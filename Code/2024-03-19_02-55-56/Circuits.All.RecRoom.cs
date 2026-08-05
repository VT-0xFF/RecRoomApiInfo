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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DBB3B0", Offset = "0x1DBA3B0", VA = "0x181DBB3B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NNMPKFHFGGO : IDisposable, MPKNIFMDLKB, KMAHMFMEGHN, CPMANAPJGKG, AOKCNLPJHFL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class DFFGFMALGEP : FNJIOEFLACF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int JNCLENAMCLL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4BF0", Offset = "0x1DA3BF0", VA = "0x181DA4BF0", Slot = "5")]
		public PLMNHCLKIPL AFOBIDOAFIB(MGJDGKCFPDL.IENECAPDIMD DGILCEAPJEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void GJKINKMBDMM();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FLMJMNMLEIG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4D40", Offset = "0x1DA3D40", VA = "0x181DA4D40", Slot = "13")]
		public virtual void ALKPHKDIOOE(NNMPKFHFGGO CJMKECHHMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4DC0", Offset = "0x1DA3DC0", VA = "0x181DA4DC0", Slot = "14")]
		public virtual void LAOKBCJKOFI(NNMPKFHFGGO CJMKECHHMIB, JKLONHDKBPA DFHNKDINOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		protected DFFGFMALGEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FNJIOEFLACF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int JNCLENAMCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PLMNHCLKIPL AFOBIDOAFIB(MGJDGKCFPDL.IENECAPDIMD DGILCEAPJEB);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GJKINKMBDMM();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FLMJMNMLEIG();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ALKPHKDIOOE(NNMPKFHFGGO CJMKECHHMIB);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LAOKBCJKOFI(NNMPKFHFGGO CJMKECHHMIB, JKLONHDKBPA DFHNKDINOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NAOFJHIBDEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OFMJOGHJGCD<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> JJPKIGPGLFE;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7600", Offset = "0x1DB6600", VA = "0x181DB7600")]
		internal NAOFJHIBDEB(OFMJOGHJGCD<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> GINEIDDJABE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HCOHGFNJCMP : GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HCOHGFNJCMP GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private HCOHGFNJCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xADF990", Offset = "0xADE990", VA = "0x180ADF990", Slot = "4")]
		public PFEGGNECANP EMPNDCMFKGE(JKLONHDKBPA AOFEPADBPDL)
		{
			return default(PFEGGNECANP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1CA0", Offset = "0x1DB0CA0", VA = "0x181DB1CA0", Slot = "5")]
		public void ALKPHKDIOOE(NNMPKFHFGGO HLMIIECLDOF, JKLONHDKBPA DFHNKDINOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1DB0", Offset = "0x1DB0DB0", VA = "0x181DB1DB0", Slot = "6")]
		public void LAOKBCJKOFI(NNMPKFHFGGO HLMIIECLDOF, JKLONHDKBPA DFHNKDINOMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DMCLJAKPJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DNEFDDHLONC<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> JJPKIGPGLFE;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DA54C0", Offset = "0x1DA44C0", VA = "0x181DA54C0")]
		internal DMCLJAKPJBO(DNEFDDHLONC<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> GINEIDDJABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5470", Offset = "0x1DA4470", VA = "0x181DA5470")]
		public static DMCLJAKPJBO NAJBLLJFKKI()
		{
			return default(DMCLJAKPJBO);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LGGFKJAIAAO : MNHPADLFMBH.ELBMJLJLHFD<JDCJAIOICPD, JKLONHDKBPA, NNMPKFHFGGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LOANCKGMFJD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NNMPKFHFGGO receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JKLONHDKBPA action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LGGFKJAIAAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6120", Offset = "0x1DB5120", VA = "0x181DB6120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6300", Offset = "0x1DB5300", VA = "0x181DB6300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC0590", Offset = "0xABF590", VA = "0x180AC0590", Slot = "4")]
		public ADHLEPAMMHK<JDCJAIOICPD> JCCKHMCJIIJ(NNMPKFHFGGO ACNOIKBCAAG)
		{
			return default(ADHLEPAMMHK<JDCJAIOICPD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5F30", Offset = "0x1DB4F30", VA = "0x181DB5F30", Slot = "5")]
		[AsyncStateMachine(typeof(LOANCKGMFJD))]
		public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> LMJJFPKLIAG(NNMPKFHFGGO ACNOIKBCAAG, JKLONHDKBPA DFHNKDINOMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5F10", Offset = "0x1DB4F10", VA = "0x181DB5F10", Slot = "6")]
		public JKLONHDKBPA[] GICPALJNOKF(NNMPKFHFGGO ACNOIKBCAAG)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LDNAPGMLOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NNMPKFHFGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PAILNLJOFGB rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JCBHMFNFIKJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public PJNIIGNHFFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5C20", Offset = "0x1DB4C20", VA = "0x181DB5C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5EA0", Offset = "0x1DB4EA0", VA = "0x181DB5EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IGPLPLFACNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NNMPKFHFGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB2E10", Offset = "0x1DB1E10", VA = "0x181DB2E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB30A0", Offset = "0x1DB20A0", VA = "0x181DB30A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BEBLMLFMIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public NNMPKFHFGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0920", Offset = "0x1D9F920", VA = "0x181DA0920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0B00", Offset = "0x1D9FB00", VA = "0x181DA0B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GODLKCDFAMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NNMPKFHFGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public JKLONHDKBPA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1680", Offset = "0x1DB0680", VA = "0x181DB1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1870", Offset = "0x1DB0870", VA = "0x181DB1870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NOMKMPAAAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NNMPKFHFGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DBAB50", Offset = "0x1DB9B50", VA = "0x181DBAB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB340", Offset = "0x1DBA340", VA = "0x181DBB340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ADHLEPAMMHK<JDCJAIOICPD> INBGINJFOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NAOFJHIBDEB KOLGJPCKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JEHBPPLAPKG HMBGEGIIPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly FDMHNNOGJAI LNBJHDBKGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1090")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly EKNPNMCHALK GEFONLKDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1098")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly GLKLKFEHMAM.KKNKEHMNCCA KMFJEHCEMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10B8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KFONJFIAPED DPIMMBIFIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BIGOHDACDLJ NBCNJIGHJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LDLKICFPIOK CPAEDDAELOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly NKBAKDFHEBN KOMBMEAKHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LKJMFEHKIDF AIOBMEGJPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NOEBIGGMBLL KCOLBFHKMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1108")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly JEHBPPLAPKG.ANCNGMKGJOO ELCAMLECKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1110")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EJPBCLLBNCF JLIOGNDLKPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JEHBPPLAPKG BCEBACFDGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9E70", Offset = "0x1DB8E70", VA = "0x181DB9E70")]
		get
		{
			return default(JEHBPPLAPKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal FNJIOEFLACF MGHJHIMCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9930", Offset = "0x1DB8930", VA = "0x181DB9930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PLMNHCLKIPL BCKOKGCCALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8F30", Offset = "0x1DB7F30", VA = "0x181DB8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9980", Offset = "0x1DB8980", VA = "0x181DB9980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool BIMNOMKIGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9290", Offset = "0x1DB8290", VA = "0x181DB9290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8E00", Offset = "0x1DB7E00", VA = "0x181DB8E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LCJCCKGELBJ MOKIFODHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA6F0", Offset = "0x1DB96F0", VA = "0x181DBA6F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KFPINHANOMK JDFKNEFHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA710", Offset = "0x1DB9710", VA = "0x181DBA710", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ALPFFACEIOO CBEPKKJHEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA720", Offset = "0x1DB9720", VA = "0x181DBA720", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AKNIOCOIMII IHEGJOIGHON
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA700", Offset = "0x1DB9700", VA = "0x181DBA700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FFBCFPBOAEB? FJIOJAFLPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9C10", Offset = "0x1DB8C10", VA = "0x181DB9C10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private CKLPICJAOHL? OCLPNGBMLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9D40", Offset = "0x1DB8D40", VA = "0x181DB9D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA3C0", Offset = "0x1DB93C0", VA = "0x181DBA3C0")]
	private NNMPKFHFGGO(EKNPNMCHALK BGDNJKOICGK, ADHLEPAMMHK<JDCJAIOICPD> PHEFCCOCLHJ, [In] NAOFJHIBDEB GHDDDEMGEPO, [In] JEHBPPLAPKG FOMHOPBANOI, [In] FDMHNNOGJAI NHDDMLIACHG, PLMNHCLKIPL LIFOFKHKGKM, [In] GLKLKFEHMAM.KKNKEHMNCCA DHKKNEIPNJM, JEHBPPLAPKG.ANCNGMKGJOO IKDIODJMPEM, EJPBCLLBNCF MLCDCGOHJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA160", Offset = "0x1DB9160", VA = "0x181DBA160")]
	public static NNMPKFHFGGO NAJBLLJFKKI(EKNPNMCHALK DGILCEAPJEB, JEHBPPLAPKG.BLOOBLBKJNH PGDMJFBJMKD, ADHLEPAMMHK<JDCJAIOICPD> PHEFCCOCLHJ, ADHLEPAMMHK<GIPEJCIIDKP> OLAKOJLAKKL, BKLDCBGANEP JJJFBBKJDAL, HJJKBKEBAEB OKFMGGKHOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9E80", Offset = "0x1DB8E80", VA = "0x181DB9E80")]
	public static NNMPKFHFGGO NAJBLLJFKKI(EKNPNMCHALK BGDNJKOICGK, [In] JEHBPPLAPKG FOMHOPBANOI, [In] FDMHNNOGJAI NHDDMLIACHG, ADHLEPAMMHK<JDCJAIOICPD> PHEFCCOCLHJ, ADHLEPAMMHK<GIPEJCIIDKP> OLAKOJLAKKL, BKLDCBGANEP JJJFBBKJDAL, HJJKBKEBAEB OKFMGGKHOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8F40", Offset = "0x1DB7F40", VA = "0x181DB8F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9130", Offset = "0x1DB8130", VA = "0x181DB9130")]
	[AsyncStateMachine(typeof(LDNAPGMLOCB))]
	internal Task<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> FEHOEONBFIK(PAILNLJOFGB KBFDAOPBMDF, JCBHMFNFIKJ KDONCADGILP, PJNIIGNHFFM EMCNNGKGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9840", Offset = "0x1DB8840", VA = "0x181DB9840")]
	[AsyncStateMachine(typeof(IGPLPLFACNG))]
	public Task<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> HFLGHAPGMNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9B20", Offset = "0x1DB8B20", VA = "0x181DB9B20")]
	[AsyncStateMachine(typeof(BEBLMLFMIHK))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> JKKLGGBIGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DB92A0", Offset = "0x1DB82A0", VA = "0x181DB92A0")]
	internal void GHGIIODIFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA340", Offset = "0x1DB9340", VA = "0x181DBA340")]
	internal DCPPBKBIMOM<JKLONHDKBPA> PABFMGFPHEH([In] GJFKCPECBGE KKCMMMDHGGD)
	{
		return default(DCPPBKBIMOM<JKLONHDKBPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9AB0", Offset = "0x1DB8AB0", VA = "0x181DB9AB0")]
	internal bool JCGCPEOJKOE([In] GJFKCPECBGE KKCMMMDHGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8D80", Offset = "0x1DB7D80", VA = "0x181DB8D80")]
	internal DCPPBKBIMOM<JKLONHDKBPA> AJFEKFLOPJJ([In] NNNIFOBAHOO NNNFCPFPDIB)
	{
		return default(DCPPBKBIMOM<JKLONHDKBPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DB99A0", Offset = "0x1DB89A0", VA = "0x181DB99A0")]
	[AsyncStateMachine(typeof(GODLKCDFAMM))]
	internal Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOFHDIDNGIN(JKLONHDKBPA DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DB94B0", Offset = "0x1DB84B0", VA = "0x181DB94B0")]
	private JKLONHDKBPA[] GICPALJNOKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8E10", Offset = "0x1DB7E10", VA = "0x181DB8E10")]
	[AsyncStateMachine(typeof(NOMKMPAAAOI))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> DGJPLBGLNBG(Guid DJBODAEIIGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EPEFAOOAKAB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26747D0", Offset = "0x26737D0", VA = "0x1826747D0")]
	public static LGGAFOJGIEM<(TPrev?, NNMPKFHFGGO?), CKLPICJAOHL> OJHHGCEMLGK<TPrev>([In] this LGGAFOJGIEM<TPrev, NNMPKFHFGGO> AOFEPADBPDL)
	{
		return default(LGGAFOJGIEM<(TPrev, NNMPKFHFGGO), CKLPICJAOHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26745B0", Offset = "0x26735B0", VA = "0x1826745B0")]
	public static LGGAFOJGIEM<TPrev?, NNMPKFHFGGO?> NPEDKJAEMAF<TPrev>([In] this LGGAFOJGIEM<TPrev, NNMPKFHFGGO> AOFEPADBPDL)
	{
		return default(LGGAFOJGIEM<TPrev, NNMPKFHFGGO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MJENPKMBEBG<TData> : HMMHOLFLIGF, CMKKPFMCONL, BOFJPOKAPAE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EEKPKFNOHLA<OBKEKPIBNBO>? HNGBEGGJFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string FBJBIEBEAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData GCOMEMFCJKB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EEKPKFNOHLA<OBKEKPIBNBO>? BMAMOLJLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CBD0", Offset = "0x1F6BBD0", VA = "0x181F6CBD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310", Slot = "7")]
	public override string OJGKBMCMILI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0AD0", Offset = "0x3ECFAD0", VA = "0x183ED0AD0")]
	internal MJENPKMBEBG([In] EEKPKFNOHLA<OBKEKPIBNBO>? PEGNKJHCJDD, ADHLEPAMMHK<KMFJMNHLAMA>? CPOILEKAPCC, IOKind? JKACOKLGBJM, string DFJKCKBFLAD, [In] TData ELANMAGHLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IAJMJHIKFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1DB29D0", Offset = "0x1DB19D0", VA = "0x181DB29D0")]
	public static PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL> PIGNNMNLEKB([In] this OMLCDDMNGKH<JOMMGDDKCKJ> KCLKKJDHKNM)
	{
		return default(PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27D8250", Offset = "0x27D7250", VA = "0x1827D8250")]
	public static PBAOJGOHCMJ<TOk, CMKKPFMCONL> NNKBCHAIHMO<TOk>([In] this PBAOJGOHCMJ<TOk, CMKKPFMCONL> AOFEPADBPDL, [In] EEKPKFNOHLA<OBKEKPIBNBO>? PEGNKJHCJDD, ADHLEPAMMHK<KMFJMNHLAMA>? CPOILEKAPCC, IOKind? JKACOKLGBJM, string DFJKCKBFLAD) where TOk : notnull
	{
		return default(PBAOJGOHCMJ<TOk, CMKKPFMCONL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EKNPNMCHALK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DBHKDIKGLID.KHOIFOLEPCJ MJBKDGHOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MGJDGKCFPDL.IENECAPDIMD KLLFJAJADAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NNMPKFHFGGO.FNJIOEFLACF DGNMJNGEKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CNOGHEAKGCF.KEBCJPFIPKM CKANHBOEDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO> BPMBGEOLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DICLHGGBJDJ MMNHOKAMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GMNGMOEKMAC OEOLJJDMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DAOEIIKMPAD LFJGDKIKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NMEACDKGJCL AFBNKLFCHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HHJIANLGKIB KLHEEHIAPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DNDOAOPMAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DA54D0", Offset = "0x1DA44D0", VA = "0x181DA54D0")]
	public static JKLONHDKBPA EOLNHAGKHMN(this JKLONHDKBPA AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DA55E0", Offset = "0x1DA45E0", VA = "0x181DA55E0")]
	public static JKLONHDKBPA GOLHLBMMCMI(this NMKEDPNJCPF AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct NMKEDPNJCPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OPEGHBMBAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NNMPKFHFGGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NMKEDPNJCPF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB910", Offset = "0x1DBA910", VA = "0x181DBB910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DBBBD0", Offset = "0x1DBABD0", VA = "0x181DBBBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString ADACBBLDADO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	private NMKEDPNJCPF(ByteString CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8CC0", Offset = "0x1DB7CC0", VA = "0x181DB8CC0")]
	public static JKLONHDKBPA KMDFMINDMDH(ByteString CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8B00", Offset = "0x1DB7B00", VA = "0x181DB8B00")]
	public static BOOPHCEICIM<PFEGGNECANP, NMKEDPNJCPF> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, NMKEDPNJCPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8BB0", Offset = "0x1DB7BB0", VA = "0x181DB8BB0")]
	[AsyncStateMachine(typeof(OPEGHBMBAHD))]
	public static Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOFHDIDNGIN(NNMPKFHFGGO HLMIIECLDOF, NMKEDPNJCPF AOFEPADBPDL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HKHBJCLIHPA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2380", Offset = "0x1DB1380", VA = "0x181DB2380")]
	public static JKLONHDKBPA KMDFMINDMDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2290", Offset = "0x1DB1290", VA = "0x181DB2290")]
	public static BOOPHCEICIM<PFEGGNECANP, HKHBJCLIHPA> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, HKHBJCLIHPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2300", Offset = "0x1DB1300", VA = "0x181DB2300")]
	public static PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH> IOILAJCLNNK(NNMPKFHFGGO HLMIIECLDOF, [In] HKHBJCLIHPA AOFEPADBPDL)
	{
		return default(PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HEOHCCEIICB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct BOHCMJKAMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NNMPKFHFGGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public HEOHCCEIICB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1670", Offset = "0x1DA0670", VA = "0x181DA1670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DA19E0", Offset = "0x1DA09E0", VA = "0x181DA19E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly PAILNLJOFGB? GIFNBKIDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JCBHMFNFIKJ? LLKMKLJMGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly PJNIIGNHFFM? HOJEOJILJFE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B04740", Offset = "0x1B03740", VA = "0x181B04740")]
	private HEOHCCEIICB(PAILNLJOFGB? KBFDAOPBMDF, JCBHMFNFIKJ? KDONCADGILP, PJNIIGNHFFM? EMCNNGKGOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2190", Offset = "0x1DB1190", VA = "0x181DB2190")]
	public static JKLONHDKBPA? KMDFMINDMDH(PAILNLJOFGB? KBFDAOPBMDF, JCBHMFNFIKJ? KDONCADGILP, PJNIIGNHFFM? EMCNNGKGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1F40", Offset = "0x1DB0F40", VA = "0x181DB1F40")]
	public static BOOPHCEICIM<PFEGGNECANP, HEOHCCEIICB> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, HEOHCCEIICB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2050", Offset = "0x1DB1050", VA = "0x181DB2050")]
	[AsyncStateMachine(typeof(BOHCMJKAMMA))]
	public static Task<PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH>> IOFHDIDNGIN(NNMPKFHFGGO HLMIIECLDOF, HEOHCCEIICB AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DEDNCHPEDAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OEOJBDDPOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<AOFAJGMCGLP, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DEDNCHPEDAF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NNMPKFHFGGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private PBAOJGOHCMJ<AOFAJGMCGLP, OAAMPDEOGNE> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private PBAOJGOHCMJ<object, BOFJPOKAPAE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private PBAOJGOHCMJ<object, BOFJPOKAPAE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private PBAOJGOHCMJ<object, BOFJPOKAPAE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB430", Offset = "0x1DBA430", VA = "0x181DBB430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB8A0", Offset = "0x1DBA8A0", VA = "0x181DBB8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<JKLONHDKBPA> EEDMIBKJFBD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	private DEDNCHPEDAF(IReadOnlyList<JKLONHDKBPA> MLHDOGCFLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4B30", Offset = "0x1DA3B30", VA = "0x181DA4B30")]
	public static JKLONHDKBPA KMDFMINDMDH(IReadOnlyList<JKLONHDKBPA> MLHDOGCFLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4950", Offset = "0x1DA3950", VA = "0x181DA4950")]
	public static BOOPHCEICIM<PFEGGNECANP, DEDNCHPEDAF> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, DEDNCHPEDAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DA49F0", Offset = "0x1DA39F0", VA = "0x181DA49F0")]
	[AsyncStateMachine(typeof(OEOJBDDPOBK))]
	public static Task<PBAOJGOHCMJ<AOFAJGMCGLP, OAAMPDEOGNE>> IOFHDIDNGIN(NNMPKFHFGGO HLMIIECLDOF, DEDNCHPEDAF AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NNNIFOBAHOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int BIBAPHNHGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int EDPEAEGJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] GCOMEMFCJKB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x18A4BB0", Offset = "0x18A3BB0", VA = "0x1818A4BB0")]
	private NNNIFOBAHOO(int FBDNKGNOEFD, int GCDIELAOHNA, byte[] ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAA70", Offset = "0x1DB9A70", VA = "0x181DBAA70")]
	public static JKLONHDKBPA KMDFMINDMDH(int FBDNKGNOEFD, int GCDIELAOHNA, ByteString ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA810", Offset = "0x1DB9810", VA = "0x181DBA810")]
	public static JKLONHDKBPA[] FFDFCFLFBPF(JKLONHDKBPA DFHNKDINOMO, int MOKKKPAADAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA730", Offset = "0x1DB9730", VA = "0x181DBA730")]
	public static BOOPHCEICIM<PFEGGNECANP, NNNIFOBAHOO> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, NNNIFOBAHOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA950", Offset = "0x1DB9950", VA = "0x181DBA950")]
	public static PBAOJGOHCMJ<JKLONHDKBPA, PHBMKBALCLH> IOILAJCLNNK(NNMPKFHFGGO HLMIIECLDOF, [In] NNNIFOBAHOO AOFEPADBPDL)
	{
		return default(PBAOJGOHCMJ<JKLONHDKBPA, PHBMKBALCLH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GJFKCPECBGE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IPKHLKLLNIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<bool, PHBMKBALCLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NNMPKFHFGGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GJFKCPECBGE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private PBAOJGOHCMJ<bool, PHBMKBALCLH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, PHBMKBALCLH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3660", Offset = "0x1DB2660", VA = "0x181DB3660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3CA0", Offset = "0x1DB2CA0", VA = "0x181DB3CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int BIBAPHNHGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int EDPEAEGJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] GCOMEMFCJKB;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x18A4BB0", Offset = "0x18A3BB0", VA = "0x1818A4BB0")]
	private GJFKCPECBGE(int FBDNKGNOEFD, int GCDIELAOHNA, byte[] ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0AB0", Offset = "0x1DAFAB0", VA = "0x181DB0AB0")]
	public static JKLONHDKBPA KMDFMINDMDH(int FBDNKGNOEFD, int GCDIELAOHNA, ByteString ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DB06A0", Offset = "0x1DAF6A0", VA = "0x181DB06A0")]
	public static JKLONHDKBPA?[]? AOEEOLNCGME(int MOKKKPAADAJ, PAILNLJOFGB? KBFDAOPBMDF, JCBHMFNFIKJ? KDONCADGILP, PJNIIGNHFFM? EMCNNGKGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DB08A0", Offset = "0x1DAF8A0", VA = "0x181DB08A0")]
	public static BOOPHCEICIM<PFEGGNECANP, GJFKCPECBGE> DPBNJJPPECA(JKLONHDKBPA BBBKGJIEHNF)
	{
		return default(BOOPHCEICIM<PFEGGNECANP, GJFKCPECBGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0980", Offset = "0x1DAF980", VA = "0x181DB0980")]
	[AsyncStateMachine(typeof(IPKHLKLLNIH))]
	public static Task<PBAOJGOHCMJ<bool, PHBMKBALCLH>> IOFHDIDNGIN(NNMPKFHFGGO HLMIIECLDOF, GJFKCPECBGE AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KFONJFIAPED : LCJCCKGELBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MGKCEHGJKNM? GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB49B0", Offset = "0x1DB39B0", VA = "0x181DB49B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	internal KFONJFIAPED(NNMPKFHFGGO CJMKECHHMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GLODOHNFDBI : MGKCEHGJKNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BPPAGNNDHAH NEPDBOOIJJB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	public GLODOHNFDBI(NNMPKFHFGGO CJMKECHHMIB, BPPAGNNDHAH LIDBDPEDMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0E60", Offset = "0x1DAFE60", VA = "0x181DB0E60", Slot = "4")]
	public PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL> NCCKCLIKHEO(EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<EPMBAEECFAC> AOGEFPCFIDF)
	{
		return default(PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0B90", Offset = "0x1DAFB90", VA = "0x181DB0B90", Slot = "5")]
	public PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL> JFHEMCGKONH(EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<FJPMHDEFCDN> EEMDIPHNDGL)
	{
		return default(PBAOJGOHCMJ<EGBOCDKFAGE, CMKKPFMCONL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DBHKDIKGLID : OIPJDEBGDNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface KHOIFOLEPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BPPAGNNDHAH> AIMBCHJAKIN(NNMPKFHFGGO CJMKECHHMIB, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM, CancellationToken JMJKFNJJBHM);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PHNDHGHMPCN AJIFEGKKBNJ(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NKGOHPPFMOH : KHOIFOLEPCJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct GIKIIGOAEFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<BPPAGNNDHAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public NNMPKFHFGGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public JCBHMFNFIKJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public PJNIIGNHFFM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<CNOGHEAKGCF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1DB0310", Offset = "0x1DAF310", VA = "0x181DB0310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1DB0630", Offset = "0x1DAF630", VA = "0x181DB0630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly NKGOHPPFMOH GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private NKGOHPPFMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8900", Offset = "0x1DB7900", VA = "0x181DB8900", Slot = "4")]
		[AsyncStateMachine(typeof(GIKIIGOAEFB))]
		public Task<BPPAGNNDHAH> AIMBCHJAKIN(NNMPKFHFGGO CJMKECHHMIB, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM, CancellationToken JMJKFNJJBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8A60", Offset = "0x1DB7A60", VA = "0x181DB8A60", Slot = "5")]
		public PHNDHGHMPCN AJIFEGKKBNJ(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BIKMKKJEBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DBHKDIKGLID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NNMPKFHFGGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JCBHMFNFIKJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PJNIIGNHFFM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public PAILNLJOFGB evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KHOIFOLEPCJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<BPPAGNNDHAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1040", Offset = "0x1DA0040", VA = "0x181DA1040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DA15A0", Offset = "0x1DA05A0", VA = "0x181DA15A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BPPAGNNDHAH NEPDBOOIJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PHNDHGHMPCN ACPLDMIPKFG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FFBCFPBOAEB COKGPBAGIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4860", Offset = "0x1DA3860", VA = "0x181DA4860", Slot = "4")]
		get
		{
			return default(FFBCFPBOAEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CKLPICJAOHL BCPHHHFFBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DA47A0", Offset = "0x1DA37A0", VA = "0x181DA47A0", Slot = "5")]
		get
		{
			return default(CKLPICJAOHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GLODOHNFDBI PDNFANJCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CLLMGOOGNOC GKIOJHLHODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public EAEHJBNBDAG DAJFAJHDPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DA48C0", Offset = "0x1DA38C0", VA = "0x181DA48C0")]
	private DBHKDIKGLID(BPPAGNNDHAH LIDBDPEDMLE, PHNDHGHMPCN GDGIOABJOFG, GLODOHNFDBI GIKLKMKJDMA, CLLMGOOGNOC NAEEFAGHGPG, EAEHJBNBDAG NFGGPFKDGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4630", Offset = "0x1DA3630", VA = "0x181DA4630")]
	[AsyncStateMachine(typeof(BIKMKKJEBJD))]
	public static Task<DBHKDIKGLID> CENPFJOHMJL(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4800", Offset = "0x1DA3800", VA = "0x181DA4800", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MGJDGKCFPDL : PLMNHCLKIPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface IENECAPDIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<OIPJDEBGDNN> AIDEMECJAPB(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM, CancellationToken JMJKFNJJBHM);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGBELECKLOD();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MBHAMJLKNHI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class HPFALLCJPAO : IENECAPDIMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct NICLFPCFJHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<OIPJDEBGDNN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public NNMPKFHFGGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public PAILNLJOFGB evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public JCBHMFNFIKJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public PJNIIGNHFFM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<DBHKDIKGLID> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1DB8440", Offset = "0x1DB7440", VA = "0x181DB8440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DB8780", Offset = "0x1DB7780", VA = "0x181DB8780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DB2420", Offset = "0x1DB1420", VA = "0x181DB2420", Slot = "4")]
		[AsyncStateMachine(typeof(NICLFPCFJHI))]
		public Task<OIPJDEBGDNN> AIDEMECJAPB(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM, CancellationToken JMJKFNJJBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OGBELECKLOD();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MBHAMJLKNHI();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		protected HPFALLCJPAO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NGOKMDJHNFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<OIPJDEBGDNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public MGJDGKCFPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<EMBFKEMHPML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DB81D0", Offset = "0x1DB71D0", VA = "0x181DB81D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DB83D0", Offset = "0x1DB73D0", VA = "0x181DB83D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DHMGFKBKNMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public MGJDGKCFPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NNMPKFHFGGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public PAILNLJOFGB evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JCBHMFNFIKJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public PJNIIGNHFFM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<OIPJDEBGDNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4EE0", Offset = "0x1DA3EE0", VA = "0x181DA4EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5410", Offset = "0x1DA4410", VA = "0x181DA5410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IENECAPDIMD KFNEOPKPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<EMBFKEMHPML> NCPBJICMBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<EMBFKEMHPML> NJICFNDBDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource BEGADHJDAJO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BIMNOMKIGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x883B80", Offset = "0x882B80", VA = "0x180883B80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x967470", Offset = "0x966470", VA = "0x180967470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x967450", Offset = "0x966450", VA = "0x180967450", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x967490", Offset = "0x966490", VA = "0x180967490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NAEDMLKIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF61670", Offset = "0xF60670", VA = "0x180F61670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7410", Offset = "0x1DB6410", VA = "0x181DB7410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public OIPJDEBGDNN? MBFLCDMBNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC440", Offset = "0x7BB440", VA = "0x1807BC440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7320", Offset = "0x1DB6320", VA = "0x181DB7320", Slot = "7")]
	[AsyncStateMachine(typeof(NGOKMDJHNFB))]
	public Task<OIPJDEBGDNN> ELPNLCDKLDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7420", Offset = "0x1DB6420", VA = "0x181DB7420")]
	public MGJDGKCFPDL(IENECAPDIMD DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7050", Offset = "0x1DB6050", VA = "0x181DB7050", Slot = "8")]
	[AsyncStateMachine(typeof(DHMGFKBKNMO))]
	public Task AMHJNLCPNLP(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB71B0", Offset = "0x1DB61B0", VA = "0x181DB71B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ABFFMMFBPAJ : DNODOMBGKPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CLLMGOOGNOC FIEGHIMNMAB;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public ABFFMMFBPAJ(CLLMGOOGNOC NAEEFAGHGPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class KBHDDBJLJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class OPOGKBOKFJO<TGraph> : GJGPEGFGDNF where TGraph : INIKEGJGPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph BDKFDCKBIML;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual MEBHKJKIEDB? AKOIBNIPHKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xDB40C0", Offset = "0xDB30C0", VA = "0x180DB40C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
		public OPOGKBOKFJO(TGraph AIAGFCPBNID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class MFBMNDDGLFM : OPOGKBOKFJO<GPMJCDPHCFE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override MEBHKJKIEDB? AKOIBNIPHKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6F60", Offset = "0x1DB5F60", VA = "0x181DB6F60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6F80", Offset = "0x1DB5F80", VA = "0x181DB6F80")]
		public MFBMNDDGLFM(GPMJCDPHCFE LICCNPHDABN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4820", Offset = "0x1DB3820", VA = "0x181DB4820")]
	public static GJGPEGFGDNF NAJBLLJFKKI(INIKEGJGPBO AIAGFCPBNID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class DPEBMPAHIJM : PNCMMCFPNCI, PIGODIIJAML, CMGHFLFOGLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KKPBNMDNMIL
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
			public KKPBNMDNMIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public DICLHGGBJDJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1DBD620", Offset = "0x1DBC620", VA = "0x181DBD620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1DBD890", Offset = "0x1DBC890", VA = "0x181DBD890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DPEBMPAHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KKPBNMDNMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4AC0", Offset = "0x1DB3AC0", VA = "0x181DB4AC0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task AEJHHPBOPNH(DICLHGGBJDJ errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GMECAOMPHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public DPEBMPAHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1130", Offset = "0x1DB0130", VA = "0x181DB1130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1620", Offset = "0x1DB0620", VA = "0x181DB1620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class GHKPOGGPMOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public GHKPOGGPMOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1DBD8F0", Offset = "0x1DBC8F0", VA = "0x181DBD8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1DBDBD0", Offset = "0x1DBCBD0", VA = "0x181DBDBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DPEBMPAHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GHKPOGGPMOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0240", Offset = "0x1DAF240", VA = "0x181DB0240")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GNANHKNBBOJ(DICLHGGBJDJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly FBFKJDNAODM ABKMPOHMJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<AJNNMENCAII> NHHPLHJAMEC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private EKNPNMCHALK JNLAGLJECOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5C30", Offset = "0x1DA4C30", VA = "0x181DA5C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ADHLEPAMMHK<EPMBAEECFAC> CDJMIHGPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x883330", Offset = "0x882330", VA = "0x180883330", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(ADHLEPAMMHK<EPMBAEECFAC>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB315C0", Offset = "0xB305C0", VA = "0x180B315C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private ADHLEPAMMHK<HDMIFOBJNHK> JNPIBAJNPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x95FD70", Offset = "0x95ED70", VA = "0x18095FD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override ADHLEPAMMHK<KMFJMNHLAMA> PAGAIHAMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5950", Offset = "0x1DA4950", VA = "0x181DA5950", Slot = "19")]
		get
		{
			return default(ADHLEPAMMHK<KMFJMNHLAMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AEKBEALHOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7FD0", Offset = "0x1DA6FD0", VA = "0x181DA7FD0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8410", Offset = "0x1DA7410", VA = "0x181DA8410")]
	private DPEBMPAHIJM(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF, FBFKJDNAODM JJEIEOIALHP, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<EPMBAEECFAC> AOGEFPCFIDF, ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC, bool LBOKFIAPOGA, string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6E60", Offset = "0x1DA5E60", VA = "0x181DA6E60")]
	public static DPEBMPAHIJM NAJBLLJFKKI(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF, FBFKJDNAODM IIBDJBFNFJM, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC, ADHLEPAMMHK<EPMBAEECFAC> AOGEFPCFIDF, bool LBOKFIAPOGA, bool EFDIDHHFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5C50", Offset = "0x1DA4C50", VA = "0x181DA5C50", Slot = "20")]
	protected override void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5E10", Offset = "0x1DA4E10", VA = "0x181DA5E10", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6CE0", Offset = "0x1DA5CE0", VA = "0x181DA6CE0", Slot = "28")]
	public void JACFAOEEPHO(AJNNMENCAII KODNJFLPNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DA78C0", Offset = "0x1DA68C0", VA = "0x181DA78C0", Slot = "25")]
	public void OOOACIKICOI(HLKKJCJAJKH DJDJPKGBPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5FD0", Offset = "0x1DA4FD0", VA = "0x181DA5FD0", Slot = "26")]
	public void EFDNCDIHBNN(BGBPIJLDINL JAJONEPNHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7440", Offset = "0x1DA6440", VA = "0x181DA7440", Slot = "22")]
	protected override void NHKFCAOEMBD(FFEEHMPDCIA LBBHGPDEDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7680", Offset = "0x1DA6680", VA = "0x181DA7680", Slot = "30")]
	public string NPBGEJMKAKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7CA0", Offset = "0x1DA6CA0", VA = "0x181DA7CA0", Slot = "27")]
	public string PAIDBBBNOJI(int JKABMGFMNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7210", Offset = "0x1DA6210", VA = "0x181DA7210")]
	private void NGDPCBICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DA75B0", Offset = "0x1DA65B0", VA = "0x181DA75B0", Slot = "29")]
	public void NNIDICNOACF(AJNNMENCAII KODNJFLPNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6970", Offset = "0x1DA5970", VA = "0x181DA6970")]
	private void FGLFEJHJKMJ(bool CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DA56B0", Offset = "0x1DA46B0", VA = "0x181DA56B0", Slot = "31")]
	[AsyncStateMachine(typeof(GMECAOMPHLE))]
	public Task AIMJKFJEBCM(string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8190", Offset = "0x1DA7190", VA = "0x181DA8190")]
	public void PGECGDKEIHI(string CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DA57B0", Offset = "0x1DA47B0", VA = "0x181DA57B0")]
	private void AIPPMGJOHFI(int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xB315C0", Offset = "0xB305C0", VA = "0x180B315C0")]
	internal void LONLBGOCFIK(ADHLEPAMMHK<EPMBAEECFAC> CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5990", Offset = "0x1DA4990", VA = "0x181DA5990")]
	[CompilerGenerated]
	private bool CGJKANNACPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5AE0", Offset = "0x1DA4AE0", VA = "0x181DA5AE0")]
	[CompilerGenerated]
	private bool COAMJPGKANN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6D40", Offset = "0x1DA5D40", VA = "0x181DA6D40")]
	[CompilerGenerated]
	private int PEGLFKJGHIO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7520", Offset = "0x1DA6520", VA = "0x181DA7520")]
	[CompilerGenerated]
	private bool NJIBPIGKMLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DA82C0", Offset = "0x1DA72C0", VA = "0x181DA82C0")]
	[CompilerGenerated]
	private bool PNJKGJPNCNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6B30", Offset = "0x1DA5B30", VA = "0x181DA6B30")]
	[CompilerGenerated]
	private bool FIAKDOFCCBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6B80", Offset = "0x1DA5B80", VA = "0x181DA6B80")]
	[CompilerGenerated]
	private bool GFLGKIJHJGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6D40", Offset = "0x1DA5D40", VA = "0x181DA6D40")]
	[CompilerGenerated]
	private int JHOGBBBHCCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DA77F0", Offset = "0x1DA67F0", VA = "0x181DA77F0")]
	[CompilerGenerated]
	private bool OALOGJICGFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6D90", Offset = "0x1DA5D90", VA = "0x181DA6D90")]
	[CompilerGenerated]
	private int KBNJIPIMPLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6DE0", Offset = "0x1DA5DE0", VA = "0x181DA6DE0")]
	[CompilerGenerated]
	private void MJJKHMGONLA(object CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6C10", Offset = "0x1DA5C10", VA = "0x181DA6C10")]
	[CompilerGenerated]
	private bool HCFDEMCOJGA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MAAAEIDLEGN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class LJJOCMMDOLN<TNode> : DELJGGMKELJ<TNode> where TNode : notnull, FMJIIIDLMFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct FGHIPFOLMDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public LJJOCMMDOLN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3670470", Offset = "0x366F470", VA = "0x183670470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3670840", Offset = "0x366F840", VA = "0x183670840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct OGLCKFNPMKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LJJOCMMDOLN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public ADHLEPAMMHK<HAOMCHNKLHE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4076AD0", Offset = "0x4075AD0", VA = "0x184076AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4076EA0", Offset = "0x4075EA0", VA = "0x184076EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override bool DDBADHOHGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public sealed override ADHLEPAMMHK<HAOMCHNKLHE>? AMHODBNDFGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3CF0EB0", Offset = "0x3CEFEB0", VA = "0x183CF0EB0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0E80", Offset = "0x3CEFE80", VA = "0x183CF0E80")]
		public LJJOCMMDOLN(NNMPKFHFGGO CJMKECHHMIB, TNode PENNBKHEEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0D60", Offset = "0x3CEFD60", VA = "0x183CF0D60", Slot = "94")]
		[AsyncStateMachine(typeof(LJJOCMMDOLN<>.FGHIPFOLMDO))]
		public override Task<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> KJHONGFLIFF(string GCMHJLFFDHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0B80", Offset = "0x3CEFB80", VA = "0x183CF0B80", Slot = "116")]
		public sealed override bool IDGFLKEFEMC(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0C20", Offset = "0x3CEFC20", VA = "0x183CF0C20", Slot = "106")]
		protected sealed override bool IMAKJLNADEJ(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0CC0", Offset = "0x3CEFCC0", VA = "0x183CF0CC0", Slot = "107")]
		protected override bool KAPLEKPFDNA(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0A70", Offset = "0x3CEFA70", VA = "0x183CF0A70", Slot = "95")]
		[AsyncStateMachine(typeof(LJJOCMMDOLN<>.OGLCKFNPMKD))]
		public override Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> FPKILHKLIGK(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class CIOIOMBBHLD : MDLLAILFKNF<JENGDGOFICG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1CB0", Offset = "0x1DA0CB0", VA = "0x181DA1CB0")]
		public CIOIOMBBHLD(NNMPKFHFGGO CJMKECHHMIB, JENGDGOFICG PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class MDLLAILFKNF<TNode> : DELJGGMKELJ<TNode> where TNode : notnull, BNBKLLNDAIK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct HNJCDGGIOFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public MDLLAILFKNF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x37EF0C0", Offset = "0x37EE0C0", VA = "0x1837EF0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x37EF430", Offset = "0x37EE430", VA = "0x1837EF430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct ALMFCJFEFCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public MDLLAILFKNF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ADHLEPAMMHK<HAOMCHNKLHE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x37B13C0", Offset = "0x37B03C0", VA = "0x1837B13C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x37B1710", Offset = "0x37B0710", VA = "0x1837B1710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override ADHLEPAMMHK<CDCECIICCHL>? LJNOBGMHNBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3EC3190", Offset = "0x3EC2190", VA = "0x183EC3190", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override ADHLEPAMMHK<HAOMCHNKLHE>? AMHODBNDFGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x3EC3240", Offset = "0x3EC2240", VA = "0x183EC3240", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0E80", Offset = "0x3CEFE80", VA = "0x183CF0E80")]
		public MDLLAILFKNF(NNMPKFHFGGO CJMKECHHMIB, TNode PENNBKHEEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3070", Offset = "0x3EC2070", VA = "0x183EC3070", Slot = "94")]
		[AsyncStateMachine(typeof(MDLLAILFKNF<>.HNJCDGGIOFI))]
		public override Task<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> KJHONGFLIFF(string GCMHJLFFDHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2E90", Offset = "0x3EC1E90", VA = "0x183EC2E90", Slot = "116")]
		public sealed override bool IDGFLKEFEMC(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2F30", Offset = "0x3EC1F30", VA = "0x183EC2F30", Slot = "106")]
		protected sealed override bool IMAKJLNADEJ(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2FD0", Offset = "0x3EC1FD0", VA = "0x183EC2FD0", Slot = "107")]
		protected override bool KAPLEKPFDNA(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2D80", Offset = "0x3EC1D80", VA = "0x183EC2D80", Slot = "95")]
		[AsyncStateMachine(typeof(MDLLAILFKNF<>.ALMFCJFEFCC))]
		public override Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> FPKILHKLIGK(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class JMDPIOJOCHL : DELJGGMKELJ<KCAIJMOEJOD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xA45400", Offset = "0xA44400", VA = "0x180A45400", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1DB47B0", Offset = "0x1DB37B0", VA = "0x181DB47B0")]
		public JMDPIOJOCHL(NNMPKFHFGGO CJMKECHHMIB, KCAIJMOEJOD PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class FCFICEHKGDI : MDLLAILFKNF<EBIAILBPHOG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool AGEEBLHLDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool ODIDJLLDJFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1DA9610", Offset = "0x1DA8610", VA = "0x181DA9610", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x923280", Offset = "0x922280", VA = "0x180923280", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DA95B0", Offset = "0x1DA85B0", VA = "0x181DA95B0")]
		public FCFICEHKGDI(NNMPKFHFGGO CJMKECHHMIB, EBIAILBPHOG PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class IOADPFMFLPF : DELJGGMKELJ<OFCFLOMIHGO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x103C740", Offset = "0x103B740", VA = "0x18103C740", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1DB35F0", Offset = "0x1DB25F0", VA = "0x181DB35F0")]
		public IOADPFMFLPF(NNMPKFHFGGO CJMKECHHMIB, OFCFLOMIHGO PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class CBLMEGMONPF : DELJGGMKELJ<KBNLIEGFBNN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x924620", Offset = "0x923620", VA = "0x180924620", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1A50", Offset = "0x1DA0A50", VA = "0x181DA1A50")]
		public CBLMEGMONPF(NNMPKFHFGGO CJMKECHHMIB, KBNLIEGFBNN PENNBKHEEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "106")]
		protected override bool IMAKJLNADEJ(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class LHFGNKABHIC : DELJGGMKELJ<HMJNMEHPHDH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x932B90", Offset = "0x931B90", VA = "0x180932B90", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool FJLHLIDENFH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1DB60D0", Offset = "0x1DB50D0", VA = "0x181DB60D0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override bool BIHCLFEKNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6060", Offset = "0x1DB5060", VA = "0x181DB6060")]
		public LHFGNKABHIC(NNMPKFHFGGO CJMKECHHMIB, HMJNMEHPHDH PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class AHKCFBKNFKM : DELJGGMKELJ<ODBCPMCKMIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x909610", Offset = "0x908610", VA = "0x180909610", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FJLHLIDENFH
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1DA08D0", Offset = "0x1D9F8D0", VA = "0x181DA08D0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool BIHCLFEKNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0860", Offset = "0x1D9F860", VA = "0x181DA0860")]
		public AHKCFBKNFKM(NNMPKFHFGGO CJMKECHHMIB, ODBCPMCKMIF PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BNGMJAPJFKO : LJJOCMMDOLN<GLMFNMBGDBN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x930290", Offset = "0x92F290", VA = "0x180930290", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1610", Offset = "0x1DA0610", VA = "0x181DA1610")]
		public BNGMJAPJFKO(NNMPKFHFGGO CJMKECHHMIB, GLMFNMBGDBN PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class CPIGOKAGJFG : DELJGGMKELJ<HAJMFOKCJDO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1DA45C0", Offset = "0x1DA35C0", VA = "0x181DA45C0")]
		public CPIGOKAGJFG(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class DELJGGMKELJ<TNode> : LIDAIMBHMPN, IDisposable where TNode : notnull, HAJMFOKCJDO
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		protected readonly struct AGHJMOPJFPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string PFEMNIDBHDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly string NIMLMOLPMMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly string NOPAFHNNEPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public readonly DBLLEHNNMEE NIGFMCLOCKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public readonly JKKLKFMKGDI BIKDEDGFBNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public readonly Func<string, bool> FNJNBJMEEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public readonly string JHDAHOAPECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public readonly Func<string, bool> IKOBDIOAFGB;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x37A1B50", Offset = "0x37A0B50", VA = "0x1837A1B50")]
			public AGHJMOPJFPO(string BGHEAOFPJKM, string HIHMFOIMCIM, string JOJIIAMEDEB, DBLLEHNNMEE JCPODOKDHIO, JKKLKFMKGDI AEMNEDFCOPB, Func<string, bool> BIGPODIKLEI, string EAEKPHDLJIH, Func<string, bool> HFHKCCAOBMC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class CBHBKEIPMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public DELJGGMKELJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public NNMPKFHFGGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public CBHBKEIPMBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4B8F730", Offset = "0x4B8E730", VA = "0x184B8F730")]
			internal GGEOCCHMJFP NIALJDEGCGP(BKEGAOIMPIK portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct DKJCNIKODOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public DELJGGMKELJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x50D07D0", Offset = "0x50CF7D0", VA = "0x1850D07D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct GDPEAAJKHKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public DELJGGMKELJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public DFEHHELGJNI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public OIFLPNNFNNI? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3741530", Offset = "0x3740530", VA = "0x183741530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x37417D0", Offset = "0x37407D0", VA = "0x1837417D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class PHFALHFDCFB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public PHFALHFDCFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x30FC200", Offset = "0x30FB200", VA = "0x1830FC200", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public GKIICEGKOBI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public DELJGGMKELJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public LAEMJFPCJLA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public PHFALHFDCFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			internal string CMCCDKJILON()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
			internal void OPINCPKCGJG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x41499E0", Offset = "0x41489E0", VA = "0x1841499E0")]
			[AsyncStateMachine(typeof(DELJGGMKELJ<>.PHFALHFDCFB.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void LPAKLBNCOGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class BAJHPFPOJFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public GKIICEGKOBI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public BAJHPFPOJFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4786080", Offset = "0x4785080", VA = "0x184786080")]
			internal bool BBJBHCCKELE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x4786160", Offset = "0x4785160", VA = "0x184786160")]
			internal bool FNNKOOJLEAC(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct KDLKOHOIPGL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public DELJGGMKELJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3BF24F0", Offset = "0x3BF14F0", VA = "0x183BF24F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3BF2860", Offset = "0x3BF1860", VA = "0x183BF2860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly NNMPKFHFGGO LDBDKKHEMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly bool NKFGBONNHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private JIKAOEJPHBF<HAOMCHNKLHE, GGEOCCHMJFP> KOMEFFKGMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private JIKAOEJPHBF<HAOMCHNKLHE, EDOJJPLGLKD> KPLFJFBHDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<Action> HMINNHAGNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<ADHLEPAMMHK<HAOMCHNKLHE>>? ILEBJDHFDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<ADHLEPAMMHK<HAOMCHNKLHE>, EDOJJPLGLKD>? CLPJLFPHKJA;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected GKIICEGKOBI MCEDOAEKDOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x50BD9D0", Offset = "0x50BC9D0", VA = "0x1850BD9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected TNode MHIINAILEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public EEKPKFNOHLA<GBEDNKELGKE> FPNLADDJKEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4520", Offset = "0x9B3520", VA = "0x1809B4520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(EEKPKFNOHLA<GBEDNKELGKE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public ADHLEPAMMHK<LBHKOJMLAKF> OOGPMGDAICE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x50BEFC0", Offset = "0x50BDFC0", VA = "0x1850BEFC0", Slot = "6")]
			get
			{
				return default(ADHLEPAMMHK<LBHKOJMLAKF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object EOPLLFAHMKF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x33767A0", Offset = "0x33757A0", VA = "0x1833767A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool MMLAJFLCPIA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int LFFGDKFENIC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x50BED10", Offset = "0x50BDD10", VA = "0x1850BED10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public LFCMEGDHOPI BLGNJANDFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x50BECC0", Offset = "0x50BDCC0", VA = "0x1850BECC0", Slot = "10")]
			get
			{
				return default(LFCMEGDHOPI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string HOKGDKPLBBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x50BF150", Offset = "0x50BE150", VA = "0x1850BF150", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected virtual bool BIHCLFEKNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ADHLEPAMMHK<KECFOCMOBIB> JKCOPLOMKPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x94EB20", Offset = "0x94DB20", VA = "0x18094EB20", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(ADHLEPAMMHK<KECFOCMOBIB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9BE010", Offset = "0x9BD010", VA = "0x1809BE010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual bool FJLHLIDENFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual bool AGEEBLHLDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual HPGJOBCPNKE HFJCCIAECGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x921630", Offset = "0x920630", VA = "0x180921630", Slot = "88")]
			get
			{
				return default(HPGJOBCPNKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool HJFNNBDGGDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x50BEAF0", Offset = "0x50BDAF0", VA = "0x1850BEAF0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool DLIMGOALNFD
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x50BEB40", Offset = "0x50BDB40", VA = "0x1850BEB40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool KHGBIJCLEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x50BEB90", Offset = "0x50BDB90", VA = "0x1850BEB90", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int DBJJNKNMBIC
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x50BEF80", Offset = "0x50BDF80", VA = "0x1850BEF80", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool BAIBKHFLHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x50BEE00", Offset = "0x50BDE00", VA = "0x1850BEE00", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HDJCAJAJDDE
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x50BEC20", Offset = "0x50BDC20", VA = "0x1850BEC20", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool PFAFKBBAKMB
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB01510", Offset = "0xB00510", VA = "0x180B01510", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB01520", Offset = "0xB00520", VA = "0x180B01520")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool NNJKPKNEIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual bool PNIEPBBAPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x50BEBE0", Offset = "0x50BDBE0", VA = "0x1850BEBE0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool JHADLKJHDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x50BED50", Offset = "0x50BDD50", VA = "0x1850BED50", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public DFEHHELGJNI DANHCCHNLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x50BEEE0", Offset = "0x50BDEE0", VA = "0x1850BEEE0", Slot = "27")]
			get
			{
				return default(DFEHHELGJNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public OIFLPNNFNNI MDCBKNMNABN
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x50BEF30", Offset = "0x50BDF30", VA = "0x1850BEF30", Slot = "29")]
			get
			{
				return default(OIFLPNNFNNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool FNACJPIGGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual MDLCCMNNIMB? AEBFPAEGPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual MEKEICNLILM? PPABNHDBNMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual IEnumerable<EEKPKFNOHLA<OBKEKPIBNBO>>? LIMLNNEJLFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OKGKOAKKFFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x50BEC70", Offset = "0x50BDC70", VA = "0x1850BEC70", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EEKPKFNOHLA<CDCECIICCHL> DDDDKOOIALO
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x50BEE40", Offset = "0x50BDE40", VA = "0x1850BEE40", Slot = "55")]
			get
			{
				return default(EEKPKFNOHLA<CDCECIICCHL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool DDBADHOHGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual ADHLEPAMMHK<CDCECIICCHL>? LJNOBGMHNBE
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual bool ODIDJLLDJFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool LMJEAPLECJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x50BEDA0", Offset = "0x50BDDA0", VA = "0x1850BEDA0", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7C01B0", Offset = "0x7BF1B0", VA = "0x1807C01B0", Slot = "62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x7C0060", Offset = "0x7BF060", VA = "0x1807C0060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public EEKPKFNOHLA<OBKEKPIBNBO> LCEPAFBPPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x50BEE90", Offset = "0x50BDE90", VA = "0x1850BEE90", Slot = "61")]
			get
			{
				return default(EEKPKFNOHLA<OBKEKPIBNBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public EEKPKFNOHLA<OBKEKPIBNBO>? AMDNOEHHALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x50BF030", Offset = "0x50BE030", VA = "0x1850BF030", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OGOEANFICND<HAOMCHNKLHE, EDOJJPLGLKD> KHODFPCLHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x50BF110", Offset = "0x50BE110", VA = "0x1850BF110", Slot = "63")]
			get
			{
				return default(OGOEANFICND<HAOMCHNKLHE, EDOJJPLGLKD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual ADHLEPAMMHK<HAOMCHNKLHE>? AMHODBNDFGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BCLFKDPJKGK
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x50BCE20", Offset = "0x50BBE20", VA = "0x1850BCE20", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x50BE220", Offset = "0x50BD220", VA = "0x1850BE220", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OLPEMNBOFAE IDMOJBIDBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x50BC6F0", Offset = "0x50BB6F0", VA = "0x1850BC6F0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x50BC850", Offset = "0x50BB850", VA = "0x1850BC850", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JDIJDELADGA OINDJOOJCBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x50BC400", Offset = "0x50BB400", VA = "0x1850BC400", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x50BB230", Offset = "0x50BA230", VA = "0x1850BB230", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CIDLMBAJPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x50BCEC0", Offset = "0x50BBEC0", VA = "0x1850BCEC0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x50BA830", Offset = "0x50B9830", VA = "0x1850BA830", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NGDJLNFBNCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x50BD890", Offset = "0x50BC890", VA = "0x1850BD890", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x50BDC40", Offset = "0x50BCC40", VA = "0x1850BDC40", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>, EDOJJPLGLKD> OELFBNMMOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x50BD770", Offset = "0x50BC770", VA = "0x1850BD770", Slot = "65")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x50BE540", Offset = "0x50BD540", VA = "0x1850BE540", Slot = "66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>, EDOJJPLGLKD> NHACMJBMLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x50BD6B0", Offset = "0x50BC6B0", VA = "0x1850BD6B0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x50BC2F0", Offset = "0x50BB2F0", VA = "0x1850BC2F0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>> GNMCLCDGDCE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x50BDB80", Offset = "0x50BCB80", VA = "0x1850BDB80", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x50BC570", Offset = "0x50BB570", VA = "0x1850BC570", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>, ADHLEPAMMHK<HAOMCHNKLHE>> CLCHIECFAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x50BA9A0", Offset = "0x50B99A0", VA = "0x1850BA9A0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x50BC790", Offset = "0x50BB790", VA = "0x1850BC790", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>, EDOJJPLGLKD> BFCFEHDMLOF
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x50B9AF0", Offset = "0x50B8AF0", VA = "0x1850B9AF0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x50BE160", Offset = "0x50BD160", VA = "0x1850BE160", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ADHLEPAMMHK<HAOMCHNKLHE>, ADHLEPAMMHK<HAOMCHNKLHE>> AHKCMKFJKKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x50BDAC0", Offset = "0x50BCAC0", VA = "0x1850BDAC0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x50BB090", Offset = "0x50BA090", VA = "0x1850BB090", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x50BE600", Offset = "0x50BD600", VA = "0x1850BE600")]
		[HGNKAKLJIMO("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[HGNKAKLJIMO("Need to handle `Name` better.")]
		protected DELJGGMKELJ(NNMPKFHFGGO CJMKECHHMIB, TNode PENNBKHEEFF, bool EFDIDHHFHMA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x50BB380", Offset = "0x50BA380", VA = "0x1850BB380", Slot = "81")]
		protected virtual void DPGLELIALOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x50BBA80", Offset = "0x50BAA80", VA = "0x1850BBA80", Slot = "82")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50BB2D0", Offset = "0x50BA2D0", VA = "0x1850BB2D0", Slot = "9")]
		[AsyncStateMachine(typeof(DELJGGMKELJ<>.DKJCNIKODOK))]
		public void DMKECIALLCN(int MFDDCALCDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x50BC660", Offset = "0x50BB660", VA = "0x1850BC660")]
		public bool IHILKJELLHF([In] DFEHHELGJNI CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x50BD830", Offset = "0x50BC830", VA = "0x1850BD830")]
		public bool MJIBMDHJICH([In] OIFLPNNFNNI CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50B9BB0", Offset = "0x50B8BB0", VA = "0x1850B9BB0", Slot = "31")]
		public void AHDCODHIOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x50BDE30", Offset = "0x50BCE30", VA = "0x1850BDE30", Slot = "32")]
		[AsyncStateMachine(typeof(DELJGGMKELJ<>.GDPEAAJKHKI))]
		public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> OPMDKJDFMKO(DFEHHELGJNI? IFFNKCNEEAK, OIFLPNNFNNI? KLEJIABFHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "91")]
		public virtual void IDJJOOCJPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "92")]
		public virtual void FFLFNLIMCJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "93")]
		public virtual void HEKJMBEFMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1B0A980", Offset = "0x1B09980", VA = "0x181B0A980")]
		protected void NHPADBINIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x433D750", Offset = "0x433C750", VA = "0x18433D750")]
		protected void JOCNEJBAGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1F702B0", Offset = "0x1F6F2B0", VA = "0x181F702B0")]
		private void JDFKMJBCFOJ([In] OIFLPNNFNNI GOAHENPPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50BD4F0", Offset = "0x50BC4F0", VA = "0x1850BD4F0", Slot = "94")]
		public virtual Task<PBAOJGOHCMJ<ADHLEPAMMHK<HAOMCHNKLHE>, OAAMPDEOGNE>> KJHONGFLIFF(string GCMHJLFFDHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x50BC4A0", Offset = "0x50BB4A0", VA = "0x1850BC4A0", Slot = "95")]
		public virtual Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> FPKILHKLIGK(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "96")]
		public virtual void HEGDGKDGELF(ADHLEPAMMHK<HAOMCHNKLHE> GCDIELAOHNA, ADHLEPAMMHK<HAOMCHNKLHE> PGJBCOPPFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x50BD5C0", Offset = "0x50BC5C0", VA = "0x1850BD5C0", Slot = "97")]
		public virtual IEnumerable<JKLONHDKBPA> KMGNKHMEAJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x50BCF70", Offset = "0x50BBF70", VA = "0x1850BCF70", Slot = "98")]
		public PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE> JKAKCCGPGBH(string KJAHJFOGPFJ)
		{
			return default(PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x50BDCE0", Offset = "0x50BCCE0", VA = "0x1850BDCE0", Slot = "46")]
		public bool OPFICMKENCE([Out] Guid AKADKJMACIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x50BA1D0", Offset = "0x50B91D0", VA = "0x1850BA1D0")]
		public bool AKILGMKNMDN([In] Guid BCLOBLHDBMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "99")]
		public virtual void FPNJJPKFGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "100")]
		public virtual void BBFAMGMJHKF(bool EOFIMEPGMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "101")]
		public virtual LBMHKNJIGEN HKALDIALEGI([In] DNIFJEMKDHD KHFNGOHGGJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x50BDF80", Offset = "0x50BCF80", VA = "0x1850BDF80")]
		protected void PBBBHCGBFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x50BC6C0", Offset = "0x50BB6C0", VA = "0x1850BC6C0", Slot = "106")]
		protected virtual bool IMAKJLNADEJ(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "107")]
		protected virtual bool KAPLEKPFDNA(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "114")]
		protected virtual void JFCPBDBIIKL(LAEMJFPCJLA HBIOAAFHIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x50BAAB0", Offset = "0x50B9AB0", VA = "0x1850BAAB0")]
		protected void CGBIHEOHFDM(LAEMJFPCJLA ALHEIBEHGOI, Func<string> CBKBNDNLHOJ, Action<string> OOMGBGGNDNK, AGHJMOPJFPO AFBHAGBGAAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x50BD050", Offset = "0x50BC050", VA = "0x1850BD050")]
		protected void KBOIDGLCJEF(LAEMJFPCJLA ALHEIBEHGOI, Func<string> CBKBNDNLHOJ, Action<string> OOMGBGGNDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x50BE2C0", Offset = "0x50BD2C0", VA = "0x1850BE2C0", Slot = "115")]
		protected virtual void PECGHGOFACF(LAEMJFPCJLA ALHEIBEHGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x50BC3B0", Offset = "0x50BB3B0", VA = "0x1850BC3B0", Slot = "77")]
		public void EFDNCDIHBNN(LAEMJFPCJLA ALHEIBEHGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x50BB150", Offset = "0x50BA150", VA = "0x1850BB150", Slot = "78")]
		public JCHFKLKIANL DFJPIGCABCK()
		{
			return default(JCHFKLKIANL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "116")]
		public virtual bool IDGFLKEFEMC(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1238F30", Offset = "0x1237F30", VA = "0x181238F30")]
		private void DIPGJLLAEBN([In] DFEHHELGJNI PKDBIHBDKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x50BD3F0", Offset = "0x50BC3F0", VA = "0x1850BD3F0")]
		private void KHLKGONDGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x50BC8F0", Offset = "0x50BB8F0", VA = "0x1850BC8F0")]
		private void JEOLENCJMKI(int CDECGHMBGBK, BKEGAOIMPIK DGOFOLPNAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x50B9AA0", Offset = "0x50B8AA0", VA = "0x1850B9AA0")]
		private void ABPDJEEAMLP(int GCDIELAOHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x50BE400", Offset = "0x50BD400", VA = "0x1850BE400")]
		private void PJHGMAOLCHP(int GCDIELAOHNA, BKEGAOIMPIK JPEALCPAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x50BA480", Offset = "0x50B9480", VA = "0x1850BA480")]
		private void AODNNMBABCC(int OIKKJBLBBPE, int CEAIAIGMIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x50BD650", Offset = "0x50BC650", VA = "0x1850BD650")]
		private void LMMBBHNDFOB(int OIKKJBLBBPE, int CEAIAIGMIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x50BAA60", Offset = "0x50B9A60", VA = "0x1850BAA60")]
		private void CBDJIHMDHHE(int GCDIELAOHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x50B9DA0", Offset = "0x50B8DA0", VA = "0x1850B9DA0")]
		private void AJEAGHJFOKM(int CDECGHMBGBK, BKEGAOIMPIK DGOFOLPNAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x50BD370", Offset = "0x50BC370", VA = "0x1850BD370")]
		private void KFJPBMFOAMH(int GCDIELAOHNA, BKEGAOIMPIK JPEALCPAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x50BAF70", Offset = "0x50B9F70", VA = "0x1850BAF70", Slot = "117")]
		[AsyncStateMachine(typeof(DELJGGMKELJ<>.KDLKOHOIPGL))]
		public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> CGJMDANCMDO(string KJAHJFOGPFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x50BA890", Offset = "0x50B9890", VA = "0x1850BA890", Slot = "53")]
		private void BCOBKDAECDE(object EIGFNDCBCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x50BA900", Offset = "0x50B9900", VA = "0x1850BA900", Slot = "54")]
		private void BKCKEMDGKGB(object EIGFNDCBCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x50BC630", Offset = "0x50BB630", VA = "0x1850BC630", Slot = "28")]
		private bool IGPOIKLCECG([In] DFEHHELGJNI CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x50BD020", Offset = "0x50BC020", VA = "0x1850BD020", Slot = "30")]
		private bool JPAFNDELIPA([In] OIFLPNNFNNI CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x50BCFF0", Offset = "0x50BBFF0", VA = "0x1850BCFF0", Slot = "47")]
		private bool JLDIJDFEINJ([In] Guid BCLOBLHDBMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x50BA970", Offset = "0x50B9970", VA = "0x1850BA970")]
		[CompilerGenerated]
		private string BLPCFGAPIIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x50BD930", Offset = "0x50BC930", VA = "0x1850BD930")]
		[CompilerGenerated]
		private void MPLMKNNEEFM(string GCMHJLFFDHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class IEECPGEFIJM : LJJOCMMDOLN<BEFIFAMIDJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xC21880", Offset = "0xC20880", VA = "0x180C21880", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB2DB0", Offset = "0x1DB1DB0", VA = "0x181DB2DB0")]
		public IEECPGEFIJM(NNMPKFHFGGO CJMKECHHMIB, BEFIFAMIDJJ PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class DFIAIBNNJPP : MDLLAILFKNF<ALDLOELFHBF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4E80", Offset = "0x1DA3E80", VA = "0x181DA4E80")]
		public DFIAIBNNJPP(NNMPKFHFGGO CJMKECHHMIB, ALDLOELFHBF PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private sealed class ENICNKICKJH : DELJGGMKELJ<INIAALLBNHO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8D9500", Offset = "0x8D8500", VA = "0x1808D9500", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9540", Offset = "0x1DA8540", VA = "0x181DA9540")]
		public ENICNKICKJH(NNMPKFHFGGO CJMKECHHMIB, INIAALLBNHO PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class FPDJGMDJCKA : MDLLAILFKNF<ECCJJHOJBCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9650", Offset = "0x1DA8650", VA = "0x181DA9650")]
		public FPDJGMDJCKA(NNMPKFHFGGO CJMKECHHMIB, ECCJJHOJBCC PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MJODGJHADAC : MDLLAILFKNF<IKNPENEOBEL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7530", Offset = "0x1DB6530", VA = "0x181DB7530")]
		public MJODGJHADAC(NNMPKFHFGGO CJMKECHHMIB, IKNPENEOBEL PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class EDCGCIKFBCE : DELJGGMKELJ<LFPKEPIEOIH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC51FD0", Offset = "0xC50FD0", VA = "0x180C51FD0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8700", Offset = "0x1DA7700", VA = "0x181DA8700")]
		public EDCGCIKFBCE(NNMPKFHFGGO CJMKECHHMIB, LFPKEPIEOIH PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class GFNNMHNGEGH : DELJGGMKELJ<FLMGNKFBNHC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Dictionary<string, JHHJCHFLMID> GDPNOJMCMLE;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public sealed override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public sealed override bool FJLHLIDENFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected sealed override bool BIHCLFEKNKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9D40", Offset = "0x1DA8D40", VA = "0x181DA9D40")]
		public GFNNMHNGEGH(NNMPKFHFGGO CJMKECHHMIB, FLMGNKFBNHC PENNBKHEEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9AB0", Offset = "0x1DA8AB0", VA = "0x181DA9AB0", Slot = "114")]
		protected sealed override void JFCPBDBIIKL(LAEMJFPCJLA ALHEIBEHGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9A70", Offset = "0x1DA8A70", VA = "0x181DA9A70")]
		private int BCALNHEJGOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9CE0", Offset = "0x1DA8CE0", VA = "0x181DA9CE0")]
		private void MMDANGPEELJ(int PDPILKIDIPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class NAFLJJCPAGI : DELJGGMKELJ<MLBKFGJGGDK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x923C10", Offset = "0x922C10", VA = "0x180923C10", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7590", Offset = "0x1DB6590", VA = "0x181DB7590")]
		public NAFLJJCPAGI(NNMPKFHFGGO CJMKECHHMIB, MLBKFGJGGDK PENNBKHEEFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6370", Offset = "0x1DB5370", VA = "0x181DB6370")]
	internal static LIDAIMBHMPN NAJBLLJFKKI(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class PNEDAOOCLHO : PNCMMCFPNCI, PIHAMILODFC, CMGHFLFOGLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public ADHLEPAMMHK<FJPMHDEFCDN> KOLLNMMHFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDB6230", Offset = "0xDB5230", VA = "0x180DB6230", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(ADHLEPAMMHK<FJPMHDEFCDN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDB5F20", Offset = "0xDB4F20", VA = "0x180DB5F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private ADHLEPAMMHK<BDFEODHMFIL> JOMIJJHPBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD290", Offset = "0x1DBC290", VA = "0x181DBD290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public override ADHLEPAMMHK<KMFJMNHLAMA> PAGAIHAMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD250", Offset = "0x1DBC250", VA = "0x181DBD250", Slot = "19")]
		get
		{
			return default(ADHLEPAMMHK<KMFJMNHLAMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DBD5D0", Offset = "0x1DBC5D0", VA = "0x181DBD5D0")]
	private PNEDAOOCLHO(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF, DBBJGHCMKPP FBBFKDKBCHO, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<FJPMHDEFCDN> EEMDIPHNDGL, ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC, bool LBOKFIAPOGA, string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DBD2A0", Offset = "0x1DBC2A0", VA = "0x181DBD2A0")]
	public static PNEDAOOCLHO NAJBLLJFKKI(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF, DBBJGHCMKPP MMMJGLCBBNG, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC, ADHLEPAMMHK<FJPMHDEFCDN> EEMDIPHNDGL, bool LBOKFIAPOGA, bool EFDIDHHFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xDB5F20", Offset = "0xDB4F20", VA = "0x180DB5F20")]
	internal void GKHDELJOMKE(ADHLEPAMMHK<FJPMHDEFCDN> CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class PNCMMCFPNCI : CMGHFLFOGLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct MAPOCLMBGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private CLNNINGHHLD? GPDEACFOOAI;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6EB0", Offset = "0x1DB5EB0", VA = "0x181DB6EB0")]
		public void BGPDDONPEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6EC0", Offset = "0x1DB5EC0", VA = "0x181DB6EC0")]
		public CLNNINGHHLD CHHICEIBEIG(PNCMMCFPNCI PNGJPAJICNM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	protected readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly HAJMFOKCJDO LJHHEBCICMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private MAPOCLMBGOC JBGIHCABDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DCFPFFENOPD FNOJMPAMAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<EJCJNNBNLEE> FHLAEJKJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly List<OMHIECJKCLL> APKHGJODJJL;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<StaticEdge> EOKAKIMEKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC660", Offset = "0x1DBB660", VA = "0x181DBC660", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public DisplayKind JMPHHFNDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1C0", Offset = "0x7CA1C0", VA = "0x1807CB1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EEKPKFNOHLA<CDCECIICCHL> DDDDKOOIALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC420", Offset = "0x1DBB420", VA = "0x181DBC420", Slot = "6")]
		get
		{
			return default(EEKPKFNOHLA<CDCECIICCHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FIDPHGGNNBC ELLHIOHIBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x199F2A0", Offset = "0x199E2A0", VA = "0x18199F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public DKLLEKENJLB DCPDOAKDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC250", Offset = "0x1DBB250", VA = "0x181DBC250", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	protected CLNNINGHHLD NMFLABHGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC250", Offset = "0x1DBB250", VA = "0x181DBC250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PortImage JBAOJIANFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC2F0", Offset = "0x1DBB2F0", VA = "0x181DBC2F0", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1B0", Offset = "0x7BB1B0", VA = "0x1807BC1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public EEKPKFNOHLA<OBKEKPIBNBO> LCEPAFBPPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD0D0", Offset = "0x1DBC0D0", VA = "0x181DBD0D0", Slot = "8")]
		get
		{
			return default(EEKPKFNOHLA<OBKEKPIBNBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public ADHLEPAMMHK<HAOMCHNKLHE> IDEBHFKNOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85BF50", Offset = "0x85AF50", VA = "0x18085BF50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(ADHLEPAMMHK<HAOMCHNKLHE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x184C060", Offset = "0x184B060", VA = "0x18184C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public abstract ADHLEPAMMHK<KMFJMNHLAMA> PAGAIHAMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DBD0F0", Offset = "0x1DBC0F0", VA = "0x181DBD0F0")]
	protected PNCMMCFPNCI(NNMPKFHFGGO CJMKECHHMIB, HAJMFOKCJDO PENNBKHEEFF, DCFPFFENOPD KEEIILHLCMJ, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, bool LBOKFIAPOGA, string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBFB0", Offset = "0x1DBAFB0", VA = "0x181DBBFB0", Slot = "20")]
	protected virtual void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC100", Offset = "0x1DBB100", VA = "0x181DBC100", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCE60", Offset = "0x1DBBE60", VA = "0x181DBCE60", Slot = "13")]
	public void MNGKIEMLDCO(EJCJNNBNLEE DCKPMIGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBF50", Offset = "0x1DBAF50", VA = "0x181DBBF50", Slot = "14")]
	public void CPNBCELAPCE(OMHIECJKCLL DCKPMIGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC7B0", Offset = "0x1DBB7B0", VA = "0x181DBC7B0", Slot = "15")]
	public void KEIHGECFHGI(FFEEHMPDCIA LBBHGPDEDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCEC0", Offset = "0x1DBBEC0", VA = "0x181DBCEC0", Slot = "22")]
	protected virtual void NHKFCAOEMBD(FFEEHMPDCIA LBBHGPDEDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBDC0", Offset = "0x1DBADC0", VA = "0x181DBBDC0")]
	private void BKPEDGBFNIB(bool IEHPEJEDEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC4B0", Offset = "0x1DBB4B0", VA = "0x181DBC4B0")]
	private void JMOHIAMMMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCF20", Offset = "0x1DBBF20", VA = "0x181DBCF20")]
	private void ONBAIOOEDFA([In] OLJMCECIBCJ BDCCNKGKIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBD60", Offset = "0x1DBAD60", VA = "0x181DBBD60", Slot = "16")]
	public void BDAKIJENNFG(EJCJNNBNLEE DCKPMIGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC450", Offset = "0x1DBB450", VA = "0x181DBC450", Slot = "17")]
	public void JIMNBODLBAE(OMHIECJKCLL DCKPMIGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1B0", Offset = "0x7BB1B0", VA = "0x1807BC1B0")]
	internal void OEBBNLKMOPI(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCE40", Offset = "0x1DBBE40", VA = "0x181DBCE40")]
	internal void LJOAKLEFDNN(ACAIGDMPFDK DGILCEAPJEB, FIDPHGGNNBC IKHOLAJCJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x184C060", Offset = "0x184B060", VA = "0x18184C060")]
	internal void FMOPPKCGDFC(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class GGEOCCHMJFP : EDOJJPLGLKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PJHMLEGPJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public NNMPKFHFGGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HAJMFOKCJDO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ADHLEPAMMHK<HAOMCHNKLHE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PJHMLEGPJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1DBBC40", Offset = "0x1DBAC40", VA = "0x181DBBC40")]
		internal DPEBMPAHIJM JHBEBMEPPFM((int PortDescIndex, int PortIndex, FBFKJDNAODM InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1DBBCD0", Offset = "0x1DBACD0", VA = "0x181DBBCD0")]
		internal PNEDAOOCLHO LMCGHJPEOCD(DBBJGHCMKPP i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct ACHAHAEGPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0390", Offset = "0x1D9F390", VA = "0x181DA0390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1DA07F0", Offset = "0x1D9F7F0", VA = "0x181DA07F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HBEEEDOJJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ADHLEPAMMHK<HDMIFOBJNHK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB18E0", Offset = "0x1DB08E0", VA = "0x181DB18E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1C30", Offset = "0x1DB0C30", VA = "0x181DB1C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct JJDINFACBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public ADHLEPAMMHK<BDFEODHMFIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB43F0", Offset = "0x1DB33F0", VA = "0x181DB43F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4740", Offset = "0x1DB3740", VA = "0x181DB4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct JFLIAJDNMNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public ADHLEPAMMHK<HDMIFOBJNHK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public ADHLEPAMMHK<HDMIFOBJNHK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3D10", Offset = "0x1DB2D10", VA = "0x181DB3D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4060", Offset = "0x1DB3060", VA = "0x181DB4060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct LBLHPIBGJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ADHLEPAMMHK<BDFEODHMFIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public ADHLEPAMMHK<BDFEODHMFIL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4BB0", Offset = "0x1DB3BB0", VA = "0x181DB4BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4F00", Offset = "0x1DB3F00", VA = "0x181DB4F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct IKNJBOBOGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3110", Offset = "0x1DB2110", VA = "0x181DB3110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3580", Offset = "0x1DB2580", VA = "0x181DB3580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct CMKHEBLIOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4080", Offset = "0x1DA3080", VA = "0x181DA4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1DA43D0", Offset = "0x1DA33D0", VA = "0x181DA43D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GADKBBLKEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public ADHLEPAMMHK<HDMIFOBJNHK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1DA96B0", Offset = "0x1DA86B0", VA = "0x181DA96B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9A00", Offset = "0x1DA8A00", VA = "0x181DA9A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct NCKNLMNDDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public ADHLEPAMMHK<BDFEODHMFIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7610", Offset = "0x1DB6610", VA = "0x181DB7610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7960", Offset = "0x1DB6960", VA = "0x181DB7960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct NDBFIBLINAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public DJCOFFIAHBM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public ADHLEPAMMHK<HDMIFOBJNHK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB79D0", Offset = "0x1DB69D0", VA = "0x181DB79D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7D60", Offset = "0x1DB6D60", VA = "0x181DB7D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct NEACOAGNHGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GGEOCCHMJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public DJCOFFIAHBM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public ADHLEPAMMHK<BDFEODHMFIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private DICLHGGBJDJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7DD0", Offset = "0x1DB6DD0", VA = "0x181DB7DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8160", Offset = "0x1DB7160", VA = "0x181DB8160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool BPBBACFIJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly bool FOJJADEMIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OGOEANFICND<EPMBAEECFAC, DPEBMPAHIJM> LPBNIDPOIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private OGOEANFICND<EPMBAEECFAC, PIGODIIJAML> DGCNHJDHPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly HAJMFOKCJDO LJHHEBCICMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private OGOEANFICND<FJPMHDEFCDN, PNEDAOOCLHO> LFHNIDKMPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private OGOEANFICND<FJPMHDEFCDN, PIHAMILODFC> EFLNEAKJBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private string? FFNLJBFKPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly BKEGAOIMPIK OCOELMDIKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private ADHLEPAMMHK<HAOMCHNKLHE> BAMMHPFDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly bool NKFGBONNHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[CompilerGenerated]
	private Action? OOIJHANGLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[CompilerGenerated]
	private Action? NPMIFNDDHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[CompilerGenerated]
	private Action<ADHLEPAMMHK<EPMBAEECFAC>>? LNAGNKGDAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[CompilerGenerated]
	private Action<ADHLEPAMMHK<FJPMHDEFCDN>>? GKFCIEPPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[CompilerGenerated]
	private EDOJJPLGLKD.AAEOELFIDOO? FDBJNMCCKMA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool NEJLJLJDELK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD680", Offset = "0x1DAC680", VA = "0x181DAD680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool EMBKABPLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0090", Offset = "0x1DAF090", VA = "0x181DB0090", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool ABFAHKLINBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA4D0", Offset = "0x1DA94D0", VA = "0x181DAA4D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public EEKPKFNOHLA<CDCECIICCHL> DDDDKOOIALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DACC40", Offset = "0x1DABC40", VA = "0x181DACC40", Slot = "7")]
		get
		{
			return default(EEKPKFNOHLA<CDCECIICCHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool GIBENCOEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DAACF0", Offset = "0x1DA9CF0", VA = "0x181DAACF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public OGOEANFICND<EPMBAEECFAC, PIGODIIJAML> KLIKLEAGNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "9")]
		get
		{
			return default(OGOEANFICND<EPMBAEECFAC, PIGODIIJAML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA650", Offset = "0x1DA9650", VA = "0x181DAA650", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public EEKPKFNOHLA<OBKEKPIBNBO> LCEPAFBPPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0120", Offset = "0x1DAF120", VA = "0x181DB0120", Slot = "11")]
		get
		{
			return default(EEKPKFNOHLA<OBKEKPIBNBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public OGOEANFICND<FJPMHDEFCDN, PIHAMILODFC> DGFAKBDHFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "12")]
		get
		{
			return default(OGOEANFICND<FJPMHDEFCDN, PIHAMILODFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public ADHLEPAMMHK<HAOMCHNKLHE> IDEBHFKNOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA2EDB0", Offset = "0xA2DDB0", VA = "0x180A2EDB0", Slot = "13")]
		get
		{
			return default(ADHLEPAMMHK<HAOMCHNKLHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action AOICCLJPGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE610", Offset = "0x1DAD610", VA = "0x181DAE610", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE6B0", Offset = "0x1DAD6B0", VA = "0x181DAE6B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action CHMPPMGPLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA420", Offset = "0x1DA9420", VA = "0x181DAA420", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DADDB0", Offset = "0x1DACDB0", VA = "0x181DADDB0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<ADHLEPAMMHK<EPMBAEECFAC>, ADHLEPAMMHK<EPMBAEECFAC>> PMJOKHMAANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE200", Offset = "0x1DAD200", VA = "0x181DAE200", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFEB0", Offset = "0x1DAEEB0", VA = "0x181DAFEB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<ADHLEPAMMHK<EPMBAEECFAC>, ADHLEPAMMHK<EPMBAEECFAC>> GEOHAFIOECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF650", Offset = "0x1DAE650", VA = "0x181DAF650", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE030", Offset = "0x1DAD030", VA = "0x181DAE030", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<ADHLEPAMMHK<FJPMHDEFCDN>, ADHLEPAMMHK<FJPMHDEFCDN>> JPMFPPCNBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DACC70", Offset = "0x1DABC70", VA = "0x181DACC70", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA360", Offset = "0x1DA9360", VA = "0x181DAA360", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<ADHLEPAMMHK<FJPMHDEFCDN>, ADHLEPAMMHK<FJPMHDEFCDN>> KLJMPOFOLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD8F0", Offset = "0x1DAC8F0", VA = "0x181DAD8F0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFFD0", Offset = "0x1DAEFD0", VA = "0x181DAFFD0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ADHLEPAMMHK<EPMBAEECFAC>, PIGODIIJAML> MIBBECOMEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD5C0", Offset = "0x1DAC5C0", VA = "0x181DAD5C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DADCF0", Offset = "0x1DACCF0", VA = "0x181DADCF0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ADHLEPAMMHK<EPMBAEECFAC>> BKJGPDPPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1DADC30", Offset = "0x1DACC30", VA = "0x181DADC30", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DADE60", Offset = "0x1DACE60", VA = "0x181DADE60", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ADHLEPAMMHK<EPMBAEECFAC>, PIGODIIJAML> LKEKEJGHDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA590", Offset = "0x1DA9590", VA = "0x181DAA590", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DACB30", Offset = "0x1DABB30", VA = "0x181DACB30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<ADHLEPAMMHK<FJPMHDEFCDN>, PIHAMILODFC> CCFNDPPEDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DACA70", Offset = "0x1DABA70", VA = "0x181DACA70", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE550", Offset = "0x1DAD550", VA = "0x181DAE550", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<ADHLEPAMMHK<FJPMHDEFCDN>> LOBHPLIBNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD740", Offset = "0x1DAC740", VA = "0x181DAD740", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE360", Offset = "0x1DAD360", VA = "0x181DAE360", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<ADHLEPAMMHK<FJPMHDEFCDN>, PIHAMILODFC> FDMOEHEMJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA2A0", Offset = "0x1DA92A0", VA = "0x181DAA2A0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEDB0", Offset = "0x1DADDB0", VA = "0x181DAEDB0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0140", Offset = "0x1DAF140", VA = "0x181DB0140")]
	private GGEOCCHMJFP(bool LBOKFIAPOGA, NNMPKFHFGGO CJMKECHHMIB, bool JDFHLIPMKCN, OGOEANFICND<EPMBAEECFAC, DPEBMPAHIJM> LKOHEIMNPAA, OGOEANFICND<EPMBAEECFAC, PIGODIIJAML> BNAKOEAHPII, HAJMFOKCJDO PENNBKHEEFF, OGOEANFICND<FJPMHDEFCDN, PNEDAOOCLHO> APEGEIBEGIF, OGOEANFICND<FJPMHDEFCDN, PIHAMILODFC> CBMIABCMJPD, string? ALEHCLKPDGG, BKEGAOIMPIK DGOFOLPNAJC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, bool EFDIDHHFHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE840", Offset = "0x1DAD840", VA = "0x181DAE840")]
	public static GGEOCCHMJFP NAJBLLJFKKI(bool LBOKFIAPOGA, NNMPKFHFGGO CJMKECHHMIB, bool JDFHLIPMKCN, HAJMFOKCJDO PENNBKHEEFF, BKEGAOIMPIK DGOFOLPNAJC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, bool EFDIDHHFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB340", Offset = "0x1DAA340", VA = "0x181DAB340")]
	private void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1DABAF0", Offset = "0x1DAAAF0", VA = "0x181DABAF0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE750", Offset = "0x1DAD750", VA = "0x181DAE750", Slot = "38")]
	[AsyncStateMachine(typeof(ACHAHAEGPAM))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> LKOHIPHODOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB110", Offset = "0x1DAA110", VA = "0x181DAB110")]
	private (JMNEKKLAAJF, int)? DMIOGCPJMPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD800", Offset = "0x1DAC800", VA = "0x181DAD800")]
	private void HHMPHEAFAPF(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x125BFC0", Offset = "0x125AFC0", VA = "0x18125BFC0")]
	private void LNPEOEEFAEH(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD100", Offset = "0x1DAC100", VA = "0x181DAD100")]
	private void FNGCCNMJHOP(int HABPIHLFEOM, int FMMMJJIDDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1DAFF70", Offset = "0x1DAEF70", VA = "0x181DAFF70")]
	private void PDBACEGOKCI(int HABPIHLFEOM, int FMMMJJIDDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF0B0", Offset = "0x1DAE0B0", VA = "0x181DAF0B0")]
	private void NGGBEPIKGGI(int LKJFCEBECIA, int DECMOANLFLJ, FBFKJDNAODM GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x1DB00D0", Offset = "0x1DAF0D0", VA = "0x181DB00D0")]
	private void PKHCPEBMOKN(int IEHPEJEDEKI, int DECMOANLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE2C0", Offset = "0x1DAD2C0", VA = "0x181DAE2C0")]
	private void KHMBCELBCMI(int IEHPEJEDEKI, int DECMOANLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA7A0", Offset = "0x1DA97A0", VA = "0x181DAA7A0")]
	private void CKHNMAGDIBB(int LKJFCEBECIA, int DECMOANLFLJ, FBFKJDNAODM GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD9B0", Offset = "0x1DAC9B0", VA = "0x181DAD9B0")]
	private void HLLNEMJGFBC(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9605C0", Offset = "0x95F5C0", VA = "0x1809605C0")]
	private void OEKNOKFMJHB(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAEE70", Offset = "0x1DADE70", VA = "0x181DAEE70")]
	private void NEKJOOFJJHE(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x125BFC0", Offset = "0x125AFC0", VA = "0x18125BFC0")]
	private void MHCDMGMNHON(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAD70", Offset = "0x1DA9D70", VA = "0x181DAAD70")]
	private void DHKAOIAAHLC(int HABPIHLFEOM, int FMMMJJIDDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF5F0", Offset = "0x1DAE5F0", VA = "0x181DAF5F0")]
	private void NKKEDKBGAKM(int HABPIHLFEOM, int FMMMJJIDDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF960", Offset = "0x1DAE960", VA = "0x181DAF960")]
	private void OJGKNCLFDLO(int LKJFCEBECIA, int DECMOANLFLJ, DBBJGHCMKPP GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE310", Offset = "0x1DAD310", VA = "0x181DAE310")]
	private void KLIOKACPAMF(int IEHPEJEDEKI, int DECMOANLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x1DACBF0", Offset = "0x1DABBF0", VA = "0x181DACBF0")]
	private void EJOEPLKPBEN(int IEHPEJEDEKI, int DECMOANLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC5F0", Offset = "0x1DAB5F0", VA = "0x181DAC5F0")]
	private void EBLMBOMLFJN(int LKJFCEBECIA, int DECMOANLFLJ, DBBJGHCMKPP GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1DAEF60", Offset = "0x1DADF60", VA = "0x181DAEF60")]
	private void NELNEEGDGOK(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9605C0", Offset = "0x95F5C0", VA = "0x1809605C0")]
	private void NBFPEKGDINH(int LKJFCEBECIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE0F0", Offset = "0x1DAD0F0", VA = "0x181DAE0F0", Slot = "39")]
	[AsyncStateMachine(typeof(HBEEEDOJJLB))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> KGIKCEJFCDA(ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x1DADF20", Offset = "0x1DACF20", VA = "0x181DADF20", Slot = "40")]
	[AsyncStateMachine(typeof(JJDINFACBKC))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> JMCIHHKMKBP(ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD4A0", Offset = "0x1DAC4A0", VA = "0x181DAD4A0", Slot = "41")]
	[AsyncStateMachine(typeof(JFLIAJDNMNE))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> FODGJIEADGM(ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC, ADHLEPAMMHK<HDMIFOBJNHK> CEAIAIGMIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA680", Offset = "0x1DA9680", VA = "0x181DAA680", Slot = "42")]
	[AsyncStateMachine(typeof(LBLHPIBGJJB))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> CGCGMODGBKM(ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC, ADHLEPAMMHK<BDFEODHMFIL> CEAIAIGMIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAC00", Offset = "0x1DA9C00", VA = "0x181DAAC00", Slot = "43")]
	[AsyncStateMachine(typeof(IKNJBOBOGJC))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> CMKCHLCCNMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF710", Offset = "0x1DAE710", VA = "0x181DAF710", Slot = "44")]
	[AsyncStateMachine(typeof(CMKHEBLIOBC))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> OGNECPNCFAJ(string KJAHJFOGPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF830", Offset = "0x1DAE830", VA = "0x181DAF830", Slot = "45")]
	[AsyncStateMachine(typeof(GADKBBLKEEL))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> OHCMKONPNMB(ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC, string GCMHJLFFDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA170", Offset = "0x1DA9170", VA = "0x181DAA170", Slot = "46")]
	[AsyncStateMachine(typeof(NCKNLMNDDCK))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> ADFLJHCLMEE(ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC, string GCMHJLFFDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE420", Offset = "0x1DAD420", VA = "0x181DAE420", Slot = "47")]
	[AsyncStateMachine(typeof(NDBFIBLINAL))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> LDHKFECHCFJ(ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC, DJCOFFIAHBM IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1DADB00", Offset = "0x1DACB00", VA = "0x181DADB00", Slot = "48")]
	[AsyncStateMachine(typeof(NEACOAGNHGB))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> IHDJOHBPCDJ(ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC, DJCOFFIAHBM IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1DACD30", Offset = "0x1DABD30", VA = "0x181DACD30")]
	internal void FMOPPKCGDFC(ADHLEPAMMHK<HAOMCHNKLHE> CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class CNOGHEAKGCF : BPPAGNNDHAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface KEBCJPFIPKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		ACAIGDMPFDK APBBCINGMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JCBHMFNFIKJ> OKGEFNPNPFB(CancellationToken JMJKFNJJBHM);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PJNIIGNHFFM> NALKPGLCJGP(CancellationToken JMJKFNJJBHM);

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CMMCDCKCCKK> INLPOFECCOB(CancellationToken JMJKFNJJBHM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct EKCFHDHPPHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder<CNOGHEAKGCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NNMPKFHFGGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public JCBHMFNFIKJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public PJNIIGNHFFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private KEBCJPFIPKM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private PJNIIGNHFFM <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter<JCBHMFNFIKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter<PJNIIGNHFFM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private TaskAwaiter<CMMCDCKCCKK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter<GLKLKFEHMAM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8AF0", Offset = "0x1DA7AF0", VA = "0x181DA8AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1DA94D0", Offset = "0x1DA84D0", VA = "0x181DA94D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly GLKLKFEHMAM GJOMDJBGEDG;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public GLKLKFEHMAM ODGBINPDMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	private CNOGHEAKGCF(GLKLKFEHMAM CDIONDBMLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4440", Offset = "0x1DA3440", VA = "0x181DA4440")]
	[AsyncStateMachine(typeof(EKCFHDHPPHF))]
	public static Task<CNOGHEAKGCF> CENPFJOHMJL(NNMPKFHFGGO CJMKECHHMIB, JCBHMFNFIKJ? PCNPJGFONNP, PJNIIGNHFFM? EMCNNGKGOCG, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1DA45A0", Offset = "0x1DA35A0", VA = "0x181DA45A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct EJPBCLLBNCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MAOAFNDIBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public EJPBCLLBNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public JKLONHDKBPA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6BB0", Offset = "0x1DB5BB0", VA = "0x181DB6BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6E40", Offset = "0x1DB5E40", VA = "0x181DB6E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IADIGFGDGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<bool, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PAILNLJOFGB rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public JCBHMFNFIKJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PJNIIGNHFFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public EJPBCLLBNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private JKLONHDKBPA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB2580", Offset = "0x1DB1580", VA = "0x181DB2580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB2960", Offset = "0x1DB1960", VA = "0x181DB2960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct ACDLMAKFCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public EJPBCLLBNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0040", Offset = "0x1D9F040", VA = "0x181DA0040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0320", Offset = "0x1D9F320", VA = "0x181DA0320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly BKLDCBGANEP FCNLCLDHBFC;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	public EJPBCLLBNCF(BKLDCBGANEP JJJFBBKJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1DA89C0", Offset = "0x1DA79C0", VA = "0x181DA89C0")]
	[AsyncStateMachine(typeof(MAOAFNDIBDE))]
	private Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> NCKGDCAGBPC(JKLONHDKBPA DFHNKDINOMO, bool BCMNHKGIIHL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8770", Offset = "0x1DA7770", VA = "0x181DA8770")]
	[AsyncStateMachine(typeof(IADIGFGDGAM))]
	public Task<PBAOJGOHCMJ<bool, OAAMPDEOGNE?>>? BHNGDFPKKIC(int MOKKKPAADAJ, PAILNLJOFGB? KBFDAOPBMDF, JCBHMFNFIKJ? KDONCADGILP, PJNIIGNHFFM? EMCNNGKGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA88D0", Offset = "0x1DA78D0", VA = "0x181DA88D0")]
	[AsyncStateMachine(typeof(ACDLMAKFCNL))]
	public Task<PBAOJGOHCMJ<EMBFKEMHPML, OAAMPDEOGNE>> CCMBCIBACJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class CFJINFLACAD : PHNDHGHMPCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly HINPIJANFLG INHCJMAHPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public HINPIJANFLG HAJOCINLAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	private CFJINFLACAD(HINPIJANFLG GGHICMBGMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1AE0", Offset = "0x1DA0AE0", VA = "0x181DA1AE0")]
	public static CFJINFLACAD MPIEPNPHGIA(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1AC0", Offset = "0x1DA0AC0", VA = "0x181DA1AC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface OIPJDEBGDNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	FFBCFPBOAEB COKGPBAGIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CKLPICJAOHL BCPHHHFFBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	GLODOHNFDBI PDNFANJCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	EAEHJBNBDAG DAJFAJHDPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	CLLMGOOGNOC GKIOJHLHODM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface PLMNHCLKIPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	OIPJDEBGDNN? MBFLCDMBNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool BIMNOMKIGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OIPJDEBGDNN?>? ELPNLCDKLDP();

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AMHJNLCPNLP(NNMPKFHFGGO CJMKECHHMIB, PAILNLJOFGB NEMNKIDNFGA, JCBHMFNFIKJ? BOLADIAHKBD, PJNIIGNHFFM? CCNIJPPJLIM);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[GMPCNOECIMH("IStaticCV2Instance")]
public interface BPPAGNNDHAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	GLKLKFEHMAM ODGBINPDMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[GMPCNOECIMH("IStaticEVInstance")]
public interface PHNDHGHMPCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	HINPIJANFLG HAJOCINLAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class NKBAKDFHEBN : AKNIOCOIMII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public APDOGHOBKGK? GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1DB87F0", Offset = "0x1DB77F0", VA = "0x181DB87F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	internal NKBAKDFHEBN(NNMPKFHFGGO CJMKECHHMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public sealed class EAEHJBNBDAG : APDOGHOBKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly BPPAGNNDHAH NEPDBOOIJJB;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GAPGOAHLNKL NCKGDCAGBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8590", Offset = "0x1DA7590", VA = "0x181DA8590", Slot = "4")]
		get
		{
			return default(GAPGOAHLNKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public NMFMLPOCBFG KJMGEFMEPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x1DA85F0", Offset = "0x1DA75F0", VA = "0x181DA85F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public EEKPKFNOHLA<CDCECIICCHL> OAALIAOPINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1DA86A0", Offset = "0x1DA76A0", VA = "0x181DA86A0", Slot = "6")]
		get
		{
			return default(EEKPKFNOHLA<CDCECIICCHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GLKLKFEHMAM CJJLELLMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8650", Offset = "0x1DA7650", VA = "0x181DA8650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public EAEHJBNBDAG(BPPAGNNDHAH LIDBDPEDMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8520", Offset = "0x1DA7520", VA = "0x181DA8520")]
	public bool OGGFPLAKHLL([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8520", Offset = "0x1DA7520", VA = "0x181DA8520", Slot = "8")]
	private bool FNCLIKKEIMJ([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class BIJFBBAPOPP
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0B90", Offset = "0x1D9FB90", VA = "0x181DA0B90")]
	public static DNEFDDHLONC<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> NPKCBELECKD([In] this DNEFDDHLONC<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>> KGIDHPKHLJI)
	{
		return default(DNEFDDHLONC<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO, GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public sealed class BIGOHDACDLJ : KFPINHANOMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BIMNOMKIGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0B70", Offset = "0x1D9FB70", VA = "0x181DA0B70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	internal BIGOHDACDLJ(NNMPKFHFGGO CJMKECHHMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class LDLKICFPIOK : ALPFFACEIOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct JIBFLBBGFPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder<FLIFMFMKKIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public LDLKICFPIOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<OIPJDEBGDNN?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1DB40D0", Offset = "0x1DB30D0", VA = "0x181DB40D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4380", Offset = "0x1DB3380", VA = "0x181DB4380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private IReadOnlyList<EEKPKFNOHLA<GBEDNKELGKE>>? BBMKEMNDNMH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public FLIFMFMKKIF? GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB57D0", Offset = "0x1DB47D0", VA = "0x181DB57D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CLLMGOOGNOC? DJPHOFGCEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5010", Offset = "0x1DB4010", VA = "0x181DB5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool ODFIENLHCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5BC0", Offset = "0x1DB4BC0", VA = "0x181DB5BC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IGNJAGPLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4F70", Offset = "0x1DB3F70", VA = "0x181DB4F70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	internal LDLKICFPIOK(NNMPKFHFGGO CJMKECHHMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5290", Offset = "0x1DB4290", VA = "0x181DB5290", Slot = "7")]
	[AsyncStateMachine(typeof(JIBFLBBGFPI))]
	public Task<FLIFMFMKKIF> KOIBCGLMGEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5850", Offset = "0x1DB4850", VA = "0x181DB5850")]
	internal Dictionary<EEKPKFNOHLA<CDCECIICCHL>, Guid> POAEMGDICKF(IEnumerable<CLAFHIEHHKM> CAFKAOBMCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5380", Offset = "0x1DB4380", VA = "0x181DB5380")]
	public PBAOJGOHCMJ<MNACMLOIGGK, BOFJPOKAPAE> NAIFLAFNIID([In] MNACMLOIGGK KIANMPGJGFP, IEnumerable<CLAFHIEHHKM> IIOJFICIFCF, int OANOGFJGHPA)
	{
		return default(PBAOJGOHCMJ<MNACMLOIGGK, BOFJPOKAPAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4FD0", Offset = "0x1DB3FD0", VA = "0x181DB4FD0")]
	internal static JCHFKLKIANL FAJFIDIDMBL(KOBLCODIHJO KOBOEPEFOLG, HAJMFOKCJDO PENNBKHEEFF)
	{
		return default(JCHFKLKIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5090", Offset = "0x1DB4090", VA = "0x181DB5090", Slot = "8")]
	private PBAOJGOHCMJ<MNACMLOIGGK, BOFJPOKAPAE> FHBEHMBIJJG([In] MNACMLOIGGK KIANMPGJGFP, IEnumerable<CLAFHIEHHKM> IIOJFICIFCF, int OANOGFJGHPA)
	{
		return default(PBAOJGOHCMJ<MNACMLOIGGK, BOFJPOKAPAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5580", Offset = "0x1DB4580", VA = "0x181DB5580")]
	[CompilerGenerated]
	internal static JCHFKLKIANL ODFJKKJEJED(KOBLCODIHJO GPHELFHIOOO, HAJMFOKCJDO DJLIBHAMMCI)
	{
		return default(JCHFKLKIANL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public sealed class CLLMGOOGNOC : FLIFMFMKKIF
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal static class JCOEKCMHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class MLHLCOMDDJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public GLKLKFEHMAM state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public INIKEGJGPBO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public MLHLCOMDDJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2FC0", Offset = "0x1DC1FC0", VA = "0x181DC2FC0")]
			internal bool JKNPGHIPCGD(MNKOPNDPIBD n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class LGLOBFLDOOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public LGLOBFLDOOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2F40", Offset = "0x1DC1F40", VA = "0x181DC2F40")]
			internal void DFOKMJMIAGO(MNKOPNDPIBD n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2400", Offset = "0x1DC1400", VA = "0x181DC2400")]
		public static PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE> OIOCKJJDGEP(CLLMGOOGNOC AOFEPADBPDL, [In] FLIFMFMKKIF.JFINODLABMI AFBHAGBGAAM)
		{
			return default(PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1220", Offset = "0x1DC0220", VA = "0x181DC1220")]
		internal static PBAOJGOHCMJ<(GHJNJECEHGI, JBBMEKAMICD), OAAMPDEOGNE> LMFOGACNELP(CLLMGOOGNOC AOFEPADBPDL, JBBMEKAMICD MABMMLCLKEJ, bool DECGJHMBIGM, [In] EEKPKFNOHLA<CDCECIICCHL> HLCCJLLFMLI, [In] int? JMMBJLDCFOD, [In] JCHFKLKIANL? BBLDMDJENHI, [In] JCHFKLKIANL? OFALNICDFHL)
		{
			return default(PBAOJGOHCMJ<(GHJNJECEHGI, JBBMEKAMICD), OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1F70", Offset = "0x1DC0F70", VA = "0x181DC1F70")]
		private static void NDJPFOEMACJ(bool DECGJHMBIGM, CLAFHIEHHKM KHIBNGNBOAK, GHJNJECEHGI OLNMFIJMGOK, [In] EEKPKFNOHLA<CDCECIICCHL> HLCCJLLFMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2940", Offset = "0x1DC1940", VA = "0x181DC2940")]
		public static void OPNDNKIBKAI(EBGHCBCBGDO BNDIKCPICDI, [In] FLIFMFMKKIF.GFJGEGHIFHI IDFJHMMJGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1130", Offset = "0x1DC0130", VA = "0x181DC1130")]
		[CompilerGenerated]
		internal static bool LJEBOOIGBDH(GLKLKFEHMAM FMFIEHFLIMM, INIKEGJGPBO KFPNHBCIDDJ, MNKOPNDPIBD CAHOEKCNKEE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly NNMPKFHFGGO LDBDKKHEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly BPPAGNNDHAH NEPDBOOIJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private readonly PHNDHGHMPCN ACPLDMIPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly BNBCPKCCCKH HNPLFOECANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly LDLKICFPIOK PBHHBMNKBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<EEKPKFNOHLA<OBKEKPIBNBO>, LIDAIMBHMPN> IMJLDHAKGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	[CompilerGenerated]
	private Action<EEKPKFNOHLA<OBKEKPIBNBO>>? CIDLMBAJPOG;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3D00", Offset = "0x1DA2D00", VA = "0x181DA3D00")]
	public CLLMGOOGNOC(NNMPKFHFGGO CJMKECHHMIB, BPPAGNNDHAH LIDBDPEDMLE, PHNDHGHMPCN GDGIOABJOFG, LDLKICFPIOK PIOHADOBGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1D80", Offset = "0x1DA0D80", VA = "0x181DA1D80")]
	public LIDAIMBHMPN? BDGIDJGBFDN([In] EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1FF0", Offset = "0x1DA0FF0", VA = "0x181DA1FF0")]
	private void DLFAPOBAKKN(EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3A60", Offset = "0x1DA2A60", VA = "0x181DA3A60")]
	private LIDAIMBHMPN? NGMAOIEGCIO([In] EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2E80", Offset = "0x1DA1E80", VA = "0x181DA2E80")]
	public HAJMFOKCJDO? IDFMCBINDDO([In] EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2070", Offset = "0x1DA1070", VA = "0x181DA2070")]
	public GJGPEGFGDNF? HOEOILJAMDA([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2300", Offset = "0x1DA1300", VA = "0x181DA2300")]
	private INIKEGJGPBO? FJNOJGMDBHL([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1DA34D0", Offset = "0x1DA24D0", VA = "0x181DA34D0")]
	private GJGPEGFGDNF? JOEBFBNDAOD([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2F10", Offset = "0x1DA1F10", VA = "0x181DA2F10", Slot = "6")]
	public IEnumerable<DJCOFFIAHBM> IGDIGGHFIBK(bool GAMDHFCNEHK, bool APJALMHDEAA, bool LLLCAJMPCLP, bool NEABANDKIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1DA21A0", Offset = "0x1DA11A0", VA = "0x181DA21A0")]
	public PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE> NBKKEEJGCOI([In] FLIFMFMKKIF.JFINODLABMI AFBHAGBGAAM)
	{
		return default(PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1DA30E0", Offset = "0x1DA20E0", VA = "0x181DA30E0", Slot = "8")]
	public PBAOJGOHCMJ<IOPBKNNKFFG, BOFJPOKAPAE> JECNIICLLMC(EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD, IOPBKNNKFFG PNALBINEGNG, OIFLPNNFNNI LAFFOJOFMCF)
	{
		return default(PBAOJGOHCMJ<IOPBKNNKFFG, BOFJPOKAPAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3B10", Offset = "0x1DA2B10", VA = "0x181DA3B10", Slot = "9")]
	public LKIMFBLNODM NHMAOIKIOIG(IEnumerable<CLAFHIEHHKM> IIOJFICIFCF)
	{
		return default(LKIMFBLNODM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2080", Offset = "0x1DA1080", VA = "0x181DA2080", Slot = "10")]
	public LKIMFBLNODM ECKPHFEECFP()
	{
		return default(LKIMFBLNODM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2990", Offset = "0x1DA1990", VA = "0x181DA2990")]
	private MNJJAICAEII HLPNCCDOEDJ(FCONECPBLHA ABJGEDOLCOH, ADHLEPAMMHK<CDCECIICCHL> MMIHMIDJIAO, IEnumerable<EEKPKFNOHLA<CDCECIICCHL>> DDKDBJLPOOC, IEnumerable<EEKPKFNOHLA<OBKEKPIBNBO>> PCJIBLJLIKC)
	{
		return default(MNJJAICAEII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2B40", Offset = "0x1DA1B40", VA = "0x181DA2B40", Slot = "11")]
	public MNJJAICAEII HLPNCCDOEDJ(FCONECPBLHA ABJGEDOLCOH, ADHLEPAMMHK<CDCECIICCHL> MMIHMIDJIAO, IEnumerable<EEKPKFNOHLA<OBKEKPIBNBO>> PCJIBLJLIKC, IEnumerable<CLAFHIEHHKM> IIOJFICIFCF)
	{
		return default(MNJJAICAEII);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA36E0", Offset = "0x1DA26E0", VA = "0x181DA36E0")]
	private static IEnumerable<EEKPKFNOHLA<CDCECIICCHL>> LCKHJGCNEIA(IEnumerable<CLAFHIEHHKM> IIOJFICIFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA24F0", Offset = "0x1DA14F0", VA = "0x181DA24F0")]
	private IEnumerable<EEKPKFNOHLA<OBKEKPIBNBO>> HLFJHGOLPGJ(IEnumerable<CLAFHIEHHKM> IIOJFICIFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1EF0", Offset = "0x1DA0EF0", VA = "0x181DA1EF0", Slot = "12")]
	public List<AMDHKFHLLDE> CMMFFFNOEPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA21D0", Offset = "0x1DA11D0", VA = "0x181DA21D0", Slot = "13")]
	public bool EMBNDNIFFHD(ADHLEPAMMHK<CDCECIICCHL> BCLOBLHDBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3080", Offset = "0x1DA2080", VA = "0x181DA3080")]
	internal void JBGKNDLDPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA22A0", Offset = "0x1DA12A0", VA = "0x181DA22A0")]
	internal Task FDJPLNEAMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2070", Offset = "0x1DA1070", VA = "0x181DA2070", Slot = "4")]
	private GJGPEGFGDNF EBCCFIMDMBJ([In] EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1DA23A0", Offset = "0x1DA13A0", VA = "0x181DA23A0", Slot = "5")]
	private LIDAIMBHMPN HGKODMIMLCE([In] EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1DA21A0", Offset = "0x1DA11A0", VA = "0x181DA21A0", Slot = "7")]
	private PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE> EGBIGHCGFCL([In] FLIFMFMKKIF.JFINODLABMI AFBHAGBGAAM)
	{
		return default(PBAOJGOHCMJ<FLIFMFMKKIF.OKGHAHCHCDM, BOFJPOKAPAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3000", Offset = "0x1DA2000", VA = "0x181DA3000")]
	[CompilerGenerated]
	private IPJHOKGIPNH INPLOLCDGPM(FIDPHGGNNBC BFOKHFCOJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1F80", Offset = "0x1DA0F80", VA = "0x181DA1F80")]
	[CompilerGenerated]
	private HAJMFOKCJDO COHEDGHJMBP(EEKPKFNOHLA<OBKEKPIBNBO> BFOKHFCOJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1D10", Offset = "0x1DA0D10", VA = "0x181DA1D10")]
	[CompilerGenerated]
	private INIKEGJGPBO AAMFEPEFKNO(EEKPKFNOHLA<CDCECIICCHL> BFOKHFCOJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class IPJHOKGIPNH : DJCOFFIAHBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct OINGIMGPDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<ADHLEPAMMHK<HDMIFOBJNHK>, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public IPJHOKGIPNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public EEKPKFNOHLA<CDCECIICCHL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public EEKPKFNOHLA<OBKEKPIBNBO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ADHLEPAMMHK<HAOMCHNKLHE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<PBAOJGOHCMJ<ADHLEPAMMHK<HDMIFOBJNHK>, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3A80", Offset = "0x1DC2A80", VA = "0x181DC3A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3D00", Offset = "0x1DC2D00", VA = "0x181DC3D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct ODDHLPGLAJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<ADHLEPAMMHK<BDFEODHMFIL>, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public IPJHOKGIPNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public EEKPKFNOHLA<CDCECIICCHL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public EEKPKFNOHLA<OBKEKPIBNBO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public ADHLEPAMMHK<HAOMCHNKLHE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter<PBAOJGOHCMJ<ADHLEPAMMHK<BDFEODHMFIL>, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1DC33A0", Offset = "0x1DC23A0", VA = "0x181DC33A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3620", Offset = "0x1DC2620", VA = "0x181DC3620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly FIDPHGGNNBC CCLKOPBPCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly BPPAGNNDHAH NEPDBOOIJJB;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TypeKey GKELNKHBPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string LDMOBLPPJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF610", Offset = "0x1DBE610", VA = "0x181DBF610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FIDPHGGNNBC LOFOLMKNAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1090", Offset = "0x1DC0090", VA = "0x181DC1090")]
	public IPJHOKGIPNH(FIDPHGGNNBC LBDAPMBKLLH, BPPAGNNDHAH LIDBDPEDMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0DB0", Offset = "0x1DBFDB0", VA = "0x181DC0DB0", Slot = "6")]
	[AsyncStateMachine(typeof(OINGIMGPDOE))]
	public Task<PBAOJGOHCMJ<ADHLEPAMMHK<HDMIFOBJNHK>, OAAMPDEOGNE>> BLLIGBBDLFB(EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD, EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, string GCMHJLFFDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0F20", Offset = "0x1DBFF20", VA = "0x181DC0F20", Slot = "7")]
	[AsyncStateMachine(typeof(ODDHLPGLAJG))]
	public Task<PBAOJGOHCMJ<ADHLEPAMMHK<BDFEODHMFIL>, OAAMPDEOGNE>> MICCGOPILHE(EEKPKFNOHLA<CDCECIICCHL> BCLOBLHDBMD, EEKPKFNOHLA<OBKEKPIBNBO> GIGGNCPPKPC, ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG, string GCMHJLFFDHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class CLNNINGHHLD : DKLLEKENJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly FIDPHGGNNBC MGOJFBHMJOF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly HashSet<FIDPHGGNNBC> OKACFJPCEFP;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly HashSet<FIDPHGGNNBC> NFNGCOAHHDM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly HashSet<FIDPHGGNNBC> LHIEOBEMBIA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public TypeKey KHCGDDAFALB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC06D0", Offset = "0x1DBF6D0", VA = "0x181DC06D0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool HMFJNHLBLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DC06C0", Offset = "0x1DBF6C0", VA = "0x181DC06C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OEKAIGHHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0720", Offset = "0x1DBF720", VA = "0x181DC0720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool GEAFBLDAKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0640", Offset = "0x1DBF640", VA = "0x181DC0640", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF210", Offset = "0x1DBE210", VA = "0x181DBF210")]
	public bool DJJPBKFGGEM(string CFJDHAGGAJO, [Out] JOHNMEANDND INLLNPHCKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public CLNNINGHHLD(FIDPHGGNNBC GINEIDDJABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF480", Offset = "0x1DBE480", VA = "0x181DBF480")]
	internal static TypeKey GKMPKIOKOCD(FIDPHGGNNBC IKHOLAJCJOG)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF610", Offset = "0x1DBE610", VA = "0x181DBF610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct DNIGMNOIPGB : MNHPADLFMBH.NFNGKBOCLKH<JKLONHDKBPA, EMBFKEMHPML>
{
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C20", Offset = "0x1DBFC20", VA = "0x181DC0C20", Slot = "4")]
	public int KPJALKOACKL(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0B60", Offset = "0x1DBFB60", VA = "0x181DC0B60", Slot = "5")]
	public JKLONHDKBPA FKKLCECNADG(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0BB0", Offset = "0x1DBFBB0", VA = "0x181DC0BB0", Slot = "6")]
	public JKLONHDKBPA IMEEIOFGHJM(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0BE0", Offset = "0x1DBFBE0", VA = "0x181DC0BE0", Slot = "7")]
	public IReadOnlyList<JKLONHDKBPA> IPCALDPHOJP(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0B50", Offset = "0x1DBFB50", VA = "0x181DC0B50", Slot = "8")]
	public JKLONHDKBPA[] AGEHOILIPBL(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO, int BIDOIIHAAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0B90", Offset = "0x1DBFB90", VA = "0x181DC0B90", Slot = "9")]
	public bool HGKKPHNCFKK(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C80", Offset = "0x1DBFC80", VA = "0x181DC0C80", Slot = "10")]
	public bool POJFJJPCOGH(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C60", Offset = "0x1DBFC60", VA = "0x181DC0C60", Slot = "11")]
	public bool LMBGEHNFOJF(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C40", Offset = "0x1DBFC40", VA = "0x181DC0C40", Slot = "12")]
	public bool LLLOGBKOBDJ(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0B70", Offset = "0x1DBFB70", VA = "0x181DC0B70", Slot = "13")]
	public bool GNJKEKAGKDL(EMBFKEMHPML PJJHCBPGJMO, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0C00", Offset = "0x1DBFC00", VA = "0x181DC0C00", Slot = "14")]
	public bool KJCLAPNLFGK(EMBFKEMHPML IEHPEJEDEKI, JKLONHDKBPA DFHNKDINOMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public abstract class NIMJJBKBONM : EKNPNMCHALK
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DBHKDIKGLID.KHOIFOLEPCJ MJBKDGHOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DC32F0", Offset = "0x1DC22F0", VA = "0x181DC32F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract MGJDGKCFPDL.IENECAPDIMD KLLFJAJADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract NNMPKFHFGGO.FNJIOEFLACF DGNMJNGEKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract CNOGHEAKGCF.KEBCJPFIPKM CKANHBOEDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GKGPGLIMANN.KLFOOIIIPBL<PFEGGNECANP, JKLONHDKBPA, NNMPKFHFGGO> BPMBGEOLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1DC32A0", Offset = "0x1DC22A0", VA = "0x181DC32A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public abstract DICLHGGBJDJ MMNHOKAMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public abstract GMNGMOEKMAC OEOLJJDMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public abstract DAOEIIKMPAD LFJGDKIKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public abstract NMEACDKGJCL AFBNKLFCHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public abstract HHJIANLGKIB KLHEEHIAPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected NIMJJBKBONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class CAKHMPBAOMK : NMFMLPOCBFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct DJMHLPNGNBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public CAKHMPBAOMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public JKLONHDKBPA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0840", Offset = "0x1DBF840", VA = "0x181DC0840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0AE0", Offset = "0x1DBFAE0", VA = "0x181DC0AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct OHKEPCJKEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<AOFAJGMCGLP, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public CAKHMPBAOMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public IReadOnlyList<JKLONHDKBPA> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3690", Offset = "0x1DC2690", VA = "0x181DC3690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3A10", Offset = "0x1DC2A10", VA = "0x181DC3A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly BKLDCBGANEP FCNLCLDHBFC;

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public CAKHMPBAOMK(BKLDCBGANEP JJJFBBKJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF0E0", Offset = "0x1DBE0E0", VA = "0x181DBF0E0")]
	[AsyncStateMachine(typeof(DJMHLPNGNBK))]
	private Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> NCKGDCAGBPC(JKLONHDKBPA DFHNKDINOMO, bool BCMNHKGIIHL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEFB0", Offset = "0x1DBDFB0", VA = "0x181DBEFB0", Slot = "4")]
	[AsyncStateMachine(typeof(OHKEPCJKEDJ))]
	public Task<PBAOJGOHCMJ<AOFAJGMCGLP, OAAMPDEOGNE>> HAIPHODLDIJ(IReadOnlyList<JKLONHDKBPA> MLHDOGCFLPD, bool BCMNHKGIIHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NOEBIGGMBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	internal PKMDFGAIIKB<NNNIFOBAHOO, JKLONHDKBPA, KKDJKCDHPLB> MGOJFBHMJOF;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7600", Offset = "0x1DB6600", VA = "0x181DB7600")]
	private NOEBIGGMBLL([In] PKMDFGAIIKB<NNNIFOBAHOO, JKLONHDKBPA, KKDJKCDHPLB> KHJHBPFCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DC3340", Offset = "0x1DC2340", VA = "0x181DC3340")]
	public static NOEBIGGMBLL NAJBLLJFKKI()
	{
		return default(NOEBIGGMBLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class MBLEDHAAAHL
{
	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static PKMDFGAIIKB<NNNIFOBAHOO, JKLONHDKBPA, KKDJKCDHPLB> ANMMPPEPNHI(this NOEBIGGMBLL AOFEPADBPDL)
	{
		return default(PKMDFGAIIKB<NNNIFOBAHOO, JKLONHDKBPA, KKDJKCDHPLB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct KKDJKCDHPLB : INBNDDOPJOA.AOKHMKDDCAN<NNNIFOBAHOO, JKLONHDKBPA>
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2D50", Offset = "0x1DC1D50", VA = "0x181DC2D50", Slot = "5")]
	public JKLONHDKBPA DLNNKIMGDCP(NNNIFOBAHOO[] HHEBLBBJLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20")]
	public int NDJFJACJLJL([In] NNNIFOBAHOO KNCNEEKLJHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20", Slot = "4")]
	private int NBPGBEJIEJJ([In] NNNIFOBAHOO GAJMMLHGDEF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct LKJMFEHKIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	internal AKKCPNOIPOG<GJFKCPECBGE, JKLONHDKBPA, NEJNAEBKKPK> MGOJFBHMJOF;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7600", Offset = "0x1DB6600", VA = "0x181DB7600")]
	private LKJMFEHKIDF([In] AKKCPNOIPOG<GJFKCPECBGE, JKLONHDKBPA, NEJNAEBKKPK> BPMFONHEFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2F60", Offset = "0x1DC1F60", VA = "0x181DC2F60")]
	public static LKJMFEHKIDF NAJBLLJFKKI()
	{
		return default(LKJMFEHKIDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class GHCOKBFJCCN
{
	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static AKKCPNOIPOG<GJFKCPECBGE, JKLONHDKBPA, NEJNAEBKKPK> ANMMPPEPNHI(this LKJMFEHKIDF AOFEPADBPDL)
	{
		return default(AKKCPNOIPOG<GJFKCPECBGE, JKLONHDKBPA, NEJNAEBKKPK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct NEJNAEBKKPK : ABBFGNEEKLJ.FKNDIMPJDKP<GJFKCPECBGE, JKLONHDKBPA>
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20")]
	public int FEBBHAABEHD([In] GJFKCPECBGE KNCNEEKLJHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC30B0", Offset = "0x1DC20B0", VA = "0x181DC30B0", Slot = "5")]
	public JKLONHDKBPA NKCBOEGAPNJ(GJFKCPECBGE[] PILIOOGMMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20", Slot = "4")]
	private int PJNEECLBFAM([In] GJFKCPECBGE KNCNEEKLJHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface DICLHGGBJDJ
{
	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNPOPBLFFLF([In] PBAOJGOHCMJ<EMBFKEMHPML, BOFJPOKAPAE> HEOGODCLBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class LFGLHBBAKGM
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x283B7B0", Offset = "0x283A7B0", VA = "0x18283B7B0")]
	public static bool DNPOPBLFFLF<TOk, TErr>(this DICLHGGBJDJ AOFEPADBPDL, [In] PBAOJGOHCMJ<TOk, TErr> HEOGODCLBDD) where TOk : notnull where TErr : notnull, BOFJPOKAPAE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface GMNGMOEKMAC
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	HCGEPDDBNLB AJMGMEMDELK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface DAOEIIKMPAD
{
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFCMEGDHOPI ILNKMKCDDIO(int CPEPDMLCKGB);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public interface IAJKNANHNFO
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface PCMOKBCKJEE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKEAJHDDPCN? CBGNKMKEDLC(ADHLEPAMMHK<HAOMCHNKLHE> CGDBKLHCHGG);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface AIBNEKFCGDD
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface AKEAJHDDPCN
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIBNEKFCGDD? FLCEGBKMGNL(ADHLEPAMMHK<HDMIFOBJNHK> AOGLOMCDMBC);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAJKNANHNFO? IFNDJANOLPO(ADHLEPAMMHK<BDFEODHMFIL> NHCDOBKJAHC);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface NMEACDKGJCL
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> KADEIHNHNJJ(string CFJDHAGGAJO, string LNLKAOCIPJI);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface HHJIANLGKIB
{
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCMOKBCKJEE? HIBONHIAFCB([In] EEKPKFNOHLA<GBEDNKELGKE> JDJJGDGAGNG);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class AFJMOIICEPB
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private struct FEDHIAHHMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int EDPEAEGJAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public JCBHMFNFIKJ? KBFMNNMNKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public JCBHMFNFIKJ? LCPNMFPFEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public readonly List<JKLONHDKBPA> EEDMIBKJFBD;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0D60", Offset = "0x1DBFD60", VA = "0x181DC0D60")]
		private FEDHIAHHMON(int GCDIELAOHNA, JCBHMFNFIKJ? HNEDDNFKJPN, JCBHMFNFIKJ? AMHAAHAGMOM, List<JKLONHDKBPA> MLHDOGCFLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0CA0", Offset = "0x1DBFCA0", VA = "0x181DC0CA0")]
		public static FEDHIAHHMON NAJBLLJFKKI()
		{
			return default(FEDHIAHHMON);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private readonly EDLDEPFFGGK<FEDHIAHHMON> CEHNCABBDPB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public static AFJMOIICEPB GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DBEDB0", Offset = "0x1DBDDB0", VA = "0x181DBEDB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool IOLNOAFCMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x80F210", Offset = "0x80E210", VA = "0x18080F210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x876690", Offset = "0x875690", VA = "0x180876690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE9B0", Offset = "0x1DBD9B0", VA = "0x181DBE9B0")]
	public void CNMHLDLLMBC(GLKLKFEHMAM AMHAAHAGMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE6B0", Offset = "0x1DBD6B0", VA = "0x181DBE6B0")]
	public void BEBCPJNAFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEA70", Offset = "0x1DBDA70", VA = "0x181DBEA70")]
	private static string? MDPOIFBPOEC([In] FEDHIAHHMON OHDOELCIBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEF00", Offset = "0x1DBDF00", VA = "0x181DBEF00")]
	public AFJMOIICEPB()
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
