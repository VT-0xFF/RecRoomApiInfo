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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D2B570", Offset = "0x1D2A970", VA = "0x181D2B570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DPOHHGLACDM : IDisposable, ELLLAIMABFF, IDHNMIILEDK, HKFFGGJGDKG, PGDHGJACCNB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class HAHPLMADIHM : POJJIDPLMEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int KHKNKEPFFCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D211D0", Offset = "0x1D205D0", VA = "0x181D211D0", Slot = "5")]
		public AOKPKMPOIFB LEPCFBFPAMK(NJEFKMFEPEE.OGKJCFBAHMC MLLANHDPJEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LGCLHHPAEHC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void EEOPKCCCPCH();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1D21150", Offset = "0x1D20550", VA = "0x181D21150", Slot = "13")]
		public virtual void DNBPLMMJJKP(DPOHHGLACDM JFEBJHGKJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D21320", Offset = "0x1D20720", VA = "0x181D21320", Slot = "14")]
		public virtual void NBEBMDONAHJ(DPOHHGLACDM JFEBJHGKJHE, LOAMOHDBOAD HKJBPIINLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		protected HAHPLMADIHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface POJJIDPLMEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int KHKNKEPFFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AOKPKMPOIFB LEPCFBFPAMK(NJEFKMFEPEE.OGKJCFBAHMC MLLANHDPJEE);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LGCLHHPAEHC();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EEOPKCCCPCH();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DNBPLMMJJKP(DPOHHGLACDM JFEBJHGKJHE);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NBEBMDONAHJ(DPOHHGLACDM JFEBJHGKJHE, LOAMOHDBOAD HKJBPIINLDG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct PPDGAMEKNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LNAJOMJEKNC<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> PBEAHKDNFOA;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EBB0", Offset = "0x1D2DFB0", VA = "0x181D2EBB0")]
		internal PPDGAMEKNMH(LNAJOMJEKNC<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> FBIBFNALIEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PNBBDPCBEEL : PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PNBBDPCBEEL GHDJCOLHINO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		private PNBBDPCBEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEB0", Offset = "0xA1B2B0", VA = "0x180A1BEB0", Slot = "4")]
		public PALFOBNHMHK KHGHNDIHENN(LOAMOHDBOAD LOMPFKEACIP)
		{
			return default(PALFOBNHMHK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E910", Offset = "0x1D2DD10", VA = "0x181D2E910", Slot = "5")]
		public void DNBPLMMJJKP(DPOHHGLACDM DHHBNGOGOPD, LOAMOHDBOAD HKJBPIINLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EA20", Offset = "0x1D2DE20", VA = "0x181D2EA20", Slot = "6")]
		public void NBEBMDONAHJ(DPOHHGLACDM DHHBNGOGOPD, LOAMOHDBOAD HKJBPIINLDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HGHBFCFMGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JAMIIGBDJCD<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> PBEAHKDNFOA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D220E0", Offset = "0x1D214E0", VA = "0x181D220E0")]
		internal HGHBFCFMGIG(JAMIIGBDJCD<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> FBIBFNALIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D22090", Offset = "0x1D21490", VA = "0x181D22090")]
		public static HGHBFCFMGIG CPLKLKACALP()
		{
			return default(HGHBFCFMGIG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NHEJCBLNMIM : IHKNFHBFMNG.HPMPJEGEOAD<EEOFNEKIBGO, LOAMOHDBOAD, DPOHHGLACDM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct DODPIOFKLJB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DPOHHGLACDM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LOAMOHDBOAD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NHEJCBLNMIM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D15030", Offset = "0x1D14430", VA = "0x181D15030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D15210", Offset = "0x1D14610", VA = "0x181D15210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEB0", Offset = "0xA1B2B0", VA = "0x180A1BEB0", Slot = "4")]
		public LELHOHFMKKF<EEOFNEKIBGO> CKBPCLAPHJM(DPOHHGLACDM KNPJGAEAGFF)
		{
			return default(LELHOHFMKKF<EEOFNEKIBGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A500", Offset = "0x1D29900", VA = "0x181D2A500", Slot = "5")]
		[AsyncStateMachine(typeof(DODPIOFKLJB))]
		public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> ANNLIAEODMB(DPOHHGLACDM KNPJGAEAGFF, LOAMOHDBOAD HKJBPIINLDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A630", Offset = "0x1D29A30", VA = "0x181D2A630", Slot = "6")]
		public LOAMOHDBOAD[] LBNLOBHGPMD(DPOHHGLACDM KNPJGAEAGFF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AMDIGNCLPMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DPOHHGLACDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CCDJHKBKGMD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JPIILNLKKAK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MOBKEGKHHKE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D12EB0", Offset = "0x1D122B0", VA = "0x181D12EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D13130", Offset = "0x1D12530", VA = "0x181D13130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OOICHNOHHGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DPOHHGLACDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C3F0", Offset = "0x1D2B7F0", VA = "0x181D2C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C680", Offset = "0x1D2BA80", VA = "0x181D2C680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BNANHFOKHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DPOHHGLACDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D13530", Offset = "0x1D12930", VA = "0x181D13530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D13710", Offset = "0x1D12B10", VA = "0x181D13710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MCNEPDOECJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DPOHHGLACDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public LOAMOHDBOAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D26D10", Offset = "0x1D26110", VA = "0x181D26D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D26F00", Offset = "0x1D26300", VA = "0x181D26F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PCEKEOLLIKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public DPOHHGLACDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D950", Offset = "0x1D2CD50", VA = "0x181D2D950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E140", Offset = "0x1D2D540", VA = "0x181D2E140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LELHOHFMKKF<EEOFNEKIBGO> KMHIELFNDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PPDGAMEKNMH GBNDLENAHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EJNMOIPJJHB CFHMKCGDFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly CJPDCCEDLLC HBINNPAFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly PINFCBGDJKA NNEHBHOOFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly DKLLMPOOJBB.PIJNNIPOKPN GKAPIOAKEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly NJFHKMLFGAP FDCDBBFOMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly PCFCFNENHOD IMJPEIHFMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HDKAEJDPAHL MCHMAKMNFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly GFKEMEBJHCF ABCAPMIMJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HDCDFGPGBAI AJDCMMFJJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1008")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MKPBKPFDFCG PJJMNOLNNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1028")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly EJNMOIPJJHB.CJEOJOKFBPK JBNKBFGIDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1030")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly AFEFDIHJDGK MJHICNHEFAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EJNMOIPJJHB EKJPCOJOMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C4D0", Offset = "0x1D1B8D0", VA = "0x181D1C4D0")]
		get
		{
			return default(EJNMOIPJJHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal POJJIDPLMEH BCLAKOEBHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BCC0", Offset = "0x1D1B0C0", VA = "0x181D1BCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal AOKPKMPOIFB OIIOCALBIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B130", Offset = "0x1D1A530", VA = "0x181D1B130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B770", Offset = "0x1D1AB70", VA = "0x181D1B770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HBPKLGDDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C0A0", Offset = "0x1D1B4A0", VA = "0x181D1C0A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BB50", Offset = "0x1D1AF50", VA = "0x181D1BB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHJGDCFMJDN PNPJPEMIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C800", Offset = "0x1D1BC00", VA = "0x181D1C800", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PHKGCIFAFDN FGCBFFLGFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C820", Offset = "0x1D1BC20", VA = "0x181D1C820", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ODFGIPCKMLI OFJEAACINDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C830", Offset = "0x1D1BC30", VA = "0x181D1C830", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LEOLOJJDHIF BIJKCGNOCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C810", Offset = "0x1D1BC10", VA = "0x181D1C810", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private BLCFMHBFELN? GDPPJNEDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B8F0", Offset = "0x1D1ACF0", VA = "0x181D1B8F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BNBJPAHIOEM? IBEMACAHEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BA20", Offset = "0x1D1AE20", VA = "0x181D1BA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C4E0", Offset = "0x1D1B8E0", VA = "0x181D1C4E0")]
	private DPOHHGLACDM(PINFCBGDJKA KIGAJECMNEJ, LELHOHFMKKF<EEOFNEKIBGO> EKIMCCFCFIG, [In] PPDGAMEKNMH EEPBJEPPADF, [In] EJNMOIPJJHB KLLILIANKBN, [In] CJPDCCEDLLC KNOJKMBFCIF, AOKPKMPOIFB BMNIIHDNHLM, [In] DKLLMPOOJBB.PIJNNIPOKPN PIDHJDJDHPP, EJNMOIPJJHB.CJEOJOKFBPK OJLGIAEIBEE, AFEFDIHJDGK IMBEBEBAHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B140", Offset = "0x1D1A540", VA = "0x181D1B140")]
	public static DPOHHGLACDM CPLKLKACALP(PINFCBGDJKA MLLANHDPJEE, EJNMOIPJJHB.DFEFBLMKACD PLJJFMJMDOA, LELHOHFMKKF<EEOFNEKIBGO> EKIMCCFCFIG, LELHOHFMKKF<BLGIEHPDHCC> CEEDHGOLPDE, NOKEHKADGPK MACKCAOBDPO, JHPIAPALLCI DENALFLJMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B2A0", Offset = "0x1D1A6A0", VA = "0x181D1B2A0")]
	public static DPOHHGLACDM CPLKLKACALP(PINFCBGDJKA KIGAJECMNEJ, [In] EJNMOIPJJHB KLLILIANKBN, [In] CJPDCCEDLLC KNOJKMBFCIF, LELHOHFMKKF<EEOFNEKIBGO> EKIMCCFCFIG, LELHOHFMKKF<BLGIEHPDHCC> CEEDHGOLPDE, NOKEHKADGPK MACKCAOBDPO, JHPIAPALLCI DENALFLJMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B580", Offset = "0x1D1A980", VA = "0x181D1B580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BB60", Offset = "0x1D1AF60", VA = "0x181D1BB60")]
	[AsyncStateMachine(typeof(AMDIGNCLPMJ))]
	internal Task<IAPKJCHKLLD<bool, HDKPGPNEBBO>> IDMNMAHEECA(CCDJHKBKGMD IEOLFELCNDG, JPIILNLKKAK BAODNDKBBPK, MOBKEGKHHKE CGLBOCLPJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C240", Offset = "0x1D1B640", VA = "0x181D1C240")]
	[AsyncStateMachine(typeof(OOICHNOHHGM))]
	public Task<IAPKJCHKLLD<bool, HDKPGPNEBBO>> PAMOCHOMPHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B790", Offset = "0x1D1AB90", VA = "0x181D1B790")]
	[AsyncStateMachine(typeof(BNANHFOKHDL))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> EGDHKPACHBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D1AF20", Offset = "0x1D1A320", VA = "0x181D1AF20")]
	internal void ADJHGHLNFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C0B0", Offset = "0x1D1B4B0", VA = "0x181D1C0B0")]
	internal MEHMHNNDBEN<LOAMOHDBOAD> NHBILBDHFPH([In] GLOLEFJGGIP OJDHAALMPCD)
	{
		return default(MEHMHNNDBEN<LOAMOHDBOAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B880", Offset = "0x1D1AC80", VA = "0x181D1B880")]
	internal bool EONCJABCGBD([In] GLOLEFJGGIP OJDHAALMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C330", Offset = "0x1D1B730", VA = "0x181D1C330")]
	internal MEHMHNNDBEN<LOAMOHDBOAD> PFABGLKNGNB([In] FAJPOODAAGD FDMJILCMGEK)
	{
		return default(MEHMHNNDBEN<LOAMOHDBOAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C130", Offset = "0x1D1B530", VA = "0x181D1C130")]
	[AsyncStateMachine(typeof(MCNEPDOECJI))]
	internal Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> NKMKGJKJNGE(LOAMOHDBOAD HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD10", Offset = "0x1D1B110", VA = "0x181D1BD10")]
	private LOAMOHDBOAD[] LBNLOBHGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C3B0", Offset = "0x1D1B7B0", VA = "0x181D1C3B0")]
	[AsyncStateMachine(typeof(PCEKEOLLIKN))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> PFGNCGPHHJL(Guid JOCJDOCMIGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MCOJFKHOJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2749880", Offset = "0x2748C80", VA = "0x182749880")]
	public static FALBHHGFIEG<(TPrev?, DPOHHGLACDM?), BNBJPAHIOEM> KMMAMBFCHDO<TPrev>([In] this FALBHHGFIEG<TPrev, DPOHHGLACDM> LOMPFKEACIP)
	{
		return default(FALBHHGFIEG<(TPrev, DPOHHGLACDM), BNBJPAHIOEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2749660", Offset = "0x2748A60", VA = "0x182749660")]
	public static FALBHHGFIEG<TPrev?, DPOHHGLACDM?> DFIFFPOCEJO<TPrev>([In] this FALBHHGFIEG<TPrev, DPOHHGLACDM> LOMPFKEACIP)
	{
		return default(FALBHHGFIEG<TPrev, DPOHHGLACDM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class CAJHKKFHADK<TData> : PKAEFJIJPHG, NJBEAIANNCA, LKFFGCCEJDH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BKCFLNKEACJ<FFAKLMOHHBO>? LNHKINGGAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string MHEEAEBIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData NCANEPOJAJP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BKCFLNKEACJ<FFAKLMOHHBO>? KIMHCDNIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1EBEB40", Offset = "0x1EBDF40", VA = "0x181EBEB40", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A47A0", Offset = "0x7A3BA0", VA = "0x1807A47A0", Slot = "7")]
	public override string KHCKPFAHKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4832AC0", Offset = "0x4831EC0", VA = "0x184832AC0")]
	internal CAJHKKFHADK([In] BKCFLNKEACJ<FFAKLMOHHBO>? HNKJNDBBGLJ, LELHOHFMKKF<COHCNNIPOPA>? JOFOIMCOIOC, IOKind? PMJOIOKCKDD, string CAIOIMEOMNJ, [In] TData ALPLHOOHPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KKELLNBDCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D267B0", Offset = "0x1D25BB0", VA = "0x181D267B0")]
	public static IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA> LINIPPHAAAE([In] this EOCFCLCIFEO<LHIKFBLJJKM> KCKODDAAICC)
	{
		return default(IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27206C0", Offset = "0x271FAC0", VA = "0x1827206C0")]
	public static IAPKJCHKLLD<TOk, NJBEAIANNCA> ELLPAMCOOLN<TOk>([In] this IAPKJCHKLLD<TOk, NJBEAIANNCA> LOMPFKEACIP, [In] BKCFLNKEACJ<FFAKLMOHHBO>? HNKJNDBBGLJ, LELHOHFMKKF<COHCNNIPOPA>? JOFOIMCOIOC, IOKind? PMJOIOKCKDD, string CAIOIMEOMNJ) where TOk : notnull
	{
		return default(IAPKJCHKLLD<TOk, NJBEAIANNCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PINFCBGDJKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KAGGEPDIJHE.COJFLBMOJHN BACLPNLHMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NJEFKMFEPEE.OGKJCFBAHMC KIPLPOLFOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DPOHHGLACDM.POJJIDPLMEH EJJDGNPDCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CJLDDMBLOMP.MDEACIDCPNH HOEKJNJIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM> DGHDFAMJIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FMMFCOMCHNK KODGAOFNAED
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FGLHCDBNHIK CCMDGDMPFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PELIKIBPIJH OEDHNDOMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KLLCGLKENGP DFIBDKFHPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LOLCKGKFAJM OALLLFPHMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GGEKCAIBHBN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F8E0", Offset = "0x1D1ECE0", VA = "0x181D1F8E0")]
	public static LOAMOHDBOAD EDEMIOKFAPM(this LOAMOHDBOAD LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F9F0", Offset = "0x1D1EDF0", VA = "0x181D1F9F0")]
	public static LOAMOHDBOAD FGOHGBEOHEP(this GJMICIHGNFA LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GJMICIHGNFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BBFLMFOPOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DPOHHGLACDM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public GJMICIHGNFA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D131A0", Offset = "0x1D125A0", VA = "0x181D131A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D13460", Offset = "0x1D12860", VA = "0x181D13460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString BDGBGLMDOLF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	private GJMICIHGNFA(ByteString ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FDB0", Offset = "0x1D1F1B0", VA = "0x181D1FDB0")]
	public static LOAMOHDBOAD IJLDKIGBNOA(ByteString ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FD00", Offset = "0x1D1F100", VA = "0x181D1FD00")]
	public static NJOABLHJPPJ<PALFOBNHMHK, GJMICIHGNFA> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, GJMICIHGNFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FE70", Offset = "0x1D1F270", VA = "0x181D1FE70")]
	[AsyncStateMachine(typeof(BBFLMFOPOJL))]
	public static Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> NKMKGJKJNGE(DPOHHGLACDM DHHBNGOGOPD, GJMICIHGNFA LOMPFKEACIP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PBFNFPPDLAI
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D830", Offset = "0x1D2CC30", VA = "0x181D2D830")]
	public static LOAMOHDBOAD IJLDKIGBNOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D7C0", Offset = "0x1D2CBC0", VA = "0x181D2D7C0")]
	public static NJOABLHJPPJ<PALFOBNHMHK, PBFNFPPDLAI> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, PBFNFPPDLAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D8D0", Offset = "0x1D2CCD0", VA = "0x181D2D8D0")]
	public static IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG> JNOKEHCMGPO(DPOHHGLACDM DHHBNGOGOPD, [In] PBFNFPPDLAI LOMPFKEACIP)
	{
		return default(IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PGJKGAIDEJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KDAPOFLLOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DPOHHGLACDM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PGJKGAIDEJG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1D26100", Offset = "0x1D25500", VA = "0x181D26100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1D26470", Offset = "0x1D25870", VA = "0x181D26470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly CCDJHKBKGMD? BFEAMKENOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JPIILNLKKAK? CEMAIBEKEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly MOBKEGKHHKE? OGKMLJMENGC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A1F1B0", Offset = "0x1A1E5B0", VA = "0x181A1F1B0")]
	private PGJKGAIDEJG(CCDJHKBKGMD? IEOLFELCNDG, JPIILNLKKAK? BAODNDKBBPK, MOBKEGKHHKE? CGLBOCLPJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E6D0", Offset = "0x1D2DAD0", VA = "0x181D2E6D0")]
	public static LOAMOHDBOAD? IJLDKIGBNOA(CCDJHKBKGMD? IEOLFELCNDG, JPIILNLKKAK? BAODNDKBBPK, MOBKEGKHHKE? CGLBOCLPJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E5C0", Offset = "0x1D2D9C0", VA = "0x181D2E5C0")]
	public static NJOABLHJPPJ<PALFOBNHMHK, PGJKGAIDEJG> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, PGJKGAIDEJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E7D0", Offset = "0x1D2DBD0", VA = "0x181D2E7D0")]
	[AsyncStateMachine(typeof(KDAPOFLLOFP))]
	public static Task<IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG>> NKMKGJKJNGE(DPOHHGLACDM DHHBNGOGOPD, PGJKGAIDEJG LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MEMFCIBIBNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct NNJMPJLLOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<DJBBEBFPLOK, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MEMFCIBIBNE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DPOHHGLACDM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IAPKJCHKLLD<DJBBEBFPLOK, HDKPGPNEBBO> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IAPKJCHKLLD<object, LKFFGCCEJDH>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private IAPKJCHKLLD<object, LKFFGCCEJDH> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IAPKJCHKLLD<object, LKFFGCCEJDH>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AFA0", Offset = "0x1D2A3A0", VA = "0x181D2AFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B410", Offset = "0x1D2A810", VA = "0x181D2B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<LOAMOHDBOAD> LMANMAPJFLF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	private MEMFCIBIBNE(IReadOnlyList<LOAMOHDBOAD> EFJGOOKKOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D27010", Offset = "0x1D26410", VA = "0x181D27010")]
	public static LOAMOHDBOAD IJLDKIGBNOA(IReadOnlyList<LOAMOHDBOAD> EFJGOOKKOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D26F70", Offset = "0x1D26370", VA = "0x181D26F70")]
	public static NJOABLHJPPJ<PALFOBNHMHK, MEMFCIBIBNE> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, MEMFCIBIBNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D270D0", Offset = "0x1D264D0", VA = "0x181D270D0")]
	[AsyncStateMachine(typeof(NNJMPJLLOLL))]
	public static Task<IAPKJCHKLLD<DJBBEBFPLOK, HDKPGPNEBBO>> NKMKGJKJNGE(DPOHHGLACDM DHHBNGOGOPD, MEMFCIBIBNE LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FAJPOODAAGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int EKCLJKKLOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int BLAEHDOLMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] NCANEPOJAJP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1791C00", Offset = "0x1791000", VA = "0x181791C00")]
	private FAJPOODAAGD(int CBPPKGAPPDD, int AHDNEIKOMIB, byte[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D3E0", Offset = "0x1D1C7E0", VA = "0x181D1D3E0")]
	public static LOAMOHDBOAD IJLDKIGBNOA(int CBPPKGAPPDD, int AHDNEIKOMIB, ByteString ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D5E0", Offset = "0x1D1C9E0", VA = "0x181D1D5E0")]
	public static LOAMOHDBOAD[] LHIDDHNBNCA(LOAMOHDBOAD HKJBPIINLDG, int GHBGPEGNALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D300", Offset = "0x1D1C700", VA = "0x181D1D300")]
	public static NJOABLHJPPJ<PALFOBNHMHK, FAJPOODAAGD> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, FAJPOODAAGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D4C0", Offset = "0x1D1C8C0", VA = "0x181D1D4C0")]
	public static IAPKJCHKLLD<LOAMOHDBOAD, MBFBMDOADGG> JNOKEHCMGPO(DPOHHGLACDM DHHBNGOGOPD, [In] FAJPOODAAGD LOMPFKEACIP)
	{
		return default(IAPKJCHKLLD<LOAMOHDBOAD, MBFBMDOADGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GLOLEFJGGIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct OONMCOPMDKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<bool, MBFBMDOADGG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DPOHHGLACDM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GLOLEFJGGIP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private IAPKJCHKLLD<bool, MBFBMDOADGG> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, MBFBMDOADGG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C6F0", Offset = "0x1D2BAF0", VA = "0x181D2C6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2CD30", Offset = "0x1D2C130", VA = "0x181D2CD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int EKCLJKKLOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int BLAEHDOLMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] NCANEPOJAJP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1791C00", Offset = "0x1791000", VA = "0x181791C00")]
	private GLOLEFJGGIP(int CBPPKGAPPDD, int AHDNEIKOMIB, byte[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D20890", Offset = "0x1D1FC90", VA = "0x181D20890")]
	public static LOAMOHDBOAD IJLDKIGBNOA(int CBPPKGAPPDD, int AHDNEIKOMIB, ByteString ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D20AA0", Offset = "0x1D1FEA0", VA = "0x181D20AA0")]
	public static LOAMOHDBOAD?[]? OPPNANFHHNB(int GHBGPEGNALO, CCDJHKBKGMD? IEOLFELCNDG, JPIILNLKKAK? BAODNDKBBPK, MOBKEGKHHKE? CGLBOCLPJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D207B0", Offset = "0x1D1FBB0", VA = "0x181D207B0")]
	public static NJOABLHJPPJ<PALFOBNHMHK, GLOLEFJGGIP> BCPGKGHAOLH(LOAMOHDBOAD LDHBFICIPMG)
	{
		return default(NJOABLHJPPJ<PALFOBNHMHK, GLOLEFJGGIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D20970", Offset = "0x1D1FD70", VA = "0x181D20970")]
	[AsyncStateMachine(typeof(OONMCOPMDKL))]
	public static Task<IAPKJCHKLLD<bool, MBFBMDOADGG>> NKMKGJKJNGE(DPOHHGLACDM DHHBNGOGOPD, GLOLEFJGGIP LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NJFHKMLFGAP : GHJGDCFMJDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MEMCCOJEMCN? GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AB90", Offset = "0x1D29F90", VA = "0x181D2AB90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	internal NJFHKMLFGAP(DPOHHGLACDM JFEBJHGKJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OGDGIMDDODK : MEMCCOJEMCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NKHIGFADDMD OEKNNHKGODO;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
	public OGDGIMDDODK(DPOHHGLACDM JFEBJHGKJHE, NKHIGFADDMD GGILDEJPPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BFD0", Offset = "0x1D2B3D0", VA = "0x181D2BFD0", Slot = "4")]
	public IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA> ICGMLMCNJGE(BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<HFFLFLDFDGK> MIPIBMCBIIC)
	{
		return default(IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BD00", Offset = "0x1D2B100", VA = "0x181D2BD00", Slot = "5")]
	public IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA> EIJCIFGHMIO(BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<PEMACHABAND> KPOALPLEIEO)
	{
		return default(IAPKJCHKLLD<GIDLHIODNPE, NJBEAIANNCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KAGGEPDIJHE : OFDPNPBJHOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface COJFLBMOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NKHIGFADDMD> JLNCANKKKAE(DPOHHGLACDM JFEBJHGKJHE, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK, CancellationToken PPJMMMGPFGD);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BEMFABBHDAG DCLBHNKMPLI(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IMGHLPFOGAK : COJFLBMOJHN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct PEFDCMPEFID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<NKHIGFADDMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public DPOHHGLACDM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public JPIILNLKKAK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public MOBKEGKHHKE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<CJLDDMBLOMP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E230", Offset = "0x1D2D630", VA = "0x181D2E230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E550", Offset = "0x1D2D950", VA = "0x181D2E550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IMGHLPFOGAK GHDJCOLHINO;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		private IMGHLPFOGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D22FB0", Offset = "0x1D223B0", VA = "0x181D22FB0", Slot = "4")]
		[AsyncStateMachine(typeof(PEFDCMPEFID))]
		public Task<NKHIGFADDMD> JLNCANKKKAE(DPOHHGLACDM JFEBJHGKJHE, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK, CancellationToken PPJMMMGPFGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1D22F90", Offset = "0x1D22390", VA = "0x181D22F90", Slot = "5")]
		public BEMFABBHDAG DCLBHNKMPLI(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HJGBFLBJAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<KAGGEPDIJHE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DPOHHGLACDM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JPIILNLKKAK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MOBKEGKHHKE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CCDJHKBKGMD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private COJFLBMOJHN <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<NKHIGFADDMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D220F0", Offset = "0x1D214F0", VA = "0x181D220F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1D22650", Offset = "0x1D21A50", VA = "0x181D22650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NKHIGFADDMD OEKNNHKGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly BEMFABBHDAG KOJKMPGDBKF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BLCFMHBFELN DCEIPHFECDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1D26010", Offset = "0x1D25410", VA = "0x181D26010", Slot = "4")]
		get
		{
			return default(BLCFMHBFELN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BNBJPAHIOEM BBJOHALIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1D25DE0", Offset = "0x1D251E0", VA = "0x181D25DE0", Slot = "5")]
		get
		{
			return default(BNBJPAHIOEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OGDGIMDDODK BOKAMKGIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public IPDECNDKKEE LIDPACAOMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public INMGBNCHJOL NKCGKEHOPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D26070", Offset = "0x1D25470", VA = "0x181D26070")]
	private KAGGEPDIJHE(NKHIGFADDMD GGILDEJPPPD, BEMFABBHDAG AHJLDPBONMJ, OGDGIMDDODK GPAOPDDKPAH, IPDECNDKKEE NLNCPGOGCIM, INMGBNCHJOL NOAAHLEDIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D25EA0", Offset = "0x1D252A0", VA = "0x181D25EA0")]
	[AsyncStateMachine(typeof(HJGBFLBJAEG))]
	public static Task<KAGGEPDIJHE> MOLNINMADMF(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D25E40", Offset = "0x1D25240", VA = "0x181D25E40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NJEFKMFEPEE : AOKPKMPOIFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface OGKJCFBAHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<OFDPNPBJHOD> DCJHKOKEDGI(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK, CancellationToken PPJMMMGPFGD);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GEPFBGBFENI();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MGECEFNFKBA();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class EENBEOOBDLG : OGKJCFBAHMC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct ICBAIBHDDOE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<OFDPNPBJHOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public DPOHHGLACDM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public CCDJHKBKGMD evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public JPIILNLKKAK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public MOBKEGKHHKE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<KAGGEPDIJHE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D227C0", Offset = "0x1D21BC0", VA = "0x181D227C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D22B00", Offset = "0x1D21F00", VA = "0x181D22B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C840", Offset = "0x1D1BC40", VA = "0x181D1C840", Slot = "4")]
		[AsyncStateMachine(typeof(ICBAIBHDDOE))]
		public Task<OFDPNPBJHOD> DCJHKOKEDGI(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK, CancellationToken PPJMMMGPFGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GEPFBGBFENI();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MGECEFNFKBA();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		protected EENBEOOBDLG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KDLFNPJLBHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<OFDPNPBJHOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NJEFKMFEPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<MKHCJDDCMIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D264E0", Offset = "0x1D258E0", VA = "0x181D264E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D266E0", Offset = "0x1D25AE0", VA = "0x181D266E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CLFLJPABHKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public NJEFKMFEPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DPOHHGLACDM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CCDJHKBKGMD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JPIILNLKKAK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public MOBKEGKHHKE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<OFDPNPBJHOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D14210", Offset = "0x1D13610", VA = "0x181D14210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D14740", Offset = "0x1D13B40", VA = "0x181D14740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly OGKJCFBAHMC ILLOCOKHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<MKHCJDDCMIA> GAEBENCGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<MKHCJDDCMIA> LDGKKEMPNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource PFBJMGODHDK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HBPKLGDDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7EC380", Offset = "0x7EB780", VA = "0x1807EC380", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7EC910", Offset = "0x7EBD10", VA = "0x1807EC910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD70", Offset = "0x8BD170", VA = "0x1808BDD70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD80", Offset = "0x8BD180", VA = "0x1808BDD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HHKDDJCEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AA70", Offset = "0x1D29E70", VA = "0x181D2AA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public OFDPNPBJHOD? GJBBCGOLBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A6B0", Offset = "0x1D29AB0", VA = "0x181D2A6B0", Slot = "7")]
	[AsyncStateMachine(typeof(KDLFNPJLBHM))]
	public Task<OFDPNPBJHOD> ALIBOGAIBLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D2AA80", Offset = "0x1D29E80", VA = "0x181D2AA80")]
	public NJEFKMFEPEE(OGKJCFBAHMC MLLANHDPJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A910", Offset = "0x1D29D10", VA = "0x181D2A910", Slot = "8")]
	[AsyncStateMachine(typeof(CLFLJPABHKK))]
	public Task JODHKNGLMDN(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A7A0", Offset = "0x1D29BA0", VA = "0x181D2A7A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BBJLPEJBNBK : BKIGPCAIPPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IPDECNDKKEE PPMOECMJLHM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public BBJLPEJBNBK(IPDECNDKKEE NLNCPGOGCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GIODIKFCNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class MAKBHKCKPPN<TGraph> : ODCDFBLDLJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph KNIABDNNJIH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual CHIPJCGOILH? OMMIFILLHOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD06A80", Offset = "0xD05E80", VA = "0x180D06A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
		public MAKBHKCKPPN(TGraph HOGIGPFBANF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GFMEFDEMIHG : MAKBHKCKPPN<JNBDNPFEFDC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override CHIPJCGOILH? OMMIFILLHOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1D1F7F0", Offset = "0x1D1EBF0", VA = "0x181D1F7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F810", Offset = "0x1D1EC10", VA = "0x181D1F810")]
		public GFMEFDEMIHG(JNBDNPFEFDC JCMLHMINGNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FB70", Offset = "0x1D1EF70", VA = "0x181D1FB70")]
	public static ODCDFBLDLJG CPLKLKACALP(LKDLEGDJFDM HOGIGPFBANF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NCFFFOCEFMK : GDOMCFJMAOO, PBJDPJGEOOI, GBEKEIPKALF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NNLABLLDNJO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NNLABLLDNJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public FMMFCOMCHNK errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1D2EBC0", Offset = "0x1D2DFC0", VA = "0x181D2EBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D2EE30", Offset = "0x1D2E230", VA = "0x181D2EE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NCFFFOCEFMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NNLABLLDNJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B480", Offset = "0x1D2A880", VA = "0x181D2B480")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task JHACDPGALPA(FMMFCOMCHNK errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CDMPHLNHBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NCFFFOCEFMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D13B40", Offset = "0x1D12F40", VA = "0x181D13B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D14030", Offset = "0x1D13430", VA = "0x181D14030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OAPBMDJKIGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public OAPBMDJKIGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D2EE90", Offset = "0x1D2E290", VA = "0x181D2EE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1D2F170", Offset = "0x1D2E570", VA = "0x181D2F170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NCFFFOCEFMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public OAPBMDJKIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B5F0", Offset = "0x1D2A9F0", VA = "0x181D2B5F0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task POCBIDBEJDJ(FMMFCOMCHNK errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IEGLICKAHKN BNAGPKGJABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<OHGBIJIBCPL> CLBPIJELCOL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private PINFCBGDJKA AJFLHONBNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D291A0", Offset = "0x1D285A0", VA = "0x181D291A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LELHOHFMKKF<HFFLFLDFDGK> JEHJLCINFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA1FBD0", Offset = "0xA1EFD0", VA = "0x180A1FBD0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(LELHOHFMKKF<HFFLFLDFDGK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA686D0", Offset = "0xA67AD0", VA = "0x180A686D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override LELHOHFMKKF<COHCNNIPOPA> CCBMPBIIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D29A90", Offset = "0x1D28E90", VA = "0x181D29A90", Slot = "19")]
		get
		{
			return default(LELHOHFMKKF<COHCNNIPOPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FCOJJJHKELG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D293E0", Offset = "0x1D287E0", VA = "0x181D293E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A000", Offset = "0x1D29400", VA = "0x181D2A000")]
	private NCFFFOCEFMK(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO, IEGLICKAHKN KFLIELNEOHM, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<HFFLFLDFDGK> MIPIBMCBIIC, bool KADGLPKMCDG, string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D27FD0", Offset = "0x1D273D0", VA = "0x181D27FD0")]
	public static NCFFFOCEFMK CPLKLKACALP(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO, IEGLICKAHKN EPJNNNGOOAO, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ, LELHOHFMKKF<HFFLFLDFDGK> MIPIBMCBIIC, bool KADGLPKMCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D29C30", Offset = "0x1D29030", VA = "0x181D29C30", Slot = "20")]
	protected override void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D28510", Offset = "0x1D27910", VA = "0x181D28510", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D27210", Offset = "0x1D26610", VA = "0x181D27210", Slot = "28")]
	public void ACHGOGAAAGM(OHGBIJIBCPL FJDJANCHANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D28CF0", Offset = "0x1D280F0", VA = "0x181D28CF0", Slot = "25")]
	public void HAJAJNJNJPO(MKNJDKFIAKM ADMGBDLBGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D27630", Offset = "0x1D26A30", VA = "0x181D27630", Slot = "26")]
	public void BOLJEDBAJIA(MKLINEGAEDM EJBONAHBANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D299B0", Offset = "0x1D28DB0", VA = "0x181D299B0", Slot = "22")]
	protected override void LICLKJFJCIO(JFPAGGOFBDK JANNHHPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D274C0", Offset = "0x1D268C0", VA = "0x181D274C0", Slot = "30")]
	public string BHDCGFONHHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D286D0", Offset = "0x1D27AD0", VA = "0x181D286D0", Slot = "27")]
	public string EEPHBEMLLFI(int AKAFCPJAPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D295E0", Offset = "0x1D289E0", VA = "0x181D295E0")]
	private void JEBAOPNEPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D29B60", Offset = "0x1D28F60", VA = "0x181D29B60", Slot = "29")]
	public void NHHIODGGOIO(OHGBIJIBCPL FJDJANCHANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D29E40", Offset = "0x1D29240", VA = "0x181D29E40")]
	private void PPJFBPLFGGL(bool ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D28A50", Offset = "0x1D27E50", VA = "0x181D28A50", Slot = "31")]
	[AsyncStateMachine(typeof(CDMPHLNHBJG))]
	public Task FOBDNCOBMFG(string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D283E0", Offset = "0x1D277E0", VA = "0x181D283E0")]
	public void DGPHNELBFAF(string ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D29810", Offset = "0x1D28C10", VA = "0x181D29810")]
	private void KCDLNOHCGHL(int ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA686D0", Offset = "0xA67AD0", VA = "0x180A686D0")]
	internal void FKIMOEPLLLF(LELHOHFMKKF<HFFLFLDFDGK> ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D28BA0", Offset = "0x1D27FA0", VA = "0x181D28BA0")]
	[CompilerGenerated]
	private bool GGCGALGBFPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D291C0", Offset = "0x1D285C0", VA = "0x181D291C0")]
	[CompilerGenerated]
	private bool ILPBGPMALAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D28B50", Offset = "0x1D27F50", VA = "0x181D28B50")]
	[CompilerGenerated]
	private int PJIGJEKMAKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D29AD0", Offset = "0x1D28ED0", VA = "0x181D29AD0")]
	[CompilerGenerated]
	private bool MKHPBBBHMAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D27370", Offset = "0x1D26770", VA = "0x181D27370")]
	[CompilerGenerated]
	private bool APFCBNDFLFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D29DF0", Offset = "0x1D291F0", VA = "0x181D29DF0")]
	[CompilerGenerated]
	private bool PIHPPFDBHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D272E0", Offset = "0x1D266E0", VA = "0x181D272E0")]
	[CompilerGenerated]
	private bool AMNIAHMKIEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D28B50", Offset = "0x1D27F50", VA = "0x181D28B50")]
	[CompilerGenerated]
	private int FONIOCMBGPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D290D0", Offset = "0x1D284D0", VA = "0x181D290D0")]
	[CompilerGenerated]
	private bool HIHGGDDAFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D28A00", Offset = "0x1D27E00", VA = "0x181D28A00")]
	[CompilerGenerated]
	private int EIMMKFFJJOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D28360", Offset = "0x1D27760", VA = "0x181D28360")]
	[CompilerGenerated]
	private void DGOEOJNCPGC(object ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D29310", Offset = "0x1D28710", VA = "0x181D29310")]
	[CompilerGenerated]
	private bool INKCNHGCICJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GKPAINMDPEO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class LDCMPMEGJLA<TNode> : JCDCCBADCIP<TNode> where TNode : notnull, CFAIJCLHDNA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct ALBMKBCDGEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LDCMPMEGJLA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x36DC110", Offset = "0x36DB510", VA = "0x1836DC110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x36DC4E0", Offset = "0x36DB8E0", VA = "0x1836DC4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct FFJPOMJINKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public LDCMPMEGJLA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LELHOHFMKKF<JJEPODHECPL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x363DD80", Offset = "0x363D180", VA = "0x18363DD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x363E150", Offset = "0x363D550", VA = "0x18363E150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool DMMFJBCGIAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override LELHOHFMKKF<JJEPODHECPL>? OJEBPAMFIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x3B65AF0", Offset = "0x3B64EF0", VA = "0x183B65AF0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3771DF0", Offset = "0x37711F0", VA = "0x183771DF0")]
		public LDCMPMEGJLA(DPOHHGLACDM JFEBJHGKJHE, TNode DKBEBHEBAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3B659D0", Offset = "0x3B64DD0", VA = "0x183B659D0", Slot = "94")]
		[AsyncStateMachine(typeof(LDCMPMEGJLA<>.ALBMKBCDGEH))]
		public override Task<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> LJKEFGCLKGE(string GFBABMFGHOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B656E0", Offset = "0x3B64AE0", VA = "0x183B656E0", Slot = "118")]
		public sealed override bool ECJMBGMIPNM(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B65930", Offset = "0x3B64D30", VA = "0x183B65930", Slot = "108")]
		protected sealed override bool LIAMDGMPEBD(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B65890", Offset = "0x3B64C90", VA = "0x183B65890", Slot = "109")]
		protected override bool FMIOIMNAEOG(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B65780", Offset = "0x3B64B80", VA = "0x183B65780", Slot = "95")]
		[AsyncStateMachine(typeof(LDCMPMEGJLA<>.FFJPOMJINKO))]
		public override Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> ENEFLBMBCFB(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class EHCKCGJINDL : HMEGHPJDOFK<BLNLFOJEMAH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C9A0", Offset = "0x1D1BDA0", VA = "0x181D1C9A0")]
		public EHCKCGJINDL(DPOHHGLACDM JFEBJHGKJHE, BLNLFOJEMAH DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class HMEGHPJDOFK<TNode> : JCDCCBADCIP<TNode> where TNode : notnull, HBDCKNNABDL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct AELLGAOMCIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public HMEGHPJDOFK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x36BBA90", Offset = "0x36BAE90", VA = "0x1836BBA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x36BBE00", Offset = "0x36BB200", VA = "0x1836BBE00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct HHOJIJGOBMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public HMEGHPJDOFK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public LELHOHFMKKF<JJEPODHECPL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3760040", Offset = "0x375F440", VA = "0x183760040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3760390", Offset = "0x375F790", VA = "0x183760390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override BKCFLNKEACJ<BBFMEDFDBAF>? NPFNAAOAHGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3771E10", Offset = "0x3771210", VA = "0x183771E10", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override LELHOHFMKKF<JJEPODHECPL>? OJEBPAMFIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3771E60", Offset = "0x3771260", VA = "0x183771E60", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3771DF0", Offset = "0x37711F0", VA = "0x183771DF0")]
		public HMEGHPJDOFK(DPOHHGLACDM JFEBJHGKJHE, TNode DKBEBHEBAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3771CD0", Offset = "0x37710D0", VA = "0x183771CD0", Slot = "94")]
		[AsyncStateMachine(typeof(HMEGHPJDOFK<>.AELLGAOMCIG))]
		public override Task<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> LJKEFGCLKGE(string GFBABMFGHOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x37719E0", Offset = "0x3770DE0", VA = "0x1837719E0", Slot = "118")]
		public sealed override bool ECJMBGMIPNM(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3771C30", Offset = "0x3771030", VA = "0x183771C30", Slot = "108")]
		protected sealed override bool LIAMDGMPEBD(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3771B90", Offset = "0x3770F90", VA = "0x183771B90", Slot = "109")]
		protected override bool FMIOIMNAEOG(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3771A80", Offset = "0x3770E80", VA = "0x183771A80", Slot = "95")]
		[AsyncStateMachine(typeof(HMEGHPJDOFK<>.HHOJIJGOBMJ))]
		public override Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> ENEFLBMBCFB(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class LMHKCGKJDOD : JCDCCBADCIP<LEOKDGDAGLI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9BF420", Offset = "0x9BE820", VA = "0x1809BF420", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D26C50", Offset = "0x1D26050", VA = "0x181D26C50")]
		public LMHKCGKJDOD(DPOHHGLACDM JFEBJHGKJHE, LEOKDGDAGLI DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class OJABDNHNBPC : HMEGHPJDOFK<CLMLDCIMGCE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool OMCMDGFJEHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool KIMGEHLKNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C300", Offset = "0x1D2B700", VA = "0x181D2C300", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8879C0", Offset = "0x886DC0", VA = "0x1808879C0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C2A0", Offset = "0x1D2B6A0", VA = "0x181D2C2A0")]
		public OJABDNHNBPC(DPOHHGLACDM JFEBJHGKJHE, CLMLDCIMGCE DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class PDJBHOOBLBE : JCDCCBADCIP<NHGODLGGPKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xFF5850", Offset = "0xFF4C50", VA = "0x180FF5850", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E1D0", Offset = "0x1D2D5D0", VA = "0x181D2E1D0")]
		public PDJBHOOBLBE(DPOHHGLACDM JFEBJHGKJHE, NHGODLGGPKG DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class MCLHNAPKCFO : JCDCCBADCIP<DPGPIJIMJHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x888CE0", Offset = "0x8880E0", VA = "0x180888CE0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1D26CB0", Offset = "0x1D260B0", VA = "0x181D26CB0")]
		public MCLHNAPKCFO(DPOHHGLACDM JFEBJHGKJHE, DPGPIJIMJHP DKBEBHEBAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "108")]
		protected override bool LIAMDGMPEBD(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class GIMCBFBPNEI : JCDCCBADCIP<DNNLNMKDPMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x89A600", Offset = "0x899A00", VA = "0x18089A600", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool IJIOCGONNKB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1D1FB20", Offset = "0x1D1EF20", VA = "0x181D1FB20", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected override bool ACGEONDLPII
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1FAC0", Offset = "0x1D1EEC0", VA = "0x181D1FAC0")]
		public GIMCBFBPNEI(DPOHHGLACDM JFEBJHGKJHE, DNNLNMKDPMN DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class ONPFCADOCAB : JCDCCBADCIP<GBKEJHIACEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x886610", Offset = "0x885A10", VA = "0x180886610", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool IJIOCGONNKB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C3A0", Offset = "0x1D2B7A0", VA = "0x181D2C3A0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool ACGEONDLPII
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C340", Offset = "0x1D2B740", VA = "0x181D2C340")]
		public ONPFCADOCAB(DPOHHGLACDM JFEBJHGKJHE, GBKEJHIACEB DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BEBAMBDANOA : LDCMPMEGJLA<HHCKNBIKLFK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x890130", Offset = "0x88F530", VA = "0x180890130", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1D134D0", Offset = "0x1D128D0", VA = "0x181D134D0")]
		public BEBAMBDANOA(DPOHHGLACDM JFEBJHGKJHE, HHCKNBIKLFK DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class JCDCCBADCIP<TNode> : DGFNNJBKMFJ, IDisposable where TNode : notnull, HAHFCMAIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class GMIKEPJFLFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public JCDCCBADCIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public DPOHHGLACDM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GMIKEPJFLFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3723D20", Offset = "0x3723120", VA = "0x183723D20")]
			internal DPLKBKPDCBA KKIMMHMGGIP(EHJIPIABNOC portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct NBALLKDJLLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public JCDCCBADCIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public LOFPEMGPBIF? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public AOAOMEHBOEB? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3E83160", Offset = "0x3E82560", VA = "0x183E83160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3E83400", Offset = "0x3E82800", VA = "0x183E83400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct LIFCMBBIGJG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public JCDCCBADCIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3BCAED0", Offset = "0x3BCA2D0", VA = "0x183BCAED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3BCB130", Offset = "0x3BCA530", VA = "0x183BCB130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DPOHHGLACDM AHLCIJFCKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private MDCELMGCHKK<JJEPODHECPL, DPLKBKPDCBA> PAPMPIIFOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MDCELMGCHKK<JJEPODHECPL, FBCMPMMEFNE> BLFJHJMDFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<Action> OIGDCMFBJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<LELHOHFMKKF<JJEPODHECPL>>? ELDHOJJCEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CompilerGenerated]
		private Action<LELHOHFMKKF<JJEPODHECPL>, FBCMPMMEFNE>? BDGCBOLCLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<LELHOHFMKKF<JJEPODHECPL>, LELHOHFMKKF<JJEPODHECPL>>? ADNPFLNJKDP;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected TNode BJAACIJNJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public BKCFLNKEACJ<ENDKBNLNALP> AIGFOAAHCFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xE47380", Offset = "0xE46780", VA = "0x180E47380", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(BKCFLNKEACJ<ENDKBNLNALP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public object CGKIHHOMJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x332B080", Offset = "0x332A480", VA = "0x18332B080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual bool OJHDIJJOCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int BLNABIPFJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x39C5A50", Offset = "0x39C4E50", VA = "0x1839C5A50", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public EIIPBCOJFEM MCPPLLLDGFA
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x39C5A00", Offset = "0x39C4E00", VA = "0x1839C5A00", Slot = "9")]
			get
			{
				return default(EIIPBCOJFEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FCDHJADLLAP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x39C5E90", Offset = "0x39C5290", VA = "0x1839C5E90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual bool ACGEONDLPII
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public LELHOHFMKKF<EELOPCKFABG> DDOKKECOGII
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7AF1C0", Offset = "0x7AE5C0", VA = "0x1807AF1C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(LELHOHFMKKF<EELOPCKFABG>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD06CE0", Offset = "0xD060E0", VA = "0x180D06CE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool IJIOCGONNKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool OMCMDGFJEHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual HEODCHMMMBN BOELNGELLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x87BE90", Offset = "0x87B290", VA = "0x18087BE90", Slot = "87")]
			get
			{
				return default(HEODCHMMMBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool PKFAEPAIFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x39C5820", Offset = "0x39C4C20", VA = "0x1839C5820", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool FDLHGBPMHEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x39C5870", Offset = "0x39C4C70", VA = "0x1839C5870", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool GAHFJNFEJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x39C58C0", Offset = "0x39C4CC0", VA = "0x1839C58C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int FEOGDFODEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x39C5CE0", Offset = "0x39C50E0", VA = "0x1839C5CE0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool AEMOHJENELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x39C5C00", Offset = "0x39C5000", VA = "0x1839C5C00", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string FGPMJICOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x39C5B10", Offset = "0x39C4F10", VA = "0x1839C5B10", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CHNGDLNFBEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x39C5960", Offset = "0x39C4D60", VA = "0x1839C5960", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool LCBOJAPIMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xBA4FD0", Offset = "0xBA43D0", VA = "0x180BA4FD0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xBC15C0", Offset = "0xBC09C0", VA = "0x180BC15C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool KDKJKAGENPG
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool LOCNNKBIJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x39C5910", Offset = "0x39C4D10", VA = "0x1839C5910", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool JGOHGCDMHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x39C5B50", Offset = "0x39C4F50", VA = "0x1839C5B50", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public LOFPEMGPBIF PEDCHEEBCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x39C5C40", Offset = "0x39C5040", VA = "0x1839C5C40", Slot = "27")]
			get
			{
				return default(LOFPEMGPBIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public AOAOMEHBOEB IFBEDGFGEHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x39C5C90", Offset = "0x39C5090", VA = "0x1839C5C90", Slot = "29")]
			get
			{
				return default(AOAOMEHBOEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool NPHJBIBCKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual EMMMIDAJPEH? LKDGFHLEJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual LNNOFJNIGEL? NOIAAFAABJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual IEnumerable<BKCFLNKEACJ<FFAKLMOHHBO>>? JPGCFHIDBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "106")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool BJMLLLIMHIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x39C59B0", Offset = "0x39C4DB0", VA = "0x1839C59B0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public BKCFLNKEACJ<BBFMEDFDBAF> EDCMHGHOPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x39C5A90", Offset = "0x39C4E90", VA = "0x1839C5A90", Slot = "55")]
			get
			{
				return default(BKCFLNKEACJ<BBFMEDFDBAF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool DMMFJBCGIAM
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual BKCFLNKEACJ<BBFMEDFDBAF>? NPFNAAOAHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x39C5AE0", Offset = "0x39C4EE0", VA = "0x1839C5AE0", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool KIMGEHLKNGN
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool ICNPGOPNADP
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x39C5BA0", Offset = "0x39C4FA0", VA = "0x1839C5BA0", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7A67F0", Offset = "0x7A5BF0", VA = "0x1807A67F0", Slot = "62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7A67B0", Offset = "0x7A5BB0", VA = "0x1807A67B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public BKCFLNKEACJ<FFAKLMOHHBO> KOCONPECOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x39C5D20", Offset = "0x39C5120", VA = "0x1839C5D20", Slot = "61")]
			get
			{
				return default(BKCFLNKEACJ<FFAKLMOHHBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public BKCFLNKEACJ<FFAKLMOHHBO>? OGJEFEDGLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x39C5D70", Offset = "0x39C5170", VA = "0x1839C5D70", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public JNCDGINEFMI<JJEPODHECPL, FBCMPMMEFNE> BLFGLBADIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x39C5E50", Offset = "0x39C5250", VA = "0x1839C5E50", Slot = "63")]
			get
			{
				return default(JNCDGINEFMI<JJEPODHECPL, FBCMPMMEFNE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual LELHOHFMKKF<JJEPODHECPL>? OJEBPAMFIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PMAIBDCAOMI
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x39C31A0", Offset = "0x39C25A0", VA = "0x1839C31A0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x39C20B0", Offset = "0x39C14B0", VA = "0x1839C20B0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OENAKDLPDKG KDENDAFLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x39C2460", Offset = "0x39C1860", VA = "0x1839C2460", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x39C5440", Offset = "0x39C4840", VA = "0x1839C5440", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OGGDGDCFBFO JPJBFOFCGDG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x39C21B0", Offset = "0x39C15B0", VA = "0x1839C21B0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x39C3100", Offset = "0x39C2500", VA = "0x1839C3100", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CANNLIBCMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x39C3580", Offset = "0x39C2980", VA = "0x1839C3580", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x39C4C90", Offset = "0x39C4090", VA = "0x1839C4C90", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action COIIBNHHNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x39C4BF0", Offset = "0x39C3FF0", VA = "0x1839C4BF0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x39C4CF0", Offset = "0x39C40F0", VA = "0x1839C4CF0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LELHOHFMKKF<JJEPODHECPL>, FBCMPMMEFNE> EBCEBOJIANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x39C23B0", Offset = "0x39C17B0", VA = "0x1839C23B0", Slot = "65")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x39C1BD0", Offset = "0x39C0FD0", VA = "0x1839C1BD0", Slot = "66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<LELHOHFMKKF<JJEPODHECPL>, FBCMPMMEFNE> JDJNNHDKKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x39C42C0", Offset = "0x39C36C0", VA = "0x1839C42C0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x39C4100", Offset = "0x39C3500", VA = "0x1839C4100", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<LELHOHFMKKF<JJEPODHECPL>> PLKLMKJPEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x39C3930", Offset = "0x39C2D30", VA = "0x1839C3930", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x39C3680", Offset = "0x39C2A80", VA = "0x1839C3680", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<LELHOHFMKKF<JJEPODHECPL>, LELHOHFMKKF<JJEPODHECPL>> IPLCKPIHBPF
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x39C4B30", Offset = "0x39C3F30", VA = "0x1839C4B30", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x39C22A0", Offset = "0x39C16A0", VA = "0x1839C22A0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<LELHOHFMKKF<JJEPODHECPL>, FBCMPMMEFNE> NIBAGEDHBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39C2F70", Offset = "0x39C2370", VA = "0x1839C2F70", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x39C3870", Offset = "0x39C2C70", VA = "0x1839C3870", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x39C54E0", Offset = "0x39C48E0", VA = "0x1839C54E0")]
		[JOOFHEAGKPO("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[JOOFHEAGKPO("Need to handle `Name` better.")]
		public JCDCCBADCIP(DPOHHGLACDM JFEBJHGKJHE, TNode DKBEBHEBAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x39C4380", Offset = "0x39C3780", VA = "0x1839C4380", Slot = "79")]
		protected virtual void OBMDJKKOMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x39C26B0", Offset = "0x39C1AB0", VA = "0x1839C26B0", Slot = "80")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x39C2F20", Offset = "0x39C2320", VA = "0x1839C2F20", Slot = "82")]
		public virtual void EEGFPMDELPM(int NFICNDFIPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x39C25D0", Offset = "0x39C19D0", VA = "0x1839C25D0")]
		public bool DKMFDIBAPHM([In] LOFPEMGPBIF ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x39C2150", Offset = "0x39C1550", VA = "0x1839C2150")]
		public bool BNCOLLDFPEI([In] AOAOMEHBOEB ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x39C53F0", Offset = "0x39C47F0", VA = "0x1839C53F0", Slot = "90")]
		public virtual void PKNJHBCCMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x39C33B0", Offset = "0x39C27B0", VA = "0x1839C33B0", Slot = "32")]
		[AsyncStateMachine(typeof(JCDCCBADCIP<>.NBALLKDJLLB))]
		public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> IBCHNADNGEM(LOFPEMGPBIF? IPLJDJCHMDC, AOAOMEHBOEB? BHCBAPBJJED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "91")]
		public virtual void CPFOCDNNFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "92")]
		public virtual void OHNOFJNHOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "93")]
		public virtual void EKFDGEKHFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1471250", Offset = "0x1470650", VA = "0x181471250")]
		protected void CMEIFKAGIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x11963D0", Offset = "0x11957D0", VA = "0x1811963D0")]
		protected void FNMHCKPPPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1174380", Offset = "0x1173780", VA = "0x181174380")]
		private void KPFEIPBOHJO([In] AOAOMEHBOEB IKFFGJBHBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x39C3AA0", Offset = "0x39C2EA0", VA = "0x1839C3AA0", Slot = "94")]
		public virtual Task<IAPKJCHKLLD<LELHOHFMKKF<JJEPODHECPL>, HDKPGPNEBBO>> LJKEFGCLKGE(string GFBABMFGHOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x39C3030", Offset = "0x39C2430", VA = "0x1839C3030", Slot = "95")]
		public virtual Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> ENEFLBMBCFB(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x39C2630", Offset = "0x39C1A30", VA = "0x1839C2630", Slot = "96")]
		public virtual void DLAMLGHPKHM(LELHOHFMKKF<JJEPODHECPL> AHDNEIKOMIB, LELHOHFMKKF<JJEPODHECPL> JILDGEDOLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x39C3CC0", Offset = "0x39C30C0", VA = "0x1839C3CC0", Slot = "97")]
		public virtual IEnumerable<LOAMOHDBOAD> LPHPOJEHKAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x39C39F0", Offset = "0x39C2DF0", VA = "0x1839C39F0", Slot = "98")]
		public IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO> LHNEFIOGLGM(string MFENIHMNHOB)
		{
			return default(IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x39C3B70", Offset = "0x39C2F70", VA = "0x1839C3B70", Slot = "46")]
		public bool LODJGPANMJJ([Out] Guid KGDEKIEJOEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x39C4AE0", Offset = "0x39C3EE0", VA = "0x1839C4AE0", Slot = "99")]
		public virtual bool OPKJEAHFKLD([In] Guid NGLJABNBABA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x39C2360", Offset = "0x39C1760", VA = "0x1839C2360", Slot = "100")]
		public virtual void CJNCIGMNEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "101")]
		public virtual void ADMFFMEANCK(bool JNJCOOOGANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "102")]
		public virtual EMANOKPLKME LGFMEFCHAKJ([In] DOOPPIKEEPM OLNLHGOMGEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x39C41C0", Offset = "0x39C35C0", VA = "0x1839C41C0")]
		protected void MOHNNFFGDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "107")]
		protected virtual void GHALFIBGIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x39C3A70", Offset = "0x39C2E70", VA = "0x1839C3A70", Slot = "108")]
		protected virtual bool LIAMDGMPEBD(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "109")]
		protected virtual bool FMIOIMNAEOG(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "116")]
		protected virtual void CJNJANACLML(NEECKPLCFEG KBHLJPNNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "117")]
		protected virtual void ODOIBFONCAD(NEECKPLCFEG EHBEALIGLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x39C2250", Offset = "0x39C1650", VA = "0x1839C2250", Slot = "75")]
		public void BOLJEDBAJIA(NEECKPLCFEG EHBEALIGLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x39C3790", Offset = "0x39C2B90", VA = "0x1839C3790", Slot = "76")]
		public DFENHDHDBNN JIOGCDGPNPL()
		{
			return default(DFENHDHDBNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "118")]
		public virtual bool ECJMBGMIPNM(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x39C3390", Offset = "0x39C2790", VA = "0x1839C3390")]
		private void HMCBCKMJBKA([In] LOFPEMGPBIF BEBKKMFGLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x39C1AD0", Offset = "0x39C0ED0", VA = "0x1839C1AD0")]
		private void AIDFHCAACLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x39C4D90", Offset = "0x39C4190", VA = "0x1839C4D90")]
		private void PHJEMKJJDBH(int OPDOAGMIDBI, EHJIPIABNOC FGANFANHPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x39C3740", Offset = "0x39C2B40", VA = "0x1839C3740")]
		private void IKMOGLMLPHP(int AHDNEIKOMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x39C52B0", Offset = "0x39C46B0", VA = "0x1839C52B0")]
		private void PINBCHEAPCK(int AHDNEIKOMIB, EHJIPIABNOC GPGKJPFGNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x39C3D50", Offset = "0x39C3150", VA = "0x1839C3D50")]
		private void MAFBLNGHAJA(int JLGMIDHHFAF, int PLBOKKEMOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x39C2570", Offset = "0x39C1970", VA = "0x1839C2570")]
		private void DHLFEOBDNJH(int JLGMIDHHFAF, int PLBOKKEMOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x39C3630", Offset = "0x39C2A30", VA = "0x1839C3630")]
		private void IIMABBMMACE(int AHDNEIKOMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x39C1C80", Offset = "0x39C1080", VA = "0x1839C1C80")]
		private void ALCADCBKBEL(int OPDOAGMIDBI, EHJIPIABNOC FGANFANHPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x39C3500", Offset = "0x39C2900", VA = "0x1839C3500")]
		private void ICKAFHOAMGF(int AHDNEIKOMIB, EHJIPIABNOC GPGKJPFGNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39C3240", Offset = "0x39C2640", VA = "0x1839C3240", Slot = "119")]
		[AsyncStateMachine(typeof(JCDCCBADCIP<>.LIFCMBBIGJG))]
		public virtual Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> GEHBIIIEDLD(string MFENIHMNHOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x39C4A70", Offset = "0x39C3E70", VA = "0x1839C4A70", Slot = "53")]
		private void OFKFNJOGMHE(object HCJINHHKFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39C2500", Offset = "0x39C1900", VA = "0x1839C2500", Slot = "54")]
		private void DGGBJMLLFOI(object HCJINHHKFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39C2680", Offset = "0x39C1A80", VA = "0x1839C2680", Slot = "28")]
		private bool DOJKCCIEFMG([In] LOFPEMGPBIF ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39C3360", Offset = "0x39C2760", VA = "0x1839C3360", Slot = "30")]
		private bool HBKBAONFIPE([In] AOAOMEHBOEB ANJCCKHBJJO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class KEANOEGLNHG : LDCMPMEGJLA<IGKMKIMOGKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA2120", Offset = "0xAA1520", VA = "0x180AA2120", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1D26750", Offset = "0x1D25B50", VA = "0x181D26750")]
		public KEANOEGLNHG(DPOHHGLACDM JFEBJHGKJHE, IGKMKIMOGKB DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class LACEAIPAAOF : HMEGHPJDOFK<AHKENHMMJHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1D26B90", Offset = "0x1D25F90", VA = "0x181D26B90")]
		public LACEAIPAAOF(DPOHHGLACDM JFEBJHGKJHE, AHKENHMMJHP DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class ENBPCIAJGKF : JCDCCBADCIP<HHPEHBFJDHL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x854730", Offset = "0x853B30", VA = "0x180854730", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D2A0", Offset = "0x1D1C6A0", VA = "0x181D1D2A0")]
		public ENBPCIAJGKF(DPOHHGLACDM JFEBJHGKJHE, HHPEHBFJDHL DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class NICFLOJEGAB : HMEGHPJDOFK<HFKDIDLGGJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A650", Offset = "0x1D29A50", VA = "0x181D2A650")]
		public NICFLOJEGAB(DPOHHGLACDM JFEBJHGKJHE, HFKDIDLGGJB DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class LIPENAAHEPO : HMEGHPJDOFK<IHDELFFEONA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1D26BF0", Offset = "0x1D25FF0", VA = "0x181D26BF0")]
		public LIPENAAHEPO(DPOHHGLACDM JFEBJHGKJHE, IHDELFFEONA DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class ICGMGHGLNID : JCDCCBADCIP<GENBLCPGEFD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x91A920", Offset = "0x919D20", VA = "0x18091A920", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1D22B70", Offset = "0x1D21F70", VA = "0x181D22B70")]
		public ICGMGHGLNID(DPOHHGLACDM JFEBJHGKJHE, GENBLCPGEFD DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class JHELEBCEPCO : JCDCCBADCIP<HMIBHFHJLDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected override bool ACGEONDLPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D25D80", Offset = "0x1D25180", VA = "0x181D25D80")]
		public JHELEBCEPCO(DPOHHGLACDM JFEBJHGKJHE, HMIBHFHJLDP DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class ALICCDIPDBN : JCDCCBADCIP<OAKBHADBPOF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x888320", Offset = "0x887720", VA = "0x180888320", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1D12E50", Offset = "0x1D12250", VA = "0x181D12E50")]
		public ALICCDIPDBN(DPOHHGLACDM JFEBJHGKJHE, OAKBHADBPOF DKBEBHEBAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FF80", Offset = "0x1D1F380", VA = "0x181D1FF80")]
	internal static DGFNNJBKMFJ CPLKLKACALP(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class JCNGAEDEAOI : GDOMCFJMAOO, JNFABKKHCOK, GBEKEIPKALF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public LELHOHFMKKF<PEMACHABAND> JGAJPOGBGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xD08DF0", Offset = "0xD081F0", VA = "0x180D08DF0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(LELHOHFMKKF<PEMACHABAND>);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xD08AF0", Offset = "0xD07EF0", VA = "0x180D08AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public override LELHOHFMKKF<COHCNNIPOPA> CCBMPBIIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1D25CF0", Offset = "0x1D250F0", VA = "0x181D25CF0", Slot = "19")]
		get
		{
			return default(LELHOHFMKKF<COHCNNIPOPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1D25D30", Offset = "0x1D25130", VA = "0x181D25D30")]
	private JCNGAEDEAOI(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO, DCGMHMPBHBE GDIFJHAOPOO, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<PEMACHABAND> KPOALPLEIEO, bool KADGLPKMCDG, string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1D259D0", Offset = "0x1D24DD0", VA = "0x181D259D0")]
	public static JCNGAEDEAOI CPLKLKACALP(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO, DCGMHMPBHBE NCFFHCMILBH, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH, LELHOHFMKKF<PEMACHABAND> KPOALPLEIEO, bool KADGLPKMCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0xD08AF0", Offset = "0xD07EF0", VA = "0x180D08AF0")]
	internal void BPPPPMKIJCJ(LELHOHFMKKF<PEMACHABAND> ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GDOMCFJMAOO : GBEKEIPKALF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct HABHGDLHLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private PICLEBLECGC? LJPJLBMCLAG;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D210A0", Offset = "0x1D204A0", VA = "0x181D210A0")]
		public void BILLODBOEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D210B0", Offset = "0x1D204B0", VA = "0x181D210B0")]
		public PICLEBLECGC PIHGFAFBIMP(GDOMCFJMAOO IEDDIHHOLAN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly HAHFCMAIFAE LCAODFANHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private HABHGDLHLHG CMNPMAEECIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly AADDKFDOADM MJLDEBGBGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<CIDNBHDFEPF> KGPHLLDKACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<BIFMLKDMOLJ> KCCNKCKCKLJ;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<StaticEdge> OOCOMPOLGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F3F0", Offset = "0x1D1E7F0", VA = "0x181D1F3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DisplayKind LAJLICEOILD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1C0", Offset = "0x7AE5C0", VA = "0x1807AF1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BKCFLNKEACJ<BBFMEDFDBAF> EDCMHGHOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F000", Offset = "0x1D1E400", VA = "0x181D1F000", Slot = "6")]
		get
		{
			return default(BKCFLNKEACJ<BBFMEDFDBAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NJKNAPIEGPP MDDBICKGDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A37F0", Offset = "0x9A2BF0", VA = "0x1809A37F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KFOBHPACDPA IMCFAFGIPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1E7E0", Offset = "0x1D1DBE0", VA = "0x181D1E7E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	protected PICLEBLECGC IHLLFJNKNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D1E7E0", Offset = "0x1D1DBE0", VA = "0x181D1E7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PortImage MLPFOPDMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D1EED0", Offset = "0x1D1E2D0", VA = "0x181D1EED0", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x79E7C0", Offset = "0x79DBC0", VA = "0x18079E7C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x79E680", Offset = "0x79DA80", VA = "0x18079E680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public BKCFLNKEACJ<FFAKLMOHHBO> KOCONPECOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F090", Offset = "0x1D1E490", VA = "0x181D1F090", Slot = "8")]
		get
		{
			return default(BKCFLNKEACJ<FFAKLMOHHBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public LELHOHFMKKF<JJEPODHECPL> OGCNKFEHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x871590", Offset = "0x870990", VA = "0x180871590", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(LELHOHFMKKF<JJEPODHECPL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1769C90", Offset = "0x1769090", VA = "0x181769C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public abstract LELHOHFMKKF<COHCNNIPOPA> CCBMPBIIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F580", Offset = "0x1D1E980", VA = "0x181D1F580")]
	protected GDOMCFJMAOO(DPOHHGLACDM JFEBJHGKJHE, HAHFCMAIFAE DKBEBHEBAJO, AADDKFDOADM FAPNKFCFBMJ, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, bool KADGLPKMCDG, string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F0B0", Offset = "0x1D1E4B0", VA = "0x181D1F0B0", Slot = "20")]
	protected virtual void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E4C0", Offset = "0x1D1D8C0", VA = "0x181D1E4C0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D1EE10", Offset = "0x1D1E210", VA = "0x181D1EE10", Slot = "13")]
	public void IFGFJPPADFJ(CIDNBHDFEPF PBLAGMGHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F030", Offset = "0x1D1E430", VA = "0x181D1F030", Slot = "14")]
	public void NILLOIEHAON(BIFMLKDMOLJ PBLAGMGHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E880", Offset = "0x1D1DC80", VA = "0x181D1E880", Slot = "15")]
	public void HCDGEGFNHBG(JFPAGGOFBDK JANNHHPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D1EE70", Offset = "0x1D1E270", VA = "0x181D1EE70", Slot = "22")]
	protected virtual void LICLKJFJCIO(JFPAGGOFBDK JANNHHPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F200", Offset = "0x1D1E600", VA = "0x181D1F200")]
	private void OGBKBBMNBGN(bool OIGNJCHPDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E310", Offset = "0x1D1D710", VA = "0x181D1E310")]
	private void DGAOHNLIJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E630", Offset = "0x1D1DA30", VA = "0x181D1E630")]
	private void FLNEAOOKPDP([In] DPGPEFBLODB LHLBHNJFCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E2B0", Offset = "0x1D1D6B0", VA = "0x181D1E2B0", Slot = "16")]
	public void BCOCAMFIGDA(CIDNBHDFEPF PBLAGMGHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F390", Offset = "0x1D1E790", VA = "0x181D1F390", Slot = "17")]
	public void OGLOGEPOEEH(BIFMLKDMOLJ PBLAGMGHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x79E680", Offset = "0x79DA80", VA = "0x18079E680")]
	internal void MEIICIINHFA(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D1E610", Offset = "0x1D1DA10", VA = "0x181D1E610")]
	internal void EDDOHODDKKC(GCJGLFAPCCC MLLANHDPJEE, NJKNAPIEGPP FICJMFBEBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1769C90", Offset = "0x1769090", VA = "0x181769C90")]
	internal void LMIFLKBEIJA(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class DPLKBKPDCBA : FBCMPMMEFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HPFHKGOOILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DPOHHGLACDM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public HAHFCMAIFAE node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public LELHOHFMKKF<JJEPODHECPL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public HPFHKGOOILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1D22740", Offset = "0x1D21B40", VA = "0x181D22740")]
		internal NCFFFOCEFMK MMBOLMGALOG((int PortDescIndex, int PortIndex, IEGLICKAHKN InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1D226C0", Offset = "0x1D21AC0", VA = "0x181D226C0")]
		internal JCNGAEDEAOI JHKKBJJHCPO(DCGMHMPBHBE i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct DHECEJNEACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1D147A0", Offset = "0x1D13BA0", VA = "0x181D147A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1D14C00", Offset = "0x1D14000", VA = "0x181D14C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct GCIDEAODJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public LELHOHFMKKF<AKAFBBFLHOC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DEF0", Offset = "0x1D1D2F0", VA = "0x181D1DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D1E240", Offset = "0x1D1D640", VA = "0x181D1E240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct AIHKOEFGKCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public LELHOHFMKKF<DFDPMBCLKMJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1D12A90", Offset = "0x1D11E90", VA = "0x181D12A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1D12DE0", Offset = "0x1D121E0", VA = "0x181D12DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct EKPDKEDOBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public LELHOHFMKKF<AKAFBBFLHOC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LELHOHFMKKF<AKAFBBFLHOC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CEE0", Offset = "0x1D1C2E0", VA = "0x181D1CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D230", Offset = "0x1D1C630", VA = "0x181D1D230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct CBMCMGOCAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public LELHOHFMKKF<DFDPMBCLKMJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LELHOHFMKKF<DFDPMBCLKMJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1D13780", Offset = "0x1D12B80", VA = "0x181D13780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D13AD0", Offset = "0x1D12ED0", VA = "0x181D13AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct EHDAMKKLPEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CA00", Offset = "0x1D1BE00", VA = "0x181D1CA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CE70", Offset = "0x1D1C270", VA = "0x181D1CE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct DIHCNNGNAGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D14C70", Offset = "0x1D14070", VA = "0x181D14C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1D14FC0", Offset = "0x1D143C0", VA = "0x181D14FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct IPPNLGHEANA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public LELHOHFMKKF<AKAFBBFLHOC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1D25610", Offset = "0x1D24A10", VA = "0x181D25610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D25960", Offset = "0x1D24D60", VA = "0x181D25960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct IKDILPGACNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public LELHOHFMKKF<DFDPMBCLKMJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D22BD0", Offset = "0x1D21FD0", VA = "0x181D22BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D22F20", Offset = "0x1D22320", VA = "0x181D22F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct GMCCEBNGJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public EIMNJMAGOBP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public LELHOHFMKKF<AKAFBBFLHOC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D20CA0", Offset = "0x1D200A0", VA = "0x181D20CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D21030", Offset = "0x1D20430", VA = "0x181D21030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct NDEMBKIIKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public DPLKBKPDCBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public EIMNJMAGOBP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public LELHOHFMKKF<DFDPMBCLKMJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private FMMFCOMCHNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A100", Offset = "0x1D29500", VA = "0x181D2A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A490", Offset = "0x1D29890", VA = "0x181D2A490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly bool EJDEDDFBHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool KAHIGKFHHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JNCDGINEFMI<HFFLFLDFDGK, NCFFFOCEFMK> MGAKJPAKPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JNCDGINEFMI<HFFLFLDFDGK, PBJDPJGEOOI> CINLCCFNDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly HAHFCMAIFAE LCAODFANHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JNCDGINEFMI<PEMACHABAND, JCNGAEDEAOI> BPDHAMJMEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JNCDGINEFMI<PEMACHABAND, JNFABKKHCOK> EGKGINAMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private string? KJDNIKHEGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly EHJIPIABNOC OLBCILDKBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private LELHOHFMKKF<JJEPODHECPL> JKHMNHMAIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[CompilerGenerated]
	private Action? OBDBLLPBDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[CompilerGenerated]
	private Action? DAKPLBLDAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? EEJGFGMIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[CompilerGenerated]
	private Action<LELHOHFMKKF<HFFLFLDFDGK>>? CAMKJCPHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[CompilerGenerated]
	private Action<LELHOHFMKKF<PEMACHABAND>>? LKLNFPBEIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[CompilerGenerated]
	private FBCMPMMEFNE.CFLNKMCACON? IJJFBFDPLJN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool FICFLHPEEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D172B0", Offset = "0x1D166B0", VA = "0x181D172B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool MINBDFJMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D19710", Offset = "0x1D18B10", VA = "0x181D19710", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool INEFOFELPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D16C60", Offset = "0x1D16060", VA = "0x181D16C60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public BKCFLNKEACJ<BBFMEDFDBAF> EDCMHGHOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D190F0", Offset = "0x1D184F0", VA = "0x181D190F0", Slot = "7")]
		get
		{
			return default(BKCFLNKEACJ<BBFMEDFDBAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool KPLEAHDDAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D17230", Offset = "0x1D16630", VA = "0x181D17230", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JNCDGINEFMI<HFFLFLDFDGK, PBJDPJGEOOI> LPNIECGEGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "9")]
		get
		{
			return default(JNCDGINEFMI<HFFLFLDFDGK, PBJDPJGEOOI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A3D0", Offset = "0x1D197D0", VA = "0x181D1A3D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public BKCFLNKEACJ<FFAKLMOHHBO> KOCONPECOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1D19C00", Offset = "0x1D19000", VA = "0x181D19C00", Slot = "11")]
		get
		{
			return default(BKCFLNKEACJ<FFAKLMOHHBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JNCDGINEFMI<PEMACHABAND, JNFABKKHCOK> KBAKOFJGELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x79E7C0", Offset = "0x79DBC0", VA = "0x18079E7C0", Slot = "12")]
		get
		{
			return default(JNCDGINEFMI<PEMACHABAND, JNFABKKHCOK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public LELHOHFMKKF<JJEPODHECPL> OGCNKFEHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCC0", Offset = "0x9AD0C0", VA = "0x1809ADCC0", Slot = "13")]
		get
		{
			return default(LELHOHFMKKF<JJEPODHECPL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? ODFFJHEDPON
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D17A80", Offset = "0x1D16E80", VA = "0x181D17A80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D19980", Offset = "0x1D18D80", VA = "0x181D19980", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? JLKFMKPIGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D16AA0", Offset = "0x1D15EA0", VA = "0x181D16AA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D198D0", Offset = "0x1D18CD0", VA = "0x181D198D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LELHOHFMKKF<HFFLFLDFDGK?>, LELHOHFMKKF<HFFLFLDFDGK?>>? AANOIAJALEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D19B40", Offset = "0x1D18F40", VA = "0x181D19B40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D194F0", Offset = "0x1D188F0", VA = "0x181D194F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<LELHOHFMKKF<PEMACHABAND?>, LELHOHFMKKF<PEMACHABAND?>>? EIEPNOMJDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D19810", Offset = "0x1D18C10", VA = "0x181D19810", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D19750", Offset = "0x1D18B50", VA = "0x181D19750", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<LELHOHFMKKF<HFFLFLDFDGK?>, PBJDPJGEOOI?>? HPOEMLMOHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D156A0", Offset = "0x1D14AA0", VA = "0x181D156A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D16F30", Offset = "0x1D16330", VA = "0x181D16F30", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<LELHOHFMKKF<HFFLFLDFDGK?>>? PFLNJKDGPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D19030", Offset = "0x1D18430", VA = "0x181D19030", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D18B10", Offset = "0x1D17F10", VA = "0x181D18B10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<LELHOHFMKKF<HFFLFLDFDGK?>, PBJDPJGEOOI?>? NCBMGGCLEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D15760", Offset = "0x1D14B60", VA = "0x181D15760", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D154B0", Offset = "0x1D148B0", VA = "0x181D154B0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LELHOHFMKKF<PEMACHABAND?>, JNFABKKHCOK?>? PAMGGLNJKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D18F70", Offset = "0x1D18370", VA = "0x181D18F70", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D16E70", Offset = "0x1D16270", VA = "0x181D16E70", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LELHOHFMKKF<PEMACHABAND?>>? JPBEGHNPALM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D15EE0", Offset = "0x1D152E0", VA = "0x181D15EE0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D179C0", Offset = "0x1D16DC0", VA = "0x181D179C0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LELHOHFMKKF<PEMACHABAND?>, JNFABKKHCOK?>? FIEMGDPKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D153F0", Offset = "0x1D147F0", VA = "0x181D153F0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A7A0", Offset = "0x1D19BA0", VA = "0x181D1A7A0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D1AE30", Offset = "0x1D1A230", VA = "0x181D1AE30")]
	private DPLKBKPDCBA(bool KADGLPKMCDG, DPOHHGLACDM JFEBJHGKJHE, bool NLLOPJIJFHA, JNCDGINEFMI<HFFLFLDFDGK, NCFFFOCEFMK> EAELCGHJPDI, JNCDGINEFMI<HFFLFLDFDGK, PBJDPJGEOOI> OFMBFKHDLOH, HAHFCMAIFAE DKBEBHEBAJO, JNCDGINEFMI<PEMACHABAND, JCNGAEDEAOI> PHGKKOHPNNN, JNCDGINEFMI<PEMACHABAND, JNFABKKHCOK> CDFOBPIMNDM, string? EDHONFJNJOA, EHJIPIABNOC FGANFANHPDP, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D15990", Offset = "0x1D14D90", VA = "0x181D15990")]
	public static DPLKBKPDCBA CPLKLKACALP(bool KADGLPKMCDG, DPOHHGLACDM JFEBJHGKJHE, bool NLLOPJIJFHA, HAHFCMAIFAE DKBEBHEBAJO, EHJIPIABNOC FGANFANHPDP, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D19C20", Offset = "0x1D19020", VA = "0x181D19C20")]
	private void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D15FA0", Offset = "0x1D153A0", VA = "0x181D15FA0", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D18E30", Offset = "0x1D18230", VA = "0x181D18E30", Slot = "34")]
	[AsyncStateMachine(typeof(DHECEJNEACO))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? KIOMHLMBOEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D1AC00", Offset = "0x1D1A000", VA = "0x181D1AC00")]
	private (FHKPKFGEEML?, int)? PDHBCJIPPCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1D18A20", Offset = "0x1D17E20", VA = "0x181D18A20")]
	private void KCCDOJBLBPO(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x11963D0", Offset = "0x11957D0", VA = "0x1811963D0")]
	private void HEGACPJHDGC(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A860", Offset = "0x1D19C60", VA = "0x181D1A860")]
	private void PCPLEOBDJEM(int BGHJAFHAODE, int MGFBKBODMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x187CA20", Offset = "0x187BE20", VA = "0x18187CA20")]
	private void ADEHMOGAOJB(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D17B20", Offset = "0x1D16F20", VA = "0x181D17B20")]
	private void ICENLNFCMMH(int CLNIOJLOJAG, int BAMNODMDOON, IEGLICKAHKN IDHPCHNAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D15280", Offset = "0x1D14680", VA = "0x181D15280")]
	private void ACGBMMELJCF(int OIGNJCHPDMC, int BAMNODMDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D195B0", Offset = "0x1D189B0", VA = "0x181D195B0")]
	private void MDIHNEDJALJ(int OIGNJCHPDMC, int BAMNODMDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D18050", Offset = "0x1D17450", VA = "0x181D18050")]
	private void IDPHNHOJBPF(int CLNIOJLOJAG, int BAMNODMDOON, IEGLICKAHKN IDHPCHNAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D16D20", Offset = "0x1D16120", VA = "0x181D16D20")]
	private void EDPKMILMPAA(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB330", Offset = "0x8BA730", VA = "0x1808BB330")]
	private void NDPFBCIMLEK(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1D17140", Offset = "0x1D16540", VA = "0x181D17140")]
	private void FMJCNIBJENA(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x11963D0", Offset = "0x11957D0", VA = "0x1811963D0")]
	private void GHPGHBJILJL(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A400", Offset = "0x1D19800", VA = "0x181D1A400")]
	private void OLJDHBFNGJA(int BGHJAFHAODE, int MGFBKBODMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x187CA20", Offset = "0x187BE20", VA = "0x18187CA20")]
	private void LCCNPPGDFEH(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D17370", Offset = "0x1D16770", VA = "0x181D17370")]
	private void GKFAJIDPMEO(int CLNIOJLOJAG, int BAMNODMDOON, DCGMHMPBHBE IDHPCHNAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D15820", Offset = "0x1D14C20", VA = "0x181D15820")]
	private void CJLLAOFIFAF(int OIGNJCHPDMC, int BAMNODMDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D18F20", Offset = "0x1D18320", VA = "0x181D18F20")]
	private void KOOKEKDGHIJ(int OIGNJCHPDMC, int BAMNODMDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D185A0", Offset = "0x1D179A0", VA = "0x181D185A0")]
	private void INCJAHFAIJI(int CLNIOJLOJAG, int BAMNODMDOON, DCGMHMPBHBE IDHPCHNAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D16FF0", Offset = "0x1D163F0", VA = "0x181D16FF0")]
	private void FKHDCODMCAP(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8BB330", Offset = "0x8BA730", VA = "0x1808BB330")]
	private void OIEPKPFNCCD(int CLNIOJLOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D16B50", Offset = "0x1D15F50", VA = "0x181D16B50", Slot = "35")]
	[AsyncStateMachine(typeof(GCIDEAODJMA))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? EDLDGFOLBGD(LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D19600", Offset = "0x1D18A00", VA = "0x181D19600", Slot = "36")]
	[AsyncStateMachine(typeof(AIHKOEFGKCO))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? MGEMFCFIEJP(LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D152D0", Offset = "0x1D146D0", VA = "0x181D152D0", Slot = "37")]
	[AsyncStateMachine(typeof(EKPDKEDOBJG))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? AIALHLHLFAL(LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ, LELHOHFMKKF<AKAFBBFLHOC> PLBOKKEMOFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D19A20", Offset = "0x1D18E20", VA = "0x181D19A20", Slot = "38")]
	[AsyncStateMachine(typeof(CBMCMGOCAIF))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? NNLAPLHFAPH(LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH, LELHOHFMKKF<DFDPMBCLKMJ> PLBOKKEMOFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D184B0", Offset = "0x1D178B0", VA = "0x181D184B0", Slot = "39")]
	[AsyncStateMachine(typeof(EHDAMKKLPEO))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO?>>? IIHKMMEFHJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D15870", Offset = "0x1D14C70", VA = "0x181D15870", Slot = "40")]
	[AsyncStateMachine(typeof(DIHCNNGNAGM))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> CKOMENMACOI(string MFENIHMNHOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D18D00", Offset = "0x1D18100", VA = "0x181D18D00", Slot = "41")]
	[AsyncStateMachine(typeof(IPPNLGHEANA))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> KIOLMPIMIOE(LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ, string GFBABMFGHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1D17890", Offset = "0x1D16C90", VA = "0x181D17890", Slot = "42")]
	[AsyncStateMachine(typeof(IKDILPGACNH))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> GMMOHKBKFBM(LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH, string GFBABMFGHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1D15570", Offset = "0x1D14970", VA = "0x181D15570", Slot = "43")]
	[AsyncStateMachine(typeof(GMCCEBNGJJE))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> BNFHHEFPDKA(LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ, EIMNJMAGOBP FICJMFBEBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1D18BD0", Offset = "0x1D17FD0", VA = "0x181D18BD0", Slot = "44")]
	[AsyncStateMachine(typeof(NDEMBKIIKOJ))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> KGCPHDOCKLK(LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH, EIMNJMAGOBP FICJMFBEBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1D19120", Offset = "0x1D18520", VA = "0x181D19120")]
	internal void LMIFLKBEIJA(LELHOHFMKKF<JJEPODHECPL> ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class CJLDDMBLOMP : NKHIGFADDMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface MDEACIDCPNH
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		GCJGLFAPCCC HDOJCDOPODL
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JPIILNLKKAK> POJLOPLHPKL(CancellationToken PPJMMMGPFGD);

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MOBKEGKHHKE> LCBEFDLOECD(CancellationToken PPJMMMGPFGD);

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KPNLOFKEFMI> BNLBOHOCPNF(CancellationToken PPJMMMGPFGD);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PBCNGIBEDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<CJLDDMBLOMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DPOHHGLACDM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public JPIILNLKKAK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public MOBKEGKHHKE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private MDEACIDCPNH <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private MOBKEGKHHKE <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<JPIILNLKKAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<MOBKEGKHHKE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter<KPNLOFKEFMI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<DKLLMPOOJBB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1D2CDA0", Offset = "0x1D2C1A0", VA = "0x181D2CDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D750", Offset = "0x1D2CB50", VA = "0x181D2D750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly DKLLMPOOJBB LLCKJLAOKOK;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DKLLMPOOJBB MHDIBNOEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	private CJLDDMBLOMP(DKLLMPOOJBB OHJCNLOJMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1D140B0", Offset = "0x1D134B0", VA = "0x181D140B0")]
	[AsyncStateMachine(typeof(PBCNGIBEDDE))]
	public static Task<CJLDDMBLOMP> MOLNINMADMF(DPOHHGLACDM JFEBJHGKJHE, JPIILNLKKAK? FOIDNCOOLGM, MOBKEGKHHKE? CGLBOCLPJCB, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x1D14090", Offset = "0x1D13490", VA = "0x181D14090", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct AFEFDIHJDGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct NMLEHBMGGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AFEFDIHJDGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public LOAMOHDBOAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2ACA0", Offset = "0x1D2A0A0", VA = "0x181D2ACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AF30", Offset = "0x1D2A330", VA = "0x181D2AF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct OBJMODDPNNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<bool, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CCDJHKBKGMD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public JPIILNLKKAK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MOBKEGKHHKE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AFEFDIHJDGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private LOAMOHDBOAD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B6C0", Offset = "0x1D2AAC0", VA = "0x181D2B6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BAA0", Offset = "0x1D2AEA0", VA = "0x181D2BAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct ABBMDKEKMGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AFEFDIHJDGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1D123C0", Offset = "0x1D117C0", VA = "0x181D123C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1D126A0", Offset = "0x1D11AA0", VA = "0x181D126A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly NOKEHKADGPK PCNDONDALJB;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	public AFEFDIHJDGK(NOKEHKADGPK MACKCAOBDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1D12800", Offset = "0x1D11C00", VA = "0x181D12800")]
	[AsyncStateMachine(typeof(NMLEHBMGGDP))]
	private Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGFKOKIGCJO(LOAMOHDBOAD HKJBPIINLDG, bool KJOBCONKJDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1D12930", Offset = "0x1D11D30", VA = "0x181D12930")]
	[AsyncStateMachine(typeof(OBJMODDPNNK))]
	public Task<IAPKJCHKLLD<bool, HDKPGPNEBBO?>>? OONKDLBPKDP(int GHBGPEGNALO, CCDJHKBKGMD? IEOLFELCNDG, JPIILNLKKAK? BAODNDKBBPK, MOBKEGKHHKE? CGLBOCLPJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1D12710", Offset = "0x1D11B10", VA = "0x181D12710")]
	[AsyncStateMachine(typeof(ABBMDKEKMGI))]
	public Task<IAPKJCHKLLD<MKHCJDDCMIA, HDKPGPNEBBO>> HJKKNDHGMPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class OEDBAOGIKDD : BEMFABBHDAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly CGIGLAAKPOF FPLHAMPFHJA;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public CGIGLAAKPOF PPAKGIFDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	private OEDBAOGIKDD(CGIGLAAKPOF BINFGLGGHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BB30", Offset = "0x1D2AF30", VA = "0x181D2BB30")]
	public static OEDBAOGIKDD JCEFODEMOAF(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BB10", Offset = "0x1D2AF10", VA = "0x181D2BB10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface OFDPNPBJHOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	BLCFMHBFELN DCEIPHFECDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	BNBJPAHIOEM BBJOHALIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	OGDGIMDDODK BOKAMKGIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	INMGBNCHJOL NKCGKEHOPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IPDECNDKKEE LIDPACAOMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface AOKPKMPOIFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	OFDPNPBJHOD? GJBBCGOLBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool HBPKLGDDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OFDPNPBJHOD?>? ALIBOGAIBLD();

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JODHKNGLMDN(DPOHHGLACDM JFEBJHGKJHE, CCDJHKBKGMD PDINDCMOBEJ, JPIILNLKKAK? IMGCBHHJOLB, MOBKEGKHHKE? LOCJJNCMKGK);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[GEIPBJDCNMO("IStaticCV2Instance")]
public interface NKHIGFADDMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DKLLMPOOJBB MHDIBNOEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[GEIPBJDCNMO("IStaticEVInstance")]
public interface BEMFABBHDAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	CGIGLAAKPOF PPAKGIFDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class GFKEMEBJHCF : LEOLOJJDHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EINDJDMPLNG? GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F6E0", Offset = "0x1D1EAE0", VA = "0x181D1F6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	internal GFKEMEBJHCF(DPOHHGLACDM JFEBJHGKJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class INMGBNCHJOL : EINDJDMPLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly NKHIGFADDMD OEKNNHKGODO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEGDNDDDGNK OGFKOKIGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1D232A0", Offset = "0x1D226A0", VA = "0x181D232A0", Slot = "4")]
		get
		{
			return default(IEGDNDDDGNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BPAGEOFJIHB ONOPMDBPPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D23240", Offset = "0x1D22640", VA = "0x181D23240", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public BKCFLNKEACJ<BBFMEDFDBAF> MNBPEIDJNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1D23190", Offset = "0x1D22590", VA = "0x181D23190", Slot = "6")]
		get
		{
			return default(BKCFLNKEACJ<BBFMEDFDBAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public DKLLMPOOJBB MOEOMELAFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1D231F0", Offset = "0x1D225F0", VA = "0x181D231F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public INMGBNCHJOL(NKHIGFADDMD GGILDEJPPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1D23300", Offset = "0x1D22700", VA = "0x181D23300")]
	public bool KHFHJPNOPAP([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1D23300", Offset = "0x1D22700", VA = "0x181D23300", Slot = "8")]
	private bool PKMOEPHANIB([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class FNKDPJAEHDI
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D720", Offset = "0x1D1CB20", VA = "0x181D1D720")]
	public static JAMIIGBDJCD<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> KAAGBIPIKDH([In] this JAMIIGBDJCD<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>> GGHJJADBEDC)
	{
		return default(JAMIIGBDJCD<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM, PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class PCFCFNENHOD : PHKGCIFAFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool HBPKLGDDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E1B0", Offset = "0x1D2D5B0", VA = "0x181D2E1B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	internal PCFCFNENHOD(DPOHHGLACDM JFEBJHGKJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class HDKAEJDPAHL : ODFGIPCKMLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct GCBFJCNNHHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<NDNKDDKCJKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public HDKAEJDPAHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private TaskAwaiter<OFDPNPBJHOD?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DBD0", Offset = "0x1D1CFD0", VA = "0x181D1DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DE80", Offset = "0x1D1D280", VA = "0x181D1DE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private IReadOnlyList<BKCFLNKEACJ<ENDKBNLNALP>>? LDPNFOLJKEN;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public NDNKDDKCJKI? GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1D21D50", Offset = "0x1D21150", VA = "0x181D21D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public IPDECNDKKEE? MGDKJBLHDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1D213E0", Offset = "0x1D207E0", VA = "0x181D213E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool COFOOMALPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1D21FD0", Offset = "0x1D213D0", VA = "0x181D21FD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DNBDLEBPDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1D22030", Offset = "0x1D21430", VA = "0x181D22030", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	internal HDKAEJDPAHL(DPOHHGLACDM JFEBJHGKJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1D216B0", Offset = "0x1D20AB0", VA = "0x181D216B0", Slot = "7")]
	[AsyncStateMachine(typeof(GCBFJCNNHHI))]
	public Task<NDNKDDKCJKI> DMOMPCJCHKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1D217E0", Offset = "0x1D20BE0", VA = "0x181D217E0")]
	internal Dictionary<BKCFLNKEACJ<BBFMEDFDBAF>, Guid> FDMGMLMLIIJ(IEnumerable<NNPHGGCALLP> EJNCCHMBMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1D21DD0", Offset = "0x1D211D0", VA = "0x181D21DD0")]
	public IAPKJCHKLLD<NIBMCGNFENA, LKFFGCCEJDH> OFDGMNHBEAN([In] NIBMCGNFENA JKEMOBEAEEF, IEnumerable<NNPHGGCALLP> ECONJCEKPOK, int KAPFOFBNCPD)
	{
		return default(IAPKJCHKLLD<NIBMCGNFENA, LKFFGCCEJDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1D217A0", Offset = "0x1D20BA0", VA = "0x181D217A0")]
	internal static DFENHDHDBNN EGFOKNOLECC(PBKHJGGDJMH GHEONPLKIJD, HAHFCMAIFAE DKBEBHEBAJO)
	{
		return default(DFENHDHDBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1D21B50", Offset = "0x1D20F50", VA = "0x181D21B50", Slot = "8")]
	private IAPKJCHKLLD<NIBMCGNFENA, LKFFGCCEJDH> GPHKACNJNDD([In] NIBMCGNFENA JKEMOBEAEEF, IEnumerable<NNPHGGCALLP> ECONJCEKPOK, int KAPFOFBNCPD)
	{
		return default(IAPKJCHKLLD<NIBMCGNFENA, LKFFGCCEJDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1D21460", Offset = "0x1D20860", VA = "0x181D21460")]
	[CompilerGenerated]
	internal static DFENHDHDBNN CIGDDJPIJJN(PBKHJGGDJMH HAJFPILGPHE, HAHFCMAIFAE BCCKIGDGDJG)
	{
		return default(DFENHDHDBNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class IPDECNDKKEE : NDNKDDKCJKI
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class ANIILKGABNG
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class ICKHOKPNPGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public DKLLMPOOJBB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public LKDLEGDJFDM spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public ICKHOKPNPGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x1D32DB0", Offset = "0x1D321B0", VA = "0x181D32DB0")]
			internal bool ENIHOGMNDBP(ODNLFDFALBH n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class HMFADCJAFJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public HMFADCJAFJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x1D32D90", Offset = "0x1D32190", VA = "0x181D32D90")]
			internal void PHEDHKMBDCI(ODNLFDFALBH n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1D30180", Offset = "0x1D2F580", VA = "0x181D30180")]
		public static IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH> BAFODOIJADE(IPDECNDKKEE LOMPFKEACIP, [In] NDNKDDKCJKI.JFIBFLJLPOK EALPNGKPAMO)
		{
			return default(IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1D307B0", Offset = "0x1D2FBB0", VA = "0x181D307B0")]
		internal static IAPKJCHKLLD<(MBPPODCALOB, LGBDEOKIFIH), HDKPGPNEBBO> GCDLPJBBNAP(IPDECNDKKEE LOMPFKEACIP, LGBDEOKIFIH POEGLFDIKOD, bool NFCGAIKCBFN, [In] BKCFLNKEACJ<BBFMEDFDBAF> ILNNOMGCBLF, [In] int? OLLLGJIPPAC, [In] DFENHDHDBNN? HCBCFDDCFGC, [In] DFENHDHDBNN? ADIJMNOOFJB)
		{
			return default(IAPKJCHKLLD<(MBPPODCALOB, LGBDEOKIFIH), HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1D31500", Offset = "0x1D30900", VA = "0x181D31500")]
		private static void GOGHMDNAFBB(bool NFCGAIKCBFN, NNPHGGCALLP EJHCKIEAIIN, MBPPODCALOB NENCJDPPEOC, [In] BKCFLNKEACJ<BBFMEDFDBAF> ILNNOMGCBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1D31990", Offset = "0x1D30D90", VA = "0x181D31990")]
		public static void HENBEPNGICE(FBILDKAPPGD ECLMHEAPOBO, [In] NDNKDDKCJKI.LBMDCNPPAAK AKNMHLHINPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1D306C0", Offset = "0x1D2FAC0", VA = "0x181D306C0")]
		[CompilerGenerated]
		internal static bool EJFJGFMONLK(DKLLMPOOJBB CIHELIJPAOG, LKDLEGDJFDM BFKMHMNKJHB, ODNLFDFALBH CHCJOGBGGCK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly DPOHHGLACDM AHLCIJFCKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly NKHIGFADDMD OEKNNHKGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly BEMFABBHDAG KOJKMPGDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly DNNPPJFGCAH NAJAAMNOCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly HDKAEJDPAHL CKLMLAJFCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Dictionary<BKCFLNKEACJ<FFAKLMOHHBO>, DGFNNJBKMFJ> FGBHCPGLEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[CompilerGenerated]
	private Action<BKCFLNKEACJ<FFAKLMOHHBO>>? CANNLIBCMPG;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1D25290", Offset = "0x1D24690", VA = "0x181D25290")]
	public IPDECNDKKEE(DPOHHGLACDM JFEBJHGKJHE, NKHIGFADDMD GGILDEJPPPD, BEMFABBHDAG AHJLDPBONMJ, HDKAEJDPAHL BPIAHBLIFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D24450", Offset = "0x1D23850", VA = "0x181D24450")]
	public DGFNNJBKMFJ? ELBKKGJKBOB([In] BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D25210", Offset = "0x1D24610", VA = "0x181D25210")]
	private void NJKKGAFFHKI(BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D23EB0", Offset = "0x1D232B0", VA = "0x181D23EB0")]
	private DGFNNJBKMFJ? CNALFIHJPPD([In] BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D23AA0", Offset = "0x1D22EA0", VA = "0x181D23AA0")]
	public HAHFCMAIFAE? CKKDONLJNIP([In] BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D245C0", Offset = "0x1D239C0", VA = "0x181D245C0")]
	public ODCDFBLDLJG? FGOHGPPAJHM([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D24CD0", Offset = "0x1D240D0", VA = "0x181D24CD0")]
	private LKDLEGDJFDM? LGMIHCKOECM([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D24800", Offset = "0x1D23C00", VA = "0x181D24800")]
	private ODCDFBLDLJG? JADLKIDCOCI([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D24AA0", Offset = "0x1D23EA0", VA = "0x181D24AA0", Slot = "6")]
	public IEnumerable<EIMNJMAGOBP> JLPIFOCKODF(bool NBEFJCHBKDK, bool BHDAPPLPOKL, bool KLBEOGBLKPC, bool BMEKOAJDACF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D24770", Offset = "0x1D23B70", VA = "0x181D24770")]
	public IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH> HFIDNJFKBHL([In] NDNKDDKCJKI.JFIBFLJLPOK EALPNGKPAMO)
	{
		return default(IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D236B0", Offset = "0x1D22AB0", VA = "0x181D236B0", Slot = "8")]
	public IAPKJCHKLLD<NJIHNBPAIJO, LKFFGCCEJDH> BEFDILMPPDI(BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA, NJIHNBPAIJO LJOCEKHIBFK, AOAOMEHBOEB HJKEKCDLEEC)
	{
		return default(IAPKJCHKLLD<NJIHNBPAIJO, LKFFGCCEJDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D23370", Offset = "0x1D22770", VA = "0x181D23370", Slot = "9")]
	public KKLMEMONAHL ADFPKCNFGCO(IEnumerable<NNPHGGCALLP> ECONJCEKPOK)
	{
		return default(KKLMEMONAHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D24650", Offset = "0x1D23A50", VA = "0x181D24650", Slot = "10")]
	public KKLMEMONAHL GBJPNBALIOE()
	{
		return default(KKLMEMONAHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D242A0", Offset = "0x1D236A0", VA = "0x181D242A0")]
	private HGDCPMPDPLF DEMJLCIBBMH(HOBGOGOHCNM BLGGHFNDNML, LELHOHFMKKF<BBFMEDFDBAF> MDECBDDNKHJ, IEnumerable<BKCFLNKEACJ<BBFMEDFDBAF>> LNJNNGKILDH, IEnumerable<BKCFLNKEACJ<FFAKLMOHHBO>> FENLIFLFKJK)
	{
		return default(HGDCPMPDPLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D23F60", Offset = "0x1D23360", VA = "0x181D23F60", Slot = "11")]
	public HGDCPMPDPLF DEMJLCIBBMH(HOBGOGOHCNM BLGGHFNDNML, LELHOHFMKKF<BBFMEDFDBAF> MDECBDDNKHJ, IEnumerable<BKCFLNKEACJ<FFAKLMOHHBO>> FENLIFLFKJK, IEnumerable<NNPHGGCALLP> ECONJCEKPOK)
	{
		return default(HGDCPMPDPLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D23B30", Offset = "0x1D22F30", VA = "0x181D23B30")]
	private static IEnumerable<BKCFLNKEACJ<BBFMEDFDBAF>> CMDFOONHFGM(IEnumerable<NNPHGGCALLP> ECONJCEKPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D24D70", Offset = "0x1D24170", VA = "0x181D24D70")]
	private IEnumerable<BKCFLNKEACJ<FFAKLMOHHBO>> MOCMABLJMDA(IEnumerable<NNPHGGCALLP> ECONJCEKPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D24A10", Offset = "0x1D23E10", VA = "0x181D24A10", Slot = "12")]
	public List<EIFFKLKFIKN> JJKKABPAJAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D24C70", Offset = "0x1D24070", VA = "0x181D24C70")]
	internal void LBDDPKIPIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D247A0", Offset = "0x1D23BA0", VA = "0x181D247A0")]
	internal Task HPBJJELENGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1D245C0", Offset = "0x1D239C0", VA = "0x181D245C0", Slot = "4")]
	private ODCDFBLDLJG KBIFNJOKAHL([In] BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1D23560", Offset = "0x1D22960", VA = "0x181D23560", Slot = "5")]
	private DGFNNJBKMFJ BAIEKJOFIBO([In] BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1D24770", Offset = "0x1D23B70", VA = "0x181D24770", Slot = "7")]
	private IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH> PIJFBDMKEAF([In] NDNKDDKCJKI.JFIBFLJLPOK EALPNGKPAMO)
	{
		return default(IAPKJCHKLLD<NDNKDDKCJKI.MCIINNGMIMJ, LKFFGCCEJDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1D245D0", Offset = "0x1D239D0", VA = "0x181D245D0")]
	[CompilerGenerated]
	private IFMCJJBHODE FMKNEODFAOH(NJKNAPIEGPP FPJGJJLGENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D24B90", Offset = "0x1D23F90", VA = "0x181D24B90")]
	[CompilerGenerated]
	private HAHFCMAIFAE KFJFKJIGHHJ(BKCFLNKEACJ<FFAKLMOHHBO> FPJGJJLGENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1D24C00", Offset = "0x1D24000", VA = "0x181D24C00")]
	[CompilerGenerated]
	private LKDLEGDJFDM KJDOFBBANLN(BKCFLNKEACJ<BBFMEDFDBAF> FPJGJJLGENP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class IFMCJJBHODE : EIMNJMAGOBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct EHGKAPKCDNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<LELHOHFMKKF<AKAFBBFLHOC>, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public IFMCJJBHODE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public BKCFLNKEACJ<BBFMEDFDBAF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public BKCFLNKEACJ<FFAKLMOHHBO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public LELHOHFMKKF<JJEPODHECPL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<IAPKJCHKLLD<LELHOHFMKKF<AKAFBBFLHOC>, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1D323F0", Offset = "0x1D317F0", VA = "0x181D323F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1D32670", Offset = "0x1D31A70", VA = "0x181D32670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct AHKNGEENOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<LELHOHFMKKF<DFDPMBCLKMJ>, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IFMCJJBHODE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public BKCFLNKEACJ<BBFMEDFDBAF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public BKCFLNKEACJ<FFAKLMOHHBO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public LELHOHFMKKF<JJEPODHECPL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<IAPKJCHKLLD<LELHOHFMKKF<DFDPMBCLKMJ>, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FE90", Offset = "0x1D2F290", VA = "0x181D2FE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1D30110", Offset = "0x1D2F510", VA = "0x181D30110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly NJKNAPIEGPP LMNBMAPBGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly NKHIGFADDMD OEKNNHKGODO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TypeKey POJMEDKACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string LMEPPCHNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1D33180", Offset = "0x1D32580", VA = "0x181D33180", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NJKNAPIEGPP OGEHEAOPAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1D331B0", Offset = "0x1D325B0", VA = "0x181D331B0")]
	public IFMCJJBHODE(NJKNAPIEGPP JKINLOBMAKE, NKHIGFADDMD GGILDEJPPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1D32EA0", Offset = "0x1D322A0", VA = "0x181D32EA0", Slot = "6")]
	[AsyncStateMachine(typeof(EHGKAPKCDNI))]
	public Task<IAPKJCHKLLD<LELHOHFMKKF<AKAFBBFLHOC>, HDKPGPNEBBO>> DIGAGPAGPGP(BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA, BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, string GFBABMFGHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1D33010", Offset = "0x1D32410", VA = "0x181D33010", Slot = "7")]
	[AsyncStateMachine(typeof(AHKNGEENOOM))]
	public Task<IAPKJCHKLLD<LELHOHFMKKF<DFDPMBCLKMJ>, HDKPGPNEBBO>> GOJEIFFJJCF(BKCFLNKEACJ<BBFMEDFDBAF> NGLJABNBABA, BKCFLNKEACJ<FFAKLMOHHBO> MADPFKENMIG, LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI, string GFBABMFGHOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class PICLEBLECGC : KFOBHPACDPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly NJKNAPIEGPP FHNNDHGHDBF;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly HashSet<NJKNAPIEGPP> NPLJIHADPLM;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly HashSet<NJKNAPIEGPP> MLGFJMHKKJF;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly HashSet<NJKNAPIEGPP> HANLHOFKGNH;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TypeKey LGEKOOBGCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1D34900", Offset = "0x1D33D00", VA = "0x181D34900", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool KJBNAAJOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1D348F0", Offset = "0x1D33CF0", VA = "0x181D348F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool LMOIDDJIEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1D34950", Offset = "0x1D33D50", VA = "0x181D34950", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool EGHDMJHPGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1D34870", Offset = "0x1D33C70", VA = "0x181D34870", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1D33460", Offset = "0x1D32860", VA = "0x181D33460")]
	public bool DFEFBNCAIPO(string ANJCCKHBJJO, [Out] HFACFABGKLL DEOKDAMLGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public PICLEBLECGC(NJKNAPIEGPP FBIBFNALIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x1D336D0", Offset = "0x1D32AD0", VA = "0x181D336D0")]
	internal static TypeKey GEHCJIKMGIM(NJKNAPIEGPP FICJMFBEBIN)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1D33180", Offset = "0x1D32580", VA = "0x181D33180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct ELFMKCHNLGM : IHKNFHBFMNG.HIGOGNLDGCK<LOAMOHDBOAD, MKHCJDDCMIA>
{
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1D32980", Offset = "0x1D31D80", VA = "0x181D32980", Slot = "4")]
	public int JOMLHEKKKBF(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1D32950", Offset = "0x1D31D50", VA = "0x181D32950", Slot = "5")]
	public LOAMOHDBOAD IACPIOGFJAN(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1D328D0", Offset = "0x1D31CD0", VA = "0x181D328D0", Slot = "6")]
	public LOAMOHDBOAD AICKGBOAMBL(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1D329E0", Offset = "0x1D31DE0", VA = "0x181D329E0", Slot = "7")]
	public IReadOnlyList<LOAMOHDBOAD> MKAFMMHGHAF(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1D32920", Offset = "0x1D31D20", VA = "0x181D32920", Slot = "8")]
	public LOAMOHDBOAD[] BLCJGJPEHDI(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG, int AACNBCIBKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1D32960", Offset = "0x1D31D60", VA = "0x181D32960", Slot = "9")]
	public bool ILDKKEJIEOL(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1D329C0", Offset = "0x1D31DC0", VA = "0x181D329C0", Slot = "10")]
	public bool LPDELGABFDN(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1D329A0", Offset = "0x1D31DA0", VA = "0x181D329A0", Slot = "11")]
	public bool LHDBOGNLKEI(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1D32930", Offset = "0x1D31D30", VA = "0x181D32930", Slot = "12")]
	public bool DBNLPJFKFCK(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1D32A00", Offset = "0x1D31E00", VA = "0x181D32A00", Slot = "13")]
	public bool OOKDLFANCKC(MKHCJDDCMIA MAFKOGKJLHL, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1D32900", Offset = "0x1D31D00", VA = "0x181D32900", Slot = "14")]
	public bool BBMLNJIDPHM(MKHCJDDCMIA OIGNJCHPDMC, LOAMOHDBOAD HKJBPIINLDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class JJOBJGBKINK : PINFCBGDJKA
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public KAGGEPDIJHE.COJFLBMOJHN BACLPNLHMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1D332A0", Offset = "0x1D326A0", VA = "0x181D332A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public abstract NJEFKMFEPEE.OGKJCFBAHMC KIPLPOLFOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract DPOHHGLACDM.POJJIDPLMEH EJJDGNPDCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public abstract CJLDDMBLOMP.MDEACIDCPNH HOEKJNJIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public PFMJMBIHEMD.PNIGIANKJKA<PALFOBNHMHK, LOAMOHDBOAD, DPOHHGLACDM> DGHDFAMJIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D33250", Offset = "0x1D32650", VA = "0x181D33250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract FMMFCOMCHNK KODGAOFNAED
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract FGLHCDBNHIK CCMDGDMPFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract PELIKIBPIJH OEDHNDOMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public abstract KLLCGLKENGP DFIBDKFHPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public abstract LOLCKGKFAJM OALLLFPHMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected JJOBJGBKINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class BMJJKBOAIJG : BPAGEOFJIHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct GJPFMKCJOBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public BMJJKBOAIJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public LOAMOHDBOAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D32A20", Offset = "0x1D31E20", VA = "0x181D32A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D32CC0", Offset = "0x1D320C0", VA = "0x181D32CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct DHMDCNHLHAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<DJBBEBFPLOK, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public BMJJKBOAIJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public IReadOnlyList<LOAMOHDBOAD> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D32000", Offset = "0x1D31400", VA = "0x181D32000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D32380", Offset = "0x1D31780", VA = "0x181D32380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private readonly NOKEHKADGPK PCNDONDALJB;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public BMJJKBOAIJG(NOKEHKADGPK MACKCAOBDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D31ED0", Offset = "0x1D312D0", VA = "0x181D31ED0")]
	[AsyncStateMachine(typeof(GJPFMKCJOBB))]
	private Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGFKOKIGCJO(LOAMOHDBOAD HKJBPIINLDG, bool KJOBCONKJDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1D31DA0", Offset = "0x1D311A0", VA = "0x181D31DA0", Slot = "4")]
	[AsyncStateMachine(typeof(DHMDCNHLHAI))]
	public Task<IAPKJCHKLLD<DJBBEBFPLOK, HDKPGPNEBBO>> HLGHBKHGMBD(IReadOnlyList<LOAMOHDBOAD> EFJGOOKKOMG, bool KJOBCONKJDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MKPBKPFDFCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	internal ENAHIJCKNCC<FAJPOODAAGD, LOAMOHDBOAD, AHJMLKLJANI> FHNNDHGHDBF;

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D2EBB0", Offset = "0x1D2DFB0", VA = "0x181D2EBB0")]
	private MKPBKPFDFCG([In] ENAHIJCKNCC<FAJPOODAAGD, LOAMOHDBOAD, AHJMLKLJANI> HONCGOPCCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D332F0", Offset = "0x1D326F0", VA = "0x181D332F0")]
	public static MKPBKPFDFCG CPLKLKACALP()
	{
		return default(MKPBKPFDFCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class GHCMCBBPIJI
{
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static ENAHIJCKNCC<FAJPOODAAGD, LOAMOHDBOAD, AHJMLKLJANI> MHFPMEBDPLG(this MKPBKPFDFCG LOMPFKEACIP)
	{
		return default(ENAHIJCKNCC<FAJPOODAAGD, LOAMOHDBOAD, AHJMLKLJANI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AHJMLKLJANI : PMNEIEPFDBL.IBIMPHAFCAB<FAJPOODAAGD, LOAMOHDBOAD>
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FCA0", Offset = "0x1D2F0A0", VA = "0x181D2FCA0", Slot = "5")]
	public LOAMOHDBOAD NLAOJIBIGEH(FAJPOODAAGD[] BEIFPMNJCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60")]
	public int GLEJMEDJGGE([In] FAJPOODAAGD EDMNJHMCIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60", Slot = "4")]
	private int KGLDCCMAJNM([In] FAJPOODAAGD DHFJEMLPBBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HDCDFGPGBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	internal LMMLJBEPJHH<GLOLEFJGGIP, LOAMOHDBOAD, EIAFCEKIBAP> FHNNDHGHDBF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D2EBB0", Offset = "0x1D2DFB0", VA = "0x181D2EBB0")]
	private HDCDFGPGBAI([In] LMMLJBEPJHH<GLOLEFJGGIP, LOAMOHDBOAD, EIAFCEKIBAP> DBJLLJKCEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D32D30", Offset = "0x1D32130", VA = "0x181D32D30")]
	public static HDCDFGPGBAI CPLKLKACALP()
	{
		return default(HDCDFGPGBAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class ADKGECEBDFN
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static LMMLJBEPJHH<GLOLEFJGGIP, LOAMOHDBOAD, EIAFCEKIBAP> MHFPMEBDPLG(this HDCDFGPGBAI LOMPFKEACIP)
	{
		return default(LMMLJBEPJHH<GLOLEFJGGIP, LOAMOHDBOAD, EIAFCEKIBAP>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct EIAFCEKIBAP : EBABHJLEOJP.FAALPPMOHHE<GLOLEFJGGIP, LOAMOHDBOAD>
{
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60")]
	public int JIGOGHBAKGB([In] GLOLEFJGGIP EDMNJHMCIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D326E0", Offset = "0x1D31AE0", VA = "0x181D326E0", Slot = "5")]
	public LOAMOHDBOAD LNCBJFGBGFJ(GLOLEFJGGIP[] KEEMDPCNAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60", Slot = "4")]
	private int HPIALDLFKCL([In] GLOLEFJGGIP EDMNJHMCIMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface FMMFCOMCHNK
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDCMCOOKNCE([In] IAPKJCHKLLD<MKHCJDDCMIA, LKFFGCCEJDH> ANIEEDIHIEE);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class BCOLHKICHPL
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2453120", Offset = "0x2452520", VA = "0x182453120")]
	public static bool GDCMCOOKNCE<TOk, TErr>(this FMMFCOMCHNK LOMPFKEACIP, [In] IAPKJCHKLLD<TOk, TErr> ANIEEDIHIEE) where TOk : notnull where TErr : notnull, LKFFGCCEJDH
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface FGLHCDBNHIK
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	AMFHFOHLNCK MKFNGMGKAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface PELIKIBPIJH
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIIPBCOJFEM LAAJMELALFI(int EFIGNALHDDN);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface HACBDFHOHLI
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface GOPBEIGLFPC
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHNLIPPKAKL? PMIMKALILNA(LELHOHFMKKF<JJEPODHECPL> HELNCKLMDGI);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface DCDIJNPNIGL
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface HHNLIPPKAKL
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCDIJNPNIGL? JIHMGDDINPK(LELHOHFMKKF<AKAFBBFLHOC> JCKINGBHJAJ);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HACBDFHOHLI? GMLGJLDPHOH(LELHOHFMKKF<DFDPMBCLKMJ> JHDOGDLHBJH);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface KLLCGLKENGP
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CKKILKOPHCN(string ANJCCKHBJJO, string HFPPGLCONIA);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface LOLCKGKFAJM
{
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GOPBEIGLFPC? IAPBCEHLEIC([In] BKCFLNKEACJ<ENDKBNLNALP> PNHOAOHNJLN);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class PNGPLIDBLEE
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct OLEEBDEDIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int BLAEHDOLMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public JPIILNLKKAK? MEENHNHELCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public JPIILNLKKAK? KKMLINJCKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public readonly List<LOAMOHDBOAD> LMANMAPJFLF;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D33410", Offset = "0x1D32810", VA = "0x181D33410")]
		private OLEEBDEDIFG(int AHDNEIKOMIB, JPIILNLKKAK? OGGBPOAAJFN, JPIILNLKKAK? IKGBLEHMJPC, List<LOAMOHDBOAD> EFJGOOKKOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D33350", Offset = "0x1D32750", VA = "0x181D33350")]
		public static OLEEBDEDIFG CPLKLKACALP()
		{
			return default(OLEEBDEDIFG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly KDHHLOKDLFP<OLEEBDEDIFG> PGLJKLJFOLK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public static PNGPLIDBLEE GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D35170", Offset = "0x1D34570", VA = "0x181D35170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool IMIFJCGDBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC020", Offset = "0x7EB420", VA = "0x1807EC020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x992880", Offset = "0x991C80", VA = "0x180992880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D350B0", Offset = "0x1D344B0", VA = "0x181D350B0")]
	public void GEOMENFHAKG(DKLLMPOOJBB IKGBLEHMJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D34DB0", Offset = "0x1D341B0", VA = "0x181D34DB0")]
	public void CCAAKJAMPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D34A70", Offset = "0x1D33E70", VA = "0x181D34A70")]
	private static string? BCKKDDPAEDJ([In] OLEEBDEDIFG EAKINBODPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D352C0", Offset = "0x1D346C0", VA = "0x181D352C0")]
	public PNGPLIDBLEE()
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
