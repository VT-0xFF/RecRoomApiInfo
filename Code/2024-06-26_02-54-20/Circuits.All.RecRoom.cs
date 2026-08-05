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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FD70", Offset = "0x1F7E370", VA = "0x181F7FD70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class JOOJDMJJLEH : IDisposable, ECLPKDGOAND, BIBLPKMGIII, IGFJANOHOJM, NILAGBLKPHO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class ALJJKMHKEJE : MIHACBIPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int KBPPIKHKAKN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F65860", Offset = "0x1F63E60", VA = "0x181F65860", Slot = "5")]
		public KHELNPHJBOP KHAIABPCJCF(KGDIMKMHBFE.MOIDLENAHHO OJGLDAGFLKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NBCNAJFOOME();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void CFHHPDICBNE();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F65A30", Offset = "0x1F64030", VA = "0x181F65A30", Slot = "13")]
		public virtual void MCBEFAKCIDD(JOOJDMJJLEH KHALMCHEKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F659B0", Offset = "0x1F63FB0", VA = "0x181F659B0", Slot = "14")]
		public virtual void LGNGGGEOHDH(JOOJDMJJLEH KHALMCHEKDD, LHAEFPHAKAB OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		protected ALJJKMHKEJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MIHACBIPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int KBPPIKHKAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KHELNPHJBOP KHAIABPCJCF(KGDIMKMHBFE.MOIDLENAHHO OJGLDAGFLKC);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NBCNAJFOOME();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CFHHPDICBNE();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MCBEFAKCIDD(JOOJDMJJLEH KHALMCHEKDD);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LGNGGGEOHDH(JOOJDMJJLEH KHALMCHEKDD, LHAEFPHAKAB OGLJLDNLGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct LMGAHOPAGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MNOJACLHNCK<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> HNAILNEMKEH;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D240", Offset = "0x1F7B840", VA = "0x181F7D240")]
		internal LMGAHOPAGKI(MNOJACLHNCK<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MPEMBIIMIEL : KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly MPEMBIIMIEL IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		private MPEMBIIMIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB7B9D0", Offset = "0xB79FD0", VA = "0x180B7B9D0", Slot = "4")]
		public NJFHMKNMECP IOJBBFGABCC(LHAEFPHAKAB OLDDCPCBGIL)
		{
			return default(NJFHMKNMECP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FB80", Offset = "0x1F7E180", VA = "0x181F7FB80", Slot = "5")]
		public void MCBEFAKCIDD(JOOJDMJJLEH FMGEJNFFGHE, LHAEFPHAKAB OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FA70", Offset = "0x1F7E070", VA = "0x181F7FA70", Slot = "6")]
		public void LGNGGGEOHDH(JOOJDMJJLEH FMGEJNFFGHE, LHAEFPHAKAB OGLJLDNLGIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct KBCHMFBOPII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> HNAILNEMKEH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B860", Offset = "0x1F79E60", VA = "0x181F7B860")]
		internal KBCHMFBOPII(NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B810", Offset = "0x1F79E10", VA = "0x181F7B810")]
		public static KBCHMFBOPII HCLFOFEHDJP()
		{
			return default(KBCHMFBOPII);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GJMNFCAHGPC : OAJKKMGDBOO.CCGIGCEDEPA<LHAEFPHAKAB, JOOJDMJJLEH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct FHJDJGPIHHG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public JOOJDMJJLEH receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LHAEFPHAKAB action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GJMNFCAHGPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B330", Offset = "0x1F69930", VA = "0x181F6B330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B510", Offset = "0x1F69B10", VA = "0x181F6B510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8E9270", Offset = "0x8E7870", VA = "0x1808E9270", Slot = "4")]
		public HBKKMIFHCOI<EIKFNDMDOJI> BCKIGFDBJGI(JOOJDMJJLEH PMALGFDMMMA)
		{
			return default(HBKKMIFHCOI<EIKFNDMDOJI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CE50", Offset = "0x1F6B450", VA = "0x181F6CE50", Slot = "5")]
		[AsyncStateMachine(typeof(FHJDJGPIHHG))]
		public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EJNDJKMCFEN(JOOJDMJJLEH PMALGFDMMMA, LHAEFPHAKAB OGLJLDNLGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CF80", Offset = "0x1F6B580", VA = "0x181F6CF80", Slot = "6")]
		public LHAEFPHAKAB[] MCKGHELMHJF(JOOJDMJJLEH PMALGFDMMMA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PBJOEOAIELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JOOJDMJJLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AGKNAGALEPM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OCCKDCOPHOC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public HMALNBKCNFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F80650", Offset = "0x1F7EC50", VA = "0x181F80650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F808D0", Offset = "0x1F7EED0", VA = "0x181F808D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CIBDEKDMHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JOOJDMJJLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F69670", Offset = "0x1F67C70", VA = "0x181F69670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F69900", Offset = "0x1F67F00", VA = "0x181F69900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LFJEDGHNPBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JOOJDMJJLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CC40", Offset = "0x1F7B240", VA = "0x181F7CC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CE20", Offset = "0x1F7B420", VA = "0x181F7CE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GDBFAMGGILN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JOOJDMJJLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public LHAEFPHAKAB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B9D0", Offset = "0x1F69FD0", VA = "0x181F6B9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BBC0", Offset = "0x1F6A1C0", VA = "0x181F6BBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CJCFHMBGMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public JOOJDMJJLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F69970", Offset = "0x1F67F70", VA = "0x181F69970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A160", Offset = "0x1F68760", VA = "0x181F6A160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HBKKMIFHCOI<EIKFNDMDOJI> GFNPMNHLOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LMGAHOPAGKI NNDLMMPDECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MGBELDMDLPO CHJHCCKLMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GKNKMINNEBL KBIAOJBFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1828")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly FLCPFHBAPJH JJAMBPCFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1830")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MDDIMDPOMKC.NJFFLOAGOPF PCHIKGDKHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1850")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly LBKJEPDDNGL JLNBDLKFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1858")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly AKFANCKKAOE BDDIBKOLBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1860")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PBOABKNJFJD IKKHNBLIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1868")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EGLCBPFGBKA HNFAPJOPEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1870")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EJAAMGBHNOH IJJFDHMNGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1880")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PEPAPMHKFKO LJIHHEFGLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly MGBELDMDLPO.GGENEPMEDEA KHCOBIGDKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GOGFHKFMKHD NEMLJLDHEDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGBELDMDLPO MKLANBOJFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AB50", Offset = "0x1F79150", VA = "0x181F7AB50")]
		get
		{
			return default(MGBELDMDLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MIHACBIPGMM DEFGCMCDACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A560", Offset = "0x1F78B60", VA = "0x181F7A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KHELNPHJBOP ELKOBPOKPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A060", Offset = "0x1F78660", VA = "0x181F7A060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B1F0", Offset = "0x1F797F0", VA = "0x181F7B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NCEFEDCCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A5B0", Offset = "0x1F78BB0", VA = "0x181F7A5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A070", Offset = "0x1F78670", VA = "0x181F7A070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BJHLAKBJGKO AHKCKJGFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B7D0", Offset = "0x1F79DD0", VA = "0x181F7B7D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EPJNNELGOGJ PNJEFMMMMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B7E0", Offset = "0x1F79DE0", VA = "0x181F7B7E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DBFAAEPDDME CFBCEINFDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B800", Offset = "0x1F79E00", VA = "0x181F7B800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DAJBIJHHEBH FMIEJFAPNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B7F0", Offset = "0x1F79DF0", VA = "0x181F7B7F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MDDIMDPOMKC? EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F79FE0", Offset = "0x1F785E0", VA = "0x181F79FE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BGKNJNPOJIF? KKNJKGJMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B3A0", Offset = "0x1F799A0", VA = "0x181F7B3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B4D0", Offset = "0x1F79AD0", VA = "0x181F7B4D0")]
	private JOOJDMJJLEH(FLCPFHBAPJH ECFOBHKDIGL, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, [In] LMGAHOPAGKI JLNHNLIGONI, [In] MGBELDMDLPO NBKAOCGOJKK, [In] GKNKMINNEBL DCDAGCEPLJE, KHELNPHJBOP OGJHIBPCAOA, [In] MDDIMDPOMKC.NJFFLOAGOPF NBEHPNBHMMO, MGBELDMDLPO.GGENEPMEDEA DHNGJCGFLGH, GOGFHKFMKHD KLIMNIPMKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A5C0", Offset = "0x1F78BC0", VA = "0x181F7A5C0")]
	public static JOOJDMJJLEH HCLFOFEHDJP(FLCPFHBAPJH OJGLDAGFLKC, [In] BBELGPEHEBI DEFBBOJCBCK, NCOPDIDOCIJ LPJMNFNNLOL, [In] BFDEGALMMGL HNPLDPCJAKF, AGAJFDOBDMC MNNDPJJPNFJ, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, HBKKMIFHCOI<LEHJCLIPGBM> AGHFHJDAPPL, PKBGPKAOHBH DFJCFKMIMDO, HMJGLCBHCGJ AAGJOLOELMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A700", Offset = "0x1F78D00", VA = "0x181F7A700")]
	public static JOOJDMJJLEH HCLFOFEHDJP(FLCPFHBAPJH ECFOBHKDIGL, [In] MGBELDMDLPO NBKAOCGOJKK, [In] GKNKMINNEBL DCDAGCEPLJE, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, HBKKMIFHCOI<LEHJCLIPGBM> AGHFHJDAPPL, PKBGPKAOHBH DFJCFKMIMDO, HMJGLCBHCGJ AAGJOLOELMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A370", Offset = "0x1F78970", VA = "0x181F7A370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A210", Offset = "0x1F78810", VA = "0x181F7A210")]
	[AsyncStateMachine(typeof(PBJOEOAIELM))]
	internal Task<PIJKHLBEMKP<bool, NJADGKCOIIE>> DJLBJINGPJA(AGKNAGALEPM KCIKNADAAIN, OCCKDCOPHOC BFJKCBLPPNB, HMALNBKCNFI KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AB60", Offset = "0x1F79160", VA = "0x181F7AB60")]
	[AsyncStateMachine(typeof(CIBDEKDMHLB))]
	public Task<PIJKHLBEMKP<bool, NJADGKCOIIE>> JKOBDFLEEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A9E0", Offset = "0x1F78FE0", VA = "0x181F7A9E0")]
	[AsyncStateMachine(typeof(LFJEDGHNPBB))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HFDBBMLFJME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AC50", Offset = "0x1F79250", VA = "0x181F7AC50")]
	internal void MBPGIGALLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B210", Offset = "0x1F79810", VA = "0x181F7B210")]
	internal GBGJJMPMMOC<LHAEFPHAKAB> MOMFKOJIMOL([In] GMLOAEMICEM NDCOKFIFMGK)
	{
		return default(GBGJJMPMMOC<LHAEFPHAKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A1A0", Offset = "0x1F787A0", VA = "0x181F7A1A0")]
	internal bool CIHMEDAFCPG([In] GMLOAEMICEM NDCOKFIFMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AAD0", Offset = "0x1F790D0", VA = "0x181F7AAD0")]
	internal GBGJJMPMMOC<LHAEFPHAKAB> HMFKABOOCKE([In] LAIIPGLFFDO FDNPBIEJGOL)
	{
		return default(GBGJJMPMMOC<LHAEFPHAKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B290", Offset = "0x1F79890", VA = "0x181F7B290")]
	[AsyncStateMachine(typeof(GDBFAMGGILN))]
	internal Task<PIJKHLBEMKP<object, NJADGKCOIIE>> NDJLAKALMID(LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AE60", Offset = "0x1F79460", VA = "0x181F7AE60")]
	private LHAEFPHAKAB[] MCKGHELMHJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A080", Offset = "0x1F78680", VA = "0x181F7A080")]
	[AsyncStateMachine(typeof(CJCFHMBGMLD))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> CCNOMNEKPCH(Guid DLMHCBHLPNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ODEPOKKKIJH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C940B0", Offset = "0x2C926B0", VA = "0x182C940B0")]
	public static NNMPMPJEGIG<(TPrev?, JOOJDMJJLEH?), BGKNJNPOJIF> JKNAOKCDPCN<TPrev>([In] this NNMPMPJEGIG<TPrev, JOOJDMJJLEH> OLDDCPCBGIL)
	{
		return default(NNMPMPJEGIG<(TPrev, JOOJDMJJLEH), BGKNJNPOJIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C93E90", Offset = "0x2C92490", VA = "0x182C93E90")]
	public static NNMPMPJEGIG<TPrev?, JOOJDMJJLEH?> CPGJBLNGFLM<TPrev>([In] this NNMPMPJEGIG<TPrev, JOOJDMJJLEH> OLDDCPCBGIL)
	{
		return default(NNMPMPJEGIG<TPrev, JOOJDMJJLEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class BFHDJNDBJBB<TData> : FNFMNGCMHCP, PINIHHMBGNP, PFPHCNGMPPA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DAMOFJGJNKL<JMIDFPKEEGG>? KKOPHNHADJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string CANNEAPCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData MEEFJAOGPIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DAMOFJGJNKL<JMIDFPKEEGG>? GJIIFGNDFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2195DA0", Offset = "0x21943A0", VA = "0x182195DA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E54630", Offset = "0x4E52C30", VA = "0x184E54630")]
	internal BFHDJNDBJBB([In] DAMOFJGJNKL<JMIDFPKEEGG>? OACAGPBNMGE, HBKKMIFHCOI<PMHAGHKACGK>? OMGHKGIDKJA, IOKind? OAKFCEGNGNA, string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JHAFFLBJMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F794F0", Offset = "0x1F77AF0", VA = "0x181F794F0")]
	public static PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP> GFJLDCMLPKE([In] this PBIHBOCMLOA<OHENAFGHCPN> OINKFFDGJFI)
	{
		return default(PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B74520", Offset = "0x2B72B20", VA = "0x182B74520")]
	public static PIJKHLBEMKP<TOk, PINIHHMBGNP> DOGOBPKPPHG<TOk>([In] this PIJKHLBEMKP<TOk, PINIHHMBGNP> OLDDCPCBGIL, [In] DAMOFJGJNKL<JMIDFPKEEGG>? OACAGPBNMGE, HBKKMIFHCOI<PMHAGHKACGK>? OMGHKGIDKJA, IOKind? OAKFCEGNGNA, string NFOHONOFFAP) where TOk : notnull
	{
		return default(PIJKHLBEMKP<TOk, PINIHHMBGNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FLCPFHBAPJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DLGNBFFFJLN.GDHOOPFNBAJ DFEBHJNMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KGDIMKMHBFE.MOIDLENAHHO OBBIHGEFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JOOJDMJJLEH.MIHACBIPGMM NDGIKDHAFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CJJOLICGHKG.FGAHFMCOIBE CLBLHFHBCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH> IMEGFBPJLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CPINABIIADF BHFCPAAJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LJHDAPGEJJE CHKELOKKMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NLGHLAJCHOD MNAIFDANDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CEPHBLLCLBJ OBJDPMKPKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AGBMMPAAEAL OLOMKCHBCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GGPCDONLONC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C290", Offset = "0x1F6A890", VA = "0x181F6C290")]
	public static LHAEFPHAKAB IIEMMLHKEDE(this LHAEFPHAKAB OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C1C0", Offset = "0x1F6A7C0", VA = "0x181F6C1C0")]
	public static LHAEFPHAKAB DKFDMCANEAJ(this DCNHMHCLPPM OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DCNHMHCLPPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GCNFELGBNHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JOOJDMJJLEH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DCNHMHCLPPM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B6A0", Offset = "0x1F69CA0", VA = "0x181F6B6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B960", Offset = "0x1F69F60", VA = "0x181F6B960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString BLBBIKKJHJE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	private DCNHMHCLPPM(ByteString CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A9A0", Offset = "0x1F68FA0", VA = "0x181F6A9A0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(ByteString CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AA60", Offset = "0x1F69060", VA = "0x181F6AA60")]
	public static DGAGACGIHNN<NJFHMKNMECP, DCNHMHCLPPM> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, DCNHMHCLPPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AB10", Offset = "0x1F69110", VA = "0x181F6AB10")]
	[AsyncStateMachine(typeof(GCNFELGBNHL))]
	public static Task<PIJKHLBEMKP<object, NJADGKCOIIE>> NDJLAKALMID(JOOJDMJJLEH FMGEJNFFGHE, DCNHMHCLPPM OLDDCPCBGIL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FBILKGNAKEA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B1A0", Offset = "0x1F697A0", VA = "0x181F6B1A0")]
	public static LHAEFPHAKAB FBFCPOMMFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B240", Offset = "0x1F69840", VA = "0x181F6B240")]
	public static DGAGACGIHNN<NJFHMKNMECP, FBILKGNAKEA> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, FBILKGNAKEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B2B0", Offset = "0x1F698B0", VA = "0x181F6B2B0")]
	public static PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB> MPNMBGCPMBC(JOOJDMJJLEH FMGEJNFFGHE, [In] FBILKGNAKEA OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GJFJOGHGKEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct HJGPJPBNBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public JOOJDMJJLEH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GJFJOGHGKEA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1F78830", Offset = "0x1F76E30", VA = "0x181F78830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F78BA0", Offset = "0x1F771A0", VA = "0x181F78BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly AGKNAGALEPM? GFHPEMHACPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly OCCKDCOPHOC? IIJLAHJIJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly HMALNBKCNFI? CECGOGIKOHJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E9E7D0", Offset = "0x1E9CDD0", VA = "0x181E9E7D0")]
	private GJFJOGHGKEA(AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CB00", Offset = "0x1F6B100", VA = "0x181F6CB00")]
	public static LHAEFPHAKAB? FBFCPOMMFGD(AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CC00", Offset = "0x1F6B200", VA = "0x181F6CC00")]
	public static DGAGACGIHNN<NJFHMKNMECP, GJFJOGHGKEA> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, GJFJOGHGKEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CD10", Offset = "0x1F6B310", VA = "0x181F6CD10")]
	[AsyncStateMachine(typeof(HJGPJPBNBPJ))]
	public static Task<PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB>> NDJLAKALMID(JOOJDMJJLEH FMGEJNFFGHE, GJFJOGHGKEA OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OEDPDEBLMGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AGAOIENKILM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OEDPDEBLMGB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JOOJDMJJLEH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private PIJKHLBEMKP<object, PFPHCNGMPPA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private PIJKHLBEMKP<object, PFPHCNGMPPA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private PIJKHLBEMKP<object, PFPHCNGMPPA>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F65140", Offset = "0x1F63740", VA = "0x181F65140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F655B0", Offset = "0x1F63BB0", VA = "0x181F655B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<LHAEFPHAKAB> NCAFLHECIBM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	private OEDPDEBLMGB(IReadOnlyList<LHAEFPHAKAB> HAMKHHIHPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FDF0", Offset = "0x1F7E3F0", VA = "0x181F7FDF0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(IReadOnlyList<LHAEFPHAKAB> HAMKHHIHPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FEB0", Offset = "0x1F7E4B0", VA = "0x181F7FEB0")]
	public static DGAGACGIHNN<NJFHMKNMECP, OEDPDEBLMGB> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, OEDPDEBLMGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FF50", Offset = "0x1F7E550", VA = "0x181F7FF50")]
	[AsyncStateMachine(typeof(AGAOIENKILM))]
	public static Task<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> NDJLAKALMID(JOOJDMJJLEH FMGEJNFFGHE, OEDPDEBLMGB OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct LAIIPGLFFDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int FGAKKPCAMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int FPNFNABMIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] MEEFJAOGPIF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1AB9630", Offset = "0x1AB7C30", VA = "0x181AB9630")]
	private LAIIPGLFFDO(int JPBPNOCHNLG, int LLPJHIPCNFD, byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C7E0", Offset = "0x1F7ADE0", VA = "0x181F7C7E0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(int JPBPNOCHNLG, int LLPJHIPCNFD, ByteString FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C6A0", Offset = "0x1F7ACA0", VA = "0x181F7C6A0")]
	public static LHAEFPHAKAB[] CNCPDILJHON(LHAEFPHAKAB OGLJLDNLGIJ, int KICHIPMPPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C8C0", Offset = "0x1F7AEC0", VA = "0x181F7C8C0")]
	public static DGAGACGIHNN<NJFHMKNMECP, LAIIPGLFFDO> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, LAIIPGLFFDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C9A0", Offset = "0x1F7AFA0", VA = "0x181F7C9A0")]
	public static PIJKHLBEMKP<LHAEFPHAKAB, JPAMHBNAPMB> MPNMBGCPMBC(JOOJDMJJLEH FMGEJNFFGHE, [In] LAIIPGLFFDO OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<LHAEFPHAKAB, JPAMHBNAPMB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GMLOAEMICEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MFPGBPAPEJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<bool, JPAMHBNAPMB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JOOJDMJJLEH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GMLOAEMICEM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private PIJKHLBEMKP<bool, JPAMHBNAPMB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, JPAMHBNAPMB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D340", Offset = "0x1F7B940", VA = "0x181F7D340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D980", Offset = "0x1F7BF80", VA = "0x181F7D980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int FGAKKPCAMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int FPNFNABMIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] MEEFJAOGPIF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1AB9630", Offset = "0x1AB7C30", VA = "0x181AB9630")]
	private GMLOAEMICEM(int JPBPNOCHNLG, int LLPJHIPCNFD, byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F77FD0", Offset = "0x1F765D0", VA = "0x181F77FD0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(int JPBPNOCHNLG, int LLPJHIPCNFD, ByteString FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F77DD0", Offset = "0x1F763D0", VA = "0x181F77DD0")]
	public static LHAEFPHAKAB?[]? AHOEGCAEODK(int KICHIPMPPLC, AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F780B0", Offset = "0x1F766B0", VA = "0x181F780B0")]
	public static DGAGACGIHNN<NJFHMKNMECP, GMLOAEMICEM> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, GMLOAEMICEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F78190", Offset = "0x1F76790", VA = "0x181F78190")]
	[AsyncStateMachine(typeof(MFPGBPAPEJA))]
	public static Task<PIJKHLBEMKP<bool, JPAMHBNAPMB>> NDJLAKALMID(JOOJDMJJLEH FMGEJNFFGHE, GMLOAEMICEM OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LBKJEPDDNGL : BJHLAKBJGKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FGHCHKLJLEI? IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CB30", Offset = "0x1F7B130", VA = "0x181F7CB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	internal LBKJEPDDNGL(JOOJDMJJLEH KHALMCHEKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OLKOPFDMPBB : FGHCHKLJLEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly OKEJDJNOOIE IHPJMEOKAKE;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
	public OLKOPFDMPBB(JOOJDMJJLEH KHALMCHEKDD, OKEJDJNOOIE NFKIECONLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F80370", Offset = "0x1F7E970", VA = "0x181F80370", Slot = "4")]
	public PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP> IJGOJAPGDFA(DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED)
	{
		return default(PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F80090", Offset = "0x1F7E690", VA = "0x181F80090", Slot = "5")]
	public PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP> CFFFBABCMHK(DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA)
	{
		return default(PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DLGNBFFFJLN : KIAAHGKKHGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface GDHOOPFNBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<OKEJDJNOOIE> AGGCLAGFIIM(JOOJDMJJLEH KHALMCHEKDD, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HBBDNIKPEOK NFBGCHGKMGP(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IEAMDDADLAO : GDHOOPFNBAJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct AKMMFKEKLKE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<OKEJDJNOOIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public JOOJDMJJLEH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public OCCKDCOPHOC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HMALNBKCNFI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<CJJOLICGHKG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F65620", Offset = "0x1F63C20", VA = "0x181F65620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1F657F0", Offset = "0x1F63DF0", VA = "0x181F657F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IEAMDDADLAO IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		private IEAMDDADLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F78EB0", Offset = "0x1F774B0", VA = "0x181F78EB0", Slot = "4")]
		[AsyncStateMachine(typeof(AKMMFKEKLKE))]
		public Task<OKEJDJNOOIE> AGGCLAGFIIM(JOOJDMJJLEH KHALMCHEKDD, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F79010", Offset = "0x1F77610", VA = "0x181F79010", Slot = "5")]
		public HBBDNIKPEOK NFBGCHGKMGP(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JMNEMPMJAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<DLGNBFFFJLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JOOJDMJJLEH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OCCKDCOPHOC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HMALNBKCNFI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AGKNAGALEPM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private GDHOOPFNBAJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<OKEJDJNOOIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1F79A70", Offset = "0x1F78070", VA = "0x181F79A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F79F70", Offset = "0x1F78570", VA = "0x181F79F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OKEJDJNOOIE IHPJMEOKAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HBBDNIKPEOK PPEOPJNEGFN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MDDIMDPOMKC EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AC20", Offset = "0x1F69220", VA = "0x181F6AC20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BGKNJNPOJIF NHKAIKLFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AE40", Offset = "0x1F69440", VA = "0x181F6AE40", Slot = "5")]
		get
		{
			return default(BGKNJNPOJIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OLKOPFDMPBB DMMAAOPFCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public APGFLEHHNBL NIHBMHBFGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CA90", Offset = "0x1D7B090", VA = "0x181D7CA90")]
	private DLGNBFFFJLN(OKEJDJNOOIE NFKIECONLKB, HBBDNIKPEOK PMBKGLBIAHE, OLKOPFDMPBB PHKEBLFJKHD, APGFLEHHNBL NPFJHJGNMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F6ACD0", Offset = "0x1F692D0", VA = "0x181F6ACD0")]
	[AsyncStateMachine(typeof(JMNEMPMJAIH))]
	public static Task<DLGNBFFFJLN> LGHHEPEAJLF(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AC70", Offset = "0x1F69270", VA = "0x181F6AC70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KGDIMKMHBFE : KHELNPHJBOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface MOIDLENAHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KIAAHGKKHGJ> PEHOFGADBKH(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KJLHKFIMGEA();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KIFFEEJHGIO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class KIMKGDOCKCO : MOIDLENAHHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LKKMNBFMNOA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<KIAAHGKKHGJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public JOOJDMJJLEH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AGKNAGALEPM evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public OCCKDCOPHOC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public HMALNBKCNFI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<DLGNBFFFJLN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F7CE90", Offset = "0x1F7B490", VA = "0x181F7CE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D1D0", Offset = "0x1F7B7D0", VA = "0x181F7D1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C540", Offset = "0x1F7AB40", VA = "0x181F7C540", Slot = "4")]
		[AsyncStateMachine(typeof(LKKMNBFMNOA))]
		public Task<KIAAHGKKHGJ> PEHOFGADBKH(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KJLHKFIMGEA();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KIFFEEJHGIO();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		protected KIMKGDOCKCO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BGJPNAGDIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<KIAAHGKKHGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KGDIMKMHBFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<HNKFFDNJINI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F692D0", Offset = "0x1F678D0", VA = "0x181F692D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F694D0", Offset = "0x1F67AD0", VA = "0x181F694D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GFICLFMPLMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KGDIMKMHBFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public JOOJDMJJLEH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AGKNAGALEPM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public OCCKDCOPHOC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HMALNBKCNFI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<KIAAHGKKHGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BC30", Offset = "0x1F6A230", VA = "0x181F6BC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C160", Offset = "0x1F6A760", VA = "0x181F6C160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MOIDLENAHHO GNFPFODOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<HNKFFDNJINI> NNMFOEJPLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<HNKFFDNJINI> FEHONMGMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource AFKCBCNNOGA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool NCEFEDCCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9CBCB0", Offset = "0x9CA2B0", VA = "0x1809CBCB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA26EE0", Offset = "0xA254E0", VA = "0x180A26EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xADEB40", Offset = "0xADD140", VA = "0x180ADEB40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xADEB60", Offset = "0xADD160", VA = "0x180ADEB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DNBMPCFJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10DA2B0", Offset = "0x10D88B0", VA = "0x1810DA2B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F7BC10", Offset = "0x1F7A210", VA = "0x181F7BC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KIAAHGKKHGJ? LBGJFIIMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86CF10", Offset = "0x86B510", VA = "0x18086CF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F7BEF0", Offset = "0x1F7A4F0", VA = "0x181F7BEF0", Slot = "7")]
	[AsyncStateMachine(typeof(BGJPNAGDIHH))]
	public Task<KIAAHGKKHGJ> JHHJELLMFLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7BFE0", Offset = "0x1F7A5E0", VA = "0x181F7BFE0")]
	public KGDIMKMHBFE(MOIDLENAHHO OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7BC20", Offset = "0x1F7A220", VA = "0x181F7BC20", Slot = "8")]
	[AsyncStateMachine(typeof(GFICLFMPLMA))]
	public Task CDNMIACPINI(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7BD80", Offset = "0x1F7A380", VA = "0x181F7BD80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CJHLNFNEOMG : JNMFGEAAFAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly APGFLEHHNBL PJFBDDNBJGP;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public CJHLNFNEOMG(APGFLEHHNBL NPFJHJGNMEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JCJPFHKJLHL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FGPJLCCMCLL<TGraph> : GPMBAPNKEOC where TGraph : ICFEHOOIGAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph CMOCLNNCGBF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual NMPCIIEHDBC? MHLGOIKNNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xF15D80", Offset = "0xF14380", VA = "0x180F15D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public HBKKMIFHCOI<EKJMGNHJFDN> HLPKLNNHMEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C26C30", Offset = "0x3C25230", VA = "0x183C26C30", Slot = "5")]
			get
			{
				return default(HBKKMIFHCOI<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public HBKKMIFHCOI<EKJMGNHJFDN>? NFKIMIFBHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C26C50", Offset = "0x3C25250", VA = "0x183C26C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
		public FGPJLCCMCLL(TGraph MJOHLJLDMNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class MFPBHBBOFHB : FGPJLCCMCLL<AJENAFDLAAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override NMPCIIEHDBC? MHLGOIKNNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D250", Offset = "0x1F7B850", VA = "0x181F7D250", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D270", Offset = "0x1F7B870", VA = "0x181F7D270")]
		public MFPBHBBOFHB(AJENAFDLAAA MFGMLHGLKCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F79360", Offset = "0x1F77960", VA = "0x181F79360")]
	public static GPMBAPNKEOC HCLFOFEHDJP(ICFEHOOIGAO MJOHLJLDMNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class BEILIFKJEAK : ADEIFDEHNLJ, BGGKHBIFAEB, CKCCDGBALKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KGLFKIGAKHF
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
			public KGLFKIGAKHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public CPINABIIADF errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F82020", Offset = "0x1F80620", VA = "0x181F82020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F82290", Offset = "0x1F80890", VA = "0x181F82290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public BEILIFKJEAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KGLFKIGAKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C0F0", Offset = "0x1F7A6F0", VA = "0x181F7C0F0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task NOFCOJNNFEG(CPINABIIADF errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HGGDCKODMJJ : IAsyncStateMachine
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
		public BEILIFKJEAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1F782C0", Offset = "0x1F768C0", VA = "0x181F782C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F787D0", Offset = "0x1F76DD0", VA = "0x181F787D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BMCHDEODDLH
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
			public BMCHDEODDLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F822F0", Offset = "0x1F808F0", VA = "0x181F822F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F825D0", Offset = "0x1F80BD0", VA = "0x181F825D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public BEILIFKJEAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BMCHDEODDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F695A0", Offset = "0x1F67BA0", VA = "0x181F695A0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JNNLFLCGLNK(CPINABIIADF errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly CDGMKFJFGMP OMJMHJKBJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<DGDJLJHDIKF> PDLNBCNCMCF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private FLCPFHBAPJH IDBPLAGMONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F68060", Offset = "0x1F66660", VA = "0x181F68060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HBKKMIFHCOI<CHIHANCPCBA> GBCMGAGMECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8CE550", Offset = "0x8CCB50", VA = "0x1808CE550", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<CHIHANCPCBA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC8C580", Offset = "0xC8AB80", VA = "0x180C8C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private HBKKMIFHCOI<KIADPJBFMAK> OMDPHFGIEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAD31F0", Offset = "0xAD17F0", VA = "0x180AD31F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HBKKMIFHCOI<NIMJJIGJCLJ> MFDFJELCHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x889F50", Offset = "0x888550", VA = "0x180889F50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<NIMJJIGJCLJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override HBKKMIFHCOI<PMHAGHKACGK> LPFLDCIEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F68470", Offset = "0x1F66A70", VA = "0x181F68470", Slot = "20")]
		get
		{
			return default(HBKKMIFHCOI<PMHAGHKACGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KOLFICBPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F683F0", Offset = "0x1F669F0", VA = "0x181F683F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F690B0", Offset = "0x1F676B0", VA = "0x181F690B0")]
	private BEILIFKJEAK(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, CDGMKFJFGMP OLIDFKMIIMI, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED, HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F670A0", Offset = "0x1F656A0", VA = "0x181F670A0")]
	public static BEILIFKJEAK HCLFOFEHDJP(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, CDGMKFJFGMP CPEKGDIIDKL, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED, bool FHGEKDMEAEP, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F66A70", Offset = "0x1F65070", VA = "0x181F66A70", Slot = "21")]
	protected override void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F66D70", Offset = "0x1F65370", VA = "0x181F66D70", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F66940", Offset = "0x1F64F40", VA = "0x181F66940", Slot = "30")]
	public void AEKEEMHMPPE(DGDJLJHDIKF GJEKDFCFFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F68080", Offset = "0x1F66680", VA = "0x181F68080", Slot = "27")]
	public void MLJNENCLEAO(FIGPFCCGJOI NDNAEFJAOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F68700", Offset = "0x1F66D00", VA = "0x181F68700", Slot = "28")]
	public void PKPMOKLBCIG(DMPIEPKAJAP MODBBIOCFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F66C20", Offset = "0x1F65220", VA = "0x181F66C20", Slot = "23")]
	protected override void DKAHAGGDDDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F66EA0", Offset = "0x1F654A0", VA = "0x181F66EA0", Slot = "32")]
	public string GDKNOJAHPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F675F0", Offset = "0x1F65BF0", VA = "0x181F675F0", Slot = "29")]
	public string IJFEAEOPIOC(int EFEECMADLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F67C10", Offset = "0x1F66210", VA = "0x181F67C10")]
	private void KKJEILLEOMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F678B0", Offset = "0x1F65EB0", VA = "0x181F678B0", Slot = "31")]
	public void JBMOIFJGCKD(DGDJLJHDIKF GJEKDFCFFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F67980", Offset = "0x1F65F80", VA = "0x181F67980")]
	private void JKABDKMGEPF(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F685F0", Offset = "0x1F66BF0", VA = "0x181F685F0", Slot = "33")]
	[AsyncStateMachine(typeof(HGGDCKODMJJ))]
	public Task PEEAOLFNGJP(string CBAEIEAPLIH, bool JKHHFLMJJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F67F10", Offset = "0x1F66510", VA = "0x181F67F10")]
	public void LLEJDEEAPOF(string CBAEIEAPLIH, bool JKHHFLMJJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F67450", Offset = "0x1F65A50", VA = "0x181F67450")]
	private void HIOJCLIDJNC(int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xC8C580", Offset = "0xC8AB80", VA = "0x180C8C580")]
	internal void GMPHGLEAJBB(HBKKMIFHCOI<CHIHANCPCBA> CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F685E0", Offset = "0x1F66BE0", VA = "0x181F685E0")]
	[CompilerGenerated]
	private void PDGHHLFJLMK(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F67B50", Offset = "0x1F66150", VA = "0x181F67B50")]
	[CompilerGenerated]
	private bool KKCLJOFJFIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F66880", Offset = "0x1F64E80", VA = "0x181F66880")]
	[CompilerGenerated]
	private bool ADJBAOMFCID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F669A0", Offset = "0x1F64FA0", VA = "0x181F669A0")]
	[CompilerGenerated]
	private int GNIABEJIBJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F67010", Offset = "0x1F65610", VA = "0x181F67010")]
	[CompilerGenerated]
	private bool GHPLLHGJGHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F67B40", Offset = "0x1F66140", VA = "0x181F67B40")]
	[CompilerGenerated]
	private void KGHOKPIKOEH(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F66B10", Offset = "0x1F65110", VA = "0x181F66B10")]
	[CompilerGenerated]
	private bool COPCMBFMIJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F684C0", Offset = "0x1F66AC0", VA = "0x181F684C0")]
	[CompilerGenerated]
	private bool ODPFFDLHHFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F66E10", Offset = "0x1F65410", VA = "0x181F66E10")]
	[CompilerGenerated]
	private bool FEHBIEICJJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F669A0", Offset = "0x1F64FA0", VA = "0x181F669A0")]
	[CompilerGenerated]
	private int AEKKOBFOGCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F68510", Offset = "0x1F66B10", VA = "0x181F68510")]
	[CompilerGenerated]
	private bool OFPKJHDAHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F66BD0", Offset = "0x1F651D0", VA = "0x181F66BD0")]
	[CompilerGenerated]
	private int DJAFBEBNGMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F669F0", Offset = "0x1F64FF0", VA = "0x181F669F0")]
	[CompilerGenerated]
	private void AOFCPJLPAAP(object CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F67E40", Offset = "0x1F66440", VA = "0x181F67E40")]
	[CompilerGenerated]
	private bool KKOGPJPKEGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PDBEFLCOHCM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class BLMGMLJBPBD : EAHKPFBPIMN<GDKMAHGNKEF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override OMLMKPNJFBP DEKNNDMEDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8D95E0", Offset = "0x8D7BE0", VA = "0x1808D95E0", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F69540", Offset = "0x1F67B40", VA = "0x181F69540")]
		public BLMGMLJBPBD(JOOJDMJJLEH KHALMCHEKDD, GDKMAHGNKEF LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class KIEKCBIFADF : FLHJOEBGJCE<MPMGHJCOJAK>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C4D0", Offset = "0x1F7AAD0", VA = "0x181F7C4D0")]
		public KIEKCBIFADF(JOOJDMJJLEH KHALMCHEKDD, MPMGHJCOJAK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C1E0", Offset = "0x1F7A7E0", VA = "0x181F7C1E0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C480", Offset = "0x1F7AA80", VA = "0x181F7C480")]
		[CompilerGenerated]
		private bool PKJCFCJEODH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C360", Offset = "0x1F7A960", VA = "0x181F7C360")]
		[CompilerGenerated]
		private void KBHILKJFIFP(bool CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class KDDIDGCLBHL : FLHJOEBGJCE<IAIDDHAHKNK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class PDDLNKDCGLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public KDDIDGCLBHL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public PDDLNKDCGLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F81EE0", Offset = "0x1F804E0", VA = "0x181F81EE0")]
			internal void COFCJKDJKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F81FD0", Offset = "0x1F805D0", VA = "0x181F81FD0")]
			internal bool PNOMNBKFDEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F81F30", Offset = "0x1F80530", VA = "0x181F81F30")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F81DC0", Offset = "0x1F803C0", VA = "0x181F81DC0")]
			internal void BIBKJJFHCPP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F81F80", Offset = "0x1F80580", VA = "0x181F81F80")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F7BBA0", Offset = "0x1F7A1A0", VA = "0x181F7BBA0")]
		public KDDIDGCLBHL(JOOJDMJJLEH KHALMCHEKDD, IAIDDHAHKNK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B870", Offset = "0x1F79E70", VA = "0x181F7B870", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CPMFDOPKDBN : FLHJOEBGJCE<DCFOOGDEKOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class GHABKBGMKMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public CPMFDOPKDBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public GHABKBGMKMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C3F0", Offset = "0x1F6A9F0", VA = "0x181F6C3F0")]
			internal object COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C4F0", Offset = "0x1F6AAF0", VA = "0x181F6C4F0")]
			internal bool EGEJICJNDOM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C8B0", Offset = "0x1F6AEB0", VA = "0x181F6C8B0")]
			internal void PNOMNBKFDEO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C5C0", Offset = "0x1F6ABC0", VA = "0x181F6C5C0")]
			internal string GNBJLDAOBME(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C3A0", Offset = "0x1F6A9A0", VA = "0x181F6C3A0")]
			internal IReadOnlyList<object> BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C720", Offset = "0x1F6AD20", VA = "0x181F6C720")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C570", Offset = "0x1F6AB70", VA = "0x181F6C570")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C790", Offset = "0x1F6AD90", VA = "0x181F6C790")]
			internal void NJDLMJNFPFI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A930", Offset = "0x1F68F30", VA = "0x181F6A930")]
		public CPMFDOPKDBN(JOOJDMJJLEH KHALMCHEKDD, DCFOOGDEKOJ MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A1D0", Offset = "0x1F687D0", VA = "0x181F6A1D0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class IDKBIMBPKGO : FLHJOEBGJCE<HKGNMGMJOJF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class ACDHPNECILK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public IDKBIMBPKGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public ACDHPNECILK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1F64F80", Offset = "0x1F63580", VA = "0x181F64F80")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F65020", Offset = "0x1F63620", VA = "0x181F65020")]
			internal void PNOMNBKFDEO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F64FD0", Offset = "0x1F635D0", VA = "0x181F64FD0")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F78E40", Offset = "0x1F77440", VA = "0x181F78E40")]
		public IDKBIMBPKGO(JOOJDMJJLEH KHALMCHEKDD, HKGNMGMJOJF MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F78C10", Offset = "0x1F77210", VA = "0x181F78C10", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class FHGFOKLDGKI<TNode> : FLHJOEBGJCE<TNode> where TNode : notnull, PCCEPOJOELN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct EEOPCNJLKEK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public FHGFOKLDGKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x37E8750", Offset = "0x37E6D50", VA = "0x1837E8750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x37E8B50", Offset = "0x37E7150", VA = "0x1837E8B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct ELODHLCEKEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public FHGFOKLDGKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3836920", Offset = "0x3834F20", VA = "0x183836920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3836D20", Offset = "0x3835320", VA = "0x183836D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool HCINIAEOGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3C27130", Offset = "0x3C25730", VA = "0x183C27130", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C270E0", Offset = "0x3C256E0", VA = "0x183C270E0")]
		protected FHGFOKLDGKI(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C26FC0", Offset = "0x3C255C0", VA = "0x183C26FC0", Slot = "100")]
		[AsyncStateMachine(typeof(FHGFOKLDGKI<>.EEOPCNJLKEK))]
		public override Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C26CD0", Offset = "0x3C252D0", VA = "0x183C26CD0", Slot = "124")]
		public sealed override bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C26F20", Offset = "0x3C25520", VA = "0x183C26F20", Slot = "112")]
		protected sealed override bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C26E80", Offset = "0x3C25480", VA = "0x183C26E80", Slot = "113")]
		protected override bool HPIHPMEFIMM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3C26D70", Offset = "0x3C25370", VA = "0x183C26D70", Slot = "101")]
		[AsyncStateMachine(typeof(FHGFOKLDGKI<>.ELODHLCEKEP))]
		public override Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GPOOPJANOMH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class IKEIIDFCEOI : DMEMDLIDPNO<NKMLPHAGBLL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MOJMOHNDAPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public IKEIIDFCEOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public MOJMOHNDAPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F930", Offset = "0x1F7DF30", VA = "0x181F7F930")]
			internal bool DGFKBIDOBHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F9B0", Offset = "0x1F7DFB0", VA = "0x181F7F9B0")]
			internal void PEMCEBMGGDF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1F79300", Offset = "0x1F77900", VA = "0x181F79300")]
		public IKEIIDFCEOI(JOOJDMJJLEH KHALMCHEKDD, NKMLPHAGBLL LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F790B0", Offset = "0x1F776B0", VA = "0x181F790B0", Slot = "126")]
		protected override void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class NKOOIOLNOKM : EICHAAEOEKA<GOLBEOFMKJI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FD10", Offset = "0x1F7E310", VA = "0x181F7FD10")]
		public NKOOIOLNOKM(JOOJDMJJLEH KHALMCHEKDD, GOLBEOFMKJI MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class EICHAAEOEKA<TNode> : FLHJOEBGJCE<TNode> where TNode : notnull, APHCBCNIFHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct DBKALNMINOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x57CD0A0", Offset = "0x57CB6A0", VA = "0x1857CD0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x57CD560", Offset = "0x57CBB60", VA = "0x1857CD560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct JEHAMJKPJJF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x407A9C0", Offset = "0x4078FC0", VA = "0x18407A9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x407AE50", Offset = "0x4079450", VA = "0x18407AE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct FHJAFCHMPMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3C27220", Offset = "0x3C25820", VA = "0x183C27220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x3C27900", Offset = "0x3C25F00", VA = "0x183C27900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class HNDCGIDLOMG
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
				public HNDCGIDLOMG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3541C20", Offset = "0x3540220", VA = "0x183541C20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public FCJJHIHCGFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public HNDCGIDLOMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3690", Offset = "0x3DF1C90", VA = "0x183DF3690")]
			internal bool NJDLMJNFPFI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3DF32F0", Offset = "0x3DF18F0", VA = "0x183DF32F0")]
			internal void COFCJKDJKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3DF35F0", Offset = "0x3DF1BF0", VA = "0x183DF35F0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.HNDCGIDLOMG.<<BuildConfigMenuInternal>b__7>d))]
			internal void EGEJICJNDOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3770", Offset = "0x3DF1D70", VA = "0x183DF3770")]
			internal bool PNOMNBKFDEO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class PPIBKMPDKGN
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
				public PPIBKMPDKGN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35418A0", Offset = "0x353FEA0", VA = "0x1835418A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
			public HNDCGIDLOMG CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public PPIBKMPDKGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x47950D0", Offset = "0x47936D0", VA = "0x1847950D0")]
			internal void GNBJLDAOBME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			internal string BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
			internal void JHIMGCOAKHK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4795030", Offset = "0x4793630", VA = "0x184795030")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.PPIBKMPDKGN.<<BuildConfigMenuInternal>b__5>d))]
			internal void GEFCJOJKENH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class FCGDCCBPFBN
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
				public FCGDCCBPFBN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x35413D0", Offset = "0x353F9D0", VA = "0x1835413D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
				public FCGDCCBPFBN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<KIADPJBFMAK>, NJADGKCOIIE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x35415B0", Offset = "0x353FBB0", VA = "0x1835415B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
				public FCGDCCBPFBN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<KEBIIKCPPLB>, NJADGKCOIIE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3540D00", Offset = "0x353F300", VA = "0x183540D00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public FCJJHIHCGFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public JHMJLMFOOPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public OMFLEFMMLLM selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<DADNPGGKCKI> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public OMFLEFMMLLM selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<DADNPGGKCKI> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public FCGDCCBPFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B850", Offset = "0x3C19E50", VA = "0x183C1B850")]
			internal bool ONPIDIDPOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B580", Offset = "0x3C19B80", VA = "0x183C1B580")]
			internal void LFGEBHEMPBI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B390", Offset = "0x3C19990", VA = "0x183C1B390")]
			internal bool ICIEDPIMIGO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B6B0", Offset = "0x3C19CB0", VA = "0x183C1B6B0")]
			internal bool MKJOEFBGAAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3C1AFF0", Offset = "0x3C195F0", VA = "0x183C1AFF0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void ABOKPBFHHGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B2F0", Offset = "0x3C198F0", VA = "0x183C1B2F0")]
			internal bool HGPHPKHAINI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B6F0", Offset = "0x3C19CF0", VA = "0x183C1B6F0")]
			internal void NLDEJCBDCOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B8C0", Offset = "0x3C19EC0", VA = "0x183C1B8C0")]
			internal bool PKIDKMGAMFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B5F0", Offset = "0x3C19BF0", VA = "0x183C1B5F0")]
			internal void LIGNGBLCHKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B240", Offset = "0x3C19840", VA = "0x183C1B240")]
			internal bool HGAFMNNMOFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B470", Offset = "0x3C19A70", VA = "0x183C1B470")]
			internal bool KCJKNEPBFLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B0F0", Offset = "0x3C196F0", VA = "0x183C1B0F0")]
			internal void AGMICKFGMLD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B7B0", Offset = "0x3C19DB0", VA = "0x183C1B7B0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void ONLFNCOHPIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B330", Offset = "0x3C19930", VA = "0x183C1B330")]
			internal bool IACCOMLLFPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B160", Offset = "0x3C19760", VA = "0x183C1B160")]
			internal bool COEKPOLFOPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B1D0", Offset = "0x3C197D0", VA = "0x183C1B1D0")]
			internal void GHKFAGGMILE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B4E0", Offset = "0x3C19AE0", VA = "0x183C1B4E0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void KFEHNALNICH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3C1B090", Offset = "0x3C19690", VA = "0x183C1B090")]
			internal bool ADJFCILJNOP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class JFEPBEJLEKM
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
				public JFEPBEJLEKM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3540FF0", Offset = "0x353F5F0", VA = "0x183540FF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
			public FCGDCCBPFBN CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JFEPBEJLEKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4080B30", Offset = "0x407F130", VA = "0x184080B30")]
			internal void EBDKEMIFPEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			internal string ILLGCNKMOND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
			internal void JLFCICICODH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x4080EE0", Offset = "0x407F4E0", VA = "0x184080EE0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.JFEPBEJLEKM.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void LJPBHLFNNKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class EOAGGAEBDAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JHMJLMFOOPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<DADNPGGKCKI> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public EICHAAEOEKA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public EOAGGAEBDAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3838C50", Offset = "0x3837250", VA = "0x183838C50")]
			internal bool POKLKMLGEAL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class ELMMBHKOLOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CKCCDGBALKM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public EOAGGAEBDAD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public ELMMBHKOLOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x38366F0", Offset = "0x3834CF0", VA = "0x1838366F0")]
			internal void HPJOJGFPAEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3836640", Offset = "0x3834C40", VA = "0x183836640")]
			internal bool BBBBGDMLGMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3836800", Offset = "0x3834E00", VA = "0x183836800")]
			internal void PEPOEKBFOBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3836690", Offset = "0x3834C90", VA = "0x183836690")]
			internal bool HFPEOGBBAEA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class PCNEMLPEJMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public DADNPGGKCKI portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public ELMMBHKOLOE CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public PCNEMLPEJMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4749490", Offset = "0x4747A90", VA = "0x184749490")]
			internal void MBGNMOLLGNC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class LMDNDGNEFFC
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
				public LMDNDGNEFFC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x3543090", Offset = "0x3541690", VA = "0x183543090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
			public OMFLEFMMLLM selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public JHMJLMFOOPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public CKCCDGBALKM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LMDNDGNEFFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x42D6E70", Offset = "0x42D5470", VA = "0x1842D6E70")]
			internal int BDNGIENECEP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x42D6F70", Offset = "0x42D5570", VA = "0x1842D6F70")]
			internal void GKJPLFPDNAP(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
			internal string PHOANBJAMJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42D6EB0", Offset = "0x42D54B0", VA = "0x1842D6EB0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.LMDNDGNEFFC.<<CreatePortItemV2>b__3>d))]
			internal void DJKPEHBAOHA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x42D71B0", Offset = "0x42D57B0", VA = "0x1842D71B0")]
			internal bool OMMICNKBAJE(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> PLIINCLONOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> AKPFDNJFMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> KNFBONEIPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> CJGGFFOEEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> CGBLACKJLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<HBKKMIFHCOI<LMECHAAEJCH>, bool> DOFDKJOBKCE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BIEGNHBACOM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool OECMEGHGJHP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool CJOBNMGEJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool JPKDFJDDKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override HBKKMIFHCOI<EKJMGNHJFDN>? JPIPEBHBNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x37F08F0", Offset = "0x37EEEF0", VA = "0x1837F08F0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x37F0BD0", Offset = "0x37EF1D0", VA = "0x1837F0BD0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>>? JFBAEOIGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x37F09B0", Offset = "0x37EEFB0", VA = "0x1837F09B0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37F06D0", Offset = "0x37EECD0", VA = "0x1837F06D0")]
		public EICHAAEOEKA(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "129")]
		protected virtual bool IJHPAIINKJF(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "130")]
		protected virtual bool FKJFMDJMLNN(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "131")]
		protected virtual bool AAGNCPHFPDL(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "132")]
		protected virtual void HKBDALLHFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x37ED100", Offset = "0x37EB700", VA = "0x1837ED100", Slot = "124")]
		public override bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x37EE2C0", Offset = "0x37EC8C0", VA = "0x1837EE2C0", Slot = "100")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.DBKALNMINOO))]
		public override Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x37ED490", Offset = "0x37EBA90", VA = "0x1837ED490", Slot = "101")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.JEHAMJKPJJF))]
		public override Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GPOOPJANOMH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x37F04C0", Offset = "0x37EEAC0", VA = "0x1837F04C0", Slot = "102")]
		public override void PDNKLEKFEGM(HBKKMIFHCOI<LMECHAAEJCH> LLPJHIPCNFD, HBKKMIFHCOI<LMECHAAEJCH> PKMPGPJICGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x37EE030", Offset = "0x37EC630", VA = "0x1837EE030", Slot = "103")]
		public override IEnumerable<LHAEFPHAKAB> HMCEGJOBJAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x37ED1A0", Offset = "0x37EB7A0", VA = "0x1837ED1A0")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.FHJAFCHMPMO))]
		private Task<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> GBMGNGHOKNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "133")]
		protected virtual bool AIFNKOLNHIP(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "134")]
		protected virtual bool BOMFIBEKIKO(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "135")]
		protected virtual bool PCKLGBHAOFL(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "136")]
		protected virtual bool MECAGOIPMKN(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "137")]
		protected virtual bool LFELIIODPEA(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HPKBDAKMBNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "138")]
		protected virtual bool GJMLPGNLKDN(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HPKBDAKMBNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "139")]
		protected virtual bool IILBDALHGNI(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int JPLNJAGBMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "140")]
		protected virtual bool KGOLNABGGMC(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int JPLNJAGBMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "141")]
		protected virtual bool DMMEFNOOHEF(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int GONALOCEIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "142")]
		protected virtual bool EJKMFMBDKJI(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HDLCFJJFELF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x37EBD00", Offset = "0x37EA300", VA = "0x1837EBD00", Slot = "143")]
		protected virtual List<OMFLEFMMLLM> BOGNEBAFEBH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "144")]
		protected virtual void LPAICJJNGMO(FCJJHIHCGFA AABAOMBBJAL, AOHGDNOPNMN ALBMKKDCCLG, JHMJLMFOOPE JFMKJOHFDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x37ED5A0", Offset = "0x37EBBA0", VA = "0x1837ED5A0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x37EED40", Offset = "0x37ED340", VA = "0x1837EED40")]
		private AOHGDNOPNMN OJJKJOGMCGD(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x37EBFA0", Offset = "0x37EA5A0", VA = "0x1837EBFA0")]
		private List<DADNPGGKCKI> EDNOPELEDIA(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, AOHGDNOPNMN IPMIOHOFJBK, bool NOPADGLPHDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x37EE3E0", Offset = "0x37EC9E0", VA = "0x1837EE3E0")]
		private List<DADNPGGKCKI> MBEMKAOEBLG(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, CKCCDGBALKM JCEBAOIBEAD, bool NOPADGLPHDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x37ED2A0", Offset = "0x37EB8A0", VA = "0x1837ED2A0")]
		private OMFLEFMMLLM GCKGMMLPJIF(List<OMFLEFMMLLM> AHPACDJDBMJ, CKCCDGBALKM JCEBAOIBEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x37EBC60", Offset = "0x37EA260", VA = "0x1837EBC60")]
		[CompilerGenerated]
		private LHAEFPHAKAB BDJNPKDHGAF(CDJIOCDEIML JFDIHIMJIHB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class BBFFPDAEAJD : FLHJOEBGJCE<KDPOBFMJIDM>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class JLBFJPPGBBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public BBFFPDAEAJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JLBFJPPGBBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F79990", Offset = "0x1F77F90", VA = "0x181F79990")]
			internal int COFCJKDJKKN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1F799E0", Offset = "0x1F77FE0", VA = "0x181F799E0")]
			internal void PNOMNBKFDEO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1F65CB0", Offset = "0x1F642B0", VA = "0x181F65CB0")]
		public BBFFPDAEAJD(JOOJDMJJLEH KHALMCHEKDD, KDPOBFMJIDM MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1F65AF0", Offset = "0x1F640F0", VA = "0x181F65AF0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class EENMOCNAKKM : DMEMDLIDPNO<EFBPPOANOOH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class FPDDNHLPMHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public EENMOCNAKKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public FPDDNHLPMHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B580", Offset = "0x1F69B80", VA = "0x181F6B580")]
			internal int DGFKBIDOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B600", Offset = "0x1F69C00", VA = "0x181F6B600")]
			internal void PEMCEBMGGDF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B140", Offset = "0x1F69740", VA = "0x181F6B140")]
		public EENMOCNAKKM(JOOJDMJJLEH KHALMCHEKDD, EFBPPOANOOH LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1F6AF00", Offset = "0x1F69500", VA = "0x181F6AF00", Slot = "126")]
		protected override void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class LBEIAMNMJNB : FLHJOEBGJCE<DCCPMHKKFLP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8CF1E0", Offset = "0x8CD7E0", VA = "0x1808CF1E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CAC0", Offset = "0x1F7B0C0", VA = "0x181F7CAC0")]
		public LBEIAMNMJNB(JOOJDMJJLEH KHALMCHEKDD, DCCPMHKKFLP MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class MINONEPGMEP : FLHJOEBGJCE<OGGCHEHFLEB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GKCHPCIOBFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public MINONEPGMEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public FCJJHIHCGFA configure;

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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public GKCHPCIOBFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F73EB0", Offset = "0x1F724B0", VA = "0x181F73EB0")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F77D20", Offset = "0x1F76320", VA = "0x181F77D20")]
			internal void PNOMNBKFDEO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1F75C10", Offset = "0x1F74210", VA = "0x181F75C10")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F75000", Offset = "0x1F73600", VA = "0x181F75000")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F76BA0", Offset = "0x1F751A0", VA = "0x181F76BA0")]
			internal void NJDLMJNFPFI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F77790", Offset = "0x1F75D90", VA = "0x181F77790")]
			internal bool PHGCDCHIGEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F76A50", Offset = "0x1F75050", VA = "0x181F76A50")]
			internal bool NFPAOECPANG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F757E0", Offset = "0x1F73DE0", VA = "0x181F757E0")]
			internal void IEJPHFBPPGM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F77280", Offset = "0x1F75880", VA = "0x181F77280")]
			internal bool OJFPODJBBEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F76640", Offset = "0x1F74C40", VA = "0x181F76640")]
			internal bool LPLKIPEEPHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F77730", Offset = "0x1F75D30", VA = "0x181F77730")]
			internal void PHFABFMOBOJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F772D0", Offset = "0x1F758D0", VA = "0x181F772D0")]
			internal bool ONCGAKHKEKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F76A00", Offset = "0x1F75000", VA = "0x181F76A00")]
			internal bool NEEMEKBPNCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F752A0", Offset = "0x1F738A0", VA = "0x181F752A0")]
			internal bool GOGELNBBHKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F760E0", Offset = "0x1F746E0", VA = "0x181F760E0")]
			internal bool KOHOPAENLNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F768C0", Offset = "0x1F74EC0", VA = "0x181F768C0")]
			internal bool MNPMLJEHMFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F76550", Offset = "0x1F74B50", VA = "0x181F76550")]
			internal bool LNDKELOELAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F74CC0", Offset = "0x1F732C0", VA = "0x181F74CC0")]
			internal bool FGMMEKNCBNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F74E10", Offset = "0x1F73410", VA = "0x181F74E10")]
			internal bool FMPPHCBINPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F776E0", Offset = "0x1F75CE0", VA = "0x181F776E0")]
			internal bool PHEMHKBIFOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F6CFA0", Offset = "0x1F6B5A0", VA = "0x181F6CFA0")]
			internal void AABEPMGDNFL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F759C0", Offset = "0x1F73FC0", VA = "0x181F759C0")]
			internal bool IOAPOEINCEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F74460", Offset = "0x1F72A60", VA = "0x181F74460")]
			internal bool DIHFDMLMLJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F76E20", Offset = "0x1F75420", VA = "0x181F76E20")]
			internal bool NNDMOJJPGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F75A60", Offset = "0x1F74060", VA = "0x181F75A60")]
			internal bool IPNHNNBLGBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F765F0", Offset = "0x1F74BF0", VA = "0x181F765F0")]
			internal bool LPAEGCIBFGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F77920", Offset = "0x1F75F20", VA = "0x181F77920")]
			internal bool PLBOFMPJLEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F73250", Offset = "0x1F71850", VA = "0x181F73250")]
			internal bool AHMOGLBOFCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F77A00", Offset = "0x1F76000", VA = "0x181F77A00")]
			internal bool PMMGNMNJLGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F76F70", Offset = "0x1F75570", VA = "0x181F76F70")]
			internal void OANAPIABGJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F75050", Offset = "0x1F73650", VA = "0x181F75050")]
			internal bool GIMPHAKGMPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F737D0", Offset = "0x1F71DD0", VA = "0x181F737D0")]
			internal bool BOGBLHHFPHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F76DC0", Offset = "0x1F753C0", VA = "0x181F76DC0")]
			internal void NMIMFHMMIFE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F74370", Offset = "0x1F72970", VA = "0x181F74370")]
			internal bool DFFDFOCCMHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F73340", Offset = "0x1F71940", VA = "0x181F73340")]
			internal bool ALGJIAIIHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1F76E70", Offset = "0x1F75470", VA = "0x181F76E70")]
			internal void NNEMOJCGAGK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D0F0", Offset = "0x1F6B6F0", VA = "0x181F6D0F0")]
			internal List<DADNPGGKCKI> AGNCKHODNMM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F73680", Offset = "0x1F71C80", VA = "0x181F73680")]
			internal bool BLCHCFCFAOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1F76820", Offset = "0x1F74E20", VA = "0x181F76820")]
			internal int MLHOLMFCGKH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1F74D60", Offset = "0x1F73360", VA = "0x181F74D60")]
			internal void FLGMJGPOPEA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F74780", Offset = "0x1F72D80", VA = "0x181F74780")]
			internal bool ECCEIKAMEIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F752F0", Offset = "0x1F738F0", VA = "0x181F752F0")]
			internal bool GPBIBENBKMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F75740", Offset = "0x1F73D40", VA = "0x181F75740")]
			internal bool ICHOPIOGIAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F749F0", Offset = "0x1F72FF0", VA = "0x181F749F0")]
			internal int ENIGBBIKDCP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F74220", Offset = "0x1F72820", VA = "0x181F74220")]
			internal void DDLDEJAIIPB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F75E40", Offset = "0x1F74440", VA = "0x181F75E40")]
			internal bool JNBKIKPHNIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F73870", Offset = "0x1F71E70", VA = "0x181F73870")]
			internal bool CBBMAOFECIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F73590", Offset = "0x1F71B90", VA = "0x181F73590")]
			internal bool BHGDFHILMOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F74110", Offset = "0x1F72710", VA = "0x181F74110")]
			internal bool DCMNMOHCDJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F756A0", Offset = "0x1F73CA0", VA = "0x181F756A0")]
			internal bool HPDDJKKAHPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F75200", Offset = "0x1F73800", VA = "0x181F75200")]
			internal bool GOEGJOMNEEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F767D0", Offset = "0x1F74DD0", VA = "0x181F767D0")]
			internal string MJNOBOHJPNF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1F75480", Offset = "0x1F73A80", VA = "0x181F75480")]
			internal void HDLAKIAKDHC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F77120", Offset = "0x1F75720", VA = "0x181F77120")]
			internal int OEHFIPEAPEK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F77460", Offset = "0x1F75A60", VA = "0x181F77460")]
			internal void PBPPGGGFEJP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F77510", Offset = "0x1F75B10", VA = "0x181F77510")]
			internal bool PCMIIMCIJJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F77020", Offset = "0x1F75620", VA = "0x181F77020")]
			internal bool OBNHKELNKNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F76960", Offset = "0x1F74F60", VA = "0x181F76960")]
			internal bool NBMOHKHDPBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F766E0", Offset = "0x1F74CE0", VA = "0x181F766E0")]
			internal float MCOHOCECNGN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F74C10", Offset = "0x1F73210", VA = "0x181F74C10")]
			internal void FBAFIKDKCAE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F74820", Offset = "0x1F72E20", VA = "0x181F74820")]
			internal bool EFEHNJLPNFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D000", Offset = "0x1F6B600", VA = "0x181F6D000")]
			internal bool ABFLMAAOJEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F73430", Offset = "0x1F71A30", VA = "0x181F73430")]
			internal bool ANABGICCCNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F761E0", Offset = "0x1F747E0", VA = "0x181F761E0")]
			internal bool LAKCLJJAILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1F76FD0", Offset = "0x1F755D0", VA = "0x181F76FD0")]
			internal bool OBAJAFIAILM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1F741D0", Offset = "0x1F727D0", VA = "0x181F741D0")]
			internal bool DCPPNNPDKGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F73A50", Offset = "0x1F72050", VA = "0x181F73A50")]
			internal void CJIOFJICENI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F76870", Offset = "0x1F74E70", VA = "0x181F76870")]
			internal string MLJFNMPKCHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F73520", Offset = "0x1F71B20", VA = "0x181F73520")]
			internal void BELPPJBNLJL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F76090", Offset = "0x1F74690", VA = "0x181F76090")]
			internal bool KOFCFNBMMPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F74BC0", Offset = "0x1F731C0", VA = "0x181F74BC0")]
			internal bool FAMJKOALMCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F74070", Offset = "0x1F72670", VA = "0x181F74070")]
			internal bool DCAMALJCKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F77A50", Offset = "0x1F76050", VA = "0x181F77A50")]
			internal void PNCHFEPNBGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F73F70", Offset = "0x1F72570", VA = "0x181F73F70")]
			internal bool DADKAEPJMKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F753E0", Offset = "0x1F739E0", VA = "0x181F753E0")]
			internal bool HCIFJOCBKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F770D0", Offset = "0x1F756D0", VA = "0x181F770D0")]
			internal bool ODLPODBFOEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F738C0", Offset = "0x1F71EC0", VA = "0x181F738C0")]
			internal bool CGHMBPHILKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F76CC0", Offset = "0x1F752C0", VA = "0x181F76CC0")]
			internal void NJMIAFNIAPH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F74730", Offset = "0x1F72D30", VA = "0x181F74730")]
			internal bool EAJHKLKEAEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F773C0", Offset = "0x1F759C0", VA = "0x181F773C0")]
			internal bool OPEKOOBHMOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F76910", Offset = "0x1F74F10", VA = "0x181F76910")]
			internal bool MODHGHNOJJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F75E90", Offset = "0x1F74490", VA = "0x181F75E90")]
			internal bool JPAMEMNMEKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1F75AB0", Offset = "0x1F740B0", VA = "0x181F75AB0")]
			internal void JCHIADFHCDP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F76230", Offset = "0x1F74830", VA = "0x181F76230")]
			internal bool LBCLBMHIFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F744B0", Offset = "0x1F72AB0", VA = "0x181F744B0")]
			internal bool DILLHNOLMCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F74C70", Offset = "0x1F73270", VA = "0x181F74C70")]
			internal bool FDCBJOLDFLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F74EC0", Offset = "0x1F734C0", VA = "0x181F74EC0")]
			internal bool GCONCEPJLPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F75650", Offset = "0x1F73C50", VA = "0x181F75650")]
			internal int HPBHKHECCOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F775B0", Offset = "0x1F75BB0", VA = "0x181F775B0")]
			internal void PEJGPKGMMOC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F75F80", Offset = "0x1F74580", VA = "0x181F75F80")]
			internal bool KEPAKJPCJHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F778D0", Offset = "0x1F75ED0", VA = "0x181F778D0")]
			internal bool PKGEBNJMHAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F74550", Offset = "0x1F72B50", VA = "0x181F74550")]
			internal int DKHJHAHJKLM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F77070", Offset = "0x1F75670", VA = "0x181F77070")]
			internal void OCDBODJEGHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F77830", Offset = "0x1F75E30", VA = "0x181F77830")]
			internal bool PIDLBNAHLFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F75250", Offset = "0x1F73850", VA = "0x181F75250")]
			internal bool GOGDMAPEJDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F751B0", Offset = "0x1F737B0", VA = "0x181F751B0")]
			internal int GNFFFAMFODP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F77220", Offset = "0x1F75820", VA = "0x181F77220")]
			internal void OIMMMFNDMPE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F77170", Offset = "0x1F75770", VA = "0x181F77170")]
			internal bool OFABAOGHMOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F76B50", Offset = "0x1F75150", VA = "0x181F76B50")]
			internal bool NIDLLBCBJLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F74690", Offset = "0x1F72C90", VA = "0x181F74690")]
			internal bool DNOGIAFCOKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F73E60", Offset = "0x1F72460", VA = "0x181F73E60")]
			internal int CLFNJLOJKIK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F73FC0", Offset = "0x1F725C0", VA = "0x181F73FC0")]
			internal void DAOAGECJHIF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F74A40", Offset = "0x1F73040", VA = "0x181F74A40")]
			internal bool EOBBKDLLAOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F74640", Offset = "0x1F72C40", VA = "0x181F74640")]
			internal bool DMKHCLNEMOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F739B0", Offset = "0x1F71FB0", VA = "0x181F739B0")]
			internal bool CHDOAKJHGHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F74980", Offset = "0x1F72F80", VA = "0x181F74980")]
			internal object ELBBBPBEACM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F77970", Offset = "0x1F75F70", VA = "0x181F77970")]
			internal void PLDABBCKLHK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F75F30", Offset = "0x1F74530", VA = "0x181F75F30")]
			internal bool KEGDCGBJKCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1F77D80", Offset = "0x1F76380", VA = "0x181F77D80")]
			internal bool PPDKIBPDNDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F76390", Offset = "0x1F74990", VA = "0x181F76390")]
			internal object LIDMDJBGBLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F764C0", Offset = "0x1F74AC0", VA = "0x181F764C0")]
			internal void LMAFJAOGFFB(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F75160", Offset = "0x1F73760", VA = "0x181F75160")]
			internal bool GLPPKKAAFGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F76690", Offset = "0x1F74C90", VA = "0x181F76690")]
			internal int MANFMJPGDME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F76130", Offset = "0x1F74730", VA = "0x181F76130")]
			internal void LAAKFIJBGPG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F736D0", Offset = "0x1F71CD0", VA = "0x181F736D0")]
			internal bool BLLKNMEODLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F754F0", Offset = "0x1F73AF0", VA = "0x181F754F0")]
			internal bool HFFPGGFJDEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F77320", Offset = "0x1F75920", VA = "0x181F77320")]
			internal bool OPAOANFGPDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F75FD0", Offset = "0x1F745D0", VA = "0x181F75FD0")]
			internal int KGCEBDGGEOO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F74E60", Offset = "0x1F73460", VA = "0x181F74E60")]
			internal void FOAGNHBPAML(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1F76ED0", Offset = "0x1F754D0", VA = "0x181F76ED0")]
			internal bool NOBPGIINKGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F75B70", Offset = "0x1F74170", VA = "0x181F75B70")]
			internal bool JFIHGIPNMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1F76AA0", Offset = "0x1F750A0", VA = "0x181F76AA0")]
			internal bool NGBDKMGPLKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F73480", Offset = "0x1F71A80", VA = "0x181F73480")]
			internal float APADPAMILMF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1F76AF0", Offset = "0x1F750F0", VA = "0x181F76AF0")]
			internal void NHFHMEKHJDH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1F765A0", Offset = "0x1F74BA0", VA = "0x181F765A0")]
			internal bool LNKCKJACLBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1F745F0", Offset = "0x1F72BF0", VA = "0x181F745F0")]
			internal bool DLMNCLIKECF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1F774C0", Offset = "0x1F75AC0", VA = "0x181F774C0")]
			internal bool PCDCMEGLLKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1F75430", Offset = "0x1F73A30", VA = "0x181F75430")]
			internal float HDAPBNKPPAI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1F75B10", Offset = "0x1F74110", VA = "0x181F75B10")]
			internal void JDAGEPLGOEG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1F73390", Offset = "0x1F71990", VA = "0x181F73390")]
			internal bool ALOJLKBELFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1F73E10", Offset = "0x1F72410", VA = "0x181F73E10")]
			internal bool CKLNGILOCKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1F746E0", Offset = "0x1F72CE0", VA = "0x181F746E0")]
			internal string DOOECFMPLOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1F74910", Offset = "0x1F72F10", VA = "0x181F74910")]
			internal void EJDKJKMIFNH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1F73910", Offset = "0x1F71F10", VA = "0x181F73910")]
			internal bool CGPKOCNCDJA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1F77370", Offset = "0x1F75970", VA = "0x181F77370")]
			internal bool OPCLCCKBDNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D0A0", Offset = "0x1F6B6A0", VA = "0x181F6D0A0")]
			internal bool AGEHIKNCILL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1F74F60", Offset = "0x1F73560", VA = "0x181F74F60")]
			internal bool GDKDPPDAMCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1F74320", Offset = "0x1F72920", VA = "0x181F74320")]
			internal string DFDGPIOGNIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1F76450", Offset = "0x1F74A50", VA = "0x181F76450")]
			internal void LLIKJMMDLIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1F77690", Offset = "0x1F75C90", VA = "0x181F77690")]
			internal bool PGGPCJLGDJK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F76F20", Offset = "0x1F75520", VA = "0x181F76F20")]
			internal bool NOCCBILFMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1F73820", Offset = "0x1F71E20", VA = "0x181F73820")]
			internal bool BPBMHAJOKNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1F735E0", Offset = "0x1F71BE0", VA = "0x181F735E0")]
			internal bool BIPMMPJPBHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1F758B0", Offset = "0x1F73EB0", VA = "0x181F758B0")]
			internal string IKHOFNCLFHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1F75540", Offset = "0x1F73B40", VA = "0x181F75540")]
			internal void HGCODBELDPD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1F76190", Offset = "0x1F74790", VA = "0x181F76190")]
			internal bool LAECICMJNKG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1F74410", Offset = "0x1F72A10", VA = "0x181F74410")]
			internal bool DHFKIODNNPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1F75EE0", Offset = "0x1F744E0", VA = "0x181F75EE0")]
			internal bool KEDPKLFHDOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F73630", Offset = "0x1F71C30", VA = "0x181F73630")]
			internal bool BKJFOKIAHNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D050", Offset = "0x1F6B650", VA = "0x181F6D050")]
			internal string ADJMPGOEIHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1F75840", Offset = "0x1F73E40", VA = "0x181F75840")]
			internal void IGPNAOMLPPH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1F75340", Offset = "0x1F73940", VA = "0x181F75340")]
			internal bool GPEFCNNKCOO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F732F0", Offset = "0x1F718F0", VA = "0x181F732F0")]
			internal bool ALBBHPKEDGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1F77560", Offset = "0x1F75B60", VA = "0x181F77560")]
			internal bool PCOLMBEJPAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1F74020", Offset = "0x1F72620", VA = "0x181F74020")]
			internal bool DBILMEGPFFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1F76730", Offset = "0x1F74D30", VA = "0x181F76730")]
			internal string MDHKLMJKLIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1F75950", Offset = "0x1F73F50", VA = "0x181F75950")]
			internal void IMOLMGPHGIB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1F76340", Offset = "0x1F74940", VA = "0x181F76340")]
			internal bool LDHCOPDCAKH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1F75CB0", Offset = "0x1F742B0", VA = "0x181F75CB0")]
			internal bool JJAMLOFNLHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1F733E0", Offset = "0x1F719E0", VA = "0x181F733E0")]
			internal bool AMAIDHHJLCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1F769B0", Offset = "0x1F74FB0", VA = "0x181F769B0")]
			internal bool NDLPLJLJKGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1F75BC0", Offset = "0x1F741C0", VA = "0x181F75BC0")]
			internal string JGBKLNAABJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1F74160", Offset = "0x1F72760", VA = "0x181F74160")]
			internal void DCNDPKKCGGD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1F74280", Offset = "0x1F72880", VA = "0x181F74280")]
			internal bool DDMANHDDJOA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1F75600", Offset = "0x1F73C00", VA = "0x181F75600")]
			internal bool HMOIFMNOLAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1F77410", Offset = "0x1F75A10", VA = "0x181F77410")]
			internal bool PBDFAOMOBIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1F74870", Offset = "0x1F72E70", VA = "0x181F74870")]
			internal bool EIIMKMGGDJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1F76C00", Offset = "0x1F75200", VA = "0x181F76C00")]
			internal string NJFOMCFBPKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F76280", Offset = "0x1F74880", VA = "0x181F76280")]
			internal void LBDPJFBJDEM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F76400", Offset = "0x1F74A00", VA = "0x181F76400")]
			internal bool LKDCBKODKPA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F75790", Offset = "0x1F73D90", VA = "0x181F75790")]
			internal bool ICLIPADCDBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F76D70", Offset = "0x1F75370", VA = "0x181F76D70")]
			internal bool NLIGPAKDHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1F74DC0", Offset = "0x1F733C0", VA = "0x181F74DC0")]
			internal bool FMIMHCKBJOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1F742D0", Offset = "0x1F728D0", VA = "0x181F742D0")]
			internal string DECPAPHPLEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1F74AE0", Offset = "0x1F730E0", VA = "0x181F74AE0")]
			internal void EPHIIOKIONB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1F76780", Offset = "0x1F74D80", VA = "0x181F76780")]
			internal bool MIBHCJGAIEK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1F75DF0", Offset = "0x1F743F0", VA = "0x181F75DF0")]
			internal bool JMNIPLKELDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1F75C60", Offset = "0x1F74260", VA = "0x181F75C60")]
			internal bool JIHGJMPEHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F73720", Offset = "0x1F71D20", VA = "0x181F73720")]
			internal bool BMIPCHLBJJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F77880", Offset = "0x1F75E80", VA = "0x181F77880")]
			internal string PKDCKCGIDDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F73F00", Offset = "0x1F72500", VA = "0x181F73F00")]
			internal void CPPNAENKOAA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F747D0", Offset = "0x1F72DD0", VA = "0x181F747D0")]
			internal bool EDJFMEAJBMA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F73A00", Offset = "0x1F72000", VA = "0x181F73A00")]
			internal bool CHIMFHEMOHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F74F10", Offset = "0x1F73510", VA = "0x181F74F10")]
			internal bool GDCGDOLGLHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F75900", Offset = "0x1F73F00", VA = "0x181F75900")]
			internal bool ILAFMIPJMJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F756F0", Offset = "0x1F73CF0", VA = "0x181F756F0")]
			internal string ICHBEGFCMIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F76020", Offset = "0x1F74620", VA = "0x181F76020")]
			internal void KMLEJHJIFHE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F75D00", Offset = "0x1F74300", VA = "0x181F75D00")]
			internal bool JKPFBJFLBMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F748C0", Offset = "0x1F72EC0", VA = "0x181F748C0")]
			internal bool EJBAJKJAJGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F745A0", Offset = "0x1F72BA0", VA = "0x181F745A0")]
			internal bool DLHNLAMPDPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F734D0", Offset = "0x1F71AD0", VA = "0x181F734D0")]
			internal string BEDMJCMHLMC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F76C50", Offset = "0x1F75250", VA = "0x181F76C50")]
			internal void NJLJLEECBBM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F77640", Offset = "0x1F75C40", VA = "0x181F77640")]
			internal bool PFMDMNEKEKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1F777E0", Offset = "0x1F75DE0", VA = "0x181F777E0")]
			internal bool PIAILGCODDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1F740C0", Offset = "0x1F726C0", VA = "0x181F740C0")]
			internal bool DCBAFLLEBMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1F75A10", Offset = "0x1F74010", VA = "0x181F75A10")]
			internal string IPFNIEJPNIH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1F74B50", Offset = "0x1F73150", VA = "0x181F74B50")]
			internal void FALKMCLKIKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1F74D10", Offset = "0x1F73310", VA = "0x181F74D10")]
			internal bool FLBFPAIFIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1F75110", Offset = "0x1F73710", VA = "0x181F75110")]
			internal bool GLAMEDAKADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1F73960", Offset = "0x1F71F60", VA = "0x181F73960")]
			internal bool CHCMNFBFKPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1F76D20", Offset = "0x1F75320", VA = "0x181F76D20")]
			internal string NKLIJBEBCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F750A0", Offset = "0x1F736A0", VA = "0x181F750A0")]
			internal void GKBOLJGPDKC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F762F0", Offset = "0x1F748F0", VA = "0x181F762F0")]
			internal bool LCJCPAGAGDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F732A0", Offset = "0x1F718A0", VA = "0x181F732A0")]
			internal bool AJGJADNNKMJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F74FB0", Offset = "0x1F735B0", VA = "0x181F74FB0")]
			internal float GEBHOEBMHAM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1F771C0", Offset = "0x1F757C0", VA = "0x181F771C0")]
			internal void OFEFEOENOHN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1F74500", Offset = "0x1F72B00", VA = "0x181F74500")]
			internal bool DJDCNBCCNGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1F75DA0", Offset = "0x1F743A0", VA = "0x181F75DA0")]
			internal bool JLLLJJEMJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1F743C0", Offset = "0x1F729C0", VA = "0x181F743C0")]
			internal bool DFJACGBHKLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1F75D50", Offset = "0x1F74350", VA = "0x181F75D50")]
			internal int JLFPMKBLLPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F73770", Offset = "0x1F71D70", VA = "0x181F73770")]
			internal void BMLCNHLKGID(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1F74A90", Offset = "0x1F73090", VA = "0x181F74A90")]
			internal bool EOIIGBPIIFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1F755B0", Offset = "0x1F73BB0", VA = "0x181F755B0")]
			internal bool HHIKBHCFKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1F75390", Offset = "0x1F73990", VA = "0x181F75390")]
			internal bool HCFDHELMLOA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class BCPNGEOGKCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GKCHPCIOBFA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public BCPNGEOGKCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1F65D20", Offset = "0x1F64320", VA = "0x181F65D20")]
			internal void NOINPBPCOHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class ANKMHEJMLCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public ANKMHEJMLCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1F65A70", Offset = "0x1F64070", VA = "0x181F65A70")]
			internal bool KCHHBDMFHEO(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly GEOEJKJFPIP JEGDACJMHJK;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F7F7D0", Offset = "0x1F7DDD0", VA = "0x181F7F7D0")]
		public MINONEPGMEP(JOOJDMJJLEH KHALMCHEKDD, OGGCHEHFLEB MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D9F0", Offset = "0x1F7BFF0", VA = "0x181F7D9F0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class KGLBMNHOHAF : FLHJOEBGJCE<BMPCIECJHMI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DMOFFCDKNAD
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
				public DMOFFCDKNAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1F9E6F0", Offset = "0x1F9CCF0", VA = "0x181F9E6F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public KGLBMNHOHAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public DMOFFCDKNAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F8C550", Offset = "0x1F8AB50", VA = "0x181F8C550")]
			internal string COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F8C5F0", Offset = "0x1F8ABF0", VA = "0x181F8C5F0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PNOMNBKFDEO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F8C5A0", Offset = "0x1F8ABA0", VA = "0x181F8C5A0")]
			internal int GNBJLDAOBME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F8C4C0", Offset = "0x1F8AAC0", VA = "0x181F8C4C0")]
			internal void BIBKJJFHCPP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B8A0", Offset = "0x1F99EA0", VA = "0x181F9B8A0")]
		public KGLBMNHOHAF(JOOJDMJJLEH KHALMCHEKDD, BMPCIECJHMI LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B550", Offset = "0x1F99B50", VA = "0x181F9B550", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class BALHFJJMHPJ : FLHJOEBGJCE<MLDDHOIHBNK>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class JFOGDJBKMAK
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
				public JFOGDJBKMAK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1F9EA00", Offset = "0x1F9D000", VA = "0x181F9EA00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
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
				public JFOGDJBKMAK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1F9ED40", Offset = "0x1F9D340", VA = "0x181F9ED40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public BALHFJJMHPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JFOGDJBKMAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F99D90", Offset = "0x1F98390", VA = "0x181F99D90")]
			internal string COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A260", Offset = "0x1F98860", VA = "0x181F9A260")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PNOMNBKFDEO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F99F90", Offset = "0x1F98590", VA = "0x181F99F90")]
			internal int GNBJLDAOBME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F99D00", Offset = "0x1F98300", VA = "0x181F99D00")]
			internal void BIBKJJFHCPP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A070", Offset = "0x1F98670", VA = "0x181F9A070")]
			internal string JHIMGCOAKHK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F99EC0", Offset = "0x1F984C0", VA = "0x181F99EC0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void GEFCJOJKENH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A110", Offset = "0x1F98710", VA = "0x181F9A110")]
			internal bool NJDLMJNFPFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F99DE0", Offset = "0x1F983E0", VA = "0x181F99DE0")]
			internal void EGEJICJNDOM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F99E70", Offset = "0x1F98470", VA = "0x181F99E70")]
			internal bool EKFEIHIDAOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A1D0", Offset = "0x1F987D0", VA = "0x181F9A1D0")]
			internal void PHGCDCHIGEL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A0C0", Offset = "0x1F986C0", VA = "0x181F9A0C0")]
			internal float NFPAOECPANG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F99FE0", Offset = "0x1F985E0", VA = "0x181F99FE0")]
			internal void IEJPHFBPPGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F99CA0", Offset = "0x1F982A0", VA = "0x181F99CA0")]
			internal int BCHLAGBPAOD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F99C00", Offset = "0x1F98200", VA = "0x181F99C00")]
			internal void AKJFIBKILEF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A160", Offset = "0x1F98760", VA = "0x181F9A160")]
			internal bool OJFPODJBBEB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AB70", Offset = "0x1F89170", VA = "0x181F8AB70")]
		public BALHFJJMHPJ(JOOJDMJJLEH KHALMCHEKDD, MLDDHOIHBNK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F8A130", Offset = "0x1F88730", VA = "0x181F8A130", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class FPLKKFEJAFA : FLHJOEBGJCE<NEJEHJCKHKA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KOFGFFDOMFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public FPLKKFEJAFA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public KOFGFFDOMFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C050", Offset = "0x1F9A650", VA = "0x181F9C050")]
			internal Dictionary<string, HGBNDFBPIAF> COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C210", Offset = "0x1F9A810", VA = "0x181F9C210")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C0F0", Offset = "0x1F9A6F0", VA = "0x181F9C0F0")]
			internal void GNBJLDAOBME(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BFD0", Offset = "0x1F9A5D0", VA = "0x181F9BFD0")]
			internal bool BIBKJJFHCPP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F520", Offset = "0x1F8DB20", VA = "0x181F8F520")]
		public FPLKKFEJAFA(JOOJDMJJLEH KHALMCHEKDD, NEJEHJCKHKA LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F280", Offset = "0x1F8D880", VA = "0x181F8F280", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class PGJDPILMJIC : FLHJOEBGJCE<FEAFFPGJBDD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E200", Offset = "0x1F9C800", VA = "0x181F9E200")]
		public PGJDPILMJIC(JOOJDMJJLEH KHALMCHEKDD, FEAFFPGJBDD LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E110", Offset = "0x1F9C710", VA = "0x181F9E110", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DFF0", Offset = "0x1F9C5F0", VA = "0x181F9DFF0")]
		[CompilerGenerated]
		private void GINCKELINAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class IBPNADGLHJI : EICHAAEOEKA<IJOLMLDMCDE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CEBICBBGCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool CMJPIMKNEDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F92BA0", Offset = "0x1F911A0", VA = "0x181F92BA0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9B0", Offset = "0x8DCFB0", VA = "0x1808DE9B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F92B40", Offset = "0x1F91140", VA = "0x181F92B40")]
		public IBPNADGLHJI(JOOJDMJJLEH KHALMCHEKDD, IJOLMLDMCDE MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class ELHGBJKADBO : FLHJOEBGJCE<CKNFPAFGLGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDA0", Offset = "0x8CE3A0", VA = "0x1808CFDA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F8DCC0", Offset = "0x1F8C2C0", VA = "0x181F8DCC0")]
		public ELHGBJKADBO(JOOJDMJJLEH KHALMCHEKDD, CKNFPAFGLGJ MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class HJGOKPJHNAG : FLHJOEBGJCE<PBIMOALIPCA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D3060", Offset = "0x8D1660", VA = "0x1808D3060", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F92880", Offset = "0x1F90E80", VA = "0x181F92880")]
		public HJGOKPJHNAG(JOOJDMJJLEH KHALMCHEKDD, PBIMOALIPCA MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "112")]
		protected override bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class EPDLEEBDFFK : FLHJOEBGJCE<PCMCOBBJNFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC510", Offset = "0x8CAB10", VA = "0x1808CC510", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F8DDA0", Offset = "0x1F8C3A0", VA = "0x181F8DDA0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F8DD30", Offset = "0x1F8C330", VA = "0x181F8DD30")]
		public EPDLEEBDFFK(JOOJDMJJLEH KHALMCHEKDD, PCMCOBBJNFH MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GAAIHJIBKMM : FLHJOEBGJCE<AJJNJJBOONH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D95E0", Offset = "0x8D7BE0", VA = "0x1808D95E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F670", Offset = "0x1F8DC70", VA = "0x181F8F670", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F600", Offset = "0x1F8DC00", VA = "0x181F8F600")]
		public GAAIHJIBKMM(JOOJDMJJLEH KHALMCHEKDD, AJJNJJBOONH MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class MAFGCIAIDBK : DMEMDLIDPNO<EPELEPELPGL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class CFOFNDPLLEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public MAFGCIAIDBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public CFOFNDPLLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F8BA40", Offset = "0x1F8A040", VA = "0x181F8BA40")]
			internal float DGFKBIDOBHC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F8BAC0", Offset = "0x1F8A0C0", VA = "0x181F8BAC0")]
			internal void PEMCEBMGGDF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CDC0", Offset = "0x1F9B3C0", VA = "0x181F9CDC0")]
		public MAFGCIAIDBK(JOOJDMJJLEH KHALMCHEKDD, EPELEPELPGL LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CB40", Offset = "0x1F9B140", VA = "0x181F9CB40", Slot = "126")]
		protected override void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class ADIJHIDGFFD : FLHJOEBGJCE<ALLGOEAPGKF>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class PNOEAJLHBBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public ADIJHIDGFFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public PNOEAJLHBBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E270", Offset = "0x1F9C870", VA = "0x181F9E270")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E2C0", Offset = "0x1F9C8C0", VA = "0x181F9E2C0")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F85040", Offset = "0x1F83640", VA = "0x181F85040")]
		public ADIJHIDGFFD(JOOJDMJJLEH KHALMCHEKDD, ALLGOEAPGKF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F84D90", Offset = "0x1F83390", VA = "0x181F84D90", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class CDAKCPFLGGK : FLHJOEBGJCE<NBDPFAKPJMN>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class KBHMLAOIPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CDAKCPFLGGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public KBHMLAOIPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F9AA20", Offset = "0x1F99020", VA = "0x181F9AA20")]
			internal object COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F9AB50", Offset = "0x1F99150", VA = "0x181F9AB50")]
			internal bool EGEJICJNDOM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9AF10", Offset = "0x1F99510", VA = "0x181F9AF10")]
			internal void PNOMNBKFDEO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F9AC20", Offset = "0x1F99220", VA = "0x181F9AC20")]
			internal string GNBJLDAOBME(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A9D0", Offset = "0x1F98FD0", VA = "0x181F9A9D0")]
			internal IReadOnlyList<object> BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9AD80", Offset = "0x1F99380", VA = "0x181F9AD80")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9ABD0", Offset = "0x1F991D0", VA = "0x181F9ABD0")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9ADF0", Offset = "0x1F993F0", VA = "0x181F9ADF0")]
			internal void NJDLMJNFPFI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F8B620", Offset = "0x1F89C20", VA = "0x181F8B620")]
		public CDAKCPFLGGK(JOOJDMJJLEH KHALMCHEKDD, NBDPFAKPJMN LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AE20", Offset = "0x1F89420", VA = "0x181F8AE20", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class OJIMABNJCGO : FHGFOKLDGKI<BECCNMHEIMA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA40F0", Offset = "0xAA26F0", VA = "0x180AA40F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D750", Offset = "0x1F9BD50", VA = "0x181F9D750")]
		public OJIMABNJCGO(JOOJDMJJLEH KHALMCHEKDD, BECCNMHEIMA MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class AMMGMMKBJLK : DMEMDLIDPNO<CMKLNOPPKLI>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class BONDFOGIBPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public AMMGMMKBJLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public BONDFOGIBPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F8AD00", Offset = "0x1F89300", VA = "0x181F8AD00")]
			internal int DGFKBIDOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F8AD80", Offset = "0x1F89380", VA = "0x181F8AD80")]
			internal void PEMCEBMGGDF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F85740", Offset = "0x1F83D40", VA = "0x181F85740")]
		public AMMGMMKBJLK(JOOJDMJJLEH KHALMCHEKDD, CMKLNOPPKLI LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F854B0", Offset = "0x1F83AB0", VA = "0x181F854B0", Slot = "126")]
		protected override void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class IAONDPKNJKN : FLHJOEBGJCE<CLGIKLJIANF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class CPLJEOHOCNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public IAONDPKNJKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public CPLJEOHOCNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F8BF30", Offset = "0x1F8A530", VA = "0x181F8BF30")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1F8BF80", Offset = "0x1F8A580", VA = "0x181F8BF80")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F92AD0", Offset = "0x1F910D0", VA = "0x181F92AD0")]
		public IAONDPKNJKN(JOOJDMJJLEH KHALMCHEKDD, CLGIKLJIANF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F928F0", Offset = "0x1F90EF0", VA = "0x181F928F0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class CMGBLKBJIJM : FLHJOEBGJCE<CIHCGEGMHGF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class EBLDBABFOPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CMGBLKBJIJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public EBLDBABFOPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1F8CB70", Offset = "0x1F8B170", VA = "0x181F8CB70")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1F8CBC0", Offset = "0x1F8B1C0", VA = "0x181F8CBC0")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1F8BEC0", Offset = "0x1F8A4C0", VA = "0x181F8BEC0")]
		public CMGBLKBJIJM(JOOJDMJJLEH KHALMCHEKDD, CIHCGEGMHGF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1F8BCE0", Offset = "0x1F8A2E0", VA = "0x181F8BCE0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FKNBHPDENBI : FLHJOEBGJCE<OLBLCDEKNDO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class GEJJABJNNPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public FKNBHPDENBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public GEJJABJNNPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x1F917A0", Offset = "0x1F8FDA0", VA = "0x181F917A0")]
			internal int COFCJKDJKKN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1F917F0", Offset = "0x1F8FDF0", VA = "0x181F917F0")]
			internal void PNOMNBKFDEO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EF60", Offset = "0x1F8D560", VA = "0x181F8EF60")]
		public FKNBHPDENBI(JOOJDMJJLEH KHALMCHEKDD, OLBLCDEKNDO LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1F8ED00", Offset = "0x1F8D300", VA = "0x181F8ED00", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class PCBLINKKEMD : EAHKPFBPIMN<PBGOOGEJMDE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override OMLMKPNJFBP DEKNNDMEDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DF90", Offset = "0x1F9C590", VA = "0x181F9DF90")]
		public PCBLINKKEMD(JOOJDMJJLEH KHALMCHEKDD, PBGOOGEJMDE LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class GKANKGNJGEH : FLHJOEBGJCE<CDJIOCDEIML>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F590", Offset = "0x1F8DB90", VA = "0x181F8F590")]
		public GKANKGNJGEH(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public abstract class FLHJOEBGJCE<TNode> : KIEKNELDHJG, IDisposable where TNode : notnull, CDJIOCDEIML
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class KFNLMJCIOFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public FLHJOEBGJCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public JOOJDMJJLEH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public KFNLMJCIOFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x41F6D80", Offset = "0x41F5380", VA = "0x1841F6D80")]
			internal IJENMLPPGDM MAMACJIKHMP(JLKIADPGAEH portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private struct MLFKKHAJBCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public FLHJOEBGJCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x44DA2E0", Offset = "0x44D88E0", VA = "0x1844DA2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct OEPBIJAIMGA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public FLHJOEBGJCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public LPFLGIOMHPC? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public PKPOPCCMEJH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x466A5E0", Offset = "0x4668BE0", VA = "0x18466A5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x466A890", Offset = "0x4668E90", VA = "0x18466A890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class GJMIIBAJNNJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008D")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public GJMIIBAJNNJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x3541E30", Offset = "0x3540430", VA = "0x183541E30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public FLHJOEBGJCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public FCJJHIHCGFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public GJMIIBAJNNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			internal string AJEFLFLHANK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
			internal void EOELMDKLAKO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x3D30190", Offset = "0x3D2E790", VA = "0x183D30190")]
			[AsyncStateMachine(typeof(FLHJOEBGJCE<>.GJMIIBAJNNJ.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void PKPMGLDADMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class LHDIDKIIPCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LHDIDKIIPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x42B8780", Offset = "0x42B6D80", VA = "0x1842B8780")]
			internal bool OGPPHJCFFBP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x42B8770", Offset = "0x42B6D70", VA = "0x1842B8770")]
			internal bool KIBLMFMAMLD(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct IFAKDFCEJNK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public FLHJOEBGJCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3EA9C80", Offset = "0x3EA8280", VA = "0x183EA9C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3EAA010", Offset = "0x3EA8610", VA = "0x183EAA010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly JOOJDMJJLEH MKHFBHMOMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly bool KNIPLAFECMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private AOFPDBAMMHL<LMECHAAEJCH, IJENMLPPGDM> NBOHOGEFOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private AOFPDBAMMHL<LMECHAAEJCH, JHMJLMFOOPE> PLGCENIJFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private List<Action> NNBCCBBLFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[CompilerGenerated]
		private Action<HBKKMIFHCOI<LMECHAAEJCH>>? GKCJILNJJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[CompilerGenerated]
		private Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE>? CAMNEOEHFBO;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected BGBOPJIEMLP NIHBMHBFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x3C4F490", Offset = "0x3C4DA90", VA = "0x183C4F490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected DKIELNKLCBA EJNKFCIJBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3C50710", Offset = "0x3C4ED10", VA = "0x183C50710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode CAENIKMKAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public DAMOFJGJNKL<BBDJCOABDOK> BMACCBGMHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xB0DA30", Offset = "0xB0C030", VA = "0x180B0DA30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DAMOFJGJNKL<BBDJCOABDOK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public HBKKMIFHCOI<ACKBLKMLNKG> HEKKBFGJAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3C539D0", Offset = "0x3C51FD0", VA = "0x183C539D0", Slot = "6")]
			get
			{
				return default(HBKKMIFHCOI<ACKBLKMLNKG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object EJOMCAPLLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x37F7470", Offset = "0x37F5A70", VA = "0x1837F7470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool AHBMPDLOFPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int POKBFINKFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x3C53600", Offset = "0x3C51C00", VA = "0x183C53600", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GEANJACADNF DJDACLDIAFI
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x3C535A0", Offset = "0x3C51BA0", VA = "0x183C535A0", Slot = "10")]
			get
			{
				return default(GEANJACADNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string POMKDKLHHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3C53B90", Offset = "0x3C52190", VA = "0x183C53B90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public HBKKMIFHCOI<OEOGDBHPCHJ> PCNJLMIMPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x92F230", Offset = "0x92D830", VA = "0x18092F230", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(HBKKMIFHCOI<OEOGDBHPCHJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xB0AF80", Offset = "0xB09580", VA = "0x180B0AF80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool CEBICBBGCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NMDEKEINGII HGHKCAMHGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA740A0", VA = "0x180A75AA0", Slot = "94")]
			get
			{
				return default(NMDEKEINGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IOCOFHABPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x3C532B0", Offset = "0x3C518B0", VA = "0x183C532B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool FDDIHMHFJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x3C53320", Offset = "0x3C51920", VA = "0x183C53320", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool AODAIAKKAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3C53390", Offset = "0x3C51990", VA = "0x183C53390", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int IACDEADEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3C53970", Offset = "0x3C51F70", VA = "0x183C53970", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AEEFIPIEGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3C53790", Offset = "0x3C51D90", VA = "0x183C53790", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool NNPNMPPDFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3C534C0", Offset = "0x3C51AC0", VA = "0x183C534C0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MAPNPIOBIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3C53450", Offset = "0x3C51A50", VA = "0x183C53450", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool ACAFIJCIKII
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xC5D420", Offset = "0xC5BA20", VA = "0x180C5D420", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xC5D160", Offset = "0xC5B760", VA = "0x180C5D160")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KFFGLPIPNOA
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CIHHBIDNOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3C53400", Offset = "0x3C51A00", VA = "0x183C53400", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool FOJADCDDGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3C536C0", Offset = "0x3C51CC0", VA = "0x183C536C0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public LPFLGIOMHPC ABAOOCCJCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3C538B0", Offset = "0x3C51EB0", VA = "0x183C538B0", Slot = "28")]
			get
			{
				return default(LPFLGIOMHPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public PKPOPCCMEJH JHHONLHGLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x3C53910", Offset = "0x3C51F10", VA = "0x183C53910", Slot = "30")]
			get
			{
				return default(PKPOPCCMEJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KACNEOHIMLB
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual AAJCICADOFI? NOFFJKCFMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual GFLPNBNPAIM? PJKMBCEHFDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>>? JFBAEOIGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool NKDLCCBOPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x3C53530", Offset = "0x3C51B30", VA = "0x183C53530", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3C537F0", Offset = "0x3C51DF0", VA = "0x183C537F0", Slot = "62")]
			get
			{
				return default(DAMOFJGJNKL<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public HBKKMIFHCOI<EKJMGNHJFDN> HLPKLNNHMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3C53660", Offset = "0x3C51C60", VA = "0x183C53660", Slot = "56")]
			get
			{
				return default(HBKKMIFHCOI<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool HCINIAEOGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual HBKKMIFHCOI<EKJMGNHJFDN>? JPIPEBHBNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool CMJPIMKNEDF
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NBAKPCNLLOP
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x3C53720", Offset = "0x3C51D20", VA = "0x183C53720", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x868A10", Offset = "0x867010", VA = "0x180868A10", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x868B10", Offset = "0x867110", VA = "0x180868B10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string LEGKCFALMHM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x868AC0", Offset = "0x8670C0", VA = "0x180868AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3C53850", Offset = "0x3C51E50", VA = "0x183C53850", Slot = "63")]
			get
			{
				return default(DAMOFJGJNKL<JMIDFPKEEGG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DAMOFJGJNKL<JMIDFPKEEGG>? NBCANKBLKKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3C53A60", Offset = "0x3C52060", VA = "0x183C53A60", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ANJPNODIDCK<LMECHAAEJCH, JHMJLMFOOPE> ILPAPNCMHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x3C53B50", Offset = "0x3C52150", VA = "0x183C53B50", Slot = "65")]
			get
			{
				return default(ANJPNODIDCK<LMECHAAEJCH, JHMJLMFOOPE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool BIEGNHBACOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool PJKCCNEJEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CCDDIDLHHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x3C527D0", Offset = "0x3C50DD0", VA = "0x183C527D0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3C517D0", Offset = "0x3C4FDD0", VA = "0x183C517D0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KGOMHBDJPFD BHPPPIGIAKK
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3C52A60", Offset = "0x3C51060", VA = "0x183C52A60", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3C510D0", Offset = "0x3C4F6D0", VA = "0x183C510D0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LGJGPNLKKME GFKJLEBHEDG
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3C50D60", Offset = "0x3C4F360", VA = "0x183C50D60", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3C51870", Offset = "0x3C4FE70", VA = "0x183C51870", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GJMGNPINCEK
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3C50030", Offset = "0x3C4E630", VA = "0x183C50030", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3C4E8C0", Offset = "0x3C4CEC0", VA = "0x183C4E8C0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CHIOEGACKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3C4FE10", Offset = "0x3C4E410", VA = "0x183C4FE10", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3C51430", Offset = "0x3C4FA30", VA = "0x183C51430", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> MKGDMGJBAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x3C519E0", Offset = "0x3C4FFE0", VA = "0x183C519E0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x3C524B0", Offset = "0x3C50AB0", VA = "0x183C524B0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> OLLNBMEDJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x3C4E020", Offset = "0x3C4C620", VA = "0x183C4E020", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3C4F5B0", Offset = "0x3C4DBB0", VA = "0x183C4F5B0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>> CHHMIOGLAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3C4E990", Offset = "0x3C4CF90", VA = "0x183C4E990", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3C51BD0", Offset = "0x3C501D0", VA = "0x183C51BD0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, HBKKMIFHCOI<LMECHAAEJCH>> AGNPKBPMOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3C52870", Offset = "0x3C50E70", VA = "0x183C52870", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x3C50CA0", Offset = "0x3C4F2A0", VA = "0x183C50CA0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> GFHFFBDLBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3C4FEB0", Offset = "0x3C4E4B0", VA = "0x183C4FEB0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3C4F4F0", Offset = "0x3C4DAF0", VA = "0x183C4F4F0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, HBKKMIFHCOI<LMECHAAEJCH>> BMDAHOHBJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3C50E00", Offset = "0x3C4F400", VA = "0x183C50E00", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3C4FF70", Offset = "0x3C4E570", VA = "0x183C4FF70", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x3C52CA0", Offset = "0x3C512A0", VA = "0x183C52CA0")]
		[NONNNOEJCPN("Need to handle `Name` better.")]
		[NONNNOEJCPN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected FLHJOEBGJCE(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG, bool JMNMBLFPBOD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E0E0", Offset = "0x3C4C6E0", VA = "0x183C4E0E0", Slot = "87")]
		protected virtual void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EBB0", Offset = "0x3C4D1B0", VA = "0x183C4EBB0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3C4DF50", Offset = "0x3C4C550", VA = "0x183C4DF50", Slot = "9")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.MLFKKHAJBCD))]
		public void AINAAPPNLAF(int KJFBCKFCKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4F4C0", VA = "0x183C50EC0")]
		public bool INCGLEKKCJO([In] LPFLGIOMHPC CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E850", Offset = "0x3C4CE50", VA = "0x183C4E850")]
		public bool CDDPLBACIAG([In] PKPOPCCMEJH CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3C51D90", Offset = "0x3C50390", VA = "0x183C51D90", Slot = "32")]
		public void NDBAOJBIBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3C52B50", Offset = "0x3C51150", VA = "0x183C52B50", Slot = "33")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.OEPBIJAIMGA))]
		public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> PMMFCKLNPLI(LPFLGIOMHPC? DCBNBHMBGKP, PKPOPCCMEJH? JAFBJNOBENG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "97")]
		public virtual void AACONAFIOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "98")]
		public virtual void LGFMHLMHBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "99")]
		public virtual void LECBEDAALCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1D28470", Offset = "0x1D26A70", VA = "0x181D28470")]
		protected void BJEGDEIDJBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F800", Offset = "0x3C4DE00", VA = "0x183C4F800")]
		protected void EMGBBNJOOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x217DD60", Offset = "0x217C360", VA = "0x18217DD60")]
		private void JCLFLCBMFEI([In] PKPOPCCMEJH ADNGPFKNGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3C51910", Offset = "0x3C4FF10", VA = "0x183C51910", Slot = "100")]
		public virtual Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3C50100", Offset = "0x3C4E700", VA = "0x183C50100", Slot = "101")]
		public virtual Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GPOOPJANOMH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "102")]
		public virtual void PDNKLEKFEGM(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3C50C10", Offset = "0x3C4F210", VA = "0x183C50C10", Slot = "103")]
		public virtual IEnumerable<LHAEFPHAKAB> HMCEGJOBJAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3C52420", Offset = "0x3C50A20", VA = "0x183C52420", Slot = "104")]
		public PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE> NKDMCEHBLOH(string MFOBCFPKPKP)
		{
			return default(PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EA50", Offset = "0x3C4D050", VA = "0x183C4EA50", Slot = "47")]
		public bool DGJBENPCBHM([Out] Guid JDNABOPHHBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3C51170", Offset = "0x3C4F770", VA = "0x183C51170")]
		public bool KBFLFDOLLAP([In] Guid KJEGAEAMNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "105")]
		public virtual void FDHFDDAAOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "106")]
		public virtual void HFENOCLBOPM(bool PKFFHGLMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "107")]
		public virtual APFHLPOFLMK BDCCOPBMKJL([In] LHGEAJIDJBF DBDAMLBKEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FBD0", Offset = "0x3C4E1D0", VA = "0x183C4FBD0")]
		protected void FCFFKFNCFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x3C51090", Offset = "0x3C4F690", VA = "0x183C51090", Slot = "112")]
		protected virtual bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "113")]
		protected virtual bool HPIHPMEFIMM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected virtual void HBCAHGJBAAI(FCJJHIHCGFA JIJOFMDFCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3C52010", Offset = "0x3C50610", VA = "0x183C52010")]
		protected void NJDGGBPAEHP(FCJJHIHCGFA AABAOMBBJAL, Func<string> AJEMMDJDICO, Action<string> KAJDEFJNFGP, string KIJDCDFNLDM, string PCECBJNMEJC, string NGAPPCIMKFK, OKMACKCCIOE NNGIMKJCHNJ, KHOFHMDHGEA BCBBPGNLPIM, Func<string, bool> PGHEIKLABPM, string CPEDPHLDPGC, Func<string, bool> DMGLHFHDNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3C514D0", Offset = "0x3C4FAD0", VA = "0x183C514D0")]
		protected void LAFCOAIJEPO(FCJJHIHCGFA AABAOMBBJAL, Func<string> AJEMMDJDICO, Action<string> KAJDEFJNFGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3C52570", Offset = "0x3C50B70", VA = "0x183C52570", Slot = "121")]
		protected virtual void OBELONDCEKE(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3C52B00", Offset = "0x3C51100", VA = "0x183C52B00", Slot = "80")]
		public void PKPMOKLBCIG(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3C51C90", Offset = "0x3C50290", VA = "0x183C51C90", Slot = "81")]
		public DEFEBGKBMOG MFPAFOKONNM()
		{
			return default(DEFEBGKBMOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "124")]
		public virtual bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x13EFF10", Offset = "0x13EE510", VA = "0x1813EFF10")]
		private void CPANAHEDOJC([In] LPFLGIOMHPC MOIICCIPACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3C50F30", Offset = "0x3C4F530", VA = "0x183C50F30")]
		private void JGGKGGKGPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3C501D0", Offset = "0x3C4E7D0", VA = "0x183C501D0")]
		private void HDLJLPPKKDC(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH BNCODIOLIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1E61270", Offset = "0x1E5F870", VA = "0x181E61270")]
		private void CMACKKGKJDF(HBKKMIFHCOI<LMECHAAEJCH> BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3C52930", Offset = "0x3C50F30", VA = "0x183C52930")]
		private void OLAIDNIKPBL(HBKKMIFHCOI<LMECHAAEJCH> BLCJLIJFBDL, JLKIADPGAEH KPGBFLPHOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F820", Offset = "0x3C4DE20", VA = "0x183C4F820")]
		private void FAGAMOIGGLE(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1E611F0", Offset = "0x1E5F7F0", VA = "0x181E611F0")]
		private void DDHLLNAICPE(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E000", Offset = "0x3C4C600", VA = "0x183C4E000")]
		private void ALOKMMNPPDL(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3C50800", Offset = "0x3C4EE00", VA = "0x183C50800")]
		private void HKIEOHFNNDH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH BNCODIOLIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F790", Offset = "0x3C4DD90", VA = "0x183C4F790")]
		private void EHFMAJPDJEF(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH KPGBFLPHOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F670", Offset = "0x3C4DC70", VA = "0x183C4F670", Slot = "125")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.IFAKDFCEJNK))]
		public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> EHBMLGHJPOC(string MFOBCFPKPKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E920", Offset = "0x3C4CF20", VA = "0x183C4E920", Slot = "54")]
		private void CIDPPOEODDE(object AMHCGCDJMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x3C51FA0", Offset = "0x3C505A0", VA = "0x183C51FA0", Slot = "55")]
		private void NEPOLNDLDHP(object AMHCGCDJMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x3C51AE0", Offset = "0x3C500E0", VA = "0x183C51AE0", Slot = "29")]
		private bool MCJDLHDLJFA([In] LPFLGIOMHPC CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FDD0", Offset = "0x3C4E3D0", VA = "0x183C4FDD0", Slot = "31")]
		private bool FFNAAJLPHIM([In] PKPOPCCMEJH CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3C51AA0", Offset = "0x3C500A0", VA = "0x183C51AA0", Slot = "48")]
		private bool LLMKCMJMEDL([In] Guid KJEGAEAMNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3C52790", Offset = "0x3C50D90", VA = "0x183C52790")]
		[CompilerGenerated]
		private string OFMBAMGABMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3C51B20", Offset = "0x3C50120", VA = "0x183C51B20")]
		[CompilerGenerated]
		private void MEAAKEIOMJG(string LCLKDNPLMED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class NCNCOJGCOOE : FHGFOKLDGKI<FCPCOHKHOGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xCC2A90", Offset = "0xCC1090", VA = "0x180CC2A90", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CE20", Offset = "0x1F9B420", VA = "0x181F9CE20")]
		public NCNCOJGCOOE(JOOJDMJJLEH KHALMCHEKDD, FCPCOHKHOGJ MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private sealed class GKMNCBOABFN : EICHAAEOEKA<KGCAOGAEKDB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1F91D50", Offset = "0x1F90350", VA = "0x181F91D50")]
		public GKMNCBOABFN(JOOJDMJJLEH KHALMCHEKDD, KGCAOGAEKDB MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public abstract class EAHKPFBPIMN<T> : FLHJOEBGJCE<T> where T : notnull, PIKNDFHEMDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class LMJNMGGFFMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public IReadOnlyList<KeyValuePair<string, HGBNDFBPIAF>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public EAHKPFBPIMN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public OMLMKPNJFBP clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LMJNMGGFFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			internal IReadOnlyList<KeyValuePair<string, HGBNDFBPIAF>> COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x42D8AE0", Offset = "0x42D70E0", VA = "0x1842D8AE0")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x42D8540", Offset = "0x42D6B40", VA = "0x1842D8540")]
			internal void GNBJLDAOBME(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x42D8400", Offset = "0x42D6A00", VA = "0x1842D8400")]
			internal void BIBKJJFHCPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x42D8820", Offset = "0x42D6E20", VA = "0x1842D8820")]
			internal void JHIMGCOAKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x42D8450", Offset = "0x42D6A50", VA = "0x1842D8450")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x42D89D0", Offset = "0x42D6FD0", VA = "0x1842D89D0")]
			internal void NJDLMJNFPFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x42D8450", Offset = "0x42D6A50", VA = "0x1842D8450")]
			internal bool EGEJICJNDOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x42D84E0", Offset = "0x42D6AE0", VA = "0x1842D84E0")]
			internal float EKFEIHIDAOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x42D8A20", Offset = "0x42D7020", VA = "0x1842D8A20")]
			internal void PHGCDCHIGEL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x42D8970", Offset = "0x42D6F70", VA = "0x1842D8970")]
			internal float NFPAOECPANG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x42D8760", Offset = "0x42D6D60", VA = "0x1842D8760")]
			internal void IEJPHFBPPGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x42D83A0", Offset = "0x42D69A0", VA = "0x1842D83A0")]
			internal float BCHLAGBPAOD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x42D82E0", Offset = "0x42D68E0", VA = "0x1842D82E0")]
			internal void AKJFIBKILEF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC910", Offset = "0x8CAF10", VA = "0x1808CC910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract OMLMKPNJFBP DEKNNDMEDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x37C4CC0", Offset = "0x37C32C0", VA = "0x1837C4CC0")]
		public EAHKPFBPIMN(JOOJDMJJLEH KHALMCHEKDD, T MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x37C41A0", Offset = "0x37C27A0", VA = "0x1837C41A0", Slot = "120")]
		protected sealed override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class LPHDIGGIBFL : FLHJOEBGJCE<GKIEFGJCJKF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x92B9D0", Offset = "0x929FD0", VA = "0x18092B9D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CAD0", Offset = "0x1F9B0D0", VA = "0x181F9CAD0")]
		public LPHDIGGIBFL(JOOJDMJJLEH KHALMCHEKDD, GKIEFGJCJKF MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class KGHFJBEDPFC : FLHJOEBGJCE<ADCLPOJIGAO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class AKLNEOCNFAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public KGHFJBEDPFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public AKLNEOCNFAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F85460", Offset = "0x1F83A60", VA = "0x181F85460")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F853D0", Offset = "0x1F839D0", VA = "0x181F853D0")]
			internal void GNBJLDAOBME(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private static Dictionary<string, HGBNDFBPIAF>? BJCEBOMGKNP;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B4E0", Offset = "0x1F99AE0", VA = "0x181F9B4E0")]
		public KGHFJBEDPFC(JOOJDMJJLEH KHALMCHEKDD, ADCLPOJIGAO MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B160", Offset = "0x1F99760", VA = "0x181F9B160", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class LAGDOFGBNPP : EAHKPFBPIMN<OIHFBKPFKJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override OMLMKPNJFBP DEKNNDMEDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C610", Offset = "0x1F9AC10", VA = "0x181F9C610")]
		public LAGDOFGBNPP(JOOJDMJJLEH KHALMCHEKDD, OIHFBKPFKJK LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class NLKHPINCEFP : EICHAAEOEKA<FLGODBGGBBK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CF70", Offset = "0x1F9B570", VA = "0x181F9CF70")]
		public NLKHPINCEFP(JOOJDMJJLEH KHALMCHEKDD, FLGODBGGBBK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class DHPJGJKMHKK : EICHAAEOEKA<GAJCDOINBKE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C460", Offset = "0x1F8AA60", VA = "0x181F8C460")]
		public DHPJGJKMHKK(JOOJDMJJLEH KHALMCHEKDD, GAJCDOINBKE MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class INDGCPKMHAL : DMEMDLIDPNO<KPJGAKGGBMD>
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class GKOPAOBFHNO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public GKOPAOBFHNO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x1F9E3E0", Offset = "0x1F9C9E0", VA = "0x181F9E3E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public INDGCPKMHAL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public GKOPAOBFHNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F91DB0", Offset = "0x1F903B0", VA = "0x181F91DB0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void DGFKBIDOBHC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F99730", Offset = "0x1F97D30", VA = "0x181F99730")]
		public INDGCPKMHAL(JOOJDMJJLEH KHALMCHEKDD, KPJGAKGGBMD LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F99450", Offset = "0x1F97A50", VA = "0x181F99450", Slot = "126")]
		protected override void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class OPINAFGCDMF : EAHKPFBPIMN<HMJHPIHKDDL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override OMLMKPNJFBP DEKNNDMEDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x8CC510", Offset = "0x8CAB10", VA = "0x1808CC510", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DE90", Offset = "0x1F9C490", VA = "0x181F9DE90")]
		public OPINAFGCDMF(JOOJDMJJLEH KHALMCHEKDD, HMJHPIHKDDL LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private sealed class FJBPIKJGBMJ : FLHJOEBGJCE<FJDGEOCJLBD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x92AC40", Offset = "0x929240", VA = "0x18092AC40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EC90", Offset = "0x1F8D290", VA = "0x181F8EC90")]
		public FJBPIKJGBMJ(JOOJDMJJLEH KHALMCHEKDD, FJDGEOCJLBD MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class LNKEDOBMCEF : FLHJOEBGJCE<FHPHOHAMCFA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CA60", Offset = "0x1F9B060", VA = "0x181F9CA60")]
		public LNKEDOBMCEF(JOOJDMJJLEH KHALMCHEKDD, FHPHOHAMCFA MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C690", Offset = "0x1F9AC90", VA = "0x181F9C690", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CA20", Offset = "0x1F9B020", VA = "0x181F9CA20")]
		private int PFONAACEKPC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C9C0", Offset = "0x1F9AFC0", VA = "0x181F9C9C0")]
		private void KEFBDADCCLP(int HEJFAMNFDIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class FPMOHGJKDAJ : GKANKGNJGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F590", Offset = "0x1F8DB90", VA = "0x181F8F590")]
		public FPMOHGJKDAJ(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class GLELEDEHPNN : DMEMDLIDPNO<OFEBFEPLBJH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1F91E80", Offset = "0x1F90480", VA = "0x181F91E80")]
		public GLELEDEHPNN(JOOJDMJJLEH KHALMCHEKDD, OFEBFEPLBJH MPJOKOKILNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public abstract class DMEMDLIDPNO<TVariableNode> : FLHJOEBGJCE<TVariableNode> where TVariableNode : notnull, OFEBFEPLBJH
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class OHDHNLAJPCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public DMEMDLIDPNO<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public OHDHNLAJPCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x466E900", Offset = "0x466CF00", VA = "0x18466E900")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x466EA70", Offset = "0x466D070", VA = "0x18466EA70")]
			internal void PNOMNBKFDEO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x466E960", Offset = "0x466CF60", VA = "0x18466E960")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x466E840", Offset = "0x466CE40", VA = "0x18466E840")]
			internal void BIBKJJFHCPP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x466E9C0", Offset = "0x466CFC0", VA = "0x18466E9C0")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class KJOLLIHHKFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public DKIELNKLCBA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public DMEMDLIDPNO<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public KJOLLIHHKFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4205460", Offset = "0x4203A60", VA = "0x184205460")]
			internal void DGFKBIDOBHC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA97530", Offset = "0xA95B30", VA = "0x180A97530", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NMDEKEINGII HGHKCAMHGED
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x5838B40", Offset = "0x5837140", VA = "0x185838B40", Slot = "94")]
			get
			{
				return default(NMDEKEINGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5838990", Offset = "0x5836F90", VA = "0x185838990")]
		protected DMEMDLIDPNO(JOOJDMJJLEH KHALMCHEKDD, TVariableNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5837EA0", Offset = "0x58364A0", VA = "0x185837EA0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5838140", Offset = "0x5836740", VA = "0x185838140", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x58385F0", Offset = "0x5836BF0", VA = "0x1858385F0", Slot = "126")]
		protected virtual void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5838040", Offset = "0x5836640", VA = "0x185838040", Slot = "105")]
		public override void FDHFDDAAOOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F80940", Offset = "0x1F7EF40", VA = "0x181F80940")]
	public static KIEKNELDHJG HCLFOFEHDJP(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public sealed class JIKAELGFCPG : ADEIFDEHNLJ, OFKBCMKGDMA, CKCCDGBALKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HBKKMIFHCOI<ONJNKIAIFAM> FHLLHDFEKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1D0", Offset = "0xA687D0", VA = "0x180A6A1D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<ONJNKIAIFAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public HBKKMIFHCOI<OPHNHCNNIBK> CLDFOLDBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x11F7DF0", Offset = "0x11F63F0", VA = "0x1811F7DF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<OPHNHCNNIBK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A330", Offset = "0x1F98930", VA = "0x181F9A330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private HBKKMIFHCOI<KEBIIKCPPLB> HIPHIMBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xBC3D40", Offset = "0xBC2340", VA = "0x180BC3D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override HBKKMIFHCOI<PMHAGHKACGK> LPFLDCIEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A690", Offset = "0x1F98C90", VA = "0x181F9A690", Slot = "20")]
		get
		{
			return default(HBKKMIFHCOI<PMHAGHKACGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A6E0", Offset = "0x1F98CE0", VA = "0x181F9A6E0")]
	private JIKAELGFCPG(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, JCEFPMOKKCP GOADIDBMIJH, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA, HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A340", Offset = "0x1F98940", VA = "0x181F9A340")]
	public static JIKAELGFCPG HCLFOFEHDJP(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, JCEFPMOKKCP INKGDJHAJPE, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA, bool FHGEKDMEAEP, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A330", Offset = "0x1F98930", VA = "0x181F9A330")]
	internal void LPHOPGIMCOF(HBKKMIFHCOI<OPHNHCNNIBK> CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public abstract class ADEIFDEHNLJ : CKCCDGBALKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private struct JAICFLMGOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private OMHBDILNPHD? AAACNJJBBJN;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1F99BF0", Offset = "0x1F981F0", VA = "0x181F99BF0")]
		public void OAIAOCAHOEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1F99B50", Offset = "0x1F98150", VA = "0x181F99B50")]
		public OMHBDILNPHD DGPCOOBKLLI(ADEIFDEHNLJ LELOANIDCDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	protected readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	protected readonly CDJIOCDEIML IAAGCAJGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private JAICFLMGOEI PAGOKJNDIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly AKNPPOILJMM JFDNDOHLMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly List<JFDPKJAFIFC> CHEBIHOBBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly List<MHKFOLFKNDO> CJNFBBAMJAE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[NONNNOEJCPN("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> NCGFNGEFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F84770", Offset = "0x1F82D70", VA = "0x181F84770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind KJEBMFBHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8723F0", Offset = "0x8709F0", VA = "0x1808723F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public HBKKMIFHCOI<EKJMGNHJFDN> HLPKLNNHMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1F84920", Offset = "0x1F82F20", VA = "0x181F84920", Slot = "6")]
		get
		{
			return default(HBKKMIFHCOI<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F84C00", Offset = "0x1F83200", VA = "0x181F84C00", Slot = "7")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CNABLCLBOEK FNIGGFHADFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1BC9930", Offset = "0x1BC7F30", VA = "0x181BC9930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public KBJGBHFDLPP FFCAOKDECBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F84950", Offset = "0x1F82F50", VA = "0x181F84950", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OMHBDILNPHD JKCGFBANPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F84950", Offset = "0x1F82F50", VA = "0x181F84950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage FOCMCGLBJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F83E00", Offset = "0x1F82400", VA = "0x181F83E00", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x868A50", Offset = "0x867050", VA = "0x180868A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F83F30", Offset = "0x1F82530", VA = "0x181F83F30", Slot = "9")]
		get
		{
			return default(DAMOFJGJNKL<JMIDFPKEEGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HBKKMIFHCOI<LMECHAAEJCH> FABGDHBLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A90", Offset = "0x9B1090", VA = "0x1809B2A90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<LMECHAAEJCH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xEA02E0", Offset = "0xE9E8E0", VA = "0x180EA02E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract HBKKMIFHCOI<PMHAGHKACGK> LPFLDCIEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1F84C30", Offset = "0x1F83230", VA = "0x181F84C30")]
	protected ADEIFDEHNLJ(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, AKNPPOILJMM JCEBAOIBEAD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1F83890", Offset = "0x1F81E90", VA = "0x181F83890", Slot = "21")]
	protected virtual void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1F83CB0", Offset = "0x1F822B0", VA = "0x181F83CB0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1F83BF0", Offset = "0x1F821F0", VA = "0x181F83BF0", Slot = "14")]
	public void DBGNIKNGGLE(JFDPKJAFIFC FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1F848C0", Offset = "0x1F82EC0", VA = "0x181F848C0", Slot = "15")]
	public void KMLAOBCIICF(MHKFOLFKNDO FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1F83F50", Offset = "0x1F82550", VA = "0x181F83F50", Slot = "16")]
	public void GEAKHPFHIDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1F83C50", Offset = "0x1F82250", VA = "0x181F83C50", Slot = "23")]
	protected virtual void DKAHAGGDDDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1F845E0", Offset = "0x1F82BE0", VA = "0x181F845E0")]
	private void JKEOHDLBLKI(bool JLMICGLMAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1F83A40", Offset = "0x1F82040", VA = "0x181F83A40")]
	private void CPMAOLMDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1F849F0", Offset = "0x1F82FF0", VA = "0x181F849F0")]
	private void NAEPPMJCHGE([In] BOFICHBLKBH KCACFKLJPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1F839E0", Offset = "0x1F81FE0", VA = "0x181F839E0", Slot = "17")]
	public void CIKHPFOGLOI(JFDPKJAFIFC FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1F84BA0", Offset = "0x1F831A0", VA = "0x181F84BA0", Slot = "18")]
	public void NCJHMNFHNLF(MHKFOLFKNDO FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x868A50", Offset = "0x867050", VA = "0x180868A50")]
	internal void OFJBNIKIPAA(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1F83870", Offset = "0x1F81E70", VA = "0x181F83870")]
	internal void ABJFAPNIBFB(FNPCAPDLGHJ OJGLDAGFLKC, CNABLCLBOEK PBLNJHEPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xEA02E0", Offset = "0xE9E8E0", VA = "0x180EA02E0")]
	internal void IKKPPJKBOAF(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class IJENMLPPGDM : JHMJLMFOOPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class BLNBKBOPAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public JOOJDMJJLEH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CDJIOCDEIML node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BLNBKBOPAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1F8ABE0", Offset = "0x1F891E0", VA = "0x181F8ABE0")]
		internal BEILIFKJEAK MNDNNDJEEMH((int PortDescIndex, int PortIndex, CDGMKFJFGMP InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AC70", Offset = "0x1F89270", VA = "0x181F8AC70")]
		internal JIKAELGFCPG ONBNCPNGJLP(JCEFPMOKKCP i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GEOIPFKJHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1F91880", Offset = "0x1F8FE80", VA = "0x181F91880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1F91CE0", Offset = "0x1F902E0", VA = "0x181F91CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct APEHLEGPCOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public HBKKMIFHCOI<KIADPJBFMAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1F857A0", Offset = "0x1F83DA0", VA = "0x181F857A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1F85AF0", Offset = "0x1F840F0", VA = "0x181F85AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct JAGDJEPHADK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public HBKKMIFHCOI<KEBIIKCPPLB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1F99790", Offset = "0x1F97D90", VA = "0x181F99790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1F99AE0", Offset = "0x1F980E0", VA = "0x181F99AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct EKMKHBELJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public HBKKMIFHCOI<KIADPJBFMAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public HBKKMIFHCOI<KIADPJBFMAK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D900", Offset = "0x1F8BF00", VA = "0x181F8D900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1F8DC50", Offset = "0x1F8C250", VA = "0x181F8DC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct OFIDLAEOHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public HBKKMIFHCOI<KEBIIKCPPLB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public HBKKMIFHCOI<KEBIIKCPPLB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CFD0", Offset = "0x1F9B5D0", VA = "0x181F9CFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D320", Offset = "0x1F9B920", VA = "0x181F9D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct ICGHNOBLHJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1F92BE0", Offset = "0x1F911E0", VA = "0x181F92BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1F93050", Offset = "0x1F91650", VA = "0x181F93050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct OLFNLCOGIBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D7B0", Offset = "0x1F9BDB0", VA = "0x181F9D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DB00", Offset = "0x1F9C100", VA = "0x181F9DB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct OHFDAIOIBAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public HBKKMIFHCOI<KIADPJBFMAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D390", Offset = "0x1F9B990", VA = "0x181F9D390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D6E0", Offset = "0x1F9BCE0", VA = "0x181F9D6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct GDNKGMOJHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public HBKKMIFHCOI<KEBIIKCPPLB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1F913E0", Offset = "0x1F8F9E0", VA = "0x181F913E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1F91730", Offset = "0x1F8FD30", VA = "0x181F91730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FAFPALOJMDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public OMFLEFMMLLM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public HBKKMIFHCOI<KIADPJBFMAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1F8DDF0", Offset = "0x1F8C3F0", VA = "0x181F8DDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E180", Offset = "0x1F8C780", VA = "0x181F8E180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct HGHAHDHBILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public IJENMLPPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public OMFLEFMMLLM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public HBKKMIFHCOI<KEBIIKCPPLB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private CPINABIIADF <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1F92480", Offset = "0x1F90A80", VA = "0x181F92480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1F92810", Offset = "0x1F90E10", VA = "0x181F92810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly bool CIEDAAKLEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool OBFCJLMCJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private ANJPNODIDCK<CHIHANCPCBA, BEILIFKJEAK> AMOFCMIBLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB> IDIJLDOGBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly CDJIOCDEIML IAAGCAJGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private ANJPNODIDCK<OPHNHCNNIBK, JIKAELGFCPG> LNKOJNLHDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA> KJDLKIGCAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private string? JMGDJFPIBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly JLKIADPGAEH FEHBOGBDEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private HBKKMIFHCOI<LMECHAAEJCH> MKEALHAGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool KNIPLAFECMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[CompilerGenerated]
	private Action? NHNHNBJHMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? JOHFKJCNBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<HBKKMIFHCOI<CHIHANCPCBA>>? IPIABEMODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	[CompilerGenerated]
	private Action<HBKKMIFHCOI<OPHNHCNNIBK>>? INPJDNGNDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private JHMJLMFOOPE.HPBGCIEHKCN? HCLMCCMJEKN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool DIIEGPJDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1F968F0", Offset = "0x1F94EF0", VA = "0x181F968F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool HMAEBJJCNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1F98360", Offset = "0x1F96960", VA = "0x181F98360", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool NCIPFABILKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1F963A0", Offset = "0x1F949A0", VA = "0x181F963A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1F98860", Offset = "0x1F96E60", VA = "0x181F98860", Slot = "7")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PDEIBLGIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1F982E0", Offset = "0x1F968E0", VA = "0x181F982E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB> CKBKHKMIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "9")]
		get
		{
			return default(ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1F95780", Offset = "0x1F93D80", VA = "0x181F95780", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1F95760", Offset = "0x1F93D60", VA = "0x181F95760", Slot = "11")]
		get
		{
			return default(DAMOFJGJNKL<JMIDFPKEEGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA> EKFBFMJHDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0", Slot = "12")]
		get
		{
			return default(ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HBKKMIFHCOI<LMECHAAEJCH> FABGDHBLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xBC4FD0", Offset = "0xBC35D0", VA = "0x180BC4FD0", Slot = "13")]
		get
		{
			return default(HBKKMIFHCOI<LMECHAAEJCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GGBEAFDIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1F98F00", Offset = "0x1F97500", VA = "0x181F98F00", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F983A0", Offset = "0x1F969A0", VA = "0x181F983A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action ABIKAAHOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1F94430", Offset = "0x1F92A30", VA = "0x181F94430", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1F97590", Offset = "0x1F95B90", VA = "0x181F97590", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, HBKKMIFHCOI<CHIHANCPCBA>> HLPBPLPBBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1F95900", Offset = "0x1F93F00", VA = "0x181F95900", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1F93AB0", Offset = "0x1F920B0", VA = "0x181F93AB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, HBKKMIFHCOI<CHIHANCPCBA>> GPLLNIEEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1F97410", Offset = "0x1F95A10", VA = "0x181F97410", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1F939F0", Offset = "0x1F91FF0", VA = "0x181F939F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, HBKKMIFHCOI<OPHNHCNNIBK>> FEIKAPFKBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1F98890", Offset = "0x1F96E90", VA = "0x181F98890", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1F985C0", Offset = "0x1F96BC0", VA = "0x181F985C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, HBKKMIFHCOI<OPHNHCNNIBK>> JLIGCCGAJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1F941F0", Offset = "0x1F927F0", VA = "0x181F941F0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1F93B90", Offset = "0x1F92190", VA = "0x181F93B90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, BGGKHBIFAEB> PBJGDFLKINE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1F969D0", Offset = "0x1F94FD0", VA = "0x181F969D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1F96E90", Offset = "0x1F95490", VA = "0x181F96E90", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>> IIEJCFKBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1F97DB0", Offset = "0x1F963B0", VA = "0x181F97DB0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1F96A90", Offset = "0x1F95090", VA = "0x181F96A90", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, BGGKHBIFAEB> EMLKPFLMMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1F974D0", Offset = "0x1F95AD0", VA = "0x181F974D0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1F98440", Offset = "0x1F96A40", VA = "0x181F98440", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, OFKBCMKGDMA> JBHOJNIAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1F98E40", Offset = "0x1F97440", VA = "0x181F98E40", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1F94370", Offset = "0x1F92970", VA = "0x181F94370", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>> AGOLLGECOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1F942B0", Offset = "0x1F928B0", VA = "0x181F942B0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1F96DD0", Offset = "0x1F953D0", VA = "0x181F96DD0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, OFKBCMKGDMA> BOEGBMAFFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1F98500", Offset = "0x1F96B00", VA = "0x181F98500", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1F96830", Offset = "0x1F94E30", VA = "0x181F96830", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1F98FA0", Offset = "0x1F975A0", VA = "0x181F98FA0")]
	private IJENMLPPGDM(bool FHGEKDMEAEP, JOOJDMJJLEH KHALMCHEKDD, bool GCCOGJBMEGM, ANJPNODIDCK<CHIHANCPCBA, BEILIFKJEAK> NOPADGLPHDE, ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB> JGDIMHBLHBD, CDJIOCDEIML MPJOKOKILNG, ANJPNODIDCK<OPHNHCNNIBK, JIKAELGFCPG> EEPCHAOPKJF, ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA> FIDIFFEJHBE, string? BCJONJAFFLF, JLKIADPGAEH BNCODIOLIGF, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool JMNMBLFPBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1F95E30", Offset = "0x1F94430", VA = "0x181F95E30")]
	public static IJENMLPPGDM HCLFOFEHDJP(bool FHGEKDMEAEP, JOOJDMJJLEH KHALMCHEKDD, bool GCCOGJBMEGM, CDJIOCDEIML MPJOKOKILNG, JLKIADPGAEH BNCODIOLIGF, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1F93240", Offset = "0x1F91840", VA = "0x181F93240")]
	private void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1F945F0", Offset = "0x1F92BF0", VA = "0x181F945F0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1F96CE0", Offset = "0x1F952E0", VA = "0x181F96CE0", Slot = "38")]
	[AsyncStateMachine(typeof(GEOIPFKJHCK))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> KGNEMHAPCKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1F97640", Offset = "0x1F95C40", VA = "0x181F97640")]
	private (CBPNOBAKELJ, int)? LODCEKPFNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1F95AE0", Offset = "0x1F940E0", VA = "0x181F95AE0")]
	private void GDLIMJPKMLC(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x140AE30", Offset = "0x1409430", VA = "0x18140AE30")]
	private void GNKPCJADMBD(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1F98AA0", Offset = "0x1F970A0", VA = "0x181F98AA0")]
	private void PNGJBNEKIOD(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1F930C0", Offset = "0x1F916C0", VA = "0x181F930C0")]
	private void BDLAHKOCELD(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1F97870", Offset = "0x1F95E70", VA = "0x181F97870")]
	private void MAELIGHABCF(int FMIHCHGCFLM, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA, CDGMKFJFGMP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1F96CC0", Offset = "0x1F952C0", VA = "0x181F96CC0")]
	private void KEDPEHGKMAL(int JLMICGLMAKN, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1F969B0", Offset = "0x1F94FB0", VA = "0x181F969B0")]
	private void IPMPEEKFLJL(int JLMICGLMAKN, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1F97E90", Offset = "0x1F96490", VA = "0x181F97E90")]
	private void MMCNKBHAJLO(int FMIHCHGCFLM, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA, CDGMKFJFGMP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1F98950", Offset = "0x1F96F50", VA = "0x181F98950")]
	private void PDNJEPDCNCI(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xAD3A30", Offset = "0xAD2030", VA = "0x180AD3A30")]
	private void HJNKIIJGNHH(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x1F98770", Offset = "0x1F96D70", VA = "0x181F98770")]
	private void NPFCAJGBPOL(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x140AE30", Offset = "0x1409430", VA = "0x18140AE30")]
	private void MIFOACGNEDE(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1F97070", Offset = "0x1F95670", VA = "0x181F97070")]
	private void LDNNLDCFPJI(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1F96C60", Offset = "0x1F95260", VA = "0x181F96C60")]
	private void JKJIHFBIFNG(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1F950F0", Offset = "0x1F936F0", VA = "0x181F950F0")]
	private void EELFJCACOAH(int FMIHCHGCFLM, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA, JCEFPMOKKCP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1F97E70", Offset = "0x1F96470", VA = "0x181F97E70")]
	private void MFMNEMANNDP(int JLMICGLMAKN, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1F93B70", Offset = "0x1F92170", VA = "0x181F93B70")]
	private void CENDKJBHDDO(int JLMICGLMAKN, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1F93C50", Offset = "0x1F92250", VA = "0x181F93C50")]
	private void CKIIBKNKKNL(int FMIHCHGCFLM, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA, JCEFPMOKKCP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1F957B0", Offset = "0x1F93DB0", VA = "0x181F957B0")]
	private void FIGLDBEHPAE(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xAD3A30", Offset = "0xAD2030", VA = "0x180AD3A30")]
	private void KFGLPNGJBJA(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1F96B50", Offset = "0x1F95150", VA = "0x181F96B50", Slot = "39")]
	[AsyncStateMachine(typeof(APEHLEGPCOB))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> JGFONHLJFKH(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1F944E0", Offset = "0x1F92AE0", VA = "0x181F944E0", Slot = "40")]
	[AsyncStateMachine(typeof(JAGDJEPHADK))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> DMJNLKOPEDF(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1F959C0", Offset = "0x1F93FC0", VA = "0x181F959C0", Slot = "41")]
	[AsyncStateMachine(typeof(EKMKHBELJKJ))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> FOCBCCDFLHC(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, HBKKMIFHCOI<KIADPJBFMAK> GOFJPGHIIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1F96F50", Offset = "0x1F95550", VA = "0x181F96F50", Slot = "42")]
	[AsyncStateMachine(typeof(OFIDLAEOHKH))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> LBONKFAAJKL(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, HBKKMIFHCOI<KEBIIKCPPLB> GOFJPGHIIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1F98680", Offset = "0x1F96C80", VA = "0x181F98680", Slot = "43")]
	[AsyncStateMachine(typeof(ICGHNOBLHJC))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> NOPFNFGELED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1F93120", Offset = "0x1F91720", VA = "0x181F93120", Slot = "44")]
	[AsyncStateMachine(typeof(OLFNLCOGIBM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> BGFINDGOPFD(string MFOBCFPKPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1F95BD0", Offset = "0x1F941D0", VA = "0x181F95BD0", Slot = "45")]
	[AsyncStateMachine(typeof(OHFDAIOIBAI))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GOJEJIMPLHF(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1F95D00", Offset = "0x1F94300", VA = "0x181F95D00", Slot = "46")]
	[AsyncStateMachine(typeof(GDNKGMOJHDL))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HCAFJDCPIOC(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1F95630", Offset = "0x1F93C30", VA = "0x181F95630", Slot = "47")]
	[AsyncStateMachine(typeof(FAFPALOJMDM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> FBEGHNEIHGL(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, OMFLEFMMLLM PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1F940C0", Offset = "0x1F926C0", VA = "0x181F940C0", Slot = "48")]
	[AsyncStateMachine(typeof(HGHAHDHBILE))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> COGMJDMFHJO(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, OMFLEFMMLLM PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1F96460", Offset = "0x1F94A60", VA = "0x181F96460")]
	internal void IKKPPJKBOAF(HBKKMIFHCOI<LMECHAAEJCH> CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class CJJOLICGHKG : OKEJDJNOOIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public interface FGAHFMCOIBE
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		FNPCAPDLGHJ IJJAFDHIFLK
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OCCKDCOPHOC> PEDNHJDPHHC(CancellationToken DADBOHKBJNO);

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HMALNBKCNFI> CCBKHKHGJLH(CancellationToken DADBOHKBJNO);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CPNNGLIIIOE> KHLMIGOAACB(CancellationToken DADBOHKBJNO);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct FFNHECAIBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<CJJOLICGHKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public JOOJDMJJLEH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OCCKDCOPHOC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public HMALNBKCNFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private FGAHFMCOIBE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private HMALNBKCNFI <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<OCCKDCOPHOC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<HMALNBKCNFI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<CPNNGLIIIOE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<MDDIMDPOMKC> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E1F0", Offset = "0x1F8C7F0", VA = "0x181F8E1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EC20", Offset = "0x1F8D220", VA = "0x181F8EC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly MDDIMDPOMKC LMOEHLHHNCD;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MDDIMDPOMKC EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	private CJJOLICGHKG(MDDIMDPOMKC KBFJOOIMLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BB80", Offset = "0x1F8A180", VA = "0x181F8BB80")]
	[AsyncStateMachine(typeof(FFNHECAIBFL))]
	public static Task<CJJOLICGHKG> LGHHEPEAJLF(JOOJDMJJLEH KHALMCHEKDD, OCCKDCOPHOC? ENLCDNNHBBD, HMALNBKCNFI? KEAPPNMDHKA, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BB60", Offset = "0x1F8A160", VA = "0x181F8BB60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public readonly struct GOGFHKFMKHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct AICFGCNCDLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public GOGFHKFMKHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public LHAEFPHAKAB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1F850B0", Offset = "0x1F836B0", VA = "0x181F850B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1F85340", Offset = "0x1F83940", VA = "0x181F85340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct DEEDPNMLCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<bool, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AGKNAGALEPM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public OCCKDCOPHOC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public HMALNBKCNFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public GOGFHKFMKHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private LHAEFPHAKAB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C010", Offset = "0x1F8A610", VA = "0x181F8C010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C3F0", Offset = "0x1F8A9F0", VA = "0x181F8C3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FMIFPLAJALE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GOGFHKFMKHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EFD0", Offset = "0x1F8D5D0", VA = "0x181F8EFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F210", Offset = "0x1F8D810", VA = "0x181F8F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly PKBGPKAOHBH IPICGINFACB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	public GOGFHKFMKHD(PKBGPKAOHBH DFJCFKMIMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1F91FD0", Offset = "0x1F905D0", VA = "0x181F91FD0")]
	[AsyncStateMachine(typeof(AICFGCNCDLB))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EKKCLFIOMLH(LHAEFPHAKAB OGLJLDNLGIJ, bool EPJOLNMCGPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1F92100", Offset = "0x1F90700", VA = "0x181F92100")]
	[AsyncStateMachine(typeof(DEEDPNMLCFI))]
	public Task<PIJKHLBEMKP<bool, NJADGKCOIIE?>>? MJEMCAEJKCI(int KICHIPMPPLC, AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1F91EE0", Offset = "0x1F904E0", VA = "0x181F91EE0")]
	[AsyncStateMachine(typeof(FMIFPLAJALE))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> BKCGKDNFFIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class HBIAHFKNLDH : HBBDNIKPEOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly JKPODBPPDEH DLJBCBJNBHG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JKPODBPPDEH FNMGFGMHHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	private HBIAHFKNLDH(JKPODBPPDEH BKOAJFMCFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F92280", Offset = "0x1F90880", VA = "0x181F92280")]
	public static HBIAHFKNLDH JGNOLJBBCJA(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1F92260", Offset = "0x1F90860", VA = "0x181F92260", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface KIAAHGKKHGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	MDDIMDPOMKC EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	BGKNJNPOJIF NHKAIKLFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	OLKOPFDMPBB DMMAAOPFCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	APGFLEHHNBL NIHBMHBFGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface KHELNPHJBOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	KIAAHGKKHGJ? LBGJFIIMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool NCEFEDCCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KIAAHGKKHGJ?>? JHHJELLMFLD();

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CDNMIACPINI(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ALLMMCMLLNM("IStaticCV2Instance")]
public interface OKEJDJNOOIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MDDIMDPOMKC EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ALLMMCMLLNM("IStaticEVInstance")]
public interface HBBDNIKPEOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	JKPODBPPDEH FNMGFGMHHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class EADIDMMCELA
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C6C0", Offset = "0x1F8ACC0", VA = "0x181F8C6C0")]
	public static NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> JDBGFEEGNJE([In] this NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> CDMLJCCHNJC)
	{
		return default(NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class AKFANCKKAOE : EPJNNELGOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NCEFEDCCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x1F853B0", Offset = "0x1F839B0", VA = "0x181F853B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	internal AKFANCKKAOE(JOOJDMJJLEH KHALMCHEKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class PBOABKNJFJD : DAJBIJHHEBH
{
	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DEF0", Offset = "0x1F9C4F0", VA = "0x181F9DEF0", Slot = "4")]
	public FJHHPENGBMK? FFIFAOFANHL(string? LJJOFJIKNDL, string? GCAFACMGFAP, string? HAPEMCMCCFP, FIJLIHGCHDL.KBENJEODHDA.KDGHJJAMAML INBNININEHN, bool GEFEMBGFAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public PBOABKNJFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class EGLCBPFGBKA : DBFAAEPDDME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct ONFCDPABABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AsyncTaskMethodBuilder<BGBOPJIEMLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public EGLCBPFGBKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<KIAAHGKKHGJ?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DB70", Offset = "0x1F9C170", VA = "0x181F9DB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DE20", Offset = "0x1F9C420", VA = "0x181F9DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private IReadOnlyList<DAMOFJGJNKL<BBDJCOABDOK>>? IGIFHKFKEIP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public BGBOPJIEMLP? IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1F8CF80", Offset = "0x1F8B580", VA = "0x181F8CF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public APGFLEHHNBL? DKHJJDIJPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F8CF00", Offset = "0x1F8B500", VA = "0x181F8CF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MAFPLDGLFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D8A0", Offset = "0x1F8BEA0", VA = "0x181F8D8A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MNHKAPHDGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F8CEA0", Offset = "0x1F8B4A0", VA = "0x181F8CEA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	internal EGLCBPFGBKA(JOOJDMJJLEH KHALMCHEKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D000", Offset = "0x1F8B600", VA = "0x181F8D000", Slot = "7")]
	[AsyncStateMachine(typeof(ONFCDPABABO))]
	public Task<BGBOPJIEMLP> KKKEKLJJHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D530", Offset = "0x1F8BB30", VA = "0x181F8D530", Slot = "9")]
	public IReadOnlyDictionary<DAMOFJGJNKL<EKJMGNHJFDN>, Guid> PGFOILHJEDP(IEnumerable<CGIDLDDLPHO> AGAEFCPEJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D0F0", Offset = "0x1F8B6F0", VA = "0x181F8D0F0")]
	public PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA> KLNEHKLMKGP([In] DPLPMGFHLCK HJLKBDGMNOH, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF, int DADHPDPLPJH)
	{
		return default(PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D4F0", Offset = "0x1F8BAF0", VA = "0x181F8D4F0")]
	internal static DEFEBGKBMOG LJIBAPJPPFH(IDHOMPHPHDD KDOLOIDMFEN, CDJIOCDEIML MPJOKOKILNG)
	{
		return default(DEFEBGKBMOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D2F0", Offset = "0x1F8B8F0", VA = "0x181F8D2F0", Slot = "8")]
	private PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA> LCJGAMDMICO([In] DPLPMGFHLCK HJLKBDGMNOH, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF, int DADHPDPLPJH)
	{
		return default(PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CC50", Offset = "0x1F8B250", VA = "0x181F8CC50")]
	[CompilerGenerated]
	internal static DEFEBGKBMOG CIHKMIDEOKF(IDHOMPHPHDD EKGCMFDHKNO, CDJIOCDEIML DFLLBMKFKMA)
	{
		return default(DEFEBGKBMOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class APGFLEHHNBL : BGBOPJIEMLP
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	internal static class GBEJEFJJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class NCNKFDEIEAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public MDDIMDPOMKC state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public ICFEHOOIGAO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public NCNKFDEIEAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CE80", Offset = "0x1F9B480", VA = "0x181F9CE80")]
			internal bool FFIJPACMACD(FLJAKMHKMAG n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class LLKKBOICCOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LLKKBOICCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C670", Offset = "0x1F9AC70", VA = "0x181F9C670")]
			internal void LPMFBBOIJJJ(FLJAKMHKMAG n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F909E0", Offset = "0x1F8EFE0", VA = "0x181F909E0")]
		public static PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> JGBGEMHOKIJ(APGFLEHHNBL OLDDCPCBGIL, [In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
		{
			return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F6C0", Offset = "0x1F8DCC0", VA = "0x181F8F6C0")]
		internal static PIJKHLBEMKP<(EOAGLOOCHAC, GPOFCGMIFIM), JKFFLAEBADK> DGJHAIJNDGA(APGFLEHHNBL OLDDCPCBGIL, GPOFCGMIFIM IODIGIENGOI, bool OPCKIKOAGAG, [In] DAMOFJGJNKL<EKJMGNHJFDN> PINDFINEKFC, [In] int? LIFAEHCHCOG, [In] DEFEBGKBMOG? MCJNHKFFNGB, [In] DEFEBGKBMOG? LCPPPBENPFE)
		{
			return default(PIJKHLBEMKP<(EOAGLOOCHAC, GPOFCGMIFIM), JKFFLAEBADK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F90F70", Offset = "0x1F8F570", VA = "0x181F90F70")]
		private static void LIJEDCFGHFP(bool OPCKIKOAGAG, CGIDLDDLPHO PKKOMHEOCPG, EOAGLOOCHAC DLMMOCDPJNC, [In] DAMOFJGJNKL<EKJMGNHJFDN> PINDFINEKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F904E0", Offset = "0x1F8EAE0", VA = "0x181F904E0")]
		public static void FIOPEPCJABB(HAPEGCJCAFB FLGBCKPBNEF, [In] BGBOPJIEMLP.BGBKGFEFHEB ILJDFLKNIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F908F0", Offset = "0x1F8EEF0", VA = "0x181F908F0")]
		[CompilerGenerated]
		internal static bool IIPNLPBEPCB(MDDIMDPOMKC CBMAKLGFICM, ICFEHOOIGAO HOAMKPMOJKO, FLJAKMHKMAG BEIDPDGFKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F913B0", Offset = "0x1F8F9B0", VA = "0x181F913B0")]
		[CompilerGenerated]
		internal static bool OJAAMBLDDJC(FLJAKMHKMAG LFGOPFNHKKH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct KJLBBEOJEJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public APGFLEHHNBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public HBKKMIFHCOI<EKJMGNHJFDN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public HBKKMIFHCOI<ONJNKIAIFAM> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public HBKKMIFHCOI<NIMJJIGJCLJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B910", Offset = "0x1F99F10", VA = "0x181F9B910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BF60", Offset = "0x1F9A560", VA = "0x181F9BF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct KOJJCLOFDGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public APGFLEHHNBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public DAMOFJGJNKL<JMIDFPKEEGG> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public DAMOFJGJNKL<EKJMGNHJFDN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public HBKKMIFHCOI<LMECHAAEJCH> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public HBKKMIFHCOI<CHIHANCPCBA> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C260", Offset = "0x1F9A860", VA = "0x181F9C260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C5A0", Offset = "0x1F9ABA0", VA = "0x181F9C5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct IJIAFADFHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public APGFLEHHNBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public DAMOFJGJNKL<JMIDFPKEEGG> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public DAMOFJGJNKL<EKJMGNHJFDN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public HBKKMIFHCOI<LMECHAAEJCH> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public HBKKMIFHCOI<OPHNHCNNIBK> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F990A0", Offset = "0x1F976A0", VA = "0x181F990A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1F993E0", Offset = "0x1F979E0", VA = "0x181F993E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly JOOJDMJJLEH MKHFBHMOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly OKEJDJNOOIE IHPJMEOKAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly HBBDNIKPEOK PPEOPJNEGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly GEOEJKJFPIP JEGDACJMHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly EGLCBPFGBKA AHLFGBJHKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Dictionary<DAMOFJGJNKL<JMIDFPKEEGG>, KIEKNELDHJG> CKANMOLOIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[CompilerGenerated]
	private Action<DAMOFJGJNKL<JMIDFPKEEGG>>? GJMGNPINCEK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DAMOFJGJNKL<EKJMGNHJFDN> ANMNFNFIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F87820", Offset = "0x1F85E20", VA = "0x181F87820", Slot = "4")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GEOEJKJFPIP NILFJBLBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AB50", Offset = "0x1F79150", VA = "0x181F7AB50", Slot = "5")]
		get
		{
			return default(GEOEJKJFPIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F89C10", Offset = "0x1F88210", VA = "0x181F89C10")]
	public APGFLEHHNBL(JOOJDMJJLEH KHALMCHEKDD, OKEJDJNOOIE NFKIECONLKB, HBBDNIKPEOK PMBKGLBIAHE, EGLCBPFGBKA DPPFHMBECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F85E60", Offset = "0x1F84460", VA = "0x181F85E60", Slot = "41")]
	public HBKKMIFHCOI<KEBEKGPMJKL> AANNGLFFJOC(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(HBKKMIFHCOI<KEBEKGPMJKL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F899C0", Offset = "0x1F87FC0", VA = "0x181F899C0", Slot = "42")]
	public HBKKMIFHCOI<FAGHEGCFHGM> NJMGGLKOAGI(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(HBKKMIFHCOI<FAGHEGCFHGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F89450", Offset = "0x1F87A50", VA = "0x181F89450", Slot = "6")]
	public bool NHJIGEIJJEF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F86100", Offset = "0x1F84700", VA = "0x181F86100")]
	public bool BELKKJBKFDH(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F89A50", Offset = "0x1F88050", VA = "0x181F89A50", Slot = "8")]
	public bool OHDIMHLMCJP(BGGKHBIFAEB PNLIMBPEEFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F88E80", Offset = "0x1F87480", VA = "0x181F88E80", Slot = "9")]
	public bool LLMBKFLDBJP(OFKBCMKGDMA DAFAKLKEDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F898C0", Offset = "0x1F87EC0", VA = "0x181F898C0")]
	public KIEKNELDHJG? NHLANNCGFBK([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F872B0", Offset = "0x1F858B0", VA = "0x181F872B0")]
	public HBKKMIFHCOI<JMIDFPKEEGG> FEGEAOBIKON(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] DAMOFJGJNKL<JMIDFPKEEGG> DCNPIEAMPAG)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F89B90", Offset = "0x1F88190", VA = "0x181F89B90", Slot = "20")]
	public HBKKMIFHCOI<JMIDFPKEEGG> PNAEMMAPJLK(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F882D0", Offset = "0x1F868D0", VA = "0x181F882D0", Slot = "21")]
	public HBKKMIFHCOI<JMIDFPKEEGG> IPIICFCNFGD(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F86DE0", Offset = "0x1F853E0", VA = "0x181F86DE0")]
	private void DKOJBNCCBPP(DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F85EE0", Offset = "0x1F844E0", VA = "0x181F85EE0")]
	public IEnumerable<KIEKNELDHJG> AJANHPENBOO([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F87790", Offset = "0x1F85D90", VA = "0x181F87790", Slot = "19")]
	public HBKKMIFHCOI<NIMJJIGJCLJ> GANPICIJFAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<KEBEKGPMJKL> GONALOCEIKE)
	{
		return default(HBKKMIFHCOI<NIMJJIGJCLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F86FF0", Offset = "0x1F855F0", VA = "0x181F86FF0", Slot = "22")]
	public HBKKMIFHCOI<ONJNKIAIFAM> EMDNCKGBECF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<FAGHEGCFHGM> HDLCFJJFELF)
	{
		return default(HBKKMIFHCOI<ONJNKIAIFAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F86FB0", Offset = "0x1F855B0", VA = "0x181F86FB0")]
	private KIEKNELDHJG? EGLGNADAGHO([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F883D0", Offset = "0x1F869D0", VA = "0x181F883D0")]
	private KIEKNELDHJG JCCKOKOGJCC([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, CDJIOCDEIML MPJOKOKILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F88C00", Offset = "0x1F87200", VA = "0x181F88C00")]
	public CDJIOCDEIML? KDNDKPMIEON([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F866E0", Offset = "0x1F84CE0", VA = "0x181F866E0")]
	public GPMBAPNKEOC? CFLGMADNMHA([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F89AD0", Offset = "0x1F880D0", VA = "0x181F89AD0", Slot = "15")]
	public IEnumerable<OBFDOAMHKBB> PMBKHNBHIJK(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F88600", Offset = "0x1F86C00", VA = "0x181F88600", Slot = "16")]
	public IEnumerable<JKFONICFCFD> JJDBOJPCBPA(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F88890", Offset = "0x1F86E90", VA = "0x181F88890", Slot = "17")]
	public IEnumerable<JKFONICFCFD> JJFGPCMBEAC(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F86080", Offset = "0x1F84680", VA = "0x181F86080")]
	public HBKKMIFHCOI<EKJMGNHJFDN> HLGOJNLMOHL([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(HBKKMIFHCOI<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F88B80", Offset = "0x1F87180", VA = "0x181F88B80")]
	public HBKKMIFHCOI<EKJMGNHJFDN>? KBNCCHDABIG([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F85FC0", Offset = "0x1F845C0", VA = "0x181F85FC0")]
	private ICFEHOOIGAO? AKNGHOELKIL([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F866E0", Offset = "0x1F84CE0", VA = "0x181F866E0")]
	private GPMBAPNKEOC? PBEBHBNJGIP([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F87E40", Offset = "0x1F86440", VA = "0x181F87E40", Slot = "26")]
	public DAMOFJGJNKL<EKJMGNHJFDN> GHIJPOPHFLF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(DAMOFJGJNKL<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F88070", Offset = "0x1F86670", VA = "0x181F88070", Slot = "23")]
	public IEnumerable<OMFLEFMMLLM> HGKAFKDAHBJ(MNDEIIAMGGE GJPEPMPHDKA, bool MKCMGPIHFMB, bool BNBFGLKCIIA, bool DEHKMADBKBK, bool DGMGBNEFKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F85B60", Offset = "0x1F84160", VA = "0x181F85B60", Slot = "24")]
	public OMFLEFMMLLM AADJJLEAKGL(MNDEIIAMGGE GJPEPMPHDKA, CKCCDGBALKM FKPIFFHGEFN, bool MKCMGPIHFMB, bool BNBFGLKCIIA, bool DEHKMADBKBK, bool DGMGBNEFKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F86570", Offset = "0x1F84B70", VA = "0x181F86570")]
	public OBFDOAMHKBB FBBLMLGONFO(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(OBFDOAMHKBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F87080", Offset = "0x1F85680", VA = "0x181F87080", Slot = "27")]
	public JKFONICFCFD EMLEGPOIABP(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return default(JKFONICFCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F86EE0", Offset = "0x1F854E0", VA = "0x181F86EE0", Slot = "28")]
	public bool EBKGAFMDMAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F86D60", Offset = "0x1F85360", VA = "0x181F86D60", Slot = "29")]
	public bool DJNPKGPPKDP(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F86800", Offset = "0x1F84E00", VA = "0x181F86800", Slot = "30")]
	public bool CLILKLFGMFB(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F87E10", Offset = "0x1F86410", VA = "0x181F87E10")]
	public PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> GGCDHAPNMKE([In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
	{
		return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F87F40", Offset = "0x1F86540", VA = "0x181F87F40", Slot = "32")]
	[AsyncStateMachine(typeof(KJLBBEOJEJM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HGIBNKFEIFA(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F86880", Offset = "0x1F84E80", VA = "0x181F86880", Slot = "33")]
	public PIJKHLBEMKP<MPHHGGPJIID, PFPHCNGMPPA> CMHLBCDLGHJ(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, MPHHGGPJIID AFLKEAAOOKI, PKPOPCCMEJH ENKHHNDEBMF)
	{
		return default(PIJKHLBEMKP<MPHHGGPJIID, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F884A0", Offset = "0x1F86AA0", VA = "0x181F884A0", Slot = "34")]
	[AsyncStateMachine(typeof(KOJJCLOFDGE))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> JINHDBNALAP(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> MBFOPOJGAGD, HBKKMIFHCOI<LMECHAAEJCH> IDJJGINOKHE, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F88170", Offset = "0x1F86770", VA = "0x181F88170", Slot = "35")]
	[AsyncStateMachine(typeof(IJIAFADFHCG))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HHBLHNKDOFC(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> DPNJBFHMCGO, HBKKMIFHCOI<LMECHAAEJCH> DPOODGMPBKI, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F88C90", Offset = "0x1F87290", VA = "0x181F88C90", Slot = "36")]
	public ALOMCECAJBD LJHLMHMLAKF(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return default(ALOMCECAJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F86450", Offset = "0x1F84A50", VA = "0x181F86450", Slot = "37")]
	public ALOMCECAJBD BGKFGOEHDBN()
	{
		return default(ALOMCECAJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F88F00", Offset = "0x1F87500", VA = "0x181F88F00")]
	private JALMFEGBLDJ LPMMOPCPOPL(ODKGEFHMPDC HEJAKDDPCGA, HBKKMIFHCOI<EKJMGNHJFDN> MJCMBENGNAC, IEnumerable<DAMOFJGJNKL<EKJMGNHJFDN>> LGIBPODGGCO, IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GKJNDKDCEAM)
	{
		return default(JALMFEGBLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F890B0", Offset = "0x1F876B0", VA = "0x181F890B0", Slot = "38")]
	public JALMFEGBLDJ LPMMOPCPOPL(ODKGEFHMPDC HEJAKDDPCGA, HBKKMIFHCOI<EKJMGNHJFDN> MJCMBENGNAC, IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GKJNDKDCEAM, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return default(JALMFEGBLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F87330", Offset = "0x1F85930", VA = "0x181F87330")]
	private static IEnumerable<DAMOFJGJNKL<EKJMGNHJFDN>> FKKEKBAGAFF(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F87970", Offset = "0x1F85F70", VA = "0x181F87970")]
	private IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GFMOPAEFJKN(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F87EB0", Offset = "0x1F864B0", VA = "0x181F87EB0", Slot = "39")]
	public List<BLAOHIBFJFL> HEAKFNBKMHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F86C70", Offset = "0x1F85270", VA = "0x181F86C70", Slot = "40")]
	public bool CMMPNHGOHAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F86F50", Offset = "0x1F85550", VA = "0x181F86F50")]
	internal void EDEPMIGIEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F893F0", Offset = "0x1F879F0", VA = "0x181F893F0")]
	internal Task MLIHHKAOCAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F89A40", Offset = "0x1F88040", VA = "0x181F89A40", Slot = "7")]
	private bool NPKCFOOHEPL(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F866E0", Offset = "0x1F84CE0", VA = "0x181F866E0", Slot = "10")]
	private GPMBAPNKEOC EGLPNEBIHEH([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F86080", Offset = "0x1F84680", VA = "0x181F86080", Slot = "11")]
	private HBKKMIFHCOI<EKJMGNHJFDN> APHAPEBEDEN([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(HBKKMIFHCOI<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F88B80", Offset = "0x1F87180", VA = "0x181F88B80", Slot = "12")]
	private HBKKMIFHCOI<EKJMGNHJFDN>? NLBIKJNDMGD([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F86710", Offset = "0x1F84D10", VA = "0x181F86710", Slot = "13")]
	private KIEKNELDHJG CHHELAOBPFO([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F872B0", Offset = "0x1F858B0", VA = "0x181F872B0", Slot = "14")]
	private HBKKMIFHCOI<JMIDFPKEEGG> HALNEMMHEPD(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] DAMOFJGJNKL<JMIDFPKEEGG> DCNPIEAMPAG)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F876B0", Offset = "0x1F85CB0", VA = "0x181F876B0", Slot = "18")]
	private IEnumerable<KIEKNELDHJG> GAHJOAFJMOC([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F86570", Offset = "0x1F84B70", VA = "0x181F86570", Slot = "25")]
	private OBFDOAMHKBB CAFOGNAGIOH(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(OBFDOAMHKBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F87E10", Offset = "0x1F86410", VA = "0x181F87E10", Slot = "31")]
	private PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> IJDLICELGBI([In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
	{
		return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F87880", Offset = "0x1F85E80", VA = "0x181F87880")]
	[CompilerGenerated]
	private KIEKNELDHJG GCNBHGPHHIF(CDJIOCDEIML JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F88350", Offset = "0x1F86950", VA = "0x181F88350")]
	[CompilerGenerated]
	private CFDDAHNNFCM JADMNPMOCGO(CNABLCLBOEK JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F86E70", Offset = "0x1F85470", VA = "0x181F86E70")]
	[CompilerGenerated]
	private CDJIOCDEIML DLKIMPCNGNF(DAMOFJGJNKL<JMIDFPKEEGG> JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F88B10", Offset = "0x1F87110", VA = "0x181F88B10")]
	[CompilerGenerated]
	private ICFEHOOIGAO JLMOMDLNGMA(DAMOFJGJNKL<EKJMGNHJFDN> JFDIHIMJIHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class CFDDAHNNFCM : OMFLEFMMLLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct IHLMAGEFBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HBKKMIFHCOI<KIADPJBFMAK>, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public CFDDAHNNFCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public DAMOFJGJNKL<EKJMGNHJFDN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public DAMOFJGJNKL<JMIDFPKEEGG> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<KIADPJBFMAK>, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FA07F0", Offset = "0x1F9EDF0", VA = "0x181FA07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0A70", Offset = "0x1F9F070", VA = "0x181FA0A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct BGJFABFAPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<HBKKMIFHCOI<KEBIIKCPPLB>, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public CFDDAHNNFCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public DAMOFJGJNKL<EKJMGNHJFDN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public DAMOFJGJNKL<JMIDFPKEEGG> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public HBKKMIFHCOI<LMECHAAEJCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<PIJKHLBEMKP<HBKKMIFHCOI<KEBIIKCPPLB>, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F9B0", Offset = "0x1F9DFB0", VA = "0x181F9F9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FC30", Offset = "0x1F9E230", VA = "0x181F9FC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly CNABLCLBOEK PCKJMPAJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly OKEJDJNOOIE IHPJMEOKAKE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey JDCCDBOEMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string DCCFDNCPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1F8B690", Offset = "0x1F89C90", VA = "0x181F8B690", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CNABLCLBOEK KFKPICPEIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B9A0", Offset = "0x1F89FA0", VA = "0x181F8B9A0")]
	public CFDDAHNNFCM(CNABLCLBOEK BDOLDCEGNBK, OKEJDJNOOIE NFKIECONLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B830", Offset = "0x1F89E30", VA = "0x181F8B830", Slot = "6")]
	[AsyncStateMachine(typeof(IHLMAGEFBDE))]
	public Task<PIJKHLBEMKP<HBKKMIFHCOI<KIADPJBFMAK>, NJADGKCOIIE>> NIJNNABMDJI(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B6C0", Offset = "0x1F89CC0", VA = "0x181F8B6C0", Slot = "7")]
	[AsyncStateMachine(typeof(BGJFABFAPFP))]
	public Task<PIJKHLBEMKP<HBKKMIFHCOI<KEBIIKCPPLB>, NJADGKCOIIE>> ELPCECMADAC(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, string LCLKDNPLMED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class OMHBDILNPHD : KBJGBHFDLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private readonly CNABLCLBOEK LICEJNGDJEL;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private static readonly HashSet<CNABLCLBOEK> MCJNLHAIGPC;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly HashSet<CNABLCLBOEK> KJGNOEPAAFM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static readonly HashSet<CNABLCLBOEK> DHLBHMJIGAK;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey IGAHPOGKKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2C10", Offset = "0x1FA1210", VA = "0x181FA2C10", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EBCECCENLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2C00", Offset = "0x1FA1200", VA = "0x181FA2C00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool AJALACGDKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2DD0", Offset = "0x1FA13D0", VA = "0x181FA2DD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool HBAPJPAGHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2B80", Offset = "0x1FA1180", VA = "0x181FA2B80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA18F0", Offset = "0x1F9FEF0", VA = "0x181FA18F0")]
	public bool OKMKNGIIOOJ(string CBAEIEAPLIH, [Out] JKOGPJHKOIC MFLJABKHCPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public OMHBDILNPHD(CNABLCLBOEK LIGKCFOOPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1760", Offset = "0x1F9FD60", VA = "0x181FA1760")]
	internal static TypeKey NDOPEFAOHPJ(CNABLCLBOEK PBLNJHEPKAE)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B690", Offset = "0x1F89C90", VA = "0x181F8B690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct LMHLFLOHEOA : OAJKKMGDBOO.ECFPAMJGJJM<LHAEFPHAKAB, HNKFFDNJINI>
{
	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1290", Offset = "0x1F9F890", VA = "0x181FA1290", Slot = "4")]
	public int EBDLGCFHBFK(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1280", Offset = "0x1F9F880", VA = "0x181FA1280", Slot = "5")]
	public LHAEFPHAKAB DCEEMHKKCGJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FA12B0", Offset = "0x1F9F8B0", VA = "0x181FA12B0", Slot = "6")]
	public LHAEFPHAKAB EMMAMFOOIDG(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1240", Offset = "0x1F9F840", VA = "0x181FA1240", Slot = "7")]
	public IReadOnlyList<LHAEFPHAKAB> CFMLLODKBLJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1340", Offset = "0x1F9F940", VA = "0x181FA1340", Slot = "8")]
	public LHAEFPHAKAB[] MCPMJGFCBPH(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ, int OBGBEPEHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1220", Offset = "0x1F9F820", VA = "0x181FA1220", Slot = "9")]
	public bool BBDJJHKHEOF(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FA12E0", Offset = "0x1F9F8E0", VA = "0x181FA12E0", Slot = "10")]
	public bool GCHBHHIKIOH(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1300", Offset = "0x1F9F900", VA = "0x181FA1300", Slot = "11")]
	public bool GJEEBCLJENJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1350", Offset = "0x1F9F950", VA = "0x181FA1350", Slot = "12")]
	public bool ODACACMOFCB(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1320", Offset = "0x1F9F920", VA = "0x181FA1320", Slot = "13")]
	public bool GPGPCNFFAPD(HNKFFDNJINI PEGGANACAPA, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1260", Offset = "0x1F9F860", VA = "0x181FA1260", Slot = "14")]
	public bool DBANGNDLDAC(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public abstract class PIGJBCIJHGL : FLCPFHBAPJH
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public DLGNBFFFJLN.GDHOOPFNBAJ DFEBHJNMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2F50", Offset = "0x1FA1550", VA = "0x181FA2F50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract KGDIMKMHBFE.MOIDLENAHHO OBBIHGEFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract JOOJDMJJLEH.MIHACBIPGMM NDGIKDHAFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract CJJOLICGHKG.FGAHFMCOIBE CLBLHFHBCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH> IMEGFBPJLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2FA0", Offset = "0x1FA15A0", VA = "0x181FA2FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract CPINABIIADF BHFCPAAJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract LJHDAPGEJJE CHKELOKKMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract NLGHLAJCHOD MNAIFDANDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract CEPHBLLCLBJ OBJDPMKPKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract AGBMMPAAEAL OLOMKCHBCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected PIGJBCIJHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PIIAPLMIGOD : JAENABDGMLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KDMPFDDLDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public PIIAPLMIGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public LHAEFPHAKAB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0AE0", Offset = "0x1F9F0E0", VA = "0x181FA0AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0D80", Offset = "0x1F9F380", VA = "0x181FA0D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct OKLEMDMCHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public PIIAPLMIGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IReadOnlyList<LHAEFPHAKAB> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1370", Offset = "0x1F9F970", VA = "0x181FA1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA16F0", Offset = "0x1F9FCF0", VA = "0x181FA16F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly PKBGPKAOHBH IPICGINFACB;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public PIIAPLMIGOD(PKBGPKAOHBH DFJCFKMIMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3120", Offset = "0x1FA1720", VA = "0x181FA3120")]
	[AsyncStateMachine(typeof(KDMPFDDLDPE))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EKKCLFIOMLH(LHAEFPHAKAB OGLJLDNLGIJ, bool EPJOLNMCGPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2FF0", Offset = "0x1FA15F0", VA = "0x181FA2FF0", Slot = "4")]
	[AsyncStateMachine(typeof(OKLEMDMCHNM))]
	public Task<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> AIIKEDNPNFF(IReadOnlyList<LHAEFPHAKAB> HAMKHHIHPNJ, bool EPJOLNMCGPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct PEPAPMHKFKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	internal FOMFGEDLPOL<LAIIPGLFFDO, LHAEFPHAKAB, EGKIGOBIHGJ> LICEJNGDJEL;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D240", Offset = "0x1F7B840", VA = "0x181F7D240")]
	private PEPAPMHKFKO([In] FOMFGEDLPOL<LAIIPGLFFDO, LHAEFPHAKAB, EGKIGOBIHGJ> AOEHMJKNPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2EF0", Offset = "0x1FA14F0", VA = "0x181FA2EF0")]
	public static PEPAPMHKFKO HCLFOFEHDJP()
	{
		return default(PEPAPMHKFKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class MEGPJFELEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x92F360", Offset = "0x92D960", VA = "0x18092F360")]
	public static FOMFGEDLPOL<LAIIPGLFFDO, LHAEFPHAKAB, EGKIGOBIHGJ> FGPNIHKGFBA(this PEPAPMHKFKO OLDDCPCBGIL)
	{
		return default(FOMFGEDLPOL<LAIIPGLFFDO, LHAEFPHAKAB, EGKIGOBIHGJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct EGKIGOBIHGJ : DHBHOKKKNNE.COLHCHBEECF<LAIIPGLFFDO, LHAEFPHAKAB>
{
	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FCA0", Offset = "0x1F9E2A0", VA = "0x181F9FCA0", Slot = "5")]
	public LHAEFPHAKAB KOPEFNAMCKL(LAIIPGLFFDO[] ENHIMKDFLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x15A10A0", Offset = "0x159F6A0", VA = "0x1815A10A0")]
	public int LBDKIEPAIEF([In] LAIIPGLFFDO EKOGPHNJFMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x15A10A0", Offset = "0x159F6A0", VA = "0x1815A10A0", Slot = "4")]
	private int KABLCHCDMAB([In] LAIIPGLFFDO CIGGNCELACH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct EJAAMGBHNOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	internal MDJMPLHOKKJ<GMLOAEMICEM, LHAEFPHAKAB, BBCCGNBNHOO> LICEJNGDJEL;

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D240", Offset = "0x1F7B840", VA = "0x181F7D240")]
	private EJAAMGBHNOH([In] MDJMPLHOKKJ<GMLOAEMICEM, LHAEFPHAKAB, BBCCGNBNHOO> GPNGODCEGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FE90", Offset = "0x1F9E490", VA = "0x181F9FE90")]
	public static EJAAMGBHNOH HCLFOFEHDJP()
	{
		return default(EJAAMGBHNOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class JHDHKEFPOLC
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x92F360", Offset = "0x92D960", VA = "0x18092F360")]
	public static MDJMPLHOKKJ<GMLOAEMICEM, LHAEFPHAKAB, BBCCGNBNHOO> FGPNIHKGFBA(this EJAAMGBHNOH OLDDCPCBGIL)
	{
		return default(MDJMPLHOKKJ<GMLOAEMICEM, LHAEFPHAKAB, BBCCGNBNHOO>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct BBCCGNBNHOO : IJGEFNBNJHM.EEGPBEIABJC<GMLOAEMICEM, LHAEFPHAKAB>
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x15A10A0", Offset = "0x159F6A0", VA = "0x1815A10A0")]
	public int FAAMDAHGCGF([In] GMLOAEMICEM EKOGPHNJFMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F7C0", Offset = "0x1F9DDC0", VA = "0x181F9F7C0", Slot = "5")]
	public LHAEFPHAKAB CEEFOGPAMMO(GMLOAEMICEM[] BNEPOBMHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x15A10A0", Offset = "0x159F6A0", VA = "0x1815A10A0", Slot = "4")]
	private int EIMMGOLGNMD([In] GMLOAEMICEM EKOGPHNJFMN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class LFACDBPJMBF : FNFMNGCMHCP, JKFFLAEBADK, NJADGKCOIIE, PFPHCNGMPPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private readonly PFPHCNGMPPA? FOEDJLLFNMB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public LEELBPOKNLO NIAJMMEOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(LEELBPOKNLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x865080", Offset = "0x863680", VA = "0x180865080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override PFPHCNGMPPA? AOHMEHBPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0FE0", Offset = "0x1F9F5E0", VA = "0x181FA0FE0", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1FA11E0", Offset = "0x1F9F7E0", VA = "0x181FA11E0")]
	private LFACDBPJMBF(LEELBPOKNLO JGHIAOJOLJP, PFPHCNGMPPA? KCLFHIGFABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1160", Offset = "0x1F9F760", VA = "0x181FA1160")]
	public static LFACDBPJMBF NBKHDIGNOGF(PFPHCNGMPPA KCLFHIGFABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0F00", Offset = "0x1F9F500", VA = "0x181FA0F00")]
	public static LFACDBPJMBF CJNPBGPNDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0F70", Offset = "0x1F9F570", VA = "0x181FA0F70")]
	public static LFACDBPJMBF HLFCMANLIPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class IGGGBOIOMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2B2FCF0", Offset = "0x2B2E2F0", VA = "0x182B2FCF0")]
	public static PIJKHLBEMKP<TOk, JKFFLAEBADK> CJCNDIEFBID<TOk>([In] this PIJKHLBEMKP<TOk, JKFFLAEBADK> OLDDCPCBGIL, PFPHCNGMPPA KCLFHIGFABJ) where TOk : notnull
	{
		return default(PIJKHLBEMKP<TOk, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2FED0", Offset = "0x2B2E4D0", VA = "0x182B2FED0")]
	public static PIJKHLBEMKP<TOk?, JKFFLAEBADK?> IHEKENIDPKG<TOk>([In] this PIJKHLBEMKP<TOk, JKFFLAEBADK> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<TOk, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2FDE0", Offset = "0x2B2E3E0", VA = "0x182B2FDE0")]
	public static PIJKHLBEMKP<TOk?, JKFFLAEBADK?> DOFBKIIGEDB<TOk>([In] this PIJKHLBEMKP<TOk, JKFFLAEBADK> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<TOk, JKFFLAEBADK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface CPINABIIADF
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIMALHKDFNK([In] PIJKHLBEMKP<HNKFFDNJINI, PFPHCNGMPPA> HJBJAPKPPFA);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class OANFFAIHBBH
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EF50", Offset = "0x2C8D550", VA = "0x182C8EF50")]
	public static bool KIMALHKDFNK<TOk, TErr>(this CPINABIIADF OLDDCPCBGIL, [In] PIJKHLBEMKP<TOk, TErr> HJBJAPKPPFA) where TOk : notnull where TErr : notnull, PFPHCNGMPPA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface LJHDAPGEJJE
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	NDEFAAFBGHP BCDFHICDHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public interface NLGHLAJCHOD
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEANJACADNF FOANOHJBDPM(int HAPMLKMMFPK);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface HFPDNPBJKDD
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface AOADNLJOINP
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEKLHAGDALI? NDGBGFIHAKL(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface HLABLDLKFJI
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface CEKLHAGDALI
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLABLDLKFJI? IBNKBPILKLJ(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HFPDNPBJKDD? CFEFMHAGOEJ(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface CEPHBLLCLBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FCHOMHALEAA(string CBAEIEAPLIH, string FFHIJMOJNAI);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface AGBMMPAAEAL
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOADNLJOINP? JKBMNAABMMH([In] DAMOFJGJNKL<BBDJCOABDOK> EGHFDFMIGII);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class ELFDIPBLPPB
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private struct KDMPHNKNGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public int FPNFNABMIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public OCCKDCOPHOC? JIIDJOGONEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public OCCKDCOPHOC? CGHEEKEGENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly List<LHAEFPHAKAB> NCAFLHECIBM;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0EB0", Offset = "0x1F9F4B0", VA = "0x181FA0EB0")]
		private KDMPHNKNGMG(int LLPJHIPCNFD, OCCKDCOPHOC? ENHKLDEEJND, OCCKDCOPHOC? GLIKJLJKENE, List<LHAEFPHAKAB> HAMKHHIHPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0DF0", Offset = "0x1F9F3F0", VA = "0x181FA0DF0")]
		public static KDMPHNKNGMG HCLFOFEHDJP()
		{
			return default(KDMPHNKNGMG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly EJLMCKJBBPD<KDMPHNKNGMG> GBDIEEKNCKJ;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static ELFDIPBLPPB IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1FA05F0", Offset = "0x1F9EBF0", VA = "0x181FA05F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool GHFDOGLHMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8B5660", Offset = "0x8B3C60", VA = "0x1808B5660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8470", Offset = "0x9B6A70", VA = "0x1809B8470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FEF0", Offset = "0x1F9E4F0", VA = "0x181F9FEF0")]
	public void BLBLLEIAEKH(MDDIMDPOMKC GLIKJLJKENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FFB0", Offset = "0x1F9E5B0", VA = "0x181F9FFB0")]
	public void HBMKADHEIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA02B0", Offset = "0x1F9E8B0", VA = "0x181FA02B0")]
	private static string? HCCEPKNLCIN([In] KDMPHNKNGMG KCOBPCPODIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0740", Offset = "0x1F9ED40", VA = "0x181FA0740")]
	public ELFDIPBLPPB()
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
