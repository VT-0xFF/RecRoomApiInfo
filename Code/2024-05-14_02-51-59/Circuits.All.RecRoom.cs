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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E52FD0", Offset = "0x1E519D0", VA = "0x181E52FD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class IGHGHLPEJAC : IDisposable, MOJKMONGGFI, IKPIBHHOBOL, BNGIAHEAIAO, EMNPKKMDILM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class EEJPHCNPOLK : DCOOCGDJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int JJPILGNDEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E3FB40", Offset = "0x1E3E540", VA = "0x181E3FB40", Slot = "5")]
		public PCOEICMFPIB DGDLGCBABPE(BKFJOOBDPHK.HBMMNMAFGFF COBDDACEALE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void HLKKFJPOFAC();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void GPJBDIDFGHK();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E3FB00", Offset = "0x1E3E500", VA = "0x181E3FB00", Slot = "13")]
		public virtual void CPGCMJAHMAP(IGHGHLPEJAC DGEHNBLILFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E3FC90", Offset = "0x1E3E690", VA = "0x181E3FC90", Slot = "14")]
		public virtual void ODNGHFCGHBI(IGHGHLPEJAC DGEHNBLILFB, PIADNJODOCI HKIJJKKNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		protected EEJPHCNPOLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DCOOCGDJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int JJPILGNDEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PCOEICMFPIB DGDLGCBABPE(BKFJOOBDPHK.HBMMNMAFGFF COBDDACEALE);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HLKKFJPOFAC();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GPJBDIDFGHK();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CPGCMJAHMAP(IGHGHLPEJAC DGEHNBLILFB);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ODNGHFCGHBI(IGHGHLPEJAC DGEHNBLILFB, PIADNJODOCI HKIJJKKNOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct FBLECOMBICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IDBBNLNJKEH<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> GMKKFAACACB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E463D0", Offset = "0x1E44DD0", VA = "0x181E463D0")]
		internal FBLECOMBICD(IDBBNLNJKEH<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> KGDPHHJJNLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AFPEAGCOELE : LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly AFPEAGCOELE AINFBDJPIJL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		private AFPEAGCOELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xADD400", Offset = "0xADBE00", VA = "0x180ADD400", Slot = "4")]
		public GCNNJGFCDBH CADHCMMBGHN(PIADNJODOCI CMJEIEIDHIK)
		{
			return default(GCNNJGFCDBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A430", Offset = "0x1E38E30", VA = "0x181E3A430", Slot = "5")]
		public void CPGCMJAHMAP(IGHGHLPEJAC AKBOHBAKCNP, PIADNJODOCI HKIJJKKNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A530", Offset = "0x1E38F30", VA = "0x181E3A530", Slot = "6")]
		public void ODNGHFCGHBI(IGHGHLPEJAC AKBOHBAKCNP, PIADNJODOCI HKIJJKKNOIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AACPKGBMNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CAJHKKDKNDJ<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> GMKKFAACACB;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A420", Offset = "0x1E38E20", VA = "0x181E3A420")]
		internal AACPKGBMNFB(CAJHKKDKNDJ<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A3D0", Offset = "0x1E38DD0", VA = "0x181E3A3D0")]
		public static AACPKGBMNFB OLCPJHCMOKI()
		{
			return default(AACPKGBMNFB);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MJLEECELKEF : BFBIFBHLOKO.PJCNBMKOGME<PIADNJODOCI, IGHGHLPEJAC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct OABDDBFCKDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IGHGHLPEJAC receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public PIADNJODOCI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public MJLEECELKEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1E53050", Offset = "0x1E51A50", VA = "0x181E53050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1E53230", Offset = "0x1E51C30", VA = "0x181E53230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xB014C0", Offset = "0xAFFEC0", VA = "0x180B014C0", Slot = "4")]
		public BOLDNJBHEHG<JNFDKKBIGJN> NHLKGKOEMEO(IGHGHLPEJAC PENEHNLEHJA)
		{
			return default(BOLDNJBHEHG<JNFDKKBIGJN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E51800", Offset = "0x1E50200", VA = "0x181E51800", Slot = "5")]
		[AsyncStateMachine(typeof(OABDDBFCKDC))]
		public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> EPMMFPHOCHC(IGHGHLPEJAC PENEHNLEHJA, PIADNJODOCI HKIJJKKNOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E51930", Offset = "0x1E50330", VA = "0x181E51930", Slot = "6")]
		public PIADNJODOCI[] LPKBKBMPFBC(IGHGHLPEJAC PENEHNLEHJA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OGJPGHOIBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IGHGHLPEJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JJBFONMHECH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JDDHADDGFLN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NHPAEOGMHIC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E54100", Offset = "0x1E52B00", VA = "0x181E54100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E54380", Offset = "0x1E52D80", VA = "0x181E54380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PIEMKFAINDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IGHGHLPEJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E557A0", Offset = "0x1E541A0", VA = "0x181E557A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E55A30", Offset = "0x1E54430", VA = "0x181E55A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GCLCBHPBNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public IGHGHLPEJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E46D50", Offset = "0x1E45750", VA = "0x181E46D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E46F30", Offset = "0x1E45930", VA = "0x181E46F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GIIGGHBBCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IGHGHLPEJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PIADNJODOCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E47010", Offset = "0x1E45A10", VA = "0x181E47010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E47200", Offset = "0x1E45C00", VA = "0x181E47200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GPICHFFIDEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IGHGHLPEJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E48020", Offset = "0x1E46A20", VA = "0x181E48020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E48810", Offset = "0x1E47210", VA = "0x181E48810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BOLDNJBHEHG<JNFDKKBIGJN> LFMPNLPHNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FBLECOMBICD FOHONNIKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EEIDDILGOEM KHHNCPLHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly KOKLPFFMJDI PCGDFMLNMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly OINADJBBGIM DDGAPPJOMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly GCFHKIJAPKL.AMILNJLBOBL DKMBIGCAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1208")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly EIEOFPKIAEI POCBCDAPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1210")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KBCLJPEHIND HOGPLGEFNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1218")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DLGDGFOABNK GDLKNIKOHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1220")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ODJEHMIEOOL JKOGDCEMIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1228")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly FKPPFJELKJE DLPDOMFAEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1230")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GFBOEEMKNFJ KJKDPEKPCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1240")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BDIBPFFKHFD EPNHALJGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1260")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EEIDDILGOEM.OGHGLHANFOK IBPCONEPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1268")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly NKOHOGAIMBP EBBPFCFHPBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EEIDDILGOEM ENAGILDFBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E48F50", Offset = "0x1E47950", VA = "0x181E48F50")]
		get
		{
			return default(EEIDDILGOEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DCOOCGDJEGB ONJFHGMCMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E49700", Offset = "0x1E48100", VA = "0x181E49700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PCOEICMFPIB FGDJFLANNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E49960", Offset = "0x1E48360", VA = "0x181E49960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E48F20", Offset = "0x1E47920", VA = "0x181E48F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EIBMNNDPKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E491F0", Offset = "0x1E47BF0", VA = "0x181E491F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E48F40", Offset = "0x1E47940", VA = "0x181E48F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CENCMGBBFMO MBJDIHKFIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A2E0", Offset = "0x1E48CE0", VA = "0x181E4A2E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IPDNAFPELKC KDOOLHCILIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A300", Offset = "0x1E48D00", VA = "0x181E4A300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKPELDGDDPF ONLLHHFICFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A320", Offset = "0x1E48D20", VA = "0x181E4A320", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BDCIPLBEFEG NJNAHDGEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A2F0", Offset = "0x1E48CF0", VA = "0x181E4A2F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AHNLJOCMCHP PIDJFKPCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A310", Offset = "0x1E48D10", VA = "0x181E4A310", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PCNNJGKJEMD? EBMBKKKBFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E48F60", Offset = "0x1E47960", VA = "0x181E48F60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private ENNIFEMKOHC? CGFCLDEABOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E48A00", Offset = "0x1E47400", VA = "0x181E48A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E49FA0", Offset = "0x1E489A0", VA = "0x181E49FA0")]
	private IGHGHLPEJAC(OINADJBBGIM KGKIIJPBBFB, BOLDNJBHEHG<JNFDKKBIGJN> OFMNGOBJEKH, [In] FBLECOMBICD GGFLHHIEAAD, [In] EEIDDILGOEM IJPGNCKKJHJ, [In] KOKLPFFMJDI AHNBEJNBDIA, PCOEICMFPIB NOEOCCOIGCO, [In] GCFHKIJAPKL.AMILNJLBOBL APHDNGNNBNK, EEIDDILGOEM.OGHGLHANFOK MPFLLHIEAEK, NKOHOGAIMBP EJAJEPEKOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E49C50", Offset = "0x1E48650", VA = "0x181E49C50")]
	public static IGHGHLPEJAC OLCPJHCMOKI(OINADJBBGIM COBDDACEALE, [In] MPCKOFEIPHC CBIDOKPEDKF, KPPAOPOIMOO BLGFPALMHNJ, [In] GCGEJGFHKJM AAKNGJLAPDE, CKKCAGDJECC KACFDPOMMHC, BOLDNJBHEHG<JNFDKKBIGJN> OFMNGOBJEKH, BOLDNJBHEHG<ABCKJPLMHOP> IEJGEHOEGMH, FDBLMCDEPNP KBMHLGEFDFM, HLCIENHMABC HBBBHBNEPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E49970", Offset = "0x1E48370", VA = "0x181E49970")]
	public static IGHGHLPEJAC OLCPJHCMOKI(OINADJBBGIM KGKIIJPBBFB, [In] EEIDDILGOEM IJPGNCKKJHJ, [In] KOKLPFFMJDI AHNBEJNBDIA, BOLDNJBHEHG<JNFDKKBIGJN> OFMNGOBJEKH, BOLDNJBHEHG<ABCKJPLMHOP> IEJGEHOEGMH, FDBLMCDEPNP KBMHLGEFDFM, HLCIENHMABC HBBBHBNEPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E48C40", Offset = "0x1E47640", VA = "0x181E48C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E49090", Offset = "0x1E47A90", VA = "0x181E49090")]
	[AsyncStateMachine(typeof(OGJPGHOIBJG))]
	internal Task<LGGHGMLBJFM<bool, DGFMPJAMJNO>> KBEIGLFDOJL(JJBFONMHECH EHICCJEFNJM, JDDHADDGFLN FMJIOPLOAJN, NHPAEOGMHIC AOFALACDKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E48E30", Offset = "0x1E47830", VA = "0x181E48E30")]
	[AsyncStateMachine(typeof(PIEMKFAINDD))]
	public Task<LGGHGMLBJFM<bool, DGFMPJAMJNO>> GBFFNPNGNOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E49610", Offset = "0x1E48010", VA = "0x181E49610")]
	[AsyncStateMachine(typeof(GCLCBHPBNFA))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> MKIOJIGEKBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E49D90", Offset = "0x1E48790", VA = "0x181E49D90")]
	internal void PDCJIMBBHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E49200", Offset = "0x1E47C00", VA = "0x181E49200")]
	internal GLKIBNECMOM<PIADNJODOCI> LLAMKJEDKDI([In] MDBHOKCDNOA GPFPOMCGCGK)
	{
		return default(GLKIBNECMOM<PIADNJODOCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E49750", Offset = "0x1E48150", VA = "0x181E49750")]
	internal bool MPNLAIBKNMG([In] MDBHOKCDNOA GPFPOMCGCGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E497C0", Offset = "0x1E481C0", VA = "0x181E497C0")]
	internal GLKIBNECMOM<PIADNJODOCI> NJGLCDMNMAH([In] NOEPPJIJACE HDHLCGKJCKO)
	{
		return default(GLKIBNECMOM<PIADNJODOCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E48B30", Offset = "0x1E47530", VA = "0x181E48B30")]
	[AsyncStateMachine(typeof(GIIGGHBBCHJ))]
	internal Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> CNPALDJCKJC(PIADNJODOCI HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E49280", Offset = "0x1E47C80", VA = "0x181E49280")]
	private PIADNJODOCI[] LPKBKBMPFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E49840", Offset = "0x1E48240", VA = "0x181E49840")]
	[AsyncStateMachine(typeof(GPICHFFIDEG))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> OGJEJIFAACL(Guid EMADILJCABF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LEJPCMFNLDB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29E4CE0", Offset = "0x29E36E0", VA = "0x1829E4CE0")]
	public static NGGPDBAAOKO<(TPrev?, IGHGHLPEJAC?), ENNIFEMKOHC> OKDHAHKMNBP<TPrev>([In] this NGGPDBAAOKO<TPrev, IGHGHLPEJAC> CMJEIEIDHIK)
	{
		return default(NGGPDBAAOKO<(TPrev, IGHGHLPEJAC), ENNIFEMKOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29E4A80", Offset = "0x29E3480", VA = "0x1829E4A80")]
	public static NGGPDBAAOKO<TPrev?, IGHGHLPEJAC?> HBNBBDLOIBM<TPrev>([In] this NGGPDBAAOKO<TPrev, IGHGHLPEJAC> CMJEIEIDHIK)
	{
		return default(NGGPDBAAOKO<TPrev, IGHGHLPEJAC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MMHFKIHAPFN<TData> : LJNADPDGEHJ, ABIDJHCNICE, CEAFENKMCFB where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CPNCACFPDBL<APJKLHNMCKH>? DDIHNCCEGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string IFJJAPFHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData PICICNMEMLG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CPNCACFPDBL<APJKLHNMCKH>? HJODAJDODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x203DC50", Offset = "0x203C650", VA = "0x18203DC50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0", Slot = "7")]
	public override string BLGDHPMKGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x404E7F0", Offset = "0x404D1F0", VA = "0x18404E7F0")]
	internal MMHFKIHAPFN([In] CPNCACFPDBL<APJKLHNMCKH>? JDDJDGEFBHK, BOLDNJBHEHG<HCGHMOECILC>? HEBNGMJIIOP, IOKind? BLGCINJABHF, string CPPFNMDMGHI, [In] TData ABDLEBPKDKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GNNNNKANPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E479E0", Offset = "0x1E463E0", VA = "0x181E479E0")]
	public static LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE> PJOCOPFNADP([In] this PPJBGKFADEC<KIFEKOJDIPL> MHFPCOOEEPE)
	{
		return default(LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x295AEB0", Offset = "0x29598B0", VA = "0x18295AEB0")]
	public static LGGHGMLBJFM<TOk, ABIDJHCNICE> APMDHFJAFAH<TOk>([In] this LGGHGMLBJFM<TOk, ABIDJHCNICE> CMJEIEIDHIK, [In] CPNCACFPDBL<APJKLHNMCKH>? JDDJDGEFBHK, BOLDNJBHEHG<HCGHMOECILC>? HEBNGMJIIOP, IOKind? BLGCINJABHF, string CPPFNMDMGHI) where TOk : notnull
	{
		return default(LGGHGMLBJFM<TOk, ABIDJHCNICE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OINADJBBGIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OLEBJKAMFBN.AEFOBHFPENK GPMHEFKMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BKFJOOBDPHK.HBMMNMAFGFF NKEFMBMJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IGHGHLPEJAC.DCOOCGDJEGB NMJKFCFMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MHKHOIOAOKB.KNHBMIPBGEP LMGMPJGJNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC> BHLOGAJIELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KPEHDMLEMPN GBCHJDDJIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JNIJOOCHFDO FBAJMJLHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HMNMFEPLBKF DELHBEIBNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DCHHPEJEIML JMNIDNNFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GNPIDDDCFOP LGAHAPODJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LAIMAOGADFI
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C280", Offset = "0x1E4AC80", VA = "0x181E4C280")]
	public static PIADNJODOCI IBNPAIGCOON(this PIADNJODOCI CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C390", Offset = "0x1E4AD90", VA = "0x181E4C390")]
	public static PIADNJODOCI ONFBMLCADKM(this LGPJECHKOLE CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LGPJECHKOLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LNIBOHAEKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IGHGHLPEJAC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public LGPJECHKOLE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E506F0", Offset = "0x1E4F0F0", VA = "0x181E506F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E509B0", Offset = "0x1E4F3B0", VA = "0x181E509B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString DPMGLPAKGNP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	private LGPJECHKOLE(ByteString AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F7D0", Offset = "0x1E4E1D0", VA = "0x181E4F7D0")]
	public static PIADNJODOCI ANFNKIAEHGJ(ByteString AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F9A0", Offset = "0x1E4E3A0", VA = "0x181E4F9A0")]
	public static OJPADOANHHB<GCNNJGFCDBH, LGPJECHKOLE> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, LGPJECHKOLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F890", Offset = "0x1E4E290", VA = "0x181E4F890")]
	[AsyncStateMachine(typeof(LNIBOHAEKPP))]
	public static Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> CNPALDJCKJC(IGHGHLPEJAC AKBOHBAKCNP, LGPJECHKOLE CMJEIEIDHIK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LLMIOEJJNEJ
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E50560", Offset = "0x1E4EF60", VA = "0x181E50560")]
	public static PIADNJODOCI ANFNKIAEHGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E50680", Offset = "0x1E4F080", VA = "0x181E50680")]
	public static OJPADOANHHB<GCNNJGFCDBH, LLMIOEJJNEJ> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, LLMIOEJJNEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E50600", Offset = "0x1E4F000", VA = "0x181E50600")]
	public static LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN> DGFGFAMKDPC(IGHGHLPEJAC AKBOHBAKCNP, [In] LLMIOEJJNEJ CMJEIEIDHIK)
	{
		return default(LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PIDGNPJPBHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LIPNKIFDNOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IGHGHLPEJAC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PIDGNPJPBHK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FDC0", Offset = "0x1E4E7C0", VA = "0x181E4FDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E50130", Offset = "0x1E4EB30", VA = "0x181E50130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JJBFONMHECH? LHLNOFFBAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly JDDHADDGFLN? DINNJPEHABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly NHPAEOGMHIC? PHOBIPHEHNK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7590", Offset = "0x1BA5F90", VA = "0x181BA7590")]
	private PIDGNPJPBHK(JJBFONMHECH? EHICCJEFNJM, JDDHADDGFLN? FMJIOPLOAJN, NHPAEOGMHIC? AOFALACDKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E54F50", Offset = "0x1E53950", VA = "0x181E54F50")]
	public static PIADNJODOCI? ANFNKIAEHGJ(JJBFONMHECH? EHICCJEFNJM, JDDHADDGFLN? FMJIOPLOAJN, NHPAEOGMHIC? AOFALACDKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E55190", Offset = "0x1E53B90", VA = "0x181E55190")]
	public static OJPADOANHHB<GCNNJGFCDBH, PIDGNPJPBHK> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, PIDGNPJPBHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E55050", Offset = "0x1E53A50", VA = "0x181E55050")]
	[AsyncStateMachine(typeof(LIPNKIFDNOE))]
	public static Task<LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN>> CNPALDJCKJC(IGHGHLPEJAC AKBOHBAKCNP, PIDGNPJPBHK CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct JDOEDHEILGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct NOJDLMAIIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<CFFLBEIHEFA, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JDOEDHEILGI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IGHGHLPEJAC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private LGGHGMLBJFM<CFFLBEIHEFA, DGFMPJAMJNO> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private LGGHGMLBJFM<object, CEAFENKMCFB>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private LGGHGMLBJFM<object, CEAFENKMCFB> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private LGGHGMLBJFM<object, CEAFENKMCFB>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E52B00", Offset = "0x1E51500", VA = "0x181E52B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E52F60", Offset = "0x1E51960", VA = "0x181E52F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<PIADNJODOCI> GLPOPLCBCJM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	private JDOEDHEILGI(IReadOnlyList<PIADNJODOCI> LCNHLGGJHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A870", Offset = "0x1E49270", VA = "0x181E4A870")]
	public static PIADNJODOCI ANFNKIAEHGJ(IReadOnlyList<PIADNJODOCI> LCNHLGGJHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AA70", Offset = "0x1E49470", VA = "0x181E4AA70")]
	public static OJPADOANHHB<GCNNJGFCDBH, JDOEDHEILGI> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, JDOEDHEILGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A930", Offset = "0x1E49330", VA = "0x181E4A930")]
	[AsyncStateMachine(typeof(NOJDLMAIIED))]
	public static Task<LGGHGMLBJFM<CFFLBEIHEFA, DGFMPJAMJNO>> CNPALDJCKJC(IGHGHLPEJAC AKBOHBAKCNP, JDOEDHEILGI CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NOEPPJIJACE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int IAGPAHCAHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int JIFJFCOEJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] PICICNMEMLG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1931F20", Offset = "0x1930920", VA = "0x181931F20")]
	private NOEPPJIJACE(int GBACAOOHJGH, int ABBNIPHGMGH, byte[] ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E526E0", Offset = "0x1E510E0", VA = "0x181E526E0")]
	public static PIADNJODOCI ANFNKIAEHGJ(int GBACAOOHJGH, int ABBNIPHGMGH, ByteString ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E529C0", Offset = "0x1E513C0", VA = "0x181E529C0")]
	public static PIADNJODOCI[] OAAIHHFKGEP(PIADNJODOCI HKIJJKKNOIF, int CIJBKMKFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E528E0", Offset = "0x1E512E0", VA = "0x181E528E0")]
	public static OJPADOANHHB<GCNNJGFCDBH, NOEPPJIJACE> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, NOEPPJIJACE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E527C0", Offset = "0x1E511C0", VA = "0x181E527C0")]
	public static LGGHGMLBJFM<PIADNJODOCI, BPHLMNENOKN> DGFGFAMKDPC(IGHGHLPEJAC AKBOHBAKCNP, [In] NOEPPJIJACE CMJEIEIDHIK)
	{
		return default(LGGHGMLBJFM<PIADNJODOCI, BPHLMNENOKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MDBHOKCDNOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DBFPPCPPGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<bool, BPHLMNENOKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IGHGHLPEJAC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MDBHOKCDNOA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private LGGHGMLBJFM<bool, BPHLMNENOKN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, BPHLMNENOKN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C780", Offset = "0x1E3B180", VA = "0x181E3C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1E3CDC0", Offset = "0x1E3B7C0", VA = "0x181E3CDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int IAGPAHCAHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int JIFJFCOEJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] PICICNMEMLG;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1931F20", Offset = "0x1930920", VA = "0x181931F20")]
	private MDBHOKCDNOA(int GBACAOOHJGH, int ABBNIPHGMGH, byte[] ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E50AC0", Offset = "0x1E4F4C0", VA = "0x181E50AC0")]
	public static PIADNJODOCI ANFNKIAEHGJ(int GBACAOOHJGH, int ABBNIPHGMGH, ByteString ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E50CD0", Offset = "0x1E4F6D0", VA = "0x181E50CD0")]
	public static PIADNJODOCI?[]? LPNEKIMGBOB(int CIJBKMKFJME, JJBFONMHECH? EHICCJEFNJM, JDDHADDGFLN? FMJIOPLOAJN, NHPAEOGMHIC? AOFALACDKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E50ED0", Offset = "0x1E4F8D0", VA = "0x181E50ED0")]
	public static OJPADOANHHB<GCNNJGFCDBH, MDBHOKCDNOA> MGJBLEBCFNA(PIADNJODOCI DBICFIADHIL)
	{
		return default(OJPADOANHHB<GCNNJGFCDBH, MDBHOKCDNOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E50BA0", Offset = "0x1E4F5A0", VA = "0x181E50BA0")]
	[AsyncStateMachine(typeof(DBFPPCPPGFF))]
	public static Task<LGGHGMLBJFM<bool, BPHLMNENOKN>> CNPALDJCKJC(IGHGHLPEJAC AKBOHBAKCNP, MDBHOKCDNOA CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EIEOFPKIAEI : CENCMGBBFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LMOKPICHJEM? AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3FD10", Offset = "0x1E3E710", VA = "0x181E3FD10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	internal EIEOFPKIAEI(IGHGHLPEJAC DGEHNBLILFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JJGKKDNKGAM : LMOKPICHJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CLGOAAEIPHG EOBLNFOPFCF;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public JJGKKDNKGAM(IGHGHLPEJAC DGEHNBLILFB, CLGOAAEIPHG HCJDMNONFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AEF0", Offset = "0x1E498F0", VA = "0x181E4AEF0", Slot = "4")]
	public LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE> HALHIJLDOHF(CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<GJPIAGLNEDD> AALGEDLKPBM)
	{
		return default(LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AC20", Offset = "0x1E49620", VA = "0x181E4AC20", Slot = "5")]
	public LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE> BCCPMEOLPOA(CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<JGMGJKCNGHI> PPBIEIMLFDD)
	{
		return default(LGGHGMLBJFM<EPKBHFHBKKM, ABIDJHCNICE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OLEBJKAMFBN : FLKKGLJNIDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface AEFOBHFPENK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CLGOAAEIPHG> BJEBDDGGIDD(IGHGHLPEJAC DGEHNBLILFB, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB, CancellationToken CFAFANOFDNJ);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CHJMCIBJDKP OBNCAOBADNK(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CKDEICJMCNM : AEFOBHFPENK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct NDDCDPLMIGM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<CLGOAAEIPHG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IGHGHLPEJAC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public JDDHADDGFLN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public NHPAEOGMHIC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<MHKHOIOAOKB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1E522F0", Offset = "0x1E50CF0", VA = "0x181E522F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1E52610", Offset = "0x1E51010", VA = "0x181E52610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly CKDEICJMCNM AINFBDJPIJL;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		private CKDEICJMCNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C580", Offset = "0x1E3AF80", VA = "0x181E3C580", Slot = "4")]
		[AsyncStateMachine(typeof(NDDCDPLMIGM))]
		public Task<CLGOAAEIPHG> BJEBDDGGIDD(IGHGHLPEJAC DGEHNBLILFB, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB, CancellationToken CFAFANOFDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C6E0", Offset = "0x1E3B0E0", VA = "0x181E3C6E0", Slot = "5")]
		public CHJMCIBJDKP OBNCAOBADNK(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KONACEBJGGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<OLEBJKAMFBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IGHGHLPEJAC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JDDHADDGFLN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NHPAEOGMHIC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JJBFONMHECH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private AEFOBHFPENK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<CLGOAAEIPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B770", Offset = "0x1E4A170", VA = "0x181E4B770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BCC0", Offset = "0x1E4A6C0", VA = "0x181E4BCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CLGOAAEIPHG EOBLNFOPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CHJMCIBJDKP MOBNCODAGDM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PCNNJGKJEMD HCKHOEOGDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E54510", Offset = "0x1E52F10", VA = "0x181E54510", Slot = "4")]
		get
		{
			return default(PCNNJGKJEMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ENNIFEMKOHC COJLAAELABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E543F0", Offset = "0x1E52DF0", VA = "0x181E543F0", Slot = "5")]
		get
		{
			return default(ENNIFEMKOHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JJGKKDNKGAM OCHCLHCHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public BNIKIGCHKEJ LMJDMAJCPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MDEDMHBHNFJ IENBEGAFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E546E0", Offset = "0x1E530E0", VA = "0x181E546E0")]
	private OLEBJKAMFBN(CLGOAAEIPHG HCJDMNONFOG, CHJMCIBJDKP FPGGJHOJDEO, JJGKKDNKGAM LKDOJCAKCAA, BNIKIGCHKEJ ECHPHJFALLP, MDEDMHBHNFJ PHJIOJHEGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E54570", Offset = "0x1E52F70", VA = "0x181E54570")]
	[AsyncStateMachine(typeof(KONACEBJGGL))]
	public static Task<OLEBJKAMFBN> PAHKOIFMMME(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E544B0", Offset = "0x1E52EB0", VA = "0x181E544B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BKFJOOBDPHK : PCOEICMFPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface HBMMNMAFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FLKKGLJNIDA> IPLHHFBJJCH(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB, CancellationToken CFAFANOFDNJ);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PDLMFCFNFBA();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GGEFFJCDOFH();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class DFJDKEMLBIB : HBMMNMAFGFF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct BGFGNPACPHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<FLKKGLJNIDA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public IGHGHLPEJAC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public JJBFONMHECH evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public JDDHADDGFLN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public NHPAEOGMHIC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<OLEBJKAMFBN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E3ACF0", Offset = "0x1E396F0", VA = "0x181E3ACF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E3B030", Offset = "0x1E39A30", VA = "0x181E3B030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E3CE30", Offset = "0x1E3B830", VA = "0x181E3CE30", Slot = "4")]
		[AsyncStateMachine(typeof(BGFGNPACPHD))]
		public Task<FLKKGLJNIDA> IPLHHFBJJCH(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB, CancellationToken CFAFANOFDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PDLMFCFNFBA();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GGEFFJCDOFH();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		protected DFJDKEMLBIB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct ENDFDCGPCCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<FLKKGLJNIDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BKFJOOBDPHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<PHKKIFFGKBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E45DD0", Offset = "0x1E447D0", VA = "0x181E45DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E45FD0", Offset = "0x1E449D0", VA = "0x181E45FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MHGKFIOJMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BKFJOOBDPHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public IGHGHLPEJAC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JJBFONMHECH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JDDHADDGFLN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NHPAEOGMHIC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<FLKKGLJNIDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E510F0", Offset = "0x1E4FAF0", VA = "0x181E510F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E51620", Offset = "0x1E50020", VA = "0x181E51620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly HBMMNMAFGFF GOGJLAAIIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<PHKKIFFGKBG> DCNABKMMBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<PHKKIFFGKBG> GLPJEBJMJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource OGFONBMLPNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EIBMNNDPKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x886CD0", Offset = "0x8856D0", VA = "0x180886CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x979270", Offset = "0x977C70", VA = "0x180979270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99B460", Offset = "0x999E60", VA = "0x18099B460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99B450", Offset = "0x999E50", VA = "0x18099B450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OEGGKIEDEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF9F860", Offset = "0xF9E260", VA = "0x180F9F860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B460", Offset = "0x1E39E60", VA = "0x181E3B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FLKKGLJNIDA? FONKOPNOOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C00", Offset = "0x7C8600", VA = "0x1807C9C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B370", Offset = "0x1E39D70", VA = "0x181E3B370", Slot = "7")]
	[AsyncStateMachine(typeof(ENDFDCGPCCM))]
	public Task<FLKKGLJNIDA> EDOACMAINLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B470", Offset = "0x1E39E70", VA = "0x181E3B470")]
	public BKFJOOBDPHK(HBMMNMAFGFF COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B0A0", Offset = "0x1E39AA0", VA = "0x181E3B0A0", Slot = "8")]
	[AsyncStateMachine(typeof(MHGKFIOJMMF))]
	public Task BHFHBKKEPDF(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B200", Offset = "0x1E39C00", VA = "0x181E3B200", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LCABDAFJEDI : BLLNNIIMFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly BNIKIGCHKEJ ECIIDOEHLEC;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public LCABDAFJEDI(BNIKIGCHKEJ ECHPHJFALLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class BDBEJNINJEN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class LIGMMEGFCAD<TGraph> : HMJNJCIKJKO where TGraph : DEPOAGBIECE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph NDDEBEBGOMG;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual HIICAHMIHPP? JEIJJKAKCLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDE2080", Offset = "0xDE0A80", VA = "0x180DE2080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BOLDNJBHEHG<ADBOOFMFKMC> EICJLFJEAGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E4B7F0", Offset = "0x3E4A1F0", VA = "0x183E4B7F0", Slot = "4")]
			get
			{
				return default(BOLDNJBHEHG<ADBOOFMFKMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
		public LIGMMEGFCAD(TGraph HFKIFEHLALP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class APNMPPAIBGJ : LIGMMEGFCAD<OBIHCBMCGFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override HIICAHMIHPP? JEIJJKAKCLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E3A870", Offset = "0x1E39270", VA = "0x181E3A870", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A890", Offset = "0x1E39290", VA = "0x181E3A890")]
		public APNMPPAIBGJ(OBIHCBMCGFH JEMFGCLIFPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AB60", Offset = "0x1E39560", VA = "0x181E3AB60")]
	public static HMJNJCIKJKO OLCPJHCMOKI(DEPOAGBIECE HFKIFEHLALP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LGMHPCBBGGP : ECJAFEPLEEF, GPNEHIBKNCM, OHBAIJGMMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ANHELEEHGAI
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
			public ANHELEEHGAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public KPEHDMLEMPN errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E56890", Offset = "0x1E55290", VA = "0x181E56890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E56B00", Offset = "0x1E55500", VA = "0x181E56B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LGMHPCBBGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ANHELEEHGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A780", Offset = "0x1E39180", VA = "0x181E3A780")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task COLAOJLCHCM(KPEHDMLEMPN errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FPAHDEMLIFO : IAsyncStateMachine
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
		public LGMHPCBBGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E46870", Offset = "0x1E45270", VA = "0x181E46870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E46CF0", Offset = "0x1E456F0", VA = "0x181E46CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class FGJOAHJOHGC
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
			public FGJOAHJOHGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E56B60", Offset = "0x1E55560", VA = "0x181E56B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E56E40", Offset = "0x1E55840", VA = "0x181E56E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LGMHPCBBGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FGJOAHJOHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E463E0", Offset = "0x1E44DE0", VA = "0x181E463E0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task PPEEIOIJJAK(KPEHDMLEMPN errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CNKFKBDECFB MKEBNCHEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<IOFMOFADMGN> ANFAGPCHFGF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private OINADJBBGIM BLLFPCDNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E4F630", Offset = "0x1E4E030", VA = "0x181E4F630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BOLDNJBHEHG<GJPIAGLNEDD> BEMMKOBIJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB019F0", Offset = "0xB003F0", VA = "0x180B019F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(BOLDNJBHEHG<GJPIAGLNEDD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB4FF50", Offset = "0xB4E950", VA = "0x180B4FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BOLDNJBHEHG<KEJDHOACCFC> PCEIHBHHFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x996160", Offset = "0x994B60", VA = "0x180996160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BOLDNJBHEHG<NDKJHIALBDD> NNADPNJHOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E88C0", VA = "0x1807E9EC0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BOLDNJBHEHG<NDKJHIALBDD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override BOLDNJBHEHG<HCGHMOECILC> ODMLCDCMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E4DC70", Offset = "0x1E4C670", VA = "0x181E4DC70", Slot = "20")]
		get
		{
			return default(BOLDNJBHEHG<HCGHMOECILC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BHDBHFLMELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E4DE30", Offset = "0x1E4C830", VA = "0x181E4DE30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F650", Offset = "0x1E4E050", VA = "0x181E4F650")]
	private LGMHPCBBGGP(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII, CNKFKBDECFB DAIGNNEONPP, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<GJPIAGLNEDD> AALGEDLKPBM, BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP, bool FLOOKPAMGPM, string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F160", Offset = "0x1E4DB60", VA = "0x181E4F160")]
	public static LGMHPCBBGGP OLCPJHCMOKI(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII, CNKFKBDECFB KAPFFOPPBJF, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP, BOLDNJBHEHG<GJPIAGLNEDD> AALGEDLKPBM, bool FLOOKPAMGPM, bool ALDNJOMOHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EBC0", Offset = "0x1E4D5C0", VA = "0x181E4EBC0", Slot = "21")]
	protected override void MPOMBMILLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D6E0", Offset = "0x1E4C0E0", VA = "0x181E4D6E0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EAD0", Offset = "0x1E4D4D0", VA = "0x181E4EAD0", Slot = "30")]
	public void MGCCNHNGMII(IOFMOFADMGN CJFHPBMPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E110", Offset = "0x1E4CB10", VA = "0x181E4E110", Slot = "27")]
	public void IPKNJMOFNMD(DLINMBAEOJM OGBKBOMEHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C8C0", Offset = "0x1E4B2C0", VA = "0x181E4C8C0", Slot = "28")]
	public void CHJJKPIKLLJ(ADNCGFGGOOO DFKBBKKJFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DB20", Offset = "0x1E4C520", VA = "0x181E4DB20", Slot = "23")]
	protected override void ENLKGHOAIMK(MEFJDEBPGIB JEIMNOJMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DCC0", Offset = "0x1E4C6C0", VA = "0x181E4DCC0", Slot = "32")]
	public string GNLMPJNKNHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D3B0", Offset = "0x1E4BDB0", VA = "0x181E4D3B0", Slot = "29")]
	public string DPNONFOLEDI(int AFOAGHLPAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E8A0", Offset = "0x1E4D2A0", VA = "0x181E4E8A0")]
	private void LEIAOKMJFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F570", Offset = "0x1E4DF70", VA = "0x181E4F570", Slot = "31")]
	public void PCBCFCJLHDD(IOFMOFADMGN CJFHPBMPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4ED80", Offset = "0x1E4D780", VA = "0x181E4ED80")]
	private void NDJLMKHDHGN(bool AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E790", Offset = "0x1E4D190", VA = "0x181E4E790", Slot = "33")]
	[AsyncStateMachine(typeof(FPAHDEMLIFO))]
	public Task KJBFJGPLBPN(string AEJBOLFACJC, bool IMJHMLHANNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D260", Offset = "0x1E4BC60", VA = "0x181E4D260")]
	public void DJHJBIEJBED(string AEJBOLFACJC, bool IMJHMLHANNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D8A0", Offset = "0x1E4C2A0", VA = "0x181E4D8A0")]
	private void ECKKCOPGCLG(int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB4FF50", Offset = "0xB4E950", VA = "0x180B4FF50")]
	internal void BEOCIFHPPPE(BOLDNJBHEHG<GJPIAGLNEDD> AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DCB0", Offset = "0x1E4C6B0", VA = "0x181E4DCB0")]
	[CompilerGenerated]
	private void FKLIEFEDMBK(string AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E4F0", Offset = "0x1E4CEF0", VA = "0x181E4E4F0")]
	[CompilerGenerated]
	private bool JLNEEOHLDGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E640", Offset = "0x1E4D040", VA = "0x181E4E640")]
	[CompilerGenerated]
	private bool JMKGFCELLAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DA40", Offset = "0x1E4C440", VA = "0x181E4DA40")]
	[CompilerGenerated]
	private int EJGJEOFCOFE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C830", Offset = "0x1E4B230", VA = "0x181E4C830")]
	[CompilerGenerated]
	private bool BDGGKGKEKGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EBB0", Offset = "0x1E4D5B0", VA = "0x181E4EBB0")]
	[CompilerGenerated]
	private void MLEBEMIACMP(string AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F010", Offset = "0x1E4DA10", VA = "0x181E4F010")]
	[CompilerGenerated]
	private bool NJJICBIHNOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DC20", Offset = "0x1E4C620", VA = "0x181E4DC20")]
	[CompilerGenerated]
	private bool FDPGFABJOEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DA90", Offset = "0x1E4C490", VA = "0x181E4DA90")]
	[CompilerGenerated]
	private bool EMPLICBNNAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DA40", Offset = "0x1E4C440", VA = "0x181E4DA40")]
	[CompilerGenerated]
	private int IMGBIMLBLCM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EF40", Offset = "0x1E4D940", VA = "0x181E4EF40")]
	[CompilerGenerated]
	private bool NIIBNJFBAGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E0C0", Offset = "0x1E4CAC0", VA = "0x181E4E0C0")]
	[CompilerGenerated]
	private int IJLFFDPMCCO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EB30", Offset = "0x1E4D530", VA = "0x181E4EB30")]
	[CompilerGenerated]
	private void MGLPAKBLPND(object AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DFF0", Offset = "0x1E4C9F0", VA = "0x181E4DFF0")]
	[CompilerGenerated]
	private bool IFHNPPHPFBO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DIDHELBFOAN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class CDJGGALADBD : JDCFLCFIBEJ<HAIDLDPBIEM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override OCCLPNFOLEO PKBNLDNNOLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9206E0", Offset = "0x91F0E0", VA = "0x1809206E0", Slot = "125")]
			get
			{
				return default(OCCLPNFOLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C160", Offset = "0x1E3AB60", VA = "0x181E3C160")]
		public CDJGGALADBD(IGHGHLPEJAC DGEHNBLILFB, HAIDLDPBIEM KGDPHHJJNLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class LJDKLNKECHP : EHELHGFELGD<KHCEBJJLMEL>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E50490", Offset = "0x1E4EE90", VA = "0x181E50490")]
		public LJDKLNKECHP(IGHGHLPEJAC DGEHNBLILFB, KHCEBJJLMEL KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E50310", Offset = "0x1E4ED10", VA = "0x181E50310", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E502C0", Offset = "0x1E4ECC0", VA = "0x181E502C0")]
		[CompilerGenerated]
		private bool HLJFJBNOBBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E501A0", Offset = "0x1E4EBA0", VA = "0x181E501A0")]
		[CompilerGenerated]
		private void BFCPNKCGAJP(bool AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class GJJEGAPFFFE : EHELHGFELGD<JIHKFEDDLHB>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class GPGEPNMCLLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public GJJEGAPFFFE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GPGEPNMCLLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E47DC0", Offset = "0x1E467C0", VA = "0x181E47DC0")]
			internal void EBIDOKGKNKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E47E10", Offset = "0x1E46810", VA = "0x181E47E10")]
			internal bool JKHEINDOBNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E47EB0", Offset = "0x1E468B0", VA = "0x181E47EB0")]
			internal bool LFAFFACJNIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1E47F00", Offset = "0x1E46900", VA = "0x181E47F00")]
			internal void MJKGBCAGJIG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E47E60", Offset = "0x1E46860", VA = "0x181E47E60")]
			internal bool LEENDAKODMJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E47970", Offset = "0x1E46370", VA = "0x181E47970")]
		public GJJEGAPFFFE(IGHGHLPEJAC DGEHNBLILFB, JIHKFEDDLHB KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E47670", Offset = "0x1E46070", VA = "0x181E47670", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MNIHIJNMENJ : EHELHGFELGD<BPMLDBFLIBH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class DJAFNDKNCAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public MNIHIJNMENJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public DJAFNDKNCAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E3DDD0", Offset = "0x1E3C7D0", VA = "0x181E3DDD0")]
			internal object EBIDOKGKNKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E390", Offset = "0x1E3CD90", VA = "0x181E3E390")]
			internal bool LKNIMPMBGJD(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E3DF90", Offset = "0x1E3C990", VA = "0x181E3DF90")]
			internal void JKHEINDOBNA(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E230", Offset = "0x1E3CC30", VA = "0x181E3E230")]
			internal string LFAFFACJNIO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E410", Offset = "0x1E3CE10", VA = "0x181E3E410")]
			internal IReadOnlyList<object> MJKGBCAGJIG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E1E0", Offset = "0x1E3CBE0", VA = "0x181E3E1E0")]
			internal bool LEENDAKODMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E3DF20", Offset = "0x1E3C920", VA = "0x181E3DF20")]
			internal bool IIEEMKLMHOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1E3DED0", Offset = "0x1E3C8D0", VA = "0x181E3DED0")]
			internal void GEDFMMCMPAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E460", Offset = "0x1E3CE60", VA = "0x181E3E460")]
			internal bool PDBAHHJGJBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E500", Offset = "0x1E3CF00", VA = "0x181E3E500")]
			internal bool PPBBOJEPGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1E3DCB0", Offset = "0x1E3C6B0", VA = "0x181E3DCB0")]
			internal void BPFCAIKJNLB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E3E4B0", Offset = "0x1E3CEB0", VA = "0x181E3E4B0")]
			internal bool PDKLELKGAKA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E51F70", Offset = "0x1E50970", VA = "0x181E51F70")]
		public MNIHIJNMENJ(IGHGHLPEJAC DGEHNBLILFB, BPMLDBFLIBH KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E51950", Offset = "0x1E50350", VA = "0x181E51950", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class LHBEPLNMOIC : EHELHGFELGD<EGMGKMLLBID>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class EOHOGFOGJEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public LHBEPLNMOIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public EOHOGFOGJEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E46040", Offset = "0x1E44A40", VA = "0x181E46040")]
			internal bool EBIDOKGKNKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E46090", Offset = "0x1E44A90", VA = "0x181E46090")]
			internal void JKHEINDOBNA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1E46200", Offset = "0x1E44C00", VA = "0x181E46200")]
			internal bool LFAFFACJNIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x1E46250", Offset = "0x1E44C50", VA = "0x181E46250")]
			internal void MJKGBCAGJIG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1E461B0", Offset = "0x1E44BB0", VA = "0x181E461B0")]
			internal bool LEENDAKODMJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FD50", Offset = "0x1E4E750", VA = "0x181E4FD50")]
		public LHBEPLNMOIC(IGHGHLPEJAC DGEHNBLILFB, EGMGKMLLBID KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FA50", Offset = "0x1E4E450", VA = "0x181E4FA50", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class BAPEOJAIIEM<TNode> : EHELHGFELGD<TNode> where TNode : notnull, NAJNNPINHNE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct DGDPBMIDKPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public BAPEOJAIIEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5248A10", Offset = "0x5247410", VA = "0x185248A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5248DD0", Offset = "0x52477D0", VA = "0x185248DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct FLAJPBAGGPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public BAPEOJAIIEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public BOLDNJBHEHG<OIOOIEADMDH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x38C7D40", Offset = "0x38C6740", VA = "0x1838C7D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x38C8100", Offset = "0x38C6B00", VA = "0x1838C8100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool MFOGAJFEBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override BOLDNJBHEHG<OIOOIEADMDH>? ECDMBDPOFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4926DF0", Offset = "0x49257F0", VA = "0x184926DF0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3953F00", Offset = "0x3952900", VA = "0x183953F00")]
		protected BAPEOJAIIEM(IGHGHLPEJAC DGEHNBLILFB, TNode KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49269E0", Offset = "0x49253E0", VA = "0x1849269E0", Slot = "99")]
		[AsyncStateMachine(typeof(BAPEOJAIIEM<>.DGDPBMIDKPO))]
		public override Task<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> HCALPNCAJMA(string GKDOOPOCBPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4926BA0", Offset = "0x49255A0", VA = "0x184926BA0", Slot = "123")]
		public sealed override bool LEMLHKLHGEE(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4926D50", Offset = "0x4925750", VA = "0x184926D50", Slot = "111")]
		protected sealed override bool OFBHFEPBNME(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4926B00", Offset = "0x4925500", VA = "0x184926B00", Slot = "112")]
		protected override bool HMGHCHLNLBL(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4926C40", Offset = "0x4925640", VA = "0x184926C40", Slot = "100")]
		[AsyncStateMachine(typeof(BAPEOJAIIEM<>.FLAJPBAGGPE))]
		public override Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> LMMBNEDKDIN(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class LCBADJEBMHM : KJMMGCOAGNA<HMICCDBNHHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MFGKFLCAIKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public LCBADJEBMHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public MFGKFLCAIKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1E50FB0", Offset = "0x1E4F9B0", VA = "0x181E50FB0")]
			internal bool NCDCMHPPPLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1E51030", Offset = "0x1E4FA30", VA = "0x181E51030")]
			internal void OEPNHLKKIHI(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C6B0", Offset = "0x1E4B0B0", VA = "0x181E4C6B0")]
		public LCBADJEBMHM(IGHGHLPEJAC DGEHNBLILFB, HMICCDBNHHO KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C460", Offset = "0x1E4AE60", VA = "0x181E4C460", Slot = "125")]
		protected override void AGLAEPOJEAH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JFEFDDFOGGO : GBMMKHDMOAN<LBOBPFLNGAG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AB10", Offset = "0x1E49510", VA = "0x181E4AB10")]
		public JFEFDDFOGGO(IGHGHLPEJAC DGEHNBLILFB, LBOBPFLNGAG KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class GBMMKHDMOAN<TNode> : EHELHGFELGD<TNode> where TNode : notnull, LJHFPGJMOJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct IIBOKGDCIEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public GBMMKHDMOAN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB870", Offset = "0x3ABA270", VA = "0x183ABB870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3ABBBD0", Offset = "0x3ABA5D0", VA = "0x183ABBBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct CILEEILJPKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public GBMMKHDMOAN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public BOLDNJBHEHG<OIOOIEADMDH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x4B95A20", Offset = "0x4B94420", VA = "0x184B95A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4B95D50", Offset = "0x4B94750", VA = "0x184B95D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override BOLDNJBHEHG<ADBOOFMFKMC>? ECHGILGCMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3953F30", Offset = "0x3952930", VA = "0x183953F30", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override BOLDNJBHEHG<OIOOIEADMDH>? ECDMBDPOFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3953FE0", Offset = "0x39529E0", VA = "0x183953FE0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3953F00", Offset = "0x3952900", VA = "0x183953F00")]
		public GBMMKHDMOAN(IGHGHLPEJAC DGEHNBLILFB, TNode KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3953AF0", Offset = "0x39524F0", VA = "0x183953AF0", Slot = "99")]
		[AsyncStateMachine(typeof(GBMMKHDMOAN<>.IIBOKGDCIEM))]
		public override Task<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> HCALPNCAJMA(string GKDOOPOCBPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3953CB0", Offset = "0x39526B0", VA = "0x183953CB0", Slot = "123")]
		public sealed override bool LEMLHKLHGEE(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3953E60", Offset = "0x3952860", VA = "0x183953E60", Slot = "111")]
		protected sealed override bool OFBHFEPBNME(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3953C10", Offset = "0x3952610", VA = "0x183953C10", Slot = "112")]
		protected override bool HMGHCHLNLBL(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3953D50", Offset = "0x3952750", VA = "0x183953D50", Slot = "100")]
		[AsyncStateMachine(typeof(GBMMKHDMOAN<>.CILEEILJPKC))]
		public override Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> LMMBNEDKDIN(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class MPCAOIOCJGF : KJMMGCOAGNA<AHCDCOIAEDG>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class IMLDHALLEIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public MPCAOIOCJGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public IMLDHALLEIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1E4A330", Offset = "0x1E48D30", VA = "0x181E4A330")]
			internal int NCDCMHPPPLP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1E4A3B0", Offset = "0x1E48DB0", VA = "0x181E4A3B0")]
			internal void OEPNHLKKIHI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1E52290", Offset = "0x1E50C90", VA = "0x181E52290")]
		public MPCAOIOCJGF(IGHGHLPEJAC DGEHNBLILFB, AHCDCOIAEDG KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1E51FE0", Offset = "0x1E509E0", VA = "0x181E51FE0", Slot = "125")]
		protected override void AGLAEPOJEAH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class KMJLBMPOIEO : EHELHGFELGD<PLDGKIGLNFN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA75AF0", Offset = "0xA744F0", VA = "0x180A75AF0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B700", Offset = "0x1E4A100", VA = "0x181E4B700")]
		public KMJLBMPOIEO(IGHGHLPEJAC DGEHNBLILFB, PLDGKIGLNFN KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class MBCGLNMLJHG : GBMMKHDMOAN<OGOHCNOPBKI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool OEMABDCADDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CKNEDBOEBMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1E50A80", Offset = "0x1E4F480", VA = "0x181E50A80", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x93A410", Offset = "0x938E10", VA = "0x18093A410", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E50A20", Offset = "0x1E4F420", VA = "0x181E50A20")]
		public MBCGLNMLJHG(IGHGHLPEJAC DGEHNBLILFB, OGOHCNOPBKI KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class KPGLGEEPKPF : EHELHGFELGD<FJOLALNIOFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x10A76B0", Offset = "0x10A60B0", VA = "0x1810A76B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BD30", Offset = "0x1E4A730", VA = "0x181E4BD30")]
		public KPGLGEEPKPF(IGHGHLPEJAC DGEHNBLILFB, FJOLALNIOFH KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class ODINOGKEBKE : EHELHGFELGD<GHMPBIMCJCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x93B790", Offset = "0x93A190", VA = "0x18093B790", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E53990", Offset = "0x1E52390", VA = "0x181E53990")]
		public ODINOGKEBKE(IGHGHLPEJAC DGEHNBLILFB, GHMPBIMCJCC KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "111")]
		protected override bool OFBHFEPBNME(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class BCGKJFJHAIG : EHELHGFELGD<BCDDFNBDMAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x949E90", Offset = "0x948890", VA = "0x180949E90", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool MGKNPCGCPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1E3AB10", Offset = "0x1E39510", VA = "0x181E3AB10", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override bool FDJNCIHHNPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AAA0", Offset = "0x1E394A0", VA = "0x181E3AAA0")]
		public BCGKJFJHAIG(IGHGHLPEJAC DGEHNBLILFB, BCDDFNBDMAJ KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class AKDOEEABHAF : EHELHGFELGD<MCABJGKPLMP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9206E0", Offset = "0x91F0E0", VA = "0x1809206E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool MGKNPCGCPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1E3A730", Offset = "0x1E39130", VA = "0x181E3A730", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected override bool FDJNCIHHNPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A6C0", Offset = "0x1E390C0", VA = "0x181E3A6C0")]
		public AKDOEEABHAF(IGHGHLPEJAC DGEHNBLILFB, MCABJGKPLMP KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class CBGIOCNECPF : BAPEOJAIIEM<OCAMJJNIPLM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x947F30", Offset = "0x946930", VA = "0x180947F30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C100", Offset = "0x1E3AB00", VA = "0x181E3C100")]
		public CBGIOCNECPF(IGHGHLPEJAC DGEHNBLILFB, OCAMJJNIPLM KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class CFEBOGIOKJA : KJMMGCOAGNA<IIFLKHGCMLM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class LFJDJFHGNME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public CFEBOGIOKJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public LFJDJFHGNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x1E4C710", Offset = "0x1E4B110", VA = "0x181E4C710")]
			internal int NCDCMHPPPLP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1E4C790", Offset = "0x1E4B190", VA = "0x181E4C790")]
			internal void OEPNHLKKIHI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C4C0", Offset = "0x1E3AEC0", VA = "0x181E3C4C0")]
		public CFEBOGIOKJA(IGHGHLPEJAC DGEHNBLILFB, IIFLKHGCMLM KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C1C0", Offset = "0x1E3ABC0", VA = "0x181E3C1C0", Slot = "125")]
		protected override void AGLAEPOJEAH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class PMAOMANPBOE : JDCFLCFIBEJ<HFMONEJBFKH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override OCCLPNFOLEO PKBNLDNNOLK
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "125")]
			get
			{
				return default(OCCLPNFOLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1E55AA0", Offset = "0x1E544A0", VA = "0x181E55AA0")]
		public PMAOMANPBOE(IGHGHLPEJAC DGEHNBLILFB, HFMONEJBFKH KGDPHHJJNLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class BAPBGBAHFAC : EHELHGFELGD<AOHIGHJIHBA>
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AA30", Offset = "0x1E39430", VA = "0x181E3AA30")]
		public BAPBGBAHFAC(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class EHELHGFELGD<TNode> : GDLGGGHHOIM, IDisposable where TNode : notnull, AOHIGHJIHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct BGCPLLPFJKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string DNHJCMFLIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly string MGGECGAMDDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly string LJOPJNOBIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly PIAMGAAGBBD LNGMGFMKKOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly LHAGGOKJPNJ GNJCGBBCNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly Func<string, bool> OMNGLPKDJEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly string LFINIFHEJIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public readonly Func<string, bool> LAEPGGDPBLA;

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4943E20", Offset = "0x4942820", VA = "0x184943E20")]
			public BGCPLLPFJKP(string ELPLMJHJKDJ, string OGFCEIILDCN, string OCINNEDOIBB, PIAMGAAGBBD HFGDPLNMEJP, LHAGGOKJPNJ BKNDGOJEBEJ, Func<string, bool> LJHDLPPFCKJ, string HEKKMOKOEPO, Func<string, bool> BFDMCCBAMMD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class IBFDNGBINMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public EHELHGFELGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public IGHGHLPEJAC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public IBFDNGBINMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4380", Offset = "0x3AA2D80", VA = "0x183AA4380")]
			internal EIIEKECEBDB AMNKBLANHKG(JJOGMCDAALH portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct LJAKLKGLHBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public EHELHGFELGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3E4BE90", Offset = "0x3E4A890", VA = "0x183E4BE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct DLHCIPLKGHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public EHELHGFELGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public DAMMCLLGIFL? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public EGHKIPGFNHC? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5272240", Offset = "0x5270C40", VA = "0x185272240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x52724D0", Offset = "0x5270ED0", VA = "0x1852724D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class GIBFJKCDFMP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public GIBFJKCDFMP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x32C79B0", Offset = "0x32C63B0", VA = "0x1832C79B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public EHELHGFELGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public LNJHIAAAAND configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GIBFJKCDFMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			internal string AEHHCGELPCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
			internal void JGGINFNGMDI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x398A8D0", Offset = "0x39892D0", VA = "0x18398A8D0")]
			[AsyncStateMachine(typeof(EHELHGFELGD<>.GIBFJKCDFMP.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void AHPDKOHBCKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class NHFNJPNEHDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public NHFNJPNEHDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x40D1B50", Offset = "0x40D0550", VA = "0x1840D1B50")]
			internal bool GKIEEFPPFCJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x40D1C30", Offset = "0x40D0630", VA = "0x1840D1C30")]
			internal bool JIJFJOBHPJD(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct PMAIFMOHIDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public EHELHGFELGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x43140A0", Offset = "0x4312AA0", VA = "0x1843140A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x4314380", Offset = "0x4312D80", VA = "0x184314380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly IGHGHLPEJAC JCJEKHBNMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly bool MLILCJCOEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private OKKMLGACIBJ<OIOOIEADMDH, EIIEKECEBDB> BDPGLPKJFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private OKKMLGACIBJ<OIOOIEADMDH, DLHLLKIPNOP> GJEDALABPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<Action> DGMFOECIDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[CompilerGenerated]
		private Action<BOLDNJBHEHG<OIOOIEADMDH>>? CKKBCPFNNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[CompilerGenerated]
		private Action<BOLDNJBHEHG<OIOOIEADMDH>, DLHLLKIPNOP>? EIBOJCCFDBD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected PJLALPJBKMI EEGCOIAIHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x34FFD90", Offset = "0x34FE790", VA = "0x1834FFD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected TNode KPOLILHKOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public CPNCACFPDBL<EFGKAOAPDDH> FDIONMKJOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9DE400", Offset = "0x9DCE00", VA = "0x1809DE400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CPNCACFPDBL<EFGKAOAPDDH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public BOLDNJBHEHG<FIAOGCPGKFO> MBPAACIONGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x35019D0", Offset = "0x35003D0", VA = "0x1835019D0", Slot = "6")]
			get
			{
				return default(BOLDNJBHEHG<FIAOGCPGKFO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public object BHEGPEPPGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3501A40", Offset = "0x3500440", VA = "0x183501A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool AJLEPLBBAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int LLKBDMEOKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x35016F0", Offset = "0x35000F0", VA = "0x1835016F0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public NLADGGDNOHJ HHEECNFKOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x35016B0", Offset = "0x35000B0", VA = "0x1835016B0", Slot = "10")]
			get
			{
				return default(NLADGGDNOHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string APBCMBOOOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3501B80", Offset = "0x3500580", VA = "0x183501B80", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected virtual bool FDJNCIHHNPF
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public BOLDNJBHEHG<PGKMNFOGGHM> AALMMAGKHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x963310", Offset = "0x961D10", VA = "0x180963310", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(BOLDNJBHEHG<PGKMNFOGGHM>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9E1FC0", Offset = "0x9E09C0", VA = "0x1809E1FC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool MGKNPCGCPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool OEMABDCADDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual DHHLBMJCLDL NJEFDLJKGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9385C0", Offset = "0x936FC0", VA = "0x1809385C0", Slot = "93")]
			get
			{
				return default(DHHLBMJCLDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DONHMCLFIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x35014E0", Offset = "0x34FFEE0", VA = "0x1835014E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool MPHOPMLHGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3501530", Offset = "0x34FFF30", VA = "0x183501530", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool GCKEDGOIMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3501580", Offset = "0x34FFF80", VA = "0x183501580", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int PEMEHGLDMCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3501990", Offset = "0x3500390", VA = "0x183501990", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool KAAFPMCAJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3501820", Offset = "0x3500220", VA = "0x183501820", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool BOFBJMIDGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3501610", Offset = "0x3500010", VA = "0x183501610", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool COCLDCGMHPE
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB21620", Offset = "0xB20020", VA = "0x180B21620", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB216A0", Offset = "0xB200A0", VA = "0x180B216A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool HFKANKLNFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool OKKIHLLLJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x35015D0", Offset = "0x34FFFD0", VA = "0x1835015D0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool GECILADHGMC
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3501780", Offset = "0x3500180", VA = "0x183501780", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public DAMMCLLGIFL BMNHEIGADNE
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x35018F0", Offset = "0x35002F0", VA = "0x1835018F0", Slot = "27")]
			get
			{
				return default(DAMMCLLGIFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public EGHKIPGFNHC JGNDFHLFBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3501940", Offset = "0x3500340", VA = "0x183501940", Slot = "29")]
			get
			{
				return default(EGHKIPGFNHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool DGKKGGPMKDD
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual PBJGKJAOOFM? IMPLPKDFKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual KDAHDEPLPHB? OEODIFHJGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual IEnumerable<CPNCACFPDBL<APJKLHNMCKH>>? NFINFIGKBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool NFPIIMLGEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3501660", Offset = "0x3500060", VA = "0x183501660", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public CPNCACFPDBL<ADBOOFMFKMC> MKMMBBDDGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3501860", Offset = "0x3500260", VA = "0x183501860", Slot = "55")]
			get
			{
				return default(CPNCACFPDBL<ADBOOFMFKMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public BOLDNJBHEHG<ADBOOFMFKMC> EICJLFJEAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3501730", Offset = "0x3500130", VA = "0x183501730", Slot = "56")]
			get
			{
				return default(BOLDNJBHEHG<ADBOOFMFKMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool MFOGAJFEBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual BOLDNJBHEHG<ADBOOFMFKMC>? ECHGILGCMHL
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool CKNEDBOEBMC
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool FNFBABOECAA
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x35017D0", Offset = "0x35001D0", VA = "0x1835017D0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7CF990", Offset = "0x7CE390", VA = "0x1807CF990", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA00", Offset = "0x7CE400", VA = "0x1807CFA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public CPNCACFPDBL<APJKLHNMCKH> KDMEOILOEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x35018B0", Offset = "0x35002B0", VA = "0x1835018B0", Slot = "62")]
			get
			{
				return default(CPNCACFPDBL<APJKLHNMCKH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public CPNCACFPDBL<APJKLHNMCKH>? JIGPEOMPGMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3501A60", Offset = "0x3500460", VA = "0x183501A60", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public BEDLNHHKGNB<OIOOIEADMDH, DLHLLKIPNOP> OMAJMILIPOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3501B40", Offset = "0x3500540", VA = "0x183501B40", Slot = "64")]
			get
			{
				return default(BEDLNHHKGNB<OIOOIEADMDH, DLHLLKIPNOP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual BOLDNJBHEHG<OIOOIEADMDH>? ECDMBDPOFHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool NDJHLEJIFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool JOPDBMABFID
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FPDFIDPPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x34FE210", Offset = "0x34FCC10", VA = "0x1834FE210", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x34FD180", Offset = "0x34FBB80", VA = "0x1834FD180", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AHKEDCDIJIF IGLAEAAMELF
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x34FEC90", Offset = "0x34FD690", VA = "0x1834FEC90", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3500080", Offset = "0x34FEA80", VA = "0x183500080", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ELKAOPPPLNK HMKOINFGJPH
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x34FD070", Offset = "0x34FBA70", VA = "0x1834FD070", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x34FE400", Offset = "0x34FCE00", VA = "0x1834FE400", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OLKKCDJHDLE
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x34FF1B0", Offset = "0x34FDBB0", VA = "0x1834FF1B0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x34FFD30", Offset = "0x34FE730", VA = "0x1834FFD30", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JFGAJNDLGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x34FC790", Offset = "0x34FB190", VA = "0x1834FC790", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x34FFB80", Offset = "0x34FE580", VA = "0x1834FFB80", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>, DLHLLKIPNOP> LALFHIBFHJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3500AC0", Offset = "0x34FF4C0", VA = "0x183500AC0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3500C00", Offset = "0x34FF600", VA = "0x183500C00", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>, DLHLLKIPNOP> BFCHBABLBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3500DE0", Offset = "0x34FF7E0", VA = "0x183500DE0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x34FEE00", Offset = "0x34FD800", VA = "0x1834FEE00", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>> EMEEFLOBFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x34FD220", Offset = "0x34FBC20", VA = "0x1834FD220", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x34FE120", Offset = "0x34FCB20", VA = "0x1834FE120", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>, BOLDNJBHEHG<OIOOIEADMDH>> NJFALJJGJPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x34FFC20", Offset = "0x34FE620", VA = "0x1834FFC20", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x34FEF30", Offset = "0x34FD930", VA = "0x1834FEF30", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>, DLHLLKIPNOP> BJJNDJGIPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x35002F0", Offset = "0x34FECF0", VA = "0x1835002F0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x34FCC70", Offset = "0x34FB670", VA = "0x1834FCC70", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<BOLDNJBHEHG<OIOOIEADMDH>, BOLDNJBHEHG<OIOOIEADMDH>> JGNFPBBIEJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3500F60", Offset = "0x34FF960", VA = "0x183500F60", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x34FFE80", Offset = "0x34FE880", VA = "0x1834FFE80", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3501020", Offset = "0x34FFA20", VA = "0x183501020")]
		[OKMJKJEMLAC("Need to handle `Name` better.")]
		[OKMJKJEMLAC("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected EHELHGFELGD(IGHGHLPEJAC DGEHNBLILFB, TNode KDIAAEPKAII, bool ALDNJOMOHAB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x35003B0", Offset = "0x34FEDB0", VA = "0x1835003B0", Slot = "86")]
		protected virtual void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x34FD830", Offset = "0x34FC230", VA = "0x1834FD830", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x34FF440", Offset = "0x34FDE40", VA = "0x1834FF440", Slot = "9")]
		[AsyncStateMachine(typeof(EHELHGFELGD<>.LJAKLKGLHBO))]
		public void INPDHADJEMO(int FKPLEDOIEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x34FFCE0", Offset = "0x34FE6E0", VA = "0x1834FFCE0")]
		public bool KBEGKMDLNNO([In] DAMMCLLGIFL AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3500B80", Offset = "0x34FF580", VA = "0x183500B80")]
		public bool NMLNKJFAHDC([In] EGHKIPGFNHC AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3500120", Offset = "0x34FEB20", VA = "0x183500120", Slot = "31")]
		public void MNPJHBEIJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x34FF2F0", Offset = "0x34FDCF0", VA = "0x1834FF2F0", Slot = "32")]
		[AsyncStateMachine(typeof(EHELHGFELGD<>.DLHCIPLKGHL))]
		public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> IMMBCFBPHOD(DAMMCLLGIFL? AFOLKIAHJCP, EGHKIPGFNHC? JEMAGIAEKCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "96")]
		public virtual void PJFMPHFMEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "97")]
		public virtual void CEPOMKHCMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "98")]
		public virtual void JHNGLDEFGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1BA0950", Offset = "0x1B9F350", VA = "0x181BA0950")]
		protected void KBEIPOLMBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x34FD2E0", Offset = "0x34FBCE0", VA = "0x1834FD2E0")]
		protected void DLJCDDBFEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2026790", Offset = "0x2025190", VA = "0x182026790")]
		private void AMFAPPABOMM([In] EGHKIPGFNHC DMBBOEJIOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x34FED30", Offset = "0x34FD730", VA = "0x1834FED30", Slot = "99")]
		public virtual Task<LGGHGMLBJFM<BOLDNJBHEHG<OIOOIEADMDH>, DGFMPJAMJNO>> HCALPNCAJMA(string GKDOOPOCBPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x34FFF40", Offset = "0x34FE940", VA = "0x1834FFF40", Slot = "100")]
		public virtual Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> LMMBNEDKDIN(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "101")]
		public virtual void NIPCLGEFNIO(BOLDNJBHEHG<OIOOIEADMDH> JAJKIEFIIAN, BOLDNJBHEHG<OIOOIEADMDH> JPCFJEAHLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3500EA0", Offset = "0x34FF8A0", VA = "0x183500EA0", Slot = "102")]
		public virtual IEnumerable<PIADNJODOCI> OPGCHPMMNED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3500A40", Offset = "0x34FF440", VA = "0x183500A40", Slot = "103")]
		public LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO> NFLOIJEBNAJ(string AEAHKBEEEIA)
		{
			return default(LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34FE2B0", Offset = "0x34FCCB0", VA = "0x1834FE2B0", Slot = "46")]
		public bool GCJLBOJCFHA([Out] Guid GNNJFHIPNKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x34FCD30", Offset = "0x34FB730", VA = "0x1834FCD30")]
		public bool AOJLEMHAPMP([In] Guid NINCGKAKJEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "104")]
		public virtual void EMPGGONCJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "105")]
		public virtual void MJMHPIHBKCO(bool BDODHPJFKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "106")]
		public virtual GAHFDHBJIDC IOBEDDPPNMC([In] KIOHOOEEGPI HAHKCOOEFGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x34FEFF0", Offset = "0x34FD9F0", VA = "0x1834FEFF0")]
		protected void IEPBNJLHOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3500BD0", Offset = "0x34FF5D0", VA = "0x183500BD0", Slot = "111")]
		protected virtual bool OFBHFEPBNME(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "112")]
		protected virtual bool HMGHCHLNLBL(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "119")]
		protected virtual void MEBBNPJIOMH(LNJHIAAAAND KFLNICEJHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x34FF6E0", Offset = "0x34FE0E0", VA = "0x1834FF6E0")]
		protected void JIPLNOAIBPG(LNJHIAAAAND NDJIIBMIIDA, Func<string> JDODBFDBFFG, Action<string> KBOIPFJJIJA, BGCPLLPFJKP CADHKPGCKBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34FC960", Offset = "0x34FB360", VA = "0x1834FC960")]
		protected void AEIOLHHABMI(LNJHIAAAAND NDJIIBMIIDA, Func<string> JDODBFDBFFG, Action<string> KBOIPFJJIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x34FC830", Offset = "0x34FB230", VA = "0x1834FC830", Slot = "120")]
		protected virtual void AEGKHICOFEO(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x34FD110", Offset = "0x34FBB10", VA = "0x1834FD110", Slot = "79")]
		public void CHJJKPIKLLJ(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x34FF4F0", Offset = "0x34FDEF0", VA = "0x1834FF4F0", Slot = "80")]
		public EJIJEHCDMIF JCNHCFBCPPH()
		{
			return default(EJIJEHCDMIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "123")]
		public virtual bool LEMLHKLHGEE(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x128EB40", Offset = "0x128D540", VA = "0x18128EB40")]
		private void CIPLJMCIDDK([In] DAMMCLLGIFL DGOJEOCFHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x34FE030", Offset = "0x34FCA30", VA = "0x1834FE030")]
		private void EIKKIENKFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x34FD300", Offset = "0x34FBD00", VA = "0x1834FD300")]
		private void DPAKHBFCJPG(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, JJOGMCDAALH FCBLHFLMLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x34FD160", Offset = "0x34FBB60", VA = "0x1834FD160")]
		private void CIBKIADCJJN(BOLDNJBHEHG<OIOOIEADMDH> MCGNHGLIJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3500CC0", Offset = "0x34FF6C0", VA = "0x183500CC0")]
		private void OOLEFMJHMGH(BOLDNJBHEHG<OIOOIEADMDH> MCGNHGLIJDN, JJOGMCDAALH LEPIIGKFNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x34FE8E0", Offset = "0x34FD2E0", VA = "0x1834FE8E0")]
		private void GPFOMIEGBDO(BOLDNJBHEHG<OIOOIEADMDH> JAJKIEFIIAN, BOLDNJBHEHG<OIOOIEADMDH> JPCFJEAHLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2026550", Offset = "0x2024F50", VA = "0x182026550")]
		private void CODMMABBLMN(BOLDNJBHEHG<OIOOIEADMDH> JAJKIEFIIAN, BOLDNJBHEHG<OIOOIEADMDH> JPCFJEAHLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xC233C0", Offset = "0xC21DC0", VA = "0x180C233C0")]
		private void MOKLJPBINAP(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x34FE4D0", Offset = "0x34FCED0", VA = "0x1834FE4D0")]
		private void GGLJCAMIDBN(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, JJOGMCDAALH FCBLHFLMLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x34FEEC0", Offset = "0x34FD8C0", VA = "0x1834FEEC0")]
		private void HJPNNCBONND(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, JJOGMCDAALH LEPIIGKFNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x34FF5C0", Offset = "0x34FDFC0", VA = "0x1834FF5C0", Slot = "124")]
		[AsyncStateMachine(typeof(EHELHGFELGD<>.PMAIFMOHIDI))]
		public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> JFFMBFMGDBP(string AEAHKBEEEIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3500010", Offset = "0x34FEA10", VA = "0x183500010", Slot = "53")]
		private void LOLEHJLJGDF(object ILDKDHAKDFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x34FD000", Offset = "0x34FBA00", VA = "0x1834FD000", Slot = "54")]
		private void CAFPINKIIIJ(object ILDKDHAKDFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x34FE4A0", Offset = "0x34FCEA0", VA = "0x1834FE4A0", Slot = "28")]
		private bool GGGNPHMPIEJ([In] DAMMCLLGIFL AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x34FE1E0", Offset = "0x34FCBE0", VA = "0x1834FE1E0", Slot = "30")]
		private bool EOGLCDPLIKM([In] EGHKIPGFNHC AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3500F30", Offset = "0x34FF930", VA = "0x183500F30", Slot = "47")]
		private bool PLIFNPGBIBL([In] Guid NINCGKAKJEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x34FCFD0", Offset = "0x34FB9D0", VA = "0x1834FCFD0")]
		[CompilerGenerated]
		private string BKPNCJFAFNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x34FF260", Offset = "0x34FDC60", VA = "0x1834FF260")]
		[CompilerGenerated]
		private void IJOAEDKFPFF(string GKDOOPOCBPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class EPPODEFEPMN : BAPEOJAIIEM<FMFCIBMMFEI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC20500", Offset = "0xC1EF00", VA = "0x180C20500", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E46370", Offset = "0x1E44D70", VA = "0x181E46370")]
		public EPPODEFEPMN(IGHGHLPEJAC DGEHNBLILFB, FMFCIBMMFEI KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class NKEODIGEBDD : GBMMKHDMOAN<HKMNLBHMCLB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E52680", Offset = "0x1E51080", VA = "0x181E52680")]
		public NKEODIGEBDD(IGHGHLPEJAC DGEHNBLILFB, HKMNLBHMCLB KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JDCFLCFIBEJ<T> : EHELHGFELGD<T> where T : notnull, COGAJONNONG
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class PBGGMPJDMEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public IReadOnlyList<KeyValuePair<string, IBBHNDCDBDE>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public JDCFLCFIBEJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public OCCLPNFOLEO clipType;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public PBGGMPJDMEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			internal IReadOnlyList<KeyValuePair<string, IBBHNDCDBDE>> EBIDOKGKNKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x42D7E80", Offset = "0x42D6880", VA = "0x1842D7E80")]
			internal int JKHEINDOBNA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x42D8020", Offset = "0x42D6A20", VA = "0x1842D8020")]
			internal void LFAFFACJNIO(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x42D8240", Offset = "0x42D6C40", VA = "0x1842D8240")]
			internal void MJKGBCAGJIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x42D7FD0", Offset = "0x42D69D0", VA = "0x1842D7FD0")]
			internal float LEENDAKODMJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x42D7DD0", Offset = "0x42D67D0", VA = "0x1842D7DD0")]
			internal void IIEEMKLMHOM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x42D7D80", Offset = "0x42D6780", VA = "0x1842D7D80")]
			internal float GEDFMMCMPAM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x42D8290", Offset = "0x42D6C90", VA = "0x1842D8290")]
			internal void PDBAHHJGJBF(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x42D8340", Offset = "0x42D6D40", VA = "0x1842D8340")]
			internal float PPBBOJEPGFI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x42D7CD0", Offset = "0x42D66D0", VA = "0x1842D7CD0")]
			internal void BPFCAIKJNLB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8F29B0", Offset = "0x8F13B0", VA = "0x1808F29B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public abstract OCCLPNFOLEO PKBNLDNNOLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B2E0", Offset = "0x3C69CE0", VA = "0x183C6B2E0")]
		public JDCFLCFIBEJ(IGHGHLPEJAC DGEHNBLILFB, T KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AB30", Offset = "0x3C69530", VA = "0x183C6AB30", Slot = "119")]
		protected sealed override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class KAEIICOIKDK : EHELHGFELGD<LGKLNDAJENG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8F27D0", Offset = "0x8F11D0", VA = "0x1808F27D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B1C0", Offset = "0x1E49BC0", VA = "0x181E4B1C0")]
		public KAEIICOIKDK(IGHGHLPEJAC DGEHNBLILFB, LGKLNDAJENG KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class CJIGPGCAMPF : JDCFLCFIBEJ<KEBBIJBGDPN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override OCCLPNFOLEO PKBNLDNNOLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "125")]
			get
			{
				return default(OCCLPNFOLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C520", Offset = "0x1E3AF20", VA = "0x181E3C520")]
		public CJIGPGCAMPF(IGHGHLPEJAC DGEHNBLILFB, KEBBIJBGDPN KGDPHHJJNLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class HGNMANOAMKI : GBMMKHDMOAN<BJFCKPIMMPB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E48880", Offset = "0x1E47280", VA = "0x181E48880")]
		public HGNMANOAMKI(IGHGHLPEJAC DGEHNBLILFB, BJFCKPIMMPB KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class IMNGAACMOID : GBMMKHDMOAN<DNCEPNHGDJA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A450", Offset = "0x1E48E50", VA = "0x181E4A450")]
		public IMNGAACMOID(IGHGHLPEJAC DGEHNBLILFB, DNCEPNHGDJA KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class OFFHKHFLJIF : KJMMGCOAGNA<CPFCCLDAOAE>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class BANDHEPPIKE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public BANDHEPPIKE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x1E56580", Offset = "0x1E54F80", VA = "0x181E56580", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public OFFHKHFLJIF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public BANDHEPPIKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E3A960", Offset = "0x1E39360", VA = "0x181E3A960")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void NCDCMHPPPLP(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E53CE0", Offset = "0x1E526E0", VA = "0x181E53CE0")]
		public OFFHKHFLJIF(IGHGHLPEJAC DGEHNBLILFB, CPFCCLDAOAE KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E53A00", Offset = "0x1E52400", VA = "0x181E53A00", Slot = "125")]
		protected override void AGLAEPOJEAH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class OLGOLIELLCN : JDCFLCFIBEJ<CGCKGBHELGE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override OCCLPNFOLEO PKBNLDNNOLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x949E90", Offset = "0x948890", VA = "0x180949E90", Slot = "125")]
			get
			{
				return default(OCCLPNFOLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E54770", Offset = "0x1E53170", VA = "0x181E54770")]
		public OLGOLIELLCN(IGHGHLPEJAC DGEHNBLILFB, CGCKGBHELGE KGDPHHJJNLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class GDGMFOIBCDL : EHELHGFELGD<MBJKPOLFJJD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xC71580", Offset = "0xC6FF80", VA = "0x180C71580", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1E46FA0", Offset = "0x1E459A0", VA = "0x181E46FA0")]
		public GDGMFOIBCDL(IGHGHLPEJAC DGEHNBLILFB, MBJKPOLFJJD KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class OCFCDCNCJPP : EHELHGFELGD<ABMBJLAPKBG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Dictionary<string, IBBHNDCDBDE> MGNHEGKDGBA;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public sealed override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public sealed override bool MGKNPCGCPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected sealed override bool FDJNCIHHNPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1E53570", Offset = "0x1E51F70", VA = "0x181E53570")]
		public OCFCDCNCJPP(IGHGHLPEJAC DGEHNBLILFB, ABMBJLAPKBG KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1E53340", Offset = "0x1E51D40", VA = "0x181E53340", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1E53300", Offset = "0x1E51D00", VA = "0x181E53300")]
		private int ICINJEDBHNA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1E532A0", Offset = "0x1E51CA0", VA = "0x181E532A0")]
		private void DAMBPDIHBFK(int OPIDCOCFJHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class LKDIOIIDENI : KJMMGCOAGNA<AHIMGKONGPP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1E50500", Offset = "0x1E4EF00", VA = "0x181E50500")]
		public LKDIOIIDENI(IGHGHLPEJAC DGEHNBLILFB, AHIMGKONGPP KDIAAEPKAII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class KJMMGCOAGNA<TVariableNode> : EHELHGFELGD<TVariableNode> where TVariableNode : notnull, AHIMGKONGPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class PNFMACBLOJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public KJMMGCOAGNA<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public PNFMACBLOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x4315970", Offset = "0x4314370", VA = "0x184315970")]
			internal bool EBIDOKGKNKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x43159C0", Offset = "0x43143C0", VA = "0x1843159C0")]
			internal void JKHEINDOBNA(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4315B80", Offset = "0x4314580", VA = "0x184315B80")]
			internal bool LFAFFACJNIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4315BD0", Offset = "0x43145D0", VA = "0x184315BD0")]
			internal void MJKGBCAGJIG(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4315A70", Offset = "0x4314470", VA = "0x184315A70")]
			internal bool LEENDAKODMJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class JJBCGDAICEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public PJLALPJBKMI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public KJMMGCOAGNA<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public JJBCGDAICEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x3C7E6A0", Offset = "0x3C7D0A0", VA = "0x183C7E6A0")]
			internal void NCDCMHPPPLP(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x93AD80", Offset = "0x939780", VA = "0x18093AD80", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override DHHLBMJCLDL NJEFDLJKGNO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3D6FA50", Offset = "0x3D6E450", VA = "0x183D6FA50", Slot = "93")]
			get
			{
				return default(DHHLBMJCLDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F900", Offset = "0x3D6E300", VA = "0x183D6F900")]
		protected KJMMGCOAGNA(IGHGHLPEJAC DGEHNBLILFB, TVariableNode KDIAAEPKAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F2B0", Offset = "0x3D6DCB0", VA = "0x183D6F2B0", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F4B0", Offset = "0x3D6DEB0", VA = "0x183D6F4B0", Slot = "119")]
		protected override void MEBBNPJIOMH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6EF60", Offset = "0x3D6D960", VA = "0x183D6EF60", Slot = "125")]
		protected virtual void AGLAEPOJEAH(LNJHIAAAAND NDJIIBMIIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F3F0", Offset = "0x3D6DDF0", VA = "0x183D6F3F0", Slot = "104")]
		public override void EMPGGONCJIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CF90", Offset = "0x1E3B990", VA = "0x181E3CF90")]
	internal static GDLGGGHHOIM OLCPJHCMOKI(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class PIEMEADBOKK : ECJAFEPLEEF, ANPOBHNMKIK, OHBAIJGMMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public BOLDNJBHEHG<ICCAPPJDEGG> PADPEKOPIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xDE4200", Offset = "0xDE2C00", VA = "0x180DE4200", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(BOLDNJBHEHG<ICCAPPJDEGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BOLDNJBHEHG<JGMGJKCNGHI> CMMOBFEEJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x106BF60", Offset = "0x106A960", VA = "0x18106BF60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BOLDNJBHEHG<JGMGJKCNGHI>);
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1E552A0", Offset = "0x1E53CA0", VA = "0x181E552A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private BOLDNJBHEHG<LPAGCMFKGEH> BOAIIMOGNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA699B0", Offset = "0xA683B0", VA = "0x180A699B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public override BOLDNJBHEHG<HCGHMOECILC> ODMLCDCMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1E552B0", Offset = "0x1E53CB0", VA = "0x181E552B0", Slot = "20")]
		get
		{
			return default(BOLDNJBHEHG<HCGHMOECILC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1E55690", Offset = "0x1E54090", VA = "0x181E55690")]
	private PIEMEADBOKK(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII, MNIKKEBDEGB JPLLLGNMCEF, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<JGMGJKCNGHI> PPBIEIMLFDD, BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF, bool FLOOKPAMGPM, string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1E552F0", Offset = "0x1E53CF0", VA = "0x181E552F0")]
	public static PIEMEADBOKK OLCPJHCMOKI(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII, MNIKKEBDEGB LLFGKDLLLNF, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF, BOLDNJBHEHG<JGMGJKCNGHI> PPBIEIMLFDD, bool FLOOKPAMGPM, bool ALDNJOMOHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1E552A0", Offset = "0x1E53CA0", VA = "0x181E552A0")]
	internal void ANDNGFICKHM(BOLDNJBHEHG<JGMGJKCNGHI> AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class ECJAFEPLEEF : OHBAIJGMMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct JHAOAIBAACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private FNDKKMNFOEJ? NGOAABCMNDL;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AC10", Offset = "0x1E49610", VA = "0x181E4AC10")]
		public void LDCFGOINEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AB70", Offset = "0x1E49570", VA = "0x181E4AB70")]
		public FNDKKMNFOEJ DMJDGBDIKPJ(ECJAFEPLEEF PHNECNNNMBH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected readonly AOHIGHJIHBA OAMNOJGCMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private JHAOAIBAACL DDJGKOLAMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly NAMMLDOFLPP JHEGHCEALKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<DHGONLFCEIF> IPCOELJMMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly List<GDGOCDBBMKF> HEKINGINCDH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	[OKMJKJEMLAC("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> LFIGFHMBHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1E3EFD0", Offset = "0x1E3D9D0", VA = "0x181E3EFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DisplayKind JPCOPJEIFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7D24E0", Offset = "0x7D0EE0", VA = "0x1807D24E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public BOLDNJBHEHG<ADBOOFMFKMC> EICJLFJEAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F120", Offset = "0x1E3DB20", VA = "0x181E3F120", Slot = "6")]
		get
		{
			return default(BOLDNJBHEHG<ADBOOFMFKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CPNCACFPDBL<ADBOOFMFKMC> MKMMBBDDGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F970", Offset = "0x1E3E370", VA = "0x181E3F970", Slot = "7")]
		get
		{
			return default(CPNCACFPDBL<ADBOOFMFKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public LJGFGNEOPFB JGMIGKKALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1A32120", Offset = "0x1A30B20", VA = "0x181A32120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public INBFCOKPCOP FHJDEOPEGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1E3EF30", Offset = "0x1E3D930", VA = "0x181E3EF30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	protected FNDKKMNFOEJ JKPEONHBDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1E3EF30", Offset = "0x1E3D930", VA = "0x181E3EF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PortImage CLFJIAODNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F690", Offset = "0x1E3E090", VA = "0x181E3F690", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AE0", Offset = "0x7C84E0", VA = "0x1807C9AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CPNCACFPDBL<APJKLHNMCKH> KDMEOILOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1E3EEB0", Offset = "0x1E3D8B0", VA = "0x181E3EEB0", Slot = "9")]
		get
		{
			return default(CPNCACFPDBL<APJKLHNMCKH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public BOLDNJBHEHG<OIOOIEADMDH> OECNINJBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x877700", Offset = "0x876100", VA = "0x180877700", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(BOLDNJBHEHG<OIOOIEADMDH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xD372A0", Offset = "0xD35CA0", VA = "0x180D372A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract BOLDNJBHEHG<HCGHMOECILC> ODMLCDCMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F9A0", Offset = "0x1E3E3A0", VA = "0x181E3F9A0")]
	protected ECJAFEPLEEF(IGHGHLPEJAC DGEHNBLILFB, AOHIGHJIHBA KDIAAEPKAII, NAMMLDOFLPP CADBBPNNJIP, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, bool FLOOKPAMGPM, string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F2E0", Offset = "0x1E3DCE0", VA = "0x181E3F2E0", Slot = "21")]
	protected virtual void MPOMBMILLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ED60", Offset = "0x1E3D760", VA = "0x181E3ED60", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F430", Offset = "0x1E3DE30", VA = "0x181E3F430", Slot = "14")]
	public void NJLNPBGJBCP(DHGONLFCEIF DHCGHGOKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E550", Offset = "0x1E3CF50", VA = "0x181E3E550", Slot = "15")]
	public void ADFKDNPPPKN(GDGOCDBBMKF DHCGHGOKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E6E0", Offset = "0x1E3D0E0", VA = "0x181E3E6E0", Slot = "16")]
	public void DLOHIOCCGJP(MEFJDEBPGIB JEIMNOJMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EED0", Offset = "0x1E3D8D0", VA = "0x181E3EED0", Slot = "23")]
	protected virtual void ENLKGHOAIMK(MEFJDEBPGIB JEIMNOJMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F150", Offset = "0x1E3DB50", VA = "0x181E3F150")]
	private void MAPGPFJAGIN(bool GCGDEDCNCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F4E0", Offset = "0x1E3DEE0", VA = "0x181E3F4E0")]
	private void OCPILCJDIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F7C0", Offset = "0x1E3E1C0", VA = "0x181E3F7C0")]
	private void OGOPEGLJLEI([In] NMLJDNPBGJA AHCCIPEODFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E600", Offset = "0x1E3D000", VA = "0x181E3E600", Slot = "17")]
	public void AKCGAMEDDJJ(DHGONLFCEIF DHCGHGOKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E660", Offset = "0x1E3D060", VA = "0x181E3E660", Slot = "18")]
	public void APAFINMFJBG(GDGOCDBBMKF DHCGHGOKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AE0", Offset = "0x7C84E0", VA = "0x1807C9AE0")]
	internal void GHOPOJMPNMM(string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E6C0", Offset = "0x1E3D0C0", VA = "0x181E3E6C0")]
	internal void DBOJPBEPNLF(ILKLHEGILPI COBDDACEALE, LJGFGNEOPFB CGEOAHHPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0xD372A0", Offset = "0xD35CA0", VA = "0x180D372A0")]
	internal void FEPGILLEKAP(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class EIIEKECEBDB : DLHLLKIPNOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class HHGFHKAFBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public IGHGHLPEJAC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AOHIGHJIHBA node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public BOLDNJBHEHG<OIOOIEADMDH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HHGFHKAFBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1E48970", Offset = "0x1E47370", VA = "0x181E48970")]
		internal LGMHPCBBGGP PBGANNKHMDN((int PortDescIndex, int PortIndex, CNKFKBDECFB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1E488E0", Offset = "0x1E472E0", VA = "0x181E488E0")]
		internal PIEMEADBOKK INNKJNLDCCL(MNIKKEBDEGB i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct KHNPMJAOLEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B230", Offset = "0x1E49C30", VA = "0x181E4B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B690", Offset = "0x1E4A090", VA = "0x181E4B690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct BKKJDJPHIGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public BOLDNJBHEHG<KEJDHOACCFC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B580", Offset = "0x1E39F80", VA = "0x181E3B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B8D0", Offset = "0x1E3A2D0", VA = "0x181E3B8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct JBCKJBPDMAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public BOLDNJBHEHG<LPAGCMFKGEH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A4B0", Offset = "0x1E48EB0", VA = "0x181E4A4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A800", Offset = "0x1E49200", VA = "0x181E4A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct PCLKOKKKCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public BOLDNJBHEHG<KEJDHOACCFC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public BOLDNJBHEHG<KEJDHOACCFC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1E54B90", Offset = "0x1E53590", VA = "0x181E54B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1E54EE0", Offset = "0x1E538E0", VA = "0x181E54EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct PBEMLFAIMMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public BOLDNJBHEHG<LPAGCMFKGEH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public BOLDNJBHEHG<LPAGCMFKGEH> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1E547D0", Offset = "0x1E531D0", VA = "0x181E547D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1E54B20", Offset = "0x1E53520", VA = "0x181E54B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct KPIHOEEGCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BDA0", Offset = "0x1E4A7A0", VA = "0x181E4BDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C210", Offset = "0x1E4AC10", VA = "0x181E4C210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct OFJOJKPNJFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1E53D40", Offset = "0x1E52740", VA = "0x181E53D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1E54090", Offset = "0x1E52A90", VA = "0x181E54090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct FLKGNICKGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public BOLDNJBHEHG<KEJDHOACCFC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1E464B0", Offset = "0x1E44EB0", VA = "0x181E464B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1E46800", Offset = "0x1E45200", VA = "0x181E46800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct BLANADLNKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public BOLDNJBHEHG<LPAGCMFKGEH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B940", Offset = "0x1E3A340", VA = "0x181E3B940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E3BC90", Offset = "0x1E3A690", VA = "0x181E3BC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct CAGHAAPOBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public ENGGEPCMAGD type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BOLDNJBHEHG<KEJDHOACCFC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E3BD00", Offset = "0x1E3A700", VA = "0x181E3BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C090", Offset = "0x1E3AA90", VA = "0x181E3C090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct GJCMFADHHHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public EIIEKECEBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public ENGGEPCMAGD type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public BOLDNJBHEHG<LPAGCMFKGEH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private KPEHDMLEMPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E47270", Offset = "0x1E45C70", VA = "0x181E47270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E47600", Offset = "0x1E46000", VA = "0x181E47600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly bool MKMNLPBPNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly bool PIGHNDHJAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private BEDLNHHKGNB<GJPIAGLNEDD, LGMHPCBBGGP> MAPCOCJAFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private BEDLNHHKGNB<GJPIAGLNEDD, GPNEHIBKNCM> MOJMPKDBNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly AOHIGHJIHBA OAMNOJGCMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private BEDLNHHKGNB<JGMGJKCNGHI, PIEMEADBOKK> DIDELCKIMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private BEDLNHHKGNB<JGMGJKCNGHI, ANPOBHNMKIK> JOCLGHOBCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private string? KILLHBNGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly JJOGMCDAALH PKIGOBKNMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private BOLDNJBHEHG<OIOOIEADMDH> KEMFMJHGMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly bool MLILCJCOEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[CompilerGenerated]
	private Action? OKCMDPDKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[CompilerGenerated]
	private Action? KHCLOIBCJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[CompilerGenerated]
	private Action<BOLDNJBHEHG<GJPIAGLNEDD>>? MNGEFCGJFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[CompilerGenerated]
	private Action<BOLDNJBHEHG<JGMGJKCNGHI>>? HJGBJFBBBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[CompilerGenerated]
	private DLHLLKIPNOP.KEIPLBNLJNG? DPOBJIOFEIF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool DLFEDBJDPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1E43CC0", Offset = "0x1E426C0", VA = "0x181E43CC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LGKBNOIEFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1E41E10", Offset = "0x1E40810", VA = "0x181E41E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool GKOODODCCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E454F0", Offset = "0x1E43EF0", VA = "0x181E454F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public CPNCACFPDBL<ADBOOFMFKMC> MKMMBBDDGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1E44DB0", Offset = "0x1E437B0", VA = "0x181E44DB0", Slot = "7")]
		get
		{
			return default(CPNCACFPDBL<ADBOOFMFKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool LKJONECJHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1E424E0", Offset = "0x1E40EE0", VA = "0x181E424E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BEDLNHHKGNB<GJPIAGLNEDD, GPNEHIBKNCM> CNDGPAMNPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "9")]
		get
		{
			return default(BEDLNHHKGNB<GJPIAGLNEDD, GPNEHIBKNCM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1E43EA0", Offset = "0x1E428A0", VA = "0x181E43EA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public CPNCACFPDBL<APJKLHNMCKH> KDMEOILOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1E41C70", Offset = "0x1E40670", VA = "0x181E41C70", Slot = "11")]
		get
		{
			return default(CPNCACFPDBL<APJKLHNMCKH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BEDLNHHKGNB<JGMGJKCNGHI, ANPOBHNMKIK> IEAEIKICIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "12")]
		get
		{
			return default(BEDLNHHKGNB<JGMGJKCNGHI, ANPOBHNMKIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public BOLDNJBHEHG<OIOOIEADMDH> OECNINJBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0B0", Offset = "0xA68AB0", VA = "0x180A6A0B0", Slot = "13")]
		get
		{
			return default(BOLDNJBHEHG<OIOOIEADMDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action OLOEDACLCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1E45670", Offset = "0x1E44070", VA = "0x181E45670", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1E43610", Offset = "0x1E42010", VA = "0x181E43610", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action AJDGCCENMII
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1E43430", Offset = "0x1E41E30", VA = "0x181E43430", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1E40FE0", Offset = "0x1E3F9E0", VA = "0x181E40FE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<BOLDNJBHEHG<GJPIAGLNEDD>, BOLDNJBHEHG<GJPIAGLNEDD>> NFKBPOPCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1E42420", Offset = "0x1E40E20", VA = "0x181E42420", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1E44120", Offset = "0x1E42B20", VA = "0x181E44120", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<BOLDNJBHEHG<GJPIAGLNEDD>, BOLDNJBHEHG<GJPIAGLNEDD>> IHBDOMHGDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1E43F30", Offset = "0x1E42930", VA = "0x181E43F30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1E436B0", Offset = "0x1E420B0", VA = "0x181E436B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<BOLDNJBHEHG<JGMGJKCNGHI>, BOLDNJBHEHG<JGMGJKCNGHI>> MGIMDPBGLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1E40260", Offset = "0x1E3EC60", VA = "0x181E40260", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1E40F20", Offset = "0x1E3F920", VA = "0x181E40F20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<BOLDNJBHEHG<JGMGJKCNGHI>, BOLDNJBHEHG<JGMGJKCNGHI>> ICHIMMEOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1E43C00", Offset = "0x1E42600", VA = "0x181E43C00", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E41C90", Offset = "0x1E40690", VA = "0x181E41C90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BOLDNJBHEHG<GJPIAGLNEDD>, GPNEHIBKNCM> DEAPEPJHGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E441E0", Offset = "0x1E42BE0", VA = "0x181E441E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C10", Offset = "0x1E41610", VA = "0x181E42C10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BOLDNJBHEHG<GJPIAGLNEDD>> NHJKILLCHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E41D50", Offset = "0x1E40750", VA = "0x181E41D50", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1E41E50", Offset = "0x1E40850", VA = "0x181E41E50", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BOLDNJBHEHG<GJPIAGLNEDD>, GPNEHIBKNCM> AHOAFPENDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1E455B0", Offset = "0x1E43FB0", VA = "0x181E455B0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E45370", Offset = "0x1E43D70", VA = "0x181E45370", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<BOLDNJBHEHG<JGMGJKCNGHI>, ANPOBHNMKIK> LJBBBEAFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1E42680", Offset = "0x1E41080", VA = "0x181E42680", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1E41B90", Offset = "0x1E40590", VA = "0x181E41B90", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<BOLDNJBHEHG<JGMGJKCNGHI>> KGKIFKHGDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1E44300", Offset = "0x1E42D00", VA = "0x181E44300", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E40940", Offset = "0x1E3F340", VA = "0x181E40940", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<BOLDNJBHEHG<JGMGJKCNGHI>, ANPOBHNMKIK> CJKGHCLCNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1E40C30", Offset = "0x1E3F630", VA = "0x181E40C30", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1E45430", Offset = "0x1E43E30", VA = "0x181E45430", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1E45CD0", Offset = "0x1E446D0", VA = "0x181E45CD0")]
	private EIIEKECEBDB(bool FLOOKPAMGPM, IGHGHLPEJAC DGEHNBLILFB, bool KBANDGKIPOG, BEDLNHHKGNB<GJPIAGLNEDD, LGMHPCBBGGP> IPKJGKJIJFL, BEDLNHHKGNB<GJPIAGLNEDD, GPNEHIBKNCM> AEELFPDOOII, AOHIGHJIHBA KDIAAEPKAII, BEDLNHHKGNB<JGMGJKCNGHI, PIEMEADBOKK> LBGLMGPKEFM, BEDLNHHKGNB<JGMGJKCNGHI, ANPOBHNMKIK> JDCFKEAEHLG, string? LLCAGPMCMNH, JJOGMCDAALH FCBLHFLMLGO, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, bool ALDNJOMOHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1E44DE0", Offset = "0x1E437E0", VA = "0x181E44DE0")]
	public static EIIEKECEBDB OLCPJHCMOKI(bool FLOOKPAMGPM, IGHGHLPEJAC DGEHNBLILFB, bool KBANDGKIPOG, AOHIGHJIHBA KDIAAEPKAII, JJOGMCDAALH FCBLHFLMLGO, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, bool ALDNJOMOHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1E443C0", Offset = "0x1E42DC0", VA = "0x181E443C0")]
	private void MPOMBMILLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1E41090", Offset = "0x1E3FA90", VA = "0x181E41090", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1E40E30", Offset = "0x1E3F830", VA = "0x181E40E30", Slot = "38")]
	[AsyncStateMachine(typeof(KHNPMJAOLEK))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> DACJCJHOJBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1E40A00", Offset = "0x1E3F400", VA = "0x181E40A00")]
	private (HGPOENFGKGG, int)? CCBPJDEMNEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1E43210", Offset = "0x1E41C10", VA = "0x181E43210")]
	private void IENMILJLOAL(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x12A8BB0", Offset = "0x12A75B0", VA = "0x1812A8BB0")]
	private void HMCICNELMGH(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1E43770", Offset = "0x1E42170", VA = "0x181E43770")]
	private void KEDKNHNGIJD(int APMKBMCIBDJ, int DAOEMCFAGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1E43ED0", Offset = "0x1E428D0", VA = "0x181E43ED0")]
	private void LEKIIKDLPJC(int APMKBMCIBDJ, int DAOEMCFAGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1E40410", Offset = "0x1E3EE10", VA = "0x181E40410")]
	private void BMCFGNMLFDC(int AGFELDCANFM, BOLDNJBHEHG<GJPIAGLNEDD> APBJDOEDEDM, CNKFKBDECFB KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1E44B70", Offset = "0x1E43570", VA = "0x181E44B70")]
	private void NDPPAGBNBPJ(int GCGDEDCNCCJ, BOLDNJBHEHG<GJPIAGLNEDD> APBJDOEDEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1E40E10", Offset = "0x1E3F810", VA = "0x181E40E10")]
	private void CKIBPBAFFCO(int GCGDEDCNCCJ, BOLDNJBHEHG<GJPIAGLNEDD> APBJDOEDEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FE10", Offset = "0x1E3E810", VA = "0x181E3FE10")]
	private void AEJFKOFJDHJ(int AGFELDCANFM, BOLDNJBHEHG<GJPIAGLNEDD> APBJDOEDEDM, CNKFKBDECFB KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1E422D0", Offset = "0x1E40CD0", VA = "0x181E422D0")]
	private void FJAFJFPDMCF(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8A0D30", Offset = "0x89F730", VA = "0x1808A0D30")]
	private void GEFCOKPNLDJ(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1E40320", Offset = "0x1E3ED20", VA = "0x181E40320")]
	private void BLLGMBFGAIH(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x12A8BB0", Offset = "0x12A75B0", VA = "0x1812A8BB0")]
	private void FBDPDNODDIO(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1E42870", Offset = "0x1E41270", VA = "0x181E42870")]
	private void IBDNDGHONEN(int APMKBMCIBDJ, int DAOEMCFAGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1E442A0", Offset = "0x1E42CA0", VA = "0x181E442A0")]
	private void MKKBLAOBDNG(int APMKBMCIBDJ, int DAOEMCFAGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1E42CD0", Offset = "0x1E416D0", VA = "0x181E42CD0")]
	private void IEIJCJGGMOC(int AGFELDCANFM, BOLDNJBHEHG<JGMGJKCNGHI> APBJDOEDEDM, MNIKKEBDEGB KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1E41C50", Offset = "0x1E40650", VA = "0x181E41C50")]
	private void EJAMLBLFPLI(int GCGDEDCNCCJ, BOLDNJBHEHG<JGMGJKCNGHI> APBJDOEDEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1E45350", Offset = "0x1E43D50", VA = "0x181E45350")]
	private void OLLFKDPONHO(int GCGDEDCNCCJ, BOLDNJBHEHG<JGMGJKCNGHI> APBJDOEDEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1E45710", Offset = "0x1E44110", VA = "0x181E45710")]
	private void PLDHPOFJLKE(int AGFELDCANFM, BOLDNJBHEHG<JGMGJKCNGHI> APBJDOEDEDM, MNIKKEBDEGB KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1E45B80", Offset = "0x1E44580", VA = "0x181E45B80")]
	private void PNBFBINBDJN(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x8A0D30", Offset = "0x89F730", VA = "0x1808A0D30")]
	private void GINIKNJHLDC(int AGFELDCANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1E44CA0", Offset = "0x1E436A0", VA = "0x181E44CA0", Slot = "39")]
	[AsyncStateMachine(typeof(BKKJDJPHIGC))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> NODFFOCMNGA(BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1E44B90", Offset = "0x1E43590", VA = "0x181E44B90", Slot = "40")]
	[AsyncStateMachine(typeof(JBCKJBPDMAD))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> NHOOAGNOLDJ(BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1E40CF0", Offset = "0x1E3F6F0", VA = "0x181E40CF0", Slot = "41")]
	[AsyncStateMachine(typeof(PCLKOKKKCLA))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> CEEFEOMCKHK(BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP, BOLDNJBHEHG<KEJDHOACCFC> EPPBHCBDELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1E42560", Offset = "0x1E40F60", VA = "0x181E42560", Slot = "42")]
	[AsyncStateMachine(typeof(PBEMLFAIMMC))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> GKLLAEKLJKK(BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF, BOLDNJBHEHG<LPAGCMFKGEH> EPPBHCBDELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1E43B10", Offset = "0x1E42510", VA = "0x181E43B10", Slot = "43")]
	[AsyncStateMachine(typeof(KPIHOEEGCAO))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> KEJDNOOEPHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1E43D80", Offset = "0x1E42780", VA = "0x181E43D80", Slot = "44")]
	[AsyncStateMachine(typeof(OFJOJKPNJFC))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> LBHECBMLGNG(string AEAHKBEEEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1E43300", Offset = "0x1E41D00", VA = "0x181E43300", Slot = "45")]
	[AsyncStateMachine(typeof(FLKGNICKGIL))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> IKFLKCBJHHM(BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP, string GKDOOPOCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1E42740", Offset = "0x1E41140", VA = "0x181E42740", Slot = "46")]
	[AsyncStateMachine(typeof(BLANADLNKCG))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> HMMFMPKJNIM(BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF, string GKDOOPOCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1E43FF0", Offset = "0x1E429F0", VA = "0x181E43FF0", Slot = "47")]
	[AsyncStateMachine(typeof(CAGHAAPOBBE))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> MFKKDJMBILN(BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP, ENGGEPCMAGD CGEOAHHPHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1E434E0", Offset = "0x1E41EE0", VA = "0x181E434E0", Slot = "48")]
	[AsyncStateMachine(typeof(GJCMFADHHHI))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> JFDKKDIGJPE(BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF, ENGGEPCMAGD CGEOAHHPHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1E41F10", Offset = "0x1E40910", VA = "0x181E41F10")]
	internal void FEPGILLEKAP(BOLDNJBHEHG<OIOOIEADMDH> AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class MHKHOIOAOKB : CLGOAAEIPHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface KNHBMIPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		ILKLHEGILPI NNLDBGAIGMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JDDHADDGFLN> CLNNHLNLNCN(CancellationToken CFAFANOFDNJ);

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<NHPAEOGMHIC> JLACBJAOPBD(CancellationToken CFAFANOFDNJ);

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JDCCNMIHMFO> OPAHPEEJAGJ(CancellationToken CFAFANOFDNJ);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct PPIICBNIOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public AsyncTaskMethodBuilder<MHKHOIOAOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public IGHGHLPEJAC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public JDDHADDGFLN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public NHPAEOGMHIC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private KNHBMIPBGEP <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private NHPAEOGMHIC <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<JDDHADDGFLN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<NHPAEOGMHIC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<JDCCNMIHMFO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter<GCFHKIJAPKL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E55B00", Offset = "0x1E54500", VA = "0x181E55B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E56510", Offset = "0x1E54F10", VA = "0x181E56510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly GCFHKIJAPKL HMDIPPIJIDA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public GCFHKIJAPKL BLOFKIPKMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	private MHKHOIOAOKB(GCFHKIJAPKL OJKINMHNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x1E516A0", Offset = "0x1E500A0", VA = "0x181E516A0")]
	[AsyncStateMachine(typeof(PPIICBNIOMJ))]
	public static Task<MHKHOIOAOKB> PAHKOIFMMME(IGHGHLPEJAC DGEHNBLILFB, JDDHADDGFLN? GOGGOGGMFEP, NHPAEOGMHIC? AOFALACDKEP, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1E51680", Offset = "0x1E50080", VA = "0x181E51680", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct NKOHOGAIMBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct ENGIDAEODHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public NKOHOGAIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public PIADNJODOCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D710", Offset = "0x1E5C110", VA = "0x181E5D710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D910", Offset = "0x1E5C310", VA = "0x181E5D910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct BCCABDPGMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<bool, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public JJBFONMHECH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public JDDHADDGFLN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public NHPAEOGMHIC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public NKOHOGAIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private PIADNJODOCI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E58150", Offset = "0x1E56B50", VA = "0x181E58150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E58530", Offset = "0x1E56F30", VA = "0x181E58530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct EFMMIMAINGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public NKOHOGAIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D460", Offset = "0x1E5BE60", VA = "0x181E5D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D6A0", Offset = "0x1E5C0A0", VA = "0x181E5D6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly FDBLMCDEPNP CPGFAOBIDIB;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	public NKOHOGAIMBP(FDBLMCDEPNP KBMHLGEFDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E61500", Offset = "0x1E5FF00", VA = "0x181E61500")]
	[AsyncStateMachine(typeof(ENGIDAEODHM))]
	private Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> JGHIONECKEH(PIADNJODOCI HKIJJKKNOIF, bool GDDNBDKGFBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1E61720", Offset = "0x1E60120", VA = "0x181E61720")]
	[AsyncStateMachine(typeof(BCCABDPGMAM))]
	public Task<LGGHGMLBJFM<bool, DGFMPJAMJNO?>>? MGHGINMNLNA(int CIJBKMKFJME, JJBFONMHECH? EHICCJEFNJM, JDDHADDGFLN? FMJIOPLOAJN, NHPAEOGMHIC? AOFALACDKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E61630", Offset = "0x1E60030", VA = "0x181E61630")]
	[AsyncStateMachine(typeof(EFMMIMAINGK))]
	public Task<LGGHGMLBJFM<PHKKIFFGKBG, DGFMPJAMJNO>> KDNFCEDEOOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class MHKBGANJGAG : CHJMCIBJDKP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly OHPJPPILBAE AEOCKKNNBGM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public OHPJPPILBAE FJBJCBADMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	private MHKBGANJGAG(OHPJPPILBAE HHMPEAOOLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E61320", Offset = "0x1E5FD20", VA = "0x181E61320")]
	public static MHKBGANJGAG HIBHLHEFCGJ(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E61300", Offset = "0x1E5FD00", VA = "0x181E61300", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface FLKKGLJNIDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	PCNNJGKJEMD HCKHOEOGDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	ENNIFEMKOHC COJLAAELABM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	JJGKKDNKGAM OCHCLHCHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	MDEDMHBHNFJ IENBEGAFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	BNIKIGCHKEJ LMJDMAJCPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface PCOEICMFPIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	FLKKGLJNIDA? FONKOPNOOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool EIBMNNDPKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<FLKKGLJNIDA?>? EDOACMAINLA();

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BHFHBKKEPDF(IGHGHLPEJAC DGEHNBLILFB, JJBFONMHECH OFOADDOAIHE, JDDHADDGFLN? IAAEPPPGJAP, NHPAEOGMHIC? KMOBHAGJGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IDKPDNLJBNL("IStaticCV2Instance")]
public interface CLGOAAEIPHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	GCFHKIJAPKL BLOFKIPKMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[IDKPDNLJBNL("IStaticEVInstance")]
public interface CHJMCIBJDKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	OHPJPPILBAE FJBJCBADMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class FKPPFJELKJE : BDCIPLBEFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public FPHAEMDINLO? AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DC70", Offset = "0x1E5C670", VA = "0x181E5DC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	internal FKPPFJELKJE(IGHGHLPEJAC DGEHNBLILFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class MDEDMHBHNFJ : FPHAEMDINLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly CLGOAAEIPHG EOBLNFOPFCF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AHOHIBKDEAI JGHIONECKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E61250", Offset = "0x1E5FC50", VA = "0x181E61250", Slot = "4")]
		get
		{
			return default(AHOHIBKDEAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IDJFGDPEEOM PHHPOJCLLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E61120", Offset = "0x1E5FB20", VA = "0x181E61120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public CPNCACFPDBL<ADBOOFMFKMC> FNDLCNPPMON
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E61180", Offset = "0x1E5FB80", VA = "0x181E61180", Slot = "6")]
		get
		{
			return default(CPNCACFPDBL<ADBOOFMFKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GCFHKIJAPKL PGBMHCDNOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E612B0", Offset = "0x1E5FCB0", VA = "0x181E612B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public MDEDMHBHNFJ(CLGOAAEIPHG HCJDMNONFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E611E0", Offset = "0x1E5FBE0", VA = "0x181E611E0")]
	public bool OECAJCKPLOO([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E611E0", Offset = "0x1E5FBE0", VA = "0x181E611E0", Slot = "8")]
	private bool GAFNCOEKDOD([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class KLDJBLPPAHL
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E60370", Offset = "0x1E5ED70", VA = "0x181E60370")]
	public static CAJHKKDKNDJ<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> PEIEHKGDOIA([In] this CAJHKKDKNDJ<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>> LEDMADPLELG)
	{
		return default(CAJHKKDKNDJ<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC, LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class KBCLJPEHIND : IPDNAFPELKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EIBMNNDPKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E60350", Offset = "0x1E5ED50", VA = "0x181E60350", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	internal KBCLJPEHIND(IGHGHLPEJAC DGEHNBLILFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class DLGDGFOABNK : AHNLJOCMCHP
{
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E5D3C0", Offset = "0x1E5BDC0", VA = "0x181E5D3C0", Slot = "4")]
	public IBAPHPFILIH? CJEMLNFKMHA(string? ADBLBKANJBN, string? GGCBIPDIEIF, string? IIODHBOKDIN, EBNNCKGHPPI.AHOCNFEALJM.IDCHNKABPOL KBGEDGNEIGF, bool FIBKNKIONOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DLGDGFOABNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class ODJEHMIEOOL : JKPELDGDDPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct HDEMEEBECBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<MFPBKKFPNCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public ODJEHMIEOOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter<FLKKGLJNIDA?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E5F840", Offset = "0x1E5E240", VA = "0x181E5F840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E5FAE0", Offset = "0x1E5E4E0", VA = "0x181E5FAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private IReadOnlyList<CPNCACFPDBL<EFGKAOAPDDH>>? PHBAMIKEBBP;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MFPBKKFPNCD? AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E61C60", Offset = "0x1E60660", VA = "0x181E61C60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BNIKIGCHKEJ? EOBGILKCECE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E61D20", Offset = "0x1E60720", VA = "0x181E61D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool LGNNCJFGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E61AD0", Offset = "0x1E604D0", VA = "0x181E61AD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool IGOGEFMBFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E61DA0", Offset = "0x1E607A0", VA = "0x181E61DA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	internal ODJEHMIEOOL(IGHGHLPEJAC DGEHNBLILFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E61B30", Offset = "0x1E60530", VA = "0x181E61B30", Slot = "7")]
	[AsyncStateMachine(typeof(HDEMEEBECBJ))]
	public Task<MFPBKKFPNCD> JEBAEEDDACA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E62070", Offset = "0x1E60A70", VA = "0x181E62070")]
	internal Dictionary<CPNCACFPDBL<ADBOOFMFKMC>, Guid> OMPJKGLLNAG(IEnumerable<FDEHGBEEAOL> DNDMAFPCMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E61E00", Offset = "0x1E60800", VA = "0x181E61E00")]
	public LGGHGMLBJFM<HMABJIECFDB, CEAFENKMCFB> OLGFPAKONPJ([In] HMABJIECFDB MEKMDKPLJCE, IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ, int FAKMBPKABFI)
	{
		return default(LGGHGMLBJFM<HMABJIECFDB, CEAFENKMCFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E61C20", Offset = "0x1E60620", VA = "0x181E61C20")]
	internal static EJIJEHCDMIF KGOGGMOLFBB(KJPPDMNPGFJ OAHIHAGGBFG, AOHIGHJIHBA KDIAAEPKAII)
	{
		return default(EJIJEHCDMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E61CE0", Offset = "0x1E606E0", VA = "0x181E61CE0", Slot = "8")]
	private LGGHGMLBJFM<HMABJIECFDB, CEAFENKMCFB> KNCCPNPDAMG([In] HMABJIECFDB MEKMDKPLJCE, IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ, int FAKMBPKABFI)
	{
		return default(LGGHGMLBJFM<HMABJIECFDB, CEAFENKMCFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E61880", Offset = "0x1E60280", VA = "0x181E61880")]
	[CompilerGenerated]
	internal static EJIJEHCDMIF EELAADAOJON(KJPPDMNPGFJ FLNOEKGDHOK, AOHIGHJIHBA OLKDNDNGFBA)
	{
		return default(EJIJEHCDMIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class BNIKIGCHKEJ : MFPBKKFPNCD
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class CBGGINPEIJL
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class HNCPPGCGAHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public GCFHKIJAPKL state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public DEPOAGBIECE spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public HNCPPGCGAHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1E5FC60", Offset = "0x1E5E660", VA = "0x181E5FC60")]
			internal bool ELJIAJMEIKN(CPDENFKGNHP n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class JCCOLEMNEGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public JCCOLEMNEGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1E60330", Offset = "0x1E5ED30", VA = "0x181E60330")]
			internal void DAAHDCOCLCG(CPDENFKGNHP n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1E5BAD0", Offset = "0x1E5A4D0", VA = "0x181E5BAD0")]
		public static LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB> JGEDHJJKDOM(BNIKIGCHKEJ CMJEIEIDHIK, [In] MFPBKKFPNCD.LHJBFOEBIFD CADHKPGCKBL)
		{
			return default(LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1E5C410", Offset = "0x1E5AE10", VA = "0x181E5C410")]
		internal static LGGHGMLBJFM<(OCFINGGNBFO, EFIHLPHAJKG), DGFMPJAMJNO> LMKMOJCBFDA(BNIKIGCHKEJ CMJEIEIDHIK, EFIHLPHAJKG EMMMJJJIHNC, bool IIBPIEKKDHO, [In] CPNCACFPDBL<ADBOOFMFKMC> CFCGACFOOED, [In] int? MOEJNCLMPJF, [In] EJIJEHCDMIF? MKAHCJDNFLL, [In] EJIJEHCDMIF? ILKLHEPHIEN)
		{
			return default(LGGHGMLBJFM<(OCFINGGNBFO, EFIHLPHAJKG), DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B690", Offset = "0x1E5A090", VA = "0x181E5B690")]
		private static void CKIGCGJAJKF(bool IIBPIEKKDHO, FDEHGBEEAOL FLLKCMLDGED, OCFINGGNBFO GBDJEHKEDAH, [In] CPNCACFPDBL<ADBOOFMFKMC> CFCGACFOOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5C010", Offset = "0x1E5AA10", VA = "0x181E5C010")]
		public static void LDPEFFGOFDC(CIAKKFHNFNK OOAEFEPJFOI, [In] MFPBKKFPNCD.NMGAIMNPMAF MIMIOAFCKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D230", Offset = "0x1E5BC30", VA = "0x181E5D230")]
		[CompilerGenerated]
		internal static bool MDGHLHFEAAN(GCFHKIJAPKL IMDDDPDPKGL, DEPOAGBIECE HJLBBACLDOE, CPDENFKGNHP ODGCMBIBMBO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly IGHGHLPEJAC JCJEKHBNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly CLGOAAEIPHG EOBLNFOPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly CHJMCIBJDKP MOBNCODAGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly IGICNCDAAGH DJJJFMEMAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly ODJEHMIEOOL CIJOAECEDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Dictionary<CPNCACFPDBL<APJKLHNMCKH>, GDLGGGHHOIM> ABGFHJENGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[CompilerGenerated]
	private Action<CPNCACFPDBL<APJKLHNMCKH>>? OLKKCDJHDLE;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B170", Offset = "0x1E59B70", VA = "0x181E5B170")]
	public BNIKIGCHKEJ(IGHGHLPEJAC DGEHNBLILFB, CLGOAAEIPHG HCJDMNONFOG, CHJMCIBJDKP FPGGJHOJDEO, ODJEHMIEOOL HJMAIMGDFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E59500", Offset = "0x1E57F00", VA = "0x181E59500", Slot = "4")]
	public bool DJGDENMLBJB(BOLDNJBHEHG<ADBOOFMFKMC> NINCGKAKJEG, BOLDNJBHEHG<ICCAPPJDEGG> DIMCALCGNNN, BOLDNJBHEHG<NDKJHIALBDD> NONNOOALJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E58940", Offset = "0x1E57340", VA = "0x181E58940")]
	public GDLGGGHHOIM? CDGKDNIBGHB([In] CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A740", Offset = "0x1E59140", VA = "0x181E5A740")]
	private void HNJPJPDPMML(CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A8F0", Offset = "0x1E592F0", VA = "0x181E5A8F0")]
	public IEnumerable<GDLGGGHHOIM> IGBPOKAKDJF([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A7D0", Offset = "0x1E591D0", VA = "0x181E5A7D0")]
	private GDLGGGHHOIM? HPBIHBLPHAJ([In] CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A440", Offset = "0x1E58E40", VA = "0x181E5A440")]
	private GDLGGGHHOIM FIKDBNMJOBD([In] CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA, AOHIGHJIHBA KDIAAEPKAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E588B0", Offset = "0x1E572B0", VA = "0x181E588B0")]
	public AOHIGHJIHBA? BFJINGCKHGI([In] CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E58690", Offset = "0x1E57090", VA = "0x181E58690")]
	public HMJNJCIKJKO? AKMAOAGJCDL([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B0D0", Offset = "0x1E59AD0", VA = "0x181E5B0D0")]
	private DEPOAGBIECE? PFJJDMGKGCP([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E58690", Offset = "0x1E57090", VA = "0x181E58690")]
	private HMJNJCIKJKO? JIEKNMPPKII([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A510", Offset = "0x1E58F10", VA = "0x181E5A510", Slot = "10")]
	public CPNCACFPDBL<ADBOOFMFKMC> GFGHGFCFOCJ(BOLDNJBHEHG<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return default(CPNCACFPDBL<ADBOOFMFKMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E58600", Offset = "0x1E57000", VA = "0x181E58600")]
	public BOLDNJBHEHG<NDKJHIALBDD> ACDBCPDNODP(BOLDNJBHEHG<ADBOOFMFKMC> NINCGKAKJEG, BOLDNJBHEHG<APJKLHNMCKH> BKJEPPHMINA, int CNMAIPJGLBA)
	{
		return default(BOLDNJBHEHG<NDKJHIALBDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AE60", Offset = "0x1E59860", VA = "0x181E5AE60")]
	public BOLDNJBHEHG<ICCAPPJDEGG> MKBKEJIMIOL(BOLDNJBHEHG<ADBOOFMFKMC> NINCGKAKJEG, BOLDNJBHEHG<APJKLHNMCKH> BKJEPPHMINA, int CIMCDJJDLGL)
	{
		return default(BOLDNJBHEHG<ICCAPPJDEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AFD0", Offset = "0x1E599D0", VA = "0x181E5AFD0", Slot = "8")]
	public IEnumerable<ENGGEPCMAGD> OBOFNEOEAGO(HCGKFBIIIEE JDEBBALEFHA, bool DFJLCMPIHFP, bool BJHBBJMHMMH, bool FPPDJEBJGNH, bool CAEDMHJCJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AB80", Offset = "0x1E59580", VA = "0x181E5AB80", Slot = "9")]
	public ENGGEPCMAGD KCKEGFNPLMI(HCGKFBIIIEE JDEBBALEFHA, OHBAIJGMMJL OKDLBACBBDJ, bool DFJLCMPIHFP, bool BJHBBJMHMMH, bool FPPDJEBJGNH, bool CAEDMHJCJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A5F0", Offset = "0x1E58FF0", VA = "0x181E5A5F0")]
	public LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB> HOOHPGKFIJN([In] MFPBKKFPNCD.LHJBFOEBIFD CADHKPGCKBL)
	{
		return default(LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E58AB0", Offset = "0x1E574B0", VA = "0x181E58AB0", Slot = "12")]
	public LGGHGMLBJFM<LDCNFOCPBHM, CEAFENKMCFB> CJAGBFHHFDG(CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG, LDCNFOCPBHM FJFGBEAMFGP, EGHKIPGFNHC BGLEIBEIGMJ)
	{
		return default(LGGHGMLBJFM<LDCNFOCPBHM, CEAFENKMCFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E586C0", Offset = "0x1E570C0", VA = "0x181E586C0", Slot = "13")]
	public HLOLJNOLOPH BAANLLHEONM(IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ)
	{
		return default(HLOLJNOLOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A620", Offset = "0x1E59020", VA = "0x181E5A620", Slot = "14")]
	public HLOLJNOLOPH HMPKBKMDEBN()
	{
		return default(HLOLJNOLOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E59D90", Offset = "0x1E58790", VA = "0x181E59D90")]
	private DDGBEIAEPJC DLEMKEICIBL(OFKGLIOOCPC CEBHCOHGLMJ, BOLDNJBHEHG<ADBOOFMFKMC> EJKIICCFDEN, IEnumerable<CPNCACFPDBL<ADBOOFMFKMC>> IFKAFDLLAAP, IEnumerable<CPNCACFPDBL<APJKLHNMCKH>> FIEIGHAKNIK)
	{
		return default(DDGBEIAEPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E59A50", Offset = "0x1E58450", VA = "0x181E59A50", Slot = "15")]
	public DDGBEIAEPJC DLEMKEICIBL(OFKGLIOOCPC CEBHCOHGLMJ, BOLDNJBHEHG<ADBOOFMFKMC> EJKIICCFDEN, IEnumerable<CPNCACFPDBL<APJKLHNMCKH>> FIEIGHAKNIK, IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ)
	{
		return default(DDGBEIAEPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A030", Offset = "0x1E58A30", VA = "0x181E5A030")]
	private static IEnumerable<CPNCACFPDBL<ADBOOFMFKMC>> FAMIOONMNIA(IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E59050", Offset = "0x1E57A50", VA = "0x181E59050")]
	private IEnumerable<CPNCACFPDBL<APJKLHNMCKH>> DJDKALEMFOB(IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A3B0", Offset = "0x1E58DB0", VA = "0x181E5A3B0", Slot = "16")]
	public List<GPCDBHNMONM> FCFOGHJMPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A9D0", Offset = "0x1E593D0", VA = "0x181E5A9D0", Slot = "17")]
	public bool JFHMMJAIMIG(BOLDNJBHEHG<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E58EA0", Offset = "0x1E578A0", VA = "0x181E58EA0")]
	internal void CNFDOLMEALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AF70", Offset = "0x1E59970", VA = "0x181E5AF70")]
	internal Task NDNJKDHBHGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1E58690", Offset = "0x1E57090", VA = "0x181E58690", Slot = "5")]
	private HMJNJCIKJKO DCGOHKPBANL([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1E58F00", Offset = "0x1E57900", VA = "0x181E58F00", Slot = "6")]
	private GDLGGGHHOIM DGPNDMCACOH([In] CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AAA0", Offset = "0x1E594A0", VA = "0x181E5AAA0", Slot = "7")]
	private IEnumerable<GDLGGGHHOIM> KAAJIGHDEGM([In] CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A5F0", Offset = "0x1E58FF0", VA = "0x181E5A5F0", Slot = "11")]
	private LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB> HDAOPAJFBII([In] MFPBKKFPNCD.LHJBFOEBIFD CADHKPGCKBL)
	{
		return default(LGGHGMLBJFM<MFPBKKFPNCD.LPAAEDDMHPG, CEAFENKMCFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1E59F40", Offset = "0x1E58940", VA = "0x181E59F40")]
	[CompilerGenerated]
	private GDLGGGHHOIM EOGBKLAIGBJ(AOHIGHJIHBA AJODNFJNJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1E5AEF0", Offset = "0x1E598F0", VA = "0x181E5AEF0")]
	[CompilerGenerated]
	private PBIMDKNLIBI MNECMCCKHJF(LJGFGNEOPFB AJODNFJNJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A580", Offset = "0x1E58F80", VA = "0x181E5A580")]
	[CompilerGenerated]
	private AOHIGHJIHBA HAFOLIAAOGO(CPNCACFPDBL<APJKLHNMCKH> AJODNFJNJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A880", Offset = "0x1E59280", VA = "0x181E5A880")]
	[CompilerGenerated]
	private DEPOAGBIECE ICEEBGAOPNK(CPNCACFPDBL<ADBOOFMFKMC> AJODNFJNJPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class PBIMDKNLIBI : ENGGEPCMAGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct EPDMFIHGKHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<BOLDNJBHEHG<KEJDHOACCFC>, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public PBIMDKNLIBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public CPNCACFPDBL<ADBOOFMFKMC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public CPNCACFPDBL<APJKLHNMCKH> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public BOLDNJBHEHG<OIOOIEADMDH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter<LGGHGMLBJFM<BOLDNJBHEHG<KEJDHOACCFC>, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D980", Offset = "0x1E5C380", VA = "0x181E5D980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DC00", Offset = "0x1E5C600", VA = "0x181E5DC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct AFGINFIALHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<BOLDNJBHEHG<LPAGCMFKGEH>, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public PBIMDKNLIBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public CPNCACFPDBL<ADBOOFMFKMC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CPNCACFPDBL<APJKLHNMCKH> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public BOLDNJBHEHG<OIOOIEADMDH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<LGGHGMLBJFM<BOLDNJBHEHG<LPAGCMFKGEH>, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E57BE0", Offset = "0x1E565E0", VA = "0x181E57BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1E57E60", Offset = "0x1E56860", VA = "0x181E57E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly LJGFGNEOPFB DLOFJOAGPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly CLGOAAEIPHG EOBLNFOPFCF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public TypeKey HPGCAJEMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string OKPOLFPFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1E5E170", Offset = "0x1E5CB70", VA = "0x181E5E170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public LJGFGNEOPFB GIJMMMJPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1E626C0", Offset = "0x1E610C0", VA = "0x181E626C0")]
	public PBIMDKNLIBI(LJGFGNEOPFB KFBJCDGJHHC, CLGOAAEIPHG HCJDMNONFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1E62550", Offset = "0x1E60F50", VA = "0x181E62550", Slot = "6")]
	[AsyncStateMachine(typeof(EPDMFIHGKHI))]
	public Task<LGGHGMLBJFM<BOLDNJBHEHG<KEJDHOACCFC>, DGFMPJAMJNO>> KJFHAMHBAHD(CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG, CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, string GKDOOPOCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1E623E0", Offset = "0x1E60DE0", VA = "0x181E623E0", Slot = "7")]
	[AsyncStateMachine(typeof(AFGINFIALHB))]
	public Task<LGGHGMLBJFM<BOLDNJBHEHG<LPAGCMFKGEH>, DGFMPJAMJNO>> HPOIOKJKMGG(CPNCACFPDBL<ADBOOFMFKMC> NINCGKAKJEG, CPNCACFPDBL<APJKLHNMCKH> BKJEPPHMINA, BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG, string GKDOOPOCBPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class FNDKKMNFOEJ : INBFCOKPCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly LJGFGNEOPFB IGFGDBIIGID;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly HashSet<LJGFGNEOPFB> EADIAEENJEN;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly HashSet<LJGFGNEOPFB> HBGPIMJEEGD;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly HashSet<LJGFGNEOPFB> AKNGMLONEKE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public TypeKey ILKHIKNJEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5F2C0", Offset = "0x1E5DCC0", VA = "0x181E5F2C0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CLGEICGEMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1E5F2B0", Offset = "0x1E5DCB0", VA = "0x181E5F2B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FCOCFNNLIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1E5F310", Offset = "0x1E5DD10", VA = "0x181E5F310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PBNCBMCBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1E5F230", Offset = "0x1E5DC30", VA = "0x181E5F230", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DF00", Offset = "0x1E5C900", VA = "0x181E5DF00")]
	public bool KLJFNHDHDBD(string AEJBOLFACJC, [Out] IPIOFGCMKBC KPDLIJMJNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public FNDKKMNFOEJ(LJGFGNEOPFB KGDPHHJJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DD70", Offset = "0x1E5C770", VA = "0x181E5DD70")]
	internal static TypeKey KJLNOPILAMN(LJGFGNEOPFB CGEOAHHPHHK)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1E5E170", Offset = "0x1E5CB70", VA = "0x181E5E170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct FNMCECOIHJG : BFBIFBHLOKO.EDBHPBHJBAD<PIADNJODOCI, PHKKIFFGKBG>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F480", Offset = "0x1E5DE80", VA = "0x181E5F480", Slot = "4")]
	public int AODMFPABJNE(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F550", Offset = "0x1E5DF50", VA = "0x181E5F550", Slot = "5")]
	public PIADNJODOCI NADIJJEMGJP(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F450", Offset = "0x1E5DE50", VA = "0x181E5F450", Slot = "6")]
	public PIADNJODOCI AEPDHCGPIBH(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F4E0", Offset = "0x1E5DEE0", VA = "0x181E5F4E0", Slot = "7")]
	public IReadOnlyList<PIADNJODOCI> HIBBOOOAJOL(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F500", Offset = "0x1E5DF00", VA = "0x181E5F500", Slot = "8")]
	public PIADNJODOCI[] JHEBGNCNHEF(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF, int JFFMKAFAFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F530", Offset = "0x1E5DF30", VA = "0x181E5F530", Slot = "9")]
	public bool NAABNLKHGAK(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F510", Offset = "0x1E5DF10", VA = "0x181E5F510", Slot = "10")]
	public bool JNEHNDGKLNK(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F4A0", Offset = "0x1E5DEA0", VA = "0x181E5F4A0", Slot = "11")]
	public bool EDOFENGACLI(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F560", Offset = "0x1E5DF60", VA = "0x181E5F560", Slot = "12")]
	public bool NGBIFFJPPEG(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F4C0", Offset = "0x1E5DEC0", VA = "0x181E5F4C0", Slot = "13")]
	public bool FGJCDLBGJMC(PHKKIFFGKBG CJPLBPAGEKE, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F430", Offset = "0x1E5DE30", VA = "0x181E5F430", Slot = "14")]
	public bool AAKCLCICPJK(PHKKIFFGKBG GCGDEDCNCCJ, PIADNJODOCI HKIJJKKNOIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class CGJNGNDIKBE : OINADJBBGIM
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OLEBJKAMFBN.AEFOBHFPENK GPMHEFKMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D320", Offset = "0x1E5BD20", VA = "0x181E5D320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract BKFJOOBDPHK.HBMMNMAFGFF NKEFMBMJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract IGHGHLPEJAC.DCOOCGDJEGB NMJKFCFMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract MHKHOIOAOKB.KNHBMIPBGEP LMGMPJGJNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public LBFJEAANEBJ.IHFHEHLCCJG<GCNNJGFCDBH, PIADNJODOCI, IGHGHLPEJAC> BHLOGAJIELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1E5D370", Offset = "0x1E5BD70", VA = "0x181E5D370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract KPEHDMLEMPN GBCHJDDJIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public abstract JNIJOOCHFDO FBAJMJLHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract HMNMFEPLBKF DELHBEIBNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract DCHHPEJEIML JMNIDNNFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract GNPIDDDCFOP LGAHAPODJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected CGJNGNDIKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class HBBPFNICNNH : IDJFGDPEEOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct BBOLLBFMJIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public HBBPFNICNNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public PIADNJODOCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1E57ED0", Offset = "0x1E568D0", VA = "0x181E57ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1E580E0", Offset = "0x1E56AE0", VA = "0x181E580E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct IMNJNGPOHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<CFFLBEIHEFA, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public HBBPFNICNNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IReadOnlyList<PIADNJODOCI> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1E5FF40", Offset = "0x1E5E940", VA = "0x181E5FF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1E602C0", Offset = "0x1E5ECC0", VA = "0x181E602C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly FDBLMCDEPNP CPGFAOBIDIB;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public HBBPFNICNNH(FDBLMCDEPNP KBMHLGEFDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F5E0", Offset = "0x1E5DFE0", VA = "0x181E5F5E0")]
	[AsyncStateMachine(typeof(BBOLLBFMJIC))]
	private Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> JGHIONECKEH(PIADNJODOCI HKIJJKKNOIF, bool GDDNBDKGFBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F710", Offset = "0x1E5E110", VA = "0x181E5F710", Slot = "4")]
	[AsyncStateMachine(typeof(IMNJNGPOHMC))]
	public Task<LGGHGMLBJFM<CFFLBEIHEFA, DGFMPJAMJNO>> LAMPNNGGIPG(IReadOnlyList<PIADNJODOCI> LCNHLGGJHOL, bool GDDNBDKGFBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct BDIBPFFKHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal OGGLLGDGBBE<NOEPPJIJACE, PIADNJODOCI, ABKKMFLOEIN> IGFGDBIIGID;

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1E463D0", Offset = "0x1E44DD0", VA = "0x181E463D0")]
	private BDIBPFFKHFD([In] OGGLLGDGBBE<NOEPPJIJACE, PIADNJODOCI, ABKKMFLOEIN> PAHHAEPGOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1E585A0", Offset = "0x1E56FA0", VA = "0x181E585A0")]
	public static BDIBPFFKHFD OLCPJHCMOKI()
	{
		return default(BDIBPFFKHFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class INMNGOFPKAK
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static OGGLLGDGBBE<NOEPPJIJACE, PIADNJODOCI, ABKKMFLOEIN> NNCCCBBPBBP(this BDIBPFFKHFD CMJEIEIDHIK)
	{
		return default(OGGLLGDGBBE<NOEPPJIJACE, PIADNJODOCI, ABKKMFLOEIN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct ABKKMFLOEIN : ENJIJLDDFEF.ABCCCIAEMIJ<NOEPPJIJACE, PIADNJODOCI>
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1E579F0", Offset = "0x1E563F0", VA = "0x181E579F0", Slot = "5")]
	public PIADNJODOCI POMKHPMLFGM(NOEPPJIJACE[] EFCKNPEIOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230")]
	public int APAPJGLHDEJ([In] NOEPPJIJACE NKIONPLADAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230", Slot = "4")]
	private int JKJLMFEJOEF([In] NOEPPJIJACE FCCHFBENICN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct GFBOEEMKNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal OBCJBFGFDBF<MDBHOKCDNOA, PIADNJODOCI, IDFOLLIGBFM> IGFGDBIIGID;

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1E463D0", Offset = "0x1E44DD0", VA = "0x181E463D0")]
	private GFBOEEMKNFJ([In] OBCJBFGFDBF<MDBHOKCDNOA, PIADNJODOCI, IDFOLLIGBFM> NGCHBMHNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F580", Offset = "0x1E5DF80", VA = "0x181E5F580")]
	public static GFBOEEMKNFJ OLCPJHCMOKI()
	{
		return default(GFBOEEMKNFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class NLAAAHKILPI
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static OBCJBFGFDBF<MDBHOKCDNOA, PIADNJODOCI, IDFOLLIGBFM> NNCCCBBPBBP(this GFBOEEMKNFJ CMJEIEIDHIK)
	{
		return default(OBCJBFGFDBF<MDBHOKCDNOA, PIADNJODOCI, IDFOLLIGBFM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct IDFOLLIGBFM : BCBECCBEHKG.KIDJOAMJLPJ<MDBHOKCDNOA, PIADNJODOCI>
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230")]
	public int BKJOODOIMOD([In] MDBHOKCDNOA NKIONPLADAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1E5FD50", Offset = "0x1E5E750", VA = "0x181E5FD50", Slot = "5")]
	public PIADNJODOCI LEDOAHAJNIP(MDBHOKCDNOA[] CONKIBBMAPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230", Slot = "4")]
	private int LBDPMCEMDCM([In] MDBHOKCDNOA NKIONPLADAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface KPEHDMLEMPN
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBMPCMAGALC([In] LGGHGMLBJFM<PHKKIFFGKBG, CEAFENKMCFB> LKBGEIGOHEF);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class MCFMLOKMNAD
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B480", Offset = "0x2A19E80", VA = "0x182A1B480")]
	public static bool HBMPCMAGALC<TOk, TErr>(this KPEHDMLEMPN CMJEIEIDHIK, [In] LGGHGMLBJFM<TOk, TErr> LKBGEIGOHEF) where TOk : notnull where TErr : notnull, CEAFENKMCFB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface JNIJOOCHFDO
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	JCNELOHCCMP IFDNHAGNOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface HMNMFEPLBKF
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLADGGDNOHJ JJNMICBKFBH(int OMMABLAKJOF);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface OIMCHGBBLMG
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface CCJGEGONFCI
{
	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHKKBJHKDNI? DCMIKFJODMD(BOLDNJBHEHG<OIOOIEADMDH> JNPOFNMMALG);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface MADHBFDNLNE
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface JHKKBJHKDNI
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MADHBFDNLNE? IALEIOLJLIA(BOLDNJBHEHG<KEJDHOACCFC> FJJEEKLLHMP);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OIMCHGBBLMG? KBLANBFJJFE(BOLDNJBHEHG<LPAGCMFKGEH> JFMEOLKGOBF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface DCHHPEJEIML
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CBCJDBDILEB(string AEJBOLFACJC, string JGGBEOJAHKH);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface GNPIDDDCFOP
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCJGEGONFCI? JBJHNNMDKFH([In] CPNCACFPDBL<EFGKAOAPDDH> OJNLHLOGOOH);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class MBAJJALACEK
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct HIKCOCHHMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int JIFJFCOEJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public JDDHADDGFLN? ILJMGPBCNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JDDHADDGFLN? JIPJNBHGFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public readonly List<PIADNJODOCI> GLPOPLCBCJM;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1E5FC10", Offset = "0x1E5E610", VA = "0x181E5FC10")]
		private HIKCOCHHMPF(int ABBNIPHGMGH, JDDHADDGFLN? OJKOJBBPGBP, JDDHADDGFLN? CPBCONEPEBF, List<PIADNJODOCI> LCNHLGGJHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1E5FB50", Offset = "0x1E5E550", VA = "0x181E5FB50")]
		public static HIKCOCHHMPF OLCPJHCMOKI()
		{
			return default(HIKCOCHHMPF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly NOFGLKBOLDG<HIKCOCHHMPF> DFAAJCCBOMJ;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public static MBAJJALACEK AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1E60BE0", Offset = "0x1E5F5E0", VA = "0x181E60BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool FGIELCKEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x838CD0", Offset = "0x8376D0", VA = "0x180838CD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8AA620", Offset = "0x8A9020", VA = "0x1808AA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1E60B20", Offset = "0x1E5F520", VA = "0x181E60B20")]
	public void GMNFCLBCJKI(GCFHKIJAPKL CPBCONEPEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1E60820", Offset = "0x1E5F220", VA = "0x181E60820")]
	public void GEOEFOGAFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1E60C30", Offset = "0x1E5F630", VA = "0x181E60C30")]
	private static string? NNKJIFALHAP([In] HIKCOCHHMPF BENFINKKACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1E61070", Offset = "0x1E5FA70", VA = "0x181E61070")]
	public MBAJJALACEK()
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
