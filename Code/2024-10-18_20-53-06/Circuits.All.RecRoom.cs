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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x21E27D0", Offset = "0x21E1BD0", VA = "0x1821E27D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MMCIBAEBBCI : IDisposable, JLACLBOHCIJ, BFFGFIPDHGO, IEBOLDPPHPL, ENDCBPFDIAM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class EIHLGIECMAA : JGJAFJKJECG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int FFOGEAGMNAN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21D8560", Offset = "0x21D7960", VA = "0x1821D8560", Slot = "5")]
		public JBLEPFIJEMC PENACPEDGFP(IMIOGAHJMGH.PCLAPFKMNLL CLOGBAKPPIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void HAMGCLPJLKG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void JKIOCCBHJGH();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21D84A0", Offset = "0x21D78A0", VA = "0x1821D84A0", Slot = "13")]
		public virtual void GGELMCCLDNG(MMCIBAEBBCI KNGIFCGKIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21D84E0", Offset = "0x21D78E0", VA = "0x1821D84E0", Slot = "14")]
		public virtual void LONMNBPPKAF(MMCIBAEBBCI KNGIFCGKIIP, IIIMLHFAMEO HJOAJFDFEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		protected EIHLGIECMAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JGJAFJKJECG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int FFOGEAGMNAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JBLEPFIJEMC PENACPEDGFP(IMIOGAHJMGH.PCLAPFKMNLL CLOGBAKPPIL);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HAMGCLPJLKG();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JKIOCCBHJGH();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GGELMCCLDNG(MMCIBAEBBCI KNGIFCGKIIP);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LONMNBPPKAF(MMCIBAEBBCI KNGIFCGKIIP, IIIMLHFAMEO HJOAJFDFEDM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BAFAEHNFOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CJKPHJOADDL<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> MJFPMHLONAL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
		internal BAFAEHNFOGG(CJKPHJOADDL<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> JPNNGBEFPIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ANLCOBLOCOI : JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ANLCOBLOCOI GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		private ANLCOBLOCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x132F570", Offset = "0x132E970", VA = "0x18132F570", Slot = "4")]
		public BFOPIJOMCBH DMPEIOIFJNE(IIIMLHFAMEO MCPMOAEEEOJ)
		{
			return default(BFOPIJOMCBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21D52D0", Offset = "0x21D46D0", VA = "0x1821D52D0", Slot = "5")]
		public void GGELMCCLDNG(MMCIBAEBBCI KCFGMPGPMFA, IIIMLHFAMEO HJOAJFDFEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x21D53E0", Offset = "0x21D47E0", VA = "0x1821D53E0", Slot = "6")]
		public void LONMNBPPKAF(MMCIBAEBBCI KCFGMPGPMFA, IIIMLHFAMEO HJOAJFDFEDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IDJGMNIGJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> MJFPMHLONAL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21DC2D0", Offset = "0x21DB6D0", VA = "0x1821DC2D0")]
		internal IDJGMNIGJKK(ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21DC280", Offset = "0x21DB680", VA = "0x1821DC280")]
		public static IDJGMNIGJKK AHLALEPNKFA()
		{
			return default(IDJGMNIGJKK);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct JINBDNJFFAJ : NIKOONMOAJF.APKLBBFFAHB<IIIMLHFAMEO, MMCIBAEBBCI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct CANHKEJHBGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public MMCIBAEBBCI receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IIIMLHFAMEO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JINBDNJFFAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x21D5B50", Offset = "0x21D4F50", VA = "0x1821D5B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21D5D30", Offset = "0x21D5130", VA = "0x1821D5D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9FB590", Offset = "0x9FA990", VA = "0x1809FB590", Slot = "4")]
		public MIEEFIOIIBN<ANIPNONNBFB> FBMPALHGHIN(MMCIBAEBBCI JEMODPNNLCP)
		{
			return default(MIEEFIOIIBN<ANIPNONNBFB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21DDD80", Offset = "0x21DD180", VA = "0x1821DDD80", Slot = "5")]
		[AsyncStateMachine(typeof(CANHKEJHBGO))]
		public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> KCNNBCILLCB(MMCIBAEBBCI JEMODPNNLCP, IIIMLHFAMEO HJOAJFDFEDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21DDD60", Offset = "0x21DD160", VA = "0x1821DDD60", Slot = "6")]
		public IIIMLHFAMEO[] HFPKONJACIJ(MMCIBAEBBCI JEMODPNNLCP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LMFJLMEKPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MMCIBAEBBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IKCDDPNEMII rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EOEFLIMDACN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public OMMIODCOJEM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21DE7F0", Offset = "0x21DDBF0", VA = "0x1821DE7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21DEA70", Offset = "0x21DDE70", VA = "0x1821DEA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OBGAOLFNMEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MMCIBAEBBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21E2850", Offset = "0x21E1C50", VA = "0x1821E2850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21E2AE0", Offset = "0x21E1EE0", VA = "0x1821E2AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CMDMPIAGNHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public MMCIBAEBBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x21D6480", Offset = "0x21D5880", VA = "0x1821D6480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x21D6660", Offset = "0x21D5A60", VA = "0x1821D6660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CJDEOMMJBLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public MMCIBAEBBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IIIMLHFAMEO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21D60C0", Offset = "0x21D54C0", VA = "0x1821D60C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21D62B0", Offset = "0x21D56B0", VA = "0x1821D62B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IIGGMOOKJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public MMCIBAEBBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x21DC420", Offset = "0x21DB820", VA = "0x1821DC420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x21DCC00", Offset = "0x21DC000", VA = "0x1821DCC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MIEEFIOIIBN<ANIPNONNBFB> CLJONBGOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BAFAEHNFOGG KLEBLJMOLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AMOCPKHIDKG OMIJEGEHFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly AJOMIBOJDAF DIBOKMGIOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IBPEIDILKAG LGKANLEKDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly HDKNAPMCODO.FACFHGNMCAF JCILMEELFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly ANOIJPPKCMP LPEODALCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly MCHEMPBABCG NDEHIEKLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MEHMMJIOJJA KMIABBJCNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1990")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly PPAMKCHDBJD GHAPDNKCBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1998")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KBCHGPLOHFK KNKEOKCLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EPKDKGFLEMI OJKLABHMIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly AMOCPKHIDKG.GBIJGDEIGEG EFEKHIEFMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly FMHEDGEMLDN DFDLFKPDCLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMOCPKHIDKG AEFOAEAGGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21E0560", Offset = "0x21DF960", VA = "0x1821E0560")]
		get
		{
			return default(AMOCPKHIDKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JGJAFJKJECG MBGHPNLJLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21E0010", Offset = "0x21DF410", VA = "0x1821E0010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JBLEPFIJEMC MNIACJAIICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21E0B30", Offset = "0x21DFF30", VA = "0x1821E0B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21E0B40", Offset = "0x21DFF40", VA = "0x1821E0B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool AGFDPGJNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21DFF90", Offset = "0x21DF390", VA = "0x1821DFF90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21DFF80", Offset = "0x21DF380", VA = "0x1821DFF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LGJPMFJIMBL EBDIDBIKCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21E1000", Offset = "0x21E0400", VA = "0x1821E1000", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NAGKPIFKJBG MMEAEMJBBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x21E1010", Offset = "0x21E0410", VA = "0x1821E1010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KEIEGLKKNMF JJBLBDKGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21E1030", Offset = "0x21E0430", VA = "0x1821E1030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NPODIEKGBCL DHMCAJDFIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x21E1020", Offset = "0x21E0420", VA = "0x1821E1020", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HDKNAPMCODO? HCEPMOHJEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21E0060", Offset = "0x21DF460", VA = "0x1821E0060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BDONJDJNHOP? HOAIKFDEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21E0910", Offset = "0x21DFD10", VA = "0x1821E0910", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21E0D00", Offset = "0x21E0100", VA = "0x1821E0D00")]
	private MMCIBAEBBCI(IBPEIDILKAG DAOJAMKOACA, MIEEFIOIIBN<ANIPNONNBFB> KIGKEDGNJCM, [In] BAFAEHNFOGG HEPDCLNFHLG, [In] AMOCPKHIDKG LMKJJGAGOOO, [In] AJOMIBOJDAF FAMBIJBBKOH, JBLEPFIJEMC PPMMDMNMOMF, [In] HDKNAPMCODO.FACFHGNMCAF FLKNGHBJJIE, AMOCPKHIDKG.GBIJGDEIGEG GCMELHMFEBC, FMHEDGEMLDN FGFFANLJNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21DF810", Offset = "0x21DEC10", VA = "0x1821DF810")]
	public static MMCIBAEBBCI AHLALEPNKFA(IBPEIDILKAG CLOGBAKPPIL, [In] IEJPFKMAMGI AMFDKAICLIO, NBOMKCDKMHM IDJAAPCIFNK, [In] DCFGBEMNKII GDPFADNNMFL, MBPMDBGOCHE AFCHCEEENLK, MIEEFIOIIBN<ANIPNONNBFB> KIGKEDGNJCM, MIEEFIOIIBN<OHPGPBIPOGD> CJMKLNPNHGL, IEOBNKPDNKH MACGMKINBBL, DDCLMMODIKD NGEAIAACHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21DF950", Offset = "0x21DED50", VA = "0x1821DF950")]
	public static MMCIBAEBBCI AHLALEPNKFA(IBPEIDILKAG DAOJAMKOACA, [In] AMOCPKHIDKG LMKJJGAGOOO, [In] AJOMIBOJDAF FAMBIJBBKOH, MIEEFIOIIBN<ANIPNONNBFB> KIGKEDGNJCM, MIEEFIOIIBN<OHPGPBIPOGD> CJMKLNPNHGL, IEOBNKPDNKH MACGMKINBBL, DDCLMMODIKD NGEAIAACHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21DFD90", Offset = "0x21DF190", VA = "0x1821DFD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21DFC30", Offset = "0x21DF030", VA = "0x1821DFC30")]
	[AsyncStateMachine(typeof(LMFJLMEKPLE))]
	internal Task<LMFFMMPMNDB<bool, FOPCNMINEGF>> ANFPGPECOBP(IKCDDPNEMII NJOPDIAIDJN, EOEFLIMDACN HOCKCMJEENH, OMMIODCOJEM JMBCEPAOBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21E0470", Offset = "0x21DF870", VA = "0x1821E0470")]
	[AsyncStateMachine(typeof(OBGAOLFNMEH))]
	public Task<LMFFMMPMNDB<bool, FOPCNMINEGF>> HJLLBNBNCBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21E0A40", Offset = "0x21DFE40", VA = "0x1821E0A40")]
	[AsyncStateMachine(typeof(CMDMPIAGNHP))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> KKMJEKOOCNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21E05F0", Offset = "0x21DF9F0", VA = "0x1821E05F0")]
	internal void JEMBJPGNKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21E0570", Offset = "0x21DF970", VA = "0x1821E0570")]
	internal EAJEDGEMDCE<IIIMLHFAMEO> ILJNECNKBCE([In] IKCMGKIAFBA NPHDONDBCAC)
	{
		return default(EAJEDGEMDCE<IIIMLHFAMEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21DFFA0", Offset = "0x21DF3A0", VA = "0x1821DFFA0")]
	internal bool EMDJMGHHAHC([In] IKCMGKIAFBA NPHDONDBCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21E0B60", Offset = "0x21DFF60", VA = "0x1821E0B60")]
	internal EAJEDGEMDCE<IIIMLHFAMEO> OCMNPFGOMIM([In] LJODAPINPGD PHBECHPGJFM)
	{
		return default(EAJEDGEMDCE<IIIMLHFAMEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21E0800", Offset = "0x21DFC00", VA = "0x1821E0800")]
	[AsyncStateMachine(typeof(CJDEOMMJBLO))]
	internal Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JKBANBELGDG(IIIMLHFAMEO HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21E00E0", Offset = "0x21DF4E0", VA = "0x1821E00E0")]
	private IIIMLHFAMEO[] HFPKONJACIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21E0BE0", Offset = "0x21DFFE0", VA = "0x1821E0BE0")]
	[AsyncStateMachine(typeof(IIGGMOOKJDF))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> OPEAIJHPIPL(Guid PILCKHPHIKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JKFPBKKNEKI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4D70", Offset = "0x2EB4170", VA = "0x182EB4D70")]
	public static KGDMABAIHKE<(TPrev?, MMCIBAEBBCI?), BDONJDJNHOP> LIKOCCNEMEJ<TPrev>([In] this KGDMABAIHKE<TPrev, MMCIBAEBBCI> MCPMOAEEEOJ)
	{
		return default(KGDMABAIHKE<(TPrev, MMCIBAEBBCI), BDONJDJNHOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5030", Offset = "0x2EB4430", VA = "0x182EB5030")]
	public static KGDMABAIHKE<TPrev?, MMCIBAEBBCI?> OAJOHLJIPPH<TPrev>([In] this KGDMABAIHKE<TPrev, MMCIBAEBBCI> MCPMOAEEEOJ)
	{
		return default(KGDMABAIHKE<TPrev, MMCIBAEBBCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LHGAHHGPLEI<TData> : CIIOJBGFHGE, IPCCKFJAFKG, HGFLKMEKLGL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OCPIDHFODDG<LKDNFLJFHHO>? MPPAMLMKKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LIEABGFDIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData LMIMGNACAMD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OCPIDHFODDG<LKDNFLJFHHO>? HDJNEGKCPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x240DA10", Offset = "0x240CE10", VA = "0x18240DA10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45AF370", Offset = "0x45AE770", VA = "0x1845AF370")]
	internal LHGAHHGPLEI([In] OCPIDHFODDG<LKDNFLJFHHO>? EHDPCBCIOGD, MIEEFIOIIBN<MJHPFEMDFLB>? ANGEIOAFKDG, IOKind? JPMDAGJNMGB, string MOKGCFCFCPE, [In] TData AIKOCCMKKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FBOPNONAGPF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x21D88C0", Offset = "0x21D7CC0", VA = "0x1821D88C0")]
	public static LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG> NCMOJKIHDDL([In] this FANKOKNCEAP<JHBDAACEFGM> OIOJPGFMPGO)
	{
		return default(LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E2B9D0", Offset = "0x2E2ADD0", VA = "0x182E2B9D0")]
	public static LMFFMMPMNDB<TOk, IPCCKFJAFKG> FDCIAOOKNFF<TOk>([In] this LMFFMMPMNDB<TOk, IPCCKFJAFKG> MCPMOAEEEOJ, [In] OCPIDHFODDG<LKDNFLJFHHO>? EHDPCBCIOGD, MIEEFIOIIBN<MJHPFEMDFLB>? ANGEIOAFKDG, IOKind? JPMDAGJNMGB, string MOKGCFCFCPE) where TOk : notnull
	{
		return default(LMFFMMPMNDB<TOk, IPCCKFJAFKG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IBPEIDILKAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PNMGAFPDHCL.NCAGMIPMNHM BNFHEFLAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IMIOGAHJMGH.PCLAPFKMNLL HPEACPCJJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MMCIBAEBBCI.JGJAFJKJECG BFELPJCOHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JMJNIILKGBC.BIKCOHPFLDG NMPOCDKFMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI> HAFDJDFINIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GCOEHOKBBPN DFMPJGOHJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LAFLPBPFMJP DJENMAOHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LJEJDJNPLGJ NAFKOIKKPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DFDNEOKMBMJ ABPLMAIGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DOHHLPMJDLP GPBMNKGKDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IKKAADLCDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21DD3C0", Offset = "0x21DC7C0", VA = "0x1821DD3C0")]
	public static IIIMLHFAMEO KEHHLMBLGLO(this IIIMLHFAMEO MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21DD4D0", Offset = "0x21DC8D0", VA = "0x1821DD4D0")]
	public static IIIMLHFAMEO KKNEPIBLGND(this NEFGAHMHOJC MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct NEFGAHMHOJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ACEAOHFFDAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public MMCIBAEBBCI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NEFGAHMHOJC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21D4560", Offset = "0x21D3960", VA = "0x1821D4560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x21D4820", Offset = "0x21D3C20", VA = "0x1821D4820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString EEMLDMGPOLA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	private NEFGAHMHOJC(ByteString EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21E2550", Offset = "0x21E1950", VA = "0x1821E2550")]
	public static IIIMLHFAMEO AGHJPCDDAEN(ByteString EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21E2610", Offset = "0x21E1A10", VA = "0x1821E2610")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, NEFGAHMHOJC> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, NEFGAHMHOJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x21E26C0", Offset = "0x21E1AC0", VA = "0x1821E26C0")]
	[AsyncStateMachine(typeof(ACEAOHFFDAL))]
	public static Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JKBANBELGDG(MMCIBAEBBCI KCFGMPGPMFA, NEFGAHMHOJC MCPMOAEEEOJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LDNKIKONNIJ
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21DE160", Offset = "0x21DD560", VA = "0x1821DE160")]
	public static IIIMLHFAMEO AGHJPCDDAEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x21DE200", Offset = "0x21DD600", VA = "0x1821DE200")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, LDNKIKONNIJ> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, LDNKIKONNIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21DE270", Offset = "0x21DD670", VA = "0x1821DE270")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO(MMCIBAEBBCI KCFGMPGPMFA, [In] LDNKIKONNIJ MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GGFKBFMFHKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LNKBGGKDBDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public MMCIBAEBBCI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GGFKBFMFHKF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x21DEAE0", Offset = "0x21DDEE0", VA = "0x1821DEAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x21DEE50", Offset = "0x21DE250", VA = "0x1821DEE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IKCDDPNEMII? JAMIKAEBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly EOEFLIMDACN? FIODOIBNGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly OMMIODCOJEM? NKMHGGHKKJI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x210F020", Offset = "0x210E420", VA = "0x18210F020")]
	private GGFKBFMFHKF(IKCDDPNEMII? NJOPDIAIDJN, EOEFLIMDACN? HOCKCMJEENH, OMMIODCOJEM? JMBCEPAOBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x21D92B0", Offset = "0x21D86B0", VA = "0x1821D92B0")]
	public static IIIMLHFAMEO? AGHJPCDDAEN(IKCDDPNEMII? NJOPDIAIDJN, EOEFLIMDACN? HOCKCMJEENH, OMMIODCOJEM? JMBCEPAOBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21D93B0", Offset = "0x21D87B0", VA = "0x1821D93B0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, GGFKBFMFHKF> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, GGFKBFMFHKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21D94C0", Offset = "0x21D88C0", VA = "0x1821D94C0")]
	[AsyncStateMachine(typeof(LNKBGGKDBDG))]
	public static Task<LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>> JKBANBELGDG(MMCIBAEBBCI KCFGMPGPMFA, GGFKBFMFHKF MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CELGPGFMEKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AEDJKGCDDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CELGPGFMEKE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MMCIBAEBBCI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private LMFFMMPMNDB<object, HGFLKMEKLGL>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private LMFFMMPMNDB<object, HGFLKMEKLGL> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private LMFFMMPMNDB<object, HGFLKMEKLGL>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21D4890", Offset = "0x21D3C90", VA = "0x1821D4890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21D4D00", Offset = "0x21D4100", VA = "0x1821D4D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<IIIMLHFAMEO> LIOHNOJPGAL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	private CELGPGFMEKE(IReadOnlyList<IIIMLHFAMEO> DKIHKOGIAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x21D5E20", Offset = "0x21D5220", VA = "0x1821D5E20")]
	public static IIIMLHFAMEO AGHJPCDDAEN(IReadOnlyList<IIIMLHFAMEO> DKIHKOGIAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21D5EE0", Offset = "0x21D52E0", VA = "0x1821D5EE0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, CELGPGFMEKE> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, CELGPGFMEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21D5F80", Offset = "0x21D5380", VA = "0x1821D5F80")]
	[AsyncStateMachine(typeof(AEDJKGCDDPK))]
	public static Task<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> JKBANBELGDG(MMCIBAEBBCI KCFGMPGPMFA, CELGPGFMEKE MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct LJODAPINPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int ICBOPDBFFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int KMIIBMECGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] LMIMGNACAMD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C360", Offset = "0x1F6B760", VA = "0x181F6C360")]
	private LJODAPINPGD(int HMELIAGANNM, int HAJICDLBEKC, byte[] AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21DE2F0", Offset = "0x21DD6F0", VA = "0x1821DE2F0")]
	public static IIIMLHFAMEO AGHJPCDDAEN(int HMELIAGANNM, int HAJICDLBEKC, ByteString AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21DE3D0", Offset = "0x21DD7D0", VA = "0x1821DE3D0")]
	public static IIIMLHFAMEO[] EDCHALAGKDP(IIIMLHFAMEO HJOAJFDFEDM, int CDNHMMICIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x21DE500", Offset = "0x21DD900", VA = "0x1821DE500")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, LJODAPINPGD> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, LJODAPINPGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x21DE5E0", Offset = "0x21DD9E0", VA = "0x1821DE5E0")]
	public static LMFFMMPMNDB<IIIMLHFAMEO, JLINDJLDKOH> JGMEIPOPKPO(MMCIBAEBBCI KCFGMPGPMFA, [In] LJODAPINPGD MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<IIIMLHFAMEO, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct IKCMGKIAFBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EGMOMLGDHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, JLINDJLDKOH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MMCIBAEBBCI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IKCMGKIAFBA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private LMFFMMPMNDB<bool, JLINDJLDKOH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x21D7DF0", Offset = "0x21D71F0", VA = "0x1821D7DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x21D8430", Offset = "0x21D7830", VA = "0x1821D8430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int ICBOPDBFFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int KMIIBMECGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] LMIMGNACAMD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C360", Offset = "0x1F6B760", VA = "0x181F6C360")]
	private IKCMGKIAFBA(int HMELIAGANNM, int HAJICDLBEKC, byte[] AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21DCEE0", Offset = "0x21DC2E0", VA = "0x1821DCEE0")]
	public static IIIMLHFAMEO AGHJPCDDAEN(int HMELIAGANNM, int HAJICDLBEKC, ByteString AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21DD0A0", Offset = "0x21DC4A0", VA = "0x1821DD0A0")]
	public static IIIMLHFAMEO?[]? JAJLODHGELB(int CDNHMMICIOJ, IKCDDPNEMII? NJOPDIAIDJN, EOEFLIMDACN? HOCKCMJEENH, OMMIODCOJEM? JMBCEPAOBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21DCFC0", Offset = "0x21DC3C0", VA = "0x1821DCFC0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, IKCMGKIAFBA> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, IKCMGKIAFBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x21DD290", Offset = "0x21DC690", VA = "0x1821DD290")]
	[AsyncStateMachine(typeof(EGMOMLGDHNM))]
	public static Task<LMFFMMPMNDB<bool, JLINDJLDKOH>> JKBANBELGDG(MMCIBAEBBCI KCFGMPGPMFA, IKCMGKIAFBA MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ANOIJPPKCMP : LGJPMFJIMBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public POJPLOKHLKJ? GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21D5560", Offset = "0x21D4960", VA = "0x1821D5560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	internal ANOIJPPKCMP(MMCIBAEBBCI KNGIFCGKIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DDBGKGHPHBD : POJPLOKHLKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LFMNDGPEAHI CPKEKNCLHDD;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public DDBGKGHPHBD(MMCIBAEBBCI KNGIFCGKIIP, LFMNDGPEAHI LFAPDIELPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x21D6E90", Offset = "0x21D6290", VA = "0x1821D6E90", Slot = "4")]
	public LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG> AJAKGDPABNM(OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<PGPOGLDOPDL> JJEIDNNKDCH)
	{
		return default(LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21D7170", Offset = "0x21D6570", VA = "0x1821D7170", Slot = "5")]
	public LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG> DBFPCAANDEO(OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<JJJHNALFLKF> KEAJHDKKBAE)
	{
		return default(LMFFMMPMNDB<GKHLODBGHIO, IPCCKFJAFKG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PNMGAFPDHCL : BJHIPBIDKLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface NCAGMIPMNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LFMNDGPEAHI> GOBKEEMFECH(MMCIBAEBBCI KNGIFCGKIIP, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC, CancellationToken NBBCMDKGJKI);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FFNKEAOMJEC HPDKAOOPKEC(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OICMKGABOJC : NCAGMIPMNHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct DLIBFGDKLPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<LFMNDGPEAHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public MMCIBAEBBCI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EOEFLIMDACN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public OMMIODCOJEM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<JMJNIILKGBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x21D7BB0", Offset = "0x21D6FB0", VA = "0x1821D7BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x21D7D80", Offset = "0x21D7180", VA = "0x1821D7D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly OICMKGABOJC GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		private OICMKGABOJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x21E5590", Offset = "0x21E4990", VA = "0x1821E5590", Slot = "4")]
		[AsyncStateMachine(typeof(DLIBFGDKLPM))]
		public Task<LFMNDGPEAHI> GOBKEEMFECH(MMCIBAEBBCI KNGIFCGKIIP, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC, CancellationToken NBBCMDKGJKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x21E56F0", Offset = "0x21E4AF0", VA = "0x1821E56F0", Slot = "5")]
		public FFNKEAOMJEC HPDKAOOPKEC(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ANINEDMGINE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<PNMGAFPDHCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MMCIBAEBBCI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EOEFLIMDACN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OMMIODCOJEM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IKCDDPNEMII evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private NCAGMIPMNHM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<LFMNDGPEAHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x21D4D70", Offset = "0x21D4170", VA = "0x1821D4D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x21D5260", Offset = "0x21D4660", VA = "0x1821D5260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LFMNDGPEAHI CPKEKNCLHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly FFNKEAOMJEC LELKKKDGKGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HDKNAPMCODO HCEPMOHJEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21F1250", Offset = "0x21F0650", VA = "0x1821F1250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BDONJDJNHOP OLFMDCOIJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21F1410", Offset = "0x21F0810", VA = "0x1821F1410", Slot = "5")]
		get
		{
			return default(BDONJDJNHOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DDBGKGHPHBD MGJCAKDLIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EEFBGIEIMDH ACPLGLFFKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA99C70", Offset = "0xA99070", VA = "0x180A99C70")]
	private PNMGAFPDHCL(LFMNDGPEAHI LFAPDIELPCG, FFNKEAOMJEC DOBJAGLEDDC, DDBGKGHPHBD JGFHNCEKNDF, EEFBGIEIMDH GEDJLONGACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21F12A0", Offset = "0x21F06A0", VA = "0x1821F12A0")]
	[AsyncStateMachine(typeof(ANINEDMGINE))]
	public static Task<PNMGAFPDHCL> KAJBPLHMDKN(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x21F11F0", Offset = "0x21F05F0", VA = "0x1821F11F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IMIOGAHJMGH : JBLEPFIJEMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface PCLAPFKMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BJHIPBIDKLJ> CPBEFBKFIAO(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC, CancellationToken NBBCMDKGJKI);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BBDCKNOJHBF();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PPFEKJFAONL();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class CLMNBGCBCKH : PCLAPFKMNLL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct HMNFAKMNBML : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<BJHIPBIDKLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public MMCIBAEBBCI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public IKCDDPNEMII evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public EOEFLIMDACN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public OMMIODCOJEM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<PNMGAFPDHCL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x21DBB10", Offset = "0x21DAF10", VA = "0x1821DBB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x21DBE50", Offset = "0x21DB250", VA = "0x1821DBE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x21D6320", Offset = "0x21D5720", VA = "0x1821D6320", Slot = "4")]
		[AsyncStateMachine(typeof(HMNFAKMNBML))]
		public Task<BJHIPBIDKLJ> CPBEFBKFIAO(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC, CancellationToken NBBCMDKGJKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BBDCKNOJHBF();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PPFEKJFAONL();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		protected CLMNBGCBCKH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IJFPEHNNBMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<BJHIPBIDKLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IMIOGAHJMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IOADHBFKJOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x21DCC70", Offset = "0x21DC070", VA = "0x1821DCC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x21DCE70", Offset = "0x21DC270", VA = "0x1821DCE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MBBIGECJCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public IMIOGAHJMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public MMCIBAEBBCI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IKCDDPNEMII evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EOEFLIMDACN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OMMIODCOJEM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<BJHIPBIDKLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x21DEEC0", Offset = "0x21DE2C0", VA = "0x1821DEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x21DF400", Offset = "0x21DE800", VA = "0x1821DF400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly PCLAPFKMNLL DBHDOFFCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<IOADHBFKJOJ> NHJILPPDAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<IOADHBFKJOJ> CFLLLMAPEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource HNCEDKMKLAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool AGFDPGJNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCAB850", Offset = "0xCAAC50", VA = "0x180CAB850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xDB0010", Offset = "0xDAF410", VA = "0x180DB0010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x914370", Offset = "0x913770", VA = "0x180914370", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xDB0000", Offset = "0xDAF400", VA = "0x180DB0000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FMBIBNPKJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x13D7450", Offset = "0x13D6850", VA = "0x1813D7450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x21DD970", Offset = "0x21DCD70", VA = "0x1821DD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public BJHIPBIDKLJ? CFLIINJGMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C20", Offset = "0x8B2020", VA = "0x1808B2C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x21DD720", Offset = "0x21DCB20", VA = "0x1821DD720", Slot = "7")]
	[AsyncStateMachine(typeof(IJFPEHNNBMP))]
	public Task<BJHIPBIDKLJ> EFIGCBALAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x21DD980", Offset = "0x21DCD80", VA = "0x1821DD980")]
	public IMIOGAHJMGH(PCLAPFKMNLL CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x21DD810", Offset = "0x21DCC10", VA = "0x1821DD810", Slot = "8")]
	[AsyncStateMachine(typeof(MBBIGECJCLB))]
	public Task GCLFEGPEDPM(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21DD5A0", Offset = "0x21DC9A0", VA = "0x1821DD5A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AEOFCJHHMBM : IJHHLHJOBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly EEFBGIEIMDH OBNEJPHDKGF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public AEOFCJHHMBM(EEFBGIEIMDH GEDJLONGACK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class KMOFCBCNABL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class OBLAJOJLPLH<TGraph> : MJPDFIFLFHA where TGraph : HPGACFOCINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph ENFEMKJHFFI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual MEIKOAABHMC? NHBAOECJBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x120C480", Offset = "0x120B880", VA = "0x18120C480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4A067D0", Offset = "0x4A05BD0", VA = "0x184A067D0", Slot = "5")]
			get
			{
				return default(MIEEFIOIIBN<ABNDNCLMDPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MIEEFIOIIBN<ABNDNCLMDPA>? MJAJCILNEFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4A06750", Offset = "0x4A05B50", VA = "0x184A06750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
		public OBLAJOJLPLH(TGraph CGOGNBPFMJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GOFDPIEFAED : OBLAJOJLPLH<IDDEKGLEALB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MEIKOAABHMC? NHBAOECJBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x21D9600", Offset = "0x21D8A00", VA = "0x1821D9600", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x21D9620", Offset = "0x21D8A20", VA = "0x1821D9620")]
		public GOFDPIEFAED(IDDEKGLEALB DOADMDDAMBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x21DDEB0", Offset = "0x21DD2B0", VA = "0x1821DDEB0")]
	public static MJPDFIFLFHA AHLALEPNKFA(HPGACFOCINO CGOGNBPFMJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class OFNFBDLLMED : MNGEJDPKCBN, IGCEFHEOJEM, PDIJIFKJMKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LJOMDLHCGPL
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
			public LJOMDLHCGPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public GCOEHOKBBPN errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x21F14D0", Offset = "0x21F08D0", VA = "0x1821F14D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21F1740", Offset = "0x21F0B40", VA = "0x1821F1740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public OFNFBDLLMED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LJOMDLHCGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x21DE700", Offset = "0x21DDB00", VA = "0x1821DE700")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task MGBNNFAGHEI(GCOEHOKBBPN errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HGAEAGPGCIO : IAsyncStateMachine
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
		public OFNFBDLLMED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x21DB5B0", Offset = "0x21DA9B0", VA = "0x1821DB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x21DBAB0", Offset = "0x21DAEB0", VA = "0x1821DBAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ENMFGDNGAND
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
			public ENMFGDNGAND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x21F17A0", Offset = "0x21F0BA0", VA = "0x1821F17A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x21F1A80", Offset = "0x21F0E80", VA = "0x1821F1A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public OFNFBDLLMED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public ENMFGDNGAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x21D87F0", Offset = "0x21D7BF0", VA = "0x1821D87F0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task NHKLGEBNJIE(GCOEHOKBBPN errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OLILKFPHGDO BGAEEANLEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<AGBECELHAJJ> MKPFGDHPNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private IBPEIDILKAG NFMMGNFMIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x21E3120", Offset = "0x21E2520", VA = "0x1821E3120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MIEEFIOIIBN<PGPOGLDOPDL> GALPGIIODOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA38A20", Offset = "0xA37E20", VA = "0x180A38A20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MIEEFIOIIBN<PGPOGLDOPDL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA38D90", Offset = "0xA38190", VA = "0x180A38D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MIEEFIOIIBN<AJJFJLHFCKF> JMCBMNEKMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDA9F30", Offset = "0xDA9330", VA = "0x180DA9F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MIEEFIOIIBN<HIBILKABFFC> MFBNKALFKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D1060", Offset = "0x8D0460", VA = "0x1808D1060", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MIEEFIOIIBN<HIBILKABFFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override MIEEFIOIIBN<MJHPFEMDFLB> EKBGBOHCEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x21E4E00", Offset = "0x21E4200", VA = "0x1821E4E00", Slot = "20")]
		get
		{
			return default(MIEEFIOIIBN<MJHPFEMDFLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OADLHELFGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x21E4E50", Offset = "0x21E4250", VA = "0x1821E4E50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x21E5370", Offset = "0x21E4770", VA = "0x1821E5370")]
	private OFNFBDLLMED(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM, OLILKFPHGDO ODGBBOOMINF, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<PGPOGLDOPDL> JJEIDNNKDCH, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, bool POHMJEBINKC, string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x21E2C20", Offset = "0x21E2020", VA = "0x1821E2C20")]
	public static OFNFBDLLMED AHLALEPNKFA(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM, OLILKFPHGDO EBJHHBADCKF, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, MIEEFIOIIBN<PGPOGLDOPDL> JJEIDNNKDCH, bool POHMJEBINKC, bool AFOPELNLDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x21E3140", Offset = "0x21E2540", VA = "0x1821E3140", Slot = "21")]
	protected override void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x21E3520", Offset = "0x21E2920", VA = "0x1821E3520", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x21E45B0", Offset = "0x21E39B0", VA = "0x1821E45B0", Slot = "30")]
	public void HPJHNLJMEKE(AGBECELHAJJ BFNMBCDJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x21E35C0", Offset = "0x21E29C0", VA = "0x1821E35C0", Slot = "27")]
	public void EBIGNBBDDNI(BNBCCGJEHCO HDNEINDHCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x21E3930", Offset = "0x21E2D30", VA = "0x1821E3930", Slot = "28")]
	public void EJJKFALMNOG(JIDKAELFGOD OHGGCNKIPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21E5220", Offset = "0x21E4620", VA = "0x1821E5220", Slot = "23")]
	protected override void PPMNILFOFML(MEBKJLINKLN LPMKAJHJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x21E4B00", Offset = "0x21E3F00", VA = "0x1821E4B00", Slot = "32")]
	public string LIDHNLFOOJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x21E4610", Offset = "0x21E3A10", VA = "0x1821E4610", Slot = "29")]
	public string IICMHIKBGJO(int EOANMDEAJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x21E32B0", Offset = "0x21E26B0", VA = "0x1821E32B0")]
	private void DGEIEOONLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x21E4ED0", Offset = "0x21E42D0", VA = "0x1821E4ED0", Slot = "31")]
	public void PFFCJONNDGE(AGBECELHAJJ BFNMBCDJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x21E5060", Offset = "0x21E4460", VA = "0x1821E5060")]
	private void PKCMDFPLOME(bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21E44A0", Offset = "0x21E38A0", VA = "0x1821E44A0", Slot = "33")]
	[AsyncStateMachine(typeof(HGAEAGPGCIO))]
	public Task HJLGKHELMMD(string EEPLCHCGAIN, bool GEDFCBDALCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x21E4C60", Offset = "0x21E4060", VA = "0x1821E4C60")]
	public void LIJJPECAIPL(string EEPLCHCGAIN, bool GEDFCBDALCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x21E48D0", Offset = "0x21E3CD0", VA = "0x1821E48D0")]
	private void JPFOCDLDPPK(int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA38D90", Offset = "0xA38190", VA = "0x180A38D90")]
	internal void EKPEPDAELKG(MIEEFIOIIBN<PGPOGLDOPDL> EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21E31E0", Offset = "0x21E25E0", VA = "0x1821E31E0")]
	[CompilerGenerated]
	private void CPMLIODOKOH(string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x21E4360", Offset = "0x21E3760", VA = "0x1821E4360")]
	[CompilerGenerated]
	private bool GDPMPODJKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x21E3060", Offset = "0x21E2460", VA = "0x1821E3060")]
	[CompilerGenerated]
	private bool BAJPAKDJDFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x21E34D0", Offset = "0x21E28D0", VA = "0x1821E34D0")]
	[CompilerGenerated]
	private int GIMHEEEMCBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21E4A70", Offset = "0x21E3E70", VA = "0x1821E4A70")]
	[CompilerGenerated]
	private bool KIBPKBPPFIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21E4350", Offset = "0x21E3750", VA = "0x1821E4350")]
	[CompilerGenerated]
	private void GBKEJCCBAKF(string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21E31F0", Offset = "0x21E25F0", VA = "0x1821E31F0")]
	[CompilerGenerated]
	private bool DCPFEDOLGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x21E4DB0", Offset = "0x21E41B0", VA = "0x1821E4DB0")]
	[CompilerGenerated]
	private bool MFLPDEADHIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21E2FD0", Offset = "0x21E23D0", VA = "0x1821E2FD0")]
	[CompilerGenerated]
	private bool ANBNJIAGDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21E34D0", Offset = "0x21E28D0", VA = "0x1821E34D0")]
	[CompilerGenerated]
	private int DKPDMEINCNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21E4F90", Offset = "0x21E4390", VA = "0x1821E4F90")]
	[CompilerGenerated]
	private bool PHEMLHBFFEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x21E42D0", Offset = "0x21E36D0", VA = "0x1821E42D0")]
	[CompilerGenerated]
	private object ENMJHJHKNGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x21E4420", Offset = "0x21E3820", VA = "0x1821E4420")]
	[CompilerGenerated]
	private void GKNEDOALHOO(object EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21E2B50", Offset = "0x21E1F50", VA = "0x1821E2B50")]
	[CompilerGenerated]
	private bool AFIDBPICHML()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NDHKBBEIMHP
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class IEHKBOEADFE : BMAFIOBNPFI<HFFGEBHIBBG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override LGPBEICFJCC AHPOIALCIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9E9140", Offset = "0x9E8540", VA = "0x1809E9140", Slot = "126")]
			get
			{
				return default(LGPBEICFJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x21DC2E0", Offset = "0x21DB6E0", VA = "0x1821DC2E0")]
		public IEHKBOEADFE(MMCIBAEBBCI KNGIFCGKIIP, HFFGEBHIBBG JPNNGBEFPIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class HNBAMCOEKMN : CGPACPEMHBP<EDHOEJPCHFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x21DC1B0", Offset = "0x21DB5B0", VA = "0x1821DC1B0")]
		public HNBAMCOEKMN(MMCIBAEBBCI KNGIFCGKIIP, EDHOEJPCHFJ EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x21DBF10", Offset = "0x21DB310", VA = "0x1821DBF10", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x21DBEC0", Offset = "0x21DB2C0", VA = "0x1821DBEC0")]
		[CompilerGenerated]
		private bool BOJDNHPNKKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x21DC090", Offset = "0x21DB490", VA = "0x1821DC090")]
		[CompilerGenerated]
		private void HNFABMCMEPH(bool EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class MKAIPGEDEAL : CGPACPEMHBP<IMDJBAEJAEL>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JCLPAJKFPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MKAIPGEDEAL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JCLPAJKFPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x21DDB30", Offset = "0x21DCF30", VA = "0x1821DDB30")]
			internal void MOEPJNLOJBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x21DDA90", Offset = "0x21DCE90", VA = "0x1821DDA90")]
			internal bool AHOICCPHLDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x21DDCA0", Offset = "0x21DD0A0", VA = "0x1821DDCA0")]
			internal bool OICGBLFDKCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x21DDB80", Offset = "0x21DCF80", VA = "0x1821DDB80")]
			internal void NNHBOCLIFNJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x21DDAE0", Offset = "0x21DCEE0", VA = "0x1821DDAE0")]
			internal bool EFOLAMGFGCA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x21DF7A0", Offset = "0x21DEBA0", VA = "0x1821DF7A0")]
		public MKAIPGEDEAL(MMCIBAEBBCI KNGIFCGKIIP, IMDJBAEJAEL EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x21DF460", Offset = "0x21DE860", VA = "0x1821DF460", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CPJMAALENBG : CGPACPEMHBP<ENBGMFPBGLF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class DGFHPELIOLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public CPJMAALENBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public DGFHPELIOLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x21D7830", Offset = "0x21D6C30", VA = "0x1821D7830")]
			internal object MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21D7930", Offset = "0x21D6D30", VA = "0x1821D7930")]
			internal bool NJINOALPIJG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x21D7450", Offset = "0x21D6850", VA = "0x1821D7450")]
			internal void AHOICCPHLDO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x21D7A00", Offset = "0x21D6E00", VA = "0x1821D7A00")]
			internal string OICGBLFDKCO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x21D79B0", Offset = "0x21D6DB0", VA = "0x1821D79B0")]
			internal IReadOnlyList<object> NNHBOCLIFNJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x21D77C0", Offset = "0x21D6BC0", VA = "0x1821D77C0")]
			internal bool EFOLAMGFGCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x21D7B60", Offset = "0x21D6F60", VA = "0x1821D7B60")]
			internal bool OLKPPADNCPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x21D76A0", Offset = "0x21D6AA0", VA = "0x1821D76A0")]
			internal void BHPIKOMKOHN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21D6E20", Offset = "0x21D6220", VA = "0x1821D6E20")]
		public CPJMAALENBG(MMCIBAEBBCI KNGIFCGKIIP, ENBGMFPBGLF EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x21D66D0", Offset = "0x21D5AD0", VA = "0x1821D66D0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GCKBIFHBFAJ : CGPACPEMHBP<GDBDMOCDJHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class OJPEMEAFKJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public GCKBIFHBFAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public OJPEMEAFKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21E58A0", Offset = "0x21E4CA0", VA = "0x1821E58A0")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x21E5780", Offset = "0x21E4B80", VA = "0x1821E5780")]
			internal void AHOICCPHLDO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x21E58F0", Offset = "0x21E4CF0", VA = "0x1821E58F0")]
			internal bool OICGBLFDKCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x21D9240", Offset = "0x21D8640", VA = "0x1821D9240")]
		public GCKBIFHBFAJ(MMCIBAEBBCI KNGIFCGKIIP, GDBDMOCDJHJ EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x21D9010", Offset = "0x21D8410", VA = "0x1821D9010", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class DDLHEDNDGJP<TNode> : CGPACPEMHBP<TNode> where TNode : notnull, HOFKJJOFENN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct CLIJFHBNMDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public DDLHEDNDGJP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x598B190", Offset = "0x598A590", VA = "0x18598B190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x598B590", Offset = "0x598A990", VA = "0x18598B590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct COCJOEBIJPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public DDLHEDNDGJP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5A78410", Offset = "0x5A77810", VA = "0x185A78410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5A78810", Offset = "0x5A77C10", VA = "0x185A78810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool GADCCNMEEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MIEEFIOIIBN<BEFCHCFLIDG>? HOLLCEJBJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5C97BB0", Offset = "0x5C96FB0", VA = "0x185C97BB0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x45F97F0", Offset = "0x45F8BF0", VA = "0x1845F97F0")]
		protected DDLHEDNDGJP(MMCIBAEBBCI KNGIFCGKIIP, TNode EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5C97A90", Offset = "0x5C96E90", VA = "0x185C97A90", Slot = "100")]
		[AsyncStateMachine(typeof(DDLHEDNDGJP<>.CLIJFHBNMDJ))]
		public override Task<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> OGPFNHDMHMM(string DDDHPCNFCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5C97950", Offset = "0x5C96D50", VA = "0x185C97950", Slot = "124")]
		public sealed override bool IBPPLOBDHLC(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5C977A0", Offset = "0x5C96BA0", VA = "0x185C977A0", Slot = "112")]
		protected sealed override bool EBJIPOLOLMM(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5C979F0", Offset = "0x5C96DF0", VA = "0x185C979F0", Slot = "113")]
		protected override bool JMKIGODDAEO(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5C97840", Offset = "0x5C96C40", VA = "0x185C97840", Slot = "101")]
		[AsyncStateMachine(typeof(DDLHEDNDGJP<>.COCJOEBIJPJ))]
		public override Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> FKLOAFCPCMP(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FPDJCNKNLCD : GFIMKCGHFHB<LEGNINJDKAD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class ENGMOLPNJNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public FPDJCNKNLCD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public ENGMOLPNJNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x21D86B0", Offset = "0x21D7AB0", VA = "0x1821D86B0")]
			internal bool ADGPGBNFOPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x21D8730", Offset = "0x21D7B30", VA = "0x1821D8730")]
			internal void AEPDCACCBIM(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x21D8FB0", Offset = "0x21D83B0", VA = "0x1821D8FB0")]
		public FPDJCNKNLCD(MMCIBAEBBCI KNGIFCGKIIP, LEGNINJDKAD JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x21D8D60", Offset = "0x21D8160", VA = "0x1821D8D60", Slot = "126")]
		protected override void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class IAEALCEKDFA : IJEAKAIKBNL<JKFJFKEELDO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x21DC220", Offset = "0x21DB620", VA = "0x1821DC220")]
		public IAEALCEKDFA(MMCIBAEBBCI KNGIFCGKIIP, JKFJFKEELDO EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class IJEAKAIKBNL<TNode> : CGPACPEMHBP<TNode> where TNode : notnull, GIMCJHDLFHG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct DAMMFNHPIDD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A0E0", Offset = "0x5C894E0", VA = "0x185C8A0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A5A0", Offset = "0x5C899A0", VA = "0x185C8A5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct EHIJMFPIGKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3B6C0F0", Offset = "0x3B6B4F0", VA = "0x183B6C0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3B6C580", Offset = "0x3B6B980", VA = "0x183B6C580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct CIDHCHDKOAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x5965E40", Offset = "0x5965240", VA = "0x185965E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5966520", Offset = "0x5965920", VA = "0x185966520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class OJOBMHLJGGI
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
				public OJOBMHLJGGI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x386EDB0", Offset = "0x386E1B0", VA = "0x18386EDB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public PAMOHKJEGIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public OJOBMHLJGGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4A16F60", Offset = "0x4A16360", VA = "0x184A16F60")]
			internal bool BHPIKOMKOHN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4A17040", Offset = "0x4A16440", VA = "0x184A17040")]
			internal void MOEPJNLOJBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4A17330", Offset = "0x4A16730", VA = "0x184A17330")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.OJOBMHLJGGI.<<BuildConfigMenuInternal>b__7>d))]
			internal void NJINOALPIJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4A16B50", Offset = "0x4A15F50", VA = "0x184A16B50")]
			internal bool AHOICCPHLDO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class FMOEDGEPFON
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
				public FMOEDGEPFON <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x386EA30", Offset = "0x386DE30", VA = "0x18386EA30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
			public OJOBMHLJGGI CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public FMOEDGEPFON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3F619D0", Offset = "0x3F60DD0", VA = "0x183F619D0")]
			internal void OICGBLFDKCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			internal string NNHBOCLIFNJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			internal void EFOLAMGFGCA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3F61DF0", Offset = "0x3F611F0", VA = "0x183F61DF0")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.FMOEDGEPFON.<<BuildConfigMenuInternal>b__5>d))]
			internal void OLKPPADNCPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class EGGFPEHDGBK
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
				public EGGFPEHDGBK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x386E560", Offset = "0x386D960", VA = "0x18386E560", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
				public EGGFPEHDGBK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<AJJFJLHFCKF>, FOPCNMINEGF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x386E740", Offset = "0x386DB40", VA = "0x18386E740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
				public EGGFPEHDGBK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<OMLEDJJIGFA>, FOPCNMINEGF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x386DEA0", Offset = "0x386D2A0", VA = "0x18386DEA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public PAMOHKJEGIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public BHGCNCEPMNM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public JJPPEDIIBFE selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<IMLHDEKDMHN> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public JJPPEDIIBFE selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<IMLHDEKDMHN> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public EGGFPEHDGBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3B686A0", Offset = "0x3B67AA0", VA = "0x183B686A0")]
			internal bool EOKIMLLMEAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3B684C0", Offset = "0x3B678C0", VA = "0x183B684C0")]
			internal void CDDPCKFGJCM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3B683E0", Offset = "0x3B677E0", VA = "0x183B683E0")]
			internal bool BNFGMOFBOBN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3B688F0", Offset = "0x3B67CF0", VA = "0x183B688F0")]
			internal bool JDJDCPOCGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3B68260", Offset = "0x3B67660", VA = "0x183B68260")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.EGGFPEHDGBK.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void AAJGMOMDJAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3B68300", Offset = "0x3B67700", VA = "0x183B68300")]
			internal bool ALDFEEBFACH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3B685E0", Offset = "0x3B679E0", VA = "0x183B685E0")]
			internal void DADCJHLJDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3B68530", Offset = "0x3B67930", VA = "0x183B68530")]
			internal bool CIFHMHGKAHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3B68830", Offset = "0x3B67C30", VA = "0x183B68830")]
			internal void IGOJBHPFJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3B68710", Offset = "0x3B67B10", VA = "0x183B68710")]
			internal bool FCJDPNGDLML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3B687C0", Offset = "0x3B67BC0", VA = "0x183B687C0")]
			internal bool HFAMKLDLLHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3B68B10", Offset = "0x3B67F10", VA = "0x183B68B10")]
			internal void PHOOMJJGDOA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3B68340", Offset = "0x3B67740", VA = "0x183B68340")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.EGGFPEHDGBK.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void BEFEDIJKBFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3B68B80", Offset = "0x3B67F80", VA = "0x183B68B80")]
			internal bool PIFPLMEDAFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3B68990", Offset = "0x3B67D90", VA = "0x183B68990")]
			internal bool MMKGLFMGMBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3B68AA0", Offset = "0x3B67EA0", VA = "0x183B68AA0")]
			internal void PHGCIOLDMGB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3B68A00", Offset = "0x3B67E00", VA = "0x183B68A00")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.EGGFPEHDGBK.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void NDBDKCFMMDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3B68930", Offset = "0x3B67D30", VA = "0x183B68930")]
			internal bool LNABNOLKLIB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class BECBCIHMIGJ
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
				public BECBCIHMIGJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x386E190", Offset = "0x386D590", VA = "0x18386E190", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
			public EGGFPEHDGBK CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public BECBCIHMIGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x5232730", Offset = "0x5231B30", VA = "0x185232730")]
			internal void FKNEKMGOAFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			internal string GICIMJHOLAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			internal void AKMJHMGMCBD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x5232AE0", Offset = "0x5231EE0", VA = "0x185232AE0")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.BECBCIHMIGJ.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void PFJJHOFHOHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class NPEBEINAOOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public BHGCNCEPMNM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<IMLHDEKDMHN> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public IJEAKAIKBNL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public NPEBEINAOOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x49210C0", Offset = "0x49204C0", VA = "0x1849210C0")]
			internal bool NIEGMDLKJAG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class ACEIKKEPEON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public PDIJIFKJMKB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public NPEBEINAOOA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public ACEIKKEPEON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3FCFA00", Offset = "0x3FCEE00", VA = "0x183FCFA00")]
			internal void KIJNFHCAOAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3FCF890", Offset = "0x3FCEC90", VA = "0x183FCF890")]
			internal bool DIMMJKOLNMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3FCF8E0", Offset = "0x3FCECE0", VA = "0x183FCF8E0")]
			internal void ILJIIPIEFEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3FCFB10", Offset = "0x3FCEF10", VA = "0x183FCFB10")]
			internal bool KJFJAICAHMC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class APPONDJLEKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public IMLHDEKDMHN portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public ACEIKKEPEON CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public APPONDJLEKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x41FCB80", Offset = "0x41FBF80", VA = "0x1841FCB80")]
			internal void GMHOKGIGIHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class MNPEOAFEAJD
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
				public MNPEOAFEAJD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x3870220", Offset = "0x386F620", VA = "0x183870220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
			public JJPPEDIIBFE selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public BHGCNCEPMNM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public PDIJIFKJMKB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public MNPEOAFEAJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4855230", Offset = "0x4854630", VA = "0x184855230")]
			internal int ANKKLABDKBN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4855270", Offset = "0x4854670", VA = "0x184855270")]
			internal void CFJHOMHMLGB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870")]
			internal string GLEDNGMFKLC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x48554B0", Offset = "0x48548B0", VA = "0x1848554B0")]
			[AsyncStateMachine(typeof(IJEAKAIKBNL<>.MNPEOAFEAJD.<<CreatePortItemV2>b__3>d))]
			internal void EGMAACKPCDH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4855570", Offset = "0x4854970", VA = "0x184855570")]
			internal bool NHNAPCNHELP(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> GLHFFOEFDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> JHJGBKNAAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> MPPDDEKCPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> APPGAOAJLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> IFEMHODAADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<MIEEFIOIIBN<BEFCHCFLIDG>, bool> MGLPLPMCHIJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool KOEJKPFIAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool MMMBFMEPKCN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool HBDGAHEMEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool HDAPBBPPFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MIEEFIOIIBN<ABNDNCLMDPA>? MBAEGOGEMFF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4259C60", Offset = "0x4259060", VA = "0x184259C60", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MIEEFIOIIBN<BEFCHCFLIDG>? HOLLCEJBJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4259F30", Offset = "0x4259330", VA = "0x184259F30", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<OCPIDHFODDG<LKDNFLJFHHO>>? AJMIJEEDKAI
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4259D20", Offset = "0x4259120", VA = "0x184259D20", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4259A40", Offset = "0x4258E40", VA = "0x184259A40")]
		public IJEAKAIKBNL(MMCIBAEBBCI KNGIFCGKIIP, TNode EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "129")]
		protected virtual bool MLALICLIJLK(int AGFBLCMNPMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "130")]
		protected virtual bool BCHFNKMKCII(int AGFBLCMNPMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "131")]
		protected virtual bool ODEBKGPJAEK(int AGFBLCMNPMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "132")]
		protected virtual void ODEKNJAILPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x42567F0", Offset = "0x4255BF0", VA = "0x1842567F0", Slot = "124")]
		public override bool IBPPLOBDHLC(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4259880", Offset = "0x4258C80", VA = "0x184259880", Slot = "100")]
		[AsyncStateMachine(typeof(IJEAKAIKBNL<>.DAMMFNHPIDD))]
		public override Task<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> OGPFNHDMHMM(string DDDHPCNFCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4255C60", Offset = "0x4255060", VA = "0x184255C60", Slot = "101")]
		[AsyncStateMachine(typeof(IJEAKAIKBNL<>.EHIJMFPIGKH))]
		public override Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> FKLOAFCPCMP(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x42593E0", Offset = "0x42587E0", VA = "0x1842593E0", Slot = "102")]
		public override void MHEHNLHHDNH(MIEEFIOIIBN<BEFCHCFLIDG> HAJICDLBEKC, MIEEFIOIIBN<BEFCHCFLIDG> KDGMCPCFIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4259160", Offset = "0x4258560", VA = "0x184259160", Slot = "103")]
		public override IEnumerable<IIIMLHFAMEO> MEIMGMDACFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4255200", Offset = "0x4254600", VA = "0x184255200")]
		[AsyncStateMachine(typeof(IJEAKAIKBNL<>.CIDHCHDKOAB))]
		private Task<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> BEIMIBCEFCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "133")]
		protected virtual bool EMFCOAGGECG(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "134")]
		protected virtual bool DFDCPKGOPJN(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "135")]
		protected virtual bool NBDJAHMNAKA(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "136")]
		protected virtual bool PNJECAPDKCB(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "137")]
		protected virtual bool ECFAEHBPBKM(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int CHGOHBNNHGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "138")]
		protected virtual bool MGEHOABMMCG(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int CHGOHBNNHGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "139")]
		protected virtual bool NHCEGJFGCAD(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int LBIPHNGAJOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "140")]
		protected virtual bool FPIELLMLDGB(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int LBIPHNGAJOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "141")]
		protected virtual bool GGCKBPCNJCL(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int CNAIPFMACGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "142")]
		protected virtual bool ELPGCKFDNMA(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, int KLEBBHLPMGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x42595F0", Offset = "0x42589F0", VA = "0x1842595F0", Slot = "143")]
		protected virtual List<JJPPEDIIBFE> NLEKGPCDAHG(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "144")]
		protected virtual void EOMDJEGHMOM(PAMOHKJEGIN NMNIBGDFNJA, CHLBFNOLFDI OIJNFCPIGGJ, BHGCNCEPMNM KEOGHBFEGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4255D70", Offset = "0x4255170", VA = "0x184255D70", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x42579F0", Offset = "0x4256DF0", VA = "0x1842579F0")]
		private CHLBFNOLFDI KDFODHHOKMO(PAMOHKJEGIN NMNIBGDFNJA, BHGCNCEPMNM KEOGHBFEGLO, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4256890", Offset = "0x4255C90", VA = "0x184256890")]
		private List<IMLHDEKDMHN> JGHENMBHLBC(PAMOHKJEGIN NMNIBGDFNJA, BHGCNCEPMNM KEOGHBFEGLO, CHLBFNOLFDI LMFNFKBNONM, bool HADCNPPEHJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4255300", Offset = "0x4254700", VA = "0x184255300")]
		private List<IMLHDEKDMHN> FFJIHENMCPG(PAMOHKJEGIN NMNIBGDFNJA, BHGCNCEPMNM KEOGHBFEGLO, PDIJIFKJMKB IMFOKHINEEP, bool HADCNPPEHJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4255010", Offset = "0x4254410", VA = "0x184255010")]
		private JJPPEDIIBFE AJDJHNAEIHC(List<JJPPEDIIBFE> NAOOEBENJKA, PDIJIFKJMKB IMFOKHINEEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x42599A0", Offset = "0x4258DA0", VA = "0x1842599A0")]
		[CompilerGenerated]
		private IIIMLHFAMEO PMBBDOCMBPM(JFHPLKLODPO PGOOPNPHNCA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class BAOPNNFFHNH : CGPACPEMHBP<BONNFNMHECO>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class IHNHOABJJOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public BAOPNNFFHNH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public IHNHOABJJOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x21DC3D0", Offset = "0x21DB7D0", VA = "0x1821DC3D0")]
			internal int MOEPJNLOJBM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x21DC340", Offset = "0x21DB740", VA = "0x1821DC340")]
			internal void AHOICCPHLDO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x21D5AE0", Offset = "0x21D4EE0", VA = "0x1821D5AE0")]
		public BAOPNNFFHNH(MMCIBAEBBCI KNGIFCGKIIP, BONNFNMHECO EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x21D5920", Offset = "0x21D4D20", VA = "0x1821D5920", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class BAOMNMNEOPD : GFIMKCGHFHB<DEKNLCMFJFN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class KMPFDKDABNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public BAOMNMNEOPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public KMPFDKDABNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x21DE040", Offset = "0x21DD440", VA = "0x1821DE040")]
			internal int ADGPGBNFOPP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x21DE0C0", Offset = "0x21DD4C0", VA = "0x1821DE0C0")]
			internal void AEPDCACCBIM(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x21D58C0", Offset = "0x21D4CC0", VA = "0x1821D58C0")]
		public BAOMNMNEOPD(MMCIBAEBBCI KNGIFCGKIIP, DEKNLCMFJFN JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x21D5680", Offset = "0x21D4A80", VA = "0x1821D5680", Slot = "126")]
		protected override void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class JDIEPKLOANG : CGPACPEMHBP<MMGLLIIKHPO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB5A5B0", Offset = "0xB599B0", VA = "0x180B5A5B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x21DDCF0", Offset = "0x21DD0F0", VA = "0x1821DDCF0")]
		public JDIEPKLOANG(MMCIBAEBBCI KNGIFCGKIIP, MMGLLIIKHPO EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class HCIOPAGNCKK : CGPACPEMHBP<EGJHPFDOIDE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class OMEPDAKAJIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public HCIOPAGNCKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public PAMOHKJEGIN configure;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public OMEPDAKAJIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x21EF750", Offset = "0x21EEB50", VA = "0x1821EF750")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x21EBDC0", Offset = "0x21EB1C0", VA = "0x1821EBDC0")]
			internal void AHOICCPHLDO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x21ECFC0", Offset = "0x21EC3C0", VA = "0x1821ECFC0")]
			internal bool EFOLAMGFGCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x21F01A0", Offset = "0x21EF5A0", VA = "0x1821F01A0")]
			internal bool OLKPPADNCPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x21EC1E0", Offset = "0x21EB5E0", VA = "0x1821EC1E0")]
			internal void BHPIKOMKOHN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x21ED160", Offset = "0x21EC560", VA = "0x1821ED160")]
			internal bool EIEJEPOHFBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x21ECDB0", Offset = "0x21EC1B0", VA = "0x1821ECDB0")]
			internal bool DJBBKLEEMME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x21EF1F0", Offset = "0x21EE5F0", VA = "0x1821EF1F0")]
			internal void LKNFPBNPFAJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x21EFFC0", Offset = "0x21EF3C0", VA = "0x1821EFFC0")]
			internal bool OCFHAIKAGDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x21EF430", Offset = "0x21EE830", VA = "0x1821EF430")]
			internal bool MEJBODADJKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x21EF190", Offset = "0x21EE590", VA = "0x1821EF190")]
			internal void LIKOKMNHOOC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x21EF480", Offset = "0x21EE880", VA = "0x1821EF480")]
			internal bool MFEDIIHLLJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x21E59E0", Offset = "0x21E4DE0", VA = "0x1821E59E0")]
			internal bool ABHLKHJHDJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x21ED460", Offset = "0x21EC860", VA = "0x1821ED460")]
			internal bool FFMCFIJALCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x21EE3B0", Offset = "0x21ED7B0", VA = "0x1821EE3B0")]
			internal bool INKAICAICFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x21ED2A0", Offset = "0x21EC6A0", VA = "0x1821ED2A0")]
			internal bool FADFPMHGACF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x21EF4D0", Offset = "0x21EE8D0", VA = "0x1821EF4D0")]
			internal bool MGLHKIBMANK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x21EF0F0", Offset = "0x21EE4F0", VA = "0x1821EF0F0")]
			internal bool LEJDEEFNFMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x21EC6A0", Offset = "0x21EBAA0", VA = "0x1821EC6A0")]
			internal bool BOPBLEHJMNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x21EC940", Offset = "0x21EBD40", VA = "0x1821EC940")]
			internal bool CKKHELLJCBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x21EFA00", Offset = "0x21EEE00", VA = "0x1821EFA00")]
			internal void NJODIGKAHFL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x21EE980", Offset = "0x21EDD80", VA = "0x1821EE980")]
			internal bool JOMFOPFNLGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x21EFE10", Offset = "0x21EF210", VA = "0x1821EFE10")]
			internal bool NOCDGLNDFFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x21EDED0", Offset = "0x21ED2D0", VA = "0x1821EDED0")]
			internal bool HJFCAPKBNDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x21ED970", Offset = "0x21ECD70", VA = "0x1821ED970")]
			internal bool GIPNJPPPGJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x21EE610", Offset = "0x21EDA10", VA = "0x1821EE610")]
			internal bool IPNGMONECKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x21ECF70", Offset = "0x21EC370", VA = "0x1821ECF70")]
			internal bool EFILGGKJPCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x21EDBE0", Offset = "0x21ECFE0", VA = "0x1821EDBE0")]
			internal bool HAHJMMBCEDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x21E5AD0", Offset = "0x21E4ED0", VA = "0x1821E5AD0")]
			internal bool ACLIMKEKCNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x21ECE00", Offset = "0x21EC200", VA = "0x1821ECE00")]
			internal void DKKBBJLPOPF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x21EE750", Offset = "0x21EDB50", VA = "0x1821EE750")]
			internal bool JHOKKLHAHIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x21EC880", Offset = "0x21EBC80", VA = "0x1821EC880")]
			internal bool CHFDDDJGOMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x21EF840", Offset = "0x21EEC40", VA = "0x1821EF840")]
			internal void NFDFNAEFJMG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x21EE2A0", Offset = "0x21ED6A0", VA = "0x1821EE2A0")]
			internal bool IIOANEIMJOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x21EEAE0", Offset = "0x21EDEE0", VA = "0x1821EEAE0")]
			internal bool KEAPCOCDJAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x21ED360", Offset = "0x21EC760", VA = "0x1821ED360")]
			internal void FCCPHFLFJEK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x21E5CC0", Offset = "0x21E50C0", VA = "0x1821E5CC0")]
			internal List<IMLHDEKDMHN> AFDBJEPMBKJ(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x21E5940", Offset = "0x21E4D40", VA = "0x1821E5940")]
			internal bool AAKKAAKGCHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x21ECF20", Offset = "0x21EC320", VA = "0x1821ECF20")]
			internal int EADGNNAJLMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x21EFE60", Offset = "0x21EF260", VA = "0x1821EFE60")]
			internal void NOKOKGLMLNO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x21ED250", Offset = "0x21EC650", VA = "0x1821ED250")]
			internal bool EPIDGLANJKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x21EE460", Offset = "0x21ED860", VA = "0x1821EE460")]
			internal bool INOJJBFICLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x21EDE30", Offset = "0x21ED230", VA = "0x1821EDE30")]
			internal bool HGJEAEFBHKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x21E5A80", Offset = "0x21E4E80", VA = "0x1821E5A80")]
			internal int ACANLIGMAKH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x21EDCD0", Offset = "0x21ED0D0", VA = "0x1821EDCD0")]
			internal void HBOHBALCBIE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x21EDAF0", Offset = "0x21ECEF0", VA = "0x1821EDAF0")]
			internal bool GNANPKMNJGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x21EF5C0", Offset = "0x21EE9C0", VA = "0x1821EF5C0")]
			internal bool MJMDGLJMMNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x21EF520", Offset = "0x21EE920", VA = "0x1821EF520")]
			internal bool MHDCFCMANGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x21ECD60", Offset = "0x21EC160", VA = "0x1821ECD60")]
			internal bool DINNKAFLFOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x21EBE70", Offset = "0x21EB270", VA = "0x1821EBE70")]
			internal bool AMLDBACIBBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x21ED1B0", Offset = "0x21EC5B0", VA = "0x1821ED1B0")]
			internal bool EIPAFMKGAOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x21EEA20", Offset = "0x21EDE20", VA = "0x1821EEA20")]
			internal string KBIDKPAMLOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x21EE230", Offset = "0x21ED630", VA = "0x1821EE230")]
			internal void IHDNFLLJGOD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x21EE7F0", Offset = "0x21EDBF0", VA = "0x1821EE7F0")]
			internal int JJNDIOMIEHJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x21ED060", Offset = "0x21EC460", VA = "0x1821ED060")]
			internal void EHDPBBMLGMJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x21ED720", Offset = "0x21ECB20", VA = "0x1821ED720")]
			internal bool GDHBDCEEEII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x21ED6D0", Offset = "0x21ECAD0", VA = "0x1821ED6D0")]
			internal bool GCMGOLJJECO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x21ED110", Offset = "0x21EC510", VA = "0x1821ED110")]
			internal bool EIDICKPBMCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x21EF3E0", Offset = "0x21EE7E0", VA = "0x1821EF3E0")]
			internal float MCJLGFFGHPI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21ECC10", Offset = "0x21EC010", VA = "0x1821ECC10")]
			internal void DEDOEDPGJMD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x21E5B70", Offset = "0x21E4F70", VA = "0x1821E5B70")]
			internal bool ADHBOJLIGIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x21E5C70", Offset = "0x21E5070", VA = "0x1821E5C70")]
			internal bool AEPKIKCGDAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x21ECC70", Offset = "0x21EC070", VA = "0x1821ECC70")]
			internal bool DEKCGMBKFCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x21ED500", Offset = "0x21EC900", VA = "0x1821ED500")]
			internal bool FHNCAHGGCOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x21EDC80", Offset = "0x21ED080", VA = "0x1821EDC80")]
			internal bool HBBEEBGLJDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x21EF660", Offset = "0x21EEA60", VA = "0x1821EF660")]
			internal bool MKOGMGFMCGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x21EFA60", Offset = "0x21EEE60", VA = "0x1821EFA60")]
			internal void NJONIHKJEDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x21E5B20", Offset = "0x21E4F20", VA = "0x1821E5B20")]
			internal string ACPDPBFOGKK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x21ED5A0", Offset = "0x21EC9A0", VA = "0x1821ED5A0")]
			internal void FMAMNAEPMBP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x21EC090", Offset = "0x21EB490", VA = "0x1821EC090")]
			internal bool BGIDOEOGLBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x21EE100", Offset = "0x21ED500", VA = "0x1821EE100")]
			internal bool IBCLMKMAHEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x21F0010", Offset = "0x21EF410", VA = "0x1821F0010")]
			internal bool OEDNAKJNKFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x21EC300", Offset = "0x21EB700", VA = "0x1821EC300")]
			internal void BJOHMOOCPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x21EE660", Offset = "0x21EDA60", VA = "0x1821EE660")]
			internal bool JACKCINFLHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x21EC7E0", Offset = "0x21EBBE0", VA = "0x1821EC7E0")]
			internal bool CCLCHENOMKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x21EDF20", Offset = "0x21ED320", VA = "0x1821EDF20")]
			internal bool HLNGDFGPHOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x21F01F0", Offset = "0x21EF5F0", VA = "0x1821F01F0")]
			internal bool OMJDCNIMNJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x21EEEE0", Offset = "0x21EE2E0", VA = "0x1821EEEE0")]
			internal void LBHOMPIAIMO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x21F03A0", Offset = "0x21EF7A0", VA = "0x1821F03A0")]
			internal bool PALNKBOIILO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x21EC9E0", Offset = "0x21EBDE0", VA = "0x1821EC9E0")]
			internal bool CNCMGPLLOLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x21EF250", Offset = "0x21EE650", VA = "0x1821EF250")]
			internal bool LLGPJBCBPKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x21EF0A0", Offset = "0x21EE4A0", VA = "0x1821EF0A0")]
			internal bool LEIEDLOFJMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x21ECA30", Offset = "0x21EBE30", VA = "0x1821ECA30")]
			internal void CPIJEIHGAJE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x21EF7A0", Offset = "0x21EEBA0", VA = "0x1821EF7A0")]
			internal bool NBLGOOCKALG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x21ECCC0", Offset = "0x21EC0C0", VA = "0x1821ECCC0")]
			internal bool DEKIOKDEBPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x21EE9D0", Offset = "0x21EDDD0", VA = "0x1821EE9D0")]
			internal bool KAEIJEBBJAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x21EC990", Offset = "0x21EBD90", VA = "0x1821EC990")]
			internal bool CLMEEMFNGHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x21ECB30", Offset = "0x21EBF30", VA = "0x1821ECB30")]
			internal object DANJCGDIAPF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x21EDA60", Offset = "0x21ECE60", VA = "0x1821EDA60")]
			internal void GMGLCBIAOIO(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x21ED0C0", Offset = "0x21EC4C0", VA = "0x1821ED0C0")]
			internal bool EHMJPOLJHDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x21EF910", Offset = "0x21EED10", VA = "0x1821EF910")]
			internal bool NHNEDNOEJKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x21EE700", Offset = "0x21EDB00", VA = "0x1821EE700")]
			internal int JHCPOHLEPFG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x21EC0E0", Offset = "0x21EB4E0", VA = "0x1821EC0E0")]
			internal void BGPLHFBKHMD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x21ECD10", Offset = "0x21EC110", VA = "0x1821ECD10")]
			internal bool DFMDIJGGOCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x21F0100", Offset = "0x21EF500", VA = "0x1821F0100")]
			internal bool OHAECGPCMKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x21EBE20", Offset = "0x21EB220", VA = "0x1821EBE20")]
			internal int AKNHMHJCJEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x21ED810", Offset = "0x21ECC10", VA = "0x1821ED810")]
			internal void GFIBKJOCBKM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x21EDE80", Offset = "0x21ED280", VA = "0x1821EDE80")]
			internal bool HIGJKNPLLNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x21ECED0", Offset = "0x21EC2D0", VA = "0x1821ECED0")]
			internal bool DPPFKGBIGNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x21EF390", Offset = "0x21EE790", VA = "0x1821EF390")]
			internal bool MABIPGIOHPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x21ED010", Offset = "0x21EC410", VA = "0x1821ED010")]
			internal int EGFFPACECEB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x21EECF0", Offset = "0x21EE0F0", VA = "0x1821EECF0")]
			internal void KIIDDNLLBEH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x21F0550", Offset = "0x21EF950", VA = "0x1821F0550")]
			internal bool PFOKAMBNPCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x21ED3C0", Offset = "0x21EC7C0", VA = "0x1821ED3C0")]
			internal bool FEFIDGIJPMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x21F0150", Offset = "0x21EF550", VA = "0x1821F0150")]
			internal bool OILIHEGMCGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x21EF8A0", Offset = "0x21EECA0", VA = "0x1821EF8A0")]
			internal object NHDEBFNBBPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x21EBFB0", Offset = "0x21EB3B0", VA = "0x1821EBFB0")]
			internal void BCCLACFMDCP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x21F00B0", Offset = "0x21EF4B0", VA = "0x1821F00B0")]
			internal bool OFLALKIPLDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21ED550", Offset = "0x21EC950", VA = "0x1821ED550")]
			internal bool FJEKDKGEPJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x21F05F0", Offset = "0x21EF9F0", VA = "0x1821F05F0")]
			internal object POOBMJHICMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x21EE1A0", Offset = "0x21ED5A0", VA = "0x1821EE1A0")]
			internal void IEIAAKJKFPC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21EDC90", VA = "0x1821EE890")]
			internal bool JLCPJDHHPNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x21EC2B0", Offset = "0x21EB6B0", VA = "0x1821EC2B0")]
			internal int BIMFABBONMM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x21EE400", Offset = "0x21ED800", VA = "0x1821EE400")]
			internal void INKOIEGIHFD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x21EE6B0", Offset = "0x21EDAB0", VA = "0x1821EE6B0")]
			internal bool JGDNMODLDEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x21EC6F0", Offset = "0x21EBAF0", VA = "0x1821EC6F0")]
			internal bool BPGKNNBHHGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x21EE5C0", Offset = "0x21ED9C0", VA = "0x1821EE5C0")]
			internal bool IPJABPDMNOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x21EDD90", Offset = "0x21ED190", VA = "0x1821EDD90")]
			internal int HEDGNGAABEE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x21E5BC0", Offset = "0x21E4FC0", VA = "0x1821E5BC0")]
			internal void ADJOMAGEFKL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x21EEF90", Offset = "0x21EE390", VA = "0x1821EEF90")]
			internal bool LCJKHGCDGIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x21EE150", Offset = "0x21ED550", VA = "0x1821EE150")]
			internal bool IDHGIDLEGOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x21EE500", Offset = "0x21ED900", VA = "0x1821EE500")]
			internal bool IOJGDOOHBBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x21EF340", Offset = "0x21EE740", VA = "0x1821EF340")]
			internal float LPEMDFGBCIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x21EDD30", Offset = "0x21ED130", VA = "0x1821EDD30")]
			internal void HCDALFAOKKF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x21F03F0", Offset = "0x21EF7F0", VA = "0x1821F03F0")]
			internal bool PBEMFKNGGAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x21EFF70", Offset = "0x21EF370", VA = "0x1821EFF70")]
			internal bool OBGBICBDPJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x21EBF10", Offset = "0x21EB310", VA = "0x1821EBF10")]
			internal bool AOOOCJGBBEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x21EEE90", Offset = "0x21EE290", VA = "0x1821EEE90")]
			internal float KPEBBFGIILD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x21EFEC0", Offset = "0x21EF2C0", VA = "0x1821EFEC0")]
			internal void OAHJFHDDPGB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x21EEDF0", Offset = "0x21EE1F0", VA = "0x1821EEDF0")]
			internal bool KMOCDPMEACA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x21EDB40", Offset = "0x21ECF40", VA = "0x1821EDB40")]
			internal bool GNMBLOIHFNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x21EF570", Offset = "0x21EE970", VA = "0x1821EF570")]
			internal string MIONDALIPBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x21EE550", Offset = "0x21ED950", VA = "0x1821EE550")]
			internal void IPGOJELODFK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x21ED7C0", Offset = "0x21ECBC0", VA = "0x1821ED7C0")]
			internal bool GEOAEHNLIBK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x21F0060", Offset = "0x21EF460", VA = "0x1821F0060")]
			internal bool OEPNEDMKEHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x21EED50", Offset = "0x21EE150", VA = "0x1821EED50")]
			internal bool KIOBEMKCJNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x21EE930", Offset = "0x21EDD30", VA = "0x1821EE930")]
			internal bool JNOLMGKNHCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x21F05A0", Offset = "0x21EF9A0", VA = "0x1821F05A0")]
			internal string PHMBPLGGBJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x21EE340", Offset = "0x21ED740", VA = "0x1821EE340")]
			internal void IMIDKINHMOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x21EE2F0", Offset = "0x21ED6F0", VA = "0x1821EE2F0")]
			internal bool ILJKJIKPFFD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x21EF960", Offset = "0x21EED60", VA = "0x1821EF960")]
			internal bool NJFGCCJOEJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x21ED4B0", Offset = "0x21EC8B0", VA = "0x1821ED4B0")]
			internal bool FHBIBEFAMEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x21EC650", Offset = "0x21EBA50", VA = "0x1821EC650")]
			internal bool BOLDAHHMCGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x21EF6B0", Offset = "0x21EEAB0", VA = "0x1821EF6B0")]
			internal string MLIEIJICOGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x21EC240", Offset = "0x21EB640", VA = "0x1821EC240")]
			internal void BIAKMAKCHJA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x21E5990", Offset = "0x21E4D90", VA = "0x1821E5990")]
			internal bool AAOJINLECBH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x21ED870", Offset = "0x21ECC70", VA = "0x1821ED870")]
			internal bool GGHEINCMEBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x21EC740", Offset = "0x21EBB40", VA = "0x1821EC740")]
			internal bool CADHKEIAENF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x21EF2F0", Offset = "0x21EE6F0", VA = "0x1821EF2F0")]
			internal bool LOCCCJLGCDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x21E5A30", Offset = "0x21E4E30", VA = "0x1821E5A30")]
			internal string ABHPDGINMIN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x21EC8D0", Offset = "0x21EBCD0", VA = "0x1821EC8D0")]
			internal void CJOIDDJDBJI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x21EE7A0", Offset = "0x21EDBA0", VA = "0x1821EE7A0")]
			internal bool JJCMCDPDNHN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x21EDC30", Offset = "0x21ED030", VA = "0x1821EDC30")]
			internal bool HBAAKKHCGGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x21EF7F0", Offset = "0x21EEBF0", VA = "0x1821EF7F0")]
			internal bool NDAHPHMBAKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x21EF700", Offset = "0x21EEB00", VA = "0x1821EF700")]
			internal bool MLNGFLCLBNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x21EC830", Offset = "0x21EBC30", VA = "0x1821EC830")]
			internal string CCLNOOGHGIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x21F0330", Offset = "0x21EF730", VA = "0x1821F0330")]
			internal void OPMHCKGPEMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x21EE0B0", Offset = "0x21ED4B0", VA = "0x1821EE0B0")]
			internal bool IAPPDKOGIGM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x21EC790", Offset = "0x21EBB90", VA = "0x1821EC790")]
			internal bool CBCIPLNGAAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x21EEBF0", Offset = "0x21EDFF0", VA = "0x1821EEBF0")]
			internal bool KGIEJDPKABL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x21EE4B0", Offset = "0x21ED8B0", VA = "0x1821EE4B0")]
			internal bool IOFHCCIIONP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21EE060", Offset = "0x21ED460", VA = "0x1821EE060")]
			internal string HPOEMOHEFJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x21ECE60", Offset = "0x21EC260", VA = "0x1821ECE60")]
			internal void DLAADBDJKKK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x21EF610", Offset = "0x21EEA10", VA = "0x1821EF610")]
			internal bool MKECMHJGHEA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x21EBD70", Offset = "0x21EB170", VA = "0x1821EBD70")]
			internal bool AFFMBHPEGCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x21EEE40", Offset = "0x21EE240", VA = "0x1821EEE40")]
			internal bool KNFEBOCNINI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x21EC140", Offset = "0x21EB540", VA = "0x1821EC140")]
			internal bool BHBBDIMPKDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x21EF2A0", Offset = "0x21EE6A0", VA = "0x1821EF2A0")]
			internal string LMFLGAMEJAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x21EEFE0", Offset = "0x21EE3E0", VA = "0x1821EEFE0")]
			internal void LDJBFNCFBHM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x21ED410", Offset = "0x21EC810", VA = "0x1821ED410")]
			internal bool FFBOPCFHFIE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x21EE840", Offset = "0x21EDC40", VA = "0x1821EE840")]
			internal bool JJOGGOFAOAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x21F0240", Offset = "0x21EF640", VA = "0x1821F0240")]
			internal bool ONBEJDMBPAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x21ED610", Offset = "0x21ECA10", VA = "0x1821ED610")]
			internal bool FMNNJFOPJNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x21EDA10", Offset = "0x21ECE10", VA = "0x1821EDA10")]
			internal string GLPOKNFECIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x21ED660", Offset = "0x21ECA60", VA = "0x1821ED660")]
			internal void GBKLJGALLPJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x21EC190", Offset = "0x21EB590", VA = "0x1821EC190")]
			internal bool BHMHGHDIJMF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x21EFF20", Offset = "0x21EF320", VA = "0x1821EFF20")]
			internal bool OAMIBANFEPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x21F0660", Offset = "0x21EFA60", VA = "0x1821F0660")]
			internal bool PPGCKACGNDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x21EE010", Offset = "0x21ED410", VA = "0x1821EE010")]
			internal bool HOGFEJLJKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x21ECA90", Offset = "0x21EBE90", VA = "0x1821ECA90")]
			internal string CPPHAGDNEAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x21EEB30", Offset = "0x21EDF30", VA = "0x1821EEB30")]
			internal void KFEANHDPIHC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x21ED9C0", Offset = "0x21ECDC0", VA = "0x1821ED9C0")]
			internal bool GKPDDHNGOAN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x21EE8E0", Offset = "0x21EDCE0", VA = "0x1821EE8E0")]
			internal bool JMIJDKILNFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x21E5C20", Offset = "0x21E5020", VA = "0x1821E5C20")]
			internal bool ADMPHDPIJFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x21EEDA0", Offset = "0x21EE1A0", VA = "0x1821EEDA0")]
			internal bool KKOBJLHPCNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x21ECAE0", Offset = "0x21EBEE0", VA = "0x1821ECAE0")]
			internal string DADDIHPEAHO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x21ECBA0", Offset = "0x21EBFA0", VA = "0x1821ECBA0")]
			internal void DDPOCJHGMOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x21EC600", Offset = "0x21EBA00", VA = "0x1821EC600")]
			internal bool BNMAMAPJPGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x21EF140", Offset = "0x21EE540", VA = "0x1821EF140")]
			internal bool LFBFDFIDFAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x21EEF40", Offset = "0x21EE340", VA = "0x1821EEF40")]
			internal bool LCEOIAHBBGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x21EF050", Offset = "0x21EE450", VA = "0x1821EF050")]
			internal string LDLAHOAHPJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x21F04E0", Offset = "0x21EF8E0", VA = "0x1821F04E0")]
			internal void PDLLJFKPLDL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x21ED920", Offset = "0x21ECD20", VA = "0x1821ED920")]
			internal bool GILMCGINEPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x21EDDE0", Offset = "0x21ED1E0", VA = "0x1821EDDE0")]
			internal bool HFLFAKGBAIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x21EF9B0", Offset = "0x21EEDB0", VA = "0x1821EF9B0")]
			internal bool NJFODJODEGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x21EC5B0", Offset = "0x21EB9B0", VA = "0x1821EC5B0")]
			internal string BNEOKOIGAEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x21ED2F0", Offset = "0x21EC6F0", VA = "0x1821ED2F0")]
			internal void FBEDOOCDAGK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x21F02E0", Offset = "0x21EF6E0", VA = "0x1821F02E0")]
			internal bool OOLCFPFNHKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x21ED200", Offset = "0x21EC600", VA = "0x1821ED200")]
			internal bool EMBHKODGKPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x21EEC40", Offset = "0x21EE040", VA = "0x1821EEC40")]
			internal bool KHIPBOGBOGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x21EDB90", Offset = "0x21ECF90", VA = "0x1821EDB90")]
			internal string GPKFMENHANE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x21EEA70", Offset = "0x21EDE70", VA = "0x1821EEA70")]
			internal void KDBDHDIBMKF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x21EBEC0", Offset = "0x21EB2C0", VA = "0x1821EBEC0")]
			internal bool AMNDPGBFOMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x21EC040", Offset = "0x21EB440", VA = "0x1821EC040")]
			internal bool BFOFMCMMOPD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x21F0490", Offset = "0x21EF890", VA = "0x1821F0490")]
			internal float PDDEPDJNCJI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x21EEC90", Offset = "0x21EE090", VA = "0x1821EEC90")]
			internal void KIANANDLPKG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x21EDFC0", Offset = "0x21ED3C0", VA = "0x1821EDFC0")]
			internal bool HOAAEKDMJFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x21EDF70", Offset = "0x21ED370", VA = "0x1821EDF70")]
			internal bool HNBIOENAHMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x21F0440", Offset = "0x21EF840", VA = "0x1821F0440")]
			internal bool PBIAOFCKBIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x21EBF60", Offset = "0x21EB360", VA = "0x1821EBF60")]
			internal int BBFBGHFPFPK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x21ED8C0", Offset = "0x21ECCC0", VA = "0x1821ED8C0")]
			internal void GHJMKDLFCEK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x21ED770", Offset = "0x21ECB70", VA = "0x1821ED770")]
			internal bool GENFHBCCGKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x21EEBA0", Offset = "0x21EDFA0", VA = "0x1821EEBA0")]
			internal bool KFJPCJEDJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x21F0290", Offset = "0x21EF690", VA = "0x1821F0290")]
			internal bool ONDPMFMPDHC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class OMOOCDCFIEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public OMEPDAKAJIH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public OMOOCDCFIEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x21F06B0", Offset = "0x21EFAB0", VA = "0x1821F06B0")]
			internal void KJEFEGBENBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class CEBAOKGEEGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public CEBAOKGEEGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x21D5DA0", Offset = "0x21D51A0", VA = "0x1821D5DA0")]
			internal bool DJJGGBDAMPB(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly GNPJLGJHLKA ECEMHOACLBD;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x21DB450", Offset = "0x21DA850", VA = "0x1821DB450")]
		public HCIOPAGNCKK(MMCIBAEBBCI KNGIFCGKIIP, EGJHPFDOIDE EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x21D96F0", Offset = "0x21D8AF0", VA = "0x1821D96F0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class DNECKKHBJHL : CGPACPEMHBP<KLBCBNOMIKP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class HBCEIKOFPAB
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
				public HBCEIKOFPAB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x220DFA0", Offset = "0x220D3A0", VA = "0x18220DFA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public DNECKKHBJHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HBCEIKOFPAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x22013A0", Offset = "0x22007A0", VA = "0x1822013A0")]
			internal string MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x22012D0", Offset = "0x22006D0", VA = "0x1822012D0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void AHOICCPHLDO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2201480", Offset = "0x2200880", VA = "0x182201480")]
			internal int OICGBLFDKCO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x22013F0", Offset = "0x22007F0", VA = "0x1822013F0")]
			internal void NNHBOCLIFNJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x21F5940", Offset = "0x21F4D40", VA = "0x1821F5940")]
		public DNECKKHBJHL(MMCIBAEBBCI KNGIFCGKIIP, KLBCBNOMIKP JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x21F55F0", Offset = "0x21F49F0", VA = "0x1821F55F0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class EDLLLIMFBPD : CGPACPEMHBP<OLHAJHDEADH>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class BOAKNDPGEIJ
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
				public BOAKNDPGEIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x220DC60", Offset = "0x220D060", VA = "0x18220DC60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
				public BOAKNDPGEIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x220E2B0", Offset = "0x220D6B0", VA = "0x18220E2B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public EDLLLIMFBPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public BOAKNDPGEIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x21F4380", Offset = "0x21F3780", VA = "0x1821F4380")]
			internal string MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x21F3FA0", Offset = "0x21F33A0", VA = "0x1821F3FA0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void AHOICCPHLDO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x21F4560", Offset = "0x21F3960", VA = "0x1821F4560")]
			internal int OICGBLFDKCO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x21F4460", Offset = "0x21F3860", VA = "0x1821F4460")]
			internal void NNHBOCLIFNJ(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x21F4170", Offset = "0x21F3570", VA = "0x1821F4170")]
			internal string EFOLAMGFGCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x21F45B0", Offset = "0x21F39B0", VA = "0x1821F45B0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void OLKPPADNCPE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x21F4070", Offset = "0x21F3470", VA = "0x1821F4070")]
			internal bool BHPIKOMKOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x21F43D0", Offset = "0x21F37D0", VA = "0x1821F43D0")]
			internal void NJINOALPIJG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x21F4680", Offset = "0x21F3A80", VA = "0x1821F4680")]
			internal bool OMFODHJIBJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x21F41C0", Offset = "0x21F35C0", VA = "0x1821F41C0")]
			internal void EIEJEPOHFBO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x21F4120", Offset = "0x21F3520", VA = "0x1821F4120")]
			internal float DJBBKLEEMME()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x21F42F0", Offset = "0x21F36F0", VA = "0x1821F42F0")]
			internal void LKNFPBNPFAJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x21F40C0", Offset = "0x21F34C0", VA = "0x1821F40C0")]
			internal int CCDICFDEPPJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x21F4250", Offset = "0x21F3650", VA = "0x1821F4250")]
			internal void HMFIIBGFNGN(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x21F44F0", Offset = "0x21F38F0", VA = "0x1821F44F0")]
			internal bool OCFHAIKAGDB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x21F6ED0", Offset = "0x21F62D0", VA = "0x1821F6ED0")]
		public EDLLLIMFBPD(MMCIBAEBBCI KNGIFCGKIIP, OLHAJHDEADH EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21F6490", Offset = "0x21F5890", VA = "0x1821F6490", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class EKNAIDIOEII : CGPACPEMHBP<BMLJDPPELAF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class EBLEKHHOMGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public EKNAIDIOEII <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public EBLEKHHOMGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x21F6180", Offset = "0x21F5580", VA = "0x1821F6180")]
			internal Dictionary<string, GLMBEIECJOO> MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x21F6130", Offset = "0x21F5530", VA = "0x1821F6130")]
			internal int AHOICCPHLDO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x21F62A0", Offset = "0x21F56A0", VA = "0x1821F62A0")]
			internal void OICGBLFDKCO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x21F6220", Offset = "0x21F5620", VA = "0x1821F6220")]
			internal bool NNHBOCLIFNJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x21FC7C0", Offset = "0x21FBBC0", VA = "0x1821FC7C0")]
		public EKNAIDIOEII(MMCIBAEBBCI KNGIFCGKIIP, BMLJDPPELAF JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x21FC4F0", Offset = "0x21FB8F0", VA = "0x1821FC4F0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class HPNOOCFJNOP : CGPACPEMHBP<AECENPLADBM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class BPGPEPCHABF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public HPNOOCFJNOP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public BPGPEPCHABF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x21F46D0", Offset = "0x21F3AD0", VA = "0x1821F46D0")]
			internal void MOEPJNLOJBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x22019D0", Offset = "0x2200DD0", VA = "0x1822019D0")]
		public HPNOOCFJNOP(MMCIBAEBBCI KNGIFCGKIIP, AECENPLADBM JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2201850", Offset = "0x2200C50", VA = "0x182201850", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class AOPILEMILAF : IJEAKAIKBNL<LGHCLKLGBGB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DIPBNPBNGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DOPEDMBOFHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x21F31A0", Offset = "0x21F25A0", VA = "0x1821F31A0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xA0A470", Offset = "0xA09870", VA = "0x180A0A470", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x21F3140", Offset = "0x21F2540", VA = "0x1821F3140")]
		public AOPILEMILAF(MMCIBAEBBCI KNGIFCGKIIP, LGHCLKLGBGB EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class ICJBIBHLHJK : CGPACPEMHBP<JJGIKBHMBCP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB535C0", Offset = "0xB529C0", VA = "0x180B535C0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2201F20", Offset = "0x2201320", VA = "0x182201F20")]
		public ICJBIBHLHJK(MMCIBAEBBCI KNGIFCGKIIP, JJGIKBHMBCP EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class EDLCNGOOHBH : CGPACPEMHBP<HPJNLJKEMFP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xB83D00", Offset = "0xB83100", VA = "0x180B83D00", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x21F6420", Offset = "0x21F5820", VA = "0x1821F6420")]
		public EDLCNGOOHBH(MMCIBAEBBCI KNGIFCGKIIP, HPJNLJKEMFP EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "112")]
		protected override bool EBJIPOLOLMM(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class CLFONNNEHGB : CGPACPEMHBP<IBDINHMJMNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA16A60", Offset = "0xA15E60", VA = "0x180A16A60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool BBLCCIKHMKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x21F4C10", Offset = "0x21F4010", VA = "0x1821F4C10", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool FIDEPFCAMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x21F4BA0", Offset = "0x21F3FA0", VA = "0x1821F4BA0")]
		public CLFONNNEHGB(MMCIBAEBBCI KNGIFCGKIIP, IBDINHMJMNJ EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class LPJNJHKBMHO : CGPACPEMHBP<MHBLIKPDEFB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9E9140", Offset = "0x9E8540", VA = "0x1809E9140", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool BBLCCIKHMKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2209920", Offset = "0x2208D20", VA = "0x182209920", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool FIDEPFCAMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x22098B0", Offset = "0x2208CB0", VA = "0x1822098B0")]
		public LPJNJHKBMHO(MMCIBAEBBCI KNGIFCGKIIP, MHBLIKPDEFB EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class PFLLMPGJPDL : GFIMKCGHFHB<FKPLNPONGFI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class HPOHEKKLBNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public PFLLMPGJPDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HPOHEKKLBNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2201A40", Offset = "0x2200E40", VA = "0x182201A40")]
			internal float ADGPGBNFOPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2201AC0", Offset = "0x2200EC0", VA = "0x182201AC0")]
			internal void AEPDCACCBIM(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x220C4B0", Offset = "0x220B8B0", VA = "0x18220C4B0")]
		public PFLLMPGJPDL(MMCIBAEBBCI KNGIFCGKIIP, FKPLNPONGFI JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x220C230", Offset = "0x220B630", VA = "0x18220C230", Slot = "126")]
		protected override void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class GCDIPLABDAK : CGPACPEMHBP<BJPFFKOKEFB>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class FLEOECLGMDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public GCDIPLABDAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public FLEOECLGMDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x21FF920", Offset = "0x21FED20", VA = "0x1821FF920")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x21FF800", Offset = "0x21FEC00", VA = "0x1821FF800")]
			internal void AHOICCPHLDO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x21FFF90", Offset = "0x21FF390", VA = "0x1821FFF90")]
		public GCDIPLABDAK(MMCIBAEBBCI KNGIFCGKIIP, BJPFFKOKEFB JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x21FFCF0", Offset = "0x21FF0F0", VA = "0x1821FFCF0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class BDGBBLNLOPF : CGPACPEMHBP<OHMKDMJJOKP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class EKNIAMJNCFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public BDGBBLNLOPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public EKNIAMJNCFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x21FCC10", Offset = "0x21FC010", VA = "0x1821FCC10")]
			internal object MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x21FCD40", Offset = "0x21FC140", VA = "0x1821FCD40")]
			internal bool NJINOALPIJG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x21FC830", Offset = "0x21FBC30", VA = "0x1821FC830")]
			internal void AHOICCPHLDO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x21FCE10", Offset = "0x21FC210", VA = "0x1821FCE10")]
			internal string OICGBLFDKCO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x21FCDC0", Offset = "0x21FC1C0", VA = "0x1821FCDC0")]
			internal IReadOnlyList<object> NNHBOCLIFNJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x21FCBA0", Offset = "0x21FBFA0", VA = "0x1821FCBA0")]
			internal bool EFOLAMGFGCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x21FCF70", Offset = "0x21FC370", VA = "0x1821FCF70")]
			internal bool OLKPPADNCPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x21FCA80", Offset = "0x21FBE80", VA = "0x1821FCA80")]
			internal void BHPIKOMKOHN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x21F3AD0", Offset = "0x21F2ED0", VA = "0x1821F3AD0")]
		public BDGBBLNLOPF(MMCIBAEBBCI KNGIFCGKIIP, OHMKDMJJOKP JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x21F32B0", Offset = "0x21F26B0", VA = "0x1821F32B0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class MLDLDIGFGNO : DDLHEDNDGJP<GABIKNBEGNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA1D370", Offset = "0xA1C770", VA = "0x180A1D370", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x220A360", Offset = "0x2209760", VA = "0x18220A360")]
		public MLDLDIGFGNO(MMCIBAEBBCI KNGIFCGKIIP, GABIKNBEGNL EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class IILLFHJLOHL : GFIMKCGHFHB<NHHNNLCCEML>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class NJEIBEOJFGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public IILLFHJLOHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public NJEIBEOJFGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x220BBE0", Offset = "0x220AFE0", VA = "0x18220BBE0")]
			internal int ADGPGBNFOPP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x220BC60", Offset = "0x220B060", VA = "0x18220BC60")]
			internal void AEPDCACCBIM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2202960", Offset = "0x2201D60", VA = "0x182202960")]
		public IILLFHJLOHL(MMCIBAEBBCI KNGIFCGKIIP, NHHNNLCCEML JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x22026D0", Offset = "0x2201AD0", VA = "0x1822026D0", Slot = "126")]
		protected override void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class JKCENLGKLON : CGPACPEMHBP<BHBNPBOEACB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class PCOAGPLPNNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public JKCENLGKLON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public PCOAGPLPNNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x220C1E0", Offset = "0x220B5E0", VA = "0x18220C1E0")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x220C150", Offset = "0x220B550", VA = "0x18220C150")]
			internal void AHOICCPHLDO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2208F20", Offset = "0x2208320", VA = "0x182208F20")]
		public JKCENLGKLON(MMCIBAEBBCI KNGIFCGKIIP, BHBNPBOEACB JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2208D40", Offset = "0x2208140", VA = "0x182208D40", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class GDCOBLKCNBI : CGPACPEMHBP<ODJOGDOEEOB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class HLEGCLCOEIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public GDCOBLKCNBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HLEGCLCOEIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2201800", Offset = "0x2200C00", VA = "0x182201800")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2201770", Offset = "0x2200B70", VA = "0x182201770")]
			internal void AHOICCPHLDO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x22001E0", Offset = "0x21FF5E0", VA = "0x1822001E0")]
		public GDCOBLKCNBI(MMCIBAEBBCI KNGIFCGKIIP, ODJOGDOEEOB JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2200000", Offset = "0x21FF400", VA = "0x182200000", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class MNKJEIPPCOK : CGPACPEMHBP<OGGIIPKGAEA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class KANJKOLFLNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public MNKJEIPPCOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public KANJKOLFLNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x22091A0", Offset = "0x22085A0", VA = "0x1822091A0")]
			internal int MOEPJNLOJBM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x2209110", Offset = "0x2208510", VA = "0x182209110")]
			internal void AHOICCPHLDO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x220BB10", Offset = "0x220AF10", VA = "0x18220BB10")]
		public MNKJEIPPCOK(MMCIBAEBBCI KNGIFCGKIIP, OGGIIPKGAEA JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x220B8A0", Offset = "0x220ACA0", VA = "0x18220B8A0", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ECJEBIKFCDP : BMAFIOBNPFI<OCGCMGJGNCL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override LGPBEICFJCC AHPOIALCIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "126")]
			get
			{
				return default(LGPBEICFJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x21F63C0", Offset = "0x21F57C0", VA = "0x1821F63C0")]
		public ECJEBIKFCDP(MMCIBAEBBCI KNGIFCGKIIP, OCGCMGJGNCL JPNNGBEFPIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class OKDPFKNDNAH : CGPACPEMHBP<JFHPLKLODPO>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x220C010", Offset = "0x220B410", VA = "0x18220C010")]
		public OKDPFKNDNAH(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class CGPACPEMHBP<TNode> : FCOBIPBEMPJ, IDisposable where TNode : notnull, JFHPLKLODPO
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class IPBIJJAHCFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public CGPACPEMHBP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public MMCIBAEBBCI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public IPBIJJAHCFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x42639B0", Offset = "0x4262DB0", VA = "0x1842639B0")]
			internal JIEMIPNJDBF KJPDGIEKCBF(HMMEDJJIPHL portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct LDMCBAOGBLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public CGPACPEMHBP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4594240", Offset = "0x4593640", VA = "0x184594240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct DNEKHPPLIDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CGPACPEMHBP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public DPPHGIGHBKC? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public FHHIKJNGAEG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x5CC6240", Offset = "0x5CC5640", VA = "0x185CC6240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x5CC64F0", Offset = "0x5CC58F0", VA = "0x185CC64F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class MHKMFACLCMO
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
				public MHKMFACLCMO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x386EFC0", Offset = "0x386E3C0", VA = "0x18386EFC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public CGPACPEMHBP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public PAMOHKJEGIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public MHKMFACLCMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			internal string POPBBLHMFGK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			internal void MCMJPAOEJOM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x47E28E0", Offset = "0x47E1CE0", VA = "0x1847E28E0")]
			[AsyncStateMachine(typeof(CGPACPEMHBP<>.MHKMFACLCMO.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void JKCOFPICDJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class MIFILMJPKCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public MIFILMJPKCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x47E3160", Offset = "0x47E2560", VA = "0x1847E3160")]
			internal bool MMPEJHLLMIE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x47E3150", Offset = "0x47E2550", VA = "0x1847E3150")]
			internal bool MGKOEPLAOEM(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct BHDFMFJIDHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public CGPACPEMHBP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x523A370", Offset = "0x5239770", VA = "0x18523A370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x523A700", Offset = "0x5239B00", VA = "0x18523A700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly MMCIBAEBBCI IINGMIALPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool GJDDCGMCLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private LMPCPDJAHLE<BEFCHCFLIDG, JIEMIPNJDBF> LILJOJFDDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private LMPCPDJAHLE<BEFCHCFLIDG, BHGCNCEPMNM> FKFOKPKMBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> HEACNPAAAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<MIEEFIOIIBN<BEFCHCFLIDG>>? HNOPAHEOMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<MIEEFIOIIBN<BEFCHCFLIDG>, BHGCNCEPMNM>? MDMCEBDLJAP;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected NNEPGCMMILH ACPLGLFFKAO
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x58861C0", Offset = "0x58855C0", VA = "0x1858861C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected ILPNGJHFLPM CAIFNHMBBOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x58844B0", Offset = "0x58838B0", VA = "0x1858844B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode CJNFJNFMPCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public OCPIDHFODDG<KPGIKLGCHFF> HFMOOCFBFIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xDFCAB0", Offset = "0xDFBEB0", VA = "0x180DFCAB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(OCPIDHFODDG<KPGIKLGCHFF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public MIEEFIOIIBN<LIGCAJFGNCM> ACGBLFJPCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x58874B0", Offset = "0x58868B0", VA = "0x1858874B0", Slot = "6")]
			get
			{
				return default(MIEEFIOIIBN<LIGCAJFGNCM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object BAPHJCKPNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3C08AE0", Offset = "0x3C07EE0", VA = "0x183C08AE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool LJFLJIIOKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int BFHKACAHKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x58870E0", Offset = "0x58864E0", VA = "0x1858870E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public NKEEOAFKEJI JHCNIGPCECM
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x5887080", Offset = "0x5886480", VA = "0x185887080", Slot = "10")]
			get
			{
				return default(NKEEOAFKEJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string EPJGEAGOAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x5887670", Offset = "0x5886A70", VA = "0x185887670", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool FIDEPFCAMIF
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MIEEFIOIIBN<EFNGINKMBGE> BONHJKIHLAA
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x98A740", Offset = "0x989B40", VA = "0x18098A740", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MIEEFIOIIBN<EFNGINKMBGE>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x98B330", Offset = "0x98A730", VA = "0x18098B330")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool BBLCCIKHMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool DIPBNPBNGEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual OGEDDDKNCPK HMEAHCEPIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA7EC00", Offset = "0xA7E000", VA = "0x180A7EC00", Slot = "94")]
			get
			{
				return default(OGEDDDKNCPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool LEEBLBGILBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x5886D90", Offset = "0x5886190", VA = "0x185886D90", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool APAFNADJOOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x5886E00", Offset = "0x5886200", VA = "0x185886E00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool OEMAADLMOPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x5886E70", Offset = "0x5886270", VA = "0x185886E70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int EGHBFCFJFLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x5887450", Offset = "0x5886850", VA = "0x185887450", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool EDNBJINBKJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x5887270", Offset = "0x5886670", VA = "0x185887270", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool KBOEPHHOMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x5886FA0", Offset = "0x58863A0", VA = "0x185886FA0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool CFLBLCOOFOB
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5886F30", Offset = "0x5886330", VA = "0x185886F30", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GEOKENIMPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA3ED80", Offset = "0xA3E180", VA = "0x180A3ED80", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xF441F0", Offset = "0xF435F0", VA = "0x180F441F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool IHGENCAOFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool FHAFJLMGMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x5886EE0", Offset = "0x58862E0", VA = "0x185886EE0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool DIJJFHBIOHP
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x58871A0", Offset = "0x58865A0", VA = "0x1858871A0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public DPPHGIGHBKC ADKILKCAHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x5887390", Offset = "0x5886790", VA = "0x185887390", Slot = "28")]
			get
			{
				return default(DPPHGIGHBKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FHHIKJNGAEG CKEEBDBDPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x58873F0", Offset = "0x58867F0", VA = "0x1858873F0", Slot = "30")]
			get
			{
				return default(FHHIKJNGAEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool FGNEHCNLAMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual ECPHBLBIDCJ? HAPMINLODLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual JLPOLKOJIJE? AAOKPBFAAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<OCPIDHFODDG<LKDNFLJFHHO>>? AJMIJEEDKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool CGJOFGCMFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x5887010", Offset = "0x5886410", VA = "0x185887010", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public OCPIDHFODDG<ABNDNCLMDPA> CPLNPIJONIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x58872D0", Offset = "0x58866D0", VA = "0x1858872D0", Slot = "62")]
			get
			{
				return default(OCPIDHFODDG<ABNDNCLMDPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x5887140", Offset = "0x5886540", VA = "0x185887140", Slot = "56")]
			get
			{
				return default(MIEEFIOIIBN<ABNDNCLMDPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool GADCCNMEEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual MIEEFIOIIBN<ABNDNCLMDPA>? MBAEGOGEMFF
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DOPEDMBOFHA
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool PPLALDKEHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x5887200", Offset = "0x5886600", VA = "0x185887200", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCC0", Offset = "0x8AF0C0", VA = "0x1808AFCC0", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD20", Offset = "0x8AF120", VA = "0x1808AFD20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string MDKNDOOJHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public OCPIDHFODDG<LKDNFLJFHHO> DJDPJNGAEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x5887330", Offset = "0x5886730", VA = "0x185887330", Slot = "63")]
			get
			{
				return default(OCPIDHFODDG<LKDNFLJFHHO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public OCPIDHFODDG<LKDNFLJFHHO>? HDBAGFJEJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x5887540", Offset = "0x5886940", VA = "0x185887540", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JEMAAAJFJBC<BEFCHCFLIDG, BHGCNCEPMNM> NIANJJFFNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x5887630", Offset = "0x5886A30", VA = "0x185887630", Slot = "65")]
			get
			{
				return default(JEMAAAJFJBC<BEFCHCFLIDG, BHGCNCEPMNM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual MIEEFIOIIBN<BEFCHCFLIDG>? HOLLCEJBJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool KOEJKPFIAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool JHDNBKNAMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KNLHEEDKMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x5884880", Offset = "0x5883C80", VA = "0x185884880", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5884A20", Offset = "0x5883E20", VA = "0x185884A20", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IAANGNHEGLJ MBDEHPHPPNB
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x5884F30", Offset = "0x5884330", VA = "0x185884F30", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x5886440", Offset = "0x5885840", VA = "0x185886440", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CDEEGMKLMGM ICBCLDDKBPA
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x58864E0", Offset = "0x58858E0", VA = "0x1858864E0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x58862D0", Offset = "0x58856D0", VA = "0x1858862D0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LMFAHAHPFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x5881BA0", Offset = "0x5880FA0", VA = "0x185881BA0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x58845A0", Offset = "0x58839A0", VA = "0x1858845A0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action GNAPDKHFAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x5882020", Offset = "0x5881420", VA = "0x185882020", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x5881C70", Offset = "0x5881070", VA = "0x185881C70", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>, BHGCNCEPMNM> KALAPMNHMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x58856F0", Offset = "0x5884AF0", VA = "0x1858856F0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x5884960", Offset = "0x5883D60", VA = "0x185884960", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>, BHGCNCEPMNM> DEGFLJFIFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x58846C0", Offset = "0x5883AC0", VA = "0x1858846C0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x5885340", Offset = "0x5884740", VA = "0x185885340", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>> AFDNHJBACIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x58866D0", Offset = "0x5885AD0", VA = "0x1858866D0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x5885900", Offset = "0x5884D00", VA = "0x185885900", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>, MIEEFIOIIBN<BEFCHCFLIDG>> OKNFBJGPIBF
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x5884600", Offset = "0x5883A00", VA = "0x185884600", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x5885280", Offset = "0x5884680", VA = "0x185885280", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>, BHGCNCEPMNM> ENLGKEFINGO
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x5884E70", Offset = "0x5884270", VA = "0x185884E70", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x5881D50", Offset = "0x5881150", VA = "0x185881D50", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MIEEFIOIIBN<BEFCHCFLIDG>, MIEEFIOIIBN<BEFCHCFLIDG>> OFAAICLDKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x5882C40", Offset = "0x5882040", VA = "0x185882C40", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x5886580", Offset = "0x5885980", VA = "0x185886580", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x5886790", Offset = "0x5885B90", VA = "0x185886790")]
		[ALGEIKMJAHG("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[ALGEIKMJAHG("Need to handle `Name` better.")]
		protected CGPACPEMHBP(MMCIBAEBBCI KNGIFCGKIIP, TNode EKHCANKHNFM, bool AFOPELNLDGA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x58824D0", Offset = "0x58818D0", VA = "0x1858824D0", Slot = "87")]
		protected virtual void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5883250", Offset = "0x5882650", VA = "0x185883250", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5881AF0", Offset = "0x5880EF0", VA = "0x185881AF0", Slot = "9")]
		[AsyncStateMachine(typeof(CGPACPEMHBP<>.LDMCBAOGBLD))]
		public void AFCFNLFNEMO(int AFLPKBLFOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x5883C60", Offset = "0x5883060", VA = "0x185883C60")]
		public bool FICCALJBNHE([In] DPPHGIGHBKC EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x58860E0", Offset = "0x58854E0", VA = "0x1858860E0")]
		public bool NEOMDPKJPAM([In] FHHIKJNGAEG EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5881E10", Offset = "0x5881210", VA = "0x185881E10", Slot = "32")]
		public void BIMNNJNIOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x58857B0", Offset = "0x5884BB0", VA = "0x1858857B0", Slot = "33")]
		[AsyncStateMachine(typeof(CGPACPEMHBP<>.DNEKHPPLIDL))]
		public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> LPFKOPPJINN(DPPHGIGHBKC? OGHPOADGEMG, FHHIKJNGAEG? MHGGNDLFNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "97")]
		public virtual void JFLPIEFFFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "98")]
		public virtual void FCGEGCEPEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "99")]
		public virtual void GIDDHIIEPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA09390", Offset = "0xA08790", VA = "0x180A09390")]
		protected void BMCNJIJPLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x935990", Offset = "0x934D90", VA = "0x180935990")]
		protected void BBEODLLOFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x23FF650", Offset = "0x23FEA50", VA = "0x1823FF650")]
		private void FKDMJKBNEEO([In] FHHIKJNGAEG MDJOMEFJFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5886370", Offset = "0x5885770", VA = "0x185886370", Slot = "100")]
		public virtual Task<LMFFMMPMNDB<MIEEFIOIIBN<BEFCHCFLIDG>, FOPCNMINEGF>> OGPFNHDMHMM(string DDDHPCNFCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5883CD0", Offset = "0x58830D0", VA = "0x185883CD0", Slot = "101")]
		public virtual Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> FKLOAFCPCMP(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "102")]
		public virtual void MHEHNLHHDNH(MIEEFIOIIBN<BEFCHCFLIDG> HDCNEKKOGHK, MIEEFIOIIBN<BEFCHCFLIDG> JOMHMCFIGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x5885F00", Offset = "0x5885300", VA = "0x185885F00", Slot = "103")]
		public virtual IEnumerable<IIIMLHFAMEO> MEIMGMDACFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5886640", Offset = "0x5885A40", VA = "0x185886640", Slot = "104")]
		public LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF> PGMCHFNDIIA(string FBOCPMBJHCG)
		{
			return default(LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5885F90", Offset = "0x5885390", VA = "0x185885F90", Slot = "47")]
		public bool MIAIDBJLLKK([Out] Guid CNBCAPIFOMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5884FD0", Offset = "0x58843D0", VA = "0x185884FD0")]
		public bool KKDPGLOJBBN([In] Guid HANIKMKPJIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "105")]
		public virtual void PGLAGHNEHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "106")]
		public virtual void OJPFNEEABDC(bool AMLNPHIMNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "107")]
		public virtual IEHLAIBBHEN LCHOELOIKFF([In] BGBFFAPMEKO MMFPOPDDHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x5883050", Offset = "0x5882450", VA = "0x185883050")]
		protected void DIIFEOHBDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x5883B20", Offset = "0x5882F20", VA = "0x185883B20", Slot = "112")]
		protected virtual bool EBJIPOLOLMM(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "113")]
		protected virtual bool JMKIGODDAEO(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected virtual void GFBINPNJIDP(PAMOHKJEGIN MKOANHIDHPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x58820C0", Offset = "0x58814C0", VA = "0x1858820C0")]
		protected void BLMIBKPFFOK(PAMOHKJEGIN NMNIBGDFNJA, Func<string> MHLEIHBOGOM, Action<string> GPHCLHFHBPH, string LEAPEPMBDLE, string PHFJIFMCCLF, string LGJPBHJDNJF, EMBLJLAINDG NDHPPHEILIH, OEFIPCCIDJJ GGHMFJEJALI, Func<string, bool> CHGCFGJGGAG, string KGIFJOBIFLH, Func<string, bool> FEFPIEABAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x58841B0", Offset = "0x58835B0", VA = "0x1858841B0")]
		protected void GGCAOHFLKEC(PAMOHKJEGIN NMNIBGDFNJA, Func<string> MHLEIHBOGOM, Action<string> GPHCLHFHBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5882D00", Offset = "0x5882100", VA = "0x185882D00", Slot = "121")]
		protected virtual void DCOKPHFLAIC(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5883B60", Offset = "0x5882F60", VA = "0x185883B60", Slot = "80")]
		public void EJJKFALMNOG(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5884780", Offset = "0x5883B80", VA = "0x185884780", Slot = "81")]
		public MOAGCKPEMJL IDGAJLOGGLC()
		{
			return default(MOAGCKPEMJL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "124")]
		public virtual bool IBPPLOBDHLC(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x18599B0", Offset = "0x1858DB0", VA = "0x1818599B0")]
		private void JEDEEGCLAMK([In] DPPHGIGHBKC CLHMEGFDOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5885520", Offset = "0x5884920", VA = "0x185885520")]
		private void LHMJKNGDKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x58859C0", Offset = "0x5884DC0", VA = "0x1858859C0")]
		private void MBMCPLAFDON(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, HMMEDJJIPHL JMNCBIMIGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xB6E130", Offset = "0xB6D530", VA = "0x180B6E130")]
		private void AMEDEAHHHHJ(MIEEFIOIIBN<BEFCHCFLIDG> NKPCGMJMEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5882F20", Offset = "0x5882320", VA = "0x185882F20")]
		private void DFMJHHCKBFG(MIEEFIOIIBN<BEFCHCFLIDG> NKPCGMJMEIE, HMMEDJJIPHL HPEBPNEMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5884AC0", Offset = "0x5883EC0", VA = "0x185884AC0")]
		private void JKNGGCNGIEO(MIEEFIOIIBN<BEFCHCFLIDG> HDCNEKKOGHK, MIEEFIOIIBN<BEFCHCFLIDG> JOMHMCFIGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xB6E750", Offset = "0xB6DB50", VA = "0x180B6E750")]
		private void LHONAKODJPG(MIEEFIOIIBN<BEFCHCFLIDG> HDCNEKKOGHK, MIEEFIOIIBN<BEFCHCFLIDG> JOMHMCFIGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5292AD0", Offset = "0x5291ED0", VA = "0x185292AD0")]
		private void JDCMHMKGKPD(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5883DA0", Offset = "0x58831A0", VA = "0x185883DA0")]
		private void FNPJCKGFMEH(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, HMMEDJJIPHL JMNCBIMIGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5885680", Offset = "0x5884A80", VA = "0x185885680")]
		private void LJFBGIMOHCB(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, HMMEDJJIPHL HPEBPNEMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5885400", Offset = "0x5884800", VA = "0x185885400", Slot = "125")]
		[AsyncStateMachine(typeof(CGPACPEMHBP<>.BHDFMFJIDHI))]
		public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> LDHNMLKCKFM(string FBOCPMBJHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5886150", Offset = "0x5885550", VA = "0x185886150", Slot = "54")]
		private void NMBGAPBKLED(object CBMLJPMGBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5883BF0", Offset = "0x5882FF0", VA = "0x185883BF0", Slot = "55")]
		private void FGKIEMDAJJF(object CBMLJPMGBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5884920", Offset = "0x5883D20", VA = "0x185884920", Slot = "29")]
		private bool IJENOELPGGL([In] DPPHGIGHBKC EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5883BB0", Offset = "0x5882FB0", VA = "0x185883BB0", Slot = "31")]
		private bool FELBINDIIOE([In] FHHIKJNGAEG EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5881D10", Offset = "0x5881110", VA = "0x185881D10", Slot = "48")]
		private bool BDOCFDHMHLH([In] Guid HANIKMKPJIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8CC40", Offset = "0x4F8C040", VA = "0x184F8CC40")]
		[CompilerGenerated]
		private string NODPIDPKDIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5886220", Offset = "0x5885620", VA = "0x185886220")]
		[CompilerGenerated]
		private void OCJPEPKIFHP(string DDDHPCNFCEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class ONHKFEBINAM : DDLHEDNDGJP<CBLGPEBENAM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x154DA00", Offset = "0x154CE00", VA = "0x18154DA00", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x220C080", Offset = "0x220B480", VA = "0x18220C080")]
		public ONHKFEBINAM(MMCIBAEBBCI KNGIFCGKIIP, CBLGPEBENAM EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class ABMPIDHKEMK : IJEAKAIKBNL<NPBPMJHIBDL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x21F2D20", Offset = "0x21F2120", VA = "0x1821F2D20")]
		public ABMPIDHKEMK(MMCIBAEBBCI KNGIFCGKIIP, NPBPMJHIBDL EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class BMAFIOBNPFI<T> : CGPACPEMHBP<T> where T : notnull, FPDNOPOMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class JCOKMHKJLOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, GLMBEIECJOO>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public BMAFIOBNPFI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public LGPBEICFJCC clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JCOKMHKJLOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			internal IReadOnlyList<KeyValuePair<string, GLMBEIECJOO>> MOEPJNLOJBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4413380", Offset = "0x4412780", VA = "0x184413380")]
			internal int AHOICCPHLDO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4413A60", Offset = "0x4412E60", VA = "0x184413A60")]
			internal void OICGBLFDKCO(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4413A10", Offset = "0x4412E10", VA = "0x184413A10")]
			internal void NNHBOCLIFNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x44135F0", Offset = "0x44129F0", VA = "0x1844135F0")]
			internal void EFOLAMGFGCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4413980", Offset = "0x4412D80", VA = "0x184413980")]
			internal bool OLKPPADNCPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x44134E0", Offset = "0x44128E0", VA = "0x1844134E0")]
			internal void BHPIKOMKOHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4413980", Offset = "0x4412D80", VA = "0x184413980")]
			internal bool NJINOALPIJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4413C80", Offset = "0x4413080", VA = "0x184413C80")]
			internal float OMFODHJIBJP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4413740", Offset = "0x4412B40", VA = "0x184413740")]
			internal void EIEJEPOHFBO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4413590", Offset = "0x4412990", VA = "0x184413590")]
			internal float DJBBKLEEMME()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x44138C0", Offset = "0x4412CC0", VA = "0x1844138C0")]
			internal void LKNFPBNPFAJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4413530", Offset = "0x4412930", VA = "0x184413530")]
			internal float CCDICFDEPPJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4413800", Offset = "0x4412C00", VA = "0x184413800")]
			internal void HMFIIBGFNGN(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xB82790", Offset = "0xB81B90", VA = "0x180B82790", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract LGPBEICFJCC AHPOIALCIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x52817C0", Offset = "0x5280BC0", VA = "0x1852817C0")]
		public BMAFIOBNPFI(MMCIBAEBBCI KNGIFCGKIIP, T EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5280CA0", Offset = "0x52800A0", VA = "0x185280CA0", Slot = "120")]
		protected sealed override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class HAIKFOHHDDG : CGPACPEMHBP<EFMMFGBFBAH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F9270", Offset = "0x9F8670", VA = "0x1809F9270", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2201260", Offset = "0x2200660", VA = "0x182201260")]
		public HAIKFOHHDDG(MMCIBAEBBCI KNGIFCGKIIP, EFMMFGBFBAH EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CPFHKANACGA : CGPACPEMHBP<OFOJCCJCFHC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class LMAAEFMCOCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public CPFHKANACGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public LMAAEFMCOCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x22097D0", Offset = "0x2208BD0", VA = "0x1822097D0")]
			internal int AHOICCPHLDO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2209820", Offset = "0x2208C20", VA = "0x182209820")]
			internal void OICGBLFDKCO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, GLMBEIECJOO>? MMELJKOEDMO;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x21F5280", Offset = "0x21F4680", VA = "0x1821F5280")]
		public CPFHKANACGA(MMCIBAEBBCI KNGIFCGKIIP, OFOJCCJCFHC EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x21F4F10", Offset = "0x21F4310", VA = "0x1821F4F10", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HBIECPOFMDE : BMAFIOBNPFI<NKJMKCLINFE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override LGPBEICFJCC AHPOIALCIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "126")]
			get
			{
				return default(LGPBEICFJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x22014D0", Offset = "0x22008D0", VA = "0x1822014D0")]
		public HBIECPOFMDE(MMCIBAEBBCI KNGIFCGKIIP, NKJMKCLINFE JPNNGBEFPIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class FCBIDODCMLJ : IJEAKAIKBNL<AKJNKKFBGIL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x21FF0E0", Offset = "0x21FE4E0", VA = "0x1821FF0E0")]
		public FCBIDODCMLJ(MMCIBAEBBCI KNGIFCGKIIP, AKJNKKFBGIL EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class NFAFFIFPOHK : IJEAKAIKBNL<NLAFHEFJPMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x220BB80", Offset = "0x220AF80", VA = "0x18220BB80")]
		public NFAFFIFPOHK(MMCIBAEBBCI KNGIFCGKIIP, NLAFHEFJPMN EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class IFBOLEHBBID : GFIMKCGHFHB<KLKMJFPCAIP>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class BBNFLEPOOGA
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
				public BBNFLEPOOGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x220D950", Offset = "0x220CD50", VA = "0x18220D950", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public IFBOLEHBBID <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public BBNFLEPOOGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x21F31E0", Offset = "0x21F25E0", VA = "0x1821F31E0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void ADGPGBNFOPP(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2202270", Offset = "0x2201670", VA = "0x182202270")]
		public IFBOLEHBBID(MMCIBAEBBCI KNGIFCGKIIP, KLKMJFPCAIP JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2201F90", Offset = "0x2201390", VA = "0x182201F90", Slot = "126")]
		protected override void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class BFGIHGEIKAK : BMAFIOBNPFI<EEHLOGBNFFE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override LGPBEICFJCC AHPOIALCIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xA16A60", Offset = "0xA15E60", VA = "0x180A16A60", Slot = "126")]
			get
			{
				return default(LGPBEICFJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x21F3B40", Offset = "0x21F2F40", VA = "0x1821F3B40")]
		public BFGIHGEIKAK(MMCIBAEBBCI KNGIFCGKIIP, EEHLOGBNFFE JPNNGBEFPIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class OOEHBLBPNHB : CGPACPEMHBP<LKNLHMKCGPB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBE9220", Offset = "0xBE8620", VA = "0x180BE9220", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x220C0E0", Offset = "0x220B4E0", VA = "0x18220C0E0")]
		public OOEHBLBPNHB(MMCIBAEBBCI KNGIFCGKIIP, LKNLHMKCGPB EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class ELAHEOBGLAE : CGPACPEMHBP<AKCPBOBKJNG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool BBLCCIKHMKG
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool FIDEPFCAMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x21FD390", Offset = "0x21FC790", VA = "0x1821FD390")]
		public ELAHEOBGLAE(MMCIBAEBBCI KNGIFCGKIIP, AKCPBOBKJNG EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x21FD020", Offset = "0x21FC420", VA = "0x1821FD020", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x21FD350", Offset = "0x21FC750", VA = "0x1821FD350")]
		private int HLKFCNFDMLC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x21FCFC0", Offset = "0x21FC3C0", VA = "0x1821FCFC0")]
		private void FOAIJHOKHLN(int GLEGKLPKAOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class OLNEJPECLHE : OKDPFKNDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x220C010", Offset = "0x220B410", VA = "0x18220C010")]
		public OLNEJPECLHE(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class KLENFBKFDJE : GFIMKCGHFHB<LEMCKPEHKFK>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x22096C0", Offset = "0x2208AC0", VA = "0x1822096C0")]
		public KLENFBKFDJE(MMCIBAEBBCI KNGIFCGKIIP, LEMCKPEHKFK EKHCANKHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class GFIMKCGHFHB<TVariableNode> : CGPACPEMHBP<TVariableNode> where TVariableNode : notnull, LEMCKPEHKFK
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class AAGGLGAPOID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public GFIMKCGHFHB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public AAGGLGAPOID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x3FC44A0", Offset = "0x3FC38A0", VA = "0x183FC44A0")]
			internal bool MOEPJNLOJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3FC4330", Offset = "0x3FC3730", VA = "0x183FC4330")]
			internal void AHOICCPHLDO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x3FC45C0", Offset = "0x3FC39C0", VA = "0x183FC45C0")]
			internal bool OICGBLFDKCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x3FC4500", Offset = "0x3FC3900", VA = "0x183FC4500")]
			internal void NNHBOCLIFNJ(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x3FC43F0", Offset = "0x3FC37F0", VA = "0x183FC43F0")]
			internal bool EFOLAMGFGCA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class JFDBNNJAPKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public ILPNGJHFLPM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public GFIMKCGHFHB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JFDBNNJAPKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x44196C0", Offset = "0x4418AC0", VA = "0x1844196C0")]
			internal void ADGPGBNFOPP(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xD597B0", Offset = "0xD58BB0", VA = "0x180D597B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override OGEDDDKNCPK HMEAHCEPIDO
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4092AD0", Offset = "0x4091ED0", VA = "0x184092AD0", Slot = "94")]
			get
			{
				return default(OGEDDDKNCPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x4092920", Offset = "0x4091D20", VA = "0x184092920")]
		protected GFIMKCGHFHB(MMCIBAEBBCI KNGIFCGKIIP, TVariableNode EKHCANKHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x40921D0", Offset = "0x40915D0", VA = "0x1840921D0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4092370", Offset = "0x4091770", VA = "0x184092370", Slot = "120")]
		protected override void GFBINPNJIDP(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x4091E30", Offset = "0x4091230", VA = "0x184091E30", Slot = "126")]
		protected virtual void BAHIGLMBKJD(PAMOHKJEGIN NMNIBGDFNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x4092820", Offset = "0x4091C20", VA = "0x184092820", Slot = "105")]
		public override void PGLAGHNEHAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x21E1040", Offset = "0x21E0440", VA = "0x1821E1040")]
	public static FCOBIPBEMPJ AHLALEPNKFA(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class GPIMKCIJLPH : MNGEJDPKCBN, PPNJOJJENBM, PDIJIFKJMKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MIEEFIOIIBN<IMBJFPFGGEG> OICHFKIBENN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8F0", Offset = "0x9BDCF0", VA = "0x1809BE8F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MIEEFIOIIBN<IMBJFPFGGEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MIEEFIOIIBN<JJJHNALFLKF> JJBLGJKLGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9BE910", Offset = "0x9BDD10", VA = "0x1809BE910", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MIEEFIOIIBN<JJJHNALFLKF>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2200F20", Offset = "0x2200320", VA = "0x182200F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private MIEEFIOIIBN<OMLEDJJIGFA> KGDAFCLOEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA171A0", Offset = "0xA165A0", VA = "0x180A171A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override MIEEFIOIIBN<MJHPFEMDFLB> EKBGBOHCEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2200F30", Offset = "0x2200330", VA = "0x182200F30", Slot = "20")]
		get
		{
			return default(MIEEFIOIIBN<MJHPFEMDFLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2200F80", Offset = "0x2200380", VA = "0x182200F80")]
	private GPIMKCIJLPH(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM, HAGCHEBKNGO OCGJNHPJFGM, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<JJJHNALFLKF> KEAJHDKKBAE, MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP, bool POHMJEBINKC, string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2200BD0", Offset = "0x21FFFD0", VA = "0x182200BD0")]
	public static GPIMKCIJLPH AHLALEPNKFA(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM, HAGCHEBKNGO FFCICFEFFCP, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP, MIEEFIOIIBN<JJJHNALFLKF> KEAJHDKKBAE, bool POHMJEBINKC, bool AFOPELNLDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2200F20", Offset = "0x2200320", VA = "0x182200F20")]
	internal void GJKFLNFHGCE(MIEEFIOIIBN<JJJHNALFLKF> EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class MNGEJDPKCBN : PDIJIFKJMKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct LELEMKBPFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LJAJOMHKJGB? DBCMLCCIKNO;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x22097C0", Offset = "0x2208BC0", VA = "0x1822097C0")]
		public void KMNEPMPOIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2209720", Offset = "0x2208B20", VA = "0x182209720")]
		public LJAJOMHKJGB FHDJMNKHKEM(MNGEJDPKCBN LFGEHNLKBBH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly JFHPLKLODPO EKDJFBFHONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private LELEMKBPFIB HEDFGALLGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly HOMOJPAKJAC DFIHLIFGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<INCCKLJKCDG> CFPFOIEIJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<EFMFMOEOPNM> CDOFCDHAFJI;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[ALGEIKMJAHG("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> FGLAOIAEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x220B540", Offset = "0x220A940", VA = "0x18220B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind NOPNCEIKCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9060", Offset = "0x8B8460", VA = "0x1808B9060", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x220B3E0", Offset = "0x220A7E0", VA = "0x18220B3E0", Slot = "6")]
		get
		{
			return default(MIEEFIOIIBN<ABNDNCLMDPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OCPIDHFODDG<ABNDNCLMDPA> CPLNPIJONIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x220A780", Offset = "0x2209B80", VA = "0x18220A780", Slot = "7")]
		get
		{
			return default(OCPIDHFODDG<ABNDNCLMDPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FJIDBMMCBDN KINOPFLOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x208EB90", Offset = "0x208DF90", VA = "0x18208EB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PNFIDHACBOF MFNELEHEHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x220A6E0", Offset = "0x2209AE0", VA = "0x18220A6E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected LJAJOMHKJGB HHHJNHKPIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x220A6E0", Offset = "0x2209AE0", VA = "0x18220A6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage LDAOOCGMLME
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x220B410", Offset = "0x220A810", VA = "0x18220B410", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB70", Offset = "0x8AEF70", VA = "0x1808AFB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public OCPIDHFODDG<LKDNFLJFHHO> DJDPJNGAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x220A3C0", Offset = "0x22097C0", VA = "0x18220A3C0", Slot = "9")]
		get
		{
			return default(OCPIDHFODDG<LKDNFLJFHHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MIEEFIOIIBN<BEFCHCFLIDG> IMGPJMGLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFD0", Offset = "0x9AF3D0", VA = "0x1809AFFD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MIEEFIOIIBN<BEFCHCFLIDG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x9AFCD0", Offset = "0x9AF0D0", VA = "0x1809AFCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract MIEEFIOIIBN<MJHPFEMDFLB> EKBGBOHCEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x220B740", Offset = "0x220AB40", VA = "0x18220B740")]
	protected MNGEJDPKCBN(MMCIBAEBBCI KNGIFCGKIIP, JFHPLKLODPO EKHCANKHNFM, HOMOJPAKJAC IMFOKHINEEP, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, bool POHMJEBINKC, string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x220A3E0", Offset = "0x22097E0", VA = "0x18220A3E0", Slot = "21")]
	protected virtual void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x220A530", Offset = "0x2209930", VA = "0x18220A530", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x220B680", Offset = "0x220AA80", VA = "0x18220B680", Slot = "14")]
	public void PMGDIPPOMJP(INCCKLJKCDG EBILIAAEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x220A680", Offset = "0x2209A80", VA = "0x18220A680", Slot = "15")]
	public void EPKCMBOHEHP(EFMFMOEOPNM EBILIAAEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x220AD60", Offset = "0x220A160", VA = "0x18220AD60", Slot = "16")]
	public void NDLAGGKBMHJ(MEBKJLINKLN LPMKAJHJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x220B6E0", Offset = "0x220AAE0", VA = "0x18220B6E0", Slot = "23")]
	protected virtual void PPMNILFOFML(MEBKJLINKLN LPMKAJHJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x220ABE0", Offset = "0x2209FE0", VA = "0x18220ABE0")]
	private void MPALILLPOPK(bool EFCBJHHANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x220A9D0", Offset = "0x2209DD0", VA = "0x18220A9D0")]
	private void GPDJAACKAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x220A830", Offset = "0x2209C30", VA = "0x18220A830")]
	private void GNJCDNKFBGE([In] JIHJLACBEBK DCJIEGOOABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x220AB80", Offset = "0x2209F80", VA = "0x18220AB80", Slot = "17")]
	public void LKPIHFKDDDF(INCCKLJKCDG EBILIAAEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x220A7D0", Offset = "0x2209BD0", VA = "0x18220A7D0", Slot = "18")]
	public void GMBMAJGIIEO(EFMFMOEOPNM EBILIAAEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB70", Offset = "0x8AEF70", VA = "0x1808AFB70")]
	internal void KEGCMFPHKIK(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x220A7B0", Offset = "0x2209BB0", VA = "0x18220A7B0")]
	internal void FPILONCHDPH(GLNFCHBPOHC CLOGBAKPPIL, FJIDBMMCBDN DPOLEDLIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x9AFCD0", Offset = "0x9AF0D0", VA = "0x1809AFCD0")]
	internal void ABGJKNMIHDI(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class JIEMIPNJDBF : BHGCNCEPMNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class KFPIJPAPPIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public MMCIBAEBBCI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JFHPLKLODPO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KFPIJPAPPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x22091F0", Offset = "0x22085F0", VA = "0x1822091F0")]
		internal OFNFBDLLMED EIPPOMKKPNF((int PortDescIndex, int PortIndex, OLILKFPHGDO InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2209280", Offset = "0x2208680", VA = "0x182209280")]
		internal GPIMKCIJLPH LEGBFGNJAPD(HAGCHEBKNGO i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct GLDLBCMFLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2200700", Offset = "0x21FFB00", VA = "0x182200700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2200B60", Offset = "0x21FFF60", VA = "0x182200B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ILLHFFNFBPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MIEEFIOIIBN<AJJFJLHFCKF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x22029C0", Offset = "0x2201DC0", VA = "0x1822029C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2202D10", Offset = "0x2202110", VA = "0x182202D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct ACFICCKIEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public MIEEFIOIIBN<OMLEDJJIGFA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x21F2D80", Offset = "0x21F2180", VA = "0x1821F2D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x21F30D0", Offset = "0x21F24D0", VA = "0x1821F30D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct ICDNELLGBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public MIEEFIOIIBN<AJJFJLHFCKF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MIEEFIOIIBN<AJJFJLHFCKF> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2201B60", Offset = "0x2200F60", VA = "0x182201B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2201EB0", Offset = "0x22012B0", VA = "0x182201EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct CGJIHOCAHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MIEEFIOIIBN<OMLEDJJIGFA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public MIEEFIOIIBN<OMLEDJJIGFA> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x21F47E0", Offset = "0x21F3BE0", VA = "0x1821F47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x21F4B30", Offset = "0x21F3F30", VA = "0x1821F4B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MHGBKACBGNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2209A30", Offset = "0x2208E30", VA = "0x182209A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2209EA0", Offset = "0x22092A0", VA = "0x182209EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct EADMGJGFEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x21F5D70", Offset = "0x21F5170", VA = "0x1821F5D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x21F60C0", Offset = "0x21F54C0", VA = "0x1821F60C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct DPKJGODHHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public MIEEFIOIIBN<AJJFJLHFCKF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x21F59B0", Offset = "0x21F4DB0", VA = "0x1821F59B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x21F5D00", Offset = "0x21F5100", VA = "0x1821F5D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct EEFDDDLFFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public MIEEFIOIIBN<OMLEDJJIGFA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x21FC040", Offset = "0x21FB440", VA = "0x1821FC040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x21FC390", Offset = "0x21FB790", VA = "0x1821FC390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct BJCBGGODCBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public JJPPEDIIBFE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MIEEFIOIIBN<AJJFJLHFCKF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x21F3BA0", Offset = "0x21F2FA0", VA = "0x1821F3BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x21F3F30", Offset = "0x21F3330", VA = "0x1821F3F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct IGEDJIODOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public JIEMIPNJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public JJPPEDIIBFE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MIEEFIOIIBN<OMLEDJJIGFA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private GCOEHOKBBPN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x22022D0", Offset = "0x22016D0", VA = "0x1822022D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2202660", Offset = "0x2201A60", VA = "0x182202660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool CGLODPGBEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool AHNBMEOHALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private JEMAAAJFJBC<PGPOGLDOPDL, OFNFBDLLMED> AEOELPDBJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private JEMAAAJFJBC<PGPOGLDOPDL, IGCEFHEOJEM> JPGLKPMDIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly JFHPLKLODPO EKDJFBFHONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private JEMAAAJFJBC<JJJHNALFLKF, GPIMKCIJLPH> KFGDFPEPDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private JEMAAAJFJBC<JJJHNALFLKF, PPNJOJJENBM> PJOLMEIOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? JKCFGLINDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly HMMEDJJIPHL AJNNGDBNPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private MIEEFIOIIBN<BEFCHCFLIDG> LDOBOIMPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool GJDDCGMCLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? DNMMHDIMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? APMHEPMHKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<MIEEFIOIIBN<PGPOGLDOPDL>>? FJOILMJJJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<MIEEFIOIIBN<JJJHNALFLKF>>? KMBHHHBMPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private BHGCNCEPMNM.AEIMDIMIACA? KIKOGMPCDMA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HDFGCONCLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x22085E0", Offset = "0x22079E0", VA = "0x1822085E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PNLIBPBIJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2208A90", Offset = "0x2207E90", VA = "0x182208A90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool GAGKMEBECED
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x22060F0", Offset = "0x22054F0", VA = "0x1822060F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public OCPIDHFODDG<ABNDNCLMDPA> CPLNPIJONIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2205900", Offset = "0x2204D00", VA = "0x182205900", Slot = "7")]
		get
		{
			return default(OCPIDHFODDG<ABNDNCLMDPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool DAGMKMJNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x22054A0", Offset = "0x22048A0", VA = "0x1822054A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JEMAAAJFJBC<PGPOGLDOPDL, IGCEFHEOJEM> OLEAPPPALGD
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "9")]
		get
		{
			return default(JEMAAAJFJBC<PGPOGLDOPDL, IGCEFHEOJEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x22060C0", Offset = "0x22054C0", VA = "0x1822060C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public OCPIDHFODDG<LKDNFLJFHHO> DJDPJNGAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2203800", Offset = "0x2202C00", VA = "0x182203800", Slot = "11")]
		get
		{
			return default(OCPIDHFODDG<LKDNFLJFHHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JEMAAAJFJBC<JJJHNALFLKF, PPNJOJJENBM> JCLFJMNFENC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00", Slot = "12")]
		get
		{
			return default(JEMAAAJFJBC<JJJHNALFLKF, PPNJOJJENBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MIEEFIOIIBN<BEFCHCFLIDG> IMGPJMGLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE900", Offset = "0x9BDD00", VA = "0x1809BE900", Slot = "13")]
		get
		{
			return default(MIEEFIOIIBN<BEFCHCFLIDG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FFMPGEFMFON
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x22036A0", Offset = "0x2202AA0", VA = "0x1822036A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x22076B0", Offset = "0x2206AB0", VA = "0x1822076B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action MIDAPCEFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2204660", Offset = "0x2203A60", VA = "0x182204660", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2208B90", Offset = "0x2207F90", VA = "0x182208B90", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MIEEFIOIIBN<PGPOGLDOPDL>, MIEEFIOIIBN<PGPOGLDOPDL>> AMLMMOCDCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2207D80", Offset = "0x2207180", VA = "0x182207D80", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2203A00", Offset = "0x2202E00", VA = "0x182203A00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MIEEFIOIIBN<PGPOGLDOPDL>, MIEEFIOIIBN<PGPOGLDOPDL>> LKHDCKOMIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2208910", Offset = "0x2207D10", VA = "0x182208910", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2208AD0", Offset = "0x2207ED0", VA = "0x182208AD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MIEEFIOIIBN<JJJHNALFLKF>, MIEEFIOIIBN<JJJHNALFLKF>> NEGEKBJDGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2208850", Offset = "0x2207C50", VA = "0x182208850", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22052D0", Offset = "0x22046D0", VA = "0x1822052D0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MIEEFIOIIBN<JJJHNALFLKF>, MIEEFIOIIBN<JJJHNALFLKF>> OKJDGHIKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22086A0", Offset = "0x2207AA0", VA = "0x1822086A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2207AB0", Offset = "0x2206EB0", VA = "0x182207AB0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MIEEFIOIIBN<PGPOGLDOPDL>, IGCEFHEOJEM> EOPKEKPJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2208310", Offset = "0x2207710", VA = "0x182208310", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2205210", Offset = "0x2204610", VA = "0x182205210", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MIEEFIOIIBN<PGPOGLDOPDL>> FPKEADBEDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2205990", Offset = "0x2204D90", VA = "0x182205990", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2203AC0", Offset = "0x2202EC0", VA = "0x182203AC0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MIEEFIOIIBN<PGPOGLDOPDL>, IGCEFHEOJEM> ABMFAKFILBH
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2208500", Offset = "0x2207900", VA = "0x182208500", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2204480", Offset = "0x2203880", VA = "0x182204480", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MIEEFIOIIBN<JJJHNALFLKF>, PPNJOJJENBM> EFGDDPBJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2203740", Offset = "0x2202B40", VA = "0x182203740", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2203820", Offset = "0x2202C20", VA = "0x182203820", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MIEEFIOIIBN<JJJHNALFLKF>> KHHBBAPNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x22074E0", Offset = "0x22068E0", VA = "0x1822074E0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x22089D0", Offset = "0x2207DD0", VA = "0x1822089D0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MIEEFIOIIBN<JJJHNALFLKF>, PPNJOJJENBM> OJMFHHHKLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2207420", Offset = "0x2206820", VA = "0x182207420", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2207BD0", Offset = "0x2206FD0", VA = "0x182207BD0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2208C40", Offset = "0x2208040", VA = "0x182208C40")]
	private JIEMIPNJDBF(bool POHMJEBINKC, MMCIBAEBBCI KNGIFCGKIIP, bool FLGHAPKEKGP, JEMAAAJFJBC<PGPOGLDOPDL, OFNFBDLLMED> HADCNPPEHJP, JEMAAAJFJBC<PGPOGLDOPDL, IGCEFHEOJEM> FOMICKAECJI, JFHPLKLODPO EKHCANKHNFM, JEMAAAJFJBC<JJJHNALFLKF, GPIMKCIJLPH> DJGLHBGKMGE, JEMAAAJFJBC<JJJHNALFLKF, PPNJOJJENBM> HHEEJFBPGNN, string? JPKNBMKPAJN, HMMEDJJIPHL JMNCBIMIGJD, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, bool AFOPELNLDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2203130", Offset = "0x2202530", VA = "0x182203130")]
	public static JIEMIPNJDBF AHLALEPNKFA(bool POHMJEBINKC, MMCIBAEBBCI KNGIFCGKIIP, bool FLGHAPKEKGP, JFHPLKLODPO EKHCANKHNFM, HMMEDJJIPHL JMNCBIMIGJD, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, bool AFOPELNLDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2203CD0", Offset = "0x22030D0", VA = "0x182203CD0")]
	private void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2204710", Offset = "0x2203B10", VA = "0x182204710", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22075C0", Offset = "0x22069C0", VA = "0x1822075C0", Slot = "38")]
	[AsyncStateMachine(typeof(GLDLBCMFLHE))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> IKLMANCGNAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2207750", Offset = "0x2206B50", VA = "0x182207750")]
	private (JMLCDHALKDK, int)? JDDBPIEEOEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2207C90", Offset = "0x2207090", VA = "0x182207C90")]
	private void LCEEGDOJHCN(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x18B1A30", Offset = "0x18B0E30", VA = "0x1818B1A30")]
	private void CEGONOMKHNP(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2205520", Offset = "0x2204920", VA = "0x182205520")]
	private void EODNBBNCBCC(int MNGDLDGGJIM, int JAFIBJHPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2207B70", Offset = "0x2206F70", VA = "0x182207B70")]
	private void KLJNOCFFEON(int MNGDLDGGJIM, int JAFIBJHPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x22061B0", Offset = "0x22055B0", VA = "0x1822061B0")]
	private void HAOGDGONEGM(int JJEFCMBPNOK, MIEEFIOIIBN<PGPOGLDOPDL> AFDIFMICLOL, OLILKFPHGDO KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x22085C0", Offset = "0x22079C0", VA = "0x1822085C0")]
	private void MJIPCBFLAJN(int EFCBJHHANBC, MIEEFIOIIBN<PGPOGLDOPDL> AFDIFMICLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x22075A0", Offset = "0x22069A0", VA = "0x1822075A0")]
	private void IKGEJCMGMGB(int EFCBJHHANBC, MIEEFIOIIBN<PGPOGLDOPDL> AFDIFMICLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2206B60", Offset = "0x2205F60", VA = "0x182206B60")]
	private void HJHKLGIKIJA(int JJEFCMBPNOK, MIEEFIOIIBN<PGPOGLDOPDL> AFDIFMICLOL, OLILKFPHGDO KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x22072D0", Offset = "0x22066D0", VA = "0x1822072D0")]
	private void HPMFEFHKNLA(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xDAA770", Offset = "0xDA9B70", VA = "0x180DAA770")]
	private void DCJHKKNOBPG(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x22070D0", Offset = "0x22064D0", VA = "0x1822070D0")]
	private void HLDBNAACILK(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x18B1A30", Offset = "0x18B0E30", VA = "0x1818B1A30")]
	private void MIOLKKEHDIN(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2207F70", Offset = "0x2207370", VA = "0x182207F70")]
	private void LNIPAEPEDCA(int MNGDLDGGJIM, int JAFIBJHPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2205930", Offset = "0x2204D30", VA = "0x182205930")]
	private void FLAPMBMNNFN(int MNGDLDGGJIM, int JAFIBJHPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2205B80", Offset = "0x2204F80", VA = "0x182205B80")]
	private void GKLDBGECDDD(int JJEFCMBPNOK, MIEEFIOIIBN<JJJHNALFLKF> AFDIFMICLOL, HAGCHEBKNGO KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x22058E0", Offset = "0x2204CE0", VA = "0x1822058E0")]
	private void FGCHHGINAEG(int EFCBJHHANBC, MIEEFIOIIBN<JJJHNALFLKF> AFDIFMICLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x22058C0", Offset = "0x2204CC0", VA = "0x1822058C0")]
	private void FALKEIJFJBN(int EFCBJHHANBC, MIEEFIOIIBN<JJJHNALFLKF> AFDIFMICLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x22066F0", Offset = "0x2205AF0", VA = "0x1822066F0")]
	private void HGEGBLABKPP(int JJEFCMBPNOK, MIEEFIOIIBN<JJJHNALFLKF> AFDIFMICLOL, HAGCHEBKNGO KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2203B80", Offset = "0x2202F80", VA = "0x182203B80")]
	private void CDJEDEJKCOD(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xDAA770", Offset = "0xDA9B70", VA = "0x180DAA770")]
	private void MCEEHKNBBAI(int JJEFCMBPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2205390", Offset = "0x2204790", VA = "0x182205390", Slot = "39")]
	[AsyncStateMachine(typeof(ILLHFFNFBPD))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> EILFOFMDMEG(MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x22071C0", Offset = "0x22065C0", VA = "0x1822071C0", Slot = "40")]
	[AsyncStateMachine(typeof(ACFICCKIEPM))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> HNNNFONMDIA(MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2206FB0", Offset = "0x22063B0", VA = "0x182206FB0", Slot = "41")]
	[AsyncStateMachine(typeof(ICDNELLGBLB))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> HJOCDBPHBDA(MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, MIEEFIOIIBN<AJJFJLHFCKF> CBKFMGLFFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x22038E0", Offset = "0x2202CE0", VA = "0x1822038E0", Slot = "42")]
	[AsyncStateMachine(typeof(CGJIHOCAHLB))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> BIGEGPPBFNE(MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP, MIEEFIOIIBN<OMLEDJJIGFA> CBKFMGLFFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2208760", Offset = "0x2207B60", VA = "0x182208760", Slot = "43")]
	[AsyncStateMachine(typeof(MHGBKACBGNE))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> NGNDBPFCGND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2204540", Offset = "0x2203940", VA = "0x182204540", Slot = "44")]
	[AsyncStateMachine(typeof(EADMGJGFEDG))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> DGEOCHNIOFP(string FBOCPMBJHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2207980", Offset = "0x2206D80", VA = "0x182207980", Slot = "45")]
	[AsyncStateMachine(typeof(DPKJGODHHKF))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> JJADOGDLKLA(MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, string DDDHPCNFCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2205A50", Offset = "0x2204E50", VA = "0x182205A50", Slot = "46")]
	[AsyncStateMachine(typeof(EEFDDDLFFBI))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> GFALHLPECGL(MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP, string DDDHPCNFCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x22083D0", Offset = "0x22077D0", VA = "0x1822083D0", Slot = "47")]
	[AsyncStateMachine(typeof(BJCBGGODCBL))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> MEMKPNKCFOA(MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, JJPPEDIIBFE DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2207E40", Offset = "0x2207240", VA = "0x182207E40", Slot = "48")]
	[AsyncStateMachine(typeof(IGEDJIODOMD))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> LFCJFPGPOBG(MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP, JJPPEDIIBFE DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2202D80", Offset = "0x2202180", VA = "0x182202D80")]
	internal void ABGJKNMIHDI(MIEEFIOIIBN<BEFCHCFLIDG> EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class JMJNIILKGBC : LFMNDGPEAHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface BIKCOHPFLDG
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		GLNFCHBPOHC JBGCJPICIED
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EOEFLIMDACN> NCJLEDPHHNM(CancellationToken NBBCMDKGJKI);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<OMMIODCOJEM> MKGLNFOHMHE(CancellationToken NBBCMDKGJKI);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<DAIGEEMMDMO> EHNLIDMFFNO(CancellationToken NBBCMDKGJKI);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PIHOOPCCAEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<JMJNIILKGBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public MMCIBAEBBCI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EOEFLIMDACN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public OMMIODCOJEM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private BIKCOHPFLDG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private OMMIODCOJEM <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<EOEFLIMDACN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<OMMIODCOJEM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<DAIGEEMMDMO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<HDKNAPMCODO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x220C510", Offset = "0x220B910", VA = "0x18220C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x220CF20", Offset = "0x220C320", VA = "0x18220CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly HDKNAPMCODO LMKPJCPKFIK;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HDKNAPMCODO HCEPMOHJEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	private JMJNIILKGBC(HDKNAPMCODO JEHMCEEGEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2208FB0", Offset = "0x22083B0", VA = "0x182208FB0")]
	[AsyncStateMachine(typeof(PIHOOPCCAEC))]
	public static Task<JMJNIILKGBC> KAJBPLHMDKN(MMCIBAEBBCI KNGIFCGKIIP, EOEFLIMDACN? AAAHDHHHHGN, OMMIODCOJEM? JMBCEPAOBOI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2208F90", Offset = "0x2208390", VA = "0x182208F90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct FMHEDGEMLDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct DKKCOJPDOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FMHEDGEMLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public IIIMLHFAMEO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x21F52F0", Offset = "0x21F46F0", VA = "0x1821F52F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x21F5580", Offset = "0x21F4980", VA = "0x1821F5580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct MHJILGDCNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public IKCDDPNEMII rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public EOEFLIMDACN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public OMMIODCOJEM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FMHEDGEMLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private IIIMLHFAMEO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2209F10", Offset = "0x2209310", VA = "0x182209F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x220A2F0", Offset = "0x22096F0", VA = "0x18220A2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct CLGAGBDPEIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public FMHEDGEMLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x21F4C60", Offset = "0x21F4060", VA = "0x1821F4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x21F4EA0", Offset = "0x21F42A0", VA = "0x1821F4EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly IEOBNKPDNKH AMPKEHMJPIO;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public FMHEDGEMLDN(IEOBNKPDNKH MACGMKINBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x21FF970", Offset = "0x21FED70", VA = "0x1821FF970")]
	[AsyncStateMachine(typeof(DKKCOJPDOJF))]
	private Task<LMFFMMPMNDB<object, FOPCNMINEGF>> HCEICHAIFFA(IIIMLHFAMEO HJOAJFDFEDM, bool BFNNDCCPMOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x21FFB90", Offset = "0x21FEF90", VA = "0x1821FFB90")]
	[AsyncStateMachine(typeof(MHJILGDCNFA))]
	public Task<LMFFMMPMNDB<bool, FOPCNMINEGF?>>? LOMNOLILIKM(int CDNHMMICIOJ, IKCDDPNEMII? NJOPDIAIDJN, EOEFLIMDACN? HOCKCMJEENH, OMMIODCOJEM? JMBCEPAOBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x21FFAA0", Offset = "0x21FEEA0", VA = "0x1821FFAA0")]
	[AsyncStateMachine(typeof(CLGAGBDPEIF))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> KJDEEDGEPIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class HDHCHNBFCAI : FFNKEAOMJEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly PIJMOKLJHHD KHBHLJBNFLJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PIJMOKLJHHD PMOJPKLODGM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	private HDHCHNBFCAI(PIJMOKLJHHD DOCGCLOGABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2201530", Offset = "0x2200930", VA = "0x182201530")]
	public static HDHCHNBFCAI AJCCBGLJAMD(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2201730", Offset = "0x2200B30", VA = "0x182201730", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface BJHIPBIDKLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	HDKNAPMCODO HCEPMOHJEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	BDONJDJNHOP OLFMDCOIJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	DDBGKGHPHBD MGJCAKDLIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	EEFBGIEIMDH ACPLGLFFKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface JBLEPFIJEMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	BJHIPBIDKLJ? CFLIINJGMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool AGFDPGJNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<BJHIPBIDKLJ?>? EFIGCBALAIP();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GCLFEGPEDPM(MMCIBAEBBCI KNGIFCGKIIP, IKCDDPNEMII LKIFMCKPOHL, EOEFLIMDACN? EOEHJDONDDK, OMMIODCOJEM? AAEGJHPHMIC);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[DOEMOBPLMFE("IStaticCV2Instance")]
public interface LFMNDGPEAHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	HDKNAPMCODO HCEPMOHJEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[DOEMOBPLMFE("IStaticEVInstance")]
public interface FFNKEAOMJEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	PIJMOKLJHHD PMOJPKLODGM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class GFAPECLIEPC
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2200250", Offset = "0x21FF650", VA = "0x182200250")]
	public static ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> LKPKPAOKCJJ([In] this ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>> MDIMFOFMFHC)
	{
		return default(ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class MCHEMPBABCG : NAGKPIFKJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool AGFDPGJNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2209970", Offset = "0x2208D70", VA = "0x182209970", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	internal MCHEMPBABCG(MMCIBAEBBCI KNGIFCGKIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class MEHMMJIOJJA : NPODIEKGBCL
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2209990", Offset = "0x2208D90", VA = "0x182209990", Slot = "4")]
	public KCEPCOOCJNC? POKEEKFHJBF(string? DKEBEKMOMNO, string? PEOBBLNCCAO, string? GGNNCIMNPHL, EAHEPOKIDPI.HMOCCDANFDI.EDGGEOMPFPM FHNGGOJEAHM, bool FEBOKODGGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MEHMMJIOJJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class PPAMKCHDBJD : KEIEGLKKNMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct OFPPABILINB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<NNEPGCMMILH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public PPAMKCHDBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<BJHIPBIDKLJ?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x220BD00", Offset = "0x220B100", VA = "0x18220BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x220BFA0", Offset = "0x220B3A0", VA = "0x18220BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<OCPIDHFODDG<KPGIKLGCHFF>>? NOEKGIPKJFK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NNEPGCMMILH? GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x220D620", Offset = "0x220CA20", VA = "0x18220D620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public EEFBGIEIMDH? KJAIIIKJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x220D6A0", Offset = "0x220CAA0", VA = "0x18220D6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool HEJALGJHDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x220D4D0", Offset = "0x220C8D0", VA = "0x18220D4D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FNJNPLGAAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x220D8F0", Offset = "0x220CCF0", VA = "0x18220D8F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	internal PPAMKCHDBJD(MMCIBAEBBCI KNGIFCGKIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x220D530", Offset = "0x220C930", VA = "0x18220D530", Slot = "7")]
	[AsyncStateMachine(typeof(OFPPABILINB))]
	public Task<NNEPGCMMILH> GAKOMHOKBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x220D160", Offset = "0x220C560", VA = "0x18220D160", Slot = "9")]
	public IReadOnlyDictionary<OCPIDHFODDG<ABNDNCLMDPA>, Guid> CNOGKBLBALH(IEnumerable<DHPBNJJBAKM> CEKJDPDEHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x220D720", Offset = "0x220CB20", VA = "0x18220D720")]
	public LMFFMMPMNDB<NIECJKMKJIE, HGFLKMEKLGL> LEBHNBFBIFD([In] NIECJKMKJIE OHLDLLGCABK, IEnumerable<DHPBNJJBAKM> KHPFOMLECLB, int DLGCBJGBNIJ)
	{
		return default(LMFFMMPMNDB<NIECJKMKJIE, HGFLKMEKLGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x220CF90", Offset = "0x220C390", VA = "0x18220CF90", Slot = "8")]
	private LMFFMMPMNDB<NIECJKMKJIE, HGFLKMEKLGL> BMOEIDPIIDJ([In] NIECJKMKJIE OHLDLLGCABK, IEnumerable<DHPBNJJBAKM> KHPFOMLECLB, int DLGCBJGBNIJ)
	{
		return default(LMFFMMPMNDB<NIECJKMKJIE, HGFLKMEKLGL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class EEFBGIEIMDH : NNEPGCMMILH
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class ENILANEHIFP
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class EEJADNGAPKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public HDKNAPMCODO state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public HPGACFOCINO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public EEJADNGAPKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x21FC400", Offset = "0x21FB800", VA = "0x1821FC400")]
			internal bool MLKCICEKGJC(NCNACGGIKBD n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class HIJILGJGKON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HIJILGJGKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x2201750", Offset = "0x2200B50", VA = "0x182201750")]
			internal void FMMCLAGOBNJ(NCNACGGIKBD n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x21FD870", Offset = "0x21FCC70", VA = "0x1821FD870")]
		public static LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK> EPAPKGBPEKK(EEFBGIEIMDH MCPMOAEEEOJ, [In] NNEPGCMMILH.FCPOMANPPNG CJLBFJEOAOD)
		{
			return default(LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x21FDEC0", Offset = "0x21FD2C0", VA = "0x1821FDEC0")]
		internal static LMFFMMPMNDB<(BAFEBAHGNCJ, IEEILMCLHCC), BAPAKJBJLEK> KOCLMNBGEMG(EEFBGIEIMDH MCPMOAEEEOJ, IEEILMCLHCC OPKCBMBHGJO, bool MLMPIBDJAHN, [In] OCPIDHFODDG<ABNDNCLMDPA> ALKLJLCLFAM, [In] int? IOKEKOBDJPJ, [In] MOAGCKPEMJL? GLAGJNCBJFO, [In] MOAGCKPEMJL? LLDKAJCDNPD)
		{
			return default(LMFFMMPMNDB<(BAFEBAHGNCJ, IEEILMCLHCC), BAPAKJBJLEK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x21FD400", Offset = "0x21FC800", VA = "0x1821FD400")]
		private static void ALKCFGCICHI(bool MLMPIBDJAHN, DHPBNJJBAKM OHJDHAOMKKE, BAFEBAHGNCJ DOIIMHNCIFM, [In] OCPIDHFODDG<ABNDNCLMDPA> ALKLJLCLFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x21FECD0", Offset = "0x21FE0D0", VA = "0x1821FECD0")]
		public static void MGJEPGCDFAH(GBGNGFHNOCN JINDJJAONIN, [In] NNEPGCMMILH.PIJHEBGONBF KGMCGHKBLAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x21FDDD0", Offset = "0x21FD1D0", VA = "0x1821FDDD0")]
		[CompilerGenerated]
		internal static bool IEPBIAOCDAL(HDKNAPMCODO NDHFMMHDPEB, HPGACFOCINO BGGOMEHLOKD, NCNACGGIKBD GNBCEMNBPBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x21FD840", Offset = "0x21FCC40", VA = "0x1821FD840")]
		[CompilerGenerated]
		internal static bool EHLDACCBBNN(NCNACGGIKBD BDAAIBDOCNE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct FDFJBEOFAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public EEFBGIEIMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public MIEEFIOIIBN<ABNDNCLMDPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public MIEEFIOIIBN<IMBJFPFGGEG> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public MIEEFIOIIBN<HIBILKABFFC> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x21FF140", Offset = "0x21FE540", VA = "0x1821FF140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x21FF790", Offset = "0x21FEB90", VA = "0x1821FF790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct KIMOKHCLMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public EEFBGIEIMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public OCPIDHFODDG<LKDNFLJFHHO> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public OCPIDHFODDG<ABNDNCLMDPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public MIEEFIOIIBN<BEFCHCFLIDG> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public MIEEFIOIIBN<PGPOGLDOPDL> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2209310", Offset = "0x2208710", VA = "0x182209310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x2209650", Offset = "0x2208A50", VA = "0x182209650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct DLKFKAMFEHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public EEFBGIEIMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public OCPIDHFODDG<LKDNFLJFHHO> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public OCPIDHFODDG<ABNDNCLMDPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public MIEEFIOIIBN<BEFCHCFLIDG> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MIEEFIOIIBN<JJJHNALFLKF> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x220F280", Offset = "0x220E680", VA = "0x18220F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x220F5C0", Offset = "0x220E9C0", VA = "0x18220F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly MMCIBAEBBCI IINGMIALPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly LFMNDGPEAHI CPKEKNCLHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly FFNKEAOMJEC LELKKKDGKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly GNPJLGJHLKA ECEMHOACLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly PPAMKCHDBJD OAHKFINBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<OCPIDHFODDG<LKDNFLJFHHO>, FCOBIPBEMPJ> BHABKPPKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<OCPIDHFODDG<LKDNFLJFHHO>>? LMFAHAHPFGP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public OCPIDHFODDG<ABNDNCLMDPA> JOBABELLDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x21F6F70", Offset = "0x21F6370", VA = "0x1821F6F70", Slot = "4")]
		get
		{
			return default(OCPIDHFODDG<ABNDNCLMDPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GNPJLGJHLKA PCFPEEGGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x21E0560", Offset = "0x21DF960", VA = "0x1821E0560", Slot = "5")]
		get
		{
			return default(GNPJLGJHLKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x21FBB20", Offset = "0x21FAF20", VA = "0x1821FBB20")]
	public EEFBGIEIMDH(MMCIBAEBBCI KNGIFCGKIIP, LFMNDGPEAHI LFAPDIELPCG, FFNKEAOMJEC DOBJAGLEDDC, PPAMKCHDBJD LBCLIMIAGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x21F8ED0", Offset = "0x21F82D0", VA = "0x1821F8ED0", Slot = "48")]
	public MIEEFIOIIBN<MADBHGONAGC> GEFCFKKGKML(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
		return default(MIEEFIOIIBN<MADBHGONAGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x21F7C80", Offset = "0x21F7080", VA = "0x1821F7C80", Slot = "49")]
	public MIEEFIOIIBN<JBHLDNPLMJO> CCJJHEBBDJI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
		return default(MIEEFIOIIBN<JBHLDNPLMJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x21FAE40", Offset = "0x21FA240", VA = "0x1821FAE40", Slot = "6")]
	public (bool, bool) MENDMAAADAD(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x21F87B0", Offset = "0x21F7BB0", VA = "0x1821F87B0")]
	public bool FIIIPADEJJI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] CAEMFDLOEGM BLNJILGIDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x21F71A0", Offset = "0x21F65A0", VA = "0x1821F71A0", Slot = "8")]
	public bool AOLGBAAFFBA(IGCEFHEOJEM GOABHCHMKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x21F8390", Offset = "0x21F7790", VA = "0x1821F8390", Slot = "9")]
	public bool DKNDAIPGGDL(PPNJOJJENBM GEAEEEJKFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x21F8490", Offset = "0x21F7890", VA = "0x1821F8490", Slot = "10")]
	public PMGCIMHFMNC? EDAOIDPFOOP(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x21FB340", Offset = "0x21FA740", VA = "0x1821FB340", Slot = "11")]
	public NOFJIPNLPKA? MGODJPLJLPB(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x21FA2B0", Offset = "0x21F96B0", VA = "0x1821FA2B0", Slot = "12")]
	public IEnumerable<MIEEFIOIIBN<PPFGLOGNGAN>> JNHMLBCANBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x21FA360", Offset = "0x21F9760", VA = "0x1821FA360", Slot = "13")]
	public string KAFCDJDHOPP(MIEEFIOIIBN<PPFGLOGNGAN> HAGHHNEPMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x21FADD0", Offset = "0x21FA1D0", VA = "0x1821FADD0", Slot = "14")]
	public string MADFBDMCLFF(MIEEFIOIIBN<PPFGLOGNGAN> HAGHHNEPMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x21F8F50", Offset = "0x21F8350", VA = "0x1821F8F50")]
	public FCOBIPBEMPJ? GJONGLNKHMA([In] OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x21F8410", Offset = "0x21F7810", VA = "0x1821F8410")]
	public MIEEFIOIIBN<LKDNFLJFHHO> DNFHOCJJMPI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] OCPIDHFODDG<LKDNFLJFHHO> MLBFNNCEODL)
	{
		return default(MIEEFIOIIBN<LKDNFLJFHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x21F78B0", Offset = "0x21F6CB0", VA = "0x1821F78B0", Slot = "26")]
	public MIEEFIOIIBN<LKDNFLJFHHO> BKFPIFBOGCP(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
		return default(MIEEFIOIIBN<LKDNFLJFHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x21F8BD0", Offset = "0x21F7FD0", VA = "0x1821F8BD0", Slot = "27")]
	public MIEEFIOIIBN<LKDNFLJFHHO> FMMBAJOAIPE(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
		return default(MIEEFIOIIBN<LKDNFLJFHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x21FB670", Offset = "0x21FAA70", VA = "0x1821FB670")]
	private void PFJFGELILFP(OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x21FAAC0", Offset = "0x21F9EC0", VA = "0x1821FAAC0")]
	public IEnumerable<FCOBIPBEMPJ> LCIDEGMIOKA([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x21F7110", Offset = "0x21F6510", VA = "0x1821F7110", Slot = "25")]
	public MIEEFIOIIBN<HIBILKABFFC> ANDAPEALPEG(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<MADBHGONAGC> CNAIPFMACGM)
	{
		return default(MIEEFIOIIBN<HIBILKABFFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x21FABA0", Offset = "0x21F9FA0", VA = "0x1821FABA0", Slot = "28")]
	public MIEEFIOIIBN<IMBJFPFGGEG> LDEEPFMKPBI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<JBHLDNPLMJO> KLEBBHLPMGG)
	{
		return default(MIEEFIOIIBN<IMBJFPFGGEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x21F7E70", Offset = "0x21F7270", VA = "0x1821F7E70")]
	private FCOBIPBEMPJ? DEDKFKEAOHM([In] OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x21F77E0", Offset = "0x21F6BE0", VA = "0x1821F77E0")]
	private FCOBIPBEMPJ BKEMGIBDLBF([In] OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM, JFHPLKLODPO EKHCANKHNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x21FB400", Offset = "0x21FA800", VA = "0x1821FB400")]
	public JFHPLKLODPO? MKNCOHGHNMM([In] OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x21F6F40", Offset = "0x21F6340", VA = "0x1821F6F40")]
	public MJPDFIFLFHA? CAPOLDCAFLL([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x21F6FD0", Offset = "0x21F63D0", VA = "0x1821F6FD0", Slot = "20")]
	public IEnumerable<KLPCAFMGILJ> AGCFMHFFCNA(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x21F8630", Offset = "0x21F7A30", VA = "0x1821F8630", Slot = "21")]
	public bool EJHLHJBFAAK(MIEEFIOIIBN<PPFGLOGNGAN> HAGHHNEPMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x21F79B0", Offset = "0x21F6DB0", VA = "0x1821F79B0", Slot = "22")]
	public IEnumerable<CAEMFDLOEGM> BLLCDAGKPNI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x21F8C50", Offset = "0x21F8050", VA = "0x1821F8C50", Slot = "23")]
	public IEnumerable<CAEMFDLOEGM> FNGGFPGIMJC(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x21FAA40", Offset = "0x21F9E40", VA = "0x1821FAA40")]
	public MIEEFIOIIBN<ABNDNCLMDPA> LCDONJKGBBF([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(MIEEFIOIIBN<ABNDNCLMDPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x21F7290", Offset = "0x21F6690", VA = "0x1821F7290")]
	public MIEEFIOIIBN<ABNDNCLMDPA>? BGDGCOCOCBJ([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x21F9AF0", Offset = "0x21F8EF0", VA = "0x1821F9AF0")]
	private HPGACFOCINO? JFGPBOKMNFN([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x21F6F40", Offset = "0x21F6340", VA = "0x1821F6F40")]
	private MJPDFIFLFHA? ACBHDDIIGNC([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x21F7220", Offset = "0x21F6620", VA = "0x1821F7220", Slot = "32")]
	public OCPIDHFODDG<ABNDNCLMDPA> BBFEFEAJADE(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(OCPIDHFODDG<ABNDNCLMDPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x21FB570", Offset = "0x21FA970", VA = "0x1821FB570", Slot = "29")]
	public IEnumerable<JJPPEDIIBFE> PEJDHLBBGKC(APGGJPBALIL NHHHDJMHPLL, bool AIEGKADNMPC, bool CANGKBNLFBH, bool AAJPPFKLFMC, bool FMGGNCGOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x21F8080", Offset = "0x21F7480", VA = "0x1821F8080", Slot = "30")]
	public JJPPEDIIBFE DGLJJJDIANF(APGGJPBALIL NHHHDJMHPLL, PDIJIFKJMKB KGBMFLPFKMG, bool AIEGKADNMPC, bool CANGKBNLFBH, bool AAJPPFKLFMC, bool FMGGNCGOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x21F7D00", Offset = "0x21F7100", VA = "0x1821F7D00")]
	public KLPCAFMGILJ NGBHNLPDHIO(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] CAEMFDLOEGM BLNJILGIDKA)
	{
		return default(KLPCAFMGILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x21F9CA0", Offset = "0x21F90A0", VA = "0x1821F9CA0", Slot = "33")]
	public CAEMFDLOEGM JIDPFFFMAKC(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
		return default(CAEMFDLOEGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x21FA530", Offset = "0x21F9930", VA = "0x1821FA530", Slot = "34")]
	public bool KNADILMEOEC(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x21F7090", Offset = "0x21F6490", VA = "0x1821F7090", Slot = "35")]
	public bool ALCOLMPNJIG(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x21F8550", Offset = "0x21F7950", VA = "0x1821F8550", Slot = "36")]
	public bool EHFAKALDKPN(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x21F7C50", Offset = "0x21F7050", VA = "0x1821F7C50")]
	public LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK> CAOEIDDCLNF([In] NNEPGCMMILH.FCPOMANPPNG CJLBFJEOAOD)
	{
		return default(LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x21FACA0", Offset = "0x21FA0A0", VA = "0x1821FACA0", Slot = "38")]
	[AsyncStateMachine(typeof(FDFJBEOFAHP))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> LMECMNEPEHP(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x21FB760", Offset = "0x21FAB60", VA = "0x1821FB760", Slot = "39")]
	public LMFFMMPMNDB<MLAKCGJHLCB, HGFLKMEKLGL> PNGMDEFLKFB(OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE, MLAKCGJHLCB DOMGBCKMIEC, FHHIKJNGAEG AMMPFOHHHBE)
	{
		return default(LMFFMMPMNDB<MLAKCGJHLCB, HGFLKMEKLGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x21FA3D0", Offset = "0x21F97D0", VA = "0x1821FA3D0", Slot = "40")]
	[AsyncStateMachine(typeof(KIMOKHCLMMD))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> KJDNHNPAAFG(OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE, OCPIDHFODDG<LKDNFLJFHHO> NNEDPEJLMJD, MIEEFIOIIBN<BEFCHCFLIDG> GLGBFKIFKKI, MIEEFIOIIBN<PGPOGLDOPDL> JJEIDNNKDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x21F9050", Offset = "0x21F8450", VA = "0x1821F9050", Slot = "41")]
	[AsyncStateMachine(typeof(DLKFKAMFEHG))]
	public Task<LMFFMMPMNDB<IOADHBFKJOJ, FOPCNMINEGF>> HCAMBAAACLK(OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE, OCPIDHFODDG<LKDNFLJFHHO> FEKLEAMJIAF, MIEEFIOIIBN<BEFCHCFLIDG> KBDJLAKHBFN, MIEEFIOIIBN<JJJHNALFLKF> KEAJHDKKBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x21F7EB0", Offset = "0x21F72B0", VA = "0x1821F7EB0", Slot = "42")]
	public OIJNDHILKOM DEMOPGALDKF(IEnumerable<DHPBNJJBAKM> KHPFOMLECLB)
	{
		return default(OIJNDHILKOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x21F91B0", Offset = "0x21F85B0", VA = "0x1821F91B0", Slot = "43")]
	public OIJNDHILKOM HHFEPEOJEAE()
	{
		return default(OIJNDHILKOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x21F7630", Offset = "0x21F6A30", VA = "0x1821F7630")]
	private DHBJKCIEPCP BJFPNNEMAOI(NFMHLDIGCHK CJJFAEPFNLH, MIEEFIOIIBN<ABNDNCLMDPA> FKCNCBNHLBE, IEnumerable<OCPIDHFODDG<ABNDNCLMDPA>> IJJLBLEANKB, IEnumerable<OCPIDHFODDG<LKDNFLJFHHO>> AHEKKHHJIID)
	{
		return default(DHBJKCIEPCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x21F7310", Offset = "0x21F6710", VA = "0x1821F7310", Slot = "44")]
	public DHBJKCIEPCP BJFPNNEMAOI(NFMHLDIGCHK CJJFAEPFNLH, MIEEFIOIIBN<ABNDNCLMDPA> FKCNCBNHLBE, IEnumerable<OCPIDHFODDG<LKDNFLJFHHO>> AHEKKHHJIID, IEnumerable<DHPBNJJBAKM> KHPFOMLECLB)
	{
		return default(DHBJKCIEPCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x21F9ED0", Offset = "0x21F92D0", VA = "0x1821F9ED0")]
	private static IEnumerable<OCPIDHFODDG<ABNDNCLMDPA>> JLFMKALAMKM(IEnumerable<DHPBNJJBAKM> KHPFOMLECLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x21FA5A0", Offset = "0x21F99A0", VA = "0x1821FA5A0")]
	private IEnumerable<OCPIDHFODDG<LKDNFLJFHHO>> KNKCPDICEOD(IEnumerable<DHPBNJJBAKM> KHPFOMLECLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x21F8B40", Offset = "0x21F7F40", VA = "0x1821F8B40", Slot = "45")]
	public List<DADGJPBJGJN> FJKGAPDGNAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x21F9430", Offset = "0x21F8830", VA = "0x1821F9430")]
	public (List<DADGJPBJGJN>, bool) IOJPOLBPFBJ([In] MOAKCLIKKIE DGCEHHJOEAF, string OMHMFLHBNDJ, [In] GKLJAAGFCCM ECIIIJNHAJA, IMABIAJMMMD ACELMIKJHNH, JFOBMJMIOMH KFHGJHFAOCK)
	{
		return default((List<DADGJPBJGJN>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x21F9340", Offset = "0x21F8740", VA = "0x1821F9340", Slot = "47")]
	public bool IIEKBLAHLOE(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x21FB700", Offset = "0x21FAB00", VA = "0x1821FB700")]
	internal void PIJCBFHEOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x21F85D0", Offset = "0x21F79D0", VA = "0x1821F85D0")]
	internal Task EIKNCDOKPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x21F7C40", Offset = "0x21F7040", VA = "0x1821F7C40", Slot = "7")]
	private bool BPKFFPDGACN(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] CAEMFDLOEGM BLNJILGIDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x21F6F40", Offset = "0x21F6340", VA = "0x1821F6F40", Slot = "15")]
	private MJPDFIFLFHA EJEFCIJNBFJ([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x21FAA40", Offset = "0x21F9E40", VA = "0x1821FAA40", Slot = "16")]
	private MIEEFIOIIBN<ABNDNCLMDPA> LCHNDDGNKOM([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(MIEEFIOIIBN<ABNDNCLMDPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x21F7290", Offset = "0x21F6690", VA = "0x1821F7290", Slot = "17")]
	private MIEEFIOIIBN<ABNDNCLMDPA>? FBJFPGFMLNH([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x21F86C0", Offset = "0x21F7AC0", VA = "0x1821F86C0", Slot = "18")]
	private FCOBIPBEMPJ FAFHBIPHAJA([In] OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x21F8410", Offset = "0x21F7810", VA = "0x1821F8410", Slot = "19")]
	private MIEEFIOIIBN<LKDNFLJFHHO> LCMPHNGHOGD(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] OCPIDHFODDG<LKDNFLJFHHO> MLBFNNCEODL)
	{
		return default(MIEEFIOIIBN<LKDNFLJFHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x21FB490", Offset = "0x21FA890", VA = "0x1821FB490", Slot = "24")]
	private IEnumerable<FCOBIPBEMPJ> MOLJLICFNHE([In] OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x21F7D00", Offset = "0x21F7100", VA = "0x1821F7D00", Slot = "31")]
	private KLPCAFMGILJ CKKBPOLJONG(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] CAEMFDLOEGM BLNJILGIDKA)
	{
		return default(KLPCAFMGILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x21F7C50", Offset = "0x21F7050", VA = "0x1821F7C50", Slot = "37")]
	private LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK> FBBIPMKAAGM([In] NNEPGCMMILH.FCPOMANPPNG CJLBFJEOAOD)
	{
		return default(LMFFMMPMNDB<NNEPGCMMILH.LDJHJEGMDIH, BAPAKJBJLEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x21FA250", Offset = "0x21F9650", VA = "0x1821FA250", Slot = "46")]
	private (List<DADGJPBJGJN>, bool) JNFFDEIDKBJ([In] MOAKCLIKKIE DGCEHHJOEAF, string OMHMFLHBNDJ, [In] GKLJAAGFCCM ECIIIJNHAJA, IMABIAJMMMD ACELMIKJHNH, JFOBMJMIOMH KFHGJHFAOCK)
	{
		return default((List<DADGJPBJGJN>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x21F9BB0", Offset = "0x21F8FB0", VA = "0x1821F9BB0")]
	[CompilerGenerated]
	private FCOBIPBEMPJ JGOHHLAMAMK(JFHPLKLODPO PGOOPNPHNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x21F7930", Offset = "0x21F6D30", VA = "0x1821F7930")]
	[CompilerGenerated]
	private HPIOPMADBJN BKJDIOIGLBA(FJIDBMMCBDN PGOOPNPHNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x21FAC30", Offset = "0x21FA030", VA = "0x1821FAC30")]
	[CompilerGenerated]
	private JFHPLKLODPO LEKHMHLACLM(OCPIDHFODDG<LKDNFLJFHHO> PGOOPNPHNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x21F92D0", Offset = "0x21F86D0", VA = "0x1821F92D0")]
	[CompilerGenerated]
	private HPGACFOCINO HNBMHDKJBIA(OCPIDHFODDG<ABNDNCLMDPA> PGOOPNPHNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class HPIOPMADBJN : JJPPEDIIBFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct EACALCJDABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<MIEEFIOIIBN<AJJFJLHFCKF>, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HPIOPMADBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public OCPIDHFODDG<ABNDNCLMDPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public OCPIDHFODDG<LKDNFLJFHHO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<AJJFJLHFCKF>, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x220F630", Offset = "0x220EA30", VA = "0x18220F630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x220F8B0", Offset = "0x220ECB0", VA = "0x18220F8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct HBNKKDGAIOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<MIEEFIOIIBN<OMLEDJJIGFA>, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HPIOPMADBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public OCPIDHFODDG<ABNDNCLMDPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public OCPIDHFODDG<LKDNFLJFHHO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MIEEFIOIIBN<BEFCHCFLIDG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<LMFFMMPMNDB<MIEEFIOIIBN<OMLEDJJIGFA>, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x220FD30", Offset = "0x220F130", VA = "0x18220FD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x220FFB0", Offset = "0x220F3B0", VA = "0x18220FFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly FJIDBMMCBDN KMEOLJLMENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly LFMNDGPEAHI CPKEKNCLHDD;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey DIDJDEODNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string PEKHGICPBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2210760", Offset = "0x220FB60", VA = "0x182210760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public FJIDBMMCBDN NNDPLOLJAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2210900", Offset = "0x220FD00", VA = "0x182210900")]
	public HPIOPMADBJN(FJIDBMMCBDN EEKGNLEDDHL, LFMNDGPEAHI LFAPDIELPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x22105F0", Offset = "0x220F9F0", VA = "0x1822105F0", Slot = "6")]
	[AsyncStateMachine(typeof(EACALCJDABB))]
	public Task<LMFFMMPMNDB<MIEEFIOIIBN<AJJFJLHFCKF>, FOPCNMINEGF>> DDMKIGDBLAC(OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE, OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, string DDDHPCNFCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2210790", Offset = "0x220FB90", VA = "0x182210790", Slot = "7")]
	[AsyncStateMachine(typeof(HBNKKDGAIOL))]
	public Task<LMFFMMPMNDB<MIEEFIOIIBN<OMLEDJJIGFA>, FOPCNMINEGF>> NJAADEBMENB(OCPIDHFODDG<ABNDNCLMDPA> HANIKMKPJIE, OCPIDHFODDG<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM, string DDDHPCNFCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LJAJOMHKJGB : PNFIDHACBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly FJIDBMMCBDN BAIKAGNNDHE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<FJIDBMMCBDN> AKCHHNANJEC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<FJIDBMMCBDN> GENGDJGGNCB;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<FJIDBMMCBDN> NMGADANKGKA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey KJHFJLCNKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2211FC0", Offset = "0x22113C0", VA = "0x182211FC0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KMAEPMFICPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2211FB0", Offset = "0x22113B0", VA = "0x182211FB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool GFHKALDKCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2212010", Offset = "0x2211410", VA = "0x182212010", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool KCJOMDJOLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2211F30", Offset = "0x2211330", VA = "0x182211F30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2210B90", Offset = "0x220FF90", VA = "0x182210B90")]
	public bool KJAMFPDPJEA(string EEPLCHCGAIN, [Out] MCNINKMGLLA CLKBOFOFCEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public LJAJOMHKJGB(FJIDBMMCBDN JPNNGBEFPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2210A00", Offset = "0x220FE00", VA = "0x182210A00")]
	internal static TypeKey EOEMENCHCNB(FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2210760", Offset = "0x220FB60", VA = "0x182210760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct EHIIDPOPKKN : NIKOONMOAJF.ICNHBGLMIHJ<IIIMLHFAMEO, IOADHBFKJOJ>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x220FC90", Offset = "0x220F090", VA = "0x18220FC90", Slot = "4")]
	public int NEOMMKEBKEC(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x220FC20", Offset = "0x220F020", VA = "0x18220FC20", Slot = "5")]
	public IIIMLHFAMEO JGOOEELCIFP(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x220FBF0", Offset = "0x220EFF0", VA = "0x18220FBF0", Slot = "6")]
	public IIIMLHFAMEO IGLCKKGFCED(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x220FC30", Offset = "0x220F030", VA = "0x18220FC30", Slot = "7")]
	public IReadOnlyList<IIIMLHFAMEO> LDBIJEMNHHL(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x220FBC0", Offset = "0x220EFC0", VA = "0x18220FBC0", Slot = "8")]
	public IIIMLHFAMEO[] ECONEAMDMKC(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM, int DHFMLFCFGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x220FC70", Offset = "0x220F070", VA = "0x18220FC70", Slot = "9")]
	public bool NEDMOBGJPLL(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x220FB80", Offset = "0x220EF80", VA = "0x18220FB80", Slot = "10")]
	public bool CILFHPFLMDF(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x220FBD0", Offset = "0x220EFD0", VA = "0x18220FBD0", Slot = "11")]
	public bool HCIALIIDAEI(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x220FBA0", Offset = "0x220EFA0", VA = "0x18220FBA0", Slot = "12")]
	public bool DPEOMGLALMG(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x220FC50", Offset = "0x220F050", VA = "0x18220FC50", Slot = "13")]
	public bool MIFPKEDGIFN(IOADHBFKJOJ FPEPFKAIIIG, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x220FCB0", Offset = "0x220F0B0", VA = "0x18220FCB0", Slot = "14")]
	public bool PHFOJINJPPA(IOADHBFKJOJ EFCBJHHANBC, IIIMLHFAMEO HJOAJFDFEDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class OBMBBKCGHPA : IBPEIDILKAG
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public PNMGAFPDHCL.NCAGMIPMNHM BNFHEFLAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2212B50", Offset = "0x2211F50", VA = "0x182212B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract IMIOGAHJMGH.PCLAPFKMNLL HPEACPCJJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract MMCIBAEBBCI.JGJAFJKJECG BFELPJCOHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract JMJNIILKGBC.BIKCOHPFLDG NMPOCDKFMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, MMCIBAEBBCI> HAFDJDFINIG
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2212BA0", Offset = "0x2211FA0", VA = "0x182212BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract GCOEHOKBBPN DFMPJGOHJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract LAFLPBPFMJP DJENMAOHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract LJEJDJNPLGJ NAFKOIKKPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract DFDNEOKMBMJ ABPLMAIGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract DOHHLPMJDLP GPBMNKGKDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected OBMBBKCGHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class EEFGBCAMHPA : DPLNMIAMPMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct OBNBHPOHMIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public EEFGBCAMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public IIIMLHFAMEO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2212BF0", Offset = "0x2211FF0", VA = "0x182212BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2212E90", Offset = "0x2212290", VA = "0x182212E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct HHGGLNHEENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public EEFGBCAMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<IIIMLHFAMEO> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2210020", Offset = "0x220F420", VA = "0x182210020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x22103A0", Offset = "0x220F7A0", VA = "0x1822103A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly IEOBNKPDNKH AMPKEHMJPIO;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public EEFGBCAMHPA(IEOBNKPDNKH MACGMKINBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x220F920", Offset = "0x220ED20", VA = "0x18220F920")]
	[AsyncStateMachine(typeof(OBNBHPOHMIA))]
	private Task<LMFFMMPMNDB<object, FOPCNMINEGF>> HCEICHAIFFA(IIIMLHFAMEO HJOAJFDFEDM, bool BFNNDCCPMOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x220FA50", Offset = "0x220EE50", VA = "0x18220FA50", Slot = "4")]
	[AsyncStateMachine(typeof(HHGGLNHEENM))]
	public Task<LMFFMMPMNDB<IKKAJHAKAEB, FOPCNMINEGF>> NHPBIHDEGPE(IReadOnlyList<IIIMLHFAMEO> DKIHKOGIAFP, bool BFNNDCCPMOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct EPKDKGFLEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal CBAIEIGKPCP<LJODAPINPGD, IIIMLHFAMEO, HNAGBEMNFJM> BAIKAGNNDHE;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
	private EPKDKGFLEMI([In] CBAIEIGKPCP<LJODAPINPGD, IIIMLHFAMEO, HNAGBEMNFJM> NFIPIKFMKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x220FCD0", Offset = "0x220F0D0", VA = "0x18220FCD0")]
	public static EPKDKGFLEMI AHLALEPNKFA()
	{
		return default(EPKDKGFLEMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class GIHHOIDAHPK
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static CBAIEIGKPCP<LJODAPINPGD, IIIMLHFAMEO, HNAGBEMNFJM> KIDEOJHCBAM(this EPKDKGFLEMI MCPMOAEEEOJ)
	{
		return default(CBAIEIGKPCP<LJODAPINPGD, IIIMLHFAMEO, HNAGBEMNFJM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct HNAGBEMNFJM : GPBPGJCPKOO.GAIIFKOKBCE<LJODAPINPGD, IIIMLHFAMEO>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2210410", Offset = "0x220F810", VA = "0x182210410", Slot = "5")]
	public IIIMLHFAMEO OHCMCDMKKBP(LJODAPINPGD[] AJHFECKAAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670")]
	public int AGGECPHIGGG([In] LJODAPINPGD HAABFCKEKOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670", Slot = "4")]
	private int ILLOOGOOBPI([In] LJODAPINPGD GNDDBJBMHHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct KBCHGPLOHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal BELAPMCBOKP<IKCMGKIAFBA, IIIMLHFAMEO, BAICIBNEJJF> BAIKAGNNDHE;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
	private KBCHGPLOHFK([In] BELAPMCBOKP<IKCMGKIAFBA, IIIMLHFAMEO, BAICIBNEJJF> FCJFKBKIBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x22109A0", Offset = "0x220FDA0", VA = "0x1822109A0")]
	public static KBCHGPLOHFK AHLALEPNKFA()
	{
		return default(KBCHGPLOHFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class LBHIDMEGKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static BELAPMCBOKP<IKCMGKIAFBA, IIIMLHFAMEO, BAICIBNEJJF> KIDEOJHCBAM(this KBCHGPLOHFK MCPMOAEEEOJ)
	{
		return default(BELAPMCBOKP<IKCMGKIAFBA, IIIMLHFAMEO, BAICIBNEJJF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct BAICIBNEJJF : LEMJDLOICAM.OKLIKLBMCDI<IKCMGKIAFBA, IIIMLHFAMEO>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670")]
	public int ONEIGPCHNNA([In] IKCMGKIAFBA HAABFCKEKOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x220ED90", Offset = "0x220E190", VA = "0x18220ED90", Slot = "5")]
	public IIIMLHFAMEO MKDCOGBPKLN(IKCMGKIAFBA[] BOJJJFHFAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670", Slot = "4")]
	private int GCJCKBKGAIM([In] IKCMGKIAFBA HAABFCKEKOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class DGCMFKLBFPM : CIIOJBGFHGE, BAPAKJBJLEK, FOPCNMINEGF, HGFLKMEKLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly HGFLKMEKLGL? IEFBACFFABM;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public PGDJIPEOLBG GAOCPHLBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(PGDJIPEOLBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8AA0E0", VA = "0x1808AACE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override HGFLKMEKLGL? NHGNJELEAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x220EF70", Offset = "0x220E370", VA = "0x18220EF70", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x220F240", Offset = "0x220E640", VA = "0x18220F240")]
	private DGCMFKLBFPM(PGDJIPEOLBG KEKHLMMPMLO, HGFLKMEKLGL? JABBBDKOFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x220F150", Offset = "0x220E550", VA = "0x18220F150")]
	public static DGCMFKLBFPM AMMBIFAGMJN(HGFLKMEKLGL JABBBDKOFBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x220F1D0", Offset = "0x220E5D0", VA = "0x18220F1D0")]
	public static DGCMFKLBFPM OIJMLPEMDBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x220F0E0", Offset = "0x220E4E0", VA = "0x18220F0E0")]
	public static DGCMFKLBFPM AMAJJLJMJBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class LMGDLGDANHL
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F430", Offset = "0x2F0E830", VA = "0x182F0F430")]
	public static LMFFMMPMNDB<TOk, BAPAKJBJLEK> ICPIFHOHOLL<TOk>([In] this LMFFMMPMNDB<TOk, BAPAKJBJLEK> MCPMOAEEEOJ, HGFLKMEKLGL JABBBDKOFBJ) where TOk : notnull
	{
		return default(LMFFMMPMNDB<TOk, BAPAKJBJLEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F520", Offset = "0x2F0E920", VA = "0x182F0F520")]
	public static LMFFMMPMNDB<TOk?, BAPAKJBJLEK?> LHINGJHMDCO<TOk>([In] this LMFFMMPMNDB<TOk, BAPAKJBJLEK> MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<TOk, BAPAKJBJLEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F330", Offset = "0x2F0E730", VA = "0x182F0F330")]
	public static LMFFMMPMNDB<TOk?, BAPAKJBJLEK?> CLPDELJIFKH<TOk>([In] this LMFFMMPMNDB<TOk, BAPAKJBJLEK> MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<TOk, BAPAKJBJLEK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface GCOEHOKBBPN
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBFAEGGDHOG([In] LMFFMMPMNDB<IOADHBFKJOJ, HGFLKMEKLGL> IPNDOKDOGDG);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class JJHIHNEKECA
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4330", Offset = "0x2EB3730", VA = "0x182EB4330")]
	public static bool CBFAEGGDHOG<TOk, TErr>(this GCOEHOKBBPN MCPMOAEEEOJ, [In] LMFFMMPMNDB<TOk, TErr> IPNDOKDOGDG) where TOk : notnull where TErr : notnull, HGFLKMEKLGL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface LAFLPBPFMJP
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	IBLIAAMELBG FBGBFLCFJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface LJEJDJNPLGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKEEOAFKEJI GLBAJDKANKM(int PGJEJNDNNOM);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface HINIINMCDDP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface JMHBDGMNIDN
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FAALONINIKK? EFIKEMLDGDG(MIEEFIOIIBN<BEFCHCFLIDG> EBFFNEHIIBM);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface ALHBKONKLDD
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface FAALONINIKK
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALHBKONKLDD? LPEPGGCNMKO(MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HINIINMCDDP? ICAFHEGGHKA(MIEEFIOIIBN<OMLEDJJIGFA> PPJKBEPAPJP);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface DFDNEOKMBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JMDFHEPJAJK(string EEPLCHCGAIN, string OMHMFLHBNDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface DOHHLPMJDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMHBDGMNIDN? JLLJGMBEMDN([In] OCPIDHFODDG<KPGIKLGCHFF> HILCHLHCIKH);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class LKHDNPCNLCL
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct NGOHHOEAICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int KMIIBMECGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public EOEFLIMDACN? LPEGKNPLLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public EOEFLIMDACN? FNILAJILGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<IIIMLHFAMEO> LIOHNOJPGAL;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2212B00", Offset = "0x2211F00", VA = "0x182212B00")]
		private NGOHHOEAICL(int HAJICDLBEKC, EOEFLIMDACN? FEIOACBMAAH, EOEFLIMDACN? JCICMPPBJNO, List<IIIMLHFAMEO> DKIHKOGIAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2212A40", Offset = "0x2211E40", VA = "0x182212A40")]
		public static NGOHHOEAICL AHLALEPNKFA()
		{
			return default(NGOHHOEAICL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly PODIGMFMMHK<NGOHHOEAICL> ICDFGDMJNKG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static LKHDNPCNLCL GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2212550", Offset = "0x2211950", VA = "0x182212550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool BBANPPIJKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x946390", Offset = "0x945790", VA = "0x180946390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x9463A0", Offset = "0x9457A0", VA = "0x1809463A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2212490", Offset = "0x2211890", VA = "0x182212490")]
	public void FIHDHDDLPEE(HDKNAPMCODO JCICMPPBJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x22125A0", Offset = "0x22119A0", VA = "0x1822125A0")]
	public void ICKHKNFMLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2212130", Offset = "0x2211530", VA = "0x182212130")]
	private static string? CAMOBEOPBGM([In] NGOHHOEAICL GCMFEKCIALA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2212990", Offset = "0x2211D90", VA = "0x182212990")]
	public LKHDNPCNLCL()
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
