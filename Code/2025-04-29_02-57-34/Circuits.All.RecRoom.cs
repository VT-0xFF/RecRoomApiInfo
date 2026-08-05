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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x26C3480", Offset = "0x26C2880", VA = "0x1826C3480")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LJJLNABEAFK : IDisposable, IBAGLICGPPJ, IPFILNFKLDO, EGKKLAEAPMF, LJICKEDFFNG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IBNJLKGDKFB : OHEPGMCOLNP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int PEMLEIMKNGG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x26B9B90", Offset = "0x26B8F90", VA = "0x1826B9B90", Slot = "5")]
		public PMMJFDBILBO EGPGKGDLKPH(KJPNNIHKIBH.ONDMOAGPIPA BGLHIFBEGOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void HOOBCJLCCNC();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void NPEGNAFMJHF();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26B9D60", Offset = "0x26B9160", VA = "0x1826B9D60", Slot = "13")]
		public virtual void NJFKMBLNDOH(LJJLNABEAFK IOJHPNJDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x26B9CE0", Offset = "0x26B90E0", VA = "0x1826B9CE0", Slot = "14")]
		public virtual void HNLDCCCGMII(LJJLNABEAFK IOJHPNJDEEC, MEKIHADOGMJ PDHMHKIHKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		protected IBNJLKGDKFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OHEPGMCOLNP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PEMLEIMKNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PMMJFDBILBO EGPGKGDLKPH(KJPNNIHKIBH.ONDMOAGPIPA BGLHIFBEGOD);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HOOBCJLCCNC();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NPEGNAFMJHF();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NJFKMBLNDOH(LJJLNABEAFK IOJHPNJDEEC);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HNLDCCCGMII(LJJLNABEAFK IOJHPNJDEEC, MEKIHADOGMJ PDHMHKIHKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JIIAFIGPKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IGMDGJHNAKG<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> CLNJNKIAKKK;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x26BAAA0", Offset = "0x26B9EA0", VA = "0x1826BAAA0")]
		internal JIIAFIGPKJF(IGMDGJHNAKG<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> GDOONENKGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class CEOMCOOKCLG : DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly CEOMCOOKCLG IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		private CEOMCOOKCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA8C7C0", Offset = "0xA8BBC0", VA = "0x180A8C7C0", Slot = "4")]
		public MPNDOKPDCHB PELEDOLKKGF(MEKIHADOGMJ KBBJDOAJMAF)
		{
			return default(MPNDOKPDCHB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x26B39D0", Offset = "0x26B2DD0", VA = "0x1826B39D0", Slot = "5")]
		public void NJFKMBLNDOH(LJJLNABEAFK DGFFJNKGDJD, MEKIHADOGMJ PDHMHKIHKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x26B38C0", Offset = "0x26B2CC0", VA = "0x1826B38C0", Slot = "6")]
		public void HNLDCCCGMII(LJJLNABEAFK DGFFJNKGDJD, MEKIHADOGMJ PDHMHKIHKPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NLCBCFOMPLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JDHPDAPAGED<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> CLNJNKIAKKK;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x26C3470", Offset = "0x26C2870", VA = "0x1826C3470")]
		internal NLCBCFOMPLI(JDHPDAPAGED<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x26C3420", Offset = "0x26C2820", VA = "0x1826C3420")]
		public static NLCBCFOMPLI FABCCGGAHMJ()
		{
			return default(NLCBCFOMPLI);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct KEHAGOPAHLK : FIOMGIHMKCL.AFCAGPJONCB<MEKIHADOGMJ, LJJLNABEAFK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BHFPMIHDHED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<object?, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public LJJLNABEAFK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MEKIHADOGMJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KEHAGOPAHLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<BECHBBIPIFM<object?, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x26B34C0", Offset = "0x26B28C0", VA = "0x1826B34C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x26B36A0", Offset = "0x26B2AA0", VA = "0x1826B36A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA67F60", Offset = "0xA67360", VA = "0x180A67F60", Slot = "4")]
		public JHLAGGIINPD<FFKEAHELAHD> CIKBMOFEDKC(LJJLNABEAFK JKOBGLOJMAJ)
		{
			return default(JHLAGGIINPD<FFKEAHELAHD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26BB4F0", Offset = "0x26BA8F0", VA = "0x1826BB4F0", Slot = "5")]
		public void HPGFEOBNAML(LJJLNABEAFK JKOBGLOJMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x26BB570", Offset = "0x26BA970", VA = "0x1826BB570", Slot = "6")]
		[AsyncStateMachine(typeof(BHFPMIHDHED))]
		public Task<BECHBBIPIFM<object, FFKOEKDBPON>> KNJOFGLIDKC(LJJLNABEAFK JKOBGLOJMAJ, MEKIHADOGMJ PDHMHKIHKPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x26BB550", Offset = "0x26BA950", VA = "0x1826BB550", Slot = "7")]
		public MEKIHADOGMJ[] IMJBGFPGEFI(LJJLNABEAFK JKOBGLOJMAJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KBPBBFBIPJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<bool, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LJJLNABEAFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<BECHBBIPIFM<bool, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x26BAD50", Offset = "0x26BA150", VA = "0x1826BAD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x26BAFE0", Offset = "0x26BA3E0", VA = "0x1826BAFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PAFBHDIJFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LJJLNABEAFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x26C3E20", Offset = "0x26C3220", VA = "0x1826C3E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x26C4000", Offset = "0x26C3400", VA = "0x1826C4000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ALFNLLMACEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object?, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public LJJLNABEAFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public MEKIHADOGMJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<BECHBBIPIFM<object?, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x26B3260", Offset = "0x26B2660", VA = "0x1826B3260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x26B3450", Offset = "0x26B2850", VA = "0x1826B3450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JHLAGGIINPD<FFKEAHELAHD> HHGMLHLHIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JIIAFIGPKJF KLOPPKLKDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ILEBHHLFGHB KABEGJPAKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly NBNKDGDKEGO PKKKGPEKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B58")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly KKBHJHOOKPD GDNAIFMFDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LLLBPLEIMIJ.PNFDHJCONFF KPMNALBAALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B88")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JJEIOBCFPBB DPALAJHLCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B90")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly FFEHNAIDJCB FPIAIALGIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B98")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly KPEDOALNEIF BEFMFOHKNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly OFJLKGHEFDP MELMNGHOMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DLJOFELEGFC KOKLCOJNNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GPNAFOAEJGE BGOJNELLHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly ILEBHHLFGHB.HGENGJHJGBD AEACPABLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BE0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly OJMDILOCDLB JBPKAFCMAJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ILEBHHLFGHB FJALGONGHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26BDC40", Offset = "0x26BD040", VA = "0x1826BDC40")]
		get
		{
			return default(ILEBHHLFGHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal OHEPGMCOLNP HDFHODCAMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26BD450", Offset = "0x26BC850", VA = "0x1826BD450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PMMJFDBILBO NDILDNMMIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x26BD590", Offset = "0x26BC990", VA = "0x1826BD590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26BCBE0", Offset = "0x26BBFE0", VA = "0x1826BCBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool GGBHNPHMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x26BD5A0", Offset = "0x26BC9A0", VA = "0x1826BD5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x26BD990", Offset = "0x26BCD90", VA = "0x1826BD990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IJMBHCBHIEJ NJAAEECIMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x26BE0C0", Offset = "0x26BD4C0", VA = "0x1826BE0C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LBCOCDPPOFL MCMIHLBJADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x26BE0D0", Offset = "0x26BD4D0", VA = "0x1826BE0D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DMEECILJNLE CEFDCEKOOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x26BE0F0", Offset = "0x26BD4F0", VA = "0x1826BE0F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ECJMBHDFOKO IGGCLINOAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x26BE0E0", Offset = "0x26BD4E0", VA = "0x1826BE0E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LLLBPLEIMIJ? MEILKCJDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x26BDC50", Offset = "0x26BD050", VA = "0x1826BDC50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PJHDAEHNDPE? NKOAHNBELOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x26BCAB0", Offset = "0x26BBEB0", VA = "0x1826BCAB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26BDDC0", Offset = "0x26BD1C0", VA = "0x1826BDDC0")]
	private LJJLNABEAFK(KKBHJHOOKPD DMMOIDHGCMK, JHLAGGIINPD<FFKEAHELAHD> FIFFOHPGPDL, [In] JIIAFIGPKJF MBPMIPCMAOD, [In] ILEBHHLFGHB OEJAHKGDBEL, [In] NBNKDGDKEGO OGJFKNNJOAJ, PMMJFDBILBO OLLPMBMHEHI, [In] LLLBPLEIMIJ.PNFDHJCONFF PDGDFCNIKIG, ILEBHHLFGHB.HGENGJHJGBD AAACJGEGMEP, OJMDILOCDLB AOAINMPBBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26BD310", Offset = "0x26BC710", VA = "0x1826BD310")]
	public static LJJLNABEAFK FABCCGGAHMJ(KKBHJHOOKPD BGLHIFBEGOD, [In] KGHIAJBLLMH KJEHMMEJCLK, KDFMPIMJNFI JHAODFPAJAO, [In] JHGNJEKFEEP IIKCHMDOIEG, LBKAIHNDOKA JAODIJGAJCF, JHLAGGIINPD<FFKEAHELAHD> FIFFOHPGPDL, JHLAGGIINPD<PFMHIGGGJBF> LINNGIMGDAB, FDABGINDJJA GBMFHBEGEFM, ALKCBPMBCHC HOLEACIIDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26BD000", Offset = "0x26BC400", VA = "0x1826BD000")]
	public static LJJLNABEAFK FABCCGGAHMJ(KKBHJHOOKPD DMMOIDHGCMK, [In] ILEBHHLFGHB OEJAHKGDBEL, [In] NBNKDGDKEGO OGJFKNNJOAJ, JHLAGGIINPD<FFKEAHELAHD> FIFFOHPGPDL, JHLAGGIINPD<PFMHIGGGJBF> LINNGIMGDAB, FDABGINDJJA GBMFHBEGEFM, ALKCBPMBCHC HOLEACIIDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26BCC00", Offset = "0x26BC000", VA = "0x1826BCC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26BC9C0", Offset = "0x26BBDC0", VA = "0x1826BC9C0")]
	[AsyncStateMachine(typeof(KBPBBFBIPJC))]
	public Task<BECHBBIPIFM<bool, FFKOEKDBPON>> AIKBNMGPFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26BDCD0", Offset = "0x26BD0D0", VA = "0x1826BDCD0")]
	[AsyncStateMachine(typeof(PAFBHDIJFDM))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> PMDIMDIJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26BCDF0", Offset = "0x26BC1F0", VA = "0x1826BCDF0")]
	internal void ECKNOECNPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26BD4A0", Offset = "0x26BC8A0", VA = "0x1826BD4A0")]
	internal JCEPLOKMLCO<MEKIHADOGMJ> FIDNBKPKFEF([In] NKPOEBOJMPD EAKMDPEMKOK)
	{
		return default(JCEPLOKMLCO<MEKIHADOGMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26BD520", Offset = "0x26BC920", VA = "0x1826BD520")]
	internal bool FOMGHHCFJPL([In] NKPOEBOJMPD EAKMDPEMKOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26BD9A0", Offset = "0x26BCDA0", VA = "0x1826BD9A0")]
	internal BECHBBIPIFM<MEKIHADOGMJ, FFKOEKDBPON> JCHKGEEFFJE([In] HFFHDMNMGNC EAFMOEDDHKI)
	{
		return default(BECHBBIPIFM<MEKIHADOGMJ, FFKOEKDBPON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26BD5B0", Offset = "0x26BC9B0", VA = "0x1826BD5B0")]
	private void HPGFEOBNAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26BDB30", Offset = "0x26BCF30", VA = "0x1826BDB30")]
	[AsyncStateMachine(typeof(ALFNLLMACEN))]
	internal Task<BECHBBIPIFM<object, FFKOEKDBPON>> JILJCHJKIAD(MEKIHADOGMJ PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26BD600", Offset = "0x26BCA00", VA = "0x1826BD600")]
	private MEKIHADOGMJ[] IMJBGFPGEFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DKPMMFHOCBN<TData> : IDMJKCLDJLO, MELNEKKLKAF, HAPFLJDLPEC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GKHNEBJMJEM<AIKGKILEHOL>? OJOFNAMJLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string FINCLBNLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData ODKGCMKKMAA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GKHNEBJMJEM<AIKGKILEHOL>? JDIEPHGNIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2930B80", Offset = "0x292FF80", VA = "0x182930B80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68E1E10", Offset = "0x68E1210", VA = "0x1868E1E10")]
	internal DKPMMFHOCBN([In] GKHNEBJMJEM<AIKGKILEHOL>? GOECDMOLIAE, JHLAGGIINPD<PCONLAGIHPE>? BFDCNGMFIOH, IOKind? BIACFBPGBCK, string FGEBHLNNMNH, [In] TData AOFGGGKINCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KDLIKBLCDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26BB050", Offset = "0x26BA450", VA = "0x1826BB050")]
	public static BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF> PFBPFFDJMGO([In] this BADJGHABOEF<CLCHFCFAMID> KCNMOPILLPO)
	{
		return default(BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3785150", Offset = "0x3784550", VA = "0x183785150")]
	public static BECHBBIPIFM<TOk, MELNEKKLKAF> CFKJOJGFMIM<TOk>([In] this BECHBBIPIFM<TOk, MELNEKKLKAF> KBBJDOAJMAF, [In] GKHNEBJMJEM<AIKGKILEHOL>? GOECDMOLIAE, JHLAGGIINPD<PCONLAGIHPE>? BFDCNGMFIOH, IOKind? BIACFBPGBCK, string FGEBHLNNMNH) where TOk : notnull
	{
		return default(BECHBBIPIFM<TOk, MELNEKKLKAF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KKBHJHOOKPD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	ADBGCEBAHGP.KEBEELDICCF AOODLEMGABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KJPNNIHKIBH.ONDMOAGPIPA KDIFAIPKMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LJJLNABEAFK.OHEPGMCOLNP JDFMAFJAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BFJFGICDBMB.FHINOFCPEOE PPDGMLJFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK> HBCBPEINEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DHEBDOCLJNA.CEFCHEPAGDP AFHPELAEKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PPPNMBLCMMH FBGHFLLJKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FGPBBLMONCG LMDLKAHHEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EHIHMPMFFMC DACLJBNMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BCEBBPJHFFP HDICCJHNFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IMBIBBDAGKI APAGKPLNEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FLCCGFPEEPO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26B66D0", Offset = "0x26B5AD0", VA = "0x1826B66D0")]
	public static MEKIHADOGMJ ADHCNGJNEGP(this MEKIHADOGMJ KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26B67E0", Offset = "0x26B5BE0", VA = "0x1826B67E0")]
	public static MEKIHADOGMJ BHHGDBABJNB(this MBJMDMCDBBI KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct MBJMDMCDBBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DFJBHHAFCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object?, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public LJJLNABEAFK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MBJMDMCDBBI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<BECHBBIPIFM<object?, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x26B3F10", Offset = "0x26B3310", VA = "0x1826B3F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26B41D0", Offset = "0x26B35D0", VA = "0x1826B41D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString APFNDOMNAPN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	private MBJMDMCDBBI(ByteString OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26BE2C0", Offset = "0x26BD6C0", VA = "0x1826BE2C0")]
	public static MEKIHADOGMJ JKOLNBCODCB(ByteString OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26BE100", Offset = "0x26BD500", VA = "0x1826BE100")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, MBJMDMCDBBI> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, MBJMDMCDBBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26BE1B0", Offset = "0x26BD5B0", VA = "0x1826BE1B0")]
	[AsyncStateMachine(typeof(DFJBHHAFCJI))]
	public static Task<BECHBBIPIFM<object, FFKOEKDBPON>> JILJCHJKIAD(LJJLNABEAFK DGFFJNKGDJD, MBJMDMCDBBI KBBJDOAJMAF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JNBGFNNNGEL
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26BACB0", Offset = "0x26BA0B0", VA = "0x1826BACB0")]
	public static MEKIHADOGMJ JKOLNBCODCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26BABC0", Offset = "0x26B9FC0", VA = "0x1826BABC0")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, JNBGFNNNGEL> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, JNBGFNNNGEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26BAC30", Offset = "0x26BA030", VA = "0x1826BAC30")]
	public static BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO> HALFAMCMEEJ(LJJLNABEAFK DGFFJNKGDJD, [In] JNBGFNNNGEL KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct AEOFHBFILPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HICEKHLJLKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LJJLNABEAFK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AEOFHBFILPI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x26B7870", Offset = "0x26B6C70", VA = "0x1826B7870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x26B7BE0", Offset = "0x26B6FE0", VA = "0x1826B7BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DGADMLPHDMP? JIICPEKJMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DGOMHNDAFIH? CBJDNBJHIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KPMJDHJBPEL? JIAOIEHKLFP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25E1080", Offset = "0x25E0480", VA = "0x1825E1080")]
	private AEOFHBFILPI(DGADMLPHDMP? GEDHHIAHIJI, DGOMHNDAFIH? FMKCIHIOIOE, KPMJDHJBPEL? PBNEIBAJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26A82A0", Offset = "0x26A76A0", VA = "0x1826A82A0")]
	public static MEKIHADOGMJ? JKOLNBCODCB(DGADMLPHDMP? GEDHHIAHIJI, DGOMHNDAFIH? FMKCIHIOIOE, KPMJDHJBPEL? PBNEIBAJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26A8050", Offset = "0x26A7450", VA = "0x1826A8050")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, AEOFHBFILPI> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, AEOFHBFILPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26A8160", Offset = "0x26A7560", VA = "0x1826A8160")]
	[AsyncStateMachine(typeof(HICEKHLJLKB))]
	public static Task<BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO>> JILJCHJKIAD(LJJLNABEAFK DGFFJNKGDJD, AEOFHBFILPI KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DLOCIAONAKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PBPMGEPMKIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DLOCIAONAKH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LJJLNABEAFK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BECHBBIPIFM<object?, HAPFLJDLPEC>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BECHBBIPIFM<object?, HAPFLJDLPEC> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BECHBBIPIFM<object?, HAPFLJDLPEC>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<BECHBBIPIFM<object?, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x26C4720", Offset = "0x26C3B20", VA = "0x1826C4720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x26C4B90", Offset = "0x26C3F90", VA = "0x1826C4B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<MEKIHADOGMJ> PICJFGFFGFL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	private DLOCIAONAKH(IReadOnlyList<MEKIHADOGMJ> BJHPHPBLMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26B4540", Offset = "0x26B3940", VA = "0x1826B4540")]
	public static MEKIHADOGMJ JKOLNBCODCB(IReadOnlyList<MEKIHADOGMJ> BJHPHPBLMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26B4360", Offset = "0x26B3760", VA = "0x1826B4360")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, DLOCIAONAKH> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, DLOCIAONAKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26B4400", Offset = "0x26B3800", VA = "0x1826B4400")]
	[AsyncStateMachine(typeof(PBPMGEPMKIM))]
	public static Task<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> JILJCHJKIAD(LJJLNABEAFK DGFFJNKGDJD, DLOCIAONAKH KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HFFHDMNMGNC
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class FFGPLMNDAGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HAPEPNJDIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GKHNEBJMJEM<FFGPLMNDAGD> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HAPEPNJDIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26B7170", Offset = "0x26B6570", VA = "0x1826B7170")]
		internal MEKIHADOGMJ LLLNEPOODKE(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly GKHNEBJMJEM<FFGPLMNDAGD> AOBMAEACIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int FBDCOBNEAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int PINFDPDNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] ODKGCMKKMAA;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26B7850", Offset = "0x26B6C50", VA = "0x1826B7850")]
	private HFFHDMNMGNC(GKHNEBJMJEM<FFGPLMNDAGD> KJBFEDBOMPG, int PCGLBCNIEAP, int COPLIEINKOF, byte[] AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26B7630", Offset = "0x26B6A30", VA = "0x1826B7630")]
	public static MEKIHADOGMJ JKOLNBCODCB(GKHNEBJMJEM<FFGPLMNDAGD> KJBFEDBOMPG, int PCGLBCNIEAP, int COPLIEINKOF, ByteString AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26B7740", Offset = "0x26B6B40", VA = "0x1826B7740")]
	public static MEKIHADOGMJ[] LNKHGGKDCND(MEKIHADOGMJ PDHMHKIHKPF, int FACKHILDKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26B7340", Offset = "0x26B6740", VA = "0x1826B7340")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, HFFHDMNMGNC> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, HFFHDMNMGNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26B7490", Offset = "0x26B6890", VA = "0x1826B7490")]
	public static BECHBBIPIFM<MEKIHADOGMJ, FFKOEKDBPON> HALFAMCMEEJ(LJJLNABEAFK DGFFJNKGDJD, [In] HFFHDMNMGNC KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<MEKIHADOGMJ, FFKOEKDBPON>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct NKPOEBOJMPD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PAOHDCGMGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<bool, BCMJKIOOIBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LJJLNABEAFK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NKPOEBOJMPD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private BECHBBIPIFM<bool, BCMJKIOOIBO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, BCMJKIOOIBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x26C4070", Offset = "0x26C3470", VA = "0x1826C4070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26C46B0", Offset = "0x26C3AB0", VA = "0x1826C46B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int FBDCOBNEAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int PINFDPDNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] ODKGCMKKMAA;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xBEB880", Offset = "0xBEAC80", VA = "0x180BEB880")]
	private NKPOEBOJMPD(int PCGLBCNIEAP, int COPLIEINKOF, byte[] AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26C3340", Offset = "0x26C2740", VA = "0x1826C3340")]
	public static MEKIHADOGMJ JKOLNBCODCB(int PCGLBCNIEAP, int COPLIEINKOF, ByteString AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26C3010", Offset = "0x26C2410", VA = "0x1826C3010")]
	public static MEKIHADOGMJ?[]? IAJEJDEBKAO(int FACKHILDKAH, DGADMLPHDMP? GEDHHIAHIJI, DGOMHNDAFIH? FMKCIHIOIOE, KPMJDHJBPEL? PBNEIBAJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26C2F30", Offset = "0x26C2330", VA = "0x1826C2F30")]
	public static AAGFGDLMNJI<MPNDOKPDCHB, NKPOEBOJMPD> BDBFJAGHJOB(MEKIHADOGMJ GLJOOLJOKEE)
	{
		return default(AAGFGDLMNJI<MPNDOKPDCHB, NKPOEBOJMPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26C3210", Offset = "0x26C2610", VA = "0x1826C3210")]
	[AsyncStateMachine(typeof(PAOHDCGMGIJ))]
	public static Task<BECHBBIPIFM<bool, BCMJKIOOIBO>> JILJCHJKIAD(LJJLNABEAFK DGFFJNKGDJD, NKPOEBOJMPD KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JJEIOBCFPBB : IJMBHCBHIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OBFJNODPLNE? IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26BAAB0", Offset = "0x26B9EB0", VA = "0x1826BAAB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	internal JJEIOBCFPBB(LJJLNABEAFK IOJHPNJDEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JECJABEPNHF : OBFJNODPLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GIDBJEAMJJD LGGIMAOOHMK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public JECJABEPNHF(LJJLNABEAFK IOJHPNJDEEC, GIDBJEAMJJD JGFAIOAKBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26BA4E0", Offset = "0x26B98E0", VA = "0x1826BA4E0", Slot = "4")]
	public BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF> AILENNEKHCC(GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<FAHJLKCNODD> ELDPAHOBCDC)
	{
		return default(BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26BA7C0", Offset = "0x26B9BC0", VA = "0x1826BA7C0", Slot = "5")]
	public BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF> GFKPBMIPNBI(GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<GLKJMBBFOIK> CIPHPJIJIKI)
	{
		return default(BECHBBIPIFM<DBHIIHIHICA, MELNEKKLKAF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ADBGCEBAHGP : HHLELMNMPOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface KEBEELDICCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GIDBJEAMJJD> PBBOKADHLCP(LJJLNABEAFK IOJHPNJDEEC, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM, CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LLGLIPKDJHJ DCEAOKECBBP(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class KNGDBFCNFOA : KEBEELDICCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct ODOFMGJLCDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<GIDBJEAMJJD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public LJJLNABEAFK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DGOMHNDAFIH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public KPMJDHJBPEL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<BFJFGICDBMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x26C3500", Offset = "0x26C2900", VA = "0x1826C3500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x26C36D0", Offset = "0x26C2AD0", VA = "0x1826C36D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly KNGDBFCNFOA IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		private KNGDBFCNFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26BC7E0", Offset = "0x26BBBE0", VA = "0x1826BC7E0", Slot = "4")]
		[AsyncStateMachine(typeof(ODOFMGJLCDL))]
		public Task<GIDBJEAMJJD> PBBOKADHLCP(LJJLNABEAFK IOJHPNJDEEC, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM, CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26BC7C0", Offset = "0x26BBBC0", VA = "0x1826BC7C0", Slot = "5")]
		public LLGLIPKDJHJ DCEAOKECBBP(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FHKILIAAIJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<ADBGCEBAHGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public LJJLNABEAFK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DGOMHNDAFIH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KPMJDHJBPEL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DGADMLPHDMP evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private KEBEELDICCF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<GIDBJEAMJJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x26B6160", Offset = "0x26B5560", VA = "0x1826B6160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x26B6660", Offset = "0x26B5A60", VA = "0x1826B6660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GIDBJEAMJJD LGGIMAOOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LLGLIPKDJHJ EMMDPFAGPMB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LLLBPLEIMIJ MEILKCJDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26A7DD0", Offset = "0x26A71D0", VA = "0x1826A7DD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PJHDAEHNDPE PNNOGPFEHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x26A7F90", Offset = "0x26A7390", VA = "0x1826A7F90", Slot = "5")]
		get
		{
			return default(PJHDAEHNDPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JECJABEPNHF BHOGCJNFGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public LFBNNEGDDLI OKNODCDDJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xE88E90", Offset = "0xE88290", VA = "0x180E88E90")]
	private ADBGCEBAHGP(GIDBJEAMJJD JGFAIOAKBDM, LLGLIPKDJHJ HMIDLJJCLDH, JECJABEPNHF IAALGDDFNJB, LFBNNEGDDLI KIEHENGIKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26A7E20", Offset = "0x26A7220", VA = "0x1826A7E20")]
	[AsyncStateMachine(typeof(FHKILIAAIJI))]
	public static Task<ADBGCEBAHGP> MICGICOPDNP(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26A7D70", Offset = "0x26A7170", VA = "0x1826A7D70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KJPNNIHKIBH : PMMJFDBILBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface ONDMOAGPIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HHLELMNMPOM> MDCJPAFNDEH(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM, CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CMOBMPMCHIE();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LBEGHGCBLFH();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class FADJHHCHHLN : ONDMOAGPIPA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct FPFBEBBMMOC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<HHLELMNMPOM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public LJJLNABEAFK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public DGADMLPHDMP evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DGOMHNDAFIH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public KPMJDHJBPEL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<ADBGCEBAHGP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x26B68B0", Offset = "0x26B5CB0", VA = "0x1826B68B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x26B6BF0", Offset = "0x26B5FF0", VA = "0x1826B6BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D40", Offset = "0x26B5140", VA = "0x1826B5D40", Slot = "4")]
		[AsyncStateMachine(typeof(FPFBEBBMMOC))]
		public Task<HHLELMNMPOM> MDCJPAFNDEH(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM, CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CMOBMPMCHIE();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LBEGHGCBLFH();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		protected FADJHHCHHLN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct GJJAKNDLJEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<HHLELMNMPOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KJPNNIHKIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<FGGPIMEAIEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x26B6F00", Offset = "0x26B6300", VA = "0x1826B6F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x26B7100", Offset = "0x26B6500", VA = "0x1826B7100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct ONFKPCDPBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KJPNNIHKIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LJJLNABEAFK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DGADMLPHDMP evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DGOMHNDAFIH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KPMJDHJBPEL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HHLELMNMPOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x26C3880", Offset = "0x26C2C80", VA = "0x1826C3880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x26C3DC0", Offset = "0x26C31C0", VA = "0x1826C3DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly ONDMOAGPIPA DGDPNOACCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<FGGPIMEAIEJ> PEFDEAOENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<FGGPIMEAIEJ> LHAFEAMFGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource PMGNAJENAFD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GGBHNPHMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FA0", Offset = "0x9F73A0", VA = "0x1809F7FA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D20", Offset = "0x9F7120", VA = "0x1809F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PJBCMDOMBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xD7C4C0", Offset = "0xD7B8C0", VA = "0x180D7C4C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x128A150", Offset = "0x1289550", VA = "0x18128A150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AIGJEJEFMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1957B30", Offset = "0x1956F30", VA = "0x181957B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x26BC5B0", Offset = "0x26BB9B0", VA = "0x1826BC5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HHLELMNMPOM? HGJJAAPGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26BC4C0", Offset = "0x26BB8C0", VA = "0x1826BC4C0", Slot = "7")]
	[AsyncStateMachine(typeof(GJJAKNDLJEP))]
	public Task<HHLELMNMPOM> NIAIOLAJKON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26BC5C0", Offset = "0x26BB9C0", VA = "0x1826BC5C0")]
	public KJPNNIHKIBH(ONDMOAGPIPA BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x26BC360", Offset = "0x26BB760", VA = "0x1826BC360", Slot = "8")]
	[AsyncStateMachine(typeof(ONFKPCDPBOI))]
	public Task LKGDLPDKPHK(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x26BC1E0", Offset = "0x26BB5E0", VA = "0x1826BC1E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LKFEOMCOGGL : LHHKHBJHNNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LFBNNEGDDLI FHGINFLECCE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public LKFEOMCOGGL(LFBNNEGDDLI KIEHENGIKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class IPONNNELGEK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class DICCPLJDILK<TGraph> : NDIEEALJBOE where TGraph : FLFGJJGPOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph GAJNBGENBOB;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual FDAHGAEDOCK? CAENJBOMJAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x17622C0", Offset = "0x17616C0", VA = "0x1817622C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual GKHNEBJMJEM<AIKGKILEHOL>? BPDBHKEFNMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x17622C0", Offset = "0x17616C0", VA = "0x1817622C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public JHLAGGIINPD<HHOOHPCIFEM> PCJAKAOPGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x68988D0", Offset = "0x6897CD0", VA = "0x1868988D0", Slot = "5")]
			get
			{
				return default(JHLAGGIINPD<HHOOHPCIFEM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JHLAGGIINPD<HHOOHPCIFEM>? ADMEIONFIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6898850", Offset = "0x6897C50", VA = "0x186898850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
		public DICCPLJDILK(TGraph OFGCJBCHPLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class FCIHJFFJJJP : DICCPLJDILK<AOPJBIBOMOF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override FDAHGAEDOCK? CAENJBOMJAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x26B6070", Offset = "0x26B5470", VA = "0x1826B6070", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override GKHNEBJMJEM<AIKGKILEHOL>? BPDBHKEFNMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x26B5FE0", Offset = "0x26B53E0", VA = "0x1826B5FE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x26B6090", Offset = "0x26B5490", VA = "0x1826B6090")]
		public FCIHJFFJJJP(AOPJBIBOMOF DJBKJGJEKGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x26BA350", Offset = "0x26B9750", VA = "0x1826BA350")]
	public static NDIEEALJBOE FABCCGGAHMJ(FLFGJJGPOAG OFGCJBCHPLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class MFENEFENMEA : NJDBDJALAMN, CNNBKJKIMPE, NCIDOMLJCOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KNFHMDIGKAP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public KNFHMDIGKAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public PPPNMBLCMMH errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x26C57D0", Offset = "0x26C4BD0", VA = "0x1826C57D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x26C5A40", Offset = "0x26C4E40", VA = "0x1826C5A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MFENEFENMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KNFHMDIGKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26BC6D0", Offset = "0x26BBAD0", VA = "0x1826BC6D0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task BFOJABPOIHB(PPPNMBLCMMH errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MBNOAEMMFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public MFENEFENMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x26BE380", Offset = "0x26BD780", VA = "0x1826BE380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x26BE890", Offset = "0x26BDC90", VA = "0x1826BE890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NGKEONPPCDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public NGKEONPPCDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x26C5AA0", Offset = "0x26C4EA0", VA = "0x1826C5AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x26C5D80", Offset = "0x26C5180", VA = "0x1826C5D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MFENEFENMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NGKEONPPCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x26C2E60", Offset = "0x26C2260", VA = "0x1826C2E60")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task BHBMFPEPIFH(PPPNMBLCMMH errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OFNAEBPFAHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public OFNAEBPFAHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x26C6300", Offset = "0x26C5700", VA = "0x1826C6300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x26C67B0", Offset = "0x26C5BB0", VA = "0x1826C67B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public MFENEFENMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OFNAEBPFAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x26C37B0", Offset = "0x26C2BB0", VA = "0x1826C37B0")]
		[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
		internal Task HOMCPAKHKGP(PPPNMBLCMMH errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BLJDJBFCNDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public BLJDJBFCNDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x26C5DE0", Offset = "0x26C51E0", VA = "0x1826C5DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x26C62A0", Offset = "0x26C56A0", VA = "0x1826C62A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public MFENEFENMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BLJDJBFCNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x26B3710", Offset = "0x26B2B10", VA = "0x1826B3710")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task EDPFEGMCDBM(PPPNMBLCMMH errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GMCELBBCPDH JKPLHPFFDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<MABAGIBBJIB> IHAGGJFKLGK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private KKBHJHOOKPD AIPJEAABAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x26BE9D0", Offset = "0x26BDDD0", VA = "0x1826BE9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public JHLAGGIINPD<FAHJLKCNODD> CCKPKHKFIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xECF790", Offset = "0xECEB90", VA = "0x180ECF790", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JHLAGGIINPD<FAHJLKCNODD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xECF770", Offset = "0xECEB70", VA = "0x180ECF770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private JHLAGGIINPD<JGBFKPDFGOJ> DCEFHKLHHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x12606D0", Offset = "0x125FAD0", VA = "0x1812606D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JHLAGGIINPD<ODIMEMELOCG> BNBNNBMLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1B90", Offset = "0x9F0F90", VA = "0x1809F1B90", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(JHLAGGIINPD<ODIMEMELOCG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override JHLAGGIINPD<PCONLAGIHPE> JOJBEHELKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x26BF0B0", Offset = "0x26BE4B0", VA = "0x1826BF0B0", Slot = "21")]
		get
		{
			return default(JHLAGGIINPD<PCONLAGIHPE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OENPGLAMLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x26C2010", Offset = "0x26C1410", VA = "0x1826C2010", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26C2710", Offset = "0x26C1B10", VA = "0x1826C2710")]
	private MFENEFENMEA(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO, GMCELBBCPDH CAMELOHLOLI, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<FAHJLKCNODD> ELDPAHOBCDC, JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB, bool COCAJCECLNF, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x26BF8B0", Offset = "0x26BECB0", VA = "0x1826BF8B0")]
	public static MFENEFENMEA FABCCGGAHMJ(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO, GMCELBBCPDH EOMFNMMGCEC, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB, JHLAGGIINPD<FAHJLKCNODD> ELDPAHOBCDC, bool COCAJCECLNF, bool BIHCMKDDNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x26BF810", Offset = "0x26BEC10", VA = "0x1826BF810", Slot = "22")]
	protected override void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x26BF3C0", Offset = "0x26BE7C0", VA = "0x1826BF3C0", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x26C2330", Offset = "0x26C1730", VA = "0x1826C2330", Slot = "31")]
	public void OMHHPKOGEBO(MABAGIBBJIB FAPPFBEHLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x26BECC0", Offset = "0x26BE0C0", VA = "0x1826BECC0", Slot = "28")]
	public void BOCPHKKAGAK(GNLANIPEMDN EHDIDFMGFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x26BFC60", Offset = "0x26BF060", VA = "0x1826BFC60", Slot = "29")]
	public void FECOCCIGMOJ(PLMIEOCFBMB JDOIHAMCPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x26C2400", Offset = "0x26C1800", VA = "0x1826C2400", Slot = "24")]
	protected override void PKKFGLCMKLF(IFNEMJOAEIG JMNGOOCABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26C1BB0", Offset = "0x26C0FB0", VA = "0x1826C1BB0", Slot = "33")]
	public string LIPFEGDFEEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x26C18E0", Offset = "0x26C0CE0", VA = "0x1826C18E0", Slot = "30")]
	public string LFICBMDBBNB(int CMOFODPGFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26C14F0", Offset = "0x26C08F0", VA = "0x1826C14F0")]
	private void KCNKBGKELJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26BE8F0", Offset = "0x26BDCF0", VA = "0x1826BE8F0", Slot = "32")]
	public void ADDDHNJJJDK(MABAGIBBJIB FAPPFBEHLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26C0D50", Offset = "0x26C0150", VA = "0x1826C0D50")]
	private void FJLNAFHDIIO(bool OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x26BF2A0", Offset = "0x26BE6A0", VA = "0x1826BF2A0", Slot = "34")]
	[AsyncStateMachine(typeof(MBNOAEMMFCM))]
	public Task DFCLKLPCINF(string OOEMJLHLIHJ, bool EBMNGJBHIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26C13A0", Offset = "0x26C07A0", VA = "0x1826C13A0")]
	public void JIHANNHLAKH(string OOEMJLHLIHJ, bool EBMNGJBHIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x26BF530", Offset = "0x26BE930", VA = "0x1826BF530")]
	private void EAHHMPIPNJP(int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x26C2550", Offset = "0x26C1950", VA = "0x1826C2550")]
	private void PLADLBNKJLH(int OOIDMMDPJHM, string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26C11D0", Offset = "0x26C05D0", VA = "0x1826C11D0")]
	private void IPHGIJECOHH(int OOIDMMDPJHM, string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x26C21E0", Offset = "0x26C15E0", VA = "0x1826C21E0")]
	private string OADAAOAMINK(int OOIDMMDPJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26C1E80", Offset = "0x26C1280", VA = "0x1826C1E80")]
	private string MJNHGPMKMBJ(int OOIDMMDPJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xECF770", Offset = "0xECEB70", VA = "0x180ECF770")]
	internal void DFAJKIEIOHL(JHLAGGIINPD<FAHJLKCNODD> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26BF3B0", Offset = "0x26BE7B0", VA = "0x1826BF3B0")]
	[CompilerGenerated]
	private void DHIDHKBLAKB(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x26BE9F0", Offset = "0x26BDDF0", VA = "0x1826BE9F0")]
	[CompilerGenerated]
	private bool AKOKBFAHBHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x26C0C20", Offset = "0x26C0020", VA = "0x1826C0C20")]
	[CompilerGenerated]
	private bool FGCMFDKHMIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26BEC70", Offset = "0x26BE070", VA = "0x1826BEC70")]
	[CompilerGenerated]
	private int BNNPBNMKKLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x26C1DF0", Offset = "0x26C11F0", VA = "0x1826C1DF0")]
	[CompilerGenerated]
	private bool MECJGHLAFBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x26C11C0", Offset = "0x26C05C0", VA = "0x1826C11C0")]
	[CompilerGenerated]
	private void IPGDCHGBNJK(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26C1D30", Offset = "0x26C1130", VA = "0x1826C1D30")]
	[CompilerGenerated]
	private bool LLKPPAKBLEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26C2390", Offset = "0x26C1790", VA = "0x1826C2390")]
	[CompilerGenerated]
	private bool PDJBFOLLHLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26C0F10", Offset = "0x26C0310", VA = "0x1826C0F10")]
	[CompilerGenerated]
	private bool GKEGNIPHMJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x26BEC70", Offset = "0x26BE070", VA = "0x1826BEC70")]
	[CompilerGenerated]
	private int JEBEDNIGDNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26C17A0", Offset = "0x26C0BA0", VA = "0x1826C17A0")]
	[CompilerGenerated]
	private bool KEOEDNKGNJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26BEBF0", Offset = "0x26BDFF0", VA = "0x1826BEBF0")]
	[CompilerGenerated]
	private object APMMIKCOJKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26BF030", Offset = "0x26BE430", VA = "0x1826BF030")]
	[CompilerGenerated]
	private void CJFKNOLAGLL(object OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x26BF6D0", Offset = "0x26BEAD0", VA = "0x1826BF6D0")]
	[CompilerGenerated]
	private bool ECGAHDONPLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x26C1720", Offset = "0x26C0B20", VA = "0x1826C1720")]
	[CompilerGenerated]
	private string KDDCCEEPFKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26C1070", Offset = "0x26C0470", VA = "0x1826C1070")]
	[CompilerGenerated]
	private void IFHEBNJCKIP(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26BF100", Offset = "0x26BE500", VA = "0x1826BF100")]
	[CompilerGenerated]
	private bool CNBIGBKDEIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26C1080", Offset = "0x26C0480", VA = "0x1826C1080")]
	[CompilerGenerated]
	private string IHAJMFELGFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x26C2090", Offset = "0x26C1490", VA = "0x1826C2090")]
	[CompilerGenerated]
	private void NABAMEJNDFE(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26BEAB0", Offset = "0x26BDEB0", VA = "0x1826BEAB0")]
	[CompilerGenerated]
	private bool AKPNAMGCKGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x26C0CE0", Offset = "0x26C00E0", VA = "0x1826C0CE0")]
	[CompilerGenerated]
	private string FJLLKDOGIGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x26C23F0", Offset = "0x26C17F0", VA = "0x1826C23F0")]
	[CompilerGenerated]
	private void PHKNLBPAOIF(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x26C0FA0", Offset = "0x26C03A0", VA = "0x1826C0FA0")]
	[CompilerGenerated]
	private bool HOADPKNMPKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26C1870", Offset = "0x26C0C70", VA = "0x1826C1870")]
	[CompilerGenerated]
	private string LFDCIKBNIJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x26BE9C0", Offset = "0x26BDDC0", VA = "0x1826BE9C0")]
	[CompilerGenerated]
	private void AEAIOPCKJFF(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x26C20A0", Offset = "0x26C14A0", VA = "0x1826C20A0")]
	[CompilerGenerated]
	private bool NAPEHKELBKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26C2170", Offset = "0x26C1570", VA = "0x1826C2170")]
	[CompilerGenerated]
	private string NJCFPMOAOOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26C23E0", Offset = "0x26C17E0", VA = "0x1826C23E0")]
	[CompilerGenerated]
	private void PEPLFJEFCLN(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x26BF1D0", Offset = "0x26BE5D0", VA = "0x1826BF1D0")]
	[CompilerGenerated]
	private bool DCOMNJOPLAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x26BEB80", Offset = "0x26BDF80", VA = "0x1826BEB80")]
	[CompilerGenerated]
	private string ALOHPHIIHML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x26C1390", Offset = "0x26C0790", VA = "0x1826C1390")]
	[CompilerGenerated]
	private void JFIGPJBFJNF(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26C10F0", Offset = "0x26C04F0", VA = "0x1826C10F0")]
	[CompilerGenerated]
	private bool INFMGMICJNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26BF7A0", Offset = "0x26BEBA0", VA = "0x1826BF7A0")]
	[CompilerGenerated]
	private string EGPPGMDFMLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26C1790", Offset = "0x26C0B90", VA = "0x1826C1790")]
	[CompilerGenerated]
	private void KDNPGGHPIHJ(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x26BF460", Offset = "0x26BE860", VA = "0x1826BF460")]
	[CompilerGenerated]
	private bool EAFODLPHOAC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EJACHAIGIHE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class IKKFNEJDDBA : CODCJNJKJKO<NKCEIEFPAMD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class EFCMIKEGPFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public IKKFNEJDDBA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EFCMIKEGPFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x26B4600", Offset = "0x26B3A00", VA = "0x1826B4600")]
			internal object CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x26B4670", Offset = "0x26B3A70", VA = "0x1826B4670")]
			internal void IFLMKALMDCI(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x26BA030", Offset = "0x26B9430", VA = "0x1826BA030")]
		public IKKFNEJDDBA(LJJLNABEAFK IOJHPNJDEEC, NKCEIEFPAMD GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x26B9DA0", Offset = "0x26B91A0", VA = "0x1826B9DA0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class MKFCCPEOCLO : GOJOFEGGGIC<GKBPLPDMADO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override LNAGEALNDID DJIMGDPEGHD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBA6200", Offset = "0xBA5600", VA = "0x180BA6200", Slot = "140")]
			get
			{
				return default(LNAGEALNDID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x26C2930", Offset = "0x26C1D30", VA = "0x1826C2930")]
		public MKFCCPEOCLO(LJJLNABEAFK IOJHPNJDEEC, GKBPLPDMADO GDOONENKGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KFPHDJFPABM : CODCJNJKJKO<CIHHOMJEPLM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x26BB9A0", Offset = "0x26BADA0", VA = "0x1826BB9A0")]
		public KFPHDJFPABM(LJJLNABEAFK IOJHPNJDEEC, CIHHOMJEPLM HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x26BB820", Offset = "0x26BAC20", VA = "0x1826BB820", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x26BB7D0", Offset = "0x26BABD0", VA = "0x1826BB7D0")]
		[CompilerGenerated]
		private bool MBFBDANAHFM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x26BB6A0", Offset = "0x26BAAA0", VA = "0x1826BB6A0")]
		[CompilerGenerated]
		private void DMLLOIACJIB(bool OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class CPMBJMGAILE : CODCJNJKJKO<POGFLBOFLDB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class PPBKLPHMIBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public CPMBJMGAILE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PPBKLPHMIBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C41D0", VA = "0x1826C4DD0")]
			internal void CHJJPNCJFNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x26C4E20", Offset = "0x26C4220", VA = "0x1826C4E20")]
			internal bool IFLMKALMDCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x26C4FF0", Offset = "0x26C43F0", VA = "0x1826C4FF0")]
			internal bool NNOHNDFMACB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x26C4EC0", Offset = "0x26C42C0", VA = "0x1826C4EC0")]
			internal void NHBCLOJHNJD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x26C4E70", Offset = "0x26C4270", VA = "0x1826C4E70")]
			internal bool IGGBJOKJGHG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x26B3EA0", Offset = "0x26B32A0", VA = "0x1826B3EA0")]
		public CPMBJMGAILE(LJJLNABEAFK IOJHPNJDEEC, POGFLBOFLDB HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x26B3B60", Offset = "0x26B2F60", VA = "0x1826B3B60", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class KIIJDGFNPFH : CODCJNJKJKO<AFBHBNLMDHI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class PPNCKKOJKCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public KIIJDGFNPFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PPNCKKOJKCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x26C5040", Offset = "0x26C4440", VA = "0x1826C5040")]
			internal object CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x26C5750", Offset = "0x26C4B50", VA = "0x1826C5750")]
			internal bool OJJEMDKOGEF(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x26C5140", Offset = "0x26C4540", VA = "0x1826C5140")]
			internal void IFLMKALMDCI(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x26C55E0", Offset = "0x26C49E0", VA = "0x1826C55E0")]
			internal string NNOHNDFMACB(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x26C5590", Offset = "0x26C4990", VA = "0x1826C5590")]
			internal IReadOnlyList<object> NHBCLOJHNJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x26C53A0", Offset = "0x26C47A0", VA = "0x1826C53A0")]
			internal bool IGGBJOKJGHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x26C5410", Offset = "0x26C4810", VA = "0x1826C5410")]
			internal bool KFBJFGNCNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x26C5460", Offset = "0x26C4860", VA = "0x1826C5460")]
			internal void NDBFHAMHJHE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x26BC170", Offset = "0x26BB570", VA = "0x1826BC170")]
		public KIIJDGFNPFH(LJJLNABEAFK IOJHPNJDEEC, AFBHBNLMDHI HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x26BBA10", Offset = "0x26BAE10", VA = "0x1826BBA10", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class NCOPMCDHAPH : CODCJNJKJKO<NHBKLOEJJIN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class PLIFJKBEMKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NCOPMCDHAPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PLIFJKBEMKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x26C4C00", Offset = "0x26C4000", VA = "0x1826C4C00")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x26C4C50", Offset = "0x26C4050", VA = "0x1826C4C50")]
			internal void IFLMKALMDCI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x26C4D80", Offset = "0x26C4180", VA = "0x1826C4D80")]
			internal bool NNOHNDFMACB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x26C2DF0", Offset = "0x26C21F0", VA = "0x1826C2DF0")]
		public NCOPMCDHAPH(LJJLNABEAFK IOJHPNJDEEC, NHBKLOEJJIN HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x26C2BC0", Offset = "0x26C1FC0", VA = "0x1826C2BC0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class CAKGEENOPOB<TNode> : CODCJNJKJKO<TNode> where TNode : notnull, NALONELNNEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct IIMPLFFLNPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CAKGEENOPOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4A63710", Offset = "0x4A62B10", VA = "0x184A63710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4A63B30", Offset = "0x4A62F30", VA = "0x184A63B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct OAOIKCKECBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CAKGEENOPOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x532E1A0", Offset = "0x532D5A0", VA = "0x18532E1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x532E5C0", Offset = "0x532D9C0", VA = "0x18532E5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool AJJCKNEAFLG
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override JHLAGGIINPD<CBLNHLFJAIK>? PCAJJFEPHCH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x637BE00", Offset = "0x637B200", VA = "0x18637BE00", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDABF0", Offset = "0x4ED9FF0", VA = "0x184EDABF0")]
		protected CAKGEENOPOB(LJJLNABEAFK IOJHPNJDEEC, TNode HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x637B9F0", Offset = "0x637ADF0", VA = "0x18637B9F0", Slot = "114")]
		[AsyncStateMachine(typeof(CAKGEENOPOB<>.IIMPLFFLNPJ))]
		public override Task<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> AIPKDLCHDME(string KCCMEIDBNGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x637BBB0", Offset = "0x637AFB0", VA = "0x18637BBB0", Slot = "138")]
		public sealed override bool CJFMHJBCPIJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x637BD60", Offset = "0x637B160", VA = "0x18637BD60", Slot = "126")]
		protected sealed override bool LFKPACKJAGI(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x637BB10", Offset = "0x637AF10", VA = "0x18637BB10", Slot = "127")]
		protected override bool CHECKGCAFBL(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x637BC50", Offset = "0x637B050", VA = "0x18637BC50", Slot = "115")]
		[AsyncStateMachine(typeof(CAKGEENOPOB<>.OAOIKCKECBL))]
		public override Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> GEGCJKEHJHJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class IPAPOPGFGJE : BGIPEPLCEKC<BKCMGLJELOM>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class FAHDENHGJJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public IPAPOPGFGJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FAHDENHGJJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x26B5EA0", Offset = "0x26B52A0", VA = "0x1826B5EA0")]
			internal bool EHCEIBDGJJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x26B5F20", Offset = "0x26B5320", VA = "0x1826B5F20")]
			internal void PCCJMGANGBM(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x26BA2F0", Offset = "0x26B96F0", VA = "0x1826BA2F0")]
		public IPAPOPGFGJE(LJJLNABEAFK IOJHPNJDEEC, BKCMGLJELOM GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x26BA0A0", Offset = "0x26B94A0", VA = "0x1826BA0A0", Slot = "140")]
		protected override void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class HBLAMFAOCLI : AENFDOKHDNJ<LDOIIBDEGIM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x26B72E0", Offset = "0x26B66E0", VA = "0x1826B72E0")]
		public HBLAMFAOCLI(LJJLNABEAFK IOJHPNJDEEC, LDOIIBDEGIM HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class AENFDOKHDNJ<TNode> : CODCJNJKJKO<TNode> where TNode : notnull, LHIJCKDKEHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct IFNBHCEHGKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4A52CF0", Offset = "0x4A520F0", VA = "0x184A52CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4A531B0", Offset = "0x4A525B0", VA = "0x184A531B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct AHFMJNEFOIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4BB9700", Offset = "0x4BB8B00", VA = "0x184BB9700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4BB9B90", Offset = "0x4BB8F90", VA = "0x184BB9B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct HCPCKGEACGH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4911530", Offset = "0x4910930", VA = "0x184911530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4911C10", Offset = "0x4911010", VA = "0x184911C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class NFEAIOHIKHA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public NFEAIOHIKHA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x3F4C500", Offset = "0x3F4B900", VA = "0x183F4C500", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public PGBGOAJGFEL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public NFEAIOHIKHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x5194390", Offset = "0x5193790", VA = "0x185194390")]
			internal bool NDBFHAMHJHE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x5193C80", Offset = "0x5193080", VA = "0x185193C80")]
			internal void CHJJPNCJFNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x5194470", Offset = "0x5193870", VA = "0x185194470")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.NFEAIOHIKHA.<<BuildConfigMenuInternal>b__7>d))]
			internal void OJJEMDKOGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x5193F80", Offset = "0x5193380", VA = "0x185193F80")]
			internal bool IFLMKALMDCI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class AOPCECPHGKK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public AOPCECPHGKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3F4C180", Offset = "0x3F4B580", VA = "0x183F4C180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public NFEAIOHIKHA CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AOPCECPHGKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4CA3E40", Offset = "0x4CA3240", VA = "0x184CA3E40")]
			internal void NNOHNDFMACB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			internal string NHBCLOJHNJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			internal void IGGBJOKJGHG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4CA3DA0", Offset = "0x4CA31A0", VA = "0x184CA3DA0")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.AOPCECPHGKK.<<BuildConfigMenuInternal>b__5>d))]
			internal void KFBJFGNCNJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class JDDALALLFJB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public JDDALALLFJB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x3F4BCB0", Offset = "0x3F4B0B0", VA = "0x183F4BCB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public JDDALALLFJB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<JGBFKPDFGOJ>, FFKOEKDBPON>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x3F4BE90", Offset = "0x3F4B290", VA = "0x183F4BE90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public JDDALALLFJB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<HEKBHBJIOHJ>, FFKOEKDBPON>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3F4B5E0", Offset = "0x3F4A9E0", VA = "0x183F4B5E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public PGBGOAJGFEL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public BLBBOINPFJE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public FBGLCEJBMBF selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public List<NKNJFPDOPHL> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public FBGLCEJBMBF selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public List<NKNJFPDOPHL> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public JDDALALLFJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4C84AC0", Offset = "0x4C83EC0", VA = "0x184C84AC0")]
			internal bool IDLOMGJFHBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4C84FF0", Offset = "0x4C843F0", VA = "0x184C84FF0")]
			internal void OLBNAHDBMHH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4C84BA0", Offset = "0x4C83FA0", VA = "0x184C84BA0")]
			internal bool KIDIKGPLLOF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4C84C80", Offset = "0x4C84080", VA = "0x184C84C80")]
			internal bool LGIPLCNGFDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4C84D80", Offset = "0x4C84180", VA = "0x184C84D80")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.JDDALALLFJB.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void MGONJKKBFFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4C84830", Offset = "0x4C83C30", VA = "0x184C84830")]
			internal bool DHLCGMDPEGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4C84CC0", Offset = "0x4C840C0", VA = "0x184C84CC0")]
			internal void LLPKKEKHEBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4C84F40", Offset = "0x4C84340", VA = "0x184C84F40")]
			internal bool NPKOLNHDCHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4C84E20", Offset = "0x4C84220", VA = "0x184C84E20")]
			internal void MIIABMLLKNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4C85060", Offset = "0x4C84460", VA = "0x184C85060")]
			internal bool PHMHADDKDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4C84870", Offset = "0x4C83C70", VA = "0x184C84870")]
			internal bool DHMMJAHMEOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4C84B30", Offset = "0x4C83F30", VA = "0x184C84B30")]
			internal void KFEKBHBDGIN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4C84790", Offset = "0x4C83B90", VA = "0x184C84790")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.JDDALALLFJB.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void DCMDMEKEPGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4C84EE0", Offset = "0x4C842E0", VA = "0x184C84EE0")]
			internal bool MPCKMPIGOOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4C849F0", Offset = "0x4C83DF0", VA = "0x184C849F0")]
			internal bool HJODPMMOADM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4C84980", Offset = "0x4C83D80", VA = "0x184C84980")]
			internal void GNHLGIKJCEE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4C848E0", Offset = "0x4C83CE0", VA = "0x184C848E0")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.JDDALALLFJB.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void EIPNDDLIGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4C84A60", Offset = "0x4C83E60", VA = "0x184C84A60")]
			internal bool HNJBOAJDPCD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class BHICAEFCLKI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public BHICAEFCLKI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x3F4B8D0", Offset = "0x3F4ACD0", VA = "0x183F4B8D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public JDDALALLFJB CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public BHICAEFCLKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5F95360", Offset = "0x5F94760", VA = "0x185F95360")]
			internal void GDPHIEEJDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			internal string BCAHMLBCGFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			internal void JBLMOKAELAA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5F95790", Offset = "0x5F94B90", VA = "0x185F95790")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.BHICAEFCLKI.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void HCEEHIBGIHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class BCNOAJFLPFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public BLBBOINPFJE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public List<NKNJFPDOPHL> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public AENFDOKHDNJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public BCNOAJFLPFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C9C0", Offset = "0x5E9BDC0", VA = "0x185E9C9C0")]
			internal bool LIKALNNEMEN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class MJGJIBGEOMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public NCIDOMLJCOM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public BCNOAJFLPFN CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public MJGJIBGEOMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x50CA300", Offset = "0x50C9700", VA = "0x1850CA300")]
			internal void NNDJMKJDDHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x50CA2B0", Offset = "0x50C96B0", VA = "0x1850CA2B0")]
			internal bool MOKJPGGCELM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x50CA190", Offset = "0x50C9590", VA = "0x1850CA190")]
			internal void AHKOCNCGHBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x50CA410", Offset = "0x50C9810", VA = "0x1850CA410")]
			internal bool OODONHPGPDD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class FAPJHLEACIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public NKNJFPDOPHL portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MJGJIBGEOMI CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FAPJHLEACIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x47C8250", Offset = "0x47C7650", VA = "0x1847C8250")]
			internal void OCGILEDBBJN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class HGDMDMJEJCH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public HGDMDMJEJCH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x3F4D980", Offset = "0x3F4CD80", VA = "0x183F4D980", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public FBGLCEJBMBF selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public BLBBOINPFJE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public NCIDOMLJCOM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public HGDMDMJEJCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4920C50", Offset = "0x4920050", VA = "0x184920C50")]
			internal int FGFANPGJPPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4920C90", Offset = "0x4920090", VA = "0x184920C90")]
			internal void JOBLLLOKMAL(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			internal string ODHIELOCMNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4920ED0", Offset = "0x49202D0", VA = "0x184920ED0")]
			[AsyncStateMachine(typeof(AENFDOKHDNJ<>.HGDMDMJEJCH.<<CreatePortItemV2>b__3>d))]
			internal void KCGIEGOFOOD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4920F90", Offset = "0x4920390", VA = "0x184920F90")]
			internal bool ONNPDBJENCO(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> ICFLLODOEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> ONOMMIBPJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> MJDIJCJMPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> OIICDPHKIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> KADNEJBKMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<JHLAGGIINPD<CBLNHLFJAIK>, bool> EGFKEDGPAPK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OJOCGLHKILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool FAALPOJCKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool BEKKNDLGEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool BOPBALIMJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override JHLAGGIINPD<HHOOHPCIFEM>? CCMHHBLPOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x48B57C0", Offset = "0x48B4BC0", VA = "0x1848B57C0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override JHLAGGIINPD<CBLNHLFJAIK>? PCAJJFEPHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x48B5AA0", Offset = "0x48B4EA0", VA = "0x1848B5AA0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>>? GEPGIMDOJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x48B5880", Offset = "0x48B4C80", VA = "0x1848B5880", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x48B55A0", Offset = "0x48B49A0", VA = "0x1848B55A0")]
		public AENFDOKHDNJ(LJJLNABEAFK IOJHPNJDEEC, TNode HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "143")]
		protected virtual bool PIJAABOPCAP(int FIGFPPHFCFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "144")]
		protected virtual bool NBKFODGCBIB(int FIGFPPHFCFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "145")]
		protected virtual bool OCJIJCLAEDE(int FIGFPPHFCFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "146")]
		protected virtual void NFCOKELKAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x48B0C40", Offset = "0x48B0040", VA = "0x1848B0C40", Slot = "138")]
		public override bool CJFMHJBCPIJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x48B0B20", Offset = "0x48AFF20", VA = "0x1848B0B20", Slot = "114")]
		[AsyncStateMachine(typeof(AENFDOKHDNJ<>.IFNBHCEHGKC))]
		public override Task<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> AIPKDLCHDME(string KCCMEIDBNGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x48B1E60", Offset = "0x48B1260", VA = "0x1848B1E60", Slot = "115")]
		[AsyncStateMachine(typeof(AENFDOKHDNJ<>.AHFMJNEFOIB))]
		public override Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> GEGCJKEHJHJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x48B3D10", Offset = "0x48B3110", VA = "0x1848B3D10", Slot = "116")]
		public override void NAHMGMOOLDA(JHLAGGIINPD<CBLNHLFJAIK> COPLIEINKOF, JHLAGGIINPD<CBLNHLFJAIK> EJCNBBIIFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x48B4890", Offset = "0x48B3C90", VA = "0x1848B4890", Slot = "117")]
		public override IEnumerable<MEKIHADOGMJ> PHOKCABMKDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x48B3A20", Offset = "0x48B2E20", VA = "0x1848B3A20")]
		[AsyncStateMachine(typeof(AENFDOKHDNJ<>.HCPCKGEACGH))]
		private Task<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> LFDBCACEADD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "147")]
		protected virtual bool KMFLACGLJFL(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "148")]
		protected virtual bool NCHMLIMGFOL(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "149")]
		protected virtual bool LKANHDEBJEM(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "150")]
		protected virtual bool LBPEELEJIMF(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "151")]
		protected virtual bool BFEGGEHEFDJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int EJHMFFJLMIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "152")]
		protected virtual bool LMHLCDHADNK(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int EJHMFFJLMIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "153")]
		protected virtual bool MDOLNEICNJO(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int IELJOCDCJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "154")]
		protected virtual bool HHJAAIGHHKP(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int IELJOCDCJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "155")]
		protected virtual bool DLAMJGFEGFC(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int DNDEDEPADFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "156")]
		protected virtual bool POLDNLBEAPN(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, int NAANDAAKIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x48B36F0", Offset = "0x48B2AF0", VA = "0x1848B36F0", Slot = "157")]
		protected virtual List<FBGLCEJBMBF> JDPFGGFNJNA(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "158")]
		protected virtual void EKNJGPGMGOD(PGBGOAJGFEL MDJCNEAGBFC, KPMOKBOHMCB OIHNFBEKBCC, BLBBOINPFJE CHMPLIKNGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x48B4B10", Offset = "0x48B3F10", VA = "0x1848B4B10", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x48B1F70", Offset = "0x48B1370", VA = "0x1848B1F70")]
		private KPMOKBOHMCB HGCHBJMKAPH(PGBGOAJGFEL MDJCNEAGBFC, BLBBOINPFJE CHMPLIKNGIL, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x48B0CE0", Offset = "0x48B00E0", VA = "0x1848B0CE0")]
		private List<NKNJFPDOPHL> EGHFKMLPBJK(PGBGOAJGFEL MDJCNEAGBFC, BLBBOINPFJE CHMPLIKNGIL, KPMOKBOHMCB LGFIJJDPNFK, bool KCOKOMAOHGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x48B3F30", Offset = "0x48B3330", VA = "0x1848B3F30")]
		private List<NKNJFPDOPHL> NKEMCPHCNHB(PGBGOAJGFEL MDJCNEAGBFC, BLBBOINPFJE CHMPLIKNGIL, NCIDOMLJCOM NELIGLJDGIK, bool KCOKOMAOHGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x48B3B20", Offset = "0x48B2F20", VA = "0x1848B3B20")]
		private FBGLCEJBMBF LOCANAGDIDD(List<FBGLCEJBMBF> AMGBODDLPDI, NCIDOMLJCOM NELIGLJDGIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x48B3990", Offset = "0x48B2D90", VA = "0x1848B3990")]
		[CompilerGenerated]
		private MEKIHADOGMJ JOCDCAMIGON(LIHPLMOAJJK DPBBAIABGAH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class NAKINIGPIAK : CODCJNJKJKO<IDIDMLNOONN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class BMKDAGMAOBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public NAKINIGPIAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public BMKDAGMAOBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x26B37E0", Offset = "0x26B2BE0", VA = "0x1826B37E0")]
			internal int CHJJPNCJFNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x26B3830", Offset = "0x26B2C30", VA = "0x1826B3830")]
			internal void IFLMKALMDCI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x26C2B50", Offset = "0x26C1F50", VA = "0x1826C2B50")]
		public NAKINIGPIAK(LJJLNABEAFK IOJHPNJDEEC, IDIDMLNOONN HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x26C2990", Offset = "0x26C1D90", VA = "0x1826C2990", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class GDHKMKJGFKE : BGIPEPLCEKC<BGBAHKNHHJE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class DIAENAPHLMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public GDHKMKJGFKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public DIAENAPHLMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x26B4240", Offset = "0x26B3640", VA = "0x1826B4240")]
			internal int EHCEIBDGJJE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x26B42C0", Offset = "0x26B36C0", VA = "0x1826B42C0")]
			internal void PCCJMGANGBM(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x26B6EA0", Offset = "0x26B62A0", VA = "0x1826B6EA0")]
		public GDHKMKJGFKE(LJJLNABEAFK IOJHPNJDEEC, BGBAHKNHHJE GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x26B6C60", Offset = "0x26B6060", VA = "0x1826B6C60", Slot = "140")]
		protected override void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class OFBNMLCKFFH : CODCJNJKJKO<FEAGMDNIKMG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xD55DE0", Offset = "0xD551E0", VA = "0x180D55DE0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x26C3740", Offset = "0x26C2B40", VA = "0x1826C3740")]
		public OFBNMLCKFFH(LJJLNABEAFK IOJHPNJDEEC, FEAGMDNIKMG HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class HIOCDGAHLNP : CODCJNJKJKO<LMKFGIBNOJD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class AKCNEPDDDEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public HIOCDGAHLNP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public PGBGOAJGFEL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AKCNEPDDDEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x26A8C00", Offset = "0x26A8000", VA = "0x1826A8C00")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x26B0F20", Offset = "0x26B0320", VA = "0x1826B0F20")]
			internal void IFLMKALMDCI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x26B0F80", Offset = "0x26B0380", VA = "0x1826B0F80")]
			internal bool IGGBJOKJGHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x26B1BF0", Offset = "0x26B0FF0", VA = "0x1826B1BF0")]
			internal bool KFBJFGNCNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x26B2680", Offset = "0x26B1A80", VA = "0x1826B2680")]
			internal void NDBFHAMHJHE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x26AF230", Offset = "0x26AE630", VA = "0x1826AF230")]
			internal bool DAMNDHOKCMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x26B3210", Offset = "0x26B2610", VA = "0x1826B3210")]
			internal bool PPGOEOENKAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x26AF3F0", Offset = "0x26AE7F0", VA = "0x1826AF3F0")]
			internal void DGPNJJKFKHD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x26B1C90", Offset = "0x26B1090", VA = "0x1826B1C90")]
			internal bool KHOLNKFPICJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x26B1210", Offset = "0x26B0610", VA = "0x1826B1210")]
			internal bool IOHCPDFHGHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x26AFB00", Offset = "0x26AEF00", VA = "0x1826AFB00")]
			internal void FFBONIDPKGM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x26B10D0", Offset = "0x26B04D0", VA = "0x1826B10D0")]
			internal bool IKMJHNPPECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x26A8D40", Offset = "0x26A8140", VA = "0x1826A8D40")]
			internal bool CJNGNCBDONA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x26B1DD0", Offset = "0x26B11D0", VA = "0x1826B1DD0")]
			internal bool KOMDLKAEJLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x26B2B30", Offset = "0x26B1F30", VA = "0x1826B2B30")]
			internal bool OJMIPOJHBOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x26AEFB0", Offset = "0x26AE3B0", VA = "0x1826AEFB0")]
			internal bool CNAFNLLDOOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x26B1800", Offset = "0x26B0C00", VA = "0x1826B1800")]
			internal bool JINGCIAEJLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x26B2310", Offset = "0x26B1710", VA = "0x1826B2310")]
			internal bool MCONKBNDCEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x26AF3A0", Offset = "0x26AE7A0", VA = "0x1826AF3A0")]
			internal bool DFMPPFAPJOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x26AFDB0", Offset = "0x26AF1B0", VA = "0x1826AFDB0")]
			internal bool FKHEBEAJLDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x26B0EC0", Offset = "0x26B02C0", VA = "0x1826B0EC0")]
			internal void IFGPDDNFNCJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x26B18C0", Offset = "0x26B0CC0", VA = "0x1826B18C0")]
			internal bool JJCKHOHPOAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x26AF890", Offset = "0x26AEC90", VA = "0x1826AF890")]
			internal bool EJIKPMLCPJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x26A8AB0", Offset = "0x26A7EB0", VA = "0x1826A8AB0")]
			internal bool CCFPHDBGGGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x26AFFF0", Offset = "0x26AF3F0", VA = "0x1826AFFF0")]
			internal bool FOELKDDFNGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x26B2E00", Offset = "0x26B2200", VA = "0x1826B2E00")]
			internal bool PBFFPPGPDPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x26AFA10", Offset = "0x26AEE10", VA = "0x1826AFA10")]
			internal bool EOPAEHNDIGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x26B2C60", Offset = "0x26B2060", VA = "0x1826B2C60")]
			internal bool ONHPKGJJEKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x26B3080", Offset = "0x26B2480", VA = "0x1826B3080")]
			internal bool PJINOGHMAKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x26B1F10", Offset = "0x26B1310", VA = "0x1826B1F10")]
			internal void LFGFJAPBCIJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x26B1EC0", Offset = "0x26B12C0", VA = "0x1826B1EC0")]
			internal bool LEMKFNHEABP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x26B1170", Offset = "0x26B0570", VA = "0x1826B1170")]
			internal bool INKPPFGLBDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x26B19C0", Offset = "0x26B0DC0", VA = "0x1826B19C0")]
			internal void JONBEGNCKMJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x26AF0A0", Offset = "0x26AE4A0", VA = "0x1826AF0A0")]
			internal bool CNOBCGABADN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x26B0810", Offset = "0x26AFC10", VA = "0x1826B0810")]
			internal bool HHIHGBNGLDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x26AF2D0", Offset = "0x26AE6D0", VA = "0x1826AF2D0")]
			internal void DFDLBNNADMN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x26A8E30", Offset = "0x26A8230", VA = "0x1826A8E30")]
			internal List<NKNJFPDOPHL> CLPCBAFEJLK(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x26A8700", Offset = "0x26A7B00", VA = "0x1826A8700")]
			internal bool ALJDBEAHOCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x26AF280", Offset = "0x26AE680", VA = "0x1826AF280")]
			internal int DEPBMJHFLMK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x26B1910", Offset = "0x26B0D10", VA = "0x1826B1910")]
			internal void JMHEJMGAEHD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x26A8450", Offset = "0x26A7850", VA = "0x1826A8450")]
			internal bool AGMNCICFDMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x26AFF50", Offset = "0x26AF350", VA = "0x1826AFF50")]
			internal bool FNFGLMDNGMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x26AF790", Offset = "0x26AEB90", VA = "0x1826AF790")]
			internal bool EAKDEADANFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x26A8B00", Offset = "0x26A7F00", VA = "0x1826A8B00")]
			internal int CFEMLOOEDOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x26A83F0", Offset = "0x26A77F0", VA = "0x1826A83F0")]
			internal void AENHHJCJNJI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x26AFA60", Offset = "0x26AEE60", VA = "0x1826AFA60")]
			internal bool FCMPMKPDJLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x26B21C0", Offset = "0x26B15C0", VA = "0x1826B21C0")]
			internal bool LOPDMFFLANJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x26B24A0", Offset = "0x26B18A0", VA = "0x1826B24A0")]
			internal bool MPGJNDHEJOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x26AFBB0", Offset = "0x26AEFB0", VA = "0x1826AFBB0")]
			internal bool FFHBNGMFOAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x26B0FD0", Offset = "0x26B03D0", VA = "0x1826B0FD0")]
			internal bool IJJKEEKNBEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x26AF840", Offset = "0x26AEC40", VA = "0x1826AF840")]
			internal bool EEIBGHIGPOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x26B2210", Offset = "0x26B1610", VA = "0x1826B2210")]
			internal string MABHIACIGFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x26AF720", Offset = "0x26AEB20", VA = "0x1826AF720")]
			internal void EABKKONDGKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x26AFC00", Offset = "0x26AF000", VA = "0x1826AFC00")]
			internal int FGEBFCJGIGM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x26B2440", Offset = "0x26B1840", VA = "0x1826B2440")]
			internal void MMBAMLMNOEN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x26B0660", Offset = "0x26AFA60", VA = "0x1826B0660")]
			internal bool GPKFDLEMMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x26B20D0", Offset = "0x26B14D0", VA = "0x1826B20D0")]
			internal bool LOHFLOPIBAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x26B2080", Offset = "0x26B1480", VA = "0x1826B2080")]
			internal bool LNPINAADIMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x26B0250", Offset = "0x26AF650", VA = "0x1826B0250")]
			internal float GCALEPNBBNF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x26AFE50", Offset = "0x26AF250", VA = "0x1826AFE50")]
			internal void FLHGINIHCIO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x26AFEB0", Offset = "0x26AF2B0", VA = "0x1826AFEB0")]
			internal bool FMBCPALOMPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x26B1970", Offset = "0x26B0D70", VA = "0x1826B1970")]
			internal bool JMJPKFHPBOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x26B0040", Offset = "0x26AF440", VA = "0x1826B0040")]
			internal bool FOILLIFLOPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x26B1300", Offset = "0x26B0700", VA = "0x1826B1300")]
			internal bool JDKDNOOJPEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x26A8860", Offset = "0x26A7C60", VA = "0x1826A8860")]
			internal bool APJCJMPCPKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x26B02F0", Offset = "0x26AF6F0", VA = "0x1826B02F0")]
			internal bool GFFMIMDFMAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x26B0900", Offset = "0x26AFD00", VA = "0x1826B0900")]
			internal void ICAELIGAOBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x26A85E0", Offset = "0x26A79E0", VA = "0x1826A85E0")]
			internal string AIKFCNIKAHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x26AF330", Offset = "0x26AE730", VA = "0x1826AF330")]
			internal void DFHEBCFCFBN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x26B30D0", Offset = "0x26B24D0", VA = "0x1826B30D0")]
			internal bool PLHNAJPCOHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x26B2EF0", Offset = "0x26B22F0", VA = "0x1826B2EF0")]
			internal bool PFFPJLAJIGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x26A84A0", Offset = "0x26A78A0", VA = "0x1826A84A0")]
			internal bool AHJIOCDLHBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x26B1490", Offset = "0x26B0890", VA = "0x1826B1490")]
			internal void JFLMFKGBBDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x26B26E0", Offset = "0x26B1AE0", VA = "0x1826B26E0")]
			internal bool NEGOKHCFPLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x26B2DB0", Offset = "0x26B21B0", VA = "0x1826B2DB0")]
			internal bool PACEJGHGDEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x26A89C0", Offset = "0x26A7DC0", VA = "0x1826A89C0")]
			internal bool BHKIKCFMJGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x26B05C0", Offset = "0x26AF9C0", VA = "0x1826B05C0")]
			internal bool GOFHMFJOLDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x26B2970", Offset = "0x26B1D70", VA = "0x1826B2970")]
			internal void OAMNBLGHEBG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x26B1E20", Offset = "0x26B1220", VA = "0x1826B1E20")]
			internal bool KOPGIIDBLIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x26A8A60", Offset = "0x26A7E60", VA = "0x1826A8A60")]
			internal bool CAPPIDGMHFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x26B2830", Offset = "0x26B1C30", VA = "0x1826B2830")]
			internal bool NMBODOFDFCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x26A8810", Offset = "0x26A7C10", VA = "0x1826A8810")]
			internal bool ANPEECIJMHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x26A8B50", Offset = "0x26A7F50", VA = "0x1826A8B50")]
			internal void CHBCMIGONHI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x26B17B0", Offset = "0x26B0BB0", VA = "0x1826B17B0")]
			internal bool JHKMBBPDGLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x26B2AE0", Offset = "0x26B1EE0", VA = "0x1826B2AE0")]
			internal bool OIAJFHJPLFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x26A8BB0", Offset = "0x26A7FB0", VA = "0x1826A8BB0")]
			internal bool CHHFINOIEJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x26B2A40", Offset = "0x26B1E40", VA = "0x1826B2A40")]
			internal bool OFBJMFELAPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x26B23D0", Offset = "0x26B17D0", VA = "0x1826B23D0")]
			internal object MKLDIJPGDJK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x26AF8E0", Offset = "0x26AECE0", VA = "0x1826AF8E0")]
			internal void EMGBPCJLNMJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x26AFD60", Offset = "0x26AF160", VA = "0x1826AFD60")]
			internal bool FKBGLFLJOGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x26AF450", Offset = "0x26AE850", VA = "0x1826AF450")]
			internal bool DIDONLBNDNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x26AFB60", Offset = "0x26AEF60", VA = "0x1826AFB60")]
			internal int FFCEHHCGGDM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x26A86A0", Offset = "0x26A7AA0", VA = "0x1826A86A0")]
			internal void ALGOCILFHFP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x26B1B00", Offset = "0x26B0F00", VA = "0x1826B1B00")]
			internal bool KBMGEFMJMPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x26B1020", Offset = "0x26B0420", VA = "0x1826B1020")]
			internal bool IJKPDONLPEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x26B02A0", Offset = "0x26AF6A0", VA = "0x1826B02A0")]
			internal int GDMJIEPIKCE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x26B22B0", Offset = "0x26B16B0", VA = "0x1826B22B0")]
			internal void MAIFEDLBGLC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x26A83A0", Offset = "0x26A77A0", VA = "0x1826A83A0")]
			internal bool AAGMCHBOCIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x26AFFA0", Offset = "0x26AF3A0", VA = "0x1826AFFA0")]
			internal bool FNKPAEIEBJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x26B2030", Offset = "0x26B1430", VA = "0x1826B2030")]
			internal bool LMKHKMBILGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x26B2D00", Offset = "0x26B2100", VA = "0x1826B2D00")]
			internal int OOCLOMCHFON()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x26B27D0", Offset = "0x26B1BD0", VA = "0x1826B27D0")]
			internal void NGMJGGKDFBC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x26AF620", Offset = "0x26AEA20", VA = "0x1826AF620")]
			internal bool DKHEBGEIOPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x26AF4A0", Offset = "0x26AE8A0", VA = "0x1826AF4A0")]
			internal bool DIJMFBLEIPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x26AEF60", Offset = "0x26AE360", VA = "0x1826AEF60")]
			internal bool CMLALOABAKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x26B0550", Offset = "0x26AF950", VA = "0x1826B0550")]
			internal object GODJFNKFGGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x26B2B80", Offset = "0x26B1F80", VA = "0x1826B2B80")]
			internal void OLKFGDGJPPK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x26B2170", Offset = "0x26B1570", VA = "0x1826B2170")]
			internal bool LOMOMOMOHMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x26B0500", Offset = "0x26AF900", VA = "0x1826B0500")]
			internal bool GOCBCIKHLCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x26B1F70", Offset = "0x26B1370", VA = "0x1826B1F70")]
			internal object LGFJHBBNBAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x26AF590", Offset = "0x26AE990", VA = "0x1826AF590")]
			internal void DJKAJOCHABI(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0E70", Offset = "0x26B0270", VA = "0x1826B0E70")]
			internal bool IEPOILOCGGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x26AF000", Offset = "0x26AE400", VA = "0x1826AF000")]
			internal int CNCHDHKMLJG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x26AF7E0", Offset = "0x26AEBE0", VA = "0x1826AF7E0")]
			internal void EDEFLMLICMM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x26B1B50", Offset = "0x26B0F50", VA = "0x1826B1B50")]
			internal bool KDGNIDCGOPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x26B25E0", Offset = "0x26B19E0", VA = "0x1826B25E0")]
			internal bool NAPDJMAHHMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x26B2880", Offset = "0x26B1C80", VA = "0x1826B2880")]
			internal bool NMFNGNNPHIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x26B0750", Offset = "0x26AFB50", VA = "0x1826B0750")]
			internal int HBPKCDKOFFB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x26B0090", Offset = "0x26AF490", VA = "0x1826B0090")]
			internal void FPAEEGGCAEH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x26B08B0", Offset = "0x26AFCB0", VA = "0x1826B08B0")]
			internal bool HLAIDGHILEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x26B2C10", Offset = "0x26B2010", VA = "0x1826B2C10")]
			internal bool OLMNEJBHHOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x26B2A90", Offset = "0x26B1E90", VA = "0x1826B2A90")]
			internal bool OHPGGILECMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x26A8C50", Offset = "0x26A8050", VA = "0x1826A8C50")]
			internal float CIAOGDODLKE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x26AF6C0", Offset = "0x26AEAC0", VA = "0x1826AF6C0")]
			internal void DOBNOGGCHBF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x26B1C40", Offset = "0x26B1040", VA = "0x1826B1C40")]
			internal bool KHJPDGNDFAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x26B2F40", Offset = "0x26B2340", VA = "0x1826B2F40")]
			internal bool PFGIAPDLACN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x26AF190", Offset = "0x26AE590", VA = "0x1826AF190")]
			internal bool CPFDGCFKLCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0D60", Offset = "0x26B0160", VA = "0x1826B0D60")]
			internal float IDGMLPJFMAL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x26B2D50", Offset = "0x26B2150", VA = "0x1826B2D50")]
			internal void OPOLLEILJDF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x26B0610", Offset = "0x26AFA10", VA = "0x1826B0610")]
			internal bool GPCPGKHDNGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x26B24F0", Offset = "0x26B18F0", VA = "0x1826B24F0")]
			internal bool MPGNEHDFELO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x26AF970", Offset = "0x26AED70", VA = "0x1826AF970")]
			internal string ENHLKIIOKON()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x26B07A0", Offset = "0x26AFBA0", VA = "0x1826B07A0")]
			internal void HHCIMHECPFP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x26B2120", Offset = "0x26B1520", VA = "0x1826B2120")]
			internal bool LOJMEKMBDPB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x26B1FE0", Offset = "0x26B13E0", VA = "0x1826B1FE0")]
			internal bool LJALNGOMFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x26B1760", Offset = "0x26B0B60", VA = "0x1826B1760")]
			internal bool JHGPKNMKIAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x26A8A10", Offset = "0x26A7E10", VA = "0x1826A8A10")]
			internal bool BIMKCEFHGCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x26AF140", Offset = "0x26AE540", VA = "0x1826AF140")]
			internal string CPFDBJOHJAL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x26B29D0", Offset = "0x26B1DD0", VA = "0x1826B29D0")]
			internal void OBGNMIDJDFA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x26B1D30", Offset = "0x26B1130", VA = "0x1826B1D30")]
			internal bool KMJCCCDGNNJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x26B31C0", Offset = "0x26B25C0", VA = "0x1826B31C0")]
			internal bool PNDFFICEHBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x26B13F0", Offset = "0x26B07F0", VA = "0x1826B13F0")]
			internal bool JFHJLBMHFPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x26AF4F0", Offset = "0x26AE8F0", VA = "0x1826AF4F0")]
			internal bool DJFPIFHGIPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x26A8CF0", Offset = "0x26A80F0", VA = "0x1826A8CF0")]
			internal string CJKIGFGPKKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x26B00F0", Offset = "0x26AF4F0", VA = "0x1826B00F0")]
			internal void FPGJLHBBBKB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x26B2540", Offset = "0x26B1940", VA = "0x1826B2540")]
			internal bool MPOPBJAFGLL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x26B1CE0", Offset = "0x26B10E0", VA = "0x1826B1CE0")]
			internal bool KJKLPABLMHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x26B2EA0", Offset = "0x26B22A0", VA = "0x1826B2EA0")]
			internal bool PFBMDEFNLPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x26B2CB0", Offset = "0x26B20B0", VA = "0x1826B2CB0")]
			internal bool OOAEBNJEMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x26B1350", Offset = "0x26B0750", VA = "0x1826B1350")]
			internal string JECACOFLGDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x26B1A20", Offset = "0x26B0E20", VA = "0x1826B1A20")]
			internal void KAAGHHHIGCJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x26B2FE0", Offset = "0x26B23E0", VA = "0x1826B2FE0")]
			internal bool PIJELOJEMDJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x26B0440", Offset = "0x26AF840", VA = "0x1826B0440")]
			internal bool GMBEKEIHAIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x26B0860", Offset = "0x26AFC60", VA = "0x1826B0860")]
			internal bool HKKDBFICCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x26B2260", Offset = "0x26B1660", VA = "0x1826B2260")]
			internal bool MACFNJILIKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x26AFAB0", Offset = "0x26AEEB0", VA = "0x1826AFAB0")]
			internal string FEMKELIIKMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x26B1850", Offset = "0x26B0C50", VA = "0x1826B1850")]
			internal void JINHHCMHDNF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x26B1120", Offset = "0x26B0520", VA = "0x1826B1120")]
			internal bool IMELBALDBFA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x26B3030", Offset = "0x26B2430", VA = "0x1826B3030")]
			internal bool PJDHGJMGNFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0340", Offset = "0x26AF740", VA = "0x1826B0340")]
			internal bool GKMOAIOADMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x26B1BA0", Offset = "0x26B0FA0", VA = "0x1826B1BA0")]
			internal bool KDKNPDLMKAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x26A8CA0", Offset = "0x26A80A0", VA = "0x1826A8CA0")]
			internal string CIKOFFPAHBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x26A87A0", Offset = "0x26A7BA0", VA = "0x1826A87A0")]
			internal void AMIEDEGNPCL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x26B12B0", Offset = "0x26B06B0", VA = "0x1826B12B0")]
			internal bool IPHOOKBOAHM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x26B3170", Offset = "0x26B2570", VA = "0x1826B3170")]
			internal bool PMPBFNJBMKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x26B2920", Offset = "0x26B1D20", VA = "0x1826B2920")]
			internal bool NPKDKEBDIAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x26B1440", Offset = "0x26B0840", VA = "0x1826B1440")]
			internal bool JFLIKDKJFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x26B0390", Offset = "0x26AF790", VA = "0x1826B0390")]
			internal string GKNENMBOOOH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x26A88B0", Offset = "0x26A7CB0", VA = "0x1826A88B0")]
			internal void BCHGLAGDJMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x26AFCA0", Offset = "0x26AF0A0", VA = "0x1826AFCA0")]
			internal bool FJALAKOANPG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x26A8DE0", Offset = "0x26A81E0", VA = "0x1826A8DE0")]
			internal bool CLDOIFMCPIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x26B1E70", Offset = "0x26B1270", VA = "0x1826B1E70")]
			internal bool LELMOBKJDCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x26A8D90", Offset = "0x26A8190", VA = "0x1826A8D90")]
			internal bool CKPIFAMKFKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x26AFC50", Offset = "0x26AF050", VA = "0x1826AFC50")]
			internal string FIINADNCDCN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x26A8630", Offset = "0x26A7A30", VA = "0x1826A8630")]
			internal void AKJGKBOJECG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x26AFF00", Offset = "0x26AF300", VA = "0x1826AFF00")]
			internal bool FNEFBLHIKHI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x26B0160", Offset = "0x26AF560", VA = "0x1826B0160")]
			internal bool GAKDOLJKHFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x26B2F90", Offset = "0x26B2390", VA = "0x1826B2F90")]
			internal bool PHBDJJEEAGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x26AF9C0", Offset = "0x26AEDC0", VA = "0x1826AF9C0")]
			internal bool EOIMIOIEPPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x26B3120", Offset = "0x26B2520", VA = "0x1826B3120")]
			internal string PMKIHPOFBAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x26B0E00", Offset = "0x26B0200", VA = "0x1826B0E00")]
			internal void IEHKNJIOFKO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x26A8590", Offset = "0x26A7990", VA = "0x1826A8590")]
			internal bool AIJPOMCOLGF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x26B13A0", Offset = "0x26B07A0", VA = "0x1826B13A0")]
			internal bool JECDGPHFFGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x26B01B0", Offset = "0x26AF5B0", VA = "0x1826B01B0")]
			internal bool GALKIGJBDJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x26AF670", Offset = "0x26AEA70", VA = "0x1826AF670")]
			internal bool DNENAILDFNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x26B2630", Offset = "0x26B1A30", VA = "0x1826B2630")]
			internal string NCBHEEHMOPC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x26AFCF0", Offset = "0x26AF0F0", VA = "0x1826AFCF0")]
			internal void FJDABOHBODC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x26B2E50", Offset = "0x26B2250", VA = "0x1826B2E50")]
			internal bool PEGEFKPEJNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x26AF050", Offset = "0x26AE450", VA = "0x1826AF050")]
			internal bool CNHGDDMAKCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x26B11C0", Offset = "0x26B05C0", VA = "0x1826B11C0")]
			internal bool IOGAEODNMIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x26A8540", Offset = "0x26A7940", VA = "0x1826A8540")]
			internal string AIFFKBIIPJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0490", Offset = "0x26AF890", VA = "0x1826B0490")]
			internal void GOBDEJBLMGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x26A84F0", Offset = "0x26A78F0", VA = "0x1826A84F0")]
			internal bool AIDKBLJCLHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x26B06B0", Offset = "0x26AFAB0", VA = "0x1826B06B0")]
			internal bool HAOBHBBJHKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x26B0200", Offset = "0x26AF600", VA = "0x1826B0200")]
			internal bool GBKNIMJJLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x26B2780", Offset = "0x26B1B80", VA = "0x1826B2780")]
			internal string NGABCLBDEAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x26B2360", Offset = "0x26B1760", VA = "0x1826B2360")]
			internal void MKDELLKFBOD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x26AF540", Offset = "0x26AE940", VA = "0x1826AF540")]
			internal bool DJIGKEACHEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x26B1D80", Offset = "0x26B1180", VA = "0x1826B1D80")]
			internal bool KOCDBIPHLKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x26AFE00", Offset = "0x26AF200", VA = "0x1826AFE00")]
			internal bool FKIBIHPOMFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x26B1260", Offset = "0x26B0660", VA = "0x1826B1260")]
			internal string IOKJJIGGECF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x26B1A90", Offset = "0x26B0E90", VA = "0x1826B1A90")]
			internal void KACDINCGNFH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x26B0DB0", Offset = "0x26B01B0", VA = "0x1826B0DB0")]
			internal bool IEBLFHKHLGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x26B28D0", Offset = "0x26B1CD0", VA = "0x1826B28D0")]
			internal bool NOPJLFGFLPK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x26B2590", Offset = "0x26B1990", VA = "0x1826B2590")]
			internal float NAEFFFMNFHO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x26B03E0", Offset = "0x26AF7E0", VA = "0x1826B03E0")]
			internal void GLLMLCBGJFC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x26A8920", Offset = "0x26A7D20", VA = "0x1826A8920")]
			internal bool BGBJOCPMBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0700", Offset = "0x26AFB00", VA = "0x1826B0700")]
			internal bool HBOBJLMAEHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x26B2730", Offset = "0x26B1B30", VA = "0x1826B2730")]
			internal bool NEOEGHLALMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x26AF0F0", Offset = "0x26AE4F0", VA = "0x1826AF0F0")]
			internal int COFJNNJBGAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x26B1070", Offset = "0x26B0470", VA = "0x1826B1070")]
			internal void IJOLFHPLIPM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x26AF1E0", Offset = "0x26AE5E0", VA = "0x1826AF1E0")]
			internal bool CPPKOMLMKFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x26A8750", Offset = "0x26A7B50", VA = "0x1826A8750")]
			internal bool ALOKLNIFLNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x26A8970", Offset = "0x26A7D70", VA = "0x1826A8970")]
			internal bool BHBMMKAMIDA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class EJDDNPNKMPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AKCNEPDDDEP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EJDDNPNKMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x26C97C0", Offset = "0x26C8BC0", VA = "0x1826C97C0")]
			internal void LPDGOGJBCCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class OCDLBNDHPKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public OCDLBNDHPKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x26DFDD0", Offset = "0x26DF1D0", VA = "0x1826DFDD0")]
			internal bool OODAPJACOIB(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly DNEOPCAKCHF IEHONGOFMDG;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x26B9A30", Offset = "0x26B8E30", VA = "0x1826B9A30")]
		public HIOCDGAHLNP(LJJLNABEAFK IOJHPNJDEEC, LMKFGIBNOJD HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x26B7C50", Offset = "0x26B7050", VA = "0x1826B7C50", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class MGHIMMFECAH : CODCJNJKJKO<OJGFLOHDHAB>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class PGKNLCJBAPG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public PGKNLCJBAPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x26E27F0", Offset = "0x26E1BF0", VA = "0x1826E27F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public MGHIMMFECAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PGKNLCJBAPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x26E1930", Offset = "0x26E0D30", VA = "0x1826E1930")]
			internal string CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x26E1980", Offset = "0x26E0D80", VA = "0x1826E1980")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IFLMKALMDCI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x26E1AE0", Offset = "0x26E0EE0", VA = "0x1826E1AE0")]
			internal int NNOHNDFMACB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x26E1A50", Offset = "0x26E0E50", VA = "0x1826E1A50")]
			internal void NHBCLOJHNJD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x26DE020", Offset = "0x26DD420", VA = "0x1826DE020")]
		public MGHIMMFECAH(LJJLNABEAFK IOJHPNJDEEC, OJGFLOHDHAB GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x26DDCC0", Offset = "0x26DD0C0", VA = "0x1826DDCC0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class LEDANIHEBAI : CODCJNJKJKO<JEIAMIPJEKG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class FFEAKHAJION
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public FFEAKHAJION <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x26E24B0", Offset = "0x26E18B0", VA = "0x1826E24B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public FFEAKHAJION <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x26E2B00", Offset = "0x26E1F00", VA = "0x1826E2B00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public LEDANIHEBAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FFEAKHAJION()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x26CB0C0", Offset = "0x26CA4C0", VA = "0x1826CB0C0")]
			internal string CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x26CB230", Offset = "0x26CA630", VA = "0x1826CB230")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IFLMKALMDCI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x26CB6C0", Offset = "0x26CAAC0", VA = "0x1826CB6C0")]
			internal int NNOHNDFMACB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x26CB5D0", Offset = "0x26CA9D0", VA = "0x1826CB5D0")]
			internal void NHBCLOJHNJD(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x26CB300", Offset = "0x26CA700", VA = "0x1826CB300")]
			internal string IGGBJOKJGHG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x26CB350", Offset = "0x26CA750", VA = "0x1826CB350")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void KFBJFGNCNJG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x26CB580", Offset = "0x26CA980", VA = "0x1826CB580")]
			internal bool NDBFHAMHJHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x26CB710", Offset = "0x26CAB10", VA = "0x1826CB710")]
			internal void OJJEMDKOGEF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x26CB530", Offset = "0x26CA930", VA = "0x1826CB530")]
			internal bool MPHDMECKOLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x26CB110", Offset = "0x26CA510", VA = "0x1826CB110")]
			internal void DAMNDHOKCMA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x26CB7A0", Offset = "0x26CABA0", VA = "0x1826CB7A0")]
			internal float PPGOEOENKAH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x26CB1A0", Offset = "0x26CA5A0", VA = "0x1826CB1A0")]
			internal void DGPNJJKFKHD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x26CB660", Offset = "0x26CAA60", VA = "0x1826CB660")]
			internal int NNFHECCEIJI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x26CB490", Offset = "0x26CA890", VA = "0x1826CB490")]
			internal void MHDIDMOMHEP(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x26CB420", Offset = "0x26CA820", VA = "0x1826CB420")]
			internal bool KHOLNKFPICJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x26D5A70", Offset = "0x26D4E70", VA = "0x1826D5A70")]
		public LEDANIHEBAI(LJJLNABEAFK IOJHPNJDEEC, JEIAMIPJEKG HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x26D5030", Offset = "0x26D4430", VA = "0x1826D5030", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class ENEMBEMKMLF : CODCJNJKJKO<LFKJGLOGMDA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class PHDPDGOJNLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public ENEMBEMKMLF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PHDPDGOJNLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x26E1B30", Offset = "0x26E0F30", VA = "0x1826E1B30")]
			internal Dictionary<string, BGKHLJCAAGH> CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x26E1BD0", Offset = "0x26E0FD0", VA = "0x1826E1BD0")]
			internal int IFLMKALMDCI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x26E1CA0", Offset = "0x26E10A0", VA = "0x1826E1CA0")]
			internal void NNOHNDFMACB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x26E1C20", Offset = "0x26E1020", VA = "0x1826E1C20")]
			internal bool NHBCLOJHNJD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x26CA7E0", Offset = "0x26C9BE0", VA = "0x1826CA7E0")]
		public ENEMBEMKMLF(LJJLNABEAFK IOJHPNJDEEC, LFKJGLOGMDA GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x26CA510", Offset = "0x26C9910", VA = "0x1826CA510", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class HJCEDIPFBNH : CODCJNJKJKO<MKBLBIFKLOO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class EIGJIIBCFDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public HJCEDIPFBNH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EIGJIIBCFDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x26C96B0", Offset = "0x26C8AB0", VA = "0x1826C96B0")]
			internal void CHJJPNCJFNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x26D3130", Offset = "0x26D2530", VA = "0x1826D3130")]
		public HJCEDIPFBNH(LJJLNABEAFK IOJHPNJDEEC, MKBLBIFKLOO GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x26D2FB0", Offset = "0x26D23B0", VA = "0x1826D2FB0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class NGDNDLDBAMB<TNode> : AENFDOKHDNJ<TNode> where TNode : notnull, DADLBHHCJCD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool LGHEDEGCNNG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LHGEAAAIPDP? AGLFBNPOIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x5198490", Offset = "0x5197890", VA = "0x185198490", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool KDKGAPBBCLM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x5198550", Offset = "0x5197950", VA = "0x185198550", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD69110", Offset = "0xD68510", VA = "0x180D69110", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5198510", Offset = "0x5197910", VA = "0x185198510")]
		public NGDNDLDBAMB(LJJLNABEAFK IOJHPNJDEEC, TNode HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class HBDAJHEODFB : NGDNDLDBAMB<GKDJJBIJMAE>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class GGOKJJBHPIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public HBDAJHEODFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public GGOKJJBHPIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x26CC160", Offset = "0x26CB560", VA = "0x1826CC160")]
			internal object CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x26CC1D0", Offset = "0x26CB5D0", VA = "0x1826CC1D0")]
			internal void IFLMKALMDCI(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x26CC2A0", Offset = "0x26CB6A0", VA = "0x1826CC2A0")]
			internal void NNOHNDFMACB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static object[]? OFMFLAGEEPA;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x26D2220", Offset = "0x26D1620", VA = "0x1826D2220")]
		public HBDAJHEODFB(LJJLNABEAFK IOJHPNJDEEC, GKDJJBIJMAE HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x26D1C60", Offset = "0x26D1060", VA = "0x1826D1C60", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class LJLCNDMODEB : CODCJNJKJKO<AEEDCNIKGAL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xC37440", Offset = "0xC36840", VA = "0x180C37440", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x26DD2E0", Offset = "0x26DC6E0", VA = "0x1826DD2E0")]
		public LJLCNDMODEB(LJJLNABEAFK IOJHPNJDEEC, AEEDCNIKGAL HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class MGJMJLFJEJK : CODCJNJKJKO<PIGBPBAKAJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xBA5E70", Offset = "0xBA5270", VA = "0x180BA5E70", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x26DE090", Offset = "0x26DD490", VA = "0x1826DE090")]
		public MGJMJLFJEJK(LJJLNABEAFK IOJHPNJDEEC, PIGBPBAKAJK HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "126")]
		protected override bool LFKPACKJAGI(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class JGPOBKHCKHL : CODCJNJKJKO<FBHNCCPLMFA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xB5D430", Offset = "0xB5C830", VA = "0x180B5D430", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool CHEGPOKINIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x26D41F0", Offset = "0x26D35F0", VA = "0x1826D41F0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool IGBFMNACKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x26D4180", Offset = "0x26D3580", VA = "0x1826D4180")]
		public JGPOBKHCKHL(LJJLNABEAFK IOJHPNJDEEC, FBHNCCPLMFA HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class HOOEAEOFIIE : CODCJNJKJKO<MBDCAOMHGDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xBA6200", Offset = "0xBA5600", VA = "0x180BA6200", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool CHEGPOKINIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x26D3750", Offset = "0x26D2B50", VA = "0x1826D3750", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool IGBFMNACKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x26D36E0", Offset = "0x26D2AE0", VA = "0x1826D36E0")]
		public HOOEAEOFIIE(LJJLNABEAFK IOJHPNJDEEC, MBDCAOMHGDJ HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class JLLBIJHIEEB : BGIPEPLCEKC<EKPBLFGMABG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class IENOMAEFCLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public JLLBIJHIEEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public IENOMAEFCLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x26D4060", Offset = "0x26D3460", VA = "0x1826D4060")]
			internal float EHCEIBDGJJE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x26D40E0", Offset = "0x26D34E0", VA = "0x1826D40E0")]
			internal void PCCJMGANGBM(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x26D4520", Offset = "0x26D3920", VA = "0x1826D4520")]
		public JLLBIJHIEEB(LJJLNABEAFK IOJHPNJDEEC, EKPBLFGMABG GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x26D42A0", Offset = "0x26D36A0", VA = "0x1826D42A0", Slot = "140")]
		protected override void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class HJCHHHNDHFP : CODCJNJKJKO<GIEDEDALBDN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class EMMPMNHBNMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public HJCHHHNDHFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EMMPMNHBNMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x26CA390", Offset = "0x26C9790", VA = "0x1826CA390")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x26CA3E0", Offset = "0x26C97E0", VA = "0x1826CA3E0")]
			internal void IFLMKALMDCI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x26D3450", Offset = "0x26D2850", VA = "0x1826D3450")]
		public HJCHHHNDHFP(LJJLNABEAFK IOJHPNJDEEC, GIEDEDALBDN GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x26D31A0", Offset = "0x26D25A0", VA = "0x1826D31A0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class LPCJCFOFMJD : CODCJNJKJKO<MPDFNBNEFCC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class FHMPIBCNJFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public LPCJCFOFMJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FHMPIBCNJFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x26CB810", Offset = "0x26CAC10", VA = "0x1826CB810")]
			internal object CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x26CBF50", Offset = "0x26CB350", VA = "0x1826CBF50")]
			internal bool OJJEMDKOGEF(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x26CB940", Offset = "0x26CAD40", VA = "0x1826CB940")]
			internal void IFLMKALMDCI(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x26CBDE0", Offset = "0x26CB1E0", VA = "0x1826CBDE0")]
			internal string NNOHNDFMACB(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x26CBD90", Offset = "0x26CB190", VA = "0x1826CBD90")]
			internal IReadOnlyList<object> NHBCLOJHNJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x26CBBA0", Offset = "0x26CAFA0", VA = "0x1826CBBA0")]
			internal bool IGGBJOKJGHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x26CBC10", Offset = "0x26CB010", VA = "0x1826CBC10")]
			internal bool KFBJFGNCNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x26CBC60", Offset = "0x26CB060", VA = "0x1826CBC60")]
			internal void NDBFHAMHJHE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x26DDB90", Offset = "0x26DCF90", VA = "0x1826DDB90")]
		public LPCJCFOFMJD(LJJLNABEAFK IOJHPNJDEEC, MPDFNBNEFCC GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x26DD350", Offset = "0x26DC750", VA = "0x1826DD350", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class MCOAGCGGJKC : CAKGEENOPOB<NOECMAKNDLH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD59BB0", Offset = "0xD58FB0", VA = "0x180D59BB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x26DDC00", Offset = "0x26DD000", VA = "0x1826DDC00")]
		public MCOAGCGGJKC(LJJLNABEAFK IOJHPNJDEEC, NOECMAKNDLH HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class OLJEADFLCDF : BGIPEPLCEKC<IDNBDOGMCAN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class KJMMGBGBNOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public OLJEADFLCDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public KJMMGBGBNOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x26D4AB0", Offset = "0x26D3EB0", VA = "0x1826D4AB0")]
			internal int EHCEIBDGJJE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x26D4B30", Offset = "0x26D3F30", VA = "0x1826D4B30")]
			internal void PCCJMGANGBM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x26E15B0", Offset = "0x26E09B0", VA = "0x1826E15B0")]
		public OLJEADFLCDF(LJJLNABEAFK IOJHPNJDEEC, IDNBDOGMCAN GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x26E1320", Offset = "0x26E0720", VA = "0x1826E1320", Slot = "140")]
		protected override void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class DILOOAFLGCK : CODCJNJKJKO<IJNAPKKFHMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class HLKBOGJEEGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public DILOOAFLGCK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public HLKBOGJEEGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x26D3530", Offset = "0x26D2930", VA = "0x1826D3530")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x26D3580", Offset = "0x26D2980", VA = "0x1826D3580")]
			internal void IFLMKALMDCI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x26C91D0", Offset = "0x26C85D0", VA = "0x1826C91D0")]
		public DILOOAFLGCK(LJJLNABEAFK IOJHPNJDEEC, IJNAPKKFHMJ GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x26C8FF0", Offset = "0x26C83F0", VA = "0x1826C8FF0", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class HHKGANBGGIK : CODCJNJKJKO<KOELGOMEKOK>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class LBCJBKGIMMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public HHKGANBGGIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public LBCJBKGIMMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x26D4C70", Offset = "0x26D4070", VA = "0x1826D4C70")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x26D4CC0", Offset = "0x26D40C0", VA = "0x1826D4CC0")]
			internal void IFLMKALMDCI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x26D2F40", Offset = "0x26D2340", VA = "0x1826D2F40")]
		public HHKGANBGGIK(LJJLNABEAFK IOJHPNJDEEC, KOELGOMEKOK GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x26D2D60", Offset = "0x26D2160", VA = "0x1826D2D60", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class LBKMDLGNLKL : CODCJNJKJKO<CNAGAACGKGL>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class FMBAPFHLPIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public LBKMDLGNLKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FMBAPFHLPIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x26CBFD0", Offset = "0x26CB3D0", VA = "0x1826CBFD0")]
			internal int CHJJPNCJFNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB420", VA = "0x1826CC020")]
			internal void IFLMKALMDCI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x26D4FC0", Offset = "0x26D43C0", VA = "0x1826D4FC0")]
		public LBKMDLGNLKL(LJJLNABEAFK IOJHPNJDEEC, CNAGAACGKGL GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x26D4D50", Offset = "0x26D4150", VA = "0x1826D4D50", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class OJALIIGKKFF : GOJOFEGGGIC<NGEKHAIBKNP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override LNAGEALNDID DJIMGDPEGHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "140")]
			get
			{
				return default(LNAGEALNDID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x26E0F40", Offset = "0x26E0340", VA = "0x1826E0F40")]
		public OJALIIGKKFF(LJJLNABEAFK IOJHPNJDEEC, NGEKHAIBKNP GDOONENKGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class HJECPIJEGIJ : CODCJNJKJKO<LIHPLMOAJJK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x26D34C0", Offset = "0x26D28C0", VA = "0x1826D34C0")]
		public HJECPIJEGIJ(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class CODCJNJKJKO<TNode> : MKBHMHJPFFJ, IDisposable where TNode : notnull, LIHPLMOAJJK
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class NKMNDEHFDAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public CODCJNJKJKO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public LJJLNABEAFK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public NKMNDEHFDAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x52241E0", Offset = "0x52235E0", VA = "0x1852241E0")]
			internal GLBOPFNNPEC PAPNJAOJFJE(BHNCBLCNPHC portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct CKOOLLMINNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public CODCJNJKJKO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x662D000", Offset = "0x662C400", VA = "0x18662D000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct KPOOGCNNDNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public CODCJNJKJKO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public LICKHDGKAMM? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public LKIBKIJNMNK? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B810", Offset = "0x4E1AC10", VA = "0x184E1B810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x4E1BAC0", Offset = "0x4E1AEC0", VA = "0x184E1BAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class CMABEDOBJFF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000095")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public CMABEDOBJFF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x3F4C710", Offset = "0x3F4BB10", VA = "0x183F4C710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public CODCJNJKJKO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public PGBGOAJGFEL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CMABEDOBJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			internal string PIFFHBBNAIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			internal void NHFCLMKFNOK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x66324E0", Offset = "0x66318E0", VA = "0x1866324E0")]
			[AsyncStateMachine(typeof(CODCJNJKJKO<>.CMABEDOBJFF.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void NFLLANGEJMO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class DPHKPNEBEKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public DPHKPNEBEKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x68F8500", Offset = "0x68F7900", VA = "0x1868F8500")]
			internal bool PBCEKOHMGLA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x68F84F0", Offset = "0x68F78F0", VA = "0x1868F84F0")]
			internal bool HMOLNJHEBPH(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct HFOPNJKHNEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public CODCJNJKJKO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x49204B0", Offset = "0x491F8B0", VA = "0x1849204B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x49207C0", Offset = "0x491FBC0", VA = "0x1849207C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly LJJLNABEAFK IAGNOONNNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly bool ADKAMDNIINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private JGMACDACEPK<CBLNHLFJAIK, GLBOPFNNPEC> NFIMHHFKBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private JGMACDACEPK<CBLNHLFJAIK, BLBBOINPFJE> KDOKOEDLAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private List<Action> IAKHFOFKADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<JHLAGGIINPD<CBLNHLFJAIK>>? FMPKGACBLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[CompilerGenerated]
		private Action<JHLAGGIINPD<CBLNHLFJAIK>, BLBBOINPFJE>? BPNOECBFLPB;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected OOKBLLNDPGF OKNODCDDJKL
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x6637CF0", Offset = "0x66370F0", VA = "0x186637CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected KIFFONIJAAE CHKOMOPDLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x66376B0", Offset = "0x6636AB0", VA = "0x1866376B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode NIADBHDFAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public GKHNEBJMJEM<LFIPNIKKFOL> ECPPPPMIMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x12C3A40", Offset = "0x12C2E40", VA = "0x1812C3A40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GKHNEBJMJEM<LFIPNIKKFOL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JHLAGGIINPD<PPBAIKDIKBC> NAJAEEPCDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x6639300", Offset = "0x6638700", VA = "0x186639300", Slot = "6")]
			get
			{
				return default(JHLAGGIINPD<PPBAIKDIKBC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object HGPAKJHEINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x43BAC70", Offset = "0x43BA070", VA = "0x1843BAC70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool JKALPMJCOFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int GCPEOPHCDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x6638F30", Offset = "0x6638330", VA = "0x186638F30", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MINJKFOIMDC FDDLKGKGOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x6638ED0", Offset = "0x66382D0", VA = "0x186638ED0", Slot = "10")]
			get
			{
				return default(MINJKFOIMDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string PMJIHHJFIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x6639520", Offset = "0x6638920", VA = "0x186639520", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool IGBFMNACKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public JHLAGGIINPD<OBPOAHBPHCP> MADGMHCDPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE1B1E0", Offset = "0xE1A5E0", VA = "0x180E1B1E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(JHLAGGIINPD<OBPOAHBPHCP>);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE1C480", Offset = "0xE1B880", VA = "0x180E1C480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool FDABJNOOMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool CHEGPOKINIP
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool LGHEDEGCNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual LLJJDLECFAF NBADLLNPBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xEFD190", Offset = "0xEFC590", VA = "0x180EFD190", Slot = "108")]
			get
			{
				return default(LLJJDLECFAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool DOBKEFBNAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x6638BE0", Offset = "0x6637FE0", VA = "0x186638BE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HBBPGHIPGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x6638C50", Offset = "0x6638050", VA = "0x186638C50", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MNAFIGKNGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x6638CC0", Offset = "0x66380C0", VA = "0x186638CC0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int OKHBKEMOCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x66392A0", Offset = "0x66386A0", VA = "0x1866392A0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool HCLHNGOLLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x66390C0", Offset = "0x66384C0", VA = "0x1866390C0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public BBDLPGIDAGK IKBIGOGILEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x6638DF0", Offset = "0x66381F0", VA = "0x186638DF0", Slot = "23")]
			get
			{
				return default(BBDLPGIDAGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool IOEDBNIGBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x6638D80", Offset = "0x6638180", VA = "0x186638D80", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KOLECAPMLJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xEC0770", Offset = "0xEBFB70", VA = "0x180EC0770", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x1293420", Offset = "0x1292820", VA = "0x181293420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool CFPEOKBEKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool CBGCJAGJOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x6638D30", Offset = "0x6638130", VA = "0x186638D30", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool LDHPAHILLLB
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x6638FF0", Offset = "0x66383F0", VA = "0x186638FF0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public LICKHDGKAMM BDNGLNKLDEH
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x66391E0", Offset = "0x66385E0", VA = "0x1866391E0", Slot = "29")]
			get
			{
				return default(LICKHDGKAMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public LKIBKIJNMNK KJKLIEAGBDO
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x6639240", Offset = "0x6638640", VA = "0x186639240", Slot = "31")]
			get
			{
				return default(LKIBKIJNMNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool NIPMOCIJDLB
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual PDKAKNMLKDF? IDLJKPNJAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual LHGEAAAIPDP? AGLFBNPOIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>>? GEPGIMDOJAL
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool BMCIFPPCBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x6638E60", Offset = "0x6638260", VA = "0x186638E60", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GKHNEBJMJEM<HHOOHPCIFEM> BDMPMKDIBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x6639120", Offset = "0x6638520", VA = "0x186639120", Slot = "63")]
			get
			{
				return default(GKHNEBJMJEM<HHOOHPCIFEM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public JHLAGGIINPD<HHOOHPCIFEM> PCJAKAOPGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x6638F90", Offset = "0x6638390", VA = "0x186638F90", Slot = "57")]
			get
			{
				return default(JHLAGGIINPD<HHOOHPCIFEM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool AJJCKNEAFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual JHLAGGIINPD<HHOOHPCIFEM>? CCMHHBLPOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool KDKGAPBBCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool PMKICCHHFND
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x6639050", Offset = "0x6638450", VA = "0x186639050", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B60", Offset = "0x9D4F60", VA = "0x1809D5B60", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C00", Offset = "0x9D5000", VA = "0x1809D5C00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string FKCCAHOKFNF
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AB0", Offset = "0x9D4EB0", VA = "0x1809D5AB0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AC0", Offset = "0x9D4EC0", VA = "0x1809D5AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public JHLAGGIINPD<AIKGKILEHOL> KDCLLMNGLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x6639390", Offset = "0x6638790", VA = "0x186639390", Slot = "64")]
			get
			{
				return default(JHLAGGIINPD<AIKGKILEHOL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public GKHNEBJMJEM<AIKGKILEHOL> OBPNEDHGFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x6639180", Offset = "0x6638580", VA = "0x186639180", Slot = "65")]
			get
			{
				return default(GKHNEBJMJEM<AIKGKILEHOL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public GKHNEBJMJEM<AIKGKILEHOL>? DOPHJENAJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x66393F0", Offset = "0x66387F0", VA = "0x1866393F0", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public OCNKOJALFOI<CBLNHLFJAIK, BLBBOINPFJE> PFGBOKJAMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x66394E0", Offset = "0x66388E0", VA = "0x1866394E0", Slot = "68")]
			get
			{
				return default(OCNKOJALFOI<CBLNHLFJAIK, BLBBOINPFJE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual JHLAGGIINPD<CBLNHLFJAIK>? PCAJJFEPHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool OJOCGLHKILC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool JHPBAEAMDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BCFGDBGKHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x6637A60", Offset = "0x6636E60", VA = "0x186637A60", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x66363B0", Offset = "0x66357B0", VA = "0x1866363B0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PGEINJOGELP DKKOJCNPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x6636750", Offset = "0x6635B50", VA = "0x186636750", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x66348C0", Offset = "0x6633CC0", VA = "0x1866348C0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event BAIBBEHAMNG ECEDCEOGGAI
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x6636E00", Offset = "0x6636200", VA = "0x186636E00", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x6637C50", Offset = "0x6637050", VA = "0x186637C50", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OHALNBNILLL
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x66356E0", Offset = "0x6634AE0", VA = "0x1866356E0", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x6636130", Offset = "0x6635530", VA = "0x186636130", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JBNMDAMAOLE
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6637B70", Offset = "0x6636F70", VA = "0x186637B70", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6637610", Offset = "0x6636A10", VA = "0x186637610", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>, BLBBOINPFJE> KDKIJKJPAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x6636C80", Offset = "0x6636080", VA = "0x186636C80", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x66379A0", Offset = "0x6636DA0", VA = "0x1866379A0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>, BLBBOINPFJE> DLLPHJJIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x66370E0", Offset = "0x66364E0", VA = "0x1866370E0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x6636F60", Offset = "0x6636360", VA = "0x186636F60", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>> JABGAJOFKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x66382A0", Offset = "0x66376A0", VA = "0x1866382A0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x6634F70", Offset = "0x6634370", VA = "0x186634F70", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<CBLNHLFJAIK>> CFKEJAOIMDG
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6636D40", Offset = "0x6636140", VA = "0x186636D40", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x6635030", Offset = "0x6634430", VA = "0x186635030", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>, BLBBOINPFJE> FMIJFEEKAMK
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x6634DB0", Offset = "0x66341B0", VA = "0x186634DB0", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x6637020", Offset = "0x6636420", VA = "0x186637020", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<CBLNHLFJAIK>> DDLGDLPGLEK
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x6636EA0", Offset = "0x66362A0", VA = "0x186636EA0", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x6635A60", Offset = "0x6634E60", VA = "0x186635A60", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x66385D0", Offset = "0x66379D0", VA = "0x1866385D0")]
		[CBPMGKHNHGF("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CBPMGKHNHGF("Need to handle `Name` better.")]
		protected CODCJNJKJKO(LJJLNABEAFK IOJHPNJDEEC, TNode HAIECNDMOKO, bool BIHCMKDDNHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x66357B0", Offset = "0x6634BB0", VA = "0x1866357B0", Slot = "100")]
		protected virtual void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x66352C0", Offset = "0x66346C0", VA = "0x1866352C0", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6638520", Offset = "0x6637920", VA = "0x186638520", Slot = "9")]
		[AsyncStateMachine(typeof(CODCJNJKJKO<>.CKOOLLMINNE))]
		public void PPEGGDKFNLJ(int CCHDLDAJFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6634B60", Offset = "0x6633F60", VA = "0x186634B60")]
		public bool BJNKIDMCMOI([In] LICKHDGKAMM OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6634BD0", Offset = "0x6633FD0", VA = "0x186634BD0")]
		public bool BJOGPGLHONA([In] LKIBKIJNMNK OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x66350F0", Offset = "0x66344F0", VA = "0x1866350F0", Slot = "33")]
		public void DOLNFJGFPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x66371A0", Offset = "0x66365A0", VA = "0x1866371A0", Slot = "34")]
		[AsyncStateMachine(typeof(CODCJNJKJKO<>.KPOOGCNNDNM))]
		public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> LAAHNDCAMIP(LICKHDGKAMM? PJFBLLCJOED, LKIBKIJNMNK? EFHNCGDBHHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "111")]
		public virtual void DBHLAGDBBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "112")]
		public virtual void OAEIAEJBHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "113")]
		public virtual void KLAPNNBBBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xEA3090", Offset = "0xEA2490", VA = "0x180EA3090")]
		protected void PDCDPELHEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xEF72A0", Offset = "0xEF66A0", VA = "0x180EF72A0")]
		protected void HGLBNDOMFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x20DA110", Offset = "0x20D9510", VA = "0x1820DA110")]
		private void FJMAKAADNDG([In] LKIBKIJNMNK PNEDBEMJDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x66347F0", Offset = "0x6633BF0", VA = "0x1866347F0", Slot = "114")]
		public virtual Task<BECHBBIPIFM<JHLAGGIINPD<CBLNHLFJAIK>, FFKOEKDBPON>> AIPKDLCHDME(string KCCMEIDBNGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x66362E0", Offset = "0x66356E0", VA = "0x1866362E0", Slot = "115")]
		public virtual Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> GEGCJKEHJHJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "116")]
		public virtual void NAHMGMOOLDA(JHLAGGIINPD<CBLNHLFJAIK> MHCIKMPHKKC, JHLAGGIINPD<CBLNHLFJAIK> JKEKPGFAOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6637E00", Offset = "0x6637200", VA = "0x186637E00", Slot = "117")]
		public virtual IEnumerable<MEKIHADOGMJ> PHOKCABMKDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6634E70", Offset = "0x6634270", VA = "0x186634E70", Slot = "118")]
		public BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON> CCOLIFJMOAJ(string KJCJHCHOCNE)
		{
			return default(BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6637330", Offset = "0x6636730", VA = "0x186637330", Slot = "48")]
		public bool MBELPOKKCJO([Out] Guid GMFAPAPAPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6634180", Offset = "0x6633580", VA = "0x186634180")]
		public bool AELODJIHAEF([In] Guid APKPABPIPHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "119")]
		public virtual void ICMDEPLACPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "120")]
		public virtual void POKGDPDKPOK(bool CNLBFEHCAOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "121")]
		public virtual IKLJJPDONBP HCFALFIGAGJ([In] CCDGHFJJKNO BFECCEFMAKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6634960", Offset = "0x6633D60", VA = "0x186634960")]
		protected void BGNGBBKENCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x66372F0", Offset = "0x66366F0", VA = "0x1866372F0", Slot = "126")]
		protected virtual bool LFKPACKJAGI(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6636190", Offset = "0x6635590", VA = "0x186636190", Slot = "89")]
		public bool GBMGGLLBKOI(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "127")]
		protected virtual bool CHECKGCAFBL(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected virtual void PJKPOIJGJEP(PGBGOAJGFEL CJIIBHNIEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6637E90", Offset = "0x6637290", VA = "0x186637E90")]
		protected void PHONBDOFCED(PGBGOAJGFEL MDJCNEAGBFC, Func<string> JCDMBLGMIJN, Action<string> OLPIGGFOOOB, string LHJFLDHLPNJ, string OLBHKDLHGBK, string GOACPIDJHEI, CDMIGBDAFPN KKPOHFDIJBK, NDGCFPCCMLG CHCPEKEKKOM, Func<string, bool> GDECLHDBCJP, string BPIHLIDMEHE, Func<string, bool> GCENGAINONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6636450", Offset = "0x6635850", VA = "0x186636450")]
		protected void GLOABLOPPKE(PGBGOAJGFEL MDJCNEAGBFC, Func<string> JCDMBLGMIJN, Action<string> OLPIGGFOOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x66377A0", Offset = "0x6636BA0", VA = "0x1866377A0", Slot = "135")]
		protected virtual void NKACDPKOHAO(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6635B20", Offset = "0x6634F20", VA = "0x186635B20", Slot = "83")]
		public void FECOCCIGMOJ(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x66374D0", Offset = "0x66368D0", VA = "0x1866374D0", Slot = "84")]
		public OJNENIBHGBE MLOHCOCJGOF()
		{
			return default(OJNENIBHGBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "138")]
		public virtual bool CJFMHJBCPIJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1EC7750", Offset = "0x1EC6B50", VA = "0x181EC7750")]
		private void EMKCCGMLHGJ([In] LICKHDGKAMM KBPOHLLNAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x6634C40", Offset = "0x6634040", VA = "0x186634C40")]
		private void BKCGHIKDBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x6637490", Offset = "0x6636890", VA = "0x186637490", Slot = "90")]
		private void MCPIHPOJPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6635B70", Offset = "0x6634F70", VA = "0x186635B70", Slot = "92")]
		private void FFIBKBKOIJE(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1033D50", Offset = "0x1033150", VA = "0x181033D50", Slot = "94")]
		private void IBLNKAGEDKG(JHLAGGIINPD<CBLNHLFJAIK> FBLIJIPJKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6638360", Offset = "0x6637760", VA = "0x186638360", Slot = "96")]
		private void PNHMMHHOCFI(JHLAGGIINPD<CBLNHLFJAIK> FBLIJIPJKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6634440", Offset = "0x6633840", VA = "0x186634440", Slot = "97")]
		private void AFALNDJKKJE(JHLAGGIINPD<CBLNHLFJAIK> MHCIKMPHKKC, JHLAGGIINPD<CBLNHLFJAIK> JKEKPGFAOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1033D30", Offset = "0x1033130", VA = "0x181033D30", Slot = "98")]
		private void CEIAKKKHJJC(JHLAGGIINPD<CBLNHLFJAIK> MHCIKMPHKKC, JHLAGGIINPD<CBLNHLFJAIK> JKEKPGFAOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6091730", Offset = "0x6090B30", VA = "0x186091730", Slot = "91")]
		private void KAOJKFKAMLN(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x66367F0", Offset = "0x6635BF0", VA = "0x1866367F0", Slot = "93")]
		private void HAAEEFADJIJ(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6637B00", Offset = "0x6636F00", VA = "0x186637B00", Slot = "95")]
		private void OIIDLINNOOK(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x66361C0", Offset = "0x66355C0", VA = "0x1866361C0", Slot = "139")]
		[AsyncStateMachine(typeof(CODCJNJKJKO<>.HFOPNJKHNEG))]
		public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> GDIMAMOANNG(string KJCJHCHOCNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6636C10", Offset = "0x6636010", VA = "0x186636C10", Slot = "55")]
		private void HCCFEBCAMPL(object IOMEFDFPPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6634F00", Offset = "0x6634300", VA = "0x186634F00", Slot = "56")]
		private void CNOBCKLDBHJ(object IOMEFDFPPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x53827F0", Offset = "0x5381BF0", VA = "0x1853827F0", Slot = "30")]
		private bool IFBAJCBGMFO([In] LICKHDGKAMM OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6637C10", Offset = "0x6637010", VA = "0x186637C10", Slot = "32")]
		private bool OLMNIFDIAMO([In] LKIBKIJNMNK OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x66375D0", Offset = "0x66369D0", VA = "0x1866375D0", Slot = "49")]
		private bool NAJBFJIJOPM([In] Guid APKPABPIPHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6637960", Offset = "0x6636D60", VA = "0x186637960")]
		[CompilerGenerated]
		private string NMDBKAKMILK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6637D50", Offset = "0x6637150", VA = "0x186637D50")]
		[CompilerGenerated]
		private void PFKHLJBAOKF(string KCCMEIDBNGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class NJCMFHEDNIM : CAKGEENOPOB<HNJADBFIPFL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xD68840", Offset = "0xD67C40", VA = "0x180D68840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x26DE8E0", Offset = "0x26DDCE0", VA = "0x1826DE8E0")]
		public NJCMFHEDNIM(LJJLNABEAFK IOJHPNJDEEC, HNJADBFIPFL HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class JJGLADLADLJ : AENFDOKHDNJ<MAFJOLDKFGC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x26D4240", Offset = "0x26D3640", VA = "0x1826D4240")]
		public JJGLADLADLJ(LJJLNABEAFK IOJHPNJDEEC, MAFJOLDKFGC HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public abstract class GOJOFEGGGIC<T> : CODCJNJKJKO<T> where T : notnull, GFJOGDDKKEM
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class MJDBFFDFJJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public IReadOnlyList<KeyValuePair<string, BGKHLJCAAGH>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public GOJOFEGGGIC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public LNAGEALNDID clipType;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public MJDBFFDFJJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			internal IReadOnlyList<KeyValuePair<string, BGKHLJCAAGH>> CHJJPNCJFNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x50C7D30", Offset = "0x50C7130", VA = "0x1850C7D30")]
			internal int IFLMKALMDCI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x50C8290", Offset = "0x50C7690", VA = "0x1850C8290")]
			internal void NNOHNDFMACB(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x50C81E0", Offset = "0x50C75E0", VA = "0x1850C81E0")]
			internal void NHBCLOJHNJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x50C7E90", Offset = "0x50C7290", VA = "0x1850C7E90")]
			internal void IGGBJOKJGHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x50C7FE0", Offset = "0x50C73E0", VA = "0x1850C7FE0")]
			internal bool KFBJFGNCNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x50C8190", Offset = "0x50C7590", VA = "0x1850C8190")]
			internal void NDBFHAMHJHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x50C7FE0", Offset = "0x50C73E0", VA = "0x1850C7FE0")]
			internal bool OJJEMDKOGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x50C8130", Offset = "0x50C7530", VA = "0x1850C8130")]
			internal float MPHDMECKOLL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x50C7BB0", Offset = "0x50C6FB0", VA = "0x1850C7BB0")]
			internal void DAMNDHOKCMA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x50C84B0", Offset = "0x50C78B0", VA = "0x1850C84B0")]
			internal float PPGOEOENKAH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x50C7C70", Offset = "0x50C7070", VA = "0x1850C7C70")]
			internal void DGPNJJKFKHD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x50C8230", Offset = "0x50C7630", VA = "0x1850C8230")]
			internal float NNFHECCEIJI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x50C8070", Offset = "0x50C7470", VA = "0x1850C8070")]
			internal void MHDIDMOMHEP(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A930", VA = "0x18104B530", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public abstract LNAGEALNDID DJIMGDPEGHD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x48D2770", Offset = "0x48D1B70", VA = "0x1848D2770")]
		public GOJOFEGGGIC(LJJLNABEAFK IOJHPNJDEEC, T HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x48D1C70", Offset = "0x48D1070", VA = "0x1848D1C70", Slot = "134")]
		protected sealed override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private sealed class HONIONNCHDM : CODCJNJKJKO<AKPNIOMIMAH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xD5CDF0", Offset = "0xD5C1F0", VA = "0x180D5CDF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x26D3670", Offset = "0x26D2A70", VA = "0x1826D3670")]
		public HONIONNCHDM(LJJLNABEAFK IOJHPNJDEEC, AKPNIOMIMAH HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class HGANPCAGKFC : CODCJNJKJKO<OCIGKJIBMKF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class MKHMLLKHLOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public HGANPCAGKFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public MKHMLLKHLOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x26DE100", Offset = "0x26DD500", VA = "0x1826DE100")]
			internal int IFLMKALMDCI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x26DE150", Offset = "0x26DD550", VA = "0x1826DE150")]
			internal void NNOHNDFMACB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static Dictionary<string, BGKHLJCAAGH>? PBMDIMBKLNN;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x26D29F0", Offset = "0x26D1DF0", VA = "0x1826D29F0")]
		public HGANPCAGKFC(LJJLNABEAFK IOJHPNJDEEC, OCIGKJIBMKF HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x26D2660", Offset = "0x26D1A60", VA = "0x1826D2660", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class MELCFNNAMFL : GOJOFEGGGIC<FGDAILBPNEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override LNAGEALNDID DJIMGDPEGHD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "140")]
			get
			{
				return default(LNAGEALNDID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x26DDC60", Offset = "0x26DD060", VA = "0x1826DDC60")]
		public MELCFNNAMFL(LJJLNABEAFK IOJHPNJDEEC, FGDAILBPNEB GDOONENKGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class NICIAFKBEMC : AENFDOKHDNJ<JJEIIDDJPMO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x26DE880", Offset = "0x26DDC80", VA = "0x1826DE880")]
		public NICIAFKBEMC(LJJLNABEAFK IOJHPNJDEEC, JJEIIDDJPMO HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class HNOFDAIHPCF : AENFDOKHDNJ<FPLDIKKBIEL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x26D3610", Offset = "0x26D2A10", VA = "0x1826D3610")]
		public HNOFDAIHPCF(LJJLNABEAFK IOJHPNJDEEC, FPLDIKKBIEL HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class OIBMCHCFDGP : BGIPEPLCEKC<HAKBCEGLCEA>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class EPNCAGLDKEO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A5")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public EPNCAGLDKEO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0x26E21A0", Offset = "0x26E15A0", VA = "0x1826E21A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public OIBMCHCFDGP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EPNCAGLDKEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x26CA850", Offset = "0x26C9C50", VA = "0x1826CA850")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void EHCEIBDGJJE(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x26E0E70", Offset = "0x26E0270", VA = "0x1826E0E70")]
		public OIBMCHCFDGP(LJJLNABEAFK IOJHPNJDEEC, HAKBCEGLCEA GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x26E0B90", Offset = "0x26DFF90", VA = "0x1826E0B90", Slot = "140")]
		protected override void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class EHAHBNAGLHN : GOJOFEGGGIC<LDFCGLPEMKE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override LNAGEALNDID DJIMGDPEGHD
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB5D430", Offset = "0xB5C830", VA = "0x180B5D430", Slot = "140")]
			get
			{
				return default(LNAGEALNDID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x26C9650", Offset = "0x26C8A50", VA = "0x1826C9650")]
		public EHAHBNAGLHN(LJJLNABEAFK IOJHPNJDEEC, LDFCGLPEMKE GDOONENKGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private sealed class OIFMKOKNCMJ : CODCJNJKJKO<DAGKBKHCHMB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xD47BA0", Offset = "0xD46FA0", VA = "0x180D47BA0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x26E0ED0", Offset = "0x26E02D0", VA = "0x1826E0ED0")]
		public OIFMKOKNCMJ(LJJLNABEAFK IOJHPNJDEEC, DAGKBKHCHMB HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class HDNENBMIPMC : CODCJNJKJKO<GEAMIDPAAHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public sealed override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override bool CHEGPOKINIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected sealed override bool IGBFMNACKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x26D25F0", Offset = "0x26D19F0", VA = "0x1826D25F0")]
		public HDNENBMIPMC(LJJLNABEAFK IOJHPNJDEEC, GEAMIDPAAHP HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x26D2320", Offset = "0x26D1720", VA = "0x1826D2320", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x26D22E0", Offset = "0x26D16E0", VA = "0x1826D22E0")]
		private int LMLEEKFJKLP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x26D2280", Offset = "0x26D1680", VA = "0x1826D2280")]
		private void AFCAJDMFHIO(int AGBLNABJHCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class IIJMMGMFIGB : HJECPIJEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x26D34C0", Offset = "0x26D28C0", VA = "0x1826D34C0")]
		public IIJMMGMFIGB(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class OGOMBINNNKH : BGIPEPLCEKC<JNNPIOACAON>
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x26E0B30", Offset = "0x26DFF30", VA = "0x1826E0B30")]
		public OGOMBINNNKH(LJJLNABEAFK IOJHPNJDEEC, JNNPIOACAON HAIECNDMOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public abstract class BGIPEPLCEKC<TVariableNode> : CODCJNJKJKO<TVariableNode> where TVariableNode : notnull, JNNPIOACAON
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class FGPAFPANMMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public BGIPEPLCEKC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public FGPAFPANMMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x47D8330", Offset = "0x47D7730", VA = "0x1847D8330")]
			internal bool CHJJPNCJFNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x47D8390", Offset = "0x47D7790", VA = "0x1847D8390")]
			internal void IFLMKALMDCI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x47D85C0", Offset = "0x47D79C0", VA = "0x1847D85C0")]
			internal bool NNOHNDFMACB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x47D8500", Offset = "0x47D7900", VA = "0x1847D8500")]
			internal void NHBCLOJHNJD(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x47D8450", Offset = "0x47D7850", VA = "0x1847D8450")]
			internal bool IGGBJOKJGHG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class HFEJNIBFGCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public KIFFONIJAAE nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public BGIPEPLCEKC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public HFEJNIBFGCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x49201F0", Offset = "0x491F5F0", VA = "0x1849201F0")]
			internal void EHCEIBDGJJE(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override NodeVisualizationKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xBA8DA0", Offset = "0xBA81A0", VA = "0x180BA8DA0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override LLJJDLECFAF NBADLLNPBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x5F928E0", Offset = "0x5F91CE0", VA = "0x185F928E0", Slot = "108")]
			get
			{
				return default(LLJJDLECFAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5F92730", Offset = "0x5F91B30", VA = "0x185F92730")]
		protected BGIPEPLCEKC(LJJLNABEAFK IOJHPNJDEEC, TVariableNode HAIECNDMOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5F91C70", Offset = "0x5F91070", VA = "0x185F91C70", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5F92280", Offset = "0x5F91680", VA = "0x185F92280", Slot = "134")]
		protected override void PJKPOIJGJEP(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5F91ED0", Offset = "0x5F912D0", VA = "0x185F91ED0", Slot = "140")]
		protected virtual void NDLAGGNDAJA(PGBGOAJGFEL MDJCNEAGBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5F91E10", Offset = "0x5F91210", VA = "0x185F91E10", Slot = "119")]
		public override void ICMDEPLACPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x26B4740", Offset = "0x26B3B40", VA = "0x1826B4740")]
	public static MKBHMHJPFFJ FABCCGGAHMJ(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class MLOAFLKEOGI : NJDBDJALAMN, HDKIHMKOEDO, NCIDOMLJCOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JHLAGGIINPD<FNFJOKDEBDH> MAAEFMCJKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xD37CA0", Offset = "0xD370A0", VA = "0x180D37CA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JHLAGGIINPD<FNFJOKDEBDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JHLAGGIINPD<GLKJMBBFOIK> EJLINNPDILB
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE36D60", Offset = "0xE36160", VA = "0x180E36D60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(JHLAGGIINPD<GLKJMBBFOIK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x26DE1E0", Offset = "0x26DD5E0", VA = "0x1826DE1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private JHLAGGIINPD<HEKBHBJIOHJ> EFIPHBHCLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD387B0", Offset = "0xD37BB0", VA = "0x180D387B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public override JHLAGGIINPD<PCONLAGIHPE> JOJBEHELKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x26DE1F0", Offset = "0x26DD5F0", VA = "0x1826DE1F0", Slot = "21")]
		get
		{
			return default(JHLAGGIINPD<PCONLAGIHPE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x26DE590", Offset = "0x26DD990", VA = "0x1826DE590")]
	private MLOAFLKEOGI(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO, JIBKJGEEEFC KKPJNLBEEFC, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<GLKJMBBFOIK> CIPHPJIJIKI, JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN, bool COCAJCECLNF, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x26DE240", Offset = "0x26DD640", VA = "0x1826DE240")]
	public static MLOAFLKEOGI FABCCGGAHMJ(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO, JIBKJGEEEFC GKIPCPOAHBN, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN, JHLAGGIINPD<GLKJMBBFOIK> CIPHPJIJIKI, bool COCAJCECLNF, bool BIHCMKDDNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x26DE1E0", Offset = "0x26DD5E0", VA = "0x1826DE1E0")]
	internal void EGPOGIIPLLI(JHLAGGIINPD<GLKJMBBFOIK> OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class NJDBDJALAMN : NCIDOMLJCOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private struct GGEFPCBBDMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private ONJCFFFIKDB? OCPGNKDOELN;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x26CC0B0", Offset = "0x26CB4B0", VA = "0x1826CC0B0")]
		public void ENAIKFMHAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x26CC0C0", Offset = "0x26CB4C0", VA = "0x1826CC0C0")]
		public ONJCFFFIKDB LHJCLBBBMGJ(NJDBDJALAMN HJOAABDKGHL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	protected readonly LIHPLMOAJJK EBDOLCICJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private GGEFPCBBDMO PIFAKLJMPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MLDKONBNCPD GNHPLEMGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<BEIPEHBOLBC> GABNCCFDCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly List<HLHEJOADENE> CPLBCCGHJIM;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[CBPMGKHNHGF("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> KLICOMNHAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x26DF070", Offset = "0x26DE470", VA = "0x1826DF070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DisplayKind OJNCGIMIIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9DA090", Offset = "0x9D9490", VA = "0x1809DA090", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JHLAGGIINPD<HHOOHPCIFEM> PCJAKAOPGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x26DFBE0", Offset = "0x26DEFE0", VA = "0x1826DFBE0", Slot = "6")]
		get
		{
			return default(JHLAGGIINPD<HHOOHPCIFEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GKHNEBJMJEM<HHOOHPCIFEM> BDMPMKDIBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x26DF040", Offset = "0x26DE440", VA = "0x1826DF040", Slot = "7")]
		get
		{
			return default(GKHNEBJMJEM<HHOOHPCIFEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public IGCHBCCCIIG LFFHHKEHKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD19750", Offset = "0xD18B50", VA = "0x180D19750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HLBKNJBMDKC BJEGFCIJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x26DEFA0", Offset = "0x26DE3A0", VA = "0x1826DEFA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	protected ONJCFFFIKDB MOLKACNJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x26DEFA0", Offset = "0x26DE3A0", VA = "0x1826DEFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PortImage OGEHDGNNGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x26DF3F0", Offset = "0x26DE7F0", VA = "0x1826DF3F0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9440", Offset = "0x9C8840", VA = "0x1809C9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public GKHNEBJMJEM<AIKGKILEHOL> OBPNEDHGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x26DF220", Offset = "0x26DE620", VA = "0x1826DF220", Slot = "9")]
		get
		{
			return default(GKHNEBJMJEM<AIKGKILEHOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JHLAGGIINPD<CBLNHLFJAIK> OOEAPIEGNBG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCDFED0", Offset = "0xCDF2D0", VA = "0x180CDFED0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JHLAGGIINPD<CBLNHLFJAIK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE16700", Offset = "0xE15B00", VA = "0x180E16700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract JHLAGGIINPD<PCONLAGIHPE> JOJBEHELKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x26DFC70", Offset = "0x26DF070", VA = "0x1826DFC70")]
	protected NJDBDJALAMN(LJJLNABEAFK IOJHPNJDEEC, LIHPLMOAJJK HAIECNDMOKO, MLDKONBNCPD NELIGLJDGIK, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, bool COCAJCECLNF, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x26DEB10", Offset = "0x26DDF10", VA = "0x1826DEB10", Slot = "22")]
	protected virtual void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x26DE9C0", Offset = "0x26DDDC0", VA = "0x1826DE9C0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x26DEAB0", Offset = "0x26DDEB0", VA = "0x1826DEAB0", Slot = "14")]
	public void ENIIDNFFCKJ(BEIPEHBOLBC FMFJELOACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x26DEDB0", Offset = "0x26DE1B0", VA = "0x1826DEDB0", Slot = "15")]
	public void FMGLBPKGPBF(HLHEJOADENE FMFJELOACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x26DF520", Offset = "0x26DE920", VA = "0x1826DF520", Slot = "16")]
	public void KMOKADBJEGF(IFNEMJOAEIG JMNGOOCABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x26DFC10", Offset = "0x26DF010", VA = "0x1826DFC10", Slot = "24")]
	protected virtual void PKKFGLCMKLF(IFNEMJOAEIG JMNGOOCABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x26DEE10", Offset = "0x26DE210", VA = "0x1826DEE10", Slot = "19")]
	private void GABGPDPMIMF(bool PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x26DF240", Offset = "0x26DE640", VA = "0x1826DF240")]
	private void IPMLENGOKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x26DEC00", Offset = "0x26DE000", VA = "0x1826DEC00")]
	private void FLBFOCKGNHG([In] HMKPKPIHMCB AIHINFONMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x26DF1C0", Offset = "0x26DE5C0", VA = "0x1826DF1C0", Slot = "17")]
	public void HPLELMKMGNP(BEIPEHBOLBC FMFJELOACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x26DE940", Offset = "0x26DDD40", VA = "0x1826DE940", Slot = "18")]
	public void BBACJHMPNPI(HLHEJOADENE FMFJELOACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x9C9440", Offset = "0x9C8840", VA = "0x1809C9440")]
	internal void CBEDAAFAGJM(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x26DE9A0", Offset = "0x26DDDA0", VA = "0x1826DE9A0")]
	internal void CBKAHFMGBEH(GMEGDKBKOFO BGLHIFBEGOD, IGCHBCCCIIG KHNCICOHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE16700", Offset = "0xE15B00", VA = "0x180E16700")]
	internal void JGMKDDBHLDA(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class GLBOPFNNPEC : BLBBOINPFJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class KFFOPFMCGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public LJJLNABEAFK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LIHPLMOAJJK node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KFFOPFMCGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x26D4610", Offset = "0x26D3A10", VA = "0x1826D4610")]
		internal MFENEFENMEA MLAAMAELLBC((int PortDescIndex, int PortIndex, GMCELBBCPDH InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x26D4580", Offset = "0x26D3980", VA = "0x1826D4580")]
		internal MLOAFLKEOGI IPIICICGKJJ(JIBKJGEEEFC i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IEDCKIJGAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x26D3B80", Offset = "0x26D2F80", VA = "0x1826D3B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x26D3FF0", Offset = "0x26D33F0", VA = "0x1826D3FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FABJIBBALAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public JHLAGGIINPD<JGBFKPDFGOJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x26CA920", Offset = "0x26C9D20", VA = "0x1826CA920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x26CAC70", Offset = "0x26CA070", VA = "0x1826CAC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct DGMHFHHPMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JHLAGGIINPD<HEKBHBJIOHJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x26C8C30", Offset = "0x26C8030", VA = "0x1826C8C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x26C8F80", Offset = "0x26C8380", VA = "0x1826C8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct PMMAONCIMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public JHLAGGIINPD<JGBFKPDFGOJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public JHLAGGIINPD<JGBFKPDFGOJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x26E1DD0", Offset = "0x26E11D0", VA = "0x1826E1DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x26E2130", Offset = "0x26E1530", VA = "0x1826E2130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct DFLIMPHGPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public JHLAGGIINPD<HEKBHBJIOHJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public JHLAGGIINPD<HEKBHBJIOHJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x26C8860", Offset = "0x26C7C60", VA = "0x1826C8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x26C8BC0", Offset = "0x26C7FC0", VA = "0x1826C8BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LJCHMFOOOBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x26DCDF0", Offset = "0x26DC1F0", VA = "0x1826DCDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x26DD270", Offset = "0x26DC670", VA = "0x1826DD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct CNFBDFGANEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x26C84A0", Offset = "0x26C78A0", VA = "0x1826C84A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x26C87F0", Offset = "0x26C7BF0", VA = "0x1826C87F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct FEGBPIPNMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public JHLAGGIINPD<JGBFKPDFGOJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x26CACE0", Offset = "0x26CA0E0", VA = "0x1826CACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x26CB050", Offset = "0x26CA450", VA = "0x1826CB050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct IBIGMPJAJOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public JHLAGGIINPD<HEKBHBJIOHJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x26D37A0", Offset = "0x26D2BA0", VA = "0x1826D37A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x26D3B10", Offset = "0x26D2F10", VA = "0x1826D3B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct EEALCENEKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public FBGLCEJBMBF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public JHLAGGIINPD<JGBFKPDFGOJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x26C9240", Offset = "0x26C8640", VA = "0x1826C9240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x26C95E0", Offset = "0x26C89E0", VA = "0x1826C95E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct KHAALIGPDOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public GLBOPFNNPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public FBGLCEJBMBF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JHLAGGIINPD<HEKBHBJIOHJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private PPPNMBLCMMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x26D46A0", Offset = "0x26D3AA0", VA = "0x1826D46A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x26D4A40", Offset = "0x26D3E40", VA = "0x1826D4A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly bool DPNGMDMIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly bool KDMINADOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private OCNKOJALFOI<FAHJLKCNODD, MFENEFENMEA> HLAOKFCGOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private OCNKOJALFOI<FAHJLKCNODD, CNNBKJKIMPE> IPDPIBIFDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly LIHPLMOAJJK EBDOLCICJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private OCNKOJALFOI<GLKJMBBFOIK, MLOAFLKEOGI> LJLDMPCPCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private OCNKOJALFOI<GLKJMBBFOIK, HDKIHMKOEDO> BLBJPHMCBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private string? AKMMMHJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly BHNCBLCNPHC ACKMHGCONIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private JHLAGGIINPD<CBLNHLFJAIK> BFJBKLCDLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly bool ADKAMDNIINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action? BPBCJOADCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action? GENFBJIMLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private Action<JHLAGGIINPD<FAHJLKCNODD>>? BAOAAPOMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[CompilerGenerated]
	private Action<JHLAGGIINPD<GLKJMBBFOIK>>? LHCMFBFAIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	[CompilerGenerated]
	private BLBBOINPFJE.FLNHLIALOMP? EHEBEMIGNAE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool AMDEFCOLBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x26CE2D0", Offset = "0x26CD6D0", VA = "0x1826CE2D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool ABHNCMMCFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x26D0DC0", Offset = "0x26D01C0", VA = "0x1826D0DC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool APBGIEONNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x26CCC00", Offset = "0x26CC000", VA = "0x1826CCC00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public GKHNEBJMJEM<HHOOHPCIFEM> BDMPMKDIBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x26CEAA0", Offset = "0x26CDEA0", VA = "0x1826CEAA0", Slot = "7")]
		get
		{
			return default(GKHNEBJMJEM<HHOOHPCIFEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool JMALBAEPOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x26CFD30", Offset = "0x26CF130", VA = "0x1826CFD30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public OCNKOJALFOI<FAHJLKCNODD, CNNBKJKIMPE> CLDBNMHKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "9")]
		get
		{
			return default(OCNKOJALFOI<FAHJLKCNODD, CNNBKJKIMPE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x26CCBD0", Offset = "0x26CBFD0", VA = "0x1826CCBD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GKHNEBJMJEM<AIKGKILEHOL> OBPNEDHGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x26CEAD0", Offset = "0x26CDED0", VA = "0x1826CEAD0", Slot = "11")]
		get
		{
			return default(GKHNEBJMJEM<AIKGKILEHOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public OCNKOJALFOI<GLKJMBBFOIK, HDKIHMKOEDO> IPFDEKMDFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450", Slot = "12")]
		get
		{
			return default(OCNKOJALFOI<GLKJMBBFOIK, HDKIHMKOEDO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JHLAGGIINPD<CBLNHLFJAIK> OOEAPIEGNBG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xB8AA20", Offset = "0xB89E20", VA = "0x180B8AA20", Slot = "13")]
		get
		{
			return default(JHLAGGIINPD<CBLNHLFJAIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? ANINCIAHEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x26CEDD0", Offset = "0x26CE1D0", VA = "0x1826CEDD0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x26CE830", Offset = "0x26CDC30", VA = "0x1826CE830", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? LECDAFGEDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x26D0790", Offset = "0x26CFB90", VA = "0x1826D0790", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x26CEC00", Offset = "0x26CE000", VA = "0x1826CEC00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JHLAGGIINPD<FAHJLKCNODD?>, JHLAGGIINPD<FAHJLKCNODD?>>? PCHEOKIDHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x26D1280", Offset = "0x26D0680", VA = "0x1826D1280", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x26D0580", Offset = "0x26CF980", VA = "0x1826D0580", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JHLAGGIINPD<FAHJLKCNODD?>, JHLAGGIINPD<FAHJLKCNODD?>>? ALNFNECPONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x26CCCC0", Offset = "0x26CC0C0", VA = "0x1826CCCC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x26CC390", Offset = "0x26CB790", VA = "0x1826CC390", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JHLAGGIINPD<GLKJMBBFOIK?>, JHLAGGIINPD<GLKJMBBFOIK?>>? HKOHLJFPAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x26D04C0", Offset = "0x26CF8C0", VA = "0x1826D04C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x26CE390", Offset = "0x26CD790", VA = "0x1826CE390", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JHLAGGIINPD<GLKJMBBFOIK?>, JHLAGGIINPD<GLKJMBBFOIK?>>? DOLGPECFENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x26D11C0", Offset = "0x26D05C0", VA = "0x1826D11C0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x26D0400", Offset = "0x26CF800", VA = "0x1826D0400", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JHLAGGIINPD<FAHJLKCNODD?>, CNNBKJKIMPE?>? EGKBJGMIECN
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x26D0340", Offset = "0x26CF740", VA = "0x1826D0340", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x26CF460", Offset = "0x26CE860", VA = "0x1826CF460", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JHLAGGIINPD<FAHJLKCNODD?>>? OCLFEHEOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x26D0EC0", Offset = "0x26D02C0", VA = "0x1826D0EC0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x26CE770", Offset = "0x26CDB70", VA = "0x1826CE770", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JHLAGGIINPD<FAHJLKCNODD?>, CNNBKJKIMPE?>? IMIIKHFECFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x26D0E00", Offset = "0x26D0200", VA = "0x1826D0E00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x26CF240", Offset = "0x26CE640", VA = "0x1826CF240", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JHLAGGIINPD<GLKJMBBFOIK?>, HDKIHMKOEDO?>? LCMFMCCEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x26CCB10", Offset = "0x26CBF10", VA = "0x1826CCB10", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x26D1340", Offset = "0x26D0740", VA = "0x1826D1340", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<JHLAGGIINPD<GLKJMBBFOIK?>>? GNMDGDHKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x26D0840", Offset = "0x26CFC40", VA = "0x1826D0840", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x26CF380", Offset = "0x26CE780", VA = "0x1826CF380", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JHLAGGIINPD<GLKJMBBFOIK?>, HDKIHMKOEDO?>? ACDCFCPBALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x26CE9E0", Offset = "0x26CDDE0", VA = "0x1826CE9E0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x26CCE70", Offset = "0x26CC270", VA = "0x1826CCE70", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x26D1400", Offset = "0x26D0800", VA = "0x1826D1400")]
	private GLBOPFNNPEC(bool COCAJCECLNF, LJJLNABEAFK IOJHPNJDEEC, bool MPPFBPOMAJO, OCNKOJALFOI<FAHJLKCNODD, MFENEFENMEA> KCOKOMAOHGE, OCNKOJALFOI<FAHJLKCNODD, CNNBKJKIMPE> CODEHBEJJAM, LIHPLMOAJJK HAIECNDMOKO, OCNKOJALFOI<GLKJMBBFOIK, MLOAFLKEOGI> HFLJADBFFBE, OCNKOJALFOI<GLKJMBBFOIK, HDKIHMKOEDO> GKDKGBCKEME, string? OMIJABAPHLE, BHNCBLCNPHC NECFEMKMJOJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, bool BIHCMKDDNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x26CDAD0", Offset = "0x26CCED0", VA = "0x1826CDAD0")]
	public static GLBOPFNNPEC FABCCGGAHMJ(bool COCAJCECLNF, LJJLNABEAFK IOJHPNJDEEC, bool MPPFBPOMAJO, LIHPLMOAJJK HAIECNDMOKO, BHNCBLCNPHC NECFEMKMJOJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, bool BIHCMKDDNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x26CD730", Offset = "0x26CCB30", VA = "0x1826CD730", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x26CCD80", Offset = "0x26CC180", VA = "0x1826CCD80", Slot = "38")]
	[AsyncStateMachine(typeof(IEDCKIJGAEK))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? CILCAMAOOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x26CE0A0", Offset = "0x26CD4A0", VA = "0x1826CE0A0")]
	private (GKIPGNDBCBC?, int)? FGIBPGHDDCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x26CE680", Offset = "0x26CDA80", VA = "0x1826CE680", Slot = "58")]
	private void GCMILDNLIIO(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1EE97A0", Offset = "0x1EE8BA0", VA = "0x181EE97A0", Slot = "57")]
	private void IHDJGKCFJKL(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26D0A20", Offset = "0x26CFE20", VA = "0x1826D0A20", Slot = "61")]
	private void OHEBNEDMGAM(int FMHGNBAMFCP, int ANGBNJGBMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x26CF320", Offset = "0x26CE720", VA = "0x1826CF320", Slot = "63")]
	private void KJFFFMGDBBM(int FMHGNBAMFCP, int ANGBNJGBMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x26CC450", Offset = "0x26CB850", VA = "0x1826CC450", Slot = "50")]
	private void BDIGEBDIOFC(int HODLGGDPBMF, JHLAGGIINPD<FAHJLKCNODD> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x26D1070", Offset = "0x26D0470", VA = "0x1826D1070", Slot = "54")]
	private void PFLDKMDKLFF(int PLCJAHDMBHK, JHLAGGIINPD<FAHJLKCNODD> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x26CF300", Offset = "0x26CE700", VA = "0x1826CF300", Slot = "49")]
	private void KHKNKGIJKGL(int PLCJAHDMBHK, JHLAGGIINPD<FAHJLKCNODD> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x26CD190", Offset = "0x26CC590", VA = "0x1826CD190", Slot = "53")]
	private void CMFIHBNCGML(int HODLGGDPBMF, JHLAGGIINPD<FAHJLKCNODD> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x26CD5E0", Offset = "0x26CC9E0", VA = "0x1826CD5E0", Slot = "66")]
	private void DCFBBEDFHKO(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x12606E0", Offset = "0x125FAE0", VA = "0x1812606E0", Slot = "65")]
	private void HIKEHAOFBAI(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x26D0F80", Offset = "0x26D0380", VA = "0x1826D0F80", Slot = "60")]
	private void OPLNENOAPOA(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1EE97A0", Offset = "0x1EE8BA0", VA = "0x181EE97A0", Slot = "59")]
	private void FMOMHPGOPLA(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x26CF990", Offset = "0x26CED90", VA = "0x1826CF990", Slot = "62")]
	private void LMNPCLHICHG(int FMHGNBAMFCP, int ANGBNJGBMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x26CE040", Offset = "0x26CD440", VA = "0x1826CE040", Slot = "64")]
	private void FGABKBMBMAN(int FMHGNBAMFCP, int ANGBNJGBMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x26CFDB0", Offset = "0x26CF1B0", VA = "0x1826CFDB0", Slot = "52")]
	private void LNNNKPDFEHI(int HODLGGDPBMF, JHLAGGIINPD<GLKJMBBFOIK> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x26CEBE0", Offset = "0x26CDFE0", VA = "0x1826CEBE0", Slot = "56")]
	private void INCLABMLJHC(int PLCJAHDMBHK, JHLAGGIINPD<GLKJMBBFOIK> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x26CF440", Offset = "0x26CE840", VA = "0x1826CF440", Slot = "51")]
	private void LBJILDNGGGE(int PLCJAHDMBHK, JHLAGGIINPD<GLKJMBBFOIK> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x26CF520", Offset = "0x26CE920", VA = "0x1826CF520", Slot = "55")]
	private void LILFOGFNCAD(int HODLGGDPBMF, JHLAGGIINPD<GLKJMBBFOIK> DBPAKCEBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x26D0640", Offset = "0x26CFA40", VA = "0x1826D0640", Slot = "68")]
	private void NBCDGKBMHJA(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x12606E0", Offset = "0x125FAE0", VA = "0x1812606E0", Slot = "67")]
	private void DKPNDKDLPOP(int HODLGGDPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x26CE8D0", Offset = "0x26CDCD0", VA = "0x1826CE8D0", Slot = "39")]
	[AsyncStateMachine(typeof(FABJIBBALAK))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? GIELCMKEJCL(JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x26CE450", Offset = "0x26CD850", VA = "0x1826CE450", Slot = "40")]
	[AsyncStateMachine(typeof(DGMHFHHPMOM))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? GAEKGBLHOII(JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x26CE560", Offset = "0x26CD960", VA = "0x1826CE560", Slot = "41")]
	[AsyncStateMachine(typeof(PMMAONCIMPC))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? GBMINPKPCMF(JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB, JHLAGGIINPD<JGBFKPDFGOJ> KMKPOMMBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x26D0900", Offset = "0x26CFD00", VA = "0x1826D0900", Slot = "42")]
	[AsyncStateMachine(typeof(DFLIMPHGPJN))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? OFHEONPEMPI(JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN, JHLAGGIINPD<HEKBHBJIOHJ> KMKPOMMBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x26CEAF0", Offset = "0x26CDEF0", VA = "0x1826CEAF0", Slot = "43")]
	[AsyncStateMachine(typeof(LJCHMFOOOBG))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON?>>? IFDMAGONKBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x26CECB0", Offset = "0x26CE0B0", VA = "0x1826CECB0", Slot = "44")]
	[AsyncStateMachine(typeof(CNFBDFGANEB))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> JAPCEJOHHKF(string KJCJHCHOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x26CD060", Offset = "0x26CC460", VA = "0x1826CD060", Slot = "45")]
	[AsyncStateMachine(typeof(FEGBPIPNMKB))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> CMDGENJEMLP(JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB, string KCCMEIDBNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x26CC9E0", Offset = "0x26CBDE0", VA = "0x1826CC9E0", Slot = "46")]
	[AsyncStateMachine(typeof(IBIGMPJAJOI))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> BGEKOIHJCDN(JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN, string KCCMEIDBNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x26CCF30", Offset = "0x26CC330", VA = "0x1826CCF30", Slot = "47")]
	[AsyncStateMachine(typeof(EEALCENEKFB))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> CLILDKFHGMM(JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB, FBGLCEJBMBF KHNCICOHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x26D1090", Offset = "0x26D0490", VA = "0x1826D1090", Slot = "48")]
	[AsyncStateMachine(typeof(KHAALIGPDOA))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> PGFPDLGFCFK(JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN, FBGLCEJBMBF KHNCICOHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x26CEE70", Offset = "0x26CE270", VA = "0x1826CEE70")]
	internal void JGMKDDBHLDA(JHLAGGIINPD<CBLNHLFJAIK> OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class BFJFGICDBMB : GIDBJEAMJJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public interface FHINOFCPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public readonly struct HKOAMOCLJCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public readonly IReadOnlyDictionary<GKHNEBJMJEM<HHOOHPCIFEM>, Guid>? HAPNJOBGBKC;

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
			public HKOAMOCLJCE(IReadOnlyDictionary<GKHNEBJMJEM<HHOOHPCIFEM>, Guid>? HAPNJOBGBKC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		GMEGDKBKOFO NMFGEFFLLID
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DGOMHNDAFIH> BLAENPMLMKH(CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KPMJDHJBPEL> HIKKPMCLLEG(CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<MFNBCAODJJD> KCMFHKFGKMM(CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<CLFCELJMAMP> KFGPBIKOPKE(CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<HKOAMOCLJCE> IAKEHNHDDLH(CancellationToken JDDHIJBJNHP);

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<JIOJFHJNGNL> LNECCEOJELA(CancellationToken JDDHIJBJNHP);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct AGFPIABHNIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<BFJFGICDBMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public LJJLNABEAFK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DGOMHNDAFIH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public KPMJDHJBPEL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private FHINOFCPEOE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private DGOMHNDAFIH <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DGOMHNDAFIH <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private JIOJFHJNGNL <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private KPMJDHJBPEL <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private MFNBCAODJJD <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private CLFCELJMAMP <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<DGOMHNDAFIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private DGOMHNDAFIH <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<JIOJFHJNGNL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<KPMJDHJBPEL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<MFNBCAODJJD> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<CLFCELJMAMP> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<FHINOFCPEOE.HKOAMOCLJCE> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<LLLBPLEIMIJ> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x26C6D80", Offset = "0x26C6180", VA = "0x1826C6D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x26C7E50", Offset = "0x26C7250", VA = "0x1826C7E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private readonly LLLBPLEIMIJ AAGLPKDAIBF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LLLBPLEIMIJ MEILKCJDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	private BFJFGICDBMB(LLLBPLEIMIJ GIOJIDGIPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x26C7EE0", Offset = "0x26C72E0", VA = "0x1826C7EE0")]
	[AsyncStateMachine(typeof(AGFPIABHNIH))]
	public static Task<BFJFGICDBMB> MICGICOPDNP(LJJLNABEAFK IOJHPNJDEEC, DGOMHNDAFIH? NILNGFKCINL, KPMJDHJBPEL? PBNEIBAJIIG, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x26C7EC0", Offset = "0x26C72C0", VA = "0x1826C7EC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct OJMDILOCDLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct HGBIJABMILA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public OJMDILOCDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public MEKIHADOGMJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x26D2A60", Offset = "0x26D1E60", VA = "0x1826D2A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x26D2CF0", Offset = "0x26D20F0", VA = "0x1826D2CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct CFODAIOLCIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<bool, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public DGADMLPHDMP rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public DGOMHNDAFIH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public KPMJDHJBPEL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public OJMDILOCDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private MEKIHADOGMJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x26C8050", Offset = "0x26C7450", VA = "0x1826C8050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x26C8430", Offset = "0x26C7830", VA = "0x1826C8430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct GPIAJHACHHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public OJMDILOCDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x26D1500", Offset = "0x26D0900", VA = "0x1826D1500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x26D1740", Offset = "0x26D0B40", VA = "0x1826D1740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly FDABGINDJJA DKPLKPFKKOI;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	public OJMDILOCDLB(FDABGINDJJA GBMFHBEGEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x26E0FA0", Offset = "0x26E03A0", VA = "0x1826E0FA0")]
	[AsyncStateMachine(typeof(HGBIJABMILA))]
	private Task<BECHBBIPIFM<object, FFKOEKDBPON>> EONDIGCKHLE(MEKIHADOGMJ PDHMHKIHKPF, bool HCKGLDGPPOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x26E10D0", Offset = "0x26E04D0", VA = "0x1826E10D0")]
	[AsyncStateMachine(typeof(CFODAIOLCIN))]
	public Task<BECHBBIPIFM<bool, FFKOEKDBPON?>>? FLLPAMCKENA(int FACKHILDKAH, DGADMLPHDMP? GEDHHIAHIJI, DGOMHNDAFIH? FMKCIHIOIOE, KPMJDHJBPEL? PBNEIBAJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x26E1230", Offset = "0x26E0630", VA = "0x1826E1230")]
	[AsyncStateMachine(typeof(GPIAJHACHHJ))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> JLKCCHLFIFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class ADCNMDBEJKF : LLGLIPKDJHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly PIEOCOPGBAL ILCJCONICBJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PIEOCOPGBAL NOIBKHJFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	private ADCNMDBEJKF(PIEOCOPGBAL GAFLCGDCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x26C6B90", Offset = "0x26C5F90", VA = "0x1826C6B90")]
	public static ADCNMDBEJKF ILOIKAMJPOD(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x26C6B70", Offset = "0x26C5F70", VA = "0x1826C6B70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface HHLELMNMPOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	LLLBPLEIMIJ MEILKCJDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	PJHDAEHNDPE PNNOGPFEHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	JECJABEPNHF BHOGCJNFGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	LFBNNEGDDLI OKNODCDDJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface PMMJFDBILBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	HHLELMNMPOM? HGJJAAPGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool PJBCMDOMBND
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool GGBHNPHMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HHLELMNMPOM?>? NIAIOLAJKON();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LKGDLPDKPHK(LJJLNABEAFK IOJHPNJDEEC, DGADMLPHDMP AINGCCFHKBA, DGOMHNDAFIH? BINPFAMCCAA, KPMJDHJBPEL? EJMCAOPFLMM);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ADFLCGEAIKO("IStaticCV2Instance")]
public interface GIDBJEAMJJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	LLLBPLEIMIJ MEILKCJDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ADFLCGEAIKO("IStaticEVInstance")]
public interface LLGLIPKDJHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	PIEOCOPGBAL NOIBKHJFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class HAOLKHMIJOB
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x26D17B0", Offset = "0x26D0BB0", VA = "0x1826D17B0")]
	public static JDHPDAPAGED<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> KGNNKJBLGEN([In] this JDHPDAPAGED<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>> LOAKOLOCEHF)
	{
		return default(JDHPDAPAGED<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK, DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class FFEHNAIDJCB : LBCOCDPPOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool GGBHNPHMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x26CB7F0", Offset = "0x26CABF0", VA = "0x1826CB7F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	internal FFEHNAIDJCB(LJJLNABEAFK IOJHPNJDEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal sealed class KPEDOALNEIF : ECJMBHDFOKO
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x26D4BD0", Offset = "0x26D3FD0", VA = "0x1826D4BD0", Slot = "4")]
	public MLNOOCNNPNF? IMNLKBJLANC(string? PPLGMFFJCIB, string? JMENHJHNOMG, string? IDJNHKEKKOC, CINCIIECING.HLHLEEOFBNP.MDOIMLIABPA KCJJBIPHKOH, bool FAFMOGHDFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KPEDOALNEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class OFJLKGHEFDP : DMEECILJNLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct PEKPCINDGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder<OOKBLLNDPGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public OFJLKGHEFDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<HHLELMNMPOM?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x26E1610", Offset = "0x26E0A10", VA = "0x1826E1610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x26E18C0", Offset = "0x26E0CC0", VA = "0x1826E18C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OOKBLLNDPGF? IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x26E04A0", Offset = "0x26DF8A0", VA = "0x1826E04A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public LFBNNEGDDLI? DLBPEDMFNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x26E08C0", Offset = "0x26DFCC0", VA = "0x1826E08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool MMGABGDPAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x26E01C0", Offset = "0x26DF5C0", VA = "0x1826E01C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool KLNFHCLCFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x26E06C0", Offset = "0x26DFAC0", VA = "0x1826E06C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x26E0940", Offset = "0x26DFD40", VA = "0x1826E0940")]
	internal OFJLKGHEFDP(LJJLNABEAFK IOJHPNJDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x26E03B0", Offset = "0x26DF7B0", VA = "0x1826E03B0", Slot = "7")]
	[AsyncStateMachine(typeof(PEKPCINDGOJ))]
	public Task<OOKBLLNDPGF> GKGAHLHKKKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x26DFE50", Offset = "0x26DF250", VA = "0x1826DFE50", Slot = "9")]
	public IReadOnlyDictionary<GKHNEBJMJEM<HHOOHPCIFEM>, Guid> ANGNBLEPFOA(IEnumerable<IBDHKNDIHNK> ENCLDPFKCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x26E0220", Offset = "0x26DF620", VA = "0x1826E0220", Slot = "10")]
	public LJCKALEBKLJ EPKECAGKFEK(IEnumerable<IBDHKNDIHNK> ENCLDPFKCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x26E0720", Offset = "0x26DFB20", VA = "0x1826E0720")]
	public BECHBBIPIFM<JDLKOFEKJFO, HAPFLJDLPEC> MLPPLDNNJLO([In] JDLKOFEKJFO IHFELLGNBJP)
	{
		return default(BECHBBIPIFM<JDLKOFEKJFO, HAPFLJDLPEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x26E0520", Offset = "0x26DF920", VA = "0x1826E0520", Slot = "8")]
	private BECHBBIPIFM<JDLKOFEKJFO, HAPFLJDLPEC> JOABAIFIJEL([In] JDLKOFEKJFO IHFELLGNBJP)
	{
		return default(BECHBBIPIFM<JDLKOFEKJFO, HAPFLJDLPEC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class LFBNNEGDDLI : OOKBLLNDPGF
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal static class AAPFJAIPBPH
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class AJMCLJAHCNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public LLLBPLEIMIJ state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public FLFGJJGPOAG spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AJMCLJAHCNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x26E6590", Offset = "0x26E5990", VA = "0x1826E6590")]
			internal bool DEIHABBMDMH(DHJMMNEBKJD n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class PDMNHGOLOPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PDMNHGOLOPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x26EC180", Offset = "0x26EB580", VA = "0x1826EC180")]
			internal void ENACMHHCNGH(DHJMMNEBKJD n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x26E49C0", Offset = "0x26E3DC0", VA = "0x1826E49C0")]
		public static BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN> ILOIMMFJAMD(LFBNNEGDDLI KBBJDOAJMAF, [In] OOKBLLNDPGF.GNFONCOCCDK KBIBHMCLJNL)
		{
			return default(BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x26E4F00", Offset = "0x26E4300", VA = "0x1826E4F00")]
		internal static BECHBBIPIFM<(KINPNBNGIEM, LIHFGDHNINM), DJJEDLFAHGN> JJDADGBMBCO(LFBNNEGDDLI KBBJDOAJMAF, LIHFGDHNINM HPMCFGNOELC, bool OKNDCKAADLL, [In] GKHNEBJMJEM<HHOOHPCIFEM> JGMECOGPNHP, [In] int? JNPPOBMCDJJ, [In] OJNENIBHGBE? DCBPDKDGOGG, [In] OJNENIBHGBE? CAFHACHPKAJ)
		{
			return default(BECHBBIPIFM<(KINPNBNGIEM, LIHFGDHNINM), DJJEDLFAHGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x26E5E40", Offset = "0x26E5240", VA = "0x1826E5E40")]
		private static void PBNFHKFOHJL(bool OKNDCKAADLL, IBDHKNDIHNK GEBIOONDCDF, KINPNBNGIEM KEJMOCEKCNM, [In] GKHNEBJMJEM<HHOOHPCIFEM> JGMECOGPNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x26E45B0", Offset = "0x26E39B0", VA = "0x1826E45B0")]
		public static void ADKPNABCDPJ(GBPDGMFBFGP KIBBPNKOOHI, [In] OOKBLLNDPGF.BOPMFOMBKBO JOCAJHEJLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x26E5D50", Offset = "0x26E5150", VA = "0x1826E5D50")]
		[CompilerGenerated]
		internal static bool ONEBOAKCBOF(LLLBPLEIMIJ BPBJHMOKKMO, FLFGJJGPOAG HJFGJAHGIBA, DHJMMNEBKJD LIDGFNBJMKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x26E5D20", Offset = "0x26E5120", VA = "0x1826E5D20")]
		[CompilerGenerated]
		internal static bool NJJOMABDDHM(DHJMMNEBKJD JBBAONHBPHP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct AHFFFDHNCEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public JHLAGGIINPD<HHOOHPCIFEM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public JHLAGGIINPD<AIKGKILEHOL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public LICKHDGKAMM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x26E62D0", Offset = "0x26E56D0", VA = "0x1826E62D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x26E6520", Offset = "0x26E5920", VA = "0x1826E6520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct NIOEEOHJPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public JHLAGGIINPD<HHOOHPCIFEM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public GKHNEBJMJEM<AIKGKILEHOL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public List<JHLAGGIINPD<AIKGKILEHOL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public LICKHDGKAMM localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public LKIBKIJNMNK localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public LICKHDGKAMM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x26E9DD0", Offset = "0x26E91D0", VA = "0x1826E9DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x26EA090", Offset = "0x26E9490", VA = "0x1826EA090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct EGOMENNKNMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public JHLAGGIINPD<HHOOHPCIFEM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public GKHNEBJMJEM<AIKGKILEHOL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public List<JHLAGGIINPD<AIKGKILEHOL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x26E8620", Offset = "0x26E7A20", VA = "0x1826E8620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x26E8860", Offset = "0x26E7C60", VA = "0x1826E8860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct PFOIJFDDLHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public JHLAGGIINPD<HHOOHPCIFEM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public GKHNEBJMJEM<AIKGKILEHOL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public JHLAGGIINPD<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public List<JHLAGGIINPD<AIKGKILEHOL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x26EC430", Offset = "0x26EB830", VA = "0x1826EC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x26EC670", Offset = "0x26EBA70", VA = "0x1826EC670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct DAGHFDHKKHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public GKHNEBJMJEM<HHOOHPCIFEM> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public GKHNEBJMJEM<AIKGKILEHOL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IReadOnlyDictionary<AIPNLKNEFCF, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<FAHJLKCNODD>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IReadOnlyDictionary<OHMLFNMKJCJ, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<GLKJMBBFOIK>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x26E68E0", Offset = "0x26E5CE0", VA = "0x1826E68E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x26E6E90", Offset = "0x26E6290", VA = "0x1826E6E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct FJMHJEIIBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public JHLAGGIINPD<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public JHLAGGIINPD<FNFJOKDEBDH> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public JHLAGGIINPD<ODIMEMELOCG> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x26E8CC0", Offset = "0x26E80C0", VA = "0x1826E8CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x26E9310", Offset = "0x26E8710", VA = "0x1826E9310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct HIEFMANOLMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public GKHNEBJMJEM<AIKGKILEHOL> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public GKHNEBJMJEM<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public JHLAGGIINPD<CBLNHLFJAIK> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JHLAGGIINPD<FAHJLKCNODD> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x26E96D0", Offset = "0x26E8AD0", VA = "0x1826E96D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x26E9A10", Offset = "0x26E8E10", VA = "0x1826E9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct DJAJNGJDJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public GKHNEBJMJEM<AIKGKILEHOL> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public GKHNEBJMJEM<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public JHLAGGIINPD<CBLNHLFJAIK> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public JHLAGGIINPD<GLKJMBBFOIK> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x26E7810", Offset = "0x26E6C10", VA = "0x1826E7810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x26E7B50", Offset = "0x26E6F50", VA = "0x1826E7B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct PFMKDJNMLMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public LFBNNEGDDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x26EC1A0", Offset = "0x26EB5A0", VA = "0x1826EC1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x26EC3C0", Offset = "0x26EB7C0", VA = "0x1826EC3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly LJJLNABEAFK IAGNOONNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly GIDBJEAMJJD LGGIMAOOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly LLGLIPKDJHJ EMMDPFAGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly DNEOPCAKCHF IEHONGOFMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly OFJLKGHEFDP LJCHPFPLBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private Dictionary<GKHNEBJMJEM<AIKGKILEHOL>, MKBHMHJPFFJ> JNKHLNKAPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[CompilerGenerated]
	private Action<GKHNEBJMJEM<AIKGKILEHOL>>? OHALNBNILLL;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GKHNEBJMJEM<HHOOHPCIFEM> CGOHBIHBJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x26D6EA0", Offset = "0x26D62A0", VA = "0x1826D6EA0", Slot = "4")]
		get
		{
			return default(GKHNEBJMJEM<HHOOHPCIFEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DNEOPCAKCHF PBKMNBAFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x26BDC40", Offset = "0x26BD040", VA = "0x1826BDC40", Slot = "5")]
		get
		{
			return default(DNEOPCAKCHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x26DC8D0", Offset = "0x26DBCD0", VA = "0x1826DC8D0")]
	public LFBNNEGDDLI(LJJLNABEAFK IOJHPNJDEEC, GIDBJEAMJJD JGFAIOAKBDM, LLGLIPKDJHJ HMIDLJJCLDH, OFJLKGHEFDP KGFEPJDCEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x26DAD50", Offset = "0x26DA150", VA = "0x1826DAD50", Slot = "65")]
	public JHLAGGIINPD<NAIAPDHIGPH> LCPJNCMJCPD(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(JHLAGGIINPD<NAIAPDHIGPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26D8630", Offset = "0x26D7A30", VA = "0x1826D8630", Slot = "66")]
	public JHLAGGIINPD<NIHOBGMELIC> HLNHPDKKINM(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(JHLAGGIINPD<NIHOBGMELIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x26D8710", Offset = "0x26D7B10", VA = "0x1826D8710", Slot = "6")]
	public (bool, bool) IAIIFBDKJFP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x26D6B70", Offset = "0x26D5F70", VA = "0x1826D6B70")]
	public bool FAPFPDBACGP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] BKPGIIMEFJM IBKMPBCBMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26DC760", Offset = "0x26DBB60", VA = "0x1826DC760", Slot = "8")]
	public bool PENHMFAIJME(CNNBKJKIMPE JBOHHEIANKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x26D68B0", Offset = "0x26D5CB0", VA = "0x1826D68B0", Slot = "9")]
	public bool DLINAFOFEHH(HDKIHMKOEDO EAKIIKDFLKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x26D69B0", Offset = "0x26D5DB0", VA = "0x1826D69B0", Slot = "10")]
	public FIEHNFDCFNO? EDPEGOJJDMP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x26D8570", Offset = "0x26D7970", VA = "0x1826D8570", Slot = "11")]
	public KNPCHEBHEBO? HINIMFGMEBD(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x26DACC0", Offset = "0x26DA0C0", VA = "0x1826DACC0", Slot = "12")]
	public JHLAGGIINPD<FNFJOKDEBDH>? LCEDGCEKFLK(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<GLKJMBBFOIK> NAANDAAKIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x26D8120", Offset = "0x26D7520", VA = "0x1826D8120", Slot = "13")]
	public JHLAGGIINPD<ODIMEMELOCG>? HGLNJDDMKAP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, JHLAGGIINPD<FAHJLKCNODD> DNDEDEPADFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x26DADD0", Offset = "0x26DA1D0", VA = "0x1826DADD0", Slot = "14")]
	public IEnumerable<JHLAGGIINPD<HHOOHPCIFEM>> LFGKDPLHJFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x26DBC90", Offset = "0x26DB090", VA = "0x1826DBC90", Slot = "15")]
	public IEnumerable<JHLAGGIINPD<IEGOHFFIIFG>> NPODMOJEEKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x26DABC0", Offset = "0x26D9FC0", VA = "0x1826DABC0", Slot = "16")]
	public string KFPFPGCAHKC(JHLAGGIINPD<IEGOHFFIIFG> AODCKIHJPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x26D5D30", Offset = "0x26D5130", VA = "0x1826D5D30", Slot = "17")]
	public string CDKFJCBMGGJ(JHLAGGIINPD<IEGOHFFIIFG> AODCKIHJPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x26DC3C0", Offset = "0x26DB7C0", VA = "0x1826DC3C0")]
	public MKBHMHJPFFJ? ONJKBLKGDBL([In] GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x26D6A70", Offset = "0x26D5E70", VA = "0x1826D6A70", Slot = "23")]
	public JHLAGGIINPD<PPBAIKDIKBC> EEDCGPEIHKG(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(JHLAGGIINPD<PPBAIKDIKBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x26DB820", Offset = "0x26DAC20", VA = "0x1826DB820")]
	public JHLAGGIINPD<AIKGKILEHOL> NAOPHIKAMHM(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] GKHNEBJMJEM<AIKGKILEHOL> KENGKNFKLFC)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x26D5B60", Offset = "0x26D4F60", VA = "0x1826D5B60", Slot = "33")]
	public JHLAGGIINPD<AIKGKILEHOL> BDOJPJOOFPK(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x26D5AE0", Offset = "0x26D4EE0", VA = "0x1826D5AE0", Slot = "34")]
	public JHLAGGIINPD<AIKGKILEHOL> BDNDNPGMHOF(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x26D6AF0", Offset = "0x26D5EF0", VA = "0x1826D6AF0")]
	public JHLAGGIINPD<AIKGKILEHOL>? EOALANNADAF(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] GKHNEBJMJEM<AIKGKILEHOL> KENGKNFKLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x26DC530", Offset = "0x26DB930", VA = "0x1826DC530", Slot = "25")]
	public IJJNMADIJMM? OPAAMADNKPP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x26D86B0", Offset = "0x26D7AB0", VA = "0x1826D86B0", Slot = "26")]
	public long HMGDCIPBOFN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x26DC7E0", Offset = "0x26DBBE0", VA = "0x1826DC7E0")]
	private void PLEFEICCJEA(GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x26DB310", Offset = "0x26DA710", VA = "0x1826DB310", Slot = "31")]
	public IEnumerable<(JHLAGGIINPD<HHOOHPCIFEM>, JHLAGGIINPD<AIKGKILEHOL>)> LMOCFJMBJKO(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x26D81B0", Offset = "0x26D75B0", VA = "0x1826D81B0", Slot = "32")]
	public JHLAGGIINPD<ODIMEMELOCG> HGLNJDDMKAP(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NAIAPDHIGPH> DNDEDEPADFH)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC30", Offset = "0x26DA030", VA = "0x1826DAC30", Slot = "35")]
	public JHLAGGIINPD<FNFJOKDEBDH> LCEDGCEKFLK(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NIHOBGMELIC> NAANDAAKIBL)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x26DB480", Offset = "0x26DA880", VA = "0x1826DB480")]
	private MKBHMHJPFFJ? MDLIFGBLOBB([In] GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x26D6F00", Offset = "0x26D6300", VA = "0x1826D6F00")]
	public LIHPLMOAJJK? FOANNIEELHA([In] GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x26D5DD0", Offset = "0x26D51D0", VA = "0x1826D5DD0")]
	public NDIEEALJBOE? NIHKKBGLPKI([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x26DB8A0", Offset = "0x26DACA0", VA = "0x1826DB8A0", Slot = "27")]
	public IEnumerable<DIOIGPDCAIB> NBGHLNOEMJE(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x26DBC00", Offset = "0x26DB000", VA = "0x1826DBC00", Slot = "28")]
	public bool NJPHMGCAPHM(JHLAGGIINPD<IEGOHFFIIFG> AODCKIHJPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x26D7110", Offset = "0x26D6510", VA = "0x1826D7110", Slot = "29")]
	public IEnumerable<BKPGIIMEFJM> GDHPOFIMPFI(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x26DBDB0", Offset = "0x26DB1B0", VA = "0x1826DBDB0", Slot = "30")]
	public IEnumerable<BKPGIIMEFJM> OBKMACCEBOJ(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x26DC340", Offset = "0x26DB740", VA = "0x1826DC340")]
	public JHLAGGIINPD<HHOOHPCIFEM> OMHCBAEKFCI([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return default(JHLAGGIINPD<HHOOHPCIFEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26D8C10", Offset = "0x26D8010", VA = "0x1826D8C10")]
	public JHLAGGIINPD<HHOOHPCIFEM>? IBAKONMHLJM([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26DB3C0", Offset = "0x26DA7C0", VA = "0x1826DB3C0")]
	private FLFGJJGPOAG? MDGLLFEMKBO([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26D5DD0", Offset = "0x26D51D0", VA = "0x1826D5DD0")]
	private NDIEEALJBOE? CKNDIJJHEGE([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26D7FF0", Offset = "0x26D73F0", VA = "0x1826D7FF0", Slot = "21")]
	public JHLAGGIINPD<HHOOHPCIFEM>? HCPHCEBEHPI(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26D6830", Offset = "0x26D5C30", VA = "0x1826D6830", Slot = "39")]
	public GKHNEBJMJEM<HHOOHPCIFEM> DJAEPLMJIGI(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return default(GKHNEBJMJEM<HHOOHPCIFEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x26D6570", Offset = "0x26D5970", VA = "0x1826D6570", Slot = "36")]
	public IEnumerable<FBGLCEJBMBF> DHPJDNHEOKL(LAACLDCMHLC MNEJEGPLGGL, bool ADHGEKJPIPI, bool IOEIKHPNPIH, bool JFMJFNEMBNC, bool CJDOIKBDENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26DAF80", Offset = "0x26DA380", VA = "0x1826DAF80", Slot = "37")]
	public FBGLCEJBMBF LKNJDHMKENK(LAACLDCMHLC MNEJEGPLGGL, NCIDOMLJCOM KPMMJEHHOOC, bool ADHGEKJPIPI, bool IOEIKHPNPIH, bool JFMJFNEMBNC, bool CJDOIKBDENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x26D8D20", Offset = "0x26D8120", VA = "0x1826D8D20")]
	public DIOIGPDCAIB MJBKHLIBBCH(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] BKPGIIMEFJM IBKMPBCBMAC)
	{
		return default(DIOIGPDCAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x26DA990", Offset = "0x26D9D90", VA = "0x1826DA990", Slot = "40")]
	public BKPGIIMEFJM KFIPFNKBKKA(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
		return default(BKPGIIMEFJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x26D8420", Offset = "0x26D7820", VA = "0x1826D8420", Slot = "41")]
	[AsyncStateMachine(typeof(AHFFFDHNCEC))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> HHEDBPAMMPC(JHLAGGIINPD<HHOOHPCIFEM> KNMPHLGKNGC, JHLAGGIINPD<AIKGKILEHOL> MPAHHEHMCIK, LICKHDGKAMM IALPEJIGIPD, bool LKCIIALEPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x26D6F90", Offset = "0x26D6390", VA = "0x1826D6F90", Slot = "42")]
	[AsyncStateMachine(typeof(NIOEEOHJPFA))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> GCLFCFNDKJK(JHLAGGIINPD<HHOOHPCIFEM> KNMPHLGKNGC, GKHNEBJMJEM<AIKGKILEHOL> MPAHHEHMCIK, List<JHLAGGIINPD<AIKGKILEHOL>> EFHBBPJOJCO, LICKHDGKAMM LIELHBFDIPE, LKIBKIJNMNK GHFCKLBABMC, LICKHDGKAMM IALPEJIGIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x26D5BE0", Offset = "0x26D4FE0", VA = "0x1826D5BE0", Slot = "45")]
	[AsyncStateMachine(typeof(EGOMENNKNMF))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> CCGBNNMOKBO(JHLAGGIINPD<HHOOHPCIFEM> KNMPHLGKNGC, GKHNEBJMJEM<AIKGKILEHOL> MPAHHEHMCIK, List<JHLAGGIINPD<AIKGKILEHOL>> EFHBBPJOJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x26DA830", Offset = "0x26D9C30", VA = "0x1826DA830", Slot = "46")]
	[AsyncStateMachine(typeof(PFOIJFDDLHM))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> KEMHIEMINFK(JHLAGGIINPD<HHOOHPCIFEM> KNMPHLGKNGC, GKHNEBJMJEM<AIKGKILEHOL> MPAHHEHMCIK, JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, List<JHLAGGIINPD<AIKGKILEHOL>> EFHBBPJOJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x26DB6B0", Offset = "0x26DAAB0", VA = "0x1826DB6B0", Slot = "43")]
	public (IReadOnlyDictionary<AIPNLKNEFCF, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<FAHJLKCNODD>)>, IReadOnlyDictionary<OHMLFNMKJCJ, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<GLKJMBBFOIK>)>) MIAJPEAKJAG(GKHNEBJMJEM<HHOOHPCIFEM> PLLDOLANNPH, JHLAGGIINPD<AIKGKILEHOL> MPAHHEHMCIK)
	{
		return default((IReadOnlyDictionary<AIPNLKNEFCF, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<FAHJLKCNODD>)>, IReadOnlyDictionary<OHMLFNMKJCJ, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<GLKJMBBFOIK>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x26DC030", Offset = "0x26DB430", VA = "0x1826DC030", Slot = "44")]
	[AsyncStateMachine(typeof(DAGHFDHKKHI))]
	public Task OCADIFPEFMA(GKHNEBJMJEM<HHOOHPCIFEM> PLLDOLANNPH, GKHNEBJMJEM<AIKGKILEHOL> MPAHHEHMCIK, IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> GMBKPPMKBHB, IReadOnlyDictionary<AIPNLKNEFCF, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<FAHJLKCNODD>)> LDCKOIPALGH, IReadOnlyDictionary<OHMLFNMKJCJ, (JHLAGGIINPD<CBLNHLFJAIK>, JHLAGGIINPD<GLKJMBBFOIK>)> BHLFKCNAOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x26DBD40", Offset = "0x26DB140", VA = "0x1826DBD40", Slot = "47")]
	public bool OAHAKDNDKJA(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x26D6930", Offset = "0x26D5D30", VA = "0x1826D6930", Slot = "48")]
	public bool DLPILJKMFDN(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x26D64F0", Offset = "0x26D58F0", VA = "0x1826D64F0", Slot = "49")]
	public bool DFOFBHAGJJB(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x26D5DA0", Offset = "0x26D51A0", VA = "0x1826D5DA0")]
	public BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN> PEDCIBPMLBA([In] OOKBLLNDPGF.GNFONCOCCDK KBIBHMCLJNL)
	{
		return default(BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x26D8E90", Offset = "0x26D8290", VA = "0x1826D8E90", Slot = "51")]
	[AsyncStateMachine(typeof(FJMHJEIIBKB))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> IOGPAMIEEKC(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x26D6130", Offset = "0x26D5530", VA = "0x1826D6130", Slot = "52")]
	public BECHBBIPIFM<MGIGLDJHHIH, HAPFLJDLPEC> DDAOHFONHAD(GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP, MGIGLDJHHIH CGPLCKJABFM, LKIBKIJNMNK MAONCCICKLA)
	{
		return default(BECHBBIPIFM<MGIGLDJHHIH, HAPFLJDLPEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x26D5E70", Offset = "0x26D5270", VA = "0x1826D5E70", Slot = "53")]
	[AsyncStateMachine(typeof(HIEFMANOLMB))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> CNKDEDNBHHL(GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP, GKHNEBJMJEM<AIKGKILEHOL> BIBGJDEEGDK, JHLAGGIINPD<CBLNHLFJAIK> NMPMNKLCJID, JHLAGGIINPD<FAHJLKCNODD> ELDPAHOBCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x26D5FD0", Offset = "0x26D53D0", VA = "0x1826D5FD0", Slot = "54")]
	[AsyncStateMachine(typeof(DJAJNGJDJBD))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> DBLFAEDLIFE(GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP, GKHNEBJMJEM<AIKGKILEHOL> HIMHCCAPGBH, JHLAGGIINPD<CBLNHLFJAIK> PPBKHLAPKKE, JHLAGGIINPD<GLKJMBBFOIK> CIPHPJIJIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x26DB590", Offset = "0x26DA990", VA = "0x1826DB590", Slot = "55")]
	public FFNOIDDEFLC MFGHIGPBBPC()
	{
		return default(FFNOIDDEFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x26DAE60", Offset = "0x26DA260", VA = "0x1826DAE60", Slot = "56")]
	public FFNOIDDEFLC LFOHPFGKABL()
	{
		return default(FFNOIDDEFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x26D8240", Offset = "0x26D7640", VA = "0x1826D8240", Slot = "58")]
	public IAOBFPCPJML HHDNPNPJIEL(FHNEONLKGCM JEPOOJBBEFK, JHLAGGIINPD<HHOOHPCIFEM> JNNOIANPDOB, IEnumerable<GKHNEBJMJEM<HHOOHPCIFEM>> OBJEPBEAGJP, IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>> EFHBBPJOJCO, ISet<GKHNEBJMJEM<DEAOPEBPHHC>>? HCBDHPCEDKJ)
	{
		return default(IAOBFPCPJML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x26D6670", Offset = "0x26D5A70", VA = "0x1826D6670")]
	private IAOBFPCPJML DINPGHPKDBL(FHNEONLKGCM JEPOOJBBEFK, JHLAGGIINPD<HHOOHPCIFEM> JNNOIANPDOB, IEnumerable<GKHNEBJMJEM<HHOOHPCIFEM>> OBJEPBEAGJP, IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>> EFHBBPJOJCO, ISet<GKHNEBJMJEM<DEAOPEBPHHC>>? HCBDHPCEDKJ)
	{
		return default(IAOBFPCPJML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x26DB960", Offset = "0x26DAD60", VA = "0x1826DB960", Slot = "57")]
	public IAOBFPCPJML NIENGHHIEDM(FHNEONLKGCM JEPOOJBBEFK, JHLAGGIINPD<HHOOHPCIFEM> JNNOIANPDOB, IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>> EFHBBPJOJCO, IEnumerable<IBDHKNDIHNK> LDAIHJLBDPI, ISet<GKHNEBJMJEM<DEAOPEBPHHC>>? HCBDHPCEDKJ)
	{
		return default(IAOBFPCPJML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x26D9AE0", Offset = "0x26D8EE0", VA = "0x1826D9AE0")]
	private static IEnumerable<GKHNEBJMJEM<HHOOHPCIFEM>> JFFAPIAKGNA(IEnumerable<IBDHKNDIHNK> LDAIHJLBDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x26D7410", Offset = "0x26D6810", VA = "0x1826D7410")]
	private IEnumerable<GKHNEBJMJEM<AIKGKILEHOL>> GHFEJEMDGMA(IEnumerable<IBDHKNDIHNK> LDAIHJLBDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x26D8C90", Offset = "0x26D8090", VA = "0x1826D8C90", Slot = "59")]
	public List<IKIFMGOIBDM> ICBLABFHIFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x26D78B0", Offset = "0x26D6CB0", VA = "0x1826D78B0")]
	public (List<IKIFMGOIBDM>, bool) GKOLJHCCOJK([In] BEHBFCALFDC JAKLBKPBALH, string FAJBNOJIOHK, [In] PFJPNDJBJHP IAJHAKKFGOO, DHLLHPILJFE KOINNIKDMKL, HHOMOIKIKPC HMMGAKMLGNC)
	{
		return default((List<IKIFMGOIBDM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x26DC670", Offset = "0x26DBA70", VA = "0x1826DC670", Slot = "61")]
	public bool PBOAGLEJEGL(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x26DC870", Offset = "0x26DBC70", VA = "0x1826DC870")]
	internal void PLNCHJLGFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x26DB530", Offset = "0x26DA930", VA = "0x1826DB530")]
	internal Task MEDBIBKEEBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x26D9E60", Offset = "0x26D9260", VA = "0x1826D9E60", Slot = "62")]
	public BECHBBIPIFM<JHLAGGIINPD<FNFJOKDEBDH>?, FFKOEKDBPON> JLJCBCJAMCF(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(BECHBBIPIFM<JHLAGGIINPD<FNFJOKDEBDH>?, FFKOEKDBPON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x26D90B0", Offset = "0x26D84B0", VA = "0x1826D90B0", Slot = "63")]
	public BECHBBIPIFM<JHLAGGIINPD<ODIMEMELOCG>?, FFKOEKDBPON> JEHLMKIPIHN(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(BECHBBIPIFM<JHLAGGIINPD<ODIMEMELOCG>?, FFKOEKDBPON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x26D8FC0", Offset = "0x26D83C0", VA = "0x1826D8FC0", Slot = "64")]
	[AsyncStateMachine(typeof(PFMKDJNMLMG))]
	public Task<BECHBBIPIFM<FGGPIMEAIEJ, FFKOEKDBPON>> JANGOALJFJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x26D68A0", Offset = "0x26D5CA0", VA = "0x1826D68A0", Slot = "7")]
	private bool DJFLFIICGKN(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] BKPGIIMEFJM IBKMPBCBMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x26D5DD0", Offset = "0x26D51D0", VA = "0x1826D5DD0", Slot = "18")]
	private NDIEEALJBOE LIJFIHEHBFJ([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x26DC660", Offset = "0x26DBA60", VA = "0x1826DC660", Slot = "19")]
	private JHLAGGIINPD<HHOOHPCIFEM> OPAKINJOGDB([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return default(JHLAGGIINPD<HHOOHPCIFEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x26D8C10", Offset = "0x26D8010", VA = "0x1826D8C10", Slot = "20")]
	private JHLAGGIINPD<HHOOHPCIFEM>? KOLGLFFBMJF([In] GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x26DC1F0", Offset = "0x26DB5F0", VA = "0x1826DC1F0", Slot = "22")]
	private MKBHMHJPFFJ OMDODCCJEPO([In] GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x26DB820", Offset = "0x26DAC20", VA = "0x1826DB820", Slot = "24")]
	private JHLAGGIINPD<AIKGKILEHOL> NOKAPBPKDIA(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] GKHNEBJMJEM<AIKGKILEHOL> KENGKNFKLFC)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x26D8D20", Offset = "0x26D8120", VA = "0x1826D8D20", Slot = "38")]
	private DIOIGPDCAIB IFJGFNEAPNJ(JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, [In] BKPGIIMEFJM IBKMPBCBMAC)
	{
		return default(DIOIGPDCAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x26D5DA0", Offset = "0x26D51A0", VA = "0x1826D5DA0", Slot = "50")]
	private BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN> CFCHLLCBIGD([In] OOKBLLNDPGF.GNFONCOCCDK KBIBHMCLJNL)
	{
		return default(BECHBBIPIFM<OOKBLLNDPGF.DJKLKDBCKOL, DJJEDLFAHGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x26D9A80", Offset = "0x26D8E80", VA = "0x1826D9A80", Slot = "60")]
	private (List<IKIFMGOIBDM>, bool) JEJNPIKPKNC([In] BEHBFCALFDC JAKLBKPBALH, string FAJBNOJIOHK, [In] PFJPNDJBJHP IAJHAKKFGOO, DHLLHPILJFE KOINNIKDMKL, HHOMOIKIKPC HMMGAKMLGNC)
	{
		return default((List<IKIFMGOIBDM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x26DB290", Offset = "0x26DA690", VA = "0x1826DB290")]
	[CompilerGenerated]
	private EBMDGPLCFJP LLEGEEOALCD(IGCHBCCCIIG DPBBAIABGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x26D73A0", Offset = "0x26D67A0", VA = "0x1826D73A0")]
	[CompilerGenerated]
	private LIHPLMOAJJK GGNFGEPBLGK(GKHNEBJMJEM<AIKGKILEHOL> DPBBAIABGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x26DC180", Offset = "0x26DB580", VA = "0x1826DC180")]
	[CompilerGenerated]
	private FLFGJJGPOAG OGAOOFOPIGM(GKHNEBJMJEM<HHOOHPCIFEM> DPBBAIABGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x26D7F80", Offset = "0x26D7380", VA = "0x1826D7F80")]
	[CompilerGenerated]
	private LIHPLMOAJJK HBDHKGJOAAC(GKHNEBJMJEM<AIKGKILEHOL> DPBBAIABGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x26D5E00", Offset = "0x26D5200", VA = "0x1826D5E00")]
	[CompilerGenerated]
	private FLFGJJGPOAG CMFPMKALKEJ(GKHNEBJMJEM<HHOOHPCIFEM> DPBBAIABGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class EBMDGPLCFJP : FBGLCEJBMBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct NNCJGDILECJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<JHLAGGIINPD<JGBFKPDFGOJ>, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public EBMDGPLCFJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public GKHNEBJMJEM<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public GKHNEBJMJEM<AIKGKILEHOL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<JGBFKPDFGOJ>, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x26EA100", Offset = "0x26E9500", VA = "0x1826EA100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x26EA380", Offset = "0x26E9780", VA = "0x1826EA380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct GENECCOKHBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<JHLAGGIINPD<HEKBHBJIOHJ>, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public EBMDGPLCFJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public GKHNEBJMJEM<HHOOHPCIFEM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public GKHNEBJMJEM<AIKGKILEHOL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public JHLAGGIINPD<CBLNHLFJAIK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<BECHBBIPIFM<JHLAGGIINPD<HEKBHBJIOHJ>, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x26E9380", Offset = "0x26E8780", VA = "0x1826E9380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x26E9600", Offset = "0x26E8A00", VA = "0x1826E9600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly IGCHBCCCIIG LGGMBOLDHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly GIDBJEAMJJD LGGIMAOOHMK;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey EPDBBGELEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string IFIKKBBCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x26E82F0", Offset = "0x26E76F0", VA = "0x1826E82F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public IGCHBCCCIIG PBAHFLFMMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x26E8320", Offset = "0x26E7720", VA = "0x1826E8320")]
	public EBMDGPLCFJP(IGCHBCCCIIG JEFLBMDIBEI, GIDBJEAMJJD JGFAIOAKBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x26E8010", Offset = "0x26E7410", VA = "0x1826E8010", Slot = "6")]
	[AsyncStateMachine(typeof(NNCJGDILECJ))]
	public Task<BECHBBIPIFM<JHLAGGIINPD<JGBFKPDFGOJ>, FFKOEKDBPON>> BLGEELINBKA(GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP, GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, string KCCMEIDBNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x26E8180", Offset = "0x26E7580", VA = "0x1826E8180", Slot = "7")]
	[AsyncStateMachine(typeof(GENECCOKHBH))]
	public Task<BECHBBIPIFM<JHLAGGIINPD<HEKBHBJIOHJ>, FFKOEKDBPON>> IIPCCEECOCK(GKHNEBJMJEM<HHOOHPCIFEM> APKPABPIPHP, GKHNEBJMJEM<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK, string KCCMEIDBNGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class ONJCFFFIKDB : HLBKNJBMDKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly IGCHBCCCIIG CHOIFCDJHJG;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly HashSet<IGCHBCCCIIG> PNAFCLADLDM;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly HashSet<IGCHBCCCIIG> GMOCFMOJNKN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly HashSet<IGCHBCCCIIG> IOLHOODEKIC;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey HGAANBOBAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x26EC010", Offset = "0x26EB410", VA = "0x1826EC010", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DPGHKOPCBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x26EC000", Offset = "0x26EB400", VA = "0x1826EC000", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool LDJBCEABEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x26EC060", Offset = "0x26EB460", VA = "0x1826EC060", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool FBFLLNAGBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x26EBF80", Offset = "0x26EB380", VA = "0x1826EBF80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x26EA700", Offset = "0x26E9B00", VA = "0x1826EA700")]
	public bool FHKPBMIIJEA(string OOEMJLHLIHJ, [Out] DHEDMIPOEEK NNJPHGNNKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public ONJCFFFIKDB(IGCHBCCCIIG GDOONENKGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x26EA970", Offset = "0x26E9D70", VA = "0x1826EA970")]
	internal static TypeKey ICCCKKEAIKN(IGCHBCCCIIG KHNCICOHHHJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x26E82F0", Offset = "0x26E76F0", VA = "0x1826E82F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public readonly struct EGDNLPADEIF : FIOMGIHMKCL.KCPOPCNCDEG<MEKIHADOGMJ, FGGPIMEAIEJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x26E8530", Offset = "0x26E7930", VA = "0x1826E8530", Slot = "4")]
	public int ENHCPDBNFOG(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x26E84F0", Offset = "0x26E78F0", VA = "0x1826E84F0", Slot = "5")]
	public MEKIHADOGMJ CAPMJHFNDJN(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x26E8500", Offset = "0x26E7900", VA = "0x1826E8500", Slot = "6")]
	public MEKIHADOGMJ DGEEHBBAMMH(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x26E85C0", Offset = "0x26E79C0", VA = "0x1826E85C0", Slot = "7")]
	public IReadOnlyList<MEKIHADOGMJ> KJHINEIAANH(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x26E8590", Offset = "0x26E7990", VA = "0x1826E8590", Slot = "8")]
	public MEKIHADOGMJ[] IGAJMCBOMAG(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF, int PMDHKOOLGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x26E8570", Offset = "0x26E7970", VA = "0x1826E8570", Slot = "9")]
	public bool HLOPEPBBFMP(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x26E85E0", Offset = "0x26E79E0", VA = "0x1826E85E0", Slot = "10")]
	public bool KPPINIILGHF(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x26E85A0", Offset = "0x26E79A0", VA = "0x1826E85A0", Slot = "11")]
	public bool JNDBCHGEMJO(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x26E84D0", Offset = "0x26E78D0", VA = "0x1826E84D0", Slot = "12")]
	public bool ACLODAKJLCL(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x26E8550", Offset = "0x26E7950", VA = "0x1826E8550", Slot = "13")]
	public bool FCAHJNPGMCE(FGGPIMEAIEJ DJDKBDCCAEC, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x26E8600", Offset = "0x26E7A00", VA = "0x1826E8600", Slot = "14")]
	public bool OBBFMODNIKD(FGGPIMEAIEJ PLCJAHDMBHK, MEKIHADOGMJ PDHMHKIHKPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class JPHHNHGOIOM : KKBHJHOOKPD
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public ADBGCEBAHGP.KEBEELDICCF AOODLEMGABD
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x26E9A80", Offset = "0x26E8E80", VA = "0x1826E9A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract KJPNNIHKIBH.ONDMOAGPIPA KDIFAIPKMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract LJJLNABEAFK.OHEPGMCOLNP JDFMAFJAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract BFJFGICDBMB.FHINOFCPEOE PPDGMLJFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public DFEACKPIPPA.GIGBFNDFAEE<MPNDOKPDCHB, MEKIHADOGMJ, LJJLNABEAFK> HBCBPEINEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x26E9AD0", Offset = "0x26E8ED0", VA = "0x1826E9AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract DHEBDOCLJNA.CEFCHEPAGDP AFHPELAEKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract PPPNMBLCMMH FBGHFLLJKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract FGPBBLMONCG LMDLKAHHEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract EHIHMPMFFMC DACLJBNMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract BCEBBPJHFFP HDICCJHNFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract IMBIBBDAGKI APAGKPLNEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected JPHHNHGOIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CDECIANFPHO : DLDIAPJHLNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct NNGKCFCHPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CDECIANFPHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public MEKIHADOGMJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x26EA3F0", Offset = "0x26E97F0", VA = "0x1826EA3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x26EA690", Offset = "0x26E9A90", VA = "0x1826EA690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct EOJCBLMOCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CDECIANFPHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public IReadOnlyList<MEKIHADOGMJ> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x26E88D0", Offset = "0x26E7CD0", VA = "0x1826E88D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x26E8C50", Offset = "0x26E8050", VA = "0x1826E8C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly FDABGINDJJA DKPLKPFKKOI;

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public CDECIANFPHO(FDABGINDJJA GBMFHBEGEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x26E6680", Offset = "0x26E5A80", VA = "0x1826E6680")]
	[AsyncStateMachine(typeof(NNGKCFCHPPF))]
	private Task<BECHBBIPIFM<object, FFKOEKDBPON>> EONDIGCKHLE(MEKIHADOGMJ PDHMHKIHKPF, bool HCKGLDGPPOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x26E67B0", Offset = "0x26E5BB0", VA = "0x1826E67B0", Slot = "4")]
	[AsyncStateMachine(typeof(EOJCBLMOCAK))]
	public Task<BECHBBIPIFM<GGFIAIGFJGE, FFKOEKDBPON>> NOKJGMCFCJL(IReadOnlyList<MEKIHADOGMJ> BJHPHPBLMDP, bool HCKGLDGPPOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct GPNAFOAEJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	internal IBIKIEPHJIL<HFFHDMNMGNC, GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>, MEKIHADOGMJ, DPCAALEMNLE> CHOIFCDJHJG;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x26BAAA0", Offset = "0x26B9EA0", VA = "0x1826BAAA0")]
	private GPNAFOAEJGE([In] IBIKIEPHJIL<HFFHDMNMGNC, GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>, MEKIHADOGMJ, DPCAALEMNLE> CHJBHCHFOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x26E9670", Offset = "0x26E8A70", VA = "0x1826E9670")]
	public static GPNAFOAEJGE FABCCGGAHMJ()
	{
		return default(GPNAFOAEJGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class KJJENMHIOOH
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static IBIKIEPHJIL<HFFHDMNMGNC, GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>, MEKIHADOGMJ, DPCAALEMNLE> JCODPENOIHO(this GPNAFOAEJGE KBBJDOAJMAF)
	{
		return default(IBIKIEPHJIL<HFFHDMNMGNC, GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>, MEKIHADOGMJ, DPCAALEMNLE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct DPCAALEMNLE : IGPHAPJJMCK.ECHECMPNIPL<HFFHDMNMGNC, GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>, MEKIHADOGMJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x26E7C20", Offset = "0x26E7020", VA = "0x1826E7C20", Slot = "7")]
	public MEKIHADOGMJ HDDHPOGAHPH(HFFHDMNMGNC[] OMLJGBHCBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x1047550", Offset = "0x1046950", VA = "0x181047550")]
	public GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD> GAPCOFLNMCD([In] HFFHDMNMGNC NHMLIICCBOF)
	{
		return default(GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x10669C0", Offset = "0x1065DC0", VA = "0x1810669C0")]
	public int DAPFEGNMAOL([In] HFFHDMNMGNC PHIAMLHMBEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x26E7E10", Offset = "0x26E7210", VA = "0x1826E7E10")]
	public int NOKGMIJHIHD([In] HFFHDMNMGNC NHMLIICCBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x10669C0", Offset = "0x1065DC0", VA = "0x1810669C0", Slot = "4")]
	private int NHODKLGLFHD([In] HFFHDMNMGNC NHMLIICCBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x26E7E10", Offset = "0x26E7210", VA = "0x1826E7E10", Slot = "5")]
	private int NMKIAJIAHDC([In] HFFHDMNMGNC NHMLIICCBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x1047550", Offset = "0x1046950", VA = "0x181047550", Slot = "6")]
	private GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD> HALGFALCPPG([In] HFFHDMNMGNC NHMLIICCBOF)
	{
		return default(GKHNEBJMJEM<HFFHDMNMGNC.FFGPLMNDAGD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public struct DLJOFELEGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	internal BLCKOBFDCMD<NKPOEBOJMPD, MEKIHADOGMJ, EBLGLLLELEB> CHOIFCDJHJG;

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x26BAAA0", Offset = "0x26B9EA0", VA = "0x1826BAAA0")]
	private DLJOFELEGFC([In] BLCKOBFDCMD<NKPOEBOJMPD, MEKIHADOGMJ, EBLGLLLELEB> HKNBLFOAMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x26E7BC0", Offset = "0x26E6FC0", VA = "0x1826E7BC0")]
	public static DLJOFELEGFC FABCCGGAHMJ()
	{
		return default(DLJOFELEGFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class JMGBJDCALCN
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static BLCKOBFDCMD<NKPOEBOJMPD, MEKIHADOGMJ, EBLGLLLELEB> JCODPENOIHO(this DLJOFELEGFC KBBJDOAJMAF)
	{
		return default(BLCKOBFDCMD<NKPOEBOJMPD, MEKIHADOGMJ, EBLGLLLELEB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public struct EBLGLLLELEB : FLADPBFHJKD.LLCPBBEMNEI<NKPOEBOJMPD, MEKIHADOGMJ>
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50")]
	public int CPGADLGLFKB([In] NKPOEBOJMPD PHIAMLHMBEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x26E7E20", Offset = "0x26E7220", VA = "0x1826E7E20", Slot = "5")]
	public MEKIHADOGMJ GGEACLDPBPM(NKPOEBOJMPD[] CCDAOIBKEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50", Slot = "4")]
	private int ELJJKOOMNPK([In] NKPOEBOJMPD PHIAMLHMBEL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class NGEHENJFBLK : IDMJKCLDJLO, DJJEDLFAHGN, FFKOEKDBPON, HAPFLJDLPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly HAPFLJDLPEC? JKKJFIIJJLH;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public HGEDKOIDJPB JNHEJAAFHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(HGEDKOIDJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override HAPFLJDLPEC? CPFDANEBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C10", Offset = "0x26E9010", VA = "0x1826E9C10", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D90", Offset = "0x26E9190", VA = "0x1826E9D90")]
	private NGEHENJFBLK(HGEDKOIDJPB JCPHFIALCGL, HAPFLJDLPEC? FKLFOLGEIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x26E9B90", Offset = "0x26E8F90", VA = "0x1826E9B90")]
	public static NGEHENJFBLK ALHMHFPFCJA(HAPFLJDLPEC FKLFOLGEIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D20", Offset = "0x26E9120", VA = "0x1826E9D20")]
	public static NGEHENJFBLK FMBJLAIANJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x26E9B20", Offset = "0x26E8F20", VA = "0x1826E9B20")]
	public static NGEHENJFBLK AJLGBACJMEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public static class NGMAECOKMMJ
{
	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x3859E20", Offset = "0x3859220", VA = "0x183859E20")]
	public static BECHBBIPIFM<TOk, DJJEDLFAHGN> NMNPLCDNMLB<TOk>([In] this BECHBBIPIFM<TOk, DJJEDLFAHGN> KBBJDOAJMAF, HAPFLJDLPEC FKLFOLGEIKM) where TOk : notnull
	{
		return default(BECHBBIPIFM<TOk, DJJEDLFAHGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3859D20", Offset = "0x3859120", VA = "0x183859D20")]
	public static BECHBBIPIFM<TOk?, DJJEDLFAHGN?> GOMIFLPPHBA<TOk>([In] this BECHBBIPIFM<TOk, DJJEDLFAHGN> KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<TOk, DJJEDLFAHGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3859C30", Offset = "0x3859030", VA = "0x183859C30")]
	public static BECHBBIPIFM<TOk?, DJJEDLFAHGN?> FADJKHFKDKE<TOk>([In] this BECHBBIPIFM<TOk, DJJEDLFAHGN> KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<TOk, DJJEDLFAHGN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface PPPNMBLCMMH
{
	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NKDCIMKAAPP([In] BECHBBIPIFM<FGGPIMEAIEJ, HAPFLJDLPEC> APLCGCDLEGH);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class DOIBKMILOOL
{
	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x350BE40", Offset = "0x350B240", VA = "0x18350BE40")]
	public static bool NKDCIMKAAPP<TOk, TErr>(this PPPNMBLCMMH KBBJDOAJMAF, [In] BECHBBIPIFM<TOk, TErr> APLCGCDLEGH) where TOk : notnull where TErr : notnull, HAPFLJDLPEC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface FGPBBLMONCG
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	HCCEHEPDLFC GFINBDPBGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface EHIHMPMFFMC
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MINJKFOIMDC LNBHLFAGIAJ(int PALICIKBOFC);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface DHPDCHDJKNC
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface FLNJOMFCPMN
{
	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCKJJBEKAGP? IIAGPCGLNGO(JHLAGGIINPD<CBLNHLFJAIK> HEGFLJHIFOK);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface NGEJHGLCLCI
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface BCKJJBEKAGP
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGEJHGLCLCI? ELICCGIOFHD(JHLAGGIINPD<JGBFKPDFGOJ> AOEMJMEEFGB);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DHPDCHDJKNC? JCDKMEKAKKP(JHLAGGIINPD<HEKBHBJIOHJ> OCPCMLPOCAN);
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface BCEBBPJHFFP
{
	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PNHAGBNHMAM(string OOEMJLHLIHJ, string FAJBNOJIOHK);
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface IMBIBBDAGKI
{
	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FLNJOMFCPMN? CLANFBOCPBL([In] GKHNEBJMJEM<LFIPNIKKFOL> IJPBHONNMOK);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DEHOHIDJAFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private struct EDMHHPAACMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int PINFDPDNIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public DGOMHNDAFIH? EOKNLFAJONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public DGOMHNDAFIH? AGPHDJNHOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public readonly List<MEKIHADOGMJ> PICJFGFFGFL;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x26E8480", Offset = "0x26E7880", VA = "0x1826E8480")]
		private EDMHHPAACMO(int COPLIEINKOF, DGOMHNDAFIH? DGPLCCPEKBN, DGOMHNDAFIH? AKPPGJHGBLF, List<MEKIHADOGMJ> BJHPHPBLMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x26E83C0", Offset = "0x26E77C0", VA = "0x1826E83C0")]
		public static EDMHHPAACMO FABCCGGAHMJ()
		{
			return default(EDMHHPAACMO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly KCIJCJKFKDP<EDMHHPAACMO> CIOBKACKPNK;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public static DEHOHIDJAFJ IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x26E7550", Offset = "0x26E6950", VA = "0x1826E7550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool NIADKOMLMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xC461D0", Offset = "0xC455D0", VA = "0x180C461D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x26E75A0", Offset = "0x26E69A0", VA = "0x1826E75A0")]
	public void PKLHHLGMPID(LLLBPLEIMIJ AKPPGJHGBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6EF0", Offset = "0x26E62F0", VA = "0x1826E6EF0")]
	public void FKDFFCFFAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x26E71F0", Offset = "0x26E65F0", VA = "0x1826E71F0")]
	private static string? IADACGLPDGM([In] EDMHHPAACMO JBJHCMPOAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x26E7760", Offset = "0x26E6B60", VA = "0x1826E7760")]
	public DEHOHIDJAFJ()
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
