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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DD7620", Offset = "0x1DD6220", VA = "0x181DD7620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NKBDFFBLNPL : IDisposable, CJJJFENELIO, MGFFCHCONNI, JEHFLJLFBGC, NPBILKAIIEA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class CKFHBCKGFMB : JGAACLOFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int GEKDBMHJAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2D50", Offset = "0x1DC1950", VA = "0x181DC2D50", Slot = "5")]
		public OPKFIBMLNHA JJLNPGMHDHE(OJFGCHFAGDN.KMEKLOAJFJB BNNGNHILECN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void OOPDLDGODEG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LGAAABONCFK();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2EA0", Offset = "0x1DC1AA0", VA = "0x181DC2EA0", Slot = "13")]
		public virtual void OFCCNMDFKDM(NKBDFFBLNPL KKJDCIPMCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2CD0", Offset = "0x1DC18D0", VA = "0x181DC2CD0", Slot = "14")]
		public virtual void EBHJCHJCOIL(NKBDFFBLNPL KKJDCIPMCCK, IDOLLADEHJJ ODKDNEPMNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected CKFHBCKGFMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JGAACLOFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int GEKDBMHJAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OPKFIBMLNHA JJLNPGMHDHE(OJFGCHFAGDN.KMEKLOAJFJB BNNGNHILECN);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OOPDLDGODEG();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LGAAABONCFK();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OFCCNMDFKDM(NKBDFFBLNPL KKJDCIPMCCK);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EBHJCHJCOIL(NKBDFFBLNPL KKJDCIPMCCK, IDOLLADEHJJ ODKDNEPMNIA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NALLGABBPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OMHOEMCOFLL<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> GBBJIHOCAIH;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF8F0", Offset = "0x1DCE4F0", VA = "0x181DCF8F0")]
		internal NALLGABBPHG(OMHOEMCOFLL<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> GAFLMOIGPJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class POHFJMBNACD : KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly POHFJMBNACD EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private POHFJMBNACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xADA720", Offset = "0xAD9320", VA = "0x180ADA720", Slot = "4")]
		public CDHFMAMOJHN JKBDJEGAMNJ(IDOLLADEHJJ NOLNJDLEMAA)
		{
			return default(CDHFMAMOJHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9990", Offset = "0x1DD8590", VA = "0x181DD9990", Slot = "5")]
		public void OFCCNMDFKDM(NKBDFFBLNPL EBCHPMPLBLG, IDOLLADEHJJ ODKDNEPMNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9880", Offset = "0x1DD8480", VA = "0x181DD9880", Slot = "6")]
		public void EBHJCHJCOIL(NKBDFFBLNPL EBCHPMPLBLG, IDOLLADEHJJ ODKDNEPMNIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IFCBJDLJBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OOGNGCJKBIK<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> GBBJIHOCAIH;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DC95A0", Offset = "0x1DC81A0", VA = "0x181DC95A0")]
		internal IFCBJDLJBHA(OOGNGCJKBIK<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9550", Offset = "0x1DC8150", VA = "0x181DC9550")]
		public static IFCBJDLJBHA CIGBOGDFGOD()
		{
			return default(IFCBJDLJBHA);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct IOACIJEABGA : BHNIIDLKBFO.DEBNHMBIKMA<IDOLLADEHJJ, NKBDFFBLNPL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct HKBILJIEGHO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NKBDFFBLNPL receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IDOLLADEHJJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IOACIJEABGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7D40", Offset = "0x1DC6940", VA = "0x181DC7D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7F20", Offset = "0x1DC6B20", VA = "0x181DC7F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xABF820", Offset = "0xABE420", VA = "0x180ABF820", Slot = "4")]
		public FEAGCKDELFK<HHCCPIMKDMJ> OFIPPLPFHFP(NKBDFFBLNPL IPJAHGCJIBA)
		{
			return default(FEAGCKDELFK<HHCCPIMKDMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9B70", Offset = "0x1DC8770", VA = "0x181DC9B70", Slot = "5")]
		[AsyncStateMachine(typeof(HKBILJIEGHO))]
		public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> BPHEMFKFDPH(NKBDFFBLNPL IPJAHGCJIBA, IDOLLADEHJJ ODKDNEPMNIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9CA0", Offset = "0x1DC88A0", VA = "0x181DC9CA0", Slot = "6")]
		public IDOLLADEHJJ[] KHPJFFDDEFK(NKBDFFBLNPL IPJAHGCJIBA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DDBAHDCMLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NKBDFFBLNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GLEDFAMGOCH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JCLGJDHLEKN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MHLNEPCFHJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC34F0", Offset = "0x1DC20F0", VA = "0x181DC34F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3770", Offset = "0x1DC2370", VA = "0x181DC3770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BLHFPFLNBMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NKBDFFBLNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC25C0", Offset = "0x1DC11C0", VA = "0x181DC25C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2850", Offset = "0x1DC1450", VA = "0x181DC2850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PHOEKCJICKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public NKBDFFBLNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9390", Offset = "0x1DD7F90", VA = "0x181DD9390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9570", Offset = "0x1DD8170", VA = "0x181DD9570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FLMGMGCLMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NKBDFFBLNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IDOLLADEHJJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5140", Offset = "0x1DC3D40", VA = "0x181DC5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5330", Offset = "0x1DC3F30", VA = "0x181DC5330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JGKDOJANMII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NKBDFFBLNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA8F0", Offset = "0x1DC94F0", VA = "0x181DCA8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB0E0", Offset = "0x1DC9CE0", VA = "0x181DCB0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FEAGCKDELFK<HHCCPIMKDMJ> PFLKOOBDFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NALLGABBPHG DDDAGPFJBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GPLPCAHMIDA EJHBIEDPGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GCMJHPCHEDJ HHFNCDOKJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IKMOPJOGEJD IMJHKFOBOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly IEJIDNBBAFF.AFNIIAAJFHC POCICLONJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly ODOMJLHLIIF POEKNIDDIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10F0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly CKKIKPDCJPN ECIDAGCFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10F8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PIINIKJDBEM FGAKMOLNDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1100")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly DMAOIAPJHCJ MHAHEBBHLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1108")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly LOKFKCJPKKF BHLHKFNHEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1110")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GGLMPHIFHAP BJFDODCBLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1120")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HEOJELFLAGM MEEFIBGAJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1140")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GPLPCAHMIDA.KDFGOOKJOLC DJOCHPCHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1148")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly CLPANGMNOAK ACAAGPIDMGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GPLPCAHMIDA EBCGPHOJKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0520", Offset = "0x1DCF120", VA = "0x181DD0520")]
		get
		{
			return default(GPLPCAHMIDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JGAACLOFCJA HDJICILHONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DD04D0", Offset = "0x1DCF0D0", VA = "0x181DD04D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OPKFIBMLNHA FHLBOHFPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DD00B0", Offset = "0x1DCECB0", VA = "0x181DD00B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DD07C0", Offset = "0x1DCF3C0", VA = "0x181DD07C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HLCBICCMHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0E90", Offset = "0x1DCFA90", VA = "0x181DD0E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD07B0", Offset = "0x1DCF3B0", VA = "0x181DD07B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OPAJNBCANPF JEMIGLAIBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1500", Offset = "0x1DD0100", VA = "0x181DD1500", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NMLJOIAJPDC JELMNGCCBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1520", Offset = "0x1DD0120", VA = "0x181DD1520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HPBKEHNGBMD KBIPLDMFFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1540", Offset = "0x1DD0140", VA = "0x181DD1540", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EBAEGIIBGHC KKPNLPNOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1510", Offset = "0x1DD0110", VA = "0x181DD1510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HJDJALDMILB JHJJCJHCLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1530", Offset = "0x1DD0130", VA = "0x181DD1530", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PMGBIHIMAAN? JJCLEFGNDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0F90", Offset = "0x1DCFB90", VA = "0x181DD0F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private DNHALMKOBJA? MPBCGIKKIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD03A0", Offset = "0x1DCEFA0", VA = "0x181DD03A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD11B0", Offset = "0x1DCFDB0", VA = "0x181DD11B0")]
	private NKBDFFBLNPL(IKMOPJOGEJD CHJILIBAEBO, FEAGCKDELFK<HHCCPIMKDMJ> FHDOEPMHPEB, [In] NALLGABBPHG FCBMPELPDBD, [In] GPLPCAHMIDA DGMNKJNOCMF, [In] GCMJHPCHEDJ IAPOGJILLPH, OPKFIBMLNHA DMIFDBFMGIK, [In] IEJIDNBBAFF.AFNIIAAJFHC PKNBNMPGDIK, GPLPCAHMIDA.KDFGOOKJOLC KELIMIDPNBI, CLPANGMNOAK EODGHDEPJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFBF0", Offset = "0x1DCE7F0", VA = "0x181DCFBF0")]
	public static NKBDFFBLNPL CIGBOGDFGOD(IKMOPJOGEJD BNNGNHILECN, GPLPCAHMIDA.AFMGKNKEENC GLJCBJGAOHD, FEAGCKDELFK<HHCCPIMKDMJ> FHDOEPMHPEB, FEAGCKDELFK<MAELMOHBIJC> JLFJENONKMH, PDPCABEHLNM LPACIFPMABD, KGBAHCECBEG KOHGMGMPOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFDD0", Offset = "0x1DCE9D0", VA = "0x181DCFDD0")]
	public static NKBDFFBLNPL CIGBOGDFGOD(IKMOPJOGEJD CHJILIBAEBO, [In] GPLPCAHMIDA DGMNKJNOCMF, [In] GCMJHPCHEDJ IAPOGJILLPH, FEAGCKDELFK<HHCCPIMKDMJ> FHDOEPMHPEB, FEAGCKDELFK<MAELMOHBIJC> JLFJENONKMH, PDPCABEHLNM LPACIFPMABD, KGBAHCECBEG KOHGMGMPOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD00C0", Offset = "0x1DCECC0", VA = "0x181DD00C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0650", Offset = "0x1DCF250", VA = "0x181DD0650")]
	[AsyncStateMachine(typeof(DDBAHDCMLLF))]
	internal Task<DGKNLHNBBJB<bool, BNLEFJJKIPP>> HCGAGOMCIJL(GLEDFAMGOCH GFAFHNOFNDA, JCLGJDHLEKN HCLALOIEKIC, MHLNEPCFHJN DNCEPNILLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0EA0", Offset = "0x1DCFAA0", VA = "0x181DD0EA0")]
	[AsyncStateMachine(typeof(BLHFPFLNBMN))]
	public Task<DGKNLHNBBJB<bool, BNLEFJJKIPP>> MCILPIAPFCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DD10C0", Offset = "0x1DCFCC0", VA = "0x181DD10C0")]
	[AsyncStateMachine(typeof(PHOEKCJICKO))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> OKHPMIHGKMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0B70", Offset = "0x1DCF770", VA = "0x181DD0B70")]
	internal void KIPAPEAIKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFB70", Offset = "0x1DCE770", VA = "0x181DCFB70")]
	internal FJLODHFCFCH<IDOLLADEHJJ> BKNILOCFCCA([In] AHOGAMGDHFP HAEKACBEIKD)
	{
		return default(FJLODHFCFCH<IDOLLADEHJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DD02B0", Offset = "0x1DCEEB0", VA = "0x181DD02B0")]
	internal bool EEINDCFLOKI([In] AHOGAMGDHFP HAEKACBEIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0320", Offset = "0x1DCEF20", VA = "0x181DD0320")]
	internal FJLODHFCFCH<IDOLLADEHJJ> EGNMFHBLEML([In] MMAKMDPBBPC HHAMKPDJLJO)
	{
		return default(FJLODHFCFCH<IDOLLADEHJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0D80", Offset = "0x1DCF980", VA = "0x181DD0D80")]
	[AsyncStateMachine(typeof(FLMGMGCLMLF))]
	internal Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> LFEEFJAJHFO(IDOLLADEHJJ ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DD07E0", Offset = "0x1DCF3E0", VA = "0x181DD07E0")]
	private IDOLLADEHJJ[] KHPJFFDDEFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0530", Offset = "0x1DCF130", VA = "0x181DD0530")]
	[AsyncStateMachine(typeof(JGKDOJANMII))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> GLPNKJHHEPI(Guid PLJHHGIJDPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LIEFFOMINKH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2874B20", Offset = "0x2873720", VA = "0x182874B20")]
	public static LBGHNMHBJDF<(TPrev?, NKBDFFBLNPL?), DNHALMKOBJA> HMPGNPMJOFP<TPrev>([In] this LBGHNMHBJDF<TPrev, NKBDFFBLNPL> NOLNJDLEMAA)
	{
		return default(LBGHNMHBJDF<(TPrev, NKBDFFBLNPL), DNHALMKOBJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2874900", Offset = "0x2873500", VA = "0x182874900")]
	public static LBGHNMHBJDF<TPrev?, NKBDFFBLNPL?> APMAGLCHBFP<TPrev>([In] this LBGHNMHBJDF<TPrev, NKBDFFBLNPL> NOLNJDLEMAA)
	{
		return default(LBGHNMHBJDF<TPrev, NKBDFFBLNPL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DGBDALHJPAL<TData> : PHFFNBEEJOM, OCDAFDGDKDH, JIEDJHBPKDD where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KCDCADLPKIO<BABPFGLJKHJ>? ADLEHCCBMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string NAFGJKMOKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData EIIIJBECKHI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public KCDCADLPKIO<BABPFGLJKHJ>? DIBMIEOCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F1A0", Offset = "0x1F8DDA0", VA = "0x181F8F1A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50", Slot = "7")]
	public override string HJJFPLKFILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5041D50", Offset = "0x5040950", VA = "0x185041D50")]
	internal DGBDALHJPAL([In] KCDCADLPKIO<BABPFGLJKHJ>? NGENNFEBCJA, FEAGCKDELFK<HHCMNLLLPME>? OGBNGNFDGNO, IOKind? IFINKPONKEM, string COECLHOAJJF, [In] TData KOMCCCIEHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LHLMHAIIDFG
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDA80", Offset = "0x1DCC680", VA = "0x181DCDA80")]
	public static DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH> KGBHPGOAAEK([In] this LHKGKOHNOAJ<JGPPCDNFEAG> FPOLDCOOKCG)
	{
		return default(DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28736B0", Offset = "0x28722B0", VA = "0x1828736B0")]
	public static DGKNLHNBBJB<TOk, OCDAFDGDKDH> EFHNPGBPDDA<TOk>([In] this DGKNLHNBBJB<TOk, OCDAFDGDKDH> NOLNJDLEMAA, [In] KCDCADLPKIO<BABPFGLJKHJ>? NGENNFEBCJA, FEAGCKDELFK<HHCMNLLLPME>? OGBNGNFDGNO, IOKind? IFINKPONKEM, string COECLHOAJJF) where TOk : notnull
	{
		return default(DGKNLHNBBJB<TOk, OCDAFDGDKDH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IKMOPJOGEJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OLLGDFOFBDL.JKMHFOLOLGE EKJHGPFCOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OJFGCHFAGDN.KMEKLOAJFJB OGENNMAOPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NKBDFFBLNPL.JGAACLOFCJA ODBMJDJMNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DIJPCCIGCJH.FBLLADKFBBB JKINHFMDHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL> HLELLEPCEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HAOANKFPNCO DPNNKJDLNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LDJPKEOMMBK CMPIAJDOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ICPKAGCHLKD AAEFAIDAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MBGGHHIOJJN MPEFEONNGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	EDOKNHNMOPM CMGIILACMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KJGMEBEEGHP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD230", Offset = "0x1DCBE30", VA = "0x181DCD230")]
	public static IDOLLADEHJJ LDCPMIAELMI(this IDOLLADEHJJ NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD160", Offset = "0x1DCBD60", VA = "0x181DCD160")]
	public static IDOLLADEHJJ CAFAIPELAJP(this MOANLIFDEFK NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MOANLIFDEFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JOIHAODBGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NKBDFFBLNPL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public MOANLIFDEFK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBB80", Offset = "0x1DCA780", VA = "0x181DCBB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBE40", Offset = "0x1DCAA40", VA = "0x181DCBE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString BLAEOCKJGCA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	private MOANLIFDEFK(ByteString BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF710", Offset = "0x1DCE310", VA = "0x181DCF710")]
	public static IDOLLADEHJJ MALBLLNDBHJ(ByteString BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF550", Offset = "0x1DCE150", VA = "0x181DCF550")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, MOANLIFDEFK> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, MOANLIFDEFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF600", Offset = "0x1DCE200", VA = "0x181DCF600")]
	[AsyncStateMachine(typeof(JOIHAODBGMH))]
	public static Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> LFEEFJAJHFO(NKBDFFBLNPL EBCHPMPLBLG, MOANLIFDEFK NOLNJDLEMAA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GJLKPPOOKNE
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6800", Offset = "0x1DC5400", VA = "0x181DC6800")]
	public static IDOLLADEHJJ MALBLLNDBHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6790", Offset = "0x1DC5390", VA = "0x181DC6790")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, GJLKPPOOKNE> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, GJLKPPOOKNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6710", Offset = "0x1DC5310", VA = "0x181DC6710")]
	public static DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB> ECDNJKDACHL(NKBDFFBLNPL EBCHPMPLBLG, [In] GJLKPPOOKNE NOLNJDLEMAA)
	{
		return default(DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct OIBCLEDBAFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GOJKDNJELGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NKBDFFBLNPL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OIBCLEDBAFH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6F50", Offset = "0x1DC5B50", VA = "0x181DC6F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1DC72C0", Offset = "0x1DC5EC0", VA = "0x181DC72C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly GLEDFAMGOCH? DHLMDFEKFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly JCLGJDHLEKN? HFDNGOELMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly MHLNEPCFHJN? HIPGKJKFGMK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AFD0", Offset = "0x1B29BD0", VA = "0x181B2AFD0")]
	private OIBCLEDBAFH(GLEDFAMGOCH? GFAFHNOFNDA, JCLGJDHLEKN? HCLALOIEKIC, MHLNEPCFHJN? DNCEPNILLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7D20", Offset = "0x1DD6920", VA = "0x181DD7D20")]
	public static IDOLLADEHJJ? MALBLLNDBHJ(GLEDFAMGOCH? GFAFHNOFNDA, JCLGJDHLEKN? HCLALOIEKIC, MHLNEPCFHJN? DNCEPNILLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7AD0", Offset = "0x1DD66D0", VA = "0x181DD7AD0")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, OIBCLEDBAFH> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, OIBCLEDBAFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7BE0", Offset = "0x1DD67E0", VA = "0x181DD7BE0")]
	[AsyncStateMachine(typeof(GOJKDNJELGD))]
	public static Task<DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB>> LFEEFJAJHFO(NKBDFFBLNPL EBCHPMPLBLG, OIBCLEDBAFH NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PLMNMHFOBOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JNKIJPCFGKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<DEKILCMBKCB, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PLMNMHFOBOC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NKBDFFBLNPL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private DGKNLHNBBJB<DEKILCMBKCB, BNLEFJJKIPP> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private DGKNLHNBBJB<object, JIEDJHBPKDD>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private DGKNLHNBBJB<object, JIEDJHBPKDD> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private DGKNLHNBBJB<object, JIEDJHBPKDD>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB6A0", Offset = "0x1DCA2A0", VA = "0x181DCB6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBB10", Offset = "0x1DCA710", VA = "0x181DCBB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<IDOLLADEHJJ> GNBOHJPEDFE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	private PLMNMHFOBOC(IReadOnlyList<IDOLLADEHJJ> OBCPCGLFBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DD97C0", Offset = "0x1DD83C0", VA = "0x181DD97C0")]
	public static IDOLLADEHJJ MALBLLNDBHJ(IReadOnlyList<IDOLLADEHJJ> OBCPCGLFBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DD95E0", Offset = "0x1DD81E0", VA = "0x181DD95E0")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, PLMNMHFOBOC> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, PLMNMHFOBOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9680", Offset = "0x1DD8280", VA = "0x181DD9680")]
	[AsyncStateMachine(typeof(JNKIJPCFGKB))]
	public static Task<DGKNLHNBBJB<DEKILCMBKCB, BNLEFJJKIPP>> LFEEFJAJHFO(NKBDFFBLNPL EBCHPMPLBLG, PLMNMHFOBOC NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct MMAKMDPBBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int LOHCAPLAMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int KGAKPAMIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] EIIIJBECKHI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x18BEC50", Offset = "0x18BD850", VA = "0x1818BEC50")]
	private MMAKMDPBBPC(int MAJIECOCCAC, int PMIDLPOCCEE, byte[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF470", Offset = "0x1DCE070", VA = "0x181DCF470")]
	public static IDOLLADEHJJ MALBLLNDBHJ(int MAJIECOCCAC, int PMIDLPOCCEE, ByteString KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF250", Offset = "0x1DCDE50", VA = "0x181DCF250")]
	public static IDOLLADEHJJ[] GAJNOGGLEHL(IDOLLADEHJJ ODKDNEPMNIA, int BLMCNEELCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF390", Offset = "0x1DCDF90", VA = "0x181DCF390")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, MMAKMDPBBPC> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, MMAKMDPBBPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF130", Offset = "0x1DCDD30", VA = "0x181DCF130")]
	public static DGKNLHNBBJB<IDOLLADEHJJ, PGJMJGCIBHB> ECDNJKDACHL(NKBDFFBLNPL EBCHPMPLBLG, [In] MMAKMDPBBPC NOLNJDLEMAA)
	{
		return default(DGKNLHNBBJB<IDOLLADEHJJ, PGJMJGCIBHB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AHOGAMGDHFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GOAEOFAGDLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, PGJMJGCIBHB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NKBDFFBLNPL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AHOGAMGDHFP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private DGKNLHNBBJB<bool, PGJMJGCIBHB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, PGJMJGCIBHB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC68A0", Offset = "0x1DC54A0", VA = "0x181DC68A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6EE0", Offset = "0x1DC5AE0", VA = "0x181DC6EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int LOHCAPLAMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int KGAKPAMIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] EIIIJBECKHI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x18BEC50", Offset = "0x18BD850", VA = "0x1818BEC50")]
	private AHOGAMGDHFP(int MAJIECOCCAC, int PMIDLPOCCEE, byte[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE010", Offset = "0x1DBCC10", VA = "0x181DBE010")]
	public static IDOLLADEHJJ MALBLLNDBHJ(int MAJIECOCCAC, int PMIDLPOCCEE, ByteString KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDC00", Offset = "0x1DBC800", VA = "0x181DBDC00")]
	public static IDOLLADEHJJ?[]? GAPIKPDJMKG(int BLMCNEELCAF, GLEDFAMGOCH? GFAFHNOFNDA, JCLGJDHLEKN? HCLALOIEKIC, MHLNEPCFHJN? DNCEPNILLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDE00", Offset = "0x1DBCA00", VA = "0x181DBDE00")]
	public static ILHAJEBFGOI<CDHFMAMOJHN, AHOGAMGDHFP> LADHFPJPNAB(IDOLLADEHJJ GHGFBHNADEL)
	{
		return default(ILHAJEBFGOI<CDHFMAMOJHN, AHOGAMGDHFP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDEE0", Offset = "0x1DBCAE0", VA = "0x181DBDEE0")]
	[AsyncStateMachine(typeof(GOAEOFAGDLB))]
	public static Task<DGKNLHNBBJB<bool, PGJMJGCIBHB>> LFEEFJAJHFO(NKBDFFBLNPL EBCHPMPLBLG, AHOGAMGDHFP NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ODOMJLHLIIF : OPAJNBCANPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PMCILDOBJII? EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7950", Offset = "0x1DD6550", VA = "0x181DD7950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	internal ODOMJLHLIIF(NKBDFFBLNPL KKJDCIPMCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KHCJANPPIEB : PMCILDOBJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NINNLLILECB NMMFPDKNIDE;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	public KHCJANPPIEB(NKBDFFBLNPL KKJDCIPMCCK, NINNLLILECB FDOBLOMBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC5F0", Offset = "0x1DCB1F0", VA = "0x181DCC5F0", Slot = "4")]
	public DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH> GCOOEHOGIGH(KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<LNDJCPNFBEL> LCPPMLAJMFK)
	{
		return default(DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC320", Offset = "0x1DCAF20", VA = "0x181DCC320", Slot = "5")]
	public DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH> AHHOABNGJID(KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<FPAAFDFINNL> JBAOPGNMBAM)
	{
		return default(DGKNLHNBBJB<MKPDFMGAFIK, OCDAFDGDKDH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OLLGDFOFBDL : LDDLADIBNIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface JKMHFOLOLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NINNLLILECB> BNMKMJBNOLA(NKBDFFBLNPL KKJDCIPMCCK, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO, CancellationToken EJGJLLMBDIN);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PKNAPKKEBLL KOKPNCKBAKK(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IKJKOCPKMKK : JKMHFOLOLGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct OKHJLGGGMJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<NINNLLILECB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NKBDFFBLNPL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public JCLGJDHLEKN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public MHLNEPCFHJN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<DIJPCCIGCJH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1DD87D0", Offset = "0x1DD73D0", VA = "0x181DD87D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8AF0", Offset = "0x1DD76F0", VA = "0x181DD8AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IKJKOCPKMKK EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private IKJKOCPKMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9970", Offset = "0x1DC8570", VA = "0x181DC9970", Slot = "4")]
		[AsyncStateMachine(typeof(OKHJLGGGMJE))]
		public Task<NINNLLILECB> BNMKMJBNOLA(NKBDFFBLNPL KKJDCIPMCCK, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO, CancellationToken EJGJLLMBDIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9AD0", Offset = "0x1DC86D0", VA = "0x181DC9AD0", Slot = "5")]
		public PKNAPKKEBLL KOKPNCKBAKK(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BCOBGLHCPIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<OLLGDFOFBDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NKBDFFBLNPL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JCLGJDHLEKN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MHLNEPCFHJN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLEDFAMGOCH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private JKMHFOLOLGE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<NINNLLILECB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0FC0", Offset = "0x1DBFBC0", VA = "0x181DC0FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1510", Offset = "0x1DC0110", VA = "0x181DC1510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NINNLLILECB NMMFPDKNIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PKNAPKKEBLL MPLEJKHGIKI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PMGBIHIMAAN GPCJIAEGCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8EC0", Offset = "0x1DD7AC0", VA = "0x181DD8EC0", Slot = "4")]
		get
		{
			return default(PMGBIHIMAAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DNHALMKOBJA GGNLPLABMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8C90", Offset = "0x1DD7890", VA = "0x181DD8C90", Slot = "5")]
		get
		{
			return default(DNHALMKOBJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KHCJANPPIEB OAELMINFFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OEIDIKHEEBP OHOFAJIPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public KKKNNJHKIFI HFOPOGOLBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8F20", Offset = "0x1DD7B20", VA = "0x181DD8F20")]
	private OLLGDFOFBDL(NINNLLILECB FDOBLOMBDPM, PKNAPKKEBLL EKANANBNHBN, KHCJANPPIEB PJNCFPCADOF, OEIDIKHEEBP AEMEOCEDNDG, KKKNNJHKIFI ACGEOMKMDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8D50", Offset = "0x1DD7950", VA = "0x181DD8D50")]
	[AsyncStateMachine(typeof(BCOBGLHCPIJ))]
	public static Task<OLLGDFOFBDL> OCNONELDNGN(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8C30", Offset = "0x1DD7830", VA = "0x181DD8C30", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class OJFGCHFAGDN : OPKFIBMLNHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface KMEKLOAJFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LDDLADIBNIC> PGIEJMJAPBE(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO, CancellationToken EJGJLLMBDIN);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NAAJAIMAJJL();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KEBHECOMDLF();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class DJFLGKNAABP : KMEKLOAJFJB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct CGBMBJFLFDE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<LDDLADIBNIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public NKBDFFBLNPL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GLEDFAMGOCH evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public JCLGJDHLEKN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public MHLNEPCFHJN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<OLLGDFOFBDL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2920", Offset = "0x1DC1520", VA = "0x181DC2920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2C60", Offset = "0x1DC1860", VA = "0x181DC2C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3960", Offset = "0x1DC2560", VA = "0x181DC3960", Slot = "4")]
		[AsyncStateMachine(typeof(CGBMBJFLFDE))]
		public Task<LDDLADIBNIC> PGIEJMJAPBE(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO, CancellationToken EJGJLLMBDIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NAAJAIMAJJL();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KEBHECOMDLF();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected DJFLGKNAABP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NGHBADCHFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<LDDLADIBNIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OJFGCHFAGDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<BABPIFEMKHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF900", Offset = "0x1DCE500", VA = "0x181DCF900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFB00", Offset = "0x1DCE700", VA = "0x181DCFB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DKOEDNEKIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public OJFGCHFAGDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NKBDFFBLNPL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GLEDFAMGOCH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JCLGJDHLEKN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MHLNEPCFHJN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<LDDLADIBNIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3AC0", Offset = "0x1DC26C0", VA = "0x181DC3AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3FF0", Offset = "0x1DC2BF0", VA = "0x181DC3FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KMEKLOAJFJB AJFJAGOPOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<BABPIFEMKHH> PEAJHEDBGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<BABPIFEMKHH> GPBHBAOJKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource LFELAFOEFHN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HLCBICCMHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x879630", Offset = "0x878230", VA = "0x180879630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x961730", Offset = "0x960330", VA = "0x180961730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x961720", Offset = "0x960320", VA = "0x180961720", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x961740", Offset = "0x960340", VA = "0x180961740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool PFDHAHGFBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF69A30", Offset = "0xF68630", VA = "0x180F69A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD81E0", Offset = "0x1DD6DE0", VA = "0x181DD81E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LDDLADIBNIC? ICLOHIDJFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD80F0", Offset = "0x1DD6CF0", VA = "0x181DD80F0", Slot = "7")]
	[AsyncStateMachine(typeof(NGHBADCHFAM))]
	public Task<LDDLADIBNIC> KPFMOCCGPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD81F0", Offset = "0x1DD6DF0", VA = "0x181DD81F0")]
	public OJFGCHFAGDN(KMEKLOAJFJB BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7E20", Offset = "0x1DD6A20", VA = "0x181DD7E20", Slot = "8")]
	[AsyncStateMachine(typeof(DKOEDNEKIDK))]
	public Task CHCLBDJLNOB(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F80", Offset = "0x1DD6B80", VA = "0x181DD7F80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PJGIBGNLEAA : GHCOGGGHOLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OEIDIKHEEBP CENANMIIFAO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public PJGIBGNLEAA(OEIDIKHEEBP AEMEOCEDNDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class COJNBFLKKJA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class MOMFGKIBJAG<TGraph> : BJNJFINEDCC where TGraph : GADCIAEBIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph KJLBKPNAODH;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual GPBEKBIODBK? MBCNMPGIBOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDB5490", Offset = "0xDB4090", VA = "0x180DB5490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
		public MOMFGKIBJAG(TGraph IKOAHIFGOIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JFKPALMFDEK : MOMFGKIBJAG<ALJFPJIMAHH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GPBEKBIODBK? MBCNMPGIBOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA800", Offset = "0x1DC9400", VA = "0x181DCA800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA820", Offset = "0x1DC9420", VA = "0x181DCA820")]
		public JFKPALMFDEK(ALJFPJIMAHH MKFIDAHMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DC3300", Offset = "0x1DC1F00", VA = "0x181DC3300")]
	public static BJNJFINEDCC CIGBOGDFGOD(GADCIAEBIHE IKOAHIFGOIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class ALNGKPEIOMI : HLODBMFDKOO, HDBLOMJOBNJ, DPPEIKPKKKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class AHFENDHIDBA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AHFENDHIDBA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public HAOANKFPNCO errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9E30", Offset = "0x1DD8A30", VA = "0x181DD9E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA0A0", Offset = "0x1DD8CA0", VA = "0x181DDA0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ALNGKPEIOMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AHFENDHIDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1DBDB10", Offset = "0x1DBC710", VA = "0x181DBDB10")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task CNLDEAGLMFD(HAOANKFPNCO errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct JAGNMGPKELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public ALNGKPEIOMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9D80", Offset = "0x1DC8980", VA = "0x181DC9D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA1F0", Offset = "0x1DC8DF0", VA = "0x181DCA1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IAFEACPOJOP
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
			public IAFEACPOJOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA100", Offset = "0x1DD8D00", VA = "0x181DDA100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA3E0", Offset = "0x1DD8FE0", VA = "0x181DDA3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ALNGKPEIOMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IAFEACPOJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9480", Offset = "0x1DC8080", VA = "0x181DC9480")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task ANLFDKGIJBK(HAOANKFPNCO errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GGEBPMKIDIG KCEPKLFLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<DIHJAJDLIOG> GDBFKCFBNJA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private IKMOPJOGEJD BFGGKOFDMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0790", Offset = "0x1DBF390", VA = "0x181DC0790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FEAGCKDELFK<LNDJCPNFBEL> MECPBLPBPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8785B0", Offset = "0x8771B0", VA = "0x1808785B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(FEAGCKDELFK<LNDJCPNFBEL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB2CB80", Offset = "0xB2B780", VA = "0x180B2CB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private FEAGCKDELFK<HDBJEEHEBJO> CPPHNPANMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9577E0", Offset = "0x9563E0", VA = "0x1809577E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override FEAGCKDELFK<HHCMNLLLPME> JHAIOAHLPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF0C0", Offset = "0x1DBDCC0", VA = "0x181DBF0C0", Slot = "19")]
		get
		{
			return default(FEAGCKDELFK<HHCMNLLLPME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ONILNKJDHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1DBE7C0", Offset = "0x1DBD3C0", VA = "0x181DBE7C0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0E50", Offset = "0x1DBFA50", VA = "0x181DC0E50")]
	private ALNGKPEIOMI(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD, GGEBPMKIDIG EMBJFPCMFBH, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<LNDJCPNFBEL> LCPPMLAJMFK, FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ, bool MMPJLAKAIJJ, string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEA50", Offset = "0x1DBD650", VA = "0x181DBEA50")]
	public static ALNGKPEIOMI CIGBOGDFGOD(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD, GGEBPMKIDIG KMJAEAGEOPB, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ, FEAGCKDELFK<LNDJCPNFBEL> LCPPMLAJMFK, bool MMPJLAKAIJJ, bool JMOANIOPEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0090", Offset = "0x1DBEC90", VA = "0x181DC0090", Slot = "20")]
	protected override void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEF00", Offset = "0x1DBDB00", VA = "0x181DBEF00", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0360", Offset = "0x1DBEF60", VA = "0x181DC0360", Slot = "28")]
	public void ILHGNGGNDOD(DIHJAJDLIOG OOODGGOEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0840", Offset = "0x1DBF440", VA = "0x181DC0840", Slot = "25")]
	public void NMOHLEBGMAE(HLJOJCNGIOK KDNINLBHKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF320", Offset = "0x1DBDF20", VA = "0x181DBF320", Slot = "26")]
	public void FOHFPONDKMM(OHHMIBEIDLO NAKGKEKALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C20", Offset = "0x1DBF820", VA = "0x181DC0C20", Slot = "22")]
	protected override void OKAANEHKOFJ(JPOKFENGOKO PNEJKFFOBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DC05D0", Offset = "0x1DBF1D0", VA = "0x181DC05D0", Slot = "30")]
	public string KBCICFBMDHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE0F0", Offset = "0x1DBCCF0", VA = "0x181DBE0F0", Slot = "27")]
	public string AECIKAKNNIH(int ONLOKNDIICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFE60", Offset = "0x1DBEA60", VA = "0x181DBFE60")]
	private void GCGBIPMCFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE470", Offset = "0x1DBD070", VA = "0x181DBE470", Slot = "29")]
	public void AKDDLNCEKJN(DIHJAJDLIOG OOODGGOEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0410", Offset = "0x1DBF010", VA = "0x181DC0410")]
	private void JHAEAKHPCND(bool BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEE00", Offset = "0x1DBDA00", VA = "0x181DBEE00", Slot = "31")]
	[AsyncStateMachine(typeof(JAGNMGPKELN))]
	public Task DGOFMBPFBJC(string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE690", Offset = "0x1DBD290", VA = "0x181DBE690")]
	public void BDNBEHEEGDH(string BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFCC0", Offset = "0x1DBE8C0", VA = "0x181DBFCC0")]
	private void FPJEAPADIPN(int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xB2CB80", Offset = "0xB2B780", VA = "0x180B2CB80")]
	internal void IFJGNLBFKHO(FEAGCKDELFK<LNDJCPNFBEL> BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0D00", Offset = "0x1DBF900", VA = "0x181DC0D00")]
	[CompilerGenerated]
	private bool PDKMFGHCODE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF1D0", Offset = "0x1DBDDD0", VA = "0x181DBF1D0")]
	[CompilerGenerated]
	private bool FIANLKHJCLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE420", Offset = "0x1DBD020", VA = "0x181DBE420")]
	[CompilerGenerated]
	private int EGEKELEMAIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DC07B0", Offset = "0x1DBF3B0", VA = "0x181DC07B0")]
	[CompilerGenerated]
	private bool MGMDNKMEOHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE540", Offset = "0x1DBD140", VA = "0x181DBE540")]
	[CompilerGenerated]
	private bool BCDJGOJPJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0740", Offset = "0x1DBF340", VA = "0x181DC0740")]
	[CompilerGenerated]
	private bool LJFNKHEKINF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0250", Offset = "0x1DBEE50", VA = "0x181DC0250")]
	[CompilerGenerated]
	private bool IBCAMBCCBLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE420", Offset = "0x1DBD020", VA = "0x181DBE420")]
	[CompilerGenerated]
	private int AFCGLFKGDDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF100", Offset = "0x1DBDD00", VA = "0x181DBF100")]
	[CompilerGenerated]
	private bool EKAMCNFBDGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC03C0", Offset = "0x1DBEFC0", VA = "0x181DC03C0")]
	[CompilerGenerated]
	private int INBKMPKJODM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DC02E0", Offset = "0x1DBEEE0", VA = "0x181DC02E0")]
	[CompilerGenerated]
	private void IFIDOKENFGH(object BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE980", Offset = "0x1DBD580", VA = "0x181DBE980")]
	[CompilerGenerated]
	private bool CAKIJFDFIFO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LLHDFCCFNJE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class BBLJOLJIMAD : FOGNFHOCLFD<HKPDCKIKFDB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override DIBKLHJNJMH BEPHDELLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x91C340", Offset = "0x91AF40", VA = "0x18091C340", Slot = "119")]
			get
			{
				return default(DIBKLHJNJMH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0F60", Offset = "0x1DBFB60", VA = "0x181DC0F60")]
		public BBLJOLJIMAD(NKBDFFBLNPL KKJDCIPMCCK, HKPDCKIKFDB GAFLMOIGPJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class IGMBOCCFNDH : IPBOBBOKBDL<KIAJGJJEIBK>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9900", Offset = "0x1DC8500", VA = "0x181DC9900")]
		public IGMBOCCFNDH(NKBDFFBLNPL KKJDCIPMCCK, KIAJGJJEIBK FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9610", Offset = "0x1DC8210", VA = "0x181DC9610", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9790", Offset = "0x1DC8390", VA = "0x181DC9790")]
		[CompilerGenerated]
		private bool CGFIHMGLGJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC97E0", Offset = "0x1DC83E0", VA = "0x181DC97E0")]
		[CompilerGenerated]
		private void EBLGJKOGCCO(bool BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class ONMDALGPBIH : IPBOBBOKBDL<BGBMBOMJCIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class BGCNGBNJIBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public ONMDALGPBIH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public BGCNGBNJIBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1DC20C0", Offset = "0x1DC0CC0", VA = "0x181DC20C0")]
			internal void IKDKAOFMCJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2020", Offset = "0x1DC0C20", VA = "0x181DC2020")]
			internal bool BAHBMDHDAHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2070", Offset = "0x1DC0C70", VA = "0x181DC2070")]
			internal bool HEOAKBAGILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2110", Offset = "0x1DC0D10", VA = "0x181DC2110")]
			internal void LPEIJLBOFFD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2230", Offset = "0x1DC0E30", VA = "0x181DC2230")]
			internal bool PHCPJOPKBPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD92B0", Offset = "0x1DD7EB0", VA = "0x181DD92B0")]
		public ONMDALGPBIH(NKBDFFBLNPL KKJDCIPMCCK, BGBMBOMJCIJ FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8FB0", Offset = "0x1DD7BB0", VA = "0x181DD8FB0", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class HCDLCIHDABJ : IPBOBBOKBDL<KPOOCAPEBCG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class KIONHCNGEAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public HCDLCIHDABJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public KIONHCNGEAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCE30", Offset = "0x1DCBA30", VA = "0x181DCCE30")]
			internal object IKDKAOFMCJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCFA0", Offset = "0x1DCBBA0", VA = "0x181DCCFA0")]
			internal bool KACLGHBEGCA(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCA30", Offset = "0x1DCB630", VA = "0x181DCCA30")]
			internal void BAHBMDHDAHB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCCD0", Offset = "0x1DCB8D0", VA = "0x181DCCCD0")]
			internal string HEOAKBAGILD(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD020", Offset = "0x1DCBC20", VA = "0x181DCD020")]
			internal IReadOnlyList<object> LPEIJLBOFFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD110", Offset = "0x1DCBD10", VA = "0x181DCD110")]
			internal bool PHCPJOPKBPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCF30", Offset = "0x1DCBB30", VA = "0x181DCCF30")]
			internal bool JLFDHCHCCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC9E0", Offset = "0x1DCB5E0", VA = "0x181DCC9E0")]
			internal void AJJOPLNMKLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD0C0", Offset = "0x1DCBCC0", VA = "0x181DCD0C0")]
			internal bool PGHPEBPAMGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD070", Offset = "0x1DCBC70", VA = "0x181DCD070")]
			internal bool NDDJDGNIDDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC8C0", Offset = "0x1DCB4C0", VA = "0x181DCC8C0")]
			internal void AIDMFKGBLIC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCC80", Offset = "0x1DCB880", VA = "0x181DCCC80")]
			internal bool GIBCPPIPIPM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7960", Offset = "0x1DC6560", VA = "0x181DC7960")]
		public HCDLCIHDABJ(NKBDFFBLNPL KKJDCIPMCCK, KPOOCAPEBCG FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7330", Offset = "0x1DC5F30", VA = "0x181DC7330", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HFMDGALDCKF : IPBOBBOKBDL<ODCEEBHNIML>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class GGBAAEMFIGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public HFMDGALDCKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public GGBAAEMFIGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5E50", Offset = "0x1DC4A50", VA = "0x181DC5E50")]
			internal bool IKDKAOFMCJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5CE0", Offset = "0x1DC48E0", VA = "0x181DC5CE0")]
			internal void BAHBMDHDAHB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5E00", Offset = "0x1DC4A00", VA = "0x181DC5E00")]
			internal bool HEOAKBAGILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5EA0", Offset = "0x1DC4AA0", VA = "0x181DC5EA0")]
			internal void LPEIJLBOFFD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5FC0", Offset = "0x1DC4BC0", VA = "0x181DC5FC0")]
			internal bool PHCPJOPKBPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7CD0", Offset = "0x1DC68D0", VA = "0x181DC7CD0")]
		public HFMDGALDCKF(NKBDFFBLNPL KKJDCIPMCCK, ODCEEBHNIML GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DC79D0", Offset = "0x1DC65D0", VA = "0x181DC79D0", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class DDNPLIGPAOB<TNode> : IPBOBBOKBDL<TNode> where TNode : notnull, EFHGOBOIDNI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct BMCBIGIKFHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public DDNPLIGPAOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x47F1E80", Offset = "0x47F0A80", VA = "0x1847F1E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x47F2250", Offset = "0x47F0E50", VA = "0x1847F2250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct IDDDCHKLKAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public DDNPLIGPAOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public FEAGCKDELFK<JNBJANNDBMM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x392D510", Offset = "0x392C110", VA = "0x18392D510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x392D8E0", Offset = "0x392C4E0", VA = "0x18392D8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public sealed override bool GKOHCMDDLIH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override FEAGCKDELFK<JNBJANNDBMM>? PDDGOHPAGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x503E0C0", Offset = "0x503CCC0", VA = "0x18503E0C0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x386A710", Offset = "0x3869310", VA = "0x18386A710")]
		protected DDNPLIGPAOB(NKBDFFBLNPL KKJDCIPMCCK, TNode FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x503DD50", Offset = "0x503C950", VA = "0x18503DD50", Slot = "95")]
		[AsyncStateMachine(typeof(DDNPLIGPAOB<>.BMCBIGIKFHN))]
		public override Task<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> CCEIDGCPIIO(string MPGNMPAPHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x503DCB0", Offset = "0x503C8B0", VA = "0x18503DCB0", Slot = "117")]
		public sealed override bool BPCLAGBAHLD(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503CB10", VA = "0x18503DF10", Slot = "107")]
		protected sealed override bool LPCGJJFHHKP(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x503DE70", Offset = "0x503CA70", VA = "0x18503DE70", Slot = "108")]
		protected override bool DFGEJDJIBPA(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x503DFB0", Offset = "0x503CBB0", VA = "0x18503DFB0", Slot = "96")]
		[AsyncStateMachine(typeof(DDNPLIGPAOB<>.IDDDCHKLKAE))]
		public override Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> ODNODPOGLJG(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class ODOKIDJACJI : IDIOPLFMFJL<EBEONOAPAAF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class FEJIKPDCELB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ODOKIDJACJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public FEJIKPDCELB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4FA0", Offset = "0x1DC3BA0", VA = "0x181DC4FA0")]
			internal bool BDDBOMDCACH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5020", Offset = "0x1DC3C20", VA = "0x181DC5020")]
			internal void FMBJPLFEFJG(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1DD78F0", Offset = "0x1DD64F0", VA = "0x181DD78F0")]
		public ODOKIDJACJI(NKBDFFBLNPL KKJDCIPMCCK, EBEONOAPAAF GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1DD76A0", Offset = "0x1DD62A0", VA = "0x181DD76A0", Slot = "119")]
		protected override void KGGCHHGMJDG(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JBNGJBJGDNF : HGBKJDNNGHB<DJKOLJMJJPE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA730", Offset = "0x1DC9330", VA = "0x181DCA730")]
		public JBNGJBJGDNF(NKBDFFBLNPL KKJDCIPMCCK, DJKOLJMJJPE FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class HGBKJDNNGHB<TNode> : IPBOBBOKBDL<TNode> where TNode : notnull, CJPKFCBFKDG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct DEBDIJNNNDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public HGBKJDNNGHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private TaskAwaiter<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x503E500", Offset = "0x503D100", VA = "0x18503E500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x503E870", Offset = "0x503D470", VA = "0x18503E870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct KBIDNAJCKPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public HGBKJDNNGHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public FEAGCKDELFK<JNBJANNDBMM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3B65070", Offset = "0x3B63C70", VA = "0x183B65070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3B653C0", Offset = "0x3B63FC0", VA = "0x183B653C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override FEAGCKDELFK<GJFGFOEJABF>? OIGPAKOJNGH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x386A740", Offset = "0x3869340", VA = "0x18386A740", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override FEAGCKDELFK<JNBJANNDBMM>? PDDGOHPAGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x386A7F0", Offset = "0x38693F0", VA = "0x18386A7F0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x386A710", Offset = "0x3869310", VA = "0x18386A710")]
		public HGBKJDNNGHB(NKBDFFBLNPL KKJDCIPMCCK, TNode FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x386A3A0", Offset = "0x3868FA0", VA = "0x18386A3A0", Slot = "95")]
		[AsyncStateMachine(typeof(HGBKJDNNGHB<>.DEBDIJNNNDO))]
		public override Task<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> CCEIDGCPIIO(string MPGNMPAPHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x386A300", Offset = "0x3868F00", VA = "0x18386A300", Slot = "117")]
		public sealed override bool BPCLAGBAHLD(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x386A560", Offset = "0x3869160", VA = "0x18386A560", Slot = "107")]
		protected sealed override bool LPCGJJFHHKP(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x386A4C0", Offset = "0x38690C0", VA = "0x18386A4C0", Slot = "108")]
		protected override bool DFGEJDJIBPA(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x386A600", Offset = "0x3869200", VA = "0x18386A600", Slot = "96")]
		[AsyncStateMachine(typeof(HGBKJDNNGHB<>.KBIDNAJCKPJ))]
		public override Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> ODNODPOGLJG(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LEFNJPCIDDA : IDIOPLFMFJL<LABBOHELBBL>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class JBMIOHLIFMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public LEFNJPCIDDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public JBMIOHLIFMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA610", Offset = "0x1DC9210", VA = "0x181DCA610")]
			internal int BDDBOMDCACH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA690", Offset = "0x1DC9290", VA = "0x181DCA690")]
			internal void FMBJPLFEFJG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD9B0", Offset = "0x1DCC5B0", VA = "0x181DCD9B0")]
		public LEFNJPCIDDA(NKBDFFBLNPL KKJDCIPMCCK, LABBOHELBBL GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD700", Offset = "0x1DCC300", VA = "0x181DCD700", Slot = "119")]
		protected override void KGGCHHGMJDG(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class LFHKIFLMBKJ : IPBOBBOKBDL<JKMFHGLHIEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xA53E40", Offset = "0xA52A40", VA = "0x180A53E40", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDA10", Offset = "0x1DCC610", VA = "0x181DCDA10")]
		public LFHKIFLMBKJ(NKBDFFBLNPL KKJDCIPMCCK, JKMFHGLHIEF FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class ABPKHNJBDAP : HGBKJDNNGHB<LAJBJDEHBAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool DKIGHABHPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CNAEABLEFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1DBDAD0", Offset = "0x1DBC6D0", VA = "0x181DBDAD0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x91DFC0", Offset = "0x91CBC0", VA = "0x18091DFC0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1DBDA70", Offset = "0x1DBC670", VA = "0x181DBDA70")]
		public ABPKHNJBDAP(NKBDFFBLNPL KKJDCIPMCCK, LAJBJDEHBAO FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class JHPMFDJCFIP : IPBOBBOKBDL<LIHKFDBBMAG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1045D50", Offset = "0x1044950", VA = "0x181045D50", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB150", Offset = "0x1DC9D50", VA = "0x181DCB150")]
		public JHPMFDJCFIP(NKBDFFBLNPL KKJDCIPMCCK, LIHKFDBBMAG FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class OPEHMJHDMAG : IPBOBBOKBDL<JIGGPKDDHFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x91F360", Offset = "0x91DF60", VA = "0x18091F360", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9320", Offset = "0x1DD7F20", VA = "0x181DD9320")]
		public OPEHMJHDMAG(NKBDFFBLNPL KKJDCIPMCCK, JIGGPKDDHFC FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "107")]
		protected override bool LPCGJJFHHKP(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class JACJPBDMDJP : IPBOBBOKBDL<LFKDMDCFADN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x92F620", Offset = "0x92E220", VA = "0x18092F620", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool HCMEGIOHEKC
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1DC9D30", Offset = "0x1DC8930", VA = "0x181DC9D30", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool NDDDNFOBDII
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9CC0", Offset = "0x1DC88C0", VA = "0x181DC9CC0")]
		public JACJPBDMDJP(NKBDFFBLNPL KKJDCIPMCCK, LFKDMDCFADN FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class LJKIDMKLEEO : IPBOBBOKBDL<GLJCAGAFACL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x91C340", Offset = "0x91AF40", VA = "0x18091C340", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HCMEGIOHEKC
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDED0", Offset = "0x1DCCAD0", VA = "0x181DCDED0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override bool NDDDNFOBDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDE60", Offset = "0x1DCCA60", VA = "0x181DCDE60")]
		public LJKIDMKLEEO(NKBDFFBLNPL KKJDCIPMCCK, GLJCAGAFACL FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class LPJLABNOOAI : DDNPLIGPAOB<KAEOAEIOIAH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x92AA70", Offset = "0x929670", VA = "0x18092AA70", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF000", Offset = "0x1DCDC00", VA = "0x181DCF000")]
		public LPJLABNOOAI(NKBDFFBLNPL KKJDCIPMCCK, KAEOAEIOIAH FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class KANEANDJOLD : IDIOPLFMFJL<KLLEJNOKMKK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class FNCGKIOHNLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public KANEANDJOLD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public FNCGKIOHNLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5400", Offset = "0x1DC4000", VA = "0x181DC5400")]
			internal int BDDBOMDCACH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5480", Offset = "0x1DC4080", VA = "0x181DC5480")]
			internal void FMBJPLFEFJG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC1B0", Offset = "0x1DCADB0", VA = "0x181DCC1B0")]
		public KANEANDJOLD(NKBDFFBLNPL KKJDCIPMCCK, KLLEJNOKMKK GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBEB0", Offset = "0x1DCAAB0", VA = "0x181DCBEB0", Slot = "119")]
		protected override void KGGCHHGMJDG(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class FGMDPEAPFPG : FOGNFHOCLFD<AGDMIFHLAEE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override DIBKLHJNJMH BEPHDELLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "119")]
			get
			{
				return default(DIBKLHJNJMH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1DC50E0", Offset = "0x1DC3CE0", VA = "0x181DC50E0")]
		public FGMDPEAPFPG(NKBDFFBLNPL KKJDCIPMCCK, AGDMIFHLAEE GAFLMOIGPJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class OFOHFHCOPGC : IPBOBBOKBDL<ICGBBDONDFF>
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7A60", Offset = "0x1DD6660", VA = "0x181DD7A60")]
		public OFOHFHCOPGC(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class IPBOBBOKBDL<TNode> : HHOAODFCJBD, IDisposable where TNode : notnull, ICGBBDONDFF
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct MJDHDJFHLBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public readonly string JHPNDNIMCCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly string OPOMGGMICEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string ELPCPNLDLGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly KDLGANOALJD AMFNJEKEFAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly JMJEBDAEGED FIIKJABLCBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly Func<string, bool> CIEBMLAGOBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly string DHCGMMBIEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly Func<string, bool> EKDFCEMEMOP;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3E50060", Offset = "0x3E4EC60", VA = "0x183E50060")]
			public MJDHDJFHLBD(string EEEANFDAMGO, string JPIAALKGIMF, string HGDLDHHLGHF, KDLGANOALJD JIPAMPAIPHL, JMJEBDAEGED CMOLGDOJMHP, Func<string, bool> EIECOMFKCAJ, string GLHAFJPONBA, Func<string, bool> KHDNLGGJAHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class HGOHHOEPGFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public IPBOBBOKBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public NKBDFFBLNPL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public HGOHHOEPGFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x386AB60", Offset = "0x3869760", VA = "0x18386AB60")]
			internal NPBOBPPDNAK BGPILABIAMK(JLCJKIKLBLB portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct DAOCJDPGLDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public IPBOBBOKBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x502F620", Offset = "0x502E220", VA = "0x18502F620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct BMDOCOIMNLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public IPBOBBOKBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public IOJFBDCDMGD? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public IACENOBNHPJ? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x47F22C0", Offset = "0x47F0EC0", VA = "0x1847F22C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x47F2560", Offset = "0x47F1160", VA = "0x1847F2560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class CCDHDCAHBLL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public CCDHDCAHBLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x31266F0", Offset = "0x31252F0", VA = "0x1831266F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public IPBOBBOKBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public PLLNFKHEGMD configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public CCDHDCAHBLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			internal string LMMCNJEDFHG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
			internal void CCNDGIKJHBB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4AE2510", Offset = "0x4AE1110", VA = "0x184AE2510")]
			[AsyncStateMachine(typeof(IPBOBBOKBDL<>.CCDHDCAHBLL.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void HBDGAFDHAFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class DPIBAGKOIEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public DPIBAGKOIEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x506BE10", Offset = "0x506AA10", VA = "0x18506BE10")]
			internal bool IEGNEJHEDIE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x506BD40", Offset = "0x506A940", VA = "0x18506BD40")]
			internal bool DHGIMJHGGNK(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct MEDENFFGOME : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public IPBOBBOKBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3E139C0", Offset = "0x3E125C0", VA = "0x183E139C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3E13D30", Offset = "0x3E12930", VA = "0x183E13D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly NKBDFFBLNPL IPAOAOOMGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly bool NMDJHBLMLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private CHOKMLPIAHE<JNBJANNDBMM, NPBOBPPDNAK> GJDGMDCEBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private CHOKMLPIAHE<JNBJANNDBMM, NDEPEIEDMDJ> GCDNEECLFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<Action> CJDOCLJOJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[CompilerGenerated]
		private Action<FEAGCKDELFK<JNBJANNDBMM>>? LJHPNDAOIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[CompilerGenerated]
		private Action<FEAGCKDELFK<JNBJANNDBMM>, NDEPEIEDMDJ>? IHPCJNNIMDN;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected KFOAEGJFKOB CGPIEJILDFC
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x39632F0", Offset = "0x3961EF0", VA = "0x1839632F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected TNode KKLCFFNELGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public KCDCADLPKIO<AAMCLGEIBGD> OCNEKJAEIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x9B5260", Offset = "0x9B3E60", VA = "0x1809B5260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KCDCADLPKIO<AAMCLGEIBGD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public FEAGCKDELFK<ABMPONEJFKK> LMPJIBIKBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3968170", Offset = "0x3966D70", VA = "0x183968170", Slot = "6")]
			get
			{
				return default(FEAGCKDELFK<ABMPONEJFKK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public object DFCLJPAOEGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3391D20", Offset = "0x3390920", VA = "0x183391D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual bool PDELHIBGMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int DEHFKEFKIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3967E70", Offset = "0x3966A70", VA = "0x183967E70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DFOLEDMKELE ABOOMDLBHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3967E20", Offset = "0x3966A20", VA = "0x183967E20", Slot = "10")]
			get
			{
				return default(DFOLEDMKELE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string NLMFDMLDNBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3968300", Offset = "0x3966F00", VA = "0x183968300", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected virtual bool NDDDNFOBDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FEAGCKDELFK<IPMBLIHPKBJ> CFKLAMNJOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x945510", Offset = "0x944110", VA = "0x180945510", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(FEAGCKDELFK<IPMBLIHPKBJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC060", VA = "0x1809AD460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool HCMEGIOHEKC
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual bool DKIGHABHPLD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual BOBGKCEJNDN BDNMPKJKHID
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x91B8E0", Offset = "0x91A4E0", VA = "0x18091B8E0", Slot = "89")]
			get
			{
				return default(BOBGKCEJNDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool AJCOCGDNIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3967C50", Offset = "0x3966850", VA = "0x183967C50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool EFKIFEPFKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3967CA0", Offset = "0x39668A0", VA = "0x183967CA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool OGLEMHJDLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3967CF0", Offset = "0x39668F0", VA = "0x183967CF0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int PJLNIFEFIGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3968130", Offset = "0x3966D30", VA = "0x183968130", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool EBLFCECABMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3967FB0", Offset = "0x3966BB0", VA = "0x183967FB0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool DHJBMHKGOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3967D80", Offset = "0x3966980", VA = "0x183967D80", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool FOIIEIPOJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAFD0D0", Offset = "0xAFBCD0", VA = "0x180AFD0D0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAFD410", Offset = "0xAFC010", VA = "0x180AFD410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool GAEPNAEPCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual bool GKNIBGFFBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3967D40", Offset = "0x3966940", VA = "0x183967D40", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool PKDDMMPLGGH
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3967F00", Offset = "0x3966B00", VA = "0x183967F00", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IOJFBDCDMGD ADMMPHIELJP
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3968090", Offset = "0x3966C90", VA = "0x183968090", Slot = "27")]
			get
			{
				return default(IOJFBDCDMGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public IACENOBNHPJ IMKNHDNNIAC
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39680E0", Offset = "0x3966CE0", VA = "0x1839680E0", Slot = "29")]
			get
			{
				return default(IACENOBNHPJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool BEOKFNNGJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual HKPECNAENEL? NJDJAHNGOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual EDHCILHEGNF? CEIBAIAKBFC
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual IEnumerable<KCDCADLPKIO<BABPFGLJKHJ>>? JADLMHLGEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "106")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AKJDMBIBPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3967DD0", Offset = "0x39669D0", VA = "0x183967DD0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public KCDCADLPKIO<GJFGFOEJABF> BPKPHMHNKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x3967FF0", Offset = "0x3966BF0", VA = "0x183967FF0", Slot = "55")]
			get
			{
				return default(KCDCADLPKIO<GJFGFOEJABF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FEAGCKDELFK<GJFGFOEJABF> LKPJGGLFILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3967EB0", Offset = "0x3966AB0", VA = "0x183967EB0", Slot = "56")]
			get
			{
				return default(FEAGCKDELFK<GJFGFOEJABF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool GKOHCMDDLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual FEAGCKDELFK<GJFGFOEJABF>? OIGPAKOJNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CNAEABLEFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool KGJMGOAEHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3967F50", Offset = "0x3966B50", VA = "0x183967F50", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7B1600", Offset = "0x7B0200", VA = "0x1807B1600", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1720", Offset = "0x7B0320", VA = "0x1807B1720")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public KCDCADLPKIO<BABPFGLJKHJ> LOFCJJCHJBB
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3968040", Offset = "0x3966C40", VA = "0x183968040", Slot = "62")]
			get
			{
				return default(KCDCADLPKIO<BABPFGLJKHJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public KCDCADLPKIO<BABPFGLJKHJ>? LKDLPABHOFP
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x39681E0", Offset = "0x3966DE0", VA = "0x1839681E0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public FOKPAJJHAME<JNBJANNDBMM, NDEPEIEDMDJ> BFAJIBECIEA
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x39682C0", Offset = "0x3966EC0", VA = "0x1839682C0", Slot = "64")]
			get
			{
				return default(FOKPAJJHAME<JNBJANNDBMM, NDEPEIEDMDJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual FEAGCKDELFK<JNBJANNDBMM>? PDDGOHPAGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NFHFBGFOHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3966730", Offset = "0x3965330", VA = "0x183966730", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x39664C0", Offset = "0x39650C0", VA = "0x1839664C0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HGFFGKLGPBE BKACFKOKNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3966560", Offset = "0x3965160", VA = "0x183966560", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3967380", Offset = "0x3965F80", VA = "0x183967380", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IAMGAPKMPDP EPHCKHCAEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3966800", Offset = "0x3965400", VA = "0x183966800", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3962BE0", Offset = "0x39617E0", VA = "0x183962BE0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GMHLJPPNCKO
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x39674E0", Offset = "0x39660E0", VA = "0x1839674E0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3967680", Offset = "0x3966280", VA = "0x183967680", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NAHEDOKDHHL
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3962D20", Offset = "0x3961920", VA = "0x183962D20", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3964BE0", Offset = "0x39637E0", VA = "0x183964BE0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>, NDEPEIEDMDJ> OOFAEACGJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3962DC0", Offset = "0x39619C0", VA = "0x183962DC0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3967290", Offset = "0x3965E90", VA = "0x183967290", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>, NDEPEIEDMDJ> LMDNOJKHLNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3964E60", Offset = "0x3963A60", VA = "0x183964E60", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3965C60", Offset = "0x3964860", VA = "0x183965C60", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>> LFMNLHBHJFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3963BB0", Offset = "0x39627B0", VA = "0x183963BB0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3966670", Offset = "0x3965270", VA = "0x183966670", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>, FEAGCKDELFK<JNBJANNDBMM>> LBHHGAIKPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3967420", Offset = "0x3966020", VA = "0x183967420", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3965050", Offset = "0x3963C50", VA = "0x183965050", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>, NDEPEIEDMDJ> CNAFLDFPFPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3963E50", Offset = "0x3962A50", VA = "0x183963E50", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3963960", Offset = "0x3962560", VA = "0x183963960", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<FEAGCKDELFK<JNBJANNDBMM>, FEAGCKDELFK<JNBJANNDBMM>> EAJNNNHDAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3962E80", Offset = "0x3961A80", VA = "0x183962E80", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3963A20", Offset = "0x3962620", VA = "0x183963A20", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3967760", Offset = "0x3966360", VA = "0x183967760")]
		[ONOAPBNPKCD("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[ONOAPBNPKCD("Need to handle `Name` better.")]
		protected IPBOBBOKBDL(NKBDFFBLNPL KKJDCIPMCCK, TNode FJKJNIMGBPD, bool JMOANIOPEHA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3965140", Offset = "0x3963D40", VA = "0x183965140", Slot = "82")]
		protected virtual void HAJAGMDCLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x39640C0", Offset = "0x3962CC0", VA = "0x1839640C0", Slot = "83")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3966CB0", Offset = "0x39658B0", VA = "0x183966CB0", Slot = "9")]
		[AsyncStateMachine(typeof(IPBOBBOKBDL<>.DAOCJDPGLDG))]
		public void MDKMKOBBNGA(int PFLNHKMGNAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3964F70", Offset = "0x3963B70", VA = "0x183964F70")]
		public bool GKNFNNPABNN([In] IOJFBDCDMGD BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x39663D0", Offset = "0x3964FD0", VA = "0x1839663D0")]
		public bool HNBKDEGDJEO([In] IACENOBNHPJ BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3965D20", Offset = "0x3964920", VA = "0x183965D20", Slot = "31")]
		public void HHIEKDGFIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x39669E0", Offset = "0x39655E0", VA = "0x1839669E0", Slot = "32")]
		[AsyncStateMachine(typeof(IPBOBBOKBDL<>.BMDOCOIMNLH))]
		public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> LEMAIDLIIMI(IOJFBDCDMGD? FBFBHGAGOOB, IACENOBNHPJ? AMHIBJAFJID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "92")]
		public virtual void LEAMAINEHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "93")]
		public virtual void LBDJMLPICDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "94")]
		public virtual void DKLFMLIMJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1B1E9A0", Offset = "0x1B1D5A0", VA = "0x181B1E9A0")]
		protected void HACDPIHPNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3967660", Offset = "0x3966260", VA = "0x183967660")]
		protected void ONDICHNGIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1F95650", Offset = "0x1F94250", VA = "0x181F95650")]
		private void PLNFCOIIFFO([In] IACENOBNHPJ MJCNDCDLGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3963AE0", Offset = "0x39626E0", VA = "0x183963AE0", Slot = "95")]
		public virtual Task<DGKNLHNBBJB<FEAGCKDELFK<JNBJANNDBMM>, BNLEFJJKIPP>> CCEIDGCPIIO(string MPGNMPAPHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3967590", Offset = "0x3966190", VA = "0x183967590", Slot = "96")]
		public virtual Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> ODNODPOGLJG(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "97")]
		public virtual void IHFHAOBJMKN(FEAGCKDELFK<JNBJANNDBMM> PMIDLPOCCEE, FEAGCKDELFK<JNBJANNDBMM> PMKKKDOAOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3966430", Offset = "0x3965030", VA = "0x183966430", Slot = "98")]
		public virtual IEnumerable<IDOLLADEHJJ> HOCOACGACNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3964FD0", Offset = "0x3963BD0", VA = "0x183964FD0", Slot = "99")]
		public DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP> GNLMLBOFKPN(string FOENHCOIAOO)
		{
			return default(DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3963810", Offset = "0x3962410", VA = "0x183963810", Slot = "46")]
		public bool BGKKJFCPFGL([Out] Guid BCCFOHIDEBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3964930", Offset = "0x3963530", VA = "0x183964930")]
		public bool FAPKJNELPIC([In] Guid IDHAMCEFIKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "100")]
		public virtual void KEPEANOIAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "101")]
		public virtual void GMBGDCCBCHC(bool PKHOHLENMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "102")]
		public virtual CDMAFCMLHAM HDOEGAEMMBI([In] HKCJBHMGGKF FDJHBPGLAHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3963C70", Offset = "0x3962870", VA = "0x183963C70")]
		protected void CFBABOHDALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3966C50", Offset = "0x3965850", VA = "0x183966C50", Slot = "107")]
		protected virtual bool LPCGJJFHHKP(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "108")]
		protected virtual bool DFGEJDJIBPA(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "115")]
		protected virtual void ADABGILEALH(PLLNFKHEGMD NKKLLNIPFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3965F10", Offset = "0x3964B10", VA = "0x183965F10")]
		protected void HIHHCDKBBGC(PLLNFKHEGMD CLADIKHOOAP, Func<string> MJIIOMEAJJN, Action<string> AIKNLBEPKHH, MJDHDJFHLBD PELDJLKMCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3965940", Offset = "0x3964540", VA = "0x183965940")]
		protected void HEBBCAJMCIH(PLLNFKHEGMD CLADIKHOOAP, Func<string> MJIIOMEAJJN, Action<string> AIKNLBEPKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x39668A0", Offset = "0x39654A0", VA = "0x1839668A0", Slot = "116")]
		protected virtual void KLPKCHHGCEM(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3964CD0", Offset = "0x39638D0", VA = "0x183964CD0", Slot = "78")]
		public void FOHFPONDKMM(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3963F10", Offset = "0x3962B10", VA = "0x183963F10", Slot = "79")]
		public MIEHDBHIKBD DIGLLBOLPEH()
		{
			return default(MIEHDBHIKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "117")]
		public virtual bool BPCLAGBAHLD(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x12482A0", Offset = "0x1246EA0", VA = "0x1812482A0")]
		private void PLIDBGGGGPJ([In] IOJFBDCDMGD GMKEEAOHFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3965840", Offset = "0x3964440", VA = "0x183965840")]
		private void HBIOLDDKKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3966D60", Offset = "0x3965960", VA = "0x183966D60")]
		private void MJHFPACMJCK(int KJBJIPHONFF, JLCJKIKLBLB NBFGIEIGIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3964C80", Offset = "0x3963880", VA = "0x183964C80")]
		private void FOBFNJIKAPB(int PMIDLPOCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3964D20", Offset = "0x3963920", VA = "0x183964D20")]
		private void FOKLPEJELLP(int PMIDLPOCCEE, JLCJKIKLBLB CMLKJPLBKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3962F40", Offset = "0x3961B40", VA = "0x183962F40")]
		private void AGPIAFAOBJD(int HNGFKEKMJAM, int OGPEBOFLBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3964060", Offset = "0x3962C60", VA = "0x183964060")]
		private void DOAOCKMOJGF(int HNGFKEKMJAM, int OGPEBOFLBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3964F20", Offset = "0x3963B20", VA = "0x183964F20")]
		private void GFIHDINOEFC(int PMIDLPOCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x39633E0", Offset = "0x3961FE0", VA = "0x1839633E0")]
		private void BCBGPCOLNDK(int KJBJIPHONFF, JLCJKIKLBLB NBFGIEIGIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x39676E0", Offset = "0x39662E0", VA = "0x1839676E0")]
		private void PPLGMALEMBP(int PMIDLPOCCEE, JLCJKIKLBLB CMLKJPLBKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3966B30", Offset = "0x3965730", VA = "0x183966B30", Slot = "118")]
		[AsyncStateMachine(typeof(IPBOBBOKBDL<>.MEDENFFGOME))]
		public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> LIBPOFIJFJC(string FOENHCOIAOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3963FF0", Offset = "0x3962BF0", VA = "0x183963FF0", Slot = "53")]
		private void DLNNPNNKBGN(object FFGMPLJMBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3966600", Offset = "0x3965200", VA = "0x183966600", Slot = "54")]
		private void IHIPMCLIKML(object FFGMPLJMBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3966C80", Offset = "0x3965880", VA = "0x183966C80", Slot = "28")]
		private bool MCKIGPFOJKA([In] IOJFBDCDMGD BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39667D0", Offset = "0x39653D0", VA = "0x1839667D0", Slot = "30")]
		private bool KGDMINBMFGF([In] IACENOBNHPJ BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3965110", Offset = "0x3963D10", VA = "0x183965110", Slot = "47")]
		private bool HAFNMIPADFH([In] Guid IDHAMCEFIKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3967350", Offset = "0x3965F50", VA = "0x183967350")]
		[CompilerGenerated]
		private string NAKMDHCDENL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3962C80", Offset = "0x3961880", VA = "0x183962C80")]
		[CompilerGenerated]
		private void ACLJMJHECBE(string MPGNMPAPHDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class KGIJFOHCONJ : DDNPLIGPAOB<NPPLCBPMLBP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xC23990", Offset = "0xC22590", VA = "0x180C23990", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC2C0", Offset = "0x1DCAEC0", VA = "0x181DCC2C0")]
		public KGIJFOHCONJ(NKBDFFBLNPL KKJDCIPMCCK, NPPLCBPMLBP FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class DBLBOAEEHHM : HGBKJDNNGHB<IJDELHLHENK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3490", Offset = "0x1DC2090", VA = "0x181DC3490")]
		public DBLBOAEEHHM(NKBDFFBLNPL KKJDCIPMCCK, IJDELHLHENK FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class FOGNFHOCLFD<T> : IPBOBBOKBDL<T> where T : notnull, DAKIECHGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class NLLJHJAFAMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public IReadOnlyList<KeyValuePair<string, IOCOBFNPIHJ>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public FOGNFHOCLFD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public DIBKLHJNJMH clipType;

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public NLLJHJAFAMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			internal IReadOnlyList<KeyValuePair<string, IOCOBFNPIHJ>> IKDKAOFMCJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x3F36150", Offset = "0x3F34D50", VA = "0x183F36150")]
			internal int BAHBMDHDAHB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x3F362A0", Offset = "0x3F34EA0", VA = "0x183F362A0")]
			internal void HEOAKBAGILD(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x3F36590", Offset = "0x3F35190", VA = "0x183F36590")]
			internal void LPEIJLBOFFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x3F366F0", Offset = "0x3F352F0", VA = "0x183F366F0")]
			internal float PHCPJOPKBPO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x3F364D0", Offset = "0x3F350D0", VA = "0x183F364D0")]
			internal void JLFDHCHCCLK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x3F36100", Offset = "0x3F34D00", VA = "0x183F36100")]
			internal float AJJOPLNMKLM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3F36630", Offset = "0x3F35230", VA = "0x183F36630")]
			internal void PGHPEBPAMGC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3F365E0", Offset = "0x3F351E0", VA = "0x183F365E0")]
			internal float NDDJDGNIDDI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3F36040", Offset = "0x3F34C40", VA = "0x183F36040")]
			internal void AIDMFKGBLIC(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D2EB0", Offset = "0x8D1AB0", VA = "0x1808D2EB0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public abstract DIBKLHJNJMH BEPHDELLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "119")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x369C0F0", Offset = "0x369ACF0", VA = "0x18369C0F0")]
		public FOGNFHOCLFD(NKBDFFBLNPL KKJDCIPMCCK, T FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x369B900", Offset = "0x369A500", VA = "0x18369B900", Slot = "115")]
		protected sealed override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class JCKKKJFNPEF : IPBOBBOKBDL<PMHPHDGJNND>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8D2EC0", Offset = "0x8D1AC0", VA = "0x1808D2EC0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA790", Offset = "0x1DC9390", VA = "0x181DCA790")]
		public JCKKKJFNPEF(NKBDFFBLNPL KKJDCIPMCCK, PMHPHDGJNND FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class FMLNJKABCOD : FOGNFHOCLFD<JNIECGGLLMA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override DIBKLHJNJMH BEPHDELLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "119")]
			get
			{
				return default(DIBKLHJNJMH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC53A0", Offset = "0x1DC3FA0", VA = "0x181DC53A0")]
		public FMLNJKABCOD(NKBDFFBLNPL KKJDCIPMCCK, JNIECGGLLMA GAFLMOIGPJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class CMLNFLMOHFC : HGBKJDNNGHB<KKPKEAHCBLC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC32A0", Offset = "0x1DC1EA0", VA = "0x181DC32A0")]
		public CMLNFLMOHFC(NKBDFFBLNPL KKJDCIPMCCK, KKPKEAHCBLC FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class IFOLMDEIIJM : HGBKJDNNGHB<LNCIEKMGDDD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC95B0", Offset = "0x1DC81B0", VA = "0x181DC95B0")]
		public IFOLMDEIIJM(NKBDFFBLNPL KKJDCIPMCCK, LNCIEKMGDDD FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class BICNEICKBBB : IDIOPLFMFJL<EDFPHEHOKEP>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class OLJOCDEPDME
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public OLJOCDEPDME <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x1DD9B20", Offset = "0x1DD8720", VA = "0x181DD9B20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public BICNEICKBBB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public OLJOCDEPDME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8B60", Offset = "0x1DD7760", VA = "0x181DD8B60")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void BDDBOMDCACH(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2560", Offset = "0x1DC1160", VA = "0x181DC2560")]
		public BICNEICKBBB(NKBDFFBLNPL KKJDCIPMCCK, EDFPHEHOKEP GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2280", Offset = "0x1DC0E80", VA = "0x181DC2280", Slot = "119")]
		protected override void KGGCHHGMJDG(PLLNFKHEGMD CLADIKHOOAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class MBHAHAAKLDL : FOGNFHOCLFD<MOGCDBIANMF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override DIBKLHJNJMH BEPHDELLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x92F620", Offset = "0x92E220", VA = "0x18092F620", Slot = "119")]
			get
			{
				return default(DIBKLHJNJMH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF060", Offset = "0x1DCDC60", VA = "0x181DCF060")]
		public MBHAHAAKLDL(NKBDFFBLNPL KKJDCIPMCCK, MOGCDBIANMF GAFLMOIGPJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class MDNDENENDFE : IPBOBBOKBDL<MBLDGABANCP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xC4E660", Offset = "0xC4D260", VA = "0x180C4E660", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF0C0", Offset = "0x1DCDCC0", VA = "0x181DCF0C0")]
		public MDNDENENDFE(NKBDFFBLNPL KKJDCIPMCCK, MBLDGABANCP FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class GJCEMJPFINH : IPBOBBOKBDL<KBFKJJMAKIE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Dictionary<string, IOCOBFNPIHJ> FMNPCPPAGLN;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public sealed override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public sealed override bool HCMEGIOHEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected sealed override bool NDDDNFOBDII
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC62E0", Offset = "0x1DC4EE0", VA = "0x181DC62E0")]
		public GJCEMJPFINH(NKBDFFBLNPL KKJDCIPMCCK, KBFKJJMAKIE FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6010", Offset = "0x1DC4C10", VA = "0x181DC6010", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6240", Offset = "0x1DC4E40", VA = "0x181DC6240")]
		private int BCIKLLBJDKP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6280", Offset = "0x1DC4E80", VA = "0x181DC6280")]
		private void KIJCOCECOMI(int DIOIMJEHEHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class CABCLEIPLBA : IDIOPLFMFJL<FMOFKGGGPCM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1DC28C0", Offset = "0x1DC14C0", VA = "0x181DC28C0")]
		public CABCLEIPLBA(NKBDFFBLNPL KKJDCIPMCCK, FMOFKGGGPCM FJKJNIMGBPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class IDIOPLFMFJL<TVariableNode> : IPBOBBOKBDL<TVariableNode> where TVariableNode : notnull, FMOFKGGGPCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class KGPLNEHILMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public IDIOPLFMFJL<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public KGPLNEHILMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3B71430", Offset = "0x3B70030", VA = "0x183B71430")]
			internal bool IKDKAOFMCJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3B71320", Offset = "0x3B6FF20", VA = "0x183B71320")]
			internal void BAHBMDHDAHB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x3B713E0", Offset = "0x3B6FFE0", VA = "0x183B713E0")]
			internal bool HEOAKBAGILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3B71480", Offset = "0x3B70080", VA = "0x183B71480")]
			internal void LPEIJLBOFFD(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x3B71540", Offset = "0x3B70140", VA = "0x183B71540")]
			internal bool PHCPJOPKBPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class EMCKANNOEPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public KFOAEGJFKOB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public IDIOPLFMFJL<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public EMCKANNOEPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x3349E80", Offset = "0x3348A80", VA = "0x183349E80")]
			internal void BDDBOMDCACH(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override NodeVisualizationKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x91E950", Offset = "0x91D550", VA = "0x18091E950", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override BOBGKCEJNDN BDNMPKJKHID
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x392E4F0", Offset = "0x392D0F0", VA = "0x18392E4F0", Slot = "89")]
			get
			{
				return default(BOBGKCEJNDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x392E380", Offset = "0x392CF80", VA = "0x18392E380")]
		protected IDIOPLFMFJL(NKBDFFBLNPL KKJDCIPMCCK, TVariableNode FJKJNIMGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x392DDD0", Offset = "0x392C9D0", VA = "0x18392DDD0", Slot = "83")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x392D950", Offset = "0x392C550", VA = "0x18392D950", Slot = "115")]
		protected override void ADABGILEALH(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x392E010", Offset = "0x392CC10", VA = "0x18392E010", Slot = "119")]
		protected virtual void KGGCHHGMJDG(PLLNFKHEGMD CLADIKHOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x392DF30", Offset = "0x392CB30", VA = "0x18392DF30", Slot = "100")]
		public override void KEPEANOIAHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDF20", Offset = "0x1DCCB20", VA = "0x181DCDF20")]
	internal static HHOAODFCJBD CIGBOGDFGOD(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class EDACNPFJENE : HLODBMFDKOO, CBMLFMNCMPG, DPPEIKPKKKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public FEAGCKDELFK<FPAAFDFINNL> HKPBEENOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xDB7620", Offset = "0xDB6220", VA = "0x180DB7620", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(FEAGCKDELFK<FPAAFDFINNL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xDB6200", Offset = "0xDB4E00", VA = "0x180DB6200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private FEAGCKDELFK<ELHAJPNIKDG> EOKOGKMIFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1DC43C0", Offset = "0x1DC2FC0", VA = "0x181DC43C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public override FEAGCKDELFK<HHCMNLLLPME> JHAIOAHLPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4380", Offset = "0x1DC2F80", VA = "0x181DC4380", Slot = "19")]
		get
		{
			return default(FEAGCKDELFK<HHCMNLLLPME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1DC43D0", Offset = "0x1DC2FD0", VA = "0x181DC43D0")]
	private EDACNPFJENE(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD, FMLIEPIIFEF LEAOGDMMNNB, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<FPAAFDFINNL> JBAOPGNMBAM, FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM, bool MMPJLAKAIJJ, string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1DC4050", Offset = "0x1DC2C50", VA = "0x181DC4050")]
	public static EDACNPFJENE CIGBOGDFGOD(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD, FMLIEPIIFEF DEILBIIOMKP, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM, FEAGCKDELFK<FPAAFDFINNL> JBAOPGNMBAM, bool MMPJLAKAIJJ, bool JMOANIOPEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xDB6200", Offset = "0xDB4E00", VA = "0x180DB6200")]
	internal void OBALLFMOPFE(FEAGCKDELFK<FPAAFDFINNL> BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class HLODBMFDKOO : DPPEIKPKKKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct KBOAABOKLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private KPINFGDOMBF? AHDFPGCJNDC;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC210", Offset = "0x1DCAE10", VA = "0x181DCC210")]
		public void GEDHBEKABPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC220", Offset = "0x1DCAE20", VA = "0x181DCC220")]
		public KPINFGDOMBF POCKMFONFAF(HLODBMFDKOO CMJLBGPJFAN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	protected readonly ICGBBDONDFF EHNGBHNEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private KBOAABOKLFL EHKNMEEDFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly ANBGKMPJLCA NJBAHAMPEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly List<POCAEJCBBDN> DLOCDMPCFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly List<AIDCCKJMDCK> NMPGIAEDLGE;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<StaticEdge> GIGGCDPFLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9150", Offset = "0x1DC7D50", VA = "0x181DC9150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DisplayKind KFOFEJOEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C01C0", Offset = "0x7BEDC0", VA = "0x1807C01C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public KCDCADLPKIO<GJFGFOEJABF> BPKPHMHNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC87A0", Offset = "0x1DC73A0", VA = "0x181DC87A0", Slot = "6")]
		get
		{
			return default(KCDCADLPKIO<GJFGFOEJABF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public OJBJENBAHJB LGGKDMGLNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x19B9B70", Offset = "0x19B8770", VA = "0x1819B9B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public HJJJAEJHEIF EJKEFAHMBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7F90", Offset = "0x1DC6B90", VA = "0x181DC7F90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	protected KPINFGDOMBF EKJODBBPKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7F90", Offset = "0x1DC6B90", VA = "0x181DC7F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public PortImage LGJDDDJFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8670", Offset = "0x1DC7270", VA = "0x181DC8670", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7B1730", Offset = "0x7B0330", VA = "0x1807B1730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KCDCADLPKIO<BABPFGLJKHJ> LOFCJJCHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1DC92A0", Offset = "0x1DC7EA0", VA = "0x181DC92A0", Slot = "8")]
		get
		{
			return default(KCDCADLPKIO<BABPFGLJKHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FEAGCKDELFK<JNBJANNDBMM> PHOKFHHJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x851630", Offset = "0x850230", VA = "0x180851630", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(FEAGCKDELFK<JNBJANNDBMM>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1867BF0", Offset = "0x18667F0", VA = "0x181867BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public abstract FEAGCKDELFK<HHCMNLLLPME> JHAIOAHLPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9320", Offset = "0x1DC7F20", VA = "0x181DC9320")]
	protected HLODBMFDKOO(NKBDFFBLNPL KKJDCIPMCCK, ICGBBDONDFF FJKJNIMGBPD, ANBGKMPJLCA IDHDCMJFMDO, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, bool MMPJLAKAIJJ, string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8520", Offset = "0x1DC7120", VA = "0x181DC8520", Slot = "20")]
	protected virtual void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1DC81C0", Offset = "0x1DC6DC0", VA = "0x181DC81C0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1DC84C0", Offset = "0x1DC70C0", VA = "0x181DC84C0", Slot = "13")]
	public void GPEOGIKGFOD(POCAEJCBBDN MCDBBPGADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC92C0", Offset = "0x1DC7EC0", VA = "0x181DC92C0", Slot = "14")]
	public void PEGACOOKKAF(AIDCCKJMDCK MCDBBPGADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC87F0", Offset = "0x1DC73F0", VA = "0x181DC87F0", Slot = "15")]
	public void LCAAGKAFPHH(JPOKFENGOKO PNEJKFFOBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1DC90F0", Offset = "0x1DC7CF0", VA = "0x181DC90F0", Slot = "22")]
	protected virtual void OKAANEHKOFJ(JPOKFENGOKO PNEJKFFOBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8030", Offset = "0x1DC6C30", VA = "0x181DC8030")]
	private void DBNKADKGIFI(bool BGBHFDMLCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8310", Offset = "0x1DC6F10", VA = "0x181DC8310")]
	private void FBFOGLBGLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8F40", Offset = "0x1DC7B40", VA = "0x181DC8F40")]
	private void NADMCMKCCDK([In] COGHIDDAGHC JKAJEGFIOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8EE0", Offset = "0x1DC7AE0", VA = "0x181DC8EE0", Slot = "16")]
	public void MPNAFEFKNKO(POCAEJCBBDN MCDBBPGADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8E80", Offset = "0x1DC7A80", VA = "0x181DC8E80", Slot = "17")]
	public void LPKECCJKIDM(AIDCCKJMDCK MCDBBPGADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7B1730", Offset = "0x7B0330", VA = "0x1807B1730")]
	internal void HHFLIBAGJEB(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1DC87D0", Offset = "0x1DC73D0", VA = "0x181DC87D0")]
	internal void KFKKCHLHOFL(AJJLPMAKNEI BNNGNHILECN, OJBJENBAHJB CJEAJMFMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1867BF0", Offset = "0x18667F0", VA = "0x181867BF0")]
	internal void JGPDAKLBBEB(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class NPBOBPPDNAK : NDEPEIEDMDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class NAJLGAIBLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public NKBDFFBLNPL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public ICGBBDONDFF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FEAGCKDELFK<JNBJANNDBMM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NAJLGAIBLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF860", Offset = "0x1DCE460", VA = "0x181DCF860")]
		internal ALNGKPEIOMI EGPBBIBLEBL((int PortDescIndex, int PortIndex, GGEBPMKIDIG InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF7D0", Offset = "0x1DCE3D0", VA = "0x181DCF7D0")]
		internal EDACNPFJENE CMODHAHMFMD(FMLIEPIIFEF i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct OJJHJJBLFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8300", Offset = "0x1DD6F00", VA = "0x181DD8300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8760", Offset = "0x1DD7360", VA = "0x181DD8760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct CKNBNDFMPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public FEAGCKDELFK<HDBJEEHEBJO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2EE0", Offset = "0x1DC1AE0", VA = "0x181DC2EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3230", Offset = "0x1DC1E30", VA = "0x181DC3230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct GFDMENMPNJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public FEAGCKDELFK<ELHAJPNIKDG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5920", Offset = "0x1DC4520", VA = "0x181DC5920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5C70", Offset = "0x1DC4870", VA = "0x181DC5C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct JALDNODFEFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public FEAGCKDELFK<HDBJEEHEBJO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public FEAGCKDELFK<HDBJEEHEBJO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA250", Offset = "0x1DC8E50", VA = "0x181DCA250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA5A0", Offset = "0x1DC91A0", VA = "0x181DCA5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct LMAFGGNIAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public FEAGCKDELFK<ELHAJPNIKDG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public FEAGCKDELFK<ELHAJPNIKDG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEC40", Offset = "0x1DCD840", VA = "0x181DCEC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEF90", Offset = "0x1DCDB90", VA = "0x181DCEF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct JMCANAOIEBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB1C0", Offset = "0x1DC9DC0", VA = "0x181DCB1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB630", Offset = "0x1DCA230", VA = "0x181DCB630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct FBJIHDBBBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4BE0", Offset = "0x1DC37E0", VA = "0x181DC4BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4F30", Offset = "0x1DC3B30", VA = "0x181DC4F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct EPCFMHOJNED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FEAGCKDELFK<HDBJEEHEBJO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4820", Offset = "0x1DC3420", VA = "0x181DC4820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4B70", Offset = "0x1DC3770", VA = "0x181DC4B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct KJMAMHLPBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public FEAGCKDELFK<ELHAJPNIKDG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD340", Offset = "0x1DCBF40", VA = "0x181DCD340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD690", Offset = "0x1DCC290", VA = "0x181DCD690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct EMPEEOHOFAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PAOPNKBLFLK type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public FEAGCKDELFK<HDBJEEHEBJO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4420", Offset = "0x1DC3020", VA = "0x181DC4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC47B0", Offset = "0x1DC33B0", VA = "0x181DC47B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct GFAOACCPNDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NPBOBPPDNAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PAOPNKBLFLK type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public FEAGCKDELFK<ELHAJPNIKDG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private HAOANKFPNCO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5520", Offset = "0x1DC4120", VA = "0x181DC5520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC58B0", Offset = "0x1DC44B0", VA = "0x181DC58B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly bool FPCDNLIJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly bool HBABKFGIONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private FOKPAJJHAME<LNDJCPNFBEL, ALNGKPEIOMI> NNNIPOEKPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private FOKPAJJHAME<LNDJCPNFBEL, HDBLOMJOBNJ> GANIPCCFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly ICGBBDONDFF EHNGBHNEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private FOKPAJJHAME<FPAAFDFINNL, EDACNPFJENE> NOBCDBMFECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private FOKPAJJHAME<FPAAFDFINNL, CBMLFMNCMPG> FJFELIAHJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private string? NHAILLLHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly JLCJKIKLBLB JBPMIFLEOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private FEAGCKDELFK<JNBJANNDBMM> CJEJILMMOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool NMDJHBLMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[CompilerGenerated]
	private Action? IKOGOJOMAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[CompilerGenerated]
	private Action? KLFLKINGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[CompilerGenerated]
	private Action<FEAGCKDELFK<LNDJCPNFBEL>>? DLHOMIEMCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[CompilerGenerated]
	private Action<FEAGCKDELFK<FPAAFDFINNL>>? KEPHNHBLHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[CompilerGenerated]
	private NDEPEIEDMDJ.FMFBFKMIOPF? FFKLLEPCOPK;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool CBIBODKEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6590", Offset = "0x1DD5190", VA = "0x181DD6590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BIFONBOCDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1640", Offset = "0x1DD0240", VA = "0x181DD1640", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool NEKEAJIMFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1E60", Offset = "0x1DD0A60", VA = "0x181DD1E60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KCDCADLPKIO<GJFGFOEJABF> BPKPHMHNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5210", Offset = "0x1DD3E10", VA = "0x181DD5210", Slot = "7")]
		get
		{
			return default(KCDCADLPKIO<GJFGFOEJABF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool JJOIBKCKGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4050", Offset = "0x1DD2C50", VA = "0x181DD4050", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public FOKPAJJHAME<LNDJCPNFBEL, HDBLOMJOBNJ> FEBAFDEMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "9")]
		get
		{
			return default(FOKPAJJHAME<LNDJCPNFBEL, HDBLOMJOBNJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1DD71E0", Offset = "0x1DD5DE0", VA = "0x181DD71E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public KCDCADLPKIO<BABPFGLJKHJ> LOFCJJCHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1DD73E0", Offset = "0x1DD5FE0", VA = "0x181DD73E0", Slot = "11")]
		get
		{
			return default(KCDCADLPKIO<BABPFGLJKHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FOKPAJJHAME<FPAAFDFINNL, CBMLFMNCMPG> FAHACGJJLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "12")]
		get
		{
			return default(FOKPAJJHAME<FPAAFDFINNL, CBMLFMNCMPG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FEAGCKDELFK<JNBJANNDBMM> PHOKFHHJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7B0", Offset = "0xA4B3B0", VA = "0x180A4C7B0", Slot = "13")]
		get
		{
			return default(FEAGCKDELFK<JNBJANNDBMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action MALEDHEMNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5A60", Offset = "0x1DD4660", VA = "0x181DD5A60", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3870", Offset = "0x1DD2470", VA = "0x181DD3870", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action AGFMEMKBMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1DB0", Offset = "0x1DD09B0", VA = "0x181DD1DB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3EE0", Offset = "0x1DD2AE0", VA = "0x181DD3EE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<FEAGCKDELFK<LNDJCPNFBEL>, FEAGCKDELFK<LNDJCPNFBEL>> DOKKNILPOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1DD34B0", Offset = "0x1DD20B0", VA = "0x181DD34B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3690", Offset = "0x1DD2290", VA = "0x181DD3690", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<FEAGCKDELFK<LNDJCPNFBEL>, FEAGCKDELFK<LNDJCPNFBEL>> GHOGKKIIMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3D30", Offset = "0x1DD2930", VA = "0x181DD3D30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3750", Offset = "0x1DD2350", VA = "0x181DD3750", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<FEAGCKDELFK<FPAAFDFINNL>, FEAGCKDELFK<FPAAFDFINNL>> AFFFMHNLBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4C10", Offset = "0x1DD3810", VA = "0x181DD4C10", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5240", Offset = "0x1DD3E40", VA = "0x181DD5240", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FEAGCKDELFK<FPAAFDFINNL>, FEAGCKDELFK<FPAAFDFINNL>> IFBDCDFFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2F90", Offset = "0x1DD1B90", VA = "0x181DD2F90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6860", Offset = "0x1DD5460", VA = "0x181DD6860", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FEAGCKDELFK<LNDJCPNFBEL>, HDBLOMJOBNJ> OLECFADIONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7320", Offset = "0x1DD5F20", VA = "0x181DD7320", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4A20", Offset = "0x1DD3620", VA = "0x181DD4A20", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FEAGCKDELFK<LNDJCPNFBEL>> CNDLNIKCOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3F90", Offset = "0x1DD2B90", VA = "0x181DD3F90", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6920", Offset = "0x1DD5520", VA = "0x181DD6920", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FEAGCKDELFK<LNDJCPNFBEL>, HDBLOMJOBNJ> OIFAPLCLHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5B00", Offset = "0x1DD4700", VA = "0x181DD5B00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1BA0", Offset = "0x1DD07A0", VA = "0x181DD1BA0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FEAGCKDELFK<FPAAFDFINNL>, CBMLFMNCMPG> GKFFOBKPLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1DD33F0", Offset = "0x1DD1FF0", VA = "0x181DD33F0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6BD0", Offset = "0x1DD57D0", VA = "0x181DD6BD0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FEAGCKDELFK<FPAAFDFINNL>> JAHINLFCPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1DD67A0", Offset = "0x1DD53A0", VA = "0x181DD67A0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5880", Offset = "0x1DD4480", VA = "0x181DD5880", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FEAGCKDELFK<FPAAFDFINNL>, CBMLFMNCMPG> BBNKDODFGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6B10", Offset = "0x1DD5710", VA = "0x181DD6B10", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3910", Offset = "0x1DD2510", VA = "0x181DD3910", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7520", Offset = "0x1DD6120", VA = "0x181DD7520")]
	private NPBOBPPDNAK(bool MMPJLAKAIJJ, NKBDFFBLNPL KKJDCIPMCCK, bool LIDFKBEEDAC, FOKPAJJHAME<LNDJCPNFBEL, ALNGKPEIOMI> JGPGHBKGPHA, FOKPAJJHAME<LNDJCPNFBEL, HDBLOMJOBNJ> NOIDKOOOBJH, ICGBBDONDFF FJKJNIMGBPD, FOKPAJJHAME<FPAAFDFINNL, EDACNPFJENE> CKNJLJOOOGI, FOKPAJJHAME<FPAAFDFINNL, CBMLFMNCMPG> MMIJOOBKMHB, string? BCOPCGGLIBE, JLCJKIKLBLB NBFGIEIGIKC, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, bool JMOANIOPEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1F20", Offset = "0x1DD0B20", VA = "0x181DD1F20")]
	public static NPBOBPPDNAK CIGBOGDFGOD(bool MMPJLAKAIJJ, NKBDFFBLNPL KKJDCIPMCCK, bool LIDFKBEEDAC, ICGBBDONDFF FJKJNIMGBPD, JLCJKIKLBLB NBFGIEIGIKC, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, bool JMOANIOPEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD40D0", Offset = "0x1DD2CD0", VA = "0x181DD40D0")]
	private void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2490", Offset = "0x1DD1090", VA = "0x181DD2490", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3DF0", Offset = "0x1DD29F0", VA = "0x181DD3DF0", Slot = "38")]
	[AsyncStateMachine(typeof(OJJHJJBLFMH))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> GHDOMDEHBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1DD39D0", Offset = "0x1DD25D0", VA = "0x181DD39D0")]
	private (EECLONELEPP, int)? GCKEFJEOKIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1DD64A0", Offset = "0x1DD50A0", VA = "0x181DD64A0")]
	private void MCAFOLHLFEF(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x126B3E0", Offset = "0x1269FE0", VA = "0x18126B3E0")]
	private void ONDLDBLLBEK(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1680", Offset = "0x1DD0280", VA = "0x181DD1680")]
	private void ANKMGNMBIFG(int BAIHOGKKKJM, int DMAFOGNDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3810", Offset = "0x1DD2410", VA = "0x181DD3810")]
	private void FKAPKLNPDJC(int BAIHOGKKKJM, int DMAFOGNDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4CD0", Offset = "0x1DD38D0", VA = "0x181DD4CD0")]
	private void JBAAMMCNHFL(int DAOIDCIHNJP, int HACCLAHPIOG, GGEBPMKIDIG HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1A20", Offset = "0x1DD0620", VA = "0x181DD1A20")]
	private void BCIGPMFDEFL(int BGBHFDMLCDN, int HACCLAHPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4970", Offset = "0x1DD3570", VA = "0x181DD4970")]
	private void HFCLLCOCCJO(int BGBHFDMLCDN, int HACCLAHPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6040", Offset = "0x1DD4C40", VA = "0x181DD6040")]
	private void LMDCICKHCHC(int DAOIDCIHNJP, int HACCLAHPIOG, GGEBPMKIDIG HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1C60", Offset = "0x1DD0860", VA = "0x181DD1C60")]
	private void BEMEBPNCAHE(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x958010", Offset = "0x956C10", VA = "0x180958010")]
	private void LIKBIFAAEBF(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4880", Offset = "0x1DD3480", VA = "0x181DD4880")]
	private void HFBGEGIOHPL(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x126B3E0", Offset = "0x1269FE0", VA = "0x18126B3E0")]
	private void COLNMENBENM(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3050", Offset = "0x1DD1C50", VA = "0x181DD3050")]
	private void EMNILMDENGK(int BAIHOGKKKJM, int DMAFOGNDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD49C0", Offset = "0x1DD35C0", VA = "0x181DD49C0")]
	private void HMEHHJJKEPM(int BAIHOGKKKJM, int DMAFOGNDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6C90", Offset = "0x1DD5890", VA = "0x181DD6C90")]
	private void OKPDMFLKLEH(int DAOIDCIHNJP, int HACCLAHPIOG, FMLIEPIIFEF HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1DD56D0", Offset = "0x1DD42D0", VA = "0x181DD56D0")]
	private void JICDCCGLNNC(int BGBHFDMLCDN, int HACCLAHPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5720", Offset = "0x1DD4320", VA = "0x181DD5720")]
	private void JJMPCJBBNBB(int BGBHFDMLCDN, int HACCLAHPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5BC0", Offset = "0x1DD47C0", VA = "0x181DD5BC0")]
	private void KOFMFEKHMBO(int DAOIDCIHNJP, int HACCLAHPIOG, FMLIEPIIFEF HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6650", Offset = "0x1DD5250", VA = "0x181DD6650")]
	private void NLJGBCOHDMJ(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x958010", Offset = "0x956C10", VA = "0x180958010")]
	private void ECCHBCACNAB(int DAOIDCIHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7210", Offset = "0x1DD5E10", VA = "0x181DD7210", Slot = "39")]
	[AsyncStateMachine(typeof(CKNBNDFMPIP))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> OMDIICBLGLL(FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5770", Offset = "0x1DD4370", VA = "0x181DD5770", Slot = "40")]
	[AsyncStateMachine(typeof(GFDMENMPNJC))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> JNKHLNDJECB(FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5940", Offset = "0x1DD4540", VA = "0x181DD5940", Slot = "41")]
	[AsyncStateMachine(typeof(JALDNODFEFH))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> KCDGAHEBCHA(FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ, FEAGCKDELFK<HDBJEEHEBJO> OGPEBOFLBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7400", Offset = "0x1DD6000", VA = "0x181DD7400", Slot = "42")]
	[AsyncStateMachine(typeof(LMAFGGNIAIK))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> PNGOILNDDNK(FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM, FEAGCKDELFK<ELHAJPNIKDG> OGPEBOFLBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1550", Offset = "0x1DD0150", VA = "0x181DD1550", Slot = "43")]
	[AsyncStateMachine(typeof(JMCANAOIEBD))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> AKDKIIDPMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3570", Offset = "0x1DD2170", VA = "0x181DD3570", Slot = "44")]
	[AsyncStateMachine(typeof(FBJIHDBBBGF))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> FEMNBMCELDM(string FOENHCOIAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4AE0", Offset = "0x1DD36E0", VA = "0x181DD4AE0", Slot = "45")]
	[AsyncStateMachine(typeof(EPCFMHOJNED))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> IHBHICJFLMO(FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ, string MPGNMPAPHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1A70", Offset = "0x1DD0670", VA = "0x181DD1A70", Slot = "46")]
	[AsyncStateMachine(typeof(KJMAMHLPBAJ))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> BCLCDIFFJNA(FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM, string MPGNMPAPHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD69E0", Offset = "0x1DD55E0", VA = "0x181DD69E0", Slot = "47")]
	[AsyncStateMachine(typeof(EMPEEOHOFAJ))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> OGLHGPHKMMF(FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ, PAOPNKBLFLK CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3C00", Offset = "0x1DD2800", VA = "0x181DD3C00", Slot = "48")]
	[AsyncStateMachine(typeof(GFAOACCPNDJ))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> GEMDDAKMJFA(FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM, PAOPNKBLFLK CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5300", Offset = "0x1DD3F00", VA = "0x181DD5300")]
	internal void JGPDAKLBBEB(FEAGCKDELFK<JNBJANNDBMM> BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class DIJPCCIGCJH : NINNLLILECB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface FBLLADKFBBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000091")]
		AJJLPMAKNEI ANFGECLKKGI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JCLGJDHLEKN> HCBNJFCBMNH(CancellationToken EJGJLLMBDIN);

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MHLNEPCFHJN> KDLKACGOOEE(CancellationToken EJGJLLMBDIN);

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<MHMDDPIMCBA> HPJMPJADMEI(CancellationToken EJGJLLMBDIN);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct BFPOLEHEODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder<DIJPCCIGCJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public NKBDFFBLNPL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JCLGJDHLEKN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public MHLNEPCFHJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private FBLLADKFBBB <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private MHLNEPCFHJN <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<JCLGJDHLEKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<MHLNEPCFHJN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<MHMDDPIMCBA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<IEJIDNBBAFF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1580", Offset = "0x1DC0180", VA = "0x181DC1580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1FB0", Offset = "0x1DC0BB0", VA = "0x181DC1FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly IEJIDNBBAFF BOELFPMCCCN;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IEJIDNBBAFF LMCHMOBOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	private DIJPCCIGCJH(IEJIDNBBAFF JDJAHHMHGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC3800", Offset = "0x1DC2400", VA = "0x181DC3800")]
	[AsyncStateMachine(typeof(BFPOLEHEODI))]
	public static Task<DIJPCCIGCJH> OCNONELDNGN(NKBDFFBLNPL KKJDCIPMCCK, JCLGJDHLEKN? MAOJLJBOFIK, MHLNEPCFHJN? DNCEPNILLJE, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC37E0", Offset = "0x1DC23E0", VA = "0x181DC37E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct CLPANGMNOAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct ICMIFABKMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public CLPANGMNOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public IDOLLADEHJJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD980", Offset = "0x1DDC580", VA = "0x181DDD980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DDDB80", Offset = "0x1DDC780", VA = "0x181DDDB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct ADKELCIDFJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public GLEDFAMGOCH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public JCLGJDHLEKN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public MHLNEPCFHJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public CLPANGMNOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private IDOLLADEHJJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB1B0", Offset = "0x1DD9DB0", VA = "0x181DDB1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB590", Offset = "0x1DDA190", VA = "0x181DDB590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct LOFKHOBHKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public CLPANGMNOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFE50", Offset = "0x1DDEA50", VA = "0x181DDFE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0090", Offset = "0x1DDEC90", VA = "0x181DE0090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly PDPCABEHLNM CKKMCAMKPKK;

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	public CLPANGMNOAK(PDPCABEHLNM LPACIFPMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBB00", Offset = "0x1DDA700", VA = "0x181DDBB00")]
	[AsyncStateMachine(typeof(ICMIFABKMPA))]
	private Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> CHEEEBNKDNP(IDOLLADEHJJ ODKDNEPMNIA, bool GKKMBFLEHJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBC30", Offset = "0x1DDA830", VA = "0x181DDBC30")]
	[AsyncStateMachine(typeof(ADKELCIDFJB))]
	public Task<DGKNLHNBBJB<bool, BNLEFJJKIPP?>>? OADNHEJDOGM(int BLMCNEELCAF, GLEDFAMGOCH? GFAFHNOFNDA, JCLGJDHLEKN? HCLALOIEKIC, MHLNEPCFHJN? DNCEPNILLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBA10", Offset = "0x1DDA610", VA = "0x181DDBA10")]
	[AsyncStateMachine(typeof(LOFKHOBHKKH))]
	public Task<DGKNLHNBBJB<BABPIFEMKHH, BNLEFJJKIPP>> AIMIAMDLHAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class ODAEPGFLEGP : PKNAPKKEBLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly BINCOJFCOND FPCNODECIKI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BINCOJFCOND NKJJMMJIAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	private ODAEPGFLEGP(BINCOJFCOND MHHODGIKHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2890", Offset = "0x1DE1490", VA = "0x181DE2890")]
	public static ODAEPGFLEGP DPCADENMEMJ(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2A70", Offset = "0x1DE1670", VA = "0x181DE2A70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface LDDLADIBNIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	PMGBIHIMAAN GPCJIAEGCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	DNHALMKOBJA GGNLPLABMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	KHCJANPPIEB OAELMINFFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	KKKNNJHKIFI HFOPOGOLBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	OEIDIKHEEBP OHOFAJIPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface OPKFIBMLNHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	LDDLADIBNIC? ICLOHIDJFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool HLCBICCMHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<LDDLADIBNIC?>? KPFMOCCGPBJ();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CHCLBDJLNOB(NKBDFFBLNPL KKJDCIPMCCK, GLEDFAMGOCH PJOFPMMODID, JCLGJDHLEKN? PDDLKFCNLEI, MHLNEPCFHJN? GJIFCLNMPDO);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DLMFKMJFFCO("IStaticCV2Instance")]
public interface NINNLLILECB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	IEJIDNBBAFF LMCHMOBOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DLMFKMJFFCO("IStaticEVInstance")]
public interface PKNAPKKEBLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	BINCOJFCOND NKJJMMJIAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class LOKFKCJPKKF : EBAEGIIBGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public NBLBNDLPPJL? EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0100", Offset = "0x1DDED00", VA = "0x181DE0100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	internal LOKFKCJPKKF(NKBDFFBLNPL KKJDCIPMCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class KKKNNJHKIFI : NBLBNDLPPJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly NINNLLILECB NMMFPDKNIDE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public NNGHGABOKGP CHEEEBNKDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE540", Offset = "0x1DDD140", VA = "0x181DDE540", Slot = "4")]
		get
		{
			return default(NNGHGABOKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public NIDDGHIFJFC HAMBPOHGOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE4E0", Offset = "0x1DDD0E0", VA = "0x181DDE4E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public KCDCADLPKIO<GJFGFOEJABF> GLJBCMKEEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE3C0", Offset = "0x1DDCFC0", VA = "0x181DDE3C0", Slot = "6")]
		get
		{
			return default(KCDCADLPKIO<GJFGFOEJABF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IEJIDNBBAFF EEJOKPBFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE420", Offset = "0x1DDD020", VA = "0x181DDE420", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public KKKNNJHKIFI(NINNLLILECB FDOBLOMBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE470", Offset = "0x1DDD070", VA = "0x181DDE470")]
	public bool CNIIMGGHEHC([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE470", Offset = "0x1DDD070", VA = "0x181DDE470", Slot = "8")]
	private bool HAIPPHPDPLD([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class JLLLBELBJMI
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDF10", Offset = "0x1DDCB10", VA = "0x181DDDF10")]
	public static OOGNGCJKBIK<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> CDAHLMHJOAH([In] this OOGNGCJKBIK<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>> EDEICIJNMLA)
	{
		return default(OOGNGCJKBIK<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL, KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class CKKIKPDCJPN : NMLJOIAJPDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool HLCBICCMHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB600", Offset = "0x1DDA200", VA = "0x181DDB600", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	internal CKKIKPDCJPN(NKBDFFBLNPL KKJDCIPMCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class PIINIKJDBEM : HJDJALDMILB
{
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4C20", Offset = "0x1DE3820", VA = "0x181DE4C20", Slot = "4")]
	public IKMBCBIFGHL? GKDPAGGBIHF(string? DDGJLFOGKNB, string? DFLKCBMPBPL, string? PHIDEABCGCC, OJNBJHOPKNB.GKFFDGDOKGK.PLBOCBDPPPO IMHCDEDIODD, bool EKDAKEJLMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PIINIKJDBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class DMAOIAPJHCJ : HPBKEHNGBMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct JHIDHGDONFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public AsyncTaskMethodBuilder<BMCGGHHHOPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public DMAOIAPJHCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter<LDDLADIBNIC?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1DDDBF0", Offset = "0x1DDC7F0", VA = "0x181DDDBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DDDEA0", Offset = "0x1DDCAA0", VA = "0x181DDDEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private IReadOnlyList<KCDCADLPKIO<AAMCLGEIBGD>>? AGECFIPBEAC;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BMCGGHHHOPM? EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC2D0", Offset = "0x1DDAED0", VA = "0x181DDC2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public OEIDIKHEEBP? GHLGHFDHJID
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC910", Offset = "0x1DDB510", VA = "0x181DDC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool NNBNHKHMMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBEB0", Offset = "0x1DDAAB0", VA = "0x181DDBEB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool DIIKOKPGILL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBF10", Offset = "0x1DDAB10", VA = "0x181DDBF10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	internal DMAOIAPJHCJ(NKBDFFBLNPL KKJDCIPMCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC1E0", Offset = "0x1DDADE0", VA = "0x181DDC1E0", Slot = "7")]
	[AsyncStateMachine(typeof(JHIDHGDONFB))]
	public Task<BMCGGHHHOPM> KACCCPBGJCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC350", Offset = "0x1DDAF50", VA = "0x181DDC350")]
	internal Dictionary<KCDCADLPKIO<GJFGFOEJABF>, Guid> NBEOLKALPIG(IEnumerable<LJJGPBMCLBA> NJMMBEACHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBF70", Offset = "0x1DDAB70", VA = "0x181DDBF70")]
	public DGKNLHNBBJB<EFOEPDNCLHN, JIEDJHBPKDD> IADLJKDKLPA([In] EFOEPDNCLHN DFJILALNAEB, IEnumerable<LJJGPBMCLBA> OKOKJGBIJME, int GDBOJACJAHO)
	{
		return default(DGKNLHNBBJB<EFOEPDNCLHN, JIEDJHBPKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBE30", Offset = "0x1DDAA30", VA = "0x181DDBE30")]
	internal static MIEHDBHIKBD BGFHOLOCEDK(OAPBHKECBKG LEPAJLDOFBJ, ICGBBDONDFF FJKJNIMGBPD)
	{
		return default(MIEHDBHIKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBE70", Offset = "0x1DDAA70", VA = "0x181DDBE70", Slot = "8")]
	private DGKNLHNBBJB<EFOEPDNCLHN, JIEDJHBPKDD> BIIPDLKAHOP([In] EFOEPDNCLHN DFJILALNAEB, IEnumerable<LJJGPBMCLBA> OKOKJGBIJME, int GDBOJACJAHO)
	{
		return default(DGKNLHNBBJB<EFOEPDNCLHN, JIEDJHBPKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC6C0", Offset = "0x1DDB2C0", VA = "0x181DDC6C0")]
	[CompilerGenerated]
	internal static MIEHDBHIKBD NHNMALLHCEB(OAPBHKECBKG GEGPMBGNDPL, ICGBBDONDFF BCMPDEBALEL)
	{
		return default(MIEHDBHIKBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class OEIDIKHEEBP : BMCGGHHHOPM
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class MCCLEKICCCH
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class LPHKHDJBNCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public IEJIDNBBAFF state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public GADCIAEBIHE spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public LPHKHDJBNCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x1DE0210", Offset = "0x1DDEE10", VA = "0x181DE0210")]
			internal bool FOGEMEEPHAE(ENJPPALBKFP n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class LBHJBBHDPFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public LBHJBBHDPFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1DDFBD0", Offset = "0x1DDE7D0", VA = "0x181DDFBD0")]
			internal void CNHLNOJEMHH(ENJPPALBKFP n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1460", Offset = "0x1DE0060", VA = "0x181DE1460")]
		public static DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD> EDEDADACBKL(OEIDIKHEEBP NOLNJDLEMAA, [In] BMCGGHHHOPM.LFINGBIIOHI PELDJLKMCIK)
		{
			return default(DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0300", Offset = "0x1DDEF00", VA = "0x181DE0300")]
		internal static DGKNLHNBBJB<(EJCIKAEGJJJ, LGJMLAIFAOL), BNLEFJJKIPP> CHBMGODLCCP(OEIDIKHEEBP NOLNJDLEMAA, LGJMLAIFAOL BBMEPHCJOAA, bool BDKBLJGBGOK, [In] KCDCADLPKIO<GJFGFOEJABF> HJLDDFGLPKN, [In] int? HPGIOMLDMMO, [In] MIEHDBHIKBD? INMICBELOCN, [In] MIEHDBHIKBD? IMDKFNAMJNH)
		{
			return default(DGKNLHNBBJB<(EJCIKAEGJJJ, LGJMLAIFAOL), BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE19A0", Offset = "0x1DE05A0", VA = "0x181DE19A0")]
		private static void JHLFCFCKGDJ(bool BDKBLJGBGOK, LJJGPBMCLBA AIAFICPGPCD, EJCIKAEGJJJ DPDBPMDLCCI, [In] KCDCADLPKIO<GJFGFOEJABF> HJLDDFGLPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1050", Offset = "0x1DDFC50", VA = "0x181DE1050")]
		public static void CPGCGKAFDJF(FGINFIMJKMF JFPGGIAEDGN, [In] BMCGGHHHOPM.OPPJFFCIAJE HHBDJIGDICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1E30", Offset = "0x1DE0A30", VA = "0x181DE1E30")]
		[CompilerGenerated]
		internal static bool KEANEGOPOCL(IEJIDNBBAFF OLNGHOCNGHK, GADCIAEBIHE JJFFNBAONFM, ENJPPALBKFP EEGBBCLIPPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly NKBDFFBLNPL IPAOAOOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly NINNLLILECB NMMFPDKNIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly PKNAPKKEBLL MPLEJKHGIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly FLMCACOPFIA KJGDEGGCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly DMAOIAPJHCJ FKGLKPIGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private Dictionary<KCDCADLPKIO<BABPFGLJKHJ>, HHOAODFCJBD> CKCOKDHLOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[CompilerGenerated]
	private Action<KCDCADLPKIO<BABPFGLJKHJ>>? GMHLJPPNCKO;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE48B0", Offset = "0x1DE34B0", VA = "0x181DE48B0")]
	public OEIDIKHEEBP(NKBDFFBLNPL KKJDCIPMCCK, NINNLLILECB FDOBLOMBDPM, PKNAPKKEBLL EKANANBNHBN, DMAOIAPJHCJ POPIBAGAFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3590", Offset = "0x1DE2190", VA = "0x181DE3590")]
	public HHOAODFCJBD? JOHLEBOKFDG([In] KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2A90", Offset = "0x1DE1690", VA = "0x181DE2A90")]
	private void BBOJCINHMLP(KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2E20", Offset = "0x1DE1A20", VA = "0x181DE2E20")]
	private HHOAODFCJBD? GDCNLGCDKJJ([In] KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE34A0", Offset = "0x1DE20A0", VA = "0x181DE34A0")]
	public ICGBBDONDFF? JLMBONAEEMF([In] KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2D80", Offset = "0x1DE1980", VA = "0x181DE2D80")]
	public BJNJFINEDCC? DBOGBPAAJBM([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2CE0", Offset = "0x1DE18E0", VA = "0x181DE2CE0")]
	private GADCIAEBIHE? CAKJIFIOMCN([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2D80", Offset = "0x1DE1980", VA = "0x181DE2D80")]
	private BJNJFINEDCC? MNFKLHFBMAE([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2B10", Offset = "0x1DE1710", VA = "0x181DE2B10", Slot = "6")]
	public IEnumerable<PAOPNKBLFLK> BGNDALNFAPA(KHLDDJEHCCP GEDPANMBDKA, bool HNIKGBAPOCD, bool GOIBOEAHLNH, bool GAMHIPBLDFC, bool NKJEHLGMDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3350", Offset = "0x1DE1F50", VA = "0x181DE3350")]
	public DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD> HMBPLDKFEDG([In] BMCGGHHHOPM.LFINGBIIOHI PELDJLKMCIK)
	{
		return default(DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2F60", Offset = "0x1DE1B60", VA = "0x181DE2F60", Slot = "8")]
	public DGKNLHNBBJB<OELLLENMAFD, JIEDJHBPKDD> HDJBMICPCPD(KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC, OELLLENMAFD HEOAPOIKFGF, IACENOBNHPJ NOKPKLNILBE)
	{
		return default(DGKNLHNBBJB<OELLLENMAFD, JIEDJHBPKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3DC0", Offset = "0x1DE29C0", VA = "0x181DE3DC0", Slot = "9")]
	public DJHLGIIKPNM NENDNDBHMGP(IEnumerable<LJJGPBMCLBA> OKOKJGBIJME)
	{
		return default(DJHLGIIKPNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3380", Offset = "0x1DE1F80", VA = "0x181DE3380", Slot = "10")]
	public DJHLGIIKPNM JEHJPDEFAPL()
	{
		return default(DJHLGIIKPNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3B90", Offset = "0x1DE2790", VA = "0x181DE3B90")]
	private HMPOMBFBNFD LIIPBGMJKAG(DOLHPJCJCMG ELDJDPNANDM, FEAGCKDELFK<GJFGFOEJABF> ODHPDBMLIDC, IEnumerable<KCDCADLPKIO<GJFGFOEJABF>> MNIBGGMMNGB, IEnumerable<KCDCADLPKIO<BABPFGLJKHJ>> MCFKDFBEMIC)
	{
		return default(HMPOMBFBNFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3850", Offset = "0x1DE2450", VA = "0x181DE3850", Slot = "11")]
	public HMPOMBFBNFD LIIPBGMJKAG(DOLHPJCJCMG ELDJDPNANDM, FEAGCKDELFK<GJFGFOEJABF> ODHPDBMLIDC, IEnumerable<KCDCADLPKIO<BABPFGLJKHJ>> MCFKDFBEMIC, IEnumerable<LJJGPBMCLBA> OKOKJGBIJME)
	{
		return default(HMPOMBFBNFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4530", Offset = "0x1DE3130", VA = "0x181DE4530")]
	private static IEnumerable<KCDCADLPKIO<GJFGFOEJABF>> PLGGMOOOGOE(IEnumerable<LJJGPBMCLBA> OKOKJGBIJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3FB0", Offset = "0x1DE2BB0", VA = "0x181DE3FB0")]
	private IEnumerable<KCDCADLPKIO<BABPFGLJKHJ>> NEPMPGBNHME(IEnumerable<LJJGPBMCLBA> OKOKJGBIJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2ED0", Offset = "0x1DE1AD0", VA = "0x181DE2ED0", Slot = "12")]
	public List<MIFEIEBAKCI> GLBLOPGKIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4460", Offset = "0x1DE3060", VA = "0x181DE4460", Slot = "13")]
	public bool OGMCKMABCHM(FEAGCKDELFK<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2C80", Offset = "0x1DE1880", VA = "0x181DE2C80")]
	internal void BOGDDHHKCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3530", Offset = "0x1DE2130", VA = "0x181DE3530")]
	internal Task JMFKEPNAAPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2D80", Offset = "0x1DE1980", VA = "0x181DE2D80", Slot = "4")]
	private BJNJFINEDCC IEPPGNFHJLM([In] KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3700", Offset = "0x1DE2300", VA = "0x181DE3700", Slot = "5")]
	private HHOAODFCJBD KOJHLMBEHMO([In] KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3350", Offset = "0x1DE1F50", VA = "0x181DE3350", Slot = "7")]
	private DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD> PODGDCAKCNE([In] BMCGGHHHOPM.LFINGBIIOHI PELDJLKMCIK)
	{
		return default(DGKNLHNBBJB<BMCGGHHHOPM.CPJBPCGCDLF, JIEDJHBPKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3D40", Offset = "0x1DE2940", VA = "0x181DE3D40")]
	[CompilerGenerated]
	private NODEIOMCJMA MBKHIEMKPLL(OJBJENBAHJB CFPNJHJGBGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2C10", Offset = "0x1DE1810", VA = "0x181DE2C10")]
	[CompilerGenerated]
	private ICGBBDONDFF BODMPFLLACM(KCDCADLPKIO<BABPFGLJKHJ> CFPNJHJGBGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2DB0", Offset = "0x1DE19B0", VA = "0x181DE2DB0")]
	[CompilerGenerated]
	private GADCIAEBIHE EDDLMBOFGNA(KCDCADLPKIO<GJFGFOEJABF> CFPNJHJGBGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class NODEIOMCJMA : PAOPNKBLFLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct NPKCDEAGHIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<FEAGCKDELFK<HDBJEEHEBJO>, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NODEIOMCJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public KCDCADLPKIO<GJFGFOEJABF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public KCDCADLPKIO<BABPFGLJKHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public FEAGCKDELFK<JNBJANNDBMM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<DGKNLHNBBJB<FEAGCKDELFK<HDBJEEHEBJO>, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1DE25A0", Offset = "0x1DE11A0", VA = "0x181DE25A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2820", Offset = "0x1DE1420", VA = "0x181DE2820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct GKECPCKMOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<FEAGCKDELFK<ELHAJPNIKDG>, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public NODEIOMCJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public KCDCADLPKIO<GJFGFOEJABF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public KCDCADLPKIO<BABPFGLJKHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FEAGCKDELFK<JNBJANNDBMM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<DGKNLHNBBJB<FEAGCKDELFK<ELHAJPNIKDG>, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD4E0", Offset = "0x1DDC0E0", VA = "0x181DDD4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD760", Offset = "0x1DDC360", VA = "0x181DDD760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly OJBJENBAHJB OOHDIDDEPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly NINNLLILECB NMMFPDKNIDE;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TypeKey NJNNBOCNKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string MDPLIMBMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE9A0", Offset = "0x1DDD5A0", VA = "0x181DDE9A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public OJBJENBAHJB MKPHCNFMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2500", Offset = "0x1DE1100", VA = "0x181DE2500")]
	public NODEIOMCJMA(OJBJENBAHJB KDECOLLMPBH, NINNLLILECB FDOBLOMBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2220", Offset = "0x1DE0E20", VA = "0x181DE2220", Slot = "6")]
	[AsyncStateMachine(typeof(NPKCDEAGHIC))]
	public Task<DGKNLHNBBJB<FEAGCKDELFK<HDBJEEHEBJO>, BNLEFJJKIPP>> GDPHFPHFFOK(KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC, KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, string MPGNMPAPHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2390", Offset = "0x1DE0F90", VA = "0x181DE2390", Slot = "7")]
	[AsyncStateMachine(typeof(GKECPCKMOJF))]
	public Task<DGKNLHNBBJB<FEAGCKDELFK<ELHAJPNIKDG>, BNLEFJJKIPP>> MCNHDNGKAGN(KCDCADLPKIO<GJFGFOEJABF> IDHAMCEFIKC, KCDCADLPKIO<BABPFGLJKHJ> KHDECEICOFI, FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE, string MPGNMPAPHDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class KPINFGDOMBF : HJJJAEJHEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly OJBJENBAHJB BDGBEOEBCPA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly HashSet<OJBJENBAHJB> PEJKOJIKLCP;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly HashSet<OJBJENBAHJB> IHFJNJOMIDJ;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly HashSet<OJBJENBAHJB> PCJBGLICBBL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TypeKey BKEHFHLBEND
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFA60", Offset = "0x1DDE660", VA = "0x181DDFA60", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool FPIIFKBNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFA50", Offset = "0x1DDE650", VA = "0x181DDFA50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HOFNPCELHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFAB0", Offset = "0x1DDE6B0", VA = "0x181DDFAB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ENHIMKFDNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF9D0", Offset = "0x1DDE5D0", VA = "0x181DDF9D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE5A0", Offset = "0x1DDD1A0", VA = "0x181DDE5A0")]
	public bool DPJDAFPOBGP(string BLKAHBIJBJO, [Out] FJBPEHODLLG DPGCGKPAGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public KPINFGDOMBF(OJBJENBAHJB GAFLMOIGPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE810", Offset = "0x1DDD410", VA = "0x181DDE810")]
	internal static TypeKey NGHACIPJMLP(OJBJENBAHJB CJEAJMFMNNJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE9A0", Offset = "0x1DDD5A0", VA = "0x181DDE9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct IABOAAPOLHN : BHNIIDLKBFO.OKDNLNKHCOF<IDOLLADEHJJ, BABPIFEMKHH>
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD840", Offset = "0x1DDC440", VA = "0x181DDD840", Slot = "4")]
	public int CHOAMPOLBFL(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD8F0", Offset = "0x1DDC4F0", VA = "0x181DDD8F0", Slot = "5")]
	public IDOLLADEHJJ GPMBGMPIPLL(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD860", Offset = "0x1DDC460", VA = "0x181DDD860", Slot = "6")]
	public IDOLLADEHJJ DAGIFNJLAMO(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD8D0", Offset = "0x1DDC4D0", VA = "0x181DDD8D0", Slot = "7")]
	public IReadOnlyList<IDOLLADEHJJ> ELBADFMBNBH(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD830", Offset = "0x1DDC430", VA = "0x181DDD830", Slot = "8")]
	public IDOLLADEHJJ[] BDDJNCNGPGF(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA, int GGBMDIHGHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD960", Offset = "0x1DDC560", VA = "0x181DDD960", Slot = "9")]
	public bool MBNIGOIJLHF(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD900", Offset = "0x1DDC500", VA = "0x181DDD900", Slot = "10")]
	public bool HLBJHLBGJEF(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD940", Offset = "0x1DDC540", VA = "0x181DDD940", Slot = "11")]
	public bool JJIOBEFBLLL(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD890", Offset = "0x1DDC490", VA = "0x181DDD890", Slot = "12")]
	public bool DPLCIFIJPAE(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD920", Offset = "0x1DDC520", VA = "0x181DDD920", Slot = "13")]
	public bool IINGDCEECDF(BABPIFEMKHH JKPOGACKCLN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD8B0", Offset = "0x1DDC4B0", VA = "0x181DDD8B0", Slot = "14")]
	public bool EENDEKCJGHI(BABPIFEMKHH BGBHFDMLCDN, IDOLLADEHJJ ODKDNEPMNIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class DAFNJONELDA : IKMOPJOGEJD
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public OLLGDFOFBDL.JKMHFOLOLGE EKJHGPFCOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBDE0", Offset = "0x1DDA9E0", VA = "0x181DDBDE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public abstract OJFGCHFAGDN.KMEKLOAJFJB OGENNMAOPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public abstract NKBDFFBLNPL.JGAACLOFCJA ODBMJDJMNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public abstract DIJPCCIGCJH.FBLLADKFBBB JKINHFMDHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KBCJMJJCBAG.DCMBHPCGLIG<CDHFMAMOJHN, IDOLLADEHJJ, NKBDFFBLNPL> HLELLEPCEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBD90", Offset = "0x1DDA990", VA = "0x181DDBD90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public abstract HAOANKFPNCO DPNNKJDLNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public abstract LDJPKEOMMBK CMPIAJDOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract ICPKAGCHLKD AAEFAIDAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract MBGGHHIOJJN MPEFEONNGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract EDOKNHNMOPM CMGIILACMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected DAFNJONELDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class LHCIHOAJMBB : NIDDGHIFJFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct AAPLECLBANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public LHCIHOAJMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public IDOLLADEHJJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1DDAF30", Offset = "0x1DD9B30", VA = "0x181DDAF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB140", Offset = "0x1DD9D40", VA = "0x181DDB140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct CLOJGPMGAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<DEKILCMBKCB, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public LHCIHOAJMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public IReadOnlyList<IDOLLADEHJJ> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB620", Offset = "0x1DDA220", VA = "0x181DDB620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB9A0", Offset = "0x1DDA5A0", VA = "0x181DDB9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly PDPCABEHLNM CKKMCAMKPKK;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public LHCIHOAJMBB(PDPCABEHLNM LPACIFPMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDFBF0", Offset = "0x1DDE7F0", VA = "0x181DDFBF0")]
	[AsyncStateMachine(typeof(AAPLECLBANN))]
	private Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> CHEEEBNKDNP(IDOLLADEHJJ ODKDNEPMNIA, bool GKKMBFLEHJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDFD20", Offset = "0x1DDE920", VA = "0x181DDFD20", Slot = "4")]
	[AsyncStateMachine(typeof(CLOJGPMGAAF))]
	public Task<DGKNLHNBBJB<DEKILCMBKCB, BNLEFJJKIPP>> ELFIOBEJMII(IReadOnlyList<IDOLLADEHJJ> OBCPCGLFBNL, bool GKKMBFLEHJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HEOJELFLAGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	internal JBGDJPPGGAN<MMAKMDPBBPC, IDOLLADEHJJ, NNEANGHGCHK> BDGBEOEBCPA;

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF8F0", Offset = "0x1DCE4F0", VA = "0x181DCF8F0")]
	private HEOJELFLAGM([In] JBGDJPPGGAN<MMAKMDPBBPC, IDOLLADEHJJ, NNEANGHGCHK> POPCIAHGGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD7D0", Offset = "0x1DDC3D0", VA = "0x181DDD7D0")]
	public static HEOJELFLAGM CIGBOGDFGOD()
	{
		return default(HEOJELFLAGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class LCPOBOEEJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static JBGDJPPGGAN<MMAKMDPBBPC, IDOLLADEHJJ, NNEANGHGCHK> KBPHBNBCHKB(this HEOJELFLAGM NOLNJDLEMAA)
	{
		return default(JBGDJPPGGAN<MMAKMDPBBPC, IDOLLADEHJJ, NNEANGHGCHK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct NNEANGHGCHK : NABPMKPMHPA.PNBPKPOBIKM<MMAKMDPBBPC, IDOLLADEHJJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2030", Offset = "0x1DE0C30", VA = "0x181DE2030", Slot = "5")]
	public IDOLLADEHJJ EFKAHGALPDO(MMAKMDPBBPC[] EFBDBJKCMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40")]
	public int FMKOMIABKON([In] MMAKMDPBBPC DLFNGOGDHBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40", Slot = "4")]
	private int GGCOCCALCBE([In] MMAKMDPBBPC JIGGJNIOAFI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct GGLMPHIFHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal EOGFNHMMICL<AHOGAMGDHFP, IDOLLADEHJJ, GGEKMDFOEJM> BDGBEOEBCPA;

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF8F0", Offset = "0x1DCE4F0", VA = "0x181DCF8F0")]
	private GGLMPHIFHAP([In] EOGFNHMMICL<AHOGAMGDHFP, IDOLLADEHJJ, GGEKMDFOEJM> EHFCOBKMFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD480", Offset = "0x1DDC080", VA = "0x181DDD480")]
	public static GGLMPHIFHAP CIGBOGDFGOD()
	{
		return default(GGLMPHIFHAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class EBHIAFCBFON
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static EOGFNHMMICL<AHOGAMGDHFP, IDOLLADEHJJ, GGEKMDFOEJM> KBPHBNBCHKB(this GGLMPHIFHAP NOLNJDLEMAA)
	{
		return default(EOGFNHMMICL<AHOGAMGDHFP, IDOLLADEHJJ, GGEKMDFOEJM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct GGEKMDFOEJM : KLMPDDMAEBO.EFOBIIPCAKP<AHOGAMGDHFP, IDOLLADEHJJ>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40")]
	public int IPLPMMIEOLB([In] AHOGAMGDHFP DLFNGOGDHBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD290", Offset = "0x1DDBE90", VA = "0x181DDD290", Slot = "5")]
	public IDOLLADEHJJ KNGDCGAGFPH(AHOGAMGDHFP[] BNPPGHGCGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40", Slot = "4")]
	private int HEIBBOKMEAC([In] AHOGAMGDHFP DLFNGOGDHBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface HAOANKFPNCO
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJDPBBAKEML([In] DGKNLHNBBJB<BABPIFEMKHH, JIEDJHBPKDD> MGHLKGJFBCD);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class APAEMAMMKJC
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD240", Offset = "0x2DABE40", VA = "0x182DAD240")]
	public static bool MJDPBBAKEML<TOk, TErr>(this HAOANKFPNCO NOLNJDLEMAA, [In] DGKNLHNBBJB<TOk, TErr> MGHLKGJFBCD) where TOk : notnull where TErr : notnull, JIEDJHBPKDD
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface LDJPKEOMMBK
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	EHELCDOJHHH FIJDLKBBIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface ICPKAGCHLKD
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFOLEDMKELE OKGNJEEPCCL(int KIMBDFBIAPF);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface FADBODDDEHG
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface BPABNDMLJMF
{
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INLPPBMHKDJ? FPJHNIMGMGK(FEAGCKDELFK<JNBJANNDBMM> IPBAPBAGANE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface FENFJGCIGIL
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface INLPPBMHKDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FENFJGCIGIL? PEJNDMMCEHA(FEAGCKDELFK<HDBJEEHEBJO> MCLCDEGGGMJ);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FADBODDDEHG? JODFMPPENDC(FEAGCKDELFK<ELHAJPNIKDG> MKJODIMJMLM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface MBGGHHIOJJN
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CDBPMHIGIIB(string BLKAHBIJBJO, string LAMCDJBBCDK);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface EDOKNHNMOPM
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPABNDMLJMF? MHDJBIAIEGI([In] KCDCADLPKIO<AAMCLGEIBGD> EEGLBNKJIKP);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class DNMJILNLHED
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct MOPCOMGLCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int KGAKPAMIIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public JCLGJDHLEKN? GGCJCDMLCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public JCLGJDHLEKN? FCJFFIMKDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public readonly List<IDOLLADEHJJ> GNBOHJPEDFE;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1FE0", Offset = "0x1DE0BE0", VA = "0x181DE1FE0")]
		private MOPCOMGLCMB(int PMIDLPOCCEE, JCLGJDHLEKN? PBEBLLGLGLM, JCLGJDHLEKN? LCNLHMMLMME, List<IDOLLADEHJJ> OBCPCGLFBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE0B20", VA = "0x181DE1F20")]
		public static MOPCOMGLCMB CIGBOGDFGOD()
		{
			return default(MOPCOMGLCMB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly HMLCBAKHNFG<MOPCOMGLCMB> FALBBCGKJBH;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public static DNMJILNLHED EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDCFD0", Offset = "0x1DDBBD0", VA = "0x181DDCFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool EBKCANCADJM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x869490", Offset = "0x868090", VA = "0x180869490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD020", Offset = "0x1DDBC20", VA = "0x181DDD020")]
	public void OAMDIIBLKEL(IEJIDNBBAFF LCNLHMMLMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCCD0", Offset = "0x1DDB8D0", VA = "0x181DDCCD0")]
	public void GFKBFGCPMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC990", Offset = "0x1DDB590", VA = "0x181DDC990")]
	private static string? DDGFGOKFICK([In] MOPCOMGLCMB DDAMHJGGJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD1E0", Offset = "0x1DDBDE0", VA = "0x181DDD1E0")]
	public DNMJILNLHED()
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
