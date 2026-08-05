using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KGOMKFALPJE<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HLKKOMNPOMJ(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CLBIEFGOADD(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction CGOCNEIMHBL(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> KCCJMJFCDOK(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGHKIBOIBFC(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ACPABOBLEOK(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HDGJANAICGE(in TAction EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AJCICNBGBMM(in TAction EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PCLKFEDNNNJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::FDLJHLNGNLE<CBKCPGEGMJO> KDOOJAEFKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJEBECFNDLA();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEMOPEHCHEE(in global::FDLJHLNGNLE<MJGJKBCEANK> CCOPGLCNAKD, in TAction EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CBKCPGEGMJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MJGJKBCEANK
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CJJOCHIBDIG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::BEIGJFECBOI<TAction, Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>>, TActionReceiver> where TActionReceiver : global::BPBPICFCOJM<TAction, Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>>> where TActionDeps : global::KGOMKFALPJE<TAction> where TStaticNetSysDeps : global::PCLKFEDNNNJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface DPAPCHONBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ABPIFKDFKBD(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void APOAAAAFMBC();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::DKPHFEGOIMC<object, AGOFKDGONDP> FBBLMDKEEIA();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JELBMBNLKEA(Exception HNABNMBFKFA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class CHBBPHNGOAO : DPAPCHONBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> JJMAPMMHIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::DKPHFEGOIMC<object, AGOFKDGONDP>> IPGJKODBOAP;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB250", Offset = "0x2FD9E50", VA = "0x182FDB250")]
		private CHBBPHNGOAO(TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> LGBGJMIKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB120", Offset = "0x2FD9D20", VA = "0x182FDB120")]
		public static CHBBPHNGOAO GPPOAKIDPIM(TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> LGBGJMIKAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAF60", Offset = "0x2FD9B60", VA = "0x182FDAF60")]
		public void ABPIFKDFKBD(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAFC0", Offset = "0x2FD9BC0", VA = "0x182FDAFC0", Slot = "5")]
		public void APOAAAAFMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB080", Offset = "0x2FD9C80", VA = "0x182FDB080", Slot = "6")]
		public global::DKPHFEGOIMC<object, AGOFKDGONDP> FBBLMDKEEIA()
		{
			return default(global::DKPHFEGOIMC<object, AGOFKDGONDP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB1F0", Offset = "0x2FD9DF0", VA = "0x182FDB1F0", Slot = "7")]
		public void JELBMBNLKEA(Exception HNABNMBFKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAF30", Offset = "0x2FD9B30", VA = "0x182FDAF30", Slot = "4")]
		private void PAHFBJDPBLE(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class GPOFLIPLGGJ : DPAPCHONBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> JJMAPMMHIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::DKPHFEGOIMC<object, AGOFKDGONDP> ECANLNODDPF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
		private GPOFLIPLGGJ(TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> LGBGJMIKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB120", Offset = "0x2FD9D20", VA = "0x182FDB120")]
		public static GPOFLIPLGGJ GPPOAKIDPIM(TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>> LGBGJMIKAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7220", Offset = "0x2BD5E20", VA = "0x182BD7220")]
		public void ABPIFKDFKBD(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2D50", Offset = "0x2FE1950", VA = "0x182FE2D50", Slot = "5")]
		public void APOAAAAFMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x55D000", Offset = "0x55BC00", VA = "0x18055D000", Slot = "6")]
		public global::DKPHFEGOIMC<object, AGOFKDGONDP> FBBLMDKEEIA()
		{
			return default(global::DKPHFEGOIMC<object, AGOFKDGONDP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2DB0", Offset = "0x2FE19B0", VA = "0x182FE2DB0", Slot = "7")]
		public void JELBMBNLKEA(Exception HNABNMBFKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAF30", Offset = "0x2FD9B30", VA = "0x182FDAF30", Slot = "4")]
		private void PAHFBJDPBLE(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class IICCAKFOAJP : DPAPCHONBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::DKPHFEGOIMC<object, AGOFKDGONDP>> IPGJKODBOAP;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2ED0", Offset = "0x2FE1AD0", VA = "0x182FE2ED0")]
		private IICCAKFOAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAE70", Offset = "0x2FD9A70", VA = "0x182FDAE70")]
		public static IICCAKFOAJP GPPOAKIDPIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2E10", Offset = "0x2FE1A10", VA = "0x182FE2E10")]
		public void ABPIFKDFKBD(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		public void APOAAAAFMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2E70", Offset = "0x2FE1A70", VA = "0x182FE2E70", Slot = "6")]
		public global::DKPHFEGOIMC<object, AGOFKDGONDP> FBBLMDKEEIA()
		{
			return default(global::DKPHFEGOIMC<object, AGOFKDGONDP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
		public void JELBMBNLKEA(Exception HNABNMBFKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAF30", Offset = "0x2FD9B30", VA = "0x182FDAF30", Slot = "4")]
		private void PAHFBJDPBLE(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CAJEBGKNGKB : DPAPCHONBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::DKPHFEGOIMC<object, AGOFKDGONDP> ECANLNODDPF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		private CAJEBGKNGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAE70", Offset = "0x2FD9A70", VA = "0x182FDAE70")]
		public static CAJEBGKNGKB GPPOAKIDPIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xD2AD40", Offset = "0xD29940", VA = "0x180D2AD40")]
		public void ABPIFKDFKBD(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		public void APOAAAAFMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E90", Offset = "0x7F3A90", VA = "0x1807F4E90", Slot = "6")]
		public global::DKPHFEGOIMC<object, AGOFKDGONDP> FBBLMDKEEIA()
		{
			return default(global::DKPHFEGOIMC<object, AGOFKDGONDP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
		public void JELBMBNLKEA(Exception HNABNMBFKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2FDAF30", Offset = "0x2FD9B30", VA = "0x182FDAF30", Slot = "4")]
		private void PAHFBJDPBLE(in global::DKPHFEGOIMC<object, AGOFKDGONDP> FNMKBJFEJIH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LPICCKMAKLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::DKPHFEGOIMC<object, AGOFKDGONDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::CJJOCHIBDIG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::FDLJHLNGNLE<CBKCPGEGMJO> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::FDLJHLNGNLE<MJGJKBCEANK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::DKPHFEGOIMC<object, AGOFKDGONDP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3910", Offset = "0x2FE2510", VA = "0x182FE3910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3B40", Offset = "0x2FE2740", VA = "0x182FE3B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NELFKNPGNPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::DKPHFEGOIMC<object, AGOFKDGONDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::CJJOCHIBDIG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::FDLJHLNGNLE<CBKCPGEGMJO> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::FDLJHLNGNLE<MJGJKBCEANK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DPAPCHONBNB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2FE69D0", Offset = "0x2FE55D0", VA = "0x182FE69D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7160", Offset = "0x2FE5D60", VA = "0x182FE7160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KCLLMPFKLOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::CJJOCHIBDIG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DPAPCHONBNB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DPAPCHONBNB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::DKPHFEGOIMC<object, AGOFKDGONDP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2F70", Offset = "0x2FE1B70", VA = "0x182FE2F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6CEFA0", Offset = "0x6CDBA0", VA = "0x1806CEFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver EPCMGBPFEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps IJCEBPEEFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps JHKKIKGGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int BKDKKAPKLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ICBJDIHFAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::FDLJHLNGNLE<MJGJKBCEANK>, TaskCompletionSource<global::DKPHFEGOIMC<object, AGOFKDGONDP>>> NCPGOFJMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::FFOMLDCHJKM<MJGJKBCEANK> MAIMNLAMDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool APBGAHEAMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MAIBPCEPLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task JLNEMPLPKJL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC6E0", Offset = "0x2FDB2E0", VA = "0x182FDC6E0")]
	protected CJJOCHIBDIG(TActionDeps DKOFHHIFODO, TStaticNetSysDeps PPJPHGLCJKH, int FNJKEEJHFEI, int EFJMFLEMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBD30", Offset = "0x2FDA930", VA = "0x182FDBD30")]
	public static global::CJJOCHIBDIG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GPPOAKIDPIM(TActionDeps DKOFHHIFODO, TStaticNetSysDeps PPJPHGLCJKH, [Optional] int? FNJKEEJHFEI, [Optional] int? EFJMFLEMFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC3E0", Offset = "0x2FDAFE0", VA = "0x182FDC3E0")]
	public Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>> PEMOPEHCHEE(in TAction EMKOBNDJJHF, bool HCJGIHIEOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC280", Offset = "0x2FDAE80", VA = "0x182FDC280")]
	public void MKDHIPDGDML(in TActionReceiver HGBOPHFBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC290", Offset = "0x2FDAE90", VA = "0x182FDC290")]
	[AsyncStateMachine(typeof(global::CJJOCHIBDIG<, , , >.LPICCKMAKLP))]
	public Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>> PBFMLLPKJMJ(global::FDLJHLNGNLE<CBKCPGEGMJO> DEGGBBOKGLD, global::FDLJHLNGNLE<MJGJKBCEANK> CCOPGLCNAKD, TAction EMKOBNDJJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBFE0", Offset = "0x2FDABE0", VA = "0x182FDBFE0")]
	[AsyncStateMachine(typeof(global::CJJOCHIBDIG<, , , >.NELFKNPGNPF))]
	private Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>> JPLIPNPHJGM(global::FDLJHLNGNLE<CBKCPGEGMJO> DEGGBBOKGLD, global::FDLJHLNGNLE<MJGJKBCEANK> CCOPGLCNAKD, TAction EMKOBNDJJHF, Task GEEDIHCCDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC130", Offset = "0x2FDAD30", VA = "0x182FDC130")]
	[AsyncStateMachine(typeof(global::CJJOCHIBDIG<, , , >.KCLLMPFKLOF))]
	private Task KJIANDDCLCM(TAction EMKOBNDJJHF, DPAPCHONBNB NENHAILALCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBE60", Offset = "0x2FDAA60", VA = "0x182FDBE60")]
	private void HAFNBKBGPPM(TAction EMKOBNDJJHF, bool GIPLNCHIMNE, bool GEANEDKJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x226E2C0", Offset = "0x226CEC0", VA = "0x18226E2C0", Slot = "4")]
	private Task<global::DKPHFEGOIMC<object, AGOFKDGONDP>> OHHBIFODNDN(in TAction EMKOBNDJJHF, bool HCJGIHIEOKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KKKCLIDAEPL : AGOFKDGONDP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E42070", Offset = "0x4E40C70", VA = "0x184E42070", Slot = "4")]
	public override string KOMJIHDGAFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21A1B70", Offset = "0x21A0770", VA = "0x1821A1B70")]
	private KKKCLIDAEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20FC530", Offset = "0x20FB130", VA = "0x1820FC530")]
	public static global::DKPHFEGOIMC<TOk, AGOFKDGONDP> GPPOAKIDPIM<TOk>()
	{
		return default(global::DKPHFEGOIMC<TOk, AGOFKDGONDP>);
	}
}
namespace Cpp2IlInjected;

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
