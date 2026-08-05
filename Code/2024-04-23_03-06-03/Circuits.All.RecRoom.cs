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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E20A50", Offset = "0x1E1FA50", VA = "0x181E20A50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DPBBAOGMDLF : IDisposable, EEAICBGDFAO, CIMGIOMJDPD, PLPEMLBJLJA, GJDGAECEFPF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class BMKOHKMDPIK : LONBFHAKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int JONOAAGIFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E076B0", Offset = "0x1E066B0", VA = "0x181E076B0", Slot = "5")]
		public PFLJFFJEMNE KPDJIKINPMD(ODKJBDAKIBF.KNGMNLKMDEI AKOGIKBAMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void OOKHLEPGFLJ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void EIKMBPIPJNJ();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E07880", Offset = "0x1E06880", VA = "0x181E07880", Slot = "13")]
		public virtual void MOBHOFIPEII(DPBBAOGMDLF PDDFEIFGNBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E07800", Offset = "0x1E06800", VA = "0x181E07800", Slot = "14")]
		public virtual void KPGKFDJIAML(DPBBAOGMDLF PDDFEIFGNBJ, EBBJCOBMEJP LNMJHEPMAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		protected BMKOHKMDPIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LONBFHAKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int JONOAAGIFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PFLJFFJEMNE KPDJIKINPMD(ODKJBDAKIBF.KNGMNLKMDEI AKOGIKBAMPF);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OOKHLEPGFLJ();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EIKMBPIPJNJ();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MOBHOFIPEII(DPBBAOGMDLF PDDFEIFGNBJ);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KPGKFDJIAML(DPBBAOGMDLF PDDFEIFGNBJ, EBBJCOBMEJP LNMJHEPMAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JKBBAJJKFLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly EHAEGNKHIGE<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> MOIDKEPIEEH;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E14D30", Offset = "0x1E13D30", VA = "0x181E14D30")]
		internal JKBBAJJKFLI(EHAEGNKHIGE<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> OFFMGNOKEOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PEMAMIDKEFH : BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly PEMAMIDKEFH AFPJCELPLKK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		private PEMAMIDKEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAE2650", Offset = "0xAE1650", VA = "0x180AE2650", Slot = "4")]
		public JMJNNGFFIBF BEFJNNIIHGB(EBBJCOBMEJP HFLBADIEKAM)
		{
			return default(JMJNNGFFIBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E21F00", Offset = "0x1E20F00", VA = "0x181E21F00", Slot = "5")]
		public void MOBHOFIPEII(DPBBAOGMDLF OPFDMIOAEHD, EBBJCOBMEJP LNMJHEPMAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E21DF0", Offset = "0x1E20DF0", VA = "0x181E21DF0", Slot = "6")]
		public void KPGKFDJIAML(DPBBAOGMDLF OPFDMIOAEHD, EBBJCOBMEJP LNMJHEPMAAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct ELIEHEPJNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KKILFCDNNAI<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> MOIDKEPIEEH;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C700", Offset = "0x1E0B700", VA = "0x181E0C700")]
		internal ELIEHEPJNPG(KKILFCDNNAI<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C6B0", Offset = "0x1E0B6B0", VA = "0x181E0C6B0")]
		public static ELIEHEPJNPG MGIIAIMPALM()
		{
			return default(ELIEHEPJNPG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MICMOOFNNAM : PANFIKCELOA.HGLACLICILB<EBBJCOBMEJP, DPBBAOGMDLF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct FJBCHIBLPCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DPBBAOGMDLF receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EBBJCOBMEJP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public MICMOOFNNAM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D360", Offset = "0x1E0C360", VA = "0x181E0D360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D540", Offset = "0x1E0C540", VA = "0x181E0D540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAC6850", Offset = "0xAC5850", VA = "0x180AC6850", Slot = "4")]
		public JLADLGKIDDG<CEBMMKCJHFK> NCNLCJFHPOL(DPBBAOGMDLF DKHAKCOFILG)
		{
			return default(JLADLGKIDDG<CEBMMKCJHFK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DC40", Offset = "0x1E1CC40", VA = "0x181E1DC40", Slot = "5")]
		[AsyncStateMachine(typeof(FJBCHIBLPCB))]
		public Task<PGLGENBDGKP<object, AABLFGLHLFL>> HJHJPPHLNNE(DPBBAOGMDLF DKHAKCOFILG, EBBJCOBMEJP LNMJHEPMAAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DC20", Offset = "0x1E1CC20", VA = "0x181E1DC20", Slot = "6")]
		public EBBJCOBMEJP[] AMGECOOEAHN(DPBBAOGMDLF DKHAKCOFILG)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FCIIINHJFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<bool, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public DPBBAOGMDLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DLGKEICEBPG rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GIKJOOGIFPO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FKEPIPDGFDA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PGLGENBDGKP<bool, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CF20", Offset = "0x1E0BF20", VA = "0x181E0CF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D1A0", Offset = "0x1E0C1A0", VA = "0x181E0D1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EBMIFEGJBFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<bool, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DPBBAOGMDLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<PGLGENBDGKP<bool, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B820", Offset = "0x1E0A820", VA = "0x181E0B820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BAB0", Offset = "0x1E0AAB0", VA = "0x181E0BAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FBLDMJENIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DPBBAOGMDLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CCD0", Offset = "0x1E0BCD0", VA = "0x181E0CCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CEB0", Offset = "0x1E0BEB0", VA = "0x181E0CEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BKALLIIKBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public DPBBAOGMDLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EBBJCOBMEJP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E07340", Offset = "0x1E06340", VA = "0x181E07340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E07530", Offset = "0x1E06530", VA = "0x181E07530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CJGONHOMIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public DPBBAOGMDLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<PGLGENBDGKP<bool, AABLFGLHLFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E08500", Offset = "0x1E07500", VA = "0x181E08500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E08CF0", Offset = "0x1E07CF0", VA = "0x181E08CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JLADLGKIDDG<CEBMMKCJHFK> GCFKPPMFBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JKBBAJJKFLI GEMMLPHKJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OCKNBLGIHIO PHLPOMHIPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly MNFHOCKMMOJ JIMMNGBAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1110")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly FCDICOJFHNB FGOACBGMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1118")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NJMBDGBPJJP.FLDMPBGIJMK CCPNIDKNCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1138")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly BKNABNFMANK HDICJNPKEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1140")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JKOMNFAKDAF ACIHHMFFNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1148")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly EFAOPOMACCK MEMIBFJLJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1150")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly NIFOCNJIIGM DEEOEAACBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1158")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly GBNDOEBBIJH EHDHOCFJINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1160")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GKLKJPMAKCN OLNFKHOODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1170")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AFHILGCNAJJ OINJEOGKJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1190")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly OCKNBLGIHIO.GLCFIEICGGP CPKMGOMCNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1198")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly DPPCBGEMLDF MCIGFKMFDKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OCKNBLGIHIO NJECLJHLCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A7F0", Offset = "0x1E097F0", VA = "0x181E0A7F0")]
		get
		{
			return default(OCKNBLGIHIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LONBFHAKFGC BFHLPJMCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A7A0", Offset = "0x1E097A0", VA = "0x181E0A7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PFLJFFJEMNE HIMGNABPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B1C0", Offset = "0x1E0A1C0", VA = "0x181E0B1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B250", Offset = "0x1E0A250", VA = "0x181E0B250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FMHKBEEAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A580", Offset = "0x1E09580", VA = "0x181E0A580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B050", Offset = "0x1E0A050", VA = "0x181E0B050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GGGEBAABKPJ NELOOCIJPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B7D0", Offset = "0x1E0A7D0", VA = "0x181E0B7D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MKGIEEFHHAN GKJKCKGDJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B7F0", Offset = "0x1E0A7F0", VA = "0x181E0B7F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MIPGBJJPDOL JJGKCDGCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B810", Offset = "0x1E0A810", VA = "0x181E0B810", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CEHHNBEEEPP NKOBMNDMEFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B7E0", Offset = "0x1E0A7E0", VA = "0x181E0B7E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AMNJCBCJPIP IFPJNFFGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B800", Offset = "0x1E0A800", VA = "0x181E0B800", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EAAJIBJHKIF? GNPIAEFCCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B270", Offset = "0x1E0A270", VA = "0x181E0B270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private DOAELPIBLPO? DBBDAJLCFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A800", Offset = "0x1E09800", VA = "0x181E0A800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B490", Offset = "0x1E0A490", VA = "0x181E0B490")]
	private DPBBAOGMDLF(FCDICOJFHNB NELLAINPCDD, JLADLGKIDDG<CEBMMKCJHFK> BFJJJMDOJBG, [In] JKBBAJJKFLI BNJGMODBCHK, [In] OCKNBLGIHIO KIAJAPLNICJ, [In] MNFHOCKMMOJ JHPLCNCKPED, PFLJFFJEMNE GIEBCJFEIMO, [In] NJMBDGBPJJP.FLDMPBGIJMK FKAMJPEKEFL, OCKNBLGIHIO.GLCFIEICGGP KMGLINOICBB, DPPCBGEMLDF NGOHHPAPMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AC30", Offset = "0x1E09C30", VA = "0x181E0AC30")]
	public static DPBBAOGMDLF MGIIAIMPALM(FCDICOJFHNB AKOGIKBAMPF, [In] EGIMKOJLJGN GFEBNKFKAKN, FAFJDNFHMDG JFLEBHFKPAK, [In] GCGBNAPALJK DIIBAJONFNG, CIAKJALIFBG OLGKECBKEAC, JLADLGKIDDG<CEBMMKCJHFK> BFJJJMDOJBG, JLADLGKIDDG<JMIMMLPKEMM> HJOGBCDOLNO, KAKPMOAJBNM JCGJGFHCLLD, CPCIDIMCDEB JCKLHADFBKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AD70", Offset = "0x1E09D70", VA = "0x181E0AD70")]
	public static DPBBAOGMDLF MGIIAIMPALM(FCDICOJFHNB NELLAINPCDD, [In] OCKNBLGIHIO KIAJAPLNICJ, [In] MNFHOCKMMOJ JHPLCNCKPED, JLADLGKIDDG<CEBMMKCJHFK> BFJJJMDOJBG, JLADLGKIDDG<JMIMMLPKEMM> HJOGBCDOLNO, KAKPMOAJBNM JCGJGFHCLLD, CPCIDIMCDEB JCKLHADFBKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A390", Offset = "0x1E09390", VA = "0x181E0A390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B060", Offset = "0x1E0A060", VA = "0x181E0B060")]
	[AsyncStateMachine(typeof(FCIIINHJFGO))]
	internal Task<PGLGENBDGKP<bool, AABLFGLHLFL>> NAJHNMLKICL(DLGKEICEBPG DCIAEPGAFCJ, GIKJOOGIFPO KBHELJGAJGN, FKEPIPDGFDA JEGJKPFGCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B3A0", Offset = "0x1E0A3A0", VA = "0x181E0B3A0")]
	[AsyncStateMachine(typeof(EBMIFEGJBFH))]
	public Task<PGLGENBDGKP<bool, AABLFGLHLFL>> PHJENKPIHNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A9A0", Offset = "0x1E099A0", VA = "0x181E0A9A0")]
	[AsyncStateMachine(typeof(FBLDMJENIJA))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> LJHONGLJDPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A590", Offset = "0x1E09590", VA = "0x181E0A590")]
	internal void GKEBDPENBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B1D0", Offset = "0x1E0A1D0", VA = "0x181E0B1D0")]
	internal HLIMGIIJKHF<EBBJCOBMEJP> OBPOKDKJPPI([In] GJMPDLGOBCL JPDGBEFFLGG)
	{
		return default(HLIMGIIJKHF<EBBJCOBMEJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A930", Offset = "0x1E09930", VA = "0x181E0A930")]
	internal bool LEKNGKJPOKD([In] GJMPDLGOBCL JPDGBEFFLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E0ABB0", Offset = "0x1E09BB0", VA = "0x181E0ABB0")]
	internal HLIMGIIJKHF<EBBJCOBMEJP> MAODFCNANIO([In] FMIOHPMBIAH LLHAKFDDHPB)
	{
		return default(HLIMGIIJKHF<EBBJCOBMEJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A280", Offset = "0x1E09280", VA = "0x181E0A280")]
	[AsyncStateMachine(typeof(BKALLIIKBJO))]
	internal Task<PGLGENBDGKP<object, AABLFGLHLFL>> DLEEEGENHMI(EBBJCOBMEJP LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E09EF0", Offset = "0x1E08EF0", VA = "0x181E09EF0")]
	private EBBJCOBMEJP[] AMGECOOEAHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AA90", Offset = "0x1E09A90", VA = "0x181E0AA90")]
	[AsyncStateMachine(typeof(CJGONHOMIBL))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> LOECENKIIHG(Guid KJEKGFNDLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KPONLBIMMPM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2958C60", Offset = "0x2957C60", VA = "0x182958C60")]
	public static MAGOHJHINJD<(TPrev?, DPBBAOGMDLF?), DOAELPIBLPO> ANAFKECBGKN<TPrev>([In] this MAGOHJHINJD<TPrev, DPBBAOGMDLF> HFLBADIEKAM)
	{
		return default(MAGOHJHINJD<(TPrev, DPBBAOGMDLF), DOAELPIBLPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2958F00", Offset = "0x2957F00", VA = "0x182958F00")]
	public static MAGOHJHINJD<TPrev?, DPBBAOGMDLF?> DKOLCELOLJA<TPrev>([In] this MAGOHJHINJD<TPrev, DPBBAOGMDLF> HFLBADIEKAM)
	{
		return default(MAGOHJHINJD<TPrev, DPBBAOGMDLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GEEHDNBNNNJ<TData> : HBNEILLBGHD, CCGEDPMBADI, HHPFBBGIKCL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HHBFDIMEGNL<GAGHAPPFMGC>? DACIEKBEGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string LLOICNKPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData IKNEHLGBAHD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public HHBFDIMEGNL<GAGHAPPFMGC>? BPHKEHBKOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x200FF20", Offset = "0x200EF20", VA = "0x18200FF20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C3300", VA = "0x1807C4300", Slot = "7")]
	public override string MGJEJBNDCKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x399B7A0", Offset = "0x399A7A0", VA = "0x18399B7A0")]
	internal GEEHDNBNNNJ([In] HHBFDIMEGNL<GAGHAPPFMGC>? CLLBMEEIIKK, JLADLGKIDDG<NOKKFPEKGJM>? OCFGNBBKJDC, IOKind? MAIPAPFPOMH, string JJJNODJJIFK, [In] TData GPKMLHOONCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FPEELONELFD
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D9D0", Offset = "0x1E0C9D0", VA = "0x181E0D9D0")]
	public static PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI> GOKMEAGCBJF([In] this DLCDEOLGGKI<CFJMACOJHPP> NLHNKFJNAAJ)
	{
		return default(PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28B0590", Offset = "0x28AF590", VA = "0x1828B0590")]
	public static PGLGENBDGKP<TOk, CCGEDPMBADI> PPLPEDHFHGA<TOk>([In] this PGLGENBDGKP<TOk, CCGEDPMBADI> HFLBADIEKAM, [In] HHBFDIMEGNL<GAGHAPPFMGC>? CLLBMEEIIKK, JLADLGKIDDG<NOKKFPEKGJM>? OCFGNBBKJDC, IOKind? MAIPAPFPOMH, string JJJNODJJIFK) where TOk : notnull
	{
		return default(PGLGENBDGKP<TOk, CCGEDPMBADI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FCDICOJFHNB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CBPDHBMHLOH.GBHCNMPCKAN DIONAGGCJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	ODKJBDAKIBF.KNGMNLKMDEI GELJNMNLJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DPBBAOGMDLF.LONBFHAKFGC GEKKIFMFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PLCJGBINHPC.MEHHNNNPIMK IINMNCIJDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF> CKKDKIPAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AFGAGCCGDDM FMGBJODPJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LEKKIHPEAHD DJJGAIGKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NEBOEELLFPE IEHGPNILMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IBHMFLAKBFA HFEEJLGMLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JJNFBOIBPCL FMMMDABHBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BFFEOKGCGKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E07230", Offset = "0x1E06230", VA = "0x181E07230")]
	public static EBBJCOBMEJP HIBKDNPOPDI(this EBBJCOBMEJP HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E07160", Offset = "0x1E06160", VA = "0x181E07160")]
	public static EBBJCOBMEJP HDPCKIPIMFM(this MGJHOLNAFOM HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MGJHOLNAFOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LLILKIEHEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DPBBAOGMDLF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public MGJHOLNAFOM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E16720", Offset = "0x1E15720", VA = "0x181E16720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E169E0", Offset = "0x1E159E0", VA = "0x181E169E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString DMDNAKDAMMG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	private MGJHOLNAFOM(ByteString LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E1D9A0", Offset = "0x1E1C9A0", VA = "0x181E1D9A0")]
	public static EBBJCOBMEJP BDIJMFMJIOA(ByteString LDGMLLMKHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DB70", Offset = "0x1E1CB70", VA = "0x181E1DB70")]
	public static DBDOFJKDFII<JMJNNGFFIBF, MGJHOLNAFOM> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, MGJHOLNAFOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DA60", Offset = "0x1E1CA60", VA = "0x181E1DA60")]
	[AsyncStateMachine(typeof(LLILKIEHEOK))]
	public static Task<PGLGENBDGKP<object, AABLFGLHLFL>> DLEEEGENHMI(DPBBAOGMDLF OPFDMIOAEHD, MGJHOLNAFOM HFLBADIEKAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HDJNCFDKHOE
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0ED90", Offset = "0x1E0DD90", VA = "0x181E0ED90")]
	public static EBBJCOBMEJP BDIJMFMJIOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EEB0", Offset = "0x1E0DEB0", VA = "0x181E0EEB0")]
	public static DBDOFJKDFII<JMJNNGFFIBF, HDJNCFDKHOE> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, HDJNCFDKHOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EE30", Offset = "0x1E0DE30", VA = "0x181E0EE30")]
	public static PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK> DOJCBMJCAGI(DPBBAOGMDLF OPFDMIOAEHD, [In] HDJNCFDKHOE HFLBADIEKAM)
	{
		return default(PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct LPHGBKLDCDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OIIMKOGDJPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public DPBBAOGMDLF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LPHGBKLDCDF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E213E0", Offset = "0x1E203E0", VA = "0x181E213E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E21750", Offset = "0x1E20750", VA = "0x181E21750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly DLGKEICEBPG? BNCPJMOJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GIKJOOGIFPO? NJGDLCLLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly FKEPIPDGFDA? AANMJGPFEBH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B5AC20", Offset = "0x1B59C20", VA = "0x181B5AC20")]
	private LPHGBKLDCDF(DLGKEICEBPG? DCIAEPGAFCJ, GIKJOOGIFPO? KBHELJGAJGN, FKEPIPDGFDA? JEGJKPFGCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E16A50", Offset = "0x1E15A50", VA = "0x181E16A50")]
	public static EBBJCOBMEJP? BDIJMFMJIOA(DLGKEICEBPG? DCIAEPGAFCJ, GIKJOOGIFPO? KBHELJGAJGN, FKEPIPDGFDA? JEGJKPFGCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E16C90", Offset = "0x1E15C90", VA = "0x181E16C90")]
	public static DBDOFJKDFII<JMJNNGFFIBF, LPHGBKLDCDF> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, LPHGBKLDCDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E16B50", Offset = "0x1E15B50", VA = "0x181E16B50")]
	[AsyncStateMachine(typeof(OIIMKOGDJPK))]
	public static Task<PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK>> DLEEEGENHMI(DPBBAOGMDLF OPFDMIOAEHD, LPHGBKLDCDF HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CNJFKPANOHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HGMCFIHDELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<JMGAFOPOMNL, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CNJFKPANOHC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DPBBAOGMDLF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private PGLGENBDGKP<JMGAFOPOMNL, AABLFGLHLFL> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private PGLGENBDGKP<object, HHPFBBGIKCL>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private PGLGENBDGKP<object, HHPFBBGIKCL> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PGLGENBDGKP<object, HHPFBBGIKCL>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F340", Offset = "0x1E0E340", VA = "0x181E0F340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F7B0", Offset = "0x1E0E7B0", VA = "0x181E0F7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<EBBJCOBMEJP> PDMABHEOFCI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	private CNJFKPANOHC(IReadOnlyList<EBBJCOBMEJP> IBDAFFKKFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E08F60", Offset = "0x1E07F60", VA = "0x181E08F60")]
	public static EBBJCOBMEJP BDIJMFMJIOA(IReadOnlyList<EBBJCOBMEJP> IBDAFFKKFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E09160", Offset = "0x1E08160", VA = "0x181E09160")]
	public static DBDOFJKDFII<JMJNNGFFIBF, CNJFKPANOHC> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, CNJFKPANOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E09020", Offset = "0x1E08020", VA = "0x181E09020")]
	[AsyncStateMachine(typeof(HGMCFIHDELM))]
	public static Task<PGLGENBDGKP<JMGAFOPOMNL, AABLFGLHLFL>> DLEEEGENHMI(DPBBAOGMDLF OPFDMIOAEHD, CNJFKPANOHC HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FMIOHPMBIAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int JFLFCJGPPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int CBOGBOOIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] IKNEHLGBAHD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x18F8450", Offset = "0x18F7450", VA = "0x1818F8450")]
	private FMIOHPMBIAH(int MJMIIGGLEFB, int GPEHCABDGEJ, byte[] GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D5B0", Offset = "0x1E0C5B0", VA = "0x181E0D5B0")]
	public static EBBJCOBMEJP BDIJMFMJIOA(int MJMIIGGLEFB, int GPEHCABDGEJ, ByteString GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D890", Offset = "0x1E0C890", VA = "0x181E0D890")]
	public static EBBJCOBMEJP[] NOOCAKDLOMA(EBBJCOBMEJP LNMJHEPMAAO, int HCGEJHPFGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D7B0", Offset = "0x1E0C7B0", VA = "0x181E0D7B0")]
	public static DBDOFJKDFII<JMJNNGFFIBF, FMIOHPMBIAH> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, FMIOHPMBIAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D690", Offset = "0x1E0C690", VA = "0x181E0D690")]
	public static PGLGENBDGKP<EBBJCOBMEJP, AKCFNDEBMDK> DOJCBMJCAGI(DPBBAOGMDLF OPFDMIOAEHD, [In] FMIOHPMBIAH HFLBADIEKAM)
	{
		return default(PGLGENBDGKP<EBBJCOBMEJP, AKCFNDEBMDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GJMPDLGOBCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EHNIEKIIODM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<bool, AKCFNDEBMDK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DPBBAOGMDLF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GJMPDLGOBCL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private PGLGENBDGKP<bool, AKCFNDEBMDK> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AKCFNDEBMDK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C000", Offset = "0x1E0B000", VA = "0x181E0C000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C640", Offset = "0x1E0B640", VA = "0x181E0C640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int JFLFCJGPPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int CBOGBOOIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] IKNEHLGBAHD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x18F8450", Offset = "0x18F7450", VA = "0x1818F8450")]
	private GJMPDLGOBCL(int MJMIIGGLEFB, int GPEHCABDGEJ, byte[] GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E580", Offset = "0x1E0D580", VA = "0x181E0E580")]
	public static EBBJCOBMEJP BDIJMFMJIOA(int MJMIIGGLEFB, int GPEHCABDGEJ, ByteString GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E790", Offset = "0x1E0D790", VA = "0x181E0E790")]
	public static EBBJCOBMEJP?[]? FMLCCCAKNBJ(int HCGEJHPFGOI, DLGKEICEBPG? DCIAEPGAFCJ, GIKJOOGIFPO? KBHELJGAJGN, FKEPIPDGFDA? JEGJKPFGCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E990", Offset = "0x1E0D990", VA = "0x181E0E990")]
	public static DBDOFJKDFII<JMJNNGFFIBF, GJMPDLGOBCL> JGAKLJKPKDC(EBBJCOBMEJP ANMDIDHLCKJ)
	{
		return default(DBDOFJKDFII<JMJNNGFFIBF, GJMPDLGOBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E660", Offset = "0x1E0D660", VA = "0x181E0E660")]
	[AsyncStateMachine(typeof(EHNIEKIIODM))]
	public static Task<PGLGENBDGKP<bool, AKCFNDEBMDK>> DLEEEGENHMI(DPBBAOGMDLF OPFDMIOAEHD, GJMPDLGOBCL HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BKNABNFMANK : GGGEBAABKPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BPGJKOLKEAI? AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E075A0", Offset = "0x1E065A0", VA = "0x181E075A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	internal BKNABNFMANK(DPBBAOGMDLF PDDFEIFGNBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KLCHCBPAEAB : BPGJKOLKEAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PEIJJNBAPBL HFAIKFBMGIH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
	public KLCHCBPAEAB(DPBBAOGMDLF PDDFEIFGNBJ, PEIJJNBAPBL CCJDBGGKIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E15930", Offset = "0x1E14930", VA = "0x181E15930", Slot = "4")]
	public PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI> NKMJIFPBMMG(HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<FPKDDGFFKID> PGPGHAGDOFN)
	{
		return default(PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E15660", Offset = "0x1E14660", VA = "0x181E15660", Slot = "5")]
	public PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI> NBBFGHLAGPB(HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<NPKBJOKMGLG> IDIHOPKDBNN)
	{
		return default(PGLGENBDGKP<DCGCAKBCPDB, CCGEDPMBADI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CBPDHBMHLOH : KMEAAHIOFHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface GBHCNMPCKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PEIJJNBAPBL> LHMBKKPGEOL(DPBBAOGMDLF PDDFEIFGNBJ, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ, CancellationToken GHLJDIEPICD);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JEHKFEEDPOD EMNICGCIINJ(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CNBAILMMDMO : GBHCNMPCKAN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct PGGGOOOAHCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<PEIJJNBAPBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public DPBBAOGMDLF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public GIKJOOGIFPO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public FKEPIPDGFDA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<PLCJGBINHPC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1E22090", Offset = "0x1E21090", VA = "0x181E22090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1E223B0", Offset = "0x1E213B0", VA = "0x181E223B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly CNBAILMMDMO AFPJCELPLKK;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		private CNBAILMMDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E08D80", Offset = "0x1E07D80", VA = "0x181E08D80", Slot = "4")]
		[AsyncStateMachine(typeof(PGGGOOOAHCD))]
		public Task<PEIJJNBAPBL> LHMBKKPGEOL(DPBBAOGMDLF PDDFEIFGNBJ, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ, CancellationToken GHLJDIEPICD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E08D60", Offset = "0x1E07D60", VA = "0x181E08D60", Slot = "5")]
		public JEHKFEEDPOD EMNICGCIINJ(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct AGELIABFFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<CBPDHBMHLOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DPBBAOGMDLF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public GIKJOOGIFPO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FKEPIPDGFDA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DLGKEICEBPG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GBHCNMPCKAN <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<PEIJJNBAPBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E06420", Offset = "0x1E05420", VA = "0x181E06420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E06970", Offset = "0x1E05970", VA = "0x181E06970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PEIJJNBAPBL HFAIKFBMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JEHKFEEDPOD OPHLBOOJNNC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EAAJIBJHKIF LHEHEKJGOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E07C50", Offset = "0x1E06C50", VA = "0x181E07C50", Slot = "4")]
		get
		{
			return default(EAAJIBJHKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DOAELPIBLPO IOKCNCOOPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E07B90", Offset = "0x1E06B90", VA = "0x181E07B90", Slot = "5")]
		get
		{
			return default(DOAELPIBLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KLCHCBPAEAB ILAOEDMKENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MENHHHCEIOM ECHIMPCPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BFCBIFHGPGJ CPBLJNPOLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E07E20", Offset = "0x1E06E20", VA = "0x181E07E20")]
	private CBPDHBMHLOH(PEIJJNBAPBL CCJDBGGKIMK, JEHKFEEDPOD HIPNNFIJIIJ, KLCHCBPAEAB JDIEEEPCHBO, MENHHHCEIOM JKHPGHBJHNK, BFCBIFHGPGJ LNOEIPNKHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E07CB0", Offset = "0x1E06CB0", VA = "0x181E07CB0")]
	[AsyncStateMachine(typeof(AGELIABFFMO))]
	public static Task<CBPDHBMHLOH> LBGMCCJIPOG(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E07B30", Offset = "0x1E06B30", VA = "0x181E07B30", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class ODKJBDAKIBF : PFLJFFJEMNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface KNGMNLKMDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KMEAAHIOFHK> CLLMNGGHNMI(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ, CancellationToken GHLJDIEPICD);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OKFFONGBPIJ();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EOKNHGEIDDE();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class IAIAMAFEKJJ : KNGMNLKMDEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct JCKODABKHLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<KMEAAHIOFHK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public DPBBAOGMDLF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public DLGKEICEBPG evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public GIKJOOGIFPO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public FKEPIPDGFDA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<CBPDHBMHLOH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E14140", Offset = "0x1E13140", VA = "0x181E14140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E14480", Offset = "0x1E13480", VA = "0x181E14480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E10320", Offset = "0x1E0F320", VA = "0x181E10320", Slot = "4")]
		[AsyncStateMachine(typeof(JCKODABKHLI))]
		public Task<KMEAAHIOFHK> CLLMNGGHNMI(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ, CancellationToken GHLJDIEPICD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OKFFONGBPIJ();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EOKNHGEIDDE();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		protected IAIAMAFEKJJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BOBKHMDAIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<KMEAAHIOFHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ODKJBDAKIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<KLKJPNNICPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E078C0", Offset = "0x1E068C0", VA = "0x181E078C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E07AC0", Offset = "0x1E06AC0", VA = "0x181E07AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CGDNKAMOJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ODKJBDAKIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DPBBAOGMDLF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DLGKEICEBPG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public GIKJOOGIFPO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FKEPIPDGFDA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<KMEAAHIOFHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E07EB0", Offset = "0x1E06EB0", VA = "0x181E07EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E083E0", Offset = "0x1E073E0", VA = "0x181E083E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KNGMNLKMDEI KOPMBDPCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<KLKJPNNICPF> IAMHABNJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<KLKJPNNICPF> BIDHGGEJAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource EJOOIAFEHAO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FMHKBEEAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x88AC60", Offset = "0x889C60", VA = "0x18088AC60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x96ECD0", Offset = "0x96DCD0", VA = "0x18096ECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OLODGLIPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x96EC90", Offset = "0x96DC90", VA = "0x18096EC90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x96ECC0", Offset = "0x96DCC0", VA = "0x18096ECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool IEMDNDNNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF813F0", Offset = "0xF803F0", VA = "0x180F813F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E20E90", Offset = "0x1E1FE90", VA = "0x181E20E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KMEAAHIOFHK? OHBKEIHPKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E20DA0", Offset = "0x1E1FDA0", VA = "0x181E20DA0", Slot = "7")]
	[AsyncStateMachine(typeof(BOBKHMDAIOD))]
	public Task<KMEAAHIOFHK> NIKLLMDELPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E20EA0", Offset = "0x1E1FEA0", VA = "0x181E20EA0")]
	public ODKJBDAKIBF(KNGMNLKMDEI AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1E20C40", Offset = "0x1E1FC40", VA = "0x181E20C40", Slot = "8")]
	[AsyncStateMachine(typeof(CGDNKAMOJIO))]
	public Task NFPOBLEFLLI(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E20AD0", Offset = "0x1E1FAD0", VA = "0x181E20AD0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DBMKPECPJDF : GDMGLHMPNFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MENHHHCEIOM FPLKCGKHJIF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public DBMKPECPJDF(MENHHHCEIOM JKHPGHBJHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class NNLBDKBALLL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class CHDLLINOIOA<TGraph> : LFMKHJDFIJL where TGraph : ILGGCCNHAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph LAAGLNPKBOE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual CALHCIDAINO? DDKLJBCHKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDC7300", Offset = "0xDC6300", VA = "0x180DC7300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
		public CHDLLINOIOA(TGraph FFHMEKGOLFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class NBFHJIKJFKM : CHDLLINOIOA<AIAOIAJOKNM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CALHCIDAINO? DDKLJBCHKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1E20410", Offset = "0x1E1F410", VA = "0x181E20410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E20430", Offset = "0x1E1F430", VA = "0x181E20430")]
		public NBFHJIKJFKM(AIAOIAJOKNM BIELNMOOHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E20500", Offset = "0x1E1F500", VA = "0x181E20500")]
	public static LFMKHJDFIJL MGIIAIMPALM(ILGGCCNHAIM FFHMEKGOLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IKBNCAAFJKM : MOMDBHCHLJM, MPLCMLPCLMB, DKJNMPPFPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FEJNKDLNBAB
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
			public FEJNKDLNBAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AFGAGCCGDDM errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1E22950", Offset = "0x1E21950", VA = "0x181E22950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E22BC0", Offset = "0x1E21BC0", VA = "0x181E22BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IKBNCAAFJKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FEJNKDLNBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D210", Offset = "0x1E0C210", VA = "0x181E0D210")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FCBBGMAEAHL(AFGAGCCGDDM errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IFDMCACGKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public IKBNCAAFJKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E10620", Offset = "0x1E0F620", VA = "0x181E10620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E10A90", Offset = "0x1E0FA90", VA = "0x181E10A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OJOEIMBPFOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public OJOEIMBPFOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1E22C20", Offset = "0x1E21C20", VA = "0x181E22C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E22F00", Offset = "0x1E21F00", VA = "0x181E22F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IKBNCAAFJKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OJOEIMBPFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E217C0", Offset = "0x1E207C0", VA = "0x181E217C0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JDOPHIIDJAK(AFGAGCCGDDM errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EENJFONECLI DEKNKAOALIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<FOHANGFBBCL> PEFBLIHDNJD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private FCDICOJFHNB BJGABICMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E115C0", Offset = "0x1E105C0", VA = "0x181E115C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JLADLGKIDDG<FPKDDGFFKID> BJKINNOFKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B10", Offset = "0xAE5B10", VA = "0x180AE6B10", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(JLADLGKIDDG<FPKDDGFFKID>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB35AB0", Offset = "0xB34AB0", VA = "0x180B35AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private JLADLGKIDDG<HMCEGANNKMN> IOCLJJKMMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x944D10", Offset = "0x943D10", VA = "0x180944D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JLADLGKIDDG<OFKKFGCILME> ALOJMBBPGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E7BF0", Offset = "0x7E6BF0", VA = "0x1807E7BF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JLADLGKIDDG<OFKKFGCILME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override JLADLGKIDDG<NOKKFPEKGJM> CANBGNJEBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E11030", Offset = "0x1E10030", VA = "0x181E11030", Slot = "20")]
		get
		{
			return default(JLADLGKIDDG<NOKKFPEKGJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CCLEIJAAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E110D0", Offset = "0x1E100D0", VA = "0x181E110D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E13DF0", Offset = "0x1E12DF0", VA = "0x181E13DF0")]
	private IKBNCAAFJKM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF, EENJFONECLI ABOOOHHIHGG, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<FPKDDGFFKID> PGPGHAGDOFN, JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI, bool KGIFDLGHLGB, string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E131D0", Offset = "0x1E121D0", VA = "0x181E131D0")]
	public static IKBNCAAFJKM MGIIAIMPALM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF, EENJFONECLI BJGIJFLPNGG, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI, JLADLGKIDDG<FPKDDGFFKID> PGPGHAGDOFN, bool KGIFDLGHLGB, bool OKGHOBKPLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E11290", Offset = "0x1E10290", VA = "0x181E11290", Slot = "21")]
	protected override void CJMKLAKCCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E11680", Offset = "0x1E10680", VA = "0x181E11680", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E11070", Offset = "0x1E10070", VA = "0x181E11070", Slot = "30")]
	public void AEFKHNEMJFP(FOHANGFBBCL FIABHBNLENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E12AB0", Offset = "0x1E11AB0", VA = "0x181E12AB0", Slot = "27")]
	public void JBGJJPCFENP(BLJNIEEOFPK INPFEFHGCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F70", Offset = "0x1E10F70", VA = "0x181E11F70", Slot = "28")]
	public void HADJBNIAHME(DOJJGBNGNBB AHPDFOPMBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E11D70", Offset = "0x1E10D70", VA = "0x181E11D70", Slot = "23")]
	protected override void FOIIMMMCJOO(KAPBNNIDDFL BKAABBKIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E11450", Offset = "0x1E10450", VA = "0x181E11450", Slot = "32")]
	public string CKELGDNBIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E11910", Offset = "0x1E10910", VA = "0x181E11910", Slot = "29")]
	public string EELHKDGEICC(int JBBBKAGKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E12FA0", Offset = "0x1E11FA0", VA = "0x181E12FA0")]
	private void LOJAGOBHLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E13B40", Offset = "0x1E12B40", VA = "0x181E13B40", Slot = "31")]
	public void ODJMEEFAFJA(FOHANGFBBCL FIABHBNLENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E13880", Offset = "0x1E12880", VA = "0x181E13880")]
	private void NHJEJECLPIN(bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E13A40", Offset = "0x1E12A40", VA = "0x181E13A40", Slot = "33")]
	[AsyncStateMachine(typeof(IFDMCACGKPI))]
	public Task NILFEIJKMGM(string LDGMLLMKHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E11C40", Offset = "0x1E10C40", VA = "0x181E11C40")]
	public void EGAOACBMPBE(string LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E12910", Offset = "0x1E11910", VA = "0x181E12910")]
	private void HHLADEONAIE(int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB35AB0", Offset = "0xB34AB0", VA = "0x180B35AB0")]
	internal void BKPAKKJFCGC(JLADLGKIDDG<FPKDDGFFKID> LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E13730", Offset = "0x1E12730", VA = "0x181E13730")]
	[CompilerGenerated]
	private bool NGKLMANADHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E13CA0", Offset = "0x1E12CA0", VA = "0x181E13CA0")]
	[CompilerGenerated]
	private bool PKGJOGMLJIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E11630", Offset = "0x1E10630", VA = "0x181E11630")]
	[CompilerGenerated]
	private int DJLHEFJJJGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E13C10", Offset = "0x1E12C10", VA = "0x181E13C10")]
	[CompilerGenerated]
	private bool OHIEGAPKKPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E135E0", Offset = "0x1E125E0", VA = "0x181E135E0")]
	[CompilerGenerated]
	private bool NBINANDEJIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E11E50", Offset = "0x1E10E50", VA = "0x181E11E50")]
	[CompilerGenerated]
	private bool GJICJMDPEFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E12F10", Offset = "0x1E11F10", VA = "0x181E12F10")]
	[CompilerGenerated]
	private bool JPCGPODAHEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E11630", Offset = "0x1E10630", VA = "0x181E11630")]
	[CompilerGenerated]
	private int LBIKEPFIHFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E11EA0", Offset = "0x1E10EA0", VA = "0x181E11EA0")]
	[CompilerGenerated]
	private bool GMEPCBHKDHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E115E0", Offset = "0x1E105E0", VA = "0x181E115E0")]
	[CompilerGenerated]
	private int DHBCLJGDOMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E12E90", Offset = "0x1E11E90", VA = "0x181E12E90")]
	[CompilerGenerated]
	private void JCIFGMELDAO(object LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E11840", Offset = "0x1E10840", VA = "0x181E11840")]
	[CompilerGenerated]
	private bool EBKFAEAKLFK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MOJODKJCDGK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class KHFEAJMEMOK : IPHLJDHPLFH<MJHJFAOBGPC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override DNHODHICOCK JJDNFNLFPGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x90E900", Offset = "0x90D900", VA = "0x18090E900", Slot = "125")]
			get
			{
				return default(DNHODHICOCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E155A0", Offset = "0x1E145A0", VA = "0x181E155A0")]
		public KHFEAJMEMOK(DPBBAOGMDLF PDDFEIFGNBJ, MJHJFAOBGPC OFFMGNOKEOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class JOINKMGPKLK : CLCOOBHFPJC<FMOIPBIKNCF>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E15030", Offset = "0x1E14030", VA = "0x181E15030")]
		public JOINKMGPKLK(DPBBAOGMDLF PDDFEIFGNBJ, FMOIPBIKNCF CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E14EB0", Offset = "0x1E13EB0", VA = "0x181E14EB0", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E14E60", Offset = "0x1E13E60", VA = "0x181E14E60")]
		[CompilerGenerated]
		private bool GHKPHGJAFAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E14D40", Offset = "0x1E13D40", VA = "0x181E14D40")]
		[CompilerGenerated]
		private void BKKPAGBGBEI(bool LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class JEKMIMBJFNH : CLCOOBHFPJC<BAJLLEOJFEA>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class ENDECKJFFNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public JEKMIMBJFNH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public ENDECKJFFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C830", Offset = "0x1E0B830", VA = "0x181E0C830")]
			internal void LNBFFFPDEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C8D0", Offset = "0x1E0B8D0", VA = "0x181E0C8D0")]
			internal bool OBJJLIBGIIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C920", Offset = "0x1E0B920", VA = "0x181E0C920")]
			internal bool PLCMMPNFCON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C710", Offset = "0x1E0B710", VA = "0x181E0C710")]
			internal void GNEGEJOFDOI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C880", Offset = "0x1E0B880", VA = "0x181E0C880")]
			internal bool NMFFOJAJPEK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E14CC0", Offset = "0x1E13CC0", VA = "0x181E14CC0")]
		public JEKMIMBJFNH(DPBBAOGMDLF PDDFEIFGNBJ, BAJLLEOJFEA CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E149C0", Offset = "0x1E139C0", VA = "0x181E149C0", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AMOCMGKBFMN : CLCOOBHFPJC<NGPIBIGONCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class DOEPIABHGGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AMOCMGKBFMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public DOEPIABHGGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1E099A0", Offset = "0x1E089A0", VA = "0x181E099A0")]
			internal object LNBFFFPDEDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1E09920", Offset = "0x1E08920", VA = "0x181E09920")]
			internal bool JMFONKFFEIF(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E09B40", Offset = "0x1E08B40", VA = "0x181E09B40")]
			internal void OBJJLIBGIIM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E09D90", Offset = "0x1E08D90", VA = "0x181E09D90")]
			internal string PLCMMPNFCON(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E098D0", Offset = "0x1E088D0", VA = "0x181E098D0")]
			internal IReadOnlyList<object> GNEGEJOFDOI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E09AA0", Offset = "0x1E08AA0", VA = "0x181E09AA0")]
			internal bool NMFFOJAJPEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E09810", Offset = "0x1E08810", VA = "0x181E09810")]
			internal bool FFOGFEIKLCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E09880", Offset = "0x1E08880", VA = "0x181E09880")]
			internal void FGOFEGHAIIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1E09650", Offset = "0x1E08650", VA = "0x181E09650")]
			internal bool BAHNCCABIDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E09AF0", Offset = "0x1E08AF0", VA = "0x181E09AF0")]
			internal bool NNCJLHFFEGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1E096F0", Offset = "0x1E086F0", VA = "0x181E096F0")]
			internal void ELAKAFOAAJA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1E096A0", Offset = "0x1E086A0", VA = "0x181E096A0")]
			internal bool BJGFILJALLP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E07080", Offset = "0x1E06080", VA = "0x181E07080")]
		public AMOCMGKBFMN(DPBBAOGMDLF PDDFEIFGNBJ, NGPIBIGONCJ CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E06A50", Offset = "0x1E05A50", VA = "0x181E06A50", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MEOADBECCON : CLCOOBHFPJC<LOIOAILHBOH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class DCMNPGBFPII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public MEOADBECCON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public DCMNPGBFPII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1E093E0", Offset = "0x1E083E0", VA = "0x181E093E0")]
			internal bool LNBFFFPDEDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1E09480", Offset = "0x1E08480", VA = "0x181E09480")]
			internal void OBJJLIBGIIM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1E095A0", Offset = "0x1E085A0", VA = "0x181E095A0")]
			internal bool PLCMMPNFCON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E092C0", Offset = "0x1E082C0", VA = "0x181E092C0")]
			internal void GNEGEJOFDOI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E09430", Offset = "0x1E08430", VA = "0x181E09430")]
			internal bool NMFFOJAJPEK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D170", Offset = "0x1E1C170", VA = "0x181E1D170")]
		public MEOADBECCON(DPBBAOGMDLF PDDFEIFGNBJ, LOIOAILHBOH OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CE70", Offset = "0x1E1BE70", VA = "0x181E1CE70", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class GBIOFIADOAP<TNode> : CLCOOBHFPJC<TNode> where TNode : notnull, LGKFKFEMCJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct CMIJHDKCEKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public GBIOFIADOAP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5023560", Offset = "0x5022560", VA = "0x185023560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5023930", Offset = "0x5022930", VA = "0x185023930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CIEIIFKOKDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GBIOFIADOAP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public JLADLGKIDDG<EOKIOPDIOPK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4CAD170", Offset = "0x4CAC170", VA = "0x184CAD170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4CAD540", Offset = "0x4CAC540", VA = "0x184CAD540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool HHHBCEKGLKN
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override JLADLGKIDDG<EOKIOPDIOPK>? AEHMMKMHELC
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x3995920", Offset = "0x3994920", VA = "0x183995920", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x39958F0", Offset = "0x39948F0", VA = "0x1839958F0")]
		protected GBIOFIADOAP(DPBBAOGMDLF PDDFEIFGNBJ, TNode CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39954E0", Offset = "0x39944E0", VA = "0x1839954E0", Slot = "99")]
		[AsyncStateMachine(typeof(GBIOFIADOAP<>.CMIJHDKCEKC))]
		public override Task<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> EDOBMOCEEFB(string ONGJKHHOIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x39956A0", Offset = "0x39946A0", VA = "0x1839956A0", Slot = "123")]
		public sealed override bool LNCLLPBGPIF(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3995600", Offset = "0x3994600", VA = "0x183995600", Slot = "111")]
		protected sealed override bool GHFMMDGEGHH(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3995850", Offset = "0x3994850", VA = "0x183995850", Slot = "112")]
		protected override bool NGGDLLHNIGM(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3995740", Offset = "0x3994740", VA = "0x183995740", Slot = "100")]
		[AsyncStateMachine(typeof(GBIOFIADOAP<>.CIEIIFKOKDJ))]
		public override Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> MGEFIPICMAL(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class GMLDGEHCCMC : DNBBIIFDPMO<KJKHCIKKMMP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class IDBPLCFJHCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public GMLDGEHCCMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public IDBPLCFJHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1E105A0", Offset = "0x1E0F5A0", VA = "0x181E105A0")]
			internal bool HPNEKPMELIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1E104E0", Offset = "0x1E0F4E0", VA = "0x181E104E0")]
			internal void GAOBJMOGJEI(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1E0ED30", Offset = "0x1E0DD30", VA = "0x181E0ED30")]
		public GMLDGEHCCMC(DPBBAOGMDLF PDDFEIFGNBJ, KJKHCIKKMMP OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EAE0", Offset = "0x1E0DAE0", VA = "0x181E0EAE0", Slot = "125")]
		protected override void JBGJNGDDMJI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class HEJPJBOIIDG : ILDMCPCAKOP<ONJLIEJGJEL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F2E0", Offset = "0x1E0E2E0", VA = "0x181E0F2E0")]
		public HEJPJBOIIDG(DPBBAOGMDLF PDDFEIFGNBJ, ONJLIEJGJEL CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class ILDMCPCAKOP<TNode> : CLCOOBHFPJC<TNode> where TNode : notnull, NHCKAGOAOGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct CCIACHJIDOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public ILDMCPCAKOP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4BDE400", Offset = "0x4BDD400", VA = "0x184BDE400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4BDE770", Offset = "0x4BDD770", VA = "0x184BDE770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AAJJFFJGPPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public ILDMCPCAKOP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public JLADLGKIDDG<EOKIOPDIOPK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3947B10", Offset = "0x3946B10", VA = "0x183947B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3947E60", Offset = "0x3946E60", VA = "0x183947E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override JLADLGKIDDG<IHHFAAHIKGJ>? JNIBIMPDLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3B0ABF0", Offset = "0x3B09BF0", VA = "0x183B0ABF0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override JLADLGKIDDG<EOKIOPDIOPK>? AEHMMKMHELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3B0ACA0", Offset = "0x3B09CA0", VA = "0x183B0ACA0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x39958F0", Offset = "0x39948F0", VA = "0x1839958F0")]
		public ILDMCPCAKOP(DPBBAOGMDLF PDDFEIFGNBJ, TNode CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A7E0", Offset = "0x3B097E0", VA = "0x183B0A7E0", Slot = "99")]
		[AsyncStateMachine(typeof(ILDMCPCAKOP<>.CCIACHJIDOH))]
		public override Task<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> EDOBMOCEEFB(string ONGJKHHOIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A9A0", Offset = "0x3B099A0", VA = "0x183B0A9A0", Slot = "123")]
		public sealed override bool LNCLLPBGPIF(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A900", Offset = "0x3B09900", VA = "0x183B0A900", Slot = "111")]
		protected sealed override bool GHFMMDGEGHH(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AB50", Offset = "0x3B09B50", VA = "0x183B0AB50", Slot = "112")]
		protected override bool NGGDLLHNIGM(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AA40", Offset = "0x3B09A40", VA = "0x183B0AA40", Slot = "100")]
		[AsyncStateMachine(typeof(ILDMCPCAKOP<>.AAJJFFJGPPB))]
		public override Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> MGEFIPICMAL(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class OEPJGADIOIN : DNBBIIFDPMO<IHKNBOHKOIK>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class OEFJFAJGBPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public OEPJGADIOIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public OEFJFAJGBPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1E21050", Offset = "0x1E20050", VA = "0x181E21050")]
			internal int HPNEKPMELIE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1E20FB0", Offset = "0x1E1FFB0", VA = "0x181E20FB0")]
			internal void GAOBJMOGJEI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1E21380", Offset = "0x1E20380", VA = "0x181E21380")]
		public OEPJGADIOIN(DPBBAOGMDLF PDDFEIFGNBJ, IHKNBOHKOIK OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1E210D0", Offset = "0x1E200D0", VA = "0x181E210D0", Slot = "125")]
		protected override void JBGJNGDDMJI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class PCNJNJCCHEC : CLCOOBHFPJC<JHHGBKKBFJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xA4AD10", Offset = "0xA49D10", VA = "0x180A4AD10", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1E219C0", Offset = "0x1E209C0", VA = "0x181E219C0")]
		public PCNJNJCCHEC(DPBBAOGMDLF PDDFEIFGNBJ, JHHGBKKBFJK CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class PKGFMADFLMM : ILDMCPCAKOP<OKEJKIIBNOO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OKNOMFNLHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool GOCDDAJLOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1E22480", Offset = "0x1E21480", VA = "0x181E22480", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x925960", Offset = "0x924960", VA = "0x180925960", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1E22420", Offset = "0x1E21420", VA = "0x181E22420")]
		public PKGFMADFLMM(DPBBAOGMDLF PDDFEIFGNBJ, OKEJKIIBNOO CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class PCBPEBEBJNJ : CLCOOBHFPJC<NEFOJMLPLNB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1081520", Offset = "0x1080520", VA = "0x181081520", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1E21950", Offset = "0x1E20950", VA = "0x181E21950")]
		public PCBPEBEBJNJ(DPBBAOGMDLF PDDFEIFGNBJ, NEFOJMLPLNB CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class GMDNBIEGPOO : CLCOOBHFPJC<OOEBBCAPDAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x926D20", Offset = "0x925D20", VA = "0x180926D20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EA70", Offset = "0x1E0DA70", VA = "0x181E0EA70")]
		public GMDNBIEGPOO(DPBBAOGMDLF PDDFEIFGNBJ, OOEBBCAPDAF CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "111")]
		protected override bool GHFMMDGEGHH(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class OLDMGOEJNPD : CLCOOBHFPJC<BJEJDDLLADA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x923370", Offset = "0x922370", VA = "0x180923370", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FAEJEOPDPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x1E21900", Offset = "0x1E20900", VA = "0x181E21900", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool BKGDCFPPHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1E21890", Offset = "0x1E20890", VA = "0x181E21890")]
		public OLDMGOEJNPD(DPBBAOGMDLF PDDFEIFGNBJ, BJEJDDLLADA CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class CGMGIKGJJMI : CLCOOBHFPJC<DBEELPEBFKA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x90E900", Offset = "0x90D900", VA = "0x18090E900", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool FAEJEOPDPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1E084B0", Offset = "0x1E074B0", VA = "0x181E084B0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override bool BKGDCFPPHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1E08440", Offset = "0x1E07440", VA = "0x181E08440")]
		public CGMGIKGJJMI(DPBBAOGMDLF PDDFEIFGNBJ, DBEELPEBFKA CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class IBNCCCEADGM : GBIOFIADOAP<FHFDMJHKIDG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x932350", Offset = "0x931350", VA = "0x180932350", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1E10480", Offset = "0x1E0F480", VA = "0x181E10480")]
		public IBNCCCEADGM(DPBBAOGMDLF PDDFEIFGNBJ, FHFDMJHKIDG CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class EOCPKOECFIK : DNBBIIFDPMO<BACEANAOOII>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class IOJMGBMDEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public EOCPKOECFIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public IOJMGBMDEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1E140C0", Offset = "0x1E130C0", VA = "0x181E140C0")]
			internal int HPNEKPMELIE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1E14020", Offset = "0x1E13020", VA = "0x181E14020")]
			internal void GAOBJMOGJEI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CC70", Offset = "0x1E0BC70", VA = "0x181E0CC70")]
		public EOCPKOECFIK(DPBBAOGMDLF PDDFEIFGNBJ, BACEANAOOII OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C970", Offset = "0x1E0B970", VA = "0x181E0C970", Slot = "125")]
		protected override void JBGJNGDDMJI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class FFPGDOEOIJA : IPHLJDHPLFH<IFNABPKDPCN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override DNHODHICOCK JJDNFNLFPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "125")]
			get
			{
				return default(DNHODHICOCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D300", Offset = "0x1E0C300", VA = "0x181E0D300")]
		public FFPGDOEOIJA(DPBBAOGMDLF PDDFEIFGNBJ, IFNABPKDPCN OFFMGNOKEOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MOAFBJLLEJM : CLCOOBHFPJC<GNCGFFJFNCO>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E170", Offset = "0x1E1D170", VA = "0x181E1E170")]
		public MOAFBJLLEJM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class CLCOOBHFPJC<TNode> : KHIFPKEHEIM, IDisposable where TNode : notnull, GNCGFFJFNCO
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct EDGLAMHKCJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly string DJJBBGBPGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string ILGFDGKEEPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly string CIACBIPDCKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly INFHFOIDFJO HPCMLBPCHBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly LLJCKKKEJAP LMIKGLFFDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Func<string, bool> BMFALELEEHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly string JNNAKODLCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly Func<string, bool> ODECNGAHIBK;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x34E4110", Offset = "0x34E3110", VA = "0x1834E4110")]
			public EDGLAMHKCJK(string FPHGDPOLABA, string GCKLDOGIJHN, string GMAJGDGPDGP, INFHFOIDFJO JOLGDPPOKHO, LLJCKKKEJAP CEBEDDPBCCN, Func<string, bool> OFILNHDLPBE, string JCPKKPKNAPC, Func<string, bool> OBMKKEHKAKM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class AJGGGKCEBOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public CLCOOBHFPJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public DPBBAOGMDLF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public AJGGGKCEBOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3A2B960", Offset = "0x3A2A960", VA = "0x183A2B960")]
			internal MAEKLNHODCE PJMIEHCPGKE(HMGHFEJCNPO portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct JFAJCPEOPBH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public CLCOOBHFPJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3CCC530", Offset = "0x3CCB530", VA = "0x183CCC530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct IAJBANEALDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public CLCOOBHFPJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public HMIMKNJCMOD? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public NKJKDNJNIDM? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3AC7810", Offset = "0x3AC6810", VA = "0x183AC7810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3AC7AB0", Offset = "0x3AC6AB0", VA = "0x183AC7AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class ADNIKJIJOPD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public ADNIKJIJOPD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x328AD20", Offset = "0x3289D20", VA = "0x18328AD20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public CLCOOBHFPJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public KHIBPDIHFCI configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public ADNIKJIJOPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			internal string LGFPJIFNHIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
			internal void OOAPGKCHADN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x394B970", Offset = "0x394A970", VA = "0x18394B970")]
			[AsyncStateMachine(typeof(CLCOOBHFPJC<>.ADNIKJIJOPD.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void JAHNDPMHGIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class NOLMCOBMECL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public NOLMCOBMECL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x40CA7F0", Offset = "0x40C97F0", VA = "0x1840CA7F0")]
			internal bool IDKKKMGEMBL(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x40CA8D0", Offset = "0x40C98D0", VA = "0x1840CA8D0")]
			internal bool PKIGIAHKCHA(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct LPILFOBPKHJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public CLCOOBHFPJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x3E5C430", Offset = "0x3E5B430", VA = "0x183E5C430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3E5C7A0", Offset = "0x3E5B7A0", VA = "0x183E5C7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly DPBBAOGMDLF JKHHDKKPHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly bool CEAJBBFEACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private JOFNNHDKNPL<EOKIOPDIOPK, MAEKLNHODCE> NEEPCGDCFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private JOFNNHDKNPL<EOKIOPDIOPK, PKHJHELMAJM> JGKJNFJNLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<Action> NPJOKNIAEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[CompilerGenerated]
		private Action<JLADLGKIDDG<EOKIOPDIOPK>>? OHJDGINCFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[CompilerGenerated]
		private Action<JLADLGKIDDG<EOKIOPDIOPK>, PKHJHELMAJM>? JKOFIICHLCD;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected MKOBJJKBAKB CGGAKKGGMCH
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x501D6A0", Offset = "0x501C6A0", VA = "0x18501D6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected TNode AHBLGPEFHCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public HHBFDIMEGNL<DBFECPGAJAD> FOGPHGOOFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9CA160", Offset = "0x9C9160", VA = "0x1809CA160", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HHBFDIMEGNL<DBFECPGAJAD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public JLADLGKIDDG<BLJMFLPPBIA> MLNHCELMHHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5020D20", Offset = "0x501FD20", VA = "0x185020D20", Slot = "6")]
			get
			{
				return default(JLADLGKIDDG<BLJMFLPPBIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public object PNEGOLACHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x357D4E0", Offset = "0x357C4E0", VA = "0x18357D4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool MHMMNIEHDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int FBIBJOLBPGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5020A20", Offset = "0x501FA20", VA = "0x185020A20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public KLMNMOFHOAB GICIJFGCGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x50209D0", Offset = "0x501F9D0", VA = "0x1850209D0", Slot = "10")]
			get
			{
				return default(KLMNMOFHOAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string DCLJCEKCEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5020EB0", Offset = "0x501FEB0", VA = "0x185020EB0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected virtual bool BKGDCFPPHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JLADLGKIDDG<BKHDPNHDLLE> DJJJOMOKEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x952CC0", Offset = "0x951CC0", VA = "0x180952CC0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(JLADLGKIDDG<BKHDPNHDLLE>);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x9CAA40", Offset = "0x9C9A40", VA = "0x1809CAA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual bool FAEJEOPDPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool OKNOMFNLHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual BAFCENBJONO ILLPOBDDLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9053D0", Offset = "0x9043D0", VA = "0x1809053D0", Slot = "93")]
			get
			{
				return default(BAFCENBJONO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool NAEIECIGLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5020800", Offset = "0x501F800", VA = "0x185020800", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool ADKGDIKLHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5020850", Offset = "0x501F850", VA = "0x185020850", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool LNNHKJLOMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x50208A0", Offset = "0x501F8A0", VA = "0x1850208A0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int LHOBLMJKFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5020CE0", Offset = "0x501FCE0", VA = "0x185020CE0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool GBLBKCHIHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5020B60", Offset = "0x501FB60", VA = "0x185020B60", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool EBCIFIPMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x5020930", Offset = "0x501F930", VA = "0x185020930", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool HJEOKHNKIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xB055A0", Offset = "0xB045A0", VA = "0x180B055A0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xB058C0", Offset = "0xB048C0", VA = "0x180B058C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual bool IPHJBNCAOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool DPJLBAAFFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x50208F0", Offset = "0x501F8F0", VA = "0x1850208F0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool PDJDMMHCEFA
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x5020AB0", Offset = "0x501FAB0", VA = "0x185020AB0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public HMIMKNJCMOD OBJFNILBNAE
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x5020C40", Offset = "0x501FC40", VA = "0x185020C40", Slot = "27")]
			get
			{
				return default(HMIMKNJCMOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public NKJKDNJNIDM KFGIAIMBKPH
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5020C90", Offset = "0x501FC90", VA = "0x185020C90", Slot = "29")]
			get
			{
				return default(NKJKDNJNIDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool JMIOIJEMBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual IPGKMDEIHLP? KACDAEAAPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual EMHNBPOKPIA? KMKOIEOEEAG
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual IEnumerable<HHBFDIMEGNL<GAGHAPPFMGC>>? OIPLCBPLLLP
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool CCOALMOFBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x5020980", Offset = "0x501F980", VA = "0x185020980", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public HHBFDIMEGNL<IHHFAAHIKGJ> IDCCFJHBJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x5020BA0", Offset = "0x501FBA0", VA = "0x185020BA0", Slot = "55")]
			get
			{
				return default(HHBFDIMEGNL<IHHFAAHIKGJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public JLADLGKIDDG<IHHFAAHIKGJ> EJPPJCBGKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x5020A60", Offset = "0x501FA60", VA = "0x185020A60", Slot = "56")]
			get
			{
				return default(JLADLGKIDDG<IHHFAAHIKGJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool HHHBCEKGLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual JLADLGKIDDG<IHHFAAHIKGJ>? JNIBIMPDLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool GOCDDAJLOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DCPJBPLMMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5020B00", Offset = "0x501FB00", VA = "0x185020B00", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB7F0", Offset = "0x7CA7F0", VA = "0x1807CB7F0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB800", Offset = "0x7CA800", VA = "0x1807CB800")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public HHBFDIMEGNL<GAGHAPPFMGC> CGGNJEDIKAN
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5020BF0", Offset = "0x501FBF0", VA = "0x185020BF0", Slot = "62")]
			get
			{
				return default(HHBFDIMEGNL<GAGHAPPFMGC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public HHBFDIMEGNL<GAGHAPPFMGC>? GNFAGBDKOKF
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5020D90", Offset = "0x501FD90", VA = "0x185020D90", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public IPKLIOLMJJP<EOKIOPDIOPK, PKHJHELMAJM> FNMPCJLLLLN
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5020E70", Offset = "0x501FE70", VA = "0x185020E70", Slot = "64")]
			get
			{
				return default(IPKLIOLMJJP<EOKIOPDIOPK, PKHJHELMAJM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual JLADLGKIDDG<EOKIOPDIOPK>? AEHMMKMHELC
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual bool JAHNNPLLOOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool MLCAFHBEPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBIKKDKBNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x501D790", Offset = "0x501C790", VA = "0x18501D790", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x5020270", Offset = "0x501F270", VA = "0x185020270", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IMLKNCPOKHB FBBOOBLCNPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x501F6C0", Offset = "0x501E6C0", VA = "0x18501F6C0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x501DFE0", Offset = "0x501CFE0", VA = "0x18501DFE0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HBPDLCFDPIJ BAFDCONCKHP
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x501ED60", Offset = "0x501DD60", VA = "0x18501ED60", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x501D3B0", Offset = "0x501C3B0", VA = "0x18501D3B0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CJOAMMJJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x501D8F0", Offset = "0x501C8F0", VA = "0x18501D8F0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x501B820", Offset = "0x501A820", VA = "0x18501B820", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CGNBJKGFJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x501D520", Offset = "0x501C520", VA = "0x18501D520", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x501E4D0", Offset = "0x501D4D0", VA = "0x18501E4D0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>, PKHJHELMAJM> OLMJABLNEJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x501BF60", Offset = "0x501AF60", VA = "0x18501BF60", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x501E360", Offset = "0x501D360", VA = "0x18501E360", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>, PKHJHELMAJM> EEIHNDMELDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x501E630", Offset = "0x501D630", VA = "0x18501E630", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x50200F0", Offset = "0x501F0F0", VA = "0x1850200F0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>> OCOHCLLDALA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x501D9A0", Offset = "0x501C9A0", VA = "0x18501D9A0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x501B940", Offset = "0x501A940", VA = "0x18501B940", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>, JLADLGKIDDG<EOKIOPDIOPK>> FNMHKBBCKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x501B880", Offset = "0x501A880", VA = "0x18501B880", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x501CA80", Offset = "0x501BA80", VA = "0x18501CA80", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>, PKHJHELMAJM> ABNFKOONBGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x501E570", Offset = "0x501D570", VA = "0x18501E570", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5020030", Offset = "0x501F030", VA = "0x185020030", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<JLADLGKIDDG<EOKIOPDIOPK>, JLADLGKIDDG<EOKIOPDIOPK>> ECOMIEBCPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x501D830", Offset = "0x501C830", VA = "0x18501D830", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x50201B0", Offset = "0x501F1B0", VA = "0x1850201B0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5020310", Offset = "0x501F310", VA = "0x185020310")]
		[HHGFKKBEMKA("Need to handle `Name` better.")]
		[HHGFKKBEMKA("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected CLCOOBHFPJC(DPBBAOGMDLF PDDFEIFGNBJ, TNode CDMAFKOHEPF, bool OKGHOBKPLHH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x501C170", Offset = "0x501B170", VA = "0x18501C170", Slot = "86")]
		protected virtual void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x501CB40", Offset = "0x501BB40", VA = "0x18501CB40", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x501E420", Offset = "0x501D420", VA = "0x18501E420", Slot = "9")]
		[AsyncStateMachine(typeof(CLCOOBHFPJC<>.JFAJCPEOPBH))]
		public void IDBJKGNFKFD(int LBDKDDHEGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x501D640", Offset = "0x501C640", VA = "0x18501D640")]
		public bool EIPCBGJCHKD([In] HMIMKNJCMOD LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x501ED00", Offset = "0x501DD00", VA = "0x18501ED00")]
		public bool KDMKMKACNBM([In] NKJKDNJNIDM LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x501F4D0", Offset = "0x501E4D0", VA = "0x18501F4D0", Slot = "31")]
		public void MBLJMLFNJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x501F380", Offset = "0x501E380", VA = "0x18501F380", Slot = "32")]
		[AsyncStateMachine(typeof(CLCOOBHFPJC<>.IAJBANEALDA))]
		public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> KPNOFJMFMHM(HMIMKNJCMOD? CMCMKLBCKPK, NKJKDNJNIDM? JOFKHOOOHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "96")]
		public virtual void JEKNHCDAKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "97")]
		public virtual void KCCMHLKOJFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "98")]
		public virtual void DIIAAAKDGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1B683A0", Offset = "0x1B673A0", VA = "0x181B683A0")]
		protected void CEMOJANPPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4473AC0", Offset = "0x4472AC0", VA = "0x184473AC0")]
		protected void ICKMHBBHPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE910", Offset = "0x1FFD910", VA = "0x181FFE910")]
		private void FCCKBPIMBBE([In] NKJKDNJNIDM CKCOAEGKOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x501D450", Offset = "0x501C450", VA = "0x18501D450", Slot = "99")]
		public virtual Task<PGLGENBDGKP<JLADLGKIDDG<EOKIOPDIOPK>, AABLFGLHLFL>> EDOBMOCEEFB(string ONGJKHHOIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x501F760", Offset = "0x501E760", VA = "0x18501F760", Slot = "100")]
		public virtual Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> MGEFIPICMAL(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "101")]
		public virtual void GKEPDKDOOCJ(JLADLGKIDDG<EOKIOPDIOPK> GPEHCABDGEJ, JLADLGKIDDG<EOKIOPDIOPK> AOHFGFEGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x501DBE0", Offset = "0x501CBE0", VA = "0x18501DBE0", Slot = "102")]
		public virtual IEnumerable<EBBJCOBMEJP> GNOCPBNJNEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x501D5C0", Offset = "0x501C5C0", VA = "0x18501D5C0", Slot = "103")]
		public PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL> EHKKJINLDBC(string EAKBCEMNLBJ)
		{
			return default(PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x501DA90", Offset = "0x501CA90", VA = "0x18501DA90", Slot = "46")]
		public bool GMALBFNPFCC([Out] Guid HPBJDLMMPEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x501E080", Offset = "0x501D080", VA = "0x18501E080")]
		public bool HGGJBKFKJCC([In] Guid ABBEJOMODMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "104")]
		public virtual void KNIDJLMEEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "105")]
		public virtual void PNFBPIALNPI(bool OBDBDNDIAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "106")]
		public virtual GPNIDGHEDOE PJIOCCNIKIA([In] BHPEFELDDJF DGLINAAFBFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x501E6F0", Offset = "0x501D6F0", VA = "0x18501E6F0")]
		protected void JLFANAPFFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x501DA60", Offset = "0x501CA60", VA = "0x18501DA60", Slot = "111")]
		protected virtual bool GHFMMDGEGHH(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "112")]
		protected virtual bool NGGDLLHNIGM(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "119")]
		protected virtual void NLOCILMGOMH(KHIBPDIHFCI FOCCLBLJGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x501BA00", Offset = "0x501AA00", VA = "0x18501BA00")]
		protected void AOPMFHNEFHK(KHIBPDIHFCI PHDFCHHGOGO, Func<string> GPLAMNNECOH, Action<string> IEFHKGFLALE, EDGLAMHKCJK JMCMGAGCLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x501DC70", Offset = "0x501CC70", VA = "0x18501DC70")]
		protected void GNPKPMPADMB(KHIBPDIHFCI PHDFCHHGOGO, Func<string> GPLAMNNECOH, Action<string> IEFHKGFLALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x501F950", Offset = "0x501E950", VA = "0x18501F950", Slot = "120")]
		protected virtual void MNMEIKKHGBI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x501DF90", Offset = "0x501CF90", VA = "0x18501DF90", Slot = "79")]
		public void HADJBNIAHME(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x501C090", Offset = "0x501B090", VA = "0x18501C090", Slot = "80")]
		public LPGOIGCDKNA CFJFKDLDHMA()
		{
			return default(LPGOIGCDKNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "123")]
		public virtual bool LNCLLPBGPIF(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x126ACE0", Offset = "0x1269CE0", VA = "0x18126ACE0")]
		private void PFJEKEBMPGC([In] HMIMKNJCMOD BJIKBOECFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x501FAC0", Offset = "0x501EAC0", VA = "0x18501FAC0")]
		private void NFDOAHEKDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x501EE00", Offset = "0x501DE00", VA = "0x18501EE00")]
		private void KJIKEDIDAIE(int GHBIKKNMKMG, HMGHFEJCNPO NEAPHJEPOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x501FFE0", Offset = "0x501EFE0", VA = "0x18501FFE0")]
		private void OHHKDGJLNBL(int GPEHCABDGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x501C940", Offset = "0x501B940", VA = "0x18501C940")]
		private void DDPMGKAIDPJ(int GPEHCABDGEJ, HMGHFEJCNPO KBAGONGOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x501FC30", Offset = "0x501EC30", VA = "0x18501FC30")]
		private void OCIMFFFBENL(int LDALENKMMJE, int BMLFBIDAKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x501BF00", Offset = "0x501AF00", VA = "0x18501BF00")]
		private void BGFAKBCEDBP(int LDALENKMMJE, int BMLFBIDAKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x501F330", Offset = "0x501E330", VA = "0x18501F330")]
		private void KOAHNHAKCBD(int GPEHCABDGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x501E8D0", Offset = "0x501D8D0", VA = "0x18501E8D0")]
		private void JMNMJNPJMAP(int GHBIKKNMKMG, HMGHFEJCNPO NEAPHJEPOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x501BE80", Offset = "0x501AE80", VA = "0x18501BE80")]
		private void BAIPIHABIJM(int GPEHCABDGEJ, HMGHFEJCNPO KBAGONGOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x501F830", Offset = "0x501E830", VA = "0x18501F830", Slot = "124")]
		[AsyncStateMachine(typeof(CLCOOBHFPJC<>.LPILFOBPKHJ))]
		public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> MKEGNJHLLIG(string EAKBCEMNLBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x501C020", Offset = "0x501B020", VA = "0x18501C020", Slot = "53")]
		private void CBCMKCAIAFH(object AMPGGHEFPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x501FBC0", Offset = "0x501EBC0", VA = "0x18501FBC0", Slot = "54")]
		private void OACFNGNNLFI(object AMPGGHEFPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x501E330", Offset = "0x501D330", VA = "0x18501E330", Slot = "28")]
		private bool HNPILNLDICK([In] HMIMKNJCMOD LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x501FA90", Offset = "0x501EA90", VA = "0x18501FA90", Slot = "30")]
		private bool NCCNKBAMECO([In] NKJKDNJNIDM LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x501BE50", Offset = "0x501AE50", VA = "0x18501BE50", Slot = "47")]
		private bool APIPFDIKFLN([In] Guid ABBEJOMODMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x501C910", Offset = "0x501B910", VA = "0x18501C910")]
		[CompilerGenerated]
		private string DCHEGMJDEKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x501C870", Offset = "0x501B870", VA = "0x18501C870")]
		[CompilerGenerated]
		private void CKBODDECJDF(string ONGJKHHOIAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class KKNEMHJOONP : GBIOFIADOAP<EPNNFJNKHON>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xC2C6F0", Offset = "0xC2B6F0", VA = "0x180C2C6F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E15600", Offset = "0x1E14600", VA = "0x181E15600")]
		public KKNEMHJOONP(DPBBAOGMDLF PDDFEIFGNBJ, EPNNFJNKHON CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class IIDDDJEOGDN : ILDMCPCAKOP<GJEMPELNONG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1E10FD0", Offset = "0x1E0FFD0", VA = "0x181E10FD0")]
		public IIDDDJEOGDN(DPBBAOGMDLF PDDFEIFGNBJ, GJEMPELNONG CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class IPHLJDHPLFH<T> : CLCOOBHFPJC<T> where T : notnull, FLCLBNFHKBB
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class GNFEGBPJNON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public IReadOnlyList<KeyValuePair<string, LLKBFGNAECE>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public IPHLJDHPLFH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public DNHODHICOCK clipType;

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public GNFEGBPJNON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			internal IReadOnlyList<KeyValuePair<string, LLKBFGNAECE>> LNBFFFPDEDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x39C3310", Offset = "0x39C2310", VA = "0x1839C3310")]
			internal int OBJJLIBGIIM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x39C3460", Offset = "0x39C2460", VA = "0x1839C3460")]
			internal void PLCMMPNFCON(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x39C3220", Offset = "0x39C2220", VA = "0x1839C3220")]
			internal void GNEGEJOFDOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x39C3270", Offset = "0x39C2270", VA = "0x1839C3270")]
			internal float NMFFOJAJPEK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x39C3110", Offset = "0x39C2110", VA = "0x1839C3110")]
			internal void FFOGFEIKLCC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x39C31D0", Offset = "0x39C21D0", VA = "0x1839C31D0")]
			internal float FGOFEGHAIIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x39C2F90", Offset = "0x39C1F90", VA = "0x1839C2F90")]
			internal void BAHNCCABIDC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x39C32C0", Offset = "0x39C22C0", VA = "0x1839C32C0")]
			internal float NNCJLHFFEGF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x39C3050", Offset = "0x39C2050", VA = "0x1839C3050")]
			internal void ELAKAFOAAJA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8E0BF0", Offset = "0x8DFBF0", VA = "0x1808E0BF0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public abstract DNHODHICOCK JJDNFNLFPGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B28750", Offset = "0x3B27750", VA = "0x183B28750")]
		public IPHLJDHPLFH(DPBBAOGMDLF PDDFEIFGNBJ, T CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3B27F60", Offset = "0x3B26F60", VA = "0x183B27F60", Slot = "119")]
		protected sealed override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class AKEBKFDLKKH : CLCOOBHFPJC<IBLPIMBJIGA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C00", Offset = "0x8DFC00", VA = "0x1808E0C00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E069E0", Offset = "0x1E059E0", VA = "0x181E069E0")]
		public AKEBKFDLKKH(DPBBAOGMDLF PDDFEIFGNBJ, IBLPIMBJIGA CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class CPGPEDNEMMO : IPHLJDHPLFH<DNDCLNOBIJF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override DNHODHICOCK JJDNFNLFPGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "125")]
			get
			{
				return default(DNHODHICOCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E09200", Offset = "0x1E08200", VA = "0x181E09200")]
		public CPGPEDNEMMO(DPBBAOGMDLF PDDFEIFGNBJ, DNDCLNOBIJF OFFMGNOKEOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class DJHGIKMFBJP : ILDMCPCAKOP<HCAAKFNELJL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E095F0", Offset = "0x1E085F0", VA = "0x181E095F0")]
		public DJHGIKMFBJP(DPBBAOGMDLF PDDFEIFGNBJ, HCAAKFNELJL CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class LBHDBPFPJHG : ILDMCPCAKOP<PHOMCFGFJKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1E16300", Offset = "0x1E15300", VA = "0x181E16300")]
		public LBHDBPFPJHG(DPBBAOGMDLF PDDFEIFGNBJ, PHOMCFGFJKB CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class GIKOFHHCHBA : DNBBIIFDPMO<IEIIILPNIGO>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class GAPNAJBFGAB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public GAPNAJBFGAB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x1E22640", Offset = "0x1E21640", VA = "0x181E22640", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public GIKOFHHCHBA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public GAPNAJBFGAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E170", Offset = "0x1E0D170", VA = "0x181E0E170")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HPNEKPMELIE(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E520", Offset = "0x1E0D520", VA = "0x181E0E520")]
		public GIKOFHHCHBA(DPBBAOGMDLF PDDFEIFGNBJ, IEIIILPNIGO OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E240", Offset = "0x1E0D240", VA = "0x181E0E240", Slot = "125")]
		protected override void JBGJNGDDMJI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class HKDLPNGPEKO : IPHLJDHPLFH<CEKHJBGEJBD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override DNHODHICOCK JJDNFNLFPGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x923370", Offset = "0x922370", VA = "0x180923370", Slot = "125")]
			get
			{
				return default(DNHODHICOCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F820", Offset = "0x1E0E820", VA = "0x181E0F820")]
		public HKDLPNGPEKO(DPBBAOGMDLF PDDFEIFGNBJ, CEKHJBGEJBD OFFMGNOKEOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class AOANMNKDLAE : CLCOOBHFPJC<AAAHOJJMDKM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xC55650", Offset = "0xC54650", VA = "0x180C55650", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E070F0", Offset = "0x1E060F0", VA = "0x181E070F0")]
		public AOANMNKDLAE(DPBBAOGMDLF PDDFEIFGNBJ, AAAHOJJMDKM CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class KNAPJOPDAFJ : CLCOOBHFPJC<EHCMHNKKNCP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly Dictionary<string, LLKBFGNAECE> HCNBJOMFMKC;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public sealed override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public sealed override bool FAEJEOPDPCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected sealed override bool BKGDCFPPHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1E15ED0", Offset = "0x1E14ED0", VA = "0x181E15ED0")]
		public KNAPJOPDAFJ(DPBBAOGMDLF PDDFEIFGNBJ, EHCMHNKKNCP CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1E15CA0", Offset = "0x1E14CA0", VA = "0x181E15CA0", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1E15C00", Offset = "0x1E14C00", VA = "0x181E15C00")]
		private int BCJGCOJDCPO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1E15C40", Offset = "0x1E14C40", VA = "0x181E15C40")]
		private void CBKHIJHJJAL(int PAFEMMFOAKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class DAEOOPFCPPD : DNBBIIFDPMO<IACHFMNOHAC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1E09260", Offset = "0x1E08260", VA = "0x181E09260")]
		public DAEOOPFCPPD(DPBBAOGMDLF PDDFEIFGNBJ, IACHFMNOHAC CDMAFKOHEPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class DNBBIIFDPMO<TVariableNode> : CLCOOBHFPJC<TVariableNode> where TVariableNode : notnull, IACHFMNOHAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class KHGAIJMFNPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public DNBBIIFDPMO<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public KHGAIJMFNPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3D85220", Offset = "0x3D84220", VA = "0x183D85220")]
			internal bool LNBFFFPDEDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x3D85310", Offset = "0x3D84310", VA = "0x183D85310")]
			internal void OBJJLIBGIIM(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x3D853D0", Offset = "0x3D843D0", VA = "0x183D853D0")]
			internal bool PLCMMPNFCON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x3D85160", Offset = "0x3D84160", VA = "0x183D85160")]
			internal void GNEGEJOFDOI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x3D85270", Offset = "0x3D84270", VA = "0x183D85270")]
			internal bool NMFFOJAJPEK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class EMJNBJIBMPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public MKOBJJKBAKB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public DNBBIIFDPMO<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public EMJNBJIBMPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x351F520", Offset = "0x351E520", VA = "0x18351F520")]
			internal void HPNEKPMELIE(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x926300", Offset = "0x925300", VA = "0x180926300", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override BAFCENBJONO ILLPOBDDLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x5213390", Offset = "0x5212390", VA = "0x185213390", Slot = "93")]
			get
			{
				return default(BAFCENBJONO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5213220", Offset = "0x5212220", VA = "0x185213220")]
		protected DNBBIIFDPMO(DPBBAOGMDLF PDDFEIFGNBJ, TVariableNode CDMAFKOHEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x52127F0", Offset = "0x52117F0", VA = "0x1852127F0", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5212DA0", Offset = "0x5211DA0", VA = "0x185212DA0", Slot = "119")]
		protected override void NLOCILMGOMH(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5212950", Offset = "0x5211950", VA = "0x185212950", Slot = "125")]
		protected virtual void JBGJNGDDMJI(KHIBPDIHFCI PHDFCHHGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5212CC0", Offset = "0x5211CC0", VA = "0x185212CC0", Slot = "104")]
		public override void KNIDJLMEEBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E1E0", Offset = "0x1E1D1E0", VA = "0x181E1E1E0")]
	internal static KHIFPKEHEIM MGIIAIMPALM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class KDAMIFKGCCK : MOMDBHCHLJM, JHPBJEOLMOL, DKJNMPPFPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JLADLGKIDDG<HIDODOLPGGA> LBBAEBCNIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xDC9490", Offset = "0xDC8490", VA = "0x180DC9490", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(JLADLGKIDDG<HIDODOLPGGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JLADLGKIDDG<NPKBJOKMGLG> NHPAIJEFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1074830", Offset = "0x1073830", VA = "0x181074830", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JLADLGKIDDG<NPKBJOKMGLG>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1E150E0", Offset = "0x1E140E0", VA = "0x181E150E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private JLADLGKIDDG<MLIECAGLJCM> FNOBHCJGECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA52D50", Offset = "0xA51D50", VA = "0x180A52D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public override JLADLGKIDDG<NOKKFPEKGJM> CANBGNJEBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1E150A0", Offset = "0x1E140A0", VA = "0x181E150A0", Slot = "20")]
		get
		{
			return default(JLADLGKIDDG<NOKKFPEKGJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1E15490", Offset = "0x1E14490", VA = "0x181E15490")]
	private KDAMIFKGCCK(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF, OEGHNJJHKKL ANFCLEKBCIE, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<NPKBJOKMGLG> IDIHOPKDBNN, JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI, bool KGIFDLGHLGB, string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1E150F0", Offset = "0x1E140F0", VA = "0x181E150F0")]
	public static KDAMIFKGCCK MGIIAIMPALM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF, OEGHNJJHKKL PBCHEFBMFKH, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI, JLADLGKIDDG<NPKBJOKMGLG> IDIHOPKDBNN, bool KGIFDLGHLGB, bool OKGHOBKPLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1E150E0", Offset = "0x1E140E0", VA = "0x181E150E0")]
	internal void KNNAODDPFBH(JLADLGKIDDG<NPKBJOKMGLG> LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class MOMDBHCHLJM : DKJNMPPFPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct IMOJHDIKBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private IFHDEDHFEFB? IMGNHJFNFOK;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1E13F70", Offset = "0x1E12F70", VA = "0x181E13F70")]
		public void HCLIMFMHPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1E13F80", Offset = "0x1E12F80", VA = "0x181E13F80")]
		public IFHDEDHFEFB LFMKIAECPIA(MOMDBHCHLJM ABHGMGICLLE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly GNCGFFJFNCO FAFDCBNOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private IMOJHDIKBDJ EMEMBCOKBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly BIELPDMGDEM FIOPJLJMAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly List<JEIJJAKLFEF> PLEBNBPPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<OCCFCNFACKO> MBADCFFOKFK;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<StaticEdge> BOMMKJICEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1E20160", Offset = "0x1E1F160", VA = "0x181E20160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DisplayKind NODKGKEGAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7D00D0", Offset = "0x7CF0D0", VA = "0x1807D00D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JLADLGKIDDG<IHHFAAHIKGJ> EJPPJCBGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F0C0", Offset = "0x1E1E0C0", VA = "0x181E1F0C0", Slot = "6")]
		get
		{
			return default(JLADLGKIDDG<IHHFAAHIKGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public HHBFDIMEGNL<IHHFAAHIKGJ> IDCCFJHBJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1E20130", Offset = "0x1E1F130", VA = "0x181E20130", Slot = "7")]
		get
		{
			return default(HHBFDIMEGNL<IHHFAAHIKGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public LOOPDHANNBN KBOIIHDJBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x19FDBD0", Offset = "0x19FCBD0", VA = "0x1819FDBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BEHBGKLLBPI ELJCGHAHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1E1FF60", Offset = "0x1E1EF60", VA = "0x181E1FF60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	protected IFHDEDHFEFB GCDDNGEAPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1E1FF60", Offset = "0x1E1EF60", VA = "0x181E1FF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public PortImage PFLEGPMHIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1E20000", Offset = "0x1E1F000", VA = "0x181E20000", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7C6550", Offset = "0x7C5550", VA = "0x1807C6550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HHBFDIMEGNL<GAGHAPPFMGC> CGGNJEDIKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F0A0", Offset = "0x1E1E0A0", VA = "0x181E1F0A0", Slot = "9")]
		get
		{
			return default(HHBFDIMEGNL<GAGHAPPFMGC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public JLADLGKIDDG<EOKIOPDIOPK> MJIMFOLNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x861170", VA = "0x180862170", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JLADLGKIDDG<EOKIOPDIOPK>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xD19760", Offset = "0xD18760", VA = "0x180D19760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract JLADLGKIDDG<NOKKFPEKGJM> CANBGNJEBED
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1E202B0", Offset = "0x1E1F2B0", VA = "0x181E202B0")]
	protected MOMDBHCHLJM(DPBBAOGMDLF PDDFEIFGNBJ, GNCGFFJFNCO CDMAFKOHEPF, BIELPDMGDEM HEABAAFBNMN, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, bool KGIFDLGHLGB, string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F170", Offset = "0x1E1E170", VA = "0x181E1F170", Slot = "21")]
	protected virtual void CJMKLAKCCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F950", Offset = "0x1E1E950", VA = "0x181E1F950", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FBC0", Offset = "0x1E1EBC0", VA = "0x181E1FBC0", Slot = "14")]
	public void ICKEKPNOEEF(JEIJJAKLFEF KDLHKPDFNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F110", Offset = "0x1E1E110", VA = "0x181E1F110", Slot = "15")]
	public void BNCEKDNCAKK(OCCFCNFACKO KDLHKPDFNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F2C0", Offset = "0x1E1E2C0", VA = "0x181E1F2C0", Slot = "16")]
	public void DNNOAIKBADM(KAPBNNIDDFL BKAABBKIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FB00", Offset = "0x1E1EB00", VA = "0x181E1FB00", Slot = "23")]
	protected virtual void FOIIMMMCJOO(KAPBNNIDDFL BKAABBKIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FC20", Offset = "0x1E1EC20", VA = "0x181E1FC20")]
	private void IDFHFIJIGEE(bool GEJMEMCGHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EEF0", Offset = "0x1E1DEF0", VA = "0x181E1EEF0")]
	private void AJPBGKMOLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FDB0", Offset = "0x1E1EDB0", VA = "0x181E1FDB0")]
	private void IGHIJNAHCKP([In] EIFIIELOEME PLBECCLMLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FB60", Offset = "0x1E1EB60", VA = "0x181E1FB60", Slot = "17")]
	public void HOBLEGCGKPP(JEIJJAKLFEF KDLHKPDFNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1E1FAA0", Offset = "0x1E1EAA0", VA = "0x181E1FAA0", Slot = "18")]
	public void EMPHBNCPIAG(OCCFCNFACKO KDLHKPDFNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7C6550", Offset = "0x7C5550", VA = "0x1807C6550")]
	internal void IPDKIKOGBBF(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F0F0", Offset = "0x1E1E0F0", VA = "0x181E1F0F0")]
	internal void BLEDDDNPEDN(ANEGEOGDDEJ AKOGIKBAMPF, LOOPDHANNBN KBCNAJKPHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xD19760", Offset = "0xD18760", VA = "0x180D19760")]
	internal void IIPMDCDNKBF(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class MAEKLNHODCE : PKHJHELMAJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EEJLEPAODKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public DPBBAOGMDLF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public GNCGFFJFNCO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public JLADLGKIDDG<EOKIOPDIOPK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EEJLEPAODKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BBB0", Offset = "0x1E0ABB0", VA = "0x181E0BBB0")]
		internal IKBNCAAFJKM HFKDHKAOCJO((int PortDescIndex, int PortIndex, EENJFONECLI InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BB20", Offset = "0x1E0AB20", VA = "0x181E0BB20")]
		internal KDAMIFKGCCK DMCHEEKMENA(OEGHNJJHKKL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct JCMBFFICJBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1E144F0", Offset = "0x1E134F0", VA = "0x181E144F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1E14950", Offset = "0x1E13950", VA = "0x181E14950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct EFCFJCCBHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public JLADLGKIDDG<HMCEGANNKMN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BC40", Offset = "0x1E0AC40", VA = "0x181E0BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BF90", Offset = "0x1E0AF90", VA = "0x181E0BF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct PECCMHEDDOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public JLADLGKIDDG<MLIECAGLJCM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1E21A30", Offset = "0x1E20A30", VA = "0x181E21A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1E21D80", Offset = "0x1E20D80", VA = "0x181E21D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct FPLPBKGPLDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JLADLGKIDDG<HMCEGANNKMN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public JLADLGKIDDG<HMCEGANNKMN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DDB0", Offset = "0x1E0CDB0", VA = "0x181E0DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E100", Offset = "0x1E0D100", VA = "0x181E0E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct HEGJNPJCAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public JLADLGKIDDG<MLIECAGLJCM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public JLADLGKIDDG<MLIECAGLJCM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EF20", Offset = "0x1E0DF20", VA = "0x181E0EF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F270", Offset = "0x1E0E270", VA = "0x181E0F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct IIDCBFKAKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1E10AF0", Offset = "0x1E0FAF0", VA = "0x181E10AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1E10F60", Offset = "0x1E0FF60", VA = "0x181E10F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct LBILKIDAEFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1E16360", Offset = "0x1E15360", VA = "0x181E16360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1E166B0", Offset = "0x1E156B0", VA = "0x181E166B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct NPAJIAIIJAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public JLADLGKIDDG<HMCEGANNKMN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1E20690", Offset = "0x1E1F690", VA = "0x181E20690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1E209E0", Offset = "0x1E1F9E0", VA = "0x181E209E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct MFACKDBFIEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public JLADLGKIDDG<MLIECAGLJCM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D1E0", Offset = "0x1E1C1E0", VA = "0x181E1D1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D530", Offset = "0x1E1C530", VA = "0x181E1D530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct MLJFIOIPDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public KHBBJBOFOKB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public JLADLGKIDDG<HMCEGANNKMN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DD70", Offset = "0x1E1CD70", VA = "0x181E1DD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E100", Offset = "0x1E1D100", VA = "0x181E1E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct MFOJDHGGLCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MAEKLNHODCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public KHBBJBOFOKB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public JLADLGKIDDG<MLIECAGLJCM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private AFGAGCCGDDM <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D5A0", Offset = "0x1E1C5A0", VA = "0x181E1D5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D930", Offset = "0x1E1C930", VA = "0x181E1D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly bool ANAKJBODOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool EDCPHGECDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private IPKLIOLMJJP<FPKDDGFFKID, IKBNCAAFJKM> PDIFJCIADPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private IPKLIOLMJJP<FPKDDGFFKID, MPLCMLPCLMB> LCPPGOJHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GNCGFFJFNCO FAFDCBNOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private IPKLIOLMJJP<NPKBJOKMGLG, KDAMIFKGCCK> NBNAFOJBJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private IPKLIOLMJJP<NPKBJOKMGLG, JHPBJEOLMOL> PGCGDMCGJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private string? KLECBDOFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly HMGHFEJCNPO MIPFLPCFIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private JLADLGKIDDG<EOKIOPDIOPK> FKACEAGNFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly bool CEAJBBFEACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[CompilerGenerated]
	private Action? ELKCPBJMFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[CompilerGenerated]
	private Action? HDEJPMNBBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[CompilerGenerated]
	private Action<JLADLGKIDDG<FPKDDGFFKID>>? IINLPEMIGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[CompilerGenerated]
	private Action<JLADLGKIDDG<NPKBJOKMGLG>>? OIPNCJMCOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[CompilerGenerated]
	private PKHJHELMAJM.JOCHGBCILJB? BICPHKFDFML;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool EEFMNKLBKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1E17280", Offset = "0x1E16280", VA = "0x181E17280", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool HEANFKADFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1E18680", Offset = "0x1E17680", VA = "0x181E18680", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DPMPEKINNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B810", Offset = "0x1E1A810", VA = "0x181E1B810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public HHBFDIMEGNL<IHHFAAHIKGJ> IDCCFJHBJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BC70", Offset = "0x1E1AC70", VA = "0x181E1BC70", Slot = "7")]
		get
		{
			return default(HHBFDIMEGNL<IHHFAAHIKGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool MCOPFFKNJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1E1A100", Offset = "0x1E19100", VA = "0x181E1A100", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IPKLIOLMJJP<FPKDDGFFKID, MPLCMLPCLMB> FLICCPLOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "9")]
		get
		{
			return default(IPKLIOLMJJP<FPKDDGFFKID, MPLCMLPCLMB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1E17A60", Offset = "0x1E16A60", VA = "0x181E17A60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HHBFDIMEGNL<GAGHAPPFMGC> CGGNJEDIKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1E16F70", Offset = "0x1E15F70", VA = "0x181E16F70", Slot = "11")]
		get
		{
			return default(HHBFDIMEGNL<GAGHAPPFMGC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IPKLIOLMJJP<NPKBJOKMGLG, JHPBJEOLMOL> JGMEAFOGHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560", Slot = "12")]
		get
		{
			return default(IPKLIOLMJJP<NPKBJOKMGLG, JHPBJEOLMOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JLADLGKIDDG<EOKIOPDIOPK> MJIMFOLNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA539C0", Offset = "0xA529C0", VA = "0x180A539C0", Slot = "13")]
		get
		{
			return default(JLADLGKIDDG<EOKIOPDIOPK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action ADLAGCGIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C700", Offset = "0x1E1B700", VA = "0x181E1C700", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1E17A90", Offset = "0x1E16A90", VA = "0x181E17A90", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action OMLLNNDKCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CA70", Offset = "0x1E1BA70", VA = "0x181E1CA70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B200", Offset = "0x1E1A200", VA = "0x181E1B200", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JLADLGKIDDG<FPKDDGFFKID>, JLADLGKIDDG<FPKDDGFFKID>> ADJIDHECHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1E16EB0", Offset = "0x1E15EB0", VA = "0x181E16EB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C400", Offset = "0x1E1B400", VA = "0x181E1C400", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JLADLGKIDDG<FPKDDGFFKID>, JLADLGKIDDG<FPKDDGFFKID>> IGGAHHCJJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B490", Offset = "0x1E1A490", VA = "0x181E1B490", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C7A0", Offset = "0x1E1B7A0", VA = "0x181E1C7A0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JLADLGKIDDG<NPKBJOKMGLG>, JLADLGKIDDG<NPKBJOKMGLG>> MCJEJGPIKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1E19210", Offset = "0x1E18210", VA = "0x181E19210", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1E1A180", Offset = "0x1E19180", VA = "0x181E1A180", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JLADLGKIDDG<NPKBJOKMGLG>, JLADLGKIDDG<NPKBJOKMGLG>> JCKKGLJHHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1E16F90", Offset = "0x1E15F90", VA = "0x181E16F90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C860", Offset = "0x1E1B860", VA = "0x181E1C860", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JLADLGKIDDG<FPKDDGFFKID>, MPLCMLPCLMB> OMFLNHOHLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B140", Offset = "0x1E1A140", VA = "0x181E1B140", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1E17B30", Offset = "0x1E16B30", VA = "0x181E17B30", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JLADLGKIDDG<FPKDDGFFKID>> MHLNCIBACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E185C0", Offset = "0x1E175C0", VA = "0x181E185C0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E16DA0", Offset = "0x1E15DA0", VA = "0x181E16DA0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JLADLGKIDDG<FPKDDGFFKID>, MPLCMLPCLMB> PPHGLJECDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E17340", Offset = "0x1E16340", VA = "0x181E17340", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C4C0", Offset = "0x1E1B4C0", VA = "0x181E1C4C0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JLADLGKIDDG<NPKBJOKMGLG>, JHPBJEOLMOL> BHLHACECLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B750", Offset = "0x1E1A750", VA = "0x181E1B750", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C580", Offset = "0x1E1B580", VA = "0x181E1C580", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<JLADLGKIDDG<NPKBJOKMGLG>> JNEIBPEJOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BCA0", Offset = "0x1E1ACA0", VA = "0x181E1BCA0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CC50", Offset = "0x1E1BC50", VA = "0x181E1CC50", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JLADLGKIDDG<NPKBJOKMGLG>, JHPBJEOLMOL> HLMOEGIDBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C640", Offset = "0x1E1B640", VA = "0x181E1C640", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1E193F0", Offset = "0x1E183F0", VA = "0x181E193F0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD70", Offset = "0x1E1BD70", VA = "0x181E1CD70")]
	private MAEKLNHODCE(bool KGIFDLGHLGB, DPBBAOGMDLF PDDFEIFGNBJ, bool EDMNHHLLGAD, IPKLIOLMJJP<FPKDDGFFKID, IKBNCAAFJKM> FFGHDCGLCBL, IPKLIOLMJJP<FPKDDGFFKID, MPLCMLPCLMB> LFPDFIJCJCA, GNCGFFJFNCO CDMAFKOHEPF, IPKLIOLMJJP<NPKBJOKMGLG, KDAMIFKGCCK> KMPJBFEDOBI, IPKLIOLMJJP<NPKBJOKMGLG, JHPBJEOLMOL> BLBFKJEPFMM, string? NKJPOBLOGFM, HMGHFEJCNPO NEAPHJEPOMO, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, bool OKGHOBKPLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BE90", Offset = "0x1E1AE90", VA = "0x181E1BE90")]
	public static MAEKLNHODCE MGIIAIMPALM(bool KGIFDLGHLGB, DPBBAOGMDLF PDDFEIFGNBJ, bool EDMNHHLLGAD, GNCGFFJFNCO CDMAFKOHEPF, HMGHFEJCNPO NEAPHJEPOMO, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, bool OKGHOBKPLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1E17D20", Offset = "0x1E16D20", VA = "0x181E17D20")]
	private void CJMKLAKCCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1E186C0", Offset = "0x1E176C0", VA = "0x181E186C0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B550", Offset = "0x1E1A550", VA = "0x181E1B550", Slot = "38")]
	[AsyncStateMachine(typeof(JCMBFFICJBH))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> KCBEOIKFKEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1E17050", Offset = "0x1E16050", VA = "0x181E17050")]
	private (GAPHPDONPBF, int)? BBDJNEHNAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B2B0", Offset = "0x1E1A2B0", VA = "0x181E1B2B0")]
	private void JIHIELDIDKI(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x12851E0", Offset = "0x12841E0", VA = "0x1812851E0")]
	private void KMOCOIHDKHG(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B8D0", Offset = "0x1E1A8D0", VA = "0x181E1B8D0")]
	private void KJOJFFPKGBA(int MFCEOHPPDCE, int BBIPIAHNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD10", Offset = "0x1E1BD10", VA = "0x181E1CD10")]
	private void PPJEEGMHEPK(int MFCEOHPPDCE, int BBIPIAHNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AC00", Offset = "0x1E19C00", VA = "0x181E1AC00")]
	private void IMNMMKEKKPK(int FIKGMFGHHBC, int AGJPNIMKFLG, EENJFONECLI FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A0B0", Offset = "0x1E190B0", VA = "0x181E1A0B0")]
	private void HIAPJCMDPNB(int GEJMEMCGHEN, int AGJPNIMKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A360", Offset = "0x1E19360", VA = "0x181E1A360")]
	private void IIGFFMCBJED(int GEJMEMCGHEN, int AGJPNIMKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1E198B0", Offset = "0x1E188B0", VA = "0x181E198B0")]
	private void HANCCOJIJJF(int FIKGMFGHHBC, int AGJPNIMKFLG, EENJFONECLI FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1E194B0", Offset = "0x1E184B0", VA = "0x181E194B0")]
	private void FMAOPIAGHLK(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8A4740", Offset = "0x8A3740", VA = "0x1808A4740")]
	private void KOGDDCCPDJM(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B3A0", Offset = "0x1E1A3A0", VA = "0x181E1B3A0")]
	private void JMEBEENKKPP(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x12851E0", Offset = "0x12841E0", VA = "0x1812851E0")]
	private void JIOPIBHHLAL(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1E19D10", Offset = "0x1E18D10", VA = "0x181E19D10")]
	private void HHMFBGJANBC(int MFCEOHPPDCE, int BBIPIAHNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1E19850", Offset = "0x1E18850", VA = "0x181E19850")]
	private void GLALKAMPLCD(int MFCEOHPPDCE, int BBIPIAHNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1E17400", Offset = "0x1E16400", VA = "0x181E17400")]
	private void BKBPBJODMEM(int FIKGMFGHHBC, int AGJPNIMKFLG, OEGHNJJHKKL FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1E191C0", Offset = "0x1E181C0", VA = "0x181E191C0")]
	private void ECAEBFFMMJF(int GEJMEMCGHEN, int AGJPNIMKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1E16E60", Offset = "0x1E15E60", VA = "0x181E16E60")]
	private void AFDOLCGDNOB(int GEJMEMCGHEN, int AGJPNIMKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A780", Offset = "0x1E19780", VA = "0x181E1A780")]
	private void IKODDINDJND(int FIKGMFGHHBC, int AGJPNIMKFLG, OEGHNJJHKKL FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C920", Offset = "0x1E1B920", VA = "0x181E1C920")]
	private void OABDFLPAPIE(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x8A4740", Offset = "0x8A3740", VA = "0x1808A4740")]
	private void ADBJFFIALDJ(int FIKGMFGHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1E17950", Offset = "0x1E16950", VA = "0x181E17950", Slot = "39")]
	[AsyncStateMachine(typeof(EFCFJCCBHHD))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> BKKGBNBEMGA(JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B640", Offset = "0x1E1A640", VA = "0x181E1B640", Slot = "40")]
	[AsyncStateMachine(typeof(PECCMHEDDOG))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> KDPPMPNIJDP(JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1E192D0", Offset = "0x1E182D0", VA = "0x181E192D0", Slot = "41")]
	[AsyncStateMachine(typeof(FPLPBKGPLDM))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> EMJJHEBEBKP(JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI, JLADLGKIDDG<HMCEGANNKMN> BMLFBIDAKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A240", Offset = "0x1E19240", VA = "0x181E1A240", Slot = "42")]
	[AsyncStateMachine(typeof(HEGJNPJCAIA))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> IDPPEKFBOHL(JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI, JLADLGKIDDG<MLIECAGLJCM> BMLFBIDAKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1E184D0", Offset = "0x1E174D0", VA = "0x181E184D0", Slot = "43")]
	[AsyncStateMachine(typeof(IIDCBFKAKGA))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> DAIHBFADDIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1E19600", Offset = "0x1E18600", VA = "0x181E19600", Slot = "44")]
	[AsyncStateMachine(typeof(LBILKIDAEFP))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> GACHHKLIIPI(string EAKBCEMNLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BD60", Offset = "0x1E1AD60", VA = "0x181E1BD60", Slot = "45")]
	[AsyncStateMachine(typeof(NPAJIAIIJAG))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> LKJOAGJJNMH(JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI, string ONGJKHHOIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1E19720", Offset = "0x1E18720", VA = "0x181E19720", Slot = "46")]
	[AsyncStateMachine(typeof(MFACKDBFIEB))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> GHKGAHONMJM(JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI, string ONGJKHHOIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CB20", Offset = "0x1E1BB20", VA = "0x181E1CB20", Slot = "47")]
	[AsyncStateMachine(typeof(MLJFIOIPDFJ))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> ONGCECCBPEH(JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI, KHBBJBOFOKB KBCNAJKPHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1E17BF0", Offset = "0x1E16BF0", VA = "0x181E17BF0", Slot = "48")]
	[AsyncStateMachine(typeof(MFOJDHGGLCF))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> CFPNIPMHCGJ(JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI, KHBBJBOFOKB KBCNAJKPHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A3B0", Offset = "0x1E193B0", VA = "0x181E1A3B0")]
	internal void IIPMDCDNKBF(JLADLGKIDDG<EOKIOPDIOPK> LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class PLCJGBINHPC : PEIJJNBAPBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface MEHHNNNPIMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000096")]
		ANEGEOGDDEJ CLFBDKHIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GIKJOOGIFPO> FOGINMGKDOI(CancellationToken GHLJDIEPICD);

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FKEPIPDGFDA> DFLIKGGBDDF(CancellationToken GHLJDIEPICD);

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<DNCLMLKIGIO> HPDLOJBNEDB(CancellationToken GHLJDIEPICD);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct HOFPDPNCMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder<PLCJGBINHPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public DPBBAOGMDLF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public GIKJOOGIFPO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public FKEPIPDGFDA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private MEHHNNNPIMK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private FKEPIPDGFDA <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<GIKJOOGIFPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<FKEPIPDGFDA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<DNCLMLKIGIO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<NJMBDGBPJJP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F880", Offset = "0x1E0E880", VA = "0x181E0F880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E102B0", Offset = "0x1E0F2B0", VA = "0x181E102B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly NJMBDGBPJJP KCPJHMGFFGC;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public NJMBDGBPJJP NOACFNHCNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	private PLCJGBINHPC(NJMBDGBPJJP HIIACFLIKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1E224E0", Offset = "0x1E214E0", VA = "0x181E224E0")]
	[AsyncStateMachine(typeof(HOFPDPNCMCO))]
	public static Task<PLCJGBINHPC> LBGMCCJIPOG(DPBBAOGMDLF PDDFEIFGNBJ, GIKJOOGIFPO? LAOLHNNNLCH, FKEPIPDGFDA? JEGJKPFGCEN, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1E224C0", Offset = "0x1E214C0", VA = "0x181E224C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct DPPCBGEMLDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct GKGADCAEMOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public DPPCBGEMLDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public EBBJCOBMEJP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E27460", Offset = "0x1E26460", VA = "0x181E27460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E27660", Offset = "0x1E26660", VA = "0x181E27660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct MHPGCNGBNBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<bool, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public DLGKEICEBPG rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public GIKJOOGIFPO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FKEPIPDGFDA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public DPPCBGEMLDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private EBBJCOBMEJP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CB30", Offset = "0x1E2BB30", VA = "0x181E2CB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CF10", Offset = "0x1E2BF10", VA = "0x181E2CF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct DEIHIELLDCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public DPPCBGEMLDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E23F10", Offset = "0x1E22F10", VA = "0x181E23F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E24150", Offset = "0x1E23150", VA = "0x181E24150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly KAKPMOAJBNM GNOBCAFHIGE;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	public DPPCBGEMLDF(KAKPMOAJBNM JCGJGFHCLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1E244B0", Offset = "0x1E234B0", VA = "0x181E244B0")]
	[AsyncStateMachine(typeof(GKGADCAEMOP))]
	private Task<PGLGENBDGKP<object, AABLFGLHLFL>> EIDJFOIGDIH(EBBJCOBMEJP LNMJHEPMAAO, bool NELCJLCCKDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E246D0", Offset = "0x1E236D0", VA = "0x181E246D0")]
	[AsyncStateMachine(typeof(MHPGCNGBNBJ))]
	public Task<PGLGENBDGKP<bool, AABLFGLHLFL?>>? MIAEIPPHLIK(int HCGEJHPFGOI, DLGKEICEBPG? DCIAEPGAFCJ, GIKJOOGIFPO? KBHELJGAJGN, FKEPIPDGFDA? JEGJKPFGCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E245E0", Offset = "0x1E235E0", VA = "0x181E245E0")]
	[AsyncStateMachine(typeof(DEIHIELLDCI))]
	public Task<PGLGENBDGKP<KLKJPNNICPF, AABLFGLHLFL>> FAAFJENLCBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class IKAFDCLMHHM : JEHKFEEDPOD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly OKHNAPBMEDM GDDIOGKACKH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public OKHNAPBMEDM BPBEGFIBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	private IKAFDCLMHHM(OKHNAPBMEDM AHFDGLHHIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E291D0", Offset = "0x1E281D0", VA = "0x181E291D0")]
	public static IKAFDCLMHHM OMCMMHECHCJ(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E291B0", Offset = "0x1E281B0", VA = "0x181E291B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface KMEAAHIOFHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	EAAJIBJHKIF LHEHEKJGOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	DOAELPIBLPO IOKCNCOOPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	KLCHCBPAEAB ILAOEDMKENP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	BFCBIFHGPGJ CPBLJNPOLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	MENHHHCEIOM ECHIMPCPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface PFLJFFJEMNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	KMEAAHIOFHK? OHBKEIHPKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool OLODGLIPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool FMHKBEEAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KMEAAHIOFHK?>? NIKLLMDELPI();

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NFPOBLEFLLI(DPBBAOGMDLF PDDFEIFGNBJ, DLGKEICEBPG LIMCEFJHMPG, GIKJOOGIFPO? IPFLLEBBINP, FKEPIPDGFDA? PKHNNKJAHBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[LNAPCDCOFGN("IStaticCV2Instance")]
public interface PEIJJNBAPBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	NJMBDGBPJJP NOACFNHCNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[LNAPCDCOFGN("IStaticEVInstance")]
public interface JEHKFEEDPOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	OKHNAPBMEDM BPBEGFIBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class GBNDOEBBIJH : CEHHNBEEEPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NNHGJHJJDGH? AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E272B0", Offset = "0x1E262B0", VA = "0x181E272B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	internal GBNDOEBBIJH(DPBBAOGMDLF PDDFEIFGNBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class BFCBIFHGPGJ : NNHGJHJJDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly PEIJJNBAPBL HFAIKFBMGIH;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MEHMJHPDCMN EIDJFOIGDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E23C50", Offset = "0x1E22C50", VA = "0x181E23C50", Slot = "4")]
		get
		{
			return default(MEHMJHPDCMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FKIOCKHMODD KMPKBBPDIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E23B20", Offset = "0x1E22B20", VA = "0x181E23B20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public HHBFDIMEGNL<IHHFAAHIKGJ> MCDKDOHLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E23BF0", Offset = "0x1E22BF0", VA = "0x181E23BF0", Slot = "6")]
		get
		{
			return default(HHBFDIMEGNL<IHHFAAHIKGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NJMBDGBPJJP DNIBHEEJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E23CB0", Offset = "0x1E22CB0", VA = "0x181E23CB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public BFCBIFHGPGJ(PEIJJNBAPBL CCJDBGGKIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E23B80", Offset = "0x1E22B80", VA = "0x181E23B80")]
	public bool FJCMPOGPDGI([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E23B80", Offset = "0x1E22B80", VA = "0x181E23B80", Slot = "8")]
	private bool NLMGMJLJMKP([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OPOMKILFKKD
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DCD0", Offset = "0x1E2CCD0", VA = "0x181E2DCD0")]
	public static KKILFCDNNAI<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> BJAMNHFPEAK([In] this KKILFCDNNAI<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>> EJKFEOKFAEF)
	{
		return default(KKILFCDNNAI<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF, BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class JKOMNFAKDAF : MKGIEEFHHAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool FMHKBEEAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E29610", Offset = "0x1E28610", VA = "0x181E29610", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	internal JKOMNFAKDAF(DPBBAOGMDLF PDDFEIFGNBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class EFAOPOMACCK : AMNJCBCJPIP
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E24830", Offset = "0x1E23830", VA = "0x181E24830", Slot = "4")]
	public DHLCGILAFHB? GBGLOJIAPOB(string? IAOMDCCFODI, string? OCIMFPJCDCP, string? PLLJKCDMNLL, ACIHMDPKCBA.BCCJEABEAOC.JEFFOPMJBCA MFMDADPACKN, bool BBAFFICFHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public EFAOPOMACCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class NIFOCNJIIGM : MIPGBJJPDOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct LEHMDFEJGGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<HICOKLLNDEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public NIFOCNJIIGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<KMEAAHIOFHK?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E29920", Offset = "0x1E28920", VA = "0x181E29920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E29BD0", Offset = "0x1E28BD0", VA = "0x181E29BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private IReadOnlyList<HHBFDIMEGNL<DBFECPGAJAD>>? PEFDDFIMKCA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public HICOKLLNDEM? AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D1F0", Offset = "0x1E2C1F0", VA = "0x181E2D1F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MENHHHCEIOM? BOCAJADEDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D170", Offset = "0x1E2C170", VA = "0x181E2D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool COMOJCMODHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D270", Offset = "0x1E2C270", VA = "0x181E2D270", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool ELCGKKHGDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DC70", Offset = "0x1E2CC70", VA = "0x181E2DC70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	internal NIFOCNJIIGM(DPBBAOGMDLF PDDFEIFGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D2D0", Offset = "0x1E2C2D0", VA = "0x181E2D2D0", Slot = "7")]
	[AsyncStateMachine(typeof(LEHMDFEJGGD))]
	public Task<HICOKLLNDEM> GCEIDEMIKBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D3C0", Offset = "0x1E2C3C0", VA = "0x181E2D3C0")]
	internal Dictionary<HHBFDIMEGNL<IHHFAAHIKGJ>, Guid> HIBKKIMCKGI(IEnumerable<FFFNEPAFGPP> EKCACDAEHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D7B0", Offset = "0x1E2C7B0", VA = "0x181E2D7B0")]
	public PGLGENBDGKP<OPOHAJJCABD, HHPFBBGIKCL> MAMJPLOKMLL([In] OPOHAJJCABD IDDPHCINLMP, IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC, int GLEOFLGCHFI)
	{
		return default(PGLGENBDGKP<OPOHAJJCABD, HHPFBBGIKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D770", Offset = "0x1E2C770", VA = "0x181E2D770")]
	internal static LPGOIGCDKNA KEEEOLNPDNN(FFNHLDJDDIG PLLKHKFKLED, GNCGFFJFNCO CDMAFKOHEPF)
	{
		return default(LPGOIGCDKNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D730", Offset = "0x1E2C730", VA = "0x181E2D730", Slot = "8")]
	private PGLGENBDGKP<OPOHAJJCABD, HHPFBBGIKCL> IPBMMFBMOLE([In] OPOHAJJCABD IDDPHCINLMP, IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC, int GLEOFLGCHFI)
	{
		return default(PGLGENBDGKP<OPOHAJJCABD, HHPFBBGIKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DA20", Offset = "0x1E2CA20", VA = "0x181E2DA20")]
	[CompilerGenerated]
	internal static LPGOIGCDKNA MGMDMFIEAKO(FFNHLDJDDIG MPMCKMBGFFC, GNCGFFJFNCO BHDDCBKPPIB)
	{
		return default(LPGOIGCDKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class MENHHHCEIOM : HICOKLLNDEM
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class FEBKGBAGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class EMCPCKEPHCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public NJMBDGBPJJP state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public ILGGCCNHAIM spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public EMCPCKEPHCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x1E251F0", Offset = "0x1E241F0", VA = "0x181E251F0")]
			internal bool DJBBOPJLEKB(DEOBEBEJOKO n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class CDMDAOPHADN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public CDMDAOPHADN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x1E23EF0", Offset = "0x1E22EF0", VA = "0x181E23EF0")]
			internal void POMJMLHOACO(DEOBEBEJOKO n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1E25690", Offset = "0x1E24690", VA = "0x181E25690")]
		public static PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL> AOFLBJDIDMG(MENHHHCEIOM HFLBADIEKAM, [In] HICOKLLNDEM.MMEJMOIAIMB JMCMGAGCLNF)
		{
			return default(PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1E26560", Offset = "0x1E25560", VA = "0x181E26560")]
		internal static PGLGENBDGKP<(OJGLDNLAAEK, OLAAPIMJMEA), AABLFGLHLFL> MNOLKEHLPHP(MENHHHCEIOM HFLBADIEKAM, OLAAPIMJMEA AJDEAMPGKLM, bool JOCGPABKMMC, [In] HHBFDIMEGNL<IHHFAAHIKGJ> IKNLCHAGENC, [In] int? LPJAFCKMJIA, [In] LPGOIGCDKNA? ANFIOOLKOMJ, [In] LPGOIGCDKNA? HGPOFIPPDKD)
		{
			return default(PGLGENBDGKP<(OJGLDNLAAEK, OLAAPIMJMEA), AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1E25BD0", Offset = "0x1E24BD0", VA = "0x181E25BD0")]
		private static void CBCFPMFCOGP(bool JOCGPABKMMC, FFFNEPAFGPP DKFEECFJOGP, OJGLDNLAAEK DEONDAFPJIF, [In] HHBFDIMEGNL<IHHFAAHIKGJ> IKNLCHAGENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1E26060", Offset = "0x1E25060", VA = "0x181E26060")]
		public static void HLPFCOKCELH(IBOLECFNBFK NGCNFNPNAFK, [In] HICOKLLNDEM.MLGFDCEJFPP KCHDPFDBELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1E26470", Offset = "0x1E25470", VA = "0x181E26470")]
		[CompilerGenerated]
		internal static bool IAOBJBFANAB(NJMBDGBPJJP BBBMDKMPCCK, ILGGCCNHAIM CIOALGOMKAN, DEOBEBEJOKO NBAIBDPCCKC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly DPBBAOGMDLF JKHHDKKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly PEIJJNBAPBL HFAIKFBMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly JEHKFEEDPOD OPHLBOOJNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly FPFDICIICKG KLEJFIGAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly NIFOCNJIIGM LKKEJDCAOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private Dictionary<HHBFDIMEGNL<GAGHAPPFMGC>, KHIFPKEHEIM> OPLCEIHBGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[CompilerGenerated]
	private Action<HHBFDIMEGNL<GAGHAPPFMGC>>? CJOAMMJJFJI;

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C7C0", Offset = "0x1E2B7C0", VA = "0x181E2C7C0")]
	public MENHHHCEIOM(DPBBAOGMDLF PDDFEIFGNBJ, PEIJJNBAPBL CCJDBGGKIMK, JEHKFEEDPOD HIPNNFIJIIJ, NIFOCNJIIGM DCJICNLNJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AB30", Offset = "0x1E29B30", VA = "0x181E2AB30", Slot = "4")]
	public bool HFAMOFMEHLM(JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<HIDODOLPGGA> BHBMKHOEJBP, JLADLGKIDDG<OFKKFGCILME> DDOKNHIGBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BB50", Offset = "0x1E2AB50", VA = "0x181E2BB50")]
	public KHIFPKEHEIM? KEKMCFAGPBD([In] HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A9F0", Offset = "0x1E299F0", VA = "0x181E2A9F0")]
	private void DMMCDKIAJJH(HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B090", Offset = "0x1E2A090", VA = "0x181E2B090")]
	private KHIFPKEHEIM? HKFEFBKHIMD([In] HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A960", Offset = "0x1E29960", VA = "0x181E2A960")]
	public GNCGFFJFNCO? DJBNNECANPJ([In] HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BAC0", Offset = "0x1E2AAC0", VA = "0x181E2BAC0")]
	public LFMKHJDFIJL? IPBACAKKOMN([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C720", Offset = "0x1E2B720", VA = "0x181E2C720")]
	private ILGGCCNHAIM? OKFNCGJCDOL([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BAC0", Offset = "0x1E2AAC0", VA = "0x181E2BAC0")]
	private LFMKHJDFIJL? MKPCCDGPBFI([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AAA0", Offset = "0x1E29AA0", VA = "0x181E2AAA0")]
	public JLADLGKIDDG<OFKKFGCILME> EOIKCCPGMKB(JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<GAGHAPPFMGC> KBFBOOCDDFE, int JINJJOHPIJH)
	{
		return default(JLADLGKIDDG<OFKKFGCILME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A220", Offset = "0x1E29220", VA = "0x181E2A220")]
	public JLADLGKIDDG<HIDODOLPGGA> BBINGENDPBF(JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<GAGHAPPFMGC> KBFBOOCDDFE, int AOJCNMOAOPE)
	{
		return default(JLADLGKIDDG<HIDODOLPGGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C180", Offset = "0x1E2B180", VA = "0x181E2C180", Slot = "7")]
	public IEnumerable<KHBBJBOFOKB> MMBPMGMCICN(OILGPLGPKDE ILBHOGFGAEF, bool CBFKJEMFDEK, bool IMBGDHDGOMI, bool MNNKKFDEHLL, bool KILNIMGLDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C3D0", Offset = "0x1E2B3D0", VA = "0x181E2C3D0", Slot = "8")]
	public KHBBJBOFOKB OGINCAAAGOL(OILGPLGPKDE ILBHOGFGAEF, DKJNMPPFPAH GCEMMGNANCN, bool CBFKJEMFDEK, bool IMBGDHDGOMI, bool MNNKKFDEHLL, bool KILNIMGLDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AA70", Offset = "0x1E29A70", VA = "0x181E2AA70")]
	public PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL> ECKEFCALGGM([In] HICOKLLNDEM.MMEJMOIAIMB JMCMGAGCLNF)
	{
		return default(PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BD90", Offset = "0x1E2AD90", VA = "0x181E2BD90", Slot = "10")]
	public PGLGENBDGKP<JMLJCCKEGNB, HHPFBBGIKCL> LKNICKMBCPC(HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP, JMLJCCKEGNB FJGEGPNAKEN, NKJKDNJNIDM MAEFMJFMBDA)
	{
		return default(PGLGENBDGKP<JMLJCCKEGNB, HHPFBBGIKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A030", Offset = "0x1E29030", VA = "0x181E2A030", Slot = "11")]
	public EGOBOJFOGIG AEKCNIEMAKA(IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC)
	{
		return default(EGOBOJFOGIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A2B0", Offset = "0x1E292B0", VA = "0x181E2A2B0", Slot = "12")]
	public EGOBOJFOGIG BJCMLODDAPG()
	{
		return default(EGOBOJFOGIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B890", Offset = "0x1E2A890", VA = "0x181E2B890")]
	private FINCOKAPMDA IEONKKAMDBP(BOAMIBDKJJG BMLENLJGPGF, JLADLGKIDDG<IHHFAAHIKGJ> BNDGLCNMHGB, IEnumerable<HHBFDIMEGNL<IHHFAAHIKGJ>> DBFMICHJKCB, IEnumerable<HHBFDIMEGNL<GAGHAPPFMGC>> OPFKPFPOGFM)
	{
		return default(FINCOKAPMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B550", Offset = "0x1E2A550", VA = "0x181E2B550", Slot = "13")]
	public FINCOKAPMDA IEONKKAMDBP(BOAMIBDKJJG BMLENLJGPGF, JLADLGKIDDG<IHHFAAHIKGJ> BNDGLCNMHGB, IEnumerable<HHBFDIMEGNL<GAGHAPPFMGC>> OPFKPFPOGFM, IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC)
	{
		return default(FINCOKAPMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B1D0", Offset = "0x1E2A1D0", VA = "0x181E2B1D0")]
	private static IEnumerable<HHBFDIMEGNL<IHHFAAHIKGJ>> HMJIAPJOMAJ(IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A440", Offset = "0x1E29440", VA = "0x181E2A440")]
	private IEnumerable<HHBFDIMEGNL<GAGHAPPFMGC>> DAIGJOKJMFH(IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B140", Offset = "0x1E2A140", VA = "0x181E2B140", Slot = "14")]
	public List<GLLNGOIIPLF> HLNDDFNKIJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BCC0", Offset = "0x1E2ACC0", VA = "0x181E2BCC0", Slot = "15")]
	public bool KFLIENLHFFK(JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BAF0", Offset = "0x1E2AAF0", VA = "0x181E2BAF0")]
	internal void KDGHIBAFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C6C0", Offset = "0x1E2B6C0", VA = "0x181E2C6C0")]
	internal Task OHPMPFPPFBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BAC0", Offset = "0x1E2AAC0", VA = "0x181E2BAC0", Slot = "5")]
	private LFMKHJDFIJL KOCFALMCEIN([In] HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C280", Offset = "0x1E2B280", VA = "0x181E2C280", Slot = "6")]
	private KHIFPKEHEIM NLGDIKAGHMJ([In] HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AA70", Offset = "0x1E29A70", VA = "0x181E2AA70", Slot = "9")]
	private PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL> LEJMCGEPJLH([In] HICOKLLNDEM.MMEJMOIAIMB JMCMGAGCLNF)
	{
		return default(PGLGENBDGKP<HICOKLLNDEM.DPPBAGGMPFP, HHPFBBGIKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BA40", Offset = "0x1E2AA40", VA = "0x181E2BA40")]
	[CompilerGenerated]
	private EOKDGIKPIKD ILJGPALDGND(LOOPDHANNBN AFFJDCKHCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A3D0", Offset = "0x1E293D0", VA = "0x181E2A3D0")]
	[CompilerGenerated]
	private GNCGFFJFNCO CKBHMHCNAIF(HHBFDIMEGNL<GAGHAPPFMGC> AFFJDCKHCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A8F0", Offset = "0x1E298F0", VA = "0x181E2A8F0")]
	[CompilerGenerated]
	private ILGGCCNHAIM DHMFJIKPMPH(HHBFDIMEGNL<IHHFAAHIKGJ> AFFJDCKHCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class EOKDGIKPIKD : KHBBJBOFOKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct KBHCMCJKOJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<JLADLGKIDDG<HMCEGANNKMN>, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public EOKDGIKPIKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public HHBFDIMEGNL<IHHFAAHIKGJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public HHBFDIMEGNL<GAGHAPPFMGC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public JLADLGKIDDG<EOKIOPDIOPK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<PGLGENBDGKP<JLADLGKIDDG<HMCEGANNKMN>, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1E29630", Offset = "0x1E28630", VA = "0x181E29630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1E298B0", Offset = "0x1E288B0", VA = "0x181E298B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct DGPDBOPBGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<JLADLGKIDDG<MLIECAGLJCM>, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public EOKDGIKPIKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public HHBFDIMEGNL<IHHFAAHIKGJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public HHBFDIMEGNL<GAGHAPPFMGC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public JLADLGKIDDG<EOKIOPDIOPK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<PGLGENBDGKP<JLADLGKIDDG<MLIECAGLJCM>, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1E241C0", Offset = "0x1E231C0", VA = "0x181E241C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1E24440", Offset = "0x1E23440", VA = "0x181E24440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly LOOPDHANNBN FCHIIEHEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly PEIJJNBAPBL HFAIKFBMGIH;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TypeKey LKCAIOPCDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string BMIDBFNPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1E252E0", Offset = "0x1E242E0", VA = "0x181E252E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public LOOPDHANNBN GFEHJEPJCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1E255F0", Offset = "0x1E245F0", VA = "0x181E255F0")]
	public EOKDGIKPIKD(LOOPDHANNBN KHIMCMFIHID, PEIJJNBAPBL CCJDBGGKIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1E25480", Offset = "0x1E24480", VA = "0x181E25480", Slot = "6")]
	[AsyncStateMachine(typeof(KBHCMCJKOJP))]
	public Task<PGLGENBDGKP<JLADLGKIDDG<HMCEGANNKMN>, AABLFGLHLFL>> NIHNBLBLBJI(HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP, HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, string ONGJKHHOIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1E25310", Offset = "0x1E24310", VA = "0x181E25310", Slot = "7")]
	[AsyncStateMachine(typeof(DGPDBOPBGKA))]
	public Task<PGLGENBDGKP<JLADLGKIDDG<MLIECAGLJCM>, AABLFGLHLFL>> NHBKAKILJKA(HHBFDIMEGNL<IHHFAAHIKGJ> ABBEJOMODMP, HHBFDIMEGNL<GAGHAPPFMGC> KBFBOOCDDFE, JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH, string ONGJKHHOIAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class IFHDEDHFEFB : BEHBGKLLBPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly LOOPDHANNBN BIHKANIIDAB;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly HashSet<LOOPDHANNBN> GHHNHFBGDIE;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly HashSet<LOOPDHANNBN> GFOKMPAKJMM;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly HashSet<LOOPDHANNBN> FENEKOKEKFL;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public TypeKey KFDLNEFCHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1E29040", Offset = "0x1E28040", VA = "0x181E29040", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NIDLLBLAPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1E29030", Offset = "0x1E28030", VA = "0x181E29030", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool DFFOALFHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1E29090", Offset = "0x1E28090", VA = "0x181E29090", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CHPGDFHLDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E28FB0", Offset = "0x1E27FB0", VA = "0x181E28FB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1E27C50", Offset = "0x1E26C50", VA = "0x181E27C50")]
	public bool PGLMBNMCCJO(string LDGMLLMKHLF, [Out] DJLNPIFDHDB DJFMFJLAGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public IFHDEDHFEFB(LOOPDHANNBN OFFMGNOKEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1E27AC0", Offset = "0x1E26AC0", VA = "0x181E27AC0")]
	internal static TypeKey AGPFHBBNFFB(LOOPDHANNBN KBCNAJKPHNL)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1E252E0", Offset = "0x1E242E0", VA = "0x181E252E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct POEIIGCCNHB : PANFIKCELOA.JFENMMDKPJE<EBBJCOBMEJP, KLKJPNNICPF>
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E290", Offset = "0x1E2D290", VA = "0x181E2E290", Slot = "4")]
	public int NLCKFPIPCLN(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E180", Offset = "0x1E2D180", VA = "0x181E2E180", Slot = "5")]
	public EBBJCOBMEJP AFPEKIHPFIA(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E240", Offset = "0x1E2D240", VA = "0x181E2E240", Slot = "6")]
	public EBBJCOBMEJP LIKIDGPCLFH(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E2B0", Offset = "0x1E2D2B0", VA = "0x181E2E2B0", Slot = "7")]
	public IReadOnlyList<EBBJCOBMEJP> NOCLOJCOFJK(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E1B0", Offset = "0x1E2D1B0", VA = "0x181E2E1B0", Slot = "8")]
	public EBBJCOBMEJP[] DPNHIBJMLDP(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO, int JHEAFPECNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E270", Offset = "0x1E2D270", VA = "0x181E2E270", Slot = "9")]
	public bool MGKNJMOOMDI(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E1C0", Offset = "0x1E2D1C0", VA = "0x181E2E1C0", Slot = "10")]
	public bool EOFLJGNLOFA(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E1E0", Offset = "0x1E2D1E0", VA = "0x181E2E1E0", Slot = "11")]
	public bool JLDHKFMNEAE(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E190", Offset = "0x1E2D190", VA = "0x181E2E190", Slot = "12")]
	public bool CNIHGDEOGJB(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E220", Offset = "0x1E2D220", VA = "0x181E2E220", Slot = "13")]
	public bool KGLCIFHGHOJ(KLKJPNNICPF EICMBJAKFOM, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1E2E200", Offset = "0x1E2D200", VA = "0x181E2E200", Slot = "14")]
	public bool JNLIILBEGLG(KLKJPNNICPF GEJMEMCGHEN, EBBJCOBMEJP LNMJHEPMAAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class GFPDOICCFOH : FCDICOJFHNB
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CBPDHBMHLOH.GBHCNMPCKAN DIONAGGCJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1E273C0", Offset = "0x1E263C0", VA = "0x181E273C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public abstract ODKJBDAKIBF.KNGMNLKMDEI GELJNMNLJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract DPBBAOGMDLF.LONBFHAKFGC GEKKIFMFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract PLCJGBINHPC.MEHHNNNPIMK IINMNCIJDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public BFNHHGDMKBD.MBIBLJLDHEM<JMJNNGFFIBF, EBBJCOBMEJP, DPBBAOGMDLF> CKKDKIPAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1E27410", Offset = "0x1E26410", VA = "0x181E27410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public abstract AFGAGCCGDDM FMGBJODPJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract LEKKIHPEAHD DJJGAIGKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public abstract NEBOEELLFPE IEHGPNILMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract IBHMFLAKBFA HFEEJLGMLIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract JJNFBOIBPCL FMMMDABHBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected GFPDOICCFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class ILFGCGHMDAE : FKIOCKHMODD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct GOAEAPCECAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public ILFGCGHMDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public EBBJCOBMEJP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1E27730", Offset = "0x1E26730", VA = "0x181E27730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1E27940", Offset = "0x1E26940", VA = "0x181E27940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct MBFNFAJMAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<JMGAFOPOMNL, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public ILFGCGHMDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public IReadOnlyList<EBBJCOBMEJP> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1E29C40", Offset = "0x1E28C40", VA = "0x181E29C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1E29FC0", Offset = "0x1E28FC0", VA = "0x181E29FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly KAKPMOAJBNM GNOBCAFHIGE;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public ILFGCGHMDAE(KAKPMOAJBNM JCGJGFHCLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1E294E0", Offset = "0x1E284E0", VA = "0x181E294E0")]
	[AsyncStateMachine(typeof(GOAEAPCECAG))]
	private Task<PGLGENBDGKP<object, AABLFGLHLFL>> EIDJFOIGDIH(EBBJCOBMEJP LNMJHEPMAAO, bool NELCJLCCKDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1E293B0", Offset = "0x1E283B0", VA = "0x181E293B0", Slot = "4")]
	[AsyncStateMachine(typeof(MBFNFAJMAAH))]
	public Task<PGLGENBDGKP<JMGAFOPOMNL, AABLFGLHLFL>> DAEAKMPHOAF(IReadOnlyList<EBBJCOBMEJP> IBDAFFKKFFB, bool NELCJLCCKDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct AFHILGCNAJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal APNIJPPCFEG<FMIOHPMBIAH, EBBJCOBMEJP, MPECMBOGHIF> BIHKANIIDAB;

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1E14D30", Offset = "0x1E13D30", VA = "0x181E14D30")]
	private AFHILGCNAJJ([In] APNIJPPCFEG<FMIOHPMBIAH, EBBJCOBMEJP, MPECMBOGHIF> COBKCMFJOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1E23AC0", Offset = "0x1E22AC0", VA = "0x181E23AC0")]
	public static AFHILGCNAJJ MGIIAIMPALM()
	{
		return default(AFHILGCNAJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class POMKFNHJFNI
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static APNIJPPCFEG<FMIOHPMBIAH, EBBJCOBMEJP, MPECMBOGHIF> NPLGHKKEOOE(this AFHILGCNAJJ HFLBADIEKAM)
	{
		return default(APNIJPPCFEG<FMIOHPMBIAH, EBBJCOBMEJP, MPECMBOGHIF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct MPECMBOGHIF : CDBEEEPBPDM.PDCEGMLCCAE<FMIOHPMBIAH, EBBJCOBMEJP>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2CF80", Offset = "0x1E2BF80", VA = "0x181E2CF80", Slot = "5")]
	public EBBJCOBMEJP KHCDGNEHBGC(FMIOHPMBIAH[] JIGCHIFJPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430")]
	public int EMGDPNFMMIF([In] FMIOHPMBIAH MIKACEEKFPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430", Slot = "4")]
	private int EOFKKHEALOO([In] FMIOHPMBIAH HBFCNHNFFJK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct GKLKJPMAKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal LHEEGJKKNFO<GJMPDLGOBCL, EBBJCOBMEJP, BIKHIJBJEHE> BIHKANIIDAB;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1E14D30", Offset = "0x1E13D30", VA = "0x181E14D30")]
	private GKLKJPMAKCN([In] LHEEGJKKNFO<GJMPDLGOBCL, EBBJCOBMEJP, BIKHIJBJEHE> OKOPCJAAKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1E276D0", Offset = "0x1E266D0", VA = "0x181E276D0")]
	public static GKLKJPMAKCN MGIIAIMPALM()
	{
		return default(GKLKJPMAKCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class KKNKOFKBDDD
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static LHEEGJKKNFO<GJMPDLGOBCL, EBBJCOBMEJP, BIKHIJBJEHE> NPLGHKKEOOE(this GKLKJPMAKCN HFLBADIEKAM)
	{
		return default(LHEEGJKKNFO<GJMPDLGOBCL, EBBJCOBMEJP, BIKHIJBJEHE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct BIKHIJBJEHE : GGLGLEILEOB.DDHPGJCGFAM<GJMPDLGOBCL, EBBJCOBMEJP>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430")]
	public int MCDGFKPIOGK([In] GJMPDLGOBCL MIKACEEKFPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1E23D00", Offset = "0x1E22D00", VA = "0x181E23D00", Slot = "5")]
	public EBBJCOBMEJP ONKDELKGFKO(GJMPDLGOBCL[] PBFOFJKBGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430", Slot = "4")]
	private int HMPFMDIOFAK([In] GJMPDLGOBCL MIKACEEKFPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface AFGAGCCGDDM
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFGFLMHOHPA([In] PGLGENBDGKP<KLKJPNNICPF, HHPFBBGIKCL> NIKEINPNLMA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class CNICPKJIFJC
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x271E610", Offset = "0x271D610", VA = "0x18271E610")]
	public static bool DFGFLMHOHPA<TOk, TErr>(this AFGAGCCGDDM HFLBADIEKAM, [In] PGLGENBDGKP<TOk, TErr> NIKEINPNLMA) where TOk : notnull where TErr : notnull, HHPFBBGIKCL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface LEKKIHPEAHD
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	HOENGLGODMK EOCKLBNGDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface NEBOEELLFPE
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLMNMOFHOAB PKGKJAAPADG(int MPFOJLHCAPN);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface POJEMABNNMM
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface CAPPJGBGPAL
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGPGDHFPCLI? MDDPOLBONCK(JLADLGKIDDG<EOKIOPDIOPK> PBBOBEFNHFH);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface PJEHMDOOFFF
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface GGPGDHFPCLI
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PJEHMDOOFFF? GMAMCFKMOHA(JLADLGKIDDG<HMCEGANNKMN> FJPFMOOAPCI);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "2")]
	POJEMABNNMM? GNPFGPKBCPP(JLADLGKIDDG<MLIECAGLJCM> LJKOBCKPHJI);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface IBHMFLAKBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JDMFNMNOIBP(string LDGMLLMKHLF, string DFKOHNJAKHM);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface JJNFBOIBPCL
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAPPJGBGPAL? KBBFHGMPPNJ([In] HHBFDIMEGNL<DBFECPGAJAD> CBEJLONPLNO);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class EFBFCOMNINM
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct GPAHGBBGNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int CBOGBOOIKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public GIKJOOGIFPO? CBADOLPOFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public GIKJOOGIFPO? OAMJOFFFAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public readonly List<EBBJCOBMEJP> PDMABHEOFCI;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1E27A70", Offset = "0x1E26A70", VA = "0x181E27A70")]
		private GPAHGBBGNJL(int GPEHCABDGEJ, GIKJOOGIFPO? JNNFKAJLFGP, GIKJOOGIFPO? HBBGCNMLCPC, List<EBBJCOBMEJP> IBDAFFKKFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1E279B0", Offset = "0x1E269B0", VA = "0x181E279B0")]
		public static GPAHGBBGNJL MGIIAIMPALM()
		{
			return default(GPAHGBBGNJL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly ABOPGOPGKMN<GPAHGBBGNJL> CAIFHGMFMEF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public static EFBFCOMNINM AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1E248D0", Offset = "0x1E238D0", VA = "0x181E248D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool EOKKFBJKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x813060", Offset = "0x812060", VA = "0x180813060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86B840", Offset = "0x86A840", VA = "0x18086B840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x1E24C80", Offset = "0x1E23C80", VA = "0x181E24C80")]
	public void NCDOBJLHEJK(NJMBDGBPJJP HBBGCNMLCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1E24D40", Offset = "0x1E23D40", VA = "0x181E24D40")]
	public void PJFGEODKOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1E24920", Offset = "0x1E23920", VA = "0x181E24920")]
	private static string? LEIHPHKKAHB([In] GPAHGBBGNJL EJDCBCOKPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1E25140", Offset = "0x1E24140", VA = "0x181E25140")]
	public EFBFCOMNINM()
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
