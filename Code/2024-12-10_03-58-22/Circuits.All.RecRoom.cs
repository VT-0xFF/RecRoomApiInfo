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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x212BCA0", Offset = "0x212A8A0", VA = "0x18212BCA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class HECAJEGBBHJ : IDisposable, AFAKLELDCMO, OOENPOIGHAB, GJDMFOMOFLO, DFNEJIOGPIA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class APHKFKKLMIH : KOFHJPNAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int GFFIKIJLDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2110790", Offset = "0x210F390", VA = "0x182110790", Slot = "5")]
		public OFKDOAFPGOJ EICGHKMACED(NGHHPLGJAPK.LOIDEMIKBAE DDNPAGAAIOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void MELABIACKKN();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void CKKMNNDHMDF();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2110750", Offset = "0x210F350", VA = "0x182110750", Slot = "13")]
		public virtual void AOEJEOOBMIJ(HECAJEGBBHJ FPAIKMADOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21108E0", Offset = "0x210F4E0", VA = "0x1821108E0", Slot = "14")]
		public virtual void IIILCNHMPKA(HECAJEGBBHJ FPAIKMADOEB, AHAMAEENKGG FNGNLBJEBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected APHKFKKLMIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KOFHJPNAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int GFFIKIJLDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OFKDOAFPGOJ EICGHKMACED(NGHHPLGJAPK.LOIDEMIKBAE DDNPAGAAIOD);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MELABIACKKN();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CKKMNNDHMDF();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AOEJEOOBMIJ(HECAJEGBBHJ FPAIKMADOEB);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IIILCNHMPKA(HECAJEGBBHJ FPAIKMADOEB, AHAMAEENKGG FNGNLBJEBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct CDFHLCLLMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MGMMBFIBLIA<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> CKILFKBLILK;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x21204E0", Offset = "0x211F0E0", VA = "0x1821204E0")]
		internal CDFHLCLLMCP(MGMMBFIBLIA<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> GMBKDDMMMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LKPMJPGKFJA : GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly LKPMJPGKFJA AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		private LKPMJPGKFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x114D4F0", Offset = "0x114C0F0", VA = "0x18114D4F0", Slot = "4")]
		public LLLJCAGLDPN CEMGALJKNON(AHAMAEENKGG GMNCELIMKIF)
		{
			return default(LLLJCAGLDPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2128F80", Offset = "0x2127B80", VA = "0x182128F80", Slot = "5")]
		public void AOEJEOOBMIJ(HECAJEGBBHJ AHFIDHNOIFE, AHAMAEENKGG FNGNLBJEBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2129090", Offset = "0x2127C90", VA = "0x182129090", Slot = "6")]
		public void IIILCNHMPKA(HECAJEGBBHJ AHFIDHNOIFE, AHAMAEENKGG FNGNLBJEBKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MOFNONKABFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LBJCDMIBGOD<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> CKILFKBLILK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x212B2C0", Offset = "0x2129EC0", VA = "0x18212B2C0")]
		internal MOFNONKABFA(LBJCDMIBGOD<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x212B270", Offset = "0x2129E70", VA = "0x18212B270")]
		public static MOFNONKABFA LMDPPDEOAIA()
		{
			return default(MOFNONKABFA);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GIKFJLDMKHD : FDMFBILDOPO.IPJHMCAMGKG<AHAMAEENKGG, HECAJEGBBHJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct CBIJDHFPKLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HECAJEGBBHJ receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AHAMAEENKGG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GIKFJLDMKHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2120290", Offset = "0x211EE90", VA = "0x182120290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2120470", Offset = "0x211F070", VA = "0x182120470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC40", Offset = "0xA7B840", VA = "0x180A7CC40", Slot = "4")]
		public FANMFDLLPNO<LIPJNACBMBC> FIACPLFMFDP(HECAJEGBBHJ IMHHBHNOLMB)
		{
			return default(FANMFDLLPNO<LIPJNACBMBC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2124D80", Offset = "0x2123980", VA = "0x182124D80", Slot = "5")]
		[AsyncStateMachine(typeof(CBIJDHFPKLD))]
		public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> EFPAJGHFNCL(HECAJEGBBHJ IMHHBHNOLMB, AHAMAEENKGG FNGNLBJEBKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2124EB0", Offset = "0x2123AB0", VA = "0x182124EB0", Slot = "6")]
		public AHAMAEENKGG[] HOANELFGKKA(HECAJEGBBHJ IMHHBHNOLMB)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LIOJAIIIPJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HECAJEGBBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JNFCNCENMII rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KAKCODMKIFK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ALHAJLJNJLJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2128A40", Offset = "0x2127640", VA = "0x182128A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2128CC0", Offset = "0x21278C0", VA = "0x182128CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MPCOJKHJKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HECAJEGBBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x212B2D0", Offset = "0x2129ED0", VA = "0x18212B2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x212B560", Offset = "0x212A160", VA = "0x18212B560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LJLBNKFKEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public HECAJEGBBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2128D30", Offset = "0x2127930", VA = "0x182128D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2128F10", Offset = "0x2127B10", VA = "0x182128F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LDHFKNBPOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public HECAJEGBBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AHAMAEENKGG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21287E0", Offset = "0x21273E0", VA = "0x1821287E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21289D0", Offset = "0x21275D0", VA = "0x1821289D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PCAMBEBPMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public HECAJEGBBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x212BE10", Offset = "0x212AA10", VA = "0x18212BE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x212C5F0", Offset = "0x212B1F0", VA = "0x18212C5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FANMFDLLPNO<LIPJNACBMBC> OGHDKBBFMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CDFHLCLLMCP LHLNFKCBAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PFKCMDMJCBD CNBGMOMLJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly POJNKKPECCK ABPDKGDFBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19F8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LMOCKDHMJIC JGAJCHLELFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A00")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KCOMFDLMGDL.PEOIIBFGOOE KKHNBHAMJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KFLMHILEOMG KGNAHLFJHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly GLMMJPHCCHK PABHHILNKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ECCNHFNKLKE GCMEBECCNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly BMNJACENIHB JGGOPLBDFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PACBFPGPOBK ONIBHPBJFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AGGFPOLNHLI GDMLOFPMHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly PFKCMDMJCBD.MCFKOOBIGGB BJFHMJMMFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EJAFGPCKOPK ELNGPJMHHKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PFKCMDMJCBD FAKIAIKINKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21261A0", Offset = "0x2124DA0", VA = "0x1821261A0")]
		get
		{
			return default(PFKCMDMJCBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KOFHJPNAMOB APAHDOBADHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2125640", Offset = "0x2124240", VA = "0x182125640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OFKDOAFPGOJ AOAIFEKKGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2125D50", Offset = "0x2124950", VA = "0x182125D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2125CB0", Offset = "0x21248B0", VA = "0x182125CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HDAAHMCPHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2126190", Offset = "0x2124D90", VA = "0x182126190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2125D60", Offset = "0x2124960", VA = "0x182125D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JBHIOPIGLDJ PKGGLKFMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2126AA0", Offset = "0x21256A0", VA = "0x182126AA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NMBDHHEEIKM GINMLLCCLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2126AB0", Offset = "0x21256B0", VA = "0x182126AB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MIHMJLMACJO BNDCEDHJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2126AD0", Offset = "0x21256D0", VA = "0x182126AD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GDGGNFBNEEL IHLMIDHBCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2126AC0", Offset = "0x21256C0", VA = "0x182126AC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KCOMFDLMGDL? MMALLIMGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21262A0", Offset = "0x2124EA0", VA = "0x1821262A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BDEGOONFGOO? FLIHFGLLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21257F0", Offset = "0x21243F0", VA = "0x1821257F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21267A0", Offset = "0x21253A0", VA = "0x1821267A0")]
	private HECAJEGBBHJ(LMOCKDHMJIC PIAKONPJLMJ, FANMFDLLPNO<LIPJNACBMBC> EKDFELJLMMH, [In] CDFHLCLLMCP MOMLDCIHAEI, [In] PFKCMDMJCBD LHOGDPPEIGH, [In] POJNKKPECCK CCJFKLAGFBK, OFKDOAFPGOJ NKABENGFCHJ, [In] KCOMFDLMGDL.PEOIIBFGOOE HOANGFBBEDE, PFKCMDMJCBD.MCFKOOBIGGB HCBCDHCFDBM, EJAFGPCKOPK BFGLKKGCIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2126050", Offset = "0x2124C50", VA = "0x182126050")]
	public static HECAJEGBBHJ LMDPPDEOAIA(LMOCKDHMJIC DDNPAGAAIOD, [In] GDFIMLDPLNL CDPIDFLDHJB, GAEMDNAELFP IOIOIJCIHGF, [In] NODHJLCOKHK NAGCKIKEPNJ, GKIKKNDJDKD NDDJINGKLGO, FANMFDLLPNO<LIPJNACBMBC> EKDFELJLMMH, FANMFDLLPNO<ILGDLDEEBMD> MPNEIADENIL, DCHFDHOJOJI HGJKJDPBMMI, BLBALGKJDLA HIEIONPFICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2125D70", Offset = "0x2124970", VA = "0x182125D70")]
	public static HECAJEGBBHJ LMDPPDEOAIA(LMOCKDHMJIC PIAKONPJLMJ, [In] PFKCMDMJCBD LHOGDPPEIGH, [In] POJNKKPECCK CCJFKLAGFBK, FANMFDLLPNO<LIPJNACBMBC> EKDFELJLMMH, FANMFDLLPNO<ILGDLDEEBMD> MPNEIADENIL, DCHFDHOJOJI HGJKJDPBMMI, BLBALGKJDLA HIEIONPFICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2125450", Offset = "0x2124050", VA = "0x182125450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2125690", Offset = "0x2124290", VA = "0x182125690")]
	[AsyncStateMachine(typeof(LIOJAIIIPJH))]
	internal Task<OAMIPODNNBO<bool, BDMFJEIOIAD>> ENIPJOBOEGA(JNFCNCENMII PJJJPLDPJEK, KAKCODMKIFK GLFGAKGEEJK, ALHAJLJNJLJ DAMPDLBECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21266B0", Offset = "0x21252B0", VA = "0x1821266B0")]
	[AsyncStateMachine(typeof(MPCOJKHJKNB))]
	public Task<OAMIPODNNBO<bool, BDMFJEIOIAD>> PAFHMOEOEBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21261B0", Offset = "0x2124DB0", VA = "0x1821261B0")]
	[AsyncStateMachine(typeof(LJLBNKFKEAI))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> MKLPAOMDNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2126390", Offset = "0x2124F90", VA = "0x182126390")]
	internal void NJNINLGJBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2125CD0", Offset = "0x21248D0", VA = "0x182125CD0")]
	internal GENIMIBGNOF<AHAMAEENKGG> IOLBMBJONEC([In] CICJJMHGIGO PGONGCFDCIO)
	{
		return default(GENIMIBGNOF<AHAMAEENKGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2126320", Offset = "0x2124F20", VA = "0x182126320")]
	internal bool NFHPBAGDMIC([In] CICJJMHGIGO PGONGCFDCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21252B0", Offset = "0x2123EB0", VA = "0x1821252B0")]
	internal GENIMIBGNOF<AHAMAEENKGG> BFGBOMBMPMA([In] BDEFLKDAAPD GHPOJONPDHG)
	{
		return default(GENIMIBGNOF<AHAMAEENKGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21265A0", Offset = "0x21251A0", VA = "0x1821265A0")]
	[AsyncStateMachine(typeof(LDHFKNBPOND))]
	internal Task<OAMIPODNNBO<object, BDMFJEIOIAD>> NPPDLFNJJJK(AHAMAEENKGG FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2125920", Offset = "0x2124520", VA = "0x182125920")]
	private AHAMAEENKGG[] HOANELFGKKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2125330", Offset = "0x2123F30", VA = "0x182125330")]
	[AsyncStateMachine(typeof(PCAMBEBPMLP))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> DEFIPBMMDNK(Guid BDIBKOIFMCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NJKKGMDLFAL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F815A0", Offset = "0x2F801A0", VA = "0x182F815A0")]
	public static IJPDJHHKPHP<(TPrev?, HECAJEGBBHJ?), BDEGOONFGOO> EDCCIIEDAKE<TPrev>([In] this IJPDJHHKPHP<TPrev, HECAJEGBBHJ> GMNCELIMKIF)
	{
		return default(IJPDJHHKPHP<(TPrev, HECAJEGBBHJ), BDEGOONFGOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F81860", Offset = "0x2F80460", VA = "0x182F81860")]
	public static IJPDJHHKPHP<TPrev?, HECAJEGBBHJ?> LNDPIFLEEGA<TPrev>([In] this IJPDJHHKPHP<TPrev, HECAJEGBBHJ> GMNCELIMKIF)
	{
		return default(IJPDJHHKPHP<TPrev, HECAJEGBBHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JBFEOAJJOFJ<TData> : BGGNEHOKNAC, DFJMIDJHGOM, OILOBAEJEDE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DBMOGKNBCFK<LOCKFIIFIFD>? EAHHCHNIBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LDONEJPFOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData HCNDAPMGMCI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DBMOGKNBCFK<LOCKFIIFIFD>? EEKOHFDGOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2360840", Offset = "0x235F440", VA = "0x182360840", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41DF4B0", Offset = "0x41DE0B0", VA = "0x1841DF4B0")]
	internal JBFEOAJJOFJ([In] DBMOGKNBCFK<LOCKFIIFIFD>? DJHGKPPNJIK, FANMFDLLPNO<EJJLEGLDJOC>? CLHEKCFILNM, IOKind? LPOBFGBNBKK, string LFKIGNHCOID, [In] TData BFLLAIFBMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AADFDBCLHPE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x210FE20", Offset = "0x210EA20", VA = "0x18210FE20")]
	public static OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM> NGHANEKEJMD([In] this CELDFHICJLN<BDEDFGBDGOM> PEGANAAAIMB)
	{
		return default(OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34B2570", Offset = "0x34B1170", VA = "0x1834B2570")]
	public static OAMIPODNNBO<TOk, DFJMIDJHGOM> HGKLMPBOBOM<TOk>([In] this OAMIPODNNBO<TOk, DFJMIDJHGOM> GMNCELIMKIF, [In] DBMOGKNBCFK<LOCKFIIFIFD>? DJHGKPPNJIK, FANMFDLLPNO<EJJLEGLDJOC>? CLHEKCFILNM, IOKind? LPOBFGBNBKK, string LFKIGNHCOID) where TOk : notnull
	{
		return default(OAMIPODNNBO<TOk, DFJMIDJHGOM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LMOCKDHMJIC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FAOKCPMHHCC.NIJIBJDKIJI DHCOKJLGAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NGHHPLGJAPK.LOIDEMIKBAE KIMEDNEABCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HECAJEGBBHJ.KOFHJPNAMOB CLFBGNLEEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FPDLBCLPOFG.PCIKIJLMJFF IIFNNBNBGME
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ> HFEGHDHCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EJJBJAKHFCE CCMHPPLNNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FBCDAJNLMJL KJHKJIFMOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PHOPNODOKFL FJLMPIJHFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LEHCNNBDEIN JIKKOOCGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MLEENANEIBN AEHFNGFBNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NFFJNDLAIJA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x212B6A0", Offset = "0x212A2A0", VA = "0x18212B6A0")]
	public static AHAMAEENKGG DFDOMJKBCMG(this AHAMAEENKGG GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x212B5D0", Offset = "0x212A1D0", VA = "0x18212B5D0")]
	public static AHAMAEENKGG CNMKKGHABMP(this POAIOJONOFP GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct POAIOJONOFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LCOKADCKMLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HECAJEGBBHJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public POAIOJONOFP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21284B0", Offset = "0x21270B0", VA = "0x1821284B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2128770", Offset = "0x2127370", VA = "0x182128770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString PPPKGAOABBC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	private POAIOJONOFP(ByteString CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x212CF70", Offset = "0x212BB70", VA = "0x18212CF70")]
	public static AHAMAEENKGG CLPGKMOLMGP(ByteString CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x212D140", Offset = "0x212BD40", VA = "0x18212D140")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, POAIOJONOFP> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, POAIOJONOFP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x212D030", Offset = "0x212BC30", VA = "0x18212D030")]
	[AsyncStateMachine(typeof(LCOKADCKMLN))]
	public static Task<OAMIPODNNBO<object, BDMFJEIOIAD>> NPPDLFNJJJK(HECAJEGBBHJ AHFIDHNOIFE, POAIOJONOFP GMNCELIMKIF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EBDPKKIEEHK
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2122A60", Offset = "0x2121660", VA = "0x182122A60")]
	public static AHAMAEENKGG CLPGKMOLMGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2122B00", Offset = "0x2121700", VA = "0x182122B00")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, EBDPKKIEEHK> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, EBDPKKIEEHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21229E0", Offset = "0x21215E0", VA = "0x1821229E0")]
	public static OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA> BNBKCOCNFCG(HECAJEGBBHJ AHFIDHNOIFE, [In] EBDPKKIEEHK GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct EBBEDIOIIOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CLLKBAMEJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HECAJEGBBHJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public EBBEDIOIIOA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2120AA0", Offset = "0x211F6A0", VA = "0x182120AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2120E10", Offset = "0x211FA10", VA = "0x182120E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JNFCNCENMII? JBCMOLBIPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly KAKCODMKIFK? OCILKJMFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly ALHAJLJNJLJ? NPBINDHMPAE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x204A9D0", Offset = "0x20495D0", VA = "0x18204A9D0")]
	private EBBEDIOIIOA(JNFCNCENMII? PJJJPLDPJEK, KAKCODMKIFK? GLFGAKGEEJK, ALHAJLJNJLJ? DAMPDLBECHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2122690", Offset = "0x2121290", VA = "0x182122690")]
	public static AHAMAEENKGG? CLPGKMOLMGP(JNFCNCENMII? PJJJPLDPJEK, KAKCODMKIFK? GLFGAKGEEJK, ALHAJLJNJLJ? DAMPDLBECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21228D0", Offset = "0x21214D0", VA = "0x1821228D0")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, EBBEDIOIIOA> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, EBBEDIOIIOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2122790", Offset = "0x2121390", VA = "0x182122790")]
	[AsyncStateMachine(typeof(CLLKBAMEJBL))]
	public static Task<OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA>> NPPDLFNJJJK(HECAJEGBBHJ AHFIDHNOIFE, EBBEDIOIIOA GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FAKADOEAGHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct EMOJPBKOBOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FAKADOEAGHI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public HECAJEGBBHJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OAMIPODNNBO<object, OILOBAEJEDE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private OAMIPODNNBO<object, OILOBAEJEDE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OAMIPODNNBO<object, OILOBAEJEDE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2122DA0", Offset = "0x21219A0", VA = "0x182122DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2123210", Offset = "0x2121E10", VA = "0x182123210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<AHAMAEENKGG> MCPDLCGONAG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	private FAKADOEAGHI(IReadOnlyList<AHAMAEENKGG> FCICDOOOFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2123280", Offset = "0x2121E80", VA = "0x182123280")]
	public static AHAMAEENKGG CLPGKMOLMGP(IReadOnlyList<AHAMAEENKGG> FCICDOOOFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2123480", Offset = "0x2122080", VA = "0x182123480")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, FAKADOEAGHI> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, FAKADOEAGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2123340", Offset = "0x2121F40", VA = "0x182123340")]
	[AsyncStateMachine(typeof(EMOJPBKOBOA))]
	public static Task<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> NPPDLFNJJJK(HECAJEGBBHJ AHFIDHNOIFE, FAKADOEAGHI GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BDEFLKDAAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int DNBGNCFCKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int NAJFJJKNBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] HCNDAPMGMCI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8D20", Offset = "0x1DB7920", VA = "0x181DB8D20")]
	private BDEFLKDAAPD(int KNHHBEFLJAF, int MFJLAMOCOBC, byte[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2110A80", Offset = "0x210F680", VA = "0x182110A80")]
	public static AHAMAEENKGG CLPGKMOLMGP(int KNHHBEFLJAF, int MFJLAMOCOBC, ByteString BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2110B60", Offset = "0x210F760", VA = "0x182110B60")]
	public static AHAMAEENKGG[] IPDMPCBOKJM(AHAMAEENKGG FNGNLBJEBKM, int OAKNPKDIJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2110C90", Offset = "0x210F890", VA = "0x182110C90")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, BDEFLKDAAPD> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, BDEFLKDAAPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2110960", Offset = "0x210F560", VA = "0x182110960")]
	public static OAMIPODNNBO<AHAMAEENKGG, LJHFFGOEJCA> BNBKCOCNFCG(HECAJEGBBHJ AHFIDHNOIFE, [In] BDEFLKDAAPD GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<AHAMAEENKGG, LJHFFGOEJCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct CICJJMHGIGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct INMJBGHLAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, LJHFFGOEJCA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HECAJEGBBHJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CICJJMHGIGO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private OAMIPODNNBO<bool, LJHFFGOEJCA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, LJHFFGOEJCA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2126D50", Offset = "0x2125950", VA = "0x182126D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2127390", Offset = "0x2125F90", VA = "0x182127390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int DNBGNCFCKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int NAJFJJKNBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] HCNDAPMGMCI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8D20", Offset = "0x1DB7920", VA = "0x181DB8D20")]
	private CICJJMHGIGO(int KNHHBEFLJAF, int MFJLAMOCOBC, byte[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21207B0", Offset = "0x211F3B0", VA = "0x1821207B0")]
	public static AHAMAEENKGG CLPGKMOLMGP(int KNHHBEFLJAF, int MFJLAMOCOBC, ByteString BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21205C0", Offset = "0x211F1C0", VA = "0x1821205C0")]
	public static AHAMAEENKGG?[]? BNGHNPILPEB(int OAKNPKDIJDI, JNFCNCENMII? PJJJPLDPJEK, KAKCODMKIFK? GLFGAKGEEJK, ALHAJLJNJLJ? DAMPDLBECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21209C0", Offset = "0x211F5C0", VA = "0x1821209C0")]
	public static LCLGHMIJKDH<LLLJCAGLDPN, CICJJMHGIGO> PMNCGNOJLEG(AHAMAEENKGG DMNCCDEPCKB)
	{
		return default(LCLGHMIJKDH<LLLJCAGLDPN, CICJJMHGIGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2120890", Offset = "0x211F490", VA = "0x182120890")]
	[AsyncStateMachine(typeof(INMJBGHLAEG))]
	public static Task<OAMIPODNNBO<bool, LJHFFGOEJCA>> NPPDLFNJJJK(HECAJEGBBHJ AHFIDHNOIFE, CICJJMHGIGO GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KFLMHILEOMG : JBHIOPIGLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public APDILIIMKBI? AAGIFLNDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21280A0", Offset = "0x2126CA0", VA = "0x1821280A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	internal KFLMHILEOMG(HECAJEGBBHJ FPAIKMADOEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FCOCHPMFPIE : APDILIIMKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GFIADHGJHPF OOCCAOBOOBN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	public FCOCHPMFPIE(HECAJEGBBHJ FPAIKMADOEB, GFIADHGJHPF AFDBEOPPPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2124620", Offset = "0x2123220", VA = "0x182124620", Slot = "4")]
	public OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM> NCIPLCAEEHM(DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NDAEOGCNEDJ> DMAAAHKLEEI)
	{
		return default(OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2124340", Offset = "0x2122F40", VA = "0x182124340", Slot = "5")]
	public OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM> IJGCJGJJNNE(DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NGICMBDBBIC> LIBLJKEMGBK)
	{
		return default(OAMIPODNNBO<ILEGILPIAOM, DFJMIDJHGOM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FAOKCPMHHCC : DCDCLEKFKNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface NIJIBJDKIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GFIADHGJHPF> EDACOEHFALP(HECAJEGBBHJ FPAIKMADOEB, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC, CancellationToken CKKFHABGBNL);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IKJMNIFLMNE GNCFDICNEJM(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HGAGOAHHCOJ : NIJIBJDKIJI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct PFPNOOLCGIN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<GFIADHGJHPF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HECAJEGBBHJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public KAKCODMKIFK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public ALHAJLJNJLJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<FPDLBCLPOFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x212C980", Offset = "0x212B580", VA = "0x18212C980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x212CB50", Offset = "0x212B750", VA = "0x18212CB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly HGAGOAHHCOJ AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		private HGAGOAHHCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2126AE0", Offset = "0x21256E0", VA = "0x182126AE0", Slot = "4")]
		[AsyncStateMachine(typeof(PFPNOOLCGIN))]
		public Task<GFIADHGJHPF> EDACOEHFALP(HECAJEGBBHJ FPAIKMADOEB, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC, CancellationToken CKKFHABGBNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2126C40", Offset = "0x2125840", VA = "0x182126C40", Slot = "5")]
		public IKJMNIFLMNE GNCFDICNEJM(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BPMDDIKHMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<FAOKCPMHHCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HECAJEGBBHJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KAKCODMKIFK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ALHAJLJNJLJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public JNFCNCENMII evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private NIJIBJDKIJI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<GFIADHGJHPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x211CB60", Offset = "0x211B760", VA = "0x18211CB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x211D060", Offset = "0x211BC60", VA = "0x18211D060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GFIADHGJHPF OOCCAOBOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IKJMNIFLMNE NKCDLBNIDGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KCOMFDLMGDL MMALLIMGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21242F0", Offset = "0x2122EF0", VA = "0x1821242F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BDEGOONFGOO LDNFJAFPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21240C0", Offset = "0x2122CC0", VA = "0x1821240C0", Slot = "5")]
		get
		{
			return default(BDEGOONFGOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FCOCHPMFPIE KIKLEJALHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OHGDKPBJDPK KKKJMICJAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9436E0", Offset = "0x9422E0", VA = "0x1809436E0")]
	private FAOKCPMHHCC(GFIADHGJHPF AFDBEOPPPBO, IKJMNIFLMNE HKIPMAAGEAB, FCOCHPMFPIE HPGFGHCKKJC, OHGDKPBJDPK MPBNJKNJCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2124180", Offset = "0x2122D80", VA = "0x182124180")]
	[AsyncStateMachine(typeof(BPMDDIKHMAG))]
	public static Task<FAOKCPMHHCC> JPAMHLHMCLP(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2124060", Offset = "0x2122C60", VA = "0x182124060", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NGHHPLGJAPK : OFKDOAFPGOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface LOIDEMIKBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DCDCLEKFKNC> CILINOECIJO(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC, CancellationToken CKKFHABGBNL);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GDJKJLOOHCF();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HGEJGBCKCBN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class PCKHLKBHAJB : LOIDEMIKBAE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct ACJLNILKBGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<DCDCLEKFKNC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public HECAJEGBBHJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public JNFCNCENMII evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public KAKCODMKIFK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public ALHAJLJNJLJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<FAOKCPMHHCC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x21103A0", Offset = "0x210EFA0", VA = "0x1821103A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x21106E0", Offset = "0x210F2E0", VA = "0x1821106E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x212C660", Offset = "0x212B260", VA = "0x18212C660", Slot = "4")]
		[AsyncStateMachine(typeof(ACJLNILKBGJ))]
		public Task<DCDCLEKFKNC> CILINOECIJO(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC, CancellationToken CKKFHABGBNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GDJKJLOOHCF();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HGEJGBCKCBN();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected PCKHLKBHAJB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct PJIADGBKOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<DCDCLEKFKNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NGHHPLGJAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<FKMCALNFICP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x212CBC0", Offset = "0x212B7C0", VA = "0x18212CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x212CDC0", Offset = "0x212B9C0", VA = "0x18212CDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JCIGHMMPFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NGHHPLGJAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public HECAJEGBBHJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public JNFCNCENMII evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KAKCODMKIFK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ALHAJLJNJLJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<DCDCLEKFKNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2127400", Offset = "0x2126000", VA = "0x182127400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2127940", Offset = "0x2126540", VA = "0x182127940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LOIDEMIKBAE KPJEAHOHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<FKMCALNFICP> LNECNBFFADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<FKMCALNFICP> NBBHLMJGDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource PHNANLCIACF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HDAAHMCPHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4C10", VA = "0x1808B6010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D90", Offset = "0x8B4990", VA = "0x1808B5D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC80500", Offset = "0xC7F100", VA = "0x180C80500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC804E0", Offset = "0xC7F0E0", VA = "0x180C804E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FPGPLOOKDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x12E4D10", Offset = "0x12E3910", VA = "0x1812E4D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x212B8A0", Offset = "0x212A4A0", VA = "0x18212B8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DCDCLEKFKNC? OPNBAPEHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x212B7B0", Offset = "0x212A3B0", VA = "0x18212B7B0", Slot = "7")]
	[AsyncStateMachine(typeof(PJIADGBKOLE))]
	public Task<DCDCLEKFKNC> BCOLHDPCIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x212BB90", Offset = "0x212A790", VA = "0x18212BB90")]
	public NGHHPLGJAPK(LOIDEMIKBAE DDNPAGAAIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x212BA30", Offset = "0x212A630", VA = "0x18212BA30", Slot = "8")]
	[AsyncStateMachine(typeof(JCIGHMMPFGI))]
	public Task POCPEIEGPEA(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x212B8B0", Offset = "0x212A4B0", VA = "0x18212B8B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CPLKLPBAFDP : IGIKJLFOFFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly OHGDKPBJDPK PMPKJHEJIIC;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public CPLKLPBAFDP(OHGDKPBJDPK MPBNJKNJCNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JNCMBPDFAME
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FCAOCLMBDME<TGraph> : OCLFDLEPGCC where TGraph : OPMGGFMPHEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph KMBADDMLHIB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual LOEOBGBLECC? PGOAMFJGAMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x10FB630", Offset = "0x10FA230", VA = "0x1810FB630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public FANMFDLLPNO<LNEKKJBHBEC> BBEBNLJJCEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3DE87B0", Offset = "0x3DE73B0", VA = "0x183DE87B0", Slot = "5")]
			get
			{
				return default(FANMFDLLPNO<LNEKKJBHBEC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public FANMFDLLPNO<LNEKKJBHBEC>? EGMILAOADPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8730", Offset = "0x3DE7330", VA = "0x183DE8730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
		public FCAOCLMBDME(TGraph DMKHGPNMEMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class MJJDLLNHLJE : FCAOCLMBDME<MOAEKBJPDPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override LOEOBGBLECC? PGOAMFJGAMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x212B180", Offset = "0x2129D80", VA = "0x18212B180", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x212B1A0", Offset = "0x2129DA0", VA = "0x18212B1A0")]
		public MJJDLLNHLJE(MOAEKBJPDPJ COANNGCAFLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2127C60", Offset = "0x2126860", VA = "0x182127C60")]
	public static OCLFDLEPGCC LMDPPDEOAIA(OPMGGFMPHEN DMKHGPNMEMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CACBJMGICIJ : BHJNOBCJGHI, HPBLGKLMNBF, KGHMAIKBCDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class OMDEELFFCJO
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
			public OMDEELFFCJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public EJJBJAKHFCE errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x212D1F0", Offset = "0x212BDF0", VA = "0x18212D1F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x212D460", Offset = "0x212C060", VA = "0x18212D460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CACBJMGICIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OMDEELFFCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x212BD20", Offset = "0x212A920", VA = "0x18212BD20")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FCGADPELCEA(EJJBJAKHFCE errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BOCCBNJPGHJ : IAsyncStateMachine
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
		public CACBJMGICIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x211C5F0", Offset = "0x211B1F0", VA = "0x18211C5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x211CB00", Offset = "0x211B700", VA = "0x18211CB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MADHEMEMDMB
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
			public MADHEMEMDMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x212D4C0", Offset = "0x212C0C0", VA = "0x18212D4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x212D7A0", Offset = "0x212C3A0", VA = "0x18212D7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CACBJMGICIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MADHEMEMDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2129210", Offset = "0x2127E10", VA = "0x182129210")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LGHLALCGPJA(EJJBJAKHFCE errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FFFPAEDNLOF EEKICLBDLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<IDPKLJKCNAA> MCHCBKLCGCN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private LMOCKDHMJIC KACNPMLGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x211DEB0", Offset = "0x211CAB0", VA = "0x18211DEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FANMFDLLPNO<NDAEOGCNEDJ> KBIPJIKJAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x920430", Offset = "0x91F030", VA = "0x180920430", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FANMFDLLPNO<NDAEOGCNEDJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x921230", Offset = "0x91FE30", VA = "0x180921230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private FANMFDLLPNO<CHEBACDPPKC> NAHFLGELFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC7C630", Offset = "0xC7B230", VA = "0x180C7C630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FANMFDLLPNO<NGAFIAGIONI> DLHDCFOADFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AE710", VA = "0x1808AFB10", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FANMFDLLPNO<NGAFIAGIONI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override FANMFDLLPNO<EJJLEGLDJOC> BCLGBAEMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x211EF30", Offset = "0x211DB30", VA = "0x18211EF30", Slot = "20")]
		get
		{
			return default(FANMFDLLPNO<EJJLEGLDJOC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MFKGPKLDHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x211F890", Offset = "0x211E490", VA = "0x18211F890", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x211F910", Offset = "0x211E510", VA = "0x18211F910")]
	private CACBJMGICIJ(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD, FFFPAEDNLOF HCDKMAOJEOH, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NDAEOGCNEDJ> DMAAAHKLEEI, FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK, bool BMEFHFPGGLM, string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x211F0E0", Offset = "0x211DCE0", VA = "0x18211F0E0")]
	public static CACBJMGICIJ LMDPPDEOAIA(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD, FFFPAEDNLOF GKMKPBACAOC, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK, FANMFDLLPNO<NDAEOGCNEDJ> DMAAAHKLEEI, bool BMEFHFPGGLM, bool FFJKALPLNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x211EDD0", Offset = "0x211D9D0", VA = "0x18211EDD0", Slot = "21")]
	protected override void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x211E1D0", Offset = "0x211CDD0", VA = "0x18211E1D0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x211E680", Offset = "0x211D280", VA = "0x18211E680", Slot = "30")]
	public void GDLIFMECACP(IDPKLJKCNAA HLEDMJFALEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x211DA70", Offset = "0x211C670", VA = "0x18211DA70", Slot = "27")]
	public void BBIMIACLMHD(KMOBFFFLNPF KEEIFONEALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x211D0D0", Offset = "0x211BCD0", VA = "0x18211D0D0", Slot = "28")]
	public void AHMJNGEFDLA(JBFGELPPAOI JALBDOJAKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x211E530", Offset = "0x211D130", VA = "0x18211E530", Slot = "23")]
	protected override void FCFMCCGLOKB(JDKGNIODLPD NFIJBNCIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x211EF80", Offset = "0x211DB80", VA = "0x18211EF80", Slot = "32")]
	public string LFLLABPEDHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x211E6E0", Offset = "0x211D2E0", VA = "0x18211E6E0", Slot = "29")]
	public string HOFLANCLGPH(int PEMOHIDFBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x211E300", Offset = "0x211CF00", VA = "0x18211E300")]
	private void ELLGNADFCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x211F4A0", Offset = "0x211E0A0", VA = "0x18211F4A0", Slot = "31")]
	public void MDPMPDKCAOK(IDPKLJKCNAA HLEDMJFALEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x211EB80", Offset = "0x211D780", VA = "0x18211EB80")]
	private void IOEKMDAIEKN(bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x211F570", Offset = "0x211E170", VA = "0x18211F570", Slot = "33")]
	[AsyncStateMachine(typeof(BOCCBNJPGHJ))]
	public Task MFIJEKKAOOF(string CABLCDOIFFL, bool CIEMGPEAOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x211F680", Offset = "0x211E280", VA = "0x18211F680")]
	public void NDDEOFFODBH(string CABLCDOIFFL, bool CIEMGPEAOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x211E030", Offset = "0x211CC30", VA = "0x18211E030")]
	private void DNJIMLDAHCI(int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x921230", Offset = "0x91FE30", VA = "0x180921230")]
	internal void KKMBDGCEKOA(FANMFDLLPNO<NDAEOGCNEDJ> CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x211ED40", Offset = "0x211D940", VA = "0x18211ED40")]
	[CompilerGenerated]
	private void KCFJGJKOHAJ(string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x211E9F0", Offset = "0x211D5F0", VA = "0x18211E9F0")]
	[CompilerGenerated]
	private bool ILPOKIKFEDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x211EE70", Offset = "0x211DA70", VA = "0x18211EE70")]
	[CompilerGenerated]
	private bool KPHNNGFKHCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x211E9A0", Offset = "0x211D5A0", VA = "0x18211E9A0")]
	[CompilerGenerated]
	private int IAKLEFLCKHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x211E270", Offset = "0x211CE70", VA = "0x18211E270")]
	[CompilerGenerated]
	private bool ELFBCBHNNLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x211F490", Offset = "0x211E090", VA = "0x18211F490")]
	[CompilerGenerated]
	private void MBIHNPOOHOI(string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x211F7D0", Offset = "0x211E3D0", VA = "0x18211F7D0")]
	[CompilerGenerated]
	private bool NEEPFBFBJAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x211DF50", Offset = "0x211CB50", VA = "0x18211DF50")]
	[CompilerGenerated]
	private bool DBFCIDFACON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x211DFA0", Offset = "0x211CBA0", VA = "0x18211DFA0")]
	[CompilerGenerated]
	private bool DNGBBACEGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x211E9A0", Offset = "0x211D5A0", VA = "0x18211E9A0")]
	[CompilerGenerated]
	private int PLEOOLKDHJO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x211EAB0", Offset = "0x211D6B0", VA = "0x18211EAB0")]
	[CompilerGenerated]
	private bool INBEGBLEBCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x211ED50", Offset = "0x211D950", VA = "0x18211ED50")]
	[CompilerGenerated]
	private object KKBOPNFJIGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x211DED0", Offset = "0x211CAD0", VA = "0x18211DED0")]
	[CompilerGenerated]
	private void CCFJMNDFGNB(object CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x211DDE0", Offset = "0x211C9E0", VA = "0x18211DDE0")]
	[CompilerGenerated]
	private bool BNKDKCLDJCD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DDHJCJGKPKL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private sealed class KKGLJKPIMDG : HPJBMACCDBJ<BGABCDOCPED>
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class GNJFAKFGEMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KKGLJKPIMDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GNJFAKFGEMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2125170", Offset = "0x2123D70", VA = "0x182125170")]
			internal object ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x21251E0", Offset = "0x2123DE0", VA = "0x1821251E0")]
			internal void OAHKBLJIFML(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2128440", Offset = "0x2127040", VA = "0x182128440")]
		public KKGLJKPIMDG(HECAJEGBBHJ FPAIKMADOEB, BGABCDOCPED GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x21281B0", Offset = "0x2126DB0", VA = "0x1821281B0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class CEPILCHCMBD : PBLEGCCFPAI<NPPDIPMOFAA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override HCBKHLMNCPD AELCIBBIEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F6D0", VA = "0x180910AD0", Slot = "128")]
			get
			{
				return default(HCBKHLMNCPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x21204F0", Offset = "0x211F0F0", VA = "0x1821204F0")]
		public CEPILCHCMBD(HECAJEGBBHJ FPAIKMADOEB, NPPDIPMOFAA GMBKDDMMMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class FGAEACGGIPC : HPJBMACCDBJ<PKIOPPJIMIO>
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2124BF0", Offset = "0x21237F0", VA = "0x182124BF0")]
		public FGAEACGGIPC(HECAJEGBBHJ FPAIKMADOEB, PKIOPPJIMIO HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2124900", Offset = "0x2123500", VA = "0x182124900", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2124BA0", Offset = "0x21237A0", VA = "0x182124BA0")]
		[CompilerGenerated]
		private bool HNOAMOGJOKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2124A80", Offset = "0x2123680", VA = "0x182124A80")]
		[CompilerGenerated]
		private void FKMOLLBJLAJ(bool CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class BFBDJBLEGPN : HPJBMACCDBJ<JPMFOADCLPB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class JLDBBMGBLNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public BFBDJBLEGPN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JLDBBMGBLNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2127A50", Offset = "0x2126650", VA = "0x182127A50")]
			internal void ALELIDPNDLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2127C10", Offset = "0x2126810", VA = "0x182127C10")]
			internal bool OAHKBLJIFML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2127BC0", Offset = "0x21267C0", VA = "0x182127BC0")]
			internal bool KPABALKIMEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2127AA0", Offset = "0x21266A0", VA = "0x182127AA0")]
			internal void BPOAFEAIGGC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2127A00", Offset = "0x2126600", VA = "0x182127A00")]
			internal bool ADJJKGEKMEG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x21110B0", Offset = "0x210FCB0", VA = "0x1821110B0")]
		public BFBDJBLEGPN(HECAJEGBBHJ FPAIKMADOEB, JPMFOADCLPB HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2110D70", Offset = "0x210F970", VA = "0x182110D70", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class BMHJGEFFDLJ : HPJBMACCDBJ<ANGKNEFDCOO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class CACFBNNDJGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public BMHJGEFFDLJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CACFBNNDJGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x211FBA0", Offset = "0x211E7A0", VA = "0x18211FBA0")]
			internal object ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x211FFC0", Offset = "0x211EBC0", VA = "0x18211FFC0")]
			internal bool LGMAIHJAMPE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2120040", Offset = "0x211EC40", VA = "0x182120040")]
			internal void OAHKBLJIFML(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x211FE60", Offset = "0x211EA60", VA = "0x18211FE60")]
			internal string KPABALKIMEH(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x211FCA0", Offset = "0x211E8A0", VA = "0x18211FCA0")]
			internal IReadOnlyList<object> BPOAFEAIGGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x211FB30", Offset = "0x211E730", VA = "0x18211FB30")]
			internal bool ADJJKGEKMEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x211FE10", Offset = "0x211EA10", VA = "0x18211FE10")]
			internal bool DGKGKMEIILK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x211FCF0", Offset = "0x211E8F0", VA = "0x18211FCF0")]
			internal void CBCOKMGEFCO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x211C580", Offset = "0x211B180", VA = "0x18211C580")]
		public BMHJGEFFDLJ(HECAJEGBBHJ FPAIKMADOEB, ANGKNEFDCOO HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x211BE20", Offset = "0x211AA20", VA = "0x18211BE20", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class GJAMHCAEOPM : HPJBMACCDBJ<JAPLELONELL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class PEIBPFFAALA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public GJAMHCAEOPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PEIBPFFAALA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x212C7C0", Offset = "0x212B3C0", VA = "0x18212C7C0")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x212C860", Offset = "0x212B460", VA = "0x18212C860")]
			internal void OAHKBLJIFML(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x212C810", Offset = "0x212B410", VA = "0x18212C810")]
			internal bool KPABALKIMEH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2125100", Offset = "0x2123D00", VA = "0x182125100")]
		public GJAMHCAEOPM(HECAJEGBBHJ FPAIKMADOEB, JAPLELONELL HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2124ED0", Offset = "0x2123AD0", VA = "0x182124ED0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class FEEBHEJIINI<TNode> : HPJBMACCDBJ<TNode> where TNode : notnull, PBGCIEKPBME
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct KNEHGGPCINM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public FEEBHEJIINI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x42D6F40", Offset = "0x42D5B40", VA = "0x1842D6F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x42D7330", Offset = "0x42D5F30", VA = "0x1842D7330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct FBICLLJIFLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public FEEBHEJIINI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3DE75A0", Offset = "0x3DE61A0", VA = "0x183DE75A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7990", Offset = "0x3DE6590", VA = "0x183DE7990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool OIHJGJGJHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override FANMFDLLPNO<JOGIKJOJMKJ>? GBBOFNFGBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3DF97B0", Offset = "0x3DF83B0", VA = "0x183DF97B0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9760", Offset = "0x3DF8360", VA = "0x183DF9760")]
		protected FEEBHEJIINI(HECAJEGBBHJ FPAIKMADOEB, TNode HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9640", Offset = "0x3DF8240", VA = "0x183DF9640", Slot = "102")]
		[AsyncStateMachine(typeof(FEEBHEJIINI<>.KNEHGGPCINM))]
		public override Task<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> MNJEIMBOHBK(string GMBAACDNNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9350", Offset = "0x3DF7F50", VA = "0x183DF9350", Slot = "126")]
		public sealed override bool AJGFPIPCIBK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9500", Offset = "0x3DF8100", VA = "0x183DF9500", Slot = "114")]
		protected sealed override bool BALMIKCFILH(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3DF95A0", Offset = "0x3DF81A0", VA = "0x183DF95A0", Slot = "115")]
		protected override bool GPCHNCEJAJI(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3DF93F0", Offset = "0x3DF7FF0", VA = "0x183DF93F0", Slot = "103")]
		[AsyncStateMachine(typeof(FEEBHEJIINI<>.FBICLLJIFLD))]
		public override Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> AOGJNGCJGFK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class KDGEDAIOLCG : KONKPOEKCJG<PBENGGLCBEA>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class PNHNHMLIHNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public KDGEDAIOLCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PNHNHMLIHNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x212CE30", Offset = "0x212BA30", VA = "0x18212CE30")]
			internal bool FEMBENICCFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x212CEB0", Offset = "0x212BAB0", VA = "0x18212CEB0")]
			internal void JDOOMBPCDBM(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2128040", Offset = "0x2126C40", VA = "0x182128040")]
		public KDGEDAIOLCG(HECAJEGBBHJ FPAIKMADOEB, PBENGGLCBEA GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2127DF0", Offset = "0x21269F0", VA = "0x182127DF0", Slot = "128")]
		protected override void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class JFMKBEMINEF : ICNGLLNMOID<KFICEMEBBNK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x21279A0", Offset = "0x21265A0", VA = "0x1821279A0")]
		public JFMKBEMINEF(HECAJEGBBHJ FPAIKMADOEB, KFICEMEBBNK HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public abstract class ICNGLLNMOID<TNode> : HPJBMACCDBJ<TNode> where TNode : notnull, DEAKKIHFBOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct NMCBGPFGELD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4679880", Offset = "0x4678480", VA = "0x184679880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x4679D10", Offset = "0x4678910", VA = "0x184679D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct FNHNDGCABAF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3E1E950", Offset = "0x3E1D550", VA = "0x183E1E950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3E1EDC0", Offset = "0x3E1D9C0", VA = "0x183E1EDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct BHEEFPEGAHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private TaskAwaiter<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50AAD70", Offset = "0x50A9970", VA = "0x1850AAD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x50AB420", Offset = "0x50AA020", VA = "0x1850AB420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class NDAEOKOKAFB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public NDAEOKOKAFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x37817F0", Offset = "0x37803F0", VA = "0x1837817F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public MOIGKILBFLB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public NDAEOKOKAFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x464B7B0", Offset = "0x464A3B0", VA = "0x18464B7B0")]
			internal bool CBCOKMGEFCO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x464B4E0", Offset = "0x464A0E0", VA = "0x18464B4E0")]
			internal void ALELIDPNDLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x464B890", Offset = "0x464A490", VA = "0x18464B890")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.NDAEOKOKAFB.<<BuildConfigMenuInternal>b__7>d))]
			internal void LGMAIHJAMPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x464B930", Offset = "0x464A530", VA = "0x18464B930")]
			internal bool OAHKBLJIFML()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class PDMOHGLDKHB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public PDMOHGLDKHB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x3781480", Offset = "0x3780080", VA = "0x183781480", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public NDAEOKOKAFB CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PDMOHGLDKHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4882810", Offset = "0x4881410", VA = "0x184882810")]
			internal void KPABALKIMEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			internal string BPOAFEAIGGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			internal void ADJJKGEKMEG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4882770", Offset = "0x4881370", VA = "0x184882770")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.PDMOHGLDKHB.<<BuildConfigMenuInternal>b__5>d))]
			internal void DGKGKMEIILK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class OPPBNLMNPOJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public OPPBNLMNPOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3780FB0", Offset = "0x377FBB0", VA = "0x183780FB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public OPPBNLMNPOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<CHEBACDPPKC>, BDMFJEIOIAD>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x3781190", Offset = "0x377FD90", VA = "0x183781190", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public OPPBNLMNPOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<JCAEKHBPEKE>, BDMFJEIOIAD>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x37808F0", Offset = "0x377F4F0", VA = "0x1837808F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public MOIGKILBFLB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AONEJDLMABH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public CCHIIJMLNME selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public List<ODMAIDEAELI> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public CCHIIJMLNME selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public List<ODMAIDEAELI> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OPPBNLMNPOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x47DCFA0", Offset = "0x47DBBA0", VA = "0x1847DCFA0")]
			internal bool DPMPBNJAOOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x47DCED0", Offset = "0x47DBAD0", VA = "0x1847DCED0")]
			internal void CKAHLMBFBHB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x47DD510", Offset = "0x47DC110", VA = "0x1847DD510")]
			internal bool OLFKDLFJMIJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x47DD300", Offset = "0x47DBF00", VA = "0x1847DD300")]
			internal bool JAEMBBOIKKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x47DD260", Offset = "0x47DBE60", VA = "0x1847DD260")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.OPPBNLMNPOJ.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void INPNICBMPNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x47DD690", Offset = "0x47DC290", VA = "0x1847DD690")]
			internal bool PCGJGLNCIMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x47DD450", Offset = "0x47DC050", VA = "0x1847DD450")]
			internal void OFCJPJDCGJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x47DCD50", Offset = "0x47DB950", VA = "0x1847DCD50")]
			internal bool AFBBGPJHOKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x47DD010", Offset = "0x47DBC10", VA = "0x1847DD010")]
			internal void EFBPOGKGGCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x47DD0D0", Offset = "0x47DBCD0", VA = "0x1847DD0D0")]
			internal bool FOALHAONOGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x47DD180", Offset = "0x47DBD80", VA = "0x1847DD180")]
			internal bool GGPKAELIGGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x47DD1F0", Offset = "0x47DBDF0", VA = "0x1847DD1F0")]
			internal void IGNEAKKCAOH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x47DD5F0", Offset = "0x47DC1F0", VA = "0x1847DD5F0")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.OPPBNLMNPOJ.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void ONOOHHALNFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x47DCF40", Offset = "0x47DBB40", VA = "0x1847DCF40")]
			internal bool COGOOBKJHLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x47DCE00", Offset = "0x47DBA00", VA = "0x1847DCE00")]
			internal bool AIOIHCCNJEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x47DD340", Offset = "0x47DBF40", VA = "0x1847DD340")]
			internal void JEGIHAIKPDP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x47DD3B0", Offset = "0x47DBFB0", VA = "0x1847DD3B0")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.OPPBNLMNPOJ.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void LGDKDMKEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x47DCE70", Offset = "0x47DBA70", VA = "0x1847DCE70")]
			internal bool BGLHDHONCMN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class IJAMCBFJJON
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public IJAMCBFJJON <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3780BE0", Offset = "0x377F7E0", VA = "0x183780BE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public OPPBNLMNPOJ CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public IJAMCBFJJON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x402E830", Offset = "0x402D430", VA = "0x18402E830")]
			internal void DBBMIPEOEPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			internal string HBIDIHDKNIG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			internal void GIFALGAIAKF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x402EC50", Offset = "0x402D850", VA = "0x18402EC50")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.IJAMCBFJJON.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void OEKCJBPFGFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class PAOMNAKIJCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AONEJDLMABH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public List<ODMAIDEAELI> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public ICNGLLNMOID<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PAOMNAKIJCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x486B560", Offset = "0x486A160", VA = "0x18486B560")]
			internal bool KOCIHDDEAEF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class AIGIGFGOAPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public KGHMAIKBCDM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public PAOMNAKIJCN CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public AIGIGFGOAPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3EB67C0", Offset = "0x3EB53C0", VA = "0x183EB67C0")]
			internal void EEMDIDPLAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3EB68D0", Offset = "0x3EB54D0", VA = "0x183EB68D0")]
			internal bool FHPMKHNMEEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6920", Offset = "0x3EB5520", VA = "0x183EB6920")]
			internal void LLBFGMDBJCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6760", Offset = "0x3EB5360", VA = "0x183EB6760")]
			internal bool CBADOAPOGNL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class LOJPFFGIOHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public ODMAIDEAELI portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public AIGIGFGOAPM CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public LOJPFFGIOHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x43C4A10", Offset = "0x43C3610", VA = "0x1843C4A10")]
			internal void BLPDLCFBEPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class APJHIAKFCPA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public APJHIAKFCPA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x3782C30", Offset = "0x3781830", VA = "0x183782C30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public CCHIIJMLNME selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public AONEJDLMABH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KGHMAIKBCDM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public APJHIAKFCPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x40630E0", Offset = "0x4061CE0", VA = "0x1840630E0")]
			internal int MFMMBBLJDKK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4062EA0", Offset = "0x4061AA0", VA = "0x184062EA0")]
			internal void FJBJNPGKJFN(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			internal string JOJILNLCCJK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4063120", Offset = "0x4061D20", VA = "0x184063120")]
			[AsyncStateMachine(typeof(ICNGLLNMOID<>.APJHIAKFCPA.<<CreatePortItemV2>b__3>d))]
			internal void NNEEONNADNP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x40631E0", Offset = "0x4061DE0", VA = "0x1840631E0")]
			internal bool PEEPIGBJMFK(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> AEKJOJOMMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> CJPOBECDAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> OFLPBOIJMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> GFPHEKNAANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> PEIKGIGCNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<FANMFDLLPNO<JOGIKJOJMKJ>, bool> DAOHGLLFMAL;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool EGKICAONNPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool JFBEEFMDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool NGLEILHINOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool NLNDMJEEOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override FANMFDLLPNO<LNEKKJBHBEC>? FCOHCEOCEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4017770", Offset = "0x4016370", VA = "0x184017770", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FANMFDLLPNO<JOGIKJOJMKJ>? GBBOFNFGBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4017A30", Offset = "0x4016630", VA = "0x184017A30", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<DBMOGKNBCFK<LOCKFIIFIFD>>? HHLLOPAIIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4017830", Offset = "0x4016430", VA = "0x184017830", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4017550", Offset = "0x4016150", VA = "0x184017550")]
		public ICNGLLNMOID(HECAJEGBBHJ FPAIKMADOEB, TNode HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "131")]
		protected virtual bool AIBHAEOGFDJ(int LONFBMKLCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "132")]
		protected virtual bool BAGMKFBFEKA(int LONFBMKLCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "133")]
		protected virtual bool DNAKHLDBFMH(int LONFBMKLCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "134")]
		protected virtual void PJHPNAHGLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4015EB0", Offset = "0x4014AB0", VA = "0x184015EB0", Slot = "126")]
		public override bool AJGFPIPCIBK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4017430", Offset = "0x4016030", VA = "0x184017430", Slot = "102")]
		[AsyncStateMachine(typeof(ICNGLLNMOID<>.NMCBGPFGELD))]
		public override Task<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> MNJEIMBOHBK(string GMBAACDNNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4016140", Offset = "0x4014D40", VA = "0x184016140", Slot = "103")]
		[AsyncStateMachine(typeof(ICNGLLNMOID<>.FNHNDGCABAF))]
		public override Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> AOGJNGCJGFK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x40170A0", Offset = "0x4015CA0", VA = "0x1840170A0", Slot = "104")]
		public override void JDJHAKGNCJH(FANMFDLLPNO<JOGIKJOJMKJ> MFJLAMOCOBC, FANMFDLLPNO<JOGIKJOJMKJ> CGJNNJHBPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4016E40", Offset = "0x4015A40", VA = "0x184016E40", Slot = "105")]
		public override IEnumerable<AHAMAEENKGG> CHFMNCGMCOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x40172A0", Offset = "0x4015EA0", VA = "0x1840172A0")]
		[AsyncStateMachine(typeof(ICNGLLNMOID<>.BHEEFPEGAHP))]
		private Task<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> JLJPJPEELPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "135")]
		protected virtual bool NPAJIDGHHLK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "136")]
		protected virtual bool KMNJDFLFMNP(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "137")]
		protected virtual bool CMNJMKBLAAA(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "138")]
		protected virtual bool ECPGDGCMHEO(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "139")]
		protected virtual bool PGBMCDNDPOM(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int HENBLCHJNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "140")]
		protected virtual bool MJKNDJBIGNG(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int HENBLCHJNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "141")]
		protected virtual bool JOAPAEBBNBI(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int FLJAKIALHAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "142")]
		protected virtual bool AFHBJMMIPCC(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int FLJAKIALHAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "143")]
		protected virtual bool OLDNPEHBHIF(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int IJLIHPPNNDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "144")]
		protected virtual bool LLOHAHDLCOO(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, int FJMEADGFOCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4016250", Offset = "0x4014E50", VA = "0x184016250", Slot = "145")]
		protected virtual List<CCHIIJMLNME> BDHGFOLFAKJ(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "146")]
		protected virtual void JJLGECJBLAG(MOIGKILBFLB NPGCDKAEFPP, BICEDMHHGFE BEGAEIEDOJC, AONEJDLMABH AONJMAMIJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4015450", Offset = "0x4014050", VA = "0x184015450", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4013D30", Offset = "0x4012930", VA = "0x184013D30")]
		private BICEDMHHGFE AEELBNEJPIC(MOIGKILBFLB NPGCDKAEFPP, AONEJDLMABH AONJMAMIJFN, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4012BF0", Offset = "0x40117F0", VA = "0x184012BF0")]
		private List<ODMAIDEAELI> ACBCOLOACDJ(MOIGKILBFLB NPGCDKAEFPP, AONEJDLMABH AONJMAMIJFN, BICEDMHHGFE EFGAICFKGKA, bool PLLOJEKJPJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x40164F0", Offset = "0x40150F0", VA = "0x1840164F0")]
		private List<ODMAIDEAELI> CGHADBNFDKO(MOIGKILBFLB NPGCDKAEFPP, AONEJDLMABH AONJMAMIJFN, KGHMAIKBCDM APMPPPPEKJK, bool PLLOJEKJPJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4015F50", Offset = "0x4014B50", VA = "0x184015F50")]
		private CCHIIJMLNME AKMIKJKJNOE(List<CCHIIJMLNME> OJPCEBMOFNI, KGHMAIKBCDM APMPPPPEKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x40173A0", Offset = "0x4015FA0", VA = "0x1840173A0")]
		[CompilerGenerated]
		private AHAMAEENKGG LHAKDCPJEPK(CABMAJOBDAN EKJHOCEPHIA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class EENGLPJMNPP : HPJBMACCDBJ<NAJKPMDGMOL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class ABKDKGCBPAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public EENGLPJMNPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public ABKDKGCBPAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x21102C0", Offset = "0x210EEC0", VA = "0x1821102C0")]
			internal int ALELIDPNDLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2110310", Offset = "0x210EF10", VA = "0x182110310")]
			internal void OAHKBLJIFML(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2122D30", Offset = "0x2121930", VA = "0x182122D30")]
		public EENGLPJMNPP(HECAJEGBBHJ FPAIKMADOEB, NAJKPMDGMOL HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2122B70", Offset = "0x2121770", VA = "0x182122B70", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class DCDPDFJFKIH : KONKPOEKCJG<CHPMGOFPJND>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class GDPDJJCJGOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public DCDPDFJFKIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GDPDJJCJGOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x2124C60", Offset = "0x2123860", VA = "0x182124C60")]
			internal int FEMBENICCFK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2124CE0", Offset = "0x21238E0", VA = "0x182124CE0")]
			internal void JDOOMBPCDBM(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x21210C0", Offset = "0x211FCC0", VA = "0x1821210C0")]
		public DCDPDFJFKIH(HECAJEGBBHJ FPAIKMADOEB, CHPMGOFPJND GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2120E80", Offset = "0x211FA80", VA = "0x182120E80", Slot = "128")]
		protected override void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class CFCPLGGHIKA : HPJBMACCDBJ<FLDODNEGODD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA35370", Offset = "0xA33F70", VA = "0x180A35370", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2120550", Offset = "0x211F150", VA = "0x182120550")]
		public CFCPLGGHIKA(HECAJEGBBHJ FPAIKMADOEB, FLDODNEGODD HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class MBINKPNIHLE : HPJBMACCDBJ<KFDDBIAEOBD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class BJOBHNHKFIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public MBINKPNIHLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public MOIGKILBFLB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public BJOBHNHKFIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x21114A0", Offset = "0x21100A0", VA = "0x1821114A0")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x211B270", Offset = "0x2119E70", VA = "0x18211B270")]
			internal void OAHKBLJIFML(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2111240", Offset = "0x210FE40", VA = "0x182111240")]
			internal bool ADJJKGEKMEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2112310", Offset = "0x2110F10", VA = "0x182112310")]
			internal bool DGKGKMEIILK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2111C80", Offset = "0x2110880", VA = "0x182111C80")]
			internal void CBCOKMGEFCO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2111540", Offset = "0x2110140", VA = "0x182111540")]
			internal bool AMIGANNAOOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2112B10", Offset = "0x2111710", VA = "0x182112B10")]
			internal bool FFPKKJBDHDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x211AD00", Offset = "0x2119900", VA = "0x18211AD00")]
			internal void MPKNPMCNPJK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x21133F0", Offset = "0x2111FF0", VA = "0x1821133F0")]
			internal bool HAFEPFJDMHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2111C30", Offset = "0x2110830", VA = "0x182111C30")]
			internal bool BPAGLADCJII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x211BD20", Offset = "0x211A920", VA = "0x18211BD20")]
			internal void PMKIECAGPHP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x21120E0", Offset = "0x2110CE0", VA = "0x1821120E0")]
			internal bool CNADHLAKJIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x211A000", Offset = "0x2118C00", VA = "0x18211A000")]
			internal bool JPGOKDEDAIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2112C50", Offset = "0x2111850", VA = "0x182112C50")]
			internal bool FIAKDMPMIMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x211A3B0", Offset = "0x2118FB0", VA = "0x18211A3B0")]
			internal bool KLGAIAJKFGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2111120", Offset = "0x210FD20", VA = "0x182111120")]
			internal bool AAKNJAGNHFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2112030", Offset = "0x2110C30", VA = "0x182112030")]
			internal bool CKEFFHKHJBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x21117B0", Offset = "0x21103B0", VA = "0x1821117B0")]
			internal bool BBPKOPALOOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2111960", Offset = "0x2110560", VA = "0x182111960")]
			internal bool BFDFKHLOMNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x21199F0", Offset = "0x21185F0", VA = "0x1821199F0")]
			internal bool IDHJCHHCGFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x211A550", Offset = "0x2119150", VA = "0x18211A550")]
			internal void LAPELIGHGJL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x211A7B0", Offset = "0x21193B0", VA = "0x18211A7B0")]
			internal bool LKEGOFHBGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2112CA0", Offset = "0x21118A0", VA = "0x182112CA0")]
			internal bool FJOIODLFMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2112E30", Offset = "0x2111A30", VA = "0x182112E30")]
			internal bool GAIFLENOBBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x211A660", Offset = "0x2119260", VA = "0x18211A660")]
			internal bool LDEDOOOIPHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x211B3C0", Offset = "0x2119FC0", VA = "0x18211B3C0")]
			internal bool OHCKNKCFGBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2111B90", Offset = "0x2110790", VA = "0x182111B90")]
			internal bool BKOAOMMGCGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x211A2F0", Offset = "0x2118EF0", VA = "0x18211A2F0")]
			internal bool KKJBGBFLEAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2112270", Offset = "0x2110E70", VA = "0x182112270")]
			internal bool DFGIFBBHJOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x211A6B0", Offset = "0x21192B0", VA = "0x18211A6B0")]
			internal void LDLGNAKLJEP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x21131D0", Offset = "0x2111DD0", VA = "0x1821131D0")]
			internal bool GMFHGADHGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x211A050", Offset = "0x2118C50", VA = "0x18211A050")]
			internal bool KABMMALKJGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x211B620", Offset = "0x211A220", VA = "0x18211B620")]
			internal void PCLLKOGLJMA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x211A500", Offset = "0x2119100", VA = "0x18211A500")]
			internal bool LABNACODABL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x211AC00", Offset = "0x2119800", VA = "0x18211AC00")]
			internal bool MJKMAAAHCIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2112620", Offset = "0x2111220", VA = "0x182112620")]
			internal void EGGKJFCAIDF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2113620", Offset = "0x2112220", VA = "0x182113620")]
			internal List<ODMAIDEAELI> HNBEDOBBOJF(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2111290", Offset = "0x210FE90", VA = "0x182111290")]
			internal bool AEBBNEGHDKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x21132C0", Offset = "0x2111EC0", VA = "0x1821132C0")]
			internal int GOGCMKLHMLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2111EE0", Offset = "0x2110AE0", VA = "0x182111EE0")]
			internal void CGCFIOKAPND(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2111A50", Offset = "0x2110650", VA = "0x182111A50")]
			internal bool BIMMOEHBNCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x211A2A0", Offset = "0x2118EA0", VA = "0x18211A2A0")]
			internal bool KKGBLKCEFGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2119B90", Offset = "0x2118790", VA = "0x182119B90")]
			internal bool IMIOAIELCFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2112420", Offset = "0x2111020", VA = "0x182112420")]
			internal int DLCDACGJBLD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2119880", Offset = "0x2118480", VA = "0x182119880")]
			internal void IAPHIAADGCM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x211A960", Offset = "0x2119560", VA = "0x18211A960")]
			internal bool MAGIDGPAJCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2119B40", Offset = "0x2118740", VA = "0x182119B40")]
			internal bool IKALCBIHDEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x211B830", Offset = "0x211A430", VA = "0x18211B830")]
			internal bool PKBEGFLAFBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2111FE0", Offset = "0x2110BE0", VA = "0x182111FE0")]
			internal bool CJAMJGEFKHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x21128E0", Offset = "0x21114E0", VA = "0x1821128E0")]
			internal bool EPNIIEDFFGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x211B7E0", Offset = "0x211A3E0", VA = "0x18211B7E0")]
			internal bool PJMMINDBCAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x211A190", Offset = "0x2118D90", VA = "0x18211A190")]
			internal string KIMKKJFBHFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2119930", Offset = "0x2118530", VA = "0x182119930")]
			internal void ICNOIOOGJIE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x21134E0", Offset = "0x21120E0", VA = "0x1821134E0")]
			internal int HECHGBGLKNH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x211ABA0", Offset = "0x21197A0", VA = "0x18211ABA0")]
			internal void MIKBOCPKBIK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2119FB0", Offset = "0x2118BB0", VA = "0x182119FB0")]
			internal bool JOIMDGNCMAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x211BDD0", Offset = "0x211A9D0", VA = "0x18211BDD0")]
			internal bool PNBJJFNKGIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2119D80", Offset = "0x2118980", VA = "0x182119D80")]
			internal bool JGAFNEEIMEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x21116D0", Offset = "0x21102D0", VA = "0x1821116D0")]
			internal float BAMJOEDDHAB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2112080", Offset = "0x2110C80", VA = "0x182112080")]
			internal void CKKABMCENDA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2119AA0", Offset = "0x21186A0", VA = "0x182119AA0")]
			internal bool IFGNFBPHOBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2111F90", Offset = "0x2110B90", VA = "0x182111F90")]
			internal bool CINEPGKKKFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2112980", Offset = "0x2111580", VA = "0x182112980")]
			internal bool FBGFJODIBPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2111AA0", Offset = "0x21106A0", VA = "0x182111AA0")]
			internal bool BINLOFMEPEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2112B60", Offset = "0x2111760", VA = "0x182112B60")]
			internal bool FHGINFANBJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2119EC0", Offset = "0x2118AC0", VA = "0x182119EC0")]
			internal bool JMFBIBGDDKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x211B880", Offset = "0x211A480", VA = "0x18211B880")]
			internal void PKGNBIJNNII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x211B510", Offset = "0x211A110", VA = "0x18211B510")]
			internal string OJDHMPKGJEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x211AA20", Offset = "0x2119620", VA = "0x18211AA20")]
			internal void MCHOCHBGHNI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x211B4C0", Offset = "0x211A0C0", VA = "0x18211B4C0")]
			internal bool OINBPCCEHIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x211A0F0", Offset = "0x2118CF0", VA = "0x18211A0F0")]
			internal bool KEKENHANKJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x211BC30", Offset = "0x211A830", VA = "0x18211BC30")]
			internal bool PKKICCNCPIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x211AF10", Offset = "0x2119B10", VA = "0x18211AF10")]
			internal void NLBAPEAAFKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x211B560", Offset = "0x211A160", VA = "0x18211B560")]
			internal bool OKLJBCJADFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x211A850", Offset = "0x2119450", VA = "0x18211A850")]
			internal bool LOCIBAMPPFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2112BB0", Offset = "0x21117B0", VA = "0x182112BB0")]
			internal bool FHKNPEMLKKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x211B320", Offset = "0x2119F20", VA = "0x18211B320")]
			internal bool OBHGPCAOOBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2111170", Offset = "0x210FD70", VA = "0x182111170")]
			internal void ACOCCKJMPDD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x21123D0", Offset = "0x2110FD0", VA = "0x1821123D0")]
			internal bool DKGBIKEMABF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2111CE0", Offset = "0x21108E0", VA = "0x182111CE0")]
			internal bool CBDJLOGBLAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2112A70", Offset = "0x2111670", VA = "0x182112A70")]
			internal bool FDLMPLJNPHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x211A8A0", Offset = "0x21194A0", VA = "0x18211A8A0")]
			internal bool LOOKMGEHFEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x211A5B0", Offset = "0x21191B0", VA = "0x18211A5B0")]
			internal void LBFDLJECKJM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2112580", Offset = "0x2111180", VA = "0x182112580")]
			internal bool EEODCGJAMGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2112830", Offset = "0x2111430", VA = "0x182112830")]
			internal bool ENKHMLBJOBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2111800", Offset = "0x2110400", VA = "0x182111800")]
			internal bool BCEPBNCGELE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x211BCD0", Offset = "0x211A8D0", VA = "0x18211BCD0")]
			internal bool PLHBJBEODDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2112360", Offset = "0x2110F60", VA = "0x182112360")]
			internal object DIOCJFNFOID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2119BE0", Offset = "0x21187E0", VA = "0x182119BE0")]
			internal void IMKBBHCIDIE(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2119E70", Offset = "0x2118A70", VA = "0x182119E70")]
			internal bool JLACFBCCIDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2112130", Offset = "0x2110D30", VA = "0x182112130")]
			internal bool CNCFOIBFPJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x211A610", Offset = "0x2119210", VA = "0x18211A610")]
			internal int LBJJDEIOKDO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2119A40", Offset = "0x2118640", VA = "0x182119A40")]
			internal void IEPGMNBFKJH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x2112D40", Offset = "0x2111940", VA = "0x182112D40")]
			internal bool FLPKOPJNDEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x211B720", Offset = "0x211A320", VA = "0x18211B720")]
			internal bool PIFOHJOKBNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2112AC0", Offset = "0x21116C0", VA = "0x182112AC0")]
			internal int FELJHDPBCEG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2112880", Offset = "0x2111480", VA = "0x182112880")]
			internal void ENPEPGENKCF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2112DE0", Offset = "0x21119E0", VA = "0x182112DE0")]
			internal bool FPEGCNIGBCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2119DD0", Offset = "0x21189D0", VA = "0x182119DD0")]
			internal bool JIMGNDPIAIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2112930", Offset = "0x2111530", VA = "0x182112930")]
			internal bool FBAIAHIMAJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2113080", Offset = "0x2111C80", VA = "0x182113080")]
			internal int GJEOFMNMFEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2113120", Offset = "0x2111D20", VA = "0x182113120")]
			internal void GJNPJCCNLMC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2119F10", Offset = "0x2118B10", VA = "0x182119F10")]
			internal bool JMLOEBJAKPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21127E0", Offset = "0x21113E0", VA = "0x1821127E0")]
			internal bool ENHNJMPALNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x211AE70", Offset = "0x2119A70", VA = "0x18211AE70")]
			internal bool NFOPOPGJNIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x211A9B0", Offset = "0x21195B0", VA = "0x18211A9B0")]
			internal object MCGBAAJFDKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2113310", Offset = "0x2111F10", VA = "0x182113310")]
			internal void GPHEJHPBGDC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2111630", Offset = "0x2110230", VA = "0x182111630")]
			internal bool APKCDBDCAHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2112680", Offset = "0x2111280", VA = "0x182112680")]
			internal bool EHJGCNGDOJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2111E20", Offset = "0x2110A20", VA = "0x182111E20")]
			internal object CEDLIEBNMCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2111720", Offset = "0x2110320", VA = "0x182111720")]
			internal void BBCCMMHFGKJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2111BE0", Offset = "0x21107E0", VA = "0x182111BE0")]
			internal bool BOOOCLAAJBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x21114F0", Offset = "0x21100F0", VA = "0x1821114F0")]
			internal int AMHIEDOCPCC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2111850", Offset = "0x2110450", VA = "0x182111850")]
			internal void BEADAKPMPAJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x211AEC0", Offset = "0x2119AC0", VA = "0x18211AEC0")]
			internal bool NGANHNEFBLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2112C00", Offset = "0x2111800", VA = "0x182112C00")]
			internal bool FHPDKJGGAID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2112D90", Offset = "0x2111990", VA = "0x182112D90")]
			internal bool FNKOGNNFENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2111680", Offset = "0x2110280", VA = "0x182111680")]
			internal int BAIPMLBFAAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2111900", Offset = "0x2110500", VA = "0x182111900")]
			internal void BEGDHKMLBPF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2111E90", Offset = "0x2110A90", VA = "0x182111E90")]
			internal bool CFKHMOPFBGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x21125D0", Offset = "0x21111D0", VA = "0x1821125D0")]
			internal bool EEPCHMOJPFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2119CC0", Offset = "0x21188C0", VA = "0x182119CC0")]
			internal bool JBCAEFCPEAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x211A800", Offset = "0x2119400", VA = "0x18211A800")]
			internal float LMCIICDEPMF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x211A400", Offset = "0x2119000", VA = "0x18211A400")]
			internal void KLKIHPLHBKP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x21124C0", Offset = "0x21110C0", VA = "0x1821124C0")]
			internal bool DNIBGGEIKIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x211A710", Offset = "0x2119310", VA = "0x18211A710")]
			internal bool LEHDCGMCFGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2111F40", Offset = "0x2110B40", VA = "0x182111F40")]
			internal bool CHJEHMDOGHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2112740", Offset = "0x2111340", VA = "0x182112740")]
			internal float ELBKHOGAAHI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x211B460", Offset = "0x211A060", VA = "0x18211B460")]
			internal void OIJJIEOLFIM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2112F20", Offset = "0x2111B20", VA = "0x182112F20")]
			internal bool GFDIFAILBBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2119830", Offset = "0x2118430", VA = "0x182119830")]
			internal bool HONLONMCCIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x21199A0", Offset = "0x21185A0", VA = "0x1821199A0")]
			internal string IDDPABOBHFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x211AD60", Offset = "0x2119960", VA = "0x18211AD60")]
			internal void NCLAGLGBJEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2119AF0", Offset = "0x21186F0", VA = "0x182119AF0")]
			internal bool IJIIPCLMAHB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2112220", Offset = "0x2110E20", VA = "0x182112220")]
			internal bool DENCEHCPGAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x211B410", Offset = "0x211A010", VA = "0x18211B410")]
			internal bool OIHBOBAMOMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x211A760", Offset = "0x2119360", VA = "0x18211A760")]
			internal bool LJABNIKJHED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2112470", Offset = "0x2111070", VA = "0x182112470")]
			internal string DNBNANPKCMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x211B770", Offset = "0x211A370", VA = "0x18211B770")]
			internal void PIMLKPEAIGL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x211B370", Offset = "0x2119F70", VA = "0x18211B370")]
			internal bool OEOHPEILKFI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x21130D0", Offset = "0x2111CD0", VA = "0x1821130D0")]
			internal bool GJFOAGDHEIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2113030", Offset = "0x2111C30", VA = "0x182113030")]
			internal bool GHMOEGGHEKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x211A0A0", Offset = "0x2118CA0", VA = "0x18211A0A0")]
			internal bool KCFFPNFMLNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x211A4B0", Offset = "0x21190B0", VA = "0x18211A4B0")]
			internal string KNFADBOPBAP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x211AA90", Offset = "0x2119690", VA = "0x18211AA90")]
			internal void MEGPGKNJINJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x211AB50", Offset = "0x2119750", VA = "0x18211AB50")]
			internal bool MHJNKJPGBPD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2119650", Offset = "0x2118250", VA = "0x182119650")]
			internal bool HNHIOHOFFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x21119B0", Offset = "0x21105B0", VA = "0x1821119B0")]
			internal bool BHHNNHIFEEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x21197E0", Offset = "0x21183E0", VA = "0x1821197E0")]
			internal bool HOLFAJLKPGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2113530", Offset = "0x2112130", VA = "0x182113530")]
			internal string HIJIIAIPLKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x211B5B0", Offset = "0x211A1B0", VA = "0x18211B5B0")]
			internal void OLPHPKLIBMO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x21118B0", Offset = "0x21104B0", VA = "0x1821118B0")]
			internal bool BEALMNFBFCM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2119790", Offset = "0x2118390", VA = "0x182119790")]
			internal bool HOEHGMNDLGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x211A250", Offset = "0x2118E50", VA = "0x18211A250")]
			internal bool KKBPBHMFDDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x211BC80", Offset = "0x211A880", VA = "0x18211BC80")]
			internal bool PLHACBJBOCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x21133A0", Offset = "0x2111FA0", VA = "0x1821133A0")]
			internal string GPOJHNKOBAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2119D10", Offset = "0x2118910", VA = "0x182119D10")]
			internal void JCBBHDMAHLO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2112180", Offset = "0x2110D80", VA = "0x182112180")]
			internal bool DBNKNHGCFBH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2111A00", Offset = "0x2110600", VA = "0x182111A00")]
			internal bool BHODKJLKFIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2119E20", Offset = "0x2118A20", VA = "0x182119E20")]
			internal bool JINJJOOIOJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x21196A0", Offset = "0x21182A0", VA = "0x1821196A0")]
			internal bool HNHNCGECOLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2113440", Offset = "0x2112040", VA = "0x182113440")]
			internal string HBAABGALGGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x211A8F0", Offset = "0x21194F0", VA = "0x18211A8F0")]
			internal void LPPOKDGCCDK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2111D80", Offset = "0x2110980", VA = "0x182111D80")]
			internal bool CCIIJCPALPB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2113220", Offset = "0x2111E20", VA = "0x182113220")]
			internal bool GMKIHEKJKJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2112CF0", Offset = "0x21118F0", VA = "0x182112CF0")]
			internal bool FLGJKNJCHBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2112790", Offset = "0x2111390", VA = "0x182112790")]
			internal bool ELICCKOIIKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x21112E0", Offset = "0x210FEE0", VA = "0x1821112E0")]
			internal string AGFKCJMIGNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x21111D0", Offset = "0x210FDD0", VA = "0x1821111D0")]
			internal void ADFPFGPDHLC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2111450", Offset = "0x2110050", VA = "0x182111450")]
			internal bool ALDJILFBNCM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2111D30", Offset = "0x2110930", VA = "0x182111D30")]
			internal bool CBONCDDLIMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2111DD0", Offset = "0x21109D0", VA = "0x182111DD0")]
			internal bool CCMEMDNKCFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x211B6D0", Offset = "0x211A2D0", VA = "0x18211B6D0")]
			internal bool PHOEHLGJLGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x21122C0", Offset = "0x2110EC0", VA = "0x1821122C0")]
			internal string DGHFKOAFNOP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x21113E0", Offset = "0x210FFE0", VA = "0x1821113E0")]
			internal void AJDFKPAPPJL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x211AB00", Offset = "0x2119700", VA = "0x18211AB00")]
			internal bool MFFHONGKDAP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x211B2D0", Offset = "0x2119ED0", VA = "0x18211B2D0")]
			internal bool OAJGODKELBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2111AF0", Offset = "0x21106F0", VA = "0x182111AF0")]
			internal bool BIOLGFAJNPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x21129D0", Offset = "0x21115D0", VA = "0x1821129D0")]
			internal bool FBOMPNGMBID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2113180", Offset = "0x2111D80", VA = "0x182113180")]
			internal string GKFNIDHFLEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2112FC0", Offset = "0x2111BC0", VA = "0x182112FC0")]
			internal void GGEIMEOJCFJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2119F60", Offset = "0x2118B60", VA = "0x182119F60")]
			internal bool JNAKEKOADPO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x211ACB0", Offset = "0x21198B0", VA = "0x18211ACB0")]
			internal bool MNPLGGAPNJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2111B40", Offset = "0x2110740", VA = "0x182111B40")]
			internal bool BKFIOKMCMCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x21121D0", Offset = "0x2110DD0", VA = "0x1821121D0")]
			internal bool DDNPHHBBLEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x211A460", Offset = "0x2119060", VA = "0x18211A460")]
			internal string KMDDEIBIFGD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2112510", Offset = "0x2111110", VA = "0x182112510")]
			internal void DPCIBJFKOOE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2119740", Offset = "0x2118340", VA = "0x182119740")]
			internal bool HNOFKBFGNLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x211BD80", Offset = "0x211A980", VA = "0x18211BD80")]
			internal bool PMPPNHHDGEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2111390", Offset = "0x210FF90", VA = "0x182111390")]
			internal bool AHNANJPGEFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x211B680", Offset = "0x211A280", VA = "0x18211B680")]
			internal string PDPOCJIAFNB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x211A340", Offset = "0x2118F40", VA = "0x18211A340")]
			internal void KLCBMECJIOE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2119C70", Offset = "0x2118870", VA = "0x182119C70")]
			internal bool JANDCAEBBEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2113490", Offset = "0x2112090", VA = "0x182113490")]
			internal bool HDLOLEGDONL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2112ED0", Offset = "0x2111AD0", VA = "0x182112ED0")]
			internal bool GEHPEELKGDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x21135D0", Offset = "0x21121D0", VA = "0x1821135D0")]
			internal string HMCLCDJKOAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x21126D0", Offset = "0x21112D0", VA = "0x1821126D0")]
			internal void EKFBCNJLKEN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x21115E0", Offset = "0x21101E0", VA = "0x1821115E0")]
			internal bool APAADJFBOOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x211B1D0", Offset = "0x2119DD0", VA = "0x18211B1D0")]
			internal bool NLNDCAOMHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x211B220", Offset = "0x2119E20", VA = "0x18211B220")]
			internal bool NOMCHBNNCEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2112A20", Offset = "0x2111620", VA = "0x182112A20")]
			internal string FDEFCCIJOKJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x211A1E0", Offset = "0x2118DE0", VA = "0x18211A1E0")]
			internal void KKBBBIPEKAO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2112F70", Offset = "0x2111B70", VA = "0x182112F70")]
			internal bool GFICFGMGFAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x211ADD0", Offset = "0x21199D0", VA = "0x18211ADD0")]
			internal bool NDGGCBEEBDC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x21196F0", Offset = "0x21182F0", VA = "0x1821196F0")]
			internal float HNODLFPILAE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2111330", Offset = "0x210FF30", VA = "0x182111330")]
			internal void AHCLMPPHDPD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x211A140", Offset = "0x2118D40", VA = "0x18211A140")]
			internal bool KFALICGHKMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2112E80", Offset = "0x2111A80", VA = "0x182112E80")]
			internal bool GAMPBDECIND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x211AE20", Offset = "0x2119A20", VA = "0x18211AE20")]
			internal bool NDMLMIKFDEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2111590", Offset = "0x2110190", VA = "0x182111590")]
			internal int AOBKHOAICAI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x211AC50", Offset = "0x2119850", VA = "0x18211AC50")]
			internal void MLAHLBCALIB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x2113270", Offset = "0x2111E70", VA = "0x182113270")]
			internal bool GNGLPIPENFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x21198E0", Offset = "0x21184E0", VA = "0x1821198E0")]
			internal bool ICDLJCDAODJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x2113580", Offset = "0x2112180", VA = "0x182113580")]
			internal bool HKEONKCBILG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class FANJKKOADLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public BJOBHNHKFIK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public FANJKKOADLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x2123520", Offset = "0x2122120", VA = "0x182123520")]
			internal void EJHLJGLCKEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class IACOIAJFJOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public IACOIAJFJOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2126CD0", Offset = "0x21258D0", VA = "0x182126CD0")]
			internal bool GDIDBGEDDFA(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly EAKLPJHKIMK EIMGMLMJGJI;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x212B020", Offset = "0x2129C20", VA = "0x18212B020")]
		public MBINKPNIHLE(HECAJEGBBHJ FPAIKMADOEB, KFDDBIAEOBD HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x21292E0", Offset = "0x2127EE0", VA = "0x1821292E0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class BFAAFJJJDDD : HPJBMACCDBJ<IJKHIDGMCPM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class GJNEMJFFCNA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006C")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public GJNEMJFFCNA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x214A9B0", Offset = "0x21495B0", VA = "0x18214A9B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public BFAAFJJJDDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GJNEMJFFCNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x213B4C0", Offset = "0x213A0C0", VA = "0x18213B4C0")]
			internal string ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x213B5F0", Offset = "0x213A1F0", VA = "0x18213B5F0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OAHKBLJIFML(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x213B5A0", Offset = "0x213A1A0", VA = "0x18213B5A0")]
			internal int KPABALKIMEH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x213B510", Offset = "0x213A110", VA = "0x18213B510")]
			internal void BPOAFEAIGGC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2134F20", Offset = "0x2133B20", VA = "0x182134F20")]
		public BFAAFJJJDDD(HECAJEGBBHJ FPAIKMADOEB, IJKHIDGMCPM GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2134BD0", Offset = "0x21337D0", VA = "0x182134BD0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class KALOKDPNGDD : HPJBMACCDBJ<NAEAJOLMFKF>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class PGCMIOMHCEK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				public PGCMIOMHCEK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x214ACC0", Offset = "0x21498C0", VA = "0x18214ACC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000070")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public PGCMIOMHCEK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x214B000", Offset = "0x2149C00", VA = "0x18214B000", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public KALOKDPNGDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PGCMIOMHCEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2149C80", Offset = "0x2148880", VA = "0x182149C80")]
			internal string ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x214A1E0", Offset = "0x2148DE0", VA = "0x18214A1E0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OAHKBLJIFML(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x214A070", Offset = "0x2148C70", VA = "0x18214A070")]
			internal int KPABALKIMEH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2149D60", Offset = "0x2148960", VA = "0x182149D60")]
			internal void BPOAFEAIGGC(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2149C30", Offset = "0x2148830", VA = "0x182149C30")]
			internal string ADJJKGEKMEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2149EE0", Offset = "0x2148AE0", VA = "0x182149EE0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DGKGKMEIILK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2149DF0", Offset = "0x21489F0", VA = "0x182149DF0")]
			internal bool CBCOKMGEFCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x214A0C0", Offset = "0x2148CC0", VA = "0x18214A0C0")]
			internal void LGMAIHJAMPE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x214A310", Offset = "0x2148F10", VA = "0x18214A310")]
			internal bool OMMDPOFOIEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2149CD0", Offset = "0x21488D0", VA = "0x182149CD0")]
			internal void AMIGANNAOOD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2149FB0", Offset = "0x2148BB0", VA = "0x182149FB0")]
			internal float FFPKKJBDHDM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x214A150", Offset = "0x2148D50", VA = "0x18214A150")]
			internal void MPKNPMCNPJK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x214A2B0", Offset = "0x2148EB0", VA = "0x18214A2B0")]
			internal int ODFNFFECMFE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x2149E40", Offset = "0x2148A40", VA = "0x182149E40")]
			internal void DGCDELGHFCA(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x214A000", Offset = "0x2148C00", VA = "0x18214A000")]
			internal bool HAFEPFJDMHL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x213DC20", Offset = "0x213C820", VA = "0x18213DC20")]
		public KALOKDPNGDD(HECAJEGBBHJ FPAIKMADOEB, NAEAJOLMFKF HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x213D1D0", Offset = "0x213BDD0", VA = "0x18213D1D0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class PPKDOEMGPHO : HPJBMACCDBJ<NMFLJANJECE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class BKKHODGPOGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public PPKDOEMGPHO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public BKKHODGPOGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2137120", Offset = "0x2135D20", VA = "0x182137120")]
			internal Dictionary<string, LGLIHOABELM> ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x2137360", Offset = "0x2135F60", VA = "0x182137360")]
			internal int OAHKBLJIFML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2137240", Offset = "0x2135E40", VA = "0x182137240")]
			internal void KPABALKIMEH(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x21371C0", Offset = "0x2135DC0", VA = "0x1821371C0")]
			internal bool BPOAFEAIGGC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x214A630", Offset = "0x2149230", VA = "0x18214A630")]
		public PPKDOEMGPHO(HECAJEGBBHJ FPAIKMADOEB, NMFLJANJECE GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x214A360", Offset = "0x2148F60", VA = "0x18214A360", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class IGDKCPMNKMA : HPJBMACCDBJ<KKGIMOCAAEL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class ABBKNBEFHMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public IGDKCPMNKMA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public ABBKNBEFHMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x212EA00", Offset = "0x212D600", VA = "0x18212EA00")]
			internal void ALELIDPNDLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x213BAA0", Offset = "0x213A6A0", VA = "0x18213BAA0")]
		public IGDKCPMNKMA(HECAJEGBBHJ FPAIKMADOEB, KKGIMOCAAEL GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x213B920", Offset = "0x213A520", VA = "0x18213B920", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class MHKNIFPKAOL : ICNGLLNMOID<CANECDFIFFO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FFMKOMMFBFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DJAMKEEPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2141110", Offset = "0x213FD10", VA = "0x182141110", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2F0", Offset = "0x8EDEF0", VA = "0x1808EF2F0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x21410B0", Offset = "0x213FCB0", VA = "0x1821410B0")]
		public MHKNIFPKAOL(HECAJEGBBHJ FPAIKMADOEB, CANECDFIFFO HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class HBCHGDOKNGK : HPJBMACCDBJ<JAJJBOKPCDM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xA2FAA0", Offset = "0xA2E6A0", VA = "0x180A2FAA0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x213B7A0", Offset = "0x213A3A0", VA = "0x18213B7A0")]
		public HBCHGDOKNGK(HECAJEGBBHJ FPAIKMADOEB, JAJJBOKPCDM HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class NDKMBABFGKK : HPJBMACCDBJ<KKCGIODJEMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA70300", Offset = "0xA6EF00", VA = "0x180A70300", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2141600", Offset = "0x2140200", VA = "0x182141600")]
		public NDKMBABFGKK(HECAJEGBBHJ FPAIKMADOEB, KKCGIODJEMC HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "114")]
		protected override bool BALMIKCFILH(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class GKJAMGOCCEB : HPJBMACCDBJ<KIKBFPOBHBD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA69BA0", Offset = "0xA687A0", VA = "0x180A69BA0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool HDOLOEGPHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x213B730", Offset = "0x213A330", VA = "0x18213B730", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool ALMDEAKFPHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x213B6C0", Offset = "0x213A2C0", VA = "0x18213B6C0")]
		public GKJAMGOCCEB(HECAJEGBBHJ FPAIKMADOEB, KIKBFPOBHBD HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class KBIFOFKDBHI : HPJBMACCDBJ<BPMIEOLBBCP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F6D0", VA = "0x180910AD0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool HDOLOEGPHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x213DF50", Offset = "0x213CB50", VA = "0x18213DF50", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool ALMDEAKFPHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x213DEE0", Offset = "0x213CAE0", VA = "0x18213DEE0")]
		public KBIFOFKDBHI(HECAJEGBBHJ FPAIKMADOEB, BPMIEOLBBCP HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class GHGNMJMLMBN : KONKPOEKCJG<CPAHKOKLFPE>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class OKDJKIACAGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public GHGNMJMLMBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OKDJKIACAGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x2149AB0", Offset = "0x21486B0", VA = "0x182149AB0")]
			internal float FEMBENICCFK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x2149B30", Offset = "0x2148730", VA = "0x182149B30")]
			internal void JDOOMBPCDBM(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x213B460", Offset = "0x213A060", VA = "0x18213B460")]
		public GHGNMJMLMBN(HECAJEGBBHJ FPAIKMADOEB, CPAHKOKLFPE GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x213B1E0", Offset = "0x2139DE0", VA = "0x18213B1E0", Slot = "128")]
		protected override void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class OBPHOKCIPKL : HPJBMACCDBJ<NLLFPPEIAII>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class MOHOIKCLCNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public OBPHOKCIPKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public MOHOIKCLCNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2141490", Offset = "0x2140090", VA = "0x182141490")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x21414E0", Offset = "0x21400E0", VA = "0x1821414E0")]
			internal void OAHKBLJIFML(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x21426E0", Offset = "0x21412E0", VA = "0x1821426E0")]
		public OBPHOKCIPKL(HECAJEGBBHJ FPAIKMADOEB, NLLFPPEIAII GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2142430", Offset = "0x2141030", VA = "0x182142430", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class MEPJAINKGCB : HPJBMACCDBJ<IHGAAJKFBDG>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class CHJALBBICOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public MEPJAINKGCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CHJALBBICOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2138A30", Offset = "0x2137630", VA = "0x182138A30")]
			internal object ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2138E80", Offset = "0x2137A80", VA = "0x182138E80")]
			internal bool LGMAIHJAMPE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2138F00", Offset = "0x2137B00", VA = "0x182138F00")]
			internal void OAHKBLJIFML(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2138D20", Offset = "0x2137920", VA = "0x182138D20")]
			internal string KPABALKIMEH(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2138B60", Offset = "0x2137760", VA = "0x182138B60")]
			internal IReadOnlyList<object> BPOAFEAIGGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x21389C0", Offset = "0x21375C0", VA = "0x1821389C0")]
			internal bool ADJJKGEKMEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2138CD0", Offset = "0x21378D0", VA = "0x182138CD0")]
			internal bool DGKGKMEIILK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2138BB0", Offset = "0x21377B0", VA = "0x182138BB0")]
			internal void CBCOKMGEFCO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2141040", Offset = "0x213FC40", VA = "0x182141040")]
		public MEPJAINKGCB(HECAJEGBBHJ FPAIKMADOEB, IHGAAJKFBDG GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2140800", Offset = "0x213F400", VA = "0x182140800", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class DHPIDBFLJEN : FEEBHEJIINI<CPKBOCLMLHC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xC54A60", Offset = "0xC53660", VA = "0x180C54A60", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x21398A0", Offset = "0x21384A0", VA = "0x1821398A0")]
		public DHPIDBFLJEN(HECAJEGBBHJ FPAIKMADOEB, CPKBOCLMLHC HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class OFJIKCACENH : KONKPOEKCJG<IJPNDFDHOJH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class NOKBGGENBAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public OFJIKCACENH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public NOKBGGENBAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x21422A0", Offset = "0x2140EA0", VA = "0x1821422A0")]
			internal int FEMBENICCFK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2142320", Offset = "0x2140F20", VA = "0x182142320")]
			internal void JDOOMBPCDBM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2142AB0", Offset = "0x21416B0", VA = "0x182142AB0")]
		public OFJIKCACENH(HECAJEGBBHJ FPAIKMADOEB, IJPNDFDHOJH GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2142820", Offset = "0x2141420", VA = "0x182142820", Slot = "128")]
		protected override void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class CGMGMPLEIMH : HPJBMACCDBJ<LACEALMHGOK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class GCKMKEKHNBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CGMGMPLEIMH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GCKMKEKHNBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x213AFE0", Offset = "0x2139BE0", VA = "0x18213AFE0")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x213B030", Offset = "0x2139C30", VA = "0x18213B030")]
			internal void OAHKBLJIFML(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2138950", Offset = "0x2137550", VA = "0x182138950")]
		public CGMGMPLEIMH(HECAJEGBBHJ FPAIKMADOEB, LACEALMHGOK GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2138770", Offset = "0x2137370", VA = "0x182138770", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class KBGFIOLNBDO : HPJBMACCDBJ<LKOAICMDNAD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class BEFMMLDOGMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public KBGFIOLNBDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public BEFMMLDOGMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x2134AF0", Offset = "0x21336F0", VA = "0x182134AF0")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x2134B40", Offset = "0x2133740", VA = "0x182134B40")]
			internal void OAHKBLJIFML(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x213DE70", Offset = "0x213CA70", VA = "0x18213DE70")]
		public KBGFIOLNBDO(HECAJEGBBHJ FPAIKMADOEB, LKOAICMDNAD GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x213DC90", Offset = "0x213C890", VA = "0x18213DC90", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class MKHKPKFPJOF : HPJBMACCDBJ<GHCOOAAKGIK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class CJMPOMMDMJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public MKHKPKFPJOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CJMPOMMDMJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2139510", Offset = "0x2138110", VA = "0x182139510")]
			internal int ALELIDPNDLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2139560", Offset = "0x2138160", VA = "0x182139560")]
			internal void OAHKBLJIFML(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2141420", Offset = "0x2140020", VA = "0x182141420")]
		public MKHKPKFPJOF(HECAJEGBBHJ FPAIKMADOEB, GHCOOAAKGIK GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x21411B0", Offset = "0x213FDB0", VA = "0x1821411B0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class MJLFHCDGALN : PBLEGCCFPAI<FHNBAEIBKKM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override HCBKHLMNCPD AELCIBBIEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "128")]
			get
			{
				return default(HCBKHLMNCPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2141150", Offset = "0x213FD50", VA = "0x182141150")]
		public MJLFHCDGALN(HECAJEGBBHJ FPAIKMADOEB, FHNBAEIBKKM GMBKDDMMMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class LKEIKJAGBLI : HPJBMACCDBJ<CABMAJOBDAN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x213AD10", Offset = "0x2139910", VA = "0x18213AD10")]
		public LKEIKJAGBLI(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public abstract class HPJBMACCDBJ<TNode> : OCABIDKCHNK, IDisposable where TNode : notnull, CABMAJOBDAN
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class NNGHBKALAEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public HPJBMACCDBJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public HECAJEGBBHJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public NNGHBKALAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x467ACE0", Offset = "0x46798E0", VA = "0x18467ACE0")]
			internal ANCGECKCCGF DJKGFMMENPJ(GAPPNIAAIMJ portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private struct ILJAHNJBKGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public HPJBMACCDBJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4032F50", Offset = "0x4031B50", VA = "0x184032F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct ANNLBENJABL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public HPJBMACCDBJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public DGFFKHOBAPM? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public OPFDDIEBCBF? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x3F1E780", Offset = "0x3F1D380", VA = "0x183F1E780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x3F1EA20", Offset = "0x3F1D620", VA = "0x183F1EA20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class OKHDPJDDECI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				public OKHDPJDDECI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0x37819F0", Offset = "0x37805F0", VA = "0x1837819F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HPJBMACCDBJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public MOIGKILBFLB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OKHDPJDDECI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			internal string LMKDIHFMAMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			internal void ECKMANLBPLJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x47BFD50", Offset = "0x47BE950", VA = "0x1847BFD50")]
			[AsyncStateMachine(typeof(HPJBMACCDBJ<>.OKHDPJDDECI.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void FPHBONKPFKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class DBIECNGCFFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DBIECNGCFFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x5AB7C10", Offset = "0x5AB6810", VA = "0x185AB7C10")]
			internal bool EAKJPBDKCAG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5AB7CF0", Offset = "0x5AB68F0", VA = "0x185AB7CF0")]
			internal bool JOEHMPMHENB(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct MGLFEEPMPHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public HPJBMACCDBJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x45B30E0", Offset = "0x45B1CE0", VA = "0x1845B30E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x45B3470", Offset = "0x45B2070", VA = "0x1845B3470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly HECAJEGBBHJ LFPGLIEDNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly bool JKIJLJCHAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private LDANOCNENFB<JOGIKJOJMKJ, ANCGECKCCGF> NINBGMJGGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private LDANOCNENFB<JOGIKJOJMKJ, AONEJDLMABH> FOHLBGDEMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private List<Action> DBAHJLMJNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[CompilerGenerated]
		private Action<FANMFDLLPNO<JOGIKJOJMKJ>>? JCBHGGNMJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[CompilerGenerated]
		private Action<FANMFDLLPNO<JOGIKJOJMKJ>, AONEJDLMABH>? FNCLIEEOLCG;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected DCMDDGDMJKM KKKJMICJAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x3F767B0", Offset = "0x3F753B0", VA = "0x183F767B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected MHNMIHKAGCN BNCBDGIOCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3F76880", Offset = "0x3F75480", VA = "0x183F76880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode KEODPDGDDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public DBMOGKNBCFK<IIHAEGFAHBG> DOCPPLFCHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB610", Offset = "0xCDA210", VA = "0x180CDB610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DBMOGKNBCFK<IIHAEGFAHBG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public FANMFDLLPNO<BJFPHMKHJNN> LFCDENPADJL
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3F77820", Offset = "0x3F76420", VA = "0x183F77820", Slot = "6")]
			get
			{
				return default(FANMFDLLPNO<BJFPHMKHJNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object NDBMEFNOAMP
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3ADF200", Offset = "0x3ADDE00", VA = "0x183ADF200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool IGIECMOCHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int KIGNICELNFC
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x3F77480", Offset = "0x3F76080", VA = "0x183F77480", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public BEGECIPCEHP DNCELDEEFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x3F77420", Offset = "0x3F76020", VA = "0x183F77420", Slot = "10")]
			get
			{
				return default(BEGECIPCEHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string MJKCFDCJGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x3F77A20", Offset = "0x3F76620", VA = "0x183F77A20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool ALMDEAKFPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public FANMFDLLPNO<EMDCIKDEAAO> OGIKLMFCEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x90A080", Offset = "0x908C80", VA = "0x18090A080", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(FANMFDLLPNO<EMDCIKDEAAO>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xCDF2B0", Offset = "0xCDDEB0", VA = "0x180CDF2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool HDOLOEGPHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool FFMKOMMFBFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NNFCEAHFOIF CMFHPGKLCLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x94DF40", Offset = "0x94CB40", VA = "0x18094DF40", Slot = "96")]
			get
			{
				return default(NNFCEAHFOIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool PFDFPFJPJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3F77190", Offset = "0x3F75D90", VA = "0x183F77190", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool ACNEPNMBLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x3F771F0", Offset = "0x3F75DF0", VA = "0x183F771F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KAFAJCJALFH
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x3F77250", Offset = "0x3F75E50", VA = "0x183F77250", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int LFHDPEPBNOD
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x3F777D0", Offset = "0x3F763D0", VA = "0x183F777D0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool APBLLDNJIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3F77600", Offset = "0x3F76200", VA = "0x183F77600", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool JPBMNCFOEID
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3F77360", Offset = "0x3F75F60", VA = "0x183F77360", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KNCIBHPLAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3F77300", Offset = "0x3F75F00", VA = "0x183F77300", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool PBPKGAODDNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x90A580", Offset = "0x909180", VA = "0x18090A580", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xCAB930", Offset = "0xCAA530", VA = "0x180CAB930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool JJFJDKEIOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "97")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool JJCIJBPKMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x3F772B0", Offset = "0x3F75EB0", VA = "0x183F772B0", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool LDIOMOOKKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x3F77530", Offset = "0x3F76130", VA = "0x183F77530", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public DGFFKHOBAPM LDMDDCKKDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x3F77710", Offset = "0x3F76310", VA = "0x183F77710", Slot = "28")]
			get
			{
				return default(DGFFKHOBAPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public OPFDDIEBCBF ACHKOFDELKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x3F77770", Offset = "0x3F76370", VA = "0x183F77770", Slot = "30")]
			get
			{
				return default(OPFDDIEBCBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool EHOOFCCOOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual OBJADOGDBGH? LFONJCADCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual GAAMHAIHFFM? JBFGABGJNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<DBMOGKNBCFK<LOCKFIIFIFD>>? HHLLOPAIIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool MPFLNKGMBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x3F773C0", Offset = "0x3F75FC0", VA = "0x183F773C0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public DBMOGKNBCFK<LNEKKJBHBEC> PNDBNHDNPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x3F77650", Offset = "0x3F76250", VA = "0x183F77650", Slot = "62")]
			get
			{
				return default(DBMOGKNBCFK<LNEKKJBHBEC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public FANMFDLLPNO<LNEKKJBHBEC> BBEBNLJJCEL
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x3F774D0", Offset = "0x3F760D0", VA = "0x183F774D0", Slot = "56")]
			get
			{
				return default(FANMFDLLPNO<LNEKKJBHBEC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool OIHJGJGJHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual FANMFDLLPNO<LNEKKJBHBEC>? FCOHCEOCEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DJAMKEEPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool FBADBODIJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x3F77590", Offset = "0x3F76190", VA = "0x183F77590", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x88EAB0", Offset = "0x88D6B0", VA = "0x18088EAB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string IBAEDMIJHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x88E9F0", Offset = "0x88D5F0", VA = "0x18088E9F0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x88EAE0", Offset = "0x88D6E0", VA = "0x18088EAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public FANMFDLLPNO<LOCKFIIFIFD> FCBHHIFPKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3F778A0", Offset = "0x3F764A0", VA = "0x183F778A0", Slot = "63")]
			get
			{
				return default(FANMFDLLPNO<LOCKFIIFIFD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DBMOGKNBCFK<LOCKFIIFIFD> ILGHOFOCBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3F776B0", Offset = "0x3F762B0", VA = "0x183F776B0", Slot = "64")]
			get
			{
				return default(DBMOGKNBCFK<LOCKFIIFIFD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public DBMOGKNBCFK<LOCKFIIFIFD>? EABPKPKIFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3F77900", Offset = "0x3F76500", VA = "0x183F77900", Slot = "120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public AFFDGJJAICK<JOGIKJOJMKJ, AONEJDLMABH> LDEKJKCFKGO
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3F779E0", Offset = "0x3F765E0", VA = "0x183F779E0", Slot = "67")]
			get
			{
				return default(AFFDGJJAICK<JOGIKJOJMKJ, AONEJDLMABH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual FANMFDLLPNO<JOGIKJOJMKJ>? GBBOFNFGBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool EGKICAONNPL
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool KJEEJDKGABF
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AFBGGMHLFIA
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3F74F60", Offset = "0x3F73B60", VA = "0x183F74F60", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3F74380", Offset = "0x3F72F80", VA = "0x183F74380", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CACIMNEDHHG EMDDPKHBPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3F740A0", Offset = "0x3F72CA0", VA = "0x183F740A0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3F76B10", Offset = "0x3F75710", VA = "0x183F76B10", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HMLCHGEMGMM HDPLDACDNLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3F74E00", Offset = "0x3F73A00", VA = "0x183F74E00", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3F74000", Offset = "0x3F72C00", VA = "0x183F74000", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BIEGFGELFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3F76640", Offset = "0x3F75240", VA = "0x183F76640", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x3F74CE0", Offset = "0x3F738E0", VA = "0x183F74CE0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NMELNHMLFAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x3F76710", Offset = "0x3F75310", VA = "0x183F76710", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x3F76450", Offset = "0x3F75050", VA = "0x183F76450", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>, AONEJDLMABH> NIAIIIDGNHE
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3F741D0", Offset = "0x3F72DD0", VA = "0x183F741D0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3F75F10", Offset = "0x3F74B10", VA = "0x183F75F10", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>, AONEJDLMABH> LLEIMPIEFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3F74570", Offset = "0x3F73170", VA = "0x183F74570", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3F74B60", Offset = "0x3F73760", VA = "0x183F74B60", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>> LMNHDBCHIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x3F74C20", Offset = "0x3F73820", VA = "0x183F74C20", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x3F75E50", Offset = "0x3F74A50", VA = "0x183F75E50", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>, FANMFDLLPNO<JOGIKJOJMKJ>> AFFCLOCAMNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x3F73110", Offset = "0x3F71D10", VA = "0x183F73110", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x3F75130", Offset = "0x3F73D30", VA = "0x183F75130", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>, AONEJDLMABH> JEAEMCENFPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x3F73B70", Offset = "0x3F72770", VA = "0x183F73B70", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x3F74D40", Offset = "0x3F73940", VA = "0x183F74D40", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<FANMFDLLPNO<JOGIKJOJMKJ>, FANMFDLLPNO<JOGIKJOJMKJ>> PBFMKNGPEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3F74EA0", Offset = "0x3F73AA0", VA = "0x183F74EA0", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x3F746A0", Offset = "0x3F732A0", VA = "0x183F746A0", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x3F76BB0", Offset = "0x3F757B0", VA = "0x183F76BB0")]
		[CEKOJAIAJNA("Need to handle `Name` better.")]
		[CEKOJAIAJNA("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected HPJBMACCDBJ(HECAJEGBBHJ FPAIKMADOEB, TNode HNCCPGMBLOD, bool FFJKALPLNJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x3F751F0", Offset = "0x3F73DF0", VA = "0x183F751F0", Slot = "89")]
		protected virtual void KMAKNPIEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x3F732E0", Offset = "0x3F71EE0", VA = "0x183F732E0", Slot = "90")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3F722F0", Offset = "0x3F70EF0", VA = "0x183F722F0", Slot = "9")]
		[AsyncStateMachine(typeof(HPJBMACCDBJ<>.ILJAHNJBKGN))]
		public void APBBBGKHKNK(int IMNDLJGFHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3F76810", Offset = "0x3F75410", VA = "0x183F76810")]
		public bool OHHIBMKPHEF([In] DGFFKHOBAPM CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3F74630", Offset = "0x3F73230", VA = "0x183F74630")]
		public bool HPPDLBLPIGN([In] OPFDDIEBCBF CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3F76970", Offset = "0x3F75570", VA = "0x183F76970", Slot = "32")]
		public void PJDEDPIMCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3F764F0", Offset = "0x3F750F0", VA = "0x183F764F0", Slot = "33")]
		[AsyncStateMachine(typeof(HPJBMACCDBJ<>.ANNLBENJABL))]
		public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> NMCGAAMKFHP(DGFFKHOBAPM? APNDNNBECGB, OPFDDIEBCBF? NDNBHPBJOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "99")]
		public virtual void LGAOIFODIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "100")]
		public virtual void PCDPOFGCHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "101")]
		public virtual void IHNEIHKKKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EF0", Offset = "0x8EFAF0", VA = "0x1808F0EF0")]
		protected void LACENJLILFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x948C50", Offset = "0x947850", VA = "0x180948C50")]
		protected void PIEBPPKPLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2353FE0", Offset = "0x2352BE0", VA = "0x182353FE0")]
		private void DPNNNDGPFKP([In] OPFDDIEBCBF EAGKGJHHIJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3F76230", Offset = "0x3F74E30", VA = "0x183F76230", Slot = "102")]
		public virtual Task<OAMIPODNNBO<FANMFDLLPNO<JOGIKJOJMKJ>, BDMFJEIOIAD>> MNJEIMBOHBK(string GMBAACDNNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3F72220", Offset = "0x3F70E20", VA = "0x183F72220", Slot = "103")]
		public virtual Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> AOGJNGCJGFK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "104")]
		public virtual void JDJHAKGNCJH(FANMFDLLPNO<JOGIKJOJMKJ> MDNMDBDHDKP, FANMFDLLPNO<JOGIKJOJMKJ> JCHHMKBBDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x3F729B0", Offset = "0x3F715B0", VA = "0x183F729B0", Slot = "105")]
		public virtual IEnumerable<AHAMAEENKGG> CHFMNCGMCOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x3F74140", Offset = "0x3F72D40", VA = "0x183F74140", Slot = "106")]
		public OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD> GOJKHEMAPBE(string PILJEHNPPCJ)
		{
			return default(OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3F76300", Offset = "0x3F74F00", VA = "0x183F76300", Slot = "47")]
		public bool NEJKGNPIHPC([Out] Guid BFAFGEHJBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3F72A40", Offset = "0x3F71640", VA = "0x183F72A40")]
		public bool CJBGENPGDJK([In] Guid JHHAGEEOAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "107")]
		public virtual void OMNFNMJPOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "108")]
		public virtual void BCHLEKNLHOK(bool OAOFHOGEGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "109")]
		public virtual LDNFEEOEBFL DIBGGBAHOBM([In] OPFODFELMPE BFAPLBPKPCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x3F75FD0", Offset = "0x3F74BD0", VA = "0x183F75FD0")]
		protected void MBEJLBOBHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3F723A0", Offset = "0x3F70FA0", VA = "0x183F723A0", Slot = "114")]
		protected virtual bool BALMIKCFILH(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "115")]
		protected virtual bool GPCHNCEJAJI(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected virtual void AEKGHJJNKJO(MOIGKILBFLB OLAGFODAIDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3F74760", Offset = "0x3F73360", VA = "0x183F74760")]
		protected void IFBIMJJNKHE(MOIGKILBFLB NPGCDKAEFPP, Func<string> LEIIIMHBAGH, Action<string> GOGMBGAGKMK, string OEKKIAGCDEC, string AKBJGJFFBHO, string ECMKCLMOHMC, NJNECIOKDOF LGLFJOMBEPI, OPDFANPBHPF MJHLHPOKCFL, Func<string, bool> ICAFAJBOHCM, string HPNFCOLAODI, Func<string, bool> PPMHIJEKCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3F72600", Offset = "0x3F71200", VA = "0x183F72600")]
		protected void BKEHNMCBHJD(MOIGKILBFLB NPGCDKAEFPP, Func<string> LEIIIMHBAGH, Action<string> GOGMBGAGKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3F723E0", Offset = "0x3F70FE0", VA = "0x183F723E0", Slot = "123")]
		protected virtual void BCLDBOOAONL(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3F72070", Offset = "0x3F70C70", VA = "0x183F72070", Slot = "82")]
		public void AHMJNGEFDLA(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3F74290", Offset = "0x3F72E90", VA = "0x183F74290", Slot = "83")]
		public IKICHIOGDGB HFCMGDELBHH()
		{
			return default(IKICHIOGDGB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "126")]
		public virtual bool AJGFPIPCIBK(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1647D60", Offset = "0x1646960", VA = "0x181647D60")]
		private void EDDNBLBIGHM([In] DGFFKHOBAPM GKJAMFFKDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3F74420", Offset = "0x3F73020", VA = "0x183F74420")]
		private void HKONOHABPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3F75910", Offset = "0x3F74510", VA = "0x183F75910")]
		private void LGFIEHEKJNM(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, GAPPNIAAIMJ PDFHKBHONLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE00", Offset = "0xA49A00", VA = "0x180A4AE00")]
		private void JDKEIKKMGFI(FANMFDLLPNO<JOGIKJOJMKJ> MJDOIIBKEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x3F75000", Offset = "0x3F73C00", VA = "0x183F75000")]
		private void KJCIGDJDMBK(FANMFDLLPNO<JOGIKJOJMKJ> MJDOIIBKEKN, GAPPNIAAIMJ PLDLGHGLIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x3F73C30", Offset = "0x3F72830", VA = "0x183F73C30")]
		private void FKOGNDFBHBH(FANMFDLLPNO<JOGIKJOJMKJ> MDNMDBDHDKP, FANMFDLLPNO<JOGIKJOJMKJ> JCHHMKBBDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA49E10", Offset = "0xA48A10", VA = "0x180A49E10")]
		private void PDEOFBHPLFO(FANMFDLLPNO<JOGIKJOJMKJ> MDNMDBDHDKP, FANMFDLLPNO<JOGIKJOJMKJ> JCHHMKBBDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3F73FE0", Offset = "0x3F72BE0", VA = "0x183F73FE0")]
		private void GAHJPPIBADH(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3F72D00", Offset = "0x3F71900", VA = "0x183F72D00")]
		private void CKALGGOOPFN(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, GAPPNIAAIMJ PDFHKBHONLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3F72590", Offset = "0x3F71190", VA = "0x183F72590")]
		private void BDMOGKKGICF(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, GAPPNIAAIMJ PLDLGHGLIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3F72100", Offset = "0x3F70D00", VA = "0x183F72100", Slot = "127")]
		[AsyncStateMachine(typeof(HPJBMACCDBJ<>.MGLFEEPMPHL))]
		public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> AKBGHHFJCGO(string PILJEHNPPCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3F761C0", Offset = "0x3F74DC0", VA = "0x183F761C0", Slot = "54")]
		private void MIPFDJFKCEI(object JGKJJDOADMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x3F731D0", Offset = "0x3F71DD0", VA = "0x183F731D0", Slot = "55")]
		private void DGMFELBELAI(object JGKJJDOADMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3F720C0", Offset = "0x3F70CC0", VA = "0x183F720C0", Slot = "29")]
		private bool AIIFDDNENHE([In] DGFFKHOBAPM CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3F72930", Offset = "0x3F71530", VA = "0x183F72930", Slot = "31")]
		private bool CCDBDPFIPHK([In] OPFDDIEBCBF CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x3F728F0", Offset = "0x3F714F0", VA = "0x183F728F0", Slot = "48")]
		private bool BPLCAAMBEPO([In] Guid JHHAGEEOAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3F72970", Offset = "0x3F71570", VA = "0x183F72970")]
		[CompilerGenerated]
		private string CGIPDLBGJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x3F73240", Offset = "0x3F71E40", VA = "0x183F73240")]
		[CompilerGenerated]
		private void DKJKCIDEBDA(string GMBAACDNNFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class OOFLABFLGJB : FEEBHEJIINI<IFBCIKGKIHG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1131F30", Offset = "0x1130B30", VA = "0x181131F30", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2149BD0", Offset = "0x21487D0", VA = "0x182149BD0")]
		public OOFLABFLGJB(HECAJEGBBHJ FPAIKMADOEB, IFBCIKGKIHG HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class JBAGOCBHIAJ : ICNGLLNMOID<DCIDGLKMOHD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x213C290", Offset = "0x213AE90", VA = "0x18213C290")]
		public JBAGOCBHIAJ(HECAJEGBBHJ FPAIKMADOEB, DCIDGLKMOHD HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public abstract class PBLEGCCFPAI<T> : HPJBMACCDBJ<T> where T : notnull, HLEIJLFJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class OCKOFOCEFDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyList<KeyValuePair<string, LGLIHOABELM>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public PBLEGCCFPAI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public HCBKHLMNCPD clipType;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OCKOFOCEFDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			internal IReadOnlyList<KeyValuePair<string, LGLIHOABELM>> ALELIDPNDLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4799560", Offset = "0x4798160", VA = "0x184799560")]
			internal int OAHKBLJIFML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4799280", Offset = "0x4797E80", VA = "0x184799280")]
			internal void KPABALKIMEH(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4799040", Offset = "0x4797C40", VA = "0x184799040")]
			internal void BPOAFEAIGGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4798E30", Offset = "0x4797A30", VA = "0x184798E30")]
			internal void ADJJKGEKMEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x47991A0", Offset = "0x4797DA0", VA = "0x1847991A0")]
			internal bool DGKGKMEIILK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4799090", Offset = "0x4797C90", VA = "0x184799090")]
			internal void CBCOKMGEFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x47991A0", Offset = "0x4797DA0", VA = "0x1847991A0")]
			internal bool LGMAIHJAMPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4799710", Offset = "0x4798310", VA = "0x184799710")]
			internal float OMMDPOFOIEI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4798F80", Offset = "0x4797B80", VA = "0x184798F80")]
			internal void AMIGANNAOOD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4799230", Offset = "0x4797E30", VA = "0x184799230")]
			internal float FFPKKJBDHDM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x47994A0", Offset = "0x47980A0", VA = "0x1847994A0")]
			internal void MPKNPMCNPJK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x47996C0", Offset = "0x47982C0", VA = "0x1847996C0")]
			internal float ODFNFFECMFE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x47990E0", Offset = "0x4797CE0", VA = "0x1847990E0")]
			internal void DGCDELGHFCA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xA67760", Offset = "0xA66360", VA = "0x180A67760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public abstract HCBKHLMNCPD AELCIBBIEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(Slot = "128")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F390", Offset = "0x3F3DF90", VA = "0x183F3F390")]
		public PBLEGCCFPAI(HECAJEGBBHJ FPAIKMADOEB, T HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x487D1F0", Offset = "0x487BDF0", VA = "0x18487D1F0", Slot = "122")]
		protected sealed override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class OAGOPLCNDBJ : HPJBMACCDBJ<DAPDAFPKPBE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xACA0B0", Offset = "0xAC8CB0", VA = "0x180ACA0B0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x21423C0", Offset = "0x2140FC0", VA = "0x1821423C0")]
		public OAGOPLCNDBJ(HECAJEGBBHJ FPAIKMADOEB, DAPDAFPKPBE HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JKPGKNALKBI : HPJBMACCDBJ<AEGDACHFEDC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class FMGCBIGODEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public JKPGKNALKBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public FMGCBIGODEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x213AE10", Offset = "0x2139A10", VA = "0x18213AE10")]
			internal int OAHKBLJIFML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x213AD80", Offset = "0x2139980", VA = "0x18213AD80")]
			internal void KPABALKIMEH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static Dictionary<string, LGLIHOABELM>? ENNAGJBAFKA;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x213CD60", Offset = "0x213B960", VA = "0x18213CD60")]
		public JKPGKNALKBI(HECAJEGBBHJ FPAIKMADOEB, AEGDACHFEDC HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x213C9F0", Offset = "0x213B5F0", VA = "0x18213C9F0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class FCIJCDPHAOF : PBLEGCCFPAI<MNDFOILIEKK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override HCBKHLMNCPD AELCIBBIEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "128")]
			get
			{
				return default(HCBKHLMNCPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x213A400", Offset = "0x2139000", VA = "0x18213A400")]
		public FCIJCDPHAOF(HECAJEGBBHJ FPAIKMADOEB, MNDFOILIEKK GMBKDDMMMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private sealed class FIDBKDKAHLL : ICNGLLNMOID<OPJGHAJKGMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x213A8B0", Offset = "0x21394B0", VA = "0x18213A8B0")]
		public FIDBKDKAHLL(HECAJEGBBHJ FPAIKMADOEB, OPJGHAJKGMC HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class LJMLHKNKGMM : ICNGLLNMOID<MNPIHDPPFME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x213FE80", Offset = "0x213EA80", VA = "0x18213FE80")]
		public LJMLHKNKGMM(HECAJEGBBHJ FPAIKMADOEB, MNPIHDPPFME HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class JBIFNHFFGMK : KONKPOEKCJG<BBMMMHGKMAG>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class OCMJNLKNJOK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public OCMJNLKNJOK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x214A6A0", Offset = "0x21492A0", VA = "0x18214A6A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public JBIFNHFFGMK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OCMJNLKNJOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2142750", Offset = "0x2141350", VA = "0x182142750")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void FEMBENICCFK(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x213C5D0", Offset = "0x213B1D0", VA = "0x18213C5D0")]
		public JBIFNHFFGMK(HECAJEGBBHJ FPAIKMADOEB, BBMMMHGKMAG GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x213C2F0", Offset = "0x213AEF0", VA = "0x18213C2F0", Slot = "128")]
		protected override void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class BNPGJGGNAFL : PBLEGCCFPAI<NEABLHLGHBE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override HCBKHLMNCPD AELCIBBIEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xA69BA0", Offset = "0xA687A0", VA = "0x180A69BA0", Slot = "128")]
			get
			{
				return default(HCBKHLMNCPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2137ED0", Offset = "0x2136AD0", VA = "0x182137ED0")]
		public BNPGJGGNAFL(HECAJEGBBHJ FPAIKMADOEB, NEABLHLGHBE GMBKDDMMMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class BOPNFGFFLPD : HPJBMACCDBJ<LADEKLJMEIL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xAE1180", Offset = "0xADFD80", VA = "0x180AE1180", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2138400", Offset = "0x2137000", VA = "0x182138400")]
		public BOPNFGFFLPD(HECAJEGBBHJ FPAIKMADOEB, LADEKLJMEIL HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class MEEKBPNHDAP : HPJBMACCDBJ<IKFAGMGLFJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override bool HDOLOEGPHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected sealed override bool ALMDEAKFPHE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2140790", Offset = "0x213F390", VA = "0x182140790")]
		public MEEKBPNHDAP(HECAJEGBBHJ FPAIKMADOEB, IKFAGMGLFJJ HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x21403C0", Offset = "0x213EFC0", VA = "0x1821403C0", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x21406F0", Offset = "0x213F2F0", VA = "0x1821406F0")]
		private int AIKOJJLBLDM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2140730", Offset = "0x213F330", VA = "0x182140730")]
		private void HDEDLAOLJBH(int DIBAENLMLKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class FMEPEIEBJFO : LKEIKJAGBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x213AD10", Offset = "0x2139910", VA = "0x18213AD10")]
		public FMEPEIEBJFO(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class HCAMMPILJBP : KONKPOEKCJG<DGPJOCOJJKP>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x213B810", Offset = "0x213A410", VA = "0x18213B810")]
		public HCAMMPILJBP(HECAJEGBBHJ FPAIKMADOEB, DGPJOCOJJKP HNCCPGMBLOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public abstract class KONKPOEKCJG<TVariableNode> : HPJBMACCDBJ<TVariableNode> where TVariableNode : notnull, DGPJOCOJJKP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class HOCEPKKJHND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public KONKPOEKCJG<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public HOCEPKKJHND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x3F608B0", Offset = "0x3F5F4B0", VA = "0x183F608B0")]
			internal bool ALELIDPNDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x3F60A30", Offset = "0x3F5F630", VA = "0x183F60A30")]
			internal void OAHKBLJIFML(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F609D0", Offset = "0x3F5F5D0", VA = "0x183F609D0")]
			internal bool KPABALKIMEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x3F60910", Offset = "0x3F5F510", VA = "0x183F60910")]
			internal void BPOAFEAIGGC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x3F60800", Offset = "0x3F5F400", VA = "0x183F60800")]
			internal bool ADJJKGEKMEG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class CHHFNJCCHDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public MHNMIHKAGCN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public KONKPOEKCJG<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CHHFNJCCHDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x55D27E0", Offset = "0x55D13E0", VA = "0x1855D27E0")]
			internal void FEMBENICCFK(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NodeVisualizationKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xC459F0", Offset = "0xC445F0", VA = "0x180C459F0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NNFCEAHFOIF CMFHPGKLCLD
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x42DFDB0", Offset = "0x42DE9B0", VA = "0x1842DFDB0", Slot = "96")]
			get
			{
				return default(NNFCEAHFOIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x42DFC10", Offset = "0x42DE810", VA = "0x1842DFC10")]
		protected KONKPOEKCJG(HECAJEGBBHJ FPAIKMADOEB, TVariableNode HNCCPGMBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x42DF610", Offset = "0x42DE210", VA = "0x1842DF610", Slot = "90")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x42DF180", Offset = "0x42DDD80", VA = "0x1842DF180", Slot = "122")]
		protected override void AEKGHJJNKJO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x42DF790", Offset = "0x42DE390", VA = "0x1842DF790", Slot = "128")]
		protected virtual void KJANECCKDOO(MOIGKILBFLB NPGCDKAEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x42DFB20", Offset = "0x42DE720", VA = "0x1842DFB20", Slot = "107")]
		public override void OMNFNMJPOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2121120", Offset = "0x211FD20", VA = "0x182121120")]
	public static OCABIDKCHNK LMDPPDEOAIA(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class OHAEKOAEENJ : BHJNOBCJGHI, IKBNADFOJLB, KGHMAIKBCDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FANMFDLLPNO<MKNPBKPFDPA> LGIJKFAKKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xB6DC10", Offset = "0xB6C810", VA = "0x180B6DC10", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FANMFDLLPNO<MKNPBKPFDPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public FANMFDLLPNO<NGICMBDBBIC> FJMEABFLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x13DE460", Offset = "0x13DD060", VA = "0x1813DE460", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FANMFDLLPNO<NGICMBDBBIC>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2142B10", Offset = "0x2141710", VA = "0x182142B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FANMFDLLPNO<JCAEKHBPEKE> IAPDPIMOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FCF40", Offset = "0x8FBB40", VA = "0x1808FCF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public override FANMFDLLPNO<EJJLEGLDJOC> BCLGBAEMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2142B20", Offset = "0x2141720", VA = "0x182142B20", Slot = "20")]
		get
		{
			return default(FANMFDLLPNO<EJJLEGLDJOC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2142EC0", Offset = "0x2141AC0", VA = "0x182142EC0")]
	private OHAEKOAEENJ(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD, EAFLBCMLHBH CHADALFBGHN, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NGICMBDBBIC> LIBLJKEMGBK, FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF, bool BMEFHFPGGLM, string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2142B70", Offset = "0x2141770", VA = "0x182142B70")]
	public static OHAEKOAEENJ LMDPPDEOAIA(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD, EAFLBCMLHBH AMGNCIGKGAH, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF, FANMFDLLPNO<NGICMBDBBIC> LIBLJKEMGBK, bool BMEFHFPGGLM, bool FFJKALPLNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2142B10", Offset = "0x2141710", VA = "0x182142B10")]
	internal void KICHDHPDABA(FANMFDLLPNO<NGICMBDBBIC> CABLCDOIFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public abstract class BHJNOBCJGHI : KGHMAIKBCDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private struct IEGKGDACHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private GCLCGAPIDIH? DPDGECNDNAO;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x213B870", Offset = "0x213A470", VA = "0x18213B870")]
		public void ANKOMBFBDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x213B880", Offset = "0x213A480", VA = "0x18213B880")]
		public GCLCGAPIDIH PJELIBHFCFE(BHJNOBCJGHI AAIEPBDDNGP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	protected readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	protected readonly CABMAJOBDAN IKBOLEHIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private IEGKGDACHHC KDKAPMGIGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly NGDOHOJHNHC FHEGCLKCMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly List<LLODBMOOPKN> HHIDFCKGHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly List<GKGKOIIPMLE> EMOMHKKBNBK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	[CEKOJAIAJNA("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> JHLMCCGIOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2135600", Offset = "0x2134200", VA = "0x182135600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DisplayKind PFFOPPLHOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896B00", VA = "0x180897F00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FANMFDLLPNO<LNEKKJBHBEC> BBEBNLJJCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2135E30", Offset = "0x2134A30", VA = "0x182135E30", Slot = "6")]
		get
		{
			return default(FANMFDLLPNO<LNEKKJBHBEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DBMOGKNBCFK<LNEKKJBHBEC> PNDBNHDNPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2135E60", Offset = "0x2134A60", VA = "0x182135E60", Slot = "7")]
		get
		{
			return default(DBMOGKNBCFK<LNEKKJBHBEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FNKIFJDBEEJ BCGPJEFDGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1EDD0F0", Offset = "0x1EDBCF0", VA = "0x181EDD0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HMIIHCFLPLL JBFBKOFLPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2135140", Offset = "0x2133D40", VA = "0x182135140", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	protected GCLCGAPIDIH JAIKNEJCMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2135140", Offset = "0x2133D40", VA = "0x182135140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public PortImage EGAONKLKOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2135470", Offset = "0x2134070", VA = "0x182135470", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x88C4B0", Offset = "0x88B0B0", VA = "0x18088C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public DBMOGKNBCFK<LOCKFIIFIFD> ILGHOFOCBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2135450", Offset = "0x2134050", VA = "0x182135450", Slot = "9")]
		get
		{
			return default(DBMOGKNBCFK<LOCKFIIFIFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FANMFDLLPNO<JOGIKJOJMKJ> FDKFIMDBHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xC3A1B0", Offset = "0xC38DB0", VA = "0x180C3A1B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(FANMFDLLPNO<JOGIKJOJMKJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1085C90", Offset = "0x1084890", VA = "0x181085C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract FANMFDLLPNO<EJJLEGLDJOC> BCLGBAEMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2136340", Offset = "0x2134F40", VA = "0x182136340")]
	protected BHJNOBCJGHI(HECAJEGBBHJ FPAIKMADOEB, CABMAJOBDAN HNCCPGMBLOD, NGDOHOJHNHC APMPPPPEKJK, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, bool BMEFHFPGGLM, string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2136040", Offset = "0x2134C40", VA = "0x182136040", Slot = "21")]
	protected virtual void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2135240", Offset = "0x2133E40", VA = "0x182135240", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2135390", Offset = "0x2133F90", VA = "0x182135390", Slot = "14")]
	public void ECEACGIKMMC(LLODBMOOPKN GBKJOHPDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2135740", Offset = "0x2134340", VA = "0x182135740", Slot = "15")]
	public void IKGKHNPBKIG(GKGKOIIPMLE GBKJOHPDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x21357A0", Offset = "0x21343A0", VA = "0x1821357A0", Slot = "16")]
	public void IPEDELFDNLK(JDKGNIODLPD NFIJBNCIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x21353F0", Offset = "0x2133FF0", VA = "0x1821353F0", Slot = "23")]
	protected virtual void FCFMCCGLOKB(JDKGNIODLPD NFIJBNCIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x21361B0", Offset = "0x2134DB0", VA = "0x1821361B0")]
	private void PGMPGAEMNAB(bool AEBBBFCJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2134F90", Offset = "0x2133B90", VA = "0x182134F90")]
	private void BIJNFPEBCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2135E90", Offset = "0x2134A90", VA = "0x182135E90")]
	private void KJNODBAEKBG([In] COLGLLHHIJB CNDDJPNJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x21351E0", Offset = "0x2133DE0", VA = "0x1821351E0", Slot = "17")]
	public void BNIOFGGBDIP(LLODBMOOPKN GBKJOHPDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x21355A0", Offset = "0x21341A0", VA = "0x1821355A0", Slot = "18")]
	public void FNAFNDDAECP(GKGKOIIPMLE GBKJOHPDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x88C4B0", Offset = "0x88B0B0", VA = "0x18088C4B0")]
	internal void CBPAEPLNNBE(string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2136190", Offset = "0x2134D90", VA = "0x182136190")]
	internal void OGKEKPLNMEB(IBGCMAIHCJF DDNPAGAAIOD, FNKIFJDBEEJ FIFJJNIIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x1085C90", Offset = "0x1084890", VA = "0x181085C90")]
	internal void KPNNPOODNCB(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class ANCGECKCCGF : AONEJDLMABH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class GEHBLFDOKAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public HECAJEGBBHJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public CABMAJOBDAN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GEHBLFDOKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x213B150", Offset = "0x2139D50", VA = "0x18213B150")]
		internal CACBJMGICIJ KJPMKCJLMOI((int PortDescIndex, int PortIndex, FFFPAEDNLOF InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x213B0C0", Offset = "0x2139CC0", VA = "0x18213B0C0")]
		internal OHAEKOAEENJ GDBHBBLMFPM(EAFLBCMLHBH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BOKLNAFLLNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2137F30", Offset = "0x2136B30", VA = "0x182137F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2138390", Offset = "0x2136F90", VA = "0x182138390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct IIGAHNPBCNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public FANMFDLLPNO<CHEBACDPPKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x213BB10", Offset = "0x213A710", VA = "0x18213BB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x213BE60", Offset = "0x213AA60", VA = "0x18213BE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct CJLBCCDADGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FANMFDLLPNO<JCAEKHBPEKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2139150", Offset = "0x2137D50", VA = "0x182139150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x21394A0", Offset = "0x21380A0", VA = "0x1821394A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DHPPDEACAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public FANMFDLLPNO<CHEBACDPPKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public FANMFDLLPNO<CHEBACDPPKC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2139900", Offset = "0x2138500", VA = "0x182139900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2139C50", Offset = "0x2138850", VA = "0x182139C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IJCBLEEGBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public FANMFDLLPNO<JCAEKHBPEKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public FANMFDLLPNO<JCAEKHBPEKE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x213BED0", Offset = "0x213AAD0", VA = "0x18213BED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x213C220", Offset = "0x213AE20", VA = "0x18213C220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct LMJKDEFDLPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x213FEE0", Offset = "0x213EAE0", VA = "0x18213FEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2140350", Offset = "0x213EF50", VA = "0x182140350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NLLCDNNIJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2141EE0", Offset = "0x2140AE0", VA = "0x182141EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2142230", Offset = "0x2140E30", VA = "0x182142230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct NGMECKGKAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public FANMFDLLPNO<CHEBACDPPKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2141670", Offset = "0x2140270", VA = "0x182141670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x21419C0", Offset = "0x21405C0", VA = "0x1821419C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct JGBJIGFGCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public FANMFDLLPNO<JCAEKHBPEKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x213C630", Offset = "0x213B230", VA = "0x18213C630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x213C980", Offset = "0x213B580", VA = "0x18213C980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FJHMGOADEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public CCHIIJMLNME type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public FANMFDLLPNO<CHEBACDPPKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x213A910", Offset = "0x2139510", VA = "0x18213A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x213ACA0", Offset = "0x21398A0", VA = "0x18213ACA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JOCPFPGMBDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public ANCGECKCCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public CCHIIJMLNME type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public FANMFDLLPNO<JCAEKHBPEKE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private EJJBJAKHFCE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x213CDD0", Offset = "0x213B9D0", VA = "0x18213CDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x213D160", Offset = "0x213BD60", VA = "0x18213D160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool MDFHILADKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly bool FOCDNIEGPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private AFFDGJJAICK<NDAEOGCNEDJ, CACBJMGICIJ> FAKDAFAEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private AFFDGJJAICK<NDAEOGCNEDJ, HPBLGKLMNBF> OGOOGHDOMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly CABMAJOBDAN IKBOLEHIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private AFFDGJJAICK<NGICMBDBBIC, OHAEKOAEENJ> KAAFCMPLFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private AFFDGJJAICK<NGICMBDBBIC, IKBNADFOJLB> MLJFFHEAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private string? ALMFANNDOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly GAPPNIAAIMJ HKIPIFJBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private FANMFDLLPNO<JOGIKJOJMKJ> KGFCIDGCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly bool JKIJLJCHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? PPMGDOFKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action? FCMOPAAACIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	[CompilerGenerated]
	private Action<FANMFDLLPNO<NDAEOGCNEDJ>>? AMFCGGGKBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private Action<FANMFDLLPNO<NGICMBDBBIC>>? JOHGBCDJKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private AONEJDLMABH.LKGBDGAAAFC? DJHPBCACDJG;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OJKDMKILNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2132F50", Offset = "0x2131B50", VA = "0x182132F50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DNPEELAACCC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x212ECC0", Offset = "0x212D8C0", VA = "0x18212ECC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool FBDIJPHANGG
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x212EC00", Offset = "0x212D800", VA = "0x18212EC00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public DBMOGKNBCFK<LNEKKJBHBEC> PNDBNHDNPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x21318A0", Offset = "0x21304A0", VA = "0x1821318A0", Slot = "7")]
		get
		{
			return default(DBMOGKNBCFK<LNEKKJBHBEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool ABCDFBIIAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2130090", Offset = "0x212EC90", VA = "0x182130090", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public AFFDGJJAICK<NDAEOGCNEDJ, HPBLGKLMNBF> EHJEHJKOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10", Slot = "9")]
		get
		{
			return default(AFFDGJJAICK<NDAEOGCNEDJ, HPBLGKLMNBF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2130400", Offset = "0x212F000", VA = "0x182130400", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DBMOGKNBCFK<LOCKFIIFIFD> ILGHOFOCBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2130430", Offset = "0x212F030", VA = "0x182130430", Slot = "11")]
		get
		{
			return default(DBMOGKNBCFK<LOCKFIIFIFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public AFFDGJJAICK<NGICMBDBBIC, IKBNADFOJLB> KALPBAEGEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620", Slot = "12")]
		get
		{
			return default(AFFDGJJAICK<NGICMBDBBIC, IKBNADFOJLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public FANMFDLLPNO<JOGIKJOJMKJ> FDKFIMDBHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8FDF20", Offset = "0x8FCB20", VA = "0x1808FDF20", Slot = "13")]
		get
		{
			return default(FANMFDLLPNO<JOGIKJOJMKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GKANIDNCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x21315D0", Offset = "0x21301D0", VA = "0x1821315D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2133D60", Offset = "0x2132960", VA = "0x182133D60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action ILOOBLNNFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x21313A0", Offset = "0x212FFA0", VA = "0x1821313A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2133960", Offset = "0x2132560", VA = "0x182133960", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<FANMFDLLPNO<NDAEOGCNEDJ>, FANMFDLLPNO<NDAEOGCNEDJ>> EOABDEPLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x212EDC0", Offset = "0x212D9C0", VA = "0x18212EDC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2133AD0", Offset = "0x21326D0", VA = "0x182133AD0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<FANMFDLLPNO<NDAEOGCNEDJ>, FANMFDLLPNO<NDAEOGCNEDJ>> HKOHNJDPPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x212EF40", Offset = "0x212DB40", VA = "0x18212EF40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2134420", Offset = "0x2133020", VA = "0x182134420", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<FANMFDLLPNO<NGICMBDBBIC>, FANMFDLLPNO<NGICMBDBBIC>> MIBNFOHEECG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2133010", Offset = "0x2131C10", VA = "0x182133010", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x21312E0", Offset = "0x212FEE0", VA = "0x1821312E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FANMFDLLPNO<NGICMBDBBIC>, FANMFDLLPNO<NGICMBDBBIC>> OAEDCIKKBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2133CA0", Offset = "0x21328A0", VA = "0x182133CA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2130230", Offset = "0x212EE30", VA = "0x182130230", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FANMFDLLPNO<NDAEOGCNEDJ>, HPBLGKLMNBF> GEALIKMOIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2131450", Offset = "0x2130050", VA = "0x182131450", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2132580", Offset = "0x2131180", VA = "0x182132580", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FANMFDLLPNO<NDAEOGCNEDJ>> AKEADCKOKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2131510", Offset = "0x2130110", VA = "0x182131510", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2133A10", Offset = "0x2132610", VA = "0x182133A10", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FANMFDLLPNO<NDAEOGCNEDJ>, HPBLGKLMNBF> BJPNCOHNFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x21330D0", Offset = "0x2131CD0", VA = "0x1821330D0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x212ED00", Offset = "0x212D900", VA = "0x18212ED00", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FANMFDLLPNO<NGICMBDBBIC>, IKBNADFOJLB> LIPIPIFECHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x212EE80", Offset = "0x212DA80", VA = "0x18212EE80", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2134360", Offset = "0x2132F60", VA = "0x182134360", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FANMFDLLPNO<NGICMBDBBIC>> BICJFNJMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2130A10", Offset = "0x212F610", VA = "0x182130A10", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x21338A0", Offset = "0x21324A0", VA = "0x1821338A0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FANMFDLLPNO<NGICMBDBBIC>, IKBNADFOJLB> FLMNBDFBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2134930", Offset = "0x2133530", VA = "0x182134930", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2130170", Offset = "0x212ED70", VA = "0x182130170", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x21349F0", Offset = "0x21335F0", VA = "0x1821349F0")]
	private ANCGECKCCGF(bool BMEFHFPGGLM, HECAJEGBBHJ FPAIKMADOEB, bool MBKAAJKDGLG, AFFDGJJAICK<NDAEOGCNEDJ, CACBJMGICIJ> PLLOJEKJPJN, AFFDGJJAICK<NDAEOGCNEDJ, HPBLGKLMNBF> HAHACHHDIHE, CABMAJOBDAN HNCCPGMBLOD, AFFDGJJAICK<NGICMBDBBIC, OHAEKOAEENJ> NGNHKABAOGE, AFFDGJJAICK<NGICMBDBBIC, IKBNADFOJLB> KDEHFDKOPHH, string? LHIEEIBBCLB, GAPPNIAAIMJ PDFHKBHONLL, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, bool FFJKALPLNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x21329E0", Offset = "0x21315E0", VA = "0x1821329E0")]
	public static ANCGECKCCGF LMDPPDEOAIA(bool BMEFHFPGGLM, HECAJEGBBHJ FPAIKMADOEB, bool MBKAAJKDGLG, CABMAJOBDAN HNCCPGMBLOD, GAPPNIAAIMJ PDFHKBHONLL, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, bool FFJKALPLNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2131A00", Offset = "0x2130600", VA = "0x182131A00")]
	private void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x212F440", Offset = "0x212E040", VA = "0x18212F440", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x212F000", Offset = "0x212DC00", VA = "0x18212F000", Slot = "38")]
	[AsyncStateMachine(typeof(BOKLNAFLLNC))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> CJLHBEHAPLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2131670", Offset = "0x2130270", VA = "0x182131670")]
	private (LGINKNNOMAM, int)? JODCFHJLDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x212F200", Offset = "0x212DE00", VA = "0x18212F200")]
	private void COILLHHEAFJ(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1664790", Offset = "0x1663390", VA = "0x181664790")]
	private void JBIBPPBHBEM(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2132640", Offset = "0x2131240", VA = "0x182132640")]
	private void LKMGHCLAKDB(int DGCOOCBNKGK, int HEAIGCGCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2130D40", Offset = "0x212F940", VA = "0x182130D40")]
	private void IBEIAAHJBEG(int DGCOOCBNKGK, int HEAIGCGCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2133E00", Offset = "0x2132A00", VA = "0x182133E00")]
	private void OKCILOCCCMI(int FELAFDBGKBP, FANMFDLLPNO<NDAEOGCNEDJ> HNEBHKMAHOB, FFFPAEDNLOF GAECIBGPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2130450", Offset = "0x212F050", VA = "0x182130450")]
	private void GGHGEFAFILK(int AEBBBFCJHJO, FANMFDLLPNO<NDAEOGCNEDJ> HNEBHKMAHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2134340", Offset = "0x2132F40", VA = "0x182134340")]
	private void OMBIMLJGMPO(int AEBBBFCJHJO, FANMFDLLPNO<NDAEOGCNEDJ> HNEBHKMAHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x21344E0", Offset = "0x21330E0", VA = "0x1821344E0")]
	private void PJAAEBFGAOD(int FELAFDBGKBP, FANMFDLLPNO<NDAEOGCNEDJ> HNEBHKMAHOB, FFFPAEDNLOF GAECIBGPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x212FF40", Offset = "0x212EB40", VA = "0x18212FF40")]
	private void EANCAADBEHD(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xC7CDF0", Offset = "0xC7B9F0", VA = "0x180C7CDF0")]
	private void LFGCIFIPKCG(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2133BB0", Offset = "0x21327B0", VA = "0x182133BB0")]
	private void OEGBHOIGAJB(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1664790", Offset = "0x1663390", VA = "0x181664790")]
	private void NEHAHGGGJAI(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x21332B0", Offset = "0x2131EB0", VA = "0x1821332B0")]
	private void MMOADGOPKNE(int DGCOOCBNKGK, int HEAIGCGCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2130110", Offset = "0x212ED10", VA = "0x182130110")]
	private void EGFEDGLJGOJ(int DGCOOCBNKGK, int HEAIGCGCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2130DA0", Offset = "0x212F9A0", VA = "0x182130DA0")]
	private void ICBBCKEFKHG(int FELAFDBGKBP, FANMFDLLPNO<NGICMBDBBIC> HNEBHKMAHOB, EAFLBCMLHBH GAECIBGPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2133B90", Offset = "0x2132790", VA = "0x182133B90")]
	private void NPFPEDMIEJE(int AEBBBFCJHJO, FANMFDLLPNO<NGICMBDBBIC> HNEBHKMAHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x212F420", Offset = "0x212E020", VA = "0x18212F420")]
	private void DLHPPPHBLDJ(int AEBBBFCJHJO, FANMFDLLPNO<NGICMBDBBIC> HNEBHKMAHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x21305A0", Offset = "0x212F1A0", VA = "0x1821305A0")]
	private void HACPPGDNMOA(int FELAFDBGKBP, FANMFDLLPNO<NGICMBDBBIC> HNEBHKMAHOB, EAFLBCMLHBH GAECIBGPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2130BF0", Offset = "0x212F7F0", VA = "0x182130BF0")]
	private void HMGELDHJKEN(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xC7CDF0", Offset = "0xC7B9F0", VA = "0x180C7CDF0")]
	private void BKIMJIIBGMH(int FELAFDBGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x21302F0", Offset = "0x212EEF0", VA = "0x1821302F0", Slot = "39")]
	[AsyncStateMachine(typeof(IIGAHNPBCNC))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> EPOHANFALNG(FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x212F0F0", Offset = "0x212DCF0", VA = "0x18212F0F0", Slot = "40")]
	[AsyncStateMachine(typeof(CJLBCCDADGF))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> CMEOOGHNMIN(FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2130AD0", Offset = "0x212F6D0", VA = "0x182130AD0", Slot = "41")]
	[AsyncStateMachine(typeof(DHPPDEACAHO))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> HGOPGLGFAOL(FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK, FANMFDLLPNO<CHEBACDPPKC> OCLFDAJAHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2133190", Offset = "0x2131D90", VA = "0x182133190", Slot = "42")]
	[AsyncStateMachine(typeof(IJCBLEEGBAJ))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> MMHLKNAJFKF(FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF, FANMFDLLPNO<JCAEKHBPEKE> OCLFDAJAHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x212EB10", Offset = "0x212D710", VA = "0x18212EB10", Slot = "43")]
	[AsyncStateMachine(typeof(LMJKDEFDLPD))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> AJCLOFAMDDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2133650", Offset = "0x2132250", VA = "0x182133650", Slot = "44")]
	[AsyncStateMachine(typeof(NLLCDNNIJIA))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> MNDODIADMAM(string PILJEHNPPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x21318D0", Offset = "0x21304D0", VA = "0x1821318D0", Slot = "45")]
	[AsyncStateMachine(typeof(NGMECKGKAIP))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> KEBONFGMAIH(FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK, string GMBAACDNNFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x212F2F0", Offset = "0x212DEF0", VA = "0x18212F2F0", Slot = "46")]
	[AsyncStateMachine(typeof(JGBJIGFGCLK))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> DHAAILAOEPJ(FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF, string GMBAACDNNFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2130470", Offset = "0x212F070", VA = "0x182130470", Slot = "47")]
	[AsyncStateMachine(typeof(FJHMGOADEPN))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> GKBFBAACLGP(FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK, CCHIIJMLNME FIFJJNIIAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2133770", Offset = "0x2132370", VA = "0x182133770", Slot = "48")]
	[AsyncStateMachine(typeof(JOCPFPGMBDC))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> MPHMEDGOJAK(FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF, CCHIIJMLNME FIFJJNIIAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x21321B0", Offset = "0x2130DB0", VA = "0x1821321B0")]
	internal void KPNNPOODNCB(FANMFDLLPNO<JOGIKJOJMKJ> CABLCDOIFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class FPDLBCLPOFG : GFIADHGJHPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public interface PCIKIJLMJFF
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public readonly struct GINDFFLNBOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public readonly IReadOnlyDictionary<DBMOGKNBCFK<LNEKKJBHBEC>, Guid>? PBHGBHANLLB;

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
			public GINDFFLNBOH(IReadOnlyDictionary<DBMOGKNBCFK<LNEKKJBHBEC>, Guid>? PBHGBHANLLB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		IBGCMAIHCJF LCHHJGFLEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KAKCODMKIFK> HOPNGFNJKOJ(CancellationToken CKKFHABGBNL);

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<ALHAJLJNJLJ> DIPCFEMKCEI(CancellationToken CKKFHABGBNL);

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<BIMNOGFLAML> IJJIIHDCPCE(CancellationToken CKKFHABGBNL);

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<GINDFFLNBOH> KNPGFNJJMFF(CancellationToken CKKFHABGBNL);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BIFOBEAMFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<FPDLBCLPOFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public HECAJEGBBHJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public KAKCODMKIFK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public ALHAJLJNJLJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private PCIKIJLMJFF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private ALHAJLJNJLJ <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private BIMNOGFLAML <playerSaveData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<KAKCODMKIFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<ALHAJLJNJLJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<BIMNOGFLAML> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<PCIKIJLMJFF.GINDFFLNBOH> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<KCOMFDLMGDL> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x21364A0", Offset = "0x21350A0", VA = "0x1821364A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x21370B0", Offset = "0x2135CB0", VA = "0x1821370B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private readonly KCOMFDLMGDL OHEOAEJEJKD;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KCOMFDLMGDL MMALLIMGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	private FPDLBCLPOFG(KCOMFDLMGDL GNAHNGCEBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x213AE80", Offset = "0x2139A80", VA = "0x18213AE80")]
	[AsyncStateMachine(typeof(BIFOBEAMFNL))]
	public static Task<FPDLBCLPOFG> JPAMHLHMCLP(HECAJEGBBHJ FPAIKMADOEB, KAKCODMKIFK? DJNINBEOIHC, ALHAJLJNJLJ? DAMPDLBECHI, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x213AE60", Offset = "0x2139A60", VA = "0x18213AE60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public readonly struct EJAFGPCKOPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct CAGBPLOLDFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public EJAFGPCKOPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AHAMAEENKGG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2138470", Offset = "0x2137070", VA = "0x182138470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2138700", Offset = "0x2137300", VA = "0x182138700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct FFJIABOEBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public JNFCNCENMII rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KAKCODMKIFK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public ALHAJLJNJLJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public EJAFGPCKOPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private AHAMAEENKGG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x213A460", Offset = "0x2139060", VA = "0x18213A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x213A840", Offset = "0x2139440", VA = "0x18213A840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct DGBKDBAOHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public EJAFGPCKOPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x21395F0", Offset = "0x21381F0", VA = "0x1821395F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2139830", Offset = "0x2138430", VA = "0x182139830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private readonly DCHFDHOJOJI PMLNHAAKAKP;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	public EJAFGPCKOPK(DCHFDHOJOJI HGJKJDPBMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2139D60", Offset = "0x2138960", VA = "0x182139D60")]
	[AsyncStateMachine(typeof(CAGBPLOLDFG))]
	private Task<OAMIPODNNBO<object, BDMFJEIOIAD>> DCHOHHNANFG(AHAMAEENKGG FNGNLBJEBKM, bool DFCDOALJFOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2139E90", Offset = "0x2138A90", VA = "0x182139E90")]
	[AsyncStateMachine(typeof(FFJIABOEBCC))]
	public Task<OAMIPODNNBO<bool, BDMFJEIOIAD?>>? GKBGAHBBALK(int OAKNPKDIJDI, JNFCNCENMII? PJJJPLDPJEK, KAKCODMKIFK? GLFGAKGEEJK, ALHAJLJNJLJ? DAMPDLBECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2139FF0", Offset = "0x2138BF0", VA = "0x182139FF0")]
	[AsyncStateMachine(typeof(DGBKDBAOHKD))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> PAMNEBLPMKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public sealed class KCOGBDJBJIA : IKJMNIFLMNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly LADNGHHIJHG OBDOLEIPOHO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LADNGHHIJHG NBHIGNFFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	private KCOGBDJBJIA(LADNGHHIJHG AJEKDODPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x213DFC0", Offset = "0x213CBC0", VA = "0x18213DFC0")]
	public static KCOGBDJBJIA ICHKPGLOBMP(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x213DFA0", Offset = "0x213CBA0", VA = "0x18213DFA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface DCDCLEKFKNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	KCOMFDLMGDL MMALLIMGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	BDEGOONFGOO LDNFJAFPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	FCOCHPMFPIE KIKLEJALHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	OHGDKPBJDPK KKKJMICJAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface OFKDOAFPGOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	DCDCLEKFKNC? OPNBAPEHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool HDAAHMCPHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DCDCLEKFKNC?>? BCOLHDPCIHH();

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task POCPEIEGPEA(HECAJEGBBHJ FPAIKMADOEB, JNFCNCENMII BDGDHKNPAPE, KAKCODMKIFK? OCNLKMFAFPI, ALHAJLJNJLJ? EJGNMLGBLEC);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[KLKAKBOPMJG("IStaticCV2Instance")]
public interface GFIADHGJHPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	KCOMFDLMGDL MMALLIMGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[KLKAKBOPMJG("IStaticEVInstance")]
public interface IKJMNIFLMNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	LADNGHHIJHG NBHIGNFFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class NIKPHPCIACD
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2141A30", Offset = "0x2140630", VA = "0x182141A30")]
	public static LBJCDMIBGOD<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> DLCBGNBIIJC([In] this LBJCDMIBGOD<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>> PDJDEDFOBOO)
	{
		return default(LBJCDMIBGOD<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ, GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class GLMMJPHCCHK : NMBDHHEEIKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HDAAHMCPHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x213B780", Offset = "0x213A380", VA = "0x18213B780", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	internal GLMMJPHCCHK(HECAJEGBBHJ FPAIKMADOEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal sealed class ECCNHFNKLKE : GDGGNFBNEEL
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2139CC0", Offset = "0x21388C0", VA = "0x182139CC0", Slot = "4")]
	public AFBCHPBOPBG? GKELNOIANDC(string? NBBKJEBPCFP, string? ENBCCNEAGEK, string? HLLILLFNDFP, HDNFFJCCEPI.IFNGBFGADLK.AKNDPDJJONG CKBAMMLDJAP, bool IGEOFDPHPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public ECCNHFNKLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class BMNJACENIHB : MIHMJLMACJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct FALDCHPCKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<DCMDDGDMJKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public BMNJACENIHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<DCDCLEKFKNC?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x213A0E0", Offset = "0x2138CE0", VA = "0x18213A0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x213A390", Offset = "0x2138F90", VA = "0x18213A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private IReadOnlyList<DBMOGKNBCFK<IIHAEGFAHBG>>? GJOFPOFEJPH;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public DCMDDGDMJKM? AAGIFLNDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x21373B0", Offset = "0x2135FB0", VA = "0x1821373B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OHGDKPBJDPK? CMHIIJIHKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2137E50", Offset = "0x2136A50", VA = "0x182137E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DFIMNBHPDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2137900", Offset = "0x2136500", VA = "0x182137900", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CALGCJMMACO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x21375F0", Offset = "0x21361F0", VA = "0x1821375F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	internal BMNJACENIHB(HECAJEGBBHJ FPAIKMADOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2137810", Offset = "0x2136410", VA = "0x182137810", Slot = "7")]
	[AsyncStateMachine(typeof(FALDCHPCKPK))]
	public Task<DCMDDGDMJKM> IBELAHCHFOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2137AE0", Offset = "0x21366E0", VA = "0x182137AE0", Slot = "9")]
	public IReadOnlyDictionary<DBMOGKNBCFK<LNEKKJBHBEC>, Guid> MBFJKFDHGIK(IEnumerable<GLOMMFEJNDK> AGJJNCHNNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2137960", Offset = "0x2136560", VA = "0x182137960", Slot = "10")]
	public CPMPBIKALEL LPFDFKHCJMD(IEnumerable<GLOMMFEJNDK> AGJJNCHNNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2137650", Offset = "0x2136250", VA = "0x182137650")]
	public OAMIPODNNBO<AMDBLAHAGKL, OILOBAEJEDE> HLNHKDDIMHO([In] AMDBLAHAGKL IFHLKMIMJLA, IEnumerable<GLOMMFEJNDK> ADKCACGJHCF, int FCDGGBOEKKM)
	{
		return default(OAMIPODNNBO<AMDBLAHAGKL, OILOBAEJEDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2137430", Offset = "0x2136030", VA = "0x182137430", Slot = "8")]
	private OAMIPODNNBO<AMDBLAHAGKL, OILOBAEJEDE> DGCFJPKMNIM([In] AMDBLAHAGKL IFHLKMIMJLA, IEnumerable<GLOMMFEJNDK> ADKCACGJHCF, int FCDGGBOEKKM)
	{
		return default(OAMIPODNNBO<AMDBLAHAGKL, OILOBAEJEDE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class OHGDKPBJDPK : DCMDDGDMJKM
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	internal static class LDNJNGGMNIL
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class KDGDPCAKJCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public KCOMFDLMGDL state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public OPMGGFMPHEN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public KDGDPCAKJCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x214EF40", Offset = "0x214DB40", VA = "0x18214EF40")]
			internal bool LEHCKINMBEE(GBHIAPPIACM n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class CLMPFBDIGPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CLMPFBDIGPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x214BB50", Offset = "0x214A750", VA = "0x18214BB50")]
			internal void AJKCJOOEKEB(GBHIAPPIACM n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x213EA40", Offset = "0x213D640", VA = "0x18213EA40")]
		public static OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG> HBJCFKJEPNA(OHGDKPBJDPK GMNCELIMKIF, [In] DCMDDGDMJKM.NHDLMDPHKDG JIAHCJFCHOA)
		{
			return default(OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x213F070", Offset = "0x213DC70", VA = "0x18213F070")]
		internal static OAMIPODNNBO<(OLOKFMGPGEJ, DLFPLHJELOG), HAJPGIFDCBG> KLABJCNOEFL(OHGDKPBJDPK GMNCELIMKIF, DLFPLHJELOG GJHAKOPCBDI, bool FHHDFEHKFIF, [In] DBMOGKNBCFK<LNEKKJBHBEC> PNIKNBAPACP, [In] int? NNAPPAIKAGM, [In] IKICHIOGDGB? NOJGHGDFFGL, [In] IKICHIOGDGB? FMBPFPEFFCL)
		{
			return default(OAMIPODNNBO<(OLOKFMGPGEJ, DLFPLHJELOG), HAJPGIFDCBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x213E1F0", Offset = "0x213CDF0", VA = "0x18213E1F0")]
		private static void CCBHGJGFIGF(bool FHHDFEHKFIF, GLOMMFEJNDK GJMLLIMGMPK, OLOKFMGPGEJ HNJPGAGOLAH, [In] DBMOGKNBCFK<LNEKKJBHBEC> PNIKNBAPACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x213E630", Offset = "0x213D230", VA = "0x18213E630")]
		public static void ELDGBBDAELG(LHJBGJCFBFG BAAPJCPJJBN, [In] DCMDDGDMJKM.JGEFHBNBNHC NGKJPEFLPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x213EF80", Offset = "0x213DB80", VA = "0x18213EF80")]
		[CompilerGenerated]
		internal static bool ILIJHALCDDG(KCOMFDLMGDL NPDKFOJGLKK, OPMGGFMPHEN INFNNGINGFI, GBHIAPPIACM BDIPOGCOBJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x213E1C0", Offset = "0x213CDC0", VA = "0x18213E1C0")]
		[CompilerGenerated]
		internal static bool BJIJABCGCIA(GBHIAPPIACM NEMFFPFIOFE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct KDMLHNHOJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OHGDKPBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public FANMFDLLPNO<LNEKKJBHBEC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public FANMFDLLPNO<LOCKFIIFIFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DGFFKHOBAPM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x214EF60", Offset = "0x214DB60", VA = "0x18214EF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct PMJODHEGODL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public OHGDKPBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public FANMFDLLPNO<LNEKKJBHBEC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public DBMOGKNBCFK<LOCKFIIFIFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public List<FANMFDLLPNO<LOCKFIIFIFD>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public DGFFKHOBAPM localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public OPFDDIEBCBF localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public DGFFKHOBAPM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x21508E0", Offset = "0x214F4E0", VA = "0x1821508E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2150BA0", Offset = "0x214F7A0", VA = "0x182150BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct HCCENLBMDFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public OHGDKPBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public FANMFDLLPNO<LNEKKJBHBEC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public FANMFDLLPNO<MKNPBKPFDPA> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public FANMFDLLPNO<NGAFIAGIONI> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x214DF60", Offset = "0x214CB60", VA = "0x18214DF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x214E5B0", Offset = "0x214D1B0", VA = "0x18214E5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct IMPNEPPOAAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public OHGDKPBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public DBMOGKNBCFK<LOCKFIIFIFD> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public DBMOGKNBCFK<LNEKKJBHBEC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public FANMFDLLPNO<JOGIKJOJMKJ> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public FANMFDLLPNO<NDAEOGCNEDJ> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x214E800", Offset = "0x214D400", VA = "0x18214E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x214EB40", Offset = "0x214D740", VA = "0x18214EB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct NENKLPNABPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public OHGDKPBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public DBMOGKNBCFK<LOCKFIIFIFD> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public DBMOGKNBCFK<LNEKKJBHBEC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public FANMFDLLPNO<JOGIKJOJMKJ> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public FANMFDLLPNO<NGICMBDBBIC> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x214FB00", Offset = "0x214E700", VA = "0x18214FB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x214FE40", Offset = "0x214EA40", VA = "0x18214FE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly HECAJEGBBHJ LFPGLIEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly GFIADHGJHPF OOCCAOBOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly IKJMNIFLMNE NKCDLBNIDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly EAKLPJHKIMK EIMGMLMJGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly BMNJACENIHB APDLFGHECGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<DBMOGKNBCFK<LOCKFIIFIFD>, OCABIDKCHNK> BDEJOJHHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<DBMOGKNBCFK<LOCKFIIFIFD>>? BIEGFGELFDP;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DBMOGKNBCFK<LNEKKJBHBEC> IMDAEIMGCED
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2143C00", Offset = "0x2142800", VA = "0x182143C00", Slot = "4")]
		get
		{
			return default(DBMOGKNBCFK<LNEKKJBHBEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public EAKLPJHKIMK BKKIOOHCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x21261A0", Offset = "0x2124DA0", VA = "0x1821261A0", Slot = "5")]
		get
		{
			return default(EAKLPJHKIMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2149590", Offset = "0x2148190", VA = "0x182149590")]
	public OHGDKPBJDPK(HECAJEGBBHJ FPAIKMADOEB, GFIADHGJHPF AFDBEOPPPBO, IKJMNIFLMNE HKIPMAAGEAB, BMNJACENIHB GFEKMEBHFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x21431B0", Offset = "0x2141DB0", VA = "0x1821431B0", Slot = "55")]
	public FANMFDLLPNO<BNHIJCMBMHA> AAJMCJGCMLB(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return default(FANMFDLLPNO<BNHIJCMBMHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x21438F0", Offset = "0x21424F0", VA = "0x1821438F0", Slot = "56")]
	public FANMFDLLPNO<FAEOAHCOPJB> BJMJHLEIKIK(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return default(FANMFDLLPNO<FAEOAHCOPJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2144190", Offset = "0x2142D90", VA = "0x182144190", Slot = "6")]
	public (bool, bool) EAKFADEJAOO(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> JDKLAIOBONN, FANMFDLLPNO<NGAFIAGIONI> PDJEJIJPIJE)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x21458B0", Offset = "0x21444B0", VA = "0x1821458B0")]
	public bool GOLKHICFIIN(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] KKACLKPNGLJ DHLBJHABHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2144FF0", Offset = "0x2143BF0", VA = "0x182144FF0", Slot = "8")]
	public bool FJENOBAEJPC(HPBLGKLMNBF ANLFNBGOLEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2147070", Offset = "0x2145C70", VA = "0x182147070", Slot = "9")]
	public bool LELICEFBAEL(IKBNADFOJLB EICKJGNHBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2145C40", Offset = "0x2144840", VA = "0x182145C40", Slot = "10")]
	public HCNIKILKFFN? GPOLGICPGBG(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2145590", Offset = "0x2144190", VA = "0x182145590", Slot = "11")]
	public HEKBMLOONDG? GFEPHDAAGBO(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2143230", Offset = "0x2141E30", VA = "0x182143230", Slot = "12")]
	public FANMFDLLPNO<MKNPBKPFDPA>? AECOEMMLEOE(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NGICMBDBBIC> FJMEADGFOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2146630", Offset = "0x2145230", VA = "0x182146630", Slot = "13")]
	public FANMFDLLPNO<NGAFIAGIONI>? JPBGAKBBDMN(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, FANMFDLLPNO<NDAEOGCNEDJ> IJLIHPPNNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x21457A0", Offset = "0x21443A0", VA = "0x1821457A0", Slot = "14")]
	public IEnumerable<FANMFDLLPNO<LNEKKJBHBEC>> GKFGNFBJBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2143C60", Offset = "0x2142860", VA = "0x182143C60", Slot = "15")]
	public IEnumerable<FANMFDLLPNO<JGAJEDDGHBK>> CIAKGBHOMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2144BC0", Offset = "0x21437C0", VA = "0x182144BC0", Slot = "16")]
	public string EKGBNMNMHDJ(FANMFDLLPNO<JGAJEDDGHBK> HKFPNCHAKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2148390", Offset = "0x2146F90", VA = "0x182148390", Slot = "17")]
	public string MNKNIINAOLL(FANMFDLLPNO<JGAJEDDGHBK> HKFPNCHAKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x21452F0", Offset = "0x2143EF0", VA = "0x1821452F0")]
	public OCABIDKCHNK? GALIJECAFJO([In] DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2143D10", Offset = "0x2142910", VA = "0x182143D10")]
	public FANMFDLLPNO<LOCKFIIFIFD> MBOICPPKOPN(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] DBMOGKNBCFK<LOCKFIIFIFD> POPCOJNNIAP)
	{
		return default(FANMFDLLPNO<LOCKFIIFIFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2143480", Offset = "0x2142080", VA = "0x182143480", Slot = "29")]
	public FANMFDLLPNO<LOCKFIIFIFD> BBGFEJOOHMF(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return default(FANMFDLLPNO<LOCKFIIFIFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x21467E0", Offset = "0x21453E0", VA = "0x1821467E0", Slot = "30")]
	public FANMFDLLPNO<LOCKFIIFIFD> KEBGNEPDFCO(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return default(FANMFDLLPNO<LOCKFIIFIFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2143FE0", Offset = "0x2142BE0", VA = "0x182143FE0")]
	private void DHIHEKBLKHB(DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2144E60", Offset = "0x2143A60", VA = "0x182144E60")]
	public IEnumerable<OCABIDKCHNK> FAIMPFFBCCL([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x21465A0", Offset = "0x21451A0", VA = "0x1821465A0", Slot = "28")]
	public FANMFDLLPNO<NGAFIAGIONI> JPBGAKBBDMN(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<BNHIJCMBMHA> IJLIHPPNNDK)
	{
		return default(FANMFDLLPNO<NGAFIAGIONI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x21432C0", Offset = "0x2141EC0", VA = "0x1821432C0", Slot = "31")]
	public FANMFDLLPNO<MKNPBKPFDPA> AECOEMMLEOE(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<FAEOAHCOPJB> FJMEADGFOCN)
	{
		return default(FANMFDLLPNO<MKNPBKPFDPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2144F40", Offset = "0x2143B40", VA = "0x182144F40")]
	private OCABIDKCHNK? FDOPOCDCECF([In] DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x21461C0", Offset = "0x2144DC0", VA = "0x1821461C0")]
	private OCABIDKCHNK JICHBGLLIFD([In] DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED, CABMAJOBDAN HNCCPGMBLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2149280", Offset = "0x2147E80", VA = "0x182149280")]
	public CABMAJOBDAN? PHACEHANNED([In] DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2143350", Offset = "0x2141F50", VA = "0x182143350")]
	public OCLFDLEPGCC? AOEKIJAACLH([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x21494D0", Offset = "0x21480D0", VA = "0x1821494D0", Slot = "23")]
	public IEnumerable<PJEMFPOGMJH> PPHCJACNHEA(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2144690", Offset = "0x2143290", VA = "0x182144690", Slot = "24")]
	public bool EANNKKNLOFJ(FANMFDLLPNO<JGAJEDDGHBK> HKFPNCHAKDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2143660", Offset = "0x2142260", VA = "0x182143660", Slot = "25")]
	public IEnumerable<KKACLKPNGLJ> BFECEJMDGLO(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> JDKLAIOBONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2145070", Offset = "0x2143C70", VA = "0x182145070", Slot = "26")]
	public IEnumerable<KKACLKPNGLJ> FLIEJIIADDA(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> PDJEJIJPIJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x21456B0", Offset = "0x21442B0", VA = "0x1821456B0")]
	public FANMFDLLPNO<LNEKKJBHBEC> OEKPANJIJKD([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return default(FANMFDLLPNO<LNEKKJBHBEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2145830", Offset = "0x2144430", VA = "0x182145830")]
	public FANMFDLLPNO<LNEKKJBHBEC>? GNMFLACACOO([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2148260", Offset = "0x2146E60", VA = "0x182148260")]
	private OPMGGFMPHEN? MEOGIGAINGN([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2143350", Offset = "0x2141F50", VA = "0x182143350")]
	private OCLFDLEPGCC? GONGNFLFJFM([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2148320", Offset = "0x2146F20", VA = "0x182148320", Slot = "35")]
	public DBMOGKNBCFK<LNEKKJBHBEC> MHLHODBEBNE(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return default(DBMOGKNBCFK<LNEKKJBHBEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2143380", Offset = "0x2141F80", VA = "0x182143380", Slot = "32")]
	public IEnumerable<CCHIIJMLNME> BBADCANOOHN(KDEHGBPHDEC DHCILNFJNFN, bool FBKIHICHDHO, bool JAMCAKOJKCG, bool OEDCHNOLCON, bool KFABLDCFMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2146290", Offset = "0x2144E90", VA = "0x182146290", Slot = "33")]
	public CCHIIJMLNME JJNLIEJFJKL(KDEHGBPHDEC DHCILNFJNFN, KGHMAIKBCDM AGBAALFHBFJ, bool FBKIHICHDHO, bool JAMCAKOJKCG, bool OEDCHNOLCON, bool KFABLDCFMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2143E70", Offset = "0x2142A70", VA = "0x182143E70")]
	public PJEMFPOGMJH EACKPLEBMCH(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] KKACLKPNGLJ DHLBJHABHDO)
	{
		return default(PJEMFPOGMJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2144C30", Offset = "0x2143830", VA = "0x182144C30", Slot = "36")]
	public KKACLKPNGLJ EPJFBPOGOMB(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> JDKLAIOBONN, FANMFDLLPNO<NGAFIAGIONI> PDJEJIJPIJE)
	{
		return default(KKACLKPNGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2149390", Offset = "0x2147F90", VA = "0x182149390", Slot = "37")]
	[AsyncStateMachine(typeof(KDMLHNHOJOD))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> PNPNOAPJNBE(FANMFDLLPNO<LNEKKJBHBEC> PJNAMKGMKFI, FANMFDLLPNO<LOCKFIIFIFD> HAKCNELIGBD, DGFFKHOBAPM APMEPKJBNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2146040", Offset = "0x2144C40", VA = "0x182146040", Slot = "38")]
	[AsyncStateMachine(typeof(PMJODHEGODL))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> JHLHHCNLCLB(FANMFDLLPNO<LNEKKJBHBEC> PJNAMKGMKFI, DBMOGKNBCFK<LOCKFIIFIFD> HAKCNELIGBD, List<FANMFDLLPNO<LOCKFIIFIFD>> ICJIJKPKEBP, DGFFKHOBAPM MOAMJJBIHCH, OPFDDIEBCBF OOPFPFKDDBF, DGFFKHOBAPM APMEPKJBNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x21466C0", Offset = "0x21452C0", VA = "0x1821466C0", Slot = "39")]
	public bool KBAJIJELOIF(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2149310", Offset = "0x2147F10", VA = "0x182149310", Slot = "40")]
	public bool PNDKCKEABPO(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2143970", Offset = "0x2142570", VA = "0x182143970", Slot = "41")]
	public bool CBFMHNLGOEJ(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x21467B0", Offset = "0x21453B0", VA = "0x1821467B0")]
	public OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG> MJNIICAKCID([In] DCMDDGDMJKM.NHDLMDPHKDG JIAHCJFCHOA)
	{
		return default(OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2145460", Offset = "0x2144060", VA = "0x182145460", Slot = "43")]
	[AsyncStateMachine(typeof(HCCENLBMDFF))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> GEBDLKJMOLE(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> JDKLAIOBONN, FANMFDLLPNO<NGAFIAGIONI> PDJEJIJPIJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2147EA0", Offset = "0x2146AA0", VA = "0x182147EA0", Slot = "44")]
	public OAMIPODNNBO<HOMBOLFPHAP, OILOBAEJEDE> MALOPKEECOJ(DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN, HOMBOLFPHAP JDMCIOCAIMB, OPFDDIEBCBF EFAGBHIHFHC)
	{
		return default(OAMIPODNNBO<HOMBOLFPHAP, OILOBAEJEDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2145E50", Offset = "0x2144A50", VA = "0x182145E50", Slot = "45")]
	[AsyncStateMachine(typeof(IMPNEPPOAAI))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> IOJCHLODEDM(DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN, DBMOGKNBCFK<LOCKFIIFIFD> GKACHBPLCKD, FANMFDLLPNO<JOGIKJOJMKJ> HKCGNMDPABD, FANMFDLLPNO<NDAEOGCNEDJ> DMAAAHKLEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2143500", Offset = "0x2142100", VA = "0x182143500", Slot = "46")]
	[AsyncStateMachine(typeof(NENKLPNABPA))]
	public Task<OAMIPODNNBO<FKMCALNFICP, BDMFJEIOIAD>> BDKGBONMFII(DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN, DBMOGKNBCFK<LOCKFIIFIFD> OJHGBHGFPGF, FANMFDLLPNO<JOGIKJOJMKJ> POIGFLPEEFC, FANMFDLLPNO<NGICMBDBBIC> LIBLJKEMGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2144070", Offset = "0x2142C70", VA = "0x182144070", Slot = "47")]
	public EKIFHPGNECC DKCGFFOAGPJ(IEnumerable<GLOMMFEJNDK> ADKCACGJHCF)
	{
		return default(EKIFHPGNECC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x21439F0", Offset = "0x21425F0", VA = "0x1821439F0", Slot = "48")]
	public EKIFHPGNECC CCGIGMEHCCN()
	{
		return default(EKIFHPGNECC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x21490D0", Offset = "0x2147CD0", VA = "0x1821490D0")]
	private NADBCIJNMIJ NOIINJFIIKP(FOMGGLLCFOD JILGGDBLMLN, FANMFDLLPNO<LNEKKJBHBEC> NPNCGDOKAPJ, IEnumerable<DBMOGKNBCFK<LNEKKJBHBEC>> LFOBOHKPCFF, IEnumerable<DBMOGKNBCFK<LOCKFIIFIFD>> ICJIJKPKEBP)
	{
		return default(NADBCIJNMIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2148E40", Offset = "0x2147A40", VA = "0x182148E40", Slot = "49")]
	public NADBCIJNMIJ NOIINJFIIKP(FOMGGLLCFOD JILGGDBLMLN, FANMFDLLPNO<LNEKKJBHBEC> NPNCGDOKAPJ, IEnumerable<DBMOGKNBCFK<LOCKFIIFIFD>> ICJIJKPKEBP, IEnumerable<GLOMMFEJNDK> ADKCACGJHCF)
	{
		return default(NADBCIJNMIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x21470F0", Offset = "0x2145CF0", VA = "0x1821470F0")]
	private static IEnumerable<DBMOGKNBCFK<LNEKKJBHBEC>> LHMLLBCEMMM(IEnumerable<GLOMMFEJNDK> ADKCACGJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2144720", Offset = "0x2143320", VA = "0x182144720")]
	private IEnumerable<DBMOGKNBCFK<LOCKFIIFIFD>> EDAPBBDOAMP(IEnumerable<GLOMMFEJNDK> ADKCACGJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2145FB0", Offset = "0x2144BB0", VA = "0x182145FB0", Slot = "50")]
	public List<LNJIHCABNGM> JFLPJJDIFOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2146860", Offset = "0x2145460", VA = "0x182146860")]
	public (List<LNJIHCABNGM>, bool) KLKDOLCEFDK([In] KCOFELKDCKO PIOIHEABDKG, string PDMONEGPHPK, [In] BAABCOCOIPM OPKLEDCLHAI, OJJBNNLPOKJ JDBAJFKKOOL, PCOCIODFNEB HFFGHKKHHIM)
	{
		return default((List<LNJIHCABNGM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2143B10", Offset = "0x2142710", VA = "0x182143B10", Slot = "52")]
	public bool CEGKAKPGLDE(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2145650", Offset = "0x2144250", VA = "0x182145650")]
	internal void GGDMKFNPDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2147E40", Offset = "0x2146A40", VA = "0x182147E40")]
	internal Task LPMGKOFONOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2147470", Offset = "0x2146070", VA = "0x182147470", Slot = "53")]
	public OAMIPODNNBO<FANMFDLLPNO<MKNPBKPFDPA>?, BDMFJEIOIAD> LJJMBNMFLFL(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return default(OAMIPODNNBO<FANMFDLLPNO<MKNPBKPFDPA>?, BDMFJEIOIAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2148400", Offset = "0x2147000", VA = "0x182148400", Slot = "54")]
	public OAMIPODNNBO<FANMFDLLPNO<NGAFIAGIONI>?, BDMFJEIOIAD> NCAOJICBBDI(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return default(OAMIPODNNBO<FANMFDLLPNO<NGAFIAGIONI>?, BDMFJEIOIAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x21438E0", Offset = "0x21424E0", VA = "0x1821438E0", Slot = "7")]
	private bool BHIKGIKOEPL(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] KKACLKPNGLJ DHLBJHABHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2143350", Offset = "0x2141F50", VA = "0x182143350", Slot = "18")]
	private OCLFDLEPGCC FBCHJKANLAD([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x21456B0", Offset = "0x21442B0", VA = "0x1821456B0", Slot = "19")]
	private FANMFDLLPNO<LNEKKJBHBEC> GGIBDONCJFK([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return default(FANMFDLLPNO<LNEKKJBHBEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2145830", Offset = "0x2144430", VA = "0x182145830", Slot = "20")]
	private FANMFDLLPNO<LNEKKJBHBEC>? HMNICPMBAEE([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2146F20", Offset = "0x2145B20", VA = "0x182146F20", Slot = "21")]
	private OCABIDKCHNK KLMNHIICGAF([In] DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2143D10", Offset = "0x2142910", VA = "0x182143D10", Slot = "22")]
	private FANMFDLLPNO<LOCKFIIFIFD> CIMDIFFEBOH(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] DBMOGKNBCFK<LOCKFIIFIFD> POPCOJNNIAP)
	{
		return default(FANMFDLLPNO<LOCKFIIFIFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2143D90", Offset = "0x2142990", VA = "0x182143D90", Slot = "27")]
	private IEnumerable<OCABIDKCHNK> DBIPMPGEANC([In] DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2143E70", Offset = "0x2142A70", VA = "0x182143E70", Slot = "34")]
	private PJEMFPOGMJH DFHPFMPLCBG(FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, [In] KKACLKPNGLJ DHLBJHABHDO)
	{
		return default(PJEMFPOGMJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x21467B0", Offset = "0x21453B0", VA = "0x1821467B0", Slot = "42")]
	private OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG> KCFKLMHMEFB([In] DCMDDGDMJKM.NHDLMDPHKDG JIAHCJFCHOA)
	{
		return default(OAMIPODNNBO<DCMDDGDMJKM.EONADNHFAPG, HAJPGIFDCBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2145DF0", Offset = "0x21449F0", VA = "0x182145DF0", Slot = "51")]
	private (List<LNJIHCABNGM>, bool) IHFBLCNMMFD([In] KCOFELKDCKO PIOIHEABDKG, string PDMONEGPHPK, [In] BAABCOCOIPM OPKLEDCLHAI, OJJBNNLPOKJ JDBAJFKKOOL, PCOCIODFNEB HFFGHKKHHIM)
	{
		return default((List<LNJIHCABNGM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2145D00", Offset = "0x2144900", VA = "0x182145D00")]
	[CompilerGenerated]
	private OCABIDKCHNK ICNHJKJPJDN(CABMAJOBDAN EKJHOCEPHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2146730", Offset = "0x2145330", VA = "0x182146730")]
	[CompilerGenerated]
	private ONDKEJNHALC KBEPIHPBIMN(FNKIFJDBEEJ EKJHOCEPHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2148DD0", Offset = "0x21479D0", VA = "0x182148DD0")]
	[CompilerGenerated]
	private CABMAJOBDAN NJPBFEDCEDM(DBMOGKNBCFK<LOCKFIIFIFD> EKJHOCEPHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2145730", Offset = "0x2144330", VA = "0x182145730")]
	[CompilerGenerated]
	private OPMGGFMPHEN GJICJFNNLEP(DBMOGKNBCFK<LNEKKJBHBEC> EKJHOCEPHIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class ONDKEJNHALC : CCHIIJMLNME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct LJHLKKFAMLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FANMFDLLPNO<CHEBACDPPKC>, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public ONDKEJNHALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public DBMOGKNBCFK<LNEKKJBHBEC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public DBMOGKNBCFK<LOCKFIIFIFD> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<CHEBACDPPKC>, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x214F520", Offset = "0x214E120", VA = "0x18214F520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x214F7A0", Offset = "0x214E3A0", VA = "0x18214F7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct JEELNAHPOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<FANMFDLLPNO<JCAEKHBPEKE>, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public ONDKEJNHALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public DBMOGKNBCFK<LNEKKJBHBEC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public DBMOGKNBCFK<LOCKFIIFIFD> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FANMFDLLPNO<JOGIKJOJMKJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private TaskAwaiter<OAMIPODNNBO<FANMFDLLPNO<JCAEKHBPEKE>, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x214EBB0", Offset = "0x214D7B0", VA = "0x18214EBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x214EE30", Offset = "0x214DA30", VA = "0x18214EE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private readonly FNKIFJDBEEJ EENHLEEEDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private readonly GFIADHGJHPF OOCCAOBOOBN;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public TypeKey CPKCCKDOHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string AHHBNCHAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x214CB10", Offset = "0x214B710", VA = "0x18214CB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public FNKIFJDBEEJ PJENKLJOEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2150190", Offset = "0x214ED90", VA = "0x182150190")]
	public ONDKEJNHALC(FNKIFJDBEEJ NGMGIHKJNME, GFIADHGJHPF AFDBEOPPPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x214FEB0", Offset = "0x214EAB0", VA = "0x18214FEB0", Slot = "6")]
	[AsyncStateMachine(typeof(LJHLKKFAMLE))]
	public Task<OAMIPODNNBO<FANMFDLLPNO<CHEBACDPPKC>, BDMFJEIOIAD>> EMEMEBOPBDG(DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN, DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, string GMBAACDNNFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2150020", Offset = "0x214EC20", VA = "0x182150020", Slot = "7")]
	[AsyncStateMachine(typeof(JEELNAHPOGM))]
	public Task<OAMIPODNNBO<FANMFDLLPNO<JCAEKHBPEKE>, BDMFJEIOIAD>> MAHLKJMLPLA(DBMOGKNBCFK<LNEKKJBHBEC> JHHAGEEOAEN, DBMOGKNBCFK<LOCKFIIFIFD> KPGLKHEJBED, FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO, string GMBAACDNNFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GCLCGAPIDIH : HMIIHCFLPLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly FNKIFJDBEEJ AEENIKHNMFJ;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly HashSet<FNKIFJDBEEJ> DBGOHKBKMHN;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly HashSet<FNKIFJDBEEJ> HHCCGJAOBGI;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private static readonly HashSet<FNKIFJDBEEJ> FCNJKIPKKEB;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public TypeKey EIDDFPPJNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x214DCA0", Offset = "0x214C8A0", VA = "0x18214DCA0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CPKMABDAICP
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x214DC90", Offset = "0x214C890", VA = "0x18214DC90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool IJEJDKMGBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x214DCF0", Offset = "0x214C8F0", VA = "0x18214DCF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool HHOIFIOFFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x214DC10", Offset = "0x214C810", VA = "0x18214DC10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x214C8A0", Offset = "0x214B4A0", VA = "0x18214C8A0")]
	public bool IIMMEHKBGDG(string CABLCDOIFFL, [Out] LNBKJKLIFCF KGOHFMFEDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public GCLCGAPIDIH(FNKIFJDBEEJ GMBKDDMMMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x214C710", Offset = "0x214B310", VA = "0x18214C710")]
	internal static TypeKey FMLJENKJCKE(FNKIFJDBEEJ FIFJJNIIAPF)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x214CB10", Offset = "0x214B710", VA = "0x18214CB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public readonly struct GKLFOKPBDOJ : FDMFBILDOPO.NONOCIIBHKC<AHAMAEENKGG, FKMCALNFICP>
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x214DE70", Offset = "0x214CA70", VA = "0x18214DE70", Slot = "4")]
	public int CHBGHCPNEPN(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x214DE40", Offset = "0x214CA40", VA = "0x18214DE40", Slot = "5")]
	public AHAMAEENKGG BAJAONKDOOC(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x214DE10", Offset = "0x214CA10", VA = "0x18214DE10", Slot = "6")]
	public AHAMAEENKGG AMPCJDAPHNO(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x214DEC0", Offset = "0x214CAC0", VA = "0x18214DEC0", Slot = "7")]
	public IReadOnlyList<AHAMAEENKGG> HGGMKNAIHND(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x214DEB0", Offset = "0x214CAB0", VA = "0x18214DEB0", Slot = "8")]
	public AHAMAEENKGG[] EMGGMFDKFHF(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM, int DOPIEFFGKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x214DE50", Offset = "0x214CA50", VA = "0x18214DE50", Slot = "9")]
	public bool CCJECFGONAH(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x214DF20", Offset = "0x214CB20", VA = "0x18214DF20", Slot = "10")]
	public bool NCGLOMGCFAA(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x214DE90", Offset = "0x214CA90", VA = "0x18214DE90", Slot = "11")]
	public bool CMOMANKLEHD(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x214DEE0", Offset = "0x214CAE0", VA = "0x18214DEE0", Slot = "12")]
	public bool HONKNOFHDAL(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x214DF00", Offset = "0x214CB00", VA = "0x18214DF00", Slot = "13")]
	public bool KKENDIGBLJG(FKMCALNFICP BDBODJKDEFI, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x214DF40", Offset = "0x214CB40", VA = "0x18214DF40", Slot = "14")]
	public bool NMFGFDIKDII(FKMCALNFICP AEBBBFCJHJO, AHAMAEENKGG FNGNLBJEBKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public abstract class KAGHJBIGEJH : LMOCKDHMJIC
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public FAOKCPMHHCC.NIJIBJDKIJI DHCOKJLGAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x214EEA0", Offset = "0x214DAA0", VA = "0x18214EEA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract NGHHPLGJAPK.LOIDEMIKBAE KIMEDNEABCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract HECAJEGBBHJ.KOFHJPNAMOB CLFBGNLEEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract FPDLBCLPOFG.PCIKIJLMJFF IIFNNBNBGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GCIANMOGIHK.GFDMALPGDKJ<LLLJCAGLDPN, AHAMAEENKGG, HECAJEGBBHJ> HFEGHDHCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x214EEF0", Offset = "0x214DAF0", VA = "0x18214EEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract EJJBJAKHFCE CCMHPPLNNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract FBCDAJNLMJL KJHKJIFMOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract PHOPNODOKFL FJLMPIJHFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract LEHCNNBDEIN JIKKOOCGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract MLEENANEIBN AEHFNGFBNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected KAGHJBIGEJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class PGGMDHIIMCN : MLKBBHIBLDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct KPPCNOOGOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public PGGMDHIIMCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AHAMAEENKGG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x214F210", Offset = "0x214DE10", VA = "0x18214F210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x214F4B0", Offset = "0x214E0B0", VA = "0x18214F4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct PKGLOLGOPGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public PGGMDHIIMCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public IReadOnlyList<AHAMAEENKGG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x21504F0", Offset = "0x214F0F0", VA = "0x1821504F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2150870", Offset = "0x214F470", VA = "0x182150870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private readonly DCHFDHOJOJI PMLNHAAKAKP;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public PGGMDHIIMCN(DCHFDHOJOJI HGJKJDPBMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2150290", Offset = "0x214EE90", VA = "0x182150290")]
	[AsyncStateMachine(typeof(KPPCNOOGOLE))]
	private Task<OAMIPODNNBO<object, BDMFJEIOIAD>> DCHOHHNANFG(AHAMAEENKGG FNGNLBJEBKM, bool DFCDOALJFOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x21503C0", Offset = "0x214EFC0", VA = "0x1821503C0", Slot = "4")]
	[AsyncStateMachine(typeof(PKGLOLGOPGL))]
	public Task<OAMIPODNNBO<EEFEIIHMJDH, BDMFJEIOIAD>> OBFGLODBLBO(IReadOnlyList<AHAMAEENKGG> FCICDOOOFNC, bool DFCDOALJFOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct AGGFPOLNHLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	internal NIHGKAFEDPL<BDEFLKDAAPD, AHAMAEENKGG, MLCGNDGLPGL> AEENIKHNMFJ;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x21204E0", Offset = "0x211F0E0", VA = "0x1821204E0")]
	private AGGFPOLNHLI([In] NIHGKAFEDPL<BDEFLKDAAPD, AHAMAEENKGG, MLCGNDGLPGL> ADDMGHJAAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x214BAF0", Offset = "0x214A6F0", VA = "0x18214BAF0")]
	public static AGGFPOLNHLI LMDPPDEOAIA()
	{
		return default(AGGFPOLNHLI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class ENLBNMNNOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static NIHGKAFEDPL<BDEFLKDAAPD, AHAMAEENKGG, MLCGNDGLPGL> LGLOAFKDEKA(this AGGFPOLNHLI GMNCELIMKIF)
	{
		return default(NIHGKAFEDPL<BDEFLKDAAPD, AHAMAEENKGG, MLCGNDGLPGL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct MLCGNDGLPGL : HBJHEMLPGDJ.NHMOPANLNDJ<BDEFLKDAAPD, AHAMAEENKGG>
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x214F810", Offset = "0x214E410", VA = "0x18214F810", Slot = "5")]
	public AHAMAEENKGG HINBBFDILPN(BDEFLKDAAPD[] HEPKBGAOODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970")]
	public int HIEDPGHCNPG([In] BDEFLKDAAPD CHFJEIGACEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970", Slot = "4")]
	private int EDGEKMOHEPK([In] BDEFLKDAAPD KKGBMHECKEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct PACBFPGPOBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	internal AOBABHPKNDM<CICJJMHGIGO, AHAMAEENKGG, IBNBCFJAPDF> AEENIKHNMFJ;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x21204E0", Offset = "0x211F0E0", VA = "0x1821204E0")]
	private PACBFPGPOBK([In] AOBABHPKNDM<CICJJMHGIGO, AHAMAEENKGG, IBNBCFJAPDF> CNCLCIEBKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2150230", Offset = "0x214EE30", VA = "0x182150230")]
	public static PACBFPGPOBK LMDPPDEOAIA()
	{
		return default(PACBFPGPOBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class MCGEHANEFGD
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static AOBABHPKNDM<CICJJMHGIGO, AHAMAEENKGG, IBNBCFJAPDF> LGLOAFKDEKA(this PACBFPGPOBK GMNCELIMKIF)
	{
		return default(AOBABHPKNDM<CICJJMHGIGO, AHAMAEENKGG, IBNBCFJAPDF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct IBNBCFJAPDF : PKIJDFIGBNH.KFJPBOMAIHL<CICJJMHGIGO, AHAMAEENKGG>
{
	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970")]
	public int PMOPMGFBMIK([In] CICJJMHGIGO CHFJEIGACEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x214E620", Offset = "0x214D220", VA = "0x18214E620", Slot = "5")]
	public AHAMAEENKGG OPDECGOCDPC(CICJJMHGIGO[] IDACKIBEGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970", Slot = "4")]
	private int HCHKGJICPJN([In] CICJJMHGIGO CHFJEIGACEL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class CNLGFBNNFIF : BGGNEHOKNAC, HAJPGIFDCBG, BDMFJEIOIAD, OILOBAEJEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly OILOBAEJEDE? DGJEAMJNJGN;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public DLGFEAGPPBA OIFCJBLJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(DLGFEAGPPBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8866D0", VA = "0x180887AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override OILOBAEJEDE? HHJLGJBOHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x214BC60", Offset = "0x214A860", VA = "0x18214BC60", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x214BDE0", Offset = "0x214A9E0", VA = "0x18214BDE0")]
	private CNLGFBNNFIF(DLGFEAGPPBA CHCPEAEKFEB, OILOBAEJEDE? NNIIAIKBKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x214BBE0", Offset = "0x214A7E0", VA = "0x18214BBE0")]
	public static CNLGFBNNFIF EKMLEHMLPIJ(OILOBAEJEDE NNIIAIKBKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x214BD70", Offset = "0x214A970", VA = "0x18214BD70")]
	public static CNLGFBNNFIF KPLJDHOHGGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x214BB70", Offset = "0x214A770", VA = "0x18214BB70")]
	public static CNLGFBNNFIF ECJCDLIHDAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class GADKAJAHKGI
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7750", Offset = "0x2DF6350", VA = "0x182DF7750")]
	public static OAMIPODNNBO<TOk, HAJPGIFDCBG> KFJPLLHNOAN<TOk>([In] this OAMIPODNNBO<TOk, HAJPGIFDCBG> GMNCELIMKIF, OILOBAEJEDE NNIIAIKBKBN) where TOk : notnull
	{
		return default(OAMIPODNNBO<TOk, HAJPGIFDCBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7650", Offset = "0x2DF6250", VA = "0x182DF7650")]
	public static OAMIPODNNBO<TOk?, HAJPGIFDCBG?> HNFIMOMLIKH<TOk>([In] this OAMIPODNNBO<TOk, HAJPGIFDCBG> GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<TOk, HAJPGIFDCBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7560", Offset = "0x2DF6160", VA = "0x182DF7560")]
	public static OAMIPODNNBO<TOk?, HAJPGIFDCBG?> BCBNHPPOIBG<TOk>([In] this OAMIPODNNBO<TOk, HAJPGIFDCBG> GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<TOk, HAJPGIFDCBG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface EJJBJAKHFCE
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJKLDGNFDCP([In] OAMIPODNNBO<FKMCALNFICP, OILOBAEJEDE> CMNKPAFMHMO);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class LEAHDKHJIEE
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF8F0", Offset = "0x2ECE4F0", VA = "0x182ECF8F0")]
	public static bool JJKLDGNFDCP<TOk, TErr>(this EJJBJAKHFCE GMNCELIMKIF, [In] OAMIPODNNBO<TOk, TErr> CMNKPAFMHMO) where TOk : notnull where TErr : notnull, OILOBAEJEDE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface FBCDAJNLMJL
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	GHPFMNFEOLI NEJGDCPNOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface PHOPNODOKFL
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BEGECIPCEHP CCODKNBLINK(int NHMCIACLKHL);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public interface OOMHPGCGMMP
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface JPBJFJABMFC
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHHGPDHKGAH? BIIPCEMGPBA(FANMFDLLPNO<JOGIKJOJMKJ> GNIBHDFHNLO);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface PNEMIFCDKHA
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface BHHGPDHKGAH
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PNEMIFCDKHA? EELMGKDHBJB(FANMFDLLPNO<CHEBACDPPKC> LKDPLCCDGLK);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOMHPGCGMMP? PIDELKMKBOK(FANMFDLLPNO<JCAEKHBPEKE> NMHLEEGGHCF);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface LEHCNNBDEIN
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> AEFLDJMOBLL(string CABLCDOIFFL, string PDMONEGPHPK);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface MLEENANEIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPBJFJABMFC? DCIMJPMOIJI([In] DBMOGKNBCFK<IIHAEGFAHBG> LGPFJMIKGBN);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class FMKFEJLBLKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private struct MMJIGCJABGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int NAJFJJKNBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public KAKCODMKIFK? IBEJMGJCJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public KAKCODMKIFK? JMIILPLPAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public readonly List<AHAMAEENKGG> MCPDLCGONAG;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x214FAB0", Offset = "0x214E6B0", VA = "0x18214FAB0")]
		private MMJIGCJABGD(int MFJLAMOCOBC, KAKCODMKIFK? NJBHKBFMJIN, KAKCODMKIFK? DCNGBGBHACJ, List<AHAMAEENKGG> FCICDOOOFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x214F9F0", Offset = "0x214E5F0", VA = "0x18214F9F0")]
		public static MMJIGCJABGD LMDPPDEOAIA()
		{
			return default(MMJIGCJABGD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly NAKKOJICPNM<MMJIGCJABGD> OGLNOKOBAHB;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public static FMKFEJLBLKJ AAGIFLNDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x214BE20", Offset = "0x214AA20", VA = "0x18214BE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool OBACDGDNJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xBA1690", Offset = "0xBA0290", VA = "0x180BA1690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x214BE70", Offset = "0x214AA70", VA = "0x18214BE70")]
	public void CLJNAEFIEPO(KCOMFDLMGDL DCNGBGBHACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x214BF30", Offset = "0x214AB30", VA = "0x18214BF30")]
	public void ICHCCEDKDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x214C220", Offset = "0x214AE20", VA = "0x18214C220")]
	private static string? NOAIHLDGDAE([In] MMJIGCJABGD KCIJELELNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x214C660", Offset = "0x214B260", VA = "0x18214C660")]
	public FMKFEJLBLKJ()
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
