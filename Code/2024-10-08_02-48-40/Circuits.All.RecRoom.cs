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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21C4740", Offset = "0x21C3940", VA = "0x1821C4740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class EDAGGAKPDDG : IDisposable, IJHBGHFENMM, PLHFHJGHAPP, HLDDBANDECM, LPMNIGCKKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class CDAFHOKCGNE : NEFFKNHDBPG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int ABMNAGKOLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21AB910", Offset = "0x21AAB10", VA = "0x1821AB910", Slot = "5")]
		public JMJIBDMBIID KHHANBMGMHL(BPIHHPPODHB.FJEJFPBMPHM LJHLMAFOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void OJCMLGECLPO();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void NHOKKKPKBKK();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21AB850", Offset = "0x21AAA50", VA = "0x1821AB850", Slot = "13")]
		public virtual void BPHHFDELPFG(EDAGGAKPDDG FEIKNINOKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21AB890", Offset = "0x21AAA90", VA = "0x1821AB890", Slot = "14")]
		public virtual void COMIKNCFAGE(EDAGGAKPDDG FEIKNINOKPC, IBMALGPEGND ECFGAICLGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected CDAFHOKCGNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NEFFKNHDBPG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int ABMNAGKOLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JMJIBDMBIID KHHANBMGMHL(BPIHHPPODHB.FJEJFPBMPHM LJHLMAFOMCA);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OJCMLGECLPO();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NHOKKKPKBKK();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BPHHFDELPFG(EDAGGAKPDDG FEIKNINOKPC);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void COMIKNCFAGE(EDAGGAKPDDG FEIKNINOKPC, IBMALGPEGND ECFGAICLGCA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BNOLPKABCGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BBLFJNEINJN<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> KPNJLGMNFCK;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x21AA6E0", Offset = "0x21A98E0", VA = "0x1821AA6E0")]
		internal BNOLPKABCGG(BBLFJNEINJN<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> JANAFGLBOCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ILMLACMHILN : LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ILMLACMHILN FAKOKDPOOAM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		private ILMLACMHILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x130D700", Offset = "0x130C900", VA = "0x18130D700", Slot = "4")]
		public OHKHJIAEKPD GBJFLKFEJMH(IBMALGPEGND AEFKHDNCNFD)
		{
			return default(OHKHJIAEKPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21BDDA0", Offset = "0x21BCFA0", VA = "0x1821BDDA0", Slot = "5")]
		public void BPHHFDELPFG(EDAGGAKPDDG LPLEFLJFGNH, IBMALGPEGND ECFGAICLGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x21BDEB0", Offset = "0x21BD0B0", VA = "0x1821BDEB0", Slot = "6")]
		public void COMIKNCFAGE(EDAGGAKPDDG LPLEFLJFGNH, IBMALGPEGND ECFGAICLGCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DKHIJEPAEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JIPBALMMOGA<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> KPNJLGMNFCK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21ADC50", Offset = "0x21ACE50", VA = "0x1821ADC50")]
		internal DKHIJEPAEGO(JIPBALMMOGA<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21ADC00", Offset = "0x21ACE00", VA = "0x1821ADC00")]
		public static DKHIJEPAEGO MIFIOLMMIDE()
		{
			return default(DKHIJEPAEGO);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct IPMGFDNKNOP : HBIMPLJEHAG.DFCICADBFEO<IBMALGPEGND, EDAGGAKPDDG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LDOGJNDMJEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public EDAGGAKPDDG receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IBMALGPEGND action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IPMGFDNKNOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x21C0230", Offset = "0x21BF430", VA = "0x1821C0230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21C0410", Offset = "0x21BF610", VA = "0x1821C0410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9E6070", Offset = "0x9E5270", VA = "0x1809E6070", Slot = "4")]
		public GJCCLPKGONN<AGPJHJICIGM> NNELMDIEPOL(EDAGGAKPDDG CDBPAMBCOAE)
		{
			return default(GJCCLPKGONN<AGPJHJICIGM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21BE280", Offset = "0x21BD480", VA = "0x1821BE280", Slot = "5")]
		[AsyncStateMachine(typeof(LDOGJNDMJEP))]
		public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> OACPMHKCACD(EDAGGAKPDDG CDBPAMBCOAE, IBMALGPEGND ECFGAICLGCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21BE260", Offset = "0x21BD460", VA = "0x1821BE260", Slot = "6")]
		public IBMALGPEGND[] FOOOIEODNKN(EDAGGAKPDDG CDBPAMBCOAE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HOKIOFMBAMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EDAGGAKPDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NBBJGCPEPPG rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public POAKEMJOLKP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public NFPGJPJJCOP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21BCD20", Offset = "0x21BBF20", VA = "0x1821BCD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21BCFA0", Offset = "0x21BC1A0", VA = "0x1821BCFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DDFEMJOOJGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EDAGGAKPDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21AC230", Offset = "0x21AB430", VA = "0x1821AC230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21AC4C0", Offset = "0x21AB6C0", VA = "0x1821AC4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LFOAGGGLPFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EDAGGAKPDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x21C09E0", Offset = "0x21BFBE0", VA = "0x1821C09E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x21C0BC0", Offset = "0x21BFDC0", VA = "0x1821C0BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LIGPJLOIAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public EDAGGAKPDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IBMALGPEGND action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21C0CA0", Offset = "0x21BFEA0", VA = "0x1821C0CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21C0E90", Offset = "0x21C0090", VA = "0x1821C0E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LOIJFKBMHKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public EDAGGAKPDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x21C39A0", Offset = "0x21C2BA0", VA = "0x1821C39A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x21C4180", Offset = "0x21C3380", VA = "0x1821C4180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GJCCLPKGONN<AGPJHJICIGM> KIIGGBAJDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BNOLPKABCGG GMDNAFJJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ANEBEJCPHMG ENFAKBGDOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly HIIOADCPIFH JGKOCIPDLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly PDMENEPAMGI DGGHAMLLEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NNKACLEGANH.FGEEBLAHFJA IINHHAGNHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JPJAJBALEEG OGBJMKDHDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly PMNCBBJIPJC HNANAKMFMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HHNECOECANL OBFLKMOAJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1990")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HMBIKHKKOJM IBILOHNFJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1998")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CEIKEIBNNBO PIEFNOJPMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GNCCLPIJMMG CLPOKNAALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly ANEBEJCPHMG.ACMINDAJBMN FEONKONGODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EBEOFFDDEEB FBKPEDFAELD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ANEBEJCPHMG OEMGKJAEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21AF770", Offset = "0x21AE970", VA = "0x1821AF770")]
		get
		{
			return default(ANEBEJCPHMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal NEFFKNHDBPG BAMFDPPLLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21AE290", Offset = "0x21AD490", VA = "0x1821AE290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JMJIBDMBIID GBGJAJLAJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21AE410", Offset = "0x21AD610", VA = "0x1821AE410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE90", Offset = "0x21AE090", VA = "0x1821AEE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EPAJOFLCAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6E0", Offset = "0x21AE8E0", VA = "0x1821AF6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21AE510", Offset = "0x21AD710", VA = "0x1821AE510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BCAHCGPDLFO BEGFBILAKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21AFA80", Offset = "0x21AEC80", VA = "0x1821AFA80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ACFCEFOJGEA FFEBLHEAPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x21AFA90", Offset = "0x21AEC90", VA = "0x1821AFA90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EDGIAIMEMBH JCNOFAAKBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21AFAB0", Offset = "0x21AECB0", VA = "0x1821AFAB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EMMBJOBALJI CCCNBJLNMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x21AFAA0", Offset = "0x21AECA0", VA = "0x1821AFAA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NNKACLEGANH? PEKGPHAEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6F0", Offset = "0x21AE8F0", VA = "0x1821AF6F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EMNGFMEJKPM? PPKFDLLOPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21AE2E0", Offset = "0x21AD4E0", VA = "0x1821AE2E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21AF780", Offset = "0x21AE980", VA = "0x1821AF780")]
	private EDAGGAKPDDG(PDMENEPAMGI IGMKHKPOAIG, GJCCLPKGONN<AGPJHJICIGM> NKKKMBMGHIH, [In] BNOLPKABCGG EGONKEEJMFG, [In] ANEBEJCPHMG LDMHJAJCKBK, [In] HIIOADCPIFH KOKJNGCFONK, JMJIBDMBIID DAGFLFLFNLI, [In] NNKACLEGANH.FGEEBLAHFJA MGDHNEDPGIE, ANEBEJCPHMG.ACMINDAJBMN GPICEDFKECA, EBEOFFDDEEB LPDPKBGPALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21AEFC0", Offset = "0x21AE1C0", VA = "0x1821AEFC0")]
	public static EDAGGAKPDDG MIFIOLMMIDE(PDMENEPAMGI LJHLMAFOMCA, [In] FOOCJHANMDF LHMPDDIHCPN, JDNABILCDAE HDLCDODHMJO, [In] DDCJHAPCJNI CJALJGLFPGH, DLKHICGKBDM KOPEDCBMDBC, GJCCLPKGONN<AGPJHJICIGM> NKKKMBMGHIH, GJCCLPKGONN<PAEHBHIKLGL> PKEHBCOLCFP, LGCMAGEOKHH LNNDAFFMAKF, OMMMOIENNFL APHJODKJJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21AF100", Offset = "0x21AE300", VA = "0x1821AF100")]
	public static EDAGGAKPDDG MIFIOLMMIDE(PDMENEPAMGI IGMKHKPOAIG, [In] ANEBEJCPHMG LDMHJAJCKBK, [In] HIIOADCPIFH KOKJNGCFONK, GJCCLPKGONN<AGPJHJICIGM> NKKKMBMGHIH, GJCCLPKGONN<PAEHBHIKLGL> PKEHBCOLCFP, LGCMAGEOKHH LNNDAFFMAKF, OMMMOIENNFL APHJODKJJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21AE520", Offset = "0x21AD720", VA = "0x1821AE520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21AE710", Offset = "0x21AD910", VA = "0x1821AE710")]
	[AsyncStateMachine(typeof(HOKIOFMBAMC))]
	internal Task<KJEOKHCIBGM<bool, IJNOPJPLCIM>> FFOEPENHMDI(NBBJGCPEPPG CFILLPNNBGA, POAKEMJOLKP AECELIKKPLN, NFPGJPJJCOP HNMCNGMNKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21AEDA0", Offset = "0x21ADFA0", VA = "0x1821AEDA0")]
	[AsyncStateMachine(typeof(DDFEMJOOJGO))]
	public Task<KJEOKHCIBGM<bool, IJNOPJPLCIM>> HPDBEMDHBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21AF3E0", Offset = "0x21AE5E0", VA = "0x1821AF3E0")]
	[AsyncStateMachine(typeof(LFOAGGGLPFH))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> MMHFACHGPGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21AF4D0", Offset = "0x21AE6D0", VA = "0x1821AF4D0")]
	internal void MNJBMFDEACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21AED20", Offset = "0x21ADF20", VA = "0x1821AED20")]
	internal BMNACOJIPCO<IBMALGPEGND> HIIIHIFAEBB([In] CIHIDAPLCLE LFHPIOCPCOD)
	{
		return default(BMNACOJIPCO<IBMALGPEGND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21AE420", Offset = "0x21AD620", VA = "0x1821AE420")]
	internal bool DCPMIAPPCFP([In] CIHIDAPLCLE LFHPIOCPCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21AE490", Offset = "0x21AD690", VA = "0x1821AE490")]
	internal BMNACOJIPCO<IBMALGPEGND> DDEJEGIEEOF([In] GDIIEGODKPI CECHBGOIDGC)
	{
		return default(BMNACOJIPCO<IBMALGPEGND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21AEEB0", Offset = "0x21AE0B0", VA = "0x1821AEEB0")]
	[AsyncStateMachine(typeof(LIGPJLOIAKL))]
	internal Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> LCMFLAOKOBA(IBMALGPEGND ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21AE870", Offset = "0x21ADA70", VA = "0x1821AE870")]
	private IBMALGPEGND[] FOOOIEODNKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21AEC00", Offset = "0x21ADE00", VA = "0x1821AEC00")]
	[AsyncStateMachine(typeof(LOIJFKBMHKM))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> GOFGEMHFFNG(Guid IMAOMKDLJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CILMNIFKAHE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C204B0", Offset = "0x2C1F6B0", VA = "0x182C204B0")]
	public static LKPPFALGGPH<(TPrev?, EDAGGAKPDDG?), EMNGFMEJKPM> LCNCFFMPFOH<TPrev>([In] this LKPPFALGGPH<TPrev, EDAGGAKPDDG> AEFKHDNCNFD)
	{
		return default(LKPPFALGGPH<(TPrev, EDAGGAKPDDG), EMNGFMEJKPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C20770", Offset = "0x2C1F970", VA = "0x182C20770")]
	public static LKPPFALGGPH<TPrev?, EDAGGAKPDDG?> LNMBFDKBJKK<TPrev>([In] this LKPPFALGGPH<TPrev, EDAGGAKPDDG> AEFKHDNCNFD)
	{
		return default(LKPPFALGGPH<TPrev, EDAGGAKPDDG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ELMMMDIJJMN<TData> : KKIKBNLICGH, MHFDALBOCHE, NDNNGNKGHFF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JFDDFNFCNKH<JKFBFCDNFMP>? AECGGJOCJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string PGKAKDMACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData OMAPODLEEDD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JFDDFNFCNKH<JKFBFCDNFMP>? DOLLJDBJJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x23F7B60", Offset = "0x23F6D60", VA = "0x1823F7B60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6520", Offset = "0x3AE5720", VA = "0x183AE6520")]
	internal ELMMMDIJJMN([In] JFDDFNFCNKH<JKFBFCDNFMP>? GMOHEKKCPOL, GJCCLPKGONN<ACHJADOJBKC>? EKMBIEEPDGA, IOKind? GGKNFFHPGFP, string ADNFLGLLNKI, [In] TData LJIEGDEDOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HHODGKBNEDN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x21BC880", Offset = "0x21BBA80", VA = "0x1821BC880")]
	public static KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE> DJIPALLIKMJ([In] this MJMJKNGFMEO<ELJNDNHODAA> HFMNHFIEDIM)
	{
		return default(KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E33FE0", Offset = "0x2E331E0", VA = "0x182E33FE0")]
	public static KJEOKHCIBGM<TOk, MHFDALBOCHE> HMCPBCBAPNC<TOk>([In] this KJEOKHCIBGM<TOk, MHFDALBOCHE> AEFKHDNCNFD, [In] JFDDFNFCNKH<JKFBFCDNFMP>? GMOHEKKCPOL, GJCCLPKGONN<ACHJADOJBKC>? EKMBIEEPDGA, IOKind? GGKNFFHPGFP, string ADNFLGLLNKI) where TOk : notnull
	{
		return default(KJEOKHCIBGM<TOk, MHFDALBOCHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PDMENEPAMGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FANCHMMAMOF.PKJKGCMANPI DKCJLLCBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BPIHHPPODHB.FJEJFPBMPHM PFPBKPEFBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EDAGGAKPDDG.NEFFKNHDBPG GGLJLABOGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	OEIIELLDBDK.ELCLOAEBPJL CMONGDILJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG> AFOGMADKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EPKPCCKMNFP JDLOMELFPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DALEGBHOIGB MMKEOIEDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DEFHLCJBIDI JJEHKOHANOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IDBPLFDAJOL EEPGNBGLJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DJBHJEHICMN FOIAMPAIBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GJHNJEBIMKN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21BBC20", Offset = "0x21BAE20", VA = "0x1821BBC20")]
	public static IBMALGPEGND FDHNMGOFGDH(this IBMALGPEGND AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21BBD30", Offset = "0x21BAF30", VA = "0x1821BBD30")]
	public static IBMALGPEGND NMOJFJJNICL(this GLHHCLGFBMP AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GLHHCLGFBMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EMBPFOJLKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EDAGGAKPDDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public GLHHCLGFBMP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21AFAC0", Offset = "0x21AECC0", VA = "0x1821AFAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x21AFD80", Offset = "0x21AEF80", VA = "0x1821AFD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString GOGBANOMEKC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	private GLHHCLGFBMP(ByteString JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21BC450", Offset = "0x21BB650", VA = "0x1821BC450")]
	public static IBMALGPEGND KOILNPNCLGH(ByteString JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21BC3A0", Offset = "0x21BB5A0", VA = "0x1821BC3A0")]
	public static NOJOABDLLEK<OHKHJIAEKPD, GLHHCLGFBMP> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, GLHHCLGFBMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x21BC510", Offset = "0x21BB710", VA = "0x1821BC510")]
	[AsyncStateMachine(typeof(EMBPFOJLKCA))]
	public static Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> LCMFLAOKOBA(EDAGGAKPDDG LPLEFLJFGNH, GLHHCLGFBMP AEFKHDNCNFD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct DGMLIHHGJDO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21ADB60", Offset = "0x21ACD60", VA = "0x1821ADB60")]
	public static IBMALGPEGND KOILNPNCLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x21ADAF0", Offset = "0x21ACCF0", VA = "0x1821ADAF0")]
	public static NOJOABDLLEK<OHKHJIAEKPD, DGMLIHHGJDO> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, DGMLIHHGJDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21ADA70", Offset = "0x21ACC70", VA = "0x1821ADA70")]
	public static KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP> BBMBAHICDII(EDAGGAKPDDG LPLEFLJFGNH, [In] DGMLIHHGJDO AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IFKGENNJCHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LAHDCFAPIDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public EDAGGAKPDDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IFKGENNJCHF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x21BF6F0", Offset = "0x21BE8F0", VA = "0x1821BF6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x21BFA60", Offset = "0x21BEC60", VA = "0x1821BFA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly NBBJGCPEPPG? BCHJDPKHCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly POAKEMJOLKP? MICLMELLDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly NFPGJPJJCOP? IBKMLIPJFMG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x20E49A0", Offset = "0x20E3BA0", VA = "0x1820E49A0")]
	private IFKGENNJCHF(NBBJGCPEPPG? CFILLPNNBGA, POAKEMJOLKP? AECELIKKPLN, NFPGJPJJCOP? HNMCNGMNKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x21BDB60", Offset = "0x21BCD60", VA = "0x1821BDB60")]
	public static IBMALGPEGND? KOILNPNCLGH(NBBJGCPEPPG? CFILLPNNBGA, POAKEMJOLKP? AECELIKKPLN, NFPGJPJJCOP? HNMCNGMNKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21BDA50", Offset = "0x21BCC50", VA = "0x1821BDA50")]
	public static NOJOABDLLEK<OHKHJIAEKPD, IFKGENNJCHF> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, IFKGENNJCHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21BDC60", Offset = "0x21BCE60", VA = "0x1821BDC60")]
	[AsyncStateMachine(typeof(LAHDCFAPIDE))]
	public static Task<KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP>> LCMFLAOKOBA(EDAGGAKPDDG LPLEFLJFGNH, IFKGENNJCHF AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct GIOBCPDMHOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct IBLAHNIDCKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GIOBCPDMHOE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EDAGGAKPDDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private KJEOKHCIBGM<object, NDNNGNKGHFF>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KJEOKHCIBGM<object, NDNNGNKGHFF> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private KJEOKHCIBGM<object, NDNNGNKGHFF>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21BD010", Offset = "0x21BC210", VA = "0x1821BD010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21BD480", Offset = "0x21BC680", VA = "0x1821BD480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<IBMALGPEGND> OHDNKHLACNE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	private GIOBCPDMHOE(IReadOnlyList<IBMALGPEGND> CHFBGJFMMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x21BBA20", Offset = "0x21BAC20", VA = "0x1821BBA20")]
	public static IBMALGPEGND KOILNPNCLGH(IReadOnlyList<IBMALGPEGND> CHFBGJFMMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21BB980", Offset = "0x21BAB80", VA = "0x1821BB980")]
	public static NOJOABDLLEK<OHKHJIAEKPD, GIOBCPDMHOE> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, GIOBCPDMHOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21BBAE0", Offset = "0x21BACE0", VA = "0x1821BBAE0")]
	[AsyncStateMachine(typeof(IBLAHNIDCKM))]
	public static Task<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> LCMFLAOKOBA(EDAGGAKPDDG LPLEFLJFGNH, GIOBCPDMHOE AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct GDIIEGODKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int HDFADKJDLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int NLHHONDOFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] OMAPODLEEDD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1F44980", Offset = "0x1F43B80", VA = "0x181F44980")]
	private GDIIEGODKPI(int NDEFEFEFLCE, int KINMHNEMPOD, byte[] LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21B07F0", Offset = "0x21AF9F0", VA = "0x1821B07F0")]
	public static IBMALGPEGND KOILNPNCLGH(int NDEFEFEFLCE, int KINMHNEMPOD, ByteString LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21B05E0", Offset = "0x21AF7E0", VA = "0x1821B05E0")]
	public static IBMALGPEGND[] FMONLICHHEG(IBMALGPEGND ECFGAICLGCA, int FPLJHJKPJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x21B0710", Offset = "0x21AF910", VA = "0x1821B0710")]
	public static NOJOABDLLEK<OHKHJIAEKPD, GDIIEGODKPI> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, GDIIEGODKPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x21B04C0", Offset = "0x21AF6C0", VA = "0x1821B04C0")]
	public static KJEOKHCIBGM<IBMALGPEGND, GDNNKDPAIAP> BBMBAHICDII(EDAGGAKPDDG LPLEFLJFGNH, [In] GDIIEGODKPI AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<IBMALGPEGND, GDNNKDPAIAP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct CIHIDAPLCLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CABPFIENLLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, GDNNKDPAIAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EDAGGAKPDDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CIHIDAPLCLE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private KJEOKHCIBGM<bool, GDNNKDPAIAP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, GDNNKDPAIAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x21AABE0", Offset = "0x21A9DE0", VA = "0x1821AABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x21AB220", Offset = "0x21AA420", VA = "0x1821AB220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int HDFADKJDLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int NLHHONDOFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] OMAPODLEEDD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F44980", Offset = "0x1F43B80", VA = "0x181F44980")]
	private CIHIDAPLCLE(int NDEFEFEFLCE, int KINMHNEMPOD, byte[] LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21ABD30", Offset = "0x21AAF30", VA = "0x1821ABD30")]
	public static IBMALGPEGND KOILNPNCLGH(int NDEFEFEFLCE, int KINMHNEMPOD, ByteString LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21ABA60", Offset = "0x21AAC60", VA = "0x1821ABA60")]
	public static IBMALGPEGND?[]? IGDAMJDMHPK(int FPLJHJKPJML, NBBJGCPEPPG? CFILLPNNBGA, POAKEMJOLKP? AECELIKKPLN, NFPGJPJJCOP? HNMCNGMNKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21ABC50", Offset = "0x21AAE50", VA = "0x1821ABC50")]
	public static NOJOABDLLEK<OHKHJIAEKPD, CIHIDAPLCLE> JJHFHBAHGJB(IBMALGPEGND BKFLIPIHHHA)
	{
		return default(NOJOABDLLEK<OHKHJIAEKPD, CIHIDAPLCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x21ABE10", Offset = "0x21AB010", VA = "0x1821ABE10")]
	[AsyncStateMachine(typeof(CABPFIENLLE))]
	public static Task<KJEOKHCIBGM<bool, GDNNKDPAIAP>> LCMFLAOKOBA(EDAGGAKPDDG LPLEFLJFGNH, CIHIDAPLCLE AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JPJAJBALEEG : BCAHCGPDLFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NKONPAPHEHJ? FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21BEFE0", Offset = "0x21BE1E0", VA = "0x1821BEFE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	internal JPJAJBALEEG(EDAGGAKPDDG FEIKNINOKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CBBNGNNIFAN : NKONPAPHEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JOLJBBEOFAN MDKCLDDFONG;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
	public CBBNGNNIFAN(EDAGGAKPDDG FEIKNINOKPC, JOLJBBEOFAN DDJNPHIHCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x21AB570", Offset = "0x21AA770", VA = "0x1821AB570", Slot = "4")]
	public KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE> PHABKIPBKKN(JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<ICEFOKPGJNF> FDFICHJDGEE)
	{
		return default(KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21AB290", Offset = "0x21AA490", VA = "0x1821AB290", Slot = "5")]
	public KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE> DOKBKFPADDD(JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<IHNEIIKOCEP> NPHLMCCFBOL)
	{
		return default(KJEOKHCIBGM<LJKAJAIACGK, MHFDALBOCHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FANCHMMAMOF : CAGNMKPFHGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface PKJKGCMANPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JOLJBBEOFAN> LIBDLMLMBMK(EDAGGAKPDDG FEIKNINOKPC, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD, CancellationToken DDNLBFLLCLM);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MJGKHJJPNHJ AHMILGOINHL(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BJADNKPCLGJ : PKJKGCMANPI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct KNHCCNFALJI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<JOLJBBEOFAN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public EDAGGAKPDDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public POAKEMJOLKP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NFPGJPJJCOP cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<OEIIELLDBDK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x21BF4B0", Offset = "0x21BE6B0", VA = "0x1821BF4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x21BF680", Offset = "0x21BE880", VA = "0x1821BF680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly BJADNKPCLGJ FAKOKDPOOAM;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		private BJADNKPCLGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x21AA510", Offset = "0x21A9710", VA = "0x1821AA510", Slot = "4")]
		[AsyncStateMachine(typeof(KNHCCNFALJI))]
		public Task<JOLJBBEOFAN> LIBDLMLMBMK(EDAGGAKPDDG FEIKNINOKPC, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD, CancellationToken DDNLBFLLCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x21AA4F0", Offset = "0x21A96F0", VA = "0x1821AA4F0", Slot = "5")]
		public MJGKHJJPNHJ AHMILGOINHL(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ICIFBGPKLLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<FANCHMMAMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EDAGGAKPDDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public POAKEMJOLKP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NFPGJPJJCOP cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NBBJGCPEPPG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private PKJKGCMANPI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<JOLJBBEOFAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x21BD4F0", Offset = "0x21BC6F0", VA = "0x1821BD4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x21BD9E0", Offset = "0x21BCBE0", VA = "0x1821BD9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JOLJBBEOFAN MDKCLDDFONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MJGKHJJPNHJ LAIFMPOEEFD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NNKACLEGANH PEKGPHAEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21B0240", Offset = "0x21AF440", VA = "0x1821B0240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EMNGFMEJKPM DOOKDKIOLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21B0180", Offset = "0x21AF380", VA = "0x1821B0180", Slot = "5")]
		get
		{
			return default(EMNGFMEJKPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CBBNGNNIFAN GMKPEFJILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CGDGCAEHEEL MCOODMGALMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA7DB40", Offset = "0xA7CD40", VA = "0x180A7DB40")]
	private FANCHMMAMOF(JOLJBBEOFAN DDJNPHIHCDH, MJGKHJJPNHJ OMBJLPMAAJE, CBBNGNNIFAN MJDELNKLJNK, CGDGCAEHEEL KENCJJDECAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21B0010", Offset = "0x21AF210", VA = "0x1821B0010")]
	[AsyncStateMachine(typeof(ICIFBGPKLLL))]
	public static Task<FANCHMMAMOF> FFCDDEAGMDA(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x21AFFB0", Offset = "0x21AF1B0", VA = "0x1821AFFB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BPIHHPPODHB : JMJIBDMBIID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface FJEJFPBMPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CAGNMKPFHGF> AMFLJMOMPON(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD, CancellationToken DDNLBFLLCLM);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MIDHPPAAOPE();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JLPGPOMCHCE();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class IMIMEIMHODJ : FJEJFPBMPHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct DKPFIKOKBMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<CAGNMKPFHGF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public EDAGGAKPDDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public NBBJGCPEPPG evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public POAKEMJOLKP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public NFPGJPJJCOP cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<FANCHMMAMOF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x21ADC60", Offset = "0x21ACE60", VA = "0x1821ADC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x21ADFA0", Offset = "0x21AD1A0", VA = "0x1821ADFA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x21BE100", Offset = "0x21BD300", VA = "0x1821BE100", Slot = "4")]
		[AsyncStateMachine(typeof(DKPFIKOKBMP))]
		public Task<CAGNMKPFHGF> AMFLJMOMPON(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD, CancellationToken DDNLBFLLCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MIDHPPAAOPE();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JLPGPOMCHCE();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected IMIMEIMHODJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct CMOGDELIDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<CAGNMKPFHGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BPIHHPPODHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<EPFCCNCFAEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x21ABF40", Offset = "0x21AB140", VA = "0x1821ABF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x21AC140", Offset = "0x21AB340", VA = "0x1821AC140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GKLPKKJIBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BPIHHPPODHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public EDAGGAKPDDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NBBJGCPEPPG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public POAKEMJOLKP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NFPGJPJJCOP cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<CAGNMKPFHGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x21BBE00", Offset = "0x21BB000", VA = "0x1821BBE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x21BC340", Offset = "0x21BB540", VA = "0x1821BC340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FJEJFPBMPHM LPKKIADABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<EPFCCNCFAEJ> LEMHHBKNPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<EPFCCNCFAEJ> CKFPKICIANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource KONJLANGNJG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool EPAJOFLCAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC92370", VA = "0x180C93170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD92370", Offset = "0xD91570", VA = "0x180D92370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LDONACDLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x901A00", Offset = "0x900C00", VA = "0x180901A00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD92350", Offset = "0xD91550", VA = "0x180D92350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LOEBLEBLEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x13B7740", Offset = "0x13B6940", VA = "0x1813B7740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x21AAAC0", Offset = "0x21A9CC0", VA = "0x1821AAAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public CAGNMKPFHGF? MANBGMDABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x21AA870", Offset = "0x21A9A70", VA = "0x1821AA870", Slot = "7")]
	[AsyncStateMachine(typeof(CMOGDELIDBK))]
	public Task<CAGNMKPFHGF> GGJAJGLJJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x21AAAD0", Offset = "0x21A9CD0", VA = "0x1821AAAD0")]
	public BPIHHPPODHB(FJEJFPBMPHM LJHLMAFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x21AA960", Offset = "0x21A9B60", VA = "0x1821AA960", Slot = "8")]
	[AsyncStateMachine(typeof(GKLPKKJIBKB))]
	public Task HEKLPNCOFPL(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21AA6F0", Offset = "0x21A98F0", VA = "0x1821AA6F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LDDLDCKFJEL : BFBHFOFCDAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly CGDGCAEHEEL CGDIAJPACMH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public LDDLDCKFJEL(CGDGCAEHEEL KENCJJDECAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DPJKPALKHKL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class ALKEGPFKAJA<TGraph> : JKKGEHGGKGE where TGraph : GMCDLDCGJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph CNLPPHNCBEG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual IKNFCDFLDMP? ECJKBICLDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x11E7C90", Offset = "0x11E6E90", VA = "0x1811E7C90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public GJCCLPKGONN<EJPHCCLFAJF> LAGDFJGMEAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3FA9390", Offset = "0x3FA8590", VA = "0x183FA9390", Slot = "5")]
			get
			{
				return default(GJCCLPKGONN<EJPHCCLFAJF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public GJCCLPKGONN<EJPHCCLFAJF>? DJKCKINDHCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3FA9310", Offset = "0x3FA8510", VA = "0x183FA9310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		public ALKEGPFKAJA(TGraph LMEHCBGAMFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JJMJAABAPBM : ALKEGPFKAJA<FHABHGEOIIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override IKNFCDFLDMP? ECJKBICLDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x21BEEF0", Offset = "0x21BE0F0", VA = "0x1821BEEF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x21BEF10", Offset = "0x21BE110", VA = "0x1821BEF10")]
		public JJMJAABAPBM(FHABHGEOIIA OCPJLBHPNGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x21AE100", Offset = "0x21AD300", VA = "0x1821AE100")]
	public static JKKGEHGGKGE MIFIOLMMIDE(GMCDLDCGJGB LMEHCBGAMFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LNDGGDLFKNJ : NKKIPAJHCAJ, FAAIJHFGPMB, POPNOIEKCJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DNIJKBHOAIO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public DNIJKBHOAIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public EPKPCCKMNFP errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x21C69F0", Offset = "0x21C5BF0", VA = "0x1821C69F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21C6C60", Offset = "0x21C5E60", VA = "0x1821C6C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LNDGGDLFKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DNIJKBHOAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x21AE010", Offset = "0x21AD210", VA = "0x1821AE010")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task PNNJHAGKCJG(EPKPCCKMNFP errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LFGBMFEFPDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LNDGGDLFKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x21C0480", Offset = "0x21BF680", VA = "0x1821C0480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x21C0980", Offset = "0x21BFB80", VA = "0x1821C0980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IMBHGGIJDOP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public IMBHGGIJDOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x21C6CC0", Offset = "0x21C5EC0", VA = "0x1821C6CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x21C6FA0", Offset = "0x21C61A0", VA = "0x1821C6FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LNDGGDLFKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IMBHGGIJDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x21BE030", Offset = "0x21BD230", VA = "0x1821BE030")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task PNIDJICNACE(EPKPCCKMNFP errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JONGHNMOEEB BPDBNCMPPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<DNKCJIAEMHI> IIEPLMMLOOE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private PDMENEPAMGI FJJPJEBEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x21C1E20", Offset = "0x21C1020", VA = "0x1821C1E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GJCCLPKGONN<ICEFOKPGJNF> EJPHOOPBCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA20160", Offset = "0xA1F360", VA = "0x180A20160", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(GJCCLPKGONN<ICEFOKPGJNF>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA21450", Offset = "0xA20650", VA = "0x180A21450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private GJCCLPKGONN<NFIAEODBBMM> NJIJLBEDOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD90FA0", Offset = "0xD901A0", VA = "0x180D90FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public GJCCLPKGONN<BLNNADLBCOP> LDPLBHAMHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC50", Offset = "0x8BBE50", VA = "0x1808BCC50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(GJCCLPKGONN<BLNNADLBCOP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override GJCCLPKGONN<ACHJADOJBKC> JBCFBHPLBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x21C29F0", Offset = "0x21C1BF0", VA = "0x1821C29F0", Slot = "20")]
		get
		{
			return default(GJCCLPKGONN<ACHJADOJBKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DMGFBBKLGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x21C0FB0", Offset = "0x21C01B0", VA = "0x1821C0FB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x21C3780", Offset = "0x21C2980", VA = "0x1821C3780")]
	private LNDGGDLFKNJ(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO, JONGHNMOEEB BAELNDDADMG, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<ICEFOKPGJNF> FDFICHJDGEE, GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA, bool MPLNGLKJBPE, string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x21C2DB0", Offset = "0x21C1FB0", VA = "0x1821C2DB0")]
	public static LNDGGDLFKNJ MIFIOLMMIDE(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO, JONGHNMOEEB GJDJIDOLBAE, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA, GJCCLPKGONN<ICEFOKPGJNF> FDFICHJDGEE, bool MPLNGLKJBPE, bool PJGLOKHODBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x21C1030", Offset = "0x21C0230", VA = "0x1821C1030", Slot = "21")]
	protected override void DDNLIMMJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x21C10D0", Offset = "0x21C02D0", VA = "0x1821C10D0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x21C3450", Offset = "0x21C2650", VA = "0x1821C3450", Slot = "30")]
	public void OHOICNFBEGC(DNKCJIAEMHI GBLHECHDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x21C2A40", Offset = "0x21C1C40", VA = "0x1821C2A40", Slot = "27")]
	public void MFBCBFIEJBP(CLFADNPJJAN ENDEHCENCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x21C1170", Offset = "0x21C0370", VA = "0x1821C1170", Slot = "28")]
	public void EFFPEHIOBLL(MBNJJJGGMCG BOBDKLFIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21C3230", Offset = "0x21C2430", VA = "0x1821C3230", Slot = "23")]
	protected override void NDBLAJNHEHK(ILGLFEOFNBL AICPONKAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x21C1CC0", Offset = "0x21C0EC0", VA = "0x1821C1CC0", Slot = "32")]
	public string FJOOHGGFMLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x21C25E0", Offset = "0x21C17E0", VA = "0x1821C25E0", Slot = "29")]
	public string KKLDHLCHMGP(int HMDMPLFHGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x21C1EC0", Offset = "0x21C10C0", VA = "0x1821C1EC0")]
	private void HKGCFDCDNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x21C20E0", Offset = "0x21C12E0", VA = "0x1821C20E0", Slot = "31")]
	public void IAHIIAKGKPD(DNKCJIAEMHI GBLHECHDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x21C35C0", Offset = "0x21C27C0", VA = "0x1821C35C0")]
	private void PEPPLJAHFDA(bool JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21C1B10", Offset = "0x21C0D10", VA = "0x1821C1B10", Slot = "33")]
	[AsyncStateMachine(typeof(LFGBMFEFPDB))]
	public Task EJDDPFHELFP(string JECHHBGMFLN, bool JIIPGGPGADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x21C28A0", Offset = "0x21C1AA0", VA = "0x1821C28A0")]
	public void LECNJFCGJHD(string JECHHBGMFLN, bool JIIPGGPGADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x21C23C0", Offset = "0x21C15C0", VA = "0x1821C23C0")]
	private void KEOFEOFBPLF(int JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA21450", Offset = "0xA20650", VA = "0x180A21450")]
	internal void MACGOGMAOOI(GJCCLPKGONN<ICEFOKPGJNF> JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21C1C20", Offset = "0x21C0E20", VA = "0x1821C1C20")]
	[CompilerGenerated]
	private void FAGNFDMFCDO(string JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x21C21A0", Offset = "0x21C13A0", VA = "0x1821C21A0")]
	[CompilerGenerated]
	private bool JBEEGCOGEAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x21C3500", Offset = "0x21C2700", VA = "0x1821C3500")]
	[CompilerGenerated]
	private bool PAGANCKNJGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x21C0F60", Offset = "0x21C0160", VA = "0x1821C0F60")]
	[CompilerGenerated]
	private int ICCHCAOIEMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21C2330", Offset = "0x21C1530", VA = "0x1821C2330")]
	[CompilerGenerated]
	private bool JOBLKFANIIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21C3380", Offset = "0x21C2580", VA = "0x1821C3380")]
	[CompilerGenerated]
	private void NEGGAHFCKLK(string JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21C3390", Offset = "0x21C2590", VA = "0x1821C3390")]
	[CompilerGenerated]
	private bool OHBIPBFILHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x21C34B0", Offset = "0x21C26B0", VA = "0x1821C34B0")]
	[CompilerGenerated]
	private bool OLJPGBILCPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21C1C30", Offset = "0x21C0E30", VA = "0x1821C1C30")]
	[CompilerGenerated]
	private bool FHHECIBHONI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21C0F60", Offset = "0x21C0160", VA = "0x1821C0F60")]
	[CompilerGenerated]
	private int AIHPMOFHHEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21C3160", Offset = "0x21C2360", VA = "0x1821C3160")]
	[CompilerGenerated]
	private bool NBPGFAOANDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x21C1E40", Offset = "0x21C1040", VA = "0x1821C1E40")]
	[CompilerGenerated]
	private object GBHEPPNBANM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x21C2560", Offset = "0x21C1760", VA = "0x1821C2560")]
	[CompilerGenerated]
	private void KGACHFOAPOH(object JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21C2260", Offset = "0x21C1460", VA = "0x1821C2260")]
	[CompilerGenerated]
	private bool JBHKCMBNGGK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DEMLMPNOONK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class LLPNDAEHCLC : MBHLAECKHMG<JPIJDKJCFPF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override ALNLJNEDEAK KHDJGOLOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9CE470", Offset = "0x9CD670", VA = "0x1809CE470", Slot = "126")]
			get
			{
				return default(ALNLJNEDEAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x21C0F00", Offset = "0x21C0100", VA = "0x1821C0F00")]
		public LLPNDAEHCLC(EDAGGAKPDDG FEIKNINOKPC, JPIJDKJCFPF JANAFGLBOCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class GGBAGBKACKM : APNAIIJKFII<FCGNPGNPANH>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x21BB910", Offset = "0x21BAB10", VA = "0x1821BB910")]
		public GGBAGBKACKM(EDAGGAKPDDG FEIKNINOKPC, FCGNPGNPANH MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x21BB740", Offset = "0x21BA940", VA = "0x1821BB740", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x21BB8C0", Offset = "0x21BAAC0", VA = "0x1821BB8C0")]
		[CompilerGenerated]
		private bool MGNBCKNOLAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x21BB620", Offset = "0x21BA820", VA = "0x1821BB620")]
		[CompilerGenerated]
		private void BNMNMHNAPDN(bool JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class NBKMGMBMFEB : APNAIIJKFII<KAADNPICOMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class HCEMAIJLJDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public NBKMGMBMFEB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public HCEMAIJLJDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x21BC6C0", Offset = "0x21BB8C0", VA = "0x1821BC6C0")]
			internal void KGCPFDDPLHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x21BC830", Offset = "0x21BBA30", VA = "0x1821BC830")]
			internal bool NGJPHKCEHLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x21BC670", Offset = "0x21BB870", VA = "0x1821BC670")]
			internal bool HPGIFPPDCIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x21BC710", Offset = "0x21BB910", VA = "0x1821BC710")]
			internal void LKMAJLJJKFG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x21BC620", Offset = "0x21BB820", VA = "0x1821BC620")]
			internal bool ABHDPKLANKF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x21C46D0", Offset = "0x21C38D0", VA = "0x1821C46D0")]
		public NBKMGMBMFEB(EDAGGAKPDDG FEIKNINOKPC, KAADNPICOMJ MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x21C4390", Offset = "0x21C3590", VA = "0x1821C4390", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AEMIMKOMGJK : APNAIIJKFII<ODCLHADAOAM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class LBCJBFHMPHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public AEMIMKOMGJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LBCJBFHMPHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x21BFE90", Offset = "0x21BF090", VA = "0x1821BFE90")]
			internal object KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21BFB90", Offset = "0x21BED90", VA = "0x1821BFB90")]
			internal bool DJFJMPCCJBA(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x21BFFE0", Offset = "0x21BF1E0", VA = "0x1821BFFE0")]
			internal void NGJPHKCEHLB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x21BFD30", Offset = "0x21BEF30", VA = "0x1821BFD30")]
			internal string HPGIFPPDCIC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x21BFF90", Offset = "0x21BF190", VA = "0x1821BFF90")]
			internal IReadOnlyList<object> LKMAJLJJKFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x21BFAD0", Offset = "0x21BECD0", VA = "0x1821BFAD0")]
			internal bool ABHDPKLANKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x21BFB40", Offset = "0x21BED40", VA = "0x1821BFB40")]
			internal bool DGIJEHPALPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x21BFC10", Offset = "0x21BEE10", VA = "0x1821BFC10")]
			internal void EBEBKGPNMMF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21AA480", Offset = "0x21A9680", VA = "0x1821AA480")]
		public AEMIMKOMGJK(EDAGGAKPDDG FEIKNINOKPC, ODCLHADAOAM MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x21A9D30", Offset = "0x21A8F30", VA = "0x1821A9D30", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KDGKMEKBGGE : APNAIIJKFII<BHDPKMLCIMM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class ENNHAPEAPPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KDGKMEKBGGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public ENNHAPEAPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21AFE40", Offset = "0x21AF040", VA = "0x1821AFE40")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x21AFE90", Offset = "0x21AF090", VA = "0x1821AFE90")]
			internal void NGJPHKCEHLB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x21AFDF0", Offset = "0x21AEFF0", VA = "0x1821AFDF0")]
			internal bool HPGIFPPDCIC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x21BF440", Offset = "0x21BE640", VA = "0x1821BF440")]
		public KDGKMEKBGGE(EDAGGAKPDDG FEIKNINOKPC, BHDPKMLCIMM MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x21BF210", Offset = "0x21BE410", VA = "0x1821BF210", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class LNCFCHDFKND<TNode> : APNAIIJKFII<TNode> where TNode : notnull, GCEEBAGKHHE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct CKAHMPFBFJD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public LNCFCHDFKND<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x57C7C60", Offset = "0x57C6E60", VA = "0x1857C7C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x57C8050", Offset = "0x57C7250", VA = "0x1857C8050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CNEHOLNGLPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public LNCFCHDFKND<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x57CC8E0", Offset = "0x57CBAE0", VA = "0x1857CC8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x57CCCD0", Offset = "0x57CBED0", VA = "0x1857CCCD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool LNCHFFIAMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override GJCCLPKGONN<PNDOEKJDHKD>? KMEAIAFFGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x45659A0", Offset = "0x4564BA0", VA = "0x1845659A0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4565950", Offset = "0x4564B50", VA = "0x184565950")]
		protected LNCFCHDFKND(EDAGGAKPDDG FEIKNINOKPC, TNode MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4565540", Offset = "0x4564740", VA = "0x184565540", Slot = "100")]
		[AsyncStateMachine(typeof(LNCFCHDFKND<>.CKAHMPFBFJD))]
		public override Task<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> CPEKAPDODCI(string EPPPGDEIJCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4565660", Offset = "0x4564860", VA = "0x184565660", Slot = "124")]
		public sealed override bool HBEJFAJEKOG(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x45658B0", Offset = "0x4564AB0", VA = "0x1845658B0", Slot = "112")]
		protected sealed override bool POGFJAEOBMC(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4565700", Offset = "0x4564900", VA = "0x184565700", Slot = "113")]
		protected override bool HMGOGGLIMEM(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x45657A0", Offset = "0x45649A0", VA = "0x1845657A0", Slot = "101")]
		[AsyncStateMachine(typeof(LNCFCHDFKND<>.CNEHOLNGLPE))]
		public override Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> PAOGCBMBOGF(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class PCBBNFAEEGH : DLLLGOBGCHM<MACFHKFOICB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MBFIAJACBOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public PCBBNFAEEGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public MBFIAJACBOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x21C41F0", Offset = "0x21C33F0", VA = "0x1821C41F0")]
			internal bool GMEEHBALEMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x21C4270", Offset = "0x21C3470", VA = "0x1821C4270")]
			internal void LOBDCEFFOEJ(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x21C68B0", Offset = "0x21C5AB0", VA = "0x1821C68B0")]
		public PCBBNFAEEGH(EDAGGAKPDDG FEIKNINOKPC, MACFHKFOICB JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x21C6660", Offset = "0x21C5860", VA = "0x1821C6660", Slot = "126")]
		protected override void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class MHKECMECLNI : PBFGDBGFPGM<JLCEHCCECNF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x21C4330", Offset = "0x21C3530", VA = "0x1821C4330")]
		public MHKECMECLNI(EDAGGAKPDDG FEIKNINOKPC, JLCEHCCECNF MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class PBFGDBGFPGM<TNode> : APNAIIJKFII<TNode> where TNode : notnull, JLDBLCDONKF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct FMBDDCDKFLL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC600", Offset = "0x3EAB800", VA = "0x183EAC600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3EACA90", Offset = "0x3EABC90", VA = "0x183EACA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct LACABKKCIHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x452B2B0", Offset = "0x452A4B0", VA = "0x18452B2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x452B720", Offset = "0x452A920", VA = "0x18452B720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct NNPDEDEDCND : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x48673B0", Offset = "0x48665B0", VA = "0x1848673B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x48679F0", Offset = "0x4866BF0", VA = "0x1848679F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class HPECMPNLHOG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public HPECMPNLHOG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3822DB0", Offset = "0x3821FB0", VA = "0x183822DB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public IOAPGBAGAAA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public HPECMPNLHOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4054A70", Offset = "0x4053C70", VA = "0x184054A70")]
			internal bool EBEBKGPNMMF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4054B50", Offset = "0x4053D50", VA = "0x184054B50")]
			internal void KGCPFDDPLHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x40549D0", Offset = "0x4053BD0", VA = "0x1840549D0")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.HPECMPNLHOG.<<BuildConfigMenuInternal>b__7>d))]
			internal void DJFJMPCCJBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4054E20", Offset = "0x4054020", VA = "0x184054E20")]
			internal bool NGJPHKCEHLB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class LIBLAMMDGAI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public LIBLAMMDGAI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x3822A40", Offset = "0x3821C40", VA = "0x183822A40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public HPECMPNLHOG CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LIBLAMMDGAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4555880", Offset = "0x4554A80", VA = "0x184555880")]
			internal void HPGIFPPDCIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			internal string LKMAJLJJKFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			internal void ABHDPKLANKF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x45557E0", Offset = "0x45549E0", VA = "0x1845557E0")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.LIBLAMMDGAI.<<BuildConfigMenuInternal>b__5>d))]
			internal void DGIJEHPALPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class JILMHONFFBE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public JILMHONFFBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x3822570", Offset = "0x3821770", VA = "0x183822570", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public JILMHONFFBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<NFIAEODBBMM>, IJNOPJPLCIM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3822750", Offset = "0x3821950", VA = "0x183822750", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public JILMHONFFBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<CGLJCKEDIBG>, IJNOPJPLCIM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3821EC0", Offset = "0x38210C0", VA = "0x183821EC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public IOAPGBAGAAA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public CGCNPKFOLDI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public FPBHJJDNMNB selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<HADLAOCLOCM> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public FPBHJJDNMNB selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<HADLAOCLOCM> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public JILMHONFFBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4361110", Offset = "0x4360310", VA = "0x184361110")]
			internal bool KCIMFGEBBNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4360C00", Offset = "0x435FE00", VA = "0x184360C00")]
			internal void DBKHBODMBFJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x43611F0", Offset = "0x43603F0", VA = "0x1843611F0")]
			internal bool LBMBJAOMHBH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x43612D0", Offset = "0x43604D0", VA = "0x1843612D0")]
			internal bool NIPCOHDCHNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4361070", Offset = "0x4360270", VA = "0x184361070")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.JILMHONFFBE.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void IEMGAHJEFBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4360B60", Offset = "0x435FD60", VA = "0x184360B60")]
			internal bool BOMKKNLFLKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4361310", Offset = "0x4360510", VA = "0x184361310")]
			internal void OFKINMFBMLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4360FC0", Offset = "0x43601C0", VA = "0x184360FC0")]
			internal bool HMFGGKDLJNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4360E90", Offset = "0x4360090", VA = "0x184360E90")]
			internal void GCKOCDBFCPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4360AB0", Offset = "0x435FCB0", VA = "0x184360AB0")]
			internal bool BOAIOLLJDNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4361180", Offset = "0x4360380", VA = "0x184361180")]
			internal bool KCPPOOKJJOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4360E20", Offset = "0x4360020", VA = "0x184360E20")]
			internal void FKMJNLAKECG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4360D80", Offset = "0x435FF80", VA = "0x184360D80")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.JILMHONFFBE.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void FEBOFPDMENJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x43613D0", Offset = "0x43605D0", VA = "0x1843613D0")]
			internal bool PIGEBMJMLLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4360F50", Offset = "0x4360150", VA = "0x184360F50")]
			internal bool HLHOBEOIHFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4360C70", Offset = "0x435FE70", VA = "0x184360C70")]
			internal void DMALCPJBFKJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4360CE0", Offset = "0x435FEE0", VA = "0x184360CE0")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.JILMHONFFBE.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void EBPDKBAGKJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4360BA0", Offset = "0x435FDA0", VA = "0x184360BA0")]
			internal bool CPACONBJACJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class GCFKOOHLLMA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public GCFKOOHLLMA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x38221B0", Offset = "0x38213B0", VA = "0x1838221B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public JILMHONFFBE CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GCFKOOHLLMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3F5AC80", Offset = "0x3F59E80", VA = "0x183F5AC80")]
			internal void HIHKPIMGKND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			internal string PPFEAMFPLLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			internal void EAPLNHCEFNC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3F5B090", Offset = "0x3F5A290", VA = "0x183F5B090")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.GCFKOOHLLMA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void IAOIMPFPDKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class LBOFIGONDBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public CGCNPKFOLDI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<HADLAOCLOCM> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public PBFGDBGFPGM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LBOFIGONDBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4532BE0", Offset = "0x4531DE0", VA = "0x184532BE0")]
			internal bool OLDEJADAFAB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class LPJAPDHAFEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public POPNOIEKCJO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public LBOFIGONDBF CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LPJAPDHAFEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x45715E0", Offset = "0x45707E0", VA = "0x1845715E0")]
			internal void CLDEOKBEAJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4571750", Offset = "0x4570950", VA = "0x184571750")]
			internal bool LMMLOGENLBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x45717A0", Offset = "0x45709A0", VA = "0x1845717A0")]
			internal void NEMDJLJNKLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x45716F0", Offset = "0x45708F0", VA = "0x1845716F0")]
			internal bool LBGLFCHFFAA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class EFAIOPEKJJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public HADLAOCLOCM portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public LPJAPDHAFEF CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public EFAIOPEKJJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3ACE2D0", Offset = "0x3ACD4D0", VA = "0x183ACE2D0")]
			internal void JGOJNEMMBOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class GLEEOEPFHBK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public GLEEOEPFHBK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x38241E0", Offset = "0x38233E0", VA = "0x1838241E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public FPBHJJDNMNB selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public CGCNPKFOLDI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public POPNOIEKCJO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GLEEOEPFHBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3FC56E0", Offset = "0x3FC48E0", VA = "0x183FC56E0")]
			internal int DBNFJBCNMIB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3FC54A0", Offset = "0x3FC46A0", VA = "0x183FC54A0")]
			internal void AAKHBFCHLFH(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0")]
			internal string LEHNNOBCJAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5720", Offset = "0x3FC4920", VA = "0x183FC5720")]
			[AsyncStateMachine(typeof(PBFGDBGFPGM<>.GLEEOEPFHBK.<<CreatePortItemV2>b__3>d))]
			internal void GLDJJFKIOJD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3FC57E0", Offset = "0x3FC49E0", VA = "0x183FC57E0")]
			internal bool KPPEOCOCCJH(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> DPFCDAGJEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> EADKNJIDPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> KMFKPDNHBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> GFKJFKLHEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> BALJGCEBJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<GJCCLPKGONN<PNDOEKJDHKD>, bool> NIEHEPCCPHB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FBKHNMIBDLG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool FFNEJFPEHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool LIGAHHPJDBD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool LGCDELHIDGI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override GJCCLPKGONN<EJPHCCLFAJF>? MOKNHELLBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4A81290", Offset = "0x4A80490", VA = "0x184A81290", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override GJCCLPKGONN<PNDOEKJDHKD>? KMEAIAFFGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4A81550", Offset = "0x4A80750", VA = "0x184A81550", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<JFDDFNFCNKH<JKFBFCDNFMP>>? NHGAAONFIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4A81350", Offset = "0x4A80550", VA = "0x184A81350", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4A81070", Offset = "0x4A80270", VA = "0x184A81070")]
		public PBFGDBGFPGM(EDAGGAKPDDG FEIKNINOKPC, TNode MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "129")]
		protected virtual bool CJGBNEOLBEH(int PKHADPCDPPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "130")]
		protected virtual bool ELKGCCCAENB(int PKHADPCDPPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "131")]
		protected virtual bool OIJFJIMMACP(int PKHADPCDPPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "132")]
		protected virtual void HKJEGLNBCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4A7DD30", Offset = "0x4A7CF30", VA = "0x184A7DD30", Slot = "124")]
		public override bool HBEJFAJEKOG(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A7CA70", Offset = "0x4A7BC70", VA = "0x184A7CA70", Slot = "100")]
		[AsyncStateMachine(typeof(PBFGDBGFPGM<>.FMBDDCDKFLL))]
		public override Task<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> CPEKAPDODCI(string EPPPGDEIJCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4A7F4F0", Offset = "0x4A7E6F0", VA = "0x184A7F4F0", Slot = "101")]
		[AsyncStateMachine(typeof(PBFGDBGFPGM<>.LACABKKCIHF))]
		public override Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> PAOGCBMBOGF(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A7CE80", Offset = "0x4A7C080", VA = "0x184A7CE80", Slot = "102")]
		public override void FICGGMACIGB(GJCCLPKGONN<PNDOEKJDHKD> KINMHNEMPOD, GJCCLPKGONN<PNDOEKJDHKD> LCMBJJGJCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D080", Offset = "0x4A7C280", VA = "0x184A7D080", Slot = "103")]
		public override IEnumerable<IBMALGPEGND> GFHHGMDPOID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4A7CD80", Offset = "0x4A7BF80", VA = "0x184A7CD80")]
		[AsyncStateMachine(typeof(PBFGDBGFPGM<>.NNPDEDEDCND))]
		private Task<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> FCCHMKNNBLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "133")]
		protected virtual bool AMJIGAPNJND(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "134")]
		protected virtual bool HDKLEKAJAHF(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "135")]
		protected virtual bool OBPEMLOJKFC(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "136")]
		protected virtual bool IPPDHGAKKFK(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "137")]
		protected virtual bool KMIHHJLJOFE(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int AMALFFCODNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "138")]
		protected virtual bool IMBBNAGJFMM(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int AMALFFCODNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "139")]
		protected virtual bool NNAKOHCJNKC(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int AHJNGFBCLPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "140")]
		protected virtual bool LHOCENHBKNM(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int AHJNGFBCLPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "141")]
		protected virtual bool OEEHOFBFOIP(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int NHOEEIGKLHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "142")]
		protected virtual bool BGODLMLGJHH(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, int PMOHOGGCKDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4A7C7E0", Offset = "0x4A7B9E0", VA = "0x184A7C7E0", Slot = "143")]
		protected virtual List<FPBHJJDNMNB> BFBBJDDNMJM(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "144")]
		protected virtual void LOAHJHIIKDO(IOAPGBAGAAA MHGCHDPGHAI, PNNOHIOGLLO DJHCHGCPADL, CGCNPKFOLDI FFGBAENDNOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D2E0", Offset = "0x4A7C4E0", VA = "0x184A7D2E0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4A7DDD0", Offset = "0x4A7CFD0", VA = "0x184A7DDD0")]
		private PNNOHIOGLLO IHABPANBEEK(IOAPGBAGAAA MHGCHDPGHAI, CGCNPKFOLDI FFGBAENDNOL, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4A7F600", Offset = "0x4A7E800", VA = "0x184A7F600")]
		private List<HADLAOCLOCM> PBIAKNEOCJJ(IOAPGBAGAAA MHGCHDPGHAI, CGCNPKFOLDI FFGBAENDNOL, PNNOHIOGLLO KDOHFGNPGDH, bool IKILLKMDKCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4A80730", Offset = "0x4A7F930", VA = "0x184A80730")]
		private List<HADLAOCLOCM> PFOANLFEPEC(IOAPGBAGAAA MHGCHDPGHAI, CGCNPKFOLDI FFGBAENDNOL, POPNOIEKCJO EOAIGCCJHHM, bool IKILLKMDKCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4A7CB90", Offset = "0x4A7BD90", VA = "0x184A7CB90")]
		private FPBHJJDNMNB EKDEJDEHLEF(List<FPBHJJDNMNB> AIKHIPNAHGE, POPNOIEKCJO EOAIGCCJHHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4A7C750", Offset = "0x4A7B950", VA = "0x184A7C750")]
		[CompilerGenerated]
		private IBMALGPEGND AMKCJFGBNJN(MNIIIHLJBIO ABKDFEIGMDF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class FBLKBAOBJKF : APNAIIJKFII<MHFENGPFAOD>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class POFBOHAJKPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public FBLKBAOBJKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public POFBOHAJKPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x21C6910", Offset = "0x21C5B10", VA = "0x1821C6910")]
			internal int KGCPFDDPLHF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x21C6960", Offset = "0x21C5B60", VA = "0x1821C6960")]
			internal void NGJPHKCEHLB(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x21B0450", Offset = "0x21AF650", VA = "0x1821B0450")]
		public FBLKBAOBJKF(EDAGGAKPDDG FEIKNINOKPC, MHFENGPFAOD MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x21B0290", Offset = "0x21AF490", VA = "0x1821B0290", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class ABBPMHLGBBK : DLLLGOBGCHM<LAOHFNHMADL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class KAIDABDBODM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public ABBPMHLGBBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public KAIDABDBODM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x21BF0F0", Offset = "0x21BE2F0", VA = "0x1821BF0F0")]
			internal int GMEEHBALEMH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x21BF170", Offset = "0x21BE370", VA = "0x1821BF170")]
			internal void LOBDCEFFOEJ(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x21A9CD0", Offset = "0x21A8ED0", VA = "0x1821A9CD0")]
		public ABBPMHLGBBK(EDAGGAKPDDG FEIKNINOKPC, LAOHFNHMADL JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x21A9A90", Offset = "0x21A8C90", VA = "0x1821A9A90", Slot = "126")]
		protected override void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class LIBDJPAFJDM : APNAIIJKFII<DFBBBHLCBLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB438A0", Offset = "0xB42AA0", VA = "0x180B438A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x21C0C30", Offset = "0x21BFE30", VA = "0x1821C0C30")]
		public LIBDJPAFJDM(EDAGGAKPDDG FEIKNINOKPC, DFBBBHLCBLJ MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class OJJJDHMLPJH : APNAIIJKFII<IFGNMBDCALK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GDPPCKLHLEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public OJJJDHMLPJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public IOAPGBAGAAA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GDPPCKLHLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x21B35D0", Offset = "0x21B27D0", VA = "0x1821B35D0")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x21BA840", Offset = "0x21B9A40", VA = "0x1821BA840")]
			internal void NGJPHKCEHLB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x21B0920", Offset = "0x21AFB20", VA = "0x1821B0920")]
			internal bool ABHDPKLANKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x21B17B0", Offset = "0x21B09B0", VA = "0x1821B17B0")]
			internal bool DGIJEHPALPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x21B19B0", Offset = "0x21B0BB0", VA = "0x1821B19B0")]
			internal void EBEBKGPNMMF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x21BAC80", Offset = "0x21B9E80", VA = "0x1821BAC80")]
			internal bool OCFLHINKJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x21B1040", Offset = "0x21B0240", VA = "0x1821B1040")]
			internal bool CLAANLLCIJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x21B0A70", Offset = "0x21AFC70", VA = "0x1821B0A70")]
			internal void AFKMDJIIPHP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x21B1F90", Offset = "0x21B1190", VA = "0x1821B1F90")]
			internal bool FMGLOPGFCIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x21B1CF0", Offset = "0x21B0EF0", VA = "0x1821B1CF0")]
			internal bool FIBOGDNMPHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x21BA460", Offset = "0x21B9660", VA = "0x1821BA460")]
			internal void MFFDAJHFBAK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x21B0C10", Offset = "0x21AFE10", VA = "0x1821B0C10")]
			internal bool APPCOGGDEAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x21B24F0", Offset = "0x21B16F0", VA = "0x1821B24F0")]
			internal bool HNGGEOJMDAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x21B2110", Offset = "0x21B1310", VA = "0x1821B2110")]
			internal bool GFNJEIGIOCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x21BB160", Offset = "0x21BA360", VA = "0x1821BB160")]
			internal bool PGEJJFLFNHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x21B26A0", Offset = "0x21B18A0", VA = "0x1821B26A0")]
			internal bool IBMPOOEADCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x21BAB90", Offset = "0x21B9D90", VA = "0x1821BAB90")]
			internal bool NOKEJKEKENL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x21B1E30", Offset = "0x21B1030", VA = "0x1821B1E30")]
			internal bool FLLFBOJNFDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x21B3B60", Offset = "0x21B2D60", VA = "0x1821B3B60")]
			internal bool LCMNAOBLDCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x21B0CB0", Offset = "0x21AFEB0", VA = "0x1821B0CB0")]
			internal bool BBOHMOMOFNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x21BA7E0", Offset = "0x21B99E0", VA = "0x1821BA7E0")]
			internal void NCPHAIGOMJA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x21B3580", Offset = "0x21B2780", VA = "0x1821B3580")]
			internal bool KEPLGICBIMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x21B3530", Offset = "0x21B2730", VA = "0x1821B3530")]
			internal bool KEFJNKMMHGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x21B2940", Offset = "0x21B1B40", VA = "0x1821B2940")]
			internal bool IJLKADCNJIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x21BAA00", Offset = "0x21B9C00", VA = "0x1821BAA00")]
			internal bool NJNJEPBHKHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x21BB110", Offset = "0x21BA310", VA = "0x1821BB110")]
			internal bool PBLNFFFEBIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x21BAD70", Offset = "0x21B9F70", VA = "0x1821BAD70")]
			internal bool OGKEIDMJFAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x21B3040", Offset = "0x21B2240", VA = "0x1821B3040")]
			internal bool JNNKADJEHPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x21B2600", Offset = "0x21B1800", VA = "0x1821B2600")]
			internal bool IAMGGFACHCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x21BB5C0", Offset = "0x21BA7C0", VA = "0x1821BB5C0")]
			internal void PPEKFJKPAIK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x21BAA50", Offset = "0x21B9C50", VA = "0x1821BAA50")]
			internal bool NKHCDIMGKKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x21B26F0", Offset = "0x21B18F0", VA = "0x1821B26F0")]
			internal bool ICIBOFFGAPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x21B1800", Offset = "0x21B0A00", VA = "0x1821B1800")]
			internal void DKBICCFLNIC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x21B1400", Offset = "0x21B0600", VA = "0x1821B1400")]
			internal bool DBMGHJNNJMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x21B2E00", Offset = "0x21B2000", VA = "0x1821B2E00")]
			internal bool JJEDLDAMEIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x21BB450", Offset = "0x21BA650", VA = "0x1821BB450")]
			internal void PLDMOCLEEBJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x21B3D00", Offset = "0x21B2F00", VA = "0x1821B3D00")]
			internal List<HADLAOCLOCM> LLFHJNJCGLL(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x21B1760", Offset = "0x21B0960", VA = "0x1821B1760")]
			internal bool DFOKIKNOKAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x21BAC30", Offset = "0x21B9E30", VA = "0x1821BAC30")]
			internal int OAOKAJIELGL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x21B2740", Offset = "0x21B1940", VA = "0x1821B2740")]
			internal void IFOAPNHKKKD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x21B1510", Offset = "0x21B0710", VA = "0x1821B1510")]
			internal bool DCLLJIABGDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x21BA510", Offset = "0x21B9710", VA = "0x1821BA510")]
			internal bool MILNLGCCHHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x21B18C0", Offset = "0x21B0AC0", VA = "0x1821B18C0")]
			internal bool DMBEPKBCKOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x21B3A70", Offset = "0x21B2C70", VA = "0x1821B3A70")]
			internal int LALJBHHKBOB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x21B37C0", Offset = "0x21B29C0", VA = "0x1821B37C0")]
			internal void KLDNBKGDJPH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x21B1CA0", Offset = "0x21B0EA0", VA = "0x1821B1CA0")]
			internal bool FDEDJILJLDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x21B3820", Offset = "0x21B2A20", VA = "0x1821B3820")]
			internal bool KLFGNFFOOPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x21B1620", Offset = "0x21B0820", VA = "0x1821B1620")]
			internal bool DEIJINDIBOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x21BAB40", Offset = "0x21B9D40", VA = "0x1821BAB40")]
			internal bool NOHLOAAMPCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x21BB570", Offset = "0x21BA770", VA = "0x1821BB570")]
			internal bool POJDMHIKIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x21B3BB0", Offset = "0x21B2DB0", VA = "0x1821B3BB0")]
			internal bool LDFPJIFMHOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x21B0EE0", Offset = "0x21B00E0", VA = "0x1821B0EE0")]
			internal string CCBKOABLHFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x21B15B0", Offset = "0x21B07B0", VA = "0x1821B15B0")]
			internal void DEFDAOJBKBP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x21B22C0", Offset = "0x21B14C0", VA = "0x1821B22C0")]
			internal int GMGBBACPJOK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x21B0A10", Offset = "0x21AFC10", VA = "0x1821B0A10")]
			internal void AFIMKKCNEEE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x21B2B20", Offset = "0x21B1D20", VA = "0x1821B2B20")]
			internal bool JCGNGLGOBNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x21BA9B0", Offset = "0x21B9BB0", VA = "0x1821BA9B0")]
			internal bool NJNINLCMDEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x21B2DB0", Offset = "0x21B1FB0", VA = "0x1821B2DB0")]
			internal bool JJANPFJHLIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x21B3B10", Offset = "0x21B2D10", VA = "0x1821B3B10")]
			internal float LCLIGMAEHGO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21BB1B0", Offset = "0x21BA3B0", VA = "0x1821BB1B0")]
			internal void PGMHPANEJDD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x21BAF50", Offset = "0x21BA150", VA = "0x1821BAF50")]
			internal bool OMMGFHEPKJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x21B1910", Offset = "0x21B0B10", VA = "0x1821B1910")]
			internal bool DMFKECMJACJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x21BA910", Offset = "0x21B9B10", VA = "0x1821BA910")]
			internal bool NJCJKHKAFEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x21B23B0", Offset = "0x21B15B0", VA = "0x1821B23B0")]
			internal bool HFEJPCINPCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x21B1670", Offset = "0x21B0870", VA = "0x1821B1670")]
			internal bool DEJHDPBKIMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x21B39D0", Offset = "0x21B2BD0", VA = "0x1821B39D0")]
			internal bool KPPEEKIMDKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x21B9E30", Offset = "0x21B9030", VA = "0x1821B9E30")]
			internal void LNADAKGDNCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x21BB370", Offset = "0x21BA570", VA = "0x1821BB370")]
			internal string PJDIBMLKOHP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x21B2160", Offset = "0x21B1360", VA = "0x1821B2160")]
			internal void GGJINBLIDDI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x21BAD20", Offset = "0x21B9F20", VA = "0x1821BAD20")]
			internal bool OGDEKEOBFBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x21BA690", Offset = "0x21B9890", VA = "0x1821BA690")]
			internal bool MMGPKEKLAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x21B1C00", Offset = "0x21B0E00", VA = "0x1821B1C00")]
			internal bool EKJPFJNELLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x21B3180", Offset = "0x21B2380", VA = "0x1821B3180")]
			internal void KAONGJDLFOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x21B2F50", Offset = "0x21B2150", VA = "0x1821B2F50")]
			internal bool JMOOJOANGAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x21BACD0", Offset = "0x21B9ED0", VA = "0x1821BACD0")]
			internal bool ODEDMNBNKBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x21BA230", Offset = "0x21B9430", VA = "0x1821BA230")]
			internal bool LOEPPLGPMJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x21BA4C0", Offset = "0x21B96C0", VA = "0x1821BA4C0")]
			internal bool MIAACNNEGAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x21B1260", Offset = "0x21B0460", VA = "0x1821B1260")]
			internal void DABBHIJNDML(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x21B3C00", Offset = "0x21B2E00", VA = "0x1821B3C00")]
			internal bool LDIDBHHNAMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x21B2360", Offset = "0x21B1560", VA = "0x1821B2360")]
			internal bool HDBNOMKFBLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x21B1560", Offset = "0x21B0760", VA = "0x1821B1560")]
			internal bool DEEOAEOPDCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x21BAAA0", Offset = "0x21B9CA0", VA = "0x1821BAAA0")]
			internal bool NKOPJIDGFIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x21B3CA0", Offset = "0x21B2EA0", VA = "0x1821B3CA0")]
			internal void LLADGNJOJDA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x21B2B70", Offset = "0x21B1D70", VA = "0x1821B2B70")]
			internal bool JCLGPAKACME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x21BB2B0", Offset = "0x21BA4B0", VA = "0x1821BB2B0")]
			internal bool PHMJPNKEFIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x21B1210", Offset = "0x21B0410", VA = "0x1821B1210")]
			internal bool DAAEONBGGPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x21BA6E0", Offset = "0x21B98E0", VA = "0x1821BA6E0")]
			internal bool NAPMPCGKFJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x21B10E0", Offset = "0x21B02E0", VA = "0x1821B10E0")]
			internal object CMGCBNLMOLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x21B12C0", Offset = "0x21B04C0", VA = "0x1821B12C0")]
			internal void DACOGJMHNBM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x21B2650", Offset = "0x21B1850", VA = "0x1821B2650")]
			internal bool IAMKDPLJNIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x21BA960", Offset = "0x21B9B60", VA = "0x1821BA960")]
			internal bool NJIHDJDCMFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x21B2A80", Offset = "0x21B1C80", VA = "0x1821B2A80")]
			internal int IOBLONELPOD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x21BAFF0", Offset = "0x21BA1F0", VA = "0x1821BAFF0")]
			internal void ONJDMDNDLGO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x21B14C0", Offset = "0x21B06C0", VA = "0x1821B14C0")]
			internal bool DCFBNIJMDKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x21B3910", Offset = "0x21B2B10", VA = "0x1821B3910")]
			internal bool KOBJKEDOIHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x21B11C0", Offset = "0x21B03C0", VA = "0x1821B11C0")]
			internal int CPNMGPIBCOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x21B2E50", Offset = "0x21B2050", VA = "0x1821B2E50")]
			internal void JLFNFHEANFG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x21B1D40", Offset = "0x21B0F40", VA = "0x1821B1D40")]
			internal bool FJDFIILJELH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x21B2CC0", Offset = "0x21B1EC0", VA = "0x1821B2CC0")]
			internal bool JFLPBDBGGFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x21B0E40", Offset = "0x21B0040", VA = "0x1821B0E40")]
			internal bool BMOMDCPGODA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x21B2220", Offset = "0x21B1420", VA = "0x1821B2220")]
			internal int GLPJDILJNIG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x21B3670", Offset = "0x21B2870", VA = "0x1821B3670")]
			internal void KHJDDAMPFGL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x21B2540", Offset = "0x21B1740", VA = "0x1821B2540")]
			internal bool HOPEDGGHJDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x21B3620", Offset = "0x21B2820", VA = "0x1821B3620")]
			internal bool KHBOMECMLEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x21B0E90", Offset = "0x21B0090", VA = "0x1821B0E90")]
			internal bool BOMGCOECABG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x21BB0A0", Offset = "0x21BA2A0", VA = "0x1821BB0A0")]
			internal object PAMMFIJGJBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x21B3430", Offset = "0x21B2630", VA = "0x1821B3430")]
			internal void KDLDBGFHHGC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x21B3720", Offset = "0x21B2920", VA = "0x1821B3720")]
			internal bool KKPOOJEECJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21B2D60", Offset = "0x21B1F60", VA = "0x1821B2D60")]
			internal bool JFNKJBICJAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x21BA8A0", Offset = "0x21B9AA0", VA = "0x1821BA8A0")]
			internal object NIOPFLKOANJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x21BB3C0", Offset = "0x21BA5C0", VA = "0x1821BB3C0")]
			internal void PJOLBPIELMH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x21B36D0", Offset = "0x21B28D0", VA = "0x1821B36D0")]
			internal bool KKFMDJFNLMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x21B09C0", Offset = "0x21AFBC0", VA = "0x1821B09C0")]
			internal int ADDMDBFDJAG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x21B13A0", Offset = "0x21B05A0", VA = "0x1821B13A0")]
			internal void DBKAOIJOOOH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x21B3AC0", Offset = "0x21B2CC0", VA = "0x1821B3AC0")]
			internal bool LCFMEEADGAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x21BAE10", Offset = "0x21BA010", VA = "0x1821BAE10")]
			internal bool OKEDGIJEGCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x21B1090", Offset = "0x21B0290", VA = "0x1821B1090")]
			internal bool CLBBBMFDKEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x21B08D0", Offset = "0x21AFAD0", VA = "0x1821B08D0")]
			internal int ABDAFKODJHB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x21B1AB0", Offset = "0x21B0CB0", VA = "0x1821B1AB0")]
			internal void EEPNPEFKILN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x21BA3C0", Offset = "0x21B95C0", VA = "0x1821BA3C0")]
			internal bool MEFOAKAKMPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x21B3C50", Offset = "0x21B2E50", VA = "0x1821B3C50")]
			internal bool LIFAJFGHGNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x21B3770", Offset = "0x21B2970", VA = "0x1821B3770")]
			internal bool KLBLEGINLMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x21B2270", Offset = "0x21B1470", VA = "0x1821B2270")]
			internal float GMDKJFLFDLO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x21B2C10", Offset = "0x21B1E10", VA = "0x1821B2C10")]
			internal void JDIDPAFNNEJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x21B0F80", Offset = "0x21B0180", VA = "0x1821B0F80")]
			internal bool CJAOKPIIGFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AFFF0", VA = "0x1821B0DF0")]
			internal bool BKFNPIOLEPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x21B2400", Offset = "0x21B1600", VA = "0x1821B2400")]
			internal bool HHDNDIDMGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x21B38C0", Offset = "0x21B2AC0", VA = "0x1821B38C0")]
			internal float KMOOIHMNCJI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x21B28E0", Offset = "0x21B1AE0", VA = "0x1821B28E0")]
			internal void IJKGDBEKFEC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x21B2F00", Offset = "0x21B2100", VA = "0x1821B2F00")]
			internal bool JMNOIDFIJAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x21B0B70", Offset = "0x21AFD70", VA = "0x1821B0B70")]
			internal bool AOJFNJABCLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x21B0BC0", Offset = "0x21AFDC0", VA = "0x1821B0BC0")]
			internal string APCKIJMMEOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x21B1E80", Offset = "0x21B1080", VA = "0x1821B1E80")]
			internal void FLPMFAENLJO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x21B0DA0", Offset = "0x21AFFA0", VA = "0x1821B0DA0")]
			internal bool BJLCKNBPAAK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x21B3870", Offset = "0x21B2A70", VA = "0x1821B3870")]
			internal bool KLOKHGCMAOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x21B1A10", Offset = "0x21B0C10", VA = "0x1821B1A10")]
			internal bool ECMOLCNJNJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x21B0D50", Offset = "0x21AFF50", VA = "0x1821B0D50")]
			internal bool BIHINDENOAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x21B3090", Offset = "0x21B2290", VA = "0x1821B3090")]
			internal string JNOHMIECGOB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x21BA5D0", Offset = "0x21B97D0", VA = "0x1821BA5D0")]
			internal void MLFHGPFMBJF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x21B24A0", Offset = "0x21B16A0", VA = "0x1821B24A0")]
			internal bool HJNCGBHHGGN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x21B1710", Offset = "0x21B0910", VA = "0x1821B1710")]
			internal bool DFJGJADBAAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x21BA370", Offset = "0x21B9570", VA = "0x1821BA370")]
			internal bool MEADGILBBHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x21B0D00", Offset = "0x21AFF00", VA = "0x1821B0D00")]
			internal bool BGBIHGOENNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x21B27A0", Offset = "0x21B19A0", VA = "0x1821B27A0")]
			internal string IGAFGAADONG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x21BB300", Offset = "0x21BA500", VA = "0x1821BB300")]
			internal void PIFLKDLKADE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x21BA280", Offset = "0x21B9480", VA = "0x1821BA280")]
			internal bool LOLINBOJGGL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x21BADC0", Offset = "0x21B9FC0", VA = "0x1821BADC0")]
			internal bool OHAKGJJLHMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x21B2AD0", Offset = "0x21B1CD0", VA = "0x1821B2AD0")]
			internal bool IOONOCHLNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x21B3A20", Offset = "0x21B2C20", VA = "0x1821B3A20")]
			internal bool LAKGGPFCEHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x21BAEB0", Offset = "0x21BA0B0", VA = "0x1821BAEB0")]
			internal string OLDIBOKCGOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x21B0FD0", Offset = "0x21B01D0", VA = "0x1821B0FD0")]
			internal void CJHICJPENFN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x21B2450", Offset = "0x21B1650", VA = "0x1821B2450")]
			internal bool HIJJMCMGEKL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x21B2EB0", Offset = "0x21B20B0", VA = "0x1821B2EB0")]
			internal bool JLHPHPGNIKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x21B0AD0", Offset = "0x21AFCD0", VA = "0x1821B0AD0")]
			internal bool AJBFBMJENEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x21B0F30", Offset = "0x21B0130", VA = "0x1821B0F30")]
			internal bool CCMOHIPBMMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x21BA2D0", Offset = "0x21B94D0", VA = "0x1821BA2D0")]
			internal string LPMDNPDIICB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x21B2590", Offset = "0x21B1790", VA = "0x1821B2590")]
			internal void IALDCLPJOOF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x21BAAF0", Offset = "0x21B9CF0", VA = "0x1821BAAF0")]
			internal bool NNFDFLLNHHL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x21B1F40", Offset = "0x21B1140", VA = "0x1821B1F40")]
			internal bool FMENHDHGIHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x21BB520", Offset = "0x21BA720", VA = "0x1821BB520")]
			internal bool PNEEMCPOFIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x21B2FA0", Offset = "0x21B21A0", VA = "0x1821B2FA0")]
			internal bool JNEMAGJEDPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21B2BC0", Offset = "0x21B1DC0", VA = "0x1821B2BC0")]
			internal string JCPFIILACNM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x21BB4B0", Offset = "0x21BA6B0", VA = "0x1821BB4B0")]
			internal void PMFKKDAEDDO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x21B21D0", Offset = "0x21B13D0", VA = "0x1821B21D0")]
			internal bool GLDFKEAPALL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x21BB260", Offset = "0x21BA460", VA = "0x1821BB260")]
			internal bool PHJNGCGPDFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x21B30E0", Offset = "0x21B22E0", VA = "0x1821B30E0")]
			internal bool JOGCMNBKGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x21B0C60", Offset = "0x21AFE60", VA = "0x1821B0C60")]
			internal bool BAAHBBMAFHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x21BAE60", Offset = "0x21BA060", VA = "0x1821BAE60")]
			internal string OKHECBEGGFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x21B3960", Offset = "0x21B2B60", VA = "0x1821B3960")]
			internal void KPMLOJACBCN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x21BB210", Offset = "0x21BA410", VA = "0x1821BB210")]
			internal bool PHCEFAKACJK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x21B2D10", Offset = "0x21B1F10", VA = "0x1821B2D10")]
			internal bool JFNDELJMEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x21B0B20", Offset = "0x21AFD20", VA = "0x1821B0B20")]
			internal bool ANCCABEFABA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x21B1BB0", Offset = "0x21B0DB0", VA = "0x1821B1BB0")]
			internal bool EGILCLODOAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x21BA640", Offset = "0x21B9840", VA = "0x1821BA640")]
			internal string MMFCCBDKGAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x21B34C0", Offset = "0x21B26C0", VA = "0x1821B34C0")]
			internal void KEDNCPMJBLJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x21B2A30", Offset = "0x21B1C30", VA = "0x1821B2A30")]
			internal bool IMNJAOCFHBB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x21B2990", Offset = "0x21B1B90", VA = "0x1821B2990")]
			internal bool IKPCHCFMGCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x21B1B60", Offset = "0x21B0D60", VA = "0x1821B1B60")]
			internal bool EFNEIMEAJMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x21B2FF0", Offset = "0x21B21F0", VA = "0x1821B2FF0")]
			internal bool JNMIJOKJIDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x21B29E0", Offset = "0x21B1BE0", VA = "0x1821B29E0")]
			internal string ILIJJMEFMNA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x21B1FE0", Offset = "0x21B11E0", VA = "0x1821B1FE0")]
			internal void FMOODECCHHN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x21BA410", Offset = "0x21B9610", VA = "0x1821BA410")]
			internal bool MFAEANGOOHF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x21BA790", Offset = "0x21B9990", VA = "0x1821BA790")]
			internal bool NCEDJOEJKMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x21BAF00", Offset = "0x21BA100", VA = "0x1821BAF00")]
			internal bool OLNHHHFPIPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x21B1EF0", Offset = "0x21B10F0", VA = "0x1821B1EF0")]
			internal bool FMDKLIBANFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x21B2050", Offset = "0x21B1250", VA = "0x1821B2050")]
			internal string GACIHKELAFJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x21B1450", Offset = "0x21B0650", VA = "0x1821B1450")]
			internal void DCBDAGIFFKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x21BABE0", Offset = "0x21B9DE0", VA = "0x1821BABE0")]
			internal bool OAHCHJHAPCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x21BB050", Offset = "0x21BA250", VA = "0x1821BB050")]
			internal bool ONJGJKLDKAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x21B1D90", Offset = "0x21B0F90", VA = "0x1821B1D90")]
			internal bool FKEHANKIIDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x21B1350", Offset = "0x21B0550", VA = "0x1821B1350")]
			internal string DADCPAENMIG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x21BA560", Offset = "0x21B9760", VA = "0x1821BA560")]
			internal void MJPIPMHJGMJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x21BAFA0", Offset = "0x21BA1A0", VA = "0x1821BAFA0")]
			internal bool ONBOGPPLIEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x21B0970", Offset = "0x21AFB70", VA = "0x1821B0970")]
			internal bool ACHGNCNKAPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x21B27F0", Offset = "0x21B19F0", VA = "0x1821B27F0")]
			internal bool IHOPPPEKFFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x21BA320", Offset = "0x21B9520", VA = "0x1821BA320")]
			internal string MBHDLGCEAIN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x21B1150", Offset = "0x21B0350", VA = "0x1821B1150")]
			internal void CPGPJOGFJPF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x21B9DE0", Offset = "0x21B8FE0", VA = "0x1821B9DE0")]
			internal bool LMDIBKKANPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x21B9D90", Offset = "0x21B8F90", VA = "0x1821B9D90")]
			internal bool LLMFHCPMMHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x21B1960", Offset = "0x21B0B60", VA = "0x1821B1960")]
			internal bool EAFBBPHJAJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x21B1DE0", Offset = "0x21B0FE0", VA = "0x1821B1DE0")]
			internal string FKMHLAPMFJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x21B20A0", Offset = "0x21B12A0", VA = "0x1821B20A0")]
			internal void GADGEPFMCAM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x21B2890", Offset = "0x21B1A90", VA = "0x1821B2890")]
			internal bool IIFLDNCDBEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x21B1C50", Offset = "0x21B0E50", VA = "0x1821B1C50")]
			internal bool EPAJOGLNNPI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x21B2840", Offset = "0x21B1A40", VA = "0x1821B2840")]
			internal float IIADDMHAPJL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x21BA730", Offset = "0x21B9930", VA = "0x1821BA730")]
			internal void NBIMMMBPBEP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x21B1B10", Offset = "0x21B0D10", VA = "0x1821B1B10")]
			internal bool EFJEHLEDLPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x21B2310", Offset = "0x21B1510", VA = "0x1821B2310")]
			internal bool HCPKECJDMOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x21B16C0", Offset = "0x21B08C0", VA = "0x1821B16C0")]
			internal bool DEMOOCDGDPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x21BA1E0", Offset = "0x21B93E0", VA = "0x1821BA1E0")]
			internal int LNJKDNMFEJD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x21B1860", Offset = "0x21B0A60", VA = "0x1821B1860")]
			internal void DKGHDPHCIML(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x21B3130", Offset = "0x21B2330", VA = "0x1821B3130")]
			internal bool JPOLJBMOOLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x21B2C70", Offset = "0x21B1E70", VA = "0x1821B2C70")]
			internal bool JEJKEMMCJDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x21B1A60", Offset = "0x21B0C60", VA = "0x1821B1A60")]
			internal bool EEJAMFDPPAH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class JEBEENCLOJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GDPPCKLHLEO CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public JEBEENCLOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x21BE3B0", Offset = "0x21BD5B0", VA = "0x1821BE3B0")]
			internal void IFPIBLOAKJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class DCGHECFEIGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public DCGHECFEIGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x21AC1B0", Offset = "0x21AB3B0", VA = "0x1821AC1B0")]
			internal bool DFLGAFOFGEF(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly MLGKICPLDAO ADEOCMHOEBG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x21C6500", Offset = "0x21C5700", VA = "0x1821C6500")]
		public OJJJDHMLPJH(EDAGGAKPDDG FEIKNINOKPC, IFGNMBDCALK MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x21C47C0", Offset = "0x21C39C0", VA = "0x1821C47C0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class PMDEHNCIACC : APNAIIJKFII<AEMBKAONAEK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class BMPKHAGJIPC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public BMPKHAGJIPC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x21E3470", Offset = "0x21E2670", VA = "0x1821E3470", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public PMDEHNCIACC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public BMPKHAGJIPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x21CEC50", Offset = "0x21CDE50", VA = "0x1821CEC50")]
			internal string KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x21CED30", Offset = "0x21CDF30", VA = "0x1821CED30")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NGJPHKCEHLB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x21CEC00", Offset = "0x21CDE00", VA = "0x1821CEC00")]
			internal int HPGIFPPDCIC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x21CECA0", Offset = "0x21CDEA0", VA = "0x1821CECA0")]
			internal void LKMAJLJJKFG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x21E2D90", Offset = "0x21E1F90", VA = "0x1821E2D90")]
		public PMDEHNCIACC(EDAGGAKPDDG FEIKNINOKPC, AEMBKAONAEK JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x21E2A40", Offset = "0x21E1C40", VA = "0x1821E2A40", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class JHKBAPJAOCA : APNAIIJKFII<JHOFNJOMGAN>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class NBKIIFNHJOG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public NBKIIFNHJOG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x21E3130", Offset = "0x21E2330", VA = "0x1821E3130", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public NBKIIFNHJOG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x21E3780", Offset = "0x21E2980", VA = "0x1821E3780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public JHKBAPJAOCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public NBKIIFNHJOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x21DF120", Offset = "0x21DE320", VA = "0x1821DF120")]
			internal string KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x21DF2A0", Offset = "0x21DE4A0", VA = "0x1821DF2A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NGJPHKCEHLB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x21DF0D0", Offset = "0x21DE2D0", VA = "0x1821DF0D0")]
			internal int HPGIFPPDCIC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x21DF170", Offset = "0x21DE370", VA = "0x1821DF170")]
			internal void LKMAJLJJKFG(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x21DED80", Offset = "0x21DDF80", VA = "0x1821DED80")]
			internal string ABHDPKLANKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x21DEEB0", Offset = "0x21DE0B0", VA = "0x1821DEEB0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DGIJEHPALPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x21DF010", Offset = "0x21DE210", VA = "0x1821DF010")]
			internal bool EBEBKGPNMMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x21DEF80", Offset = "0x21DE180", VA = "0x1821DEF80")]
			internal void DJFJMPCCJBA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x21DF400", Offset = "0x21DE600", VA = "0x1821DF400")]
			internal bool OIPAJJNHJAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x21DF370", Offset = "0x21DE570", VA = "0x1821DF370")]
			internal void OCFLHINKJHA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x21DEE60", Offset = "0x21DE060", VA = "0x1821DEE60")]
			internal float CLAANLLCIJE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x21DEDD0", Offset = "0x21DDFD0", VA = "0x1821DEDD0")]
			internal void AFKMDJIIPHP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x21DF450", Offset = "0x21DE650", VA = "0x1821DF450")]
			internal int OOJJEIGOKBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x21DF200", Offset = "0x21DE400", VA = "0x1821DF200")]
			internal void MLAPFFEFHBN(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x21DF060", Offset = "0x21DE260", VA = "0x1821DF060")]
			internal bool FMGLOPGFCIA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x21D9810", Offset = "0x21D8A10", VA = "0x1821D9810")]
		public JHKBAPJAOCA(EDAGGAKPDDG FEIKNINOKPC, JHOFNJOMGAN MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21D8DD0", Offset = "0x21D7FD0", VA = "0x1821D8DD0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class EALCLCPKNGP : APNAIIJKFII<NFODBCGLNCO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class DDFKNBIOKLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public EALCLCPKNGP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public DDFKNBIOKLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x21D48D0", Offset = "0x21D3AD0", VA = "0x1821D48D0")]
			internal Dictionary<string, KMMOFIPPECC> KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x21D49F0", Offset = "0x21D3BF0", VA = "0x1821D49F0")]
			internal int NGJPHKCEHLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x21D47B0", Offset = "0x21D39B0", VA = "0x1821D47B0")]
			internal void HPGIFPPDCIC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x21D4970", Offset = "0x21D3B70", VA = "0x1821D4970")]
			internal bool LKMAJLJJKFG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x21D51E0", Offset = "0x21D43E0", VA = "0x1821D51E0")]
		public EALCLCPKNGP(EDAGGAKPDDG FEIKNINOKPC, NFODBCGLNCO JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x21D4F10", Offset = "0x21D4110", VA = "0x1821D4F10", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class GDGLKCIIGHO : APNAIIJKFII<JCMPAOLFCGH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class BLOLFMALHHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public GDGLKCIIGHO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public BLOLFMALHHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x21CEAF0", Offset = "0x21CDCF0", VA = "0x1821CEAF0")]
			internal void KGCPFDDPLHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x21D6C90", Offset = "0x21D5E90", VA = "0x1821D6C90")]
		public GDGLKCIIGHO(EDAGGAKPDDG FEIKNINOKPC, JCMPAOLFCGH JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x21D6B10", Offset = "0x21D5D10", VA = "0x1821D6B10", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class FEINNOJABAG : PBFGDBGFPGM<KJONJFMBAJG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool INGGAAIIHOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool HMIONIPNIAF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x21D62B0", Offset = "0x21D54B0", VA = "0x1821D62B0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F4E20", Offset = "0x9F4020", VA = "0x1809F4E20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x21D6250", Offset = "0x21D5450", VA = "0x1821D6250")]
		public FEINNOJABAG(EDAGGAKPDDG FEIKNINOKPC, KJONJFMBAJG MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class LDPPDODKBJH : APNAIIJKFII<OMLENBJFPFF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB31FA0", Offset = "0xB311A0", VA = "0x180B31FA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x21DCB00", Offset = "0x21DBD00", VA = "0x1821DCB00")]
		public LDPPDODKBJH(EDAGGAKPDDG FEIKNINOKPC, OMLENBJFPFF MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class OJNHCDPEGKP : APNAIIJKFII<GEHPCJLFGPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xB6DF20", Offset = "0xB6D120", VA = "0x180B6DF20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x21E14A0", Offset = "0x21E06A0", VA = "0x1821E14A0")]
		public OJNHCDPEGKP(EDAGGAKPDDG FEIKNINOKPC, GEHPCJLFGPK MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "112")]
		protected override bool POGFJAEOBMC(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class DKHOJINGDIG : APNAIIJKFII<ANMOEBNOPNC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9FADB0", Offset = "0x9F9FB0", VA = "0x1809FADB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool FEMPPPDFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x21D4EC0", Offset = "0x21D40C0", VA = "0x1821D4EC0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool EFHGFPAAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x21D4E50", Offset = "0x21D4050", VA = "0x1821D4E50")]
		public DKHOJINGDIG(EDAGGAKPDDG FEIKNINOKPC, ANMOEBNOPNC MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class HPPCNOGAIFC : APNAIIJKFII<KELHCNPMOEL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9CE470", Offset = "0x9CD670", VA = "0x1809CE470", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool FEMPPPDFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x21D8820", Offset = "0x21D7A20", VA = "0x1821D8820", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool EFHGFPAAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x21D87B0", Offset = "0x21D79B0", VA = "0x1821D87B0")]
		public HPPCNOGAIFC(EDAGGAKPDDG FEIKNINOKPC, KELHCNPMOEL MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class OPFKHEJPNDH : DLLLGOBGCHM<GMBIFKPICIC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class LFOOIDBIBKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public OPFKHEJPNDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LFOOIDBIBKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x21DCB70", Offset = "0x21DBD70", VA = "0x1821DCB70")]
			internal float GMEEHBALEMH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x21DCBF0", Offset = "0x21DBDF0", VA = "0x1821DCBF0")]
			internal void LOBDCEFFOEJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x21E1F20", Offset = "0x21E1120", VA = "0x1821E1F20")]
		public OPFKHEJPNDH(EDAGGAKPDDG FEIKNINOKPC, GMBIFKPICIC JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x21E1CA0", Offset = "0x21E0EA0", VA = "0x1821E1CA0", Slot = "126")]
		protected override void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class MFBCELJBGEP : APNAIIJKFII<OBICLEHFAAF>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class KNOLDEACKGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public MFBCELJBGEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public KNOLDEACKGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x21DAA90", Offset = "0x21D9C90", VA = "0x1821DAA90")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x21DAAE0", Offset = "0x21D9CE0", VA = "0x1821DAAE0")]
			internal void NGJPHKCEHLB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x21DDBD0", Offset = "0x21DCDD0", VA = "0x1821DDBD0")]
		public MFBCELJBGEP(EDAGGAKPDDG FEIKNINOKPC, OBICLEHFAAF JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x21DD930", Offset = "0x21DCB30", VA = "0x1821DD930", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class JJNNNGCBCOP : APNAIIJKFII<KDNOEFKMANK>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class OKKLIAPMFMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public JJNNNGCBCOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public OKKLIAPMFMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x21E18D0", Offset = "0x21E0AD0", VA = "0x1821E18D0")]
			internal object KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x21E15D0", Offset = "0x21E07D0", VA = "0x1821E15D0")]
			internal bool DJFJMPCCJBA(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x21E1A50", Offset = "0x21E0C50", VA = "0x1821E1A50")]
			internal void NGJPHKCEHLB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x21E1770", Offset = "0x21E0970", VA = "0x1821E1770")]
			internal string HPGIFPPDCIC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x21E1A00", Offset = "0x21E0C00", VA = "0x1821E1A00")]
			internal IReadOnlyList<object> LKMAJLJJKFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x21E1510", Offset = "0x21E0710", VA = "0x1821E1510")]
			internal bool ABHDPKLANKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x21E1580", Offset = "0x21E0780", VA = "0x1821E1580")]
			internal bool DGIJEHPALPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x21E1650", Offset = "0x21E0850", VA = "0x1821E1650")]
			internal void EBEBKGPNMMF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x21DA0A0", Offset = "0x21D92A0", VA = "0x1821DA0A0")]
		public JJNNNGCBCOP(EDAGGAKPDDG FEIKNINOKPC, KDNOEFKMANK JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x21D9880", Offset = "0x21D8A80", VA = "0x1821D9880", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class GBGMIGLKGAC : LNCFCHDFKND<DODJHIADGPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA076B0", Offset = "0xA068B0", VA = "0x180A076B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x21D6AB0", Offset = "0x21D5CB0", VA = "0x1821D6AB0")]
		public GBGMIGLKGAC(EDAGGAKPDDG FEIKNINOKPC, DODJHIADGPF MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class FNCKDHOONGO : DLLLGOBGCHM<JNJJBHACBEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class EDKLGKCGNDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public FNCKDHOONGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public EDKLGKCGNDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x21D55D0", Offset = "0x21D47D0", VA = "0x1821D55D0")]
			internal int GMEEHBALEMH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x21D5650", Offset = "0x21D4850", VA = "0x1821D5650")]
			internal void LOBDCEFFOEJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x21D6A50", Offset = "0x21D5C50", VA = "0x1821D6A50")]
		public FNCKDHOONGO(EDAGGAKPDDG FEIKNINOKPC, JNJJBHACBEJ JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x21D67C0", Offset = "0x21D59C0", VA = "0x1821D67C0", Slot = "126")]
		protected override void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class MANMEBAJABI : APNAIIJKFII<DAJKABDBJOP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class EHDACAFHGKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public MANMEBAJABI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public EHDACAFHGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x21D5AB0", Offset = "0x21D4CB0", VA = "0x1821D5AB0")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x21D5B00", Offset = "0x21D4D00", VA = "0x1821D5B00")]
			internal void NGJPHKCEHLB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x21DD8C0", Offset = "0x21DCAC0", VA = "0x1821DD8C0")]
		public MANMEBAJABI(EDAGGAKPDDG FEIKNINOKPC, DAJKABDBJOP JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x21DD6E0", Offset = "0x21DC8E0", VA = "0x1821DD6E0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class GEOAJPBCLLN : APNAIIJKFII<ODODMKENIGO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class KLLEFJIMEDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public GEOAJPBCLLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public KLLEFJIMEDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x21DA9B0", Offset = "0x21D9BB0", VA = "0x1821DA9B0")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x21DAA00", Offset = "0x21D9C00", VA = "0x1821DAA00")]
			internal void NGJPHKCEHLB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x21D6EE0", Offset = "0x21D60E0", VA = "0x1821D6EE0")]
		public GEOAJPBCLLN(EDAGGAKPDDG FEIKNINOKPC, ODODMKENIGO JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x21D6D00", Offset = "0x21D5F00", VA = "0x1821D6D00", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class AJIEMDACKEP : APNAIIJKFII<NNGDHHKIEMF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class KGFENHGHIAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public AJIEMDACKEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public KGFENHGHIAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x21DA8D0", Offset = "0x21D9AD0", VA = "0x1821DA8D0")]
			internal int KGCPFDDPLHF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x21DA920", Offset = "0x21D9B20", VA = "0x1821DA920")]
			internal void NGJPHKCEHLB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x21CE430", Offset = "0x21CD630", VA = "0x1821CE430")]
		public AJIEMDACKEP(EDAGGAKPDDG FEIKNINOKPC, NNGDHHKIEMF JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x21CE1C0", Offset = "0x21CD3C0", VA = "0x1821CE1C0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class DHEALPKDFEN : MBHLAECKHMG<MGILCAGBAPM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override ALNLJNEDEAK KHDJGOLOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "126")]
			get
			{
				return default(ALNLJNEDEAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x21D4A40", Offset = "0x21D3C40", VA = "0x1821D4A40")]
		public DHEALPKDFEN(EDAGGAKPDDG FEIKNINOKPC, MGILCAGBAPM JANAFGLBOCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class OBJJMIOEKIP : APNAIIJKFII<MNIIIHLJBIO>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x21DF980", Offset = "0x21DEB80", VA = "0x1821DF980")]
		public OBJJMIOEKIP(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class APNAIIJKFII<TNode> : NJEHGCGMDBB, IDisposable where TNode : notnull, MNIIIHLJBIO
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class PKIJHNALGPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public APNAIIJKFII<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public EDAGGAKPDDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public PKIJHNALGPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x4AAC270", Offset = "0x4AAB470", VA = "0x184AAC270")]
			internal AINENMOGCPO IJNILCNMLFB(GJEECKOFBOD portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct ECAHNEMMLHJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public APNAIIJKFII<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9AB0", Offset = "0x3AC8CB0", VA = "0x183AC9AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct AKPGAIEFGIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public APNAIIJKFII<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public APIJGFLEKBA? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public PKEMICAKFDH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x3FA7580", Offset = "0x3FA6780", VA = "0x183FA7580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3FA7820", Offset = "0x3FA6A20", VA = "0x183FA7820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class CCHKOMOMLKN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public CCHKOMOMLKN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x3822FB0", Offset = "0x38221B0", VA = "0x183822FB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public APNAIIJKFII<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public IOAPGBAGAAA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public CCHKOMOMLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			internal string MDDOEOPMBNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			internal void NKMPEBNODPF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x56C6FB0", Offset = "0x56C61B0", VA = "0x1856C6FB0")]
			[AsyncStateMachine(typeof(APNAIIJKFII<>.CCHKOMOMLKN.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void PFCJHPDBHFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class GAPCGGGJEKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GAPCGGGJEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3F564A0", Offset = "0x3F556A0", VA = "0x183F564A0")]
			internal bool PFOJAFEHBDO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3F56490", Offset = "0x3F55690", VA = "0x183F56490")]
			internal bool HHIDMFOIPBK(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct ODKPNKIBMIA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public APNAIIJKFII<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x49587C0", Offset = "0x49579C0", VA = "0x1849587C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x4958B40", Offset = "0x4957D40", VA = "0x184958B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly EDAGGAKPDDG FHGLJIGGHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool PGADDCEKOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private KNBBJIOBKCJ<PNDOEKJDHKD, AINENMOGCPO> IOBLJEDADJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private KNBBJIOBKCJ<PNDOEKJDHKD, CGCNPKFOLDI> MFOFGLPFCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> ELBKLBKNOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<GJCCLPKGONN<PNDOEKJDHKD>>? ECJKCOPEPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<GJCCLPKGONN<PNDOEKJDHKD>, CGCNPKFOLDI>? MPBLAFMBKKJ;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected MONPBPLADEK MCOODMGALMC
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x447FDD0", Offset = "0x447EFD0", VA = "0x18447FDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected OMMABCMAHNJ GFLFIIFLEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x447EF10", Offset = "0x447E110", VA = "0x18447EF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode HNNALMMBIGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public JFDDFNFCNKH<DIFGJKIDHIA> GIJGMAFIDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xDE8C40", Offset = "0xDE7E40", VA = "0x180DE8C40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JFDDFNFCNKH<DIFGJKIDHIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public GJCCLPKGONN<COJKPHBGDFJ> IAIOODDBANF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x44844D0", Offset = "0x44836D0", VA = "0x1844844D0", Slot = "6")]
			get
			{
				return default(GJCCLPKGONN<COJKPHBGDFJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object OGKDBBDOMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3B3FE50", Offset = "0x3B3F050", VA = "0x183B3FE50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool LONAOPIDGEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int NGHCCCHGLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x4484130", Offset = "0x4483330", VA = "0x184484130", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JLEFEMGMODF NMKPKHHLMDK
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x44840D0", Offset = "0x44832D0", VA = "0x1844840D0", Slot = "10")]
			get
			{
				return default(JLEFEMGMODF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string CDFLJNGHNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x4484670", Offset = "0x4483870", VA = "0x184484670", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool EFHGFPAAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public GJCCLPKGONN<GMFKPENPKND> DKJJCLNLJEF
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x96D780", Offset = "0x96C980", VA = "0x18096D780", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(GJCCLPKGONN<GMFKPENPKND>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x96BB50", Offset = "0x96AD50", VA = "0x18096BB50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool FEMPPPDFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool INGGAAIIHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NOOPAONCHDB HAINGAAPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA66CB0", Offset = "0xA65EB0", VA = "0x180A66CB0", Slot = "94")]
			get
			{
				return default(NOOPAONCHDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool HDEEODHGNML
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4483E40", Offset = "0x4483040", VA = "0x184483E40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool AJLIPIMHIPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4483EA0", Offset = "0x44830A0", VA = "0x184483EA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool BCPGLFJIJPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x4483F00", Offset = "0x4483100", VA = "0x184483F00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int DBMIBEELBBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x4484480", Offset = "0x4483680", VA = "0x184484480", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool NJKIEGHEOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x44842B0", Offset = "0x44834B0", VA = "0x1844842B0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool OPHCJAHPOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x4484010", Offset = "0x4483210", VA = "0x184484010", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KOOLBOJKJAH
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x4483FB0", Offset = "0x44831B0", VA = "0x184483FB0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool BKNOMGBGDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA30E60", Offset = "0xA30060", VA = "0x180A30E60", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xF1EF90", Offset = "0xF1E190", VA = "0x180F1EF90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KHHJHNJDILD
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool EPOIEFGGIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4483F60", Offset = "0x4483160", VA = "0x184483F60", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool NKPEBDLHHHP
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x44841E0", Offset = "0x44833E0", VA = "0x1844841E0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public APIJGFLEKBA BNMCNAJDLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x44843C0", Offset = "0x44835C0", VA = "0x1844843C0", Slot = "28")]
			get
			{
				return default(APIJGFLEKBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public PKEMICAKFDH JNDADJGBBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4484420", Offset = "0x4483620", VA = "0x184484420", Slot = "30")]
			get
			{
				return default(PKEMICAKFDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool EHLAJCKLNEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual CPGKEIFEELC? NHCDILNFLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual IMCEEIHAMBG? EINFFBNIFCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<JFDDFNFCNKH<JKFBFCDNFMP>>? NHGAAONFIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool LECHFKLCPDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4484070", Offset = "0x4483270", VA = "0x184484070", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JFDDFNFCNKH<EJPHCCLFAJF> NECCBABEDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4484300", Offset = "0x4483500", VA = "0x184484300", Slot = "62")]
			get
			{
				return default(JFDDFNFCNKH<EJPHCCLFAJF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public GJCCLPKGONN<EJPHCCLFAJF> LAGDFJGMEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x4484180", Offset = "0x4483380", VA = "0x184484180", Slot = "56")]
			get
			{
				return default(GJCCLPKGONN<EJPHCCLFAJF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool LNCHFFIAMJF
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual GJCCLPKGONN<EJPHCCLFAJF>? MOKNHELLBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool HMIONIPNIAF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NGKFNAPJHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4484240", Offset = "0x4483440", VA = "0x184484240", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x8A2460", Offset = "0x8A1660", VA = "0x1808A2460", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8A2550", Offset = "0x8A1750", VA = "0x1808A2550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string JMDIHACKGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8A24F0", Offset = "0x8A16F0", VA = "0x1808A24F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JFDDFNFCNKH<JKFBFCDNFMP> EDPLAHOCNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4484360", Offset = "0x4483560", VA = "0x184484360", Slot = "63")]
			get
			{
				return default(JFDDFNFCNKH<JKFBFCDNFMP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JFDDFNFCNKH<JKFBFCDNFMP>? PMEMEHHPOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4484550", Offset = "0x4483750", VA = "0x184484550", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public DMBJJGMCBDP<PNDOEKJDHKD, CGCNPKFOLDI> DGJKPEANHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4484630", Offset = "0x4483830", VA = "0x184484630", Slot = "65")]
			get
			{
				return default(DMBJJGMCBDP<PNDOEKJDHKD, CGCNPKFOLDI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual GJCCLPKGONN<PNDOEKJDHKD>? KMEAIAFFGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool FBKHNMIBDLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool CNLLPDHHLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PHMDKALKEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4482DE0", Offset = "0x4481FE0", VA = "0x184482DE0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4480070", Offset = "0x447F270", VA = "0x184480070", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IJGJLBCMHGI NECLHBBHCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4483100", Offset = "0x4482300", VA = "0x184483100", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x44829D0", Offset = "0x4481BD0", VA = "0x1844829D0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OHGKDBDDCOM JHGMPEKDPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4481550", Offset = "0x4480750", VA = "0x184481550", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4481840", Offset = "0x4480A40", VA = "0x184481840", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IDJAHIHAACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4483030", Offset = "0x4482230", VA = "0x184483030", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4482F20", Offset = "0x4482120", VA = "0x184482F20", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NDABKEDHNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4482E80", Offset = "0x4482080", VA = "0x184482E80", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x44815F0", Offset = "0x44807F0", VA = "0x1844815F0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>, CGCNPKFOLDI> FKBPHKPNLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x44821E0", Offset = "0x44813E0", VA = "0x1844821E0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4483760", Offset = "0x4482960", VA = "0x184483760", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>, CGCNPKFOLDI> CGGMAFHAGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4482910", Offset = "0x4481B10", VA = "0x184482910", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4482D20", Offset = "0x4481F20", VA = "0x184482D20", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>> PFIMPLADHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x44816B0", Offset = "0x44808B0", VA = "0x1844816B0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x4481490", Offset = "0x4480690", VA = "0x184481490", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>, GJCCLPKGONN<PNDOEKJDHKD>> EHPFOAFEJJO
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4481F70", Offset = "0x4481170", VA = "0x184481F70", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x447FB60", Offset = "0x447ED60", VA = "0x18447FB60", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>, CGCNPKFOLDI> NGCGHAMJLPF
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4482030", Offset = "0x4481230", VA = "0x184482030", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x447FFB0", Offset = "0x447F1B0", VA = "0x18447FFB0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<GJCCLPKGONN<PNDOEKJDHKD>, GJCCLPKGONN<PNDOEKJDHKD>> AMAPJINGABN
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x44823D0", Offset = "0x44815D0", VA = "0x1844823D0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4480830", Offset = "0x447FA30", VA = "0x184480830", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4483860", Offset = "0x4482A60", VA = "0x184483860")]
		[NLMOIDEGKNH("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[NLMOIDEGKNH("Need to handle `Name` better.")]
		protected APNAIIJKFII(EDAGGAKPDDG FEIKNINOKPC, TNode MOPDELCEJCO, bool PJGLOKHODBB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x4480110", Offset = "0x447F310", VA = "0x184480110", Slot = "87")]
		protected virtual void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4480A60", Offset = "0x447FC60", VA = "0x184480A60", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x447FE30", Offset = "0x447F030", VA = "0x18447FE30", Slot = "9")]
		[AsyncStateMachine(typeof(APNAIIJKFII<>.ECAHNEMMLHJ))]
		public void CDMGIKKHBKP(int IOHDNCGNCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x447F000", Offset = "0x447E200", VA = "0x18447F000")]
		public bool AIGNJJJOEKL([In] APIJGFLEKBA JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x447F070", Offset = "0x447E270", VA = "0x18447F070")]
		public bool AKAODKFINCH([In] PKEMICAKFDH JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x447ED10", Offset = "0x447DF10", VA = "0x18447ED10", Slot = "32")]
		public void ADPKGGNOJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x4481E20", Offset = "0x4481020", VA = "0x184481E20", Slot = "33")]
		[AsyncStateMachine(typeof(APNAIIJKFII<>.AKPGAIEFGIJ))]
		public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> HGHHDEDBOBO(APIJGFLEKBA? KMEEFLDIFOK, PKEMICAKFDH? GGGHJBFEJHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "97")]
		public virtual void CLIPFMGNACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "98")]
		public virtual void CKDIJBKFDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "99")]
		public virtual void JIGEEDJBEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9FD660", Offset = "0x9FC860", VA = "0x1809FD660")]
		protected void HMCIMMAGNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x92A6D0", Offset = "0x9298D0", VA = "0x18092A6D0")]
		protected void EBLPPDONDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x23D73E0", Offset = "0x23D65E0", VA = "0x1823D73E0")]
		private void LCPLBMLHMCA([In] PKEMICAKFDH MBMKLLFOFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x447FEE0", Offset = "0x447F0E0", VA = "0x18447FEE0", Slot = "100")]
		public virtual Task<KJEOKHCIBGM<GJCCLPKGONN<PNDOEKJDHKD>, IJNOPJPLCIM>> CPEKAPDODCI(string EPPPGDEIJCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x44833F0", Offset = "0x44825F0", VA = "0x1844833F0", Slot = "101")]
		public virtual Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> PAOGCBMBOGF(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "102")]
		public virtual void FICGGMACIGB(GJCCLPKGONN<PNDOEKJDHKD> FBFPLOINBGA, GJCCLPKGONN<PNDOEKJDHKD> PJJNLACBJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4481770", Offset = "0x4480970", VA = "0x184481770", Slot = "103")]
		public virtual IEnumerable<IBMALGPEGND> GFHHGMDPOID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x44809D0", Offset = "0x447FBD0", VA = "0x1844809D0", Slot = "104")]
		public KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM> DNDODCCDBFI(string CKNPCFBJILM)
		{
			return default(KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x4483610", Offset = "0x4482810", VA = "0x184483610", Slot = "47")]
		public bool PEPJELDLDJL([Out] Guid EMABKLGIJKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x4482A70", Offset = "0x4481C70", VA = "0x184482A70")]
		public bool LIEFDPHIJHE([In] Guid CNOJGLMENAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "105")]
		public virtual void AKMCCPCKADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "106")]
		public virtual void LMBPMLFFFED(bool CCKONNKLALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "107")]
		public virtual AGPMKMJAGLD BOECJIJHMLF([In] ICKFALCALHH KDOPFBECBBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x44831A0", Offset = "0x44823A0", VA = "0x1844831A0")]
		protected void OCPPMMKBKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4483820", Offset = "0x4482A20", VA = "0x184483820", Slot = "112")]
		protected virtual bool POGFJAEOBMC(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "113")]
		protected virtual bool HMGOGGLIMEM(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected virtual void GJKIELJMNEA(IOAPGBAGAAA EBGMDKKMFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x447F0E0", Offset = "0x447E2E0", VA = "0x18447F0E0")]
		protected void AKHIKLKLLLD(IOAPGBAGAAA MHGCHDPGHAI, Func<string> EOKKFAIBNHC, Action<string> IOHCBLHHNID, string PDHPFLMGPLJ, string EDHPFKPJAGO, string CCGIGCNCHNL, EEBIHJLFMOC PFGLLMNFJNG, MLMKBGFBILK GADANGKCOOC, Func<string, bool> ALBLIGFKNHC, string ANOEAIHKODJ, Func<string, bool> PCJGBCPEHCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x447F4D0", Offset = "0x447E6D0", VA = "0x18447F4D0")]
		protected void BCJJKDOKHMA(IOAPGBAGAAA MHGCHDPGHAI, Func<string> EOKKFAIBNHC, Action<string> IOHCBLHHNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x447FC20", Offset = "0x447EE20", VA = "0x18447FC20", Slot = "121")]
		protected virtual void BPEONHOLCEE(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4481320", Offset = "0x4480520", VA = "0x184481320", Slot = "80")]
		public void EFFPEHIOBLL(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x44820F0", Offset = "0x44812F0", VA = "0x1844820F0", Slot = "81")]
		public JMFFCBMGCHD IIJNKEDDNLE()
		{
			return default(JMFFCBMGCHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "124")]
		public virtual bool HBEJFAJEKOG(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1836CC0", Offset = "0x1835EC0", VA = "0x181836CC0")]
		private void DBMBMKJGLFP([In] APIJGFLEKBA FJFKFIAGEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x44834C0", Offset = "0x44826C0", VA = "0x1844834C0")]
		private void PBLKFHEEHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x44818E0", Offset = "0x4480AE0", VA = "0x1844818E0")]
		private void GLFPIGEKNCG(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJEECKOFBOD IOCEGBFDPGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xB574E0", Offset = "0xB566E0", VA = "0x180B574E0")]
		private void LEEDGLAJJKB(GJCCLPKGONN<PNDOEKJDHKD> MHMAFIBKDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x44822A0", Offset = "0x44814A0", VA = "0x1844822A0")]
		private void IOBLFBFEJGN(GJCCLPKGONN<PNDOEKJDHKD> MHMAFIBKDFF, GJEECKOFBOD HIOPOAMIBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x447F7B0", Offset = "0x447E9B0", VA = "0x18447F7B0")]
		private void BNBKMOIFALA(GJCCLPKGONN<PNDOEKJDHKD> FBFPLOINBGA, GJCCLPKGONN<PNDOEKJDHKD> PJJNLACBJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xB56210", Offset = "0xB55410", VA = "0x180B56210")]
		private void ELOFDONNPBG(GJCCLPKGONN<PNDOEKJDHKD> FBFPLOINBGA, GJCCLPKGONN<PNDOEKJDHKD> PJJNLACBJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4481690", Offset = "0x4480890", VA = "0x184481690")]
		private void FOMCMIHCODE(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4482490", Offset = "0x4481690", VA = "0x184482490")]
		private void JEJOJEFCMDJ(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJEECKOFBOD IOCEGBFDPGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4483380", Offset = "0x4482580", VA = "0x184483380")]
		private void OLEHOJNFEAP(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJEECKOFBOD HIOPOAMIBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4481370", Offset = "0x4480570", VA = "0x184481370", Slot = "125")]
		[AsyncStateMachine(typeof(APNAIIJKFII<>.ODKPNKIBMIA))]
		public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> FAEGOMIMPMH(string CKNPCFBJILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4482FC0", Offset = "0x44821C0", VA = "0x184482FC0", Slot = "54")]
		private void MCOJPLAJOEP(object IHAEPNEKCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x44828A0", Offset = "0x4481AA0", VA = "0x1844828A0", Slot = "55")]
		private void JFEPNEAJFIF(object IHAEPNEKCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4480990", Offset = "0x447FB90", VA = "0x184480990", Slot = "29")]
		private bool DLFOFBGLBKH([In] APIJGFLEKBA JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4481800", Offset = "0x4480A00", VA = "0x184481800", Slot = "31")]
		private bool GHBFMNKKMNL([In] PKEMICAKFDH JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4482F80", Offset = "0x4482180", VA = "0x184482F80", Slot = "48")]
		private bool MBLFPOAEAIP([In] Guid CNOJGLMENAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x44812E0", Offset = "0x44804E0", VA = "0x1844812E0")]
		[CompilerGenerated]
		private string EEILLAJEBCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x44808F0", Offset = "0x447FAF0", VA = "0x1844808F0")]
		[CompilerGenerated]
		private void DLFGHNDAKNJ(string EPPPGDEIJCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class GHHLHFBDHHO : LNCFCHDFKND<NMNNOHAFLJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x152F3A0", Offset = "0x152E5A0", VA = "0x18152F3A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x21D6F50", Offset = "0x21D6150", VA = "0x1821D6F50")]
		public GHHLHFBDHHO(EDAGGAKPDDG FEIKNINOKPC, NMNNOHAFLJK MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class JEEPLEOPHIJ : PBFGDBGFPGM<IDKEONIHNJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x21D8950", Offset = "0x21D7B50", VA = "0x1821D8950")]
		public JEEPLEOPHIJ(EDAGGAKPDDG FEIKNINOKPC, IDKEONIHNJK MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class MBHLAECKHMG<T> : APNAIIJKFII<T> where T : notnull, PHAEFCDHLDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class LLEMNALPPBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, KMMOFIPPECC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public MBHLAECKHMG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public ALNLJNEDEAK clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LLEMNALPPBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			internal IReadOnlyList<KeyValuePair<string, KMMOFIPPECC>> KGCPFDDPLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4559B40", Offset = "0x4558D40", VA = "0x184559B40")]
			internal int NGJPHKCEHLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4559810", Offset = "0x4558A10", VA = "0x184559810")]
			internal void HPGIFPPDCIC(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4559A30", Offset = "0x4558C30", VA = "0x184559A30")]
			internal void LKMAJLJJKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x45594D0", Offset = "0x45586D0", VA = "0x1845594D0")]
			internal void ABHDPKLANKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4559730", Offset = "0x4558930", VA = "0x184559730")]
			internal bool DGIJEHPALPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x45597C0", Offset = "0x45589C0", VA = "0x1845597C0")]
			internal void EBEBKGPNMMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4559730", Offset = "0x4558930", VA = "0x184559730")]
			internal bool DJFJMPCCJBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4559D50", Offset = "0x4558F50", VA = "0x184559D50")]
			internal float OIPAJJNHJAG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4559C90", Offset = "0x4558E90", VA = "0x184559C90")]
			internal void OCFLHINKJHA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x45596E0", Offset = "0x45588E0", VA = "0x1845596E0")]
			internal float CLAANLLCIJE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4559620", Offset = "0x4558820", VA = "0x184559620")]
			internal void AFKMDJIIPHP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4559DA0", Offset = "0x4558FA0", VA = "0x184559DA0")]
			internal float OOJJEIGOKBC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4559A80", Offset = "0x4558C80", VA = "0x184559A80")]
			internal void MLAPFFEFHBN(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6BBA0", VA = "0x180B6C9A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract ALNLJNEDEAK KHDJGOLOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4765580", Offset = "0x4764780", VA = "0x184765580")]
		public MBHLAECKHMG(EDAGGAKPDDG FEIKNINOKPC, T MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4764A90", Offset = "0x4763C90", VA = "0x184764A90", Slot = "120")]
		protected sealed override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class NHNDPLPBAGG : APNAIIJKFII<JCPFAOLEDFL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9E3DD0", Offset = "0x9E2FD0", VA = "0x1809E3DD0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x21DF910", Offset = "0x21DEB10", VA = "0x1821DF910")]
		public NHNDPLPBAGG(EDAGGAKPDDG FEIKNINOKPC, JCPFAOLEDFL MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class FLLMHANCBKL : APNAIIJKFII<KBIHMEHCHMH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class IBLNLLPNAJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public FLLMHANCBKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public IBLNLLPNAJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x21D8900", Offset = "0x21D7B00", VA = "0x1821D8900")]
			internal int NGJPHKCEHLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x21D8870", Offset = "0x21D7A70", VA = "0x1821D8870")]
			internal void HPGIFPPDCIC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, KMMOFIPPECC>? FPKGPAJOGNE;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x21D6750", Offset = "0x21D5950", VA = "0x1821D6750")]
		public FLLMHANCBKL(EDAGGAKPDDG FEIKNINOKPC, KBIHMEHCHMH MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x21D63E0", Offset = "0x21D55E0", VA = "0x1821D63E0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class JGPNJLALLNN : MBHLAECKHMG<HPDDDGNFHCN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override ALNLJNEDEAK KHDJGOLOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "126")]
			get
			{
				return default(ALNLJNEDEAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x21D8D70", Offset = "0x21D7F70", VA = "0x1821D8D70")]
		public JGPNJLALLNN(EDAGGAKPDDG FEIKNINOKPC, HPDDDGNFHCN JANAFGLBOCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class NEIMKJBFADC : PBFGDBGFPGM<DNCEINNEHMI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x21DF4B0", Offset = "0x21DE6B0", VA = "0x1821DF4B0")]
		public NEIMKJBFADC(EDAGGAKPDDG FEIKNINOKPC, DNCEINNEHMI MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class ALGDGNHLCFD : PBFGDBGFPGM<DNINFIEIDKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x21CE4A0", Offset = "0x21CD6A0", VA = "0x1821CE4A0")]
		public ALGDGNHLCFD(EDAGGAKPDDG FEIKNINOKPC, DNINFIEIDKG MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class GKNFPKBOFJB : DLLLGOBGCHM<LJECKOJIGDP>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class LIOCJNKGCKD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public LIOCJNKGCKD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x21E2E20", Offset = "0x21E2020", VA = "0x1821E2E20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public GKNFPKBOFJB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LIOCJNKGCKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x21DD610", Offset = "0x21DC810", VA = "0x1821DD610")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void GMEEHBALEMH(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x21D7290", Offset = "0x21D6490", VA = "0x1821D7290")]
		public GKNFPKBOFJB(EDAGGAKPDDG FEIKNINOKPC, LJECKOJIGDP JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x21D6FB0", Offset = "0x21D61B0", VA = "0x1821D6FB0", Slot = "126")]
		protected override void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class BKJCPKNEADE : MBHLAECKHMG<EGIDFMPHCBO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override ALNLJNEDEAK KHDJGOLOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9FADB0", Offset = "0x9F9FB0", VA = "0x1809FADB0", Slot = "126")]
			get
			{
				return default(ALNLJNEDEAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x21CEA90", Offset = "0x21CDC90", VA = "0x1821CEA90")]
		public BKJCPKNEADE(EDAGGAKPDDG FEIKNINOKPC, EGIDFMPHCBO JANAFGLBOCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class PIIJFAEAICG : APNAIIJKFII<EGJCPICHIPN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBCBBC0", Offset = "0xBCADC0", VA = "0x180BCBBC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x21E29D0", Offset = "0x21E1BD0", VA = "0x1821E29D0")]
		public PIIJFAEAICG(EDAGGAKPDDG FEIKNINOKPC, EGJCPICHIPN MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class HOHDCEFEHKM : APNAIIJKFII<PNIGFKLOLPL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool FEMPPPDFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool EFHGFPAAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x21D8740", Offset = "0x21D7940", VA = "0x1821D8740")]
		public HOHDCEFEHKM(EDAGGAKPDDG FEIKNINOKPC, PNIGFKLOLPL MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x21D8370", Offset = "0x21D7570", VA = "0x1821D8370", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x21D8700", Offset = "0x21D7900", VA = "0x1821D8700")]
		private int OHLDPMBOLLH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x21D86A0", Offset = "0x21D78A0", VA = "0x1821D86A0")]
		private void KKAECPOKPGP(int ODDCGAGBKJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class NKFHAOHJKNG : OBJJMIOEKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x21DF980", Offset = "0x21DEB80", VA = "0x1821DF980")]
		public NKFHAOHJKNG(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class GLHEFIBHKGK : DLLLGOBGCHM<NGKNIBDJFJL>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x21D72F0", Offset = "0x21D64F0", VA = "0x1821D72F0")]
		public GLHEFIBHKGK(EDAGGAKPDDG FEIKNINOKPC, NGKNIBDJFJL MOPDELCEJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class DLLLGOBGCHM<TVariableNode> : APNAIIJKFII<TVariableNode> where TVariableNode : notnull, NGKNIBDJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class BPAFLGKCALL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public DLLLGOBGCHM<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public BPAFLGKCALL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x52F96C0", Offset = "0x52F88C0", VA = "0x1852F96C0")]
			internal bool KGCPFDDPLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x52F97E0", Offset = "0x52F89E0", VA = "0x1852F97E0")]
			internal void NGJPHKCEHLB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x52F9660", Offset = "0x52F8860", VA = "0x1852F9660")]
			internal bool HPGIFPPDCIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x52F9720", Offset = "0x52F8920", VA = "0x1852F9720")]
			internal void LKMAJLJJKFG(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x52F95B0", Offset = "0x52F87B0", VA = "0x1852F95B0")]
			internal bool ABHDPKLANKF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class NAHEBGOENBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public OMMABCMAHNJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public DLLLGOBGCHM<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public NAHEBGOENBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x480FB00", Offset = "0x480ED00", VA = "0x18480FB00")]
			internal void GMEEHBALEMH(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xD3E110", Offset = "0xD3D310", VA = "0x180D3E110", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NOOPAONCHDB HAINGAAPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x5B3F700", Offset = "0x5B3E900", VA = "0x185B3F700", Slot = "94")]
			get
			{
				return default(NOOPAONCHDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F560", Offset = "0x5B3E760", VA = "0x185B3F560")]
		protected DLLLGOBGCHM(EDAGGAKPDDG FEIKNINOKPC, TVariableNode MOPDELCEJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EBD0", Offset = "0x5B3DDD0", VA = "0x185B3EBD0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F0D0", Offset = "0x5B3E2D0", VA = "0x185B3F0D0", Slot = "120")]
		protected override void GJKIELJMNEA(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ED50", Offset = "0x5B3DF50", VA = "0x185B3ED50", Slot = "126")]
		protected virtual void ENLPPHECAMK(IOAPGBAGAAA MHGCHDPGHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EAE0", Offset = "0x5B3DCE0", VA = "0x185B3EAE0", Slot = "105")]
		public override void AKMCCPCKADJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x21AC530", Offset = "0x21AB730", VA = "0x1821AC530")]
	public static NJEHGCGMDBB MIFIOLMMIDE(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class PCKADIHMEFG : NKKIPAJHCAJ, BHNPEPMIFCA, POPNOIEKCJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GJCCLPKGONN<KEOFFAFEBNA> BGCGMAENDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9A9820", Offset = "0x9A8A20", VA = "0x1809A9820", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(GJCCLPKGONN<KEOFFAFEBNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GJCCLPKGONN<IHNEIIKOCEP> PJLNPENCPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9A9840", Offset = "0x9A8A40", VA = "0x1809A9840", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(GJCCLPKGONN<IHNEIIKOCEP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x21E1F80", Offset = "0x21E1180", VA = "0x1821E1F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GJCCLPKGONN<CGLJCKEDIBG> KOFKJMJEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA01880", Offset = "0xA00A80", VA = "0x180A01880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override GJCCLPKGONN<ACHJADOJBKC> JBCFBHPLBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x21E1F90", Offset = "0x21E1190", VA = "0x1821E1F90", Slot = "20")]
		get
		{
			return default(GJCCLPKGONN<ACHJADOJBKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x21E2330", Offset = "0x21E1530", VA = "0x1821E2330")]
	private PCKADIHMEFG(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO, BCHGFCNGAGL OFNMNCJGJNJ, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<IHNEIIKOCEP> NPHLMCCFBOL, GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM, bool MPLNGLKJBPE, string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x21E1FE0", Offset = "0x21E11E0", VA = "0x1821E1FE0")]
	public static PCKADIHMEFG MIFIOLMMIDE(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO, BCHGFCNGAGL EKGBCGOKPGJ, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM, GJCCLPKGONN<IHNEIIKOCEP> NPHLMCCFBOL, bool MPLNGLKJBPE, bool PJGLOKHODBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x21E1F80", Offset = "0x21E1180", VA = "0x1821E1F80")]
	internal void DKGCJCHDIOI(GJCCLPKGONN<IHNEIIKOCEP> JECHHBGMFLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class NKKIPAJHCAJ : POPNOIEKCJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct APJGOGIPAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private MOJFPADHGGH? EFIEGIAODPG;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x21CE9E0", Offset = "0x21CDBE0", VA = "0x1821CE9E0")]
		public void AODHOHPPLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x21CE9F0", Offset = "0x21CDBF0", VA = "0x1821CE9F0")]
		public MOJFPADHGGH GKMCDCPPHNL(NKKIPAJHCAJ OGHCBDPABMJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly MNIIIHLJBIO MGPBIMOLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private APJGOGIPAMO NFOJFFDLBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly MJKNHNBOHNF HAONCEKJHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<NGDBFBHMEFO> MEBBGOFMJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<DJFEDHMILDM> FIKHNPNHONC;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[NLMOIDEGKNH("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> EDBANOMBNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x21E0A00", Offset = "0x21DFC00", VA = "0x1821E0A00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind MPCHAOCFDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A5090", Offset = "0x8A4290", VA = "0x1808A5090", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GJCCLPKGONN<EJPHCCLFAJF> LAGDFJGMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x21E05C0", Offset = "0x21DF7C0", VA = "0x1821E05C0", Slot = "6")]
		get
		{
			return default(GJCCLPKGONN<EJPHCCLFAJF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JFDDFNFCNKH<EJPHCCLFAJF> NECCBABEDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x21DFEB0", Offset = "0x21DF0B0", VA = "0x1821DFEB0", Slot = "7")]
		get
		{
			return default(JFDDFNFCNKH<EJPHCCLFAJF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public APBIJNAHPCO KFICJABNBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2065330", Offset = "0x2064530", VA = "0x182065330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public NFBFAGBGHIK IHEHNIMMMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x21DFE10", Offset = "0x21DF010", VA = "0x1821DFE10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected MOJFPADHGGH DNFJOEDCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x21DFE10", Offset = "0x21DF010", VA = "0x1821DFE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage LJLLGPFIOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x21E05F0", Offset = "0x21DF7F0", VA = "0x1821E05F0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x894350", Offset = "0x893550", VA = "0x180894350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JFDDFNFCNKH<JKFBFCDNFMP> EDPLAHOCNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x21E07E0", Offset = "0x21DF9E0", VA = "0x1821E07E0", Slot = "9")]
		get
		{
			return default(JFDDFNFCNKH<JKFBFCDNFMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public GJCCLPKGONN<PNDOEKJDHKD> OLLDIBJBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x998FF0", Offset = "0x9981F0", VA = "0x180998FF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(GJCCLPKGONN<PNDOEKJDHKD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x998590", Offset = "0x997790", VA = "0x180998590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract GJCCLPKGONN<ACHJADOJBKC> JBCFBHPLBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x21E0D70", Offset = "0x21DFF70", VA = "0x1821E0D70")]
	protected NKKIPAJHCAJ(EDAGGAKPDDG FEIKNINOKPC, MNIIIHLJBIO MOPDELCEJCO, MJKNHNBOHNF EOAIGCCJHHM, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, bool MPLNGLKJBPE, string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x21DFB70", Offset = "0x21DED70", VA = "0x1821DFB70", Slot = "21")]
	protected virtual void DDNLIMMJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x21DFCC0", Offset = "0x21DEEC0", VA = "0x1821DFCC0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x21E0B40", Offset = "0x21DFD40", VA = "0x1821E0B40", Slot = "14")]
	public void OICHPLGGFLK(NGDBFBHMEFO LFJEHCDEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x21DFEE0", Offset = "0x21DF0E0", VA = "0x1821DFEE0", Slot = "15")]
	public void FICHGFKILPL(DJFEDHMILDM LFJEHCDEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21DFF40", Offset = "0x21DF140", VA = "0x1821DFF40", Slot = "16")]
	public void FKKPADDEEBI(ILGLFEOFNBL AICPONKAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x21E09A0", Offset = "0x21DFBA0", VA = "0x1821E09A0", Slot = "23")]
	protected virtual void NDBLAJNHEHK(ILGLFEOFNBL AICPONKAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x21DF9F0", Offset = "0x21DEBF0", VA = "0x1821DF9F0")]
	private void CGOJCFONGHA(bool JNLAAHCIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x21E0BC0", Offset = "0x21DFDC0", VA = "0x1821E0BC0")]
	private void POBLEECOLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x21E0800", Offset = "0x21DFA00", VA = "0x1821E0800")]
	private void MPNHCIBOOAM([In] LIIPCPAFKFK HOOBIBDCHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x21E0720", Offset = "0x21DF920", VA = "0x1821E0720", Slot = "17")]
	public void KBNEIAKPPLI(NGDBFBHMEFO LFJEHCDEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x21E0780", Offset = "0x21DF980", VA = "0x1821E0780", Slot = "18")]
	public void KGKFGOEPOAF(DJFEDHMILDM LFJEHCDEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x894350", Offset = "0x893550", VA = "0x180894350")]
	internal void MOAHHPBKGAI(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x21E0BA0", Offset = "0x21DFDA0", VA = "0x1821E0BA0")]
	internal void OLAMGMHPJOD(GIJIIMBDDBD LJHLMAFOMCA, APBIJNAHPCO EIHDAHDDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x998590", Offset = "0x997790", VA = "0x180998590")]
	internal void JFCMPJJHLHB(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class AINENMOGCPO : CGCNPKFOLDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class CIOLDKGGBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public EDAGGAKPDDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public MNIIIHLJBIO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CIOLDKGGBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x21D4720", Offset = "0x21D3920", VA = "0x1821D4720")]
		internal LNDGGDLFKNJ IHFJIMDEPMH((int PortDescIndex, int PortIndex, JONGHNMOEEB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x21D4690", Offset = "0x21D3890", VA = "0x1821D4690")]
		internal PCKADIHMEFG CKAICHEPLCM(BCHGFCNGAGL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct LINJEMKFDAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x21DD140", Offset = "0x21DC340", VA = "0x1821DD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x21DD5A0", Offset = "0x21DC7A0", VA = "0x1821DD5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct JGJMBKIDHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public GJCCLPKGONN<NFIAEODBBMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x21D89B0", Offset = "0x21D7BB0", VA = "0x1821D89B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x21D8D00", Offset = "0x21D7F00", VA = "0x1821D8D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct MGDKFJHEJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public GJCCLPKGONN<CGLJCKEDIBG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x21DDF40", Offset = "0x21DD140", VA = "0x1821DDF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x21DE290", Offset = "0x21DD490", VA = "0x1821DE290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct KFAHNBLHDAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public GJCCLPKGONN<NFIAEODBBMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public GJCCLPKGONN<NFIAEODBBMM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x21DA510", Offset = "0x21D9710", VA = "0x1821DA510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x21DA860", Offset = "0x21D9A60", VA = "0x1821DA860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct EEKIHLBAFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public GJCCLPKGONN<CGLJCKEDIBG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public GJCCLPKGONN<CGLJCKEDIBG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x21D56F0", Offset = "0x21D48F0", VA = "0x1821D56F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x21D5A40", Offset = "0x21D4C40", VA = "0x1821D5A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct ALMDIBAPFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x21CE500", Offset = "0x21CD700", VA = "0x1821CE500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x21CE970", Offset = "0x21CDB70", VA = "0x1821CE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct CGBMFAOAEKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x21CF1C0", Offset = "0x21CE3C0", VA = "0x1821CF1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x21CF510", Offset = "0x21CE710", VA = "0x1821CF510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct PEDIDHCHLOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public GJCCLPKGONN<NFIAEODBBMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x21E2610", Offset = "0x21E1810", VA = "0x1821E2610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x21E2960", Offset = "0x21E1B60", VA = "0x1821E2960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct BNABNJAPEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GJCCLPKGONN<CGLJCKEDIBG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x21CEE00", Offset = "0x21CE000", VA = "0x1821CEE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x21CF150", Offset = "0x21CE350", VA = "0x1821CF150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct JKKMHCIOBIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public FPBHJJDNMNB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public GJCCLPKGONN<NFIAEODBBMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x21DA110", Offset = "0x21D9310", VA = "0x1821DA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x21DA4A0", Offset = "0x21D96A0", VA = "0x1821DA4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct NFEDCFLBJKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AINENMOGCPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public FPBHJJDNMNB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public GJCCLPKGONN<CGLJCKEDIBG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private EPKPCCKMNFP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x21DF510", Offset = "0x21DE710", VA = "0x1821DF510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x21DF8A0", Offset = "0x21DEAA0", VA = "0x1821DF8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool AKGGPMOBPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool BHHJAKFFEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private DMBJJGMCBDP<ICEFOKPGJNF, LNDGGDLFKNJ> LFDEGDIALDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private DMBJJGMCBDP<ICEFOKPGJNF, FAAIJHFGPMB> AFBANKHLGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly MNIIIHLJBIO MGPBIMOLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private DMBJJGMCBDP<IHNEIIKOCEP, PCKADIHMEFG> INAADNLMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private DMBJJGMCBDP<IHNEIIKOCEP, BHNPEPMIFCA> LKMOPDNCLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? OAIBLFCFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly GJEECKOFBOD CGLMIPAFFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private GJCCLPKGONN<PNDOEKJDHKD> GBJPMMMKKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool PGADDCEKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? FDDAGCDHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? PDLHBILJCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<GJCCLPKGONN<ICEFOKPGJNF>>? HMMHPEDFDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<GJCCLPKGONN<IHNEIIKOCEP>>? PPLBMNMDDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private CGCNPKFOLDI.PJIPCPJBJIF? ABHCCNDOOOI;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NMGBLBLNOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x21CBCB0", Offset = "0x21CAEB0", VA = "0x1821CBCB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PPEIJLCPEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x21CC2D0", Offset = "0x21CB4D0", VA = "0x1821CC2D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DOLHPBJEIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x21CA840", Offset = "0x21C9A40", VA = "0x1821CA840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JFDDFNFCNKH<EJPHCCLFAJF> NECCBABEDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x21CA810", Offset = "0x21C9A10", VA = "0x1821CA810", Slot = "7")]
		get
		{
			return default(JFDDFNFCNKH<EJPHCCLFAJF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool HPNECPFAEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x21CA790", Offset = "0x21C9990", VA = "0x1821CA790", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public DMBJJGMCBDP<ICEFOKPGJNF, FAAIJHFGPMB> IDDJIEIMDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "9")]
		get
		{
			return default(DMBJJGMCBDP<ICEFOKPGJNF, FAAIJHFGPMB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x21C9210", Offset = "0x21C8410", VA = "0x1821C9210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JFDDFNFCNKH<JKFBFCDNFMP> EDPLAHOCNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x21CC490", Offset = "0x21CB690", VA = "0x1821CC490", Slot = "11")]
		get
		{
			return default(JFDDFNFCNKH<JKFBFCDNFMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DMBJJGMCBDP<IHNEIIKOCEP, BHNPEPMIFCA> BEMGIKJBOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340", Slot = "12")]
		get
		{
			return default(DMBJJGMCBDP<IHNEIIKOCEP, BHNPEPMIFCA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public GJCCLPKGONN<PNDOEKJDHKD> OLLDIBJBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9830", Offset = "0x9A8A30", VA = "0x1809A9830", Slot = "13")]
		get
		{
			return default(GJCCLPKGONN<PNDOEKJDHKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FBLOKPLCJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x21CB0D0", Offset = "0x21CA2D0", VA = "0x1821CB0D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x21C8490", Offset = "0x21C7690", VA = "0x1821C8490", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action FKOBNPJLKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x21C8FE0", Offset = "0x21C81E0", VA = "0x1821C8FE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x21CB7A0", Offset = "0x21CA9A0", VA = "0x1821CB7A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<GJCCLPKGONN<ICEFOKPGJNF>, GJCCLPKGONN<ICEFOKPGJNF>> EKFAIFFJCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x21CC310", Offset = "0x21CB510", VA = "0x1821CC310", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x21C8F20", Offset = "0x21C8120", VA = "0x1821C8F20", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<GJCCLPKGONN<ICEFOKPGJNF>, GJCCLPKGONN<ICEFOKPGJNF>> CCOGANDBMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x21C9090", Offset = "0x21C8290", VA = "0x1821C9090", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x21CE000", Offset = "0x21CD200", VA = "0x1821CE000", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<GJCCLPKGONN<IHNEIIKOCEP>, GJCCLPKGONN<IHNEIIKOCEP>> HPONDOKDKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x21CC120", Offset = "0x21CB320", VA = "0x1821CC120", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x21CD510", Offset = "0x21CC710", VA = "0x1821CD510", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<GJCCLPKGONN<IHNEIIKOCEP>, GJCCLPKGONN<IHNEIIKOCEP>> EBPPNFBKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x21C83D0", Offset = "0x21C75D0", VA = "0x1821C83D0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x21CC3D0", Offset = "0x21CB5D0", VA = "0x1821CC3D0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GJCCLPKGONN<ICEFOKPGJNF>, FAAIJHFGPMB> LLJBGDDLEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x21CB850", Offset = "0x21CAA50", VA = "0x1821CB850", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x21C8310", Offset = "0x21C7510", VA = "0x1821C8310", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GJCCLPKGONN<ICEFOKPGJNF>> CFLNOFCAJED
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x21CD950", Offset = "0x21CCB50", VA = "0x1821CD950", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x21CD780", Offset = "0x21CC980", VA = "0x1821CD780", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GJCCLPKGONN<ICEFOKPGJNF>, FAAIJHFGPMB> MJHNELFNHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x21CAAE0", Offset = "0x21C9CE0", VA = "0x1821CAAE0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x21C8AF0", Offset = "0x21C7CF0", VA = "0x1821C8AF0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<GJCCLPKGONN<IHNEIIKOCEP>, BHNPEPMIFCA> NBBFKCCDGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x21CABA0", Offset = "0x21C9DA0", VA = "0x1821CABA0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x21CA5B0", Offset = "0x21C97B0", VA = "0x1821CA5B0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<GJCCLPKGONN<IHNEIIKOCEP>> HKOLKKBGGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x21C9150", Offset = "0x21C8350", VA = "0x1821C9150", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x21C99F0", Offset = "0x21C8BF0", VA = "0x1821C99F0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GJCCLPKGONN<IHNEIIKOCEP>, BHNPEPMIFCA> CNBNMAEPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x21CA900", Offset = "0x21C9B00", VA = "0x1821CA900", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x21CD450", Offset = "0x21CC650", VA = "0x1821CD450", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x21CE0C0", Offset = "0x21CD2C0", VA = "0x1821CE0C0")]
	private AINENMOGCPO(bool MPLNGLKJBPE, EDAGGAKPDDG FEIKNINOKPC, bool DLDHOODALKF, DMBJJGMCBDP<ICEFOKPGJNF, LNDGGDLFKNJ> IKILLKMDKCN, DMBJJGMCBDP<ICEFOKPGJNF, FAAIJHFGPMB> KPHCBAAMCIN, MNIIIHLJBIO MOPDELCEJCO, DMBJJGMCBDP<IHNEIIKOCEP, PCKADIHMEFG> LHAMIBOABAD, DMBJJGMCBDP<IHNEIIKOCEP, BHNPEPMIFCA> IBKNFPNAHJJ, string? BIAAABBEHGC, GJEECKOFBOD IOCEGBFDPGG, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, bool PJGLOKHODBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x21CC740", Offset = "0x21CB940", VA = "0x1821CC740")]
	public static AINENMOGCPO MIFIOLMMIDE(bool MPLNGLKJBPE, EDAGGAKPDDG FEIKNINOKPC, bool DLDHOODALKF, MNIIIHLJBIO MOPDELCEJCO, GJEECKOFBOD IOCEGBFDPGG, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, bool PJGLOKHODBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x21C9240", Offset = "0x21C8440", VA = "0x1821C9240")]
	private void DDNLIMMJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x21C9AB0", Offset = "0x21C8CB0", VA = "0x1821C9AB0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x21CB170", Offset = "0x21CA370", VA = "0x1821CB170", Slot = "38")]
	[AsyncStateMachine(typeof(LINJEMKFDAC))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> GMIAMCIBMGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x21CDDD0", Offset = "0x21CCFD0", VA = "0x1821CDDD0")]
	private (CDPILLBMHMA, int)? PLNFFCOJEOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x21CC1E0", Offset = "0x21CB3E0", VA = "0x1821CC1E0")]
	private void KKDPCECGNDD(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x188F960", Offset = "0x188EB60", VA = "0x18188F960")]
	private void HILPBJECBEC(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x21CDA10", Offset = "0x21CCC10", VA = "0x1821CDA10")]
	private void PFFBNPNHPOD(int MPEOMAFHJGB, int DCCDACDNHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x21CD5D0", Offset = "0x21CC7D0", VA = "0x1821CD5D0")]
	private void OMJNOOGMPON(int MPEOMAFHJGB, int DCCDACDNHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x21C85B0", Offset = "0x21C77B0", VA = "0x1821C85B0")]
	private void BDMJKNJFCLD(int HGDLFNBJPJO, GJCCLPKGONN<ICEFOKPGJNF> LKLPBKFCOJH, JONGHNMOEEB HBNAJMHMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x21CC600", Offset = "0x21CB800", VA = "0x1821CC600")]
	private void LIGFPECLHNK(int JNLAAHCIJJI, GJCCLPKGONN<ICEFOKPGJNF> LKLPBKFCOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x21C8590", Offset = "0x21C7790", VA = "0x1821C8590")]
	private void APEDJKNPDJB(int JNLAAHCIJJI, GJCCLPKGONN<ICEFOKPGJNF> LKLPBKFCOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x21CB260", Offset = "0x21CA460", VA = "0x1821CB260")]
	private void GOHLGJPGHJB(int HGDLFNBJPJO, GJCCLPKGONN<ICEFOKPGJNF> LKLPBKFCOJH, JONGHNMOEEB HBNAJMHMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x21CC4B0", Offset = "0x21CB6B0", VA = "0x1821CC4B0")]
	private void LHEBEEMHCHO(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xD91030", Offset = "0xD90230", VA = "0x180D91030")]
	private void OCEPPHEBMPM(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x21C8BB0", Offset = "0x21C7DB0", VA = "0x1821C8BB0")]
	private void BJDKNDLKJML(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x188F960", Offset = "0x188EB60", VA = "0x18188F960")]
	private void KEOCNGKBCEA(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x21CB910", Offset = "0x21CAB10", VA = "0x1821CB910")]
	private void IOECFKEACAP(int MPEOMAFHJGB, int DCCDACDNHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x21C8530", Offset = "0x21C7730", VA = "0x1821C8530")]
	private void ANNKLCGINEM(int MPEOMAFHJGB, int DCCDACDNHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x21CCF10", Offset = "0x21CC110", VA = "0x1821CCF10")]
	private void MNHBPPNPBGE(int HGDLFNBJPJO, GJCCLPKGONN<IHNEIIKOCEP> LKLPBKFCOJH, BCHGFCNGAGL HBNAJMHMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x21CDDB0", Offset = "0x21CCFB0", VA = "0x1821CDDB0")]
	private void PGBIDHGNDLC(int JNLAAHCIJJI, GJCCLPKGONN<IHNEIIKOCEP> LKLPBKFCOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x21CD760", Offset = "0x21CC960", VA = "0x1821CD760")]
	private void ONGFGMDMPFL(int JNLAAHCIJJI, GJCCLPKGONN<IHNEIIKOCEP> LKLPBKFCOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x21CAC60", Offset = "0x21C9E60", VA = "0x1821CAC60")]
	private void GIOFDPGHKNO(int HGDLFNBJPJO, GJCCLPKGONN<IHNEIIKOCEP> LKLPBKFCOJH, BCHGFCNGAGL HBNAJMHMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x21C8DD0", Offset = "0x21C7FD0", VA = "0x1821C8DD0")]
	private void BMICFPKHGHH(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xD91030", Offset = "0xD90230", VA = "0x180D91030")]
	private void JNIMFJFFNGA(int HGDLFNBJPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x21CD840", Offset = "0x21CCA40", VA = "0x1821CD840", Slot = "39")]
	[AsyncStateMachine(typeof(JGJMBKIDHOM))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> PBKMNHLBAHN(GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x21C8200", Offset = "0x21C7400", VA = "0x1821C8200", Slot = "40")]
	[AsyncStateMachine(typeof(MGDKFJHEJPE))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> AAJBNLAEPKJ(GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x21CC620", Offset = "0x21CB820", VA = "0x1821CC620", Slot = "41")]
	[AsyncStateMachine(typeof(KFAHNBLHDAH))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> MGINIMIKGCK(GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA, GJCCLPKGONN<NFIAEODBBMM> ONJOOCFJHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x21CA670", Offset = "0x21C9870", VA = "0x1821CA670", Slot = "42")]
	[AsyncStateMachine(typeof(EEKIHLBAFJL))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> ECMDKOHGIED(GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM, GJCCLPKGONN<CGLJCKEDIBG> ONJOOCFJHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x21CB6B0", Offset = "0x21CA8B0", VA = "0x1821CB6B0", Slot = "43")]
	[AsyncStateMachine(typeof(ALMDIBAPFFO))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> HFEGINAEKCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x21CA9C0", Offset = "0x21C9BC0", VA = "0x1821CA9C0", Slot = "44")]
	[AsyncStateMachine(typeof(CGBMFAOAEKF))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> FGFBCGMBPNB(string CKNPCFBJILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x21CD630", Offset = "0x21CC830", VA = "0x1821CD630", Slot = "45")]
	[AsyncStateMachine(typeof(PEDIDHCHLOP))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> OMPEJKGJDHI(GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA, string EPPPGDEIJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x21CCDE0", Offset = "0x21CBFE0", VA = "0x1821CCDE0", Slot = "46")]
	[AsyncStateMachine(typeof(BNABNJAPEOK))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> MLGOHCEMNNF(GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM, string EPPPGDEIJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x21CCCB0", Offset = "0x21CBEB0", VA = "0x1821CCCB0", Slot = "47")]
	[AsyncStateMachine(typeof(JKKMHCIOBIK))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> MKAAIKLCHCD(GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA, FPBHJJDNMNB EIHDAHDDDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x21C8CA0", Offset = "0x21C7EA0", VA = "0x1821C8CA0", Slot = "48")]
	[AsyncStateMachine(typeof(NFEDCFLBJKF))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> BJHPHOLAOAK(GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM, FPBHJJDNMNB EIHDAHDDDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x21CBD70", Offset = "0x21CAF70", VA = "0x1821CBD70")]
	internal void JFCMPJJHLHB(GJCCLPKGONN<PNDOEKJDHKD> JECHHBGMFLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class OEIIELLDBDK : JOLJBBEOFAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface ELCLOAEBPJL
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		GIJIIMBDDBD MNGIAPOEIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<POAKEMJOLKP> BHKGMLLNFPP(CancellationToken DDNLBFLLCLM);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<NFPGJPJJCOP> BDJKMCDIKEG(CancellationToken DDNLBFLLCLM);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<AKNNAIPAAAF> JACELECLKIG(CancellationToken DDNLBFLLCLM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MNFLPMGEDKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<OEIIELLDBDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public EDAGGAKPDDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public POAKEMJOLKP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public NFPGJPJJCOP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private ELCLOAEBPJL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private NFPGJPJJCOP <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<POAKEMJOLKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<NFPGJPJJCOP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<AKNNAIPAAAF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<NNKACLEGANH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x21DE300", Offset = "0x21DD500", VA = "0x1821DE300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x21DED10", Offset = "0x21DDF10", VA = "0x1821DED10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly NNKACLEGANH BADJJKMJMCL;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NNKACLEGANH PEKGPHAEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	private OEIIELLDBDK(NNKACLEGANH NPJIMGAJFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x21E1340", Offset = "0x21E0540", VA = "0x1821E1340")]
	[AsyncStateMachine(typeof(MNFLPMGEDKE))]
	public static Task<OEIIELLDBDK> FFCDDEAGMDA(EDAGGAKPDDG FEIKNINOKPC, POAKEMJOLKP? AICAHIPDPHC, NFPGJPJJCOP? HNMCNGMNKIO, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x21E1320", Offset = "0x21E0520", VA = "0x1821E1320", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct EBEOFFDDEEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MGDJONKEIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public EBEOFFDDEEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public IBMALGPEGND action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x21DDC40", Offset = "0x21DCE40", VA = "0x1821DDC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x21DDED0", Offset = "0x21DD0D0", VA = "0x1821DDED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NLPMJHMDACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public NBBJGCPEPPG rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public POAKEMJOLKP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NFPGJPJJCOP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public EBEOFFDDEEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private IBMALGPEGND[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x21E0ED0", Offset = "0x21E00D0", VA = "0x1821E0ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x21E12B0", Offset = "0x21E04B0", VA = "0x1821E12B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct GNGBGILKOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public EBEOFFDDEEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x21D7350", Offset = "0x21D6550", VA = "0x1821D7350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x21D7590", Offset = "0x21D6790", VA = "0x1821D7590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly LGCMAGEOKHH DFBMDIEJNPB;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	public EBEOFFDDEEB(LGCMAGEOKHH LNNDAFFMAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x21D5250", Offset = "0x21D4450", VA = "0x1821D5250")]
	[AsyncStateMachine(typeof(MGDJONKEIBL))]
	private Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> CLKMGPFIPCA(IBMALGPEGND ECFGAICLGCA, bool DCDLPLKJNBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x21D5470", Offset = "0x21D4670", VA = "0x1821D5470")]
	[AsyncStateMachine(typeof(NLPMJHMDACC))]
	public Task<KJEOKHCIBGM<bool, IJNOPJPLCIM?>>? JPDFKFHFFDM(int FPLJHJKPJML, NBBJGCPEPPG? CFILLPNNBGA, POAKEMJOLKP? AECELIKKPLN, NFPGJPJJCOP? HNMCNGMNKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x21D5380", Offset = "0x21D4580", VA = "0x1821D5380")]
	[AsyncStateMachine(typeof(GNGBGILKOEL))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> GJKAEPPOOPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class LAFFGDLDJEM : MJGKHJJPNHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly PKLHHCHKJNO ECGHMGJOIAG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PKLHHCHKJNO NPHAGGJPNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	private LAFFGDLDJEM(PKLHHCHKJNO LNLKIOFCCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x21DC900", Offset = "0x21DBB00", VA = "0x1821DC900")]
	public static LAFFGDLDJEM GBKBNNNFJGC(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x21DC8E0", Offset = "0x21DBAE0", VA = "0x1821DC8E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface CAGNMKPFHGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	NNKACLEGANH PEKGPHAEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	EMNGFMEJKPM DOOKDKIOLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	CBBNGNNIFAN GMKPEFJILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CGDGCAEHEEL MCOODMGALMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface JMJIBDMBIID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	CAGNMKPFHGF? MANBGMDABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool LDONACDLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool EPAJOFLCAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CAGNMKPFHGF?>? GGJAJGLJJLB();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HEKLPNCOFPL(EDAGGAKPDDG FEIKNINOKPC, NBBJGCPEPPG NDLFCIMICGE, POAKEMJOLKP? LIDHOKLEPAF, NFPGJPJJCOP? EOKACCMCNCD);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[LBOOJLEKELP("IStaticCV2Instance")]
public interface JOLJBBEOFAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	NNKACLEGANH PEKGPHAEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[LBOOJLEKELP("IStaticEVInstance")]
public interface MJGKHJJPNHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	PKLHHCHKJNO NPHAGGJPNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class LHPFECLPOBA
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x21DCC90", Offset = "0x21DBE90", VA = "0x1821DCC90")]
	public static JIPBALMMOGA<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> GLBELGOOGBA([In] this JIPBALMMOGA<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>> MKKLCDEHAGN)
	{
		return default(JIPBALMMOGA<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG, LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class PMNCBBJIPJC : ACFCEFOJGEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool EPAJOFLCAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x21E2E00", Offset = "0x21E2000", VA = "0x1821E2E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	internal PMNCBBJIPJC(EDAGGAKPDDG FEIKNINOKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class HHNECOECANL : EMMBJOBALJI
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x21D7910", Offset = "0x21D6B10", VA = "0x1821D7910", Slot = "4")]
	public OONKGBFAGCK? LNLHKBADONC(string? CPBCHJCONNH, string? IAHOHDPALHK, string? HFPKNHJDOOK, HJEPJBOMFHB.HMBEPNIOKDD.PHBGGKNNBKN KEIEHIPOPLA, bool IJOKDCCKNHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public HHNECOECANL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class HMBIKHKKOJM : EDGIAIMEMBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct HECEEPFGDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<MONPBPLADEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HMBIKHKKOJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<CAGNMKPFHGF?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x21D7600", Offset = "0x21D6800", VA = "0x1821D7600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x21D78A0", Offset = "0x21D6AA0", VA = "0x1821D78A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<JFDDFNFCNKH<DIFGJKIDHIA>>? OGPLIFDDODF;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MONPBPLADEK? FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x21D7B80", Offset = "0x21D6D80", VA = "0x1821D7B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CGDGCAEHEEL? AOKFIJFBDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x21D82F0", Offset = "0x21D74F0", VA = "0x1821D82F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool IFICIJPPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x21D8290", Offset = "0x21D7490", VA = "0x1821D8290", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool BOMOCKDKBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x21D8060", Offset = "0x21D7260", VA = "0x1821D8060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	internal HMBIKHKKOJM(EDAGGAKPDDG FEIKNINOKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x21D7F70", Offset = "0x21D7170", VA = "0x1821D7F70", Slot = "7")]
	[AsyncStateMachine(typeof(HECEEPFGDEF))]
	public Task<MONPBPLADEK> GGMKLDOMLCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x21D7C00", Offset = "0x21D6E00", VA = "0x1821D7C00", Slot = "9")]
	public IReadOnlyDictionary<JFDDFNFCNKH<EJPHCCLFAJF>, Guid> EBMFNPMNMFP(IEnumerable<EJACNHLCCNH> OFPHJGIINNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x21D79B0", Offset = "0x21D6BB0", VA = "0x1821D79B0")]
	public KJEOKHCIBGM<PFJCCNOFOBE, NDNNGNKGHFF> AADNMIFEFFE([In] PFJCCNOFOBE DIMPOACBIEC, IEnumerable<EJACNHLCCNH> FLCCHBKAFHO, int APGPGDKOFKG)
	{
		return default(KJEOKHCIBGM<PFJCCNOFOBE, NDNNGNKGHFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x21D80C0", Offset = "0x21D72C0", VA = "0x1821D80C0", Slot = "8")]
	private KJEOKHCIBGM<PFJCCNOFOBE, NDNNGNKGHFF> LCPKCBNJLJI([In] PFJCCNOFOBE DIMPOACBIEC, IEnumerable<EJACNHLCCNH> FLCCHBKAFHO, int APGPGDKOFKG)
	{
		return default(KJEOKHCIBGM<PFJCCNOFOBE, NDNNGNKGHFF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class CGDGCAEHEEL : MONPBPLADEK
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class KOEFEODKMNL
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class FHDAGHCHGCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public NNKACLEGANH state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public GMCDLDCGJGB spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public FHDAGHCHGCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x21D62F0", Offset = "0x21D54F0", VA = "0x1821D62F0")]
			internal bool BCPDMFEHINF(NECNHNCODBL n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class CHFLKIJLKEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public CHFLKIJLKEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x21D4670", Offset = "0x21D3870", VA = "0x1821D4670")]
			internal void KDIDPECIAKG(NECNHNCODBL n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x21DBF70", Offset = "0x21DB170", VA = "0x1821DBF70")]
		public static KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF> JJJKKJJOEON(CGDGCAEHEEL AEFKHDNCNFD, [In] MONPBPLADEK.LLEALHJKPAJ KLDEANCBDEG)
		{
			return default(KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x21DB130", Offset = "0x21DA330", VA = "0x1821DB130")]
		internal static KJEOKHCIBGM<(AAAEKCMLEOH, CEOOEOBEFLF), KPFAPPGFMLF> FMPHEEJHOIO(CGDGCAEHEEL AEFKHDNCNFD, CEOOEOBEFLF GDKIPPMHOCG, bool FKAPOAAECFL, [In] JFDDFNFCNKH<EJPHCCLFAJF> GFPHECKFHJG, [In] int? APLKODHAPOF, [In] JMFFCBMGCHD? HCCKFBAJAMA, [In] JMFFCBMGCHD? KMJMNFMNIIN)
		{
			return default(KJEOKHCIBGM<(AAAEKCMLEOH, CEOOEOBEFLF), KPFAPPGFMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x21DACF0", Offset = "0x21D9EF0", VA = "0x1821DACF0")]
		private static void COBFFCJNPMK(bool FKAPOAAECFL, EJACNHLCCNH BDKKOCLKBDN, AAAEKCMLEOH DPEEJPHPNPF, [In] JFDDFNFCNKH<EJPHCCLFAJF> GFPHECKFHJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x21DC4D0", Offset = "0x21DB6D0", VA = "0x1821DC4D0")]
		public static void PGCFHIIJOPD(EPHMIGNHEKE DPJMCGMNAIG, [In] MONPBPLADEK.LEDBNENDNMK MBEJDIFFFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x21DAC00", Offset = "0x21D9E00", VA = "0x1821DAC00")]
		[CompilerGenerated]
		internal static bool AAHGILPNHBD(NNKACLEGANH JBOFEMGJEGF, GMCDLDCGJGB IOAKEFMKBAB, NECNHNCODBL GJGNEAHBLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x21DBF40", Offset = "0x21DB140", VA = "0x1821DBF40")]
		[CompilerGenerated]
		internal static bool GPEOCDJNKHD(NECNHNCODBL EFECIMDANAO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct EMNPLAONIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CGDGCAEHEEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public GJCCLPKGONN<EJPHCCLFAJF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public GJCCLPKGONN<KEOFFAFEBNA> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public GJCCLPKGONN<BLNNADLBCOP> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x21D5B90", Offset = "0x21D4D90", VA = "0x1821D5B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x21D61E0", Offset = "0x21D53E0", VA = "0x1821D61E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct DJLKCGIGOFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CGDGCAEHEEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public JFDDFNFCNKH<JKFBFCDNFMP> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JFDDFNFCNKH<EJPHCCLFAJF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public GJCCLPKGONN<PNDOEKJDHKD> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public GJCCLPKGONN<ICEFOKPGJNF> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x21D4AA0", Offset = "0x21D3CA0", VA = "0x1821D4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x21D4DE0", Offset = "0x21D3FE0", VA = "0x1821D4DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct DDDGOOOIJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CGDGCAEHEEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JFDDFNFCNKH<JKFBFCDNFMP> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public JFDDFNFCNKH<EJPHCCLFAJF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public GJCCLPKGONN<PNDOEKJDHKD> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public GJCCLPKGONN<IHNEIIKOCEP> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x21E4F10", Offset = "0x21E4110", VA = "0x1821E4F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x21E5250", Offset = "0x21E4450", VA = "0x1821E5250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly EDAGGAKPDDG FHGLJIGGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly JOLJBBEOFAN MDKCLDDFONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly MJGKHJJPNHJ LAIFMPOEEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly MLGKICPLDAO ADEOCMHOEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly HMBIKHKKOJM HJLDMKEPLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<JFDDFNFCNKH<JKFBFCDNFMP>, NJEHGCGMDBB> PMGKCEBMJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<JFDDFNFCNKH<JKFBFCDNFMP>>? IDJAHIHAACB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JFDDFNFCNKH<EJPHCCLFAJF> JPJOCEFDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x21CFFC0", Offset = "0x21CF1C0", VA = "0x1821CFFC0", Slot = "4")]
		get
		{
			return default(JFDDFNFCNKH<EJPHCCLFAJF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MLGKICPLDAO PMNEANFDGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x21AF770", Offset = "0x21AE970", VA = "0x1821AF770", Slot = "5")]
		get
		{
			return default(MLGKICPLDAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x21D4150", Offset = "0x21D3350", VA = "0x1821D4150")]
	public CGDGCAEHEEL(EDAGGAKPDDG FEIKNINOKPC, JOLJBBEOFAN DDJNPHIHCDH, MJGKHJJPNHJ OMBJLPMAAJE, HMBIKHKKOJM DKCKMHIMFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x21D4010", Offset = "0x21D3210", VA = "0x1821D4010", Slot = "48")]
	public GJCCLPKGONN<IMGLNEPMAGM> OIMGGIHGEEO(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<BLNNADLBCOP> FDFICHJDGEE)
	{
		return default(GJCCLPKGONN<IMGLNEPMAGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x21CFBF0", Offset = "0x21CEDF0", VA = "0x1821CFBF0", Slot = "49")]
	public GJCCLPKGONN<JNICELAEOFA> AINPILFIAMB(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> NPHLMCCFBOL)
	{
		return default(GJCCLPKGONN<JNICELAEOFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x21D31E0", Offset = "0x21D23E0", VA = "0x1821D31E0", Slot = "6")]
	public (bool, bool) NHHILNCMKJM(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> GAGOOEGHACG, GJCCLPKGONN<BLNNADLBCOP> HCOAAGDHDEP)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x21D2CC0", Offset = "0x21D1EC0", VA = "0x1821D2CC0")]
	public bool MMAKFKHJCCC(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] OMCGLEEHDAE GCLJBEFHJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x21D1DA0", Offset = "0x21D0FA0", VA = "0x1821D1DA0", Slot = "8")]
	public bool KDABLBJACOG(FAAIJHFGPMB JMKHFOHBMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x21D1A40", Offset = "0x21D0C40", VA = "0x1821D1A40", Slot = "9")]
	public bool IPJKHNBGJFC(BHNPEPMIFCA LKJIIAHPDIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x21D36E0", Offset = "0x21D28E0", VA = "0x1821D36E0", Slot = "10")]
	public OMKCELDJKBB? NLHICKCFAAC(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<BLNNADLBCOP> FDFICHJDGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x21D1EA0", Offset = "0x21D10A0", VA = "0x1821D1EA0", Slot = "11")]
	public GKLLCDIAMBK? KNNLIODOIPC(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> NPHLMCCFBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x21D2B90", Offset = "0x21D1D90", VA = "0x1821D2B90", Slot = "12")]
	public IEnumerable<GJCCLPKGONN<PHGGEFNECEK>> MFPOPFHPOEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x21D0C80", Offset = "0x21CFE80", VA = "0x1821D0C80", Slot = "13")]
	public string EMLDJHICHMG(GJCCLPKGONN<PHGGEFNECEK> CIFIIDONOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x21D3140", Offset = "0x21D2340", VA = "0x1821D3140", Slot = "14")]
	public string NCNGDIGCJPG(GJCCLPKGONN<PHGGEFNECEK> CIFIIDONOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x21D09E0", Offset = "0x21CFBE0", VA = "0x1821D09E0")]
	public NJEHGCGMDBB? EHIBDGMADHJ([In] JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x21CFD70", Offset = "0x21CEF70", VA = "0x1821CFD70")]
	public GJCCLPKGONN<JKFBFCDNFMP> INKNLPIKNIP(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] JFDDFNFCNKH<JKFBFCDNFMP> OFGDIOEGJIN)
	{
		return default(GJCCLPKGONN<JKFBFCDNFMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x21CFE80", Offset = "0x21CF080", VA = "0x1821CFE80", Slot = "26")]
	public GJCCLPKGONN<JKFBFCDNFMP> CKFJPFNMPFJ(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<BLNNADLBCOP> FDFICHJDGEE)
	{
		return default(GJCCLPKGONN<JKFBFCDNFMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x21D1E20", Offset = "0x21D1020", VA = "0x1821D1E20", Slot = "27")]
	public GJCCLPKGONN<JKFBFCDNFMP> KFCAGLAHDLC(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> NPHLMCCFBOL)
	{
		return default(GJCCLPKGONN<JKFBFCDNFMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x21D15C0", Offset = "0x21D07C0", VA = "0x1821D15C0")]
	private void GJANOCPFMAE(JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x21D0AE0", Offset = "0x21CFCE0", VA = "0x1821D0AE0")]
	public IEnumerable<NJEHGCGMDBB> ELMOLLEPBDI([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x21D0020", Offset = "0x21CF220", VA = "0x1821D0020", Slot = "25")]
	public GJCCLPKGONN<BLNNADLBCOP> DCKNCBBAMNK(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<IMGLNEPMAGM> NHOEEIGKLHK)
	{
		return default(GJCCLPKGONN<BLNNADLBCOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x21D1AC0", Offset = "0x21D0CC0", VA = "0x1821D1AC0", Slot = "28")]
	public GJCCLPKGONN<KEOFFAFEBNA> JBCAAEKLKAK(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<JNICELAEOFA> PMOHOGGCKDA)
	{
		return default(GJCCLPKGONN<KEOFFAFEBNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x21D4110", Offset = "0x21D3310", VA = "0x1821D4110")]
	private NJEHGCGMDBB? PPDFCPPKEIK([In] JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x21D0160", Offset = "0x21CF360", VA = "0x1821D0160")]
	private NJEHGCGMDBB DPEGHOIJCFE([In] JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH, MNIIIHLJBIO MOPDELCEJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x21CFDF0", Offset = "0x21CEFF0", VA = "0x1821CFDF0")]
	public MNIIIHLJBIO? CJKNFMAKIPO([In] JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x21D00B0", Offset = "0x21CF2B0", VA = "0x1821D00B0")]
	public JKKGEHGGKGE? JKNKMIHFHDC([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x21CFF00", Offset = "0x21CF100", VA = "0x1821CFF00", Slot = "20")]
	public IEnumerable<BFOIOFJKFEA> CMGEIGPHHAM(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x21D0E50", Offset = "0x21D0050", VA = "0x1821D0E50", Slot = "21")]
	public bool FKGHFJLIPPC(GJCCLPKGONN<PHGGEFNECEK> CIFIIDONOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x21D3CA0", Offset = "0x21D2EA0", VA = "0x1821D3CA0", Slot = "22")]
	public IEnumerable<OMCGLEEHDAE> OGPGBEFHMLG(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> GAGOOEGHACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x21D3A20", Offset = "0x21D2C20", VA = "0x1821D3A20", Slot = "23")]
	public IEnumerable<OMCGLEEHDAE> ODDLDNMNKLE(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<BLNNADLBCOP> HCOAAGDHDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x21D1650", Offset = "0x21D0850", VA = "0x1821D1650")]
	public GJCCLPKGONN<EJPHCCLFAJF> GPLMNMMAGPM([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return default(GJCCLPKGONN<EJPHCCLFAJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x21D00E0", Offset = "0x21CF2E0", VA = "0x1821D00E0")]
	public GJCCLPKGONN<EJPHCCLFAJF>? LMCGPJBHOLB([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x21D0BC0", Offset = "0x21CFDC0", VA = "0x1821D0BC0")]
	private GMCDLDCGJGB? EMFDBCOLKCI([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x21D00B0", Offset = "0x21CF2B0", VA = "0x1821D00B0")]
	private JKKGEHGGKGE? DDLEACMJODO([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x21CFA20", Offset = "0x21CEC20", VA = "0x1821CFA20", Slot = "32")]
	public JFDDFNFCNKH<EJPHCCLFAJF> AFPJHAKBIBF(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return default(JFDDFNFCNKH<EJPHCCLFAJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x21CFC70", Offset = "0x21CEE70", VA = "0x1821CFC70", Slot = "29")]
	public IEnumerable<FPBHJJDNMNB> AMLEOFDGEFL(KIBLIHFBBGG OFIKFHEKDBO, bool HDBDFBMMKNM, bool GPKIKOADBOG, bool ADPKGGINGAH, bool FLNNECLKBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x21D1730", Offset = "0x21D0930", VA = "0x1821D1730", Slot = "30")]
	public FPBHJJDNMNB HIHEFBJBJNM(KIBLIHFBBGG OFIKFHEKDBO, POPNOIEKCJO MCAKAJCIMOK, bool HDBDFBMMKNM, bool GPKIKOADBOG, bool ADPKGGINGAH, bool FLNNECLKBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x21D2320", Offset = "0x21D1520", VA = "0x1821D2320")]
	public BFOIOFJKFEA MAKOMELKGDL(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] OMCGLEEHDAE GCLJBEFHJPC)
	{
		return default(BFOIOFJKFEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x21D2560", Offset = "0x21D1760", VA = "0x1821D2560", Slot = "33")]
	public OMCGLEEHDAE LOJBNNIDOLN(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> GAGOOEGHACG, GJCCLPKGONN<BLNNADLBCOP> HCOAAGDHDEP)
	{
		return default(OMCGLEEHDAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x21D2490", Offset = "0x21D1690", VA = "0x1821D2490", Slot = "34")]
	public bool LFBHEGFFKMK(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x21D1D20", Offset = "0x21D0F20", VA = "0x1821D1D20", Slot = "35")]
	public bool JMMIDCBHBAF(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<BLNNADLBCOP> FDFICHJDGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x21D2B10", Offset = "0x21D1D10", VA = "0x1821D2B10", Slot = "36")]
	public bool MFDHOOEFNJC(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> NPHLMCCFBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x21D31B0", Offset = "0x21D23B0", VA = "0x1821D31B0")]
	public KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF> NFLHOELFHIO([In] MONPBPLADEK.LLEALHJKPAJ KLDEANCBDEG)
	{
		return default(KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x21D0EE0", Offset = "0x21D00E0", VA = "0x1821D0EE0", Slot = "38")]
	[AsyncStateMachine(typeof(EMNPLAONIHK))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> GEGOGHMMCPG(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, GJCCLPKGONN<KEOFFAFEBNA> GAGOOEGHACG, GJCCLPKGONN<BLNNADLBCOP> HCOAAGDHDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x21D1F60", Offset = "0x21D1160", VA = "0x1821D1F60", Slot = "39")]
	public KJEOKHCIBGM<PLHFINKOLBB, NDNNGNKGHFF> KPFGLBOOFFH(JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL, PLHFINKOLBB IMCBACBOIHH, PKEMICAKFDH HFMFGBPIGJL)
	{
		return default(KJEOKHCIBGM<PLHFINKOLBB, NDNNGNKGHFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x21CFA90", Offset = "0x21CEC90", VA = "0x1821CFA90", Slot = "40")]
	[AsyncStateMachine(typeof(DJLKCGIGOFO))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> AGHJKLOHPMH(JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL, JFDDFNFCNKH<JKFBFCDNFMP> ABEHMDKHGPJ, GJCCLPKGONN<PNDOEKJDHKD> CNOJFDAOPOC, GJCCLPKGONN<ICEFOKPGJNF> FDFICHJDGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x21D37A0", Offset = "0x21D29A0", VA = "0x1821D37A0", Slot = "41")]
	[AsyncStateMachine(typeof(DDDGOOOIJHN))]
	public Task<KJEOKHCIBGM<EPFCCNCFAEJ, IJNOPJPLCIM>> OAFGNEIKAFI(JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL, JFDDFNFCNKH<JKFBFCDNFMP> JEDMOAODJHF, GJCCLPKGONN<PNDOEKJDHKD> NBGKJKGBIOI, GJCCLPKGONN<IHNEIIKOCEP> NPHLMCCFBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x21D1B50", Offset = "0x21D0D50", VA = "0x1821D1B50", Slot = "42")]
	public JEGGEDIFOJA JEGOOCNBHHH(IEnumerable<EJACNHLCCNH> FLCCHBKAFHO)
	{
		return default(JEGGEDIFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x21D3900", Offset = "0x21D2B00", VA = "0x1821D3900", Slot = "43")]
	public JEGGEDIFOJA OAIDIFLKFAP()
	{
		return default(JEGGEDIFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x21D1410", Offset = "0x21D0610", VA = "0x1821D1410")]
	private IFINKGIMIBM GGHKLONONPA(INGPKEPCHCJ OHKAIEHGIJM, GJCCLPKGONN<EJPHCCLFAJF> HOLODOCCCKK, IEnumerable<JFDDFNFCNKH<EJPHCCLFAJF>> EKOCNDMCLIB, IEnumerable<JFDDFNFCNKH<JKFBFCDNFMP>> BIAGGLFDKMJ)
	{
		return default(IFINKGIMIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x21D10F0", Offset = "0x21D02F0", VA = "0x1821D10F0", Slot = "44")]
	public IFINKGIMIBM GGHKLONONPA(INGPKEPCHCJ OHKAIEHGIJM, GJCCLPKGONN<EJPHCCLFAJF> HOLODOCCCKK, IEnumerable<JFDDFNFCNKH<JKFBFCDNFMP>> BIAGGLFDKMJ, IEnumerable<EJACNHLCCNH> FLCCHBKAFHO)
	{
		return default(IFINKGIMIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x21D2790", Offset = "0x21D1990", VA = "0x1821D2790")]
	private static IEnumerable<JFDDFNFCNKH<EJPHCCLFAJF>> MDCEAAMJMGB(IEnumerable<EJACNHLCCNH> FLCCHBKAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x21CF580", Offset = "0x21CE780", VA = "0x1821CF580")]
	private IEnumerable<JFDDFNFCNKH<JKFBFCDNFMP>> ABNPDBKCAHO(IEnumerable<EJACNHLCCNH> FLCCHBKAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x21D0DC0", Offset = "0x21CFFC0", VA = "0x1821D0DC0", Slot = "45")]
	public List<MFHIJKGOLHM> FFEIDHHMNDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x21D0230", Offset = "0x21CF430", VA = "0x1821D0230")]
	public (List<MFHIJKGOLHM>, bool) EBLCMPLDKDK([In] GMNHPKJPCFH ACEAEOMDHEN, string GFIAFOEJCDD, [In] HKKDANEFDJO KENMIINODFC, CKGNJKGFKPE GPHILNDNKBA, DEJALPNGGEI ODBKEKEDHIC)
	{
		return default((List<MFHIJKGOLHM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x21D08F0", Offset = "0x21CFAF0", VA = "0x1821D08F0", Slot = "47")]
	public bool EGCHICBJEFN(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x21D2500", Offset = "0x21D1700", VA = "0x1821D2500")]
	internal void LFMACLOBNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x21D0D60", Offset = "0x21CFF60", VA = "0x1821D0D60")]
	internal Task FEEIDPADIHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x21D4100", Offset = "0x21D3300", VA = "0x1821D4100", Slot = "7")]
	private bool PLCLDIODNEM(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] OMCGLEEHDAE GCLJBEFHJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x21D00B0", Offset = "0x21CF2B0", VA = "0x1821D00B0", Slot = "15")]
	private JKKGEHGGKGE OPCKNIKFJFH([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x21D1650", Offset = "0x21D0850", VA = "0x1821D1650", Slot = "16")]
	private GJCCLPKGONN<EJPHCCLFAJF> JDAMKHGGKOK([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return default(GJCCLPKGONN<EJPHCCLFAJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x21D00E0", Offset = "0x21CF2E0", VA = "0x1821D00E0", Slot = "17")]
	private GJCCLPKGONN<EJPHCCLFAJF>? DKEJDOKFPPN([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x21D3F20", Offset = "0x21D3120", VA = "0x1821D3F20", Slot = "18")]
	private NJEHGCGMDBB OIAEKIKHNCO([In] JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x21CFD70", Offset = "0x21CEF70", VA = "0x1821CFD70", Slot = "19")]
	private GJCCLPKGONN<JKFBFCDNFMP> CDBIGIPNFDP(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] JFDDFNFCNKH<JKFBFCDNFMP> OFGDIOEGJIN)
	{
		return default(GJCCLPKGONN<JKFBFCDNFMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x21D1010", Offset = "0x21D0210", VA = "0x1821D1010", Slot = "24")]
	private IEnumerable<NJEHGCGMDBB> GFIENAELNKG([In] JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x21D2320", Offset = "0x21D1520", VA = "0x1821D2320", Slot = "31")]
	private BFOIOFJKFEA LEHKFKFOELP(GJCCLPKGONN<EJPHCCLFAJF> CNOJGLMENAL, [In] OMCGLEEHDAE GCLJBEFHJPC)
	{
		return default(BFOIOFJKFEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x21D31B0", Offset = "0x21D23B0", VA = "0x1821D31B0", Slot = "37")]
	private KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF> PJNKPBIEOHJ([In] MONPBPLADEK.LLEALHJKPAJ KLDEANCBDEG)
	{
		return default(KJEOKHCIBGM<MONPBPLADEK.INIMDLPAHPN, KPFAPPGFMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x21D16D0", Offset = "0x21D08D0", VA = "0x1821D16D0", Slot = "46")]
	private (List<MFHIJKGOLHM>, bool) HFNDOCEMFAJ([In] GMNHPKJPCFH ACEAEOMDHEN, string GFIAFOEJCDD, [In] HKKDANEFDJO KENMIINODFC, CKGNJKGFKPE GPHILNDNKBA, DEJALPNGGEI ODBKEKEDHIC)
	{
		return default((List<MFHIJKGOLHM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x21D3050", Offset = "0x21D2250", VA = "0x1821D3050")]
	[CompilerGenerated]
	private NJEHGCGMDBB MMCNJIENHPD(MNIIIHLJBIO ABKDFEIGMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x21D2C40", Offset = "0x21D1E40", VA = "0x1821D2C40")]
	[CompilerGenerated]
	private MGJHDGOHBAP MJKDGCCFALC(APBIJNAHPCO ABKDFEIGMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x21D4090", Offset = "0x21D3290", VA = "0x1821D4090")]
	[CompilerGenerated]
	private MNIIIHLJBIO PGBPAAFCCDP(JFDDFNFCNKH<JKFBFCDNFMP> ABKDFEIGMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x21D0CF0", Offset = "0x21CFEF0", VA = "0x1821D0CF0")]
	[CompilerGenerated]
	private GMCDLDCGJGB EOIPPIJKNAH(JFDDFNFCNKH<EJPHCCLFAJF> ABKDFEIGMDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class MGJHDGOHBAP : FPBHJJDNMNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct BBIFFOFJDIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<GJCCLPKGONN<NFIAEODBBMM>, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public MGJHDGOHBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JFDDFNFCNKH<EJPHCCLFAJF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public JFDDFNFCNKH<JKFBFCDNFMP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<NFIAEODBBMM>, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x21E4570", Offset = "0x21E3770", VA = "0x1821E4570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x21E47F0", Offset = "0x21E39F0", VA = "0x1821E47F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct IGMDLBILAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<GJCCLPKGONN<CGLJCKEDIBG>, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public MGJHDGOHBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public JFDDFNFCNKH<EJPHCCLFAJF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public JFDDFNFCNKH<JKFBFCDNFMP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public GJCCLPKGONN<PNDOEKJDHKD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<KJEOKHCIBGM<GJCCLPKGONN<CGLJCKEDIBG>, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x21E56F0", Offset = "0x21E48F0", VA = "0x1821E56F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x21E5970", Offset = "0x21E4B70", VA = "0x1821E5970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly APBIJNAHPCO EIAPKGPNMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly JOLJBBEOFAN MDKCLDDFONG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey DODEIKBBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string MHKILPCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x21E66F0", Offset = "0x21E58F0", VA = "0x1821E66F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public APBIJNAHPCO CNGECEPKNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x21E6A00", Offset = "0x21E5C00", VA = "0x1821E6A00")]
	public MGJHDGOHBAP(APBIJNAHPCO DAEJMKNKBEI, JOLJBBEOFAN DDJNPHIHCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x21E6890", Offset = "0x21E5A90", VA = "0x1821E6890", Slot = "6")]
	[AsyncStateMachine(typeof(BBIFFOFJDIM))]
	public Task<KJEOKHCIBGM<GJCCLPKGONN<NFIAEODBBMM>, IJNOPJPLCIM>> IGGGAPEIPGM(JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL, JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, string EPPPGDEIJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x21E6720", Offset = "0x21E5920", VA = "0x1821E6720", Slot = "7")]
	[AsyncStateMachine(typeof(IGMDLBILAPM))]
	public Task<KJEOKHCIBGM<GJCCLPKGONN<CGLJCKEDIBG>, IJNOPJPLCIM>> BOLJAIOFKEF(JFDDFNFCNKH<EJPHCCLFAJF> CNOJGLMENAL, JFDDFNFCNKH<JKFBFCDNFMP> HJLGLEFKOHH, GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI, string EPPPGDEIJCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MOJFPADHGGH : NFBFAGBGHIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly APBIJNAHPCO OIIJPIEPJOK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<APBIJNAHPCO> HAPOGJLPHEL;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<APBIJNAHPCO> NABPKDDMCGC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<APBIJNAHPCO> LLPMACMCMHN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey KEBPHANPJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x21E8000", Offset = "0x21E7200", VA = "0x1821E8000", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MHHKDICAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x21E7FF0", Offset = "0x21E71F0", VA = "0x1821E7FF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool NLEOHPCMPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x21E8050", Offset = "0x21E7250", VA = "0x1821E8050", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool HLNNCGCFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x21E7F70", Offset = "0x21E7170", VA = "0x1821E7F70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x21E6C30", Offset = "0x21E5E30", VA = "0x1821E6C30")]
	public bool MDFMKJMGDLG(string JECHHBGMFLN, [Out] DIMACJAKKNO LNBKPFPFMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public MOJFPADHGGH(APBIJNAHPCO JANAFGLBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x21E6AA0", Offset = "0x21E5CA0", VA = "0x1821E6AA0")]
	internal static TypeKey JLNBOOCDBOD(APBIJNAHPCO EIHDAHDDDEG)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x21E66F0", Offset = "0x21E58F0", VA = "0x1821E66F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct GEMFDJLBMBL : HBIMPLJEHAG.BEEKGINOKHK<IBMALGPEGND, EPFCCNCFAEJ>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x21E5420", Offset = "0x21E4620", VA = "0x1821E5420", Slot = "4")]
	public int FHJJOBGJABP(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x21E5380", Offset = "0x21E4580", VA = "0x1821E5380", Slot = "5")]
	public IBMALGPEGND BECIFEAGIBF(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x21E53D0", Offset = "0x21E45D0", VA = "0x1821E53D0", Slot = "6")]
	public IBMALGPEGND CBDMMLHKBPC(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x21E5490", Offset = "0x21E4690", VA = "0x1821E5490", Slot = "7")]
	public IReadOnlyList<IBMALGPEGND> NGLMEPNPNCB(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x21E5440", Offset = "0x21E4640", VA = "0x1821E5440", Slot = "8")]
	public IBMALGPEGND[] KOMIDCGOMLK(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA, int FCGGPALAGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x21E5470", Offset = "0x21E4670", VA = "0x1821E5470", Slot = "9")]
	public bool NBONIHBFBAN(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x21E5360", Offset = "0x21E4560", VA = "0x1821E5360", Slot = "10")]
	public bool BBCKDEJNIAD(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x21E53B0", Offset = "0x21E45B0", VA = "0x1821E53B0", Slot = "11")]
	public bool BNCLDGBDFDC(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x21E5400", Offset = "0x21E4600", VA = "0x1821E5400", Slot = "12")]
	public bool EJGBFJFHCNI(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x21E5450", Offset = "0x21E4650", VA = "0x1821E5450", Slot = "13")]
	public bool LJNCEPIEEEI(EPFCCNCFAEJ JKDKFMIKEAL, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x21E5390", Offset = "0x21E4590", VA = "0x1821E5390", Slot = "14")]
	public bool BLHECBGKCMC(EPFCCNCFAEJ JNLAAHCIJJI, IBMALGPEGND ECFGAICLGCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class GCBDEJCAAEF : PDMENEPAMGI
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public FANCHMMAMOF.PKJKGCMANPI DKCJLLCBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x21E5310", Offset = "0x21E4510", VA = "0x1821E5310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract BPIHHPPODHB.FJEJFPBMPHM PFPBKPEFBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract EDAGGAKPDDG.NEFFKNHDBPG GGLJLABOGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract OEIIELLDBDK.ELCLOAEBPJL CMONGDILJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LOLLCAOFNBL.GOCGCEFLNLE<OHKHJIAEKPD, IBMALGPEGND, EDAGGAKPDDG> AFOGMADKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x21E52C0", Offset = "0x21E44C0", VA = "0x1821E52C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract EPKPCCKMNFP JDLOMELFPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract DALEGBHOIGB MMKEOIEDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract DEFHLCJBIDI JJEHKOHANOO
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract IDBPLFDAJOL EEPGNBGLJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract DJBHJEHICMN FOIAMPAIBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected GCBDEJCAAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DALDGDBMCBP : EODCGIMLMID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct AIKBNPFIOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public DALDGDBMCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public IBMALGPEGND action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x21E4260", Offset = "0x21E3460", VA = "0x1821E4260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x21E4500", Offset = "0x21E3700", VA = "0x1821E4500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct BOAOKHJNEIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public DALDGDBMCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<IBMALGPEGND> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x21E4860", Offset = "0x21E3A60", VA = "0x1821E4860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x21E4BE0", Offset = "0x21E3DE0", VA = "0x1821E4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly LGCMAGEOKHH DFBMDIEJNPB;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public DALDGDBMCBP(LGCMAGEOKHH LNNDAFFMAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x21E4CB0", Offset = "0x21E3EB0", VA = "0x1821E4CB0")]
	[AsyncStateMachine(typeof(AIKBNPFIOBE))]
	private Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> CLKMGPFIPCA(IBMALGPEGND ECFGAICLGCA, bool DCDLPLKJNBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x21E4DE0", Offset = "0x21E3FE0", VA = "0x1821E4DE0", Slot = "4")]
	[AsyncStateMachine(typeof(BOAOKHJNEIO))]
	public Task<KJEOKHCIBGM<INCPKBHJMMC, IJNOPJPLCIM>> PHCEOPOMJDA(IReadOnlyList<IBMALGPEGND> CHFBGJFMMOK, bool DCDLPLKJNBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct GNCCLPIJMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal ODEOBNPHKAF<GDIIEGODKPI, IBMALGPEGND, HHGDKIHMKPH> OIIJPIEPJOK;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x21AA6E0", Offset = "0x21A98E0", VA = "0x1821AA6E0")]
	private GNCCLPIJMMG([In] ODEOBNPHKAF<GDIIEGODKPI, IBMALGPEGND, HHGDKIHMKPH> IAPGPLHLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x21E54B0", Offset = "0x21E46B0", VA = "0x1821E54B0")]
	public static GNCCLPIJMMG MIFIOLMMIDE()
	{
		return default(GNCCLPIJMMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class LCJFFHDEAHP
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static ODEOBNPHKAF<GDIIEGODKPI, IBMALGPEGND, HHGDKIHMKPH> BPBOBJOCFDE(this GNCCLPIJMMG AEFKHDNCNFD)
	{
		return default(ODEOBNPHKAF<GDIIEGODKPI, IBMALGPEGND, HHGDKIHMKPH>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct HHGDKIHMKPH : PGOBAIBFGJE.EEAKMAGLMBJ<GDIIEGODKPI, IBMALGPEGND>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x21E5510", Offset = "0x21E4710", VA = "0x1821E5510", Slot = "5")]
	public IBMALGPEGND KDFNKJAODNE(GDIIEGODKPI[] PJLMFPJCPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0")]
	public int DDCNPHKMOMF([In] GDIIEGODKPI EKBHMICEKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0", Slot = "4")]
	private int FNNNGBFHOEH([In] GDIIEGODKPI HKAPDOJMFMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct CEIKEIBNNBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal JBDFIPCBALH<CIHIDAPLCLE, IBMALGPEGND, OGCADCIPIDM> OIIJPIEPJOK;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x21AA6E0", Offset = "0x21A98E0", VA = "0x1821AA6E0")]
	private CEIKEIBNNBO([In] JBDFIPCBALH<CIHIDAPLCLE, IBMALGPEGND, OGCADCIPIDM> MHHEFPGHAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x21E4C50", Offset = "0x21E3E50", VA = "0x1821E4C50")]
	public static CEIKEIBNNBO MIFIOLMMIDE()
	{
		return default(CEIKEIBNNBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class NJCAPHFHFNC
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static JBDFIPCBALH<CIHIDAPLCLE, IBMALGPEGND, OGCADCIPIDM> BPBOBJOCFDE(this CEIKEIBNNBO AEFKHDNCNFD)
	{
		return default(JBDFIPCBALH<CIHIDAPLCLE, IBMALGPEGND, OGCADCIPIDM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct OGCADCIPIDM : PEKAMIPLDOB.HIIDABOIFGO<CIHIDAPLCLE, IBMALGPEGND>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0")]
	public int FOPALMHIJIB([In] CIHIDAPLCLE EKBHMICEKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x21E8170", Offset = "0x21E7370", VA = "0x1821E8170", Slot = "5")]
	public IBMALGPEGND PJCJCMDICJI(CIHIDAPLCLE[] PKPOOKOEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0", Slot = "4")]
	private int HBDGGHMAMFJ([In] CIHIDAPLCLE EKBHMICEKBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class JDDBDEOKMIH : KKIKBNLICGH, KPFAPPGFMLF, IJNOPJPLCIM, NDNNGNKGHFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly NDNNGNKGHFF? AGCBOLKFKMI;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BKNLANCKOBM BNDKOPLNLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(BKNLANCKOBM);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C0", Offset = "0x8997C0", VA = "0x18089A5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override NDNNGNKGHFF? BNBOKFBOLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x21E5B40", Offset = "0x21E4D40", VA = "0x1821E5B40", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x21E5CB0", Offset = "0x21E4EB0", VA = "0x1821E5CB0")]
	private JDDBDEOKMIH(BKNLANCKOBM MBLCENENKDK, NDNNGNKGHFF? ANBBNOACDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x21E5A50", Offset = "0x21E4C50", VA = "0x1821E5A50")]
	public static JDDBDEOKMIH DHCMJKGEAOB(NDNNGNKGHFF ANBBNOACDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x21E5AD0", Offset = "0x21E4CD0", VA = "0x1821E5AD0")]
	public static JDDBDEOKMIH GCGLNIIKEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x21E59E0", Offset = "0x21E4BE0", VA = "0x1821E59E0")]
	public static JDDBDEOKMIH CGNJOFAAFJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class DGLCOHIKBOM
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2C66840", Offset = "0x2C65A40", VA = "0x182C66840")]
	public static KJEOKHCIBGM<TOk, KPFAPPGFMLF> AOKLDCPJPBH<TOk>([In] this KJEOKHCIBGM<TOk, KPFAPPGFMLF> AEFKHDNCNFD, NDNNGNKGHFF ANBBNOACDLH) where TOk : notnull
	{
		return default(KJEOKHCIBGM<TOk, KPFAPPGFMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2C66A20", Offset = "0x2C65C20", VA = "0x182C66A20")]
	public static KJEOKHCIBGM<TOk?, KPFAPPGFMLF?> OHMEJFIAMDK<TOk>([In] this KJEOKHCIBGM<TOk, KPFAPPGFMLF> AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<TOk, KPFAPPGFMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2C66930", Offset = "0x2C65B30", VA = "0x182C66930")]
	public static KJEOKHCIBGM<TOk?, KPFAPPGFMLF?> ODOLKDEIJKF<TOk>([In] this KJEOKHCIBGM<TOk, KPFAPPGFMLF> AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<TOk, KPFAPPGFMLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface EPKPCCKMNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHMJDJMBJPL([In] KJEOKHCIBGM<EPFCCNCFAEJ, NDNNGNKGHFF> KHPJAGHLNBM);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class BOJJNEIDPON
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5910", Offset = "0x2BB4B10", VA = "0x182BB5910")]
	public static bool DHMJDJMBJPL<TOk, TErr>(this EPKPCCKMNFP AEFKHDNCNFD, [In] KJEOKHCIBGM<TOk, TErr> KHPJAGHLNBM) where TOk : notnull where TErr : notnull, NDNNGNKGHFF
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface DALEGBHOIGB
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	EKKKDFCIKEG DBBLHPNCAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface DEFHLCJBIDI
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JLEFEMGMODF ELHJOLLLBKH(int EKADCALMHFA);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface GOBPHHBONCM
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface LIJEOKKOGDB
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCCBBOEMGDM? GAIEABDLIKD(GJCCLPKGONN<PNDOEKJDHKD> JLGAHGAEPDI);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface IMAMKIPGENB
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface BCCBBOEMGDM
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMAMKIPGENB? OLNEFDJEGLD(GJCCLPKGONN<NFIAEODBBMM> HNIOEDELIAA);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GOBPHHBONCM? IICHPEHIHGO(GJCCLPKGONN<CGLJCKEDIBG> OOFENBMPCLM);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface IDBPLFDAJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IGPBPFFFLIL(string JECHHBGMFLN, string GFIAFOEJCDD);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface DJBHJEHICMN
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIJEOKKOGDB? JDKIMJLOHOB([In] JFDDFNFCNKH<DIFGJKIDHIA> MIFILCCJDAA);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MEHDHAMFGJB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct KBMCAOJANCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int NLHHONDOFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public POAKEMJOLKP? BKBFOJEAKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public POAKEMJOLKP? PPIIFEBNEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<IBMALGPEGND> OHDNKHLACNE;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x21E5DB0", Offset = "0x21E4FB0", VA = "0x1821E5DB0")]
		private KBMCAOJANCD(int KINMHNEMPOD, POAKEMJOLKP? GNGNBNJMPDJ, POAKEMJOLKP? GCPIPJMJLMI, List<IBMALGPEGND> CHFBGJFMMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x21E5CF0", Offset = "0x21E4EF0", VA = "0x1821E5CF0")]
		public static KBMCAOJANCD MIFIOLMMIDE()
		{
			return default(KBMCAOJANCD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly LOMEIPJBOKE<KBMCAOJANCD> GOBIPNDLFPE;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static MEHDHAMFGJB FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x21E5EC0", Offset = "0x21E50C0", VA = "0x1821E5EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool BLKGAIONAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x931B60", Offset = "0x930D60", VA = "0x180931B60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x931B70", Offset = "0x930D70", VA = "0x180931B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x21E5E00", Offset = "0x21E5000", VA = "0x1821E5E00")]
	public void BOOCPBMNOPC(NNKACLEGANH GCPIPJMJLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F10", Offset = "0x21E5110", VA = "0x1821E5F10")]
	public void JENAIINMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x21E6200", Offset = "0x21E5400", VA = "0x1821E6200")]
	private static string? MJBODEBOGGO([In] KBMCAOJANCD KMIDAIGJCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x21E6640", Offset = "0x21E5840", VA = "0x1821E6640")]
	public MEHDHAMFGJB()
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
