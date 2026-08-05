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
public class CBAKCJPLJJB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x268DDE0", Offset = "0x268CDE0", VA = "0x18268DDE0")]
	public CBAKCJPLJJB(string LMLMHJKGDCH, Exception ACPNJFGCPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class PEOADNLHBPA : HHLPCPLKKFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NOEMBPOIJIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<EPNJNOPJDEL>> <>t__builder;

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
		private TaskAwaiter<global::PAIFNMPNFEI<EPNJNOPJDEL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D30310", Offset = "0x3D2F310", VA = "0x183D30310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D304F0", Offset = "0x3D2F4F0", VA = "0x183D304F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct BJKKLIHDLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IOMKAICGADJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<IOMKAICGADJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D259C0", Offset = "0x3D249C0", VA = "0x183D259C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D25B80", Offset = "0x3D24B80", VA = "0x183D25B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	[Preserve]
	public PEOADNLHBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D8B0", Offset = "0x2E6C8B0", VA = "0x182E6D8B0", Slot = "4")]
	[AsyncStateMachine(typeof(NOEMBPOIJIB))]
	public Task<IReadOnlyList<EPNJNOPJDEL>> LEDGHEFFEBJ(long KPBGCMCAECK, long CFCAAMCKONC, [Optional] CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D770", Offset = "0x2E6C770", VA = "0x182E6D770", Slot = "5")]
	[AsyncStateMachine(typeof(BJKKLIHDLLF))]
	public Task<IReadOnlyList<IOMKAICGADJ>> IIHLOPGNBNE(IReadOnlyList<int> IAHEDFIHALC, [Optional] CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JOPIOJDDLBN : IEquatable<JOPIOJDDLBN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int AEOBAOCLDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	IOMKAICGADJ ANENJLMGAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DNMAEPOIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EPIKAMAPMAF? GNBFIIGKIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CKKLBGOIJKE? PFGDNDEHKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	GMDNAFOPMOO EIPAEBECNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NIHJKBCEGCJ> FBHLNEPBIAG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GMDNAFOPMOO
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HHLPCPLKKFH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<EPNJNOPJDEL>> LEDGHEFFEBJ(long KPBGCMCAECK, long CFCAAMCKONC, [Optional] CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<IOMKAICGADJ>> IIHLOPGNBNE(IReadOnlyList<int> IAHEDFIHALC, [Optional] CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GDDBLKKNHHG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class IFKAPHKKAMP : JOPIOJDDLBN, IEquatable<JOPIOJDDLBN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct IFNMAENBFAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IFKAPHKKAMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private IOJNPFFHDDA <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<HIEMHHFNKEP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<NIHJKBCEGCJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3D2AC80", Offset = "0x3D29C80", VA = "0x183D2AC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B110", Offset = "0x3D2A110", VA = "0x183D2B110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EPNJNOPJDEL KCGCGGFHHGJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AEOBAOCLDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IOMKAICGADJ ANENJLMGAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime PDMOKCBDENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x11CE660", Offset = "0x11CD660", VA = "0x1811CE660", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EPIKAMAPMAF? GNBFIIGKIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x852970", Offset = "0x851970", VA = "0x180852970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CKKLBGOIJKE? PFGDNDEHKCE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x852930", Offset = "0x851930", VA = "0x180852930", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GMDNAFOPMOO EIPAEBECNAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6A4AA0", Offset = "0x6A3AA0", VA = "0x1806A4AA0", Slot = "10")]
			get
			{
				return default(GMDNAFOPMOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x31F2190", Offset = "0x31F1190", VA = "0x1831F2190", Slot = "9")]
		[AsyncStateMachine(typeof(IFNMAENBFAG))]
		public Task<NIHJKBCEGCJ> FBHLNEPBIAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x31F2350", Offset = "0x31F1350", VA = "0x1831F2350")]
		public IFKAPHKKAMP(int OEOCDNGNJAG, IOMKAICGADJ AHODNKDLJJG, EPNJNOPJDEL KCGCGGFHHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x31F2100", Offset = "0x31F1100", VA = "0x1831F2100", Slot = "11")]
		public bool Equals(JOPIOJDDLBN KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x31F2060", Offset = "0x31F1060", VA = "0x1831F2060", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x31F2020", Offset = "0x31F1020", VA = "0x1831F2020")]
		private bool AGKLKJAKGKE(IFKAPHKKAMP KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x31F22C0", Offset = "0x31F12C0", VA = "0x1831F22C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class LHKBLOGJLJA : JOPIOJDDLBN, IEquatable<JOPIOJDDLBN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct AFLGDFABGKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public LHKBLOGJLJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<NIHJKBCEGCJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3D24D90", Offset = "0x3D23D90", VA = "0x183D24D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3D24F70", Offset = "0x3D23F70", VA = "0x183D24F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly EIADPFDFDMD LOLDBIBJLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly EPIKAMAPMAF DHEPPELHCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly CKKLBGOIJKE AHCJOHEFENC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int AEOBAOCLDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x31F80D0", Offset = "0x31F70D0", VA = "0x1831F80D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IOMKAICGADJ ANENJLMGAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x31F8120", Offset = "0x31F7120", VA = "0x1831F8120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime PDMOKCBDENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x31F81C0", Offset = "0x31F71C0", VA = "0x1831F81C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EPIKAMAPMAF? GNBFIIGKIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x31F8080", Offset = "0x31F7080", VA = "0x1831F8080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CKKLBGOIJKE? PFGDNDEHKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x31F7D30", Offset = "0x31F6D30", VA = "0x1831F7D30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GMDNAFOPMOO EIPAEBECNAG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6992A0", Offset = "0x6982A0", VA = "0x1806992A0", Slot = "10")]
			get
			{
				return default(GMDNAFOPMOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x723D10", Offset = "0x722D10", VA = "0x180723D10")]
		public LHKBLOGJLJA(EIADPFDFDMD IIDEMCOOKBC, EPIKAMAPMAF IGOLEBKMOLC, CKKLBGOIJKE CEBDALCMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x31F7ED0", Offset = "0x31F6ED0", VA = "0x1831F7ED0", Slot = "9")]
		[AsyncStateMachine(typeof(AFLGDFABGKK))]
		public Task<NIHJKBCEGCJ> FBHLNEPBIAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x31F7E30", Offset = "0x31F6E30", VA = "0x1831F7E30", Slot = "11")]
		public bool Equals(JOPIOJDDLBN KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x31F7D80", Offset = "0x31F6D80", VA = "0x1831F7D80", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x31F7CD0", Offset = "0x31F6CD0", VA = "0x1831F7CD0")]
		private bool AGKLKJAKGKE(LHKBLOGJLJA KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31F7FF0", Offset = "0x31F6FF0", VA = "0x1831F7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class JKINPNBKMNP : JOPIOJDDLBN, IEquatable<JOPIOJDDLBN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct FBIPGBKFJMA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<NIHJKBCEGCJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3D279E0", Offset = "0x3D269E0", VA = "0x183D279E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26BC0", VA = "0x183D27BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly IOMKAICGADJ GOJJDCELBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly EPIKAMAPMAF DHEPPELHCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CKKLBGOIJKE AHCJOHEFENC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int AEOBAOCLDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x31F4EE0", Offset = "0x31F3EE0", VA = "0x1831F4EE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public IOMKAICGADJ ANENJLMGAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime PDMOKCBDENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EPIKAMAPMAF? GNBFIIGKIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x31F4E90", Offset = "0x31F3E90", VA = "0x1831F4E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CKKLBGOIJKE? PFGDNDEHKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x31F4A10", Offset = "0x31F3A10", VA = "0x1831F4A10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GMDNAFOPMOO EIPAEBECNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "10")]
			get
			{
				return default(GMDNAFOPMOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x723D10", Offset = "0x722D10", VA = "0x180723D10")]
		public JKINPNBKMNP(IOMKAICGADJ AHODNKDLJJG, EPIKAMAPMAF IGOLEBKMOLC, CKKLBGOIJKE CEBDALCMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x31F4CF0", Offset = "0x31F3CF0", VA = "0x1831F4CF0", Slot = "9")]
		[AsyncStateMachine(typeof(FBIPGBKFJMA))]
		public Task<NIHJKBCEGCJ> FBHLNEPBIAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x31F4A60", Offset = "0x31F3A60", VA = "0x1831F4A60", Slot = "11")]
		public bool Equals(JOPIOJDDLBN KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x31F4BA0", Offset = "0x31F3BA0", VA = "0x1831F4BA0", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x31F4DE0", Offset = "0x31F3DE0", VA = "0x1831F4DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x31F4910", Offset = "0x31F3910", VA = "0x1831F4910")]
		private bool AGKLKJAKGKE(JKINPNBKMNP KICLNADFIEK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PBBCBMKNDJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<JOPIOJDDLBN>> <>t__builder;

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
		public GDDBLKKNHHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<EPNJNOPJDEL> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<EPNJNOPJDEL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, IOMKAICGADJ account, EPNJNOPJDEL roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x31FC9A0", Offset = "0x31FB9A0", VA = "0x1831FC9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x31FD430", Offset = "0x31FC430", VA = "0x1831FD430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LCOBJPMDIML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, IOMKAICGADJ account, EPNJNOPJDEL roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<EPNJNOPJDEL> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GDDBLKKNHHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<IOMKAICGADJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x31F6740", Offset = "0x31F5740", VA = "0x1831F6740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x31F70C0", Offset = "0x31F60C0", VA = "0x1831F70C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LFOLIFGJFGF NNBCDDDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HHLPCPLKKFH PCPPJNFPLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DOADGIBKBGJ IDBMDNJBHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::OKOFPBCAHLM<(long, long), IReadOnlyList<EPNJNOPJDEL>> ILMADPHAKFJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2699690", Offset = "0x2698690", VA = "0x182699690")]
	[Preserve]
	public GDDBLKKNHHG([ELDNEOCBGIN(null)] HHLPCPLKKFH IFADIMANKDJ, [ELDNEOCBGIN(null)] DOADGIBKBGJ AMIFHHFGOOB, [ELDNEOCBGIN(null)] LFOLIFGJFGF DNDMINLDOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2699250", Offset = "0x2698250", VA = "0x182699250")]
	[AsyncStateMachine(typeof(PBBCBMKNDJI))]
	public Task<IList<JOPIOJDDLBN>> BHALEFDKLPH(long KPBGCMCAECK, long PFEOAIPJFFN, bool AGFBACKMKJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26994E0", Offset = "0x26984E0", VA = "0x1826994E0")]
	private bool IJACECDCJCE(DateTime? CLNFFBLLOKC, long KPBGCMCAECK, long PFEOAIPJFFN, out EIADPFDFDMD MBIMPHFLEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26993A0", Offset = "0x26983A0", VA = "0x1826993A0")]
	[AsyncStateMachine(typeof(LCOBJPMDIML))]
	private Task<IReadOnlyList<(int, IOMKAICGADJ, EPNJNOPJDEL)>> HMKFDGIBNNO(IReadOnlyList<EPNJNOPJDEL> FHBNDHEOPHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DOADGIBKBGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EIADPFDFDMD> NEEIMAJJICB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKBMENBAEEG(long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI, JCKPEGAFAPH MPBBMJKCHFP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BODCEIGPFMK(long KPBGCMCAECK, long PFEOAIPJFFN, out EIADPFDFDMD MBIMPHFLEBF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BHMAGAMFKBA(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, out EIADPFDFDMD MBIMPHFLEBF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEHJKFKOLGB(long KPBGCMCAECK, long PFEOAIPJFFN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface BFJLFMGALHP : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JIBBALOEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task BJCHJDINMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFPPHAMFDNN(Task KLOLOJBLOIC, string MGHGFNABLJD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface CGENMFCCDOP : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIHJKBCEGCJ> HMHMNCPOLME(EIADPFDFDMD MBIMPHFLEBF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ODBLLKMEFFH(CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface LKGOHJCOGLG : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BCJGNNLDEJN ECHNCKBBEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAJBGMCOPIC();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBCJPFENHLO();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JGHNIBPBLBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface JKLAEHOICFC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan FNDHGBPCPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JGDJDKMEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan PJJHILONDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JEBLCBLGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OMEDHOJFBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FCFBDFIBMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NHNBJNKMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum FGMJPMBGHDA
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KNBPMPDLLNP
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GDHGOFCBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly long FJGLOBNDEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly long CFCAAMCKONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly FGMJPMBGHDA IGEIBCJNCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CanBeNull]
	public readonly Exception JLLBMIECJFG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2699800", Offset = "0x2698800", VA = "0x182699800")]
	public GDHGOFCBJHF(long FJGLOBNDEPN, long CFCAAMCKONC, FGMJPMBGHDA IGEIBCJNCHF, [CanBeNull] Exception JLLBMIECJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26997B0", Offset = "0x26987B0", VA = "0x1826997B0")]
	public static GDHGOFCBJHF GNCNGCOCOBN(JJPHLLGENAE JHLPOBMNEPJ, FGMJPMBGHDA IGEIBCJNCHF, [Optional] Exception JLLBMIECJFG)
	{
		return default(GDHGOFCBJHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void DJLBGEEBEFL(GDHGOFCBJHF PBPFPGHNJKP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PJLEKAFGDIF : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AIAJFPGBKOB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DJLBGEEBEFL NFHDPBKNNBA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DJLBGEEBEFL NILLDLCILNL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DJLBGEEBEFL NOFIPHLPDHB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<KNBPMPDLLNP, bool> MKEIMCAPDFE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHPNNNFINEE();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HNCKPFKBFDC(GDHGOFCBJHF PBPFPGHNJKP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IDFNHFODFML(GDHGOFCBJHF PBPFPGHNJKP);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JLIDBIDOBOI(GDHGOFCBJHF PBPFPGHNJKP);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBJOGOKFHPC(KNBPMPDLLNP KJNNCDKFMMI, bool CDAAFMCMHEH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface BHEMEEJAANK : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EMMMFMKKCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INFNDPGMHGO();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJMCNJCBCGH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task HFCIAEIHEJM(MMIGNNJDMKB GPCLICNBEEG, CancellationToken KCCFEDJJGAN);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface KJIGEGFPGBM : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LCNAHLDKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKPFIOCMDCB(HFCIAEIHEJM AMMJBKKDPJD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface OENKPGLLGIL : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus PLKDOKJGOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GAOHONPHLKA(JJPHLLGENAE LMINODPKJOI, BDHECDAPBLF FLKOAIGLKHM, CancellationToken OGPKLEECEBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class HFAAGJADFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x269A910", Offset = "0x2699910", VA = "0x18269A910")]
	public static bool HIAJFJEMIPM(this OENKPGLLGIL FCFNCJNKPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface AMHDFPELFBK : IOJNPFFHDDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken DPECBNGOCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GBDCKFPNAEP JMIIMIBHIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BMHJNIJKGAA FPIOGIIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GEGNGOGKNPE LJDDMDIHGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KBLLFAOCCDI KLDGFMLAEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EFMAHDKJBBP MGIIFBFBFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IFDFMCFIIAL PLEFKJOODDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EAPCBILCKLG PCNBDEFKFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BFJLFMGALHP EDMONCJOEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CGENMFCCDOP IOMFEIKKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PJLEKAFGDIF LJFFKOJPADD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BHEMEEJAANK NCGMIGCMBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OENKPGLLGIL IKILJHGNDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KJIGEGFPGBM FAABPNLPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IOOCMJIHEDP KPHAKGDELPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MJBMIIBGBFL EDHKLGAIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NNCFJCNKKJL INMICICNGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CEAHDCCBJHP JHIGOBNPPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KMFGHJFILBA KCEALNBMMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BPDAIKIDHAK LECPKPPBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PNIMAPFPOBF AMDOCMAEAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OHFMKHGMJEI PLGJHDBBNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OADHKCLEONA EAAOICJMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	IHJIIAFEIEI FGPAJKHOHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PAKFKMHNOJA CEFKIMAMKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LKGOHJCOGLG CDKDFOIJKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	JKLAEHOICFC ADKONLGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HNJHANBGNNM NPJLIDINEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	DOADGIBKBGJ FHIKHEEAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LDJNLONJPBJ(BDHECDAPBLF HGDLJFLEKKF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface IOOCMJIHEDP : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCEKOBJPBHA HMNAIPBHJIK(Guid MHGELGNLCHI);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAHLDBEBGON(Guid MHGELGNLCHI);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJKGIJAHMPN(Guid MHGELGNLCHI, Task KMFBBIBMFPE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IJIGLAHEKCA(Guid MHGELGNLCHI, NIHJKBCEGCJ AHOKFBGFMCP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KJMCNJCBCGH(Guid MHGELGNLCHI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(NIHJKBCEGCJ, Task)> EJEAKEJBKLN(Guid MHGELGNLCHI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface MJBMIIBGBFL : JGHNIBPBLBF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface NNCFJCNKKJL : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAKOOCGLLOD(KNMGGFFPHPG LMLMHJKGDCH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBBDJFJFPLL(KNMGGFFPHPG LMLMHJKGDCH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KCNIDPOKJDF> HFPFGLEPFGF(CancellationToken NJACNIOFFGE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate NIHJKBCEGCJ DKADDMIFBIH(DMHOAMAMDGI NDODIMDBLAB, KCNIDPOKJDF KLLGHOJBLIJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface CEAHDCCBJHP : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCEKOBJPBHA KKFEPEPBJMH(KNMGGFFPHPG AKPEAIHBLLD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHEGEEEEAPB(Guid MHGELGNLCHI, Task KMFBBIBMFPE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KMFGHJFILBA : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIHJKBCEGCJ> KCEALNBMMLC(KNMGGFFPHPG DNAOLLFBNEI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BPDAIKIDHAK : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GDFDJMJJEPG> OFJDKEKCIJN(NILMFDECOMH OIJDGGDGOKN, JJPHLLGENAE LMINODPKJOI, CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface OHFMKHGMJEI : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIHJKBCEGCJ PLDGGJFNPCK(DMHOAMAMDGI NDODIMDBLAB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IBOIMOGEDPB(string JLGENJBOGCK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PNIMAPFPOBF : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNMGGFFPHPG> OKLIBFOEIBH(KNMGGFFPHPG KJACHHOOFKC, DGAJACEMLNI DLNPHMAKOCI, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KNMGGFFPHPG> BBJFHHCMOGM(CancellationToken NIEOBBGKEFJ, DGAJACEMLNI DLNPHMAKOCI);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFGGDAIBFBD DDKDHMDHCJN(NEJLBNOHIBA BIPLIJDCIEC, NILMFDECOMH OIJDGGDGOKN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFGGDAIBFBD FPBBFBLBDNH(NEJLBNOHIBA BIPLIJDCIEC, NILMFDECOMH OIJDGGDGOKN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface OADHKCLEONA : JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIHJKBCEGCJ FBPOJNNAHAA(DMHOAMAMDGI NDODIMDBLAB, KCNIDPOKJDF KLLGHOJBLIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIHJKBCEGCJ MFKLLJIHGNP(DMHOAMAMDGI DPEPLBDJLAB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIHJKBCEGCJ BEOJBNNGBPN(DMHOAMAMDGI DPEPLBDJLAB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IHJIIAFEIEI
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAIANEKGNMB(LEKCEKMLHEL IFOIBJJCMNM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCKHCDOKLPK(LEKCEKMLHEL IFOIBJJCMNM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELCFIOIILPC(LEKCEKMLHEL IFOIBJJCMNM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPKHIHJHAMA(LEKCEKMLHEL IFOIBJJCMNM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LEKCEKMLHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JJPHLLGENAE PCHBOGIEHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, string> IIEIEOKIIAA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::FCHNJJOGFOB<string> GOHKAGCGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	public LEKCEKMLHEL(JJPHLLGENAE DKBNHPIBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26A4F10", Offset = "0x26A3F10", VA = "0x1826A4F10")]
	public LEKCEKMLHEL CGJIEBHJGAM(string PIIJMEAKDGO, string DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x26A4FE0", Offset = "0x26A3FE0", VA = "0x1826A4FE0")]
	public bool FAFGKJFHBHC(out IEnumerable<KeyValuePair<string, string>> MDOJKFFJHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5060", Offset = "0x26A4060", VA = "0x1826A5060")]
	public LEKCEKMLHEL NBPHMLNFEDG(global::FCHNJJOGFOB<string> JBAEFOFJALC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HNJHANBGNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PNILEMJKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string DHBBEDEDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKEMOBMFNNN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JENLCEMCKKM KPICAKMFDDH(long CPIEIKFMDCD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DIHAHOBNPFF<INLAJELACMH, EEANAGPKBOF> EGKKACNPLEO(long CPIEIKFMDCD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DIHAHOBNPFF<INLAJELACMH, DOJAMBMLNII> KMLAEHCFFML(long CPIEIKFMDCD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DIHAHOBNPFF<long, CPPNEHBPDEC> IAMMHEMBCMN();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> GGIDNAFBJKH(byte[] OPPGOHCPNCA, byte[] EFGJIFHPJPD, CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IOJNPFFHDDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HIAJFJEMIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ENMNLOLBFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task KPCABIKOLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	BDHECDAPBLF MLKLDBHAIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AIAJFPGBKOB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DJLBGEEBEFL NFHDPBKNNBA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DJLBGEEBEFL NILLDLCILNL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DJLBGEEBEFL NOFIPHLPDHB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KNBPMPDLLNP, bool> MKEIMCAPDFE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void INFNDPGMHGO();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IAEJIMAMGPL EPONIEEFFJE();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FIHIKPBJMKO NGBCCGEHEFI();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<NIHJKBCEGCJ> HMHMNCPOLME(EIADPFDFDMD IIDEMCOOKBC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task ODBLLKMEFFH(CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KBLLFAOCCDI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HOCNLOGFBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string NDNHNLPBKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIEALGGDEJO(Scene HCIKLMMKMOL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MAGFNLGNIMF(MOIFEMAHELI AELCCEDDHNO, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LGIKKCDDKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KPENDAEOIAB
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int OHMHDNPGGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JJCGIMDNLDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HAPGMKHJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool HGJPICGBADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CPJBPPBLDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool DLKPONDHLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	DMHOAMAMDGI HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IGBFAFAHKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBDCKFPNAEP PBBBDCGNHMP(GBDCKFPNAEP FLFONOKDLGH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHGGOJGBHDM(GBDCKFPNAEP FOIOPKEONKP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task KCJFPEIIPGD(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OLOKPAACECL(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task IBMHOOFPKJM(DOCJJOEFAJF COBJNMAIDFF, [Optional] CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBHBAJJPHJI(float JLBGCGDHKHO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OECBOPACJAB(string JOOHLGDBFIN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<HADDBKOIJFF> KLIHJBNMEJM();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable PEPHBGOGAPH(object KPJEGNGKPOH, HADDBKOIJFF DEGHCFJKCEP);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EEANAGPKBOF IFLGMAFAIFI();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LIDLMONHJHA(int PELDLDOEDBI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task IAPKHHOBKKN();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FNLDDHCBJEP();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool NMKNFODNEHC();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task NEFPLIEJGFE(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KKOMMILLEJI(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<HJBOKMAALMC> FAGPELKFMEL(DateTime OIMMPPBDOHH, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> ANPJDMOAEMH(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BPEMIDHEDNL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FDBDBNOIJEA GLEDALCIOKD(JHPBHDOGOGO FCEBBBLGEJO, DOJAMBMLNII GCAJLECELPO, IEnumerable<PersistenceView> MAAEJBDELJL, ref ABEBIAKBDHH KPGEJCHLPCD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PHBBFKBBKNB(EPAMCLOEEBK BAKMJFIKFPC, in FDBDBNOIJEA JOHEPNEHJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task HAAIDNDBKPL(DOJAMBMLNII KBIIDELJIDG, bool KPAGMOEIGLK, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CPMOHMDCMIH(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LKKKKBMFCFI(long KPBGCMCAECK, long CFCAAMCKONC, HIEMHHFNKEP LDFKNCALKNJ, CFDCFBIAELJ MAEFHMCAIMI);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KHBLLOEDLAD(long KPBGCMCAECK, long CFCAAMCKONC);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JFNNIICHLBD(PersistenceView PHIOCOKFAPM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool OJPPIFBKOLP(PersistenceView JENEHFPKFDC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MJAEHMKFAEH(EPAMCLOEEBK BAKMJFIKFPC, GMDPNKPCIHK IGHFIAHHGBO, out OEOHLIIEIAM AJBGMCLNIMN);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EHNJIONAOAD();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KEBPIHHHCCJ();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable EILCBJBMLOE();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OFKMHBKAGJK(DOJAMBMLNII KBIIDELJIDG, GMDPNKPCIHK IGHFIAHHGBO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> NAKAMFPBBCH(BMHJNIJKGAA GNPHKIFHPOM, CancellationToken NIEOBBGKEFJ, NILMFDECOMH OIJDGGDGOKN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void MMFJONNLAKH(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<IFFJPCNELHO> CACFKIABJCJ(MKOOJPOJJEM KJACHHOOFKC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<IILIHFPFOJH> DOOBIFGPLFF(string EHGBHFCBKPM, long KPBGCMCAECK, long CFCAAMCKONC, string GHOHBGIEHPJ, PEHJDNEOAMN.IECIGIGCPLB GPCLICNBEEG, PEHJDNEOAMN.IECIGIGCPLB EFGJIFHPJPD, int CEGPOGLBCHA);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<HIEMHHFNKEP> GDPPKMGCLPC(long KPBGCMCAECK, bool AFHNIPPLDJF, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool ILBABCJKBBI();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool OBBKAACBOGF();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KEMAFHDLFGF(IEnumerable<OEOHLIIEIAM> JKLEKMBAKIN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JAOGLHPPPFA(List<GameObject> BHOFFBKAHBF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float PAAEJGDGGCC();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool BECNJEDMMCI(string PPPHPNPKCLP, out Scene PPJNHEBGICL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> JHKGJNAGGID(string PPPHPNPKCLP, LoadSceneMode GIBAJNBNLHD, bool DCPIBGCPNCJ, NILMFDECOMH JBAEFOFJALC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void PIGILAJBLPP();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool KHINFCAPPEL(ByteString GEGIPEOHNBF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void GCAGKCBCIDN(JJPHLLGENAE APGMDOJKEFH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task MDLCAKLONDA(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task LKKJLDJAMPJ(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BOHJIAPMGDG();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable AMGHKFLLCDL();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	GGDALNKLLGD OLKCAEBGKLK();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GGDALNKLLGD
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ADEHFHOILFD(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CIMHFDFHGCG(CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FDBDBNOIJEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HashSet<int> KHKBEBBLJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IDisposable IMFBFANIBOL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2695CB0", Offset = "0x2694CB0", VA = "0x182695CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HJBOKMAALMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CCAPIFGDDLC
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	JJPHLLGENAE KMAPINOFGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	HIEMHHFNKEP DDIGFCPICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MFFGBJPFPEF KLLMIJGCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool HPPOFFIJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PCLDFHHADOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int OHMHDNPGGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action MENCBKDIOLH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> GPABAKIJMJI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FCPNDECAHAK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LMOEEEOLEEG> ACPFGHHJABC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NKKEFKFOHIC();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(JJPHLLGENAE, BDHECDAPBLF) EMFHJOAKLND();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KJNKLCIDCEB GNOHBHGEPKD();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NCDPGNKIDHJ(long CPIEIKFMDCD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PAKFKMHNOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELKLHNADAHO(out IEnumerable<int> BJLEANBIJHH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DINCELFPKCO(HPDGKDBFFPK KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLJILLGFFLK(HPDGKDBFFPK KCCFEDJJGAN);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface CCDJIACAJOK
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MBFECGHBLOC(NIHJKBCEGCJ CGALMJJGCDO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CMEPAHKFKGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJOKFEMMPNI(CPFCOCIJDGC.GLIDLDOONNA AFKBPHIOOIH);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFGABGBLMBC(CPFCOCIJDGC.GLIDLDOONNA AFKBPHIOOIH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EFMAHDKJBBP : CMEPAHKFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIHJKBCEGCJ EBCEPGNJCCB(DMHOAMAMDGI DPEPLBDJLAB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IFDFMCFIIAL : CMEPAHKFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIHJKBCEGCJ PLDGGJFNPCK(DMHOAMAMDGI PKPBDEIEICB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JENLCEMCKKM
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::CIOEKKBILIB<MOIFEMAHELI, AAHLPJGCFPM>> LOEKJOJEGKO(string GHOHBGIEHPJ, long CPIEIKFMDCD, DBEEPMIJCMI.CNMIEGAELBL GEFHKKPHINB, CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DIHAHOBNPFF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::CIOEKKBILIB<byte[], AAHLPJGCFPM>> DBLPJBOCACJ(TGetDataArg JCKDEHJPDNC, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CIOEKKBILIB<global::OOPICKNMODO<TData>, AAHLPJGCFPM> JMIMDGLCFKC(byte[] FILAKGLBGGA);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EPFNIKPEDOJ : AMHDFPELFBK, IOJNPFFHDDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct LEJPBLDHGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public EPFNIKPEDOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EIADPFDFDMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x31F7620", Offset = "0x31F6620", VA = "0x1831F7620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x31F78C0", Offset = "0x31F68C0", VA = "0x1831F78C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OGGJJDCECKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EPFNIKPEDOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x31FC770", Offset = "0x31FB770", VA = "0x1831FC770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ANHEMAEOACD : IEnumerable<JGHNIBPBLBF>, IEnumerable, IEnumerator<JGHNIBPBLBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JGHNIBPBLBF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public EPFNIKPEDOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private JGHNIBPBLBF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public ANHEMAEOACD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A290", Offset = "0x2E59290", VA = "0x182E5A290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A6D0", Offset = "0x2E596D0", VA = "0x182E5A6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A630", Offset = "0x2E59630", VA = "0x182E5A630", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JGHNIBPBLBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A630", Offset = "0x2E59630", VA = "0x182E5A630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CancellationTokenSource PPEIEOMJFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GBDCKFPNAEP FOIOPKEONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private CFPHDEGKFBH MJMAECBABFI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public BMHJNIJKGAA FPIOGIIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D0", Offset = "0x67D0D0", VA = "0x18067E0D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x776310", Offset = "0x775310", VA = "0x180776310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GEGNGOGKNPE LJDDMDIHGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x694760", Offset = "0x693760", VA = "0x180694760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x708000", Offset = "0x707000", VA = "0x180708000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x67E0B0", Offset = "0x67D0B0", VA = "0x18067E0B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x776300", Offset = "0x775300", VA = "0x180776300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KBLLFAOCCDI KLDGFMLAEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x694770", Offset = "0x693770", VA = "0x180694770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x71FAB0", Offset = "0x71EAB0", VA = "0x18071FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EFMAHDKJBBP MGIIFBFBFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x694780", Offset = "0x693780", VA = "0x180694780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7762F0", Offset = "0x7752F0", VA = "0x1807762F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public IFDFMCFIIAL PLEFKJOODDO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x694700", Offset = "0x693700", VA = "0x180694700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6860", Offset = "0x6A5860", VA = "0x1806A6860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EAPCBILCKLG PCNBDEFKFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x694710", Offset = "0x693710", VA = "0x180694710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6B5DB0", Offset = "0x6B4DB0", VA = "0x1806B5DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public BFJLFMGALHP EDMONCJOEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6D0", Offset = "0x6B96D0", VA = "0x1806BA6D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6B5D90", Offset = "0x6B4D90", VA = "0x1806B5D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CGENMFCCDOP IOMFEIKKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x684D80", Offset = "0x683D80", VA = "0x180684D80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x885B50", Offset = "0x884B50", VA = "0x180885B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public PJLEKAFGDIF LJFFKOJPADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x684E20", Offset = "0x683E20", VA = "0x180684E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7DC170", Offset = "0x7DB170", VA = "0x1807DC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public BHEMEEJAANK NCGMIGCMBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6A0", Offset = "0x6B96A0", VA = "0x1806BA6A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x885170", Offset = "0x884170", VA = "0x180885170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OENKPGLLGIL IKILJHGNDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x694720", Offset = "0x693720", VA = "0x180694720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6B5DA0", Offset = "0x6B4DA0", VA = "0x1806B5DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KJIGEGFPGBM FAABPNLPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x694730", Offset = "0x693730", VA = "0x180694730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x702540", Offset = "0x701540", VA = "0x180702540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IOOCMJIHEDP KPHAKGDELPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x694750", Offset = "0x693750", VA = "0x180694750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x78FC50", Offset = "0x78EC50", VA = "0x18078FC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public MJBMIIBGBFL EDHKLGAIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x694740", Offset = "0x693740", VA = "0x180694740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6B5DC0", Offset = "0x6B4DC0", VA = "0x1806B5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NNCFJCNKKJL INMICICNGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x78D370", Offset = "0x78C370", VA = "0x18078D370", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x78DA60", Offset = "0x78CA60", VA = "0x18078DA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public CEAHDCCBJHP JHIGOBNPPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7367A0", Offset = "0x7357A0", VA = "0x1807367A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x78D380", Offset = "0x78C380", VA = "0x18078D380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KMFGHJFILBA KCEALNBMMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x78F990", Offset = "0x78E990", VA = "0x18078F990", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x78FA80", Offset = "0x78EA80", VA = "0x18078FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BPDAIKIDHAK LECPKPPBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7D9540", Offset = "0x7D8540", VA = "0x1807D9540", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7D9620", Offset = "0x7D8620", VA = "0x1807D9620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public PNIMAPFPOBF AMDOCMAEAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x78E010", Offset = "0x78D010", VA = "0x18078E010", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7DA290", Offset = "0x7D9290", VA = "0x1807DA290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public OHFMKHGMJEI PLGJHDBBNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x78DD10", Offset = "0x78CD10", VA = "0x18078DD10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x78E040", Offset = "0x78D040", VA = "0x18078E040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OADHKCLEONA EAAOICJMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x78DCF0", Offset = "0x78CCF0", VA = "0x18078DCF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x78E020", Offset = "0x78D020", VA = "0x18078E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IHJIIAFEIEI FGPAJKHOHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x78DD00", Offset = "0x78CD00", VA = "0x18078DD00", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x78E030", Offset = "0x78D030", VA = "0x18078E030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public PAKFKMHNOJA CEFKIMAMKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA280", Offset = "0x7D9280", VA = "0x1807DA280", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xEF68A0", Offset = "0xEF58A0", VA = "0x180EF68A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LKGOHJCOGLG CDKDFOIJKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CFF0", VA = "0x18078DFF0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x78E190", Offset = "0x78D190", VA = "0x18078E190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JKLAEHOICFC ADKONLGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x78E000", Offset = "0x78D000", VA = "0x18078E000", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78D1A0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public HNJHANBGNNM NPJLIDINEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA2B9E0", Offset = "0xA2A9E0", VA = "0x180A2B9E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA2B070", Offset = "0xA2A070", VA = "0x180A2B070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public DOADGIBKBGJ FHIKHEEAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA29B40", Offset = "0xA28B40", VA = "0x180A29B40", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public BDHECDAPBLF MLKLDBHAIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xEA3070", Offset = "0xEA2070", VA = "0x180EA3070", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xE66420", Offset = "0xE65420", VA = "0x180E66420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool ELCLJBCCPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2694550", Offset = "0x2693550", VA = "0x182694550", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool AFILAINECDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2694980", Offset = "0x2693980", VA = "0x182694980", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task LFMKMIHLICK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2694750", Offset = "0x2693750", VA = "0x182694750", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken BNCNNKFOGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2694BB0", Offset = "0x2693BB0", VA = "0x182694BB0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GBDCKFPNAEP DJCCJPKCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action AGAACEEOMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2694DE0", Offset = "0x2693DE0", VA = "0x182694DE0", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2694F30", Offset = "0x2693F30", VA = "0x182694F30", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event DJLBGEEBEFL KFBGFODIJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x26948C0", Offset = "0x26938C0", VA = "0x1826948C0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x26946F0", Offset = "0x26936F0", VA = "0x1826946F0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event DJLBGEEBEFL MPPEMCGEFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2694920", Offset = "0x2693920", VA = "0x182694920", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2694420", Offset = "0x2693420", VA = "0x182694420", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event DJLBGEEBEFL BODAFNCELAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2694480", Offset = "0x2693480", VA = "0x182694480", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2694B50", Offset = "0x2693B50", VA = "0x182694B50", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<KNBPMPDLLNP, bool> KFGKJIIANGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x26943C0", Offset = "0x26933C0", VA = "0x1826943C0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2694D80", Offset = "0x2693D80", VA = "0x182694D80", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xE66420", Offset = "0xE65420", VA = "0x180E66420", Slot = "34")]
	public void LDJNLONJPBJ(BDHECDAPBLF HGDLJFLEKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26950D0", Offset = "0x26940D0", VA = "0x1826950D0")]
	[Preserve]
	internal EPFNIKPEDOJ([ELDNEOCBGIN(null)] GBDCKFPNAEP FOIOPKEONKP, [ELDNEOCBGIN(null)] BMHJNIJKGAA GNPHKIFHPOM, [ELDNEOCBGIN(null)] GEGNGOGKNPE PBNMNDEPKKM, [ELDNEOCBGIN(null)] KPENDAEOIAB ACNDHAIKGGB, [ELDNEOCBGIN(null)] KBLLFAOCCDI BKNCDINGCOM, [ELDNEOCBGIN(null)] EFMAHDKJBBP IPICAMEAOLH, [ELDNEOCBGIN(null)] IFDFMCFIIAL AADAEPLNONC, [ELDNEOCBGIN(null)] EAPCBILCKLG HECOGALPDLB, [ELDNEOCBGIN(null)] BFJLFMGALHP JANAPNFIBMD, [ELDNEOCBGIN(null)] CGENMFCCDOP CEHKKELECBH, [ELDNEOCBGIN(null)] PJLEKAFGDIF PGEAEBLBOHE, [ELDNEOCBGIN(null)] BHEMEEJAANK MJAGECADCKC, [ELDNEOCBGIN(null)] OENKPGLLGIL FCFNCJNKPCJ, [ELDNEOCBGIN(null)] KJIGEGFPGBM CEKLIKIGLKF, [ELDNEOCBGIN(null)] IOOCMJIHEDP OLMOACNIHHL, [ELDNEOCBGIN(null)] MJBMIIBGBFL EIABBKHOMEC, [ELDNEOCBGIN(null)] NNCFJCNKKJL NHNKGIDKLAJ, [ELDNEOCBGIN(null)] CEAHDCCBJHP HDOBPMGCNLN, [ELDNEOCBGIN(null)] KMFGHJFILBA NBAAJLKOGNH, [ELDNEOCBGIN(null)] BPDAIKIDHAK DEANKNKINBE, [ELDNEOCBGIN(null)] OHFMKHGMJEI HAPKMMBPKNP, [ELDNEOCBGIN(null)] PNIMAPFPOBF JJIKKENKMOE, [ELDNEOCBGIN(null)] OADHKCLEONA BHEGBBGFCPN, [ELDNEOCBGIN(null)] IHJIIAFEIEI JIKAAFIGBNJ, [ELDNEOCBGIN(null)] PAKFKMHNOJA EJHEHHEJMEL, [ELDNEOCBGIN(null)] JKLAEHOICFC PJKPAHNPCHO, [ELDNEOCBGIN(null)] HNJHANBGNNM CNOLEHFIDMB, [ELDNEOCBGIN(null)] DOADGIBKBGJ JOJDKOKBAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2694E40", Offset = "0x2693E40", VA = "0x182694E40")]
	private void NAGCBALDEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2694560", Offset = "0x2693560", VA = "0x182694560", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2694310", Offset = "0x2693310", VA = "0x182694310", Slot = "48")]
	private void AGNNKLEPEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2694A00", Offset = "0x2693A00", VA = "0x182694A00", Slot = "49")]
	private IAEJIMAMGPL IAJELOFHHAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2694BD0", Offset = "0x2693BD0", VA = "0x182694BD0", Slot = "50")]
	private FIHIKPBJMKO JNJGGGAMFDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2694F90", Offset = "0x2693F90", VA = "0x182694F90", Slot = "51")]
	[AsyncStateMachine(typeof(LEJPBLDHGFN))]
	private Task<NIHJKBCEGCJ> OKIMJHAFKCA(EIADPFDFDMD MBIMPHFLEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x26947A0", Offset = "0x26937A0", VA = "0x1826947A0", Slot = "52")]
	[AsyncStateMachine(typeof(OGGJJDCECKJ))]
	private Task FMPFNFDNHDD(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x26944E0", Offset = "0x26934E0", VA = "0x1826944E0")]
	[IteratorStateMachine(typeof(ANHEMAEOACD))]
	private IEnumerable<JGHNIBPBLBF> CPENJIHECKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2694360", Offset = "0x2693360", VA = "0x182694360")]
	[CompilerGenerated]
	private void BAGNAHONCMJ(JGHNIBPBLBF KMJCJNGOPHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class LFMPENBGKOE : EABAPHHMCLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NEIKFAENBOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public LFMPENBGKOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x31FB250", Offset = "0x31FA250", VA = "0x1831FB250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x31FB5D0", Offset = "0x31FA5D0", VA = "0x1831FB5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67E6E0", Offset = "0x67D6E0", VA = "0x18067E6E0")]
	public LFMPENBGKOE(AMHDFPELFBK POBEANPIGDE, KPENDAEOIAB ACNDHAIKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x26A5160", Offset = "0x26A4160", VA = "0x1826A5160", Slot = "4")]
	[AsyncStateMachine(typeof(NEIKFAENBOP))]
	public Task<bool> JKJHJPFPHIB(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5080", Offset = "0x26A4080", VA = "0x1826A5080")]
	[CompilerGenerated]
	private object GIHCJONNMLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class OKHKHDHIHHG : EABAPHHMCLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LMIAOJKDEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OKHKHDHIHHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DA90", Offset = "0x3D2CA90", VA = "0x183D2DA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E130", Offset = "0x3D2D130", VA = "0x183D2E130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const float BPJKKKFADOI = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E6ABF0", Offset = "0x2E69BF0", VA = "0x182E6ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x67E6E0", Offset = "0x67D6E0", VA = "0x18067E6E0")]
	public OKHKHDHIHHG(AMHDFPELFBK POBEANPIGDE, KPENDAEOIAB ACNDHAIKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AD80", Offset = "0x2E69D80", VA = "0x182E6AD80", Slot = "4")]
	[AsyncStateMachine(typeof(LMIAOJKDEAJ))]
	public Task<bool> JKJHJPFPHIB(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AC40", Offset = "0x2E69C40", VA = "0x182E6AC40")]
	[CompilerGenerated]
	private object EMFBENLGJKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class KACLAMHKLOE : EABAPHHMCLM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class AOJPCDNKLNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KACLAMHKLOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Matchmaking.LMOEEEOLEEG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public JJPHLLGENAE newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AOJPCDNKLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x31EA680", Offset = "0x31E9680", VA = "0x1831EA680")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x31EA7D0", Offset = "0x31E97D0", VA = "0x1831EA7D0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x31EA840", Offset = "0x31E9840", VA = "0x1831EA840")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MLDLMDGEOKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KACLAMHKLOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private AOJPCDNKLNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Matchmaking.LMOEEEOLEEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x31FA220", Offset = "0x31F9220", VA = "0x1831FA220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x31FAB50", Offset = "0x31F9B50", VA = "0x1831FAB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private const float BPJKKKFADOI = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x26A2640", Offset = "0x26A1640", VA = "0x1826A2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x67E6E0", Offset = "0x67D6E0", VA = "0x18067E6E0")]
	public KACLAMHKLOE(AMHDFPELFBK POBEANPIGDE, KPENDAEOIAB ACNDHAIKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x26A2690", Offset = "0x26A1690", VA = "0x1826A2690", Slot = "4")]
	[AsyncStateMachine(typeof(MLDLMDGEOKL))]
	public Task<bool> JKJHJPFPHIB(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface EABAPHHMCLM
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JKJHJPFPHIB(CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct POAMODCAEIN
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class DFDEEOEHGBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AMHDFPELFBK manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DFDEEOEHGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D26E40", Offset = "0x3D25E40", VA = "0x183D26E40")]
		internal Task <CreateTask>b__0(MMIGNNJDMKB data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MMEDGACMKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public POAMODCAEIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private EIADPFDFDMD <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<HJBOKMAALMC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ED70", Offset = "0x3D2DD70", VA = "0x183D2ED70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F280", Offset = "0x3D2E280", VA = "0x183D2F280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AKLANHGFEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public POAMODCAEIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D24FC0", Offset = "0x3D23FC0", VA = "0x183D24FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly CancellationToken NIEOBBGKEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly AMHDFPELFBK CLAEEJIDJEI;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private BMHJNIJKGAA FPIOGIIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2E72470", Offset = "0x2E71470", VA = "0x182E72470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2E72010", Offset = "0x2E71010", VA = "0x182E72010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E71CB0", Offset = "0x2E70CB0", VA = "0x182E71CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private CGENMFCCDOP IOMFEIKKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2E72420", Offset = "0x2E71420", VA = "0x182E72420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2E724C0", Offset = "0x2E714C0", VA = "0x182E724C0")]
	public POAMODCAEIN(CancellationToken NIEOBBGKEFJ, AMHDFPELFBK CLAEEJIDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2E71E60", Offset = "0x2E70E60", VA = "0x182E71E60")]
	public static HFCIAEIHEJM DBIDMBINCEF(AMHDFPELFBK CLAEEJIDJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2E71D30", Offset = "0x2E70D30", VA = "0x182E71D30")]
	[AsyncStateMachine(typeof(MMEDGACMKHB))]
	public Task<bool> CAIEIEJFFKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2E72060", Offset = "0x2E71060", VA = "0x182E72060")]
	private bool JFMKPLAPJNM(out EIADPFDFDMD MBIMPHFLEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2E71F10", Offset = "0x2E70F10", VA = "0x182E71F10")]
	[AsyncStateMachine(typeof(AKLANHGFEDN))]
	private Task EPMABBFCNFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2E72270", Offset = "0x2E71270", VA = "0x182E72270")]
	private Task<HJBOKMAALMC> KLMFGEJLMCH(EIADPFDFDMD BONELMPFJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct MCEKOBJPBHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly IOOCMJIHEDP OLMOACNIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Guid MHGELGNLCHI;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(NIHJKBCEGCJ, Task)> FANAKHALKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x26A78A0", Offset = "0x26A68A0", VA = "0x1826A78A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2077F70", Offset = "0x2076F70", VA = "0x182077F70")]
	public MCEKOBJPBHA(IOOCMJIHEDP OLMOACNIHHL, Guid MHGELGNLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26A7970", Offset = "0x26A6970", VA = "0x1826A7970")]
	public TaskAwaiter<(NIHJKBCEGCJ, Task)> IMEEJIAKHMP()
	{
		return default(TaskAwaiter<(NIHJKBCEGCJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26A77D0", Offset = "0x26A67D0", VA = "0x1826A77D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct FGLMNKCPBDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TaskCompletionSource<(NIHJKBCEGCJ, Task)> PNKBOHKIOKF;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(NIHJKBCEGCJ, Task)> FANAKHALKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x26964C0", Offset = "0x26954C0", VA = "0x1826964C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2696550", Offset = "0x2695550", VA = "0x182696550")]
	public FGLMNKCPBDG(TimeSpan NNEBMFOPCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2696390", Offset = "0x2695390", VA = "0x182696390")]
	public void EJJADDGEBCB(Task KMFBBIBMFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2696300", Offset = "0x2695300", VA = "0x182696300")]
	public void BGFEOEINDOE(NIHJKBCEGCJ CGALMJJGCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2696500", Offset = "0x2695500", VA = "0x182696500")]
	public void LOEMLBODOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2696430", Offset = "0x2695430", VA = "0x182696430")]
	internal void IBKLDPMGJEA(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LLPENNINOIM
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PGHOAAHJBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PGHOAAHJBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x126AA80", Offset = "0x1269A80", VA = "0x18126AA80")]
		internal bool <Create>b__0(MFFGBJPFPEF subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x26A6530", Offset = "0x26A5530", VA = "0x1826A6530")]
	public static GDFDJMJJEPG HJNGNBALKKN(long FJGLOBNDEPN, long CFCAAMCKONC, INLAJELACMH OPPGOHCPNCA, string GHOHBGIEHPJ, INLAJELACMH EFGJIFHPJPD, string EHGBHFCBKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x26A6670", Offset = "0x26A5670", VA = "0x1826A6670")]
	public static GDFDJMJJEPG HJNGNBALKKN(HIEMHHFNKEP JMHKAPODEIP, EPNJNOPJDEL GNHMKIHHNCF, [Optional] string EHGBHFCBKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A6310", Offset = "0x26A5310", VA = "0x1826A6310")]
	public static GDFDJMJJEPG HJNGNBALKKN(HIEMHHFNKEP JMHKAPODEIP, long CFCAAMCKONC, [Optional] string EHGBHFCBKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x26A69A0", Offset = "0x26A59A0", VA = "0x1826A69A0")]
	public static GDFDJMJJEPG LHAJHGAJKKF(this GDFDJMJJEPG BNKBFACGLIM, HIEMHHFNKEP IJKABEMCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x26A67E0", Offset = "0x26A57E0", VA = "0x1826A67E0")]
	public static GDFDJMJJEPG HLCGGMLBDJF(this GDFDJMJJEPG BNKBFACGLIM, EPNJNOPJDEL EADPFEFJELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x26A68C0", Offset = "0x26A58C0", VA = "0x1826A68C0")]
	public static GDFDJMJJEPG HLCGGMLBDJF(this GDFDJMJJEPG BNKBFACGLIM, MFFGBJPFPEF LJDHPIMKIDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Preserve]
internal class GAMECBBIKNG : BFJLFMGALHP, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct LPBPKLCBGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GAMECBBIKNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x31F8210", Offset = "0x31F7210", VA = "0x1831F8210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly HPDGKDBFFPK DGHDCLNODHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string CEMCBIGGHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Task CJMLGJFMGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool JIBBALOEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2698FC0", Offset = "0x2697FC0", VA = "0x182698FC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task BJCHJDINMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2698FF0", Offset = "0x2697FF0", VA = "0x182698FF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C01C0", Offset = "0x6BF1C0", VA = "0x1806C01C0", Slot = "7")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2699050", Offset = "0x2698050", VA = "0x182699050", Slot = "6")]
	public void LFPPHAMFDNN(Task KLOLOJBLOIC, string MGHGFNABLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2698E90", Offset = "0x2697E90", VA = "0x182698E90")]
	[AsyncStateMachine(typeof(LPBPKLCBGDN))]
	private Task FJGNADGHFHG(Task HGDMGAPHGEK, string MGHGFNABLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x26991D0", Offset = "0x26981D0", VA = "0x1826991D0")]
	public GAMECBBIKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class LLHGBODGHAG : LKGOHJCOGLG, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool CNFFELDCOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private BCJGNNLDEJN IGHENPBKIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JKLAEHOICFC PJKPAHNPCHO;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BCJGNNLDEJN ECHNCKBBEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F60", Offset = "0x26A4F60", VA = "0x1826A5F60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x26A6190", Offset = "0x26A5190", VA = "0x1826A6190", Slot = "7")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x26A5FD0", Offset = "0x26A4FD0", VA = "0x1826A5FD0", Slot = "5")]
	public void GAJBGMCOPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F20", Offset = "0x26A4F20", VA = "0x1826A5F20", Slot = "6")]
	public void NBCJPFENHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x26A5EA0", Offset = "0x26A4EA0", VA = "0x1826A5EA0")]
	private Task CKGLEJPKKLJ(HOGDMMENGFF GJBHFPJIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F20", Offset = "0x26A4F20", VA = "0x1826A5F20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LLHGBODGHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class PMALLDMNCOF : JKLAEHOICFC
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class JHJEEDLFLKF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly HGFOCGNFLJM LFJLAOIHKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly string PIIJMEAKDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly T PGBDPKDFJME;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x682250", Offset = "0x681250", VA = "0x180682250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x682270", Offset = "0x681270", VA = "0x180682270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x325C4B0", Offset = "0x325B4B0", VA = "0x18325C4B0")]
		public JHJEEDLFLKF(HGFOCGNFLJM LFJLAOIHKKC, string PIIJMEAKDGO, T PGBDPKDFJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x325C140", Offset = "0x325B140", VA = "0x18325C140")]
		private void GBKNPBJOCFA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly JHJEEDLFLKF<TimeSpan> IEFMOKMAFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly JHJEEDLFLKF<TimeSpan> FENOHDOJCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly JHJEEDLFLKF<TimeSpan> LGFICPICGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly JHJEEDLFLKF<TimeSpan> LEGEBCBLPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JHJEEDLFLKF<bool> BGNPMEINLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly JHJEEDLFLKF<bool> KIGDOFCIABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly JHJEEDLFLKF<bool> EIEMHCNDCOF;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan FNDHGBPCPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E70440", Offset = "0x2E6F440", VA = "0x182E70440", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan JGDJDKMEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2E70480", Offset = "0x2E6F480", VA = "0x182E70480", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan PJJHILONDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E704C0", Offset = "0x2E6F4C0", VA = "0x182E704C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan JEBLCBLGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E703C0", Offset = "0x2E6F3C0", VA = "0x182E703C0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool OMEDHOJFBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E70400", Offset = "0x2E6F400", VA = "0x182E70400", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FCFBDFIBMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E70500", Offset = "0x2E6F500", VA = "0x182E70500", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool NHNBJNKMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E70380", Offset = "0x2E6F380", VA = "0x182E70380", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E70540", Offset = "0x2E6F540", VA = "0x182E70540")]
	[Preserve]
	public PMALLDMNCOF([ELDNEOCBGIN(null)] HGFOCGNFLJM LFJLAOIHKKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class FGNBFFCBEBG : PJLEKAFGDIF, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NEJBJMGEPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GDHGOFCBJHF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public NEJBJMGEPDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x31FB620", Offset = "0x31FA620", VA = "0x1831FB620")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action AIAJFPGBKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2696BB0", Offset = "0x2695BB0", VA = "0x182696BB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2696C50", Offset = "0x2695C50", VA = "0x182696C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event DJLBGEEBEFL NFHDPBKNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x26969A0", Offset = "0x26959A0", VA = "0x1826969A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2696B10", Offset = "0x2695B10", VA = "0x182696B10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event DJLBGEEBEFL NILLDLCILNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x26968A0", Offset = "0x26958A0", VA = "0x1826968A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2696A70", Offset = "0x2695A70", VA = "0x182696A70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event DJLBGEEBEFL NOFIPHLPDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x26966C0", Offset = "0x26956C0", VA = "0x1826966C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2696760", Offset = "0x2695760", VA = "0x182696760", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<KNBPMPDLLNP, bool> MKEIMCAPDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2696CF0", Offset = "0x2695CF0", VA = "0x182696CF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2696800", Offset = "0x2695800", VA = "0x182696800", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "19")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2697090", Offset = "0x2696090", VA = "0x182697090", Slot = "14")]
	public void PHPNNNFINEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2696940", Offset = "0x2695940", VA = "0x182696940", Slot = "15")]
	public void HNCKPFKBFDC(GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2696970", Offset = "0x2695970", VA = "0x182696970", Slot = "16")]
	public void IDFNHFODFML(GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2696A40", Offset = "0x2695A40", VA = "0x182696A40", Slot = "17")]
	public void JLIDBIDOBOI(GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2696D90", Offset = "0x2695D90", VA = "0x182696D90", Slot = "18")]
	public void PBJOGOKFHPC(KNBPMPDLLNP KJNNCDKFMMI, bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2696E40", Offset = "0x2695E40", VA = "0x182696E40")]
	private void PEAOLDLIGBA(DJLBGEEBEFL DEGHCFJKCEP, GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FGNBFFCBEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class OCFEEEFODLI : BHEMEEJAANK, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct GIBONODBGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OCFEEEFODLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3D297D0", Offset = "0x3D287D0", VA = "0x183D297D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct JHBHPPHJHON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public OCFEEEFODLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C780", Offset = "0x3D2B780", VA = "0x183D2C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GBKJBGELNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GBKJBGELNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3D29730", Offset = "0x3D28730", VA = "0x183D29730")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct BKCPJCDMJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public OCFEEEFODLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GBKJBGELNLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3D25BD0", Offset = "0x3D24BD0", VA = "0x183D25BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3D26160", Offset = "0x3D25160", VA = "0x183D26160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NPHDAKAOPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public NPHDAKAOPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3D30540", Offset = "0x3D2F540", VA = "0x183D30540")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private EABAPHHMCLM[] GKAPFPEOMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CancellationTokenSource ANGOLJLDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int EOHDNPLEEAE;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A1D0", Offset = "0x2E691D0", VA = "0x182E6A1D0", Slot = "7")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2E698A0", Offset = "0x2E688A0", VA = "0x182E698A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2E69F20", Offset = "0x2E68F20", VA = "0x182E69F20", Slot = "6")]
	public void KJMCNJCBCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2E69DD0", Offset = "0x2E68DD0", VA = "0x182E69DD0", Slot = "5")]
	public void INFNDPGMHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2E698B0", Offset = "0x2E688B0", VA = "0x182E698B0", Slot = "4")]
	[AsyncStateMachine(typeof(GIBONODBGFN))]
	public Task EMMMFMKKCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A380", Offset = "0x2E69380", VA = "0x182E6A380")]
	private void OBPJEINHGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A250", Offset = "0x2E69250", VA = "0x182E6A250")]
	[AsyncStateMachine(typeof(JHBHPPHJHON))]
	private Task NHDDFAMLHLL(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2E69B70", Offset = "0x2E68B70", VA = "0x182E69B70")]
	[AsyncStateMachine(typeof(BKCPJCDMJAB))]
	private Task<bool> GFGNMDMGKBG(int NPDGHPHAKDK, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A6C0", Offset = "0x2E696C0", VA = "0x182E6A6C0")]
	private void ODGBMOGCLOI(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A090", Offset = "0x2E69090", VA = "0x182E6A090")]
	private void MOAKGLGIEII(int NPDGHPHAKDK, bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2E699C0", Offset = "0x2E689C0", VA = "0x182E699C0")]
	private void FLAMCPENOJB(int NPDGHPHAKDK, Exception ILBPMKLBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2E69CC0", Offset = "0x2E68CC0", VA = "0x182E69CC0")]
	private void HAMJBGHFIJE(CancellationToken NIEOBBGKEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OCFEEEFODLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal class OPDMKJFBHDK : KJIGEGFPGBM, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct KBOCBCIFMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public OPDMKJFBHDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MMIGNNJDMKB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CB90", Offset = "0x3D2BB90", VA = "0x183D2CB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GGBFBHOIFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OPDMKJFBHDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MMIGNNJDMKB roomData;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GGBFBHOIFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D297A0", Offset = "0x3D287A0", VA = "0x183D297A0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct KCBLLMFMCAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public HFCIAEIHEJM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CFD0", Offset = "0x3D2BFD0", VA = "0x183D2CFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NLHHAEFOACL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public OPDMKJFBHDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3D300B0", Offset = "0x3D2F0B0", VA = "0x183D300B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HashSet<HFCIAEIHEJM> GJHBBANAPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GEGNGOGKNPE PBNMNDEPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private HADDBKOIJFF NBEHAOEOMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MPPGFPAKOOC KCLKMNDABMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IDisposable KHIJPOHJLLA;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LCNAHLDKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2E6BE40", Offset = "0x2E6AE40", VA = "0x182E6BE40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task FANAKHALKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2E6B930", Offset = "0x2E6A930", VA = "0x182E6B930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BB40", Offset = "0x2E6AB40", VA = "0x182E6BB40", Slot = "6")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B2E0", Offset = "0x2E6A2E0", VA = "0x182E6B2E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B040", Offset = "0x2E6A040", VA = "0x182E6B040", Slot = "5")]
	public bool CKPFIOCMDCB(HFCIAEIHEJM AMMJBKKDPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B0A0", Offset = "0x2E6A0A0", VA = "0x182E6B0A0")]
	private void CNEIAOHBPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B5B0", Offset = "0x2E6A5B0", VA = "0x182E6B5B0")]
	private void GFDALFBJINH(MMIGNNJDMKB GPCLICNBEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B490", Offset = "0x2E6A490", VA = "0x182E6B490")]
	[AsyncStateMachine(typeof(KBOCBCIFMHI))]
	private Task FGCBCLADOHC(MMIGNNJDMKB GPCLICNBEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BA60", Offset = "0x2E6AA60", VA = "0x182E6BA60")]
	private Func<CancellationToken, List<Task>> MJNOIDOKKBB(MMIGNNJDMKB GPCLICNBEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BE70", Offset = "0x2E6AE70", VA = "0x182E6BE70")]
	private List<Task> OOOBJHENBJH(MMIGNNJDMKB GPCLICNBEEG, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B360", Offset = "0x2E6A360", VA = "0x182E6B360")]
	[AsyncStateMachine(typeof(KCBLLMFMCAJ))]
	private Task EPHOKEFLDBB(HFCIAEIHEJM JDIKKADHENL, MMIGNNJDMKB FILAKGLBGGA, CancellationToken KCCFEDJJGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B830", Offset = "0x2E6A830", VA = "0x182E6B830")]
	[AsyncStateMachine(typeof(NLHHAEFOACL))]
	private Task HOPHNMKLKGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B940", Offset = "0x2E6A940", VA = "0x182E6B940")]
	private void KJMCNJCBCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C3A0", Offset = "0x2E6B3A0", VA = "0x182E6C3A0")]
	public OPDMKJFBHDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal class AKMLFHMBMIA : OENKPGLLGIL, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CCLNHMKELCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public BDHECDAPBLF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2E5BB30", Offset = "0x2E5AB30", VA = "0x182E5BB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FAMNALNHILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BDHECDAPBLF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private global::FCHNJJOGFOB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private DGAJACEMLNI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private LEKCEKMLHEL <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2E5D200", Offset = "0x2E5C200", VA = "0x182E5D200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OCKAKOIKOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task<GDFDJMJJEPG> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OCKAKOIKOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		internal Task<GDFDJMJJEPG> <ConnectToRoomAndRunLoadLogic>b__0(NILMFDECOMH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct KBAFPPAJCAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BDHECDAPBLF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DGAJACEMLNI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private OCKAKOIKOHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CGCFOACLBLD <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NILMFDECOMH <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private ACHCIGHCIHA <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<GDFDJMJJEPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2E608C0", Offset = "0x2E5F8C0", VA = "0x182E608C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct PBLDFLDEDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private NILMFDECOMH <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private NILMFDECOMH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2E6C860", Offset = "0x2E6B860", VA = "0x182E6C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FFCBKMIGMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private GBDCKFPNAEP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2E5DBA0", Offset = "0x2E5CBA0", VA = "0x182E5DBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PCJEOGNCLDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DGAJACEMLNI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NILMFDECOMH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<LKPOELFDMBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2E6D120", Offset = "0x2E6C120", VA = "0x182E6D120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class BDJCADHNODO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public BDJCADHNODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A810", Offset = "0x2E59810", VA = "0x182E5A810")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A710", Offset = "0x2E59710", VA = "0x182E5A710")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct ALMIGJGILHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private BDJCADHNODO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2E597D0", Offset = "0x2E587D0", VA = "0x182E597D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct PMPLMMHGDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public DGAJACEMLNI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GDFDJMJJEPG initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public JJPHLLGENAE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CGCFOACLBLD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private NILMFDECOMH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2E70E60", Offset = "0x2E6FE60", VA = "0x182E70E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct OKDMMHLPCKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private NILMFDECOMH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2E6A820", Offset = "0x2E69820", VA = "0x182E6A820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct HMEINKHFGGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2E5F420", Offset = "0x2E5E420", VA = "0x182E5F420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct EHOGJAIOCJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CE00", Offset = "0x2E5BE00", VA = "0x182E5CE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct GJDFFDCIAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2E5E700", Offset = "0x2E5D700", VA = "0x182E5E700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct BOPFGCHDOBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AKMLFHMBMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2E5AC40", Offset = "0x2E59C40", VA = "0x182E5AC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class ILAOLEODAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ILAOLEODAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2E5FF80", Offset = "0x2E5EF80", VA = "0x182E5FF80")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IMNCJEFPEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IMNCJEFPEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2E60410", Offset = "0x2E5F410", VA = "0x182E60410")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class MPJPJEEKNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MPJPJEEKNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2E64EC0", Offset = "0x2E63EC0", VA = "0x182E64EC0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CNCMJMDMHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CNCMJMDMHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2E5C5A0", Offset = "0x2E5B5A0", VA = "0x182E5C5A0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly string NBCPGHFCCBC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly string LKJDMIGALLG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string LMCAIBMCDIP;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly Guid MLOKEIFCBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private EAPCBILCKLG HECOGALPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GEGNGOGKNPE PBNMNDEPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BHEMEEJAANK MJAGECADCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private BFJLFMGALHP JANAPNFIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private PJLEKAFGDIF PGEAEBLBOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private JKLAEHOICFC PJKPAHNPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IDisposable KHIJPOHJLLA;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus PLKDOKJGOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9E1340", Offset = "0x9E0340", VA = "0x1809E1340", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9E1350", Offset = "0x9E0350", VA = "0x1809E1350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2689B90", Offset = "0x2688B90", VA = "0x182689B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x268BCB0", Offset = "0x268ACB0", VA = "0x18268BCB0", Slot = "6")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x268A580", Offset = "0x2689580", VA = "0x18268A580", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x268A920", Offset = "0x2689920", VA = "0x18268A920", Slot = "5")]
	[AsyncStateMachine(typeof(CCLNHMKELCC))]
	public Task GAOHONPHLKA(JJPHLLGENAE LMINODPKJOI, BDHECDAPBLF FLKOAIGLKHM, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x268B980", Offset = "0x268A980", VA = "0x18268B980")]
	[AsyncStateMachine(typeof(FAMNALNHILC))]
	private Task KINLAIOBOON(JJPHLLGENAE LMINODPKJOI, BDHECDAPBLF FLKOAIGLKHM, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2689BE0", Offset = "0x2688BE0", VA = "0x182689BE0")]
	private static void AJLIIOCOCLE(JJPHLLGENAE LMINODPKJOI, Exception ILBPMKLBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x268BEC0", Offset = "0x268AEC0", VA = "0x18268BEC0")]
	private static void NAOOJJGIDMK(LEKCEKMLHEL DECHLKPOGCI, Exception ILBPMKLBBAG, [Optional] List<int> JEKFALECPOK, int EOHDNPLEEAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x268C700", Offset = "0x268B700", VA = "0x18268C700")]
	[AsyncStateMachine(typeof(KBAFPPAJCAB))]
	private Task NDAGJGJPBEK(NILMFDECOMH JBAEFOFJALC, JJPHLLGENAE LMINODPKJOI, BDHECDAPBLF FLKOAIGLKHM, DGAJACEMLNI HENBCBGFNBN, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x268B240", Offset = "0x268A240", VA = "0x18268B240")]
	private void IMFCHLGPBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x268B390", Offset = "0x268A390", VA = "0x18268B390")]
	[AsyncStateMachine(typeof(PBLDFLDEDJD))]
	private Task IOHOIJLGBDM(NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x268CC30", Offset = "0x268BC30", VA = "0x18268CC30")]
	private void NHABDDNFOOM(JJPHLLGENAE LMINODPKJOI, CancellationToken OGPKLEECEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x268A660", Offset = "0x2689660", VA = "0x18268A660")]
	private void FPHKJJEOHGF(JJPHLLGENAE LMINODPKJOI, DGAJACEMLNI HENBCBGFNBN, OperationCanceledException KGNIJFCFPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x268ABB0", Offset = "0x2689BB0", VA = "0x18268ABB0")]
	private void HLICEBNIEBB(JJPHLLGENAE LMINODPKJOI, DGAJACEMLNI HENBCBGFNBN, Exception ILBPMKLBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x268B6F0", Offset = "0x268A6F0", VA = "0x18268B6F0")]
	private void KCKPNIGBEOI(JJPHLLGENAE LMINODPKJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x268A1B0", Offset = "0x26891B0", VA = "0x18268A1B0")]
	private static GDHGOFCBJHF CPJBOJBIJEN(JJPHLLGENAE LMINODPKJOI)
	{
		return default(GDHGOFCBJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x268B140", Offset = "0x268A140", VA = "0x18268B140")]
	[AsyncStateMachine(typeof(FFCBKMIGMHO))]
	private Task IKLBDDPGHJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x268D3E0", Offset = "0x268C3E0", VA = "0x18268D3E0")]
	private static LKPOELFDMBJ PJPIFKLGOPE(JJPHLLGENAE LMINODPKJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x268D270", Offset = "0x268C270", VA = "0x18268D270")]
	[AsyncStateMachine(typeof(PCJEOGNCLDH))]
	private Task PIJJEAMDKEA(JJPHLLGENAE LMINODPKJOI, DGAJACEMLNI HENBCBGFNBN, NILMFDECOMH JBAEFOFJALC, CancellationToken JECEKMIFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x268A210", Offset = "0x2689210", VA = "0x18268A210")]
	[AsyncStateMachine(typeof(ALMIGJGILHP))]
	private Task DAGHOEKOGFN(JJPHLLGENAE LMINODPKJOI, CancellationTokenSource OPBBPIFAINF, Task KLNCOEPPCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x268AFB0", Offset = "0x2689FB0", VA = "0x18268AFB0")]
	[AsyncStateMachine(typeof(PMPLMMHGDAB))]
	private Task IKDLKDKNLKC(GDFDJMJJEPG KLENJIGINOD, CGCFOACLBLD HELHJOLCACD, JJPHLLGENAE CMKOKLANJAG, DGAJACEMLNI EALAJPNNPBH, NILMFDECOMH JBAEFOFJALC, CancellationToken EHHCODKAMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2689E30", Offset = "0x2688E30", VA = "0x182689E30")]
	private DGAJACEMLNI BKHBPGNPGGI(DGAJACEMLNI EALAJPNNPBH, ref CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x268BAE0", Offset = "0x268AAE0", VA = "0x18268BAE0")]
	[AsyncStateMachine(typeof(OKDMMHLPCKL))]
	private Task LGMJMHFIKHM(NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x268A370", Offset = "0x2689370", VA = "0x18268A370")]
	[AsyncStateMachine(typeof(HMEINKHFGGB))]
	private Task DDPHDJLDFJP(NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x268A070", Offset = "0x2689070", VA = "0x18268A070")]
	[AsyncStateMachine(typeof(EHOGJAIOCJB))]
	private Task CGLOCNCNJCN(NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x268AA70", Offset = "0x2689A70", VA = "0x18268AA70")]
	[AsyncStateMachine(typeof(GJDFFDCIAJA))]
	private Task HJKDADJGNCB(MMIGNNJDMKB FILAKGLBGGA, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x268AE70", Offset = "0x2689E70", VA = "0x18268AE70")]
	[AsyncStateMachine(typeof(BOPFGCHDOBM))]
	private Task IBMHOOFPKJM(NILMFDECOMH OIJDGGDGOKN, CancellationToken JECEKMIFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x268CF80", Offset = "0x268BF80", VA = "0x18268CF80")]
	private static void OPBPNDAHMDG(JJPHLLGENAE LMINODPKJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x268B4D0", Offset = "0x268A4D0", VA = "0x18268B4D0")]
	private void KCICFLPMLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x268BC20", Offset = "0x268AC20", VA = "0x18268BC20")]
	private void MGPLJFMNCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2689DA0", Offset = "0x2688DA0", VA = "0x182689DA0")]
	private void BDPCKBKPIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x268A5D0", Offset = "0x26895D0", VA = "0x18268A5D0")]
	private void EJOAOHOJNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x268CAC0", Offset = "0x268BAC0", VA = "0x18268CAC0")]
	private static void NGHCFCPFGGL(JJPHLLGENAE LMINODPKJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2689AD0", Offset = "0x2688AD0", VA = "0x182689AD0")]
	private static void ABJFBJIOPAJ(JJPHLLGENAE LMINODPKJOI, CancellationToken JECEKMIFAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x268D0F0", Offset = "0x268C0F0", VA = "0x18268D0F0")]
	private static void PCGBCBHINGC(JJPHLLGENAE LMINODPKJOI, Exception ILBPMKLBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x268C880", Offset = "0x268B880", VA = "0x18268C880")]
	private void NFBNLDBOCLJ(JJPHLLGENAE LMINODPKJOI, Task KLNCOEPPCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x268A4A0", Offset = "0x26894A0", VA = "0x18268A4A0")]
	private static void DHDJNBLMDNC(Func<string> BDICMGNPCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x268D580", Offset = "0x268C580", VA = "0x18268D580")]
	public AKMLFHMBMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class PLDLHOAIEGL : IOOCMJIHEDP, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class IBDGHLAIDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IBDGHLAIDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AC20", Offset = "0x3D29C20", VA = "0x183D2AC20")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class OAPGNCENADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OAPGNCENADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D305B0", Offset = "0x3D2F5B0", VA = "0x183D305B0")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class ODADMPKIICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ODADMPKIICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D30610", Offset = "0x3D2F610", VA = "0x183D30610")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JKGDKLPBIFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JKGDKLPBIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CB30", Offset = "0x3D2BB30", VA = "0x183D2CB30")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MJFGJMEKKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MJFGJMEKKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E4F0", Offset = "0x3D2D4F0", VA = "0x183D2E4F0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<Guid, FGLMNKCPBDG> OLMOACNIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly TimeSpan LPPEDEGDBFB;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "10")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F240", Offset = "0x2E6E240", VA = "0x182E6F240", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F540", Offset = "0x2E6E540", VA = "0x182E6F540", Slot = "4")]
	public MCEKOBJPBHA HMNAIPBHJIK(Guid MHGELGNLCHI)
	{
		return default(MCEKOBJPBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F2C0", Offset = "0x2E6E2C0", VA = "0x182E6F2C0", Slot = "5")]
	public bool FAHLDBEBGON(Guid MHGELGNLCHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FA20", Offset = "0x2E6EA20", VA = "0x182E6FA20", Slot = "8")]
	public bool KJMCNJCBCGH(Guid MHGELGNLCHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FF00", Offset = "0x2E6EF00", VA = "0x182E6FF00", Slot = "6")]
	public bool PJKGIJAHMPN(Guid MHGELGNLCHI, Task KMFBBIBMFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F7D0", Offset = "0x2E6E7D0", VA = "0x182E6F7D0", Slot = "7")]
	public bool IJIGLAHEKCA(Guid MHGELGNLCHI, NIHJKBCEGCJ CGALMJJGCDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F250", Offset = "0x2E6E250", VA = "0x182E6F250", Slot = "9")]
	public Task<(NIHJKBCEGCJ, Task)> EJEAKEJBKLN(Guid MHGELGNLCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FC70", Offset = "0x2E6EC70", VA = "0x182E6FC70")]
	private void MIABLHNGAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2E702C0", Offset = "0x2E6F2C0", VA = "0x182E702C0")]
	public PLDLHOAIEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal class OAMJKEOKKGB : MJBMIIBGBFL, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class BINICFODJPG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private readonly JJPHLLGENAE APGMDOJKEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private readonly CancellationTokenSource ANGOLJLDKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly CancellationToken KLOFIAEHOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool AHAHEHBENFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool JKEEGJNIPNF;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D25910", Offset = "0x3D24910", VA = "0x183D25910")]
		public BINICFODJPG(JJPHLLGENAE APGMDOJKEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D257C0", Offset = "0x3D247C0", VA = "0x183D257C0")]
		public void KJMCNJCBCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D25790", Offset = "0x3D24790", VA = "0x183D25790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class LBIAOCLICFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public HOGDMMENGFF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LBIAOCLICFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D370", Offset = "0x3D2C370", VA = "0x183D2D370")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct PCDANNNLEDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public HOGDMMENGFF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public OAMJKEOKKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D30970", Offset = "0x3D2F970", VA = "0x183D30970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OOIJLOENBIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OOIJLOENBIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D30900", Offset = "0x3D2F900", VA = "0x183D30900")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct GMDEMCMGHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public OAMJKEOKKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D29BD0", Offset = "0x3D28BD0", VA = "0x183D29BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x687AD0", Offset = "0x686AD0", VA = "0x180687AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MCBLNHFKGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public JJPHLLGENAE newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MCBLNHFKGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E180", Offset = "0x3D2D180", VA = "0x183D2E180")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E220", Offset = "0x3D2D220", VA = "0x183D2E220")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E260", Offset = "0x3D2D260", VA = "0x183D2E260")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JADEJMFOEMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JADEJMFOEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B630", Offset = "0x3D2A630", VA = "0x183D2B630")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct JDFHGLNLBHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public JJPHLLGENAE newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public OAMJKEOKKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public BDHECDAPBLF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private MCBLNHFKGNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B8A0", Offset = "0x3D2A8A0", VA = "0x183D2B8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private GEGNGOGKNPE PBNMNDEPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private BHEMEEJAANK MJAGECADCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private JKLAEHOICFC PJKPAHNPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private OENKPGLLGIL FCFNCJNKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private long DJBKAIBBHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private BINICFODJPG LAMHFJIKGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool MGOGPHEAEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Task LFOGMGCLIDO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E680C0", Offset = "0x2E670C0", VA = "0x182E680C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CIGDJCGMKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x969290", Offset = "0x968290", VA = "0x180969290")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2E68110", Offset = "0x2E67110", VA = "0x182E68110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E69060", Offset = "0x2E68060", VA = "0x182E69060", Slot = "4")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E68350", Offset = "0x2E67350", VA = "0x182E68350", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E681F0", Offset = "0x2E671F0", VA = "0x182E681F0")]
	[AsyncStateMachine(typeof(PCDANNNLEDI))]
	private Task BBDHLJNHNIO(HOGDMMENGFF NLPJCMLJMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E68E50", Offset = "0x2E67E50", VA = "0x182E68E50")]
	private void MENCBKDIOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E68810", Offset = "0x2E67810", VA = "0x182E68810")]
	private void FIIDEHPOMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E68C50", Offset = "0x2E67C50", VA = "0x182E68C50")]
	private void MCIBOGPMLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E68040", Offset = "0x2E67040", VA = "0x182E68040")]
	private bool ACLKDHEEMLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E68A20", Offset = "0x2E67A20", VA = "0x182E68A20")]
	[AsyncStateMachine(typeof(GMDEMCMGHPD))]
	private void GPABAKIJMJI(int IFEILBLHHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E684D0", Offset = "0x2E674D0", VA = "0x182E684D0")]
	private void EHMOBIHHFKD(out IDisposable FBGFOONONLC, out IDisposable AFEOLNBKMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E69310", Offset = "0x2E68310", VA = "0x182E69310")]
	private bool NEGPPKIGMKD(JJPHLLGENAE APGMDOJKEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E68310", Offset = "0x2E67310", VA = "0x182E68310")]
	private void CEFFGAHGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E68B10", Offset = "0x2E67B10", VA = "0x182E68B10")]
	[AsyncStateMachine(typeof(JDFHGLNLBHF))]
	private Task KINLAIOBOON(JJPHLLGENAE APGMDOJKEFH, BDHECDAPBLF FLKOAIGLKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E69490", Offset = "0x2E68490", VA = "0x182E69490")]
	public OAMJKEOKKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class FKBACFPGJAE : NNCFJCNKKJL, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct DEOHLMDPHOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<KCNIDPOKJDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public FKBACFPGJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<KCNIDPOKJDF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x31ED8D0", Offset = "0x31EC8D0", VA = "0x1831ED8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x31EDB20", Offset = "0x31ECB20", VA = "0x1831EDB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class OOPBLHNAMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public KNMGGFFPHPG message;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OOPBLHNAMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x31FC940", Offset = "0x31FB940", VA = "0x1831FC940")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class EIODBDBDGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public KNMGGFFPHPG messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EIODBDBDGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x31EEB10", Offset = "0x31EDB10", VA = "0x1831EEB10")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class DJGLPLAFKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DJGLPLAFKIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x31EDFC0", Offset = "0x31ECFC0", VA = "0x1831EDFC0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct NDKHGEELENG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FKBACFPGJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<NEJLBNOHIBA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x31FAC10", Offset = "0x31F9C10", VA = "0x1831FAC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class FMOLDHOMPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public KNMGGFFPHPG operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FMOLDHOMPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x31EF830", Offset = "0x31EE830", VA = "0x1831EF830")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct AHFCKNELLLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public KNMGGFFPHPG operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public FKBACFPGJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private DGAJACEMLNI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x31E9390", Offset = "0x31E8390", VA = "0x1831E9390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct CILCILGHNOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<NEJLBNOHIBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public FKBACFPGJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private DGAJACEMLNI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x31ECBD0", Offset = "0x31EBBD0", VA = "0x1831ECBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x31ED020", Offset = "0x31EC020", VA = "0x1831ED020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class FKMAIAAJOOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public NEJLBNOHIBA operation;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FKMAIAAJOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x31EF7B0", Offset = "0x31EE7B0", VA = "0x1831EF7B0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct NMBCNEKJOID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public NEJLBNOHIBA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public FKBACFPGJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private global::FCHNJJOGFOB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x31FB720", Offset = "0x31FA720", VA = "0x1831FB720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class JBPLJMPNOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JBPLJMPNOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x31F3090", Offset = "0x31F2090", VA = "0x1831F3090")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class NMNIJFGLMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public NMNIJFGLMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x31FBC60", Offset = "0x31FAC60", VA = "0x1831FBC60")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private BFJLFMGALHP JANAPNFIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private CEAHDCCBJHP HDOBPMGCNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private PNIMAPFPOBF JJIKKENKMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private TaskCompletionSource<KCNIDPOKJDF> IOPLEPHGBBB;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x26989B0", Offset = "0x26979B0", VA = "0x1826989B0", Slot = "7")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2697B30", Offset = "0x2696B30", VA = "0x182697B30", Slot = "6")]
	[AsyncStateMachine(typeof(DEOHLMDPHOE))]
	public Task<KCNIDPOKJDF> HFPFGLEPFGF(CancellationToken NJACNIOFFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2698020", Offset = "0x2697020", VA = "0x182698020", Slot = "4")]
	public void MAKOOCGLLOD(KNMGGFFPHPG LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2698A90", Offset = "0x2697A90", VA = "0x182698A90", Slot = "5")]
	public void NBBDJFJFPLL(KNMGGFFPHPG EPLELHDMLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2697EF0", Offset = "0x2696EF0", VA = "0x182697EF0")]
	[AsyncStateMachine(typeof(NDKHGEELENG))]
	private Task KBDMFHCADMK(KNMGGFFPHPG KJACHHOOFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2697A00", Offset = "0x2696A00", VA = "0x182697A00")]
	[AsyncStateMachine(typeof(AHFCKNELLLO))]
	private Task GDJJCAHBODL(KNMGGFFPHPG KDPAICMMEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2698860", Offset = "0x2697860", VA = "0x182698860")]
	[AsyncStateMachine(typeof(CILCILGHNOI))]
	private Task<NEJLBNOHIBA> MPKDDGJMNBD(KNMGGFFPHPG KJACHHOOFKC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2697800", Offset = "0x2696800", VA = "0x182697800")]
	private DGAJACEMLNI BMGPMMOJDIJ(KNMGGFFPHPG DNAOLLFBNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2697880", Offset = "0x2696880", VA = "0x182697880")]
	[AsyncStateMachine(typeof(NMBCNEKJOID))]
	private Task BMOMAMCLIFC(NEJLBNOHIBA HMHJFDAOLEM, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2697C70", Offset = "0x2696C70", VA = "0x182697C70")]
	private NEJLBNOHIBA JLLCJBKKIFB(KNMGGFFPHPG KJACHHOOFKC, DGAJACEMLNI DLNPHMAKOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x27E89A0", Offset = "0x27E79A0", VA = "0x1827E89A0")]
	private T FCKPDJDHJBJ<T>(T DFEOJBAFBHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2698450", Offset = "0x2697450", VA = "0x182698450")]
	private NEJLBNOHIBA MBEIHCGPIND(KNMGGFFPHPG KJACHHOOFKC, DGAJACEMLNI DLNPHMAKOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FKBACFPGJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x26979B0", Offset = "0x26969B0", VA = "0x1826979B0")]
	[CompilerGenerated]
	private void DFBODAGEEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Preserve]
internal sealed class AKHGHOINEMN : CEAHDCCBJHP, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class GLAAKNMFBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GLAAKNMFBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2E5F000", Offset = "0x2E5E000", VA = "0x182E5F000")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class MKGOKKDNLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MKGOKKDNLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2E63DE0", Offset = "0x2E62DE0", VA = "0x182E63DE0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private OADHKCLEONA BHEGBBGFCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NNCFJCNKKJL NHNKGIDKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IOOCMJIHEDP OLMOACNIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private PAKFKMHNOJA EJHEHHEJMEL;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2688F10", Offset = "0x2687F10", VA = "0x182688F10", Slot = "6")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2687710", Offset = "0x2686710", VA = "0x182687710", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2688030", Offset = "0x2687030", VA = "0x182688030", Slot = "4")]
	public MCEKOBJPBHA KKFEPEPBJMH(KNMGGFFPHPG AKPEAIHBLLD)
	{
		return default(MCEKOBJPBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2689080", Offset = "0x2688080", VA = "0x182689080", Slot = "5")]
	public void NHEGEEEEAPB(Guid MHGELGNLCHI, Task KMFBBIBMFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2687640", Offset = "0x2686640", VA = "0x182687640")]
	private void AKDOEJALECP(byte GNOOEPNILHC, int OBACLODMPLK, object KLLPOBANEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2688510", Offset = "0x2687510", VA = "0x182688510")]
	private void KMMECMGEIKN(IEKPPDBGAIA APIGNLIODDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x26877B0", Offset = "0x26867B0", VA = "0x1826877B0")]
	private void ENHOPBMEKDH(IEKPPDBGAIA APIGNLIODDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2689820", Offset = "0x2688820", VA = "0x182689820")]
	private void PGJHCMGFDLA(IEKPPDBGAIA APIGNLIODDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2687A90", Offset = "0x2686A90", VA = "0x182687A90")]
	private NIHJKBCEGCJ IJAOMINJIEN(KNMGGFFPHPG DNAOLLFBNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2689300", Offset = "0x2688300", VA = "0x182689300")]
	private void NHHEOCOEMCM(KNMGGFFPHPG KDPAICMMEJA, NIHJKBCEGCJ CGALMJJGCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2688C10", Offset = "0x2687C10", VA = "0x182688C10")]
	private bool MPHAEANHICL(KNMGGFFPHPG KDPAICMMEJA, NIHJKBCEGCJ CGALMJJGCDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2689550", Offset = "0x2688550", VA = "0x182689550")]
	private bool NIDIMGLKMPG(KNMGGFFPHPG GEAMOEKJAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2687D30", Offset = "0x2686D30", VA = "0x182687D30")]
	private bool JCCBBGCPJEL(byte GNOOEPNILHC, ExitGames.Client.Photon.Hashtable APIGNLIODDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AKHGHOINEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class IBJDLEEMFHA : KMFGHJFILBA, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class EBEDMAKALNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public KCNIDPOKJDF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public IBJDLEEMFHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public KNMGGFFPHPG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EBEDMAKALNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x31EE0E0", Offset = "0x31ED0E0", VA = "0x1831EE0E0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x31EE150", Offset = "0x31ED150", VA = "0x1831EE150")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct CONHBMMHICB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public IBJDLEEMFHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public KNMGGFFPHPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x31ED320", Offset = "0x31EC320", VA = "0x1831ED320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x31ED880", Offset = "0x31EC880", VA = "0x1831ED880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class PFDLACPEOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public KCNIDPOKJDF operationType;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PFDLACPEOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x31FDF80", Offset = "0x31FCF80", VA = "0x1831FDF80")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GMPNLJHCHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GMPNLJHCHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x31F0EB0", Offset = "0x31EFEB0", VA = "0x1831F0EB0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x31F0F20", Offset = "0x31EFF20", VA = "0x1831F0F20")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x31F0F90", Offset = "0x31EFF90", VA = "0x1831F0F90")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct CABEIJLGEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public IBJDLEEMFHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private GMPNLJHCHJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MCEKOBJPBHA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private NIHJKBCEGCJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<(NIHJKBCEGCJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x31EBED0", Offset = "0x31EAED0", VA = "0x1831EBED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x31EC5C0", Offset = "0x31EB5C0", VA = "0x1831EC5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private OADHKCLEONA BHEGBBGFCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private CEAHDCCBJHP HDOBPMGCNLN;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x269C7D0", Offset = "0x269B7D0", VA = "0x18269C7D0", Slot = "5")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x269C690", Offset = "0x269B690", VA = "0x18269C690", Slot = "4")]
	[AsyncStateMachine(typeof(CONHBMMHICB))]
	private Task<NIHJKBCEGCJ> EDNLKNDDDGB(KNMGGFFPHPG DNAOLLFBNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x269C430", Offset = "0x269B430", VA = "0x18269C430")]
	private bool BHLDBBOHLFK(KCNIDPOKJDF KJNNCDKFMMI, out NIHJKBCEGCJ MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x269C2F0", Offset = "0x269B2F0", VA = "0x18269C2F0")]
	[AsyncStateMachine(typeof(CABEIJLGEDJ))]
	private Task<NIHJKBCEGCJ> BFIKEPCBHED(KNMGGFFPHPG KJACHHOOFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IBJDLEEMFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Preserve]
internal sealed class PIEGHLONIGI : BPDAIKIDHAK, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct CMAOLMHHNIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<GDFDJMJJEPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public PIEGHLONIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<HIEMHHFNKEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3D26AC0", Offset = "0x3D25AC0", VA = "0x183D26AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3D26CA0", Offset = "0x3D25CA0", VA = "0x183D26CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MFDBKEEDDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MFDBKEEDDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E2A0", Offset = "0x3D2D2A0", VA = "0x183D2E2A0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct EJKGAFNLNNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<HIEMHHFNKEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public PIEGHLONIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public JJPHLLGENAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private MFDBKEEDDEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<NDNNICHHGLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3D275D0", Offset = "0x3D265D0", VA = "0x183D275D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3D27990", Offset = "0x3D26990", VA = "0x183D27990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class HNPPAJHBJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HNPPAJHBJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x126AA80", Offset = "0x1269A80", VA = "0x18126AA80")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(MFFGBJPFPEF sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly (INLAJELACMH superRoomData, string unityAssetId, INLAJELACMH subRoomData) DEEFAEGDPLM;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EE40", Offset = "0x2E6DE40", VA = "0x182E6EE40", Slot = "5")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EEB0", Offset = "0x2E6DEB0", VA = "0x182E6EEB0", Slot = "4")]
	[AsyncStateMachine(typeof(CMAOLMHHNIG))]
	public Task<GDFDJMJJEPG> OFJDKEKCIJN(NILMFDECOMH OIJDGGDGOKN, JJPHLLGENAE LMINODPKJOI, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E780", Offset = "0x2E6D780", VA = "0x182E6E780")]
	[AsyncStateMachine(typeof(EJKGAFNLNNJ))]
	private Task<HIEMHHFNKEP> DBPFNNAOHCL(JJPHLLGENAE LMINODPKJOI, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2E6ECB0", Offset = "0x2E6DCB0", VA = "0x182E6ECB0")]
	private GDFDJMJJEPG MPFKLIJFFLM(JJPHLLGENAE LMINODPKJOI, HIEMHHFNKEP EKGPEMDBMDG, long PFEOAIPJFFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E900", Offset = "0x2E6D900", VA = "0x182E6E900")]
	private (INLAJELACMH, string, INLAJELACMH) FDGCBEPHHAJ(JJPHLLGENAE LMINODPKJOI, HIEMHHFNKEP EKGPEMDBMDG, long PFEOAIPJFFN)
	{
		return default((INLAJELACMH, string, INLAJELACMH));
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PIEGHLONIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[Preserve]
internal sealed class JLOACCGBLFP : PNIMAPFPOBF, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MJJFMFHNDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MJJFMFHNDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x31FA080", Offset = "0x31F9080", VA = "0x1831FA080")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct ADGOLEIBPBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public JLOACCGBLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public DGAJACEMLNI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x31E8EE0", Offset = "0x31E7EE0", VA = "0x1831E8EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x31E9340", Offset = "0x31E8340", VA = "0x1831E9340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct EKBGGKDJLLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public JLOACCGBLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public DGAJACEMLNI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x31EEB70", Offset = "0x31EDB70", VA = "0x1831EEB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x31EF150", Offset = "0x31EE150", VA = "0x1831EF150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class JGHFFEHGADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JGHFFEHGADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x31F3C20", Offset = "0x31F2C20", VA = "0x1831F3C20")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct KGBGGALLNJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public KNMGGFFPHPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public JLOACCGBLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DGAJACEMLNI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private AEBLGFABLHE <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private PIHMHNLDCFL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x31F5460", Offset = "0x31F4460", VA = "0x1831F5460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x31F5EF0", Offset = "0x31F4EF0", VA = "0x1831F5EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private LKGOHJCOGLG PFFGNFFADCL;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private BCJGNNLDEJN ECHNCKBBEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x26A1F90", Offset = "0x26A0F90", VA = "0x1826A1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x26A2440", Offset = "0x26A1440", VA = "0x1826A2440", Slot = "8")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x26A24D0", Offset = "0x26A14D0", VA = "0x1826A24D0", Slot = "4")]
	[AsyncStateMachine(typeof(ADGOLEIBPBM))]
	public Task<KNMGGFFPHPG> OKLIBFOEIBH(KNMGGFFPHPG KJACHHOOFKC, DGAJACEMLNI DLNPHMAKOCI, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x26A1A50", Offset = "0x26A0A50", VA = "0x1826A1A50", Slot = "5")]
	[AsyncStateMachine(typeof(EKBGGKDJLLD))]
	public Task<KNMGGFFPHPG> BBJFHHCMOGM(CancellationToken NIEOBBGKEFJ, DGAJACEMLNI DLNPHMAKOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x26A1BB0", Offset = "0x26A0BB0", VA = "0x1826A1BB0", Slot = "6")]
	public MFGGDAIBFBD DDKDHMDHCJN(NEJLBNOHIBA BIPLIJDCIEC, NILMFDECOMH OIJDGGDGOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26A2040", Offset = "0x26A1040", VA = "0x1826A2040", Slot = "7")]
	public MFGGDAIBFBD FPBBFBLBDNH(NEJLBNOHIBA BIPLIJDCIEC, NILMFDECOMH OIJDGGDGOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x26A22C0", Offset = "0x26A12C0", VA = "0x1826A22C0")]
	[AsyncStateMachine(typeof(KGBGGALLNJP))]
	private Task<KNMGGFFPHPG> LCOJPMAFCJL(KNMGGFFPHPG KJACHHOOFKC, DGAJACEMLNI DLNPHMAKOCI, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x249A140", Offset = "0x2499140", VA = "0x18249A140")]
	private static byte[] EJCBOMGLAID(KNMGGFFPHPG LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26A1E40", Offset = "0x26A0E40", VA = "0x1826A1E40")]
	private static string DNGCGAOEIPN(byte[] JCKDEHJPDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JLOACCGBLFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class GEHNLMCFNCE : OADHKCLEONA, JGHNIBPBLBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private EFMAHDKJBBP IPICAMEAOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private BFJLFMGALHP JANAPNFIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private OHFMKHGMJEI HAPKMMBPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private OENKPGLLGIL FCFNCJNKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private KJIGEGFPGBM CEKLIKIGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private JKLAEHOICFC PJKPAHNPCHO;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2699820", Offset = "0x2698820", VA = "0x182699820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static NIHJKBCEGCJ KHANBACLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2699C00", Offset = "0x2698C00", VA = "0x182699C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2699E60", Offset = "0x2698E60", VA = "0x182699E60", Slot = "7")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2699A70", Offset = "0x2698A70", VA = "0x182699A70", Slot = "4")]
	public NIHJKBCEGCJ FBPOJNNAHAA(DMHOAMAMDGI NDODIMDBLAB, KCNIDPOKJDF KLLGHOJBLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2699C10", Offset = "0x2698C10", VA = "0x182699C10", Slot = "5")]
	public NIHJKBCEGCJ MFKLLJIHGNP(DMHOAMAMDGI DPEPLBDJLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2699870", Offset = "0x2698870", VA = "0x182699870", Slot = "6")]
	public NIHJKBCEGCJ BEOJBNNGBPN(DMHOAMAMDGI DPEPLBDJLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2699FC0", Offset = "0x2698FC0", VA = "0x182699FC0")]
	private static NIHJKBCEGCJ OHACODFOKJH(HBKJCNMGDOP COBJNMAIDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GEHNLMCFNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class ICLDPKBOJDH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x269C880", Offset = "0x269B880", VA = "0x18269C880")]
	public ICLDPKBOJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xF57D90", Offset = "0xF56D90", VA = "0x180F57D90")]
	public ICLDPKBOJDH(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[Preserve]
internal sealed class IPMMKCHDHNM : CGENMFCCDOP, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct GDPNJLEMNMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public EIADPFDFDMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private global::FCHNJJOGFOB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private NILMFDECOMH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private PGBAAGAGOLE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private NILMFDECOMH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x31EFFD0", Offset = "0x31EEFD0", VA = "0x1831EFFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x31F0730", Offset = "0x31EF730", VA = "0x1831F0730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct MGOHEPMFFOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x31F9A20", Offset = "0x31F8A20", VA = "0x1831F9A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NOHMCECFNIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x31FBCC0", Offset = "0x31FACC0", VA = "0x1831FBCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct MKHPOINHEBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x31FA0E0", Offset = "0x31F90E0", VA = "0x1831FA0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GLIPEBFNBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x31F0780", Offset = "0x31EF780", VA = "0x1831F0780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct LGONIGIJBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public IPMMKCHDHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public JCKPEGAFAPH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private global::FCHNJJOGFOB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x31F7910", Offset = "0x31F6910", VA = "0x1831F7910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static readonly TimeSpan IBHMCDBGKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private PNIMAPFPOBF JJIKKENKMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private BFJLFMGALHP JANAPNFIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private KJIGEGFPGBM CEKLIKIGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private CancellationTokenSource FJOCJBGJEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Task FDOOKDODILK;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x269FF50", Offset = "0x269EF50", VA = "0x18269FF50", Slot = "6")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x16472C0", Offset = "0x16462C0", VA = "0x1816472C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x269FA90", Offset = "0x269EA90", VA = "0x18269FA90", Slot = "4")]
	[AsyncStateMachine(typeof(GDPNJLEMNMP))]
	public Task<NIHJKBCEGCJ> HMHMNCPOLME(EIADPFDFDMD MBIMPHFLEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x26A0320", Offset = "0x269F320", VA = "0x1826A0320", Slot = "5")]
	[AsyncStateMachine(typeof(MGOHEPMFFOD))]
	public Task ODBLLKMEFFH([Optional] CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x16472C0", Offset = "0x16462C0", VA = "0x1816472C0")]
	public void KMLNEBOKAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x26A0110", Offset = "0x269F110", VA = "0x1826A0110")]
	private PGBAAGAGOLE NKNCMEGPGOP(EIADPFDFDMD MBIMPHFLEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x26A0440", Offset = "0x269F440", VA = "0x1826A0440")]
	[AsyncStateMachine(typeof(NOHMCECFNIO))]
	private Task OIBMDHDEBMM(MMIGNNJDMKB GJBHFPJIHBB, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x269FE30", Offset = "0x269EE30", VA = "0x18269FE30")]
	[AsyncStateMachine(typeof(MKHPOINHEBI))]
	private Task MAEJFJIHEEP([Optional] CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x269FBD0", Offset = "0x269EBD0", VA = "0x18269FBD0")]
	[AsyncStateMachine(typeof(GLIPEBFNBMK))]
	private Task IALCGPJGALE(TimeSpan ACJPLKFAGPG, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x269F820", Offset = "0x269E820", VA = "0x18269F820")]
	private Task FFDHMNCMJPJ(JCKPEGAFAPH MPBBMJKCHFP, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x269FD00", Offset = "0x269ED00", VA = "0x18269FD00")]
	[AsyncStateMachine(typeof(LGONIGIJBNE))]
	private Task KCDJBLKCHJL(JCKPEGAFAPH MPBBMJKCHFP, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x26A0570", Offset = "0x269F570", VA = "0x1826A0570")]
	private bool PLDGGJFNPCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IPMMKCHDHNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[Preserve]
internal class ENHGIPJGDHM : OHFMKHGMJEI, JGHNIBPBLBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct BEKKNJIPFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public ENHGIPJGDHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private global::FCHNJJOGFOB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A910", Offset = "0x2E59910", VA = "0x182E5A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private IFDFMCFIIAL AADAEPLNONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private OADHKCLEONA BHEGBBGFCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private PNIMAPFPOBF JJIKKENKMOE;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2691E70", Offset = "0x2690E70", VA = "0x182691E70", Slot = "6")]
	public void NAGCBALDEME(AMHDFPELFBK POBEANPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2691D00", Offset = "0x2690D00", VA = "0x182691D00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2691D50", Offset = "0x2690D50", VA = "0x182691D50", Slot = "5")]
	[AsyncStateMachine(typeof(BEKKNJIPFEC))]
	public Task IBOIMOGEDPB(string JLGENJBOGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2692090", Offset = "0x2691090", VA = "0x182692090", Slot = "4")]
	public NIHJKBCEGCJ PLDGGJFNPCK(DMHOAMAMDGI NDODIMDBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2691BF0", Offset = "0x2690BF0", VA = "0x182691BF0")]
	private PBDAHOFIJJE BALMNOJAKON(string JLGENJBOGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ENHGIPJGDHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class JJNCPEOGKBO
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x26A1890", Offset = "0x26A0890", VA = "0x1826A1890")]
	public static void LNKIBBOFALD(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x26A16D0", Offset = "0x26A06D0", VA = "0x1826A16D0")]
	internal static void JMAOICPLNPE(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x26A17B0", Offset = "0x26A07B0", VA = "0x1826A17B0")]
	internal static void KGIAJDNPPFA(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x26A1280", Offset = "0x26A0280", VA = "0x1826A1280")]
	internal static void AAANGABMFOO(GBDCKFPNAEP FOIOPKEONKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class KHGEGGJBACP : global::PEFNKMFFPFP<KNMGGFFPHPG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class KOPACPKKBHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public KNMGGFFPHPG message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public KOPACPKKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x31F6390", Offset = "0x31F5390", VA = "0x1831F6390")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly KHGEGGJBACP JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const string HJNJLODOGLH = "pl";

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x26A3B00", Offset = "0x26A2B00", VA = "0x1826A3B00")]
	public ExitGames.Client.Photon.Hashtable PNKNJNLKBEB(KNMGGFFPHPG LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x26A39C0", Offset = "0x26A29C0", VA = "0x1826A39C0", Slot = "5")]
	protected override void IGAGDOCAOCO(KNMGGFFPHPG LMLMHJKGDCH, IDictionary<object, object> FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x26A3640", Offset = "0x26A2640", VA = "0x1826A3640", Slot = "6")]
	public override KNMGGFFPHPG CJKIJAOEIBM(IDictionary<object, object> FILAKGLBGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x26A3840", Offset = "0x26A2840", VA = "0x1826A3840")]
	private static void DHDJNBLMDNC(string KHHCHKEIKIJ, KNMGGFFPHPG LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x26A3C00", Offset = "0x26A2C00", VA = "0x1826A3C00")]
	public KHGEGGJBACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x26A32F0", Offset = "0x26A22F0", VA = "0x1826A32F0")]
	[CompilerGenerated]
	internal static string BALIONFFDGO(GDFDJMJJEPG BNKBFACGLIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class OAJDDBCOLBE
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static NIHJKBCEGCJ KHANBACLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2E67F80", Offset = "0x2E66F80", VA = "0x182E67F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2E67D50", Offset = "0x2E66D50", VA = "0x182E67D50")]
	public static bool EOOKPAPFICE(this NIHJKBCEGCJ CGALMJJGCDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2E67FE0", Offset = "0x2E66FE0", VA = "0x182E67FE0")]
	public static NIHJKBCEGCJ OHACODFOKJH(HBKJCNMGDOP JIFACBIDLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2E67F70", Offset = "0x2E66F70", VA = "0x182E67F70")]
	public static NIHJKBCEGCJ JKJJAMFOIIF(params NIHJKBCEGCJ[] GDIEPBLHJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2E67D70", Offset = "0x2E66D70", VA = "0x182E67D70")]
	public static NIHJKBCEGCJ GMOEHJDHHKM(IEnumerable<NIHJKBCEGCJ> GDIEPBLHJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2E67AE0", Offset = "0x2E66AE0", VA = "0x182E67AE0")]
	public static string DCHLIOPDPKF(this NIHJKBCEGCJ MMPEAFKIOCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class CPFCOCIJDGC : CMEPAHKFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate NIHJKBCEGCJ GLIDLDOONNA([NotNull] DMHOAMAMDGI PPBGOFKIMPI);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class JCKLGENEOGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public DMHOAMAMDGI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JCKLGENEOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2E604B0", Offset = "0x2E5F4B0", VA = "0x182E604B0")]
		internal NIHJKBCEGCJ <Validate>b__0(GLIDLDOONNA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	protected readonly HashSet<GLIDLDOONNA> KOBCIKMHPND;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x268F5C0", Offset = "0x268E5C0", VA = "0x18268F5C0", Slot = "4")]
	public void OJOKFEMMPNI(GLIDLDOONNA AFKBPHIOOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x268F340", Offset = "0x268E340", VA = "0x18268F340", Slot = "5")]
	public void KFGABGBLMBC(GLIDLDOONNA AFKBPHIOOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x268F2F0", Offset = "0x268E2F0", VA = "0x18268F2F0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x268F3A0", Offset = "0x268E3A0", VA = "0x18268F3A0")]
	protected NIHJKBCEGCJ LOAEPKKACOJ(DMHOAMAMDGI DPEPLBDJLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x268F620", Offset = "0x268E620", VA = "0x18268F620")]
	protected CPFCOCIJDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class NNCIKDGKEFB : CPFCOCIJDGC, EFMAHDKJBBP, CMEPAHKFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class BIEOLKKHKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public NIHJKBCEGCJ result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public BIEOLKKHKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D25730", Offset = "0x3D24730", VA = "0x183D25730")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E66950", Offset = "0x2E65950", VA = "0x182E66950")]
	[Preserve]
	public NNCIKDGKEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E667D0", Offset = "0x2E657D0", VA = "0x182E667D0", Slot = "8")]
	public NIHJKBCEGCJ EBCEPGNJCCB(DMHOAMAMDGI DPEPLBDJLAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class FCFENHMIGDP : CPFCOCIJDGC, IFDFMCFIIAL, CMEPAHKFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class JEHMKMMCOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NIHJKBCEGCJ result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JEHMKMMCOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x31F3630", Offset = "0x31F2630", VA = "0x1831F3630")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x268F620", Offset = "0x268E620", VA = "0x18268F620")]
	[Preserve]
	public FCFENHMIGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2695B30", Offset = "0x2694B30", VA = "0x182695B30", Slot = "8")]
	public NIHJKBCEGCJ PLDGGJFNPCK(DMHOAMAMDGI PKPBDEIEICB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum DOCJJOEFAJF
{
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class DMGNIKBKLII
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class GABABNEGEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public global::FCHNJJOGFOB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GABABNEGEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2E5E680", Offset = "0x2E5D680", VA = "0x182E5E680")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public const string EOIOONCPFDB = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public const string CPADEAOPIMH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2690200", Offset = "0x268F200", VA = "0x182690200")]
	public static global::FCHNJJOGFOB<string> NFJIODIGMFG([Optional] string PAOCLLJLEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2690040", Offset = "0x268F040", VA = "0x182690040")]
	private static void KCMONNMBAKE(string PIIJMEAKDGO, OAHJLKFBMHH JBAEFOFJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x268FF40", Offset = "0x268EF40", VA = "0x18268FF40")]
	private static void CADAMDANLPP(string PIIJMEAKDGO, OAHJLKFBMHH JBAEFOFJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x26902D0", Offset = "0x268F2D0", VA = "0x1826902D0")]
	public static void NOJMCDOCNEE(global::FCHNJJOGFOB<string> JBAEFOFJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2690140", Offset = "0x268F140", VA = "0x182690140")]
	public static string NACPGCOHGAP(KNMGGFFPHPG DNAOLLFBNEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class LNPHIPMEDAF
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x26A77B0", Offset = "0x26A67B0", VA = "0x1826A77B0")]
	public static void KMCPKLPFGJC(this BMHJNIJKGAA GNPHKIFHPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x26A77C0", Offset = "0x26A67C0", VA = "0x1826A77C0")]
	public static void KMKBIEAJBGB(this BMHJNIJKGAA GNPHKIFHPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x26A76A0", Offset = "0x26A66A0", VA = "0x1826A76A0")]
	private static void CHMFGLOMCMC(this BMHJNIJKGAA GNPHKIFHPOM, bool EILNMMDDDLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PGAMNLIJLHA : JLJCIAPHMDI, GIMENMFNCMN, KLCONECFFJG, NAKPLBCDHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly GIMENMFNCMN MBAHCIBDJJJ;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public DMHOAMAMDGI HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E420", Offset = "0x2E6D420", VA = "0x182E6E420", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int HDPOCMIPNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E330", Offset = "0x2E6D330", VA = "0x182E6E330", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int DOACCKOCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E240", Offset = "0x2E6D240", VA = "0x182E6E240", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool NFCFBKFCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int BAKMJKAAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AA0", Offset = "0x6A3AA0", VA = "0x1806A4AA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event BGNOACFBGFB.HEPDMHFCDBD ACHOBFAFFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JPBEDCOIFNA NKJDBPGKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E470", Offset = "0x2E6D470", VA = "0x182E6E470", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E380", Offset = "0x2E6D380", VA = "0x182E6E380", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> KBOIFKMJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<DMHOAMAMDGI> GGMHBPKJMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action KLEDAAGLHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E6DF90", Offset = "0x2E6CF90", VA = "0x182E6DF90", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E6DEF0", Offset = "0x2E6CEF0", VA = "0x182E6DEF0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xBA2280", Offset = "0xBA1280", VA = "0x180BA2280")]
	public PGAMNLIJLHA(GIMENMFNCMN MBAHCIBDJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E0B0", Offset = "0x2E6D0B0", VA = "0x182E6E0B0", Slot = "8")]
	public bool FKAEENDOHIB(byte GNOOEPNILHC, ExitGames.Client.Photon.Hashtable KNMBMHHJEIM, KDGMCGJBAGF NFBADFJMCNL, SendOptions EPBLMJILLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E290", Offset = "0x2E6D290", VA = "0x182E6E290", Slot = "29")]
	public DMHOAMAMDGI JCMFHHEGOJB(int CJMDBHODHKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E160", Offset = "0x2E6D160", VA = "0x182E6E160", Slot = "16")]
	public DMHOAMAMDGI IBBBJMDNFNH(int HPIFBKJNDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "19")]
	public void AOHFFPEBDHI(object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "20")]
	public void MCAKGDDDNIG(object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "21")]
	public void FCBLHPLIDIN(object KCCFEDJJGAN, bool KFLBLFJIFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E050", Offset = "0x2E6D050", VA = "0x182E6E050", Slot = "22")]
	public IDisposable EIOBGAPJDLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "23")]
	private bool BFBMGICENJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "24")]
	public void LOOENNDAHNM(StringBuilder PPGOPAPHMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E030", Offset = "0x2E6D030", VA = "0x182E6E030", Slot = "25")]
	public bool DACGNJBJMLB(bool NAIGJBCNKCH, out string HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public void MJIFFCKFGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x154C050", Offset = "0x154B050", VA = "0x18154C050", Slot = "28")]
	public void BFOINFBLHKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct IEKPPDBGAIA
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const string ILNOJFCOBIA = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public const string NHEGEHCAJDP = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly IDictionary<object, object> APIGNLIODDG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A0280", Offset = "0x89F280", VA = "0x1808A0280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
	public IEKPPDBGAIA(IDictionary<object, object> APIGNLIODDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x269C8C0", Offset = "0x269B8C0", VA = "0x18269C8C0")]
	public bool CCHLBHEBHKJ(out KNMGGFFPHPG LMLMHJKGDCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x269C980", Offset = "0x269B980", VA = "0x18269C980")]
	public Guid DFIILGDKMLI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x269CB50", Offset = "0x269BB50", VA = "0x18269CB50")]
	public NIHJKBCEGCJ IHPPANEDICM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x269CA60", Offset = "0x269BA60", VA = "0x18269CA60")]
	public static ExitGames.Client.Photon.Hashtable HJNGNBALKKN(KNMGGFFPHPG LMLMHJKGDCH, NIHJKBCEGCJ CGALMJJGCDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class HFFFPDFCFHG
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x269AEF0", Offset = "0x2699EF0", VA = "0x18269AEF0")]
	public static string EMGPEIPCMOG(this JJPHLLGENAE DKBNHPIBBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x269B140", Offset = "0x269A140", VA = "0x18269B140")]
	public static bool HIGDHJJMFCC(this JJPHLLGENAE DKBNHPIBBHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct MPPGFPAKOOC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct MHIDKBPOOLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public MPPGFPAKOOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E350", Offset = "0x3D2D350", VA = "0x183D2E350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CancellationTokenSource ANGOLJLDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private Task KLOLOJBLOIC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E64F90", Offset = "0x2E63F90", VA = "0x182E64F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task FANAKHALKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E64FC0", Offset = "0x2E63FC0", VA = "0x182E64FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E65170", Offset = "0x2E64170", VA = "0x182E65170")]
	public MPPGFPAKOOC(CancellationToken NIEOBBGKEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E65040", Offset = "0x2E64040", VA = "0x182E65040")]
	[AsyncStateMachine(typeof(MHIDKBPOOLO))]
	public Task JLCJFHLOPDO(Func<CancellationToken, List<Task>> BEAGKAAFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E64F40", Offset = "0x2E63F40", VA = "0x182E64F40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct ENPIOIJAIHA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct IPOAFFHHODB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<global::OOPICKNMODO<TData>, AAHLPJGCFPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public global::ENPIOIJAIHA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private NILMFDECOMH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<global::CIOEKKBILIB<byte[], AAHLPJGCFPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E31BF0", Offset = "0x1E30BF0", VA = "0x181E31BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E33220", Offset = "0x1E32220", VA = "0x181E33220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private readonly global::DIHAHOBNPFF<TGetDataArg, TData> HOKAKDDBBJK;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
	internal ENPIOIJAIHA(global::DIHAHOBNPFF<TGetDataArg, TData> GODJKHDKJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x20144D0", Offset = "0x20134D0", VA = "0x1820144D0")]
	[AsyncStateMachine(typeof(global::ENPIOIJAIHA<, >.IPOAFFHHODB))]
	public Task<global::CIOEKKBILIB<global::OOPICKNMODO<TData>, AAHLPJGCFPM>> CBCJKLGBFME(TGetDataArg JCKDEHJPDNC, string MMIHBPNOBEL, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class PPJAEJLOAGE
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E73E90", Offset = "0x1E72E90", VA = "0x181E73E90")]
	public static global::ENPIOIJAIHA<TGetDataArg, TData> DHGKFEMNGCO<TGetDataArg, TData>(global::DIHAHOBNPFF<TGetDataArg, TData> GODJKHDKJCI)
	{
		return default(global::ENPIOIJAIHA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class EAPCBILCKLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly DCGCDOAFKJE DMPMLBGEDKK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private const string MDMJJCLJODF = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private const string HKIEOJGALCJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string HGLNKIOPJGJ = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string MFHMCBMPMDN = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string LJLBCOKGCPE = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private string ALDCIBLPJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private long? MAIKHHLFIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private long? IKPKNGFEOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private MLAKGLIELEE HNIKOOEHMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? HMJPMJGMIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private bool MLIPJCDIGMC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string JNKDGDNGHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long HBAACDBIMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2690670", Offset = "0x268F670", VA = "0x182690670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long AJDGGCIADKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x26909C0", Offset = "0x268F9C0", VA = "0x1826909C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MLAKGLIELEE EABEEELMCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6CB720", Offset = "0x6CA720", VA = "0x1806CB720")]
		get
		{
			return default(MLAKGLIELEE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2690430", Offset = "0x268F430", VA = "0x182690430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long CMNCCEONMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2690610", Offset = "0x268F610", VA = "0x182690610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2690F80", Offset = "0x268FF80", VA = "0x182690F80")]
	[Preserve]
	public EAPCBILCKLG([ELDNEOCBGIN(null)] DCGCDOAFKJE DMPMLBGEDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2690A20", Offset = "0x268FA20", VA = "0x182690A20")]
	private void MBFNDMKGHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2690BD0", Offset = "0x268FBD0", VA = "0x182690BD0")]
	public void NBLCMHIPKOK(long KPBGCMCAECK, long PFEOAIPJFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2690520", Offset = "0x268F520", VA = "0x182690520")]
	public void DFDGNIAKMMG(string OJNOAAHKKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x26906D0", Offset = "0x268F6D0", VA = "0x1826906D0")]
	public void KPINCKBPEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class MFGGDAIBFBD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct IIPICPNJDCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public KNMGGFFPHPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public MFGGDAIBFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<ADJLHAJLJIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B160", Offset = "0x3D2A160", VA = "0x183D2B160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B470", Offset = "0x3D2A470", VA = "0x183D2B470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct OPADGGGEPEE<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class HKMABGPOCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public KNMGGFFPHPG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HKMABGPOCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AB10", Offset = "0x3D29B10", VA = "0x183D2AB10")]
		internal KNMGGFFPHPG <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct MKGNAOAKLOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<ADJLHAJLJIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public KNMGGFFPHPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public MFGGDAIBFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private AEBLGFABLHE <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<ADJLHAJLJIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E550", Offset = "0x3D2D550", VA = "0x183D2E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ED20", Offset = "0x3D2DD20", VA = "0x183D2ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct JCGLDKCNDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public MFGGDAIBFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B740", Offset = "0x3D2A740", VA = "0x183D2B740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class JEOGILEJFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JEOGILEJFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C610", Offset = "0x3D2B610", VA = "0x183D2C610")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class CFJHDFIKLAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CFJHDFIKLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x31EC690", Offset = "0x31EB690", VA = "0x1831EC690")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CJNGCMPENDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CJNGCMPENDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x31ED070", Offset = "0x31EC070", VA = "0x1831ED070")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class ACLMHNOIJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ACLMHNOIJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x31E8E70", Offset = "0x31E7E70", VA = "0x1831E8E70")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class FJGAMLJPKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public MFGGDAIBFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FJGAMLJPKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3D28640", Offset = "0x3D27640", VA = "0x183D28640")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class EEONLLIAFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public MFGGDAIBFBD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EEONLLIAFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x3D27330", Offset = "0x3D26330", VA = "0x183D27330")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly Guid NPOJMJHJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly NEJLBNOHIBA HBMFNJKGLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly BCJGNNLDEJN BGHPOAOGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly KLCONECFFJG GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly NAKPLBCDHEJ JHECPCMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool MJMNPICPNHL;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x26A90F0", Offset = "0x26A80F0", VA = "0x1826A90F0")]
	public MFGGDAIBFBD(NEJLBNOHIBA HMHJFDAOLEM, BCJGNNLDEJN BGHPOAOGGAA, KLCONECFFJG GNPHKIFHPOM, NAKPLBCDHEJ JHECPCMCJBH, NILMFDECOMH OIJDGGDGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x26A86F0", Offset = "0x26A76F0", VA = "0x1826A86F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x26A86F0", Offset = "0x26A76F0", VA = "0x1826A86F0")]
	public void MDLKOOHNKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x26A80E0", Offset = "0x26A70E0", VA = "0x1826A80E0")]
	public void BOLEDHNMFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x26A7DB0", Offset = "0x26A6DB0", VA = "0x1826A7DB0")]
	public void AJCKPPPOOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x26A8D20", Offset = "0x26A7D20", VA = "0x1826A8D20")]
	[AsyncStateMachine(typeof(IIPICPNJDCO))]
	internal Task<KNMGGFFPHPG> JJDNDAOFHOP(NILMFDECOMH OIJDGGDGOKN, KNMGGFFPHPG DNAOLLFBNEI, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x249A140", Offset = "0x2499140", VA = "0x18249A140")]
	private static byte[] BKOFBHGIBNC<T>(T LMLMHJKGDCH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x249A540", Offset = "0x2499540", VA = "0x18249A540")]
	private static T JBDGAKPPKHE<T>(MessageParser<T> NNJFKHHFNOO, byte[] LMLMHJKGDCH, T MPNBEECGANP) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x26A8BC0", Offset = "0x26A7BC0", VA = "0x1826A8BC0")]
	[AsyncStateMachine(typeof(MKGNAOAKLOK))]
	private Task<ADJLHAJLJIN> JEEBJCJFPBB(KNMGGFFPHPG DNAOLLFBNEI, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2499E60", Offset = "0x2498E60", VA = "0x182499E60")]
	[AsyncStateMachine(typeof(FOKGCDIDBIO))]
	internal Task<T> BJGGADPOFJL<T>(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task<T>> PHENNPFNDHM, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x26A7F90", Offset = "0x26A6F90", VA = "0x1826A7F90")]
	[AsyncStateMachine(typeof(JCGLDKCNDHG))]
	internal Task BJGGADPOFJL(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task> PHENNPFNDHM, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x26A7F00", Offset = "0x26A6F00", VA = "0x1826A7F00")]
	public KNMGGFFPHPG BAODALIKEMB(AEBLGFABLHE MLOKPBMJAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x26A8AF0", Offset = "0x26A7AF0", VA = "0x1826A8AF0")]
	public IIKNOLCOPFM HOCIFBGCHJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x26A8530", Offset = "0x26A7530", VA = "0x1826A8530")]
	public EPCKKLNKFPK DMFLGKCELII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x26A88C0", Offset = "0x26A78C0", VA = "0x1826A88C0")]
	public NOEICNIBFBG GALCNKEOBHC([Optional] FOGNFBPAHHI? MCAIOCMCMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x26A8890", Offset = "0x26A7890", VA = "0x1826A8890")]
	public void FEAABEONEJE(Func<Guid, bool> DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x26A7BD0", Offset = "0x26A6BD0", VA = "0x1826A7BD0")]
	public void AECPCPPONMH(Func<Guid, bool> JEPCAJNOPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x26A8EF0", Offset = "0x26A7EF0", VA = "0x1826A8EF0")]
	public void KNFPDNKCFDL(Func<Guid, bool> DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x26A79C0", Offset = "0x26A69C0", VA = "0x1826A79C0")]
	public Guid ABIBLGLHIEN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x26A8960", Offset = "0x26A7960", VA = "0x1826A8960")]
	public void GPOFBDIHLPM(Guid NEHFFLMLAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x26A85A0", Offset = "0x26A75A0", VA = "0x1826A85A0")]
	public void DNCMHJDKGAN(KNMGGFFPHPG JGFBMAGIGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x26A8230", Offset = "0x26A7230", VA = "0x1826A8230")]
	public void DHDJNBLMDNC(string CACKDOGDPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x26A83B0", Offset = "0x26A73B0", VA = "0x1826A83B0")]
	public void DHDJNBLMDNC(Func<string> HCMDEEFFOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x249A150", Offset = "0x2499150", VA = "0x18249A150")]
	private T FCKPDJDHJBJ<T>(T DFEOJBAFBHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x26A8EA0", Offset = "0x26A7EA0", VA = "0x1826A8EA0")]
	public void KLBAJAGACCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x249A230", Offset = "0x2499230", VA = "0x18249A230")]
	[CompilerGenerated]
	internal static string GBPFEGIMJGA<T>(byte[] CCFMJPPGPDK, int LJIMMNKDOFH, ref OPADGGGEPEE<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class JEFFFHAEEAK : NEJLBNOHIBA
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class IAOLGLFNHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IAOLGLFNHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x31F1EF0", Offset = "0x31F0EF0", VA = "0x1831F1EF0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct DHDJODBNAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public JEFFFHAEEAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private EPCKKLNKFPK <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x31EDB70", Offset = "0x31ECB70", VA = "0x1831EDB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class MGEGNIDNNDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public KJNKLCIDCEB presence;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MGEGNIDNNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x31F98E0", Offset = "0x31F88E0", VA = "0x1831F98E0")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly GDFDJMJJEPG KLENJIGINOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly JJPHLLGENAE PEKKMNLGGLN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private const bool KFPIICANJCG = false;

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x26A0C70", Offset = "0x269FC70", VA = "0x1826A0C70")]
	public JEFFFHAEEAK(GDFDJMJJEPG KLENJIGINOD, JJPHLLGENAE PEKKMNLGGLN, Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x26A0B20", Offset = "0x269FB20", VA = "0x1826A0B20", Slot = "8")]
	[AsyncStateMachine(typeof(DHDJODBNAGJ))]
	protected override Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x26A06F0", Offset = "0x269F6F0", VA = "0x1826A06F0")]
	private KJNKLCIDCEB GNOHBHGEPKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class PGBAAGAGOLE : NEJLBNOHIBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct NCDLDEMFIOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public PGBAAGAGOLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<IFFJPCNELHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F2D0", Offset = "0x3D2E2D0", VA = "0x183D2F2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly int IKAPMFIEKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly EIADPFDFDMD IIDEMCOOKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public readonly long ECJEJHCMFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public readonly long BNFGNAGFHDE;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IFFJPCNELHO HHAEGCFAACP
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x684D80", Offset = "0x683D80", VA = "0x180684D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x885B50", Offset = "0x884B50", VA = "0x180885B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E650", Offset = "0x2E6D650", VA = "0x182E6E650")]
	public PGBAAGAGOLE(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH, int IKAPMFIEKBO, EIADPFDFDMD IIDEMCOOKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E510", Offset = "0x2E6D510", VA = "0x182E6E510", Slot = "8")]
	[AsyncStateMachine(typeof(NCDLDEMFIOK))]
	protected override Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class KMGPFCHJHBI : NEJLBNOHIBA
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class EAHLPDAANND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public KMGPFCHJHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public GGDALNKLLGD playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EAHLPDAANND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x31EE020", Offset = "0x31ED020", VA = "0x1831EE020")]
		internal Task <RunAsync>b__0(NILMFDECOMH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x31EE060", Offset = "0x31ED060", VA = "0x1831EE060")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct JGJCBABFIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public KMGPFCHJHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private EAHLPDAANND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x31F3C80", Offset = "0x31F2C80", VA = "0x1831F3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct ECNGJHMMHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public GGDALNKLLGD playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public KMGPFCHJHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x31EE600", Offset = "0x31ED600", VA = "0x1831EE600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x26A4680", Offset = "0x26A3680", VA = "0x1826A4680")]
	public KMGPFCHJHBI(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH, string HKODEIINHCJ, KNBPMPDLLNP KJNNCDKFMMI, bool BCKDHLNOELN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x26A4530", Offset = "0x26A3530", VA = "0x1826A4530", Slot = "8")]
	[AsyncStateMachine(typeof(JGJCBABFIHH))]
	protected override Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task OKNEMLKDJHI(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x26A43D0", Offset = "0x26A33D0", VA = "0x1826A43D0")]
	[AsyncStateMachine(typeof(ECNGJHMMHIF))]
	private Task IEHCJEFEIDG(IDisposable BNNMPOPOJMG, GGDALNKLLGD EDODCIBPDMK, NILMFDECOMH JBAEFOFJALC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class AFAPMOKGDCL : NEJLBNOHIBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct LKPLFMCEDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public AFAPMOKGDCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<CFDCFBIAELJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2E62BD0", Offset = "0x2E61BD0", VA = "0x182E62BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly JCKPEGAFAPH MPBBMJKCHFP;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2687510", Offset = "0x2686510", VA = "0x182687510")]
	public AFAPMOKGDCL(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH, JCKPEGAFAPH MPBBMJKCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x26872F0", Offset = "0x26862F0", VA = "0x1826872F0", Slot = "7")]
	protected override string DAPNKDKBBFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x26873D0", Offset = "0x26863D0", VA = "0x1826873D0", Slot = "8")]
	[AsyncStateMachine(typeof(LKPLFMCEDNL))]
	protected override Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal abstract class NEJLBNOHIBA : PENMGOCJCDO
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task DFIFONNILMA(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class LFLFGHBNKAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public NILMFDECOMH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public NEJLBNOHIBA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LFLFGHBNKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DA60", Offset = "0x3D2CA60", VA = "0x183D2DA60")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class HJDALLHHMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public LFLFGHBNKAK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HJDALLHHMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A6C0", Offset = "0x3D296C0", VA = "0x183D2A6C0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A780", Offset = "0x3D29780", VA = "0x183D2A780")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct GBJFBLIBLLJ : IAsyncStateMachine
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
		public NEJLBNOHIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<NEJLBNOHIBA, NILMFDECOMH, MFGGDAIBFBD> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private LFLFGHBNKAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private MFGGDAIBFBD <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x3D288C0", Offset = "0x3D278C0", VA = "0x183D288C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct OJLNOKOFKCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public NEJLBNOHIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x3D30670", Offset = "0x3D2F670", VA = "0x183D30670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public readonly Guid MONMFFCHOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public readonly ByteString NPJMCJALIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly DGAJACEMLNI GHJAPLCFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	protected readonly string AIGDHFGDALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly bool BCKDHLNOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly Queue<DFIFONNILMA> DNHIHDGAJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly ACHCIGHCIHA HIKGFJMKMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly KNBPMPDLLNP KJNNCDKFMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private bool BEGKDNFDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public MLAKGLIELEE OIHDEJEGCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public MLAKGLIELEE NPAEANIAAKJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AMHDFPELFBK NLHPHNNMALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2E65DF0", Offset = "0x2E64DF0", VA = "0x182E65DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KBLLFAOCCDI KLDGFMLAEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2E65CC0", Offset = "0x2E64CC0", VA = "0x182E65CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2E65720", Offset = "0x2E64720", VA = "0x182E65720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2E65E40", Offset = "0x2E64E40", VA = "0x182E65E40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2E65F70", Offset = "0x2E64F70", VA = "0x182E65F70", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2E657A0", Offset = "0x2E647A0", VA = "0x182E657A0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2E65FF0", Offset = "0x2E64FF0", VA = "0x182E65FF0")]
	protected NEJLBNOHIBA(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH, string HKODEIINHCJ, KNBPMPDLLNP KJNNCDKFMMI, bool BCKDHLNOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2E65AF0", Offset = "0x2E64AF0", VA = "0x182E65AF0", Slot = "7")]
	protected virtual string DAPNKDKBBFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2E65F90", Offset = "0x2E64F90", VA = "0x182E65F90")]
	public void NBPNGGIMKLO(DFIFONNILMA JDIKKADHENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2E65980", Offset = "0x2E64980", VA = "0x182E65980")]
	protected void BBHLLDIGNGC(float ONINKGDNEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2E659A0", Offset = "0x2E649A0", VA = "0x182E659A0")]
	[AsyncStateMachine(typeof(GBJFBLIBLLJ))]
	public Task CAIEIEJFFKG(CancellationToken NIEOBBGKEFJ, NILMFDECOMH OIJDGGDGOKN, [Optional] Func<NEJLBNOHIBA, NILMFDECOMH, MFGGDAIBFBD> GMDPIHDKAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2E65B30", Offset = "0x2E64B30", VA = "0x182E65B30")]
	private void DNHDPHDCFEJ(bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2E65E60", Offset = "0x2E64E60", VA = "0x182E65E60")]
	private void HFIGDEEKALP(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2E657C0", Offset = "0x2E647C0", VA = "0x182E657C0")]
	[AsyncStateMachine(typeof(OJLNOKOFKCM))]
	private Task ANOGNHAJEJG(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2E65900", Offset = "0x2E64900", VA = "0x182E65900")]
	public KNMGGFFPHPG BAODALIKEMB(AEBLGFABLHE MLOKPBMJAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2E65D10", Offset = "0x2E64D10", VA = "0x182E65D10")]
	[CompilerGenerated]
	private Task FHJFBDDMFGA(CancellationToken PHLICBNKKOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal sealed class JJAMLJIIKAH : KMGPFCHJHBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct ANMOFCMINAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public JJAMLJIIKAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private GDHGOFCBJHF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private EPCKKLNKFPK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x31EA0C0", Offset = "0x31E90C0", VA = "0x1831EA0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly GDFDJMJJEPG BIHINLHEMNK;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x26A11D0", Offset = "0x26A01D0", VA = "0x1826A11D0")]
	public JJAMLJIIKAH(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, GDFDJMJJEPG BIHINLHEMNK, DGAJACEMLNI NDFNDDNACCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x26A1080", Offset = "0x26A0080", VA = "0x1826A1080", Slot = "9")]
	[AsyncStateMachine(typeof(ANMOFCMINAE))]
	protected override Task OKNEMLKDJHI(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class PBDAHOFIJJE : NEJLBNOHIBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct PJEEBJGPFCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public PBDAHOFIJJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter<CFDCFBIAELJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3D30D00", Offset = "0x3D2FD00", VA = "0x183D30D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly string HKKKPKNHAPK;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C7B0", Offset = "0x2E6B7B0", VA = "0x182E6C7B0")]
	public PBDAHOFIJJE(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, DGAJACEMLNI NDFNDDNACCH, string HKKKPKNHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C680", Offset = "0x2E6B680", VA = "0x182E6C680", Slot = "8")]
	[AsyncStateMachine(typeof(PJEEBJGPFCI))]
	protected override Task JKFLOEEHJJL(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class PNBOOPCNDPF : KMGPFCHJHBI
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class DCLDKIJLFPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public DCLDKIJLFPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private TaskAwaiter<CFDCFBIAELJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter<KNMGGFFPHPG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x3D34830", Offset = "0x3D33830", VA = "0x183D34830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x3D34B80", Offset = "0x3D33B80", VA = "0x183D34B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public PNBOOPCNDPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public NOEICNIBFBG serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public IIKNOLCOPFM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DCLDKIJLFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3D26CF0", Offset = "0x3D25CF0", VA = "0x183D26CF0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KNMGGFFPHPG> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct PNMIMPGEFJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public PNBOOPCNDPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DCLDKIJLFPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private GDHGOFCBJHF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EPCKKLNKFPK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x3D31020", Offset = "0x3D30020", VA = "0x183D31020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly int CEGPOGLBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[CanBeNull]
	private readonly GAGKBGGCBLG MDMHKOKPKAA;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2E71830", Offset = "0x2E70830", VA = "0x182E71830")]
	public PNBOOPCNDPF(Guid MHGELGNLCHI, AMHDFPELFBK POBEANPIGDE, int CEGPOGLBCHA, GAGKBGGCBLG MDMHKOKPKAA, DGAJACEMLNI NDFNDDNACCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2E716D0", Offset = "0x2E706D0", VA = "0x182E716D0", Slot = "9")]
	[AsyncStateMachine(typeof(PNMIMPGEFJE))]
	protected override Task OKNEMLKDJHI(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x2E715E0", Offset = "0x2E705E0", VA = "0x182E715E0")]
	private void HKHBBJDDOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2E71440", Offset = "0x2E70440", VA = "0x182E71440")]
	private void CJOFJKKGCOB(NILMFDECOMH OIJDGGDGOKN, GDHGOFCBJHF PBPFPGHNJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal abstract class OMELJEKBDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly NEJLBNOHIBA HBMFNJKGLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public readonly MFGGDAIBFBD GCKDNBGGGLO;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2E6AF90", Offset = "0x2E69F90", VA = "0x182E6AF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2E6AEC0", Offset = "0x2E69EC0", VA = "0x182E6AEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AFE0", Offset = "0x2E69FE0", VA = "0x182E6AFE0")]
	protected OMELJEKBDMF(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AF50", Offset = "0x2E69F50", VA = "0x182E6AF50")]
	protected void DHDJNBLMDNC(string CACKDOGDPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AF70", Offset = "0x2E69F70", VA = "0x182E6AF70")]
	public void DHDJNBLMDNC(Func<string> HCMDEEFFOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct EGPCABDFBPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public Dictionary<Guid, List<ALIGMBLCLJO>> AKCDABOBKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public Dictionary<Guid, List<ALIGMBLCLJO>> OCALOGOJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<ALIGMBLCLJO>> JBBGFLFIILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public List<Guid> APBNEFOALOD;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2691600", Offset = "0x2690600", VA = "0x182691600")]
	public static EGPCABDFBPF CIGAFCHFFML(KPENDAEOIAB ACNDHAIKGGB, MLAKGLIELEE AGKNBBFDEAN, MMIGNNJDMKB HIPDCGPBJBN)
	{
		return default(EGPCABDFBPF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct NLNHCIPELCE
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00")]
	public static NLNHCIPELCE HJNGNBALKKN()
	{
		return default(NLNHCIPELCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GPPKJDJKLMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GGCAMLKPBJI(MMIGNNJDMKB FILAKGLBGGA, object BAKMJFIKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GFFJMALFDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct NDNNICHHGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly HIEMHHFNKEP LDFKNCALKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly MFFGBJPFPEF CKOJFPHLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly DENPKHNFBIE PJOJLPDBEPN;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2E656D0", Offset = "0x2E646D0", VA = "0x182E656D0")]
	public NDNNICHHGLJ(HIEMHHFNKEP LDFKNCALKNJ, MFFGBJPFPEF CKOJFPHLFJK, DENPKHNFBIE PJOJLPDBEPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct ECAGHIFJDOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private readonly MFGGDAIBFBD HICGCFFCGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private readonly Guid NEHFFLMLAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private bool CDAAFMCMHEH;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2690FC0", Offset = "0x268FFC0", VA = "0x182690FC0")]
	public static ECAGHIFJDOK ABIBLGLHIEN(MFGGDAIBFBD HICGCFFCGJC)
	{
		return default(ECAGHIFJDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1318B20", Offset = "0x1317B20", VA = "0x181318B20")]
	public void KADPFJIDOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x26910A0", Offset = "0x26900A0", VA = "0x1826910A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x26913E0", Offset = "0x26903E0", VA = "0x1826913E0")]
	private ECAGHIFJDOK(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x26910B0", Offset = "0x26900B0", VA = "0x1826910B0")]
	private void GPOFBDIHLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2690FF0", Offset = "0x268FFF0", VA = "0x182690FF0")]
	private Func<Guid, bool> BCMEJBJLMOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class EPCKKLNKFPK : OMELJEKBDMF, PENMGOCJCDO
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public delegate Task<MLAKGLIELEE> FNENGBNOFIB(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF NACGHOKJHAP, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct OCBFBPMJGKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public GDFDJMJJEPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private ECAGHIFJDOK <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2E69510", Offset = "0x2E68510", VA = "0x182E69510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct DNCAFLBADOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public GDFDJMJJEPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private NILMFDECOMH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E5C6A0", Offset = "0x2E5B6A0", VA = "0x182E5C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2E5C9C0", Offset = "0x2E5B9C0", VA = "0x182E5C9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct PACDBMBDMPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public GDFDJMJJEPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private NILMFDECOMH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E6C420", Offset = "0x2E6B420", VA = "0x182E6C420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class EFOLDOJDOCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public AsyncTaskMethodBuilder<NDNNICHHGLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public EFOLDOJDOCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private NDNNICHHGLJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<MLAKGLIELEE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<NDNNICHHGLJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x3D33580", Offset = "0x3D32580", VA = "0x183D33580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x3D33B90", Offset = "0x3D32B90", VA = "0x183D33B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public AsyncTaskMethodBuilder<MMIGNNJDMKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public EFOLDOJDOCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private MMIGNNJDMKB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<MLAKGLIELEE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private TaskAwaiter<MMIGNNJDMKB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x3D33BE0", Offset = "0x3D32BE0", VA = "0x183D33BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3D34110", Offset = "0x3D33110", VA = "0x183D34110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public EFOLDOJDOCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private bool <reloadSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private TaskAwaiter<MLAKGLIELEE> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private HAAEHEGPGPF <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x3D32170", Offset = "0x3D31170", VA = "0x183D32170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public GDFDJMJJEPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public ACHCIGHCIHA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public ACHCIGHCIHA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public NDNNICHHGLJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ACHCIGHCIHA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public MMIGNNJDMKB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public DBEEPMIJCMI.CNMIEGAELBL <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EFOLDOJDOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CB40", Offset = "0x2E5BB40", VA = "0x182E5CB40")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<NDNNICHHGLJ> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CC80", Offset = "0x2E5BC80", VA = "0x182E5CC80")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MMIGNNJDMKB> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CDC0", Offset = "0x2E5BDC0", VA = "0x182E5CDC0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CA10", Offset = "0x2E5BA10", VA = "0x182E5CA10")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct KCAFOIMEDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public GDFDJMJJEPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private EFOLDOJDOCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<NDNNICHHGLJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter<MMIGNNJDMKB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2E61FC0", Offset = "0x2E60FC0", VA = "0x182E61FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct CEBDGAFBEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x2E5C080", Offset = "0x2E5B080", VA = "0x182E5C080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct MNKHDNEAABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private NILMFDECOMH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E64910", Offset = "0x2E63910", VA = "0x182E64910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct LODALBLBLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private NILMFDECOMH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E632F0", Offset = "0x2E622F0", VA = "0x182E632F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E63D90", Offset = "0x2E62D90", VA = "0x182E63D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct BOPGNJOBLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private NILMFDECOMH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E5AF30", Offset = "0x2E59F30", VA = "0x182E5AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x2E5BAE0", Offset = "0x2E5AAE0", VA = "0x182E5BAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct IKHNOIHNCCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public MLAKGLIELEE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public MMIGNNJDMKB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E5FD40", Offset = "0x2E5ED40", VA = "0x182E5FD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E5FF30", Offset = "0x2E5EF30", VA = "0x182E5FF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class EMPMPPJJLMA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public EMPMPPJJLMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<MLAKGLIELEE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x3D34160", Offset = "0x3D33160", VA = "0x183D34160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x3D346A0", Offset = "0x3D336A0", VA = "0x183D346A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public FNENGBNOFIB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public MLAKGLIELEE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EMPMPPJJLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E5D0C0", Offset = "0x2E5C0C0", VA = "0x182E5D0C0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MLAKGLIELEE> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct PFKLEAFPBPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public FNENGBNOFIB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E6DA00", Offset = "0x2E6CA00", VA = "0x182E6DA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E6DEA0", Offset = "0x2E6CEA0", VA = "0x182E6DEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct JEJCBFKGJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public ACHCIGHCIHA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private MLAKGLIELEE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private IEnumerator<MLAKGLIELEE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E604E0", Offset = "0x2E5F4E0", VA = "0x182E604E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NFHGBIHMOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E66130", Offset = "0x2E65130", VA = "0x182E66130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FJKEBMHIOIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AMHDFPELFBK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E5DF60", Offset = "0x2E5CF60", VA = "0x182E5DF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GKNHBOCMNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public EPCKKLNKFPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E5EE10", Offset = "0x2E5DE10", VA = "0x182E5EE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class IHHAKINEKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public HIEMHHFNKEP roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IHHAKINEKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E5FAB0", Offset = "0x2E5EAB0", VA = "0x182E5FAB0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly HPDGKDBFFPK NPPICHAEJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly HPDGKDBFFPK JBHGGNBNNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly EAPCBILCKLG HECOGALPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly IOPLLKNKNGM NCELCCPHMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly NKIBJCJMACG ELFNEDHEOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly CGCFOACLBLD PDACKAGGHCM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2692E70", Offset = "0x2691E70", VA = "0x182692E70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private AMHDFPELFBK NLHPHNNMALF
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2692B90", Offset = "0x2691B90", VA = "0x182692B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2693030", Offset = "0x2692030", VA = "0x182693030", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2692270", Offset = "0x2691270", VA = "0x182692270", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2694110", Offset = "0x2693110", VA = "0x182694110")]
	public EPCKKLNKFPK(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2692880", Offset = "0x2691880", VA = "0x182692880")]
	[AsyncStateMachine(typeof(OCBFBPMJGKG))]
	public Task EIHKNEONEPI(GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, bool CLPKIDEIOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x26920F0", Offset = "0x26910F0", VA = "0x1826920F0")]
	[AsyncStateMachine(typeof(DNCAFLBADOO))]
	private Task<KNMGGFFPHPG> AEEFBADOJDM(GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x26931B0", Offset = "0x26921B0", VA = "0x1826931B0")]
	[AsyncStateMachine(typeof(PACDBMBDMPB))]
	private Task HGGEHGHKBOM(GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, bool CLPKIDEIOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2693700", Offset = "0x2692700", VA = "0x182693700")]
	[AsyncStateMachine(typeof(KCAFOIMEDFJ))]
	private Task LBPHIBGHJFF(GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH OIJDGGDGOKN, CancellationToken GLBGFKBONLI, bool CLPKIDEIOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2693CA0", Offset = "0x2692CA0", VA = "0x182693CA0")]
	[AsyncStateMachine(typeof(CEBDGAFBEAG))]
	private Task MDLCAKLONDA(NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2692290", Offset = "0x2691290", VA = "0x182692290")]
	[AsyncStateMachine(typeof(MNKHDNEAABM))]
	private Task AMHMFGCHMHG(MMIGNNJDMKB FILAKGLBGGA, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x26925A0", Offset = "0x26915A0", VA = "0x1826925A0")]
	[AsyncStateMachine(typeof(LODALBLBLDP))]
	private Task<MLAKGLIELEE> CNNBDDMNCHC(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2692E90", Offset = "0x2691E90", VA = "0x182692E90")]
	[AsyncStateMachine(typeof(BOPGNJOBLNI))]
	private Task<MLAKGLIELEE> HBADJFDBJON(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x26939B0", Offset = "0x26929B0", VA = "0x1826939B0")]
	[AsyncStateMachine(typeof(IKHNOIHNCCH))]
	private Task<MLAKGLIELEE> LLLBLPBMIBB(MLAKGLIELEE AGKNBBFDEAN, MMIGNNJDMKB HIPDCGPBJBN, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, bool FHOPFOFLBIC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2693460", Offset = "0x2692460", VA = "0x182693460")]
	private bool JAJKGIEPOAG(MMIGNNJDMKB JBGOADOMDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x26923F0", Offset = "0x26913F0", VA = "0x1826923F0")]
	[AsyncStateMachine(typeof(PFKLEAFPBPA))]
	protected Task<MLAKGLIELEE> APAAKOAKGBC(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, FNENGBNOFIB JKAMHFCLDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2692D10", Offset = "0x2691D10", VA = "0x182692D10")]
	[AsyncStateMachine(typeof(JEJCBFKGJIO))]
	private Task GLEBDOOKEIL(MMIGNNJDMKB FILAKGLBGGA, ACHCIGHCIHA HELHJOLCACD, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x26929E0", Offset = "0x26919E0", VA = "0x1826929E0")]
	private void EINCEMPHBMP(MLAKGLIELEE CHELLHNMPGA, ACHCIGHCIHA HELHJOLCACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2693EF0", Offset = "0x2692EF0", VA = "0x182693EF0")]
	private void NBMMAMFJHJA(MLAKGLIELEE JCABIBECLKD, out MLAKGLIELEE IOIIOEAMMAK, out MLAKGLIELEE IFMELOJBHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x26940D0", Offset = "0x26930D0", VA = "0x1826940D0")]
	private Task<NDNNICHHGLJ> PHMDJCNMFFC(GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2694080", Offset = "0x2693080", VA = "0x182694080")]
	private Task<MMIGNNJDMKB> PBMGLPCCBLK(GDFDJMJJEPG KJACHHOOFKC, NDNNICHHGLJ FILAKGLBGGA, DBEEPMIJCMI.CNMIEGAELBL GEFHKKPHINB, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2692BC0", Offset = "0x2691BC0", VA = "0x182692BC0")]
	[AsyncStateMachine(typeof(NFHGBIHMOEK))]
	private Task GKCJEONBNOG(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2693860", Offset = "0x2692860", VA = "0x182693860")]
	[AsyncStateMachine(typeof(FJKEBMHIOIH))]
	private Task LGCAOFMJAFP(MMIGNNJDMKB FILAKGLBGGA, AMHDFPELFBK POBEANPIGDE, NILMFDECOMH OIJDGGDGOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2693DD0", Offset = "0x2692DD0", VA = "0x182693DD0")]
	[AsyncStateMachine(typeof(GKNHBOCMNOB))]
	private Task MNDLNLCIKIJ(MMIGNNJDMKB FILAKGLBGGA, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2693B40", Offset = "0x2692B40", VA = "0x182693B40")]
	private Task LNLLGABPNMJ(MMIGNNJDMKB FILAKGLBGGA, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2693050", Offset = "0x2692050", VA = "0x182693050")]
	private Task HFOLFLNLMIG(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2693310", Offset = "0x2692310", VA = "0x182693310")]
	private Task IINFMEFCHJA(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2693590", Offset = "0x2692590", VA = "0x182693590")]
	private Task KJBJADBNPAP(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2693580", Offset = "0x2692580", VA = "0x182693580")]
	private static Task KCIGNEGPKKI(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2692A30", Offset = "0x2691A30", VA = "0x182692A30")]
	private Task FJJALAHJJJH(MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2693F30", Offset = "0x2692F30", VA = "0x182693F30")]
	private Task OFKJDIMACIM(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2693550", Offset = "0x2692550", VA = "0x182693550")]
	private void JNADJOAOAFI(GDFDJMJJEPG KJACHHOOFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2692720", Offset = "0x2691720", VA = "0x182692720")]
	private static void EGHBFBIBECE(HIEMHHFNKEP LDFKNCALKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct PNHJHJHJMMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private MLAKGLIELEE CHELLHNMPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private MMIGNNJDMKB FILAKGLBGGA;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E71C60", Offset = "0x2E70C60", VA = "0x182E71C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E718E0", Offset = "0x2E708E0", VA = "0x182E718E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E71960", Offset = "0x2E70960", VA = "0x182E71960")]
	public static Task CAIEIEJFFKG(AMHDFPELFBK POBEANPIGDE, MLAKGLIELEE CHELLHNMPGA, MMIGNNJDMKB FILAKGLBGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E71A10", Offset = "0x2E70A10", VA = "0x182E71A10")]
	private void CAIEIEJFFKG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct PJGFBOAELOF
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F120", Offset = "0x2E6E120", VA = "0x182E6F120")]
	public static Task CAIEIEJFFKG(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct IMDJKEEHCJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct MDPKFKOKBOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private NILMFDECOMH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x31F9140", Offset = "0x31F8140", VA = "0x1831F9140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x269DC30", Offset = "0x269CC30", VA = "0x18269DC30")]
	[AsyncStateMachine(typeof(MDPKFKOKBOD))]
	public static Task CAIEIEJFFKG(MFGGDAIBFBD HICGCFFCGJC, MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct KOKCNBAKCHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct HOJBCBJPGLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private MLAKGLIELEE <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private AMHDFPELFBK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private KPENDAEOIAB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private List<(PersistenceView, EPAMCLOEEBK)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private EPAMCLOEEBK <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x31F1700", Offset = "0x31F0700", VA = "0x1831F1700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26A4B30", Offset = "0x26A3B30", VA = "0x1826A4B30")]
	[AsyncStateMachine(typeof(HOJBCBJPGLP))]
	public static Task CAIEIEJFFKG(MFGGDAIBFBD HICGCFFCGJC, MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x26A4CA0", Offset = "0x26A3CA0", VA = "0x1826A4CA0")]
	private static void DAGNCIOPNME(PersistenceView JENEHFPKFDC, EPAMCLOEEBK BAKMJFIKFPC, MMIGNNJDMKB FILAKGLBGGA, MLAKGLIELEE AGKNBBFDEAN, bool KPAGMOEIGLK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct BGEKOIEFLAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NACCDHPHKLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AMHDFPELFBK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E65290", Offset = "0x2E64290", VA = "0x182E65290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x268DCB0", Offset = "0x268CCB0", VA = "0x18268DCB0")]
	[AsyncStateMachine(typeof(NACCDHPHKLE))]
	public static Task CAIEIEJFFKG(AMHDFPELFBK POBEANPIGDE, MMIGNNJDMKB FILAKGLBGGA, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct MMIGFOBFIOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct IPDCMGABBIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AMHDFPELFBK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B4C0", Offset = "0x3D2A4C0", VA = "0x183D2B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct FHNGKIPEHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public MMIGFOBFIOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D27C10", Offset = "0x3D26C10", VA = "0x183D27C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class FIEFGKKBPHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GMDPNKPCIHK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FIEFGKKBPHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3D284B0", Offset = "0x3D274B0", VA = "0x183D284B0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3D28590", Offset = "0x3D27590", VA = "0x183D28590")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private MMIGNNJDMKB FILAKGLBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private MFGGDAIBFBD HICGCFFCGJC;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private static readonly ByteString AEFEDDLEPAO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E641A0", Offset = "0x2E631A0", VA = "0x182E641A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private CCAPIFGDDLC PBCOOOFJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E63E50", Offset = "0x2E62E50", VA = "0x182E63E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E64010", Offset = "0x2E63010", VA = "0x182E64010")]
	[AsyncStateMachine(typeof(IPDCMGABBIA))]
	public static Task CAIEIEJFFKG(AMHDFPELFBK POBEANPIGDE, MLAKGLIELEE CHELLHNMPGA, MMIGNNJDMKB FILAKGLBGGA, MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E63ED0", Offset = "0x2E62ED0", VA = "0x182E63ED0")]
	[AsyncStateMachine(typeof(FHNGKIPEHHC))]
	private Task CAIEIEJFFKG(NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E641F0", Offset = "0x2E631F0", VA = "0x182E641F0")]
	private void MEMFBMPFHAJ([NotNull] DOJAMBMLNII KBIIDELJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E64170", Offset = "0x2E63170", VA = "0x182E64170")]
	private bool CEIGHCEGIBA(GMDPNKPCIHK IIJDDKBOPLN, DOJAMBMLNII KBIIDELJIDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct PMIOGIAGFKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct CGADIAEJHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AsyncTaskMethodBuilder<MMIGNNJDMKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public PMIOGIAGFKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public DBEEPMIJCMI.CNMIEGAELBL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private NILMFDECOMH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private TaskAwaiter<(global::CIOEKKBILIB<MOIFEMAHELI, AAHLPJGCFPM>, global::CIOEKKBILIB<global::OOPICKNMODO<DOJAMBMLNII>, AAHLPJGCFPM>, global::CIOEKKBILIB<global::OOPICKNMODO<EEANAGPKBOF>, AAHLPJGCFPM>, global::CIOEKKBILIB<global::OOPICKNMODO<CPPNEHBPDEC>, AAHLPJGCFPM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3D261B0", Offset = "0x3D251B0", VA = "0x183D261B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A70", Offset = "0x3D25A70", VA = "0x183D26A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct AOLBHOFMNLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<MOIFEMAHELI, AAHLPJGCFPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public NILMFDECOMH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public PMIOGIAGFKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public DBEEPMIJCMI.CNMIEGAELBL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private NILMFDECOMH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<global::CIOEKKBILIB<MOIFEMAHELI, AAHLPJGCFPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3D251F0", Offset = "0x3D241F0", VA = "0x183D251F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3D256E0", Offset = "0x3D246E0", VA = "0x183D256E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private global::ENPIOIJAIHA<INLAJELACMH, EEANAGPKBOF> JMHKAPODEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private global::ENPIOIJAIHA<INLAJELACMH, DOJAMBMLNII> CKOJFPHLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private global::ENPIOIJAIHA<long, CPPNEHBPDEC> JHDMLOHBFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private JENLCEMCKKM GIBAMEDHPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private GDFDJMJJEPG KJACHHOOFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private HIEMHHFNKEP LDFKNCALKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private MFFGBJPFPEF JEEAHIFEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private long CPIEIKFMDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private NILMFDECOMH JBAEFOFJALC;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2E709B0", Offset = "0x2E6F9B0", VA = "0x182E709B0")]
	public static Task<MMIGNNJDMKB> FJDLFGOMLOH(AMHDFPELFBK POBEANPIGDE, GDFDJMJJEPG KJACHHOOFKC, in NDNNICHHGLJ FILAKGLBGGA, DBEEPMIJCMI.CNMIEGAELBL GEFHKKPHINB, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2E70840", Offset = "0x2E6F840", VA = "0x182E70840")]
	[AsyncStateMachine(typeof(CGADIAEJHGD))]
	private Task<MMIGNNJDMKB> CAIEIEJFFKG(DBEEPMIJCMI.CNMIEGAELBL GEFHKKPHINB, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2E70E20", Offset = "0x2E6FE20", VA = "0x182E70E20")]
	private INLAJELACMH GNCNGCOCOBN(LCOCAOICAJN CLAOGJNMEBM)
	{
		return default(INLAJELACMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2E70C70", Offset = "0x2E6FC70", VA = "0x182E70C70")]
	[AsyncStateMachine(typeof(AOLBHOFMNLL))]
	private Task<global::CIOEKKBILIB<MOIFEMAHELI, AAHLPJGCFPM>> FKPLIPOHGHC(string GHOHBGIEHPJ, long CPIEIKFMDCD, DBEEPMIJCMI.CNMIEGAELBL GEFHKKPHINB, NILMFDECOMH FELDFPPGJHG, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct KCBKFDNFEIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct INMOBMNKHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<NDNNICHHGLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public KCBKFDNFEIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private NILMFDECOMH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter<NDNNICHHGLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x31F2630", Offset = "0x31F1630", VA = "0x1831F2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x31F2AE0", Offset = "0x31F1AE0", VA = "0x1831F2AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CMJAAINOOKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder<NDNNICHHGLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public KCBKFDNFEIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter<NDNNICHHGLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x31ED0E0", Offset = "0x31EC0E0", VA = "0x1831ED0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x31ED2D0", Offset = "0x31EC2D0", VA = "0x1831ED2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class AEBJJPFGDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AEBJJPFGDGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x126AA80", Offset = "0x1269A80", VA = "0x18126AA80")]
		internal bool <FetchRoomDetails>b__0(MFFGBJPFPEF sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct JFFJMIHOCOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder<NDNNICHHGLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public KPENDAEOIAB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private AEBJJPFGDGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private TaskAwaiter<HIEMHHFNKEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x31F3690", Offset = "0x31F2690", VA = "0x1831F3690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x31F3BD0", Offset = "0x31F2BD0", VA = "0x1831F3BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EAPCBILCKLG HECOGALPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private NILMFDECOMH JBAEFOFJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private long KPBGCMCAECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private long PFEOAIPJFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private string JANCCCAJCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private INLAJELACMH ICEEOGNDBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private INLAJELACMH LKAPNEFHNEJ;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26A2A40", Offset = "0x26A1A40", VA = "0x1826A2A40")]
	public static Task<NDNNICHHGLJ> FJDLFGOMLOH(AMHDFPELFBK POBEANPIGDE, GDFDJMJJEPG KJACHHOOFKC, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26A27D0", Offset = "0x26A17D0", VA = "0x1826A27D0")]
	[AsyncStateMachine(typeof(INMOBMNKHFB))]
	private Task<NDNNICHHGLJ> CAIEIEJFFKG(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26A3160", Offset = "0x26A2160", VA = "0x1826A3160")]
	[AsyncStateMachine(typeof(CMJAAINOOKI))]
	private Task<NDNNICHHGLJ> PHMDJCNMFFC(long KPBGCMCAECK, long PFEOAIPJFFN, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, bool HJFAPMCENBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x26A2FE0", Offset = "0x26A1FE0", VA = "0x1826A2FE0")]
	[AsyncStateMachine(typeof(JFFJMIHOCOD))]
	public static Task<NDNNICHHGLJ> PHMDJCNMFFC(KPENDAEOIAB ACNDHAIKGGB, long KPBGCMCAECK, long PFEOAIPJFFN, CancellationToken NIEOBBGKEFJ, NILMFDECOMH OIJDGGDGOKN, bool HJFAPMCENBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26A2930", Offset = "0x26A1930", VA = "0x1826A2930")]
	private void FGKCKIPEAPA(HIEMHHFNKEP LDFKNCALKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x26A2CD0", Offset = "0x26A1CD0", VA = "0x1826A2CD0")]
	private bool IANPBMHGEMC(NDNNICHHGLJ FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x26A2E40", Offset = "0x26A1E40", VA = "0x1826A2E40")]
	private void PCEFEMPMFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct APGNBNPMJCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct HCJAEBBGHCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public APGNBNPMJCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2E5F070", Offset = "0x2E5E070", VA = "0x182E5F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private const int OOBKIGABKMC = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private const float IFCGLAKHGII = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private KPENDAEOIAB ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private MMIGNNJDMKB FILAKGLBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private NILMFDECOMH JBAEFOFJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private float GODDJFGHCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private float OCCMAACGMMB;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x268DB10", Offset = "0x268CB10", VA = "0x18268DB10")]
	public static Task NKFCGNHKJPL(AMHDFPELFBK POBEANPIGDE, MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x268D590", Offset = "0x268C590", VA = "0x18268D590")]
	[AsyncStateMachine(typeof(HCJAEBBGHCA))]
	public Task CAIEIEJFFKG(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x268D950", Offset = "0x268C950", VA = "0x18268D950")]
	private static void JNJLGNLKDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x268D780", Offset = "0x268C780", VA = "0x18268D780")]
	private void JKFNOJKMDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x268D6C0", Offset = "0x268C6C0", VA = "0x18268D6C0")]
	private static float GMHFLOGOFJI(KPENDAEOIAB ACNDHAIKGGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x268DAF0", Offset = "0x268CAF0", VA = "0x18268DAF0")]
	private static float MNPCHGIGBJI()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct HJOGOELIFHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct BOKPGOCJEGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public MFGGDAIBFBD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private NEJLBNOHIBA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private AMHDFPELFBK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private HPNIPMEMLKB.KHKHNNMJIJG <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x31EB950", Offset = "0x31EA950", VA = "0x1831EB950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct HKBCKMGDLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private PNCIKFNGDFC.LBECLGBAAHA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x31F1450", Offset = "0x31F0450", VA = "0x1831F1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x269B1C0", Offset = "0x269A1C0", VA = "0x18269B1C0")]
	[AsyncStateMachine(typeof(BOKPGOCJEGK))]
	public static Task CAIEIEJFFKG(MFGGDAIBFBD HICGCFFCGJC, MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x269B3F0", Offset = "0x269A3F0", VA = "0x18269B3F0")]
	private static Task<KNMGGFFPHPG> MCCKILKNOHN(MFGGDAIBFBD HICGCFFCGJC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x269B320", Offset = "0x269A320", VA = "0x18269B320")]
	[AsyncStateMachine(typeof(HKBCKMGDLOM))]
	private static Task JDLOIJNDOKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct GKEPIANMEBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct JCPMOIIBCFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public GKEPIANMEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x31F30F0", Offset = "0x31F20F0", VA = "0x1831F30F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class CAHMOIPNGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CAHMOIPNGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x31EC610", Offset = "0x31EB610", VA = "0x1831EC610")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct CGAAFFKOFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public GKEPIANMEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private IBMDLIPNHOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x31EC6F0", Offset = "0x31EB6F0", VA = "0x1831EC6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private bool PHPPDKMMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private NILMFDECOMH JBAEFOFJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private CancellationToken NIEOBBGKEFJ;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x269A210", Offset = "0x2699210", VA = "0x18269A210")]
	public static Task KBHEAKBGDCE(AMHDFPELFBK POBEANPIGDE, bool PHPPDKMMLGO, NILMFDECOMH JBAEFOFJALC, CancellationToken JECEKMIFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x269A100", Offset = "0x2699100", VA = "0x18269A100")]
	[AsyncStateMachine(typeof(JCPMOIIBCFJ))]
	private Task CAIEIEJFFKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2699FD0", Offset = "0x2698FD0", VA = "0x182699FD0")]
	[AsyncStateMachine(typeof(CGAAFFKOFEA))]
	private Task BAGMIKJBBAB(bool DCPIBGCPNCJ, string PPPHPNPKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00")]
	private bool MHFEAGCBHDH(bool PHPPDKMMLGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct KNMKPOONEFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct LPCMNHNKDBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public KNMKPOONEFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x31F88A0", Offset = "0x31F78A0", VA = "0x1831F88A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x31F8CF0", Offset = "0x31F7CF0", VA = "0x1831F8CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class EDJEHDPADBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EDJEHDPADBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x31EEAC0", Offset = "0x31EDAC0", VA = "0x1831EEAC0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct BHCIMJELDHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public KNMKPOONEFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private IBMDLIPNHOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x31EB120", Offset = "0x31EA120", VA = "0x1831EB120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x31EB600", Offset = "0x31EA600", VA = "0x1831EB600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private DENPKHNFBIE MIEAECDGGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NILMFDECOMH JBAEFOFJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private bool MLHJLBMIGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private MMIGNNJDMKB FILAKGLBGGA;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x26A4960", Offset = "0x26A3960", VA = "0x1826A4960")]
	public static Task<Scene> MGINHBEAHMI(AMHDFPELFBK POBEANPIGDE, DENPKHNFBIE HEKFPKBGNGO, NILMFDECOMH JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x26A49E0", Offset = "0x26A39E0", VA = "0x1826A49E0")]
	public static Task<Scene> NHCJBLKKBNL(AMHDFPELFBK POBEANPIGDE, MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x26A4830", Offset = "0x26A3830", VA = "0x1826A4830")]
	[AsyncStateMachine(typeof(LPCMNHNKDBL))]
	private Task<Scene> CAIEIEJFFKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x26A4A80", Offset = "0x26A3A80", VA = "0x1826A4A80")]
	private bool NHCPNBIJHHF(MMIGNNJDMKB FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x26A4AC0", Offset = "0x26A3AC0", VA = "0x1826A4AC0")]
	private void PIGILAJBLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x26A46D0", Offset = "0x26A36D0", VA = "0x1826A46D0")]
	[AsyncStateMachine(typeof(BHCIMJELDHN))]
	private Task<Scene> BAGMIKJBBAB(string PPPHPNPKCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct NKIBJCJMACG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct LELFKKCKOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NKIBJCJMACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public MLAKGLIELEE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public MMIGNNJDMKB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private NILMFDECOMH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<MLAKGLIELEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D420", Offset = "0x3D2C420", VA = "0x183D2D420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DA10", Offset = "0x3D2CA10", VA = "0x183D2DA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct HKBOAHFPIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<MLAKGLIELEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public NKIBJCJMACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public MLAKGLIELEE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A840", Offset = "0x3D29840", VA = "0x183D2A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AAC0", Offset = "0x3D29AC0", VA = "0x183D2AAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly MFGGDAIBFBD HICGCFFCGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly EAPCBILCKLG HECOGALPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly IOPLLKNKNGM NCELCCPHMDF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private NEJLBNOHIBA HBMFNJKGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8EB940", Offset = "0x8EA940", VA = "0x1808EB940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2E66770", Offset = "0x2E65770", VA = "0x182E66770")]
	public NKIBJCJMACG(MFGGDAIBFBD HICGCFFCGJC, EAPCBILCKLG HECOGALPDLB, IOPLLKNKNGM NCELCCPHMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2E665A0", Offset = "0x2E655A0", VA = "0x182E665A0")]
	[AsyncStateMachine(typeof(LELFKKCKOOF))]
	public Task<MLAKGLIELEE> FHPPEIONNPM(MLAKGLIELEE CMBFMEDLLDE, MMIGNNJDMKB HIPDCGPBJBN, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ, bool FHOPFOFLBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2E66410", Offset = "0x2E65410", VA = "0x182E66410")]
	[AsyncStateMachine(typeof(HKBOAHFPIAE))]
	private Task<MLAKGLIELEE> COIODBKDBOL(NILMFDECOMH OIJDGGDGOKN, MLAKGLIELEE IDIIBDOHICE, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2E66740", Offset = "0x2E65740", VA = "0x182E66740")]
	private bool LPGPNJDDLEK(MLAKGLIELEE KPBONAIIKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2E66580", Offset = "0x2E65580", VA = "0x182E66580")]
	private void DHDJNBLMDNC(string BDICMGNPCMC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct KILAHPJFDEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct IOFPNANHJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public NEJLBNOHIBA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private List<(PersistenceView, EPAMCLOEEBK)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private (PersistenceView, EPAMCLOEEBK) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x31F2B30", Offset = "0x31F1B30", VA = "0x1831F2B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x26A3C40", Offset = "0x26A2C40", VA = "0x1826A3C40")]
	[AsyncStateMachine(typeof(IOFPNANHJOC))]
	public static Task CAIEIEJFFKG(NEJLBNOHIBA HMHJFDAOLEM, MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct JFJHEEMKMBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct FNNDAGBFAFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public NEJLBNOHIBA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public HAAEHEGPGPF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private GMDPNKPCIHK <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private List<(PersistenceView, EPAMCLOEEBK)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private EPAMCLOEEBK <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x31EF890", Offset = "0x31EE890", VA = "0x1831EF890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x26A0F30", Offset = "0x269FF30", VA = "0x1826A0F30")]
	[AsyncStateMachine(typeof(FNNDAGBFAFE))]
	public static Task CAIEIEJFFKG(NEJLBNOHIBA HMHJFDAOLEM, MMIGNNJDMKB FILAKGLBGGA, HAAEHEGPGPF IEIMADIFAHC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct HPNIPMEMLKB
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct KHKHNNMJIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public List<OEOHLIIEIAM> NPKAGAKFFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public List<EPAMCLOEEBK> GGDICLKMLJD;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x72EA10", Offset = "0x72DA10", VA = "0x18072EA10")]
		public KHKHNNMJIJG(List<OEOHLIIEIAM> NPKAGAKFFJB, List<EPAMCLOEEBK> GGDICLKMLJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class ABDFIHHOADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public IEnumerable<OEOHLIIEIAM> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ABDFIHHOADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x31E8DF0", Offset = "0x31E7DF0", VA = "0x1831E8DF0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private AMHDFPELFBK POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private MMIGNNJDMKB FILAKGLBGGA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private KPENDAEOIAB JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x269BE40", Offset = "0x269AE40", VA = "0x18269BE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x269B890", Offset = "0x269A890", VA = "0x18269B890")]
	public static KHKHNNMJIJG CAIEIEJFFKG(AMHDFPELFBK POBEANPIGDE, MMIGNNJDMKB FILAKGLBGGA)
	{
		return default(KHKHNNMJIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x269B590", Offset = "0x269A590", VA = "0x18269B590")]
	private KHKHNNMJIJG CAIEIEJFFKG()
	{
		return default(KHKHNNMJIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x269B8F0", Offset = "0x269A8F0", VA = "0x18269B8F0")]
	private KHKHNNMJIJG GCFLHPEFGCC(DOJAMBMLNII KBIIDELJIDG, GMDPNKPCIHK IGHFIAHHGBO)
	{
		return default(KHKHNNMJIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x269BE90", Offset = "0x269AE90", VA = "0x18269BE90")]
	private bool PAAMODNKOMP(IEnumerable<OEOHLIIEIAM> NPKAGAKFFJB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct GPCPLOIMFEF
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class MAMEDOAEBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public HPNIPMEMLKB.KHKHNNMJIJG instantiations;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MAMEDOAEBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x31F9090", Offset = "0x31F8090", VA = "0x1831F9090")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class PIJMKDALIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PIJMKDALIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x31FE240", Offset = "0x31FD240", VA = "0x1831FE240")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x269A280", Offset = "0x2699280", VA = "0x18269A280")]
	public static void CAIEIEJFFKG(NEJLBNOHIBA HMHJFDAOLEM, MMIGNNJDMKB FILAKGLBGGA, HPNIPMEMLKB.KHKHNNMJIJG EEPDAMLMIKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class IOPLLKNKNGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct MFNMBFLDFNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public MLAKGLIELEE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public MMIGNNJDMKB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x31F95A0", Offset = "0x31F85A0", VA = "0x1831F95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class FKEOPKAHBMC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public FKEOPKAHBMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x3D346F0", Offset = "0x3D336F0", VA = "0x183D346F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public NILMFDECOMH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FKEOPKAHBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x31EF690", Offset = "0x31EE690", VA = "0x1831EF690")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct AIGNDHELEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private FKEOPKAHBMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x31E9CA0", Offset = "0x31E8CA0", VA = "0x1831E9CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct ENFNPNLMGCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Dictionary<Guid, List<ALIGMBLCLJO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x31EF1A0", Offset = "0x31EE1A0", VA = "0x1831EF1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KCBDDPABIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private NILMFDECOMH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private Dictionary<Guid, List<ALIGMBLCLJO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x31F4F60", Offset = "0x31F3F60", VA = "0x1831F4F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class ECKNHEFBAGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public ALIGMBLCLJO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public ECKNHEFBAGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3D32030", Offset = "0x3D31030", VA = "0x183D32030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public ENMKPNAANDI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public List<ALIGMBLCLJO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ECKNHEFBAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x31EE300", Offset = "0x31ED300", VA = "0x1831EE300")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x31EE4E0", Offset = "0x31ED4E0", VA = "0x1831EE4E0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(ALIGMBLCLJO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x31EE3F0", Offset = "0x31ED3F0", VA = "0x1831EE3F0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct JKFNNCCOLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public ENMKPNAANDI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public List<ALIGMBLCLJO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private ECKNHEFBAGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x31F4390", Offset = "0x31F3390", VA = "0x1831F4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct IGPFNIADKIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public NILMFDECOMH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x31F23B0", Offset = "0x31F13B0", VA = "0x1831F23B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class FDOCGBHMBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FDOCGBHMBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x31EF620", Offset = "0x31EE620", VA = "0x1831EF620")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct KJMHBODPLGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public MMIGNNJDMKB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x31F5F40", Offset = "0x31F4F40", VA = "0x1831F5F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class MPOMIAKOMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MPOMIAKOMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x31FABA0", Offset = "0x31F9BA0", VA = "0x1831FABA0")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct NPFEMIEMLEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public IOPLLKNKNGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x31FC210", Offset = "0x31FB210", VA = "0x1831FC210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class HGDHLNBGHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HGDHLNBGHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x31F1000", Offset = "0x31F0000", VA = "0x1831F1000")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly MFGGDAIBFBD HICGCFFCGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private EGPCABDFBPF NCELCCPHMDF;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private NEJLBNOHIBA HBMFNJKGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x7B21E0", Offset = "0x7B11E0", VA = "0x1807B21E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	public IOPLLKNKNGM(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x269E900", Offset = "0x269D900", VA = "0x18269E900")]
	[AsyncStateMachine(typeof(MFNMBFLDFNH))]
	public Task CAIEIEJFFKG(MLAKGLIELEE AGKNBBFDEAN, MMIGNNJDMKB HIPDCGPBJBN, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x269F260", Offset = "0x269E260", VA = "0x18269F260")]
	[AsyncStateMachine(typeof(AIGNDHELEOE))]
	private Task IGJFAOKEBPF(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x269F100", Offset = "0x269E100", VA = "0x18269F100")]
	[AsyncStateMachine(typeof(ENFNPNLMGCG))]
	private Task IFKPHMBMPFB(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x269ECC0", Offset = "0x269DCC0", VA = "0x18269ECC0")]
	[AsyncStateMachine(typeof(KCBDDPABIAE))]
	private Task GDONAJDFDJP(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x269EA60", Offset = "0x269DA60", VA = "0x18269EA60")]
	[AsyncStateMachine(typeof(JKFNNCCOLIH))]
	private Task CENHAJFIHBI(Guid CDDAANOGHOJ, List<ALIGMBLCLJO> JPDJGCMNEGI, ENMKPNAANDI LIKGFGOODGF, MMIGNNJDMKB FILAKGLBGGA, CancellationToken KCCFEDJJGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x269F6D0", Offset = "0x269E6D0", VA = "0x18269F6D0")]
	[AsyncStateMachine(typeof(IGPFNIADKIG))]
	private Task MOODLJEHEGN(MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x269F3C0", Offset = "0x269E3C0", VA = "0x18269F3C0")]
	[AsyncStateMachine(typeof(KJMHBODPLGG))]
	private Task JNHJJDCAEHC(Guid JFFCBMAGIOG, MMIGNNJDMKB FILAKGLBGGA, NILMFDECOMH JBAEFOFJALC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x269EE20", Offset = "0x269DE20", VA = "0x18269EE20")]
	[AsyncStateMachine(typeof(NPFEMIEMLEI))]
	private Task HFHEJNGADFA(Guid JFFCBMAGIOG, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x269EF70", Offset = "0x269DF70", VA = "0x18269EF70")]
	private void IBGLNDJFEDL(Guid JFFCBMAGIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x269EBA0", Offset = "0x269DBA0", VA = "0x18269EBA0")]
	private void CPMNFHCPDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x269F500", Offset = "0x269E500", VA = "0x18269F500")]
	public Guid MFOGCMJOKJI(MLAKGLIELEE CHELLHNMPGA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x269E730", Offset = "0x269D730", VA = "0x18269E730")]
	[CompilerGenerated]
	private object BOGBMDNAMFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
public readonly struct CFDCFBIAELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	[CanBeNull]
	public readonly DOJAMBMLNII EHBOCPMCFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	[NotNull]
	public readonly ALOGFNPDBKM DPPOJMLFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	[CanBeNull]
	public readonly string IPFJCDALDAH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyCollection<string> PJOICJBIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x268DE60", Offset = "0x268CE60", VA = "0x18268DE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyDictionary<long, int> HCGCDPCEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x268DE80", Offset = "0x268CE80", VA = "0x18268DE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x268DEA0", Offset = "0x268CEA0", VA = "0x18268DEA0")]
	public CFDCFBIAELJ([CanBeNull] DOJAMBMLNII GPCLICNBEEG, [NotNull] ALOGFNPDBKM POPCGCFICBI, [CanBeNull] string GHOHBGIEHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal class NOEICNIBFBG : OMELJEKBDMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct NHEDFAMNJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public AsyncTaskMethodBuilder<CFDCFBIAELJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public NOEICNIBFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public JHPBHDOGOGO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FB90", Offset = "0x3D2EB90", VA = "0x183D2FB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3D30060", Offset = "0x3D2F060", VA = "0x183D30060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class AEOMHBLIKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public JHPBHDOGOGO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AEOMHBLIKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D24B50", Offset = "0x3D23B50", VA = "0x183D24B50")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class JAEGFGFEIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AEOMHBLIKDI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JAEGFGFEIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B6D0", Offset = "0x3D2A6D0", VA = "0x183D2B6D0")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class LBHLDDMHMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AEOMHBLIKDI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LBHLDDMHMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D330", Offset = "0x3D2C330", VA = "0x183D2D330")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct POIICCLIGAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public JHPBHDOGOGO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public NOEICNIBFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private JAEGFGFEIFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private PNCIKFNGDFC.FOAPJDNKIHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D31A40", Offset = "0x3D30A40", VA = "0x183D31A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly FOGNFBPAHHI MCAIOCMCMPO;

	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private static readonly TimeSpan MHIFGBHHHCM;

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2E679E0", Offset = "0x2E669E0", VA = "0x182E679E0")]
	public NOEICNIBFBG(MFGGDAIBFBD HICGCFFCGJC, [Optional] FOGNFBPAHHI? MCAIOCMCMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2E677F0", Offset = "0x2E667F0", VA = "0x182E677F0")]
	[AsyncStateMachine(typeof(NHEDFAMNJCC))]
	public Task<CFDCFBIAELJ> PNKNJNLKBEB(long PFEOAIPJFFN, string GHOHBGIEHPJ, JHPBHDOGOGO FCEBBBLGEJO, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2E66B40", Offset = "0x2E65B40", VA = "0x182E66B40")]
	[AsyncStateMachine(typeof(POIICCLIGAG))]
	private Task CIHDAEICNGP(JHPBHDOGOGO FCEBBBLGEJO, IEnumerable<PersistenceView> MAAEJBDELJL, StringBuilder LBDEIPELFGB, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2E66CA0", Offset = "0x2E65CA0", VA = "0x182E66CA0")]
	private CFDCFBIAELJ DFJPJIPNINO(long PFEOAIPJFFN, string GHOHBGIEHPJ, JHPBHDOGOGO FCEBBBLGEJO, IEnumerable<PersistenceView> MAAEJBDELJL, StringBuilder LBDEIPELFGB)
	{
		return default(CFDCFBIAELJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2E66960", Offset = "0x2E65960", VA = "0x182E66960")]
	private DOJAMBMLNII CIDABFIIGMN(long PFEOAIPJFFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2E67070", Offset = "0x2E66070", VA = "0x182E67070")]
	private void GGKCNIFBGDC(DOJAMBMLNII GCAJLECELPO, StringBuilder LBDEIPELFGB, IEnumerable<PersistenceView> MAAEJBDELJL, in FDBDBNOIJEA JOHEPNEHJEJ, ref ABEBIAKBDHH KPGEJCHLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2E67290", Offset = "0x2E66290", VA = "0x182E67290")]
	private void PHEKFCBKIJO(DOJAMBMLNII GCAJLECELPO, StringBuilder LBDEIPELFGB, PersistenceView JENEHFPKFDC, ref ABEBIAKBDHH KPGEJCHLPCD, in FDBDBNOIJEA JOHEPNEHJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal class IIKNOLCOPFM : OMELJEKBDMF
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class APJOBGHHHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public PEHJDNEOAMN.IECIGIGCPLB roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public PEHJDNEOAMN.IECIGIGCPLB subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public APJOBGHHHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x31EA8E0", Offset = "0x31E98E0", VA = "0x1831EA8E0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x31EA970", Offset = "0x31E9970", VA = "0x1831EA970")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x31EA9C0", Offset = "0x31E99C0", VA = "0x1831EA9C0")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x31EAA30", Offset = "0x31E9A30", VA = "0x1831EAA30")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct PCJDFBFCHFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public AsyncTaskMethodBuilder<(PEHJDNEOAMN.IECIGIGCPLB roomDataUpload, PEHJDNEOAMN.IECIGIGCPLB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CFDCFBIAELJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public IIKNOLCOPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private APJOBGHHHBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<PEHJDNEOAMN.IECIGIGCPLB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x31FD480", Offset = "0x31FC480", VA = "0x1831FD480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x31FDF30", Offset = "0x31FCF30", VA = "0x1831FDF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LDGJPIPACEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public AsyncTaskMethodBuilder<IFFJPCNELHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IIKNOLCOPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CFDCFBIAELJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public GAGKBGGCBLG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private TaskAwaiter<(PEHJDNEOAMN.IECIGIGCPLB roomDataUpload, PEHJDNEOAMN.IECIGIGCPLB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<IFFJPCNELHO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x31F7110", Offset = "0x31F6110", VA = "0x1831F7110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x31F75D0", Offset = "0x31F65D0", VA = "0x1831F75D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct HGOGJFDHIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder<IILIHFPFOJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public IIKNOLCOPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CFDCFBIAELJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter<(PEHJDNEOAMN.IECIGIGCPLB roomDataUpload, PEHJDNEOAMN.IECIGIGCPLB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<IILIHFPFOJH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x31F1070", Offset = "0x31F0070", VA = "0x1831F1070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x31F1400", Offset = "0x31F0400", VA = "0x1831F1400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class PNEJOEFHGEJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public PNEJOEFHGEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			private KNMGGFFPHPG <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			private TaskAwaiter<IILIHFPFOJH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			private TaskAwaiter<IFFJPCNELHO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private TaskAwaiter<KNMGGFFPHPG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x3D34BD0", Offset = "0x3D33BD0", VA = "0x183D34BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x3D35750", Offset = "0x3D34750", VA = "0x183D35750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public IIKNOLCOPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CFDCFBIAELJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public GAGKBGGCBLG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PNEJOEFHGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x31FE2D0", Offset = "0x31FD2D0", VA = "0x1831FE2D0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KNMGGFFPHPG> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct BKDDJNMEADP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<KNMGGFFPHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public IIKNOLCOPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CFDCFBIAELJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public GAGKBGGCBLG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<KNMGGFFPHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x31EB650", Offset = "0x31EA650", VA = "0x1831EB650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x31EB900", Offset = "0x31EA900", VA = "0x1831EB900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private const float JODCDACDAJN = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private readonly BPDAIKIDHAK DEANKNKINBE;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private AMHDFPELFBK NLHPHNNMALF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x2692B90", Offset = "0x2691B90", VA = "0x182692B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x269DBA0", Offset = "0x269CBA0", VA = "0x18269DBA0")]
	public IIKNOLCOPFM(MFGGDAIBFBD HICGCFFCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x269D880", Offset = "0x269C880", VA = "0x18269D880")]
	[AsyncStateMachine(typeof(PCJDFBFCHFG))]
	private Task<(PEHJDNEOAMN.IECIGIGCPLB, PEHJDNEOAMN.IECIGIGCPLB)> LNAPFLIHGFM(CFDCFBIAELJ MAEFHMCAIMI, long KPBGCMCAECK, long CFCAAMCKONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x269D6F0", Offset = "0x269C6F0", VA = "0x18269D6F0")]
	[AsyncStateMachine(typeof(LDGJPIPACEG))]
	public Task<IFFJPCNELHO> JBJCEPLGJNG(int CEGPOGLBCHA, [CanBeNull] GAGKBGGCBLG MDMHKOKPKAA, CFDCFBIAELJ MAEFHMCAIMI, long KPBGCMCAECK, long CFCAAMCKONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x269D560", Offset = "0x269C560", VA = "0x18269D560")]
	[AsyncStateMachine(typeof(HGOGJFDHIJA))]
	private Task<IILIHFPFOJH> IOGFJKDHAKP(string EHGBHFCBKPM, int CEGPOGLBCHA, CFDCFBIAELJ MAEFHMCAIMI, long KPBGCMCAECK, long CFCAAMCKONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x269D9F0", Offset = "0x269C9F0", VA = "0x18269D9F0")]
	[AsyncStateMachine(typeof(BKDDJNMEADP))]
	public Task<KNMGGFFPHPG> OCLHBAABJGH(int CEGPOGLBCHA, [CanBeNull] GAGKBGGCBLG MDMHKOKPKAA, CFDCFBIAELJ MAEFHMCAIMI, long KPBGCMCAECK, long CFCAAMCKONC, NILMFDECOMH OIJDGGDGOKN, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public abstract class BIHLKGAAFGN<T> where T : global::BIHLKGAAFGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	internal readonly AMHDFPELFBK OHKOMBOEAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private int? IIEBHDGGBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	protected readonly Guid MONMFFCHOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	protected readonly KCNIDPOKJDF FNJGMNKBLMJ;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T NNDECPIIHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x28275F0", Offset = "0x28265F0", VA = "0x1828275F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x2827650", Offset = "0x2826650", VA = "0x182827650")]
	internal BIHLKGAAFGN(AMHDFPELFBK NOJKJGAHGIO, KCNIDPOKJDF KLLGHOJBLIJ, [Optional] Guid? MHGELGNLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2827490", Offset = "0x2826490", VA = "0x182827490")]
	private KNMGGFFPHPG KLOJEJEEDCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	protected virtual void PACFHKFGKBL(KNMGGFFPHPG LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x2827300", Offset = "0x2826300", VA = "0x182827300")]
	public T AHFBNGMHPFH(DMHOAMAMDGI PKPBDEIEICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2827570", Offset = "0x2826570", VA = "0x182827570")]
	public T LAAFNHGNBEK(int LNJBAMIEJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x2827390", Offset = "0x2826390", VA = "0x182827390", Slot = "5")]
	public virtual Task<NIHJKBCEGCJ> JCFMGFEDMLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class IAEJIMAMGPL : global::BIHLKGAAFGN<IAEJIMAMGPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private GDFDJMJJEPG BNKBFACGLIM;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x269C1C0", Offset = "0x269B1C0", VA = "0x18269C1C0")]
	internal IAEJIMAMGPL(AMHDFPELFBK NOJKJGAHGIO, KCNIDPOKJDF KLLGHOJBLIJ, [Optional] Guid? MHGELGNLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x269C0E0", Offset = "0x269B0E0", VA = "0x18269C0E0")]
	public IAEJIMAMGPL CIINCBAMJGO(GDFDJMJJEPG BNKBFACGLIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x269C100", Offset = "0x269B100", VA = "0x18269C100", Slot = "4")]
	protected override void PACFHKFGKBL(KNMGGFFPHPG LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class FIHIKPBJMKO : global::BIHLKGAAFGN<FIHIKPBJMKO>
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	internal enum AFGFLKPFPOO
	{
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct MADPGPBKJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public AsyncTaskMethodBuilder<NIHJKBCEGCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public FIHIKPBJMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter<NIHJKBCEGCJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x31F8D40", Offset = "0x31F7D40", VA = "0x1831F8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x31F9040", Offset = "0x31F8040", VA = "0x1831F9040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private AFGFLKPFPOO KDOCGMEFMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private string IJJJLMMLCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private GAGKBGGCBLG BNKBFACGLIM;

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2697680", Offset = "0x2696680", VA = "0x182697680")]
	internal FIHIKPBJMKO(AMHDFPELFBK NOJKJGAHGIO, KCNIDPOKJDF KLLGHOJBLIJ, [Optional] Guid? MHGELGNLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2697490", Offset = "0x2696490", VA = "0x182697490")]
	public FIHIKPBJMKO KNHIMHHKENP(string FIBEBNJOBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x26974C0", Offset = "0x26964C0", VA = "0x1826974C0")]
	public FIHIKPBJMKO LOGLLPHAFJJ(bool OIGGOOPDAIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x26974E0", Offset = "0x26964E0", VA = "0x1826974E0")]
	public FIHIKPBJMKO ODCHCNAOIEL(string JLGENJBOGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2697340", Offset = "0x2696340", VA = "0x182697340")]
	public FIHIKPBJMKO HPGAEEIFLMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x2697510", Offset = "0x2696510", VA = "0x182697510", Slot = "4")]
	protected override void PACFHKFGKBL(KNMGGFFPHPG LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2697370", Offset = "0x2696370", VA = "0x182697370", Slot = "5")]
	[AsyncStateMachine(typeof(MADPGPBKJPI))]
	public override Task<NIHJKBCEGCJ> JCFMGFEDMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2697300", Offset = "0x2696300", VA = "0x182697300")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<NIHJKBCEGCJ> BJDPPOCEFDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal static class AEAEDDEOKOG
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x26870C0", Offset = "0x26860C0", VA = "0x1826870C0")]
	public static void NJKHMFABFDM(this KJNKLCIDCEB OFINBADPEFM, JJPHLLGENAE PEKKMNLGGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2687210", Offset = "0x2686210", VA = "0x182687210")]
	public static void OPBPNDAHMDG(this JJPHLLGENAE DKBNHPIBBHO, [Optional] string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public static class FFNDMNIGDLN
{
	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x2696260", Offset = "0x2695260", VA = "0x182696260")]
	public static INLAJELACMH KPOBJMJDFNL(this LCOCAOICAJN CLAOGJNMEBM)
	{
		return default(INLAJELACMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x26961A0", Offset = "0x26951A0", VA = "0x1826961A0")]
	public static LCOCAOICAJN CPEBFDFKPNP(this INLAJELACMH NEPIPPLKINA)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000177")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			public HBKJCNMGDOP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public HBKJCNMGDOP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private static HBKJCNMGDOP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private Dictionary<HBKJCNMGDOP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E73000", Offset = "0x2E72000", VA = "0x182E73000")]
		public bool LMIBBENFOEN(HBKJCNMGDOP JIFACBIDLOJ, out ResultConfig PJKPAHNPCHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E72EE0", Offset = "0x2E71EE0", VA = "0x182E72EE0")]
		public ResultConfig ECKKEIKMBMD(HBKJCNMGDOP COBJNMAIDFF, [Optional] HashSet<HBKJCNMGDOP> LCFBJAIDJLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E735F0", Offset = "0x2E725F0", VA = "0x182E735F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E73070", Offset = "0x2E72070", VA = "0x182E73070", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public static class FFIIHGEOPED
{
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2695D00", Offset = "0x2694D00", VA = "0x182695D00")]
	[EJICMPGFCBP(CIKEJIGJNLD.GameOnly)]
	private static void PMFNJDEOCIJ(GBDCKFPNAEP BPNAPGCNONC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public interface EIADPFDFDMD : IEquatable<EIADPFDFDMD>
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime NKEFJMHLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMMBLFIAPAP();

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHALAMMNEGE(long KPBGCMCAECK, long PFEOAIPJFFN, out CFDCFBIAELJ MAEFHMCAIMI);
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class LKEELEADBHM : DOADGIBKBGJ
{
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class FOIKBCKPNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public JCKPEGAFAPH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FOIKBCKPNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x31EFF60", Offset = "0x31EEF60", VA = "0x1831EFF60")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly KOPCDNAMJLH BIBFFBNIGKK;

	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private const int ENLBLOMPKOJ = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<EIADPFDFDMD> NEEIMAJJICB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x26A5280", Offset = "0x26A4280", VA = "0x1826A5280", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x26A5E00", Offset = "0x26A4E00", VA = "0x1826A5E00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	[Preserve]
	public LKEELEADBHM([ELDNEOCBGIN(null)] KOPCDNAMJLH BIBFFBNIGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x26A55F0", Offset = "0x26A45F0", VA = "0x1826A55F0", Slot = "6")]
	public bool CKBMENBAEEG(long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI, JCKPEGAFAPH MPBBMJKCHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x26A5550", Offset = "0x26A4550", VA = "0x1826A5550")]
	private void CJHOPBHEAFA(EIADPFDFDMD IIDEMCOOKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x26A53D0", Offset = "0x26A43D0", VA = "0x1826A53D0", Slot = "7")]
	public bool BODCEIGPFMK(long KPBGCMCAECK, long PFEOAIPJFFN, out EIADPFDFDMD MBIMPHFLEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5320", Offset = "0x26A4320", VA = "0x1826A5320", Slot = "8")]
	public bool BHMAGAMFKBA(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, out EIADPFDFDMD MBIMPHFLEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x26A58F0", Offset = "0x26A48F0", VA = "0x1826A58F0")]
	private void CLJLHCNIEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x26A5CE0", Offset = "0x26A4CE0", VA = "0x1826A5CE0", Slot = "9")]
	public void GEHJKFKOLGB(long KPBGCMCAECK, long PFEOAIPJFFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal abstract class IMICKPOBGEC : KOPCDNAMJLH
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	protected enum DDBHICDECMG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class PGNGEHBPLED : IEnumerable<EIADPFDFDMD>, IEnumerable, IEnumerator<EIADPFDFDMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private EIADPFDFDMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public IMICKPOBGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private JCKPEGAFAPH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public JCKPEGAFAPH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private EIADPFDFDMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public PGNGEHBPLED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x31FDFF0", Offset = "0x31FCFF0", VA = "0x1831FDFF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x31FE200", Offset = "0x31FD200", VA = "0x1831FE200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x31FE150", Offset = "0x31FD150", VA = "0x1831FE150", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EIADPFDFDMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x31FE150", Offset = "0x31FD150", VA = "0x1831FE150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class IENBKCCFLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public JCKPEGAFAPH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IENBKCCFLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x31F1F90", Offset = "0x31F0F90", VA = "0x1831F1F90")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class IBBKMJILDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public IMICKPOBGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IBBKMJILDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x31F1F60", Offset = "0x31F0F60", VA = "0x1831F1F60")]
		internal void <TryReadAutosaveFile>b__0(NMLJGOBBGAI.MGNOFCAMLNB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	protected readonly string GDLLBPGBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private readonly object EALODCELHMC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x269E6A0", Offset = "0x269D6A0", VA = "0x18269E6A0")]
	protected IMICKPOBGEC([CanBeNull] string CLPHADOKDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x269E030", Offset = "0x269D030", VA = "0x18269E030", Slot = "5")]
	public bool JOFHABCPMEM(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, out EIADPFDFDMD IIDEMCOOKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x269E620", Offset = "0x269D620", VA = "0x18269E620", Slot = "6")]
	[IteratorStateMachine(typeof(PGNGEHBPLED))]
	public IEnumerable<EIADPFDFDMD> PPPCEALAAJG(JCKPEGAFAPH MPBBMJKCHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PBAFIPNIOHE(Stream BCNKLGENPIG, long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FIKNJLAPFEI(Stream FCJFADFKEOM, long KPBGCMCAECK, long PFEOAIPJFFN, AHPFPBIDHDM KOEOCBJIALD, out CFDCFBIAELJ MAEFHMCAIMI);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x269E210", Offset = "0x269D210", VA = "0x18269E210", Slot = "7")]
	public EIADPFDFDMD NHKKPECNIMG(long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI, JCKPEGAFAPH MPBBMJKCHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BJGLDEMKKDI(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CMIDHLODCNC(JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x269E5B0", Offset = "0x269D5B0", VA = "0x18269E5B0")]
	protected void PCMBJILJHMF(NMLJGOBBGAI.MGNOFCAMLNB HAPHEAJPNFB, string BDICMGNPCMC, FileInfo MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x269DD80", Offset = "0x269CD80", VA = "0x18269DD80")]
	internal bool GLCGEHLJIMP(FileInfo EOPENNKALCA, long KPBGCMCAECK, long PFEOAIPJFFN, out CFDCFBIAELJ MAEFHMCAIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private void MKJBOMNHFNK(Exception BGAGBEAHOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class LMODCAIHKGL : IMICKPOBGEC
{
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private const string NCLBEMHHNBO = "V2";

	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private const string FOHNLDAACAJ = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private const string MCJBPNJCDKJ = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x10BD050", Offset = "0x10BC050", VA = "0x1810BD050", Slot = "8")]
		get
		{
			return default(APMJAFGFGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x26A75F0", Offset = "0x26A65F0", VA = "0x1826A75F0")]
	public LMODCAIHKGL([Optional] string CLPHADOKDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x26A6AA0", Offset = "0x26A5AA0", VA = "0x1826A6AA0")]
	private void ANILGNPAHDP(JCKPEGAFAPH MPBBMJKCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x26A7390", Offset = "0x26A6390", VA = "0x1826A7390", Slot = "9")]
	internal override void PBAFIPNIOHE(Stream BCNKLGENPIG, long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D20", Offset = "0x26A5D20", VA = "0x1826A6D20", Slot = "10")]
	internal override bool FIKNJLAPFEI(Stream FCJFADFKEOM, long KPBGCMCAECK, long PFEOAIPJFFN, AHPFPBIDHDM KOEOCBJIALD, out CFDCFBIAELJ MAEFHMCAIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x26A6B20", Offset = "0x26A5B20", VA = "0x1826A6B20", Slot = "11")]
	protected override FileInfo BJGLDEMKKDI(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x26A6C10", Offset = "0x26A5C10", VA = "0x1826A6C10", Slot = "12")]
	protected override DirectoryInfo CMIDHLODCNC(JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal sealed class CILOGIMLCHD : IMICKPOBGEC
{
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private static readonly byte[] PIIJMEAKDGO;

	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private const string FOHNLDAACAJ = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private const string MCJBPNJCDKJ = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private const string OLGCJDOAHLH = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly byte[] EMCHFOKPGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly byte[] KDHNLIJHKBP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x738020", Offset = "0x737020", VA = "0x180738020", Slot = "8")]
		get
		{
			return default(APMJAFGFGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x268F1A0", Offset = "0x268E1A0", VA = "0x18268F1A0")]
	public CILOGIMLCHD([Optional] string CLPHADOKDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x268EE80", Offset = "0x268DE80", VA = "0x18268EE80", Slot = "9")]
	internal override void PBAFIPNIOHE(Stream BCNKLGENPIG, long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x268E600", Offset = "0x268D600", VA = "0x18268E600", Slot = "10")]
	internal override bool FIKNJLAPFEI(Stream FCJFADFKEOM, long KPBGCMCAECK, long PFEOAIPJFFN, AHPFPBIDHDM KOEOCBJIALD, out CFDCFBIAELJ MAEFHMCAIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x268E3D0", Offset = "0x268D3D0", VA = "0x18268E3D0")]
	private void CHCNCHJNFPN(byte[] CCFMJPPGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x268E2A0", Offset = "0x268D2A0", VA = "0x18268E2A0", Slot = "11")]
	protected override FileInfo BJGLDEMKKDI(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x268E4E0", Offset = "0x268D4E0", VA = "0x18268E4E0", Slot = "12")]
	protected override DirectoryInfo CMIDHLODCNC(JCKPEGAFAPH MPBBMJKCHFP, DDBHICDECMG KHAADBDLPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public enum APMJAFGFGBM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IHMGNDHLIOJ : KOPCDNAMJLH
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class BEHDOOBLPFJ : IEnumerable<EIADPFDFDMD>, IEnumerable, IEnumerator<EIADPFDFDMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private EIADPFDFDMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public IHMGNDHLIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private JCKPEGAFAPH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public JCKPEGAFAPH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private APMJAFGFGBM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private IEnumerator<EIADPFDFDMD> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private EIADPFDFDMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public BEHDOOBLPFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x31EB040", Offset = "0x31EA040", VA = "0x1831EB040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x31EAC70", Offset = "0x31E9C70", VA = "0x1831EAC70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x31EB0D0", Offset = "0x31EA0D0", VA = "0x1831EB0D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x31EB000", Offset = "0x31EA000", VA = "0x1831EB000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x31EAF50", Offset = "0x31E9F50", VA = "0x1831EAF50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EIADPFDFDMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x31EAF50", Offset = "0x31E9F50", VA = "0x1831EAF50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly APMJAFGFGBM[] CFBPCNCPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private readonly Dictionary<APMJAFGFGBM, KOPCDNAMJLH> LEJIFPIAFKJ;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x269CCB0", Offset = "0x269BCB0", VA = "0x18269CCB0", Slot = "4")]
		get
		{
			return default(APMJAFGFGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x269D1F0", Offset = "0x269C1F0", VA = "0x18269D1F0")]
	[Preserve]
	public IHMGNDHLIOJ(params KOPCDNAMJLH[] LACFANDOCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x269CF20", Offset = "0x269BF20", VA = "0x18269CF20", Slot = "5")]
	public bool JOFHABCPMEM(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, out EIADPFDFDMD IIDEMCOOKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x269CCF0", Offset = "0x269BCF0", VA = "0x18269CCF0")]
	private void JGPGGPJCFND(int JEHLJEDAEBP, long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x269D170", Offset = "0x269C170", VA = "0x18269D170", Slot = "6")]
	[IteratorStateMachine(typeof(BEHDOOBLPFJ))]
	public IEnumerable<EIADPFDFDMD> PPPCEALAAJG(JCKPEGAFAPH MPBBMJKCHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x269D080", Offset = "0x269C080", VA = "0x18269D080", Slot = "7")]
	public EIADPFDFDMD NHKKPECNIMG(long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI, JCKPEGAFAPH MPBBMJKCHFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class CHIAHPGNPJD
{
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	internal const int ACAFNOOJEJE = 32;

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x268E200", Offset = "0x268D200", VA = "0x18268E200")]
	internal static byte[] LIIDBBIELPN(byte[] CCFMJPPGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x268DFA0", Offset = "0x268CFA0", VA = "0x18268DFA0")]
	public static void CHACEELGIPH(Stream KJHFBEBKBIB, byte[] BKABFHDDBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x268E020", Offset = "0x268D020", VA = "0x18268E020")]
	public static bool DHILJHDHEOF(Stream KJHFBEBKBIB, long EMAHDLDOAFG, AHPFPBIDHDM IBHPEOPPODH, out byte[] KHFBMIHLNAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal sealed class FAELINKJHDK : EIADPFDFDMD, IEquatable<EIADPFDFDMD>, IEquatable<FAELINKJHDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private readonly IMICKPOBGEC PDOMGOFGJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public readonly FileInfo GAOKEDONOKK;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x9799A0", Offset = "0x9789A0", VA = "0x1809799A0", Slot = "4")]
		get
		{
			return default(APMJAFGFGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime NKEFJMHLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2695570", Offset = "0x2694570", VA = "0x182695570", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2695A30", Offset = "0x2694A30", VA = "0x182695A30")]
	public FAELINKJHDK(IMICKPOBGEC MMIEMEFPKAA, FileInfo EOPENNKALCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2695980", Offset = "0x2694980", VA = "0x182695980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x26954B0", Offset = "0x26944B0", VA = "0x1826954B0", Slot = "6")]
	public void AMMBLFIAPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x2695610", Offset = "0x2694610", VA = "0x182695610", Slot = "7")]
	public bool CHALAMMNEGE(long KPBGCMCAECK, long PFEOAIPJFFN, out CFDCFBIAELJ MAEFHMCAIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2695700", Offset = "0x2694700", VA = "0x182695700", Slot = "8")]
	public bool Equals(EIADPFDFDMD KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2695650", Offset = "0x2694650", VA = "0x182695650", Slot = "9")]
	public bool Equals(FAELINKJHDK KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x26957E0", Offset = "0x26947E0", VA = "0x1826957E0", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x26958E0", Offset = "0x26948E0", VA = "0x1826958E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x1753490", Offset = "0x1752490", VA = "0x181753490")]
	public static bool FHCNBCDBOFI(FAELINKJHDK LKPNMPOCKEL, FAELINKJHDK JJHFBCIJNFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x17535E0", Offset = "0x17525E0", VA = "0x1817535E0")]
	public static bool LIEIJOJMABA(FAELINKJHDK LKPNMPOCKEL, FAELINKJHDK JJHFBCIJNFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public delegate void AHPFPBIDHDM(NMLJGOBBGAI.MGNOFCAMLNB DNHICBFFOBI, string LMLMHJKGDCH);
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal interface KOPCDNAMJLH
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	APMJAFGFGBM PHDIDPGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOFHABCPMEM(long KPBGCMCAECK, long PFEOAIPJFFN, JCKPEGAFAPH MPBBMJKCHFP, out EIADPFDFDMD IIDEMCOOKBC);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<EIADPFDFDMD> PPPCEALAAJG(JCKPEGAFAPH MPBBMJKCHFP);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EIADPFDFDMD NHKKPECNIMG(long KPBGCMCAECK, long PFEOAIPJFFN, CFDCFBIAELJ MAEFHMCAIMI, JCKPEGAFAPH MPBBMJKCHFP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x26A40F0", Offset = "0x26A30F0", VA = "0x1826A40F0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x26A3DA0", Offset = "0x26A2DA0", VA = "0x1826A3DA0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000691")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
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
