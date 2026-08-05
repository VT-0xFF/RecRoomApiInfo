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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FADEB0", Offset = "0x1FAD2B0", VA = "0x181FADEB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NAAMCGEJGIP : IDisposable, JDNIOOGFLNG, BAMELAMEAOL, AFNBLCPHNMF, CDHEFGAPPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FELIFIICGKO : MIKEIELFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int JJIANEEEMCF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6890", Offset = "0x1FA5C90", VA = "0x181FA6890", Slot = "5")]
		public JAGFPCJBDCO CIOCDKKOJNJ(EJAOBIAMFLH.IPPOFHOGKHP GPENJAMDJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void BLFKCDFIOOA();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void HMNNMJOCAED();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6850", Offset = "0x1FA5C50", VA = "0x181FA6850", Slot = "13")]
		public virtual void BEKJKCHJOOF(NAAMCGEJGIP LMOEPHCOEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FA69E0", Offset = "0x1FA5DE0", VA = "0x181FA69E0", Slot = "14")]
		public virtual void JLAMJIKCBGC(NAAMCGEJGIP LMOEPHCOEOK, CIAJNHMHPBB FADGJFNLBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected FELIFIICGKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MIKEIELFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int JJIANEEEMCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JAGFPCJBDCO CIOCDKKOJNJ(EJAOBIAMFLH.IPPOFHOGKHP GPENJAMDJGM);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BLFKCDFIOOA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HMNNMJOCAED();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BEKJKCHJOOF(NAAMCGEJGIP LMOEPHCOEOK);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JLAMJIKCBGC(NAAMCGEJGIP LMOEPHCOEOK, CIAJNHMHPBB FADGJFNLBLP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GIBEBIEAILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NJGPIJLJNOL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> KPFDILKCFKP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7DD0", Offset = "0x1FA71D0", VA = "0x181FA7DD0")]
		internal GIBEBIEAILG(NJGPIJLJNOL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> DJKNDPHDPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HDGEIHKIHGG : OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HDGEIHKIHGG CLHFPJDPLGI;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		private HDGEIHKIHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBCBF90", Offset = "0xBCB390", VA = "0x180BCBF90", Slot = "4")]
		public FALDKJOPCKF KNABBLFKFCE(CIAJNHMHPBB ABPJKOBADEP)
		{
			return default(FALDKJOPCKF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA81A0", Offset = "0x1FA75A0", VA = "0x181FA81A0", Slot = "5")]
		public void BEKJKCHJOOF(NAAMCGEJGIP MILPLABKJCF, CIAJNHMHPBB FADGJFNLBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1FA82B0", Offset = "0x1FA76B0", VA = "0x181FA82B0", Slot = "6")]
		public void JLAMJIKCBGC(NAAMCGEJGIP MILPLABKJCF, CIAJNHMHPBB FADGJFNLBLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BIPLFJHLGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KGJMNALECGB<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> KPFDILKCFKP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E460", Offset = "0x1F9D860", VA = "0x181F9E460")]
		internal BIPLFJHLGBB(KGJMNALECGB<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E410", Offset = "0x1F9D810", VA = "0x181F9E410")]
		public static BIPLFJHLGBB DDEJLDFANAB()
		{
			return default(BIPLFJHLGBB);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct OMLNDKLJFBD : MLNCCOCPGDO.HAADJHCAOBA<CIAJNHMHPBB, NAAMCGEJGIP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BDOADMKCJNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NAAMCGEJGIP receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CIAJNHMHPBB action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OMLNDKLJFBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E1C0", Offset = "0x1F9D5C0", VA = "0x181F9E1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E3A0", Offset = "0x1F9D7A0", VA = "0x181F9E3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD20", Offset = "0x9AF120", VA = "0x1809AFD20", Slot = "4")]
		public DFKPAEMPCKH<LKGMKFKGJFB> GGLMADLMCGN(NAAMCGEJGIP IFEKGLLMLPF)
		{
			return default(DFKPAEMPCKH<LKGMKFKGJFB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF7A0", Offset = "0x1FAEBA0", VA = "0x181FAF7A0", Slot = "5")]
		[AsyncStateMachine(typeof(BDOADMKCJNJ))]
		public Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> CJLDBNPMEJF(NAAMCGEJGIP IFEKGLLMLPF, CIAJNHMHPBB FADGJFNLBLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF8D0", Offset = "0x1FAECD0", VA = "0x181FAF8D0", Slot = "6")]
		public CIAJNHMHPBB[] GPEENOGBIBE(NAAMCGEJGIP IFEKGLLMLPF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LCIPEONEIPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NAAMCGEJGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ABGDAFBNPKJ rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HKDDDJCKAFD circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ALPLJLFJAMB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB340", Offset = "0x1FAA740", VA = "0x181FAB340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB5C0", Offset = "0x1FAA9C0", VA = "0x181FAB5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IPNHNIMDDIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NAAMCGEJGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8D50", Offset = "0x1FA8150", VA = "0x181FA8D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8FE0", Offset = "0x1FA83E0", VA = "0x181FA8FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FFBGILCAHEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public NAAMCGEJGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6A60", Offset = "0x1FA5E60", VA = "0x181FA6A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6C40", Offset = "0x1FA6040", VA = "0x181FA6C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GMNPGMJDKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NAAMCGEJGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public CIAJNHMHPBB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7F40", Offset = "0x1FA7340", VA = "0x181FA7F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8130", Offset = "0x1FA7530", VA = "0x181FA8130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JPLCOMKBKOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NAAMCGEJGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9D40", Offset = "0x1FA9140", VA = "0x181FA9D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA530", Offset = "0x1FA9930", VA = "0x181FAA530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DFKPAEMPCKH<LKGMKFKGJFB> JFCCNGJAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GIBEBIEAILG CCLNFJGLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DKAJIEOEAPC CKFKJJHBOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly OEBAHAMNKEI BOCJBIHOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly KMOOBHBDIMP HCAOGKPKONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FJGCDADIDCM.FLJANHLEFCH EGFJBFDMEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1918")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly CJFFJBJONAO INIGLNDBAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1920")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly LNKFCPFDDEL PMICPCEOPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PKMEAPNGDAA BMBJMJIBNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly IEKKKEGNDGM CDBKCNKJMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HPBHCAFKCCA FANNJKPENPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HFNKGONFOEJ JCLDJODMIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1968")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly DKAJIEOEAPC.NFOKGEGGHPG EOBGJAFOILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1970")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly CNGDEOGLLPM JBPFPOGBLHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DKAJIEOEAPC GNJHJBICAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD9E0", Offset = "0x1FACDE0", VA = "0x181FAD9E0")]
		get
		{
			return default(DKAJIEOEAPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MIKEIELFCGF CFHMHGJHCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD610", Offset = "0x1FACA10", VA = "0x181FAD610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JAGFPCJBDCO OJCIKDBNNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD590", Offset = "0x1FAC990", VA = "0x181FAD590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FACBA0", Offset = "0x1FABFA0", VA = "0x181FACBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool ABNBGAIBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD9F0", Offset = "0x1FACDF0", VA = "0x181FAD9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD7D0", Offset = "0x1FACBD0", VA = "0x181FAD7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PLOMGJIAMFN AFCPJPBGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1FADD00", Offset = "0x1FAD100", VA = "0x181FADD00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BAHDOGOPPJF NNEIMFNLOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FADD10", Offset = "0x1FAD110", VA = "0x181FADD10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PNCHAOAGJFN FPDEHOOCCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FADD30", Offset = "0x1FAD130", VA = "0x181FADD30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNPBGEDDMDG DOHAEJMBEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FADD20", Offset = "0x1FAD120", VA = "0x181FADD20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FJGCDADIDCM? GOHGNOOHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD750", Offset = "0x1FACB50", VA = "0x181FAD750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private HCIPNBJGCCB? KHLLKHGJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FACD20", Offset = "0x1FAC120", VA = "0x181FACD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FADA00", Offset = "0x1FACE00", VA = "0x181FADA00")]
	private NAAMCGEJGIP(KMOOBHBDIMP OLAPOPPPDNC, DFKPAEMPCKH<LKGMKFKGJFB> CPCCBMAHCJD, [In] GIBEBIEAILG ABCCBPIDBBI, [In] DKAJIEOEAPC GACLDMOMONI, [In] OEBAHAMNKEI PEILKILIENH, JAGFPCJBDCO BNKPJOLHMJI, [In] FJGCDADIDCM.FLJANHLEFCH DEKEOPKNELE, DKAJIEOEAPC.NFOKGEGGHPG NJFMLDIAGBJ, CNGDEOGLLPM LALEIIACCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC7F0", Offset = "0x1FABBF0", VA = "0x181FAC7F0")]
	public static NAAMCGEJGIP DDEJLDFANAB(KMOOBHBDIMP GPENJAMDJGM, [In] FAKDIDMHGKB JLHAGNMBHEG, IBNHFHHDLAL GDPLCPEFAIL, [In] AFJHGOGALJN OCBAHGJIMMF, DNPMPCLLKLB IIMNHKKKOKB, DFKPAEMPCKH<LKGMKFKGJFB> CPCCBMAHCJD, DFKPAEMPCKH<BCOJMOHINGI> BEPAMDMPPKN, IEAPCJENEBE NAPHODNAANP, HNKDINLKEHJ OOECLJGGPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC510", Offset = "0x1FAB910", VA = "0x181FAC510")]
	public static NAAMCGEJGIP DDEJLDFANAB(KMOOBHBDIMP OLAPOPPPDNC, [In] DKAJIEOEAPC GACLDMOMONI, [In] OEBAHAMNKEI PEILKILIENH, DFKPAEMPCKH<LKGMKFKGJFB> CPCCBMAHCJD, DFKPAEMPCKH<BCOJMOHINGI> BEPAMDMPPKN, IEAPCJENEBE NAPHODNAANP, HNKDINLKEHJ OOECLJGGPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC930", Offset = "0x1FABD30", VA = "0x181FAC930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FACBC0", Offset = "0x1FABFC0", VA = "0x181FACBC0")]
	[AsyncStateMachine(typeof(LCIPEONEIPA))]
	internal Task<NNKIHJJJOOI<bool, FAGGAEGFGFH>> EOMIMLADFAG(ABGDAFBNPKJ KNLBLOKDGNG, HKDDDJCKAFD KBJADHCBKJK, ALPLJLFJAMB JBOHECJOFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD7E0", Offset = "0x1FACBE0", VA = "0x181FAD7E0")]
	[AsyncStateMachine(typeof(IPNHNIMDDIA))]
	public Task<NNKIHJJJOOI<bool, FAGGAEGFGFH>> MCDLDNDPGNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD660", Offset = "0x1FACA60", VA = "0x181FAD660")]
	[AsyncStateMachine(typeof(FFBGILCAHEH))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> KOHJEIPHKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE50", Offset = "0x1FAC250", VA = "0x181FACE50")]
	internal void GHOBLJDJEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD3F0", Offset = "0x1FAC7F0", VA = "0x181FAD3F0")]
	internal DMABLNOGLNN<CIAJNHMHPBB> HPEODAOMMHM([In] ENCMKFOLPJA BOJEOMLJFBB)
	{
		return default(DMABLNOGLNN<CIAJNHMHPBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD5A0", Offset = "0x1FAC9A0", VA = "0x181FAD5A0")]
	internal bool KFDIPHDFAOC([In] ENCMKFOLPJA BOJEOMLJFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FACB20", Offset = "0x1FABF20", VA = "0x181FACB20")]
	internal DMABLNOGLNN<CIAJNHMHPBB> EDBNGIBFJEC([In] GGGJKIGEJCF AONOCOPBPIA)
	{
		return default(DMABLNOGLNN<CIAJNHMHPBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD8D0", Offset = "0x1FACCD0", VA = "0x181FAD8D0")]
	[AsyncStateMachine(typeof(GMNPGMJDKKD))]
	internal Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> NOALJCBHHAA(CIAJNHMHPBB FADGJFNLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD060", Offset = "0x1FAC460", VA = "0x181FAD060")]
	private CIAJNHMHPBB[] GPEENOGBIBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD470", Offset = "0x1FAC870", VA = "0x181FAD470")]
	[AsyncStateMachine(typeof(JPLCOMKBKOD))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> IKKCLPGPLDI(Guid AJGDHEHIMJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FGNOCNMGHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B527B0", Offset = "0x2B51BB0", VA = "0x182B527B0")]
	public static AFBKFHKFDCN<(TPrev?, NAAMCGEJGIP?), HCIPNBJGCCB> ODKGDJFDIEA<TPrev>([In] this AFBKFHKFDCN<TPrev, NAAMCGEJGIP> ABPJKOBADEP)
	{
		return default(AFBKFHKFDCN<(TPrev, NAAMCGEJGIP), HCIPNBJGCCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B52590", Offset = "0x2B51990", VA = "0x182B52590")]
	public static AFBKFHKFDCN<TPrev?, NAAMCGEJGIP?> GLPECOEAJNI<TPrev>([In] this AFBKFHKFDCN<TPrev, NAAMCGEJGIP> ABPJKOBADEP)
	{
		return default(AFBKFHKFDCN<TPrev, NAAMCGEJGIP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PPKBGBHPHBG<TData> : NDGMACBFDAM, HDMFOONKIAF, EHALGCGAKNL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AACPCJLHLFB<CEAIECNFGDF>? DAJAKFIDDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string IBHMBHJJPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData GAMKDEPHLKE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AACPCJLHLFB<CEAIECNFGDF>? BBPCPCHNCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21EB8A0", Offset = "0x21EACA0", VA = "0x1821EB8A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620", Slot = "7")]
	public override string GBCPGMBELKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47F7360", Offset = "0x47F6760", VA = "0x1847F7360")]
	internal PPKBGBHPHBG([In] AACPCJLHLFB<CEAIECNFGDF>? ALBGLJIAAIA, DFKPAEMPCKH<EBINLCLBAEP>? GCJPCGOBNLJ, IOKind? HEPKJDIAMPK, string PBDOHNMILPN, [In] TData LDNEPNAGEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JOACNJGIFFB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FA98A0", Offset = "0x1FA8CA0", VA = "0x181FA98A0")]
	public static NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF> OPIKJEJNKNN([In] this JLIAJACFMJM<EAPFMOLBLAL> JNBOOPIADFG)
	{
		return default(NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4CF0", Offset = "0x2BE40F0", VA = "0x182BE4CF0")]
	public static NNKIHJJJOOI<TOk, HDMFOONKIAF> CHABIJDJCJO<TOk>([In] this NNKIHJJJOOI<TOk, HDMFOONKIAF> ABPJKOBADEP, [In] AACPCJLHLFB<CEAIECNFGDF>? ALBGLJIAAIA, DFKPAEMPCKH<EBINLCLBAEP>? GCJPCGOBNLJ, IOKind? HEPKJDIAMPK, string PBDOHNMILPN) where TOk : notnull
	{
		return default(NNKIHJJJOOI<TOk, HDMFOONKIAF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KMOOBHBDIMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JKCLGPCNGGM.BPENMBILMHO MGDKNLNPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EJAOBIAMFLH.IPPOFHOGKHP DIGKMAKIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NAAMCGEJGIP.MIKEIELFCGF HAMMPPGGPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	LOIFMGHPEPP.MNFBECEJCCF DMNIFINAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP> LBLMALJKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DOCEIIONKMH FJHMEDMNNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OJHNOEMMCBP GDAMCNLLMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JCANDIFEJOA JDPGMMEBPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DJIOBGEKANB LMKHDMAJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LAKFBGDBCBB DOBDGIEJBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LCGINHPPLCO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB160", Offset = "0x1FAA560", VA = "0x181FAB160")]
	public static CIAJNHMHPBB EOBPJBADMFP(this CIAJNHMHPBB ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB270", Offset = "0x1FAA670", VA = "0x181FAB270")]
	public static CIAJNHMHPBB FHGHOPICFFI(this FCCKMIBGNEF ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FCCKMIBGNEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GACBOOKIODL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NAAMCGEJGIP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FCCKMIBGNEF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7090", Offset = "0x1FA6490", VA = "0x181FA7090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7350", Offset = "0x1FA6750", VA = "0x181FA7350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString KHLHBLNGCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	private FCCKMIBGNEF(ByteString OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6680", Offset = "0x1FA5A80", VA = "0x181FA6680")]
	public static CIAJNHMHPBB DLJEMINPBNH(ByteString OBEEJPGJPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FA65D0", Offset = "0x1FA59D0", VA = "0x181FA65D0")]
	public static ODDKBFGDCGO<FALDKJOPCKF, FCCKMIBGNEF> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, FCCKMIBGNEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6740", Offset = "0x1FA5B40", VA = "0x181FA6740")]
	[AsyncStateMachine(typeof(GACBOOKIODL))]
	public static Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> NOALJCBHHAA(NAAMCGEJGIP MILPLABKJCF, FCCKMIBGNEF ABPJKOBADEP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PPMHPPEAEEN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB0D0", Offset = "0x1FBA4D0", VA = "0x181FBB0D0")]
	public static CIAJNHMHPBB DLJEMINPBNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB060", Offset = "0x1FBA460", VA = "0x181FBB060")]
	public static ODDKBFGDCGO<FALDKJOPCKF, PPMHPPEAEEN> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, PPMHPPEAEEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAFE0", Offset = "0x1FBA3E0", VA = "0x181FBAFE0")]
	public static NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC> BGEOPOFDMAO(NAAMCGEJGIP MILPLABKJCF, [In] PPMHPPEAEEN ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HEBKDAELJEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LNGMOHFLBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NAAMCGEJGIP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public HEBKDAELJEA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FABFD0", Offset = "0x1FAB3D0", VA = "0x181FABFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC340", Offset = "0x1FAB740", VA = "0x181FAC340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly ABGDAFBNPKJ? KDIJMCDFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HKDDDJCKAFD? IOECPJBHHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly ALPLJLFJAMB? CIIDLPJJGFH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED7B20", Offset = "0x1ED6F20", VA = "0x181ED7B20")]
	private HEBKDAELJEA(ABGDAFBNPKJ? KNLBLOKDGNG, HKDDDJCKAFD? KBJADHCBKJK, ALPLJLFJAMB? JBOHECJOFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8550", Offset = "0x1FA7950", VA = "0x181FA8550")]
	public static CIAJNHMHPBB? DLJEMINPBNH(ABGDAFBNPKJ? KNLBLOKDGNG, HKDDDJCKAFD? KBJADHCBKJK, ALPLJLFJAMB? JBOHECJOFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8440", Offset = "0x1FA7840", VA = "0x181FA8440")]
	public static ODDKBFGDCGO<FALDKJOPCKF, HEBKDAELJEA> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, HEBKDAELJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8650", Offset = "0x1FA7A50", VA = "0x181FA8650")]
	[AsyncStateMachine(typeof(LNGMOHFLBOM))]
	public static Task<NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC>> NOALJCBHHAA(NAAMCGEJGIP MILPLABKJCF, HEBKDAELJEA ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PDGAEDNIJDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OHJGEAJAILK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PDGAEDNIJDP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NAAMCGEJGIP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private NNKIHJJJOOI<object, EHALGCGAKNL>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private NNKIHJJJOOI<object, EHALGCGAKNL> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private NNKIHJJJOOI<object, EHALGCGAKNL>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEAF0", Offset = "0x1FADEF0", VA = "0x181FAEAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEF60", Offset = "0x1FAE360", VA = "0x181FAEF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<CIAJNHMHPBB> KMCMOHIFJPI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	private PDGAEDNIJDP(IReadOnlyList<CIAJNHMHPBB> DJJANLFLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFC00", Offset = "0x1FAF000", VA = "0x181FAFC00")]
	public static CIAJNHMHPBB DLJEMINPBNH(IReadOnlyList<CIAJNHMHPBB> DJJANLFLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFB60", Offset = "0x1FAEF60", VA = "0x181FAFB60")]
	public static ODDKBFGDCGO<FALDKJOPCKF, PDGAEDNIJDP> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, PDGAEDNIJDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFCC0", Offset = "0x1FAF0C0", VA = "0x181FAFCC0")]
	[AsyncStateMachine(typeof(OHJGEAJAILK))]
	public static Task<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> NOALJCBHHAA(NAAMCGEJGIP MILPLABKJCF, PDGAEDNIJDP ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct GGGJKIGEJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int AKKFFAPEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int KCOEJCJFNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] GAMKDEPHLKE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1BC1F30", Offset = "0x1BC1330", VA = "0x181BC1F30")]
	private GGGJKIGEJCF(int MLMABEGDEJH, int AGAGKNBDCIG, byte[] LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7CF0", Offset = "0x1FA70F0", VA = "0x181FA7CF0")]
	public static CIAJNHMHPBB DLJEMINPBNH(int MLMABEGDEJH, int AGAGKNBDCIG, ByteString LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7AD0", Offset = "0x1FA6ED0", VA = "0x181FA7AD0")]
	public static CIAJNHMHPBB[] CIPKDHEKCIB(CIAJNHMHPBB FADGJFNLBLP, int NAIFHADDDCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7C10", Offset = "0x1FA7010", VA = "0x181FA7C10")]
	public static ODDKBFGDCGO<FALDKJOPCKF, GGGJKIGEJCF> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, GGGJKIGEJCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA79B0", Offset = "0x1FA6DB0", VA = "0x181FA79B0")]
	public static NNKIHJJJOOI<CIAJNHMHPBB, JNABADLMAMC> BGEOPOFDMAO(NAAMCGEJGIP MILPLABKJCF, [In] GGGJKIGEJCF ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<CIAJNHMHPBB, JNABADLMAMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ENCMKFOLPJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BMGLBEAFCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<bool, JNABADLMAMC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NAAMCGEJGIP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ENCMKFOLPJA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private NNKIHJJJOOI<bool, JNABADLMAMC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, JNABADLMAMC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E470", Offset = "0x1F9D870", VA = "0x181F9E470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EAB0", Offset = "0x1F9DEB0", VA = "0x181F9EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int AKKFFAPEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int KCOEJCJFNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] GAMKDEPHLKE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1BC1F30", Offset = "0x1BC1330", VA = "0x181BC1F30")]
	private ENCMKFOLPJA(int MLMABEGDEJH, int AGAGKNBDCIG, byte[] LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA55C0", VA = "0x181FA61C0")]
	public static CIAJNHMHPBB DLJEMINPBNH(int MLMABEGDEJH, int AGAGKNBDCIG, ByteString LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FA62A0", Offset = "0x1FA56A0", VA = "0x181FA62A0")]
	public static CIAJNHMHPBB?[]? FLEOMKMPMPG(int NAIFHADDDCA, ABGDAFBNPKJ? KNLBLOKDGNG, HKDDDJCKAFD? KBJADHCBKJK, ALPLJLFJAMB? JBOHECJOFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FA60E0", Offset = "0x1FA54E0", VA = "0x181FA60E0")]
	public static ODDKBFGDCGO<FALDKJOPCKF, ENCMKFOLPJA> DFJLGDIIKLM(CIAJNHMHPBB KDMNPNPDLEF)
	{
		return default(ODDKBFGDCGO<FALDKJOPCKF, ENCMKFOLPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FA64A0", Offset = "0x1FA58A0", VA = "0x181FA64A0")]
	[AsyncStateMachine(typeof(BMGLBEAFCKJ))]
	public static Task<NNKIHJJJOOI<bool, JNABADLMAMC>> NOALJCBHHAA(NAAMCGEJGIP MILPLABKJCF, ENCMKFOLPJA ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CJFFJBJONAO : PLOMGJIAMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BEAJLBHIAAB? CLHFPJDPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EC60", Offset = "0x1F9E060", VA = "0x181F9EC60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	internal CJFFJBJONAO(NAAMCGEJGIP LMOEPHCOEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HJDHJPKKJDN : BEAJLBHIAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HLLGCBEKKMH GFGMMOOHOFE;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
	public HJDHJPKKJDN(NAAMCGEJGIP LMOEPHCOEOK, HLLGCBEKKMH NDDBAFJNIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8A70", Offset = "0x1FA7E70", VA = "0x181FA8A70", Slot = "4")]
	public NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF> LGMHPFIAOEH(AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<CGOIJKHKIMG> OBINEBNCEJA)
	{
		return default(NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8790", Offset = "0x1FA7B90", VA = "0x181FA8790", Slot = "5")]
	public NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF> JCKOJIHONBG(AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<NNKLJCCKPPB> HOLPDNLGFNL)
	{
		return default(NNKIHJJJOOI<MELFHKCFMAN, HDMFOONKIAF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JKCLGPCNGGM : DPMBDPIOLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BPENMBILMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HLLGCBEKKMH> EIGJJAIPNAI(NAAMCGEJGIP LMOEPHCOEOK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN, CancellationToken GNJJGEHBGKC);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HJDNPIMPMHO CGOJDAEBKNC(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class KINBJMHDLJF : BPENMBILMHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct LLLFJGACIEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<HLLGCBEKKMH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NAAMCGEJGIP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HKDDDJCKAFD cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public ALPLJLFJAMB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<LOIFMGHPEPP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB630", Offset = "0x1FAAA30", VA = "0x181FAB630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB800", Offset = "0x1FAAC00", VA = "0x181FAB800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly KINBJMHDLJF CLHFPJDPLGI;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		private KINBJMHDLJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA5C0", Offset = "0x1FA99C0", VA = "0x181FAA5C0", Slot = "4")]
		[AsyncStateMachine(typeof(LLLFJGACIEH))]
		public Task<HLLGCBEKKMH> EIGJJAIPNAI(NAAMCGEJGIP LMOEPHCOEOK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN, CancellationToken GNJJGEHBGKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA5A0", Offset = "0x1FA99A0", VA = "0x181FAA5A0", Slot = "5")]
		public HJDNPIMPMHO CGOJDAEBKNC(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JLIKCPCKAJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<JKCLGPCNGGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NAAMCGEJGIP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HKDDDJCKAFD cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ALPLJLFJAMB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ABGDAFBNPKJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private BPENMBILMHO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<HLLGCBEKKMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9330", Offset = "0x1FA8730", VA = "0x181FA9330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9830", Offset = "0x1FA8C30", VA = "0x181FA9830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HLLGCBEKKMH GFGMMOOHOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HJDNPIMPMHO JHOGCLOPKOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FJGCDADIDCM GOHGNOOHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9170", Offset = "0x1FA8570", VA = "0x181FA9170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HCIPNBJGCCB GKLJNMCHKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1FA90B0", Offset = "0x1FA84B0", VA = "0x181FA90B0", Slot = "5")]
		get
		{
			return default(HCIPNBJGCCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HJDHJPKKJDN BLPHKMMMLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ACKMOMLFCCA EMCNPMMIALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E90520", Offset = "0x1E8F920", VA = "0x181E90520")]
	private JKCLGPCNGGM(HLLGCBEKKMH NDDBAFJNIDF, HJDNPIMPMHO PJJEMPEOHGL, HJDHJPKKJDN ANOJHJPDNNN, ACKMOMLFCCA KKAPGLNNOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FA91C0", Offset = "0x1FA85C0", VA = "0x181FA91C0")]
	[AsyncStateMachine(typeof(JLIKCPCKAJM))]
	public static Task<JKCLGPCNGGM> LKKCFMPGCAF(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9050", Offset = "0x1FA8450", VA = "0x181FA9050", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EJAOBIAMFLH : JAGFPCJBDCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface IPPOFHOGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DPMBDPIOLLP> FIGPAFDLEMD(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN, CancellationToken GNJJGEHBGKC);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GJNIMGLDCDL();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DGCNAMNFPAB();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class GLIMMKMEFGC : IPPOFHOGKHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct PJCCLDPNGPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<DPMBDPIOLLP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public NAAMCGEJGIP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ABGDAFBNPKJ evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public HKDDDJCKAFD cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public ALPLJLFJAMB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<JKCLGPCNGGM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FAFE00", Offset = "0x1FAF200", VA = "0x181FAFE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0140", Offset = "0x1FAF540", VA = "0x181FB0140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7DE0", Offset = "0x1FA71E0", VA = "0x181FA7DE0", Slot = "4")]
		[AsyncStateMachine(typeof(PJCCLDPNGPJ))]
		public Task<DPMBDPIOLLP> FIGPAFDLEMD(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN, CancellationToken GNJJGEHBGKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GJNIMGLDCDL();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DGCNAMNFPAB();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected GLIMMKMEFGC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct PBGKJPPFMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<DPMBDPIOLLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EJAOBIAMFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<AEFODLADDHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF8F0", Offset = "0x1FAECF0", VA = "0x181FAF8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FAFAF0", Offset = "0x1FAEEF0", VA = "0x181FAFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LBHDONNLHBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EJAOBIAMFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public NAAMCGEJGIP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ABGDAFBNPKJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HKDDDJCKAFD cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ALPLJLFJAMB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<DPMBDPIOLLP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FAABD0", Offset = "0x1FA9FD0", VA = "0x181FAABD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB100", Offset = "0x1FAA500", VA = "0x181FAB100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IPPOFHOGKHP FNNPADDAENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<AEFODLADDHH> GCJMNFIKDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<AEFODLADDHH> NMNEFOAFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource BCPNHHGABPD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool ABNBGAIBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA5F680", Offset = "0xA5EA80", VA = "0x180A5F680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA5F990", Offset = "0xA5ED90", VA = "0x180A5F990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ADBLGJPBPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F30", Offset = "0xBA3330", VA = "0x180BA3F30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F40", Offset = "0xBA3340", VA = "0x180BA3F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AEFHJCLAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x11D0410", Offset = "0x11CF810", VA = "0x1811D0410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4080", Offset = "0x1FA3480", VA = "0x181FA4080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DPMBDPIOLLP? JMHJJBEKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3E20", Offset = "0x1FA3220", VA = "0x181FA3E20", Slot = "7")]
	[AsyncStateMachine(typeof(PBGKJPPFMGC))]
	public Task<DPMBDPIOLLP> DODLFOJAEGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4090", Offset = "0x1FA3490", VA = "0x181FA4090")]
	public EJAOBIAMFLH(IPPOFHOGKHP GPENJAMDJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3CC0", Offset = "0x1FA30C0", VA = "0x181FA3CC0", Slot = "8")]
	[AsyncStateMachine(typeof(LBHDONNLHBI))]
	public Task CKBHNBBOGJI(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3F10", Offset = "0x1FA3310", VA = "0x181FA3F10", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DIBMNJBCCKK : IPDFNJJFABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ACKMOMLFCCA KNPNGAAHKFF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public DIBMNJBCCKK(ACKMOMLFCCA KKAPGLNNOPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GFKNCPDKIDK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FCBGBBKGHMM<TGraph> : EIOGPKGBPGN where TGraph : IAJIJDCIEPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph DNBJCMGLOGM;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual HAECHINNGHF? ECBOGGHLEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x102C6E0", Offset = "0x102BAE0", VA = "0x18102C6E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DFKPAEMPCKH<JJIBBLMHJAE> HGENNJHNHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C05CE0", Offset = "0x3C050E0", VA = "0x183C05CE0", Slot = "5")]
			get
			{
				return default(DFKPAEMPCKH<JJIBBLMHJAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DFKPAEMPCKH<JJIBBLMHJAE>? IEJDBDBECOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C05C60", Offset = "0x3C05060", VA = "0x183C05C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
		public FCBGBBKGHMM(TGraph KHHCBCFNIBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class NFHDDBIPJFB : FCBGBBKGHMM<HMCGFEJGOED>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override HAECHINNGHF? ECBOGGHLEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FADD40", Offset = "0x1FAD140", VA = "0x181FADD40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FADD60", Offset = "0x1FAD160", VA = "0x181FADD60")]
		public NFHDDBIPJFB(HMCGFEJGOED BMJLIPJPCOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7820", Offset = "0x1FA6C20", VA = "0x181FA7820")]
	public static EIOGPKGBPGN DDEJLDFANAB(IAJIJDCIEPB KHHCBCFNIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CKFKFMHNJOK : KHEIIHCPHBN, BJGCGLIDAKL, ADNGLOCCGKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class MFOECMDDGAK
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
			public MFOECMDDGAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public DOCEIIONKMH errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB170", Offset = "0x1FBA570", VA = "0x181FBB170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB3E0", Offset = "0x1FBA7E0", VA = "0x181FBB3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CKFKFMHNJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MFOECMDDGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC3B0", Offset = "0x1FAB7B0", VA = "0x181FAC3B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task LHGNIBCODFC(DOCEIIONKMH errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EFEFFMLFEFO : IAsyncStateMachine
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
		public CKFKFMHNJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3750", Offset = "0x1FA2B50", VA = "0x181FA3750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3C60", Offset = "0x1FA3060", VA = "0x181FA3C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KLLIMMGNAJH
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
			public KLLIMMGNAJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB440", Offset = "0x1FBA840", VA = "0x181FBB440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB720", Offset = "0x1FBAB20", VA = "0x181FBB720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CKFKFMHNJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public KLLIMMGNAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA7A0", Offset = "0x1FA9BA0", VA = "0x181FAA7A0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task MNBMOAEMJFD(DOCEIIONKMH errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KOOGMACNIJK OPFBLKGKEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<LPNCCKOEKPD> JLOKCFKOIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private KMOOBHBDIMP LGBOJIHHEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0180", Offset = "0x1F9F580", VA = "0x181FA0180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DFKPAEMPCKH<CGOIJKHKIMG> AGGOOIMOLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x996330", Offset = "0x995730", VA = "0x180996330", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(DFKPAEMPCKH<CGOIJKHKIMG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBB1BF0", Offset = "0xBB0FF0", VA = "0x180BB1BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private DFKPAEMPCKH<PEGEEDBAAGD> JMEHMICDDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB9B210", Offset = "0xB9A610", VA = "0x180B9B210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DFKPAEMPCKH<OGMOCINGCKO> KLFOJDPBKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x872CD0", Offset = "0x8720D0", VA = "0x180872CD0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DFKPAEMPCKH<OGMOCINGCKO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override DFKPAEMPCKH<EBINLCLBAEP> CNPFOFGDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA01A0", Offset = "0x1F9F5A0", VA = "0x181FA01A0", Slot = "20")]
		get
		{
			return default(DFKPAEMPCKH<EBINLCLBAEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OCGIICDMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0D50", Offset = "0x1FA0150", VA = "0x181FA0D50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA15A0", Offset = "0x1FA09A0", VA = "0x181FA15A0")]
	private CKFKFMHNJOK(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ, KOOGMACNIJK HEMMOABFLIA, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<CGOIJKHKIMG> OBINEBNCEJA, DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH, bool DJKCNNJKFBL, string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F1F0", Offset = "0x1F9E5F0", VA = "0x181F9F1F0")]
	public static CKFKFMHNJOK DDEJLDFANAB(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ, KOOGMACNIJK BCPLMINPIEH, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH, DFKPAEMPCKH<CGOIJKHKIMG> OBINEBNCEJA, bool DJKCNNJKFBL, bool LKDJEFBOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1090", Offset = "0x1FA0490", VA = "0x181FA1090", Slot = "21")]
	protected override void MGIGIPLLEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F670", Offset = "0x1F9EA70", VA = "0x181F9F670", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA13D0", Offset = "0x1FA07D0", VA = "0x181FA13D0", Slot = "30")]
	public void OMLJCKIFDHA(LPNCCKOEKPD AKCDFMJOOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FC70", Offset = "0x1F9F070", VA = "0x181F9FC70", Slot = "27")]
	public void GEOOGBHLFPH(LOJLCPCKNIN MCJJLDPGNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA03A0", Offset = "0x1F9F7A0", VA = "0x181FA03A0", Slot = "28")]
	public void LIBPOCNOGAF(KLBDDGBOCFJ DJKKNBGBODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F7D0", Offset = "0x1F9EBD0", VA = "0x181F9F7D0", Slot = "23")]
	protected override void EMBHJFCAHOA(NKHPFNCLJJF FFPDHPNKKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1430", Offset = "0x1FA0830", VA = "0x181FA1430", Slot = "32")]
	public string PBNCLBKIJMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0DD0", Offset = "0x1FA01D0", VA = "0x181FA0DD0", Slot = "29")]
	public string LLGMLLKNNCH(int AOMPLLKPDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F970", Offset = "0x1F9ED70", VA = "0x181F9F970")]
	private void EOMCHHEBNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FBA0", Offset = "0x1F9EFA0", VA = "0x181F9FBA0", Slot = "31")]
	public void FNCDILMOLND(LPNCCKOEKPD AKCDFMJOOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F030", Offset = "0x1F9E430", VA = "0x181F9F030")]
	private void CLPILGFAHMN(bool OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9ED70", Offset = "0x1F9E170", VA = "0x181F9ED70", Slot = "33")]
	[AsyncStateMachine(typeof(EFEFFMLFEFO))]
	public Task BCIOPFDCFOL(string OBEEJPGJPFD, bool FPNNDOFMDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0250", Offset = "0x1F9F650", VA = "0x181FA0250")]
	public void LCBFFOLFJJB(string OBEEJPGJPFD, bool FPNNDOFMDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EE90", Offset = "0x1F9E290", VA = "0x181F9EE90")]
	private void CEFOBENENFI(int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xBB1BF0", Offset = "0xBB0FF0", VA = "0x180BB1BF0")]
	internal void GOEEDIMDEEC(DFKPAEMPCKH<CGOIJKHKIMG> OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0240", Offset = "0x1F9F640", VA = "0x181FA0240")]
	[CompilerGenerated]
	private void KDNIMPBJCBD(string OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F710", Offset = "0x1F9EB10", VA = "0x181F9F710")]
	[CompilerGenerated]
	private bool EGKAMJDJLKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA11F0", Offset = "0x1FA05F0", VA = "0x181FA11F0")]
	[CompilerGenerated]
	private bool MODGBAPMDLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA00B0", Offset = "0x1F9F4B0", VA = "0x181FA00B0")]
	[CompilerGenerated]
	private int NIPLJJFFOLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA12B0", Offset = "0x1FA06B0", VA = "0x181FA12B0")]
	[CompilerGenerated]
	private bool MPJENCHPNDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EE80", Offset = "0x1F9E280", VA = "0x181F9EE80")]
	[CompilerGenerated]
	private void BKOFMNEAEMB(string OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1130", Offset = "0x1FA0530", VA = "0x181FA1130")]
	[CompilerGenerated]
	private bool MGJMIFMEIOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA01F0", Offset = "0x1F9F5F0", VA = "0x181FA01F0")]
	[CompilerGenerated]
	private bool JODPCJCFJEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1340", Offset = "0x1FA0740", VA = "0x181FA1340")]
	[CompilerGenerated]
	private bool OKOJBIIBCOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA00B0", Offset = "0x1F9F4B0", VA = "0x181FA00B0")]
	[CompilerGenerated]
	private int GLJAIEGFPNM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F5A0", Offset = "0x1F9E9A0", VA = "0x181F9F5A0")]
	[CompilerGenerated]
	private bool DKFAEGGJHGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F920", Offset = "0x1F9ED20", VA = "0x181F9F920")]
	[CompilerGenerated]
	private int EMLGCLOCBAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0100", Offset = "0x1F9F500", VA = "0x181FA0100")]
	[CompilerGenerated]
	private void JAABEFLADOG(object OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FFE0", Offset = "0x1F9F3E0", VA = "0x181F9FFE0")]
	[CompilerGenerated]
	private bool GHFPNIPJNDD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DAKOAIADDJF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class FOGHILCNGPL : ENEIGNLMIHO<CKDBJANDPGL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override OCGADGAFCAL NJHCNDGIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9A0F70", Offset = "0x9A0370", VA = "0x1809A0F70", Slot = "126")]
			get
			{
				return default(OCGADGAFCAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6D90", Offset = "0x1FA6190", VA = "0x181FA6D90")]
		public FOGHILCNGPL(NAAMCGEJGIP LMOEPHCOEOK, CKDBJANDPGL DJKNDPHDPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class KMJOLGPGCBF : JJOAMEIBCPP<HEIEJIMAFKB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAB60", Offset = "0x1FA9F60", VA = "0x181FAAB60")]
		public KMJOLGPGCBF(NAAMCGEJGIP LMOEPHCOEOK, HEIEJIMAFKB ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA9E0", Offset = "0x1FA9DE0", VA = "0x181FAA9E0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA990", Offset = "0x1FA9D90", VA = "0x181FAA990")]
		[CompilerGenerated]
		private bool GJAFELMNHAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA870", Offset = "0x1FA9C70", VA = "0x181FAA870")]
		[CompilerGenerated]
		private void BLOLFIIKIJI(bool OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class DOKGMHABIEL : JJOAMEIBCPP<FNKKKIBBMLO>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DANIDLLMNHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public DOKGMHABIEL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public DANIDLLMNHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2D90", Offset = "0x1FA2190", VA = "0x181FA2D90")]
			internal void DGKOKFDKCLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2DE0", Offset = "0x1FA21E0", VA = "0x181FA2DE0")]
			internal bool FLPJKIJGKLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2E30", Offset = "0x1FA2230", VA = "0x181FA2E30")]
			internal bool GGFGJHCDEGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2C70", Offset = "0x1FA2070", VA = "0x181FA2C70")]
			internal void BLEGDHBDGFH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA2E80", Offset = "0x1FA2280", VA = "0x181FA2E80")]
			internal bool NLGNKDDPHDF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FA34B0", Offset = "0x1FA28B0", VA = "0x181FA34B0")]
		public DOKGMHABIEL(NAAMCGEJGIP LMOEPHCOEOK, FNKKKIBBMLO ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3180", Offset = "0x1FA2580", VA = "0x181FA3180", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class OMCKAJMIBDL : JJOAMEIBCPP<KDKJKFKIIDP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class LMDIHCOGPIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public OMCKAJMIBDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LMDIHCOGPIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FABA60", Offset = "0x1FAAE60", VA = "0x181FABA60")]
			internal object DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB9E0", Offset = "0x1FAADE0", VA = "0x181FAB9E0")]
			internal bool CIBOKJGKDLO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FABB60", Offset = "0x1FAAF60", VA = "0x181FABB60")]
			internal void FLPJKIJGKLD(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FABE00", Offset = "0x1FAB200", VA = "0x181FABE00")]
			internal string GGFGJHCDEGP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB990", Offset = "0x1FAAD90", VA = "0x181FAB990")]
			internal IReadOnlyList<object> BLEGDHBDGFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FABF60", Offset = "0x1FAB360", VA = "0x181FABF60")]
			internal bool NLGNKDDPHDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1FABDB0", Offset = "0x1FAB1B0", VA = "0x181FABDB0")]
			internal bool GEJGFLFBEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB870", Offset = "0x1FAAC70", VA = "0x181FAB870")]
			internal void BDNCDJKOFEJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FAF730", Offset = "0x1FAEB30", VA = "0x181FAF730")]
		public OMCKAJMIBDL(NAAMCGEJGIP LMOEPHCOEOK, KDKJKFKIIDP ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEFD0", Offset = "0x1FAE3D0", VA = "0x181FAEFD0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GAFDLGANMGF : JJOAMEIBCPP<AHINGDOBMEE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class GDGGKDFAIKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public GAFDLGANMGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public GDGGKDFAIKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7660", Offset = "0x1FA6A60", VA = "0x181FA7660")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1FA76B0", Offset = "0x1FA6AB0", VA = "0x181FA76B0")]
			internal void FLPJKIJGKLD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1FA77D0", Offset = "0x1FA6BD0", VA = "0x181FA77D0")]
			internal bool GGFGJHCDEGP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FA75F0", Offset = "0x1FA69F0", VA = "0x181FA75F0")]
		public GAFDLGANMGF(NAAMCGEJGIP LMOEPHCOEOK, AHINGDOBMEE ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1FA73C0", Offset = "0x1FA67C0", VA = "0x181FA73C0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class FKNGNIGDMFH<TNode> : JJOAMEIBCPP<TNode> where TNode : notnull, OBDHFMIPLNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct IKLNAKEEAAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public FKNGNIGDMFH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3E72700", Offset = "0x3E71B00", VA = "0x183E72700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3E72AF0", Offset = "0x3E71EF0", VA = "0x183E72AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct IHONOMMEIKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public FKNGNIGDMFH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3E4B030", Offset = "0x3E4A430", VA = "0x183E4B030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3E4B420", Offset = "0x3E4A820", VA = "0x183E4B420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool IIGAFLJOAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override DFKPAEMPCKH<JHDIGLFOPPI>? ALINDLDJCPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3C21BF0", Offset = "0x3C20FF0", VA = "0x183C21BF0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C21BA0", Offset = "0x3C20FA0", VA = "0x183C21BA0")]
		protected FKNGNIGDMFH(NAAMCGEJGIP LMOEPHCOEOK, TNode ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C21790", Offset = "0x3C20B90", VA = "0x183C21790", Slot = "100")]
		[AsyncStateMachine(typeof(FKNGNIGDMFH<>.IKLNAKEEAAJ))]
		public override Task<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> AOJHDPGIPHF(string FIKHOKLHCII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C21B00", Offset = "0x3C20F00", VA = "0x183C21B00", Slot = "124")]
		public sealed override bool JICFJHONDFK(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C219C0", Offset = "0x3C20DC0", VA = "0x183C219C0", Slot = "112")]
		protected sealed override bool FODOAPJOCOL(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C21A60", Offset = "0x3C20E60", VA = "0x183C21A60", Slot = "113")]
		protected override bool IPCBEAGFHNH(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3C218B0", Offset = "0x3C20CB0", VA = "0x183C218B0", Slot = "101")]
		[AsyncStateMachine(typeof(FKNGNIGDMFH<>.IHONOMMEIKH))]
		public override Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> EKHJOAJFDPG(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class DFKGAJIGCCO : JLKFGINIJME<OGLAFFEFNFM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class CHLHGEILOLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public DFKGAJIGCCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public CHLHGEILOLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F9EB20", Offset = "0x1F9DF20", VA = "0x181F9EB20")]
			internal bool JDKBKLGDFCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F9EBA0", Offset = "0x1F9DFA0", VA = "0x181F9EBA0")]
			internal void LHHHAEBJJEA(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3120", Offset = "0x1FA2520", VA = "0x181FA3120")]
		public DFKGAJIGCCO(NAAMCGEJGIP LMOEPHCOEOK, OGLAFFEFNFM DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2ED0", Offset = "0x1FA22D0", VA = "0x181FA2ED0", Slot = "126")]
		protected override void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class OAHOFDDMGOO : AEMMAFKPMHP<CLDDJFJGBOL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1FADF30", Offset = "0x1FAD330", VA = "0x181FADF30")]
		public OAHOFDDMGOO(NAAMCGEJGIP LMOEPHCOEOK, CLDDJFJGBOL ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class AEMMAFKPMHP<TNode> : JJOAMEIBCPP<TNode> where TNode : notnull, CBMDCMNCPPA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct GFNDOAHODAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3D03330", Offset = "0x3D02730", VA = "0x183D03330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3D037C0", Offset = "0x3D02BC0", VA = "0x183D037C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct PJGCGHCIFGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x47EC890", Offset = "0x47EBC90", VA = "0x1847EC890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x47ECD00", Offset = "0x47EC100", VA = "0x1847ECD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct KAPEEDDGGPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x411CA40", Offset = "0x411BE40", VA = "0x18411CA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x411D0F0", Offset = "0x411C4F0", VA = "0x18411D0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class ALJHFCIOBCP
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
				public ALJHFCIOBCP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x359DF80", Offset = "0x359D380", VA = "0x18359DF80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public CJIKKDBPPII configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public ALJHFCIOBCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3D79C80", Offset = "0x3D79080", VA = "0x183D79C80")]
			internal bool BDNCDJKOFEJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3D79E00", Offset = "0x3D79200", VA = "0x183D79E00")]
			internal void DGKOKFDKCLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D79D60", Offset = "0x3D79160", VA = "0x183D79D60")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.ALJHFCIOBCP.<<BuildConfigMenuInternal>b__7>d))]
			internal void CIBOKJGKDLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3D7A0E0", Offset = "0x3D794E0", VA = "0x183D7A0E0")]
			internal bool FLPJKIJGKLD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class HJKGHAPKJDO
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
				public HJKGHAPKJDO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x359DC10", Offset = "0x359D010", VA = "0x18359DC10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
			public ALJHFCIOBCP CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HJKGHAPKJDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3D83180", Offset = "0x3D82580", VA = "0x183D83180")]
			internal void GGFGJHCDEGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			internal string BLEGDHBDGFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			internal void NLGNKDDPHDF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3D830E0", Offset = "0x3D824E0", VA = "0x183D830E0")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.HJKGHAPKJDO.<<BuildConfigMenuInternal>b__5>d))]
			internal void GEJGFLFBEDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class GACGNFIEOAF
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
				public GACGNFIEOAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x359D740", Offset = "0x359CB40", VA = "0x18359D740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
				public GACGNFIEOAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<PEGEEDBAAGD>, FAGGAEGFGFH>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x359D920", Offset = "0x359CD20", VA = "0x18359D920", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
				public GACGNFIEOAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<FMDFDHKLINA>, FAGGAEGFGFH>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x359D080", Offset = "0x359C480", VA = "0x18359D080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public CJIKKDBPPII configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public PMOBMPCNNFE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public HFCDJOHNIHH selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<BMDNBPIOCLK> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public HFCDJOHNIHH selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<BMDNBPIOCLK> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public GACGNFIEOAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFD80", Offset = "0x3CDF180", VA = "0x183CDFD80")]
			internal bool FJBKGGFHHME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3CE0070", Offset = "0x3CDF470", VA = "0x183CE0070")]
			internal void LIOGHNFGEJF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFED0", Offset = "0x3CDF2D0", VA = "0x183CDFED0")]
			internal bool IKHABBLCLCG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFDF0", Offset = "0x3CDF1F0", VA = "0x183CDFDF0")]
			internal bool FNMJGNNLGEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFE30", Offset = "0x3CDF230", VA = "0x183CDFE30")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.GACGNFIEOAF.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void IFKBABBMDEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFD40", Offset = "0x3CDF140", VA = "0x183CDFD40")]
			internal bool FDPDHBHGJLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFB70", Offset = "0x3CDEF70", VA = "0x183CDFB70")]
			internal void DDOBNONHCCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3CE0190", Offset = "0x3CDF590", VA = "0x183CE0190")]
			internal bool OMAHIGNOAIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3CDF9D0", Offset = "0x3CDEDD0", VA = "0x183CDF9D0")]
			internal void AKDPFEEBHII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3CE00E0", Offset = "0x3CDF4E0", VA = "0x183CE00E0")]
			internal bool NOFEKPCAHFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFA90", Offset = "0x3CDEE90", VA = "0x183CDFA90")]
			internal bool BMEPCJKBOPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3CE02E0", Offset = "0x3CDF6E0", VA = "0x183CE02E0")]
			internal void PMHHJIJCGDC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFC30", Offset = "0x3CDF030", VA = "0x183CDFC30")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.GACGNFIEOAF.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void DPAAMLFBGID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFFB0", Offset = "0x3CDF3B0", VA = "0x183CDFFB0")]
			internal bool JJBKCLFHGEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFB00", Offset = "0x3CDEF00", VA = "0x183CDFB00")]
			internal bool CMBGIDCOGEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3CDFCD0", Offset = "0x3CDF0D0", VA = "0x183CDFCD0")]
			internal void EOGHHJLPICC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3CE0240", Offset = "0x3CDF640", VA = "0x183CE0240")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.GACGNFIEOAF.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void PJOFLMLAAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3CE0010", Offset = "0x3CDF410", VA = "0x183CE0010")]
			internal bool JKFEHNGPDKN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class MCLJHJKFLIL
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
				public MCLJHJKFLIL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x359D370", Offset = "0x359C770", VA = "0x18359D370", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
			public GACGNFIEOAF CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public MCLJHJKFLIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x442A8D0", Offset = "0x4429CD0", VA = "0x18442A8D0")]
			internal void ONKEDBFJNBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			internal string MLJHJFHOBHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			internal void CCFDJJOIMIC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x442A830", Offset = "0x4429C30", VA = "0x18442A830")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.MCLJHJKFLIL.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void MHKBMHEAKBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class FPPNHPOBBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public PMOBMPCNNFE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<BMDNBPIOCLK> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AEMMAFKPMHP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public FPPNHPOBBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3C3DD80", Offset = "0x3C3D180", VA = "0x183C3DD80")]
			internal bool CAGFPCELKIG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class DOFEJKEGHHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ADNGLOCCGKN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public FPPNHPOBBFP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public DOFEJKEGHHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x57AD720", Offset = "0x57ACB20", VA = "0x1857AD720")]
			internal void LGDCJLILAIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x57AD6D0", Offset = "0x57ACAD0", VA = "0x1857AD6D0")]
			internal bool DEILKIJKJAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x57AD5B0", Offset = "0x57AC9B0", VA = "0x1857AD5B0")]
			internal void BIKDEPNMAID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x57AD830", Offset = "0x57ACC30", VA = "0x1857AD830")]
			internal bool PAGIDJALIEP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class LJPNEHDIOAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public BMDNBPIOCLK portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public DOFEJKEGHHO CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LJPNEHDIOAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x423F0D0", Offset = "0x423E4D0", VA = "0x18423F0D0")]
			internal void AMNOPEJHOLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class EHFBOJGCOIH
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
				public EHFBOJGCOIH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x359F3B0", Offset = "0x359E7B0", VA = "0x18359F3B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
			public HFCDJOHNIHH selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PMOBMPCNNFE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public ADNGLOCCGKN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public EHFBOJGCOIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x38070D0", Offset = "0x38064D0", VA = "0x1838070D0")]
			internal int COFCDAHIPNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x38072B0", Offset = "0x38066B0", VA = "0x1838072B0")]
			internal void NEANLLBMMPH(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
			internal string FFIAKIOGJNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3807110", Offset = "0x3806510", VA = "0x183807110")]
			[AsyncStateMachine(typeof(AEMMAFKPMHP<>.EHFBOJGCOIH.<<CreatePortItemV2>b__3>d))]
			internal void FJALMOIPHBP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x38071D0", Offset = "0x38065D0", VA = "0x1838071D0")]
			internal bool MEFKMFLFPGH(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> OHOGJADENHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> IDLOJAGGFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> HCKEKFFIADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> JLDFNFBKJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> CKPNKMIGOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<DFKPAEMPCKH<JHDIGLFOPPI>, bool> GJBNDPGOAMN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool HDJAAOFDMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool IMLBDLBNFHL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool HEHPECMGAAH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool OFJHIDCFNGH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override DFKPAEMPCKH<JJIBBLMHJAE>? IOJLAJPNIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3CD1220", Offset = "0x3CD0620", VA = "0x183CD1220", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override DFKPAEMPCKH<JHDIGLFOPPI>? ALINDLDJCPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3CD14F0", Offset = "0x3CD08F0", VA = "0x183CD14F0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<AACPCJLHLFB<CEAIECNFGDF>>? FAEIKGIBDBC
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3CD12E0", Offset = "0x3CD06E0", VA = "0x183CD12E0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1000", Offset = "0x3CD0400", VA = "0x183CD1000")]
		public AEMMAFKPMHP(NAAMCGEJGIP LMOEPHCOEOK, TNode ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "129")]
		protected virtual bool BFNKBDAJPIE(int NNOEFINFJON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "130")]
		protected virtual bool ANFLPLPNJIH(int NNOEFINFJON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "131")]
		protected virtual bool DLAAJEHDLGE(int NNOEFINFJON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "132")]
		protected virtual void AEHAKAEHFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDAA0", Offset = "0x3CCCEA0", VA = "0x183CCDAA0", Slot = "124")]
		public override bool JICFJHONDFK(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC670", Offset = "0x3CCBA70", VA = "0x183CCC670", Slot = "100")]
		[AsyncStateMachine(typeof(AEMMAFKPMHP<>.GFNDOAHODAH))]
		public override Task<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> AOJHDPGIPHF(string FIKHOKLHCII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCA20", Offset = "0x3CCBE20", VA = "0x183CCCA20", Slot = "101")]
		[AsyncStateMachine(typeof(AEMMAFKPMHP<>.PJGCGHCIFGD))]
		public override Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> EKHJOAJFDPG(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC820", Offset = "0x3CCBC20", VA = "0x183CCC820", Slot = "102")]
		public override void EBNKLHAJDPA(DFKPAEMPCKH<JHDIGLFOPPI> AGAGKNBDCIG, DFKPAEMPCKH<JHDIGLFOPPI> KMCPIOGEAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCDD0", Offset = "0x3CCC1D0", VA = "0x183CCCDD0", Slot = "103")]
		public override IEnumerable<CIAJNHMHPBB> FPPBLGHBIGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF5D0", Offset = "0x3CCE9D0", VA = "0x183CCF5D0")]
		[AsyncStateMachine(typeof(AEMMAFKPMHP<>.KAPEEDDGGPM))]
		private Task<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> MKELCJHIJEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "133")]
		protected virtual bool LJNNJNAEPLB(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "134")]
		protected virtual bool IMDNHOOCPHF(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "135")]
		protected virtual bool KJGEMJJHPPJ(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "136")]
		protected virtual bool OHFNDAFILDK(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "137")]
		protected virtual bool HDFAJOOKFGH(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int OCADMAMKCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "138")]
		protected virtual bool MKKNBIOBJJA(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int OCADMAMKCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "139")]
		protected virtual bool CPPPFHJPJNF(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int HNBJBEAMCJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "140")]
		protected virtual bool IFLEIPPPOHL(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int HNBJBEAMCJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "141")]
		protected virtual bool CKKICDBCDJG(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int OGEMJMHDFLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "142")]
		protected virtual bool DBFEGMFEEOP(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, int OCOBGNMIFDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCB30", Offset = "0x3CCBF30", VA = "0x183CCCB30", Slot = "143")]
		protected virtual List<HFCDJOHNIHH> FEHHHABKJBB(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "144")]
		protected virtual void GHPLAOBBGGP(CJIKKDBPPII FOKEKPJLMIN, PLFIICAEIGC FCHJCGEICMM, PMOBMPCNNFE BKHBLKJFKKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD040", Offset = "0x3CCC440", VA = "0x183CCD040", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF6D0", Offset = "0x3CCEAD0", VA = "0x183CCF6D0")]
		private PLFIICAEIGC OHBBHCCFFHP(CJIKKDBPPII FOKEKPJLMIN, PMOBMPCNNFE BKHBLKJFKKC, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE490", Offset = "0x3CCD890", VA = "0x183CCE490")]
		private List<BMDNBPIOCLK> LEOHKCFIINI(CJIKKDBPPII FOKEKPJLMIN, PMOBMPCNNFE BKHBLKJFKKC, PLFIICAEIGC AOOJJFFFOAP, bool BFGMEIFFLLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDB40", Offset = "0x3CCCF40", VA = "0x183CCDB40")]
		private List<BMDNBPIOCLK> KKBNGIJNAAP(CJIKKDBPPII FOKEKPJLMIN, PMOBMPCNNFE BKHBLKJFKKC, ADNGLOCCGKN HDOKGLCAPFN, bool BFGMEIFFLLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0E10", Offset = "0x3CD0210", VA = "0x183CD0E10")]
		private HFCDJOHNIHH OHIHLEMMDCD(List<HFCDJOHNIHH> PCJADLELIIC, ADNGLOCCGKN HDOKGLCAPFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC790", Offset = "0x3CCBB90", VA = "0x183CCC790")]
		[CompilerGenerated]
		private CIAJNHMHPBB DCNDPDOONAI(DOGMMAIBEOG CBBBHLKBJGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class EAIKFPJAPPD : JJOAMEIBCPP<FHFCKICNLAM>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class FHDENKMKDGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public EAIKFPJAPPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public FHDENKMKDGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1FA6CB0", Offset = "0x1FA60B0", VA = "0x181FA6CB0")]
			internal int DGKOKFDKCLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1FA6D00", Offset = "0x1FA6100", VA = "0x181FA6D00")]
			internal void FLPJKIJGKLD(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1FA36E0", Offset = "0x1FA2AE0", VA = "0x181FA36E0")]
		public EAIKFPJAPPD(NAAMCGEJGIP LMOEPHCOEOK, FHFCKICNLAM ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3520", Offset = "0x1FA2920", VA = "0x181FA3520", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class FPNLDNLDEGE : JLKFGINIJME<LHOOFFOABHF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class APJBMHGILBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public FPNLDNLDEGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public APJBMHGILBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E0A0", Offset = "0x1F9D4A0", VA = "0x181F9E0A0")]
			internal int JDKBKLGDFCE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E120", Offset = "0x1F9D520", VA = "0x181F9E120")]
			internal void LHHHAEBJJEA(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7030", Offset = "0x1FA6430", VA = "0x181FA7030")]
		public FPNLDNLDEGE(NAAMCGEJGIP LMOEPHCOEOK, LHOOFFOABHF DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6DF0", Offset = "0x1FA61F0", VA = "0x181FA6DF0", Slot = "126")]
		protected override void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class MNJFGHGHNBB : JJOAMEIBCPP<GIBHGBCPCEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9691A0", Offset = "0x9685A0", VA = "0x1809691A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC4A0", Offset = "0x1FAB8A0", VA = "0x181FAC4A0")]
		public MNJFGHGHNBB(NAAMCGEJGIP LMOEPHCOEOK, GIBHGBCPCEI ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class EMFGEPBECDP : JJOAMEIBCPP<BEMPACJPCOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class PNKHDPHPJMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public EMFGEPBECDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public CJIKKDBPPII configure;

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
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public PNKHDPHPJMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0FB0", Offset = "0x1FB03B0", VA = "0x181FB0FB0")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB18C0", Offset = "0x1FB0CC0", VA = "0x181FB18C0")]
			internal void FLPJKIJGKLD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA5E0", Offset = "0x1FB99E0", VA = "0x181FBA5E0")]
			internal bool NLGNKDDPHDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1A60", Offset = "0x1FB0E60", VA = "0x181FB1A60")]
			internal bool GEJGFLFBEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0640", Offset = "0x1FAFA40", VA = "0x181FB0640")]
			internal void BDNCDJKOFEJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA010", Offset = "0x1FB9410", VA = "0x181FBA010")]
			internal bool MNPACKNHEEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9F70", Offset = "0x1FB9370", VA = "0x181FB9F70")]
			internal bool MJCHHEGMKCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBACA0", Offset = "0x1FBA0A0", VA = "0x181FBACA0")]
			internal void PAMGAGNNFML(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA630", Offset = "0x1FB9A30", VA = "0x181FBA630")]
			internal bool NLHFMLGBCNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB08A0", Offset = "0x1FAFCA0", VA = "0x181FB08A0")]
			internal bool BMCPFCICGPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8360", Offset = "0x1FB7760", VA = "0x181FB8360")]
			internal void HEIAHKJNMEN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7D50", Offset = "0x1FB7150", VA = "0x181FB7D50")]
			internal bool GIHBGKGBNKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1660", Offset = "0x1FB0A60", VA = "0x181FB1660")]
			internal bool FDEGKHACFAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8460", Offset = "0x1FB7860", VA = "0x181FB8460")]
			internal bool HIJECOIPNHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8500", Offset = "0x1FB7900", VA = "0x181FB8500")]
			internal bool HKFEJOADOBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB04A0", Offset = "0x1FAF8A0", VA = "0x181FB04A0")]
			internal bool AMMKLGMDMMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8860", Offset = "0x1FB7C60", VA = "0x181FB8860")]
			internal bool IJPNHHNIOCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB17C0", Offset = "0x1FB0BC0", VA = "0x181FB17C0")]
			internal bool FGHBOKAFMJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB98B0", Offset = "0x1FB8CB0", VA = "0x181FB98B0")]
			internal bool MAODBMANAEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA250", Offset = "0x1FB9650", VA = "0x181FBA250")]
			internal bool NEAPJMPLMJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB03A0", Offset = "0x1FAF7A0", VA = "0x181FB03A0")]
			internal void AIPAKNNKBFI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9610", Offset = "0x1FB8A10", VA = "0x181FB9610")]
			internal bool LKKNLJCPHKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA8A0", Offset = "0x1FB9CA0", VA = "0x181FBA8A0")]
			internal bool OCIJBBOJGOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8410", Offset = "0x1FB7810", VA = "0x181FB8410")]
			internal bool HHKIIPKAEGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0300", Offset = "0x1FAF700", VA = "0x181FB0300")]
			internal bool AGLGPJBLHAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1230", Offset = "0x1FB0630", VA = "0x181FB1230")]
			internal bool DPKIIBMHBOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB14C0", Offset = "0x1FB08C0", VA = "0x181FB14C0")]
			internal bool EPCDGNFFGCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0850", Offset = "0x1FAFC50", VA = "0x181FB0850")]
			internal bool BIGJDACJLIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0960", Offset = "0x1FAFD60", VA = "0x181FB0960")]
			internal bool CEBNMNCGHJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB10A0", Offset = "0x1FB04A0", VA = "0x181FB10A0")]
			internal void DMJIJMLBACH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA590", Offset = "0x1FB9990", VA = "0x181FBA590")]
			internal bool NJMGBHDHKCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8700", Offset = "0x1FB7B00", VA = "0x181FB8700")]
			internal bool IFDMKBLIDDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9170", Offset = "0x1FB8570", VA = "0x181FB9170")]
			internal void KILEGJGMPJN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB92D0", Offset = "0x1FB86D0", VA = "0x181FB92D0")]
			internal bool KOHHDLALEMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9900", Offset = "0x1FB8D00", VA = "0x181FB9900")]
			internal bool MCCGIEBALJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA1A0", Offset = "0x1FB95A0", VA = "0x181FBA1A0")]
			internal void NDAFFMJGCDA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1AB0", Offset = "0x1FB0EB0", VA = "0x181FB1AB0")]
			internal List<BMDNBPIOCLK> GFCAKJJMAOP(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1610", Offset = "0x1FB0A10", VA = "0x181FB1610")]
			internal bool FDCFGCOGDHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8ED0", Offset = "0x1FB82D0", VA = "0x181FB8ED0")]
			internal int JPDCJKCLPIK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBABF0", Offset = "0x1FB9FF0", VA = "0x181FBABF0")]
			internal void OPNNEAMMHOM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAD50", Offset = "0x1FBA150", VA = "0x181FBAD50")]
			internal bool PFINLAMPLHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA310", Offset = "0x1FB9710", VA = "0x181FBA310")]
			internal bool NFIKDNCEJEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB93C0", Offset = "0x1FB87C0", VA = "0x181FB93C0")]
			internal bool LAFEBALKOKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA360", Offset = "0x1FB9760", VA = "0x181FBA360")]
			internal int NGENAILHKKP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9020", Offset = "0x1FB8420", VA = "0x181FB9020")]
			internal void KEGJOLFKGAP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9810", Offset = "0x1FB8C10", VA = "0x181FB9810")]
			internal bool LOAALJHKIFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8E80", Offset = "0x1FB8280", VA = "0x181FB8E80")]
			internal bool JOIFHLEAEBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAB00", Offset = "0x1FB9F00", VA = "0x181FBAB00")]
			internal bool OLADGOIDJNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1050", Offset = "0x1FB0450", VA = "0x181FB1050")]
			internal bool DLJDPCBIEDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0AF0", Offset = "0x1FAFEF0", VA = "0x181FB0AF0")]
			internal bool CIBLGNFLCJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0C80", Offset = "0x1FB0080", VA = "0x181FB0C80")]
			internal bool CNEDKAHLMGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9370", Offset = "0x1FB8770", VA = "0x181FB9370")]
			internal string KPBMPCJGAFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB87F0", Offset = "0x1FB7BF0", VA = "0x181FB87F0")]
			internal void IJJJDAIPPHI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0A50", Offset = "0x1FAFE50", VA = "0x181FB0A50")]
			internal int CHHCHFOHLKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E50", Offset = "0x1FB9250", VA = "0x181FB9E50")]
			internal void MILMMILBPGC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0AA0", Offset = "0x1FAFEA0", VA = "0x181FB0AA0")]
			internal bool CHNNHNBKKEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB99A0", Offset = "0x1FB8DA0", VA = "0x181FB99A0")]
			internal bool MFKAFKKMDNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1570", Offset = "0x1FB0970", VA = "0x181FB1570")]
			internal bool EPHNIJJIFFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1000", Offset = "0x1FB0400", VA = "0x181FB1000")]
			internal float DIEMLJDDGEI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1280", Offset = "0x1FB0680", VA = "0x181FB1280")]
			internal void DPMDEGICJBK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0740", Offset = "0x1FAFB40", VA = "0x181FB0740")]
			internal bool BFLJLCJCGEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAE50", Offset = "0x1FBA250", VA = "0x181FBAE50")]
			internal bool PIMBMJJAPDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0200", Offset = "0x1FAF600", VA = "0x181FB0200")]
			internal bool ABMJENDADBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA450", Offset = "0x1FB9850", VA = "0x181FBA450")]
			internal bool NGPANCECKMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8A80", Offset = "0x1FB7E80", VA = "0x181FB8A80")]
			internal bool INJNOMCPJDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB85F0", Offset = "0x1FB79F0", VA = "0x181FB85F0")]
			internal bool IAJAGCMDDIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9A90", Offset = "0x1FB8E90", VA = "0x181FB9A90")]
			internal void MIDOJJEFMHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0B90", Offset = "0x1FAFF90", VA = "0x181FB0B90")]
			internal string CIOODMDGKHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9F00", Offset = "0x1FB9300", VA = "0x181FB9F00")]
			internal void MJBCHCOEEDC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0EC0", Offset = "0x1FB02C0", VA = "0x181FB0EC0")]
			internal bool DDOINDHKPCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8640", Offset = "0x1FB7A40", VA = "0x181FB8640")]
			internal bool IDEKCGICEBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB83C0", Offset = "0x1FB77C0", VA = "0x181FB83C0")]
			internal bool HGCPFPBCNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7DF0", Offset = "0x1FB71F0", VA = "0x181FB7DF0")]
			internal void GKFILAJMGDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1150", Offset = "0x1FB0550", VA = "0x181FB1150")]
			internal bool DODHFKFLAHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0800", Offset = "0x1FAFC00", VA = "0x181FB0800")]
			internal bool BHCKMGAKKGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0BE0", Offset = "0x1FAFFE0", VA = "0x181FB0BE0")]
			internal bool CKCMJOJPIBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB84B0", Offset = "0x1FB78B0", VA = "0x181FB84B0")]
			internal bool HJNFCLPDJAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8220", Offset = "0x1FB7620", VA = "0x181FB8220")]
			internal void GNELJIGGIDK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB19C0", Offset = "0x1FB0DC0", VA = "0x181FB19C0")]
			internal bool GDHCJJAECBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB97C0", Offset = "0x1FB8BC0", VA = "0x181FB97C0")]
			internal bool LNLEDNPEJBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA0B0", Offset = "0x1FB94B0", VA = "0x181FBA0B0")]
			internal bool MPJDAMAPEIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA4F0", Offset = "0x1FB98F0", VA = "0x181FBA4F0")]
			internal bool NJANAENDIFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8DD0", Offset = "0x1FB81D0", VA = "0x181FB8DD0")]
			internal void JJNBDOFOJIC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8AD0", Offset = "0x1FB7ED0", VA = "0x181FB8AD0")]
			internal bool IPEJPDHOLNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA200", Offset = "0x1FB9600", VA = "0x181FBA200")]
			internal bool NDDELPOGDOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8900", Offset = "0x1FB7D00", VA = "0x181FB8900")]
			internal bool IKDKNMHDPPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB06F0", Offset = "0x1FAFAF0", VA = "0x181FB06F0")]
			internal bool BFFJOEBDGGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0400", Offset = "0x1FAF800", VA = "0x181FB0400")]
			internal int AJDFNHLKNIO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8C80", Offset = "0x1FB8080", VA = "0x181FB8C80")]
			internal void JFABDNAPMJD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB90D0", Offset = "0x1FB84D0", VA = "0x181FB90D0")]
			internal bool KHMDDCNHPAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9860", Offset = "0x1FB8C60", VA = "0x181FB9860")]
			internal bool LOIKLBILHGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA100", Offset = "0x1FB9500", VA = "0x181FBA100")]
			internal int NAFHEIEAGOA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9220", Offset = "0x1FB8620", VA = "0x181FB9220")]
			internal void KMHFGDKAIFI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA150", Offset = "0x1FB9550", VA = "0x181FBA150")]
			internal bool NBGOCPLLJCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB80C0", Offset = "0x1FB74C0", VA = "0x181FB80C0")]
			internal bool GKPOMPGJACO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA4A0", Offset = "0x1FB98A0", VA = "0x181FBA4A0")]
			internal int NHADOBEDAMM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1510", Offset = "0x1FB0910", VA = "0x181FB1510")]
			internal void EPGMMAHLKIC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9660", Offset = "0x1FB8A60", VA = "0x181FB9660")]
			internal bool LLIKDBFDGIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAF90", Offset = "0x1FBA390", VA = "0x181FBAF90")]
			internal bool PPGPEBIIJEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB06A0", Offset = "0x1FAFAA0", VA = "0x181FB06A0")]
			internal bool BEOENBHMFIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1100", Offset = "0x1FB0500", VA = "0x181FB1100")]
			internal int DOBEAKOOLAC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1810", Offset = "0x1FB0C10", VA = "0x181FB1810")]
			internal void FJGDIFFKKIK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9320", Offset = "0x1FB8720", VA = "0x181FB9320")]
			internal bool KOIBCINPGNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1FB91D0", Offset = "0x1FB85D0", VA = "0x181FB91D0")]
			internal bool KKKPMKAABKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1FB01B0", Offset = "0x1FAF5B0", VA = "0x181FB01B0")]
			internal bool ABKIOLCKNKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1FB08F0", Offset = "0x1FAFCF0", VA = "0x181FB08F0")]
			internal object CBFLKGJOICO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1FB11A0", Offset = "0x1FB05A0", VA = "0x181FB11A0")]
			internal void DOJMCHBKLFF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9080", Offset = "0x1FB8480", VA = "0x181FB9080")]
			internal bool KHLKMAJFHOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0F10", Offset = "0x1FB0310", VA = "0x181FB0F10")]
			internal bool DELINILIGML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA680", Offset = "0x1FB9A80", VA = "0x181FBA680")]
			internal object NMBECKLKJEK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1FB89F0", Offset = "0x1FB7DF0", VA = "0x181FB89F0")]
			internal void IMIJPLAKEKF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAC50", Offset = "0x1FBA050", VA = "0x181FBAC50")]
			internal bool PABCKFODCHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9120", Offset = "0x1FB8520", VA = "0x181FB9120")]
			internal int KHOMFOJDFGC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0540", Offset = "0x1FAF940", VA = "0x181FB0540")]
			internal void AOGLMFGDCLA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA6F0", Offset = "0x1FB9AF0", VA = "0x181FBA6F0")]
			internal bool NNOKPHAGBBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAEF0", Offset = "0x1FBA2F0", VA = "0x181FBAEF0")]
			internal bool PMKDJAOAFDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA7B0", Offset = "0x1FB9BB0", VA = "0x181FBA7B0")]
			internal bool NPDMNEGBBLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA8F0", Offset = "0x1FB9CF0", VA = "0x181FBA8F0")]
			internal int OEAEJKOGGGA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0CD0", Offset = "0x1FB00D0", VA = "0x181FB0CD0")]
			internal void CODKEAODFLI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1FB88B0", Offset = "0x1FB7CB0", VA = "0x181FB88B0")]
			internal bool IKBBEDCDJNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9A40", Offset = "0x1FB8E40", VA = "0x181FB9A40")]
			internal bool MHJDPIDPFCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8C30", Offset = "0x1FB8030", VA = "0x181FB8C30")]
			internal bool JECEGGFEMKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0350", Offset = "0x1FAF750", VA = "0x181FB0350")]
			internal float AHKPBBMABPN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1FB02A0", Offset = "0x1FAF6A0", VA = "0x181FB02A0")]
			internal void ADONDBJDEKC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0D80", Offset = "0x1FB0180", VA = "0x181FB0D80")]
			internal bool CPOOELDGDED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1FB94B0", Offset = "0x1FB88B0", VA = "0x181FB94B0")]
			internal bool LIINBPDEKBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1380", Offset = "0x1FB0780", VA = "0x181FB1380")]
			internal bool EEAMLAPKECF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAB50", Offset = "0x1FB9F50", VA = "0x181FBAB50")]
			internal float OLCJGNPLENB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1FBADF0", Offset = "0x1FBA1F0", VA = "0x181FBADF0")]
			internal void PILGPFMLABH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB15C0", Offset = "0x1FB09C0", VA = "0x181FB15C0")]
			internal bool FAFLLBIBIHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1870", Offset = "0x1FB0C70", VA = "0x181FB1870")]
			internal bool FJIEPLDGMEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAEA0", Offset = "0x1FBA2A0", VA = "0x181FBAEA0")]
			internal string PKGEIBKFKAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8690", Offset = "0x1FB7A90", VA = "0x181FB8690")]
			internal void IFCCHOINALA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1FBABA0", Offset = "0x1FB9FA0", VA = "0x181FBABA0")]
			internal bool OMEPJPKLJDK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1420", Offset = "0x1FB0820", VA = "0x181FB1420")]
			internal bool EMOCPMKBEIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9460", Offset = "0x1FB8860", VA = "0x181FB9460")]
			internal bool LIDNEENJEIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1970", Offset = "0x1FB0D70", VA = "0x181FB1970")]
			internal bool GCIOHIELAJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9550", Offset = "0x1FB8950", VA = "0x181FB9550")]
			internal string LJKHKODBJOI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8110", Offset = "0x1FB7510", VA = "0x181FB8110")]
			internal void GLALCMJDDIK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0E20", Offset = "0x1FB0220", VA = "0x181FB0E20")]
			internal bool DCBBGEJKKOH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8180", Offset = "0x1FB7580", VA = "0x181FB8180")]
			internal bool GLLOMJOLHGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1330", Offset = "0x1FB0730", VA = "0x181FB1330")]
			internal bool EDNNFCKENIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7DA0", Offset = "0x1FB71A0", VA = "0x181FB7DA0")]
			internal bool GJFBJMEHPAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1FB96B0", Offset = "0x1FB8AB0", VA = "0x181FB96B0")]
			internal string LLKCKAPCOAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8280", Offset = "0x1FB7680", VA = "0x181FB8280")]
			internal void HDDFIAEEHMM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA800", Offset = "0x1FB9C00", VA = "0x181FBA800")]
			internal bool NPMABKIIEDB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8950", Offset = "0x1FB7D50", VA = "0x181FB8950")]
			internal bool ILCAGJHGOEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB87A0", Offset = "0x1FB7BA0", VA = "0x181FB87A0")]
			internal bool IJAPOCKCLHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA060", Offset = "0x1FB9460", VA = "0x181FBA060")]
			internal bool MOCJBJLMFJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA990", Offset = "0x1FB9D90", VA = "0x181FBA990")]
			internal string OEKLPKPIOIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1FB82F0", Offset = "0x1FB76F0", VA = "0x181FB82F0")]
			internal void HDNBOJDJGHM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0A00", Offset = "0x1FAFE00", VA = "0x181FB0A00")]
			internal bool CGPMDIBMIJP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1FB05F0", Offset = "0x1FAF9F0", VA = "0x181FB05F0")]
			internal bool BDMHKKPKBGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAD00", Offset = "0x1FBA100", VA = "0x181FBAD00")]
			internal bool PDHGONGDLCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA540", Offset = "0x1FB9940", VA = "0x181FBA540")]
			internal bool NJDDOMIBDAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9500", Offset = "0x1FB8900", VA = "0x181FB9500")]
			internal string LJFKKCKJJAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9700", Offset = "0x1FB8B00", VA = "0x181FB9700")]
			internal void LNBIGGKGDEF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1FB09B0", Offset = "0x1FAFDB0", VA = "0x181FB09B0")]
			internal bool CEFHBLIMFFN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8B70", Offset = "0x1FB7F70", VA = "0x181FB8B70")]
			internal bool JAJLFGECLIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8E30", Offset = "0x1FB8230", VA = "0x181FB8E30")]
			internal bool JLCCJANCOCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8F20", Offset = "0x1FB8320", VA = "0x181FB8F20")]
			internal bool KCDBPNHKBPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1920", Offset = "0x1FB0D20", VA = "0x181FB1920")]
			internal string FPKMJGKPHLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA2A0", Offset = "0x1FB96A0", VA = "0x181FBA2A0")]
			internal void NECEJEJOMEH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1A10", Offset = "0x1FB0E10", VA = "0x181FB1A10")]
			internal bool GEBLKKCMAKB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA400", Offset = "0x1FB9800", VA = "0x181FBA400")]
			internal bool NGOPFJOPEAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1470", Offset = "0x1FB0870", VA = "0x181FB1470")]
			internal bool ENJGHBLIBNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9770", Offset = "0x1FB8B70", VA = "0x181FB9770")]
			internal bool LNCJHIFJEJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0DD0", Offset = "0x1FB01D0", VA = "0x181FB0DD0")]
			internal string DABDJKJKGMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8D60", Offset = "0x1FB8160", VA = "0x181FB8D60")]
			internal void JIHEIOLHBMN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8FD0", Offset = "0x1FB83D0", VA = "0x181FB8FD0")]
			internal bool KDHMKJPJBBJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0C30", Offset = "0x1FB0030", VA = "0x181FB0C30")]
			internal bool CMCEBOHHLML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1FB81D0", Offset = "0x1FB75D0", VA = "0x181FB81D0")]
			internal bool GMJANAMONED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9280", Offset = "0x1FB8680", VA = "0x181FB9280")]
			internal bool KNGPKPMBJPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7CB0", Offset = "0x1FB70B0", VA = "0x181FB7CB0")]
			internal string GGGJGCOOLIN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1FB95A0", Offset = "0x1FB89A0", VA = "0x181FB95A0")]
			internal void LKBKGFKPHDB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1FBADA0", Offset = "0x1FBA1A0", VA = "0x181FBADA0")]
			internal bool PHKAAHJGCCE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7D00", Offset = "0x1FB7100", VA = "0x181FB7D00")]
			internal bool GHLEBBBFIJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB13D0", Offset = "0x1FB07D0", VA = "0x181FB13D0")]
			internal bool ELKLECFBEEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9950", Offset = "0x1FB8D50", VA = "0x181FB9950")]
			internal bool MDJONEOOPMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA3B0", Offset = "0x1FB97B0", VA = "0x181FBA3B0")]
			internal string NGFGPIKJFBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8BC0", Offset = "0x1FB7FC0", VA = "0x181FB8BC0")]
			internal void JAOAFIEEAKA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7C10", Offset = "0x1FB7010", VA = "0x181FB7C10")]
			internal bool GFNMJEAJFMF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1FB99F0", Offset = "0x1FB8DF0", VA = "0x181FB99F0")]
			internal bool MGCALEKNLCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA940", Offset = "0x1FB9D40", VA = "0x181FBA940")]
			internal bool OEKFGHNHMKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0E70", Offset = "0x1FB0270", VA = "0x181FB0E70")]
			internal bool DCEDICAMLAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9EB0", Offset = "0x1FB92B0", VA = "0x181FB9EB0")]
			internal string MINDPHJGBHG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0790", Offset = "0x1FAFB90", VA = "0x181FB0790")]
			internal void BGOGEFEPIKF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8B20", Offset = "0x1FB7F20", VA = "0x181FB8B20")]
			internal bool IPMFCMEFKON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9410", Offset = "0x1FB8810", VA = "0x181FB9410")]
			internal bool LCBFDGFJMFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0D30", Offset = "0x1FB0130", VA = "0x181FB0D30")]
			internal bool CPBHAOECGGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1FB05A0", Offset = "0x1FAF9A0", VA = "0x181FB05A0")]
			internal string BABDOKKPENO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1750", Offset = "0x1FB0B50", VA = "0x181FB1750")]
			internal void FEOEGIBILOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7C60", Offset = "0x1FB7060", VA = "0x181FB7C60")]
			internal bool GGDEGKILBCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0250", Offset = "0x1FAF650", VA = "0x181FB0250")]
			internal bool ADICAPDKGOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8750", Offset = "0x1FB7B50", VA = "0x181FB8750")]
			internal bool IGKKFJDCGLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8D10", Offset = "0x1FB8110", VA = "0x181FB8D10")]
			internal string JFFDMCIBELP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA740", Offset = "0x1FB9B40", VA = "0x181FBA740")]
			internal void NOLIMILJAAA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0B40", Offset = "0x1FAFF40", VA = "0x181FB0B40")]
			internal bool CIEGFPBODCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8550", Offset = "0x1FB7950", VA = "0x181FB8550")]
			internal bool HLDFENGNNCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0F60", Offset = "0x1FB0360", VA = "0x181FB0F60")]
			internal bool DENLJNLEHME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1FB89A0", Offset = "0x1FB7DA0", VA = "0x181FB89A0")]
			internal string ILDFCFDMHMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAA90", Offset = "0x1FB9E90", VA = "0x181FBAA90")]
			internal void OKLPCJKIIAO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1FB85A0", Offset = "0x1FB79A0", VA = "0x181FB85A0")]
			internal bool HLKDLFBGCCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA850", Offset = "0x1FB9C50", VA = "0x181FBA850")]
			internal bool OCEHDHAHBIG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAF40", Offset = "0x1FBA340", VA = "0x181FBAF40")]
			internal float PNMEPCMKFCG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAA30", Offset = "0x1FB9E30", VA = "0x181FBAA30")]
			internal void OHDOAOAECLE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9FC0", Offset = "0x1FB93C0", VA = "0x181FB9FC0")]
			internal bool MKJJIFEGICD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1FB12E0", Offset = "0x1FB06E0", VA = "0x181FB12E0")]
			internal bool EDNMMHJMPAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB16B0", Offset = "0x1FB0AB0", VA = "0x181FB16B0")]
			internal bool FDEMGBCPIEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0450", Offset = "0x1FAF850", VA = "0x181FB0450")]
			internal int ALPDAFLKPID()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8F70", Offset = "0x1FB8370", VA = "0x181FB8F70")]
			internal void KCLIJKPDLFP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA9E0", Offset = "0x1FB9DE0", VA = "0x181FBA9E0")]
			internal bool OFHMHDOGKMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB04F0", Offset = "0x1FAF8F0", VA = "0x181FB04F0")]
			internal bool ANHOEMJOGPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1700", Offset = "0x1FB0B00", VA = "0x181FB1700")]
			internal bool FDHJKFHJAFF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class OGMEOAFLHNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public PNKHDPHPJMM CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public OGMEOAFLHNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1FADF90", Offset = "0x1FAD390", VA = "0x181FADF90")]
			internal void EOEAFNCMOFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class NIJMPLOEHBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public NIJMPLOEHBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1FADE30", Offset = "0x1FAD230", VA = "0x181FADE30")]
			internal bool NLBJCEDKLLI(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly MMAHGGEIPDA MMDCLGGOOBM;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5F80", Offset = "0x1FA5380", VA = "0x181FA5F80")]
		public EMFGEPBECDP(NAAMCGEJGIP LMOEPHCOEOK, BEMPACJPCOJ ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1FA41A0", Offset = "0x1FA35A0", VA = "0x181FA41A0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class DGCCEFPGCKP : JJOAMEIBCPP<LHKJBAIFAIM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class PGOOGPDMLBC
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
				public PGOOGPDMLBC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1FD7D40", Offset = "0x1FD7140", VA = "0x181FD7D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public DGCCEFPGCKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public PGOOGPDMLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6CE0", Offset = "0x1FD60E0", VA = "0x181FD6CE0")]
			internal string DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6D30", Offset = "0x1FD6130", VA = "0x181FD6D30")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FLPJKIJGKLD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6E00", Offset = "0x1FD6200", VA = "0x181FD6E00")]
			internal int GGFGJHCDEGP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6C50", Offset = "0x1FD6050", VA = "0x181FD6C50")]
			internal void BLEGDHBDGFH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC41C0", Offset = "0x1FC35C0", VA = "0x181FC41C0")]
		public DGCCEFPGCKP(NAAMCGEJGIP LMOEPHCOEOK, LHKJBAIFAIM DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3E70", Offset = "0x1FC3270", VA = "0x181FC3E70", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class GCDHHPDNCMG : JJOAMEIBCPP<GMNCMJAPLGI>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class MNKBDFDNKND
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
				public MNKBDFDNKND <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1FD7A00", Offset = "0x1FD6E00", VA = "0x181FD7A00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
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
				public MNKBDFDNKND <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1FD8050", Offset = "0x1FD7450", VA = "0x181FD8050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public GCDHHPDNCMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public MNKBDFDNKND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4280", Offset = "0x1FD3680", VA = "0x181FD4280")]
			internal string DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4330", Offset = "0x1FD3730", VA = "0x181FD4330")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FLPJKIJGKLD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FD44D0", Offset = "0x1FD38D0", VA = "0x181FD44D0")]
			internal int GGFGJHCDEGP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FD40C0", Offset = "0x1FD34C0", VA = "0x181FD40C0")]
			internal void BLEGDHBDGFH(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4650", Offset = "0x1FD3A50", VA = "0x181FD4650")]
			internal string NLGNKDDPHDF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4400", Offset = "0x1FD3800", VA = "0x181FD4400")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void GEJGFLFBEDH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4070", Offset = "0x1FD3470", VA = "0x181FD4070")]
			internal bool BDNCDJKOFEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FD41F0", Offset = "0x1FD35F0", VA = "0x181FD41F0")]
			internal void CIBOKJGKDLO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4520", Offset = "0x1FD3920", VA = "0x181FD4520")]
			internal bool KHAEEIMKFKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FD45C0", Offset = "0x1FD39C0", VA = "0x181FD45C0")]
			internal void MNPACKNHEEH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4570", Offset = "0x1FD3970", VA = "0x181FD4570")]
			internal float MJCHHEGMKCL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4710", Offset = "0x1FD3B10", VA = "0x181FD4710")]
			internal void PAMGAGNNFML(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FD42D0", Offset = "0x1FD36D0", VA = "0x181FD42D0")]
			internal int FKDAOOFBLNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4150", Offset = "0x1FD3550", VA = "0x181FD4150")]
			internal void BPDCIEFMBJJ(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FD46A0", Offset = "0x1FD3AA0", VA = "0x181FD46A0")]
			internal bool NLHFMLGBCNN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCA70", Offset = "0x1FCBE70", VA = "0x181FCCA70")]
		public GCDHHPDNCMG(NAAMCGEJGIP LMOEPHCOEOK, GMNCMJAPLGI ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC030", Offset = "0x1FCB430", VA = "0x181FCC030", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class FOMHAOMNLCE : JJOAMEIBCPP<BBCFGJOIEMI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class BBKOPOJGAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public FOMHAOMNLCE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public BBKOPOJGAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2500", Offset = "0x1FC1900", VA = "0x181FC2500")]
			internal Dictionary<string, OLJDNHLONJI> DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC25A0", Offset = "0x1FC19A0", VA = "0x181FC25A0")]
			internal int FLPJKIJGKLD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC25F0", Offset = "0x1FC19F0", VA = "0x181FC25F0")]
			internal void GGFGJHCDEGP(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2480", Offset = "0x1FC1880", VA = "0x181FC2480")]
			internal bool BLEGDHBDGFH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBCA0", Offset = "0x1FCB0A0", VA = "0x181FCBCA0")]
		public FOMHAOMNLCE(NAAMCGEJGIP LMOEPHCOEOK, BBCFGJOIEMI DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB9D0", Offset = "0x1FCADD0", VA = "0x181FCB9D0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class EPIFGALGBKL : JJOAMEIBCPP<EOJGKBEGNIA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class NPJAHLCHHMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public EPIFGALGBKL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public NPJAHLCHHMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4F60", Offset = "0x1FD4360", VA = "0x181FD4F60")]
			internal void DGKOKFDKCLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5560", Offset = "0x1FC4960", VA = "0x181FC5560")]
		public EPIFGALGBKL(NAAMCGEJGIP LMOEPHCOEOK, EOJGKBEGNIA DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC53E0", Offset = "0x1FC47E0", VA = "0x181FC53E0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class CLCMPCHJFMO : AEMMAFKPMHP<GEEFGDHKDII>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool BDKLMNBFDOC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool BGMEHFIPHEH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3980", Offset = "0x1FC2D80", VA = "0x181FC3980", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9A84F0", Offset = "0x9A78F0", VA = "0x1809A84F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3920", Offset = "0x1FC2D20", VA = "0x181FC3920")]
		public CLCMPCHJFMO(NAAMCGEJGIP LMOEPHCOEOK, GEEFGDHKDII ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class PEAFDHICGBF : JJOAMEIBCPP<NAENDBFJJFC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x94DDB0", Offset = "0x94D1B0", VA = "0x18094DDB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FD65D0", Offset = "0x1FD59D0", VA = "0x181FD65D0")]
		public PEAFDHICGBF(NAAMCGEJGIP LMOEPHCOEOK, NAENDBFJJFC ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class FBOILHMNCLN : JJOAMEIBCPP<GCMFBNGKOHB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9A0160", Offset = "0x99F560", VA = "0x1809A0160", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FC55D0", Offset = "0x1FC49D0", VA = "0x181FC55D0")]
		public FBOILHMNCLN(NAAMCGEJGIP LMOEPHCOEOK, GCMFBNGKOHB ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "112")]
		protected override bool FODOAPJOCOL(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class OMCLDNGLFAB : JJOAMEIBCPP<NAFGMGFEOEE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9ADA30", Offset = "0x9ACE30", VA = "0x1809ADA30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool MIHBEEMNMLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FD5D40", Offset = "0x1FD5140", VA = "0x181FD5D40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool HMOIEPHOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5CD0", Offset = "0x1FD50D0", VA = "0x181FD5CD0")]
		public OMCLDNGLFAB(NAAMCGEJGIP LMOEPHCOEOK, NAFGMGFEOEE ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class DDOKCDJPKGG : JJOAMEIBCPP<NCNAPHBPJNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A0F70", Offset = "0x9A0370", VA = "0x1809A0F70", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool MIHBEEMNMLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3DB0", Offset = "0x1FC31B0", VA = "0x181FC3DB0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool HMOIEPHOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3D40", Offset = "0x1FC3140", VA = "0x181FC3D40")]
		public DDOKCDJPKGG(NAAMCGEJGIP LMOEPHCOEOK, NCNAPHBPJNJ ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class CDEJGDIGICC : JLKFGINIJME<ENJABKAEAAF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class CEFPLPHOHKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CDEJGDIGICC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public CEFPLPHOHKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3380", Offset = "0x1FC2780", VA = "0x181FC3380")]
			internal float JDKBKLGDFCE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3400", Offset = "0x1FC2800", VA = "0x181FC3400")]
			internal void LHHHAEBJJEA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3320", Offset = "0x1FC2720", VA = "0x181FC3320")]
		public CDEJGDIGICC(NAAMCGEJGIP LMOEPHCOEOK, ENJABKAEAAF DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FC30A0", Offset = "0x1FC24A0", VA = "0x181FC30A0", Slot = "126")]
		protected override void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class CKEFJHCKBOI : JJOAMEIBCPP<GDAHIHGMEBE>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class HEDEBGIHDIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public CKEFJHCKBOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HEDEBGIHDIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDB90", Offset = "0x1FCCF90", VA = "0x181FCDB90")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDBE0", Offset = "0x1FCCFE0", VA = "0x181FCDBE0")]
			internal void FLPJKIJGKLD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FC37C0", Offset = "0x1FC2BC0", VA = "0x181FC37C0")]
		public CKEFJHCKBOI(NAAMCGEJGIP LMOEPHCOEOK, GDAHIHGMEBE DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3510", Offset = "0x1FC2910", VA = "0x181FC3510", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class OCIFLCMPDDN : JJOAMEIBCPP<OIFCOCCCPGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class PHPCMNMMMEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public OCIFLCMPDDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public PHPCMNMMMEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FD7040", Offset = "0x1FD6440", VA = "0x181FD7040")]
			internal object DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6FC0", Offset = "0x1FD63C0", VA = "0x181FD6FC0")]
			internal bool CIBOKJGKDLO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FD7170", Offset = "0x1FD6570", VA = "0x181FD7170")]
			internal void FLPJKIJGKLD(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FD7410", Offset = "0x1FD6810", VA = "0x181FD7410")]
			internal string GGFGJHCDEGP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6F70", Offset = "0x1FD6370", VA = "0x181FD6F70")]
			internal IReadOnlyList<object> BLEGDHBDGFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FD7570", Offset = "0x1FD6970", VA = "0x181FD7570")]
			internal bool NLGNKDDPHDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FD73C0", Offset = "0x1FD67C0", VA = "0x181FD73C0")]
			internal bool GEJGFLFBEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6E50", Offset = "0x1FD6250", VA = "0x181FD6E50")]
			internal void BDNCDJKOFEJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5C60", Offset = "0x1FD5060", VA = "0x181FD5C60")]
		public OCIFLCMPDDN(NAAMCGEJGIP LMOEPHCOEOK, OIFCOCCCPGJ DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5430", Offset = "0x1FD4830", VA = "0x181FD5430", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class GIECPAPBJIH : FKNGNIGDMFH<HBOJGGGBCDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xB6D680", Offset = "0xB6CA80", VA = "0x180B6D680", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD200", Offset = "0x1FCC600", VA = "0x181FCD200")]
		public GIECPAPBJIH(NAAMCGEJGIP LMOEPHCOEOK, HBOJGGGBCDB ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class BJKBEOGNFGB : JLKFGINIJME<NAJFGDMKFKG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class DLGICAOBIEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public BJKBEOGNFGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public DLGICAOBIEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC4E40", Offset = "0x1FC4240", VA = "0x181FC4E40")]
			internal int JDKBKLGDFCE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC4EC0", Offset = "0x1FC42C0", VA = "0x181FC4EC0")]
			internal void LHHHAEBJJEA(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3040", Offset = "0x1FC2440", VA = "0x181FC3040")]
		public BJKBEOGNFGB(NAAMCGEJGIP LMOEPHCOEOK, NAJFGDMKFKG DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2DB0", Offset = "0x1FC21B0", VA = "0x181FC2DB0", Slot = "126")]
		protected override void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class GDGOKBNCOKK : JJOAMEIBCPP<PEEMNNEKPML>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class OPJGIGOIMGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public GDGOKBNCOKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public OPJGIGOIMGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6240", Offset = "0x1FD5640", VA = "0x181FD6240")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6290", Offset = "0x1FD5690", VA = "0x181FD6290")]
			internal void FLPJKIJGKLD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD190", Offset = "0x1FCC590", VA = "0x181FCD190")]
		public GDGOKBNCOKK(NAAMCGEJGIP LMOEPHCOEOK, PEEMNNEKPML DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCFB0", Offset = "0x1FCC3B0", VA = "0x181FCCFB0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class PEPMELIJOMF : JJOAMEIBCPP<HNMLFKMKLEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class MDHMDEDGBAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public PEPMELIJOMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public MDHMDEDGBAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3F90", Offset = "0x1FD3390", VA = "0x181FD3F90")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3FE0", Offset = "0x1FD33E0", VA = "0x181FD3FE0")]
			internal void FLPJKIJGKLD(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6820", Offset = "0x1FD5C20", VA = "0x181FD6820")]
		public PEPMELIJOMF(NAAMCGEJGIP LMOEPHCOEOK, HNMLFKMKLEN DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6640", Offset = "0x1FD5A40", VA = "0x181FD6640", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class AOJEOIAIEJP : JJOAMEIBCPP<JFAPCHLEPHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class HDBDBMMAFAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public AOJEOIAIEJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HDBDBMMAFAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDAB0", Offset = "0x1FCCEB0", VA = "0x181FCDAB0")]
			internal int DGKOKFDKCLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDB00", Offset = "0x1FCCF00", VA = "0x181FCDB00")]
			internal void FLPJKIJGKLD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2410", Offset = "0x1FC1810", VA = "0x181FC2410")]
		public AOJEOIAIEJP(NAAMCGEJGIP LMOEPHCOEOK, JFAPCHLEPHO DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1FC21B0", Offset = "0x1FC15B0", VA = "0x181FC21B0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ELODPPBDMOL : ENEIGNLMIHO<EAKHNCDCBNA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override OCGADGAFCAL NJHCNDGIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "126")]
			get
			{
				return default(OCGADGAFCAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5380", Offset = "0x1FC4780", VA = "0x181FC5380")]
		public ELODPPBDMOL(NAAMCGEJGIP LMOEPHCOEOK, EAKHNCDCBNA DJKNDPHDPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CGFOOHINNMH : JJOAMEIBCPP<DOGMMAIBEOG>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC34A0", Offset = "0x1FC28A0", VA = "0x181FC34A0")]
		public CGFOOHINNMH(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class JJOAMEIBCPP<TNode> : HNDBDOLBHDL, IDisposable where TNode : notnull, DOGMMAIBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class LAFOFOLGCIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public JJOAMEIBCPP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public NAAMCGEJGIP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LAFOFOLGCIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x42244E0", Offset = "0x42238E0", VA = "0x1842244E0")]
			internal FDMNMOMGKHK FKAMKKDMIEJ(IOGGAMPKBPH portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct DJFPOOCCFKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public JJOAMEIBCPP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x5795310", Offset = "0x5794710", VA = "0x185795310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct NCGKFPBCMMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public JJOAMEIBCPP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public CNAJHOMKMAP? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public DIOGKOPAFDE? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x44E84F0", Offset = "0x44E78F0", VA = "0x1844E84F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x44E8790", Offset = "0x44E7B90", VA = "0x1844E8790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class LAMOHCDCJLG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public LAMOHCDCJLG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x359E180", Offset = "0x359D580", VA = "0x18359E180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public JJOAMEIBCPP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public CJIKKDBPPII configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LAMOHCDCJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			internal string APJGANNBHBG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			internal void EAGOKLNNNMD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4226510", Offset = "0x4225910", VA = "0x184226510")]
			[AsyncStateMachine(typeof(JJOAMEIBCPP<>.LAMOHCDCJLG.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void LCPIPOEGABC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class PEECKNHAGKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public PEECKNHAGKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x47D32B0", Offset = "0x47D26B0", VA = "0x1847D32B0")]
			internal bool ICCCLHALIGI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x47D3390", Offset = "0x47D2790", VA = "0x1847D3390")]
			internal bool JABHHGHAIMN(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct CJICPFGENNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public JJOAMEIBCPP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x5031250", Offset = "0x5030650", VA = "0x185031250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x50315E0", Offset = "0x50309E0", VA = "0x1850315E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly NAAMCGEJGIP ADGLCHDCNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool EPKNFKMIEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private ADPFOAGAIMM<JHDIGLFOPPI, FDMNMOMGKHK> BOGHGEMAPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private ADPFOAGAIMM<JHDIGLFOPPI, PMOBMPCNNFE> INOANKCKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> BLOEPNHFLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<DFKPAEMPCKH<JHDIGLFOPPI>>? LKLNLDCNOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<DFKPAEMPCKH<JHDIGLFOPPI>, PMOBMPCNNFE>? HDLHOBILDDL;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected LMFKKFCLKJH EMCNPMMIALC
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x40653A0", Offset = "0x40647A0", VA = "0x1840653A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected PNDACDHBLEI OMGPAGIBMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x4066520", Offset = "0x4065920", VA = "0x184066520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode DKJHLMGPNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public AACPCJLHLFB<CLCDCIMDIIC> GHOMGJMKGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xBF41C0", Offset = "0xBF35C0", VA = "0x180BF41C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AACPCJLHLFB<CLCDCIMDIIC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public DFKPAEMPCKH<DPPIGEAIABK> PEJNFHINPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x4069DE0", Offset = "0x40691E0", VA = "0x184069DE0", Slot = "6")]
			get
			{
				return default(DFKPAEMPCKH<DPPIGEAIABK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object EAGKEKNFHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x38EFD00", Offset = "0x38EF100", VA = "0x1838EFD00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool OHEMOMAGECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int NNFOKMMOCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x4069A40", Offset = "0x4068E40", VA = "0x184069A40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public MOMFOAKJJNM LNFFHLMEAJG
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x40699E0", Offset = "0x4068DE0", VA = "0x1840699E0", Slot = "10")]
			get
			{
				return default(MOMFOAKJJNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string MHHBJNPAFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x4069F80", Offset = "0x4069380", VA = "0x184069F80", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool HMOIEPHOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public DFKPAEMPCKH<FOOMHPLNIKI> PLDCPDHJELB
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2DF0", Offset = "0x9F21F0", VA = "0x1809F2DF0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(DFKPAEMPCKH<FOOMHPLNIKI>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xC09600", Offset = "0xC08A00", VA = "0x180C09600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool MIHBEEMNMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool BDKLMNBFDOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual FAADEJLFGBN PIANBCIJFNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x94E850", Offset = "0x94DC50", VA = "0x18094E850", Slot = "94")]
			get
			{
				return default(FAADEJLFGBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool EHKNMKBHCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4069750", Offset = "0x4068B50", VA = "0x184069750", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool NKJIOLFPFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x40697B0", Offset = "0x4068BB0", VA = "0x1840697B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool PHBOIGMOCOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x4069810", Offset = "0x4068C10", VA = "0x184069810", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int NAPGMKIPHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x4069D90", Offset = "0x4069190", VA = "0x184069D90", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool LDINNJJIMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x4069BC0", Offset = "0x4068FC0", VA = "0x184069BC0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool IHAOCDJDEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x4069920", Offset = "0x4068D20", VA = "0x184069920", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KKGADBEDDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x40698C0", Offset = "0x4068CC0", VA = "0x1840698C0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GHLGJKOMGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xD4C100", Offset = "0xD4B500", VA = "0x180D4C100", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xD4C0F0", Offset = "0xD4B4F0", VA = "0x180D4C0F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool MMEIBICMIFG
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool PBJEJKNEHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4069870", Offset = "0x4068C70", VA = "0x184069870", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool AHDNLJPOOJE
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4069AF0", Offset = "0x4068EF0", VA = "0x184069AF0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public CNAJHOMKMAP KIBNMIMEJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4069CD0", Offset = "0x40690D0", VA = "0x184069CD0", Slot = "28")]
			get
			{
				return default(CNAJHOMKMAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public DIOGKOPAFDE KCKHOJFDOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4069D30", Offset = "0x4069130", VA = "0x184069D30", Slot = "30")]
			get
			{
				return default(DIOGKOPAFDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KEOBBHGGCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual DCHOLJHCOIE? BALDIEJKNEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual NFDEMGPGICE? PCJEMJHDBOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<AACPCJLHLFB<CEAIECNFGDF>>? FAEIKGIBDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool IPJLILKIGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4069980", Offset = "0x4068D80", VA = "0x184069980", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public AACPCJLHLFB<JJIBBLMHJAE> ODMPLNBDLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4069C10", Offset = "0x4069010", VA = "0x184069C10", Slot = "62")]
			get
			{
				return default(AACPCJLHLFB<JJIBBLMHJAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public DFKPAEMPCKH<JJIBBLMHJAE> HGENNJHNHAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x4069A90", Offset = "0x4068E90", VA = "0x184069A90", Slot = "56")]
			get
			{
				return default(DFKPAEMPCKH<JJIBBLMHJAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool IIGAFLJOAAH
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual DFKPAEMPCKH<JJIBBLMHJAE>? IOJLAJPNIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool BGMEHFIPHEH
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool KEDLIFPJDKK
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4069B50", Offset = "0x4068F50", VA = "0x184069B50", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x855F20", Offset = "0x855320", VA = "0x180855F20", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x855F00", Offset = "0x855300", VA = "0x180855F00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string AOKGLEJOKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x855F50", Offset = "0x855350", VA = "0x180855F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public AACPCJLHLFB<CEAIECNFGDF> LCLOMHKEMID
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4069C70", Offset = "0x4069070", VA = "0x184069C70", Slot = "63")]
			get
			{
				return default(AACPCJLHLFB<CEAIECNFGDF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public AACPCJLHLFB<CEAIECNFGDF>? NLPOJCCOMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4069E60", Offset = "0x4069260", VA = "0x184069E60", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public LNNPJBHEINB<JHDIGLFOPPI, PMOBMPCNNFE> DMKAPJIOHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4069F40", Offset = "0x4069340", VA = "0x184069F40", Slot = "65")]
			get
			{
				return default(LNNPJBHEINB<JHDIGLFOPPI, PMOBMPCNNFE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual DFKPAEMPCKH<JHDIGLFOPPI>? ALINDLDJCPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool HDJAAOFDMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool KNCKBOOCLDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CLOOIHJLGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4067DB0", Offset = "0x40671B0", VA = "0x184067DB0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4064840", Offset = "0x4063C40", VA = "0x184064840", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LJFJNAMLJJL GOEPOGHNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4066BB0", Offset = "0x4065FB0", VA = "0x184066BB0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x40645B0", Offset = "0x40639B0", VA = "0x1840645B0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LIDNKIIGIJF HOGPJBICPAI
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4067EC0", Offset = "0x40672C0", VA = "0x184067EC0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4064970", Offset = "0x4063D70", VA = "0x184064970", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GCLJNKHBJPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4068540", Offset = "0x4067940", VA = "0x184068540", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x40662A0", Offset = "0x40656A0", VA = "0x1840662A0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action MIPOKPCPGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4068CC0", Offset = "0x40680C0", VA = "0x184068CC0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x40658E0", Offset = "0x4064CE0", VA = "0x1840658E0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>, PMOBMPCNNFE> IFAGBKMAGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4066A30", Offset = "0x4065E30", VA = "0x184066A30", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x40666C0", Offset = "0x4065AC0", VA = "0x1840666C0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>, PMOBMPCNNFE> CNCKPOOPEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4066AF0", Offset = "0x4065EF0", VA = "0x184066AF0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4068160", Offset = "0x4067560", VA = "0x184068160", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>> MPCOGBPBHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4065FA0", Offset = "0x40653A0", VA = "0x184065FA0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x4066300", Offset = "0x4065700", VA = "0x184066300", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>, DFKPAEMPCKH<JHDIGLFOPPI>> CDKOEOPEJJM
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x40663C0", Offset = "0x40657C0", VA = "0x1840663C0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4065980", Offset = "0x4064D80", VA = "0x184065980", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>, PMOBMPCNNFE> BIPGLIIPOAC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x40661E0", Offset = "0x40655E0", VA = "0x1840661E0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4067BC0", Offset = "0x4066FC0", VA = "0x184067BC0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<DFKPAEMPCKH<JHDIGLFOPPI>, DFKPAEMPCKH<JHDIGLFOPPI>> HNGGILNFPPM
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x40652E0", Offset = "0x40646E0", VA = "0x1840652E0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4067CF0", Offset = "0x40670F0", VA = "0x184067CF0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4069170", Offset = "0x4068570", VA = "0x184069170")]
		[KGODJLMABGP("Need to handle `Name` better.")]
		[KGODJLMABGP("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected JJOAMEIBCPP(NAAMCGEJGIP LMOEPHCOEOK, TNode ILPFPPMNEDJ, bool LKDJEFBOENG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x40673F0", Offset = "0x40667F0", VA = "0x1840673F0", Slot = "87")]
		protected virtual void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4064A50", Offset = "0x4063E50", VA = "0x184064A50", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4067B10", Offset = "0x4066F10", VA = "0x184067B10", Slot = "9")]
		[AsyncStateMachine(typeof(JJOAMEIBCPP<>.DJFPOOCCFKK))]
		public void MNAMAGHKNJH(int HOBAFHHNKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x4067E50", Offset = "0x4067250", VA = "0x184067E50")]
		public bool NKPNONEPEAH([In] CNAJHOMKMAP OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x4066170", Offset = "0x4065570", VA = "0x184066170")]
		public bool GFCOBDJPAGK([In] DIOGKOPAFDE OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x4067F60", Offset = "0x4067360", VA = "0x184067F60", Slot = "32")]
		public void OCFNHICKPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x4069020", Offset = "0x4068420", VA = "0x184069020", Slot = "33")]
		[AsyncStateMachine(typeof(JJOAMEIBCPP<>.NCGKFPBCMMI))]
		public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> PPCNPOKJDBD(CNAJHOMKMAP? NCLBJGONFMN, DIOGKOPAFDE? BDPMNAOLAED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "97")]
		public virtual void DKEKKLAPGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "98")]
		public virtual void PNCABMGNLCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "99")]
		public virtual void CJAOLENPALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1E43A20", Offset = "0x1E42E20", VA = "0x181E43A20")]
		protected void NLEKKEBGEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4065F80", Offset = "0x4065380", VA = "0x184065F80")]
		protected void FCDJIAHMCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x21BBA00", Offset = "0x21BAE00", VA = "0x1821BBA00")]
		private void CCJEFOCDLBG([In] DIOGKOPAFDE MGJIDJKDGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4064650", Offset = "0x4063A50", VA = "0x184064650", Slot = "100")]
		public virtual Task<NNKIHJJJOOI<DFKPAEMPCKH<JHDIGLFOPPI>, FAGGAEGFGFH>> AOJHDPGIPHF(string FIKHOKLHCII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4065810", Offset = "0x4064C10", VA = "0x184065810", Slot = "101")]
		public virtual Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> EKHJOAJFDPG(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "102")]
		public virtual void EBNKLHAJDPA(DFKPAEMPCKH<JHDIGLFOPPI> BGGHOIKHIKF, DFKPAEMPCKH<JHDIGLFOPPI> HCOKNBFGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x40660E0", Offset = "0x40654E0", VA = "0x1840660E0", Slot = "103")]
		public virtual IEnumerable<CIAJNHMHPBB> FPPBLGHBIGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x40648E0", Offset = "0x4063CE0", VA = "0x1840648E0", Slot = "104")]
		public NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH> DBEJJDOGDBG(string MBEFFLGCNEK)
		{
			return default(NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x40667F0", Offset = "0x4065BF0", VA = "0x1840667F0", Slot = "47")]
		public bool KAEMFNPEKGD([Out] Guid LGJAABLNELP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x4068D60", Offset = "0x4068160", VA = "0x184068D60")]
		public bool PMNPODNPMGJ([In] Guid KIEJPDOJNFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "105")]
		public virtual void FCLPPFCBMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "106")]
		public virtual void LHNJDPHDHGJ(bool IDJLMBLJLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "107")]
		public virtual LCBFCGPFMJG PLMIGGFLMEM([In] MGAGNCNEIMI GDLKFEHINKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4068220", Offset = "0x4067620", VA = "0x184068220")]
		protected void OCOLLMJFHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x40660A0", Offset = "0x40654A0", VA = "0x1840660A0", Slot = "112")]
		protected virtual bool FODOAPJOCOL(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "113")]
		protected virtual bool IPCBEAGFHNH(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected virtual void GMPBMNIHOGM(CJIKKDBPPII NBGAOOJIHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x4066C50", Offset = "0x4066050", VA = "0x184066C50")]
		protected void LEHKINHLHAD(CJIKKDBPPII FOKEKPJLMIN, Func<string> LAHAGPDAALF, Action<string> AGLCNILLLDF, string CAOOGGPOGNI, string OHNOGOCFCGG, string PAFIJLHDEKH, EBGKJMBMILH BPNECGHLPPH, GBNDNIGKCFO BIDEOGINHFE, Func<string, bool> EJGKNFIGPJC, string ENNNCGHDKJJ, Func<string, bool> MOGGMLJINHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x40670A0", Offset = "0x40664A0", VA = "0x1840670A0")]
		protected void LKCLPFKMKHK(CJIKKDBPPII FOKEKPJLMIN, Func<string> LAHAGPDAALF, Action<string> AGLCNILLLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x4068610", Offset = "0x4067A10", VA = "0x184068610", Slot = "121")]
		protected virtual void OIPEAOFJLNB(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4067050", Offset = "0x4066450", VA = "0x184067050", Slot = "80")]
		public void LIBPOCNOGAF(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4066940", Offset = "0x4065D40", VA = "0x184066940", Slot = "81")]
		public PNPKFABMDKF KBNJJMJHAAD()
		{
			return default(PNPKFABMDKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "124")]
		public virtual bool JICFJHONDFK(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x14ABA00", Offset = "0x14AAE00", VA = "0x1814ABA00")]
		private void NGIMIPEJHBF([In] CNAJHOMKMAP HBGADHMDPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x4068B70", Offset = "0x4067F70", VA = "0x184068B70")]
		private void OPKBIKAOLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x4065A40", Offset = "0x4064E40", VA = "0x184065A40")]
		private void EOOIOPJEKPO(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, IOGGAMPKBPH DONLNKMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x97CA10", Offset = "0x97BE10", VA = "0x18097CA10")]
		private void GMFKOHAFLIN(DFKPAEMPCKH<JHDIGLFOPPI> GNBDDFJPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4068410", Offset = "0x4067810", VA = "0x184068410")]
		private void OEAFMMKCEBN(DFKPAEMPCKH<JHDIGLFOPPI> GNBDDFJPEIA, IOGGAMPKBPH FMDCEAFFNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x40687C0", Offset = "0x4067BC0", VA = "0x1840687C0")]
		private void ONMAKNKEHFL(DFKPAEMPCKH<JHDIGLFOPPI> BGGHOIKHIKF, DFKPAEMPCKH<JHDIGLFOPPI> HCOKNBFGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x97C830", Offset = "0x97BC30", VA = "0x18097C830")]
		private void IBCJLBMFAPP(DFKPAEMPCKH<JHDIGLFOPPI> BGGHOIKHIKF, DFKPAEMPCKH<JHDIGLFOPPI> HCOKNBFGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x40673D0", Offset = "0x40667D0", VA = "0x1840673D0")]
		private void MFHAKFGFNHK(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4065400", Offset = "0x4064800", VA = "0x184065400")]
		private void EJLHOCCMJCG(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, IOGGAMPKBPH DONLNKMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4067C80", Offset = "0x4067080", VA = "0x184067C80")]
		private void MPPMMMENJOE(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, IOGGAMPKBPH FMDCEAFFNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4064720", Offset = "0x4063B20", VA = "0x184064720", Slot = "125")]
		[AsyncStateMachine(typeof(JJOAMEIBCPP<>.CJICPFGENNJ))]
		public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> BBIIPBOHGAN(string MBEFFLGCNEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4066780", Offset = "0x4065B80", VA = "0x184066780", Slot = "54")]
		private void JNGLLPJFPHM(object BFPAMMECFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4066650", Offset = "0x4065A50", VA = "0x184066650", Slot = "55")]
		private void JFMHNLIHHJM(object BFPAMMECFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4067390", Offset = "0x4066790", VA = "0x184067390", Slot = "29")]
		private bool LOGIJNOGPFN([In] CNAJHOMKMAP OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4064A10", Offset = "0x4063E10", VA = "0x184064A10", Slot = "31")]
		private bool DNDFOAGEGGP([In] DIOGKOPAFDE OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4066610", Offset = "0x4065A10", VA = "0x184066610", Slot = "48")]
		private bool JCJOCMLOHIE([In] Guid KIEJPDOJNFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4066060", Offset = "0x4065460", VA = "0x184066060")]
		[CompilerGenerated]
		private string FLPEEBDBAOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4066480", Offset = "0x4065880", VA = "0x184066480")]
		[CompilerGenerated]
		private void IFOKECHCIOJ(string FIKHOKLHCII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class HNEAKNGNACK : FKNGNIGDMFH<PBDKMGKOALA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD122C0", Offset = "0xD116C0", VA = "0x180D122C0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0120", Offset = "0x1FCF520", VA = "0x181FD0120")]
		public HNEAKNGNACK(NAAMCGEJGIP LMOEPHCOEOK, PBDKMGKOALA ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KGDNLAPEOEJ : AEMMAFKPMHP<CHKGJADPNLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD18C0", Offset = "0x1FD0CC0", VA = "0x181FD18C0")]
		public KGDNLAPEOEJ(NAAMCGEJGIP LMOEPHCOEOK, CHKGJADPNLJ ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class ENEIGNLMIHO<T> : JJOAMEIBCPP<T> where T : notnull, OAELNLOPPHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class KMIDIMJJNDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, OLJDNHLONJI>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public ENEIGNLMIHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public OCGADGAFCAL clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public KMIDIMJJNDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			internal IReadOnlyList<KeyValuePair<string, OLJDNHLONJI>> DGKOKFDKCLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x41AB150", Offset = "0x41AA550", VA = "0x1841AB150")]
			internal int FLPJKIJGKLD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x41AB2B0", Offset = "0x41AA6B0", VA = "0x1841AB2B0")]
			internal void GGFGJHCDEGP(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x41AAF60", Offset = "0x41AA360", VA = "0x1841AAF60")]
			internal void BLEGDHBDGFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x41AB630", Offset = "0x41AAA30", VA = "0x1841AB630")]
			internal void NLGNKDDPHDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x41AB070", Offset = "0x41AA470", VA = "0x1841AB070")]
			internal bool GEJGFLFBEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x41AAF10", Offset = "0x41AA310", VA = "0x1841AAF10")]
			internal void BDNCDJKOFEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x41AB070", Offset = "0x41AA470", VA = "0x1841AB070")]
			internal bool CIBOKJGKDLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x41AB4D0", Offset = "0x41AA8D0", VA = "0x1841AB4D0")]
			internal float KHAEEIMKFKE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x41AB570", Offset = "0x41AA970", VA = "0x1841AB570")]
			internal void MNPACKNHEEH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x41AB520", Offset = "0x41AA920", VA = "0x1841AB520")]
			internal float MJCHHEGMKCL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x41AB780", Offset = "0x41AAB80", VA = "0x1841AB780")]
			internal void PAMGAGNNFML(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x41AB100", Offset = "0x41AA500", VA = "0x1841AB100")]
			internal float FKDAOOFBLNI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x41AAFB0", Offset = "0x41AA3B0", VA = "0x1841AAFB0")]
			internal void BPDCIEFMBJJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract OCGADGAFCAL NJHCNDGIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x38379D0", Offset = "0x3836DD0", VA = "0x1838379D0")]
		public ENEIGNLMIHO(NAAMCGEJGIP LMOEPHCOEOK, T ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3836E70", Offset = "0x3836270", VA = "0x183836E70", Slot = "120")]
		protected sealed override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class DEFAAELFABJ : JJOAMEIBCPP<MBEPCMEBNOM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A3610", Offset = "0x9A2A10", VA = "0x1809A3610", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3E00", Offset = "0x1FC3200", VA = "0x181FC3E00")]
		public DEFAAELFABJ(NAAMCGEJGIP LMOEPHCOEOK, MBEPCMEBNOM ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class KOONGFNNIDL : JJOAMEIBCPP<DHHCFOCPMNA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class LBALFICEIPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public KOONGFNNIDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LBALFICEIPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3290", Offset = "0x1FD2690", VA = "0x181FD3290")]
			internal int FLPJKIJGKLD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FD32E0", Offset = "0x1FD26E0", VA = "0x181FD32E0")]
			internal void GGFGJHCDEGP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, OLJDNHLONJI>? PFFMOIFGAJI;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3220", Offset = "0x1FD2620", VA = "0x181FD3220")]
		public KOONGFNNIDL(NAAMCGEJGIP LMOEPHCOEOK, DHHCFOCPMNA ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2EA0", Offset = "0x1FD22A0", VA = "0x181FD2EA0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HDAAOAKDBFB : ENEIGNLMIHO<MNFFPOAHPOI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override OCGADGAFCAL NJHCNDGIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "126")]
			get
			{
				return default(OCGADGAFCAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FCDA50", Offset = "0x1FCCE50", VA = "0x181FCDA50")]
		public HDAAOAKDBFB(NAAMCGEJGIP LMOEPHCOEOK, MNFFPOAHPOI DJKNDPHDPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class ANHEJPBOFHC : AEMMAFKPMHP<PNGKKLBGMCN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2150", Offset = "0x1FC1550", VA = "0x181FC2150")]
		public ANHEJPBOFHC(NAAMCGEJGIP LMOEPHCOEOK, PNGKKLBGMCN ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class KNBCMKPKIML : AEMMAFKPMHP<LDMKENOKCAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2E40", Offset = "0x1FD2240", VA = "0x181FD2E40")]
		public KNBCMKPKIML(NAAMCGEJGIP LMOEPHCOEOK, LDMKENOKCAE ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class DLDLHHABIOP : JLKFGINIJME<GMGPEJFNOJP>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class ILANNAECJEI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public ILANNAECJEI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x1FD76F0", Offset = "0x1FD6AF0", VA = "0x181FD76F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public DLDLHHABIOP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public ILANNAECJEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1010", Offset = "0x1FD0410", VA = "0x181FD1010")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void JDKBKLGDFCE(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DE0", Offset = "0x1FC41E0", VA = "0x181FC4DE0")]
		public DLDLHHABIOP(NAAMCGEJGIP LMOEPHCOEOK, GMGPEJFNOJP DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4B00", Offset = "0x1FC3F00", VA = "0x181FC4B00", Slot = "126")]
		protected override void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class JBBBOMPPPPM : ENEIGNLMIHO<CFDHNCAIGPH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override OCGADGAFCAL NJHCNDGIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9ADA30", Offset = "0x9ACE30", VA = "0x1809ADA30", Slot = "126")]
			get
			{
				return default(OCGADGAFCAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FD10E0", Offset = "0x1FD04E0", VA = "0x181FD10E0")]
		public JBBBOMPPPPM(NAAMCGEJGIP LMOEPHCOEOK, CFDHNCAIGPH DJKNDPHDPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class PLNOGPFPHMC : JJOAMEIBCPP<GFLEAABNKHE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9EAF30", Offset = "0x9EA330", VA = "0x1809EAF30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7680", Offset = "0x1FD6A80", VA = "0x181FD7680")]
		public PLNOGPFPHMC(NAAMCGEJGIP LMOEPHCOEOK, GFLEAABNKHE ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class GLHOEJMAKFC : JJOAMEIBCPP<FDEMMLJJIAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool MIHBEEMNMLH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool HMOIEPHOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD9E0", Offset = "0x1FCCDE0", VA = "0x181FCD9E0")]
		public GLHOEJMAKFC(NAAMCGEJGIP LMOEPHCOEOK, FDEMMLJJIAJ ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD650", Offset = "0x1FCCA50", VA = "0x181FCD650", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD610", Offset = "0x1FCCA10", VA = "0x181FCD610")]
		private int FKBMJIIIMGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD980", Offset = "0x1FCCD80", VA = "0x181FCD980")]
		private void KNNCKFHGNNL(int LOBINIIDBBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class HBOKDIDLGFB : CGFOOHINNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC34A0", Offset = "0x1FC28A0", VA = "0x181FC34A0")]
		public HBOKDIDLGFB(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class EJIBBLLKDCP : JLKFGINIJME<FNPPPPHOHGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5320", Offset = "0x1FC4720", VA = "0x181FC5320")]
		public EJIBBLLKDCP(NAAMCGEJGIP LMOEPHCOEOK, FNPPPPHOHGJ ILPFPPMNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class JLKFGINIJME<TVariableNode> : JJOAMEIBCPP<TVariableNode> where TVariableNode : notnull, FNPPPPHOHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class ABGJDJDINKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public JLKFGINIJME<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public ABGJDJDINKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x3CB22F0", Offset = "0x3CB16F0", VA = "0x183CB22F0")]
			internal bool DGKOKFDKCLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2350", Offset = "0x3CB1750", VA = "0x183CB2350")]
			internal void FLPJKIJGKLD(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2410", Offset = "0x3CB1810", VA = "0x183CB2410")]
			internal bool GGFGJHCDEGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2230", Offset = "0x3CB1630", VA = "0x183CB2230")]
			internal void BLEGDHBDGFH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2470", Offset = "0x3CB1870", VA = "0x183CB2470")]
			internal bool NLGNKDDPHDF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class GIODEKHHMCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public PNDACDHBLEI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public JLKFGINIJME<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public GIODEKHHMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x3D175D0", Offset = "0x3D169D0", VA = "0x183D175D0")]
			internal void JDKBKLGDFCE(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB5EBC0", Offset = "0xB5DFC0", VA = "0x180B5EBC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override FAADEJLFGBN PIANBCIJFNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4072390", Offset = "0x4071790", VA = "0x184072390", Slot = "94")]
			get
			{
				return default(FAADEJLFGBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x40721F0", Offset = "0x40715F0", VA = "0x1840721F0")]
		protected JLKFGINIJME(NAAMCGEJGIP LMOEPHCOEOK, TVariableNode ILPFPPMNEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4071760", Offset = "0x4070B60", VA = "0x184071760", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x40719D0", Offset = "0x4070DD0", VA = "0x1840719D0", Slot = "120")]
		protected override void GMPBMNIHOGM(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x4071E60", Offset = "0x4071260", VA = "0x184071E60", Slot = "126")]
		protected virtual void OGNAGPKNCNH(CJIKKDBPPII FOKEKPJLMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x40718E0", Offset = "0x4070CE0", VA = "0x1840718E0", Slot = "105")]
		public override void FCLPPFCBMBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA17C0", Offset = "0x1FA0BC0", VA = "0x181FA17C0")]
	public static HNDBDOLBHDL DDEJLDFANAB(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class BGFHJNNKGOD : KHEIIHCPHBN, MGAJEBHLDAH, ADNGLOCCGKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DFKPAEMPCKH<ADOPGBMODDE> DEMMHHHKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xB33390", Offset = "0xB32790", VA = "0x180B33390", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(DFKPAEMPCKH<ADOPGBMODDE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public DFKPAEMPCKH<NNKLJCCKPPB> PALFOJMINJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E00", Offset = "0xFC0200", VA = "0x180FC0E00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DFKPAEMPCKH<NNKLJCCKPPB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2710", Offset = "0x1FC1B10", VA = "0x181FC2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private DFKPAEMPCKH<FMDFDHKLINA> LIJEHADEABB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xC92020", Offset = "0xC91420", VA = "0x180C92020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override DFKPAEMPCKH<EBINLCLBAEP> CNPFOFGDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2A70", Offset = "0x1FC1E70", VA = "0x181FC2A70", Slot = "20")]
		get
		{
			return default(DFKPAEMPCKH<EBINLCLBAEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2AC0", Offset = "0x1FC1EC0", VA = "0x181FC2AC0")]
	private BGFHJNNKGOD(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ, EEBCEGJKFEC KLKMHPCGENJ, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<NNKLJCCKPPB> HOLPDNLGFNL, DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB, bool DJKCNNJKFBL, string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2720", Offset = "0x1FC1B20", VA = "0x181FC2720")]
	public static BGFHJNNKGOD DDEJLDFANAB(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ, EEBCEGJKFEC DKGIEBLFDJO, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB, DFKPAEMPCKH<NNKLJCCKPPB> HOLPDNLGFNL, bool DJKCNNJKFBL, bool LKDJEFBOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2710", Offset = "0x1FC1B10", VA = "0x181FC2710")]
	internal void KNABKOOIIEG(DFKPAEMPCKH<NNKLJCCKPPB> OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class KHEIIHCPHBN : ADNGLOCCGKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct DHHCNCMIDPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private BNOCOIMCHNK? OOBICILIEDA;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4570", Offset = "0x1FC3970", VA = "0x181FC4570")]
		public void IHJLNMEMMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4580", Offset = "0x1FC3980", VA = "0x181FC4580")]
		public BNOCOIMCHNK KNLLNHGDEFJ(KHEIIHCPHBN JDJAPMOKAIA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly DOGMMAIBEOG JLJMNHCCMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private DHHCNCMIDPJ IFDEGBEEIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly EAPAMLDEAFG GFGDGELCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<DJNOBDIPLDB> CADGBEIBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<LNMCCMGGNGF> NMCALPEFOKH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[KGODJLMABGP("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> FDAABMMDINO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1A50", Offset = "0x1FD0E50", VA = "0x181FD1A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind HMMIHMLHOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x85B590", Offset = "0x85A990", VA = "0x18085B590", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DFKPAEMPCKH<JJIBBLMHJAE> HGENNJHNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2090", Offset = "0x1FD1490", VA = "0x181FD2090", Slot = "6")]
		get
		{
			return default(DFKPAEMPCKH<JJIBBLMHJAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public AACPCJLHLFB<JJIBBLMHJAE> ODMPLNBDLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1D50", Offset = "0x1FD1150", VA = "0x181FD1D50", Slot = "7")]
		get
		{
			return default(AACPCJLHLFB<JJIBBLMHJAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PAAJKBDOCMN POOKDIBANDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CD0B10", Offset = "0x1CCFF10", VA = "0x181CD0B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GEOPNDNLAGF IBGHABMMLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1F90", Offset = "0x1FD1390", VA = "0x181FD1F90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected BNOCOIMCHNK LLAMBJDKFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1F90", Offset = "0x1FD1390", VA = "0x181FD1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage ANCBIPANMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1920", Offset = "0x1FD0D20", VA = "0x181FD1920", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public AACPCJLHLFB<CEAIECNFGDF> LCLOMHKEMID
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FD20C0", Offset = "0x1FD14C0", VA = "0x181FD20C0", Slot = "9")]
		get
		{
			return default(AACPCJLHLFB<CEAIECNFGDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public DFKPAEMPCKH<JHDIGLFOPPI> GDOHAIBGIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA98BE0", Offset = "0xA97FE0", VA = "0x180A98BE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(DFKPAEMPCKH<JHDIGLFOPPI>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xF5ADA0", Offset = "0xF5A1A0", VA = "0x180F5ADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract DFKPAEMPCKH<EBINLCLBAEP> CNPFOFGDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2CE0", Offset = "0x1FD20E0", VA = "0x181FD2CE0")]
	protected KHEIIHCPHBN(NAAMCGEJGIP LMOEPHCOEOK, DOGMMAIBEOG ILPFPPMNEDJ, EAPAMLDEAFG HDOKGLCAPFN, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, bool DJKCNNJKFBL, string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2420", Offset = "0x1FD1820", VA = "0x181FD2420", Slot = "21")]
	protected virtual void MGIGIPLLEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1D80", Offset = "0x1FD1180", VA = "0x181FD1D80", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2C00", Offset = "0x1FD2000", VA = "0x181FD2C00", Slot = "14")]
	public void NGMEIOCEEMC(DJNOBDIPLDB GAIJEBPOFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1F30", Offset = "0x1FD1330", VA = "0x181FD1F30", Slot = "15")]
	public void GBHDIOPAJOH(LNMCCMGGNGF GAIJEBPOFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2570", Offset = "0x1FD1970", VA = "0x181FD2570", Slot = "16")]
	public void MHJKKKPOFKE(NKHPFNCLJJF FFPDHPNKKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1ED0", Offset = "0x1FD12D0", VA = "0x181FD1ED0", Slot = "23")]
	protected virtual void EMBHJFCAHOA(NKHPFNCLJJF FFPDHPNKKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2290", Offset = "0x1FD1690", VA = "0x181FD2290")]
	private void JMNPGIMHMLO(bool MHKDAHGGECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1FD20E0", Offset = "0x1FD14E0", VA = "0x181FD20E0")]
	private void JIBNDKCHPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1BA0", Offset = "0x1FD0FA0", VA = "0x181FD1BA0")]
	private void CNDIHAFNCMN([In] DBJLBMFDBJE MLKLKADACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2C80", Offset = "0x1FD2080", VA = "0x181FD2C80", Slot = "17")]
	public void PJEKFJDJMNF(DJNOBDIPLDB GAIJEBPOFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2030", Offset = "0x1FD1430", VA = "0x181FD2030", Slot = "18")]
	public void IKBNHPNIFMK(LNMCCMGGNGF GAIJEBPOFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0")]
	internal void IDEGPHBDLNF(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2C60", Offset = "0x1FD2060", VA = "0x181FD2C60")]
	internal void NMHHLEMADKO(PNFNNDGKDAE GPENJAMDJGM, PAAJKBDOCMN EPPKBKJHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xF5ADA0", Offset = "0xF5A1A0", VA = "0x180F5ADA0")]
	internal void MNPKGOFHDGF(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class FDMNMOMGKHK : PMOBMPCNNFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class DHFOLLHDLMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public NAAMCGEJGIP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DOGMMAIBEOG node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DHFOLLHDLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC44E0", Offset = "0x1FC38E0", VA = "0x181FC44E0")]
		internal CKFKFMHNJOK PIAEHKCDDGM((int PortDescIndex, int PortIndex, KOOGMACNIJK InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4450", Offset = "0x1FC3850", VA = "0x181FC4450")]
		internal BGFHJNNKGOD KIMNFNAFIJJ(EEBCEGJKFEC i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct GCLNLKHAIKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCAE0", Offset = "0x1FCBEE0", VA = "0x181FCCAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCF40", Offset = "0x1FCC340", VA = "0x181FCCF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct DMFGHFEHLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DFKPAEMPCKH<PEGEEDBAAGD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4F60", Offset = "0x1FC4360", VA = "0x181FC4F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1FC52B0", Offset = "0x1FC46B0", VA = "0x181FC52B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct NADFHBONGAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public DFKPAEMPCKH<FMDFDHKLINA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FD47A0", Offset = "0x1FD3BA0", VA = "0x181FD47A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4AF0", Offset = "0x1FD3EF0", VA = "0x181FD4AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JGHAKJCOIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public DFKPAEMPCKH<PEGEEDBAAGD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public DFKPAEMPCKH<PEGEEDBAAGD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1140", Offset = "0x1FD0540", VA = "0x181FD1140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1490", Offset = "0x1FD0890", VA = "0x181FD1490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct NPNDJGJHNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public DFKPAEMPCKH<FMDFDHKLINA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public DFKPAEMPCKH<FMDFDHKLINA> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5070", Offset = "0x1FD4470", VA = "0x181FD5070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD53C0", Offset = "0x1FD47C0", VA = "0x181FD53C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DJPELEJDPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4620", Offset = "0x1FC3A20", VA = "0x181FC4620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4A90", Offset = "0x1FC3E90", VA = "0x181FC4A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct PGKPIBPMIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6890", Offset = "0x1FD5C90", VA = "0x181FD6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6BE0", Offset = "0x1FD5FE0", VA = "0x181FD6BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct KDKCAAFNGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DFKPAEMPCKH<PEGEEDBAAGD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1500", Offset = "0x1FD0900", VA = "0x181FD1500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1850", Offset = "0x1FD0C50", VA = "0x181FD1850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct LOCPENIPKDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public DFKPAEMPCKH<FMDFDHKLINA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3A50", Offset = "0x1FD2E50", VA = "0x181FD3A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3DA0", Offset = "0x1FD31A0", VA = "0x181FD3DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct NIBBPEBFDFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public HFCDJOHNIHH type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public DFKPAEMPCKH<PEGEEDBAAGD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4B60", Offset = "0x1FD3F60", VA = "0x181FD4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4EF0", Offset = "0x1FD42F0", VA = "0x181FD4EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct HIAOIKFFMAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public FDMNMOMGKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public HFCDJOHNIHH type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public DFKPAEMPCKH<FMDFDHKLINA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private DOCEIIONKMH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FCFD20", Offset = "0x1FCF120", VA = "0x181FCFD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1FD00B0", Offset = "0x1FCF4B0", VA = "0x181FD00B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool IOPPOMEFFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool ENGIADNIDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private LNNPJBHEINB<CGOIJKHKIMG, CKFKFMHNJOK> GMAJPFOGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LNNPJBHEINB<CGOIJKHKIMG, BJGCGLIDAKL> MLLKDPONOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly DOGMMAIBEOG JLJMNHCCMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private LNNPJBHEINB<NNKLJCCKPPB, BGFHJNNKGOD> JHMGNLDLOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private LNNPJBHEINB<NNKLJCCKPPB, MGAJEBHLDAH> PNABMLOLODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? MFJEPKLOBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly IOGGAMPKBPH EOBCPILIBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private DFKPAEMPCKH<JHDIGLFOPPI> EIBIHIHFBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool EPKNFKMIEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? BGDMECLHGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? MFIMPEHKKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<DFKPAEMPCKH<CGOIJKHKIMG>>? MONPHBKPBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<DFKPAEMPCKH<NNKLJCCKPPB>>? JHHPGOEOKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private PMOBMPCNNFE.IMGBBOLFCPH? JNNGNGLCJEM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FDPMGHOCFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5A90", Offset = "0x1FC4E90", VA = "0x181FC5A90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PMPOAKFCIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB480", Offset = "0x1FCA880", VA = "0x181FCB480", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool NNALGJFJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6E30", Offset = "0x1FC6230", VA = "0x181FC6E30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public AACPCJLHLFB<JJIBBLMHJAE> ODMPLNBDLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FC61D0", Offset = "0x1FC55D0", VA = "0x181FC61D0", Slot = "7")]
		get
		{
			return default(AACPCJLHLFB<JJIBBLMHJAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool FKIPDMOOOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9CA0", Offset = "0x1FC90A0", VA = "0x181FC9CA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LNNPJBHEINB<CGOIJKHKIMG, BJGCGLIDAKL> ILHLENJMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "9")]
		get
		{
			return default(LNNPJBHEINB<CGOIJKHKIMG, BJGCGLIDAKL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAFD0", Offset = "0x1FCA3D0", VA = "0x181FCAFD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public AACPCJLHLFB<CEAIECNFGDF> LCLOMHKEMID
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8310", Offset = "0x1FC7710", VA = "0x181FC8310", Slot = "11")]
		get
		{
			return default(AACPCJLHLFB<CEAIECNFGDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LNNPJBHEINB<NNKLJCCKPPB, MGAJEBHLDAH> AFNDAMFLKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "12")]
		get
		{
			return default(LNNPJBHEINB<NNKLJCCKPPB, MGAJEBHLDAH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public DFKPAEMPCKH<JHDIGLFOPPI> GDOHAIBGIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xC93000", Offset = "0xC92400", VA = "0x180C93000", Slot = "13")]
		get
		{
			return default(DFKPAEMPCKH<JHDIGLFOPPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BBKFEEBNCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC59F0", Offset = "0x1FC4DF0", VA = "0x181FC59F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB250", Offset = "0x1FCA650", VA = "0x181FCB250", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action NEOBAILHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB2F0", Offset = "0x1FCA6F0", VA = "0x181FCB2F0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5940", Offset = "0x1FC4D40", VA = "0x181FC5940", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<DFKPAEMPCKH<CGOIJKHKIMG>, DFKPAEMPCKH<CGOIJKHKIMG>> NJGNNKIFAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAE50", Offset = "0x1FCA250", VA = "0x181FCAE50", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FC73B0", Offset = "0x1FC67B0", VA = "0x181FC73B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<DFKPAEMPCKH<CGOIJKHKIMG>, DFKPAEMPCKH<CGOIJKHKIMG>> GNKNNNBCAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA4C0", Offset = "0x1FC98C0", VA = "0x181FCA4C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8420", Offset = "0x1FC7820", VA = "0x181FC8420", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<DFKPAEMPCKH<NNKLJCCKPPB>, DFKPAEMPCKH<NNKLJCCKPPB>> PLCIFIHGNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FC75A0", Offset = "0x1FC69A0", VA = "0x181FC75A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7660", Offset = "0x1FC6A60", VA = "0x181FC7660", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<DFKPAEMPCKH<NNKLJCCKPPB>, DFKPAEMPCKH<NNKLJCCKPPB>> DDJNGDDFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB3A0", Offset = "0x1FCA7A0", VA = "0x181FCB3A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5730", Offset = "0x1FC4B30", VA = "0x181FC5730", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DFKPAEMPCKH<CGOIJKHKIMG>, BJGCGLIDAKL> AIMCLBDNLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAF10", Offset = "0x1FCA310", VA = "0x181FCAF10", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC84E0", Offset = "0x1FC78E0", VA = "0x181FC84E0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DFKPAEMPCKH<CGOIJKHKIMG>> FOJAMHIIBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7F50", Offset = "0x1FC7350", VA = "0x181FC7F50", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAD90", Offset = "0x1FCA190", VA = "0x181FCAD90", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DFKPAEMPCKH<CGOIJKHKIMG>, BJGCGLIDAKL> GGHBFFEADJA
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB060", Offset = "0x1FCA460", VA = "0x181FCB060", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8250", Offset = "0x1FC7650", VA = "0x181FC8250", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<DFKPAEMPCKH<NNKLJCCKPPB>, MGAJEBHLDAH> KNDJLCFGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7720", Offset = "0x1FC6B20", VA = "0x181FC7720", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9D20", Offset = "0x1FC9120", VA = "0x181FC9D20", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<DFKPAEMPCKH<NNKLJCCKPPB>> BMLAFFEEEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8C00", Offset = "0x1FC8000", VA = "0x181FC8C00", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FC77E0", Offset = "0x1FC6BE0", VA = "0x181FC77E0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<DFKPAEMPCKH<NNKLJCCKPPB>, MGAJEBHLDAH> NFGJBAKJLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA400", Offset = "0x1FC9800", VA = "0x181FCA400", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9410", Offset = "0x1FC8810", VA = "0x181FC9410", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB520", Offset = "0x1FCA920", VA = "0x181FCB520")]
	private FDMNMOMGKHK(bool DJKCNNJKFBL, NAAMCGEJGIP LMOEPHCOEOK, bool PLLPDEIKLPA, LNNPJBHEINB<CGOIJKHKIMG, CKFKFMHNJOK> BFGMEIFFLLC, LNNPJBHEINB<CGOIJKHKIMG, BJGCGLIDAKL> IMOPDCHNKBC, DOGMMAIBEOG ILPFPPMNEDJ, LNNPJBHEINB<NNKLJCCKPPB, BGFHJNNKGOD> JGFPDEKBLBG, LNNPJBHEINB<NNKLJCCKPPB, MGAJEBHLDAH> NKMPDLFHJGF, string? CBBMPPEMJNL, IOGGAMPKBPH DONLNKMNEDJ, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, bool LKDJEFBOENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5B50", Offset = "0x1FC4F50", VA = "0x181FC5B50")]
	public static FDMNMOMGKHK DDEJLDFANAB(bool DJKCNNJKFBL, NAAMCGEJGIP LMOEPHCOEOK, bool PLLPDEIKLPA, DOGMMAIBEOG ILPFPPMNEDJ, IOGGAMPKBPH DONLNKMNEDJ, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, bool LKDJEFBOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FC94F0", Offset = "0x1FC88F0", VA = "0x181FC94F0")]
	private void MGIGIPLLEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6200", Offset = "0x1FC5600", VA = "0x181FC6200", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8CC0", Offset = "0x1FC80C0", VA = "0x181FC8CC0", Slot = "38")]
	[AsyncStateMachine(typeof(GCLNLKHAIKI))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> KLLHCGBILDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9E00", Offset = "0x1FC9200", VA = "0x181FC9E00")]
	private (LDOJBKCHJJO, int)? MMAOFJBCKOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8330", Offset = "0x1FC7730", VA = "0x181FC8330")]
	private void JCFADENEGMM(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x15036F0", Offset = "0x1502AF0", VA = "0x1815036F0")]
	private void CBMLEFDCDGK(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7010", Offset = "0x1FC6410", VA = "0x181FC7010")]
	private void EJLDPPPLMCM(int AGIDEABOEFC, int APJBDDFLOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB4C0", Offset = "0x1FCA8C0", VA = "0x181FCB4C0")]
	private void POJOBNLKNGG(int AGIDEABOEFC, int APJBDDFLOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FC85A0", Offset = "0x1FC79A0", VA = "0x181FC85A0")]
	private void KAFNBGMJIHD(int GAHEOINCDMA, DFKPAEMPCKH<CGOIJKHKIMG> KLAJPLAHPBG, KOOGMACNIJK MMNGAEPEJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9DE0", Offset = "0x1FC91E0", VA = "0x181FC9DE0")]
	private void MKMOJHKNCLH(int MHKDAHGGECP, DFKPAEMPCKH<CGOIJKHKIMG> KLAJPLAHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB460", Offset = "0x1FCA860", VA = "0x181FCB460")]
	private void PMAEMKEHDPL(int MHKDAHGGECP, DFKPAEMPCKH<CGOIJKHKIMG> KLAJPLAHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FC78A0", Offset = "0x1FC6CA0", VA = "0x181FC78A0")]
	private void GMIDEFDDDMG(int GAHEOINCDMA, DFKPAEMPCKH<CGOIJKHKIMG> KLAJPLAHPBG, KOOGMACNIJK MMNGAEPEJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8010", Offset = "0x1FC7410", VA = "0x181FC8010")]
	private void IGBNAPCNIIE(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xB9B1F0", Offset = "0xB9A5F0", VA = "0x180B9B1F0")]
	private void IJGECPMKMMD(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8160", Offset = "0x1FC7560", VA = "0x181FC8160")]
	private void IILDBOCHAED(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x15036F0", Offset = "0x1502AF0", VA = "0x1815036F0")]
	private void HJFMAOKMILP(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA580", Offset = "0x1FC9980", VA = "0x181FCA580")]
	private void NKLDMBMFPAG(int AGIDEABOEFC, int APJBDDFLOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB000", Offset = "0x1FCA400", VA = "0x181FCB000")]
	private void OEFACOAIOKG(int AGIDEABOEFC, int APJBDDFLOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8ED0", Offset = "0x1FC82D0", VA = "0x181FC8ED0")]
	private void LAOMLMCODGJ(int GAHEOINCDMA, DFKPAEMPCKH<NNKLJCCKPPB> KLAJPLAHPBG, EEBCEGJKFEC MMNGAEPEJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC94D0", Offset = "0x1FC88D0", VA = "0x181FC94D0")]
	private void MCPGIDOCIDB(int MHKDAHGGECP, DFKPAEMPCKH<NNKLJCCKPPB> KLAJPLAHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7F30", Offset = "0x1FC7330", VA = "0x181FC7F30")]
	private void IBCCMACCEOA(int MHKDAHGGECP, DFKPAEMPCKH<NNKLJCCKPPB> KLAJPLAHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA920", Offset = "0x1FC9D20", VA = "0x181FCA920")]
	private void NNLGHDGANEM(int GAHEOINCDMA, DFKPAEMPCKH<NNKLJCCKPPB> KLAJPLAHPBG, EEBCEGJKFEC MMNGAEPEJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC57F0", Offset = "0x1FC4BF0", VA = "0x181FC57F0")]
	private void BIBDGJHGGLF(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xB9B1F0", Offset = "0xB9A5F0", VA = "0x180B9B1F0")]
	private void JDKAHJHOOCH(int GAHEOINCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FC60C0", Offset = "0x1FC54C0", VA = "0x181FC60C0", Slot = "39")]
	[AsyncStateMachine(typeof(DMFGHFEHLLA))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> DFLNGNLJAJO(DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7E20", Offset = "0x1FC7220", VA = "0x181FC7E20", Slot = "40")]
	[AsyncStateMachine(typeof(NADFHBONGAA))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> HMEFHLGOKHE(DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6EF0", Offset = "0x1FC62F0", VA = "0x181FC6EF0", Slot = "41")]
	[AsyncStateMachine(typeof(JGHAKJCOIMD))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> EFCNGMFDAAJ(DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH, DFKPAEMPCKH<PEGEEDBAAGD> BMMHIAMHOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8DB0", Offset = "0x1FC81B0", VA = "0x181FC8DB0", Slot = "42")]
	[AsyncStateMachine(typeof(NPNDJGJHNIN))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> LAJNKNCCLPE(DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB, DFKPAEMPCKH<FMDFDHKLINA> BMMHIAMHOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5640", Offset = "0x1FC4A40", VA = "0x181FC5640", Slot = "43")]
	[AsyncStateMachine(typeof(DJPELEJDPNM))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> AHKPDJKMBJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8AE0", Offset = "0x1FC7EE0", VA = "0x181FC8AE0", Slot = "44")]
	[AsyncStateMachine(typeof(PGKPIBPMIFC))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> KANPLOAFEAG(string MBEFFLGCNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7470", Offset = "0x1FC6870", VA = "0x181FC7470", Slot = "45")]
	[AsyncStateMachine(typeof(KDKCAAFNGDP))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> FDPBBLFBJGD(DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH, string FIKHOKLHCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB120", Offset = "0x1FCA520", VA = "0x181FCB120", Slot = "46")]
	[AsyncStateMachine(typeof(LOCPENIPKDB))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> PBEJDGCKGPC(DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB, string FIKHOKLHCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6D00", Offset = "0x1FC6100", VA = "0x181FC6D00", Slot = "47")]
	[AsyncStateMachine(typeof(NIBBPEBFDFD))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> EDECPKBFCMP(DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH, HFCDJOHNIHH EPPKBKJHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7CF0", Offset = "0x1FC70F0", VA = "0x181FC7CF0", Slot = "48")]
	[AsyncStateMachine(typeof(HIAOIKFFMAE))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> GONMIBHEADH(DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB, HFCDJOHNIHH EPPKBKJHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA030", Offset = "0x1FC9430", VA = "0x181FCA030")]
	internal void MNPKGOFHDGF(DFKPAEMPCKH<JHDIGLFOPPI> OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class LOIFMGHPEPP : HLLGCBEKKMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface MNFBECEJCCF
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		PNFNNDGKDAE BKHIHAKJKHO
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HKDDDJCKAFD> EGGMGPNDKNI(CancellationToken GNJJGEHBGKC);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<ALPLJLFJAMB> MEAHKDGHHPO(CancellationToken GNJJGEHBGKC);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<COEJGGIEHPH> CJEDGKLHMPC(CancellationToken GNJJGEHBGKC);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct AFJJEIHEEDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<LOIFMGHPEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NAAMCGEJGIP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public HKDDDJCKAFD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ALPLJLFJAMB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private MNFBECEJCCF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private ALPLJLFJAMB <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HKDDDJCKAFD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<ALPLJLFJAMB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<COEJGGIEHPH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<FJGCDADIDCM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FC16B0", Offset = "0x1FC0AB0", VA = "0x181FC16B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1FC20E0", Offset = "0x1FC14E0", VA = "0x181FC20E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly FJGCDADIDCM AEPHAFKLOBI;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public FJGCDADIDCM GOHGNOOHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	private LOIFMGHPEPP(FJGCDADIDCM BFLFHANOGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3E30", Offset = "0x1FD3230", VA = "0x181FD3E30")]
	[AsyncStateMachine(typeof(AFJJEIHEEDO))]
	public static Task<LOIFMGHPEPP> LKKCFMPGCAF(NAAMCGEJGIP LMOEPHCOEOK, HKDDDJCKAFD? AFNMBPMIHMN, ALPLJLFJAMB? JBOHECJOFPF, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3E10", Offset = "0x1FD3210", VA = "0x181FD3E10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct CNGDEOGLLPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct HFBOCFLAHOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CNGDEOGLLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CIAJNHMHPBB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1FCFA20", Offset = "0x1FCEE20", VA = "0x181FCFA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1FCFCB0", Offset = "0x1FCF0B0", VA = "0x181FCFCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct IJNMINBOLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<bool, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public ABGDAFBNPKJ rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public HKDDDJCKAFD circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public ALPLJLFJAMB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public CNGDEOGLLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private CIAJNHMHPBB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0BC0", Offset = "0x1FCFFC0", VA = "0x181FD0BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0FA0", Offset = "0x1FD03A0", VA = "0x181FD0FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct PCHFIGLGFOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CNGDEOGLLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6320", Offset = "0x1FD5720", VA = "0x181FD6320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6560", Offset = "0x1FD5960", VA = "0x181FD6560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly IEAPCJENEBE JMJLLNJNOEN;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public CNGDEOGLLPM(IEAPCJENEBE NAPHODNAANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3C10", Offset = "0x1FC3010", VA = "0x181FC3C10")]
	[AsyncStateMachine(typeof(HFBOCFLAHOC))]
	private Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> JOPNHEIGKHB(CIAJNHMHPBB FADGJFNLBLP, bool FOFMAFBGMCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3AB0", Offset = "0x1FC2EB0", VA = "0x181FC3AB0")]
	[AsyncStateMachine(typeof(IJNMINBOLPJ))]
	public Task<NNKIHJJJOOI<bool, FAGGAEGFGFH?>>? FOOGONJLNJF(int NAIFHADDDCA, ABGDAFBNPKJ? KNLBLOKDGNG, HKDDDJCKAFD? KBJADHCBKJK, ALPLJLFJAMB? JBOHECJOFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1FC39C0", Offset = "0x1FC2DC0", VA = "0x181FC39C0")]
	[AsyncStateMachine(typeof(PCHFIGLGFOE))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> CDBCEOANHGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class DGMFCNFCMLN : HJDNPIMPMHO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly AALPFEDFINA DGDAKKNPAFC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AALPFEDFINA LPCNAGKLHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	private DGMFCNFCMLN(AALPFEDFINA FIHDOCPIAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4250", Offset = "0x1FC3650", VA = "0x181FC4250")]
	public static DGMFCNFCMLN JLCLGLEKPEG(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4230", Offset = "0x1FC3630", VA = "0x181FC4230", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface DPMBDPIOLLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	FJGCDADIDCM GOHGNOOHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	HCIPNBJGCCB GKLJNMCHKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	HJDHJPKKJDN BLPHKMMMLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	ACKMOMLFCCA EMCNPMMIALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface JAGFPCJBDCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	DPMBDPIOLLP? JMHJJBEKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool ADBLGJPBPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool ABNBGAIBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DPMBDPIOLLP?>? DODLFOJAEGC();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CKBHNBBOGJI(NAAMCGEJGIP LMOEPHCOEOK, ABGDAFBNPKJ EALDLHHBBHK, HKDDDJCKAFD? FLOHGHFDIND, ALPLJLFJAMB? KHJKPNNGFJN);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[NDLGMFPEHCH("IStaticCV2Instance")]
public interface HLLGCBEKKMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	FJGCDADIDCM GOHGNOOHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[NDLGMFPEHCH("IStaticEVInstance")]
public interface HJDNPIMPMHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	AALPFEDFINA LPCNAGKLHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class OMDBKONPNFB
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5D90", Offset = "0x1FD5190", VA = "0x181FD5D90")]
	public static KGJMNALECGB<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> DMJBLOEIBJJ([In] this KGJMNALECGB<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>> JCPIHPNBFKN)
	{
		return default(KGJMNALECGB<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP, OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class LNKFCPFDDEL : BAHDOGOPPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool ABNBGAIBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3A30", Offset = "0x1FD2E30", VA = "0x181FD3A30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	internal LNKFCPFDDEL(NAAMCGEJGIP LMOEPHCOEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class PKMEAPNGDAA : LNPBGEDDMDG
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD75E0", Offset = "0x1FD69E0", VA = "0x181FD75E0", Slot = "4")]
	public GGNDEILFICP? NLKGKAGOOFK(string? LCHDHNLMNLO, string? JJFMOMCEDGP, string? KMHLGMLKLFJ, NAHGLDKNMOC.DMJGBHEBLHD.NGMAGAPKALD MKFPDIMOHGF, bool PAONNJKFNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public PKMEAPNGDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class IEKKKEGNDGM : PNCHAOAGJFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct GAGGEDMNBDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<LMFKKFCLKJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public IEKKKEGNDGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<DPMBDPIOLLP?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBD10", Offset = "0x1FCB110", VA = "0x181FCBD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBFC0", Offset = "0x1FCB3C0", VA = "0x181FCBFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<AACPCJLHLFB<CLCDCIMDIIC>>? CFGIJKCOMNA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public LMFKKFCLKJH? CLHFPJDPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0310", Offset = "0x1FCF710", VA = "0x181FD0310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ACKMOMLFCCA? DDPEAGPKFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0290", Offset = "0x1FCF690", VA = "0x181FD0290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KCOINPLOJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0700", Offset = "0x1FCFB00", VA = "0x181FD0700", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FFFNNGMHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0960", Offset = "0x1FCFD60", VA = "0x181FD0960", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	internal IEKKKEGNDGM(NAAMCGEJGIP LMOEPHCOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD01A0", Offset = "0x1FCF5A0", VA = "0x181FD01A0", Slot = "7")]
	[AsyncStateMachine(typeof(GAGGEDMNBDJ))]
	public Task<LMFKKFCLKJH> BJCFIOLFBBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0390", Offset = "0x1FCF790", VA = "0x181FD0390", Slot = "9")]
	public IReadOnlyDictionary<AACPCJLHLFB<JJIBBLMHJAE>, Guid> HGPMHDLKONL(IEnumerable<NLJKHDOJKPO> EDLIBLLPDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD09C0", Offset = "0x1FCFDC0", VA = "0x181FD09C0")]
	public NNKIHJJJOOI<ONGMJDMALHH, EHALGCGAKNL> PLFFIIJPPME([In] ONGMJDMALHH AFCANOJBKMB, IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE, int ENNFLLNGOBN)
	{
		return default(NNKIHJJJOOI<ONGMJDMALHH, EHALGCGAKNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0760", Offset = "0x1FCFB60", VA = "0x181FD0760", Slot = "8")]
	private NNKIHJJJOOI<ONGMJDMALHH, EHALGCGAKNL> KENIENDNKMI([In] ONGMJDMALHH AFCANOJBKMB, IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE, int ENNFLLNGOBN)
	{
		return default(NNKIHJJJOOI<ONGMJDMALHH, EHALGCGAKNL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class ACKMOMLFCCA : LMFKKFCLKJH
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class HFAIIOIDACA
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class CLBKJEJHLEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public FJGCDADIDCM state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public IAJIJDCIEPB spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public CLBKJEJHLEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3830", Offset = "0x1FC2C30", VA = "0x181FC3830")]
			internal bool MIIPPJKHHDB(ILMHACGNNEB n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class IBODBGPFFJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public IBODBGPFFJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FD0180", Offset = "0x1FCF580", VA = "0x181FD0180")]
			internal void EOFIAGLJBPH(ILMHACGNNEB n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF050", Offset = "0x1FCE450", VA = "0x181FCF050")]
		public static NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG> JBMECBCMFCJ(ACKMOMLFCCA ABPJKOBADEP, [In] LMFKKFCLKJH.LEDIIJMANCO JEKDODJMDHN)
		{
			return default(NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FCDD00", Offset = "0x1FCD100", VA = "0x181FCDD00")]
		internal static NNKIHJJJOOI<(IEOJFAKDELG, PCKBFMFMCEJ), FABPBLICAGG> BJKHFCMNEOJ(ACKMOMLFCCA ABPJKOBADEP, PCKBFMFMCEJ KNJFEPOPPHI, bool LKKLPCPCKHF, [In] AACPCJLHLFB<JJIBBLMHJAE> DNECKPEOIMD, [In] int? PKBHJOFJPJF, [In] PNPKFABMDKF? BNIONENDNNM, [In] PNPKFABMDKF? HBNDDBEEDNO)
		{
			return default(NNKIHJJJOOI<(IEOJFAKDELG, PCKBFMFMCEJ), FABPBLICAGG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF5E0", Offset = "0x1FCE9E0", VA = "0x181FCF5E0")]
		private static void LNALNNMKICP(bool LKKLPCPCKHF, NLJKHDOJKPO GIHDGAEAPDL, IEOJFAKDELG CFDOPEDLKEI, [In] AACPCJLHLFB<JJIBBLMHJAE> DNECKPEOIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FCEB20", Offset = "0x1FCDF20", VA = "0x181FCEB20")]
		public static void DFFHFPHOAJF(OMDBKFKAJGJ AGFMBAJJMID, [In] LMFKKFCLKJH.MKBJOJECNKO ECELHAGMDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1FCEF30", Offset = "0x1FCE330", VA = "0x181FCEF30")]
		[CompilerGenerated]
		internal static bool DKCIIKHMCHB(FJGCDADIDCM FDIFLLHBALG, IAJIJDCIEPB LEKFKGDDNMM, ILMHACGNNEB GFEOCHAONAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF020", Offset = "0x1FCE420", VA = "0x181FCF020")]
		[CompilerGenerated]
		internal static bool HOFLILGKLJB(ILMHACGNNEB CAHNDBICCFN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct LCCJEHPLOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public ACKMOMLFCCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public DFKPAEMPCKH<JJIBBLMHJAE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public DFKPAEMPCKH<ADOPGBMODDE> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public DFKPAEMPCKH<OGMOCINGCKO> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3370", Offset = "0x1FD2770", VA = "0x181FD3370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FD39C0", Offset = "0x1FD2DC0", VA = "0x181FD39C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct GKPDJBEAGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public ACKMOMLFCCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AACPCJLHLFB<CEAIECNFGDF> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AACPCJLHLFB<JJIBBLMHJAE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DFKPAEMPCKH<JHDIGLFOPPI> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public DFKPAEMPCKH<CGOIJKHKIMG> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD260", Offset = "0x1FCC660", VA = "0x181FCD260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD5A0", Offset = "0x1FCC9A0", VA = "0x181FCD5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct FNLNMEKILNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public ACKMOMLFCCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AACPCJLHLFB<CEAIECNFGDF> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AACPCJLHLFB<JJIBBLMHJAE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public DFKPAEMPCKH<JHDIGLFOPPI> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public DFKPAEMPCKH<NNKLJCCKPPB> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB620", Offset = "0x1FCAA20", VA = "0x181FCB620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB960", Offset = "0x1FCAD60", VA = "0x181FCB960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly NAAMCGEJGIP ADGLCHDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly HLLGCBEKKMH GFGMMOOHOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly HJDNPIMPMHO JHOGCLOPKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly MMAHGGEIPDA MMDCLGGOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly IEKKKEGNDGM HHLHGJGLDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<AACPCJLHLFB<CEAIECNFGDF>, HNDBDOLBHDL> LKJLEKLHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<AACPCJLHLFB<CEAIECNFGDF>>? GCLJNKHBJPL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public AACPCJLHLFB<JJIBBLMHJAE> PLOGNAAHNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF5D0", Offset = "0x1FBE9D0", VA = "0x181FBF5D0", Slot = "4")]
		get
		{
			return default(AACPCJLHLFB<JJIBBLMHJAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MMAHGGEIPDA EDFHDCHDJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD9E0", Offset = "0x1FACDE0", VA = "0x181FAD9E0", Slot = "5")]
		get
		{
			return default(MMAHGGEIPDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1190", Offset = "0x1FC0590", VA = "0x181FC1190")]
	public ACKMOMLFCCA(NAAMCGEJGIP LMOEPHCOEOK, HLLGCBEKKMH NDDBAFJNIDF, HJDNPIMPMHO PJJEMPEOHGL, IEKKKEGNDGM LAAMGFHGNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0700", Offset = "0x1FBFB00", VA = "0x181FC0700", Slot = "42")]
	public DFKPAEMPCKH<MGEFODJLGMO> OEAOCFINBPK(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(DFKPAEMPCKH<MGEFODJLGMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0B10", Offset = "0x1FBFF10", VA = "0x181FC0B10", Slot = "43")]
	public DFKPAEMPCKH<JJNHPAOOAJK> PILFDHMDJCO(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(DFKPAEMPCKH<JJNHPAOOAJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFA10", Offset = "0x1FBEE10", VA = "0x181FBFA10", Slot = "6")]
	public bool JGFFBGOLGGI(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF630", Offset = "0x1FBEA30", VA = "0x181FBF630")]
	public bool INCLDCCIGFK(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] MNOJGFPIFBM AFPOGELKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0550", Offset = "0x1FBF950", VA = "0x181FC0550", Slot = "8")]
	public bool NMBDGPDFLND(BJGCGLIDAKL OBJDBPDIBGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD1F0", Offset = "0x1FBC5F0", VA = "0x181FBD1F0", Slot = "9")]
	public bool BEFIHAABCCO(MGAJEBHLDAH PPNKFBEBICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFFB0", Offset = "0x1FBF3B0", VA = "0x181FBFFB0")]
	public HNDBDOLBHDL? JMDHBAKPBJJ([In] AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE640", Offset = "0x1FBDA40", VA = "0x181FBE640")]
	public DFKPAEMPCKH<CEAIECNFGDF> JPLBJBINCEE(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] AACPCJLHLFB<CEAIECNFGDF> OMECEOCBOJF)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0780", Offset = "0x1FBFB80", VA = "0x181FC0780", Slot = "20")]
	public DFKPAEMPCKH<CEAIECNFGDF> OEMIOOGFJAB(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF1A0", Offset = "0x1FBE5A0", VA = "0x181FBF1A0", Slot = "21")]
	public DFKPAEMPCKH<CEAIECNFGDF> HIHMNDBNHIF(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF980", Offset = "0x1FBED80", VA = "0x181FBF980")]
	private void IPGPKLNFHMK(AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD430", Offset = "0x1FBC830", VA = "0x181FBD430")]
	public IEnumerable<HNDBDOLBHDL> CFKKOLOBFFB([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FC00E0", Offset = "0x1FBF4E0", VA = "0x181FC00E0", Slot = "19")]
	public DFKPAEMPCKH<OGMOCINGCKO> KGCNLDHPCCL(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<MGEFODJLGMO> OGEMJMHDFLE)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE6D0", Offset = "0x1FBDAD0", VA = "0x181FBE6D0", Slot = "22")]
	public DFKPAEMPCKH<ADOPGBMODDE> GKDBMPCOKIA(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JJNHPAOOAJK> OCOBGNMIFDP)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFF00", Offset = "0x1FBF300", VA = "0x181FBFF00")]
	private HNDBDOLBHDL? JHPNKKKKKJB([In] AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE060", Offset = "0x1FBD460", VA = "0x181FBE060")]
	private HNDBDOLBHDL EIBDJBHDNNF([In] AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK, DOGMMAIBEOG ILPFPPMNEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0A80", Offset = "0x1FBFE80", VA = "0x181FC0A80")]
	public DOGMMAIBEOG? OODJHNHIFNC([In] AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD300", Offset = "0x1FBC700", VA = "0x181FBD300")]
	public EIOGPKGBPGN? LEGFFPFKEKM([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF510", Offset = "0x1FBE910", VA = "0x181FBF510", Slot = "15")]
	public IEnumerable<IOMKNCGAKAA> HPGKCFNPPDH(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0800", Offset = "0x1FBFC00", VA = "0x181FC0800", Slot = "16")]
	public IEnumerable<MNOJGFPIFBM> OKJCHILOPCN(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF290", Offset = "0x1FBE690", VA = "0x181FBF290", Slot = "17")]
	public IEnumerable<MNOJGFPIFBM> HNFMAEFLDKM(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3B0", Offset = "0x1FBC7B0", VA = "0x181FBD3B0")]
	public DFKPAEMPCKH<JJIBBLMHJAE> CEGJPBPGAHC([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return default(DFKPAEMPCKH<JJIBBLMHJAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD330", Offset = "0x1FBC730", VA = "0x181FBD330")]
	public DFKPAEMPCKH<JJIBBLMHJAE>? NHLONMBNBBD([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD7C0", Offset = "0x1FBCBC0", VA = "0x181FBD7C0")]
	private IAJIJDCIEPB? CPLBJICLHDL([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD300", Offset = "0x1FBC700", VA = "0x181FBD300")]
	private EIOGPKGBPGN? CICCPKKNAAC([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF040", Offset = "0x1FBE440", VA = "0x181FBF040", Slot = "26")]
	public AACPCJLHLFB<JJIBBLMHJAE> HDKNONPIEIH(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return default(AACPCJLHLFB<JJIBBLMHJAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD880", Offset = "0x1FBCC80", VA = "0x181FBD880", Slot = "23")]
	public IEnumerable<HFCDJOHNIHH> DBOPMCCGNMH(JKFHLLPJLBG HOBODIFDNDJ, bool FHJLIEBJMNC, bool ENKLDFLFNIH, bool MHPAJEPMGIP, bool OHFEPANMFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEC50", Offset = "0x1FBE050", VA = "0x181FBEC50", Slot = "24")]
	public HFCDJOHNIHH HBNHKCBDMOH(JKFHLLPJLBG HOBODIFDNDJ, ADNGLOCCGKN BCAFINPAKCD, bool FHJLIEBJMNC, bool ENKLDFLFNIH, bool MHPAJEPMGIP, bool OHFEPANMFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD980", Offset = "0x1FBCD80", VA = "0x181FBD980")]
	public IOMKNCGAKAA DGIILMPDCGM(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] MNOJGFPIFBM AFPOGELKEDM)
	{
		return default(IOMKNCGAKAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD590", Offset = "0x1FBC990", VA = "0x181FBD590", Slot = "27")]
	public MNOJGFPIFBM CFNLHMLLBOI(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
		return default(MNOJGFPIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFF40", Offset = "0x1FBF340", VA = "0x181FBFF40", Slot = "28")]
	public bool JKLEJPOMFDC(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFE80", Offset = "0x1FBF280", VA = "0x181FBFE80", Slot = "29")]
	public bool JHENLLKLCHL(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD510", Offset = "0x1FBC910", VA = "0x181FBD510", Slot = "30")]
	public bool CFKMFILGCCG(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC00B0", Offset = "0x1FBF4B0", VA = "0x181FC00B0")]
	public NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG> LEANDBFKMEM([In] LMFKKFCLKJH.LEDIIJMANCO JEKDODJMDHN)
	{
		return default(NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC05D0", Offset = "0x1FBF9D0", VA = "0x181FC05D0", Slot = "32")]
	[AsyncStateMachine(typeof(LCCJEHPLOLL))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> NOMLCJEDADK(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE250", Offset = "0x1FBD650", VA = "0x181FBE250", Slot = "33")]
	public NNKIHJJJOOI<FADNKJDBNDB, EHALGCGAKNL> FGDFINGHKIN(AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM, FADNKJDBNDB NFIAIPIIEJL, DIOGKOPAFDE HHOACODMNMM)
	{
		return default(NNKIHJJJOOI<FADNKJDBNDB, EHALGCGAKNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD090", Offset = "0x1FBC490", VA = "0x181FBD090", Slot = "34")]
	[AsyncStateMachine(typeof(GKPDJBEAGDD))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> AOMKDHCNNCO(AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM, AACPCJLHLFB<CEAIECNFGDF> BDIJDAGHJMP, DFKPAEMPCKH<JHDIGLFOPPI> FCIJJMIAAND, DFKPAEMPCKH<CGOIJKHKIMG> OBINEBNCEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1030", Offset = "0x1FC0430", VA = "0x181FC1030", Slot = "35")]
	[AsyncStateMachine(typeof(FNLNMEKILNM))]
	public Task<NNKIHJJJOOI<AEFODLADDHH, FAGGAEGFGFH>> PPJFKNOJEIB(AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM, AACPCJLHLFB<CEAIECNFGDF> CCMINLKFJOK, DFKPAEMPCKH<JHDIGLFOPPI> LDCCGFJLFON, DFKPAEMPCKH<NNKLJCCKPPB> HOLPDNLGFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDE70", Offset = "0x1FBD270", VA = "0x181FBDE70", Slot = "36")]
	public NHGEKPPMEHN EGKCEMKMKCH(IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE)
	{
		return default(NHGEKPPMEHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE130", Offset = "0x1FBD530", VA = "0x181FBE130", Slot = "37")]
	public NHGEKPPMEHN EPKLDLDJJOH()
	{
		return default(NHGEKPPMEHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEAA0", Offset = "0x1FBDEA0", VA = "0x181FBEAA0")]
	private EGGCPCMEEGB GMGGPDFCNON(OLBNIPCGHEJ HMODIFGODCL, DFKPAEMPCKH<JJIBBLMHJAE> NPNJLHJAGHB, IEnumerable<AACPCJLHLFB<JJIBBLMHJAE>> KPNNOHBFLFG, IEnumerable<AACPCJLHLFB<CEAIECNFGDF>> HNLNOLOLDJF)
	{
		return default(EGGCPCMEEGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE760", Offset = "0x1FBDB60", VA = "0x181FBE760", Slot = "38")]
	public EGGCPCMEEGB GMGGPDFCNON(OLBNIPCGHEJ HMODIFGODCL, DFKPAEMPCKH<JJIBBLMHJAE> NPNJLHJAGHB, IEnumerable<AACPCJLHLFB<CEAIECNFGDF>> HNLNOLOLDJF, IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE)
	{
		return default(EGGCPCMEEGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDAF0", Offset = "0x1FBCEF0", VA = "0x181FBDAF0")]
	private static IEnumerable<AACPCJLHLFB<JJIBBLMHJAE>> DOADDKGLOAF(IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0B90", Offset = "0x1FBFF90", VA = "0x181FC0B90")]
	private IEnumerable<AACPCJLHLFB<CEAIECNFGDF>> PNIPHFGEEHA(IEnumerable<NLJKHDOJKPO> NJMKLLJPLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD270", Offset = "0x1FBC670", VA = "0x181FBD270", Slot = "39")]
	public List<DPBHGAOOGBK> CAPFINMIEEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC9C0", Offset = "0x1FBBDC0", VA = "0x181FBC9C0")]
	public (List<DPBHGAOOGBK>, bool) ADDEFHDNCEF([In] IFLDNIOPGPJ HKMFAJCDAAO, string NMIKEFKOPMC, [In] ELEGJCKPBKB JPKAADACCFM, ACJKAGKEHGM NFKPGHPNNHO, LIHFPAJDJFO NPFHLGDJLPO)
	{
		return default((List<DPBHGAOOGBK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0170", Offset = "0x1FBF570", VA = "0x181FC0170", Slot = "41")]
	public bool KJGCGKNGDNG(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC04F0", Offset = "0x1FBF8F0", VA = "0x181FC04F0")]
	internal void MLIMBKJILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC03B0", Offset = "0x1FBF7B0", VA = "0x181FC03B0")]
	internal Task MDEDMIPBJLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE6C0", Offset = "0x1FBDAC0", VA = "0x181FBE6C0", Slot = "7")]
	private bool FIAMCKANEOO(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] MNOJGFPIFBM AFPOGELKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD300", Offset = "0x1FBC700", VA = "0x181FBD300", Slot = "10")]
	private EIOGPKGBPGN CAPJOPAIJMD([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3B0", Offset = "0x1FBC7B0", VA = "0x181FBD3B0", Slot = "11")]
	private DFKPAEMPCKH<JJIBBLMHJAE> OFJOPAHGEHI([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return default(DFKPAEMPCKH<JJIBBLMHJAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD330", Offset = "0x1FBC730", VA = "0x181FBD330", Slot = "12")]
	private DFKPAEMPCKH<JJIBBLMHJAE>? CDKGLLPPBAJ([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF0B0", Offset = "0x1FBE4B0", VA = "0x181FBF0B0", Slot = "13")]
	private HNDBDOLBHDL HIFHEIMDKOK([In] AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE640", Offset = "0x1FBDA40", VA = "0x181FBE640", Slot = "14")]
	private DFKPAEMPCKH<CEAIECNFGDF> FGKCIOPHHOB(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] AACPCJLHLFB<CEAIECNFGDF> OMECEOCBOJF)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0410", Offset = "0x1FBF810", VA = "0x181FC0410", Slot = "18")]
	private IEnumerable<HNDBDOLBHDL> MDHJEBHILBI([In] AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD980", Offset = "0x1FBCD80", VA = "0x181FBD980", Slot = "25")]
	private IOMKNCGAKAA OEEFOKHKCLG(DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, [In] MNOJGFPIFBM AFPOGELKEDM)
	{
		return default(IOMKNCGAKAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC00B0", Offset = "0x1FBF4B0", VA = "0x181FC00B0", Slot = "31")]
	private NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG> KEGIDICJMFC([In] LMFKKFCLKJH.LEDIIJMANCO JEKDODJMDHN)
	{
		return default(NNKIHJJJOOI<LMFKKFCLKJH.DAJLAGFDMNO, FABPBLICAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0350", Offset = "0x1FBF750", VA = "0x181FC0350", Slot = "40")]
	private (List<DPBHGAOOGBK>, bool) LLLECGPKKOP([In] IFLDNIOPGPJ HKMFAJCDAAO, string NMIKEFKOPMC, [In] ELEGJCKPBKB JPKAADACCFM, ACJKAGKEHGM NFKPGHPNNHO, LIHFPAJDJFO NPFHLGDJLPO)
	{
		return default((List<DPBHGAOOGBK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBE350", VA = "0x181FBEF50")]
	[CompilerGenerated]
	private HNDBDOLBHDL HCHMMIJIKCN(DOGMMAIBEOG CBBBHLKBJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FC02D0", Offset = "0x1FBF6D0", VA = "0x181FC02D0")]
	[CompilerGenerated]
	private EMILACJBPNO LLBAENFJPAD(PAAJKBDOCMN CBBBHLKBJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF220", Offset = "0x1FBE620", VA = "0x181FBF220")]
	[CompilerGenerated]
	private DOGMMAIBEOG HMDMIFPDIKP(AACPCJLHLFB<CEAIECNFGDF> CBBBHLKBJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0260", Offset = "0x1FBF660", VA = "0x181FC0260")]
	[CompilerGenerated]
	private IAJIJDCIEPB KLEJMOCELLP(AACPCJLHLFB<JJIBBLMHJAE> CBBBHLKBJGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class EMILACJBPNO : HFCDJOHNIHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct EGNOPPNKCIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<DFKPAEMPCKH<PEGEEDBAAGD>, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public EMILACJBPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AACPCJLHLFB<JJIBBLMHJAE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public AACPCJLHLFB<CEAIECNFGDF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<PEGEEDBAAGD>, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB160", Offset = "0x1FDA560", VA = "0x181FDB160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB3E0", Offset = "0x1FDA7E0", VA = "0x181FDB3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct GMJGLFFGCAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<DFKPAEMPCKH<FMDFDHKLINA>, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public EMILACJBPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AACPCJLHLFB<JJIBBLMHJAE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AACPCJLHLFB<CEAIECNFGDF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public DFKPAEMPCKH<JHDIGLFOPPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<NNKIHJJJOOI<DFKPAEMPCKH<FMDFDHKLINA>, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBAF0", Offset = "0x1FDAEF0", VA = "0x181FDBAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBD70", Offset = "0x1FDB170", VA = "0x181FDBD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly PAAJKBDOCMN CFLEPKPNPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly HLLGCBEKKMH GFGMMOOHOFE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey ADBMIHCIOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string GIGPBMGMLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9B90", Offset = "0x1FD8F90", VA = "0x181FD9B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PAAJKBDOCMN ICAAHKGNDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBA50", Offset = "0x1FDAE50", VA = "0x181FDBA50")]
	public EMILACJBPNO(PAAJKBDOCMN FNJKNEKLHMG, HLLGCBEKKMH NDDBAFJNIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB8E0", Offset = "0x1FDACE0", VA = "0x181FDB8E0", Slot = "6")]
	[AsyncStateMachine(typeof(EGNOPPNKCIG))]
	public Task<NNKIHJJJOOI<DFKPAEMPCKH<PEGEEDBAAGD>, FAGGAEGFGFH>> FFFLGBCLHPB(AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM, AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, string FIKHOKLHCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB770", Offset = "0x1FDAB70", VA = "0x181FDB770", Slot = "7")]
	[AsyncStateMachine(typeof(GMJGLFFGCAL))]
	public Task<NNKIHJJJOOI<DFKPAEMPCKH<FMDFDHKLINA>, FAGGAEGFGFH>> ELHMEOONNBJ(AACPCJLHLFB<JJIBBLMHJAE> KIEJPDOJNFM, AACPCJLHLFB<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH, string FIKHOKLHCII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BNOCOIMCHNK : GEOPNDNLAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly PAAJKBDOCMN KFOIPMICHFF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<PAAJKBDOCMN> EONMKNNPLJF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<PAAJKBDOCMN> PODCJLODGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<PAAJKBDOCMN> KGHENFGCEGB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey IHHIJGDCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDACE0", Offset = "0x1FDA0E0", VA = "0x181FDACE0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MAGMELMGNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDACD0", Offset = "0x1FDA0D0", VA = "0x181FDACD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool JLKAHEJMBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAD30", Offset = "0x1FDA130", VA = "0x181FDAD30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool FNDMBIFJGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAC50", Offset = "0x1FDA050", VA = "0x181FDAC50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9920", Offset = "0x1FD8D20", VA = "0x181FD9920")]
	public bool LGFEOKNPBNK(string OBEEJPGJPFD, [Out] PDPPDOJOHMI PHGIBKBPIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public BNOCOIMCHNK(PAAJKBDOCMN DJKNDPHDPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9790", Offset = "0x1FD8B90", VA = "0x181FD9790")]
	internal static TypeKey IHFMAIPGMEH(PAAJKBDOCMN EPPKBKJHHHJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9B90", Offset = "0x1FD8F90", VA = "0x181FD9B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct MDCKNJMFDNP : MLNCCOCPGDO.NCAAAOBDNIH<CIAJNHMHPBB, AEFODLADDHH>
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC650", Offset = "0x1FDBA50", VA = "0x181FDC650", Slot = "4")]
	public int LIOKJCDBOAN(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC5B0", Offset = "0x1FDB9B0", VA = "0x181FDC5B0", Slot = "5")]
	public CIAJNHMHPBB CKAPBEOFEME(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC670", Offset = "0x1FDBA70", VA = "0x181FDC670", Slot = "6")]
	public CIAJNHMHPBB MAKNPGGHLNF(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC6A0", Offset = "0x1FDBAA0", VA = "0x181FDC6A0", Slot = "7")]
	public IReadOnlyList<CIAJNHMHPBB> NENLDLKFEIF(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC600", Offset = "0x1FDBA00", VA = "0x181FDC600", Slot = "8")]
	public CIAJNHMHPBB[] GHDLBJKGHPF(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP, int CEPKJNBJFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC6C0", Offset = "0x1FDBAC0", VA = "0x181FDC6C0", Slot = "9")]
	public bool OCHCCFBBOKF(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC590", Offset = "0x1FDB990", VA = "0x181FDC590", Slot = "10")]
	public bool CBLGNPEPDDL(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC610", Offset = "0x1FDBA10", VA = "0x181FDC610", Slot = "11")]
	public bool IBFFINELONF(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC630", Offset = "0x1FDBA30", VA = "0x181FDC630", Slot = "12")]
	public bool KFDFBHCAPOG(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC5E0", Offset = "0x1FDB9E0", VA = "0x181FDC5E0", Slot = "13")]
	public bool EIOHPAKJBEO(AEFODLADDHH MMIBEGJHHAN, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC5C0", Offset = "0x1FDB9C0", VA = "0x181FDC5C0", Slot = "14")]
	public bool EHAPIPLCJIL(AEFODLADDHH MHKDAHGGECP, CIAJNHMHPBB FADGJFNLBLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class HMHDCLBHIFE : KMOOBHBDIMP
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JKCLGPCNGGM.BPENMBILMHO MGDKNLNPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBE90", Offset = "0x1FDB290", VA = "0x181FDBE90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract EJAOBIAMFLH.IPPOFHOGKHP DIGKMAKIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract NAAMCGEJGIP.MIKEIELFCGF HAMMPPGGPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract LOIFMGHPEPP.MNFBECEJCCF DMNIFINAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public OBGDBKNLLKJ.CNGLPAHDFPL<FALDKJOPCKF, CIAJNHMHPBB, NAAMCGEJGIP> LBLMALJKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBE40", Offset = "0x1FDB240", VA = "0x181FDBE40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract DOCEIIONKMH FJHMEDMNNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract OJHNOEMMCBP GDAMCNLLMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract JCANDIFEJOA JDPGMMEBPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract DJIOBGEKANB LMKHDMAJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract LAKFBGDBCBB DOBDGIEJBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	protected HMHDCLBHIFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LPBMMOMLDAF : MMKNPBDHGOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct ECMHHENEOAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public LPBMMOMLDAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CIAJNHMHPBB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAE50", Offset = "0x1FDA250", VA = "0x181FDAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB0F0", Offset = "0x1FDA4F0", VA = "0x181FDB0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct LBJBCMBPKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public LPBMMOMLDAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<CIAJNHMHPBB> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBF40", Offset = "0x1FDB340", VA = "0x181FDBF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC2C0", Offset = "0x1FDB6C0", VA = "0x181FDC2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly IEAPCJENEBE JMJLLNJNOEN;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public LPBMMOMLDAF(IEAPCJENEBE NAPHODNAANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC330", Offset = "0x1FDB730", VA = "0x181FDC330")]
	[AsyncStateMachine(typeof(ECMHHENEOAK))]
	private Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> JOPNHEIGKHB(CIAJNHMHPBB FADGJFNLBLP, bool FOFMAFBGMCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC460", Offset = "0x1FDB860", VA = "0x181FDC460", Slot = "4")]
	[AsyncStateMachine(typeof(LBJBCMBPKOO))]
	public Task<NNKIHJJJOOI<IJOOAEGNOLO, FAGGAEGFGFH>> LAPBFJAOFLC(IReadOnlyList<CIAJNHMHPBB> DJJANLFLOJF, bool FOFMAFBGMCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct HFNKGONFOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal EIAJADENNOO<GGGJKIGEJCF, CIAJNHMHPBB, PGIJMGELBCM> KFOIPMICHFF;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7DD0", Offset = "0x1FA71D0", VA = "0x181FA7DD0")]
	private HFNKGONFOEJ([In] EIAJADENNOO<GGGJKIGEJCF, CIAJNHMHPBB, PGIJMGELBCM> CFCLOJCJEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBDE0", Offset = "0x1FDB1E0", VA = "0x181FDBDE0")]
	public static HFNKGONFOEJ DDEJLDFANAB()
	{
		return default(HFNKGONFOEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class LFIHNEPIDGI
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static EIAJADENNOO<GGGJKIGEJCF, CIAJNHMHPBB, PGIJMGELBCM> MANANJIJGFC(this HFNKGONFOEJ ABPJKOBADEP)
	{
		return default(EIAJADENNOO<GGGJKIGEJCF, CIAJNHMHPBB, PGIJMGELBCM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct PGIJMGELBCM : KCNFAMPGFKM.FIPJHEJBABA<GGGJKIGEJCF, CIAJNHMHPBB>
{
	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC6E0", Offset = "0x1FDBAE0", VA = "0x181FDC6E0", Slot = "5")]
	public CIAJNHMHPBB PCNEBPFJCNI(GGGJKIGEJCF[] EIHNAKFGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0")]
	public int AGFDKEAPGEH([In] GGGJKIGEJCF KCDBDNKJPCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0", Slot = "4")]
	private int KPPCPLJFLCO([In] GGGJKIGEJCF KAJGKFBPGEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct HPBHCAFKCCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal IJNEAOPMGAK<ENCMKFOLPJA, CIAJNHMHPBB, AOIBODHLCJI> KFOIPMICHFF;

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7DD0", Offset = "0x1FA71D0", VA = "0x181FA7DD0")]
	private HPBHCAFKCCA([In] IJNEAOPMGAK<ENCMKFOLPJA, CIAJNHMHPBB, AOIBODHLCJI> FAHECCPMECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBEE0", Offset = "0x1FDB2E0", VA = "0x181FDBEE0")]
	public static HPBHCAFKCCA DDEJLDFANAB()
	{
		return default(HPBHCAFKCCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class HNPHMGJCGKN
{
	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static IJNEAOPMGAK<ENCMKFOLPJA, CIAJNHMHPBB, AOIBODHLCJI> MANANJIJGFC(this HPBHCAFKCCA ABPJKOBADEP)
	{
		return default(IJNEAOPMGAK<ENCMKFOLPJA, CIAJNHMHPBB, AOIBODHLCJI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct AOIBODHLCJI : BOIPMEBBGKJ.GPNFJFMAGAP<ENCMKFOLPJA, CIAJNHMHPBB>
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0")]
	public int HPPNKALODFO([In] ENCMKFOLPJA KCDBDNKJPCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8CA0", Offset = "0x1FD80A0", VA = "0x181FD8CA0", Slot = "5")]
	public CIAJNHMHPBB OPFDECJFCHE(ENCMKFOLPJA[] KELBNGKEHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0", Slot = "4")]
	private int IKBNBMICFBH([In] ENCMKFOLPJA KCDBDNKJPCC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class EGOBLBAHKAJ : NDGMACBFDAM, FABPBLICAGG, FAGGAEGFGFH, EHALGCGAKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly EHALGCGAKNL? HFMJFEJMPFE;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public OLFDIGHKLAE HFFHCJOOJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(OLFDIGHKLAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override EHALGCGAKNL? EJNCOKHAPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB4C0", Offset = "0x1FDA8C0", VA = "0x181FDB4C0", Slot = "7")]
	public override string GBCPGMBELKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB730", Offset = "0x1FDAB30", VA = "0x181FDB730")]
	private EGOBLBAHKAJ(OLFDIGHKLAE NDDOEMMEACD, EHALGCGAKNL? OFIACLNIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB640", Offset = "0x1FDAA40", VA = "0x181FDB640")]
	public static EGOBLBAHKAJ HAGIKKBHKLL(EHALGCGAKNL OFIACLNIPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB450", Offset = "0x1FDA850", VA = "0x181FDB450")]
	public static EGOBLBAHKAJ CPFJFMIDCAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB6C0", Offset = "0x1FDAAC0", VA = "0x181FDB6C0")]
	public static EGOBLBAHKAJ JEHHMABECAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class JBDKMNADLNO
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBA90", Offset = "0x2BCAE90", VA = "0x182BCBA90")]
	public static NNKIHJJJOOI<TOk, FABPBLICAGG> GACHBHEHJEG<TOk>([In] this NNKIHJJJOOI<TOk, FABPBLICAGG> ABPJKOBADEP, EHALGCGAKNL OFIACLNIPHM) where TOk : notnull
	{
		return default(NNKIHJJJOOI<TOk, FABPBLICAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBC70", Offset = "0x2BCB070", VA = "0x182BCBC70")]
	public static NNKIHJJJOOI<TOk?, FABPBLICAGG?> NLNCEKIIBFG<TOk>([In] this NNKIHJJJOOI<TOk, FABPBLICAGG> ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<TOk, FABPBLICAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBB80", Offset = "0x2BCAF80", VA = "0x182BCBB80")]
	public static NNKIHJJJOOI<TOk?, FABPBLICAGG?> GBOAJDBKJEN<TOk>([In] this NNKIHJJJOOI<TOk, FABPBLICAGG> ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<TOk, FABPBLICAGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface DOCEIIONKMH
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICLIHNMHFP([In] NNKIHJJJOOI<AEFODLADDHH, EHALGCGAKNL> LLANANCGECL);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class GKCFOPCBNPA
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A2A0", Offset = "0x2B696A0", VA = "0x182B6A2A0")]
	public static bool HICLIHNMHFP<TOk, TErr>(this DOCEIIONKMH ABPJKOBADEP, [In] NNKIHJJJOOI<TOk, TErr> LLANANCGECL) where TOk : notnull where TErr : notnull, EHALGCGAKNL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface OJHNOEMMCBP
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	COIPDOKHIPI BPOHPDBKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface JCANDIFEJOA
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOMFOAKJJNM BILFBIJNCKE(int OHAGAMPKHIE);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface GEJAKBNDBAF
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface DHOKADKEELL
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOHLHDABPKA? JJFBGGBDMDF(DFKPAEMPCKH<JHDIGLFOPPI> DCNFEBJGABH);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface MCLKMJGMOOK
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface HOHLHDABPKA
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCLKMJGMOOK? AGEHDNHEHGE(DFKPAEMPCKH<PEGEEDBAAGD> NNDNPKEGLPH);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEJAKBNDBAF? GHNAHNJGMLO(DFKPAEMPCKH<FMDFDHKLINA> OLCMFMLEBKB);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface DJIOBGEKANB
{
	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PLEILPAPFPL(string OBEEJPGJPFD, string NMIKEFKOPMC);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface LAKFBGDBCBB
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHOKADKEELL? FHHLEELDHIA([In] AACPCJLHLFB<CLCDCIMDIIC> IJJKPDMOHNP);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class APJHMIKHLLM
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct AJJEILNJNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int KCOEJCJFNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public HKDDDJCKAFD? KMGHBNOKPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public HKDDDJCKAFD? GAAAPFCCCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<CIAJNHMHPBB> KMCMOHIFJPI;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8C50", Offset = "0x1FD8050", VA = "0x181FD8C50")]
		private AJJEILNJNHK(int AGAGKNBDCIG, HKDDDJCKAFD? AHDHOFNCHBJ, HKDDDJCKAFD? KHJLJBJCFBC, List<CIAJNHMHPBB> DJJANLFLOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8B90", Offset = "0x1FD7F90", VA = "0x181FD8B90")]
		public static AJJEILNJNHK DDEJLDFANAB()
		{
			return default(AJJEILNJNHK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly ABMHCBNKMOB<AJJEILNJNHK> KGCIDPKFPOB;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static APJHMIKHLLM CLHFPJDPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9190", Offset = "0x1FD8590", VA = "0x181FD9190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool LCKLMPKEGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x89D6E0", Offset = "0x89CAE0", VA = "0x18089D6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F640", Offset = "0xA9EA40", VA = "0x180A9F640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD91E0", Offset = "0x1FD85E0", VA = "0x181FD91E0")]
	public void GGPILJKABHI(FJGCDADIDCM KHJLJBJCFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8E90", Offset = "0x1FD8290", VA = "0x181FD8E90")]
	public void BAOIIHDMABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x1FD92A0", Offset = "0x1FD86A0", VA = "0x181FD92A0")]
	private static string? PINABIDNFCG([In] AJJEILNJNHK KHGIPLBLPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x1FD96E0", Offset = "0x1FD8AE0", VA = "0x181FD96E0")]
	public APJHMIKHLLM()
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
