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
public class NCBBMPDFIAB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x30A96E0", Offset = "0x30A8AE0", VA = "0x1830A96E0")]
	public NCBBMPDFIAB(string HKDHNKHPGDP, Exception LMCHKJEEINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class NENIDCKJJAF : FFLAHDJLGCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BHCMIGNACFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ELHGAJBONGN>> <>t__builder;

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
		private TaskAwaiter<global::IIIGNJABNAF<ELHGAJBONGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2C00", Offset = "0x3DD2000", VA = "0x183DD2C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2DE0", Offset = "0x3DD21E0", VA = "0x183DD2DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LJDJHADCLOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LDKIDNMHABB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<LDKIDNMHABB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBB70", Offset = "0x3DDAF70", VA = "0x183DDBB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBD30", Offset = "0x3DDB130", VA = "0x183DDBD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	[Preserve]
	public NENIDCKJJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x30AB7B0", Offset = "0x30AABB0", VA = "0x1830AB7B0", Slot = "4")]
	[AsyncStateMachine(typeof(BHCMIGNACFD))]
	public Task<IReadOnlyList<ELHGAJBONGN>> EACJPPLFHPE(long CNEPCDGFLLD, long FOCJCCBGAFG, [Optional] CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30AB900", Offset = "0x30AAD00", VA = "0x1830AB900", Slot = "5")]
	[AsyncStateMachine(typeof(LJDJHADCLOL))]
	public Task<IReadOnlyList<LDKIDNMHABB>> MGNEMLHECKO(IReadOnlyList<int> HDJONOAJONC, [Optional] CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EPALDEBNBPO : IEquatable<EPALDEBNBPO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KBOMHMKKMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LDKIDNMHABB DLNNIHEAEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HPICEBGAHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PFMBKIGEGDG? EALBOFEAEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HFPGNFBOBEF? JMAHAODLAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	CLODAEADCEK PCHILEPPLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MBCHBOFNLBC> OKDCNAEEDPD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CLODAEADCEK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FFLAHDJLGCH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ELHGAJBONGN>> EACJPPLFHPE(long CNEPCDGFLLD, long FOCJCCBGAFG, [Optional] CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LDKIDNMHABB>> MGNEMLHECKO(IReadOnlyList<int> HDJONOAJONC, [Optional] CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MNFOKOLPLFM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class MBPEPKHANHC : EPALDEBNBPO, IEquatable<EPALDEBNBPO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct EEPNEBCMNFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MBPEPKHANHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private IIHLOMNOCIN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PPFCGBHBMGI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<MBCHBOFNLBC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3DD40E0", Offset = "0x3DD34E0", VA = "0x183DD40E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4570", Offset = "0x3DD3970", VA = "0x183DD4570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ELHGAJBONGN KENMKBFJNNB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int KBOMHMKKMNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LDKIDNMHABB DLNNIHEAEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime NPNIJDGBBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x128EB60", Offset = "0x128DF60", VA = "0x18128EB60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PFMBKIGEGDG? EALBOFEAEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D76A0", Offset = "0x8D6AA0", VA = "0x1808D76A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HFPGNFBOBEF? JMAHAODLAAC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D7660", Offset = "0x8D6A60", VA = "0x1808D7660", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CLODAEADCEK PCHILEPPLLO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x693AA0", Offset = "0x692EA0", VA = "0x180693AA0", Slot = "10")]
			get
			{
				return default(CLODAEADCEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBF80", Offset = "0x3DDB380", VA = "0x183DDBF80", Slot = "9")]
		[AsyncStateMachine(typeof(EEPNEBCMNFC))]
		public Task<MBCHBOFNLBC> OKDCNAEEDPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC0B0", Offset = "0x3DDB4B0", VA = "0x183DDC0B0")]
		public MBPEPKHANHC(int NBGNAADLNHM, LDKIDNMHABB IDNDHGGPLJK, ELHGAJBONGN KENMKBFJNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBD80", Offset = "0x3DDB180", VA = "0x183DDBD80", Slot = "11")]
		public bool Equals(EPALDEBNBPO BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBE10", Offset = "0x3DDB210", VA = "0x183DDBE10", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBF40", Offset = "0x3DDB340", VA = "0x183DDBF40")]
		private bool LPJNCCAEBKD(MBPEPKHANHC BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBEB0", Offset = "0x3DDB2B0", VA = "0x183DDBEB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class PAGLICCCDMK : EPALDEBNBPO, IEquatable<EPALDEBNBPO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct EFAGHKIMCMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public PAGLICCCDMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<MBCHBOFNLBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3DD45C0", Offset = "0x3DD39C0", VA = "0x183DD45C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4800", Offset = "0x3DD3C00", VA = "0x183DD4800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MDLACFNPHOC JMHHMGMBHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly PFMBKIGEGDG GNNAHPDOGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HFPGNFBOBEF NOBDMOKNMED;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int KBOMHMKKMNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD180", Offset = "0x3DDC580", VA = "0x183DDD180", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LDKIDNMHABB DLNNIHEAEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3DDCF90", Offset = "0x3DDC390", VA = "0x183DDCF90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime NPNIJDGBBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD2B0", Offset = "0x3DDC6B0", VA = "0x183DDD2B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PFMBKIGEGDG? EALBOFEAEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD260", Offset = "0x3DDC660", VA = "0x183DDD260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HFPGNFBOBEF? JMAHAODLAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3DDCF40", Offset = "0x3DDC340", VA = "0x183DDCF40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CLODAEADCEK PCHILEPPLLO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6882A0", Offset = "0x6876A0", VA = "0x1806882A0", Slot = "10")]
			get
			{
				return default(CLODAEADCEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x712D10", Offset = "0x712110", VA = "0x180712D10")]
		public PAGLICCCDMK(MDLACFNPHOC FJKNLEFOLCN, PFMBKIGEGDG BDHODENBKID, HFPGNFBOBEF MJMIDEBAKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD360", Offset = "0x3DDC760", VA = "0x183DDD360", Slot = "9")]
		[AsyncStateMachine(typeof(EFAGHKIMCMI))]
		public Task<MBCHBOFNLBC> OKDCNAEEDPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD0E0", Offset = "0x3DDC4E0", VA = "0x183DDD0E0", Slot = "11")]
		public bool Equals(EPALDEBNBPO BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD030", Offset = "0x3DDC430", VA = "0x183DDD030", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD300", Offset = "0x3DDC700", VA = "0x183DDD300")]
		private bool LPJNCCAEBKD(PAGLICCCDMK BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD1D0", Offset = "0x3DDC5D0", VA = "0x183DDD1D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HMCJPOMHDGA : EPALDEBNBPO, IEquatable<EPALDEBNBPO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct FKMMCBANHLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<MBCHBOFNLBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD5FF0", Offset = "0x3DD53F0", VA = "0x183DD5FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD61D0", Offset = "0x3DD55D0", VA = "0x183DD61D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly LDKIDNMHABB GCCFAEJCPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PFMBKIGEGDG GNNAHPDOGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HFPGNFBOBEF NOBDMOKNMED;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int KBOMHMKKMNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7A70", Offset = "0x3DD6E70", VA = "0x183DD7A70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LDKIDNMHABB DLNNIHEAEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime NPNIJDGBBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PFMBKIGEGDG? EALBOFEAEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7BA0", Offset = "0x3DD6FA0", VA = "0x183DD7BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HFPGNFBOBEF? JMAHAODLAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7790", Offset = "0x3DD6B90", VA = "0x183DD7790", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CLODAEADCEK PCHILEPPLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "10")]
			get
			{
				return default(CLODAEADCEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x712D10", Offset = "0x712110", VA = "0x180712D10")]
		public HMCJPOMHDGA(LDKIDNMHABB IDNDHGGPLJK, PFMBKIGEGDG BDHODENBKID, HFPGNFBOBEF MJMIDEBAKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7CF0", Offset = "0x3DD70F0", VA = "0x183DD7CF0", Slot = "9")]
		[AsyncStateMachine(typeof(FKMMCBANHLD))]
		public Task<MBCHBOFNLBC> OKDCNAEEDPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7930", Offset = "0x3DD6D30", VA = "0x183DD7930", Slot = "11")]
		public bool Equals(EPALDEBNBPO BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD77E0", Offset = "0x3DD6BE0", VA = "0x183DD77E0", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7AF0", Offset = "0x3DD6EF0", VA = "0x183DD7AF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7BF0", Offset = "0x3DD6FF0", VA = "0x183DD7BF0")]
		private bool LPJNCCAEBKD(HMCJPOMHDGA BKBGGIICJOJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PJNAEACMGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<EPALDEBNBPO>> <>t__builder;

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
		public MNFOKOLPLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<ELHGAJBONGN> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<ELHGAJBONGN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LDKIDNMHABB account, ELHGAJBONGN roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD4B0", Offset = "0x3DDC8B0", VA = "0x183DDD4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDF40", Offset = "0x3DDD340", VA = "0x183DDDF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AABEJIOLPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LDKIDNMHABB account, ELHGAJBONGN roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<ELHGAJBONGN> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MNFOKOLPLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<LDKIDNMHABB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1970", Offset = "0x3DD0D70", VA = "0x183DD1970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22F0", Offset = "0x3DD16F0", VA = "0x183DD22F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FHOHBFOGJEL CBMNELEJLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FFLAHDJLGCH CLJECHKJNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MBDLGBBNDBG GPCLDAGBELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::BILPELMLBHE<(long, long), IReadOnlyList<ELHGAJBONGN>> LDJIEJNLHNN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x30A8740", Offset = "0x30A7B40", VA = "0x1830A8740")]
	[Preserve]
	public MNFOKOLPLFM([FFFBKAEBNFI(null)] FFLAHDJLGCH NBAHGIGENBN, [FFFBKAEBNFI(null)] MBDLGBBNDBG GKNOADDCHDP, [FFFBKAEBNFI(null)] FHOHBFOGJEL NGPEMOJEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x30A82A0", Offset = "0x30A76A0", VA = "0x1830A82A0")]
	[AsyncStateMachine(typeof(PJNAEACMGJC))]
	public Task<IList<EPALDEBNBPO>> BLELNJBKDJH(long CNEPCDGFLLD, long EBLMJJHFMLK, bool BNFFFPMGIAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x30A83F0", Offset = "0x30A77F0", VA = "0x1830A83F0")]
	private bool EKGKNMBEOKM(DateTime? KMCDCKKKALN, long CNEPCDGFLLD, long EBLMJJHFMLK, out MDLACFNPHOC MEEMHAEBANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x30A8600", Offset = "0x30A7A00", VA = "0x1830A8600")]
	[AsyncStateMachine(typeof(AABEJIOLPJK))]
	private Task<IReadOnlyList<(int, LDKIDNMHABB, ELHGAJBONGN)>> LLDLPEFCLOA(IReadOnlyList<ELHGAJBONGN> GBAPOEABIEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MBDLGBBNDBG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MDLACFNPHOC> OBLALEEPAMJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHALJANENEN(long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO, JBMIEGHLKOB FBNDPLHPLDD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OMNCEAEFKGP(long CNEPCDGFLLD, long EBLMJJHFMLK, out MDLACFNPHOC MEEMHAEBANK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDMLNHLJGMD(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, out MDLACFNPHOC MEEMHAEBANK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPIDFAMGPGB(long CNEPCDGFLLD, long EBLMJJHFMLK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface PIIDEFHEMHD : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JKFFEFPEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GEJHOOLODGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIMNJKMMHNJ(Task NNCIDDBLNEH, string FMHLMEKNGOH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface GHOMLIGBKLE : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBCHBOFNLBC> IJCGCGLOMED(MDLACFNPHOC MEEMHAEBANK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BELAPHGJMMP(CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface IMICIHFHHPC : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AFIMMDDEDJL MGAHKMBMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIKMNBPBFLB();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOMFIPIJMFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface CEPAAGHMMNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface BHIMLHNCAAO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan MCDCBNGILPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DFJOFFBEPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LKGMEICNKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan FGNMOELODAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LGJEOCHPFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BPNKPNOCAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EALDBJDNJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DJOAKIKLOHO
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FDEFPHIAOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly long JKGHLPEJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly long FOCJCCBGAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly DJOAKIKLOHO NLAFPPIOFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[CanBeNull]
	public readonly Exception DDIELBMNBDC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26EC450", Offset = "0x26EB850", VA = "0x1826EC450")]
	public FDEFPHIAOMP(long JKGHLPEJDPA, long FOCJCCBGAFG, DJOAKIKLOHO NLAFPPIOFPG, [CanBeNull] Exception DDIELBMNBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26EC400", Offset = "0x26EB800", VA = "0x1826EC400")]
	public static FDEFPHIAOMP BEIKDICPIGL(NOOLKJHEPHD KEJAKMEBEOG, DJOAKIKLOHO NLAFPPIOFPG, [Optional] Exception DDIELBMNBDC)
	{
		return default(FDEFPHIAOMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate void JIHAFOFPEBP(FDEFPHIAOMP NCEBCFEJMFE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface EFMFLFDJPID : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LBCLHFBEDDG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JIHAFOFPEBP CKIBMJEMPJH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JIHAFOFPEBP EKIGDMAKIPI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JIHAFOFPEBP OPDOILBBFAC;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIJOBPJMBLO();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOCGJOINAGI(FDEFPHIAOMP NCEBCFEJMFE);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMFNMBAAMIF(FDEFPHIAOMP NCEBCFEJMFE);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NABCNCKJAMJ(FDEFPHIAOMP NCEBCFEJMFE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface DIHIMOFKLMB : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OEHHDOOOIED();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGOOONMIKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMHHKPCNIEA();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate Task HPNMAGPCOBO(HHPEKJGCIPO OAGMMIBDFHK, CancellationToken PFJMMABJIDH);
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal interface GCCAPKMMMFN : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GFIANLNOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HOACFGMPDAF(HPNMAGPCOBO NKAPDINFNGO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface EFIAGMDFPMO : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus HFODNOKMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HGHIBGHMDPO(NOOLKJHEPHD BGEDADFIFAH, CancellationToken DAOHELLFNHN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal static class NGAOJCEAECC
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x30ABB40", Offset = "0x30AAF40", VA = "0x1830ABB40")]
	public static bool JGOJPGAEJJH(this EFIAGMDFPMO EDHPAAKKJBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface FPCHIGOFPMO : IIHLOMNOCIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken EOGIKLLDFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	KADOJAOKIOP PODKGNKAKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	KJAOGEMHFFI NBPELOPMJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IKBEKAKNNEB HADKCCODHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	BDINODBONOA HOFBPANMFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ELDJNEHEPGE POMAAPLKBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GPKLPECHMBG LINGJFOMHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICDNBDFBHJC FHGAJNGAPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PIIDEFHEMHD HDGKJNFBHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GHOMLIGBKLE NBJCNDOIAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EFMFLFDJPID JGHPJNIOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DIHIMOFKLMB PPEHNILGFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EFIAGMDFPMO GOOBABBEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GCCAPKMMMFN BLHKCCHGODI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BKDPNJBIPHM HPOKANGOOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EDBOLGEKJAL IFLMCKLMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PFBMOKBFJIA GOAOIIHMDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OCFOCANBIME GPJEFEOKACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KMGHEMCDCDI GMJABFNHDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KFIEMLFNNDD LMBHLMOBKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NOHKAKDEFCM BPBHOKKCNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ILLDAFMFAGC MPGJHPPOBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LAJNCLCNNBF EOPBDAAGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NABFEJHBFAL OHHMOIGKOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NMKDHCIGEMM NAKNAKIKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IMICIHFHHPC GELMMCFIHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BHIMLHNCAAO OEOLBMDEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OGANKBGIOGD ONGFIOKFLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MBDLGBBNDBG OPOCFFDHLPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface BKDPNJBIPHM : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILACOLNCBHO EIPAABBBFMM(Guid OEFPMGEGBHM);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMLJNDAKNDK(Guid OEFPMGEGBHM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCNLMAALNPC(Guid OEFPMGEGBHM, Task CJMBGOGJKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMOGGGAAJDF(Guid OEFPMGEGBHM, MBCHBOFNLBC GAMGHBOCBGN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LMHHKPCNIEA(Guid OEFPMGEGBHM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(MBCHBOFNLBC, Task)> IPCIMPHFPNF(Guid OEFPMGEGBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface EDBOLGEKJAL : CEPAAGHMMNN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface PFBMOKBFJIA : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNLJLKDLDKK(IMHJALLFDIF HKDHNKHPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNMFFPBJFHI(IMHJALLFDIF HKDHNKHPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CKCMKMGEMBD> CHPDBBGJMAH(CancellationToken NKHEKKGIDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate MBCHBOFNLBC OMKLOLKKLNM(NEDBMOFEKBM MOAPJAIPHJJ, CKCMKMGEMBD IBAOIPLKGIH);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface OCFOCANBIME : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILACOLNCBHO BDLINAFAMOP(IMHJALLFDIF BLGEFGMAFMO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFPPEFOOGAF(Guid OEFPMGEGBHM, Task CJMBGOGJKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface KMGHEMCDCDI : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBCHBOFNLBC> GMJABFNHDKN(IMHJALLFDIF GEIPBHHAELC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KFIEMLFNNDD : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GNGDEKNEGGO> PIKEKPJGJCE(LHKKDNHCKDD DIECPHHHGGG, NOOLKJHEPHD BGEDADFIFAH, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GNGDEKNEGGO BLDFLOEEBDP(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ, long EBLMJJHFMLK, [Optional] ELHGAJBONGN GJPMIKNGABI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GNGDEKNEGGO LJNNMHLFOJJ(NOOLKJHEPHD BGEDADFIFAH, CIJJEIINFMP JCMKBEDCDJL, long EBLMJJHFMLK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GNGDEKNEGGO BLADDHDEMFN(long JKGHLPEJDPA, long EBLMJJHFMLK, string IJBOACAPDKG, string BCPIELJKEFM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface ILLDAFMFAGC : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBCHBOFNLBC POPPKKBLLMO(NEDBMOFEKBM MOAPJAIPHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LLOGLCFIMGH(string BABJIPJIPPC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NOHKAKDEFCM : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMHJALLFDIF> HMKEIBGDPBO(IMHJALLFDIF DKKNMPCNGDF, LAPCKNIDAJE KLOAKFGNLBJ, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IMHJALLFDIF> IPIFBDBOPLN(CancellationToken BJBDGBAHFDE, LAPCKNIDAJE KLOAKFGNLBJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NECOACPILOL BNILOPCJEIH(MAJJLPEKFOI PFHIIMADCMF, LHKKDNHCKDD DIECPHHHGGG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NECOACPILOL OKIAINKPION(MAJJLPEKFOI PFHIIMADCMF, LHKKDNHCKDD DIECPHHHGGG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LAJNCLCNNBF : CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBCHBOFNLBC FECJMKCIPNK(NEDBMOFEKBM MOAPJAIPHJJ, CKCMKMGEMBD IBAOIPLKGIH);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBCHBOFNLBC LEKEFGHDCPJ(NEDBMOFEKBM MCCCJGDFKAO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBCHBOFNLBC JLPFKBLKMGM(NEDBMOFEKBM MCCCJGDFKAO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NABFEJHBFAL
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFOGGKOCOHK(ONBEOAFGDGI MHDFGNJLPCA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDBHIMPIKJI(ONBEOAFGDGI MHDFGNJLPCA);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDCIGIJLFGI(ONBEOAFGDGI MHDFGNJLPCA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMEHCAGGDIM(ONBEOAFGDGI MHDFGNJLPCA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ONBEOAFGDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly NOOLKJHEPHD FAKFMMMOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Dictionary<string, string> ABLBDPGHEFG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::HLIIJDKEIIJ<string> LEBIGENEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	public ONBEOAFGDGI(NOOLKJHEPHD ELGKGHJLIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x30ADE10", Offset = "0x30AD210", VA = "0x1830ADE10")]
	public ONBEOAFGDGI HHBHFDKANCH(string MPIADBGKNBD, string PKODKJLGOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x30ADD90", Offset = "0x30AD190", VA = "0x1830ADD90")]
	public bool FNIKMKOFGBK(out IEnumerable<KeyValuePair<string, string>> EMFOEBIBEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2647400", Offset = "0x2646800", VA = "0x182647400")]
	public ONBEOAFGDGI BMMMNDNOLCK(global::HLIIJDKEIIJ<string> PPFBACEKDKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OGANKBGIOGD
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool HIHLNDGAAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string OMCLDPGPGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHGOLHNPHBO();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LKMFCGHDGCH KIIMKELKONG(long FBGCBCPICFF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::KEPNPHPFCLL<ECIBCEENAKM, HHNDJGNKLNP> JBNDACNAGCK(long FBGCBCPICFF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::KEPNPHPFCLL<ECIBCEENAKM, NDKLHPOCFKB> AIPDIKNHOEI(long FBGCBCPICFF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::KEPNPHPFCLL<long, KHPPIANMGIJ> JGIOELIEENK();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MNHMJPFACBH(long FBGCBCPICFF, out string BCPIELJKEFM, out string IJBOACAPDKG, out ECIBCEENAKM POJODMCODKB, out ECIBCEENAKM BLMFGCGNMBG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AAMLCEGHBLD(GNGDEKNEGGO DKKNMPCNGDF, long FBGCBCPICFF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> NAMAGAJODHH(long FBGCBCPICFF, byte[] POJODMCODKB, byte[] BLMFGCGNMBG, CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IIHLOMNOCIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool JGOJPGAEJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AMACBDNJDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task IEPKFMACALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action LBCLHFBEDDG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JIHAFOFPEBP CKIBMJEMPJH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JIHAFOFPEBP EKIGDMAKIPI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JIHAFOFPEBP OPDOILBBFAC;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NGOOONMIKAJ();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JAOJILANMJO JMOKFMDLILP();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FJHKEBJJBNN DAICCEMJBKE();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<MBCHBOFNLBC> IJCGCGLOMED(MDLACFNPHOC FJKNLEFOLCN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task BELAPHGJMMP(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GNGDEKNEGGO BLDFLOEEBDP(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ, long EBLMJJHFMLK, [Optional] ELHGAJBONGN GJPMIKNGABI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BDINODBONOA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ABGDLDEMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string NGKMPINNFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGLENKLKHDB(Scene HEJENALABEO);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KJHODBLGBAL(PEMFLNHGAAN OIFHLNFMHHA, CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EPHHKFIEIIF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int DDIHFKCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OBFJJGANDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JBLGELOGBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HKNENKFFLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MANJFEMDCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NAAOOMENNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	NEDBMOFEKBM OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool APOCNDFGNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KADOJAOKIOP BFGFDICBKPF(KADOJAOKIOP OFOGKENOHNN);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIIPGOOJBLC(KADOJAOKIOP PKBPIIAEHNA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OKMDKDKIOIL(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NHJHMDIPGNF(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task NBHPCPKNOMF(GLHKEBEIDMK MHLBJBFFDIN, [Optional] CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JBLALJIEEGI(float EOMJAOEKNIN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HNJOPMBAFCD(string LFLHOJABIBN);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<GOCNKMNKIHO> LEGPLDIKEEG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable ANFAJNHHOND(object IDEIPFIOJKJ, GOCNKMNKIHO CGBBOLOKPIC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HHNDJGNKLNP NKBCHJAFHMC();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DACCPNIOIBI(int JKGGJOMPBJI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OHBDDFLEBFM();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FMGNMJBDAFL();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool BBMJFEFLOJM();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task AALKOAMICPD(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task BIABOPDGGKJ(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<GLEEKLMEDAL> FMFJDJLHLCD(DateTime BDIFADIFJLH, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> MCJDEHJJJJK(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MLLLGKMKBKE();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BADFCIOHMAF OACCAIIHNBC(LEAJJDOJJEL IBEHNPLFNDP, NDKLHPOCFKB KIOJNOPCCAB, IEnumerable<PersistenceView> GIIMCCIMEHG, ref ONOHHLKFPBO BPBNFHOEFMO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KCPKEHKDDNP(FOOKLNINPMB MJNMHGGCEGG, in BADFCIOHMAF APKCPEDKOCI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DMLOOIELAJK(NDKLHPOCFKB AKDLLELODCG, bool ENCGCANEJFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IJAINPNIJEO();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NDHMKOBFBNP(long CNEPCDGFLLD, long FOCJCCBGAFG, PPFCGBHBMGI IKLHFPDBLDD, NGOHFOABHJO NGILCOFMNJO);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FBGHLILNNDL(long CNEPCDGFLLD, long FOCJCCBGAFG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PEHPDAGCCOB(PersistenceView EANOPFGFIMO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool HKKEBPLCKEB(PersistenceView ODDIKGOJDNI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MEFHAFMGONA(FOOKLNINPMB MJNMHGGCEGG, HLMHFEDKGND KDNLBPGKEEE, out FJMOJEGFIEJ JKBIHMAIMIM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void JJLIPBJGIFB();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void PBOKNKBIHCI();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable PLJMGHGLMOA();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PJEKCGKHFHB(NDKLHPOCFKB AKDLLELODCG, HLMHFEDKGND KDNLBPGKEEE);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> LHCKKLOOABL(KJAOGEMHFFI MBEKPBENMJL, CancellationToken BJBDGBAHFDE, LHKKDNHCKDD DIECPHHHGGG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PLHDMFOFOHP(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<LHBMFFMOHEL> NPAMDKEENCD(long CNEPCDGFLLD, long FOCJCCBGAFG, string IJBOACAPDKG, NDPLAKFEGGD.NNCGIFFCBLI OAGMMIBDFHK, NDPLAKFEGGD.NNCGIFFCBLI BLMFGCGNMBG, IReadOnlyDictionary<long, int> DJDBGOFEFOD, int PHGIGJNNMFK, string AGPEBKEGJED, bool KNJBNDFGHDD, int LIJKHGEBFLO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<CIJJEIINFMP> CGEKOPBDKEO(string BCPIELJKEFM, long CNEPCDGFLLD, long FOCJCCBGAFG, string IJBOACAPDKG, NDPLAKFEGGD.NNCGIFFCBLI OAGMMIBDFHK, NDPLAKFEGGD.NNCGIFFCBLI BLMFGCGNMBG, int IMBPHKGBKCB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PPFCGBHBMGI> DODKLEOHFJB(long CNEPCDGFLLD, bool HCEKABOPLBJ, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GPNMNEOAFDK();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool JMGOIOLHGIN();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool FGCDMJBLHGH(IEnumerable<FJMOJEGFIEJ> BDHPJBBDACE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BBBGCCKIEEL(List<GameObject> NCEGHNNPKKD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float HADHFIALOPH();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KOONIBMCJKH(string LPEACJMIECH, out Scene ENNCIIPAJMI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> ECLGGMIJDOJ(string LPEACJMIECH, LoadSceneMode JKCOGAOFGKL, bool EHABFADPPIF, LHKKDNHCKDD PPFBACEKDKI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void AIAAOAHDJIE();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool LLHNJCOLKBJ(ByteString NBOKDDEOMCP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void AKFBDNFNLAM(NOOLKJHEPHD DEHCJGBGEKN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task PGDFPNCCHNC(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task PHKGAHMOECB(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BDHNOCLHOBC();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable PINPGOJKEAM();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	LOPIEFEEJGH PJKADOKBNAD();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LOPIEFEEJGH
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BAMLMKPNNHH(CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PBGDLDKBJPC(CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BADFCIOHMAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public HashSet<int> AEGHDPHJMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IDisposable LHNMPOHMNBI;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x26DC220", Offset = "0x26DB620", VA = "0x1826DC220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum GLEEKLMEDAL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CJENJMNHIKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	NOOLKJHEPHD GNELKINBHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	PPFCGBHBMGI FDLBGJGMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	MNBEONNOJCM GGAAKPOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GDGMHBNCFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool HIIBIAODAII
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int DDIHFKCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action NGGPONAALPB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<int> LLECGGPAHAM;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBEIJJNFDEF();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.GBMOFJPEHIH> GMBFDMIOHLB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OEHDHMHILBH();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NOOLKJHEPHD GAOCJOIPJBN();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PFJAFPLIJBN OPJELPHLGNJ();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KHKAOBMNNCA(long FBGCBCPICFF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NMKDHCIGEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEJBNFNHDND(out IEnumerable<int> FNDDELOAIKH);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAKMNKIPNEA(HAPIHBLEHPF PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFDPNELICDD(HAPIHBLEHPF PFJMMABJIDH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface GKMODABNOKM
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AJGKPEIKCMC(MBCHBOFNLBC EIMECJNACCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JJIGCEEOKLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDEAHFPHLGB(OKPDFEMKFGE.APPMLMOPKDH LEGLMLJMLNK);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDIPOPKIJOD(OKPDFEMKFGE.APPMLMOPKDH LEGLMLJMLNK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ELDJNEHEPGE : JJIGCEEOKLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBCHBOFNLBC FHGOEMMKNFG(NEDBMOFEKBM MCCCJGDFKAO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GPKLPECHMBG : JJIGCEEOKLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBCHBOFNLBC POPPKKBLLMO(NEDBMOFEKBM JCPINPGGEJF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LKMFCGHDGCH
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EMJKJMHNAHC<PEMFLNHGAAN, JFEOKEIGAEM>> NDGPPJMNIFJ(string IJBOACAPDKG, long FBGCBCPICFF, FIGGJFIGHGM.HONDLOJNMDK EDMGNEDIMBO, CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KEPNPHPFCLL<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EMJKJMHNAHC<byte[], JFEOKEIGAEM>> BPIJCAHFABN(TGetDataArg GODAADFHOBN, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EMJKJMHNAHC<global::BCDCIHJGKKI<TData>, JFEOKEIGAEM> MOMPCHPFEDE(byte[] HANEMGLFJMM);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class DOEDLLAIOKO : FPCHIGOFPMO, IIHLOMNOCIN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FDJPGBBFLLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public DOEDLLAIOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MDLACFNPHOC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x309D980", Offset = "0x309CD80", VA = "0x18309D980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x309DC20", Offset = "0x309D020", VA = "0x18309DC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BCFBJIELIME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DOEDLLAIOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x309B270", Offset = "0x309A670", VA = "0x18309B270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MJCLJEBMNFN : IEnumerable<CEPAAGHMMNN>, IEnumerable, IEnumerator<CEPAAGHMMNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CEPAAGHMMNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DOEDLLAIOKO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		private CEPAAGHMMNN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public MJCLJEBMNFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x30A77B0", Offset = "0x30A6BB0", VA = "0x1830A77B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x30A7BF0", Offset = "0x30A6FF0", VA = "0x1830A7BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x30A7B50", Offset = "0x30A6F50", VA = "0x1830A7B50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CEPAAGHMMNN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x30A7B50", Offset = "0x30A6F50", VA = "0x1830A7B50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CancellationTokenSource BNJLBDJLJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KADOJAOKIOP PKBPIIAEHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private DKEMMCDHMFM NDOCFDEDLOH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KJAOGEMHFFI NBPELOPMJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x765310", Offset = "0x764710", VA = "0x180765310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public IKBEKAKNNEB HADKCCODHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x683760", Offset = "0x682B60", VA = "0x180683760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6F7000", Offset = "0x6F6400", VA = "0x1806F7000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x66D0B0", Offset = "0x66C4B0", VA = "0x18066D0B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x765300", Offset = "0x764700", VA = "0x180765300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public BDINODBONOA HOFBPANMFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x70EAB0", Offset = "0x70DEB0", VA = "0x18070EAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public ELDJNEHEPGE POMAAPLKBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x683780", Offset = "0x682B80", VA = "0x180683780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7652F0", Offset = "0x7646F0", VA = "0x1807652F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public GPKLPECHMBG LINGJFOMHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x683700", Offset = "0x682B00", VA = "0x180683700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x695860", Offset = "0x694C60", VA = "0x180695860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ICDNBDFBHJC FHGAJNGAPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x683710", Offset = "0x682B10", VA = "0x180683710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DB0", Offset = "0x6A41B0", VA = "0x1806A4DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PIIDEFHEMHD HDGKJNFBHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6A96D0", Offset = "0x6A8AD0", VA = "0x1806A96D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D90", Offset = "0x6A4190", VA = "0x1806A4D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public GHOMLIGBKLE NBJCNDOIAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x673D80", Offset = "0x673180", VA = "0x180673D80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x90A880", Offset = "0x909C80", VA = "0x18090A880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EFMFLFDJPID JGHPJNIOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x673E20", Offset = "0x673220", VA = "0x180673E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9F0", Offset = "0x7EBDF0", VA = "0x1807EC9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DIHIMOFKLMB PPEHNILGFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6A96A0", Offset = "0x6A8AA0", VA = "0x1806A96A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x909EA0", Offset = "0x9092A0", VA = "0x180909EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EFIAGMDFPMO GOOBABBEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x683720", Offset = "0x682B20", VA = "0x180683720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DA0", Offset = "0x6A41A0", VA = "0x1806A4DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GCCAPKMMMFN BLHKCCHGODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x683730", Offset = "0x682B30", VA = "0x180683730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6F1540", Offset = "0x6F0940", VA = "0x1806F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BKDPNJBIPHM HPOKANGOOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x683750", Offset = "0x682B50", VA = "0x180683750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7A04E0", Offset = "0x79F8E0", VA = "0x1807A04E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EDBOLGEKJAL IFLMCKLMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x683740", Offset = "0x682B40", VA = "0x180683740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DC0", Offset = "0x6A41C0", VA = "0x1806A4DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PFBMOKBFJIA GOAOIIHMDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x79DC00", Offset = "0x79D000", VA = "0x18079DC00", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x79E2F0", Offset = "0x79D6F0", VA = "0x18079E2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OCFOCANBIME GPJEFEOKACA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7257A0", Offset = "0x724BA0", VA = "0x1807257A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x79DC10", Offset = "0x79D010", VA = "0x18079DC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KMGHEMCDCDI GMJABFNHDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7A0220", Offset = "0x79F620", VA = "0x1807A0220", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A0310", Offset = "0x79F710", VA = "0x1807A0310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KFIEMLFNNDD LMBHLMOBKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7E9DC0", Offset = "0x7E91C0", VA = "0x1807E9DC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EA0", Offset = "0x7E92A0", VA = "0x1807E9EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NOHKAKDEFCM BPBHOKKCNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x79E8A0", Offset = "0x79DCA0", VA = "0x18079E8A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB10", Offset = "0x7E9F10", VA = "0x1807EAB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public ILLDAFMFAGC MPGJHPPOBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79E5A0", Offset = "0x79D9A0", VA = "0x18079E5A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x79E8D0", Offset = "0x79DCD0", VA = "0x18079E8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LAJNCLCNNBF EOPBDAAGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x79E580", Offset = "0x79D980", VA = "0x18079E580", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x79E8B0", Offset = "0x79DCB0", VA = "0x18079E8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NABFEJHBFAL OHHMOIGKOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x79E590", Offset = "0x79D990", VA = "0x18079E590", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x79E8C0", Offset = "0x79DCC0", VA = "0x18079E8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NMKDHCIGEMM NAKNAKIKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB00", Offset = "0x7E9F00", VA = "0x1807EAB00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x124E870", Offset = "0x124DC70", VA = "0x18124E870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IMICIHFHHPC GELMMCFIHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x79E880", Offset = "0x79DC80", VA = "0x18079E880", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79EA20", Offset = "0x79DE20", VA = "0x18079EA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BHIMLHNCAAO OEOLBMDEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x79E890", Offset = "0x79DC90", VA = "0x18079E890", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x79EA30", Offset = "0x79DE30", VA = "0x18079EA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OGANKBGIOGD ONGFIOKFLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xAEBDB0", Offset = "0xAEB1B0", VA = "0x180AEBDB0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAEB440", Offset = "0xAEA840", VA = "0x180AEB440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MBDLGBBNDBG OPOCFFDHLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAE9F10", Offset = "0xAE9310", VA = "0x180AE9F10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private bool MKMHPIGODOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x26E50F0", Offset = "0x26E44F0", VA = "0x1826E50F0", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private bool FMNPCIHDKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x26E4B00", Offset = "0x26E3F00", VA = "0x1826E4B00", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private Task BNBLJICAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x26E5100", Offset = "0x26E4500", VA = "0x1826E5100", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private CancellationToken IPAOEPKECJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x26E4B80", Offset = "0x26E3F80", VA = "0x1826E4B80", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private KADOJAOKIOP IPILDLAOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event Action CMFBHCLKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x26E4FD0", Offset = "0x26E43D0", VA = "0x1826E4FD0", Slot = "34")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x26E46F0", Offset = "0x26E3AF0", VA = "0x1826E46F0", Slot = "35")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event JIHAFOFPEBP EEJOMGKCKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x26E5150", Offset = "0x26E4550", VA = "0x1826E5150", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x26E4940", Offset = "0x26E3D40", VA = "0x1826E4940", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event JIHAFOFPEBP LKPKJFNHKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x26E5030", Offset = "0x26E4430", VA = "0x1826E5030", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x26E4EB0", Offset = "0x26E42B0", VA = "0x1826E4EB0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event JIHAFOFPEBP NODGIOAHENC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x26E4750", Offset = "0x26E3B50", VA = "0x1826E4750", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x26E4CC0", Offset = "0x26E40C0", VA = "0x1826E4CC0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x26E52A0", Offset = "0x26E46A0", VA = "0x1826E52A0")]
	[Preserve]
	internal DOEDLLAIOKO([FFFBKAEBNFI(null)] KADOJAOKIOP PKBPIIAEHNA, [FFFBKAEBNFI(null)] KJAOGEMHFFI MBEKPBENMJL, [FFFBKAEBNFI(null)] IKBEKAKNNEB JAKPEIBNEKB, [FFFBKAEBNFI(null)] EPHHKFIEIIF OENDHJEKNMI, [FFFBKAEBNFI(null)] BDINODBONOA HFCDONAEALG, [FFFBKAEBNFI(null)] ELDJNEHEPGE NGBBHILIGAP, [FFFBKAEBNFI(null)] GPKLPECHMBG MBLDBPCGGKE, [FFFBKAEBNFI(null)] ICDNBDFBHJC ABFAKPPDDKH, [FFFBKAEBNFI(null)] PIIDEFHEMHD GFPHLBBIPFD, [FFFBKAEBNFI(null)] GHOMLIGBKLE BAELLPAGBPG, [FFFBKAEBNFI(null)] EFMFLFDJPID KJICPDPGIDE, [FFFBKAEBNFI(null)] DIHIMOFKLMB MBBNNLIECCH, [FFFBKAEBNFI(null)] EFIAGMDFPMO EDHPAAKKJBE, [FFFBKAEBNFI(null)] GCCAPKMMMFN EODLAAOLMMI, [FFFBKAEBNFI(null)] BKDPNJBIPHM AOEFMNKKMDG, [FFFBKAEBNFI(null)] EDBOLGEKJAL DGBBNOEJHCA, [FFFBKAEBNFI(null)] PFBMOKBFJIA KDDBNOGNFGN, [FFFBKAEBNFI(null)] OCFOCANBIME EBLHBBOJOAJ, [FFFBKAEBNFI(null)] KMGHEMCDCDI GEGCIOMENHF, [FFFBKAEBNFI(null)] KFIEMLFNNDD GJGOIIDCDPF, [FFFBKAEBNFI(null)] ILLDAFMFAGC CICBHGBOOPC, [FFFBKAEBNFI(null)] NOHKAKDEFCM ECPJKPIGDPJ, [FFFBKAEBNFI(null)] LAJNCLCNNBF EIFIFCILEIO, [FFFBKAEBNFI(null)] NABFEJHBFAL JIKPAEOJLAB, [FFFBKAEBNFI(null)] NMKDHCIGEMM IMNADHELOPF, [FFFBKAEBNFI(null)] BHIMLHNCAAO CLBPEMDNLDC, [FFFBKAEBNFI(null)] OGANKBGIOGD FFDIMGAKBDM, [FFFBKAEBNFI(null)] MBDLGBBNDBG PAAOKBOEGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26E51B0", Offset = "0x26E45B0", VA = "0x1826E51B0")]
	private void PAICICMJOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x26E47B0", Offset = "0x26E3BB0", VA = "0x1826E47B0", Slot = "51")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x26E4E60", Offset = "0x26E4260", VA = "0x1826E4E60", Slot = "45")]
	private void INJCHLPIMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x26E49A0", Offset = "0x26E3DA0", VA = "0x1826E49A0", Slot = "46")]
	private JAOJILANMJO EGIPDLGHJGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x26E4F10", Offset = "0x26E4310", VA = "0x1826E4F10", Slot = "47")]
	private FJHKEBJJBNN JEOJHILFIGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x26E4D20", Offset = "0x26E4120", VA = "0x1826E4D20", Slot = "48")]
	[AsyncStateMachine(typeof(FDJPGBBFLLB))]
	private Task<MBCHBOFNLBC> HEPILKNBOHP(MDLACFNPHOC MEEMHAEBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x26E4660", Offset = "0x26E3A60", VA = "0x1826E4660", Slot = "50")]
	public GNGDEKNEGGO BLDFLOEEBDP(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ, long EBLMJJHFMLK, [Optional] ELHGAJBONGN GJPMIKNGABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x26E4BA0", Offset = "0x26E3FA0", VA = "0x1826E4BA0", Slot = "49")]
	[AsyncStateMachine(typeof(BCFBJIELIME))]
	private Task GBOFCONCIIB(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x26E45F0", Offset = "0x26E39F0", VA = "0x1826E45F0")]
	[IteratorStateMachine(typeof(MJCLJEBMNFN))]
	private IEnumerable<CEPAAGHMMNN> AOCFENGKOEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x26E5090", Offset = "0x26E4490", VA = "0x1826E5090")]
	[CompilerGenerated]
	private void LONDPCONKAC(CEPAAGHMMNN NDJEINDKPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class BNGDCMGDOFH : EPEBCOBHKJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MNPDFHPHJNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BNGDCMGDOFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x30A8860", Offset = "0x30A7C60", VA = "0x1830A8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x30A8BE0", Offset = "0x30A7FE0", VA = "0x1830A8BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x66D6E0", Offset = "0x66CAE0", VA = "0x18066D6E0")]
	public BNGDCMGDOFH(FPCHIGOFPMO EOPOLGFEGAI, EPHHKFIEIIF OENDHJEKNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x26DE670", Offset = "0x26DDA70", VA = "0x1826DE670", Slot = "4")]
	[AsyncStateMachine(typeof(MNPDFHPHJNG))]
	public Task<bool> NOGKHNKDJIH(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26DE590", Offset = "0x26DD990", VA = "0x1826DE590")]
	[CompilerGenerated]
	private object GJDOIPBKPBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal class NOEJBPAOBEP : EPEBCOBHKJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ILPPONDIDDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NOEJBPAOBEP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7F40", Offset = "0x3DD7340", VA = "0x183DD7F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8560", Offset = "0x3DD7960", VA = "0x183DD8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const float KGKNBEHIFNH = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x30AC570", Offset = "0x30AB970", VA = "0x1830AC570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x66D6E0", Offset = "0x66CAE0", VA = "0x18066D6E0")]
	public NOEJBPAOBEP(FPCHIGOFPMO EOPOLGFEGAI, EPHHKFIEIIF OENDHJEKNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30AC5C0", Offset = "0x30AB9C0", VA = "0x1830AC5C0", Slot = "4")]
	[AsyncStateMachine(typeof(ILPPONDIDDA))]
	public Task<bool> NOGKHNKDJIH(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x30AC490", Offset = "0x30AB890", VA = "0x1830AC490")]
	[CompilerGenerated]
	private object HACMDGAMBFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class BOLKILOECKD : EPEBCOBHKJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HPPCFOCPGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public BOLKILOECKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Matchmaking.GBMOFJPEHIH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NOOLKJHEPHD newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HPPCFOCPGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x30A0A00", Offset = "0x309FE00", VA = "0x1830A0A00")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x30A0AE0", Offset = "0x309FEE0", VA = "0x1830A0AE0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x30A0B50", Offset = "0x309FF50", VA = "0x1830A0B50")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IMDKPALLMIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BOLKILOECKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private HPPCFOCPGJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<Matchmaking.GBMOFJPEHIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x30A0C80", Offset = "0x30A0080", VA = "0x1830A0C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x30A1540", Offset = "0x30A0940", VA = "0x1830A1540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private const float KGKNBEHIFNH = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x26DF040", Offset = "0x26DE440", VA = "0x1826DF040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x66D6E0", Offset = "0x66CAE0", VA = "0x18066D6E0")]
	public BOLKILOECKD(FPCHIGOFPMO EOPOLGFEGAI, EPHHKFIEIIF OENDHJEKNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x26DF090", Offset = "0x26DE490", VA = "0x1826DF090", Slot = "4")]
	[AsyncStateMachine(typeof(IMDKPALLMIE))]
	public Task<bool> NOGKHNKDJIH(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal interface EPEBCOBHKJJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> NOGKHNKDJIH(CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct FOBDJFNGCEK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OABNJOBDFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FPCHIGOFPMO manager;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OABNJOBDFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x36F7DA0", Offset = "0x36F71A0", VA = "0x1836F7DA0")]
		internal Task <CreateTask>b__0(HHPEKJGCIPO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BCPKBKHEEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public FOBDJFNGCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private MDLACFNPHOC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<GLEEKLMEDAL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x36E80E0", Offset = "0x36E74E0", VA = "0x1836E80E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x36E8660", Offset = "0x36E7A60", VA = "0x1836E8660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct ILPKLPCEIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FOBDJFNGCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x36F1FD0", Offset = "0x36F13D0", VA = "0x1836F1FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CancellationToken BJBDGBAHFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly FPCHIGOFPMO INFFNKABNHB;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private KJAOGEMHFFI NBPELOPMJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x26EEA30", Offset = "0x26EDE30", VA = "0x1826EEA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x26EED30", Offset = "0x26EE130", VA = "0x1826EED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x26EEB80", Offset = "0x26EDF80", VA = "0x1826EEB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private GHOMLIGBKLE NBJCNDOIAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x26EE9E0", Offset = "0x26EDDE0", VA = "0x1826EE9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x26EED80", Offset = "0x26EE180", VA = "0x1826EED80")]
	public FOBDJFNGCEK(CancellationToken BJBDGBAHFDE, FPCHIGOFPMO INFFNKABNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x26EE920", Offset = "0x26EDD20", VA = "0x1826EE920")]
	public static HPNMAGPCOBO HHHINBALADA(FPCHIGOFPMO INFFNKABNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x26EEC00", Offset = "0x26EE000", VA = "0x1826EEC00")]
	[AsyncStateMachine(typeof(BCPKBKHEEPE))]
	public Task<bool> PAOKGAPHMII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x26EE780", Offset = "0x26EDB80", VA = "0x1826EE780")]
	private bool EFHCOOPMHMG(out MDLACFNPHOC MEEMHAEBANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x26EEA80", Offset = "0x26EDE80", VA = "0x1826EEA80")]
	[AsyncStateMachine(typeof(ILPKLPCEIHH))]
	private Task MHHFOLJFFPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26EDA40", VA = "0x1826EE640")]
	private Task<GLEEKLMEDAL> AHFGBOHCHIJ(MDLACFNPHOC LICICOHGDAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct ILACOLNCBHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly BKDPNJBIPHM AOEFMNKKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Guid OEFPMGEGBHM;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private Task<(MBCHBOFNLBC, Task)> FCKDLMKHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x26F5FA0", Offset = "0x26F53A0", VA = "0x1826F5FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4CB0", Offset = "0x1EC40B0", VA = "0x181EC4CB0")]
	public ILACOLNCBHO(BKDPNJBIPHM AOEFMNKKMDG, Guid OEFPMGEGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x26F6140", Offset = "0x26F5540", VA = "0x1826F6140")]
	public TaskAwaiter<(MBCHBOFNLBC, Task)> LMJHHKDHLMC()
	{
		return default(TaskAwaiter<(MBCHBOFNLBC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x26F6070", Offset = "0x26F5470", VA = "0x1826F6070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct DEGBBGGCPJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly TaskCompletionSource<(MBCHBOFNLBC, Task)> OFMNJDMOOIA;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Task<(MBCHBOFNLBC, Task)> FCKDLMKHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x26E4280", Offset = "0x26E3680", VA = "0x1826E4280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x26E4480", Offset = "0x26E3880", VA = "0x1826E4480")]
	public DEGBBGGCPJJ(TimeSpan DAKLLNONDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x26E4310", Offset = "0x26E3710", VA = "0x1826E4310")]
	public void HHICOLDDMJC(Task CJMBGOGJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26E43F0", Offset = "0x26E37F0", VA = "0x1826E43F0")]
	public void NIIHOMIJDOK(MBCHBOFNLBC EIMECJNACCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26E42C0", Offset = "0x26E36C0", VA = "0x1826E42C0")]
	public void EJGBCOHPKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x26E41F0", Offset = "0x26E35F0", VA = "0x1826E41F0")]
	internal void APJOLGHADAM(string HKDHNKHPGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Preserve]
internal class CJKDDONBABB : PIIDEFHEMHD, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HIOJAMGPNAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CJKDDONBABB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x309F000", Offset = "0x309E400", VA = "0x18309F000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HAPIHBLEHPF IELCEAGGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private string NBMPDFMCHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Task CIKDGOJJDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool JKFFEFPEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x26E2170", Offset = "0x26E1570", VA = "0x1826E2170", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task GEJHOOLODGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x26E2450", Offset = "0x26E1850", VA = "0x1826E2450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0", Slot = "7")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x26E22D0", Offset = "0x26E16D0", VA = "0x1826E22D0", Slot = "6")]
	public void EIMNJKMMHNJ(Task NNCIDDBLNEH, string FMHLMEKNGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x26E21A0", Offset = "0x26E15A0", VA = "0x1826E21A0")]
	[AsyncStateMachine(typeof(HIOJAMGPNAK))]
	private Task EGLGIMEBDHM(Task EIHJHHPILGI, string FMHLMEKNGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x26E24B0", Offset = "0x26E18B0", VA = "0x1826E24B0")]
	public CJKDDONBABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class EHCKJEFGFDD : IMICIHFHHPC, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool DPJOLFPLPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AFIMMDDEDJL KMJBKMBJDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BHIMLHNCAAO CLBPEMDNLDC;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public AFIMMDDEDJL MGAHKMBMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x26E6CB0", Offset = "0x26E60B0", VA = "0x1826E6CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x26E6DA0", Offset = "0x26E61A0", VA = "0x1826E6DA0", Slot = "7")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x26E6AB0", Offset = "0x26E5EB0", VA = "0x1826E6AB0", Slot = "5")]
	public void AIKMNBPBFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E6070", VA = "0x1826E6C70", Slot = "6")]
	public void AOMFIPIJMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x26E6D20", Offset = "0x26E6120", VA = "0x1826E6D20")]
	private Task LFJJDNDIOMP(KAGMGMMDEHF HOEKGJHOPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E6070", VA = "0x1826E6C70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public EHCKJEFGFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class AOJNOIKHLJN : BHIMLHNCAAO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KDOPEHNDCEC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly GJNPJHPMDFI EFJAALNHODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly string MPIADBGKNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly T NANCDEAMBKG;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public T ECFALLCDCAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x671270", Offset = "0x670670", VA = "0x180671270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x350EBD0", Offset = "0x350DFD0", VA = "0x18350EBD0")]
		public KDOPEHNDCEC(GJNPJHPMDFI EFJAALNHODH, string MPIADBGKNBD, T NANCDEAMBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x350E710", Offset = "0x350DB10", VA = "0x18350E710")]
		private void JNPPDFEHFNH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly KDOPEHNDCEC<TimeSpan> MHPPEPNMDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly KDOPEHNDCEC<TimeSpan> FHPHFNGCAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly KDOPEHNDCEC<TimeSpan> NPMEFCNAGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly KDOPEHNDCEC<TimeSpan> MNHPBPHHIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly KDOPEHNDCEC<bool> FBAIMEPDAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly KDOPEHNDCEC<bool> HBIDFBFPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly KDOPEHNDCEC<bool> GEMPIKFOOHI;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public TimeSpan MCDCBNGILPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x26DBDA0", Offset = "0x26DB1A0", VA = "0x1826DBDA0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public TimeSpan DFJOFFBEPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x26DBDE0", Offset = "0x26DB1E0", VA = "0x1826DBDE0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan LKGMEICNKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x26DBEE0", Offset = "0x26DB2E0", VA = "0x1826DBEE0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan FGNMOELODAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x26DBE60", Offset = "0x26DB260", VA = "0x1826DBE60", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool LGJEOCHPFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x26DBE20", Offset = "0x26DB220", VA = "0x1826DBE20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BPNKPNOCAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x26DBD60", Offset = "0x26DB160", VA = "0x1826DBD60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EALDBJDNJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x26DBEA0", Offset = "0x26DB2A0", VA = "0x1826DBEA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x26DBF20", Offset = "0x26DB320", VA = "0x1826DBF20")]
	[Preserve]
	public AOJNOIKHLJN([FFFBKAEBNFI(null)] GJNPJHPMDFI EFJAALNHODH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Preserve]
internal class MPFFOBECJDI : EFMFLFDJPID, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NOLIGHNDFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public FDEFPHIAOMP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NOLIGHNDFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCB90", Offset = "0x3DDBF90", VA = "0x183DDCB90")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action LBCLHFBEDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x30A94E0", Offset = "0x30A88E0", VA = "0x1830A94E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x30A8DA0", Offset = "0x30A81A0", VA = "0x1830A8DA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event JIHAFOFPEBP CKIBMJEMPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x30A95E0", Offset = "0x30A89E0", VA = "0x1830A95E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x30A9150", Offset = "0x30A8550", VA = "0x1830A9150", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event JIHAFOFPEBP EKIGDMAKIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x30A8D00", Offset = "0x30A8100", VA = "0x1830A8D00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x30A90B0", Offset = "0x30A84B0", VA = "0x1830A90B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event JIHAFOFPEBP OPDOILBBFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x30A91F0", Offset = "0x30A85F0", VA = "0x1830A91F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x30A8C60", Offset = "0x30A8060", VA = "0x1830A8C60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "16")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x30A8E40", Offset = "0x30A8240", VA = "0x1830A8E40", Slot = "12")]
	public void FIJOBPJMBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x30A95B0", Offset = "0x30A89B0", VA = "0x1830A95B0", Slot = "13")]
	public void OOCGJOINAGI(FDEFPHIAOMP NCEBCFEJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x30A8C30", Offset = "0x30A8030", VA = "0x1830A8C30", Slot = "14")]
	public void AMFNMBAAMIF(FDEFPHIAOMP NCEBCFEJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x30A9580", Offset = "0x30A8980", VA = "0x1830A9580", Slot = "15")]
	public void NABCNCKJAMJ(FDEFPHIAOMP NCEBCFEJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x30A9290", Offset = "0x30A8690", VA = "0x1830A9290")]
	private void JANNCPKLNPH(JIHAFOFPEBP CGBBOLOKPIC, FDEFPHIAOMP NCEBCFEJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MPFFOBECJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class BFCIBFJAJKE : DIHIMOFKLMB, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct LHFIAFOOMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public BFCIBFJAJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x30A48F0", Offset = "0x30A3CF0", VA = "0x1830A48F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct HOPECFDNDKI : IAsyncStateMachine
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
		public BFCIBFJAJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x30A0650", Offset = "0x309FA50", VA = "0x1830A0650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KGFJCCBGHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KGFJCCBGHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x30A3660", Offset = "0x30A2A60", VA = "0x1830A3660")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct LFBHKFEJODL : IAsyncStateMachine
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
		public BFCIBFJAJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private KGFJCCBGHAB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x30A4380", Offset = "0x30A3780", VA = "0x1830A4380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x30A48A0", Offset = "0x30A3CA0", VA = "0x1830A48A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PPAIJOMLOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PPAIJOMLOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x30B2560", Offset = "0x30B1960", VA = "0x1830B2560")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private EPEBCOBHKJJ[] CLNKIGFDKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CancellationTokenSource EKAOFHIFMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int PALDGMCOIHI;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x26DE3E0", Offset = "0x26DD7E0", VA = "0x1826DE3E0", Slot = "7")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x26DD8B0", Offset = "0x26DCCB0", VA = "0x1826DD8B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x26DE010", Offset = "0x26DD410", VA = "0x1826DE010", Slot = "6")]
	public void LMHHKPCNIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x26DE180", Offset = "0x26DD580", VA = "0x1826DE180", Slot = "5")]
	public void NGOOONMIKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x26DE2D0", Offset = "0x26DD6D0", VA = "0x1826DE2D0", Slot = "4")]
	[AsyncStateMachine(typeof(LHFIAFOOMOA))]
	public Task OEHHDOOOIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x26DDB10", Offset = "0x26DCF10", VA = "0x1826DDB10")]
	private void GPMFFEEGMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x26DE460", Offset = "0x26DD860", VA = "0x1826DE460")]
	[AsyncStateMachine(typeof(HOPECFDNDKI))]
	private Task PMNIIBBDEDN(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x26DD760", Offset = "0x26DCB60", VA = "0x1826DD760")]
	[AsyncStateMachine(typeof(LFBHKFEJODL))]
	private Task<bool> AMGHAGHEFAC(int PGFOAHEHPOH, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x26DD600", Offset = "0x26DCA00", VA = "0x1826DD600")]
	private void AMAFBFFBAIM(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x26DD8C0", Offset = "0x26DCCC0", VA = "0x1826DD8C0")]
	private void EAODAGCANCE(int PGFOAHEHPOH, bool OLELCLABONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x26DDE60", Offset = "0x26DD260", VA = "0x1826DDE60")]
	private void IDBBEIHOHPK(int PGFOAHEHPOH, Exception HAFLEMDJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x26DDA00", Offset = "0x26DCE00", VA = "0x1826DDA00")]
	private void FJKGLJOPHIB(CancellationToken BJBDGBAHFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BFCIBFJAJKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Preserve]
internal class DPMCGECPJGC : GCCAPKMMMFN, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct JGAPFAHGBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DPMCGECPJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HHPEKJGCIPO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x30A2340", Offset = "0x30A1740", VA = "0x1830A2340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MKGFFHEPKOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public DPMCGECPJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public HHPEKJGCIPO roomData;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public MKGFFHEPKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x30A7C30", Offset = "0x30A7030", VA = "0x1830A7C30")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct PHDGKCFNNJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public HPNMAGPCOBO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x30AED30", Offset = "0x30AE130", VA = "0x1830AED30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct NJOIPCAHIJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DPMCGECPJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x30AC1D0", Offset = "0x30AB5D0", VA = "0x1830AC1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly HashSet<HPNMAGPCOBO> OIDJAKGLLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IKBEKAKNNEB JAKPEIBNEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GOCNKMNKIHO OAPCEJJPENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private OJMJLNHLDPO DFODEHLGAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private IDisposable CEFEHDHAKLE;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool GFIANLNOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x26E5890", Offset = "0x26E4C90", VA = "0x1826E5890", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	internal Task FCKDLMKHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x26E5760", Offset = "0x26E4B60", VA = "0x1826E5760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6440", Offset = "0x26E5840", VA = "0x1826E6440", Slot = "6")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x26E58A0", Offset = "0x26E4CA0", VA = "0x1826E58A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x26E5B30", Offset = "0x26E4F30", VA = "0x1826E5B30", Slot = "5")]
	public bool HOACFGMPDAF(HPNMAGPCOBO NKAPDINFNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x26E66B0", Offset = "0x26E5AB0", VA = "0x1826E66B0")]
	private void PGNCJJPGFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x26E61C0", Offset = "0x26E55C0", VA = "0x1826E61C0")]
	private void NABIODBCCBN(HHPEKJGCIPO OAGMMIBDFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x26E5770", Offset = "0x26E4B70", VA = "0x1826E5770")]
	[AsyncStateMachine(typeof(JGAPFAHGBCC))]
	private Task CJMCGJBMELJ(HHPEKJGCIPO OAGMMIBDFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x26E5680", Offset = "0x26E4A80", VA = "0x1826E5680")]
	private Func<CancellationToken, List<Task>> ADKJEPGOMPM(HHPEKJGCIPO OAGMMIBDFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x26E5B90", Offset = "0x26E4F90", VA = "0x1826E5B90")]
	private List<Task> LMGIBKICCPA(HHPEKJGCIPO OAGMMIBDFHK, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x26E5900", Offset = "0x26E4D00", VA = "0x1826E5900")]
	[AsyncStateMachine(typeof(PHDGKCFNNJF))]
	private Task ECBFHLDMAEB(HPNMAGPCOBO CBMALGFENFM, HHPEKJGCIPO HANEMGLFJMM, CancellationToken PFJMMABJIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x26E5A30", Offset = "0x26E4E30", VA = "0x1826E5A30")]
	[AsyncStateMachine(typeof(NJOIPCAHIJN))]
	private Task HGGFKAAIGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x26E60C0", Offset = "0x26E54C0", VA = "0x1826E60C0")]
	private void LMHHKPCNIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x26E68D0", Offset = "0x26E5CD0", VA = "0x1826E68D0")]
	public DPMCGECPJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal class FADHHJLPFFP : EFIAGMDFPMO, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct MBNFFKBNEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x30A5F70", Offset = "0x30A5370", VA = "0x1830A5F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct HOPCAAIJIHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private global::HLIIJDKEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private LAPCKNIDAJE <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private ONBEOAFGDGI <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x309FCB0", Offset = "0x309F0B0", VA = "0x18309FCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MCBLOCGFELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Task<GNGDEKNEGGO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public MCBLOCGFELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		internal Task<GNGDEKNEGGO> <ConnectToRoomAndRunLoadLogic>b__0(LHKKDNHCKDD _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct ONMMCKOLFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public LAPCKNIDAJE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private MCBLOCGFELL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private EJPBBGLKCLE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private LHKKDNHCKDD <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private FNGBJBALFEM <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<GNGDEKNEGGO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x36F7DE0", Offset = "0x36F71E0", VA = "0x1836F7DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct KDCPOCFGGFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private LHKKDNHCKDD <disconnectTimerScope>5__3;

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
		private LHKKDNHCKDD <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x30A2D40", Offset = "0x30A2140", VA = "0x1830A2D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct PIPNLDAKDIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KADOJAOKIOP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x36F9940", Offset = "0x36F8D40", VA = "0x1836F9940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct NCJELAKGMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public LAPCKNIDAJE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private LHKKDNHCKDD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<KDHPAOKOCIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x30A9760", Offset = "0x30A8B60", VA = "0x1830A9760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class ECCHCJBHNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ECCHCJBHNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x309D5B0", Offset = "0x309C9B0", VA = "0x18309D5B0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x309D4B0", Offset = "0x309C8B0", VA = "0x18309D4B0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CJFOJOABIFP : IAsyncStateMachine
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
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private ECCHCJBHNMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x309C2F0", Offset = "0x309B6F0", VA = "0x18309C2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct BBKOHIFLIIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public LAPCKNIDAJE joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public GNGDEKNEGGO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NOOLKJHEPHD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public EJPBBGLKCLE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private LHKKDNHCKDD <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x309ABA0", Offset = "0x3099FA0", VA = "0x18309ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MCBEIMNNICJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private LHKKDNHCKDD <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x30A6B10", Offset = "0x30A5F10", VA = "0x1830A6B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct FGJNPOMNEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x309DC70", Offset = "0x309D070", VA = "0x18309DC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct GFAKONPGBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x309E8F0", Offset = "0x309DCF0", VA = "0x18309E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct CINKAFILOFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x309BC60", Offset = "0x309B060", VA = "0x18309BC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct NDOHICBNFMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public FADHHJLPFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x36F7420", Offset = "0x36F6820", VA = "0x1836F7420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class FHECIPNHLOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FHECIPNHLOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x309E300", Offset = "0x309D700", VA = "0x18309E300")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class HHOBOEIADGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HHOBOEIADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x309EF60", Offset = "0x309E360", VA = "0x18309EF60")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class GBDIAEJFGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GBDIAEJFGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x309E7F0", Offset = "0x309DBF0", VA = "0x18309E7F0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LMBPCIOBCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LMBPCIOBCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x30A4DA0", Offset = "0x30A41A0", VA = "0x1830A4DA0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string ILGHJAAFKFK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string BDJMDGAPNHK;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string MIMFOICNMFO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid KFNLCKFNDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private ICDNBDFBHJC ABFAKPPDDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private IKBEKAKNNEB JAKPEIBNEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private DIHIMOFKLMB MBBNNLIECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private PIIDEFHEMHD GFPHLBBIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private EFMFLFDJPID KJICPDPGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private BHIMLHNCAAO CLBPEMDNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable CEFEHDHAKLE;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TaskStatus HFODNOKMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA86060", Offset = "0xA85460", VA = "0x180A86060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA86070", Offset = "0xA85470", VA = "0x180A86070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x26EB6C0", Offset = "0x26EAAC0", VA = "0x1826EB6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x26EBD50", Offset = "0x26EB150", VA = "0x1826EBD50", Slot = "6")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x26E8E20", Offset = "0x26E8220", VA = "0x1826E8E20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D70", Offset = "0x26E9170", VA = "0x1826E9D70", Slot = "5")]
	[AsyncStateMachine(typeof(MBNFFKBNEAN))]
	public Task HGHIBGHMDPO(NOOLKJHEPHD BGEDADFIFAH, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x26EA270", Offset = "0x26E9670", VA = "0x1826EA270")]
	[AsyncStateMachine(typeof(HOPCAAIJIHM))]
	private Task JGKJHEPIPHH(NOOLKJHEPHD BGEDADFIFAH, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x26E8C60", Offset = "0x26E8060", VA = "0x1826E8C60")]
	private static void CPEFLJPKMAB(NOOLKJHEPHD BGEDADFIFAH, Exception HAFLEMDJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x26EA550", Offset = "0x26E9950", VA = "0x1826EA550")]
	private static void KDEPKOIIAOA(ONBEOAFGDGI ICDKCLELOHO, Exception HAFLEMDJHOJ, [Optional] List<int> HFLNIBDHHJA, int PALDGMCOIHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x26EAD90", Offset = "0x26EA190", VA = "0x1826EAD90")]
	[AsyncStateMachine(typeof(ONMMCKOLFLA))]
	private Task KEPNOEHDLGG(LHKKDNHCKDD PPFBACEKDKI, NOOLKJHEPHD BGEDADFIFAH, LAPCKNIDAJE NDKPEEHEIID, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x26E9FE0", Offset = "0x26E93E0", VA = "0x1826E9FE0")]
	private void IPBCOKDFMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x26EA130", Offset = "0x26E9530", VA = "0x1826EA130")]
	[AsyncStateMachine(typeof(KDCPOCFGGFH))]
	private Task JDCEBICCJEA(LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x26E9080", Offset = "0x26E8480", VA = "0x1826E9080")]
	private void EEDLOICJCDD(NOOLKJHEPHD BGEDADFIFAH, CancellationToken DAOHELLFNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x26E89A0", Offset = "0x26E7DA0", VA = "0x1826E89A0")]
	private void BDFMFHJPNIA(NOOLKJHEPHD BGEDADFIFAH, LAPCKNIDAJE NDKPEEHEIID, OperationCanceledException LIPIOANEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x26EB950", Offset = "0x26EAD50", VA = "0x1826EB950")]
	private void NKMMNOIGDOM(NOOLKJHEPHD BGEDADFIFAH, LAPCKNIDAJE NDKPEEHEIID, Exception HAFLEMDJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x26E9570", Offset = "0x26E8970", VA = "0x1826E9570")]
	private void FHEAJEELGKF(NOOLKJHEPHD BGEDADFIFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x26EA4F0", Offset = "0x26E98F0", VA = "0x1826EA4F0")]
	private static FDEFPHIAOMP KBDLEMLLHGC(NOOLKJHEPHD BGEDADFIFAH)
	{
		return default(FDEFPHIAOMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x26E99D0", Offset = "0x26E8DD0", VA = "0x1826E99D0")]
	[AsyncStateMachine(typeof(PIPNLDAKDIO))]
	private Task GOKDDIJABHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x26EA440", Offset = "0x26E9840", VA = "0x1826EA440")]
	private static KDHPAOKOCIO JOOBPFAIHJM(NOOLKJHEPHD BGEDADFIFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C00", Offset = "0x26E9000", VA = "0x1826E9C00")]
	[AsyncStateMachine(typeof(NCJELAKGMPE))]
	private Task HEHHBIAGGKL(NOOLKJHEPHD BGEDADFIFAH, LAPCKNIDAJE NDKPEEHEIID, LHKKDNHCKDD PPFBACEKDKI, CancellationToken CHJMECIFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x26E8840", Offset = "0x26E7C40", VA = "0x1826E8840")]
	[AsyncStateMachine(typeof(CJFOJOABIFP))]
	private Task AFMGKMCOAAL(NOOLKJHEPHD BGEDADFIFAH, CancellationTokenSource MIIEPMCCOIJ, Task EGEEGLDEHNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x26EAF00", Offset = "0x26EA300", VA = "0x1826EAF00")]
	[AsyncStateMachine(typeof(BBKOHIFLIIE))]
	private Task KGNNNILKGEO(GNGDEKNEGGO LDDIPLLFIGP, EJPBBGLKCLE HKLBBPGMNJI, NOOLKJHEPHD CPCJKPJFKDM, LAPCKNIDAJE MJOAAPKAODM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken FGELNLEELDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x26EB710", Offset = "0x26EAB10", VA = "0x1826EB710")]
	private LAPCKNIDAJE NIFPLDHKBKN(LAPCKNIDAJE MJOAAPKAODM, ref CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x26E9EA0", Offset = "0x26E92A0", VA = "0x1826E9EA0")]
	[AsyncStateMachine(typeof(MCBEIMNNICJ))]
	private Task HKMEIFCHCDC(LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x26E9AD0", Offset = "0x26E8ED0", VA = "0x1826E9AD0")]
	[AsyncStateMachine(typeof(FGJNPOMNEEI))]
	private Task HBFGMEFGGNN(LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x26EBC10", Offset = "0x26EB010", VA = "0x1826EBC10")]
	[AsyncStateMachine(typeof(GFAKONPGBJD))]
	private Task OCEGMAKPEPA(LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x26EB440", Offset = "0x26EA840", VA = "0x1826EB440")]
	[AsyncStateMachine(typeof(CINKAFILOFG))]
	private Task MHLKKHOKJGC(HHPEKJGCIPO HANEMGLFJMM, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x26EB580", Offset = "0x26EA980", VA = "0x1826EB580")]
	[AsyncStateMachine(typeof(NDOHICBNFMA))]
	private Task NBHPCPKNOMF(LHKKDNHCKDD DIECPHHHGGG, CancellationToken CHJMECIFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x26EC100", Offset = "0x26EB500", VA = "0x1826EC100")]
	private static void PCDPDOHLEIK(NOOLKJHEPHD BGEDADFIFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x26E9800", Offset = "0x26E8C00", VA = "0x1826E9800")]
	private void GNDFAHHNCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x26EC270", Offset = "0x26EB670", VA = "0x1826EC270")]
	private void PMOFCDDFNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x26E8E70", Offset = "0x26E8270", VA = "0x1826E8E70")]
	private void EALIHEGCDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x26EA3B0", Offset = "0x26E97B0", VA = "0x1826EA3B0")]
	private void JOHDCOJIBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x26EB2D0", Offset = "0x26EA6D0", VA = "0x1826EB2D0")]
	private static void MGGKCAKLFPL(NOOLKJHEPHD BGEDADFIFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x26E93D0", Offset = "0x26E87D0", VA = "0x1826E93D0")]
	private static void EMLHEDBJKFM(NOOLKJHEPHD BGEDADFIFAH, CancellationToken CHJMECIFBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x26E8F00", Offset = "0x26E8300", VA = "0x1826E8F00")]
	private static void EDEDFCFNNPH(NOOLKJHEPHD BGEDADFIFAH, Exception HAFLEMDJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x26EB090", Offset = "0x26EA490", VA = "0x1826EB090")]
	private void MFPELJDKMDJ(NOOLKJHEPHD BGEDADFIFAH, Task EGEEGLDEHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x26E9490", Offset = "0x26E8890", VA = "0x1826E9490")]
	private static void FAPEDBEJAFN(Func<string> PIEECBDBBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x26EC3F0", Offset = "0x26EB7F0", VA = "0x1826EC3F0")]
	public FADHHJLPFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Preserve]
internal sealed class CDIFPEMMBCK : BKDPNJBIPHM, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class LAJEEMOCHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LAJEEMOCHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x30A4320", Offset = "0x30A3720", VA = "0x1830A4320")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GANPOBAMMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GANPOBAMMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x309E790", Offset = "0x309DB90", VA = "0x18309E790")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class MPPPAHLJMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public MPPPAHLJMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x30A9680", Offset = "0x30A8A80", VA = "0x1830A9680")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class NMODCGLNJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NMODCGLNJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x30AC430", Offset = "0x30AB830", VA = "0x1830AC430")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class KELJHNOKJAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KELJHNOKJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x30A3600", Offset = "0x30A2A00", VA = "0x1830A3600")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly Dictionary<Guid, DEGBBGGCPJJ> AOEFMNKKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly TimeSpan FCMOGAOJDPP;

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "10")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x26E0C20", Offset = "0x26E0020", VA = "0x1826E0C20", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x26E0C30", Offset = "0x26E0030", VA = "0x1826E0C30", Slot = "4")]
	public ILACOLNCBHO EIPAABBBFMM(Guid OEFPMGEGBHM)
	{
		return default(ILACOLNCBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x26E1270", Offset = "0x26E0670", VA = "0x1826E1270", Slot = "5")]
	public bool GMLJNDAKNDK(Guid OEFPMGEGBHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x26E15B0", Offset = "0x26E09B0", VA = "0x1826E15B0", Slot = "8")]
	public bool LMHHKPCNIEA(Guid OEFPMGEGBHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x26E0EB0", Offset = "0x26E02B0", VA = "0x1826E0EB0", Slot = "6")]
	public bool GCNLMAALNPC(Guid OEFPMGEGBHM, Task CJMBGOGJKFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x26E0960", Offset = "0x26DFD60", VA = "0x1826E0960", Slot = "7")]
	public bool CMOGGGAAJDF(Guid OEFPMGEGBHM, MBCHBOFNLBC EIMECJNACCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x26E1520", Offset = "0x26E0920", VA = "0x1826E1520", Slot = "9")]
	public Task<(MBCHBOFNLBC, Task)> IPCIMPHFPNF(Guid OEFPMGEGBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x26E1820", Offset = "0x26E0C20", VA = "0x1826E1820")]
	private void OPLGFMPBMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x26E1AC0", Offset = "0x26E0EC0", VA = "0x1826E1AC0")]
	public CDIFPEMMBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Preserve]
internal class LPKKNKENJAC : EDBOLGEKJAL, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class NNKGEFCOAJM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly NOOLKJHEPHD DEHCJGBGEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly CancellationTokenSource EKAOFHIFMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public readonly CancellationToken EFHILFEJLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private bool FDMHNBBNAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private bool KHABLLHIIEN;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCAE0", Offset = "0x3DDBEE0", VA = "0x183DDCAE0")]
		public NNKGEFCOAJM(NOOLKJHEPHD DEHCJGBGEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC990", Offset = "0x3DDBD90", VA = "0x183DDC990")]
		public void LMHHKPCNIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC960", Offset = "0x3DDBD60", VA = "0x183DDC960", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KOENOIPLNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public KAGMGMMDEHF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KOENOIPLNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAAD0", Offset = "0x3DD9ED0", VA = "0x183DDAAD0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct NIHKKKIMLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public KAGMGMMDEHF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public LPKKNKENJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC5D0", Offset = "0x3DDB9D0", VA = "0x183DDC5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class HJCHDMLGJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HJCHDMLGJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x36EFD60", Offset = "0x36EF160", VA = "0x1836EFD60")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct KAHGEFFGDMA : IAsyncStateMachine
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
		public LPKKNKENJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9260", Offset = "0x3DD8660", VA = "0x183DD9260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x676AD0", Offset = "0x675ED0", VA = "0x180676AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class BHDDPGDONNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public NOOLKJHEPHD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BHDDPGDONNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x36E8880", Offset = "0x36E7C80", VA = "0x1836E8880")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x36E8920", Offset = "0x36E7D20", VA = "0x1836E8920")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x36E8960", Offset = "0x36E7D60", VA = "0x1836E8960")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OJKDGMPINNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OJKDGMPINNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCE30", Offset = "0x3DDC230", VA = "0x183DDCE30")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct IJDCKCIBOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public NOOLKJHEPHD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public LPKKNKENJAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private BHDDPGDONNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x36F1330", Offset = "0x36F0730", VA = "0x1836F1330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private IKBEKAKNNEB JAKPEIBNEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DIHIMOFKLMB MBBNNLIECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private BHIMLHNCAAO CLBPEMDNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private EFIAGMDFPMO EDHPAAKKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private long GAPCDNMKKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NNKGEFCOAJM ABMOIBKOICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private bool GMNOOEAICJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Task OAPFCIEDFDG;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x26FC150", Offset = "0x26FB550", VA = "0x1826FC150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BPMHFLALIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x26FB3A0", Offset = "0x26FA7A0", VA = "0x1826FB3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x26FC3B0", Offset = "0x26FB7B0", VA = "0x1826FC3B0", Slot = "4")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x26FB680", Offset = "0x26FAA80", VA = "0x1826FB680", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x26FC030", Offset = "0x26FB430", VA = "0x1826FC030")]
	[AsyncStateMachine(typeof(NIHKKKIMLLF))]
	private Task MONIICGKAAN(KAGMGMMDEHF HGIGEPIJDFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x26FC1A0", Offset = "0x26FB5A0", VA = "0x1826FC1A0")]
	private void NGGPONAALPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x26FBBC0", Offset = "0x26FAFC0", VA = "0x1826FBBC0")]
	private void HLPECCJGONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x26FB480", Offset = "0x26FA880", VA = "0x1826FB480")]
	private void DMOPDPHCKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x26FBB40", Offset = "0x26FAF40", VA = "0x1826FBB40")]
	private bool GDLFEKCLEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x26FBF40", Offset = "0x26FB340", VA = "0x1826FBF40")]
	[AsyncStateMachine(typeof(KAHGEFFGDMA))]
	private void LLECGGPAHAM(int CFFPFDDOHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x26FB800", Offset = "0x26FAC00", VA = "0x1826FB800")]
	private void FEOGBJKAEFJ(out IDisposable EEGHBDNCOMN, out IDisposable HCKEBPJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x26FB220", Offset = "0x26FA620", VA = "0x1826FB220")]
	private bool APAMLLEJMIB(NOOLKJHEPHD DEHCJGBGEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x26FBF00", Offset = "0x26FB300", VA = "0x1826FBF00")]
	private void KEOHPEBKFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x26FBDD0", Offset = "0x26FB1D0", VA = "0x1826FBDD0")]
	[AsyncStateMachine(typeof(IJDCKCIBOMP))]
	private Task JGKJHEPIPHH(NOOLKJHEPHD DEHCJGBGEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x26FC600", Offset = "0x26FBA00", VA = "0x1826FC600")]
	public LPKKNKENJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Preserve]
internal sealed class FECFICMHJHG : PFBMOKBFJIA, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct MFJNHNJPIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder<CKCMKMGEMBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public FECFICMHJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter<CKCMKMGEMBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x36F6BD0", Offset = "0x36F5FD0", VA = "0x1836F6BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x36F6E20", Offset = "0x36F6220", VA = "0x1836F6E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class KJLIMCNPNLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public IMHJALLFDIF message;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KJLIMCNPNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x36F4080", Offset = "0x36F3480", VA = "0x1836F4080")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FDMAKFOJOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public IMHJALLFDIF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FDMAKFOJOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x36EDD50", Offset = "0x36ED150", VA = "0x1836EDD50")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class CEGMFLIOLCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CEGMFLIOLCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x36E89A0", Offset = "0x36E7DA0", VA = "0x1836E89A0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct KKAOKLCEMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public FECFICMHJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<MAJJLPEKFOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x36F40E0", Offset = "0x36F34E0", VA = "0x1836F40E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GFFJBFGGCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public IMHJALLFDIF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GFFJBFGGCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x36EF570", Offset = "0x36EE970", VA = "0x1836EF570")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct FBCBJEAJPPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public IMHJALLFDIF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public FECFICMHJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private LAPCKNIDAJE <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x36ED440", Offset = "0x36EC840", VA = "0x1836ED440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct NKFEGGPCIBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder<MAJJLPEKFOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public FECFICMHJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private LAPCKNIDAJE <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x36F7770", Offset = "0x36F6B70", VA = "0x1836F7770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x36F7BC0", Offset = "0x36F6FC0", VA = "0x1836F7BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class ALJKKNELEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public MAJJLPEKFOI operation;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ALJKKNELEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x36E6660", Offset = "0x36E5A60", VA = "0x1836E6660")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct KEEKEMMAICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public MAJJLPEKFOI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public FECFICMHJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private global::HLIIJDKEIIJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x36F3B40", Offset = "0x36F2F40", VA = "0x1836F3B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class PBLMHFMMAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PBLMHFMMAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x36F98E0", Offset = "0x36F8CE0", VA = "0x1836F98E0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class NEIMABKEBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NEIMABKEBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x36F7710", Offset = "0x36F6B10", VA = "0x1836F7710")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private PIIDEFHEMHD GFPHLBBIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private OCFOCANBIME EBLHBBOJOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NOHKAKDEFCM ECPJKPIGDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private TaskCompletionSource<CKCMKMGEMBD> CANKMNODKCA;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x26ED650", Offset = "0x26ECA50", VA = "0x1826ED650", Slot = "7")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x26EC5A0", Offset = "0x26EB9A0", VA = "0x1826EC5A0", Slot = "6")]
	[AsyncStateMachine(typeof(MFJNHNJPIID))]
	public Task<CKCMKMGEMBD> CHPDBBGJMAH(CancellationToken NKHEKKGIDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x26ED730", Offset = "0x26ECB30", VA = "0x1826ED730", Slot = "4")]
	public void PNLJLKDLDKK(IMHJALLFDIF HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x26ECD30", Offset = "0x26EC130", VA = "0x1826ECD30", Slot = "5")]
	public void JNMFFPBJFHI(IMHJALLFDIF LBFCEJMPGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x26EC9B0", Offset = "0x26EBDB0", VA = "0x1826EC9B0")]
	[AsyncStateMachine(typeof(KKAOKLCEMKO))]
	private Task HNCDMONEGMA(IMHJALLFDIF DKKNMPCNGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x26ECC00", Offset = "0x26EC000", VA = "0x1826ECC00")]
	[AsyncStateMachine(typeof(FBCBJEAJPPC))]
	private Task JJDLFJOCDNG(IMHJALLFDIF CLPBLAKBHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x26ED130", Offset = "0x26EC530", VA = "0x1826ED130")]
	[AsyncStateMachine(typeof(NKFEGGPCIBF))]
	private Task<MAJJLPEKFOI> NLBFOMDAKHD(IMHJALLFDIF DKKNMPCNGDF, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x26ECAE0", Offset = "0x26EBEE0", VA = "0x1826ECAE0")]
	private LAPCKNIDAJE IICLEEAHELD(IMHJALLFDIF GEIPBHHAELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x26EC470", Offset = "0x26EB870", VA = "0x1826EC470")]
	[AsyncStateMachine(typeof(KEEKEMMAICG))]
	private Task BEBFBAJKABH(MAJJLPEKFOI JEBGPNEHLJO, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x26EC730", Offset = "0x26EBB30", VA = "0x1826EC730")]
	private MAJJLPEKFOI EOOADCKFKGP(IMHJALLFDIF DKKNMPCNGDF, LAPCKNIDAJE KLOAKFGNLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x27CAC00", Offset = "0x27CA000", VA = "0x1827CAC00")]
	private T BLLNFJEBGOG<T>(T PKODKJLGOIN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x26ED280", Offset = "0x26EC680", VA = "0x1826ED280")]
	private MAJJLPEKFOI ODPDCCCPJIK(IMHJALLFDIF DKKNMPCNGDF, LAPCKNIDAJE KLOAKFGNLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FECFICMHJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x26EC6E0", Offset = "0x26EBAE0", VA = "0x1826EC6E0")]
	[CompilerGenerated]
	private void EMJGCEFIFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[Preserve]
internal sealed class PLECDGCNGEB : OCFOCANBIME, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class JAJKDDCIGBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public JAJKDDCIGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD91F0", Offset = "0x3DD85F0", VA = "0x183DD91F0")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OOGHBMECBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OOGHBMECBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCED0", Offset = "0x3DDC2D0", VA = "0x183DDCED0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private LAJNCLCNNBF EIFIFCILEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private PFBMOKBFJIA KDDBNOGNFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private BKDPNJBIPHM AOEFMNKKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private NMKDHCIGEMM IMNADHELOPF;

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x30B1C10", Offset = "0x30B1010", VA = "0x1830B1C10", Slot = "6")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x30B03B0", Offset = "0x30AF7B0", VA = "0x1830B03B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x30AFC80", Offset = "0x30AF080", VA = "0x1830AFC80", Slot = "4")]
	public ILACOLNCBHO BDLINAFAMOP(IMHJALLFDIF BLGEFGMAFMO)
	{
		return default(ILACOLNCBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x30B16B0", Offset = "0x30B0AB0", VA = "0x1830B16B0", Slot = "5")]
	public void NFPPEFOOGAF(Guid OEFPMGEGBHM, Task CJMBGOGJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x30B09A0", Offset = "0x30AFDA0", VA = "0x1830B09A0")]
	private void JDIAHPEMKEL(byte IJFHKLANACP, int COJNJLBAPPG, object CHPBOGKAJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x30B0FB0", Offset = "0x30B03B0", VA = "0x1830B0FB0")]
	private void KEFBDADIJFB(LBKBHINNMMJ LGAMCIMMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x30B1930", Offset = "0x30B0D30", VA = "0x1830B1930")]
	private void NLPODFIENKF(LBKBHINNMMJ LGAMCIMMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x30B0D00", Offset = "0x30B0100", VA = "0x1830B0D00")]
	private void KDJIPKCBIBL(LBKBHINNMMJ LGAMCIMMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x30B1D80", Offset = "0x30B1180", VA = "0x1830B1D80")]
	private MBCHBOFNLBC PMNEDDJCFOE(IMHJALLFDIF GEIPBHHAELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x30B0160", Offset = "0x30AF560", VA = "0x1830B0160")]
	private void DEAOBAEJFOP(IMHJALLFDIF CLPBLAKBHCE, MBCHBOFNLBC EIMECJNACCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x30B0750", Offset = "0x30AFB50", VA = "0x1830B0750")]
	private bool GBOMFABPNDL(IMHJALLFDIF CLPBLAKBHCE, MBCHBOFNLBC EIMECJNACCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x30B0A70", Offset = "0x30AFE70", VA = "0x1830B0A70")]
	private bool JHECEMKBODD(IMHJALLFDIF AJMENNDCLAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x30B0450", Offset = "0x30AF850", VA = "0x1830B0450")]
	private bool EDBMNCBDBJD(byte IJFHKLANACP, ExitGames.Client.Photon.Hashtable LGAMCIMMCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PLECDGCNGEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Preserve]
internal sealed class BBCBIAGLBDM : KMGHEMCDCDI, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class CPNHCMDJOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CKCMKMGEMBD operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public BBCBIAGLBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public IMHJALLFDIF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CPNHCMDJOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x309CDB0", Offset = "0x309C1B0", VA = "0x18309CDB0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x309CE20", Offset = "0x309C220", VA = "0x18309CE20")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct PDFNANMFOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public BBCBIAGLBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public IMHJALLFDIF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x30AE780", Offset = "0x30ADB80", VA = "0x1830AE780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x30AECE0", Offset = "0x30AE0E0", VA = "0x1830AECE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class NFEGGFOCHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CKCMKMGEMBD operationType;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NFEGGFOCHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x30ABAD0", Offset = "0x30AAED0", VA = "0x1830ABAD0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class AIFCGOEIFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AIFCGOEIFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x3099F90", Offset = "0x3099390", VA = "0x183099F90")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x309A000", Offset = "0x3099400", VA = "0x18309A000")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x309A070", Offset = "0x3099470", VA = "0x18309A070")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct JDAJNAJHOCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public BBCBIAGLBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private AIFCGOEIFHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private ILACOLNCBHO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private MBCHBOFNLBC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private TaskAwaiter<(MBCHBOFNLBC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x30A1590", Offset = "0x30A0990", VA = "0x1830A1590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x30A1C80", Offset = "0x30A1080", VA = "0x1830A1C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private LAJNCLCNNBF EIFIFCILEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private OCFOCANBIME EBLHBBOJOAJ;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x26DCE30", Offset = "0x26DC230", VA = "0x1826DCE30", Slot = "5")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x26DCCF0", Offset = "0x26DC0F0", VA = "0x1826DCCF0", Slot = "4")]
	[AsyncStateMachine(typeof(PDFNANMFOEL))]
	private Task<MBCHBOFNLBC> NAKLJLKHFIF(IMHJALLFDIF GEIPBHHAELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x26DC8F0", Offset = "0x26DBCF0", VA = "0x1826DC8F0")]
	private bool ACPPKNAOOOJ(CKCMKMGEMBD JCOMOCGOPMP, out MBCHBOFNLBC HNCBGLIPCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x26DCBB0", Offset = "0x26DBFB0", VA = "0x1826DCBB0")]
	[AsyncStateMachine(typeof(JDAJNAJHOCE))]
	private Task<MBCHBOFNLBC> LFFLCDEBMLM(IMHJALLFDIF DKKNMPCNGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BBCBIAGLBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[Preserve]
internal sealed class CPLDCCMFJKN : KFIEMLFNNDD, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct OFOLDPCGMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public AsyncTaskMethodBuilder<GNGDEKNEGGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public CPLDCCMFJKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private TaskAwaiter<PPFCGBHBMGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x30AC700", Offset = "0x30ABB00", VA = "0x1830AC700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x30AC8E0", Offset = "0x30ABCE0", VA = "0x1830AC8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class NCJHPGBPMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NCJHPGBPMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x30A9DB0", Offset = "0x30A91B0", VA = "0x1830A9DB0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct LMLGCNICDHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<PPFCGBHBMGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CPLDCCMFJKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public NOOLKJHEPHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private NCJHPGBPMDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<KMGGKCEODFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x30A4EA0", Offset = "0x30A42A0", VA = "0x1830A4EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x30A5260", Offset = "0x30A4660", VA = "0x1830A5260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class DODKKGEDAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DODKKGEDAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x11882B0", Offset = "0x11876B0", VA = "0x1811882B0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(MNBEONNOJCM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private OGANKBGIOGD FFDIMGAKBDM;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly (ECIBCEENAKM superRoomData, string unityAssetId, ECIBCEENAKM subRoomData) CAIGBPMOHMH;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x26E31E0", Offset = "0x26E25E0", VA = "0x1826E31E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x26E3230", Offset = "0x26E2630", VA = "0x1826E3230", Slot = "8")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x26E32C0", Offset = "0x26E26C0", VA = "0x1826E32C0", Slot = "4")]
	[AsyncStateMachine(typeof(OFOLDPCGMAL))]
	public Task<GNGDEKNEGGO> PIKEKPJGJCE(LHKKDNHCKDD DIECPHHHGGG, NOOLKJHEPHD BGEDADFIFAH, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x26E2D80", Offset = "0x26E2180", VA = "0x1826E2D80")]
	[AsyncStateMachine(typeof(LMLGCNICDHK))]
	public Task<PPFCGBHBMGI> DEFBNICIHOC(NOOLKJHEPHD BGEDADFIFAH, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x26E2630", Offset = "0x26E1A30", VA = "0x1826E2630", Slot = "5")]
	public GNGDEKNEGGO BLDFLOEEBDP(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ, long EBLMJJHFMLK, ELHGAJBONGN GJPMIKNGABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x26E30D0", Offset = "0x26E24D0", VA = "0x1826E30D0", Slot = "6")]
	public GNGDEKNEGGO LJNNMHLFOJJ(NOOLKJHEPHD BGEDADFIFAH, CIJJEIINFMP JCMKBEDCDJL, long EBLMJJHFMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x26E2530", Offset = "0x26E1930", VA = "0x1826E2530", Slot = "7")]
	public GNGDEKNEGGO BLADDHDEMFN(long JKGHLPEJDPA, long EBLMJJHFMLK, string IJBOACAPDKG, string BCPIELJKEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x26E2F00", Offset = "0x26E2300", VA = "0x1826E2F00")]
	private static GNGDEKNEGGO KGFFECFMFHA(long JKGHLPEJDPA, long EBLMJJHFMLK, ECIBCEENAKM CNKEEMPEKGF, string IJBOACAPDKG, ECIBCEENAKM OAGMMIBDFHK, string BCPIELJKEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x26E2990", Offset = "0x26E1D90", VA = "0x1826E2990")]
	private (ECIBCEENAKM, string, ECIBCEENAKM) DAFAIKEDGDK(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ, long EBLMJJHFMLK, ELHGAJBONGN GJPMIKNGABI)
	{
		return default((ECIBCEENAKM, string, ECIBCEENAKM));
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public CPLDCCMFJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[Preserve]
internal sealed class PICCANNBAKF : NOHKAKDEFCM, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class OGEPJCKPHPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OGEPJCKPHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCC90", Offset = "0x3DDC090", VA = "0x183DDCC90")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct DPFLGOCFKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public PICCANNBAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public LAPCKNIDAJE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3DD34C0", Offset = "0x3DD28C0", VA = "0x183DD34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3920", Offset = "0x3DD2D20", VA = "0x183DD3920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct EDNOFDMHEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public PICCANNBAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public LAPCKNIDAJE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3AC0", Offset = "0x3DD2EC0", VA = "0x183DD3AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4090", Offset = "0x3DD3490", VA = "0x183DD4090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class IMFNOFCGEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IMFNOFCGEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD85B0", Offset = "0x3DD79B0", VA = "0x183DD85B0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct FHNECJPGCOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public IMHJALLFDIF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public PICCANNBAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public LAPCKNIDAJE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private IDAHOCPOKEC <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private MHDGDDEDNCP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5500", Offset = "0x3DD4900", VA = "0x183DD5500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5FA0", Offset = "0x3DD53A0", VA = "0x183DD5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private IMICIHFHHPC FEFDKLEEHEO;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private AFIMMDDEDJL MGAHKMBMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x30AF320", Offset = "0x30AE720", VA = "0x1830AF320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x30AFBF0", Offset = "0x30AEFF0", VA = "0x1830AFBF0", Slot = "8")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30AF520", Offset = "0x30AE920", VA = "0x1830AF520", Slot = "4")]
	[AsyncStateMachine(typeof(DPFLGOCFKLA))]
	public Task<IMHJALLFDIF> HMKEIBGDPBO(IMHJALLFDIF DKKNMPCNGDF, LAPCKNIDAJE KLOAKFGNLBJ, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x30AF690", Offset = "0x30AEA90", VA = "0x1830AF690", Slot = "5")]
	[AsyncStateMachine(typeof(EDNOFDMHEKD))]
	public Task<IMHJALLFDIF> IPIFBDBOPLN(CancellationToken BJBDGBAHFDE, LAPCKNIDAJE KLOAKFGNLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x30AF090", Offset = "0x30AE490", VA = "0x1830AF090", Slot = "6")]
	public NECOACPILOL BNILOPCJEIH(MAJJLPEKFOI PFHIIMADCMF, LHKKDNHCKDD DIECPHHHGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x30AF970", Offset = "0x30AED70", VA = "0x1830AF970", Slot = "7")]
	public NECOACPILOL OKIAINKPION(MAJJLPEKFOI PFHIIMADCMF, LHKKDNHCKDD DIECPHHHGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x30AF7F0", Offset = "0x30AEBF0", VA = "0x1830AF7F0")]
	[AsyncStateMachine(typeof(FHNECJPGCOA))]
	private Task<IMHJALLFDIF> KIKFOGPCGKI(IMHJALLFDIF DKKNMPCNGDF, LAPCKNIDAJE KLOAKFGNLBJ, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x29F8220", Offset = "0x29F7620", VA = "0x1829F8220")]
	private static byte[] OPBNJECOHIH(IMHJALLFDIF HKDHNKHPGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x30AF3D0", Offset = "0x30AE7D0", VA = "0x1830AF3D0")]
	private static string HIKBBPCDDMB(byte[] GODAADFHOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PICCANNBAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Preserve]
internal sealed class JLIDNBIPMBJ : LAJNCLCNNBF, CEPAAGHMMNN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private ELDJNEHEPGE NGBBHILIGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private PIIDEFHEMHD GFPHLBBIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private ILLDAFMFAGC CICBHGBOOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private EFIAGMDFPMO EDHPAAKKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private GCCAPKMMMFN EODLAAOLMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private BHIMLHNCAAO CLBPEMDNLDC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x26F9280", Offset = "0x26F8680", VA = "0x1826F9280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private static MBCHBOFNLBC DINGGPEJAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x26E7350", Offset = "0x26E6750", VA = "0x1826E7350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x26F92D0", Offset = "0x26F86D0", VA = "0x1826F92D0", Slot = "7")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x26F8C50", Offset = "0x26F8050", VA = "0x1826F8C50", Slot = "4")]
	public MBCHBOFNLBC FECJMKCIPNK(NEDBMOFEKBM MOAPJAIPHJJ, CKCMKMGEMBD IBAOIPLKGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x26F9000", Offset = "0x26F8400", VA = "0x1826F9000", Slot = "5")]
	public MBCHBOFNLBC LEKEFGHDCPJ(NEDBMOFEKBM MCCCJGDFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x26F8DE0", Offset = "0x26F81E0", VA = "0x1826F8DE0", Slot = "6")]
	public MBCHBOFNLBC JLPFKBLKMGM(NEDBMOFEKBM MCCCJGDFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x26E73B0", Offset = "0x26E67B0", VA = "0x1826E73B0")]
	private static MBCHBOFNLBC OGKKBPBAAKA(PFDFKPAFKNP MHLBJBFFDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JLIDNBIPMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class ADDEPLJDGEN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x26DAB00", Offset = "0x26D9F00", VA = "0x1826DAB00")]
	public ADDEPLJDGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xD0AAC0", Offset = "0xD09EC0", VA = "0x180D0AAC0")]
	public ADDEPLJDGEN(string HKDHNKHPGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[Preserve]
internal sealed class IPLICKFHMOF : GHOMLIGBKLE, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct DECMLDAPKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public MDLACFNPHOC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private global::HLIIJDKEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private LHKKDNHCKDD <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private LHKKDNHCKDD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x36E9FC0", Offset = "0x36E93C0", VA = "0x1836E9FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x36EA5B0", Offset = "0x36E99B0", VA = "0x1836EA5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct EEPDBFJFKHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x36EB590", Offset = "0x36EA990", VA = "0x1836EB590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct HLHALOCBLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x36F00D0", Offset = "0x36EF4D0", VA = "0x1836F00D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct DNOCFBBEABA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x36EAF30", Offset = "0x36EA330", VA = "0x1836EAF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct FLMBNGIGAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x36EE880", Offset = "0x36EDC80", VA = "0x1836EE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FKMGKDGIFAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public IPLICKFHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public JBMIEGHLKOB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::HLIIJDKEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x36EE4C0", Offset = "0x36ED8C0", VA = "0x1836EE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private static readonly TimeSpan HHFIFKOFLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private NOHKAKDEFCM ECPJKPIGDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private PIIDEFHEMHD GFPHLBBIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private GCCAPKMMMFN EODLAAOLMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private CancellationTokenSource AECIDFOCFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private Task FBIOPMODFAO;

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x26F73F0", Offset = "0x26F67F0", VA = "0x1826F73F0", Slot = "6")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x12A19D0", Offset = "0x12A0DD0", VA = "0x1812A19D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x26F7000", Offset = "0x26F6400", VA = "0x1826F7000", Slot = "4")]
	[AsyncStateMachine(typeof(DECMLDAPKDG))]
	public Task<MBCHBOFNLBC> IJCGCGLOMED(MDLACFNPHOC MEEMHAEBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x26F6A30", Offset = "0x26F5E30", VA = "0x1826F6A30", Slot = "5")]
	[AsyncStateMachine(typeof(EEPDBFJFKHF))]
	public Task BELAPHGJMMP([Optional] CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x12A19D0", Offset = "0x12A0DD0", VA = "0x1812A19D0")]
	public void DPFIMONJDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x26F7140", Offset = "0x26F6540", VA = "0x1826F7140")]
	private IEHBHMEKOPJ ODIDCCEFJJL(MDLACFNPHOC MEEMHAEBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x26F6C70", Offset = "0x26F6070", VA = "0x1826F6C70")]
	[AsyncStateMachine(typeof(HLHALOCBLCP))]
	private Task DJHKMHJBMNJ(HHPEKJGCIPO HOEKGJHOPIH, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x26F6B50", Offset = "0x26F5F50", VA = "0x1826F6B50")]
	[AsyncStateMachine(typeof(DNOCFBBEABA))]
	private Task BFPELNANGNP([Optional] CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x26F6DA0", Offset = "0x26F61A0", VA = "0x1826F6DA0")]
	[AsyncStateMachine(typeof(FLMBNGIGAGJ))]
	private Task ECDHCGPCIMB(TimeSpan OPKBDLNJBJP, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x26F67C0", Offset = "0x26F5BC0", VA = "0x1826F67C0")]
	private Task AGBMLGNJMMM(JBMIEGHLKOB FBNDPLHPLDD, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x26F6ED0", Offset = "0x26F62D0", VA = "0x1826F6ED0")]
	[AsyncStateMachine(typeof(FKMGKDGIFAJ))]
	private Task FPLFPCHGGOI(JBMIEGHLKOB FBNDPLHPLDD, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x26F7640", Offset = "0x26F6A40", VA = "0x1826F7640")]
	private bool POPPKKBLLMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public IPLICKFHMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[Preserve]
internal class FENCFHEIKEG : ILLDAFMFAGC, CEPAAGHMMNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CLBMKJHIGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public FENCFHEIKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private global::HLIIJDKEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x36E9600", Offset = "0x36E8A00", VA = "0x1836E9600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private GPKLPECHMBG MBLDBPCGGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private LAJNCLCNNBF EIFIFCILEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private NOHKAKDEFCM ECPJKPIGDPJ;

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x26EDE10", Offset = "0x26ED210", VA = "0x1826EDE10", Slot = "6")]
	public void PAICICMJOCE(FPCHIGOFPMO EOPOLGFEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x26EDB60", Offset = "0x26ECF60", VA = "0x1826EDB60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x26EDCF0", Offset = "0x26ED0F0", VA = "0x1826EDCF0", Slot = "5")]
	[AsyncStateMachine(typeof(CLBMKJHIGIJ))]
	public Task LLOGLCFIMGH(string BABJIPJIPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x26EE030", Offset = "0x26ED430", VA = "0x1826EE030", Slot = "4")]
	public MBCHBOFNLBC POPPKKBLLMO(NEDBMOFEKBM MOAPJAIPHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x26EDBB0", Offset = "0x26ECFB0", VA = "0x1826EDBB0")]
	private IFCOAFDAIGL GFJEMENLDFL(string BABJIPJIPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FENCFHEIKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class DDJEDLFBEBN
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x26E3BE0", Offset = "0x26E2FE0", VA = "0x1826E3BE0")]
	public static void LFGLFFGIMII(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x26E3B00", Offset = "0x26E2F00", VA = "0x1826E3B00")]
	internal static void FFNOBCDCFFC(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x26E3A20", Offset = "0x26E2E20", VA = "0x1826E3A20")]
	internal static void DLKCKDNGAID(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x26E3DA0", Offset = "0x26E31A0", VA = "0x1826E3DA0")]
	internal static void PCJMOLLDGNE(KADOJAOKIOP PKBPIIAEHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class ABECCJPIPLC : global::CCOEHBANMEB<IMHJALLFDIF>
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class HAHLHGPFBBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public IMHJALLFDIF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HAHLHGPFBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x309EBB0", Offset = "0x309DFB0", VA = "0x18309EBB0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly ABECCJPIPLC PNBICMAKACI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private const string KKPCKCHIBLA = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x26D9D60", Offset = "0x26D9160", VA = "0x1826D9D60")]
	public ExitGames.Client.Photon.Hashtable CAOILNKOGOI(IMHJALLFDIF HKDHNKHPGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x26DA500", Offset = "0x26D9900", VA = "0x1826DA500", Slot = "5")]
	protected override void OEOHDDHPOMH(IMHJALLFDIF HKDHNKHPGDP, IDictionary<object, object> HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x26D9DE0", Offset = "0x26D91E0", VA = "0x1826D9DE0", Slot = "6")]
	public override IMHJALLFDIF DBBEJMFMHKH(IDictionary<object, object> HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x26DA030", Offset = "0x26D9430", VA = "0x1826DA030")]
	private static void FAPEDBEJAFN(string AIIJDIFFBGI, IMHJALLFDIF HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x26DA6C0", Offset = "0x26D9AC0", VA = "0x1826DA6C0")]
	public ABECCJPIPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x26DA1B0", Offset = "0x26D95B0", VA = "0x1826DA1B0")]
	[CompilerGenerated]
	internal static string HNLOAHHOMOF(GNGDEKNEGGO EGDJKJOHALJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class EHPJABLALCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public static MBCHBOFNLBC DINGGPEJAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x26E7350", Offset = "0x26E6750", VA = "0x1826E7350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6EB0", Offset = "0x26E62B0", VA = "0x1826E6EB0")]
	public static bool AFLBEOEPMGK(this MBCHBOFNLBC EIMECJNACCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x26E73B0", Offset = "0x26E67B0", VA = "0x1826E73B0")]
	public static MBCHBOFNLBC OGKKBPBAAKA(PFDFKPAFKNP MLBDEMHAIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x26E70D0", Offset = "0x26E64D0", VA = "0x1826E70D0")]
	public static MBCHBOFNLBC ELNLKNPLMIL(params MBCHBOFNLBC[] ADPIKOOKMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x26E6ED0", Offset = "0x26E62D0", VA = "0x1826E6ED0")]
	public static MBCHBOFNLBC BABICEGGHIO(IEnumerable<MBCHBOFNLBC> ADPIKOOKMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x26E70E0", Offset = "0x26E64E0", VA = "0x1826E70E0")]
	public static string HIHDCCJFCKJ(this MBCHBOFNLBC HNCBGLIPCEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class OKPDFEMKFGE : JJIGCEEOKLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate MBCHBOFNLBC APPMLMOPKDH([NotNull] NEDBMOFEKBM FHGPINKEFGP);

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class DBKFEKEJJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public NEDBMOFEKBM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DBKFEKEJJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3380", Offset = "0x3DD2780", VA = "0x183DD3380")]
		internal MBCHBOFNLBC <Validate>b__0(APPMLMOPKDH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	protected readonly HashSet<APPMLMOPKDH> GFGFPALCACD;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x30AD7B0", Offset = "0x30ACBB0", VA = "0x1830AD7B0", Slot = "4")]
	public void CDEAHFPHLGB(APPMLMOPKDH LEGLMLJMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x30AD860", Offset = "0x30ACC60", VA = "0x1830AD860", Slot = "5")]
	public void JDIPOPKIJOD(APPMLMOPKDH LEGLMLJMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x30AD810", Offset = "0x30ACC10", VA = "0x1830AD810", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x30AD590", Offset = "0x30AC990", VA = "0x1830AD590")]
	protected MBCHBOFNLBC BAKJMOJFPHC(NEDBMOFEKBM MCCCJGDFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x30A7730", Offset = "0x30A6B30", VA = "0x1830A7730")]
	protected OKPDFEMKFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public class MGNDOBMBNHO : OKPDFEMKFGE, ELDJNEHEPGE, JJIGCEEOKLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class BMIAHBFEBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public MBCHBOFNLBC result;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BMIAHBFEBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2E30", Offset = "0x3DD2230", VA = "0x183DD2E30")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x30A7730", Offset = "0x30A6B30", VA = "0x1830A7730")]
	[Preserve]
	public MGNDOBMBNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x30A75B0", Offset = "0x30A69B0", VA = "0x1830A75B0", Slot = "8")]
	public MBCHBOFNLBC FHGOEMMKNFG(NEDBMOFEKBM MCCCJGDFKAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class EONEANDCHCL : OKPDFEMKFGE, GPKLPECHMBG, JJIGCEEOKLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class HKGCDLLJMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public MBCHBOFNLBC result;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HKGCDLLJMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x309F690", Offset = "0x309EA90", VA = "0x18309F690")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x26E86E0", Offset = "0x26E7AE0", VA = "0x1826E86E0")]
	[Preserve]
	public EONEANDCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x26E8560", Offset = "0x26E7960", VA = "0x1826E8560", Slot = "8")]
	public MBCHBOFNLBC POPPKKBLLMO(NEDBMOFEKBM JCPINPGGEJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum GLHKEBEIDMK
{
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class DALKJMPIPGJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class GCJNIOFHOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public global::HLIIJDKEIIJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GCJNIOFHOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x309E870", Offset = "0x309DC70", VA = "0x18309E870")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public const string KENOJLJFFBD = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public const string ALGANNIIFLA = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x26E3950", Offset = "0x26E2D50", VA = "0x1826E3950")]
	public static global::HLIIJDKEIIJ<string> NGGEOBFIHDF([Optional] string CCPKECIFNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x26E3850", Offset = "0x26E2C50", VA = "0x1826E3850")]
	private static void KOKKKEDAOIG(string MPIADBGKNBD, GHONPNKPJDK PPFBACEKDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x26E35F0", Offset = "0x26E29F0", VA = "0x1826E35F0")]
	private static void IAAIDKNIMKP(string MPIADBGKNBD, GHONPNKPJDK PPFBACEKDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x26E36F0", Offset = "0x26E2AF0", VA = "0x1826E36F0")]
	public static void KOHOPEKDEND(global::HLIIJDKEIIJ<string> PPFBACEKDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x26E3530", Offset = "0x26E2930", VA = "0x1826E3530")]
	public static string HEGMMLIBCJF(IMHJALLFDIF GEIPBHHAELC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class HLELLOEEMDG
{
	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x26F0430", Offset = "0x26EF830", VA = "0x1826F0430")]
	public static void KHCAHFINPII(this KJAOGEMHFFI MBEKPBENMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x26F0440", Offset = "0x26EF840", VA = "0x1826F0440")]
	public static void MACNCOBONJC(this KJAOGEMHFFI MBEKPBENMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x26F0450", Offset = "0x26EF850", VA = "0x1826F0450")]
	private static void NLPJAGGFCOA(this KJAOGEMHFFI MBEKPBENMJL, bool EIMGMLPEKKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class KEDOENIKMKP : FKGHABHKEHB, IOHECIOLNKE, AIGKOIMKCMK, MFGCGJAIIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private readonly IOHECIOLNKE BLBGAHJGIIF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public NEDBMOFEKBM OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x26F9780", Offset = "0x26F8B80", VA = "0x1826F9780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int PHKDEMDNCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x26F9A40", Offset = "0x26F8E40", VA = "0x1826F9A40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int DMMGJNHEPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x26F97D0", Offset = "0x26F8BD0", VA = "0x1826F97D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool GNOADLCEJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int HDPJGPEJHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x693AA0", Offset = "0x692EA0", VA = "0x180693AA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event LFMFMNDELGO.OBKEFIOANBO OFBFEMINEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KLJIJJJNIBF GCKCLENLMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x26F9BE0", Offset = "0x26F8FE0", VA = "0x1826F9BE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x26F9B40", Offset = "0x26F8F40", VA = "0x1826F9B40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<bool> MCLHELLBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NEDBMOFEKBM> NHOCBCDNBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action CFHLKFLCBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x26F9C80", Offset = "0x26F9080", VA = "0x1826F9C80", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x26F9900", Offset = "0x26F8D00", VA = "0x1826F9900", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x822810", Offset = "0x821C10", VA = "0x180822810")]
	public KEDOENIKMKP(IOHECIOLNKE BLBGAHJGIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x26F9A90", Offset = "0x26F8E90", VA = "0x1826F9A90", Slot = "8")]
	public bool JNKPLDENNIN(byte IJFHKLANACP, ExitGames.Client.Photon.Hashtable IKICAIDGFFA, DBBKKHEJAPM EAFGPEKOLJG, SendOptions AGGEFCIDAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x26F99A0", Offset = "0x26F8DA0", VA = "0x1826F99A0", Slot = "29")]
	public NEDBMOFEKBM GNGGKOCDIOP(int DGFHGGGGEEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x26F9820", Offset = "0x26F8C20", VA = "0x1826F9820", Slot = "16")]
	public NEDBMOFEKBM ENBNCIGBOAM(int CAANLPABKCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "19")]
	public void BBPIICLLOAG(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "20")]
	public void ELCDLEKMIBC(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "21")]
	public void GJDBEEFOKPH(object PFJMMABJIDH, bool KFKKBCIMDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x26F9720", Offset = "0x26F8B20", VA = "0x1826F9720", Slot = "22")]
	public IDisposable BEHKJPLIEKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "23")]
	private bool IAFODMMEPIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "24")]
	public void ALNGABHFOOE(StringBuilder MNNOMONDJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x26F9D20", Offset = "0x26F9120", VA = "0x1826F9D20", Slot = "25")]
	public bool PHEAPMOPHNE(bool OAAOPIMBFAK, out string DNNOOMDNIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public void HJEIPCHNJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x11D3380", Offset = "0x11D2780", VA = "0x1811D3380", Slot = "28")]
	public void PCNIOKHNOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct LBKBHINNMMJ
{
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public const string ONKJIKFAGBG = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public const string ALJEFMOHONH = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private readonly IDictionary<object, object> LGAMCIMMCHA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x924FA0", Offset = "0x9243A0", VA = "0x180924FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
	public LBKBHINNMMJ(IDictionary<object, object> LGAMCIMMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x26FA530", Offset = "0x26F9930", VA = "0x1826FA530")]
	public bool JPFCDPHFKGB(out IMHJALLFDIF HKDHNKHPGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x26FA5F0", Offset = "0x26F99F0", VA = "0x1826FA5F0")]
	public Guid OKMFGKKGAID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x26FA2E0", Offset = "0x26F96E0", VA = "0x1826FA2E0")]
	public MBCHBOFNLBC ACBGHPMHJGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x26FA440", Offset = "0x26F9840", VA = "0x1826FA440")]
	public static ExitGames.Client.Photon.Hashtable GEGOECOOINK(IMHJALLFDIF HKDHNKHPGDP, MBCHBOFNLBC EIMECJNACCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class KELFBKEKLIE
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x26F9DC0", Offset = "0x26F91C0", VA = "0x1826F9DC0")]
	public static string OLECLAMCGJG(this NOOLKJHEPHD ELGKGHJLIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x26F9D40", Offset = "0x26F9140", VA = "0x1826F9D40")]
	public static bool DHBJOMJNKKH(this NOOLKJHEPHD ELGKGHJLIGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal struct OJMJLNHLDPO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct LHCJFACNMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public OJMJLNHLDPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB9D0", Offset = "0x3DDADD0", VA = "0x183DDB9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly CancellationTokenSource EKAOFHIFMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private Task NNCIDDBLNEH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x30AD440", Offset = "0x30AC840", VA = "0x1830AD440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	internal Task FCKDLMKHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x30AD240", Offset = "0x30AC640", VA = "0x1830AD240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x30AD470", Offset = "0x30AC870", VA = "0x1830AD470")]
	public OJMJLNHLDPO(CancellationToken BJBDGBAHFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x30AD310", Offset = "0x30AC710", VA = "0x1830AD310")]
	[AsyncStateMachine(typeof(LHCJFACNMPF))]
	public Task ELDAHBNKBBI(Func<CancellationToken, List<Task>> GIKJOIDGEFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x30AD2C0", Offset = "0x30AC6C0", VA = "0x1830AD2C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public readonly struct FACOMKEGJCF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct IPDNPIPAIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder<global::EMJKJMHNAHC<global::BCDCIHJGKKI<TData>, JFEOKEIGAEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public global::FACOMKEGJCF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private LHKKDNHCKDD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter<global::EMJKJMHNAHC<byte[], JFEOKEIGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x142FEB0", Offset = "0x142F2B0", VA = "0x18142FEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1430620", Offset = "0x142FA20", VA = "0x181430620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private readonly global::KEPNPHPFCLL<TGetDataArg, TData> LCFKANIOINC;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
	internal FACOMKEGJCF(global::KEPNPHPFCLL<TGetDataArg, TData> LFLGCLEIAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x24D29C0", Offset = "0x24D1DC0", VA = "0x1824D29C0")]
	[AsyncStateMachine(typeof(global::FACOMKEGJCF<, >.IPDNPIPAIDI))]
	public Task<global::EMJKJMHNAHC<global::BCDCIHJGKKI<TData>, JFEOKEIGAEM>> ENNKJDEGNCA(TGetDataArg GODAADFHOBN, string HBBHKFCNJMC, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class NAODFCICLLI
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x21E5DC0", Offset = "0x21E51C0", VA = "0x1821E5DC0")]
	public static global::FACOMKEGJCF<TGetDataArg, TData> AJMCJLMMDDK<TGetDataArg, TData>(global::KEPNPHPFCLL<TGetDataArg, TData> LFLGCLEIAAH)
	{
		return default(global::FACOMKEGJCF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class ICDNBDFBHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly DMFFEGMLPOI ECDIPELALBO;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private const string GKHPFONHKDB = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private const string IFNFPAIPKAN = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private const string DJDNIIGKKEN = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private const string CLJDIMIGGLO = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private const string OHGMBOCHCEF = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private string MELADKFIGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private long? AIJBOCGLJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private long? OLJHBPEKGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private BIGLHHECNDA HFMEFOHJKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private long? IPHDALJGPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool FFEOBPNDPLN;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string AOMAEFKIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public long CBEKOKDGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x26F1810", Offset = "0x26F0C10", VA = "0x1826F1810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long EOLLHCMGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x26F1E60", Offset = "0x26F1260", VA = "0x1826F1E60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BIGLHHECNDA IIAHKABKHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA720", Offset = "0x6B9B20", VA = "0x1806BA720")]
		get
		{
			return default(BIGLHHECNDA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x26F1D70", Offset = "0x26F1170", VA = "0x1826F1D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public long INOGHCDKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x26F1870", Offset = "0x26F0C70", VA = "0x1826F1870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x26F2270", Offset = "0x26F1670", VA = "0x1826F2270")]
	[Preserve]
	public ICDNBDFBHJC([FFFBKAEBNFI(null)] DMFFEGMLPOI ECDIPELALBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x26F1BC0", Offset = "0x26F0FC0", VA = "0x1826F1BC0")]
	private void MECLCCIHDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x26F1EC0", Offset = "0x26F12C0", VA = "0x1826F1EC0")]
	public void OIJLGCBNKEC(long CNEPCDGFLLD, long EBLMJJHFMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x26F1720", Offset = "0x26F0B20", VA = "0x1826F1720")]
	public void CPCECLNAPFG(string OBPIBBFCNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x26F18D0", Offset = "0x26F0CD0", VA = "0x1826F18D0")]
	public void GPGPBIKGCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class NECOACPILOL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct NHPNMNNGFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IMHJALLFDIF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public NECOACPILOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<DMFBNPPKOBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC270", Offset = "0x3DDB670", VA = "0x183DDC270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC580", Offset = "0x3DDB980", VA = "0x183DDC580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct LDBHDLPJCAC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class DKJAPIFLKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public IMHJALLFDIF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DKJAPIFLKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3DD33B0", Offset = "0x3DD27B0", VA = "0x183DD33B0")]
		internal IMHJALLFDIF <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct INJFMLPAACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AsyncTaskMethodBuilder<DMFBNPPKOBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public IMHJALLFDIF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NECOACPILOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private IDAHOCPOKEC <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter<DMFBNPPKOBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8610", Offset = "0x3DD7A10", VA = "0x183DD8610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8DE0", Offset = "0x3DD81E0", VA = "0x183DD8DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct MMJBGKAPONG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public NECOACPILOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC110", Offset = "0x3DDB510", VA = "0x183DDC110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private sealed class FNEEPMFNCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FNEEPMFNCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6220", Offset = "0x3DD5620", VA = "0x183DD6220")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class IDEGHKHHLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IDEGHKHHLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7EE0", Offset = "0x3DD72E0", VA = "0x183DD7EE0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class FPDPNPMNLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FPDPNPMNLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6630", Offset = "0x3DD5A30", VA = "0x183DD6630")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class BCLJHFAMBLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BCLJHFAMBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2B90", Offset = "0x3DD1F90", VA = "0x183DD2B90")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class IPCLBOGCOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public NECOACPILOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IPCLBOGCOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8F70", Offset = "0x3DD8370", VA = "0x183DD8F70")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class FNKJHDOKOIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public NECOACPILOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FNKJHDOKOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6390", Offset = "0x3DD5790", VA = "0x183DD6390")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private static readonly Guid NMGBNCGOFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public readonly MAJJLPEKFOI KJKJAELFADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly AFIMMDDEDJL ADPGBCAGADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly AIGKOIMKCMK MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly MFGCGJAIIIH MFAIPJIAFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private bool BKDCKDJKDHI;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x30AB590", Offset = "0x30AA990", VA = "0x1830AB590")]
	public NECOACPILOL(MAJJLPEKFOI JEBGPNEHLJO, AFIMMDDEDJL ADPGBCAGADA, AIGKOIMKCMK MBEKPBENMJL, MFGCGJAIIIH MFAIPJIAFAG, LHKKDNHCKDD DIECPHHHGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x30A9FE0", Offset = "0x30A93E0", VA = "0x1830A9FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x30A9FE0", Offset = "0x30A93E0", VA = "0x1830A9FE0")]
	public void BPKLNMJNGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x30AB1E0", Offset = "0x30AA5E0", VA = "0x1830AB1E0")]
	public void NEDKLBGHGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x30AB3D0", Offset = "0x30AA7D0", VA = "0x1830AB3D0")]
	public void OEEFAMFJENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x30A9E60", Offset = "0x30A9260", VA = "0x1830A9E60")]
	[AsyncStateMachine(typeof(NHPNMNNGFBI))]
	internal Task<IMHJALLFDIF> BMOLCNNHGEM(LHKKDNHCKDD DIECPHHHGGG, IMHJALLFDIF GEIPBHHAELC, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x29F8220", Offset = "0x29F7620", VA = "0x1829F8220")]
	private static byte[] JLKOHNNBNGK<T>(T HKDHNKHPGDP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x29F8070", Offset = "0x29F7470", VA = "0x1829F8070")]
	private static T EJEJMOENJAO<T>(MessageParser<T> OKOHGDMCIDO, byte[] HKDHNKHPGDP, T ANAIACKALCF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x30AA2D0", Offset = "0x30A96D0", VA = "0x1830AA2D0")]
	[AsyncStateMachine(typeof(INJFMLPAACM))]
	private Task<DMFBNPPKOBE> EKKMGGFKOGN(IMHJALLFDIF GEIPBHHAELC, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x29F8230", Offset = "0x29F7630", VA = "0x1829F8230")]
	[AsyncStateMachine(typeof(BOFNJEFPOFJ))]
	internal Task<T> MFFNLFBPEGM<T>(CancellationToken DAOHELLFNHN, Func<CancellationToken, Task<T>> ANMMMELMICN, int MBIHEPOPCPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x30AB000", Offset = "0x30AA400", VA = "0x1830AB000")]
	[AsyncStateMachine(typeof(MMJBGKAPONG))]
	internal Task MFFNLFBPEGM(CancellationToken DAOHELLFNHN, Func<CancellationToken, Task> ANMMMELMICN, int MBIHEPOPCPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x30AB150", Offset = "0x30AA550", VA = "0x1830AB150")]
	public IMHJALLFDIF NBNAAIKFDEP(IDAHOCPOKEC FLMLBFKJILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x30AA1B0", Offset = "0x30A95B0", VA = "0x1830AA1B0")]
	public MFADLMANDLE DEHANFCBEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB20", Offset = "0x30A9F20", VA = "0x1830AAB20")]
	public IDKJOCOFIDB HGFABGNKMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x30AB330", Offset = "0x30AA730", VA = "0x1830AB330")]
	public CCOBELPMAFF NPDEANONILO([Optional] MPCGGAFNNOH? OANBKEOGOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x30AA180", Offset = "0x30A9580", VA = "0x1830AA180")]
	public void DCOODLOPODL(Func<Guid, bool> BIGIMFNMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x30AA940", Offset = "0x30A9D40", VA = "0x1830AA940")]
	public void GJCKMGCJMOH(Func<Guid, bool> JNMLAPILPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x30AAE70", Offset = "0x30AA270", VA = "0x1830AAE70")]
	public void LACCBNOHODI(Func<Guid, bool> BIGIMFNMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x30AA730", Offset = "0x30A9B30", VA = "0x1830AA730")]
	public Guid FCEABPEGCJJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x30AACE0", Offset = "0x30AA0E0", VA = "0x1830AACE0")]
	public void KLCJKHNMMHP(Guid CPBJKGNLBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB90", Offset = "0x30A9F90", VA = "0x1830AAB90")]
	public void JOEOFADPBAP(IMHJALLFDIF IKNPKNHKOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x30AA5B0", Offset = "0x30A99B0", VA = "0x1830AA5B0")]
	public void FAPEDBEJAFN(string MBJJNPMKPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x30AA430", Offset = "0x30A9830", VA = "0x1830AA430")]
	public void FAPEDBEJAFN(Func<string> DAGEGICDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x29F7F90", Offset = "0x29F7390", VA = "0x1829F7F90")]
	private T BLLNFJEBGOG<T>(T PKODKJLGOIN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x30AA280", Offset = "0x30A9680", VA = "0x1830AA280")]
	public void DHODLGBADCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x29F7C80", Offset = "0x29F7080", VA = "0x1829F7C80")]
	[CompilerGenerated]
	internal static string BHCKPKFNGOM<T>(byte[] OGILIIFBKAD, int HCJNMBHPOMH, ref LDBHDLPJCAC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal sealed class MBNGIACCINK : MAJJLPEKFOI
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class HNNEBCMEDLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HNNEBCMEDLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7DE0", Offset = "0x3DD71E0", VA = "0x183DD7DE0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct HHFCEHEKNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public MBNGIACCINK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private IDKJOCOFIDB <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7340", Offset = "0x3DD6740", VA = "0x183DD7340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class INJIIBPBKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public PFJAFPLIJBN presence;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public INJIIBPBKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8E30", Offset = "0x3DD8230", VA = "0x183DD8E30")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private readonly GNGDEKNEGGO LDDIPLLFIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private readonly NOOLKJHEPHD ECLCBPMABPK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private const bool JLMJMDLIBKH = false;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x30A6840", Offset = "0x30A5C40", VA = "0x1830A6840")]
	public MBNGIACCINK(GNGDEKNEGGO LDDIPLLFIGP, NOOLKJHEPHD ECLCBPMABPK, Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x30A64B0", Offset = "0x30A58B0", VA = "0x1830A64B0", Slot = "8")]
	[AsyncStateMachine(typeof(HHFCEHEKNCH))]
	protected override Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x30A6600", Offset = "0x30A5A00", VA = "0x1830A6600")]
	private PFJAFPLIJBN OPJELPHLGNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class IEHBHMEKOPJ : MAJJLPEKFOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct CMLGNDGMKGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public IEHBHMEKOPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private TaskAwaiter<PPFCGBHBMGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x36E9930", Offset = "0x36E8D30", VA = "0x1836E9930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly int AKHBLONBNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly MDLACFNPHOC FJKNLEFOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly long NHALALDPCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly long KDNOPNNJEIM;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x26F4540", Offset = "0x26F3940", VA = "0x1826F4540")]
	public IEHBHMEKOPJ(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD, int AKHBLONBNBB, MDLACFNPHOC FJKNLEFOLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x26F4400", Offset = "0x26F3800", VA = "0x1826F4400", Slot = "8")]
	[AsyncStateMachine(typeof(CMLGNDGMKGM))]
	protected override Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal abstract class KAHAJOEBPJC : MAJJLPEKFOI
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class LICJOJIAAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public KAHAJOEBPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public LOPIEFEEJGH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LICJOJIAAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x36F5680", Offset = "0x36F4A80", VA = "0x1836F5680")]
		internal Task <RunAsync>b__0(LHKKDNHCKDD postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x36F56C0", Offset = "0x36F4AC0", VA = "0x1836F56C0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct FHMHPNEENDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public KAHAJOEBPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private LICJOJIAAOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x36EDDB0", Offset = "0x36ED1B0", VA = "0x1836EDDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct GANLMNBAENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public LOPIEFEEJGH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public KAHAJOEBPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x36EEFB0", Offset = "0x36EE3B0", VA = "0x1836EEFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x26F96E0", Offset = "0x26F8AE0", VA = "0x1826F96E0")]
	public KAHAJOEBPJC(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD, string JLIBJBFMBFK, bool HJFEJGHJCPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x26F9590", Offset = "0x26F8990", VA = "0x1826F9590", Slot = "8")]
	[AsyncStateMachine(typeof(FHMHPNEENDG))]
	protected override Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task IEIBKGEGKEE(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x26F9430", Offset = "0x26F8830", VA = "0x1826F9430")]
	[AsyncStateMachine(typeof(GANLMNBAENH))]
	private Task CBMPEABABMK(IDisposable ACIBJLFNFEJ, LOPIEFEEJGH MDNPNMDIFDA, LHKKDNHCKDD PPFBACEKDKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class CCMCBOJEEMH : MAJJLPEKFOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct CBEBAMDKMNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public CCMCBOJEEMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskAwaiter<NGOHFOABHJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x309B6D0", Offset = "0x309AAD0", VA = "0x18309B6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly JBMIEGHLKOB FBNDPLHPLDD;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x26DF7B0", Offset = "0x26DEBB0", VA = "0x1826DF7B0")]
	public CCMCBOJEEMH(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD, JBMIEGHLKOB FBNDPLHPLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x26DF590", Offset = "0x26DE990", VA = "0x1826DF590", Slot = "7")]
	protected override string HFPABCAKCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x26DF670", Offset = "0x26DEA70", VA = "0x1826DF670", Slot = "8")]
	[AsyncStateMachine(typeof(CBEBAMDKMNC))]
	protected override Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal abstract class MAJJLPEKFOI : INBEDPJAMNF
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public delegate Task HPJGDJHFFPH(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class KPOKJLHKANA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public LHKKDNHCKDD operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public MAJJLPEKFOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KPOKJLHKANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAB80", Offset = "0x3DD9F80", VA = "0x183DDAB80")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class AMEBNPHOBIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public KPOKJLHKANA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AMEBNPHOBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2A10", Offset = "0x3DD1E10", VA = "0x183DD2A10")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2AD0", Offset = "0x3DD1ED0", VA = "0x183DD2AD0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LFDMCMHJPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public MAJJLPEKFOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public Func<MAJJLPEKFOI, LHKKDNHCKDD, NECOACPILOL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private KPOKJLHKANA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private NECOACPILOL <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<IMHJALLFDIF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDABB0", Offset = "0x3DD9FB0", VA = "0x183DDABB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct EGGDMHCGACN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public MAJJLPEKFOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4850", Offset = "0x3DD3C50", VA = "0x183DD4850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly Guid AEKAPGAJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly ByteString EBDMNJBJMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly LAPCKNIDAJE DBIEEMALPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	protected readonly string MNHEMDBEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly bool HJFEJGHJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool HPJFNJMEJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public BIGLHHECNDA HOEPNKOLKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public BIGLHHECNDA BBFIEOOEDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly Queue<HPJGDJHFFPH> AFBAEPDGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly FNGBJBALFEM DMIPHBMBAFC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FPCHIGOFPMO DEKBIFMJEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x30A5DE0", Offset = "0x30A51E0", VA = "0x1830A5DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BDINODBONOA HOFBPANMFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x30A5D90", Offset = "0x30A5190", VA = "0x1830A5D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x30A5BC0", Offset = "0x30A4FC0", VA = "0x1830A5BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float DCAMLIOEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x30A5960", Offset = "0x30A4D60", VA = "0x1830A5960", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PKNOODLOHGF AKNFCFMMGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x30A5B20", Offset = "0x30A4F20", VA = "0x1830A5B20", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x30A5900", Offset = "0x30A4D00", VA = "0x1830A5900", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x30A5E30", Offset = "0x30A5230", VA = "0x1830A5E30")]
	protected MAJJLPEKFOI(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD, string JLIBJBFMBFK, bool HJFEJGHJCPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x30A5920", Offset = "0x30A4D20", VA = "0x1830A5920", Slot = "7")]
	protected virtual string HFPABCAKCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x30A5980", Offset = "0x30A4D80", VA = "0x1830A5980")]
	public void KGICFKJGFHH(HPJGDJHFFPH CBMALGFENFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x30A5800", Offset = "0x30A4C00", VA = "0x1830A5800")]
	protected void GEKJLAOKFFJ(float PMLBPCJAADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x30A5C40", Offset = "0x30A5040", VA = "0x1830A5C40")]
	[AsyncStateMachine(typeof(LFDMCMHJPFB))]
	public Task PAOKGAPHMII(CancellationToken BJBDGBAHFDE, LHKKDNHCKDD DIECPHHHGGG, [Optional] Func<MAJJLPEKFOI, LHKKDNHCKDD, NECOACPILOL> CNEFMLFGLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x30A55B0", Offset = "0x30A49B0", VA = "0x1830A55B0")]
	private void CFOEOEHBCNE(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x30A59E0", Offset = "0x30A4DE0", VA = "0x1830A59E0")]
	[AsyncStateMachine(typeof(EGGDMHCGACN))]
	private Task LOBAEFINMMB(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x30A5B40", Offset = "0x30A4F40", VA = "0x1830A5B40")]
	public IMHJALLFDIF NBNAAIKFDEP(IDAHOCPOKEC FLMLBFKJILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x30A5820", Offset = "0x30A4C20", VA = "0x1830A5820")]
	[CompilerGenerated]
	private Task HAELAMGCPLK(CancellationToken PMFPAMNENCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal sealed class PAIAPKFFNGE : KAHAJOEBPJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct GDOJIODNFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public PAIAPKFFNGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private FDEFPHIAOMP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private IDKJOCOFIDB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x3DD66A0", Offset = "0x3DD5AA0", VA = "0x183DD66A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private readonly GNGDEKNEGGO PBPGKMFICOG;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x30AE180", Offset = "0x30AD580", VA = "0x1830AE180")]
	public PAIAPKFFNGE(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, GNGDEKNEGGO PBPGKMFICOG, LAPCKNIDAJE LDOMBKAFLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x30AE030", Offset = "0x30AD430", VA = "0x1830AE030", Slot = "9")]
	[AsyncStateMachine(typeof(GDOJIODNFCP))]
	protected override Task IEIBKGEGKEE(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class IFCOAFDAIGL : MAJJLPEKFOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct ICGCHDGIOIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public IFCOAFDAIGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter<NGOHFOABHJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x36F0CF0", Offset = "0x36F00F0", VA = "0x1836F0CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly string JBPJHPDMPPF;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x26F4790", Offset = "0x26F3B90", VA = "0x1826F4790")]
	public IFCOAFDAIGL(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, LAPCKNIDAJE LDOMBKAFLLD, string JBPJHPDMPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x26F4660", Offset = "0x26F3A60", VA = "0x1826F4660", Slot = "8")]
	[AsyncStateMachine(typeof(ICGCHDGIOIN))]
	protected override Task MHOKPIHCEPJ(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class PMIPKMPAEGG : KAHAJOEBPJC
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EBFAFOEJEMK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public EBFAFOEJEMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private TaskAwaiter<NGOHFOABHJO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<IMHJALLFDIF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0B20", Offset = "0x3DDFF20", VA = "0x183DE0B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0E70", Offset = "0x3DE0270", VA = "0x183DE0E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public PMIPKMPAEGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public CCOBELPMAFF serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public MFADLMANDLE uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public EBFAFOEJEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3970", Offset = "0x3DD2D70", VA = "0x183DD3970")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<IMHJALLFDIF> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FGOHMNHKOJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public PMIPKMPAEGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private EBFAFOEJEMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private FDEFPHIAOMP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private IDKJOCOFIDB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4AE0", Offset = "0x3DD3EE0", VA = "0x183DD4AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly int IMBPHKGBKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	[CanBeNull]
	private readonly AGKPHDPNGFE IJHFPDLHEBO;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x30B24B0", Offset = "0x30B18B0", VA = "0x1830B24B0")]
	public PMIPKMPAEGG(Guid OEFPMGEGBHM, FPCHIGOFPMO EOPOLGFEGAI, int IMBPHKGBKCB, AGKPHDPNGFE IJHFPDLHEBO, LAPCKNIDAJE LDOMBKAFLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x30B21C0", Offset = "0x30B15C0", VA = "0x1830B21C0", Slot = "9")]
	[AsyncStateMachine(typeof(FGOHMNHKOJE))]
	protected override Task IEIBKGEGKEE(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x30B2320", Offset = "0x30B1720", VA = "0x1830B2320")]
	private void JNHKCPBJLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x30B2020", Offset = "0x30B1420", VA = "0x1830B2020")]
	private void AIADKBJGGEH(LHKKDNHCKDD DIECPHHHGGG, FDEFPHIAOMP NCEBCFEJMFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal abstract class FFMANBPPBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public readonly MAJJLPEKFOI KJKJAELFADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public readonly NECOACPILOL CGNCLEJLGOA;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x26EE130", Offset = "0x26ED530", VA = "0x1826EE130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x26EE0D0", Offset = "0x26ED4D0", VA = "0x1826EE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x26EE150", Offset = "0x26ED550", VA = "0x1826EE150")]
	protected FFMANBPPBKB(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x26EE0B0", Offset = "0x26ED4B0", VA = "0x1826EE0B0")]
	protected void FAPEDBEJAFN(string MBJJNPMKPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x26EE090", Offset = "0x26ED490", VA = "0x1826EE090")]
	public void FAPEDBEJAFN(Func<string> DAGEGICDLIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal struct CGHHDADKOEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public Dictionary<Guid, List<NDDJJJKNNLH>> LNCPGHBLCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public Dictionary<Guid, List<NDDJJJKNNLH>> PINCKMJOMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public Dictionary<Guid, List<NDDJJJKNNLH>> BFOBBMMFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public List<Guid> GNGEHKIEIHO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x26E1B80", Offset = "0x26E0F80", VA = "0x1826E1B80")]
	public static CGHHDADKOEP DPALGOGEJPD(EPHHKFIEIIF OENDHJEKNMI, BIGLHHECNDA GBHODPDIKNP, HHPEKJGCIPO MMJILEAOBBD)
	{
		return default(CGHHDADKOEP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal struct BOFHPPMEIAD
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00")]
	public static BOFHPPMEIAD GEGOECOOINK()
	{
		return default(BOFHPPMEIAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PMBHAPDINOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LIMHKHPCEGG(HHPEKJGCIPO HANEMGLFJMM, object MJNMHGGCEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void OPDOANMHNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct KMGGKCEODFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly PPFCGBHBMGI IKLHFPDBLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly MNBEONNOJCM AGFNLJNNGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly ICBMODALIOP IPKADKJDHGO;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x26FA290", Offset = "0x26F9690", VA = "0x1826FA290")]
	public KMGGKCEODFP(PPFCGBHBMGI IKLHFPDBLDD, MNBEONNOJCM AGFNLJNNGGI, ICBMODALIOP IPKADKJDHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal struct MMBDMBDIFKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly NECOACPILOL OJPOMAFEDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly Guid CPBJKGNLBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private bool OLELCLABONI;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x30A7C70", Offset = "0x30A7070", VA = "0x1830A7C70")]
	public static MMBDMBDIFKC FCEABPEGCJJ(NECOACPILOL OJPOMAFEDGN)
	{
		return default(MMBDMBDIFKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x16B5950", Offset = "0x16B4D50", VA = "0x1816B5950")]
	public void EDLHNGHEPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x30A7C60", Offset = "0x30A7060", VA = "0x1830A7C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x30A8080", Offset = "0x30A7480", VA = "0x1830A8080")]
	private MMBDMBDIFKC(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x30A7CA0", Offset = "0x30A70A0", VA = "0x1830A7CA0")]
	private void KLCJKHNMMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x30A7FD0", Offset = "0x30A73D0", VA = "0x1830A7FD0")]
	private Func<Guid, bool> NIENHCNCDCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class IDKJOCOFIDB : FFMANBPPBKB, INBEDPJAMNF
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public delegate Task<BIGLHHECNDA> HGDNFBGACOP(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE CDGKJMNNMIC, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct JOCMKKPOKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public GNGDEKNEGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private MMBDMBDIFKC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x36F27D0", Offset = "0x36F1BD0", VA = "0x1836F27D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct ABIEEBMFGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public GNGDEKNEGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private LHKKDNHCKDD <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x36E6280", Offset = "0x36E5680", VA = "0x1836E6280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x36E65A0", Offset = "0x36E59A0", VA = "0x1836E65A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct LJJOHCCPEMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public GNGDEKNEGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private LHKKDNHCKDD <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x36F5B60", Offset = "0x36F4F60", VA = "0x1836F5B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class DGAMGNOKKHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public AsyncTaskMethodBuilder<KMGGKCEODFP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public DGAMGNOKKHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private KMGGKCEODFP <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private TaskAwaiter<BIGLHHECNDA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private TaskAwaiter<KMGGKCEODFP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3DDF730", Offset = "0x3DDEB30", VA = "0x183DDF730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x3DDFE80", Offset = "0x3DDF280", VA = "0x183DDFE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder<HHPEKJGCIPO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public DGAMGNOKKHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private HHPEKJGCIPO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<BIGLHHECNDA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private TaskAwaiter<HHPEKJGCIPO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DDFED0", Offset = "0x3DDF2D0", VA = "0x183DDFED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0400", Offset = "0x3DDF800", VA = "0x183DE0400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public DGAMGNOKKHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			private bool <reloadSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private TaskAwaiter<BIGLHHECNDA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private HLFEEILEDJE <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE320", Offset = "0x3DDD720", VA = "0x183DDE320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public GNGDEKNEGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public FNGBJBALFEM preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public FNGBJBALFEM downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public KMGGKCEODFP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public FNGBJBALFEM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public HHPEKJGCIPO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public FIGGJFIGHGM.HONDLOJNMDK <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DGAMGNOKKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x36EA730", Offset = "0x36E9B30", VA = "0x1836EA730")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<KMGGKCEODFP> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x36EA870", Offset = "0x36E9C70", VA = "0x1836EA870")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HHPEKJGCIPO> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x36EA9B0", Offset = "0x36E9DB0", VA = "0x1836EA9B0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x36EA600", Offset = "0x36E9A00", VA = "0x1836EA600")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct EPECCPAJFDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public GNGDEKNEGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private DGAMGNOKKHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter<KMGGKCEODFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter<HHPEKJGCIPO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x36EC8E0", Offset = "0x36EBCE0", VA = "0x1836EC8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct EEBKCKDFOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x36EB070", Offset = "0x36EA470", VA = "0x1836EB070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct ANHOFBHNMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private LHKKDNHCKDD <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x36E66E0", Offset = "0x36E5AE0", VA = "0x1836E66E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct APNPCKBODPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private LHKKDNHCKDD <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x36E74B0", Offset = "0x36E68B0", VA = "0x1836E74B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x36E7F50", Offset = "0x36E7350", VA = "0x1836E7F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct CIKFHCPPNFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private LHKKDNHCKDD <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x36E8A00", Offset = "0x36E7E00", VA = "0x1836E8A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x36E95B0", Offset = "0x36E89B0", VA = "0x1836E95B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LFGPKBLCMKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public BIGLHHECNDA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public HHPEKJGCIPO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x36F5430", Offset = "0x36F4830", VA = "0x1836F5430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x36F5630", Offset = "0x36F4A30", VA = "0x1836F5630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class BBHFLBIAFLB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public BBHFLBIAFLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter<BIGLHHECNDA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0450", Offset = "0x3DDF850", VA = "0x183DE0450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0990", Offset = "0x3DDFD90", VA = "0x183DE0990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public HGDNFBGACOP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public BIGLHHECNDA originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BBHFLBIAFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x36E7FA0", Offset = "0x36E73A0", VA = "0x1836E7FA0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BIGLHHECNDA> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct OOEIGKOGOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HGDNFBGACOP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x36F93F0", Offset = "0x36F87F0", VA = "0x1836F93F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x36F9890", Offset = "0x36F8C90", VA = "0x1836F9890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct LEELJNKGACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public FNGBJBALFEM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private BIGLHHECNDA <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private IEnumerator<BIGLHHECNDA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x36F4CB0", Offset = "0x36F40B0", VA = "0x1836F4CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct BEGPIKBKHAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x36E86B0", Offset = "0x36E7AB0", VA = "0x1836E86B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct GCFMJDBEGFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public FPCHIGOFPMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x36EF420", Offset = "0x36EE820", VA = "0x1836EF420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct HFNGBGKCLHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public IDKJOCOFIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x36EF640", Offset = "0x36EEA40", VA = "0x1836EF640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class AODJNGKEPPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public PPFCGBHBMGI roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AODJNGKEPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x36E6C90", Offset = "0x36E6090", VA = "0x1836E6C90")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HAPIHBLEHPF BOAGDKPLBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly HAPIHBLEHPF IDFLOBMBDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly ICDNBDFBHJC ABFAKPPDDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly IIOGHHMIHGO NONOCLKCDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private readonly CAJCNKBENGG OJBCPDGCPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly EJPBBGLKCLE GANBCBBKJKG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float DCAMLIOEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x26F35B0", Offset = "0x26F29B0", VA = "0x1826F35B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private FPCHIGOFPMO DEKBIFMJEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x26F3A00", Offset = "0x26F2E00", VA = "0x1826F3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PKNOODLOHGF AKNFCFMMGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x26F3BE0", Offset = "0x26F2FE0", VA = "0x1826F3BE0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x26F33F0", Offset = "0x26F27F0", VA = "0x1826F33F0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x26F41C0", Offset = "0x26F35C0", VA = "0x1826F41C0")]
	public IDKJOCOFIDB(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x26F2BC0", Offset = "0x26F1FC0", VA = "0x1826F2BC0")]
	[AsyncStateMachine(typeof(JOCMKKPOKHB))]
	public Task EEPOEMFGFIH(GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, bool OIMBCLNEHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x26F35D0", Offset = "0x26F29D0", VA = "0x1826F35D0")]
	[AsyncStateMachine(typeof(ABIEEBMFGEN))]
	private Task<IMHJALLFDIF> JJPJCKBFFBA(GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x26F3A80", Offset = "0x26F2E80", VA = "0x1826F3A80")]
	[AsyncStateMachine(typeof(LJJOHCCPEMK))]
	private Task MDGPEIPNKKO(GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, bool OIMBCLNEHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x26F25E0", Offset = "0x26F19E0", VA = "0x1826F25E0")]
	[AsyncStateMachine(typeof(EPECCPAJFDI))]
	private Task CPMKOIGFMGO(GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD DIECPHHHGGG, CancellationToken OKHPFJJJKDA, bool OIMBCLNEHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x26F4040", Offset = "0x26F3440", VA = "0x1826F4040")]
	[AsyncStateMachine(typeof(EEBKCKDFOMD))]
	private Task PGDFPNCCHNC(LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x26F3410", Offset = "0x26F2810", VA = "0x1826F3410")]
	[AsyncStateMachine(typeof(ANHOFBHNMNJ))]
	private Task IAAOLFGAAGP(HHPEKJGCIPO HANEMGLFJMM, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x26F2E90", Offset = "0x26F2290", VA = "0x1826F2E90")]
	[AsyncStateMachine(typeof(APNPCKBODPG))]
	private Task<BIGLHHECNDA> FGNAMGGINIJ(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x26F2A20", Offset = "0x26F1E20", VA = "0x1826F2A20")]
	[AsyncStateMachine(typeof(CIKFHCPPNFN))]
	private Task<BIGLHHECNDA> DEPEDJGPGJB(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x26F2740", Offset = "0x26F1B40", VA = "0x1826F2740")]
	[AsyncStateMachine(typeof(LFGPKBLCMKN))]
	private Task<BIGLHHECNDA> DABBPDAFAJI(BIGLHHECNDA GBHODPDIKNP, HHPEKJGCIPO MMJILEAOBBD, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, bool PBNCMPIBIKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x26F3C30", Offset = "0x26F3030", VA = "0x1826F3C30")]
	private bool MNEDLMDBBFO(HHPEKJGCIPO DNCIOAFLPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x26F22F0", Offset = "0x26F16F0", VA = "0x1826F22F0")]
	[AsyncStateMachine(typeof(OOEIGKOGOLM))]
	protected Task<BIGLHHECNDA> BOEGDBMFPHI(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, HGDNFBGACOP NBFCHAOEPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x26F3EE0", Offset = "0x26F32E0", VA = "0x1826F3EE0")]
	[AsyncStateMachine(typeof(LEELJNKGACO))]
	private Task PEOMCPGIOGK(HHPEKJGCIPO HANEMGLFJMM, FNGBJBALFEM HKLBBPGMNJI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x26F3A30", Offset = "0x26F2E30", VA = "0x1826F3A30")]
	private void LIMLIPAFNIN(BIGLHHECNDA FJCLAHLFFDB, FNGBJBALFEM HKLBBPGMNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x26F3570", Offset = "0x26F2970", VA = "0x1826F3570")]
	private void IONPGONKFFN(BIGLHHECNDA KNJGHGOLNLI, out BIGLHHECNDA JKOGAOGACFM, out BIGLHHECNDA PNHDNOIFEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x26F22B0", Offset = "0x26F16B0", VA = "0x1826F22B0")]
	private Task<KMGGKCEODFP> BEONGJKLDJJ(GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x26F4170", Offset = "0x26F3570", VA = "0x1826F4170")]
	private Task<HHPEKJGCIPO> PKEADJHAEOK(GNGDEKNEGGO DKKNMPCNGDF, KMGGKCEODFP HANEMGLFJMM, FIGGJFIGHGM.HONDLOJNMDK EDMGNEDIMBO, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x26F3D90", Offset = "0x26F3190", VA = "0x1826F3D90")]
	[AsyncStateMachine(typeof(BEGPIKBKHAP))]
	private Task PDOAAIDGFPB(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x26F28D0", Offset = "0x26F1CD0", VA = "0x1826F28D0")]
	[AsyncStateMachine(typeof(GCFMJDBEGFG))]
	private Task DAOOHODIKEK(HHPEKJGCIPO HANEMGLFJMM, FPCHIGOFPMO EOPOLGFEGAI, LHKKDNHCKDD DIECPHHHGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x26F3010", Offset = "0x26F2410", VA = "0x1826F3010")]
	[AsyncStateMachine(typeof(HFNGBGKCLHF))]
	private Task GGAFANINCNC(HHPEKJGCIPO HANEMGLFJMM, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x26F3D60", Offset = "0x26F3160", VA = "0x1826F3D60")]
	private Task NDOBMOGHAEM(HHPEKJGCIPO HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x26F38A0", Offset = "0x26F2CA0", VA = "0x1826F38A0")]
	private Task KJMCNBBLCIM(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x26F25C0", Offset = "0x26F19C0", VA = "0x1826F25C0")]
	private Task CKLNPJCNCGM(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x26F2D20", Offset = "0x26F2120", VA = "0x1826F2D20")]
	private Task FCENLFCJCOB(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x26F24A0", Offset = "0x26F18A0", VA = "0x1826F24A0")]
	private static Task CBLADNHKIEC(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x26F3290", Offset = "0x26F2690", VA = "0x1826F3290")]
	private Task HFAGLEMONJF(HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x26F3750", Offset = "0x26F2B50", VA = "0x1826F3750")]
	private Task JMLIBJJAMND(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x26F3C00", Offset = "0x26F3000", VA = "0x1826F3C00")]
	private void MGAHJFBPEJI(GNGDEKNEGGO DKKNMPCNGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x26F3130", Offset = "0x26F2530", VA = "0x1826F3130")]
	private static void GIKHFNLGFDA(PPFCGBHBMGI IKLHFPDBLDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct HIDMFJKFKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private BIGLHHECNDA FJCLAHLFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private HHPEKJGCIPO HANEMGLFJMM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x26F03E0", Offset = "0x26EF7E0", VA = "0x1826F03E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x26F0060", Offset = "0x26EF460", VA = "0x1826F0060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x26F00E0", Offset = "0x26EF4E0", VA = "0x1826F00E0")]
	public static Task PAOKGAPHMII(FPCHIGOFPMO EOPOLGFEGAI, BIGLHHECNDA FJCLAHLFFDB, HHPEKJGCIPO HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x26F0190", Offset = "0x26EF590", VA = "0x1826F0190")]
	private void PAOKGAPHMII()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct LLEKAMIDEDG
{
	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x26F24A0", Offset = "0x26F18A0", VA = "0x1826F24A0")]
	public static Task PAOKGAPHMII(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct FACNFGFMADP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct ANANHJBALEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private LHKKDNHCKDD <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x309A6D0", Offset = "0x3099AD0", VA = "0x18309A6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x26E86F0", Offset = "0x26E7AF0", VA = "0x1826E86F0")]
	[AsyncStateMachine(typeof(ANANHJBALEM))]
	public static Task PAOKGAPHMII(NECOACPILOL OJPOMAFEDGN, HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct JIDNKNADLAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct EICEFJCJCGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private BIGLHHECNDA <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private FPCHIGOFPMO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private EPHHKFIEIIF <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private List<(PersistenceView, FOOKLNINPMB)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private FOOKLNINPMB <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x36EBBF0", Offset = "0x36EAFF0", VA = "0x1836EBBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x26F8710", Offset = "0x26F7B10", VA = "0x1826F8710")]
	[AsyncStateMachine(typeof(EICEFJCJCGN))]
	public static Task PAOKGAPHMII(NECOACPILOL OJPOMAFEDGN, HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x26F84A0", Offset = "0x26F78A0", VA = "0x1826F84A0")]
	private static void IKOFOKNNGJD(PersistenceView ODDIKGOJDNI, FOOKLNINPMB MJNMHGGCEGG, HHPEKJGCIPO HANEMGLFJMM, BIGLHHECNDA GBHODPDIKNP, bool ENCGCANEJFJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct KGGHFCALJNG
{
	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x26FA010", Offset = "0x26F9410", VA = "0x1826FA010")]
	public static Task PAOKGAPHMII(FPCHIGOFPMO EOPOLGFEGAI, HHPEKJGCIPO HANEMGLFJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct EKPHGFKGBJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct HLKGPOBMHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FPCHIGOFPMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x309F6F0", Offset = "0x309EAF0", VA = "0x18309F6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct KLCNIANBLOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public EKPHGFKGBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x30A36D0", Offset = "0x30A2AD0", VA = "0x1830A36D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class ABBHNIDHMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public HLMHFEDKGND version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ABBHNIDHMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x3099E00", Offset = "0x3099200", VA = "0x183099E00")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x3099EE0", Offset = "0x30992E0", VA = "0x183099EE0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private HHPEKJGCIPO HANEMGLFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private NECOACPILOL OJPOMAFEDGN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private static readonly ByteString NIMKPMMLPKL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x26E7DF0", Offset = "0x26E71F0", VA = "0x1826E7DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CJENJMNHIKJ COFAFFDAHID
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x26E7AD0", Offset = "0x26E6ED0", VA = "0x1826E7AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x26E7B50", Offset = "0x26E6F50", VA = "0x1826E7B50")]
	[AsyncStateMachine(typeof(HLKGPOBMHEA))]
	public static Task PAOKGAPHMII(FPCHIGOFPMO EOPOLGFEGAI, BIGLHHECNDA FJCLAHLFFDB, HHPEKJGCIPO HANEMGLFJMM, NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x26E7CB0", Offset = "0x26E70B0", VA = "0x1826E7CB0")]
	[AsyncStateMachine(typeof(KLCNIANBLOI))]
	private Task PAOKGAPHMII(LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x26E7E40", Offset = "0x26E7240", VA = "0x1826E7E40")]
	private void PODNCHALJAD([NotNull] NDKLHPOCFKB AKDLLELODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26E7AA0", Offset = "0x26E6EA0", VA = "0x1826E7AA0")]
	private bool BNMIEFJLFOJ(HLMHFEDKGND CELCPLLAAGH, NDKLHPOCFKB AKDLLELODCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct IKOCLFBFPLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct LPCLEGOCCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder<HHPEKJGCIPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public IKOCLFBFPLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public FIGGJFIGHGM.HONDLOJNMDK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private LHKKDNHCKDD <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<(global::EMJKJMHNAHC<PEMFLNHGAAN, JFEOKEIGAEM>, global::EMJKJMHNAHC<global::BCDCIHJGKKI<NDKLHPOCFKB>, JFEOKEIGAEM>, global::EMJKJMHNAHC<global::BCDCIHJGKKI<HHNDJGNKLNP>, JFEOKEIGAEM>, global::EMJKJMHNAHC<global::BCDCIHJGKKI<KHPPIANMGIJ>, JFEOKEIGAEM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x36F62C0", Offset = "0x36F56C0", VA = "0x1836F62C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x36F6B80", Offset = "0x36F5F80", VA = "0x1836F6B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct MOFPJHGKFNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<global::EMJKJMHNAHC<PEMFLNHGAAN, JFEOKEIGAEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public LHKKDNHCKDD downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public IKOCLFBFPLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public FIGGJFIGHGM.HONDLOJNMDK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private LHKKDNHCKDD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private TaskAwaiter<global::EMJKJMHNAHC<PEMFLNHGAAN, JFEOKEIGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x36F6E70", Offset = "0x36F6270", VA = "0x1836F6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x36F7360", Offset = "0x36F6760", VA = "0x1836F7360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private global::FACOMKEGJCF<ECIBCEENAKM, HHNDJGNKLNP> EADODGAIFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private global::FACOMKEGJCF<ECIBCEENAKM, NDKLHPOCFKB> AGFNLJNNGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private global::FACOMKEGJCF<long, KHPPIANMGIJ> DAEKHBANCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private LKMFCGHDGCH JEKFPDHFLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private GNGDEKNEGGO DKKNMPCNGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private PPFCGBHBMGI IKLHFPDBLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private MNBEONNOJCM CGGCJJIKLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private long FBGCBCPICFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private LHKKDNHCKDD PPFBACEKDKI;

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x26F5960", Offset = "0x26F4D60", VA = "0x1826F5960")]
	public static Task<HHPEKJGCIPO> DOGFMHBIPDH(FPCHIGOFPMO EOPOLGFEGAI, GNGDEKNEGGO DKKNMPCNGDF, in KMGGKCEODFP HANEMGLFJMM, FIGGJFIGHGM.HONDLOJNMDK EDMGNEDIMBO, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x26F5E30", Offset = "0x26F5230", VA = "0x1826F5E30")]
	[AsyncStateMachine(typeof(LPCLEGOCCAM))]
	private Task<HHPEKJGCIPO> PAOKGAPHMII(FIGGJFIGHGM.HONDLOJNMDK EDMGNEDIMBO, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x26F5920", Offset = "0x26F4D20", VA = "0x1826F5920")]
	private ECIBCEENAKM BEIKDICPIGL(CLDGEJBINNH FOLBNLFCLOC)
	{
		return default(ECIBCEENAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x26F5C80", Offset = "0x26F5080", VA = "0x1826F5C80")]
	[AsyncStateMachine(typeof(MOFPJHGKFNJ))]
	private Task<global::EMJKJMHNAHC<PEMFLNHGAAN, JFEOKEIGAEM>> FNFMMDFKOEA(string IJBOACAPDKG, long FBGCBCPICFF, FIGGJFIGHGM.HONDLOJNMDK EDMGNEDIMBO, LHKKDNHCKDD DFFKIOAOBFA, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct HBENHFGLALE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct LJNIBOLCBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder<KMGGKCEODFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public HBENHFGLALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private LHKKDNHCKDD <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter<KMGGKCEODFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x36F5DC0", Offset = "0x36F51C0", VA = "0x1836F5DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x36F6270", Offset = "0x36F5670", VA = "0x1836F6270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct KNFNKOAOEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<KMGGKCEODFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public HBENHFGLALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<KMGGKCEODFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x36F4A70", Offset = "0x36F3E70", VA = "0x1836F4A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x36F4C60", Offset = "0x36F4060", VA = "0x1836F4C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class CGMCIKPKOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CGMCIKPKOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x11882B0", Offset = "0x11876B0", VA = "0x1811882B0")]
		internal bool <FetchRoomDetails>b__0(MNBEONNOJCM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct APBKJKFOCCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public AsyncTaskMethodBuilder<KMGGKCEODFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public EPHHKFIEIIF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private CGMCIKPKOKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<PPFCGBHBMGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x36E6F20", Offset = "0x36E6320", VA = "0x1836E6F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x36E7460", Offset = "0x36E6860", VA = "0x1836E7460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private ICDNBDFBHJC ABFAKPPDDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private LHKKDNHCKDD PPFBACEKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private long CNEPCDGFLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private long EBLMJJHFMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private string GKADEOLGEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private ECIBCEENAKM JCLIIHBPNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private ECIBCEENAKM IEEDNCMJPPO;

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x26EF6C0", Offset = "0x26EEAC0", VA = "0x1826EF6C0")]
	public static Task<KMGGKCEODFP> DOGFMHBIPDH(FPCHIGOFPMO EOPOLGFEGAI, GNGDEKNEGGO DKKNMPCNGDF, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x26EFAC0", Offset = "0x26EEEC0", VA = "0x1826EFAC0")]
	[AsyncStateMachine(typeof(LJNIBOLCBCG))]
	private Task<KMGGKCEODFP> PAOKGAPHMII(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x26EF2A0", Offset = "0x26EE6A0", VA = "0x1826EF2A0")]
	[AsyncStateMachine(typeof(KNFNKOAOEFC))]
	private Task<KMGGKCEODFP> BEONGJKLDJJ(long CNEPCDGFLLD, long EBLMJJHFMLK, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, bool JMOCJEOALOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x26EF430", Offset = "0x26EE830", VA = "0x1826EF430")]
	[AsyncStateMachine(typeof(APBKJKFOCCP))]
	public static Task<KMGGKCEODFP> BEONGJKLDJJ(EPHHKFIEIIF OENDHJEKNMI, long CNEPCDGFLLD, long EBLMJJHFMLK, CancellationToken BJBDGBAHFDE, LHKKDNHCKDD DIECPHHHGGG, bool JMOCJEOALOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x26EF5B0", Offset = "0x26EE9B0", VA = "0x1826EF5B0")]
	private void CJKINNKKLOG(PPFCGBHBMGI IKLHFPDBLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x26EF950", Offset = "0x26EED50", VA = "0x1826EF950")]
	private bool HBNBGEAGCAG(KMGGKCEODFP HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x26EFC20", Offset = "0x26EF020", VA = "0x1826EFC20")]
	private void PNKEOKFPPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct BCEIGELLNOD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct KNBBPACKLMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public BCEIGELLNOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x30A3F70", Offset = "0x30A3370", VA = "0x1830A3F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private const int DIHINPGNPLM = 20;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private const float PLKBPONACIP = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private EPHHKFIEIIF OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private HHPEKJGCIPO HANEMGLFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private LHKKDNHCKDD PPFBACEKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private float NOFLNDJBJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private float IDFNCKABEED;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26DD250", Offset = "0x26DC650", VA = "0x1826DD250")]
	public static Task GMMLPJOJDHA(FPCHIGOFPMO EOPOLGFEGAI, HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26DD4D0", Offset = "0x26DC8D0", VA = "0x1826DD4D0")]
	[AsyncStateMachine(typeof(KNBBPACKLMA))]
	public Task PAOKGAPHMII(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26DD0B0", Offset = "0x26DC4B0", VA = "0x1826DD0B0")]
	private static void EPGECECOEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x26DCEE0", Offset = "0x26DC2E0", VA = "0x1826DCEE0")]
	private void ABGKEEEFFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26DD410", Offset = "0x26DC810", VA = "0x1826DD410")]
	private static float OFHECJMLDPE(EPHHKFIEIIF OENDHJEKNMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x26DD3F0", Offset = "0x26DC7F0", VA = "0x1826DD3F0")]
	private static float KGMNAIOAJGA()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct HGFACBMFFCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct AAHGLNGJDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public NECOACPILOL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private MAJJLPEKFOI <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private FPCHIGOFPMO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private LNFBJLODCAH.ELDGLNJMMKF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x36E5D00", Offset = "0x36E5100", VA = "0x1836E5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct IGBJHKJNNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private LPDBJMLAAPD.IKHJMKMLBHE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x36F1080", Offset = "0x36F0480", VA = "0x1836F1080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x26EFF00", Offset = "0x26EF300", VA = "0x1826EFF00")]
	[AsyncStateMachine(typeof(AAHGLNGJDDE))]
	public static Task PAOKGAPHMII(NECOACPILOL OJPOMAFEDGN, HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x26EFE90", Offset = "0x26EF290", VA = "0x1826EFE90")]
	private static Task<IMHJALLFDIF> JFCBJGPILDL(NECOACPILOL OJPOMAFEDGN, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x26EFDC0", Offset = "0x26EF1C0", VA = "0x1826EFDC0")]
	[AsyncStateMachine(typeof(IGBJHKJNNFH))]
	private static Task HBHAMKHGBNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct GCHCLGKJDOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct DIEEAELHDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public GCHCLGKJDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x36EA9F0", Offset = "0x36E9DF0", VA = "0x1836EA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class JNJIHIEKFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public JNJIHIEKFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x36F2750", Offset = "0x36F1B50", VA = "0x1836F2750")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct JFNOHJOJLDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public GCHCLGKJDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private LPGMOMJHCGD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x36F2200", Offset = "0x36F1600", VA = "0x1836F2200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private bool IABCECAMHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private LHKKDNHCKDD PPFBACEKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private CancellationToken BJBDGBAHFDE;

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x26EEFF0", Offset = "0x26EE3F0", VA = "0x1826EEFF0")]
	public static Task ELFKAGFKCDC(FPCHIGOFPMO EOPOLGFEGAI, bool IABCECAMHMC, LHKKDNHCKDD PPFBACEKDKI, CancellationToken CHJMECIFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x26EF060", Offset = "0x26EE460", VA = "0x1826EF060")]
	[AsyncStateMachine(typeof(DIEEAELHDNL))]
	private Task PAOKGAPHMII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x26EF170", Offset = "0x26EE570", VA = "0x1826EF170")]
	[AsyncStateMachine(typeof(JFNOHJOJLDF))]
	private Task PECGIJJIDEL(bool EHABFADPPIF, string LPEACJMIECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00")]
	private bool GMNLFHDGFFG(bool IABCECAMHMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct ALLFCBEHOGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct NJCEPGEBCAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public ALLFCBEHOGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x30ABD30", Offset = "0x30AB130", VA = "0x1830ABD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x30AC180", Offset = "0x30AB580", VA = "0x1830AC180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class BMOHEMNDLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BMOHEMNDLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x309B440", Offset = "0x309A840", VA = "0x18309B440")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct JIDGAOAIGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public ALLFCBEHOGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private LPGMOMJHCGD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x30A27B0", Offset = "0x30A1BB0", VA = "0x1830A27B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x30A2CF0", Offset = "0x30A20F0", VA = "0x1830A2CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private ICBMODALIOP JBJIMOGHILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private LHKKDNHCKDD PPFBACEKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private bool LIHPPAPPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private HHPEKJGCIPO HANEMGLFJMM;

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x26DABB0", Offset = "0x26D9FB0", VA = "0x1826DABB0")]
	public static Task<Scene> ECHDGAOBAFJ(FPCHIGOFPMO EOPOLGFEGAI, ICBMODALIOP HHOKFAOBNEH, LHKKDNHCKDD PPFBACEKDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC70", Offset = "0x26DA070", VA = "0x1826DAC70")]
	public static Task<Scene> KCMIPJKJPND(FPCHIGOFPMO EOPOLGFEGAI, HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x26DAD10", Offset = "0x26DA110", VA = "0x1826DAD10")]
	[AsyncStateMachine(typeof(NJCEPGEBCAB))]
	private Task<Scene> PAOKGAPHMII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC30", Offset = "0x26DA030", VA = "0x1826DAC30")]
	private bool JBBMLDALNJL(HHPEKJGCIPO HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x26DAB40", Offset = "0x26D9F40", VA = "0x1826DAB40")]
	private void AIAAOAHDJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x26DAE40", Offset = "0x26DA240", VA = "0x1826DAE40")]
	[AsyncStateMachine(typeof(JIDGAOAIGIK))]
	private Task<Scene> PECGIJJIDEL(string LPEACJMIECH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct CAJCNKBENGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct JDBPOMAAFIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CAJCNKBENGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public BIGLHHECNDA nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public HHPEKJGCIPO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private LHKKDNHCKDD <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter<BIGLHHECNDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x30A1CD0", Offset = "0x30A10D0", VA = "0x1830A1CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x30A22F0", Offset = "0x30A16F0", VA = "0x1830A22F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct EKGGKPCDEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder<BIGLHHECNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CAJCNKBENGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public BIGLHHECNDA state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x309D6B0", Offset = "0x309CAB0", VA = "0x18309D6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x309D930", Offset = "0x309CD30", VA = "0x18309D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private readonly NECOACPILOL OJPOMAFEDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private readonly ICDNBDFBHJC ABFAKPPDDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private readonly IIOGHHMIHGO NONOCLKCDLP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MAJJLPEKFOI KJKJAELFADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x970530", Offset = "0x96F930", VA = "0x180970530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x26DF530", Offset = "0x26DE930", VA = "0x1826DF530")]
	public CAJCNKBENGG(NECOACPILOL OJPOMAFEDGN, ICDNBDFBHJC ABFAKPPDDKH, IIOGHHMIHGO NONOCLKCDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x26DF390", Offset = "0x26DE790", VA = "0x1826DF390")]
	[AsyncStateMachine(typeof(JDBPOMAAFIA))]
	public Task<BIGLHHECNDA> FLGOFPLELHJ(BIGLHHECNDA DNCPIMHIIBO, HHPEKJGCIPO MMJILEAOBBD, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE, bool PBNCMPIBIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x26DF1D0", Offset = "0x26DE5D0", VA = "0x1826DF1D0")]
	[AsyncStateMachine(typeof(EKGGKPCDEPN))]
	private Task<BIGLHHECNDA> CDDNIKPJGIJ(LHKKDNHCKDD DIECPHHHGGG, BIGLHHECNDA AGOKAPGFDDL, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x26DF340", Offset = "0x26DE740", VA = "0x1826DF340")]
	private bool CPDMKNEOOGG(BIGLHHECNDA ALCGKAHLBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x26DF370", Offset = "0x26DE770", VA = "0x1826DF370")]
	private void FAPEDBEJAFN(string PIEECBDBBLD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EDCPKJGIGJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct PBBAGBOKFCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public MAJJLPEKFOI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private List<(PersistenceView, FOOKLNINPMB)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private (PersistenceView, FOOKLNINPMB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x30AE220", Offset = "0x30AD620", VA = "0x1830AE220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x26E6950", Offset = "0x26E5D50", VA = "0x1826E6950")]
	[AsyncStateMachine(typeof(PBBAGBOKFCI))]
	public static Task PAOKGAPHMII(MAJJLPEKFOI JEBGPNEHLJO, HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct OOLCKMFMPNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct ACNBPKKNJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public MAJJLPEKFOI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public HLFEEILEDJE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private HLMHFEDKGND <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private List<(PersistenceView, FOOKLNINPMB)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private FOOKLNINPMB <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2340", Offset = "0x3DD1740", VA = "0x183DD2340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x30ADEE0", Offset = "0x30AD2E0", VA = "0x1830ADEE0")]
	[AsyncStateMachine(typeof(ACNBPKKNJIN))]
	public static Task PAOKGAPHMII(MAJJLPEKFOI JEBGPNEHLJO, HHPEKJGCIPO HANEMGLFJMM, HLFEEILEDJE ACBKKMMGKDK, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct LNFBJLODCAH
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public struct ELDGLNJMMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public List<FJMOJEGFIEJ> IKKCCJDELEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public List<FOOKLNINPMB> LOPKMNGGHJH;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x71DA10", Offset = "0x71CE10", VA = "0x18071DA10")]
		public ELDGLNJMMKF(List<FJMOJEGFIEJ> IKKCCJDELEP, List<FOOKLNINPMB> LOPKMNGGHJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class JOIGMGLJDMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public IEnumerable<FJMOJEGFIEJ> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public JOIGMGLJDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x36F2B60", Offset = "0x36F1F60", VA = "0x1836F2B60")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private FPCHIGOFPMO EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private HHPEKJGCIPO HANEMGLFJMM;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private EPHHKFIEIIF LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x26FB1D0", Offset = "0x26FA5D0", VA = "0x1826FB1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x26FB170", Offset = "0x26FA570", VA = "0x1826FB170")]
	public static ELDGLNJMMKF PAOKGAPHMII(FPCHIGOFPMO EOPOLGFEGAI, HHPEKJGCIPO HANEMGLFJMM)
	{
		return default(ELDGLNJMMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x26FAE70", Offset = "0x26FA270", VA = "0x1826FAE70")]
	private ELDGLNJMMKF PAOKGAPHMII()
	{
		return default(ELDGLNJMMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x26FA6D0", Offset = "0x26F9AD0", VA = "0x1826FA6D0")]
	private ELDGLNJMMKF IAGNFAIIKPB(NDKLHPOCFKB AKDLLELODCG, HLMHFEDKGND KDNLBPGKEEE)
	{
		return default(ELDGLNJMMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x26FAC20", Offset = "0x26FA020", VA = "0x1826FAC20")]
	private bool KGAMDMBBKLC(IEnumerable<FJMOJEGFIEJ> IKKCCJDELEP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct EKJBCODNNBA
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class LJEGLFOHOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public LNFBJLODCAH.ELDGLNJMMKF instantiations;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LJEGLFOHOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x30A4CF0", Offset = "0x30A40F0", VA = "0x1830A4CF0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class IEHCLNEKEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IEHCLNEKEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x30A0BF0", Offset = "0x309FFF0", VA = "0x1830A0BF0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x26E7410", Offset = "0x26E6810", VA = "0x1826E7410")]
	public static void PAOKGAPHMII(MAJJLPEKFOI JEBGPNEHLJO, HHPEKJGCIPO HANEMGLFJMM, LNFBJLODCAH.ELDGLNJMMKF JLFLKBOMKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal class IIOGHHMIHGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct LEHLGBGJDGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public BIGLHHECNDA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public HHPEKJGCIPO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x36F50F0", Offset = "0x36F44F0", VA = "0x1836F50F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class NNBKEFDMCKE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public NNBKEFDMCKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x3DE09E0", Offset = "0x3DDFDE0", VA = "0x183DE09E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public LHKKDNHCKDD handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NNBKEFDMCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x36F7C80", Offset = "0x36F7080", VA = "0x1836F7C80")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct LIONLLHBGKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private NNBKEFDMCKE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x36F5740", Offset = "0x36F4B40", VA = "0x1836F5740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct KAGMNLBPBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private Dictionary<Guid, List<NDDJJJKNNLH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x36F2BE0", Offset = "0x36F1FE0", VA = "0x1836F2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct EOJMBBKFEIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private LHKKDNHCKDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private Dictionary<Guid, List<NDDJJJKNNLH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x36EC3E0", Offset = "0x36EB7E0", VA = "0x1836EC3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class HJGPDBIBJEP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public NDDJJJKNNLH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public HJGPDBIBJEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE1E0", Offset = "0x3DDD5E0", VA = "0x183DDE1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public PNDNNBOIBEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public List<NDDJJJKNNLH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HJGPDBIBJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x36EFDD0", Offset = "0x36EF1D0", VA = "0x1836EFDD0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x36EFFB0", Offset = "0x36EF3B0", VA = "0x1836EFFB0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(NDDJJJKNNLH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x36EFEC0", Offset = "0x36EF2C0", VA = "0x1836EFEC0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct KCMNKONNCAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public PNDNNBOIBEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public List<NDDJJJKNNLH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private HJGPDBIBJEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x36F3060", Offset = "0x36F2460", VA = "0x1836F3060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct HMJGEMNBLMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public LHKKDNHCKDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x36F0620", Offset = "0x36EFA20", VA = "0x1836F0620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class GHIPPBHCEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GHIPPBHCEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x36EF5D0", Offset = "0x36EE9D0", VA = "0x1836EF5D0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct HMJPCGPDALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public HHPEKJGCIPO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x36F08A0", Offset = "0x36EFCA0", VA = "0x1836F08A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class AHLELCJKKMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AHLELCJKKMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x36E65F0", Offset = "0x36E59F0", VA = "0x1836E65F0")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct KDOBNJIHLCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public IIOGHHMIHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x36F35E0", Offset = "0x36F29E0", VA = "0x1836F35E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class MPLCMHABGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public MPLCMHABGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x36F73B0", Offset = "0x36F67B0", VA = "0x1836F73B0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private readonly NECOACPILOL OJPOMAFEDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private CGHHDADKOEP NONOCLKCDLP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private MAJJLPEKFOI KJKJAELFADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A60", Offset = "0x7C1E60", VA = "0x1807C2A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	public IIOGHHMIHGO(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x26F5660", Offset = "0x26F4A60", VA = "0x1826F5660")]
	[AsyncStateMachine(typeof(LEHLGBGJDGO))]
	public Task PAOKGAPHMII(BIGLHHECNDA GBHODPDIKNP, HHPEKJGCIPO MMJILEAOBBD, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x26F4C60", Offset = "0x26F4060", VA = "0x1826F4C60")]
	[AsyncStateMachine(typeof(LIONLLHBGKK))]
	private Task GCGKIJCCONI(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x26F57C0", Offset = "0x26F4BC0", VA = "0x1826F57C0")]
	[AsyncStateMachine(typeof(KAGMNLBPBLG))]
	private Task PDBPJHFHLME(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x26F49C0", Offset = "0x26F3DC0", VA = "0x1826F49C0")]
	[AsyncStateMachine(typeof(EOJMBBKFEIE))]
	private Task EJENBHPCMHE(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x26F4B20", Offset = "0x26F3F20", VA = "0x1826F4B20")]
	[AsyncStateMachine(typeof(KCMNKONNCAI))]
	private Task FKNBLMKCFMH(Guid ABEGMKKMFNK, List<NDDJJJKNNLH> ANLBLIEOMBK, PNDNNBOIBEB NMCENKAFOMH, HHPEKJGCIPO HANEMGLFJMM, CancellationToken PFJMMABJIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x26F4F90", Offset = "0x26F4390", VA = "0x1826F4F90")]
	[AsyncStateMachine(typeof(HMJGEMNBLMF))]
	private Task IFPPPJLCGIO(HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x26F5520", Offset = "0x26F4920", VA = "0x1826F5520")]
	[AsyncStateMachine(typeof(HMJPCGPDALJ))]
	private Task MKNGAGFCDKH(Guid GBCJMCLFLDI, HHPEKJGCIPO HANEMGLFJMM, LHKKDNHCKDD PPFBACEKDKI, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x26F50E0", Offset = "0x26F44E0", VA = "0x1826F50E0")]
	[AsyncStateMachine(typeof(KDOBNJIHLCG))]
	private Task KPODIONLCJK(Guid GBCJMCLFLDI, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x26F4830", Offset = "0x26F3C30", VA = "0x1826F4830")]
	private void BMNAOIIBIMA(Guid GBCJMCLFLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5400", Offset = "0x26F4800", VA = "0x1826F5400")]
	private void MFBMNCAKAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x26F5230", Offset = "0x26F4630", VA = "0x1826F5230")]
	public Guid MEMIBJHNBFG(BIGLHHECNDA FJCLAHLFFDB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x26F4DC0", Offset = "0x26F41C0", VA = "0x1826F4DC0")]
	[CompilerGenerated]
	private object GIBGHIIFBNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
public readonly struct NGOHFOABHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	[CanBeNull]
	public readonly NDKLHPOCFKB CDIMJGDBGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	[NotNull]
	public readonly IMGLAOJJEBH KJJNAOAPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	[CanBeNull]
	public readonly string MELFNNGMJGI;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public IReadOnlyCollection<string> PEOMBBAFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x30ABC10", Offset = "0x30AB010", VA = "0x1830ABC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IReadOnlyDictionary<long, int> OIAOCBMOBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x30ABBF0", Offset = "0x30AAFF0", VA = "0x1830ABBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x30ABC30", Offset = "0x30AB030", VA = "0x1830ABC30")]
	public NGOHFOABHJO([CanBeNull] NDKLHPOCFKB OAGMMIBDFHK, [NotNull] IMGLAOJJEBH FILDBLMIJOK, [CanBeNull] string IJBOACAPDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class CCOBELPMAFF : FFMANBPPBKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct DNJCINOIMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder<NGOHFOABHJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CCOBELPMAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public LEAJJDOJJEL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x309CF90", Offset = "0x309C390", VA = "0x18309CF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x309D460", Offset = "0x309C860", VA = "0x18309D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class BOLPDHBCNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public LEAJJDOJJEL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BOLPDHBCNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x309B490", Offset = "0x309A890", VA = "0x18309B490")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class APFIMDMPJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public BOLPDHBCNHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public APFIMDMPJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x309AB30", Offset = "0x3099F30", VA = "0x18309AB30")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class DFBLKBIAMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public BOLPDHBCNHM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DFBLKBIAMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x309CF50", Offset = "0x309C350", VA = "0x18309CF50")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct AIKHJEDOCPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public LEAJJDOJJEL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public CCOBELPMAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private APFIMDMPJJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private LPDBJMLAAPD.NLDDAAACJND <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x309A0E0", Offset = "0x30994E0", VA = "0x18309A0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private readonly MPCGGAFNNOH OANBKEOGOCO;

	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private static readonly TimeSpan BKLLPBMIJAB;

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x26E0860", Offset = "0x26DFC60", VA = "0x1826E0860")]
	public CCOBELPMAFF(NECOACPILOL OJPOMAFEDGN, [Optional] MPCGGAFNNOH? OANBKEOGOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x26DF850", Offset = "0x26DEC50", VA = "0x1826DF850")]
	[AsyncStateMachine(typeof(DNJCINOIMMF))]
	public Task<NGOHFOABHJO> CAOILNKOGOI(long EBLMJJHFMLK, string IJBOACAPDKG, LEAJJDOJJEL IBEHNPLFNDP, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x26E02C0", Offset = "0x26DF6C0", VA = "0x1826E02C0")]
	[AsyncStateMachine(typeof(AIKHJEDOCPP))]
	private Task FENGLHMGILO(LEAJJDOJJEL IBEHNPLFNDP, IEnumerable<PersistenceView> GIIMCCIMEHG, StringBuilder MKENMJLMAIO, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x26DFF00", Offset = "0x26DF300", VA = "0x1826DFF00")]
	private NGOHFOABHJO FCINIBPIMOE(long EBLMJJHFMLK, string IJBOACAPDKG, LEAJJDOJJEL IBEHNPLFNDP, IEnumerable<PersistenceView> GIIMCCIMEHG, StringBuilder MKENMJLMAIO)
	{
		return default(NGOHFOABHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x26E0640", Offset = "0x26DFA40", VA = "0x1826E0640")]
	private NDKLHPOCFKB IAIGLLMALCP(long EBLMJJHFMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x26E0420", Offset = "0x26DF820", VA = "0x1826E0420")]
	private void HNKMHNNFMPC(NDKLHPOCFKB KIOJNOPCCAB, StringBuilder MKENMJLMAIO, IEnumerable<PersistenceView> GIIMCCIMEHG, in BADFCIOHMAF APKCPEDKOCI, ref ONOHHLKFPBO BPBNFHOEFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x26DF9D0", Offset = "0x26DEDD0", VA = "0x1826DF9D0")]
	private void CHFKDCDLKCK(NDKLHPOCFKB KIOJNOPCCAB, StringBuilder MKENMJLMAIO, PersistenceView ODDIKGOJDNI, ref ONOHHLKFPBO BPBNFHOEFMO, in BADFCIOHMAF APKCPEDKOCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class MFADLMANDLE : FFMANBPPBKB
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class KDFCFJGLDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public NDPLAKFEGGD.NNCGIFFCBLI roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public NDPLAKFEGGD.NNCGIFFCBLI subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KDFCFJGLDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9CA0", Offset = "0x3DD90A0", VA = "0x183DD9CA0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9D30", Offset = "0x3DD9130", VA = "0x183DD9D30")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9D80", Offset = "0x3DD9180", VA = "0x183DD9D80")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9DF0", Offset = "0x3DD91F0", VA = "0x183DD9DF0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct KMPDJAGALNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder<(NDPLAKFEGGD.NNCGIFFCBLI roomDataUpload, NDPLAKFEGGD.NNCGIFFCBLI subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public NGOHFOABHJO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public MFADLMANDLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private KDFCFJGLDGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter<NDPLAKFEGGD.NNCGIFFCBLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA030", Offset = "0x3DD9430", VA = "0x183DDA030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAA80", Offset = "0x3DD9E80", VA = "0x183DDAA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct BNLNGCKBIAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public AsyncTaskMethodBuilder<PPFCGBHBMGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public MFADLMANDLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public NGOHFOABHJO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AGKPHDPNGFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter<(NDPLAKFEGGD.NNCGIFFCBLI roomDataUpload, NDPLAKFEGGD.NNCGIFFCBLI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private TaskAwaiter<LHBMFFMOHEL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2E90", Offset = "0x3DD2290", VA = "0x183DD2E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD32A0", Offset = "0x3DD26A0", VA = "0x183DD32A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct HBIOACKPGNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<CIJJEIINFMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public MFADLMANDLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public NGOHFOABHJO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(NDPLAKFEGGD.NNCGIFFCBLI roomDataUpload, NDPLAKFEGGD.NNCGIFFCBLI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private TaskAwaiter<CIJJEIINFMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6F60", Offset = "0x3DD6360", VA = "0x183DD6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD72F0", Offset = "0x3DD66F0", VA = "0x183DD72F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class OHOAAAIEEEP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			public OHOAAAIEEEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400060E")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			private IMHJALLFDIF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			private TaskAwaiter<CIJJEIINFMP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			private TaskAwaiter<PPFCGBHBMGI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			private TaskAwaiter<IMHJALLFDIF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0EC0", Offset = "0x3DE02C0", VA = "0x183DE0EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1B40", Offset = "0x3DE0F40", VA = "0x183DE1B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public MFADLMANDLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public NGOHFOABHJO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AGKPHDPNGFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OHOAAAIEEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCCF0", Offset = "0x3DDC0F0", VA = "0x183DDCCF0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<IMHJALLFDIF> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct GKDFAAGIJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public AsyncTaskMethodBuilder<IMHJALLFDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public MFADLMANDLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public NGOHFOABHJO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AGKPHDPNGFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<IMHJALLFDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6C60", Offset = "0x3DD6060", VA = "0x183DD6C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6F10", Offset = "0x3DD6310", VA = "0x183DD6F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private const float JFONGBFIMAF = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private readonly KFIEMLFNNDD GJGOIIDCDPF;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private FPCHIGOFPMO DEKBIFMJEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x26F3A00", Offset = "0x26F2E00", VA = "0x1826F3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x30A7520", Offset = "0x30A6920", VA = "0x1830A7520")]
	public MFADLMANDLE(NECOACPILOL OJPOMAFEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x30A7090", Offset = "0x30A6490", VA = "0x1830A7090")]
	[AsyncStateMachine(typeof(KMPDJAGALNB))]
	private Task<(NDPLAKFEGGD.NNCGIFFCBLI, NDPLAKFEGGD.NNCGIFFCBLI)> FNBIKJNEKIP(NGOHFOABHJO NGILCOFMNJO, long CNEPCDGFLLD, long FOCJCCBGAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x30A7390", Offset = "0x30A6790", VA = "0x1830A7390")]
	[AsyncStateMachine(typeof(BNLNGCKBIAK))]
	public Task<PPFCGBHBMGI> OICINNEHIJD(int IMBPHKGBKCB, [CanBeNull] AGKPHDPNGFE IJHFPDLHEBO, NGOHFOABHJO NGILCOFMNJO, long CNEPCDGFLLD, long FOCJCCBGAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x30A7200", Offset = "0x30A6600", VA = "0x1830A7200")]
	[AsyncStateMachine(typeof(HBIOACKPGNH))]
	private Task<CIJJEIINFMP> NHKLFHDOAEH(string BCPIELJKEFM, int IMBPHKGBKCB, NGOHFOABHJO NGILCOFMNJO, long CNEPCDGFLLD, long FOCJCCBGAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x30A6EE0", Offset = "0x30A62E0", VA = "0x1830A6EE0")]
	[AsyncStateMachine(typeof(GKDFAAGIJHH))]
	public Task<IMHJALLFDIF> EELKLMICGKF(int IMBPHKGBKCB, [CanBeNull] AGKPHDPNGFE IJHFPDLHEBO, NGOHFOABHJO NGILCOFMNJO, long CNEPCDGFLLD, long FOCJCCBGAFG, LHKKDNHCKDD DIECPHHHGGG, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public abstract class ONFAFFACGBJ<T> where T : global::ONFAFFACGBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	internal readonly FPCHIGOFPMO DNPDIECDNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private int? GEKJCHOGBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	protected readonly Guid AEKAPGAJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	protected readonly CKCMKMGEMBD DGIJGNPHEIH;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	protected T AIKLAOFNEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x4341AC0", Offset = "0x4340EC0", VA = "0x184341AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x4341E10", Offset = "0x4341210", VA = "0x184341E10")]
	internal ONFAFFACGBJ(FPCHIGOFPMO EFIDBBHFIJD, CKCMKMGEMBD IBAOIPLKGIH, [Optional] Guid? OEFPMGEGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x4341D30", Offset = "0x4341130", VA = "0x184341D30")]
	private IMHJALLFDIF MPFIHGIOMNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	protected virtual void CGBNMOGKHHN(IMHJALLFDIF HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x4341CA0", Offset = "0x43410A0", VA = "0x184341CA0")]
	public T LACLOIFLIGE(NEDBMOFEKBM JCPINPGGEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x4341C20", Offset = "0x4341020", VA = "0x184341C20")]
	public T IBOLPDNMDMO(int FJNFCKFINKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x4341B20", Offset = "0x4340F20", VA = "0x184341B20", Slot = "5")]
	public virtual Task<MBCHBOFNLBC> GLIFMDCHILD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
public class JAOJILANMJO : global::ONFAFFACGBJ<JAOJILANMJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private GNGDEKNEGGO EGDJKJOHALJ;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A20", Offset = "0x26F6E20", VA = "0x1826F7A20")]
	internal JAOJILANMJO(FPCHIGOFPMO EFIDBBHFIJD, CKCMKMGEMBD IBAOIPLKGIH, [Optional] Guid? OEFPMGEGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x26F7920", Offset = "0x26F6D20", VA = "0x1826F7920")]
	public JAOJILANMJO GOJIBOBACNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x26F77C0", Offset = "0x26F6BC0", VA = "0x1826F77C0")]
	public JAOJILANMJO CEMBNOOHJEL(NOOLKJHEPHD BGEDADFIFAH, PPFCGBHBMGI IAMCHHNPPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A00", Offset = "0x26F6E00", VA = "0x1826F7A00")]
	public JAOJILANMJO KIJNJEBNPLE(GNGDEKNEGGO EGDJKJOHALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x26F7860", Offset = "0x26F6C60", VA = "0x1826F7860", Slot = "4")]
	protected override void CGBNMOGKHHN(IMHJALLFDIF HKDHNKHPGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class FJHKEBJJBNN : global::ONFAFFACGBJ<FJHKEBJJBNN>
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	internal enum GICFFLGKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct KKCDHCOAAHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<MBCHBOFNLBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public FJHKEBJJBNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private TaskAwaiter<MBCHBOFNLBC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x36F4720", Offset = "0x36F3B20", VA = "0x1836F4720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x36F4A20", Offset = "0x36F3E20", VA = "0x1836F4A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private GICFFLGKPMJ LEBNBOACHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private string CMPDAGIGOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private AGKPHDPNGFE EGDJKJOHALJ;

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5A0", Offset = "0x26ED9A0", VA = "0x1826EE5A0")]
	internal FJHKEBJJBNN(FPCHIGOFPMO EFIDBBHFIJD, CKCMKMGEMBD IBAOIPLKGIH, [Optional] Guid? OEFPMGEGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x26EE550", Offset = "0x26ED950", VA = "0x1826EE550")]
	public FJHKEBJJBNN KIJNJEBNPLE(AGKPHDPNGFE IJHFPDLHEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x26EE400", Offset = "0x26ED800", VA = "0x1826EE400")]
	public FJHKEBJJBNN FAEFELOJCEB(string BABJIPJIPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x26EE570", Offset = "0x26ED970", VA = "0x1826EE570")]
	public FJHKEBJJBNN MFKNECDJOOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x26EE290", Offset = "0x26ED690", VA = "0x1826EE290", Slot = "4")]
	protected override void CGBNMOGKHHN(IMHJALLFDIF HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x26EE430", Offset = "0x26ED830", VA = "0x1826EE430", Slot = "5")]
	[AsyncStateMachine(typeof(KKCDHCOAAHJ))]
	public override Task<MBCHBOFNLBC> GLIFMDCHILD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x26EE250", Offset = "0x26ED650", VA = "0x1826EE250")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<MBCHBOFNLBC> BEHJADEHPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal static class FOJODIFLFFN
{
	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x26EEDC0", Offset = "0x26EE1C0", VA = "0x1826EEDC0")]
	public static void MOIOOMJLGED(this PFJAFPLIJBN INFFPNPJFHC, NOOLKJHEPHD ECLCBPMABPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x26EEF10", Offset = "0x26EE310", VA = "0x1826EEF10")]
	public static void PCDPDOHLEIK(this NOOLKJHEPHD ELGKGHJLIGG, [Optional] string HKDHNKHPGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public static class FGCIHJPDJKN
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x26EE1B0", Offset = "0x26ED5B0", VA = "0x1826EE1B0")]
	public static ECIBCEENAKM FPIJGDAMJFD(this CLDGEJBINNH FOLBNLFCLOC)
	{
		return default(ECIBCEENAKM);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			public PFDFKPAFKNP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public PFDFKPAFKNP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private static PFDFKPAFKNP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<PFDFKPAFKNP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x30B3080", Offset = "0x30B2480", VA = "0x1830B3080")]
		public bool HMHEDLGFCLF(PFDFKPAFKNP MLBDEMHAIEE, out ResultConfig CLBPEMDNLDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x30B2F60", Offset = "0x30B2360", VA = "0x1830B2F60")]
		public ResultConfig FGJKBMDCNMN(PFDFKPAFKNP MHLBJBFFDIN, [Optional] HashSet<PFDFKPAFKNP> CEEAEIODKDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x30B3670", Offset = "0x30B2A70", VA = "0x1830B3670", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x30B30F0", Offset = "0x30B24F0", VA = "0x1830B30F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01C80", VA = "0x180F02880")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public static class ABPHJPDDEJK
{
	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x26DA700", Offset = "0x26D9B00", VA = "0x1826DA700")]
	[AMOLIILEGPJ(OPIFOMJNBJD.GameOnly)]
	private static void HMILCOJDCME(KADOJAOKIOP FOAKHNLHFMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public interface MDLACFNPHOC : IEquatable<MDLACFNPHOC>
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	DateTime MAOOIFBOMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDPLHIFFKNA();

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKPKDOOIOKJ(long CNEPCDGFLLD, long EBLMJJHFMLK, out NGOHFOABHJO NGILCOFMNJO);
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class HNHBCPMFEJA : MBDLGBBNDBG
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class NMEAHJEJJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public JBMIEGHLKOB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NMEAHJEJJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x36F7C10", Offset = "0x36F7010", VA = "0x1836F7C10")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private readonly POPFLAPIFHA LFKJCGLOLMB;

	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private const int EKAHOJELDFH = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<MDLACFNPHOC> OBLALEEPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x26F0BB0", Offset = "0x26EFFB0", VA = "0x1826F0BB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x26F0B10", Offset = "0x26EFF10", VA = "0x1826F0B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	[Preserve]
	public HNHBCPMFEJA([FFFBKAEBNFI(null)] POPFLAPIFHA LFKJCGLOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x26F0D70", Offset = "0x26F0170", VA = "0x1826F0D70", Slot = "6")]
	public bool NHALJANENEN(long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO, JBMIEGHLKOB FBNDPLHPLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x26F0A70", Offset = "0x26EFE70", VA = "0x1826F0A70")]
	private void IBBEHFGOMFI(MDLACFNPHOC FJKNLEFOLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x26F1070", Offset = "0x26F0470", VA = "0x1826F1070", Slot = "7")]
	public bool OMNCEAEFKGP(long CNEPCDGFLLD, long EBLMJJHFMLK, out MDLACFNPHOC MEEMHAEBANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x26F09C0", Offset = "0x26EFDC0", VA = "0x1826F09C0", Slot = "8")]
	public bool EDMLNHLJGMD(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, out MDLACFNPHOC MEEMHAEBANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x26F0560", Offset = "0x26EF960", VA = "0x1826F0560")]
	private void BGNAPLNKNIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x26F0C50", Offset = "0x26F0050", VA = "0x1826F0C50", Slot = "9")]
	public void KPIDFAMGPGB(long CNEPCDGFLLD, long EBLMJJHFMLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal abstract class OGPHHPJCHHH : POPFLAPIFHA
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	protected enum JNCOFEEMEAL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class POMFJMNMJMA : IEnumerable<MDLACFNPHOC>, IEnumerable, IEnumerator<MDLACFNPHOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private MDLACFNPHOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public OGPHHPJCHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private JBMIEGHLKOB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public JBMIEGHLKOB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		private MDLACFNPHOC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public POMFJMNMJMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDF90", Offset = "0x3DDD390", VA = "0x183DDDF90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE1A0", Offset = "0x3DDD5A0", VA = "0x183DDE1A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE0F0", Offset = "0x3DDD4F0", VA = "0x183DDE0F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MDLACFNPHOC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE0F0", Offset = "0x3DDD4F0", VA = "0x183DDE0F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class CGHAIDNGGOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public JBMIEGHLKOB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CGHAIDNGGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DD32F0", Offset = "0x3DD26F0", VA = "0x183DD32F0")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class PFIMNOADMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public OGPHHPJCHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PFIMNOADMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD480", Offset = "0x3DDC880", VA = "0x183DDD480")]
		internal void <TryReadAutosaveFile>b__0(BKHGAGNHELB.BMNLLHIEFJB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	protected readonly string HLHOCGBHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly object LLHOHNILFLI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x30AD1B0", Offset = "0x30AC5B0", VA = "0x1830AD1B0")]
	protected OGPHHPJCHHH([CanBeNull] string NIEOLNKMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x30ACD50", Offset = "0x30AC150", VA = "0x1830ACD50", Slot = "5")]
	public bool NJAMPOEEBEC(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, out MDLACFNPHOC FJKNLEFOLCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30AC930", Offset = "0x30ABD30", VA = "0x1830AC930", Slot = "6")]
	[IteratorStateMachine(typeof(POMFJMNMJMA))]
	public IEnumerable<MDLACFNPHOC> BCHHCIBDDNP(JBMIEGHLKOB FBNDPLHPLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void AJMCCLEDEEP(Stream ACCECBOBICD, long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool KPCKBDDCBBA(Stream AMLFCGLHCOF, long CNEPCDGFLLD, long EBLMJJHFMLK, NEOMDELONJJ LNOHKMMIBCI, out NGOHFOABHJO NGILCOFMNJO);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x30AC9B0", Offset = "0x30ABDB0", VA = "0x1830AC9B0", Slot = "7")]
	public MDLACFNPHOC FBKIDLKMPBF(long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO, JBMIEGHLKOB FBNDPLHPLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo CLENCDNGBCD(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo AAPNNBLENFL(JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x30ACCE0", Offset = "0x30AC0E0", VA = "0x1830ACCE0")]
	protected void JDOOMJOOAPK(BKHGAGNHELB.BMNLLHIEFJB DMAJNILCAOC, string PIEECBDBBLD, FileInfo OBCGOJKLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x30ACF00", Offset = "0x30AC300", VA = "0x1830ACF00")]
	internal bool PICHKLELJEK(FileInfo HAAHINPOKLM, long CNEPCDGFLLD, long EBLMJJHFMLK, out NGOHFOABHJO NGILCOFMNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private void IACLJOHOKFG(Exception GCOPFBLODIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class JBIIDGBFBDA : OGPHHPJCHHH
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private const string LDDIILAAHOK = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private const string AGCKLJEHHAL = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private const string OLNOPFGIIHB = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public override BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x12D5A70", Offset = "0x12D4E70", VA = "0x1812D5A70", Slot = "8")]
		get
		{
			return default(BDFJJPPLECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x26F8460", Offset = "0x26F7860", VA = "0x1826F8460")]
	public JBIIDGBFBDA([Optional] string NIEOLNKMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x26F7F70", Offset = "0x26F7370", VA = "0x1826F7F70")]
	private void GDAHKEIEOKE(JBMIEGHLKOB FBNDPLHPLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x26F7C70", Offset = "0x26F7070", VA = "0x1826F7C70", Slot = "9")]
	internal override void AJMCCLEDEEP(Stream ACCECBOBICD, long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x26F7FF0", Offset = "0x26F73F0", VA = "0x1826F7FF0", Slot = "10")]
	internal override bool KPCKBDDCBBA(Stream AMLFCGLHCOF, long CNEPCDGFLLD, long EBLMJJHFMLK, NEOMDELONJJ LNOHKMMIBCI, out NGOHFOABHJO NGILCOFMNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x26F7E80", Offset = "0x26F7280", VA = "0x1826F7E80", Slot = "11")]
	protected override FileInfo CLENCDNGBCD(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x26F7B60", Offset = "0x26F6F60", VA = "0x1826F7B60", Slot = "12")]
	protected override DirectoryInfo AAPNNBLENFL(JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal sealed class ANAAEEKKIMF : OGPHHPJCHHH
{
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private static readonly byte[] MPIADBGKNBD;

	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private const string AGCKLJEHHAL = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private const string OLNOPFGIIHB = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private const string EMHLFPINILA = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private readonly byte[] OHNCDCCAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private readonly byte[] NGPOONIIBLM;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public override BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x726420", VA = "0x180727020", Slot = "8")]
		get
		{
			return default(BDFJJPPLECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x26DBC70", Offset = "0x26DB070", VA = "0x1826DBC70")]
	public ANAAEEKKIMF([Optional] string NIEOLNKMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x26DB0C0", Offset = "0x26DA4C0", VA = "0x1826DB0C0", Slot = "9")]
	internal override void AJMCCLEDEEP(Stream ACCECBOBICD, long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x26DB560", Offset = "0x26DA960", VA = "0x1826DB560", Slot = "10")]
	internal override bool KPCKBDDCBBA(Stream AMLFCGLHCOF, long CNEPCDGFLLD, long EBLMJJHFMLK, NEOMDELONJJ LNOHKMMIBCI, out NGOHFOABHJO NGILCOFMNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x26DB450", Offset = "0x26DA850", VA = "0x1826DB450")]
	private void FOINLGBPICA(byte[] OGILIIFBKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x26DB320", Offset = "0x26DA720", VA = "0x1826DB320", Slot = "11")]
	protected override FileInfo CLENCDNGBCD(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x26DAFA0", Offset = "0x26DA3A0", VA = "0x1826DAFA0", Slot = "12")]
	protected override DirectoryInfo AAPNNBLENFL(JBMIEGHLKOB FBNDPLHPLDD, JNCOFEEMEAL HLBIBANMKCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
public enum BDFJJPPLECC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class BOHEEMODLLN : POPFLAPIFHA
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class HNLLENHNNGD : IEnumerable<MDLACFNPHOC>, IEnumerable, IEnumerator<MDLACFNPHOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private MDLACFNPHOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public BOHEEMODLLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private JBMIEGHLKOB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public JBMIEGHLKOB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private BDFJJPPLECC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private IEnumerator<MDLACFNPHOC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private MDLACFNPHOC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public HNLLENHNNGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x309FBD0", Offset = "0x309EFD0", VA = "0x18309FBD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x309F860", Offset = "0x309EC60", VA = "0x18309F860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x309FC60", Offset = "0x309F060", VA = "0x18309FC60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x309FB90", Offset = "0x309EF90", VA = "0x18309FB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x309FAE0", Offset = "0x309EEE0", VA = "0x18309FAE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MDLACFNPHOC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x309FAE0", Offset = "0x309EEE0", VA = "0x18309FAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private readonly BDFJJPPLECC[] EKCMOAMMJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private readonly Dictionary<BDFJJPPLECC, POPFLAPIFHA> HHDGCKIPLJO;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x26DEC90", Offset = "0x26DE090", VA = "0x1826DEC90", Slot = "4")]
		get
		{
			return default(BDFJJPPLECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x26DECD0", Offset = "0x26DE0D0", VA = "0x1826DECD0")]
	[Preserve]
	public BOHEEMODLLN(params POPFLAPIFHA[] DLCAJNNJJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x26DEB30", Offset = "0x26DDF30", VA = "0x1826DEB30", Slot = "5")]
	public bool NJAMPOEEBEC(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, out MDLACFNPHOC FJKNLEFOLCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x26DE810", Offset = "0x26DDC10", VA = "0x1826DE810")]
	private void DHKIPJIILDJ(int KBIPILPDOGI, long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x26DE790", Offset = "0x26DDB90", VA = "0x1826DE790", Slot = "6")]
	[IteratorStateMachine(typeof(HNLLENHNNGD))]
	public IEnumerable<MDLACFNPHOC> BCHHCIBDDNP(JBMIEGHLKOB FBNDPLHPLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x26DEA40", Offset = "0x26DDE40", VA = "0x1826DEA40", Slot = "7")]
	public MDLACFNPHOC FBKIDLKMPBF(long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO, JBMIEGHLKOB FBNDPLHPLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal static class MACDKMHOPOP
{
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	internal const int IAHFEAMGMFF = 32;

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x30A52B0", Offset = "0x30A46B0", VA = "0x1830A52B0")]
	internal static byte[] FOGGMKEHOIN(byte[] OGILIIFBKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x30A5530", Offset = "0x30A4930", VA = "0x1830A5530")]
	public static void PIMDEBDCLJP(Stream GHBMNGPKFNO, byte[] JNJKAHNDANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x30A5350", Offset = "0x30A4750", VA = "0x1830A5350")]
	public static bool OPDDIEFNHEH(Stream GHBMNGPKFNO, long NADGCPKAIHM, NEOMDELONJJ BFDJIHKFGBE, out byte[] KCICHCEDKBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal sealed class BADIACNKHNE : MDLACFNPHOC, IEquatable<MDLACFNPHOC>, IEquatable<BADIACNKHNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private readonly OGPHHPJCHHH BOKBHEEMMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly FileInfo HHFIGGIGGKM;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x9FE240", Offset = "0x9FD640", VA = "0x1809FE240", Slot = "4")]
		get
		{
			return default(BDFJJPPLECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public DateTime MAOOIFBOMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x26DC6A0", Offset = "0x26DBAA0", VA = "0x1826DC6A0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x26DC7F0", Offset = "0x26DBBF0", VA = "0x1826DC7F0")]
	public BADIACNKHNE(OGPHHPJCHHH EGEMHGMNEKH, FileInfo HAAHINPOKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x26DC740", Offset = "0x26DBB40", VA = "0x1826DC740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x26DC270", Offset = "0x26DB670", VA = "0x1826DC270", Slot = "6")]
	public void CDPLHIFFKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x26DC330", Offset = "0x26DB730", VA = "0x1826DC330", Slot = "7")]
	public bool EKPKDOOIOKJ(long CNEPCDGFLLD, long EBLMJJHFMLK, out NGOHFOABHJO NGILCOFMNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x26DC420", Offset = "0x26DB820", VA = "0x1826DC420", Slot = "8")]
	public bool Equals(MDLACFNPHOC BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x26DC370", Offset = "0x26DB770", VA = "0x1826DC370", Slot = "9")]
	public bool Equals(BADIACNKHNE BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x26DC500", Offset = "0x26DB900", VA = "0x1826DC500", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x26DC600", Offset = "0x26DBA00", VA = "0x1826DC600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x1804020", Offset = "0x1803420", VA = "0x181804020")]
	public static bool HOHCOENENOO(BADIACNKHNE LJEFIPFJBOF, BADIACNKHNE DAPBJAIHDIF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x1803E70", Offset = "0x1803270", VA = "0x181803E70")]
	public static bool GJGNKFAGFPG(BADIACNKHNE LJEFIPFJBOF, BADIACNKHNE DAPBJAIHDIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public delegate void NEOMDELONJJ(BKHGAGNHELB.BMNLLHIEFJB ICLPHECHGKK, string HKDHNKHPGDP);
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal interface POPFLAPIFHA
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	BDFJJPPLECC JPMCIPDNHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJAMPOEEBEC(long CNEPCDGFLLD, long EBLMJJHFMLK, JBMIEGHLKOB FBNDPLHPLDD, out MDLACFNPHOC FJKNLEFOLCN);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<MDLACFNPHOC> BCHHCIBDDNP(JBMIEGHLKOB FBNDPLHPLDD);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MDLACFNPHOC FBKIDLKMPBF(long CNEPCDGFLLD, long EBLMJJHFMLK, NGOHFOABHJO NGILCOFMNJO, JBMIEGHLKOB FBNDPLHPLDD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x26F64E0", Offset = "0x26F58E0", VA = "0x1826F64E0")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x26F6190", Offset = "0x26F5590", VA = "0x1826F6190")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400067A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
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
