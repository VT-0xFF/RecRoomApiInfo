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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E7E100", Offset = "0x1E7D300", VA = "0x181E7E100")]
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
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
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
public sealed class PKEMJIPKCPK : IDisposable, IENKDAIAILD, EGCJDLJIMIB, LAPOIPKDEHP, JHLGKCCOENF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class HHBCCLIFKLE : LAJPCLAGAMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int FEJNEMGCNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AD10", Offset = "0x1E79F10", VA = "0x181E7AD10", Slot = "5")]
		public HJGCLKOGKPJ ICIAIIGIANH(HGNFAEFDMLF.FLNOPKKFNHO LPEICIFHPLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void OJBKDEDEHLP();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LFIKKAIFBHL();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AC50", Offset = "0x1E79E50", VA = "0x181E7AC50", Slot = "13")]
		public virtual void DHFKBOMAJMP(PKEMJIPKCPK HPFIGCNHCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AC90", Offset = "0x1E79E90", VA = "0x181E7AC90", Slot = "14")]
		public virtual void FPKANFFNBHC(PKEMJIPKCPK HPFIGCNHCOB, APJENLFJGEH BGMBJALDBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected HHBCCLIFKLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LAJPCLAGAMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int FEJNEMGCNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HJGCLKOGKPJ ICIAIIGIANH(HGNFAEFDMLF.FLNOPKKFNHO LPEICIFHPLM);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OJBKDEDEHLP();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LFIKKAIFBHL();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DHFKBOMAJMP(PKEMJIPKCPK HPFIGCNHCOB);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FPKANFFNBHC(PKEMJIPKCPK HPFIGCNHCOB, APJENLFJGEH BGMBJALDBDD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JFEPJAKCIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GMIMMGKKKAL<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> HIDDLFOHBPP;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B6A0", Offset = "0x1E7A8A0", VA = "0x181E7B6A0")]
		internal JFEPJAKCIIO(GMIMMGKKKAL<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> FNFDOEGAMFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IIBGCLNMBHA : DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly IIBGCLNMBHA LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private IIBGCLNMBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAFF250", Offset = "0xAFE450", VA = "0x180AFF250", Slot = "4")]
		public JHEMGAEJBGF FOCMFNNDIDA(APJENLFJGEH CJKIBFNGPNM)
		{
			return default(JHEMGAEJBGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B170", Offset = "0x1E7A370", VA = "0x181E7B170", Slot = "5")]
		public void DHFKBOMAJMP(PKEMJIPKCPK LNOFAKNEFAA, APJENLFJGEH BGMBJALDBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B270", Offset = "0x1E7A470", VA = "0x181E7B270", Slot = "6")]
		public void FPKANFFNBHC(PKEMJIPKCPK LNOFAKNEFAA, APJENLFJGEH BGMBJALDBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct ICGBLAOCDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DFAANEJFENB<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> HIDDLFOHBPP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AEB0", Offset = "0x1E7A0B0", VA = "0x181E7AEB0")]
		internal ICGBLAOCDJE(DFAANEJFENB<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AE60", Offset = "0x1E7A060", VA = "0x181E7AE60")]
		public static ICGBLAOCDJE EPPBEPCPNMI()
		{
			return default(ICGBLAOCDJE);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GECPDMPEPDJ : IEGIHPENLKG.LBPAADNCLIH<APJENLFJGEH, PKEMJIPKCPK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LFPNMIBFCOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PKEMJIPKCPK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public APJENLFJGEH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public GECPDMPEPDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1E7C8C0", Offset = "0x1E7BAC0", VA = "0x181E7C8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1E7CAA0", Offset = "0x1E7BCA0", VA = "0x181E7CAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84ED00", Offset = "0x84DF00", VA = "0x18084ED00", Slot = "4")]
		public MKMFEDEKPBJ<PPPHCJPAHEM> BDOCPJLEDLF(PKEMJIPKCPK LHADPJODGJC)
		{
			return default(MKMFEDEKPBJ<PPPHCJPAHEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E79B50", Offset = "0x1E78D50", VA = "0x181E79B50", Slot = "5")]
		[AsyncStateMachine(typeof(LFPNMIBFCOI))]
		public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> BFONIOELENK(PKEMJIPKCPK LHADPJODGJC, APJENLFJGEH BGMBJALDBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E79B30", Offset = "0x1E78D30", VA = "0x181E79B30", Slot = "6")]
		public APJENLFJGEH[] AMFNOBPCLBH(PKEMJIPKCPK LHADPJODGJC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AKECEGFOFCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PKEMJIPKCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PKDBENLCLBC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MLCOGDIIGCK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KCJGDFFBJOD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E71B80", Offset = "0x1E70D80", VA = "0x181E71B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E71E00", Offset = "0x1E71000", VA = "0x181E71E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JGKKLJFLBGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PKEMJIPKCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B6B0", Offset = "0x1E7A8B0", VA = "0x181E7B6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B940", Offset = "0x1E7AB40", VA = "0x181E7B940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FLHBAHJNHHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PKEMJIPKCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E796F0", Offset = "0x1E788F0", VA = "0x181E796F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E798D0", Offset = "0x1E78AD0", VA = "0x181E798D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AJNJODHNKOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PKEMJIPKCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public APJENLFJGEH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E71920", Offset = "0x1E70B20", VA = "0x181E71920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E71B10", Offset = "0x1E70D10", VA = "0x181E71B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CMKJEAIKKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PKEMJIPKCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E73DE0", Offset = "0x1E72FE0", VA = "0x181E73DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E745D0", Offset = "0x1E737D0", VA = "0x181E745D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MKMFEDEKPBJ<PPPHCJPAHEM> FAMFGIJFAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JFEPJAKCIIO JOKBKKCGFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FANLINACCPD HOHPNANAONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly EFIMHAKMKMH BNDBOKHIGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12A8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BMCEJPFIGDJ FCNHNAJCBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12B0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly AFFDOFPHFOK.JLHAPFCEKEF LFDABALEJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly GADLKNHGMKG EDBJFHJLOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KEHLKOHCFEJ OFAIGMDELNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JFDHLDHEPDF MPAKCCBDGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly JMFGKGOPGDF MKAHOOLJBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly EJNMPDOBKMO PBKNLEGFNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OPCJFKPDBGP KHHKEFMNDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1308")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DHIKHAAHBIL PHHCCHJJGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1328")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly FANLINACCPD.KFMKBGPIJGN LICPDILICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1330")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly KCHIDPBFKDM NPNMGDKOHID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FANLINACCPD NKOLBCJPJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BB00", Offset = "0x1E8AD00", VA = "0x181E8BB00")]
		get
		{
			return default(FANLINACCPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LAJPCLAGAMO OGLCHPDPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D050", Offset = "0x1E8C250", VA = "0x181E8D050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HJGCLKOGKPJ PIPKNHKKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E8C7F0", Offset = "0x1E8B9F0", VA = "0x181E8C7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E8CD20", Offset = "0x1E8BF20", VA = "0x181E8CD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool MJHKLCMMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E8CD40", Offset = "0x1E8BF40", VA = "0x181E8CD40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D040", Offset = "0x1E8C240", VA = "0x181E8D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IMJCILECHLL CLKJJGLLPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D3E0", Offset = "0x1E8C5E0", VA = "0x181E8D3E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KNCBCBKHJEP MHOLDLPFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D400", Offset = "0x1E8C600", VA = "0x181E8D400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ENEPPOKAMDP OOIKOHFGLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D420", Offset = "0x1E8C620", VA = "0x181E8D420", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ECBBJBGGPEP OJCKNIGNKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D3F0", Offset = "0x1E8C5F0", VA = "0x181E8D3F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ECPDHGIBOIF FLJGGIJENAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D410", Offset = "0x1E8C610", VA = "0x181E8D410", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PJCIGFCBIPG? KEPBODNLKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E8CBF0", Offset = "0x1E8BDF0", VA = "0x181E8CBF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private MPCACCMNJGP? FCGIMOMCJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BEA0", Offset = "0x1E8B0A0", VA = "0x181E8BEA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D0A0", Offset = "0x1E8C2A0", VA = "0x181E8D0A0")]
	private PKEMJIPKCPK(BMCEJPFIGDJ AMCPAFMAAPM, MKMFEDEKPBJ<PPPHCJPAHEM> MDCNPPDPLHN, [In] JFEPJAKCIIO DHBFEELJHGA, [In] FANLINACCPD IKOMLJAGELN, [In] EFIMHAKMKMH OADJNBBJDON, HJGCLKOGKPJ HGIFPHKBPAJ, [In] AFFDOFPHFOK.JLHAPFCEKEF CJGDHPNJBMN, FANLINACCPD.KFMKBGPIJGN KOGBNPMHHOH, KCHIDPBFKDM GJHGBIAIAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E8C6B0", Offset = "0x1E8B8B0", VA = "0x181E8C6B0")]
	public static PKEMJIPKCPK EPPBEPCPNMI(BMCEJPFIGDJ LPEICIFHPLM, [In] FLBBIEKAGPN HGNJLEEAHEM, ELALKHAKGFN AJOOAOAMHPM, [In] MMHDKGNEFFD KGOJBAPCOKN, FLGFCLLGDNP EOADBLCGBKK, MKMFEDEKPBJ<PPPHCJPAHEM> MDCNPPDPLHN, MKMFEDEKPBJ<LPDBKJKBIEM> JOOEALEAALG, NEKJGJPAMKL KKKALCIMAHL, OFJGBGNFACM BEEDBNEMOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E8C3D0", Offset = "0x1E8B5D0", VA = "0x181E8C3D0")]
	public static PKEMJIPKCPK EPPBEPCPNMI(BMCEJPFIGDJ AMCPAFMAAPM, [In] FANLINACCPD IKOMLJAGELN, [In] EFIMHAKMKMH OADJNBBJDON, MKMFEDEKPBJ<PPPHCJPAHEM> MDCNPPDPLHN, MKMFEDEKPBJ<LPDBKJKBIEM> JOOEALEAALG, NEKJGJPAMKL KKKALCIMAHL, OFJGBGNFACM BEEDBNEMOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E8BFD0", Offset = "0x1E8B1D0", VA = "0x181E8BFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CD50", Offset = "0x1E8BF50", VA = "0x181E8CD50")]
	[AsyncStateMachine(typeof(AKECEGFOFCJ))]
	internal Task<GDHFNIGIAEI<bool, HHLFGPMDGJA>> MALILKCLBHE(PKDBENLCLBC DHDPONDIBPB, MLCOGDIIGCK LHOBKLPONGG, KCJGDFFBJOD EMCGDLKBKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CA80", Offset = "0x1E8BC80", VA = "0x181E8CA80")]
	[AsyncStateMachine(typeof(JGKKLJFLBGA))]
	public Task<GDHFNIGIAEI<bool, HHLFGPMDGJA>> GKMBKCICAOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E8C800", Offset = "0x1E8BA00", VA = "0x181E8C800")]
	[AsyncStateMachine(typeof(FLHBAHJNHHL))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> GCLHADEJLNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E8C1C0", Offset = "0x1E8B3C0", VA = "0x181E8C1C0")]
	internal void EONMBOKNAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CFC0", Offset = "0x1E8C1C0", VA = "0x181E8CFC0")]
	internal CPCJPGBNMLP<APJENLFJGEH> OLADFECNFDM([In] PPEFPCLGECF AHJFKCMLGEB)
	{
		return default(CPCJPGBNMLP<APJENLFJGEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CA10", Offset = "0x1E8BC10", VA = "0x181E8CA10")]
	internal bool GIPPFKFOBIM([In] PPEFPCLGECF AHJFKCMLGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CB70", Offset = "0x1E8BD70", VA = "0x181E8CB70")]
	internal CPCJPGBNMLP<APJENLFJGEH> GNKCIMJPAHO([In] DPKMONKDAOE PLPBDJAJMMP)
	{
		return default(CPCJPGBNMLP<APJENLFJGEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E8CEB0", Offset = "0x1E8C0B0", VA = "0x181E8CEB0")]
	[AsyncStateMachine(typeof(AJNJODHNKOA))]
	internal Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> MLGCNGLDEMM(APJENLFJGEH BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E8BB10", Offset = "0x1E8AD10", VA = "0x181E8BB10")]
	private APJENLFJGEH[] AMFNOBPCLBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E8C8F0", Offset = "0x1E8BAF0", VA = "0x181E8C8F0")]
	[AsyncStateMachine(typeof(CMKJEAIKKMH))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> GDMCOPIPFIC(Guid EBKJCGPGOOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DMGEANOCKJF
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2806FA0", Offset = "0x28061A0", VA = "0x182806FA0")]
	public static JKOFFKDPAPJ<(TPrev?, PKEMJIPKCPK?), MPCACCMNJGP> JJBCMPPAJJK<TPrev>([In] this JKOFFKDPAPJ<TPrev, PKEMJIPKCPK> CJKIBFNGPNM)
	{
		return default(JKOFFKDPAPJ<(TPrev, PKEMJIPKCPK), MPCACCMNJGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2806D40", Offset = "0x2805F40", VA = "0x182806D40")]
	public static JKOFFKDPAPJ<TPrev?, PKEMJIPKCPK?> HACFKHPIMCD<TPrev>([In] this JKOFFKDPAPJ<TPrev, PKEMJIPKCPK> CJKIBFNGPNM)
	{
		return default(JKOFFKDPAPJ<TPrev, PKEMJIPKCPK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class FPHDDCAHAJD<TData> : GCNNAKAAMEK, MCELHECPKFI, NFEBAOOCHCK where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BEGCOIKGLLD<HLKKEFMLJPC>? GKLBMKBNFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string AALAONDECAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData GICDCDBMPKH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BEGCOIKGLLD<HLKKEFMLJPC>? JCAPEEPNHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x20A47C0", Offset = "0x20A39C0", VA = "0x1820A47C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0", Slot = "7")]
	public override string HDHLJKIJNJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3927D30", Offset = "0x3926F30", VA = "0x183927D30")]
	internal FPHDDCAHAJD([In] BEGCOIKGLLD<HLKKEFMLJPC>? LCPJGOLNJGI, MKMFEDEKPBJ<CAJELJDMNKC>? KDNBKLECGJN, IOKind? PIIBFAPJHGP, string PPGBBBOBJLN, [In] TData JLJKEBMIIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HFILDNIIKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A390", Offset = "0x1E79590", VA = "0x181E7A390")]
	public static GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI> KCDPKACAPAI([In] this OKNCPOIACPH<BOBMDBMOHMA> KIHDICPJKKH)
	{
		return default(GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29B2E70", Offset = "0x29B2070", VA = "0x1829B2E70")]
	public static GDHFNIGIAEI<TOk, MCELHECPKFI> HPHABIDJPNE<TOk>([In] this GDHFNIGIAEI<TOk, MCELHECPKFI> CJKIBFNGPNM, [In] BEGCOIKGLLD<HLKKEFMLJPC>? LCPJGOLNJGI, MKMFEDEKPBJ<CAJELJDMNKC>? KDNBKLECGJN, IOKind? PIIBFAPJHGP, string PPGBBBOBJLN) where TOk : notnull
	{
		return default(GDHFNIGIAEI<TOk, MCELHECPKFI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BMCEJPFIGDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DOBPHAPKDEG.HJNPKHNFDDO DLBDJIKHENN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HGNFAEFDMLF.FLNOPKKFNHO DAMBFELDEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PKEMJIPKCPK.LAJPCLAGAMO EFGHICPHACP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PKLKKIHOCMG.CNAJEMDMNEL MEKJPIGKIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK> GJHDHKFCDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CDJKJBJCCHG FJDJIKMGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BIIGOGPKBLH EKNIIGDOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DAICGOPJCMH ANDJEDHEJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HLCKDCFNDIG PGMNKONADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OABCGNHFAAC HFHMJKCFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BHAHCJIDMBE
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E72360", Offset = "0x1E71560", VA = "0x181E72360")]
	public static APJENLFJGEH EFKFFCONOMC(this APJENLFJGEH CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E72290", Offset = "0x1E71490", VA = "0x181E72290")]
	public static APJENLFJGEH BODAGHEDFIA(this CGAIKPLDNCC CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CGAIKPLDNCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MCHDLKMAOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PKEMJIPKCPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CGAIKPLDNCC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7CCA0", Offset = "0x1E7BEA0", VA = "0x181E7CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7CF60", Offset = "0x1E7C160", VA = "0x181E7CF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString OGADOHBOMGE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	private CGAIKPLDNCC(ByteString HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E73B60", Offset = "0x1E72D60", VA = "0x181E73B60")]
	public static APJENLFJGEH FNBADAKBAFA(ByteString HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E73D30", Offset = "0x1E72F30", VA = "0x181E73D30")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, CGAIKPLDNCC> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, CGAIKPLDNCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E73C20", Offset = "0x1E72E20", VA = "0x181E73C20")]
	[AsyncStateMachine(typeof(MCHDLKMAOCH))]
	public static Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> MLGCNGLDEMM(PKEMJIPKCPK LNOFAKNEFAA, CGAIKPLDNCC CJKIBFNGPNM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LPKPDDPKFLM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E7CB10", Offset = "0x1E7BD10", VA = "0x181E7CB10")]
	public static APJENLFJGEH FNBADAKBAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E7CBB0", Offset = "0x1E7BDB0", VA = "0x181E7CBB0")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, LPKPDDPKFLM> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, LPKPDDPKFLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E7CC20", Offset = "0x1E7BE20", VA = "0x181E7CC20")]
	public static GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE> PFFCILAFNIK(PKEMJIPKCPK LNOFAKNEFAA, [In] LPKPDDPKFLM CJKIBFNGPNM)
	{
		return default(GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FEAMOCBPPDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KBHDHFJLKND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PKEMJIPKCPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FEAMOCBPPDF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BBC0", Offset = "0x1E7ADC0", VA = "0x181E7BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BF30", Offset = "0x1E7B130", VA = "0x181E7BF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly PKDBENLCLBC? NPPJIPEFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly MLCOGDIIGCK? ELOGFDCHIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly KCJGDFFBJOD? EGNBAOEJFMG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA420", Offset = "0x1DA9620", VA = "0x181DAA420")]
	private FEAMOCBPPDF(PKDBENLCLBC? DHDPONDIBPB, MLCOGDIIGCK? LHOBKLPONGG, KCJGDFFBJOD? EMCGDLKBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E79160", Offset = "0x1E78360", VA = "0x181E79160")]
	public static APJENLFJGEH? FNBADAKBAFA(PKDBENLCLBC? DHDPONDIBPB, MLCOGDIIGCK? LHOBKLPONGG, KCJGDFFBJOD? EMCGDLKBKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E793A0", Offset = "0x1E785A0", VA = "0x181E793A0")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, FEAMOCBPPDF> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, FEAMOCBPPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E79260", Offset = "0x1E78460", VA = "0x181E79260")]
	[AsyncStateMachine(typeof(KBHDHFJLKND))]
	public static Task<GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE>> MLGCNGLDEMM(PKEMJIPKCPK LNOFAKNEFAA, FEAMOCBPPDF CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AINBHEONLHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MECGPEIIMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<JMKCIGECGHH, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AINBHEONLHK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PKEMJIPKCPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GDHFNIGIAEI<JMKCIGECGHH, HHLFGPMDGJA> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GDHFNIGIAEI<object, NFEBAOOCHCK>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private GDHFNIGIAEI<object, NFEBAOOCHCK> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private GDHFNIGIAEI<object, NFEBAOOCHCK>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E7CFD0", Offset = "0x1E7C1D0", VA = "0x181E7CFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D430", Offset = "0x1E7C630", VA = "0x181E7D430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<APJENLFJGEH> CDCLICNCGJB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	private AINBHEONLHK(IReadOnlyList<APJENLFJGEH> JCAJMHEPJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E71680", Offset = "0x1E70880", VA = "0x181E71680")]
	public static APJENLFJGEH FNBADAKBAFA(IReadOnlyList<APJENLFJGEH> JCAJMHEPJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E71880", Offset = "0x1E70A80", VA = "0x181E71880")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, AINBHEONLHK> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, AINBHEONLHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E71740", Offset = "0x1E70940", VA = "0x181E71740")]
	[AsyncStateMachine(typeof(MECGPEIIMGJ))]
	public static Task<GDHFNIGIAEI<JMKCIGECGHH, HHLFGPMDGJA>> MLGCNGLDEMM(PKEMJIPKCPK LNOFAKNEFAA, AINBHEONLHK CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct DPKMONKDAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int HJGLMCCDDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int DMDPAHAMEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] GICDCDBMPKH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x19DCB90", Offset = "0x19DBD90", VA = "0x1819DCB90")]
	private DPKMONKDAOE(int BIFLOKBJAPK, int PMNHOLIPOMJ, byte[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E75930", Offset = "0x1E74B30", VA = "0x181E75930")]
	public static APJENLFJGEH FNBADAKBAFA(int BIFLOKBJAPK, int PMNHOLIPOMJ, ByteString JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E75A10", Offset = "0x1E74C10", VA = "0x181E75A10")]
	public static APJENLFJGEH[] KFILDLKEFNA(APJENLFJGEH BGMBJALDBDD, int BJOPPFBCIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E75B50", Offset = "0x1E74D50", VA = "0x181E75B50")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, DPKMONKDAOE> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, DPKMONKDAOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E75C30", Offset = "0x1E74E30", VA = "0x181E75C30")]
	public static GDHFNIGIAEI<APJENLFJGEH, GCHIODKACBE> PFFCILAFNIK(PKEMJIPKCPK LNOFAKNEFAA, [In] DPKMONKDAOE CJKIBFNGPNM)
	{
		return default(GDHFNIGIAEI<APJENLFJGEH, GCHIODKACBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PPEFPCLGECF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct OHBJMAAKKED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<bool, GCHIODKACBE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PKEMJIPKCPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PPEFPCLGECF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private GDHFNIGIAEI<bool, GCHIODKACBE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, GCHIODKACBE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1E8B240", Offset = "0x1E8A440", VA = "0x181E8B240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1E8B880", Offset = "0x1E8AA80", VA = "0x181E8B880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int HJGLMCCDDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int DMDPAHAMEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] GICDCDBMPKH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x19DCB90", Offset = "0x19DBD90", VA = "0x1819DCB90")]
	private PPEFPCLGECF(int BIFLOKBJAPK, int PMNHOLIPOMJ, byte[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D630", Offset = "0x1E8C830", VA = "0x181E8D630")]
	public static APJENLFJGEH FNBADAKBAFA(int BIFLOKBJAPK, int PMNHOLIPOMJ, ByteString JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D430", Offset = "0x1E8C630", VA = "0x181E8D430")]
	public static APJENLFJGEH?[]? FKLBLJOOMCI(int BJOPPFBCIEP, PKDBENLCLBC? DHDPONDIBPB, MLCOGDIIGCK? LHOBKLPONGG, KCJGDFFBJOD? EMCGDLKBKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D840", Offset = "0x1E8CA40", VA = "0x181E8D840")]
	public static HBGEDKJHNBH<JHEMGAEJBGF, PPEFPCLGECF> NOAKJENBCMF(APJENLFJGEH OJNBFDJPPPI)
	{
		return default(HBGEDKJHNBH<JHEMGAEJBGF, PPEFPCLGECF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D710", Offset = "0x1E8C910", VA = "0x181E8D710")]
	[AsyncStateMachine(typeof(OHBJMAAKKED))]
	public static Task<GDHFNIGIAEI<bool, GCHIODKACBE>> MLGCNGLDEMM(PKEMJIPKCPK LNOFAKNEFAA, PPEFPCLGECF CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GADLKNHGMKG : IMJCILECHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FLHHAJALKFD? LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E79940", Offset = "0x1E78B40", VA = "0x181E79940", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	internal GADLKNHGMKG(PKEMJIPKCPK HPFIGCNHCOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AIEMALEKDCC : FLHHAJALKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ILFPMINBIAD AJGEPOPLJAJ;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
	public AIEMALEKDCC(PKEMJIPKCPK HPFIGCNHCOB, ILFPMINBIAD AIJCKEEFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E710E0", Offset = "0x1E702E0", VA = "0x181E710E0", Slot = "4")]
	public GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI> ABCGAHFDGPG(BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<PJFBEINPAMA> KKNMCFFINHC)
	{
		return default(GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E713B0", Offset = "0x1E705B0", VA = "0x181E713B0", Slot = "5")]
	public GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI> BCJJJAGPKOB(BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<MPEIMPJLOJO> JCNECKHKKFI)
	{
		return default(GDHFNIGIAEI<DJKLPPHGAFN, MCELHECPKFI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DOBPHAPKDEG : DKKAMCCPBBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface HJNPKHNFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ILFPMINBIAD> NEAJMAGEEGA(PKEMJIPKCPK HPFIGCNHCOB, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE, CancellationToken GILHKFNDIJP);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PPJHNHKMMBG FADBCMCOABJ(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class LCNICGPDFOP : HJNPKHNFDDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct FJBOOLOEPNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<ILFPMINBIAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public PKEMJIPKCPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public MLCOGDIIGCK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KCJGDFFBJOD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<PKLKKIHOCMG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1E794B0", Offset = "0x1E786B0", VA = "0x181E794B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1E79680", Offset = "0x1E78880", VA = "0x181E79680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly LCNICGPDFOP LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private LCNICGPDFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C180", Offset = "0x1E7B380", VA = "0x181E7C180", Slot = "4")]
		[AsyncStateMachine(typeof(FJBOOLOEPNJ))]
		public Task<ILFPMINBIAD> NEAJMAGEEGA(PKEMJIPKCPK HPFIGCNHCOB, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE, CancellationToken GILHKFNDIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C160", Offset = "0x1E7B360", VA = "0x181E7C160", Slot = "5")]
		public PPJHNHKMMBG FADBCMCOABJ(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NDEPPNGCAEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<DOBPHAPKDEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PKEMJIPKCPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MLCOGDIIGCK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KCJGDFFBJOD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public PKDBENLCLBC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HJNPKHNFDDO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<ILFPMINBIAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D860", Offset = "0x1E7CA60", VA = "0x181E7D860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E7DDA0", Offset = "0x1E7CFA0", VA = "0x181E7DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ILFPMINBIAD AJGEPOPLJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PPJHNHKMMBG NEDCPJALFAD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PJCIGFCBIPG IGJMNCLODOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E74C30", Offset = "0x1E73E30", VA = "0x181E74C30", Slot = "4")]
		get
		{
			return default(PJCIGFCBIPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MPCACCMNJGP ALPOJMLLPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E74B70", Offset = "0x1E73D70", VA = "0x181E74B70", Slot = "5")]
		get
		{
			return default(MPCACCMNJGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AIEMALEKDCC OEOLGDKNJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NIEAMKJENIB PPCINCPCHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DMCCNBALGBC GNKFIKCPGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E74C90", Offset = "0x1E73E90", VA = "0x181E74C90")]
	private DOBPHAPKDEG(ILFPMINBIAD AIJCKEEFELO, PPJHNHKMMBG KPNIBOPLGKP, AIEMALEKDCC FMMCAPMDFKD, NIEAMKJENIB CDBILGKDOEO, DMCCNBALGBC JLKIACOEICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E74A00", Offset = "0x1E73C00", VA = "0x181E74A00")]
	[AsyncStateMachine(typeof(NDEPPNGCAEA))]
	public static Task<DOBPHAPKDEG> HHPFEBJGPNM(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E749A0", Offset = "0x1E73BA0", VA = "0x181E749A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class HGNFAEFDMLF : HJGCLKOGKPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface FLNOPKKFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DKKAMCCPBBL> NKFPAADMFAH(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE, CancellationToken GILHKFNDIJP);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HBDFPHMNDCN();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void APEIGELAKOH();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class JJPCHAJJFMM : FLNOPKKFNHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct EMDPELOBKGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<DKKAMCCPBBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public PKEMJIPKCPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public PKDBENLCLBC evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public MLCOGDIIGCK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public KCJGDFFBJOD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<DOBPHAPKDEG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E78820", Offset = "0x1E77A20", VA = "0x181E78820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E78B60", Offset = "0x1E77D60", VA = "0x181E78B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B9B0", Offset = "0x1E7ABB0", VA = "0x181E7B9B0", Slot = "4")]
		[AsyncStateMachine(typeof(EMDPELOBKGJ))]
		public Task<DKKAMCCPBBL> NKFPAADMFAH(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE, CancellationToken GILHKFNDIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HBDFPHMNDCN();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void APEIGELAKOH();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected JJPCHAJJFMM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NEADPOIOHPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<DKKAMCCPBBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HGNFAEFDMLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<PJGNGDCIDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E7DE10", Offset = "0x1E7D010", VA = "0x181E7DE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E010", Offset = "0x1E7D210", VA = "0x181E7E010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FDCJICBBHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HGNFAEFDMLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public PKEMJIPKCPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PKDBENLCLBC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public MLCOGDIIGCK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KCJGDFFBJOD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<DKKAMCCPBBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E78BD0", Offset = "0x1E77DD0", VA = "0x181E78BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E79100", Offset = "0x1E78300", VA = "0x181E79100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly FLNOPKKFNHO GJMNJKPIFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<PJGNGDCIDLA> AGAEIJEAEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<PJGNGDCIDLA> OENPIHNFLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource CODPADBPEFK;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MJHKLCMMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x91A950", Offset = "0x919B50", VA = "0x18091A950", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99DF40", Offset = "0x99D140", VA = "0x18099DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA18ED0", Offset = "0xA180D0", VA = "0x180A18ED0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA18EE0", Offset = "0xA180E0", VA = "0x180A18EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool BHGPEJFBGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x100E460", Offset = "0x100D660", VA = "0x18100E460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AB30", Offset = "0x1E79D30", VA = "0x181E7AB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public DKKAMCCPBBL? CCFNCMHEGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE970", Offset = "0x7CDB70", VA = "0x1807CE970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AA40", Offset = "0x1E79C40", VA = "0x181E7AA40", Slot = "7")]
	[AsyncStateMachine(typeof(NEADPOIOHPB))]
	public Task<DKKAMCCPBBL> HBCCDMKPBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AB40", Offset = "0x1E79D40", VA = "0x181E7AB40")]
	public HGNFAEFDMLF(FLNOPKKFNHO LPEICIFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8E0", Offset = "0x1E79AE0", VA = "0x181E7A8E0", Slot = "8")]
	[AsyncStateMachine(typeof(FDCJICBBHDP))]
	public Task EAMHCPDGMAC(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A770", Offset = "0x1E79970", VA = "0x181E7A770", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HPIGIKDPPMG : ACICOJMICLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NIEAMKJENIB GFLLLACDEHF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public HPIGIKDPPMG(NIEAMKJENIB CDBILGKDOEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GIHBKGFGABB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class EKEMLGAKDOI<TGraph> : DHMCDHEHAEA where TGraph : KIFLJLFOAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph GFLBCGLGBKB;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual HJLKNBANMHD? HDMKLHCBLNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xE4F360", Offset = "0xE4E560", VA = "0x180E4F360", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MKMFEDEKPBJ<OAAIMIGIBKP> MEBGPMMMIBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x358D8C0", Offset = "0x358CAC0", VA = "0x18358D8C0", Slot = "4")]
			get
			{
				return default(MKMFEDEKPBJ<OAAIMIGIBKP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
		public EKEMLGAKDOI(TGraph IMHPFNAFBNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GCBHACELCII : EKEMLGAKDOI<GOCKONPLPFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override HJLKNBANMHD? HDMKLHCBLNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E79A40", Offset = "0x1E78C40", VA = "0x181E79A40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E79A60", Offset = "0x1E78C60", VA = "0x181E79A60")]
		public GCBHACELCII(GOCKONPLPFH HNNLGJIAFJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E79C80", Offset = "0x1E78E80", VA = "0x181E79C80")]
	public static DHMCDHEHAEA EPPBEPCPNMI(KIFLJLFOAIC IMHPFNAFBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EEEKBKCMIFP : EPKOLHMAPGJ, JOMBBDNGBPN, EFJEMAMNNPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PJDJPJFKFJJ
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
			public PJDJPJFKFJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public CDJKJBJCCHG errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E8D920", Offset = "0x1E8CB20", VA = "0x181E8D920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E8DB90", Offset = "0x1E8CD90", VA = "0x181E8DB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public EEEKBKCMIFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public PJDJPJFKFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BA10", Offset = "0x1E8AC10", VA = "0x181E8BA10")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task GPPLBAJJJPO(CDJKJBJCCHG errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LEJCOBGJPGD : IAsyncStateMachine
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
		public EEEKBKCMIFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C360", Offset = "0x1E7B560", VA = "0x181E7C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C860", Offset = "0x1E7BA60", VA = "0x181E7C860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class GMFGPJNIFHF
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
			public GMFGPJNIFHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E8DBF0", Offset = "0x1E8CDF0", VA = "0x181E8DBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E8DED0", Offset = "0x1E8D0D0", VA = "0x181E8DED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public EEEKBKCMIFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GMFGPJNIFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A2C0", Offset = "0x1E794C0", VA = "0x181E7A2C0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task EGACJBIKFHN(CDJKJBJCCHG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly LEPKIMBNGAG INDABHFBLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<DKEBBKEMCJA> BICCPIANGCA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private BMCEJPFIGDJ OABPCAHLKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E76A00", Offset = "0x1E75C00", VA = "0x181E76A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MKMFEDEKPBJ<PJFBEINPAMA> NHCNDJAKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x834E80", Offset = "0x834080", VA = "0x180834E80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MKMFEDEKPBJ<PJFBEINPAMA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBCE4F0", Offset = "0xBCD6F0", VA = "0x180BCE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MKMFEDEKPBJ<FJNGGFBGNAK> BLFHLAOJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA12FF0", Offset = "0xA121F0", VA = "0x180A12FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MKMFEDEKPBJ<BEFIKDACCGE> DGCJLFDLHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0060", Offset = "0x7EF260", VA = "0x1807F0060", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MKMFEDEKPBJ<BEFIKDACCGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override MKMFEDEKPBJ<CAJELJDMNKC> PIIAGBABOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E76CD0", Offset = "0x1E75ED0", VA = "0x181E76CD0", Slot = "20")]
		get
		{
			return default(MKMFEDEKPBJ<CAJELJDMNKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NPGBNHBNPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E77770", Offset = "0x1E76970", VA = "0x181E77770", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E785F0", Offset = "0x1E777F0", VA = "0x181E785F0")]
	private EEEKBKCMIFP(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK, LEPKIMBNGAG POCDHJBLKNB, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<PJFBEINPAMA> KKNMCFFINHC, MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF, bool NNBABOHPMKN, string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E76470", Offset = "0x1E75670", VA = "0x181E76470")]
	public static EEEKBKCMIFP EPPBEPCPNMI(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK, LEPKIMBNGAG NBFGFAAMIMJ, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF, MKMFEDEKPBJ<PJFBEINPAMA> KKNMCFFINHC, bool NNBABOHPMKN, bool MPEKFMHACMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E76280", Offset = "0x1E75480", VA = "0x181E76280", Slot = "21")]
	protected override void CNOOLEDIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E763D0", Offset = "0x1E755D0", VA = "0x181E763D0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E76370", Offset = "0x1E75570", VA = "0x181E76370", Slot = "30")]
	public void DOALAIIGDFJ(DKEBBKEMCJA COANOGIBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E77E40", Offset = "0x1E77040", VA = "0x181E77E40", Slot = "27")]
	public void MIPOHOJDLOD(MFEHCBCMNIJ NFFBJGLCGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E76DE0", Offset = "0x1E75FE0", VA = "0x181E76DE0", Slot = "28")]
	public void JBNEBCNELAN(LDPEGGOBFPG IPGBJNIIIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E78490", Offset = "0x1E77690", VA = "0x181E78490", Slot = "23")]
	protected override void NLEKJLMNGGH(MBFPMMLAFED EIDAIJGJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E77870", Offset = "0x1E76A70", VA = "0x181E77870", Slot = "32")]
	public string LBNMNEDMOJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E779E0", Offset = "0x1E76BE0", VA = "0x181E779E0", Slot = "29")]
	public string LGLILDFPMLN(int EONMMHJJMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E781B0", Offset = "0x1E773B0", VA = "0x181E781B0")]
	private void MJHINBCPDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E783D0", Offset = "0x1E775D0", VA = "0x181E783D0", Slot = "31")]
	public void NLBMAKBDAEB(DKEBBKEMCJA COANOGIBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E760C0", Offset = "0x1E752C0", VA = "0x181E760C0")]
	private void BNCKDDGMAOL(bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E76BC0", Offset = "0x1E75DC0", VA = "0x181E76BC0", Slot = "33")]
	[AsyncStateMachine(typeof(LEJCOBGJPGD))]
	public Task ICGMOKNKNEP(string HLCKBKFCMPI, bool LAKPDFCMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E75DF0", Offset = "0x1E74FF0", VA = "0x181E75DF0")]
	public void AHMGCHDINJO(string HLCKBKFCMPI, bool LAKPDFCMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E77CA0", Offset = "0x1E76EA0", VA = "0x181E77CA0")]
	private void LOJIHMLGDMD(int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xBCE4F0", Offset = "0xBCD6F0", VA = "0x180BCE4F0")]
	internal void LOGIJOGMHGC(MKMFEDEKPBJ<PJFBEINPAMA> HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E785E0", Offset = "0x1E777E0", VA = "0x181E785E0")]
	[CompilerGenerated]
	private void OFKNLPJPOHH(string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E76000", Offset = "0x1E75200", VA = "0x181E76000")]
	[CompilerGenerated]
	private bool BIPCKLDBFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E75F40", Offset = "0x1E75140", VA = "0x181E75F40")]
	[CompilerGenerated]
	private bool BFCFJPFLFPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E76320", Offset = "0x1E75520", VA = "0x181E76320")]
	[CompilerGenerated]
	private int OANAGMIEKKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E76AE0", Offset = "0x1E75CE0", VA = "0x181E76AE0")]
	[CompilerGenerated]
	private bool GJOPKFONFFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E75DE0", Offset = "0x1E74FE0", VA = "0x181E75DE0")]
	[CompilerGenerated]
	private void ABIGCHDJMFE(string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E76A20", Offset = "0x1E75C20", VA = "0x181E76A20")]
	[CompilerGenerated]
	private bool GHHFKPOIAGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E76B70", Offset = "0x1E75D70", VA = "0x181E76B70")]
	[CompilerGenerated]
	private bool IAHNFBGIKIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E75D50", Offset = "0x1E74F50", VA = "0x181E75D50")]
	[CompilerGenerated]
	private bool AAEBOPCKFPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E76320", Offset = "0x1E75520", VA = "0x181E76320")]
	[CompilerGenerated]
	private int DLFHJAFLBNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E768E0", Offset = "0x1E75AE0", VA = "0x181E768E0")]
	[CompilerGenerated]
	private bool FKDGEGNOPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E769B0", Offset = "0x1E75BB0", VA = "0x181E769B0")]
	[CompilerGenerated]
	private int GFACJDCGFOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E777F0", Offset = "0x1E769F0", VA = "0x181E777F0")]
	[CompilerGenerated]
	private void LBHNDOJKECG(object HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1E76D10", Offset = "0x1E75F10", VA = "0x181E76D10")]
	[CompilerGenerated]
	private bool IOJPDLJNOFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BPHGDBCLKMP
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MHPHONFCHIF : DPANGKDHNJC<DKMEBGMBBPL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override EEHKFGNGBPB PKGDKEIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x847C60", Offset = "0x846E60", VA = "0x180847C60", Slot = "125")]
			get
			{
				return default(EEHKFGNGBPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D5A0", Offset = "0x1E7C7A0", VA = "0x181E7D5A0")]
		public MHPHONFCHIF(PKEMJIPKCPK HPFIGCNHCOB, DKMEBGMBBPL FNFDOEGAMFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class DAEIEIMCAGK : ILMMGEDFODO<BEDAPDKKHBF>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E74930", Offset = "0x1E73B30", VA = "0x181E74930")]
		public DAEIEIMCAGK(PKEMJIPKCPK HPFIGCNHCOB, BEDAPDKKHBF BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E747B0", Offset = "0x1E739B0", VA = "0x181E747B0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E74760", Offset = "0x1E73960", VA = "0x181E74760")]
		[CompilerGenerated]
		private bool JKIKAKFHHLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E74640", Offset = "0x1E73840", VA = "0x181E74640")]
		[CompilerGenerated]
		private void BEEBOPKAJIL(bool HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class GKFBMODIHIK : ILMMGEDFODO<IOBICCMHABF>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class MNBNGPKNLKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public GKFBMODIHIK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public MNBNGPKNLKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D810", Offset = "0x1E7CA10", VA = "0x181E7D810")]
			internal void PKNDNPAGFKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D650", Offset = "0x1E7C850", VA = "0x181E7D650")]
			internal bool GBMKOLPFFMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D6A0", Offset = "0x1E7C8A0", VA = "0x181E7D6A0")]
			internal bool GKLJLJJFMKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D6F0", Offset = "0x1E7C8F0", VA = "0x181E7D6F0")]
			internal void NEMIABMHAIA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D600", Offset = "0x1E7C800", VA = "0x181E7D600")]
			internal bool FHHKCNJPCEE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A110", Offset = "0x1E79310", VA = "0x181E7A110")]
		public GKFBMODIHIK(PKEMJIPKCPK HPFIGCNHCOB, IOBICCMHABF BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E79E10", Offset = "0x1E79010", VA = "0x181E79E10", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CFIGMGMIFOH : ILMMGEDFODO<FKJGHGEELIK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class ABDHAMPPFFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public CFIGMGMIFOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ABDHAMPPFFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E70F30", Offset = "0x1E70130", VA = "0x181E70F30")]
			internal object PKNDNPAGFKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E70DC0", Offset = "0x1E6FFC0", VA = "0x181E70DC0")]
			internal bool LFIEFDFKKNB(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E70850", Offset = "0x1E6FA50", VA = "0x181E70850")]
			internal void GBMKOLPFFMO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E70AA0", Offset = "0x1E6FCA0", VA = "0x181E70AA0")]
			internal string GKLJLJJFMKK(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E70EE0", Offset = "0x1E700E0", VA = "0x181E70EE0")]
			internal IReadOnlyList<object> NEMIABMHAIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1E70800", Offset = "0x1E6FA00", VA = "0x181E70800")]
			internal bool FHHKCNJPCEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E70790", Offset = "0x1E6F990", VA = "0x181E70790")]
			internal bool BFOLPNJGFMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1E70E90", Offset = "0x1E70090", VA = "0x181E70E90")]
			internal void MFHLPKDHECF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1E70C00", Offset = "0x1E6FE00", VA = "0x181E70C00")]
			internal bool IANMAAIGEHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1E70C50", Offset = "0x1E6FE50", VA = "0x181E70C50")]
			internal bool JDGIOCFJIJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1E70CA0", Offset = "0x1E6FEA0", VA = "0x181E70CA0")]
			internal void KPENPCHIEAC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E70E40", Offset = "0x1E70040", VA = "0x181E70E40")]
			internal bool MCPHDGMMLAG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E73AF0", Offset = "0x1E72CF0", VA = "0x181E73AF0")]
		public CFIGMGMIFOH(PKEMJIPKCPK HPFIGCNHCOB, FKJGHGEELIK BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E735C0", Offset = "0x1E727C0", VA = "0x181E735C0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class AODKFJINNME : ILMMGEDFODO<NLNJFAJEBJM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class KEPLCCEBBDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public AODKFJINNME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public KEPLCCEBBDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7C110", Offset = "0x1E7B310", VA = "0x181E7C110")]
			internal bool PKNDNPAGFKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E7BFA0", Offset = "0x1E7B1A0", VA = "0x181E7BFA0")]
			internal void GBMKOLPFFMO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1E7C0C0", Offset = "0x1E7B2C0", VA = "0x181E7C0C0")]
			internal bool GKLJLJJFMKK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1E720A0", Offset = "0x1E712A0", VA = "0x181E720A0")]
		public AODKFJINNME(PKEMJIPKCPK HPFIGCNHCOB, NLNJFAJEBJM FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1E71E70", Offset = "0x1E71070", VA = "0x181E71E70", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class DBAFFDAHBKN<TNode> : ILMMGEDFODO<TNode> where TNode : notnull, MLAJNDHGJFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct GNIGEFHPKPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public DBAFFDAHBKN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x39E81F0", Offset = "0x39E73F0", VA = "0x1839E81F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x39E85B0", Offset = "0x39E77B0", VA = "0x1839E85B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct AHNMFEIGGPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public DBAFFDAHBKN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public MKMFEDEKPBJ<IMEMOCGMKGP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B9B0", Offset = "0x3C8ABB0", VA = "0x183C8B9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3C8BD70", Offset = "0x3C8AF70", VA = "0x183C8BD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool ELDLMMJCJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override MKMFEDEKPBJ<IMEMOCGMKGP>? PALBKIGCKED
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x531D4D0", Offset = "0x531C6D0", VA = "0x18531D4D0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F79520", Offset = "0x3F78720", VA = "0x183F79520")]
		protected DBAFFDAHBKN(PKEMJIPKCPK HPFIGCNHCOB, TNode BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x531D160", Offset = "0x531C360", VA = "0x18531D160", Slot = "99")]
		[AsyncStateMachine(typeof(DBAFFDAHBKN<>.GNIGEFHPKPO))]
		public override Task<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> GEFELEPGNJH(string IIADHBOODBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x531D0C0", Offset = "0x531C2C0", VA = "0x18531D0C0", Slot = "123")]
		public sealed override bool AGNKBNOKOJK(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x531D390", Offset = "0x531C590", VA = "0x18531D390", Slot = "111")]
		protected sealed override bool LGCEEILNGGE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x531D430", Offset = "0x531C630", VA = "0x18531D430", Slot = "112")]
		protected override bool PCBLCHHFIOE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x531D280", Offset = "0x531C480", VA = "0x18531D280", Slot = "100")]
		[AsyncStateMachine(typeof(DBAFFDAHBKN<>.AHNMFEIGGPO))]
		public override Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> HGJBLCDOLLO(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class IEALIHONHBO : IODHEBJCFBL<BEFEMBLACMD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class GKNCNICCLAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public IEALIHONHBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public GKNCNICCLAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1E7A180", Offset = "0x1E79380", VA = "0x181E7A180")]
			internal bool BIEEFHELDMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1E7A200", Offset = "0x1E79400", VA = "0x181E7A200")]
			internal void LJKPAAIFABL(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B110", Offset = "0x1E7A310", VA = "0x181E7B110")]
		public IEALIHONHBO(PKEMJIPKCPK HPFIGCNHCOB, BEFEMBLACMD FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1E7AEC0", Offset = "0x1E7A0C0", VA = "0x181E7AEC0", Slot = "125")]
		protected override void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BFPPHEJEBOI : BHALHKPNELH<CJKALHGAJNC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1E72230", Offset = "0x1E71430", VA = "0x181E72230")]
		public BFPPHEJEBOI(PKEMJIPKCPK HPFIGCNHCOB, CJKALHGAJNC BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1E721F0", Offset = "0x1E713F0", VA = "0x181E721F0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class BHALHKPNELH<TNode> : ILMMGEDFODO<TNode> where TNode : notnull, IIEOCLOLCKO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct CICEGFMKDPF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public BHALHKPNELH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4F8F850", Offset = "0x4F8EA50", VA = "0x184F8F850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4F8FBB0", Offset = "0x4F8EDB0", VA = "0x184F8FBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct GGBFKMIBLOE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public BHALHKPNELH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public MKMFEDEKPBJ<IMEMOCGMKGP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x39C8F30", Offset = "0x39C8130", VA = "0x1839C8F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x39C9260", Offset = "0x39C8460", VA = "0x1839C9260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override MKMFEDEKPBJ<OAAIMIGIBKP>? LDDIAOCHMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B450", Offset = "0x4A5A650", VA = "0x184A5B450", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override MKMFEDEKPBJ<IMEMOCGMKGP>? PALBKIGCKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B500", Offset = "0x4A5A700", VA = "0x184A5B500", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F79520", Offset = "0x3F78720", VA = "0x183F79520")]
		public BHALHKPNELH(PKEMJIPKCPK HPFIGCNHCOB, TNode BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B0E0", Offset = "0x4A5A2E0", VA = "0x184A5B0E0", Slot = "99")]
		[AsyncStateMachine(typeof(BHALHKPNELH<>.CICEGFMKDPF))]
		public override Task<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> GEFELEPGNJH(string IIADHBOODBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B040", Offset = "0x4A5A240", VA = "0x184A5B040", Slot = "123")]
		public sealed override bool AGNKBNOKOJK(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B310", Offset = "0x4A5A510", VA = "0x184A5B310", Slot = "111")]
		protected sealed override bool LGCEEILNGGE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B3B0", Offset = "0x4A5A5B0", VA = "0x184A5B3B0", Slot = "112")]
		protected override bool PCBLCHHFIOE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B200", Offset = "0x4A5A400", VA = "0x184A5B200", Slot = "100")]
		[AsyncStateMachine(typeof(BHALHKPNELH<>.GGBFKMIBLOE))]
		public override Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> HGJBLCDOLLO(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class IMGMPIABLDH : IODHEBJCFBL<EBLPJCKANPG>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class OLKBHJHABLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public IMGMPIABLDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public OLKBHJHABLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1E8B8F0", Offset = "0x1E8AAF0", VA = "0x181E8B8F0")]
			internal int BIEEFHELDMM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1E8B970", Offset = "0x1E8AB70", VA = "0x181E8B970")]
			internal void LJKPAAIFABL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B640", Offset = "0x1E7A840", VA = "0x181E7B640")]
		public IMGMPIABLDH(PKEMJIPKCPK HPFIGCNHCOB, EBLPJCKANPG FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B400", Offset = "0x1E7A600", VA = "0x181E7B400", Slot = "125")]
		protected override void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class AHCLJKPAFNF : ILMMGEDFODO<EAPLHHDINAM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83D1F0", Offset = "0x83C3F0", VA = "0x18083D1F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1E71070", Offset = "0x1E70270", VA = "0x181E71070")]
		public AHCLJKPAFNF(PKEMJIPKCPK HPFIGCNHCOB, EAPLHHDINAM BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1E71030", Offset = "0x1E70230", VA = "0x181E71030", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class OFJOLIDFNBB : ILMMGEDFODO<IOJEIOAMMCE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class OCJNEFPPBCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public OFJOLIDFNBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public MDHDNFOPPIJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public OCJNEFPPBCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x1E89040", Offset = "0x1E88240", VA = "0x181E89040")]
			internal bool PKNDNPAGFKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FE60", Offset = "0x1E7F060", VA = "0x181E7FE60")]
			internal void GBMKOLPFFMO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F9B0", Offset = "0x1E7EBB0", VA = "0x181E7F9B0")]
			internal bool FHHKCNJPCEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E540", Offset = "0x1E7D740", VA = "0x181E7E540")]
			internal bool BFOLPNJGFMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x1E81B60", Offset = "0x1E80D60", VA = "0x181E81B60")]
			internal void MFHLPKDHECF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1E81530", Offset = "0x1E80730", VA = "0x181E81530")]
			internal bool KPENPCHIEAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1E81A10", Offset = "0x1E80C10", VA = "0x181E81A10")]
			internal bool MCPHDGMMLAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1E81670", Offset = "0x1E80870", VA = "0x181E81670")]
			internal void LFIEFDFKKNB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E450", Offset = "0x1E7D650", VA = "0x181E7E450")]
			internal bool BEFIACLMGDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E4A0", Offset = "0x1E7D6A0", VA = "0x181E7E4A0")]
			internal bool BELPPIDPMHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x1E88750", Offset = "0x1E87950", VA = "0x181E88750")]
			internal void NOKALEHGPNF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E830", Offset = "0x1E7DA30", VA = "0x181E7E830")]
			internal bool CHFPLCOGGCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F8C0", Offset = "0x1E7EAC0", VA = "0x181E7F8C0")]
			internal bool FCGKNOGBPIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F780", Offset = "0x1E7E980", VA = "0x181E7F780")]
			internal bool EPANHDEFKGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1E88700", Offset = "0x1E87900", VA = "0x181E88700")]
			internal bool NNHLLDLHAHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1E82090", Offset = "0x1E81290", VA = "0x181E82090")]
			internal bool NDBJCKALMNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1E88660", Offset = "0x1E87860", VA = "0x181E88660")]
			internal bool NLPOGECGBCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E8D0", Offset = "0x1E7DAD0", VA = "0x181E7E8D0")]
			internal bool CIOLJNBKIGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x1E80E50", Offset = "0x1E80050", VA = "0x181E80E50")]
			internal bool IPDFOBACHKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x1E81DA0", Offset = "0x1E80FA0", VA = "0x181E81DA0")]
			internal bool MNJADAPLEMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1E80780", Offset = "0x1E7F980", VA = "0x181E80780")]
			internal void HEJHEBFFENH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EC90", Offset = "0x1E7DE90", VA = "0x181E7EC90")]
			internal bool DGPEKDJDDKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x1E888C0", Offset = "0x1E87AC0", VA = "0x181E888C0")]
			internal bool ODOFGOEHIFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x1E80BE0", Offset = "0x1E7FDE0", VA = "0x181E80BE0")]
			internal bool IDFEGDOOHCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x1E81CB0", Offset = "0x1E80EB0", VA = "0x181E81CB0")]
			internal bool MJHIDHIADGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x1E81030", Offset = "0x1E80230", VA = "0x181E81030")]
			internal bool JKECLEDGDGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x1E82150", Offset = "0x1E81350", VA = "0x181E82150")]
			internal bool NJMJAFBJJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F490", Offset = "0x1E7E690", VA = "0x181E7F490")]
			internal bool EKBBKHFFADP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1E803C0", Offset = "0x1E7F5C0", VA = "0x181E803C0")]
			internal bool GKPMFCKLNCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EE20", Offset = "0x1E7E020", VA = "0x181E7EE20")]
			internal void DOKOCAMJLMM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E310", Offset = "0x1E7D510", VA = "0x181E7E310")]
			internal bool APKALGBPDGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F910", Offset = "0x1E7EB10", VA = "0x181E7F910")]
			internal bool FDMDBFKIJAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x1E88D40", Offset = "0x1E87F40", VA = "0x181E88D40")]
			internal void OPPNJNCFLAJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x1E88A10", Offset = "0x1E87C10", VA = "0x181E88A10")]
			internal bool OFFGEEPAFFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x1E81D00", Offset = "0x1E80F00", VA = "0x181E81D00")]
			internal bool MKDNNOHCOME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1E80650", Offset = "0x1E7F850", VA = "0x181E80650")]
			internal void GPJCGLJHBDD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1E821F0", Offset = "0x1E813F0", VA = "0x181E821F0")]
			internal List<HLAGMJMLGPB> NKNFIHNJNLP(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E5E0", Offset = "0x1E7D7E0", VA = "0x181E7E5E0")]
			internal bool BJLNDCPGBNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1E80410", Offset = "0x1E7F610", VA = "0x181E80410")]
			internal int GLBMNPFHIMB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x1E80A20", Offset = "0x1E7FC20", VA = "0x181E80A20")]
			internal void HPOCJPBMNKG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1E80460", Offset = "0x1E7F660", VA = "0x181E80460")]
			internal bool GLDCJMGPBKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EA40", Offset = "0x1E7DC40", VA = "0x181E7EA40")]
			internal bool CMCGLOJJCMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F7D0", Offset = "0x1E7E9D0", VA = "0x181E7F7D0")]
			internal bool EPKEFGBHIEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x1E81C60", Offset = "0x1E80E60", VA = "0x181E81C60")]
			internal int MIDAICAEDAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x1E81480", Offset = "0x1E80680", VA = "0x181E81480")]
			internal void KJOLHIKOLBE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F960", Offset = "0x1E7EB60", VA = "0x181E7F960")]
			internal bool FENAHEHNPIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1E88E90", Offset = "0x1E88090", VA = "0x181E88E90")]
			internal bool PDPKMKGIHHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1E80C80", Offset = "0x1E7FE80", VA = "0x181E80C80")]
			internal bool IFFFBBMFMOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E7E0", Offset = "0x1E7D9E0", VA = "0x181E7E7E0")]
			internal bool CFJKNAHBCEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1E80B90", Offset = "0x1E7FD90", VA = "0x181E80B90")]
			internal bool ICMOIIDLIDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FBD0", Offset = "0x1E7EDD0", VA = "0x181E7FBD0")]
			internal bool FOKDFMGBLLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x1E88BF0", Offset = "0x1E87DF0", VA = "0x181E88BF0")]
			internal string ONLBEMJBNDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1E81140", Offset = "0x1E80340", VA = "0x181E81140")]
			internal void JLHOFBHAPBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1E813E0", Offset = "0x1E805E0", VA = "0x181E813E0")]
			internal int KGALAPOICNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1E805A0", Offset = "0x1E7F7A0", VA = "0x181E805A0")]
			internal void GMNFEOOOPOJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1E81BC0", Offset = "0x1E80DC0", VA = "0x181E81BC0")]
			internal bool MHEPJNODIMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1E81770", Offset = "0x1E80970", VA = "0x181E81770")]
			internal bool LHCBHFJILKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1E821A0", Offset = "0x1E813A0", VA = "0x181E821A0")]
			internal bool NKFNCCDBHHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F690", Offset = "0x1E7E890", VA = "0x181E7F690")]
			internal float ENENPMFMHMB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1E81B00", Offset = "0x1E80D00", VA = "0x181E81B00")]
			internal void MFGKLHHBAJF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F3A0", Offset = "0x1E7E5A0", VA = "0x181E7F3A0")]
			internal bool EGJFAOIIDCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F440", Offset = "0x1E7E640", VA = "0x181E7F440")]
			internal bool EJGMIOGEEKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F640", Offset = "0x1E7E840", VA = "0x181E7F640")]
			internal bool EMGIMLGAIMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1E80F40", Offset = "0x1E80140", VA = "0x181E80F40")]
			internal bool JEKLFFAPIKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1E80550", Offset = "0x1E7F750", VA = "0x181E80550")]
			internal bool GMGOMPKCOHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EEF0", Offset = "0x1E7E0F0", VA = "0x181E7EEF0")]
			internal bool EADPCIDEKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FFB0", Offset = "0x1E7F1B0", VA = "0x181E7FFB0")]
			internal void GICHPKHDBNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E1D0", Offset = "0x1E7D3D0", VA = "0x181E7E1D0")]
			internal string AIBLKIDNNLF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1E80D20", Offset = "0x1E7FF20", VA = "0x181E80D20")]
			internal void ILAMPHFKPGK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1E88B50", Offset = "0x1E87D50", VA = "0x181E88B50")]
			internal bool OLDGHNLFEFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1E88C40", Offset = "0x1E87E40", VA = "0x181E88C40")]
			internal bool OPADOAHMDDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1E81F50", Offset = "0x1E81150", VA = "0x181E81F50")]
			internal bool NAOBELCEKMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EFE0", Offset = "0x1E7E1E0", VA = "0x181E7EFE0")]
			internal void ECFKCENKINI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x1E88A60", Offset = "0x1E87C60", VA = "0x181E88A60")]
			internal bool OHLKCPJFCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E400", Offset = "0x1E7D600", VA = "0x181E7E400")]
			internal bool BDPPEANIMCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F730", Offset = "0x1E7E930", VA = "0x181E7F730")]
			internal bool EOLLBOOKFJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FC70", Offset = "0x1E7EE70", VA = "0x181E7FC70")]
			internal bool FOLDGALBMLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1E81330", Offset = "0x1E80530", VA = "0x181E81330")]
			internal void KAFEHKGAJOI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1E88B00", Offset = "0x1E87D00", VA = "0x181E88B00")]
			internal bool OJJJCBIPNEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E790", Offset = "0x1E7D990", VA = "0x181E7E790")]
			internal bool CFBODODFKKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1E7ED30", Offset = "0x1E7DF30", VA = "0x181E7ED30")]
			internal bool DKJEKPFNGAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1E80A80", Offset = "0x1E7FC80", VA = "0x181E80A80")]
			internal bool HPPLKDOIMBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1E891A0", Offset = "0x1E883A0", VA = "0x181E891A0")]
			internal void PMLNAEEDDME(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1E81D50", Offset = "0x1E80F50", VA = "0x181E81D50")]
			internal bool MLOGOJLFJKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FAE0", Offset = "0x1E7ECE0", VA = "0x181E7FAE0")]
			internal bool FKNKGCGFOBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FD60", Offset = "0x1E7EF60", VA = "0x181E7FD60")]
			internal bool GAGPPKLOJCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E6E0", Offset = "0x1E7D8E0", VA = "0x181E7E6E0")]
			internal bool CDGPEOABJBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1E809D0", Offset = "0x1E7FBD0", VA = "0x181E809D0")]
			internal int HMKNDEHCEFF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FA00", Offset = "0x1E7EC00", VA = "0x181E7FA00")]
			internal void FHMNEOLDOPN(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1E88FF0", Offset = "0x1E881F0", VA = "0x181E88FF0")]
			internal bool PHLBIDPHEML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FB30", Offset = "0x1E7ED30", VA = "0x181E7FB30")]
			internal bool FLKIJLPFEFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1E81720", Offset = "0x1E80920", VA = "0x181E81720")]
			internal int LGCCILBMFIH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1E807E0", Offset = "0x1E7F9E0", VA = "0x181E807E0")]
			internal void HFIDPAOALAD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1E88E40", Offset = "0x1E88040", VA = "0x181E88E40")]
			internal bool PCLMDCJKANF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F300", Offset = "0x1E7E500", VA = "0x181E7F300")]
			internal bool EECDKEIJCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x1E89150", Offset = "0x1E88350", VA = "0x181E89150")]
			internal int PLOFDCLNNOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FDB0", Offset = "0x1E7EFB0", VA = "0x181E7FDB0")]
			internal void GAHHGMMCHHG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E920", Offset = "0x1E7DB20", VA = "0x181E7E920")]
			internal bool CIPCDMMFALH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FCC0", Offset = "0x1E7EEC0", VA = "0x181E7FCC0")]
			internal bool FPJENKAMPGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F350", Offset = "0x1E7E550", VA = "0x181E7F350")]
			internal bool EEEDOPPCBBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F530", Offset = "0x1E7E730", VA = "0x181E7F530")]
			internal int EKMMONGCLDP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1E88C90", Offset = "0x1E87E90", VA = "0x181E88C90")]
			internal void OPOPOEMNKKA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1E81E60", Offset = "0x1E81060", VA = "0x181E81E60")]
			internal bool MOHKJGGJHHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1E81430", Offset = "0x1E80630", VA = "0x181E81430")]
			internal bool KHOFPHAIAFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1E80EF0", Offset = "0x1E800F0", VA = "0x181E80EF0")]
			internal bool JCFIOOLEDMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1E820E0", Offset = "0x1E812E0", VA = "0x181E820E0")]
			internal object NJCNOJAGDFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1E80840", Offset = "0x1E7FA40", VA = "0x181E80840")]
			internal void HHHONGMCNOL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EF90", Offset = "0x1E7E190", VA = "0x181E7EF90")]
			internal bool EBOIHBPEAKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1E804B0", Offset = "0x1E7F6B0", VA = "0x181E804B0")]
			internal bool GLLFHLCCIEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1E806B0", Offset = "0x1E7F8B0", VA = "0x181E806B0")]
			internal object HBGPKFDOOKG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1E81200", Offset = "0x1E80400", VA = "0x181E81200")]
			internal void JOONHOOKDBP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FD10", Offset = "0x1E7EF10", VA = "0x181E7FD10")]
			internal bool FPLBGDIBIPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E815D0", Offset = "0x1E807D0", VA = "0x181E815D0")]
			internal int KPONBBNHDGF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E9E0", Offset = "0x1E7DBE0", VA = "0x181E7E9E0")]
			internal void CLAMEHLOIBO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EC40", Offset = "0x1E7DE40", VA = "0x181E7EC40")]
			internal bool DFEIAOPLJIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1E89100", Offset = "0x1E88300", VA = "0x181E89100")]
			internal bool PLMDCNBOGPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FA90", Offset = "0x1E7EC90", VA = "0x181E7FA90")]
			internal bool FIPGLLNEIBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FF10", Offset = "0x1E7F110", VA = "0x181E7FF10")]
			internal int GGGLHMGKEJB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E730", Offset = "0x1E7D930", VA = "0x181E7E730")]
			internal void CELKLIHIJCA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F6E0", Offset = "0x1E7E8E0", VA = "0x181E7F6E0")]
			internal bool ENMHJEKLNJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1E811B0", Offset = "0x1E803B0", VA = "0x181E811B0")]
			internal bool JMEGPGJDGAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1E812E0", Offset = "0x1E804E0", VA = "0x181E812E0")]
			internal bool JPFMLBKAPEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E180", Offset = "0x1E7D380", VA = "0x181E7E180")]
			internal float AELFALCINIF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E889B0", Offset = "0x1E87BB0", VA = "0x181E889B0")]
			internal void OFEBHMAOMLP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1E88870", Offset = "0x1E87A70", VA = "0x181E88870")]
			internal bool OAFGJLDDKOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E270", Offset = "0x1E7D470", VA = "0x181E7E270")]
			internal bool AIKBHINKEFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1E80C30", Offset = "0x1E7FE30", VA = "0x181E80C30")]
			internal bool IEGEPIMBBPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E2C0", Offset = "0x1E7D4C0", VA = "0x181E7E2C0")]
			internal float AKOCLOPLFHD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1E80720", Offset = "0x1E7F920", VA = "0x181E80720")]
			internal void HDEFPGMOIEM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1E81EB0", Offset = "0x1E810B0", VA = "0x181E81EB0")]
			internal bool MOMHJLGNEND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1E80FE0", Offset = "0x1E801E0", VA = "0x181E80FE0")]
			internal bool JIOHAMIJFNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1E81C10", Offset = "0x1E80E10", VA = "0x181E81C10")]
			internal string MHPNHFEGJAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EE80", Offset = "0x1E7E080", VA = "0x181E7EE80")]
			internal void DPODMIDBDKM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E220", Offset = "0x1E7D420", VA = "0x181E7E220")]
			internal bool AIFGDFGJFMI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1E88910", Offset = "0x1E87B10", VA = "0x181E88910")]
			internal bool OEBGIMHFMPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FF60", Offset = "0x1E7F160", VA = "0x181E7FF60")]
			internal bool GGIIHOPJOCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F3F0", Offset = "0x1E7E5F0", VA = "0x181E7F3F0")]
			internal bool EGKNEOFKKJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1E80980", Offset = "0x1E7FB80", VA = "0x181E80980")]
			internal string HKGAGGOJKEI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1E80AD0", Offset = "0x1E7FCD0", VA = "0x181E80AD0")]
			internal void IAGCONCKHEC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E3B0", Offset = "0x1E7D5B0", VA = "0x181E7E3B0")]
			internal bool BCBEIDADNMH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1E81FF0", Offset = "0x1E811F0", VA = "0x181E81FF0")]
			internal bool NCOJKKGOONP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1E818B0", Offset = "0x1E80AB0", VA = "0x181E818B0")]
			internal bool LPLFNOKEMDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E80EA0", Offset = "0x1E800A0", VA = "0x181E80EA0")]
			internal bool IPFNMGPABCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1E81AB0", Offset = "0x1E80CB0", VA = "0x181E81AB0")]
			internal string MFGEMDDOPJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1E88800", Offset = "0x1E87A00", VA = "0x181E88800")]
			internal void NOPNNIOCBBK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EA90", Offset = "0x1E7DC90", VA = "0x181E7EA90")]
			internal bool COIFKICJLDI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1E80B40", Offset = "0x1E7FD40", VA = "0x181E80B40")]
			internal bool IAPFPGHKMGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1E80CD0", Offset = "0x1E7FED0", VA = "0x181E80CD0")]
			internal bool IINHEIIPEIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EF40", Offset = "0x1E7E140", VA = "0x181E7EF40")]
			internal bool EAHGBOBPBNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1E81900", Offset = "0x1E80B00", VA = "0x181E81900")]
			internal string MCBEFEFGMNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EB80", Offset = "0x1E7DD80", VA = "0x181E7EB80")]
			internal void DBGLFNKHECE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1E88CF0", Offset = "0x1E87EF0", VA = "0x181E88CF0")]
			internal bool OPPDFNMNKHL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F580", Offset = "0x1E7E780", VA = "0x181E7F580")]
			internal bool ELJBOJGHFDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EBF0", Offset = "0x1E7DDF0", VA = "0x181E7EBF0")]
			internal bool DCIJABCOOID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E80F90", Offset = "0x1E80190", VA = "0x181E80F90")]
			internal bool JGMJDHPKOML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1E88DF0", Offset = "0x1E87FF0", VA = "0x181E88DF0")]
			internal string PBOBAJBGKAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F5D0", Offset = "0x1E7E7D0", VA = "0x181E7F5D0")]
			internal void EMFJJFNJPLE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EB30", Offset = "0x1E7DD30", VA = "0x181E7EB30")]
			internal bool DAKMJBMAGAH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E690", Offset = "0x1E7D890", VA = "0x181E7E690")]
			internal bool BLJDFJNLJGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1E88960", Offset = "0x1E87B60", VA = "0x181E88960")]
			internal bool OENEIFEAHGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FE10", Offset = "0x1E7F010", VA = "0x181E7FE10")]
			internal bool GAOOEPFMNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1E81F00", Offset = "0x1E81100", VA = "0x181E81F00")]
			internal string MPGPNKJBHPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1E89090", Offset = "0x1E88290", VA = "0x181E89090")]
			internal void PLHGDMLBDKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E81290", Offset = "0x1E80490", VA = "0x181E81290")]
			internal bool JPAJEJMEJAI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E88BA0", Offset = "0x1E87DA0", VA = "0x181E88BA0")]
			internal bool ONLADBKEEJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FEC0", Offset = "0x1E7F0C0", VA = "0x181E7FEC0")]
			internal bool GCGBKLNJKKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E360", Offset = "0x1E7D560", VA = "0x181E7E360")]
			internal bool BBFIBKKGFCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EAE0", Offset = "0x1E7DCE0", VA = "0x181E7EAE0")]
			internal string COMNNCEBLKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1E810D0", Offset = "0x1E802D0", VA = "0x181E810D0")]
			internal void JLGEDKDLPJI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E88F30", Offset = "0x1E88130", VA = "0x181E88F30")]
			internal bool PEGLKGHALLN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E81860", Offset = "0x1E80A60", VA = "0x181E81860")]
			internal bool LOFLCFPNKCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1E80600", Offset = "0x1E7F800", VA = "0x181E80600")]
			internal bool GMOEGDNLOPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1E7ED80", Offset = "0x1E7DF80", VA = "0x181E7ED80")]
			internal bool DMAGJBKDDFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E88EE0", Offset = "0x1E880E0", VA = "0x181E88EE0")]
			internal string PECOHNFOFBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E970", Offset = "0x1E7DB70", VA = "0x181E7E970")]
			internal void CKJIMBMFMDP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E88DA0", Offset = "0x1E87FA0", VA = "0x181E88DA0")]
			internal bool PBBBGCCIIOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E81810", Offset = "0x1E80A10", VA = "0x181E81810")]
			internal bool LLFMBBNBNBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F4E0", Offset = "0x1E7E6E0", VA = "0x181E7F4E0")]
			internal bool EKEGNEJGGID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1E80370", Offset = "0x1E7F570", VA = "0x181E80370")]
			internal bool GJJNOHNNGCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1E81FA0", Offset = "0x1E811A0", VA = "0x181E81FA0")]
			internal string NBABCHHEFJP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1E89200", Offset = "0x1E88400", VA = "0x181E89200")]
			internal void PNCBMHIHPJF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1E80D90", Offset = "0x1E7FF90", VA = "0x181E80D90")]
			internal bool ILLEBKKOOML(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F870", Offset = "0x1E7EA70", VA = "0x181E7F870")]
			internal bool FAJIFMFPNMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F2B0", Offset = "0x1E7E4B0", VA = "0x181E7F2B0")]
			internal bool ECKAMOHOJMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E590", Offset = "0x1E7D790", VA = "0x181E7E590")]
			internal bool BGAJDJALDIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E82040", Offset = "0x1E81240", VA = "0x181E82040")]
			internal string NDAPPCFHFIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E80DE0", Offset = "0x1E7FFE0", VA = "0x181E80DE0")]
			internal void INCENBBNJKA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FB80", Offset = "0x1E7ED80", VA = "0x181E7FB80")]
			internal bool FMNJGGFEGOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E88610", Offset = "0x1E87810", VA = "0x181E88610")]
			internal bool NLGAPEACKPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E81580", Offset = "0x1E80780", VA = "0x181E81580")]
			internal bool KPGGINHIEKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1E7ECE0", Offset = "0x1E7DEE0", VA = "0x181E7ECE0")]
			internal string DJOLMCJMHNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E81950", Offset = "0x1E80B50", VA = "0x181E81950")]
			internal void MCELMJPENNM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1E80500", Offset = "0x1E7F700", VA = "0x181E80500")]
			internal bool GMBDCPCLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1E81390", Offset = "0x1E80590", VA = "0x181E81390")]
			internal bool KFKHCPHBAJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E7FC20", Offset = "0x1E7EE20", VA = "0x181E7FC20")]
			internal bool FOKPJAEHGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E81A60", Offset = "0x1E80C60", VA = "0x181E81A60")]
			internal string MFCHIMBKDFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E81DF0", Offset = "0x1E80FF0", VA = "0x181E81DF0")]
			internal void MNLANAGPDFI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E4F0", Offset = "0x1E7D6F0", VA = "0x181E7E4F0")]
			internal bool BFOHPHFEPDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E819C0", Offset = "0x1E80BC0", VA = "0x181E819C0")]
			internal bool MCOMNDBFNEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E817C0", Offset = "0x1E809C0", VA = "0x181E817C0")]
			internal bool LKJEOLMEBDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1E81620", Offset = "0x1E80820", VA = "0x181E81620")]
			internal string LFFMOGGLIHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1E88F80", Offset = "0x1E88180", VA = "0x181E88F80")]
			internal void PHDAPOMEKGA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EDD0", Offset = "0x1E7DFD0", VA = "0x181E7EDD0")]
			internal bool DOFDEFAHLNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1E88AB0", Offset = "0x1E87CB0", VA = "0x181E88AB0")]
			internal bool OJHEOJIKCLA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1E886B0", Offset = "0x1E878B0", VA = "0x181E886B0")]
			internal float NMIODGEEELN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1E80920", Offset = "0x1E7FB20", VA = "0x181E80920")]
			internal void HKBBPHOHEFI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1E887B0", Offset = "0x1E879B0", VA = "0x181E887B0")]
			internal bool NOLIMBNPIBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1E808D0", Offset = "0x1E7FAD0", VA = "0x181E808D0")]
			internal bool HIPLBLIODLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1E81080", Offset = "0x1E80280", VA = "0x181E81080")]
			internal bool JKGKEEODPHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1E7F820", Offset = "0x1E7EA20", VA = "0x181E7F820")]
			internal int FAAIHGEAEMP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E630", Offset = "0x1E7D830", VA = "0x181E7E630")]
			internal void BJOCPEOEPPE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1E816D0", Offset = "0x1E808D0", VA = "0x181E816D0")]
			internal bool LFKKINBGCAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1E814E0", Offset = "0x1E806E0", VA = "0x181E814E0")]
			internal bool KMNHKNLBEKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E880", Offset = "0x1E7DA80", VA = "0x181E7E880")]
			internal bool CHMLICGBKPE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class DOJMPNMMBKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public OCJNEFPPBCK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public DOJMPNMMBKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1E74D20", Offset = "0x1E73F20", VA = "0x181E74D20")]
			internal void LANHDFHOHCL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class NKGNIHHPLJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public NKGNIHHPLJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E080", Offset = "0x1E7D280", VA = "0x181E7E080")]
			internal bool EMLGHGMCFMG(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly HOCKFEMGHBJ GAJDMCJJMAH;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1E8B0E0", Offset = "0x1E8A2E0", VA = "0x181E8B0E0")]
		public OFJOLIDFNBB(PKEMJIPKCPK HPFIGCNHCOB, IOJEIOAMMCE BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1E89270", Offset = "0x1E88470", VA = "0x181E89270", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class BENOGIOHGLG : BHALHKPNELH<CCPCLCEJMLD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool PMAPBHDLMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool PEMCKNIDLJN
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1E721B0", Offset = "0x1E713B0", VA = "0x181E721B0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x868DF0", Offset = "0x867FF0", VA = "0x180868DF0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1E72150", Offset = "0x1E71350", VA = "0x181E72150")]
		public BENOGIOHGLG(PKEMJIPKCPK HPFIGCNHCOB, CCPCLCEJMLD BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1E72110", Offset = "0x1E71310", VA = "0x181E72110", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private sealed class ELAHNDMAKAH : ILMMGEDFODO<CHHBHKGPAIC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x845520", Offset = "0x844720", VA = "0x180845520", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1E787B0", Offset = "0x1E779B0", VA = "0x181E787B0")]
		public ELAHNDMAKAH(PKEMJIPKCPK HPFIGCNHCOB, CHHBHKGPAIC BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1E78770", Offset = "0x1E77970", VA = "0x181E78770", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class JNMJLBFICCA : ILMMGEDFODO<DCELOPICEGC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x838B00", Offset = "0x837D00", VA = "0x180838B00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BB50", Offset = "0x1E7AD50", VA = "0x181E7BB50")]
		public JNMJLBFICCA(PKEMJIPKCPK HPFIGCNHCOB, DCELOPICEGC BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "111")]
		protected override bool LGCEEILNGGE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BB10", Offset = "0x1E7AD10", VA = "0x181E7BB10", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MFKGEEDFOHH : ILMMGEDFODO<FHMEAPKDIAM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x832EE0", Offset = "0x8320E0", VA = "0x180832EE0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool DIFNJINJGJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1E7D550", Offset = "0x1E7C750", VA = "0x181E7D550", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override bool DODDAOPLCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D4E0", Offset = "0x1E7C6E0", VA = "0x181E7D4E0")]
		public MFKGEEDFOHH(PKEMJIPKCPK HPFIGCNHCOB, FHMEAPKDIAM BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D4A0", Offset = "0x1E7C6A0", VA = "0x181E7D4A0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class AFJFGIGOCMH : ILMMGEDFODO<EGKOOKJCNIN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x847C60", Offset = "0x846E60", VA = "0x180847C60", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DIFNJINJGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1E8FF70", Offset = "0x1E8F170", VA = "0x181E8FF70", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected override bool DODDAOPLCOK
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FF00", Offset = "0x1E8F100", VA = "0x181E8FF00")]
		public AFJFGIGOCMH(PKEMJIPKCPK HPFIGCNHCOB, EGKOOKJCNIN BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FEC0", Offset = "0x1E8F0C0", VA = "0x181E8FEC0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class HANHOBPNAPP : IODHEBJCFBL<MMBLIDACMGF>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class OLCDNKBHIKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public HANHOBPNAPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public OLCDNKBHIKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1EA90A0", Offset = "0x1EA82A0", VA = "0x181EA90A0")]
			internal float BIEEFHELDMM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1EA9120", Offset = "0x1EA8320", VA = "0x181EA9120")]
			internal void LJKPAAIFABL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1E97730", Offset = "0x1E96930", VA = "0x181E97730")]
		public HANHOBPNAPP(PKEMJIPKCPK HPFIGCNHCOB, MMBLIDACMGF FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1E97430", Offset = "0x1E96630", VA = "0x181E97430", Slot = "125")]
		protected override void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class ONPCCDDDFFB : DBAFFDAHBKN<BFJLGLEFDKL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x9E5750", Offset = "0x9E4950", VA = "0x1809E5750", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1EA91C0", Offset = "0x1EA83C0", VA = "0x181EA91C0")]
		public ONPCCDDDFFB(PKEMJIPKCPK HPFIGCNHCOB, BFJLGLEFDKL BKOKOKIHONK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class BBMMNIMABIM : IODHEBJCFBL<BAKMGHCJCHM>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class FJPKFNBNLNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public BBMMNIMABIM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public FJPKFNBNLNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1E968F0", Offset = "0x1E95AF0", VA = "0x181E968F0")]
			internal int BIEEFHELDMM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1E96970", Offset = "0x1E95B70", VA = "0x181E96970")]
			internal void LJKPAAIFABL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E90E40", Offset = "0x1E90040", VA = "0x181E90E40")]
		public BBMMNIMABIM(PKEMJIPKCPK HPFIGCNHCOB, BAKMGHCJCHM FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E90B40", Offset = "0x1E8FD40", VA = "0x181E90B40", Slot = "125")]
		protected override void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class AMKBNCEAKEF : DPANGKDHNJC<LJGFHGLLFCB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override EEHKFGNGBPB PKGDKEIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "125")]
			get
			{
				return default(EEHKFGNGBPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E90680", Offset = "0x1E8F880", VA = "0x181E90680")]
		public AMKBNCEAKEF(PKEMJIPKCPK HPFIGCNHCOB, LJGFHGLLFCB FNFDOEGAMFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class LLCOAJJAKMM : ILMMGEDFODO<CHJNEAPICHF>
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1800", Offset = "0x1EA0A00", VA = "0x181EA1800")]
		public LLCOAJJAKMM(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class ILMMGEDFODO<TNode> : OFFHOBPALPP, IDisposable where TNode : notnull, CHJNEAPICHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected readonly struct NADPDEHEMHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public readonly string EALCMGGJAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public readonly string PDNFHJHCKLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public readonly string EEKLENDOLAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public readonly NMJACANGCLA DBLFKLLODLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public readonly CLFDMMLALHL IIJNJHFLKHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public readonly Func<string, bool> LKLFLOPECIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public readonly string HEHMDNHEADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public readonly Func<string, bool> GJAODDLBHFD;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x418CC10", Offset = "0x418BE10", VA = "0x18418CC10")]
			public NADPDEHEMHC(string BKILHKFIMDO, string CCPCDLCPPMN, string AONMNOEAPAD, NMJACANGCLA EAKPDOKIPDA, CLFDMMLALHL JLPEOHIEBAC, Func<string, bool> JGKDJNLKDIG, string MBDKPIDCEGM, Func<string, bool> EFNLJEHMNMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class ANACMJIKGJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public ILMMGEDFODO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public PKEMJIPKCPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ANACMJIKGJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x3D64570", Offset = "0x3D63770", VA = "0x183D64570")]
			internal KOINNPBGCKM OAPCBPOJLGB(NPGHGBANIDL portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private struct MLLPCCPNCOC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public ILMMGEDFODO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4146590", Offset = "0x4145790", VA = "0x184146590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private struct ACKPDCLDENA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public ILMMGEDFODO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public CPFICFJNHPL? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public AOFKOPJBKJN? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x3BA33A0", Offset = "0x3BA25A0", VA = "0x183BA33A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3BA3630", Offset = "0x3BA2830", VA = "0x183BA3630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KBHDEDFCEPH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000067")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000150")]
				public KBHDEDFCEPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000151")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x3343F90", Offset = "0x3343190", VA = "0x183343F90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public ILMMGEDFODO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public MDHDNFOPPIJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public KBHDEDFCEPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			internal string IBFFMCFFLHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
			internal void LGDJCNOKMGL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3E3E490", Offset = "0x3E3D690", VA = "0x183E3E490")]
			[AsyncStateMachine(typeof(ILMMGEDFODO<>.KBHDEDFCEPH.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void EMMFHNACKKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class CJHNAJJDFFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public CJHNAJJDFFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x505D5D0", Offset = "0x505C7D0", VA = "0x18505D5D0")]
			internal bool BIDBDOLPNJE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x505D6B0", Offset = "0x505C8B0", VA = "0x18505D6B0")]
			internal bool KMEKEGCBMMI(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private struct BFJACHNBCIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public ILMMGEDFODO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x4A54070", Offset = "0x4A53270", VA = "0x184A54070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x4A54350", Offset = "0x4A53550", VA = "0x184A54350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly PKEMJIPKCPK PJAOKDDOCBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly bool CPOGLLJCKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private PLMMFEMJMLP<IMEMOCGMKGP, KOINNPBGCKM> IKNLEOCGFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private PLMMFEMJMLP<IMEMOCGMKGP, LLGHDCCGOFI> APHGLFGHMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private List<Action> JKLLCOFJHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[CompilerGenerated]
		private Action<MKMFEDEKPBJ<IMEMOCGMKGP>>? CGLOOJENMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CompilerGenerated]
		private Action<MKMFEDEKPBJ<IMEMOCGMKGP>, LLGHDCCGOFI>? FCDKIBCJEPL;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected MPMGBKLANIH BGEPIDGNEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x3B21240", Offset = "0x3B20440", VA = "0x183B21240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected TNode KPAEKEKMDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public BEGCOIKGLLD<ODBIIIHGKLL> LBLKIOECEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7E0", Offset = "0xA4C9E0", VA = "0x180A4D7E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(BEGCOIKGLLD<ODBIIIHGKLL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public MKMFEDEKPBJ<CMHJLPOOKMO> OLHJBFLLEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x3B261A0", Offset = "0x3B253A0", VA = "0x183B261A0", Slot = "6")]
			get
			{
				return default(MKMFEDEKPBJ<CMHJLPOOKMO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public object FNJNMMOAFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x3572A20", Offset = "0x3571C20", VA = "0x183572A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool BKKHAEECJAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int HJNOELOMHDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x3B25EC0", Offset = "0x3B250C0", VA = "0x183B25EC0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public MNMPOJDENIN LIOLGDNEBOG
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x3B25E80", Offset = "0x3B25080", VA = "0x183B25E80", Slot = "10")]
			get
			{
				return default(MNMPOJDENIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string GHFCFKGDKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x3B26330", Offset = "0x3B25530", VA = "0x183B26330", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected virtual bool DODDAOPLCOK
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public MKMFEDEKPBJ<MPIGEJKPHAJ> CGMBJJLALDP
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x864320", VA = "0x180865120", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MKMFEDEKPBJ<MPIGEJKPHAJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA5E750", Offset = "0xA5D950", VA = "0x180A5E750")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool DIFNJINJGJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool PMAPBHDLMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual NPDHIKFALGD CEJPEABLOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x9D70F0", Offset = "0x9D62F0", VA = "0x1809D70F0", Slot = "93")]
			get
			{
				return default(NPDHIKFALGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool FGJNAIHFLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x3B25CB0", Offset = "0x3B24EB0", VA = "0x183B25CB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool ALBGDCPNBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x3B25D00", Offset = "0x3B24F00", VA = "0x183B25D00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool INBFLCNDIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x3B25D50", Offset = "0x3B24F50", VA = "0x183B25D50", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int FBNGHFBHKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x3B26160", Offset = "0x3B25360", VA = "0x183B26160", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool ABONOAAIGDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x3B25FF0", Offset = "0x3B251F0", VA = "0x183B25FF0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool ODHGIJEEFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x3B25DE0", Offset = "0x3B24FE0", VA = "0x183B25DE0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool MPNMAFHGNIF
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xB9ED60", Offset = "0xB9DF60", VA = "0x180B9ED60", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB9ED70", Offset = "0xB9DF70", VA = "0x180B9ED70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool BCGJGPNPGJE
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool IHDAOOKHLEH
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x3B25DA0", Offset = "0x3B24FA0", VA = "0x183B25DA0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool MCNAJICJGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x3B25F50", Offset = "0x3B25150", VA = "0x183B25F50", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public CPFICFJNHPL IKDGFFADEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x3B260C0", Offset = "0x3B252C0", VA = "0x183B260C0", Slot = "27")]
			get
			{
				return default(CPFICFJNHPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public AOFKOPJBKJN MBPJHPHFEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x3B26110", Offset = "0x3B25310", VA = "0x183B26110", Slot = "29")]
			get
			{
				return default(AOFKOPJBKJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool MFEIKHKACLE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual OKDKGJBOEGG? LEEJMPEPDLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual FLJPHBEGHJI? GBLFMJIIPBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual IEnumerable<BEGCOIKGLLD<HLKKEFMLJPC>>? PCAGOBBCMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool EFGEMKLOBPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x3B25E30", Offset = "0x3B25030", VA = "0x183B25E30", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public BEGCOIKGLLD<OAAIMIGIBKP> DAOADGCAPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x3B26030", Offset = "0x3B25230", VA = "0x183B26030", Slot = "55")]
			get
			{
				return default(BEGCOIKGLLD<OAAIMIGIBKP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MKMFEDEKPBJ<OAAIMIGIBKP> MEBGPMMMIBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3B25F00", Offset = "0x3B25100", VA = "0x183B25F00", Slot = "56")]
			get
			{
				return default(MKMFEDEKPBJ<OAAIMIGIBKP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool ELDLMMJCJHF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual MKMFEDEKPBJ<OAAIMIGIBKP>? LDDIAOCHMLB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool PEMCKNIDLJN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool OAHLIBMJMHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x3B25FA0", Offset = "0x3B251A0", VA = "0x183B25FA0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x7D23A0", Offset = "0x7D15A0", VA = "0x1807D23A0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x7D2420", Offset = "0x7D1620", VA = "0x1807D2420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private string HFEADFHIGNI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x7D2350", Offset = "0x7D1550", VA = "0x1807D2350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BEGCOIKGLLD<HLKKEFMLJPC> KCEOJDALNFN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x3B26080", Offset = "0x3B25280", VA = "0x183B26080", Slot = "62")]
			get
			{
				return default(BEGCOIKGLLD<HLKKEFMLJPC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public BEGCOIKGLLD<HLKKEFMLJPC>? EPLPJBLGCNC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B26210", Offset = "0x3B25410", VA = "0x183B26210", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public NOGOGJJGMED<IMEMOCGMKGP, LLGHDCCGOFI> ONHCJAIAJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B262F0", Offset = "0x3B254F0", VA = "0x183B262F0", Slot = "64")]
			get
			{
				return default(NOGOGJJGMED<IMEMOCGMKGP, LLGHDCCGOFI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual MKMFEDEKPBJ<IMEMOCGMKGP>? PALBKIGCKED
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool EHCGENKKICI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool MGPAECBOLNB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KBHBIJKNLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x3B24E90", Offset = "0x3B24090", VA = "0x183B24E90", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x3B228B0", Offset = "0x3B21AB0", VA = "0x183B228B0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DANKLLHBAJH PHDODAMDPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x3B23D50", Offset = "0x3B22F50", VA = "0x183B23D50", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x3B23CB0", Offset = "0x3B22EB0", VA = "0x183B23CB0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FEBGEJJGJCA OBBOBGDNMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3B21CD0", Offset = "0x3B20ED0", VA = "0x183B21CD0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x3B24F30", Offset = "0x3B24130", VA = "0x183B24F30", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FHAKBDDPKJD
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3B21590", Offset = "0x3B20790", VA = "0x183B21590", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x3B24950", Offset = "0x3B23B50", VA = "0x183B24950", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KBHPALIOGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x3B227F0", Offset = "0x3B219F0", VA = "0x183B227F0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x3B23980", Offset = "0x3B22B80", VA = "0x183B23980", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>, LLGHDCCGOFI> MDIPONNFILJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x3B23630", Offset = "0x3B22830", VA = "0x183B23630", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x3B245D0", Offset = "0x3B237D0", VA = "0x183B245D0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>, LLGHDCCGOFI> OICFCEFLIEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x3B214D0", Offset = "0x3B206D0", VA = "0x183B214D0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x3B23A50", Offset = "0x3B22C50", VA = "0x183B23A50", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>> DMILAOKCPAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x3B249E0", Offset = "0x3B23BE0", VA = "0x183B249E0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x3B24FD0", Offset = "0x3B241D0", VA = "0x183B24FD0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>, MKMFEDEKPBJ<IMEMOCGMKGP>> KDOLCILPFAH
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x3B20F50", Offset = "0x3B20150", VA = "0x183B20F50", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x3B247D0", Offset = "0x3B239D0", VA = "0x183B247D0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>, LLGHDCCGOFI> EHJOLPBHDOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x3B243E0", Offset = "0x3B235E0", VA = "0x183B243E0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x3B21410", Offset = "0x3B20610", VA = "0x183B21410", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MKMFEDEKPBJ<IMEMOCGMKGP>, MKMFEDEKPBJ<IMEMOCGMKGP>> GMOBLNFBFMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x3B236F0", Offset = "0x3B228F0", VA = "0x183B236F0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3B24890", Offset = "0x3B23A90", VA = "0x183B24890", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3B25790", Offset = "0x3B24990", VA = "0x183B25790")]
		[LCJOOIGDAHJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[LCJOOIGDAHJ("Need to handle `Name` better.")]
		protected ILMMGEDFODO(PKEMJIPKCPK HPFIGCNHCOB, TNode BKOKOKIHONK, bool MPEKFMHACMM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3B21640", Offset = "0x3B20840", VA = "0x183B21640", Slot = "86")]
		protected virtual void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3B22E40", Offset = "0x3B22040", VA = "0x183B22E40", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3B23EC0", Offset = "0x3B230C0", VA = "0x183B23EC0", Slot = "9")]
		[AsyncStateMachine(typeof(ILMMGEDFODO<>.MLLPCCPNCOC))]
		public void HCONGEAJKDH(int DGDCEMECHLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3B22950", Offset = "0x3B21B50", VA = "0x183B22950")]
		public bool DNJGPLACIEG([In] CPFICFJNHPL HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3B23B10", Offset = "0x3B22D10", VA = "0x183B23B10")]
		public bool FIMJAEPKENM([In] AOFKOPJBKJN HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3B237B0", Offset = "0x3B229B0", VA = "0x183B237B0", Slot = "31")]
		public void EMGEPGMPLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3B210F0", Offset = "0x3B202F0", VA = "0x183B210F0", Slot = "32")]
		[AsyncStateMachine(typeof(ILMMGEDFODO<>.ACKPDCLDENA))]
		public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> BLODBIEAEPM(CPFICFJNHPL? HNNAMHMDPNC, AOFKOPJBKJN? LNJHJGHHPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "96")]
		public virtual void ABBGKMBNNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "97")]
		public virtual void ODPEKJOGPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "98")]
		public virtual void HOIGDOPEDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1C539C0", Offset = "0x1C52BC0", VA = "0x181C539C0")]
		protected void IKOIOMGMNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3B22890", Offset = "0x3B21A90", VA = "0x183B22890")]
		protected void DMGJKLAHOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x20742B0", Offset = "0x20734B0", VA = "0x1820742B0")]
		private void OLJMEHBGLFJ([In] AOFKOPJBKJN JCCMNAMJFGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3B23DF0", Offset = "0x3B22FF0", VA = "0x183B23DF0", Slot = "99")]
		public virtual Task<GDHFNIGIAEI<MKMFEDEKPBJ<IMEMOCGMKGP>, HHLFGPMDGJA>> GEFELEPGNJH(string IIADHBOODBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3B24310", Offset = "0x3B23510", VA = "0x183B24310", Slot = "100")]
		public virtual Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> HGJBLCDOLLO(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "101")]
		public virtual void DNPGOBCDELG(MKMFEDEKPBJ<IMEMOCGMKGP> CDMGMIOPINH, MKMFEDEKPBJ<IMEMOCGMKGP> FELJKEHOAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3B254A0", Offset = "0x3B246A0", VA = "0x183B254A0", Slot = "102")]
		public virtual IEnumerable<APJENLFJGEH> OOEKLHJPBHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3B21D70", Offset = "0x3B20F70", VA = "0x183B21D70", Slot = "103")]
		public GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA> DGABJEFGJNN(string OEEJEIGDKKJ)
		{
			return default(GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3B23B60", Offset = "0x3B22D60", VA = "0x183B23B60", Slot = "46")]
		public bool FNOJGFJMLMH([Out] Guid ANBKOFHGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3B24AA0", Offset = "0x3B23CA0", VA = "0x183B24AA0")]
		public bool MMGLABACKAJ([In] Guid DOLMKPMNMEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "104")]
		public virtual void CFPPHLPBNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "105")]
		public virtual void JALKEIAMFMP(bool LJJMNBGLDEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "106")]
		public virtual EBHNIBGLJAJ HICJPHPBDDG([In] EEHFJDOHHPF MNGCEOJCPDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B22100", Offset = "0x3B21300", VA = "0x183B22100")]
		protected void DKJOGOKKNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B249B0", Offset = "0x3B23BB0", VA = "0x183B249B0", Slot = "111")]
		protected virtual bool LGCEEILNGGE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "112")]
		protected virtual bool PCBLCHHFIOE(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "119")]
		protected virtual void KLIPNEHPHMM(MDHDNFOPPIJ IMCCCEALFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		protected static void PGEMGGHKNJP(MDHDNFOPPIJ IMCCCEALFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B229A0", Offset = "0x3B21BA0", VA = "0x183B229A0")]
		protected void DPJDKOIMIHF(MDHDNFOPPIJ GIBHEBAOFBD, Func<string> HHJLCGHJKCE, Action<string> FPNKOGOLAKL, NADPDEHEMHC NEAMBEFDODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B21DF0", Offset = "0x3B20FF0", VA = "0x183B21DF0")]
		protected void DHDLGHHNBIG(MDHDNFOPPIJ GIBHEBAOFBD, Func<string> HHJLCGHJKCE, Action<string> FPNKOGOLAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B244A0", Offset = "0x3B236A0", VA = "0x183B244A0", Slot = "120")]
		protected virtual void HKLJAMEMMCO(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B24720", Offset = "0x3B23920", VA = "0x183B24720", Slot = "79")]
		public void JBNEBCNELAN(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B25530", Offset = "0x3B24730", VA = "0x183B25530", Slot = "80")]
		public LJEFFADCIED PIJFELCCCFH()
		{
			return default(LJEFFADCIED);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "123")]
		public virtual bool AGNKBNOKOJK(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1318EF0", Offset = "0x13180F0", VA = "0x181318EF0")]
		private void FEAFPBPCBDP([In] CPFICFJNHPL CAOOPLKANIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B21320", Offset = "0x3B20520", VA = "0x183B21320")]
		private void CAMJBBBNJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B222C0", Offset = "0x3B214C0", VA = "0x183B222C0")]
		private void DKKJKKJIEHJ(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, NPGHGBANIDL KKDLGEGHAKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DDF0", Offset = "0x1D6CFF0", VA = "0x181D6DDF0")]
		private void AJFAPHJGFMA(MKMFEDEKPBJ<IMEMOCGMKGP> IFAFPBGLEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B24D70", Offset = "0x3B23F70", VA = "0x183B24D70")]
		private void MNDHDAAJIFH(MKMFEDEKPBJ<IMEMOCGMKGP> IFAFPBGLEJO, NPGHGBANIDL PBCGNPMCKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B23F70", Offset = "0x3B23170", VA = "0x183B23F70")]
		private void HEACFHGABAC(MKMFEDEKPBJ<IMEMOCGMKGP> CDMGMIOPINH, MKMFEDEKPBJ<IMEMOCGMKGP> FELJKEHOAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E530", Offset = "0x1D6D730", VA = "0x181D6E530")]
		private void LOMLBOKAIGH(MKMFEDEKPBJ<IMEMOCGMKGP> CDMGMIOPINH, MKMFEDEKPBJ<IMEMOCGMKGP> FELJKEHOAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xC475A0", Offset = "0xC467A0", VA = "0x180C475A0")]
		private void CHKDLPDBEJM(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B25090", Offset = "0x3B24290", VA = "0x183B25090")]
		private void OHKIBJLFFAG(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, NPGHGBANIDL KKDLGEGHAKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B25720", Offset = "0x3B24920", VA = "0x183B25720")]
		private void PMBEJLAPELD(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, NPGHGBANIDL PBCGNPMCKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3B25600", Offset = "0x3B24800", VA = "0x183B25600", Slot = "124")]
		[AsyncStateMachine(typeof(ILMMGEDFODO<>.BFJACHNBCIJ))]
		public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> PLPCAEOCPAL(string OEEJEIGDKKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B21080", Offset = "0x3B20280", VA = "0x183B21080", Slot = "53")]
		private void BKOMFBPOCJN(object DFELGDMPKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B21010", Offset = "0x3B20210", VA = "0x183B21010", Slot = "54")]
		private void ADJDBFAEPBA(object DFELGDMPKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B247A0", Offset = "0x3B239A0", VA = "0x183B247A0", Slot = "28")]
		private bool KBIGAGHBJFM([In] CPFICFJNHPL HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B24770", Offset = "0x3B23970", VA = "0x183B24770", Slot = "30")]
		private bool JKDCBMEFDJM([In] AOFKOPJBKJN HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B23A20", Offset = "0x3B22C20", VA = "0x183B23A20", Slot = "47")]
		private bool ENINDAKIAAB([In] Guid DOLMKPMNMEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B24D40", Offset = "0x3B23F40", VA = "0x183B24D40")]
		[CompilerGenerated]
		private string MMKDEKGPHBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B24690", Offset = "0x3B23890", VA = "0x183B24690")]
		[CompilerGenerated]
		private void JAHPNMLNFFH(string IIADHBOODBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class HPKFPIOBBMP : DBAFFDAHBKN<FOOHPNHMLDM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xC46470", Offset = "0xC45670", VA = "0x180C46470", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E97AE0", Offset = "0x1E96CE0", VA = "0x181E97AE0")]
		public HPKFPIOBBMP(PKEMJIPKCPK HPFIGCNHCOB, FOOHPNHMLDM BKOKOKIHONK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class OIPFDBNKIKE : BHALHKPNELH<MPDHHDKBCLO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8FD0", Offset = "0x1EA81D0", VA = "0x181EA8FD0")]
		public OIPFDBNKIKE(PKEMJIPKCPK HPFIGCNHCOB, MPDHHDKBCLO BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8F90", Offset = "0x1EA8190", VA = "0x181EA8F90", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public abstract class DPANGKDHNJC<T> : ILMMGEDFODO<T> where T : notnull, LAKGEILLMGP
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class IAPEPKMJOCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public IReadOnlyList<KeyValuePair<string, CMCAOCKOAAO>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public DPANGKDHNJC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public EEHKFGNGBPB clipType;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public IAPEPKMJOCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			internal IReadOnlyList<KeyValuePair<string, CMCAOCKOAAO>> PKNDNPAGFKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFE70", Offset = "0x3AFF070", VA = "0x183AFFE70")]
			internal int GBMKOLPFFMO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFFC0", Offset = "0x3AFF1C0", VA = "0x183AFFFC0")]
			internal void GKLJLJJFMKK(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x3B00520", Offset = "0x3AFF720", VA = "0x183B00520")]
			internal void NEMIABMHAIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFD30", Offset = "0x3AFEF30", VA = "0x183AFFD30")]
			internal void FHHKCNJPCEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFCB0", Offset = "0x3AFEEB0", VA = "0x183AFFCB0")]
			internal bool BFOLPNJGFMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x3B004D0", Offset = "0x3AFF6D0", VA = "0x183B004D0")]
			internal void MFHLPKDHECF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFCB0", Offset = "0x3AFEEB0", VA = "0x183AFFCB0")]
			internal bool IANMAAIGEHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x3B001D0", Offset = "0x3AFF3D0", VA = "0x183B001D0")]
			internal float JDGIOCFJIJN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x3B00270", Offset = "0x3AFF470", VA = "0x183B00270")]
			internal void KPENPCHIEAC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x3B00480", Offset = "0x3AFF680", VA = "0x183B00480")]
			internal float MCPHDGMMLAG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x3B00320", Offset = "0x3AFF520", VA = "0x183B00320")]
			internal void LFIEFDFKKNB(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x3B00220", Offset = "0x3AFF420", VA = "0x183B00220")]
			internal float JHKJDBNJJIF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x3B003D0", Offset = "0x3AFF5D0", VA = "0x183B003D0")]
			internal void LMAJJJOJDEH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x832790", Offset = "0x831990", VA = "0x180832790", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public abstract EEHKFGNGBPB PKGDKEIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E69440", Offset = "0x3E68640", VA = "0x183E69440")]
		public DPANGKDHNJC(PKEMJIPKCPK HPFIGCNHCOB, T BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x534B960", Offset = "0x534AB60", VA = "0x18534B960", Slot = "119")]
		protected sealed override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class OJKBMFDBMAP : ILMMGEDFODO<BNCLNPMDECA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x856920", Offset = "0x855B20", VA = "0x180856920", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9030", Offset = "0x1EA8230", VA = "0x181EA9030")]
		public OJKBMFDBMAP(PKEMJIPKCPK HPFIGCNHCOB, BNCLNPMDECA BKOKOKIHONK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class DNOOLCODNMH : DPANGKDHNJC<IGCOPELOEEH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override EEHKFGNGBPB PKGDKEIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "125")]
			get
			{
				return default(EEHKFGNGBPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1E94170", Offset = "0x1E93370", VA = "0x181E94170")]
		public DNOOLCODNMH(PKEMJIPKCPK HPFIGCNHCOB, IGCOPELOEEH FNFDOEGAMFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class APCHDNCINDN : BHALHKPNELH<GLPFOMDJNGN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1E90AE0", Offset = "0x1E8FCE0", VA = "0x181E90AE0")]
		public APCHDNCINDN(PKEMJIPKCPK HPFIGCNHCOB, GLPFOMDJNGN BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1E90AA0", Offset = "0x1E8FCA0", VA = "0x181E90AA0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class KDBFPFPFAAM : BHALHKPNELH<PKJDFAFKMII>
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A810", Offset = "0x1E99A10", VA = "0x181E9A810")]
		public KDBFPFPFAAM(PKEMJIPKCPK HPFIGCNHCOB, PKJDFAFKMII BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A7D0", Offset = "0x1E999D0", VA = "0x181E9A7D0", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class LLHOIMJJLMM : IODHEBJCFBL<NJNNCLMIKJE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class HMPDPPKECBK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000074")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000160")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000161")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000162")]
				public HMPDPPKECBK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000163")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000164")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000165")]
				private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x1EA9960", Offset = "0x1EA8B60", VA = "0x181EA9960", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public LLHOIMJJLMM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public HMPDPPKECBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x1E97A10", Offset = "0x1E96C10", VA = "0x181E97A10")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void BIEEFHELDMM(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1B50", Offset = "0x1EA0D50", VA = "0x181EA1B50")]
		public LLHOIMJJLMM(PKEMJIPKCPK HPFIGCNHCOB, NJNNCLMIKJE FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1870", Offset = "0x1EA0A70", VA = "0x181EA1870", Slot = "125")]
		protected override void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class AOKFDBBFCIF : DPANGKDHNJC<JFFLDEEFFGK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override EEHKFGNGBPB PKGDKEIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x832EE0", Offset = "0x8320E0", VA = "0x180832EE0", Slot = "125")]
			get
			{
				return default(EEHKFGNGBPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1E90A40", Offset = "0x1E8FC40", VA = "0x181E90A40")]
		public AOKFDBBFCIF(PKEMJIPKCPK HPFIGCNHCOB, JFFLDEEFFGK FNFDOEGAMFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class AOJCGAFPGGI : ILMMGEDFODO<IHKNILBGCMB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x857650", Offset = "0x856850", VA = "0x180857650", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E909D0", Offset = "0x1E8FBD0", VA = "0x181E909D0")]
		public AOJCGAFPGGI(PKEMJIPKCPK HPFIGCNHCOB, IHKNILBGCMB BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1E90990", Offset = "0x1E8FB90", VA = "0x181E90990", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class OGIPAGIGNHB : ILMMGEDFODO<BOPKOMKPMNF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public sealed override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public sealed override bool DIFNJINJGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected sealed override bool DODDAOPLCOK
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8F20", Offset = "0x1EA8120", VA = "0x181EA8F20")]
		public OGIPAGIGNHB(PKEMJIPKCPK HPFIGCNHCOB, BOPKOMKPMNF BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8B20", Offset = "0x1EA7D20", VA = "0x181EA8B20", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8A80", Offset = "0x1EA7C80", VA = "0x181EA8A80")]
		private int ADGENKLFPLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8AC0", Offset = "0x1EA7CC0", VA = "0x181EA8AC0")]
		private void BAPLKOKMNOG(int GAPFLOIFLPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class PMAAABAGNMD : LLCOAJJAKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1800", Offset = "0x1EA0A00", VA = "0x181EA1800")]
		public PMAAABAGNMD(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9920", Offset = "0x1EA8B20", VA = "0x181EA9920", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class EDJLHFFCEME : IODHEBJCFBL<FOKMGCFBLHN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1E941D0", Offset = "0x1E933D0", VA = "0x181E941D0")]
		public EDJLHFFCEME(PKEMJIPKCPK HPFIGCNHCOB, FOKMGCFBLHN BKOKOKIHONK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public abstract class IODHEBJCFBL<TVariableNode> : ILMMGEDFODO<TVariableNode> where TVariableNode : notnull, FOKMGCFBLHN
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LJNLHHOKPLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public IODHEBJCFBL<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public LJNLHHOKPLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E940", Offset = "0x3F5DB40", VA = "0x183F5E940")]
			internal bool PKNDNPAGFKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E790", Offset = "0x3F5D990", VA = "0x183F5E790")]
			internal void GBMKOLPFFMO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E840", Offset = "0x3F5DA40", VA = "0x183F5E840")]
			internal bool GKLJLJJFMKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E890", Offset = "0x3F5DA90", VA = "0x183F5E890")]
			internal void NEMIABMHAIA(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E6F0", Offset = "0x3F5D8F0", VA = "0x183F5E6F0")]
			internal bool FHHKCNJPCEE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class BHPIDFHNGGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public MPMGBKLANIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public IODHEBJCFBL<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public BHPIDFHNGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x4A5DB30", Offset = "0x4A5CD30", VA = "0x184A5DB30")]
			internal void BIEEFHELDMM(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9D9AC0", Offset = "0x9D8CC0", VA = "0x1809D9AC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NPDHIKFALGD CEJPEABLOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3B2B820", Offset = "0x3B2AA20", VA = "0x183B2B820", Slot = "93")]
			get
			{
				return default(NPDHIKFALGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B6D0", Offset = "0x3B2A8D0", VA = "0x183B2B6D0")]
		protected IODHEBJCFBL(PKEMJIPKCPK HPFIGCNHCOB, TVariableNode BKOKOKIHONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3B2ADF0", Offset = "0x3B29FF0", VA = "0x183B2ADF0", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B280", Offset = "0x3B2A480", VA = "0x183B2B280", Slot = "119")]
		protected override void KLIPNEHPHMM(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AF30", Offset = "0x3B2A130", VA = "0x183B2AF30", Slot = "125")]
		protected virtual void HLNOHLCHKJH(MDHDNFOPPIJ GIBHEBAOFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AD30", Offset = "0x3B29F30", VA = "0x183B2AD30", Slot = "104")]
		public override void CFPPHLPBNAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E72470", Offset = "0x1E71670", VA = "0x181E72470")]
	public static OFFHOBPALPP EPPBEPCPNMI(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public sealed class FKCJHGOPIFG : EPKOLHMAPGJ, AIAIMHDEBHE, EFJEMAMNNPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MKMFEDEKPBJ<GBMLPCLHAKJ> DIHDDJPDPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE515C0", Offset = "0xE507C0", VA = "0x180E515C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MKMFEDEKPBJ<GBMLPCLHAKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public MKMFEDEKPBJ<MPEIMPJLOJO> CLCOFLOMKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1129310", Offset = "0x1128510", VA = "0x181129310", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MKMFEDEKPBJ<MPEIMPJLOJO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1E96DA0", Offset = "0x1E95FA0", VA = "0x181E96DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private MKMFEDEKPBJ<IKLDOHGAIKE> GACEFHKFDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xB0B030", Offset = "0xB0A230", VA = "0x180B0B030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public override MKMFEDEKPBJ<CAJELJDMNKC> PIIAGBABOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1E96D60", Offset = "0x1E95F60", VA = "0x181E96D60", Slot = "20")]
		get
		{
			return default(MKMFEDEKPBJ<CAJELJDMNKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1E96DB0", Offset = "0x1E95FB0", VA = "0x181E96DB0")]
	private FKCJHGOPIFG(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK, CFGMHJEFNMJ NCGICAGICOJ, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<MPEIMPJLOJO> JCNECKHKKFI, MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH, bool NNBABOHPMKN, string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1E96A10", Offset = "0x1E95C10", VA = "0x181E96A10")]
	public static FKCJHGOPIFG EPPBEPCPNMI(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK, CFGMHJEFNMJ AFCBPHPDPNC, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH, MKMFEDEKPBJ<MPEIMPJLOJO> JCNECKHKKFI, bool NNBABOHPMKN, bool MPEKFMHACMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1E96DA0", Offset = "0x1E95FA0", VA = "0x181E96DA0")]
	internal void KBPDBPJBMIJ(MKMFEDEKPBJ<MPEIMPJLOJO> HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public abstract class EPKOLHMAPGJ : EFJEMAMNNPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct JGHOHLIAPPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private MJHDMGBJFLI? OFIGFMFPOHB;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1E986D0", Offset = "0x1E978D0", VA = "0x181E986D0")]
		public void BFDHFEEMFPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1E986E0", Offset = "0x1E978E0", VA = "0x181E986E0")]
		public MJHDMGBJFLI DLIJJIEBLPP(EPKOLHMAPGJ BKKCDHFNNBA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	protected readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected readonly CHJNEAPICHF MNJHKALCPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private JGHOHLIAPPA NBODOOGODIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly MFHDBBCEKPE MKAPODJNHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly List<PNLJBJIICOI> OLENANDDJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly List<FIEJFFPCJKH> HMOBFBIFIPG;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	[LCJOOIGDAHJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> ALKNOLAOKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1E954E0", Offset = "0x1E946E0", VA = "0x181E954E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DisplayKind LBNKELOHOED
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8620", Offset = "0x7D7820", VA = "0x1807D8620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public MKMFEDEKPBJ<OAAIMIGIBKP> MEBGPMMMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1E94DC0", Offset = "0x1E93FC0", VA = "0x181E94DC0", Slot = "6")]
		get
		{
			return default(MKMFEDEKPBJ<OAAIMIGIBKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BEGCOIKGLLD<OAAIMIGIBKP> DAOADGCAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1E94F40", Offset = "0x1E94140", VA = "0x181E94F40", Slot = "7")]
		get
		{
			return default(BEGCOIKGLLD<OAAIMIGIBKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public LPPNAJJCCPF EFKDMOBOMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1AF27E0", Offset = "0x1AF19E0", VA = "0x181AF27E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public BJINLGHAPDD IBJBCJEOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1E951F0", Offset = "0x1E943F0", VA = "0x181E951F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	protected MJHDMGBJFLI IDFHKJNMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1E951F0", Offset = "0x1E943F0", VA = "0x181E951F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public PortImage IGDELAACEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1E956F0", Offset = "0x1E948F0", VA = "0x181E956F0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAD0", Offset = "0x7CDCD0", VA = "0x1807CEAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public BEGCOIKGLLD<HLKKEFMLJPC> KCEOJDALNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1E950C0", Offset = "0x1E942C0", VA = "0x181E950C0", Slot = "9")]
		get
		{
			return default(BEGCOIKGLLD<HLKKEFMLJPC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MKMFEDEKPBJ<IMEMOCGMKGP> GLADKBPEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8F1D00", Offset = "0x8F0F00", VA = "0x1808F1D00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MKMFEDEKPBJ<IMEMOCGMKGP>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xDDA170", Offset = "0xDD9370", VA = "0x180DDA170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public abstract MKMFEDEKPBJ<CAJELJDMNKC> PIIAGBABOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1E95EF0", Offset = "0x1E950F0", VA = "0x181E95EF0")]
	protected EPKOLHMAPGJ(PKEMJIPKCPK HPFIGCNHCOB, CHJNEAPICHF BKOKOKIHONK, MFHDBBCEKPE IFCDCDHKHNE, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, bool NNBABOHPMKN, string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1E94DF0", Offset = "0x1E93FF0", VA = "0x181E94DF0", Slot = "21")]
	protected virtual void CNOOLEDIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1E94F70", Offset = "0x1E94170", VA = "0x181E94F70", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1E95290", Offset = "0x1E94490", VA = "0x181E95290", Slot = "14")]
	public void JPKIKKNJLDB(PNLJBJIICOI EBKJNJIBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1E95140", Offset = "0x1E94340", VA = "0x181E95140", Slot = "15")]
	public void HCMNAGDFCEN(FIEJFFPCJKH EBKJNJIBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1E95830", Offset = "0x1E94A30", VA = "0x181E95830", Slot = "16")]
	public void ONFICCKPHKL(MBFPMMLAFED EIDAIJGJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1E95690", Offset = "0x1E94890", VA = "0x181E95690", Slot = "23")]
	protected virtual void NLEKJLMNGGH(MBFPMMLAFED EIDAIJGJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A90", Offset = "0x1E93C90", VA = "0x181E94A90")]
	private void BDOKICEKKGD(bool AOLAKAPHPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1E94C10", Offset = "0x1E93E10", VA = "0x181E94C10")]
	private void CCGAOFPEPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1E95340", Offset = "0x1E94540", VA = "0x181E95340")]
	private void LEKNCMEJNKM([In] DFCMNCPPNNP FKDLNAIEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1E950E0", Offset = "0x1E942E0", VA = "0x181E950E0", Slot = "17")]
	public void FFOLAPMOBIK(PNLJBJIICOI EBKJNJIBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x1E95630", Offset = "0x1E94830", VA = "0x181E95630", Slot = "18")]
	public void NBCNIBMCEPG(FIEJFFPCJKH EBKJNJIBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAD0", Offset = "0x7CDCD0", VA = "0x1807CEAD0")]
	internal void EOENLFHFHMK(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A70", Offset = "0x1E93C70", VA = "0x181E94A70")]
	internal void ALABCDFMDNI(MEBGDOMIBIO LPEICIFHPLM, LPPNAJJCCPF HHJOOHJDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0xDDA170", Offset = "0xDD9370", VA = "0x180DDA170")]
	internal void POJEOHJCONM(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class KOINNPBGCKM : LLGHDCCGOFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class PJMAPHAOCIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PKEMJIPKCPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CHJNEAPICHF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public MKMFEDEKPBJ<IMEMOCGMKGP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public PJMAPHAOCIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9710", Offset = "0x1EA8910", VA = "0x181EA9710")]
		internal EEEKBKCMIFP GHCKNBIMBHO((int PortDescIndex, int PortIndex, LEPKIMBNGAG InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9680", Offset = "0x1EA8880", VA = "0x181EA9680")]
		internal FKCJHGOPIFG BFJMPEGOBCC(CFGMHJEFNMJ i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct ABLAMJICGJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F630", Offset = "0x1E8E830", VA = "0x181E8F630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FA90", Offset = "0x1E8EC90", VA = "0x181E8FA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct FFBMHPICGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public MKMFEDEKPBJ<FJNGGFBGNAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E96530", Offset = "0x1E95730", VA = "0x181E96530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E96880", Offset = "0x1E95A80", VA = "0x181E96880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JILOADCNLGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public MKMFEDEKPBJ<IKLDOHGAIKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E98780", Offset = "0x1E97980", VA = "0x181E98780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E98AD0", Offset = "0x1E97CD0", VA = "0x181E98AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct ACHPKDDAPOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public MKMFEDEKPBJ<FJNGGFBGNAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public MKMFEDEKPBJ<FJNGGFBGNAK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FB00", Offset = "0x1E8ED00", VA = "0x181E8FB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FE50", Offset = "0x1E8F050", VA = "0x181E8FE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct JDMCLOEFGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public MKMFEDEKPBJ<IKLDOHGAIKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public MKMFEDEKPBJ<IKLDOHGAIKE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E98270", Offset = "0x1E97470", VA = "0x181E98270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E985C0", Offset = "0x1E977C0", VA = "0x181E985C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FBMFLHAMOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E96050", Offset = "0x1E95250", VA = "0x181E96050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E964C0", Offset = "0x1E956C0", VA = "0x181E964C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JOOGGLINAOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A090", Offset = "0x1E99290", VA = "0x181E9A090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A3E0", Offset = "0x1E995E0", VA = "0x181E9A3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct CAABDGBDDAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public MKMFEDEKPBJ<FJNGGFBGNAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E91C10", Offset = "0x1E90E10", VA = "0x181E91C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E91F60", Offset = "0x1E91160", VA = "0x181E91F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct JCLLOGHJDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public MKMFEDEKPBJ<IKLDOHGAIKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E97EB0", Offset = "0x1E970B0", VA = "0x181E97EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E98200", Offset = "0x1E97400", VA = "0x181E98200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct EKAKHICJHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public EDIDNDCAFNF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public MKMFEDEKPBJ<FJNGGFBGNAK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E94330", Offset = "0x1E93530", VA = "0x181E94330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E946C0", Offset = "0x1E938C0", VA = "0x181E946C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct PBAPBMAKOFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public KOINNPBGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public EDIDNDCAFNF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public MKMFEDEKPBJ<IKLDOHGAIKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private CDJKJBJCCHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9280", Offset = "0x1EA8480", VA = "0x181EA9280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9610", Offset = "0x1EA8810", VA = "0x181EA9610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly bool FEOLFCDLMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly bool NNFECCAMIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private NOGOGJJGMED<PJFBEINPAMA, EEEKBKCMIFP> NKOOJPCLPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NOGOGJJGMED<PJFBEINPAMA, JOMBBDNGBPN> PPMNJCCDLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly CHJNEAPICHF MNJHKALCPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NOGOGJJGMED<MPEIMPJLOJO, FKCJHGOPIFG> ALLCLKENIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NOGOGJJGMED<MPEIMPJLOJO, AIAIMHDEBHE> BAIBGKPKGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private string? DHDOJPAHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly NPGHGBANIDL CFCBBLNJJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private MKMFEDEKPBJ<IMEMOCGMKGP> BPELLDJDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly bool CPOGLLJCKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[CompilerGenerated]
	private Action? JEJGMKFPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[CompilerGenerated]
	private Action? JKAICLPGHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[CompilerGenerated]
	private Action<MKMFEDEKPBJ<PJFBEINPAMA>>? IEMLMHCPLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[CompilerGenerated]
	private Action<MKMFEDEKPBJ<MPEIMPJLOJO>>? APBLFHILEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[CompilerGenerated]
	private LLGHDCCGOFI.NHEPPBJLNML? JCKNLPBDENK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DKIDGHJEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F400", Offset = "0x1E9E600", VA = "0x181E9F400", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool PHHHPCCFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F870", Offset = "0x1E9EA70", VA = "0x181E9F870", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool GJMHGBKKHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FD80", Offset = "0x1E9EF80", VA = "0x181E9FD80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public BEGCOIKGLLD<OAAIMIGIBKP> DAOADGCAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1E9D1A0", Offset = "0x1E9C3A0", VA = "0x181E9D1A0", Slot = "7")]
		get
		{
			return default(BEGCOIKGLLD<OAAIMIGIBKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool IBOPPILGJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1EA0700", Offset = "0x1E9F900", VA = "0x181EA0700", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NOGOGJJGMED<PJFBEINPAMA, JOMBBDNGBPN> OKHJLBMMLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "9")]
		get
		{
			return default(NOGOGJJGMED<PJFBEINPAMA, JOMBBDNGBPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FAE0", Offset = "0x1E9ECE0", VA = "0x181E9FAE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BEGCOIKGLLD<HLKKEFMLJPC> KCEOJDALNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1E9E8C0", Offset = "0x1E9DAC0", VA = "0x181E9E8C0", Slot = "11")]
		get
		{
			return default(BEGCOIKGLLD<HLKKEFMLJPC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public NOGOGJJGMED<MPEIMPJLOJO, AIAIMHDEBHE> INILIEAFGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70", Slot = "12")]
		get
		{
			return default(NOGOGJJGMED<MPEIMPJLOJO, AIAIMHDEBHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MKMFEDEKPBJ<IMEMOCGMKGP> GLADKBPEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xB0BBE0", Offset = "0xB0ADE0", VA = "0x180B0BBE0", Slot = "13")]
		get
		{
			return default(MKMFEDEKPBJ<IMEMOCGMKGP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action EBOEBBIFDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B5F0", Offset = "0x1E9A7F0", VA = "0x181E9B5F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1EA0780", Offset = "0x1E9F980", VA = "0x181EA0780", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action FGECFOFADGF
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F8B0", Offset = "0x1E9EAB0", VA = "0x181E9F8B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F690", Offset = "0x1E9E890", VA = "0x181E9F690", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MKMFEDEKPBJ<PJFBEINPAMA>, MKMFEDEKPBJ<PJFBEINPAMA>> CLLABNBCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FCC0", Offset = "0x1E9EEC0", VA = "0x181E9FCC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BFB0", Offset = "0x1E9B1B0", VA = "0x181E9BFB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MKMFEDEKPBJ<PJFBEINPAMA>, MKMFEDEKPBJ<PJFBEINPAMA>> LNLGECHLENP
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F4C0", Offset = "0x1E9E6C0", VA = "0x181E9F4C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F1C0", Offset = "0x1E9E3C0", VA = "0x181E9F1C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MKMFEDEKPBJ<MPEIMPJLOJO>, MKMFEDEKPBJ<MPEIMPJLOJO>> HBNEEPFJMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FA20", Offset = "0x1E9EC20", VA = "0x181E9FA20", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1E9D0E0", Offset = "0x1E9C2E0", VA = "0x181E9D0E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MKMFEDEKPBJ<MPEIMPJLOJO>, MKMFEDEKPBJ<MPEIMPJLOJO>> BGHGKFOJHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F280", Offset = "0x1E9E480", VA = "0x181E9F280", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FF00", Offset = "0x1E9F100", VA = "0x181E9FF00", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MKMFEDEKPBJ<PJFBEINPAMA>, JOMBBDNGBPN> IDKKLKPKHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F340", Offset = "0x1E9E540", VA = "0x181E9F340", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F010", Offset = "0x1E9E210", VA = "0x181E9F010", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MKMFEDEKPBJ<PJFBEINPAMA>> DONKFLKIMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1E9DCF0", Offset = "0x1E9CEF0", VA = "0x181E9DCF0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1EA0C60", Offset = "0x1E9FE60", VA = "0x181EA0C60", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MKMFEDEKPBJ<PJFBEINPAMA>, JOMBBDNGBPN> EHJGGOFCELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1EA0BA0", Offset = "0x1E9FDA0", VA = "0x181EA0BA0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FE40", Offset = "0x1E9F040", VA = "0x181E9FE40", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MKMFEDEKPBJ<MPEIMPJLOJO>, AIAIMHDEBHE> ICJGDDAMDJO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EF50", Offset = "0x1E9E150", VA = "0x181E9EF50", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA0640", Offset = "0x1E9F840", VA = "0x181EA0640", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MKMFEDEKPBJ<MPEIMPJLOJO>> HAPKFLEEPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EE90", Offset = "0x1E9E090", VA = "0x181E9EE90", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EDD0", Offset = "0x1E9DFD0", VA = "0x181E9EDD0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MKMFEDEKPBJ<MPEIMPJLOJO>, AIAIMHDEBHE> KKDHLNCCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FC00", Offset = "0x1E9EE00", VA = "0x181E9FC00", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F960", Offset = "0x1E9EB60", VA = "0x181E9F960", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1EA1350", Offset = "0x1EA0550", VA = "0x181EA1350")]
	private KOINNPBGCKM(bool NNBABOHPMKN, PKEMJIPKCPK HPFIGCNHCOB, bool GAGPGIBADKF, NOGOGJJGMED<PJFBEINPAMA, EEEKBKCMIFP> KHLDLPOONGF, NOGOGJJGMED<PJFBEINPAMA, JOMBBDNGBPN> IHDBLMBFAAE, CHJNEAPICHF BKOKOKIHONK, NOGOGJJGMED<MPEIMPJLOJO, FKCJHGOPIFG> KACBJJFDECN, NOGOGJJGMED<MPEIMPJLOJO, AIAIMHDEBHE> DINJNEHJOIA, string? DECJMCCKFLM, NPGHGBANIDL KKDLGEGHAKO, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, bool MPEKFMHACMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1E9E220", Offset = "0x1E9D420", VA = "0x181E9E220")]
	public static KOINNPBGCKM EPPBEPCPNMI(bool NNBABOHPMKN, PKEMJIPKCPK HPFIGCNHCOB, bool GAGPGIBADKF, CHJNEAPICHF BKOKOKIHONK, NPGHGBANIDL KKDLGEGHAKO, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, bool MPEKFMHACMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C800", Offset = "0x1E9BA00", VA = "0x181E9C800")]
	private void CNOOLEDIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1E9D1F0", Offset = "0x1E9C3F0", VA = "0x181E9D1F0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1E9B4A0", Offset = "0x1E9A6A0", VA = "0x181E9B4A0", Slot = "38")]
	[AsyncStateMachine(typeof(ABLAMJICGJA))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> AFJADEBEAON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C5B0", Offset = "0x1E9B7B0", VA = "0x181E9C5B0")]
	private (EHBOOLOCFOM, int)? CKGNPJJALBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FB10", Offset = "0x1E9ED10", VA = "0x181E9FB10")]
	private void LLCDGOOENKF(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1334820", Offset = "0x1333A20", VA = "0x181334820")]
	private void BJJFBPABFLN(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1E9EA30", Offset = "0x1E9DC30", VA = "0x181E9EA30")]
	private void FLKBKHNMNKC(int BGNNCBDIMBJ, int CNADNOMJOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0D20", Offset = "0x1E9FF20", VA = "0x181EA0D20")]
	private void PJLDACDODKF(int BGNNCBDIMBJ, int CNADNOMJOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C070", Offset = "0x1E9B270", VA = "0x181E9C070")]
	private void CANLONPGLGM(int CGPKLOBDLFG, MKMFEDEKPBJ<PJFBEINPAMA> LBJEONCCHHN, LEPKIMBNGAG DBMDKHEIDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0F90", Offset = "0x1EA0190", VA = "0x181EA0F90")]
	private void PNPBBBNJFKP(int AOLAKAPHPCK, MKMFEDEKPBJ<PJFBEINPAMA> LBJEONCCHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C7E0", Offset = "0x1E9B9E0", VA = "0x181E9C7E0")]
	private void CMLCMNABFFF(int AOLAKAPHPCK, MKMFEDEKPBJ<PJFBEINPAMA> LBJEONCCHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1E9BB60", Offset = "0x1E9AD60", VA = "0x181E9BB60")]
	private void BLAHJIEDNAN(int CGPKLOBDLFG, MKMFEDEKPBJ<PJFBEINPAMA> LBJEONCCHHN, LEPKIMBNGAG DBMDKHEIDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9E8E0", Offset = "0x1E9DAE0", VA = "0x181E9E8E0")]
	private void FEFKJLNCGGJ(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xA136A0", Offset = "0xA128A0", VA = "0x180A136A0")]
	private void GAAMIGNDKDL(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0EA0", Offset = "0x1EA00A0", VA = "0x181EA0EA0")]
	private void PLFGAEAEPAB(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1334820", Offset = "0x1333A20", VA = "0x181334820")]
	private void HCNPOMNMLJL(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1E9B690", Offset = "0x1E9A890", VA = "0x181E9B690")]
	private void ANLJKEAOLDG(int BGNNCBDIMBJ, int CNADNOMJOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1E9B590", Offset = "0x1E9A790", VA = "0x181E9B590")]
	private void AHKNFAJMOCN(int BGNNCBDIMBJ, int CNADNOMJOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x1EA00E0", Offset = "0x1E9F2E0", VA = "0x181EA00E0")]
	private void NPMJNDLJPGD(int CGPKLOBDLFG, MKMFEDEKPBJ<MPEIMPJLOJO> LBJEONCCHHN, CFGMHJEFNMJ DBMDKHEIDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x1E9D1D0", Offset = "0x1E9C3D0", VA = "0x181E9D1D0")]
	private void DOHDLACNAHG(int AOLAKAPHPCK, MKMFEDEKPBJ<MPEIMPJLOJO> LBJEONCCHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0620", Offset = "0x1E9F820", VA = "0x181EA0620")]
	private void OBBCKFKFBPP(int AOLAKAPHPCK, MKMFEDEKPBJ<MPEIMPJLOJO> LBJEONCCHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x1E9DDB0", Offset = "0x1E9CFB0", VA = "0x181E9DDB0")]
	private void EMPMMLGAAFM(int CGPKLOBDLFG, MKMFEDEKPBJ<MPEIMPJLOJO> LBJEONCCHHN, CFGMHJEFNMJ DBMDKHEIDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0A50", Offset = "0x1E9FC50", VA = "0x181EA0A50")]
	private void OOECMFGCEGC(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xA136A0", Offset = "0xA128A0", VA = "0x180A136A0")]
	private void EFDHNOPHEDL(int CGPKLOBDLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0940", Offset = "0x1E9FB40", VA = "0x181EA0940", Slot = "39")]
	[AsyncStateMachine(typeof(FFBMHPICGHH))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> ONIKPKKFLGK(MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1E9F580", Offset = "0x1E9E780", VA = "0x181E9F580", Slot = "40")]
	[AsyncStateMachine(typeof(JILOADCNLGJ))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> INHELMOCFPO(MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0820", Offset = "0x1E9FA20", VA = "0x181EA0820", Slot = "41")]
	[AsyncStateMachine(typeof(ACHPKDDAPOA))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> OJLBIMCBABG(MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF, MKMFEDEKPBJ<FJNGGFBGNAK> INMFPKPAPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FFC0", Offset = "0x1E9F1C0", VA = "0x181E9FFC0", Slot = "42")]
	[AsyncStateMachine(typeof(JDMCLOEFGCM))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> NOBBAPHHBNE(MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH, MKMFEDEKPBJ<IKLDOHGAIKE> INMFPKPAPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9F0D0", Offset = "0x1E9E2D0", VA = "0x181E9F0D0", Slot = "43")]
	[AsyncStateMachine(typeof(FBMFLHAMOCB))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> GOGOMPOMAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0D80", Offset = "0x1E9FF80", VA = "0x181EA0D80", Slot = "44")]
	[AsyncStateMachine(typeof(JOOGGLINAOG))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> PJNMLKLAJPN(string OEEJEIGDKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E9BA30", Offset = "0x1E9AC30", VA = "0x181E9BA30", Slot = "45")]
	[AsyncStateMachine(typeof(CAABDGBDDAP))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> BHOHFIPDMDJ(MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF, string IIADHBOODBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1E9CFB0", Offset = "0x1E9C1B0", VA = "0x181E9CFB0", Slot = "46")]
	[AsyncStateMachine(typeof(JCLLOGHJDPE))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> DFMLPHIBNKO(MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH, string IIADHBOODBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1E9F740", Offset = "0x1E9E940", VA = "0x181E9F740", Slot = "47")]
	[AsyncStateMachine(typeof(EKAKHICJHLE))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> JJPKOEAJOIA(MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF, EDIDNDCAFNF HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1E9E790", Offset = "0x1E9D990", VA = "0x181E9E790", Slot = "48")]
	[AsyncStateMachine(typeof(PBAPBMAKOFK))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> FALJNDDOADI(MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH, EDIDNDCAFNF HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0FB0", Offset = "0x1EA01B0", VA = "0x181EA0FB0")]
	internal void POJEOHJCONM(MKMFEDEKPBJ<IMEMOCGMKGP> HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public sealed class PKLKKIHOCMG : ILFPMINBIAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public interface CNAJEMDMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x17000098")]
		MEBGDOMIBIO DMPMCLDNGJK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MLCOGDIIGCK> MPDBHCAPIKP(CancellationToken GILHKFNDIJP);

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KCJGDFFBJOD> HOGOEBKCDLG(CancellationToken GILHKFNDIJP);

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<IHNKBOKNFJO> IIIFOGGOPIN(CancellationToken GILHKFNDIJP);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct BHOGMKDAJHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<PKLKKIHOCMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public PKEMJIPKCPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public MLCOGDIIGCK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public KCJGDFFBJOD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private CNAJEMDMNEL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private KCJGDFFBJOD <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<MLCOGDIIGCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<KCJGDFFBJOD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<IHNKBOKNFJO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<AFFDOFPHFOK> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E90EA0", Offset = "0x1E900A0", VA = "0x181E90EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E918A0", Offset = "0x1E90AA0", VA = "0x181E918A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly AFFDOFPHFOK BKLPGEAIGND;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public AFFDOFPHFOK IJJMGGPPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	private PKLKKIHOCMG(AFFDOFPHFOK NKDBKJEDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1EA97C0", Offset = "0x1EA89C0", VA = "0x181EA97C0")]
	[AsyncStateMachine(typeof(BHOGMKDAJHA))]
	public static Task<PKLKKIHOCMG> HHPFEBJGPNM(PKEMJIPKCPK HPFIGCNHCOB, MLCOGDIIGCK? LOOHIDPGHKP, KCJGDFFBJOD? EMCGDLKBKKO, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1EA97A0", Offset = "0x1EA89A0", VA = "0x181EA97A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public readonly struct KCHIDPBFKDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct CCNAEIAJDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public KCHIDPBFKDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public APJENLFJGEH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E91FD0", Offset = "0x1E911D0", VA = "0x181E91FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E921D0", Offset = "0x1E913D0", VA = "0x181E921D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct NJCLEEJNOGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<bool, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public PKDBENLCLBC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public MLCOGDIIGCK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public KCJGDFFBJOD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public KCHIDPBFKDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private APJENLFJGEH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8070", Offset = "0x1EA7270", VA = "0x181EA8070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8450", Offset = "0x1EA7650", VA = "0x181EA8450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct AOEIECLOEKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public KCHIDPBFKDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E906E0", Offset = "0x1E8F8E0", VA = "0x181E906E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1E90920", Offset = "0x1E8FB20", VA = "0x181E90920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly NEKJGJPAMKL KLFFNAHEMDP;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	public KCHIDPBFKDM(NEKJGJPAMKL KKKALCIMAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E9A5B0", Offset = "0x1E997B0", VA = "0x181E9A5B0")]
	[AsyncStateMachine(typeof(CCNAEIAJDKC))]
	private Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> FEIBHGHJJCN(APJENLFJGEH BGMBJALDBDD, bool ELOBKEMEHKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E9A450", Offset = "0x1E99650", VA = "0x181E9A450")]
	[AsyncStateMachine(typeof(NJCLEEJNOGG))]
	public Task<GDHFNIGIAEI<bool, HHLFGPMDGJA?>>? CENBEKCGDNB(int BJOPPFBCIEP, PKDBENLCLBC? DHDPONDIBPB, MLCOGDIIGCK? LHOBKLPONGG, KCJGDFFBJOD? EMCGDLKBKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E9A6E0", Offset = "0x1E998E0", VA = "0x181E9A6E0")]
	[AsyncStateMachine(typeof(AOEIECLOEKM))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> HJOADCBEFJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class JMHHMMDLMBA : PPJHNHKMMBG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly EKJJAPDHIED MDCDGNLJEOG;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EKJJAPDHIED LMCPPFDDIII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	private JMHHMMDLMBA(EKJJAPDHIED KFCBBDOOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E99EB0", Offset = "0x1E990B0", VA = "0x181E99EB0")]
	public static JMHHMMDLMBA IHPADLGFHBL(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E99E90", Offset = "0x1E99090", VA = "0x181E99E90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface DKKAMCCPBBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	PJCIGFCBIPG IGJMNCLODOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	MPCACCMNJGP ALPOJMLLPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	AIEMALEKDCC OEOLGDKNJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	DMCCNBALGBC GNKFIKCPGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	NIEAMKJENIB PPCINCPCHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface HJGCLKOGKPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DKKAMCCPBBL? CCFNCMHEGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool MJHKLCMMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DKKAMCCPBBL?>? HBCCDMKPBKG();

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EAMHCPDGMAC(PKEMJIPKCPK HPFIGCNHCOB, PKDBENLCLBC NLLONELOMGP, MLCOGDIIGCK? PJCHEOBHJNF, KCJGDFFBJOD? BIEKKKGNGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[FAMALPLAALP("IStaticCV2Instance")]
public interface ILFPMINBIAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	AFFDOFPHFOK IJJMGGPPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[FAMALPLAALP("IStaticEVInstance")]
public interface PPJHNHKMMBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	EKJJAPDHIED LMCPPFDDIII
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public sealed class EJNMPDOBKMO : ECBBJBGGPEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JLIGGJIFIMM? LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1E94230", Offset = "0x1E93430", VA = "0x181E94230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	internal EJNMPDOBKMO(PKEMJIPKCPK HPFIGCNHCOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public sealed class DMCCNBALGBC : JLIGGJIFIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly ILFPMINBIAD AJGEPOPLJAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public ACKPNPOBANL FEIBHGHJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E92340", Offset = "0x1E91540", VA = "0x181E92340", Slot = "4")]
		get
		{
			return default(ACKPNPOBANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DAKEDBOHEAE ADPGJPJGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E92410", Offset = "0x1E91610", VA = "0x181E92410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public BEGCOIKGLLD<OAAIMIGIBKP> MMPMGHMFCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E924C0", Offset = "0x1E916C0", VA = "0x181E924C0", Slot = "6")]
		get
		{
			return default(BEGCOIKGLLD<OAAIMIGIBKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public AFFDOFPHFOK IFIBBEEIBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E92470", Offset = "0x1E91670", VA = "0x181E92470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public DMCCNBALGBC(ILFPMINBIAD AIJCKEEFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E923A0", Offset = "0x1E915A0", VA = "0x181E923A0")]
	public bool FFAPKCABLHH([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E923A0", Offset = "0x1E915A0", VA = "0x181E923A0", Slot = "8")]
	private bool CNBNADJEGHB([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class OCCGFHJMJPB
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1EA84E0", Offset = "0x1EA76E0", VA = "0x181EA84E0")]
	public static DFAANEJFENB<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> DGFHBBNHECI([In] this DFAANEJFENB<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>> CEGKLNFIOFH)
	{
		return default(DFAANEJFENB<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK, DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class KEHLKOHCFEJ : KNCBCBKHJEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool MJHKLCMMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A870", Offset = "0x1E99A70", VA = "0x181E9A870", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	internal KEHLKOHCFEJ(PKEMJIPKCPK HPFIGCNHCOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal sealed class JFDHLDHEPDF : ECPDHGIBOIF
{
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E98630", Offset = "0x1E97830", VA = "0x181E98630", Slot = "4")]
	public HLFBMMKOEOP? BOJCFKHLFLE(string? GKECBMMNGCG, string? HAEEAEKJMEI, string? EMCNCFHPIIK, FPNOBENGAIP.OHIOGDBNFBO.PDKLCDLKDLK KDJHNEAIEPL, bool LHCOBLPBMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public JFDHLDHEPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class JMFGKGOPGDF : ENEPPOKAMDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct BIALPACBAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder<NDLIJJKABHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JMFGKGOPGDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<DKKAMCCPBBL?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1E91910", Offset = "0x1E90B10", VA = "0x181E91910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E91BA0", Offset = "0x1E90DA0", VA = "0x181E91BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private IReadOnlyList<BEGCOIKGLLD<ODBIIIHGKLL>>? AIMEOIOEOEM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NDLIJJKABHI? LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1E99460", Offset = "0x1E98660", VA = "0x181E99460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NIEAMKJENIB? LNMAGFOFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E993E0", Offset = "0x1E985E0", VA = "0x181E993E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool NHOHKMFOLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E99580", Offset = "0x1E98780", VA = "0x181E99580", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DGEEEEENAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E99520", Offset = "0x1E98720", VA = "0x181E99520", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	internal JMFGKGOPGDF(PKEMJIPKCPK HPFIGCNHCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E99A30", Offset = "0x1E98C30", VA = "0x181E99A30", Slot = "7")]
	[AsyncStateMachine(typeof(BIALPACBAHL))]
	public Task<NDLIJJKABHI> KPFKMMDJKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E99B20", Offset = "0x1E98D20", VA = "0x181E99B20")]
	internal Dictionary<BEGCOIKGLLD<OAAIMIGIBKP>, Guid> NICFHAFJHMP(IEnumerable<LGJHLMJIKKC> NPFCEBGIIPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E991E0", Offset = "0x1E983E0", VA = "0x181E991E0")]
	public GDHFNIGIAEI<IEKDACABFIM, NFEBAOOCHCK> BIDOIHPLJJK([In] IEKDACABFIM LFGIAEMLDDL, IEnumerable<LGJHLMJIKKC> AKINLPCJCBH, int EPCEOGMGMHM)
	{
		return default(GDHFNIGIAEI<IEKDACABFIM, NFEBAOOCHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E994E0", Offset = "0x1E986E0", VA = "0x181E994E0")]
	internal static LJEFFADCIED HOONMGPIINO(DCPNCMPNOHF GIIJDPJOHBH, CHJNEAPICHF BKOKOKIHONK)
	{
		return default(LJEFFADCIED);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E99830", Offset = "0x1E98A30", VA = "0x181E99830", Slot = "8")]
	private GDHFNIGIAEI<IEKDACABFIM, NFEBAOOCHCK> KOFFIDLDJNF([In] IEKDACABFIM LFGIAEMLDDL, IEnumerable<LGJHLMJIKKC> AKINLPCJCBH, int EPCEOGMGMHM)
	{
		return default(GDHFNIGIAEI<IEKDACABFIM, NFEBAOOCHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E995E0", Offset = "0x1E987E0", VA = "0x181E995E0")]
	[CompilerGenerated]
	internal static LJEFFADCIED KLCKAGIBKJG(DCPNCMPNOHF OHCMJDIKKOO, CHJNEAPICHF MCEPKDAHEEE)
	{
		return default(LJEFFADCIED);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public sealed class NIEAMKJENIB : NDLIJJKABHI
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class DMIGDJPNANJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class OCPAHFDNJKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public AFFDOFPHFOK state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public KIFLJLFOAIC spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public OCPAHFDNJKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1EA8990", Offset = "0x1EA7B90", VA = "0x181EA8990")]
			internal bool CDLECFACOMH(DDJCFECNACM n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class NMHBPJBFNPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public NMHBPJBFNPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1EA84C0", Offset = "0x1EA76C0", VA = "0x181EA84C0")]
			internal void MKCCCDEDNIO(DDJCFECNACM n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1E92520", Offset = "0x1E91720", VA = "0x181E92520")]
		public static GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK> AMLDLFJMPOP(NIEAMKJENIB CJKIBFNGPNM, [In] NDLIJJKABHI.GIMBEBKEOAM NEAMBEFDODM)
		{
			return default(GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1E92E50", Offset = "0x1E92050", VA = "0x181E92E50")]
		internal static GDHFNIGIAEI<(INFBLLINAFI, LNEMNPOAFLH), HHLFGPMDGJA> GKNHCMHAODF(NIEAMKJENIB CJKIBFNGPNM, LNEMNPOAFLH MOBJGPKKAGF, bool CCNCODLECON, [In] BEGCOIKGLLD<OAAIMIGIBKP> JGGMOOCEJMG, [In] int? BIAOJIGDLMM, [In] LJEFFADCIED? OGMIDIJKDHJ, [In] LJEFFADCIED? FANGJIPOCNL)
		{
			return default(GDHFNIGIAEI<(INFBLLINAFI, LNEMNPOAFLH), HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x1E93D40", Offset = "0x1E92F40", VA = "0x181E93D40")]
		private static void MLADHBBKBKP(bool CCNCODLECON, LGJHLMJIKKC IBNFDGDHACD, INFBLLINAFI ACAELCKGLND, [In] BEGCOIKGLLD<OAAIMIGIBKP> JGGMOOCEJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1E92A50", Offset = "0x1E91C50", VA = "0x181E92A50")]
		public static void EPFDIHJBIBM(HOALBFJDPGL FOGLHIEDJJL, [In] NDLIJJKABHI.ELEFCCDCMIF PEFGPOPFFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1E93C50", Offset = "0x1E92E50", VA = "0x181E93C50")]
		[CompilerGenerated]
		internal static bool HNOCBPHKPKB(AFFDOFPHFOK LGKFCHFOLJE, KIFLJLFOAIC MBLENMCFGIK, DDJCFECNACM LPEGLDLGAAI)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct AGKMIIKOHHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public NIEAMKJENIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public MKMFEDEKPBJ<OAAIMIGIBKP> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public MKMFEDEKPBJ<GBMLPCLHAKJ> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public MKMFEDEKPBJ<BEFIKDACCGE> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FFC0", Offset = "0x1E8F1C0", VA = "0x181E8FFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1E90610", Offset = "0x1E8F810", VA = "0x181E90610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct LKMOMBNGPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public NIEAMKJENIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public BEGCOIKGLLD<HLKKEFMLJPC> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public BEGCOIKGLLD<OAAIMIGIBKP> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public MKMFEDEKPBJ<IMEMOCGMKGP> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public MKMFEDEKPBJ<PJFBEINPAMA> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1450", Offset = "0x1EA0650", VA = "0x181EA1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1790", Offset = "0x1EA0990", VA = "0x181EA1790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct MJADKLMHEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public NIEAMKJENIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public BEGCOIKGLLD<HLKKEFMLJPC> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public BEGCOIKGLLD<OAAIMIGIBKP> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public MKMFEDEKPBJ<IMEMOCGMKGP> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public MKMFEDEKPBJ<MPEIMPJLOJO> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private TaskAwaiter<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1BB0", Offset = "0x1EA0DB0", VA = "0x181EA1BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1EF0", Offset = "0x1EA10F0", VA = "0x181EA1EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private readonly PKEMJIPKCPK PJAOKDDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private readonly ILFPMINBIAD AJGEPOPLJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private readonly PPJHNHKMMBG NEDCPJALFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private readonly HOCKFEMGHBJ GAJDMCJJMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private readonly JMFGKGOPGDF DCBPEHBLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private Dictionary<BEGCOIKGLLD<HLKKEFMLJPC>, OFFHOBPALPP> IJMHBOAPFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private Action<BEGCOIKGLLD<HLKKEFMLJPC>>? FHAKBDDPKJD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public HOCKFEMGHBJ GEBAAGFNEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BB00", Offset = "0x1E8AD00", VA = "0x181E8BB00", Slot = "4")]
		get
		{
			return default(HOCKFEMGHBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7B50", Offset = "0x1EA6D50", VA = "0x181EA7B50")]
	public NIEAMKJENIB(PKEMJIPKCPK HPFIGCNHCOB, ILFPMINBIAD AIJCKEEFELO, PPJHNHKMMBG KPNIBOPLGKP, JMFGKGOPGDF AEGFJCJEFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1EA78F0", Offset = "0x1EA6AF0", VA = "0x181EA78F0", Slot = "38")]
	public MKMFEDEKPBJ<AHKJBPDNHIP> OMFLJGMIFCF(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<BEFIKDACCGE> KKNMCFFINHC)
	{
		return default(MKMFEDEKPBJ<AHKJBPDNHIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4440", Offset = "0x1EA3640", VA = "0x181EA4440", Slot = "39")]
	public MKMFEDEKPBJ<KPBJFDNJIIP> FDECNLGFDHP(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> JCNECKHKKFI)
	{
		return default(MKMFEDEKPBJ<KPBJFDNJIIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4530", Offset = "0x1EA3730", VA = "0x181EA4530", Slot = "5")]
	public bool FHGHDCLGMHD(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> ENLDGMBNBEH, MKMFEDEKPBJ<BEFIKDACCGE> FFLOGODNOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6330", Offset = "0x1EA5530", VA = "0x181EA6330")]
	public bool KGNNFKHHPGC(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] NAHMOAHDAMH ADHFAJIAOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6050", Offset = "0x1EA5250", VA = "0x181EA6050", Slot = "7")]
	public bool JBMFHGGOLBD(JOMBBDNGBPN HCJHMPOPAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7670", Offset = "0x1EA6870", VA = "0x181EA7670", Slot = "8")]
	public bool NHKEDBLHEGI(AIAIMHDEBHE OAIJIFJOOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5720", Offset = "0x1EA4920", VA = "0x181EA5720")]
	public OFFHOBPALPP? IAGAIHIHENI([In] BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1EA76F0", Offset = "0x1EA68F0", VA = "0x181EA76F0")]
	public MKMFEDEKPBJ<HLKKEFMLJPC> OHFEPNJNDHF(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] BEGCOIKGLLD<HLKKEFMLJPC> AKELGBAIBDK)
	{
		return default(MKMFEDEKPBJ<HLKKEFMLJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4C20", Offset = "0x1EA3E20", VA = "0x181EA4C20", Slot = "18")]
	public MKMFEDEKPBJ<HLKKEFMLJPC> GFICBAILHFF(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<BEFIKDACCGE> KKNMCFFINHC)
	{
		return default(MKMFEDEKPBJ<HLKKEFMLJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3920", Offset = "0x1EA2B20", VA = "0x181EA3920", Slot = "19")]
	public MKMFEDEKPBJ<HLKKEFMLJPC> AHFAKMCBKHF(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> JCNECKHKKFI)
	{
		return default(MKMFEDEKPBJ<HLKKEFMLJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA61C0", Offset = "0x1EA53C0", VA = "0x181EA61C0")]
	private void JEAIMNDMIEE(BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5CD0", Offset = "0x1EA4ED0", VA = "0x181EA5CD0")]
	public IEnumerable<OFFHOBPALPP> IIFHNBMOPFK([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7B10", Offset = "0x1EA6D10", VA = "0x181EA7B10")]
	private OFFHOBPALPP? PHBEKMHPJND([In] BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3D90", Offset = "0x1EA2F90", VA = "0x181EA3D90")]
	private OFFHOBPALPP CBMBHCKBNBB([In] BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK, CHJNEAPICHF BKOKOKIHONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5DE0", Offset = "0x1EA4FE0", VA = "0x181EA5DE0")]
	public CHJNEAPICHF? IJOACDKOKGG([In] BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1EA66B0", Offset = "0x1EA58B0", VA = "0x181EA66B0")]
	public DHMCDHEHAEA? NNAMHMOIIKG([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x1EA66E0", Offset = "0x1EA58E0", VA = "0x181EA66E0", Slot = "14")]
	public IEnumerable<KAHFHLMFHHL> LDBGLHCAEHI(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1EA49A0", Offset = "0x1EA3BA0", VA = "0x181EA49A0", Slot = "15")]
	public IEnumerable<NAHMOAHDAMH> FLNGGPPPOFG(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> ENLDGMBNBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1EA39A0", Offset = "0x1EA2BA0", VA = "0x181EA39A0", Slot = "16")]
	public IEnumerable<NAHMOAHDAMH> AJENICHFOBE(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<BEFIKDACCGE> FFLOGODNOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3E70", Offset = "0x1EA3070", VA = "0x181EA3E70")]
	public MKMFEDEKPBJ<OAAIMIGIBKP> DCLOGJINDEO([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(MKMFEDEKPBJ<OAAIMIGIBKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3FF0", Offset = "0x1EA31F0", VA = "0x181EA3FF0")]
	public MKMFEDEKPBJ<OAAIMIGIBKP>? EGKMPGJLDCC([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3CF0", Offset = "0x1EA2EF0", VA = "0x181EA3CF0")]
	private KIFLJLFOAIC? BAPGIGDCJBE([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1EA66B0", Offset = "0x1EA58B0", VA = "0x181EA66B0")]
	private DHMCDHEHAEA? KHGBGMEILNJ([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3840", Offset = "0x1EA2A40", VA = "0x181EA3840", Slot = "23")]
	public BEGCOIKGLLD<OAAIMIGIBKP> AEFJFADJMLO(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(BEGCOIKGLLD<OAAIMIGIBKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3F60", Offset = "0x1EA3160", VA = "0x181EA3F60")]
	public MKMFEDEKPBJ<BEFIKDACCGE> ECHKJPODCGJ(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<HLKKEFMLJPC> PNCKNAFMFGK, int EOPHJBOKNJH)
	{
		return default(MKMFEDEKPBJ<BEFIKDACCGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA70F0", Offset = "0x1EA62F0", VA = "0x181EA70F0")]
	public MKMFEDEKPBJ<GBMLPCLHAKJ> MGEOCGFIGHF(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<HLKKEFMLJPC> PNCKNAFMFGK, int KCDEBEMMIOG)
	{
		return default(MKMFEDEKPBJ<GBMLPCLHAKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4070", Offset = "0x1EA3270", VA = "0x181EA4070", Slot = "20")]
	public IEnumerable<EDIDNDCAFNF> EJAOHJHLBHL(EBGNMLFLMID DNKCEPPNIDN, bool AAMBDIEBHCJ, bool EEKCNEKDJDH, bool LGOCMNKLFJN, bool BCGIPMJLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4D20", Offset = "0x1EA3F20", VA = "0x181EA4D20", Slot = "21")]
	public EDIDNDCAFNF HDFDGDJJBBC(EBGNMLFLMID DNKCEPPNIDN, EFJEMAMNNPC MFJANPNMIFI, bool AAMBDIEBHCJ, bool EEKCNEKDJDH, bool LGOCMNKLFJN, bool BCGIPMJLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA42D0", Offset = "0x1EA34D0", VA = "0x181EA42D0")]
	public KAHFHLMFHHL MFNOCPPIKHA(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] NAHMOAHDAMH ADHFAJIAOJG)
	{
		return default(KAHFHLMFHHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6B40", Offset = "0x1EA5D40", VA = "0x181EA6B40", Slot = "24")]
	public NAHMOAHDAMH MCOFDCDEGON(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> ENLDGMBNBEH, MKMFEDEKPBJ<BEFIKDACCGE> FFLOGODNOIL)
	{
		return default(NAHMOAHDAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1EA44C0", Offset = "0x1EA36C0", VA = "0x181EA44C0", Slot = "25")]
	public bool FFAPKCABLHH(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7970", Offset = "0x1EA6B70", VA = "0x181EA7970", Slot = "26")]
	public bool OMPGLGHGJPD(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<BEFIKDACCGE> KKNMCFFINHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5E70", Offset = "0x1EA5070", VA = "0x181EA5E70", Slot = "27")]
	public bool IOGECJIHAOI(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> JCNECKHKKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5DB0", Offset = "0x1EA4FB0", VA = "0x181EA5DB0")]
	public GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK> PKLDGBLPJDC([In] NDLIJJKABHI.GIMBEBKEOAM NEAMBEFDODM)
	{
		return default(GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5010", Offset = "0x1EA4210", VA = "0x181EA5010", Slot = "29")]
	[AsyncStateMachine(typeof(AGKMIIKOHHB))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> HDKDHKOPFCH(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, MKMFEDEKPBJ<GBMLPCLHAKJ> ENLDGMBNBEH, MKMFEDEKPBJ<BEFIKDACCGE> FFLOGODNOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5330", Offset = "0x1EA4530", VA = "0x181EA5330", Slot = "30")]
	public GDHFNIGIAEI<BLOIKPJJAOB, NFEBAOOCHCK> HHOICIGIBFE(BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL, BLOIKPJJAOB CJOHADMJGPB, AOFKOPJBKJN NIFHGEELDFD)
	{
		return default(GDHFNIGIAEI<BLOIKPJJAOB, NFEBAOOCHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5EF0", Offset = "0x1EA50F0", VA = "0x181EA5EF0", Slot = "31")]
	[AsyncStateMachine(typeof(LKMOMBNGPCP))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> JBLDCOPMGEO(BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL, BEGCOIKGLLD<HLKKEFMLJPC> DJEBBMNJBBA, MKMFEDEKPBJ<IMEMOCGMKGP> ACPGADLHBAD, MKMFEDEKPBJ<PJFBEINPAMA> KKNMCFFINHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4170", Offset = "0x1EA3370", VA = "0x181EA4170", Slot = "32")]
	[AsyncStateMachine(typeof(MJADKLMHEHL))]
	public Task<GDHFNIGIAEI<PJGNGDCIDLA, HHLFGPMDGJA>> ELLMEPDCJHG(BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL, BEGCOIKGLLD<HLKKEFMLJPC> DOCKNGDCFDK, MKMFEDEKPBJ<IMEMOCGMKGP> BCFIGNKBKDF, MKMFEDEKPBJ<MPEIMPJLOJO> JCNECKHKKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5140", Offset = "0x1EA4340", VA = "0x181EA5140", Slot = "33")]
	public MEMPKFIHFAC HHBKAANLPPE(IEnumerable<LGJHLMJIKKC> AKINLPCJCBH)
	{
		return default(MEMPKFIHFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x1EA79F0", Offset = "0x1EA6BF0", VA = "0x181EA79F0", Slot = "34")]
	public MEMPKFIHFAC PCKMOBINGDL()
	{
		return default(MEMPKFIHFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7180", Offset = "0x1EA6380", VA = "0x181EA7180")]
	private PDLIJKHLAGE NDHNCJGIDLP(IFKBNFIBGIM CKJPEKGOHNI, MKMFEDEKPBJ<OAAIMIGIBKP> OEJDKLDJELC, IEnumerable<BEGCOIKGLLD<OAAIMIGIBKP>> KIBJAIIFELC, IEnumerable<BEGCOIKGLLD<HLKKEFMLJPC>> JGJAFCFNKDL)
	{
		return default(PDLIJKHLAGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7330", Offset = "0x1EA6530", VA = "0x181EA7330", Slot = "35")]
	public PDLIJKHLAGE NDHNCJGIDLP(IFKBNFIBGIM CKJPEKGOHNI, MKMFEDEKPBJ<OAAIMIGIBKP> OEJDKLDJELC, IEnumerable<BEGCOIKGLLD<HLKKEFMLJPC>> JGJAFCFNKDL, IEnumerable<LGJHLMJIKKC> AKINLPCJCBH)
	{
		return default(PDLIJKHLAGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6D70", Offset = "0x1EA5F70", VA = "0x181EA6D70")]
	private static IEnumerable<BEGCOIKGLLD<OAAIMIGIBKP>> MFMEIMCKHJP(IEnumerable<LGJHLMJIKKC> AKINLPCJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5820", Offset = "0x1EA4A20", VA = "0x181EA5820")]
	private IEnumerable<BEGCOIKGLLD<HLKKEFMLJPC>> IBADJAEHJOH(IEnumerable<LGJHLMJIKKC> AKINLPCJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7770", Offset = "0x1EA6970", VA = "0x181EA7770", Slot = "36")]
	public List<NPOANFFHKAN> NPABOMPPLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3C20", Offset = "0x1EA2E20", VA = "0x181EA3C20", Slot = "37")]
	public bool ANBOKGANCFC(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6AE0", Offset = "0x1EA5CE0", VA = "0x181EA6AE0")]
	internal void LKDFAJJCAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6A80", Offset = "0x1EA5C80", VA = "0x181EA6A80")]
	internal Task LJLHCIBMLBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3E60", Offset = "0x1EA3060", VA = "0x181EA3E60", Slot = "6")]
	private bool CKIIBCHHAHC(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] NAHMOAHDAMH ADHFAJIAOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1EA66B0", Offset = "0x1EA58B0", VA = "0x181EA66B0", Slot = "9")]
	private DHMCDHEHAEA OJOGNPCHLMM([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3E70", Offset = "0x1EA3070", VA = "0x181EA3E70", Slot = "10")]
	private MKMFEDEKPBJ<OAAIMIGIBKP> MDEGPACDPEK([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return default(MKMFEDEKPBJ<OAAIMIGIBKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3FF0", Offset = "0x1EA31F0", VA = "0x181EA3FF0", Slot = "11")]
	private MKMFEDEKPBJ<OAAIMIGIBKP>? GAAONJJGKLM([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1EA60D0", Offset = "0x1EA52D0", VA = "0x181EA60D0", Slot = "12")]
	private OFFHOBPALPP JDEJNEMONDC([In] BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1EA76F0", Offset = "0x1EA68F0", VA = "0x181EA76F0", Slot = "13")]
	private MKMFEDEKPBJ<HLKKEFMLJPC> NOPHECKBGPB(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] BEGCOIKGLLD<HLKKEFMLJPC> AKELGBAIBDK)
	{
		return default(MKMFEDEKPBJ<HLKKEFMLJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1EA6250", Offset = "0x1EA5450", VA = "0x181EA6250", Slot = "17")]
	private IEnumerable<OFFHOBPALPP> JHOBIGDCFNF([In] BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1EA42D0", Offset = "0x1EA34D0", VA = "0x181EA42D0", Slot = "22")]
	private KAHFHLMFHHL FBNEMHNEPEL(MKMFEDEKPBJ<OAAIMIGIBKP> DOLMKPMNMEL, [In] NAHMOAHDAMH ADHFAJIAOJG)
	{
		return default(KAHFHLMFHHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA5DB0", Offset = "0x1EA4FB0", VA = "0x181EA5DB0", Slot = "28")]
	private GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK> IJMPOJGHPMM([In] NDLIJJKABHI.GIMBEBKEOAM NEAMBEFDODM)
	{
		return default(GDHFNIGIAEI<NDLIJJKABHI.CEDAINMPIFN, NFEBAOOCHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7800", Offset = "0x1EA6A00", VA = "0x181EA7800")]
	[CompilerGenerated]
	private OFFHOBPALPP OBNKJJAPPEL(CHJNEAPICHF BJOOMLAOBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4CA0", Offset = "0x1EA3EA0", VA = "0x181EA4CA0")]
	[CompilerGenerated]
	private JLNHOIJPPHN GOJEACJBFJC(LPPNAJJCCPF BJOOMLAOBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA38B0", Offset = "0x1EA2AB0", VA = "0x181EA38B0")]
	[CompilerGenerated]
	private CHJNEAPICHF AHANCNMEABE(BEGCOIKGLLD<HLKKEFMLJPC> BJOOMLAOBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3EF0", Offset = "0x1EA30F0", VA = "0x181EA3EF0")]
	[CompilerGenerated]
	private KIFLJLFOAIC DNDKCGDOMDB(BEGCOIKGLLD<OAAIMIGIBKP> BJOOMLAOBEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class JLNHOIJPPHN : EDIDNDCAFNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct KFPBFONCPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<MKMFEDEKPBJ<FJNGGFBGNAK>, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JLNHOIJPPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public BEGCOIKGLLD<OAAIMIGIBKP> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public BEGCOIKGLLD<HLKKEFMLJPC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public MKMFEDEKPBJ<IMEMOCGMKGP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter<GDHFNIGIAEI<MKMFEDEKPBJ<FJNGGFBGNAK>, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A890", Offset = "0x1E99A90", VA = "0x181E9A890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1E9AB10", Offset = "0x1E99D10", VA = "0x181E9AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct JLJGBIEFAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<MKMFEDEKPBJ<IKLDOHGAIKE>, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public JLNHOIJPPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public BEGCOIKGLLD<OAAIMIGIBKP> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public BEGCOIKGLLD<HLKKEFMLJPC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public MKMFEDEKPBJ<IMEMOCGMKGP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<GDHFNIGIAEI<MKMFEDEKPBJ<IKLDOHGAIKE>, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1E98B40", Offset = "0x1E97D40", VA = "0x181E98B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1E98DC0", Offset = "0x1E97FC0", VA = "0x181E98DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly LPPNAJJCCPF LPKJMAOAHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly ILFPMINBIAD AJGEPOPLJAJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public TypeKey DIPEFPLLEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string GOHNJLKGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1E98FA0", Offset = "0x1E981A0", VA = "0x181E98FA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public LPPNAJJCCPF BGONKBGPEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1E99140", Offset = "0x1E98340", VA = "0x181E99140")]
	public JLNHOIJPPHN(LPPNAJJCCPF JOCPKAICGNJ, ILFPMINBIAD AIJCKEEFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1E98E30", Offset = "0x1E98030", VA = "0x181E98E30", Slot = "6")]
	[AsyncStateMachine(typeof(KFPBFONCPOI))]
	public Task<GDHFNIGIAEI<MKMFEDEKPBJ<FJNGGFBGNAK>, HHLFGPMDGJA>> CIKIJJMLHFE(BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL, BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, string IIADHBOODBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1E98FD0", Offset = "0x1E981D0", VA = "0x181E98FD0", Slot = "7")]
	[AsyncStateMachine(typeof(JLJGBIEFAGF))]
	public Task<GDHFNIGIAEI<MKMFEDEKPBJ<IKLDOHGAIKE>, HHLFGPMDGJA>> MCILAPFKHAL(BEGCOIKGLLD<OAAIMIGIBKP> DOLMKPMNMEL, BEGCOIKGLLD<HLKKEFMLJPC> PNCKNAFMFGK, MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH, string IIADHBOODBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public sealed class MJHDMGBJFLI : BJINLGHAPDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private readonly LPPNAJJCCPF KFFKCHCFKNG;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly HashSet<LPPNAJJCCPF> ALBDKHJOHIM;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly HashSet<LPPNAJJCCPF> IGIHJNDBNEK;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly HashSet<LPPNAJJCCPF> JCENDGCECMA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public TypeKey HCJOAPEDCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1EA34E0", Offset = "0x1EA26E0", VA = "0x181EA34E0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GGMELALGLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1EA34D0", Offset = "0x1EA26D0", VA = "0x181EA34D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool PFKEKLPHDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3530", Offset = "0x1EA2730", VA = "0x181EA3530", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool EGOPCNIMCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3450", Offset = "0x1EA2650", VA = "0x181EA3450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA20F0", Offset = "0x1EA12F0", VA = "0x181EA20F0")]
	public bool PMBAPCCDDIB(string HLCKBKFCMPI, [Out] GMBDIMFDADF DPBKLKGKDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public MJHDMGBJFLI(LPPNAJJCCPF FNFDOEGAMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA1F60", Offset = "0x1EA1160", VA = "0x181EA1F60")]
	internal static TypeKey LCHAHEPAPED(LPPNAJJCCPF HHJOOHJDNNM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1E98FA0", Offset = "0x1E981A0", VA = "0x181E98FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public readonly struct EMNGMDKLGCN : IEGIHPENLKG.EJEJBJKNIID<APJENLFJGEH, PJGNGDCIDLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A10", Offset = "0x1E93C10", VA = "0x181E94A10", Slot = "4")]
	public int MPFDMBNCGCG(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1E94990", Offset = "0x1E93B90", VA = "0x181E94990", Slot = "5")]
	public APJENLFJGEH CLAENALCEDC(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1E94960", Offset = "0x1E93B60", VA = "0x181E94960", Slot = "6")]
	public APJENLFJGEH BJFNOMFJDGB(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1E94920", Offset = "0x1E93B20", VA = "0x181E94920", Slot = "7")]
	public IReadOnlyList<APJENLFJGEH> AGMBPIPCBAO(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1E949C0", Offset = "0x1E93BC0", VA = "0x181E949C0", Slot = "8")]
	public APJENLFJGEH[] JMGIMHCMIBP(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD, int BAIDADKGBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1E949D0", Offset = "0x1E93BD0", VA = "0x181E949D0", Slot = "9")]
	public bool KIGNAMHHHNK(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1E949A0", Offset = "0x1E93BA0", VA = "0x181E949A0", Slot = "10")]
	public bool FAHBPKFOFAN(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A50", Offset = "0x1E93C50", VA = "0x181E94A50", Slot = "11")]
	public bool PAHEMHCACCF(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1E949F0", Offset = "0x1E93BF0", VA = "0x181E949F0", Slot = "12")]
	public bool LHGBDCNNIIP(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1E94940", Offset = "0x1E93B40", VA = "0x181E94940", Slot = "13")]
	public bool ANNELCNNBMK(PJGNGDCIDLA BMGPEHJNJNI, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A30", Offset = "0x1E93C30", VA = "0x181E94A30", Slot = "14")]
	public bool OMAFIPPDBKD(PJGNGDCIDLA AOLAKAPHPCK, APJENLFJGEH BGMBJALDBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public abstract class CIONHECDGLJ : BMCEJPFIGDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DOBPHAPKDEG.HJNPKHNFDDO DLBDJIKHENN
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1E92240", Offset = "0x1E91440", VA = "0x181E92240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract HGNFAEFDMLF.FLNOPKKFNHO DAMBFELDEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public abstract PKEMJIPKCPK.LAJPCLAGAMO EFGHICPHACP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract PKLKKIHOCMG.CNAJEMDMNEL MEKJPIGKIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DHCMLCCMCOC.DGJHPPHLBLI<JHEMGAEJBGF, APJENLFJGEH, PKEMJIPKCPK> GJHDHKFCDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E91490", VA = "0x181E92290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract CDJKJBJCCHG FJDJIKMGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract BIIGOGPKBLH EKNIIGDOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract DAICGOPJCMH ANDJEDHEJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract HLCKDCFNDIG PGMNKONADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract OABCGNHFAAC HFHMJKCFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected CIONHECDGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public sealed class IDMGNGIKAGL : DAKEDBOHEAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct HIILKGEKLHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public IDMGNGIKAGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public APJENLFJGEH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1E97790", Offset = "0x1E96990", VA = "0x181E97790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1E979A0", Offset = "0x1E96BA0", VA = "0x181E979A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct GMOGMPNGHMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<JMKCIGECGHH, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public IDMGNGIKAGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IReadOnlyList<APJENLFJGEH> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1E97040", Offset = "0x1E96240", VA = "0x181E97040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1E973C0", Offset = "0x1E965C0", VA = "0x181E973C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private readonly NEKJGJPAMKL KLFFNAHEMDP;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public IDMGNGIKAGL(NEKJGJPAMKL KKKALCIMAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1E97C50", Offset = "0x1E96E50", VA = "0x181E97C50")]
	[AsyncStateMachine(typeof(HIILKGEKLHP))]
	private Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> FEIBHGHJJCN(APJENLFJGEH BGMBJALDBDD, bool ELOBKEMEHKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1E97D80", Offset = "0x1E96F80", VA = "0x181E97D80", Slot = "4")]
	[AsyncStateMachine(typeof(GMOGMPNGHMK))]
	public Task<GDHFNIGIAEI<JMKCIGECGHH, HHLFGPMDGJA>> OHNAKPLKBHO(IReadOnlyList<APJENLFJGEH> JCAJMHEPJIC, bool ELOBKEMEHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct DHIKHAAHBIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal CNNGLNMMDDE<DPKMONKDAOE, APJENLFJGEH, EKEPIIHGOOC> KFFKCHCFKNG;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B6A0", Offset = "0x1E7A8A0", VA = "0x181E7B6A0")]
	private DHIKHAAHBIL([In] CNNGLNMMDDE<DPKMONKDAOE, APJENLFJGEH, EKEPIIHGOOC> PCFILHFLGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1E922E0", Offset = "0x1E914E0", VA = "0x181E922E0")]
	public static DHIKHAAHBIL EPPBEPCPNMI()
	{
		return default(DHIKHAAHBIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class CABOENMKECK
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static CNNGLNMMDDE<DPKMONKDAOE, APJENLFJGEH, EKEPIIHGOOC> MJNPGFNGJHD(this DHIKHAAHBIL CJKIBFNGPNM)
	{
		return default(CNNGLNMMDDE<DPKMONKDAOE, APJENLFJGEH, EKEPIIHGOOC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct EKEPIIHGOOC : EFBKGMCBEKM.CBHIDGLBLLL<DPKMONKDAOE, APJENLFJGEH>
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1E94730", Offset = "0x1E93930", VA = "0x181E94730", Slot = "5")]
	public APJENLFJGEH FDAPEHPOAIL(DPKMONKDAOE[] LHCIIGCBJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170")]
	public int CNHKCFODGIL([In] DPKMONKDAOE JDJGNJCIKCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170", Slot = "4")]
	private int LIEMFFIPOHO([In] DPKMONKDAOE MEDLCKOFPJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct OPCJFKPDBGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal HOOGKKFDBEN<PPEFPCLGECF, APJENLFJGEH, NAGNOFGJBOD> KFFKCHCFKNG;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B6A0", Offset = "0x1E7A8A0", VA = "0x181E7B6A0")]
	private OPCJFKPDBGP([In] HOOGKKFDBEN<PPEFPCLGECF, APJENLFJGEH, NAGNOFGJBOD> JAKMANPBLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9220", Offset = "0x1EA8420", VA = "0x181EA9220")]
	public static OPCJFKPDBGP EPPBEPCPNMI()
	{
		return default(OPCJFKPDBGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class NJLALNIJGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static HOOGKKFDBEN<PPEFPCLGECF, APJENLFJGEH, NAGNOFGJBOD> MJNPGFNGJHD(this OPCJFKPDBGP CJKIBFNGPNM)
	{
		return default(HOOGKKFDBEN<PPEFPCLGECF, APJENLFJGEH, NAGNOFGJBOD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct NAGNOFGJBOD : PFAGPHOPEIA.JAGNEBMNBKD<PPEFPCLGECF, APJENLFJGEH>
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170")]
	public int JHIAKLFHHDO([In] PPEFPCLGECF JDJGNJCIKCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3650", Offset = "0x1EA2850", VA = "0x181EA3650", Slot = "5")]
	public APJENLFJGEH NELMOEPNBEA(PPEFPCLGECF[] MANJEECENMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170", Slot = "4")]
	private int OPIOOEELEHH([In] PPEFPCLGECF JDJGNJCIKCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface CDJKJBJCCHG
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OODEBHCOHLO([In] GDHFNIGIAEI<PJGNGDCIDLA, NFEBAOOCHCK> JBENFHJBMMN);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class EDNNCFNIIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2821700", Offset = "0x2820900", VA = "0x182821700")]
	public static bool OODEBHCOHLO<TOk, TErr>(this CDJKJBJCCHG CJKIBFNGPNM, [In] GDHFNIGIAEI<TOk, TErr> JBENFHJBMMN) where TOk : notnull where TErr : notnull, NFEBAOOCHCK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public interface BIIGOGPKBLH
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	JOJGIFEHBIO PEAGJECDJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface DAICGOPJCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNMPOJDENIN KJIOFKKLEDH(int OFJABNGOMJN);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface DMCGOGOIJFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface KLMBKDBJJDE
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AMJFCNPLPMC? GNDMHLHOEHK(MKMFEDEKPBJ<IMEMOCGMKGP> FHIDDOHBBMH);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface PJPBFOGDOBM
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface AMJFCNPLPMC
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PJPBFOGDOBM? BLEICDOFHHB(MKMFEDEKPBJ<FJNGGFBGNAK> GLOLJLDOOBF);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMCGOGOIJFJ? NGNIOCMPBHG(MKMFEDEKPBJ<IKLDOHGAIKE> AILJCMLABBH);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface HLCKDCFNDIG
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IAAKKGCNIMG(string HLCKBKFCMPI, string EOIJJPCMNGA);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface OABCGNHFAAC
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLMBKDBJJDE? HMAAIECKGCH([In] BEGCOIKGLLD<ODBIIIHGKLL> KJPPOMKKODP);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class KGIMENFDNMB
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private struct IAADGMOOFFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int DMDPAHAMEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MLCOGDIIGCK? DMKLADONEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public MLCOGDIIGCK? KCPKOGPKDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public readonly List<APJENLFJGEH> CDCLICNCGJB;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E97C00", Offset = "0x1E96E00", VA = "0x181E97C00")]
		private IAADGMOOFFK(int PMNHOLIPOMJ, MLCOGDIIGCK? PAHOGKMADCA, MLCOGDIIGCK? CLAECJEIPHA, List<APJENLFJGEH> JCAJMHEPJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x1E97B40", Offset = "0x1E96D40", VA = "0x181E97B40")]
		public static IAADGMOOFFK EPPBEPCPNMI()
		{
			return default(IAADGMOOFFK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private readonly ONPEGMAPLAB<IAADGMOOFFK> ELOJLPCAPEN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public static KGIMENFDNMB LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9AE80", Offset = "0x1E9A080", VA = "0x181E9AE80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool OEHDNCPOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9A0", Offset = "0x8CBBA0", VA = "0x1808CC9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x906310", Offset = "0x905510", VA = "0x180906310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x1E9AED0", Offset = "0x1E9A0D0", VA = "0x181E9AED0")]
	public void KMFMGBEGJOK(AFFDOFPHFOK CLAECJEIPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E9AB80", Offset = "0x1E99D80", VA = "0x181E9AB80")]
	public void CAJCFKDOJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x1E9AF90", Offset = "0x1E9A190", VA = "0x181E9AF90")]
	private static string? OEFDAMMCKIO([In] IAADGMOOFFK BDMHABLICGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x1E9B3F0", Offset = "0x1E9A5F0", VA = "0x181E9B3F0")]
	public KGIMENFDNMB()
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
