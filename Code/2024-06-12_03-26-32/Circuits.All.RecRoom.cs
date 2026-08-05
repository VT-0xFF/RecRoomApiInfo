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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F5BA40", Offset = "0x1F5A640", VA = "0x181F5BA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KAPIFPFJPBM : IDisposable, PKLBOBOJGAM, MFEBLGMHCFE, JIHDDGBPGGN, AADJJBFAAJN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class JLDGCNDEGNL : CKPFKOBPIEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int HGKNLODIEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1F49280", Offset = "0x1F47E80", VA = "0x181F49280", Slot = "5")]
		public JBJHBFJEELL IKDLJPOEDNA(EAJCABHLBHF.KGIAELGNDDE CFCALMONEJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void CAPFPJDAOBB();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void IOICCFBDKCJ();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F49240", Offset = "0x1F47E40", VA = "0x181F49240", Slot = "13")]
		public virtual void DEBJNPDMINC(KAPIFPFJPBM KCPELCALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1F493D0", Offset = "0x1F47FD0", VA = "0x181F493D0", Slot = "14")]
		public virtual void IKPGDPGEDLP(KAPIFPFJPBM KCPELCALJIF, KPEIBDAFOMB FIPNCHEIGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected JLDGCNDEGNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CKPFKOBPIEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int HGKNLODIEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JBJHBFJEELL IKDLJPOEDNA(EAJCABHLBHF.KGIAELGNDDE CFCALMONEJL);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CAPFPJDAOBB();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IOICCFBDKCJ();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DEBJNPDMINC(KAPIFPFJPBM KCPELCALJIF);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IKPGDPGEDLP(KAPIFPFJPBM KCPELCALJIF, KPEIBDAFOMB FIPNCHEIGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct FBBPIPNINMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly BKCAOGABAKD<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> DJIIOHPILON;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1F459F0", Offset = "0x1F445F0", VA = "0x181F459F0")]
		internal FBBPIPNINMC(BKCAOGABAKD<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> NHLLCDFJMEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class DOHGPBAPMAO : FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly DOHGPBAPMAO GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private DOHGPBAPMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB5F7B0", Offset = "0xB5E3B0", VA = "0x180B5F7B0", Slot = "4")]
		public MCHFNCPKCHH GKNJFKACFCJ(KPEIBDAFOMB HNFMOHFACKF)
		{
			return default(MCHFNCPKCHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F41E50", Offset = "0x1F40A50", VA = "0x181F41E50", Slot = "5")]
		public void DEBJNPDMINC(KAPIFPFJPBM BLPDMPJLPPJ, KPEIBDAFOMB FIPNCHEIGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1F41F50", Offset = "0x1F40B50", VA = "0x181F41F50", Slot = "6")]
		public void IKPGDPGEDLP(KAPIFPFJPBM BLPDMPJLPPJ, KPEIBDAFOMB FIPNCHEIGMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct KIGCLABBHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LOCGLCFIOKB<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> DJIIOHPILON;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F4B0D0", Offset = "0x1F49CD0", VA = "0x181F4B0D0")]
		internal KIGCLABBHKH(LOCGLCFIOKB<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1F4B080", Offset = "0x1F49C80", VA = "0x181F4B080")]
		public static KIGCLABBHKH PPOPBMPFEOP()
		{
			return default(KIGCLABBHKH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct BIAEBEHOBAB : FJHOKOIKACF.ECBIIFJABHC<KPEIBDAFOMB, KAPIFPFJPBM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BBPEBIPGMCG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KAPIFPFJPBM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KPEIBDAFOMB action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BIAEBEHOBAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F40510", Offset = "0x1F3F110", VA = "0x181F40510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1F406F0", Offset = "0x1F3F2F0", VA = "0x181F406F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CA9B0", Offset = "0x8C95B0", VA = "0x1808CA9B0", Slot = "4")]
		public DCECDLKENED<KLBJPBJKDCO> BOAEAGHPAEH(KAPIFPFJPBM PPFPKNPFHFN)
		{
			return default(DCECDLKENED<KLBJPBJKDCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F408F0", Offset = "0x1F3F4F0", VA = "0x181F408F0", Slot = "5")]
		[AsyncStateMachine(typeof(BBPEBIPGMCG))]
		public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> ADGJIKPMKGF(KAPIFPFJPBM PPFPKNPFHFN, KPEIBDAFOMB FIPNCHEIGMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1F40A20", Offset = "0x1F3F620", VA = "0x181F40A20", Slot = "6")]
		public KPEIBDAFOMB[] BIBENPJDHNB(KAPIFPFJPBM PPFPKNPFHFN)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LAMNIIMDEOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KAPIFPFJPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JIPCGMFMDIK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GKKNBFGCPLF circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GLNEPJPIIDC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C830", Offset = "0x1F4B430", VA = "0x181F4C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CAB0", Offset = "0x1F4B6B0", VA = "0x181F4CAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AGHMMEFDGFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KAPIFPFJPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FC40", Offset = "0x1F3E840", VA = "0x181F3FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FED0", Offset = "0x1F3EAD0", VA = "0x181F3FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NKPBMEDFGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KAPIFPFJPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F59760", Offset = "0x1F58360", VA = "0x181F59760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F59940", Offset = "0x1F58540", VA = "0x181F59940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EIFFIOHBCAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KAPIFPFJPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KPEIBDAFOMB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F42C40", Offset = "0x1F41840", VA = "0x181F42C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F42E30", Offset = "0x1F41A30", VA = "0x181F42E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GBOLKGCNFAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public KAPIFPFJPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F46170", Offset = "0x1F44D70", VA = "0x181F46170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1F46960", Offset = "0x1F45560", VA = "0x181F46960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DCECDLKENED<KLBJPBJKDCO> EACMEHPNJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FBBPIPNINMC GILHOOJGJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NFCKFCJMOMH IBAAELHNGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly HPMOJMGCPAC CLJEAHLCNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A00")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly OPKHADNNKCD FIGBCCIHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A08")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FHKIIPNOMGA.BDGJJPJFFND MHNBDGBGJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly FAEFJBNHGEG DDJIBLNDFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A30")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly DOJNMOBOFJD EJMBKMFECJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly KBKDMACGHJL JOODCOPGHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly PIEEBLIFECI KJNJNLKKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly LIAHPIOCGBP MOABEBDLCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NOIBEFKBNDC JBDMEGAINHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FDCOBNKCCAI BJNLKOMCFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly NFCKFCJMOMH.HGMPJKAMPPF PFGMOJODCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly FJHKCGLMIFM AGIOPCLGIJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NFCKFCJMOMH JCIFLLNMLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F4A010", Offset = "0x1F48C10", VA = "0x181F4A010")]
		get
		{
			return default(NFCKFCJMOMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal CKPFKOBPIEH KPGPPPMLFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F49460", Offset = "0x1F48060", VA = "0x181F49460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JBJHBFJEELL IPFGIONPBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F4A4D0", Offset = "0x1F490D0", VA = "0x181F4A4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F49E40", Offset = "0x1F48A40", VA = "0x181F49E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool GOGCPBGMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F49450", Offset = "0x1F48050", VA = "0x181F49450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4A020", Offset = "0x1F48C20", VA = "0x181F4A020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DMLIAGOINBK FDHIJMFNFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD30", Offset = "0x1F49930", VA = "0x181F4AD30", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LKCINBOJDHD EHOJJDPPCII
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD50", Offset = "0x1F49950", VA = "0x181F4AD50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LJJHBGOEMBL CKDLGGCMMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD70", Offset = "0x1F49970", VA = "0x181F4AD70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AAJKJKLDMEO KBGOHNAGBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD40", Offset = "0x1F49940", VA = "0x181F4AD40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NOOIKNGMFEF ALICDLPGHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD60", Offset = "0x1F49960", VA = "0x181F4AD60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private AFAONHFGOBC? CINNFPIIMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F4A280", Offset = "0x1F48E80", VA = "0x181F4A280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private MCDENGCHJHL? EAIEMOKNADA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F49E60", Offset = "0x1F48A60", VA = "0x181F49E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A9F0", Offset = "0x1F495F0", VA = "0x181F4A9F0")]
	private KAPIFPFJPBM(OPKHADNNKCD DIPPLEBBBBE, DCECDLKENED<KLBJPBJKDCO> OPBLCCPLEKK, [In] FBBPIPNINMC MEOPHEGEJPJ, [In] NFCKFCJMOMH HGFNPIJILPJ, [In] HPMOJMGCPAC PIHBPPFKAHM, JBJHBFJEELL ODHIEEDCLEG, [In] FHKIIPNOMGA.BDGJJPJFFND NPIDLKOFLKG, NFCKFCJMOMH.HGMPJKAMPPF NPECDMDGLGD, FJHKCGLMIFM GIKIEEICIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A8B0", Offset = "0x1F494B0", VA = "0x181F4A8B0")]
	public static KAPIFPFJPBM PPOPBMPFEOP(OPKHADNNKCD CFCALMONEJL, [In] POEKCOIIKEO BDBKIBHDLNE, ADLDHGAFFLE MAAJFBGLNNE, [In] CLLNEMKKEGP IJKAAIKIMCP, DLHBEPOMBGF CEEJEHMMMEH, DCECDLKENED<KLBJPBJKDCO> OPBLCCPLEKK, DCECDLKENED<NHJKGCIAJLH> MALDIIBMGEP, AINBMLCMMJM DCGGBFLHNBG, JMJOJDMNDEJ LPLDCDLDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A5D0", Offset = "0x1F491D0", VA = "0x181F4A5D0")]
	public static KAPIFPFJPBM PPOPBMPFEOP(OPKHADNNKCD DIPPLEBBBBE, [In] NFCKFCJMOMH HGFNPIJILPJ, [In] HPMOJMGCPAC PIHBPPFKAHM, DCECDLKENED<KLBJPBJKDCO> OPBLCCPLEKK, DCECDLKENED<NHJKGCIAJLH> MALDIIBMGEP, AINBMLCMMJM DCGGBFLHNBG, JMJOJDMNDEJ LPLDCDLDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F49950", Offset = "0x1F48550", VA = "0x181F49950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A030", Offset = "0x1F48C30", VA = "0x181F4A030")]
	[AsyncStateMachine(typeof(LAMNIIMDEOD))]
	internal Task<GFFELLBKJIA<bool, DCMKOJFPDPC>> KPEMDOMMKGJ(JIPCGMFMDIK MBOIBNMPCFB, GKKNBFGCPLF PCFLOJOLNII, GLNEPJPIIDC MAOEPJEIFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F49D50", Offset = "0x1F48950", VA = "0x181F49D50")]
	[AsyncStateMachine(typeof(AGHMMEFDGFJ))]
	public Task<GFFELLBKJIA<bool, DCMKOJFPDPC>> GIDLHKDGEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A4E0", Offset = "0x1F490E0", VA = "0x181F4A4E0")]
	[AsyncStateMachine(typeof(NKPBMEDFGCM))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> PMFBPNGCFAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F49B40", Offset = "0x1F48740", VA = "0x181F49B40")]
	internal void EBAHLFJPAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F49F90", Offset = "0x1F48B90", VA = "0x181F49F90")]
	internal IJOGPJMNLNP<KPEIBDAFOMB> IHIJHFNFCKG([In] JEBGCOOABAF FNLEOLJEGMF)
	{
		return default(IJOGPJMNLNP<KPEIBDAFOMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A210", Offset = "0x1F48E10", VA = "0x181F4A210")]
	internal bool MFNCHAPMJOH([In] JEBGCOOABAF FNLEOLJEGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A190", Offset = "0x1F48D90", VA = "0x181F4A190")]
	internal IJOGPJMNLNP<KPEIBDAFOMB> LFAEACGGMCJ([In] EEEAJDNKBAK AHMEMEAMGBB)
	{
		return default(IJOGPJMNLNP<KPEIBDAFOMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F49840", Offset = "0x1F48440", VA = "0x181F49840")]
	[AsyncStateMachine(typeof(EIFFIOHBCAE))]
	internal Task<GFFELLBKJIA<object, DCMKOJFPDPC>> CLJBCJPGHIO(KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F494B0", Offset = "0x1F480B0", VA = "0x181F494B0")]
	private KPEIBDAFOMB[] BIBENPJDHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A3B0", Offset = "0x1F48FB0", VA = "0x181F4A3B0")]
	[AsyncStateMachine(typeof(GBOLKGCNFAH))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> NCJAGBFFEGJ(Guid ABAJMPPNGDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BCCICHECFIG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x287F7E0", Offset = "0x287E3E0", VA = "0x18287F7E0")]
	public static OJGOABDHJAH<(TPrev?, KAPIFPFJPBM?), MCDENGCHJHL> HLCHEGGCAMD<TPrev>([In] this OJGOABDHJAH<TPrev, KAPIFPFJPBM> HNFMOHFACKF)
	{
		return default(OJGOABDHJAH<(TPrev, KAPIFPFJPBM), MCDENGCHJHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x287F5C0", Offset = "0x287E1C0", VA = "0x18287F5C0")]
	public static OJGOABDHJAH<TPrev?, KAPIFPFJPBM?> HKGPIFPBAPD<TPrev>([In] this OJGOABDHJAH<TPrev, KAPIFPFJPBM> HNFMOHFACKF)
	{
		return default(OJGOABDHJAH<TPrev, KAPIFPFJPBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MJDFECILGAH<TData> : DICIKJENGEG, NMGAEJLLOPI, NKGCJHELBDN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KPOKIIDKMFA<GIGLGMMBICO>? FCBKAPJHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string LFPIMPJLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData JLODENNJHEB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public KPOKIIDKMFA<GIGLGMMBICO>? HAEMCBMFAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x216E030", Offset = "0x216CC30", VA = "0x18216E030", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x43FAB40", Offset = "0x43F9740", VA = "0x1843FAB40")]
	internal MJDFECILGAH([In] KPOKIIDKMFA<GIGLGMMBICO>? LPDDGJMOICG, DCECDLKENED<CJEJKMAMNCJ>? CIPIDNMEOBA, IOKind? APNOEKHBKPI, string JIMAFLGJGFB, [In] TData IMCLGJBJJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BOAGGECIDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F40CF0", Offset = "0x1F3F8F0", VA = "0x181F40CF0")]
	public static GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI> FANGPEOMEHJ([In] this HCMAELHNFKC<KMMBHEHEPJH> JHBKGCDIFNO)
	{
		return default(GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x288A440", Offset = "0x2889040", VA = "0x18288A440")]
	public static GFFELLBKJIA<TOk, NMGAEJLLOPI> HAAHLKDCNBJ<TOk>([In] this GFFELLBKJIA<TOk, NMGAEJLLOPI> HNFMOHFACKF, [In] KPOKIIDKMFA<GIGLGMMBICO>? LPDDGJMOICG, DCECDLKENED<CJEJKMAMNCJ>? CIPIDNMEOBA, IOKind? APNOEKHBKPI, string JIMAFLGJGFB) where TOk : notnull
	{
		return default(GFFELLBKJIA<TOk, NMGAEJLLOPI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OPKHADNNKCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MLDIPGBBGJF.GPFGLENNCBE MFJMIPEMHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EAJCABHLBHF.KGIAELGNDDE BGAOLGINCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KAPIFPFJPBM.CKPFKOBPIEH GNILAAJCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MBONHOHFBJI.IPAMALPCJPL ACGAPHENLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM> POCNGADANDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JGJANGBPMAM NCIIHALIHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MAEAMFANOOA AHCAMCOBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FDMDCDNEJLM BHJOOOLODDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MFEAPMIBBPD CPEBAJGHDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DEEHBNCBKNI CIMDACIDHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KPNBJJLLEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C720", Offset = "0x1F4B320", VA = "0x181F4C720")]
	public static KPEIBDAFOMB ILPIAJIDFII(this KPEIBDAFOMB HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C650", Offset = "0x1F4B250", VA = "0x181F4C650")]
	public static KPEIBDAFOMB FJENKFKLIHF(this GILNCNPHNEL HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GILNCNPHNEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LEDOGILFKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KAPIFPFJPBM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GILNCNPHNEL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F57CE0", Offset = "0x1F568E0", VA = "0x181F57CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1F57FA0", Offset = "0x1F56BA0", VA = "0x181F57FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString EPAONLOANJK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	private GILNCNPHNEL(ByteString GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F46B90", Offset = "0x1F45790", VA = "0x181F46B90")]
	public static KPEIBDAFOMB NGNDKCOGIFA(ByteString GLMEMJNJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F46AE0", Offset = "0x1F456E0", VA = "0x181F46AE0")]
	public static JPENIILFPGH<MCHFNCPKCHH, GILNCNPHNEL> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, GILNCNPHNEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F469D0", Offset = "0x1F455D0", VA = "0x181F469D0")]
	[AsyncStateMachine(typeof(LEDOGILFKCG))]
	public static Task<GFFELLBKJIA<object, DCMKOJFPDPC>> CLJBCJPGHIO(KAPIFPFJPBM BLPDMPJLPPJ, GILNCNPHNEL HNFMOHFACKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GOIFAMHHMDH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F46DB0", Offset = "0x1F459B0", VA = "0x181F46DB0")]
	public static KPEIBDAFOMB NGNDKCOGIFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F46CC0", Offset = "0x1F458C0", VA = "0x181F46CC0")]
	public static JPENIILFPGH<MCHFNCPKCHH, GOIFAMHHMDH> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, GOIFAMHHMDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F46D30", Offset = "0x1F45930", VA = "0x181F46D30")]
	public static GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE> KPIGLCGNAIG(KAPIFPFJPBM BLPDMPJLPPJ, [In] GOIFAMHHMDH HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HLMMJLABKHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GBBAOFMIIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KAPIFPFJPBM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HLMMJLABKHL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F45D90", Offset = "0x1F44990", VA = "0x181F45D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1F46100", Offset = "0x1F44D00", VA = "0x181F46100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JIPCGMFMDIK? AIOACMPCEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GKKNBFGCPLF? IIGAMLDGGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly GLNEPJPIIDC? EIGBNMLEPEJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E79650", Offset = "0x1E78250", VA = "0x181E79650")]
	private HLMMJLABKHL(JIPCGMFMDIK? MBOIBNMPCFB, GKKNBFGCPLF? PCFLOJOLNII, GLNEPJPIIDC? MAOEPJEIFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F48220", Offset = "0x1F46E20", VA = "0x181F48220")]
	public static KPEIBDAFOMB? NGNDKCOGIFA(JIPCGMFMDIK? MBOIBNMPCFB, GKKNBFGCPLF? PCFLOJOLNII, GLNEPJPIIDC? MAOEPJEIFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F48110", Offset = "0x1F46D10", VA = "0x181F48110")]
	public static JPENIILFPGH<MCHFNCPKCHH, HLMMJLABKHL> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, HLMMJLABKHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F47FD0", Offset = "0x1F46BD0", VA = "0x181F47FD0")]
	[AsyncStateMachine(typeof(GBBAOFMIIGG))]
	public static Task<GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE>> CLJBCJPGHIO(KAPIFPFJPBM BLPDMPJLPPJ, HLMMJLABKHL HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FMIJPCMJLDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LGAGCHGEDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<DOAHPFBPLDP, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FMIJPCMJLDF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KAPIFPFJPBM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GFFELLBKJIA<DOAHPFBPLDP, DCMKOJFPDPC> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GFFELLBKJIA<object, NKGCJHELBDN>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private GFFELLBKJIA<object, NKGCJHELBDN> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private GFFELLBKJIA<object, NKGCJHELBDN>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F58010", Offset = "0x1F56C10", VA = "0x181F58010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1F58470", Offset = "0x1F57070", VA = "0x181F58470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<KPEIBDAFOMB> JFGBLPFLNAF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	private FMIJPCMJLDF(IReadOnlyList<KPEIBDAFOMB> FOLFFNCNEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F45CD0", Offset = "0x1F448D0", VA = "0x181F45CD0")]
	public static KPEIBDAFOMB NGNDKCOGIFA(IReadOnlyList<KPEIBDAFOMB> FOLFFNCNEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F45C30", Offset = "0x1F44830", VA = "0x181F45C30")]
	public static JPENIILFPGH<MCHFNCPKCHH, FMIJPCMJLDF> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, FMIJPCMJLDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F45AF0", Offset = "0x1F446F0", VA = "0x181F45AF0")]
	[AsyncStateMachine(typeof(LGAGCHGEDJM))]
	public static Task<GFFELLBKJIA<DOAHPFBPLDP, DCMKOJFPDPC>> CLJBCJPGHIO(KAPIFPFJPBM BLPDMPJLPPJ, FMIJPCMJLDF HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct EEEAJDNKBAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int FPIENNPNDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int HDEPOMLIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] JLODENNJHEB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A1F0", Offset = "0x1A98DF0", VA = "0x181A9A1F0")]
	private EEEAJDNKBAK(int HDFABDCMCAG, int OPDMGNJCACB, byte[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F42B60", Offset = "0x1F41760", VA = "0x181F42B60")]
	public static KPEIBDAFOMB NGNDKCOGIFA(int HDFABDCMCAG, int OPDMGNJCACB, ByteString IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F42A20", Offset = "0x1F41620", VA = "0x181F42A20")]
	public static KPEIBDAFOMB[] MGOKPFPKCOF(KPEIBDAFOMB FIPNCHEIGMJ, int HBFPDCKDOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F42820", Offset = "0x1F41420", VA = "0x181F42820")]
	public static JPENIILFPGH<MCHFNCPKCHH, EEEAJDNKBAK> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, EEEAJDNKBAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F42900", Offset = "0x1F41500", VA = "0x181F42900")]
	public static GFFELLBKJIA<KPEIBDAFOMB, GCLPBJOMDAE> KPIGLCGNAIG(KAPIFPFJPBM BLPDMPJLPPJ, [In] EEEAJDNKBAK HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<KPEIBDAFOMB, GCLPBJOMDAE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JEBGCOOABAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CBCGBCOIPCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<bool, GCLPBJOMDAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KAPIFPFJPBM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JEBGCOOABAF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private GFFELLBKJIA<bool, GCLPBJOMDAE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, GCLPBJOMDAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F414F0", Offset = "0x1F400F0", VA = "0x181F414F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F41B30", Offset = "0x1F40730", VA = "0x181F41B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int FPIENNPNDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int HDEPOMLIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] JLODENNJHEB;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A1F0", Offset = "0x1A98DF0", VA = "0x181A9A1F0")]
	private JEBGCOOABAF(int HDFABDCMCAG, int OPDMGNJCACB, byte[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F48BA0", Offset = "0x1F477A0", VA = "0x181F48BA0")]
	public static KPEIBDAFOMB NGNDKCOGIFA(int HDFABDCMCAG, int OPDMGNJCACB, ByteString IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F489A0", Offset = "0x1F475A0", VA = "0x181F489A0")]
	public static KPEIBDAFOMB?[]? KKBKLGIJDJN(int HBFPDCKDOJA, JIPCGMFMDIK? MBOIBNMPCFB, GKKNBFGCPLF? PCFLOJOLNII, GLNEPJPIIDC? MAOEPJEIFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F488C0", Offset = "0x1F474C0", VA = "0x181F488C0")]
	public static JPENIILFPGH<MCHFNCPKCHH, JEBGCOOABAF> IDNJCJAEAEL(KPEIBDAFOMB FBHAOMNHCMH)
	{
		return default(JPENIILFPGH<MCHFNCPKCHH, JEBGCOOABAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F48790", Offset = "0x1F47390", VA = "0x181F48790")]
	[AsyncStateMachine(typeof(CBCGBCOIPCM))]
	public static Task<GFFELLBKJIA<bool, GCLPBJOMDAE>> CLJBCJPGHIO(KAPIFPFJPBM BLPDMPJLPPJ, JEBGCOOABAF HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FAEFJBNHGEG : DMLIAGOINBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IPFEEJFNPED? GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1F458F0", Offset = "0x1F444F0", VA = "0x181F458F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	internal FAEFJBNHGEG(KAPIFPFJPBM KCPELCALJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JFKIIBAPKFC : IPFEEJFNPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CLLMLCCFDAI HHABAPLNGJN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public JFKIIBAPKFC(KAPIFPFJPBM KCPELCALJIF, CLLMLCCFDAI EGLKKHIDACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F48C80", Offset = "0x1F47880", VA = "0x181F48C80", Slot = "4")]
	public GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI> HOBBKOBJLDI(KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<NMGIOEAJCBI> ALMJBMBCMPN)
	{
		return default(GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F48F60", Offset = "0x1F47B60", VA = "0x181F48F60", Slot = "5")]
	public GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI> OIBKGJJLCCE(KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<ODOMFDGLFOL> LKMOAAHJAKF)
	{
		return default(GFFELLBKJIA<CHDJBHOINKA, NMGAEJLLOPI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MLDIPGBBGJF : IHBEIFDIAIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface GPFGLENNCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CLLMLCCFDAI> FAHOKJMPDBI(KAPIFPFJPBM KCPELCALJIF, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK, CancellationToken MPLCHGMFENA);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GDIGJKFJKLM OIAOOMGKMCO(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IJGMDLDPIKE : GPFGLENNCBE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct HKIEJONFEJF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<CLLMLCCFDAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public KAPIFPFJPBM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public GKKNBFGCPLF cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GLNEPJPIIDC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<MBONHOHFBJI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1F47D90", Offset = "0x1F46990", VA = "0x181F47D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1F47F60", Offset = "0x1F46B60", VA = "0x181F47F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IJGMDLDPIKE GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private IJGMDLDPIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1F48590", Offset = "0x1F47190", VA = "0x181F48590", Slot = "4")]
		[AsyncStateMachine(typeof(HKIEJONFEJF))]
		public Task<CLLMLCCFDAI> FAHOKJMPDBI(KAPIFPFJPBM KCPELCALJIF, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK, CancellationToken MPLCHGMFENA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1F486F0", Offset = "0x1F472F0", VA = "0x181F486F0", Slot = "5")]
		public GDIGJKFJKLM OIAOOMGKMCO(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ODMJOIBPPIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<MLDIPGBBGJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KAPIFPFJPBM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public GKKNBFGCPLF cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GLNEPJPIIDC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JIPCGMFMDIK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GPFGLENNCBE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<CLLMLCCFDAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F5BAC0", Offset = "0x1F5A6C0", VA = "0x181F5BAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F5C010", Offset = "0x1F5AC10", VA = "0x181F5C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CLLMLCCFDAI HHABAPLNGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GDIGJKFJKLM HPDHFAPKJFA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AFAONHFGOBC FJKPHHCFIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F58920", Offset = "0x1F57520", VA = "0x181F58920", Slot = "4")]
		get
		{
			return default(AFAONHFGOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MCDENGCHJHL NKICEBBFKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F58690", Offset = "0x1F57290", VA = "0x181F58690", Slot = "5")]
		get
		{
			return default(MCDENGCHJHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JFKIIBAPKFC NDMEPDNMEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MLDLBHNIBED NCJJKOEANGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LFPKKLNLEPJ AEINEPGMJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F58980", Offset = "0x1F57580", VA = "0x181F58980")]
	private MLDIPGBBGJF(CLLMLCCFDAI EGLKKHIDACA, GDIGJKFJKLM ELFDNEMOGND, JFKIIBAPKFC EHENJMOPPPD, MLDLBHNIBED HFGNHGLOODJ, LFPKKLNLEPJ MKAFEIAHMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F58750", Offset = "0x1F57350", VA = "0x181F58750")]
	[AsyncStateMachine(typeof(ODMJOIBPPIF))]
	public static Task<MLDIPGBBGJF> CIMEFJNJMHI(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F588C0", Offset = "0x1F574C0", VA = "0x181F588C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EAJCABHLBHF : JBJHBFJEELL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface KGIAELGNDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IHBEIFDIAIE> KNIFDONGLCN(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK, CancellationToken MPLCHGMFENA);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IFLFIKAOGNA();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OMGIBGCPNEM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class NNINKMFACFO : KGIAELGNDDE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct PFCFFKDAICG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<IHBEIFDIAIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public KAPIFPFJPBM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public JIPCGMFMDIK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public GKKNBFGCPLF cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public GLNEPJPIIDC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<MLDIPGBBGJF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C9A0", Offset = "0x1F5B5A0", VA = "0x181F5C9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CCE0", Offset = "0x1F5B8E0", VA = "0x181F5CCE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B8E0", Offset = "0x1F5A4E0", VA = "0x181F5B8E0", Slot = "4")]
		[AsyncStateMachine(typeof(PFCFFKDAICG))]
		public Task<IHBEIFDIAIE> KNIFDONGLCN(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK, CancellationToken MPLCHGMFENA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void IFLFIKAOGNA();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OMGIBGCPNEM();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected NNINKMFACFO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IDPBIAIAJCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<IHBEIFDIAIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EAJCABHLBHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<LOGIJBPEHJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F48320", Offset = "0x1F46F20", VA = "0x181F48320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F48520", Offset = "0x1F47120", VA = "0x181F48520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NICKMBLIGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public EAJCABHLBHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KAPIFPFJPBM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JIPCGMFMDIK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public GKKNBFGCPLF cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLNEPJPIIDC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<IHBEIFDIAIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F591D0", Offset = "0x1F57DD0", VA = "0x181F591D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1F59700", Offset = "0x1F58300", VA = "0x181F59700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KGIAELGNDDE KJMCLGOJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<LOGIJBPEHJN> IENOFHHLOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<LOGIJBPEHJN> PEMPCNNAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource MNFDDODKIFF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GOGCPBGMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E90", Offset = "0x9B0A90", VA = "0x1809B1E90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA07C40", Offset = "0xA06840", VA = "0x180A07C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB7880", Offset = "0xAB6480", VA = "0x180AB7880", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB78A0", Offset = "0xAB64A0", VA = "0x180AB78A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool IBGIOOIMLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10BB400", Offset = "0x10BA000", VA = "0x1810BB400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1F42610", Offset = "0x1F41210", VA = "0x181F42610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IHBEIFDIAIE? FLDIKEPJLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F42620", Offset = "0x1F41220", VA = "0x181F42620", Slot = "7")]
	[AsyncStateMachine(typeof(IDPBIAIAJCB))]
	public Task<IHBEIFDIAIE> PGEKGLELCAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F42710", Offset = "0x1F41310", VA = "0x181F42710")]
	public EAJCABHLBHF(KGIAELGNDDE CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F42340", Offset = "0x1F40F40", VA = "0x181F42340", Slot = "8")]
	[AsyncStateMachine(typeof(NICKMBLIGCK))]
	public Task BEEFIPAMNKI(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F424A0", Offset = "0x1F410A0", VA = "0x181F424A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NHDNOONAPHM : CIKEKMDGPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MLDLBHNIBED LPMFGAONDBB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public NHDNOONAPHM(MLDLBHNIBED HFGNHGLOODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class BFANPCABCJF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class HJEGBLGPGHM<TGraph> : NFJAEEDNHJG where TGraph : LPNEEKIAAGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph JBCCIDOGGLI;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual GHKADHCEAJO? KGJLBHOEICB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xEF2BA0", Offset = "0xEF17A0", VA = "0x180EF2BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DCECDLKENED<AJNNPPKMCNH> GHAMJFHEBIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D45DD0", Offset = "0x3D449D0", VA = "0x183D45DD0", Slot = "4")]
			get
			{
				return default(DCECDLKENED<AJNNPPKMCNH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
		public HJEGBLGPGHM(TGraph ENLPGHMPOPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class FFDIKOLEECC : HJEGBLGPGHM<PDGJFENJCCA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override GHKADHCEAJO? KGJLBHOEICB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F45A00", Offset = "0x1F44600", VA = "0x181F45A00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F45A20", Offset = "0x1F44620", VA = "0x181F45A20")]
		public FFDIKOLEECC(PDGJFENJCCA JFMPPPAPPLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F40760", Offset = "0x1F3F360", VA = "0x181F40760")]
	public static NFJAEEDNHJG PPOPBMPFEOP(LPNEEKIAAGE ENLPGHMPOPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EKEJPGAJHNH : MJNFEBBIGCG, PIDHPFCANLD, GODPPCJFBIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KMBGJFKPJOJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
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
			public KMBGJFKPJOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public JGJANGBPMAM errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CE70", Offset = "0x1F5BA70", VA = "0x181F5CE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D0E0", Offset = "0x1F5BCE0", VA = "0x181F5D0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public EKEJPGAJHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KMBGJFKPJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F4B0E0", Offset = "0x1F49CE0", VA = "0x181F4B0E0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task KFJOFAHOPPD(JGJANGBPMAM errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BAGHCNHONDO : IAsyncStateMachine
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
		public EKEJPGAJHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FF40", Offset = "0x1F3EB40", VA = "0x181F3FF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F40450", Offset = "0x1F3F050", VA = "0x181F40450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MFPCDEMDGDK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
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
			public MFPCDEMDGDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D140", Offset = "0x1F5BD40", VA = "0x181F5D140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D420", Offset = "0x1F5C020", VA = "0x181F5D420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public EKEJPGAJHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MFPCDEMDGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F584E0", Offset = "0x1F570E0", VA = "0x181F584E0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GICCKPAPOOK(JGJANGBPMAM errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GFJLNNHFMCB EHGMLNEHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<NMHGKFELIJP> JJADMKHEEFO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private OPKHADNNKCD GACCLNIIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F447D0", Offset = "0x1F433D0", VA = "0x181F447D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DCECDLKENED<NMGIOEAJCBI> LGABBOBAKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B3970", Offset = "0x8B2570", VA = "0x1808B3970", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(DCECDLKENED<NMGIOEAJCBI>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC71580", Offset = "0xC70180", VA = "0x180C71580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DCECDLKENED<OAAFJJJLHDG> NKDLDOPCEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAABBE0", Offset = "0xAAA7E0", VA = "0x180AABBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public DCECDLKENED<IMCNFENPJKF> CNLCMIGHNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86ABB0", Offset = "0x8697B0", VA = "0x18086ABB0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DCECDLKENED<IMCNFENPJKF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override DCECDLKENED<CJEJKMAMNCJ> EPHEFCNNALL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F432D0", Offset = "0x1F41ED0", VA = "0x181F432D0", Slot = "20")]
		get
		{
			return default(DCECDLKENED<CJEJKMAMNCJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ECIGDHAKOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F451F0", Offset = "0x1F43DF0", VA = "0x181F451F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F45770", Offset = "0x1F44370", VA = "0x181F45770")]
	private EKEJPGAJHNH(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK, GFJLNNHFMCB EEHJLLDBAEL, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<NMGIOEAJCBI> ALMJBMBCMPN, DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK, bool ONENGBHGLAP, string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F45300", Offset = "0x1F43F00", VA = "0x181F45300")]
	public static EKEJPGAJHNH PPOPBMPFEOP(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK, GFJLNNHFMCB HJNPKADFMMO, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK, DCECDLKENED<NMGIOEAJCBI> ALMJBMBCMPN, bool ONENGBHGLAP, bool PLLHAEBLAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F439A0", Offset = "0x1F425A0", VA = "0x181F439A0", Slot = "21")]
	protected override void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F438A0", Offset = "0x1F424A0", VA = "0x181F438A0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F45190", Offset = "0x1F43D90", VA = "0x181F45190", Slot = "30")]
	public void NJKOLMNHEGH(NMHGKFELIJP KLOKMDFPOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F43CC0", Offset = "0x1F428C0", VA = "0x181F43CC0", Slot = "27")]
	public void FJNFHFKEICF(OIGLEDJPLCC FDIMCBDCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F447F0", Offset = "0x1F433F0", VA = "0x181F447F0", Slot = "28")]
	public void MMKOPNFHHEH(DPJBKNALION CKJHGKENPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F42EA0", Offset = "0x1F41AA0", VA = "0x181F42EA0", Slot = "23")]
	protected override void ADCKKPKKDDN(CPIDHOALHHJ JKEEDJALKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F43670", Offset = "0x1F42270", VA = "0x181F43670", Slot = "32")]
	public string DPGFCNMBKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F43320", Offset = "0x1F41F20", VA = "0x181F43320", Slot = "29")]
	public string CPIMFHPMBBH(int HLCPHBIOAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F44040", Offset = "0x1F42C40", VA = "0x181F44040")]
	private void GHDOEJAGNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F437E0", Offset = "0x1F423E0", VA = "0x181F437E0", Slot = "31")]
	public void DPJPPIOGFCE(NMHGKFELIJP KLOKMDFPOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F43B00", Offset = "0x1F42700", VA = "0x181F43B00")]
	private void FDFGNBECBOE(bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F444D0", Offset = "0x1F430D0", VA = "0x181F444D0", Slot = "33")]
	[AsyncStateMachine(typeof(BAGHCNHONDO))]
	public Task LLLOKJLLOIB(string GLMEMJNJKAN, bool FPGPFKJFNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F42FF0", Offset = "0x1F41BF0", VA = "0x181F42FF0")]
	public void BEAGFGPKIPG(string GLMEMJNJKAN, bool FPGPFKJFNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F44630", Offset = "0x1F43230", VA = "0x181F44630")]
	private void MFCMLHCMBLF(int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xC71580", Offset = "0xC70180", VA = "0x180C71580")]
	internal void ODNFCPKAELI(DCECDLKENED<NMGIOEAJCBI> GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F43990", Offset = "0x1F42590", VA = "0x181F43990")]
	[CompilerGenerated]
	private void EHELKHLEMEF(string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F43A40", Offset = "0x1F42640", VA = "0x181F43A40")]
	[CompilerGenerated]
	private bool FBINABGLHMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F43140", Offset = "0x1F41D40", VA = "0x181F43140")]
	[CompilerGenerated]
	private bool BEKMCHCGEIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F443C0", Offset = "0x1F42FC0", VA = "0x181F443C0")]
	[CompilerGenerated]
	private int JPAGIADCAHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F435E0", Offset = "0x1F421E0", VA = "0x181F435E0")]
	[CompilerGenerated]
	private bool CPJPCCPCMLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F44030", Offset = "0x1F42C30", VA = "0x181F44030")]
	[CompilerGenerated]
	private void GCCGNGNJNFP(string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F44410", Offset = "0x1F43010", VA = "0x181F44410")]
	[CompilerGenerated]
	private bool KANKOFLMNAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F445E0", Offset = "0x1F431E0", VA = "0x181F445E0")]
	[CompilerGenerated]
	private bool LNHAOLNLMGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F45270", Offset = "0x1F43E70", VA = "0x181F45270")]
	[CompilerGenerated]
	private bool PKKKODLCFKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F443C0", Offset = "0x1F42FC0", VA = "0x181F443C0")]
	[CompilerGenerated]
	private int NOAKFDMAIMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F43200", Offset = "0x1F41E00", VA = "0x181F43200")]
	[CompilerGenerated]
	private bool CKACGKPLPBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F43940", Offset = "0x1F42540", VA = "0x181F43940")]
	[CompilerGenerated]
	private int EGKKLDBDPHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F44270", Offset = "0x1F42E70", VA = "0x181F44270")]
	[CompilerGenerated]
	private void INEFNMJHMDG(object GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F442F0", Offset = "0x1F42EF0", VA = "0x181F442F0")]
	[CompilerGenerated]
	private bool IPEEHIGCCPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KMJPMIMAIMN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class KBACKBILKJB : ADHBAHEGKKB<MGBAOPICJDA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override LIOCLGAMGCA FCDMEKHGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D90", Offset = "0x8B3990", VA = "0x1808B4D90", Slot = "125")]
			get
			{
				return default(LIOCLGAMGCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F4B020", Offset = "0x1F49C20", VA = "0x181F4B020")]
		public KBACKBILKJB(KAPIFPFJPBM KCPELCALJIF, MGBAOPICJDA NHLLCDFJMEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class BOONMLBAOJF : CDGFKNABBGG<PCCOAMPLPOO>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F41480", Offset = "0x1F40080", VA = "0x181F41480")]
		public BOONMLBAOJF(KAPIFPFJPBM KCPELCALJIF, PCCOAMPLPOO LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F412B0", Offset = "0x1F3FEB0", VA = "0x181F412B0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F41430", Offset = "0x1F40030", VA = "0x181F41430")]
		[CompilerGenerated]
		private bool LDCAHNGGDGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F41190", Offset = "0x1F3FD90", VA = "0x181F41190")]
		[CompilerGenerated]
		private void CEDCIEIBFGK(bool GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class LCJEJJBKEIB : CDGFKNABBGG<ALGEOALDCAK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DPAPJANFPNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public LCJEJJBKEIB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DPAPJANFPNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F42200", Offset = "0x1F40E00", VA = "0x181F42200")]
			internal void ELJGOANJBDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F422A0", Offset = "0x1F40EA0", VA = "0x181F422A0")]
			internal bool LJMKIEFGAHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F422F0", Offset = "0x1F40EF0", VA = "0x181F422F0")]
			internal bool PCLCNFNILHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F420E0", Offset = "0x1F40CE0", VA = "0x181F420E0")]
			internal void CNEHGMMCIDE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F42250", Offset = "0x1F40E50", VA = "0x181F42250")]
			internal bool HDCKOKNLGCL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F57C70", Offset = "0x1F56870", VA = "0x181F57C70")]
		public LCJEJJBKEIB(KAPIFPFJPBM KCPELCALJIF, ALGEOALDCAK LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F57940", Offset = "0x1F56540", VA = "0x181F57940", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MNAAMBFKDGO : CDGFKNABBGG<ECKABLHBCHL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class OKPAJMHMECB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public MNAAMBFKDGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public OKPAJMHMECB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C120", Offset = "0x1F5AD20", VA = "0x181F5C120")]
			internal object ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C4E0", Offset = "0x1F5B0E0", VA = "0x181F5C4E0")]
			internal bool MAOHOEAKJAA(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C290", Offset = "0x1F5AE90", VA = "0x181F5C290")]
			internal void LJMKIEFGAHD(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C680", Offset = "0x1F5B280", VA = "0x181F5C680")]
			internal string PCLCNFNILHF(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C080", Offset = "0x1F5AC80", VA = "0x181F5C080")]
			internal IReadOnlyList<object> CNEHGMMCIDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C220", Offset = "0x1F5AE20", VA = "0x181F5C220")]
			internal bool HDCKOKNLGCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C0D0", Offset = "0x1F5ACD0", VA = "0x181F5C0D0")]
			internal bool DBDPMHDNCNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C560", Offset = "0x1F5B160", VA = "0x181F5C560")]
			internal void MBPKLLGJGAI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F59160", Offset = "0x1F57D60", VA = "0x181F59160")]
		public MNAAMBFKDGO(KAPIFPFJPBM KCPELCALJIF, ECKABLHBCHL LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F58A10", Offset = "0x1F57610", VA = "0x181F58A10", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HAPBIFLMENI : CDGFKNABBGG<DFNPFDCPGOD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class PEJBMACOHNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public HAPBIFLMENI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public PEJBMACOHNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C7E0", Offset = "0x1F5B3E0", VA = "0x181F5C7E0")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C830", Offset = "0x1F5B430", VA = "0x181F5C830")]
			internal void LJMKIEFGAHD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C950", Offset = "0x1F5B550", VA = "0x181F5C950")]
			internal bool PCLCNFNILHF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F47BE0", Offset = "0x1F467E0", VA = "0x181F47BE0")]
		public HAPBIFLMENI(KAPIFPFJPBM KCPELCALJIF, DFNPFDCPGOD LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1F479B0", Offset = "0x1F465B0", VA = "0x181F479B0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class GPIPAGDLMFJ<TNode> : CDGFKNABBGG<TNode> where TNode : notnull, JCIMJDGAJBJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct JBFFJCFDCJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public GPIPAGDLMFJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x400FB60", Offset = "0x400E760", VA = "0x18400FB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x400FF50", Offset = "0x400EB50", VA = "0x18400FF50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct HMBCNFFAPBB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GPIPAGDLMFJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public DCECDLKENED<OMKPDHDDBAO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3D591A0", Offset = "0x3D57DA0", VA = "0x183D591A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3D59590", Offset = "0x3D58190", VA = "0x183D59590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool ONEJLBKGLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override DCECDLKENED<OMKPDHDDBAO>? KGMIFDIEFAG
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3CE85C0", Offset = "0x3CE71C0", VA = "0x183CE85C0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8570", Offset = "0x3CE7170", VA = "0x183CE8570")]
		protected GPIPAGDLMFJ(KAPIFPFJPBM KCPELCALJIF, TNode LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8310", Offset = "0x3CE6F10", VA = "0x183CE8310", Slot = "99")]
		[AsyncStateMachine(typeof(GPIPAGDLMFJ<>.JBFFJCFDCJC))]
		public override Task<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> KDKGMBIHBFL(string GFLNGGKHEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8430", Offset = "0x3CE7030", VA = "0x183CE8430", Slot = "123")]
		public sealed override bool LODMGJMDJLI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8270", Offset = "0x3CE6E70", VA = "0x183CE8270", Slot = "111")]
		protected sealed override bool JIMNAACOKJE(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE84D0", Offset = "0x3CE70D0", VA = "0x183CE84D0", Slot = "112")]
		protected override bool PIMJDCJNKOH(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8160", Offset = "0x3CE6D60", VA = "0x183CE8160", Slot = "100")]
		[AsyncStateMachine(typeof(GPIPAGDLMFJ<>.HMBCNFFAPBB))]
		public override Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> DEEOGKAFKBI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class BJDODDLJOBD : CEHEPJCCGAL<KOFLDEEPJAC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class HDIPEFENDBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public BJDODDLJOBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public HDIPEFENDBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F47D10", Offset = "0x1F46910", VA = "0x181F47D10")]
			internal bool NAGIJHBIFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1F47C50", Offset = "0x1F46850", VA = "0x181F47C50")]
			internal void ABOJMLMFABF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F40C90", Offset = "0x1F3F890", VA = "0x181F40C90")]
		public BJDODDLJOBD(KAPIFPFJPBM KCPELCALJIF, KOFLDEEPJAC NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1F40A40", Offset = "0x1F3F640", VA = "0x181F40A40", Slot = "125")]
		protected override void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BBMCHMOHPEC : IBBBHMPMONO<GKAAHHNAMFC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1F404B0", Offset = "0x1F3F0B0", VA = "0x181F404B0")]
		public BBMCHMOHPEC(KAPIFPFJPBM KCPELCALJIF, GKAAHHNAMFC LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class IBBBHMPMONO<TNode> : CDGFKNABBGG<TNode> where TNode : notnull, CECCFEPEDDA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct KOHINOLGHFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public IBBBHMPMONO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x416A920", Offset = "0x4169520", VA = "0x18416A920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x416ACB0", Offset = "0x41698B0", VA = "0x18416ACB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct IHBLNJMNPBK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public IBBBHMPMONO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public DCECDLKENED<OMKPDHDDBAO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3E2A290", Offset = "0x3E28E90", VA = "0x183E2A290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3E2A600", Offset = "0x3E29200", VA = "0x183E2A600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override DCECDLKENED<AJNNPPKMCNH>? LEBKOPCAFOM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3E1F850", Offset = "0x3E1E450", VA = "0x183E1F850", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override DCECDLKENED<OMKPDHDDBAO>? KGMIFDIEFAG
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3E1F910", Offset = "0x3E1E510", VA = "0x183E1F910", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8570", Offset = "0x3CE7170", VA = "0x183CE8570")]
		public IBBBHMPMONO(KAPIFPFJPBM KCPELCALJIF, TNode LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F5F0", Offset = "0x3E1E1F0", VA = "0x183E1F5F0", Slot = "99")]
		[AsyncStateMachine(typeof(IBBBHMPMONO<>.KOHINOLGHFN))]
		public override Task<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> KDKGMBIHBFL(string GFLNGGKHEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F710", Offset = "0x3E1E310", VA = "0x183E1F710", Slot = "123")]
		public sealed override bool LODMGJMDJLI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F550", Offset = "0x3E1E150", VA = "0x183E1F550", Slot = "111")]
		protected sealed override bool JIMNAACOKJE(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F7B0", Offset = "0x3E1E3B0", VA = "0x183E1F7B0", Slot = "112")]
		protected override bool PIMJDCJNKOH(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F440", Offset = "0x3E1E040", VA = "0x183E1F440", Slot = "100")]
		[AsyncStateMachine(typeof(IBBBHMPMONO<>.IHBLNJMNPBK))]
		public override Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> DEEOGKAFKBI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class DNMIKGEBFCK : CDGFKNABBGG<PAKFBPCCODB>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class MJBLLPDFFIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public DNMIKGEBFCK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public MJBLLPDFFIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1F585B0", Offset = "0x1F571B0", VA = "0x181F585B0")]
			internal int ELJGOANJBDB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1F58600", Offset = "0x1F57200", VA = "0x181F58600")]
			internal void LJMKIEFGAHD(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1F41DE0", Offset = "0x1F409E0", VA = "0x181F41DE0")]
		public DNMIKGEBFCK(KAPIFPFJPBM KCPELCALJIF, PAKFBPCCODB LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1F41C20", Offset = "0x1F40820", VA = "0x181F41C20", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class KBACHCGACCA : CEHEPJCCGAL<KPOGMKMMKHP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class PMCBJIOJCNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public KBACHCGACCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public PMCBJIOJCNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CDF0", Offset = "0x1F5B9F0", VA = "0x181F5CDF0")]
			internal int NAGIJHBIFBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CD50", Offset = "0x1F5B950", VA = "0x181F5CD50")]
			internal void ABOJMLMFABF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AFC0", Offset = "0x1F49BC0", VA = "0x181F4AFC0")]
		public KBACHCGACCA(KAPIFPFJPBM KCPELCALJIF, KPOGMKMMKHP NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AD80", Offset = "0x1F49980", VA = "0x181F4AD80", Slot = "125")]
		protected override void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class GKJMAMKNOIO : CDGFKNABBGG<NNBFKNEOACH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8B0A50", Offset = "0x8AF650", VA = "0x1808B0A50", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1F46C50", Offset = "0x1F45850", VA = "0x181F46C50")]
		public GKJMAMKNOIO(KAPIFPFJPBM KCPELCALJIF, NNBFKNEOACH LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class NLAFECGEFEN : CDGFKNABBGG<JOLOLAADOME>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class LCBIMKCPOOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public NLAFECGEFEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public CPELIOLDBEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public LCBIMKCPOOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1F53DA0", Offset = "0x1F529A0", VA = "0x181F53DA0")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x1F55E80", Offset = "0x1F54A80", VA = "0x181F55E80")]
			internal void LJMKIEFGAHD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1F54900", Offset = "0x1F53500", VA = "0x181F54900")]
			internal bool HDCKOKNLGCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1F53890", Offset = "0x1F52490", VA = "0x181F53890")]
			internal bool DBDPMHDNCNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1F56560", Offset = "0x1F55160", VA = "0x181F56560")]
			internal void MBPKLLGJGAI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1F564C0", Offset = "0x1F550C0", VA = "0x181F564C0")]
			internal bool MAEFKDHLLMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D2C0", Offset = "0x1F4BEC0", VA = "0x181F4D2C0")]
			internal bool BLOMLHGBEJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x1F54E90", Offset = "0x1F53A90", VA = "0x181F54E90")]
			internal void IFMAFGEGMGM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1F55220", Offset = "0x1F53E20", VA = "0x181F55220")]
			internal bool ILKKKNNFIIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1F541F0", Offset = "0x1F52DF0", VA = "0x181F541F0")]
			internal bool FINNAAPEOFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x1F55720", Offset = "0x1F54320", VA = "0x181F55720")]
			internal void JGHMIJMMKFA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1F53EE0", Offset = "0x1F52AE0", VA = "0x181F53EE0")]
			internal bool FBAPAFFNPID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CDB0", Offset = "0x1F4B9B0", VA = "0x181F4CDB0")]
			internal bool AJOLCGEFCCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1F55BF0", Offset = "0x1F547F0", VA = "0x181F55BF0")]
			internal bool LDINEGMPOHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1F54FA0", Offset = "0x1F53BA0", VA = "0x181F54FA0")]
			internal bool IHPHPEAEPOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CFB0", Offset = "0x1F4BBB0", VA = "0x181F4CFB0")]
			internal bool BCIHELBKBNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x1F54B30", Offset = "0x1F53730", VA = "0x181F54B30")]
			internal bool HLHNOKNBDMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1F56EC0", Offset = "0x1F55AC0", VA = "0x181F56EC0")]
			internal bool NJOEKMKNBEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x1F53A20", Offset = "0x1F52620", VA = "0x181F53A20")]
			internal bool DKGAJAODFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x1F55040", Offset = "0x1F53C40", VA = "0x181F55040")]
			internal bool IIEGBHGPICH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x1F56C60", Offset = "0x1F55860", VA = "0x181F56C60")]
			internal void NEICCBJIHFE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x1F53C10", Offset = "0x1F52810", VA = "0x181F53C10")]
			internal bool EEFCPBLOGFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x1F557D0", Offset = "0x1F543D0", VA = "0x181F557D0")]
			internal bool JGNMENOPINB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x1F543B0", Offset = "0x1F52FB0", VA = "0x181F543B0")]
			internal bool FMOPAENHDMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x1F55680", Offset = "0x1F54280", VA = "0x181F55680")]
			internal bool JEDOIAPCCCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1F54EF0", Offset = "0x1F53AF0", VA = "0x181F54EF0")]
			internal bool IGAIFHDGFND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D000", Offset = "0x1F4BC00", VA = "0x181F4D000")]
			internal bool BFDJHKIBJPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1F53D00", Offset = "0x1F52900", VA = "0x181F53D00")]
			internal bool EKBHANPAJKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x1F53CB0", Offset = "0x1F528B0", VA = "0x181F53CB0")]
			internal bool EJOFCNNLDOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x1F56460", Offset = "0x1F55060", VA = "0x181F56460")]
			internal void MABPMKNOIOL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x1F56350", Offset = "0x1F54F50", VA = "0x181F56350")]
			internal bool LMKPCEAMBLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D050", Offset = "0x1F4BC50", VA = "0x181F4D050")]
			internal bool BGGEINBBGAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1F54DC0", Offset = "0x1F539C0", VA = "0x181F54DC0")]
			internal void ICCBBEPKFCK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1F53980", Offset = "0x1F52580", VA = "0x181F53980")]
			internal bool DHFNFAMIOLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1F56B70", Offset = "0x1F55770", VA = "0x181F56B70")]
			internal bool NCPMLJOLMHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1F53BB0", Offset = "0x1F527B0", VA = "0x181F53BB0")]
			internal void EDCIJLOFDCM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D3D0", Offset = "0x1F4BFD0", VA = "0x181F4D3D0")]
			internal List<PFDDMMHMEHP> CDGHJJEABDI(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1F53700", Offset = "0x1F52300", VA = "0x181F53700")]
			internal bool CHILHAMJMGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x1F56F10", Offset = "0x1F55B10", VA = "0x181F56F10")]
			internal int NLBGKFNGPEH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1F54350", Offset = "0x1F52F50", VA = "0x181F54350")]
			internal void FMCKEOOLPDE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x1F577F0", Offset = "0x1F563F0", VA = "0x181F577F0")]
			internal bool POANCAIHENP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x1F571B0", Offset = "0x1F55DB0", VA = "0x181F571B0")]
			internal bool OEAAJDMKFMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x1F539D0", Offset = "0x1F525D0", VA = "0x181F539D0")]
			internal bool DINOGDLPDBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1F55D30", Offset = "0x1F54930", VA = "0x181F55D30")]
			internal int LGAGJLLBDED()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1F573A0", Offset = "0x1F55FA0", VA = "0x181F573A0")]
			internal void PACOGJCFCHN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x1F57450", Offset = "0x1F56050", VA = "0x181F57450")]
			internal bool PEHNNCNEDIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1F54CC0", Offset = "0x1F538C0", VA = "0x181F54CC0")]
			internal bool HONEHKGAOFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1F56E70", Offset = "0x1F55A70", VA = "0x181F56E70")]
			internal bool NIOFLJDHFKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x1F57300", Offset = "0x1F55F00", VA = "0x181F57300")]
			internal bool OOPKPAABAFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1F552C0", Offset = "0x1F53EC0", VA = "0x181F552C0")]
			internal bool IMFCIDJJAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1F56CC0", Offset = "0x1F558C0", VA = "0x181F56CC0")]
			internal bool NEJCPEIOFBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D0A0", Offset = "0x1F4BCA0", VA = "0x181F4D0A0")]
			internal string BGPPGCFDKNN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1F563F0", Offset = "0x1F54FF0", VA = "0x181F563F0")]
			internal void LOFIIMBNEGB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F55E30", Offset = "0x1F54A30", VA = "0x181F55E30")]
			internal int LHNHDNJFJKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1F54D60", Offset = "0x1F53960", VA = "0x181F54D60")]
			internal void IBMFCLBIHCN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1F54950", Offset = "0x1F53550", VA = "0x181F54950")]
			internal bool HDPCKOIDAKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1F53FD0", Offset = "0x1F52BD0", VA = "0x181F53FD0")]
			internal bool FFGMHIEBFEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1F54680", Offset = "0x1F53280", VA = "0x181F54680")]
			internal bool GEJHKHGFAMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1F546D0", Offset = "0x1F532D0", VA = "0x181F546D0")]
			internal float GLJBJKIEINO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1F56A20", Offset = "0x1F55620", VA = "0x181F56A20")]
			internal void MPANEKJKEPM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1F53840", Offset = "0x1F52440", VA = "0x181F53840")]
			internal bool DBDBOJNHODP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1F551D0", Offset = "0x1F53DD0", VA = "0x181F551D0")]
			internal bool ILJFFJIGMEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CE00", Offset = "0x1F4BA00", VA = "0x181F4CE00")]
			internal bool AKGOIONOJHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1F549A0", Offset = "0x1F535A0", VA = "0x181F549A0")]
			internal bool HEMAAAPBCMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1F54A90", Offset = "0x1F53690", VA = "0x181F54A90")]
			internal bool HGHHNLMEEEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CE50", Offset = "0x1F4BA50", VA = "0x181F4CE50")]
			internal bool ALJMMGKPDAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1F55EE0", Offset = "0x1F54AE0", VA = "0x181F55EE0")]
			internal void LKBPHEMGAFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1F56F60", Offset = "0x1F55B60", VA = "0x181F56F60")]
			internal string NLBMCJBEPFJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1F575C0", Offset = "0x1F561C0", VA = "0x181F575C0")]
			internal void PGPDHFDCFLJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1F54FF0", Offset = "0x1F53BF0", VA = "0x181F54FF0")]
			internal bool IIBCFDAAIPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x1F56E20", Offset = "0x1F55A20", VA = "0x181F56E20")]
			internal bool NIBCDLCMGCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1F537F0", Offset = "0x1F523F0", VA = "0x181F537F0")]
			internal bool CPGPNKNMIKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1F56610", Offset = "0x1F55210", VA = "0x181F56610")]
			internal void MFADKJKCHKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D380", Offset = "0x1F4BF80", VA = "0x181F4D380")]
			internal bool BMLJDCCGHDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1F57160", Offset = "0x1F55D60", VA = "0x181F57160")]
			internal bool OBACICCKGNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1F53A70", Offset = "0x1F52670", VA = "0x181F53A70")]
			internal bool DMOHEONKPHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1F558C0", Offset = "0x1F544C0", VA = "0x181F558C0")]
			internal bool KDGDJJEPMOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1F55B90", Offset = "0x1F54790", VA = "0x181F55B90")]
			internal void LDBIOGOJANG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1F55130", Offset = "0x1F53D30", VA = "0x181F55130")]
			internal bool IJOIBIFBMMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1F55420", Offset = "0x1F54020", VA = "0x181F55420")]
			internal bool IOAAEBOLDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1F538E0", Offset = "0x1F524E0", VA = "0x181F538E0")]
			internal bool DGIOPPPLNHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1F53520", Offset = "0x1F52120", VA = "0x181F53520")]
			internal bool CDHPBDENGOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F578E0", Offset = "0x1F564E0", VA = "0x181F578E0")]
			internal void PONMNEOIEMJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1F54470", Offset = "0x1F53070", VA = "0x181F54470")]
			internal bool FPGIEDMKGJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1F55360", Offset = "0x1F53F60", VA = "0x181F55360")]
			internal bool INFBJHFDNHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1F565C0", Offset = "0x1F551C0", VA = "0x181F565C0")]
			internal bool MDGEDPOLLMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1F53570", Offset = "0x1F52170", VA = "0x181F53570")]
			internal bool CEFNAGHOPLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F55910", Offset = "0x1F54510", VA = "0x181F55910")]
			internal int KDPECAKNOPN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D230", Offset = "0x1F4BE30", VA = "0x181F4D230")]
			internal void BKPDOKOIBJO(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CF10", Offset = "0x1F4BB10", VA = "0x181F4CF10")]
			internal bool BABCOOGMGOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1F56A80", Offset = "0x1F55680", VA = "0x181F56A80")]
			internal bool NAHDEKJJACC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x1F56930", Offset = "0x1F55530", VA = "0x181F56930")]
			internal int MHEMCAEOAID()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x1F55AE0", Offset = "0x1F546E0", VA = "0x181F55AE0")]
			internal void KOEEKOMCDIC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x1F550E0", Offset = "0x1F53CE0", VA = "0x181F550E0")]
			internal bool IIOKEALKICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1F541A0", Offset = "0x1F52DA0", VA = "0x181F541A0")]
			internal bool FHNBFAEFIEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F56300", Offset = "0x1F54F00", VA = "0x181F56300")]
			internal int LMJFEAAFJLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F54F40", Offset = "0x1F53B40", VA = "0x181F54F40")]
			internal void IGCLEMIMIHK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1F54C70", Offset = "0x1F53870", VA = "0x181F54C70")]
			internal bool HOKOGDFBDCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F548B0", Offset = "0x1F534B0", VA = "0x181F548B0")]
			internal bool HCOFELKGIKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F54D10", Offset = "0x1F53910", VA = "0x181F54D10")]
			internal bool IACHFLJJOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F54860", Offset = "0x1F53460", VA = "0x181F54860")]
			internal int HBGPPLFKCPJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F57720", Offset = "0x1F56320", VA = "0x181F57720")]
			internal void PMMOLPDFINN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CB20", Offset = "0x1F4B720", VA = "0x181F4CB20")]
			internal bool ABIPILEDDNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F576D0", Offset = "0x1F562D0", VA = "0x181F576D0")]
			internal bool PMHMAMHBPGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F55590", Offset = "0x1F54190", VA = "0x181F55590")]
			internal bool JBLPAMPMLDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CEA0", Offset = "0x1F4BAA0", VA = "0x181F4CEA0")]
			internal object APCHIJJCKJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F54530", Offset = "0x1F53130", VA = "0x181F54530")]
			internal void FPJNNBDGOPD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F53930", Offset = "0x1F52530", VA = "0x181F53930")]
			internal bool DGNBEBIDDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F53C60", Offset = "0x1F52860", VA = "0x181F53C60")]
			internal bool EICCJGMCFNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F54E20", Offset = "0x1F53A20", VA = "0x181F54E20")]
			internal object IEONDOCBHCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F55A00", Offset = "0x1F54600", VA = "0x181F55A00")]
			internal void KMKAFMNCOKA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F53F30", Offset = "0x1F52B30", VA = "0x181F53F30")]
			internal bool FEBHIFBMDIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F55180", Offset = "0x1F53D80", VA = "0x181F55180")]
			internal int IKMIOEHBEOK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F574A0", Offset = "0x1F560A0", VA = "0x181F574A0")]
			internal void PGBMNPGKNDE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F56B20", Offset = "0x1F55720", VA = "0x181F56B20")]
			internal bool NCHFAGGKEKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F569D0", Offset = "0x1F555D0", VA = "0x181F569D0")]
			internal bool MLKNECAHBNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F559B0", Offset = "0x1F545B0", VA = "0x181F559B0")]
			internal bool KMIGJLPHLBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4BD90", VA = "0x181F4D190")]
			internal int BKJKFFPFBNH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CBC0", Offset = "0x1F4B7C0", VA = "0x181F4CBC0")]
			internal void AGKNNHGJLHC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F56510", Offset = "0x1F55110", VA = "0x181F56510")]
			internal bool MBPGNOLHPOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D1E0", Offset = "0x1F4BDE0", VA = "0x181F4D1E0")]
			internal bool BKPCHFJAGNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CF60", Offset = "0x1F4BB60", VA = "0x181F4CF60")]
			internal bool BBDCDFGLEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F55960", Offset = "0x1F54560", VA = "0x181F55960")]
			internal float KFIAACIFCFP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F57200", Offset = "0x1F55E00", VA = "0x181F57200")]
			internal void OEGIMLJEJIE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F56C10", Offset = "0x1F55810", VA = "0x181F56C10")]
			internal bool NEHBLDKMKPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CD60", Offset = "0x1F4B960", VA = "0x181F4CD60")]
			internal bool AJOGOKPHPPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F536B0", Offset = "0x1F522B0", VA = "0x181F536B0")]
			internal bool CHGBLPHDPKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F53DF0", Offset = "0x1F529F0", VA = "0x181F53DF0")]
			internal float EMCPLPAIIDE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F55DD0", Offset = "0x1F549D0", VA = "0x181F55DD0")]
			internal void LHFHFLCJDLH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F55470", Offset = "0x1F54070", VA = "0x181F55470")]
			internal bool IPAOJKODKIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1F55C90", Offset = "0x1F54890", VA = "0x181F55C90")]
			internal bool LEEEPPPAPGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F56BC0", Offset = "0x1F557C0", VA = "0x181F56BC0")]
			internal string NEGGANEHOAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F545C0", Offset = "0x1F531C0", VA = "0x181F545C0")]
			internal void GACNJENBBPF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1F55270", Offset = "0x1F53E70", VA = "0x181F55270")]
			internal bool IMBPFPKCNAD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CCC0", Offset = "0x1F4B8C0", VA = "0x181F4CCC0")]
			internal bool AJAAIPEJBMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F55D80", Offset = "0x1F54980", VA = "0x181F55D80")]
			internal bool LGKOMOOKOGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F57500", Offset = "0x1F56100", VA = "0x181F57500")]
			internal bool PGEKEKJAJLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F54720", Offset = "0x1F53320", VA = "0x181F54720")]
			internal string GLNJNCEOJIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F56FB0", Offset = "0x1F55BB0", VA = "0x181F56FB0")]
			internal void NLHMOOLFAOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F555E0", Offset = "0x1F541E0", VA = "0x181F555E0")]
			internal bool JCEHPLGEELL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F57630", Offset = "0x1F56230", VA = "0x181F57630")]
			internal bool PHFBCDPIGPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F549F0", Offset = "0x1F535F0", VA = "0x181F549F0")]
			internal bool HFEODDKAOED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F55B40", Offset = "0x1F54740", VA = "0x181F55B40")]
			internal bool KPNIHIGFHPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F57840", Offset = "0x1F56440", VA = "0x181F57840")]
			internal string POEHMBBECNN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F544C0", Offset = "0x1F530C0", VA = "0x181F544C0")]
			internal void FPHPNGCHCKP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F55310", Offset = "0x1F53F10", VA = "0x181F55310")]
			internal bool IMIBANABAPL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F55090", Offset = "0x1F53C90", VA = "0x181F55090")]
			internal bool IINKIMFNGDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1F55A90", Offset = "0x1F54690", VA = "0x181F55A90")]
			internal bool KNDPBMHEDGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F55870", Offset = "0x1F54470", VA = "0x181F55870")]
			internal bool JLAPFELFMIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D0F0", Offset = "0x1F4BCF0", VA = "0x181F4D0F0")]
			internal string BIKJDEHADCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F56DB0", Offset = "0x1F559B0", VA = "0x181F56DB0")]
			internal void NHCFJHALAHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F57680", Offset = "0x1F56280", VA = "0x181F57680")]
			internal bool PJOMPNLPOPH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F537A0", Offset = "0x1F523A0", VA = "0x181F537A0")]
			internal bool COLLBLIPHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F53E90", Offset = "0x1F52A90", VA = "0x181F53E90")]
			internal bool EOKEKKAFOIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CB70", Offset = "0x1F4B770", VA = "0x181F4CB70")]
			internal bool ACHDMCGCKBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F54630", Offset = "0x1F53230", VA = "0x181F54630")]
			internal string GBFLCAGACKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F540C0", Offset = "0x1F52CC0", VA = "0x181F540C0")]
			internal void FHAHPMNHNLL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F54810", Offset = "0x1F53410", VA = "0x181F54810")]
			internal bool GPGPONLBAHC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F55CE0", Offset = "0x1F548E0", VA = "0x181F55CE0")]
			internal bool LEPAHPHOOPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1F57260", Offset = "0x1F55E60", VA = "0x181F57260")]
			internal bool OFODLHIPPBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1F56980", Offset = "0x1F55580", VA = "0x181F56980")]
			internal bool MJBMJFFIHNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F54B80", Offset = "0x1F53780", VA = "0x181F54B80")]
			internal string HMDKAGBHJOL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F554C0", Offset = "0x1F540C0", VA = "0x181F554C0")]
			internal void JAKHEJGKPAB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F54070", Offset = "0x1F52C70", VA = "0x181F54070")]
			internal bool FGJGBHKJDMM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D140", Offset = "0x1F4BD40", VA = "0x181F4D140")]
			internal bool BINILEOHLBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F54300", Offset = "0x1F52F00", VA = "0x181F54300")]
			internal bool FLEKKOLMDHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F55780", Offset = "0x1F54380", VA = "0x181F55780")]
			internal bool JGMPPIGCBNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F53660", Offset = "0x1F52260", VA = "0x181F53660")]
			internal string CGNFHKPABCN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F553B0", Offset = "0x1F53FB0", VA = "0x181F553B0")]
			internal void INOLMKFGPCF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F53B10", Offset = "0x1F52710", VA = "0x181F53B10")]
			internal bool DPGJPAPIIGA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F563A0", Offset = "0x1F54FA0", VA = "0x181F563A0")]
			internal bool LNEOACAINFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F556D0", Offset = "0x1F542D0", VA = "0x181F556D0")]
			internal bool JFNFKMEELMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F55820", Offset = "0x1F54420", VA = "0x181F55820")]
			internal bool JJGIDIMCIII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F56D60", Offset = "0x1F55960", VA = "0x181F56D60")]
			internal string NGPLLOEAPCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F57550", Offset = "0x1F56150", VA = "0x181F57550")]
			internal void PGNKCLACECG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F570C0", Offset = "0x1F55CC0", VA = "0x181F570C0")]
			internal bool NPHFKPGFDHL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F542B0", Offset = "0x1F52EB0", VA = "0x181F542B0")]
			internal bool FJOFMKEFPCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1F53750", Offset = "0x1F52350", VA = "0x181F53750")]
			internal bool CMKDGJHKMAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CC20", Offset = "0x1F4B820", VA = "0x181F4CC20")]
			internal bool AGMAAOBNGDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F535C0", Offset = "0x1F521C0", VA = "0x181F535C0")]
			internal string CFNNKBPNBCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F54400", Offset = "0x1F53000", VA = "0x181F54400")]
			internal void FPFOLBDMNJK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F57890", Offset = "0x1F56490", VA = "0x181F57890")]
			internal bool POJLAAFGCFM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F57020", Offset = "0x1F55C20", VA = "0x181F57020")]
			internal bool NLOCGGDKFJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F55C40", Offset = "0x1F54840", VA = "0x181F55C40")]
			internal bool LDLINDMOEGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F54770", Offset = "0x1F53370", VA = "0x181F54770")]
			internal bool GLPPBOCCLBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F54A40", Offset = "0x1F53640", VA = "0x181F54A40")]
			internal string HGAODIGILKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F4D310", Offset = "0x1F4BF10", VA = "0x181F4D310")]
			internal void BMFOELOIAEA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F57070", Offset = "0x1F55C70", VA = "0x181F57070")]
			internal bool NMDIOJLLPMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F53D50", Offset = "0x1F52950", VA = "0x181F53D50")]
			internal bool EKDLJHLEAIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F53E40", Offset = "0x1F52A40", VA = "0x181F53E40")]
			internal bool EOAIHGMFMEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CD10", Offset = "0x1F4B910", VA = "0x181F4CD10")]
			internal string AJCPAHBFMHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F57780", Offset = "0x1F56380", VA = "0x181F57780")]
			internal void PNGEOMDFKAM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F54020", Offset = "0x1F52C20", VA = "0x181F54020")]
			internal bool FGABCEDPNBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F53AC0", Offset = "0x1F526C0", VA = "0x181F53AC0")]
			internal bool DNOGKNKPGFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F57400", Offset = "0x1F56000", VA = "0x181F57400")]
			internal bool PEFKAPMGMGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F4CC70", Offset = "0x1F4B870", VA = "0x181F4CC70")]
			internal string AIOOOMGJEMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F54130", Offset = "0x1F52D30", VA = "0x181F54130")]
			internal void FHBCAIHBCLJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F53B60", Offset = "0x1F52760", VA = "0x181F53B60")]
			internal bool EALMNPOBPPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F53F80", Offset = "0x1F52B80", VA = "0x181F53F80")]
			internal bool FEPPFFEJAHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F57350", Offset = "0x1F55F50", VA = "0x181F57350")]
			internal bool OPJOLCEDOLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F54C20", Offset = "0x1F53820", VA = "0x181F54C20")]
			internal string HOEIAIEDDGG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F54240", Offset = "0x1F52E40", VA = "0x181F54240")]
			internal void FJIFNGMJBCF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F53610", Offset = "0x1F52210", VA = "0x181F53610")]
			internal bool CFPLFMDFEIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1F57110", Offset = "0x1F55D10", VA = "0x181F57110")]
			internal bool OAPLHAGHDBB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F547C0", Offset = "0x1F533C0", VA = "0x181F547C0")]
			internal float GOKLMAHKJGI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F562A0", Offset = "0x1F54EA0", VA = "0x181F562A0")]
			internal void LKDMNIGFLGP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F568E0", Offset = "0x1F554E0", VA = "0x181F568E0")]
			internal bool MGGDKBPPJJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F54BD0", Offset = "0x1F537D0", VA = "0x181F54BD0")]
			internal bool HNGNKFEFBFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F56AD0", Offset = "0x1F556D0", VA = "0x181F56AD0")]
			internal bool NBAEDHIOPDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F572B0", Offset = "0x1F55EB0", VA = "0x181F572B0")]
			internal int OMLBODPKAAI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F55530", Offset = "0x1F54130", VA = "0x181F55530")]
			internal void JBKEKIDOHKO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F56D10", Offset = "0x1F55910", VA = "0x181F56D10")]
			internal bool NGNLOIDLDKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F55630", Offset = "0x1F54230", VA = "0x181F55630")]
			internal bool JDGCMACMAJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F54AE0", Offset = "0x1F536E0", VA = "0x181F54AE0")]
			internal bool HHPKEFCFHHN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class HAFBLGOKJGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public LCBIMKCPOOE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public HAFBLGOKJGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F46E50", Offset = "0x1F45A50", VA = "0x181F46E50")]
			internal void PKIMCMHJPIC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class DIKOCILMOGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DIKOCILMOGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F41BA0", Offset = "0x1F407A0", VA = "0x181F41BA0")]
			internal bool DAINFOKNGMJ(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly DHMKNCGHNLM ECGCCCBFEAF;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B780", Offset = "0x1F5A380", VA = "0x181F5B780")]
		public NLAFECGEFEN(KAPIFPFJPBM KCPELCALJIF, JOLOLAADOME LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1F599B0", Offset = "0x1F585B0", VA = "0x181F599B0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class KCMMCHFIJKN : CDGFKNABBGG<PMKHFMNJGIO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class DBIDJGCFHLP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public DBIDJGCFHLP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x1F79A00", Offset = "0x1F78600", VA = "0x181F79A00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public KCMMCHFIJKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DBIDJGCFHLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F60470", Offset = "0x1F5F070", VA = "0x181F60470")]
			internal string ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F604C0", Offset = "0x1F5F0C0", VA = "0x181F604C0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void LJMKIEFGAHD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F60590", Offset = "0x1F5F190", VA = "0x181F60590")]
			internal int PCLCNFNILHF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F603E0", Offset = "0x1F5EFE0", VA = "0x181F603E0")]
			internal void CNEHGMMCIDE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EB30", Offset = "0x1F6D730", VA = "0x181F6EB30")]
		public KCMMCHFIJKN(KAPIFPFJPBM KCPELCALJIF, PMKHFMNJGIO NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1F6E7E0", Offset = "0x1F6D3E0", VA = "0x181F6E7E0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class JBLNIKAJGNK : CDGFKNABBGG<CONCNHDJFNK>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class MOLOOMONIJN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public MOLOOMONIJN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x1F796C0", Offset = "0x1F782C0", VA = "0x181F796C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				public MOLOOMONIJN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x1F79D10", Offset = "0x1F78910", VA = "0x181F79D10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public JBLNIKAJGNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public MOLOOMONIJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F75E40", Offset = "0x1F74A40", VA = "0x181F75E40")]
			internal string ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F76030", Offset = "0x1F74C30", VA = "0x181F76030")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void LJMKIEFGAHD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F76270", Offset = "0x1F74E70", VA = "0x181F76270")]
			internal int PCLCNFNILHF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F75BE0", Offset = "0x1F747E0", VA = "0x181F75BE0")]
			internal void CNEHGMMCIDE(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F75E90", Offset = "0x1F74A90", VA = "0x181F75E90")]
			internal string HDCKOKNLGCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F75C70", Offset = "0x1F74870", VA = "0x181F75C70")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DBDPMHDNCNG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F76220", Offset = "0x1F74E20", VA = "0x181F76220")]
			internal bool MBPKLLGJGAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F76190", Offset = "0x1F74D90", VA = "0x181F76190")]
			internal void MAOHOEAKJAA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F75FE0", Offset = "0x1F74BE0", VA = "0x181F75FE0")]
			internal bool IPLKOHEGHFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F76100", Offset = "0x1F74D00", VA = "0x181F76100")]
			internal void MAEFKDHLLMA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F75B90", Offset = "0x1F74790", VA = "0x181F75B90")]
			internal float BLOMLHGBEJK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F75EE0", Offset = "0x1F74AE0", VA = "0x181F75EE0")]
			internal void IFMAFGEGMGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F75DE0", Offset = "0x1F749E0", VA = "0x181F75DE0")]
			internal int DNLDNBPGAKI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F75D40", Offset = "0x1F74940", VA = "0x181F75D40")]
			internal void DCGEMJPLLHO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F75F70", Offset = "0x1F74B70", VA = "0x181F75F70")]
			internal bool ILKKKNNFIIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BB20", Offset = "0x1F6A720", VA = "0x181F6BB20")]
		public JBLNIKAJGNK(KAPIFPFJPBM KCPELCALJIF, CONCNHDJFNK LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B0E0", Offset = "0x1F69CE0", VA = "0x181F6B0E0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class OFGPEOLEHBD : CDGFKNABBGG<DEFHFNPBEBF>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class FCADEBHPGCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public OFGPEOLEHBD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public FCADEBHPGCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F689F0", Offset = "0x1F675F0", VA = "0x181F689F0")]
			internal Dictionary<string, EJFDDCNOMKE> ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F68A90", Offset = "0x1F67690", VA = "0x181F68A90")]
			internal int LJMKIEFGAHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F68AE0", Offset = "0x1F676E0", VA = "0x181F68AE0")]
			internal void PCLCNFNILHF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F68970", Offset = "0x1F67570", VA = "0x181F68970")]
			internal bool CNEHGMMCIDE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1F774A0", Offset = "0x1F760A0", VA = "0x181F774A0")]
		public OFGPEOLEHBD(KAPIFPFJPBM KCPELCALJIF, DEFHFNPBEBF NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1F77200", Offset = "0x1F75E00", VA = "0x181F77200", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class EIFHHELKDBK : CDGFKNABBGG<GHHJEHKIFJD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1F61EB0", Offset = "0x1F60AB0", VA = "0x181F61EB0")]
		public EIFHHELKDBK(KAPIFPFJPBM KCPELCALJIF, GHHJEHKIFJD NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1F61DC0", Offset = "0x1F609C0", VA = "0x181F61DC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1F61CA0", Offset = "0x1F608A0", VA = "0x181F61CA0")]
		[CompilerGenerated]
		private void CHGNBIAOOFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class DMIKIMCOMPI : IBBBHMPMONO<GHGOBPBFHON>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool INAJKNDPHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool IEJBIMPNOHC
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F61710", Offset = "0x1F60310", VA = "0x181F61710", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x8C3C80", Offset = "0x8C2880", VA = "0x1808C3C80", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1F616B0", Offset = "0x1F602B0", VA = "0x181F616B0")]
		public DMIKIMCOMPI(KAPIFPFJPBM KCPELCALJIF, GHGOBPBFHON LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class GPLFNIFCEAD : CDGFKNABBGG<HLEHJGCOMMF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8B2EA0", Offset = "0x8B1AA0", VA = "0x1808B2EA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AAF0", Offset = "0x1F696F0", VA = "0x181F6AAF0")]
		public GPLFNIFCEAD(KAPIFPFJPBM KCPELCALJIF, HLEHJGCOMMF LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class PADAEINMLLA : CDGFKNABBGG<OAKAFMHEDIP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8B1BF0", Offset = "0x8B07F0", VA = "0x1808B1BF0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1F778D0", Offset = "0x1F764D0", VA = "0x181F778D0")]
		public PADAEINMLLA(KAPIFPFJPBM KCPELCALJIF, OAKAFMHEDIP LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "111")]
		protected override bool JIMNAACOKJE(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class FGIMGDMHEFA : CDGFKNABBGG<IDJDKFGJFEK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8BC790", Offset = "0x8BB390", VA = "0x1808BC790", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool KCODEDAKGDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x1F69150", Offset = "0x1F67D50", VA = "0x181F69150", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override bool BOPBEGODDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F690E0", Offset = "0x1F67CE0", VA = "0x181F690E0")]
		public FGIMGDMHEFA(KAPIFPFJPBM KCPELCALJIF, IDJDKFGJFEK LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class JNNBBCEEHMD : CDGFKNABBGG<EAKHPGLGHEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D90", Offset = "0x8B3990", VA = "0x1808B4D90", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool KCODEDAKGDG
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6E690", Offset = "0x1F6D290", VA = "0x181F6E690", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override bool BOPBEGODDKP
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6E620", Offset = "0x1F6D220", VA = "0x181F6E620")]
		public JNNBBCEEHMD(KAPIFPFJPBM KCPELCALJIF, EAKHPGLGHEK LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class FBEFHAIMDPF : CEHEPJCCGAL<OGCOPJABFDP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class ANENLGMOKPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public FBEFHAIMDPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ANENLGMOKPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EB90", Offset = "0x1F5D790", VA = "0x181F5EB90")]
			internal float NAGIJHBIFBL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EAF0", Offset = "0x1F5D6F0", VA = "0x181F5EAF0")]
			internal void ABOJMLMFABF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1F68910", Offset = "0x1F67510", VA = "0x181F68910")]
		public FBEFHAIMDPF(KAPIFPFJPBM KCPELCALJIF, OGCOPJABFDP NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1F68690", Offset = "0x1F67290", VA = "0x181F68690", Slot = "125")]
		protected override void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class DCBFDFBGPCB : CDGFKNABBGG<DPGILCFBPID>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DPPKLKEKOPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public DCBFDFBGPCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DPPKLKEKOPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x1F61770", Offset = "0x1F60370", VA = "0x181F61770")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x1F617C0", Offset = "0x1F603C0", VA = "0x181F617C0")]
			internal void LJMKIEFGAHD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1F60890", Offset = "0x1F5F490", VA = "0x181F60890")]
		public DCBFDFBGPCB(KAPIFPFJPBM KCPELCALJIF, DPGILCFBPID NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1F605E0", Offset = "0x1F5F1E0", VA = "0x181F605E0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class JJPDDCNLKDG : CDGFKNABBGG<BJKPHHGGHPO>
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class BJHKNFNONOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public JJPDDCNLKDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BJHKNFNONOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F3F0", Offset = "0x1F5DFF0", VA = "0x181F5F3F0")]
			internal object ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F7E0", Offset = "0x1F5E3E0", VA = "0x181F5F7E0")]
			internal bool MAOHOEAKJAA(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F590", Offset = "0x1F5E190", VA = "0x181F5F590")]
			internal void LJMKIEFGAHD(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F980", Offset = "0x1F5E580", VA = "0x181F5F980")]
			internal string PCLCNFNILHF(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F350", Offset = "0x1F5DF50", VA = "0x181F5F350")]
			internal IReadOnlyList<object> CNEHGMMCIDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F520", Offset = "0x1F5E120", VA = "0x181F5F520")]
			internal bool HDCKOKNLGCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F3A0", Offset = "0x1F5DFA0", VA = "0x181F5F3A0")]
			internal bool DBDPMHDNCNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x1F5F860", Offset = "0x1F5E460", VA = "0x181F5F860")]
			internal void MBPKLLGJGAI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C850", Offset = "0x1F6B450", VA = "0x181F6C850")]
		public JJPDDCNLKDG(KAPIFPFJPBM KCPELCALJIF, BJKPHHGGHPO NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C050", Offset = "0x1F6AC50", VA = "0x181F6C050", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class DEGHBGCHALO : GPIPAGDLMFJ<AKBJGILFFLM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA833F0", Offset = "0xA81FF0", VA = "0x180A833F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1F609E0", Offset = "0x1F5F5E0", VA = "0x181F609E0")]
		public DEGHBGCHALO(KAPIFPFJPBM KCPELCALJIF, AKBJGILFFLM LNFMEAPGAAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class APGEFLIGBED : CEHEPJCCGAL<AMOJJGLDNDP>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class FJNMCNAFKMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public APGEFLIGBED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public FJNMCNAFKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x1F69810", Offset = "0x1F68410", VA = "0x181F69810")]
			internal int NAGIJHBIFBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x1F69770", Offset = "0x1F68370", VA = "0x181F69770")]
			internal void ABOJMLMFABF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EF00", Offset = "0x1F5DB00", VA = "0x181F5EF00")]
		public APGEFLIGBED(KAPIFPFJPBM KCPELCALJIF, AMOJJGLDNDP NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EC70", Offset = "0x1F5D870", VA = "0x181F5EC70", Slot = "125")]
		protected override void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class FIJGKKKDDEN : CDGFKNABBGG<DJNBFJJOAIG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class BLMLPOCEODG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public FIJGKKKDDEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BLMLPOCEODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5FAE0", Offset = "0x1F5E6E0", VA = "0x181F5FAE0")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F5FB30", Offset = "0x1F5E730", VA = "0x181F5FB30")]
			internal void LJMKIEFGAHD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1F69380", Offset = "0x1F67F80", VA = "0x181F69380")]
		public FIJGKKKDDEN(KAPIFPFJPBM KCPELCALJIF, DJNBFJJOAIG NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1F691A0", Offset = "0x1F67DA0", VA = "0x181F691A0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class LCNNFHHEPAH : CDGFKNABBGG<FJAGDJAOEPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class EKIGCHDJGIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public LCNNFHHEPAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public EKIGCHDJGIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F61F20", Offset = "0x1F60B20", VA = "0x181F61F20")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F61F70", Offset = "0x1F60B70", VA = "0x181F61F70")]
			internal void LJMKIEFGAHD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F140", Offset = "0x1F6DD40", VA = "0x181F6F140")]
		public LCNNFHHEPAH(KAPIFPFJPBM KCPELCALJIF, FJAGDJAOEPO NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EF60", Offset = "0x1F6DB60", VA = "0x181F6EF60", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class JBKOAFOMOFJ : CDGFKNABBGG<CGLFGHAEHIK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class DDENIKHCJIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public JBKOAFOMOFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DDENIKHCJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F60900", Offset = "0x1F5F500", VA = "0x181F60900")]
			internal int ELJGOANJBDB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F60950", Offset = "0x1F5F550", VA = "0x181F60950")]
			internal void LJMKIEFGAHD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B070", Offset = "0x1F69C70", VA = "0x181F6B070")]
		public JBKOAFOMOFJ(KAPIFPFJPBM KCPELCALJIF, CGLFGHAEHIK NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AE10", Offset = "0x1F69A10", VA = "0x181F6AE10", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class CJJIACKLHHF : ADHBAHEGKKB<NGDPFCAINML>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override LIOCLGAMGCA FCDMEKHGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "125")]
			get
			{
				return default(LIOCLGAMGCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FBC0", Offset = "0x1F5E7C0", VA = "0x181F5FBC0")]
		public CJJIACKLHHF(KAPIFPFJPBM KCPELCALJIF, NGDPFCAINML NHLLCDFJMEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class DKEDJBIIGKO : CDGFKNABBGG<JJIKDDBCBGL>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F60BC0", Offset = "0x1F5F7C0", VA = "0x181F60BC0")]
		public DKEDJBIIGKO(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public abstract class CDGFKNABBGG<TNode> : OBMNEEPHOCK, IDisposable where TNode : notnull, JJIKDDBCBGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		protected readonly struct JGKJHJPMOLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public readonly string AEJFCLFDGMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public readonly string FIJCIPDKAKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public readonly string DMPECOANLBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public readonly OBJOBBMGDID LOIPPJJCIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public readonly PHBEFCDKJPM FPCPBDDLABB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public readonly Func<string, bool> EPJGCCKNHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public readonly string PFEHABFHCMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public readonly Func<string, bool> DBJILOMIGMI;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x4034CA0", Offset = "0x40338A0", VA = "0x184034CA0")]
			public JGKJHJPMOLI(string HFHFHLFJIAC, string BBIHHPKACDJ, string LLGOHGAJDEN, OBJOBBMGDID LOKIDPODMOA, PHBEFCDKJPM FEAMCMAMIJF, Func<string, bool> KBAPADHBOOM, string DAMJIMGAPHF, Func<string, bool> HPDOBNIKBNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class BFKJMKCKPEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public CDGFKNABBGG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public KAPIFPFJPBM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BFKJMKCKPEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4E598F0", Offset = "0x4E584F0", VA = "0x184E598F0")]
			internal EOCKOMBAJGD FGDMNBNLAMN(IJEFBNHNJAA portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct PHIFFKCHDCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public CDGFKNABBGG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4702780", Offset = "0x4701380", VA = "0x184702780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct AOECCKAINEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public CDGFKNABBGG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public KGFCMJCHHEL? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public BAIJOIKGIKG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF470", Offset = "0x3DEE070", VA = "0x183DEF470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF710", Offset = "0x3DEE310", VA = "0x183DEF710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class AFPNGEBGDMB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public AFPNGEBGDMB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0x3537A10", Offset = "0x3536610", VA = "0x183537A10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public CDGFKNABBGG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public CPELIOLDBEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public AFPNGEBGDMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			internal string HGLPOMJIFEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
			internal void NKLLBLAPLIL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x3CD1F50", Offset = "0x3CD0B50", VA = "0x183CD1F50")]
			[AsyncStateMachine(typeof(CDGFKNABBGG<>.AFPNGEBGDMB.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void DCOJPDGNPEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class LCGJLAGHLKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public LCGJLAGHLKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x41EE990", Offset = "0x41ED590", VA = "0x1841EE990")]
			internal bool LMIMAOIKIHH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x41EE980", Offset = "0x41ED580", VA = "0x1841EE980")]
			internal bool JANMPAHHLAI(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct KDMBJDILDAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CDGFKNABBGG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4136E90", Offset = "0x4135A90", VA = "0x184136E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4137220", Offset = "0x4135E20", VA = "0x184137220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private readonly KAPIFPFJPBM JPLNHCACCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly bool LMJBNFOKLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private FOBGKDMAFIM<OMKPDHDDBAO, EOCKOMBAJGD> PKHGILLBNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private FOBGKDMAFIM<OMKPDHDDBAO, LJHKJJNGAGF> BCBMJIJIDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private List<Action> COHAGEAKNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[CompilerGenerated]
		private Action<DCECDLKENED<OMKPDHDDBAO>>? OPNMIHJGOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[CompilerGenerated]
		private Action<DCECDLKENED<OMKPDHDDBAO>, LJHKJJNGAGF>? EHJFKCMBBCH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected GFNIBIHMECA HMBCDGEIJFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x51A73B0", Offset = "0x51A5FB0", VA = "0x1851A73B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected TNode MAIIKAJJGDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public KPOKIIDKMFA<BNCFOBOFDGL> CMPIEDNOKLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xAF2670", Offset = "0xAF1270", VA = "0x180AF2670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KPOKIIDKMFA<BNCFOBOFDGL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DCECDLKENED<KEIDDNGIJFA> BHAPDHEAHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x51A90B0", Offset = "0x51A7CB0", VA = "0x1851A90B0", Slot = "6")]
			get
			{
				return default(DCECDLKENED<KEIDDNGIJFA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public object NPFANBOBOND
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x386BB30", Offset = "0x386A730", VA = "0x18386BB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool EOCOGKIPMNO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int IFLIDIAMOMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x51A8D10", Offset = "0x51A7910", VA = "0x1851A8D10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public CHKBIKGCDEG PKDJEPIJPGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x51A8CB0", Offset = "0x51A78B0", VA = "0x1851A8CB0", Slot = "10")]
			get
			{
				return default(CHKBIKGCDEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string JFEBEKEKLOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x51A9250", Offset = "0x51A7E50", VA = "0x1851A9250", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected virtual bool BOPBEGODDKP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DCECDLKENED<FKCIDBBNNON> IKAJDJABFGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x90B4D0", Offset = "0x90A0D0", VA = "0x18090B4D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(DCECDLKENED<FKCIDBBNNON>);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xAED320", Offset = "0xAEBF20", VA = "0x180AED320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool KCODEDAKGDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual bool INAJKNDPHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual POBMNIBDMOK DPFALEKIDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA73E70", Offset = "0xA72A70", VA = "0x180A73E70", Slot = "93")]
			get
			{
				return default(POBMNIBDMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool IPIJFDIIEAA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x51A8A80", Offset = "0x51A7680", VA = "0x1851A8A80", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool KLOIKDMNBAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x51A8AE0", Offset = "0x51A76E0", VA = "0x1851A8AE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool HIODMMBIAEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x51A8B40", Offset = "0x51A7740", VA = "0x1851A8B40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int MHOFMKOMAPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x51A9060", Offset = "0x51A7C60", VA = "0x1851A9060", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool KNFDGFNHOOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x51A8E90", Offset = "0x51A7A90", VA = "0x1851A8E90", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool ADMDEHPFPFG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x51A8BF0", Offset = "0x51A77F0", VA = "0x1851A8BF0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool GPPLLMPIDEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xC418F0", Offset = "0xC404F0", VA = "0x180C418F0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xC418E0", Offset = "0xC404E0", VA = "0x180C418E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool DMFMHGAJJLK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool FAOBJDEPJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x51A8BA0", Offset = "0x51A77A0", VA = "0x1851A8BA0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HAHFEEPGLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x51A8DC0", Offset = "0x51A79C0", VA = "0x1851A8DC0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public KGFCMJCHHEL OCLAILDFLFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x51A8FA0", Offset = "0x51A7BA0", VA = "0x1851A8FA0", Slot = "27")]
			get
			{
				return default(KGFCMJCHHEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public BAIJOIKGIKG OJMCLJJHOHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x51A9000", Offset = "0x51A7C00", VA = "0x1851A9000", Slot = "29")]
			get
			{
				return default(BAIJOIKGIKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool HHCFNPPCEHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual ABOAOIFCCNM? EPGACHBCDLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual BGEGDAIHAFI? GDBGPEFEGJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual IEnumerable<KPOKIIDKMFA<GIGLGMMBICO>>? AAFBEKHGMFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool GAAOJHBLIAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x51A8C50", Offset = "0x51A7850", VA = "0x1851A8C50", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public KPOKIIDKMFA<AJNNPPKMCNH> PKHMMJLCDNP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x51A8EE0", Offset = "0x51A7AE0", VA = "0x1851A8EE0", Slot = "61")]
			get
			{
				return default(KPOKIIDKMFA<AJNNPPKMCNH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public DCECDLKENED<AJNNPPKMCNH> GHAMJFHEBIG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x51A8D60", Offset = "0x51A7960", VA = "0x1851A8D60", Slot = "55")]
			get
			{
				return default(DCECDLKENED<AJNNPPKMCNH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool ONEJLBKGLCI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual DCECDLKENED<AJNNPPKMCNH>? LEBKOPCAFOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool IEJBIMPNOHC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool MHECFKOPHMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x51A8E20", Offset = "0x51A7A20", VA = "0x1851A8E20", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850100", VA = "0x180851500", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8500A0", VA = "0x1808514A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private string KFOFHEHBLDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x851580", Offset = "0x850180", VA = "0x180851580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public KPOKIIDKMFA<GIGLGMMBICO> AOIMFEDGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x51A8F40", Offset = "0x51A7B40", VA = "0x1851A8F40", Slot = "62")]
			get
			{
				return default(KPOKIIDKMFA<GIGLGMMBICO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public KPOKIIDKMFA<GIGLGMMBICO>? CMFMDFGKDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x51A9130", Offset = "0x51A7D30", VA = "0x1851A9130", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public OKMJBKIIOIE<OMKPDHDDBAO, LJHKJJNGAGF> HAEBHPNKLEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x51A9210", Offset = "0x51A7E10", VA = "0x1851A9210", Slot = "64")]
			get
			{
				return default(OKMJBKIIOIE<OMKPDHDDBAO, LJHKJJNGAGF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual DCECDLKENED<OMKPDHDDBAO>? KGMIFDIEFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual bool BDHFKCDDADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool IOCKEJFHOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EIKBCKNPNGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x51A5900", Offset = "0x51A4500", VA = "0x1851A5900", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x51A71E0", Offset = "0x51A5DE0", VA = "0x1851A71E0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HEAECJDGNHE FGIHKPPMKOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x51A38B0", Offset = "0x51A24B0", VA = "0x1851A38B0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x51A7F60", Offset = "0x51A6B60", VA = "0x1851A7F60", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DABHNEABKEC DKLGCIEBHMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x51A8330", Offset = "0x51A6F30", VA = "0x1851A8330", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x51A5A60", Offset = "0x51A4660", VA = "0x1851A5A60", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action PFLINLNAAJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x51A3A40", Offset = "0x51A2640", VA = "0x1851A3A40", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x51A5C70", Offset = "0x51A4870", VA = "0x1851A5C70", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KCEOBJAOGLB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x51A3D40", Offset = "0x51A2940", VA = "0x1851A3D40", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x51A83D0", Offset = "0x51A6FD0", VA = "0x1851A83D0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>, LJHKJJNGAGF> DAFLFIMPCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x51A48D0", Offset = "0x51A34D0", VA = "0x1851A48D0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x51A67B0", Offset = "0x51A53B0", VA = "0x1851A67B0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>, LJHKJJNGAGF> DDHPFBLEPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x51A7AD0", Offset = "0x51A66D0", VA = "0x1851A7AD0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x51A53F0", Offset = "0x51A3FF0", VA = "0x1851A53F0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>> IGIDPMCHEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x51A59A0", Offset = "0x51A45A0", VA = "0x1851A59A0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x51A5330", Offset = "0x51A3F30", VA = "0x1851A5330", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>, DCECDLKENED<OMKPDHDDBAO>> ADNDKLPLKNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x51A3B10", Offset = "0x51A2710", VA = "0x1851A3B10", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x51A7120", Offset = "0x51A5D20", VA = "0x1851A7120", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>, LJHKJJNGAGF> OICLHOIHCFP
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x51A3C40", Offset = "0x51A2840", VA = "0x1851A3C40", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x51A5200", Offset = "0x51A3E00", VA = "0x1851A5200", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<DCECDLKENED<OMKPDHDDBAO>, DCECDLKENED<OMKPDHDDBAO>> PLDGFFNBGBC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x51A7280", Offset = "0x51A5E80", VA = "0x1851A7280", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x51A66F0", Offset = "0x51A52F0", VA = "0x1851A66F0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x51A84B0", Offset = "0x51A70B0", VA = "0x1851A84B0")]
		[DKPEDCBOHDB("Need to handle `Name` better.")]
		[DKPEDCBOHDB("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected CDGFKNABBGG(KAPIFPFJPBM KCPELCALJIF, TNode LNFMEAPGAAK, bool PLLHAEBLAOD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x51A4990", Offset = "0x51A3590", VA = "0x1851A4990", Slot = "86")]
		protected virtual void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x51A3EB0", Offset = "0x51A2AB0", VA = "0x1851A3EB0", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x51A8000", Offset = "0x51A6C00", VA = "0x1851A8000", Slot = "9")]
		[AsyncStateMachine(typeof(CDGFKNABBGG<>.PHIFFKCHDCB))]
		public void OLJIPINLCLJ(int MIHPPKKJNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x51A5CD0", Offset = "0x51A48D0", VA = "0x1851A5CD0")]
		public bool KAODHAGFBKD([In] KGFCMJCHHEL GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x51A5600", Offset = "0x51A4200", VA = "0x1851A5600")]
		public bool GOEEBONCFBA([In] BAIJOIKGIKG GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x51A5670", Offset = "0x51A4270", VA = "0x1851A5670", Slot = "31")]
		public void IBEMFOFGLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x51A7940", Offset = "0x51A6540", VA = "0x1851A7940", Slot = "32")]
		[AsyncStateMachine(typeof(CDGFKNABBGG<>.AOECCKAINEH))]
		public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> NGNBFCKFJED(KGFCMJCHHEL? FKKCBKBCNEL, BAIJOIKGIKG? MFHPKPAOAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "96")]
		public virtual void EBKEMGNBKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "97")]
		public virtual void CJFADOJGIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "98")]
		public virtual void DHBALEJBIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F890", Offset = "0x1D0E490", VA = "0x181D0F890")]
		protected void GJIJBLGEAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x4966240", Offset = "0x4964E40", VA = "0x184966240")]
		protected void NBNGCLHHNFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x21600A0", Offset = "0x215ECA0", VA = "0x1821600A0")]
		private void CLGIOCLCLBP([In] BAIJOIKGIKG DELGPMLKBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x51A5D40", Offset = "0x51A4940", VA = "0x1851A5D40", Slot = "99")]
		public virtual Task<GFFELLBKJIA<DCECDLKENED<OMKPDHDDBAO>, DCMKOJFPDPC>> KDKGMBIHBFL(string GFLNGGKHEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x51A3DE0", Offset = "0x51A29E0", VA = "0x1851A3DE0", Slot = "100")]
		public virtual Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> DEEOGKAFKBI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "101")]
		public virtual void JJEEPDJNHLA(DCECDLKENED<OMKPDHDDBAO> ALNGMECGNOP, DCECDLKENED<OMKPDHDDBAO> BEDKFMEIFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x51A5870", Offset = "0x51A4470", VA = "0x1851A5870", Slot = "102")]
		public virtual IEnumerable<KPEIBDAFOMB> IDGCGGHJHNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x51A82A0", Offset = "0x51A6EA0", VA = "0x1851A82A0", Slot = "103")]
		public GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC> PDKOBNCAIAN(string FGGDGHCCIJF)
		{
			return default(GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x51A50B0", Offset = "0x51A3CB0", VA = "0x1851A50B0", Slot = "46")]
		public bool EJDAMAMHPOP([Out] Guid KELJNLNAABF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x51A7CB0", Offset = "0x51A68B0", VA = "0x1851A7CB0")]
		public bool OBJDEOLKNAD([In] Guid DJGLMBCCEPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "104")]
		public virtual void CJMFGDFICPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "105")]
		public virtual void NILGPDNGIIB(bool EGLLFPIHMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "106")]
		public virtual DMMODAEPMBB AHHBHFNALIO([In] EOHCKNPKNLJ PLOIAEJAFCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x51A80B0", Offset = "0x51A6CB0", VA = "0x1851A80B0")]
		protected void ONGPOHGKGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x51A5C30", Offset = "0x51A4830", VA = "0x1851A5C30", Slot = "111")]
		protected virtual bool JIMNAACOKJE(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "112")]
		protected virtual bool PIMJDCJNKOH(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected virtual void GGOAEJOLKEO(CPELIOLDBEG ALGHJALGNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x51A5E10", Offset = "0x51A4A10", VA = "0x1851A5E10")]
		protected void KFFNJAFECKF(CPELIOLDBEG HMJIIBGLMMB, Func<string> GJHAPFCCMBB, Action<string> HGHALDMJKMA, JGKJHJPMOLI LLJCEPGKLEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x51A6DB0", Offset = "0x51A59B0", VA = "0x1851A6DB0")]
		protected void LHKMNBMPBFD(CPELIOLDBEG HMJIIBGLMMB, Func<string> GJHAPFCCMBB, Action<string> HGHALDMJKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x51A4780", Offset = "0x51A3380", VA = "0x1851A4780", Slot = "120")]
		protected virtual void EEBFPPKGIJP(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x51A74A0", Offset = "0x51A60A0", VA = "0x1851A74A0", Slot = "79")]
		public void MMKOPNFHHEH(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x51A3950", Offset = "0x51A2550", VA = "0x1851A3950", Slot = "80")]
		public IBGMJDOMBAG AHKLBOGJCAC()
		{
			return default(IBGMJDOMBAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "123")]
		public virtual bool LODMGJMDJLI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x13CC820", Offset = "0x13CB420", VA = "0x1813CC820")]
		private void DIMKLNBPMNI([In] KGFCMJCHHEL DFPHDEDIHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x51A54B0", Offset = "0x51A40B0", VA = "0x1851A54B0")]
		private void GMGJOCBJCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x51A6870", Offset = "0x51A5470", VA = "0x1851A6870")]
		private void LADJEACAMII(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, IJEFBNHNJAA FFIFLNJALJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C880", Offset = "0x1E3B480", VA = "0x181E3C880")]
		private void NLJEAGCPOEK(DCECDLKENED<OMKPDHDDBAO> EPKGPGILADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x51A5B00", Offset = "0x51A4700", VA = "0x1851A5B00")]
		private void JIEKENKKCEI(DCECDLKENED<OMKPDHDDBAO> EPKGPGILADI, IJEFBNHNJAA KDPAJIFKJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x51A7590", Offset = "0x51A6190", VA = "0x1851A7590")]
		private void NEBHIGOJLNG(DCECDLKENED<OMKPDHDDBAO> ALNGMECGNOP, DCECDLKENED<OMKPDHDDBAO> BEDKFMEIFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C8A0", Offset = "0x1E3B4A0", VA = "0x181E3C8A0")]
		private void GBHDDPKCNFJ(DCECDLKENED<OMKPDHDDBAO> ALNGMECGNOP, DCECDLKENED<OMKPDHDDBAO> BEDKFMEIFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x4E99790", Offset = "0x4E98390", VA = "0x184E99790")]
		private void EDIJAIFIGJO(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x51A62E0", Offset = "0x51A4EE0", VA = "0x1851A62E0")]
		private void KFLJMIKECNI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, IJEFBNHNJAA FFIFLNJALJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x51A7340", Offset = "0x51A5F40", VA = "0x1851A7340")]
		private void MEIOEFHLHPL(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, IJEFBNHNJAA KDPAJIFKJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x51A7B90", Offset = "0x51A6790", VA = "0x1851A7B90", Slot = "124")]
		[AsyncStateMachine(typeof(CDGFKNABBGG<>.KDMBJDILDAL))]
		public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> OANCHOJCBGC(string FGGDGHCCIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x51A52C0", Offset = "0x51A3EC0", VA = "0x1851A52C0", Slot = "53")]
		private void FLPCLLMPHEP(object NHKFMJBFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x51A3BD0", Offset = "0x51A27D0", VA = "0x1851A3BD0", Slot = "54")]
		private void CJOIAHPAPAF(object NHKFMJBFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x51A4740", Offset = "0x51A3340", VA = "0x1851A4740", Slot = "28")]
		private bool EBCEHENAHDE([In] KGFCMJCHHEL GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x51A7A90", Offset = "0x51A6690", VA = "0x1851A7A90", Slot = "30")]
		private bool NIOOHPOCDEJ([In] BAIJOIKGIKG GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x51A3D00", Offset = "0x51A2900", VA = "0x1851A3D00", Slot = "47")]
		private bool CPPNAAMGKDD([In] Guid DJGLMBCCEPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x51A8470", Offset = "0x51A7070", VA = "0x1851A8470")]
		[CompilerGenerated]
		private string PPLPAPLELAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x51A74F0", Offset = "0x51A60F0", VA = "0x1851A74F0")]
		[CompilerGenerated]
		private void NDNNEDACAFF(string GFLNGGKHEOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class GEAJGHNILCD : GPIPAGDLMFJ<DFCLGFFLEIC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xC9A130", Offset = "0xC98D30", VA = "0x180C9A130", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1F69CD0", Offset = "0x1F688D0", VA = "0x181F69CD0")]
		public GEAJGHNILCD(KAPIFPFJPBM KCPELCALJIF, DFCLGFFLEIC LNFMEAPGAAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class KAJKNHLNDNP : IBBBHMPMONO<BJGGMDIBGPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6E6E0", Offset = "0x1F6D2E0", VA = "0x181F6E6E0")]
		public KAJKNHLNDNP(KAPIFPFJPBM KCPELCALJIF, BJGGMDIBGPF LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public abstract class ADHBAHEGKKB<T> : CDGFKNABBGG<T> where T : notnull, LPNAFAMOKME
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class JPNEODMAONA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public IReadOnlyList<KeyValuePair<string, EJFDDCNOMKE>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ADHBAHEGKKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public LIOCLGAMGCA clipType;

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public JPNEODMAONA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			internal IReadOnlyList<KeyValuePair<string, EJFDDCNOMKE>> ELJGOANJBDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x407AFC0", Offset = "0x4079BC0", VA = "0x18407AFC0")]
			internal int LJMKIEFGAHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x407B230", Offset = "0x4079E30", VA = "0x18407B230")]
			internal void PCLCNFNILHF(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x407AB70", Offset = "0x4079770", VA = "0x18407AB70")]
			internal void CNEHGMMCIDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x407AD60", Offset = "0x4079960", VA = "0x18407AD60")]
			internal void HDCKOKNLGCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x407ABC0", Offset = "0x40797C0", VA = "0x18407ABC0")]
			internal bool DBDPMHDNCNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x407B1E0", Offset = "0x4079DE0", VA = "0x18407B1E0")]
			internal void MBPKLLGJGAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x407ABC0", Offset = "0x40797C0", VA = "0x18407ABC0")]
			internal bool MAOHOEAKJAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x407AF70", Offset = "0x4079B70", VA = "0x18407AF70")]
			internal float IPLKOHEGHFL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x407B120", Offset = "0x4079D20", VA = "0x18407B120")]
			internal void MAEFKDHLLMA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x407AB20", Offset = "0x4079720", VA = "0x18407AB20")]
			internal float BLOMLHGBEJK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x407AEB0", Offset = "0x4079AB0", VA = "0x18407AEB0")]
			internal void IFMAFGEGMGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x407AD10", Offset = "0x4079910", VA = "0x18407AD10")]
			internal float DNLDNBPGAKI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x407AC50", Offset = "0x4079850", VA = "0x18407AC50")]
			internal void DCGEMJPLLHO(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDC0", Offset = "0x8AC9C0", VA = "0x1808ADDC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public abstract LIOCLGAMGCA FCDMEKHGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3CC38C0", Offset = "0x3CC24C0", VA = "0x183CC38C0")]
		public ADHBAHEGKKB(KAPIFPFJPBM KCPELCALJIF, T LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2DE0", Offset = "0x3CC19E0", VA = "0x183CC2DE0", Slot = "119")]
		protected sealed override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class BIAJENNGNIL : CDGFKNABBGG<NDOMPJJOOFI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x8F7950", Offset = "0x8F6550", VA = "0x1808F7950", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F2E0", Offset = "0x1F5DEE0", VA = "0x181F5F2E0")]
		public BIAJENNGNIL(KAPIFPFJPBM KCPELCALJIF, NDOMPJJOOFI LNFMEAPGAAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class AHIIOLEANCD : CDGFKNABBGG<GMFALACHPDH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class IPLJFLADEPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public AHIIOLEANCD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public IPLJFLADEPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x1F6AD30", Offset = "0x1F69930", VA = "0x181F6AD30")]
			internal int LJMKIEFGAHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x1F6AD80", Offset = "0x1F69980", VA = "0x181F6AD80")]
			internal void PCLCNFNILHF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static Dictionary<string, EJFDDCNOMKE>? JPDBMPOMCLM;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EA80", Offset = "0x1F5D680", VA = "0x181F5EA80")]
		public AHIIOLEANCD(KAPIFPFJPBM KCPELCALJIF, GMFALACHPDH LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1F5E700", Offset = "0x1F5D300", VA = "0x181F5E700", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class HCBEHGKFAKK : ADHBAHEGKKB<DPJPHKNIOAK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override LIOCLGAMGCA FCDMEKHGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "125")]
			get
			{
				return default(LIOCLGAMGCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AB60", Offset = "0x1F69760", VA = "0x181F6AB60")]
		public HCBEHGKFAKK(KAPIFPFJPBM KCPELCALJIF, DPJPHKNIOAK NHLLCDFJMEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class DJFBIKONOGA : IBBBHMPMONO<GGHICELDPMK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1F60B60", Offset = "0x1F5F760", VA = "0x181F60B60")]
		public DJFBIKONOGA(KAPIFPFJPBM KCPELCALJIF, GGHICELDPMK LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class HCIFABMOOKH : IBBBHMPMONO<EKNOAHAMBIA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1F6ABC0", Offset = "0x1F697C0", VA = "0x181F6ABC0")]
		public HCIFABMOOKH(KAPIFPFJPBM KCPELCALJIF, EKNOAHAMBIA LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class GFMPLHMHCAK : CEHEPJCCGAL<HFEJCCAJKHK>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class BDEJCGKPHPK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public BDEJCGKPHPK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600036A")]
				[Cpp2IlInjected.Address(RVA = "0x1F793B0", Offset = "0x1F77FB0", VA = "0x181F793B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public GFMPLHMHCAK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BDEJCGKPHPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EF60", Offset = "0x1F5DB60", VA = "0x181F5EF60")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void NAGIJHBIFBL(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A010", Offset = "0x1F68C10", VA = "0x181F6A010")]
		public GFMPLHMHCAK(KAPIFPFJPBM KCPELCALJIF, HFEJCCAJKHK NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1F69D30", Offset = "0x1F68930", VA = "0x181F69D30", Slot = "125")]
		protected override void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class APFONGBHIBJ : ADHBAHEGKKB<OJDDLFBFIOD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override LIOCLGAMGCA FCDMEKHGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC790", Offset = "0x8BB390", VA = "0x1808BC790", Slot = "125")]
			get
			{
				return default(LIOCLGAMGCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EC10", Offset = "0x1F5D810", VA = "0x181F5EC10")]
		public APFONGBHIBJ(KAPIFPFJPBM KCPELCALJIF, OJDDLFBFIOD NHLLCDFJMEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class JEFCJKPCOOK : CDGFKNABBGG<GKACKHAKMMH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9290", Offset = "0x8F7E90", VA = "0x1808F9290", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BB90", Offset = "0x1F6A790", VA = "0x181F6BB90")]
		public JEFCJKPCOOK(KAPIFPFJPBM KCPELCALJIF, GKACKHAKMMH LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class FLFELPEHEKO : CDGFKNABBGG<EPAPLAMPPDD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public sealed override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public sealed override bool KCODEDAKGDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected sealed override bool BOPBEGODDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1F69C60", Offset = "0x1F68860", VA = "0x181F69C60")]
		public FLFELPEHEKO(KAPIFPFJPBM KCPELCALJIF, EPAPLAMPPDD LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1F698D0", Offset = "0x1F684D0", VA = "0x181F698D0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1F69890", Offset = "0x1F68490", VA = "0x181F69890")]
		private int EGNMLKCHMBC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1F69C00", Offset = "0x1F68800", VA = "0x181F69C00")]
		private void KCJDEJDDLLP(int APNFGFBFBNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class NANHDJLECML : DKEDJBIIGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1F60BC0", Offset = "0x1F5F7C0", VA = "0x181F60BC0")]
		public NANHDJLECML(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class MILEIFAFHHK : CEHEPJCCGAL<BLKHBJKMMLL>
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FDD0", Offset = "0x1F6E9D0", VA = "0x181F6FDD0")]
		public MILEIFAFHHK(KAPIFPFJPBM KCPELCALJIF, BLKHBJKMMLL LNFMEAPGAAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class CEHEPJCCGAL<TVariableNode> : CDGFKNABBGG<TVariableNode> where TVariableNode : notnull, BLKHBJKMMLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class DEHCKOACODI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CEHEPJCCGAL<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DEHCKOACODI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x57CCB70", Offset = "0x57CB770", VA = "0x1857CCB70")]
			internal bool ELJGOANJBDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x57CCC80", Offset = "0x57CB880", VA = "0x1857CCC80")]
			internal void LJMKIEFGAHD(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x57CCD40", Offset = "0x57CB940", VA = "0x1857CCD40")]
			internal bool PCLCNFNILHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x57CCAB0", Offset = "0x57CB6B0", VA = "0x1857CCAB0")]
			internal void CNEHGMMCIDE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x57CCBD0", Offset = "0x57CB7D0", VA = "0x1857CCBD0")]
			internal bool HDCKOKNLGCL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class GCPLADFAEFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public GFNIBIHMECA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CEHEPJCCGAL<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public GCPLADFAEFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x3C72BE0", Offset = "0x3C717E0", VA = "0x183C72BE0")]
			internal void NAGIJHBIFBL(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA76C20", Offset = "0xA75820", VA = "0x180A76C20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override POBMNIBDMOK DPFALEKIDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x51AA910", Offset = "0x51A9510", VA = "0x1851AA910", Slot = "93")]
			get
			{
				return default(POBMNIBDMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x51AA770", Offset = "0x51A9370", VA = "0x1851AA770")]
		protected CEHEPJCCGAL(KAPIFPFJPBM KCPELCALJIF, TVariableNode LNFMEAPGAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x51A9DD0", Offset = "0x51A89D0", VA = "0x1851A9DD0", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x51A9F50", Offset = "0x51A8B50", VA = "0x1851A9F50", Slot = "119")]
		protected override void GGOAEJOLKEO(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x51AA3E0", Offset = "0x51A8FE0", VA = "0x1851AA3E0", Slot = "125")]
		protected virtual void JMOBNLDGADD(CPELIOLDBEG HMJIIBGLMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x51A9CE0", Offset = "0x51A88E0", VA = "0x1851A9CE0", Slot = "104")]
		public override void CJMFGDFICPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B1D0", Offset = "0x1F49DD0", VA = "0x181F4B1D0")]
	public static OBMNEEPHOCK PPOPBMPFEOP(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class PAEDGDJNGNC : MJNFEBBIGCG, KBDPMDHGBMD, GODPPCJFBIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DCECDLKENED<PNPFCEGBCNJ> BGECOPJAAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xEF4D20", Offset = "0xEF3920", VA = "0x180EF4D20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(DCECDLKENED<PNPFCEGBCNJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DCECDLKENED<ODOMFDGLFOL> DNCCIEBPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x11DFD30", Offset = "0x11DE930", VA = "0x1811DFD30", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DCECDLKENED<ODOMFDGLFOL>);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1F77990", Offset = "0x1F76590", VA = "0x181F77990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private DCECDLKENED<KKIKNFODNKB> HBNFKEKIFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xBAA2D0", Offset = "0xBA8ED0", VA = "0x180BAA2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public override DCECDLKENED<CJEJKMAMNCJ> EPHEFCNNALL
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1F77940", Offset = "0x1F76540", VA = "0x181F77940", Slot = "20")]
		get
		{
			return default(DCECDLKENED<CJEJKMAMNCJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x1F77CF0", Offset = "0x1F768F0", VA = "0x181F77CF0")]
	private PAEDGDJNGNC(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK, OOGGMIHNNEJ PIDKGHHCKJM, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<ODOMFDGLFOL> LKMOAAHJAKF, DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK, bool ONENGBHGLAP, string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1F779A0", Offset = "0x1F765A0", VA = "0x181F779A0")]
	public static PAEDGDJNGNC PPOPBMPFEOP(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK, OOGGMIHNNEJ JDJMAGMGKBH, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK, DCECDLKENED<ODOMFDGLFOL> LKMOAAHJAKF, bool ONENGBHGLAP, bool PLLHAEBLAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1F77990", Offset = "0x1F76590", VA = "0x181F77990")]
	internal void EGLBAGMJJKJ(DCECDLKENED<ODOMFDGLFOL> GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public abstract class MJNFEBBIGCG : GODPPCJFBIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct EADHGDIIDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private DLBPGCNKOEL? FHFIHKCLOBL;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1F61980", Offset = "0x1F60580", VA = "0x181F61980")]
		public void ONDHHAABKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1F618E0", Offset = "0x1F604E0", VA = "0x181F618E0")]
		public DLBPGCNKOEL NLOCHDBNKCN(MJNFEBBIGCG OHDPKFLPGFG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	protected readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	protected readonly JJIKDDBCBGL JDAFBKEAMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private EADHGDIIDBE BOBFHJDKICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly OLDENCCJDPA FGAEDBCHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly List<KNGKLCKJAMJ> FDLGJNJJELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly List<KBMAMDOFJEH> KNIFFEDOPNP;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	[DKPEDCBOHDB("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> CJOIACMDDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1F70100", Offset = "0x1F6ED00", VA = "0x181F70100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public DisplayKind ONOLNPFKHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x853470", Offset = "0x852070", VA = "0x180853470", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DCECDLKENED<AJNNPPKMCNH> GHAMJFHEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1F707A0", Offset = "0x1F6F3A0", VA = "0x181F707A0", Slot = "6")]
		get
		{
			return default(DCECDLKENED<AJNNPPKMCNH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KPOKIIDKMFA<AJNNPPKMCNH> PKHMMJLCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1F70EB0", Offset = "0x1F6FAB0", VA = "0x181F70EB0", Slot = "7")]
		get
		{
			return default(KPOKIIDKMFA<AJNNPPKMCNH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AKAJDHLNMMA CBNCNJLEJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1BA8A10", Offset = "0x1BA7610", VA = "0x181BA8A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EGHKLHHFFHO JCCLAJIHEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FEB0", Offset = "0x1F6EAB0", VA = "0x181F6FEB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	protected DLBPGCNKOEL NAPJPEFJCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FEB0", Offset = "0x1F6EAB0", VA = "0x181F6FEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public PortImage FEDHJOMPLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1F70EE0", Offset = "0x1F6FAE0", VA = "0x181F70EE0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x843390", Offset = "0x841F90", VA = "0x180843390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KPOKIIDKMFA<GIGLGMMBICO> AOIMFEDGIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FE90", Offset = "0x1F6EA90", VA = "0x181F6FE90", Slot = "9")]
		get
		{
			return default(KPOKIIDKMFA<GIGLGMMBICO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DCECDLKENED<OMKPDHDDBAO> FMHMJGIKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9956E0", Offset = "0x9942E0", VA = "0x1809956E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(DCECDLKENED<OMKPDHDDBAO>);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE7D150", Offset = "0xE7BD50", VA = "0x180E7D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract DCECDLKENED<CJEJKMAMNCJ> EPHEFCNNALL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F711E0", Offset = "0x1F6FDE0", VA = "0x181F711E0")]
	protected MJNFEBBIGCG(KAPIFPFJPBM KCPELCALJIF, JJIKDDBCBGL LNFMEAPGAAK, OLDENCCJDPA GBDBCEHCEOE, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, bool ONENGBHGLAP, string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F70250", Offset = "0x1F6EE50", VA = "0x181F70250", Slot = "21")]
	protected virtual void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FF50", Offset = "0x1F6EB50", VA = "0x181F6FF50", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F700A0", Offset = "0x1F6ECA0", VA = "0x181F700A0", Slot = "14")]
	public void EEKDMOEIDHG(KNGKLCKJAMJ COPPJILPFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F70E50", Offset = "0x1F6FA50", VA = "0x181F70E50", Slot = "15")]
	public void KMCLJKNMMIF(KBMAMDOFJEH COPPJILPFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F707D0", Offset = "0x1F6F3D0", VA = "0x181F707D0", Slot = "16")]
	public void JEAFKIALKKP(CPIDHOALHHJ JKEEDJALKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FE30", Offset = "0x1F6EA30", VA = "0x181F6FE30", Slot = "23")]
	protected virtual void ADCKKPKKDDN(CPIDHOALHHJ JKEEDJALKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F703A0", Offset = "0x1F6EFA0", VA = "0x181F703A0")]
	private void ELELGBCLHJH(bool KGECOLOELOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F70590", Offset = "0x1F6F190", VA = "0x181F70590")]
	private void GIEOHDDLKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F71010", Offset = "0x1F6FC10", VA = "0x181F71010")]
	private void NFCBGBLDJHJ([In] MPKMGJPIMDA JKACJFAMHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F70530", Offset = "0x1F6F130", VA = "0x181F70530", Slot = "17")]
	public void FHOKKCJPOMN(KNGKLCKJAMJ COPPJILPFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F70740", Offset = "0x1F6F340", VA = "0x181F70740", Slot = "18")]
	public void HKKCJELAECK(KBMAMDOFJEH COPPJILPFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x843390", Offset = "0x841F90", VA = "0x180843390")]
	internal void FMGDEHCLGHC(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F711C0", Offset = "0x1F6FDC0", VA = "0x181F711C0")]
	internal void ONOMKIMLPOF(HKPHHDIOMKG CFCALMONEJL, AKAJDHLNMMA NCNNODEFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xE7D150", Offset = "0xE7BD50", VA = "0x180E7D150")]
	internal void NHINFGBOEIN(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class EOCKOMBAJGD : LJHKJJNGAGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DHAIGFNJBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public KAPIFPFJPBM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public JJIKDDBCBGL node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public DCECDLKENED<OMKPDHDDBAO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DHAIGFNJBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F60A40", Offset = "0x1F5F640", VA = "0x181F60A40")]
		internal EKEJPGAJHNH AAMBMOMKMJJ((int PortDescIndex, int PortIndex, GFJLNNHFMCB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F60AD0", Offset = "0x1F5F6D0", VA = "0x181F60AD0")]
		internal PAEDGDJNGNC ONEKJIONKON(OOGGMIHNNEJ i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct OEAPOIAAKPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1F76970", Offset = "0x1F75570", VA = "0x181F76970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1F76DD0", Offset = "0x1F759D0", VA = "0x181F76DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct PJPFMDKJBEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public DCECDLKENED<OAAFJJJLHDG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1F78FF0", Offset = "0x1F77BF0", VA = "0x181F78FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1F79340", Offset = "0x1F77F40", VA = "0x181F79340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct CKFEPFFBOIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public DCECDLKENED<KKIKNFODNKB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FC20", Offset = "0x1F5E820", VA = "0x181F5FC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FF70", Offset = "0x1F5EB70", VA = "0x181F5FF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct OIFLFKPJMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public DCECDLKENED<OAAFJJJLHDG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public DCECDLKENED<OAAFJJJLHDG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1F77510", Offset = "0x1F76110", VA = "0x181F77510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1F77860", Offset = "0x1F76460", VA = "0x181F77860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct OEKLKBJOFOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public DCECDLKENED<KKIKNFODNKB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public DCECDLKENED<KKIKNFODNKB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1F76E40", Offset = "0x1F75A40", VA = "0x181F76E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1F77190", Offset = "0x1F75D90", VA = "0x181F77190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct FCHBEHOILHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1F68C00", Offset = "0x1F67800", VA = "0x181F68C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1F69070", Offset = "0x1F67C70", VA = "0x181F69070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct MHKNJHIDJFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FA10", Offset = "0x1F6E610", VA = "0x181F6FA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FD60", Offset = "0x1F6E960", VA = "0x181F6FD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct PBHONDOECOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public DCECDLKENED<OAAFJJJLHDG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1F77F80", Offset = "0x1F76B80", VA = "0x181F77F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1F782D0", Offset = "0x1F76ED0", VA = "0x181F782D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct LBHEEBFGFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public DCECDLKENED<KKIKNFODNKB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBA0", Offset = "0x1F6D7A0", VA = "0x181F6EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EEF0", Offset = "0x1F6DAF0", VA = "0x181F6EEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct DAFHMAKLGGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public KEODHPBNKAD type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public DCECDLKENED<OAAFJJJLHDG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FFE0", Offset = "0x1F5EBE0", VA = "0x181F5FFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1F60370", Offset = "0x1F5EF70", VA = "0x181F60370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct MCIOGCKAEEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EOCKOMBAJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public KEODHPBNKAD type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public DCECDLKENED<KKIKNFODNKB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private JGJANGBPMAM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F610", Offset = "0x1F6E210", VA = "0x181F6F610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F9A0", Offset = "0x1F6E5A0", VA = "0x181F6F9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly bool HMLCJBDCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool AHNCEHDDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private OKMJBKIIOIE<NMGIOEAJCBI, EKEJPGAJHNH> KAPDPDDAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private OKMJBKIIOIE<NMGIOEAJCBI, PIDHPFCANLD> NDKGCKECALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly JJIKDDBCBGL JDAFBKEAMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private OKMJBKIIOIE<ODOMFDGLFOL, PAEDGDJNGNC> PLKBIEBEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private OKMJBKIIOIE<ODOMFDGLFOL, KBDPMDHGBMD> LCGBKGNAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private string? MNLPGPEFACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly IJEFBNHNJAA OHJDHNKJPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private DCECDLKENED<OMKPDHDDBAO> JBKDAIHCCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly bool LMJBNFOKLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[CompilerGenerated]
	private Action? AIKANCEHNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[CompilerGenerated]
	private Action? KOHODIMOHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[CompilerGenerated]
	private Action<DCECDLKENED<NMGIOEAJCBI>>? ADBNOMKIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[CompilerGenerated]
	private Action<DCECDLKENED<ODOMFDGLFOL>>? MLAFEDFIBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[CompilerGenerated]
	private LJHKJJNGAGF.GFPOJMKHGMB? LODOIPEPEEE;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool FPKNMANCBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F62420", Offset = "0x1F61020", VA = "0x181F62420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CMJEFLHKGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F64660", Offset = "0x1F63260", VA = "0x181F64660", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool FBBKODDEGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1F65590", Offset = "0x1F64190", VA = "0x181F65590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public KPOKIIDKMFA<AJNNPPKMCNH> PKHMMJLCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F658C0", Offset = "0x1F644C0", VA = "0x181F658C0", Slot = "7")]
		get
		{
			return default(KPOKIIDKMFA<AJNNPPKMCNH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PBDIMPLLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F65740", Offset = "0x1F64340", VA = "0x181F65740", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public OKMJBKIIOIE<NMGIOEAJCBI, PIDHPFCANLD> DBEJIPPFMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "9")]
		get
		{
			return default(OKMJBKIIOIE<NMGIOEAJCBI, PIDHPFCANLD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F65D40", Offset = "0x1F64940", VA = "0x181F65D40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public KPOKIIDKMFA<GIGLGMMBICO> AOIMFEDGIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F62EB0", Offset = "0x1F61AB0", VA = "0x181F62EB0", Slot = "11")]
		get
		{
			return default(KPOKIIDKMFA<GIGLGMMBICO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public OKMJBKIIOIE<ODOMFDGLFOL, KBDPMDHGBMD> GHNJLCOCEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "12")]
		get
		{
			return default(OKMJBKIIOIE<ODOMFDGLFOL, KBDPMDHGBMD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DCECDLKENED<OMKPDHDDBAO> FMHMJGIKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xBAAFF0", Offset = "0xBA9BF0", VA = "0x180BAAFF0", Slot = "13")]
		get
		{
			return default(DCECDLKENED<OMKPDHDDBAO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action HACBOFMHJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F62EF0", Offset = "0x1F61AF0", VA = "0x181F62EF0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F657C0", Offset = "0x1F643C0", VA = "0x181F657C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action HGOKPHPOHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F678B0", Offset = "0x1F664B0", VA = "0x181F678B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1F67740", Offset = "0x1F66340", VA = "0x181F67740", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<DCECDLKENED<NMGIOEAJCBI>, DCECDLKENED<NMGIOEAJCBI>> GPIMFMBKBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F66380", Offset = "0x1F64F80", VA = "0x181F66380", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F67680", Offset = "0x1F66280", VA = "0x181F67680", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<DCECDLKENED<NMGIOEAJCBI>, DCECDLKENED<NMGIOEAJCBI>> ALKPKHCMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F66E30", Offset = "0x1F65A30", VA = "0x181F66E30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F64C10", Offset = "0x1F63810", VA = "0x181F64C10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<DCECDLKENED<ODOMFDGLFOL>, DCECDLKENED<ODOMFDGLFOL>> KHIJGCIIJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F64B30", Offset = "0x1F63730", VA = "0x181F64B30", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F66FB0", Offset = "0x1F65BB0", VA = "0x181F66FB0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<DCECDLKENED<ODOMFDGLFOL>, DCECDLKENED<ODOMFDGLFOL>> OJPLOFGAFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1F67130", Offset = "0x1F65D30", VA = "0x181F67130", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F64F80", Offset = "0x1F63B80", VA = "0x181F64F80", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DCECDLKENED<NMGIOEAJCBI>, PIDHPFCANLD> DHCJLGKOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F62DF0", Offset = "0x1F619F0", VA = "0x181F62DF0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F626C0", Offset = "0x1F612C0", VA = "0x181F626C0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DCECDLKENED<NMGIOEAJCBI>> PKPGKCIKOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F65040", Offset = "0x1F63C40", VA = "0x181F65040", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F64EC0", Offset = "0x1F63AC0", VA = "0x181F64EC0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DCECDLKENED<NMGIOEAJCBI>, PIDHPFCANLD> EHCHDOBJPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1F67070", Offset = "0x1F65C70", VA = "0x181F67070", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F66EF0", Offset = "0x1F65AF0", VA = "0x181F66EF0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<DCECDLKENED<ODOMFDGLFOL>, KBDPMDHGBMD> INJCOJAAMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F677F0", Offset = "0x1F663F0", VA = "0x181F677F0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1F624E0", Offset = "0x1F610E0", VA = "0x181F624E0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<DCECDLKENED<ODOMFDGLFOL>> MGEDDOHLAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F64E00", Offset = "0x1F63A00", VA = "0x181F64E00", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F64370", Offset = "0x1F62F70", VA = "0x181F64370", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<DCECDLKENED<ODOMFDGLFOL>, KBDPMDHGBMD> JMLENBPGCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F64A70", Offset = "0x1F63670", VA = "0x181F64A70", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F62000", Offset = "0x1F60C00", VA = "0x181F62000", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F67ED0", Offset = "0x1F66AD0", VA = "0x181F67ED0")]
	private EOCKOMBAJGD(bool ONENGBHGLAP, KAPIFPFJPBM KCPELCALJIF, bool LEGFCIIFJFC, OKMJBKIIOIE<NMGIOEAJCBI, EKEJPGAJHNH> GLDEEBPEGBP, OKMJBKIIOIE<NMGIOEAJCBI, PIDHPFCANLD> OJIJFHAJDPB, JJIKDDBCBGL LNFMEAPGAAK, OKMJBKIIOIE<ODOMFDGLFOL, PAEDGDJNGNC> NNNNICCNMLA, OKMJBKIIOIE<ODOMFDGLFOL, KBDPMDHGBMD> AHHCABPNCOE, string? MOHHEDEFFMB, IJEFBNHNJAA FFIFLNJALJJ, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, bool PLLHAEBLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F67960", Offset = "0x1F66560", VA = "0x181F67960")]
	public static EOCKOMBAJGD PPOPBMPFEOP(bool ONENGBHGLAP, KAPIFPFJPBM KCPELCALJIF, bool LEGFCIIFJFC, JJIKDDBCBGL LNFMEAPGAAK, IJEFBNHNJAA FFIFLNJALJJ, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, bool PLLHAEBLAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F63BC0", Offset = "0x1F627C0", VA = "0x181F63BC0")]
	private void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F62F90", Offset = "0x1F61B90", VA = "0x181F62F90", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F646A0", Offset = "0x1F632A0", VA = "0x181F646A0", Slot = "38")]
	[AsyncStateMachine(typeof(OEAPOIAAKPM))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> GPBJODLPGII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F620C0", Offset = "0x1F60CC0", VA = "0x181F620C0")]
	private (CMBDNEELCHH, int)? AENGIMJGFMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F66980", Offset = "0x1F65580", VA = "0x181F66980")]
	private void NGHDCJMIFEP(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x13E5B40", Offset = "0x13E4740", VA = "0x1813E5B40")]
	private void APNHEDFFOLO(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F672E0", Offset = "0x1F65EE0", VA = "0x181F672E0")]
	private void OCGKMNEGJPM(int LBHGJMBGPFA, int KMCLIOBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F64790", Offset = "0x1F63390", VA = "0x181F64790")]
	private void HCOGDNJICOC(int LBHGJMBGPFA, int KMCLIOBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F627A0", Offset = "0x1F613A0", VA = "0x181F627A0")]
	private void CICMHDIAKMG(int OBICKJEIEFD, DCECDLKENED<NMGIOEAJCBI> DJPILIKDMHA, GFJLNNHFMCB GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F62ED0", Offset = "0x1F61AD0", VA = "0x181F62ED0")]
	private void DJBAPPCLCLM(int KGECOLOELOJ, DCECDLKENED<NMGIOEAJCBI> DJPILIKDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F62780", Offset = "0x1F61380", VA = "0x181F62780")]
	private void CEBDLKMCLCO(int KGECOLOELOJ, DCECDLKENED<NMGIOEAJCBI> DJPILIKDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F658F0", Offset = "0x1F644F0", VA = "0x181F658F0")]
	private void LFHICGFNPMI(int OBICKJEIEFD, DCECDLKENED<NMGIOEAJCBI> DJPILIKDMHA, GFJLNNHFMCB GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F66230", Offset = "0x1F64E30", VA = "0x181F66230")]
	private void MHDILPNNMNO(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xAABC00", Offset = "0xAAA800", VA = "0x180AABC00")]
	private void BBKLHBLHLPD(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F671F0", Offset = "0x1F65DF0", VA = "0x181F671F0")]
	private void OCGEKKPOANK(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x13E5B40", Offset = "0x13E4740", VA = "0x1813E5B40")]
	private void KCIMIKCADIC(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F65D70", Offset = "0x1F64970", VA = "0x181F65D70")]
	private void LMHEDJOENKN(int LBHGJMBGPFA, int KMCLIOBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F65860", Offset = "0x1F64460", VA = "0x181F65860")]
	private void LAFIAGNDFKG(int LBHGJMBGPFA, int KMCLIOBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F66440", Offset = "0x1F65040", VA = "0x181F66440")]
	private void NCLNNIIJCLG(int OBICKJEIEFD, DCECDLKENED<ODOMFDGLFOL> DJPILIKDMHA, OOGGMIHNNEJ GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F65570", Offset = "0x1F64170", VA = "0x181F65570")]
	private void JFDDKMCFGAI(int KGECOLOELOJ, DCECDLKENED<ODOMFDGLFOL> DJPILIKDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F64BF0", Offset = "0x1F637F0", VA = "0x181F64BF0")]
	private void IDMFMLPJPJC(int KGECOLOELOJ, DCECDLKENED<ODOMFDGLFOL> DJPILIKDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F65100", Offset = "0x1F63D00", VA = "0x181F65100")]
	private void JENJINAGPMP(int OBICKJEIEFD, DCECDLKENED<ODOMFDGLFOL> DJPILIKDMHA, OOGGMIHNNEJ GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F647F0", Offset = "0x1F633F0", VA = "0x181F647F0")]
	private void HEJPCELDFLM(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xAABC00", Offset = "0xAAA800", VA = "0x180AABC00")]
	private void MKLMBPLDDEN(int OBICKJEIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F62CE0", Offset = "0x1F618E0", VA = "0x181F62CE0", Slot = "39")]
	[AsyncStateMachine(typeof(PJPFMDKJBEB))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> CJMIMLNKEBA(DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F64430", Offset = "0x1F63030", VA = "0x181F64430", Slot = "40")]
	[AsyncStateMachine(typeof(CKFEPFFBOIM))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> GFAHIKHJMNM(DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F66110", Offset = "0x1F64D10", VA = "0x181F66110", Slot = "41")]
	[AsyncStateMachine(typeof(OIFLFKPJMHO))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> MBCKOAJFCCM(DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK, DCECDLKENED<OAAFJJJLHDG> LGMHJMAJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F64540", Offset = "0x1F63140", VA = "0x181F64540", Slot = "42")]
	[AsyncStateMachine(typeof(OEKLKBJOFOE))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> GOHFNENEGBA(DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK, DCECDLKENED<KKIKNFODNKB> LGMHJMAJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F65650", Offset = "0x1F64250", VA = "0x181F65650", Slot = "43")]
	[AsyncStateMachine(typeof(FCHBEHOILHH))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> KAJCPECCMFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F625A0", Offset = "0x1F611A0", VA = "0x181F625A0", Slot = "44")]
	[AsyncStateMachine(typeof(MHKNJHIDJFM))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> BGFPNDFNPPL(string FGGDGHCCIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F622F0", Offset = "0x1F60EF0", VA = "0x181F622F0", Slot = "45")]
	[AsyncStateMachine(typeof(PBHONDOECOI))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> AHJFOJCJHMH(DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK, string GFLNGGKHEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F64CD0", Offset = "0x1F638D0", VA = "0x181F64CD0", Slot = "46")]
	[AsyncStateMachine(typeof(LBHEEBFGFPF))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> IMCHJACLDJI(DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK, string GFLNGGKHEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F63A90", Offset = "0x1F62690", VA = "0x181F63A90", Slot = "47")]
	[AsyncStateMachine(typeof(DAFHMAKLGGE))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> EDHBJOLPHAC(DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK, KEODHPBNKAD NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F64940", Offset = "0x1F63540", VA = "0x181F64940", Slot = "48")]
	[AsyncStateMachine(typeof(MCIOGCKAEEA))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> HPELMEINHLF(DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK, KEODHPBNKAD NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F66A70", Offset = "0x1F65670", VA = "0x181F66A70")]
	internal void NHINFGBOEIN(DCECDLKENED<OMKPDHDDBAO> GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public sealed class MBONHOHFBJI : CLLMLCCFDAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public interface IPAMALPCJPL
	{
		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		HKPHHDIOMKG JJLFBNPFGDH
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GKKNBFGCPLF> OPDBLCFCFMA(CancellationToken MPLCHGMFENA);

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GLNEPJPIIDC> BGALODBHFOM(CancellationToken MPLCHGMFENA);

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JPNINDOKGHL> KLMCLBCLCMN(CancellationToken MPLCHGMFENA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct DLFAHBGLHEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder<MBONHOHFBJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public KAPIFPFJPBM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public GKKNBFGCPLF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GLNEPJPIIDC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private IPAMALPCJPL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private GLNEPJPIIDC <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<GKKNBFGCPLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter<GLNEPJPIIDC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<JPNINDOKGHL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<FHKIIPNOMGA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F60C30", Offset = "0x1F5F830", VA = "0x181F60C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1F61640", Offset = "0x1F60240", VA = "0x181F61640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly FHKIIPNOMGA JFCLDBEGPKH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FHKIIPNOMGA DLCLFHDMLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	private MBONHOHFBJI(FHKIIPNOMGA LLLECNECLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F490", Offset = "0x1F6E090", VA = "0x181F6F490")]
	[AsyncStateMachine(typeof(DLFAHBGLHEP))]
	public static Task<MBONHOHFBJI> CIMEFJNJMHI(KAPIFPFJPBM KCPELCALJIF, GKKNBFGCPLF? AFAEGADIMPI, GLNEPJPIIDC? MAOEPJEIFFB, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F5F0", Offset = "0x1F6E1F0", VA = "0x181F6F5F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public readonly struct FJHKCGLMIFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct NGIOOAIIAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public FJHKCGLMIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public KPEIBDAFOMB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1F762C0", Offset = "0x1F74EC0", VA = "0x181F762C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1F76550", Offset = "0x1F75150", VA = "0x181F76550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct JHHMNIHAPKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<bool, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JIPCGMFMDIK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public GKKNBFGCPLF circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public GLNEPJPIIDC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public FJHKCGLMIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private KPEIBDAFOMB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BC00", Offset = "0x1F6A800", VA = "0x181F6BC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BFE0", Offset = "0x1F6ABE0", VA = "0x181F6BFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct BGIALBKPNPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public FJHKCGLMIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F030", Offset = "0x1F5DC30", VA = "0x181F5F030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F270", Offset = "0x1F5DE70", VA = "0x181F5F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly AINBMLCMMJM LMNLEMDOACK;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	public FJHKCGLMIFM(AINBMLCMMJM DCGGBFLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x1F69640", Offset = "0x1F68240", VA = "0x181F69640")]
	[AsyncStateMachine(typeof(NGIOOAIIAKD))]
	private Task<GFFELLBKJIA<object, DCMKOJFPDPC>> OGMGOFGAPMN(KPEIBDAFOMB FIPNCHEIGMJ, bool ADIMHKJHMBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1F694E0", Offset = "0x1F680E0", VA = "0x181F694E0")]
	[AsyncStateMachine(typeof(JHHMNIHAPKC))]
	public Task<GFFELLBKJIA<bool, DCMKOJFPDPC?>>? JLPGPHICCMK(int HBFPDCKDOJA, JIPCGMFMDIK? MBOIBNMPCFB, GKKNBFGCPLF? PCFLOJOLNII, GLNEPJPIIDC? MAOEPJEIFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1F693F0", Offset = "0x1F67FF0", VA = "0x181F693F0")]
	[AsyncStateMachine(typeof(BGIALBKPNPL))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> IICIADDLCDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public sealed class GOLBJIPIOCB : GDIGJKFJKLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private readonly FEBEFLIGOJE CHKCHAPHFJN;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public FEBEFLIGOJE BBLEHBCEEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	private GOLBJIPIOCB(FEBEFLIGOJE NFDDBOFHHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A540", Offset = "0x1F69140", VA = "0x181F6A540")]
	public static GOLBJIPIOCB EGCBEAACMHC(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A520", Offset = "0x1F69120", VA = "0x181F6A520", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface IHBEIFDIAIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	AFAONHFGOBC FJKPHHCFIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	MCDENGCHJHL NKICEBBFKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	JFKIIBAPKFC NDMEPDNMEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	LFPKKLNLEPJ AEINEPGMJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	MLDLBHNIBED NCJJKOEANGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface JBJHBFJEELL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	IHBEIFDIAIE? FLDIKEPJLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool GOGCPBGMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<IHBEIFDIAIE?>? PGEKGLELCAH();

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BEEFIPAMNKI(KAPIFPFJPBM KCPELCALJIF, JIPCGMFMDIK OMDGKDEIMMI, GKKNBFGCPLF? LCDFFOJABOK, GLNEPJPIIDC? LMNFKCLNCDK);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[FLLIIGCGAJP("IStaticCV2Instance")]
public interface CLLMLCCFDAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	FHKIIPNOMGA DLCLFHDMLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FLLIIGCGAJP("IStaticEVInstance")]
public interface GDIGJKFJKLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	FEBEFLIGOJE BBLEHBCEEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class LIAHPIOCGBP : AAJKJKLDMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GBNBAIFNKLM? GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F390", Offset = "0x1F6DF90", VA = "0x181F6F390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	internal LIAHPIOCGBP(KAPIFPFJPBM KCPELCALJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class LFPKKLNLEPJ : GBNBAIFNKLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly CLLMLCCFDAI HHABAPLNGJN;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IDEKMENCBHG OGMGOFGAPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F330", Offset = "0x1F6DF30", VA = "0x181F6F330", Slot = "4")]
		get
		{
			return default(IDEKMENCBHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NHKLILKBPHL BNGBBHDMOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F260", Offset = "0x1F6DE60", VA = "0x181F6F260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KPOKIIDKMFA<AJNNPPKMCNH> NIBHNHFOEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F1B0", Offset = "0x1F6DDB0", VA = "0x181F6F1B0", Slot = "6")]
		get
		{
			return default(KPOKIIDKMFA<AJNNPPKMCNH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FHKIIPNOMGA NFHGOICDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F210", Offset = "0x1F6DE10", VA = "0x181F6F210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public LFPKKLNLEPJ(CLLMLCCFDAI EGLKKHIDACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F2C0", Offset = "0x1F6DEC0", VA = "0x181F6F2C0")]
	public bool OOKHMMNOONN([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F2C0", Offset = "0x1F6DEC0", VA = "0x181F6F2C0", Slot = "8")]
	private bool HNDNAHPFECE([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class GLLANOJNBMA
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A070", Offset = "0x1F68C70", VA = "0x181F6A070")]
	public static LOCGLCFIOKB<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> ADJHJEPNIKO([In] this LOCGLCFIOKB<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>> AIKLNKDNBNC)
	{
		return default(LOCGLCFIOKB<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM, FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class DOJNMOBOFJD : LKCINBOJDHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GOGCPBGMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1F61750", Offset = "0x1F60350", VA = "0x181F61750", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	internal DOJNMOBOFJD(KAPIFPFJPBM KCPELCALJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal sealed class KBKDMACGHJL : NOOIKNGMFEF
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E740", Offset = "0x1F6D340", VA = "0x181F6E740", Slot = "4")]
	public LAHCNGFEJAN? IBFKPELINKA(string? GMINGLOEBAP, string? IKIOGODHAFM, string? BHBDNENBOCH, ACPLALMNBLO.ODCIPOFFJLP.EFPIPIIIJJM JIFKLPCMBPF, bool LPJDLONHDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KBKDMACGHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class PIEEBLIFECI : LJJHBGOEMBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct EBEGCLBDPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<CMAKDEJOIDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public PIEEBLIFECI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<IHBEIFDIAIE?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1F61990", Offset = "0x1F60590", VA = "0x181F61990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1F61C30", Offset = "0x1F60830", VA = "0x181F61C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private IReadOnlyList<KPOKIIDKMFA<BNCFOBOFDGL>>? NOMMNMADIMD;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CMAKDEJOIDK? GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1F78340", Offset = "0x1F76F40", VA = "0x181F78340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MLDLBHNIBED? NNPHDDBIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1F78F70", Offset = "0x1F77B70", VA = "0x181F78F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FMONPLEBHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1F78C20", Offset = "0x1F77820", VA = "0x181F78C20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OKFCIGINAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1F78970", Offset = "0x1F77570", VA = "0x181F78970", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	internal PIEEBLIFECI(KAPIFPFJPBM KCPELCALJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1F78E80", Offset = "0x1F77A80", VA = "0x181F78E80", Slot = "7")]
	[AsyncStateMachine(typeof(EBEGCLBDPOD))]
	public Task<CMAKDEJOIDK> NCAOFOLIJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1F78600", Offset = "0x1F77200", VA = "0x181F78600", Slot = "9")]
	public IReadOnlyDictionary<KPOKIIDKMFA<AJNNPPKMCNH>, Guid> HLGNCGMEGGG(IEnumerable<CBEKBKNFPHF> GLOPPPJAKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1F78400", Offset = "0x1F77000", VA = "0x181F78400")]
	public GFFELLBKJIA<GMGJHPGADAK, NKGCJHELBDN> ELCIOKCBKMD([In] GMGJHPGADAK ODJKIIAEIND, IEnumerable<CBEKBKNFPHF> MICHEJOPHCB, int MADHGMCJKDI)
	{
		return default(GFFELLBKJIA<GMGJHPGADAK, NKGCJHELBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1F783C0", Offset = "0x1F76FC0", VA = "0x181F783C0")]
	internal static IBGMJDOMBAG DGLJMJNJJKO(LJEGCNDLIFH DDINFGNOGDC, JJIKDDBCBGL LNFMEAPGAAK)
	{
		return default(IBGMJDOMBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1F78C80", Offset = "0x1F77880", VA = "0x181F78C80", Slot = "8")]
	private GFFELLBKJIA<GMGJHPGADAK, NKGCJHELBDN> MMADHJLBMCK([In] GMGJHPGADAK ODJKIIAEIND, IEnumerable<CBEKBKNFPHF> MICHEJOPHCB, int MADHGMCJKDI)
	{
		return default(GFFELLBKJIA<GMGJHPGADAK, NKGCJHELBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1F789D0", Offset = "0x1F775D0", VA = "0x181F789D0")]
	[CompilerGenerated]
	internal static IBGMJDOMBAG ILPBPCAIFIF(LJEGCNDLIFH GFPCEHNECFN, JJIKDDBCBGL BKINDFHFCEM)
	{
		return default(IBGMJDOMBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class MLDLBHNIBED : CMAKDEJOIDK
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal static class JKJFFJGGADD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class ILGMPHADECH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public FHKIIPNOMGA state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public LPNEEKIAAGE spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ILGMPHADECH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x1F6AC40", Offset = "0x1F69840", VA = "0x181F6AC40")]
			internal bool PLMCGOHNGBI(CCBHLLAHGJD n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class HNCOLDDNGBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public HNCOLDDNGBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x1F6AC20", Offset = "0x1F69820", VA = "0x181F6AC20")]
			internal void COKKGKIJMNJ(CCBHLLAHGJD n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1F6E060", Offset = "0x1F6CC60", VA = "0x181F6E060")]
		public static GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI> JHMLCEABGGF(MLDLBHNIBED HNFMOHFACKF, [In] CMAKDEJOIDK.IOOHGNBKMJH LLJCEPGKLEC)
		{
			return default(GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C8C0", Offset = "0x1F6B4C0", VA = "0x181F6C8C0")]
		internal static GFFELLBKJIA<(EAHPJGHOFAM, PENGCGJKGBO), CDNNBELNBJI> DEKOMFJHOLJ(MLDLBHNIBED HNFMOHFACKF, PENGCGJKGBO NBPBPGKDMGN, bool AJHJFJAKJIH, [In] KPOKIIDKMFA<AJNNPPKMCNH> CBPCFNJPMBG, [In] int? CDNCHFLIMEN, [In] IBGMJDOMBAG? PIDEPJHLOIK, [In] IBGMJDOMBAG? PKMHIHEFCLE)
		{
			return default(GFFELLBKJIA<(EAHPJGHOFAM, PENGCGJKGBO), CDNNBELNBJI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D730", Offset = "0x1F6C330", VA = "0x181F6D730")]
		private static void FHACGGMABDL(bool AJHJFJAKJIH, CBEKBKNFPHF PDLNDIJBMLD, EAHPJGHOFAM AGCIOAAGKOA, [In] KPOKIIDKMFA<AJNNPPKMCNH> CBPCFNJPMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1F6DB70", Offset = "0x1F6C770", VA = "0x181F6DB70")]
		public static void GKLHMDNMLLP(MFJCFEEFMNJ ELFLPHLJPJB, [In] CMAKDEJOIDK.CCEDNDMKCKG COMOOOLJEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1F6DF70", Offset = "0x1F6CB70", VA = "0x181F6DF70")]
		[CompilerGenerated]
		internal static bool ILLHCFGLBIO(FHKIIPNOMGA GGJHAAPJIKM, LPNEEKIAAGE GLLFOPFCEAD, CCBHLLAHGJD PPFFLKPFPEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6E5F0", Offset = "0x1F6D1F0", VA = "0x181F6E5F0")]
		[CompilerGenerated]
		internal static bool LGMECIHJIBJ(CCBHLLAHGJD BGLILLMPOMB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct EOHBKPGCFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public MLDLBHNIBED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DCECDLKENED<AJNNPPKMCNH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public DCECDLKENED<PNPFCEGBCNJ> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public DCECDLKENED<IMCNFENPJKF> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F67FD0", Offset = "0x1F66BD0", VA = "0x181F67FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F68620", Offset = "0x1F67220", VA = "0x181F68620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct NLEBOAAKBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public MLDLBHNIBED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KPOKIIDKMFA<GIGLGMMBICO> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KPOKIIDKMFA<AJNNPPKMCNH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public DCECDLKENED<OMKPDHDDBAO> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public DCECDLKENED<NMGIOEAJCBI> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x1F765C0", Offset = "0x1F751C0", VA = "0x181F765C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x1F76900", Offset = "0x1F75500", VA = "0x181F76900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct GPLAAEHHKAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public MLDLBHNIBED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KPOKIIDKMFA<GIGLGMMBICO> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public KPOKIIDKMFA<AJNNPPKMCNH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public DCECDLKENED<OMKPDHDDBAO> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public DCECDLKENED<ODOMFDGLFOL> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A740", Offset = "0x1F69340", VA = "0x181F6A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AA80", Offset = "0x1F69680", VA = "0x181F6AA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly KAPIFPFJPBM JPLNHCACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private readonly CLLMLCCFDAI HHABAPLNGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private readonly GDIGJKFJKLM HPDHFAPKJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly DHMKNCGHNLM ECGCCCBFEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly PIEEBLIFECI PDDIHEPOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Dictionary<KPOKIIDKMFA<GIGLGMMBICO>, OBMNEEPHOCK> GOIDFEDBMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	[CompilerGenerated]
	private Action<KPOKIIDKMFA<GIGLGMMBICO>>? PFLINLNAAJH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DHMKNCGHNLM DPBNDGMKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1F4A010", Offset = "0x1F48C10", VA = "0x181F4A010", Slot = "4")]
		get
		{
			return default(DHMKNCGHNLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1F75670", Offset = "0x1F74270", VA = "0x181F75670")]
	public MLDLBHNIBED(KAPIFPFJPBM KCPELCALJIF, CLLMLCCFDAI EGLKKHIDACA, GDIGJKFJKLM ELFDNEMOGND, PIEEBLIFECI KEOKIHAOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1F72670", Offset = "0x1F71270", VA = "0x181F72670", Slot = "38")]
	public DCECDLKENED<KDBFLEOELMD> EONCJOENDDG(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN)
	{
		return default(DCECDLKENED<KDBFLEOELMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1F747E0", Offset = "0x1F733E0", VA = "0x181F747E0", Slot = "39")]
	public DCECDLKENED<AKHEHBMJHKF> MHHHPKNOJFD(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF)
	{
		return default(DCECDLKENED<AKHEHBMJHKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1F72850", Offset = "0x1F71450", VA = "0x181F72850", Slot = "5")]
	public bool GECNNAFKMNG(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> BAFNJFKBIEH, DCECDLKENED<IMCNFENPJKF> LEFFDECMKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1F72F30", Offset = "0x1F71B30", VA = "0x181F72F30")]
	public bool HFGEOKDCFEK(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] INGOMJHICCE GLGFGEJMEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1F71B10", Offset = "0x1F70710", VA = "0x181F71B10", Slot = "7")]
	public bool CBMGOIMAMKH(PIDHPFCANLD MJCNPOEJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1F75570", Offset = "0x1F74170", VA = "0x181F75570", Slot = "8")]
	public bool PHLBFJLGLCN(KBDPMDHGBMD JKOMGLLEDKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x1F71690", Offset = "0x1F70290", VA = "0x181F71690")]
	public OBMNEEPHOCK? BJMEAKPDOAC([In] KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1F71420", Offset = "0x1F70020", VA = "0x181F71420")]
	public DCECDLKENED<GIGLGMMBICO> ALKCGGDIEJK(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] KPOKIIDKMFA<GIGLGMMBICO> OKKJAFFNBOM)
	{
		return default(DCECDLKENED<GIGLGMMBICO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x1F714A0", Offset = "0x1F700A0", VA = "0x181F714A0", Slot = "18")]
	public DCECDLKENED<GIGLGMMBICO> AMDAPEKCJJP(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN)
	{
		return default(DCECDLKENED<GIGLGMMBICO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1F755F0", Offset = "0x1F741F0", VA = "0x181F755F0", Slot = "19")]
	public DCECDLKENED<GIGLGMMBICO> PPKNBEKKAPJ(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF)
	{
		return default(DCECDLKENED<GIGLGMMBICO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1F71B90", Offset = "0x1F70790", VA = "0x181F71B90")]
	private void CEKFLGMIFMF(KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1F71340", Offset = "0x1F6FF40", VA = "0x181F71340")]
	public IEnumerable<OBMNEEPHOCK> AAEDOCHFOJG([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1F72EF0", Offset = "0x1F71AF0", VA = "0x181F72EF0")]
	private OBMNEEPHOCK? HEABJACMOGH([In] KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1F74440", Offset = "0x1F73040", VA = "0x181F74440")]
	private OBMNEEPHOCK LNGLPPNBJNL([In] KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO, JJIKDDBCBGL LNFMEAPGAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1F735A0", Offset = "0x1F721A0", VA = "0x181F735A0")]
	public JJIKDDBCBGL? JBGJEDJBKDE([In] KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1F73820", Offset = "0x1F72420", VA = "0x181F73820")]
	public NFJAEEDNHJG? OMOFCEDFKLO([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x1F71C20", Offset = "0x1F70820", VA = "0x181F71C20", Slot = "14")]
	public IEnumerable<NOKPKPAAMCD> CFLKKMONJCJ(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1F741C0", Offset = "0x1F72DC0", VA = "0x181F741C0", Slot = "15")]
	public IEnumerable<INGOMJHICCE> LHDNGBNDLLH(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> BAFNJFKBIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1F721A0", Offset = "0x1F70DA0", VA = "0x181F721A0", Slot = "16")]
	public IEnumerable<INGOMJHICCE> DLPPGPDIENK(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> LEFFDECMKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1F71FC0", Offset = "0x1F70BC0", VA = "0x181F71FC0")]
	public DCECDLKENED<AJNNPPKMCNH> DKMLDOAOBKH([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(DCECDLKENED<AJNNPPKMCNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1F733F0", Offset = "0x1F71FF0", VA = "0x181F733F0")]
	public DCECDLKENED<AJNNPPKMCNH>? NIGJHNCCDLD([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1F73310", Offset = "0x1F71F10", VA = "0x181F73310")]
	private LPNEEKIAAGE? HOAIPCFHDEL([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1F73820", Offset = "0x1F72420", VA = "0x181F73820")]
	private NFJAEEDNHJG? JPLJDEPHJGC([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1F72600", Offset = "0x1F71200", VA = "0x181F72600", Slot = "23")]
	public KPOKIIDKMFA<AJNNPPKMCNH> ELBCJLJKJOG(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(KPOKIIDKMFA<AJNNPPKMCNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x1F74130", Offset = "0x1F72D30", VA = "0x181F74130")]
	public DCECDLKENED<IMCNFENPJKF> LGCMGCNNNLG(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<GIGLGMMBICO> KJPMBCBOCOO, int BJIDOJPLAFP)
	{
		return default(DCECDLKENED<IMCNFENPJKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1F752D0", Offset = "0x1F73ED0", VA = "0x181F752D0")]
	public DCECDLKENED<PNPFCEGBCNJ> OFINPKGDLOL(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<GIGLGMMBICO> KJPMBCBOCOO, int OEGEHNAFPGM)
	{
		return default(DCECDLKENED<PNPFCEGBCNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x1F73D40", Offset = "0x1F72940", VA = "0x181F73D40", Slot = "20")]
	public IEnumerable<KEODHPBNKAD> KMJHFCPKIOF(EPBMGJKGLND CAFLLFPEHLM, bool BHHFJKKJDEP, bool EEINPLLIBEP, bool NPGNFMAOGKK, bool MKNCEADDNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x1F73E40", Offset = "0x1F72A40", VA = "0x181F73E40", Slot = "21")]
	public KEODHPBNKAD LFENGOELIAH(EPBMGJKGLND CAFLLFPEHLM, GODPPCJFBIM COANIDJBPGH, bool BHHFJKKJDEP, bool EEINPLLIBEP, bool NPGNFMAOGKK, bool MKNCEADDNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1F71520", Offset = "0x1F70120", VA = "0x181F71520")]
	public NOKPKPAAMCD BGOCEIDFGKM(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] INGOMJHICCE GLGFGEJMEAB)
	{
		return default(NOKPKPAAMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1F72CC0", Offset = "0x1F718C0", VA = "0x181F72CC0", Slot = "24")]
	public INGOMJHICCE GMEJFJLOKHJ(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> BAFNJFKBIEH, DCECDLKENED<IMCNFENPJKF> LEFFDECMKGJ)
	{
		return default(INGOMJHICCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1F75360", Offset = "0x1F73F60", VA = "0x181F75360", Slot = "25")]
	public bool OOKHMMNOONN(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F72580", Offset = "0x1F71180", VA = "0x181F72580", Slot = "26")]
	public bool EHIDAJJMDND(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F745E0", Offset = "0x1F731E0", VA = "0x181F745E0", Slot = "27")]
	public bool MBNDHMLIEEL(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1F733C0", Offset = "0x1F71FC0", VA = "0x181F733C0")]
	public GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI> OMOEEHOHDJK([In] CMAKDEJOIDK.IOOHGNBKMJH LLJCEPGKLEC)
	{
		return default(GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1F73470", Offset = "0x1F72070", VA = "0x181F73470", Slot = "29")]
	[AsyncStateMachine(typeof(EOHBKPGCFBO))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> ILLKLACGDJG(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> BAFNJFKBIEH, DCECDLKENED<IMCNFENPJKF> LEFFDECMKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x1F74860", Offset = "0x1F73460", VA = "0x181F74860", Slot = "30")]
	public GFFELLBKJIA<MINDHGAGPKC, NKGCJHELBDN> MLBODEDBFCE(KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH, MINDHGAGPKC FNMHNCELDAK, BAIJOIKGIKG FEDKFDECKKG)
	{
		return default(GFFELLBKJIA<MINDHGAGPKC, NKGCJHELBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x1F72420", Offset = "0x1F71020", VA = "0x181F72420", Slot = "31")]
	[AsyncStateMachine(typeof(NLEBOAAKBDA))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> DPFJMGLJLNM(KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH, KPOKIIDKMFA<GIGLGMMBICO> MJIEJKLIBED, DCECDLKENED<OMKPDHDDBAO> FOHPAGICLPK, DCECDLKENED<NMGIOEAJCBI> ALMJBMBCMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x1F72040", Offset = "0x1F70C40", VA = "0x181F72040", Slot = "32")]
	[AsyncStateMachine(typeof(GPLAAEHHKAI))]
	public Task<GFFELLBKJIA<LOGIJBPEHJN, DCMKOJFPDPC>> DDDBHFLGHOA(KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH, KPOKIIDKMFA<GIGLGMMBICO> NCHHMCKPHFD, DCECDLKENED<OMKPDHDDBAO> ADALLBMNKIJ, DCECDLKENED<ODOMFDGLFOL> LKMOAAHJAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x1F73630", Offset = "0x1F72230", VA = "0x181F73630", Slot = "33")]
	public OMCMCJHFMGP JKMFFOLIBJA(IEnumerable<CBEKBKNFPHF> MICHEJOPHCB)
	{
		return default(OMCMCJHFMGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1F753D0", Offset = "0x1F73FD0", VA = "0x181F753D0", Slot = "34")]
	public OMCMCJHFMGP PBPHIFNKCNG()
	{
		return default(OMCMCJHFMGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x1F73B90", Offset = "0x1F72790", VA = "0x181F73B90")]
	private OOKDEHOJBAK KLOBOBPDGLJ(LLFCHAKAIDN JBNLJBPGOLP, DCECDLKENED<AJNNPPKMCNH> GAEKPMCPKGF, IEnumerable<KPOKIIDKMFA<AJNNPPKMCNH>> KAOFKLKKOIG, IEnumerable<KPOKIIDKMFA<GIGLGMMBICO>> PBBDEBGHHBE)
	{
		return default(OOKDEHOJBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1F73850", Offset = "0x1F72450", VA = "0x181F73850", Slot = "35")]
	public OOKDEHOJBAK KLOBOBPDGLJ(LLFCHAKAIDN JBNLJBPGOLP, DCECDLKENED<AJNNPPKMCNH> GAEKPMCPKGF, IEnumerable<KPOKIIDKMFA<GIGLGMMBICO>> PBBDEBGHHBE, IEnumerable<CBEKBKNFPHF> MICHEJOPHCB)
	{
		return default(OOKDEHOJBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1F71790", Offset = "0x1F70390", VA = "0x181F71790")]
	private static IEnumerable<KPOKIIDKMFA<AJNNPPKMCNH>> CALJJFFKIEE(IEnumerable<CBEKBKNFPHF> MICHEJOPHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1F74C50", Offset = "0x1F73850", VA = "0x181F74C50")]
	private IEnumerable<KPOKIIDKMFA<GIGLGMMBICO>> MMEEAEKOPCC(IEnumerable<CBEKBKNFPHF> MICHEJOPHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1F74660", Offset = "0x1F73260", VA = "0x181F74660", Slot = "36")]
	public List<OMKKDKEKDFO> MEOMFDMPOCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1F751E0", Offset = "0x1F73DE0", VA = "0x181F751E0", Slot = "37")]
	public bool ODENDFDIHDL(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1F74510", Offset = "0x1F73110", VA = "0x181F74510")]
	internal void LPCAPGIMAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1F732B0", Offset = "0x1F71EB0", VA = "0x181F732B0")]
	internal Task HGELNJEMCDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1F733B0", Offset = "0x1F71FB0", VA = "0x181F733B0", Slot = "6")]
	private bool IBMMAEINKIF(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] INGOMJHICCE GLGFGEJMEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1F73820", Offset = "0x1F72420", VA = "0x181F73820", Slot = "9")]
	private NFJAEEDNHJG PEBGHEIGADH([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1F71FC0", Offset = "0x1F70BC0", VA = "0x181F71FC0", Slot = "10")]
	private DCECDLKENED<AJNNPPKMCNH> CGBNEMFCDPG([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return default(DCECDLKENED<AJNNPPKMCNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x1F733F0", Offset = "0x1F71FF0", VA = "0x181F733F0", Slot = "11")]
	private DCECDLKENED<AJNNPPKMCNH>? IJHMFHHIGPF([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F726F0", Offset = "0x1F712F0", VA = "0x181F726F0", Slot = "12")]
	private OBMNEEPHOCK FBACNNPOBEN([In] KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1F71420", Offset = "0x1F70020", VA = "0x181F71420", Slot = "13")]
	private DCECDLKENED<GIGLGMMBICO> HAPCLIDAOHP(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] KPOKIIDKMFA<GIGLGMMBICO> OKKJAFFNBOM)
	{
		return default(DCECDLKENED<GIGLGMMBICO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1F75100", Offset = "0x1F73D00", VA = "0x181F75100", Slot = "17")]
	private IEnumerable<OBMNEEPHOCK> OAHFHOFMCCN([In] KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x1F71520", Offset = "0x1F70120", VA = "0x181F71520", Slot = "22")]
	private NOKPKPAAMCD PFLPEJOKLKN(DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, [In] INGOMJHICCE GLGFGEJMEAB)
	{
		return default(NOKPKPAAMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1F733C0", Offset = "0x1F71FC0", VA = "0x181F733C0", Slot = "28")]
	private GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI> IFHBEDNBPDL([In] CMAKDEJOIDK.IOOHGNBKMJH LLJCEPGKLEC)
	{
		return default(GFFELLBKJIA<CMAKDEJOIDK.CFJELPCJNLF, CDNNBELNBJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1F746F0", Offset = "0x1F732F0", VA = "0x181F746F0")]
	[CompilerGenerated]
	private OBMNEEPHOCK MGDBJLEDBDN(JJIKDDBCBGL EKELKKECGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1F754F0", Offset = "0x1F740F0", VA = "0x181F754F0")]
	[CompilerGenerated]
	private MCOBAMEKIGG PFANPDDMKJG(AKAJDHLNMMA EKELKKECGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x1F74570", Offset = "0x1F73170", VA = "0x181F74570")]
	[CompilerGenerated]
	private JJIKDDBCBGL MALBALKOJBC(KPOKIIDKMFA<GIGLGMMBICO> EKELKKECGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1F727E0", Offset = "0x1F713E0", VA = "0x181F727E0")]
	[CompilerGenerated]
	private LPNEEKIAAGE GAJJEFOLLKJ(KPOKIIDKMFA<AJNNPPKMCNH> EKELKKECGGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public sealed class MCOBAMEKIGG : KEODHPBNKAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct GFMGFDPHIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<DCECDLKENED<OAAFJJJLHDG>, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public MCOBAMEKIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public KPOKIIDKMFA<AJNNPPKMCNH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public KPOKIIDKMFA<GIGLGMMBICO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DCECDLKENED<OMKPDHDDBAO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<GFFELLBKJIA<DCECDLKENED<OAAFJJJLHDG>, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D020", Offset = "0x1F7BC20", VA = "0x181F7D020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D2A0", Offset = "0x1F7BEA0", VA = "0x181F7D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct OAMAJEAGBBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<DCECDLKENED<KKIKNFODNKB>, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public MCOBAMEKIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KPOKIIDKMFA<AJNNPPKMCNH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public KPOKIIDKMFA<GIGLGMMBICO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public DCECDLKENED<OMKPDHDDBAO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<GFFELLBKJIA<DCECDLKENED<KKIKNFODNKB>, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E260", Offset = "0x1F7CE60", VA = "0x181F7E260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E4E0", Offset = "0x1F7D0E0", VA = "0x181F7E4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private readonly AKAJDHLNMMA LDGIMKEKPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private readonly CLLMLCCFDAI HHABAPLNGJN;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public TypeKey BCCKJMOAHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string BCMOIPHBEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B0F0", Offset = "0x1F79CF0", VA = "0x181F7B0F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public AKAJDHLNMMA PJMLCKEOPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E010", Offset = "0x1F7CC10", VA = "0x181F7E010")]
	public MCOBAMEKIGG(AKAJDHLNMMA KOJPLNFMHKB, CLLMLCCFDAI EGLKKHIDACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DD30", Offset = "0x1F7C930", VA = "0x181F7DD30", Slot = "6")]
	[AsyncStateMachine(typeof(GFMGFDPHIEJ))]
	public Task<GFFELLBKJIA<DCECDLKENED<OAAFJJJLHDG>, DCMKOJFPDPC>> CBOOBGNEHFD(KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH, KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, string GFLNGGKHEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DEA0", Offset = "0x1F7CAA0", VA = "0x181F7DEA0", Slot = "7")]
	[AsyncStateMachine(typeof(OAMAJEAGBBH))]
	public Task<GFFELLBKJIA<DCECDLKENED<KKIKNFODNKB>, DCMKOJFPDPC>> GLEPDEMFHPE(KPOKIIDKMFA<AJNNPPKMCNH> DJGLMBCCEPH, KPOKIIDKMFA<GIGLGMMBICO> KJPMBCBOCOO, DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP, string GFLNGGKHEOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class DLBPGCNKOEL : EGHKLHHFFHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private readonly AKAJDHLNMMA DFDBHJFKEDI;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private static readonly HashSet<AKAJDHLNMMA> PPHLPMELMMC;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static readonly HashSet<AKAJDHLNMMA> CACKBBOKACG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly HashSet<AKAJDHLNMMA> CLBADBBFPGL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey NEMDOAJKGDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C2A0", Offset = "0x1F7AEA0", VA = "0x181F7C2A0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool IBDECBKDJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C290", Offset = "0x1F7AE90", VA = "0x181F7C290", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool JIJGIBDMEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C2F0", Offset = "0x1F7AEF0", VA = "0x181F7C2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool NOLIKFBMFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C210", Offset = "0x1F7AE10", VA = "0x181F7C210", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AE80", Offset = "0x1F79A80", VA = "0x181F7AE80")]
	public bool GMNKIBMJFNE(string GLMEMJNJKAN, [Out] OEEFDKMDGCF FOOLHENHNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public DLBPGCNKOEL(AKAJDHLNMMA NHLLCDFJMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F7ACF0", Offset = "0x1F798F0", VA = "0x181F7ACF0")]
	internal static TypeKey BCGOCDDILCP(AKAJDHLNMMA NCNNODEFPOG)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B0F0", Offset = "0x1F79CF0", VA = "0x181F7B0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public readonly struct MHMILMGJEJP : FJHOKOIKACF.DGGHPGHNPGN<KPEIBDAFOMB, LOGIJBPEHJN>
{
	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0D0", Offset = "0x1F7CCD0", VA = "0x181F7E0D0", Slot = "4")]
	public int GKLKBIANJDP(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0B0", Offset = "0x1F7CCB0", VA = "0x181F7E0B0", Slot = "5")]
	public KPEIBDAFOMB BCEOEMFCEBH(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E190", Offset = "0x1F7CD90", VA = "0x181F7E190", Slot = "6")]
	public KPEIBDAFOMB LPHDEHDAMMI(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E1E0", Offset = "0x1F7CDE0", VA = "0x181F7E1E0", Slot = "7")]
	public IReadOnlyList<KPEIBDAFOMB> OCAGLLPEHLD(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0C0", Offset = "0x1F7CCC0", VA = "0x181F7E0C0", Slot = "8")]
	public KPEIBDAFOMB[] EPANFMNPGLC(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ, int IBOMMGNPJEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E130", Offset = "0x1F7CD30", VA = "0x181F7E130", Slot = "9")]
	public bool JFPBOHHLJHF(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0F0", Offset = "0x1F7CCF0", VA = "0x181F7E0F0", Slot = "10")]
	public bool HKCEFIMINBJ(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E1C0", Offset = "0x1F7CDC0", VA = "0x181F7E1C0", Slot = "11")]
	public bool MFODPKHHHAL(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E150", Offset = "0x1F7CD50", VA = "0x181F7E150", Slot = "12")]
	public bool KHBEBGOOEMI(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E110", Offset = "0x1F7CD10", VA = "0x181F7E110", Slot = "13")]
	public bool HLOLEENAPNA(LOGIJBPEHJN NJLGKJNKHDJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E170", Offset = "0x1F7CD70", VA = "0x181F7E170", Slot = "14")]
	public bool LOGLHOEAJCA(LOGIJBPEHJN KGECOLOELOJ, KPEIBDAFOMB FIPNCHEIGMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class DLLDLANENHB : OPKHADNNKCD
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MLDIPGBBGJF.GPFGLENNCBE MFJMIPEMHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C460", Offset = "0x1F7B060", VA = "0x181F7C460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract EAJCABHLBHF.KGIAELGNDDE BGAOLGINCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract KAPIFPFJPBM.CKPFKOBPIEH GNILAAJCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract MBONHOHFBJI.IPAMALPCJPL ACGAPHENLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public FBDMKCHIIEC.FNCKIIKMALN<MCHFNCPKCHH, KPEIBDAFOMB, KAPIFPFJPBM> POCNGADANDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C410", Offset = "0x1F7B010", VA = "0x181F7C410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract JGJANGBPMAM NCIIHALIHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract MAEAMFANOOA AHCAMCOBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract FDMDCDNEJLM BHJOOOLODDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract MFEAPMIBBPD CPEBAJGHDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract DEEHBNCBKNI CIMDACIDHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected DLLDLANENHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class AIGJDCLEPCN : NHKLILKBPHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct GJAHNBPHHCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AIGJDCLEPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public KPEIBDAFOMB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D310", Offset = "0x1F7BF10", VA = "0x181F7D310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D5B0", Offset = "0x1F7C1B0", VA = "0x181F7D5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct LJNPHGPADMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<DOAHPFBPLDP, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AIGJDCLEPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public IReadOnlyList<KPEIBDAFOMB> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D940", Offset = "0x1F7C540", VA = "0x181F7D940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1F7DCC0", Offset = "0x1F7C8C0", VA = "0x181F7DCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private readonly AINBMLCMMJM LMNLEMDOACK;

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public AIGJDCLEPCN(AINBMLCMMJM DCGGBFLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A8C0", Offset = "0x1F794C0", VA = "0x181F7A8C0")]
	[AsyncStateMachine(typeof(GJAHNBPHHCH))]
	private Task<GFFELLBKJIA<object, DCMKOJFPDPC>> OGMGOFGAPMN(KPEIBDAFOMB FIPNCHEIGMJ, bool ADIMHKJHMBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A790", Offset = "0x1F79390", VA = "0x181F7A790", Slot = "4")]
	[AsyncStateMachine(typeof(LJNPHGPADMG))]
	public Task<GFFELLBKJIA<DOAHPFBPLDP, DCMKOJFPDPC>> EKBLIBFNKII(IReadOnlyList<KPEIBDAFOMB> FOLFFNCNEBJ, bool ADIMHKJHMBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct FDCOBNKCCAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	internal NHMIIPPBAIH<EEEAJDNKBAK, KPEIBDAFOMB, BHBFAHLFFAK> DFDBHJFKEDI;

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F459F0", Offset = "0x1F445F0", VA = "0x181F459F0")]
	private FDCOBNKCCAI([In] NHMIIPPBAIH<EEEAJDNKBAK, KPEIBDAFOMB, BHBFAHLFFAK> FILLDMIJNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CFC0", Offset = "0x1F7BBC0", VA = "0x181F7CFC0")]
	public static FDCOBNKCCAI PPOPBMPFEOP()
	{
		return default(FDCOBNKCCAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class EDJLPLAKCEJ
{
	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static NHMIIPPBAIH<EEEAJDNKBAK, KPEIBDAFOMB, BHBFAHLFFAK> NBJMBJNLNJI(this FDCOBNKCCAI HNFMOHFACKF)
	{
		return default(NHMIIPPBAIH<EEEAJDNKBAK, KPEIBDAFOMB, BHBFAHLFFAK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct BHBFAHLFFAK : DIBDOAHCJLI.PNBPICICCMP<EEEAJDNKBAK, KPEIBDAFOMB>
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A9F0", Offset = "0x1F795F0", VA = "0x181F7A9F0", Slot = "5")]
	public KPEIBDAFOMB PLELAFPPJIP(EEEAJDNKBAK[] DFOHJLIAOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0")]
	public int GKJEPICCCEP([In] EEEAJDNKBAK CDFHKOPLKOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0", Slot = "4")]
	private int GDCLOIPHFDK([In] EEEAJDNKBAK BDBALIFAMNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public struct NOIBEFKBNDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	internal BBFAHDBGJDO<JEBGCOOABAF, KPEIBDAFOMB, EOLMPLPGPJK> DFDBHJFKEDI;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F459F0", Offset = "0x1F445F0", VA = "0x181F459F0")]
	private NOIBEFKBNDC([In] BBFAHDBGJDO<JEBGCOOABAF, KPEIBDAFOMB, EOLMPLPGPJK> PGBENFBFIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E200", Offset = "0x1F7CE00", VA = "0x181F7E200")]
	public static NOIBEFKBNDC PPOPBMPFEOP()
	{
		return default(NOIBEFKBNDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class MPLOBLGNNCH
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static BBFAHDBGJDO<JEBGCOOABAF, KPEIBDAFOMB, EOLMPLPGPJK> NBJMBJNLNJI(this NOIBEFKBNDC HNFMOHFACKF)
	{
		return default(BBFAHDBGJDO<JEBGCOOABAF, KPEIBDAFOMB, EOLMPLPGPJK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct EOLMPLPGPJK : GMNPOAJBCBK.ODEBCOFGGBP<JEBGCOOABAF, KPEIBDAFOMB>
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0")]
	public int ALFFDBGNLIL([In] JEBGCOOABAF CDFHKOPLKOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CDD0", Offset = "0x1F7B9D0", VA = "0x181F7CDD0", Slot = "5")]
	public KPEIBDAFOMB HGCLNJHPCGM(JEBGCOOABAF[] IMFNIEPDAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0", Slot = "4")]
	private int IIKHBBOOOHO([In] JEBGCOOABAF CDFHKOPLKOP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class HIEGOFJDJIJ : DICIKJENGEG, CDNNBELNBJI, DCMKOJFPDPC, NKGCJHELBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly NKGCJHELBDN? BJAMKFCPMFB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public PPAEPJABCKD BJGJKEOGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(PPAEPJABCKD);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x84DE00", Offset = "0x84CA00", VA = "0x18084DE00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override NKGCJHELBDN? CFFCMBCDKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D620", Offset = "0x1F7C220", VA = "0x181F7D620", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D900", Offset = "0x1F7C500", VA = "0x181F7D900")]
	private HIEGOFJDJIJ(PPAEPJABCKD OLADDMOOKPM, NKGCJHELBDN? NNNOAPHEEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D7A0", Offset = "0x1F7C3A0", VA = "0x181F7D7A0")]
	public static HIEGOFJDJIJ HLNMMEFLKBM(NKGCJHELBDN NNNOAPHEEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D820", Offset = "0x1F7C420", VA = "0x181F7D820")]
	public static HIEGOFJDJIJ JIPJLEOFJGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D890", Offset = "0x1F7C490", VA = "0x181F7D890")]
	public static HIEGOFJDJIJ JKFGLBDBIMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class LDGOIEJOIFD
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE230", Offset = "0x2BECE30", VA = "0x182BEE230")]
	public static GFFELLBKJIA<TOk, CDNNBELNBJI> KDGPACAGCJF<TOk>([In] this GFFELLBKJIA<TOk, CDNNBELNBJI> HNFMOHFACKF, NKGCJHELBDN NNNOAPHEEEE) where TOk : notnull
	{
		return default(GFFELLBKJIA<TOk, CDNNBELNBJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE130", Offset = "0x2BECD30", VA = "0x182BEE130")]
	public static GFFELLBKJIA<TOk?, CDNNBELNBJI?> ALKLGCFFNID<TOk>([In] this GFFELLBKJIA<TOk, CDNNBELNBJI> HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<TOk, CDNNBELNBJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE320", Offset = "0x2BECF20", VA = "0x182BEE320")]
	public static GFFELLBKJIA<TOk?, CDNNBELNBJI?> LPFPLHPDCJE<TOk>([In] this GFFELLBKJIA<TOk, CDNNBELNBJI> HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<TOk, CDNNBELNBJI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface JGJANGBPMAM
{
	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDGMKKPFGPK([In] GFFELLBKJIA<LOGIJBPEHJN, NKGCJHELBDN> JFBAIGMLPKE);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class LJIJBIIFFBK
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCCE0", Offset = "0x2BFB8E0", VA = "0x182BFCCE0")]
	public static bool PDGMKKPFGPK<TOk, TErr>(this JGJANGBPMAM HNFMOHFACKF, [In] GFFELLBKJIA<TOk, TErr> JFBAIGMLPKE) where TOk : notnull where TErr : notnull, NKGCJHELBDN
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface MAEAMFANOOA
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	JKPJHEFCIHA LMOKHIJICGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface FDMDCDNEJLM
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CHKBIKGCDEG DCGFLIGELNP(int ICFBENCABKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface CCEIEMIKBKE
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface CJLHGFBPGBE
{
	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJFEKGANCGM? PLKKIJMHMDI(DCECDLKENED<OMKPDHDDBAO> GOMFODILJBP);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface JPKCBAOAPIA
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface FJFEKGANCGM
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPKCBAOAPIA? HFLCOGNJPEG(DCECDLKENED<OAAFJJJLHDG> DDNHNCNLDJK);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCEIEMIKBKE? LDEGHHHELEK(DCECDLKENED<KKIKNFODNKB> GFJIFJLGKMK);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface MFEAPMIBBPD
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IDFGMAFDKPJ(string GLMEMJNJKAN, string FBMKGECLCCA);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface DEEHBNCBKNI
{
	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJLHGFBPGBE? FNIGLMBMIKI([In] KPOKIIDKMFA<BNCFOBOFDGL> HFEFNEKOBNO);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class EBGDFDCPAII
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private struct BNMBEIDIHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int HDEPOMLIBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public GKKNBFGCPLF? AAEHBJHMOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public GKKNBFGCPLF? FKBAKIGMDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public readonly List<KPEIBDAFOMB> JFGBLPFLNAF;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1F7ACA0", Offset = "0x1F798A0", VA = "0x181F7ACA0")]
		private BNMBEIDIHIK(int OPDMGNJCACB, GKKNBFGCPLF? GEPJCKPOJAI, GKKNBFGCPLF? GAOGLGFLJLA, List<KPEIBDAFOMB> FOLFFNCNEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7ABE0", Offset = "0x1F797E0", VA = "0x181F7ABE0")]
		public static BNMBEIDIHIK PPOPBMPFEOP()
		{
			return default(BNMBEIDIHIK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly DJEFHBAKJHJ<BNMBEIDIHIK> FDOAHBLELOM;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public static EBGDFDCPAII GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C4B0", Offset = "0x1F7B0B0", VA = "0x181F7C4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool KDBPIPJLKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x897580", Offset = "0x896180", VA = "0x180897580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x99DDA0", Offset = "0x99C9A0", VA = "0x18099DDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C500", Offset = "0x1F7B100", VA = "0x181F7C500")]
	public void FAJMLLNJDJF(FHKIIPNOMGA GAOGLGFLJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C920", Offset = "0x1F7B520", VA = "0x181F7C920")]
	public void PBKBFGHIKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C5C0", Offset = "0x1F7B1C0", VA = "0x181F7C5C0")]
	private static string? INNJFNBBGCA([In] BNMBEIDIHIK JOMEHILOOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CD20", Offset = "0x1F7B920", VA = "0x181F7CD20")]
	public EBGDFDCPAII()
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
