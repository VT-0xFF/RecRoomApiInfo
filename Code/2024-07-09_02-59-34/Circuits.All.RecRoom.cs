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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9BE50", Offset = "0x1F9AA50", VA = "0x181F9BE50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BBMNOHIFAAA : IDisposable, GHAFFEAFAAP, CAIDNILOMBP, JOBMNDNEHNA, NNBANJIHNEK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FPPJHKLMNLG : CBBEMDJIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int IGHCGLGDJGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F94150", Offset = "0x1F92D50", VA = "0x181F94150", Slot = "5")]
		public GHBFLECAIHO FPKPIPFIEAH(KBLFFLEDDJB.OJPPPELGEIB EIDBKEEIBKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void EMCONJPEGID();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LDMKBLKIOHH();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F94110", Offset = "0x1F92D10", VA = "0x181F94110", Slot = "13")]
		public virtual void AABNMKHDLHK(BBMNOHIFAAA NKENJJKCCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F942A0", Offset = "0x1F92EA0", VA = "0x181F942A0", Slot = "14")]
		public virtual void OCNADHOACLL(BBMNOHIFAAA NKENJJKCCKI, JPJAJOPEHEI OBNFAOABLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		protected FPPJHKLMNLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CBBEMDJIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int IGHCGLGDJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GHBFLECAIHO FPKPIPFIEAH(KBLFFLEDDJB.OJPPPELGEIB EIDBKEEIBKK);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EMCONJPEGID();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LDMKBLKIOHH();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AABNMKHDLHK(BBMNOHIFAAA NKENJJKCCKI);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OCNADHOACLL(BBMNOHIFAAA NKENJJKCCKI, JPJAJOPEHEI OBNFAOABLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BIKLJPHOCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CJGFMHCFEOM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> IALPLOJEIIA;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1F87B90", Offset = "0x1F86790", VA = "0x181F87B90")]
		internal BIKLJPHOCFP(CJGFMHCFEOM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> JPJGGLNFIBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ICHNBGOCAKF : EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ICHNBGOCAKF NKKNEDDGFMP;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		private ICHNBGOCAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB85A80", Offset = "0xB84680", VA = "0x180B85A80", Slot = "4")]
		public IFBAEMJBHPI JCBOPKMJJBK(JPJAJOPEHEI ENEDBNLKLJL)
		{
			return default(IFBAEMJBHPI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F954B0", Offset = "0x1F940B0", VA = "0x181F954B0", Slot = "5")]
		public void AABNMKHDLHK(BBMNOHIFAAA LNPGMAMPBAC, JPJAJOPEHEI OBNFAOABLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F955B0", Offset = "0x1F941B0", VA = "0x181F955B0", Slot = "6")]
		public void OCNADHOACLL(BBMNOHIFAAA LNPGMAMPBAC, JPJAJOPEHEI OBNFAOABLKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LPOCMLDJJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FECEGHFEDAM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> IALPLOJEIIA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A740", Offset = "0x1F99340", VA = "0x181F9A740")]
		internal LPOCMLDJJGH(FECEGHFEDAM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A6F0", Offset = "0x1F992F0", VA = "0x181F9A6F0")]
		public static LPOCMLDJJGH FCDPFGJNKNI()
		{
			return default(LPOCMLDJJGH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct OMFFNBPFFKM : FNJFCDFFKGL.KJFBBPPCJMC<JPJAJOPEHEI, BBMNOHIFAAA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BFHFAPOIOKP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public BBMNOHIFAAA receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JPJAJOPEHEI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OMFFNBPFFKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F873D0", Offset = "0x1F85FD0", VA = "0x181F873D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F875B0", Offset = "0x1F861B0", VA = "0x181F875B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBB0", Offset = "0x8EA7B0", VA = "0x1808EBBB0", Slot = "4")]
		public JCIKKDEFAFO<GKGNBEOPDJJ> LKNIIMAOCAA(BBMNOHIFAAA LFPNEAKNDGE)
		{
			return default(JCIKKDEFAFO<GKGNBEOPDJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DE90", Offset = "0x1F9CA90", VA = "0x181F9DE90", Slot = "5")]
		[AsyncStateMachine(typeof(BFHFAPOIOKP))]
		public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> BHJJDLJNIJH(BBMNOHIFAAA LFPNEAKNDGE, JPJAJOPEHEI OBNFAOABLKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DE70", Offset = "0x1F9CA70", VA = "0x181F9DE70", Slot = "6")]
		public JPJAJOPEHEI[] BCNPLPMIIMF(BBMNOHIFAAA LFPNEAKNDGE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PMPEBHMKDGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BBMNOHIFAAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PLOKGBGAKJA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CELPEAGFFDN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ONEEHEFMPOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EC00", Offset = "0x1F9D800", VA = "0x181F9EC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EE80", Offset = "0x1F9DA80", VA = "0x181F9EE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HHMFOBBGFDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BBMNOHIFAAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F94F30", Offset = "0x1F93B30", VA = "0x181F94F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F951C0", Offset = "0x1F93DC0", VA = "0x181F951C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KJJEFBJFMEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BBMNOHIFAAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F96FD0", Offset = "0x1F95BD0", VA = "0x181F96FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F971B0", Offset = "0x1F95DB0", VA = "0x181F971B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ABFMHEDKLAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public BBMNOHIFAAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public JPJAJOPEHEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F82A80", Offset = "0x1F81680", VA = "0x181F82A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F82C70", Offset = "0x1F81870", VA = "0x181F82C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JAODPPOLNAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public BBMNOHIFAAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F95740", Offset = "0x1F94340", VA = "0x181F95740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F95F30", Offset = "0x1F94B30", VA = "0x181F95F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JCIKKDEFAFO<GKGNBEOPDJJ> GJIJCGGJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BIKLJPHOCFP EPJEJIBBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BGEELBFADOJ IIGEBNCAPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PFMMKIJKAKI CCAAODOMNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly GNOCGBHLCBG NCAIOCAOMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly CPNDPMFCDEK.FOIGMHNMCGI KFDCCFHENLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly LIOMKHAIGOP DFFPHBNDGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KLDEIBNEGKJ IKDLDBBNOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DAHHMFADOBK MDHOKFPMBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18E0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly CCNMDHJKEDF BMBNHGLGFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18E8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JPAGDPNOBJO JGGHLJFMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CFFCHINJDEM DDIKNBJIDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1918")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly BGEELBFADOJ.HMHKNFDDNJK MJHBDBBPKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1920")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly DJFCGLBBEOJ NBDAPGFJEIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BGEELBFADOJ MINFPAEFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F86840", Offset = "0x1F85440", VA = "0x181F86840")]
		get
		{
			return default(BGEELBFADOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal CBBEMDJIHLG CAGHMKMJEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F85D50", Offset = "0x1F84950", VA = "0x181F85D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GHBFLECAIHO HAKBDKOPLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F85DA0", Offset = "0x1F849A0", VA = "0x181F85DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F867A0", Offset = "0x1F853A0", VA = "0x181F867A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool KBHBFBGMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F864B0", Offset = "0x1F850B0", VA = "0x181F864B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F86790", Offset = "0x1F85390", VA = "0x181F86790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KAAHLEJNBJG MJGBPAFFEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F871B0", Offset = "0x1F85DB0", VA = "0x181F871B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OBPEIOJKMCE DNJEOEAHLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F871C0", Offset = "0x1F85DC0", VA = "0x181F871C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IHIPPHIDNHJ OFIEGODEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F871E0", Offset = "0x1F85DE0", VA = "0x181F871E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BOPPOJPFLIO MCJEKEJJEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F871D0", Offset = "0x1F85DD0", VA = "0x181F871D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CPNDPMFCDEK? FKLBCNENDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F86620", Offset = "0x1F85220", VA = "0x181F86620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private NOELHOAKFFF? JIOMNHELHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F86850", Offset = "0x1F85450", VA = "0x181F86850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F86EB0", Offset = "0x1F85AB0", VA = "0x181F86EB0")]
	private BBMNOHIFAAA(GNOCGBHLCBG KMGJPDDKEEH, JCIKKDEFAFO<GKGNBEOPDJJ> KNHDHKABHEK, [In] BIKLJPHOCFP JEAMHPHKKLE, [In] BGEELBFADOJ LONEKOFGFJJ, [In] PFMMKIJKAKI JCBDBBHHIMC, GHBFLECAIHO JKGKEFMMNGK, [In] CPNDPMFCDEK.FOIGMHNMCGI OEEJFINOMEB, BGEELBFADOJ.HMHKNFDDNJK LOCANIMBONF, DJFCGLBBEOJ FJOFIJEOJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F85FA0", Offset = "0x1F84BA0", VA = "0x181F85FA0")]
	public static BBMNOHIFAAA FCDPFGJNKNI(GNOCGBHLCBG EIDBKEEIBKK, [In] GADLBGDNEID AKOCPIFBDOL, OEDPJMFOEMC KGBIMLEKFNB, [In] JHHAJKLAKJF EFHPEEFMHIL, MNLOAGGALNL OBJCGNFGCKM, JCIKKDEFAFO<GKGNBEOPDJJ> KNHDHKABHEK, JCIKKDEFAFO<DJEMPMGDFJN> BEOJPJPAMGM, MKHLLMHPDDG BHLJJBKLEDA, IEJKEOKEAMB MEMHHPBHIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F860E0", Offset = "0x1F84CE0", VA = "0x181F860E0")]
	public static BBMNOHIFAAA FCDPFGJNKNI(GNOCGBHLCBG KMGJPDDKEEH, [In] BGEELBFADOJ LONEKOFGFJJ, [In] PFMMKIJKAKI JCBDBBHHIMC, JCIKKDEFAFO<GKGNBEOPDJJ> KNHDHKABHEK, JCIKKDEFAFO<DJEMPMGDFJN> BEOJPJPAMGM, MKHLLMHPDDG BHLJJBKLEDA, IEJKEOKEAMB MEMHHPBHIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F85DB0", Offset = "0x1F849B0", VA = "0x181F85DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F864C0", Offset = "0x1F850C0", VA = "0x181F864C0")]
	[AsyncStateMachine(typeof(PMPEBHMKDGP))]
	internal Task<NLDGPBPIIJN<bool, MFMODGJHEIL>> HCAJBBPMNJJ(PLOKGBGAKJA FBCBNNIIADI, CELPEAGFFDN LFOIHPGJJCO, ONEEHEFMPOC BJKFDJBGPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F863C0", Offset = "0x1F84FC0", VA = "0x181F863C0")]
	[AsyncStateMachine(typeof(HHMFOBBGFDK))]
	public Task<NLDGPBPIIJN<bool, MFMODGJHEIL>> FPANEBHFKBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F866A0", Offset = "0x1F852A0", VA = "0x181F866A0")]
	[AsyncStateMachine(typeof(KJJEFBJFMEO))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> INEKKFDMCJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F86980", Offset = "0x1F85580", VA = "0x181F86980")]
	internal void MEFOCLKKBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F86E30", Offset = "0x1F85A30", VA = "0x181F86E30")]
	internal FLLFKKECNDP<JPJAJOPEHEI> PMLHFJELGGB([In] MNJIPBFJHLO BJKPADGBGIJ)
	{
		return default(FLLFKKECNDP<JPJAJOPEHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F86B90", Offset = "0x1F85790", VA = "0x181F86B90")]
	internal bool MIJKFFFJCLI([In] MNJIPBFJHLO BJKPADGBGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F867C0", Offset = "0x1F853C0", VA = "0x181F867C0")]
	internal FLLFKKECNDP<JPJAJOPEHEI> KEOLALFNHHN([In] JCBFHOPKKBH OBNLDOPFHHI)
	{
		return default(FLLFKKECNDP<JPJAJOPEHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F86D20", Offset = "0x1F85920", VA = "0x181F86D20")]
	[AsyncStateMachine(typeof(ABFMHEDKLAC))]
	internal Task<NLDGPBPIIJN<object, MFMODGJHEIL>> PFAHALJFMDO(JPJAJOPEHEI OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F859C0", Offset = "0x1F845C0", VA = "0x181F859C0")]
	private JPJAJOPEHEI[] BCNPLPMIIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F86C00", Offset = "0x1F85800", VA = "0x181F86C00")]
	[AsyncStateMachine(typeof(JAODPPOLNAM))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> NGFPDJBBHOM(Guid DNIOBFKALPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EKGAMEFJNMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29E5CF0", Offset = "0x29E48F0", VA = "0x1829E5CF0")]
	public static CFGHMGDDHCJ<(TPrev?, BBMNOHIFAAA?), NOELHOAKFFF> EBCKOOMKBLL<TPrev>([In] this CFGHMGDDHCJ<TPrev, BBMNOHIFAAA> ENEDBNLKLJL)
	{
		return default(CFGHMGDDHCJ<(TPrev, BBMNOHIFAAA), NOELHOAKFFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29E5FB0", Offset = "0x29E4BB0", VA = "0x1829E5FB0")]
	public static CFGHMGDDHCJ<TPrev?, BBMNOHIFAAA?> LFGEHPFPLBL<TPrev>([In] this CFGHMGDDHCJ<TPrev, BBMNOHIFAAA> ENEDBNLKLJL)
	{
		return default(CFGHMGDDHCJ<TPrev, BBMNOHIFAAA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class CIDLAGMOCMM<TData> : LGLBGBDJHMM, OOBHHCEIIGB, MLPOHKBMKMA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ABKJIOOEHEB<BKMEFFNPIFK>? KPKANCEBNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string MPIOCLAPHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData COKNLHIJAIB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ABKJIOOEHEB<BKMEFFNPIFK>? GIDCMJLDCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21B9A00", Offset = "0x21B8600", VA = "0x1821B9A00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5588650", Offset = "0x5587250", VA = "0x185588650")]
	internal CIDLAGMOCMM([In] ABKJIOOEHEB<BKMEFFNPIFK>? GECFBAGGOKO, JCIKKDEFAFO<FAPNLCLMADD>? DPDGPJGPJID, IOKind? NNLJOJHMNCJ, string NKAJDDICLFH, [In] TData JGFKFMMOAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CJKEFNLFCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F88300", Offset = "0x1F86F00", VA = "0x181F88300")]
	public static NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB> CLLCCKIGPOC([In] this CCHHMJILNMB<BMIKLNMFAEC> PMCCLIKCKGM)
	{
		return default(NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29569D0", Offset = "0x29555D0", VA = "0x1829569D0")]
	public static NLDGPBPIIJN<TOk, OOBHHCEIIGB> LCCFKBBJNOO<TOk>([In] this NLDGPBPIIJN<TOk, OOBHHCEIIGB> ENEDBNLKLJL, [In] ABKJIOOEHEB<BKMEFFNPIFK>? GECFBAGGOKO, JCIKKDEFAFO<FAPNLCLMADD>? DPDGPJGPJID, IOKind? NNLJOJHMNCJ, string NKAJDDICLFH) where TOk : notnull
	{
		return default(NLDGPBPIIJN<TOk, OOBHHCEIIGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GNOCGBHLCBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PBEKNCLALAN.FMEDPOPOLCP HBLDMKJMLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KBLFFLEDDJB.OJPPPELGEIB NHKJKEIJPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BBMNOHIFAAA.CBBEMDJIHLG BEEMDEDJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NBPFHIIMCCH.NBPOAICILHA GFLFOJJICFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA> NAPBDDCMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MLJNEACEOMD GDABNFCLCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CEEEBKLIDGF KKAFDBHFFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OLBPHONICFD ABGCGOJKBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IDNFGABDLMC GKNAKMAEIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GKKOPJCDHIN JPBHIMKDGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BCLMGOHIKCM
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F871F0", Offset = "0x1F85DF0", VA = "0x181F871F0")]
	public static JPJAJOPEHEI CPJCJEPIMKC(this JPJAJOPEHEI ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F87300", Offset = "0x1F85F00", VA = "0x181F87300")]
	public static JPJAJOPEHEI FOAPMMAGGPE(this IABGBPFAPEC ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IABGBPFAPEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BGIGCNMFBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BBMNOHIFAAA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IABGBPFAPEC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F87620", Offset = "0x1F86220", VA = "0x181F87620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F878E0", Offset = "0x1F864E0", VA = "0x181F878E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString JCMGPEFMEMP;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	private IABGBPFAPEC(ByteString IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F95230", Offset = "0x1F93E30", VA = "0x181F95230")]
	public static JPJAJOPEHEI ALKGBDKCLEF(ByteString IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F952F0", Offset = "0x1F93EF0", VA = "0x181F952F0")]
	public static KIHKAALOEMO<IFBAEMJBHPI, IABGBPFAPEC> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, IABGBPFAPEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F953A0", Offset = "0x1F93FA0", VA = "0x181F953A0")]
	[AsyncStateMachine(typeof(BGIGCNMFBNE))]
	public static Task<NLDGPBPIIJN<object, MFMODGJHEIL>> PFAHALJFMDO(BBMNOHIFAAA LNPGMAMPBAC, IABGBPFAPEC ENEDBNLKLJL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NCNNBFNCMKA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B950", Offset = "0x1F9A550", VA = "0x181F9B950")]
	public static JPJAJOPEHEI ALKGBDKCLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BA70", Offset = "0x1F9A670", VA = "0x181F9BA70")]
	public static KIHKAALOEMO<IFBAEMJBHPI, NCNNBFNCMKA> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, NCNNBFNCMKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B9F0", Offset = "0x1F9A5F0", VA = "0x181F9B9F0")]
	public static NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED> DPGHPNGDBLH(BBMNOHIFAAA LNPGMAMPBAC, [In] NCNNBFNCMKA ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PMNPGJIECBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct JMENJCFMJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public BBMNOHIFAAA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PMNPGJIECBE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1F963C0", Offset = "0x1F94FC0", VA = "0x181F963C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F96730", Offset = "0x1F95330", VA = "0x181F96730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly PLOKGBGAKJA? BAMEECLDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly CELPEAGFFDN? GLBGMKGFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly ONEEHEFMPOC? CPFMCMNCKLM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB470", Offset = "0x1EBA070", VA = "0x181EBB470")]
	private PMNPGJIECBE(PLOKGBGAKJA? FBCBNNIIADI, CELPEAGFFDN? LFOIHPGJJCO, ONEEHEFMPOC? BJKFDJBGPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E8B0", Offset = "0x1F9D4B0", VA = "0x181F9E8B0")]
	public static JPJAJOPEHEI? ALKGBDKCLEF(PLOKGBGAKJA? FBCBNNIIADI, CELPEAGFFDN? LFOIHPGJJCO, ONEEHEFMPOC? BJKFDJBGPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E9B0", Offset = "0x1F9D5B0", VA = "0x181F9E9B0")]
	public static KIHKAALOEMO<IFBAEMJBHPI, PMNPGJIECBE> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, PMNPGJIECBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EAC0", Offset = "0x1F9D6C0", VA = "0x181F9EAC0")]
	[AsyncStateMachine(typeof(JMENJCFMJEF))]
	public static Task<NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED>> PFAHALJFMDO(BBMNOHIFAAA LNPGMAMPBAC, PMNPGJIECBE ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FPLFIKAOFDK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LFOBCOFHGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FPLFIKAOFDK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BBMNOHIFAAA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private NLDGPBPIIJN<object, MLPOHKBMKMA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private NLDGPBPIIJN<object, MLPOHKBMKMA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private NLDGPBPIIJN<object, MLPOHKBMKMA>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F97B30", Offset = "0x1F96730", VA = "0x181F97B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F97F90", Offset = "0x1F96B90", VA = "0x181F97F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<JPJAJOPEHEI> EHCOKHDCJPC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	private FPLFIKAOFDK(IReadOnlyList<JPJAJOPEHEI> KFCIDPMFGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F93E70", Offset = "0x1F92A70", VA = "0x181F93E70")]
	public static JPJAJOPEHEI ALKGBDKCLEF(IReadOnlyList<JPJAJOPEHEI> KFCIDPMFGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F93F30", Offset = "0x1F92B30", VA = "0x181F93F30")]
	public static KIHKAALOEMO<IFBAEMJBHPI, FPLFIKAOFDK> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, FPLFIKAOFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F93FD0", Offset = "0x1F92BD0", VA = "0x181F93FD0")]
	[AsyncStateMachine(typeof(LFOBCOFHGBB))]
	public static Task<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> PFAHALJFMDO(BBMNOHIFAAA LNPGMAMPBAC, FPLFIKAOFDK ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JCBFHOPKKBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int NAAONAFFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int ICIBDGPPAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] COKNLHIJAIB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1620", Offset = "0x1AC0220", VA = "0x181AC1620")]
	private JCBFHOPKKBH(int LLHINFJPPOH, int BAEBMIBABAE, byte[] JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F95FA0", Offset = "0x1F94BA0", VA = "0x181F95FA0")]
	public static JPJAJOPEHEI ALKGBDKCLEF(int LLHINFJPPOH, int BAEBMIBABAE, ByteString JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F96280", Offset = "0x1F94E80", VA = "0x181F96280")]
	public static JPJAJOPEHEI[] KKBEMABEJDJ(JPJAJOPEHEI OBNFAOABLKL, int CEBBHDALLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F961A0", Offset = "0x1F94DA0", VA = "0x181F961A0")]
	public static KIHKAALOEMO<IFBAEMJBHPI, JCBFHOPKKBH> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, JCBFHOPKKBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F96080", Offset = "0x1F94C80", VA = "0x181F96080")]
	public static NLDGPBPIIJN<JPJAJOPEHEI, BCBJAFAHBED> DPGHPNGDBLH(BBMNOHIFAAA LNPGMAMPBAC, [In] JCBFHOPKKBH ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<JPJAJOPEHEI, BCBJAFAHBED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MNJIPBFJHLO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MADJLECGPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<bool, BCBJAFAHBED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BBMNOHIFAAA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public MNJIPBFJHLO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private NLDGPBPIIJN<bool, BCBJAFAHBED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, BCBJAFAHBED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A750", Offset = "0x1F99350", VA = "0x181F9A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AD90", Offset = "0x1F99990", VA = "0x181F9AD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int NAAONAFFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int ICIBDGPPAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] COKNLHIJAIB;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1620", Offset = "0x1AC0220", VA = "0x181AC1620")]
	private MNJIPBFJHLO(int LLHINFJPPOH, int BAEBMIBABAE, byte[] JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B460", Offset = "0x1F9A060", VA = "0x181F9B460")]
	public static JPJAJOPEHEI ALKGBDKCLEF(int LLHINFJPPOH, int BAEBMIBABAE, ByteString JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B620", Offset = "0x1F9A220", VA = "0x181F9B620")]
	public static JPJAJOPEHEI?[]? MCAAGAOLBOG(int CEBBHDALLII, PLOKGBGAKJA? FBCBNNIIADI, CELPEAGFFDN? LFOIHPGJJCO, ONEEHEFMPOC? BJKFDJBGPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B540", Offset = "0x1F9A140", VA = "0x181F9B540")]
	public static KIHKAALOEMO<IFBAEMJBHPI, MNJIPBFJHLO> HPPKJNEODOD(JPJAJOPEHEI OEPMJOEEANO)
	{
		return default(KIHKAALOEMO<IFBAEMJBHPI, MNJIPBFJHLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B820", Offset = "0x1F9A420", VA = "0x181F9B820")]
	[AsyncStateMachine(typeof(MADJLECGPOK))]
	public static Task<NLDGPBPIIJN<bool, BCBJAFAHBED>> PFAHALJFMDO(BBMNOHIFAAA LNPGMAMPBAC, MNJIPBFJHLO ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LIOMKHAIGOP : KAAHLEJNBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LGKDFCHJKJA? NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F98070", Offset = "0x1F96C70", VA = "0x181F98070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	internal LIOMKHAIGOP(BBMNOHIFAAA NKENJJKCCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OEABOLLMLCM : LGKDFCHJKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LOOKFBIEHEI FDAPNBOLLEC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	public OEABOLLMLCM(BBMNOHIFAAA NKENJJKCCKI, LOOKFBIEHEI OGGDGFPBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BED0", Offset = "0x1F9AAD0", VA = "0x181F9BED0", Slot = "4")]
	public NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB> EBHGCILHNKN(ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<MHMFPDDJAPK> OMLIBFPFCNI)
	{
		return default(NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C1B0", Offset = "0x1F9ADB0", VA = "0x181F9C1B0", Slot = "5")]
	public NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB> KDHCDNHILEO(ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<MGOHEMMBNJL> NHPBHEJEOBE)
	{
		return default(NLDGPBPIIJN<ELLOCNMODAE, OOBHHCEIIGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PBEKNCLALAN : OMBFHACLEEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface FMEDPOPOLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LOOKFBIEHEI> BKHLPCIMAOM(BBMNOHIFAAA NKENJJKCCKI, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF, CancellationToken PPKBAEMFIMG);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CLKADIAHIMG CGEINDHDEFG(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HFDDGHNIMJI : FMEDPOPOLCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct BIHNBPDANID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<LOOKFBIEHEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public BBMNOHIFAAA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CELPEAGFFDN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public ONEEHEFMPOC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<NBPFHIIMCCH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F87950", Offset = "0x1F86550", VA = "0x181F87950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1F87B20", Offset = "0x1F86720", VA = "0x181F87B20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly HFDDGHNIMJI NKKNEDDGFMP;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		private HFDDGHNIMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F94D30", Offset = "0x1F93930", VA = "0x181F94D30", Slot = "4")]
		[AsyncStateMachine(typeof(BIHNBPDANID))]
		public Task<LOOKFBIEHEI> BKHLPCIMAOM(BBMNOHIFAAA NKENJJKCCKI, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF, CancellationToken PPKBAEMFIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F94E90", Offset = "0x1F93A90", VA = "0x181F94E90", Slot = "5")]
		public CLKADIAHIMG CGEINDHDEFG(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FFGPOLJNKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<PBEKNCLALAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BBMNOHIFAAA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CELPEAGFFDN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ONEEHEFMPOC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PLOKGBGAKJA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private FMEDPOPOLCP <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<LOOKFBIEHEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1F93910", Offset = "0x1F92510", VA = "0x181F93910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F93E00", Offset = "0x1F92A00", VA = "0x181F93E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LOOKFBIEHEI FDAPNBOLLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CLKADIAHIMG EADMADPOOBF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CPNDPMFCDEK FKLBCNENDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E0E0", Offset = "0x1F9CCE0", VA = "0x181F9E0E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NOELHOAKFFF MKDIBELADPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DFC0", Offset = "0x1F9CBC0", VA = "0x181F9DFC0", Slot = "5")]
		get
		{
			return default(NOELHOAKFFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OEABOLLMLCM MCPIJMNNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NNCCPMCMBNH PIHKKAFDPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5DF0", Offset = "0x1DB49F0", VA = "0x181DB5DF0")]
	private PBEKNCLALAN(LOOKFBIEHEI OGGDGFPBCJP, CLKADIAHIMG PIPINPKKNNK, OEABOLLMLCM EJLGHMPHOOO, NNCCPMCMBNH LPAEKDJBKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E130", Offset = "0x1F9CD30", VA = "0x181F9E130")]
	[AsyncStateMachine(typeof(FFGPOLJNKDO))]
	public static Task<PBEKNCLALAN> NNDBAILNMDF(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E080", Offset = "0x1F9CC80", VA = "0x181F9E080", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KBLFFLEDDJB : GHBFLECAIHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface OJPPPELGEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<OMBFHACLEEI> IIFJDDBFKIE(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF, CancellationToken PPKBAEMFIMG);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JMKOJKCLPGD();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LOPKEBEIIEA();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class HAHKCNLNJOH : OJPPPELGEIB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LJPLIIOCBPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<OMBFHACLEEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BBMNOHIFAAA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public PLOKGBGAKJA evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public CELPEAGFFDN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public ONEEHEFMPOC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<PBEKNCLALAN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A0A0", Offset = "0x1F98CA0", VA = "0x181F9A0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9A3E0", Offset = "0x1F98FE0", VA = "0x181F9A3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F94970", Offset = "0x1F93570", VA = "0x181F94970", Slot = "4")]
		[AsyncStateMachine(typeof(LJPLIIOCBPE))]
		public Task<OMBFHACLEEI> IIFJDDBFKIE(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF, CancellationToken PPKBAEMFIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JMKOJKCLPGD();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LOPKEBEIIEA();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		protected HAHKCNLNJOH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JNLIGKJAAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<OMBFHACLEEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KBLFFLEDDJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<HGAAMJINHPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F96880", Offset = "0x1F95480", VA = "0x181F96880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F96A80", Offset = "0x1F95680", VA = "0x181F96A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PCPBANFBHML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KBLFFLEDDJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public BBMNOHIFAAA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PLOKGBGAKJA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CELPEAGFFDN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ONEEHEFMPOC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<OMBFHACLEEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E2A0", Offset = "0x1F9CEA0", VA = "0x181F9E2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E7D0", Offset = "0x1F9D3D0", VA = "0x181F9E7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OJPPPELGEIB PLLBOMGPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<HGAAMJINHPI> JGPDEBLFKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<HGAAMJINHPI> HLJKMKMMPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource POOOMGNEMNA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KBHBFBGMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9D38C0", Offset = "0x9D24C0", VA = "0x1809D38C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA23060", Offset = "0xA21C60", VA = "0x180A23060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FIIEBMHFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4A40", VA = "0x180AE5E40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE5E50", Offset = "0xAE4A50", VA = "0x180AE5E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DFJEMIJDDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10E6E50", Offset = "0x10E5A50", VA = "0x1810E6E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F96C60", Offset = "0x1F95860", VA = "0x181F96C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public OMBFHACLEEI? PEAFDEGCNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86C780", Offset = "0x86B380", VA = "0x18086C780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F96C70", Offset = "0x1F95870", VA = "0x181F96C70", Slot = "7")]
	[AsyncStateMachine(typeof(JNLIGKJAAAL))]
	public Task<OMBFHACLEEI> EKAJIOLJOND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F96EC0", Offset = "0x1F95AC0", VA = "0x181F96EC0")]
	public KBLFFLEDDJB(OJPPPELGEIB EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F96D60", Offset = "0x1F95960", VA = "0x181F96D60", Slot = "8")]
	[AsyncStateMachine(typeof(PCPBANFBHML))]
	public Task MIMBAKGFCMJ(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F96AF0", Offset = "0x1F956F0", VA = "0x181F96AF0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HBJOAEPHBHM : BJBCFKEPKDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NNCCPMCMBNH OAHIHIDDJDJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public HBJOAEPHBHM(NNCCPMCMBNH LPAEKDJBKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class ACIFODLNBLD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class EENALPPABNF<TGraph> : MOAIGMJPFLL where TGraph : MGOMGIBIJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph JPBDFANDDDD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual AJKDPNHPDBC? DCIMKAPNACD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xF1EFA0", Offset = "0xF1DBA0", VA = "0x180F1EFA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public JCIKKDEFAFO<LDNFOKBFEMK> JNBAGJLKCFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x383A0D0", Offset = "0x3838CD0", VA = "0x18383A0D0", Slot = "5")]
			get
			{
				return default(JCIKKDEFAFO<LDNFOKBFEMK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public JCIKKDEFAFO<LDNFOKBFEMK>? AENDLGFBKKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x383A050", Offset = "0x3838C50", VA = "0x18383A050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
		public EENALPPABNF(TGraph MJHKHLBJKPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GMCNEPNFOKF : EENALPPABNF<KOEAPPHDOPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override AJKDPNHPDBC? DCIMKAPNACD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F946C0", Offset = "0x1F932C0", VA = "0x181F946C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F946E0", Offset = "0x1F932E0", VA = "0x181F946E0")]
		public GMCNEPNFOKF(KOEAPPHDOPK GLIMGEKIBID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F82CE0", Offset = "0x1F818E0", VA = "0x181F82CE0")]
	public static MOAIGMJPFLL FCDPFGJNKNI(MGOMGIBIJBN MJHKHLBJKPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AHFNDCJKMDE : DAFLNLPNEEP, GGCDLLOJFMN, BLDDIIOIMMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KKIGPBNNPFA
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
			public KKIGPBNNPFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public MLJNEACEOMD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F9EEF0", Offset = "0x1F9DAF0", VA = "0x181F9EEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F160", Offset = "0x1F9DD60", VA = "0x181F9F160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AHFNDCJKMDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KKIGPBNNPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F97220", Offset = "0x1F95E20", VA = "0x181F97220")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task NPBOOCBFOFK(MLJNEACEOMD errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OKLNGMFEOEJ : IAsyncStateMachine
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
		public AHFNDCJKMDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D910", Offset = "0x1F9C510", VA = "0x181F9D910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DE10", Offset = "0x1F9CA10", VA = "0x181F9DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NOAELGFCCLN
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
			public NOAELGFCCLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F1C0", Offset = "0x1F9DDC0", VA = "0x181F9F1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F4A0", Offset = "0x1F9E0A0", VA = "0x181F9F4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AHFNDCJKMDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NOAELGFCCLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BAE0", Offset = "0x1F9A6E0", VA = "0x181F9BAE0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HKEPJKDMAHO(MLJNEACEOMD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OKPNGBEAJGG NEEGEKDDLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<OJGBKJCMJLH> LMBBFMFFFIJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GNOCGBHLCBG CCLGEEFPAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F834C0", Offset = "0x1F820C0", VA = "0x181F834C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JCIKKDEFAFO<MHMFPDDJAPK> MFAPEBAKHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D00", Offset = "0x8D0900", VA = "0x1808D1D00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(JCIKKDEFAFO<MHMFPDDJAPK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB723A0", Offset = "0xB70FA0", VA = "0x180B723A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private JCIKKDEFAFO<JFMHBEEECHM> ABIIBLAIIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xADC040", Offset = "0xADAC40", VA = "0x180ADC040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JCIKKDEFAFO<BNGCKMJMGMP> POHNAAPJHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x88D530", Offset = "0x88C130", VA = "0x18088D530", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JCIKKDEFAFO<BNGCKMJMGMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override JCIKKDEFAFO<FAPNLCLMADD> KKHOFEODIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F841A0", Offset = "0x1F82DA0", VA = "0x181F841A0", Slot = "20")]
		get
		{
			return default(JCIKKDEFAFO<FAPNLCLMADD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BLGMBCLABLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F85490", Offset = "0x1F84090", VA = "0x181F85490", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F85660", Offset = "0x1F84260", VA = "0x181F85660")]
	private AHFNDCJKMDE(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL, OKPNGBEAJGG CILNJACDEBF, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<MHMFPDDJAPK> OMLIBFPFCNI, JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN, bool MEFBLMPNFJF, string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F83910", Offset = "0x1F82510", VA = "0x181F83910")]
	public static AHFNDCJKMDE FCDPFGJNKNI(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL, OKPNGBEAJGG NGMMAKENIFG, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN, JCIKKDEFAFO<MHMFPDDJAPK> OMLIBFPFCNI, bool MEFBLMPNFJF, bool OCKMJDPMBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F853F0", Offset = "0x1F83FF0", VA = "0x181F853F0", Slot = "21")]
	protected override void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F836D0", Offset = "0x1F822D0", VA = "0x181F836D0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F835B0", Offset = "0x1F821B0", VA = "0x181F835B0", Slot = "30")]
	public void CEJLFFABLIG(OJGBKJCMJLH PPLMPGMOGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F841F0", Offset = "0x1F82DF0", VA = "0x181F841F0", Slot = "27")]
	public void JNHAAEAOAHO(BDIPMIMNPPF KHBOMHIPDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F849E0", Offset = "0x1F835E0", VA = "0x181F849E0", Slot = "28")]
	public void LOJKBDLOBDN(ICMDECFOCAG LLJBLBPEHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F846D0", Offset = "0x1F832D0", VA = "0x181F846D0", Slot = "23")]
	protected override void LEKBFALEFAC(LNCAMHNMJGM EFKJDJMMPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F83090", Offset = "0x1F81C90", VA = "0x181F83090", Slot = "32")]
	public string BCCANBOBFAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F83200", Offset = "0x1F81E00", VA = "0x181F83200", Slot = "29")]
	public string BFOPLJFIIDF(int IJGENGGMLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F83CC0", Offset = "0x1F828C0", VA = "0x181F83CC0")]
	private void GHGFNLBAPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F837C0", Offset = "0x1F823C0", VA = "0x181F837C0", Slot = "31")]
	public void ELNHCFMLINJ(OJGBKJCMJLH PPLMPGMOGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F84820", Offset = "0x1F83420", VA = "0x181F84820")]
	private void LLIGHAGOJIK(bool IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F83EF0", Offset = "0x1F82AF0", VA = "0x181F83EF0", Slot = "33")]
	[AsyncStateMachine(typeof(OKLNGMFEOEJ))]
	public Task ILAAOJGKMAM(string IIPLJLPCLBC, bool PPGMJGIDDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F82F40", Offset = "0x1F81B40", VA = "0x181F82F40")]
	public void APEMLFDJLAH(string IIPLJLPCLBC, bool PPGMJGIDDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F84000", Offset = "0x1F82C00", VA = "0x181F84000")]
	private void IOOCNFDOJDO(int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB723A0", Offset = "0xB70FA0", VA = "0x180B723A0")]
	internal void AIHDDJNCIDG(JCIKKDEFAFO<MHMFPDDJAPK> IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F82E70", Offset = "0x1F81A70", VA = "0x181F82E70")]
	[CompilerGenerated]
	private void ANFJAGMPPFP(string IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F83610", Offset = "0x1F82210", VA = "0x181F83610")]
	[CompilerGenerated]
	private bool DEPOLPMMDHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F855A0", Offset = "0x1F841A0", VA = "0x181F855A0")]
	[CompilerGenerated]
	private bool PNBIJKFNCJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F83770", Offset = "0x1F82370", VA = "0x181F83770")]
	[CompilerGenerated]
	private int GOADDFEIFEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F83880", Offset = "0x1F82480", VA = "0x181F83880")]
	[CompilerGenerated]
	private bool ENPKKCCAAJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F83EE0", Offset = "0x1F82AE0", VA = "0x181F83EE0")]
	[CompilerGenerated]
	private void HHJAHNFOGDN(string IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F82E80", Offset = "0x1F81A80", VA = "0x181F82E80")]
	[CompilerGenerated]
	private bool AOEHDLOKDKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F84680", Offset = "0x1F83280", VA = "0x181F84680")]
	[CompilerGenerated]
	private bool KHMCEOLHCAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F85510", Offset = "0x1F84110", VA = "0x181F85510")]
	[CompilerGenerated]
	private bool OPEPACAPDEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F83770", Offset = "0x1F82370", VA = "0x181F83770")]
	[CompilerGenerated]
	private int EHOKOBPGOGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F834E0", Offset = "0x1F820E0", VA = "0x181F834E0")]
	[CompilerGenerated]
	private bool CEJELIFCHGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F84630", Offset = "0x1F83230", VA = "0x181F84630")]
	[CompilerGenerated]
	private int KDBLJOHADMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F85370", Offset = "0x1F83F70", VA = "0x181F85370")]
	[CompilerGenerated]
	private void NFOCPPMCNHP(object IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F84560", Offset = "0x1F83160", VA = "0x181F84560")]
	[CompilerGenerated]
	private bool JNNPAIIBKJJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OGLHFJOOLII
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MEKFNKBNDIN : HPNHCBBNPHA<OFLBLKJIDNP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override FIKOPHFGBHL HOMKKINNPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8E1570", Offset = "0x8E0170", VA = "0x1808E1570", Slot = "126")]
			get
			{
				return default(FIKOPHFGBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B030", Offset = "0x1F99C30", VA = "0x181F9B030")]
		public MEKFNKBNDIN(BBMNOHIFAAA NKENJJKCCKI, OFLBLKJIDNP JPJGGLNFIBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class FECJHNBLEAD : NMGPAJANPNI<OHEAABMOPFB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F938A0", Offset = "0x1F924A0", VA = "0x181F938A0")]
		public FECJHNBLEAD(BBMNOHIFAAA NKENJJKCCKI, OHEAABMOPFB AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F93720", Offset = "0x1F92320", VA = "0x181F93720", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F936D0", Offset = "0x1F922D0", VA = "0x181F936D0")]
		[CompilerGenerated]
		private bool FGECKHHOKAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F935B0", Offset = "0x1F921B0", VA = "0x181F935B0")]
		[CompilerGenerated]
		private void EJFDGKFKJEL(bool IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class GBBKHDFFJCA : NMGPAJANPNI<DCJNCEGKNBH>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class HDMCDBLACOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public GBBKHDFFJCA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public HDMCDBLACOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F94AD0", Offset = "0x1F936D0", VA = "0x181F94AD0")]
			internal void BJEBONJACJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F94BC0", Offset = "0x1F937C0", VA = "0x181F94BC0")]
			internal bool NJBLCJPFOPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F94B70", Offset = "0x1F93770", VA = "0x181F94B70")]
			internal bool MJDBNIPDNIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F94C10", Offset = "0x1F93810", VA = "0x181F94C10")]
			internal void PBHKKGCIJHM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F94B20", Offset = "0x1F93720", VA = "0x181F94B20")]
			internal bool CFGKMIDNAHJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F94650", Offset = "0x1F93250", VA = "0x181F94650")]
		public GBBKHDFFJCA(BBMNOHIFAAA NKENJJKCCKI, DCJNCEGKNBH AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F94320", Offset = "0x1F92F20", VA = "0x181F94320", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class KOHNGKPKLHB : NMGPAJANPNI<GAEFAMEONAL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BOLJNPOIHFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public KOHNGKPKLHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public BOLJNPOIHFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F87BA0", Offset = "0x1F867A0", VA = "0x181F87BA0")]
			internal object BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F87D10", Offset = "0x1F86910", VA = "0x181F87D10")]
			internal bool FLJOBEJBJOE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F88060", Offset = "0x1F86C60", VA = "0x181F88060")]
			internal void NJBLCJPFOPH(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F87F00", Offset = "0x1F86B00", VA = "0x181F87F00")]
			internal string MJDBNIPDNIP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F882B0", Offset = "0x1F86EB0", VA = "0x181F882B0")]
			internal IReadOnlyList<object> PBHKKGCIJHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F87CA0", Offset = "0x1F868A0", VA = "0x181F87CA0")]
			internal bool CFGKMIDNAHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1F87EB0", Offset = "0x1F86AB0", VA = "0x181F87EB0")]
			internal bool MDDGLBAOAOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F87D90", Offset = "0x1F86990", VA = "0x181F87D90")]
			internal void HBMIICIOFHN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F97A60", Offset = "0x1F96660", VA = "0x181F97A60")]
		public KOHNGKPKLHB(BBMNOHIFAAA NKENJJKCCKI, GAEFAMEONAL AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F97310", Offset = "0x1F95F10", VA = "0x181F97310", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NOHHBGCCCIK : NMGPAJANPNI<CNKKGBCMMHN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class GNDEAJKPLMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public NOHHBGCCCIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public GNDEAJKPLMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1F947B0", Offset = "0x1F933B0", VA = "0x181F947B0")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F94850", Offset = "0x1F93450", VA = "0x181F94850")]
			internal void NJBLCJPFOPH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F94800", Offset = "0x1F93400", VA = "0x181F94800")]
			internal bool MJDBNIPDNIP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BDE0", Offset = "0x1F9A9E0", VA = "0x181F9BDE0")]
		public NOHHBGCCCIK(BBMNOHIFAAA NKENJJKCCKI, CNKKGBCMMHN AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BBB0", Offset = "0x1F9A7B0", VA = "0x181F9BBB0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class BFLCINEOBHL<TNode> : NMGPAJANPNI<TNode> where TNode : notnull, FHKEMOMIDEH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct MEBBFDGCLNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BFLCINEOBHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4476470", Offset = "0x4475070", VA = "0x184476470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4476870", Offset = "0x4475470", VA = "0x184476870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct EFNGMEIFPFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public BFLCINEOBHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x38448D0", Offset = "0x38434D0", VA = "0x1838448D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3844CD0", Offset = "0x38438D0", VA = "0x183844CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool ENADKJJLNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override JCIKKDEFAFO<NKOLEFJCHJO>? GOKCJEALDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4E697F0", Offset = "0x4E683F0", VA = "0x184E697F0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x429CF00", Offset = "0x429BB00", VA = "0x18429CF00")]
		protected BFLCINEOBHL(BBMNOHIFAAA NKENJJKCCKI, TNode AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4E696D0", Offset = "0x4E682D0", VA = "0x184E696D0", Slot = "100")]
		[AsyncStateMachine(typeof(BFLCINEOBHL<>.MEBBFDGCLNP))]
		public override Task<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> LGGGMOCHLEO(string LONKACOOPGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4E693E0", Offset = "0x4E67FE0", VA = "0x184E693E0", Slot = "124")]
		public sealed override bool CDAGJJFDNOK(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4E69480", Offset = "0x4E68080", VA = "0x184E69480", Slot = "112")]
		protected sealed override bool DCEACDKKFDO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4E69520", Offset = "0x4E68120", VA = "0x184E69520", Slot = "113")]
		protected override bool DFOKAPNEMNG(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4E695C0", Offset = "0x4E681C0", VA = "0x184E695C0", Slot = "101")]
		[AsyncStateMachine(typeof(BFLCINEOBHL<>.EFNGMEIFPFO))]
		public override Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> EJDODLOMFHO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class MNFPFEAPDFA : EFBOHHPDNHP<JGJIDDMAHFG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class BBLLCCDLOMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public MNFPFEAPDFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public BBLLCCDLOMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F85880", Offset = "0x1F84480", VA = "0x181F85880")]
			internal bool CHAFAJKMIDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F85900", Offset = "0x1F84500", VA = "0x181F85900")]
			internal void OLFCCCKEFDJ(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B400", Offset = "0x1F9A000", VA = "0x181F9B400")]
		public MNFPFEAPDFA(BBMNOHIFAAA NKENJJKCCKI, JGJIDDMAHFG JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B1B0", Offset = "0x1F99DB0", VA = "0x181F9B1B0", Slot = "126")]
		protected override void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class LEEIIDKBDBL : GPPHMPPDKOB<CKHBDFHCBGK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1F97AD0", Offset = "0x1F966D0", VA = "0x181F97AD0")]
		public LEEIIDKBDBL(BBMNOHIFAAA NKENJJKCCKI, CKHBDFHCBGK AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class GPPHMPPDKOB<TNode> : NMGPAJANPNI<TNode> where TNode : notnull, PCDKOAIPCDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct BDPMOBOICHG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4E68010", Offset = "0x4E66C10", VA = "0x184E68010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4E684C0", Offset = "0x4E670C0", VA = "0x184E684C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FCPEFFBPBEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3C03E50", Offset = "0x3C02A50", VA = "0x183C03E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3C042E0", Offset = "0x3C02EE0", VA = "0x183C042E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct JKIONIANKAP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x40CAFC0", Offset = "0x40C9BC0", VA = "0x1840CAFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x40CB690", Offset = "0x40CA290", VA = "0x1840CB690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class JNDGLEBADII
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
				public JNDGLEBADII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3572B30", Offset = "0x3571730", VA = "0x183572B30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public GADLAGDBJEO configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public JNDGLEBADII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x40D4C20", Offset = "0x40D3820", VA = "0x1840D4C20")]
			internal bool HBMIICIOFHN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x40D4890", Offset = "0x40D3490", VA = "0x1840D4890")]
			internal void BJEBONJACJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x40D4B80", Offset = "0x40D3780", VA = "0x1840D4B80")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.JNDGLEBADII.<<BuildConfigMenuInternal>b__7>d))]
			internal void FLJOBEJBJOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x40D4D00", Offset = "0x40D3900", VA = "0x1840D4D00")]
			internal bool NJBLCJPFOPH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class BIJJKOADOPP
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
				public BIJJKOADOPP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35727B0", Offset = "0x35713B0", VA = "0x1835727B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
			public JNDGLEBADII CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public BIJJKOADOPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4E78EA0", Offset = "0x4E77AA0", VA = "0x184E78EA0")]
			internal void MJDBNIPDNIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			internal string PBHKKGCIJHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
			internal void CFGKMIDNAHJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4E78E00", Offset = "0x4E77A00", VA = "0x184E78E00")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.BIJJKOADOPP.<<BuildConfigMenuInternal>b__5>d))]
			internal void MDDGLBAOAOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class MGOAPFJILAP
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
				public MGOAPFJILAP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x35722E0", Offset = "0x3570EE0", VA = "0x1835722E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
				public MGOAPFJILAP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<JFMHBEEECHM>, MFMODGJHEIL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x35724C0", Offset = "0x35710C0", VA = "0x1835724C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
				public MGOAPFJILAP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<NPNOGIJPNKK>, MFMODGJHEIL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3571C20", Offset = "0x3570820", VA = "0x183571C20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public GADLAGDBJEO configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public GONIPNMLBFC nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public HJEILFHEDJO selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<EHGKEKCMCCF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public HJEILFHEDJO selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<EHGKEKCMCCF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public MGOAPFJILAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x448A600", Offset = "0x4489200", VA = "0x18448A600")]
			internal bool KHDOINIIIGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x448A260", Offset = "0x4488E60", VA = "0x18448A260")]
			internal void ECEILCKLOKK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x448A520", Offset = "0x4489120", VA = "0x18448A520")]
			internal bool KGMKBOHDFLB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x448A390", Offset = "0x4488F90", VA = "0x18448A390")]
			internal bool ELJIBPDHBHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x448A1C0", Offset = "0x4488DC0", VA = "0x18448A1C0")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.MGOAPFJILAP.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void DNDACJECDNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x448A3D0", Offset = "0x4488FD0", VA = "0x18448A3D0")]
			internal bool HFMDIJBGKDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x448A2D0", Offset = "0x4488ED0", VA = "0x18448A2D0")]
			internal void EDHFEJFBODM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x448A040", Offset = "0x4488C40", VA = "0x18448A040")]
			internal bool AKMCOKDHCDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x448A900", Offset = "0x4489500", VA = "0x18448A900")]
			internal void PIGMANGPAAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x448A740", Offset = "0x4489340", VA = "0x18448A740")]
			internal bool NLDGMDOFINH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x448A150", Offset = "0x4488D50", VA = "0x18448A150")]
			internal bool DKNPACJLCIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x448A6D0", Offset = "0x44892D0", VA = "0x18448A6D0")]
			internal void MIFHMLFNFGD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x448A480", Offset = "0x4489080", VA = "0x18448A480")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.MGOAPFJILAP.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void KFMKNHCNHOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x448A0F0", Offset = "0x4488CF0", VA = "0x18448A0F0")]
			internal bool BMADECDGNNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x448A410", Offset = "0x4489010", VA = "0x18448A410")]
			internal bool JKOOPCDAJGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x448A7F0", Offset = "0x44893F0", VA = "0x18448A7F0")]
			internal void OAOCDKLIEIF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x448A860", Offset = "0x4489460", VA = "0x18448A860")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.MGOAPFJILAP.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void ONNKGBOAHNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x448A670", Offset = "0x4489270", VA = "0x18448A670")]
			internal bool LKDJPANLDIL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class PNOEPKFLKPA
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
				public PNOEPKFLKPA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3571F10", Offset = "0x3570B10", VA = "0x183571F10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
			public MGOAPFJILAP CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PNOEPKFLKPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x47AA310", Offset = "0x47A8F10", VA = "0x1847AA310")]
			internal void JMPFNOKNCGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			internal string PJDFPHNKPCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
			internal void ALILGKDLKBO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x47AA270", Offset = "0x47A8E70", VA = "0x1847AA270")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.PNOEPKFLKPA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void DJIENDECKJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class PAGHAFIKCDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public GONIPNMLBFC nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<EHGKEKCMCCF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public GPPHMPPDKOB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PAGHAFIKCDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4756BE0", Offset = "0x47557E0", VA = "0x184756BE0")]
			internal bool KKDJIMMLHIF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class EJNAOKCOCMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public BLDDIIOIMMM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public PAGHAFIKCDK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public EJNAOKCOCMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x384A1A0", VA = "0x18384B5A0")]
			internal void OIIADGJELOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x384B550", Offset = "0x384A150", VA = "0x18384B550")]
			internal bool NHIJDODPHPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x384B3D0", Offset = "0x3849FD0", VA = "0x18384B3D0")]
			internal void CICPCKKELIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x384B4F0", Offset = "0x384A0F0", VA = "0x18384B4F0")]
			internal bool MMPKBFCKIGK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class LPPCKOIHNGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public EHGKEKCMCCF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public EJNAOKCOCMG CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public LPPCKOIHNGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x42996C0", Offset = "0x42982C0", VA = "0x1842996C0")]
			internal void DGPFJKOIPHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class IGDMFCJBFBN
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
				public IGDMFCJBFBN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x3573F90", Offset = "0x3572B90", VA = "0x183573F90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
			public HJEILFHEDJO selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public GONIPNMLBFC nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public BLDDIIOIMMM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public IGDMFCJBFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3EA8580", Offset = "0x3EA7180", VA = "0x183EA8580")]
			internal int JGKEFJAEFIN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3EA8280", Offset = "0x3EA6E80", VA = "0x183EA8280")]
			internal void AKCGELIGKGO(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
			internal string FKMELINJAAF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3EA84C0", Offset = "0x3EA70C0", VA = "0x183EA84C0")]
			[AsyncStateMachine(typeof(GPPHMPPDKOB<>.IGDMFCJBFBN.<<CreatePortItemV2>b__3>d))]
			internal void HNBILFNGLMC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3EA85C0", Offset = "0x3EA71C0", VA = "0x183EA85C0")]
			internal bool OLKOCJFBLND(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> CLJKOHIOFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> PKKHDFEDHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> BOCKHGHPKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> KEGOJDMBMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> LPODLLMODCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<JCIKKDEFAFO<NKOLEFJCHJO>, bool> HMFNCJHFFAG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BJEJMCNFGGM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool MFLAFOBDPJN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool OEGFJKAPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool DAKEHLNMEOC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override JCIKKDEFAFO<LDNFOKBFEMK>? BNILNIJJJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3D8B130", Offset = "0x3D89D30", VA = "0x183D8B130", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override JCIKKDEFAFO<NKOLEFJCHJO>? GOKCJEALDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3D8B410", Offset = "0x3D8A010", VA = "0x183D8B410", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<ABKJIOOEHEB<BKMEFFNPIFK>>? ECEMHODNKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3D8B1F0", Offset = "0x3D89DF0", VA = "0x183D8B1F0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3D8AF10", Offset = "0x3D89B10", VA = "0x183D8AF10")]
		public GPPHMPPDKOB(BBMNOHIFAAA NKENJJKCCKI, TNode AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "129")]
		protected virtual bool MGFOEOCOPDL(int MKFBNOBCBDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "130")]
		protected virtual bool JJDGPMLJKCJ(int MKFBNOBCBDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "131")]
		protected virtual bool CADBLHBNMDA(int MKFBNOBCBDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "132")]
		protected virtual void EDCHHDBGGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3D86590", Offset = "0x3D85190", VA = "0x183D86590", Slot = "124")]
		public override bool CDAGJJFDNOK(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3D89D10", Offset = "0x3D88910", VA = "0x183D89D10", Slot = "100")]
		[AsyncStateMachine(typeof(GPPHMPPDKOB<>.BDPMOBOICHG))]
		public override Task<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> LGGGMOCHLEO(string LONKACOOPGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3D87780", Offset = "0x3D86380", VA = "0x183D87780", Slot = "101")]
		[AsyncStateMachine(typeof(GPPHMPPDKOB<>.FCPEFFBPBEA))]
		public override Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> EJDODLOMFHO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3D8AD00", Offset = "0x3D89900", VA = "0x183D8AD00", Slot = "102")]
		public override void NPLPMHJIAGG(JCIKKDEFAFO<NKOLEFJCHJO> BAEBMIBABAE, JCIKKDEFAFO<NKOLEFJCHJO> EEOLDJILHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A120", Offset = "0x3D88D20", VA = "0x183D8A120", Slot = "103")]
		public override IEnumerable<JPJAJOPEHEI> MOJJMIMNELO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3D89E30", Offset = "0x3D88A30", VA = "0x183D89E30")]
		[AsyncStateMachine(typeof(GPPHMPPDKOB<>.JKIONIANKAP))]
		private Task<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> LIFPBCAEOCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "133")]
		protected virtual bool AAGPDIAHMED(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "134")]
		protected virtual bool CKGJFMGBKMA(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "135")]
		protected virtual bool AIBKAJOMBLI(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "136")]
		protected virtual bool NKHPGGMDIEF(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "137")]
		protected virtual bool HJOEOGNHGEF(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int HKPFNHAJGPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "138")]
		protected virtual bool LNFBJOBLGKF(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int HKPFNHAJGPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "139")]
		protected virtual bool IBLNMFKFBIP(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int LFOPOPFCDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "140")]
		protected virtual bool PBCPPHLHGAH(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int LFOPOPFCDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "141")]
		protected virtual bool PMBCBPDAPJH(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int DLKDICJKMOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "142")]
		protected virtual bool IPDBGFPNHOP(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, int AFFJKIAILLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D87890", Offset = "0x3D86490", VA = "0x183D87890", Slot = "143")]
		protected virtual List<HJEILFHEDJO> IMFGHEPDKLI(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "144")]
		protected virtual void OHHILALABKN(GADLAGDBJEO GLJNOBBOEPL, HNFDKPLPKGI AHNLODGNMIN, GONIPNMLBFC AACJFFGNBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3D892A0", Offset = "0x3D87EA0", VA = "0x183D892A0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3D87B20", Offset = "0x3D86720", VA = "0x183D87B20")]
		private HNFDKPLPKGI IPCMJFNICPF(GADLAGDBJEO GLJNOBBOEPL, GONIPNMLBFC AACJFFGNBFO, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3D86630", Offset = "0x3D85230", VA = "0x183D86630")]
		private List<EHGKEKCMCCF> DLPGMKKPFLL(GADLAGDBJEO GLJNOBBOEPL, GONIPNMLBFC AACJFFGNBFO, HNFDKPLPKGI PJILMAFEPPD, bool HJOHPNILCPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A3B0", Offset = "0x3D88FB0", VA = "0x183D8A3B0")]
		private List<EHGKEKCMCCF> NJNIDEALDCF(GADLAGDBJEO GLJNOBBOEPL, GONIPNMLBFC AACJFFGNBFO, BLDDIIOIMMM IKPNOAEKCNK, bool HJOHPNILCPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3D89F30", Offset = "0x3D88B30", VA = "0x183D89F30")]
		private HJEILFHEDJO MJPMGKMALJO(List<HJEILFHEDJO> LFCAKNLAPJF, BLDDIIOIMMM IKPNOAEKCNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3D864F0", Offset = "0x3D850F0", VA = "0x183D864F0")]
		[CompilerGenerated]
		private JPJAJOPEHEI CBBMCPDBELP(ECHKNCNLALD BFOGKPIBBMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class MCANEOLPMGJ : NMGPAJANPNI<JCNJNMMOPHF>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class JMNOCNFOGEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public MCANEOLPMGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public JMNOCNFOGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F967A0", Offset = "0x1F953A0", VA = "0x181F967A0")]
			internal int BJEBONJACJN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1F967F0", Offset = "0x1F953F0", VA = "0x181F967F0")]
			internal void NJBLCJPFOPH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AFC0", Offset = "0x1F99BC0", VA = "0x181F9AFC0")]
		public MCANEOLPMGJ(BBMNOHIFAAA NKENJJKCCKI, JCNJNMMOPHF AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AE00", Offset = "0x1F99A00", VA = "0x181F9AE00", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class LKNPIJCCKOK : EFBOHHPDNHP<OLOMAHOGHIH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class MMKCDLMNCBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public LKNPIJCCKOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public MMKCDLMNCBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B090", Offset = "0x1F99C90", VA = "0x181F9B090")]
			internal int CHAFAJKMIDI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B110", Offset = "0x1F99D10", VA = "0x181F9B110")]
			internal void OLFCCCKEFDJ(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A690", Offset = "0x1F99290", VA = "0x181F9A690")]
		public LKNPIJCCKOK(BBMNOHIFAAA NKENJJKCCKI, OLOMAHOGHIH JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A450", Offset = "0x1F99050", VA = "0x181F9A450", Slot = "126")]
		protected override void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class LIHIHFBCABE : NMGPAJANPNI<JHPIGDLPGCE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8E3BE0", Offset = "0x8E27E0", VA = "0x1808E3BE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F98000", Offset = "0x1F96C00", VA = "0x181F98000")]
		public LIHIHFBCABE(BBMNOHIFAAA NKENJJKCCKI, JHPIGDLPGCE AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class LJNNBKFJDHH : NMGPAJANPNI<EEGENLOPAMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class EHDHGPJGMOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public LJNNBKFJDHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public GADLAGDBJEO configure;

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
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public EHDHGPJGMOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F890E0", Offset = "0x1F87CE0", VA = "0x181F890E0")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F92BF0", Offset = "0x1F917F0", VA = "0x181F92BF0")]
			internal void NJBLCJPFOPH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1F89460", Offset = "0x1F88060", VA = "0x181F89460")]
			internal bool CFGKMIDNAHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F926E0", Offset = "0x1F912E0", VA = "0x181F926E0")]
			internal bool MDDGLBAOAOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F90C80", Offset = "0x1F8F880", VA = "0x181F90C80")]
			internal void HBMIICIOFHN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F91890", Offset = "0x1F90490", VA = "0x181F91890")]
			internal bool JLJIJKJJEOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F917A0", Offset = "0x1F903A0", VA = "0x181F917A0")]
			internal bool JKHLNBFGEPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F88D00", Offset = "0x1F87900", VA = "0x181F88D00")]
			internal void ALBHLGCKJBI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F91CB0", Offset = "0x1F908B0", VA = "0x181F91CB0")]
			internal bool KFELNCCFBNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F896C0", Offset = "0x1F882C0", VA = "0x181F896C0")]
			internal bool CPIHCABPKNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F88D60", Offset = "0x1F87960", VA = "0x181F88D60")]
			internal void ALNJHHEGJBE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F88850", Offset = "0x1F87450", VA = "0x181F88850")]
			internal bool ABBBPHIHFAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A390", Offset = "0x1F88F90", VA = "0x181F8A390")]
			internal bool FIKKALPDKIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F90D90", Offset = "0x1F8F990", VA = "0x181F90D90")]
			internal bool HIACLBMGGOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F893C0", Offset = "0x1F87FC0", VA = "0x181F893C0")]
			internal bool CBFADEIOCJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F89760", Offset = "0x1F88360", VA = "0x181F89760")]
			internal bool DAAPBMLILPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F91E40", Offset = "0x1F90A40", VA = "0x181F91E40")]
			internal bool KNNNGKCEAAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F89F00", Offset = "0x1F88B00", VA = "0x181F89F00")]
			internal bool EPOMAJLAIJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A5C0", Offset = "0x1F891C0", VA = "0x181F8A5C0")]
			internal bool FPJNMFNIBMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F89DC0", Offset = "0x1F889C0", VA = "0x181F89DC0")]
			internal bool EMKBEEFBDMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F889E0", Offset = "0x1F875E0", VA = "0x181F889E0")]
			internal void ADBDBHIJKGD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A7B0", Offset = "0x1F893B0", VA = "0x181F8A7B0")]
			internal bool GCPJNAHIKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F91700", Offset = "0x1F90300", VA = "0x181F91700")]
			internal bool JJKNGGGAPNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F895C0", Offset = "0x1F881C0", VA = "0x181F895C0")]
			internal bool CMDLJONMJKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F91F80", Offset = "0x1F90B80", VA = "0x181F91F80")]
			internal bool LAANCEKGHGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F91E90", Offset = "0x1F90A90", VA = "0x181F91E90")]
			internal bool KPANHMKALKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F93050", Offset = "0x1F91C50", VA = "0x181F93050")]
			internal bool OMBNHJMOFGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F919A0", Offset = "0x1F905A0", VA = "0x181F919A0")]
			internal bool JMODMDEBAMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F92BA0", Offset = "0x1F917A0", VA = "0x181F92BA0")]
			internal bool NJAPICILPPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F887F0", Offset = "0x1F873F0", VA = "0x181F887F0")]
			internal void AAPPIJIHCPM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F934C0", Offset = "0x1F920C0", VA = "0x181F934C0")]
			internal bool POCEDLKEIFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F88EB0", Offset = "0x1F87AB0", VA = "0x181F88EB0")]
			internal bool BCGCHGDJMJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F92820", Offset = "0x1F91420", VA = "0x181F92820")]
			internal void MIFJKPMKELM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F91EE0", Offset = "0x1F90AE0", VA = "0x181F91EE0")]
			internal bool KPGPLGHEBFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F89E10", Offset = "0x1F88A10", VA = "0x181F89E10")]
			internal bool ENCDAJCECHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1F93190", Offset = "0x1F91D90", VA = "0x181F93190")]
			internal void PAMJFAIDCDP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A850", Offset = "0x1F89450", VA = "0x181F8A850")]
			internal List<EHGKEKCMCCF> GEBKLODFOIC(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F891D0", Offset = "0x1F87DD0", VA = "0x181F891D0")]
			internal bool BNLKGBEHOED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1F913C0", Offset = "0x1F8FFC0", VA = "0x181F913C0")]
			internal int JAFPCLGNNLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1F89610", Offset = "0x1F88210", VA = "0x181F89610")]
			internal void COBALBCEPPC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A40", Offset = "0x1F87640", VA = "0x181F88A40")]
			internal bool ADJILHAGLOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F93000", Offset = "0x1F91C00", VA = "0x181F93000")]
			internal bool OMBDMFLLBAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A4D0", Offset = "0x1F890D0", VA = "0x181F8A4D0")]
			internal bool FNCLMBCDMPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F92730", Offset = "0x1F91330", VA = "0x181F92730")]
			internal int MFGEEJNCGPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F91940", Offset = "0x1F90540", VA = "0x181F91940")]
			internal void JMLOHPEMFMI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F89B80", Offset = "0x1F88780", VA = "0x181F89B80")]
			internal bool EDHBMCDAALI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F916B0", Offset = "0x1F902B0", VA = "0x181F916B0")]
			internal bool JJANNPJONBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F92EA0", Offset = "0x1F91AA0", VA = "0x181F92EA0")]
			internal bool OJOPJBMMOLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F90B20", Offset = "0x1F8F720", VA = "0x181F90B20")]
			internal bool GNNLJJOLAKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F91A60", Offset = "0x1F90660", VA = "0x181F91A60")]
			internal bool JOLNDHNEOIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F92FB0", Offset = "0x1F91BB0", VA = "0x181F92FB0")]
			internal bool OLJNEALBAEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F932C0", Offset = "0x1F91EC0", VA = "0x181F932C0")]
			internal string PCALFOAJIBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1F91260", Offset = "0x1F8FE60", VA = "0x181F91260")]
			internal void IMCPHHKFDFA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F90FC0", Offset = "0x1F8FBC0", VA = "0x181F90FC0")]
			internal int ICENMKMBKOL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F90F60", Offset = "0x1F8FB60", VA = "0x181F90F60")]
			internal void IBLHOEFFHMG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F93560", Offset = "0x1F92160", VA = "0x181F93560")]
			internal bool PONLDNPIPDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F88940", Offset = "0x1F87540", VA = "0x181F88940")]
			internal bool ACJGGAAFCIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A480", Offset = "0x1F89080", VA = "0x181F8A480")]
			internal bool FMNMCJLIKFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F91150", Offset = "0x1F8FD50", VA = "0x181F91150")]
			internal float IHCGPOONLEN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F90D30", Offset = "0x1F8F930", VA = "0x181F90D30")]
			internal void HGDBBNGNNDN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F92D50", Offset = "0x1F91950", VA = "0x181F92D50")]
			internal bool NOANBLMHHOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A570", Offset = "0x1F89170", VA = "0x181F8A570")]
			internal bool FNMGNGBKIGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F930F0", Offset = "0x1F91CF0", VA = "0x181F930F0")]
			internal bool OPHOCOOMHNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F91100", Offset = "0x1F8FD00", VA = "0x181F91100")]
			internal bool IHAIENLGMHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1F91060", Offset = "0x1F8FC60", VA = "0x181F91060")]
			internal bool IDDJAACJDDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1F930A0", Offset = "0x1F91CA0", VA = "0x181F930A0")]
			internal bool OOIFEJGCKEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F92130", Offset = "0x1F90D30", VA = "0x181F92130")]
			internal void LHKLKABGOEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F91840", Offset = "0x1F90440", VA = "0x181F91840")]
			internal string JLEGOAFEJAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F88C20", Offset = "0x1F87820", VA = "0x181F88C20")]
			internal void AJMLHMLCPMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F88FA0", Offset = "0x1F87BA0", VA = "0x181F88FA0")]
			internal bool BDPLLDPAKJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F89940", Offset = "0x1F88540", VA = "0x181F89940")]
			internal bool DIAIIMEJECH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F897B0", Offset = "0x1F883B0", VA = "0x181F897B0")]
			internal bool DAENCAPGJNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A050", Offset = "0x1F88C50", VA = "0x181F8A050")]
			internal void FDOCLLBGPOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F92970", Offset = "0x1F91570", VA = "0x181F92970")]
			internal bool MODPGEMFNBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F89130", Offset = "0x1F87D30", VA = "0x181F89130")]
			internal bool BJPLKJGJHCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F88F00", Offset = "0x1F87B00", VA = "0x181F88F00")]
			internal bool BCJIPLPLKLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F91320", Offset = "0x1F8FF20", VA = "0x181F91320")]
			internal bool IPFHNELBMCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F933C0", Offset = "0x1F91FC0", VA = "0x181F933C0")]
			internal void PICBAIMKBLE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F90CE0", Offset = "0x1F8F8E0", VA = "0x181F90CE0")]
			internal bool HDCAJAGLBEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F88DC0", Offset = "0x1F879C0", VA = "0x181F88DC0")]
			internal bool AOHKOHNBBHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F92B00", Offset = "0x1F91700", VA = "0x181F92B00")]
			internal bool NFHAGMODBNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A3E0", Offset = "0x1F88FE0", VA = "0x181F8A3E0")]
			internal bool FKEGMOBEGBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A660", Offset = "0x1F89260", VA = "0x181F8A660")]
			internal void GAFPJLCAGKC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F92880", Offset = "0x1F91480", VA = "0x181F92880")]
			internal bool MLDBKFKNCGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F92AB0", Offset = "0x1F916B0", VA = "0x181F92AB0")]
			internal bool NFFMLHNKFBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F93140", Offset = "0x1F91D40", VA = "0x181F93140")]
			internal bool PAJIOIAFFMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F88E10", Offset = "0x1F87A10", VA = "0x181F88E10")]
			internal bool BBMFCJICAHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F88E60", Offset = "0x1F87A60", VA = "0x181F88E60")]
			internal int BCALBECGDKK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F88B00", Offset = "0x1F87700", VA = "0x181F88B00")]
			internal void AEOFPJOCIHD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F91D50", Offset = "0x1F90950", VA = "0x181F91D50")]
			internal bool KKHHGALLJHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F89520", Offset = "0x1F88120", VA = "0x181F89520")]
			internal bool CJPOBEHDAJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F89800", Offset = "0x1F88400", VA = "0x181F89800")]
			internal int DAKAEKDFMOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F92E40", Offset = "0x1F91A40", VA = "0x181F92E40")]
			internal void OEMOKOGLIFK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A430", Offset = "0x1F89030", VA = "0x181F8A430")]
			internal bool FMANNKBOGJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F898A0", Offset = "0x1F884A0", VA = "0x181F898A0")]
			internal bool DGEAGAOCDMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F90BE0", Offset = "0x1F8F7E0", VA = "0x181F90BE0")]
			internal int HAGHKOMALDO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F918E0", Offset = "0x1F904E0", VA = "0x181F918E0")]
			internal void JMHCCANKIDE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F89EB0", Offset = "0x1F88AB0", VA = "0x181F89EB0")]
			internal bool EPIBDLHHHGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F90990", Offset = "0x1F8F590", VA = "0x181F90990")]
			internal bool GEIBDBCPLDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F91550", Offset = "0x1F90150", VA = "0x181F91550")]
			internal bool JFAPLPJJGJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F89410", Offset = "0x1F88010", VA = "0x181F89410")]
			internal int CEJJLEBJDJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F92CA0", Offset = "0x1F918A0", VA = "0x181F92CA0")]
			internal void NLICLGLJKND(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F914B0", Offset = "0x1F900B0", VA = "0x181F914B0")]
			internal bool JEINFBDOLAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F91AB0", Offset = "0x1F906B0", VA = "0x181F91AB0")]
			internal bool KACFFOHBACA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F93470", Offset = "0x1F92070", VA = "0x181F93470")]
			internal bool PJCCHKGHODC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F90B70", Offset = "0x1F8F770", VA = "0x181F90B70")]
			internal object HAEADMIMACK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F89CC0", Offset = "0x1F888C0", VA = "0x181F89CC0")]
			internal void EKKNOKLAANH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F90AD0", Offset = "0x1F8F6D0", VA = "0x181F90AD0")]
			internal bool GNNICDEGAKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1F89710", Offset = "0x1F88310", VA = "0x181F89710")]
			internal bool CPPHNBEAJKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F91BF0", Offset = "0x1F907F0", VA = "0x181F91BF0")]
			internal object KDDMHEMGJFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F88B90", Offset = "0x1F87790", VA = "0x181F88B90")]
			internal void AHPLCOGEIBF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F92C50", Offset = "0x1F91850", VA = "0x181F92C50")]
			internal bool NJMADMCMONI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F91010", Offset = "0x1F8FC10", VA = "0x181F91010")]
			internal int ICNLOMFNNCG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F89FF0", Offset = "0x1F88BF0", VA = "0x181F89FF0")]
			internal void FCKFHOEJOGN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F89F50", Offset = "0x1F88B50", VA = "0x181F89F50")]
			internal bool EPPCHHILKLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F91F30", Offset = "0x1F90B30", VA = "0x181F91F30")]
			internal bool KPJDCAAPHCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F89A80", Offset = "0x1F88680", VA = "0x181F89A80")]
			internal bool DMFGPGMOEBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F892D0", Offset = "0x1F87ED0", VA = "0x181F892D0")]
			internal int CAAFAMCKGFE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F92630", Offset = "0x1F91230", VA = "0x181F92630")]
			internal void MBJBONLGEJK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1F929C0", Offset = "0x1F915C0", VA = "0x181F929C0")]
			internal bool NDDPMOPCKJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F91370", Offset = "0x1F8FF70", VA = "0x181F91370")]
			internal bool IPNABAOMALK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1F91500", Offset = "0x1F90100", VA = "0x181F91500")]
			internal bool JEKFAIMFEBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F89040", Offset = "0x1F87C40", VA = "0x181F89040")]
			internal float BFBEKKHFPHK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1F89220", Offset = "0x1F87E20", VA = "0x181F89220")]
			internal void BNMDIKHDMFP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1F88990", Offset = "0x1F87590", VA = "0x181F88990")]
			internal bool ACONCJHDFPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A610", Offset = "0x1F89210", VA = "0x181F8A610")]
			internal bool GACHJEKJNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1F89FA0", Offset = "0x1F88BA0", VA = "0x181F89FA0")]
			internal bool FBBDPKIGAFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1F89670", Offset = "0x1F88270", VA = "0x181F89670")]
			internal float COGCMPFLHOO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1F93260", Offset = "0x1F91E60", VA = "0x181F93260")]
			internal void PBMFLFLOJMP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1F93510", Offset = "0x1F92110", VA = "0x181F93510")]
			internal bool POGNJEJFIPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1F91660", Offset = "0x1F90260", VA = "0x181F91660")]
			internal bool JIMAPCHLJID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1F89AD0", Offset = "0x1F886D0", VA = "0x181F89AD0")]
			internal string DMIECGBPMAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1F919F0", Offset = "0x1F905F0", VA = "0x181F919F0")]
			internal void JNMCPLAICMM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1F888A0", Offset = "0x1F874A0", VA = "0x181F888A0")]
			internal bool ABGMHFMMEDK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1F912D0", Offset = "0x1F8FED0", VA = "0x181F912D0")]
			internal bool IONIAFKBCMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1F92A60", Offset = "0x1F91660", VA = "0x181F92A60")]
			internal bool NDKPOOJIAPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1F925E0", Offset = "0x1F911E0", VA = "0x181F925E0")]
			internal bool MBFCPKIDHBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1F911A0", Offset = "0x1F8FDA0", VA = "0x181F911A0")]
			internal string IINDGJCDJFF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1F90DE0", Offset = "0x1F8F9E0", VA = "0x181F90DE0")]
			internal void HIMOBMKLNNH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A520", Offset = "0x1F89120", VA = "0x181F8A520")]
			internal bool FNDKGNHMOFI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F909E0", Offset = "0x1F8F5E0", VA = "0x181F909E0")]
			internal bool GGGMPPCNPHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1F90A80", Offset = "0x1F8F680", VA = "0x181F90A80")]
			internal bool GMCLODOLPOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1F89990", Offset = "0x1F88590", VA = "0x181F89990")]
			internal bool DJOKBFCGABA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1F91750", Offset = "0x1F90350", VA = "0x181F91750")]
			internal string JKBEMHBAEJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1F88C90", Offset = "0x1F87890", VA = "0x181F88C90")]
			internal void AKIGGJAJAOB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1F89180", Offset = "0x1F87D80", VA = "0x181F89180")]
			internal bool BKIKLMAOOHD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1F92780", Offset = "0x1F91380", VA = "0x181F92780")]
			internal bool MGENCIFJOML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1F92DF0", Offset = "0x1F919F0", VA = "0x181F92DF0")]
			internal bool OCAFIDNIMGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F927D0", Offset = "0x1F913D0", VA = "0x181F927D0")]
			internal bool MHBJONLFJIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F910B0", Offset = "0x1F8FCB0", VA = "0x181F910B0")]
			internal string IEPMJADIFJH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1F911F0", Offset = "0x1F8FDF0", VA = "0x181F911F0")]
			internal void ILEABJCCHNJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1F91410", Offset = "0x1F90010", VA = "0x181F91410")]
			internal bool JALIHJHDOIH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A710", Offset = "0x1F89310", VA = "0x181F8A710")]
			internal bool GAOKEIIJFIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1F92B50", Offset = "0x1F91750", VA = "0x181F92B50")]
			internal bool NFMMOHDIGHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1F89090", Offset = "0x1F87C90", VA = "0x181F89090")]
			internal bool BICIBKEMJGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1F89A30", Offset = "0x1F88630", VA = "0x181F89A30")]
			internal string DKLGCJHCGLJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A320", Offset = "0x1F88F20", VA = "0x181F8A320")]
			internal void FHPJOHNAGDI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A760", Offset = "0x1F89360", VA = "0x181F8A760")]
			internal bool GCPGLACLDNA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1F90F10", Offset = "0x1F8FB10", VA = "0x181F90F10")]
			internal bool HOEJKOKANMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1F89320", Offset = "0x1F87F20", VA = "0x181F89320")]
			internal bool CAJGDJJEGFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1F917F0", Offset = "0x1F903F0", VA = "0x181F917F0")]
			internal bool JLEBJEMEKNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1F89570", Offset = "0x1F88170", VA = "0x181F89570")]
			internal string CKLPNIPECOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1F92020", Offset = "0x1F90C20", VA = "0x181F92020")]
			internal void LCMGBABEFMF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1F92EF0", Offset = "0x1F91AF0", VA = "0x181F92EF0")]
			internal bool OKFPMMHELMN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1F928D0", Offset = "0x1F914D0", VA = "0x181F928D0")]
			internal bool MLNFOONFOLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1F89280", Offset = "0x1F87E80", VA = "0x181F89280")]
			internal bool BOKNCHLKDKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1F90E50", Offset = "0x1F8FA50", VA = "0x181F90E50")]
			internal bool HJMCPHPHIPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1F93420", Offset = "0x1F92020", VA = "0x181F93420")]
			internal string PIPGPEFPOPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F92F40", Offset = "0x1F91B40", VA = "0x181F92F40")]
			internal void OKJPGOOJFBM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F91460", Offset = "0x1F90060", VA = "0x181F91460")]
			internal bool JBHHNOJCELP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F89C20", Offset = "0x1F88820", VA = "0x181F89C20")]
			internal bool EGDJPOJBCKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F89BD0", Offset = "0x1F887D0", VA = "0x181F89BD0")]
			internal bool EEOFGBKGIOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1F899E0", Offset = "0x1F885E0", VA = "0x181F899E0")]
			internal bool DKCOJOCCOOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1F90A30", Offset = "0x1F8F630", VA = "0x181F90A30")]
			internal string GHPEOPMNCBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1F915A0", Offset = "0x1F901A0", VA = "0x181F915A0")]
			internal void JGGHJBPNFFK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1F91DA0", Offset = "0x1F909A0", VA = "0x181F91DA0")]
			internal bool KKKNGIIOOLP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1F92A10", Offset = "0x1F91610", VA = "0x181F92A10")]
			internal bool NDIJBNONEEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1F93310", Offset = "0x1F91F10", VA = "0x181F93310")]
			internal bool PEMOBMEGAGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F92690", Offset = "0x1F91290", VA = "0x181F92690")]
			internal bool MCKAACCKOFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F89E60", Offset = "0x1F88A60", VA = "0x181F89E60")]
			internal string ENPJIANHHLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F894B0", Offset = "0x1F880B0", VA = "0x181F894B0")]
			internal void CFHKIKPNBDD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F920E0", Offset = "0x1F90CE0", VA = "0x181F920E0")]
			internal bool LGHCPEMGHAM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F90C30", Offset = "0x1F8F830", VA = "0x181F90C30")]
			internal bool HBLFFGMBJBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F924F0", Offset = "0x1F910F0", VA = "0x181F924F0")]
			internal bool LJGKMPKBPMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F888F0", Offset = "0x1F874F0", VA = "0x181F888F0")]
			internal bool ACILKONKDKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F91610", Offset = "0x1F90210", VA = "0x181F91610")]
			internal string JHPIFJPIIJM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F90EA0", Offset = "0x1F8FAA0", VA = "0x181F90EA0")]
			internal void HKMDECIPMPA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F91DF0", Offset = "0x1F909F0", VA = "0x181F91DF0")]
			internal bool KMLMFPEGDEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F91B50", Offset = "0x1F90750", VA = "0x181F91B50")]
			internal bool KCNFPIDPBBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F89370", Offset = "0x1F87F70", VA = "0x181F89370")]
			internal bool CAKKEBCHENN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F92920", Offset = "0x1F91520", VA = "0x181F92920")]
			internal string MMGAKGNMDBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F931F0", Offset = "0x1F91DF0", VA = "0x181F931F0")]
			internal void PBMEELLPICN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F91BA0", Offset = "0x1F907A0", VA = "0x181F91BA0")]
			internal bool KDAEGBKMFLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1F91B00", Offset = "0x1F90700", VA = "0x181F91B00")]
			internal bool KCLLIPNNEEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1F898F0", Offset = "0x1F884F0", VA = "0x181F898F0")]
			internal bool DGPEANKLHKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1F91FD0", Offset = "0x1F90BD0", VA = "0x181F91FD0")]
			internal string LBHGKBLBHBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1F89D50", Offset = "0x1F88950", VA = "0x181F89D50")]
			internal void ELLDJFHJIJA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1F91D00", Offset = "0x1F90900", VA = "0x181F91D00")]
			internal bool KIFEDPMIPBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1F92DA0", Offset = "0x1F919A0", VA = "0x181F92DA0")]
			internal bool OBHHLCHGEFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1F89850", Offset = "0x1F88450", VA = "0x181F89850")]
			internal bool DALNLKHIMNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1F92590", Offset = "0x1F91190", VA = "0x181F92590")]
			internal string LNFPEBMLCIF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A90", Offset = "0x1F87690", VA = "0x181F88A90")]
			internal void ADKJOLJDJHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F89C70", Offset = "0x1F88870", VA = "0x181F89C70")]
			internal bool EINBLMMEPOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F91C60", Offset = "0x1F90860", VA = "0x181F91C60")]
			internal bool KEHNKCANKAN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A800", Offset = "0x1F89400", VA = "0x181F8A800")]
			internal float GDOHNDDENCE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1F89B20", Offset = "0x1F88720", VA = "0x181F89B20")]
			internal void EBNDMCIKCEJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1F88FF0", Offset = "0x1F87BF0", VA = "0x181F88FF0")]
			internal bool BFAJFOGGDFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1F92090", Offset = "0x1F90C90", VA = "0x181F92090")]
			internal bool LFPMKFIGDAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1F92540", Offset = "0x1F91140", VA = "0x181F92540")]
			internal bool LKKFNHJFDNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1F887A0", Offset = "0x1F873A0", VA = "0x181F887A0")]
			internal int AAEGFGKNDPB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F93360", Offset = "0x1F91F60", VA = "0x181F93360")]
			internal void PFNHOLBJKHO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1F88F50", Offset = "0x1F87B50", VA = "0x181F88F50")]
			internal bool BCJLPEMAGPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A6C0", Offset = "0x1F892C0", VA = "0x181F8A6C0")]
			internal bool GANANOMNCND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1F92D00", Offset = "0x1F91900", VA = "0x181F92D00")]
			internal bool NNKCCBINCJN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class AAFCGLAKIHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public EHDHGPJGMOD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public AAFCGLAKIHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1F81F20", Offset = "0x1F80B20", VA = "0x181F81F20")]
			internal void JEEAFLICEKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class PEIDGFJPPGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PEIDGFJPPGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E830", Offset = "0x1F9D430", VA = "0x181F9E830")]
			internal bool OABPPFOMMCE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly EIKIHDMKHAG LOHECFAPNJO;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F99F40", Offset = "0x1F98B40", VA = "0x181F99F40")]
		public LJNNBKFJDHH(BBMNOHIFAAA NKENJJKCCKI, EEGENLOPAMJ AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1F98170", Offset = "0x1F96D70", VA = "0x181F98170", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class NEJOKBDBKNG : NMGPAJANPNI<BCJDPKMHGPP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class LHHGKKJIPHN
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
				public LHHGKKJIPHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1FBB670", Offset = "0x1FBA270", VA = "0x181FBB670", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public NEJOKBDBKNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public LHHGKKJIPHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1CE0", Offset = "0x1FB08E0", VA = "0x181FB1CE0")]
			internal string BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1D80", Offset = "0x1FB0980", VA = "0x181FB1D80")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NJBLCJPFOPH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1D30", Offset = "0x1FB0930", VA = "0x181FB1D30")]
			internal int MJDBNIPDNIP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1E50", Offset = "0x1FB0A50", VA = "0x181FB1E50")]
			internal void PBHKKGCIJHM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3D80", Offset = "0x1FB2980", VA = "0x181FB3D80")]
		public NEJOKBDBKNG(BBMNOHIFAAA NKENJJKCCKI, BCJDPKMHGPP JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3A30", Offset = "0x1FB2630", VA = "0x181FB3A30", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class NPPPMAKNGAJ : NMGPAJANPNI<BDFOENJLPOK>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class DMIGFHGHKPB
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
				public DMIGFHGHKPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1FBB330", Offset = "0x1FB9F30", VA = "0x181FBB330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
				public DMIGFHGHKPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1FBB980", Offset = "0x1FBA580", VA = "0x181FBB980", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public NPPPMAKNGAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public DMIGFHGHKPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4210", Offset = "0x1FA2E10", VA = "0x181FA4210")]
			internal string BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4750", Offset = "0x1FA3350", VA = "0x181FA4750")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NJBLCJPFOPH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4700", Offset = "0x1FA3300", VA = "0x181FA4700")]
			internal int MJDBNIPDNIP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4820", Offset = "0x1FA3420", VA = "0x181FA4820")]
			internal void PBHKKGCIJHM(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4260", Offset = "0x1FA2E60", VA = "0x181FA4260")]
			internal string CFGKMIDNAHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4630", Offset = "0x1FA3230", VA = "0x181FA4630")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void MDDGLBAOAOL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4430", Offset = "0x1FA3030", VA = "0x181FA4430")]
			internal bool HBMIICIOFHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA43A0", Offset = "0x1FA2FA0", VA = "0x181FA43A0")]
			internal void FLJOBEJBJOE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA42B0", Offset = "0x1FA2EB0", VA = "0x181FA42B0")]
			internal bool CFMLJBAHOJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4530", Offset = "0x1FA3130", VA = "0x181FA4530")]
			internal void JLJIJKJJEOO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA44E0", Offset = "0x1FA30E0", VA = "0x181FA44E0")]
			internal float JKHLNBFGEPK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4180", Offset = "0x1FA2D80", VA = "0x181FA4180")]
			internal void ALBHLGCKJBI(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4480", Offset = "0x1FA3080", VA = "0x181FA4480")]
			internal int JHMLAJHEFFM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4300", Offset = "0x1FA2F00", VA = "0x181FA4300")]
			internal void EOAGMMIEKGO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FA45C0", Offset = "0x1FA31C0", VA = "0x181FA45C0")]
			internal bool KFELNCCFBNE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB95E0", Offset = "0x1FB81E0", VA = "0x181FB95E0")]
		public NPPPMAKNGAJ(BBMNOHIFAAA NKENJJKCCKI, BDFOENJLPOK AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8BB0", Offset = "0x1FB77B0", VA = "0x181FB8BB0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class MMKPIDAEGCA : NMGPAJANPNI<NDHCFPOEDCI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KKAPGLLOPAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public MMKPIDAEGCA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public KKAPGLLOPAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1620", Offset = "0x1FB0220", VA = "0x181FB1620")]
			internal Dictionary<string, JBBDCCJMFFN> BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB17E0", Offset = "0x1FB03E0", VA = "0x181FB17E0")]
			internal int NJBLCJPFOPH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB16C0", Offset = "0x1FB02C0", VA = "0x181FB16C0")]
			internal void MJDBNIPDNIP(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1830", Offset = "0x1FB0430", VA = "0x181FB1830")]
			internal bool PBHKKGCIJHM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3480", Offset = "0x1FB2080", VA = "0x181FB3480")]
		public MMKPIDAEGCA(BBMNOHIFAAA NKENJJKCCKI, NDHCFPOEDCI JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB31E0", Offset = "0x1FB1DE0", VA = "0x181FB31E0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class LEHPHJMHPHD : NMGPAJANPNI<CCJLHCICHBO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1C10", Offset = "0x1FB0810", VA = "0x181FB1C10")]
		public LEHPHJMHPHD(BBMNOHIFAAA NKENJJKCCKI, CCJLHCICHBO JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1B20", Offset = "0x1FB0720", VA = "0x181FB1B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1A10", Offset = "0x1FB0610", VA = "0x181FB1A10")]
		[CompilerGenerated]
		private void FMLPFNIIHKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class OPCEFLNELHI : GPPHMPPDKOB<MNBHCKCJCNP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool LJBGOPBBKEM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool ECBFNBFDMJB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA190", Offset = "0x1FB8D90", VA = "0x181FBA190", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8DCCE0", Offset = "0x8DB8E0", VA = "0x1808DCCE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA130", Offset = "0x1FB8D30", VA = "0x181FBA130")]
		public OPCEFLNELHI(BBMNOHIFAAA NKENJJKCCKI, MNBHCKCJCNP AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class CFOCFJJEOBC : NMGPAJANPNI<HFACCPAJGIB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x8E45A0", Offset = "0x8E31A0", VA = "0x1808E45A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2300", Offset = "0x1FA0F00", VA = "0x181FA2300")]
		public CFOCFJJEOBC(BBMNOHIFAAA NKENJJKCCKI, HFACCPAJGIB AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class FMJINDPLAEF : NMGPAJANPNI<NMDKNHPEGEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D0B50", Offset = "0x8CF750", VA = "0x1808D0B50", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5DB0", Offset = "0x1FA49B0", VA = "0x181FA5DB0")]
		public FMJINDPLAEF(BBMNOHIFAAA NKENJJKCCKI, NMDKNHPEGEK AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "112")]
		protected override bool DCEACDKKFDO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class FACAEKAAKAL : NMGPAJANPNI<PEIJDDMGKIO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x8D5890", Offset = "0x8D4490", VA = "0x1808D5890", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool OJONDAACMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA50E0", Offset = "0x1FA3CE0", VA = "0x181FA50E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool NJNAPFLFCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5070", Offset = "0x1FA3C70", VA = "0x181FA5070")]
		public FACAEKAAKAL(BBMNOHIFAAA NKENJJKCCKI, PEIJDDMGKIO AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class CFODGBEHGDP : NMGPAJANPNI<DICKMAHNFCI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8E1570", Offset = "0x8E0170", VA = "0x1808E1570", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool OJONDAACMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FA23E0", Offset = "0x1FA0FE0", VA = "0x181FA23E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool NJNAPFLFCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2370", Offset = "0x1FA0F70", VA = "0x181FA2370")]
		public CFODGBEHGDP(BBMNOHIFAAA NKENJJKCCKI, DICKMAHNFCI AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class EDEIPPAFMNL : EFBOHHPDNHP<NLMPOCMLIHC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class JBKCMKCKDHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public EDEIPPAFMNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public JBKCMKCKDHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF670", Offset = "0x1FAE270", VA = "0x181FAF670")]
			internal float CHAFAJKMIDI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF6F0", Offset = "0x1FAE2F0", VA = "0x181FAF6F0")]
			internal void OLFCCCKEFDJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4B30", Offset = "0x1FA3730", VA = "0x181FA4B30")]
		public EDEIPPAFMNL(BBMNOHIFAAA NKENJJKCCKI, NLMPOCMLIHC JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FA48B0", Offset = "0x1FA34B0", VA = "0x181FA48B0", Slot = "126")]
		protected override void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class KFEDKFFANCG : NMGPAJANPNI<BLGOCFPELCO>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class BMGCLIKDOBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public KFEDKFFANCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public BMGCLIKDOBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1FA0FE0", Offset = "0x1F9FBE0", VA = "0x181FA0FE0")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1030", Offset = "0x1F9FC30", VA = "0x181FA1030")]
			internal void NJBLCJPFOPH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB15B0", Offset = "0x1FB01B0", VA = "0x181FB15B0")]
		public KFEDKFFANCG(BBMNOHIFAAA NKENJJKCCKI, BLGOCFPELCO JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1310", Offset = "0x1FAFF10", VA = "0x181FB1310", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class FKHGNOBPDNO : NMGPAJANPNI<FBLDFJCKALP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class BOJKGOBEEFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public FKHGNOBPDNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public BOJKGOBEEFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1150", Offset = "0x1F9FD50", VA = "0x181FA1150")]
			internal object BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA12F0", Offset = "0x1F9FEF0", VA = "0x181FA12F0")]
			internal bool FLJOBEJBJOE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1640", Offset = "0x1FA0240", VA = "0x181FA1640")]
			internal void NJBLCJPFOPH(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA14E0", Offset = "0x1FA00E0", VA = "0x181FA14E0")]
			internal string MJDBNIPDNIP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1890", Offset = "0x1FA0490", VA = "0x181FA1890")]
			internal IReadOnlyList<object> PBHKKGCIJHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1280", Offset = "0x1F9FE80", VA = "0x181FA1280")]
			internal bool CFGKMIDNAHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1490", Offset = "0x1FA0090", VA = "0x181FA1490")]
			internal bool MDDGLBAOAOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1370", Offset = "0x1F9FF70", VA = "0x181FA1370")]
			internal void HBMIICIOFHN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D40", Offset = "0x1FA4940", VA = "0x181FA5D40")]
		public FKHGNOBPDNO(BBMNOHIFAAA NKENJJKCCKI, FBLDFJCKALP JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5560", Offset = "0x1FA4160", VA = "0x181FA5560", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class PLNMJLJBJBE : BFLCINEOBHL<OICGJONGBFO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAD440", Offset = "0xAAC040", VA = "0x180AAD440", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAFC0", Offset = "0x1FB9BC0", VA = "0x181FBAFC0")]
		public PLNMJLJBJBE(BBMNOHIFAAA NKENJJKCCKI, OICGJONGBFO AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class HBPJPHAPOOP : EFBOHHPDNHP<LCELLCJHALC>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class ABCHKPCFPAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public HBPJPHAPOOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ABCHKPCFPAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FA0780", Offset = "0x1F9F380", VA = "0x181FA0780")]
			internal int CHAFAJKMIDI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA0800", Offset = "0x1F9F400", VA = "0x181FA0800")]
			internal void OLFCCCKEFDJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FA67C0", Offset = "0x1FA53C0", VA = "0x181FA67C0")]
		public HBPJPHAPOOP(BBMNOHIFAAA NKENJJKCCKI, LCELLCJHALC JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6530", Offset = "0x1FA5130", VA = "0x181FA6530", Slot = "126")]
		protected override void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class KACDBEECNDK : NMGPAJANPNI<FAGMOBHLFOM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class CHMNMPLIAIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KACDBEECNDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public CHMNMPLIAIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2730", Offset = "0x1FA1330", VA = "0x181FA2730")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2780", Offset = "0x1FA1380", VA = "0x181FA2780")]
			internal void NJBLCJPFOPH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0EB0", Offset = "0x1FAFAB0", VA = "0x181FB0EB0")]
		public KACDBEECNDK(BBMNOHIFAAA NKENJJKCCKI, FAGMOBHLFOM JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0CD0", Offset = "0x1FAF8D0", VA = "0x181FB0CD0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class PKJCPHPOMEL : NMGPAJANPNI<FNAFOKMAGKH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class IOGHFPAAJDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public PKJCPHPOMEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public IOGHFPAAJDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF590", Offset = "0x1FAE190", VA = "0x181FAF590")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF5E0", Offset = "0x1FAE1E0", VA = "0x181FAF5E0")]
			internal void NJBLCJPFOPH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAE70", Offset = "0x1FB9A70", VA = "0x181FBAE70")]
		public PKJCPHPOMEL(BBMNOHIFAAA NKENJJKCCKI, FNAFOKMAGKH JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAC90", Offset = "0x1FB9890", VA = "0x181FBAC90", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class HHKDNLIILBL : NMGPAJANPNI<OBJIMJBKFOI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class KKLNEOBKOAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public HHKDNLIILBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public KKLNEOBKOAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x1FB18B0", Offset = "0x1FB04B0", VA = "0x181FB18B0")]
			internal int BJEBONJACJN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1900", Offset = "0x1FB0500", VA = "0x181FB1900")]
			internal void NJBLCJPFOPH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9090", Offset = "0x1FA7C90", VA = "0x181FA9090")]
		public HHKDNLIILBL(BBMNOHIFAAA NKENJJKCCKI, OBJIMJBKFOI JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8E30", Offset = "0x1FA7A30", VA = "0x181FA8E30", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class LHFDBBABGCL : HPNHCBBNPHA<NCJDHNMPOHN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override FIKOPHFGBHL HOMKKINNPGF
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "126")]
			get
			{
				return default(FIKOPHFGBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1C80", Offset = "0x1FB0880", VA = "0x181FB1C80")]
		public LHFDBBABGCL(BBMNOHIFAAA NKENJJKCCKI, NCJDHNMPOHN JPJGGLNFIBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class LKIMPDCEHFB : NMGPAJANPNI<ECHKNCNLALD>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9100", Offset = "0x1FA7D00", VA = "0x181FA9100")]
		public LKIMPDCEHFB(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public abstract class NMGPAJANPNI<TNode> : OAAKPGFEBMO, IDisposable where TNode : notnull, ECHKNCNLALD
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class GKBJKCLLJOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public NMGPAJANPNI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public BBMNOHIFAAA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public GKBJKCLLJOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x3D4E400", Offset = "0x3D4D000", VA = "0x183D4E400")]
			internal HPJKJOBIEID FCDLKHEOIMG(BKPJEIMFEEC portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private struct NJBGBIFMJMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public NMGPAJANPNI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x45040F0", Offset = "0x4502CF0", VA = "0x1845040F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct OGONMGCLMNI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public NMGPAJANPNI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public OFADLKEABJI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CAELIJMJDML? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x4693E40", Offset = "0x4692A40", VA = "0x184693E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x46940F0", Offset = "0x4692CF0", VA = "0x1846940F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class ELOLNEGPFDJ
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
				public ELOLNEGPFDJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x3572D40", Offset = "0x3571940", VA = "0x183572D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
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
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public NMGPAJANPNI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public GADLAGDBJEO configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ELOLNEGPFDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			internal string CCCKGGGNKMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
			internal void GCBIMKIIMEN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x384FE40", Offset = "0x384EA40", VA = "0x18384FE40")]
			[AsyncStateMachine(typeof(NMGPAJANPNI<>.ELOLNEGPFDJ.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void AHFDOGLDHFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class IAHCMCIJIKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public IAHCMCIJIKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x3E88200", Offset = "0x3E86E00", VA = "0x183E88200")]
			internal bool CMBNEOPIPPC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3E882E0", Offset = "0x3E86EE0", VA = "0x183E882E0")]
			internal bool MMKEJDHNOLH(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct BFIOHNCGMOE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public NMGPAJANPNI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4E68FE0", Offset = "0x4E67BE0", VA = "0x184E68FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4E69370", Offset = "0x4E67F70", VA = "0x184E69370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly BBMNOHIFAAA HHKBPMIKABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly bool GNAHJJAHCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private PAOCMADHIKK<NKOLEFJCHJO, HPJKJOBIEID> OBENMDGOFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private PAOCMADHIKK<NKOLEFJCHJO, GONIPNMLBFC> FEGIOMJDJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private List<Action> KLJJAIPNIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[CompilerGenerated]
		private Action<JCIKKDEFAFO<NKOLEFJCHJO>>? IMBEHKLFDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[CompilerGenerated]
		private Action<JCIKKDEFAFO<NKOLEFJCHJO>, GONIPNMLBFC>? OBAFDDGODPL;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected NGAKEPLJGMP PIHKKAFDPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x4531A30", Offset = "0x4530630", VA = "0x184531A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected AKGCFGGDMPM MAJGAHCFKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x452F5D0", Offset = "0x452E1D0", VA = "0x18452F5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode ALAPOEEMCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public ABKJIOOEHEB<INPGPFPHLDA> FMDIMOOKEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xB25FE0", Offset = "0xB24BE0", VA = "0x180B25FE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(ABKJIOOEHEB<INPGPFPHLDA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public JCIKKDEFAFO<BJGMDIFIIGE> LOHLNACPBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x4534040", Offset = "0x4532C40", VA = "0x184534040", Slot = "6")]
			get
			{
				return default(JCIKKDEFAFO<BJGMDIFIIGE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object OAKDNPEENLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x38A2C90", Offset = "0x38A1890", VA = "0x1838A2C90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool GHNPDGCGFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int LNDJCPFPLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4533C70", Offset = "0x4532870", VA = "0x184533C70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IOGKBBNKEMJ FGMFEJIJGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x4533C10", Offset = "0x4532810", VA = "0x184533C10", Slot = "10")]
			get
			{
				return default(IOGKBBNKEMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string MIMPDGPKHAO
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x4534200", Offset = "0x4532E00", VA = "0x184534200", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool NJNAPFLFCFP
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public JCIKKDEFAFO<NEPHPGNGDJL> MDKIACJEIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x932DE0", Offset = "0x9319E0", VA = "0x180932DE0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(JCIKKDEFAFO<NEPHPGNGDJL>);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xB15C80", Offset = "0xB14880", VA = "0x180B15C80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool OJONDAACMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool LJBGOPBBKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual JFCKMIDDHIJ JFOOBMANEEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA7E8B0", Offset = "0xA7D4B0", VA = "0x180A7E8B0", Slot = "94")]
			get
			{
				return default(JFCKMIDDHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool LDOAEDCBGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4533920", Offset = "0x4532520", VA = "0x184533920", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OCCEMFMNFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4533990", Offset = "0x4532590", VA = "0x184533990", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KNIONOCPEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4533A00", Offset = "0x4532600", VA = "0x184533A00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int DHKGOGFIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x4533FE0", Offset = "0x4532BE0", VA = "0x184533FE0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AIPDCPEPOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x4533E00", Offset = "0x4532A00", VA = "0x184533E00", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool LEAHHGEIEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x4533B30", Offset = "0x4532730", VA = "0x184533B30", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KBJHMNJEEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x4533AC0", Offset = "0x45326C0", VA = "0x184533AC0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool BODFGAJHOOB
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xC67E70", Offset = "0xC66A70", VA = "0x180C67E70", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xC68130", Offset = "0xC66D30", VA = "0x180C68130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool LPGMFPKPEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CLBLLBBELPE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4533A70", Offset = "0x4532670", VA = "0x184533A70", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool FJNFNJLBOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4533D30", Offset = "0x4532930", VA = "0x184533D30", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public OFADLKEABJI BOKOHHFILBG
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4533F20", Offset = "0x4532B20", VA = "0x184533F20", Slot = "28")]
			get
			{
				return default(OFADLKEABJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public CAELIJMJDML CKGMEBIHNIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4533F80", Offset = "0x4532B80", VA = "0x184533F80", Slot = "30")]
			get
			{
				return default(CAELIJMJDML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool CBDNNBFPEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual GINMHDACIOK? OADOFFKDHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual HBLDMCMGHKL? APPOBIHLHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<ABKJIOOEHEB<BKMEFFNPIFK>>? ECEMHODNKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool OEDAFMJJONE
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x4533BA0", Offset = "0x45327A0", VA = "0x184533BA0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public ABKJIOOEHEB<LDNFOKBFEMK> OCJEGEPGNEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4533E60", Offset = "0x4532A60", VA = "0x184533E60", Slot = "62")]
			get
			{
				return default(ABKJIOOEHEB<LDNFOKBFEMK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public JCIKKDEFAFO<LDNFOKBFEMK> JNBAGJLKCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4533CD0", Offset = "0x45328D0", VA = "0x184533CD0", Slot = "56")]
			get
			{
				return default(JCIKKDEFAFO<LDNFOKBFEMK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool ENADKJJLNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual JCIKKDEFAFO<LDNFOKBFEMK>? BNILNIJJJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool ECBFNBFDMJB
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool FLNAAFOOANK
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4533D90", Offset = "0x4532990", VA = "0x184533D90", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871070", VA = "0x180872470", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x872420", Offset = "0x871020", VA = "0x180872420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string FJMOAEMJKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8723A0", Offset = "0x870FA0", VA = "0x1808723A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ABKJIOOEHEB<BKMEFFNPIFK> IFEBGIOFLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x4533EC0", Offset = "0x4532AC0", VA = "0x184533EC0", Slot = "63")]
			get
			{
				return default(ABKJIOOEHEB<BKMEFFNPIFK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public ABKJIOOEHEB<BKMEFFNPIFK>? EPEMIGDHAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x45340D0", Offset = "0x4532CD0", VA = "0x1845340D0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public LDMIEKANPMO<NKOLEFJCHJO, GONIPNMLBFC> HMOEHMKPFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x45341C0", Offset = "0x4532DC0", VA = "0x1845341C0", Slot = "65")]
			get
			{
				return default(LDMIEKANPMO<NKOLEFJCHJO, GONIPNMLBFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual JCIKKDEFAFO<NKOLEFJCHJO>? GOKCJEALDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool BJEJMCNFGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool FNMDEFKGEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LIGFIBKEMBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4532060", Offset = "0x4530C60", VA = "0x184532060", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4531A90", Offset = "0x4530690", VA = "0x184531A90", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PPFEKEBPDCD BDGNOEIGMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4532C90", Offset = "0x4531890", VA = "0x184532C90", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4532350", Offset = "0x4530F50", VA = "0x184532350", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KAHONEKGKLC ENDKFEEHIAG
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4531CC0", Offset = "0x45308C0", VA = "0x184531CC0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4533280", Offset = "0x4531E80", VA = "0x184533280", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action NLFCOEBBDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4531190", Offset = "0x452FD90", VA = "0x184531190", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4532E50", Offset = "0x4531A50", VA = "0x184532E50", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action INIFKDALMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4530750", Offset = "0x452F350", VA = "0x184530750", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x452FF80", Offset = "0x452EB80", VA = "0x18452FF80", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>, GONIPNMLBFC> HGODHAOKLDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4530CB0", Offset = "0x452F8B0", VA = "0x184530CB0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x45323F0", Offset = "0x4530FF0", VA = "0x1845323F0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>, GONIPNMLBFC> PINGAPDDHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4532200", Offset = "0x4530E00", VA = "0x184532200", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4532100", Offset = "0x4530D00", VA = "0x184532100", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>> NIJNEDBGMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x452E680", Offset = "0x452D280", VA = "0x18452E680", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4530D70", Offset = "0x452F970", VA = "0x184530D70", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>, JCIKKDEFAFO<NKOLEFJCHJO>> EOLMNLJHCBE
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x452EF40", Offset = "0x452DB40", VA = "0x18452EF40", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4530570", Offset = "0x452F170", VA = "0x184530570", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>, GONIPNMLBFC> IFODBDGFIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4530650", Offset = "0x452F250", VA = "0x184530650", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4531B30", Offset = "0x4530730", VA = "0x184531B30", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<JCIKKDEFAFO<NKOLEFJCHJO>, JCIKKDEFAFO<NKOLEFJCHJO>> AEJHKOKDBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x452EE80", Offset = "0x452DA80", VA = "0x18452EE80", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4531F50", Offset = "0x4530B50", VA = "0x184531F50", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4533320", Offset = "0x4531F20", VA = "0x184533320")]
		[ENAFOIIGLJJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[ENAFOIIGLJJ("Need to handle `Name` better.")]
		protected NMGPAJANPNI(BBMNOHIFAAA NKENJJKCCKI, TNode AIJMDPAKHCL, bool OCKMJDPMBAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4532520", Offset = "0x4531120", VA = "0x184532520", Slot = "87")]
		protected virtual void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x452F6B0", Offset = "0x452E2B0", VA = "0x18452F6B0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4530C00", Offset = "0x452F800", VA = "0x184530C00", Slot = "9")]
		[AsyncStateMachine(typeof(NMGPAJANPNI<>.NJBGBIFMJMM))]
		public void GCODIKMDLJP(int BLCDFKBIBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x4533210", Offset = "0x4531E10", VA = "0x184533210")]
		public bool PELOCLMPBFF([In] OFADLKEABJI IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x45324B0", Offset = "0x45310B0", VA = "0x1845324B0")]
		public bool NGKFEJJHPHH([In] CAELIJMJDML IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x4531690", Offset = "0x4530290", VA = "0x184531690", Slot = "32")]
		public void JJPALGDJFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x45318A0", Offset = "0x45304A0", VA = "0x1845318A0", Slot = "33")]
		[AsyncStateMachine(typeof(NMGPAJANPNI<>.OGONMGCLMNI))]
		public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> JMIHGOLIFMD(OFADLKEABJI? PNBKCIFAGHL, CAELIJMJDML? DIBEOMGKEFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "97")]
		public virtual void BFOGCANFHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "98")]
		public virtual void PMBDNDMDMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "99")]
		public virtual void GGIOLFFDODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1D532B0", Offset = "0x1D51EB0", VA = "0x181D532B0")]
		protected void LACDDNJLFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x45312D0", Offset = "0x452FED0", VA = "0x1845312D0")]
		protected void JGBAACGJLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x219DFC0", Offset = "0x219CBC0", VA = "0x18219DFC0")]
		private void ICGDEBKAJFC([In] CAELIJMJDML GPEICHFGELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x4531BF0", Offset = "0x45307F0", VA = "0x184531BF0", Slot = "100")]
		public virtual Task<NLDGPBPIIJN<JCIKKDEFAFO<NKOLEFJCHJO>, MFMODGJHEIL>> LGGGMOCHLEO(string LONKACOOPGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4530430", Offset = "0x452F030", VA = "0x184530430", Slot = "101")]
		public virtual Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> EJDODLOMFHO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "102")]
		public virtual void NPLPMHJIAGG(JCIKKDEFAFO<NKOLEFJCHJO> IFLJHBOADJH, JCIKKDEFAFO<NKOLEFJCHJO> MOGNJDPKPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x45322C0", Offset = "0x4530EC0", VA = "0x1845322C0", Slot = "103")]
		public virtual IEnumerable<JPJAJOPEHEI> MOJJMIMNELO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4531EC0", Offset = "0x4530AC0", VA = "0x184531EC0", Slot = "104")]
		public NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL> LMJDLNIMEHG(string CJGDDAIMGOL)
		{
			return default(NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x452F340", Offset = "0x452DF40", VA = "0x18452F340", Slot = "47")]
		public bool DCGEIKCAFKN([Out] Guid KLLNIJEHEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x4530E30", Offset = "0x452FA30", VA = "0x184530E30")]
		public bool IAOAFGFCHCC([In] Guid CJJOKEDEAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "105")]
		public virtual void LEJCELDJPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "106")]
		public virtual void LNHFNPOAPFP(bool LCNFDKANLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "107")]
		public virtual HGCLFNDIBGH LPPEFIPKFAO([In] KMDMHJDLNPC ALBBDMHKEOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x452E740", Offset = "0x452D340", VA = "0x18452E740")]
		protected void BHMEPMEDOCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x452F300", Offset = "0x452DF00", VA = "0x18452F300", Slot = "112")]
		protected virtual bool DCEACDKKFDO(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "113")]
		protected virtual bool DFOKAPNEMNG(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected virtual void KLJHIABOKMF(GADLAGDBJEO COOKCNFHKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x4530020", Offset = "0x452EC20", VA = "0x184530020")]
		protected void EGOBAEGFOFJ(GADLAGDBJEO GLJNOBBOEPL, Func<string> JDNKDHJHPFK, Action<string> FIMFMAPCNJA, string HOOEMGGLGOC, string EEILFPCNOJI, string AJEMFHBLDPO, CLOPCJOIJHE AIJDHILJIDK, DIIOGNCDFDP NKFBLDDFLFP, Func<string, bool> JCHFOFJANJK, string EJGKJKKONCP, Func<string, bool> PGIKJFCECDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x452F000", Offset = "0x452DC00", VA = "0x18452F000")]
		protected void DBCDAFHGMLG(GADLAGDBJEO GLJNOBBOEPL, Func<string> JDNKDHJHPFK, Action<string> FIMFMAPCNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4532EF0", Offset = "0x4531AF0", VA = "0x184532EF0", Slot = "121")]
		protected virtual void OOPNDELBODB(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x4532010", Offset = "0x4530C10", VA = "0x184532010", Slot = "80")]
		public void LOJKBDLOBDN(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4533110", Offset = "0x4531D10", VA = "0x184533110", Slot = "81")]
		public MDCJCJDDPLM OPKIBFIMDEO()
		{
			return default(MDCJCJDDPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "124")]
		public virtual bool CDAGJJFDNOK(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1400780", Offset = "0x13FF380", VA = "0x181400780")]
		private void KMIAPKCDGNG([In] OFADLKEABJI DCDKACDAEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x4531D60", Offset = "0x4530960", VA = "0x184531D60")]
		private void LKEBJHLLOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x452E940", Offset = "0x452D540", VA = "0x18452E940")]
		private void BKJEBFCHMMD(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, BKPJEIMFEEC EHIABIKCKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7FC00", Offset = "0x1E7E800", VA = "0x181E7FC00")]
		private void BMAKIHGJNPN(JCIKKDEFAFO<NKOLEFJCHJO> CABAGOHBNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x452F4A0", Offset = "0x452E0A0", VA = "0x18452F4A0")]
		private void DFCMJGOFBKF(JCIKKDEFAFO<NKOLEFJCHJO> CABAGOHBNFK, BKPJEIMFEEC JBIKNJBNBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x45312F0", Offset = "0x452FEF0", VA = "0x1845312F0")]
		private void JIMACMAHGHB(JCIKKDEFAFO<NKOLEFJCHJO> IFLJHBOADJH, JCIKKDEFAFO<NKOLEFJCHJO> MOGNJDPKPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1E803C0", Offset = "0x1E7EFC0", VA = "0x181E803C0")]
		private void BJBHBJPLFHB(JCIKKDEFAFO<NKOLEFJCHJO> IFLJHBOADJH, JCIKKDEFAFO<NKOLEFJCHJO> MOGNJDPKPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4530630", Offset = "0x452F230", VA = "0x184530630")]
		private void ENLFEBNPIND(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x45307F0", Offset = "0x452F3F0", VA = "0x1845307F0")]
		private void FOICOCOIIIE(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, BKPJEIMFEEC EHIABIKCKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4530500", Offset = "0x452F100", VA = "0x184530500")]
		private void EKMMNONIAOL(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, BKPJEIMFEEC JBIKNJBNBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4532D30", Offset = "0x4531930", VA = "0x184532D30", Slot = "125")]
		[AsyncStateMachine(typeof(NMGPAJANPNI<>.BFIOHNCGMOE))]
		public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> OCNCOPGHAOI(string CJGDDAIMGOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4531260", Offset = "0x452FE60", VA = "0x184531260", Slot = "54")]
		private void JEJJHPBAMPG(object FCKEAEMBFLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x452E610", Offset = "0x452D210", VA = "0x18452E610", Slot = "55")]
		private void AIBIFNOKJMM(object FCKEAEMBFLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4532EB0", Offset = "0x4531AB0", VA = "0x184532EB0", Slot = "29")]
		private bool OOPFCPFPDAG([In] OFADLKEABJI IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x45321C0", Offset = "0x4530DC0", VA = "0x1845321C0", Slot = "31")]
		private bool MNFCOEKEJJE([In] CAELIJMJDML IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4530710", Offset = "0x452F310", VA = "0x184530710", Slot = "48")]
		private bool FBDNAKOMEGH([In] Guid CJJOKEDEAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x45319F0", Offset = "0x45305F0", VA = "0x1845319F0")]
		[CompilerGenerated]
		private string JMILPEJFGHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x45310E0", Offset = "0x452FCE0", VA = "0x1845310E0")]
		[CompilerGenerated]
		private void IGCLMJNJGIH(string LONKACOOPGJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class PGAOHGDACMF : BFLCINEOBHL<FMIBAEOMBAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xCC0070", Offset = "0xCBEC70", VA = "0x180CC0070", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAC30", Offset = "0x1FB9830", VA = "0x181FBAC30")]
		public PGAOHGDACMF(BBMNOHIFAAA NKENJJKCCKI, FMIBAEOMBAE AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private sealed class OLCGGJJFNDB : GPPHMPPDKOB<OEGGFOOILIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9D10", Offset = "0x1FB8910", VA = "0x181FB9D10")]
		public OLCGGJJFNDB(BBMNOHIFAAA NKENJJKCCKI, OEGGFOOILIJ AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public abstract class HPNHCBBNPHA<T> : NMGPAJANPNI<T> where T : notnull, PDKPNAECMBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class PFDJDDBMHHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public IReadOnlyList<KeyValuePair<string, JBBDCCJMFFN>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public HPNHCBBNPHA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public FIKOPHFGBHL clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PFDJDDBMHHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			internal IReadOnlyList<KeyValuePair<string, JBBDCCJMFFN>> BJEBONJACJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4784D30", Offset = "0x4783930", VA = "0x184784D30")]
			internal int NJBLCJPFOPH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4784B10", Offset = "0x4783710", VA = "0x184784B10")]
			internal void MJDBNIPDNIP(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4784E90", Offset = "0x4783A90", VA = "0x184784E90")]
			internal void PBHKKGCIJHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4784640", Offset = "0x4783240", VA = "0x184784640")]
			internal void CFGKMIDNAHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x47848B0", Offset = "0x47834B0", VA = "0x1847848B0")]
			internal bool MDDGLBAOAOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4784940", Offset = "0x4783540", VA = "0x184784940")]
			internal void HBMIICIOFHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x47848B0", Offset = "0x47834B0", VA = "0x1847848B0")]
			internal bool FLJOBEJBJOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4784790", Offset = "0x4783390", VA = "0x184784790")]
			internal float CFMLJBAHOJH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4784A50", Offset = "0x4783650", VA = "0x184784A50")]
			internal void JLJIJKJJEOO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x47849F0", Offset = "0x47835F0", VA = "0x1847849F0")]
			internal float JKHLNBFGEPK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4784580", Offset = "0x4783180", VA = "0x184784580")]
			internal void ALBHLGCKJBI(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4784990", Offset = "0x4783590", VA = "0x184784990")]
			internal float JHMLAJHEFFM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x47847F0", Offset = "0x47833F0", VA = "0x1847847F0")]
			internal void EOAGMMIEKGO(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CE5F0", VA = "0x1808CF9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract FIKOPHFGBHL HOMKKINNPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C122A0", Offset = "0x3C10EA0", VA = "0x183C122A0")]
		public HPNHCBBNPHA(BBMNOHIFAAA NKENJJKCCKI, T AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1730", Offset = "0x3DF0330", VA = "0x183DF1730", Slot = "120")]
		protected sealed override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class LIJJKHJOEMK : NMGPAJANPNI<HJMNALNMFJE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x920350", Offset = "0x91EF50", VA = "0x180920350", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1F50", Offset = "0x1FB0B50", VA = "0x181FB1F50")]
		public LIJJKHJOEMK(BBMNOHIFAAA NKENJJKCCKI, HJMNALNMFJE AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class KDKICHGBEDL : NMGPAJANPNI<FFINKBGECCD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class PKLFPBGDBBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public KDKICHGBEDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PKLFPBGDBBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAF70", Offset = "0x1FB9B70", VA = "0x181FBAF70")]
			internal int NJBLCJPFOPH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAEE0", Offset = "0x1FB9AE0", VA = "0x181FBAEE0")]
			internal void MJDBNIPDNIP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private static Dictionary<string, JBBDCCJMFFN>? EHEDPOFJAMN;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB12A0", Offset = "0x1FAFEA0", VA = "0x181FB12A0")]
		public KDKICHGBEDL(BBMNOHIFAAA NKENJJKCCKI, FFINKBGECCD AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0F20", Offset = "0x1FAFB20", VA = "0x181FB0F20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class DGKMJIEHFCJ : HPNHCBBNPHA<IOGFPCMDKDA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override FIKOPHFGBHL HOMKKINNPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "126")]
			get
			{
				return default(FIKOPHFGBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3DA0", Offset = "0x1FA29A0", VA = "0x181FA3DA0")]
		public DGKMJIEHFCJ(BBMNOHIFAAA NKENJJKCCKI, IOGFPCMDKDA JPJGGLNFIBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class FDOMHBKPJII : GPPHMPPDKOB<LGKADHEFNEN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5150", Offset = "0x1FA3D50", VA = "0x181FA5150")]
		public FDOMHBKPJII(BBMNOHIFAAA NKENJJKCCKI, LGKADHEFNEN AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class KPBOOIBIPAE : GPPHMPPDKOB<CKHAAODKOHD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1FB19B0", Offset = "0x1FB05B0", VA = "0x181FB19B0")]
		public KPBOOIBIPAE(BBMNOHIFAAA NKENJJKCCKI, CKHAAODKOHD AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class PCDMEHCBMNO : EFBOHHPDNHP<KGPPANDNDGF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class ADKKMEKIDDG
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
				public ADKKMEKIDDG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x1FBB020", Offset = "0x1FB9C20", VA = "0x181FBB020", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public PCDMEHCBMNO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ADKKMEKIDDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x1FA08A0", Offset = "0x1F9F4A0", VA = "0x181FA08A0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void CHAFAJKMIDI(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAAB0", Offset = "0x1FB96B0", VA = "0x181FBAAB0")]
		public PCDMEHCBMNO(BBMNOHIFAAA NKENJJKCCKI, KGPPANDNDGF JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA7D0", Offset = "0x1FB93D0", VA = "0x181FBA7D0", Slot = "126")]
		protected override void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class OPKPCAJGLAO : HPNHCBBNPHA<HGAFIDMCGMP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override FIKOPHFGBHL HOMKKINNPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x8D5890", Offset = "0x8D4490", VA = "0x1808D5890", Slot = "126")]
			get
			{
				return default(FIKOPHFGBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA680", Offset = "0x1FB9280", VA = "0x181FBA680")]
		public OPKPCAJGLAO(BBMNOHIFAAA NKENJJKCCKI, HGAFIDMCGMP JPJGGLNFIBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private sealed class LIAMDFFEEJG : NMGPAJANPNI<DEOCBEFOIMF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x924A80", Offset = "0x923680", VA = "0x180924A80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1EE0", Offset = "0x1FB0AE0", VA = "0x181FB1EE0")]
		public LIAMDFFEEJG(BBMNOHIFAAA NKENJJKCCKI, DEOCBEFOIMF AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class JDEOKPCOAOG : NMGPAJANPNI<MJEJDEIMFGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool OJONDAACMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool NJNAPFLFCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FAFB60", Offset = "0x1FAE760", VA = "0x181FAFB60")]
		public JDEOKPCOAOG(BBMNOHIFAAA NKENJJKCCKI, MJEJDEIMFGH AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF830", Offset = "0x1FAE430", VA = "0x181FAF830", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF790", Offset = "0x1FAE390", VA = "0x181FAF790")]
		private int CEOOIKJFJKM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF7D0", Offset = "0x1FAE3D0", VA = "0x181FAF7D0")]
		private void FHDMOPIFPHD(int CLDDKGECHDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class HKJHCLEAMGG : LKIMPDCEHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9100", Offset = "0x1FA7D00", VA = "0x181FA9100")]
		public HKJHCLEAMGG(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class HAFACBIJLCB : EFBOHHPDNHP<JCONHJPKOJA>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA64D0", Offset = "0x1FA50D0", VA = "0x181FA64D0")]
		public HAFACBIJLCB(BBMNOHIFAAA NKENJJKCCKI, JCONHJPKOJA AIJMDPAKHCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public abstract class EFBOHHPDNHP<TVariableNode> : NMGPAJANPNI<TVariableNode> where TVariableNode : notnull, JCONHJPKOJA
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class ODDLCNNPIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public EFBOHHPDNHP<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ODDLCNNPIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x4647080", Offset = "0x4645C80", VA = "0x184647080")]
			internal bool BJEBONJACJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x46471F0", Offset = "0x4645DF0", VA = "0x1846471F0")]
			internal void NJBLCJPFOPH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x4647190", Offset = "0x4645D90", VA = "0x184647190")]
			internal bool MJDBNIPDNIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x46472B0", Offset = "0x4645EB0", VA = "0x1846472B0")]
			internal void PBHKKGCIJHM(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x46470E0", Offset = "0x4645CE0", VA = "0x1846470E0")]
			internal bool CFGKMIDNAHJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class DNBEKIEHACF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public AKGCFGGDMPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public EFBOHHPDNHP<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public DNBEKIEHACF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x58DD670", Offset = "0x58DC270", VA = "0x1858DD670")]
			internal void CHAFAJKMIDI(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA9FC10", Offset = "0xA9E810", VA = "0x180A9FC10", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override JFCKMIDDHIJ JFOOBMANEEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x383B5C0", Offset = "0x383A1C0", VA = "0x18383B5C0", Slot = "94")]
			get
			{
				return default(JFCKMIDDHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x383B410", Offset = "0x383A010", VA = "0x18383B410")]
		protected EFBOHHPDNHP(BBMNOHIFAAA NKENJJKCCKI, TVariableNode AIJMDPAKHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x383A920", Offset = "0x3839520", VA = "0x18383A920", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x383AAC0", Offset = "0x38396C0", VA = "0x18383AAC0", Slot = "120")]
		protected override void KLJHIABOKMF(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x383B070", Offset = "0x3839C70", VA = "0x18383B070", Slot = "126")]
		protected virtual void PHNNOKHNJGC(GADLAGDBJEO GLJNOBBOEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x383AF70", Offset = "0x3839B70", VA = "0x18383AF70", Slot = "105")]
		public override void LEJCELDJPNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C490", Offset = "0x1F9B090", VA = "0x181F9C490")]
	public static OAAKPGFEBMO FCDPFGJNKNI(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public sealed class JMODEJEOJAO : DAFLNLPNEEP, NBINKKELLDG, BLDDIIOIMMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JCIKKDEFAFO<EBPAJHFGHPO> EEICPMKJPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA75390", Offset = "0xA73F90", VA = "0x180A75390", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(JCIKKDEFAFO<EBPAJHFGHPO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public JCIKKDEFAFO<MGOHEMMBNJL> MKMPFCHHIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xF9A470", Offset = "0xF99070", VA = "0x180F9A470", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JCIKKDEFAFO<MGOHEMMBNJL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0640", Offset = "0x1FAF240", VA = "0x181FB0640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private JCIKKDEFAFO<NPNOGIJPNKK> LBIINICPOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xBCF3C0", Offset = "0xBCDFC0", VA = "0x180BCF3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override JCIKKDEFAFO<FAPNLCLMADD> KKHOFEODIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FB09A0", Offset = "0x1FAF5A0", VA = "0x181FB09A0", Slot = "20")]
		get
		{
			return default(JCIKKDEFAFO<FAPNLCLMADD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB09F0", Offset = "0x1FAF5F0", VA = "0x181FB09F0")]
	private JMODEJEOJAO(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL, GGOGFPLMNEN ADGHMGHNEHD, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<MGOHEMMBNJL> NHPBHEJEOBE, JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND, bool MEFBLMPNFJF, string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0650", Offset = "0x1FAF250", VA = "0x181FB0650")]
	public static JMODEJEOJAO FCDPFGJNKNI(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL, GGOGFPLMNEN KCIEOFBOPOK, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND, JCIKKDEFAFO<MGOHEMMBNJL> NHPBHEJEOBE, bool MEFBLMPNFJF, bool OCKMJDPMBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0640", Offset = "0x1FAF240", VA = "0x181FB0640")]
	internal void FAHNPDPGPDL(JCIKKDEFAFO<MGOHEMMBNJL> IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public abstract class DAFLNLPNEEP : BLDDIIOIMMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private struct HOCOLGNPPEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private OMAFGIIFLNO? JDHKJGIHCEO;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9170", Offset = "0x1FA7D70", VA = "0x181FA9170")]
		public void AFPCPCPKMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9180", Offset = "0x1FA7D80", VA = "0x181FA9180")]
		public OMAFGIIFLNO EPLGBBHNJDN(DAFLNLPNEEP LBIADDHMGDH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	protected readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	protected readonly ECHKNCNLALD AHOEDDANLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private HOCOLGNPPEJ FOJNHMLKFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly EOMPBOHKHDM AJBKCBLPLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly List<OPABDNDDGPG> APJNOFFKICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly List<CLBFDMKJGPO> CNCKOCIBEDK;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[ENAFOIIGLJJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> MGJIFMOAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2870", Offset = "0x1FA1470", VA = "0x181FA2870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind NIMLLPEDNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x875460", Offset = "0x874060", VA = "0x180875460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JCIKKDEFAFO<LDNFOKBFEMK> JNBAGJLKCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3430", Offset = "0x1FA2030", VA = "0x181FA3430", Slot = "6")]
		get
		{
			return default(JCIKKDEFAFO<LDNFOKBFEMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ABKJIOOEHEB<LDNFOKBFEMK> OCJEGEPGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2B70", Offset = "0x1FA1770", VA = "0x181FA2B70", Slot = "7")]
		get
		{
			return default(ABKJIOOEHEB<LDNFOKBFEMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AHBLCPHJJBG DCKNMLFHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1BE2560", Offset = "0x1BE1160", VA = "0x181BE2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HOPIPCKENDF KDKMGHIPHII
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2D10", Offset = "0x1FA1910", VA = "0x181FA2D10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OMAFGIIFLNO MLPMJPEADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2D10", Offset = "0x1FA1910", VA = "0x181FA2D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage DGMNDEMBDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3890", Offset = "0x1FA2490", VA = "0x181FA3890", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x86C590", Offset = "0x86B190", VA = "0x18086C590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public ABKJIOOEHEB<BKMEFFNPIFK> IFEBGIOFLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA34C0", Offset = "0x1FA20C0", VA = "0x181FA34C0", Slot = "9")]
		get
		{
			return default(ABKJIOOEHEB<BKMEFFNPIFK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public JCIKKDEFAFO<NKOLEFJCHJO> FJMJDNNIAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x9BA910", Offset = "0x9B9510", VA = "0x1809BA910", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JCIKKDEFAFO<NKOLEFJCHJO>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xEA9C70", Offset = "0xEA8870", VA = "0x180EA9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract JCIKKDEFAFO<FAPNLCLMADD> KKHOFEODIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3BA0", Offset = "0x1FA27A0", VA = "0x181FA3BA0")]
	protected DAFLNLPNEEP(BBMNOHIFAAA NKENJJKCCKI, ECHKNCNLALD AIJMDPAKHCL, EOMPBOHKHDM IKPNOAEKCNK, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, bool MEFBLMPNFJF, string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3740", Offset = "0x1FA2340", VA = "0x181FA3740", Slot = "21")]
	protected virtual void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2BA0", Offset = "0x1FA17A0", VA = "0x181FA2BA0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1FA34E0", Offset = "0x1FA20E0", VA = "0x181FA34E0", Slot = "14")]
	public void LEBLGCGFEHF(OPABDNDDGPG OGEMOEEFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3B40", Offset = "0x1FA2740", VA = "0x181FA3B40", Slot = "15")]
	public void PNIMPBOLNAF(CLBFDMKJGPO OGEMOEEFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2DB0", Offset = "0x1FA19B0", VA = "0x181FA2DB0", Slot = "16")]
	public void GDAGFMCANNA(LNCAMHNMJGM EFKJDJMMPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3540", Offset = "0x1FA2140", VA = "0x181FA3540", Slot = "23")]
	protected virtual void LEKBFALEFAC(LNCAMHNMJGM EFKJDJMMPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1FA39C0", Offset = "0x1FA25C0", VA = "0x181FA39C0")]
	private void OACMDCDGIIH(bool LDAADCAOFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1FA29C0", Offset = "0x1FA15C0", VA = "0x181FA29C0")]
	private void CIPBCGPNHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1FA35A0", Offset = "0x1FA21A0", VA = "0x181FA35A0")]
	private void MKABDDFNBFD([In] GIJBCJHANOI JHLKNLCJOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2810", Offset = "0x1FA1410", VA = "0x181FA2810", Slot = "17")]
	public void AAFOPKAGAGO(OPABDNDDGPG OGEMOEEFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3460", Offset = "0x1FA2060", VA = "0x181FA3460", Slot = "18")]
	public void KABEJPMEFDG(CLBFDMKJGPO OGEMOEEFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x86C590", Offset = "0x86B190", VA = "0x18086C590")]
	internal void LCBCPBBLFOK(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2CF0", Offset = "0x1FA18F0", VA = "0x181FA2CF0")]
	internal void EFEOIJFGOIC(NNDFBECEIIM EIDBKEEIBKK, AHBLCPHJJBG HGPIKDLKBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xEA9C70", Offset = "0xEA8870", VA = "0x180EA9C70")]
	internal void FKIJPKDADIH(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class HPJKJOBIEID : GONIPNMLBFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class PFEHKBNMMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public BBMNOHIFAAA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public ECHKNCNLALD node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PFEHKBNMMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAB10", Offset = "0x1FB9710", VA = "0x181FBAB10")]
		internal AHFNDCJKMDE HFOMDJLJEGA((int PortDescIndex, int PortIndex, OKPNGBEAJGG InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBABA0", Offset = "0x1FB97A0", VA = "0x181FBABA0")]
		internal JMODEJEOJAO HJENONMJKPG(GGOGFPLMNEN i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct LLKHIDEKJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2380", Offset = "0x1FB0F80", VA = "0x181FB2380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB27E0", Offset = "0x1FB13E0", VA = "0x181FB27E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct MCNELMFMMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public JCIKKDEFAFO<JFMHBEEECHM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2C00", Offset = "0x1FB1800", VA = "0x181FB2C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2F50", Offset = "0x1FB1B50", VA = "0x181FB2F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct IEDDJEHPDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public JCIKKDEFAFO<NPNOGIJPNKK> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF1D0", Offset = "0x1FADDD0", VA = "0x181FAF1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF520", Offset = "0x1FAE120", VA = "0x181FAF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct ONCIDOGFPBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public JCIKKDEFAFO<JFMHBEEECHM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public JCIKKDEFAFO<JFMHBEEECHM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9D70", Offset = "0x1FB8970", VA = "0x181FB9D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA0C0", Offset = "0x1FB8CC0", VA = "0x181FBA0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct LJICFDPHNIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public JCIKKDEFAFO<NPNOGIJPNKK> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JCIKKDEFAFO<NPNOGIJPNKK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1FC0", Offset = "0x1FB0BC0", VA = "0x181FB1FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2310", Offset = "0x1FB0F10", VA = "0x181FB2310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct EJKIJDCJJLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4B90", Offset = "0x1FA3790", VA = "0x181FA4B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5000", Offset = "0x1FA3C00", VA = "0x181FA5000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct NBBFHMLACAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB34F0", Offset = "0x1FB20F0", VA = "0x181FB34F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3840", Offset = "0x1FB2440", VA = "0x181FB3840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct HEOGGOOFBED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public JCIKKDEFAFO<JFMHBEEECHM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8A70", Offset = "0x1FA7670", VA = "0x181FA8A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8DC0", Offset = "0x1FA79C0", VA = "0x181FA8DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct BGCEEEJIGFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public JCIKKDEFAFO<NPNOGIJPNKK> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0C20", Offset = "0x1F9F820", VA = "0x181FA0C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0F70", Offset = "0x1F9FB70", VA = "0x181FA0F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NFFPBOPMKCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public HJEILFHEDJO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JCIKKDEFAFO<JFMHBEEECHM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3DF0", Offset = "0x1FB29F0", VA = "0x181FB3DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4180", Offset = "0x1FB2D80", VA = "0x181FB4180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct NPDMJDKCIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public HPJKJOBIEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public HJEILFHEDJO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public JCIKKDEFAFO<NPNOGIJPNKK> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private MLJNEACEOMD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1FB87B0", Offset = "0x1FB73B0", VA = "0x181FB87B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8B40", Offset = "0x1FB7740", VA = "0x181FB8B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly bool GAHMOLENNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool GILBPFMFMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private LDMIEKANPMO<MHMFPDDJAPK, AHFNDCJKMDE> JIDPMBOKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private LDMIEKANPMO<MHMFPDDJAPK, GGCDLLOJFMN> AFFMPAOLFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly ECHKNCNLALD AHOEDDANLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LDMIEKANPMO<MGOHEMMBNJL, JMODEJEOJAO> DLEFDKELPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private LDMIEKANPMO<MGOHEMMBNJL, NBINKKELLDG> LKALIFDGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private string? EHCDIDHGNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly BKPJEIMFEEC ACODLMGBFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private JCIKKDEFAFO<NKOLEFJCHJO> PIJKGPFCPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool GNAHJJAHCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[CompilerGenerated]
	private Action? GCIBPHMCFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? IHHNMGNCJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<JCIKKDEFAFO<MHMFPDDJAPK>>? IJPLFGHGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	[CompilerGenerated]
	private Action<JCIKKDEFAFO<MGOHEMMBNJL>>? IJPFADKEPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private GONIPNMLBFC.CKIEJNFIBDF? CADOPLPEDFL;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JMLLNGPMEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD5E0", Offset = "0x1FAC1E0", VA = "0x181FAD5E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DODEFNEAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC060", Offset = "0x1FAAC60", VA = "0x181FAC060", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool MELBONMAGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA940", Offset = "0x1FA9540", VA = "0x181FAA940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ABKJIOOEHEB<LDNFOKBFEMK> OCJEGEPGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9E10", Offset = "0x1FA8A10", VA = "0x181FA9E10", Slot = "7")]
		get
		{
			return default(ABKJIOOEHEB<LDNFOKBFEMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool NLOLCEKHIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FAABB0", Offset = "0x1FA97B0", VA = "0x181FAABB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LDMIEKANPMO<MHMFPDDJAPK, GGCDLLOJFMN> ENJPBABBPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "9")]
		get
		{
			return default(LDMIEKANPMO<MHMFPDDJAPK, GGCDLLOJFMN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAECB0", Offset = "0x1FAD8B0", VA = "0x181FAECB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public ABKJIOOEHEB<BKMEFFNPIFK> IFEBGIOFLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD2D0", Offset = "0x1FABED0", VA = "0x181FAD2D0", Slot = "11")]
		get
		{
			return default(ABKJIOOEHEB<BKMEFFNPIFK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LDMIEKANPMO<MGOHEMMBNJL, NBINKKELLDG> FEIKOBJHHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0", Slot = "12")]
		get
		{
			return default(LDMIEKANPMO<MGOHEMMBNJL, NBINKKELLDG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public JCIKKDEFAFO<NKOLEFJCHJO> FJMJDNNIAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xBD06D0", Offset = "0xBCF2D0", VA = "0x180BD06D0", Slot = "13")]
		get
		{
			return default(JCIKKDEFAFO<NKOLEFJCHJO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action KHLMBIHCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1FADF40", Offset = "0x1FACB40", VA = "0x181FADF40", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEF70", Offset = "0x1FADB70", VA = "0x181FAEF70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action NFMJJJIOJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FABEF0", Offset = "0x1FAAAF0", VA = "0x181FABEF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FA93A0", Offset = "0x1FA7FA0", VA = "0x181FA93A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JCIKKDEFAFO<MHMFPDDJAPK>, JCIKKDEFAFO<MHMFPDDJAPK>> DEJAILHKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD8B0", Offset = "0x1FAC4B0", VA = "0x181FAD8B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FA92E0", Offset = "0x1FA7EE0", VA = "0x181FA92E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JCIKKDEFAFO<MHMFPDDJAPK>, JCIKKDEFAFO<MHMFPDDJAPK>> LPHGJOOFHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD2F0", Offset = "0x1FABEF0", VA = "0x181FAD2F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FABD70", Offset = "0x1FAA970", VA = "0x181FABD70", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JCIKKDEFAFO<MGOHEMMBNJL>, JCIKKDEFAFO<MGOHEMMBNJL>> FLAGJONIFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAAF0", Offset = "0x1FA96F0", VA = "0x181FAAAF0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC510", Offset = "0x1FAB110", VA = "0x181FAC510", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JCIKKDEFAFO<MGOHEMMBNJL>, JCIKKDEFAFO<MGOHEMMBNJL>> IDINPDFCFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FABFA0", Offset = "0x1FAABA0", VA = "0x181FABFA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD0E0", Offset = "0x1FABCE0", VA = "0x181FAD0E0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JCIKKDEFAFO<MHMFPDDJAPK>, GGCDLLOJFMN> DIFLKNKBNML
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAE70", Offset = "0x1FA9A70", VA = "0x181FAAE70", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9450", Offset = "0x1FA8050", VA = "0x181FA9450", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JCIKKDEFAFO<MHMFPDDJAPK>> HPAPGAONLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FACBD0", Offset = "0x1FAB7D0", VA = "0x181FACBD0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD7F0", Offset = "0x1FAC3F0", VA = "0x181FAD7F0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JCIKKDEFAFO<MHMFPDDJAPK>, GGCDLLOJFMN> LEAJDPKCJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF010", Offset = "0x1FADC10", VA = "0x181FAF010", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FABE30", Offset = "0x1FAAA30", VA = "0x181FABE30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JCIKKDEFAFO<MGOHEMMBNJL>, NBINKKELLDG> HGCAPONLGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FABC50", Offset = "0x1FAA850", VA = "0x181FABC50", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9510", Offset = "0x1FA8110", VA = "0x181FA9510", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<JCIKKDEFAFO<MGOHEMMBNJL>> IDGGACFIOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9220", Offset = "0x1FA7E20", VA = "0x181FA9220", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC5D0", Offset = "0x1FAB1D0", VA = "0x181FAC5D0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JCIKKDEFAFO<MGOHEMMBNJL>, NBINKKELLDG> CDIPAIGCBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FABA60", Offset = "0x1FAA660", VA = "0x181FABA60", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9D50", Offset = "0x1FA8950", VA = "0x181FA9D50", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF0D0", Offset = "0x1FADCD0", VA = "0x181FAF0D0")]
	private HPJKJOBIEID(bool MEFBLMPNFJF, BBMNOHIFAAA NKENJJKCCKI, bool ONEKAOLODKN, LDMIEKANPMO<MHMFPDDJAPK, AHFNDCJKMDE> HJOHPNILCPK, LDMIEKANPMO<MHMFPDDJAPK, GGCDLLOJFMN> NMBGECKIKBE, ECHKNCNLALD AIJMDPAKHCL, LDMIEKANPMO<MGOHEMMBNJL, JMODEJEOJAO> IJGFEGNCDMF, LDMIEKANPMO<MGOHEMMBNJL, NBINKKELLDG> NNGOIOEOOPA, string? NAJHACAKFCM, BKPJEIMFEEC EHIABIKCKIK, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, bool OCKMJDPMBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAF30", Offset = "0x1FA9B30", VA = "0x181FAAF30")]
	public static HPJKJOBIEID FCDPFGJNKNI(bool MEFBLMPNFJF, BBMNOHIFAAA NKENJJKCCKI, bool ONEKAOLODKN, ECHKNCNLALD AIJMDPAKHCL, BKPJEIMFEEC EHIABIKCKIK, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, bool OCKMJDPMBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE4A0", Offset = "0x1FAD0A0", VA = "0x181FAE4A0")]
	private void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9E40", Offset = "0x1FA8A40", VA = "0x181FA9E40", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD970", Offset = "0x1FAC570", VA = "0x181FAD970", Slot = "38")]
	[AsyncStateMachine(typeof(LLKHIDEKJEA))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> MFAAJECIBNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD3B0", Offset = "0x1FABFB0", VA = "0x181FAD3B0")]
	private (FJFAHIHMONA, int)? LAFHKJEMIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB950", Offset = "0x1FAA550", VA = "0x181FAB950")]
	private void GEJAJOJKJDP(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x141A210", Offset = "0x1418E10", VA = "0x18141A210")]
	private void MKOMKOAOJKG(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1FADA60", Offset = "0x1FAC660", VA = "0x181FADA60")]
	private void MFEHCANIOJP(int HOENBOIFFLG, int OMLABPEGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FABD10", Offset = "0x1FAA910", VA = "0x181FABD10")]
	private void HFINPLADKLN(int HOENBOIFFLG, int OMLABPEGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC690", Offset = "0x1FAB290", VA = "0x181FAC690")]
	private void JMDBMDILJCE(int GOHBLKKDHKG, JCIKKDEFAFO<MHMFPDDJAPK> AIINDKPJIPH, OKPNGBEAJGG GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FADF20", Offset = "0x1FACB20", VA = "0x181FADF20")]
	private void NEMINLNDGCG(int LDAADCAOFLJ, JCIKKDEFAFO<MHMFPDDJAPK> AIINDKPJIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FABA40", Offset = "0x1FAA640", VA = "0x181FABA40")]
	private void GGOEDOINNCN(int LDAADCAOFLJ, JCIKKDEFAFO<MHMFPDDJAPK> AIINDKPJIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FACC90", Offset = "0x1FAB890", VA = "0x181FACC90")]
	private void KDCKGENNDHI(int GOHBLKKDHKG, JCIKKDEFAFO<MHMFPDDJAPK> AIINDKPJIPH, OKPNGBEAJGG GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAD20", Offset = "0x1FA9920", VA = "0x181FAAD20")]
	private void EONLBJJPBHK(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xADC880", Offset = "0xADB480", VA = "0x180ADC880")]
	private void GBAMPEFKBAF(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAA00", Offset = "0x1FA9600", VA = "0x181FAAA00")]
	private void EEOMABJHHJE(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x141A210", Offset = "0x1418E10", VA = "0x18141A210")]
	private void IJCIKPIMGAJ(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE100", Offset = "0x1FACD00", VA = "0x181FAE100")]
	private void NJBNAMPJDHO(int HOENBOIFFLG, int OMLABPEGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEC50", Offset = "0x1FAD850", VA = "0x181FAEC50")]
	private void NLAKPEMDJLG(int HOENBOIFFLG, int OMLABPEGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9810", Offset = "0x1FA8410", VA = "0x181FA9810")]
	private void CEHALPJFBKI(int GOHBLKKDHKG, JCIKKDEFAFO<MGOHEMMBNJL> AIINDKPJIPH, GGOGFPLMNEN GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAECE0", Offset = "0x1FAD8E0", VA = "0x181FAECE0")]
	private void NOKGILOJAMM(int LDAADCAOFLJ, JCIKKDEFAFO<MGOHEMMBNJL> AIINDKPJIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD7D0", Offset = "0x1FAC3D0", VA = "0x181FAD7D0")]
	private void LFDPBKBNDEC(int LDAADCAOFLJ, JCIKKDEFAFO<MGOHEMMBNJL> AIINDKPJIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC0A0", Offset = "0x1FAACA0", VA = "0x181FAC0A0")]
	private void JDHJEHKEBMF(int GOHBLKKDHKG, JCIKKDEFAFO<MGOHEMMBNJL> AIINDKPJIPH, GGOGFPLMNEN GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEE20", Offset = "0x1FADA20", VA = "0x181FAEE20")]
	private void OLIKGPHCGPP(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xADC880", Offset = "0xADB480", VA = "0x180ADC880")]
	private void NMIOPBAKBJA(int GOHBLKKDHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1FA95D0", Offset = "0x1FA81D0", VA = "0x181FA95D0", Slot = "39")]
	[AsyncStateMachine(typeof(MCNELMFMMNJ))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> BJMGIDFDDIL(JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB4A0", Offset = "0x1FAA0A0", VA = "0x181FAB4A0", Slot = "40")]
	[AsyncStateMachine(typeof(IEDDJEHPDGF))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> FDCKGBBMPAO(JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FADE00", Offset = "0x1FACA00", VA = "0x181FADE00", Slot = "41")]
	[AsyncStateMachine(typeof(ONCIDOGFPBN))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> MFGBLOFLHPG(JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN, JCIKKDEFAFO<JFMHBEEECHM> KADMDJHKDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FADFE0", Offset = "0x1FACBE0", VA = "0x181FADFE0", Slot = "42")]
	[AsyncStateMachine(typeof(LJICFDPHNIA))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> NGICKEPNAED(JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND, JCIKKDEFAFO<NPNOGIJPNKK> KADMDJHKDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAC30", Offset = "0x1FA9830", VA = "0x181FAAC30", Slot = "43")]
	[AsyncStateMachine(typeof(EJKIJDCJJLG))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> ENNMAGAPOPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED00", Offset = "0x1FAD900", VA = "0x181FAED00", Slot = "44")]
	[AsyncStateMachine(typeof(NBBFHMLACAB))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> OGMBMGPCADE(string CJGDDAIMGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD6A0", Offset = "0x1FAC2A0", VA = "0x181FAD6A0", Slot = "45")]
	[AsyncStateMachine(typeof(HEOGGOOFBED))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> LFDLKBJECAC(JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN, string LONKACOOPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FA96E0", Offset = "0x1FA82E0", VA = "0x181FA96E0", Slot = "46")]
	[AsyncStateMachine(typeof(BGCEEEJIGFH))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> BKNNOFEBOBB(JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND, string LONKACOOPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD1A0", Offset = "0x1FABDA0", VA = "0x181FAD1A0", Slot = "47")]
	[AsyncStateMachine(typeof(NFFPBOPMKCM))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> KNAPBBKMKBK(JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN, HJEILFHEDJO HGPIKDLKBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FABB20", Offset = "0x1FAA720", VA = "0x181FABB20", Slot = "48")]
	[AsyncStateMachine(typeof(NPDMJDKCIFA))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> GPNADMBNNKL(JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND, HJEILFHEDJO HGPIKDLKBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB5B0", Offset = "0x1FAA1B0", VA = "0x181FAB5B0")]
	internal void FKIJPKDADIH(JCIKKDEFAFO<NKOLEFJCHJO> IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class NBPFHIIMCCH : LOOKFBIEHEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public interface NBPOAICILHA
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		NNDFBECEIIM IKMICDFBCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CELPEAGFFDN> KMPMKJKABML(CancellationToken PPKBAEMFIMG);

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<ONEEHEFMPOC> FIFIOKMJKDF(CancellationToken PPKBAEMFIMG);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<HMLFEFILMLH> IHFGGLAHJPM(CancellationToken PPKBAEMFIMG);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JJPAFFIKBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<NBPFHIIMCCH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public BBMNOHIFAAA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public CELPEAGFFDN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ONEEHEFMPOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private NBPOAICILHA <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private ONEEHEFMPOC <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<CELPEAGFFDN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<ONEEHEFMPOC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HMLFEFILMLH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<CPNDPMFCDEK> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1FAFBD0", Offset = "0x1FAE7D0", VA = "0x181FAFBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FB05D0", Offset = "0x1FAF1D0", VA = "0x181FB05D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly CPNDPMFCDEK MEPJFACIGOJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CPNDPMFCDEK FKLBCNENDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	private NBPFHIIMCCH(CPNDPMFCDEK AHPMCNFGJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1FB38D0", Offset = "0x1FB24D0", VA = "0x181FB38D0")]
	[AsyncStateMachine(typeof(JJPAFFIKBGN))]
	public static Task<NBPFHIIMCCH> NNDBAILNMDF(BBMNOHIFAAA NKENJJKCCKI, CELPEAGFFDN? ABJNEIDNHBL, ONEEHEFMPOC? BJKFDJBGPCA, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1FB38B0", Offset = "0x1FB24B0", VA = "0x181FB38B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public readonly struct DJFCGLBBEOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct GOLCIFFFFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DJFCGLBBEOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public JPJAJOPEHEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1FA61D0", Offset = "0x1FA4DD0", VA = "0x181FA61D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6460", Offset = "0x1FA5060", VA = "0x181FA6460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct HENIJJBMHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<bool, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public PLOKGBGAKJA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CELPEAGFFDN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public ONEEHEFMPOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public DJFCGLBBEOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private JPJAJOPEHEI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8620", Offset = "0x1FA7220", VA = "0x181FA8620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8A00", Offset = "0x1FA7600", VA = "0x181FA8A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BECKCHEFDCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public DJFCGLBBEOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0970", Offset = "0x1F9F570", VA = "0x181FA0970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0BB0", Offset = "0x1F9F7B0", VA = "0x181FA0BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly MKHLLMHPDDG AAOJMGOONLF;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	public DJFCGLBBEOJ(MKHLLMHPDDG BHLJJBKLEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4050", Offset = "0x1FA2C50", VA = "0x181FA4050")]
	[AsyncStateMachine(typeof(GOLCIFFFFNI))]
	private Task<NLDGPBPIIJN<object, MFMODGJHEIL>> LCJMACMDFJF(JPJAJOPEHEI OBNFAOABLKL, bool AJEJMPLGBCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3E00", Offset = "0x1FA2A00", VA = "0x181FA3E00")]
	[AsyncStateMachine(typeof(HENIJJBMHMO))]
	public Task<NLDGPBPIIJN<bool, MFMODGJHEIL?>>? GCPALCEGMLE(int CEBBHDALLII, PLOKGBGAKJA? FBCBNNIIADI, CELPEAGFFDN? LFOIHPGJJCO, ONEEHEFMPOC? BJKFDJBGPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3F60", Offset = "0x1FA2B60", VA = "0x181FA3F60")]
	[AsyncStateMachine(typeof(BECKCHEFDCI))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> KHBCMNOGPLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class MHMKGEKICMF : CLKADIAHIMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly PGJJLLNCMHO JJOHCGPIFLM;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PGJJLLNCMHO PCDJHGBIJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	private MHMKGEKICMF(PGJJLLNCMHO GFFIKHKBHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2FE0", Offset = "0x1FB1BE0", VA = "0x181FB2FE0")]
	public static MHMKGEKICMF GCPIDJEBGBI(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2FC0", Offset = "0x1FB1BC0", VA = "0x181FB2FC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface OMBFHACLEEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	CPNDPMFCDEK FKLBCNENDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	NOELHOAKFFF MKDIBELADPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	OEABOLLMLCM MCPIJMNNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	NNCCPMCMBNH PIHKKAFDPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface GHBFLECAIHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	OMBFHACLEEI? PEAFDEGCNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool FIIEBMHFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool KBHBFBGMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OMBFHACLEEI?>? EKAJIOLJOND();

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MIMBAKGFCMJ(BBMNOHIFAAA NKENJJKCCKI, PLOKGBGAKJA MKJCMCDGACE, CELPEAGFFDN? LKBIGLLPHEJ, ONEEHEFMPOC? AFGHFDOJNLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[GKMJNCLPKFM("IStaticCV2Instance")]
public interface LOOKFBIEHEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	CPNDPMFCDEK FKLBCNENDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[GKMJNCLPKFM("IStaticEVInstance")]
public interface CLKADIAHIMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	PGJJLLNCMHO PCDJHGBIJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class OPCJPJIBNKD
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA1D0", Offset = "0x1FB8DD0", VA = "0x181FBA1D0")]
	public static FECEGHFEDAM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> HAMNNBMIGOM([In] this FECEGHFEDAM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>> GNNOPILKOGH)
	{
		return default(FECEGHFEDAM<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA, EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class KLDEIBNEGKJ : OBPEIOJKMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KBHBFBGMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1990", Offset = "0x1FB0590", VA = "0x181FB1990", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	internal KLDEIBNEGKJ(BBMNOHIFAAA NKENJJKCCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class DAHHMFADOBK : BOPPOJPFLIO
{
	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3D00", Offset = "0x1FA2900", VA = "0x181FA3D00", Slot = "4")]
	public DGNLNIFLLEO? MHHLOJFHJDL(string? MJAJMIHCBDD, string? PIJKBFIPCNL, string? CFFCMNPIAMH, LBKNIOIIFPK.KIIAJIPLAJI.OMPPNAAHEPG CIDIJDOJFHG, bool HEANDNAHAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public DAHHMFADOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class CCNMDHJKEDF : IHIPPHIDNHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct CGPICKLAKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AsyncTaskMethodBuilder<NGAKEPLJGMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CCNMDHJKEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<OMBFHACLEEI?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2430", Offset = "0x1FA1030", VA = "0x181FA2430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA26C0", Offset = "0x1FA12C0", VA = "0x181FA26C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private IReadOnlyList<ABKJIOOEHEB<INPGPFPHLDA>>? ALLKDDHDFMK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NGAKEPLJGMP? NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2280", Offset = "0x1FA0E80", VA = "0x181FA2280", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NNCCPMCMBNH? CLEOKMDAHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA20B0", Offset = "0x1FA0CB0", VA = "0x181FA20B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JMDNCOMNOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2220", Offset = "0x1FA0E20", VA = "0x181FA2220", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IIHCIJMJKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1C50", Offset = "0x1FA0850", VA = "0x181FA1C50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	internal CCNMDHJKEDF(BBMNOHIFAAA NKENJJKCCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2130", Offset = "0x1FA0D30", VA = "0x181FA2130", Slot = "7")]
	[AsyncStateMachine(typeof(CGPICKLAKBC))]
	public Task<NGAKEPLJGMP> MACAJDKMCHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA18E0", Offset = "0x1FA04E0", VA = "0x181FA18E0", Slot = "9")]
	public IReadOnlyDictionary<ABKJIOOEHEB<LDNFOKBFEMK>, Guid> ALOPIGEINLH(IEnumerable<KPIIJEHPKNN> AEMMFLBGAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1CB0", Offset = "0x1FA08B0", VA = "0x181FA1CB0")]
	public NLDGPBPIIJN<PPJAPPEIMML, MLPOHKBMKMA> JGHKAIGGFKB([In] PPJAPPEIMML AKLCJHAPACE, IEnumerable<KPIIJEHPKNN> DOGMEMACJGE, int CMHBAMBILMJ)
	{
		return default(NLDGPBPIIJN<PPJAPPEIMML, MLPOHKBMKMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1EB0", Offset = "0x1FA0AB0", VA = "0x181FA1EB0", Slot = "8")]
	private NLDGPBPIIJN<PPJAPPEIMML, MLPOHKBMKMA> KNBADIIEOKN([In] PPJAPPEIMML AKLCJHAPACE, IEnumerable<KPIIJEHPKNN> DOGMEMACJGE, int CMHBAMBILMJ)
	{
		return default(NLDGPBPIIJN<PPJAPPEIMML, MLPOHKBMKMA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class NNCCPMCMBNH : NGAKEPLJGMP
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	internal static class HEFEMFNMDOP
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class PAACHOCPJNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public CPNDPMFCDEK state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public MGOMGIBIJBN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PAACHOCPJNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA6E0", Offset = "0x1FB92E0", VA = "0x181FBA6E0")]
			internal bool GEMCEJEBIEI(DDGJDHMFBKG n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class FBBJILCLKPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public FBBJILCLKPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5130", Offset = "0x1FA3D30", VA = "0x181FA5130")]
			internal void ABHPMOIPINC(DDGJDHMFBKG n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7170", Offset = "0x1FA5D70", VA = "0x181FA7170")]
		public static NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA> MGFNPLKOLEC(NNCCPMCMBNH ENEDBNLKLJL, [In] NGAKEPLJGMP.IHOHNAGGBPF OHIOFOHNMPI)
		{
			return default(NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7700", Offset = "0x1FA6300", VA = "0x181FA7700")]
		internal static NLDGPBPIIJN<(DOKGKNMBEJK, JOMEOBKFLEB), DLHJBPGLGBA> PKPLPGEMIAH(NNCCPMCMBNH ENEDBNLKLJL, JOMEOBKFLEB GJEBKPNNFGJ, bool OAEIBMHPHON, [In] ABKJIOOEHEB<LDNFOKBFEMK> CLEDMCIKJHF, [In] int? HKFFCOMELAG, [In] MDCJCJDDPLM? AGBIFOPMLMG, [In] MDCJCJDDPLM? OADANIHLOKN)
		{
			return default(NLDGPBPIIJN<(DOKGKNMBEJK, JOMEOBKFLEB), DLHJBPGLGBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6820", Offset = "0x1FA5420", VA = "0x181FA6820")]
		private static void AKKIGHMEHCP(bool OAEIBMHPHON, KPIIJEHPKNN GLDBNLEBGAB, DOKGKNMBEJK FPNBIAJMBOG, [In] ABKJIOOEHEB<LDNFOKBFEMK> CLEDMCIKJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6D70", Offset = "0x1FA5970", VA = "0x181FA6D70")]
		public static void MDMCOBKAAGL(MABCOEEFHJO DIJKMLJFMGP, [In] NGAKEPLJGMP.BHIHOFFIHPH ECFCCFINMNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6C80", Offset = "0x1FA5880", VA = "0x181FA6C80")]
		[CompilerGenerated]
		internal static bool FGIKFECLILJ(CPNDPMFCDEK CBBOKPJOPJM, MGOMGIBIJBN EJKIPEKNJOJ, DDGJDHMFBKG JEKFMECGEFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6C50", Offset = "0x1FA5850", VA = "0x181FA6C50")]
		[CompilerGenerated]
		internal static bool DKDPLDFKGII(DDGJDHMFBKG OIBBHECAKMI)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct OCGCOECJLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public NNCCPMCMBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public JCIKKDEFAFO<LDNFOKBFEMK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public JCIKKDEFAFO<EBPAJHFGHPO> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public JCIKKDEFAFO<BNGCKMJMGMP> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9650", Offset = "0x1FB8250", VA = "0x181FB9650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9CA0", Offset = "0x1FB88A0", VA = "0x181FB9CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct GLBCJHJKHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public NNCCPMCMBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public ABKJIOOEHEB<BKMEFFNPIFK> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public ABKJIOOEHEB<LDNFOKBFEMK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public JCIKKDEFAFO<NKOLEFJCHJO> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public JCIKKDEFAFO<MHMFPDDJAPK> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5E20", Offset = "0x1FA4A20", VA = "0x181FA5E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6160", Offset = "0x1FA4D60", VA = "0x181FA6160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct FIIGLELNJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public NNCCPMCMBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public ABKJIOOEHEB<BKMEFFNPIFK> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public ABKJIOOEHEB<LDNFOKBFEMK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public JCIKKDEFAFO<NKOLEFJCHJO> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public JCIKKDEFAFO<MGOHEMMBNJL> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA51B0", Offset = "0x1FA3DB0", VA = "0x181FA51B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA54F0", Offset = "0x1FA40F0", VA = "0x181FA54F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly BBMNOHIFAAA HHKBPMIKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly LOOKFBIEHEI FDAPNBOLLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly CLKADIAHIMG EADMADPOOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly EIKIHDMKHAG LOHECFAPNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly CCNMDHJKEDF BPGKOBJPMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Dictionary<ABKJIOOEHEB<BKMEFFNPIFK>, OAAKPGFEBMO> LPBPOANFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[CompilerGenerated]
	private Action<ABKJIOOEHEB<BKMEFFNPIFK>>? NLFCOEBBDFJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public ABKJIOOEHEB<LDNFOKBFEMK> GGGMPAHJFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8010", Offset = "0x1FB6C10", VA = "0x181FB8010", Slot = "4")]
		get
		{
			return default(ABKJIOOEHEB<LDNFOKBFEMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public EIKIHDMKHAG NHFMNMGICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F86840", Offset = "0x1F85440", VA = "0x181F86840", Slot = "5")]
		get
		{
			return default(EIKIHDMKHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8290", Offset = "0x1FB6E90", VA = "0x181FB8290")]
	public NNCCPMCMBNH(BBMNOHIFAAA NKENJJKCCKI, LOOKFBIEHEI OGGDGFPBCJP, CLKADIAHIMG PIPINPKKNNK, CCNMDHJKEDF FJIPBCMNFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4710", Offset = "0x1FB3310", VA = "0x181FB4710", Slot = "41")]
	public JCIKKDEFAFO<IPONAKJKJIB> BNHGELDOFBL(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI)
	{
		return default(JCIKKDEFAFO<IPONAKJKJIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5A80", Offset = "0x1FB4680", VA = "0x181FB5A80", Slot = "42")]
	public JCIKKDEFAFO<EGPFGEJDONN> GEOKIDENOCG(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE)
	{
		return default(JCIKKDEFAFO<EGPFGEJDONN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5BB0", Offset = "0x1FB47B0", VA = "0x181FB5BB0", Slot = "6")]
	public bool HMALDKNJGFK(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> CGIPJAIDKIP, JCIKKDEFAFO<BNGCKMJMGMP> MLCOPNNKKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB66B0", Offset = "0x1FB52B0", VA = "0x181FB66B0")]
	public bool JLKFJOBNBOJ(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] HLEEMKNGNHI NPMJLDKEFEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4E80", Offset = "0x1FB3A80", VA = "0x181FB4E80", Slot = "8")]
	public bool DHAJKNGKEJC(GGCDLLOJFMN IDCMAKDPBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5380", Offset = "0x1FB3F80", VA = "0x181FB5380", Slot = "9")]
	public bool EIFHMGAJCEA(NBINKKELLDG OJPOALOJGKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7870", Offset = "0x1FB6470", VA = "0x181FB7870")]
	public OAAKPGFEBMO? MHCLNEGOPFL([In] ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4230", Offset = "0x1FB2E30", VA = "0x181FB4230")]
	public JCIKKDEFAFO<BKMEFFNPIFK> DMELCFCFOBP(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] ABKJIOOEHEB<BKMEFFNPIFK> NCKPBNBNBKC)
	{
		return default(JCIKKDEFAFO<BKMEFFNPIFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7970", Offset = "0x1FB6570", VA = "0x181FB7970", Slot = "20")]
	public JCIKKDEFAFO<BKMEFFNPIFK> MHJGNMBDNPF(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI)
	{
		return default(JCIKKDEFAFO<BKMEFFNPIFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB64C0", Offset = "0x1FB50C0", VA = "0x181FB64C0", Slot = "21")]
	public JCIKKDEFAFO<BKMEFFNPIFK> JHBJIFNLLBA(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE)
	{
		return default(JCIKKDEFAFO<BKMEFFNPIFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5650", Offset = "0x1FB4250", VA = "0x181FB5650")]
	private void FGMFCOACAIF(ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6A00", Offset = "0x1FB5600", VA = "0x181FB6A00")]
	public IEnumerable<OAAKPGFEBMO> KDBFIHHFNKO([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB56E0", Offset = "0x1FB42E0", VA = "0x181FB56E0", Slot = "19")]
	public JCIKKDEFAFO<BNGCKMJMGMP> FJAMBOJILLB(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<IPONAKJKJIB> DLKDICJKMOE)
	{
		return default(JCIKKDEFAFO<BNGCKMJMGMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5400", Offset = "0x1FB4000", VA = "0x181FB5400", Slot = "22")]
	public JCIKKDEFAFO<EBPAJHFGHPO> EKJNNFLEHHI(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<EGPFGEJDONN> AFFJKIAILLF)
	{
		return default(JCIKKDEFAFO<EBPAJHFGHPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB41F0", Offset = "0x1FB2DF0", VA = "0x181FB41F0")]
	private OAAKPGFEBMO? ADHHLBFGKME([In] ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6AE0", Offset = "0x1FB56E0", VA = "0x181FB6AE0")]
	private OAAKPGFEBMO LBPHBPHLNHI([In] ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN, ECHKNCNLALD AIJMDPAKHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB63A0", Offset = "0x1FB4FA0", VA = "0x181FB63A0")]
	public ECHKNCNLALD? IOHCEBHJMMC([In] ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4850", Offset = "0x1FB3450", VA = "0x181FB4850")]
	public MOAIGMJPFLL? LEJGMPLMAIM([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4790", Offset = "0x1FB3390", VA = "0x181FB4790", Slot = "15")]
	public IEnumerable<BNLCCKPEJML> CGIAMHGCPCB(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB57F0", Offset = "0x1FB43F0", VA = "0x181FB57F0", Slot = "16")]
	public IEnumerable<HLEEMKNGNHI> FLKMKFHALLJ(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> CGIPJAIDKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB79F0", Offset = "0x1FB65F0", VA = "0x181FB79F0", Slot = "17")]
	public IEnumerable<HLEEMKNGNHI> MJKGMLKIPFI(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> MLCOPNNKKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5770", Offset = "0x1FB4370", VA = "0x181FB5770")]
	public JCIKKDEFAFO<LDNFOKBFEMK> PEGKNNIJHHA([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return default(JCIKKDEFAFO<LDNFOKBFEMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B00", Offset = "0x1FB4700", VA = "0x181FB5B00")]
	public JCIKKDEFAFO<LDNFOKBFEMK>? NLDGFKOPPOE([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7EE0", Offset = "0x1FB6AE0", VA = "0x181FB7EE0")]
	private MGOMGIBIJBN? NEDJCDNFILA([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4850", Offset = "0x1FB3450", VA = "0x181FB4850")]
	private MOAIGMJPFLL? JLAOABKAMNJ([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7FA0", Offset = "0x1FB6BA0", VA = "0x181FB7FA0", Slot = "26")]
	public ABKJIOOEHEB<LDNFOKBFEMK> NNMJKANHOEC(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return default(ABKJIOOEHEB<LDNFOKBFEMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6020", Offset = "0x1FB4C20", VA = "0x181FB6020", Slot = "23")]
	public IEnumerable<HJEILFHEDJO> HOADJEJHGLC(GOOBAOBEGDJ MDKOBMPLJIC, bool CLFHJBDACPG, bool AOPOBGKBGPM, bool CPMGPFFIAPH, bool FIMNBKFMNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB43A0", Offset = "0x1FB2FA0", VA = "0x181FB43A0", Slot = "24")]
	public HJEILFHEDJO BCMEMCJHOHI(GOOBAOBEGDJ MDKOBMPLJIC, BLDDIIOIMMM AEODHLLKDGP, bool CLFHJBDACPG, bool AOPOBGKBGPM, bool CPMGPFFIAPH, bool FIMNBKFMNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6540", Offset = "0x1FB5140", VA = "0x181FB6540")]
	public BNLCCKPEJML JLBEBFDBDHE(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] HLEEMKNGNHI NPMJLDKEFEO)
	{
		return default(BNLCCKPEJML);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5060", Offset = "0x1FB3C60", VA = "0x181FB5060", Slot = "27")]
	public HLEEMKNGNHI DPPMNOPFFMC(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> CGIPJAIDKIP, JCIKKDEFAFO<BNGCKMJMGMP> MLCOPNNKKLA)
	{
		return default(HLEEMKNGNHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5310", Offset = "0x1FB3F10", VA = "0x181FB5310", Slot = "28")]
	public bool EHFBILNPLHC(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5290", Offset = "0x1FB3E90", VA = "0x181FB5290", Slot = "29")]
	public bool EDONLPLAEKC(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB54F0", Offset = "0x1FB40F0", VA = "0x181FB54F0", Slot = "30")]
	public bool FBMPMFBALCO(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B80", Offset = "0x1FB4780", VA = "0x181FB5B80")]
	public NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA> GPMMDKNABAJ([In] NGAKEPLJGMP.IHOHNAGGBPF OHIOFOHNMPI)
	{
		return default(NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8070", Offset = "0x1FB6C70", VA = "0x181FB8070", Slot = "32")]
	[AsyncStateMachine(typeof(OCGCOECJLGO))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> OPNPHIICPBA(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> CGIPJAIDKIP, JCIKKDEFAFO<BNGCKMJMGMP> MLCOPNNKKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6BB0", Offset = "0x1FB57B0", VA = "0x181FB6BB0", Slot = "33")]
	public NLDGPBPIIJN<ACGKMHNMALL, MLPOHKBMKMA> LCMDHODFAJG(ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE, ACGKMHNMALL LJCAEHCCHAE, CAELIJMJDML GPFPBEHKOGK)
	{
		return default(NLDGPBPIIJN<ACGKMHNMALL, MLPOHKBMKMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4880", Offset = "0x1FB3480", VA = "0x181FB4880", Slot = "34")]
	[AsyncStateMachine(typeof(GLBCJHJKHJG))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> CKIDCAPCBOH(ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE, ABKJIOOEHEB<BKMEFFNPIFK> CJGAPAEJGLG, JCIKKDEFAFO<NKOLEFJCHJO> PMHHBIKEHKC, JCIKKDEFAFO<MHMFPDDJAPK> OMLIBFPFCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6240", Offset = "0x1FB4E40", VA = "0x181FB6240", Slot = "35")]
	[AsyncStateMachine(typeof(FIIGLELNJFA))]
	public Task<NLDGPBPIIJN<HGAAMJINHPI, MFMODGJHEIL>> IHJNAILMCPO(ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE, ABKJIOOEHEB<BKMEFFNPIFK> NHNFMHGAMFF, JCIKKDEFAFO<NKOLEFJCHJO> HNFEBIFPAJE, JCIKKDEFAFO<MGOHEMMBNJL> NHPBHEJEOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7CF0", Offset = "0x1FB68F0", VA = "0x181FB7CF0", Slot = "36")]
	public NCMINLFIBAA MPIEJAPPBGB(IEnumerable<KPIIJEHPKNN> DOGMEMACJGE)
	{
		return default(NCMINLFIBAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6120", Offset = "0x1FB4D20", VA = "0x181FB6120", Slot = "37")]
	public NCMINLFIBAA IDPMHEOAJCE()
	{
		return default(NCMINLFIBAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6FA0", Offset = "0x1FB5BA0", VA = "0x181FB6FA0")]
	private MMPIPECKDJH LGLNGAHMNMN(MJOFGOEMABG FBFIEDPIHJN, JCIKKDEFAFO<LDNFOKBFEMK> CJMGHKPDCFB, IEnumerable<ABKJIOOEHEB<LDNFOKBFEMK>> JBDLNBHLHGA, IEnumerable<ABKJIOOEHEB<BKMEFFNPIFK>> PEGGHMLCDBD)
	{
		return default(MMPIPECKDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7150", Offset = "0x1FB5D50", VA = "0x181FB7150", Slot = "38")]
	public MMPIPECKDJH LGLNGAHMNMN(MJOFGOEMABG FBFIEDPIHJN, JCIKKDEFAFO<LDNFOKBFEMK> CJMGHKPDCFB, IEnumerable<ABKJIOOEHEB<BKMEFFNPIFK>> PEGGHMLCDBD, IEnumerable<KPIIJEHPKNN> DOGMEMACJGE)
	{
		return default(MMPIPECKDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7490", Offset = "0x1FB6090", VA = "0x181FB7490")]
	private static IEnumerable<ABKJIOOEHEB<LDNFOKBFEMK>> LIKAKDOJDDC(IEnumerable<KPIIJEHPKNN> DOGMEMACJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB49E0", Offset = "0x1FB35E0", VA = "0x181FB49E0")]
	private IEnumerable<ABKJIOOEHEB<BKMEFFNPIFK>> DBALCFFIAFK(IEnumerable<KPIIJEHPKNN> DOGMEMACJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6430", Offset = "0x1FB5030", VA = "0x181FB6430", Slot = "39")]
	public List<LEDLMFMINBI> JBMLPMDEIHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4F00", Offset = "0x1FB3B00", VA = "0x181FB4F00", Slot = "40")]
	public bool DHDLNPKOBBJ(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5490", Offset = "0x1FB4090", VA = "0x181FB5490")]
	internal void ENODOIHAFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7810", Offset = "0x1FB6410", VA = "0x181FB7810")]
	internal Task LKNIPBFEPCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4700", Offset = "0x1FB3300", VA = "0x181FB4700", Slot = "7")]
	private bool BMJNNJKOHDO(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] HLEEMKNGNHI NPMJLDKEFEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4850", Offset = "0x1FB3450", VA = "0x181FB4850", Slot = "10")]
	private MOAIGMJPFLL CKAIPFNELLM([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5770", Offset = "0x1FB4370", VA = "0x181FB5770", Slot = "11")]
	private JCIKKDEFAFO<LDNFOKBFEMK> FJMENCDLKCO([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return default(JCIKKDEFAFO<LDNFOKBFEMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B00", Offset = "0x1FB4700", VA = "0x181FB5B00", Slot = "12")]
	private JCIKKDEFAFO<LDNFOKBFEMK>? GIEPFPHIKPG([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB42B0", Offset = "0x1FB2EB0", VA = "0x181FB42B0", Slot = "13")]
	private OAAKPGFEBMO APEIDEMMPHO([In] ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4230", Offset = "0x1FB2E30", VA = "0x181FB4230", Slot = "14")]
	private JCIKKDEFAFO<BKMEFFNPIFK> AKAHBCAFPHI(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] ABKJIOOEHEB<BKMEFFNPIFK> NCKPBNBNBKC)
	{
		return default(JCIKKDEFAFO<BKMEFFNPIFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5570", Offset = "0x1FB4170", VA = "0x181FB5570", Slot = "18")]
	private IEnumerable<OAAKPGFEBMO> FFMDIGKHCOF([In] ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6540", Offset = "0x1FB5140", VA = "0x181FB6540", Slot = "25")]
	private BNLCCKPEJML MDHBKPDKNIC(JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, [In] HLEEMKNGNHI NPMJLDKEFEO)
	{
		return default(BNLCCKPEJML);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B80", Offset = "0x1FB4780", VA = "0x181FB5B80", Slot = "31")]
	private NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA> JCHEAAGDOMB([In] NGAKEPLJGMP.IHOHNAGGBPF OHIOFOHNMPI)
	{
		return default(NLDGPBPIIJN<NGAKEPLJGMP.PKKBNKNAMIO, DLHJBPGLGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB81A0", Offset = "0x1FB6DA0", VA = "0x181FB81A0")]
	[CompilerGenerated]
	private OAAKPGFEBMO PGAFLKJLOKO(ECHKNCNLALD BFOGKPIBBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7C70", Offset = "0x1FB6870", VA = "0x181FB7C70")]
	[CompilerGenerated]
	private LPKGDNMJBGH MKMIGAFCKEH(AHBLCPHJJBG BFOGKPIBBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4FF0", Offset = "0x1FB3BF0", VA = "0x181FB4FF0")]
	[CompilerGenerated]
	private ECHKNCNLALD DIFOEBLPDKK(ABKJIOOEHEB<BKMEFFNPIFK> BFOGKPIBBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4690", Offset = "0x1FB3290", VA = "0x181FB4690")]
	[CompilerGenerated]
	private MGOMGIBIJBN BDFEDCLJPMO(ABKJIOOEHEB<LDNFOKBFEMK> BFOGKPIBBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class LPKGDNMJBGH : HJEILFHEDJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct HADEHBGBHAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<JCIKKDEFAFO<JFMHBEEECHM>, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public LPKGDNMJBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public ABKJIOOEHEB<LDNFOKBFEMK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public ABKJIOOEHEB<BKMEFFNPIFK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<JFMHBEEECHM>, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCA70", Offset = "0x1FBB670", VA = "0x181FBCA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCCF0", Offset = "0x1FBB8F0", VA = "0x181FBCCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct ODNDEEBCMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<JCIKKDEFAFO<NPNOGIJPNKK>, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public LPKGDNMJBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public ABKJIOOEHEB<LDNFOKBFEMK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public ABKJIOOEHEB<BKMEFFNPIFK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public JCIKKDEFAFO<NKOLEFJCHJO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<NLDGPBPIIJN<JCIKKDEFAFO<NPNOGIJPNKK>, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDB00", Offset = "0x1FBC700", VA = "0x181FBDB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDD80", Offset = "0x1FBC980", VA = "0x181FBDD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly AHBLCPHJJBG DEGJAIDANDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly LOOKFBIEHEI FDAPNBOLLEC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey NBDLOHIPKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string NOBKDIJIFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2850", Offset = "0x1FB1450", VA = "0x181FB2850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public AHBLCPHJJBG JJMCCGDLFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2B60", Offset = "0x1FB1760", VA = "0x181FB2B60")]
	public LPKGDNMJBGH(AHBLCPHJJBG NDCLADCGPOO, LOOKFBIEHEI OGGDGFPBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2880", Offset = "0x1FB1480", VA = "0x181FB2880", Slot = "6")]
	[AsyncStateMachine(typeof(HADEHBGBHAL))]
	public Task<NLDGPBPIIJN<JCIKKDEFAFO<JFMHBEEECHM>, MFMODGJHEIL>> KHCNHMDMDKL(ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE, ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, string LONKACOOPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x1FB29F0", Offset = "0x1FB15F0", VA = "0x181FB29F0", Slot = "7")]
	[AsyncStateMachine(typeof(ODNDEEBCMIN))]
	public Task<NLDGPBPIIJN<JCIKKDEFAFO<NPNOGIJPNKK>, MFMODGJHEIL>> KIHHEBNFACM(ABKJIOOEHEB<LDNFOKBFEMK> CJJOKEDEAPE, ABKJIOOEHEB<BKMEFFNPIFK> DDPGCLLGMBN, JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN, string LONKACOOPGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class OMAFGIIFLNO : HOPIPCKENDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private readonly AHBLCPHJJBG AEDCKMEIINL;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private static readonly HashSet<AHBLCPHJJBG> JOAIADGCEOK;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly HashSet<AHBLCPHJJBG> ILFNCAMOKEP;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static readonly HashSet<AHBLCPHJJBG> DIDBBOMOGMD;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey KNLKLIOEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF300", Offset = "0x1FBDF00", VA = "0x181FBF300", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CAMKGNGIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF2F0", Offset = "0x1FBDEF0", VA = "0x181FBF2F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MIHOFAIABKE
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF4C0", Offset = "0x1FBE0C0", VA = "0x181FBF4C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool MKGKEGIOJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF270", Offset = "0x1FBDE70", VA = "0x181FBF270", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDDF0", Offset = "0x1FBC9F0", VA = "0x181FBDDF0")]
	public bool IPONBGDADAI(string IIPLJLPCLBC, [Out] ABEDLMOOLJJ LGGMDEDPJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public OMAFGIIFLNO(AHBLCPHJJBG JPJGGLNFIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBCBF0", VA = "0x181FBDFF0")]
	internal static TypeKey OMFLIOLDNIA(AHBLCPHJJBG HGPIKDLKBHO)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2850", Offset = "0x1FB1450", VA = "0x181FB2850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct LNFDCJJIAJH : FNJFCDFFKGL.AJIHNGEMDHF<JPJAJOPEHEI, HGAAMJINHPI>
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD4B0", Offset = "0x1FBC0B0", VA = "0x181FBD4B0", Slot = "4")]
	public int PIEIDLPDHBL(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3F0", Offset = "0x1FBBFF0", VA = "0x181FBD3F0", Slot = "5")]
	public JPJAJOPEHEI EMMFGIGIHPF(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD480", Offset = "0x1FBC080", VA = "0x181FBD480", Slot = "6")]
	public JPJAJOPEHEI NKJNCDBAEPG(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3B0", Offset = "0x1FBBFB0", VA = "0x181FBD3B0", Slot = "7")]
	public IReadOnlyList<JPJAJOPEHEI> CBJGGEJDADK(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3A0", Offset = "0x1FBBFA0", VA = "0x181FBD3A0", Slot = "8")]
	public JPJAJOPEHEI[] BCCLKNMEHAL(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL, int BBKJFLOMIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD400", Offset = "0x1FBC000", VA = "0x181FBD400", Slot = "9")]
	public bool EPJFJFLHLBA(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3D0", Offset = "0x1FBBFD0", VA = "0x181FBD3D0", Slot = "10")]
	public bool CNCMEBKKMIA(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD4D0", Offset = "0x1FBC0D0", VA = "0x181FBD4D0", Slot = "11")]
	public bool PIGBKKPHFMH(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD440", Offset = "0x1FBC040", VA = "0x181FBD440", Slot = "12")]
	public bool IDBCECOKEGH(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD420", Offset = "0x1FBC020", VA = "0x181FBD420", Slot = "13")]
	public bool FAEFENLHEFG(HGAAMJINHPI ECIHEOBBGIJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD460", Offset = "0x1FBC060", VA = "0x181FBD460", Slot = "14")]
	public bool NFDGNNHECJF(HGAAMJINHPI LDAADCAOFLJ, JPJAJOPEHEI OBNFAOABLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public abstract class DMAEPDLNDNL : GNOCGBHLCBG
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public PBEKNCLALAN.FMEDPOPOLCP HBLDMKJMLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC7C0", Offset = "0x1FBB3C0", VA = "0x181FBC7C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract KBLFFLEDDJB.OJPPPELGEIB NHKJKEIJPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract BBMNOHIFAAA.CBBEMDJIHLG BEEMDEDJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract NBPFHIIMCCH.NBPOAICILHA GFLFOJJICFB
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EGFFNDEANCI.NEILCCAIIPG<IFBAEMJBHPI, JPJAJOPEHEI, BBMNOHIFAAA> NAPBDDCMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC770", Offset = "0x1FBB370", VA = "0x181FBC770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract MLJNEACEOMD GDABNFCLCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract CEEEBKLIDGF KKAFDBHFFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract OLBPHONICFD ABGCGOJKBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract IDNFGABDLMC GKNAKMAEIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract GKKOPJCDHIN JPBHIMKDGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected DMAEPDLNDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class EFOLAACHEOM : CPCOOONCEJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct AGMNHNPHPPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public EFOLAACHEOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public JPJAJOPEHEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC400", Offset = "0x1FBB000", VA = "0x181FBC400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC6A0", Offset = "0x1FBB2A0", VA = "0x181FBC6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct IINKEEEMGIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public EFOLAACHEOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IReadOnlyList<JPJAJOPEHEI> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCD60", Offset = "0x1FBB960", VA = "0x181FBCD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBD0E0", Offset = "0x1FBBCE0", VA = "0x181FBD0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly MKHLLMHPDDG AAOJMGOONLF;

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public EFOLAACHEOM(MKHLLMHPDDG BHLJJBKLEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC940", Offset = "0x1FBB540", VA = "0x181FBC940")]
	[AsyncStateMachine(typeof(AGMNHNPHPPI))]
	private Task<NLDGPBPIIJN<object, MFMODGJHEIL>> LCJMACMDFJF(JPJAJOPEHEI OBNFAOABLKL, bool AJEJMPLGBCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC810", Offset = "0x1FBB410", VA = "0x181FBC810", Slot = "4")]
	[AsyncStateMachine(typeof(IINKEEEMGIO))]
	public Task<NLDGPBPIIJN<BHMKEMJFCPL, MFMODGJHEIL>> KHLLKMKKOGG(IReadOnlyList<JPJAJOPEHEI> KFCIDPMFGKC, bool AJEJMPLGBCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct CFFCHINJDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	internal DBHFDDFANKO<JCBFHOPKKBH, JPJAJOPEHEI, MLGKJOLKNNJ> AEDCKMEIINL;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x1F87B90", Offset = "0x1F86790", VA = "0x181F87B90")]
	private CFFCHINJDEM([In] DBHFDDFANKO<JCBFHOPKKBH, JPJAJOPEHEI, MLGKJOLKNNJ> ENPFIGEFPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC710", Offset = "0x1FBB310", VA = "0x181FBC710")]
	public static CFFCHINJDEM FCDPFGJNKNI()
	{
		return default(CFFCHINJDEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class OJJMIGMJOAB
{
	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static DBHFDDFANKO<JCBFHOPKKBH, JPJAJOPEHEI, MLGKJOLKNNJ> JHNKHGMFHKC(this CFFCHINJDEM ENEDBNLKLJL)
	{
		return default(DBHFDDFANKO<JCBFHOPKKBH, JPJAJOPEHEI, MLGKJOLKNNJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct MLGKJOLKNNJ : IKLHJGLPADG.AFFAKDHDBGN<JCBFHOPKKBH, JPJAJOPEHEI>
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD4F0", Offset = "0x1FBC0F0", VA = "0x181FBD4F0", Slot = "5")]
	public JPJAJOPEHEI AKGHPOLCIPH(JCBFHOPKKBH[] ENINHHNNIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0")]
	public int PFDEKIBGEMK([In] JCBFHOPKKBH AJFJDBINGIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0", Slot = "4")]
	private int HOIPLLIACIN([In] JCBFHOPKKBH BKPAMHNLFOB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct JPAGDPNOBJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	internal JBOGJACPOFH<MNJIPBFJHLO, JPJAJOPEHEI, JOLKAKNEHIF> AEDCKMEIINL;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x1F87B90", Offset = "0x1F86790", VA = "0x181F87B90")]
	private JPAGDPNOBJO([In] JBOGJACPOFH<MNJIPBFJHLO, JPJAJOPEHEI, JOLKAKNEHIF> JCGMGDOCPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD340", Offset = "0x1FBBF40", VA = "0x181FBD340")]
	public static JPAGDPNOBJO FCDPFGJNKNI()
	{
		return default(JPAGDPNOBJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class CDAFLKGONFA
{
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static JBOGJACPOFH<MNJIPBFJHLO, JPJAJOPEHEI, JOLKAKNEHIF> JHNKHGMFHKC(this JPAGDPNOBJO ENEDBNLKLJL)
	{
		return default(JBOGJACPOFH<MNJIPBFJHLO, JPJAJOPEHEI, JOLKAKNEHIF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct JOLKAKNEHIF : CDFNFECOIID.JHHBEHCDPFA<MNJIPBFJHLO, JPJAJOPEHEI>
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0")]
	public int GBKHOFENNID([In] MNJIPBFJHLO AJFJDBINGIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD150", Offset = "0x1FBBD50", VA = "0x181FBD150", Slot = "5")]
	public JPJAJOPEHEI IHDCEBKCOJB(MNJIPBFJHLO[] NAFMEDMCLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0", Slot = "4")]
	private int BHLPBAAKMCI([In] MNJIPBFJHLO AJFJDBINGIM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class NIOFDIMJJCM : LGLBGBDJHMM, DLHJBPGLGBA, MFMODGJHEIL, MLPOHKBMKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private readonly MLPOHKBMKMA? AGJHCGAFFMM;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KLMEKDGBKHB JJFCLNLGJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(KLMEKDGBKHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x867D00", Offset = "0x866900", VA = "0x180867D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override MLPOHKBMKMA? FCPIDFMFIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD8D0", Offset = "0x1FBC4D0", VA = "0x181FBD8D0", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDAC0", Offset = "0x1FBC6C0", VA = "0x181FBDAC0")]
	private NIOFDIMJJCM(KLMEKDGBKHB DEJLCIIFBAN, MLPOHKBMKMA? EACAHDCMGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDA40", Offset = "0x1FBC640", VA = "0x181FBDA40")]
	public static NIOFDIMJJCM PJIDCJLANIE(MLPOHKBMKMA EACAHDCMGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD7F0", Offset = "0x1FBC3F0", VA = "0x181FBD7F0")]
	public static NIOFDIMJJCM CJMFCELOFGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD860", Offset = "0x1FBC460", VA = "0x181FBD860")]
	public static NIOFDIMJJCM CLOMNIKFPPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class OHGNHOKPFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5620", Offset = "0x2CD4220", VA = "0x182CD5620")]
	public static NLDGPBPIIJN<TOk, DLHJBPGLGBA> GMNDHDJHLBA<TOk>([In] this NLDGPBPIIJN<TOk, DLHJBPGLGBA> ENEDBNLKLJL, MLPOHKBMKMA EACAHDCMGDK) where TOk : notnull
	{
		return default(NLDGPBPIIJN<TOk, DLHJBPGLGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5520", Offset = "0x2CD4120", VA = "0x182CD5520")]
	public static NLDGPBPIIJN<TOk?, DLHJBPGLGBA?> FMFMEEGCBMN<TOk>([In] this NLDGPBPIIJN<TOk, DLHJBPGLGBA> ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<TOk, DLHJBPGLGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5700", Offset = "0x2CD4300", VA = "0x182CD5700")]
	public static NLDGPBPIIJN<TOk?, DLHJBPGLGBA?> ILMJLAPBDME<TOk>([In] this NLDGPBPIIJN<TOk, DLHJBPGLGBA> ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<TOk, DLHJBPGLGBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface MLJNEACEOMD
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBBNPFOEHND([In] NLDGPBPIIJN<HGAAMJINHPI, MLPOHKBMKMA> KKIOBLFFGJH);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class HNBPNCFOCJP
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D680", Offset = "0x2B5C280", VA = "0x182B5D680")]
	public static bool OBBNPFOEHND<TOk, TErr>(this MLJNEACEOMD ENEDBNLKLJL, [In] NLDGPBPIIJN<TOk, TErr> KKIOBLFFGJH) where TOk : notnull where TErr : notnull, MLPOHKBMKMA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface CEEEBKLIDGF
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	BFJNCNJMOOI PEJHONHFIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public interface OLBPHONICFD
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOGKBBNKEMJ GCJFKJEHGKK(int OFLBOMALKDF);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface MOGHJABNGHE
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface JPJJPILOJHO
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMLFANKMFDK? CMCFFIEIHDC(JCIKKDEFAFO<NKOLEFJCHJO> JEJPIJEGJHN);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface KLCMBHNGJLP
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface PMLFANKMFDK
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLCMBHNGJLP? CPBIJCFOEDM(JCIKKDEFAFO<JFMHBEEECHM> NOAPLJNBFPN);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MOGHJABNGHE? IOGLCAKEEIM(JCIKKDEFAFO<NPNOGIJPNKK> DDCMOKDDNND);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface IDNFGABDLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DGNGBBOHBBO(string IIPLJLPCLBC, string NGDLPEOFMHL);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface GKKOPJCDHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPJJPILOJHO? MOKBJDGCEKH([In] ABKJIOOEHEB<INPGPFPHLDA> LMHACOJJIPN);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PJLNJHFGPEP
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private struct NDFDLJMPHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public int ICIBDGPPAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CELPEAGFFDN? FFKOLBAEONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CELPEAGFFDN? IILFABJKOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly List<JPJAJOPEHEI> EHCOKHDCJPC;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x1FBD7A0", Offset = "0x1FBC3A0", VA = "0x181FBD7A0")]
		private NDFDLJMPHEA(int BAEBMIBABAE, CELPEAGFFDN? HOFBKBHCMEH, CELPEAGFFDN? LLHJPFLMPKL, List<JPJAJOPEHEI> KFCIDPMFGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBD6E0", Offset = "0x1FBC2E0", VA = "0x181FBD6E0")]
		public static NDFDLJMPHEA FCDPFGJNKNI()
		{
			return default(NDFDLJMPHEA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly KBDJBBPMEON<NDFDLJMPHEA> DDAAPNLLCAC;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static PJLNJHFGPEP NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFD00", Offset = "0x1FBE900", VA = "0x181FBFD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool LCNGLJCGJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E10", Offset = "0x8B6A10", VA = "0x1808B7E10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x9C2470", Offset = "0x9C1070", VA = "0x1809C2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF5E0", Offset = "0x1FBE1E0", VA = "0x181FBF5E0")]
	public void EEHMJFOCNEE(CPNDPMFCDEK LLHJPFLMPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFA00", Offset = "0x1FBE600", VA = "0x181FBFA00")]
	public void ILJEHFNKHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF6A0", Offset = "0x1FBE2A0", VA = "0x181FBF6A0")]
	private static string? EMPFCILJPHN([In] NDFDLJMPHEA FNKFFOKJOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFE50", Offset = "0x1FBEA50", VA = "0x181FBFE50")]
	public PJLNJHFGPEP()
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
