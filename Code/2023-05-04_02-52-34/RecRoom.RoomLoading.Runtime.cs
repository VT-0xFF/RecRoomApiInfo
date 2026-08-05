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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D360", Offset = "0x2F7C760", VA = "0x182F7D360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FBEFOPHLCLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25FC8B0", Offset = "0x25FBCB0", VA = "0x1825FC8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A42A70", Offset = "0x3A41E70", VA = "0x183A42A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A42C50", Offset = "0x3A42050", VA = "0x183A42C50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4B5C0", Offset = "0x3A4A9C0", VA = "0x183A4B5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B780", Offset = "0x3A4AB80", VA = "0x183A4B780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	[UnityEngine.Scripting.Preserve]
	public DCDOJDAIFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25F8C90", Offset = "0x25F8090", VA = "0x1825F8C90", Slot = "4")]
	[AsyncStateMachine(typeof(BHNOJIBGPFG))]
	public Task<IReadOnlyList<JEDNDCJMLKI>> OGFIPECONNA(long LCIEPBGBKGO, long HJCAHMBDEEM, [Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25F8B50", Offset = "0x25F7F50", VA = "0x1825F8B50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E05270", Offset = "0x3E04670", VA = "0x183E05270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3E056B0", Offset = "0x3E04AB0", VA = "0x183E056B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0A070", Offset = "0x3E09470", VA = "0x183E0A070", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7EC580", Offset = "0x7EB980", VA = "0x1807EC580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xF069A0", Offset = "0xF05DA0", VA = "0x180F069A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x73B4E0", Offset = "0x73A8E0", VA = "0x18073B4E0", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A090", Offset = "0x3E09490", VA = "0x183E0A090", Slot = "9")]
		[AsyncStateMachine(typeof(JKCHBIILIBA))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A3C0", Offset = "0x3E097C0", VA = "0x183E0A3C0")]
		public OIBHKDHHMPF(int LAJJMFBMNPC, LJHGFDHBFME JAONJGNPGMO, JEDNDCJMLKI AOMCOBDFALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A1C0", Offset = "0x3E095C0", VA = "0x183E0A1C0", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A250", Offset = "0x3E09650", VA = "0x183E0A250", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A2F0", Offset = "0x3E096F0", VA = "0x183E0A2F0")]
		private bool GPPPEAMKLPC(OIBHKDHHMPF MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A330", Offset = "0x3E09730", VA = "0x183E0A330", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E03C70", Offset = "0x3E03070", VA = "0x183E03C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3E03EB0", Offset = "0x3E032B0", VA = "0x183E03EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DFD8A0", Offset = "0x3DFCCA0", VA = "0x183DFD8A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LJHGFDHBFME LCPJOHEGCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDC00", Offset = "0x3DFD000", VA = "0x183DFDC00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime GLJBNDKPNOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD8F0", Offset = "0x3DFCCF0", VA = "0x183DFD8F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDCA0", Offset = "0x3DFD0A0", VA = "0x183DFDCA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDA60", Offset = "0x3DFCE60", VA = "0x183DFDA60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72FC40", Offset = "0x72F040", VA = "0x18072FC40", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8656E0", Offset = "0x864AE0", VA = "0x1808656E0")]
		public BEINOMKDCMD(LFLMMDJMDFC DADNHALGJFA, DJPJCNGKLKK KLFEMECHKEC, CGIIIFAOEOF BKOKOKDEANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD940", Offset = "0x3DFCD40", VA = "0x183DFD940", Slot = "9")]
		[AsyncStateMachine(typeof(IIPDPOGFFIO))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDB60", Offset = "0x3DFCF60", VA = "0x183DFDB60", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDAB0", Offset = "0x3DFCEB0", VA = "0x183DFDAB0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDCF0", Offset = "0x3DFD0F0", VA = "0x183DFDCF0")]
		private bool GPPPEAMKLPC(BEINOMKDCMD MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDD50", Offset = "0x3DFD150", VA = "0x183DFDD50", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E00230", Offset = "0x3DFF630", VA = "0x183E00230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3E00410", Offset = "0x3DFF810", VA = "0x183E00410", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E033E0", Offset = "0x3E027E0", VA = "0x183E033E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime GLJBNDKPNOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DJPJCNGKLKK? PAANIFELBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3E03830", Offset = "0x3E02C30", VA = "0x183E03830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CGIIIFAOEOF? BBODCAIIEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3E03550", Offset = "0x3E02950", VA = "0x183E03550", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JNLJFOIIPKM NLEFCLDLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "10")]
			get
			{
				return default(JNLJFOIIPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8656E0", Offset = "0x864AE0", VA = "0x1808656E0")]
		public HMIMKAJBGKP(LJHGFDHBFME JAONJGNPGMO, DJPJCNGKLKK KLFEMECHKEC, CGIIIFAOEOF BKOKOKDEANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3E03460", Offset = "0x3E02860", VA = "0x183E03460", Slot = "9")]
		[AsyncStateMachine(typeof(EHNIALIEBKD))]
		public Task<IOCLDNFCAPD> DLOLHIFGPEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E036F0", Offset = "0x3E02AF0", VA = "0x183E036F0", Slot = "11")]
		public bool Equals(EDHBDDIBAFN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E035A0", Offset = "0x3E029A0", VA = "0x183E035A0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E03980", Offset = "0x3E02D80", VA = "0x183E03980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E03880", Offset = "0x3E02C80", VA = "0x183E03880")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFE650", Offset = "0x3DFDA50", VA = "0x183DFE650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF0E0", Offset = "0x3DFE4E0", VA = "0x183DFF0E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E01420", Offset = "0x3E00820", VA = "0x183E01420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E01DA0", Offset = "0x3E011A0", VA = "0x183E01DA0", Slot = "5")]
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
	private readonly global::JNOHGJIOCHP<(long, long), IReadOnlyList<JEDNDCJMLKI>> LNGPBCOKBFF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B300", Offset = "0x2F7A700", VA = "0x182F7B300")]
	[UnityEngine.Scripting.Preserve]
	public MIELLCNLKHH([LIKONNNLKGK(null)] FDPAPOKOKPL AIABFMEGFAB, [LIKONNNLKGK(null)] NHAGLHPLIJK BOJGLIGENPI, [LIKONNNLKGK(null)] CFGBGFDLHJE OHKCEODLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B1B0", Offset = "0x2F7A5B0", VA = "0x182F7B1B0")]
	[AsyncStateMachine(typeof(DONHCBLLAAP))]
	public Task<IList<EDHBDDIBAFN>> JOMBHDMDPAK(long LCIEPBGBKGO, long HBNJLALONNE, bool GHIIHLIILBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AEC0", Offset = "0x2F7A2C0", VA = "0x182F7AEC0")]
	private bool ADMKJHELOPE(DateTime? PJAANDALBFA, long LCIEPBGBKGO, long HBNJLALONNE, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B070", Offset = "0x2F7A470", VA = "0x182F7B070")]
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
	[Cpp2IlInjected.Address(RVA = "0x25F69C0", Offset = "0x25F5DC0", VA = "0x1825F69C0")]
	public CGNOGDJLAKB(long IJNKGKEKKHE, long HJCAHMBDEEM, OJDNDNJMAGF OGILDIMGIOH, [CanBeNull] Exception EGHNIGPIDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25F6970", Offset = "0x25F5D70", VA = "0x1825F6970")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F7BA40", Offset = "0x2F7AE40", VA = "0x182F7BA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public IJOBCDJIKMP(OFCNMCIOFIM GPGKFDLHFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2604B80", Offset = "0x2603F80", VA = "0x182604B80")]
	public IJOBCDJIKMP KBAJKCGCKBG(string OGFDNCPKECB, string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2604B00", Offset = "0x2603F00", VA = "0x182604B00")]
	public bool FLMHAAJPNKD(out IEnumerable<KeyValuePair<string, string>> ABOOCHHDJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2484710", Offset = "0x2483B10", VA = "0x182484710")]
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
	void IOJJLENHCAP(long LCIEPBGBKGO, long HJCAHMBDEEM, LLBNMMPGAFE HOLCMHHFICL, JEDNDCJMLKI NDKCOMELGGK, DEIOFMFEJDI NKLMKCALAPJ, HOCIJINOOAM? JKFBHFINEFL, FCIBLCNJCKE? GCIONJIIJFG);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LODNMBFNNBA(long LCIEPBGBKGO, long HJCAHMBDEEM, FCIBLCNJCKE? GCIONJIIJFG);

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
	[Cpp2IlInjected.Address(RVA = "0x2603910", Offset = "0x2602D10", VA = "0x182603910", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4F600", Offset = "0x3A4EA00", VA = "0x183A4F600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F820", Offset = "0x3A4EC20", VA = "0x183A4F820", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A42300", Offset = "0x3A41700", VA = "0x183A42300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public OFPPDOAHFHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A517D0", Offset = "0x3A50BD0", VA = "0x183A517D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3A51C10", Offset = "0x3A51010", VA = "0x183A51C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A51B70", Offset = "0x3A50F70", VA = "0x183A51B70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FMGAKNBAMFM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A51B70", Offset = "0x3A50F70", VA = "0x183A51B70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B0A0", Offset = "0x72A4A0", VA = "0x18072B0A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF020", Offset = "0x7DE420", VA = "0x1807DF020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EOPCGGIHEON ABLGHPKODHE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D0", Offset = "0x72A4D0", VA = "0x18072B0D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF040", Offset = "0x7DE440", VA = "0x1807DF040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7DF050", Offset = "0x7DE450", VA = "0x1807DF050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HADNAKAMMKO FAFEJOEAODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x72B0C0", Offset = "0x72A4C0", VA = "0x18072B0C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7DF030", Offset = "0x7DE430", VA = "0x1807DF030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EEHMBIIEFAB LJIBLPFKMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72B040", Offset = "0x72A440", VA = "0x18072B040", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x73D2A0", Offset = "0x73C6A0", VA = "0x18073D2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public NJBDFOIOPMG LAPNCPHPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x72B050", Offset = "0x72A450", VA = "0x18072B050", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x74C820", Offset = "0x74BC20", VA = "0x18074C820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BKMGDOEHDIH NOOPFKJFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x802C90", Offset = "0x802090", VA = "0x180802C90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x74C800", Offset = "0x74BC00", VA = "0x18074C800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JJLJBFAGAMG COBJPNEFDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x803620", Offset = "0x802A20", VA = "0x180803620", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C30", Offset = "0x8C8030", VA = "0x1808C8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AELGLLIMFJF LNHAADMDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x765AF0", Offset = "0x764EF0", VA = "0x180765AF0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84FDF0", Offset = "0x84F1F0", VA = "0x18084FDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PEEFFMGKBAG JHEKMFNFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x803640", Offset = "0x802A40", VA = "0x180803640", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C8250", Offset = "0x8C7650", VA = "0x1808C8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HFHAFOIGEFC DGDHAEECBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x72B060", Offset = "0x72A460", VA = "0x18072B060", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x74C810", Offset = "0x74BC10", VA = "0x18074C810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LGDLLPOFLJK EJENBPKLMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x72B070", Offset = "0x72A470", VA = "0x18072B070", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xF80240", Offset = "0xF7F640", VA = "0x180F80240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public ILJHMLDGKCP KLDFKMKIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x72B090", Offset = "0x72A490", VA = "0x18072B090", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8038C0", Offset = "0x802CC0", VA = "0x1808038C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KIGMPHJHPJO EOFJOHKEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x72B080", Offset = "0x72A480", VA = "0x18072B080", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x74C830", Offset = "0x74BC30", VA = "0x18074C830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JJFNDJDCHPJ IKNGEFAPKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x800FF0", Offset = "0x8003F0", VA = "0x180800FF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8016F0", Offset = "0x800AF0", VA = "0x1808016F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DPJHHKMHBNI HODKIOEIFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x79EB50", Offset = "0x79DF50", VA = "0x18079EB50", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x801000", Offset = "0x800400", VA = "0x180801000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IIMPFBAAGHO FCEAPJMMCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8035E0", Offset = "0x8029E0", VA = "0x1808035E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8036F0", Offset = "0x802AF0", VA = "0x1808036F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public AFNCHCIFHKO FPBOIKJDNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x84D1C0", Offset = "0x84C5C0", VA = "0x18084D1C0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x84D2A0", Offset = "0x84C6A0", VA = "0x18084D2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FHAMAIJMDNM DOEJPFDEFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x801CB0", Offset = "0x8010B0", VA = "0x180801CB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x84DF10", Offset = "0x84D310", VA = "0x18084DF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NPFEPDLFMOF LLHFCAKALKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8019B0", Offset = "0x800DB0", VA = "0x1808019B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x801CE0", Offset = "0x8010E0", VA = "0x180801CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OLMODALHBEI HNLPAENGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x801990", Offset = "0x800D90", VA = "0x180801990", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x801CC0", Offset = "0x8010C0", VA = "0x180801CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AEEBLMOBCCO CCHCEJAALHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8019A0", Offset = "0x800DA0", VA = "0x1808019A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x801CD0", Offset = "0x8010D0", VA = "0x180801CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public KLLMDBOMELC DBMOOKIMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84DF00", Offset = "0x84D300", VA = "0x18084DF00", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xE06610", Offset = "0xE05A10", VA = "0x180E06610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MEACFOIHIKJ GIKDLNJLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x801C90", Offset = "0x801090", VA = "0x180801C90", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x801E30", Offset = "0x801230", VA = "0x180801E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FCFMBENHFCD DGDCJDNIDII
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x801CA0", Offset = "0x8010A0", VA = "0x180801CA0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x801E40", Offset = "0x801240", VA = "0x180801E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HKGOGNCIFMN LIOMPKHHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xEBD580", Offset = "0xEBC980", VA = "0x180EBD580", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xF2C190", Offset = "0xF2B590", VA = "0x180F2C190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EAMPFODMHGK MPIKPFLPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xEBD480", Offset = "0xEBC880", VA = "0x180EBD480", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xE065C0", Offset = "0xE059C0", VA = "0x180E065C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public NHAGLHPLIJK LJKEJGNOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xEBD4F0", Offset = "0xEBC8F0", VA = "0x180EBD4F0", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBD450", Offset = "0xEBC850", VA = "0x180EBD450", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x953200", Offset = "0x952600", VA = "0x180953200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool JMNIBOCFINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x26062F0", Offset = "0x26056F0", VA = "0x1826062F0", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool JLOJLADEKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2605FB0", Offset = "0x26053B0", VA = "0x182605FB0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private Task POGMGJHPILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2605C80", Offset = "0x2605080", VA = "0x182605C80", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CancellationToken FLCAFBABCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2605AC0", Offset = "0x2604EC0", VA = "0x182605AC0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private AOONKACGDKK LDBOJKECIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action GMAMLHBDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x26058D0", Offset = "0x2604CD0", VA = "0x1826058D0", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2605C20", Offset = "0x2605020", VA = "0x182605C20", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event JMJJONCEBOH KNENCDPGOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2606300", Offset = "0x2605700", VA = "0x182606300", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2606290", Offset = "0x2605690", VA = "0x182606290", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event JMJJONCEBOH AGDJJMBGEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2605F50", Offset = "0x2605350", VA = "0x182605F50", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2605B40", Offset = "0x2604F40", VA = "0x182605B40", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event JMJJONCEBOH LCJAJLBMOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2605CD0", Offset = "0x26050D0", VA = "0x182605CD0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2605D30", Offset = "0x2605130", VA = "0x182605D30", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<PGPGCAPEPDK, bool> PDNJIKNJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2605AE0", Offset = "0x2604EE0", VA = "0x182605AE0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2605D90", Offset = "0x2605190", VA = "0x182605D90", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x953200", Offset = "0x952600", VA = "0x180953200", Slot = "34")]
	public void IJDDNPGBEOH(BGLENBCKMJG NPOMHAEFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2606360", Offset = "0x2605760", VA = "0x182606360")]
	[UnityEngine.Scripting.Preserve]
	internal INJKABCABOH([LIKONNNLKGK(null)] AOONKACGDKK ONILLNPEPMK, [LIKONNNLKGK(null)] OGCACIFJDCP KEHCECCODAM, [LIKONNNLKGK(null)] EOPCGGIHEON LLLBGFHENIG, [LIKONNNLKGK(null)] DEEFNALDPBL NOHGMFJPJKL, [LIKONNNLKGK(null)] HADNAKAMMKO NPPPNEAAJPB, [LIKONNNLKGK(null)] EEHMBIIEFAB CCDCJPHJEHM, [LIKONNNLKGK(null)] NJBDFOIOPMG DIJGJGFMIIJ, [LIKONNNLKGK(null)] BKMGDOEHDIH IOMMEAGMHCE, [LIKONNNLKGK(null)] JJLJBFAGAMG CLODEIMPHIO, [LIKONNNLKGK(null)] AELGLLIMFJF HNACKNAPKOP, [LIKONNNLKGK(null)] PEEFFMGKBAG ADLONPJHLHJ, [LIKONNNLKGK(null)] HFHAFOIGEFC JGFNDHPFBOH, [LIKONNNLKGK(null)] LGDLLPOFLJK KMLKPEPDMBJ, [LIKONNNLKGK(null)] ILJHMLDGKCP LEDLKKDMDKA, [LIKONNNLKGK(null)] KIGMPHJHPJO EKNJIAIJLFK, [LIKONNNLKGK(null)] JJFNDJDCHPJ ANACADHKCDM, [LIKONNNLKGK(null)] DPJHHKMHBNI KLAJNPJNFGH, [LIKONNNLKGK(null)] IIMPFBAAGHO OGMILOCAJLG, [LIKONNNLKGK(null)] AFNCHCIFHKO ILBHLPCBMEE, [LIKONNNLKGK(null)] FHAMAIJMDNM LAGCFKDBBCN, [LIKONNNLKGK(null)] OLMODALHBEI PAHCHPMOCNE, [LIKONNNLKGK(null)] NPFEPDLFMOF BEELBGNKLAA, [LIKONNNLKGK(null)] AEEBLMOBCCO MJCHNIAODLH, [LIKONNNLKGK(null)] KLLMDBOMELC KPABCGELMLL, [LIKONNNLKGK(null)] MEACFOIHIKJ PMOEGAOHFBL, [LIKONNNLKGK(null)] HKGOGNCIFMN ELAELJDAGOI, [LIKONNNLKGK(null)] EAMPFODMHGK FACLDIPADPH, [LIKONNNLKGK(null)] NHAGLHPLIJK EJJOFJIJONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2605E60", Offset = "0x2605260", VA = "0x182605E60")]
	private void KADCCJJCHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2605930", Offset = "0x2604D30", VA = "0x182605930", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2605800", Offset = "0x2604C00", VA = "0x182605800", Slot = "48")]
	private void BBFPHKNHGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2605850", Offset = "0x2604C50", VA = "0x182605850", Slot = "49")]
	private OMKLGDOBJIE CKLDBAOKMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2605BA0", Offset = "0x2604FA0", VA = "0x182605BA0", Slot = "50")]
	private LBOANMGHMJK GEGDCHKMFOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2606030", Offset = "0x2605430", VA = "0x182606030", Slot = "51")]
	[AsyncStateMachine(typeof(LKLLKPPKMIA))]
	private Task<IOCLDNFCAPD> NBLODFBBBMI(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2606170", Offset = "0x2605570", VA = "0x182606170", Slot = "52")]
	[AsyncStateMachine(typeof(AKDMCJBINLN))]
	private Task NCAPNNBMANM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2605DF0", Offset = "0x26051F0", VA = "0x182605DF0")]
	[IteratorStateMachine(typeof(OFPPDOAHFHH))]
	private IEnumerable<FMGAKNBAMFM> JGJNDKHAHLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26057A0", Offset = "0x2604BA0", VA = "0x1826057A0")]
	[CompilerGenerated]
	private void AFDJLBJCCKN(FMGAKNBAMFM AFCHMEJMNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KHCFHOJJGOI : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1835A10", Offset = "0x1834E10", VA = "0x181835A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4B1E0", Offset = "0x3A4A5E0", VA = "0x183A4B1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B570", Offset = "0x3A4A970", VA = "0x183A4B570", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public JKNMKAKFPMO(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2609D40", Offset = "0x2609140", VA = "0x182609D40", Slot = "4")]
	[AsyncStateMachine(typeof(IBLADCAONEB))]
	public Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2609E60", Offset = "0x2609260", VA = "0x182609E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E06090", Offset = "0x3E05490", VA = "0x183E06090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E066E0", Offset = "0x3E05AE0", VA = "0x183E066E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F78370", Offset = "0x2F77770", VA = "0x182F78370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public LGEIMBCNGAC(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F78230", Offset = "0x2F77630", VA = "0x182F78230", Slot = "4")]
	[AsyncStateMachine(typeof(KLIGAHBBAIM))]
	public Task<bool> CPGGICLGFOG(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F783C0", Offset = "0x2F777C0", VA = "0x182F783C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PKHBCMPPHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B750", Offset = "0x3E0AB50", VA = "0x183E0B750")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B8A0", Offset = "0x3E0ACA0", VA = "0x183E0B8A0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B910", Offset = "0x3E0AD10", VA = "0x183E0B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E02A30", Offset = "0x3E01E30", VA = "0x183E02A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E03320", Offset = "0x3E02720", VA = "0x183E03320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7CFC0", Offset = "0x2F7C3C0", VA = "0x182F7CFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public NMIFDGELOIF(BMMONKKCCCK FDPHPHDPLEL, DEEFNALDPBL NOHGMFJPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CE80", Offset = "0x2F7C280", VA = "0x182F7CE80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MNKEDBOPHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A509B0", Offset = "0x3A4FDB0", VA = "0x183A509B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4CE80", Offset = "0x3A4C280", VA = "0x183A4CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D390", Offset = "0x3A4C790", VA = "0x183A4D390", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4E620", Offset = "0x3A4DA20", VA = "0x183A4E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2603540", Offset = "0x2602940", VA = "0x182603540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2603610", Offset = "0x2602A10", VA = "0x182603610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2603590", Offset = "0x2602990", VA = "0x182603590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private AELGLLIMFJF LNHAADMDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x26034F0", Offset = "0x26028F0", VA = "0x1826034F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x26038D0", Offset = "0x2602CD0", VA = "0x1826038D0")]
	public IBHBEHKIOOK(CancellationToken OIMNLGJCBEC, BMMONKKCCCK CMIHNHHBGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2603190", Offset = "0x2602590", VA = "0x182603190")]
	public static CIPILANIGKL BGCBCDPLHMC(BMMONKKCCCK CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2603660", Offset = "0x2602A60", VA = "0x182603660")]
	[AsyncStateMachine(typeof(JLJIFHMKNOP))]
	public Task<bool> KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2603250", Offset = "0x2602650", VA = "0x182603250")]
	private bool BHGAGCCICJC(out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26033F0", Offset = "0x26027F0", VA = "0x1826033F0")]
	[AsyncStateMachine(typeof(KMKALKIAILB))]
	private Task FINPOABKCBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2603790", Offset = "0x2602B90", VA = "0x182603790")]
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
		[Cpp2IlInjected.Address(RVA = "0x25FA3A0", Offset = "0x25F97A0", VA = "0x1825FA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D04E00", Offset = "0x1D04200", VA = "0x181D04E00")]
	public EADEEJBAKAP(KIGMPHJHPJO EKNJIAIJLFK, Guid HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x25FA470", Offset = "0x25F9870", VA = "0x1825FA470")]
	public TaskAwaiter<(IOCLDNFCAPD, Task)> ONFHCEEPMHH()
	{
		return default(TaskAwaiter<(IOCLDNFCAPD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x25FA2D0", Offset = "0x25F96D0", VA = "0x1825FA2D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7AB90", Offset = "0x2F79F90", VA = "0x182F7AB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F7ABD0", Offset = "0x2F79FD0", VA = "0x182F7ABD0")]
	public MFCNJKEINOM(TimeSpan AOEGDFNBHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AAB0", Offset = "0x2F79EB0", VA = "0x182F7AAB0")]
	public void JANOFOGBMBA(Task FGBJPNAPJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A940", Offset = "0x2F79D40", VA = "0x182F7A940")]
	public void ANPBGMHLADF(IOCLDNFCAPD HGOMAGBKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AA60", Offset = "0x2F79E60", VA = "0x182F7AA60")]
	public void IEGBHPHADMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A9D0", Offset = "0x2F79DD0", VA = "0x182F7A9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CEHNAHJGCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B080", Offset = "0x2F6A480", VA = "0x182F6B080")]
		internal bool <Create>b__0(GJMMDEMBFND s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x25F4D20", Offset = "0x25F4120", VA = "0x1825F4D20")]
	public static MPCCILKBHMP IDIKGABNBEI(long IJNKGKEKKHE, long HJCAHMBDEEM, string BPIEFHJHNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x25F4AB0", Offset = "0x25F3EB0", VA = "0x1825F4AB0")]
	public static MPCCILKBHMP IDIKGABNBEI(long IJNKGKEKKHE, long HJCAHMBDEEM, KKANDLGEEGN DDEENGNPJOM, long DBCJFDIMEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x25F4B70", Offset = "0x25F3F70", VA = "0x1825F4B70")]
	public static MPCCILKBHMP IDIKGABNBEI(HJAFOAIDLLN AHIOHOIAHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x25F4870", Offset = "0x25F3C70", VA = "0x1825F4870")]
	public static MPCCILKBHMP IDIKGABNBEI(LLBNMMPGAFE CFMENLBHIHE, JEDNDCJMLKI EPAKNJPBBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x25F4770", Offset = "0x25F3B70", VA = "0x1825F4770")]
	public static MPCCILKBHMP HDKCHBAKMKL(this MPCCILKBHMP GJNIFGAPEDN, LLBNMMPGAFE EEJKNHACFJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x25F45F0", Offset = "0x25F39F0", VA = "0x1825F45F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A52290", Offset = "0x3A51690", VA = "0x183A52290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2602490", Offset = "0x2601890", VA = "0x182602490", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task HONMDABKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2602640", Offset = "0x2601A40", VA = "0x182602640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B1920", Offset = "0x7B0D20", VA = "0x1807B1920", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x26024C0", Offset = "0x26018C0", VA = "0x1826024C0", Slot = "6")]
	public void ECLBBJAAFPK(Task IBCOHPONNBJ, string AGEKNEPBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x26026A0", Offset = "0x2601AA0", VA = "0x1826026A0")]
	[AsyncStateMachine(typeof(OKLODFALKNA))]
	private Task JHNDEDDMHFM(Task ALBJOHMCHFL, string AGEKNEPBOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x26027D0", Offset = "0x2601BD0", VA = "0x1826027D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25ED5D0", Offset = "0x25EC9D0", VA = "0x1825ED5D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x25ED6C0", Offset = "0x25ECAC0", VA = "0x1825ED6C0", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x25ED3D0", Offset = "0x25EC7D0", VA = "0x1825ED3D0", Slot = "5")]
	public void BGEGHMHJBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x25ED590", Offset = "0x25EC990", VA = "0x1825ED590", Slot = "6")]
	public void NJLDLACCEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x25ED640", Offset = "0x25ECA40", VA = "0x1825ED640")]
	private Task HHJLGOIFLPE(PGONHDFGHDL PJEHHDIBMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x25ED590", Offset = "0x25EC990", VA = "0x1825ED590", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0D40", VA = "0x1807B1940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A230", Offset = "0x2B99630", VA = "0x182B9A230")]
		public AFGANNAOFGA(LGIHGHKPCKA FBJGDFFOGDE, string OGFDNCPKECB, T LGCPJJBBDLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2B99C20", Offset = "0x2B99020", VA = "0x182B99C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x25FA890", Offset = "0x25F9C90", VA = "0x1825FA890", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan DBHKPDALIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x25FA7D0", Offset = "0x25F9BD0", VA = "0x1825FA7D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan NEJBEMPNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x25FA610", Offset = "0x25F9A10", VA = "0x1825FA610", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan HOBBIKDCALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x25FA810", Offset = "0x25F9C10", VA = "0x1825FA810", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool JENELKEOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x25FA850", Offset = "0x25F9C50", VA = "0x1825FA850", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool ECILJPNGNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x25FA650", Offset = "0x25F9A50", VA = "0x1825FA650", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IPNHFIADJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x25FA690", Offset = "0x25F9A90", VA = "0x1825FA690", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CDDCIGEMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x25FA6D0", Offset = "0x25F9AD0", VA = "0x1825FA6D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan AODPIECGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x25FA4C0", Offset = "0x25F98C0", VA = "0x1825FA4C0", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x25FA8D0", Offset = "0x25F9CD0", VA = "0x1825FA8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GIFIIABGNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3E02290", Offset = "0x3E01690", VA = "0x183E02290")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action CEPOPFLPLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2F803D0", Offset = "0x2F7F7D0", VA = "0x182F803D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2F80290", Offset = "0x2F7F690", VA = "0x182F80290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event JMJJONCEBOH AOIJHLGGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2F80720", Offset = "0x2F7FB20", VA = "0x182F80720", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FCE0", Offset = "0x2F7F0E0", VA = "0x182F7FCE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event JMJJONCEBOH FKFJALIHBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2F801F0", Offset = "0x2F7F5F0", VA = "0x182F801F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2F80870", Offset = "0x2F7FC70", VA = "0x182F80870", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event JMJJONCEBOH PMALMBPMHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FE50", Offset = "0x2F7F250", VA = "0x182F7FE50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2F80330", Offset = "0x2F7F730", VA = "0x182F80330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<PGPGCAPEPDK, bool> OHPCMLOENIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FD80", Offset = "0x2F7F180", VA = "0x182F7FD80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FEF0", Offset = "0x2F7F2F0", VA = "0x182F7FEF0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "19")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2F804A0", Offset = "0x2F7F8A0", VA = "0x182F804A0", Slot = "14")]
	public void MCAPCGKBMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2F7FCB0", Offset = "0x2F7F0B0", VA = "0x182F7FCB0", Slot = "15")]
	public void ADKBHCPGMLN(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2F7FE20", Offset = "0x2F7F220", VA = "0x182F7FE20", Slot = "16")]
	public void DCKBMFJEFEN(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F80470", Offset = "0x2F7F870", VA = "0x182F80470", Slot = "17")]
	public void KDLAHNFHJIB(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2F807C0", Offset = "0x2F7FBC0", VA = "0x182F807C0", Slot = "18")]
	public void OJDGGFLCMOI(PGPGCAPEPDK OBDLCOMHMDI, bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2F7FF90", Offset = "0x2F7F390", VA = "0x182F7FF90")]
	private void GODLCEDBDHK(JMJJONCEBOH KPNCMNIOOEH, CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E07650", Offset = "0x3E06A50", VA = "0x183E07650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E00460", Offset = "0x3DFF860", VA = "0x183E00460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HPDCCIBNEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3E03A80", Offset = "0x3E02E80", VA = "0x183E03A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFFC40", Offset = "0x3DFF040", VA = "0x183DFFC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3E001E0", Offset = "0x3DFF5E0", VA = "0x183E001E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OMMJEMBMFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AC20", Offset = "0x3E0A020", VA = "0x183E0AC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F77AC0", Offset = "0x2F76EC0", VA = "0x182F77AC0", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2F776B0", Offset = "0x2F76AB0", VA = "0x182F776B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2F777D0", Offset = "0x2F76BD0", VA = "0x182F777D0", Slot = "6")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2F77960", Offset = "0x2F76D60", VA = "0x182F77960", Slot = "5")]
	public void JENABHCBBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2F776C0", Offset = "0x2F76AC0", VA = "0x182F776C0", Slot = "4")]
	[AsyncStateMachine(typeof(LIKHLPKLCEK))]
	public Task FONCHCAGBGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2F77240", Offset = "0x2F76640", VA = "0x182F77240")]
	private void ACGIMOOKGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2F77F40", Offset = "0x2F77340", VA = "0x182F77F40")]
	[AsyncStateMachine(typeof(EJHBOHIHMCN))]
	private Task MCEGABOLFPN(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2F77DF0", Offset = "0x2F771F0", VA = "0x182F77DF0")]
	[AsyncStateMachine(typeof(EFCMNEDJCNA))]
	private Task<bool> LCAJEKLJGCJ(int EGNHJGKABLC, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2F77C90", Offset = "0x2F77090", VA = "0x182F77C90")]
	private void KBHFCONBODH(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2F77B40", Offset = "0x2F76F40", VA = "0x182F77B40")]
	private void KAOADDEJCDH(int EGNHJGKABLC, bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2F78070", Offset = "0x2F77470", VA = "0x182F78070")]
	private void OPOOJMBLKNC(int EGNHJGKABLC, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2F775A0", Offset = "0x2F769A0", VA = "0x182F775A0")]
	private void ANDDJDEFHEH(CancellationToken OIMNLGJCBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A46A90", Offset = "0x3A45E90", VA = "0x183A46A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DPIEJOMLOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3A458C0", Offset = "0x3A44CC0", VA = "0x183A458C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4C990", Offset = "0x3A4BD90", VA = "0x183A4C990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4C730", Offset = "0x3A4BB30", VA = "0x183A4C730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x260B300", Offset = "0x260A700", VA = "0x18260B300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	internal Task EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x260B580", Offset = "0x260A980", VA = "0x18260B580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x260B310", Offset = "0x260A710", VA = "0x18260B310", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x260B010", Offset = "0x260A410", VA = "0x18260B010", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x260B070", Offset = "0x260A470", VA = "0x18260B070", Slot = "5")]
	public bool FNILGHKCLDA(CIPILANIGKL AAAFJHCOPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x260ADD0", Offset = "0x260A1D0", VA = "0x18260ADD0")]
	private void DCLLMBAALNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x260A610", Offset = "0x2609A10", VA = "0x18260A610")]
	private void CBECEBDMOGJ(JILMCFPJPGB GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x260A4F0", Offset = "0x26098F0", VA = "0x18260A4F0")]
	[AsyncStateMachine(typeof(EGMBNMIJGOC))]
	private Task BFEEPNAOACJ(JILMCFPJPGB GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x260B590", Offset = "0x260A990", VA = "0x18260B590")]
	private Func<CancellationToken, List<Task>> NPJOINELPMO(JILMCFPJPGB GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x260A8B0", Offset = "0x2609CB0", VA = "0x18260A8B0")]
	private List<Task> CFLLLPBGAIE(JILMCFPJPGB GOKPFGBACOI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x260B0D0", Offset = "0x260A4D0", VA = "0x18260B0D0")]
	[AsyncStateMachine(typeof(JDNACDCEELB))]
	private Task GGBMEOMIHIN(CIPILANIGKL HCNJFIFOHOK, JILMCFPJPGB HIDEHJGLNHO, CancellationToken MIFCLBEAOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x260B670", Offset = "0x260AA70", VA = "0x18260B670")]
	[AsyncStateMachine(typeof(JBNJFMNNIDF))]
	private Task OBEEGLDMDON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x260B200", Offset = "0x260A600", VA = "0x18260B200")]
	private void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x260B770", Offset = "0x260AB70", VA = "0x18260B770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7A3D0", Offset = "0x2F797D0", VA = "0x182F7A3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F74D20", Offset = "0x2F74120", VA = "0x182F74D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ABPJHNFPMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
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
		private KIBJFOMIMGE <multiProgressTracker>5__2;

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
		private FBEIKNPDGBI <preOperationProgressTracker>5__8;

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
		[Cpp2IlInjected.Address(RVA = "0x2F73070", Offset = "0x2F72470", VA = "0x182F73070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6E3F0", Offset = "0x2F6D7F0", VA = "0x182F6E3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6F8F0", Offset = "0x2F6ECF0", VA = "0x182F6F8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6A5C0", Offset = "0x2F699C0", VA = "0x182F6A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2F6A960", Offset = "0x2F69D60", VA = "0x182F6A960", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6BB60", Offset = "0x2F6AF60", VA = "0x182F6BB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HBBBFOAEJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2F715A0", Offset = "0x2F709A0", VA = "0x182F715A0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2F714A0", Offset = "0x2F708A0", VA = "0x182F714A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6C280", Offset = "0x2F6B680", VA = "0x182F6C280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		public KIBJFOMIMGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private HKNIJBILNIP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2F71B10", Offset = "0x2F70F10", VA = "0x182F71B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6CD80", Offset = "0x2F6C180", VA = "0x182F6CD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6FD10", Offset = "0x2F6F110", VA = "0x182F6FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7B4B0", Offset = "0x2F7A8B0", VA = "0x182F7B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F81530", Offset = "0x2F80930", VA = "0x182F81530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7CA40", Offset = "0x2F7BE40", VA = "0x182F7CA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IODIDLMMDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2F74B50", Offset = "0x2F73F50", VA = "0x182F74B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DIAPNNELMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C1E0", Offset = "0x2F6B5E0", VA = "0x182F6C1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LMOLCHIDFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F79490", Offset = "0x2F78890", VA = "0x182F79490")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KNGFIJDLGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F75BF0", Offset = "0x2F74FF0", VA = "0x182F75BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FC320", Offset = "0x9FB720", VA = "0x1809FC320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9FB870", Offset = "0x9FAC70", VA = "0x1809FB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x25F3310", Offset = "0x25F2710", VA = "0x1825F3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x25F3660", Offset = "0x25F2A60", VA = "0x1825F3660", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x25F1D60", Offset = "0x25F1160", VA = "0x1825F1D60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x25F24F0", Offset = "0x25F18F0", VA = "0x1825F24F0", Slot = "5")]
	[AsyncStateMachine(typeof(MAPHANNBMHF))]
	public Task GEDACMLBIIF(OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x25F3FF0", Offset = "0x25F33F0", VA = "0x1825F3FF0")]
	[AsyncStateMachine(typeof(JJEFEMHBOOO))]
	private Task NJHNGCLNLEA(OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x25F3360", Offset = "0x25F2760", VA = "0x1825F3360")]
	private static void JANKOFDMGBF(OFCNMCIOFIM HPMGEPNNFHO, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x25F13C0", Offset = "0x25F07C0", VA = "0x1825F13C0")]
	private static void CGMGAIFIGLA(IJOBCDJIKMP JODAFCLPAAB, Exception MEIDENAJCEE, [Optional] List<int> DCINMOBAJKD, int IAFBNIHHEFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x25F2230", Offset = "0x25F1630", VA = "0x1825F2230")]
	[AsyncStateMachine(typeof(IMDHLMNKCNE))]
	private Task GBADMCLDAGE(HKNIJBILNIP MJOCLEMBKBO, OFCNMCIOFIM HPMGEPNNFHO, BGLENBCKMJG GHPOPIHLAKD, MNALPKGIDEG JBIOPHKABBJ, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x25F1E40", Offset = "0x25F1240", VA = "0x1825F1E40")]
	private void FFOHJMMKBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x25F1280", Offset = "0x25F0680", VA = "0x1825F1280")]
	[AsyncStateMachine(typeof(FAPLMMEHFOC))]
	private Task CFKKGLDIBEB(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25F2EC0", Offset = "0x25F22C0", VA = "0x1825F2EC0")]
	private void HNBDLLCGFEC(OFCNMCIOFIM HPMGEPNNFHO, CancellationToken OMMIOIOKBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x25F2640", Offset = "0x25F1A40", VA = "0x1825F2640")]
	private void GILFLCCJJPA(OFCNMCIOFIM HPMGEPNNFHO, MNALPKGIDEG JBIOPHKABBJ, OperationCanceledException MCDKCFEBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x25F2A60", Offset = "0x25F1E60", VA = "0x1825F2A60")]
	private void HDNEMKJHPGM(OFCNMCIOFIM HPMGEPNNFHO, MNALPKGIDEG JBIOPHKABBJ, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x25F06C0", Offset = "0x25EFAC0", VA = "0x1825F06C0")]
	private void AGHFGKIJJGK(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x25F42C0", Offset = "0x25F36C0", VA = "0x1825F42C0")]
	private static CGNOGDJLAKB PELPLHIHBJD(OFCNMCIOFIM HPMGEPNNFHO)
	{
		return default(CGNOGDJLAKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x25F3210", Offset = "0x25F2610", VA = "0x1825F3210")]
	[AsyncStateMachine(typeof(GJIBCIMDICK))]
	private Task IEHPKOOIIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x25F1C00", Offset = "0x25F1000", VA = "0x1825F1C00")]
	[AsyncStateMachine(typeof(AKPDNPNJPJF))]
	private Task<Matchmaking.DCPOIDHHLDB> DLKIFMCPOCE(OFCNMCIOFIM HPMGEPNNFHO, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x25F2910", Offset = "0x25F1D10", VA = "0x1825F2910")]
	private static MDCHGPLJCHG GJJOLIDMLFG(OFCNMCIOFIM HPMGEPNNFHO, Matchmaking.DCPOIDHHLDB PFNIIHBDEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x25F1010", Offset = "0x25F0410", VA = "0x1825F1010")]
	[AsyncStateMachine(typeof(DEKLGBABGKG))]
	private Task BKEJPKNEFHJ(OFCNMCIOFIM HPMGEPNNFHO, Matchmaking.DCPOIDHHLDB PFNIIHBDEGI, MNALPKGIDEG JBIOPHKABBJ, HKNIJBILNIP MJOCLEMBKBO, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x25F20D0", Offset = "0x25F14D0", VA = "0x1825F20D0")]
	[AsyncStateMachine(typeof(DJDEAAEHLMO))]
	private Task FOPKDCBIKCB(OFCNMCIOFIM HPMGEPNNFHO, CancellationTokenSource FJKCOOPILJF, Task COFGCDFOCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x25F0960", Offset = "0x25EFD60", VA = "0x1825F0960")]
	[AsyncStateMachine(typeof(HMNDOPPICIF))]
	private Task AIAFNGFMDMP(MPCCILKBHMP OIIJKAFJJPD, KIBJFOMIMGE EHILNCIAEPD, OFCNMCIOFIM IBCMJGEPEAF, MNALPKGIDEG JDKPIJMGDDM, HKNIJBILNIP MJOCLEMBKBO, CancellationToken KOGPGEEPLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x25F3A80", Offset = "0x25F2E80", VA = "0x1825F3A80")]
	private MNALPKGIDEG KLOCEDNMENM(MNALPKGIDEG JDKPIJMGDDM, ref CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x25F1F90", Offset = "0x25F1390", VA = "0x1825F1F90")]
	[AsyncStateMachine(typeof(DOACNFMHIMO))]
	private Task FLHLODBFKHM(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x25F3EB0", Offset = "0x25F32B0", VA = "0x1825F3EB0")]
	[AsyncStateMachine(typeof(GKCNFKFPPCC))]
	private Task NCFDPCPEENP(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x25F0ED0", Offset = "0x25F02D0", VA = "0x1825F0ED0")]
	[AsyncStateMachine(typeof(MLPHBHADJGB))]
	private Task AMHDOPFHBLO(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x25F23B0", Offset = "0x25F17B0", VA = "0x1825F23B0")]
	[AsyncStateMachine(typeof(PNIJPPGDOJC))]
	private Task GDIKFGKMOJA(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x25F3520", Offset = "0x25F2920", VA = "0x1825F3520")]
	[AsyncStateMachine(typeof(NIIFPFNJILG))]
	private Task JDDECIJGNOM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x25F4150", Offset = "0x25F3550", VA = "0x1825F4150")]
	private static void OGDCIMBPLHM(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x25F4320", Offset = "0x25F3720", VA = "0x1825F4320")]
	private void PJOEJBDIILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x25F3CD0", Offset = "0x25F30D0", VA = "0x1825F3CD0")]
	private void LDNPBOJFABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x25F3E20", Offset = "0x25F3220", VA = "0x1825F3E20")]
	private void MOHFOIDDBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x25F1DB0", Offset = "0x25F11B0", VA = "0x1825F1DB0")]
	private void ENEGOBPAIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x25F2D30", Offset = "0x25F2130", VA = "0x1825F2D30")]
	private static void HEAMCAFGMBE(OFCNMCIOFIM HPMGEPNNFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x25F3D60", Offset = "0x25F3160", VA = "0x1825F3D60")]
	private static void LJHDNLOMOCF(OFCNMCIOFIM HPMGEPNNFHO, CancellationToken DMMMMFNCIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x25F0AF0", Offset = "0x25EFEF0", VA = "0x1825F0AF0")]
	private static void AJOAMPGHHDN(OFCNMCIOFIM HPMGEPNNFHO, Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x25F0C90", Offset = "0x25F0090", VA = "0x1825F0C90")]
	private void ALENJDLMLML(OFCNMCIOFIM HPMGEPNNFHO, Task COFGCDFOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x25F1190", Offset = "0x25F0590", VA = "0x1825F1190")]
	private static void BMBLFHKAJNC(Func<string> HKNFNIPGHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x25F45E0", Offset = "0x25F39E0", VA = "0x1825F45E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FILMPJBKIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A47AC0", Offset = "0x3A46EC0", VA = "0x183A47AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IMNFAGCPALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C6D0", Offset = "0x3A4BAD0", VA = "0x183A4C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LEABKHCCEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A4ED10", Offset = "0x3A4E110", VA = "0x183A4ED10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EECKMIIOMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A46170", Offset = "0x3A45570", VA = "0x183A46170")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IKPKHKLKDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C670", Offset = "0x3A4BA70", VA = "0x183A4C670")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "10")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2603C00", Offset = "0x2603000", VA = "0x182603C00", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2603960", Offset = "0x2602D60", VA = "0x182603960", Slot = "4")]
	public EADEEJBAKAP AGMLDLCGDGN(Guid HPGJMKCMOPJ)
	{
		return default(EADEEJBAKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2603C10", Offset = "0x2603010", VA = "0x182603C10", Slot = "5")]
	public bool FJEBMLODAAK(Guid HPGJMKCMOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2604270", Offset = "0x2603670", VA = "0x182604270", Slot = "8")]
	public bool GJMJKHONEFD(Guid HPGJMKCMOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2603EA0", Offset = "0x26032A0", VA = "0x182603EA0", Slot = "6")]
	public bool GIJLBFKAPGH(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x26044D0", Offset = "0x26038D0", VA = "0x1826044D0", Slot = "7")]
	public bool LFCNHMDCDFA(Guid HPGJMKCMOPJ, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2604730", Offset = "0x2603B30", VA = "0x182604730", Slot = "9")]
	public Task<(IOCLDNFCAPD, Task)> LMCDFNKJLIM(Guid HPGJMKCMOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x26047A0", Offset = "0x2603BA0", VA = "0x1826047A0")]
	private void MHEGELEOABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2604A40", Offset = "0x2603E40", VA = "0x182604A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFDF60", Offset = "0x3DFD360", VA = "0x183DFDF60")]
		public BKLCLKPHHKP(OFCNMCIOFIM GPJFLBNAMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDE10", Offset = "0x3DFD210", VA = "0x183DFDE10")]
		public void GJMJKHONEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDDE0", Offset = "0x3DFD1E0", VA = "0x183DFDDE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NGCNBMGHADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E092B0", Offset = "0x3E086B0", VA = "0x183E092B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E03F00", Offset = "0x3E03300", VA = "0x183E03F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HMAEBFMFMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E03370", Offset = "0x3E02770", VA = "0x183E03370")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E04290", Offset = "0x3E03690", VA = "0x183E04290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xF4AD90", Offset = "0xF4A190", VA = "0x180F4AD90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IBBKCEDOKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E03AF0", Offset = "0x3E02EF0", VA = "0x183E03AF0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E03B90", Offset = "0x3E02F90", VA = "0x183E03B90")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E03BD0", Offset = "0x3E02FD0", VA = "0x183E03BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GCFHBDLDGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E01380", Offset = "0x3E00780", VA = "0x183E01380")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E06730", Offset = "0x3E05B30", VA = "0x183E06730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F82680", Offset = "0x2F81A80", VA = "0x182F82680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool PKJPJEMKMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x13E3880", Offset = "0x13E2C80", VA = "0x1813E3880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2F824E0", Offset = "0x2F818E0", VA = "0x182F824E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F82A10", Offset = "0x2F81E10", VA = "0x182F82A10", Slot = "4")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F82320", Offset = "0x2F81720", VA = "0x182F82320", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F828F0", Offset = "0x2F81CF0", VA = "0x182F828F0")]
	[AsyncStateMachine(typeof(IMIKPFEJMCM))]
	private Task KABNKODKHJO(PGONHDFGHDL JKPBGFEADJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F81D70", Offset = "0x2F81170", VA = "0x182F81D70")]
	private void ALBJFDMDBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F70", Offset = "0x2F82370", VA = "0x182F82F70")]
	private void PFNODJBFFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F826D0", Offset = "0x2F81AD0", VA = "0x182F826D0")]
	private void INMIEEELICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F82DB0", Offset = "0x2F821B0", VA = "0x182F82DB0")]
	private bool KNGMJIDHIBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F82CC0", Offset = "0x2F820C0", VA = "0x182F82CC0")]
	[AsyncStateMachine(typeof(JBDKOKJMAJB))]
	private void KCNCNOOIPGA(int ENNAKHLEBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F81F90", Offset = "0x2F81390", VA = "0x182F81F90")]
	private void ALDPGBCIOJI(out IDisposable IPFNGDFHBIO, out IDisposable MBGKDGKJHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F824F0", Offset = "0x2F818F0", VA = "0x182F824F0")]
	private bool ICMLKEKONBP(OFCNMCIOFIM GPJFLBNAMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F824A0", Offset = "0x2F818A0", VA = "0x182F824A0")]
	private void EILOHACBIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E30", Offset = "0x2F82230", VA = "0x182F82E30")]
	[AsyncStateMachine(typeof(KMICIFMLFBE))]
	private Task NJHNGCLNLEA(OFCNMCIOFIM GPJFLBNAMIO, BGLENBCKMJG GHPOPIHLAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F83190", Offset = "0x2F82590", VA = "0x182F83190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F70A10", Offset = "0x2F6FE10", VA = "0x182F70A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F70C60", Offset = "0x2F70060", VA = "0x182F70C60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CMHPNAECDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2F6BAA0", Offset = "0x2F6AEA0", VA = "0x182F6BAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FIDHODEJJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2F6ECE0", Offset = "0x2F6E0E0", VA = "0x182F6ECE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HNHDOIJIGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F72090", Offset = "0x2F71490", VA = "0x182F72090")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F703C0", Offset = "0x2F6F7C0", VA = "0x182F703C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DCJHKBECBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F6BB00", Offset = "0x2F6AF00", VA = "0x182F6BB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7BFE0", Offset = "0x2F7B3E0", VA = "0x182F7BFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F756E0", Offset = "0x2F74AE0", VA = "0x182F756E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F75B30", Offset = "0x2F74F30", VA = "0x182F75B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ADLEDMIBKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F6A540", Offset = "0x2F69940", VA = "0x182F6A540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6F370", Offset = "0x2F6E770", VA = "0x182F6F370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MHCPLDANJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2F7AE60", Offset = "0x2F7A260", VA = "0x182F7AE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KNJPOOCNELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2F75CF0", Offset = "0x2F750F0", VA = "0x182F75CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25EBFE0", Offset = "0x25EB3E0", VA = "0x1825EBFE0", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x25EAF50", Offset = "0x25EA350", VA = "0x1825EAF50", Slot = "6")]
	[AsyncStateMachine(typeof(HADAGEKJLDD))]
	public Task<NNHCJPLIFIC> BONIMKLBONK(CancellationToken KOAHEEBKLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x25EB0E0", Offset = "0x25EA4E0", VA = "0x1825EB0E0", Slot = "4")]
	public void DGEBDLINKDJ(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x25EB790", Offset = "0x25EAB90", VA = "0x1825EB790", Slot = "5")]
	public void HBKGBGCJJPJ(IKENBFLEHKK KKIACKKMLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x25EB660", Offset = "0x25EAA60", VA = "0x1825EB660")]
	[AsyncStateMachine(typeof(GLJEFGBHKNN))]
	private Task GOGFFCFACOJ(IKENBFLEHKK FLDKBCEOGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x25EAE30", Offset = "0x25EA230", VA = "0x1825EAE30")]
	[AsyncStateMachine(typeof(NCNDBGDBNMM))]
	private Task BHEAELABJNP(IKENBFLEHKK GEFEMGIDEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x25EB500", Offset = "0x25EA900", VA = "0x1825EB500")]
	[AsyncStateMachine(typeof(KJNPBJNDLGN))]
	private Task<IMKGIBOCLAG> DMOLPODNCBF(IKENBFLEHKK FLDKBCEOGMK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x25EC0C0", Offset = "0x25EB4C0", VA = "0x1825EC0C0")]
	private MNALPKGIDEG KICKDHMPOKP(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x25EC3D0", Offset = "0x25EB7D0", VA = "0x1825EC3D0")]
	[AsyncStateMachine(typeof(FOAELEAACFH))]
	private Task PFEMFFPGOCL(IMKGIBOCLAG FFDDMJBLHEA, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x25EC140", Offset = "0x25EB540", VA = "0x1825EC140")]
	private IMKGIBOCLAG PBKNALBMBEN(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x129C840", Offset = "0x129BC40", VA = "0x18129C840")]
	private T MFOPJHBNONP<T>(T LPJDDLMPNCG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x25EBB80", Offset = "0x25EAF80", VA = "0x1825EBB80")]
	private IMKGIBOCLAG JFANICPMFPA(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public AEIFCOEGAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x25EB090", Offset = "0x25EA490", VA = "0x1825EB090")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AHPBGENJCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3A41D10", Offset = "0x3A41110", VA = "0x183A41D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LOHCKCIOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3A50110", Offset = "0x3A4F510", VA = "0x183A50110")]
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
	[Cpp2IlInjected.Address(RVA = "0x2608390", Offset = "0x2607790", VA = "0x182608390", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x26073C0", Offset = "0x26067C0", VA = "0x1826073C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2607460", Offset = "0x2606860", VA = "0x182607460", Slot = "4")]
	public EADEEJBAKAP GAKKKEFAIMA(IKENBFLEHKK CPDANDAPHHP)
	{
		return default(EADEEJBAKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2608100", Offset = "0x2607500", VA = "0x182608100", Slot = "5")]
	public void JJIFHCDLOOA(Guid HPGJMKCMOPJ, Task FGBJPNAPJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2606A40", Offset = "0x2605E40", VA = "0x182606A40")]
	private void AKHBOHPKEPG(byte AHOKOPLCFGL, int EJDEEFFNGFA, object HGAIHPAIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2607960", Offset = "0x2606D60", VA = "0x182607960")]
	private void JGLMMCGNLFG(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x26070D0", Offset = "0x26064D0", VA = "0x1826070D0")]
	private void DDEAALOKJGF(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2608500", Offset = "0x2607900", VA = "0x182608500")]
	private void MKKJGMNLMNL(AKAINFJKHFE MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2606E20", Offset = "0x2606220", VA = "0x182606E20")]
	private IOCLDNFCAPD CALKMFNEFJE(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2608AD0", Offset = "0x2607ED0", VA = "0x182608AD0")]
	private void OPDDCNCMEAF(IKENBFLEHKK GEFEMGIDEKG, IOCLDNFCAPD HGOMAGBKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x26087C0", Offset = "0x2607BC0", VA = "0x1826087C0")]
	private bool ONAOKFGGEGM(IKENBFLEHKK GEFEMGIDEKG, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2606750", Offset = "0x2605B50", VA = "0x182606750")]
	private bool AJGMBPDOLAE(IKENBFLEHKK HMCHMJLEKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2606B10", Offset = "0x2605F10", VA = "0x182606B10")]
	private bool BIIBPICDOPA(byte AHOKOPLCFGL, ExitGames.Client.Photon.Hashtable MNNEHHHEKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FEINBBGJCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3A476A0", Offset = "0x3A46AA0", VA = "0x183A476A0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3A47710", Offset = "0x3A46B10", VA = "0x183A47710")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A461D0", Offset = "0x3A455D0", VA = "0x183A461D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3A46770", Offset = "0x3A45B70", VA = "0x183A46770", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ECJLADIDGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3A46100", Offset = "0x3A45500", VA = "0x183A46100")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DBDHKNOINFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3A44310", Offset = "0x3A43710", VA = "0x183A44310")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3A44380", Offset = "0x3A43780", VA = "0x183A44380")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3A443F0", Offset = "0x3A437F0", VA = "0x183A443F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A439E0", Offset = "0x3A42DE0", VA = "0x183A439E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3A44100", Offset = "0x3A43500", VA = "0x183A44100", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x25FD700", Offset = "0x25FCB00", VA = "0x1825FD700", Slot = "5")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1F0", Offset = "0x25FC5F0", VA = "0x1825FD1F0", Slot = "4")]
	[AsyncStateMachine(typeof(EFLJOHKKPNH))]
	private Task<IOCLDNFCAPD> CDIOKPFHEPN(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x25FD480", Offset = "0x25FC880", VA = "0x1825FD480")]
	private bool FDOJLMNALFG(NNHCJPLIFIC OBDLCOMHMDI, out IOCLDNFCAPD JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x25FD330", Offset = "0x25FC730", VA = "0x1825FD330")]
	[AsyncStateMachine(typeof(CMFIDAMLNGH))]
	private Task<IOCLDNFCAPD> CINOLBOIBDO(IKENBFLEHKK FLDKBCEOGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A48F80", Offset = "0x3A48380", VA = "0x183A48F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3A49160", Offset = "0x3A48560", VA = "0x183A49160", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MICIGEHOLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3A504C0", Offset = "0x3A4F8C0", VA = "0x183A504C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A52940", Offset = "0x3A51D40", VA = "0x183A52940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3A52E70", Offset = "0x3A52270", VA = "0x183A52E70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EGGIFLNNNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1032E50", Offset = "0x1032250", VA = "0x181032E50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2602B70", Offset = "0x2601F70", VA = "0x182602B70", Slot = "5")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2602850", Offset = "0x2601C50", VA = "0x182602850", Slot = "4")]
	[AsyncStateMachine(typeof(GBAILGELCDC))]
	public Task<MPCCILKBHMP> BDBFDACKJCJ(HKNIJBILNIP BDBJGJIIKDE, OFCNMCIOFIM HPMGEPNNFHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2602F50", Offset = "0x2602350", VA = "0x182602F50")]
	[AsyncStateMachine(typeof(OPPEDFHJDMF))]
	private Task<LLBNMMPGAFE> NEFNBCLIOIN(OFCNMCIOFIM HPMGEPNNFHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26029D0", Offset = "0x2601DD0", VA = "0x1826029D0")]
	private MPCCILKBHMP CELMFECNOOM(OFCNMCIOFIM HPMGEPNNFHO, LLBNMMPGAFE DDACBKFDEHC, long HBNJLALONNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2602BE0", Offset = "0x2601FE0", VA = "0x182602BE0")]
	private (KKANDLGEEGN, long) MKMOKNMPCHJ(OFCNMCIOFIM HPMGEPNNFHO, LLBNMMPGAFE DDACBKFDEHC, long HBNJLALONNE)
	{
		return default((KKANDLGEEGN, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BJIDMAJLCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3A42CA0", Offset = "0x3A420A0", VA = "0x183A42CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A54070", Offset = "0x3A53470", VA = "0x183A54070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3A544F0", Offset = "0x3A538F0", VA = "0x183A544F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A51190", Offset = "0x3A50590", VA = "0x183A51190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3A51780", Offset = "0x3A50B80", VA = "0x183A51780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LHFGDDAFCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x3A4ED70", Offset = "0x3A4E170", VA = "0x183A4ED70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4D950", Offset = "0x3A4CD50", VA = "0x183A4D950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E400", Offset = "0x3A4D800", VA = "0x183A4E400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25FB5D0", Offset = "0x25FA9D0", VA = "0x1825FB5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x25FB920", Offset = "0x25FAD20", VA = "0x1825FB920", Slot = "8")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x25FB450", Offset = "0x25FA850", VA = "0x1825FB450", Slot = "4")]
	[AsyncStateMachine(typeof(PJOMBJCADKO))]
	public Task<IKENBFLEHKK> BJJMPGAFBMA(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x25FB9B0", Offset = "0x25FADB0", VA = "0x1825FB9B0", Slot = "5")]
	[AsyncStateMachine(typeof(OCBHNNGJGJD))]
	public Task<IKENBFLEHKK> KIBJAHAGNIP(CancellationToken OIMNLGJCBEC, MNALPKGIDEG MPFKFHENEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x25FB690", Offset = "0x25FAA90", VA = "0x1825FB690", Slot = "6")]
	public HAACNKIHLLI IMNGPHLHNNL(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x25FB080", Offset = "0x25FA480", VA = "0x1825FB080", Slot = "7")]
	public HAACNKIHLLI ADIADHJFFPI(IMKGIBOCLAG NMPGILJJLOB, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x25FBB00", Offset = "0x25FAF00", VA = "0x1825FBB00")]
	[AsyncStateMachine(typeof(KKJEPICEDMD))]
	private Task<IKENBFLEHKK> MODOOKBOMJK(IKENBFLEHKK FLDKBCEOGMK, MNALPKGIDEG MPFKFHENEIP, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x25FB680", Offset = "0x25FAA80", VA = "0x1825FB680")]
	private static byte[] GOHJHHBGCPL(IKENBFLEHKK BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x25FB300", Offset = "0x25FA700", VA = "0x1825FB300")]
	private static string BEINDELHHIE(byte[] HACNEHKIBDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x25FD7C0", Offset = "0x25FCBC0", VA = "0x1825FD7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private static IOCLDNFCAPD NLOBKFPFEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x25FD7B0", Offset = "0x25FCBB0", VA = "0x1825FD7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x25FD810", Offset = "0x25FCC10", VA = "0x1825FD810", Slot = "7")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x25FD970", Offset = "0x25FCD70", VA = "0x1825FD970", Slot = "4")]
	public IOCLDNFCAPD MNPHBDHPKCD(IEIHKFAAJEG IEDAIENJNOO, NNHCJPLIFIC NABLKJBKJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x25FDD10", Offset = "0x25FD110", VA = "0x1825FDD10", Slot = "5")]
	public IOCLDNFCAPD PPPHHENGFMM(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x25FDB10", Offset = "0x25FCF10", VA = "0x1825FDB10", Slot = "6")]
	public IOCLDNFCAPD PNIGFKCFLHO(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x25FDB00", Offset = "0x25FCF00", VA = "0x1825FDB00")]
	private static IOCLDNFCAPD ONKNDCGMKPH(IEAAFONNOPI JALEHBMHNHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public FONNHABINBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class PJPLALHKNOE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2F80910", Offset = "0x2F7FD10", VA = "0x182F80910")]
	public PJPLALHKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x9C9AD0", Offset = "0x9C8ED0", VA = "0x1809C9AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E00CA0", Offset = "0x3E000A0", VA = "0x183E00CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3E01330", Offset = "0x3E00730", VA = "0x183E01330", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E02390", Offset = "0x3E01790", VA = "0x183E02390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E08280", Offset = "0x3E07680", VA = "0x183E08280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E07FB0", Offset = "0x3E073B0", VA = "0x183E07FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFD140", Offset = "0x3DFC540", VA = "0x183DFD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E008E0", Offset = "0x3DFFCE0", VA = "0x183E008E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F79E50", Offset = "0x2F79250", VA = "0x182F79E50", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x1279230", Offset = "0x1278630", VA = "0x181279230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2F79850", Offset = "0x2F78C50", VA = "0x182F79850", Slot = "4")]
	[AsyncStateMachine(typeof(GAPAGLGBMEI))]
	public Task<IOCLDNFCAPD> GCLDKLBGALL(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A240", Offset = "0x2F79640", VA = "0x182F7A240", Slot = "5")]
	[AsyncStateMachine(typeof(HFKBMDOCPAB))]
	public Task PCAGCJDIMFJ([Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x1279230", Offset = "0x1278630", VA = "0x181279230")]
	public void OMMBCEKDILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2F79510", Offset = "0x2F78910", VA = "0x182F79510")]
	private CFDDEJKMDNO DBLPAFLHJBP(LFLMMDJMDFC DMNFJMFHKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A110", Offset = "0x2F79510", VA = "0x182F7A110")]
	[AsyncStateMachine(typeof(MJKKEBOFDIA))]
	private Task NNPGMAEAGOB(JILMCFPJPGB PJEHHDIBMKL, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2F79C00", Offset = "0x2F79000", VA = "0x182F79C00")]
	[AsyncStateMachine(typeof(MCNMKEOJCIA))]
	private Task IEFIGCNHMOP([Optional] CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x2F79D20", Offset = "0x2F79120", VA = "0x182F79D20")]
	[AsyncStateMachine(typeof(BDDMKEJJAOO))]
	private Task IHCOIBCJBCL(TimeSpan OMNNAMIEKJH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2F79990", Offset = "0x2F78D90", VA = "0x182F79990")]
	private Task HEFJCAFLCDO(GDONNAAGMMP DDKEDGNNMCH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2F79720", Offset = "0x2F78B20", VA = "0x182F79720")]
	[AsyncStateMachine(typeof(FEPNOKIHKAJ))]
	private Task DGBNEFIGINK(GDONNAAGMMP DDKEDGNNMCH, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A000", Offset = "0x2F79400", VA = "0x182F7A000")]
	private bool MPMKDGFCFDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6ED40", Offset = "0x2F6E140", VA = "0x182F6ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x25F5E90", Offset = "0x25F5290", VA = "0x1825F5E90", Slot = "6")]
	public void KADCCJJCHBP(BMMONKKCCCK FDPHPHDPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x25F5E40", Offset = "0x25F5240", VA = "0x1825F5E40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x25F5D20", Offset = "0x25F5120", VA = "0x1825F5D20", Slot = "5")]
	[AsyncStateMachine(typeof(FMLMCGFIGDC))]
	public Task BEFGPHPFGEM(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x25F6200", Offset = "0x25F5600", VA = "0x1825F6200", Slot = "4")]
	public IOCLDNFCAPD MPMKDGFCFDK(IEIHKFAAJEG IEDAIENJNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x25F60B0", Offset = "0x25F54B0", VA = "0x1825F60B0")]
	private GCIDEOLCFFE MNCLBPLDPMD(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BLCBGLHMPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class GIACHLCFFDE
{
	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x25FEEC0", Offset = "0x25FE2C0", VA = "0x1825FEEC0")]
	public static void ONCKFELPHOE(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x25FE870", Offset = "0x25FDC70", VA = "0x1825FE870")]
	internal static void GNNMAKOOBIG(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x25FEDE0", Offset = "0x25FE1E0", VA = "0x1825FEDE0")]
	internal static void LKBDGFNIBHJ(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x25FE990", Offset = "0x25FDD90", VA = "0x1825FE990")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FAJKDEKPEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E040", Offset = "0x2F6D440", VA = "0x182F6E040")]
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
	[Cpp2IlInjected.Address(RVA = "0x25F6B70", Offset = "0x25F5F70", VA = "0x1825F6B70")]
	public ExitGames.Client.Photon.Hashtable HLHCEBOKDMG(IKENBFLEHKK BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x25F6BF0", Offset = "0x25F5FF0", VA = "0x1825F6BF0", Slot = "5")]
	protected override void HPPGFLNFHCF(IKENBFLEHKK BALNMHDNCIN, IDictionary<object, object> HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x25F6D30", Offset = "0x25F6130", VA = "0x1825F6D30", Slot = "6")]
	public override IKENBFLEHKK JDGCKOHAIDJ(IDictionary<object, object> HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x25F69E0", Offset = "0x25F5DE0", VA = "0x1825F69E0")]
	private static void BMBLFHKAJNC(string KDHKIHNDDDL, IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x25F7290", Offset = "0x25F6690", VA = "0x1825F7290")]
	public CIHFPNKIHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x25F6F30", Offset = "0x25F6330", VA = "0x1825F6F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7DA00", Offset = "0x2F7CE00", VA = "0x182F7DA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D9E0", Offset = "0x2F7CDE0", VA = "0x182F7D9E0")]
	public static bool BIGJFOBBLEF(this IOCLDNFCAPD HGOMAGBKKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2F7DEE0", Offset = "0x2F7D2E0", VA = "0x182F7DEE0")]
	public static IOCLDNFCAPD ONKNDCGMKPH(IEAAFONNOPI LBAAOGIJHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2F7DED0", Offset = "0x2F7D2D0", VA = "0x182F7DED0")]
	public static IOCLDNFCAPD MAOPIIEOOOB(params IOCLDNFCAPD[] JIIGKNCLFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2F7DA60", Offset = "0x2F7CE60", VA = "0x182F7DA60")]
	public static IOCLDNFCAPD FIFBHHOJBLH(IEnumerable<IOCLDNFCAPD> JIIGKNCLFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2F7DC60", Offset = "0x2F7D060", VA = "0x182F7DC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FPKOJOFAHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F8C0", Offset = "0x2F6ECC0", VA = "0x182F6F8C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25EDB10", Offset = "0x25ECF10", VA = "0x1825EDB10", Slot = "4")]
	public void IPLFNKPIDAI(HAKJPICFBOL FADOFACCPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x25EDAB0", Offset = "0x25ECEB0", VA = "0x1825EDAB0", Slot = "5")]
	public void INJFOFCFDMD(HAKJPICFBOL FADOFACCPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x25ED840", Offset = "0x25ECC40", VA = "0x1825ED840", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x25ED890", Offset = "0x25ECC90", VA = "0x1825ED890")]
	protected IOCLDNFCAPD HACCHEJGKIH(IEIHKFAAJEG EBBDANNDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x25EDB70", Offset = "0x25ECF70", VA = "0x1825EDB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IHBJBFNIEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E03C10", Offset = "0x3E03010", VA = "0x183E03C10")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F78B10", Offset = "0x2F77F10", VA = "0x182F78B10")]
	[UnityEngine.Scripting.Preserve]
	public OKMJGEFKMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F7ED80", Offset = "0x2F7E180", VA = "0x182F7ED80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DHMDEAAMMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE3F0", Offset = "0x3DFD7F0", VA = "0x183DFE3F0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F78B10", Offset = "0x2F77F10", VA = "0x182F78B10")]
	[UnityEngine.Scripting.Preserve]
	public LINIPLOEPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F78980", Offset = "0x2F77D80", VA = "0x182F78980", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DOKPCPGHJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE5D0", Offset = "0x3DFD9D0", VA = "0x183DFE5D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F790E0", Offset = "0x2F784E0", VA = "0x182F790E0")]
	public static global::JIHOHILIMPL<string> GCGMABAPNPH([Optional] string LAGLMNHLDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F791B0", Offset = "0x2F785B0", VA = "0x182F791B0")]
	private static void HEHLPKKDMGN(string OGFDNCPKECB, JMMAOJMBHJK MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F792C0", Offset = "0x2F786C0", VA = "0x182F792C0")]
	private static void HHOBKCKFDIM(string OGFDNCPKECB, JMMAOJMBHJK MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F78F70", Offset = "0x2F78370", VA = "0x182F78F70")]
	public static void FEAJOPBNNAD(global::JIHOHILIMPL<string> MJOCLEMBKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F793D0", Offset = "0x2F787D0", VA = "0x182F793D0")]
	public static string MHEDLLKADND(IKENBFLEHKK KDGOJEKMNED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class NFCKHLMJKKJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CA30", Offset = "0x2F7BE30", VA = "0x182F7CA30")]
	public static void GAFMAPOMCKO(this OGCACIFJDCP KEHCECCODAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CA20", Offset = "0x2F7BE20", VA = "0x182F7CA20")]
	public static void EAEAJDPEMIH(this OGCACIFJDCP KEHCECCODAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C910", Offset = "0x2F7BD10", VA = "0x182F7C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7F4E0", Offset = "0x2F7E8E0", VA = "0x182F7F4E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int FPMMDLOENAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F490", Offset = "0x2F7E890", VA = "0x182F7F490", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int LDLADOGOABN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F300", Offset = "0x2F7E700", VA = "0x182F7F300", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JFEGKDOMDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int BPCMIFONGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E0", Offset = "0x73A8E0", VA = "0x18073B4E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ADDOPBLDHDH.KECGCDEGNJJ PEBGDIJBNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FMOMLHBOKEB FPKKAHAKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F260", Offset = "0x2F7E660", VA = "0x182F7F260", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F120", Offset = "0x2F7E520", VA = "0x182F7F120", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> FJAHDMFOJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<IEIHKFAAJEG> DOBECGKOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action HFFEDFMGLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F5E0", Offset = "0x2F7E9E0", VA = "0x182F7F5E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F6A0", Offset = "0x2F7EAA0", VA = "0x182F7F6A0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xB0D730", Offset = "0xB0CB30", VA = "0x180B0D730")]
	public OOLEJPECMNK(JKMAHCLGMKC FKGEPOENBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F530", Offset = "0x2F7E930", VA = "0x182F7F530", Slot = "8")]
	public bool NLJGDCEBNPM(byte AHOKOPLCFGL, ExitGames.Client.Photon.Hashtable KJIMGDEFNCD, DMCFMAHOAGP AOPNFOFINKK, SendOptions KDMOIOKDJPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F1C0", Offset = "0x2F7E5C0", VA = "0x182F7F1C0", Slot = "29")]
	public IEIHKFAAJEG BJPHLDMLOMH(int KHALHEOHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F350", Offset = "0x2F7E750", VA = "0x182F7F350", Slot = "16")]
	public IEIHKFAAJEG JNNBJKNJKNC(int DKMBEMBDAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "19")]
	public void HLPNAPDGANN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "20")]
	public void MNEBIGNEBOO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "21")]
	public void PFPLGNEPFCH(object MIFCLBEAOPM, bool KJDPMJJFOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F430", Offset = "0x2F7E830", VA = "0x182F7F430", Slot = "22")]
	public IDisposable MEMLALILPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "23")]
	private bool PCMPJHJINEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "24")]
	public void DBOPOIDMIKI(StringBuilder IAFGLANFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F680", Offset = "0x2F7EA80", VA = "0x182F7F680", Slot = "25")]
	public bool PEPCBCLGBKG(bool DOAGGOEHHAC, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public void AHCLNKJKFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xCDCD20", Offset = "0xCDC120", VA = "0x180CDCD20", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0xD7F230", Offset = "0xD7E630", VA = "0x180D7F230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
	public AKAINFJKHFE(IDictionary<object, object> MNNEHHHEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x25EDF20", Offset = "0x25ED320", VA = "0x1825EDF20")]
	public bool ONCFLGLIFID(out IKENBFLEHKK BALNMHDNCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x25EDD50", Offset = "0x25ED150", VA = "0x1825EDD50")]
	public Guid GDEPNKJGIBI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x25EDBF0", Offset = "0x25ECFF0", VA = "0x1825EDBF0")]
	public IOCLDNFCAPD GAMAKIIFDJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x25EDE30", Offset = "0x25ED230", VA = "0x1825EDE30")]
	public static ExitGames.Client.Photon.Hashtable IDIKGABNBEI(IKENBFLEHKK BALNMHDNCIN, IOCLDNFCAPD HGOMAGBKKCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NCMEKEDHLLO
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F7BD90", Offset = "0x2F7B190", VA = "0x182F7BD90")]
	public static string OMMGKLGAGFB(this OFCNMCIOFIM GPGKFDLHFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F7BD10", Offset = "0x2F7B110", VA = "0x182F7BD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0AA80", Offset = "0x3E09E80", VA = "0x183E0AA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7D060", Offset = "0x2F7C460", VA = "0x182F7D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal Task EAPKFJAPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D1C0", Offset = "0x2F7C5C0", VA = "0x182F7D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D240", Offset = "0x2F7C640", VA = "0x182F7D240")]
	public NMLPMEFFLFG(CancellationToken OIMNLGJCBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D090", Offset = "0x2F7C490", VA = "0x182F7D090")]
	[AsyncStateMachine(typeof(OMDNEPPBKPL))]
	public Task GMNLBEMKBDM(Func<CancellationToken, List<Task>> OONBHACEHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D010", Offset = "0x2F7C410", VA = "0x182F7D010", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CBD7E0", Offset = "0x2CBCBE0", VA = "0x182CBD7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x220A3C0", Offset = "0x22097C0", VA = "0x18220A3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly global::HELOOCDOGGH<TGetDataArg, TData> GOBIMGKDLNH;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
	internal FDGFCFNJPHA(global::HELOOCDOGGH<TGetDataArg, TData> AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x242ABE0", Offset = "0x2429FE0", VA = "0x18242ABE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DBDC50", Offset = "0x1DBD050", VA = "0x181DBDC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long BNCPDJEKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x25F5580", Offset = "0x25F4980", VA = "0x1825F5580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long OGJIHNKAJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x25F55E0", Offset = "0x25F49E0", VA = "0x1825F55E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DNNPENLDDEC NICNPGDMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x895940", Offset = "0x894D40", VA = "0x180895940")]
		get
		{
			return default(DNNPENLDDEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x25F5190", Offset = "0x25F4590", VA = "0x1825F5190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long BEJFLKELMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x25F5430", Offset = "0x25F4830", VA = "0x1825F5430")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x25F5CE0", Offset = "0x25F50E0", VA = "0x1825F5CE0")]
	[UnityEngine.Scripting.Preserve]
	public BKMGDOEHDIH([LIKONNNLKGK(null)] ENIMFIBLMKI PNAOLCDCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x25F5280", Offset = "0x25F4680", VA = "0x1825F5280")]
	private void CBMKJHKGAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x25F5930", Offset = "0x25F4D30", VA = "0x1825F5930")]
	public void NEJHJPNFPEO(long LCIEPBGBKGO, long HBNJLALONNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x25F5490", Offset = "0x25F4890", VA = "0x1825F5490")]
	public void GKIHOAKDBKH(string NKECNDHGDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x25F5640", Offset = "0x25F4A40", VA = "0x1825F5640")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A47340", Offset = "0x3A46740", VA = "0x183A47340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3A47650", Offset = "0x3A46A50", VA = "0x183A47650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PJPNNCHPBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3A545C0", Offset = "0x3A539C0", VA = "0x183A545C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4F870", Offset = "0x3A4EC70", VA = "0x183A4F870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3A50060", Offset = "0x3A4F460", VA = "0x183A50060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A41700", Offset = "0x3A40B00", VA = "0x183A41700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DFFCILAPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3A446B0", Offset = "0x3A43AB0", VA = "0x183A446B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LMFJPGDADEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3A500B0", Offset = "0x3A4F4B0", VA = "0x183A500B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GNFDOMDNEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3A49760", Offset = "0x3A48B60", VA = "0x183A49760")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LAEJFLHJJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3A4ECA0", Offset = "0x3A4E0A0", VA = "0x183A4ECA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CDCGLPNBMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3A436D0", Offset = "0x3A42AD0", VA = "0x183A436D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DHBGGMLFPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x3A44820", Offset = "0x3A43C20", VA = "0x183A44820")]
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
	[Cpp2IlInjected.Address(RVA = "0x26008D0", Offset = "0x25FFCD0", VA = "0x1826008D0")]
	public HAACNKIHLLI(IMKGIBOCLAG FFDDMJBLHEA, HFKOONKIHDN ALCCAOIDJBH, IPIMGJIMFLO KEHCECCODAM, PIMENJMGHGL INAGLGEMCNH, HKNIJBILNIP BDBJGJIIKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x25FF0C0", Offset = "0x25FE4C0", VA = "0x1825FF0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x25FF0C0", Offset = "0x25FE4C0", VA = "0x1825FF0C0")]
	public void AEGLNIOCDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x25FFF70", Offset = "0x25FF370", VA = "0x1825FFF70")]
	public void KBIKPHJEFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2600220", Offset = "0x25FF620", VA = "0x182600220")]
	public void LBANNJFLBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x25FFC90", Offset = "0x25FF090", VA = "0x1825FFC90")]
	[AsyncStateMachine(typeof(EJJCCIFLKEA))]
	internal Task<IKENBFLEHKK> GCGPANHFNEH(HKNIJBILNIP BDBJGJIIKDE, IKENBFLEHKK KDGOJEKMNED, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x25FB680", Offset = "0x25FAA80", VA = "0x1825FB680")]
	private static byte[] HCLFOMFIMFH<T>(T BALNMHDNCIN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x29F2270", Offset = "0x29F1670", VA = "0x1829F2270")]
	private static T JIMGMHKLNJM<T>(MessageParser<T> JDKNEBHHMFD, byte[] BALNMHDNCIN, T PBEMIFAFADA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2600590", Offset = "0x25FF990", VA = "0x182600590")]
	[AsyncStateMachine(typeof(LLAIGJHIPFF))]
	private Task<AELILFMFADF> OLGPGBKMEII(IKENBFLEHKK KDGOJEKMNED, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x29F2730", Offset = "0x29F1B30", VA = "0x1829F2730")]
	[AsyncStateMachine(typeof(NBAFCMAOHGG))]
	internal Task<T> KJHFDOEPKJI<T>(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task<T>> GCAEGAAGADF, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x26000D0", Offset = "0x25FF4D0", VA = "0x1826000D0")]
	[AsyncStateMachine(typeof(AAOOBNBFKFE))]
	internal Task KJHFDOEPKJI(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task> GCAEGAAGADF, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x25FF730", Offset = "0x25FEB30", VA = "0x1825FF730")]
	public IKENBFLEHKK DDEBGKMOCOP(IGEDENPPIDH FNLCCIEPNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x25FFE60", Offset = "0x25FF260", VA = "0x1825FFE60")]
	public LBHMAKJMHJK GJAEIBLMFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x25FFF00", Offset = "0x25FF300", VA = "0x1825FFF00")]
	public KMMGIKAOMCG IOEJGDOBECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x26006F0", Offset = "0x25FFAF0", VA = "0x1826006F0")]
	public HGEJIOHJADL PAAJBDJBONJ([Optional] JHJMJFFJEOO? KJHKAEFGNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x25FFED0", Offset = "0x25FF2D0", VA = "0x1825FFED0")]
	public void HBMDJIKNCIA(Func<Guid, bool> DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x25FF960", Offset = "0x25FED60", VA = "0x1825FF960")]
	public void EEEGDDMDNJO(Func<Guid, bool> IFGELHABLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x25FF7C0", Offset = "0x25FEBC0", VA = "0x1825FF7C0")]
	public void DEOOGDLLCOJ(Func<Guid, bool> DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2600380", Offset = "0x25FF780", VA = "0x182600380")]
	public Guid OBNBPGHOPKJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x25FF590", Offset = "0x25FE990", VA = "0x1825FF590")]
	public void CNLOIHFBCDH(Guid PJGICPOEFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x25FFB40", Offset = "0x25FEF40", VA = "0x1825FFB40")]
	public void GBEELOKFNKK(IKENBFLEHKK OBEFFGHPGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x25FF400", Offset = "0x25FE800", VA = "0x1825FF400")]
	public void BMBLFHKAJNC(string ELAKEMJOIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x25FF270", Offset = "0x25FE670", VA = "0x1825FF270")]
	public void BMBLFHKAJNC(Func<string> BAMFEGJMCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x29F2A10", Offset = "0x29F1E10", VA = "0x1829F2A10")]
	private T MFOPJHBNONP<T>(T LPJDDLMPNCG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x25FFE10", Offset = "0x25FF210", VA = "0x1825FFE10")]
	public void GHLJJJJNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x29F2420", Offset = "0x29F1820", VA = "0x1829F2420")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GNJOCJLPKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x3A49A60", Offset = "0x3A48E60", VA = "0x183A49A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A50570", Offset = "0x3A4F970", VA = "0x183A50570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JICCDHFNIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3A4CD40", Offset = "0x3A4C140", VA = "0x183A4CD40")]
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
	[Cpp2IlInjected.Address(RVA = "0x260CEB0", Offset = "0x260C2B0", VA = "0x18260CEB0")]
	public KMCGKMKMHKG(MPCCILKBHMP OIIJKAFJJPD, OFCNMCIOFIM LGHKHDGGALO, Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x260C990", Offset = "0x260BD90", VA = "0x18260C990", Slot = "8")]
	[AsyncStateMachine(typeof(MJOHEOLBHLP))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x260CAE0", Offset = "0x260BEE0", VA = "0x18260CAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6B0B0", Offset = "0x2F6A4B0", VA = "0x182F6B0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x803620", Offset = "0x802A20", VA = "0x180803620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C30", Offset = "0x8C8030", VA = "0x1808C8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x25F6840", Offset = "0x25F5C40", VA = "0x1825F6840")]
	public CFDDEJKMDNO(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, int PJJKBPGMCEJ, LFLMMDJMDFC DADNHALGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x25F6700", Offset = "0x25F5B00", VA = "0x1825F6700", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EOFBFGFFJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3E00820", Offset = "0x3DFFC20", VA = "0x183E00820")]
		internal Task <RunAsync>b__0(HKNIJBILNIP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3E00860", Offset = "0x3DFFC60", VA = "0x183E00860")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFC160", Offset = "0x3DFB560", VA = "0x183DFC160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E04DB0", Offset = "0x3E041B0", VA = "0x183E04DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2F7ED30", Offset = "0x2F7E130", VA = "0x182F7ED30")]
	public OHKIJIKLINE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string ECMKCFBONNE, PGPGCAPEPDK OBDLCOMHMDI, bool OBNBIKJECBP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EA80", Offset = "0x2F7DE80", VA = "0x182F7EA80", Slot = "8")]
	[AsyncStateMachine(typeof(AALNNJCOKIL))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task HINPLOOKACD(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EBD0", Offset = "0x2F7DFD0", VA = "0x182F7EBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFC880", Offset = "0x3DFBC80", VA = "0x183DFC880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly GDONNAAGMMP DDKEDGNNMCH;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2F81190", Offset = "0x2F80590", VA = "0x182F81190")]
	public PMADHNLPEAE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2F810B0", Offset = "0x2F804B0", VA = "0x182F810B0", Slot = "7")]
	protected override string OMBJIKPKBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2F80F70", Offset = "0x2F80370", VA = "0x182F80F70", Slot = "8")]
	[AsyncStateMachine(typeof(ACEJFBKOMHB))]
	protected override Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class IMKGIBOCLAG : NKKFNBJGPNK
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HJKMBLIOJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A5B0", Offset = "0x3A499B0", VA = "0x183A4A5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MFJCMBOBGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3A50340", Offset = "0x3A4F740", VA = "0x183A50340")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3A50400", Offset = "0x3A4F800", VA = "0x183A50400")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A546D0", Offset = "0x3A53AD0", VA = "0x183A546D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A491B0", Offset = "0x3A485B0", VA = "0x183A491B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
	private readonly FBEIKNPDGBI BENGKGKDOBI;

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
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2605250", Offset = "0x2604650", VA = "0x182605250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HADNAKAMMKO FAFEJOEAODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2604C50", Offset = "0x2604050", VA = "0x182604C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x26051B0", Offset = "0x26045B0", VA = "0x1826051B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x26055E0", Offset = "0x26049E0", VA = "0x1826055E0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event FPLCMFJCNOC KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x26053F0", Offset = "0x26047F0", VA = "0x1826053F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2605050", Offset = "0x2604450", VA = "0x182605050", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2605660", Offset = "0x2604A60", VA = "0x182605660")]
	protected IMKGIBOCLAG(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string ECMKCFBONNE, PGPGCAPEPDK OBDLCOMHMDI, bool OBNBIKJECBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x26055A0", Offset = "0x26049A0", VA = "0x1826055A0", Slot = "7")]
	protected virtual string OMBJIKPKBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2605600", Offset = "0x2604A00", VA = "0x182605600")]
	public void PPEPNIOIJPH(FKIHFNCGFDF HCNJFIFOHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2605230", Offset = "0x2604630", VA = "0x182605230")]
	protected void JLFAAOJOHKD(float JOFEJELEMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x26052A0", Offset = "0x26046A0", VA = "0x1826052A0")]
	[AsyncStateMachine(typeof(PMMAALFKCND))]
	public Task KJENKEOBMBM(CancellationToken OIMNLGJCBEC, HKNIJBILNIP BDBJGJIIKDE, [Optional] Func<IMKGIBOCLAG, HKNIJBILNIP, HAACNKIHLLI> JPOHMMAAELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2605410", Offset = "0x2604810", VA = "0x182605410")]
	private void OAMMHNMDGBD(bool MEFHOIBEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2604D20", Offset = "0x2604120", VA = "0x182604D20")]
	private void DICNCFHMLKN(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task DKLOOKIEBFP(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2605070", Offset = "0x2604470", VA = "0x182605070")]
	[AsyncStateMachine(typeof(GCEOKDFAGEL))]
	private Task HBLDBNGIIMG(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2604CA0", Offset = "0x26040A0", VA = "0x182604CA0")]
	public IKENBFLEHKK DDEBGKMOCOP(IGEDENPPIDH FNLCCIEPNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2604F70", Offset = "0x2604370", VA = "0x182604F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A458F0", Offset = "0x3A44CF0", VA = "0x183A458F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly MPCCILKBHMP FEKDGKLEEHD;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x25F99D0", Offset = "0x25F8DD0", VA = "0x1825F99D0")]
	public DIOKJCKPLFH(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MPCCILKBHMP FEKDGKLEEHD, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x25F9880", Offset = "0x25F8C80", VA = "0x1825F9880", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A50A20", Offset = "0x3A4FE20", VA = "0x183A50A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private readonly string KCDOKAJDOKO;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x25FE090", Offset = "0x25FD490", VA = "0x1825FE090")]
	public GCIDEOLCFFE(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, MNALPKGIDEG EMPFCPMLDHK, string KCDOKAJDOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x25FDF60", Offset = "0x25FD360", VA = "0x1825FDF60", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public LOJNJEAABNH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			private TaskAwaiter<DEIOFMFEJDI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A1F20", Offset = "0x6A1320")]
			private TaskAwaiter<IKENBFLEHKK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E2B0", Offset = "0x3E0D6B0", VA = "0x183E0E2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E600", Offset = "0x3E0DA00", VA = "0x183E0E600", Slot = "5")]
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
		public FCIBLCNJCKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LOJNJEAABNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3A50180", Offset = "0x3A4F580", VA = "0x183A50180")]
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
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public ECIAONNBIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private LOJNJEAABNH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private CGNOGDJLAKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private KMMGIKAOMCG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x3A44AC0", Offset = "0x3A43EC0", VA = "0x183A44AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x25FAFD0", Offset = "0x25FA3D0", VA = "0x1825FAFD0")]
	public ECIAONNBIJO(Guid HPGJMKCMOPJ, BMMONKKCCCK FDPHPHDPLEL, int OMKBGDEDOFD, HOCIJINOOAM JKFBHFINEFL, MNALPKGIDEG EMPFCPMLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x25FAD80", Offset = "0x25FA180", VA = "0x1825FAD80", Slot = "9")]
	[AsyncStateMachine(typeof(DLBDPINPNMI))]
	protected override Task HINPLOOKACD(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x25FAEE0", Offset = "0x25FA2E0", VA = "0x1825FAEE0")]
	private void MKOMGIABHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x25FABE0", Offset = "0x25F9FE0", VA = "0x1825FABE0")]
	private void FJIHDLFLJCC(HKNIJBILNIP BDBJGJIIKDE, CGNOGDJLAKB CBNFPKLEHDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal abstract class PPKCBLMJCHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly IMKGIBOCLAG GLLMOCALFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public readonly HAACNKIHLLI CKBODLOIEGI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2F81CF0", Offset = "0x2F810F0", VA = "0x182F81CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2F81C90", Offset = "0x2F81090", VA = "0x182F81C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2F81D10", Offset = "0x2F81110", VA = "0x182F81D10")]
	protected PPKCBLMJCHH(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2F81C50", Offset = "0x2F81050", VA = "0x182F81C50")]
	protected void BMBLFHKAJNC(string ELAKEMJOIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2F81C70", Offset = "0x2F81070", VA = "0x182F81C70")]
	public void BMBLFHKAJNC(Func<string> BAMFEGJMCOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct OBLBGKHHEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Dictionary<Guid, List<HEABMPIIHCO>> MBFJFFAEIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public Dictionary<Guid, List<HEABMPIIHCO>> PAMOKOBOEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public Dictionary<Guid, List<HEABMPIIHCO>> JANADPGGMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public List<Guid> MDCPBDPNEOF;

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D3F0", Offset = "0x2F7C7F0", VA = "0x182F7D3F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	public static GONFIANDPKM IDIKGABNBEI()
	{
		return default(GONFIANDPKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LMOIDIDNJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JCEIGACAJFP(JILMCFPJPGB HIDEHJGLNHO, object KHKLJBKIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KBDGHNPMLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct ACCNBLIHPFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly LLBNMMPGAFE HOLCMHHFICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly GJMMDEMBFND EBIPNHCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly string MLKOMNKNPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly KKANDLGEEGN DDEENGNPJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly KKANDLGEEGN OGGAFKMEPLK;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x25EADB0", Offset = "0x25EA1B0", VA = "0x1825EADB0")]
	public ACCNBLIHPFM(LLBNMMPGAFE HOLCMHHFICL, GJMMDEMBFND EBIPNHCAEMF, string MLKOMNKNPAD, KKANDLGEEGN DDEENGNPJOM, KKANDLGEEGN OGGAFKMEPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct AMHPCDPCNJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly Guid PJGICPOEFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private bool MEFHOIBEAII;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x25EE7B0", Offset = "0x25EDBB0", VA = "0x1825EE7B0")]
	public static AMHPCDPCNJH OBNBPGHOPKJ(HAACNKIHLLI NLFLBJNDBCF)
	{
		return default(AMHPCDPCNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0xE185C0", Offset = "0xE179C0", VA = "0x180E185C0")]
	public void IGMPIIGMHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x25EE7A0", Offset = "0x25EDBA0", VA = "0x1825EE7A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x25EE7E0", Offset = "0x25EDBE0", VA = "0x1825EE7E0")]
	private AMHPCDPCNJH(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x25EE3B0", Offset = "0x25ED7B0", VA = "0x1825EE3B0")]
	private void CNLOIHFBCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x25EE6F0", Offset = "0x25EDAF0", VA = "0x1825EE6F0")]
	private Func<Guid, bool> DIKHMFMHCPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class KMMGIKAOMCG : PPKCBLMJCHH, NKKFNBJGPNK
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public delegate Task<DNNPENLDDEC> MJOHPKKAKLL(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM CMBBGOBDCNG, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct OHBAOFKPAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private AMHPCDPCNJH <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E09CF0", Offset = "0x3E090F0", VA = "0x183E09CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private HKNIJBILNIP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A43360", Offset = "0x3A42760", VA = "0x183A43360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A43680", Offset = "0x3A42A80", VA = "0x183A43680", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private HKNIJBILNIP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A45EA0", Offset = "0x3A452A0", VA = "0x183A45EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private ACCNBLIHPFM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			private TaskAwaiter<ACCNBLIHPFM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x3E0CD10", Offset = "0x3E0C110", VA = "0x183E0CD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D360", Offset = "0x3E0C760", VA = "0x183E0D360", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public AsyncTaskMethodBuilder<JILMCFPJPGB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			private JILMCFPJPGB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			private TaskAwaiter<JILMCFPJPGB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D3B0", Offset = "0x3E0C7B0", VA = "0x183E0D3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D920", Offset = "0x3E0CD20", VA = "0x183E0D920", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public FPCEKENKKGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private TaskAwaiter<DNNPENLDDEC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private OCMBAOLDEMM <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x3E0BAF0", Offset = "0x3E0AEF0", VA = "0x183E0BAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public FBEIKNPDGBI preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public FBEIKNPDGBI downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public ACCNBLIHPFM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public FBEIKNPDGBI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public JILMCFPJPGB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GODEACJPJMC.HBIDCNLCNEB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FPCEKENKKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A48CC0", Offset = "0x3A480C0", VA = "0x183A48CC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<ACCNBLIHPFM> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A48E00", Offset = "0x3A48200", VA = "0x183A48E00")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<JILMCFPJPGB> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A48F40", Offset = "0x3A48340", VA = "0x183A48F40")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A48B90", Offset = "0x3A47F90", VA = "0x183A48B90")]
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
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public MPCCILKBHMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private FPCEKENKKGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<JILMCFPJPGB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A47F70", Offset = "0x3A47370", VA = "0x183A47F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A42D00", Offset = "0x3A42100", VA = "0x183A42D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private HKNIJBILNIP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A49AD0", Offset = "0x3A48ED0", VA = "0x183A49AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private HKNIJBILNIP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B7D0", Offset = "0x3A4ABD0", VA = "0x183A4B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C270", Offset = "0x3A4B670", VA = "0x183A4C270", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private HKNIJBILNIP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A5E0", Offset = "0x3A499E0", VA = "0x183A4A5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B190", Offset = "0x3A4A590", VA = "0x183A4B190", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public DNNPENLDDEC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E07C20", Offset = "0x3E07020", VA = "0x183E07C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E07E20", Offset = "0x3E07220", VA = "0x183E07E20", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public LPNIPMAMBFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			private TaskAwaiter<DNNPENLDDEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D970", Offset = "0x3E0CD70", VA = "0x183E0D970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x3E0DED0", Offset = "0x3E0D2D0", VA = "0x183E0DED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public MJOHPKKAKLL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public DNNPENLDDEC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LPNIPMAMBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E07E70", Offset = "0x3E07270", VA = "0x183E07E70")]
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
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public MJOHPKKAKLL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E08DA0", Offset = "0x3E081A0", VA = "0x183E08DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E09260", Offset = "0x3E08660", VA = "0x183E09260", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FBEIKNPDGBI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private DNNPENLDDEC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private IEnumerator<DNNPENLDDEC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E05700", Offset = "0x3E04B00", VA = "0x183E05700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A44150", Offset = "0x3A43550", VA = "0x183A44150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public KMMGIKAOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B620", Offset = "0x3E0AA20", VA = "0x183E0B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public LLBNMMPGAFE roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GNFODCJJDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A497D0", Offset = "0x3A48BD0", VA = "0x183A497D0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly FGFCKLFBJIP LNAHHAOGING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly FGFCKLFBJIP GMACLJMJODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly BAAPIFCMJOI KFIKNPBGMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly DCBCAALEHJL FIPOFINIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly KIBJFOMIMGE OPEAGNFNDJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x260EFE0", Offset = "0x260E3E0", VA = "0x18260EFE0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private BMMONKKCCCK OABOAPFBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x260E7A0", Offset = "0x260DBA0", VA = "0x18260E7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FPLCMFJCNOC KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x260EB30", Offset = "0x260DF30", VA = "0x18260EB30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x260DC50", Offset = "0x260D050", VA = "0x18260DC50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x260F020", Offset = "0x260E420", VA = "0x18260F020")]
	public KMMGIKAOMCG(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x260E0B0", Offset = "0x260D4B0", VA = "0x18260E0B0")]
	[AsyncStateMachine(typeof(OHBAOFKPAGP))]
	public Task JMFFNBNKOHH(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x260E200", Offset = "0x260D600", VA = "0x18260E200")]
	[AsyncStateMachine(typeof(BPLBJCGDNCF))]
	private Task<IKENBFLEHKK> KFHJPMKFNHC(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x260D9C0", Offset = "0x260CDC0", VA = "0x18260D9C0")]
	[AsyncStateMachine(typeof(ECGGPFDMIAI))]
	private Task ECMMPEBABED(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x260D630", Offset = "0x260CA30", VA = "0x18260D630")]
	[AsyncStateMachine(typeof(FPAJMJELDGH))]
	private Task BNAPCNCGJDL(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OOMDENBMMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x260DB20", Offset = "0x260CF20", VA = "0x18260DB20")]
	[AsyncStateMachine(typeof(BNEIOBILIOB))]
	private Task FMLECFJOPPM(HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x260E4E0", Offset = "0x260D8E0", VA = "0x18260E4E0")]
	[AsyncStateMachine(typeof(HFPACJIPLMI))]
	private Task LBMDBDPAEGL(JILMCFPJPGB HIDEHJGLNHO, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x260E9B0", Offset = "0x260DDB0", VA = "0x18260E9B0")]
	[AsyncStateMachine(typeof(IKEAEEICLOI))]
	private Task<DNNPENLDDEC> NKKJHMANOFK(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x260E7D0", Offset = "0x260DBD0", VA = "0x18260E7D0")]
	[AsyncStateMachine(typeof(IBDHMDMEPPD))]
	private Task<DNNPENLDDEC> NIGLPHFNNIG(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x260DCA0", Offset = "0x260D0A0", VA = "0x18260DCA0")]
	[AsyncStateMachine(typeof(LMCBFMJGLGL))]
	private Task<DNNPENLDDEC> HIBIEPNPIOD(DNNPENLDDEC MFHLKCFDMNF, JILMCFPJPGB IFDJIENGHHN, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool OMJOAEEENOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x260D780", Offset = "0x260CB80", VA = "0x18260D780")]
	private bool BPCDGGHDNKL(JILMCFPJPGB INEOJIKCMGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x260ECC0", Offset = "0x260E0C0", VA = "0x18260ECC0")]
	[AsyncStateMachine(typeof(MLKJFJKOBCD))]
	protected Task<DNNPENLDDEC> OHIKFIPCHCA(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, MJOHPKKAKLL ABOCNCGCKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x260D480", Offset = "0x260C880", VA = "0x18260D480")]
	[AsyncStateMachine(typeof(KDDIDGPDKKA))]
	private Task BJBNDGAJLLH(JILMCFPJPGB HIDEHJGLNHO, FBEIKNPDGBI EHILNCIAEPD, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x260D120", Offset = "0x260C520", VA = "0x18260D120")]
	private void ALJFBNIBKHO(DNNPENLDDEC ALOFFKDKDOF, FBEIKNPDGBI EHILNCIAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x260E970", Offset = "0x260DD70", VA = "0x18260E970")]
	private void NKJLNHIPMDI(DNNPENLDDEC BDHAHDBKCEG, out DNNPENLDDEC CNMJNMDOHBL, out DNNPENLDDEC FNGCHLOBFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x260D2C0", Offset = "0x260C6C0", VA = "0x18260D2C0")]
	private Task<ACCNBLIHPFM> BCDDBMPBINC(MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x260D5F0", Offset = "0x260C9F0", VA = "0x18260D5F0")]
	private Task<JILMCFPJPGB> BMDDFCDAJPK(ACCNBLIHPFM HIDEHJGLNHO, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x260E380", Offset = "0x260D780", VA = "0x18260E380")]
	[AsyncStateMachine(typeof(DAMBHCCKFJJ))]
	private Task LBIILCMOLLO(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool KJLOEOIECKF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x260DF90", Offset = "0x260D390", VA = "0x18260DF90")]
	[AsyncStateMachine(typeof(PFDMBOHFGIN))]
	private Task JMAPPNGPKBI(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x260E640", Offset = "0x260DA40", VA = "0x18260E640")]
	private Task MBEIEALJLGH(JILMCFPJPGB HIDEHJGLNHO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x260DE30", Offset = "0x260D230", VA = "0x18260DE30")]
	private Task IHPAPIAOIED(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x260D870", Offset = "0x260CC70", VA = "0x18260D870")]
	private Task CLNKIDJAHHI(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x260EB50", Offset = "0x260DF50", VA = "0x18260EB50")]
	private Task OEICHBKJPAM(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x260D5E0", Offset = "0x260C9E0", VA = "0x18260D5E0")]
	private static Task BJFCBKPEGKJ(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x260D170", Offset = "0x260C570", VA = "0x18260D170")]
	private Task BBGHOAKCKIE(JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x260F000", Offset = "0x260E400", VA = "0x18260F000")]
	private Task PHPGHACADNP(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x260DC70", Offset = "0x260D070", VA = "0x18260DC70")]
	private void HCCIHDKNNCK(MPCCILKBHMP FLDKBCEOGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x260EE70", Offset = "0x260E270", VA = "0x18260EE70")]
	private static void PABJOKAOABA(LLBNMMPGAFE HOLCMHHFICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct COIGGBEPDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x25F74B0", Offset = "0x25F68B0", VA = "0x1825F74B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x25F7770", Offset = "0x25F6B70", VA = "0x1825F7770")]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x25F7500", Offset = "0x25F6900", VA = "0x1825F7500")]
	private void KJENKEOBMBM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct MGOMLDCIGHJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AD40", Offset = "0x2F7A140", VA = "0x182F7AD40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private HKNIJBILNIP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E09870", Offset = "0x3E08C70", VA = "0x183E09870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CD30", Offset = "0x2F7C130", VA = "0x182F7CD30")]
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
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private DNNPENLDDEC <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private BMMONKKCCCK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private DEEFNALDPBL <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private BADFNEBCNNH <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F727F0", Offset = "0x2F71BF0", VA = "0x182F727F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x25F4DB0", Offset = "0x25F41B0", VA = "0x1825F4DB0")]
	[AsyncStateMachine(typeof(IHCCLFFBBFE))]
	public static Task KJENKEOBMBM(HAACNKIHLLI NLFLBJNDBCF, JILMCFPJPGB HIDEHJGLNHO, OCMBAOLDEMM HLIKHECNKJI, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x25F4F20", Offset = "0x25F4320", VA = "0x1825F4F20")]
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
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E850", Offset = "0x3A4DC50", VA = "0x183A4E850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2608D30", Offset = "0x2608130", VA = "0x182608D30")]
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
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE450", Offset = "0x3DFD850", VA = "0x183DFE450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public HKNIJBILNIP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public KOLBJIDJMNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			private HKNIJBILNIP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E060", Offset = "0x3E0D460", VA = "0x183E0E060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KOLBJIDJMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x3E07510", Offset = "0x3E06910", VA = "0x183E07510")]
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
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public OHCLCMONFKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AC90", Offset = "0x3E0A090", VA = "0x183E0AC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public KKCPFDJMIOB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MDEPAADOFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3E080F0", Offset = "0x3E074F0", VA = "0x183E080F0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3E081D0", Offset = "0x3E075D0", VA = "0x183E081D0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private bool KJLOEOIECKF;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private static readonly ByteString NHPBIHMCNNE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2F7E700", Offset = "0x2F7DB00", VA = "0x182F7E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private LPDKLMLIPEF GFIPMKDIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2F7E680", Offset = "0x2F7DA80", VA = "0x182F7E680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E750", Offset = "0x2F7DB50", VA = "0x182F7E750")]
	[AsyncStateMachine(typeof(DKOJPBHCIFB))]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool KJLOEOIECKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E8C0", Offset = "0x2F7DCC0", VA = "0x182F7E8C0")]
	[AsyncStateMachine(typeof(ONIKMDKBIAC))]
	private Task KJENKEOBMBM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2F7DF40", Offset = "0x2F7D340", VA = "0x182F7DF40")]
	private void GMDDFEJBDAG([NotNull] ALDNBFOLDOE BPNGJGFCADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E650", Offset = "0x2F7DA50", VA = "0x182F7E650")]
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
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public AsyncTaskMethodBuilder<JILMCFPJPGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public DACCIINPEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public GODEACJPJMC.HBIDCNLCNEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private HKNIJBILNIP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter<(global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<ALDNBFOLDOE>, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<JHBALGJGKMA>, KFANFMGGLGP>, global::LFBADEDAHHF<global::IGMNBOHIBOC<BMJGADAGPOB>, KFANFMGGLGP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D6F0", Offset = "0x2F6CAF0", VA = "0x182F6D6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2F6DFF0", Offset = "0x2F6D3F0", VA = "0x182F6DFF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public HKNIJBILNIP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public DACCIINPEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public GODEACJPJMC.HBIDCNLCNEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter<global::LFBADEDAHHF<FKPJOOJGELL, KFANFMGGLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D180", Offset = "0x2F6C580", VA = "0x182F6D180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D6A0", Offset = "0x2F6CAA0", VA = "0x182F6D6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private global::FDGFCFNJPHA<KKANDLGEEGN, JHBALGJGKMA> LLCANMILKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private global::FDGFCFNJPHA<KKANDLGEEGN, ALDNBFOLDOE> CJCNIMFEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private global::FDGFCFNJPHA<long, BMJGADAGPOB> DJFAOPBHCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private BPFCNNOEDKB CMBIBHNCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private LLBNMMPGAFE HOLCMHHFICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private GJMMDEMBFND EBIPNHCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private string MLKOMNKNPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private KKANDLGEEGN DDEENGNPJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private KKANDLGEEGN OGGAFKMEPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private long FLLBKALBAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x25F7810", Offset = "0x25F6C10", VA = "0x1825F7810")]
	public static Task<JILMCFPJPGB> AKDODPKEJLG(BMMONKKCCCK FDPHPHDPLEL, in ACCNBLIHPFM HIDEHJGLNHO, GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x25F7D40", Offset = "0x25F7140", VA = "0x1825F7D40")]
	[AsyncStateMachine(typeof(ELNMDINNAKE))]
	private Task<JILMCFPJPGB> KJENKEOBMBM(GODEACJPJMC.HBIDCNLCNEB JGKACJDAPME, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x25F7B70", Offset = "0x25F6F70", VA = "0x1825F7B70")]
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
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public GEEKIIOMCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private HKNIJBILNIP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x3A46F50", Offset = "0x3A46350", VA = "0x183A46F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3A472F0", Offset = "0x3A466F0", VA = "0x183A472F0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public GEEKIIOMCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter<ACCNBLIHPFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x3A47840", Offset = "0x3A46C40", VA = "0x183A47840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3A47A70", Offset = "0x3A46E70", VA = "0x183A47A70", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NHOEGIFNOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1032E50", Offset = "0x1032250", VA = "0x181032E50")]
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
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public AsyncTaskMethodBuilder<ACCNBLIHPFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public KKANDLGEEGN superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public DEEFNALDPBL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private NHOEGIFNOBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private LLBNMMPGAFE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GJMMDEMBFND <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private KKANDLGEEGN <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private KKANDLGEEGN <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private HKNIJBILNIP <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<LLBNMMPGAFE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter<PDFKCDIAEML> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<JEDNDCJMLKI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x3A53430", Offset = "0x3A52830", VA = "0x183A53430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3A54020", Offset = "0x3A53420", VA = "0x183A54020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private long LCIEPBGBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private long HBNJLALONNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private long DBCJFDIMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private string BPIEFHJHNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private KKANDLGEEGN ODMPNENECGO;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x25FE140", Offset = "0x25FD540", VA = "0x1825FE140")]
	public static Task<ACCNBLIHPFM> AKDODPKEJLG(BMMONKKCCCK FDPHPHDPLEL, MPCCILKBHMP FLDKBCEOGMK, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x25FE600", Offset = "0x25FDA00", VA = "0x1825FE600")]
	[AsyncStateMachine(typeof(EHCIEGGFEHL))]
	private Task<ACCNBLIHPFM> KJENKEOBMBM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x25FE480", Offset = "0x25FD880", VA = "0x1825FE480")]
	[AsyncStateMachine(typeof(FHEELCJPDDO))]
	private Task<ACCNBLIHPFM> BCDDBMPBINC(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x25FE2E0", Offset = "0x25FD6E0", VA = "0x1825FE2E0")]
	[AsyncStateMachine(typeof(PGDCFJDALPE))]
	private static Task<ACCNBLIHPFM> BCDDBMPBINC(DEEFNALDPBL NOHGMFJPJKL, long LCIEPBGBKGO, long HBNJLALONNE, long DBCJFDIMEGJ, string BPIEFHJHNGI, KKANDLGEEGN ODMPNENECGO, CancellationToken OIMNLGJCBEC, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x25FE760", Offset = "0x25FDB60", VA = "0x1825FE760")]
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
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public DAOHGPNNDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C2C0", Offset = "0x3A4B6C0", VA = "0x183A4C2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private const int CAGAPOCGKEH = 20;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private const float HNCJFKANEJL = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private DEEFNALDPBL NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private float CMPDKCLKDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private float BOKPMNMIANB;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x25F8470", Offset = "0x25F7870", VA = "0x1825F8470")]
	public static Task OPLKIAAAFLD(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x25F8280", Offset = "0x25F7680", VA = "0x1825F8280")]
	[AsyncStateMachine(typeof(IKJCODAOFOG))]
	public Task KJENKEOBMBM(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x25F7ED0", Offset = "0x25F72D0", VA = "0x1825F7ED0")]
	private static void HGJADANGAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x25F80A0", Offset = "0x25F74A0", VA = "0x1825F80A0")]
	private void JKMBKPBBCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x25F83B0", Offset = "0x25F77B0", VA = "0x1825F83B0")]
	private static float MGEDFJIKAAE(DEEFNALDPBL NOHGMFJPJKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x25F8080", Offset = "0x25F7480", VA = "0x1825F8080")]
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
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private IMKGIBOCLAG <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private BMMONKKCCCK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private KJDCOEEGILA.ECFFIIGPEHP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2F6AAD0", Offset = "0x2F69ED0", VA = "0x182F6AAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private JHMJCENAIID.KJOAPEIMACE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2F74890", Offset = "0x2F73C90", VA = "0x182F74890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x25EE250", Offset = "0x25ED650", VA = "0x1825EE250")]
	[AsyncStateMachine(typeof(CBLKKNBHKGP))]
	public static Task KJENKEOBMBM(HAACNKIHLLI NLFLBJNDBCF, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x25EDFE0", Offset = "0x25ED3E0", VA = "0x1825EDFE0")]
	private static Task<IKENBFLEHKK> BKODKJBLBPF(HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x25EE180", Offset = "0x25ED580", VA = "0x1825EE180")]
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
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public HKEGEJBOKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3A41E00", Offset = "0x3A41200", VA = "0x183A41E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PJPMJOADHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3A54540", Offset = "0x3A53940", VA = "0x183A54540")]
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
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public HKEGEJBOKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private KKNDEEAADEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3A52EC0", Offset = "0x3A522C0", VA = "0x183A52EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private bool KPOKLGHFIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private CancellationToken OIMNLGJCBEC;

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x26021E0", Offset = "0x26015E0", VA = "0x1826021E0")]
	public static Task BDDOBENBKOO(BMMONKKCCCK FDPHPHDPLEL, bool KPOKLGHFIJF, HKNIJBILNIP MJOCLEMBKBO, CancellationToken DMMMMFNCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2602380", Offset = "0x2601780", VA = "0x182602380")]
	[AsyncStateMachine(typeof(AKCFHONKPMI))]
	private Task KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2602250", Offset = "0x2601650", VA = "0x182602250")]
	[AsyncStateMachine(typeof(PAHPPMDOLJN))]
	private Task IKOFHLPPMNO(bool LNHAKJNDEPA, string HJEGLBELAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
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
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public LJNBJPAEFKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x3E01DF0", Offset = "0x3E011F0", VA = "0x183E01DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3E02240", Offset = "0x3E01640", VA = "0x183E02240", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HOCKEKGEGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3E03A30", Offset = "0x3E02E30", VA = "0x183E03A30")]
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
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public LJNBJPAEFKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private KKNDEEAADEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x3E05AE0", Offset = "0x3E04EE0", VA = "0x183E05AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x3E06040", Offset = "0x3E05440", VA = "0x183E06040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private FHMMEOFOJJF EGMAMPAFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private HKNIJBILNIP MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private bool ODFFBFCABBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2F78EF0", Offset = "0x2F782F0", VA = "0x182F78EF0")]
	public static Task<Scene> PKOPDPDOPKE(BMMONKKCCCK FDPHPHDPLEL, FHMMEOFOJJF IELOODOAAHH, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2F78B20", Offset = "0x2F77F20", VA = "0x182F78B20")]
	public static Task<Scene> ADMDPNHMEEP(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2F78D90", Offset = "0x2F78190", VA = "0x182F78D90")]
	[AsyncStateMachine(typeof(GHOGBGGNLJC))]
	private Task<Scene> KJENKEOBMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2F78EC0", Offset = "0x2F782C0", VA = "0x182F78EC0")]
	private bool MMBGBCDHJJF(JILMCFPJPGB HIDEHJGLNHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2F78D20", Offset = "0x2F78120", VA = "0x182F78D20")]
	private void JPEGALFJBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2F78BC0", Offset = "0x2F77FC0", VA = "0x182F78BC0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public DCBCAALEHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public DNNPENLDDEC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private HKNIJBILNIP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter<DNNPENLDDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x3A51C50", Offset = "0x3A51050", VA = "0x183A51C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x3A52240", Offset = "0x3A51640", VA = "0x183A52240", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public AsyncTaskMethodBuilder<DNNPENLDDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public DCBCAALEHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public DNNPENLDDEC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x3A467C0", Offset = "0x3A45BC0", VA = "0x183A467C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3A46A40", Offset = "0x3A45E40", VA = "0x183A46A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly BKMGDOEHDIH IOMMEAGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly BAAPIFCMJOI KFIKNPBGMBO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private IMKGIBOCLAG GLLMOCALFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8F94A0", Offset = "0x8F88A0", VA = "0x1808F94A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x25F8AF0", Offset = "0x25F7EF0", VA = "0x1825F8AF0")]
	public DCBCAALEHJL(HAACNKIHLLI NLFLBJNDBCF, BKMGDOEHDIH IOMMEAGMHCE, BAAPIFCMJOI KFIKNPBGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x25F8950", Offset = "0x25F7D50", VA = "0x1825F8950")]
	[AsyncStateMachine(typeof(OIJIPPDLHOC))]
	public Task<DNNPENLDDEC> NFPENGHCHLM(DNNPENLDDEC PHEPHHCKDKI, JILMCFPJPGB IFDJIENGHHN, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC, bool OMJOAEEENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x25F87B0", Offset = "0x25F7BB0", VA = "0x1825F87B0")]
	[AsyncStateMachine(typeof(EGKCGGJLFOI))]
	private Task<DNNPENLDDEC> LILDAKABMBL(HKNIJBILNIP BDBJGJIIKDE, DNNPENLDDEC OJNFGJAPBNC, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x25F8920", Offset = "0x25F7D20", VA = "0x1825F8920")]
	private bool NFGDJNAFFLL(DNNPENLDDEC AOMIBLNHGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x25F8610", Offset = "0x25F7A10", VA = "0x1825F8610")]
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
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private (PersistenceView, BADFNEBCNNH) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D3E0", Offset = "0x3A4C7E0", VA = "0x183A4D3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x260A3A0", Offset = "0x26097A0", VA = "0x18260A3A0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IMKGIBOCLAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public OCMBAOLDEMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private KKCPFDJMIOB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private List<(PersistenceView, BADFNEBCNNH)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private BADFNEBCNNH <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2F720F0", Offset = "0x2F714F0", VA = "0x182F720F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x25F7360", Offset = "0x25F6760", VA = "0x1825F7360")]
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
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public List<GILOJIOAKMI> AJIEBOJPLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public List<BADFNEBCNNH> FDJBEHGCCNN;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
		public ECFFIIGPEHP(List<GILOJIOAKMI> AJIEBOJPLLO, List<BADFNEBCNNH> FDJBEHGCCNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class AIELNFHIDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public IEnumerable<GILOJIOAKMI> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AIELNFHIDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x3A41D80", Offset = "0x3A41180", VA = "0x183A41D80")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x260BA40", Offset = "0x260AE40", VA = "0x18260BA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x260BA90", Offset = "0x260AE90", VA = "0x18260BA90")]
	public static ECFFIIGPEHP KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO)
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x260BAF0", Offset = "0x260AEF0", VA = "0x18260BAF0")]
	private ECFFIIGPEHP KJENKEOBMBM()
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x260BE10", Offset = "0x260B210", VA = "0x18260BE10")]
	private ECFFIIGPEHP KKNEDLPFKOI(ALDNBFOLDOE BPNGJGFCADO, KKCPFDJMIOB KENFHEPCHLB)
	{
		return default(ECFFIIGPEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x260B7F0", Offset = "0x260ABF0", VA = "0x18260B7F0")]
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
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public KJDCOEEGILA.ECFFIIGPEHP instantiations;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PLGLLGJBAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2F80950", Offset = "0x2F7FD50", VA = "0x182F80950")]
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
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MJAMBPPMCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7B420", Offset = "0x2F7A820", VA = "0x182F7B420")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x25F0000", Offset = "0x25EF400", VA = "0x1825F0000")]
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
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E450", Offset = "0x3A4D850", VA = "0x183A4E450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public HIDPJCEALJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x3A50DB0", Offset = "0x3A501B0", VA = "0x183A50DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private ByteString FMCMGOJJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private bool OONOCBOIJAB;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2601EF0", Offset = "0x26012F0", VA = "0x182601EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool EBBFPBACNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2601DE0", Offset = "0x26011E0", VA = "0x182601DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private bool AHHCOCINBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2601E60", Offset = "0x2601260", VA = "0x182601E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x2602070", Offset = "0x2601470", VA = "0x182602070")]
	[AsyncStateMachine(typeof(KMHDMBEOKOK))]
	public static Task KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, bool OONOCBOIJAB, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2601F40", Offset = "0x2601340", VA = "0x182601F40")]
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
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public DNNPENLDDEC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public JILMCFPJPGB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x2F75D50", Offset = "0x2F75150", VA = "0x182F75D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public BMCKBEOPEGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x3E0DF20", Offset = "0x3E0D320", VA = "0x183E0DF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public HKNIJBILNIP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BMCKBEOPEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x2F6A9B0", Offset = "0x2F69DB0", VA = "0x182F6A9B0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private BMCKBEOPEGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2F71080", Offset = "0x2F70480", VA = "0x182F71080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private Dictionary<Guid, List<HEABMPIIHCO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2F78500", Offset = "0x2F77900", VA = "0x182F78500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private HKNIJBILNIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private Dictionary<Guid, List<HEABMPIIHCO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F740", Offset = "0x2F7EB40", VA = "0x182F7F740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public HEABMPIIHCO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public FMPCIFNOFLD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B9B0", Offset = "0x3E0ADB0", VA = "0x183E0B9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FNNOKHIDILJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public List<HEABMPIIHCO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FMPCIFNOFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F070", Offset = "0x2F6E470", VA = "0x182F6F070")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F250", Offset = "0x2F6E650", VA = "0x182F6F250")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(HEABMPIIHCO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F160", Offset = "0x2F6E560", VA = "0x182F6F160")]
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
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public FNNOKHIDILJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public List<HEABMPIIHCO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private FMPCIFNOFLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2F767A0", Offset = "0x2F75BA0", VA = "0x182F767A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public HKNIJBILNIP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BA90", Offset = "0x2F7AE90", VA = "0x182F7BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KKCICHMBGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x2F75B80", Offset = "0x2F74F80", VA = "0x182F75B80")]
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
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x2F716A0", Offset = "0x2F70AA0", VA = "0x182F716A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IKHNOEEBBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F73000", Offset = "0x2F72400", VA = "0x182F73000")]
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
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public BAAPIFCMJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F80A00", Offset = "0x2F7FE00", VA = "0x182F80A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PCBIJDFBMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FC40", Offset = "0x2F7F040", VA = "0x182F7FC40")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private readonly HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private OBLBGKHHEIM KFIKNPBGMBO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private IMKGIBOCLAG GLLMOCALFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x825E50", Offset = "0x825250", VA = "0x180825E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public BAAPIFCMJOI(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x25EF2F0", Offset = "0x25EE6F0", VA = "0x1825EF2F0")]
	[AsyncStateMachine(typeof(KOAMLDHMLEP))]
	public Task KJENKEOBMBM(DNNPENLDDEC MFHLKCFDMNF, JILMCFPJPGB IFDJIENGHHN, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x25EEA20", Offset = "0x25EDE20", VA = "0x1825EEA20")]
	[AsyncStateMachine(typeof(HBALKDMNPBP))]
	private Task BGAIEDFDJBP(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x25EF190", Offset = "0x25EE590", VA = "0x1825EF190")]
	[AsyncStateMachine(typeof(LIHENGIPJMH))]
	private Task KEPKHNGFIHO(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x25EF760", Offset = "0x25EEB60", VA = "0x1825EF760")]
	[AsyncStateMachine(typeof(PBDEFMCHDKN))]
	private Task LMJOGMGIBAB(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x25EF8C0", Offset = "0x25EECC0", VA = "0x1825EF8C0")]
	[AsyncStateMachine(typeof(LBLAPCBNIKG))]
	private Task MFKMJPLCBGE(Guid JIDHOAJGHNB, List<HEABMPIIHCO> OINFMBINCPE, FNNOKHIDILJ AICDAGLKCFE, JILMCFPJPGB HIDEHJGLNHO, CancellationToken MIFCLBEAOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x25EF040", Offset = "0x25EE440", VA = "0x1825EF040")]
	[AsyncStateMachine(typeof(MPKADGMOCAA))]
	private Task IECGNJDJGMF(JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x25EF450", Offset = "0x25EE850", VA = "0x1825EF450")]
	[AsyncStateMachine(typeof(HGLMLEHKHDO))]
	private Task KKPONEFJECI(Guid FHCPAMNAENB, JILMCFPJPGB HIDEHJGLNHO, HKNIJBILNIP MJOCLEMBKBO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x25EED50", Offset = "0x25EE150", VA = "0x1825EED50")]
	[AsyncStateMachine(typeof(PMACCLOAOFB))]
	private Task EMBDCKGELJA(Guid FHCPAMNAENB, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x25EEEA0", Offset = "0x25EE2A0", VA = "0x1825EEEA0")]
	private void FHHHMNGEHEB(Guid FHCPAMNAENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x25EFA00", Offset = "0x25EEE00", VA = "0x1825EFA00")]
	private void PBNPNNLGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x25EEB80", Offset = "0x25EDF80", VA = "0x1825EEB80")]
	public Guid EKAGOMEGAJO(DNNPENLDDEC ALOFFKDKDOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x25EF590", Offset = "0x25EE990", VA = "0x1825EF590")]
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
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public BMMONKKCCCK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public JILMCFPJPGB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public HAACNKIHLLI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A45670", Offset = "0x3A44A70", VA = "0x183A45670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A45870", Offset = "0x3A44C70", VA = "0x183A45870", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public JAJCHAKPOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A424D0", Offset = "0x3A418D0", VA = "0x183A424D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A42A20", Offset = "0x3A41E20", VA = "0x183A42A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private BMMONKKCCCK FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private JILMCFPJPGB HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private ByteString FMCMGOJJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private HAACNKIHLLI NLFLBJNDBCF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DEEFNALDPBL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2608FB0", Offset = "0x26083B0", VA = "0x182608FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool EBBFPBACNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2608E60", Offset = "0x2608260", VA = "0x182608E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool AHHCOCINBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2608F20", Offset = "0x2608320", VA = "0x182608F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool GCPFINBFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x2608EE0", Offset = "0x26082E0", VA = "0x182608EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2609000", Offset = "0x2608400", VA = "0x182609000")]
	[AsyncStateMachine(typeof(DNMKJPJHHAC))]
	public static Task<bool> KJENKEOBMBM(BMMONKKCCCK FDPHPHDPLEL, JILMCFPJPGB HIDEHJGLNHO, HAACNKIHLLI NLFLBJNDBCF, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2609190", Offset = "0x2608590", VA = "0x182609190")]
	[AsyncStateMachine(typeof(BHKAJOKJGEB))]
	private Task<bool> KJENKEOBMBM(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public readonly struct FCIBLCNJCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	public readonly bool EAHOCLJDHDD;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xCB80A0", Offset = "0xCB74A0", VA = "0x180CB80A0")]
	public FCIBLCNJCKE(bool HPDMMFKOPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public readonly struct DEIOFMFEJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	public readonly ALDNBFOLDOE? JJACLKJJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	public readonly PHJGAMCCJEB LMGJJLKHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public readonly string? ENAGDNAMEFG;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyCollection<string> PJCKJLCFGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x25F8DE0", Offset = "0x25F81E0", VA = "0x1825F8DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyDictionary<long, int> OOGCLIFJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x25F8E00", Offset = "0x25F8200", VA = "0x1825F8E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x25F8E20", Offset = "0x25F8220", VA = "0x1825F8E20")]
	public DEIOFMFEJDI(ALDNBFOLDOE? GOKPFGBACOI, PHJGAMCCJEB PODOLEPJFNP, string? MLKOMNKNPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal class HGEJIOHJADL : PPKCBLMJCHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct HGAPJKEDKLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder<DEIOFMFEJDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A080", Offset = "0x3A49480", VA = "0x183A4A080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A560", Offset = "0x3A49960", VA = "0x183A4A560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class GLGFFLLNABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GLGFFLLNABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A49440", Offset = "0x3A48840", VA = "0x183A49440")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A49680", Offset = "0x3A48A80", VA = "0x183A49680")]
		internal Task <PreserializeViews>b__2(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class NMJBFGHNHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public GLGFFLLNABD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NMJBFGHNHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A50D40", Offset = "0x3A50140", VA = "0x183A50D40")]
		internal object <PreserializeViews>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class JFPDMFMJNDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public GLGFFLLNABD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JFPDMFMJNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A4CD00", Offset = "0x3A4C100", VA = "0x183A4CD00")]
		internal Task <PreserializeViews>b__5(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct LIAIAGHEBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public OAGGKMECOKN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public HGEJIOHJADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private NMJBFGHNHBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private JHMJCENAIID.HJIEOMAMMOJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A4EDD0", Offset = "0x3A4E1D0", VA = "0x183A4EDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private readonly JHJMJFFJEOO KJHKAEFGNNP;

	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private static readonly TimeSpan FCAMKDJAGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private readonly GIFKACLJBBM NMPIHBIODLD;

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2601D10", Offset = "0x2601110", VA = "0x182601D10")]
	public HGEJIOHJADL(HAACNKIHLLI NLFLBJNDBCF, GIFKACLJBBM NMPIHBIODLD, [Optional] JHJMJFFJEOO? KJHKAEFGNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x2601510", Offset = "0x2600910", VA = "0x182601510")]
	[AsyncStateMachine(typeof(HGAPJKEDKLG))]
	public Task<DEIOFMFEJDI> HLHCEBOKDMG(long HBNJLALONNE, string MLKOMNKNPAD, OAGGKMECOKN CFEABAFCLMD, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2600AF0", Offset = "0x25FFEF0", VA = "0x182600AF0")]
	[AsyncStateMachine(typeof(LIAIAGHEBCG))]
	private Task AFBJIDDILJF(OAGGKMECOKN CFEABAFCLMD, IEnumerable<PersistenceView> HMBHDLPJNBB, StringBuilder AGMJAIEIFKK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x2601690", Offset = "0x2600A90", VA = "0x182601690")]
	private DEIOFMFEJDI OBJFMJBAAOI(long HBNJLALONNE, string MLKOMNKNPAD, OAGGKMECOKN CFEABAFCLMD, IEnumerable<PersistenceView> HMBHDLPJNBB, StringBuilder AGMJAIEIFKK)
	{
		return default(DEIOFMFEJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x2600C50", Offset = "0x2600050", VA = "0x182600C50")]
	private ALDNBFOLDOE BGDNACNNBHB(long HBNJLALONNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2600DC0", Offset = "0x26001C0", VA = "0x182600DC0")]
	private void EGIILNFOLEG(ALDNBFOLDOE CDNGHHDCBMA, StringBuilder AGMJAIEIFKK, IEnumerable<PersistenceView> HMBHDLPJNBB, in IEPIAGALNAB COEEJIEMCIP, ref NMGEBKPMOHP HCKNFNGDNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2600FE0", Offset = "0x26003E0", VA = "0x182600FE0")]
	private void HFFKHFHFNAJ(ALDNBFOLDOE CDNGHHDCBMA, StringBuilder AGMJAIEIFKK, PersistenceView KANBPIJHFNA, ref NMGEBKPMOHP HCKNFNGDNJB, in IEPIAGALNAB COEEJIEMCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal class LBHMAKJMHJK : PPKCBLMJCHH
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class AKBDJJGNNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AKBDJJGNNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCDB0", Offset = "0x3DFC1B0", VA = "0x183DFCDB0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCE40", Offset = "0x3DFC240", VA = "0x183DFCE40")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCE90", Offset = "0x3DFC290", VA = "0x183DFCE90")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCF00", Offset = "0x3DFC300", VA = "0x183DFCF00")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct ECAFGMAJAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private AKBDJJGNNPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<JJALEIDMEJJ.PDLFMNIBJJO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF130", Offset = "0x3DFE530", VA = "0x183DFF130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFBF0", Offset = "0x3DFEFF0", VA = "0x183DFFBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct NKCBMOKNGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public AsyncTaskMethodBuilder<HJAFOAIDLLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter<HJAFOAIDLLN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E09360", Offset = "0x3E08760", VA = "0x183E09360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E09820", Offset = "0x3E08C20", VA = "0x183E09820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct CMGCICLEFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder<PDFKCDIAEML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<(JJALEIDMEJJ.PDLFMNIBJJO roomDataUpload, JJALEIDMEJJ.PDLFMNIBJJO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter<PDFKCDIAEML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE010", Offset = "0x3DFD410", VA = "0x183DFE010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE3A0", Offset = "0x3DFD7A0", VA = "0x183DFE3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class LLIMHCACMKJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public LLIMHCACMKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private IKENBFLEHKK <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private TaskAwaiter<PDFKCDIAEML> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private TaskAwaiter<HJAFOAIDLLN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			private TaskAwaiter<IKENBFLEHKK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E650", Offset = "0x3E0DA50", VA = "0x183E0E650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x3E0F110", Offset = "0x3E0E510", VA = "0x183E0F110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public FCIBLCNJCKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A3440", Offset = "0x6A2840")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LLIMHCACMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E07AE0", Offset = "0x3E06EE0", VA = "0x183E07AE0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<IKENBFLEHKK> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct OJOLKCONFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder<IKENBFLEHKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public LBHMAKJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public DEIOFMFEJDI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public HOCIJINOOAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public FCIBLCNJCKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A34F0", Offset = "0x6A28F0")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter<IKENBFLEHKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A420", Offset = "0x3E09820", VA = "0x183E0A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A6E0", Offset = "0x3E09AE0", VA = "0x183E0A6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private const float HGOJILFKIEA = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private readonly FHAMAIJMDNM LAGCFKDBBCN;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private BMMONKKCCCK OABOAPFBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x260E7A0", Offset = "0x260DBA0", VA = "0x18260E7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F766E0", Offset = "0x2F75AE0", VA = "0x182F766E0")]
	public LBHMAKJMHJK(HAACNKIHLLI NLFLBJNDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F763E0", Offset = "0x2F757E0", VA = "0x182F763E0")]
	[AsyncStateMachine(typeof(ECAFGMAJAEM))]
	private Task<(JJALEIDMEJJ.PDLFMNIBJJO, JJALEIDMEJJ.PDLFMNIBJJO)> MICFCALGOCD(DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F76090", Offset = "0x2F75490", VA = "0x182F76090")]
	[AsyncStateMachine(typeof(NKCBMOKNGEF))]
	public Task<HJAFOAIDLLN> DNJGKEGEGHH(int OMKBGDEDOFD, [CanBeNull] HOCIJINOOAM JKFBHFINEFL, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F76550", Offset = "0x2F75950", VA = "0x182F76550")]
	[AsyncStateMachine(typeof(CMGCICLEFMI))]
	private Task<PDFKCDIAEML> NAODHNMCAFM(string BPIEFHJHNGI, int OMKBGDEDOFD, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F76220", Offset = "0x2F75620", VA = "0x182F76220")]
	[AsyncStateMachine(typeof(OJOLKCONFGO))]
	public Task<IKENBFLEHKK> FPNJCAHKCCN(int OMKBGDEDOFD, HOCIJINOOAM? JKFBHFINEFL, DEIOFMFEJDI NKLMKCALAPJ, long LCIEPBGBKGO, long HJCAHMBDEEM, FCIBLCNJCKE GCIONJIIJFG, HKNIJBILNIP BDBJGJIIKDE, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public abstract class GKKCPHAHENL<T> where T : global::GKKCPHAHENL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	internal readonly BMMONKKCCCK EHNFFFHJPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private int? EILHMIAEIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	protected readonly Guid ENBLPOIGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	protected readonly NNHCJPLIFIC IHKDPGBOAEG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	protected T KBFNKOGCMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x345BB90", Offset = "0x345AF90", VA = "0x18345BB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x345BEE0", Offset = "0x345B2E0", VA = "0x18345BEE0")]
	internal GKKCPHAHENL(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x345BC70", Offset = "0x345B070", VA = "0x18345BC70")]
	private IKENBFLEHKK KPPFPOJHKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	protected virtual void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x345BD50", Offset = "0x345B150", VA = "0x18345BD50")]
	public T NCMPELKBFDE(IEIHKFAAJEG DCELPOHIPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x345BBF0", Offset = "0x345AFF0", VA = "0x18345BBF0")]
	public T HIIILDLHOHJ(int HFBAGNHDHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x345BDE0", Offset = "0x345B1E0", VA = "0x18345BDE0", Slot = "5")]
	public virtual Task<IOCLDNFCAPD> NHHHFJJDOMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public class OMKLGDOBJIE : global::GKKCPHAHENL<OMKLGDOBJIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private MPCCILKBHMP GJNIFGAPEDN;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EFF0", Offset = "0x2F7E3F0", VA = "0x182F7EFF0")]
	internal OMKLGDOBJIE(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EF10", Offset = "0x2F7E310", VA = "0x182F7EF10")]
	public OMKLGDOBJIE DNGPOBFPCBI(MPCCILKBHMP GJNIFGAPEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EF30", Offset = "0x2F7E330", VA = "0x182F7EF30", Slot = "4")]
	protected override void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public class LBOANMGHMJK : global::GKKCPHAHENL<LBOANMGHMJK>
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	internal enum JGHIDABCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct OLIGJNODGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public AsyncTaskMethodBuilder<IOCLDNFCAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public LBOANMGHMJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private TaskAwaiter<IOCLDNFCAPD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A730", Offset = "0x3E09B30", VA = "0x183E0A730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AA30", Offset = "0x3E09E30", VA = "0x183E0AA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private JGHIDABCEBP BONPGNGNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private string DGFLIDNPKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private HOCIJINOOAM GJNIFGAPEDN;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F770C0", Offset = "0x2F764C0", VA = "0x182F770C0")]
	internal LBOANMGHMJK(BMMONKKCCCK OGLAPPGDKNE, NNHCJPLIFIC NABLKJBKJGK, [Optional] Guid? HPGJMKCMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2F76D40", Offset = "0x2F76140", VA = "0x182F76D40")]
	public LBOANMGHMJK BCEJDAJNILJ(string NFBKGEMICGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F76D70", Offset = "0x2F76170", VA = "0x182F76D70")]
	public LBOANMGHMJK DNIAHFMHKHD(bool GBJMEPJPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F76F00", Offset = "0x2F76300", VA = "0x182F76F00")]
	public LBOANMGHMJK GDONABALJJG(string CCJFOCJJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F76F30", Offset = "0x2F76330", VA = "0x182F76F30")]
	public LBOANMGHMJK IDBOEIOBKEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F76D90", Offset = "0x2F76190", VA = "0x182F76D90", Slot = "4")]
	protected override void EMMABGHDOJM(IKENBFLEHKK BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F76FA0", Offset = "0x2F763A0", VA = "0x182F76FA0", Slot = "5")]
	[AsyncStateMachine(typeof(OLIGJNODGEF))]
	public override Task<IOCLDNFCAPD> NHHHFJJDOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F76F60", Offset = "0x2F76360", VA = "0x182F76F60")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IOCLDNFCAPD> MLCOFNDDDHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal static class DOKANKCIMJF
{
	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x25FA100", Offset = "0x25F9500", VA = "0x1825FA100")]
	public static void JADMILDBJIK(this HEMLBBFAKKA BJANLLJJEBF, OFCNMCIOFIM LGHKHDGGALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x25FA250", Offset = "0x25F9650", VA = "0x1825FA250")]
	public static void OGDCIMBPLHM(this OFCNMCIOFIM GPGKFDLHFHG, [Optional] string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
public static class MOEKALLIIHN
{
	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B8E0", Offset = "0x2F7ACE0", VA = "0x182F7B8E0")]
	public static KKANDLGEEGN HIIPPGGIEKE(this HIGECGKJAFG GELIMIHGABP)
	{
		return default(KKANDLGEEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B980", Offset = "0x2F7AD80", VA = "0x182F7B980")]
	public static HIGECGKJAFG LOFFJEMNGKB(this KKANDLGEEGN ONPMPIEOPNF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public IEAAFONNOPI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public IEAAFONNOPI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private static IEAAFONNOPI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private Dictionary<IEAAFONNOPI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F83740", Offset = "0x2F82B40", VA = "0x182F83740")]
		public bool NHCBKGGNMOE(IEAAFONNOPI LBAAOGIJHJE, out ResultConfig ELAELJDAGOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F83620", Offset = "0x2F82A20", VA = "0x182F83620")]
		public ResultConfig DCIEHLLMIPI(IEAAFONNOPI JALEHBMHNHI, [Optional] HashSet<IEAAFONNOPI> LGOFJIJLBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2F83D30", Offset = "0x2F83130", VA = "0x182F83D30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2F837B0", Offset = "0x2F82BB0", VA = "0x182F837B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xC5D680", Offset = "0xC5CA80", VA = "0x180C5D680")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public static class BPAJOCGBKCB
{
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x25F6260", Offset = "0x25F5660", VA = "0x1825F6260")]
	[JDDIJBKLPJE(GHILFLKBMBN.GameOnly)]
	private static void JCIGPGHKKDF(AOONKACGDKK HBEJHFKCBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public interface LFLMMDJMDFC : IEquatable<LFLMMDJMDFC>
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	DateTime JKMAICDIODN
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJBDOLGCLHN();

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLHHIJEDKJM(long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class EMKDILGOEIK : NHAGLHPLIJK
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class MEHPCLMKBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MEHPCLMKBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x3A502D0", Offset = "0x3A4F6D0", VA = "0x183A502D0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly JPGOGPHHBDL IODEPELPLCG;

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private const int KCLBMAOBLKG = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<LFLMMDJMDFC> DHMDPDCJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x25FBD30", Offset = "0x25FB130", VA = "0x1825FBD30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x25FC110", Offset = "0x25FB510", VA = "0x1825FC110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	[UnityEngine.Scripting.Preserve]
	public EMKDILGOEIK([LIKONNNLKGK(null)] JPGOGPHHBDL IODEPELPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x25FC5A0", Offset = "0x25FB9A0", VA = "0x1825FC5A0", Slot = "6")]
	public bool PPPMCGGAEGO(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x25FBF50", Offset = "0x25FB350", VA = "0x1825FBF50")]
	private void BEPIEOCAFCB(LFLMMDJMDFC DADNHALGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x25FBDD0", Offset = "0x25FB1D0", VA = "0x1825FBDD0", Slot = "7")]
	public bool BEOJKECKOLL(long LCIEPBGBKGO, long HBNJLALONNE, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x25FBC80", Offset = "0x25FB080", VA = "0x1825FBC80", Slot = "8")]
	public bool AAMPCPPNAGP(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DMNFJMFHKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x25FC1B0", Offset = "0x25FB5B0", VA = "0x1825FC1B0")]
	private void LFOPDJHHLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x25FBFF0", Offset = "0x25FB3F0", VA = "0x1825FBFF0", Slot = "9")]
	public void CCFPKNBIJPM(long LCIEPBGBKGO, long HBNJLALONNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal abstract class DHJPAFIILJE : JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	protected enum IJIJCFCKAAC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class DDEOECEIDMN : IEnumerable<LFLMMDJMDFC>, IEnumerable, IEnumerator<LFLMMDJMDFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private LFLMMDJMDFC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public DHJPAFIILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public GDONNAAGMMP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private LFLMMDJMDFC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public DDEOECEIDMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x3A44460", Offset = "0x3A43860", VA = "0x183A44460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x3A44670", Offset = "0x3A43A70", VA = "0x183A44670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x3A445C0", Offset = "0x3A439C0", VA = "0x183A445C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LFLMMDJMDFC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x3A445C0", Offset = "0x3A439C0", VA = "0x183A445C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class CKEGAHKNCIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CKEGAHKNCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x3A43950", Offset = "0x3A42D50", VA = "0x183A43950")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class NAFPBLNHBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public DHJPAFIILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NAFPBLNHBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x3A509F0", Offset = "0x3A4FDF0", VA = "0x183A509F0")]
		internal void <TryReadAutosaveFile>b__0(ELNBDCJFCIL.OGLDJMJGPJB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	protected readonly string PEOCEIGFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private readonly object NONHFDBGPNH;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x25F97F0", Offset = "0x25F8BF0", VA = "0x1825F97F0")]
	protected DHJPAFIILJE([CanBeNull] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x25F9610", Offset = "0x25F8A10", VA = "0x1825F9610", Slot = "5")]
	public bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x25F9270", Offset = "0x25F8670", VA = "0x1825F9270", Slot = "6")]
	[IteratorStateMachine(typeof(DDEOECEIDMN))]
	public IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x25F8F20", Offset = "0x25F8320", VA = "0x1825F8F20", Slot = "7")]
	public LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x25F92F0", Offset = "0x25F86F0", VA = "0x1825F92F0")]
	protected void NIEOADLLEKK(ELNBDCJFCIL.OGLDJMJGPJB CHANIHNLGDA, string HKNFNIPGHDE, FileInfo OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x25F9360", Offset = "0x25F8760", VA = "0x1825F9360")]
	internal bool OMEEOAFCCJP(FileInfo JGIGLBPNCEL, long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private void LOGMGDKOLCI(Exception JIBCJCBDLGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class JFJPNOLJFEB : DHJPAFIILJE
{
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private const string CMDKJOJBPLN = "V2";

	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	private const string BMPNEAFAJIG = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private const string MGFHKANIGKJ = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public override COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xDDC1D0", Offset = "0xDDB5D0", VA = "0x180DDC1D0", Slot = "8")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2609C90", Offset = "0x2609090", VA = "0x182609C90")]
	public JFJPNOLJFEB([Optional] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x26092F0", Offset = "0x26086F0", VA = "0x1826092F0")]
	private void JHEPPKCIPLA(GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x2609990", Offset = "0x2608D90", VA = "0x182609990", Slot = "9")]
	internal override void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2609460", Offset = "0x2608860", VA = "0x182609460", Slot = "10")]
	internal override bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2609370", Offset = "0x2608770", VA = "0x182609370", Slot = "11")]
	protected override FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2609B80", Offset = "0x2608F80", VA = "0x182609B80", Slot = "12")]
	protected override DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal sealed class AEIMHNOEHLD : DHJPAFIILJE
{
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private static readonly byte[] OGFDNCPKECB;

	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private const string BMPNEAFAJIG = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private const string MGFHKANIGKJ = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private const string DNKJBFAIBIO = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private readonly byte[] IHBGAOFFBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private readonly byte[] POCCNOANFJF;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7A03D0", Offset = "0x79F7D0", VA = "0x1807A03D0", Slot = "8")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x25ED280", Offset = "0x25EC680", VA = "0x1825ED280")]
	public AEIMHNOEHLD([Optional] string NOLIHLECHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x25ECD80", Offset = "0x25EC180", VA = "0x1825ECD80", Slot = "9")]
	internal override void MHHMBEJFLLO(Stream CLCPLIIGKKM, long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x25EC640", Offset = "0x25EBA40", VA = "0x1825EC640", Slot = "10")]
	internal override bool JPMBANLBKKL(Stream LCNHJMLNHMO, long LCIEPBGBKGO, long HBNJLALONNE, JMABOBEGLPP AGJAAMFIEKL, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x25ECFD0", Offset = "0x25EC3D0", VA = "0x1825ECFD0")]
	private void NGLGMFPCKDA(byte[] EMIAMELGKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x25EC510", Offset = "0x25EB910", VA = "0x1825EC510", Slot = "11")]
	protected override FileInfo JIGNFNCJFBG(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x25ED0E0", Offset = "0x25EC4E0", VA = "0x1825ED0E0", Slot = "12")]
	protected override DirectoryInfo OMLPGDEKEDP(GDONNAAGMMP DDKEDGNNMCH, IJIJCFCKAAC NGDMNKOPGBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public enum COHFILLHMHP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class FDHGHOFCDMG : JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class ABHJFFBGPNI : IEnumerable<LFLMMDJMDFC>, IEnumerable, IEnumerator<LFLMMDJMDFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private LFLMMDJMDFC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public FDHGHOFCDMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private GDONNAAGMMP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public GDONNAAGMMP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private COHFILLHMHP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private IEnumerator<LFLMMDJMDFC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private LFLMMDJMDFC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public ABHJFFBGPNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3A41C30", Offset = "0x3A41030", VA = "0x183A41C30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x3A41860", Offset = "0x3A40C60", VA = "0x183A41860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x3A41CC0", Offset = "0x3A410C0", VA = "0x183A41CC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x3A41BF0", Offset = "0x3A40FF0", VA = "0x183A41BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x3A41B40", Offset = "0x3A40F40", VA = "0x183A41B40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LFLMMDJMDFC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3A41B40", Offset = "0x3A40F40", VA = "0x183A41B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private readonly COHFILLHMHP[] CPJGHPHOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly Dictionary<COHFILLHMHP, JPGOGPHHBDL> HEBMKPINHGF;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x25FCC60", Offset = "0x25FC060", VA = "0x1825FCC60", Slot = "4")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x25FCE80", Offset = "0x25FC280", VA = "0x1825FCE80")]
	[UnityEngine.Scripting.Preserve]
	public FDHGHOFCDMG(params JPGOGPHHBDL[] JCJNIPGAILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x25FCD20", Offset = "0x25FC120", VA = "0x1825FCD20", Slot = "5")]
	public bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x25FC930", Offset = "0x25FBD30", VA = "0x1825FC930")]
	private void GJHDGIPNPIH(int DMJDBHDDPFL, long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x25FCCA0", Offset = "0x25FC0A0", VA = "0x1825FCCA0", Slot = "6")]
	[IteratorStateMachine(typeof(ABHJFFBGPNI))]
	public IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x25FCB70", Offset = "0x25FBF70", VA = "0x1825FCB70", Slot = "7")]
	public LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal static class PNFBLAJFOPL
{
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	internal const int HPPNBLEONOE = 32;

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2F81230", Offset = "0x2F80630", VA = "0x182F81230")]
	internal static byte[] DLFHDIHNOOA(byte[] EMIAMELGKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x2F814B0", Offset = "0x2F808B0", VA = "0x182F814B0")]
	public static void KOLEAOFNPLJ(Stream NEHKLODBFEL, byte[] MEHLKMBPJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2F812D0", Offset = "0x2F806D0", VA = "0x182F812D0")]
	public static bool KAIONIFLOLO(Stream NEHKLODBFEL, long DALDPMCIIAF, JMABOBEGLPP FDLANEODAFF, out byte[] FHJBOIKJAIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
internal sealed class DLLDLLIACIC : LFLMMDJMDFC, IEquatable<LFLMMDJMDFC>, IEquatable<DLLDLLIACIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private readonly DHJPAFIILJE NLHOIDKNKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	public readonly FileInfo ODOFIOIALKE;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA21700", Offset = "0xA20B00", VA = "0x180A21700", Slot = "4")]
		get
		{
			return default(COHFILLHMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public DateTime JKMAICDIODN
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x25F9AC0", Offset = "0x25F8EC0", VA = "0x1825F9AC0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x25FA000", Offset = "0x25F9400", VA = "0x1825FA000")]
	public DLLDLLIACIC(DHJPAFIILJE HIBDEIOOCBK, FileInfo JGIGLBPNCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x25F9F50", Offset = "0x25F9350", VA = "0x1825F9F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x25F9E90", Offset = "0x25F9290", VA = "0x1825F9E90", Slot = "6")]
	public void OJBDOLGCLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x25F9A80", Offset = "0x25F8E80", VA = "0x1825F9A80", Slot = "7")]
	public bool BLHHIJEDKJM(long LCIEPBGBKGO, long HBNJLALONNE, out DEIOFMFEJDI NKLMKCALAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x25F9D10", Offset = "0x25F9110", VA = "0x1825F9D10", Slot = "8")]
	public bool Equals(LFLMMDJMDFC MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x25F9C60", Offset = "0x25F9060", VA = "0x1825F9C60", Slot = "9")]
	public bool Equals(DLLDLLIACIC MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x25F9B60", Offset = "0x25F8F60", VA = "0x1825F9B60", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x25F9DF0", Offset = "0x25F91F0", VA = "0x1825F9DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x1BA9980", Offset = "0x1BA8D80", VA = "0x181BA9980")]
	public static bool BOBJELOEACN(DLLDLLIACIC LJLKLAFAGNO, DLLDLLIACIC HFBAHIGFPIF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x1BA9D60", Offset = "0x1BA9160", VA = "0x181BA9D60")]
	public static bool GPCPOEGFAHL(DLLDLLIACIC LJLKLAFAGNO, DLLDLLIACIC HFBAHIGFPIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
public delegate void JMABOBEGLPP(ELNBDCJFCIL.OGLDJMJGPJB FDBGBIOHHGF, string BALNMHDNCIN);
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal interface JPGOGPHHBDL
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	COHFILLHMHP BLNPHHIPHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OMMDKMIDIGC(long LCIEPBGBKGO, long HBNJLALONNE, GDONNAAGMMP DDKEDGNNMCH, out LFLMMDJMDFC DADNHALGJFA);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LFLMMDJMDFC> NGPGCFBHALK(GDONNAAGMMP DDKEDGNNMCH);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFLMMDJMDFC HPCMPOOJPEA(long LCIEPBGBKGO, long HBNJLALONNE, DEIOFMFEJDI NKLMKCALAPJ, GDONNAAGMMP DDKEDGNNMCH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x260C6B0", Offset = "0x260BAB0", VA = "0x18260C6B0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x260C360", Offset = "0x260B760", VA = "0x18260C360")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
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
