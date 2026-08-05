using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Mono.Math;
using RecNet;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EPHOAEKKDFG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2662160", Offset = "0x2661160", VA = "0x182662160")]
	public EPHOAEKKDFG(string NJAIIGFCHNG, Exception COLLJDCIAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class CGJJFDDPJCI : NPIBONODDMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KLPCJHDJCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PFCNFBNAIAG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private TaskAwaiter<global::ADAFMCLNIGB<PFCNFBNAIAG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B210", Offset = "0x2C9A210", VA = "0x182C9B210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B3F0", Offset = "0x2C9A3F0", VA = "0x182C9B3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct MKFAPHCCNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LFKLBJHOBKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<LFKLBJHOBKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EF60", Offset = "0x2C9DF60", VA = "0x182C9EF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F120", Offset = "0x2C9E120", VA = "0x182C9F120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	[Preserve]
	public CGJJFDDPJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x265E350", Offset = "0x265D350", VA = "0x18265E350", Slot = "4")]
	[AsyncStateMachine(typeof(KLPCJHDJCFD))]
	public Task<IReadOnlyList<PFCNFBNAIAG>> AMALDDNPJDC(long BDNAKAPNAFM, long BGHODONOFKO, [Optional] CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x265E4A0", Offset = "0x265D4A0", VA = "0x18265E4A0", Slot = "5")]
	[AsyncStateMachine(typeof(MKFAPHCCNKO))]
	public Task<IReadOnlyList<LFKLBJHOBKP>> HHFAJGJFFHM(IReadOnlyList<int> MCGJLGFEBPD, [Optional] CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MFKMCKLFGBI : IEquatable<MFKMCKLFGBI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JNGPCOPLNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LFKLBJHOBKP NOGEIILBAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BBMEPHHFBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CNOCFDPMLGM? IAEDMFJCAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EDNIKPNLKDH? BINEIOEJAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	INOBPHJEDCA CCDHKHLHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ODHGHEGHGCB> MMNEMIHGGMG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum INOBPHJEDCA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NPIBONODDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<PFCNFBNAIAG>> AMALDDNPJDC(long BDNAKAPNAFM, long BGHODONOFKO, [Optional] CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LFKLBJHOBKP>> HHFAJGJFFHM(IReadOnlyList<int> MCGJLGFEBPD, [Optional] CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DLAIKIMFEPF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class GNAMFNOEHJP : MFKMCKLFGBI, IEquatable<MFKMCKLFGBI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct OIEJOBFCNNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GNAMFNOEHJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private EMEJKEABALH <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<DIJEGIOFGFI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<ODHGHEGHGCB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x42B56A0", Offset = "0x42B46A0", VA = "0x1842B56A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x42B5A70", Offset = "0x42B4A70", VA = "0x1842B5A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PFCNFBNAIAG NJHICDHOEDH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JNGPCOPLNDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LFKLBJHOBKP NOGEIILBAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LKFNHKOGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1165A90", Offset = "0x1164A90", VA = "0x181165A90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CNOCFDPMLGM? IAEDMFJCAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CF120", Offset = "0x8CE120", VA = "0x1808CF120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EDNIKPNLKDH? BINEIOEJAIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0E0", Offset = "0x8CE0E0", VA = "0x1808CF0E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public INOBPHJEDCA CCDHKHLHJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0", Slot = "10")]
			get
			{
				return default(INOBPHJEDCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2C970F0", Offset = "0x2C960F0", VA = "0x182C970F0", Slot = "9")]
		[AsyncStateMachine(typeof(OIEJOBFCNNP))]
		public Task<ODHGHEGHGCB> MMNEMIHGGMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2C97220", Offset = "0x2C96220", VA = "0x182C97220")]
		public GNAMFNOEHJP(int GMJPAJENEMC, LFKLBJHOBKP JCOLPNDJPKH, PFCNFBNAIAG NJHICDHOEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2C96FD0", Offset = "0x2C95FD0", VA = "0x182C96FD0", Slot = "11")]
		public bool Equals(MFKMCKLFGBI IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2C97020", Offset = "0x2C96020", VA = "0x182C97020")]
		private bool FMLLLJFHODI(GNAMFNOEHJP IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2C96F30", Offset = "0x2C95F30", VA = "0x182C96F30", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C97060", Offset = "0x2C96060", VA = "0x182C97060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IIDCGLAACNG : MFKMCKLFGBI, IEquatable<MFKMCKLFGBI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct OBNCADBCKLO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IIDCGLAACNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<ODHGHEGHGCB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x42B4790", Offset = "0x42B3790", VA = "0x1842B4790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x42B4970", Offset = "0x42B3970", VA = "0x1842B4970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly EHINBDMEHCH GIMCIAMMMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly CNOCFDPMLGM JNJCCGOECNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly EDNIKPNLKDH IMGIMKGDOOK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int JNGPCOPLNDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2C988E0", Offset = "0x2C978E0", VA = "0x182C988E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LFKLBJHOBKP NOGEIILBAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2C98A90", Offset = "0x2C97A90", VA = "0x182C98A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LKFNHKOGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2C98890", Offset = "0x2C97890", VA = "0x182C98890", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CNOCFDPMLGM? IAEDMFJCAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2C98D30", Offset = "0x2C97D30", VA = "0x182C98D30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EDNIKPNLKDH? BINEIOEJAIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2C98BC0", Offset = "0x2C97BC0", VA = "0x182C98BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public INOBPHJEDCA CCDHKHLHJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6652A0", Offset = "0x6642A0", VA = "0x1806652A0", Slot = "10")]
			get
			{
				return default(INOBPHJEDCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD10", Offset = "0x6EED10", VA = "0x1806EFD10")]
		public IIDCGLAACNG(EHINBDMEHCH LLHGAGNPGHM, CNOCFDPMLGM BLEBGFAAHGJ, EDNIKPNLKDH MHEMEOIBDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C98C10", Offset = "0x2C97C10", VA = "0x182C98C10", Slot = "9")]
		[AsyncStateMachine(typeof(OBNCADBCKLO))]
		public Task<ODHGHEGHGCB> MMNEMIHGGMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2C98930", Offset = "0x2C97930", VA = "0x182C98930", Slot = "11")]
		public bool Equals(MFKMCKLFGBI IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C98A30", Offset = "0x2C97A30", VA = "0x182C98A30")]
		private bool FMLLLJFHODI(IIDCGLAACNG IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2C98980", Offset = "0x2C97980", VA = "0x182C98980", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2C98B30", Offset = "0x2C97B30", VA = "0x182C98B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MAAMIDGJIKN : MFKMCKLFGBI, IEquatable<MFKMCKLFGBI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct BJLFELALDID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<ODHGHEGHGCB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x42ABCB0", Offset = "0x42AACB0", VA = "0x1842ABCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x42ABE70", Offset = "0x42AAE70", VA = "0x1842ABE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly LFKLBJHOBKP MLKNNAMMCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly CNOCFDPMLGM JNJCCGOECNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly EDNIKPNLKDH IMGIMKGDOOK;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int JNGPCOPLNDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2C9D990", Offset = "0x2C9C990", VA = "0x182C9D990", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LFKLBJHOBKP NOGEIILBAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LKFNHKOGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x651170", Offset = "0x650170", VA = "0x180651170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CNOCFDPMLGM? IAEDMFJCAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2C9DEA0", Offset = "0x2C9CEA0", VA = "0x182C9DEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EDNIKPNLKDH? BINEIOEJAIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2C9DD60", Offset = "0x2C9CD60", VA = "0x182C9DD60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public INOBPHJEDCA CCDHKHLHJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x651170", Offset = "0x650170", VA = "0x180651170", Slot = "10")]
			get
			{
				return default(INOBPHJEDCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD10", Offset = "0x6EED10", VA = "0x1806EFD10")]
		public MAAMIDGJIKN(LFKLBJHOBKP JCOLPNDJPKH, CNOCFDPMLGM BLEBGFAAHGJ, EDNIKPNLKDH MHEMEOIBDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DDB0", Offset = "0x2C9CDB0", VA = "0x182C9DDB0", Slot = "9")]
		[AsyncStateMachine(typeof(BJLFELALDID))]
		public Task<ODHGHEGHGCB> MMNEMIHGGMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DA10", Offset = "0x2C9CA10", VA = "0x182C9DA10", Slot = "11")]
		public bool Equals(MFKMCKLFGBI IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DBB0", Offset = "0x2C9CBB0", VA = "0x182C9DBB0")]
		private bool FMLLLJFHODI(MAAMIDGJIKN IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DA60", Offset = "0x2C9CA60", VA = "0x182C9DA60", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DCB0", Offset = "0x2C9CCB0", VA = "0x182C9DCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private static class CNJNHIDKMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3082CE0", Offset = "0x3081CE0", VA = "0x183082CE0")]
		public static bool GEIELLFIIAF<TConcrete>([NotNull] TConcrete PLIGCNJMAAG, MFKMCKLFGBI IPGOFHIJDJO) where TConcrete : MFKMCKLFGBI
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct APFHOLGHKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<MFKMCKLFGBI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DLAIKIMFEPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<PFCNFBNAIAG> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<PFCNFBNAIAG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LFKLBJHOBKP account, PFCNFBNAIAG roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2C90600", Offset = "0x2C8F600", VA = "0x182C90600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2C91090", Offset = "0x2C90090", VA = "0x182C91090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DKCPFOCNMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LFKLBJHOBKP account, PFCNFBNAIAG roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<PFCNFBNAIAG> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DLAIKIMFEPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<LFKLBJHOBKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2C94F90", Offset = "0x2C93F90", VA = "0x182C94F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2C95910", Offset = "0x2C94910", VA = "0x182C95910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MNEAPLJEHCA GHAAJFPDBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NPIBONODDMO BDECBNBECEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KMKFLCJMGIB OOLJDKKJMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::OKKLELBPLKM<(long, long), IReadOnlyList<PFCNFBNAIAG>> FABLLDAEHBJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2660830", Offset = "0x265F830", VA = "0x182660830")]
	[Preserve]
	public DLAIKIMFEPF([NBLPGINBDGI(null)] NPIBONODDMO FDFJNHIKACJ, [NBLPGINBDGI(null)] KMKFLCJMGIB PKLKENLDHEG, [NBLPGINBDGI(null)] MNEAPLJEHCA LLJAOEGIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26606E0", Offset = "0x265F6E0", VA = "0x1826606E0")]
	[AsyncStateMachine(typeof(APFHOLGHKJO))]
	public Task<IList<MFKMCKLFGBI>> PHCBGLMCLDF(long BDNAKAPNAFM, long HKIDJEFCIOJ, bool NALPCKBGCJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26603F0", Offset = "0x265F3F0", VA = "0x1826603F0")]
	private bool ECBCOJOBIJE(DateTime? IJEIGHDPKMK, long BDNAKAPNAFM, long HKIDJEFCIOJ, out EHINBDMEHCH JHJBCECDIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26605A0", Offset = "0x265F5A0", VA = "0x1826605A0")]
	[AsyncStateMachine(typeof(DKCPFOCNMPD))]
	private Task<IReadOnlyList<(int, LFKLBJHOBKP, PFCNFBNAIAG)>> OLOJEBIFOJB(IReadOnlyList<PFCNFBNAIAG> FLMDCNMMHMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KMKFLCJMGIB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EHINBDMEHCH> HIAGGGHFEBD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHHHAKDHOHE(long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH, PEAHMKADPMI KMCOHECJCLH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BNCBLPGNDMA(long BDNAKAPNAFM, long HKIDJEFCIOJ, out EHINBDMEHCH JHJBCECDIKD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNLIDPEHFAN(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, out EHINBDMEHCH JHJBCECDIKD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJKOALIJNKM(long BDNAKAPNAFM, long HKIDJEFCIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface FPKFEENENKO : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CHDBEOAKJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task AEIJNNODKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOGBLFNIICL(Task IIDIGDMKMIO, string NAMAKPBBCCC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface BJGELKDEMLP : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ODHGHEGHGCB> GKEJIADLANM(EHINBDMEHCH JHJBCECDIKD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JMNCHFFEGCE(CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface PGIPFOJCNHM : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DEBBKGCKOLK IMPOHOMIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLALKHMJKDG();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOABPDJLFCP();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GGDBKLMDLIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LMPCEFKGPKI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan HJFOHGKOAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan PHMHJDPCDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan OFDFNFOHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan GPOBNGGPAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IBGEKCMLAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HAOFHAEGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DIOKONAGPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ALBCFIAKALA
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EFBIDOEEHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly long KOPNDIHPOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly long BGHODONOFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly ALBCFIAKALA BCFKLEGAMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[CanBeNull]
	public readonly Exception ABGKPOMOIOA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2661090", Offset = "0x2660090", VA = "0x182661090")]
	public EFBIDOEEHFO(long KOPNDIHPOPK, long BGHODONOFKO, ALBCFIAKALA BCFKLEGAMEO, [CanBeNull] Exception ABGKPOMOIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2661040", Offset = "0x2660040", VA = "0x182661040")]
	public static EFBIDOEEHFO EKGOOABIHMK(APDOMGKMKFG NOLIDDABIAK, ALBCFIAKALA BCFKLEGAMEO, [Optional] Exception ABGKPOMOIOA)
	{
		return default(EFBIDOEEHFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void MMCPIPNNMGN(EFBIDOEEHFO NCOJPJKLCNI);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PDGLPNCNIGB : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GLMFLMDDEKG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MMCPIPNNMGN ANICELDEEAA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MMCPIPNNMGN OMMOGEAHOHO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MMCPIPNNMGN HEKAEADBDDE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KCKIOKEJJPK();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIAJBGMLGPO(EFBIDOEEHFO NCOJPJKLCNI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BDJPHGDLIIF(EFBIDOEEHFO NCOJPJKLCNI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FBNPAOEAMAO(EFBIDOEEHFO NCOJPJKLCNI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface ANGLDKLCNIL : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HIKKLLHPIAM();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHOINIABJCB();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHCPGDEAOOD();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task HFDLPGEBHAE(CEBPIIBHMDD DPFMLJHHCKP, CancellationToken FDKCIGPLPAB);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface DMJOFNEHOAE : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FGCCLAIAEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AAFNHIAGLEF(HFDLPGEBHAE PBJHOONDPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface AAJPBPBNKKA : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus JKODBMNCGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IOILNCAGFGJ(APDOMGKMKFG CILBKNNEHGI, CancellationToken PJNOBOOMKAP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class GHHOHBKEGCN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26683A0", Offset = "0x26673A0", VA = "0x1826683A0")]
	public static bool DLLECLJBFIF(this AAJPBPBNKKA NNDEMEJOBHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CDJBHBCLHCD : EMEJKEABALH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken IMBMCOPHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	PCJIKNDFKDJ MOLDMOAGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	LHBHABEPLIM BMACDOJDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NPJEBNJGELF PFBLNBBNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NGGIJKCGJLP HEDDBOKEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AJIMEGCKBBC PFJLKJIPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KFMPBCNDGGB CJGLJFKDAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NPPGBANJAMC MOOOGAKEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FPKFEENENKO ECHIIKDGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BJGELKDEMLP JMMFOAJMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PDGLPNCNIGB CHBGDIOAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ANGLDKLCNIL IFKFJEIFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	AAJPBPBNKKA FPFNCEMCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DMJOFNEHOAE PBDDAGFJCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AACEJKINIDC PFIMFMFMNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IKBEIDBGMGK PPDCNBCKHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ANOHCFDFHDC DKJDJKOLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BPBOEKMGJMK BDCLJAFJCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MIONDDMMAKC INBIIBMJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FGOAJCHMBDH MHCFAFOPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EPCKILAPKNE PIFIIFGBKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OJGLOFJPEPP CFOKPHOLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DJDJIIDPFGC BDMNCMLOHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KBLHKAMAGAN BAANPPJDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KKCDDKGBHII EEHDHABDLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PGIPFOJCNHM NKHIOKDMPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	LMPCEFKGPKI KLCLPFPEDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ECPCGLHGMDH KJBFBKJGMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KMKFLCJMGIB BCFDJKIBENP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface AACEJKINIDC : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GONGPCOEAHB CEMPCIEDPMO(Guid IBJDBAKNBNO);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADDEDGCCJIP(Guid IBJDBAKNBNO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBBKIAOAPCD(Guid IBJDBAKNBNO, Task DIJCFDEMACO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMHIKFBGFJN(Guid IBJDBAKNBNO, ODHGHEGHGCB EMBICOPNDOF);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHCPGDEAOOD(Guid IBJDBAKNBNO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(ODHGHEGHGCB, Task)> DPAAKFMPIIE(Guid IBJDBAKNBNO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface IKBEIDBGMGK : GGDBKLMDLIG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface ANOHCFDFHDC : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJBCONLFFAK(JKIDPKPPPFG NJAIIGFCHNG);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDNFKCHNGCG(JKIDPKPPPFG NJAIIGFCHNG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<INKLMCGIFMP> DFKMPGDELJB(CancellationToken PDGIHFLJMIA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate ODHGHEGHGCB HDPBNPAPJLJ(ODNOGOADEAI EKAJODGDHNG, INKLMCGIFMP JMJPFKPCGJM);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BPBOEKMGJMK : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GONGPCOEAHB HGPCANPJDFB(GJONLHCLILK NEKLOBPPHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPLHKNJNIIA(Guid IBJDBAKNBNO, Task DIJCFDEMACO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MIONDDMMAKC : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ODHGHEGHGCB> INBIIBMJHGG(ODNOGOADEAI FFLNBEOJALG, INKLMCGIFMP IFJGKJDPPKE, [Optional] DIJEGIOFGFI PHCKAOHPFKD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FGOAJCHMBDH : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAOKGENDBMG> DOHBEHNMLEG(HKLBBGEFPMO NMGDNGMBHAG, APDOMGKMKFG CILBKNNEHGI, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CAOKGENDBMG HACLHDADHAM(APDOMGKMKFG CILBKNNEHGI, DIJEGIOFGFI FBMEDFJHKDJ, long HKIDJEFCIOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAOKGENDBMG HJCBFBAPGIP(APDOMGKMKFG CILBKNNEHGI, HNOFBHJLOMI GMGAKMOLDCA, long HKIDJEFCIOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAOKGENDBMG GHDKAPIPINN(long KOPNDIHPOPK, long HKIDJEFCIOJ, string BLHPGIMDEGL, string OJLDLNLLPIK);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface OJGLOFJPEPP : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODHGHEGHGCB AJGFBBGFEPB(ODNOGOADEAI EKAJODGDHNG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LDCBOLAEFLO(string OIPMKBNDJIF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface EPCKILAPKNE : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKIDPKPPPFG> PBKFGNLIABC(JKIDPKPPPFG ANHHADJHMBE, OHPHHOAEIIK CDJJOGCLELP, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JKIDPKPPPFG> ICIMKMEKEBO(CancellationToken OHJGLBPIBBN, OHPHHOAEIIK CDJJOGCLELP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNICOEAPHFK OAFIPMNEMGH(FEBBGJAEJGA JKLNOJJNNIK, HKLBBGEFPMO NMGDNGMBHAG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NNICOEAPHFK PMCOJNCPDAF(FEBBGJAEJGA JKLNOJJNNIK, HKLBBGEFPMO NMGDNGMBHAG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DJDJIIDPFGC : GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODHGHEGHGCB DLBIABBDFFD(ODNOGOADEAI EKAJODGDHNG, INKLMCGIFMP JMJPFKPCGJM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODHGHEGHGCB LMBLCDIFCDE(ODNOGOADEAI DAGJCDCAJFO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODHGHEGHGCB IMHHBPFDNKI(ODNOGOADEAI DAGJCDCAJFO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KBLHKAMAGAN
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGBIKPCGLGC(NBGKBJJBNNC CFFHJDPKFLD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPPIBCFFBHF(NBGKBJJBNNC CFFHJDPKFLD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDCCGECCGAN(NBGKBJJBNNC CFFHJDPKFLD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMGOHJGCFCD(NBGKBJJBNNC CFFHJDPKFLD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NBGKBJJBNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly APDOMGKMKFG LGLNEBIPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Dictionary<string, string> HFFNMFKBOGH;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::BJNCMLEHIAG<string> CGDCGKHEHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	public NBGKBJJBNNC(APDOMGKMKFG LOEJLEDCOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FDB0", Offset = "0x2C9EDB0", VA = "0x182C9FDB0")]
	public NBGKBJJBNNC NECKMHLIKIL(string AGPLDPOAAIC, string CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FD30", Offset = "0x2C9ED30", VA = "0x182C9FD30")]
	public bool MDPOHGHFBDE(out IEnumerable<KeyValuePair<string, string>> DIOCJBHEHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x24B4DC0", Offset = "0x24B3DC0", VA = "0x1824B4DC0")]
	public NBGKBJJBNNC GHICGDNPHIE(global::BJNCMLEHIAG<string> MDGABGKAFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface ECPCGLHGMDH
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AJGHLFOLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string GIEFPAFGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMANMINKBNH();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BDLMCAKMBAG AFEEMNGBLEN(long JACMPOFNBDM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BCFJIOEINCO<NLKLCIGNEIJ, DEENGOJEGMM> ALGOJLFCBBG(long JACMPOFNBDM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BCFJIOEINCO<NLKLCIGNEIJ, KHMOACGNIHJ> GCLPNEBOANP(long JACMPOFNBDM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::BCFJIOEINCO<long, AOLFLJPAJKD> JNHGIHCLMDM();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MLEFFEIHOEK(long JACMPOFNBDM, out string OJLDLNLLPIK, out string BLHPGIMDEGL, out NLKLCIGNEIJ CFMAKJKACLA, out NLKLCIGNEIJ ONIDIMKJKKF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IDMNKNIGCDB(CAOKGENDBMG ANHHADJHMBE, long JACMPOFNBDM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> DECEKCHKDMK(long JACMPOFNBDM, byte[] CFMAKJKACLA, byte[] ONIDIMKJKKF, CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EMEJKEABALH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool DLLECLJBFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HNHGKPIFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action GLMFLMDDEKG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MMCPIPNNMGN ANICELDEEAA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MMCPIPNNMGN OMMOGEAHOHO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MMCPIPNNMGN HEKAEADBDDE;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHOINIABJCB();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<ODHGHEGHGCB> NMOOINBEKNI([Optional][CanBeNull] DIJEGIOFGFI JAPPKAPOAIK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ODHGHEGHGCB> EIPNIGCMLDO(ODNOGOADEAI IDDMFKMOAIA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<ODHGHEGHGCB> HECINAFJEPE(int DNHODCCDDPH);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LDCBOLAEFLO(string OIPMKBNDJIF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<ODHGHEGHGCB> GKEJIADLANM(EHINBDMEHCH LLHGAGNPGHM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JMNCHFFEGCE(CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface NGGIJKCGJLP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string CEGMOOEMHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDLHJJGBNNH(Scene CIPLKDLDBAG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ABENAAJEEAG(AJEPHCOGOEA EBJFJIOBAJN, CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GJMGHDCEIFH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int CCNFBNKCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool POEPMMJPNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DJDPBEEDBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ECDBFMGCDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FNBGHCKIOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool KGJMADBCHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	ODNOGOADEAI NCGONMNFDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PCJIKNDFKDJ LDMNNJCHGDF(PCJIKNDFKDJ JAEPIDIGJJL);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBLOLANJNPM(PCJIKNDFKDJ DFNJPCAHLCE);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DEONPBHMJDI(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MHEBAMCOONE(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OOIGLHKLMGI(HPDLOCNANFC OGOCJGMDPHC, [Optional] CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HPNKILKNAAK(float JGHPCJLFMGN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMODEHNJLDH(string HFKKJONCLJD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<LIIJBJHCLEL> NIOGCFDHFMG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable DMGIKBNHFMD(object IGBOEABBEHO, LIIJBJHCLEL NNLLCNEEDAP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DEENGOJEGMM OLGOGMKEEEH();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JNCCKDDPCGC(int DNECAPJNGOF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task CMNLPGLAMNI();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JOALHLGPLGB();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool LDIJBIAPALG();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task GLJILEPLFIF(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NLDMGECKCHD(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<JPBNFIDNCDN> BJIACBGNAOP(DateTime EDNHNJOBHMK, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> MOBMMIMMCAL(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OGLBMECOCOP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BEOCLJBPFIA PJDAPMNBJOK(JLDDHJDNFNG LDPABPOPAML, KHMOACGNIHJ BGGNDLOBKLP, IEnumerable<PersistenceView> JILIIJEPCJJ, ref AGLLAILKMMG MEIPCFLGHCE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DIABJGIAMPI(MMNPPFHGILJ FEKDOHINCFN, in BEOCLJBPFIA ELGPOOCMMCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BFHADIILKFJ(KHMOACGNIHJ LDGIDBEGKFC, bool NFJAPANJJBH);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CHABLPCEKEL();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void EEMDAGOCDKN(long BDNAKAPNAFM, long BGHODONOFKO, DIJEGIOFGFI PBMANDLMOMN, EOLBBGGAHOM OMHBOKLKCMH);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FCAGOHNMHNO(long BDNAKAPNAFM, long BGHODONOFKO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GEMLDNJCBGB(PersistenceView OEEMDPAGKBM);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool NGHFDGJJIMC(PersistenceView JJOFMICFAJO);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JPEPFLKNBLF(MMNPPFHGILJ FEKDOHINCFN, MCJDIFJPNAH OKJPLBMFAAJ, out BBILIEECLND GHLNNDDLBNM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GNEJABCKBDL();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KJIPMBBHAPD();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable IAJNJFOIPOL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AOFAFJDBCPE(KHMOACGNIHJ LDGIDBEGKFC, MCJDIFJPNAH OKJPLBMFAAJ);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> KBKKFDHOCPE(LHBHABEPLIM FMJNCAAMIPB, CancellationToken OHJGLBPIBBN, HKLBBGEFPMO NMGDNGMBHAG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OPFDLAAFPHI(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<NMDEGDIDAOM> INNBCLIFKJE(long BDNAKAPNAFM, long BGHODONOFKO, string BLHPGIMDEGL, CIJIGPEHFJD.AJEIOLHPDCM DPFMLJHHCKP, CIJIGPEHFJD.AJEIOLHPDCM ONIDIMKJKKF, Dictionary<long, int> OLJBFNENLCJ, int APIIOOFAGAP, string HFDADMMNOIG, bool HJEECPICPAL, int PNJDJINDFCC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<HNOFBHJLOMI> DDEOAEODLJH(string OJLDLNLLPIK, long BDNAKAPNAFM, long BGHODONOFKO, string BLHPGIMDEGL, CIJIGPEHFJD.AJEIOLHPDCM DPFMLJHHCKP, CIJIGPEHFJD.AJEIOLHPDCM ONIDIMKJKKF, int KLGMAAJMFEI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<DIJEGIOFGFI> IGLBALLCLCL(long BDNAKAPNAFM, bool KPAFOPOBFCC, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MGEOCPCAPDA();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LDJIENBAHNI();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] CIECBFODHPH(CFENKLMHKBJ[] GBKEHFOEKDH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HPGEEDGPHPM(List<GameObject> NNKADAFCGDO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float HPOCAHGNDNM();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> FCOJHHBKJFF(string COMINAANPMI, LoadSceneMode KGMIOAFIGPM, bool FHJKEIFCOLE, HKLBBGEFPMO MDGABGKAFDE);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OBCLFHFOHAB(APDOMGKMKFG KMHCHOEHAIG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void INHJOKDLEAP(string IFJGKJDPPKE, ODNOGOADEAI FFLNBEOJALG);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task KEJDNLFKPKP(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task ABEANEGBMGC(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void GEHAHGINKOE();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable MOFMEMCNJBI();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	JGDOFPANPPM GMCMOIGGJJO();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JGDOFPANPPM
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AHJPLFJCOCB(CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NIENCBCEDAO(CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BEOCLJBPFIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public HashSet<int> HIDPFLLHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IDisposable PAPKPMLFPAI;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x265B7E0", Offset = "0x265A7E0", VA = "0x18265B7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JPBNFIDNCDN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CMKIBFLEFJN
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	APDOMGKMKFG INBNHCPNHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	DIJEGIOFGFI CCLLHOEDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	MPGLODPOCPP BPFFLENGBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EINONCANNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool KKOFKOJDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int CCNFBNKCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action NCIJLLJFKFL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<int> OIOIGPAIHDI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPKOEBBCNOB();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.IHDNLLGKMEP> DHKDHJPLFLG();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LONDCBGJGNO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	APDOMGKMKFG PLLHHLGJECP();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BAOCFLKKNFF LAIMHNAKKHO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDKEDMDOOOF(long JACMPOFNBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KKCDDKGBHII
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKOFKIOMGLM(out IEnumerable<int> DOBKMMIKOOO);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIMIFDGGCGA(JPJBFCEOADG FDKCIGPLPAB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APPLIHAFBIL(JPJBFCEOADG FDKCIGPLPAB);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MGDODAAKNNO
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NKIGGNONBEN(ODHGHEGHGCB NOIHJFNCIFO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DJCHLLCLNPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPKOPOIFGGE(EELOPAPIKAM.HKFIEGCHJPA CEKHEBPFIPJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNCCBPAEEPL(EELOPAPIKAM.HKFIEGCHJPA CEKHEBPFIPJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AJIMEGCKBBC : DJCHLLCLNPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODHGHEGHGCB GJGGIPEABNE(ODNOGOADEAI DAGJCDCAJFO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KFMPBCNDGGB : DJCHLLCLNPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODHGHEGHGCB AJGFBBGFEPB(ODNOGOADEAI NLCFFNAAEHG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BDLMCAKMBAG
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::OANJAMKPOEA<AJEPHCOGOEA, LNLCMCKKKGI>> NDDDFGJLINK(string BLHPGIMDEGL, long JACMPOFNBDM, JJIIFMBPEMP.POCOGIGDIGK DCCJBFFGHGO, CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BCFJIOEINCO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::OANJAMKPOEA<byte[], LNLCMCKKKGI>> NNECMOAOCMN(TGetDataArg GFEODCCFHNP, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OANJAMKPOEA<global::DBENDBIPDML<TData>, LNLCMCKKKGI> JIPNKNACJCM(byte[] PJDKPCLOECB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class HBNKKFCLKMB : CDJBHBCLHCD, EMEJKEABALH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct LICDJHDIBAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HBNKKFCLKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public EHINBDMEHCH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<ODHGHEGHGCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x35D2F10", Offset = "0x35D1F10", VA = "0x1835D2F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x35D31B0", Offset = "0x35D21B0", VA = "0x1835D31B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GEJFELDDOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HBNKKFCLKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x35CCF10", Offset = "0x35CBF10", VA = "0x1835CCF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class HOJPEAINLDA : IEnumerable<GGDBKLMDLIG>, IEnumerable, IEnumerator<GGDBKLMDLIG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private GGDBKLMDLIG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HBNKKFCLKMB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private GGDBKLMDLIG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public HOJPEAINLDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x35CF3B0", Offset = "0x35CE3B0", VA = "0x1835CF3B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35CF7F0", Offset = "0x35CE7F0", VA = "0x1835CF7F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x35CF750", Offset = "0x35CE750", VA = "0x1835CF750", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GGDBKLMDLIG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35CF750", Offset = "0x35CE750", VA = "0x1835CF750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CancellationTokenSource FKACEEICAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PCJIKNDFKDJ DFNJPCAHLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private KGDKMOMNLJA BHHCEFIBAPL;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public LHBHABEPLIM BMACDOJDALF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x72D4A0", Offset = "0x72C4A0", VA = "0x18072D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public NPJEBNJGELF PFBLNBBNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x660760", Offset = "0x65F760", VA = "0x180660760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4000", Offset = "0x6D3000", VA = "0x1806D4000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x64A0B0", Offset = "0x6490B0", VA = "0x18064A0B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x72D490", Offset = "0x72C490", VA = "0x18072D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NGGIJKCGJLP HEDDBOKEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x660770", Offset = "0x65F770", VA = "0x180660770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAB0", Offset = "0x6EAAB0", VA = "0x1806EBAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public AJIMEGCKBBC PFJLKJIPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x660780", Offset = "0x65F780", VA = "0x180660780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75CEB0", Offset = "0x75BEB0", VA = "0x18075CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public KFMPBCNDGGB CJGLJFKDAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x660700", Offset = "0x65F700", VA = "0x180660700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x672860", Offset = "0x671860", VA = "0x180672860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NPPGBANJAMC MOOOGAKEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x660710", Offset = "0x65F710", VA = "0x180660710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x681DB0", Offset = "0x680DB0", VA = "0x180681DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public FPKFEENENKO ECHIIKDGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6866D0", Offset = "0x6856D0", VA = "0x1806866D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x681D90", Offset = "0x680D90", VA = "0x180681D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BJGELKDEMLP JMMFOAJMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x650D80", Offset = "0x64FD80", VA = "0x180650D80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x902300", Offset = "0x901300", VA = "0x180902300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public PDGLPNCNIGB CHBGDIOAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x650E20", Offset = "0x64FE20", VA = "0x180650E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4510", Offset = "0x7E3510", VA = "0x1807E4510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ANGLDKLCNIL IFKFJEIFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6866A0", Offset = "0x6856A0", VA = "0x1806866A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x901920", Offset = "0x900920", VA = "0x180901920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public AAJPBPBNKKA FPFNCEMCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x660720", Offset = "0x65F720", VA = "0x180660720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x681DA0", Offset = "0x680DA0", VA = "0x180681DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public DMJOFNEHOAE PBDDAGFJCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x660730", Offset = "0x65F730", VA = "0x180660730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6CE540", Offset = "0x6CD540", VA = "0x1806CE540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public AACEJKINIDC PFIMFMFMNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x660750", Offset = "0x65F750", VA = "0x180660750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x798030", Offset = "0x797030", VA = "0x180798030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public IKBEIDBGMGK PPDCNBCKHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x660740", Offset = "0x65F740", VA = "0x180660740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x681DC0", Offset = "0x680DC0", VA = "0x180681DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public ANOHCFDFHDC DKJDJKOLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x739200", Offset = "0x738200", VA = "0x180739200", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x739250", Offset = "0x738250", VA = "0x180739250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BPBOEKMGJMK BDCLJAFJCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7027A0", Offset = "0x7017A0", VA = "0x1807027A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x795790", Offset = "0x794790", VA = "0x180795790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MIONDDMMAKC INBIIBMJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x739120", Offset = "0x738120", VA = "0x180739120", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x739210", Offset = "0x738210", VA = "0x180739210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public FGOAJCHMBDH MHCFAFOPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E18E0", Offset = "0x7E08E0", VA = "0x1807E18E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7E19C0", Offset = "0x7E09C0", VA = "0x1807E19C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public EPCKILAPKNE PIFIIFGBKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x796410", Offset = "0x795410", VA = "0x180796410", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7E2630", Offset = "0x7E1630", VA = "0x1807E2630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OJGLOFJPEPP CFOKPHOLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x796110", Offset = "0x795110", VA = "0x180796110", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x796440", Offset = "0x795440", VA = "0x180796440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DJDJIIDPFGC BDMNCMLOHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7960F0", Offset = "0x7950F0", VA = "0x1807960F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x796420", Offset = "0x795420", VA = "0x180796420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KBLHKAMAGAN BAANPPJDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x796100", Offset = "0x795100", VA = "0x180796100", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x796430", Offset = "0x795430", VA = "0x180796430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KKCDDKGBHII EEHDHABDLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7E2620", Offset = "0x7E1620", VA = "0x1807E2620", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x11CD500", Offset = "0x11CC500", VA = "0x1811CD500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PGIPFOJCNHM NKHIOKDMPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7963F0", Offset = "0x7953F0", VA = "0x1807963F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x796590", Offset = "0x795590", VA = "0x180796590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LMPCEFKGPKI KLCLPFPEDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x796400", Offset = "0x795400", VA = "0x180796400", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7965A0", Offset = "0x7955A0", VA = "0x1807965A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ECPCGLHGMDH KJBFBKJGMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3770", Offset = "0xAE2770", VA = "0x180AE3770", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAE2E00", Offset = "0xAE1E00", VA = "0x180AE2E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KMKFLCJMGIB BCFDJKIBENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAE18D0", Offset = "0xAE08D0", VA = "0x180AE18D0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private bool MBGBLBDOPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2669A40", Offset = "0x2668A40", VA = "0x182669A40", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private bool JNNHCCICLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2669740", Offset = "0x2668740", VA = "0x182669740", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private CancellationToken NPIMDFKIHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2669A20", Offset = "0x2668A20", VA = "0x182669A20", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private PCJIKNDFKDJ GOJHIBBECOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event Action DOLENBLMMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2669B70", Offset = "0x2668B70", VA = "0x182669B70", Slot = "34")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2669830", Offset = "0x2668830", VA = "0x182669830", Slot = "35")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event MMCPIPNNMGN LHEDNHBAHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2669B10", Offset = "0x2668B10", VA = "0x182669B10", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2669470", Offset = "0x2668470", VA = "0x182669470", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event MMCPIPNNMGN ILPBMDHDLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2669C20", Offset = "0x2668C20", VA = "0x182669C20", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2669FA0", Offset = "0x2668FA0", VA = "0x182669FA0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event MMCPIPNNMGN GJFDNPBFOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2669F40", Offset = "0x2668F40", VA = "0x182669F40", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x26695F0", Offset = "0x26685F0", VA = "0x1826695F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x266A120", Offset = "0x2669120", VA = "0x18266A120")]
	[Preserve]
	internal HBNKKFCLKMB([NBLPGINBDGI(null)] PCJIKNDFKDJ DFNJPCAHLCE, [NBLPGINBDGI(null)] LHBHABEPLIM FMJNCAAMIPB, [NBLPGINBDGI(null)] NPJEBNJGELF DGAJKPEIOBE, [NBLPGINBDGI(null)] GJMGHDCEIFH OHLAEPJHHCL, [NBLPGINBDGI(null)] NGGIJKCGJLP LPAAMKBAAOM, [NBLPGINBDGI(null)] AJIMEGCKBBC BCIIFCABENC, [NBLPGINBDGI(null)] KFMPBCNDGGB BNGBGHDDGIH, [NBLPGINBDGI(null)] NPPGBANJAMC CBKHFKPLKFG, [NBLPGINBDGI(null)] FPKFEENENKO CEJBKJKONBE, [NBLPGINBDGI(null)] BJGELKDEMLP OFAFNLEGJNE, [NBLPGINBDGI(null)] PDGLPNCNIGB JKAKLGDNGFP, [NBLPGINBDGI(null)] ANGLDKLCNIL JJJEGDCOGBJ, [NBLPGINBDGI(null)] AAJPBPBNKKA NNDEMEJOBHL, [NBLPGINBDGI(null)] DMJOFNEHOAE IIPBIIDNJJE, [NBLPGINBDGI(null)] AACEJKINIDC KGBAFKGOBAK, [NBLPGINBDGI(null)] IKBEIDBGMGK KPPKPBLNGIE, [NBLPGINBDGI(null)] ANOHCFDFHDC LHGBHJIHNAL, [NBLPGINBDGI(null)] BPBOEKMGJMK MCNCKAAHEED, [NBLPGINBDGI(null)] MIONDDMMAKC ICDJBKBDPDH, [NBLPGINBDGI(null)] FGOAJCHMBDH HPPHBGMILJH, [NBLPGINBDGI(null)] OJGLOFJPEPP LCALLBKICCE, [NBLPGINBDGI(null)] EPCKILAPKNE DHMACOGKGOK, [NBLPGINBDGI(null)] DJDJIIDPFGC DJEOMGBJAFP, [NBLPGINBDGI(null)] KBLHKAMAGAN KMHBMNGPGKD, [NBLPGINBDGI(null)] KKCDDKGBHII POLGNBGFCNI, [NBLPGINBDGI(null)] LMPCEFKGPKI LEPJIGHFGOA, [NBLPGINBDGI(null)] ECPCGLHGMDH NOPDLOGLDFN, [NBLPGINBDGI(null)] KMKFLCJMGIB LAFEDHFMOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2669650", Offset = "0x2668650", VA = "0x182669650")]
	private void CDFKCHBFAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2669890", Offset = "0x2668890", VA = "0x182669890", Slot = "51")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2669BD0", Offset = "0x2668BD0", VA = "0x182669BD0", Slot = "44")]
	private void IFLLMLHKKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x266A000", Offset = "0x2669000", VA = "0x18266A000", Slot = "48")]
	private Task ONFIIMMBIGM(string OIPMKBNDJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2669EA0", Offset = "0x2668EA0", VA = "0x182669EA0", Slot = "45")]
	private Task<ODHGHEGHGCB> KHBCPKNHOJH(DIJEGIOFGFI JAPPKAPOAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x26697C0", Offset = "0x26687C0", VA = "0x1826697C0", Slot = "46")]
	private Task<ODHGHEGHGCB> DFBPBKFEEHM(ODNOGOADEAI IDDMFKMOAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2669DC0", Offset = "0x2668DC0", VA = "0x182669DC0", Slot = "47")]
	private Task<ODHGHEGHGCB> JKPEMOAAJKA(int DNHODCCDDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2669C80", Offset = "0x2668C80", VA = "0x182669C80", Slot = "49")]
	[AsyncStateMachine(typeof(LICDJHDIBAN))]
	private Task<ODHGHEGHGCB> JALMGNFIKDA(EHINBDMEHCH JHJBCECDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x26694D0", Offset = "0x26684D0", VA = "0x1826694D0", Slot = "50")]
	[AsyncStateMachine(typeof(GEJFELDDOAA))]
	private Task AFDNNEJPFKI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2669AA0", Offset = "0x2668AA0", VA = "0x182669AA0")]
	[IteratorStateMachine(typeof(HOJPEAINLDA))]
	private IEnumerable<GGDBKLMDLIG> FIKAHFAKNMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x266A0C0", Offset = "0x26690C0", VA = "0x18266A0C0")]
	[CompilerGenerated]
	private void PHIBKJIIEOL(GGDBKLMDLIG CHHHDNBJJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class JCJDHALGCDL : EOGDGKLJHLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KIGKOLMPLHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JCJDHALGCDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x35D1BD0", Offset = "0x35D0BD0", VA = "0x1835D1BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35D1F50", Offset = "0x35D0F50", VA = "0x1835D1F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x64A6E0", Offset = "0x6496E0", VA = "0x18064A6E0")]
	public JCJDHALGCDL(CDJBHBCLHCD MEFFMNONBAI, GJMGHDCEIFH OHLAEPJHHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2672900", Offset = "0x2671900", VA = "0x182672900", Slot = "4")]
	[AsyncStateMachine(typeof(KIGKOLMPLHM))]
	public Task<bool> KFLDANKIFJI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2672820", Offset = "0x2671820", VA = "0x182672820")]
	[CompilerGenerated]
	private object IHIFLDFAGGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class EJJFDECMKKF : EOGDGKLJHLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IMGPFBIMDCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EJJFDECMKKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C98D80", Offset = "0x2C97D80", VA = "0x182C98D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C993A0", Offset = "0x2C983A0", VA = "0x182C993A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const float DIPLMEGIMIH = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x26612D0", Offset = "0x26602D0", VA = "0x1826612D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x64A6E0", Offset = "0x6496E0", VA = "0x18064A6E0")]
	public EJJFDECMKKF(CDJBHBCLHCD MEFFMNONBAI, GJMGHDCEIFH OHLAEPJHHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2661190", Offset = "0x2660190", VA = "0x182661190", Slot = "4")]
	[AsyncStateMachine(typeof(IMGPFBIMDCA))]
	public Task<bool> KFLDANKIFJI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x26610B0", Offset = "0x26600B0", VA = "0x1826610B0")]
	[CompilerGenerated]
	private object KCDFAONGCDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class OLPGHMOOCOB : EOGDGKLJHLB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class PFHFPDOLOAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public OLPGHMOOCOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Matchmaking.IHDNLLGKMEP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public APDOMGKMKFG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PFHFPDOLOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x42B7100", Offset = "0x42B6100", VA = "0x1842B7100")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x42B7250", Offset = "0x42B6250", VA = "0x1842B7250")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x42B72C0", Offset = "0x42B62C0", VA = "0x1842B72C0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LKLHDDDNFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OLPGHMOOCOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private PFHFPDOLOAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<Matchmaking.IHDNLLGKMEP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x42B15D0", Offset = "0x42B05D0", VA = "0x1842B15D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x42B1E90", Offset = "0x42B0E90", VA = "0x1842B1E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private const float DIPLMEGIMIH = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8200", Offset = "0x2CA7200", VA = "0x182CA8200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64A6E0", Offset = "0x6496E0", VA = "0x18064A6E0")]
	public OLPGHMOOCOB(CDJBHBCLHCD MEFFMNONBAI, GJMGHDCEIFH OHLAEPJHHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA80C0", Offset = "0x2CA70C0", VA = "0x182CA80C0", Slot = "4")]
	[AsyncStateMachine(typeof(LKLHDDDNFFF))]
	public Task<bool> KFLDANKIFJI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface EOGDGKLJHLB
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> KFLDANKIFJI(CancellationToken OHJGLBPIBBN);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct NNMHHJLBNPI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class CAMMEGFFDKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CDJBHBCLHCD manager;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CAMMEGFFDKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x42AC1B0", Offset = "0x42AB1B0", VA = "0x1842AC1B0")]
		internal Task <CreateTask>b__0(CEBPIIBHMDD data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct AKHLIGFHKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public NNMHHJLBNPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private EHINBDMEHCH <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<JPBNFIDNCDN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<ODHGHEGHGCB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42AAD70", Offset = "0x42A9D70", VA = "0x1842AAD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x42AB280", Offset = "0x42AA280", VA = "0x1842AB280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct PDDEKBGAEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public NNMHHJLBNPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x42B6ED0", Offset = "0x42B5ED0", VA = "0x1842B6ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CancellationToken OHJGLBPIBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly CDJBHBCLHCD FMHLMANFIDO;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private LHBHABEPLIM BMACDOJDALF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA65D0", Offset = "0x2CA55D0", VA = "0x182CA65D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6750", Offset = "0x2CA5750", VA = "0x182CA6750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6C40", Offset = "0x2CA5C40", VA = "0x182CA6C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private BJGELKDEMLP JMMFOAJMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6BF0", Offset = "0x2CA5BF0", VA = "0x182CA6BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6CC0", Offset = "0x2CA5CC0", VA = "0x182CA6CC0")]
	public NNMHHJLBNPI(CancellationToken OHJGLBPIBBN, CDJBHBCLHCD FMHLMANFIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6520", Offset = "0x2CA5520", VA = "0x182CA6520")]
	public static HFDLPGEBHAE AENILGIBHIF(CDJBHBCLHCD FMHLMANFIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6620", Offset = "0x2CA5620", VA = "0x182CA6620")]
	[AsyncStateMachine(typeof(AKHLIGFHKOL))]
	public Task<bool> CHCDHEIAFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA68E0", Offset = "0x2CA58E0", VA = "0x182CA68E0")]
	private bool HLKIBJHBMDN(out EHINBDMEHCH JHJBCECDIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6AF0", Offset = "0x2CA5AF0", VA = "0x182CA6AF0")]
	[AsyncStateMachine(typeof(PDDEKBGAEGM))]
	private Task IAOEJLBBNOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA67A0", Offset = "0x2CA57A0", VA = "0x182CA67A0")]
	private Task<JPBNFIDNCDN> DIOJHGNKDDG(EHINBDMEHCH PKBNLBPBEGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct GONGPCOEAHB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly AACEJKINIDC KGBAFKGOBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Guid IBJDBAKNBNO;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private Task<(ODHGHEGHGCB, Task)> AFGCJJCJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2668CF0", Offset = "0x2667CF0", VA = "0x182668CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E820", Offset = "0x1F7D820", VA = "0x181F7E820")]
	public GONGPCOEAHB(AACEJKINIDC KGBAFKGOBAK, Guid IBJDBAKNBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2668E90", Offset = "0x2667E90", VA = "0x182668E90")]
	public TaskAwaiter<(ODHGHEGHGCB, Task)> MNEJODKLAOG()
	{
		return default(TaskAwaiter<(ODHGHEGHGCB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2668DC0", Offset = "0x2667DC0", VA = "0x182668DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct NGMPALOKIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly TaskCompletionSource<(ODHGHEGHGCB, Task)> OFHAOLOLLBN;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Task<(ODHGHEGHGCB, Task)> AFGCJJCJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1C20", Offset = "0x2CA0C20", VA = "0x182CA1C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1EB0", Offset = "0x2CA0EB0", VA = "0x182CA1EB0")]
	public NGMPALOKIPD(TimeSpan EIPFKPHACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1DD0", Offset = "0x2CA0DD0", VA = "0x182CA1DD0")]
	public void PCNIIMBOHMD(Task DIJCFDEMACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1C60", Offset = "0x2CA0C60", VA = "0x182CA1C60")]
	public void GMHOCKAELOK(ODHGHEGHGCB NOIHJFNCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1CF0", Offset = "0x2CA0CF0", VA = "0x182CA1CF0")]
	public void HLBMPGPGADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1D40", Offset = "0x2CA0D40", VA = "0x182CA1D40")]
	internal void PALHFKEOJBH(string NJAIIGFCHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Preserve]
internal class DPKKHPHNOGP : FPKFEENENKO, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct HFLBNNHNNMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DPKKHPHNOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C97940", Offset = "0x2C96940", VA = "0x182C97940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly JPJBFCEOADG IOHKIHEKMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private string JINBEAAMICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Task NGEMHDDFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool CHDBEOAKJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2660A80", Offset = "0x265FA80", VA = "0x182660A80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Task AEIJNNODKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2660AB0", Offset = "0x265FAB0", VA = "0x182660AB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0", Slot = "7")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2660B10", Offset = "0x265FB10", VA = "0x182660B10", Slot = "6")]
	public void LOGBLFNIICL(Task IIDIGDMKMIO, string NAMAKPBBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2660950", Offset = "0x265F950", VA = "0x182660950")]
	[AsyncStateMachine(typeof(HFLBNNHNNMA))]
	private Task CMNNFDKHILI(Task OFPEFOLBHKH, string NAMAKPBBCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2660C90", Offset = "0x265FC90", VA = "0x182660C90")]
	public DPKKHPHNOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class INAFJNNEDED : PGIPFOJCNHM, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool GMMGJHENFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private DEBBKGCKOLK HPPOFCKCDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LMPCEFKGPKI LEPJIGHFGOA;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DEBBKGCKOLK IMPOHOMIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x266E490", Offset = "0x266D490", VA = "0x18266E490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x266E090", Offset = "0x266D090", VA = "0x18266E090", Slot = "7")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x266E2D0", Offset = "0x266D2D0", VA = "0x18266E2D0", Slot = "5")]
	public void FLALKHMJKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x266E290", Offset = "0x266D290", VA = "0x18266E290", Slot = "6")]
	public void LOABPDJLFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x266E210", Offset = "0x266D210", VA = "0x18266E210")]
	private Task CDMEADEGNKO(GJLEJDIOIJF NJKKDANCIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x266E290", Offset = "0x266D290", VA = "0x18266E290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public INAFJNNEDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class FOLOLLNJLKE : LMPCEFKGPKI
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JJICOIJFJOM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly KGDDELCDBGB HJEJOCANIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly string AGPLDPOAAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly T KFOCAJEFKKD;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public T FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x64E270", Offset = "0x64D270", VA = "0x18064E270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F18100", Offset = "0x3F17100", VA = "0x183F18100")]
		public JJICOIJFJOM(KGDDELCDBGB HJEJOCANIMC, string AGPLDPOAAIC, T KFOCAJEFKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F17C00", Offset = "0x3F16C00", VA = "0x183F17C00")]
		private void APBIOEDOKJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly JJICOIJFJOM<TimeSpan> LGECCNGAFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JJICOIJFJOM<TimeSpan> DFEOIBIFLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly JJICOIJFJOM<TimeSpan> JPHGFGCGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly JJICOIJFJOM<TimeSpan> IHOAFONALLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JJICOIJFJOM<bool> DFIGKHNOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly JJICOIJFJOM<bool> JHEHPOGEKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly JJICOIJFJOM<bool> OABBAEGNNDI;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public TimeSpan HJFOHGKOAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2665BB0", Offset = "0x2664BB0", VA = "0x182665BB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public TimeSpan PHMHJDPCDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2665B70", Offset = "0x2664B70", VA = "0x182665B70", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public TimeSpan OFDFNFOHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2665BF0", Offset = "0x2664BF0", VA = "0x182665BF0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public TimeSpan GPOBNGGPAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2665CB0", Offset = "0x2664CB0", VA = "0x182665CB0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool IBGEKCMLAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2665B30", Offset = "0x2664B30", VA = "0x182665B30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HAOFHAEGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2665C30", Offset = "0x2664C30", VA = "0x182665C30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool DIOKONAGPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2665C70", Offset = "0x2664C70", VA = "0x182665C70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2665CF0", Offset = "0x2664CF0", VA = "0x182665CF0")]
	[Preserve]
	public FOLOLLNJLKE([NBLPGINBDGI(null)] KGDDELCDBGB HJEJOCANIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Preserve]
internal class BELNAHJENAD : PDGLPNCNIGB, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EBIOEPOOLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EFBIDOEEHFO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EBIOEPOOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C95D40", Offset = "0x2C94D40", VA = "0x182C95D40")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action GLMFLMDDEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x265B600", Offset = "0x265A600", VA = "0x18265B600", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x265ADF0", Offset = "0x2659DF0", VA = "0x18265ADF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event MMCPIPNNMGN ANICELDEEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x265B420", Offset = "0x265A420", VA = "0x18265B420", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x265AE90", Offset = "0x2659E90", VA = "0x18265AE90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event MMCPIPNNMGN OMMOGEAHOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x265B6A0", Offset = "0x265A6A0", VA = "0x18265B6A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x265B4C0", Offset = "0x265A4C0", VA = "0x18265B4C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event MMCPIPNNMGN HEKAEADBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x265B740", Offset = "0x265A740", VA = "0x18265B740", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x265B560", Offset = "0x265A560", VA = "0x18265B560", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "16")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x265B1B0", Offset = "0x265A1B0", VA = "0x18265B1B0", Slot = "12")]
	public void KCKIOKEJJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x265AF30", Offset = "0x2659F30", VA = "0x18265AF30", Slot = "13")]
	public void IIAJBGMLGPO(EFBIDOEEHFO NCOJPJKLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x265AD90", Offset = "0x2659D90", VA = "0x18265AD90", Slot = "14")]
	public void BDJPHGDLIIF(EFBIDOEEHFO NCOJPJKLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x265ADC0", Offset = "0x2659DC0", VA = "0x18265ADC0", Slot = "15")]
	public void FBNPAOEAMAO(EFBIDOEEHFO NCOJPJKLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x265AF60", Offset = "0x2659F60", VA = "0x18265AF60")]
	private void JAKEEOPOMIO(MMCPIPNNMGN NNLLCNEEDAP, EFBIDOEEHFO NCOJPJKLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BELNAHJENAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Preserve]
internal class GGBBMBLDMBB : ANGLDKLCNIL, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct CFCHGBFKIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public GGBBMBLDMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x35C7810", Offset = "0x35C6810", VA = "0x1835C7810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct LMKAAPABFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public GGBBMBLDMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x35D3C80", Offset = "0x35D2C80", VA = "0x1835D3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OMADLKCMAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OMADLKCMAJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x35D6AF0", Offset = "0x35D5AF0", VA = "0x1835D6AF0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct GLBKJCMHMAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GGBBMBLDMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private OMADLKCMAJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x35CDB40", Offset = "0x35CCB40", VA = "0x1835CDB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x35CE0D0", Offset = "0x35CD0D0", VA = "0x1835CE0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IDGLGHIJKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IDGLGHIJKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x35CF830", Offset = "0x35CE830", VA = "0x1835CF830")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private EOGDGKLJHLB[] JEMMHABALFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CancellationTokenSource NLJGOGNMNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int POOMNKBAKEB;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x26670F0", Offset = "0x26660F0", VA = "0x1826670F0", Slot = "7")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x26672D0", Offset = "0x26662D0", VA = "0x1826672D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2667820", Offset = "0x2666820", VA = "0x182667820", Slot = "6")]
	public void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2666FA0", Offset = "0x2665FA0", VA = "0x182666FA0", Slot = "5")]
	public void AHOINIABJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2667490", Offset = "0x2666490", VA = "0x182667490", Slot = "4")]
	[AsyncStateMachine(typeof(CFCHGBFKIDF))]
	public Task HIKKLLHPIAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2667AD0", Offset = "0x2666AD0", VA = "0x182667AD0")]
	private void OHDNBDFAFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x26676F0", Offset = "0x26666F0", VA = "0x1826676F0")]
	[AsyncStateMachine(typeof(LMKAAPABFLK))]
	private Task KNMMMICPLFD(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x26675A0", Offset = "0x26665A0", VA = "0x1826675A0")]
	[AsyncStateMachine(typeof(GLBKJCMHMAD))]
	private Task<bool> IEGPAFOKOJM(int MMABPPDCBIB, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2667170", Offset = "0x2666170", VA = "0x182667170")]
	private void COJONANFPCB(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2667990", Offset = "0x2666990", VA = "0x182667990")]
	private void NLCNBFHPABG(int MMABPPDCBIB, bool CLHNHEDOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x26672E0", Offset = "0x26662E0", VA = "0x1826672E0")]
	private void EHMJLILFFPK(int MMABPPDCBIB, Exception OMAAJIFLBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2667E20", Offset = "0x2666E20", VA = "0x182667E20")]
	private void PCEMGAIODPA(CancellationToken OHJGLBPIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GGBBMBLDMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[Preserve]
internal class IPJNLJDPGOE : DMJOFNEHOAE, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct LJCHIFEPIAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IPJNLJDPGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CEBPIIBHMDD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x35D34D0", Offset = "0x35D24D0", VA = "0x1835D34D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class CADKBAJLJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public IPJNLJDPGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CEBPIIBHMDD roomData;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CADKBAJLJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x35C7550", Offset = "0x35C6550", VA = "0x1835C7550")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct MPFLEAOABHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public HFDLPGEBHAE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x35D5050", Offset = "0x35D4050", VA = "0x1835D5050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct ENLILIKNPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public IPJNLJDPGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x35CAE30", Offset = "0x35C9E30", VA = "0x1835CAE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly HashSet<HFDLPGEBHAE> FEOJKIEPJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NPJEBNJGELF DGAJKPEIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LIIJBJHCLEL EOEFHEENGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ENKKGOGPPDJ ENDJLAKFPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private IDisposable LPADOKDMLFH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FGCCLAIAEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x26717C0", Offset = "0x26707C0", VA = "0x1826717C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	internal Task AFGCJJCJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2670C20", Offset = "0x266FC20", VA = "0x182670C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2670980", Offset = "0x266F980", VA = "0x182670980", Slot = "6")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2671160", Offset = "0x2670160", VA = "0x182671160", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2670710", Offset = "0x266F710", VA = "0x182670710", Slot = "5")]
	public bool AAFNHIAGLEF(HFDLPGEBHAE PBJHOONDPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2671460", Offset = "0x2670460", VA = "0x182671460")]
	private void MGKFILAOGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x26711E0", Offset = "0x26701E0", VA = "0x1826711E0")]
	private void HPPCPFOGPIL(CEBPIIBHMDD DPFMLJHHCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x26718F0", Offset = "0x26708F0", VA = "0x1826718F0")]
	[AsyncStateMachine(typeof(LJCHIFEPIAG))]
	private Task OMIIPFBMBGO(CEBPIIBHMDD DPFMLJHHCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x26708A0", Offset = "0x266F8A0", VA = "0x1826708A0")]
	private Func<CancellationToken, List<Task>> BLAODDCOIEN(CEBPIIBHMDD DPFMLJHHCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2670C30", Offset = "0x266FC30", VA = "0x182670C30")]
	private List<Task> DLIOFNKAPJL(CEBPIIBHMDD DPFMLJHHCKP, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2670770", Offset = "0x266F770", VA = "0x182670770")]
	[AsyncStateMachine(typeof(MPFLEAOABHF))]
	private Task ANBNGDOOFEJ(HFDLPGEBHAE NGAGNDOFOGP, CEBPIIBHMDD PJDKPCLOECB, CancellationToken FDKCIGPLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x26717F0", Offset = "0x26707F0", VA = "0x1826717F0")]
	[AsyncStateMachine(typeof(ENLILIKNPHK))]
	private Task NNGFCLCKFLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x26716A0", Offset = "0x26706A0", VA = "0x1826716A0")]
	private void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2671A10", Offset = "0x2670A10", VA = "0x182671A10")]
	public IPJNLJDPGOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Preserve]
internal class AKKMHFCIOJI : AAJPBPBNKKA, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FBJAAOLIDED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2C95F30", Offset = "0x2C94F30", VA = "0x182C95F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct CGDAPGIOPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private global::BJNCMLEHIAG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private OHPHHOAEIIK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private NBGKBJJBNNC <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2C91FA0", Offset = "0x2C90FA0", VA = "0x182C91FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GHPCJMALMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Task<CAOKGENDBMG> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GHPCJMALMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		internal Task<CAOKGENDBMG> <ConnectToRoomAndRunLoadLogic>b__0(HKLBBGEFPMO _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct CPHPINAJFGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OHPHHOAEIIK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private GHPCJMALMDL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private AKIFNHNILDO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private HKLBBGEFPMO <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private CKFJHMPIILJ <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<CAOKGENDBMG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2C93530", Offset = "0x2C92530", VA = "0x182C93530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct KOEFPJKGKJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HKLBBGEFPMO <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private HKLBBGEFPMO <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B720", Offset = "0x2C9A720", VA = "0x182C9B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct ICLBJFNEELC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private PCJIKNDFKDJ <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2C984D0", Offset = "0x2C974D0", VA = "0x182C984D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct HCPKCNABHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public OHPHHOAEIIK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private HKLBBGEFPMO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<EOCMPLPJPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2C97280", Offset = "0x2C96280", VA = "0x182C97280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class KOHPPFEOPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KOHPPFEOPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C0E0", Offset = "0x2C9B0E0", VA = "0x182C9C0E0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BFE0", Offset = "0x2C9AFE0", VA = "0x182C9BFE0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct JJJDGIKIMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private KOHPPFEOPHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A750", Offset = "0x2C99750", VA = "0x182C9A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct OFCHKFFICHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public OHPHHOAEIIK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public CAOKGENDBMG initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public APDOMGKMKFG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AKIFNHNILDO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private HKLBBGEFPMO <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7900", Offset = "0x2CA6900", VA = "0x182CA7900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CPGPLIPANDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private HKLBBGEFPMO <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2C93160", Offset = "0x2C92160", VA = "0x182C93160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct GFKLLHGADND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2C967A0", Offset = "0x2C957A0", VA = "0x182C967A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct BBNCHIBFOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2C91BA0", Offset = "0x2C90BA0", VA = "0x182C91BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct APKJBADHHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<ODHGHEGHGCB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2C910E0", Offset = "0x2C900E0", VA = "0x182C910E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct KPNFPKELKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AKKMHFCIOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C1E0", Offset = "0x2C9B1E0", VA = "0x182C9C1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class JEFJGLNJPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JEFJGLNJPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2C99BF0", Offset = "0x2C98BF0", VA = "0x182C99BF0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class LHHADGFLNLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LHHADGFLNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C960", Offset = "0x2C9B960", VA = "0x182C9C960")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EOJELHHKNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EOJELHHKNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2C95EB0", Offset = "0x2C94EB0", VA = "0x182C95EB0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GHBHKFIEKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GHBHKFIEKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2C96E30", Offset = "0x2C95E30", VA = "0x182C96E30")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string GOHOPGGPEEE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string INDADKIDPHM;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string DNBOPPJFLIC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid NAFILKKFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NPPGBANJAMC CBKHFKPLKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NPJEBNJGELF DGAJKPEIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private ANGLDKLCNIL JJJEGDCOGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FPKFEENENKO CEJBKJKONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private PDGLPNCNIGB JKAKLGDNGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private LMPCEFKGPKI LEPJIGHFGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable LPADOKDMLFH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TaskStatus JKODBMNCGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA40", Offset = "0xA7CA40", VA = "0x180A7DA40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA50", Offset = "0xA7CA50", VA = "0x180A7DA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2659AD0", Offset = "0x2658AD0", VA = "0x182659AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2657020", Offset = "0x2656020", VA = "0x182657020", Slot = "6")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2657EF0", Offset = "0x2656EF0", VA = "0x182657EF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2658840", Offset = "0x2657840", VA = "0x182658840", Slot = "5")]
	[AsyncStateMachine(typeof(FBJAAOLIDED))]
	public Task IOILNCAGFGJ(APDOMGKMKFG CILBKNNEHGI, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2657F40", Offset = "0x2656F40", VA = "0x182657F40")]
	[AsyncStateMachine(typeof(CGDAPGIOPMK))]
	private Task EFCGMJDALGE(APDOMGKMKFG CILBKNNEHGI, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2658A70", Offset = "0x2657A70", VA = "0x182658A70")]
	private static void JAOEHIDJDBH(APDOMGKMKFG CILBKNNEHGI, Exception OMAAJIFLBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2658F40", Offset = "0x2657F40", VA = "0x182658F40")]
	private static void LFFCLCHOFIE(NBGKBJJBNNC PENKDCCIOCE, Exception OMAAJIFLBJK, [Optional] List<int> IMCFEKGPMHC, int POOMNKBAKEB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2656D70", Offset = "0x2655D70", VA = "0x182656D70")]
	[AsyncStateMachine(typeof(CPHPINAJFGD))]
	private Task CCEHJBJMJOA(HKLBBGEFPMO MDGABGKAFDE, APDOMGKMKFG CILBKNNEHGI, OHPHHOAEIIK BNBOIPLBIID, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x26585A0", Offset = "0x26575A0", VA = "0x1826585A0")]
	private void FPJFKELOEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x265A260", Offset = "0x2659260", VA = "0x18265A260")]
	[AsyncStateMachine(typeof(KOEFPJKGKJF))]
	private Task PLPJOHBCKKL(HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2659780", Offset = "0x2658780", VA = "0x182659780")]
	private void MBIAPOJHOHO(APDOMGKMKFG CILBKNNEHGI, CancellationToken PJNOBOOMKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x26579A0", Offset = "0x26569A0", VA = "0x1826579A0")]
	private void DFEOMAABAPA(APDOMGKMKFG CILBKNNEHGI, OHPHHOAEIIK BNBOIPLBIID, OperationCanceledException NEJLFNKGLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x26576E0", Offset = "0x26566E0", VA = "0x1826576E0")]
	private void DCEOCOECAAD(APDOMGKMKFG CILBKNNEHGI, OHPHHOAEIIK BNBOIPLBIID, Exception OMAAJIFLBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2657C60", Offset = "0x2656C60", VA = "0x182657C60")]
	private void DICLLJMCHCB(APDOMGKMKFG CILBKNNEHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x26581C0", Offset = "0x26571C0", VA = "0x1826581C0")]
	private static EFBIDOEEHFO FJJAHPCLLLL(APDOMGKMKFG CILBKNNEHGI)
	{
		return default(EFBIDOEEHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2658970", Offset = "0x2657970", VA = "0x182658970")]
	[AsyncStateMachine(typeof(ICLBJFNEELC))]
	private Task JAMPEOADEID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2658110", Offset = "0x2657110", VA = "0x182658110")]
	private static EOCMPLPJPHG FIOGHCHDPJH(APDOMGKMKFG CILBKNNEHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2656880", Offset = "0x2655880", VA = "0x182656880")]
	[AsyncStateMachine(typeof(HCPKCNABHNH))]
	private Task ALEBNPAHMHI(APDOMGKMKFG CILBKNNEHGI, OHPHHOAEIIK BNBOIPLBIID, HKLBBGEFPMO MDGABGKAFDE, CancellationToken EKKAFPFIHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x265A070", Offset = "0x2659070", VA = "0x18265A070")]
	[AsyncStateMachine(typeof(JJJDGIKIMIN))]
	private Task PHECJFHJLPJ(APDOMGKMKFG CILBKNNEHGI, CancellationTokenSource GAHOGFDJPHE, Task FBALKDPGJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2657550", Offset = "0x2656550", VA = "0x182657550")]
	[AsyncStateMachine(typeof(OFCHKFFICHK))]
	private Task CPMKIDMEPFK(CAOKGENDBMG EBKIPNDPAHM, AKIFNHNILDO NLHBJJIJGOF, APDOMGKMKFG PHIGOAHKKGE, OHPHHOAEIIK GMKKLMGFAOM, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OBHANHDDFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2658360", Offset = "0x2657360", VA = "0x182658360")]
	private OHPHHOAEIIK FLMIAIBFCJH(OHPHHOAEIIK GMKKLMGFAOM, ref CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2658C30", Offset = "0x2657C30", VA = "0x182658C30")]
	[AsyncStateMachine(typeof(CPGPLIPANDJ))]
	private Task JHIKACIGKCC(HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2659DD0", Offset = "0x2658DD0", VA = "0x182659DD0")]
	[AsyncStateMachine(typeof(GFKLLHGADND))]
	private Task PAIOJCIMCEH(HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2656EE0", Offset = "0x2655EE0", VA = "0x182656EE0")]
	[AsyncStateMachine(typeof(BBNCHIBFOLI))]
	private Task CDAHNPOJFBN(HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2658220", Offset = "0x2657220", VA = "0x182658220")]
	[AsyncStateMachine(typeof(APKJBADHHPF))]
	private Task FLJFAAPCKHK(CEBPIIBHMDD PJDKPCLOECB, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2659C90", Offset = "0x2658C90", VA = "0x182659C90")]
	[AsyncStateMachine(typeof(KPNFPKELKGF))]
	private Task OOIGLHKLMGI(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken EKKAFPFIHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2659F00", Offset = "0x2658F00", VA = "0x182659F00")]
	private static void PDPPNPFOLFM(APDOMGKMKFG CILBKNNEHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2658D70", Offset = "0x2657D70", VA = "0x182658D70")]
	private void LCPGOACLNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x265A1D0", Offset = "0x26591D0", VA = "0x18265A1D0")]
	private void PJHAMDOHKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2658080", Offset = "0x2657080", VA = "0x182658080")]
	private void ELFPKHLMKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x26586F0", Offset = "0x26576F0", VA = "0x1826586F0")]
	private void IFMGMFPFCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2659B20", Offset = "0x2658B20", VA = "0x182659B20")]
	private static void ONELKNFAHJE(APDOMGKMKFG CILBKNNEHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2658780", Offset = "0x2657780", VA = "0x182658780")]
	private static void IOIBDFLDPAC(APDOMGKMKFG CILBKNNEHGI, CancellationToken EKKAFPFIHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x26573D0", Offset = "0x26563D0", VA = "0x1826573D0")]
	private static void CNIDLHDJBFI(APDOMGKMKFG CILBKNNEHGI, Exception OMAAJIFLBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2656AD0", Offset = "0x2655AD0", VA = "0x182656AD0")]
	private void BCPFOPFCLOK(APDOMGKMKFG CILBKNNEHGI, Task FBALKDPGJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x26569F0", Offset = "0x26559F0", VA = "0x1826569F0")]
	private static void AMJBGJGBGPP(Func<string> NLDGIOOAAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x265A490", Offset = "0x2659490", VA = "0x18265A490")]
	public AKKMHFCIOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[Preserve]
internal sealed class AJHOCKCHCIE : AACEJKINIDC, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class LABACMOLMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LABACMOLMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C4D0", Offset = "0x2C9B4D0", VA = "0x182C9C4D0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class DJEJJKBAJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DJEJJKBAJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2C94F30", Offset = "0x2C93F30", VA = "0x182C94F30")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class GCDGAHMIDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GCDGAHMIDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2C96470", Offset = "0x2C95470", VA = "0x182C96470")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class MPEGGAHAAJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MPEGGAHAAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F6B0", Offset = "0x2C9E6B0", VA = "0x182C9F6B0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class FPLMLBBOFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FPLMLBBOFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2C96410", Offset = "0x2C95410", VA = "0x182C96410")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly Dictionary<Guid, NGMPALOKIPD> KGBAFKGOBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly TimeSpan PPHCJEFMJHG;

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "10")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2655F10", Offset = "0x2654F10", VA = "0x182655F10", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x26559D0", Offset = "0x26549D0", VA = "0x1826559D0", Slot = "4")]
	public GONGPCOEAHB CEMPCIEDPMO(Guid IBJDBAKNBNO)
	{
		return default(GONGPCOEAHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2655750", Offset = "0x2654750", VA = "0x182655750", Slot = "5")]
	public bool ADDEDGCCJIP(Guid IBJDBAKNBNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2656570", Offset = "0x2655570", VA = "0x182656570", Slot = "8")]
	public bool MHCPGDEAOOD(Guid IBJDBAKNBNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2655F20", Offset = "0x2654F20", VA = "0x182655F20", Slot = "6")]
	public bool HBBKIAOAPCD(Guid IBJDBAKNBNO, Task DIJCFDEMACO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2655C50", Offset = "0x2654C50", VA = "0x182655C50", Slot = "7")]
	public bool DMHIKFBGFJN(Guid IBJDBAKNBNO, ODHGHEGHGCB NOIHJFNCIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2655EA0", Offset = "0x2654EA0", VA = "0x182655EA0", Slot = "9")]
	public Task<(ODHGHEGHGCB, Task)> DPAAKFMPIIE(Guid IBJDBAKNBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x26562E0", Offset = "0x26552E0", VA = "0x1826562E0")]
	private void JBHENGPMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x26567C0", Offset = "0x26557C0", VA = "0x1826567C0")]
	public AJHOCKCHCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[Preserve]
internal class PHBJLCOPOHD : IKBEIDBGMGK, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class BOPKFNLMHBK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly APDOMGKMKFG KMHCHOEHAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly CancellationTokenSource NLJGOGNMNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public readonly CancellationToken JPHFDAIIPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private bool LDMFGOJKEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private bool GPOGJJAECEL;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x42AC0A0", Offset = "0x42AB0A0", VA = "0x1842AC0A0")]
		public BOPKFNLMHBK(APDOMGKMKFG KMHCHOEHAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x42ABF50", Offset = "0x42AAF50", VA = "0x1842ABF50")]
		public void MHCPGDEAOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x42ABF20", Offset = "0x42AAF20", VA = "0x1842ABF20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KCMOBNIDHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public GJLEJDIOIJF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KCMOBNIDHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x42B0730", Offset = "0x42AF730", VA = "0x1842B0730")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct OCFJELKPPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public GJLEJDIOIJF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public PHBJLCOPOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x42B49C0", Offset = "0x42B39C0", VA = "0x1842B49C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class PFHKEKCNABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PFHKEKCNABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x42B7360", Offset = "0x42B6360", VA = "0x1842B7360")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct MGFLJOCBGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public PHBJLCOPOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x42B36C0", Offset = "0x42B26C0", VA = "0x1842B36C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x653AD0", Offset = "0x652AD0", VA = "0x180653AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class ANNBKDAADNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public APDOMGKMKFG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ANNBKDAADNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x42AB2D0", Offset = "0x42AA2D0", VA = "0x1842AB2D0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x42AB370", Offset = "0x42AA370", VA = "0x1842AB370")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x42AB3B0", Offset = "0x42AA3B0", VA = "0x1842AB3B0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class IDGPPALMJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IDGPPALMJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x42AEED0", Offset = "0x42ADED0", VA = "0x1842AEED0")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct MFLAEGMNPHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public APDOMGKMKFG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public PHBJLCOPOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private ANNBKDAADNO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x42B2980", Offset = "0x42B1980", VA = "0x1842B2980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private NPJEBNJGELF DGAJKPEIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private ANGLDKLCNIL JJJEGDCOGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private LMPCEFKGPKI LEPJIGHFGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private AAJPBPBNKKA NNDEMEJOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private long FDBFHMGHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private BOPKFNLMHBK FMMMPKMPOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private bool HPJFHCKIECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Task EGBGMAMIOPD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9B40", Offset = "0x2CA8B40", VA = "0x182CA9B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool HLIBMCFPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9E5540", Offset = "0x9E4540", VA = "0x1809E5540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CA93A0", Offset = "0x2CA83A0", VA = "0x182CA93A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8E40", Offset = "0x2CA7E40", VA = "0x182CA8E40", Slot = "4")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2CA90F0", Offset = "0x2CA80F0", VA = "0x182CA90F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8D20", Offset = "0x2CA7D20", VA = "0x182CA8D20")]
	[AsyncStateMachine(typeof(OCFJELKPPOK))]
	private Task BMHOAICPKJO(GJLEJDIOIJF AEBFBNEANDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2CA98B0", Offset = "0x2CA88B0", VA = "0x182CA98B0")]
	private void NCIJLLJFKFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9FC0", Offset = "0x2CA8FC0", VA = "0x182CA9FC0")]
	private void PKDDEMGFBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA96B0", Offset = "0x2CA86B0", VA = "0x182CA96B0")]
	private void MABCMFNJKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9AC0", Offset = "0x2CA8AC0", VA = "0x182CA9AC0")]
	private bool NJKDHLCIDEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9B90", Offset = "0x2CA8B90", VA = "0x182CA9B90")]
	[AsyncStateMachine(typeof(MGFLJOCBGBB))]
	private void OIOIGPAIHDI(int GDOGDBJHLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9C80", Offset = "0x2CA8C80", VA = "0x182CA9C80")]
	private void OPEICCPCDKG(out IDisposable BPJIDAHBGLO, out IDisposable OLHNCDFEBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9530", Offset = "0x2CA8530", VA = "0x182CA9530")]
	private bool KBEJMCLMNMP(APDOMGKMKFG KMHCHOEHAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9480", Offset = "0x2CA8480", VA = "0x182CA9480")]
	private void HLHFHLENGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9270", Offset = "0x2CA8270", VA = "0x182CA9270")]
	[AsyncStateMachine(typeof(MFLAEGMNPHP))]
	private Task EFCGMJDALGE(APDOMGKMKFG KMHCHOEHAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA1D0", Offset = "0x2CA91D0", VA = "0x182CAA1D0")]
	public PHBJLCOPOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Preserve]
internal sealed class NIPLMADBAHH : ANOHCFDFHDC, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct HADCLOCIKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder<INKLMCGIFMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NIPLMADBAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter<INKLMCGIFMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x42AD430", Offset = "0x42AC430", VA = "0x1842AD430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x42AD680", Offset = "0x42AC680", VA = "0x1842AD680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BPBLBJFGBBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public JKIDPKPPPFG message;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BPBLBJFGBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x42AC150", Offset = "0x42AB150", VA = "0x1842AC150")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class CKEGOHBJHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public JKIDPKPPPFG messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CKEGOHBJHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x42AC430", Offset = "0x42AB430", VA = "0x1842AC430")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class AIOHMDEHFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public AIOHMDEHFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x42AAD10", Offset = "0x42A9D10", VA = "0x1842AAD10")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct JELJNIGBOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public NIPLMADBAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<FEBBGJAEJGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x42AF880", Offset = "0x42AE880", VA = "0x1842AF880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PBJDAFLJHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public JKIDPKPPPFG operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PBJDAFLJHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x42B6E70", Offset = "0x42B5E70", VA = "0x1842B6E70")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct DELEGNKIDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public JKIDPKPPPFG operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public NIPLMADBAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private OHPHHOAEIIK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x42AC7F0", Offset = "0x42AB7F0", VA = "0x1842AC7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct LJFPNAOFMEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder<FEBBGJAEJGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public NIPLMADBAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private OHPHHOAEIIK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x42B1020", Offset = "0x42B0020", VA = "0x1842B1020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x42B1470", Offset = "0x42B0470", VA = "0x1842B1470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OAGPKOPACJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public FEBBGJAEJGA operation;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OAGPKOPACJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x42B4710", Offset = "0x42B3710", VA = "0x1842B4710")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct HLACGDHJJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public FEBBGJAEJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NIPLMADBAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private global::BJNCMLEHIAG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x42AE2B0", Offset = "0x42AD2B0", VA = "0x1842AE2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class PLBDOGGNCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PLBDOGGNCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x42B73D0", Offset = "0x42B63D0", VA = "0x1842B73D0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class HLBHFIGIOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HLBHFIGIOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x42AE7F0", Offset = "0x42AD7F0", VA = "0x1842AE7F0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private FPKFEENENKO CEJBKJKONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private BPBOEKMGJMK MCNCKAAHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private EPCKILAPKNE DHMACOGKGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private TaskCompletionSource<INKLMCGIFMP> DCFFFBIOINL;

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2DA0", Offset = "0x2CA1DA0", VA = "0x182CA2DA0", Slot = "7")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2E80", Offset = "0x2CA1E80", VA = "0x182CA2E80", Slot = "6")]
	[AsyncStateMachine(typeof(HADCLOCIKPE))]
	public Task<INKLMCGIFMP> DFKMPGDELJB(CancellationToken PDGIHFLJMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA34A0", Offset = "0x2CA24A0", VA = "0x182CA34A0", Slot = "4")]
	public void GJBCONLFFAK(JKIDPKPPPFG NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2920", Offset = "0x2CA1920", VA = "0x182CA2920", Slot = "5")]
	public void BDNFKCHNGCG(JKIDPKPPPFG BMHNOPILOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2CA27F0", Offset = "0x2CA17F0", VA = "0x182CA27F0")]
	[AsyncStateMachine(typeof(JELJNIGBOBK))]
	private Task BDLEJJLPIOA(JKIDPKPPPFG ANHHADJHMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3BA0", Offset = "0x2CA2BA0", VA = "0x182CA3BA0")]
	[AsyncStateMachine(typeof(DELEGNKIDCM))]
	private Task KPDKKPPOADE(JKIDPKPPPFG IKPIAMACHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3CD0", Offset = "0x2CA2CD0", VA = "0x182CA3CD0")]
	[AsyncStateMachine(typeof(LJFPNAOFMEA))]
	private Task<FEBBGJAEJGA> POGOKJOIDGO(JKIDPKPPPFG ANHHADJHMBE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2D20", Offset = "0x2CA1D20", VA = "0x182CA2D20")]
	private OHPHHOAEIIK BOIMAOFKBLE(JKIDPKPPPFG DDAIPOAIAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3370", Offset = "0x2CA2370", VA = "0x182CA3370")]
	[AsyncStateMachine(typeof(HLACGDHJJHH))]
	private Task ENABPJKHHMJ(FEBBGJAEJGA OKAMDGKEFCC, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA38D0", Offset = "0x2CA28D0", VA = "0x182CA38D0")]
	private FEBBGJAEJGA IAJLAOHDKGO(JKIDPKPPPFG ANHHADJHMBE, OHPHHOAEIIK CDJJOGCLELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x33C43B0", Offset = "0x33C33B0", VA = "0x1833C43B0")]
	private T LKNIDLIFFJE<T>(T CCIMHDCKHOF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2FC0", Offset = "0x2CA1FC0", VA = "0x182CA2FC0")]
	private FEBBGJAEJGA EAAAECNAKKG(JKIDPKPPPFG ANHHADJHMBE, OHPHHOAEIIK CDJJOGCLELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public NIPLMADBAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3B50", Offset = "0x2CA2B50", VA = "0x182CA3B50")]
	[CompilerGenerated]
	private void KLPJMAKLEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[Preserve]
internal sealed class HFFNBMHCBNA : BPBOEKMGJMK, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class KEBLMLJNLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KEBLMLJNLPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x35D1040", Offset = "0x35D0040", VA = "0x1835D1040")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ILCKDNELMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ILCKDNELMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x35CF8A0", Offset = "0x35CE8A0", VA = "0x1835CF8A0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private DJDJIIDPFGC DJEOMGBJAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private ANOHCFDFHDC LHGBHJIHNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private AACEJKINIDC KGBAFKGOBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private KKCDDKGBHII POLGNBGFCNI;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x266BA30", Offset = "0x266AA30", VA = "0x18266BA30", Slot = "6")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x266C3B0", Offset = "0x266B3B0", VA = "0x18266C3B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x266C750", Offset = "0x266B750", VA = "0x18266C750", Slot = "4")]
	public GONGPCOEAHB HGPCANPJDFB(GJONLHCLILK ANHHADJHMBE)
	{
		return default(GONGPCOEAHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x266D5A0", Offset = "0x266C5A0", VA = "0x18266D5A0", Slot = "5")]
	public void JPLHKNJNIIA(Guid IBJDBAKNBNO, Task DIJCFDEMACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x266B960", Offset = "0x266A960", VA = "0x18266B960")]
	private void CBOHALOBCFB(byte GGMHJDKPIFO, int BMOJJBEGBCD, object CFHPDIPNEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x266B1F0", Offset = "0x266A1F0", VA = "0x18266B1F0")]
	private void BPFKIADKNEI(GGPGKCOEDFH DPDIKACMHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x266D2C0", Offset = "0x266C2C0", VA = "0x18266D2C0")]
	private void JLLCBIGMIJH(GGPGKCOEDFH DPDIKACMHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x266BBA0", Offset = "0x266ABA0", VA = "0x18266BBA0")]
	private void CJECCMMHIIE(GGPGKCOEDFH DPDIKACMHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x266C110", Offset = "0x266B110", VA = "0x18266C110")]
	private ODHGHEGHGCB DMOKNDLHLEA(JKIDPKPPPFG DDAIPOAIAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x266BEC0", Offset = "0x266AEC0", VA = "0x18266BEC0")]
	private void DHOPBGGKCMG(JKIDPKPPPFG IKPIAMACHGL, ODHGHEGHGCB NOIHJFNCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x266CFC0", Offset = "0x266BFC0", VA = "0x18266CFC0")]
	private bool JIONKGDHMIF(JKIDPKPPPFG IKPIAMACHGL, ODHGHEGHGCB NOIHJFNCIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x266CCF0", Offset = "0x266BCF0", VA = "0x18266CCF0")]
	private bool HGPCANPJDFB(JKIDPKPPPFG AGMJBNAKFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x266C450", Offset = "0x266B450", VA = "0x18266C450")]
	private bool GAKOMLDFDKM(byte GGMHJDKPIFO, ExitGames.Client.Photon.Hashtable DPDIKACMHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HFFNBMHCBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Preserve]
internal sealed class CELJAEDCBAB : MIONDDMMAKC, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class HFBMELDGEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HFBMELDGEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2C978D0", Offset = "0x2C968D0", VA = "0x182C978D0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct AJHOPMJPAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CELJAEDCBAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public ODNOGOADEAI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public DIJEGIOFGFI detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<ODHGHEGHGCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2C90020", Offset = "0x2C8F020", VA = "0x182C90020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2C905B0", Offset = "0x2C8F5B0", VA = "0x182C905B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class EICGFDDGLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EICGFDDGLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2C95E40", Offset = "0x2C94E40", VA = "0x182C95E40")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DNMGAMAKCBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DNMGAMAKCBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2C95960", Offset = "0x2C94960", VA = "0x182C95960")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2C959D0", Offset = "0x2C949D0", VA = "0x182C959D0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2C95A40", Offset = "0x2C94A40", VA = "0x182C95A40")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct MGAIONEMAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CELJAEDCBAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public ODNOGOADEAI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public DIJEGIOFGFI detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private DNMGAMAKCBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private GONGPCOEAHB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private ODHGHEGHGCB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter<(ODHGHEGHGCB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E7E0", Offset = "0x2C9D7E0", VA = "0x182C9E7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EF10", Offset = "0x2C9DF10", VA = "0x182C9EF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class ODAEJDPENBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public INKLMCGIFMP operationType;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ODAEJDPENBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7890", Offset = "0x2CA6890", VA = "0x182CA7890")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private FGOAJCHMBDH HPPHBGMILJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private DJDJIIDPFGC DJEOMGBJAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private BPBOEKMGJMK MCNCKAAHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x265D730", Offset = "0x265C730", VA = "0x18265D730", Slot = "5")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x265E0C0", Offset = "0x265D0C0", VA = "0x18265E0C0", Slot = "4")]
	[AsyncStateMachine(typeof(AJHOPMJPAKD))]
	public Task<ODHGHEGHGCB> INBIIBMJHGG(ODNOGOADEAI FFLNBEOJALG, INKLMCGIFMP IFJGKJDPPKE, [CanBeNull] DIJEGIOFGFI JAPPKAPOAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x265DE60", Offset = "0x265CE60", VA = "0x18265DE60")]
	private bool INAGNGFKHHF(INKLMCGIFMP IFJGKJDPPKE, out ODHGHEGHGCB BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x265D830", Offset = "0x265C830", VA = "0x18265D830")]
	[AsyncStateMachine(typeof(MGAIONEMAHN))]
	private Task<ODHGHEGHGCB> DLHMOGDANPK(ODNOGOADEAI FFLNBEOJALG, INKLMCGIFMP IFJGKJDPPKE, [CanBeNull] DIJEGIOFGFI JAPPKAPOAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x265D9A0", Offset = "0x265C9A0", VA = "0x18265D9A0")]
	internal GJONLHCLILK FJGNNFJHPCJ(ODNOGOADEAI FFLNBEOJALG, INKLMCGIFMP IFJGKJDPPKE, [CanBeNull] DIJEGIOFGFI JAPPKAPOAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CELJAEDCBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Preserve]
internal sealed class GCHFMBEPFBA : FGOAJCHMBDH, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct BEIBOBJCEIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<CAOKGENDBMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public GCHFMBEPFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<DIJEGIOFGFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x35C5760", Offset = "0x35C4760", VA = "0x1835C5760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x35C5940", Offset = "0x35C4940", VA = "0x1835C5940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MEOKFHPIMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MEOKFHPIMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x35D49E0", Offset = "0x35D39E0", VA = "0x1835D49E0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct CHAJJHDFPAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public AsyncTaskMethodBuilder<DIJEGIOFGFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public GCHFMBEPFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public APDOMGKMKFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private MEOKFHPIMHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<FGCGCNLHLOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x35C7C10", Offset = "0x35C6C10", VA = "0x1835C7C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x35C7FD0", Offset = "0x35C6FD0", VA = "0x1835C7FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class OCOFAGMDGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OCOFAGMDGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x11048B0", Offset = "0x11038B0", VA = "0x1811048B0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(MPGLODPOCPP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private ECPCGLHGMDH NOPDLOGLDFN;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly (NLKLCIGNEIJ superRoomData, string unityAssetId, NLKLCIGNEIJ subRoomData) CMLEGIMCDEM;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2666E60", Offset = "0x2665E60", VA = "0x182666E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x26663A0", Offset = "0x26653A0", VA = "0x1826663A0", Slot = "8")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2666430", Offset = "0x2665430", VA = "0x182666430", Slot = "4")]
	[AsyncStateMachine(typeof(BEIBOBJCEIO))]
	public Task<CAOKGENDBMG> DOHBEHNMLEG(HKLBBGEFPMO NMGDNGMBHAG, APDOMGKMKFG CILBKNNEHGI, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2666CE0", Offset = "0x2665CE0", VA = "0x182666CE0")]
	[AsyncStateMachine(typeof(CHAJJHDFPAK))]
	public Task<DIJEGIOFGFI> MPMHGNAKBKB(APDOMGKMKFG CILBKNNEHGI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2666880", Offset = "0x2665880", VA = "0x182666880", Slot = "5")]
	public CAOKGENDBMG HACLHDADHAM(APDOMGKMKFG CILBKNNEHGI, DIJEGIOFGFI FBMEDFJHKDJ, long HKIDJEFCIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2666BD0", Offset = "0x2665BD0", VA = "0x182666BD0", Slot = "6")]
	public CAOKGENDBMG HJCBFBAPGIP(APDOMGKMKFG CILBKNNEHGI, HNOFBHJLOMI GMGAKMOLDCA, long HKIDJEFCIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2666780", Offset = "0x2665780", VA = "0x182666780", Slot = "7")]
	public CAOKGENDBMG GHDKAPIPINN(long KOPNDIHPOPK, long HKIDJEFCIOJ, string BLHPGIMDEGL, string OJLDLNLLPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x26665B0", Offset = "0x26655B0", VA = "0x1826665B0")]
	private static CAOKGENDBMG EDAOJPKIEAG(long KOPNDIHPOPK, long HKIDJEFCIOJ, NLKLCIGNEIJ FDJGLNKJAAA, string BLHPGIMDEGL, NLKLCIGNEIJ DPFMLJHHCKP, string OJLDLNLLPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2665FF0", Offset = "0x2664FF0", VA = "0x182665FF0")]
	private (NLKLCIGNEIJ, string, NLKLCIGNEIJ) BLPAMFLGGNF(APDOMGKMKFG CILBKNNEHGI, DIJEGIOFGFI FBMEDFJHKDJ, long HKIDJEFCIOJ)
	{
		return default((NLKLCIGNEIJ, string, NLKLCIGNEIJ));
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GCHFMBEPFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[Preserve]
internal sealed class NECKMIOILEH : EPCKILAPKNE, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class NKIMLBGBILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NKIMLBGBILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x42B46B0", Offset = "0x42B36B0", VA = "0x1842B46B0")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct MBKEEMANMLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public NECKMIOILEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public OHPHHOAEIIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x42B1EE0", Offset = "0x42B0EE0", VA = "0x1842B1EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x42B2340", Offset = "0x42B1340", VA = "0x1842B2340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct BBEFMEGPEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NECKMIOILEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public OHPHHOAEIIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x42AB3F0", Offset = "0x42AA3F0", VA = "0x1842AB3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x42AB9C0", Offset = "0x42AA9C0", VA = "0x1842AB9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HBOAGEHKBIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HBOAGEHKBIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x42AD6D0", Offset = "0x42AC6D0", VA = "0x1842AD6D0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct HCJMNBAKCKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public JKIDPKPPPFG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NECKMIOILEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public OHPHHOAEIIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private PFOPODEDLKI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private MGADGGGHNNB <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x42AD730", Offset = "0x42AC730", VA = "0x1842AD730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x42AE1D0", Offset = "0x42AD1D0", VA = "0x1842AE1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private PGIPFOJCNHM FKAIEPNBMEL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private DEBBKGCKOLK IMPOHOMIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0340", Offset = "0x2C9F340", VA = "0x182CA0340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FE80", Offset = "0x2C9EE80", VA = "0x182C9FE80", Slot = "8")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0690", Offset = "0x2C9F690", VA = "0x182CA0690", Slot = "4")]
	[AsyncStateMachine(typeof(MBKEEMANMLB))]
	public Task<JKIDPKPPPFG> PBKFGNLIABC(JKIDPKPPPFG ANHHADJHMBE, OHPHHOAEIIK CDJJOGCLELP, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0060", Offset = "0x2C9F060", VA = "0x182CA0060", Slot = "5")]
	[AsyncStateMachine(typeof(BBEFMEGPEMI))]
	public Task<JKIDPKPPPFG> ICIMKMEKEBO(CancellationToken OHJGLBPIBBN, OHPHHOAEIIK CDJJOGCLELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0400", Offset = "0x2C9F400", VA = "0x182CA0400", Slot = "6")]
	public NNICOEAPHFK OAFIPMNEMGH(FEBBGJAEJGA JKLNOJJNNIK, HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0800", Offset = "0x2C9F800", VA = "0x182CA0800", Slot = "7")]
	public NNICOEAPHFK PMCOJNCPDAF(FEBBGJAEJGA JKLNOJJNNIK, HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA01C0", Offset = "0x2C9F1C0", VA = "0x182CA01C0")]
	[AsyncStateMachine(typeof(HCJMNBAKCKD))]
	private Task<JKIDPKPPPFG> JBEKFJHMBIK(JKIDPKPPPFG ANHHADJHMBE, OHPHHOAEIIK CDJJOGCLELP, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA03F0", Offset = "0x2C9F3F0", VA = "0x182CA03F0")]
	private static byte[] MPCDECNPELF(JKIDPKPPPFG NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FF10", Offset = "0x2C9EF10", VA = "0x182C9FF10")]
	private static string EHFFLFANOGN(byte[] GFEODCCFHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public NECKMIOILEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[Preserve]
internal sealed class ADKFHOAEBDE : DJDJIIDPFGC, GGDBKLMDLIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private AJIMEGCKBBC BCIIFCABENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private FPKFEENENKO CEJBKJKONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private OJGLOFJPEPP LCALLBKICCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private AAJPBPBNKKA NNDEMEJOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private DMJOFNEHOAE IIPBIIDNJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private LMPCEFKGPKI LEPJIGHFGOA;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2654D10", Offset = "0x2653D10", VA = "0x182654D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private static ODHGHEGHGCB FJKEMABFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2654D00", Offset = "0x2653D00", VA = "0x182654D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2654520", Offset = "0x2653520", VA = "0x182654520", Slot = "7")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2654680", Offset = "0x2653680", VA = "0x182654680", Slot = "4")]
	public ODHGHEGHGCB DLBIABBDFFD(ODNOGOADEAI EKAJODGDHNG, INKLMCGIFMP JMJPFKPCGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2654A60", Offset = "0x2653A60", VA = "0x182654A60", Slot = "5")]
	public ODHGHEGHGCB LMBLCDIFCDE(ODNOGOADEAI DAGJCDCAJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2654810", Offset = "0x2653810", VA = "0x182654810", Slot = "6")]
	public ODHGHEGHGCB IMHHBPFDNKI(ODNOGOADEAI DAGJCDCAJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2654A50", Offset = "0x2653A50", VA = "0x182654A50")]
	private static ODHGHEGHGCB JLFOMIMJFHI(CJBJIFDGJEE OGOCJGMDPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public ADKFHOAEBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class MKLAKCJIILE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F170", Offset = "0x2C9E170", VA = "0x182C9F170")]
	public MKLAKCJIILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xD02140", Offset = "0xD01140", VA = "0x180D02140")]
	public MKLAKCJIILE(string NJAIIGFCHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[Preserve]
internal sealed class KIEDCEHKLOP : BJGELKDEMLP, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct ELCADNKFNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<ODHGHEGHGCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public EHINBDMEHCH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private global::BJNCMLEHIAG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private HKLBBGEFPMO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private HKLBBGEFPMO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<ODHGHEGHGCB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x35C9BD0", Offset = "0x35C8BD0", VA = "0x1835C9BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x35CA1A0", Offset = "0x35C91A0", VA = "0x1835CA1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct GJGKKMPPDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x35CD470", Offset = "0x35CC470", VA = "0x1835CD470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct LGNNMNPJJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x42B0A70", Offset = "0x42AFA70", VA = "0x1842B0A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct MOKAEBDPMNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x42B4210", Offset = "0x42B3210", VA = "0x1842B4210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct ONHPHJLOEMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x42B6740", Offset = "0x42B5740", VA = "0x1842B6740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct OFNNBPKOOHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public KIEDCEHKLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public PEAHMKADPMI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private global::BJNCMLEHIAG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x42B52E0", Offset = "0x42B42E0", VA = "0x1842B52E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static readonly TimeSpan NNIJAHOCDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private EPCKILAPKNE DHMACOGKGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private FPKFEENENKO CEJBKJKONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private DMJOFNEHOAE IIPBIIDNJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private CancellationTokenSource EBBBEHEPMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private Task OOLHPGFNOJI;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2674E90", Offset = "0x2673E90", VA = "0x182674E90", Slot = "6")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1180250", Offset = "0x117F250", VA = "0x181180250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2675050", Offset = "0x2674050", VA = "0x182675050", Slot = "4")]
	[AsyncStateMachine(typeof(ELCADNKFNHG))]
	public Task<ODHGHEGHGCB> GKEJIADLANM(EHINBDMEHCH JHJBCECDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x26752B0", Offset = "0x26742B0", VA = "0x1826752B0", Slot = "5")]
	[AsyncStateMachine(typeof(GJGKKMPPDAI))]
	public Task JMNCHFFEGCE([Optional] CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1180250", Offset = "0x117F250", VA = "0x181180250")]
	public void KFLPKAPGKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26753D0", Offset = "0x26743D0", VA = "0x1826753D0")]
	private CNHBHNANCGB KLOHOKMLCLB(EHINBDMEHCH JHJBCECDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2675680", Offset = "0x2674680", VA = "0x182675680")]
	[AsyncStateMachine(typeof(LGNNMNPJJFA))]
	private Task OEIHCFAPDIJ(CEBPIIBHMDD NJKKDANCIMG, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2675190", Offset = "0x2674190", VA = "0x182675190")]
	[AsyncStateMachine(typeof(MOKAEBDPMNA))]
	private Task HDMHNBNFPDD([Optional] CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2674D60", Offset = "0x2673D60", VA = "0x182674D60")]
	[AsyncStateMachine(typeof(ONHPHJLOEMF))]
	private Task BENMDCCFNBH(TimeSpan EBLNGPLPCLM, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x26757B0", Offset = "0x26747B0", VA = "0x1826757B0")]
	private Task PCOGALMMIME(PEAHMKADPMI KMCOHECJCLH, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2675A20", Offset = "0x2674A20", VA = "0x182675A20")]
	[AsyncStateMachine(typeof(OFNNBPKOOHN))]
	private Task PHHGHENAHJD(PEAHMKADPMI KMCOHECJCLH, CancellationToken PJNOBOOMKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2674C50", Offset = "0x2673C50", VA = "0x182674C50")]
	private bool AJGFBBGFEPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public KIEDCEHKLOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[Preserve]
internal class KNDJNNBIGOP : OJGLOFJPEPP, GGDBKLMDLIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JGBMBLPIBAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public KNDJNNBIGOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private global::BJNCMLEHIAG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x42AFEC0", Offset = "0x42AEEC0", VA = "0x1842AFEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private KFMPBCNDGGB BNGBGHDDGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private DJDJIIDPFGC DJEOMGBJAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private EPCKILAPKNE DHMACOGKGOK;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2675C20", Offset = "0x2674C20", VA = "0x182675C20", Slot = "6")]
	public void CDFKCHBFAME(CDJBHBCLHCD MEFFMNONBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2675E40", Offset = "0x2674E40", VA = "0x182675E40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2675E90", Offset = "0x2674E90", VA = "0x182675E90", Slot = "5")]
	[AsyncStateMachine(typeof(JGBMBLPIBAK))]
	public Task LDCBOLAEFLO(string OIPMKBNDJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2675BC0", Offset = "0x2674BC0", VA = "0x182675BC0", Slot = "4")]
	public ODHGHEGHGCB AJGFBBGFEPB(ODNOGOADEAI EKAJODGDHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2675FB0", Offset = "0x2674FB0", VA = "0x182675FB0")]
	private HBBHFOALEGK LECIFMHMBAJ(string OIPMKBNDJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public KNDJNNBIGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class NHNAJPFEDCK
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2630", Offset = "0x2CA1630", VA = "0x182CA2630")]
	public static void KINFJLJAMJD(PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2470", Offset = "0x2CA1470", VA = "0x182CA2470")]
	internal static void BBADLJPBIPC(PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2550", Offset = "0x2CA1550", VA = "0x182CA2550")]
	internal static void KIECMBDENJL(PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2020", Offset = "0x2CA1020", VA = "0x182CA2020")]
	internal static void AGJHONMDOCF(PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class FAGCPHELKHC : global::FAMACMKFGLF<JKIDPKPPPFG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class BBJEIHJIIHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JKIDPKPPPFG message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BBJEIHJIIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2C917F0", Offset = "0x2C907F0", VA = "0x182C917F0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly FAGCPHELKHC KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private const string GDLCDFFHNAC = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2662B90", Offset = "0x2661B90", VA = "0x182662B90")]
	public ExitGames.Client.Photon.Hashtable HHDOHEHKDKI(JKIDPKPPPFG NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2662A50", Offset = "0x2661A50", VA = "0x182662A50", Slot = "5")]
	protected override void BOEHPCBKFHF(JKIDPKPPPFG NJAIIGFCHNG, IDictionary<object, object> PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2662680", Offset = "0x2661680", VA = "0x182662680", Slot = "6")]
	public override JKIDPKPPPFG ADHMOLAJGDE(IDictionary<object, object> PJDKPCLOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x26628D0", Offset = "0x26618D0", VA = "0x1826628D0")]
	private static void AMJBGJGBGPP(string GKBNIMHPHCI, JKIDPKPPPFG NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2662FE0", Offset = "0x2661FE0", VA = "0x182662FE0")]
	public FAGCPHELKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2662C10", Offset = "0x2661C10", VA = "0x182662C10")]
	[CompilerGenerated]
	internal static string IAHDNBAALIH(CAOKGENDBMG PLNNMJAODIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class LOFMHHEFKKP
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public static ODHGHEGHGCB FJKEMABFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D6C0", Offset = "0x2C9C6C0", VA = "0x182C9D6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D630", Offset = "0x2C9C630", VA = "0x182C9D630")]
	public static bool HKCILKLIBJH(this ODHGHEGHGCB NOIHJFNCIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D660", Offset = "0x2C9C660", VA = "0x182C9D660")]
	public static ODHGHEGHGCB JLFOMIMJFHI(CJBJIFDGJEE DGGFKMKCEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D650", Offset = "0x2C9C650", VA = "0x182C9D650")]
	public static ODHGHEGHGCB HNALKLNGDPJ(params ODHGHEGHGCB[] MKDHCHPLNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D430", Offset = "0x2C9C430", VA = "0x182C9D430")]
	public static ODHGHEGHGCB ENKGBPCEALM(IEnumerable<ODHGHEGHGCB> MKDHCHPLNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D720", Offset = "0x2C9C720", VA = "0x182C9D720")]
	public static string PFPJPFKGCMM(this ODHGHEGHGCB BBELMPNHPOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public abstract class EELOPAPIKAM : DJCHLLCLNPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public delegate ODHGHEGHGCB HKFIEGCHJPA([NotNull] ODNOGOADEAI DDKPFEGJFHA);

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class LEAKGOJPHIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public ODNOGOADEAI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LEAKGOJPHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C530", Offset = "0x2C9B530", VA = "0x182C9C530")]
		internal ODHGHEGHGCB <Validate>b__0(HKFIEGCHJPA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	protected readonly HashSet<HKFIEGCHJPA> BBLCKGKJKJG;

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2660FE0", Offset = "0x265FFE0", VA = "0x182660FE0", Slot = "4")]
	public void OPKOPOIFGGE(HKFIEGCHJPA CEKHEBPFIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2660F80", Offset = "0x265FF80", VA = "0x182660F80", Slot = "5")]
	public void MNCCBPAEEPL(HKFIEGCHJPA CEKHEBPFIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2660F30", Offset = "0x265FF30", VA = "0x182660F30", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2660D10", Offset = "0x265FD10", VA = "0x182660D10")]
	protected ODHGHEGHGCB CADPKKPKKJO(ODNOGOADEAI DAGJCDCAJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x265C640", Offset = "0x265B640", VA = "0x18265C640")]
	protected EELOPAPIKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class NMBEHNJGNMP : EELOPAPIKAM, AJIMEGCKBBC, DJCHLLCLNPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class LHIKCAGKKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public ODHGHEGHGCB result;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LHIKCAGKKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x42B0FC0", Offset = "0x42AFFC0", VA = "0x1842B0FC0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4B80", Offset = "0x2CA3B80", VA = "0x182CA4B80")]
	[Preserve]
	public NMBEHNJGNMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4A00", Offset = "0x2CA3A00", VA = "0x182CA4A00", Slot = "8")]
	public ODHGHEGHGCB GJGGIPEABNE(ODNOGOADEAI DAGJCDCAJFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class BPJOIDAEOCM : EELOPAPIKAM, KFMPBCNDGGB, DJCHLLCLNPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class IOOFNBMPFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public ODHGHEGHGCB result;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IOOFNBMPFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2C99B90", Offset = "0x2C98B90", VA = "0x182C99B90")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x265C640", Offset = "0x265B640", VA = "0x18265C640")]
	[Preserve]
	public BPJOIDAEOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x265C4C0", Offset = "0x265B4C0", VA = "0x18265C4C0", Slot = "8")]
	public ODHGHEGHGCB AJGFBBGFEPB(ODNOGOADEAI NLCFFNAAEHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum HPDLOCNANFC
{
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class ADPCPCIAMHB
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class BEJGEFKOGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public global::BJNCMLEHIAG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BEJGEFKOGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C91E60", Offset = "0x2C90E60", VA = "0x182C91E60")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public const string EENOLAGJEIE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public const string PMHFGDFEHGJ = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2655030", Offset = "0x2654030", VA = "0x182655030")]
	public static global::BJNCMLEHIAG<string> NHACICBAJAH([Optional] string KCHKKMCHFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2654E20", Offset = "0x2653E20", VA = "0x182654E20")]
	private static void MFODPLPOBGO(string AGPLDPOAAIC, LNPAECEJEGM MDGABGKAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2654F30", Offset = "0x2653F30", VA = "0x182654F30")]
	private static void NDLANEAMGGN(string AGPLDPOAAIC, LNPAECEJEGM MDGABGKAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2655100", Offset = "0x2654100", VA = "0x182655100")]
	public static void OIDOKMJCCFJ(global::BJNCMLEHIAG<string> MDGABGKAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2654D60", Offset = "0x2653D60", VA = "0x182654D60")]
	public static string GNECIOPHOIN(JKIDPKPPPFG DDAIPOAIAJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class MNHEMEBNPBB
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F580", Offset = "0x2C9E580", VA = "0x182C9F580")]
	public static void EPNLDDLNKPL(this LHBHABEPLIM FMJNCAAMIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F590", Offset = "0x2C9E590", VA = "0x182C9F590")]
	public static void LMOBNCNHOGP(this LHBHABEPLIM FMJNCAAMIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F5A0", Offset = "0x2C9E5A0", VA = "0x182C9F5A0")]
	private static void PJMKOEEEFIM(this LHBHABEPLIM FMJNCAAMIPB, bool FOGPKCOCKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class BNBJNGAJFCN : FFCBBGPGJAC, BEJFDGEIIJB, IHCGNEMANOG, EGHJOOMBDDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly BEJFDGEIIJB DDPDPJPFINN;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public ODNOGOADEAI NCGONMNFDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x265C240", Offset = "0x265B240", VA = "0x18265C240", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int LABJJKIKHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x265C3D0", Offset = "0x265B3D0", VA = "0x18265C3D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int DDOMACGJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x265BFD0", Offset = "0x265AFD0", VA = "0x18265BFD0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DKPHAJAICCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public int AMCHKHPADAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event INIMCJMPGMD.FKPOBLJOCCH KLOJIEJKMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event POHIAFKPALN FMEOEDHCMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x265C330", Offset = "0x265B330", VA = "0x18265C330", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x265C1A0", Offset = "0x265B1A0", VA = "0x18265C1A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<bool> NANLFPDFOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<ODNOGOADEAI> AMPCLPPIHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action BDPENAJMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x265C420", Offset = "0x265B420", VA = "0x18265C420", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x265BED0", Offset = "0x265AED0", VA = "0x18265BED0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x81A2E0", Offset = "0x8192E0", VA = "0x18081A2E0")]
	public BNBJNGAJFCN(BEJFDGEIIJB DDPDPJPFINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x265C290", Offset = "0x265B290", VA = "0x18265C290", Slot = "8")]
	public bool GLAOMFGLKOC(byte GGMHJDKPIFO, ExitGames.Client.Photon.Hashtable LKFCEHBIPJF, DBIKEOAHPOD LKJEFAEMFOC, SendOptions FGCKIBAAHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x265C100", Offset = "0x265B100", VA = "0x18265C100", Slot = "29")]
	public ODNOGOADEAI ECOKGLBFMOO(int LMOBFJCPJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x265C020", Offset = "0x265B020", VA = "0x18265C020", Slot = "16")]
	public ODNOGOADEAI DOCENHKEBEC(int DNHODCCDDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "19")]
	public void JMDMKEPPNNO(object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "20")]
	public void ODGCLGCMKLE(object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "21")]
	public void LLOBLCKKCNM(object FDKCIGPLPAB, bool AHLKJDPDAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x265BF70", Offset = "0x265AF70", VA = "0x18265BF70", Slot = "22")]
	public IDisposable CHGOMOEKFEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "23")]
	private bool EIGFNJBCCOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "24")]
	public void CNHJEAMGGEJ(StringBuilder LMBGOCBPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x265BEB0", Offset = "0x265AEB0", VA = "0x18265BEB0", Slot = "25")]
	public bool AGLDNKGIHHI(bool GMCIALPOEGG, out string OJDKKCJFMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	public void BHGPFKPNFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x1733310", Offset = "0x1732310", VA = "0x181733310", Slot = "28")]
	public void PANGIIMDEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal struct GGPGKCOEDFH
{
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public const string MIIMJLBEALD = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public const string BJFNABBLPIF = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private readonly IDictionary<object, object> DPDIKACMHNE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x91CA20", Offset = "0x91BA20", VA = "0x18091CA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x87A620", Offset = "0x879620", VA = "0x18087A620")]
	public GGPGKCOEDFH(IDictionary<object, object> DPDIKACMHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2668300", Offset = "0x2667300", VA = "0x182668300")]
	public bool PECCAOEMPBI(out JKIDPKPPPFG NJAIIGFCHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2667FD0", Offset = "0x2666FD0", VA = "0x182667FD0")]
	public Guid HJHFJDBBPMG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x26681A0", Offset = "0x26671A0", VA = "0x1826681A0")]
	public ODHGHEGHGCB OEEJIAGOJEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x26680B0", Offset = "0x26670B0", VA = "0x1826680B0")]
	public static ExitGames.Client.Photon.Hashtable MFNJFAEBAIM(JKIDPKPPPFG NJAIIGFCHNG, ODHGHEGHGCB NOIHJFNCIFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class JFGMEOOJAPO
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2672AA0", Offset = "0x2671AA0", VA = "0x182672AA0")]
	public static string PLEOLEEMLDF(this APDOMGKMKFG LOEJLEDCOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2672A20", Offset = "0x2671A20", VA = "0x182672A20")]
	public static bool NLMKIDLBLIO(this APDOMGKMKFG LOEJLEDCOEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal struct ENKKGOGPPDJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct IOHEOLMFMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public ENKKGOGPPDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C999F0", Offset = "0x2C989F0", VA = "0x182C999F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private readonly Func<CancellationToken, List<Task>> GHNENHLCGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private readonly CancellationTokenSource NLJGOGNMNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private Task IIDIGDMKMIO;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2661EA0", Offset = "0x2660EA0", VA = "0x182661EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	internal Task AFGCJJCJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2661DD0", Offset = "0x2660DD0", VA = "0x182661DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2661ED0", Offset = "0x2660ED0", VA = "0x182661ED0")]
	public ENKKGOGPPDJ(Func<CancellationToken, List<Task>> GHNENHLCGGD, CancellationToken OHJGLBPIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2661CC0", Offset = "0x2660CC0", VA = "0x182661CC0")]
	[AsyncStateMachine(typeof(IOHEOLMFMIG))]
	public Task CKDBLDEGIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2661E50", Offset = "0x2660E50", VA = "0x182661E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public readonly struct MFJLILHPNBB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct AIFMIEHEOJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<global::OANJAMKPOEA<global::DBENDBIPDML<TData>, LNLCMCKKKGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public global::MFJLILHPNBB<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private HKLBBGEFPMO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<global::OANJAMKPOEA<byte[], LNLCMCKKKGI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x323C130", Offset = "0x323B130", VA = "0x18323C130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A907A0", Offset = "0x2A8F7A0", VA = "0x182A907A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly global::BCFJIOEINCO<TGetDataArg, TData> EGEILAHLDAM;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x87A620", Offset = "0x879620", VA = "0x18087A620")]
	internal MFJLILHPNBB(global::BCFJIOEINCO<TGetDataArg, TData> CFKGJGPDLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEFC0", Offset = "0x3BDDFC0", VA = "0x183BDEFC0")]
	[AsyncStateMachine(typeof(global::MFJLILHPNBB<, >.AIFMIEHEOJJ))]
	public Task<global::OANJAMKPOEA<global::DBENDBIPDML<TData>, LNLCMCKKKGI>> LCPLFDBPMME(TGetDataArg GFEODCCFHNP, string NNPLCLDLMCD, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class KFMCONKFHGF
{
	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6ED0", Offset = "0x1EB5ED0", VA = "0x181EB6ED0")]
	public static global::MFJLILHPNBB<TGetDataArg, TData> AKMEFLONJDG<TGetDataArg, TData>(global::BCFJIOEINCO<TGetDataArg, TData> CFKGJGPDLPN)
	{
		return default(global::MFJLILHPNBB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class NPPGBANJAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly KOKMFIHPBLP BIILBIALNEP;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private const string GILFGHIMDPO = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private const string JGKFNEEENII = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private const string EDOEAGNACDN = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private const string BDDEBIGHANN = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private const string DKBLHBOGKGC = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private string EAGCAJMMCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private long? LAJDNLGIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private long? LCLCPGMHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NCEFFCHHIAA MCFMBDGKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private long? PGDJGMMKKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private bool KNABBEJJKLB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string GBDPPNEBPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public long LDFLJGMLKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7700", Offset = "0x2CA6700", VA = "0x182CA7700")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public long ODAJPCHHECL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6DF0", Offset = "0x2CA5DF0", VA = "0x182CA6DF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NCEFFCHHIAA EHOCNJHFOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x697720", Offset = "0x696720", VA = "0x180697720")]
		get
		{
			return default(NCEFFCHHIAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7760", Offset = "0x2CA6760", VA = "0x182CA7760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public long DHODNGNFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6E50", Offset = "0x2CA5E50", VA = "0x182CA6E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7850", Offset = "0x2CA6850", VA = "0x182CA7850")]
	[Preserve]
	public NPPGBANJAMC([NBLPGINBDGI(null)] KOKMFIHPBLP BIILBIALNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2CA71A0", Offset = "0x2CA61A0", VA = "0x182CA71A0")]
	private void GCMNDNMNHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7350", Offset = "0x2CA6350", VA = "0x182CA7350")]
	public void IEHMOFDCCJM(long BDNAKAPNAFM, long HKIDJEFCIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6D00", Offset = "0x2CA5D00", VA = "0x182CA6D00")]
	public void AKOKNGHGKAD(string KPJHNEODDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6EB0", Offset = "0x2CA5EB0", VA = "0x182CA6EB0")]
	public void FOOOEGNAAFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class NNICOEAPHFK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct DCMGPCBMNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public JKIDPKPPPFG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NNICOEAPHFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter<LFGHCEFMKAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x42AC490", Offset = "0x42AB490", VA = "0x1842AC490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x42AC7A0", Offset = "0x42AB7A0", VA = "0x1842AC7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct OGCHLHBJCCE<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private sealed class LJPNGAIPBHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public JKIDPKPPPFG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LJPNGAIPBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x42B14C0", Offset = "0x42B04C0", VA = "0x1842B14C0")]
		internal JKIDPKPPPFG <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct OJDKKAMMCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<LFGHCEFMKAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public JKIDPKPPPFG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NNICOEAPHFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private PFOPODEDLKI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<LFGHCEFMKAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x42B5AC0", Offset = "0x42B4AC0", VA = "0x1842B5AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x42B6290", Offset = "0x42B5290", VA = "0x1842B6290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct CKDDAIKFJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NNICOEAPHFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x42AC2D0", Offset = "0x42AB2D0", VA = "0x1842AC2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class HLKLBNDIHGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HLKLBNDIHGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x42AE850", Offset = "0x42AD850", VA = "0x1842AE850")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class BMOAKFCKLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BMOAKFCKLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x42ABEC0", Offset = "0x42AAEC0", VA = "0x1842ABEC0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class CFKENNMGIEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CFKENNMGIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x42AC1F0", Offset = "0x42AB1F0", VA = "0x1842AC1F0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CGHBDPIMONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CGHBDPIMONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x42AC260", Offset = "0x42AB260", VA = "0x1842AC260")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class ECIDHGJBMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public NNICOEAPHFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ECIDHGJBMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x42AD170", Offset = "0x42AC170", VA = "0x1842AD170")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class BFPGFACKDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public NNICOEAPHFK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BFPGFACKDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x42ABA10", Offset = "0x42AAA10", VA = "0x1842ABA10")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private static readonly Guid OMHJODMNEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public readonly FEBBGJAEJGA FBHGNHPPGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly DEBBKGCKOLK LAFNOIFEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly IHCGNEMANOG FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly EGHJOOMBDDE LILKIDNNECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private bool PHODOHPACCO;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6300", Offset = "0x2CA5300", VA = "0x182CA6300")]
	public NNICOEAPHFK(FEBBGJAEJGA OKAMDGKEFCC, DEBBKGCKOLK LAFNOIFEIII, IHCGNEMANOG FMJNCAAMIPB, EGHJOOMBDDE LILKIDNNECK, HKLBBGEFPMO NMGDNGMBHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5370", Offset = "0x2CA4370", VA = "0x182CA5370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5370", Offset = "0x2CA4370", VA = "0x182CA5370")]
	public void CFCGJABHNNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5220", Offset = "0x2CA4220", VA = "0x182CA5220")]
	public void BLBAHCHCEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6140", Offset = "0x2CA5140", VA = "0x182CA6140")]
	public void OJMKOKOPJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA50A0", Offset = "0x2CA40A0", VA = "0x182CA50A0")]
	[AsyncStateMachine(typeof(DCMGPCBMNHH))]
	internal Task<JKIDPKPPPFG> BEBFPAJFHFN(HKLBBGEFPMO NMGDNGMBHAG, JKIDPKPPPFG DDAIPOAIAJC, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA03F0", Offset = "0x2C9F3F0", VA = "0x182CA03F0")]
	private static byte[] MMKEOPEKJML<T>(T NJAIIGFCHNG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x33C8A20", Offset = "0x33C7A20", VA = "0x1833C8A20")]
	private static T JGHNMFHGFGK<T>(MessageParser<T> MDCDAOEHDDL, byte[] NJAIIGFCHNG, T MHMMCHLDEKP) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5E20", Offset = "0x2CA4E20", VA = "0x182CA5E20")]
	[AsyncStateMachine(typeof(OJDKKAMMCKJ))]
	private Task<LFGHCEFMKAE> KCAAFPCKPFG(JKIDPKPPPFG DDAIPOAIAJC, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x33C8C50", Offset = "0x33C7C50", VA = "0x1833C8C50")]
	[AsyncStateMachine(typeof(OOINPOLFHON))]
	internal Task<T> MJPOKHCCOBC<T>(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task<T>> CPBIPBGMGDE, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5FF0", Offset = "0x2CA4FF0", VA = "0x182CA5FF0")]
	[AsyncStateMachine(typeof(CKDDAIKFJGA))]
	internal Task MJPOKHCCOBC(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task> CPBIPBGMGDE, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA58A0", Offset = "0x2CA48A0", VA = "0x182CA58A0")]
	public JKIDPKPPPFG GCHPNHDKIHA(PFOPODEDLKI ABBFFMMANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5F80", Offset = "0x2CA4F80", VA = "0x182CA5F80")]
	public GMCAOOKJNNC KKCIEJPEGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CA56A0", Offset = "0x2CA46A0", VA = "0x182CA56A0")]
	public INFBGOPBKDD FPLLEFIGPPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5560", Offset = "0x2CA4560", VA = "0x182CA5560")]
	public NEFBNKJIAHN FDMHDOHNGJO([Optional] DMNEAAIBMMH? JBMKLDJAFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5C60", Offset = "0x2CA4C60", VA = "0x182CA5C60")]
	public void IALDGEOBFEC(Func<Guid, bool> KBGJCMKGEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5A80", Offset = "0x2CA4A80", VA = "0x182CA5A80")]
	public void HCKBLJGLJBO(Func<Guid, bool> FKDGLLHEGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5710", Offset = "0x2CA4710", VA = "0x182CA5710")]
	public void FPMGJONGCNF(Func<Guid, bool> KBGJCMKGEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4B90", Offset = "0x2CA3B90", VA = "0x182CA4B90")]
	public Guid AFCNFHPHMCH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5C90", Offset = "0x2CA4C90", VA = "0x182CA5C90")]
	public void IPGGINDGNFB(Guid ACBMLODKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5930", Offset = "0x2CA4930", VA = "0x182CA5930")]
	public void GOFLOPFDOHF(JKIDPKPPPFG KOAHCDOFOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4F20", Offset = "0x2CA3F20", VA = "0x182CA4F20")]
	public void AMJBGJGBGPP(string LLHCHOJNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4DA0", Offset = "0x2CA3DA0", VA = "0x182CA4DA0")]
	public void AMJBGJGBGPP(Func<string> LLLEGJDGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x33C8BD0", Offset = "0x33C7BD0", VA = "0x1833C8BD0")]
	private T LKNIDLIFFJE<T>(T CCIMHDCKHOF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5510", Offset = "0x2CA4510", VA = "0x182CA5510")]
	public void DENDJMFFBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x33C8F30", Offset = "0x33C7F30", VA = "0x1833C8F30")]
	[CompilerGenerated]
	internal static string NPCEFFKMKIH<T>(byte[] CDDAIIMDJCN, int MNOCOBOBDHD, ref OGCHLHBJCCE<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal sealed class FKJFDOBHAOP : FEBBGJAEJGA
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class GKCFOCMJAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GKCFOCMJAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x35CDAD0", Offset = "0x35CCAD0", VA = "0x1835CDAD0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct KICKNGKOAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public FKJFDOBHAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private INFBGOPBKDD <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x35D1680", Offset = "0x35D0680", VA = "0x1835D1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class NIKINGNCHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public BAOCFLKKNFF presence;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NIKINGNCHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x35D5540", Offset = "0x35D4540", VA = "0x1835D5540")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly CAOKGENDBMG EBKIPNDPAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private readonly APDOMGKMKFG KEAADJCAHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly FGOAJCHMBDH HPPHBGMILJH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private const bool DKKNKDIPDPJ = false;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x26642A0", Offset = "0x26632A0", VA = "0x1826642A0")]
	public FKJFDOBHAOP(CAOKGENDBMG EBKIPNDPAHM, APDOMGKMKFG KEAADJCAHGL, Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2663AE0", Offset = "0x2662AE0", VA = "0x182663AE0", Slot = "8")]
	[AsyncStateMachine(typeof(KICKNGKOAHC))]
	protected override Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2663C30", Offset = "0x2662C30", VA = "0x182663C30")]
	private BAOCFLKKNFF LAIMHNAKKHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2664060", Offset = "0x2663060", VA = "0x182664060")]
	private void LPELIOMKAMM(BAOCFLKKNFF OILAODEMEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x26641C0", Offset = "0x26631C0", VA = "0x1826641C0")]
	private static void PDPPNPFOLFM(APDOMGKMKFG LOEJLEDCOEP, [Optional] string NJAIIGFCHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class CNHBHNANCGB : FEBBGJAEJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct JFPDKKIGIPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CNHBHNANCGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<DIJEGIOFGFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A080", Offset = "0x2C99080", VA = "0x182C9A080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly int PBFKHMILFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly EHINBDMEHCH LLHGAGNPGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public readonly long FEGOEOPDKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public readonly long FBLLAEIHKDB;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x265F6B0", Offset = "0x265E6B0", VA = "0x18265F6B0")]
	public CNHBHNANCGB(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA, int PBFKHMILFLG, EHINBDMEHCH LLHGAGNPGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x265F570", Offset = "0x265E570", VA = "0x18265F570", Slot = "8")]
	[AsyncStateMachine(typeof(JFPDKKIGIPI))]
	protected override Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal abstract class HFAOELFNGIG : FEBBGJAEJGA
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class HCLJPGGNJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public HFAOELFNGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public JGDOFPANPPM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HCLJPGGNJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x35CE9C0", Offset = "0x35CD9C0", VA = "0x1835CE9C0")]
		internal Task <RunAsync>b__0(HKLBBGEFPMO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x35CEA00", Offset = "0x35CDA00", VA = "0x1835CEA00")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct AHMMLINBLKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public HFAOELFNGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private HCLJPGGNJBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x35C45A0", Offset = "0x35C35A0", VA = "0x1835C45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct KNHLHJIMCOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public JGDOFPANPPM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public HFAOELFNGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x35D1FA0", Offset = "0x35D0FA0", VA = "0x1835D1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x266AC80", Offset = "0x2669C80", VA = "0x18266AC80")]
	public HFAOELFNGIG(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA, string CCMHJHGDFOL, bool KBPPNGJDHPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x266A9D0", Offset = "0x26699D0", VA = "0x18266A9D0", Slot = "8")]
	[AsyncStateMachine(typeof(AHMMLINBLKA))]
	protected override Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task BOEDIPJKBCM(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x266AB20", Offset = "0x2669B20", VA = "0x18266AB20")]
	[AsyncStateMachine(typeof(KNHLHJIMCOM))]
	private Task MNGLNLHLJHC(IDisposable LOFLLOKDHAA, JGDOFPANPPM NLBLGOIHOFO, HKLBBGEFPMO MDGABGKAFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class AKPDIPKDPIE : FEBBGJAEJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct CNJOGPDEKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public AKPDIPKDPIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter<EOLBBGGAHOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2C92940", Offset = "0x2C91940", VA = "0x182C92940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly PEAHMKADPMI KMCOHECJCLH;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x265A6C0", Offset = "0x26596C0", VA = "0x18265A6C0")]
	public AKPDIPKDPIE(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA, PEAHMKADPMI KMCOHECJCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x265A4A0", Offset = "0x26594A0", VA = "0x18265A4A0", Slot = "7")]
	protected override string FMPKEAIGINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x265A580", Offset = "0x2659580", VA = "0x18265A580", Slot = "8")]
	[AsyncStateMachine(typeof(CNJOGPDEKHB))]
	protected override Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal abstract class FEBBGJAEJGA : PIFJCMLEGIB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public delegate Task LOBFKPGJHFK(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class BKLAHHJFLEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public HKLBBGEFPMO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public FEBBGJAEJGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BKLAHHJFLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2C91EE0", Offset = "0x2C90EE0", VA = "0x182C91EE0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class MHCNGKAIGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public BKLAHHJFLEI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MHCNGKAIGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x35D4A90", Offset = "0x35D3A90", VA = "0x1835D4A90")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x35D4B50", Offset = "0x35D3B50", VA = "0x1835D4B50")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct JPPIMEFKGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public FEBBGJAEJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public Func<FEBBGJAEJGA, HKLBBGEFPMO, NNICOEAPHFK> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private BKLAHHJFLEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private NNICOEAPHFK <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x35D0290", Offset = "0x35CF290", VA = "0x1835D0290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct EADOCALAEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public FEBBGJAEJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2C95AB0", Offset = "0x2C94AB0", VA = "0x182C95AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public readonly Guid KLLKJJECHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public readonly ByteString KHKFMIJHKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public readonly OHPHHOAEIIK IBHMJJDGDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	protected readonly string AFFNIAFHIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private readonly bool KBPPNGJDHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private bool ABAEAFLJKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public NCEFFCHHIAA NKLHDODLHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public NCEFFCHHIAA NGKBKNJGJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly Queue<LOBFKPGJHFK> KCGAFGAMGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly CKFJHMPIILJ NMIMJCOBFDF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CDJBHBCLHCD KOGPOBENDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2663220", Offset = "0x2662220", VA = "0x182663220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NGGIJKCGJLP HEDDBOKEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x26636C0", Offset = "0x26626C0", VA = "0x1826636C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2663710", Offset = "0x2662710", VA = "0x182663710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2663380", Offset = "0x2662380", VA = "0x182663380", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2663560", Offset = "0x2662560", VA = "0x182663560", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x26630B0", Offset = "0x26620B0", VA = "0x1826630B0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x26637F0", Offset = "0x26627F0", VA = "0x1826637F0")]
	protected FEBBGJAEJGA(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA, string CCMHJHGDFOL, bool KBPPNGJDHPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2663480", Offset = "0x2662480", VA = "0x182663480", Slot = "7")]
	protected virtual string FMPKEAIGINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2663790", Offset = "0x2662790", VA = "0x182663790")]
	public void OLABJFNGPLJ(LOBFKPGJHFK NGAGNDOFOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2663540", Offset = "0x2662540", VA = "0x182663540")]
	protected void GCOKNMCLPGI(float OGGODOHJPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x26630D0", Offset = "0x26620D0", VA = "0x1826630D0")]
	[AsyncStateMachine(typeof(JPPIMEFKGAJ))]
	public Task CHCDHEIAFLI(CancellationToken OHJGLBPIBBN, HKLBBGEFPMO NMGDNGMBHAG, [Optional] Func<FEBBGJAEJGA, HKLBBGEFPMO, NNICOEAPHFK> IODDIDBONIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2663270", Offset = "0x2662270", VA = "0x182663270")]
	private void CMNDPCICIAN(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2663580", Offset = "0x2662580", VA = "0x182663580")]
	[AsyncStateMachine(typeof(EADOCALAEAN))]
	private Task OBKIBIMNOFM(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x26634C0", Offset = "0x26624C0", VA = "0x1826634C0")]
	public JKIDPKPPPFG GCHPNHDKIHA(PFOPODEDLKI ABBFFMMANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x26633A0", Offset = "0x26623A0", VA = "0x1826633A0")]
	[CompilerGenerated]
	private Task FJIMLNMONGM(CancellationToken HLNBIKMPIPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal sealed class AFLEAKDPMIO : HFAOELFNGIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct IMPNLLANILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AFLEAKDPMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EFBIDOEEHFO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private INFBGOPBKDD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2C993F0", Offset = "0x2C983F0", VA = "0x182C993F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private readonly CAOKGENDBMG GIBBEHBDELF;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x26553B0", Offset = "0x26543B0", VA = "0x1826553B0")]
	public AFLEAKDPMIO(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, CAOKGENDBMG GIBBEHBDELF, OHPHHOAEIIK CFNAJDFAEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2655260", Offset = "0x2654260", VA = "0x182655260", Slot = "9")]
	[AsyncStateMachine(typeof(IMPNLLANILC))]
	protected override Task BOEDIPJKBCM(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class HBBHFOALEGK : FEBBGJAEJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct BDBMDPFBEAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public HBBHFOALEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private TaskAwaiter<EOLBBGGAHOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x35C5440", Offset = "0x35C4440", VA = "0x1835C5440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly string HPFMFCELEFL;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2669010", Offset = "0x2668010", VA = "0x182669010")]
	public HBBHFOALEGK(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, OHPHHOAEIIK CFNAJDFAEAA, string HPFMFCELEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2668EE0", Offset = "0x2667EE0", VA = "0x182668EE0", Slot = "8")]
	[AsyncStateMachine(typeof(BDBMDPFBEAM))]
	protected override Task KLNHCPGJAEO(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class FOELHLLPBHF : HFAOELFNGIG
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class OKHJGFPDDLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public OKHJGFPDDLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private TaskAwaiter<EOLBBGGAHOM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<JKIDPKPPPFG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x42B97D0", Offset = "0x42B87D0", VA = "0x1842B97D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x42B9B10", Offset = "0x42B8B10", VA = "0x1842B9B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public FOELHLLPBHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public NEFBNKJIAHN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public GMCAOOKJNNC uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OKHJGFPDDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x35D6570", Offset = "0x35D5570", VA = "0x1835D6570")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JKIDPKPPPFG> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct BEOAMKCODOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public FOELHLLPBHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private OKHJGFPDDLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private EFBIDOEEHFO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private INFBGOPBKDD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x35C5990", Offset = "0x35C4990", VA = "0x1835C5990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly int KLGMAAJMFEI;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2665AA0", Offset = "0x2664AA0", VA = "0x182665AA0")]
	public FOELHLLPBHF(Guid IBJDBAKNBNO, CDJBHBCLHCD MEFFMNONBAI, int KLGMAAJMFEI, OHPHHOAEIIK CFNAJDFAEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2665680", Offset = "0x2664680", VA = "0x182665680", Slot = "9")]
	[AsyncStateMachine(typeof(BEOAMKCODOK))]
	protected override Task BOEDIPJKBCM(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x26657E0", Offset = "0x26647E0", VA = "0x1826657E0")]
	private void CIGHEHMPKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2665900", Offset = "0x2664900", VA = "0x182665900")]
	private void GFLKMBLGCME(HKLBBGEFPMO NMGDNGMBHAG, EFBIDOEEHFO NCOJPJKLCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal abstract class LGPJJBHAAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly FEBBGJAEJGA FBHGNHPPGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly NNICOEAPHFK ADBIGFFALKA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C880", Offset = "0x2C9B880", VA = "0x182C9C880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C8A0", Offset = "0x2C9B8A0", VA = "0x182C9C8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C900", Offset = "0x2C9B900", VA = "0x182C9C900")]
	protected LGPJJBHAAPI(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C560", Offset = "0x2C9B560", VA = "0x182C9C560")]
	protected void AMJBGJGBGPP(string LLHCHOJNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C6F0", Offset = "0x2C9B6F0", VA = "0x182C9C6F0")]
	public void AMJBGJGBGPP(Func<string> LLLEGJDGPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal struct ACAIEKOFOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public Dictionary<Guid, List<BDIMKNBGBLH>> ELFBNOEKBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public Dictionary<Guid, List<BDIMKNBGBLH>> LNBCPABPGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public Dictionary<Guid, List<BDIMKNBGBLH>> BDFJMPGKKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public List<Guid> GIOLMDKNEPI;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2653F30", Offset = "0x2652F30", VA = "0x182653F30")]
	public static ACAIEKOFOMH KEEHOGKCDPF(GJMGHDCEIFH OHLAEPJHHCL, NCEFFCHHIAA PDMJGBFFFIO, CEBPIIBHMDD PLOCLAPJHEI)
	{
		return default(ACAIEKOFOMH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal struct CKNJJMJJOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00")]
	public static CKNJJMJJOMN MFNJFAEBAIM()
	{
		return default(CKNJJMJJOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LMIKDGOIDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void AOMNGBIINOE(CEBPIIBHMDD PJDKPCLOECB, object FEKDOHINCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DHGHHHIPCBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct FGCGCNLHLOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public readonly DIJEGIOFGFI PBMANDLMOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly MPGLODPOCPP BHFDNIDNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public readonly OJPIJMGNJBA HMPMFMHHLJE;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2663A90", Offset = "0x2662A90", VA = "0x182663A90")]
	public FGCGCNLHLOJ(DIJEGIOFGFI PBMANDLMOMN, MPGLODPOCPP BHFDNIDNNKB, OJPIJMGNJBA HMPMFMHHLJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct MFMACBHAOGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly NNICOEAPHFK LCGHMJPFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly Guid ACBMLODKCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private bool CLHNHEDOGNJ;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E1A0", Offset = "0x2C9D1A0", VA = "0x182C9E1A0")]
	public static MFMACBHAOGD AFCNFHPHMCH(NNICOEAPHFK LCGHMJPFPBL)
	{
		return default(MFMACBHAOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x120F8B0", Offset = "0x120E8B0", VA = "0x18120F8B0")]
	public void GCHGEONECLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E1D0", Offset = "0x2C9D1D0", VA = "0x182C9E1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E5C0", Offset = "0x2C9D5C0", VA = "0x182C9E5C0")]
	private MFMACBHAOGD(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E1E0", Offset = "0x2C9D1E0", VA = "0x182C9E1E0")]
	private void IPGGINDGNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E510", Offset = "0x2C9D510", VA = "0x182C9E510")]
	private Func<Guid, bool> KGGDGEDBKHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class INFBGOPBKDD : LGPJJBHAAPI, PIFJCMLEGIB
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public delegate Task<NCEFFCHHIAA> KHAMGMNMDLA(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP PDOFJMNLAOH, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct NJHCAIAKIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public CAOKGENDBMG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private MFMACBHAOGD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x35D5680", Offset = "0x35D4680", VA = "0x1835D5680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct LKALDBENMEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CAOKGENDBMG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private HKLBBGEFPMO <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x35D3910", Offset = "0x35D2910", VA = "0x1835D3910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x35D3C30", Offset = "0x35D2C30", VA = "0x1835D3C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct HHEMPDENBOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public CAOKGENDBMG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private HKLBBGEFPMO <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x35CEA80", Offset = "0x35CDA80", VA = "0x1835CEA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class IOOFHMNBOPD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public AsyncTaskMethodBuilder<FGCGCNLHLOJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public IOOFHMNBOPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private FGCGCNLHLOJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private TaskAwaiter<NCEFFCHHIAA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private TaskAwaiter<FGCGCNLHLOJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x42B83E0", Offset = "0x42B73E0", VA = "0x1842B83E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x42B8B30", Offset = "0x42B7B30", VA = "0x1842B8B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public AsyncTaskMethodBuilder<CEBPIIBHMDD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public IOOFHMNBOPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private CEBPIIBHMDD <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter<NCEFFCHHIAA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private TaskAwaiter<CEBPIIBHMDD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x42B8B80", Offset = "0x42B7B80", VA = "0x1842B8B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x42B90B0", Offset = "0x42B80B0", VA = "0x1842B90B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IOOFHMNBOPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter<NCEFFCHHIAA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private ANEFGNKFHFP <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x42B7570", Offset = "0x42B6570", VA = "0x1842B7570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public CAOKGENDBMG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CKFJHMPIILJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CKFJHMPIILJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FGCGCNLHLOJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CKFJHMPIILJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CEBPIIBHMDD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public JJIIFMBPEMP.POCOGIGDIGK <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IOOFHMNBOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x35CFA40", Offset = "0x35CEA40", VA = "0x1835CFA40")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FGCGCNLHLOJ> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x35CFB80", Offset = "0x35CEB80", VA = "0x1835CFB80")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<CEBPIIBHMDD> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x35CFCC0", Offset = "0x35CECC0", VA = "0x1835CFCC0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x35CF910", Offset = "0x35CE910", VA = "0x1835CF910")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct DMLDHDDNFIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CAOKGENDBMG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private IOOFHMNBOPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter<FGCGCNLHLOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter<CEBPIIBHMDD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x35C8780", Offset = "0x35C7780", VA = "0x1835C8780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct JIDMCBJLGKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x35CFD70", Offset = "0x35CED70", VA = "0x1835CFD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct HIPEOLJPHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private HKLBBGEFPMO <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x35CECE0", Offset = "0x35CDCE0", VA = "0x1835CECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct ACJDDNDGGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private HKLBBGEFPMO <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x35C3AB0", Offset = "0x35C2AB0", VA = "0x1835C3AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x35C4550", Offset = "0x35C3550", VA = "0x1835C4550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct FGCIFBFCGHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private HKLBBGEFPMO <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x35CB580", Offset = "0x35CA580", VA = "0x1835CB580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x35CC130", Offset = "0x35CB130", VA = "0x1835CC130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct EBPKGGGHPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public NCEFFCHHIAA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public CEBPIIBHMDD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x35C92C0", Offset = "0x35C82C0", VA = "0x1835C92C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x35C94C0", Offset = "0x35C84C0", VA = "0x1835C94C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class PKMACKDDHGG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public PKMACKDDHGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter<NCEFFCHHIAA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x42B9100", Offset = "0x42B8100", VA = "0x1842B9100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x42B9640", Offset = "0x42B8640", VA = "0x1842B9640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public KHAMGMNMDLA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public NCEFFCHHIAA originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PKMACKDDHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x35D6E60", Offset = "0x35D5E60", VA = "0x1835D6E60")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<NCEFFCHHIAA> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct FHJBJMMEDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public KHAMGMNMDLA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x35CC180", Offset = "0x35CB180", VA = "0x1835CC180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x35CC620", Offset = "0x35CB620", VA = "0x1835CC620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct MKMLFFBJGPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CKFJHMPIILJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private NCEFFCHHIAA <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private IEnumerator<NCEFFCHHIAA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x35D4C10", Offset = "0x35D3C10", VA = "0x1835D4C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GALKPPFHKCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x35CCA50", Offset = "0x35CBA50", VA = "0x1835CCA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct BGLHGKMIBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public INFBGOPBKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x35C6910", Offset = "0x35C5910", VA = "0x1835C6910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class CEGHGLBMCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public DIJEGIOFGFI roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CEGHGLBMCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x35C7580", Offset = "0x35C6580", VA = "0x1835C7580")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly JPJBFCEOADG BKBMBCLJJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly JPJBFCEOADG PNLLIMIDAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private readonly NPPGBANJAMC CBKHFKPLKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly FLFLNLODDME HFJECHOJFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private readonly HBJDLCKBPLL IHOFEMBANDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private readonly AKIFNHNILDO LJJPJBFGHME;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x266F080", Offset = "0x266E080", VA = "0x18266F080", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private CDJBHBCLHCD KOGPOBENDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2668C30", Offset = "0x2667C30", VA = "0x182668C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x266FAA0", Offset = "0x266EAA0", VA = "0x18266FAA0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x266EAA0", Offset = "0x266DAA0", VA = "0x18266EAA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2670110", Offset = "0x266F110", VA = "0x182670110")]
	public INFBGOPBKDD(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x266F0C0", Offset = "0x266E0C0", VA = "0x18266F0C0")]
	[AsyncStateMachine(typeof(NJHCAIAKIFI))]
	public Task FOKDNMBKECM(CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x266E500", Offset = "0x266D500", VA = "0x18266E500")]
	[AsyncStateMachine(typeof(LKALDBENMEN))]
	private Task<JKIDPKPPPFG> ABDIAEOGHEN(CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x266F210", Offset = "0x266E210", VA = "0x18266F210")]
	[AsyncStateMachine(typeof(HHEMPDENBOG))]
	private Task GIGNPBOBFOI(CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x266F7D0", Offset = "0x266E7D0", VA = "0x18266F7D0")]
	[AsyncStateMachine(typeof(DMLDHDDNFIL))]
	private Task KOOMBNLOKGC(CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken FPDNLJJEEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x266F670", Offset = "0x266E670", VA = "0x18266F670")]
	[AsyncStateMachine(typeof(JIDMCBJLGKB))]
	private Task KEJDNLFKPKP(HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x266FF20", Offset = "0x266EF20", VA = "0x18266FF20")]
	[AsyncStateMachine(typeof(HIPEOLJPHKD))]
	private Task PHILELEDHFE(CEBPIIBHMDD PJDKPCLOECB, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x266F920", Offset = "0x266E920", VA = "0x18266F920")]
	[AsyncStateMachine(typeof(ACJDDNDGGAD))]
	private Task<NCEFFCHHIAA> LPDBHBAMPKE(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x266EC10", Offset = "0x266DC10", VA = "0x18266EC10")]
	[AsyncStateMachine(typeof(FGCIFBFCGHD))]
	private Task<NCEFFCHHIAA> DKGNHMBEAAN(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x266E820", Offset = "0x266D820", VA = "0x18266E820")]
	[AsyncStateMachine(typeof(EBPKGGGHPNH))]
	private Task<NCEFFCHHIAA> BLBOLKHODKP(NCEFFCHHIAA PDMJGBFFFIO, CEBPIIBHMDD PLOCLAPJHEI, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN, bool GEJKCBCPFIK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x266E9B0", Offset = "0x266D9B0", VA = "0x18266E9B0")]
	private bool BMDHHNODACD(CEBPIIBHMDD MCGJNAMJAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x266EDB0", Offset = "0x266DDB0", VA = "0x18266EDB0")]
	[AsyncStateMachine(typeof(FHJBJMMEDJD))]
	protected Task<NCEFFCHHIAA> DMEDGGLAMGB(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN, KHAMGMNMDLA MMLLONMFJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x266F3B0", Offset = "0x266E3B0", VA = "0x18266F3B0")]
	[AsyncStateMachine(typeof(MKMLFFBJGPJ))]
	private Task JHLKPHAKBLJ(CEBPIIBHMDD PJDKPCLOECB, CKFJHMPIILJ NLHBJJIJGOF, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x266FC20", Offset = "0x266EC20", VA = "0x18266FC20")]
	private void NDPNENGOJBI(NCEFFCHHIAA KJBKMBKFPBC, CKFJHMPIILJ NLHBJJIJGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x26700D0", Offset = "0x266F0D0", VA = "0x1826700D0")]
	private void PPBNOKLHPLK(NCEFFCHHIAA CIOMIOBDFJJ, out NCEFFCHHIAA AKJFDPFKKBI, out NCEFFCHHIAA MJHAHDIIHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x266F370", Offset = "0x266E370", VA = "0x18266F370")]
	private Task<FGCGCNLHLOJ> JFONCMMAEOB(CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2670080", Offset = "0x266F080", VA = "0x182670080")]
	private Task<CEBPIIBHMDD> PJBNONABDEH(CAOKGENDBMG ANHHADJHMBE, FGCGCNLHLOJ PJDKPCLOECB, JJIIFMBPEMP.POCOGIGDIGK DCCJBFFGHGO, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x266EAC0", Offset = "0x266DAC0", VA = "0x18266EAC0")]
	[AsyncStateMachine(typeof(GALKPPFHKCK))]
	private Task DALNGINDNDM(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x266EF60", Offset = "0x266DF60", VA = "0x18266EF60")]
	[AsyncStateMachine(typeof(BGLHGKMIBID))]
	private Task EIFGFCALCPP(CEBPIIBHMDD PJDKPCLOECB, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x266F7A0", Offset = "0x266E7A0", VA = "0x18266F7A0")]
	private Task KIIHOPNIAKF(CEBPIIBHMDD PJDKPCLOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x266FDC0", Offset = "0x266EDC0", VA = "0x18266FDC0")]
	private Task OFBMBOCDNAD(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x266FC70", Offset = "0x266EC70", VA = "0x18266FC70")]
	private Task NNPCLNHIDMB(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x266E680", Offset = "0x266D680", VA = "0x18266E680")]
	private Task BADCMLKMNAE(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x265E230", Offset = "0x265D230", VA = "0x18265E230")]
	private static Task EMADFCCIALG(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x266F510", Offset = "0x266E510", VA = "0x18266F510")]
	private Task KEIGFBDAOPM(CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x266F0A0", Offset = "0x266E0A0", VA = "0x18266F0A0")]
	private Task FAFKDFAPBBJ(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x266E7F0", Offset = "0x266D7F0", VA = "0x18266E7F0")]
	private void BGEJHFIMIOJ(CAOKGENDBMG ANHHADJHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x266FAC0", Offset = "0x266EAC0", VA = "0x18266FAC0")]
	private static void MMOPDPDHHJH(DIJEGIOFGFI PBMANDLMOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct LNMDOFNKDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private NCEFFCHHIAA KJBKMBKFPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private CEBPIIBHMDD PJDKPCLOECB;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D360", Offset = "0x2C9C360", VA = "0x182C9D360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D3B0", Offset = "0x2C9C3B0", VA = "0x182C9D3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D060", Offset = "0x2C9C060", VA = "0x182C9D060")]
	public static Task CHCDHEIAFLI(CDJBHBCLHCD MEFFMNONBAI, NCEFFCHHIAA KJBKMBKFPBC, CEBPIIBHMDD PJDKPCLOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D110", Offset = "0x2C9C110", VA = "0x182C9D110")]
	private void CHCDHEIAFLI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct CFBFMLCLBHJ
{
	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x265E230", Offset = "0x265D230", VA = "0x18265E230")]
	public static Task CHCDHEIAFLI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct NKCEICKGANI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct OMMFOBMBBLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private HKLBBGEFPMO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x42B62E0", Offset = "0x42B52E0", VA = "0x1842B62E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA43B0", Offset = "0x2CA33B0", VA = "0x182CA43B0")]
	[AsyncStateMachine(typeof(OMMFOBMBBLF))]
	public static Task CHCDHEIAFLI(NNICOEAPHFK LCGHMJPFPBL, CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct IOFKEDPHCPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct EMLONOIPJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private NCEFFCHHIAA <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private CDJBHBCLHCD <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private GJMGHDCEIFH <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private List<(PersistenceView, MMNPPFHGILJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private MMNPPFHGILJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x35CA640", Offset = "0x35C9640", VA = "0x1835CA640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2670330", Offset = "0x266F330", VA = "0x182670330")]
	[AsyncStateMachine(typeof(EMLONOIPJGG))]
	public static Task CHCDHEIAFLI(NNICOEAPHFK LCGHMJPFPBL, CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x26704A0", Offset = "0x266F4A0", VA = "0x1826704A0")]
	private static void NICNPKJECML(PersistenceView JJOFMICFAJO, MMNPPFHGILJ FEKDOHINCFN, CEBPIIBHMDD PJDKPCLOECB, NCEFFCHHIAA PDMJGBFFFIO, bool NFJAPANJJBH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct MALGPGBOHKF
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DEF0", Offset = "0x2C9CEF0", VA = "0x182C9DEF0")]
	public static Task CHCDHEIAFLI(CDJBHBCLHCD MEFFMNONBAI, CEBPIIBHMDD PJDKPCLOECB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct KCIBJPNMONO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct POMPCEOJJMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CDJBHBCLHCD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x35D6FA0", Offset = "0x35D5FA0", VA = "0x1835D6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct GNPNMLOCNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public KCIBJPNMONO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x35CE120", Offset = "0x35CD120", VA = "0x1835CE120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class NIBKHAIFIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public MCJDIFJPNAH version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NIBKHAIFIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x35D53B0", Offset = "0x35D43B0", VA = "0x1835D53B0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x35D5490", Offset = "0x35D4490", VA = "0x1835D5490")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private CEBPIIBHMDD PJDKPCLOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private NNICOEAPHFK LCGHMJPFPBL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ByteString HNEECJAOFMG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2674460", Offset = "0x2673460", VA = "0x182674460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private CMKIBFLEFJN CKFKOFNOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2674B50", Offset = "0x2673B50", VA = "0x182674B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2674300", Offset = "0x2673300", VA = "0x182674300")]
	[AsyncStateMachine(typeof(POMPCEOJJMM))]
	public static Task CHCDHEIAFLI(CDJBHBCLHCD MEFFMNONBAI, NCEFFCHHIAA KJBKMBKFPBC, CEBPIIBHMDD PJDKPCLOECB, NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x26741C0", Offset = "0x26731C0", VA = "0x1826741C0")]
	[AsyncStateMachine(typeof(GNPNMLOCNFC))]
	private Task CHCDHEIAFLI(HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x26744B0", Offset = "0x26734B0", VA = "0x1826744B0")]
	private void MPDMEMOLPPB([NotNull] KHMOACGNIHJ LDGIDBEGKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2674190", Offset = "0x2673190", VA = "0x182674190")]
	private bool AJFEMCCLNJH(MCJDIFJPNAH LDFDMKAILBI, KHMOACGNIHJ LDGIDBEGKFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct NBCCHMGBPHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct IOFCAEKHIFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder<CEBPIIBHMDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public NBCCHMGBPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public JJIIFMBPEMP.POCOGIGDIGK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private HKLBBGEFPMO <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter<(global::OANJAMKPOEA<AJEPHCOGOEA, LNLCMCKKKGI>, global::OANJAMKPOEA<global::DBENDBIPDML<KHMOACGNIHJ>, LNLCMCKKKGI>, global::OANJAMKPOEA<global::DBENDBIPDML<DEENGOJEGMM>, LNLCMCKKKGI>, global::OANJAMKPOEA<global::DBENDBIPDML<AOLFLJPAJKD>, LNLCMCKKKGI>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x42AEF70", Offset = "0x42ADF70", VA = "0x1842AEF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x42AF830", Offset = "0x42AE830", VA = "0x1842AF830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JICCOLGKBDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder<global::OANJAMKPOEA<AJEPHCOGOEA, LNLCMCKKKGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public HKLBBGEFPMO downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public NBCCHMGBPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public JJIIFMBPEMP.POCOGIGDIGK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private HKLBBGEFPMO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<global::OANJAMKPOEA<AJEPHCOGOEA, LNLCMCKKKGI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x42B01F0", Offset = "0x42AF1F0", VA = "0x1842B01F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x42B06E0", Offset = "0x42AF6E0", VA = "0x1842B06E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private global::MFJLILHPNBB<NLKLCIGNEIJ, DEENGOJEGMM> IBLNLAMDNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private global::MFJLILHPNBB<NLKLCIGNEIJ, KHMOACGNIHJ> BHFDNIDNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private global::MFJLILHPNBB<long, AOLFLJPAJKD> MNDGHHAJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private BDLMCAKMBAG JFCMDLIBNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private CAOKGENDBMG ANHHADJHMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private DIJEGIOFGFI PBMANDLMOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private MPGLODPOCPP HLGNIMKAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private long JACMPOFNBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private HKLBBGEFPMO MDGABGKAFDE;

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FA70", Offset = "0x2C9EA70", VA = "0x182C9FA70")]
	public static Task<CEBPIIBHMDD> LPKNIOHAOKB(CDJBHBCLHCD MEFFMNONBAI, CAOKGENDBMG ANHHADJHMBE, in FGCGCNLHLOJ PJDKPCLOECB, JJIIFMBPEMP.POCOGIGDIGK DCCJBFFGHGO, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F710", Offset = "0x2C9E710", VA = "0x182C9F710")]
	[AsyncStateMachine(typeof(IOFCAEKHIFJ))]
	private Task<CEBPIIBHMDD> CHCDHEIAFLI(JJIIFMBPEMP.POCOGIGDIGK DCCJBFFGHGO, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FA30", Offset = "0x2C9EA30", VA = "0x182C9FA30")]
	private NLKLCIGNEIJ EKGOOABIHMK(ANPPOCAMPKL MDHBBFHLKKH)
	{
		return default(NLKLCIGNEIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F880", Offset = "0x2C9E880", VA = "0x182C9F880")]
	[AsyncStateMachine(typeof(JICCOLGKBDG))]
	private Task<global::OANJAMKPOEA<AJEPHCOGOEA, LNLCMCKKKGI>> CNAFFHMMFBO(string BLHPGIMDEGL, long JACMPOFNBDM, JJIIFMBPEMP.POCOGIGDIGK DCCJBFFGHGO, HKLBBGEFPMO EKOPNHBLLNL, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct CKJOIOLPMKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NLGDAMLEFIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AsyncTaskMethodBuilder<FGCGCNLHLOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CKJOIOLPMKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private HKLBBGEFPMO <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter<FGCGCNLHLOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4500", Offset = "0x2CA3500", VA = "0x182CA4500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA49B0", Offset = "0x2CA39B0", VA = "0x182CA49B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct OLIODIKAKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder<FGCGCNLHLOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CKJOIOLPMKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<FGCGCNLHLOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7E80", Offset = "0x2CA6E80", VA = "0x182CA7E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8070", Offset = "0x2CA7070", VA = "0x182CA8070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class LCGAAJCPLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public LCGAAJCPLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x11048B0", Offset = "0x11038B0", VA = "0x1811048B0")]
		internal bool <FetchRoomDetails>b__0(MPGLODPOCPP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NJCMCNJNDJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder<FGCGCNLHLOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public GJMGHDCEIFH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private LCGAAJCPLJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private TaskAwaiter<DIJEGIOFGFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3E20", Offset = "0x2CA2E20", VA = "0x182CA3E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4360", Offset = "0x2CA3360", VA = "0x182CA4360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private NPPGBANJAMC CBKHFKPLKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private HKLBBGEFPMO MDGABGKAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private long BDNAKAPNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private long HKIDJEFCIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private string CKEJIKPAPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private NLKLCIGNEIJ JCKFOKNADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private NLKLCIGNEIJ AHFBKMMPEOM;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x265ED90", Offset = "0x265DD90", VA = "0x18265ED90")]
	public static Task<FGCGCNLHLOJ> LPKNIOHAOKB(CDJBHBCLHCD MEFFMNONBAI, CAOKGENDBMG ANHHADJHMBE, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x265E7B0", Offset = "0x265D7B0", VA = "0x18265E7B0")]
	[AsyncStateMachine(typeof(NLGDAMLEFIG))]
	private Task<FGCGCNLHLOJ> CHCDHEIAFLI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x265EA80", Offset = "0x265DA80", VA = "0x18265EA80")]
	[AsyncStateMachine(typeof(OLIODIKAKBF))]
	private Task<FGCGCNLHLOJ> JFONCMMAEOB(long BDNAKAPNAFM, long HKIDJEFCIOJ, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN, bool PJOMEBDHMCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x265EC10", Offset = "0x265DC10", VA = "0x18265EC10")]
	[AsyncStateMachine(typeof(NJCMCNJNDJL))]
	public static Task<FGCGCNLHLOJ> JFONCMMAEOB(GJMGHDCEIFH OHLAEPJHHCL, long BDNAKAPNAFM, long HKIDJEFCIOJ, CancellationToken OHJGLBPIBBN, HKLBBGEFPMO NMGDNGMBHAG, bool PJOMEBDHMCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x265E5E0", Offset = "0x265D5E0", VA = "0x18265E5E0")]
	private void CBEFEOEFDCD(DIJEGIOFGFI PBMANDLMOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x265E910", Offset = "0x265D910", VA = "0x18265E910")]
	private bool JENHIDCLONO(FGCGCNLHLOJ PJDKPCLOECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x265E610", Offset = "0x265D610", VA = "0x18265E610")]
	private void CFFCDGFIHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct HPAGLJDPCEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct NONCMAIDBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public HPAGLJDPCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x35D5A80", Offset = "0x35D4A80", VA = "0x1835D5A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private const int OLFLBLMPMME = 20;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private const float NBMGNDFDFII = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private GJMGHDCEIFH OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private CEBPIIBHMDD PJDKPCLOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private HKLBBGEFPMO MDGABGKAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private float PEPPHBPKMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private float OIEEOEMBPHM;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x266DAA0", Offset = "0x266CAA0", VA = "0x18266DAA0")]
	public static Task CKJGMEHIBFA(CDJBHBCLHCD MEFFMNONBAI, CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x266D970", Offset = "0x266C970", VA = "0x18266D970")]
	[AsyncStateMachine(typeof(NONCMAIDBBE))]
	public Task CHCDHEIAFLI(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x266DD00", Offset = "0x266CD00", VA = "0x18266DD00")]
	private static void IIKBBEAGEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x266DEC0", Offset = "0x266CEC0", VA = "0x18266DEC0")]
	private void LAMLHMAGCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x266DC40", Offset = "0x266CC40", VA = "0x18266DC40")]
	private static float HAEFAGGECEJ(GJMGHDCEIFH OHLAEPJHHCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x266DEA0", Offset = "0x266CEA0", VA = "0x18266DEA0")]
	private static float JBJNELMEEMA()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct CNANGIBNNHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct OPFBCECJCDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public NNICOEAPHFK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private FEBBGJAEJGA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private CDJBHBCLHCD <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private JAOPNNGHGNC.IHGMHPDIMOA <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8250", Offset = "0x2CA7250", VA = "0x182CA8250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct DBGLACCECMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private HLLPGMKMDGK.LNILAHAPNEG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2C94C10", Offset = "0x2C93C10", VA = "0x182C94C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x265F2D0", Offset = "0x265E2D0", VA = "0x18265F2D0")]
	[AsyncStateMachine(typeof(OPFBCECJCDD))]
	public static Task CHCDHEIAFLI(NNICOEAPHFK LCGHMJPFPBL, CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x265F430", Offset = "0x265E430", VA = "0x18265F430")]
	private static Task<JKIDPKPPPFG> JDAEFFIFGHD(NNICOEAPHFK LCGHMJPFPBL, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x265F4A0", Offset = "0x265E4A0", VA = "0x18265F4A0")]
	[AsyncStateMachine(typeof(DBGLACCECMP))]
	private static Task NKPAGFPGCKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct CLPKIFJLPEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct HNAJIKLOFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public CLPKIFJLPEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x2C97FD0", Offset = "0x2C96FD0", VA = "0x182C97FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class GEBJPIEDONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GEBJPIEDONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2C96720", Offset = "0x2C95720", VA = "0x182C96720")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct PBDOPPEEOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CLPKIFJLPEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private OAPAPFDLLPC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2CA87D0", Offset = "0x2CA77D0", VA = "0x182CA87D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private bool GLCGLDEEGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private HKLBBGEFPMO MDGABGKAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private CancellationToken OHJGLBPIBBN;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x265F260", Offset = "0x265E260", VA = "0x18265F260")]
	public static Task JPCAELBKOIJ(CDJBHBCLHCD MEFFMNONBAI, bool GLCGLDEEGDC, HKLBBGEFPMO MDGABGKAFDE, CancellationToken EKKAFPFIHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x265F150", Offset = "0x265E150", VA = "0x18265F150")]
	[AsyncStateMachine(typeof(HNAJIKLOFNK))]
	private Task CHCDHEIAFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x265F020", Offset = "0x265E020", VA = "0x18265F020")]
	[AsyncStateMachine(typeof(PBDOPPEEOBK))]
	private Task AGNFDIEIKIH(bool FHJKEIFCOLE, string COMINAANPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00")]
	private bool CLIHDDFAFMP(bool GLCGLDEEGDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct KNJOMOCBHOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct NKFMOBBDCHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public KNJOMOCBHOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x42B4350", Offset = "0x42B3350", VA = "0x1842B4350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x42B4660", Offset = "0x42B3660", VA = "0x1842B4660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class KEBOFMAJAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KEBOFMAJAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x42B07E0", Offset = "0x42AF7E0", VA = "0x1842B07E0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct OFEBPHENBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public KNJOMOCBHOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private OAPAPFDLLPC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x42B4D50", Offset = "0x42B3D50", VA = "0x1842B4D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x42B5290", Offset = "0x42B4290", VA = "0x1842B5290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private OJPIJMGNJBA LKCBIONHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private HKLBBGEFPMO MDGABGKAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2C9B6D0", Offset = "0x2C9A6D0", VA = "0x182C9B6D0")]
	public static Task<Scene> EALNEOGIOKG(CDJBHBCLHCD MEFFMNONBAI, OJPIJMGNJBA CNAJGOODIAK, HKLBBGEFPMO MDGABGKAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2C9B590", Offset = "0x2C9A590", VA = "0x182C9B590")]
	[AsyncStateMachine(typeof(NKFMOBBDCHG))]
	private Task<Scene> CHCDHEIAFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2C9B440", Offset = "0x2C9A440", VA = "0x182C9B440")]
	[AsyncStateMachine(typeof(OFEBPHENBOF))]
	private Task<Scene> AGNFDIEIKIH(string COMINAANPMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct HBJDLCKBPLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct BIEDBNPAMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public HBJDLCKBPLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public NCEFFCHHIAA nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CEBPIIBHMDD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private HKLBBGEFPMO <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<NCEFFCHHIAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x35C6A60", Offset = "0x35C5A60", VA = "0x1835C6A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x35C7050", Offset = "0x35C6050", VA = "0x1835C7050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct LIPDKMNJAGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder<NCEFFCHHIAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public HBJDLCKBPLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public NCEFFCHHIAA state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x35D3200", Offset = "0x35D2200", VA = "0x1835D3200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x35D3480", Offset = "0x35D2480", VA = "0x1835D3480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private readonly NNICOEAPHFK LCGHMJPFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private readonly NPPGBANJAMC CBKHFKPLKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private readonly FLFLNLODDME HFJECHOJFFN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private FEBBGJAEJGA FBHGNHPPGHO
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x967F40", Offset = "0x966F40", VA = "0x180967F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2669410", Offset = "0x2668410", VA = "0x182669410")]
	public HBJDLCKBPLL(NNICOEAPHFK LCGHMJPFPBL, NPPGBANJAMC CBKHFKPLKFG, FLFLNLODDME HFJECHOJFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2669270", Offset = "0x2668270", VA = "0x182669270")]
	[AsyncStateMachine(typeof(BIEDBNPAMPE))]
	public Task<NCEFFCHHIAA> KLEPDLKNDKN(NCEFFCHHIAA PEPADEOIPOK, CEBPIIBHMDD PLOCLAPJHEI, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN, bool GEJKCBCPFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2669100", Offset = "0x2668100", VA = "0x182669100")]
	[AsyncStateMachine(typeof(LIPDKMNJAGA))]
	private Task<NCEFFCHHIAA> FDEHIJAGJMK(HKLBBGEFPMO NMGDNGMBHAG, NCEFFCHHIAA JCLIGOJKKCI, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x26690D0", Offset = "0x26680D0", VA = "0x1826690D0")]
	private bool BGBBBKCCHBJ(NCEFFCHHIAA JOLJMJBGIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x26690B0", Offset = "0x26680B0", VA = "0x1826690B0")]
	private void AMJBGJGBGPP(string NLDGIOOAAAE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct FFHLKDJMPHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct MAOPBFMDEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public FEBBGJAEJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private List<(PersistenceView, MMNPPFHGILJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private (PersistenceView, MMNPPFHGILJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x35D4480", Offset = "0x35D3480", VA = "0x1835D4480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2663930", Offset = "0x2662930", VA = "0x182663930")]
	[AsyncStateMachine(typeof(MAOPBFMDEAG))]
	public static Task CHCDHEIAFLI(FEBBGJAEJGA OKAMDGKEFCC, CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct HGABKKKABJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct OHBACMFLHLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public FEBBGJAEJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public ANEFGNKFHFP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private MCJDIFJPNAH <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private List<(PersistenceView, MMNPPFHGILJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private MMNPPFHGILJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x35D5EA0", Offset = "0x35D4EA0", VA = "0x1835D5EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x266D820", Offset = "0x266C820", VA = "0x18266D820")]
	[AsyncStateMachine(typeof(OHBACMFLHLH))]
	public static Task CHCDHEIAFLI(FEBBGJAEJGA OKAMDGKEFCC, CEBPIIBHMDD PJDKPCLOECB, ANEFGNKFHFP DKCAFBACIDI, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct JAOPNNGHGNC
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public struct IHGMHPDIMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public List<BBILIEECLND> OPOKDDELINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public List<MMNPPFHGILJ> AONGCOCAIJL;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA10", Offset = "0x6F9A10", VA = "0x1806FAA10")]
		public IHGMHPDIMOA(List<BBILIEECLND> OPOKDDELINF, List<MMNPPFHGILJ> AONGCOCAIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class NLJFKBPIAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public List<BBILIEECLND> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NLJFKBPIAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x35D5A00", Offset = "0x35D4A00", VA = "0x1835D5A00")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private CDJBHBCLHCD MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private CEBPIIBHMDD PJDKPCLOECB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private GJMGHDCEIFH COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2671D70", Offset = "0x2670D70", VA = "0x182671D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2671D10", Offset = "0x2670D10", VA = "0x182671D10")]
	public static IHGMHPDIMOA CHCDHEIAFLI(CDJBHBCLHCD MEFFMNONBAI, CEBPIIBHMDD PJDKPCLOECB)
	{
		return default(IHGMHPDIMOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2671A90", Offset = "0x2670A90", VA = "0x182671A90")]
	private IHGMHPDIMOA CHCDHEIAFLI()
	{
		return default(IHGMHPDIMOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2671DC0", Offset = "0x2670DC0", VA = "0x182671DC0")]
	private IHGMHPDIMOA JEAMLBBPKHP(KHMOACGNIHJ LDGIDBEGKFC, MCJDIFJPNAH OKJPLBMFAAJ)
	{
		return default(IHGMHPDIMOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2672310", Offset = "0x2671310", VA = "0x182672310")]
	private GameObject[] LFKBAPEHLDG(List<BBILIEECLND> OPOKDDELINF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct LLPLFKNCCKL
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class MIIOHDMMCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JAOPNNGHGNC.IHGMHPDIMOA instantiations;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MIIOHDMMCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x42B4160", Offset = "0x42B3160", VA = "0x1842B4160")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class HGDGGBJMHDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HGDGGBJMHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x42AE220", Offset = "0x42AD220", VA = "0x1842AE220")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9CA00", Offset = "0x2C9BA00", VA = "0x182C9CA00")]
	public static void CHCDHEIAFLI(FEBBGJAEJGA OKAMDGKEFCC, CEBPIIBHMDD PJDKPCLOECB, JAOPNNGHGNC.IHGMHPDIMOA OBGNJLIPDDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal class FLFLNLODDME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct DLFMNOOBFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public NCEFFCHHIAA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CEBPIIBHMDD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x35C8440", Offset = "0x35C7440", VA = "0x1835C8440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class HLIFIEDKJBJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public HLIFIEDKJBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x42B9690", Offset = "0x42B8690", VA = "0x1842B9690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public HKLBBGEFPMO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HLIFIEDKJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x35CF290", Offset = "0x35CE290", VA = "0x1835CF290")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct CHHPOOOGEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private HLIFIEDKJBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x35C8020", Offset = "0x35C7020", VA = "0x1835C8020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EOIELHCABEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private Dictionary<Guid, List<BDIMKNBGBLH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x35CB090", Offset = "0x35CA090", VA = "0x1835CB090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct ALJAEEEFABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private HKLBBGEFPMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private Dictionary<Guid, List<BDIMKNBGBLH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x35C4CC0", Offset = "0x35C3CC0", VA = "0x1835C4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class PJCIKLOCCGK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public BDIMKNBGBLH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public PJCIKLOCCGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x42B7430", Offset = "0x42B6430", VA = "0x1842B7430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public POACONEMMLB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public List<BDIMKNBGBLH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PJCIKLOCCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x35D6B60", Offset = "0x35D5B60", VA = "0x1835D6B60")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x35D6D40", Offset = "0x35D5D40", VA = "0x1835D6D40")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(BDIMKNBGBLH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x35D6C50", Offset = "0x35D5C50", VA = "0x1835D6C50")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct EJAMDBADOOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public POACONEMMLB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public List<BDIMKNBGBLH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private PJCIKLOCCGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x35C9650", Offset = "0x35C8650", VA = "0x1835C9650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct BADAFABKOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public HKLBBGEFPMO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x35C51C0", Offset = "0x35C41C0", VA = "0x1835C51C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class FDGGEKLNKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FDGGEKLNKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x35CB510", Offset = "0x35CA510", VA = "0x1835CB510")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct EMJEOLPFHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CEBPIIBHMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x35CA1F0", Offset = "0x35C91F0", VA = "0x1835CA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class JAAEKIGDLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JAAEKIGDLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x35CFD00", Offset = "0x35CED00", VA = "0x1835CFD00")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct BGHFFHOIOAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public FLFLNLODDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x35C63B0", Offset = "0x35C53B0", VA = "0x1835C63B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class NPFBGOCKCEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NPFBGOCKCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x35D5E30", Offset = "0x35D4E30", VA = "0x1835D5E30")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly NNICOEAPHFK LCGHMJPFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private ACAIEKOFOMH HFJECHOJFFN;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private FEBBGJAEJGA FBHGNHPPGHO
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B95A0", VA = "0x1807BA5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	public FLFLNLODDME(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x26649E0", Offset = "0x26639E0", VA = "0x1826649E0")]
	[AsyncStateMachine(typeof(DLFMNOOBFDD))]
	public Task CHCDHEIAFLI(NCEFFCHHIAA PDMJGBFFFIO, CEBPIIBHMDD PLOCLAPJHEI, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2664880", Offset = "0x2663880", VA = "0x182664880")]
	[AsyncStateMachine(typeof(CHHPOOOGEHM))]
	private Task CBGMCJJHGBJ(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2664590", Offset = "0x2663590", VA = "0x182664590")]
	[AsyncStateMachine(typeof(EOIELHCABEE))]
	private Task AIMGLCCNLCM(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2664F70", Offset = "0x2663F70", VA = "0x182664F70")]
	[AsyncStateMachine(typeof(ALJAEEEFABO))]
	private Task JJMGLPHJIHA(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x26650D0", Offset = "0x26640D0", VA = "0x1826650D0")]
	[AsyncStateMachine(typeof(EJAMDBADOOL))]
	private Task MMFPLLFBKLC(Guid FMDINIPPGCM, List<BDIMKNBGBLH> KKIDGDBGMIN, POACONEMMLB JJCPHONCFHL, CEBPIIBHMDD PJDKPCLOECB, CancellationToken FDKCIGPLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2665530", Offset = "0x2664530", VA = "0x182665530")]
	[AsyncStateMachine(typeof(BADAFABKOHM))]
	private Task OJMHFABMPNM(CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2664E30", Offset = "0x2663E30", VA = "0x182664E30")]
	[AsyncStateMachine(typeof(EMJEOLPFHFC))]
	private Task HMOODFFEJHC(Guid HLAALDNPBCN, CEBPIIBHMDD PJDKPCLOECB, HKLBBGEFPMO MDGABGKAFDE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x26653E0", Offset = "0x26643E0", VA = "0x1826653E0")]
	[AsyncStateMachine(typeof(BGHFFHOIOAI))]
	private Task OJFHNFPGJJF(Guid HLAALDNPBCN, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x26646F0", Offset = "0x26636F0", VA = "0x1826646F0")]
	private void BDNLEMCJCHC(Guid HLAALDNPBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2664D10", Offset = "0x2663D10", VA = "0x182664D10")]
	private void GENENJPHLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2665210", Offset = "0x2664210", VA = "0x182665210")]
	public Guid NMDMBEBDCHO(NCEFFCHHIAA KJBKMBKFPBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x2664B40", Offset = "0x2663B40", VA = "0x182664B40")]
	[CompilerGenerated]
	private object FJFIOKGKPGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
public readonly struct EOLBBGGAHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	[CanBeNull]
	public readonly KHMOACGNIHJ DFBDCHCIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	[NotNull]
	public readonly List<string> HONCHCDFDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	[NotNull]
	public readonly Dictionary<long, int> EPNFGLOCNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	[CanBeNull]
	public readonly string POIMINLPJML;

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2662000", Offset = "0x2661000", VA = "0x182662000")]
	public EOLBBGGAHOM([CanBeNull] KHMOACGNIHJ DPFMLJHHCKP, [NotNull] List<string> FLAJGFCNKFA, [NotNull] Dictionary<long, int> HEOJHDMOIPM, [CanBeNull] string BLHPGIMDEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class NEFBNKJIAHN : LGPJJBHAAPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct ICMKKIHGMNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public AsyncTaskMethodBuilder<EOLBBGGAHOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public NEFBNKJIAHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public JLDDHJDNFNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x42AE9C0", Offset = "0x42AD9C0", VA = "0x1842AE9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x42AEE80", Offset = "0x42ADE80", VA = "0x1842AEE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class KNAJAGKHDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public JLDDHJDNFNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KNAJAGKHDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x42B0830", Offset = "0x42AF830", VA = "0x1842B0830")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class DGHMDHCHOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public KNAJAGKHDJC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DGHMDHCHOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x42AD100", Offset = "0x42AC100", VA = "0x1842AD100")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class FJPFHIOPGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public KNAJAGKHDJC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FJPFHIOPGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x42AD3F0", Offset = "0x42AC3F0", VA = "0x1842AD3F0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct MDBCFGMLECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public JLDDHJDNFNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public NEFBNKJIAHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private DGHMDHCHOCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private HLLPGMKMDGK.HMMIMJLPKBM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x42B2390", Offset = "0x42B1390", VA = "0x1842B2390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly DMNEAAIBMMH JBMKLDJAFIE;

	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private static readonly TimeSpan FFIOAFKMKNB;

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1B20", Offset = "0x2CA0B20", VA = "0x182CA1B20")]
	public NEFBNKJIAHN(NNICOEAPHFK LCGHMJPFPBL, [Optional] DMNEAAIBMMH? JBMKLDJAFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1030", Offset = "0x2CA0030", VA = "0x182CA1030")]
	[AsyncStateMachine(typeof(ICMKKIHGMNN))]
	public Task<EOLBBGGAHOM> HHDOHEHKDKI(long HKIDJEFCIOJ, string BLHPGIMDEGL, JLDDHJDNFNG LDPABPOPAML, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0ED0", Offset = "0x2C9FED0", VA = "0x182CA0ED0")]
	[AsyncStateMachine(typeof(MDBCFGMLECA))]
	private Task FCLJDJNIJCH(JLDDHJDNFNG LDPABPOPAML, IEnumerable<PersistenceView> JILIIJEPCJJ, StringBuilder NIHPBJNNIEJ, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0A80", Offset = "0x2C9FA80", VA = "0x182CA0A80")]
	private EOLBBGGAHOM BBOEKDIBFBJ(long HKIDJEFCIOJ, string BLHPGIMDEGL, JLDDHJDNFNG LDPABPOPAML, IEnumerable<PersistenceView> JILIIJEPCJJ, StringBuilder NIHPBJNNIEJ)
	{
		return default(EOLBBGGAHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1900", Offset = "0x2CA0900", VA = "0x182CA1900")]
	private KHMOACGNIHJ LAGOANAAOAJ(long HKIDJEFCIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2CA11B0", Offset = "0x2CA01B0", VA = "0x182CA11B0")]
	private void HMOOPMKLCCB(KHMOACGNIHJ BGGNDLOBKLP, StringBuilder NIHPBJNNIEJ, IEnumerable<PersistenceView> JILIIJEPCJJ, in BEOCLJBPFIA ELGPOOCMMCJ, ref AGLLAILKMMG MEIPCFLGHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2CA13D0", Offset = "0x2CA03D0", VA = "0x182CA13D0")]
	private void KHMNICICCOA(KHMOACGNIHJ BGGNDLOBKLP, StringBuilder NIHPBJNNIEJ, PersistenceView JJOFMICFAJO, ref AGLLAILKMMG MEIPCFLGHCE, in BEOCLJBPFIA ELGPOOCMMCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal class GMCAOOKJNNC : LGPJJBHAAPI
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class GFDMKHHKAON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CIJIGPEHFJD.AJEIOLHPDCM roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CIJIGPEHFJD.AJEIOLHPDCM subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GFDMKHHKAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x35CD0E0", Offset = "0x35CC0E0", VA = "0x1835CD0E0")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x35CD170", Offset = "0x35CC170", VA = "0x1835CD170")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x35CD1C0", Offset = "0x35CC1C0", VA = "0x1835CD1C0")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x35CD230", Offset = "0x35CC230", VA = "0x1835CD230")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct KPEONGEIHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder<(CIJIGPEHFJD.AJEIOLHPDCM roomDataUpload, CIJIGPEHFJD.AJEIOLHPDCM subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public EOLBBGGAHOM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public GMCAOOKJNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private GFDMKHHKAON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private TaskAwaiter<CIJIGPEHFJD.AJEIOLHPDCM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x35D2410", Offset = "0x35D1410", VA = "0x1835D2410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x35D2EC0", Offset = "0x35D1EC0", VA = "0x1835D2EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct OLPGPBLKMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public AsyncTaskMethodBuilder<DIJEGIOFGFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public GMCAOOKJNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public EOLBBGGAHOM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter<(CIJIGPEHFJD.AJEIOLHPDCM roomDataUpload, CIJIGPEHFJD.AJEIOLHPDCM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter<NMDEGDIDAOM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x35D66C0", Offset = "0x35D56C0", VA = "0x1835D66C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x35D6AA0", Offset = "0x35D5AA0", VA = "0x1835D6AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct FMOEBGLBABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder<HNOFBHJLOMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public GMCAOOKJNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public EOLBBGGAHOM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private TaskAwaiter<(CIJIGPEHFJD.AJEIOLHPDCM roomDataUpload, CIJIGPEHFJD.AJEIOLHPDCM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<HNOFBHJLOMI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x35CC670", Offset = "0x35CB670", VA = "0x1835CC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x35CCA00", Offset = "0x35CBA00", VA = "0x1835CCA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class EEDJNNCPCJD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			public EEDJNNCPCJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			private JKIDPKPPPFG <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			private TaskAwaiter<HNOFBHJLOMI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			private TaskAwaiter<DIJEGIOFGFI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			private TaskAwaiter<JKIDPKPPPFG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x42B9B60", Offset = "0x42B8B60", VA = "0x1842B9B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x42BA890", Offset = "0x42B9890", VA = "0x1842BA890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public GMCAOOKJNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public EOLBBGGAHOM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EEDJNNCPCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x35C9510", Offset = "0x35C8510", VA = "0x1835C9510")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JKIDPKPPPFG> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct GDBHPFBHABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder<JKIDPKPPPFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public GMCAOOKJNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public EOLBBGGAHOM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<JKIDPKPPPFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x35CCC20", Offset = "0x35CBC20", VA = "0x1835CCC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x35CCEC0", Offset = "0x35CBEC0", VA = "0x1835CCEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private const float DOBJCDHGLGC = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly FGOAJCHMBDH HPPHBGMILJH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CDJBHBCLHCD KOGPOBENDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x2668C30", Offset = "0x2667C30", VA = "0x182668C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2668C60", Offset = "0x2667C60", VA = "0x182668C60")]
	public GMCAOOKJNNC(NNICOEAPHFK LCGHMJPFPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2668930", Offset = "0x2667930", VA = "0x182668930")]
	[AsyncStateMachine(typeof(KPEONGEIHGL))]
	private Task<(CIJIGPEHFJD.AJEIOLHPDCM, CIJIGPEHFJD.AJEIOLHPDCM)> IDIKMEMDELG(EOLBBGGAHOM OMHBOKLKCMH, long BDNAKAPNAFM, long BGHODONOFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2668620", Offset = "0x2667620", VA = "0x182668620")]
	[AsyncStateMachine(typeof(OLPGPBLKMOM))]
	public Task<DIJEGIOFGFI> FLHNDJEEOBN(int KLGMAAJMFEI, EOLBBGGAHOM OMHBOKLKCMH, long BDNAKAPNAFM, long BGHODONOFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2668AA0", Offset = "0x2667AA0", VA = "0x182668AA0")]
	[AsyncStateMachine(typeof(FMOEBGLBABK))]
	private Task<HNOFBHJLOMI> KMDFBABBABL(string OJLDLNLLPIK, int KLGMAAJMFEI, EOLBBGGAHOM OMHBOKLKCMH, long BDNAKAPNAFM, long BGHODONOFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2668790", Offset = "0x2667790", VA = "0x182668790")]
	[AsyncStateMachine(typeof(GDBHPFBHABG))]
	public Task<JKIDPKPPPFG> GHPPFFFNHLI(int KLGMAAJMFEI, EOLBBGGAHOM OMHBOKLKCMH, long BDNAKAPNAFM, long BGHODONOFKO, HKLBBGEFPMO NMGDNGMBHAG, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class GJONLHCLILK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private readonly Guid IBJDBAKNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private readonly INKLMCGIFMP JMJPFKPCGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private CAOKGENDBMG PLNNMJAODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private int? GLBFGJDPHPI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Guid KLLKJJECHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2668560", Offset = "0x2667560", VA = "0x182668560")]
	public GJONLHCLILK(INKLMCGIFMP JMJPFKPCGJM, [Optional] Guid? IBJDBAKNBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x24B4DE0", Offset = "0x24B3DE0", VA = "0x1824B4DE0")]
	public GJONLHCLILK FGIIOFNAFFK(CAOKGENDBMG PLNNMJAODIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2668480", Offset = "0x2667480", VA = "0x182668480")]
	public JKIDPKPPPFG GAFPPKLKPOF(out Guid ANGDPHPDGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x26683F0", Offset = "0x26673F0", VA = "0x1826683F0")]
	public GJONLHCLILK ANKGNIMBABE(ODNOGOADEAI NLCFFNAAEHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public static class GGJNCJJEJBK
{
	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2667F30", Offset = "0x2666F30", VA = "0x182667F30")]
	public static NLKLCIGNEIJ MOGFOPNGKLB(this ANPPOCAMPKL MDHBBFHLKKH)
	{
		return default(NLKLCIGNEIJ);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public CJBJIFDGJEE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public CJBJIFDGJEE HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private static CJBJIFDGJEE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private Dictionary<CJBJIFDGJEE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA9F0", Offset = "0x2CA99F0", VA = "0x182CAA9F0")]
		public bool BOPHEHDJFDE(CJBJIFDGJEE DGGFKMKCEBJ, out ResultConfig LEPJIGHFGOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAA60", Offset = "0x2CA9A60", VA = "0x182CAAA60")]
		public ResultConfig KDOMHHBHEHC(CJBJIFDGJEE OGOCJGMDPHC, [Optional] HashSet<CJBJIFDGJEE> IGNLNEKGCFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB100", Offset = "0x2CAA100", VA = "0x182CAB100", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAB80", Offset = "0x2CA9B80", VA = "0x182CAAB80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xEE0200", Offset = "0xEDF200", VA = "0x180EE0200")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public static class EPMEDLBMHOG
{
	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x26621E0", Offset = "0x26611E0", VA = "0x1826621E0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.GameOnly)]
	private static void HKHPIAEGIMK(PCJIKNDFKDJ ICLFBGELBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public interface EHINBDMEHCH : IEquatable<EHINBDMEHCH>
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	DateTime IMHAKNHFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCGGKJNGHMK();

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GCIBCBEDPEN(long BDNAKAPNAFM, long HKIDJEFCIOJ, out EOLBBGGAHOM OMHBOKLKCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal class DFEIPIOPPKI : KMKFLCJMGIB
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class DIPIMNOECBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public PEAHMKADPMI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DIPIMNOECBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C94EC0", Offset = "0x2C93EC0", VA = "0x182C94EC0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private readonly LMCAMDAIPCH GABPBOPAGMG;

	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private const int FFJKADNKECK = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<EHINBDMEHCH> HIAGGGHFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x265F7D0", Offset = "0x265E7D0", VA = "0x18265F7D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x265FEC0", Offset = "0x265EEC0", VA = "0x18265FEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	[Preserve]
	public DFEIPIOPPKI([NBLPGINBDGI(null)] LMCAMDAIPCH GABPBOPAGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x265F9F0", Offset = "0x265E9F0", VA = "0x18265F9F0", Slot = "6")]
	public bool EHHHAKDHOHE(long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH, PEAHMKADPMI KMCOHECJCLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x265FF60", Offset = "0x265EF60", VA = "0x18265FF60")]
	private void KBKFCPFCKJB(EHINBDMEHCH LLHGAGNPGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x265F870", Offset = "0x265E870", VA = "0x18265F870", Slot = "7")]
	public bool BNCBLPGNDMA(long BDNAKAPNAFM, long HKIDJEFCIOJ, out EHINBDMEHCH JHJBCECDIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x265FCF0", Offset = "0x265ECF0", VA = "0x18265FCF0", Slot = "8")]
	public bool FNLIDPEHFAN(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, out EHINBDMEHCH JHJBCECDIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2660000", Offset = "0x265F000", VA = "0x182660000")]
	private void NHNOEFFFPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x265FDA0", Offset = "0x265EDA0", VA = "0x18265FDA0", Slot = "9")]
	public void GJKOALIJNKM(long BDNAKAPNAFM, long HKIDJEFCIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal abstract class ENCFDFOEOIO : LMCAMDAIPCH
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	protected enum LGKDMDPFECJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class GCOJPLMNHAA : IEnumerable<EHINBDMEHCH>, IEnumerable, IEnumerator<EHINBDMEHCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private EHINBDMEHCH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public ENCFDFOEOIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private PEAHMKADPMI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public PEAHMKADPMI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		private EHINBDMEHCH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public GCOJPLMNHAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C964D0", Offset = "0x2C954D0", VA = "0x182C964D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C966E0", Offset = "0x2C956E0", VA = "0x182C966E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C96630", Offset = "0x2C95630", VA = "0x182C96630", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EHINBDMEHCH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C96630", Offset = "0x2C95630", VA = "0x182C96630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class BNLFGFEFDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public PEAHMKADPMI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BNLFGFEFDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C91F10", Offset = "0x2C90F10", VA = "0x182C91F10")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class MAOADLGDMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public ENCFDFOEOIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MAOADLGDMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E170", Offset = "0x2C9D170", VA = "0x182C9E170")]
		internal void <TryReadAutosaveFile>b__0(MCJHPFJFACG.FCDDCEPDBEB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	protected readonly string JIGPHNNMLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private readonly object BHFBPJIKLPE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public abstract EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2661C30", Offset = "0x2660C30", VA = "0x182661C30")]
	protected ENCFDFOEOIO([CanBeNull] string BLMLIFKHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x26613A0", Offset = "0x26603A0", VA = "0x1826613A0", Slot = "5")]
	public bool GKDNBMDFGND(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, out EHINBDMEHCH LLHGAGNPGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2661320", Offset = "0x2660320", VA = "0x182661320", Slot = "6")]
	[IteratorStateMachine(typeof(GCOJPLMNHAA))]
	public IEnumerable<EHINBDMEHCH> AKDCKEMBHDP(PEAHMKADPMI KMCOHECJCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void NDNEKHFMJFO(Stream GIJHCOMADLP, long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool DNLJNCBABCO(Stream JEDDJIFPOFM, long BDNAKAPNAFM, long HKIDJEFCIOJ, FDINMIFKAAF PIOJBPIBJPJ, out EOLBBGGAHOM OMHBOKLKCMH);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2661580", Offset = "0x2660580", VA = "0x182661580", Slot = "7")]
	public EHINBDMEHCH HLELDLMDNNE(long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH, PEAHMKADPMI KMCOHECJCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo HOEJPMGOJGG(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NNIBNDEEDMH(PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x2661BC0", Offset = "0x2660BC0", VA = "0x182661BC0")]
	protected void LJBBCCNAPOL(MCJHPFJFACG.FCDDCEPDBEB NDFCFCPGJKP, string NLDGIOOAAAE, FileInfo IBIFMEKOMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x2661910", Offset = "0x2660910", VA = "0x182661910")]
	internal bool KGGKPHFAOCB(FileInfo DAKLFDBGKCP, long BDNAKAPNAFM, long HKIDJEFCIOJ, out EOLBBGGAHOM OMHBOKLKCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private void PPHGEKJLLAK(Exception DDKLCKNLJIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class KBDADMNBIMP : ENCFDFOEOIO
{
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private const string HJDMNEOJHJG = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private const string LAKHJDGMHFA = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private const string IJGHDFLBENK = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public override EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x128ACA0", Offset = "0x1289CA0", VA = "0x18128ACA0", Slot = "8")]
		get
		{
			return default(EHCNHDMIMKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x26740E0", Offset = "0x26730E0", VA = "0x1826740E0")]
	public KBDADMNBIMP([Optional] string BLMLIFKHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2673D00", Offset = "0x2672D00", VA = "0x182673D00")]
	private void JDNAMHNPIMJ(PEAHMKADPMI KMCOHECJCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2673D80", Offset = "0x2672D80", VA = "0x182673D80", Slot = "9")]
	internal override void NDNEKHFMJFO(Stream GIJHCOMADLP, long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x26735A0", Offset = "0x26725A0", VA = "0x1826735A0", Slot = "10")]
	internal override bool DNLJNCBABCO(Stream JEDDJIFPOFM, long BDNAKAPNAFM, long HKIDJEFCIOJ, FDINMIFKAAF PIOJBPIBJPJ, out EOLBBGGAHOM OMHBOKLKCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2673C10", Offset = "0x2672C10", VA = "0x182673C10", Slot = "11")]
	protected override FileInfo HOEJPMGOJGG(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x2673FD0", Offset = "0x2672FD0", VA = "0x182673FD0", Slot = "12")]
	protected override DirectoryInfo NNIBNDEEDMH(PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal sealed class CAICGPDPIOG : ENCFDFOEOIO
{
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private static readonly byte[] AGPLDPOAAIC;

	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private const string LAKHJDGMHFA = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private const string IJGHDFLBENK = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private const string FAOCGJFFFBH = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly byte[] KACNBKFMLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly byte[] ABANDBMBNAC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public override EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x704020", Offset = "0x703020", VA = "0x180704020", Slot = "8")]
		get
		{
			return default(EHCNHDMIMKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x265D5E0", Offset = "0x265C5E0", VA = "0x18265D5E0")]
	public CAICGPDPIOG([Optional] string BLMLIFKHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x265D1A0", Offset = "0x265C1A0", VA = "0x18265D1A0", Slot = "9")]
	internal override void NDNEKHFMJFO(Stream GIJHCOMADLP, long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x265C7D0", Offset = "0x265B7D0", VA = "0x18265C7D0", Slot = "10")]
	internal override bool DNLJNCBABCO(Stream JEDDJIFPOFM, long BDNAKAPNAFM, long HKIDJEFCIOJ, FDINMIFKAAF PIOJBPIBJPJ, out EOLBBGGAHOM OMHBOKLKCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x265C6C0", Offset = "0x265B6C0", VA = "0x18265C6C0")]
	private void CNCIDGFGBFJ(byte[] CDDAIIMDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x265D070", Offset = "0x265C070", VA = "0x18265D070", Slot = "11")]
	protected override FileInfo HOEJPMGOJGG(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x265D440", Offset = "0x265C440", VA = "0x18265D440", Slot = "12")]
	protected override DirectoryInfo NNIBNDEEDMH(PEAHMKADPMI KMCOHECJCLH, LGKDMDPFECJ MPOKOFKODKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public enum EHCNHDMIMKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class JPBJAIEHBPB : LMCAMDAIPCH
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class BJALAJOOAAO : IEnumerable<EHINBDMEHCH>, IEnumerable, IEnumerator<EHINBDMEHCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private EHINBDMEHCH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public JPBJAIEHBPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private PEAHMKADPMI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public PEAHMKADPMI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private EHCNHDMIMKN[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerator<EHINBDMEHCH> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private EHINBDMEHCH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public BJALAJOOAAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x35C7470", Offset = "0x35C6470", VA = "0x1835C7470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x35C70A0", Offset = "0x35C60A0", VA = "0x1835C70A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x35C7500", Offset = "0x35C6500", VA = "0x1835C7500")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x35C7430", Offset = "0x35C6430", VA = "0x1835C7430", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x35C7380", Offset = "0x35C6380", VA = "0x1835C7380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EHINBDMEHCH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x35C7380", Offset = "0x35C6380", VA = "0x1835C7380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly EHCNHDMIMKN[] GLEJIIPJMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly Dictionary<EHCNHDMIMKN, LMCAMDAIPCH> IPNLBJHDDMH;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2672ED0", Offset = "0x2671ED0", VA = "0x182672ED0", Slot = "4")]
		get
		{
			return default(EHCNHDMIMKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2673230", Offset = "0x2672230", VA = "0x182673230")]
	[Preserve]
	public JPBJAIEHBPB(params LMCAMDAIPCH[] KHOGCEJDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2672D70", Offset = "0x2671D70", VA = "0x182672D70", Slot = "5")]
	public bool GKDNBMDFGND(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, out EHINBDMEHCH LLHGAGNPGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2673000", Offset = "0x2672000", VA = "0x182673000")]
	private void IEHOLGLLGKC(int DPFBADPFCKM, long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2672CF0", Offset = "0x2671CF0", VA = "0x182672CF0", Slot = "6")]
	[IteratorStateMachine(typeof(BJALAJOOAAO))]
	public IEnumerable<EHINBDMEHCH> AKDCKEMBHDP(PEAHMKADPMI KMCOHECJCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2672F10", Offset = "0x2671F10", VA = "0x182672F10", Slot = "7")]
	public EHINBDMEHCH HLELDLMDNNE(long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH, PEAHMKADPMI KMCOHECJCLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal static class AJFJJHMCIHO
{
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	internal const int GOOLDCHGELG = 32;

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x26556B0", Offset = "0x26546B0", VA = "0x1826556B0")]
	internal static byte[] JKKOFKOKGPK(byte[] CDDAIIMDJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x2655450", Offset = "0x2654450", VA = "0x182655450")]
	public static void AJKACGJCJCA(Stream JMJPBBLODJI, byte[] DKLICIBILIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x26554D0", Offset = "0x26544D0", VA = "0x1826554D0")]
	public static bool BCCNAGCCDBB(Stream JMJPBBLODJI, long OGLMHCAEOGN, FDINMIFKAAF LECDDPNNJAA, out byte[] LDCKNLMAHHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal sealed class BHNHCLFIOLM : EHINBDMEHCH, IEquatable<EHINBDMEHCH>, IEquatable<BHNHCLFIOLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly ENCFDFOEOIO EBKCKNIGKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	public readonly FileInfo IOFEELEJPEI;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C30", Offset = "0x9F4C30", VA = "0x1809F5C30", Slot = "4")]
		get
		{
			return default(EHCNHDMIMKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DateTime IMHAKNHFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x265B8F0", Offset = "0x265A8F0", VA = "0x18265B8F0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x265BDB0", Offset = "0x265ADB0", VA = "0x18265BDB0")]
	public BHNHCLFIOLM(ENCFDFOEOIO NFGPILFKGIP, FileInfo DAKLFDBGKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x265BD00", Offset = "0x265AD00", VA = "0x18265BD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x265B830", Offset = "0x265A830", VA = "0x18265B830", Slot = "6")]
	public void BCGGKJNGHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x265BC20", Offset = "0x265AC20", VA = "0x18265BC20", Slot = "7")]
	public bool GCIBCBEDPEN(long BDNAKAPNAFM, long HKIDJEFCIOJ, out EOLBBGGAHOM OMHBOKLKCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x265BB40", Offset = "0x265AB40", VA = "0x18265BB40", Slot = "8")]
	public bool Equals(EHINBDMEHCH IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x265BA90", Offset = "0x265AA90", VA = "0x18265BA90", Slot = "9")]
	public bool Equals(BHNHCLFIOLM IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x265B990", Offset = "0x265A990", VA = "0x18265B990", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x265BC60", Offset = "0x265AC60", VA = "0x18265BC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x1749EF0", Offset = "0x1748EF0", VA = "0x181749EF0")]
	public static bool CGFEPDNGNBJ(BHNHCLFIOLM CIMDKEEFACC, BHNHCLFIOLM LAFBLOLJEPD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x174A3B0", Offset = "0x17493B0", VA = "0x18174A3B0")]
	public static bool NODBGCCFDAJ(BHNHCLFIOLM CIMDKEEFACC, BHNHCLFIOLM LAFBLOLJEPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public delegate void FDINMIFKAAF(MCJHPFJFACG.FCDDCEPDBEB KAEODBEPFAO, string NJAIIGFCHNG);
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal interface LMCAMDAIPCH
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	EHCNHDMIMKN GCNKELIPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKDNBMDFGND(long BDNAKAPNAFM, long HKIDJEFCIOJ, PEAHMKADPMI KMCOHECJCLH, out EHINBDMEHCH LLHGAGNPGHM);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<EHINBDMEHCH> AKDCKEMBHDP(PEAHMKADPMI KMCOHECJCLH);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHINBDMEHCH HLELDLMDNNE(long BDNAKAPNAFM, long HKIDJEFCIOJ, EOLBBGGAHOM OMHBOKLKCMH, PEAHMKADPMI KMCOHECJCLH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x265A760", Offset = "0x2659760", VA = "0x18265A760")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x265A870", Offset = "0x2659870", VA = "0x18265A870")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000666")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
