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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8D750", Offset = "0x1F8C750", VA = "0x181F8D750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F73240", Offset = "0x1F72240", VA = "0x181F73240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F73410", Offset = "0x1F72410", VA = "0x181F73410", Slot = "13")]
		public virtual void MCBEFAKCIDD(JOOJDMJJLEH KHALMCHEKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F73390", Offset = "0x1F72390", VA = "0x181F73390", Slot = "14")]
		public virtual void LGNGGGEOHDH(JOOJDMJJLEH KHALMCHEKDD, LHAEFPHAKAB OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8AC20", Offset = "0x1F89C20", VA = "0x181F8AC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		private MPEMBIIMIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB81860", Offset = "0xB80860", VA = "0x180B81860", Slot = "4")]
		public NJFHMKNMECP IOJBBFGABCC(LHAEFPHAKAB OLDDCPCBGIL)
		{
			return default(NJFHMKNMECP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D560", Offset = "0x1F8C560", VA = "0x181F8D560", Slot = "5")]
		public void MCBEFAKCIDD(JOOJDMJJLEH FMGEJNFFGHE, LHAEFPHAKAB OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D450", Offset = "0x1F8C450", VA = "0x181F8D450", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F89240", Offset = "0x1F88240", VA = "0x181F89240")]
		internal KBCHMFBOPII(NLMPMICJONI<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH, KNLGFLCJIEP.FCHBIPBEJEA<NJFHMKNMECP, LHAEFPHAKAB, JOOJDMJJLEH>> LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F891F0", Offset = "0x1F881F0", VA = "0x181F891F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F78D10", Offset = "0x1F77D10", VA = "0x181F78D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F78EF0", Offset = "0x1F77EF0", VA = "0x181F78EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8EC090", Offset = "0x8EB090", VA = "0x1808EC090", Slot = "4")]
		public HBKKMIFHCOI<EIKFNDMDOJI> BCKIGFDBJGI(JOOJDMJJLEH PMALGFDMMMA)
		{
			return default(HBKKMIFHCOI<EIKFNDMDOJI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A830", Offset = "0x1F79830", VA = "0x181F7A830", Slot = "5")]
		[AsyncStateMachine(typeof(FHJDJGPIHHG))]
		public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EJNDJKMCFEN(JOOJDMJJLEH PMALGFDMMMA, LHAEFPHAKAB OGLJLDNLGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A960", Offset = "0x1F79960", VA = "0x181F7A960", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8E030", Offset = "0x1F8D030", VA = "0x181F8E030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E2B0", Offset = "0x1F8D2B0", VA = "0x181F8E2B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F77050", Offset = "0x1F76050", VA = "0x181F77050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F772E0", Offset = "0x1F762E0", VA = "0x181F772E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8A620", Offset = "0x1F89620", VA = "0x181F8A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F8A800", Offset = "0x1F89800", VA = "0x181F8A800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F793B0", Offset = "0x1F783B0", VA = "0x181F793B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F795A0", Offset = "0x1F785A0", VA = "0x181F795A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F77350", Offset = "0x1F76350", VA = "0x181F77350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F77B40", Offset = "0x1F76B40", VA = "0x181F77B40", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x1840")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly FLCPFHBAPJH JJAMBPCFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1848")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MDDIMDPOMKC.NJFFLOAGOPF PCHIKGDKHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1868")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly LBKJEPDDNGL JLNBDLKFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1870")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly AKFANCKKAOE BDDIBKOLBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1878")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PBOABKNJFJD IKKHNBLIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1880")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EGLCBPFGBKA HNFAPJOPEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1888")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EJAAMGBHNOH IJJFDHMNGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1898")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PEPAPMHKFKO LJIHHEFGLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18B8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly MGBELDMDLPO.GGENEPMEDEA KHCOBIGDKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GOGFHKFMKHD NEMLJLDHEDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGBELDMDLPO MKLANBOJFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F88530", Offset = "0x1F87530", VA = "0x181F88530")]
		get
		{
			return default(MGBELDMDLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MIHACBIPGMM DEFGCMCDACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F87F40", Offset = "0x1F86F40", VA = "0x181F87F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KHELNPHJBOP ELKOBPOKPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F87A40", Offset = "0x1F86A40", VA = "0x181F87A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F88BD0", Offset = "0x1F87BD0", VA = "0x181F88BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NCEFEDCCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F87F90", Offset = "0x1F86F90", VA = "0x181F87F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F87A50", Offset = "0x1F86A50", VA = "0x181F87A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BJHLAKBJGKO AHKCKJGFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F891B0", Offset = "0x1F881B0", VA = "0x181F891B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EPJNNELGOGJ PNJEFMMMMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F891C0", Offset = "0x1F881C0", VA = "0x181F891C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DBFAAEPDDME CFBCEINFDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F891E0", Offset = "0x1F881E0", VA = "0x181F891E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DAJBIJHHEBH FMIEJFAPNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F891D0", Offset = "0x1F881D0", VA = "0x181F891D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MDDIMDPOMKC? EFDOHAAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F879C0", Offset = "0x1F869C0", VA = "0x181F879C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BGKNJNPOJIF? KKNJKGJMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F88D80", Offset = "0x1F87D80", VA = "0x181F88D80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F88EB0", Offset = "0x1F87EB0", VA = "0x181F88EB0")]
	private JOOJDMJJLEH(FLCPFHBAPJH ECFOBHKDIGL, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, [In] LMGAHOPAGKI JLNHNLIGONI, [In] MGBELDMDLPO NBKAOCGOJKK, [In] GKNKMINNEBL DCDAGCEPLJE, KHELNPHJBOP OGJHIBPCAOA, [In] MDDIMDPOMKC.NJFFLOAGOPF NBEHPNBHMMO, MGBELDMDLPO.GGENEPMEDEA DHNGJCGFLGH, GOGFHKFMKHD KLIMNIPMKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F87FA0", Offset = "0x1F86FA0", VA = "0x181F87FA0")]
	public static JOOJDMJJLEH HCLFOFEHDJP(FLCPFHBAPJH OJGLDAGFLKC, [In] BBELGPEHEBI DEFBBOJCBCK, NCOPDIDOCIJ LPJMNFNNLOL, [In] BFDEGALMMGL HNPLDPCJAKF, AGAJFDOBDMC MNNDPJJPNFJ, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, HBKKMIFHCOI<LEHJCLIPGBM> AGHFHJDAPPL, PKBGPKAOHBH DFJCFKMIMDO, HMJGLCBHCGJ AAGJOLOELMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F880E0", Offset = "0x1F870E0", VA = "0x181F880E0")]
	public static JOOJDMJJLEH HCLFOFEHDJP(FLCPFHBAPJH ECFOBHKDIGL, [In] MGBELDMDLPO NBKAOCGOJKK, [In] GKNKMINNEBL DCDAGCEPLJE, HBKKMIFHCOI<EIKFNDMDOJI> IGGMMJMDDDD, HBKKMIFHCOI<LEHJCLIPGBM> AGHFHJDAPPL, PKBGPKAOHBH DFJCFKMIMDO, HMJGLCBHCGJ AAGJOLOELMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F87D50", Offset = "0x1F86D50", VA = "0x181F87D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F87BF0", Offset = "0x1F86BF0", VA = "0x181F87BF0")]
	[AsyncStateMachine(typeof(PBJOEOAIELM))]
	internal Task<PIJKHLBEMKP<bool, NJADGKCOIIE>> DJLBJINGPJA(AGKNAGALEPM KCIKNADAAIN, OCCKDCOPHOC BFJKCBLPPNB, HMALNBKCNFI KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F88540", Offset = "0x1F87540", VA = "0x181F88540")]
	[AsyncStateMachine(typeof(CIBDEKDMHLB))]
	public Task<PIJKHLBEMKP<bool, NJADGKCOIIE>> JKOBDFLEEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F883C0", Offset = "0x1F873C0", VA = "0x181F883C0")]
	[AsyncStateMachine(typeof(LFJEDGHNPBB))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HFDBBMLFJME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F88630", Offset = "0x1F87630", VA = "0x181F88630")]
	internal void MBPGIGALLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F88BF0", Offset = "0x1F87BF0", VA = "0x181F88BF0")]
	internal GBGJJMPMMOC<LHAEFPHAKAB> MOMFKOJIMOL([In] GMLOAEMICEM NDCOKFIFMGK)
	{
		return default(GBGJJMPMMOC<LHAEFPHAKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F87B80", Offset = "0x1F86B80", VA = "0x181F87B80")]
	internal bool CIHMEDAFCPG([In] GMLOAEMICEM NDCOKFIFMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F884B0", Offset = "0x1F874B0", VA = "0x181F884B0")]
	internal GBGJJMPMMOC<LHAEFPHAKAB> HMFKABOOCKE([In] LAIIPGLFFDO FDNPBIEJGOL)
	{
		return default(GBGJJMPMMOC<LHAEFPHAKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F88C70", Offset = "0x1F87C70", VA = "0x181F88C70")]
	[AsyncStateMachine(typeof(GDBFAMGGILN))]
	internal Task<PIJKHLBEMKP<object, NJADGKCOIIE>> NDJLAKALMID(LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F88840", Offset = "0x1F87840", VA = "0x181F88840")]
	private LHAEFPHAKAB[] MCKGHELMHJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F87A60", Offset = "0x1F86A60", VA = "0x181F87A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CAD670", Offset = "0x2CAC670", VA = "0x182CAD670")]
	public static NNMPMPJEGIG<(TPrev?, JOOJDMJJLEH?), BGKNJNPOJIF> JKNAOKCDPCN<TPrev>([In] this NNMPMPJEGIG<TPrev, JOOJDMJJLEH> OLDDCPCBGIL)
	{
		return default(NNMPMPJEGIG<(TPrev, JOOJDMJJLEH), BGKNJNPOJIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD450", Offset = "0x2CAC450", VA = "0x182CAD450")]
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
		[Cpp2IlInjected.Address(RVA = "0x21A49A0", Offset = "0x21A39A0", VA = "0x1821A49A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x870C70", Offset = "0x86FC70", VA = "0x180870C70", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DD50", Offset = "0x4E7CD50", VA = "0x184E7DD50")]
	internal BFHDJNDBJBB([In] DAMOFJGJNKL<JMIDFPKEEGG>? OACAGPBNMGE, HBKKMIFHCOI<PMHAGHKACGK>? OMGHKGIDKJA, IOKind? OAKFCEGNGNA, string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JHAFFLBJMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F86ED0", Offset = "0x1F85ED0", VA = "0x181F86ED0")]
	public static PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP> GFJLDCMLPKE([In] this PBIHBOCMLOA<OHENAFGHCPN> OINKFFDGJFI)
	{
		return default(PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D330", Offset = "0x2B8C330", VA = "0x182B8D330")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F79C70", Offset = "0x1F78C70", VA = "0x181F79C70")]
	public static LHAEFPHAKAB IIEMMLHKEDE(this LHAEFPHAKAB OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F79BA0", Offset = "0x1F78BA0", VA = "0x181F79BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F79080", Offset = "0x1F78080", VA = "0x181F79080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F79340", Offset = "0x1F78340", VA = "0x181F79340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString BLBBIKKJHJE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	private DCNHMHCLPPM(ByteString CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F78380", Offset = "0x1F77380", VA = "0x181F78380")]
	public static LHAEFPHAKAB FBFCPOMMFGD(ByteString CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F78440", Offset = "0x1F77440", VA = "0x181F78440")]
	public static DGAGACGIHNN<NJFHMKNMECP, DCNHMHCLPPM> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, DCNHMHCLPPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F784F0", Offset = "0x1F774F0", VA = "0x181F784F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F78B80", Offset = "0x1F77B80", VA = "0x181F78B80")]
	public static LHAEFPHAKAB FBFCPOMMFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F78C20", Offset = "0x1F77C20", VA = "0x181F78C20")]
	public static DGAGACGIHNN<NJFHMKNMECP, FBILKGNAKEA> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, FBILKGNAKEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F78C90", Offset = "0x1F77C90", VA = "0x181F78C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F86210", Offset = "0x1F85210", VA = "0x181F86210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F86580", Offset = "0x1F85580", VA = "0x181F86580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1EAC1B0", Offset = "0x1EAB1B0", VA = "0x181EAC1B0")]
	private GJFJOGHGKEA(AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A4E0", Offset = "0x1F794E0", VA = "0x181F7A4E0")]
	public static LHAEFPHAKAB? FBFCPOMMFGD(AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A5E0", Offset = "0x1F795E0", VA = "0x181F7A5E0")]
	public static DGAGACGIHNN<NJFHMKNMECP, GJFJOGHGKEA> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, GJFJOGHGKEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A6F0", Offset = "0x1F796F0", VA = "0x181F7A6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F72B20", Offset = "0x1F71B20", VA = "0x181F72B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F72F90", Offset = "0x1F71F90", VA = "0x181F72F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<LHAEFPHAKAB> NCAFLHECIBM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	private OEDPDEBLMGB(IReadOnlyList<LHAEFPHAKAB> HAMKHHIHPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D7D0", Offset = "0x1F8C7D0", VA = "0x181F8D7D0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(IReadOnlyList<LHAEFPHAKAB> HAMKHHIHPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D890", Offset = "0x1F8C890", VA = "0x181F8D890")]
	public static DGAGACGIHNN<NJFHMKNMECP, OEDPDEBLMGB> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, OEDPDEBLMGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D930", Offset = "0x1F8C930", VA = "0x181F8D930")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AC57F0", Offset = "0x1AC47F0", VA = "0x181AC57F0")]
	private LAIIPGLFFDO(int JPBPNOCHNLG, int LLPJHIPCNFD, byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A1C0", Offset = "0x1F891C0", VA = "0x181F8A1C0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(int JPBPNOCHNLG, int LLPJHIPCNFD, ByteString FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A080", Offset = "0x1F89080", VA = "0x181F8A080")]
	public static LHAEFPHAKAB[] CNCPDILJHON(LHAEFPHAKAB OGLJLDNLGIJ, int KICHIPMPPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A2A0", Offset = "0x1F892A0", VA = "0x181F8A2A0")]
	public static DGAGACGIHNN<NJFHMKNMECP, LAIIPGLFFDO> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, LAIIPGLFFDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A380", Offset = "0x1F89380", VA = "0x181F8A380")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8AD20", Offset = "0x1F89D20", VA = "0x181F8AD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F8B360", Offset = "0x1F8A360", VA = "0x181F8B360", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AC57F0", Offset = "0x1AC47F0", VA = "0x181AC57F0")]
	private GMLOAEMICEM(int JPBPNOCHNLG, int LLPJHIPCNFD, byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F859B0", Offset = "0x1F849B0", VA = "0x181F859B0")]
	public static LHAEFPHAKAB FBFCPOMMFGD(int JPBPNOCHNLG, int LLPJHIPCNFD, ByteString FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F857B0", Offset = "0x1F847B0", VA = "0x181F857B0")]
	public static LHAEFPHAKAB?[]? AHOEGCAEODK(int KICHIPMPPLC, AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F85A90", Offset = "0x1F84A90", VA = "0x181F85A90")]
	public static DGAGACGIHNN<NJFHMKNMECP, GMLOAEMICEM> KPPJHKHFJHO(LHAEFPHAKAB NKBDONPMFNC)
	{
		return default(DGAGACGIHNN<NJFHMKNMECP, GMLOAEMICEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F85B70", Offset = "0x1F84B70", VA = "0x181F85B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8A510", Offset = "0x1F89510", VA = "0x181F8A510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
	public OLKOPFDMPBB(JOOJDMJJLEH KHALMCHEKDD, OKEJDJNOOIE NFKIECONLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DD50", Offset = "0x1F8CD50", VA = "0x181F8DD50", Slot = "4")]
	public PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP> IJGOJAPGDFA(DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED)
	{
		return default(PIJKHLBEMKP<GPECPCIFPIF, PINIHHMBGNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DA70", Offset = "0x1F8CA70", VA = "0x181F8DA70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F73000", Offset = "0x1F72000", VA = "0x181F73000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1F731D0", Offset = "0x1F721D0", VA = "0x181F731D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IEAMDDADLAO IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		private IEAMDDADLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F86890", Offset = "0x1F85890", VA = "0x181F86890", Slot = "4")]
		[AsyncStateMachine(typeof(AKMMFKEKLKE))]
		public Task<OKEJDJNOOIE> AGGCLAGFIIM(JOOJDMJJLEH KHALMCHEKDD, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F869F0", Offset = "0x1F859F0", VA = "0x181F869F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F87450", Offset = "0x1F86450", VA = "0x181F87450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F87950", Offset = "0x1F86950", VA = "0x181F87950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F78600", Offset = "0x1F77600", VA = "0x181F78600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BGKNJNPOJIF NHKAIKLFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F78820", Offset = "0x1F77820", VA = "0x181F78820", Slot = "5")]
		get
		{
			return default(BGKNJNPOJIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OLKOPFDMPBB DMMAAOPFCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D89C60", Offset = "0x1D88C60", VA = "0x181D89C60")]
	private DLGNBFFFJLN(OKEJDJNOOIE NFKIECONLKB, HBBDNIKPEOK PMBKGLBIAHE, OLKOPFDMPBB PHKEBLFJKHD, APGFLEHHNBL NPFJHJGNMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F786B0", Offset = "0x1F776B0", VA = "0x181F786B0")]
	[AsyncStateMachine(typeof(JMNEMPMJAIH))]
	public static Task<DLGNBFFFJLN> LGHHEPEAJLF(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F78650", Offset = "0x1F77650", VA = "0x181F78650", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F8A870", Offset = "0x1F89870", VA = "0x181F8A870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F8ABB0", Offset = "0x1F89BB0", VA = "0x181F8ABB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F89F20", Offset = "0x1F88F20", VA = "0x181F89F20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F76CB0", Offset = "0x1F75CB0", VA = "0x181F76CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F76EB0", Offset = "0x1F75EB0", VA = "0x181F76EB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F79610", Offset = "0x1F78610", VA = "0x181F79610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F79B40", Offset = "0x1F78B40", VA = "0x181F79B40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CFAC0", Offset = "0x9CEAC0", VA = "0x1809CFAC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA2B380", Offset = "0xA2A380", VA = "0x180A2B380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAE1ED0", Offset = "0xAE0ED0", VA = "0x180AE1ED0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE1EF0", Offset = "0xAE0EF0", VA = "0x180AE1EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DNBMPCFJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10E2900", Offset = "0x10E1900", VA = "0x1810E2900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F895F0", Offset = "0x1F885F0", VA = "0x181F895F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KIAAHGKKHGJ? LBGJFIIMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86FF10", Offset = "0x86EF10", VA = "0x18086FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F898D0", Offset = "0x1F888D0", VA = "0x181F898D0", Slot = "7")]
	[AsyncStateMachine(typeof(BGJPNAGDIHH))]
	public Task<KIAAHGKKHGJ> JHHJELLMFLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F899C0", Offset = "0x1F889C0", VA = "0x181F899C0")]
	public KGDIMKMHBFE(MOIDLENAHHO OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F89600", Offset = "0x1F88600", VA = "0x181F89600", Slot = "8")]
	[AsyncStateMachine(typeof(GFICLFMPLMA))]
	public Task CDNMIACPINI(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO, OCCKDCOPHOC? HBOIILPMFFP, HMALNBKCNFI? NOFBPPJFEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F89760", Offset = "0x1F88760", VA = "0x181F89760", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
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
			[Cpp2IlInjected.Address(RVA = "0xF1CDB0", Offset = "0xF1BDB0", VA = "0x180F1CDB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public HBKKMIFHCOI<EKJMGNHJFDN> HLPKLNNHMEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C416D0", Offset = "0x3C406D0", VA = "0x183C416D0", Slot = "5")]
			get
			{
				return default(HBKKMIFHCOI<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public HBKKMIFHCOI<EKJMGNHJFDN>? NFKIMIFBHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C416F0", Offset = "0x3C406F0", VA = "0x183C416F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F8AC30", Offset = "0x1F89C30", VA = "0x181F8AC30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AC50", Offset = "0x1F89C50", VA = "0x181F8AC50")]
		public MFPBHBBOFHB(AJENAFDLAAA MFGMLHGLKCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F86D40", Offset = "0x1F85D40", VA = "0x181F86D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F8FA00", Offset = "0x1F8EA00", VA = "0x181F8FA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FC70", Offset = "0x1F8EC70", VA = "0x181F8FC70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public KGLFKIGAKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F89AD0", Offset = "0x1F88AD0", VA = "0x181F89AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F85CA0", Offset = "0x1F84CA0", VA = "0x181F85CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F861B0", Offset = "0x1F851B0", VA = "0x181F861B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F8FCD0", Offset = "0x1F8ECD0", VA = "0x181F8FCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FFB0", Offset = "0x1F8EFB0", VA = "0x181F8FFB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BMCHDEODDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F76F80", Offset = "0x1F75F80", VA = "0x181F76F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F75A40", Offset = "0x1F74A40", VA = "0x181F75A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HBKKMIFHCOI<CHIHANCPCBA> GBCMGAGMECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D12A0", Offset = "0x8D02A0", VA = "0x1808D12A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<CHIHANCPCBA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB6CDF0", Offset = "0xB6BDF0", VA = "0x180B6CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private HBKKMIFHCOI<KIADPJBFMAK> OMDPHFGIEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAD80B0", Offset = "0xAD70B0", VA = "0x180AD80B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HBKKMIFHCOI<NIMJJIGJCLJ> MFDFJELCHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x88CF50", Offset = "0x88BF50", VA = "0x18088CF50", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F75E50", Offset = "0x1F74E50", VA = "0x181F75E50", Slot = "20")]
		get
		{
			return default(HBKKMIFHCOI<PMHAGHKACGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KOLFICBPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F75DD0", Offset = "0x1F74DD0", VA = "0x181F75DD0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F76A90", Offset = "0x1F75A90", VA = "0x181F76A90")]
	private BEILIFKJEAK(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, CDGMKFJFGMP OLIDFKMIIMI, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED, HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F74A80", Offset = "0x1F73A80", VA = "0x181F74A80")]
	public static BEILIFKJEAK HCLFOFEHDJP(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, CDGMKFJFGMP CPEKGDIIDKL, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED, bool FHGEKDMEAEP, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F74450", Offset = "0x1F73450", VA = "0x181F74450", Slot = "21")]
	protected override void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F74750", Offset = "0x1F73750", VA = "0x181F74750", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F74320", Offset = "0x1F73320", VA = "0x181F74320", Slot = "30")]
	public void AEKEEMHMPPE(DGDJLJHDIKF GJEKDFCFFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F75A60", Offset = "0x1F74A60", VA = "0x181F75A60", Slot = "27")]
	public void MLJNENCLEAO(FIGPFCCGJOI NDNAEFJAOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F760E0", Offset = "0x1F750E0", VA = "0x181F760E0", Slot = "28")]
	public void PKPMOKLBCIG(DMPIEPKAJAP MODBBIOCFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F74600", Offset = "0x1F73600", VA = "0x181F74600", Slot = "23")]
	protected override void DKAHAGGDDDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F74880", Offset = "0x1F73880", VA = "0x181F74880", Slot = "32")]
	public string GDKNOJAHPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F74FD0", Offset = "0x1F73FD0", VA = "0x181F74FD0", Slot = "29")]
	public string IJFEAEOPIOC(int EFEECMADLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F755F0", Offset = "0x1F745F0", VA = "0x181F755F0")]
	private void KKJEILLEOMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F75290", Offset = "0x1F74290", VA = "0x181F75290", Slot = "31")]
	public void JBMOIFJGCKD(DGDJLJHDIKF GJEKDFCFFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F75360", Offset = "0x1F74360", VA = "0x181F75360")]
	private void JKABDKMGEPF(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F75FD0", Offset = "0x1F74FD0", VA = "0x181F75FD0", Slot = "33")]
	[AsyncStateMachine(typeof(HGGDCKODMJJ))]
	public Task PEEAOLFNGJP(string CBAEIEAPLIH, bool JKHHFLMJJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F758F0", Offset = "0x1F748F0", VA = "0x181F758F0")]
	public void LLEJDEEAPOF(string CBAEIEAPLIH, bool JKHHFLMJJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F74E30", Offset = "0x1F73E30", VA = "0x181F74E30")]
	private void HIOJCLIDJNC(int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB6CDF0", Offset = "0xB6BDF0", VA = "0x180B6CDF0")]
	internal void GMPHGLEAJBB(HBKKMIFHCOI<CHIHANCPCBA> CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F75FC0", Offset = "0x1F74FC0", VA = "0x181F75FC0")]
	[CompilerGenerated]
	private void PDGHHLFJLMK(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F75530", Offset = "0x1F74530", VA = "0x181F75530")]
	[CompilerGenerated]
	private bool KKCLJOFJFIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F74260", Offset = "0x1F73260", VA = "0x181F74260")]
	[CompilerGenerated]
	private bool ADJBAOMFCID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F74380", Offset = "0x1F73380", VA = "0x181F74380")]
	[CompilerGenerated]
	private int GNIABEJIBJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F749F0", Offset = "0x1F739F0", VA = "0x181F749F0")]
	[CompilerGenerated]
	private bool GHPLLHGJGHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F75520", Offset = "0x1F74520", VA = "0x181F75520")]
	[CompilerGenerated]
	private void KGHOKPIKOEH(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F744F0", Offset = "0x1F734F0", VA = "0x181F744F0")]
	[CompilerGenerated]
	private bool COPCMBFMIJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F75EA0", Offset = "0x1F74EA0", VA = "0x181F75EA0")]
	[CompilerGenerated]
	private bool ODPFFDLHHFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F747F0", Offset = "0x1F737F0", VA = "0x181F747F0")]
	[CompilerGenerated]
	private bool FEHBIEICJJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F74380", Offset = "0x1F73380", VA = "0x181F74380")]
	[CompilerGenerated]
	private int AEKKOBFOGCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F75EF0", Offset = "0x1F74EF0", VA = "0x181F75EF0")]
	[CompilerGenerated]
	private bool OFPKJHDAHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F745B0", Offset = "0x1F735B0", VA = "0x181F745B0")]
	[CompilerGenerated]
	private int DJAFBEBNGMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F743D0", Offset = "0x1F733D0", VA = "0x181F743D0")]
	[CompilerGenerated]
	private void AOFCPJLPAAP(object CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F75820", Offset = "0x1F74820", VA = "0x181F75820")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DC330", Offset = "0x8DB330", VA = "0x1808DC330", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F76F20", Offset = "0x1F75F20", VA = "0x181F76F20")]
		public BLMGMLJBPBD(JOOJDMJJLEH KHALMCHEKDD, GDKMAHGNKEF LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class KIEKCBIFADF : FLHJOEBGJCE<MPMGHJCOJAK>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F89EB0", Offset = "0x1F88EB0", VA = "0x181F89EB0")]
		public KIEKCBIFADF(JOOJDMJJLEH KHALMCHEKDD, MPMGHJCOJAK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F89BC0", Offset = "0x1F88BC0", VA = "0x181F89BC0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F89E60", Offset = "0x1F88E60", VA = "0x181F89E60")]
		[CompilerGenerated]
		private bool PKJCFCJEODH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F89D40", Offset = "0x1F88D40", VA = "0x181F89D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public PDDLNKDCGLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F8C0", Offset = "0x1F8E8C0", VA = "0x181F8F8C0")]
			internal void COFCJKDJKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F9B0", Offset = "0x1F8E9B0", VA = "0x181F8F9B0")]
			internal bool PNOMNBKFDEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F910", Offset = "0x1F8E910", VA = "0x181F8F910")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F7A0", Offset = "0x1F8E7A0", VA = "0x181F8F7A0")]
			internal void BIBKJJFHCPP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F960", Offset = "0x1F8E960", VA = "0x181F8F960")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F89580", Offset = "0x1F88580", VA = "0x181F89580")]
		public KDDIDGCLBHL(JOOJDMJJLEH KHALMCHEKDD, IAIDDHAHKNK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F89250", Offset = "0x1F88250", VA = "0x181F89250", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public GHABKBGMKMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F79DD0", Offset = "0x1F78DD0", VA = "0x181F79DD0")]
			internal object COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F79ED0", Offset = "0x1F78ED0", VA = "0x181F79ED0")]
			internal bool EGEJICJNDOM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A290", Offset = "0x1F79290", VA = "0x181F7A290")]
			internal void PNOMNBKFDEO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F79FA0", Offset = "0x1F78FA0", VA = "0x181F79FA0")]
			internal string GNBJLDAOBME(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F79D80", Offset = "0x1F78D80", VA = "0x181F79D80")]
			internal IReadOnlyList<object> BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A100", Offset = "0x1F79100", VA = "0x181F7A100")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1F79F50", Offset = "0x1F78F50", VA = "0x181F79F50")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A170", Offset = "0x1F79170", VA = "0x181F7A170")]
			internal void NJDLMJNFPFI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F78310", Offset = "0x1F77310", VA = "0x181F78310")]
		public CPMFDOPKDBN(JOOJDMJJLEH KHALMCHEKDD, DCFOOGDEKOJ MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F77BB0", Offset = "0x1F76BB0", VA = "0x181F77BB0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public ACDHPNECILK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1F72960", Offset = "0x1F71960", VA = "0x181F72960")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F72A00", Offset = "0x1F71A00", VA = "0x181F72A00")]
			internal void PNOMNBKFDEO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F729B0", Offset = "0x1F719B0", VA = "0x181F729B0")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F86820", Offset = "0x1F85820", VA = "0x181F86820")]
		public IDKBIMBPKGO(JOOJDMJJLEH KHALMCHEKDD, HKGNMGMJOJF MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F865F0", Offset = "0x1F855F0", VA = "0x181F865F0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x38032C0", Offset = "0x38022C0", VA = "0x1838032C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x38036C0", Offset = "0x38026C0", VA = "0x1838036C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x38512B0", Offset = "0x38502B0", VA = "0x1838512B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x38516B0", Offset = "0x38506B0", VA = "0x1838516B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool HCINIAEOGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3C41BD0", Offset = "0x3C40BD0", VA = "0x183C41BD0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C41B80", Offset = "0x3C40B80", VA = "0x183C41B80")]
		protected FHGFOKLDGKI(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C41A60", Offset = "0x3C40A60", VA = "0x183C41A60", Slot = "100")]
		[AsyncStateMachine(typeof(FHGFOKLDGKI<>.EEOPCNJLKEK))]
		public override Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C41770", Offset = "0x3C40770", VA = "0x183C41770", Slot = "124")]
		public sealed override bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C419C0", Offset = "0x3C409C0", VA = "0x183C419C0", Slot = "112")]
		protected sealed override bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C41920", Offset = "0x3C40920", VA = "0x183C41920", Slot = "113")]
		protected override bool HPIHPMEFIMM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3C41810", Offset = "0x3C40810", VA = "0x183C41810", Slot = "101")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public MOJMOHNDAPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F8D310", Offset = "0x1F8C310", VA = "0x181F8D310")]
			internal bool DGFKBIDOBHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F8D390", Offset = "0x1F8C390", VA = "0x181F8D390")]
			internal void PEMCEBMGGDF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1F86CE0", Offset = "0x1F85CE0", VA = "0x181F86CE0")]
		public IKEIIDFCEOI(JOOJDMJJLEH KHALMCHEKDD, NKMLPHAGBLL LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F86A90", Offset = "0x1F85A90", VA = "0x181F86A90", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D6F0", Offset = "0x1F8C6F0", VA = "0x181F8D6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x57F6950", Offset = "0x57F5950", VA = "0x1857F6950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x57F6E10", Offset = "0x57F5E10", VA = "0x1857F6E10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x40982C0", Offset = "0x40972C0", VA = "0x1840982C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4098750", Offset = "0x4097750", VA = "0x184098750", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C41CC0", Offset = "0x3C40CC0", VA = "0x183C41CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x3C423A0", Offset = "0x3C413A0", VA = "0x183C423A0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3559280", Offset = "0x3558280", VA = "0x183559280", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public HNDCGIDLOMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D470", Offset = "0x3E0C470", VA = "0x183E0D470")]
			internal bool NJDLMJNFPFI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D0D0", Offset = "0x3E0C0D0", VA = "0x183E0D0D0")]
			internal void COFCJKDJKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D3D0", Offset = "0x3E0C3D0", VA = "0x183E0D3D0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.HNDCGIDLOMG.<<BuildConfigMenuInternal>b__7>d))]
			internal void EGEJICJNDOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D550", Offset = "0x3E0C550", VA = "0x183E0D550")]
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
				[Cpp2IlInjected.Address(RVA = "0x3558F00", Offset = "0x3557F00", VA = "0x183558F00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public PPIBKMPDKGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x47BA4F0", Offset = "0x47B94F0", VA = "0x1847BA4F0")]
			internal void GNBJLDAOBME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			internal string BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			internal void JHIMGCOAKHK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x47BA450", Offset = "0x47B9450", VA = "0x1847BA450")]
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
				[Cpp2IlInjected.Address(RVA = "0x3558A30", Offset = "0x3557A30", VA = "0x183558A30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3558C10", Offset = "0x3557C10", VA = "0x183558C10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3558360", Offset = "0x3557360", VA = "0x183558360", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public FCGDCCBPFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3C36910", Offset = "0x3C35910", VA = "0x183C36910")]
			internal bool ONPIDIDPOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3C36640", Offset = "0x3C35640", VA = "0x183C36640")]
			internal void LFGEBHEMPBI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3C36450", Offset = "0x3C35450", VA = "0x183C36450")]
			internal bool ICIEDPIMIGO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3C36770", Offset = "0x3C35770", VA = "0x183C36770")]
			internal bool MKJOEFBGAAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3C360B0", Offset = "0x3C350B0", VA = "0x183C360B0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void ABOKPBFHHGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3C363B0", Offset = "0x3C353B0", VA = "0x183C363B0")]
			internal bool HGPHPKHAINI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3C367B0", Offset = "0x3C357B0", VA = "0x183C367B0")]
			internal void NLDEJCBDCOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3C36980", Offset = "0x3C35980", VA = "0x183C36980")]
			internal bool PKIDKMGAMFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3C366B0", Offset = "0x3C356B0", VA = "0x183C366B0")]
			internal void LIGNGBLCHKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C36300", Offset = "0x3C35300", VA = "0x183C36300")]
			internal bool HGAFMNNMOFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3C36530", Offset = "0x3C35530", VA = "0x183C36530")]
			internal bool KCJKNEPBFLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C361B0", Offset = "0x3C351B0", VA = "0x183C361B0")]
			internal void AGMICKFGMLD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3C36870", Offset = "0x3C35870", VA = "0x183C36870")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void ONLFNCOHPIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3C363F0", Offset = "0x3C353F0", VA = "0x183C363F0")]
			internal bool IACCOMLLFPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3C36220", Offset = "0x3C35220", VA = "0x183C36220")]
			internal bool COEKPOLFOPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3C36290", Offset = "0x3C35290", VA = "0x183C36290")]
			internal void GHKFAGGMILE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3C365A0", Offset = "0x3C355A0", VA = "0x183C365A0")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.FCGDCCBPFBN.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void KFEHNALNICH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3C36150", Offset = "0x3C35150", VA = "0x183C36150")]
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
				[Cpp2IlInjected.Address(RVA = "0x3558650", Offset = "0x3557650", VA = "0x183558650", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JFEPBEJLEKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x409E430", Offset = "0x409D430", VA = "0x18409E430")]
			internal void EBDKEMIFPEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			internal string ILLGCNKMOND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			internal void JLFCICICODH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x409E7E0", Offset = "0x409D7E0", VA = "0x18409E7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public EOAGGAEBDAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x38535E0", Offset = "0x38525E0", VA = "0x1838535E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public ELMMBHKOLOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3851080", Offset = "0x3850080", VA = "0x183851080")]
			internal void HPJOJGFPAEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3850FD0", Offset = "0x384FFD0", VA = "0x183850FD0")]
			internal bool BBBBGDMLGMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3851190", Offset = "0x3850190", VA = "0x183851190")]
			internal void PEPOEKBFOBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3851020", Offset = "0x3850020", VA = "0x183851020")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public PCNEMLPEJMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x476A9B0", Offset = "0x47699B0", VA = "0x18476A9B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x355A6F0", Offset = "0x35596F0", VA = "0x18355A6F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public LMDNDGNEFFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x42F6640", Offset = "0x42F5640", VA = "0x1842F6640")]
			internal int BDNGIENECEP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x42F6740", Offset = "0x42F5740", VA = "0x1842F6740")]
			internal void GKJPLFPDNAP(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30")]
			internal string PHOANBJAMJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42F6680", Offset = "0x42F5680", VA = "0x1842F6680")]
			[AsyncStateMachine(typeof(EICHAAEOEKA<>.LMDNDGNEFFC.<<CreatePortItemV2>b__3>d))]
			internal void DJKPEHBAOHA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x42F6980", Offset = "0x42F5980", VA = "0x1842F6980")]
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
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool OECMEGHGJHP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool CJOBNMGEJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool JPKDFJDDKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override HBKKMIFHCOI<EKJMGNHJFDN>? JPIPEBHBNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x380B280", Offset = "0x380A280", VA = "0x18380B280", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x380B560", Offset = "0x380A560", VA = "0x18380B560", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>>? JFBAEOIGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x380B340", Offset = "0x380A340", VA = "0x18380B340", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x380B060", Offset = "0x380A060", VA = "0x18380B060")]
		public EICHAAEOEKA(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "129")]
		protected virtual bool IJHPAIINKJF(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "130")]
		protected virtual bool FKJFMDJMLNN(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "131")]
		protected virtual bool AAGNCPHFPDL(int NCPNAPEGLLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "132")]
		protected virtual void HKBDALLHFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3807A90", Offset = "0x3806A90", VA = "0x183807A90", Slot = "124")]
		public override bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3808C50", Offset = "0x3807C50", VA = "0x183808C50", Slot = "100")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.DBKALNMINOO))]
		public override Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3807E20", Offset = "0x3806E20", VA = "0x183807E20", Slot = "101")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.JEHAMJKPJJF))]
		public override Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GPOOPJANOMH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x380AE50", Offset = "0x3809E50", VA = "0x18380AE50", Slot = "102")]
		public override void PDNKLEKFEGM(HBKKMIFHCOI<LMECHAAEJCH> LLPJHIPCNFD, HBKKMIFHCOI<LMECHAAEJCH> PKMPGPJICGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x38089C0", Offset = "0x38079C0", VA = "0x1838089C0", Slot = "103")]
		public override IEnumerable<LHAEFPHAKAB> HMCEGJOBJAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3807B30", Offset = "0x3806B30", VA = "0x183807B30")]
		[AsyncStateMachine(typeof(EICHAAEOEKA<>.FHJAFCHMPMO))]
		private Task<PIJKHLBEMKP<AAADCICHDIB, NJADGKCOIIE>> GBMGNGHOKNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "133")]
		protected virtual bool AIFNKOLNHIP(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "134")]
		protected virtual bool BOMFIBEKIKO(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "135")]
		protected virtual bool PCKLGBHAOFL(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "136")]
		protected virtual bool MECAGOIPMKN(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "137")]
		protected virtual bool LFELIIODPEA(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HPKBDAKMBNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "138")]
		protected virtual bool GJMLPGNLKDN(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HPKBDAKMBNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "139")]
		protected virtual bool IILBDALHGNI(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int JPLNJAGBMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "140")]
		protected virtual bool KGOLNABGGMC(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int JPLNJAGBMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "141")]
		protected virtual bool DMMEFNOOHEF(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int GONALOCEIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "142")]
		protected virtual bool EJKMFMBDKJI(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, int HDLCFJJFELF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3806690", Offset = "0x3805690", VA = "0x183806690", Slot = "143")]
		protected virtual List<OMFLEFMMLLM> BOGNEBAFEBH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "144")]
		protected virtual void LPAICJJNGMO(FCJJHIHCGFA AABAOMBBJAL, AOHGDNOPNMN ALBMKKDCCLG, JHMJLMFOOPE JFMKJOHFDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3807F30", Offset = "0x3806F30", VA = "0x183807F30", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x38096D0", Offset = "0x38086D0", VA = "0x1838096D0")]
		private AOHGDNOPNMN OJJKJOGMCGD(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3806930", Offset = "0x3805930", VA = "0x183806930")]
		private List<DADNPGGKCKI> EDNOPELEDIA(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, AOHGDNOPNMN IPMIOHOFJBK, bool NOPADGLPHDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3808D70", Offset = "0x3807D70", VA = "0x183808D70")]
		private List<DADNPGGKCKI> MBEMKAOEBLG(FCJJHIHCGFA AABAOMBBJAL, JHMJLMFOOPE JFMKJOHFDAC, CKCCDGBALKM JCEBAOIBEAD, bool NOPADGLPHDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3807C30", Offset = "0x3806C30", VA = "0x183807C30")]
		private OMFLEFMMLLM GCKGMMLPJIF(List<OMFLEFMMLLM> AHPACDJDBMJ, CKCCDGBALKM JCEBAOIBEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38065F0", Offset = "0x38055F0", VA = "0x1838065F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JLBFJPPGBBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F87370", Offset = "0x1F86370", VA = "0x181F87370")]
			internal int COFCJKDJKKN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1F873C0", Offset = "0x1F863C0", VA = "0x181F873C0")]
			internal void PNOMNBKFDEO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1F73690", Offset = "0x1F72690", VA = "0x181F73690")]
		public BBFFPDAEAJD(JOOJDMJJLEH KHALMCHEKDD, KDPOBFMJIDM MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1F734D0", Offset = "0x1F724D0", VA = "0x181F734D0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public FPDDNHLPMHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F78F60", Offset = "0x1F77F60", VA = "0x181F78F60")]
			internal int DGFKBIDOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F78FE0", Offset = "0x1F77FE0", VA = "0x181F78FE0")]
			internal void PEMCEBMGGDF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F78B20", Offset = "0x1F77B20", VA = "0x181F78B20")]
		public EENMOCNAKKM(JOOJDMJJLEH KHALMCHEKDD, EFBPPOANOOH LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1F788E0", Offset = "0x1F778E0", VA = "0x181F788E0", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D1F30", Offset = "0x8D0F30", VA = "0x1808D1F30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F8A4A0", Offset = "0x1F894A0", VA = "0x181F8A4A0")]
		public LBEIAMNMJNB(JOOJDMJJLEH KHALMCHEKDD, DCCPMHKKFLP MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public GKCHPCIOBFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F81890", Offset = "0x1F80890", VA = "0x181F81890")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F85700", Offset = "0x1F84700", VA = "0x181F85700")]
			internal void PNOMNBKFDEO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1F835F0", Offset = "0x1F825F0", VA = "0x181F835F0")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F829E0", Offset = "0x1F819E0", VA = "0x181F829E0")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F84580", Offset = "0x1F83580", VA = "0x181F84580")]
			internal void NJDLMJNFPFI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F85170", Offset = "0x1F84170", VA = "0x181F85170")]
			internal bool PHGCDCHIGEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F84430", Offset = "0x1F83430", VA = "0x181F84430")]
			internal bool NFPAOECPANG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F831C0", Offset = "0x1F821C0", VA = "0x181F831C0")]
			internal void IEJPHFBPPGM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F84C60", Offset = "0x1F83C60", VA = "0x181F84C60")]
			internal bool OJFPODJBBEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F84020", Offset = "0x1F83020", VA = "0x181F84020")]
			internal bool LPLKIPEEPHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F85110", Offset = "0x1F84110", VA = "0x181F85110")]
			internal void PHFABFMOBOJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F84CB0", Offset = "0x1F83CB0", VA = "0x181F84CB0")]
			internal bool ONCGAKHKEKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F843E0", Offset = "0x1F833E0", VA = "0x181F843E0")]
			internal bool NEEMEKBPNCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F82C80", Offset = "0x1F81C80", VA = "0x181F82C80")]
			internal bool GOGELNBBHKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F83AC0", Offset = "0x1F82AC0", VA = "0x181F83AC0")]
			internal bool KOHOPAENLNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F842A0", Offset = "0x1F832A0", VA = "0x181F842A0")]
			internal bool MNPMLJEHMFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F83F30", Offset = "0x1F82F30", VA = "0x181F83F30")]
			internal bool LNDKELOELAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F826A0", Offset = "0x1F816A0", VA = "0x181F826A0")]
			internal bool FGMMEKNCBNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F827F0", Offset = "0x1F817F0", VA = "0x181F827F0")]
			internal bool FMPPHCBINPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F850C0", Offset = "0x1F840C0", VA = "0x181F850C0")]
			internal bool PHEMHKBIFOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A980", Offset = "0x1F79980", VA = "0x181F7A980")]
			internal void AABEPMGDNFL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F833A0", Offset = "0x1F823A0", VA = "0x181F833A0")]
			internal bool IOAPOEINCEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F81E40", Offset = "0x1F80E40", VA = "0x181F81E40")]
			internal bool DIHFDMLMLJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F84800", Offset = "0x1F83800", VA = "0x181F84800")]
			internal bool NNDMOJJPGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F83440", Offset = "0x1F82440", VA = "0x181F83440")]
			internal bool IPNHNNBLGBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F83FD0", Offset = "0x1F82FD0", VA = "0x181F83FD0")]
			internal bool LPAEGCIBFGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F85300", Offset = "0x1F84300", VA = "0x181F85300")]
			internal bool PLBOFMPJLEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F80C30", Offset = "0x1F7FC30", VA = "0x181F80C30")]
			internal bool AHMOGLBOFCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F853E0", Offset = "0x1F843E0", VA = "0x181F853E0")]
			internal bool PMMGNMNJLGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F84950", Offset = "0x1F83950", VA = "0x181F84950")]
			internal void OANAPIABGJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F82A30", Offset = "0x1F81A30", VA = "0x181F82A30")]
			internal bool GIMPHAKGMPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F811B0", Offset = "0x1F801B0", VA = "0x181F811B0")]
			internal bool BOGBLHHFPHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F847A0", Offset = "0x1F837A0", VA = "0x181F847A0")]
			internal void NMIMFHMMIFE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F81D50", Offset = "0x1F80D50", VA = "0x181F81D50")]
			internal bool DFFDFOCCMHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F80D20", Offset = "0x1F7FD20", VA = "0x181F80D20")]
			internal bool ALGJIAIIHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1F84850", Offset = "0x1F83850", VA = "0x181F84850")]
			internal void NNEMOJCGAGK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F7AAD0", Offset = "0x1F79AD0", VA = "0x181F7AAD0")]
			internal List<DADNPGGKCKI> AGNCKHODNMM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F81060", Offset = "0x1F80060", VA = "0x181F81060")]
			internal bool BLCHCFCFAOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1F84200", Offset = "0x1F83200", VA = "0x181F84200")]
			internal int MLHOLMFCGKH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1F82740", Offset = "0x1F81740", VA = "0x181F82740")]
			internal void FLGMJGPOPEA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F82160", Offset = "0x1F81160", VA = "0x181F82160")]
			internal bool ECCEIKAMEIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F82CD0", Offset = "0x1F81CD0", VA = "0x181F82CD0")]
			internal bool GPBIBENBKMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F83120", Offset = "0x1F82120", VA = "0x181F83120")]
			internal bool ICHOPIOGIAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F823D0", Offset = "0x1F813D0", VA = "0x181F823D0")]
			internal int ENIGBBIKDCP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F81C00", Offset = "0x1F80C00", VA = "0x181F81C00")]
			internal void DDLDEJAIIPB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F83820", Offset = "0x1F82820", VA = "0x181F83820")]
			internal bool JNBKIKPHNIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F81250", Offset = "0x1F80250", VA = "0x181F81250")]
			internal bool CBBMAOFECIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F80F70", Offset = "0x1F7FF70", VA = "0x181F80F70")]
			internal bool BHGDFHILMOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F81AF0", Offset = "0x1F80AF0", VA = "0x181F81AF0")]
			internal bool DCMNMOHCDJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F83080", Offset = "0x1F82080", VA = "0x181F83080")]
			internal bool HPDDJKKAHPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F82BE0", Offset = "0x1F81BE0", VA = "0x181F82BE0")]
			internal bool GOEGJOMNEEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F841B0", Offset = "0x1F831B0", VA = "0x181F841B0")]
			internal string MJNOBOHJPNF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1F82E60", Offset = "0x1F81E60", VA = "0x181F82E60")]
			internal void HDLAKIAKDHC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F84B00", Offset = "0x1F83B00", VA = "0x181F84B00")]
			internal int OEHFIPEAPEK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F84E40", Offset = "0x1F83E40", VA = "0x181F84E40")]
			internal void PBPPGGGFEJP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F84EF0", Offset = "0x1F83EF0", VA = "0x181F84EF0")]
			internal bool PCMIIMCIJJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F84A00", Offset = "0x1F83A00", VA = "0x181F84A00")]
			internal bool OBNHKELNKNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F84340", Offset = "0x1F83340", VA = "0x181F84340")]
			internal bool NBMOHKHDPBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F840C0", Offset = "0x1F830C0", VA = "0x181F840C0")]
			internal float MCOHOCECNGN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F825F0", Offset = "0x1F815F0", VA = "0x181F825F0")]
			internal void FBAFIKDKCAE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F82200", Offset = "0x1F81200", VA = "0x181F82200")]
			internal bool EFEHNJLPNFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A9E0", Offset = "0x1F799E0", VA = "0x181F7A9E0")]
			internal bool ABFLMAAOJEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F80E10", Offset = "0x1F7FE10", VA = "0x181F80E10")]
			internal bool ANABGICCCNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F83BC0", Offset = "0x1F82BC0", VA = "0x181F83BC0")]
			internal bool LAKCLJJAILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1F849B0", Offset = "0x1F839B0", VA = "0x181F849B0")]
			internal bool OBAJAFIAILM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1F81BB0", Offset = "0x1F80BB0", VA = "0x181F81BB0")]
			internal bool DCPPNNPDKGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F81430", Offset = "0x1F80430", VA = "0x181F81430")]
			internal void CJIOFJICENI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F84250", Offset = "0x1F83250", VA = "0x181F84250")]
			internal string MLJFNMPKCHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F80F00", Offset = "0x1F7FF00", VA = "0x181F80F00")]
			internal void BELPPJBNLJL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F83A70", Offset = "0x1F82A70", VA = "0x181F83A70")]
			internal bool KOFCFNBMMPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F825A0", Offset = "0x1F815A0", VA = "0x181F825A0")]
			internal bool FAMJKOALMCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F81A50", Offset = "0x1F80A50", VA = "0x181F81A50")]
			internal bool DCAMALJCKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F85430", Offset = "0x1F84430", VA = "0x181F85430")]
			internal void PNCHFEPNBGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F81950", Offset = "0x1F80950", VA = "0x181F81950")]
			internal bool DADKAEPJMKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F82DC0", Offset = "0x1F81DC0", VA = "0x181F82DC0")]
			internal bool HCIFJOCBKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F84AB0", Offset = "0x1F83AB0", VA = "0x181F84AB0")]
			internal bool ODLPODBFOEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F812A0", Offset = "0x1F802A0", VA = "0x181F812A0")]
			internal bool CGHMBPHILKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F846A0", Offset = "0x1F836A0", VA = "0x181F846A0")]
			internal void NJMIAFNIAPH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F82110", Offset = "0x1F81110", VA = "0x181F82110")]
			internal bool EAJHKLKEAEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F84DA0", Offset = "0x1F83DA0", VA = "0x181F84DA0")]
			internal bool OPEKOOBHMOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F842F0", Offset = "0x1F832F0", VA = "0x181F842F0")]
			internal bool MODHGHNOJJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F83870", Offset = "0x1F82870", VA = "0x181F83870")]
			internal bool JPAMEMNMEKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1F83490", Offset = "0x1F82490", VA = "0x181F83490")]
			internal void JCHIADFHCDP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F83C10", Offset = "0x1F82C10", VA = "0x181F83C10")]
			internal bool LBCLBMHIFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F81E90", Offset = "0x1F80E90", VA = "0x181F81E90")]
			internal bool DILLHNOLMCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F82650", Offset = "0x1F81650", VA = "0x181F82650")]
			internal bool FDCBJOLDFLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F828A0", Offset = "0x1F818A0", VA = "0x181F828A0")]
			internal bool GCONCEPJLPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F83030", Offset = "0x1F82030", VA = "0x181F83030")]
			internal int HPBHKHECCOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F84F90", Offset = "0x1F83F90", VA = "0x181F84F90")]
			internal void PEJGPKGMMOC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F83960", Offset = "0x1F82960", VA = "0x181F83960")]
			internal bool KEPAKJPCJHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F852B0", Offset = "0x1F842B0", VA = "0x181F852B0")]
			internal bool PKGEBNJMHAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F81F30", Offset = "0x1F80F30", VA = "0x181F81F30")]
			internal int DKHJHAHJKLM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F84A50", Offset = "0x1F83A50", VA = "0x181F84A50")]
			internal void OCDBODJEGHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F85210", Offset = "0x1F84210", VA = "0x181F85210")]
			internal bool PIDLBNAHLFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F82C30", Offset = "0x1F81C30", VA = "0x181F82C30")]
			internal bool GOGDMAPEJDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F82B90", Offset = "0x1F81B90", VA = "0x181F82B90")]
			internal int GNFFFAMFODP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F84C00", Offset = "0x1F83C00", VA = "0x181F84C00")]
			internal void OIMMMFNDMPE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F84B50", Offset = "0x1F83B50", VA = "0x181F84B50")]
			internal bool OFABAOGHMOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F84530", Offset = "0x1F83530", VA = "0x181F84530")]
			internal bool NIDLLBCBJLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F82070", Offset = "0x1F81070", VA = "0x181F82070")]
			internal bool DNOGIAFCOKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F81840", Offset = "0x1F80840", VA = "0x181F81840")]
			internal int CLFNJLOJKIK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F819A0", Offset = "0x1F809A0", VA = "0x181F819A0")]
			internal void DAOAGECJHIF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F82420", Offset = "0x1F81420", VA = "0x181F82420")]
			internal bool EOBBKDLLAOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F82020", Offset = "0x1F81020", VA = "0x181F82020")]
			internal bool DMKHCLNEMOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F81390", Offset = "0x1F80390", VA = "0x181F81390")]
			internal bool CHDOAKJHGHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F82360", Offset = "0x1F81360", VA = "0x181F82360")]
			internal object ELBBBPBEACM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F85350", Offset = "0x1F84350", VA = "0x181F85350")]
			internal void PLDABBCKLHK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F83910", Offset = "0x1F82910", VA = "0x181F83910")]
			internal bool KEGDCGBJKCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1F85760", Offset = "0x1F84760", VA = "0x181F85760")]
			internal bool PPDKIBPDNDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F83D70", Offset = "0x1F82D70", VA = "0x181F83D70")]
			internal object LIDMDJBGBLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F83EA0", Offset = "0x1F82EA0", VA = "0x181F83EA0")]
			internal void LMAFJAOGFFB(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F82B40", Offset = "0x1F81B40", VA = "0x181F82B40")]
			internal bool GLPPKKAAFGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F84070", Offset = "0x1F83070", VA = "0x181F84070")]
			internal int MANFMJPGDME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F83B10", Offset = "0x1F82B10", VA = "0x181F83B10")]
			internal void LAAKFIJBGPG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F810B0", Offset = "0x1F800B0", VA = "0x181F810B0")]
			internal bool BLLKNMEODLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F82ED0", Offset = "0x1F81ED0", VA = "0x181F82ED0")]
			internal bool HFFPGGFJDEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F84D00", Offset = "0x1F83D00", VA = "0x181F84D00")]
			internal bool OPAOANFGPDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F839B0", Offset = "0x1F829B0", VA = "0x181F839B0")]
			internal int KGCEBDGGEOO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F82840", Offset = "0x1F81840", VA = "0x181F82840")]
			internal void FOAGNHBPAML(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1F848B0", Offset = "0x1F838B0", VA = "0x181F848B0")]
			internal bool NOBPGIINKGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F83550", Offset = "0x1F82550", VA = "0x181F83550")]
			internal bool JFIHGIPNMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1F84480", Offset = "0x1F83480", VA = "0x181F84480")]
			internal bool NGBDKMGPLKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F80E60", Offset = "0x1F7FE60", VA = "0x181F80E60")]
			internal float APADPAMILMF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1F844D0", Offset = "0x1F834D0", VA = "0x181F844D0")]
			internal void NHFHMEKHJDH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1F83F80", Offset = "0x1F82F80", VA = "0x181F83F80")]
			internal bool LNKCKJACLBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1F81FD0", Offset = "0x1F80FD0", VA = "0x181F81FD0")]
			internal bool DLMNCLIKECF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1F84EA0", Offset = "0x1F83EA0", VA = "0x181F84EA0")]
			internal bool PCDCMEGLLKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1F82E10", Offset = "0x1F81E10", VA = "0x181F82E10")]
			internal float HDAPBNKPPAI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1F834F0", Offset = "0x1F824F0", VA = "0x181F834F0")]
			internal void JDAGEPLGOEG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1F80D70", Offset = "0x1F7FD70", VA = "0x181F80D70")]
			internal bool ALOJLKBELFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1F817F0", Offset = "0x1F807F0", VA = "0x181F817F0")]
			internal bool CKLNGILOCKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1F820C0", Offset = "0x1F810C0", VA = "0x181F820C0")]
			internal string DOOECFMPLOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1F822F0", Offset = "0x1F812F0", VA = "0x181F822F0")]
			internal void EJDKJKMIFNH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1F812F0", Offset = "0x1F802F0", VA = "0x181F812F0")]
			internal bool CGPKOCNCDJA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1F84D50", Offset = "0x1F83D50", VA = "0x181F84D50")]
			internal bool OPCLCCKBDNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1F7AA80", Offset = "0x1F79A80", VA = "0x181F7AA80")]
			internal bool AGEHIKNCILL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1F82940", Offset = "0x1F81940", VA = "0x181F82940")]
			internal bool GDKDPPDAMCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1F81D00", Offset = "0x1F80D00", VA = "0x181F81D00")]
			internal string DFDGPIOGNIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1F83E30", Offset = "0x1F82E30", VA = "0x181F83E30")]
			internal void LLIKJMMDLIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1F85070", Offset = "0x1F84070", VA = "0x181F85070")]
			internal bool PGGPCJLGDJK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F84900", Offset = "0x1F83900", VA = "0x181F84900")]
			internal bool NOCCBILFMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1F81200", Offset = "0x1F80200", VA = "0x181F81200")]
			internal bool BPBMHAJOKNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1F80FC0", Offset = "0x1F7FFC0", VA = "0x181F80FC0")]
			internal bool BIPMMPJPBHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1F83290", Offset = "0x1F82290", VA = "0x181F83290")]
			internal string IKHOFNCLFHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1F82F20", Offset = "0x1F81F20", VA = "0x181F82F20")]
			internal void HGCODBELDPD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1F83B70", Offset = "0x1F82B70", VA = "0x181F83B70")]
			internal bool LAECICMJNKG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81DF0", Offset = "0x1F80DF0", VA = "0x181F81DF0")]
			internal bool DHFKIODNNPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1F838C0", Offset = "0x1F828C0", VA = "0x181F838C0")]
			internal bool KEDPKLFHDOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F81010", Offset = "0x1F80010", VA = "0x181F81010")]
			internal bool BKJFOKIAHNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F7AA30", Offset = "0x1F79A30", VA = "0x181F7AA30")]
			internal string ADJMPGOEIHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1F83220", Offset = "0x1F82220", VA = "0x181F83220")]
			internal void IGPNAOMLPPH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1F82D20", Offset = "0x1F81D20", VA = "0x181F82D20")]
			internal bool GPEFCNNKCOO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F80CD0", Offset = "0x1F7FCD0", VA = "0x181F80CD0")]
			internal bool ALBBHPKEDGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1F84F40", Offset = "0x1F83F40", VA = "0x181F84F40")]
			internal bool PCOLMBEJPAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1F81A00", Offset = "0x1F80A00", VA = "0x181F81A00")]
			internal bool DBILMEGPFFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1F84110", Offset = "0x1F83110", VA = "0x181F84110")]
			internal string MDHKLMJKLIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1F83330", Offset = "0x1F82330", VA = "0x181F83330")]
			internal void IMOLMGPHGIB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1F83D20", Offset = "0x1F82D20", VA = "0x181F83D20")]
			internal bool LDHCOPDCAKH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1F83690", Offset = "0x1F82690", VA = "0x181F83690")]
			internal bool JJAMLOFNLHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1F80DC0", Offset = "0x1F7FDC0", VA = "0x181F80DC0")]
			internal bool AMAIDHHJLCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1F84390", Offset = "0x1F83390", VA = "0x181F84390")]
			internal bool NDLPLJLJKGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1F835A0", Offset = "0x1F825A0", VA = "0x181F835A0")]
			internal string JGBKLNAABJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81B40", Offset = "0x1F80B40", VA = "0x181F81B40")]
			internal void DCNDPKKCGGD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1F81C60", Offset = "0x1F80C60", VA = "0x181F81C60")]
			internal bool DDMANHDDJOA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1F82FE0", Offset = "0x1F81FE0", VA = "0x181F82FE0")]
			internal bool HMOIFMNOLAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1F84DF0", Offset = "0x1F83DF0", VA = "0x181F84DF0")]
			internal bool PBDFAOMOBIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1F82250", Offset = "0x1F81250", VA = "0x181F82250")]
			internal bool EIIMKMGGDJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1F845E0", Offset = "0x1F835E0", VA = "0x181F845E0")]
			internal string NJFOMCFBPKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F83C60", Offset = "0x1F82C60", VA = "0x181F83C60")]
			internal void LBDPJFBJDEM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F83DE0", Offset = "0x1F82DE0", VA = "0x181F83DE0")]
			internal bool LKDCBKODKPA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F83170", Offset = "0x1F82170", VA = "0x181F83170")]
			internal bool ICLIPADCDBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F84750", Offset = "0x1F83750", VA = "0x181F84750")]
			internal bool NLIGPAKDHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1F827A0", Offset = "0x1F817A0", VA = "0x181F827A0")]
			internal bool FMIMHCKBJOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1F81CB0", Offset = "0x1F80CB0", VA = "0x181F81CB0")]
			internal string DECPAPHPLEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1F824C0", Offset = "0x1F814C0", VA = "0x181F824C0")]
			internal void EPHIIOKIONB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1F84160", Offset = "0x1F83160", VA = "0x181F84160")]
			internal bool MIBHCJGAIEK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1F837D0", Offset = "0x1F827D0", VA = "0x181F837D0")]
			internal bool JMNIPLKELDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1F83640", Offset = "0x1F82640", VA = "0x181F83640")]
			internal bool JIHGJMPEHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81100", Offset = "0x1F80100", VA = "0x181F81100")]
			internal bool BMIPCHLBJJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F85260", Offset = "0x1F84260", VA = "0x181F85260")]
			internal string PKDCKCGIDDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F818E0", Offset = "0x1F808E0", VA = "0x181F818E0")]
			internal void CPPNAENKOAA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F821B0", Offset = "0x1F811B0", VA = "0x181F821B0")]
			internal bool EDJFMEAJBMA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F813E0", Offset = "0x1F803E0", VA = "0x181F813E0")]
			internal bool CHIMFHEMOHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F828F0", Offset = "0x1F818F0", VA = "0x181F828F0")]
			internal bool GDCGDOLGLHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F832E0", Offset = "0x1F822E0", VA = "0x181F832E0")]
			internal bool ILAFMIPJMJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F830D0", Offset = "0x1F820D0", VA = "0x181F830D0")]
			internal string ICHBEGFCMIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F83A00", Offset = "0x1F82A00", VA = "0x181F83A00")]
			internal void KMLEJHJIFHE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F836E0", Offset = "0x1F826E0", VA = "0x181F836E0")]
			internal bool JKPFBJFLBMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F822A0", Offset = "0x1F812A0", VA = "0x181F822A0")]
			internal bool EJBAJKJAJGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F81F80", Offset = "0x1F80F80", VA = "0x181F81F80")]
			internal bool DLHNLAMPDPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F80EB0", Offset = "0x1F7FEB0", VA = "0x181F80EB0")]
			internal string BEDMJCMHLMC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F84630", Offset = "0x1F83630", VA = "0x181F84630")]
			internal void NJLJLEECBBM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F85020", Offset = "0x1F84020", VA = "0x181F85020")]
			internal bool PFMDMNEKEKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1F851C0", Offset = "0x1F841C0", VA = "0x181F851C0")]
			internal bool PIAILGCODDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81AA0", Offset = "0x1F80AA0", VA = "0x181F81AA0")]
			internal bool DCBAFLLEBMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1F833F0", Offset = "0x1F823F0", VA = "0x181F833F0")]
			internal string IPFNIEJPNIH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1F82530", Offset = "0x1F81530", VA = "0x181F82530")]
			internal void FALKMCLKIKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1F826F0", Offset = "0x1F816F0", VA = "0x181F826F0")]
			internal bool FLBFPAIFIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1F82AF0", Offset = "0x1F81AF0", VA = "0x181F82AF0")]
			internal bool GLAMEDAKADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1F81340", Offset = "0x1F80340", VA = "0x181F81340")]
			internal bool CHCMNFBFKPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1F84700", Offset = "0x1F83700", VA = "0x181F84700")]
			internal string NKLIJBEBCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F82A80", Offset = "0x1F81A80", VA = "0x181F82A80")]
			internal void GKBOLJGPDKC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F83CD0", Offset = "0x1F82CD0", VA = "0x181F83CD0")]
			internal bool LCJCPAGAGDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F80C80", Offset = "0x1F7FC80", VA = "0x181F80C80")]
			internal bool AJGJADNNKMJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F82990", Offset = "0x1F81990", VA = "0x181F82990")]
			internal float GEBHOEBMHAM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1F84BA0", Offset = "0x1F83BA0", VA = "0x181F84BA0")]
			internal void OFEFEOENOHN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1F81EE0", Offset = "0x1F80EE0", VA = "0x181F81EE0")]
			internal bool DJDCNBCCNGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1F83780", Offset = "0x1F82780", VA = "0x181F83780")]
			internal bool JLLLJJEMJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1F81DA0", Offset = "0x1F80DA0", VA = "0x181F81DA0")]
			internal bool DFJACGBHKLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1F83730", Offset = "0x1F82730", VA = "0x181F83730")]
			internal int JLFPMKBLLPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81150", Offset = "0x1F80150", VA = "0x181F81150")]
			internal void BMLCNHLKGID(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1F82470", Offset = "0x1F81470", VA = "0x181F82470")]
			internal bool EOIIGBPIIFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1F82F90", Offset = "0x1F81F90", VA = "0x181F82F90")]
			internal bool HHIKBHCFKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1F82D70", Offset = "0x1F81D70", VA = "0x181F82D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public BCPNGEOGKCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1F73700", Offset = "0x1F72700", VA = "0x181F73700")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public ANKMHEJMLCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1F73450", Offset = "0x1F72450", VA = "0x181F73450")]
			internal bool KCHHBDMFHEO(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly GEOEJKJFPIP JEGDACJMHJK;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D1B0", Offset = "0x1F8C1B0", VA = "0x181F8D1B0")]
		public MINONEPGMEP(JOOJDMJJLEH KHALMCHEKDD, OGGCHEHFLEB MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1F8B3D0", Offset = "0x1F8A3D0", VA = "0x181F8B3D0", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x1FAC0D0", Offset = "0x1FAB0D0", VA = "0x181FAC0D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public DMOFFCDKNAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F99F30", Offset = "0x1F98F30", VA = "0x181F99F30")]
			internal string COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F99FD0", Offset = "0x1F98FD0", VA = "0x181F99FD0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PNOMNBKFDEO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F99F80", Offset = "0x1F98F80", VA = "0x181F99F80")]
			internal int GNBJLDAOBME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F99EA0", Offset = "0x1F98EA0", VA = "0x181F99EA0")]
			internal void BIBKJJFHCPP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9280", Offset = "0x1FA8280", VA = "0x181FA9280")]
		public KGLBMNHOHAF(JOOJDMJJLEH KHALMCHEKDD, BMPCIECJHMI LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8F30", Offset = "0x1FA7F30", VA = "0x181FA8F30", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x1FAC3E0", Offset = "0x1FAB3E0", VA = "0x181FAC3E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1FAC720", Offset = "0x1FAB720", VA = "0x181FAC720", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JFOGDJBKMAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7770", Offset = "0x1FA6770", VA = "0x181FA7770")]
			internal string COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7C40", Offset = "0x1FA6C40", VA = "0x181FA7C40")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PNOMNBKFDEO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7970", Offset = "0x1FA6970", VA = "0x181FA7970")]
			internal int GNBJLDAOBME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA76E0", Offset = "0x1FA66E0", VA = "0x181FA76E0")]
			internal void BIBKJJFHCPP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7A50", Offset = "0x1FA6A50", VA = "0x181FA7A50")]
			internal string JHIMGCOAKHK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA78A0", Offset = "0x1FA68A0", VA = "0x181FA78A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void GEFCJOJKENH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7AF0", Offset = "0x1FA6AF0", VA = "0x181FA7AF0")]
			internal bool NJDLMJNFPFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA77C0", Offset = "0x1FA67C0", VA = "0x181FA77C0")]
			internal void EGEJICJNDOM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7850", Offset = "0x1FA6850", VA = "0x181FA7850")]
			internal bool EKFEIHIDAOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7BB0", Offset = "0x1FA6BB0", VA = "0x181FA7BB0")]
			internal void PHGCDCHIGEL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7AA0", Offset = "0x1FA6AA0", VA = "0x181FA7AA0")]
			internal float NFPAOECPANG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA79C0", Offset = "0x1FA69C0", VA = "0x181FA79C0")]
			internal void IEJPHFBPPGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7680", Offset = "0x1FA6680", VA = "0x181FA7680")]
			internal int BCHLAGBPAOD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FA75E0", Offset = "0x1FA65E0", VA = "0x181FA75E0")]
			internal void AKJFIBKILEF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7B40", Offset = "0x1FA6B40", VA = "0x181FA7B40")]
			internal bool OJFPODJBBEB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F98550", Offset = "0x1F97550", VA = "0x181F98550")]
		public BALHFJJMHPJ(JOOJDMJJLEH KHALMCHEKDD, MLDDHOIHBNK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F97B10", Offset = "0x1F96B10", VA = "0x181F97B10", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KOFGFFDOMFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA9A30", Offset = "0x1FA8A30", VA = "0x181FA9A30")]
			internal Dictionary<string, HGBNDFBPIAF> COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA9BF0", Offset = "0x1FA8BF0", VA = "0x181FA9BF0")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA9AD0", Offset = "0x1FA8AD0", VA = "0x181FA9AD0")]
			internal void GNBJLDAOBME(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA99B0", Offset = "0x1FA89B0", VA = "0x181FA99B0")]
			internal bool BIBKJJFHCPP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CF00", Offset = "0x1F9BF00", VA = "0x181F9CF00")]
		public FPLKKFEJAFA(JOOJDMJJLEH KHALMCHEKDD, NEJEHJCKHKA LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CC60", Offset = "0x1F9BC60", VA = "0x181F9CC60", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FABBE0", Offset = "0x1FAABE0", VA = "0x181FABBE0")]
		public PGJDPILMJIC(JOOJDMJJLEH KHALMCHEKDD, FEAFFPGJBDD LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FABAF0", Offset = "0x1FAAAF0", VA = "0x181FABAF0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB9D0", Offset = "0x1FAA9D0", VA = "0x181FAB9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool CMJPIMKNEDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA0580", Offset = "0x1F9F580", VA = "0x181FA0580", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8E1790", Offset = "0x8E0790", VA = "0x1808E1790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0520", Offset = "0x1F9F520", VA = "0x181FA0520")]
		public IBPNADGLHJI(JOOJDMJJLEH KHALMCHEKDD, IJOLMLDMCDE MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D2AF0", Offset = "0x8D1AF0", VA = "0x1808D2AF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B6A0", Offset = "0x1F9A6A0", VA = "0x181F9B6A0")]
		public ELHGBJKADBO(JOOJDMJJLEH KHALMCHEKDD, CKNFPAFGLGJ MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D5DB0", Offset = "0x8D4DB0", VA = "0x1808D5DB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0260", Offset = "0x1F9F260", VA = "0x181FA0260")]
		public HJGOKPJHNAG(JOOJDMJJLEH KHALMCHEKDD, PBIMOALIPCA MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "112")]
		protected override bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8CF510", Offset = "0x8CE510", VA = "0x1808CF510", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B780", Offset = "0x1F9A780", VA = "0x181F9B780", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B710", Offset = "0x1F9A710", VA = "0x181F9B710")]
		public EPDLEEBDFFK(JOOJDMJJLEH KHALMCHEKDD, PCMCOBBJNFH MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DC330", Offset = "0x8DB330", VA = "0x1808DC330", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D050", Offset = "0x1F9C050", VA = "0x181F9D050", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CFE0", Offset = "0x1F9BFE0", VA = "0x181F9CFE0")]
		public GAAIHJIBKMM(JOOJDMJJLEH KHALMCHEKDD, AJJNJJBOONH MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public CFOFNDPLLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F99420", Offset = "0x1F98420", VA = "0x181F99420")]
			internal float DGFKBIDOBHC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F994A0", Offset = "0x1F984A0", VA = "0x181F994A0")]
			internal void PEMCEBMGGDF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA7A0", Offset = "0x1FA97A0", VA = "0x181FAA7A0")]
		public MAFGCIAIDBK(JOOJDMJJLEH KHALMCHEKDD, EPELEPELPGL LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA520", Offset = "0x1FA9520", VA = "0x181FAA520", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public PNOEAJLHBBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1FABC50", Offset = "0x1FAAC50", VA = "0x181FABC50")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FABCA0", Offset = "0x1FAACA0", VA = "0x181FABCA0")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F92A20", Offset = "0x1F91A20", VA = "0x181F92A20")]
		public ADIJHIDGFFD(JOOJDMJJLEH KHALMCHEKDD, ALLGOEAPGKF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F92770", Offset = "0x1F91770", VA = "0x181F92770", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KBHMLAOIPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8400", Offset = "0x1FA7400", VA = "0x181FA8400")]
			internal object COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8530", Offset = "0x1FA7530", VA = "0x181FA8530")]
			internal bool EGEJICJNDOM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA88F0", Offset = "0x1FA78F0", VA = "0x181FA88F0")]
			internal void PNOMNBKFDEO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8600", Offset = "0x1FA7600", VA = "0x181FA8600")]
			internal string GNBJLDAOBME(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FA83B0", Offset = "0x1FA73B0", VA = "0x181FA83B0")]
			internal IReadOnlyList<object> BIBKJJFHCPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8760", Offset = "0x1FA7760", VA = "0x181FA8760")]
			internal bool JHIMGCOAKHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA85B0", Offset = "0x1FA75B0", VA = "0x181FA85B0")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA87D0", Offset = "0x1FA77D0", VA = "0x181FA87D0")]
			internal void NJDLMJNFPFI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F99000", Offset = "0x1F98000", VA = "0x181F99000")]
		public CDAKCPFLGGK(JOOJDMJJLEH KHALMCHEKDD, NBDPFAKPJMN LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F98800", Offset = "0x1F97800", VA = "0x181F98800", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA8D70", Offset = "0xAA7D70", VA = "0x180AA8D70", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB130", Offset = "0x1FAA130", VA = "0x181FAB130")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public BONDFOGIBPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F986E0", Offset = "0x1F976E0", VA = "0x181F986E0")]
			internal int DGFKBIDOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F98760", Offset = "0x1F97760", VA = "0x181F98760")]
			internal void PEMCEBMGGDF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F93120", Offset = "0x1F92120", VA = "0x181F93120")]
		public AMMGMMKBJLK(JOOJDMJJLEH KHALMCHEKDD, CMKLNOPPKLI LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F92E90", Offset = "0x1F91E90", VA = "0x181F92E90", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public CPLJEOHOCNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F99910", Offset = "0x1F98910", VA = "0x181F99910")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1F99960", Offset = "0x1F98960", VA = "0x181F99960")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA04B0", Offset = "0x1F9F4B0", VA = "0x181FA04B0")]
		public IAONDPKNJKN(JOOJDMJJLEH KHALMCHEKDD, CLGIKLJIANF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FA02D0", Offset = "0x1F9F2D0", VA = "0x181FA02D0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public EBLDBABFOPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A550", Offset = "0x1F99550", VA = "0x181F9A550")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A5A0", Offset = "0x1F995A0", VA = "0x181F9A5A0")]
			internal void PNOMNBKFDEO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1F998A0", Offset = "0x1F988A0", VA = "0x181F998A0")]
		public CMGBLKBJIJM(JOOJDMJJLEH KHALMCHEKDD, CIHCGEGMHGF LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1F996C0", Offset = "0x1F986C0", VA = "0x181F996C0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public GEJJABJNNPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F180", Offset = "0x1F9E180", VA = "0x181F9F180")]
			internal int COFCJKDJKKN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F1D0", Offset = "0x1F9E1D0", VA = "0x181F9F1D0")]
			internal void PNOMNBKFDEO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C940", Offset = "0x1F9B940", VA = "0x181F9C940")]
		public FKNBHPDENBI(JOOJDMJJLEH KHALMCHEKDD, OLBLCDEKNDO LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C6E0", Offset = "0x1F9B6E0", VA = "0x181F9C6E0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB970", Offset = "0x1FAA970", VA = "0x181FAB970")]
		public PCBLINKKEMD(JOOJDMJJLEH KHALMCHEKDD, PBGOOGEJMDE LIGKCFOOPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class GKANKGNJGEH : FLHJOEBGJCE<CDJIOCDEIML>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CF70", Offset = "0x1F9BF70", VA = "0x181F9CF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KFNLMJCIOFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x4213390", Offset = "0x4212390", VA = "0x184213390")]
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
			[Cpp2IlInjected.Address(RVA = "0x44FAAD0", Offset = "0x44F9AD0", VA = "0x1844FAAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x468BCE0", Offset = "0x468ACE0", VA = "0x18468BCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x468BF90", Offset = "0x468AF90", VA = "0x18468BF90", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3559490", Offset = "0x3558490", VA = "0x183559490", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public GJMIIBAJNNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			internal string AJEFLFLHANK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			internal void EOELMDKLAKO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A410", Offset = "0x3D49410", VA = "0x183D4A410")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public LHDIDKIIPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x42D7F90", Offset = "0x42D6F90", VA = "0x1842D7F90")]
			internal bool OGPPHJCFFBP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x42D7F80", Offset = "0x42D6F80", VA = "0x1842D7F80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC73A0", Offset = "0x3EC63A0", VA = "0x183EC73A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7730", Offset = "0x3EC6730", VA = "0x183EC7730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C69F20", Offset = "0x3C68F20", VA = "0x183C69F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected DKIELNKLCBA EJNKFCIJBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B1A0", Offset = "0x3C6A1A0", VA = "0x183C6B1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode CAENIKMKAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
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
			[Cpp2IlInjected.Address(RVA = "0xB13F00", Offset = "0xB12F00", VA = "0x180B13F00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6E400", Offset = "0x3C6D400", VA = "0x183C6E400", Slot = "6")]
			get
			{
				return default(HBKKMIFHCOI<ACKBLKMLNKG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object EJOMCAPLLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3811E00", Offset = "0x3810E00", VA = "0x183811E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool AHBMPDLOFPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int POKBFINKFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E030", Offset = "0x3C6D030", VA = "0x183C6E030", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GEANJACADNF DJDACLDIAFI
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DFD0", Offset = "0x3C6CFD0", VA = "0x183C6DFD0", Slot = "10")]
			get
			{
				return default(GEANJACADNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string POMKDKLHHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E5C0", Offset = "0x3C6D5C0", VA = "0x183C6E5C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public HBKKMIFHCOI<OEOGDBHPCHJ> PCNJLMIMPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9321C0", Offset = "0x9311C0", VA = "0x1809321C0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(HBKKMIFHCOI<OEOGDBHPCHJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xB11450", Offset = "0xB10450", VA = "0x180B11450")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool CEBICBBGCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NMDEKEINGII HGHKCAMHGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4E0", Offset = "0xA794E0", VA = "0x180A7A4E0", Slot = "94")]
			get
			{
				return default(NMDEKEINGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IOCOFHABPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DCE0", Offset = "0x3C6CCE0", VA = "0x183C6DCE0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool FDDIHMHFJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DD50", Offset = "0x3C6CD50", VA = "0x183C6DD50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool AODAIAKKAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DDC0", Offset = "0x3C6CDC0", VA = "0x183C6DDC0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int IACDEADEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E3A0", Offset = "0x3C6D3A0", VA = "0x183C6E3A0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AEEFIPIEGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E1C0", Offset = "0x3C6D1C0", VA = "0x183C6E1C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool NNPNMPPDFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DEF0", Offset = "0x3C6CEF0", VA = "0x183C6DEF0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MAPNPIOBIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DE80", Offset = "0x3C6CE80", VA = "0x183C6DE80", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool ACAFIJCIKII
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xC63300", Offset = "0xC62300", VA = "0x180C63300", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xC63040", Offset = "0xC62040", VA = "0x180C63040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KFFGLPIPNOA
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CIHHBIDNOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DE30", Offset = "0x3C6CE30", VA = "0x183C6DE30", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool FOJADCDDGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E0F0", Offset = "0x3C6D0F0", VA = "0x183C6E0F0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public LPFLGIOMHPC ABAOOCCJCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E2E0", Offset = "0x3C6D2E0", VA = "0x183C6E2E0", Slot = "28")]
			get
			{
				return default(LPFLGIOMHPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public PKPOPCCMEJH JHHONLHGLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E340", Offset = "0x3C6D340", VA = "0x183C6E340", Slot = "30")]
			get
			{
				return default(PKPOPCCMEJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KACNEOHIMLB
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual AAJCICADOFI? NOFFJKCFMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual GFLPNBNPAIM? PJKMBCEHFDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>>? JFBAEOIGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool NKDLCCBOPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x3C6DF60", Offset = "0x3C6CF60", VA = "0x183C6DF60", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E220", Offset = "0x3C6D220", VA = "0x183C6E220", Slot = "62")]
			get
			{
				return default(DAMOFJGJNKL<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public HBKKMIFHCOI<EKJMGNHJFDN> HLPKLNNHMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E090", Offset = "0x3C6D090", VA = "0x183C6E090", Slot = "56")]
			get
			{
				return default(HBKKMIFHCOI<EKJMGNHJFDN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool HCINIAEOGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual HBKKMIFHCOI<EKJMGNHJFDN>? JPIPEBHBNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool CMJPIMKNEDF
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NBAKPCNLLOP
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E150", Offset = "0x3C6D150", VA = "0x183C6E150", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x86BA10", Offset = "0x86AA10", VA = "0x18086BA10", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x86BB10", Offset = "0x86AB10", VA = "0x18086BB10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string LEGKCFALMHM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x86BAC0", Offset = "0x86AAC0", VA = "0x18086BAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E280", Offset = "0x3C6D280", VA = "0x183C6E280", Slot = "63")]
			get
			{
				return default(DAMOFJGJNKL<JMIDFPKEEGG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DAMOFJGJNKL<JMIDFPKEEGG>? NBCANKBLKKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E490", Offset = "0x3C6D490", VA = "0x183C6E490", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ANJPNODIDCK<LMECHAAEJCH, JHMJLMFOOPE> ILPAPNCMHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x3C6E580", Offset = "0x3C6D580", VA = "0x183C6E580", Slot = "65")]
			get
			{
				return default(ANJPNODIDCK<LMECHAAEJCH, JHMJLMFOOPE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual HBKKMIFHCOI<LMECHAAEJCH>? PHGMMHKFCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool BIEGNHBACOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool PJKCCNEJEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CCDDIDLHHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D200", Offset = "0x3C6C200", VA = "0x183C6D200", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3C6C260", Offset = "0x3C6B260", VA = "0x183C6C260", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KGOMHBDJPFD BHPPPIGIAKK
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D490", Offset = "0x3C6C490", VA = "0x183C6D490", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3C6BB60", Offset = "0x3C6AB60", VA = "0x183C6BB60", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LGJGPNLKKME GFKJLEBHEDG
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B7F0", Offset = "0x3C6A7F0", VA = "0x183C6B7F0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3C6C300", Offset = "0x3C6B300", VA = "0x183C6C300", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GJMGNPINCEK
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AAC0", Offset = "0x3C69AC0", VA = "0x183C6AAC0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3C69350", Offset = "0x3C68350", VA = "0x183C69350", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CHIOEGACKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A8A0", Offset = "0x3C698A0", VA = "0x183C6A8A0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3C6BEC0", Offset = "0x3C6AEC0", VA = "0x183C6BEC0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> MKGDMGJBAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x3C6C470", Offset = "0x3C6B470", VA = "0x183C6C470", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x3C6CF40", Offset = "0x3C6BF40", VA = "0x183C6CF40", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> OLLNBMEDJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x3C68AB0", Offset = "0x3C67AB0", VA = "0x183C68AB0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A040", Offset = "0x3C69040", VA = "0x183C6A040", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>> CHHMIOGLAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3C69420", Offset = "0x3C68420", VA = "0x183C69420", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3C6C660", Offset = "0x3C6B660", VA = "0x183C6C660", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, HBKKMIFHCOI<LMECHAAEJCH>> AGNPKBPMOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D2A0", Offset = "0x3C6C2A0", VA = "0x183C6D2A0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B730", Offset = "0x3C6A730", VA = "0x183C6B730", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, JHMJLMFOOPE> GFHFFBDLBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A940", Offset = "0x3C69940", VA = "0x183C6A940", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3C69F80", Offset = "0x3C68F80", VA = "0x183C69F80", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<HBKKMIFHCOI<LMECHAAEJCH>, HBKKMIFHCOI<LMECHAAEJCH>> BMDAHOHBJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B890", Offset = "0x3C6A890", VA = "0x183C6B890", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA00", Offset = "0x3C69A00", VA = "0x183C6AA00", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D6D0", Offset = "0x3C6C6D0", VA = "0x183C6D6D0")]
		[NONNNOEJCPN("Need to handle `Name` better.")]
		[NONNNOEJCPN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected FLHJOEBGJCE(JOOJDMJJLEH KHALMCHEKDD, TNode MPJOKOKILNG, bool JMNMBLFPBOD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3C68B70", Offset = "0x3C67B70", VA = "0x183C68B70", Slot = "87")]
		protected virtual void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x3C69640", Offset = "0x3C68640", VA = "0x183C69640", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3C689E0", Offset = "0x3C679E0", VA = "0x183C689E0", Slot = "9")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.MLFKKHAJBCD))]
		public void AINAAPPNLAF(int KJFBCKFCKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B950", Offset = "0x3C6A950", VA = "0x183C6B950")]
		public bool INCGLEKKCJO([In] LPFLGIOMHPC CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3C692E0", Offset = "0x3C682E0", VA = "0x183C692E0")]
		public bool CDDPLBACIAG([In] PKPOPCCMEJH CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C820", Offset = "0x3C6B820", VA = "0x183C6C820", Slot = "32")]
		public void NDBAOJBIBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D580", Offset = "0x3C6C580", VA = "0x183C6D580", Slot = "33")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.OEPBIJAIMGA))]
		public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> PMMFCKLNPLI(LPFLGIOMHPC? DCBNBHMBGKP, PKPOPCCMEJH? JAFBJNOBENG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "97")]
		public virtual void AACONAFIOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "98")]
		public virtual void LGFMHLMHBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "99")]
		public virtual void LECBEDAALCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1D355F0", Offset = "0x1D345F0", VA = "0x181D355F0")]
		protected void BJEGDEIDJBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A290", Offset = "0x3C69290", VA = "0x183C6A290")]
		protected void EMGBBNJOOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x218C960", Offset = "0x218B960", VA = "0x18218C960")]
		private void JCLFLCBMFEI([In] PKPOPCCMEJH ADNGPFKNGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C3A0", Offset = "0x3C6B3A0", VA = "0x183C6C3A0", Slot = "100")]
		public virtual Task<PIJKHLBEMKP<HBKKMIFHCOI<LMECHAAEJCH>, NJADGKCOIIE>> LIKIEEOJBMO(string LCLKDNPLMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AB90", Offset = "0x3C69B90", VA = "0x183C6AB90", Slot = "101")]
		public virtual Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GPOOPJANOMH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "102")]
		public virtual void PDNKLEKFEGM(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B6A0", Offset = "0x3C6A6A0", VA = "0x183C6B6A0", Slot = "103")]
		public virtual IEnumerable<LHAEFPHAKAB> HMCEGJOBJAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CEB0", Offset = "0x3C6BEB0", VA = "0x183C6CEB0", Slot = "104")]
		public PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE> NKDMCEHBLOH(string MFOBCFPKPKP)
		{
			return default(PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3C694E0", Offset = "0x3C684E0", VA = "0x183C694E0", Slot = "47")]
		public bool DGJBENPCBHM([Out] Guid JDNABOPHHBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BC00", Offset = "0x3C6AC00", VA = "0x183C6BC00")]
		public bool KBFLFDOLLAP([In] Guid KJEGAEAMNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "105")]
		public virtual void FDHFDDAAOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "106")]
		public virtual void HFENOCLBOPM(bool PKFFHGLMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "107")]
		public virtual APFHLPOFLMK BDCCOPBMKJL([In] LHGEAJIDJBF DBDAMLBKEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A660", Offset = "0x3C69660", VA = "0x183C6A660")]
		protected void FCFFKFNCFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BB20", Offset = "0x3C6AB20", VA = "0x183C6BB20", Slot = "112")]
		protected virtual bool JIIACDFDJDM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "113")]
		protected virtual bool HPIHPMEFIMM(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
		protected virtual void HBCAHGJBAAI(FCJJHIHCGFA JIJOFMDFCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CAA0", Offset = "0x3C6BAA0", VA = "0x183C6CAA0")]
		protected void NJDGGBPAEHP(FCJJHIHCGFA AABAOMBBJAL, Func<string> AJEMMDJDICO, Action<string> KAJDEFJNFGP, string KIJDCDFNLDM, string PCECBJNMEJC, string NGAPPCIMKFK, OKMACKCCIOE NNGIMKJCHNJ, KHOFHMDHGEA BCBBPGNLPIM, Func<string, bool> PGHEIKLABPM, string CPEDPHLDPGC, Func<string, bool> DMGLHFHDNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BF60", Offset = "0x3C6AF60", VA = "0x183C6BF60")]
		protected void LAFCOAIJEPO(FCJJHIHCGFA AABAOMBBJAL, Func<string> AJEMMDJDICO, Action<string> KAJDEFJNFGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D000", Offset = "0x3C6C000", VA = "0x183C6D000", Slot = "121")]
		protected virtual void OBELONDCEKE(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D530", Offset = "0x3C6C530", VA = "0x183C6D530", Slot = "80")]
		public void PKPMOKLBCIG(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C720", Offset = "0x3C6B720", VA = "0x183C6C720", Slot = "81")]
		public DEFEBGKBMOG MFPAFOKONNM()
		{
			return default(DEFEBGKBMOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "124")]
		public virtual bool ENHDCPOBIPG(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x13F7EF0", Offset = "0x13F6EF0", VA = "0x1813F7EF0")]
		private void CPANAHEDOJC([In] LPFLGIOMHPC MOIICCIPACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B9C0", Offset = "0x3C6A9C0", VA = "0x183C6B9C0")]
		private void JGGKGGKGPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AC60", Offset = "0x3C69C60", VA = "0x183C6AC60")]
		private void HDLJLPPKKDC(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH BNCODIOLIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EC50", Offset = "0x1E6DC50", VA = "0x181E6EC50")]
		private void CMACKKGKJDF(HBKKMIFHCOI<LMECHAAEJCH> BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D360", Offset = "0x3C6C360", VA = "0x183C6D360")]
		private void OLAIDNIKPBL(HBKKMIFHCOI<LMECHAAEJCH> BLCJLIJFBDL, JLKIADPGAEH KPGBFLPHOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A2B0", Offset = "0x3C692B0", VA = "0x183C6A2B0")]
		private void FAGAMOIGGLE(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EBD0", Offset = "0x1E6DBD0", VA = "0x181E6EBD0")]
		private void DDHLLNAICPE(HBKKMIFHCOI<LMECHAAEJCH> FNHCPDOOFKL, HBKKMIFHCOI<LMECHAAEJCH> NAPMHMONEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x3C68A90", Offset = "0x3C67A90", VA = "0x183C68A90")]
		private void ALOKMMNPPDL(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B290", Offset = "0x3C6A290", VA = "0x183C6B290")]
		private void HKIEOHFNNDH(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH BNCODIOLIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A220", Offset = "0x3C69220", VA = "0x183C6A220")]
		private void EHFMAJPDJEF(HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, JLKIADPGAEH KPGBFLPHOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A100", Offset = "0x3C69100", VA = "0x183C6A100", Slot = "125")]
		[AsyncStateMachine(typeof(FLHJOEBGJCE<>.IFAKDFCEJNK))]
		public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> EHBMLGHJPOC(string MFOBCFPKPKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3C693B0", Offset = "0x3C683B0", VA = "0x183C693B0", Slot = "54")]
		private void CIDPPOEODDE(object AMHCGCDJMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CA30", Offset = "0x3C6BA30", VA = "0x183C6CA30", Slot = "55")]
		private void NEPOLNDLDHP(object AMHCGCDJMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C570", Offset = "0x3C6B570", VA = "0x183C6C570", Slot = "29")]
		private bool MCJDLHDLJFA([In] LPFLGIOMHPC CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A860", Offset = "0x3C69860", VA = "0x183C6A860", Slot = "31")]
		private bool FFNAAJLPHIM([In] PKPOPCCMEJH CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C530", Offset = "0x3C6B530", VA = "0x183C6C530", Slot = "48")]
		private bool LLMKCMJMEDL([In] Guid KJEGAEAMNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D1C0", Offset = "0x3C6C1C0", VA = "0x183C6D1C0")]
		[CompilerGenerated]
		private string OFMBAMGABMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C5B0", Offset = "0x3C6B5B0", VA = "0x183C6C5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCC89E0", Offset = "0xCC79E0", VA = "0x180CC89E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA800", Offset = "0x1FA9800", VA = "0x181FAA800")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F730", Offset = "0x1F9E730", VA = "0x181F9F730")]
		public GKMNCBOABFN(JOOJDMJJLEH KHALMCHEKDD, KGCAOGAEKDB MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public LMJNMGGFFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			internal IReadOnlyList<KeyValuePair<string, HGBNDFBPIAF>> COFCJKDJKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x42F82B0", Offset = "0x42F72B0", VA = "0x1842F82B0")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x42F7D10", Offset = "0x42F6D10", VA = "0x1842F7D10")]
			internal void GNBJLDAOBME(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x42F7BD0", Offset = "0x42F6BD0", VA = "0x1842F7BD0")]
			internal void BIBKJJFHCPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x42F7FF0", Offset = "0x42F6FF0", VA = "0x1842F7FF0")]
			internal void JHIMGCOAKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x42F7C20", Offset = "0x42F6C20", VA = "0x1842F7C20")]
			internal bool GEFCJOJKENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x42F81A0", Offset = "0x42F71A0", VA = "0x1842F81A0")]
			internal void NJDLMJNFPFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x42F7C20", Offset = "0x42F6C20", VA = "0x1842F7C20")]
			internal bool EGEJICJNDOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x42F7CB0", Offset = "0x42F6CB0", VA = "0x1842F7CB0")]
			internal float EKFEIHIDAOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x42F81F0", Offset = "0x42F71F0", VA = "0x1842F81F0")]
			internal void PHGCDCHIGEL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x42F8140", Offset = "0x42F7140", VA = "0x1842F8140")]
			internal float NFPAOECPANG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x42F7F30", Offset = "0x42F6F30", VA = "0x1842F7F30")]
			internal void IEJPHFBPPGM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x42F7B70", Offset = "0x42F6B70", VA = "0x1842F7B70")]
			internal float BCHLAGBPAOD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x42F7AB0", Offset = "0x42F6AB0", VA = "0x1842F7AB0")]
			internal void AKJFIBKILEF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CEAA0", VA = "0x1808CFAA0", Slot = "91")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DF830", Offset = "0x37DE830", VA = "0x1837DF830")]
		public EAHKPFBPIMN(JOOJDMJJLEH KHALMCHEKDD, T MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x37DED10", Offset = "0x37DDD10", VA = "0x1837DED10", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x92E960", Offset = "0x92D960", VA = "0x18092E960", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA4B0", Offset = "0x1FA94B0", VA = "0x181FAA4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public AKLNEOCNFAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F92E40", Offset = "0x1F91E40", VA = "0x181F92E40")]
			internal int PNOMNBKFDEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F92DB0", Offset = "0x1F91DB0", VA = "0x181F92DB0")]
			internal void GNBJLDAOBME(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private static Dictionary<string, HGBNDFBPIAF>? BJCEBOMGKNP;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8EC0", Offset = "0x1FA7EC0", VA = "0x181FA8EC0")]
		public KGHFJBEDPFC(JOOJDMJJLEH KHALMCHEKDD, ADCLPOJIGAO MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8B40", Offset = "0x1FA7B40", VA = "0x181FA8B40", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9FF0", Offset = "0x1FA8FF0", VA = "0x181FA9FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA950", Offset = "0x1FA9950", VA = "0x181FAA950")]
		public NLKHPINCEFP(JOOJDMJJLEH KHALMCHEKDD, FLGODBGGBBK MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F99E40", Offset = "0x1F98E40", VA = "0x181F99E40")]
		public DHPJGJKMHKK(JOOJDMJJLEH KHALMCHEKDD, GAJCDOINBKE MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x1FABDC0", Offset = "0x1FAADC0", VA = "0x181FABDC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public GKOPAOBFHNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F790", Offset = "0x1F9E790", VA = "0x181F9F790")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void DGFKBIDOBHC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7110", Offset = "0x1FA6110", VA = "0x181FA7110")]
		public INDGCPKMHAL(JOOJDMJJLEH KHALMCHEKDD, KPJGAKGGBMD LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6E30", Offset = "0x1FA5E30", VA = "0x181FA6E30", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8CF510", Offset = "0x8CE510", VA = "0x1808CF510", Slot = "126")]
			get
			{
				return default(OMLMKPNJFBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB870", Offset = "0x1FAA870", VA = "0x181FAB870")]
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
			[Cpp2IlInjected.Address(RVA = "0x92DBD0", Offset = "0x92CBD0", VA = "0x18092DBD0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C670", Offset = "0x1F9B670", VA = "0x181F9C670")]
		public FJBPIKJGBMJ(JOOJDMJJLEH KHALMCHEKDD, FJDGEOCJLBD MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool ICHLLMEACPK
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool CCLABENACFM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA440", Offset = "0x1FA9440", VA = "0x181FAA440")]
		public LNKEDOBMCEF(JOOJDMJJLEH KHALMCHEKDD, FHPHOHAMCFA MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA070", Offset = "0x1FA9070", VA = "0x181FAA070", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA400", Offset = "0x1FA9400", VA = "0x181FAA400")]
		private int PFONAACEKPC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA3A0", Offset = "0x1FA93A0", VA = "0x181FAA3A0")]
		private void KEFBDADCCLP(int HEJFAMNFDIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class FPMOHGJKDAJ : GKANKGNJGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CF70", Offset = "0x1F9BF70", VA = "0x181F9CF70")]
		public FPMOHGJKDAJ(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class GLELEDEHPNN : DMEMDLIDPNO<OFEBFEPLBJH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F860", Offset = "0x1F9E860", VA = "0x181F9F860")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public OHDHNLAJPCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x46A0600", Offset = "0x469F600", VA = "0x1846A0600")]
			internal bool COFCJKDJKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x46A0770", Offset = "0x469F770", VA = "0x1846A0770")]
			internal void PNOMNBKFDEO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x46A0660", Offset = "0x469F660", VA = "0x1846A0660")]
			internal bool GNBJLDAOBME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x46A0540", Offset = "0x469F540", VA = "0x1846A0540")]
			internal void BIBKJJFHCPP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x46A06C0", Offset = "0x469F6C0", VA = "0x1846A06C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KJOLLIHHKFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4222D90", Offset = "0x4221D90", VA = "0x184222D90")]
			internal void DGFKBIDOBHC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA9C1B0", Offset = "0xA9B1B0", VA = "0x180A9C1B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NMDEKEINGII HGHKCAMHGED
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x5860CB0", Offset = "0x585FCB0", VA = "0x185860CB0", Slot = "94")]
			get
			{
				return default(NMDEKEINGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5860B00", Offset = "0x585FB00", VA = "0x185860B00")]
		protected DMEMDLIDPNO(JOOJDMJJLEH KHALMCHEKDD, TVariableNode MPJOKOKILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5860010", Offset = "0x585F010", VA = "0x185860010", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x58602B0", Offset = "0x585F2B0", VA = "0x1858602B0", Slot = "120")]
		protected override void HBCAHGJBAAI(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5860760", Offset = "0x585F760", VA = "0x185860760", Slot = "126")]
		protected virtual void JINHNBHMPAL(FCJJHIHCGFA AABAOMBBJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x58601B0", Offset = "0x585F1B0", VA = "0x1858601B0", Slot = "105")]
		public override void FDHFDDAAOOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E320", Offset = "0x1F8D320", VA = "0x181F8E320")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6ED50", Offset = "0xA6DD50", VA = "0x180A6ED50", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0xF967A0", Offset = "0xF957A0", VA = "0x180F967A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<OPHNHCNNIBK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7D10", Offset = "0x1FA6D10", VA = "0x181FA7D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private HBKKMIFHCOI<KEBIIKCPPLB> HIPHIMBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xBC9BF0", Offset = "0xBC8BF0", VA = "0x180BC9BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override HBKKMIFHCOI<PMHAGHKACGK> LPFLDCIEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8070", Offset = "0x1FA7070", VA = "0x181FA8070", Slot = "20")]
		get
		{
			return default(HBKKMIFHCOI<PMHAGHKACGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA80C0", Offset = "0x1FA70C0", VA = "0x181FA80C0")]
	private JIKAELGFCPG(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, JCEFPMOKKCP GOADIDBMIJH, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA, HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7D20", Offset = "0x1FA6D20", VA = "0x181FA7D20")]
	public static JIKAELGFCPG HCLFOFEHDJP(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, JCEFPMOKKCP INKGDJHAJPE, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA, bool FHGEKDMEAEP, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7D10", Offset = "0x1FA6D10", VA = "0x181FA7D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA75D0", Offset = "0x1FA65D0", VA = "0x181FA75D0")]
		public void OAIAOCAHOEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7530", Offset = "0x1FA6530", VA = "0x181FA7530")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F92150", Offset = "0x1F91150", VA = "0x181F92150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind KJEBMFBHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8753F0", Offset = "0x8743F0", VA = "0x1808753F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F92300", Offset = "0x1F91300", VA = "0x181F92300", Slot = "6")]
		get
		{
			return default(HBKKMIFHCOI<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F925E0", Offset = "0x1F915E0", VA = "0x181F925E0", Slot = "7")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CNABLCLBOEK FNIGGFHADFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1BD67C0", Offset = "0x1BD57C0", VA = "0x181BD67C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public KBJGBHFDLPP FFCAOKDECBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F92330", Offset = "0x1F91330", VA = "0x181F92330", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OMHBDILNPHD JKCGFBANPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F92330", Offset = "0x1F91330", VA = "0x181F92330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage FOCMCGLBJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F917E0", Offset = "0x1F907E0", VA = "0x181F917E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A0", Offset = "0x86A9A0", VA = "0x18086B9A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x86BA50", Offset = "0x86AA50", VA = "0x18086BA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F91910", Offset = "0x1F90910", VA = "0x181F91910", Slot = "9")]
		get
		{
			return default(DAMOFJGJNKL<JMIDFPKEEGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HBKKMIFHCOI<LMECHAAEJCH> FABGDHBLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B30", Offset = "0x9B5B30", VA = "0x1809B6B30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(HBKKMIFHCOI<LMECHAAEJCH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xEA7A10", Offset = "0xEA6A10", VA = "0x180EA7A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F92610", Offset = "0x1F91610", VA = "0x181F92610")]
	protected ADEIFDEHNLJ(JOOJDMJJLEH KHALMCHEKDD, CDJIOCDEIML MPJOKOKILNG, AKNPPOILJMM JCEBAOIBEAD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool FHGEKDMEAEP, string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1F91270", Offset = "0x1F90270", VA = "0x181F91270", Slot = "21")]
	protected virtual void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1F91690", Offset = "0x1F90690", VA = "0x181F91690", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1F915D0", Offset = "0x1F905D0", VA = "0x181F915D0", Slot = "14")]
	public void DBGNIKNGGLE(JFDPKJAFIFC FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1F922A0", Offset = "0x1F912A0", VA = "0x181F922A0", Slot = "15")]
	public void KMLAOBCIICF(MHKFOLFKNDO FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1F91930", Offset = "0x1F90930", VA = "0x181F91930", Slot = "16")]
	public void GEAKHPFHIDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1F91630", Offset = "0x1F90630", VA = "0x181F91630", Slot = "23")]
	protected virtual void DKAHAGGDDDG(LJJOALMHCEA GBELMBCHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1F91FC0", Offset = "0x1F90FC0", VA = "0x181F91FC0")]
	private void JKEOHDLBLKI(bool JLMICGLMAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1F91420", Offset = "0x1F90420", VA = "0x181F91420")]
	private void CPMAOLMDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1F923D0", Offset = "0x1F913D0", VA = "0x181F923D0")]
	private void NAEPPMJCHGE([In] BOFICHBLKBH KCACFKLJPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1F913C0", Offset = "0x1F903C0", VA = "0x181F913C0", Slot = "17")]
	public void CIKHPFOGLOI(JFDPKJAFIFC FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1F92580", Offset = "0x1F91580", VA = "0x181F92580", Slot = "18")]
	public void NCJHMNFHNLF(MHKFOLFKNDO FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x86BA50", Offset = "0x86AA50", VA = "0x18086BA50")]
	internal void OFJBNIKIPAA(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1F91250", Offset = "0x1F90250", VA = "0x181F91250")]
	internal void ABJFAPNIBFB(FNPCAPDLGHJ OJGLDAGFLKC, CNABLCLBOEK PBLNJHEPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xEA7A10", Offset = "0xEA6A10", VA = "0x180EA7A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BLNBKBOPAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1F985C0", Offset = "0x1F975C0", VA = "0x181F985C0")]
		internal BEILIFKJEAK MNDNNDJEEMH((int PortDescIndex, int PortIndex, CDGMKFJFGMP InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1F98650", Offset = "0x1F97650", VA = "0x181F98650")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9F260", Offset = "0x1F9E260", VA = "0x181F9F260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F6C0", Offset = "0x1F9E6C0", VA = "0x181F9F6C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F93180", Offset = "0x1F92180", VA = "0x181F93180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1F934D0", Offset = "0x1F924D0", VA = "0x181F934D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA7170", Offset = "0x1FA6170", VA = "0x181FA7170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FA74C0", Offset = "0x1FA64C0", VA = "0x181FA74C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9B2E0", Offset = "0x1F9A2E0", VA = "0x181F9B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B630", Offset = "0x1F9A630", VA = "0x181F9B630", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAA9B0", Offset = "0x1FA99B0", VA = "0x181FAA9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAD00", Offset = "0x1FA9D00", VA = "0x181FAAD00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA05C0", Offset = "0x1F9F5C0", VA = "0x181FA05C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0A30", Offset = "0x1F9FA30", VA = "0x181FA0A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAB190", Offset = "0x1FAA190", VA = "0x181FAB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB4E0", Offset = "0x1FAA4E0", VA = "0x181FAB4E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAAD70", Offset = "0x1FA9D70", VA = "0x181FAAD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB0C0", Offset = "0x1FAA0C0", VA = "0x181FAB0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9EDC0", Offset = "0x1F9DDC0", VA = "0x181F9EDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F110", Offset = "0x1F9E110", VA = "0x181F9F110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9B7D0", Offset = "0x1F9A7D0", VA = "0x181F9B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BB60", Offset = "0x1F9AB60", VA = "0x181F9BB60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9FE60", Offset = "0x1F9EE60", VA = "0x181F9FE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FA01F0", Offset = "0x1F9F1F0", VA = "0x181FA01F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA42D0", Offset = "0x1FA32D0", VA = "0x181FA42D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool HMAEBJJCNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D40", Offset = "0x1FA4D40", VA = "0x181FA5D40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool NCIPFABILKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3D80", Offset = "0x1FA2D80", VA = "0x181FA3D80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DAMOFJGJNKL<EKJMGNHJFDN> FBGPEENHPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6240", Offset = "0x1FA5240", VA = "0x181FA6240", Slot = "7")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PDEIBLGIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5CC0", Offset = "0x1FA4CC0", VA = "0x181FA5CC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB> CKBKHKMIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820", Slot = "9")]
		get
		{
			return default(ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3160", Offset = "0x1FA2160", VA = "0x181FA3160", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DAMOFJGJNKL<JMIDFPKEEGG> NMMNLKIFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3140", Offset = "0x1FA2140", VA = "0x181FA3140", Slot = "11")]
		get
		{
			return default(DAMOFJGJNKL<JMIDFPKEEGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA> EKFBFMJHDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A0", Offset = "0x86A9A0", VA = "0x18086B9A0", Slot = "12")]
		get
		{
			return default(ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HBKKMIFHCOI<LMECHAAEJCH> FABGDHBLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xBCAE80", Offset = "0xBC9E80", VA = "0x180BCAE80", Slot = "13")]
		get
		{
			return default(HBKKMIFHCOI<LMECHAAEJCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GGBEAFDIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA68E0", Offset = "0x1FA58E0", VA = "0x181FA68E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D80", Offset = "0x1FA4D80", VA = "0x181FA5D80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action ABIKAAHOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1E10", Offset = "0x1FA0E10", VA = "0x181FA1E10", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4F70", Offset = "0x1FA3F70", VA = "0x181FA4F70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, HBKKMIFHCOI<CHIHANCPCBA>> HLPBPLPBBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FA32E0", Offset = "0x1FA22E0", VA = "0x181FA32E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1490", Offset = "0x1FA0490", VA = "0x181FA1490", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, HBKKMIFHCOI<CHIHANCPCBA>> GPLLNIEEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4DF0", Offset = "0x1FA3DF0", VA = "0x181FA4DF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FA13D0", Offset = "0x1FA03D0", VA = "0x181FA13D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, HBKKMIFHCOI<OPHNHCNNIBK>> FEIKAPFKBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6270", Offset = "0x1FA5270", VA = "0x181FA6270", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5FA0", Offset = "0x1FA4FA0", VA = "0x181FA5FA0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, HBKKMIFHCOI<OPHNHCNNIBK>> JLIGCCGAJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1BD0", Offset = "0x1FA0BD0", VA = "0x181FA1BD0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1570", Offset = "0x1FA0570", VA = "0x181FA1570", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, BGGKHBIFAEB> PBJGDFLKINE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA43B0", Offset = "0x1FA33B0", VA = "0x181FA43B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4870", Offset = "0x1FA3870", VA = "0x181FA4870", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>> IIEJCFKBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5790", Offset = "0x1FA4790", VA = "0x181FA5790", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4470", Offset = "0x1FA3470", VA = "0x181FA4470", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HBKKMIFHCOI<CHIHANCPCBA>, BGGKHBIFAEB> EMLKPFLMMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4EB0", Offset = "0x1FA3EB0", VA = "0x181FA4EB0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5E20", Offset = "0x1FA4E20", VA = "0x181FA5E20", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, OFKBCMKGDMA> JBHOJNIAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6820", Offset = "0x1FA5820", VA = "0x181FA6820", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1D50", Offset = "0x1FA0D50", VA = "0x181FA1D50", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>> AGOLLGECOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1C90", Offset = "0x1FA0C90", VA = "0x181FA1C90", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FA47B0", Offset = "0x1FA37B0", VA = "0x181FA47B0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<HBKKMIFHCOI<OPHNHCNNIBK>, OFKBCMKGDMA> BOEGBMAFFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5EE0", Offset = "0x1FA4EE0", VA = "0x181FA5EE0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4210", Offset = "0x1FA3210", VA = "0x181FA4210", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6980", Offset = "0x1FA5980", VA = "0x181FA6980")]
	private IJENMLPPGDM(bool FHGEKDMEAEP, JOOJDMJJLEH KHALMCHEKDD, bool GCCOGJBMEGM, ANJPNODIDCK<CHIHANCPCBA, BEILIFKJEAK> NOPADGLPHDE, ANJPNODIDCK<CHIHANCPCBA, BGGKHBIFAEB> JGDIMHBLHBD, CDJIOCDEIML MPJOKOKILNG, ANJPNODIDCK<OPHNHCNNIBK, JIKAELGFCPG> EEPCHAOPKJF, ANJPNODIDCK<OPHNHCNNIBK, OFKBCMKGDMA> FIDIFFEJHBE, string? BCJONJAFFLF, JLKIADPGAEH BNCODIOLIGF, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool JMNMBLFPBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3810", Offset = "0x1FA2810", VA = "0x181FA3810")]
	public static IJENMLPPGDM HCLFOFEHDJP(bool FHGEKDMEAEP, JOOJDMJJLEH KHALMCHEKDD, bool GCCOGJBMEGM, CDJIOCDEIML MPJOKOKILNG, JLKIADPGAEH BNCODIOLIGF, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, bool JMNMBLFPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0C20", Offset = "0x1F9FC20", VA = "0x181FA0C20")]
	private void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1FD0", Offset = "0x1FA0FD0", VA = "0x181FA1FD0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA46C0", Offset = "0x1FA36C0", VA = "0x181FA46C0", Slot = "38")]
	[AsyncStateMachine(typeof(GEOIPFKJHCK))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> KGNEMHAPCKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5020", Offset = "0x1FA4020", VA = "0x181FA5020")]
	private (CBPNOBAKELJ, int)? LODCEKPFNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA34C0", Offset = "0x1FA24C0", VA = "0x181FA34C0")]
	private void GDLIMJPKMLC(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1412E10", Offset = "0x1411E10", VA = "0x181412E10")]
	private void GNKPCJADMBD(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6480", Offset = "0x1FA5480", VA = "0x181FA6480")]
	private void PNGJBNEKIOD(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0AA0", Offset = "0x1F9FAA0", VA = "0x181FA0AA0")]
	private void BDLAHKOCELD(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5250", Offset = "0x1FA4250", VA = "0x181FA5250")]
	private void MAELIGHABCF(int FMIHCHGCFLM, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA, CDGMKFJFGMP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FA46A0", Offset = "0x1FA36A0", VA = "0x181FA46A0")]
	private void KEDPEHGKMAL(int JLMICGLMAKN, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4390", Offset = "0x1FA3390", VA = "0x181FA4390")]
	private void IPMPEEKFLJL(int JLMICGLMAKN, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5870", Offset = "0x1FA4870", VA = "0x181FA5870")]
	private void MMCNKBHAJLO(int FMIHCHGCFLM, HBKKMIFHCOI<CHIHANCPCBA> FBPEBPBNJBA, CDGMKFJFGMP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6330", Offset = "0x1FA5330", VA = "0x181FA6330")]
	private void PDNJEPDCNCI(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xAD88F0", Offset = "0xAD78F0", VA = "0x180AD88F0")]
	private void HJNKIIJGNHH(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6150", Offset = "0x1FA5150", VA = "0x181FA6150")]
	private void NPFCAJGBPOL(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1412E10", Offset = "0x1411E10", VA = "0x181412E10")]
	private void MIFOACGNEDE(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4A50", Offset = "0x1FA3A50", VA = "0x181FA4A50")]
	private void LDNNLDCFPJI(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4640", Offset = "0x1FA3640", VA = "0x181FA4640")]
	private void JKJIHFBIFNG(int LIIJKFBLNOO, int KPJGAIMDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2AD0", Offset = "0x1FA1AD0", VA = "0x181FA2AD0")]
	private void EELFJCACOAH(int FMIHCHGCFLM, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA, JCEFPMOKKCP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5850", Offset = "0x1FA4850", VA = "0x181FA5850")]
	private void MFMNEMANNDP(int JLMICGLMAKN, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1550", Offset = "0x1FA0550", VA = "0x181FA1550")]
	private void CENDKJBHDDO(int JLMICGLMAKN, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1630", Offset = "0x1FA0630", VA = "0x181FA1630")]
	private void CKIIBKNKKNL(int FMIHCHGCFLM, HBKKMIFHCOI<OPHNHCNNIBK> FBPEBPBNJBA, JCEFPMOKKCP EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3190", Offset = "0x1FA2190", VA = "0x181FA3190")]
	private void FIGLDBEHPAE(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xAD88F0", Offset = "0xAD78F0", VA = "0x180AD88F0")]
	private void KFGLPNGJBJA(int FMIHCHGCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4530", Offset = "0x1FA3530", VA = "0x181FA4530", Slot = "39")]
	[AsyncStateMachine(typeof(APEHLEGPCOB))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> JGFONHLJFKH(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1EC0", Offset = "0x1FA0EC0", VA = "0x181FA1EC0", Slot = "40")]
	[AsyncStateMachine(typeof(JAGDJEPHADK))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> DMJNLKOPEDF(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FA33A0", Offset = "0x1FA23A0", VA = "0x181FA33A0", Slot = "41")]
	[AsyncStateMachine(typeof(EKMKHBELJKJ))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> FOCBCCDFLHC(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, HBKKMIFHCOI<KIADPJBFMAK> GOFJPGHIIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4930", Offset = "0x1FA3930", VA = "0x181FA4930", Slot = "42")]
	[AsyncStateMachine(typeof(OFIDLAEOHKH))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> LBONKFAAJKL(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, HBKKMIFHCOI<KEBIIKCPPLB> GOFJPGHIIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6060", Offset = "0x1FA5060", VA = "0x181FA6060", Slot = "43")]
	[AsyncStateMachine(typeof(ICGHNOBLHJC))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> NOPFNFGELED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0B00", Offset = "0x1F9FB00", VA = "0x181FA0B00", Slot = "44")]
	[AsyncStateMachine(typeof(OLFNLCOGIBM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> BGFINDGOPFD(string MFOBCFPKPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FA35B0", Offset = "0x1FA25B0", VA = "0x181FA35B0", Slot = "45")]
	[AsyncStateMachine(typeof(OHFDAIOIBAI))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> GOJEJIMPLHF(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FA36E0", Offset = "0x1FA26E0", VA = "0x181FA36E0", Slot = "46")]
	[AsyncStateMachine(typeof(GDNKGMOJHDL))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HCAFJDCPIOC(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3010", Offset = "0x1FA2010", VA = "0x181FA3010", Slot = "47")]
	[AsyncStateMachine(typeof(FAFPALOJMDM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> FBEGHNEIHGL(HBKKMIFHCOI<KIADPJBFMAK> FPLFDHDHGCF, OMFLEFMMLLM PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1AA0", Offset = "0x1FA0AA0", VA = "0x181FA1AA0", Slot = "48")]
	[AsyncStateMachine(typeof(HGHAHDHBILE))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> COGMJDMFHJO(HBKKMIFHCOI<KEBIIKCPPLB> KIJJEPEBONA, OMFLEFMMLLM PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3E40", Offset = "0x1FA2E40", VA = "0x181FA3E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9BBD0", Offset = "0x1F9ABD0", VA = "0x181F9BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C600", Offset = "0x1F9B600", VA = "0x181F9C600", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	private CJJOLICGHKG(MDDIMDPOMKC KBFJOOIMLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F99560", Offset = "0x1F98560", VA = "0x181F99560")]
	[AsyncStateMachine(typeof(FFNHECAIBFL))]
	public static Task<CJJOLICGHKG> LGHHEPEAJLF(JOOJDMJJLEH KHALMCHEKDD, OCCKDCOPHOC? ENLCDNNHBBD, HMALNBKCNFI? KEAPPNMDHKA, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1F99540", Offset = "0x1F98540", VA = "0x181F99540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F92A90", Offset = "0x1F91A90", VA = "0x181F92A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1F92D20", Offset = "0x1F91D20", VA = "0x181F92D20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F999F0", Offset = "0x1F989F0", VA = "0x181F999F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1F99DD0", Offset = "0x1F98DD0", VA = "0x181F99DD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9C9B0", Offset = "0x1F9B9B0", VA = "0x181F9C9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9CBF0", Offset = "0x1F9BBF0", VA = "0x181F9CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly PKBGPKAOHBH IPICGINFACB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	public GOGFHKFMKHD(PKBGPKAOHBH DFJCFKMIMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F9B0", Offset = "0x1F9E9B0", VA = "0x181F9F9B0")]
	[AsyncStateMachine(typeof(AICFGCNCDLB))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EKKCLFIOMLH(LHAEFPHAKAB OGLJLDNLGIJ, bool EPJOLNMCGPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FAE0", Offset = "0x1F9EAE0", VA = "0x181F9FAE0")]
	[AsyncStateMachine(typeof(DEEDPNMLCFI))]
	public Task<PIJKHLBEMKP<bool, NJADGKCOIIE?>>? MJEMCAEJKCI(int KICHIPMPPLC, AGKNAGALEPM? KCIKNADAAIN, OCCKDCOPHOC? BFJKCBLPPNB, HMALNBKCNFI? KEAPPNMDHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F8C0", Offset = "0x1F9E8C0", VA = "0x181F9F8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	private HBIAHFKNLDH(JKPODBPPDEH BKOAJFMCFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FC60", Offset = "0x1F9EC60", VA = "0x181F9FC60")]
	public static HBIAHFKNLDH JGNOLJBBCJA(JOOJDMJJLEH KHALMCHEKDD, AGKNAGALEPM AKOIPGFDEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FC40", Offset = "0x1F9EC40", VA = "0x181F9FC40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F9A0A0", Offset = "0x1F990A0", VA = "0x181F9A0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F92D90", Offset = "0x1F91D90", VA = "0x181F92D90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	internal AKFANCKKAOE(JOOJDMJJLEH KHALMCHEKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class PBOABKNJFJD : DAJBIJHHEBH
{
	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB8D0", Offset = "0x1FAA8D0", VA = "0x181FAB8D0", Slot = "4")]
	public FJHHPENGBMK? FFIFAOFANHL(string? LJJOFJIKNDL, string? GCAFACMGFAP, string? HAPEMCMCCFP, FIJLIHGCHDL.KBENJEODHDA.KDGHJJAMAML INBNININEHN, bool GEFEMBGFAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAB550", Offset = "0x1FAA550", VA = "0x181FAB550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB800", Offset = "0x1FAA800", VA = "0x181FAB800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9A960", Offset = "0x1F99960", VA = "0x181F9A960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public APGFLEHHNBL? DKHJJDIJPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A8E0", Offset = "0x1F998E0", VA = "0x181F9A8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MAFPLDGLFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B280", Offset = "0x1F9A280", VA = "0x181F9B280", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MNHKAPHDGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A880", Offset = "0x1F99880", VA = "0x181F9A880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	internal EGLCBPFGBKA(JOOJDMJJLEH KHALMCHEKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A9E0", Offset = "0x1F999E0", VA = "0x181F9A9E0", Slot = "7")]
	[AsyncStateMachine(typeof(ONFCDPABABO))]
	public Task<BGBOPJIEMLP> KKKEKLJJHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AF10", Offset = "0x1F99F10", VA = "0x181F9AF10", Slot = "9")]
	public IReadOnlyDictionary<DAMOFJGJNKL<EKJMGNHJFDN>, Guid> PGFOILHJEDP(IEnumerable<CGIDLDDLPHO> AGAEFCPEJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AAD0", Offset = "0x1F99AD0", VA = "0x181F9AAD0")]
	public PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA> KLNEHKLMKGP([In] DPLPMGFHLCK HJLKBDGMNOH, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF, int DADHPDPLPJH)
	{
		return default(PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AED0", Offset = "0x1F99ED0", VA = "0x181F9AED0")]
	internal static DEFEBGKBMOG LJIBAPJPPFH(IDHOMPHPHDD KDOLOIDMFEN, CDJIOCDEIML MPJOKOKILNG)
	{
		return default(DEFEBGKBMOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9ACD0", Offset = "0x1F99CD0", VA = "0x181F9ACD0", Slot = "8")]
	private PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA> LCJGAMDMICO([In] DPLPMGFHLCK HJLKBDGMNOH, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF, int DADHPDPLPJH)
	{
		return default(PIJKHLBEMKP<DPLPMGFHLCK, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A630", Offset = "0x1F99630", VA = "0x181F9A630")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public NCNKFDEIEAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA860", Offset = "0x1FA9860", VA = "0x181FAA860")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public LLKKBOICCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA050", Offset = "0x1FA9050", VA = "0x181FAA050")]
			internal void LPMFBBOIJJJ(FLJAKMHKMAG n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E3C0", Offset = "0x1F9D3C0", VA = "0x181F9E3C0")]
		public static PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> JGBGEMHOKIJ(APGFLEHHNBL OLDDCPCBGIL, [In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
		{
			return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D0A0", Offset = "0x1F9C0A0", VA = "0x181F9D0A0")]
		internal static PIJKHLBEMKP<(EOAGLOOCHAC, GPOFCGMIFIM), JKFFLAEBADK> DGJHAIJNDGA(APGFLEHHNBL OLDDCPCBGIL, GPOFCGMIFIM IODIGIENGOI, bool OPCKIKOAGAG, [In] DAMOFJGJNKL<EKJMGNHJFDN> PINDFINEKFC, [In] int? LIFAEHCHCOG, [In] DEFEBGKBMOG? MCJNHKFFNGB, [In] DEFEBGKBMOG? LCPPPBENPFE)
		{
			return default(PIJKHLBEMKP<(EOAGLOOCHAC, GPOFCGMIFIM), JKFFLAEBADK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E950", Offset = "0x1F9D950", VA = "0x181F9E950")]
		private static void LIJEDCFGHFP(bool OPCKIKOAGAG, CGIDLDDLPHO PKKOMHEOCPG, EOAGLOOCHAC DLMMOCDPJNC, [In] DAMOFJGJNKL<EKJMGNHJFDN> PINDFINEKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DEC0", Offset = "0x1F9CEC0", VA = "0x181F9DEC0")]
		public static void FIOPEPCJABB(HAPEGCJCAFB FLGBCKPBNEF, [In] BGBOPJIEMLP.BGBKGFEFHEB ILJDFLKNIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E2D0", Offset = "0x1F9D2D0", VA = "0x181F9E2D0")]
		[CompilerGenerated]
		internal static bool IIPNLPBEPCB(MDDIMDPOMKC CBMAKLGFICM, ICFEHOOIGAO HOAMKPMOJKO, FLJAKMHKMAG BEIDPDGFKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F9ED90", Offset = "0x1F9DD90", VA = "0x181F9ED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA92F0", Offset = "0x1FA82F0", VA = "0x181FA92F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9940", Offset = "0x1FA8940", VA = "0x181FA9940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA9C40", Offset = "0x1FA8C40", VA = "0x181FA9C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9F80", Offset = "0x1FA8F80", VA = "0x181FA9F80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA6A80", Offset = "0x1FA5A80", VA = "0x181FA6A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6DC0", Offset = "0x1FA5DC0", VA = "0x181FA6DC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F95200", Offset = "0x1F94200", VA = "0x181F95200", Slot = "4")]
		get
		{
			return default(DAMOFJGJNKL<EKJMGNHJFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GEOEJKJFPIP NILFJBLBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1F88530", Offset = "0x1F87530", VA = "0x181F88530", Slot = "5")]
		get
		{
			return default(GEOEJKJFPIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F975F0", Offset = "0x1F965F0", VA = "0x181F975F0")]
	public APGFLEHHNBL(JOOJDMJJLEH KHALMCHEKDD, OKEJDJNOOIE NFKIECONLKB, HBBDNIKPEOK PMBKGLBIAHE, EGLCBPFGBKA DPPFHMBECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F93840", Offset = "0x1F92840", VA = "0x181F93840", Slot = "41")]
	public HBKKMIFHCOI<KEBEKGPMJKL> AANNGLFFJOC(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(HBKKMIFHCOI<KEBEKGPMJKL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F973A0", Offset = "0x1F963A0", VA = "0x181F973A0", Slot = "42")]
	public HBKKMIFHCOI<FAGHEGCFHGM> NJMGGLKOAGI(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(HBKKMIFHCOI<FAGHEGCFHGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F96E30", Offset = "0x1F95E30", VA = "0x181F96E30", Slot = "6")]
	public bool NHJIGEIJJEF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F93AE0", Offset = "0x1F92AE0", VA = "0x181F93AE0")]
	public bool BELKKJBKFDH(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F97430", Offset = "0x1F96430", VA = "0x181F97430", Slot = "8")]
	public bool OHDIMHLMCJP(BGGKHBIFAEB PNLIMBPEEFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F96860", Offset = "0x1F95860", VA = "0x181F96860", Slot = "9")]
	public bool LLMBKFLDBJP(OFKBCMKGDMA DAFAKLKEDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F972A0", Offset = "0x1F962A0", VA = "0x181F972A0")]
	public KIEKNELDHJG? NHLANNCGFBK([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F94C90", Offset = "0x1F93C90", VA = "0x181F94C90")]
	public HBKKMIFHCOI<JMIDFPKEEGG> FEGEAOBIKON(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] DAMOFJGJNKL<JMIDFPKEEGG> DCNPIEAMPAG)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F97570", Offset = "0x1F96570", VA = "0x181F97570", Slot = "20")]
	public HBKKMIFHCOI<JMIDFPKEEGG> PNAEMMAPJLK(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F95CB0", Offset = "0x1F94CB0", VA = "0x181F95CB0", Slot = "21")]
	public HBKKMIFHCOI<JMIDFPKEEGG> IPIICFCNFGD(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F947C0", Offset = "0x1F937C0", VA = "0x181F947C0")]
	private void DKOJBNCCBPP(DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F938C0", Offset = "0x1F928C0", VA = "0x181F938C0")]
	public IEnumerable<KIEKNELDHJG> AJANHPENBOO([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F95170", Offset = "0x1F94170", VA = "0x181F95170", Slot = "19")]
	public HBKKMIFHCOI<NIMJJIGJCLJ> GANPICIJFAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<KEBEKGPMJKL> GONALOCEIKE)
	{
		return default(HBKKMIFHCOI<NIMJJIGJCLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F949D0", Offset = "0x1F939D0", VA = "0x181F949D0", Slot = "22")]
	public HBKKMIFHCOI<ONJNKIAIFAM> EMDNCKGBECF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<FAGHEGCFHGM> HDLCFJJFELF)
	{
		return default(HBKKMIFHCOI<ONJNKIAIFAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F94990", Offset = "0x1F93990", VA = "0x181F94990")]
	private KIEKNELDHJG? EGLGNADAGHO([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F95DB0", Offset = "0x1F94DB0", VA = "0x181F95DB0")]
	private KIEKNELDHJG JCCKOKOGJCC([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, CDJIOCDEIML MPJOKOKILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F965E0", Offset = "0x1F955E0", VA = "0x181F965E0")]
	public CDJIOCDEIML? KDNDKPMIEON([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F940C0", Offset = "0x1F930C0", VA = "0x181F940C0")]
	public GPMBAPNKEOC? CFLGMADNMHA([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F974B0", Offset = "0x1F964B0", VA = "0x181F974B0", Slot = "15")]
	public IEnumerable<OBFDOAMHKBB> PMBKHNBHIJK(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F95FE0", Offset = "0x1F94FE0", VA = "0x181F95FE0", Slot = "16")]
	public IEnumerable<JKFONICFCFD> JJDBOJPCBPA(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F96270", Offset = "0x1F95270", VA = "0x181F96270", Slot = "17")]
	public IEnumerable<JKFONICFCFD> JJFGPCMBEAC(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F93A60", Offset = "0x1F92A60", VA = "0x181F93A60")]
	public HBKKMIFHCOI<EKJMGNHJFDN> HLGOJNLMOHL([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(HBKKMIFHCOI<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F96560", Offset = "0x1F95560", VA = "0x181F96560")]
	public HBKKMIFHCOI<EKJMGNHJFDN>? KBNCCHDABIG([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F939A0", Offset = "0x1F929A0", VA = "0x181F939A0")]
	private ICFEHOOIGAO? AKNGHOELKIL([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F940C0", Offset = "0x1F930C0", VA = "0x181F940C0")]
	private GPMBAPNKEOC? PBEBHBNJGIP([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F95820", Offset = "0x1F94820", VA = "0x181F95820", Slot = "26")]
	public DAMOFJGJNKL<EKJMGNHJFDN> GHIJPOPHFLF(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(DAMOFJGJNKL<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F95A50", Offset = "0x1F94A50", VA = "0x181F95A50", Slot = "23")]
	public IEnumerable<OMFLEFMMLLM> HGKAFKDAHBJ(MNDEIIAMGGE GJPEPMPHDKA, bool MKCMGPIHFMB, bool BNBFGLKCIIA, bool DEHKMADBKBK, bool DGMGBNEFKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F93540", Offset = "0x1F92540", VA = "0x181F93540", Slot = "24")]
	public OMFLEFMMLLM AADJJLEAKGL(MNDEIIAMGGE GJPEPMPHDKA, CKCCDGBALKM FKPIFFHGEFN, bool MKCMGPIHFMB, bool BNBFGLKCIIA, bool DEHKMADBKBK, bool DGMGBNEFKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F93F50", Offset = "0x1F92F50", VA = "0x181F93F50")]
	public OBFDOAMHKBB FBBLMLGONFO(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(OBFDOAMHKBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F94A60", Offset = "0x1F93A60", VA = "0x181F94A60", Slot = "27")]
	public JKFONICFCFD EMLEGPOIABP(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return default(JKFONICFCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F948C0", Offset = "0x1F938C0", VA = "0x181F948C0", Slot = "28")]
	public bool EBKGAFMDMAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F94740", Offset = "0x1F93740", VA = "0x181F94740", Slot = "29")]
	public bool DJNPKGPPKDP(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<NIMJJIGJCLJ> LCFLMOMMOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F941E0", Offset = "0x1F931E0", VA = "0x181F941E0", Slot = "30")]
	public bool CLILKLFGMFB(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> CGOMGBNAELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F957F0", Offset = "0x1F947F0", VA = "0x181F957F0")]
	public PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> GGCDHAPNMKE([In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
	{
		return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F95920", Offset = "0x1F94920", VA = "0x181F95920", Slot = "32")]
	[AsyncStateMachine(typeof(KJLBBEOJEJM))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HGIBNKFEIFA(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, HBKKMIFHCOI<ONJNKIAIFAM> KGLINJJPLLM, HBKKMIFHCOI<NIMJJIGJCLJ> KGIKNGMHAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F93260", VA = "0x181F94260", Slot = "33")]
	public PIJKHLBEMKP<MPHHGGPJIID, PFPHCNGMPPA> CMHLBCDLGHJ(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, MPHHGGPJIID AFLKEAAOOKI, PKPOPCCMEJH ENKHHNDEBMF)
	{
		return default(PIJKHLBEMKP<MPHHGGPJIID, PFPHCNGMPPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F95E80", Offset = "0x1F94E80", VA = "0x181F95E80", Slot = "34")]
	[AsyncStateMachine(typeof(KOJJCLOFDGE))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> JINHDBNALAP(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> MBFOPOJGAGD, HBKKMIFHCOI<LMECHAAEJCH> IDJJGINOKHE, HBKKMIFHCOI<CHIHANCPCBA> LCFLMOMMOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F95B50", Offset = "0x1F94B50", VA = "0x181F95B50", Slot = "35")]
	[AsyncStateMachine(typeof(IJIAFADFHCG))]
	public Task<PIJKHLBEMKP<HNKFFDNJINI, NJADGKCOIIE>> HHBLHNKDOFC(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> DPNJBFHMCGO, HBKKMIFHCOI<LMECHAAEJCH> DPOODGMPBKI, HBKKMIFHCOI<OPHNHCNNIBK> CGOMGBNAELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F96670", Offset = "0x1F95670", VA = "0x181F96670", Slot = "36")]
	public ALOMCECAJBD LJHLMHMLAKF(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return default(ALOMCECAJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F93E30", Offset = "0x1F92E30", VA = "0x181F93E30", Slot = "37")]
	public ALOMCECAJBD BGKFGOEHDBN()
	{
		return default(ALOMCECAJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F968E0", Offset = "0x1F958E0", VA = "0x181F968E0")]
	private JALMFEGBLDJ LPMMOPCPOPL(ODKGEFHMPDC HEJAKDDPCGA, HBKKMIFHCOI<EKJMGNHJFDN> MJCMBENGNAC, IEnumerable<DAMOFJGJNKL<EKJMGNHJFDN>> LGIBPODGGCO, IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GKJNDKDCEAM)
	{
		return default(JALMFEGBLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F96A90", Offset = "0x1F95A90", VA = "0x181F96A90", Slot = "38")]
	public JALMFEGBLDJ LPMMOPCPOPL(ODKGEFHMPDC HEJAKDDPCGA, HBKKMIFHCOI<EKJMGNHJFDN> MJCMBENGNAC, IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GKJNDKDCEAM, IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return default(JALMFEGBLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F94D10", Offset = "0x1F93D10", VA = "0x181F94D10")]
	private static IEnumerable<DAMOFJGJNKL<EKJMGNHJFDN>> FKKEKBAGAFF(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F95350", Offset = "0x1F94350", VA = "0x181F95350")]
	private IEnumerable<DAMOFJGJNKL<JMIDFPKEEGG>> GFMOPAEFJKN(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F95890", Offset = "0x1F94890", VA = "0x181F95890", Slot = "39")]
	public List<BLAOHIBFJFL> HEAKFNBKMHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F94650", Offset = "0x1F93650", VA = "0x181F94650", Slot = "40")]
	public bool CMMPNHGOHAM(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F94930", Offset = "0x1F93930", VA = "0x181F94930")]
	internal void EDEPMIGIEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F96DD0", Offset = "0x1F95DD0", VA = "0x181F96DD0")]
	internal Task MLIHHKAOCAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F97420", Offset = "0x1F96420", VA = "0x181F97420", Slot = "7")]
	private bool NPKCFOOHEPL(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F940C0", Offset = "0x1F930C0", VA = "0x181F940C0", Slot = "10")]
	private GPMBAPNKEOC EGLPNEBIHEH([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F93A60", Offset = "0x1F92A60", VA = "0x181F93A60", Slot = "11")]
	private HBKKMIFHCOI<EKJMGNHJFDN> APHAPEBEDEN([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return default(HBKKMIFHCOI<EKJMGNHJFDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F96560", Offset = "0x1F95560", VA = "0x181F96560", Slot = "12")]
	private HBKKMIFHCOI<EKJMGNHJFDN>? NLBIKJNDMGD([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F940F0", Offset = "0x1F930F0", VA = "0x181F940F0", Slot = "13")]
	private KIEKNELDHJG CHHELAOBPFO([In] DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F94C90", Offset = "0x1F93C90", VA = "0x181F94C90", Slot = "14")]
	private HBKKMIFHCOI<JMIDFPKEEGG> HALNEMMHEPD(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] DAMOFJGJNKL<JMIDFPKEEGG> DCNPIEAMPAG)
	{
		return default(HBKKMIFHCOI<JMIDFPKEEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F95090", Offset = "0x1F94090", VA = "0x181F95090", Slot = "18")]
	private IEnumerable<KIEKNELDHJG> GAHJOAFJMOC([In] DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F93F50", Offset = "0x1F92F50", VA = "0x181F93F50", Slot = "25")]
	private OBFDOAMHKBB CAFOGNAGIOH(HBKKMIFHCOI<EKJMGNHJFDN> KJEGAEAMNPF, [In] JKFONICFCFD OPEAEONMGFC)
	{
		return default(OBFDOAMHKBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F957F0", Offset = "0x1F947F0", VA = "0x181F957F0", Slot = "31")]
	private PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK> IJDLICELGBI([In] BGBOPJIEMLP.CDLKJALJLHE NENLABMEOHA)
	{
		return default(PIJKHLBEMKP<BGBOPJIEMLP.FACPONDNPGM, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F95260", Offset = "0x1F94260", VA = "0x181F95260")]
	[CompilerGenerated]
	private KIEKNELDHJG GCNBHGPHHIF(CDJIOCDEIML JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F95D30", Offset = "0x1F94D30", VA = "0x181F95D30")]
	[CompilerGenerated]
	private CFDDAHNNFCM JADMNPMOCGO(CNABLCLBOEK JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F94850", Offset = "0x1F93850", VA = "0x181F94850")]
	[CompilerGenerated]
	private CDJIOCDEIML DLKIMPCNGNF(DAMOFJGJNKL<JMIDFPKEEGG> JFDIHIMJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F964F0", Offset = "0x1F954F0", VA = "0x181F964F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAE1D0", Offset = "0x1FAD1D0", VA = "0x181FAE1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FAE450", Offset = "0x1FAD450", VA = "0x181FAE450", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAD390", Offset = "0x1FAC390", VA = "0x181FAD390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD610", Offset = "0x1FAC610", VA = "0x181FAD610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F99070", Offset = "0x1F98070", VA = "0x181F99070", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CNABLCLBOEK KFKPICPEIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F99380", Offset = "0x1F98380", VA = "0x181F99380")]
	public CFDDAHNNFCM(CNABLCLBOEK BDOLDCEGNBK, OKEJDJNOOIE NFKIECONLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1F99210", Offset = "0x1F98210", VA = "0x181F99210", Slot = "6")]
	[AsyncStateMachine(typeof(IHLMAGEFBDE))]
	public Task<PIJKHLBEMKP<HBKKMIFHCOI<KIADPJBFMAK>, NJADGKCOIIE>> NIJNNABMDJI(DAMOFJGJNKL<EKJMGNHJFDN> KJEGAEAMNPF, DAMOFJGJNKL<JMIDFPKEEGG> MHMEMGOEJHD, HBKKMIFHCOI<LMECHAAEJCH> AFLDCLCLLHN, string LCLKDNPLMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x1F990A0", Offset = "0x1F980A0", VA = "0x181F990A0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB05F0", Offset = "0x1FAF5F0", VA = "0x181FB05F0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EBCECCENLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB05E0", Offset = "0x1FAF5E0", VA = "0x181FB05E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool AJALACGDKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB07B0", Offset = "0x1FAF7B0", VA = "0x181FB07B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool HBAPJPAGHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0560", Offset = "0x1FAF560", VA = "0x181FB0560", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF2D0", Offset = "0x1FAE2D0", VA = "0x181FAF2D0")]
	public bool OKMKNGIIOOJ(string CBAEIEAPLIH, [Out] JKOGPJHKOIC MFLJABKHCPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public OMHBDILNPHD(CNABLCLBOEK LIGKCFOOPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF140", Offset = "0x1FAE140", VA = "0x181FAF140")]
	internal static TypeKey NDOPEFAOHPJ(CNABLCLBOEK PBLNJHEPKAE)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x1F99070", Offset = "0x1F98070", VA = "0x181F99070", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FAEC70", Offset = "0x1FADC70", VA = "0x181FAEC70", Slot = "4")]
	public int EBDLGCFHBFK(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC60", Offset = "0x1FADC60", VA = "0x181FAEC60", Slot = "5")]
	public LHAEFPHAKAB DCEEMHKKCGJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC90", Offset = "0x1FADC90", VA = "0x181FAEC90", Slot = "6")]
	public LHAEFPHAKAB EMMAMFOOIDG(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC20", Offset = "0x1FADC20", VA = "0x181FAEC20", Slot = "7")]
	public IReadOnlyList<LHAEFPHAKAB> CFMLLODKBLJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED20", Offset = "0x1FADD20", VA = "0x181FAED20", Slot = "8")]
	public LHAEFPHAKAB[] MCPMJGFCBPH(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ, int OBGBEPEHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC00", Offset = "0x1FADC00", VA = "0x181FAEC00", Slot = "9")]
	public bool BBDJJHKHEOF(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FAECC0", Offset = "0x1FADCC0", VA = "0x181FAECC0", Slot = "10")]
	public bool GCHBHHIKIOH(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FAECE0", Offset = "0x1FADCE0", VA = "0x181FAECE0", Slot = "11")]
	public bool GJEEBCLJENJ(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED30", Offset = "0x1FADD30", VA = "0x181FAED30", Slot = "12")]
	public bool ODACACMOFCB(HNKFFDNJINI JLMICGLMAKN, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED00", Offset = "0x1FADD00", VA = "0x181FAED00", Slot = "13")]
	public bool GPGPCNFFAPD(HNKFFDNJINI PEGGANACAPA, LHAEFPHAKAB OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC40", Offset = "0x1FADC40", VA = "0x181FAEC40", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB0930", Offset = "0x1FAF930", VA = "0x181FB0930", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB0980", Offset = "0x1FAF980", VA = "0x181FB0980", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAE4C0", Offset = "0x1FAD4C0", VA = "0x181FAE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1FAE760", Offset = "0x1FAD760", VA = "0x181FAE760", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAED50", Offset = "0x1FADD50", VA = "0x181FAED50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF0D0", Offset = "0x1FAE0D0", VA = "0x181FAF0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly PKBGPKAOHBH IPICGINFACB;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public PIIAPLMIGOD(PKBGPKAOHBH DFJCFKMIMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0B00", Offset = "0x1FAFB00", VA = "0x181FB0B00")]
	[AsyncStateMachine(typeof(KDMPFDDLDPE))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EKKCLFIOMLH(LHAEFPHAKAB OGLJLDNLGIJ, bool EPJOLNMCGPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB09D0", Offset = "0x1FAF9D0", VA = "0x181FB09D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F8AC20", Offset = "0x1F89C20", VA = "0x181F8AC20")]
	private PEPAPMHKFKO([In] FOMFGEDLPOL<LAIIPGLFFDO, LHAEFPHAKAB, EGKIGOBIHGJ> AOEHMJKNPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x1FB08D0", Offset = "0x1FAF8D0", VA = "0x181FB08D0")]
	public static PEPAPMHKFKO HCLFOFEHDJP()
	{
		return default(PEPAPMHKFKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class MEGPJFELEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FAD680", Offset = "0x1FAC680", VA = "0x181FAD680", Slot = "5")]
	public LHAEFPHAKAB KOPEFNAMCKL(LAIIPGLFFDO[] ENHIMKDFLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0")]
	public int LBDKIEPAIEF([In] LAIIPGLFFDO EKOGPHNJFMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F8AC20", Offset = "0x1F89C20", VA = "0x181F8AC20")]
	private EJAAMGBHNOH([In] MDJMPLHOKKJ<GMLOAEMICEM, LHAEFPHAKAB, BBCCGNBNHOO> GPNGODCEGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD870", Offset = "0x1FAC870", VA = "0x181FAD870")]
	public static EJAAMGBHNOH HCLFOFEHDJP()
	{
		return default(EJAAMGBHNOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class JHDHKEFPOLC
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0")]
	public int FAAMDAHGCGF([In] GMLOAEMICEM EKOGPHNJFMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD1A0", Offset = "0x1FAC1A0", VA = "0x181FAD1A0", Slot = "5")]
	public LHAEFPHAKAB CEEFOGPAMMO(GMLOAEMICEM[] BNEPOBMHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(LEELBPOKNLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x868080", Offset = "0x867080", VA = "0x180868080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override PFPHCNGMPPA? AOHMEHBPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE9C0", Offset = "0x1FAD9C0", VA = "0x181FAE9C0", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEBC0", Offset = "0x1FADBC0", VA = "0x181FAEBC0")]
	private LFACDBPJMBF(LEELBPOKNLO JGHIAOJOLJP, PFPHCNGMPPA? KCLFHIGFABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEB40", Offset = "0x1FADB40", VA = "0x181FAEB40")]
	public static LFACDBPJMBF NBKHDIGNOGF(PFPHCNGMPPA KCLFHIGFABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE8E0", Offset = "0x1FAD8E0", VA = "0x181FAE8E0")]
	public static LFACDBPJMBF CJNPBGPNDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE950", Offset = "0x1FAD950", VA = "0x181FAE950")]
	public static LFACDBPJMBF HLFCMANLIPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class IGGGBOIOMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2B48AC0", Offset = "0x2B47AC0", VA = "0x182B48AC0")]
	public static PIJKHLBEMKP<TOk, JKFFLAEBADK> CJCNDIEFBID<TOk>([In] this PIJKHLBEMKP<TOk, JKFFLAEBADK> OLDDCPCBGIL, PFPHCNGMPPA KCLFHIGFABJ) where TOk : notnull
	{
		return default(PIJKHLBEMKP<TOk, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2B48CA0", Offset = "0x2B47CA0", VA = "0x182B48CA0")]
	public static PIJKHLBEMKP<TOk?, JKFFLAEBADK?> IHEKENIDPKG<TOk>([In] this PIJKHLBEMKP<TOk, JKFFLAEBADK> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<TOk, JKFFLAEBADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2B48BB0", Offset = "0x2B47BB0", VA = "0x182B48BB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CA8420", Offset = "0x2CA7420", VA = "0x182CA8420")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAE890", Offset = "0x1FAD890", VA = "0x181FAE890")]
		private KDMPHNKNGMG(int LLPJHIPCNFD, OCCKDCOPHOC? ENHKLDEEJND, OCCKDCOPHOC? GLIKJLJKENE, List<LHAEFPHAKAB> HAMKHHIHPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x1FAE7D0", Offset = "0x1FAD7D0", VA = "0x181FAE7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FADFD0", Offset = "0x1FACFD0", VA = "0x181FADFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B8780", Offset = "0x8B7780", VA = "0x1808B8780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE90", Offset = "0x9BBE90", VA = "0x1809BCE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD8D0", Offset = "0x1FAC8D0", VA = "0x181FAD8D0")]
	public void BLBLLEIAEKH(MDDIMDPOMKC GLIKJLJKENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD990", Offset = "0x1FAC990", VA = "0x181FAD990")]
	public void HBMKADHEIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1FADC90", Offset = "0x1FACC90", VA = "0x181FADC90")]
	private static string? HCCEPKNLCIN([In] KDMPHNKNGMG KCOBPCPODIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE120", Offset = "0x1FAD120", VA = "0x181FAE120")]
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
