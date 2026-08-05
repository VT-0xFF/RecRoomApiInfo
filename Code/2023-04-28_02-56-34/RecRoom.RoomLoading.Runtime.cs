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
using Microsoft.CodeAnalysis;
using Mono.Math;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x31D79C0", Offset = "0x31D63C0", VA = "0x1831D79C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FBEFOPHLCLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27D6400", Offset = "0x27D4E00", VA = "0x1827D6400")]
	public FBEFOPHLCLF(string BALNMHDNCIN, Exception FCOGIEGFKLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class DCDOJDAIFMM : FDPAPOKOKPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BHNOJIBGPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JEDNDCJMLKI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<global::ADBFIODFKKF<JEDNDCJMLKI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D760", Offset = "0x3C6C160", VA = "0x183C6D760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D940", Offset = "0x3C6C340", VA = "0x183C6D940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IDDKBGFHBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LJHGFDHBFME>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LJHGFDHBFME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C76110", Offset = "0x3C74B10", VA = "0x183C76110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C762D0", Offset = "0x3C74CD0", VA = "0x183C762D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	[UnityEngine.Scripting.Preserve]
	public DCDOJDAIFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27D27E0", Offset = "0x27D11E0", VA = "0x1827D27E0", Slot = "4")]
	[AsyncStateMachine(typeof(BHNOJIBGPFG))]
	public Task<IReadOnlyList<JEDNDCJMLKI>> OGFIPECONNA(long LCIEPBGBKGO, long HJCAHMBDEEM, [Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27D26A0", Offset = "0x27D10A0", VA = "0x1827D26A0", Slot = "5")]
	[AsyncStateMachine(typeof(IDDKBGFHBLN))]
	public Task<IReadOnlyList<LJHGFDHBFME>> KDGBFILNGHA(IReadOnlyList<int> GNHEIGCMIOD, [Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EDHBDDIBAFN : IEquatable<EDHBDDIBAFN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int ICKNKMCGAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LJHGFDHBFME LCPJOHEGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime PGDGAKKAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DJPJCNGKLKK? PAANIFELBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CGIIIFAOEOF? BBODCAIIEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JNLJFOIIPKM NLEFCLDLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IOCLDNFCAPD> DLOLHIFGPEL();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JNLJFOIIPKM
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FDPAPOKOKPL
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<JEDNDCJMLKI>> OGFIPECONNA(long LCIEPBGBKGO, long HJCAHMBDEEM, [Optional] CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LJHGFDHBFME>> KDGBFILNGHA(IReadOnlyList<int> GNHEIGCMIOD, [Optional] CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MIELLCNLKHH
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class OIBHKDHHMPF : EDHBDDIBAFN, IEquatable<EDHBDDIBAFN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct JKCHBIILIBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OIBHKDHHMPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private EOALMFOCEOE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<LLBNMMPGAFE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IOCLDNFCAPD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x407D210", Offset = "0x407BC10", VA = "0x18407D210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x407D650", Offset = "0x407C050", VA = "0x18407D650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly JEDNDCJMLKI AOMCOBDFALE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ICKNKMCGAKF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LJHGFDHBFME LCPJOHEGCJA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime GLJBNDKPNOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4082010", Offset = "0x4080A10", VA = "0x184082010", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8168E0", Offset = "0x8152E0", VA = "0x1808168E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x10BF730", Offset = "0x10BE130", VA = "0x1810BF730", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4082030", Offset = "0x4080A30", VA = "0x184082030", Slot = "9")]
		[AsyncStateMachine(typeof(JKCHBIILIBA))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4082360", Offset = "0x4080D60", VA = "0x184082360")]
		public OIBHKDHHMPF(int LAJJMFBMNPC, LJHGFDHBFME JAONJGNPGMO, JEDNDCJMLKI AOMCOBDFALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4082160", Offset = "0x4080B60", VA = "0x184082160", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x40821F0", Offset = "0x4080BF0", VA = "0x1840821F0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4082290", Offset = "0x4080C90", VA = "0x184082290")]
		private bool GPPPEAMKLPC(OIBHKDHHMPF MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40822D0", Offset = "0x4080CD0", VA = "0x1840822D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class BEINOMKDCMD : EDHBDDIBAFN, IEquatable<EDHBDDIBAFN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct IIPDPOGFFIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public BEINOMKDCMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<IOCLDNFCAPD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x407BC10", Offset = "0x407A610", VA = "0x18407BC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x407BE50", Offset = "0x407A850", VA = "0x18407BE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LFLMMDJMDFC PIHHADEHLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly DJPJCNGKLKK KKELGKPHJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CGIIIFAOEOF CCILIBOFAOI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ICKNKMCGAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4075840", Offset = "0x4074240", VA = "0x184075840", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LJHGFDHBFME LCPJOHEGCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4075BA0", Offset = "0x40745A0", VA = "0x184075BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime GLJBNDKPNOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4075890", Offset = "0x4074290", VA = "0x184075890", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4075C40", Offset = "0x4074640", VA = "0x184075C40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4075A00", Offset = "0x4074400", VA = "0x184075A00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72BC40", Offset = "0x72A640", VA = "0x18072BC40", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6870", Offset = "0x7B5270", VA = "0x1807B6870")]
		public BEINOMKDCMD(LFLMMDJMDFC DADNHALGJFA, DJPJCNGKLKK KLFEMECHKEC, CGIIIFAOEOF BKOKOKDEANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40758E0", Offset = "0x40742E0", VA = "0x1840758E0", Slot = "9")]
		[AsyncStateMachine(typeof(IIPDPOGFFIO))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4075B00", Offset = "0x4074500", VA = "0x184075B00", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4075A50", Offset = "0x4074450", VA = "0x184075A50", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4075C90", Offset = "0x4074690", VA = "0x184075C90")]
		private bool GPPPEAMKLPC(BEINOMKDCMD MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4075CF0", Offset = "0x40746F0", VA = "0x184075CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class HMIMKAJBGKP : EDHBDDIBAFN, IEquatable<EDHBDDIBAFN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct EHNIALIEBKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<IOCLDNFCAPD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x40781D0", Offset = "0x4076BD0", VA = "0x1840781D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x40783B0", Offset = "0x4076DB0", VA = "0x1840783B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LJHGFDHBFME OEACBAFNJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly DJPJCNGKLKK KKELGKPHJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CGIIIFAOEOF CCILIBOFAOI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int ICKNKMCGAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x407B380", Offset = "0x4079D80", VA = "0x18407B380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LJHGFDHBFME LCPJOHEGCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime GLJBNDKPNOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x407B7D0", Offset = "0x407A1D0", VA = "0x18407B7D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x407B4F0", Offset = "0x4079EF0", VA = "0x18407B4F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6870", Offset = "0x7B5270", VA = "0x1807B6870")]
		public HMIMKAJBGKP(LJHGFDHBFME JAONJGNPGMO, DJPJCNGKLKK KLFEMECHKEC, CGIIIFAOEOF BKOKOKDEANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x407B400", Offset = "0x4079E00", VA = "0x18407B400", Slot = "9")]
		[AsyncStateMachine(typeof(EHNIALIEBKD))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x407B690", Offset = "0x407A090", VA = "0x18407B690", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x407B540", Offset = "0x4079F40", VA = "0x18407B540", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x407B920", Offset = "0x407A320", VA = "0x18407B920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x407B820", Offset = "0x407A220", VA = "0x18407B820")]
		private bool GPPPEAMKLPC(HMIMKAJBGKP MPHACEGLFIL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DONHCBLLAAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<EDHBDDIBAFN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public MIELLCNLKHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<JEDNDCJMLKI> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<JEDNDCJMLKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LJHGFDHBFME account, JEDNDCJMLKI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x40765F0", Offset = "0x4074FF0", VA = "0x1840765F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4077080", Offset = "0x4075A80", VA = "0x184077080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GHFBIHNILOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LJHGFDHBFME account, JEDNDCJMLKI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<JEDNDCJMLKI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MIELLCNLKHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LJHGFDHBFME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40793C0", Offset = "0x4077DC0", VA = "0x1840793C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4079D40", Offset = "0x4078740", VA = "0x184079D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CFGBGFDLHJE DJLPOPDHEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FDPAPOKOKPL IEBFDLACMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NHAGLHPLIJK ECMBKKPKCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::HFIHKANKGNG<(long, long), IReadOnlyList<JEDNDCJMLKI>> LNGPBCOKBFF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31D5960", Offset = "0x31D4360", VA = "0x1831D5960")]
	[UnityEngine.Scripting.Preserve]
	public MIELLCNLKHH([LIKONNNLKGK(null)] FDPAPOKOKPL AIABFMEGFAB, [LIKONNNLKGK(null)] NHAGLHPLIJK BOJGLIGENPI, [LIKONNNLKGK(null)] CFGBGFDLHJE OHKCEODLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31D5810", Offset = "0x31D4210", VA = "0x1831D5810")]
	[AsyncStateMachine(typeof(DONHCBLLAAP))]
	public Task<IList<EDHBDDIBAFN>> JOMBHDMDPAK(long LCIEPBGBKGO, long HBNJLALONNE, bool GHIIHLIILBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x31D5520", Offset = "0x31D3F20", VA = "0x1831D5520")]
	private bool ADMKJHELOPE(DateTime? PJAANDALBFA, long LCIEPBGBKGO, long HBNJLALONNE, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x31D56D0", Offset = "0x31D40D0", VA = "0x1831D56D0")]
	[AsyncStateMachine(typeof(GHFBIHNILOM))]
	private Task<IReadOnlyList<(int, LJHGFDHBFME, JEDNDCJMLKI)>> GFJGHLAOJCA(IReadOnlyList<JEDNDCJMLKI> GGCACBKODOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NHAGLHPLIJK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LFLMMDJMDFC> DHMDPDCJALJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPPMCGGAEGO(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEOJKECKOLL(long LCIEPBGBKGO, long HBNJLALONNE, out LFLMMDJMDFC DMNFJMFHKLC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AAMPCPPNAGP(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DMNFJMFHKLC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCFPKNBIJPM(long LCIEPBGBKGO, long HBNJLALONNE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JJLJBFAGAMG : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MIADAOMEMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task HONMDABKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECLBBJAAFPK(Task IBCOHPONNBJ, string AGEKNEPBOBC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface AELGLLIMFJF : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOCLDNFCAPD> GCLDKLBGALL(LFLMMDJMDFC DMNFJMFHKLC);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PCAGCJDIMFJ(CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FCFMBENHFCD : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HFKOONKIHDN DNDDGBCMNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGEGHMHJBKL();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJLDLACCEAE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FMGAKNBAMFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface HKGOGNCIFMN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JBEJBACNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DBHKPDALIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NEJBEMPNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HOBBIKDCALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JENELKEOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool ECILJPNGNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IPNHFIADJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool CDDCIGEMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan AODPIECGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum OJDNDNJMAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PGPGCAPEPDK
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct CGNOGDJLAKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long IJNKGKEKKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long HJCAHMBDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OJDNDNJMAGF OGILDIMGIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception EGHNIGPIDKD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27D0510", Offset = "0x27CEF10", VA = "0x1827D0510")]
	public CGNOGDJLAKB(long IJNKGKEKKHE, long HJCAHMBDEEM, OJDNDNJMAGF OGILDIMGIOH, [CanBeNull] Exception EGHNIGPIDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27D04C0", Offset = "0x27CEEC0", VA = "0x1827D04C0")]
	public static CGNOGDJLAKB AENBDOEOIOH(OFCNMCIOFIM LPJAIJAHPFO, OJDNDNJMAGF OGILDIMGIOH, [Optional] Exception EGHNIGPIDKD)
	{
		return default(CGNOGDJLAKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void JMJJONCEBOH(CGNOGDJLAKB CBNFPKLEHDB);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface PEEFFMGKBAG : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CEPOPFLPLEF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JMJJONCEBOH AOIJHLGGGFB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JMJJONCEBOH FKFJALIHBBO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JMJJONCEBOH PMALMBPMHDL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PGPGCAPEPDK, bool> OHPCMLOENIC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MCAPCGKBMEM();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ADKBHCPGMLN(CGNOGDJLAKB CBNFPKLEHDB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCKBMFJEFEN(CGNOGDJLAKB CBNFPKLEHDB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KDLAHNFHJIB(CGNOGDJLAKB CBNFPKLEHDB);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OJDGGFLCMOI(PGPGCAPEPDK OBDLCOMHMDI, bool MEFHOIBEAII);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface HFHAFOIGEFC : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FONCHCAGBGD();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JENABHCBBBE();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJMJKHONEFD();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task CIPILANIGKL(JILMCFPJPGB GOKPFGBACOI, CancellationToken MIFCLBEAOPM);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface ILJHMLDGKCP : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JDMEBNLLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNILGHKCLDA(CIPILANIGKL AAAFJHCOPHH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface LGDLLPOFLJK : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus HKMCNMGCMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GEDACMLBIIF(OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, CancellationToken OMMIOIOKBMF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class MOKJKJJHPOB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x31D60A0", Offset = "0x31D4AA0", VA = "0x1831D60A0")]
	public static bool BHCDKPALBFD(this LGDLLPOFLJK KMLKPEPDMBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface BMMONKKCCCK : EOALMFOCEOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken LOBHPFNOHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AOONKACGDKK LCNJLEALFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	OGCACIFJDCP HNNBFCJJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	EOPCGGIHEON ABLGHPKODHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HADNAKAMMKO FAFEJOEAODH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EEHMBIIEFAB LJIBLPFKMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NJBDFOIOPMG LAPNCPHPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BKMGDOEHDIH NOOPFKJFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JJLJBFAGAMG COBJPNEFDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AELGLLIMFJF LNHAADMDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PEEFFMGKBAG JHEKMFNFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HFHAFOIGEFC DGDHAEECBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LGDLLPOFLJK EJENBPKLMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ILJHMLDGKCP KLDFKMKIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KIGMPHJHPJO EOFJOHKEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JJFNDJDCHPJ IKNGEFAPKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DPJHHKMHBNI HODKIOEIFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IIMPFBAAGHO FCEAPJMMCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AFNCHCIFHKO FPBOIKJDNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FHAMAIJMDNM DOEJPFDEFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NPFEPDLFMOF LLHFCAKALKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OLMODALHBEI HNLPAENGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEEBLMOBCCO CCHCEJAALHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KLLMDBOMELC DBMOOKIMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MEACFOIHIKJ GIKDLNJLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FCFMBENHFCD DGDCJDNIDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HKGOGNCIFMN LIOMPKHHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	EAMPFODMHGK MPIKPFLPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NHAGLHPLIJK LJKEJGNOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IJDDNPGBEOH(BGLENBCKMJG NPOMHAEFLOC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface KIGMPHJHPJO : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EADEEJBAKAP AGMLDLCGDGN(Guid HPGJMKCMOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FJEBMLODAAK(Guid HPGJMKCMOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIJLBFKAPGH(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFCNHMDCDFA(Guid HPGJMKCMOPJ, IOCLDNFCAPD BHCIOANCAGO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJMJKHONEFD(Guid HPGJMKCMOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(IOCLDNFCAPD, Task)> LMCDFNKJLIM(Guid HPGJMKCMOPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JJFNDJDCHPJ : FMGAKNBAMFM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DPJHHKMHBNI : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGEBDLINKDJ(IKENBFLEHKK BALNMHDNCIN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBKGBGCJJPJ(IKENBFLEHKK BALNMHDNCIN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NNHCJPLIFIC> BONIMKLBONK(CancellationToken KOAHEEBKLKJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate IOCLDNFCAPD BCAJLDMALOF(IEIHKFAAJEG IEDAIENJNOO, NNHCJPLIFIC NABLKJBKJGK);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IIMPFBAAGHO : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EADEEJBAKAP GAKKKEFAIMA(IKENBFLEHKK CPDANDAPHHP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJIFHCDLOOA(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface AFNCHCIFHKO : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOCLDNFCAPD> FPBOIKJDNEH(IKENBFLEHKK KDGOJEKMNED);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface FHAMAIJMDNM : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MPCCILKBHMP> BDBFDACKJCJ(HKNIJBILNIP BDBJGJIIKDE, OFCNMCIOFIM HPMGEPNNFHO, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OLMODALHBEI : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOCLDNFCAPD MPMKDGFCFDK(IEIHKFAAJEG IEDAIENJNOO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BEFGPHPFGEM(string CCJFOCJJBJG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NPFEPDLFMOF : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IKENBFLEHKK> BJJMPGAFBMA(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IKENBFLEHKK> KIBJAHAGNIP(CancellationToken OIMNLGJCBEC, MNALPKGIDEG MPFKFHENEIP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAACNKIHLLI IMNGPHLHNNL(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HAACNKIHLLI ADIADHJFFPI(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface AEEBLMOBCCO : FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOCLDNFCAPD MNPHBDHPKCD(IEIHKFAAJEG IEDAIENJNOO, NNHCJPLIFIC NABLKJBKJGK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOCLDNFCAPD PPPHHENGFMM(IEIHKFAAJEG EBBDANNDBJO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOCLDNFCAPD PNIGFKCFLHO(IEIHKFAAJEG EBBDANNDBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KLLMDBOMELC
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGEPEDJDEIE(IJOBCDJIKMP LLGAOJANJIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNGBKNJJCL(IJOBCDJIKMP LLGAOJANJIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOCBJDJBLHL(IJOBCDJIKMP LLGAOJANJIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPEAPDOOHBI(IJOBCDJIKMP LLGAOJANJIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class IJOBCDJIKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OFCNMCIOFIM KJLPBBIGAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> BNCCMLJFFFA;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public global::JIHOHILIMPL<string> CGIFABIIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public IJOBCDJIKMP(OFCNMCIOFIM GPGKFDLHFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27DE6D0", Offset = "0x27DD0D0", VA = "0x1827DE6D0")]
	public IJOBCDJIKMP KBAJKCGCKBG(string OGFDNCPKECB, string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27DE650", Offset = "0x27DD050", VA = "0x1827DE650")]
	public bool FLMHAAJPNKD(out IEnumerable<KeyValuePair<string, string>> ABOOCHHDJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2622D00", Offset = "0x2621700", VA = "0x182622D00")]
	public IJOBCDJIKMP BOCAIKCOEGE(global::JIHOHILIMPL<string> MJOCLEMBKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EAMPFODMHGK
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool DDNPKCKNEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string JCNIHDLAJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNBLPJBIJNP();

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BPFCNNOEDKB GLIDKCANJOJ(long FLLBKALBAKE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HELOOCDOGGH<KKANDLGEEGN, JHBALGJGKMA> JNCILGKEHEG(long FLLBKALBAKE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HELOOCDOGGH<KKANDLGEEGN, ALDNBFOLDOE> PMGMEGBHKKA(long FLLBKALBAKE);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::HELOOCDOGGH<long, BMJGADAGPOB> KNENLOFMDIA();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> GEPJJJIPFJL(byte[] DDEENGNPJOM, byte[] OGGAFKMEPLK, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EOALMFOCEOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BHCDKPALBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CBJOIHKBJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Task HJCCPJIJCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	BGLENBCKMJG PMDOACBFBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action CEPOPFLPLEF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JMJJONCEBOH AOIJHLGGGFB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JMJJONCEBOH FKFJALIHBBO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JMJJONCEBOH PMALMBPMHDL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PGPGCAPEPDK, bool> OHPCMLOENIC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JENABHCBBBE();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OMKLGDOBJIE HCLAOBLLPMJ();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LBOANMGHMJK KICAMIKFAAM();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<IOCLDNFCAPD> GCLDKLBGALL(LFLMMDJMDFC DADNHALGJFA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PCAGCJDIMFJ(CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HADNAKAMMKO
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CMEKFMNCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string LCBCJCEJJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOLCMJNDNNB(Scene CHLIBGONLEN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JMHCFBIEGPB(FKPJOOJGELL CAMKKNANBAI, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DKHOAACINBG();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DEEFNALDPBL
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int GOJGLCCKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool LCCPAPJOPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KFGNLOGHHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LKLLMHDAPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool IIDGNIMCACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool PKMDHJKIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	IEIHKFAAJEG CLMJPHEMKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool EBBFPBACNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOONKACGDKK FJBOINGPFOH(AOONKACGDKK IAAJAFHICGC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFLMBNDPBEO(AOONKACGDKK ONILLNPEPMK);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LALKKBANMEG(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JDDECIJGNOM(FLBEJMADIKL JALEHBMHNHI, [Optional] CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ILCCJDFFGDH(float PDMEDOHHOJO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHNMJMKHFNC(string IFCELFAKOBP);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<ABDMBHHIJNK> NHDIOPDMKKE();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IDisposable GINIEGENPCL(object PKDAKJPDDGD, ABDMBHHIJNK KPNCMNIOOEH);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JHBALGJGKMA JJAHPEJLCBF();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GLLKGJODDHD(int EDHKAJPADAK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NFJIMENMMPD();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PLEJIINJOMF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GCKKFIDELMD();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KMPHPPKJGMO(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task PBOOEFEPEOC(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<GKMBJALDMLM> DCCDJBAKLOE(DateTime NHKGMEFACMA, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> IPFKIOGBLOH(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FOCILKICJKP();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IEPIAGALNAB NANDCLHFPFG(OAGGKMECOKN CFEABAFCLMD, ALDNBFOLDOE CDNGHHDCBMA, IEnumerable<PersistenceView> HMBHDLPJNBB, ref NMGEBKPMOHP HCKNFNGDNJB);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FIKKNDHKNJI(ALDNBFOLDOE CDNGHHDCBMA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HDJAPDNLGOK(BADFNEBCNNH KHKLJBKIGHL, in IEPIAGALNAB COEEJIEMCIP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task HBPDEMFDKFM(ALDNBFOLDOE BPNGJGFCADO, bool JFFEDLPGLIB, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task DJHHBKENIDJ(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IOJJLENHCAP(long LCIEPBGBKGO, long HJCAHMBDEEM, LLBNMMPGAFE HOLCMHHFICL, DEIOFMFEJDI NKLMKCALAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LODNMBFNNBA(long LCIEPBGBKGO, long HJCAHMBDEEM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JLOGJKLMGBB(PersistenceView BBKPOOKEPCP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool EBLNLJEDJNM(PersistenceView KANBPIJHFNA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MNFKGHIPILO(BADFNEBCNNH KHKLJBKIGHL, KKCPFDJMIOB KENFHEPCHLB, out GILOJIOAKMI IOIBDMHLKOD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task MEMPIEDONFM(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void HPLMIBBMMDH();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable ALLGHJFIGJM();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KAEIJMLHAJE(ALDNBFOLDOE BPNGJGFCADO, KKCPFDJMIOB KENFHEPCHLB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> GFBNLELGOFL(OGCACIFJDCP KEHCECCODAM, CancellationToken OIMNLGJCBEC, HKNIJBILNIP BDBJGJIIKDE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PDHFFIDMJJA(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<HJAFOAIDLLN> JGKCGAHKOGE(BBMAAKKPCIB FLDKBCEOGMK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<LLBNMMPGAFE> BHKIBNEFEAI(long LCIEPBGBKGO, bool AIHBPMKDPBB, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JEDNDCJMLKI> LMHGJCPAADB(long LCIEPBGBKGO, long HJCAHMBDEEM, long DBCJFDIMEGJ, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<PDFKCDIAEML> NKFDIOEAIEC(string BPIEFHJHNGI, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PDFKCDIAEML> DFFNMPCAHBC(string BPIEFHJHNGI, long LCIEPBGBKGO, long HJCAHMBDEEM, string MLKOMNKNPAD, JJALEIDMEJJ.PDLFMNIBJJO GOKPFGBACOI, JJALEIDMEJJ.PDLFMNIBJJO OGGAFKMEPLK, int OMKBGDEDOFD);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KGKGALEFGNA();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool EJFNGLJNHLG();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool IAKKNNBJDOH(IEnumerable<GILOJIOAKMI> LMMNCIHPNAB);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void GIEMALKEIJD(List<GameObject> IEGMHCLPPDO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float APDAIMAGJIM();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BHOAIINAOMA(string HJEGLBELAHC, out Scene OOOMPFGDEEN);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> EKPEPFCICAM(string HJEGLBELAHC, LoadSceneMode DOCBLGPBAHC, bool LNHAKJNDEPA, HKNIJBILNIP MJOCLEMBKBO);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JPEGALFJBEG();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool HOLKIBOJCPG(ByteString EICPLPLLHGP);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HHEKJCFELLD();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void GBJNKHFBBJG();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void FMPNFPAHHPO(OFCNMCIOFIM GPJFLBNAMIO);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task FMLECFJOPPM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task GCDIADBINDC(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task IBPDEOJDLGF(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void ECPEEJGCPCE();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	IDisposable OLBCAJIOPME();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	EJOIEMHIKMM DOMLOJCOOOM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EJOIEMHIKMM
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LOJLHGDFLHF(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KCMOHKKKHKI(CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct IEPIAGALNAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> IPBIMDNFHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable OOOMJDEFCAE;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x27DD460", Offset = "0x27DBE60", VA = "0x1827DD460", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum GKMBJALDMLM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LPDKLMLIPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	OFCNMCIOFIM OHKGAEPFPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LLBNMMPGAFE LJLLOPOPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GJMMDEMBFND DLJDOFHMCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool CBIBFMMGKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool AIJPNPLGDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int GOJGLCCKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action ALBJFDMDBKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> KCNCNOOIPGA;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FMIFNDDEAIK();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.DCPOIDHHLDB> DLKIFMCPOCE(long FLLBKALBAKE, [Optional] CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.GMIPLJIDAAF> EKLGMHJDPDP();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JECKEFDDJLP();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OFCNMCIOFIM, BGLENBCKMJG) NGLMEMILOPI();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HEMLBBFAKKA GBLHFDBJBAB();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CFLKLMPIFJP(long FLLBKALBAKE);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MEACFOIHIKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCBFIPMOELO(out IEnumerable<int> JOBIIBBEOBM);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOGFOALJLGP(FGFCKLFBJIP MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJMAFKDHBP(FGFCKLFBJIP MIFCLBEAOPM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PPOFAMJKLLM
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ACACCJKFDGB(IOCLDNFCAPD HGOMAGBKKCM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BCJBONPMIBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPLFNKPIDAI(AIGGJPOCKII.HAKJPICFBOL FADOFACCPBI);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INJFOFCFDMD(AIGGJPOCKII.HAKJPICFBOL FADOFACCPBI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EEHMBIIEFAB : BCJBONPMIBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOCLDNFCAPD DOAMCAGKALL(IEIHKFAAJEG EBBDANNDBJO);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NJBDFOIOPMG : BCJBONPMIBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOCLDNFCAPD MPMKDGFCFDK(IEIHKFAAJEG DCELPOHIPLK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BPFCNNOEDKB
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> LHLBPODFONA(string MLKOMNKNPAD, long FLLBKALBAKE, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HELOOCDOGGH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::LFBADEDAHHF<byte[], KFANFMGGLGP>> DFKJFIFIFFM(TGetDataArg HACNEHKIBDN, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LFBADEDAHHF<global::IGMNBOHIBOC<TData>, KFANFMGGLGP> AHOLPIBIBMD(byte[] HIDEHJGLNHO);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class INJKABCABOH : BMMONKKCCCK, EOALMFOCEOE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct LKLLKPPKMIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public INJKABCABOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LFLMMDJMDFC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A150", Offset = "0x3C78B50", VA = "0x183C7A150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A370", Offset = "0x3C78D70", VA = "0x183C7A370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AKDMCJBINLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public INJKABCABOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CFF0", Offset = "0x3C6B9F0", VA = "0x183C6CFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OFPPDOAHFHH : IEnumerable<FMGAKNBAMFM>, IEnumerable, IEnumerator<FMGAKNBAMFM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private FMGAKNBAMFM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public INJKABCABOH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private FMGAKNBAMFM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public OFPPDOAHFHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C320", Offset = "0x3C7AD20", VA = "0x183C7C320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C760", Offset = "0x3C7B160", VA = "0x183C7C760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C6C0", Offset = "0x3C7B0C0", VA = "0x183C7C6C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FMGAKNBAMFM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C6C0", Offset = "0x3C7B0C0", VA = "0x183C7C6C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource PLEMPOFMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AOONKACGDKK ONILLNPEPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DMBCALLMNEB PMAJENCCMBO;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public OGCACIFJDCP HNNBFCJJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7270A0", Offset = "0x725AA0", VA = "0x1807270A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x79AB50", Offset = "0x799550", VA = "0x18079AB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EOPCGGIHEON ABLGHPKODHE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7270D0", Offset = "0x725AD0", VA = "0x1807270D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8093D0", Offset = "0x807DD0", VA = "0x1808093D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B2610", Offset = "0x7B1010", VA = "0x1807B2610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HADNAKAMMKO FAFEJOEAODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8093C0", Offset = "0x807DC0", VA = "0x1808093C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EEHMBIIEFAB LJIBLPFKMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x727040", Offset = "0x725A40", VA = "0x180727040", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7392A0", Offset = "0x737CA0", VA = "0x1807392A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public NJBDFOIOPMG LAPNCPHPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x727050", Offset = "0x725A50", VA = "0x180727050", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x748820", Offset = "0x747220", VA = "0x180748820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BKMGDOEHDIH NOOPFKJFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x74D1A0", Offset = "0x74BBA0", VA = "0x18074D1A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x748800", Offset = "0x747200", VA = "0x180748800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JJLJBFAGAMG COBJPNEFDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x82D960", Offset = "0x82C360", VA = "0x18082D960", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x905B10", Offset = "0x904510", VA = "0x180905B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AELGLLIMFJF LNHAADMDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC720", Offset = "0x7EB120", VA = "0x1807EC720", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x87A110", Offset = "0x878B10", VA = "0x18087A110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PEEFFMGKBAG JHEKMFNFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BB70", VA = "0x18074D170", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x905130", Offset = "0x903B30", VA = "0x180905130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HFHAFOIGEFC DGDHAEECBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x727060", Offset = "0x725A60", VA = "0x180727060", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x748810", Offset = "0x747210", VA = "0x180748810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LGDLLPOFLJK EJENBPKLMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x727070", Offset = "0x725A70", VA = "0x180727070", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x794FB0", Offset = "0x7939B0", VA = "0x180794FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public ILJHMLDGKCP KLDFKMKIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x727090", Offset = "0x725A90", VA = "0x180727090", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x82DBF0", Offset = "0x82C5F0", VA = "0x18082DBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KIGMPHJHPJO EOFJOHKEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x727080", Offset = "0x725A80", VA = "0x180727080", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x748830", Offset = "0x747230", VA = "0x180748830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JJFNDJDCHPJ IKNGEFAPKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x82B350", Offset = "0x829D50", VA = "0x18082B350", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x82BA50", Offset = "0x82A450", VA = "0x18082BA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DPJHHKMHBNI HODKIOEIFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9480", Offset = "0x7C7E80", VA = "0x1807C9480", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x82B360", Offset = "0x829D60", VA = "0x18082B360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IIMPFBAAGHO FCEAPJMMCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x82D920", Offset = "0x82C320", VA = "0x18082D920", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x82DA20", Offset = "0x82C420", VA = "0x18082DA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public AFNCHCIFHKO FPBOIKJDNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8774E0", Offset = "0x875EE0", VA = "0x1808774E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FHAMAIJMDNM DOEJPFDEFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82C000", Offset = "0x82AA00", VA = "0x18082C000", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x878230", Offset = "0x876C30", VA = "0x180878230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NPFEPDLFMOF LLHFCAKALKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x82BD00", Offset = "0x82A700", VA = "0x18082BD00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x82C030", Offset = "0x82AA30", VA = "0x18082C030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OLMODALHBEI HNLPAENGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x82BCE0", Offset = "0x82A6E0", VA = "0x18082BCE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x82C010", Offset = "0x82AA10", VA = "0x18082C010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AEEBLMOBCCO CCHCEJAALHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x82BCF0", Offset = "0x82A6F0", VA = "0x18082BCF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82C020", Offset = "0x82AA20", VA = "0x18082C020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public KLLMDBOMELC DBMOOKIMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x878220", Offset = "0x876C20", VA = "0x180878220", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF78550", Offset = "0xF76F50", VA = "0x180F78550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MEACFOIHIKJ GIKDLNJLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82A9E0", VA = "0x18082BFE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x82C180", Offset = "0x82AB80", VA = "0x18082C180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FCFMBENHFCD DGDCJDNIDII
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x82BFF0", Offset = "0x82A9F0", VA = "0x18082BFF0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x82C190", Offset = "0x82AB90", VA = "0x18082C190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HKGOGNCIFMN LIOMPKHHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA8BC70", Offset = "0xA8A670", VA = "0x180A8BC70", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA8B300", Offset = "0xA89D00", VA = "0x180A8B300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EAMPFODMHGK MPIKPFLPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA89DD0", Offset = "0xA887D0", VA = "0x180A89DD0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xF78810", Offset = "0xF77210", VA = "0x180F78810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public NHAGLHPLIJK LJKEJGNOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xF59E50", Offset = "0xF58850", VA = "0x180F59E50", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BGLENBCKMJG PMDOACBFBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xF5A210", Offset = "0xF58C10", VA = "0x180F5A210", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EA0", Offset = "0x9C48A0", VA = "0x1809C5EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool JMNIBOCFINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x27DFE40", Offset = "0x27DE840", VA = "0x1827DFE40", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool JLOJLADEKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x27DFB00", Offset = "0x27DE500", VA = "0x1827DFB00", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private Task POGMGJHPILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x27DF7D0", Offset = "0x27DE1D0", VA = "0x1827DF7D0", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CancellationToken FLCAFBABCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x27DF610", Offset = "0x27DE010", VA = "0x1827DF610", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private AOONKACGDKK LDBOJKECIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action GMAMLHBDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x27DF420", Offset = "0x27DDE20", VA = "0x1827DF420", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x27DF770", Offset = "0x27DE170", VA = "0x1827DF770", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event JMJJONCEBOH KNENCDPGOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x27DFE50", Offset = "0x27DE850", VA = "0x1827DFE50", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x27DFDE0", Offset = "0x27DE7E0", VA = "0x1827DFDE0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event JMJJONCEBOH AGDJJMBGEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x27DFAA0", Offset = "0x27DE4A0", VA = "0x1827DFAA0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x27DF690", Offset = "0x27DE090", VA = "0x1827DF690", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event JMJJONCEBOH LCJAJLBMOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x27DF820", Offset = "0x27DE220", VA = "0x1827DF820", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x27DF880", Offset = "0x27DE280", VA = "0x1827DF880", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<PGPGCAPEPDK, bool> PDNJIKNJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x27DF630", Offset = "0x27DE030", VA = "0x1827DF630", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x27DF8E0", Offset = "0x27DE2E0", VA = "0x1827DF8E0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x9C5EA0", Offset = "0x9C48A0", VA = "0x1809C5EA0", Slot = "34")]
	public void IJDDNPGBEOH(BGLENBCKMJG NPOMHAEFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x27DFEB0", Offset = "0x27DE8B0", VA = "0x1827DFEB0")]
	[UnityEngine.Scripting.Preserve]
	internal INJKABCABOH([LIKONNNLKGK(null)] AOONKACGDKK ONILLNPEPMK, [LIKONNNLKGK(null)] OGCACIFJDCP KEHCECCODAM, [LIKONNNLKGK(null)] EOPCGGIHEON LLLBGFHENIG, [LIKONNNLKGK(null)] DEEFNALDPBL NOHGMFJPJKL, [LIKONNNLKGK(null)] HADNAKAMMKO NPPPNEAAJPB, [LIKONNNLKGK(null)] EEHMBIIEFAB CCDCJPHJEHM, [LIKONNNLKGK(null)] NJBDFOIOPMG DIJGJGFMIIJ, [LIKONNNLKGK(null)] BKMGDOEHDIH IOMMEAGMHCE, [LIKONNNLKGK(null)] JJLJBFAGAMG CLODEIMPHIO, [LIKONNNLKGK(null)] AELGLLIMFJF HNACKNAPKOP, [LIKONNNLKGK(null)] PEEFFMGKBAG ADLONPJHLHJ, [LIKONNNLKGK(null)] HFHAFOIGEFC JGFNDHPFBOH, [LIKONNNLKGK(null)] LGDLLPOFLJK KMLKPEPDMBJ, [LIKONNNLKGK(null)] ILJHMLDGKCP LEDLKKDMDKA, [LIKONNNLKGK(null)] KIGMPHJHPJO EKNJIAIJLFK, [LIKONNNLKGK(null)] JJFNDJDCHPJ ANACADHKCDM, [LIKONNNLKGK(null)] DPJHHKMHBNI KLAJNPJNFGH, [LIKONNNLKGK(null)] IIMPFBAAGHO OGMILOCAJLG, [LIKONNNLKGK(null)] AFNCHCIFHKO ILBHLPCBMEE, [LIKONNNLKGK(null)] FHAMAIJMDNM LAGCFKDBBCN, [LIKONNNLKGK(null)] OLMODALHBEI PAHCHPMOCNE, [LIKONNNLKGK(null)] NPFEPDLFMOF BEELBGNKLAA, [LIKONNNLKGK(null)] AEEBLMOBCCO MJCHNIAODLH, [LIKONNNLKGK(null)] KLLMDBOMELC KPABCGELMLL, [LIKONNNLKGK(null)] MEACFOIHIKJ PMOEGAOHFBL, [LIKONNNLKGK(null)] HKGOGNCIFMN ELAELJDAGOI, [LIKONNNLKGK(null)] EAMPFODMHGK FACLDIPADPH, [LIKONNNLKGK(null)] NHAGLHPLIJK EJJOFJIJONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x27DF9B0", Offset = "0x27DE3B0", VA = "0x1827DF9B0")]
	private void KADCCJJCHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x27DF480", Offset = "0x27DDE80", VA = "0x1827DF480", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x27DF350", Offset = "0x27DDD50", VA = "0x1827DF350", Slot = "48")]
	private void BBFPHKNHGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x27DF3A0", Offset = "0x27DDDA0", VA = "0x1827DF3A0", Slot = "49")]
	private OMKLGDOBJIE CKLDBAOKMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x27DF6F0", Offset = "0x27DE0F0", VA = "0x1827DF6F0", Slot = "50")]
	private LBOANMGHMJK GEGDCHKMFOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x27DFB80", Offset = "0x27DE580", VA = "0x1827DFB80", Slot = "51")]
	[AsyncStateMachine(typeof(LKLLKPPKMIA))]
	private Task<IOCLDNFCAPD> NBLODFBBBMI(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x27DFCC0", Offset = "0x27DE6C0", VA = "0x1827DFCC0", Slot = "52")]
	[AsyncStateMachine(typeof(AKDMCJBINLN))]
	private Task NCAPNNBMANM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x27DF940", Offset = "0x27DE340", VA = "0x1827DF940")]
	[IteratorStateMachine(typeof(OFPPDOAHFHH))]
	private IEnumerable<FMGAKNBAMFM> JGJNDKHAHLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x27DF2F0", Offset = "0x27DDCF0", VA = "0x1827DF2F0")]
	[CompilerGenerated]
	private void AFDJLBJCCKN(FMGAKNBAMFM AFCHMEJMNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KHCFHOJJGOI : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x17F1D90", Offset = "0x17F0790", VA = "0x1817F1D90")]
	public KHCFHOJJGOI(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class JKNMKAKFPMO : FKFAKKIKGJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IBLADCAONEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JKNMKAKFPMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C75D30", Offset = "0x3C74730", VA = "0x183C75D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C760C0", Offset = "0x3C74AC0", VA = "0x183C760C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public JKNMKAKFPMO(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x27E3840", Offset = "0x27E2240", VA = "0x1827E3840", Slot = "4")]
	[AsyncStateMachine(typeof(IBLADCAONEB))]
	public Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x27E3960", Offset = "0x27E2360", VA = "0x1827E3960")]
	[CompilerGenerated]
	private object LLMCGDDGDMA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class LGEIMBCNGAC : FKFAKKIKGJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KLIGAHBBAIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LGEIMBCNGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x407E030", Offset = "0x407CA30", VA = "0x18407E030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x407E680", Offset = "0x407D080", VA = "0x18407E680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const float KDGCOFJJDHL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x31D29D0", Offset = "0x31D13D0", VA = "0x1831D29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public LGEIMBCNGAC(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x31D2890", Offset = "0x31D1290", VA = "0x1831D2890", Slot = "4")]
	[AsyncStateMachine(typeof(KLIGAHBBAIM))]
	public Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x31D2A20", Offset = "0x31D1420", VA = "0x1831D2A20")]
	[CompilerGenerated]
	private object PGEAPHLLEGB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class NMIFDGELOIF : FKFAKKIKGJC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PKHBCMPPHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public NMIFDGELOIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.GMIPLJIDAAF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OFCNMCIOFIM newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PKHBCMPPHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x40836E0", Offset = "0x40820E0", VA = "0x1840836E0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4083830", Offset = "0x4082230", VA = "0x184083830")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x40838A0", Offset = "0x40822A0", VA = "0x1840838A0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct HLMHOOCKPFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NMIFDGELOIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PKHBCMPPHHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.GMIPLJIDAAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x407A9D0", Offset = "0x40793D0", VA = "0x18407A9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x407B2C0", Offset = "0x4079CC0", VA = "0x18407B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private const float KDGCOFJJDHL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x31D7620", Offset = "0x31D6020", VA = "0x1831D7620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public NMIFDGELOIF(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x31D74E0", Offset = "0x31D5EE0", VA = "0x1831D74E0", Slot = "4")]
	[AsyncStateMachine(typeof(HLMHOOCKPFJ))]
	public Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface FKFAKKIKGJC
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct IBHBEHKIOOK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MNKEDBOPHLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public BMMONKKCCCK manager;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MNKEDBOPHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B500", Offset = "0x3C79F00", VA = "0x183C7B500")]
		internal Task <CreateTask>b__0(JILMCFPJPGB data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct JLJIFHMKNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public IBHBEHKIOOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LFLMMDJMDFC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<GKMBJALDMLM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C779D0", Offset = "0x3C763D0", VA = "0x183C779D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C77EE0", Offset = "0x3C768E0", VA = "0x183C77EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KMKALKIAILB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public IBHBEHKIOOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C79170", Offset = "0x3C77B70", VA = "0x183C79170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken OIMNLGJCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly BMMONKKCCCK CMIHNHHBGOO;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private OGCACIFJDCP HNNBFCJJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x27DD090", Offset = "0x27DBA90", VA = "0x1827DD090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x27DD160", Offset = "0x27DBB60", VA = "0x1827DD160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x27DD0E0", Offset = "0x27DBAE0", VA = "0x1827DD0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private AELGLLIMFJF LNHAADMDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x27DD040", Offset = "0x27DBA40", VA = "0x1827DD040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27DD420", Offset = "0x27DBE20", VA = "0x1827DD420")]
	public IBHBEHKIOOK(CancellationToken OIMNLGJCBEC, BMMONKKCCCK CMIHNHHBGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27DCCE0", Offset = "0x27DB6E0", VA = "0x1827DCCE0")]
	public static CIPILANIGKL BGCBCDPLHMC(BMMONKKCCCK CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27DD1B0", Offset = "0x27DBBB0", VA = "0x1827DD1B0")]
	[AsyncStateMachine(typeof(JLJIFHMKNOP))]
	public Task<bool> KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27DCDA0", Offset = "0x27DB7A0", VA = "0x1827DCDA0")]
	private bool BHGAGCCICJC(out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27DCF40", Offset = "0x27DB940", VA = "0x1827DCF40")]
	[AsyncStateMachine(typeof(KMKALKIAILB))]
	private Task FINPOABKCBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27DD2E0", Offset = "0x27DBCE0", VA = "0x1827DD2E0")]
	private Task<GKMBJALDMLM> LNMAAHJNNAK(LFLMMDJMDFC AAMNOOAFFKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct EADEEJBAKAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly KIGMPHJHPJO EKNJIAIJLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid HPGJMKCMOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private Task<(IOCLDNFCAPD, Task)> EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x27D3EF0", Offset = "0x27D28F0", VA = "0x1827D3EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2351650", Offset = "0x2350050", VA = "0x182351650")]
	public EADEEJBAKAP(KIGMPHJHPJO EKNJIAIJLFK, Guid HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x27D3FC0", Offset = "0x27D29C0", VA = "0x1827D3FC0")]
	public TaskAwaiter<(IOCLDNFCAPD, Task)> ONFHCEEPMHH()
	{
		return default(TaskAwaiter<(IOCLDNFCAPD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E20", Offset = "0x27D2820", VA = "0x1827D3E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct MFCNJKEINOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(IOCLDNFCAPD, Task)> LMHGKFCOPCI;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task<(IOCLDNFCAPD, Task)> EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x31D51F0", Offset = "0x31D3BF0", VA = "0x1831D51F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x31D5230", Offset = "0x31D3C30", VA = "0x1831D5230")]
	public MFCNJKEINOM(TimeSpan AOEGDFNBHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x31D5110", Offset = "0x31D3B10", VA = "0x1831D5110")]
	public void JANOFOGBMBA(Task FGBJPNAPJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x31D4FA0", Offset = "0x31D39A0", VA = "0x1831D4FA0")]
	public void ANPBGMHLADF(IOCLDNFCAPD HGOMAGBKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x31D50C0", Offset = "0x31D3AC0", VA = "0x1831D50C0")]
	public void IEGBHPHADMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x31D5030", Offset = "0x31D3A30", VA = "0x1831D5030")]
	internal void BBPEMCEONBA(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BIBKBMMMADB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CEHNAHJGCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public JEDNDCJMLKI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public CEHNAHJGCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x31C56F0", Offset = "0x31C40F0", VA = "0x1831C56F0")]
		internal bool <Create>b__0(GJMMDEMBFND s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x27CE870", Offset = "0x27CD270", VA = "0x1827CE870")]
	public static MPCCILKBHMP IDIKGABNBEI(long IJNKGKEKKHE, long HJCAHMBDEEM, string BPIEFHJHNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x27CE600", Offset = "0x27CD000", VA = "0x1827CE600")]
	public static MPCCILKBHMP IDIKGABNBEI(long IJNKGKEKKHE, long HJCAHMBDEEM, KKANDLGEEGN DDEENGNPJOM, long DBCJFDIMEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x27CE6C0", Offset = "0x27CD0C0", VA = "0x1827CE6C0")]
	public static MPCCILKBHMP IDIKGABNBEI(HJAFOAIDLLN AHIOHOIAHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x27CE3C0", Offset = "0x27CCDC0", VA = "0x1827CE3C0")]
	public static MPCCILKBHMP IDIKGABNBEI(LLBNMMPGAFE CFMENLBHIHE, JEDNDCJMLKI EPAKNJPBBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x27CE2C0", Offset = "0x27CCCC0", VA = "0x1827CE2C0")]
	public static MPCCILKBHMP HDKCHBAKMKL(this MPCCILKBHMP GJNIFGAPEDN, LLBNMMPGAFE EEJKNHACFJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x27CE140", Offset = "0x27CCB40", VA = "0x1827CE140")]
	public static MPCCILKBHMP ECCOFHHAKPJ(this MPCCILKBHMP GJNIFGAPEDN, JEDNDCJMLKI GBHNFCEODME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class HKLGEGNLJEH : JJLJBFAGAMG, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct OKLODFALKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public HKLGEGNLJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CDE0", Offset = "0x3C7B7E0", VA = "0x183C7CDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly FGFCKLFBJIP OKFEKEHMPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string EOLNGGMOAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task CNBAKEKBAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool MIADAOMEMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x27DBFE0", Offset = "0x27DA9E0", VA = "0x1827DBFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task HONMDABKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x27DC190", Offset = "0x27DAB90", VA = "0x1827DC190", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x27DC010", Offset = "0x27DAA10", VA = "0x1827DC010", Slot = "6")]
	public void ECLBBJAAFPK(Task IBCOHPONNBJ, string AGEKNEPBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x27DC1F0", Offset = "0x27DABF0", VA = "0x1827DC1F0")]
	[AsyncStateMachine(typeof(OKLODFALKNA))]
	private Task JHNDEDDMHFM(Task ALBJOHMCHFL, string AGEKNEPBOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x27DC320", Offset = "0x27DAD20", VA = "0x1827DC320")]
	public HKLGEGNLJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class AFAHEJDCNCM : FCFMBENHFCD, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool BEGCOEDHJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HFKOONKIHDN AHHNIAMDDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private HKGOGNCIFMN ELAELJDAGOI;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HFKOONKIHDN DNDDGBCMNOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x27C7120", Offset = "0x27C5B20", VA = "0x1827C7120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x27C7210", Offset = "0x27C5C10", VA = "0x1827C7210", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x27C6F20", Offset = "0x27C5920", VA = "0x1827C6F20", Slot = "5")]
	public void BGEGHMHJBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x27C70E0", Offset = "0x27C5AE0", VA = "0x1827C70E0", Slot = "6")]
	public void NJLDLACCEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x27C7190", Offset = "0x27C5B90", VA = "0x1827C7190")]
	private Task HHJLGOIFLPE(PGONHDFGHDL PJEHHDIBMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x27C70E0", Offset = "0x27C5AE0", VA = "0x1827C70E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public AFAHEJDCNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class EAFCHOELAMH : HKGOGNCIFMN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class AFGANNAOFGA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly LGIHGHKPCKA FBJGDFFOGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly string OGFDNCPKECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly T LGCPJJBBDLH;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public T NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7B6C20", Offset = "0x7B5620", VA = "0x1807B6C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2AA87C0", Offset = "0x2AA71C0", VA = "0x182AA87C0")]
		public AFGANNAOFGA(LGIHGHKPCKA FBJGDFFOGDE, string OGFDNCPKECB, T LGCPJJBBDLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2AA81B0", Offset = "0x2AA6BB0", VA = "0x182AA81B0")]
		private void OGGFNKOJIIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly LGIHGHKPCKA FBJGDFFOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly AFGANNAOFGA<TimeSpan> JCFJEALCCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly AFGANNAOFGA<TimeSpan> HCMCNKGCLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly AFGANNAOFGA<TimeSpan> EIANHMOEBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly AFGANNAOFGA<TimeSpan> DPNNKPIDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly AFGANNAOFGA<bool> LGJIDEKGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly AFGANNAOFGA<bool> ODJCDPOGLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly AFGANNAOFGA<bool> AOLHAAEKCEM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private const string FABGEDKGNBO = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan JBEJBACNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x27D43E0", Offset = "0x27D2DE0", VA = "0x1827D43E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan DBHKPDALIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x27D4320", Offset = "0x27D2D20", VA = "0x1827D4320", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan NEJBEMPNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x27D4160", Offset = "0x27D2B60", VA = "0x1827D4160", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan HOBBIKDCALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x27D4360", Offset = "0x27D2D60", VA = "0x1827D4360", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool JENELKEOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x27D43A0", Offset = "0x27D2DA0", VA = "0x1827D43A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool ECILJPNGNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x27D41A0", Offset = "0x27D2BA0", VA = "0x1827D41A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IPNHFIADJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x27D41E0", Offset = "0x27D2BE0", VA = "0x1827D41E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CDDCIGEMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x27D4220", Offset = "0x27D2C20", VA = "0x1827D4220", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan AODPIECGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x27D4010", Offset = "0x27D2A10", VA = "0x1827D4010", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x27D4420", Offset = "0x27D2E20", VA = "0x1827D4420")]
	[UnityEngine.Scripting.Preserve]
	public EAFCHOELAMH([LIKONNNLKGK(null)] LGIHGHKPCKA FBJGDFFOGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class PHOAGNLADGN : PEEFFMGKBAG, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GIFIIABGNNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CGNOGDJLAKB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GIFIIABGNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x407A230", Offset = "0x4078C30", VA = "0x18407A230")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action CEPOPFLPLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x31DAA30", Offset = "0x31D9430", VA = "0x1831DAA30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x31DA8F0", Offset = "0x31D92F0", VA = "0x1831DA8F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event JMJJONCEBOH AOIJHLGGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x31DAD80", Offset = "0x31D9780", VA = "0x1831DAD80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x31DA340", Offset = "0x31D8D40", VA = "0x1831DA340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event JMJJONCEBOH FKFJALIHBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x31DA850", Offset = "0x31D9250", VA = "0x1831DA850", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x31DAED0", Offset = "0x31D98D0", VA = "0x1831DAED0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event JMJJONCEBOH PMALMBPMHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x31DA4B0", Offset = "0x31D8EB0", VA = "0x1831DA4B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x31DA990", Offset = "0x31D9390", VA = "0x1831DA990", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<PGPGCAPEPDK, bool> OHPCMLOENIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x31DA3E0", Offset = "0x31D8DE0", VA = "0x1831DA3E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x31DA550", Offset = "0x31D8F50", VA = "0x1831DA550", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "19")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x31DAB00", Offset = "0x31D9500", VA = "0x1831DAB00", Slot = "14")]
	public void MCAPCGKBMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x31DA310", Offset = "0x31D8D10", VA = "0x1831DA310", Slot = "15")]
	public void ADKBHCPGMLN(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x31DA480", Offset = "0x31D8E80", VA = "0x1831DA480", Slot = "16")]
	public void DCKBMFJEFEN(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x31DAAD0", Offset = "0x31D94D0", VA = "0x1831DAAD0", Slot = "17")]
	public void KDLAHNFHJIB(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x31DAE20", Offset = "0x31D9820", VA = "0x1831DAE20", Slot = "18")]
	public void OJDGGFLCMOI(PGPGCAPEPDK OBDLCOMHMDI, bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x31DA5F0", Offset = "0x31D8FF0", VA = "0x1831DA5F0")]
	private void GODLCEDBDHK(JMJJONCEBOH KPNCMNIOOEH, CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public PHOAGNLADGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class LCBHGAAOJAK : HFHAFOIGEFC, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct LIKHLPKLCEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public LCBHGAAOJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x407F5F0", Offset = "0x407DFF0", VA = "0x18407F5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct EJHBOHIHMCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LCBHGAAOJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4078400", Offset = "0x4076E00", VA = "0x184078400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class HPDCCIBNEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HPDCCIBNEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x407BA20", Offset = "0x407A420", VA = "0x18407BA20")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct EFCMNEDJCNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public LCBHGAAOJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private HPDCCIBNEEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4077BE0", Offset = "0x40765E0", VA = "0x184077BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4078180", Offset = "0x4076B80", VA = "0x184078180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class OMMJEMBMFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OMMJEMBMFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4082BB0", Offset = "0x40815B0", VA = "0x184082BB0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FKFAKKIKGJC[] CKPFJANNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private CancellationTokenSource FFLFGHGEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int IAFBNIHHEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x31D2120", Offset = "0x31D0B20", VA = "0x1831D2120", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D10", Offset = "0x31D0710", VA = "0x1831D1D10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x31D1E30", Offset = "0x31D0830", VA = "0x1831D1E30", Slot = "6")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x31D1FC0", Offset = "0x31D09C0", VA = "0x1831D1FC0", Slot = "5")]
	public void JENABHCBBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D20", Offset = "0x31D0720", VA = "0x1831D1D20", Slot = "4")]
	[AsyncStateMachine(typeof(LIKHLPKLCEK))]
	public Task FONCHCAGBGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x31D18A0", Offset = "0x31D02A0", VA = "0x1831D18A0")]
	private void ACGIMOOKGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x31D25A0", Offset = "0x31D0FA0", VA = "0x1831D25A0")]
	[AsyncStateMachine(typeof(EJHBOHIHMCN))]
	private Task MCEGABOLFPN(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x31D2450", Offset = "0x31D0E50", VA = "0x1831D2450")]
	[AsyncStateMachine(typeof(EFCMNEDJCNA))]
	private Task<bool> LCAJEKLJGCJ(int EGNHJGKABLC, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x31D22F0", Offset = "0x31D0CF0", VA = "0x1831D22F0")]
	private void KBHFCONBODH(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x31D21A0", Offset = "0x31D0BA0", VA = "0x1831D21A0")]
	private void KAOADDEJCDH(int EGNHJGKABLC, bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x31D26D0", Offset = "0x31D10D0", VA = "0x1831D26D0")]
	private void OPOOJMBLKNC(int EGNHJGKABLC, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x31D1C00", Offset = "0x31D0600", VA = "0x1831D1C00")]
	private void ANDDJDEFHEH(CancellationToken OIMNLGJCBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public LCBHGAAOJAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[UnityEngine.Scripting.Preserve]
internal class KFIBGICEOKH : ILJHMLDGKCP, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct EGMBNMIJGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KFIBGICEOKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public JILMCFPJPGB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3C715E0", Offset = "0x3C6FFE0", VA = "0x183C715E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DPIEJOMLOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public KFIBGICEOKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public JILMCFPJPGB roomData;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DPIEJOMLOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3C70410", Offset = "0x3C6EE10", VA = "0x183C70410")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct JDNACDCEELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CIPILANIGKL taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3C774E0", Offset = "0x3C75EE0", VA = "0x183C774E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct JBNJFMNNIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public KFIBGICEOKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3C77280", Offset = "0x3C75C80", VA = "0x183C77280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly HashSet<CIPILANIGKL> IALAJJGOLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private EOPCGGIHEON LLLBGFHENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ABDMBHHIJNK KOGKAPEENDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NMLPMEFFLFG AAMKNMPBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private IDisposable LLKOOHEMFMF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JDMEBNLLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x27E4E00", Offset = "0x27E3800", VA = "0x1827E4E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	internal Task EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x27E5080", Offset = "0x27E3A80", VA = "0x1827E5080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x27E4E10", Offset = "0x27E3810", VA = "0x1827E4E10", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x27E4B10", Offset = "0x27E3510", VA = "0x1827E4B10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x27E4B70", Offset = "0x27E3570", VA = "0x1827E4B70", Slot = "5")]
	public bool FNILGHKCLDA(CIPILANIGKL AAAFJHCOPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x27E48D0", Offset = "0x27E32D0", VA = "0x1827E48D0")]
	private void DCLLMBAALNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x27E4110", Offset = "0x27E2B10", VA = "0x1827E4110")]
	private void CBECEBDMOGJ(JILMCFPJPGB GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x27E3FF0", Offset = "0x27E29F0", VA = "0x1827E3FF0")]
	[AsyncStateMachine(typeof(EGMBNMIJGOC))]
	private Task BFEEPNAOACJ(JILMCFPJPGB GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x27E5090", Offset = "0x27E3A90", VA = "0x1827E5090")]
	private Func<CancellationToken, List<Task>> NPJOINELPMO(JILMCFPJPGB GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x27E43B0", Offset = "0x27E2DB0", VA = "0x1827E43B0")]
	private List<Task> CFLLLPBGAIE(JILMCFPJPGB GOKPFGBACOI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x27E4BD0", Offset = "0x27E35D0", VA = "0x1827E4BD0")]
	[AsyncStateMachine(typeof(JDNACDCEELB))]
	private Task GGBMEOMIHIN(CIPILANIGKL HCNJFIFOHOK, JILMCFPJPGB HIDEHJGLNHO, CancellationToken MIFCLBEAOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x27E5170", Offset = "0x27E3B70", VA = "0x1827E5170")]
	[AsyncStateMachine(typeof(JBNJFMNNIDF))]
	private Task OBEEGLDMDON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x27E4D00", Offset = "0x27E3700", VA = "0x1827E4D00")]
	private void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x27E5270", Offset = "0x27E3C70", VA = "0x1827E5270")]
	public KFIBGICEOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.NoEngine.Common.Preserve]
internal class BFAAAHEGJDN : LGDLLPOFLJK, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MAPHANNBMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BGLENBCKMJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x31D4A30", Offset = "0x31D3430", VA = "0x1831D4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct JJEFEMHBOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BGLENBCKMJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private global::JIHOHILIMPL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private MNALPKGIDEG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private IJOBCDJIKMP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x31CF390", Offset = "0x31CDD90", VA = "0x1831CF390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class ABPJHNFPMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Task<MPCCILKBHMP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ABPJHNFPMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		internal Task<MPCCILKBHMP> <ConnectToRoomAndRunLoadLogic>b__0(HKNIJBILNIP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct IMDHLMNKCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public BGLENBCKMJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public MNALPKGIDEG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private ABPJHNFPMPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private KHLCNBENFGM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private HKNIJBILNIP <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private IIFMDBOLPBK <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task<Matchmaking.DCPOIDHHLDB> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<Matchmaking.DCPOIDHHLDB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private CancellationTokenSource <photonJoinedTokenSource>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private CancellationToken <photonJoinedToken>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Task <roomLoadTask>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter<MPCCILKBHMP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x31CD6E0", Offset = "0x31CC0E0", VA = "0x1831CD6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct FAPLMMEHFOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private HKNIJBILNIP <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private HKNIJBILNIP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x31C8A60", Offset = "0x31C7460", VA = "0x1831C8A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct GJIBCIMDICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private AOONKACGDKK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x31C9F60", Offset = "0x31C8960", VA = "0x1831C9F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct AKPDNPNJPJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<Matchmaking.DCPOIDHHLDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<Matchmaking.DCPOIDHHLDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x31C4C30", Offset = "0x31C3630", VA = "0x1831C4C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x31C4FD0", Offset = "0x31C39D0", VA = "0x1831C4FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct DEKLGBABGKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Matchmaking.DCPOIDHHLDB serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public MNALPKGIDEG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter<MDCHGPLJCHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x31C61D0", Offset = "0x31C4BD0", VA = "0x1831C61D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class HBBBFOAEJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HBBBFOAEJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x31CBC10", Offset = "0x31CA610", VA = "0x1831CBC10")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x31CBB10", Offset = "0x31CA510", VA = "0x1831CBB10")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DJDEAAEHLMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private HBBBFOAEJDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x31C68F0", Offset = "0x31C52F0", VA = "0x1831C68F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct HMNDOPPICIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public MNALPKGIDEG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public MPCCILKBHMP initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public OFCNMCIOFIM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public KHLCNBENFGM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private HKNIJBILNIP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x31CC180", Offset = "0x31CAB80", VA = "0x1831CC180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct DOACNFMHIMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HKNIJBILNIP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x31C73F0", Offset = "0x31C5DF0", VA = "0x1831C73F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct GKCNFKFPPCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x31CA380", Offset = "0x31C8D80", VA = "0x1831CA380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MLPHBHADJGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private DateTime <start>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x31D5B10", Offset = "0x31D4510", VA = "0x1831D5B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct PNIJPPGDOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x31DBB90", Offset = "0x31DA590", VA = "0x1831DBB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct NIIFPFNJILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public BFAAAHEGJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x31D70A0", Offset = "0x31D5AA0", VA = "0x1831D70A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class IODIDLMMDNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IODIDLMMDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x31CF1C0", Offset = "0x31CDBC0", VA = "0x1831CF1C0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class DIAPNNELMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DIAPNNELMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x31C6850", Offset = "0x31C5250", VA = "0x1831C6850")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class LMOLCHIDFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LMOLCHIDFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x31D3AF0", Offset = "0x31D24F0", VA = "0x1831D3AF0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class KNGFIJDLGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KNGFIJDLGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x31D0260", Offset = "0x31CEC60", VA = "0x1831D0260")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string KKGJPAPKCEK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string EBANFBHLGLM;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly string OABPHEIEENH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static readonly Guid BIEODAANKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private EOPCGGIHEON LLLBGFHENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private HFHAFOIGEFC JGFNDHPFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private JJLJBFAGAMG CLODEIMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PEEFFMGKBAG ADLONPJHLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private HKGOGNCIFMN ELAELJDAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private IDisposable LLKOOHEMFMF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TaskStatus HKMCNMGCMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA41530", Offset = "0xA3FF30", VA = "0x180A41530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA41540", Offset = "0xA3FF40", VA = "0x180A41540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x27CCE60", Offset = "0x27CB860", VA = "0x1827CCE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x27CD1B0", Offset = "0x27CBBB0", VA = "0x1827CD1B0", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x27CB8B0", Offset = "0x27CA2B0", VA = "0x1827CB8B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x27CC040", Offset = "0x27CAA40", VA = "0x1827CC040", Slot = "5")]
	[AsyncStateMachine(typeof(MAPHANNBMHF))]
	public Task GEDACMLBIIF(OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x27CDB40", Offset = "0x27CC540", VA = "0x1827CDB40")]
	[AsyncStateMachine(typeof(JJEFEMHBOOO))]
	private Task NJHNGCLNLEA(OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x27CCEB0", Offset = "0x27CB8B0", VA = "0x1827CCEB0")]
	private static void JANKOFDMGBF(OFCNMCIOFIM HPMGEPNNFHO, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x27CAF10", Offset = "0x27C9910", VA = "0x1827CAF10")]
	private static void CGMGAIFIGLA(IJOBCDJIKMP JODAFCLPAAB, Exception MEIDENAJCEE, [Optional] List<int> DCINMOBAJKD, int IAFBNIHHEFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x27CBD80", Offset = "0x27CA780", VA = "0x1827CBD80")]
	[AsyncStateMachine(typeof(IMDHLMNKCNE))]
	private Task GBADMCLDAGE(HKNIJBILNIP MJOCLEMBKBO, OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, MNALPKGIDEG JBIOPHKABBJ, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x27CB990", Offset = "0x27CA390", VA = "0x1827CB990")]
	private void FFOHJMMKBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x27CADD0", Offset = "0x27C97D0", VA = "0x1827CADD0")]
	[AsyncStateMachine(typeof(FAPLMMEHFOC))]
	private Task CFKKGLDIBEB(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x27CCA10", Offset = "0x27CB410", VA = "0x1827CCA10")]
	private void HNBDLLCGFEC(OFCNMCIOFIM HPMGEPNNFHO, CancellationToken OMMIOIOKBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x27CC190", Offset = "0x27CAB90", VA = "0x1827CC190")]
	private void GILFLCCJJPA(OFCNMCIOFIM HPMGEPNNFHO, MNALPKGIDEG JBIOPHKABBJ, OperationCanceledException MCDKCFEBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x27CC5B0", Offset = "0x27CAFB0", VA = "0x1827CC5B0")]
	private void HDNEMKJHPGM(OFCNMCIOFIM HPMGEPNNFHO, MNALPKGIDEG JBIOPHKABBJ, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x27CA210", Offset = "0x27C8C10", VA = "0x1827CA210")]
	private void AGHFGKIJJGK(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x27CDE10", Offset = "0x27CC810", VA = "0x1827CDE10")]
	private static CGNOGDJLAKB PELPLHIHBJD(OFCNMCIOFIM HPMGEPNNFHO)
	{
		return default(CGNOGDJLAKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x27CCD60", Offset = "0x27CB760", VA = "0x1827CCD60")]
	[AsyncStateMachine(typeof(GJIBCIMDICK))]
	private Task IEHPKOOIIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x27CB750", Offset = "0x27CA150", VA = "0x1827CB750")]
	[AsyncStateMachine(typeof(AKPDNPNJPJF))]
	private Task<Matchmaking.DCPOIDHHLDB> DLKIFMCPOCE(OFCNMCIOFIM HPMGEPNNFHO, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x27CC460", Offset = "0x27CAE60", VA = "0x1827CC460")]
	private static MDCHGPLJCHG GJJOLIDMLFG(OFCNMCIOFIM HPMGEPNNFHO, Matchmaking.DCPOIDHHLDB PFNIIHBDEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x27CAB60", Offset = "0x27C9560", VA = "0x1827CAB60")]
	[AsyncStateMachine(typeof(DEKLGBABGKG))]
	private Task BKEJPKNEFHJ(OFCNMCIOFIM HPMGEPNNFHO, Matchmaking.DCPOIDHHLDB PFNIIHBDEGI, MNALPKGIDEG JBIOPHKABBJ, HKNIJBILNIP MJOCLEMBKBO, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x27CBC20", Offset = "0x27CA620", VA = "0x1827CBC20")]
	[AsyncStateMachine(typeof(DJDEAAEHLMO))]
	private Task FOPKDCBIKCB(OFCNMCIOFIM HPMGEPNNFHO, CancellationTokenSource FJKCOOPILJF, Task COFGCDFOCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x27CA4B0", Offset = "0x27C8EB0", VA = "0x1827CA4B0")]
	[AsyncStateMachine(typeof(HMNDOPPICIF))]
	private Task AIAFNGFMDMP(MPCCILKBHMP OIIJKAFJJPD, KHLCNBENFGM EHILNCIAEPD, OFCNMCIOFIM IBCMJGEPEAF, MNALPKGIDEG JDKPIJMGDDM, HKNIJBILNIP MJOCLEMBKBO, CancellationToken KOGPGEEPLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x27CD5D0", Offset = "0x27CBFD0", VA = "0x1827CD5D0")]
	private MNALPKGIDEG KLOCEDNMENM(MNALPKGIDEG JDKPIJMGDDM, ref CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x27CBAE0", Offset = "0x27CA4E0", VA = "0x1827CBAE0")]
	[AsyncStateMachine(typeof(DOACNFMHIMO))]
	private Task FLHLODBFKHM(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x27CDA00", Offset = "0x27CC400", VA = "0x1827CDA00")]
	[AsyncStateMachine(typeof(GKCNFKFPPCC))]
	private Task NCFDPCPEENP(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x27CAA20", Offset = "0x27C9420", VA = "0x1827CAA20")]
	[AsyncStateMachine(typeof(MLPHBHADJGB))]
	private Task AMHDOPFHBLO(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x27CBF00", Offset = "0x27CA900", VA = "0x1827CBF00")]
	[AsyncStateMachine(typeof(PNIJPPGDOJC))]
	private Task GDIKFGKMOJA(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x27CD070", Offset = "0x27CBA70", VA = "0x1827CD070")]
	[AsyncStateMachine(typeof(NIIFPFNJILG))]
	private Task JDDECIJGNOM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x27CDCA0", Offset = "0x27CC6A0", VA = "0x1827CDCA0")]
	private static void OGDCIMBPLHM(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x27CDE70", Offset = "0x27CC870", VA = "0x1827CDE70")]
	private void PJOEJBDIILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x27CD820", Offset = "0x27CC220", VA = "0x1827CD820")]
	private void LDNPBOJFABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x27CD970", Offset = "0x27CC370", VA = "0x1827CD970")]
	private void MOHFOIDDBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x27CB900", Offset = "0x27CA300", VA = "0x1827CB900")]
	private void ENEGOBPAIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x27CC880", Offset = "0x27CB280", VA = "0x1827CC880")]
	private static void HEAMCAFGMBE(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x27CD8B0", Offset = "0x27CC2B0", VA = "0x1827CD8B0")]
	private static void LJHDNLOMOCF(OFCNMCIOFIM HPMGEPNNFHO, CancellationToken DMMMMFNCIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x27CA640", Offset = "0x27C9040", VA = "0x1827CA640")]
	private static void AJOAMPGHHDN(OFCNMCIOFIM HPMGEPNNFHO, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x27CA7E0", Offset = "0x27C91E0", VA = "0x1827CA7E0")]
	private void ALENJDLMLML(OFCNMCIOFIM HPMGEPNNFHO, Task COFGCDFOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x27CACE0", Offset = "0x27C96E0", VA = "0x1827CACE0")]
	private static void BMBLFHKAJNC(Func<string> HKNFNIPGHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x27CE130", Offset = "0x27CCB30", VA = "0x1827CE130")]
	public BFAAAHEGJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class IJNFNHHLBEL : KIGMPHJHPJO, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FILMPJBKIHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FILMPJBKIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C72610", Offset = "0x3C71010", VA = "0x183C72610")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class IMNFAGCPALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IMNFAGCPALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C77220", Offset = "0x3C75C20", VA = "0x183C77220")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class LEABKHCCEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LEABKHCCEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C79860", Offset = "0x3C78260", VA = "0x183C79860")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class EECKMIIOMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EECKMIIOMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C70CC0", Offset = "0x3C6F6C0", VA = "0x183C70CC0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class IKPKHKLKDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IKPKHKLKDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C771C0", Offset = "0x3C75BC0", VA = "0x183C771C0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<Guid, MFCNJKEINOM> EKNJIAIJLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly TimeSpan HGMNOEBNAJE;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "10")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x27DD750", Offset = "0x27DC150", VA = "0x1827DD750", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x27DD4B0", Offset = "0x27DBEB0", VA = "0x1827DD4B0", Slot = "4")]
	public EADEEJBAKAP AGMLDLCGDGN(Guid HPGJMKCMOPJ)
	{
		return default(EADEEJBAKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x27DD760", Offset = "0x27DC160", VA = "0x1827DD760", Slot = "5")]
	public bool FJEBMLODAAK(Guid HPGJMKCMOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x27DDDC0", Offset = "0x27DC7C0", VA = "0x1827DDDC0", Slot = "8")]
	public bool GJMJKHONEFD(Guid HPGJMKCMOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x27DD9F0", Offset = "0x27DC3F0", VA = "0x1827DD9F0", Slot = "6")]
	public bool GIJLBFKAPGH(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x27DE020", Offset = "0x27DCA20", VA = "0x1827DE020", Slot = "7")]
	public bool LFCNHMDCDFA(Guid HPGJMKCMOPJ, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x27DE280", Offset = "0x27DCC80", VA = "0x1827DE280", Slot = "9")]
	public Task<(IOCLDNFCAPD, Task)> LMCDFNKJLIM(Guid HPGJMKCMOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x27DE2F0", Offset = "0x27DCCF0", VA = "0x1827DE2F0")]
	private void MHEGELEOABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x27DE590", Offset = "0x27DCF90", VA = "0x1827DE590")]
	public IJNFNHHLBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[UnityEngine.Scripting.Preserve]
internal class PPKONHJEDAI : JJFNDJDCHPJ, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class BKLCLKPHHKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly OFCNMCIOFIM GPJFLBNAMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly CancellationTokenSource FFLFGHGEBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public readonly CancellationToken GHJHAKAKGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private bool LDKINPCABJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool AJCOIBJBODA;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4075F00", Offset = "0x4074900", VA = "0x184075F00")]
		public BKLCLKPHHKP(OFCNMCIOFIM GPJFLBNAMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4075DB0", Offset = "0x40747B0", VA = "0x184075DB0")]
		public void GJMJKHONEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4075D80", Offset = "0x4074780", VA = "0x184075D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NGCNBMGHADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PGONHDFGHDL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NGCNBMGHADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4081250", Offset = "0x407FC50", VA = "0x184081250")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct IMIKPFEJMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public PGONHDFGHDL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public PPKONHJEDAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x407BEA0", Offset = "0x407A8A0", VA = "0x18407BEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class HMAEBFMFMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HMAEBFMFMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x407B310", Offset = "0x4079D10", VA = "0x18407B310")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct JBDKOKJMAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public PPKONHJEDAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x407C230", Offset = "0x407AC30", VA = "0x18407C230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10099B0", Offset = "0x10083B0", VA = "0x1810099B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class IBBKCEDOKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public OFCNMCIOFIM newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IBBKCEDOKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x407BA90", Offset = "0x407A490", VA = "0x18407BA90")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x407BB30", Offset = "0x407A530", VA = "0x18407BB30")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x407BB70", Offset = "0x407A570", VA = "0x18407BB70")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GCFHBDLDGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GCFHBDLDGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x4079320", Offset = "0x4077D20", VA = "0x184079320")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct KMICIFMLFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public OFCNMCIOFIM newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public PPKONHJEDAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public BGLENBCKMJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IBBKCEDOKLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x407E6D0", Offset = "0x407D0D0", VA = "0x18407E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private EOPCGGIHEON LLLBGFHENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private HFHAFOIGEFC JGFNDHPFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private HKGOGNCIFMN ELAELJDAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private LGDLLPOFLJK KMLKPEPDMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private long JLILMMAOECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private BKLCLKPHHKP LBAJICDAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private bool BJKHEHBOJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private Task IOLPPEKPHLO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x31DCCE0", Offset = "0x31DB6E0", VA = "0x1831DCCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool PKJPJEMKMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x13FB6E0", Offset = "0x13FA0E0", VA = "0x1813FB6E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x31DCB40", Offset = "0x31DB540", VA = "0x1831DCB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x31DD070", Offset = "0x31DBA70", VA = "0x1831DD070", Slot = "4")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x31DC980", Offset = "0x31DB380", VA = "0x1831DC980", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x31DCF50", Offset = "0x31DB950", VA = "0x1831DCF50")]
	[AsyncStateMachine(typeof(IMIKPFEJMCM))]
	private Task KABNKODKHJO(PGONHDFGHDL JKPBGFEADJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x31DC3D0", Offset = "0x31DADD0", VA = "0x1831DC3D0")]
	private void ALBJFDMDBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x31DD5D0", Offset = "0x31DBFD0", VA = "0x1831DD5D0")]
	private void PFNODJBFFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x31DCD30", Offset = "0x31DB730", VA = "0x1831DCD30")]
	private void INMIEEELICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x31DD410", Offset = "0x31DBE10", VA = "0x1831DD410")]
	private bool KNGMJIDHIBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x31DD320", Offset = "0x31DBD20", VA = "0x1831DD320")]
	[AsyncStateMachine(typeof(JBDKOKJMAJB))]
	private void KCNCNOOIPGA(int ENNAKHLEBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x31DC5F0", Offset = "0x31DAFF0", VA = "0x1831DC5F0")]
	private void ALDPGBCIOJI(out IDisposable IPFNGDFHBIO, out IDisposable MBGKDGKJHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x31DCB50", Offset = "0x31DB550", VA = "0x1831DCB50")]
	private bool ICMLKEKONBP(OFCNMCIOFIM GPJFLBNAMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x31DCB00", Offset = "0x31DB500", VA = "0x1831DCB00")]
	private void EILOHACBIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x31DD490", Offset = "0x31DBE90", VA = "0x1831DD490")]
	[AsyncStateMachine(typeof(KMICIFMLFBE))]
	private Task NJHNGCLNLEA(OFCNMCIOFIM GPJFLBNAMIO, BGLENBCKMJG GHPOPIHLAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x31DD7F0", Offset = "0x31DC1F0", VA = "0x1831DD7F0")]
	public PPKONHJEDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class AEIFCOEGAHE : DPJHHKMHBNI, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct HADAGEKJLDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<NNHCJPLIFIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AEIFCOEGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter<NNHCJPLIFIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x31CB080", Offset = "0x31C9A80", VA = "0x1831CB080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x31CB2D0", Offset = "0x31C9CD0", VA = "0x1831CB2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class CMHPNAECDIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public IKENBFLEHKK message;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public CMHPNAECDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x31C6110", Offset = "0x31C4B10", VA = "0x1831C6110")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class FIDHODEJJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public IKENBFLEHKK messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FIDHODEJJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x31C9350", Offset = "0x31C7D50", VA = "0x1831C9350")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class HNHDOIJIGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HNHDOIJIGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x31CC700", Offset = "0x31CB100", VA = "0x1831CC700")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct GLJEFGBHKNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AEIFCOEGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter<IMKGIBOCLAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x31CAA30", Offset = "0x31C9430", VA = "0x1831CAA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class DCJHKBECBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public IKENBFLEHKK operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DCJHKBECBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x31C6170", Offset = "0x31C4B70", VA = "0x1831C6170")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct NCNDBGDBNMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public IKENBFLEHKK operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AEIFCOEGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private MNALPKGIDEG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x31D6640", Offset = "0x31D5040", VA = "0x1831D6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct KJNPBJNDLGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<IMKGIBOCLAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public AEIFCOEGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private MNALPKGIDEG <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x31CFD50", Offset = "0x31CE750", VA = "0x1831CFD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x31D01A0", Offset = "0x31CEBA0", VA = "0x1831D01A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ADLEDMIBKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ADLEDMIBKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x31C4BB0", Offset = "0x31C35B0", VA = "0x1831C4BB0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct FOAELEAACFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AEIFCOEGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private global::JIHOHILIMPL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x31C99E0", Offset = "0x31C83E0", VA = "0x1831C99E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class MHCPLDANJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MHCPLDANJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x31D54C0", Offset = "0x31D3EC0", VA = "0x1831D54C0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class KNJPOOCNELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KNJPOOCNELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x31D0360", Offset = "0x31CED60", VA = "0x1831D0360")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private JJLJBFAGAMG CLODEIMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private IIMPFBAAGHO OGMILOCAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private NPFEPDLFMOF BEELBGNKLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<NNHCJPLIFIC> NBGPOEAILOC;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x27C5B30", Offset = "0x27C4530", VA = "0x1827C5B30", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x27C4AA0", Offset = "0x27C34A0", VA = "0x1827C4AA0", Slot = "6")]
	[AsyncStateMachine(typeof(HADAGEKJLDD))]
	public Task<NNHCJPLIFIC> BONIMKLBONK(CancellationToken KOAHEEBKLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x27C4C30", Offset = "0x27C3630", VA = "0x1827C4C30", Slot = "4")]
	public void DGEBDLINKDJ(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x27C52E0", Offset = "0x27C3CE0", VA = "0x1827C52E0", Slot = "5")]
	public void HBKGBGCJJPJ(IKENBFLEHKK KKIACKKMLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x27C51B0", Offset = "0x27C3BB0", VA = "0x1827C51B0")]
	[AsyncStateMachine(typeof(GLJEFGBHKNN))]
	private Task GOGFFCFACOJ(IKENBFLEHKK FLDKBCEOGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x27C4980", Offset = "0x27C3380", VA = "0x1827C4980")]
	[AsyncStateMachine(typeof(NCNDBGDBNMM))]
	private Task BHEAELABJNP(IKENBFLEHKK GEFEMGIDEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x27C5050", Offset = "0x27C3A50", VA = "0x1827C5050")]
	[AsyncStateMachine(typeof(KJNPBJNDLGN))]
	private Task<IMKGIBOCLAG> DMOLPODNCBF(IKENBFLEHKK FLDKBCEOGMK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x27C5C10", Offset = "0x27C4610", VA = "0x1827C5C10")]
	private MNALPKGIDEG KICKDHMPOKP(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x27C5F20", Offset = "0x27C4920", VA = "0x1827C5F20")]
	[AsyncStateMachine(typeof(FOAELEAACFH))]
	private Task PFEMFFPGOCL(IMKGIBOCLAG FFDDMJBLHEA, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x27C5C90", Offset = "0x27C4690", VA = "0x1827C5C90")]
	private IMKGIBOCLAG PBKNALBMBEN(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x10F4620", Offset = "0x10F3020", VA = "0x1810F4620")]
	private T MFOPJHBNONP<T>(T LPJDDLMPNCG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C56D0", Offset = "0x27C40D0", VA = "0x1827C56D0")]
	private IMKGIBOCLAG JFANICPMFPA(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public AEIFCOEGAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x27C4BE0", Offset = "0x27C35E0", VA = "0x1827C4BE0")]
	[CompilerGenerated]
	private void DAHEOIDJMDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class IODCGDJLFAE : IIMPFBAAGHO, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class AHPBGENJCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AHPBGENJCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CA00", Offset = "0x3C6B400", VA = "0x183C6CA00")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LOHCKCIOGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LOHCKCIOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3C7AC60", Offset = "0x3C79660", VA = "0x183C7AC60")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private AEEBLMOBCCO MJCHNIAODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private DPJHHKMHBNI KLAJNPJNFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private KIGMPHJHPJO EKNJIAIJLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MEACFOIHIKJ PMOEGAOHFBL;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x27E1E90", Offset = "0x27E0890", VA = "0x1827E1E90", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x27E0F10", Offset = "0x27DF910", VA = "0x1827E0F10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x27E0FB0", Offset = "0x27DF9B0", VA = "0x1827E0FB0", Slot = "4")]
	public EADEEJBAKAP GAKKKEFAIMA(IKENBFLEHKK CPDANDAPHHP)
	{
		return default(EADEEJBAKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x27E1C00", Offset = "0x27E0600", VA = "0x1827E1C00", Slot = "5")]
	public void JJIFHCDLOOA(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x27E0590", Offset = "0x27DEF90", VA = "0x1827E0590")]
	private void AKHBOHPKEPG(byte AHOKOPLCFGL, int EJDEEFFNGFA, object HGAIHPAIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x27E14B0", Offset = "0x27DFEB0", VA = "0x1827E14B0")]
	private void JGLMMCGNLFG(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x27E0C20", Offset = "0x27DF620", VA = "0x1827E0C20")]
	private void DDEAALOKJGF(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x27E2000", Offset = "0x27E0A00", VA = "0x1827E2000")]
	private void MKKJGMNLMNL(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x27E0970", Offset = "0x27DF370", VA = "0x1827E0970")]
	private IOCLDNFCAPD CALKMFNEFJE(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x27E25D0", Offset = "0x27E0FD0", VA = "0x1827E25D0")]
	private void OPDDCNCMEAF(IKENBFLEHKK GEFEMGIDEKG, IOCLDNFCAPD HGOMAGBKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x27E22C0", Offset = "0x27E0CC0", VA = "0x1827E22C0")]
	private bool ONAOKFGGEGM(IKENBFLEHKK GEFEMGIDEKG, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x27E02A0", Offset = "0x27DECA0", VA = "0x1827E02A0")]
	private bool AJGMBPDOLAE(IKENBFLEHKK HMCHMJLEKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x27E0660", Offset = "0x27DF060", VA = "0x1827E0660")]
	private bool BIIBPICDOPA(byte AHOKOPLCFGL, ExitGames.Client.Photon.Hashtable MNNEHHHEKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IODCGDJLFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class FKNLFAOAACP : AFNCHCIFHKO, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FEINBBGJCCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public NNHCJPLIFIC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public FKNLFAOAACP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public IKENBFLEHKK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FEINBBGJCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3C721F0", Offset = "0x3C70BF0", VA = "0x183C721F0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3C72260", Offset = "0x3C70C60", VA = "0x183C72260")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct EFLJOHKKPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public FKNLFAOAACP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public IKENBFLEHKK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3C70D20", Offset = "0x3C6F720", VA = "0x183C70D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3C712C0", Offset = "0x3C6FCC0", VA = "0x183C712C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class ECJLADIDGGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public NNHCJPLIFIC operationType;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ECJLADIDGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3C70C50", Offset = "0x3C6F650", VA = "0x183C70C50")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DBDHKNOINFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DBDHKNOINFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F000", Offset = "0x3C6DA00", VA = "0x183C6F000")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F070", Offset = "0x3C6DA70", VA = "0x183C6F070")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F0E0", Offset = "0x3C6DAE0", VA = "0x183C6F0E0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CMFIDAMLNGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public FKNLFAOAACP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private DBDHKNOINFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private EADEEJBAKAP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private IOCLDNFCAPD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter<(IOCLDNFCAPD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E6D0", Offset = "0x3C6D0D0", VA = "0x183C6E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EDF0", Offset = "0x3C6D7F0", VA = "0x183C6EDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private AEEBLMOBCCO MJCHNIAODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private IIMPFBAAGHO OGMILOCAJLG;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x27D7250", Offset = "0x27D5C50", VA = "0x1827D7250", Slot = "5")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x27D6D40", Offset = "0x27D5740", VA = "0x1827D6D40", Slot = "4")]
	[AsyncStateMachine(typeof(EFLJOHKKPNH))]
	private Task<IOCLDNFCAPD> CDIOKPFHEPN(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x27D6FD0", Offset = "0x27D59D0", VA = "0x1827D6FD0")]
	private bool FDOJLMNALFG(NNHCJPLIFIC OBDLCOMHMDI, out IOCLDNFCAPD JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x27D6E80", Offset = "0x27D5880", VA = "0x1827D6E80")]
	[AsyncStateMachine(typeof(CMFIDAMLNGH))]
	private Task<IOCLDNFCAPD> CINOLBOIBDO(IKENBFLEHKK FLDKBCEOGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FKNLFAOAACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HLFNMCMHCNP : FHAMAIJMDNM, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct GBAILGELCDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public AsyncTaskMethodBuilder<MPCCILKBHMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public HLFNMCMHCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<LLBNMMPGAFE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3C73AD0", Offset = "0x3C724D0", VA = "0x183C73AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3C73CB0", Offset = "0x3C726B0", VA = "0x183C73CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class MICIGEHOLMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MICIGEHOLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B010", Offset = "0x3C79A10", VA = "0x183C7B010")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct OPPEDFHJDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<LLBNMMPGAFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public HLFNMCMHCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public OFCNMCIOFIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private MICIGEHOLMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private TaskAwaiter<LLBNMMPGAFE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D490", Offset = "0x3C7BE90", VA = "0x183C7D490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D9C0", Offset = "0x3C7C3C0", VA = "0x183C7D9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class EGGIFLNNNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EGGIFLNNNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1094E70", Offset = "0x1093870", VA = "0x181094E70")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(GJMMDEMBFND sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly (KKANDLGEEGN superRoomData, long subRoomDataSaveId) FPLKPJCFGMI;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x27DC6C0", Offset = "0x27DB0C0", VA = "0x1827DC6C0", Slot = "5")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x27DC3A0", Offset = "0x27DADA0", VA = "0x1827DC3A0", Slot = "4")]
	[AsyncStateMachine(typeof(GBAILGELCDC))]
	public Task<MPCCILKBHMP> BDBFDACKJCJ(HKNIJBILNIP BDBJGJIIKDE, OFCNMCIOFIM HPMGEPNNFHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x27DCAA0", Offset = "0x27DB4A0", VA = "0x1827DCAA0")]
	[AsyncStateMachine(typeof(OPPEDFHJDMF))]
	private Task<LLBNMMPGAFE> NEFNBCLIOIN(OFCNMCIOFIM HPMGEPNNFHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x27DC520", Offset = "0x27DAF20", VA = "0x1827DC520")]
	private MPCCILKBHMP CELMFECNOOM(OFCNMCIOFIM HPMGEPNNFHO, LLBNMMPGAFE DDACBKFDEHC, long HBNJLALONNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x27DC730", Offset = "0x27DB130", VA = "0x1827DC730")]
	private (KKANDLGEEGN, long) MKMOKNMPCHJ(OFCNMCIOFIM HPMGEPNNFHO, LLBNMMPGAFE DDACBKFDEHC, long HBNJLALONNE)
	{
		return default((KKANDLGEEGN, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HLFNMCMHCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal sealed class EHGKOLCEILO : NPFEPDLFMOF, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class BJIDMAJLCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BJIDMAJLCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D990", Offset = "0x3C6C390", VA = "0x183C6D990")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct PJOMBJCADKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public EHGKOLCEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public MNALPKGIDEG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EBC0", Offset = "0x3C7D5C0", VA = "0x183C7EBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F040", Offset = "0x3C7DA40", VA = "0x183C7F040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct OCBHNNGJGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public EHGKOLCEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public MNALPKGIDEG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BCE0", Offset = "0x3C7A6E0", VA = "0x183C7BCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C2D0", Offset = "0x3C7ACD0", VA = "0x183C7C2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class LHFGDDAFCII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LHFGDDAFCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x3C798C0", Offset = "0x3C782C0", VA = "0x183C798C0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct KKJEPICEDMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public IKENBFLEHKK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public EHGKOLCEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public MNALPKGIDEG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private IGEDENPPIDH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private POGILJNMLPD <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3C784A0", Offset = "0x3C76EA0", VA = "0x183C784A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3C78F50", Offset = "0x3C77950", VA = "0x183C78F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private FCFMBENHFCD OGFDDGEAMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private HFKOONKIHDN DNDDGBCMNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x27D5120", Offset = "0x27D3B20", VA = "0x1827D5120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x27D5470", Offset = "0x27D3E70", VA = "0x1827D5470", Slot = "8")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x27D4FA0", Offset = "0x27D39A0", VA = "0x1827D4FA0", Slot = "4")]
	[AsyncStateMachine(typeof(PJOMBJCADKO))]
	public Task<IKENBFLEHKK> BJJMPGAFBMA(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x27D5500", Offset = "0x27D3F00", VA = "0x1827D5500", Slot = "5")]
	[AsyncStateMachine(typeof(OCBHNNGJGJD))]
	public Task<IKENBFLEHKK> KIBJAHAGNIP(CancellationToken OIMNLGJCBEC, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x27D51E0", Offset = "0x27D3BE0", VA = "0x1827D51E0", Slot = "6")]
	public HAACNKIHLLI IMNGPHLHNNL(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x27D4BD0", Offset = "0x27D35D0", VA = "0x1827D4BD0", Slot = "7")]
	public HAACNKIHLLI ADIADHJFFPI(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x27D5650", Offset = "0x27D4050", VA = "0x1827D5650")]
	[AsyncStateMachine(typeof(KKJEPICEDMD))]
	private Task<IKENBFLEHKK> MODOOKBOMJK(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x27D51D0", Offset = "0x27D3BD0", VA = "0x1827D51D0")]
	private static byte[] GOHJHHBGCPL(IKENBFLEHKK BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x27D4E50", Offset = "0x27D3850", VA = "0x1827D4E50")]
	private static string BEINDELHHIE(byte[] HACNEHKIBDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public EHGKOLCEILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class FONNHABINBD : AEEBLMOBCCO, FMGAKNBAMFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EEHMBIIEFAB CCDCJPHJEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private JJLJBFAGAMG CLODEIMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private OLMODALHBEI PAHCHPMOCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private LGDLLPOFLJK KMLKPEPDMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private ILJHMLDGKCP LEDLKKDMDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private HKGOGNCIFMN ELAELJDAGOI;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x27D7310", Offset = "0x27D5D10", VA = "0x1827D7310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private static IOCLDNFCAPD NLOBKFPFEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x27D7300", Offset = "0x27D5D00", VA = "0x1827D7300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x27D7360", Offset = "0x27D5D60", VA = "0x1827D7360", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x27D74C0", Offset = "0x27D5EC0", VA = "0x1827D74C0", Slot = "4")]
	public IOCLDNFCAPD MNPHBDHPKCD(IEIHKFAAJEG IEDAIENJNOO, NNHCJPLIFIC NABLKJBKJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x27D7860", Offset = "0x27D6260", VA = "0x1827D7860", Slot = "5")]
	public IOCLDNFCAPD PPPHHENGFMM(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x27D7660", Offset = "0x27D6060", VA = "0x1827D7660", Slot = "6")]
	public IOCLDNFCAPD PNIGFKCFLHO(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x27D7650", Offset = "0x27D6050", VA = "0x1827D7650")]
	private static IOCLDNFCAPD ONKNDCGMKPH(IEAAFONNOPI JALEHBMHNHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FONNHABINBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class PJPLALHKNOE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x31DAF70", Offset = "0x31D9970", VA = "0x1831DAF70")]
	public PJPLALHKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2280830", Offset = "0x227F230", VA = "0x182280830")]
	public PJPLALHKNOE(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[UnityEngine.Scripting.Preserve]
internal sealed class LPPNPAJLKLI : AELGLLIMFJF, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GAPAGLGBMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public LFLMMDJMDFC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private global::JIHOHILIMPL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private HKNIJBILNIP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private CFDDEJKMDNO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private HKNIJBILNIP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4078C40", Offset = "0x4077640", VA = "0x184078C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x40792D0", Offset = "0x4077CD0", VA = "0x1840792D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct HFKBMDOCPAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x407A330", Offset = "0x4078D30", VA = "0x18407A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MJKKEBOFDIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4080220", Offset = "0x407EC20", VA = "0x184080220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct MCNMKEOJCIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x407FF50", Offset = "0x407E950", VA = "0x18407FF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BDDMKEJJAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x40750E0", Offset = "0x4073AE0", VA = "0x1840750E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FEPNOKIHKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public LPPNPAJLKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private global::JIHOHILIMPL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4078880", Offset = "0x4077280", VA = "0x184078880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private static readonly TimeSpan EPPMGIMBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private NPFEPDLFMOF BEELBGNKLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private JJLJBFAGAMG CLODEIMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private ILJHMLDGKCP LEDLKKDMDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private CancellationTokenSource ILFCDMPFEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private Task ODCGGMDJEOO;

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x31D44B0", Offset = "0x31D2EB0", VA = "0x1831D44B0", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x16639D0", Offset = "0x16623D0", VA = "0x1816639D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x31D3EB0", Offset = "0x31D28B0", VA = "0x1831D3EB0", Slot = "4")]
	[AsyncStateMachine(typeof(GAPAGLGBMEI))]
	public Task<IOCLDNFCAPD> GCLDKLBGALL(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x31D48A0", Offset = "0x31D32A0", VA = "0x1831D48A0", Slot = "5")]
	[AsyncStateMachine(typeof(HFKBMDOCPAB))]
	public Task PCAGCJDIMFJ([Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x16639D0", Offset = "0x16623D0", VA = "0x1816639D0")]
	public void OMMBCEKDILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x31D3B70", Offset = "0x31D2570", VA = "0x1831D3B70")]
	private CFDDEJKMDNO DBLPAFLHJBP(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x31D4770", Offset = "0x31D3170", VA = "0x1831D4770")]
	[AsyncStateMachine(typeof(MJKKEBOFDIA))]
	private Task NNPGMAEAGOB(JILMCFPJPGB PJEHHDIBMKL, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x31D4260", Offset = "0x31D2C60", VA = "0x1831D4260")]
	[AsyncStateMachine(typeof(MCNMKEOJCIA))]
	private Task IEFIGCNHMOP([Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x31D4380", Offset = "0x31D2D80", VA = "0x1831D4380")]
	[AsyncStateMachine(typeof(BDDMKEJJAOO))]
	private Task IHCOIBCJBCL(TimeSpan OMNNAMIEKJH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x31D3FF0", Offset = "0x31D29F0", VA = "0x1831D3FF0")]
	private Task HEFJCAFLCDO(GDONNAAGMMP DDKEDGNNMCH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x31D3D80", Offset = "0x31D2780", VA = "0x1831D3D80")]
	[AsyncStateMachine(typeof(FEPNOKIHKAJ))]
	private Task DGBNEFIGINK(GDONNAAGMMP DDKEDGNNMCH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x31D4660", Offset = "0x31D3060", VA = "0x1831D4660")]
	private bool MPMKDGFCFDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public LPPNPAJLKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class BLCBGLHMPMF : OLMODALHBEI, FMGAKNBAMFM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct FMLMCGFIGDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public BLCBGLHMPMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private global::JIHOHILIMPL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x31C93B0", Offset = "0x31C7DB0", VA = "0x1831C93B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private NJBDFOIOPMG DIJGJGFMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private AEEBLMOBCCO MJCHNIAODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private NPFEPDLFMOF BEELBGNKLAA;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x27CF9E0", Offset = "0x27CE3E0", VA = "0x1827CF9E0", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x27CF990", Offset = "0x27CE390", VA = "0x1827CF990", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x27CF870", Offset = "0x27CE270", VA = "0x1827CF870", Slot = "5")]
	[AsyncStateMachine(typeof(FMLMCGFIGDC))]
	public Task BEFGPHPFGEM(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x27CFD50", Offset = "0x27CE750", VA = "0x1827CFD50", Slot = "4")]
	public IOCLDNFCAPD MPMKDGFCFDK(IEIHKFAAJEG IEDAIENJNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x27CFC00", Offset = "0x27CE600", VA = "0x1827CFC00")]
	private GCIDEOLCFFE MNCLBPLDPMD(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BLCBGLHMPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class GIACHLCFFDE
{
	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x27D8A10", Offset = "0x27D7410", VA = "0x1827D8A10")]
	public static void ONCKFELPHOE(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x27D83C0", Offset = "0x27D6DC0", VA = "0x1827D83C0")]
	internal static void GNNMAKOOBIG(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x27D8930", Offset = "0x27D7330", VA = "0x1827D8930")]
	internal static void LKBDGFNIBHJ(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x27D84E0", Offset = "0x27D6EE0", VA = "0x1827D84E0")]
	internal static void HIKDGIAJKGB(AOONKACGDKK ONILLNPEPMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class CIHFPNKIHEH : global::FGMFHGDMKOO<IKENBFLEHKK>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class FAJKDEKPEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public IKENBFLEHKK message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FAJKDEKPEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x31C86B0", Offset = "0x31C70B0", VA = "0x1831C86B0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly CIHFPNKIHEH AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private const string GBCHGEFCBDG = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x27D06C0", Offset = "0x27CF0C0", VA = "0x1827D06C0")]
	public ExitGames.Client.Photon.Hashtable HLHCEBOKDMG(IKENBFLEHKK BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x27D0740", Offset = "0x27CF140", VA = "0x1827D0740", Slot = "5")]
	protected override void HPPGFLNFHCF(IKENBFLEHKK BALNMHDNCIN, IDictionary<object, object> HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x27D0880", Offset = "0x27CF280", VA = "0x1827D0880", Slot = "6")]
	public override IKENBFLEHKK JDGCKOHAIDJ(IDictionary<object, object> HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x27D0530", Offset = "0x27CEF30", VA = "0x1827D0530")]
	private static void BMBLFHKAJNC(string KDHKIHNDDDL, IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x27D0DE0", Offset = "0x27CF7E0", VA = "0x1827D0DE0")]
	public CIHFPNKIHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x27D0A80", Offset = "0x27CF480", VA = "0x1827D0A80")]
	[CompilerGenerated]
	internal static string KBMGOJHMLNK(MPCCILKBHMP GJNIFGAPEDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class OGINKKDDIDD
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static IOCLDNFCAPD NLOBKFPFEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x31D8060", Offset = "0x31D6A60", VA = "0x1831D8060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x31D8040", Offset = "0x31D6A40", VA = "0x1831D8040")]
	public static bool BIGJFOBBLEF(this IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x31D8540", Offset = "0x31D6F40", VA = "0x1831D8540")]
	public static IOCLDNFCAPD ONKNDCGMKPH(IEAAFONNOPI LBAAOGIJHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x31D8530", Offset = "0x31D6F30", VA = "0x1831D8530")]
	public static IOCLDNFCAPD MAOPIIEOOOB(params IOCLDNFCAPD[] JIIGKNCLFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x31D80C0", Offset = "0x31D6AC0", VA = "0x1831D80C0")]
	public static IOCLDNFCAPD FIFBHHOJBLH(IEnumerable<IOCLDNFCAPD> JIIGKNCLFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x31D82C0", Offset = "0x31D6CC0", VA = "0x1831D82C0")]
	public static string GCIBGNPEBLG(this IOCLDNFCAPD JGINNNKFHFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class AIGGJPOCKII : BCJBONPMIBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate IOCLDNFCAPD HAKJPICFBOL([NotNull] IEIHKFAAJEG OAEMDLGMGHE);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class FPKOJOFAHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IEIHKFAAJEG photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FPKOJOFAHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x31C9F30", Offset = "0x31C8930", VA = "0x1831C9F30")]
		internal IOCLDNFCAPD <Validate>b__0(HAKJPICFBOL v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	protected readonly HashSet<HAKJPICFBOL> GDEIMOHLGCL;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x27C7660", Offset = "0x27C6060", VA = "0x1827C7660", Slot = "4")]
	public void IPLFNKPIDAI(HAKJPICFBOL FADOFACCPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x27C7600", Offset = "0x27C6000", VA = "0x1827C7600", Slot = "5")]
	public void INJFOFCFDMD(HAKJPICFBOL FADOFACCPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x27C7390", Offset = "0x27C5D90", VA = "0x1827C7390", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x27C73E0", Offset = "0x27C5DE0", VA = "0x1827C73E0")]
	protected IOCLDNFCAPD HACCHEJGKIH(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x27C76C0", Offset = "0x27C60C0", VA = "0x1827C76C0")]
	protected AIGGJPOCKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class OKMJGEFKMJA : AIGGJPOCKII, EEHMBIIEFAB, BCJBONPMIBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class IHBJBFNIEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public IOCLDNFCAPD result;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IHBJBFNIEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x407BBB0", Offset = "0x407A5B0", VA = "0x18407BBB0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x31D3170", Offset = "0x31D1B70", VA = "0x1831D3170")]
	[UnityEngine.Scripting.Preserve]
	public OKMJGEFKMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x31D93E0", Offset = "0x31D7DE0", VA = "0x1831D93E0", Slot = "8")]
	public IOCLDNFCAPD DOAMCAGKALL(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class LINIPLOEPBE : AIGGJPOCKII, NJBDFOIOPMG, BCJBONPMIBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class DHMDEAAMMLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public IOCLDNFCAPD result;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DHMDEAAMMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x4076390", Offset = "0x4074D90", VA = "0x184076390")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x31D3170", Offset = "0x31D1B70", VA = "0x1831D3170")]
	[UnityEngine.Scripting.Preserve]
	public LINIPLOEPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x31D2FE0", Offset = "0x31D19E0", VA = "0x1831D2FE0", Slot = "8")]
	public IOCLDNFCAPD MPMKDGFCFDK(IEIHKFAAJEG DCELPOHIPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum FLBEJMADIKL
{
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LMBBBJLOOJB
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class DOKPCPGHJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public global::JIHOHILIMPL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DOKPCPGHJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x4076570", Offset = "0x4074F70", VA = "0x184076570")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string OIJKMKIGMFP = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public const string IPOALOFACJC = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x31D3740", Offset = "0x31D2140", VA = "0x1831D3740")]
	public static global::JIHOHILIMPL<string> GCGMABAPNPH([Optional] string LAGLMNHLDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x31D3810", Offset = "0x31D2210", VA = "0x1831D3810")]
	private static void HEHLPKKDMGN(string OGFDNCPKECB, JMMAOJMBHJK MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x31D3920", Offset = "0x31D2320", VA = "0x1831D3920")]
	private static void HHOBKCKFDIM(string OGFDNCPKECB, JMMAOJMBHJK MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x31D35D0", Offset = "0x31D1FD0", VA = "0x1831D35D0")]
	public static void FEAJOPBNNAD(global::JIHOHILIMPL<string> MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x31D3A30", Offset = "0x31D2430", VA = "0x1831D3A30")]
	public static string MHEDLLKADND(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class NFCKHLMJKKJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x31D7090", Offset = "0x31D5A90", VA = "0x1831D7090")]
	public static void GAFMAPOMCKO(this OGCACIFJDCP KEHCECCODAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x31D7080", Offset = "0x31D5A80", VA = "0x1831D7080")]
	public static void EAEAJDPEMIH(this OGCACIFJDCP KEHCECCODAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x31D6F70", Offset = "0x31D5970", VA = "0x1831D6F70")]
	private static void BGGCJOCGBJP(this OGCACIFJDCP KEHCECCODAM, bool FCKCBFGKLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class OOLEJPECMNK : LPMJLEAIFHF, JKMAHCLGMKC, IPIMGJIMFLO, PIMENJMGHGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly JKMAHCLGMKC FKGEPOENBDB;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEIHKFAAJEG CLMJPHEMKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x31D9B40", Offset = "0x31D8540", VA = "0x1831D9B40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int FPMMDLOENAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x31D9AF0", Offset = "0x31D84F0", VA = "0x1831D9AF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int LDLADOGOABN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x31D9960", Offset = "0x31D8360", VA = "0x1831D9960", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JFEGKDOMDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int BPCMIFONGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ADDOPBLDHDH.KECGCDEGNJJ PEBGDIJBNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FMOMLHBOKEB FPKKAHAKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x31D98C0", Offset = "0x31D82C0", VA = "0x1831D98C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x31D9780", Offset = "0x31D8180", VA = "0x1831D9780", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> FJAHDMFOJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<IEIHKFAAJEG> DOBECGKOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action HFFEDFMGLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x31D9C40", Offset = "0x31D8640", VA = "0x1831D9C40", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x31D9D00", Offset = "0x31D8700", VA = "0x1831D9D00", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xC053A0", Offset = "0xC03DA0", VA = "0x180C053A0")]
	public OOLEJPECMNK(JKMAHCLGMKC FKGEPOENBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D9B90", Offset = "0x31D8590", VA = "0x1831D9B90", Slot = "8")]
	public bool NLJGDCEBNPM(byte AHOKOPLCFGL, ExitGames.Client.Photon.Hashtable KJIMGDEFNCD, DMCFMAHOAGP AOPNFOFINKK, SendOptions KDMOIOKDJPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x31D9820", Offset = "0x31D8220", VA = "0x1831D9820", Slot = "29")]
	public IEIHKFAAJEG BJPHLDMLOMH(int KHALHEOHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x31D99B0", Offset = "0x31D83B0", VA = "0x1831D99B0", Slot = "16")]
	public IEIHKFAAJEG JNNBJKNJKNC(int DKMBEMBDAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "19")]
	public void HLPNAPDGANN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "20")]
	public void MNEBIGNEBOO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "21")]
	public void PFPLGNEPFCH(object MIFCLBEAOPM, bool KJDPMJJFOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x31D9A90", Offset = "0x31D8490", VA = "0x1831D9A90", Slot = "22")]
	public IDisposable MEMLALILPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "23")]
	private bool PCMPJHJINEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "24")]
	public void DBOPOIDMIKI(StringBuilder IAFGLANFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x31D9CE0", Offset = "0x31D86E0", VA = "0x1831D9CE0", Slot = "25")]
	public bool PEPCBCLGBKG(bool DOAGGOEHHAC, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public void AHCLNKJKFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xE601B0", Offset = "0xE5EBB0", VA = "0x180E601B0", Slot = "28")]
	public void EOBKLCOKBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct AKAINFJKHFE
{
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public const string FCCKCLCGCKK = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public const string BGGHHONNKEF = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private readonly IDictionary<object, object> MNNEHHHEKKO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x920250", Offset = "0x91EC50", VA = "0x180920250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
	public AKAINFJKHFE(IDictionary<object, object> MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x27C7A70", Offset = "0x27C6470", VA = "0x1827C7A70")]
	public bool ONCFLGLIFID(out IKENBFLEHKK BALNMHDNCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x27C78A0", Offset = "0x27C62A0", VA = "0x1827C78A0")]
	public Guid GDEPNKJGIBI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x27C7740", Offset = "0x27C6140", VA = "0x1827C7740")]
	public IOCLDNFCAPD GAMAKIIFDJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x27C7980", Offset = "0x27C6380", VA = "0x1827C7980")]
	public static ExitGames.Client.Photon.Hashtable IDIKGABNBEI(IKENBFLEHKK BALNMHDNCIN, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NCMEKEDHLLO
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x31D63F0", Offset = "0x31D4DF0", VA = "0x1831D63F0")]
	public static string OMMGKLGAGFB(this OFCNMCIOFIM GPGKFDLHFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x31D6370", Offset = "0x31D4D70", VA = "0x1831D6370")]
	public static bool NEBEEOGNMPO(this OFCNMCIOFIM GPGKFDLHFHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct NMLPMEFFLFG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OMDNEPPBKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public NMLPMEFFLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4082A10", Offset = "0x4081410", VA = "0x184082A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private readonly CancellationTokenSource FFLFGHGEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private Task IBCOHPONNBJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x31D76C0", Offset = "0x31D60C0", VA = "0x1831D76C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal Task EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x31D7820", Offset = "0x31D6220", VA = "0x1831D7820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x31D78A0", Offset = "0x31D62A0", VA = "0x1831D78A0")]
	public NMLPMEFFLFG(CancellationToken OIMNLGJCBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x31D76F0", Offset = "0x31D60F0", VA = "0x1831D76F0")]
	[AsyncStateMachine(typeof(OMDNEPPBKPL))]
	public Task GMNLBEMKBDM(Func<CancellationToken, List<Task>> OONBHACEHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x31D7670", Offset = "0x31D6070", VA = "0x1831D7670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct FDGFCFNJPHA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct OGGLJNAEPGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<global::IGMNBOHIBOC<TData>, KFANFMGGLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public global::FDGFCFNJPHA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter<global::LFBADEDAHHF<byte[], KFANFMGGLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D322D0", Offset = "0x2D30CD0", VA = "0x182D322D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2242ED0", Offset = "0x22418D0", VA = "0x182242ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly global::HELOOCDOGGH<TGetDataArg, TData> GOBIMGKDLNH;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
	internal FDGFCFNJPHA(global::HELOOCDOGGH<TGetDataArg, TData> AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x38B2190", Offset = "0x38B0B90", VA = "0x1838B2190")]
	[AsyncStateMachine(typeof(global::FDGFCFNJPHA<, >.OGGLJNAEPGD))]
	public Task<global::LFBADEDAHHF<global::IGMNBOHIBOC<TData>, KFANFMGGLGP>> DFHPKMFOGHD(TGetDataArg HACNEHKIBDN, string IGLHEIKDNHB, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class HDHKGNCGKOL
{
	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x24BF770", Offset = "0x24BE170", VA = "0x1824BF770")]
	public static global::FDGFCFNJPHA<TGetDataArg, TData> GILBACJLDCL<TGetDataArg, TData>(global::HELOOCDOGGH<TGetDataArg, TData> AAKNFDLFILB)
	{
		return default(global::FDGFCFNJPHA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public class BKMGDOEHDIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly ENIMFIBLMKI PNAOLCDCJOM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private const string HNAPPLOMOKD = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private const string KFPDABCKHGL = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private const string PIGOEOOHEIF = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private const string LEAAJKHGIJD = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private const string LCBMIJAPAAH = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private string LMDIEPAILBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private long? KPPFCFMCMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private long? FDNLJHCKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private DNNPENLDDEC CEMAONHGDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private long? ACEHFCGNDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private bool NMHLLJBCCCK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string JNHFLLAPNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long BNCPDJEKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x27CF0D0", Offset = "0x27CDAD0", VA = "0x1827CF0D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long OGJIHNKAJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x27CF130", Offset = "0x27CDB30", VA = "0x1827CF130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DNNPENLDDEC NICNPGDMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x75E260", Offset = "0x75CC60", VA = "0x18075E260")]
		get
		{
			return default(DNNPENLDDEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x27CECE0", Offset = "0x27CD6E0", VA = "0x1827CECE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long BEJFLKELMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x27CEF80", Offset = "0x27CD980", VA = "0x1827CEF80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x27CF830", Offset = "0x27CE230", VA = "0x1827CF830")]
	[UnityEngine.Scripting.Preserve]
	public BKMGDOEHDIH([LIKONNNLKGK(null)] ENIMFIBLMKI PNAOLCDCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x27CEDD0", Offset = "0x27CD7D0", VA = "0x1827CEDD0")]
	private void CBMKJHKGAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x27CF480", Offset = "0x27CDE80", VA = "0x1827CF480")]
	public void NEJHJPNFPEO(long LCIEPBGBKGO, long HBNJLALONNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x27CEFE0", Offset = "0x27CD9E0", VA = "0x1827CEFE0")]
	public void GKIHOAKDBKH(string NKECNDHGDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x27CF190", Offset = "0x27CDB90", VA = "0x1827CF190")]
	public void KEEFNBJJFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class HAACNKIHLLI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct EJJCCIFLKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public IKENBFLEHKK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public HAACNKIHLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<AELILFMFADF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3C71E90", Offset = "0x3C70890", VA = "0x183C71E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3C721A0", Offset = "0x3C70BA0", VA = "0x183C721A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct HAAFAECPEOH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class PJPNNCHPBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public IKENBFLEHKK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PJPNNCHPBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F110", Offset = "0x3C7DB10", VA = "0x183C7F110")]
		internal IKENBFLEHKK <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct LLAIGJHIPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder<AELILFMFADF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public IKENBFLEHKK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public HAACNKIHLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private IGEDENPPIDH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<AELILFMFADF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A3C0", Offset = "0x3C78DC0", VA = "0x183C7A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3C7ABB0", Offset = "0x3C795B0", VA = "0x183C7ABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct AAOOBNBFKFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public HAACNKIHLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C3F0", Offset = "0x3C6ADF0", VA = "0x183C6C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class DFFCILAPJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DFFCILAPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F3A0", Offset = "0x3C6DDA0", VA = "0x183C6F3A0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class LMFJPGDADEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LMFJPGDADEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7AC00", Offset = "0x3C79600", VA = "0x183C7AC00")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class GNFDOMDNEEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GNFDOMDNEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3C742B0", Offset = "0x3C72CB0", VA = "0x183C742B0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class LAEJFLHJJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LAEJFLHJJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3C797F0", Offset = "0x3C781F0", VA = "0x183C797F0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class CDCGLPNBMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public HAACNKIHLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public CDCGLPNBMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E3C0", Offset = "0x3C6CDC0", VA = "0x183C6E3C0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class DHBGGMLFPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public HAACNKIHLLI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DHBGGMLFPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F510", Offset = "0x3C6DF10", VA = "0x183C6F510")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Guid FNDHNEDCBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public readonly IMKGIBOCLAG GLLMOCALFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly HFKOONKIHDN ALCCAOIDJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly IPIMGJIMFLO KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly PIMENJMGHGL INAGLGEMCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool BKMMHIEDBCJ;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x27DA420", Offset = "0x27D8E20", VA = "0x1827DA420")]
	public HAACNKIHLLI(IMKGIBOCLAG FFDDMJBLHEA, HFKOONKIHDN ALCCAOIDJBH, IPIMGJIMFLO KEHCECCODAM, PIMENJMGHGL INAGLGEMCNH, HKNIJBILNIP BDBJGJIIKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x27D8C10", Offset = "0x27D7610", VA = "0x1827D8C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x27D8C10", Offset = "0x27D7610", VA = "0x1827D8C10")]
	public void AEGLNIOCDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x27D9AC0", Offset = "0x27D84C0", VA = "0x1827D9AC0")]
	public void KBIKPHJEFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x27D9D70", Offset = "0x27D8770", VA = "0x1827D9D70")]
	public void LBANNJFLBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x27D97E0", Offset = "0x27D81E0", VA = "0x1827D97E0")]
	[AsyncStateMachine(typeof(EJJCCIFLKEA))]
	internal Task<IKENBFLEHKK> GCGPANHFNEH(HKNIJBILNIP BDBJGJIIKDE, IKENBFLEHKK KDGOJEKMNED, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x27D51D0", Offset = "0x27D3BD0", VA = "0x1827D51D0")]
	private static byte[] HCLFOMFIMFH<T>(T BALNMHDNCIN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x36BAC50", Offset = "0x36B9650", VA = "0x1836BAC50")]
	private static T JIMGMHKLNJM<T>(MessageParser<T> JDKNEBHHMFD, byte[] BALNMHDNCIN, T PBEMIFAFADA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x27DA0E0", Offset = "0x27D8AE0", VA = "0x1827DA0E0")]
	[AsyncStateMachine(typeof(LLAIGJHIPFF))]
	private Task<AELILFMFADF> OLGPGBKMEII(IKENBFLEHKK KDGOJEKMNED, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x36BB110", Offset = "0x36B9B10", VA = "0x1836BB110")]
	[AsyncStateMachine(typeof(NBAFCMAOHGG))]
	internal Task<T> KJHFDOEPKJI<T>(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task<T>> GCAEGAAGADF, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x27D9C20", Offset = "0x27D8620", VA = "0x1827D9C20")]
	[AsyncStateMachine(typeof(AAOOBNBFKFE))]
	internal Task KJHFDOEPKJI(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task> GCAEGAAGADF, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x27D9280", Offset = "0x27D7C80", VA = "0x1827D9280")]
	public IKENBFLEHKK DDEBGKMOCOP(IGEDENPPIDH FNLCCIEPNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x27D99B0", Offset = "0x27D83B0", VA = "0x1827D99B0")]
	public LBHMAKJMHJK GJAEIBLMFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x27D9A50", Offset = "0x27D8450", VA = "0x1827D9A50")]
	public KMMGIKAOMCG IOEJGDOBECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x27DA240", Offset = "0x27D8C40", VA = "0x1827DA240")]
	public HGEJIOHJADL PAAJBDJBONJ([Optional] JHJMJFFJEOO? KJHKAEFGNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x27D9A20", Offset = "0x27D8420", VA = "0x1827D9A20")]
	public void HBMDJIKNCIA(Func<Guid, bool> DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x27D94B0", Offset = "0x27D7EB0", VA = "0x1827D94B0")]
	public void EEEGDDMDNJO(Func<Guid, bool> IFGELHABLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x27D9310", Offset = "0x27D7D10", VA = "0x1827D9310")]
	public void DEOOGDLLCOJ(Func<Guid, bool> DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x27D9ED0", Offset = "0x27D88D0", VA = "0x1827D9ED0")]
	public Guid OBNBPGHOPKJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x27D90E0", Offset = "0x27D7AE0", VA = "0x1827D90E0")]
	public void CNLOIHFBCDH(Guid PJGICPOEFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x27D9690", Offset = "0x27D8090", VA = "0x1827D9690")]
	public void GBEELOKFNKK(IKENBFLEHKK OBEFFGHPGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x27D8F50", Offset = "0x27D7950", VA = "0x1827D8F50")]
	public void BMBLFHKAJNC(string ELAKEMJOIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x27D8DC0", Offset = "0x27D77C0", VA = "0x1827D8DC0")]
	public void BMBLFHKAJNC(Func<string> BAMFEGJMCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x36BB3F0", Offset = "0x36B9DF0", VA = "0x1836BB3F0")]
	private T MFOPJHBNONP<T>(T LPJDDLMPNCG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x27D9960", Offset = "0x27D8360", VA = "0x1827D9960")]
	public void GHLJJJJNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x36BAE00", Offset = "0x36B9800", VA = "0x1836BAE00")]
	[CompilerGenerated]
	internal static string KHHNLOAPGNO<T>(byte[] EMIAMELGKNF, int OIMLPOMBANL, ref HAAFAECPEOH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal sealed class KMCGKMKMHKG : IMKGIBOCLAG
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class GNJOCJLPKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GNJOCJLPKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x3C745B0", Offset = "0x3C72FB0", VA = "0x183C745B0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct MJOHEOLBHLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public KMCGKMKMHKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private KMMGIKAOMCG <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B0C0", Offset = "0x3C79AC0", VA = "0x183C7B0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class JICCDHFNIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public HEMLBBFAKKA presence;

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JICCDHFNIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3C77890", Offset = "0x3C76290", VA = "0x183C77890")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly MPCCILKBHMP OIIJKAFJJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly OFCNMCIOFIM LGHKHDGGALO;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private const bool PFPMAMCNHHE = false;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x27E69B0", Offset = "0x27E53B0", VA = "0x1827E69B0")]
	public KMCGKMKMHKG(MPCCILKBHMP OIIJKAFJJPD, OFCNMCIOFIM LGHKHDGGALO, Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27E6490", Offset = "0x27E4E90", VA = "0x1827E6490", Slot = "8")]
	[AsyncStateMachine(typeof(MJOHEOLBHLP))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x27E65E0", Offset = "0x27E4FE0", VA = "0x1827E65E0")]
	private HEMLBBFAKKA GBLHFDBJBAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class CFDDEJKMDNO : IMKGIBOCLAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct CFNFICMAKPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public CFDDEJKMDNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter<HJAFOAIDLLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x31C5720", Offset = "0x31C4120", VA = "0x1831C5720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private readonly int PJJKBPGMCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly LFLMMDJMDFC DADNHALGJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly long HOKLKFDJFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public readonly long BNJMOHCAEBB;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public HJAFOAIDLLN GMHAPKHJLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x82D960", Offset = "0x82C360", VA = "0x18082D960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x905B10", Offset = "0x904510", VA = "0x180905B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x27D0390", Offset = "0x27CED90", VA = "0x1827D0390")]
	public CFDDEJKMDNO(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, int PJJKBPGMCEJ, LFLMMDJMDFC DADNHALGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x27D0250", Offset = "0x27CEC50", VA = "0x1827D0250", Slot = "8")]
	[AsyncStateMachine(typeof(CFNFICMAKPF))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal abstract class OHKIJIKLINE : IMKGIBOCLAG
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class EOFBFGFFJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public OHKIJIKLINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public EJOIEMHIKMM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EOFBFGFFJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x40787C0", Offset = "0x40771C0", VA = "0x1840787C0")]
		internal Task <RunAsync>b__0(HKNIJBILNIP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x4078800", Offset = "0x4077200", VA = "0x184078800")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct AALNNJCOKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public OHKIJIKLINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private EOFBFGFFJGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x4074100", Offset = "0x4072B00", VA = "0x184074100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct JJALMNBIDHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public EJOIEMHIKMM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public OHKIJIKLINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x407CD50", Offset = "0x407B750", VA = "0x18407CD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x31D9390", Offset = "0x31D7D90", VA = "0x1831D9390")]
	public OHKIJIKLINE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string ECMKCFBONNE, PGPGCAPEPDK OBDLCOMHMDI, bool OBNBIKJECBP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x31D90E0", Offset = "0x31D7AE0", VA = "0x1831D90E0", Slot = "8")]
	[AsyncStateMachine(typeof(AALNNJCOKIL))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task HINPLOOKACD(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x31D9230", Offset = "0x31D7C30", VA = "0x1831D9230")]
	[AsyncStateMachine(typeof(JJALMNBIDHN))]
	private Task LJGIPKGJGOL(IDisposable JIJJOPJMLPH, EJOIEMHIKMM ABGIIPPOJFO, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class PMADHNLPEAE : IMKGIBOCLAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct ACEJFBKOMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public PMADHNLPEAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter<DEIOFMFEJDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x4074820", Offset = "0x4073220", VA = "0x184074820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly GDONNAAGMMP DDKEDGNNMCH;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x31DB7F0", Offset = "0x31DA1F0", VA = "0x1831DB7F0")]
	public PMADHNLPEAE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x31DB710", Offset = "0x31DA110", VA = "0x1831DB710", Slot = "7")]
	protected override string OMBJIKPKBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x31DB5D0", Offset = "0x31D9FD0", VA = "0x1831DB5D0", Slot = "8")]
	[AsyncStateMachine(typeof(ACEJFBKOMHB))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class IMKGIBOCLAG : KMMCOMBMDMN
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public delegate Task FKIHFNCGFDF(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class HJKMBLIOJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public HKNIJBILNIP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public IMKGIBOCLAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HJKMBLIOJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3C75100", Offset = "0x3C73B00", VA = "0x183C75100")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class MFJCMBOBGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public HJKMBLIOJFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MFJCMBOBGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7AE90", Offset = "0x3C79890", VA = "0x183C7AE90")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3C7AF50", Offset = "0x3C79950", VA = "0x183C7AF50")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct PMMAALFKCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public IMKGIBOCLAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Func<IMKGIBOCLAG, HKNIJBILNIP, HAACNKIHLLI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private HJKMBLIOJFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private HAACNKIHLLI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private TaskAwaiter<IKENBFLEHKK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F220", Offset = "0x3C7DC20", VA = "0x183C7F220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct GCEOKDFAGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public IMKGIBOCLAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x3C73D00", Offset = "0x3C72700", VA = "0x183C73D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public readonly Guid ENBLPOIGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public readonly ByteString LMDNHILILPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public readonly MNALPKGIDEG GNJAJAJJNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	protected readonly string FLHKNBLAAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly bool OBNBIKJECBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly Queue<FKIHFNCGFDF> BBFFEBOBMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private readonly IIFMDBOLPBK BENGKGKDOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly PGPGCAPEPDK OBDLCOMHMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private bool PNHEBGNDONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public DNNPENLDDEC BKPLANCDDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public DNNPENLDDEC OMNPAMKCNDI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public BMMONKKCCCK OABOAPFBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x27DEDA0", Offset = "0x27DD7A0", VA = "0x1827DEDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HADNAKAMMKO FAFEJOEAODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x27DE7A0", Offset = "0x27DD1A0", VA = "0x1827DE7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x27DED00", Offset = "0x27DD700", VA = "0x1827DED00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x27DF130", Offset = "0x27DDB30", VA = "0x1827DF130", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event BDIJCOBGOEN KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x27DEF40", Offset = "0x27DD940", VA = "0x1827DEF40", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x27DEBA0", Offset = "0x27DD5A0", VA = "0x1827DEBA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x27DF1B0", Offset = "0x27DDBB0", VA = "0x1827DF1B0")]
	protected IMKGIBOCLAG(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string ECMKCFBONNE, PGPGCAPEPDK OBDLCOMHMDI, bool OBNBIKJECBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x27DF0F0", Offset = "0x27DDAF0", VA = "0x1827DF0F0", Slot = "7")]
	protected virtual string OMBJIKPKBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x27DF150", Offset = "0x27DDB50", VA = "0x1827DF150")]
	public void PPEPNIOIJPH(FKIHFNCGFDF HCNJFIFOHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x27DED80", Offset = "0x27DD780", VA = "0x1827DED80")]
	protected void JLFAAOJOHKD(float JOFEJELEMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x27DEDF0", Offset = "0x27DD7F0", VA = "0x1827DEDF0")]
	[AsyncStateMachine(typeof(PMMAALFKCND))]
	public Task KJENKEOBMBM(CancellationToken OIMNLGJCBEC, HKNIJBILNIP BDBJGJIIKDE, [Optional] Func<IMKGIBOCLAG, HKNIJBILNIP, HAACNKIHLLI> JPOHMMAAELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x27DEF60", Offset = "0x27DD960", VA = "0x1827DEF60")]
	private void OAMMHNMDGBD(bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x27DE870", Offset = "0x27DD270", VA = "0x1827DE870")]
	private void DICNCFHMLKN(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x27DEBC0", Offset = "0x27DD5C0", VA = "0x1827DEBC0")]
	[AsyncStateMachine(typeof(GCEOKDFAGEL))]
	private Task HBLDBNGIIMG(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x27DE7F0", Offset = "0x27DD1F0", VA = "0x1827DE7F0")]
	public IKENBFLEHKK DDEBGKMOCOP(IGEDENPPIDH FNLCCIEPNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x27DEAC0", Offset = "0x27DD4C0", VA = "0x1827DEAC0")]
	[CompilerGenerated]
	private Task FNBMKODFEJE(CancellationToken FOHPMIEDDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal sealed class DIOKJCKPLFH : OHKIJIKLINE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct DPNKMJONNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public DIOKJCKPLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private CGNOGDJLAKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private KMMGIKAOMCG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3C70440", Offset = "0x3C6EE40", VA = "0x183C70440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly MPCCILKBHMP FEKDGKLEEHD;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x27D3520", Offset = "0x27D1F20", VA = "0x1827D3520")]
	public DIOKJCKPLFH(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MPCCILKBHMP FEKDGKLEEHD, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x27D33D0", Offset = "0x27D1DD0", VA = "0x1827D33D0", Slot = "9")]
	[AsyncStateMachine(typeof(DPNKMJONNDO))]
	protected override Task HINPLOOKACD(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class GCIDEOLCFFE : IMKGIBOCLAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct NLOIPEJBDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public GCIDEOLCFFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private TaskAwaiter<DEIOFMFEJDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B570", Offset = "0x3C79F70", VA = "0x183C7B570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private readonly string KCDOKAJDOKO;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x27D7BE0", Offset = "0x27D65E0", VA = "0x1827D7BE0")]
	public GCIDEOLCFFE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string KCDOKAJDOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7AB0", Offset = "0x27D64B0", VA = "0x1827D7AB0", Slot = "8")]
	[AsyncStateMachine(typeof(NLOIPEJBDPM))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class ECIAONNBIJO : OHKIJIKLINE
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class LOJNJEAABNH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public LOJNJEAABNH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			private TaskAwaiter<DEIOFMFEJDI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			private TaskAwaiter<IKENBFLEHKK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x4086240", Offset = "0x4084C40", VA = "0x184086240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x4086590", Offset = "0x4084F90", VA = "0x184086590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public ECIAONNBIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public HGEJIOHJADL serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public LBHMAKJMHJK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LOJNJEAABNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3C7ACD0", Offset = "0x3C796D0", VA = "0x183C7ACD0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<IKENBFLEHKK> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct DLBDPINPNMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public ECIAONNBIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private LOJNJEAABNH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private CGNOGDJLAKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private KMMGIKAOMCG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F7B0", Offset = "0x3C6E1B0", VA = "0x183C6F7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly int OMKBGDEDOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	[CanBeNull]
	private readonly HOCIJINOOAM JKFBHFINEFL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x27D4B20", Offset = "0x27D3520", VA = "0x1827D4B20")]
	public ECIAONNBIJO(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, int OMKBGDEDOFD, HOCIJINOOAM JKFBHFINEFL, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x27D48D0", Offset = "0x27D32D0", VA = "0x1827D48D0", Slot = "9")]
	[AsyncStateMachine(typeof(DLBDPINPNMI))]
	protected override Task HINPLOOKACD(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x27D4A30", Offset = "0x27D3430", VA = "0x1827D4A30")]
	private void MKOMGIABHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x27D4730", Offset = "0x27D3130", VA = "0x1827D4730")]
	private void FJIHDLFLJCC(HKNIJBILNIP BDBJGJIIKDE, CGNOGDJLAKB CBNFPKLEHDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal abstract class PPKCBLMJCHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly IMKGIBOCLAG GLLMOCALFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly HAACNKIHLLI CKBODLOIEGI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x31DC350", Offset = "0x31DAD50", VA = "0x1831DC350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x31DC2F0", Offset = "0x31DACF0", VA = "0x1831DC2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x31DC370", Offset = "0x31DAD70", VA = "0x1831DC370")]
	protected PPKCBLMJCHH(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x31DC2B0", Offset = "0x31DACB0", VA = "0x1831DC2B0")]
	protected void BMBLFHKAJNC(string ELAKEMJOIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x31DC2D0", Offset = "0x31DACD0", VA = "0x1831DC2D0")]
	public void BMBLFHKAJNC(Func<string> BAMFEGJMCOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct OBLBGKHHEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public Dictionary<Guid, List<HEABMPIIHCO>> MBFJFFAEIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Dictionary<Guid, List<HEABMPIIHCO>> PAMOKOBOEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public Dictionary<Guid, List<HEABMPIIHCO>> JANADPGGMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public List<Guid> MDCPBDPNEOF;

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x31D7A50", Offset = "0x31D6450", VA = "0x1831D7A50")]
	public static OBLBGKHHEIM MKLBNKEKMJE(DEEFNALDPBL NOHGMFJPJKL, DNNPENLDDEC MFHLKCFDMNF, JILMCFPJPGB IFDJIENGHHN)
	{
		return default(OBLBGKHHEIM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct GONFIANDPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	public static GONFIANDPKM IDIKGABNBEI()
	{
		return default(GONFIANDPKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LMOIDIDNJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JCEIGACAJFP(JILMCFPJPGB HIDEHJGLNHO, object KHKLJBKIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KBDGHNPMLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct ACCNBLIHPFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public readonly LLBNMMPGAFE HOLCMHHFICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly GJMMDEMBFND EBIPNHCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly string MLKOMNKNPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly KKANDLGEEGN DDEENGNPJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly KKANDLGEEGN OGGAFKMEPLK;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x27C4900", Offset = "0x27C3300", VA = "0x1827C4900")]
	public ACCNBLIHPFM(LLBNMMPGAFE HOLCMHHFICL, GJMMDEMBFND EBIPNHCAEMF, string MLKOMNKNPAD, KKANDLGEEGN DDEENGNPJOM, KKANDLGEEGN OGGAFKMEPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct AMHPCDPCNJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly Guid PJGICPOEFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool MEFHOIBEAII;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x27C8300", Offset = "0x27C6D00", VA = "0x1827C8300")]
	public static AMHPCDPCNJH OBNBPGHOPKJ(HAACNKIHLLI NLFLBJNDBCF)
	{
		return default(AMHPCDPCNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0xFA5A40", Offset = "0xFA4440", VA = "0x180FA5A40")]
	public void IGMPIIGMHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x27C82F0", Offset = "0x27C6CF0", VA = "0x1827C82F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x27C8330", Offset = "0x27C6D30", VA = "0x1827C8330")]
	private AMHPCDPCNJH(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x27C7F00", Offset = "0x27C6900", VA = "0x1827C7F00")]
	private void CNLOIHFBCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x27C8240", Offset = "0x27C6C40", VA = "0x1827C8240")]
	private Func<Guid, bool> DIKHMFMHCPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class KMMGIKAOMCG : PPKCBLMJCHH, KMMCOMBMDMN
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public delegate Task<DNNPENLDDEC> MJOHPKKAKLL(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM CMBBGOBDCNG, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct OHBAOFKPAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private AMHPCDPCNJH <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x4081C90", Offset = "0x4080690", VA = "0x184081C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct BPLBJCGDNCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private HKNIJBILNIP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E050", Offset = "0x3C6CA50", VA = "0x183C6E050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E370", Offset = "0x3C6CD70", VA = "0x183C6E370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct ECGGPFDMIAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private HKNIJBILNIP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C709F0", Offset = "0x3C6F3F0", VA = "0x183C709F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class FPCEKENKKGI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private ACCNBLIHPFM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private TaskAwaiter<ACCNBLIHPFM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x4084CA0", Offset = "0x40836A0", VA = "0x184084CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x40852F0", Offset = "0x4083CF0", VA = "0x1840852F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public AsyncTaskMethodBuilder<JILMCFPJPGB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			private JILMCFPJPGB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			private TaskAwaiter<JILMCFPJPGB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x4085340", Offset = "0x4083D40", VA = "0x184085340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x40858B0", Offset = "0x40842B0", VA = "0x1840858B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private TaskAwaiter<DNNPENLDDEC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			private OCMBAOLDEMM <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4083A80", Offset = "0x4082480", VA = "0x184083A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public IIFMDBOLPBK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public IIFMDBOLPBK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public ACCNBLIHPFM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public IIFMDBOLPBK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public JILMCFPJPGB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public GODEACJPJMC.HBIDCNLCNEB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FPCEKENKKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C73810", Offset = "0x3C72210", VA = "0x183C73810")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<ACCNBLIHPFM> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C73950", Offset = "0x3C72350", VA = "0x183C73950")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<JILMCFPJPGB> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C73A90", Offset = "0x3C72490", VA = "0x183C73A90")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C736E0", Offset = "0x3C720E0", VA = "0x183C736E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct FPAJMJELDGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private FPCEKENKKGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<JILMCFPJPGB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C72AC0", Offset = "0x3C714C0", VA = "0x183C72AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct BNEIOBILIOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D9F0", Offset = "0x3C6C3F0", VA = "0x183C6D9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct HFPACJIPLMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private HKNIJBILNIP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C74620", Offset = "0x3C73020", VA = "0x183C74620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct IKEAEEICLOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private HKNIJBILNIP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C76320", Offset = "0x3C74D20", VA = "0x183C76320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C76DC0", Offset = "0x3C757C0", VA = "0x183C76DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct IBDHMDMEPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private HKNIJBILNIP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C75130", Offset = "0x3C73B30", VA = "0x183C75130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C75CE0", Offset = "0x3C746E0", VA = "0x183C75CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct LMCBFMJGLGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public DNNPENLDDEC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x407FBC0", Offset = "0x407E5C0", VA = "0x18407FBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x407FDC0", Offset = "0x407E7C0", VA = "0x18407FDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class LPNIPMAMBFO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public LPNIPMAMBFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0x4085900", Offset = "0x4084300", VA = "0x184085900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x4085E60", Offset = "0x4084860", VA = "0x184085E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public MJOHPKKAKLL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public DNNPENLDDEC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LPNIPMAMBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x407FE10", Offset = "0x407E810", VA = "0x18407FE10")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DNNPENLDDEC> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct MLKJFJKOBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public MJOHPKKAKLL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x4080D40", Offset = "0x407F740", VA = "0x184080D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4081200", Offset = "0x407FC00", VA = "0x184081200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct KDDIDGPDKKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public IIFMDBOLPBK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private DNNPENLDDEC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private IEnumerator<DNNPENLDDEC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x407D6A0", Offset = "0x407C0A0", VA = "0x18407D6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct DAMBHCCKFJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EE40", Offset = "0x3C6D840", VA = "0x183C6EE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct PFDMBOHFGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x40835B0", Offset = "0x4081FB0", VA = "0x1840835B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class GNFODCJJDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public LLBNMMPGAFE roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GNFODCJJDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C74320", Offset = "0x3C72D20", VA = "0x183C74320")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly FGFCKLFBJIP LNAHHAOGING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly FGFCKLFBJIP GMACLJMJODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly BAAPIFCMJOI KFIKNPBGMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly DCBCAALEHJL FIPOFINIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly KHLCNBENFGM OPEAGNFNDJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x27E8AE0", Offset = "0x27E74E0", VA = "0x1827E8AE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private BMMONKKCCCK OABOAPFBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x27E82A0", Offset = "0x27E6CA0", VA = "0x1827E82A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BDIJCOBGOEN KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x27E8630", Offset = "0x27E7030", VA = "0x1827E8630", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x27E7750", Offset = "0x27E6150", VA = "0x1827E7750", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B20", Offset = "0x27E7520", VA = "0x1827E8B20")]
	public KMMGIKAOMCG(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x27E7BB0", Offset = "0x27E65B0", VA = "0x1827E7BB0")]
	[AsyncStateMachine(typeof(OHBAOFKPAGP))]
	public Task JMFFNBNKOHH(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x27E7D00", Offset = "0x27E6700", VA = "0x1827E7D00")]
	[AsyncStateMachine(typeof(BPLBJCGDNCF))]
	private Task<IKENBFLEHKK> KFHJPMKFNHC(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x27E74C0", Offset = "0x27E5EC0", VA = "0x1827E74C0")]
	[AsyncStateMachine(typeof(ECGGPFDMIAI))]
	private Task ECMMPEBABED(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x27E7130", Offset = "0x27E5B30", VA = "0x1827E7130")]
	[AsyncStateMachine(typeof(FPAJMJELDGH))]
	private Task BNAPCNCGJDL(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OOMDENBMMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x27E7620", Offset = "0x27E6020", VA = "0x1827E7620")]
	[AsyncStateMachine(typeof(BNEIOBILIOB))]
	private Task FMLECFJOPPM(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x27E7FE0", Offset = "0x27E69E0", VA = "0x1827E7FE0")]
	[AsyncStateMachine(typeof(HFPACJIPLMI))]
	private Task LBMDBDPAEGL(JILMCFPJPGB HIDEHJGLNHO, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x27E84B0", Offset = "0x27E6EB0", VA = "0x1827E84B0")]
	[AsyncStateMachine(typeof(IKEAEEICLOI))]
	private Task<DNNPENLDDEC> NKKJHMANOFK(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x27E82D0", Offset = "0x27E6CD0", VA = "0x1827E82D0")]
	[AsyncStateMachine(typeof(IBDHMDMEPPD))]
	private Task<DNNPENLDDEC> NIGLPHFNNIG(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x27E77A0", Offset = "0x27E61A0", VA = "0x1827E77A0")]
	[AsyncStateMachine(typeof(LMCBFMJGLGL))]
	private Task<DNNPENLDDEC> HIBIEPNPIOD(DNNPENLDDEC MFHLKCFDMNF, JILMCFPJPGB IFDJIENGHHN, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool OMJOAEEENOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x27E7280", Offset = "0x27E5C80", VA = "0x1827E7280")]
	private bool BPCDGGHDNKL(JILMCFPJPGB INEOJIKCMGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x27E87C0", Offset = "0x27E71C0", VA = "0x1827E87C0")]
	[AsyncStateMachine(typeof(MLKJFJKOBCD))]
	protected Task<DNNPENLDDEC> OHIKFIPCHCA(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, MJOHPKKAKLL ABOCNCGCKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F80", Offset = "0x27E5980", VA = "0x1827E6F80")]
	[AsyncStateMachine(typeof(KDDIDGPDKKA))]
	private Task BJBNDGAJLLH(JILMCFPJPGB HIDEHJGLNHO, IIFMDBOLPBK EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x27E6C20", Offset = "0x27E5620", VA = "0x1827E6C20")]
	private void ALJFBNIBKHO(DNNPENLDDEC ALOFFKDKDOF, IIFMDBOLPBK EHILNCIAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x27E8470", Offset = "0x27E6E70", VA = "0x1827E8470")]
	private void NKJLNHIPMDI(DNNPENLDDEC BDHAHDBKCEG, out DNNPENLDDEC CNMJNMDOHBL, out DNNPENLDDEC FNGCHLOBFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x27E6DC0", Offset = "0x27E57C0", VA = "0x1827E6DC0")]
	private Task<ACCNBLIHPFM> BCDDBMPBINC(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x27E70F0", Offset = "0x27E5AF0", VA = "0x1827E70F0")]
	private Task<JILMCFPJPGB> BMDDFCDAJPK(ACCNBLIHPFM HIDEHJGLNHO, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x27E7E80", Offset = "0x27E6880", VA = "0x1827E7E80")]
	[AsyncStateMachine(typeof(DAMBHCCKFJJ))]
	private Task LBIILCMOLLO(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool KJLOEOIECKF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x27E7A90", Offset = "0x27E6490", VA = "0x1827E7A90")]
	[AsyncStateMachine(typeof(PFDMBOHFGIN))]
	private Task JMAPPNGPKBI(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x27E8140", Offset = "0x27E6B40", VA = "0x1827E8140")]
	private Task MBEIEALJLGH(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x27E7930", Offset = "0x27E6330", VA = "0x1827E7930")]
	private Task IHPAPIAOIED(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x27E7370", Offset = "0x27E5D70", VA = "0x1827E7370")]
	private Task CLNKIDJAHHI(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x27E8650", Offset = "0x27E7050", VA = "0x1827E8650")]
	private Task OEICHBKJPAM(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x27E70E0", Offset = "0x27E5AE0", VA = "0x1827E70E0")]
	private static Task BJFCBKPEGKJ(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x27E6C70", Offset = "0x27E5670", VA = "0x1827E6C70")]
	private Task BBGHOAKCKIE(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B00", Offset = "0x27E7500", VA = "0x1827E8B00")]
	private Task PHPGHACADNP(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x27E7770", Offset = "0x27E6170", VA = "0x1827E7770")]
	private void HCCIHDKNNCK(MPCCILKBHMP FLDKBCEOGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x27E8970", Offset = "0x27E7370", VA = "0x1827E8970")]
	private static void PABJOKAOABA(LLBNMMPGAFE HOLCMHHFICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct COIGGBEPDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x27D1000", Offset = "0x27CFA00", VA = "0x1827D1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x27D12C0", Offset = "0x27CFCC0", VA = "0x1827D12C0")]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x27D1050", Offset = "0x27CFA50", VA = "0x1827D1050")]
	private void KJENKEOBMBM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct MGOMLDCIGHJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x31D53A0", Offset = "0x31D3DA0", VA = "0x1831D53A0")]
	public static Task KJENKEOBMBM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct NLADPEGDHFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct OBFALNOBENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private HKNIJBILNIP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x4081810", Offset = "0x4080210", VA = "0x184081810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x31D7390", Offset = "0x31D5D90", VA = "0x1831D7390")]
	[AsyncStateMachine(typeof(OBFALNOBENO))]
	public static Task KJENKEOBMBM(HAACNKIHLLI NLFLBJNDBCF, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct BKAHKFBHAJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct IHCCLFFBBFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private DNNPENLDDEC <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private BMMONKKCCCK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private DEEFNALDPBL <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private BADFNEBCNNH <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x31CCE60", Offset = "0x31CB860", VA = "0x1831CCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x27CE900", Offset = "0x27CD300", VA = "0x1827CE900")]
	[AsyncStateMachine(typeof(IHCCLFFBBFE))]
	public static Task KJENKEOBMBM(HAACNKIHLLI NLFLBJNDBCF, JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x27CEA70", Offset = "0x27CD470", VA = "0x1827CEA70")]
	private static void PPMMNFFPEFB(PersistenceView KANBPIJHFNA, BADFNEBCNNH KHKLJBKIGHL, JILMCFPJPGB HIDEHJGLNHO, DNNPENLDDEC MFHLKCFDMNF, bool JFFEDLPGLIB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct IPOLPOEIBBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KMKNFCKDLND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3C793A0", Offset = "0x3C77DA0", VA = "0x183C793A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x27E2830", Offset = "0x27E1230", VA = "0x1827E2830")]
	[AsyncStateMachine(typeof(KMKNFCKDLND))]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct OHCLCMONFKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct DKOJPBHCIFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x40763F0", Offset = "0x4074DF0", VA = "0x1840763F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class KOLBJIDJMNL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			public HKNIJBILNIP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			public KOLBJIDJMNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			private HKNIJBILNIP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x4085FF0", Offset = "0x40849F0", VA = "0x184085FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KOLBJIDJMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x407F4B0", Offset = "0x407DEB0", VA = "0x18407F4B0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task <Run>b__0(HKNIJBILNIP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct ONIKMDKBIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public OHCLCMONFKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x4082C20", Offset = "0x4081620", VA = "0x184082C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class MDEPAADOFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public KKCPFDJMIOB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MDEPAADOFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x4080090", Offset = "0x407EA90", VA = "0x184080090")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x4080170", Offset = "0x407EB70", VA = "0x184080170")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private bool KJLOEOIECKF;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private static readonly ByteString NHPBIHMCNNE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x31D8D60", Offset = "0x31D7760", VA = "0x1831D8D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x31D8CE0", Offset = "0x31D76E0", VA = "0x1831D8CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x31D8DB0", Offset = "0x31D77B0", VA = "0x1831D8DB0")]
	[AsyncStateMachine(typeof(DKOJPBHCIFB))]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool KJLOEOIECKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x31D8F20", Offset = "0x31D7920", VA = "0x1831D8F20")]
	[AsyncStateMachine(typeof(ONIKMDKBIAC))]
	private Task KJENKEOBMBM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x31D85A0", Offset = "0x31D6FA0", VA = "0x1831D85A0")]
	private void GMDDFEJBDAG([NotNull] ALDNBFOLDOE BPNGJGFCADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x31D8CB0", Offset = "0x31D76B0", VA = "0x1831D8CB0")]
	private bool HFIBALIADBJ(KKCPFDJMIOB NHBDMCDLELK, ALDNBFOLDOE BPNGJGFCADO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct DACCIINPEOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct ELNMDINNAKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<JILMCFPJPGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public DACCIINPEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public GODEACJPJMC.HBIDCNLCNEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private HKNIJBILNIP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<(global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<ALDNBFOLDOE>, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<JHBALGJGKMA>, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<BMJGADAGPOB>, KFANFMGGLGP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x31C7D60", Offset = "0x31C6760", VA = "0x1831C7D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x31C8660", Offset = "0x31C7060", VA = "0x1831C8660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct EDKHHGGCLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public HKNIJBILNIP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public DACCIINPEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public GODEACJPJMC.HBIDCNLCNEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private TaskAwaiter<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x31C77F0", Offset = "0x31C61F0", VA = "0x1831C77F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x31C7D10", Offset = "0x31C6710", VA = "0x1831C7D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private global::FDGFCFNJPHA<KKANDLGEEGN, JHBALGJGKMA> LLCANMILKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private global::FDGFCFNJPHA<KKANDLGEEGN, ALDNBFOLDOE> CJCNIMFEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private global::FDGFCFNJPHA<long, BMJGADAGPOB> DJFAOPBHCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private BPFCNNOEDKB CMBIBHNCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private LLBNMMPGAFE HOLCMHHFICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private GJMMDEMBFND EBIPNHCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private string MLKOMNKNPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private KKANDLGEEGN DDEENGNPJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private KKANDLGEEGN OGGAFKMEPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private long FLLBKALBAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x27D1360", Offset = "0x27CFD60", VA = "0x1827D1360")]
	public static Task<JILMCFPJPGB> AKDODPKEJLG(BMMONKKCCCK FDPHPHDPLEL, in ACCNBLIHPFM HIDEHJGLNHO, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x27D1890", Offset = "0x27D0290", VA = "0x1827D1890")]
	[AsyncStateMachine(typeof(ELNMDINNAKE))]
	private Task<JILMCFPJPGB> KJENKEOBMBM(GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x27D16C0", Offset = "0x27D00C0", VA = "0x1827D16C0")]
	[AsyncStateMachine(typeof(EDKHHGGCLOM))]
	private Task<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> HJOCMNIODIM(string MLKOMNKNPAD, long FLLBKALBAKE, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, HKNIJBILNIP NABPNMJEMDF, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct GEEKIIOMCAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct EHCIEGGFEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public GEEKIIOMCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private HKNIJBILNIP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x3C71AA0", Offset = "0x3C704A0", VA = "0x183C71AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3C71E40", Offset = "0x3C70840", VA = "0x183C71E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct FHEELCJPDDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public GEEKIIOMCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x3C72390", Offset = "0x3C70D90", VA = "0x183C72390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3C725C0", Offset = "0x3C70FC0", VA = "0x183C725C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class NHOEGIFNOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NHOEGIFNOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1094E70", Offset = "0x1093870", VA = "0x181094E70")]
		internal bool <FetchRoomLoadDetails>b__0(GJMMDEMBFND sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct PGDCFJDALPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public KKANDLGEEGN superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public DEEFNALDPBL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private NHOEGIFNOBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private LLBNMMPGAFE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private GJMMDEMBFND <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private KKANDLGEEGN <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private KKANDLGEEGN <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private HKNIJBILNIP <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<LLBNMMPGAFE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<PDFKCDIAEML> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter<JEDNDCJMLKI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DF80", Offset = "0x3C7C980", VA = "0x183C7DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EB70", Offset = "0x3C7D570", VA = "0x183C7EB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private long LCIEPBGBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private long HBNJLALONNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private long DBCJFDIMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private string BPIEFHJHNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private KKANDLGEEGN ODMPNENECGO;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x27D7C90", Offset = "0x27D6690", VA = "0x1827D7C90")]
	public static Task<ACCNBLIHPFM> AKDODPKEJLG(BMMONKKCCCK FDPHPHDPLEL, MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x27D8150", Offset = "0x27D6B50", VA = "0x1827D8150")]
	[AsyncStateMachine(typeof(EHCIEGGFEHL))]
	private Task<ACCNBLIHPFM> KJENKEOBMBM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x27D7FD0", Offset = "0x27D69D0", VA = "0x1827D7FD0")]
	[AsyncStateMachine(typeof(FHEELCJPDDO))]
	private Task<ACCNBLIHPFM> BCDDBMPBINC(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x27D7E30", Offset = "0x27D6830", VA = "0x1827D7E30")]
	[AsyncStateMachine(typeof(PGDCFJDALPE))]
	private static Task<ACCNBLIHPFM> BCDDBMPBINC(DEEFNALDPBL NOHGMFJPJKL, long LCIEPBGBKGO, long HBNJLALONNE, long DBCJFDIMEGJ, string BPIEFHJHNGI, KKANDLGEEGN ODMPNENECGO, CancellationToken OIMNLGJCBEC, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x27D82B0", Offset = "0x27D6CB0", VA = "0x1827D82B0")]
	private void PFNFKKJEFJP(LLBNMMPGAFE HOLCMHHFICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct DAOHGPNNDJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct IKJCODAOFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public DAOHGPNNDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x3C76E10", Offset = "0x3C75810", VA = "0x183C76E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private const int CAGAPOCGKEH = 20;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private const float HNCJFKANEJL = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private float CMPDKCLKDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private float BOKPMNMIANB;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x27D1FC0", Offset = "0x27D09C0", VA = "0x1827D1FC0")]
	public static Task OPLKIAAAFLD(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x27D1DD0", Offset = "0x27D07D0", VA = "0x1827D1DD0")]
	[AsyncStateMachine(typeof(IKJCODAOFOG))]
	public Task KJENKEOBMBM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x27D1A20", Offset = "0x27D0420", VA = "0x1827D1A20")]
	private static void HGJADANGAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x27D1BF0", Offset = "0x27D05F0", VA = "0x1827D1BF0")]
	private void JKMBKPBBCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x27D1F00", Offset = "0x27D0900", VA = "0x1827D1F00")]
	private static float MGEDFJIKAAE(DEEFNALDPBL NOHGMFJPJKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x27D1BD0", Offset = "0x27D05D0", VA = "0x1827D1BD0")]
	private static float IPNOIKPNAAJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct AKFIENECIJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct CBLKKNBHKGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private IMKGIBOCLAG <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private BMMONKKCCCK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private KJDCOEEGILA.ECFFIIGPEHP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x31C5140", Offset = "0x31C3B40", VA = "0x1831C5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct IMHEJEJIEKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private JHMJCENAIID.KJOAPEIMACE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x31CEF00", Offset = "0x31CD900", VA = "0x1831CEF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x27C7DA0", Offset = "0x27C67A0", VA = "0x1827C7DA0")]
	[AsyncStateMachine(typeof(CBLKKNBHKGP))]
	public static Task KJENKEOBMBM(HAACNKIHLLI NLFLBJNDBCF, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x27C7B30", Offset = "0x27C6530", VA = "0x1827C7B30")]
	private static Task<IKENBFLEHKK> BKODKJBLBPF(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x27C7CD0", Offset = "0x27C66D0", VA = "0x1827C7CD0")]
	[AsyncStateMachine(typeof(IMHEJEJIEKC))]
	private static Task EFNKBIDDKBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct HKEGEJBOKEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct AKCFHONKPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public HKEGEJBOKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CAF0", Offset = "0x3C6B4F0", VA = "0x183C6CAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class PJPMJOADHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PJPMJOADHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F090", Offset = "0x3C7DA90", VA = "0x183C7F090")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct PAHPPMDOLJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public HKEGEJBOKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private KKNDEEAADEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DA10", Offset = "0x3C7C410", VA = "0x183C7DA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private bool KPOKLGHFIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private CancellationToken OIMNLGJCBEC;

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x27DBD30", Offset = "0x27DA730", VA = "0x1827DBD30")]
	public static Task BDDOBENBKOO(BMMONKKCCCK FDPHPHDPLEL, bool KPOKLGHFIJF, HKNIJBILNIP MJOCLEMBKBO, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x27DBED0", Offset = "0x27DA8D0", VA = "0x1827DBED0")]
	[AsyncStateMachine(typeof(AKCFHONKPMI))]
	private Task KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27DBDA0", Offset = "0x27DA7A0", VA = "0x1827DBDA0")]
	[AsyncStateMachine(typeof(PAHPPMDOLJN))]
	private Task IKOFHLPPMNO(bool LNHAKJNDEPA, string HJEGLBELAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	private bool AOJHIOFHKDG(bool KPOKLGHFIJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct LJNBJPAEFKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct GHOGBGGNLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public LJNBJPAEFKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x4079D90", Offset = "0x4078790", VA = "0x184079D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x407A1E0", Offset = "0x4078BE0", VA = "0x18407A1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class HOCKEKGEGLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HOCKEKGEGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x407B9D0", Offset = "0x407A3D0", VA = "0x18407B9D0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct KEPGJOEOIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public LJNBJPAEFKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private KKNDEEAADEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x407DA80", Offset = "0x407C480", VA = "0x18407DA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x407DFE0", Offset = "0x407C9E0", VA = "0x18407DFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private FHMMEOFOJJF EGMAMPAFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private bool ODFFBFCABBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x31D3550", Offset = "0x31D1F50", VA = "0x1831D3550")]
	public static Task<Scene> PKOPDPDOPKE(BMMONKKCCCK FDPHPHDPLEL, FHMMEOFOJJF IELOODOAAHH, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x31D3180", Offset = "0x31D1B80", VA = "0x1831D3180")]
	public static Task<Scene> ADMDPNHMEEP(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x31D33F0", Offset = "0x31D1DF0", VA = "0x1831D33F0")]
	[AsyncStateMachine(typeof(GHOGBGGNLJC))]
	private Task<Scene> KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x31D3520", Offset = "0x31D1F20", VA = "0x1831D3520")]
	private bool MMBGBCDHJJF(JILMCFPJPGB HIDEHJGLNHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x31D3380", Offset = "0x31D1D80", VA = "0x1831D3380")]
	private void JPEGALFJBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x31D3220", Offset = "0x31D1C20", VA = "0x1831D3220")]
	[AsyncStateMachine(typeof(KEPGJOEOIBD))]
	private Task<Scene> IKOFHLPPMNO(string HJEGLBELAHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct DCBCAALEHJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct OIJIPPDLHOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public DCBCAALEHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public DNNPENLDDEC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private HKNIJBILNIP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C7A0", Offset = "0x3C7B1A0", VA = "0x183C7C7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CD90", Offset = "0x3C7B790", VA = "0x183C7CD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct EGKCGGJLFOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public DCBCAALEHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public DNNPENLDDEC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x3C71310", Offset = "0x3C6FD10", VA = "0x183C71310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3C71590", Offset = "0x3C6FF90", VA = "0x183C71590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly BAAPIFCMJOI KFIKNPBGMBO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private IMKGIBOCLAG GLLMOCALFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x952090", Offset = "0x950A90", VA = "0x180952090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x27D2640", Offset = "0x27D1040", VA = "0x1827D2640")]
	public DCBCAALEHJL(HAACNKIHLLI NLFLBJNDBCF, BKMGDOEHDIH IOMMEAGMHCE, BAAPIFCMJOI KFIKNPBGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x27D24A0", Offset = "0x27D0EA0", VA = "0x1827D24A0")]
	[AsyncStateMachine(typeof(OIJIPPDLHOC))]
	public Task<DNNPENLDDEC> NFPENGHCHLM(DNNPENLDDEC PHEPHHCKDKI, JILMCFPJPGB IFDJIENGHHN, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool OMJOAEEENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x27D2300", Offset = "0x27D0D00", VA = "0x1827D2300")]
	[AsyncStateMachine(typeof(EGKCGGJLFOI))]
	private Task<DNNPENLDDEC> LILDAKABMBL(HKNIJBILNIP BDBJGJIIKDE, DNNPENLDDEC OJNFGJAPBNC, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x27D2470", Offset = "0x27D0E70", VA = "0x1827D2470")]
	private bool NFGDJNAFFLL(DNNPENLDDEC AOMIBLNHGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x27D2160", Offset = "0x27D0B60", VA = "0x1827D2160")]
	private void BMBLFHKAJNC(string HKNFNIPGHDE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct JNOLBGBAFPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct KJLHMBPNGLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private (PersistenceView, BADFNEBCNNH) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x3C77F30", Offset = "0x3C76930", VA = "0x183C77F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x27E3EA0", Offset = "0x27E28A0", VA = "0x1827E3EA0")]
	[AsyncStateMachine(typeof(KJLHMBPNGLO))]
	public static Task KJENKEOBMBM(IMKGIBOCLAG FFDDMJBLHEA, JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct CJPOPNMLDKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct IDIIICLBEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private KKCPFDJMIOB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private BADFNEBCNNH <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x31CC760", Offset = "0x31CB160", VA = "0x1831CC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x27D0EB0", Offset = "0x27CF8B0", VA = "0x1827D0EB0")]
	[AsyncStateMachine(typeof(IDIIICLBEDP))]
	public static Task KJENKEOBMBM(IMKGIBOCLAG FFDDMJBLHEA, JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct KJDCOEEGILA
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public struct ECFFIIGPEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public List<GILOJIOAKMI> AJIEBOJPLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public List<BADFNEBCNNH> FDJBEHGCCNN;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
		public ECFFIIGPEHP(List<GILOJIOAKMI> AJIEBOJPLLO, List<BADFNEBCNNH> FDJBEHGCCNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class AIELNFHIDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public IEnumerable<GILOJIOAKMI> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AIELNFHIDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CA70", Offset = "0x3C6B470", VA = "0x183C6CA70")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x27E5540", Offset = "0x27E3F40", VA = "0x1827E5540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x27E5590", Offset = "0x27E3F90", VA = "0x1827E5590")]
	public static ECFFIIGPEHP KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO)
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x27E55F0", Offset = "0x27E3FF0", VA = "0x1827E55F0")]
	private ECFFIIGPEHP KJENKEOBMBM()
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x27E5910", Offset = "0x27E4310", VA = "0x1827E5910")]
	private ECFFIIGPEHP KKNEDLPFKOI(ALDNBFOLDOE BPNGJGFCADO, KKCPFDJMIOB KENFHEPCHLB)
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x27E52F0", Offset = "0x27E3CF0", VA = "0x1827E52F0")]
	private bool ICNIONFFCDE(IEnumerable<GILOJIOAKMI> AJIEBOJPLLO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct BDBGJAIELDN
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class PLGLLGJBAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public KJDCOEEGILA.ECFFIIGPEHP instantiations;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PLGLLGJBAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x31DAFB0", Offset = "0x31D99B0", VA = "0x1831DAFB0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class MJAMBPPMCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MJAMBPPMCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x31D5A80", Offset = "0x31D4480", VA = "0x1831D5A80")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x27C9B50", Offset = "0x27C8550", VA = "0x1827C9B50")]
	public static void KJENKEOBMBM(IMKGIBOCLAG FFDDMJBLHEA, JILMCFPJPGB HIDEHJGLNHO, KJDCOEEGILA.ECFFIIGPEHP HHGDOEIHOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct HIDPJCEALJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KMHDMBEOKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3C78FA0", Offset = "0x3C779A0", VA = "0x183C78FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct OAPNJLBENIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public HIDPJCEALJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B900", Offset = "0x3C7A300", VA = "0x183C7B900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private ByteString FMCMGOJJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private bool OONOCBOIJAB;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x27DBA40", Offset = "0x27DA440", VA = "0x1827DBA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool EBBFPBACNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x27DB930", Offset = "0x27DA330", VA = "0x1827DB930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private bool AHHCOCINBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x27DB9B0", Offset = "0x27DA3B0", VA = "0x1827DB9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x27DBBC0", Offset = "0x27DA5C0", VA = "0x1827DBBC0")]
	[AsyncStateMachine(typeof(KMHDMBEOKOK))]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, bool OONOCBOIJAB, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x27DBA90", Offset = "0x27DA490", VA = "0x1827DBA90")]
	[AsyncStateMachine(typeof(OAPNJLBENIK))]
	private Task KJENKEOBMBM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal class BAAPIFCMJOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct KOAMLDHMLEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public DNNPENLDDEC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x31D03C0", Offset = "0x31CEDC0", VA = "0x1831D03C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class BMCKBEOPEGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public BMCKBEOPEGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x4085EB0", Offset = "0x40848B0", VA = "0x184085EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public HKNIJBILNIP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BMCKBEOPEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x31C5020", Offset = "0x31C3A20", VA = "0x1831C5020")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct HBALKDMNPBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private BMCKBEOPEGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x31CB6F0", Offset = "0x31CA0F0", VA = "0x1831CB6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LIHENGIPJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private Dictionary<Guid, List<HEABMPIIHCO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x31D2B60", Offset = "0x31D1560", VA = "0x1831D2B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct PBDEFMCHDKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private Dictionary<Guid, List<HEABMPIIHCO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x31D9DA0", Offset = "0x31D87A0", VA = "0x1831D9DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class FMPCIFNOFLD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public HEABMPIIHCO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public FMPCIFNOFLD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x4083940", Offset = "0x4082340", VA = "0x184083940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public FNNOKHIDILJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public List<HEABMPIIHCO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FMPCIFNOFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x31C96E0", Offset = "0x31C80E0", VA = "0x1831C96E0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x31C98C0", Offset = "0x31C82C0", VA = "0x1831C98C0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(HEABMPIIHCO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x31C97D0", Offset = "0x31C81D0", VA = "0x1831C97D0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct LBLAPCBNIKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public FNNOKHIDILJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public List<HEABMPIIHCO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private FMPCIFNOFLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x31D0E00", Offset = "0x31CF800", VA = "0x1831D0E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct MPKADGMOCAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x31D60F0", Offset = "0x31D4AF0", VA = "0x1831D60F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class KKCICHMBGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KKCICHMBGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x31D01F0", Offset = "0x31CEBF0", VA = "0x1831D01F0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HGLMLEHKHDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x31CBD10", Offset = "0x31CA710", VA = "0x1831CBD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class IKHNOEEBBFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IKHNOEEBBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x31CD670", Offset = "0x31CC070", VA = "0x1831CD670")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct PMACCLOAOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x31DB060", Offset = "0x31D9A60", VA = "0x1831DB060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class PCBIJDFBMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PCBIJDFBMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x31DA2A0", Offset = "0x31D8CA0", VA = "0x1831DA2A0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private OBLBGKHHEIM KFIKNPBGMBO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private IMKGIBOCLAG GLLMOCALFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x850180", Offset = "0x84EB80", VA = "0x180850180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public BAAPIFCMJOI(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x27C8E40", Offset = "0x27C7840", VA = "0x1827C8E40")]
	[AsyncStateMachine(typeof(KOAMLDHMLEP))]
	public Task KJENKEOBMBM(DNNPENLDDEC MFHLKCFDMNF, JILMCFPJPGB IFDJIENGHHN, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x27C8570", Offset = "0x27C6F70", VA = "0x1827C8570")]
	[AsyncStateMachine(typeof(HBALKDMNPBP))]
	private Task BGAIEDFDJBP(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x27C8CE0", Offset = "0x27C76E0", VA = "0x1827C8CE0")]
	[AsyncStateMachine(typeof(LIHENGIPJMH))]
	private Task KEPKHNGFIHO(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x27C92B0", Offset = "0x27C7CB0", VA = "0x1827C92B0")]
	[AsyncStateMachine(typeof(PBDEFMCHDKN))]
	private Task LMJOGMGIBAB(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x27C9410", Offset = "0x27C7E10", VA = "0x1827C9410")]
	[AsyncStateMachine(typeof(LBLAPCBNIKG))]
	private Task MFKMJPLCBGE(Guid JIDHOAJGHNB, List<HEABMPIIHCO> OINFMBINCPE, FNNOKHIDILJ AICDAGLKCFE, JILMCFPJPGB HIDEHJGLNHO, CancellationToken MIFCLBEAOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x27C8B90", Offset = "0x27C7590", VA = "0x1827C8B90")]
	[AsyncStateMachine(typeof(MPKADGMOCAA))]
	private Task IECGNJDJGMF(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x27C8FA0", Offset = "0x27C79A0", VA = "0x1827C8FA0")]
	[AsyncStateMachine(typeof(HGLMLEHKHDO))]
	private Task KKPONEFJECI(Guid FHCPAMNAENB, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x27C88A0", Offset = "0x27C72A0", VA = "0x1827C88A0")]
	[AsyncStateMachine(typeof(PMACCLOAOFB))]
	private Task EMBDCKGELJA(Guid FHCPAMNAENB, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x27C89F0", Offset = "0x27C73F0", VA = "0x1827C89F0")]
	private void FHHHMNGEHEB(Guid FHCPAMNAENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x27C9550", Offset = "0x27C7F50", VA = "0x1827C9550")]
	private void PBNPNNLGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x27C86D0", Offset = "0x27C70D0", VA = "0x1827C86D0")]
	public Guid EKAGOMEGAJO(DNNPENLDDEC ALOFFKDKDOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x27C90E0", Offset = "0x27C7AE0", VA = "0x1827C90E0")]
	[CompilerGenerated]
	private object KLNKLOAMALO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct JAJCHAKPOGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct DNMKJPJHHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C701C0", Offset = "0x3C6EBC0", VA = "0x183C701C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C703C0", Offset = "0x3C6EDC0", VA = "0x183C703C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct BHKAJOKJGEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public JAJCHAKPOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D1C0", Offset = "0x3C6BBC0", VA = "0x183C6D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D710", Offset = "0x3C6C110", VA = "0x183C6D710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private ByteString FMCMGOJJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x27E2AB0", Offset = "0x27E14B0", VA = "0x1827E2AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool EBBFPBACNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x27E2960", Offset = "0x27E1360", VA = "0x1827E2960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool AHHCOCINBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x27E2A20", Offset = "0x27E1420", VA = "0x1827E2A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool GCPFINBFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x27E29E0", Offset = "0x27E13E0", VA = "0x1827E29E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x27E2B00", Offset = "0x27E1500", VA = "0x1827E2B00")]
	[AsyncStateMachine(typeof(DNMKJPJHHAC))]
	public static Task<bool> KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x27E2C90", Offset = "0x27E1690", VA = "0x1827E2C90")]
	[AsyncStateMachine(typeof(BHKAJOKJGEB))]
	private Task<bool> KJENKEOBMBM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public readonly struct DEIOFMFEJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	public readonly ALDNBFOLDOE? JJACLKJJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	public readonly PHJGAMCCJEB LMGJJLKHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	public readonly string? ENAGDNAMEFG;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyCollection<string> PJCKJLCFGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x27D2930", Offset = "0x27D1330", VA = "0x1827D2930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyDictionary<long, int> OOGCLIFJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x27D2950", Offset = "0x27D1350", VA = "0x1827D2950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x27D2970", Offset = "0x27D1370", VA = "0x1827D2970")]
	public DEIOFMFEJDI(ALDNBFOLDOE? GOKPFGBACOI, PHJGAMCCJEB PODOLEPJFNP, string? MLKOMNKNPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class HGEJIOHJADL : PPKCBLMJCHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct HGAPJKEDKLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder<DEIOFMFEJDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C74BD0", Offset = "0x3C735D0", VA = "0x183C74BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C750B0", Offset = "0x3C73AB0", VA = "0x183C750B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class GLGFFLLNABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GLGFFLLNABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C73F90", Offset = "0x3C72990", VA = "0x183C73F90")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C741D0", Offset = "0x3C72BD0", VA = "0x183C741D0")]
		internal Task <PreserializeViews>b__2(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class NMJBFGHNHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public GLGFFLLNABD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NMJBFGHNHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B890", Offset = "0x3C7A290", VA = "0x183C7B890")]
		internal object <PreserializeViews>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class JFPDMFMJNDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public GLGFFLLNABD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JFPDMFMJNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C77850", Offset = "0x3C76250", VA = "0x183C77850")]
		internal Task <PreserializeViews>b__5(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct LIAIAGHEBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private NMJBFGHNHBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C79920", Offset = "0x3C78320", VA = "0x183C79920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private readonly JHJMJFFJEOO KJHKAEFGNNP;

	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private static readonly TimeSpan FCAMKDJAGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private readonly GIFKACLJBBM NMPIHBIODLD;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x27DB860", Offset = "0x27DA260", VA = "0x1827DB860")]
	public HGEJIOHJADL(HAACNKIHLLI NLFLBJNDBCF, GIFKACLJBBM NMPIHBIODLD, [Optional] JHJMJFFJEOO? KJHKAEFGNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x27DB060", Offset = "0x27D9A60", VA = "0x1827DB060")]
	[AsyncStateMachine(typeof(HGAPJKEDKLG))]
	public Task<DEIOFMFEJDI> HLHCEBOKDMG(long HBNJLALONNE, string MLKOMNKNPAD, OAGGKMECOKN CFEABAFCLMD, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x27DA640", Offset = "0x27D9040", VA = "0x1827DA640")]
	[AsyncStateMachine(typeof(LIAIAGHEBCG))]
	private Task AFBJIDDILJF(OAGGKMECOKN CFEABAFCLMD, IEnumerable<PersistenceView> HMBHDLPJNBB, StringBuilder AGMJAIEIFKK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x27DB1E0", Offset = "0x27D9BE0", VA = "0x1827DB1E0")]
	private DEIOFMFEJDI OBJFMJBAAOI(long HBNJLALONNE, string MLKOMNKNPAD, OAGGKMECOKN CFEABAFCLMD, IEnumerable<PersistenceView> HMBHDLPJNBB, StringBuilder AGMJAIEIFKK)
	{
		return default(DEIOFMFEJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x27DA7A0", Offset = "0x27D91A0", VA = "0x1827DA7A0")]
	private ALDNBFOLDOE BGDNACNNBHB(long HBNJLALONNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x27DA910", Offset = "0x27D9310", VA = "0x1827DA910")]
	private void EGIILNFOLEG(ALDNBFOLDOE CDNGHHDCBMA, StringBuilder AGMJAIEIFKK, IEnumerable<PersistenceView> HMBHDLPJNBB, in IEPIAGALNAB COEEJIEMCIP, ref NMGEBKPMOHP HCKNFNGDNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x27DAB30", Offset = "0x27D9530", VA = "0x1827DAB30")]
	private void HFFKHFHFNAJ(ALDNBFOLDOE CDNGHHDCBMA, StringBuilder AGMJAIEIFKK, PersistenceView KANBPIJHFNA, ref NMGEBKPMOHP HCKNFNGDNJB, in IEPIAGALNAB COEEJIEMCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal class LBHMAKJMHJK : PPKCBLMJCHH
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class AKBDJJGNNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AKBDJJGNNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x4074D50", Offset = "0x4073750", VA = "0x184074D50")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x4074DE0", Offset = "0x40737E0", VA = "0x184074DE0")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x4074E30", Offset = "0x4073830", VA = "0x184074E30")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x4074EA0", Offset = "0x40738A0", VA = "0x184074EA0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct ECAFGMAJAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public AsyncTaskMethodBuilder<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private AKBDJJGNNPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter<JJALEIDMEJJ.PDLFMNIBJJO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x40770D0", Offset = "0x4075AD0", VA = "0x1840770D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x4077B90", Offset = "0x4076590", VA = "0x184077B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct NKCBMOKNGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AsyncTaskMethodBuilder<HJAFOAIDLLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private TaskAwaiter<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter<HJAFOAIDLLN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x4081300", Offset = "0x407FD00", VA = "0x184081300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x40817C0", Offset = "0x40801C0", VA = "0x1840817C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct CMGCICLEFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public AsyncTaskMethodBuilder<PDFKCDIAEML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private TaskAwaiter<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<PDFKCDIAEML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4075FB0", Offset = "0x40749B0", VA = "0x184075FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x4076340", Offset = "0x4074D40", VA = "0x184076340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class LLIMHCACMKJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000666")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000667")]
			public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public LLIMHCACMKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private IKENBFLEHKK <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private TaskAwaiter<PDFKCDIAEML> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<HJAFOAIDLLN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<IKENBFLEHKK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x40865E0", Offset = "0x4084FE0", VA = "0x1840865E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x4087040", Offset = "0x4085A40", VA = "0x184087040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LLIMHCACMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x407FA80", Offset = "0x407E480", VA = "0x18407FA80")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<IKENBFLEHKK> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct OJOLKCONFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x40823C0", Offset = "0x4080DC0", VA = "0x1840823C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x4082670", Offset = "0x4081070", VA = "0x184082670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private const float HGOJILFKIEA = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private readonly FHAMAIJMDNM LAGCFKDBBCN;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private BMMONKKCCCK OABOAPFBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x27E82A0", Offset = "0x27E6CA0", VA = "0x1827E82A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x31D0D40", Offset = "0x31CF740", VA = "0x1831D0D40")]
	public LBHMAKJMHJK(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x31D0A40", Offset = "0x31CF440", VA = "0x1831D0A40")]
	[AsyncStateMachine(typeof(ECAFGMAJAEM))]
	private Task<(JJALEIDMEJJ.PDLFMNIBJJO, JJALEIDMEJJ.PDLFMNIBJJO)> MICFCALGOCD(DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x31D0700", Offset = "0x31CF100", VA = "0x1831D0700")]
	[AsyncStateMachine(typeof(NKCBMOKNGEF))]
	public Task<HJAFOAIDLLN> DNJGKEGEGHH(int OMKBGDEDOFD, [CanBeNull] HOCIJINOOAM JKFBHFINEFL, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D0BB0", Offset = "0x31CF5B0", VA = "0x1831D0BB0")]
	[AsyncStateMachine(typeof(CMGCICLEFMI))]
	private Task<PDFKCDIAEML> NAODHNMCAFM(string BPIEFHJHNGI, int OMKBGDEDOFD, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x31D0890", Offset = "0x31CF290", VA = "0x1831D0890")]
	[AsyncStateMachine(typeof(OJOLKCONFGO))]
	public Task<IKENBFLEHKK> FPNJCAHKCCN(int OMKBGDEDOFD, [CanBeNull] HOCIJINOOAM JKFBHFINEFL, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public abstract class GKKCPHAHENL<T> where T : global::GKKCPHAHENL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	internal readonly BMMONKKCCCK EHNFFFHJPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private int? EILHMIAEIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	protected readonly Guid ENBLPOIGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	protected readonly NNHCJPLIFIC IHKDPGBOAEG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	protected T KBFNKOGCMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3472660", Offset = "0x3471060", VA = "0x183472660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x34729B0", Offset = "0x34713B0", VA = "0x1834729B0")]
	internal GKKCPHAHENL(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x3472740", Offset = "0x3471140", VA = "0x183472740")]
	private IKENBFLEHKK KPPFPOJHKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	protected virtual void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3472820", Offset = "0x3471220", VA = "0x183472820")]
	public T NCMPELKBFDE(IEIHKFAAJEG DCELPOHIPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x34726C0", Offset = "0x34710C0", VA = "0x1834726C0")]
	public T HIIILDLHOHJ(int HFBAGNHDHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x34728B0", Offset = "0x34712B0", VA = "0x1834728B0", Slot = "5")]
	public virtual Task<IOCLDNFCAPD> NHHHFJJDOMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public class OMKLGDOBJIE : global::GKKCPHAHENL<OMKLGDOBJIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private MPCCILKBHMP GJNIFGAPEDN;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x31D9650", Offset = "0x31D8050", VA = "0x1831D9650")]
	internal OMKLGDOBJIE(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x31D9570", Offset = "0x31D7F70", VA = "0x1831D9570")]
	public OMKLGDOBJIE DNGPOBFPCBI(MPCCILKBHMP GJNIFGAPEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x31D9590", Offset = "0x31D7F90", VA = "0x1831D9590", Slot = "4")]
	protected override void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public class LBOANMGHMJK : global::GKKCPHAHENL<LBOANMGHMJK>
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	internal enum JGHIDABCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct OLIGJNODGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public LBOANMGHMJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x40826C0", Offset = "0x40810C0", VA = "0x1840826C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x40829C0", Offset = "0x40813C0", VA = "0x1840829C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private JGHIDABCEBP BONPGNGNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private string DGFLIDNPKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private HOCIJINOOAM GJNIFGAPEDN;

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x31D1720", Offset = "0x31D0120", VA = "0x1831D1720")]
	internal LBOANMGHMJK(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x31D13A0", Offset = "0x31CFDA0", VA = "0x1831D13A0")]
	public LBOANMGHMJK BCEJDAJNILJ(string NFBKGEMICGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x31D13D0", Offset = "0x31CFDD0", VA = "0x1831D13D0")]
	public LBOANMGHMJK DNIAHFMHKHD(bool GBJMEPJPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x31D1560", Offset = "0x31CFF60", VA = "0x1831D1560")]
	public LBOANMGHMJK GDONABALJJG(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x31D1590", Offset = "0x31CFF90", VA = "0x1831D1590")]
	public LBOANMGHMJK IDBOEIOBKEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x31D13F0", Offset = "0x31CFDF0", VA = "0x1831D13F0", Slot = "4")]
	protected override void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x31D1600", Offset = "0x31D0000", VA = "0x1831D1600", Slot = "5")]
	[AsyncStateMachine(typeof(OLIGJNODGEF))]
	public override Task<IOCLDNFCAPD> NHHHFJJDOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x31D15C0", Offset = "0x31CFFC0", VA = "0x1831D15C0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IOCLDNFCAPD> MLCOFNDDDHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal static class DOKANKCIMJF
{
	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x27D3C50", Offset = "0x27D2650", VA = "0x1827D3C50")]
	public static void JADMILDBJIK(this HEMLBBFAKKA BJANLLJJEBF, OFCNMCIOFIM LGHKHDGGALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x27D3DA0", Offset = "0x27D27A0", VA = "0x1827D3DA0")]
	public static void OGDCIMBPLHM(this OFCNMCIOFIM GPGKFDLHFHG, [Optional] string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public static class MOEKALLIIHN
{
	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x31D5F40", Offset = "0x31D4940", VA = "0x1831D5F40")]
	public static KKANDLGEEGN HIIPPGGIEKE(this HIGECGKJAFG GELIMIHGABP)
	{
		return default(KKANDLGEEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x31D5FE0", Offset = "0x31D49E0", VA = "0x1831D5FE0")]
	public static HIGECGKJAFG LOFFJEMNGKB(this KKANDLGEEGN ONPMPIEOPNF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public IEAAFONNOPI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000690")]
			public IEAAFONNOPI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private static IEAAFONNOPI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private Dictionary<IEAAFONNOPI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x31DDDA0", Offset = "0x31DC7A0", VA = "0x1831DDDA0")]
		public bool NHCBKGGNMOE(IEAAFONNOPI LBAAOGIJHJE, out ResultConfig ELAELJDAGOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x31DDC80", Offset = "0x31DC680", VA = "0x1831DDC80")]
		public ResultConfig DCIEHLLMIPI(IEAAFONNOPI JALEHBMHNHI, [Optional] HashSet<IEAAFONNOPI> LGOFJIJLBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x31DE390", Offset = "0x31DCD90", VA = "0x1831DE390", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x31DDE10", Offset = "0x31DC810", VA = "0x1831DDE10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public static class BPAJOCGBKCB
{
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x27CFDB0", Offset = "0x27CE7B0", VA = "0x1827CFDB0")]
	[JDDIJBKLPJE(GHILFLKBMBN.GameOnly)]
	private static void JCIGPGHKKDF(AOONKACGDKK HBEJHFKCBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public interface LFLMMDJMDFC : IEquatable<LFLMMDJMDFC>
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	DateTime JKMAICDIODN
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJBDOLGCLHN();

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLHHIJEDKJM(long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class EMKDILGOEIK : NHAGLHPLIJK
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class MEHPCLMKBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MEHPCLMKBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x3C7AE20", Offset = "0x3C79820", VA = "0x183C7AE20")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly JPGOGPHHBDL IODEPELPLCG;

	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private const int KCLBMAOBLKG = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<LFLMMDJMDFC> DHMDPDCJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x27D5880", Offset = "0x27D4280", VA = "0x1827D5880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x27D5C60", Offset = "0x27D4660", VA = "0x1827D5C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	[UnityEngine.Scripting.Preserve]
	public EMKDILGOEIK([LIKONNNLKGK(null)] JPGOGPHHBDL IODEPELPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x27D60F0", Offset = "0x27D4AF0", VA = "0x1827D60F0", Slot = "6")]
	public bool PPPMCGGAEGO(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x27D5AA0", Offset = "0x27D44A0", VA = "0x1827D5AA0")]
	private void BEPIEOCAFCB(LFLMMDJMDFC DADNHALGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x27D5920", Offset = "0x27D4320", VA = "0x1827D5920", Slot = "7")]
	public bool BEOJKECKOLL(long LCIEPBGBKGO, long HBNJLALONNE, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x27D57D0", Offset = "0x27D41D0", VA = "0x1827D57D0", Slot = "8")]
	public bool AAMPCPPNAGP(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x27D5D00", Offset = "0x27D4700", VA = "0x1827D5D00")]
	private void LFOPDJHHLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x27D5B40", Offset = "0x27D4540", VA = "0x1827D5B40", Slot = "9")]
	public void CCFPKNBIJPM(long LCIEPBGBKGO, long HBNJLALONNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal abstract class DHJPAFIILJE : JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	protected enum IJIJCFCKAAC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class DDEOECEIDMN : IEnumerable<LFLMMDJMDFC>, IEnumerable, IEnumerator<LFLMMDJMDFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private LFLMMDJMDFC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public DHJPAFIILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public GDONNAAGMMP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private LFLMMDJMDFC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public DDEOECEIDMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F150", Offset = "0x3C6DB50", VA = "0x183C6F150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F360", Offset = "0x3C6DD60", VA = "0x183C6F360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F2B0", Offset = "0x3C6DCB0", VA = "0x183C6F2B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LFLMMDJMDFC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F2B0", Offset = "0x3C6DCB0", VA = "0x183C6F2B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class CKEGAHKNCIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public CKEGAHKNCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E640", Offset = "0x3C6D040", VA = "0x183C6E640")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class NAFPBLNHBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public DHJPAFIILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NAFPBLNHBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B540", Offset = "0x3C79F40", VA = "0x183C7B540")]
		internal void <TryReadAutosaveFile>b__0(ELNBDCJFCIL.OGLDJMJGPJB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	protected readonly string PEOCEIGFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private readonly object NONHFDBGPNH;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x27D3340", Offset = "0x27D1D40", VA = "0x1827D3340")]
	protected DHJPAFIILJE([CanBeNull] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x27D3160", Offset = "0x27D1B60", VA = "0x1827D3160", Slot = "5")]
	public bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x27D2DC0", Offset = "0x27D17C0", VA = "0x1827D2DC0", Slot = "6")]
	[IteratorStateMachine(typeof(DDEOECEIDMN))]
	public IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x27D2A70", Offset = "0x27D1470", VA = "0x1827D2A70", Slot = "7")]
	public LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x27D2E40", Offset = "0x27D1840", VA = "0x1827D2E40")]
	protected void NIEOADLLEKK(ELNBDCJFCIL.OGLDJMJGPJB CHANIHNLGDA, string HKNFNIPGHDE, FileInfo OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x27D2EB0", Offset = "0x27D18B0", VA = "0x1827D2EB0")]
	internal bool OMEEOAFCCJP(FileInfo JGIGLBPNCEL, long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private void LOGMGDKOLCI(Exception JIBCJCBDLGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class JFJPNOLJFEB : DHJPAFIILJE
{
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private const string CMDKJOJBPLN = "V2";

	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private const string BMPNEAFAJIG = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private const string MGFHKANIGKJ = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public override COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xEFD480", Offset = "0xEFBE80", VA = "0x180EFD480", Slot = "8")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x27E3790", Offset = "0x27E2190", VA = "0x1827E3790")]
	public JFJPNOLJFEB([Optional] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x27E2DF0", Offset = "0x27E17F0", VA = "0x1827E2DF0")]
	private void JHEPPKCIPLA(GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x27E3490", Offset = "0x27E1E90", VA = "0x1827E3490", Slot = "9")]
	internal override void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x27E2F60", Offset = "0x27E1960", VA = "0x1827E2F60", Slot = "10")]
	internal override bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x27E2E70", Offset = "0x27E1870", VA = "0x1827E2E70", Slot = "11")]
	protected override FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x27E3680", Offset = "0x27E2080", VA = "0x1827E3680", Slot = "12")]
	protected override DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal sealed class AEIMHNOEHLD : DHJPAFIILJE
{
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private static readonly byte[] OGFDNCPKECB;

	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private const string BMPNEAFAJIG = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	private const string MGFHKANIGKJ = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private const string DNKJBFAIBIO = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private readonly byte[] IHBGAOFFBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly byte[] POCCNOANFJF;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD00", Offset = "0x7C9700", VA = "0x1807CAD00", Slot = "8")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x27C6DD0", Offset = "0x27C57D0", VA = "0x1827C6DD0")]
	public AEIMHNOEHLD([Optional] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x27C68D0", Offset = "0x27C52D0", VA = "0x1827C68D0", Slot = "9")]
	internal override void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x27C6190", Offset = "0x27C4B90", VA = "0x1827C6190", Slot = "10")]
	internal override bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x27C6B20", Offset = "0x27C5520", VA = "0x1827C6B20")]
	private void NGLGMFPCKDA(byte[] EMIAMELGKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x27C6060", Offset = "0x27C4A60", VA = "0x1827C6060", Slot = "11")]
	protected override FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x27C6C30", Offset = "0x27C5630", VA = "0x1827C6C30", Slot = "12")]
	protected override DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public enum COHFILLHMHP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class FDHGHOFCDMG : JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class ABHJFFBGPNI : IEnumerable<LFLMMDJMDFC>, IEnumerable, IEnumerator<LFLMMDJMDFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private LFLMMDJMDFC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public FDHGHOFCDMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public GDONNAAGMMP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private COHFILLHMHP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private IEnumerator<LFLMMDJMDFC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private LFLMMDJMDFC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public ABHJFFBGPNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C920", Offset = "0x3C6B320", VA = "0x183C6C920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C550", Offset = "0x3C6AF50", VA = "0x183C6C550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C9B0", Offset = "0x3C6B3B0", VA = "0x183C6C9B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C8E0", Offset = "0x3C6B2E0", VA = "0x183C6C8E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C830", Offset = "0x3C6B230", VA = "0x183C6C830", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LFLMMDJMDFC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C830", Offset = "0x3C6B230", VA = "0x183C6C830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private readonly COHFILLHMHP[] CPJGHPHOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private readonly Dictionary<COHFILLHMHP, JPGOGPHHBDL> HEBMKPINHGF;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x27D67B0", Offset = "0x27D51B0", VA = "0x1827D67B0", Slot = "4")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x27D69D0", Offset = "0x27D53D0", VA = "0x1827D69D0")]
	[UnityEngine.Scripting.Preserve]
	public FDHGHOFCDMG(params JPGOGPHHBDL[] JCJNIPGAILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x27D6870", Offset = "0x27D5270", VA = "0x1827D6870", Slot = "5")]
	public bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x27D6480", Offset = "0x27D4E80", VA = "0x1827D6480")]
	private void GJHDGIPNPIH(int DMJDBHDDPFL, long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x27D67F0", Offset = "0x27D51F0", VA = "0x1827D67F0", Slot = "6")]
	[IteratorStateMachine(typeof(ABHJFFBGPNI))]
	public IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x27D66C0", Offset = "0x27D50C0", VA = "0x1827D66C0", Slot = "7")]
	public LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class PNFBLAJFOPL
{
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	internal const int HPPNBLEONOE = 32;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x31DB890", Offset = "0x31DA290", VA = "0x1831DB890")]
	internal static byte[] DLFHDIHNOOA(byte[] EMIAMELGKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x31DBB10", Offset = "0x31DA510", VA = "0x1831DBB10")]
	public static void KOLEAOFNPLJ(Stream NEHKLODBFEL, byte[] MEHLKMBPJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x31DB930", Offset = "0x31DA330", VA = "0x1831DB930")]
	public static bool KAIONIFLOLO(Stream NEHKLODBFEL, long DALDPMCIIAF, JMABOBEGLPP FDLANEODAFF, out byte[] FHJBOIKJAIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal sealed class DLLDLLIACIC : LFLMMDJMDFC, IEquatable<LFLMMDJMDFC>, IEquatable<DLLDLLIACIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private readonly DHJPAFIILJE NLHOIDKNKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	public readonly FileInfo ODOFIOIALKE;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BD0", Offset = "0xAC55D0", VA = "0x180AC6BD0", Slot = "4")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public DateTime JKMAICDIODN
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x27D3610", Offset = "0x27D2010", VA = "0x1827D3610", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x27D3B50", Offset = "0x27D2550", VA = "0x1827D3B50")]
	public DLLDLLIACIC(DHJPAFIILJE HIBDEIOOCBK, FileInfo JGIGLBPNCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x27D3AA0", Offset = "0x27D24A0", VA = "0x1827D3AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x27D39E0", Offset = "0x27D23E0", VA = "0x1827D39E0", Slot = "6")]
	public void OJBDOLGCLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x27D35D0", Offset = "0x27D1FD0", VA = "0x1827D35D0", Slot = "7")]
	public bool BLHHIJEDKJM(long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x27D3860", Offset = "0x27D2260", VA = "0x1827D3860", Slot = "8")]
	public bool Equals(LFLMMDJMDFC MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x27D37B0", Offset = "0x27D21B0", VA = "0x1827D37B0", Slot = "9")]
	public bool Equals(DLLDLLIACIC MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x27D36B0", Offset = "0x27D20B0", VA = "0x1827D36B0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x27D3940", Offset = "0x27D2340", VA = "0x1827D3940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F130", Offset = "0x1C4DB30", VA = "0x181C4F130")]
	public static bool BOBJELOEACN(DLLDLLIACIC LJLKLAFAGNO, DLLDLLIACIC HFBAHIGFPIF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F510", Offset = "0x1C4DF10", VA = "0x181C4F510")]
	public static bool GPCPOEGFAHL(DLLDLLIACIC LJLKLAFAGNO, DLLDLLIACIC HFBAHIGFPIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public delegate void JMABOBEGLPP(ELNBDCJFCIL.OGLDJMJGPJB FDBGBIOHHGF, string BALNMHDNCIN);
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal interface JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x27E61B0", Offset = "0x27E4BB0", VA = "0x1827E61B0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x27E5E60", Offset = "0x27E4860", VA = "0x1827E5E60")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
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
