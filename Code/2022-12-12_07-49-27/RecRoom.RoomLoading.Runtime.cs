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
public class DIEFELPOIJH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3203950", Offset = "0x3201F50", VA = "0x183203950")]
	public DIEFELPOIJH(string DIDMFBHHIEC, Exception JFHFLCLBOLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class KBKMLHOLEJD : ANDDFFOAIFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NJENMIEHJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ELBFJLGDNOH>> <>t__builder;

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
		private TaskAwaiter<global::ECPNENNDDGN<ELBFJLGDNOH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4059360", Offset = "0x4057960", VA = "0x184059360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4059540", Offset = "0x4057B40", VA = "0x184059540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LONECPGMKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IDMILKFHJFE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<IDMILKFHJFE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4056870", Offset = "0x4054E70", VA = "0x184056870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4056A30", Offset = "0x4055030", VA = "0x184056A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	[Preserve]
	public KBKMLHOLEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3215050", Offset = "0x3213650", VA = "0x183215050", Slot = "4")]
	[AsyncStateMachine(typeof(NJENMIEHJMH))]
	public Task<IReadOnlyList<ELBFJLGDNOH>> OCOAFDADFDG(long FAFDJINDEIN, long KJHHBFLPCIE, [Optional] CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3214F10", Offset = "0x3213510", VA = "0x183214F10", Slot = "5")]
	[AsyncStateMachine(typeof(LONECPGMKFL))]
	public Task<IReadOnlyList<IDMILKFHJFE>> ANBPMOBAHFA(IReadOnlyList<int> PPMKKBCEBIH, [Optional] CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BHGJJAMBCGO : IEquatable<BHGJJAMBCGO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BDAGMIIOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	IDMILKFHJFE BFJCCIMBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime IPLLKEHODIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MLLIOEOGGHL? HIDCHHOPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PIAFFLEPLOE? CNBMFHBOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JIBPODKNJLL KFJFOLBKEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HNKKGJKFCMD> CHGOKIHEHMG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JIBPODKNJLL
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ANDDFFOAIFD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ELBFJLGDNOH>> OCOAFDADFDG(long FAFDJINDEIN, long KJHHBFLPCIE, [Optional] CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<IDMILKFHJFE>> ANBPMOBAHFA(IReadOnlyList<int> PPMKKBCEBIH, [Optional] CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OKNHKAMKHIF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class LKNIBINOPAF : BHGJJAMBCGO, IEquatable<BHGJJAMBCGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct DIJLGGHBGDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LKNIBINOPAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private HOKMKHEIMLO <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<KFMOMBKGPMO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<HNKKGJKFCMD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D430", Offset = "0x4A4BA30", VA = "0x184A4D430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D8C0", Offset = "0x4A4BEC0", VA = "0x184A4D8C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ELBFJLGDNOH EECFJGKPIPO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BDAGMIIOAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IDMILKFHJFE BFJCCIMBGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime HJGIGJNOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2137D10", Offset = "0x2136310", VA = "0x182137D10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MLLIOEOGGHL? HIDCHHOPLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xFE3A10", Offset = "0xFE2010", VA = "0x180FE3A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PIAFFLEPLOE? CNBMFHBOFDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xFE39D0", Offset = "0xFE1FD0", VA = "0x180FE39D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JIBPODKNJLL KFJFOLBKEOH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x677270", Offset = "0x675870", VA = "0x180677270", Slot = "10")]
			get
			{
				return default(JIBPODKNJLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4A50C60", Offset = "0x4A4F260", VA = "0x184A50C60", Slot = "9")]
		[AsyncStateMachine(typeof(DIJLGGHBGDO))]
		public Task<HNKKGJKFCMD> CHGOKIHEHMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4A50F90", Offset = "0x4A4F590", VA = "0x184A50F90")]
		public LKNIBINOPAF(int DNGIKCEPPCP, IDMILKFHJFE BLDJPGFHFHE, ELBFJLGDNOH EECFJGKPIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4A50E30", Offset = "0x4A4F430", VA = "0x184A50E30", Slot = "11")]
		public bool Equals(BHGJJAMBCGO OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4A50D90", Offset = "0x4A4F390", VA = "0x184A50D90", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4A50F50", Offset = "0x4A4F550", VA = "0x184A50F50")]
		private bool JMAMHJPFMMH(LKNIBINOPAF OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4A50EC0", Offset = "0x4A4F4C0", VA = "0x184A50EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class FAILLMPONJJ : BHGJJAMBCGO, IEquatable<BHGJJAMBCGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct BIMJCMNPKJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public FAILLMPONJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<HNKKGJKFCMD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4A49D70", Offset = "0x4A48370", VA = "0x184A49D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4A49F50", Offset = "0x4A48550", VA = "0x184A49F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly HFFCNJPOHMD JALCMOPOPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MLLIOEOGGHL JJHOOICDKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly PIAFFLEPLOE HNEOEHEJNBM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BDAGMIIOAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A4ED00", Offset = "0x4A4D300", VA = "0x184A4ED00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IDMILKFHJFE BFJCCIMBGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4A4EB60", Offset = "0x4A4D160", VA = "0x184A4EB60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime HJGIGJNOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4A4ECB0", Offset = "0x4A4D2B0", VA = "0x184A4ECB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MLLIOEOGGHL? HIDCHHOPLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4A4EC60", Offset = "0x4A4D260", VA = "0x184A4EC60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PIAFFLEPLOE? CNBMFHBOFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4A4EA80", Offset = "0x4A4D080", VA = "0x184A4EA80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JIBPODKNJLL KFJFOLBKEOH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3300", Offset = "0x8C1900", VA = "0x1808C3300", Slot = "10")]
			get
			{
				return default(JIBPODKNJLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB878F0", Offset = "0xB85EF0", VA = "0x180B878F0")]
		public FAILLMPONJJ(HFFCNJPOHMD ALLHONMJPOC, MLLIOEOGGHL KAFMANCDJIB, PIAFFLEPLOE HOKJHJFJPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E810", Offset = "0x4A4CE10", VA = "0x184A4E810", Slot = "9")]
		[AsyncStateMachine(typeof(BIMJCMNPKJO))]
		public Task<HNKKGJKFCMD> CHGOKIHEHMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E930", Offset = "0x4A4CF30", VA = "0x184A4E930", Slot = "11")]
		public bool Equals(BHGJJAMBCGO OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E9D0", Offset = "0x4A4CFD0", VA = "0x184A4E9D0", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EC00", Offset = "0x4A4D200", VA = "0x184A4EC00")]
		private bool JMAMHJPFMMH(FAILLMPONJJ OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EAD0", Offset = "0x4A4D0D0", VA = "0x184A4EAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class BLDCIDCMBIP : BHGJJAMBCGO, IEquatable<BHGJJAMBCGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct ILIBHPIANOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<HNKKGJKFCMD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4A4F450", Offset = "0x4A4DA50", VA = "0x184A4F450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4A4F630", Offset = "0x4A4DC30", VA = "0x184A4F630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly IDMILKFHJFE DCGNDAGINAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly MLLIOEOGGHL JJHOOICDKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PIAFFLEPLOE HNEOEHEJNBM;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BDAGMIIOAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AD60", Offset = "0x4A49360", VA = "0x184A4AD60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public IDMILKFHJFE BFJCCIMBGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime HJGIGJNOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MLLIOEOGGHL? HIDCHHOPLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AD10", Offset = "0x4A49310", VA = "0x184A4AD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PIAFFLEPLOE? CNBMFHBOFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AB10", Offset = "0x4A49110", VA = "0x184A4AB10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JIBPODKNJLL KFJFOLBKEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "10")]
			get
			{
				return default(JIBPODKNJLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB878F0", Offset = "0xB85EF0", VA = "0x180B878F0")]
		public BLDCIDCMBIP(IDMILKFHJFE BLDJPGFHFHE, MLLIOEOGGHL KAFMANCDJIB, PIAFFLEPLOE HOKJHJFJPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A790", Offset = "0x4A48D90", VA = "0x184A4A790", Slot = "9")]
		[AsyncStateMachine(typeof(ILIBHPIANOI))]
		public Task<HNKKGJKFCMD> CHGOKIHEHMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A880", Offset = "0x4A48E80", VA = "0x184A4A880", Slot = "11")]
		public bool Equals(BHGJJAMBCGO OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A9C0", Offset = "0x4A48FC0", VA = "0x184A4A9C0", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AB60", Offset = "0x4A49160", VA = "0x184A4AB60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AC10", Offset = "0x4A49210", VA = "0x184A4AC10")]
		private bool JMAMHJPFMMH(BLDCIDCMBIP OANENNOJEBB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DGFMBIDODCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<BHGJJAMBCGO>> <>t__builder;

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
		public OKNHKAMKHIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<ELBFJLGDNOH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<ELBFJLGDNOH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, IDMILKFHJFE account, ELBFJLGDNOH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C950", Offset = "0x4A4AF50", VA = "0x184A4C950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D3E0", Offset = "0x4A4B9E0", VA = "0x184A4D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CJBANDBOFOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, IDMILKFHJFE account, ELBFJLGDNOH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<ELBFJLGDNOH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OKNHKAMKHIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<IDMILKFHJFE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B840", Offset = "0x4A49E40", VA = "0x184A4B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C1C0", Offset = "0x4A4A7C0", VA = "0x184A4C1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LAEAPGNKCEO MNHLNJBAGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ANDDFFOAIFD KEEFFNEOGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EODLIBFMCBK BPHNNOPPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::NDNGBBCKHCE<(long, long), IReadOnlyList<ELBFJLGDNOH>> JJABLHNEMJA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D216F0", Offset = "0x3D1FCF0", VA = "0x183D216F0")]
	[Preserve]
	public OKNHKAMKHIF([KICKHKJFGOO(null)] ANDDFFOAIFD PBMLGFPBBFD, [KICKHKJFGOO(null)] EODLIBFMCBK ILHPPLBILJK, [KICKHKJFGOO(null)] LAEAPGNKCEO PBMLHBNBKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D212B0", Offset = "0x3D1F8B0", VA = "0x183D212B0")]
	[AsyncStateMachine(typeof(DGFMBIDODCP))]
	public Task<IList<BHGJJAMBCGO>> DCDENJAKINE(long FAFDJINDEIN, long BJDHMPBAACC, bool NJELONKFIAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D21540", Offset = "0x3D1FB40", VA = "0x183D21540")]
	private bool FCCMPCHIKOA(DateTime? PFDEOGHHIOI, long FAFDJINDEIN, long BJDHMPBAACC, out HFFCNJPOHMD GBNPJHBLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D21400", Offset = "0x3D1FA00", VA = "0x183D21400")]
	[AsyncStateMachine(typeof(CJBANDBOFOC))]
	private Task<IReadOnlyList<(int, IDMILKFHJFE, ELBFJLGDNOH)>> DIFCFEMBINM(IReadOnlyList<ELBFJLGDNOH> JLIPNAINFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EODLIBFMCBK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HFFCNJPOHMD> GIEEADBOBFB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DAAMAIMPDJH(long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE, DJMCEAKDOIN LLJBGAHHCBP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MABPCAGPHKA(long FAFDJINDEIN, long BJDHMPBAACC, out HFFCNJPOHMD GBNPJHBLLHG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GOHIMGLLGAG(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, out HFFCNJPOHMD GBNPJHBLLHG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNIDDPEAEAA(long FAFDJINDEIN, long BJDHMPBAACC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface MLPGADEGBDL : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IDBIOBPCEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task KIMPFMJLJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKGDJHLICNC(Task LMDFEBFDNDF, string BMEAMINLEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface MDOLGLJHONG : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNKKGJKFCMD> INGCEEGHENB(HFFCNJPOHMD GBNPJHBLLHG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NHFANPNKGLE(CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface BGCIDMJMEGI : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KOANDAEHODA OPPJHNHJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJLIENMMMLL();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBLPAJBCECA();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface CGEHFEJBJEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface HCBPJJNGDOO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BEAFIBBFNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan CPBDKMELPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FGPDPAFOIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JEJNKDPGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NDLNHHEHNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IEINDJHEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MCJDEAICHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum JFHLFCHDOJE
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OHIGMNLGPGF
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
public struct OGHDDJALHCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly long AMKAIGLCPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly long KJHHBFLPCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly JFHLFCHDOJE MCLMFJEAHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CanBeNull]
	public readonly Exception BJILIFBKPGC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D20B90", Offset = "0x3D1F190", VA = "0x183D20B90")]
	public OGHDDJALHCM(long AMKAIGLCPLL, long KJHHBFLPCIE, JFHLFCHDOJE MCLMFJEAHEC, [CanBeNull] Exception BJILIFBKPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3D20B40", Offset = "0x3D1F140", VA = "0x183D20B40")]
	public static OGHDDJALHCM OOFEPMABPOC(IKMCGNPFENA PBCABMOPBBC, JFHLFCHDOJE MCLMFJEAHEC, [Optional] Exception BJILIFBKPGC)
	{
		return default(OGHDDJALHCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void IFHKCGHMLAK(OGHDDJALHCM CPFIFGNPGKI);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface IBNAFNKCHDM : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MBKGOAOOIOC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IFHKCGHMLAK ONACJMNPOGG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IFHKCGHMLAK LCACNODCCPA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IFHKCGHMLAK PCDPPPJIFFK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OHIGMNLGPGF, bool> NHCGLCCAMCN;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DOADFNAJANG();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LIPFLEFBHDL(OGHDDJALHCM CPFIFGNPGKI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGGCOEJGFNP(OGHDDJALHCM CPFIFGNPGKI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NAKMCNLLJDE(OGHDDJALHCM CPFIFGNPGKI);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDHHGMDCLBH(OHIGMNLGPGF DMPLKKLCBGL, bool HEOPHCHJMAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface OAMNBHJNBHE : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KCBJNPHNIKD();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCELCOHOLGH();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMOABCGDMKJ();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task NIOIFMFHOLF(EMLPMBHPMDM MJGIEGEMGND, CancellationToken HKLDIENGNNB);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface JFAJDMKDCOE : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BJOBNPKHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOEKKDDJOLB(NIOIFMFHOLF EJHGEIFEGAM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface EEFBLDDCJPC : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus IOHDOKKAONP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JMOLMIIDBFI(IKMCGNPFENA AGOPKDGGMFM, ODMCMDMIIOO IAFHLBMFEAK, CancellationToken CGNPIKGMLAB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class IBACLCFKLEI
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3210D50", Offset = "0x320F350", VA = "0x183210D50")]
	public static bool OFDABELKEHL(this EEFBLDDCJPC EPHHMAOIAKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PEHFLLKFGNK : HOKMKHEIMLO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken DANOEEKFEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	PEGEFOEHCCC CEAHPPGBFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	OGHNMHNJHKD OLBPIEBMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NIGKKDGFDLL IBKDOILBDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HOCHNEAIGFA FJNLIOLILEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OAGFELPGPII HGPKKDHHALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HKJGGEEKHJM CKGHAPNPNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PIJBHNICAJC KEKPFIPHEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MLPGADEGBDL FFLGEIIKLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MDOLGLJHONG LEGPJJFPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IBNAFNKCHDM APKKNJBDCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OAMNBHJNBHE IIFMPCOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EEFBLDDCJPC BFMCKPMMEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JFAJDMKDCOE PJMKCLLIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NJBDEIJJCHN PJKDJCIFCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JAGDIAEJBJB PFHOIECNPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	OKAJJGOMDFM OHGKFPEGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FPNGPNBBLMK CLPNHBILHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EENNCCEAIML HFILPCEIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FHHMNEGALCE NOKBNBHOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PGNCBAOABOL INPOOKAJIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CKCOMBPMAKH BHHNGPHDCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MDMPGKEIFFB BGNCMMJOLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FHDFGKAINFA NHEGCEBOPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NEAPKIDJFFE DMEJDNLCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BGCIDMJMEGI IIEBMLOHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	HCBPJJNGDOO PAPBJDDAHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HJKDDIICHFK KELIINMBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EODLIBFMCBK OIAJILFDLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DBNNBALOAPC(ODMCMDMIIOO BGKAMDHDGBK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface NJBDEIJJCHN : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NILFOALGDBC MFMCNFFMIAP(Guid KAOFPCAFLFA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMIFMEAGDDE(Guid KAOFPCAFLFA);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AINOHCMFOKK(Guid KAOFPCAFLFA, Task JNFJEAGEAPL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFKBAIMEICD(Guid KAOFPCAFLFA, HNKKGJKFCMD OJDHMPMEICD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMOABCGDMKJ(Guid KAOFPCAFLFA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(HNKKGJKFCMD, Task)> PENGIOKPMOF(Guid KAOFPCAFLFA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface JAGDIAEJBJB : CGEHFEJBJEO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface OKAJJGOMDFM : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGJLGJJBCDF(GMKGAFOGKAM DIDMFBHHIEC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGKCNAAHIFK(GMKGAFOGKAM DIDMFBHHIEC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JOMJELHHOJP> MOIOCBHOGPL(CancellationToken DECLKFMBNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate HNKKGJKFCMD ELJBJNOMEFO(CHIAPKEENBB LECPOHMBMNE, JOMJELHHOJP OKGFNLPFOFG);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FPNGPNBBLMK : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NILFOALGDBC KFAFAEJLPMN(GMKGAFOGKAM IANJDAGFMEA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCFKLMEFBEC(Guid KAOFPCAFLFA, Task JNFJEAGEAPL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface EENNCCEAIML : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNKKGJKFCMD> HFILPCEIENH(GMKGAFOGKAM JDCDMKBBFEE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FHHMNEGALCE : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ELFALKJEDMF> NBGMIJIFOCF(GPNAMOIINIG AEKLGCBMNDP, IKMCGNPFENA AGOPKDGGMFM, CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CKCOMBPMAKH : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKKGJKFCMD GHFIFKNLCJM(CHIAPKEENBB LECPOHMBMNE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KKHIJPILFGL(string GFBIJELPOGE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PGNCBAOABOL : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GMKGAFOGKAM> BPIHDNCEHCE(GMKGAFOGKAM GHNJJOLFHLE, GMCFJEBBKEC JCIKKLFHNKA, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GMKGAFOGKAM> PCNDOJGEELP(CancellationToken JLIEBAENBAG, GMCFJEBBKEC JCIKKLFHNKA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBAJEEKBPBO FDFOHDFCKPG(EDBOGFBFNEC DNOIABOEFCG, GPNAMOIINIG AEKLGCBMNDP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IBAJEEKBPBO AEBFMMPBEPN(EDBOGFBFNEC DNOIABOEFCG, GPNAMOIINIG AEKLGCBMNDP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MDMPGKEIFFB : CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKKGJKFCMD HLCLOHIOPKC(CHIAPKEENBB LECPOHMBMNE, JOMJELHHOJP OKGFNLPFOFG);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNKKGJKFCMD CABBJFLIHFM(CHIAPKEENBB ONJBJADNFEC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNKKGJKFCMD JMBOEPCBCHD(CHIAPKEENBB ONJBJADNFEC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FHDFGKAINFA
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HECOFAGFLCB(LCNCEEKMFHL AINNGDJPJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLGBIBFCDFM(LCNCEEKMFHL AINNGDJPJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIJCALLOEIN(LCNCEEKMFHL AINNGDJPJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAJPBPCOBGJ(LCNCEEKMFHL AINNGDJPJCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LCNCEEKMFHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IKMCGNPFENA LCCLNMEHJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, string> FPANBGLEBCN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::IMNAINPHIAI<string> AECMHKBLDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public LCNCEEKMFHL(IKMCGNPFENA OECLDILMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3218080", Offset = "0x3216680", VA = "0x183218080")]
	public LCNCEEKMFHL NFHECPHKBOB(string AIGAKEKDKHM, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3218000", Offset = "0x3216600", VA = "0x183218000")]
	public bool GDHLCFJEHIC(out IEnumerable<KeyValuePair<string, string>> OFMGHBLKLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x948600", Offset = "0x946C00", VA = "0x180948600")]
	public LCNCEEKMFHL JDOCKMILAGH(global::IMNAINPHIAI<string> IDKFKDEHFHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HJKDDIICHFK
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool POPPIJOGLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string JNKJINIEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFOBJEAEOBO();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFFCJBEKFIH DLCOOCACEGF(long HBFDFDGJDBK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MHGMMAFIJAI<LLGMLEHJMCJ, PBAIJGCAICP> KNHHHAJCGPP(long HBFDFDGJDBK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MHGMMAFIJAI<LLGMLEHJMCJ, CIFBNNGALCD> PFGKCKOOPAI(long HBFDFDGJDBK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MHGMMAFIJAI<long, GKPJHGOMINL> MIIMLNNPKEA();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> LACBIJOMPLL(byte[] NPBGCOOPEJO, byte[] CBPEMPBPFMO, CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HOKMKHEIMLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OFDABELKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JCDLDAEHGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task GFPPHAMHPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ODMCMDMIIOO OPIOIDKGEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MBKGOAOOIOC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IFHKCGHMLAK ONACJMNPOGG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IFHKCGHMLAK LCACNODCCPA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IFHKCGHMLAK PCDPPPJIFFK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OHIGMNLGPGF, bool> NHCGLCCAMCN;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JCELCOHOLGH();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NEPAAGJDNIP NDFEOEHNOJP();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IICKKMOGJNC HGEDJFFJLCD();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<HNKKGJKFCMD> INGCEEGHENB(HFFCNJPOHMD ALLHONMJPOC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NHFANPNKGLE(CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HOCHNEAIGFA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MPAMOOAIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string MIHACEHFCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIOHNFFBKEB(Scene BFOOIGOJNJN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DPFANPOKCDL(MAHIAFPEFOP JAIABNHLOBI, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LOHEEDCPKIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EEOMMJMOFEO
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int BKMDGICBJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NLNLAABJMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DDLFLBKDBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool EEOLIPIJBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool JGCBDBPACMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool DBKFKFGEFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	CHIAPKEENBB GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool CHOEOOEPJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEGEFOEHCCC IKEPDHLOMBO(PEGEFOEHCCC DFGEEFJFNPH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFLNLCHKFAC(PEGEFOEHCCC IGFHDABHNLN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NONLOIDBHGF(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task AMIGDOKKANB(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CMCDHEILKGH(OCKEDGPKKMH ECMALJHOMMC, [Optional] CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LGODDBJPMNF(float FDGOEGBIGCD);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NINIMFBOADH(string PJDLNFGCCHI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<FBDDBGAPPNK> FKPOJKDDELO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable LLNFDMONDKB(object JOOJGLPIMBB, FBDDBGAPPNK APONMHBMIIF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PBAIJGCAICP JDMGNPKPEMH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GGGEENMMDPF(int FJCCDNPEOBM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OPKDHBDINCH();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CJGLGOBHCDH();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool LDOFABNPNBN();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OCGOKEPDLLM(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NDCBPEDEBJA(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<AGAPOBGBMCN> LIILLMAIGJC(DateTime KNIOPMCNGMG, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> ONNDJIMFMMM(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LGBCPFAEMPP();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KKBKOBCEICH HPAOJKHCOOI(JHCFIMFCHAI OCCAGACDAFL, CIFBNNGALCD KICABIGFPNC, IEnumerable<PersistenceView> BOFIIODFEHN, ref EFFCHKNPBAK GBHPAMBOKGL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KPCAJKOJLMB(DACGKLHBLIE AEABGDOMKJP, in KKBKOBCEICH ILAPGNJICNP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DANLKPLPGKN(CIFBNNGALCD HIFOLPKANOJ, bool NNGLFCJLIBL);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OBMGAMGIPOH();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JLNMDKMBNNO(long FAFDJINDEIN, long KJHHBFLPCIE, KFMOMBKGPMO FPDMMMILDCI, BGFIPODFDAA CKGACJHBBDE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KIOKFAPMFIA(long FAFDJINDEIN, long KJHHBFLPCIE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ONHDNFGKFKG(PersistenceView EEAFMOAFEPC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool FMILBEJHDCC(PersistenceView EDNIAMBKPNL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KOKDIKEEMJA(DACGKLHBLIE AEABGDOMKJP, KECCLNDCEEL LOKMNAHLNNL, out GLABAKABANJ FAPFKEHGOJH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KKCMGLKLPIJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LKNBNPHNGLC();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable KCLBMOAKFIK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GJIMIMGDKLP(CIFBNNGALCD HIFOLPKANOJ, KECCLNDCEEL LOKMNAHLNNL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> HMGNPPINOPG(OGHNMHNJHKD IFOIKAOPFOA, CancellationToken JLIEBAENBAG, GPNAMOIINIG AEKLGCBMNDP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PJHOOENALNG(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<GKLDPEEJFFM> NCJKANKJAIN(long FAFDJINDEIN, long KJHHBFLPCIE, string LKJJAKMJOKN, KIJPPJFGKMD.IPOCMMCCJIG MJGIEGEMGND, KIJPPJFGKMD.IPOCMMCCJIG CBPEMPBPFMO, IReadOnlyDictionary<long, int> MBHDBPLGEOJ, int PAHKOIEFPKG, string JIPPCEBJCEE, bool HLOFGGLEMCB, int FLNFKHJCBNF);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BBPHCEGMHJG> JOCHILJLNDB(string ENKEIPCEPOH, long FAFDJINDEIN, long KJHHBFLPCIE, string LKJJAKMJOKN, KIJPPJFGKMD.IPOCMMCCJIG MJGIEGEMGND, KIJPPJFGKMD.IPOCMMCCJIG CBPEMPBPFMO, int NJHGAFMAJCP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KFMOMBKGPMO> OJLBHCCKJKJ(long FAFDJINDEIN, bool IIJBCOBCCNJ, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FGNOKAFJKLP();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool ADHOLGFOGEA();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GPJCPDDOKLN(IEnumerable<GLABAKABANJ> JLENBOIAMAN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BCAFCFMGPBO(List<GameObject> EDEBIIFHHLL);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float BHCCKDDLONI();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool OGCFJEGEGEJ(string NILDNJGDILH, out Scene FMEDCFLNIMM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> COFLJINONFP(string NILDNJGDILH, LoadSceneMode CKJJAIPDMIM, bool LFOMIKJHJFO, GPNAMOIINIG IDKFKDEHFHM);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void FAIOOKLPNOI();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool KGAEODPBAIF(ByteString FJHIHOOEHJM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PDBOPBFCAHJ(IKMCGNPFENA LOLKINEGLFF);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task JNHIHMPGHIG(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task AGPKMJKGLOC(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OOEGABOKGPI();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable DNPGOOMGMAC();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	MHLOBGAMMHN JBJJJEBAAFG();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MHLOBGAMMHN
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NNOJCKGHKEN(CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ADAPPIHMMEJ(CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KKBKOBCEICH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HashSet<int> MIGHPNOCNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IDisposable HAOCCPNJKGA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3216FF0", Offset = "0x32155F0", VA = "0x183216FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum AGAPOBGBMCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FIFNNJLDKCI
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	IKMCGNPFENA DFOFGMJLPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	KFMOMBKGPMO NPHEONMBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	ANINOEMMMNA OHPHOLNINMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool EOPKGABLMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PAONDHDBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int BKMDGICBJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action JFHPGHOGBCM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> FLJGJIBCODA;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OODFENOBLCI();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.KCNIIIDKLCN> LBHHHCLKKKA();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DMBBBKHHDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(IKMCGNPFENA, ODMCMDMIIOO) NIGGNANAKFO();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LLFBHKMOMLO JGOJJNLNJMM();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ALNDAKOBOGF(long HBFDFDGJDBK);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NEAPKIDJFFE
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPFCAIDDAH(out IEnumerable<int> HEMFAGOEFHD);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLOKPAEGMAJ(MFNIHNNDJBP HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFNGECNCLDE(MFNIHNNDJBP HKLDIENGNNB);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BEMFBJPFGHC
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FHDBPMEJCBA(HNKKGJKFCMD JFMEPDDDBHK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IAJBGEPHNOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAIJJAHEKEF(HIKHHHDNOJG.CBDLOBKPIDJ BEPCBCBFDJJ);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POPJCDNPCIB(HIKHHHDNOJG.CBDLOBKPIDJ BEPCBCBFDJJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OAGFELPGPII : IAJBGEPHNOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKKGJKFCMD ENEDDICAONN(CHIAPKEENBB ONJBJADNFEC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HKJGGEEKHJM : IAJBGEPHNOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKKGJKFCMD GHFIFKNLCJM(CHIAPKEENBB DNGIFCKAEMO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EFFCJBEKFIH
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::IKEELLNFFOM<MAHIAFPEFOP, IHHGNGPIMCG>> EJELGOJKLAI(string LKJJAKMJOKN, long HBFDFDGJDBK, PIFGAANHEEL.NEKFKEKLDFG JELIMPCBNBL, CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MHGMMAFIJAI<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::IKEELLNFFOM<byte[], IHHGNGPIMCG>> HFLBKLNNHLA(TGetDataArg LDLMPCMBDAJ, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::IKEELLNFFOM<global::BNHPJFPNMAO<TData>, IHHGNGPIMCG> JCLCGJOHAEF(byte[] JIHCLPECHIB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class MOEHLOOIIEL : PEHFLLKFGNK, HOKMKHEIMLO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NGNGAAIFDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MOEHLOOIIEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HFFCNJPOHMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4A525C0", Offset = "0x4A50BC0", VA = "0x184A525C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4A527E0", Offset = "0x4A50DE0", VA = "0x184A527E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OJJIGKDPOJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MOEHLOOIIEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4A53430", Offset = "0x4A51A30", VA = "0x184A53430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class PLBMMHBKONE : IEnumerable<CGEHFEJBJEO>, IEnumerable, IEnumerator<CGEHFEJBJEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CGEHFEJBJEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MOEHLOOIIEL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private CGEHFEJBJEO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public PLBMMHBKONE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4A537B0", Offset = "0x4A51DB0", VA = "0x184A537B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4A53BF0", Offset = "0x4A521F0", VA = "0x184A53BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A53B50", Offset = "0x4A52150", VA = "0x184A53B50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGEHFEJBJEO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A53B50", Offset = "0x4A52150", VA = "0x184A53B50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CancellationTokenSource EONGJKAMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PEGEFOEHCCC IGFHDABHNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private JALNAKLBCAF KOJDGFKGKLN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OGHNMHNJHKD OLBPIEBMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x728ED0", Offset = "0x7274D0", VA = "0x180728ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NIGKKDGFDLL IBKDOILBDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x687C20", Offset = "0x686220", VA = "0x180687C20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x728F20", Offset = "0x727520", VA = "0x180728F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x683BB0", Offset = "0x6821B0", VA = "0x180683BB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x817260", Offset = "0x815860", VA = "0x180817260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HOCHNEAIGFA FJNLIOLILEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x753B10", Offset = "0x752110", VA = "0x180753B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OAGFELPGPII HGPKKDHHALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x810210", Offset = "0x80E810", VA = "0x180810210", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83C590", Offset = "0x83AB90", VA = "0x18083C590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HKJGGEEKHJM CKGHAPNPNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83C530", Offset = "0x83AB30", VA = "0x18083C530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PIJBHNICAJC KEKPFIPHEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x792CA0", Offset = "0x7912A0", VA = "0x180792CA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x83C500", Offset = "0x83AB00", VA = "0x18083C500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public MLPGADEGBDL FFLGEIIKLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83C540", Offset = "0x83AB40", VA = "0x18083C540", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83C570", Offset = "0x83AB70", VA = "0x18083C570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MDOLGLJHONG LEGPJJFPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8F0", Offset = "0x7E8EF0", VA = "0x1807EA8F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84E450", Offset = "0x84CA50", VA = "0x18084E450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public IBNAFNKCHDM APKKNJBDCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x822190", Offset = "0x820790", VA = "0x180822190", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8FD980", Offset = "0x8FBF80", VA = "0x1808FD980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OAMNBHJNBHE IIFMPCOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x744A80", Offset = "0x743080", VA = "0x180744A80", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x744B40", Offset = "0x743140", VA = "0x180744B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EEFBLDDCJPC BFMCKPMMEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x810220", Offset = "0x80E820", VA = "0x180810220", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCC0", Offset = "0x8DE2C0", VA = "0x1808DFCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JFAJDMKDCOE PJMKCLLIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x739C50", Offset = "0x738250", VA = "0x180739C50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x739EB0", Offset = "0x7384B0", VA = "0x180739EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NJBDEIJJCHN PJKDJCIFCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x739D10", Offset = "0x738310", VA = "0x180739D10", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x739EC0", Offset = "0x7384C0", VA = "0x180739EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JAGDIAEJBJB PFHOIECNPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x739BD0", Offset = "0x7381D0", VA = "0x180739BD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x739EA0", Offset = "0x7384A0", VA = "0x180739EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OKAJJGOMDFM OHGKFPEGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x74FC30", Offset = "0x74E230", VA = "0x18074FC30", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x74FC80", Offset = "0x74E280", VA = "0x18074FC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public FPNGPNBBLMK CLPNHBILHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x828910", Offset = "0x826F10", VA = "0x180828910", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x828940", Offset = "0x826F40", VA = "0x180828940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public EENNCCEAIML HFILPCEIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x751D60", Offset = "0x750360", VA = "0x180751D60", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x752220", Offset = "0x750820", VA = "0x180752220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public FHHMNEGALCE NOKBNBHOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x68C470", Offset = "0x68AA70", VA = "0x18068C470", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x752380", Offset = "0x750980", VA = "0x180752380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public PGNCBAOABOL INPOOKAJIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x771860", Offset = "0x76FE60", VA = "0x180771860", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x773210", Offset = "0x771810", VA = "0x180773210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CKCOMBPMAKH BHHNGPHDCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x751070", Offset = "0x74F670", VA = "0x180751070", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB0F970", Offset = "0xB0DF70", VA = "0x180B0F970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MDMPGKEIFFB BGNCMMJOLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x751D40", Offset = "0x750340", VA = "0x180751D40", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x794500", Offset = "0x792B00", VA = "0x180794500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FHDFGKAINFA NHEGCEBOPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x751D50", Offset = "0x750350", VA = "0x180751D50", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x752210", Offset = "0x750810", VA = "0x180752210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NEAPKIDJFFE DMEJDNLCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7944F0", Offset = "0x792AF0", VA = "0x1807944F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x794510", Offset = "0x792B10", VA = "0x180794510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BGCIDMJMEGI IIEBMLOHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x770E70", Offset = "0x76F470", VA = "0x180770E70", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x752360", Offset = "0x750960", VA = "0x180752360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public HCBPJJNGDOO PAPBJDDAHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7981B0", Offset = "0x7967B0", VA = "0x1807981B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7981D0", Offset = "0x7967D0", VA = "0x1807981D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public HJKDDIICHFK KELIINMBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7981C0", Offset = "0x7967C0", VA = "0x1807981C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7981E0", Offset = "0x7967E0", VA = "0x1807981E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EODLIBFMCBK OIAJILFDLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79D0A0", Offset = "0x79B6A0", VA = "0x18079D0A0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ODMCMDMIIOO OPIOIDKGEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB05050", Offset = "0xB03650", VA = "0x180B05050", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xB0F950", Offset = "0xB0DF50", VA = "0x180B0F950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool NLLEDBJMENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C7E0", Offset = "0x3D1ADE0", VA = "0x183D1C7E0", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool GGJEMMIFODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CAD0", Offset = "0x3D1B0D0", VA = "0x183D1CAD0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task IKCJMKOGGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D040", Offset = "0x3D1B640", VA = "0x183D1D040", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken GMCGLALIPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D170", Offset = "0x3D1B770", VA = "0x183D1D170", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private PEGEFOEHCCC MEBNFKGLKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action DFFLKCLNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CA10", Offset = "0x3D1B010", VA = "0x183D1CA10", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CA70", Offset = "0x3D1B070", VA = "0x183D1CA70", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event IFHKCGHMLAK CAKMMFEIKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CF80", Offset = "0x3D1B580", VA = "0x183D1CF80", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D190", Offset = "0x3D1B790", VA = "0x183D1D190", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event IFHKCGHMLAK GFLFJMFEIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CDE0", Offset = "0x3D1B3E0", VA = "0x183D1CDE0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D250", Offset = "0x3D1B850", VA = "0x183D1D250", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event IFHKCGHMLAK KDACBPBBFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CFE0", Offset = "0x3D1B5E0", VA = "0x183D1CFE0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D1F0", Offset = "0x3D1B7F0", VA = "0x183D1D1F0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<OHIGMNLGPGF, bool> IAEBAEKJLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C9B0", Offset = "0x3D1AFB0", VA = "0x183D1C9B0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D090", Offset = "0x3D1B690", VA = "0x183D1D090", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xB0F950", Offset = "0xB0DF50", VA = "0x180B0F950", Slot = "34")]
	public void DBNNBALOAPC(ODMCMDMIIOO BGKAMDHDGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D4C0", Offset = "0x3D1BAC0", VA = "0x183D1D4C0")]
	[Preserve]
	internal MOEHLOOIIEL([KICKHKJFGOO(null)] PEGEFOEHCCC IGFHDABHNLN, [KICKHKJFGOO(null)] OGHNMHNJHKD IFOIKAOPFOA, [KICKHKJFGOO(null)] NIGKKDGFDLL OJJBBFPFAGD, [KICKHKJFGOO(null)] EEOMMJMOFEO NBJJAAKBODP, [KICKHKJFGOO(null)] HOCHNEAIGFA JCCPKEDACCI, [KICKHKJFGOO(null)] OAGFELPGPII CJAJFCFJGCM, [KICKHKJFGOO(null)] HKJGGEEKHJM LKDBNNCGMAB, [KICKHKJFGOO(null)] PIJBHNICAJC EKNHNIJMEKG, [KICKHKJFGOO(null)] MLPGADEGBDL KAJFELMAAFL, [KICKHKJFGOO(null)] MDOLGLJHONG FNGADFBNFKP, [KICKHKJFGOO(null)] IBNAFNKCHDM GLIGCLJIOHI, [KICKHKJFGOO(null)] OAMNBHJNBHE OFLNLBGHEKD, [KICKHKJFGOO(null)] EEFBLDDCJPC EPHHMAOIAKO, [KICKHKJFGOO(null)] JFAJDMKDCOE BGANBIAOGLC, [KICKHKJFGOO(null)] NJBDEIJJCHN HLPKHFKMEAI, [KICKHKJFGOO(null)] JAGDIAEJBJB JBHGLKHLDAI, [KICKHKJFGOO(null)] OKAJJGOMDFM LDKEPDECAGL, [KICKHKJFGOO(null)] FPNGPNBBLMK LIADCAMGBMN, [KICKHKJFGOO(null)] EENNCCEAIML CFMLFCNEPDK, [KICKHKJFGOO(null)] FHHMNEGALCE KEODHPINPHO, [KICKHKJFGOO(null)] CKCOMBPMAKH NGEFKGPCJNG, [KICKHKJFGOO(null)] PGNCBAOABOL JFFLMHPCKCE, [KICKHKJFGOO(null)] MDMPGKEIFFB FHDIHMMIHDJ, [KICKHKJFGOO(null)] FHDFGKAINFA GPLLGBKKAAL, [KICKHKJFGOO(null)] NEAPKIDJFFE KNBMEIAPFDO, [KICKHKJFGOO(null)] HCBPJJNGDOO PPPBIOFDOMH, [KICKHKJFGOO(null)] HJKDDIICHFK EHPKBIENNGN, [KICKHKJFGOO(null)] EODLIBFMCBK NEKICDPAJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D2B0", Offset = "0x3D1B8B0", VA = "0x183D1D2B0")]
	private void OIEJOMHJJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CB50", Offset = "0x3D1B150", VA = "0x183D1CB50", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CCE0", Offset = "0x3D1B2E0", VA = "0x183D1CCE0", Slot = "48")]
	private void FLKALLKHAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C7F0", Offset = "0x3D1ADF0", VA = "0x183D1C7F0", Slot = "49")]
	private NEPAAGJDNIP CDDNLJNNFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D0F0", Offset = "0x3D1B6F0", VA = "0x183D1D0F0", Slot = "50")]
	private IICKKMOGJNC KPGHFLFFMKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CE40", Offset = "0x3D1B440", VA = "0x183D1CE40", Slot = "51")]
	[AsyncStateMachine(typeof(NGNGAAIFDDC))]
	private Task<HNKKGJKFCMD> IILLLCGIBBJ(HFFCNJPOHMD GBNPJHBLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D3A0", Offset = "0x3D1B9A0", VA = "0x183D1D3A0", Slot = "52")]
	[AsyncStateMachine(typeof(OJJIGKDPOJM))]
	private Task PGCCAOBHAJG(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C940", Offset = "0x3D1AF40", VA = "0x183D1C940")]
	[IteratorStateMachine(typeof(PLBMMHBKONE))]
	private IEnumerable<CGEHFEJBJEO> CFFFJDEEMKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CD30", Offset = "0x3D1B330", VA = "0x183D1CD30")]
	[CompilerGenerated]
	private void HIFMLDDBKCF(CGEHFEJBJEO AALANACCLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class IMANGGHHMOI : GNNGBAGEPDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NANDFLKNMOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IMANGGHHMOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4058830", Offset = "0x4056E30", VA = "0x184058830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4058BB0", Offset = "0x40571B0", VA = "0x184058BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x729000", Offset = "0x727600", VA = "0x180729000")]
	public IMANGGHHMOI(PEHFLLKFGNK GHBIGIEEHOO, EEOMMJMOFEO NBJJAAKBODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3213780", Offset = "0x3211D80", VA = "0x183213780", Slot = "4")]
	[AsyncStateMachine(typeof(NANDFLKNMOE))]
	public Task<bool> MNOCHJKDIFJ(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x32136A0", Offset = "0x3211CA0", VA = "0x1832136A0")]
	[CompilerGenerated]
	private object JDJDHFJOBPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class JBNGAIGLEEG : GNNGBAGEPDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LJLBCGANFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JBNGAIGLEEG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4055F50", Offset = "0x4054550", VA = "0x184055F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4056580", Offset = "0x4054B80", VA = "0x184056580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const float EJLLCPMKINP = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3213AC0", Offset = "0x32120C0", VA = "0x183213AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x729000", Offset = "0x727600", VA = "0x180729000")]
	public JBNGAIGLEEG(PEHFLLKFGNK GHBIGIEEHOO, EEOMMJMOFEO NBJJAAKBODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3213980", Offset = "0x3211F80", VA = "0x183213980", Slot = "4")]
	[AsyncStateMachine(typeof(LJLBCGANFFF))]
	public Task<bool> MNOCHJKDIFJ(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x32138A0", Offset = "0x3211EA0", VA = "0x1832138A0")]
	[CompilerGenerated]
	private object JMFDGIJCJEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class GJMPGIEFMND : GNNGBAGEPDO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HLEIIPKLANN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GJMPGIEFMND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Matchmaking.KCNIIIDKLCN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IKMCGNPFENA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HLEIIPKLANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4050850", Offset = "0x404EE50", VA = "0x184050850")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x40509A0", Offset = "0x404EFA0", VA = "0x1840509A0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4050A10", Offset = "0x404F010", VA = "0x184050A10")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GOHILILOIHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GJMPGIEFMND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private HLEIIPKLANN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Matchmaking.KCNIIIDKLCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x404E360", Offset = "0x404C960", VA = "0x18404E360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x404EC20", Offset = "0x404D220", VA = "0x18404EC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private const float EJLLCPMKINP = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x320BE90", Offset = "0x320A490", VA = "0x18320BE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x729000", Offset = "0x727600", VA = "0x180729000")]
	public GJMPGIEFMND(PEHFLLKFGNK GHBIGIEEHOO, EEOMMJMOFEO NBJJAAKBODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x320BD50", Offset = "0x320A350", VA = "0x18320BD50", Slot = "4")]
	[AsyncStateMachine(typeof(GOHILILOIHN))]
	public Task<bool> MNOCHJKDIFJ(CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface GNNGBAGEPDO
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> MNOCHJKDIFJ(CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct CJPFAAGLEON
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FEHFENFPCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PEHFLLKFGNK manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public FEHFENFPCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D13420", Offset = "0x3D11A20", VA = "0x183D13420")]
		internal Task <CreateTask>b__0(EMLPMBHPMDM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JAKBHNMLOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CJPFAAGLEON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HFFCNJPOHMD <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<AGAPOBGBMCN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D17FF0", Offset = "0x3D165F0", VA = "0x183D17FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D18570", Offset = "0x3D16B70", VA = "0x183D18570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct EDDMFKAACMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CJPFAAGLEON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D12320", Offset = "0x3D10920", VA = "0x183D12320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly CancellationToken JLIEBAENBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly PEHFLLKFGNK HKMONJIHHIH;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private OGHNMHNJHKD OLBPIEBMOON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x32008F0", Offset = "0x31FEEF0", VA = "0x1832008F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32009F0", Offset = "0x31FEFF0", VA = "0x1832009F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3200D20", Offset = "0x31FF320", VA = "0x183200D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private MDOLGLJHONG LEGPJJFPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x32008A0", Offset = "0x31FEEA0", VA = "0x1832008A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3200DA0", Offset = "0x31FF3A0", VA = "0x183200DA0")]
	public CJPFAAGLEON(CancellationToken JLIEBAENBAG, PEHFLLKFGNK HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3200940", Offset = "0x31FEF40", VA = "0x183200940")]
	public static NIOIFMFHOLF KCGPDGHEBKJ(PEHFLLKFGNK HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3200770", Offset = "0x31FED70", VA = "0x183200770")]
	[AsyncStateMachine(typeof(JAKBHNMLOPM))]
	public Task<bool> BABMLJMPJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3200B80", Offset = "0x31FF180", VA = "0x183200B80")]
	private bool PLLFOPEOPIA(out HFFCNJPOHMD GBNPJHBLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3200670", Offset = "0x31FEC70", VA = "0x183200670")]
	[AsyncStateMachine(typeof(EDDMFKAACMP))]
	private Task ANIFFNOPGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3200A40", Offset = "0x31FF040", VA = "0x183200A40")]
	private Task<AGAPOBGBMCN> PAPAPDFJFBI(HFFCNJPOHMD IJHLBGFLJEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct NILFOALGDBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly NJBDEIJJCHN HLPKHFKMEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Guid KAOFPCAFLFA;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(HNKKGJKFCMD, Task)> CLJHHEAMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EC80", Offset = "0x3D1D280", VA = "0x183D1EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xD92800", Offset = "0xD90E00", VA = "0x180D92800")]
	public NILFOALGDBC(NJBDEIJJCHN HLPKHFKMEAI, Guid KAOFPCAFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D1ED50", Offset = "0x3D1D350", VA = "0x183D1ED50")]
	public TaskAwaiter<(HNKKGJKFCMD, Task)> JCJMPGLOIAH()
	{
		return default(TaskAwaiter<(HNKKGJKFCMD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D1EBB0", Offset = "0x3D1D1B0", VA = "0x183D1EBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct GKKKILHAGDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TaskCompletionSource<(HNKKGJKFCMD, Task)> KFGNHOILAHO;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(HNKKGJKFCMD, Task)> CLJHHEAMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x320C0A0", Offset = "0x320A6A0", VA = "0x18320C0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x320C170", Offset = "0x320A770", VA = "0x18320C170")]
	public GKKKILHAGDE(TimeSpan DKOGNBKHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x320BF70", Offset = "0x320A570", VA = "0x18320BF70")]
	public void DGPHBJEMKOG(Task JNFJEAGEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x320C0E0", Offset = "0x320A6E0", VA = "0x18320C0E0")]
	public void INHIAHGBNAD(HNKKGJKFCMD JFMEPDDDBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x320C050", Offset = "0x320A650", VA = "0x18320C050")]
	public void GIIGOLNNMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x320BEE0", Offset = "0x320A4E0", VA = "0x18320BEE0")]
	internal void DCECNNBNNKE(string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BMHNEKNOEOP
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LIFMEAHBIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LIFMEAHBIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C8D050", Offset = "0x1C8B650", VA = "0x181C8D050")]
		internal bool <Create>b__0(ANINOEMMMNA subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x31FFA00", Offset = "0x31FE000", VA = "0x1831FFA00")]
	public static ELFALKJEDMF CBFHJGEFJHE(long AMKAIGLCPLL, long KJHHBFLPCIE, LLGMLEHJMCJ NPBGCOOPEJO, string LKJJAKMJOKN, LLGMLEHJMCJ CBPEMPBPFMO, string ENKEIPCEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x31FF670", Offset = "0x31FDC70", VA = "0x1831FF670")]
	public static ELFALKJEDMF CBFHJGEFJHE(KFMOMBKGPMO MPLAFJFJPAD, ELBFJLGDNOH PAMPGOKPJNM, [Optional] string ENKEIPCEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x31FF7E0", Offset = "0x31FDDE0", VA = "0x1831FF7E0")]
	public static ELFALKJEDMF CBFHJGEFJHE(KFMOMBKGPMO MPLAFJFJPAD, long KJHHBFLPCIE, [Optional] string ENKEIPCEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x31FFB40", Offset = "0x31FE140", VA = "0x1831FFB40")]
	public static ELFALKJEDMF IGPLJAMKCLI(this ELFALKJEDMF GOMBJHKPMMM, KFMOMBKGPMO BDEHAGFBJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x31FFC40", Offset = "0x31FE240", VA = "0x1831FFC40")]
	public static ELFALKJEDMF OGKAJGCMACL(this ELFALKJEDMF GOMBJHKPMMM, ELBFJLGDNOH OGNDGNICIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x31FFD20", Offset = "0x31FE320", VA = "0x1831FFD20")]
	public static ELFALKJEDMF OGKAJGCMACL(this ELFALKJEDMF GOMBJHKPMMM, ANINOEMMMNA JIBODGEEKJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Preserve]
internal class KLJMENIAJAA : MLPGADEGBDL, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct NMPMCMKGAFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public KLJMENIAJAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4059590", Offset = "0x4057B90", VA = "0x184059590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly MFNIHNNDJBP NEDPEGBPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string KLDAPJLOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Task LJLMPKHECDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool IDBIOBPCEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3217EF0", Offset = "0x32164F0", VA = "0x183217EF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task KIMPFMJLJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3217F20", Offset = "0x3216520", VA = "0x183217F20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760", Slot = "7")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3217D70", Offset = "0x3216370", VA = "0x183217D70", Slot = "6")]
	public void JKGDJHLICNC(Task LMDFEBFDNDF, string BMEAMINLEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3217C40", Offset = "0x3216240", VA = "0x183217C40")]
	[AsyncStateMachine(typeof(NMPMCMKGAFC))]
	private Task JGNNPLCECGL(Task ADAOAEJANGC, string BMEAMINLEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3217F80", Offset = "0x3216580", VA = "0x183217F80")]
	public KLJMENIAJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class AMEANDLKFFE : BGCIDMJMEGI, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool LDLAFDEEDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private KOANDAEHODA EGCFEGFGMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HCBPJJNGDOO PPPBIOFDOMH;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KOANDAEHODA OPPJHNHJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x31FC690", Offset = "0x31FAC90", VA = "0x1831FC690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x31FC8C0", Offset = "0x31FAEC0", VA = "0x1831FC8C0", Slot = "7")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x31FC700", Offset = "0x31FAD00", VA = "0x1831FC700", Slot = "5")]
	public void HJLIENMMMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x31FC650", Offset = "0x31FAC50", VA = "0x1831FC650", Slot = "6")]
	public void OBLPAJBCECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x31FC5D0", Offset = "0x31FABD0", VA = "0x1831FC5D0")]
	private Task CBPAMADJIBF(AJGANPCLNAO IBHBGBEBHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x31FC650", Offset = "0x31FAC50", VA = "0x1831FC650", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AMEANDLKFFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class LJNJAPAPNNC : HCBPJJNGDOO
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class OBLNHADLNDP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly BPECMPIIKOJ BIPPPLGHCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly string AIGAKEKDKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly T BKMGNMEJDHA;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T OIHHNPGGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F09C0", Offset = "0x7EEFC0", VA = "0x1807F09C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3812010", Offset = "0x3810610", VA = "0x183812010")]
		public OBLNHADLNDP(BPECMPIIKOJ BIPPPLGHCGI, string AIGAKEKDKHM, T BKMGNMEJDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3811C10", Offset = "0x3810210", VA = "0x183811C10")]
		private void MKAMCHEAHME()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly OBLNHADLNDP<TimeSpan> MAAMFPHPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly OBLNHADLNDP<TimeSpan> KGMMBCBGJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly OBLNHADLNDP<TimeSpan> NOCBONNEMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly OBLNHADLNDP<TimeSpan> ILJFLNCJBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OBLNHADLNDP<bool> IBCGIBOEBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly OBLNHADLNDP<bool> KHKCOJMCCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly OBLNHADLNDP<bool> PLODGJMGFDD;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan BEAFIBBFNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3218ED0", Offset = "0x32174D0", VA = "0x183218ED0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan CPBDKMELPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3218F90", Offset = "0x3217590", VA = "0x183218F90", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan FGPDPAFOIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3218FD0", Offset = "0x32175D0", VA = "0x183218FD0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan JEJNKDPGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3218E50", Offset = "0x3217450", VA = "0x183218E50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool NDLNHHEHNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3218F50", Offset = "0x3217550", VA = "0x183218F50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool IEINDJHEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3218F10", Offset = "0x3217510", VA = "0x183218F10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool MCJDEAICHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3218E90", Offset = "0x3217490", VA = "0x183218E90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3219010", Offset = "0x3217610", VA = "0x183219010")]
	[Preserve]
	public LJNJAPAPNNC([KICKHKJFGOO(null)] BPECMPIIKOJ BIPPPLGHCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class CPMAHMCCPPN : IBNAFNKCHDM, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GDONMMDMHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public OGHDDJALHCM roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GDONMMDMHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3D14340", Offset = "0x3D12940", VA = "0x183D14340")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action MBKGOAOOIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3201DF0", Offset = "0x32003F0", VA = "0x183201DF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3201FD0", Offset = "0x32005D0", VA = "0x183201FD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event IFHKCGHMLAK ONACJMNPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3202170", Offset = "0x3200770", VA = "0x183202170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x32015D0", Offset = "0x31FFBD0", VA = "0x1832015D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event IFHKCGHMLAK LCACNODCCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3201F30", Offset = "0x3200530", VA = "0x183201F30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x32020A0", Offset = "0x32006A0", VA = "0x1832020A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event IFHKCGHMLAK PCDPPPJIFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3201970", Offset = "0x31FFF70", VA = "0x183201970", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3201A10", Offset = "0x3200010", VA = "0x183201A10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<OHIGMNLGPGF, bool> NHCGLCCAMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3201E90", Offset = "0x3200490", VA = "0x183201E90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3201D20", Offset = "0x3200320", VA = "0x183201D20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "19")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3201AB0", Offset = "0x32000B0", VA = "0x183201AB0", Slot = "14")]
	public void DOADFNAJANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3202070", Offset = "0x3200670", VA = "0x183202070", Slot = "15")]
	public void LIPFLEFBHDL(OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3201DC0", Offset = "0x32003C0", VA = "0x183201DC0", Slot = "16")]
	public void HGGCOEJGFNP(OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3202140", Offset = "0x3200740", VA = "0x183202140", Slot = "17")]
	public void NAKMCNLLJDE(OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x32018C0", Offset = "0x31FFEC0", VA = "0x1832018C0", Slot = "18")]
	public void CDHHGMDCLBH(OHIGMNLGPGF DMPLKKLCBGL, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3201670", Offset = "0x31FFC70", VA = "0x183201670")]
	private void BOKGNJCLLJG(IFHKCGHMLAK APONMHBMIIF, OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CPMAHMCCPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class BEOPBIIIPGI : OAMNBHJNBHE, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct GEKFIDKHOKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BEOPBIIIPGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3D14440", Offset = "0x3D12A40", VA = "0x183D14440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct BJPIKGNCNLL : IAsyncStateMachine
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
		public BEOPBIIIPGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FA10", Offset = "0x3D0E010", VA = "0x183D0FA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class AOBBGGJGONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AOBBGGJGONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F7D0", Offset = "0x3D0DDD0", VA = "0x183D0F7D0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct OELJHILODNC : IAsyncStateMachine
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
		public BEOPBIIIPGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private AOBBGGJGONJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F9C0", Offset = "0x3D1DFC0", VA = "0x183D1F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FF50", Offset = "0x3D1E550", VA = "0x183D1FF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GFBLAMOBFOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GFBLAMOBFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3D14840", Offset = "0x3D12E40", VA = "0x183D14840")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private GNNGBAGEPDO[] EFOAPOAMBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CancellationTokenSource MFPMCEFBCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int IJOMADBCGDN;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x31FE540", Offset = "0x31FCB40", VA = "0x1831FE540", Slot = "7")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x31FDBB0", Offset = "0x31FC1B0", VA = "0x1831FDBB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x31FD750", Offset = "0x31FBD50", VA = "0x1831FD750", Slot = "6")]
	public void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x31FDE20", Offset = "0x31FC420", VA = "0x1831FDE20", Slot = "5")]
	public void JCELCOHOLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x31FE2D0", Offset = "0x31FC8D0", VA = "0x1831FE2D0", Slot = "4")]
	[AsyncStateMachine(typeof(GEKFIDKHOKE))]
	public Task KCBJNPHNIKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x31FDF70", Offset = "0x31FC570", VA = "0x1831FDF70")]
	private void JFEKDMGDKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x31FD620", Offset = "0x31FBC20", VA = "0x1831FD620")]
	[AsyncStateMachine(typeof(BJPIKGNCNLL))]
	private Task BKEKGCNJFHM(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x31FDBC0", Offset = "0x31FC1C0", VA = "0x1831FDBC0")]
	[AsyncStateMachine(typeof(OELJHILODNC))]
	private Task<bool> FGMFELJFEGL(int EBBLFLFCHFB, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x31FE3E0", Offset = "0x31FC9E0", VA = "0x1831FE3E0")]
	private void KFEANHNBFMG(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x31FDA70", Offset = "0x31FC070", VA = "0x1831FDA70")]
	private void DCKCGKIIBIM(int EBBLFLFCHFB, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x31FD8C0", Offset = "0x31FBEC0", VA = "0x1831FD8C0")]
	private void CMABOBEMIEJ(int EBBLFLFCHFB, Exception PEAJABIJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x31FDD10", Offset = "0x31FC310", VA = "0x1831FDD10")]
	private void GLCBHDLENJH(CancellationToken JLIEBAENBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BEOPBIIIPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal class DDKBMPOJOKN : JFAJDMKDCOE, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct ENHBEEAAPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DDKBMPOJOKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public EMLPMBHPMDM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D12FE0", Offset = "0x3D115E0", VA = "0x183D12FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GFLCPGKFHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DDKBMPOJOKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public EMLPMBHPMDM roomData;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GFLCPGKFHKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D148B0", Offset = "0x3D12EB0", VA = "0x183D148B0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct IMAHJPKAGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NIOIFMFHOLF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D15DF0", Offset = "0x3D143F0", VA = "0x183D15DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NLBGCECNOGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DDKBMPOJOKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F1D0", Offset = "0x3D1D7D0", VA = "0x183D1F1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HashSet<NIOIFMFHOLF> IPDEAPJKFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NIGKKDGFDLL OJJBBFPFAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private FBDDBGAPPNK LLAOFGDLEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GIBKHNIFIMJ PMLMFABPAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IDisposable PCBEEJKAAOD;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool BJOBNPKHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3203480", Offset = "0x3201A80", VA = "0x183203480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task CLJHHEAMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3202B70", Offset = "0x3201170", VA = "0x183202B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x32031E0", Offset = "0x32017E0", VA = "0x1832031E0", Slot = "6")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3202650", Offset = "0x3200C50", VA = "0x183202650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x32034B0", Offset = "0x3201AB0", VA = "0x1832034B0", Slot = "5")]
	public bool OOEKKDDJOLB(NIOIFMFHOLF EJHGEIFEGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3202210", Offset = "0x3200810", VA = "0x183202210")]
	private void ADJFFIMBCPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x32028F0", Offset = "0x3200EF0", VA = "0x1832028F0")]
	private void GCDJJFEJCIL(EMLPMBHPMDM MJGIEGEMGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x32027D0", Offset = "0x3200DD0", VA = "0x1832027D0")]
	[AsyncStateMachine(typeof(ENHBEEAAPNA))]
	private Task FJJJLBHCEOG(EMLPMBHPMDM MJGIEGEMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3202450", Offset = "0x3200A50", VA = "0x183202450")]
	private Func<CancellationToken, List<Task>> ADOFKIAONKA(EMLPMBHPMDM MJGIEGEMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3202CB0", Offset = "0x32012B0", VA = "0x183202CB0")]
	private List<Task> OFMNILBCEKN(EMLPMBHPMDM MJGIEGEMGND, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3202B80", Offset = "0x3201180", VA = "0x183202B80")]
	[AsyncStateMachine(typeof(IMAHJPKAGIL))]
	private Task JPDILOABMFG(NIOIFMFHOLF HNGFGENHHCF, EMLPMBHPMDM JIHCLPECHIB, CancellationToken HKLDIENGNNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x32026D0", Offset = "0x3200CD0", VA = "0x1832026D0")]
	[AsyncStateMachine(typeof(NLBGCECNOGH))]
	private Task EHJOPBHKKML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3202530", Offset = "0x3200B30", VA = "0x183202530")]
	private void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3203510", Offset = "0x3201B10", VA = "0x183203510")]
	public DDKBMPOJOKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal class LOAMGJJJKAF : EEFBLDDCJPC, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CBNLIDBDNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ODMCMDMIIOO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x40481C0", Offset = "0x40467C0", VA = "0x1840481C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HGBEJMIGEPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ODMCMDMIIOO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private global::IMNAINPHIAI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private GMCFJEBBKEC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private LCNCEEKMFHL <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x404FBB0", Offset = "0x404E1B0", VA = "0x18404FBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class IPBNGOLJKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task<ELFALKJEDMF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IPBNGOLJKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		internal Task<ELFALKJEDMF> <ConnectToRoomAndRunLoadLogic>b__0(GPNAMOIINIG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct INLHBMFEEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ODMCMDMIIOO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public GMCFJEBBKEC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private IPBNGOLJKPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private MNFBCLMGCPE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private GPNAMOIINIG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private IKHDPONDBON <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<ELFALKJEDMF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x40518C0", Offset = "0x404FEC0", VA = "0x1840518C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct DNMLBKLBGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private GPNAMOIINIG <disconnectTimerScope>5__3;

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
		private GPNAMOIINIG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x404A830", Offset = "0x4048E30", VA = "0x18404A830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct KIMKNMHIELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private PEGEFOEHCCC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x4A50320", Offset = "0x4A4E920", VA = "0x184A50320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IDCKCKGAPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GMCFJEBBKEC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private GPNAMOIINIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<BEBGGGBLJGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x4050B10", Offset = "0x404F110", VA = "0x184050B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class MIOPFKPIFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public IKMCGNPFENA targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MIOPFKPIFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x4A514D0", Offset = "0x4A4FAD0", VA = "0x184A514D0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x4A513D0", Offset = "0x4A4F9D0", VA = "0x184A513D0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct DKHNPBCLMGI : IAsyncStateMachine
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
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MIOPFKPIFGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x4049CE0", Offset = "0x40482E0", VA = "0x184049CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct JAGCAPBAKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GMCFJEBBKEC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ELFALKJEDMF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public IKMCGNPFENA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MNFBCLMGCPE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private GPNAMOIINIG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F6E0", Offset = "0x4A4DCE0", VA = "0x184A4F6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct JLNBKEBPGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private GPNAMOIINIG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4A4FC50", Offset = "0x4A4E250", VA = "0x184A4FC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PNLJABPLADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4A53C30", Offset = "0x4A52230", VA = "0x184A53C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct EPNNMGIOMIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x404BD90", Offset = "0x404A390", VA = "0x18404BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct FPJGAFCHEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x404C500", Offset = "0x404AB00", VA = "0x18404C500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct HCHKHEBFPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public LOAMGJJJKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x404F070", Offset = "0x404D670", VA = "0x18404F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class HDCGCKCDMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HDCGCKCDMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x404F360", Offset = "0x404D960", VA = "0x18404F360")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class NNEJFJPJEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public NNEJFJPJEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x4A52E60", Offset = "0x4A51460", VA = "0x184A52E60")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class ADMHLGJGAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ADMHLGJGAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x4045CB0", Offset = "0x40442B0", VA = "0x184045CB0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class NBAGAMBPGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public NBAGAMBPGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x4A52070", Offset = "0x4A50670", VA = "0x184A52070")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly string NIFHEDMIOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly string IDCEJPIDAIG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string ILHBGEIAMHN;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly Guid KIODHLNFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private PIJBHNICAJC EKNHNIJMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NIGKKDGFDLL OJJBBFPFAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private OAMNBHJNBHE OFLNLBGHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private MLPGADEGBDL KAJFELMAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IBNAFNKCHDM GLIGCLJIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private HCBPJJNGDOO PPPBIOFDOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IDisposable PCBEEJKAAOD;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus IOHDOKKAONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xD5FE20", Offset = "0xD5E420", VA = "0x180D5FE20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x12D9F60", Offset = "0x12D8560", VA = "0x1812D9F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x321CF50", Offset = "0x321B550", VA = "0x18321CF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x321CB00", Offset = "0x321B100", VA = "0x18321CB00", Slot = "6")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x321ADA0", Offset = "0x32193A0", VA = "0x18321ADA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x321BE10", Offset = "0x321A410", VA = "0x18321BE10", Slot = "5")]
	[AsyncStateMachine(typeof(CBNLIDBDNCJ))]
	public Task JMOLMIIDBFI(IKMCGNPFENA AGOPKDGGMFM, ODMCMDMIIOO IAFHLBMFEAK, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x321AC40", Offset = "0x3219240", VA = "0x18321AC40")]
	[AsyncStateMachine(typeof(HGBEJMIGEPF))]
	private Task DLHAJJGIPIG(IKMCGNPFENA AGOPKDGGMFM, ODMCMDMIIOO IAFHLBMFEAK, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3219C20", Offset = "0x3218220", VA = "0x183219C20")]
	private static void BLNCPBEOKEB(IKMCGNPFENA AGOPKDGGMFM, Exception PEAJABIJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x321A160", Offset = "0x3218760", VA = "0x18321A160")]
	private static void CMCHMBCPLOC(LCNCEEKMFHL DOEFOANMJCN, Exception PEAJABIJNDI, [Optional] List<int> CEJAEDPNLCK, int IJOMADBCGDN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3219AA0", Offset = "0x32180A0", VA = "0x183219AA0")]
	[AsyncStateMachine(typeof(INLHBMFEEPE))]
	private Task BEPOCCCKCNN(GPNAMOIINIG IDKFKDEHFHM, IKMCGNPFENA AGOPKDGGMFM, ODMCMDMIIOO IAFHLBMFEAK, GMCFJEBBKEC MOCABAPGDPH, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x321C4A0", Offset = "0x321AAA0", VA = "0x18321C4A0")]
	private void MGDKOLJGLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3219DE0", Offset = "0x32183E0", VA = "0x183219DE0")]
	[AsyncStateMachine(typeof(DNMLBKLBGAP))]
	private Task BMMMHOIODJC(GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x321ADF0", Offset = "0x32193F0", VA = "0x18321ADF0")]
	private void EBOKGEFMCJM(IKMCGNPFENA AGOPKDGGMFM, CancellationToken CGNPIKGMLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x321B310", Offset = "0x3219910", VA = "0x18321B310")]
	private void EMJAJDEJMFN(IKMCGNPFENA AGOPKDGGMFM, GMCFJEBBKEC MOCABAPGDPH, OperationCanceledException BOAOAJCIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x321BF60", Offset = "0x321A560", VA = "0x18321BF60")]
	private void JONMJALMHGD(IKMCGNPFENA AGOPKDGGMFM, GMCFJEBBKEC MOCABAPGDPH, Exception PEAJABIJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x321BA10", Offset = "0x321A010", VA = "0x18321BA10")]
	private void INMLLPHENNB(IKMCGNPFENA AGOPKDGGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x321B790", Offset = "0x3219D90", VA = "0x18321B790")]
	private static OGHDDJALHCM FMPEFEDFKLD(IKMCGNPFENA AGOPKDGGMFM)
	{
		return default(OGHDDJALHCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3219F20", Offset = "0x3218520", VA = "0x183219F20")]
	[AsyncStateMachine(typeof(KIMKNMHIELD))]
	private Task CAGCHFIKNDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x321CEA0", Offset = "0x321B4A0", VA = "0x18321CEA0")]
	private static BEBGGGBLJGK PBALJFJKFDM(IKMCGNPFENA AGOPKDGGMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x321BCA0", Offset = "0x321A2A0", VA = "0x18321BCA0")]
	[AsyncStateMachine(typeof(IDCKCKGAPMA))]
	private Task JMGNEBEEPKD(IKMCGNPFENA AGOPKDGGMFM, GMCFJEBBKEC MOCABAPGDPH, GPNAMOIINIG IDKFKDEHFHM, CancellationToken FMLAIOLNLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x321CFA0", Offset = "0x321B5A0", VA = "0x18321CFA0")]
	[AsyncStateMachine(typeof(DKHNPBCLMGI))]
	private Task PNLKNEGLDKH(IKMCGNPFENA AGOPKDGGMFM, CancellationTokenSource DHAPPBJBCFJ, Task NKMMMHECIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x321C970", Offset = "0x321AF70", VA = "0x18321C970")]
	[AsyncStateMachine(typeof(JAGCAPBAKIH))]
	private Task ODOHDHAMGNK(ELFALKJEDMF CLPJELHABFF, MNFBCLMGCPE FMFPLOJMGJM, IKMCGNPFENA FDEKHGENEAA, GMCFJEBBKEC JIGNNEOAMIA, GPNAMOIINIG IDKFKDEHFHM, CancellationToken MPECOCEIHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x321C730", Offset = "0x321AD30", VA = "0x18321C730")]
	private GMCFJEBBKEC NPGDEDNOBKF(GMCFJEBBKEC JIGNNEOAMIA, ref CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x321C5F0", Offset = "0x321ABF0", VA = "0x18321C5F0")]
	[AsyncStateMachine(typeof(JLNBKEBPGBM))]
	private Task NPEENGILPPO(GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3219970", Offset = "0x3217F70", VA = "0x183219970")]
	[AsyncStateMachine(typeof(PNLJABPLADC))]
	private Task BEAJEGHAJND(GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x32196C0", Offset = "0x3217CC0", VA = "0x1832196C0")]
	[AsyncStateMachine(typeof(EPNNMGIOMIL))]
	private Task AIIIGNNHLOF(GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x321B140", Offset = "0x3219740", VA = "0x18321B140")]
	[AsyncStateMachine(typeof(FPJGAFCHEAF))]
	private Task EDJJFPELFBP(EMLPMBHPMDM JIHCLPECHIB, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x321A020", Offset = "0x3218620", VA = "0x18321A020")]
	[AsyncStateMachine(typeof(HCHKHEBFPGI))]
	private Task CMCDHEILKGH(GPNAMOIINIG AEKLGCBMNDP, CancellationToken FMLAIOLNLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3219800", Offset = "0x3217E00", VA = "0x183219800")]
	private static void AOOPDJAOJEK(IKMCGNPFENA AGOPKDGGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x321B5C0", Offset = "0x3219BC0", VA = "0x18321B5C0")]
	private void FMAHELFAPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x321C380", Offset = "0x321A980", VA = "0x18321C380")]
	private void KOFKGPAOHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x321B280", Offset = "0x3219880", VA = "0x18321B280")]
	private void EJMHAJNIGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x321C410", Offset = "0x321AA10", VA = "0x18321C410")]
	private void LHIBIHOCCPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x321C210", Offset = "0x321A810", VA = "0x18321C210")]
	private static void KJILEOCEECK(IKMCGNPFENA AGOPKDGGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x321B7D0", Offset = "0x3219DD0", VA = "0x18321B7D0")]
	private static void GLLOGAMHEMG(IKMCGNPFENA AGOPKDGGMFM, CancellationToken FMLAIOLNLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x321B890", Offset = "0x3219E90", VA = "0x18321B890")]
	private static void HFPPIEMBEEJ(IKMCGNPFENA AGOPKDGGMFM, Exception PEAJABIJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x321A9A0", Offset = "0x3218FA0", VA = "0x18321A9A0")]
	private void DGKMLKNMNMP(IKMCGNPFENA AGOPKDGGMFM, Task NKMMMHECIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x32195E0", Offset = "0x3217BE0", VA = "0x1832195E0")]
	private static void AECLFKCPDDB(Func<string> MLGGMMOFMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x321D1F0", Offset = "0x321B7F0", VA = "0x18321D1F0")]
	public LOAMGJJJKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class AGHNMMKGAEG : NJBDEIJJCHN, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class JCOMJGDICLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JCOMJGDICLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3D18DD0", Offset = "0x3D173D0", VA = "0x183D18DD0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class OBCLNDHHNLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OBCLNDHHNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F580", Offset = "0x3D1DB80", VA = "0x183D1F580")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class CPOOKLCIPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public CPOOKLCIPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D10A20", Offset = "0x3D0F020", VA = "0x183D10A20")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class IHMMLPGNKIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IHMMLPGNKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D15C10", Offset = "0x3D14210", VA = "0x183D15C10")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MHFLINGFBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MHFLINGFBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BDF0", Offset = "0x3D1A3F0", VA = "0x183D1BDF0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<Guid, GKKKILHAGDE> HLPKHFKMEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly TimeSpan IHFOOBLNFPH;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x31F97B0", Offset = "0x31F7DB0", VA = "0x1831F97B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x31F9D10", Offset = "0x31F8310", VA = "0x1831F9D10", Slot = "4")]
	public NILFOALGDBC MFMCNFFMIAP(Guid KAOFPCAFLFA)
	{
		return default(NILFOALGDBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x31F97C0", Offset = "0x31F7DC0", VA = "0x1831F97C0", Slot = "5")]
	public bool EMIFMEAGDDE(Guid KAOFPCAFLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x31F9280", Offset = "0x31F7880", VA = "0x1831F9280", Slot = "8")]
	public bool BMOABCGDMKJ(Guid KAOFPCAFLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x31F8EC0", Offset = "0x31F74C0", VA = "0x1831F8EC0", Slot = "6")]
	public bool AINOHCMFOKK(Guid KAOFPCAFLFA, Task JNFJEAGEAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x31F94F0", Offset = "0x31F7AF0", VA = "0x1831F94F0", Slot = "7")]
	public bool CFKBAIMEICD(Guid KAOFPCAFLFA, HNKKGJKFCMD JFMEPDDDBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x31F9FA0", Offset = "0x31F85A0", VA = "0x1831F9FA0", Slot = "9")]
	public Task<(HNKKGJKFCMD, Task)> PENGIOKPMOF(Guid KAOFPCAFLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x31F9A70", Offset = "0x31F8070", VA = "0x1831F9A70")]
	private void HLPCGNOALIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x31FA030", Offset = "0x31F8630", VA = "0x1831FA030")]
	public AGHNMMKGAEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal class GBKCLHPDCFF : JAGDIAEJBJB, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class LOBIGFHEGFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private readonly IKMCGNPFENA LOLKINEGLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private readonly CancellationTokenSource MFPMCEFBCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly CancellationToken DLKOFKGAKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool NDGAOAEHDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool GLPBIJFMILI;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x40567C0", Offset = "0x4054DC0", VA = "0x1840567C0")]
		public LOBIGFHEGFH(IKMCGNPFENA LOLKINEGLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x4056640", Offset = "0x4054C40", VA = "0x184056640")]
		public void BMOABCGDMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x4056790", Offset = "0x4054D90", VA = "0x184056790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class NDLOLJKNMMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AJGANPCLNAO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public NDLOLJKNMMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x40591A0", Offset = "0x40577A0", VA = "0x1840591A0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct HBKAJILHCPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public AJGANPCLNAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public GBKCLHPDCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x404ECE0", Offset = "0x404D2E0", VA = "0x18404ECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class PCJELJLHKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PCJELJLHKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x405B040", Offset = "0x4059640", VA = "0x18405B040")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct GBOHCIIFBFD : IAsyncStateMachine
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
		public GBKCLHPDCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x404CC10", Offset = "0x404B210", VA = "0x18404CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x85BDA0", Offset = "0x85A3A0", VA = "0x18085BDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class PIODPDPLDDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public IKMCGNPFENA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PIODPDPLDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x405B0B0", Offset = "0x40596B0", VA = "0x18405B0B0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x405B150", Offset = "0x4059750", VA = "0x18405B150")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x405B190", Offset = "0x4059790", VA = "0x18405B190")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class AGKJPPBIJIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AGKJPPBIJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4046D70", Offset = "0x4045370", VA = "0x184046D70")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct AAAIHCCBDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public IKMCGNPFENA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public GBKCLHPDCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public ODMCMDMIIOO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private PIODPDPLDDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x4044F40", Offset = "0x4043540", VA = "0x184044F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NIGKKDGFDLL OJJBBFPFAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private OAMNBHJNBHE OFLNLBGHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private HCBPJJNGDOO PPPBIOFDOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private EEFBLDDCJPC EPHHMAOIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private long MOAOFPNEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private LOBIGFHEGFH LNDFBPEKDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool ECOEBIPPFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Task HGIPBAAFPEF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3209620", Offset = "0x3207C20", VA = "0x183209620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FEELCMHEELH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3208D60", Offset = "0x3207360", VA = "0x183208D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3209250", Offset = "0x3207850", VA = "0x183209250", Slot = "4")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3208700", Offset = "0x3206D00", VA = "0x183208700", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3208B80", Offset = "0x3207180", VA = "0x183208B80")]
	[AsyncStateMachine(typeof(HBKAJILHCPC))]
	private Task GBPLBHJNAAG(AJGANPCLNAO JDGCGICMFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3209040", Offset = "0x3207640", VA = "0x183209040")]
	private void JFHPGHOGBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3208970", Offset = "0x3206F70", VA = "0x183208970")]
	private void FNJINJJHGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3208E40", Offset = "0x3207440", VA = "0x183208E40")]
	private void IONFJNPLFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3208CE0", Offset = "0x32072E0", VA = "0x183208CE0")]
	private bool IDGDLCBCCMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3208880", Offset = "0x3206E80", VA = "0x183208880")]
	[AsyncStateMachine(typeof(GBOHCIIFBFD))]
	private void FLJGJIBCODA(int NPMIJOEHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3208280", Offset = "0x3206880", VA = "0x183208280")]
	private void APBCJPNJFIG(out IDisposable MCICGMJMCFB, out IDisposable ACFGBBDIGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x32094A0", Offset = "0x3207AA0", VA = "0x1832094A0")]
	private bool ONCNICIPEBI(IKMCGNPFENA LOLKINEGLFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3208CA0", Offset = "0x32072A0", VA = "0x183208CA0")]
	private void HIGCBLAHEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x32085C0", Offset = "0x3206BC0", VA = "0x1832085C0")]
	[AsyncStateMachine(typeof(AAAIHCCBDNE))]
	private Task DLHAJJGIPIG(IKMCGNPFENA LOLKINEGLFF, ODMCMDMIIOO IAFHLBMFEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3209670", Offset = "0x3207C70", VA = "0x183209670")]
	public GBKCLHPDCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class KDFPJJGHHAA : OKAJJGOMDFM, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct JEJHAEKCCFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<JOMJELHHOJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public KDFPJJGHHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<JOMJELHHOJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x4052FC0", Offset = "0x40515C0", VA = "0x184052FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4053210", Offset = "0x4051810", VA = "0x184053210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HLNECDIHMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public GMKGAFOGKAM message;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HLNECDIHMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4050AB0", Offset = "0x404F0B0", VA = "0x184050AB0")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GDJCBONGLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public GMKGAFOGKAM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GDJCBONGLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x404D700", Offset = "0x404BD00", VA = "0x18404D700")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class MKAKDKANAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MKAKDKANAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4057F60", Offset = "0x4056560", VA = "0x184057F60")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct CFMGGKOGFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public KDFPJJGHHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<EDBOGFBFNEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4048710", Offset = "0x4046D10", VA = "0x184048710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class JKFENLBLLBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public GMKGAFOGKAM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JKFENLBLLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x40537F0", Offset = "0x4051DF0", VA = "0x1840537F0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct AGFMAJJNPGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public GMKGAFOGKAM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public KDFPJJGHHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GMCFJEBBKEC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x4046460", Offset = "0x4044A60", VA = "0x184046460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct MGPIEKLEIGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<EDBOGFBFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public KDFPJJGHHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private GMCFJEBBKEC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x4057AC0", Offset = "0x40560C0", VA = "0x184057AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4057F10", Offset = "0x4056510", VA = "0x184057F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class MFDEBDMLHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public EDBOGFBFNEC operation;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MFDEBDMLHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4057A40", Offset = "0x4056040", VA = "0x184057A40")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct ILOHNIBMOHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public EDBOGFBFNEC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public KDFPJJGHHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private global::IMNAINPHIAI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4051210", Offset = "0x404F810", VA = "0x184051210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class OKJIHNALEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OKJIHNALEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x405A6A0", Offset = "0x4058CA0", VA = "0x18405A6A0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EPKEENFFIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EPKEENFFIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x404BD30", Offset = "0x404A330", VA = "0x18404BD30")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private MLPGADEGBDL KAJFELMAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private FPNGPNBBLMK LIADCAMGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private PGNCBAOABOL JFFLMHPCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private TaskCompletionSource<JOMJELHHOJP> KKCKCELEPPB;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x32167F0", Offset = "0x3214DF0", VA = "0x1832167F0", Slot = "7")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3216530", Offset = "0x3214B30", VA = "0x183216530", Slot = "6")]
	[AsyncStateMachine(typeof(JEJHAEKCCFL))]
	public Task<JOMJELHHOJP> MOIOCBHOGPL(CancellationToken DECLKFMBNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x32156C0", Offset = "0x3213CC0", VA = "0x1832156C0", Slot = "4")]
	public void CGJLGJJBCDF(GMKGAFOGKAM DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x32151A0", Offset = "0x32137A0", VA = "0x1832151A0", Slot = "5")]
	public void AGKCNAAHIFK(GMKGAFOGKAM DOHAPGFHKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3216400", Offset = "0x3214A00", VA = "0x183216400")]
	[AsyncStateMachine(typeof(CFMGGKOGFNL))]
	private Task LLKOKIKHOFB(GMKGAFOGKAM GHNJJOLFHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3216670", Offset = "0x3214C70", VA = "0x183216670")]
	[AsyncStateMachine(typeof(AGFMAJJNPGH))]
	private Task OBAGKIBDACK(GMKGAFOGKAM EKPHANLOCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3215F00", Offset = "0x3214500", VA = "0x183215F00")]
	[AsyncStateMachine(typeof(MGPIEKLEIGI))]
	private Task<EDBOGFBFNEC> FEELDAOHMKG(GMKGAFOGKAM GHNJJOLFHLE, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x32155A0", Offset = "0x3213BA0", VA = "0x1832155A0")]
	private GMCFJEBBKEC CCBMLOACPMH(GMKGAFOGKAM JDCDMKBBFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x32162D0", Offset = "0x32148D0", VA = "0x1832162D0")]
	[AsyncStateMachine(typeof(ILOHNIBMOHH))]
	private Task IICIAHMCBJJ(EDBOGFBFNEC OECIEBPBJFM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3216050", Offset = "0x3214650", VA = "0x183216050")]
	private EDBOGFBFNEC GBDCBBHGJPC(GMKGAFOGKAM GHNJJOLFHLE, GMCFJEBBKEC JCIKKLFHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x308DDE0", Offset = "0x308C3E0", VA = "0x18308DDE0")]
	private T GJEPPHKPDCN<T>(T MAKFNMHIJIF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3215AF0", Offset = "0x32140F0", VA = "0x183215AF0")]
	private EDBOGFBFNEC CGJOHIPPKOF(GMKGAFOGKAM GHNJJOLFHLE, GMCFJEBBKEC JCIKKLFHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KDFPJJGHHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x32167A0", Offset = "0x3214DA0", VA = "0x1832167A0")]
	[CompilerGenerated]
	private void OBBALNDFEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Preserve]
internal sealed class ALKHHHKBFOC : FPNGPNBBLMK, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class KOKEDINJBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KOKEDINJBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F20", Offset = "0x3D18520", VA = "0x183D19F20")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class LCJLICFECOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LCJLICFECOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F90", Offset = "0x3D18590", VA = "0x183D19F90")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private MDMPGKEIFFB FHDIHMMIHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OKAJJGOMDFM LDKEPDECAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private NJBDEIJJCHN HLPKHFKMEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private NEAPKIDJFFE KNBMEIAPFDO;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x31FC160", Offset = "0x31FA760", VA = "0x1831FC160", Slot = "6")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x31FAD70", Offset = "0x31F9370", VA = "0x1831FAD70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x31FB700", Offset = "0x31F9D00", VA = "0x1831FB700", Slot = "4")]
	public NILFOALGDBC KFAFAEJLPMN(GMKGAFOGKAM IANJDAGFMEA)
	{
		return default(NILFOALGDBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x31FAAF0", Offset = "0x31F90F0", VA = "0x1831FAAF0", Slot = "5")]
	public void DCFKLMEFBEC(Guid KAOFPCAFLFA, Task JNFJEAGEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x31FB110", Offset = "0x31F9710", VA = "0x1831FB110")]
	private void FFGNANHAPKN(byte OHKFJKCFKMH, int LIMGPBBOCJI, object FODDMJNLGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x31FA3F0", Offset = "0x31F89F0", VA = "0x1831FA3F0")]
	private void BMGDCHLIINM(EEPBJLCNGAG BLEPFEFKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x31FBBE0", Offset = "0x31FA1E0", VA = "0x1831FBBE0")]
	private void LPBPKBKNIJG(EEPBJLCNGAG BLEPFEFKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x31FA140", Offset = "0x31F8740", VA = "0x1831FA140")]
	private void ADJICPMPPDK(EEPBJLCNGAG BLEPFEFKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x31FBEC0", Offset = "0x31FA4C0", VA = "0x1831FBEC0")]
	private HNKKGJKFCMD OHBJDLBBJNJ(GMKGAFOGKAM JDCDMKBBFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x31FB1E0", Offset = "0x31F97E0", VA = "0x1831FB1E0")]
	private void IHPDFPGOPIB(GMKGAFOGKAM EKPHANLOCCA, HNKKGJKFCMD JFMEPDDDBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x31FAE10", Offset = "0x31F9410", VA = "0x1831FAE10")]
	private bool EOGJPCGJNMM(GMKGAFOGKAM EKPHANLOCCA, HNKKGJKFCMD JFMEPDDDBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x31FB430", Offset = "0x31F9A30", VA = "0x1831FB430")]
	private bool JGKIJINDGMI(GMKGAFOGKAM BGOCOMOFANH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x31FC2D0", Offset = "0x31FA8D0", VA = "0x1831FC2D0")]
	private bool PNHAPFLKOPO(byte OHKFJKCFKMH, ExitGames.Client.Photon.Hashtable BLEPFEFKNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public ALKHHHKBFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class MFGOODPPMIN : EENNCCEAIML, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class OBAKJABFBME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public JOMJELHHOJP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public MFGOODPPMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public GMKGAFOGKAM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OBAKJABFBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x4A53290", Offset = "0x4A51890", VA = "0x184A53290")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x4A53300", Offset = "0x4A51900", VA = "0x184A53300")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct CEMDIECAICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public MFGOODPPMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public GMKGAFOGKAM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x4A4ADE0", Offset = "0x4A493E0", VA = "0x184A4ADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B340", Offset = "0x4A49940", VA = "0x184A4B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GPMBFBEAIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JOMJELHHOJP operationType;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GPMBFBEAIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F380", Offset = "0x4A4D980", VA = "0x184A4F380")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class OPHFGHMIFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OPHFGHMIFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x4A53660", Offset = "0x4A51C60", VA = "0x184A53660")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x4A536D0", Offset = "0x4A51CD0", VA = "0x184A536D0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x4A53740", Offset = "0x4A51D40", VA = "0x184A53740")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct DAFKEIJFDLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public MFGOODPPMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private OPHFGHMIFJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private NILFOALGDBC <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private HNKKGJKFCMD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<(HNKKGJKFCMD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C210", Offset = "0x4A4A810", VA = "0x184A4C210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C900", Offset = "0x4A4AF00", VA = "0x184A4C900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MDMPGKEIFFB FHDIHMMIHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private FPNGPNBBLMK LIADCAMGBMN;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BD40", Offset = "0x3D1A340", VA = "0x183D1BD40", Slot = "5")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BC00", Offset = "0x3D1A200", VA = "0x183D1BC00", Slot = "4")]
	[AsyncStateMachine(typeof(CEMDIECAICD))]
	private Task<HNKKGJKFCMD> NKEHGNCPMDH(GMKGAFOGKAM JDCDMKBBFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B810", Offset = "0x3D19E10", VA = "0x183D1B810")]
	private bool FMDABBJJPIF(JOMJELHHOJP DMPLKKLCBGL, out HNKKGJKFCMD BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BAC0", Offset = "0x3D1A0C0", VA = "0x183D1BAC0")]
	[AsyncStateMachine(typeof(DAFKEIJFDLL))]
	private Task<HNKKGJKFCMD> JLMACCADANF(GMKGAFOGKAM GHNJJOLFHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MFGOODPPMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Preserve]
internal sealed class HNJCIFNCBLM : FHHMNEGALCE, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct FGCLPHJBOIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<ELFALKJEDMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public HNJCIFNCBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<KFMOMBKGPMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x404C190", Offset = "0x404A790", VA = "0x18404C190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x404C370", Offset = "0x404A970", VA = "0x18404C370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class AMDDMJIBAKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AMDDMJIBAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4046E10", Offset = "0x4045410", VA = "0x184046E10")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct BDFCKFDIEDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<KFMOMBKGPMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public HNJCIFNCBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public IKMCGNPFENA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private AMDDMJIBAKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<AJHGDDIACKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x40477B0", Offset = "0x4045DB0", VA = "0x1840477B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4047B70", Offset = "0x4046170", VA = "0x184047B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class AJDJNFHACGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AJDJNFHACGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1C8D050", Offset = "0x1C8B650", VA = "0x181C8D050")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(ANINOEMMMNA sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly (LLGMLEHJMCJ superRoomData, string unityAssetId, LLGMLEHJMCJ subRoomData) BMBKHLDKDKF;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3210230", Offset = "0x320E830", VA = "0x183210230", Slot = "5")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x32100B0", Offset = "0x320E6B0", VA = "0x1832100B0", Slot = "4")]
	[AsyncStateMachine(typeof(FGCLPHJBOIG))]
	public Task<ELFALKJEDMF> NBGMIJIFOCF(GPNAMOIINIG AEKLGCBMNDP, IKMCGNPFENA AGOPKDGGMFM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x32102A0", Offset = "0x320E8A0", VA = "0x1832102A0")]
	[AsyncStateMachine(typeof(BDFCKFDIEDC))]
	private Task<KFMOMBKGPMO> OOGMHFFBBHM(IKMCGNPFENA AGOPKDGGMFM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x320FAD0", Offset = "0x320E0D0", VA = "0x18320FAD0")]
	private ELFALKJEDMF GBOEBFEMFPD(IKMCGNPFENA AGOPKDGGMFM, KFMOMBKGPMO LKKPFEOPABC, long BJDHMPBAACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x320FD00", Offset = "0x320E300", VA = "0x18320FD00")]
	private (LLGMLEHJMCJ, string, LLGMLEHJMCJ) KOMCHBPCCHB(IKMCGNPFENA AGOPKDGGMFM, KFMOMBKGPMO LKKPFEOPABC, long BJDHMPBAACC)
	{
		return default((LLGMLEHJMCJ, string, LLGMLEHJMCJ));
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public HNJCIFNCBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[Preserve]
internal sealed class NDAPNBKMNPH : PGNCBAOABOL, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class IPIJEBJNMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IPIJEBJNMNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F680", Offset = "0x4A4DC80", VA = "0x184A4F680")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct LHPLELNKLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NDAPNBKMNPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public GMCFJEBBKEC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x4A507B0", Offset = "0x4A4EDB0", VA = "0x184A507B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x4A50C10", Offset = "0x4A4F210", VA = "0x184A50C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct NKCPALNHHIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NDAPNBKMNPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public GMCFJEBBKEC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4A52830", Offset = "0x4A50E30", VA = "0x184A52830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x4A52E10", Offset = "0x4A51410", VA = "0x184A52E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class OJKNLJAJALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OJKNLJAJALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4A53600", Offset = "0x4A51C00", VA = "0x184A53600")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BFKCJALEPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public GMKGAFOGKAM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NDAPNBKMNPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public GMCFJEBBKEC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private FFFPMBNIKKG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private KHJMDKOCBNC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4A49290", Offset = "0x4A47890", VA = "0x184A49290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4A49D20", Offset = "0x4A48320", VA = "0x184A49D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private BGCIDMJMEGI LAKGEDFJCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private KOANDAEHODA OPPJHNHJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E1F0", Offset = "0x3D1C7F0", VA = "0x183D1E1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E570", Offset = "0x3D1CB70", VA = "0x183D1E570", Slot = "8")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DF50", Offset = "0x3D1C550", VA = "0x183D1DF50", Slot = "4")]
	[AsyncStateMachine(typeof(LHPLELNKLEL))]
	public Task<GMKGAFOGKAM> BPIHDNCEHCE(GMKGAFOGKAM GHNJJOLFHLE, GMCFJEBBKEC JCIKKLFHNKA, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E600", Offset = "0x3D1CC00", VA = "0x183D1E600", Slot = "5")]
	[AsyncStateMachine(typeof(NKCPALNHHIC))]
	public Task<GMKGAFOGKAM> PCNDOJGEELP(CancellationToken JLIEBAENBAG, GMCFJEBBKEC JCIKKLFHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E0C0", Offset = "0x3D1C6C0", VA = "0x183D1E0C0", Slot = "6")]
	public IBAJEEKBPBO FDFOHDFCKPG(EDBOGFBFNEC DNOIABOEFCG, GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DE20", Offset = "0x3D1C420", VA = "0x183D1DE20", Slot = "7")]
	public IBAJEEKBPBO AEBFMMPBEPN(EDBOGFBFNEC DNOIABOEFCG, GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E2A0", Offset = "0x3D1C8A0", VA = "0x183D1E2A0")]
	[AsyncStateMachine(typeof(BFKCJALEPFA))]
	private Task<GMKGAFOGKAM> KHOEDDHIMKD(GMKGAFOGKAM GHNJJOLFHLE, GMCFJEBBKEC JCIKKLFHNKA, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x32D9670", Offset = "0x32D7C70", VA = "0x1832D9670")]
	private static byte[] MACJADNOFBI(GMKGAFOGKAM DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E420", Offset = "0x3D1CA20", VA = "0x183D1E420")]
	private static string LDPFEHIBLPE(byte[] LDLMPCMBDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NDAPNBKMNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class MCCIJAAHMAI : MDMPGKEIFFB, CGEHFEJBJEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private OAGFELPGPII CJAJFCFJGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private MLPGADEGBDL KAJFELMAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private CKCOMBPMAKH NGEFKGPCJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private EEFBLDDCJPC EPHHMAOIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private JFAJDMKDCOE BGANBIAOGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HCBPJJNGDOO PPPBIOFDOMH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B190", Offset = "0x3D19790", VA = "0x183D1B190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static HNKKGJKFCMD LEDCOBPFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B020", Offset = "0x3D19620", VA = "0x183D1B020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B030", Offset = "0x3D19630", VA = "0x183D1B030", Slot = "7")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AC90", Offset = "0x3D19290", VA = "0x183D1AC90", Slot = "4")]
	public HNKKGJKFCMD HLCLOHIOPKC(CHIAPKEENBB LECPOHMBMNE, JOMJELHHOJP OKGFNLPFOFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AA30", Offset = "0x3D19030", VA = "0x183D1AA30", Slot = "5")]
	public HNKKGJKFCMD CABBJFLIHFM(CHIAPKEENBB ONJBJADNFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AE20", Offset = "0x3D19420", VA = "0x183D1AE20", Slot = "6")]
	public HNKKGJKFCMD JMBOEPCBCHD(CHIAPKEENBB ONJBJADNFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AC80", Offset = "0x3D19280", VA = "0x183D1AC80")]
	private static HNKKGJKFCMD DDNBAMJLOHN(EKOKBLCONFM ECMALJHOMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MCCIJAAHMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class AGDFKOBPAIJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x31F8E80", Offset = "0x31F7480", VA = "0x1831F8E80")]
	public AGDFKOBPAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x17E9580", Offset = "0x17E7B80", VA = "0x1817E9580")]
	public AGDFKOBPAIJ(string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[Preserve]
internal sealed class GFLHEPLICNB : MDOLGLJHONG, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct JMJAOHNCMFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public GFLHEPLICNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HFFCNJPOHMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private global::IMNAINPHIAI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private GPNAMOIINIG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private GIFBHNANFGH <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private GPNAMOIINIG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x4053850", Offset = "0x4051E50", VA = "0x184053850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x4053FB0", Offset = "0x40525B0", VA = "0x184053FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct MDBJNNLBBDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public GFLHEPLICNB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40573E0", Offset = "0x40559E0", VA = "0x1840573E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JMONDCILHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public GFLHEPLICNB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4054000", Offset = "0x4052600", VA = "0x184054000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct FAOAOJHHBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public GFLHEPLICNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x404C050", Offset = "0x404A650", VA = "0x18404C050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct AFHGFADPGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public GFLHEPLICNB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4045D30", Offset = "0x4044330", VA = "0x184045D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct HEMNCFNFCKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public GFLHEPLICNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public DJMCEAKDOIN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private global::IMNAINPHIAI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x404F7F0", Offset = "0x404DDF0", VA = "0x18404F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static readonly TimeSpan DMMPLAAIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private PGNCBAOABOL JFFLMHPCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private MLPGADEGBDL KAJFELMAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private JFAJDMKDCOE BGANBIAOGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private CancellationTokenSource PLHDAKGKPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Task MKEJECIGHIC;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x320B220", Offset = "0x3209820", VA = "0x18320B220", Slot = "6")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0B20", Offset = "0x1FEF120", VA = "0x181FF0B20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x320AD60", Offset = "0x3209360", VA = "0x18320AD60", Slot = "4")]
	[AsyncStateMachine(typeof(JMJAOHNCMFB))]
	public Task<HNKKGJKFCMD> INGCEEGHENB(HFFCNJPOHMD GBNPJHBLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x320AFD0", Offset = "0x32095D0", VA = "0x18320AFD0", Slot = "5")]
	[AsyncStateMachine(typeof(MDBJNNLBBDM))]
	public Task NHFANPNKGLE([Optional] CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0B20", Offset = "0x1FEF120", VA = "0x181FF0B20")]
	public void NBGCPEDCCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x320B460", Offset = "0x3209A60", VA = "0x18320B460")]
	private GIFBHNANFGH PCOPFMEDBBB(HFFCNJPOHMD GBNPJHBLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x320AC30", Offset = "0x3209230", VA = "0x18320AC30")]
	[AsyncStateMachine(typeof(JMONDCILHMO))]
	private Task HPLOIGJKACI(EMLPMBHPMDM IBHBGBEBHJM, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x320A990", Offset = "0x3208F90", VA = "0x18320A990")]
	[AsyncStateMachine(typeof(FAOAOJHHBEP))]
	private Task FBMDNOFABHC([Optional] CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x320AEA0", Offset = "0x32094A0", VA = "0x18320AEA0")]
	[AsyncStateMachine(typeof(AFHGFADPGDL))]
	private Task KLNOFECPLLC(TimeSpan HBCHJPAOJMJ, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x320A6A0", Offset = "0x3208CA0", VA = "0x18320A6A0")]
	private Task ECACALMMFOO(DJMCEAKDOIN LLJBGAHHCBP, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x320B0F0", Offset = "0x32096F0", VA = "0x18320B0F0")]
	[AsyncStateMachine(typeof(HEMNCFNFCKG))]
	private Task OICBCDJELLD(DJMCEAKDOIN LLJBGAHHCBP, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x320AAB0", Offset = "0x32090B0", VA = "0x18320AAB0")]
	private bool GHFIFKNLCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GFLHEPLICNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[Preserve]
internal class NCPNAHJPOMG : CKCOMBPMAKH, CGEHFEJBJEO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct GNHNLMLDNPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public NCPNAHJPOMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private global::IMNAINPHIAI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EFE0", Offset = "0x4A4D5E0", VA = "0x184A4EFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private HKJGGEEKHJM LKDBNNCGMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private MDMPGKEIFFB FHDIHMMIHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private PGNCBAOABOL JFFLMHPCKCE;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC00", Offset = "0x3D1C200", VA = "0x183D1DC00", Slot = "6")]
	public void OIEJOMHJJDA(PEHFLLKFGNK GHBIGIEEHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DA30", Offset = "0x3D1C030", VA = "0x183D1DA30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DAE0", Offset = "0x3D1C0E0", VA = "0x183D1DAE0", Slot = "5")]
	[AsyncStateMachine(typeof(GNHNLMLDNPL))]
	public Task KKHIJPILFGL(string GFBIJELPOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DA80", Offset = "0x3D1C080", VA = "0x183D1DA80", Slot = "4")]
	public HNKKGJKFCMD GHFIFKNLCJM(CHIAPKEENBB LECPOHMBMNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D920", Offset = "0x3D1BF20", VA = "0x183D1D920")]
	private GAGNIALMBPB AABBGIHIAPF(string GFBIJELPOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NCPNAHJPOMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class HDCILBJCBKK
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x320D120", Offset = "0x320B720", VA = "0x18320D120")]
	public static void KADNDACMFBG(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x320CBF0", Offset = "0x320B1F0", VA = "0x18320CBF0")]
	internal static void IKMMCLFCJMN(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x320D2E0", Offset = "0x320B8E0", VA = "0x18320D2E0")]
	internal static void LJPCHJPBNBC(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x320CCD0", Offset = "0x320B2D0", VA = "0x18320CCD0")]
	internal static void IKNDACPEMEO(PEGEFOEHCCC IGFHDABHNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class AOBEBOHEFHH : global::LJJKDOGPGLE<GMKGAFOGKAM>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class JKMJAMJFPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GMKGAFOGKAM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JKMJAMJFPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3D195E0", Offset = "0x3D17BE0", VA = "0x183D195E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly AOBEBOHEFHH LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const string KKLFEFOBONI = "pl";

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x31FCDA0", Offset = "0x31FB3A0", VA = "0x1831FCDA0")]
	public ExitGames.Client.Photon.Hashtable HGEKGOKJCDE(GMKGAFOGKAM DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x31FCE20", Offset = "0x31FB420", VA = "0x1831FCE20", Slot = "5")]
	protected override void IHONEGDEJKI(GMKGAFOGKAM DIDMFBHHIEC, IDictionary<object, object> JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x31FCB50", Offset = "0x31FB150", VA = "0x1831FCB50", Slot = "6")]
	public override GMKGAFOGKAM FFFJLEEKFAK(IDictionary<object, object> JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x31FC9D0", Offset = "0x31FAFD0", VA = "0x1831FC9D0")]
	private static void AECLFKCPDDB(string OCIJCOOAIBL, GMKGAFOGKAM DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x31FD330", Offset = "0x31FB930", VA = "0x1831FD330")]
	public AOBEBOHEFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x31FCF60", Offset = "0x31FB560", VA = "0x1831FCF60")]
	[CompilerGenerated]
	internal static string NGOMONIPBDL(ELFALKJEDMF GOMBJHKPMMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class EEMEBPBHIFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static HNKKGJKFCMD LEDCOBPFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3206150", Offset = "0x3204750", VA = "0x183206150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3206130", Offset = "0x3204730", VA = "0x183206130")]
	public static bool NBDOBKHBFOH(this HNKKGJKFCMD JFMEPDDDBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3205E50", Offset = "0x3204450", VA = "0x183205E50")]
	public static HNKKGJKFCMD DDNBAMJLOHN(EKOKBLCONFM JADFNIJJIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3206120", Offset = "0x3204720", VA = "0x183206120")]
	public static HNKKGJKFCMD MCODJLIOEBM(params HNKKGJKFCMD[] KNPODLNJLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x32061B0", Offset = "0x32047B0", VA = "0x1832061B0")]
	public static HNKKGJKFCMD PBMKKIOMEHL(IEnumerable<HNKKGJKFCMD> KNPODLNJLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3205EB0", Offset = "0x32044B0", VA = "0x183205EB0")]
	public static string HBHLHBPPMJF(this HNKKGJKFCMD BIDLMNEFHJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class HIKHHHDNOJG : IAJBGEPHNOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate HNKKGJKFCMD CBDLOBKPIDJ([NotNull] CHIAPKEENBB BIAPDBFCHKB);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class ECINOLPBNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public CHIAPKEENBB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ECINOLPBNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x404B5F0", Offset = "0x4049BF0", VA = "0x18404B5F0")]
		internal HNKKGJKFCMD <Validate>b__0(CBDLOBKPIDJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	protected readonly HashSet<CBDLOBKPIDJ> BGBGMHFANEP;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x320E460", Offset = "0x320CA60", VA = "0x18320E460", Slot = "4")]
	public void KAIJJAHEKEF(CBDLOBKPIDJ BEPCBCBFDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x320E760", Offset = "0x320CD60", VA = "0x18320E760", Slot = "5")]
	public void POPJCDNPCIB(CBDLOBKPIDJ BEPCBCBFDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x320E410", Offset = "0x320CA10", VA = "0x18320E410", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x320E4C0", Offset = "0x320CAC0", VA = "0x18320E4C0")]
	protected HNKKGJKFCMD NJAHJBMBFDH(CHIAPKEENBB ONJBJADNFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3205280", Offset = "0x3203880", VA = "0x183205280")]
	protected HIKHHHDNOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class DOBMHALMBBF : HIKHHHDNOJG, OAGFELPGPII, IAJBGEPHNOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class DLNBGMFAEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public HNKKGJKFCMD result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public DLNBGMFAEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D122C0", Offset = "0x3D108C0", VA = "0x183D122C0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3205280", Offset = "0x3203880", VA = "0x183205280")]
	[Preserve]
	public DOBMHALMBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3205100", Offset = "0x3203700", VA = "0x183205100", Slot = "8")]
	public HNKKGJKFCMD ENEDDICAONN(CHIAPKEENBB ONJBJADNFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class PMDBDLAJHKC : HIKHHHDNOJG, HKJGGEEKHJM, IAJBGEPHNOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class HKHJIKCMLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public HNKKGJKFCMD result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HKHJIKCMLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F3F0", Offset = "0x4A4D9F0", VA = "0x184A4F3F0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D239A0", Offset = "0x3D21FA0", VA = "0x183D239A0")]
	[Preserve]
	public PMDBDLAJHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D23820", Offset = "0x3D21E20", VA = "0x183D23820", Slot = "8")]
	public HNKKGJKFCMD GHFIFKNLCJM(CHIAPKEENBB DNGIFCKAEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum OCKEDGPKKMH
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
internal static class CKIKNJNEHDM
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class MOOKFKKFGOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public global::IMNAINPHIAI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MOOKFKKFGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D8A0", Offset = "0x3D1BEA0", VA = "0x183D1D8A0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public const string PFOOEPJEEIE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public const string LEOMFJOJOOC = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3200DE0", Offset = "0x31FF3E0", VA = "0x183200DE0")]
	public static global::IMNAINPHIAI<string> ANNHDAJAENG([Optional] string OOCECJOPGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3200F70", Offset = "0x31FF570", VA = "0x183200F70")]
	private static void LKBCBODPJOH(string AIGAKEKDKHM, MECHGGHOKGB IDKFKDEHFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x32011D0", Offset = "0x31FF7D0", VA = "0x1832011D0")]
	private static void NPJJMNLCKAF(string AIGAKEKDKHM, MECHGGHOKGB IDKFKDEHFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3201070", Offset = "0x31FF670", VA = "0x183201070")]
	public static void LODNBCHAELA(global::IMNAINPHIAI<string> IDKFKDEHFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3200EB0", Offset = "0x31FF4B0", VA = "0x183200EB0")]
	public static string BPMOEKBLMJG(GMKGAFOGKAM JDCDMKBBFEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class OFBLPGAJEAK
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D208C0", Offset = "0x3D1EEC0", VA = "0x183D208C0")]
	public static void ICFKJFAKMKJ(this OGHNMHNJHKD IFOIKAOPFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D208D0", Offset = "0x3D1EED0", VA = "0x183D208D0")]
	public static void KFPJHCLOCMN(this OGHNMHNJHKD IFOIKAOPFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3D208E0", Offset = "0x3D1EEE0", VA = "0x183D208E0")]
	private static void NINCHAPGDMO(this OGHNMHNJHKD IFOIKAOPFOA, bool APEPDBJBBOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class MKGCOPAJCDG : AHHKAFEBAHA, GPEHMGCIABO, PCGMNJPFOND, NIMDKFJALIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly GPEHMGCIABO ICGANKOEJLI;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CHIAPKEENBB GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C1F0", Offset = "0x3D1A7F0", VA = "0x183D1C1F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int HAFMINHOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C0C0", Offset = "0x3D1A6C0", VA = "0x183D1C0C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int BBEDCDCJPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C380", Offset = "0x3D1A980", VA = "0x183D1C380", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool CKJBFOGMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int FPCFGADJNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x677270", Offset = "0x675870", VA = "0x180677270", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event DPFDMHPCAKL.IFENLMNMOIO GCELNIHDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HCGDCIOBMHL JGDAKIOIHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C2E0", Offset = "0x3D1A8E0", VA = "0x183D1C2E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C3D0", Offset = "0x3D1A9D0", VA = "0x183D1C3D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> LMBIOOHJLML
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<CHIAPKEENBB> GEADGMGMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action AMBAJNIAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BF20", Offset = "0x3D1A520", VA = "0x183D1BF20", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BFC0", Offset = "0x3D1A5C0", VA = "0x183D1BFC0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x8AAEB0", Offset = "0x8A94B0", VA = "0x1808AAEB0")]
	public MKGCOPAJCDG(GPEHMGCIABO ICGANKOEJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BE50", Offset = "0x3D1A450", VA = "0x183D1BE50", Slot = "8")]
	public bool CJOMGOEIIAN(byte OHKFJKCFKMH, ExitGames.Client.Photon.Hashtable HDFCIJGMMLE, EDGFCDOLJKI JKBFOHIMOFI, SendOptions IIGIBKACNDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C240", Offset = "0x3D1A840", VA = "0x183D1C240", Slot = "29")]
	public CHIAPKEENBB ICPGFOLDMLI(int FEGKNPLIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C110", Offset = "0x3D1A710", VA = "0x183D1C110", Slot = "16")]
	public CHIAPKEENBB FIJJCLFHMNA(int BGLNGFFMIBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "19")]
	public void BENOLFOFBFI(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "20")]
	public void MGIMOJNHBEA(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "21")]
	public void FNHOFHJPCJA(object HKLDIENGNNB, bool CNFIBAHADNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C060", Offset = "0x3D1A660", VA = "0x183D1C060", Slot = "22")]
	public IDisposable DOLMFJDCMEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "23")]
	private bool GCPFHHHMELP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "24")]
	public void AHNNKFKKBLA(StringBuilder ONCNIAEJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BF00", Offset = "0x3D1A500", VA = "0x183D1BF00", Slot = "25")]
	public bool CKDNKIHFOPB(bool JMOCJCPLBGL, out string OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public void KOJECPOPLID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5FC0", Offset = "0x1FB45C0", VA = "0x181FB5FC0", Slot = "28")]
	public void KDELFIALKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct EEPBJLCNGAG
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const string FGGEBCHFOKD = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public const string HJKBCJHPCCD = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly IDictionary<object, object> BLEPFEFKNDI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAF8CD0", Offset = "0xAF72D0", VA = "0x180AF8CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x72F870", Offset = "0x72DE70", VA = "0x18072F870")]
	public EEPBJLCNGAG(IDictionary<object, object> BLEPFEFKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x32066E0", Offset = "0x3204CE0", VA = "0x1832066E0")]
	public bool OOAODALDLKG(out GMKGAFOGKAM DIDMFBHHIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3206600", Offset = "0x3204C00", VA = "0x183206600")]
	public Guid LOGIGLOJGHM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x32063B0", Offset = "0x32049B0", VA = "0x1832063B0")]
	public HNKKGJKFCMD BAKIHDJNANJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3206510", Offset = "0x3204B10", VA = "0x183206510")]
	public static ExitGames.Client.Photon.Hashtable CBFHJGEFJHE(GMKGAFOGKAM DIDMFBHHIEC, HNKKGJKFCMD JFMEPDDDBHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LNLMIOEJCAC
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x3219390", Offset = "0x3217990", VA = "0x183219390")]
	public static string MGHCELJPEKD(this IKMCGNPFENA OECLDILMEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x3219310", Offset = "0x3217910", VA = "0x183219310")]
	public static bool ANCBOIOCEAN(this IKMCGNPFENA OECLDILMEEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct GIBKHNIFIMJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct BMCLFNNOMGA : IAsyncStateMachine
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
		public GIBKHNIFIMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x4047FB0", Offset = "0x40465B0", VA = "0x184047FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CancellationTokenSource MFPMCEFBCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private Task LMDFEBFDNDF;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x320B790", Offset = "0x3209D90", VA = "0x18320B790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task CLJHHEAMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x320B940", Offset = "0x3209F40", VA = "0x18320B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x320B9C0", Offset = "0x3209FC0", VA = "0x18320B9C0")]
	public GIBKHNIFIMJ(CancellationToken JLIEBAENBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x320B810", Offset = "0x3209E10", VA = "0x18320B810")]
	[AsyncStateMachine(typeof(BMCLFNNOMGA))]
	public Task GPMKMPCGOAO(Func<CancellationToken, List<Task>> COKAIGNKOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x320B7C0", Offset = "0x3209DC0", VA = "0x18320B7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct IIAAFKEDLDP<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct GGKOKIKDGLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<global::IKEELLNFFOM<global::BNHPJFPNMAO<TData>, IHHGNGPIMCG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public global::IIAAFKEDLDP<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private GPNAMOIINIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<global::IKEELLNFFOM<byte[], IHHGNGPIMCG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x37D3340", Offset = "0x37D1940", VA = "0x1837D3340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1A00", Offset = "0x2CA0000", VA = "0x182CA1A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private readonly global::MHGMMAFIJAI<TGetDataArg, TData> CLMOOCMNIOA;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x72F870", Offset = "0x72DE70", VA = "0x18072F870")]
	internal IIAAFKEDLDP(global::MHGMMAFIJAI<TGetDataArg, TData> LCOMIHDGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FF66E0", Offset = "0x2FF4CE0", VA = "0x182FF66E0")]
	[AsyncStateMachine(typeof(global::IIAAFKEDLDP<, >.GGKOKIKDGLA))]
	public Task<global::IKEELLNFFOM<global::BNHPJFPNMAO<TData>, IHHGNGPIMCG>> CDPIABGMHAE(TGetDataArg LDLMPCMBDAJ, string KMPLMHKIGKP, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class HLHPAIINMMC
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x31DA850", Offset = "0x31D8E50", VA = "0x1831DA850")]
	public static global::IIAAFKEDLDP<TGetDataArg, TData> OJKIKDBCCPC<TGetDataArg, TData>(global::MHGMMAFIJAI<TGetDataArg, TData> LCOMIHDGHCD)
	{
		return default(global::IIAAFKEDLDP<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class PIJBHNICAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly DNLANILPICA JMMHILADMEA;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private const string IPKPECLEIBH = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private const string FNEFJCGIKPO = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string IOAGGGLHAMD = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string ENGALBLLDFD = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string BLCGBJKNFBM = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private string EIBKOKAKDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private long? JGPBNHMEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private long? NDECHIJLFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private DOIAGHFMBCN AEONLBHLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? NOEPMAFGCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private bool ENBFOJHFFLB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string NHPBDPLFDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long ELCHBLIOEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D235D0", Offset = "0x3D21BD0", VA = "0x183D235D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long CHMKDJJOEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D23570", Offset = "0x3D21B70", VA = "0x183D23570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DOIAGHFMBCN AAPPOFDOKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D50", Offset = "0x6A8350", VA = "0x1806A9D50")]
		get
		{
			return default(DOIAGHFMBCN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D22C90", Offset = "0x3D21290", VA = "0x183D22C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long BHIDOKLIHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D23160", Offset = "0x3D21760", VA = "0x183D23160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3D237E0", Offset = "0x3D21DE0", VA = "0x183D237E0")]
	[Preserve]
	public PIJBHNICAJC([KICKHKJFGOO(null)] DNLANILPICA JMMHILADMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3D23630", Offset = "0x3D21C30", VA = "0x183D23630")]
	private void OOLNDHEKGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D231C0", Offset = "0x3D217C0", VA = "0x183D231C0")]
	public void NJJNAKOBAEJ(long FAFDJINDEIN, long BJDHMPBAACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3D23070", Offset = "0x3D21670", VA = "0x183D23070")]
	public void HOKAGMBFAJH(string LCKDJLKMBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D22D80", Offset = "0x3D21380", VA = "0x183D22D80")]
	public void EHAKFOHAPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class IBAJEEKBPBO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct BEFBBCMHCJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public GMKGAFOGKAM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IBAJEEKBPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<FPMHAOACIJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4047BC0", Offset = "0x40461C0", VA = "0x184047BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4047ED0", Offset = "0x40464D0", VA = "0x184047ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct MJBGDMMOBBL<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class NFAACFPOKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public GMKGAFOGKAM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public NFAACFPOKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4059250", Offset = "0x4057850", VA = "0x184059250")]
		internal GMKGAFOGKAM <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct CHALJFEAPKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<FPMHAOACIJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public GMKGAFOGKAM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public IBAJEEKBPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private FFFPMBNIKKG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<FPMHAOACIJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4048D50", Offset = "0x4047350", VA = "0x184048D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4049520", Offset = "0x4047B20", VA = "0x184049520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct LDJMCFJBNHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public IBAJEEKBPBO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4055770", Offset = "0x4053D70", VA = "0x184055770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class IMOFIGMEKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IMOFIGMEKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x4051750", Offset = "0x404FD50", VA = "0x184051750")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class KFCABCNHJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KFCABCNHJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x4054B10", Offset = "0x4053110", VA = "0x184054B10")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class PPCHBHAGKPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PPCHBHAGKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x405B1D0", Offset = "0x40597D0", VA = "0x18405B1D0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class OPLICJPAGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OPLICJPAGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x405AA40", Offset = "0x4059040", VA = "0x18405AA40")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class KHGFGAACBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public IBAJEEKBPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KHGFGAACBGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x4054C60", Offset = "0x4053260", VA = "0x184054C60")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class LDIBDIHFPIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public IBAJEEKBPBO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LDIBDIHFPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x40554D0", Offset = "0x4053AD0", VA = "0x1840554D0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly Guid HMDEFEBLGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly EDBOGFBFNEC EJCDLMHEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly KOANDAEHODA EBFKOHPMINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly PCGMNJPFOND IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly NIMDKFJALIL GJMAHKNIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool DDIEMFACCCI;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3212570", Offset = "0x3210B70", VA = "0x183212570")]
	public IBAJEEKBPBO(EDBOGFBFNEC OECIEBPBJFM, KOANDAEHODA EBFKOHPMINB, PCGMNJPFOND IFOIKAOPFOA, NIMDKFJALIL GJMAHKNIOCN, GPNAMOIINIG AEKLGCBMNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x32115C0", Offset = "0x320FBC0", VA = "0x1832115C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x32115C0", Offset = "0x320FBC0", VA = "0x1832115C0")]
	public void FBIMMGIPCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3211FD0", Offset = "0x32105D0", VA = "0x183211FD0")]
	public void KDGBDMNAOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3211960", Offset = "0x320FF60", VA = "0x183211960")]
	public void GJKNLGDNFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3212120", Offset = "0x3210720", VA = "0x183212120")]
	[AsyncStateMachine(typeof(BEFBBCMHCJD))]
	internal Task<GMKGAFOGKAM> OOFMMICCPPA(GPNAMOIINIG AEKLGCBMNDP, GMKGAFOGKAM JDCDMKBBFEE, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x32D9670", Offset = "0x32D7C70", VA = "0x1832D9670")]
	private static byte[] GBJJFJEPFHB<T>(T DIDMFBHHIEC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x32D9760", Offset = "0x32D7D60", VA = "0x1832D9760")]
	private static T IAAHFMJEDOD<T>(MessageParser<T> DGECDLNDNCF, byte[] DIDMFBHHIEC, T BGANFPDCCAI) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3211460", Offset = "0x320FA60", VA = "0x183211460")]
	[AsyncStateMachine(typeof(CHALJFEAPKG))]
	private Task<FPMHAOACIJN> DDLPEMFNDHM(GMKGAFOGKAM JDCDMKBBFEE, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x32D9390", Offset = "0x32D7990", VA = "0x1832D9390")]
	[AsyncStateMachine(typeof(MOPABPGNBOD))]
	internal Task<T> BNHDHLELEAM<T>(CancellationToken CGNPIKGMLAB, Func<CancellationToken, Task<T>> AILJMABAGCL, int AEMMIGCCAPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3211280", Offset = "0x320F880", VA = "0x183211280")]
	[AsyncStateMachine(typeof(LDJMCFJBNHM))]
	internal Task BNHDHLELEAM(CancellationToken CGNPIKGMLAB, Func<CancellationToken, Task> AILJMABAGCL, int AEMMIGCCAPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x32113D0", Offset = "0x320F9D0", VA = "0x1832113D0")]
	public GMKGAFOGKAM BPEFEKAOCLF(FFFPMBNIKKG BBKFHFEGMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3211DD0", Offset = "0x32103D0", VA = "0x183211DD0")]
	public POOLDNGHOFB JKIFGCJNLJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x32118F0", Offset = "0x320FEF0", VA = "0x1832118F0")]
	public ABPFELHIMBP FLHMEKOBICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x3211AB0", Offset = "0x32100B0", VA = "0x183211AB0")]
	public HJLMGKGCMMH GKJAHPGKDLB([Optional] INGDNFMECCG? DIAIBEICBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3211100", Offset = "0x320F700", VA = "0x183211100")]
	public void AGKAILBFOLI(Func<Guid, bool> LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3211BF0", Offset = "0x32101F0", VA = "0x183211BF0")]
	public void JHKJJEHNEMN(Func<Guid, bool> FGBCKOEHBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3211760", Offset = "0x320FD60", VA = "0x183211760")]
	public void EIBNCKCDCGJ(Func<Guid, bool> LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x32122F0", Offset = "0x32108F0", VA = "0x1832122F0")]
	public Guid PKFBDKEEJNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3211E40", Offset = "0x3210440", VA = "0x183211E40")]
	public void JKPGAHPCPNP(Guid BMFNECELJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3211130", Offset = "0x320F730", VA = "0x183211130")]
	public void BHIKNFCGNOG(GMKGAFOGKAM ABDPBIPAPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3210F80", Offset = "0x320F580", VA = "0x183210F80")]
	public void AECLFKCPDDB(string MJEMGMKCJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3210E00", Offset = "0x320F400", VA = "0x183210E00")]
	public void AECLFKCPDDB(Func<string> GAPBFEAOPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x32D9680", Offset = "0x32D7C80", VA = "0x1832D9680")]
	private T GJEPPHKPDCN<T>(T MAKFNMHIJIF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x32122A0", Offset = "0x32108A0", VA = "0x1832122A0")]
	public void PKCGEDKPNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x32D9910", Offset = "0x32D7F10", VA = "0x1832D9910")]
	[CompilerGenerated]
	internal static string IOIPPGFEMIB<T>(byte[] PPJLGCLGPJE, int NAHELIKPBDN, ref MJBGDMMOBBL<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class HOALOLHOHAG : EDBOGFBFNEC
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class CBMJGCNGMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public CBMJGCNGMAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x4048150", Offset = "0x4046750", VA = "0x184048150")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct DBNELKDKDAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public HOALOLHOHAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private ABPFELHIMBP <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4049890", Offset = "0x4047E90", VA = "0x184049890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class FPBFHBCFAMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public LLFBHKMOMLO presence;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public FPBFHBCFAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x404C3C0", Offset = "0x404A9C0", VA = "0x18404C3C0")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly ELFALKJEDMF CLPJELHABFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly IKMCGNPFENA GCLFJHJGEML;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private const bool DHCGGEOGJOC = false;

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3210A90", Offset = "0x320F090", VA = "0x183210A90")]
	public HOALOLHOHAG(ELFALKJEDMF CLPJELHABFF, IKMCGNPFENA GCLFJHJGEML, Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3210510", Offset = "0x320EB10", VA = "0x183210510", Slot = "8")]
	[AsyncStateMachine(typeof(DBNELKDKDAG))]
	protected override Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3210660", Offset = "0x320EC60", VA = "0x183210660")]
	private LLFBHKMOMLO JGOJJNLNJMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class GIFBHNANFGH : EDBOGFBFNEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct ANCFHPEDLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public GIFBHNANFGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<GKLDPEEJFFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x4046EC0", Offset = "0x40454C0", VA = "0x184046EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly int IKAOGOGNIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly HFFCNJPOHMD ALLHONMJPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public readonly long GNNGJBMOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public readonly long KDOGLLCFKMJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GKLDPEEJFFM DJFIPBACEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8F0", Offset = "0x7E8EF0", VA = "0x1807EA8F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x84E450", Offset = "0x84CA50", VA = "0x18084E450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x320BC20", Offset = "0x320A220", VA = "0x18320BC20")]
	public GIFBHNANFGH(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK, int IKAOGOGNIKC, HFFCNJPOHMD ALLHONMJPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x320BAE0", Offset = "0x320A0E0", VA = "0x18320BAE0", Slot = "8")]
	[AsyncStateMachine(typeof(ANCFHPEDLHD))]
	protected override Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class COEDPEPNGJH : EDBOGFBFNEC
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class HPEDFABKKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public COEDPEPNGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public MHLOBGAMMHN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HPEDFABKKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x3D15620", Offset = "0x3D13C20", VA = "0x183D15620")]
		internal Task <RunAsync>b__0(GPNAMOIINIG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x3D15660", Offset = "0x3D13C60", VA = "0x183D15660")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct INNEOKFADFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public COEDPEPNGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private HPEDFABKKGJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3D16A60", Offset = "0x3D15060", VA = "0x183D16A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct HPJHMPJMKPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public MHLOBGAMMHN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public COEDPEPNGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x3D156E0", Offset = "0x3D13CE0", VA = "0x183D156E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3201580", Offset = "0x31FFB80", VA = "0x183201580")]
	public COEDPEPNGJH(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK, string MLIAIEHDPMM, OHIGMNLGPGF DMPLKKLCBGL, bool INFNEMAFFLB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x32012D0", Offset = "0x31FF8D0", VA = "0x1832012D0", Slot = "8")]
	[AsyncStateMachine(typeof(INNEOKFADFA))]
	protected override Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task JEICHDBNNJJ(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3201420", Offset = "0x31FFA20", VA = "0x183201420")]
	[AsyncStateMachine(typeof(HPJHMPJMKPH))]
	private Task OOHMNOGCAJF(IDisposable OIHPEGNMAPC, MHLOBGAMMHN LHMDBAPHHCB, GPNAMOIINIG IDKFKDEHFHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class LHONBHMPEJE : EDBOGFBFNEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct MCDEAOOHMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public LHONBHMPEJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public IBAJEEKBPBO operationContext;

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
		private TaskAwaiter<BGFIPODFDAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x4056EA0", Offset = "0x40554A0", VA = "0x184056EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly DJMCEAKDOIN LLJBGAHHCBP;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x3218DB0", Offset = "0x32173B0", VA = "0x183218DB0")]
	public LHONBHMPEJE(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK, DJMCEAKDOIN LLJBGAHHCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x3218CD0", Offset = "0x32172D0", VA = "0x183218CD0", Slot = "7")]
	protected override string JIHNGHFMLNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x3218B90", Offset = "0x3217190", VA = "0x183218B90", Slot = "8")]
	[AsyncStateMachine(typeof(MCDEAOOHMEI))]
	protected override Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal abstract class EDBOGFBFNEC : EIPKADAOJJH
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task ONOOMGEGHDI(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class KLNGANOIAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public GPNAMOIINIG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public EDBOGFBFNEC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KLNGANOIAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3D19EF0", Offset = "0x3D184F0", VA = "0x183D19EF0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class ILDENIDAAON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public KLNGANOIAAF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ILDENIDAAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x3D15C70", Offset = "0x3D14270", VA = "0x183D15C70")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x3D15D30", Offset = "0x3D14330", VA = "0x183D15D30")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct DHLIGFHLJOJ : IAsyncStateMachine
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
		public EDBOGFBFNEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<EDBOGFBFNEC, GPNAMOIINIG, IBAJEEKBPBO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private KLNGANOIAAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private IBAJEEKBPBO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x3D114C0", Offset = "0x3D0FAC0", VA = "0x183D114C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct JEGNDJELAAD : IAsyncStateMachine
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
		public EDBOGFBFNEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x3D18E30", Offset = "0x3D17430", VA = "0x183D18E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public readonly Guid DFKLDECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public readonly ByteString FEOHDIMEIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly GMCFJEBBKEC CLJLMAJICBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	protected readonly string COFHODCGOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly bool INFNEMAFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly Queue<ONOOMGEGHDI> MKOAKAKOMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly IKHDPONDBON NJMBNCMMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly OHIGMNLGPGF DMPLKKLCBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private bool EHOGJONDIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public DOIAGHFMBCN AILJLEHCDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public DOIAGHFMBCN JEIPIHLMIHJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PEHFLLKFGNK EHKDPFOHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x3205AA0", Offset = "0x32040A0", VA = "0x183205AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HOCHNEAIGFA FJNLIOLILEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x3205910", Offset = "0x3203F10", VA = "0x183205910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3205C90", Offset = "0x3204290", VA = "0x183205C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x3205C30", Offset = "0x3204230", VA = "0x183205C30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x3205C50", Offset = "0x3204250", VA = "0x183205C50", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x32054D0", Offset = "0x3203AD0", VA = "0x1832054D0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x3205D10", Offset = "0x3204310", VA = "0x183205D10")]
	protected EDBOGFBFNEC(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK, string MLIAIEHDPMM, OHIGMNLGPGF DMPLKKLCBGL, bool INFNEMAFFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x32058D0", Offset = "0x3203ED0", VA = "0x1832058D0", Slot = "7")]
	protected virtual string JIHNGHFMLNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3205BD0", Offset = "0x32041D0", VA = "0x183205BD0")]
	public void MAFHCLELFEB(ONOOMGEGHDI HNGFGENHHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x3205C70", Offset = "0x3204270", VA = "0x183205C70")]
	protected void PMELKEJBFNP(float GODDPHBMKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x3205300", Offset = "0x3203900", VA = "0x183205300")]
	[AsyncStateMachine(typeof(DHLIGFHLJOJ))]
	public Task BABMLJMPJCC(CancellationToken JLIEBAENBAG, GPNAMOIINIG AEKLGCBMNDP, [Optional] Func<EDBOGFBFNEC, GPNAMOIINIG, IBAJEEKBPBO> HNJBKAGHFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x3205740", Offset = "0x3203D40", VA = "0x183205740")]
	private void HNJNAJKOKOL(bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x32054F0", Offset = "0x3203AF0", VA = "0x1832054F0")]
	private void GMCJJNNJOMB(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x3205960", Offset = "0x3203F60", VA = "0x183205960")]
	[AsyncStateMachine(typeof(JEGNDJELAAD))]
	private Task KLFFIBHCLGE(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3205450", Offset = "0x3203A50", VA = "0x183205450")]
	public GMKGAFOGKAM BPEFEKAOCLF(FFFPMBNIKKG BBKFHFEGMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3205AF0", Offset = "0x32040F0", VA = "0x183205AF0")]
	[CompilerGenerated]
	private Task LOCDOHGBOKG(CancellationToken KHJLEOILJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal sealed class JFOPOABGIIB : COEDPEPNGJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct MOFMNIAACOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public JFOPOABGIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private OGHDDJALHCM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private ABPFELHIMBP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x4058270", Offset = "0x4056870", VA = "0x184058270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly ELFALKJEDMF CAIJKBPCMEF;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3213C60", Offset = "0x3212260", VA = "0x183213C60")]
	public JFOPOABGIIB(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, ELFALKJEDMF CAIJKBPCMEF, GMCFJEBBKEC GFNHOIINPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x3213B10", Offset = "0x3212110", VA = "0x183213B10", Slot = "9")]
	[AsyncStateMachine(typeof(MOFMNIAACOP))]
	protected override Task JEICHDBNNJJ(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class GAGNIALMBPB : EDBOGFBFNEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct CJMGKFJBIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public GAGNIALMBPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter<BGFIPODFDAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x4049570", Offset = "0x4047B70", VA = "0x184049570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly string EOJFFLKNAKN;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x32081D0", Offset = "0x32067D0", VA = "0x1832081D0")]
	public GAGNIALMBPB(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, GMCFJEBBKEC GFNHOIINPPK, string EOJFFLKNAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x32080A0", Offset = "0x32066A0", VA = "0x1832080A0", Slot = "8")]
	[AsyncStateMachine(typeof(CJMGKFJBIGE))]
	protected override Task GBMOPGBLFBN(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class OPKPKLIIBHD : COEDPEPNGJH
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class FJEODGLLBCM
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
			public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public FJEODGLLBCM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private TaskAwaiter<BGFIPODFDAA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter<GMKGAFOGKAM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x4A56AB0", Offset = "0x4A550B0", VA = "0x184A56AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x4A56E00", Offset = "0x4A55400", VA = "0x184A56E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public OPKPKLIIBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public HJLMGKGCMMH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public POOLDNGHOFB uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public FJEODGLLBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x4A4ED50", Offset = "0x4A4D350", VA = "0x184A4ED50")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GMKGAFOGKAM> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct EPPBGFKPIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public OPKPKLIIBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private FJEODGLLBCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private OGHDDJALHCM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private ABPFELHIMBP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x4A4DD70", Offset = "0x4A4C370", VA = "0x184A4DD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly int NJHGAFMAJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[CanBeNull]
	private readonly BFMPILHPOIM NHIKBCCKBML;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x3D21FD0", Offset = "0x3D205D0", VA = "0x183D21FD0")]
	public OPKPKLIIBHD(Guid KAOFPCAFLFA, PEHFLLKFGNK GHBIGIEEHOO, int NJHGAFMAJCP, BFMPILHPOIM NHIKBCCKBML, GMCFJEBBKEC GFNHOIINPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x3D21E70", Offset = "0x3D20470", VA = "0x183D21E70", Slot = "9")]
	[AsyncStateMachine(typeof(EPPBGFKPIPG))]
	protected override Task JEICHDBNNJJ(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3D21BE0", Offset = "0x3D201E0", VA = "0x183D21BE0")]
	private void DCBEMJHOEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x3D21CD0", Offset = "0x3D202D0", VA = "0x183D21CD0")]
	private void EDGKLAOGCKL(GPNAMOIINIG AEKLGCBMNDP, OGHDDJALHCM CPFIFGNPGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal abstract class JPPAACMPEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly EDBOGFBFNEC EJCDLMHEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public readonly IBAJEEKBPBO DNLNGICLNCI;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x3214A00", Offset = "0x3213000", VA = "0x183214A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x3214A50", Offset = "0x3213050", VA = "0x183214A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x3214AE0", Offset = "0x32130E0", VA = "0x183214AE0")]
	protected JPPAACMPEPO(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x32149E0", Offset = "0x3212FE0", VA = "0x1832149E0")]
	protected void AECLFKCPDDB(string MJEMGMKCJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x3214850", Offset = "0x3212E50", VA = "0x183214850")]
	public void AECLFKCPDDB(Func<string> GAPBFEAOPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct BFKCGCEHIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public Dictionary<Guid, List<ECJAEBIEAEH>> ELHLJMJNBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public Dictionary<Guid, List<ECJAEBIEAEH>> DCMONBHLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<ECJAEBIEAEH>> HPPCBMPJIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public List<Guid> EJDPPKLELOA;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x31FE5C0", Offset = "0x31FCBC0", VA = "0x1831FE5C0")]
	public static BFKCGCEHIAN DNJGGIFCOKL(EEOMMJMOFEO NBJJAAKBODP, DOIAGHFMBCN MALLILCMKNC, EMLPMBHPMDM MMBHGDNIOAO)
	{
		return default(BFKCGCEHIAN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct OIFMBEKKNOF
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
	public static OIFMBEKKNOF CBFHJGEFJHE()
	{
		return default(OIFMBEKKNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DFBBAENAMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FENHOKECDMB(EMLPMBHPMDM JIHCLPECHIB, object AEABGDOMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DDKDHFAKAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct AJHGDDIACKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly KFMOMBKGPMO FPDMMMILDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly ANINOEMMMNA MLMAHLBCOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly LIHDCPPHNOK OBFHICHOBMG;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x31FA0F0", Offset = "0x31F86F0", VA = "0x1831FA0F0")]
	public AJHGDDIACKC(KFMOMBKGPMO FPDMMMILDCI, ANINOEMMMNA MLMAHLBCOLO, LIHDCPPHNOK OBFHICHOBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct IENNCIDDMHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private readonly IBAJEEKBPBO GPEMNCAIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private readonly Guid BMFNECELJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private bool HEOPHCHJMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x3212B80", Offset = "0x3211180", VA = "0x183212B80")]
	public static IENNCIDDMHC PKFBDKEEJNI(IBAJEEKBPBO GPEMNCAIHFB)
	{
		return default(IENNCIDDMHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xFB3BE0", Offset = "0xFB21E0", VA = "0x180FB3BE0")]
	public void PMMMABLEBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x3212790", Offset = "0x3210D90", VA = "0x183212790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x3212BB0", Offset = "0x32111B0", VA = "0x183212BB0")]
	private IENNCIDDMHC(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x32127A0", Offset = "0x3210DA0", VA = "0x1832127A0")]
	private void JKPGAHPCPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x3212AD0", Offset = "0x32110D0", VA = "0x183212AD0")]
	private Func<Guid, bool> NINHPNMDBFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class ABPFELHIMBP : JPPAACMPEPO, EIPKADAOJJH
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public delegate Task<DOIAGHFMBCN> IOPENGFLKPH(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH BKKLLEBHDLN, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct HNJGLEPBFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public ELFALKJEDMF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private IENNCIDDMHC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D15290", Offset = "0x3D13890", VA = "0x183D15290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct MLEIDMJMEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public ELFALKJEDMF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private GPNAMOIINIG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C470", Offset = "0x3D1AA70", VA = "0x183D1C470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C790", Offset = "0x3D1AD90", VA = "0x183D1C790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct NFBJIGBGNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public ELFALKJEDMF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private GPNAMOIINIG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E950", Offset = "0x3D1CF50", VA = "0x183D1E950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class ALEKLKICGOG
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
			public AsyncTaskMethodBuilder<AJHGDDIACKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public ALEKLKICGOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private AJHGDDIACKC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<DOIAGHFMBCN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<AJHGDDIACKC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4A55800", Offset = "0x4A53E00", VA = "0x184A55800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x4A55E10", Offset = "0x4A54410", VA = "0x184A55E10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EMLPMBHPMDM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public ALEKLKICGOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private EMLPMBHPMDM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<DOIAGHFMBCN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private TaskAwaiter<EMLPMBHPMDM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x4A55E60", Offset = "0x4A54460", VA = "0x184A55E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x4A56390", Offset = "0x4A54990", VA = "0x184A56390", Slot = "5")]
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
			public ALEKLKICGOG <>4__this;

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
			private TaskAwaiter<DOIAGHFMBCN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private ILFLJKJJHHH <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x4A54400", Offset = "0x4A52A00", VA = "0x184A54400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public ELFALKJEDMF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public IKHDPONDBON preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public IKHDPONDBON downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public AJHGDDIACKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public IKHDPONDBON postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public EMLPMBHPMDM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public PIFGAANHEEL.NEKFKEKLDFG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ALEKLKICGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EF90", Offset = "0x3D0D590", VA = "0x183D0EF90")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<AJHGDDIACKC> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F0D0", Offset = "0x3D0D6D0", VA = "0x183D0F0D0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<EMLPMBHPMDM> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F210", Offset = "0x3D0D810", VA = "0x183D0F210")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EE60", Offset = "0x3D0D460", VA = "0x183D0EE60")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct PGIBHMALPOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public ELFALKJEDMF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private ALEKLKICGOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<AJHGDDIACKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter<EMLPMBHPMDM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D22080", Offset = "0x3D20680", VA = "0x183D22080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JHNNBAMEHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D190C0", Offset = "0x3D176C0", VA = "0x183D190C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct EFMPIHDHHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private GPNAMOIINIG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D12550", Offset = "0x3D10B50", VA = "0x183D12550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct CBAPMAKPEFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private GPNAMOIINIG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FDC0", Offset = "0x3D0E3C0", VA = "0x183D0FDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D10860", Offset = "0x3D0EE60", VA = "0x183D10860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct FKMAFKFIKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private GPNAMOIINIG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D13460", Offset = "0x3D11A60", VA = "0x183D13460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D14010", Offset = "0x3D12610", VA = "0x183D14010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct EKIEIDKAEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DOIAGHFMBCN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public EMLPMBHPMDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D12B00", Offset = "0x3D11100", VA = "0x183D12B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D12D00", Offset = "0x3D11300", VA = "0x183D12D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class JCOLLKGPIII
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
			public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public JCOLLKGPIII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<DOIAGHFMBCN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x4A563E0", Offset = "0x4A549E0", VA = "0x184A563E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4A56920", Offset = "0x4A54F20", VA = "0x184A56920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public IOPENGFLKPH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public DOIAGHFMBCN originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JCOLLKGPIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D18C90", Offset = "0x3D17290", VA = "0x183D18C90")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DOIAGHFMBCN> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct LECIPILNDOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public IOPENGFLKPH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A000", Offset = "0x3D18600", VA = "0x183D1A000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A4A0", Offset = "0x3D18AA0", VA = "0x183D1A4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct HBGPKKALGIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public IKHDPONDBON progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private DOIAGHFMBCN <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private IEnumerator<DOIAGHFMBCN> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D14EB0", Offset = "0x3D134B0", VA = "0x183D14EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct BICLLEKBOEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F840", Offset = "0x3D0DE40", VA = "0x183D0F840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FPOIBDHBBCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public PEHFLLKFGNK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D14060", Offset = "0x3D12660", VA = "0x183D14060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct OFKEAGEHGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public ABPFELHIMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D209F0", Offset = "0x3D1EFF0", VA = "0x183D209F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class EKPDMHFAOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public KFMOMBKGPMO roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EKPDMHFAOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D12D50", Offset = "0x3D11350", VA = "0x183D12D50")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly MFNIHNNDJBP JCANBMFNNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly MFNIHNNDJBP IPHDMBLKJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly PIJBHNICAJC EKNHNIJMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly FCJJEHPENEJ ACOMPMEACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly DDOOEJNDDGD HBEOPALGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly MNFBCLMGCPE CLLFJPMLLAF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x31F8550", Offset = "0x31F6B50", VA = "0x1831F8550", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private PEHFLLKFGNK EHKDPFOHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x31F7030", Offset = "0x31F5630", VA = "0x1831F7030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x31F8570", Offset = "0x31F6B70", VA = "0x1831F8570", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x31F7AA0", Offset = "0x31F60A0", VA = "0x1831F7AA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x31F8AE0", Offset = "0x31F70E0", VA = "0x1831F8AE0")]
	public ABPFELHIMBP(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x31F71C0", Offset = "0x31F57C0", VA = "0x1831F71C0")]
	[AsyncStateMachine(typeof(HNJGLEPBFHL))]
	public Task DFGLNNOFIJC(ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, bool IPHLHKMEPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x31F77D0", Offset = "0x31F5DD0", VA = "0x1831F77D0")]
	[AsyncStateMachine(typeof(MLEIDMJMEMB))]
	private Task<GMKGAFOGKAM> GBKOBAJFDPN(ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x31F8590", Offset = "0x31F6B90", VA = "0x1831F8590")]
	[AsyncStateMachine(typeof(NFBJIGBGNMG))]
	private Task MPMAFGKFOKB(ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, bool IPHLHKMEPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x31F6ED0", Offset = "0x31F54D0", VA = "0x1831F6ED0")]
	[AsyncStateMachine(typeof(PGIBHMALPOJ))]
	private Task AMLMLKILBMH(ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken HNBFGEDEOAO, bool IPHLHKMEPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x31F7E50", Offset = "0x31F6450", VA = "0x1831F7E50")]
	[AsyncStateMachine(typeof(JHNNBAMEHJF))]
	private Task JNHIHMPGHIG(GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x31F7520", Offset = "0x31F5B20", VA = "0x1831F7520")]
	[AsyncStateMachine(typeof(EFMPIHDHHPI))]
	private Task FFGGBJJEEAC(EMLPMBHPMDM JIHCLPECHIB, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x31F8200", Offset = "0x31F6800", VA = "0x1831F8200")]
	[AsyncStateMachine(typeof(CBAPMAKPEFP))]
	private Task<DOIAGHFMBCN> MGKJNDAJION(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x31F8850", Offset = "0x31F6E50", VA = "0x1831F8850")]
	[AsyncStateMachine(typeof(FKMAFKFIKLA))]
	private Task<DOIAGHFMBCN> OBMKGEODLBO(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x31F7350", Offset = "0x31F5950", VA = "0x1831F7350")]
	[AsyncStateMachine(typeof(EKIEIDKAEHC))]
	private Task<DOIAGHFMBCN> EHMKEFFPDNM(DOIAGHFMBCN MALLILCMKNC, EMLPMBHPMDM MMBHGDNIOAO, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, bool CODDPMLIKHM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x31F89F0", Offset = "0x31F6FF0", VA = "0x1831F89F0")]
	private bool OPGNCALJMFL(EMLPMBHPMDM PGAFCLNIKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x31F8380", Offset = "0x31F6980", VA = "0x1831F8380")]
	[AsyncStateMachine(typeof(LECIPILNDOD))]
	protected Task<DOIAGHFMBCN> MKKPDNDOGFH(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, IOPENGFLKPH MCIIJKCEIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x31F7B10", Offset = "0x31F6110", VA = "0x1831F7B10")]
	[AsyncStateMachine(typeof(HBGPKKALGIE))]
	private Task IAEOJPCOCFP(EMLPMBHPMDM JIHCLPECHIB, IKHDPONDBON FMFPLOJMGJM, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x31F7AC0", Offset = "0x31F60C0", VA = "0x1831F7AC0")]
	private void HEGIDJKOJLJ(DOIAGHFMBCN ACKEPFLBACL, IKHDPONDBON FMFPLOJMGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x31F74E0", Offset = "0x31F5AE0", VA = "0x1831F74E0")]
	private void FDKNELHDDKL(DOIAGHFMBCN DOODACODENF, out DOIAGHFMBCN MHNANPLCJEO, out DOIAGHFMBCN HOIGLFCFFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x31F7C70", Offset = "0x31F6270", VA = "0x1831F7C70")]
	private Task<AJHGDDIACKC> IKLFNAPDHHM(ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x31F6E80", Offset = "0x31F5480", VA = "0x1831F6E80")]
	private Task<EMLPMBHPMDM> AIMPGLCGOAL(ELFALKJEDMF GHNJJOLFHLE, AJHGDDIACKC JIHCLPECHIB, PIFGAANHEEL.NEKFKEKLDFG JELIMPCBNBL, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x31F7680", Offset = "0x31F5C80", VA = "0x1831F7680")]
	[AsyncStateMachine(typeof(BICLLEKBOEI))]
	private Task FJJJJAIONMN(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x31F7CD0", Offset = "0x31F62D0", VA = "0x1831F7CD0")]
	[AsyncStateMachine(typeof(FPOIBDHBBCB))]
	private Task IPMLNCDHJKH(EMLPMBHPMDM JIHCLPECHIB, PEHFLLKFGNK GHBIGIEEHOO, GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x31F7F80", Offset = "0x31F6580", VA = "0x1831F7F80")]
	[AsyncStateMachine(typeof(OFKEAGEHGKL))]
	private Task KDBIKDFBHAL(EMLPMBHPMDM JIHCLPECHIB, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x31F7320", Offset = "0x31F5920", VA = "0x1831F7320")]
	private Task EDFHOHCCAAD(EMLPMBHPMDM JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x31F7060", Offset = "0x31F5660", VA = "0x1831F7060")]
	private Task BGGJCKGFKCN(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x31F7950", Offset = "0x31F5F50", VA = "0x1831F7950")]
	private Task GFLAIOCDIMA(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x31F8530", Offset = "0x31F6B30", VA = "0x1831F8530")]
	private Task MMMLNMNLKJH(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x31F6D60", Offset = "0x31F5360", VA = "0x1831F6D60")]
	private static Task FBJAIFGEPHL(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x31F86F0", Offset = "0x31F6CF0", VA = "0x1831F86F0")]
	private Task NMBMELIOFIG(EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x31F7CB0", Offset = "0x31F62B0", VA = "0x1831F7CB0")]
	private Task IMODJPLFDBH(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x31F7E20", Offset = "0x31F6420", VA = "0x1831F7E20")]
	private void JLAFNMFHFCP(ELFALKJEDMF GHNJJOLFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x31F80A0", Offset = "0x31F66A0", VA = "0x1831F80A0")]
	private static void LHBGFHILOOE(KFMOMBKGPMO FPDMMMILDCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct BOJGJOMFNNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private DOIAGHFMBCN ACKEPFLBACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private EMLPMBHPMDM JIHCLPECHIB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3200100", Offset = "0x31FE700", VA = "0x183200100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x3200150", Offset = "0x31FE750", VA = "0x183200150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3200050", Offset = "0x31FE650", VA = "0x183200050")]
	public static Task BABMLJMPJCC(PEHFLLKFGNK GHBIGIEEHOO, DOIAGHFMBCN ACKEPFLBACL, EMLPMBHPMDM JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x31FFE00", Offset = "0x31FE400", VA = "0x1831FFE00")]
	private void BABMLJMPJCC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct AABCOKMFBIL
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x31F6D60", Offset = "0x31F5360", VA = "0x1831F6D60")]
	public static Task BABMLJMPJCC(CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct NMHJBNOHDEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct EAADKCEEEHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private GPNAMOIINIG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D910", Offset = "0x4A4BF10", VA = "0x184A4D910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F430", Offset = "0x3D1DA30", VA = "0x183D1F430")]
	[AsyncStateMachine(typeof(EAADKCEEEHN))]
	public static Task BABMLJMPJCC(IBAJEEKBPBO GPEMNCAIHFB, EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct OEIFENPJIII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct BJCEHEMAFBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private DOIAGHFMBCN <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private PEHFLLKFGNK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private EEOMMJMOFEO <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private List<(PersistenceView, DACGKLHBLIE)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private DACGKLHBLIE <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4A49FA0", Offset = "0x4A485A0", VA = "0x184A49FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F5E0", Offset = "0x3D1DBE0", VA = "0x183D1F5E0")]
	[AsyncStateMachine(typeof(BJCEHEMAFBA))]
	public static Task BABMLJMPJCC(IBAJEEKBPBO GPEMNCAIHFB, EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F750", Offset = "0x3D1DD50", VA = "0x183D1F750")]
	private static void NEIKDIJILLG(PersistenceView EDNIAMBKPNL, DACGKLHBLIE AEABGDOMKJP, EMLPMBHPMDM JIHCLPECHIB, DOIAGHFMBCN MALLILCMKNC, bool NNGLFCJLIBL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct GPAKGALIDEC
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x320C2E0", Offset = "0x320A8E0", VA = "0x18320C2E0")]
	public static Task BABMLJMPJCC(PEHFLLKFGNK GHBIGIEEHOO, EMLPMBHPMDM JIHCLPECHIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct DNJMDBLDGMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct CEGDFEAJIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public PEHFLLKFGNK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D108B0", Offset = "0x3D0EEB0", VA = "0x183D108B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct IPEEEKPDAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public DNJMDBLDGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D17750", Offset = "0x3D15D50", VA = "0x183D17750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class GAKJCBLOAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public KECCLNDCEEL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GAKJCBLOAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D141B0", Offset = "0x3D127B0", VA = "0x183D141B0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D14290", Offset = "0x3D12890", VA = "0x183D14290")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private EMLPMBHPMDM JIHCLPECHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private IBAJEEKBPBO GPEMNCAIHFB;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString DDNEDHAOKPL;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x32048E0", Offset = "0x3202EE0", VA = "0x1832048E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private FIFNNJLDKCI GCMHDCOLCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3205000", Offset = "0x3203600", VA = "0x183205000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3204640", Offset = "0x3202C40", VA = "0x183204640")]
	[AsyncStateMachine(typeof(CEGDFEAJIPP))]
	public static Task BABMLJMPJCC(PEHFLLKFGNK GHBIGIEEHOO, DOIAGHFMBCN ACKEPFLBACL, EMLPMBHPMDM JIHCLPECHIB, IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x32047A0", Offset = "0x3202DA0", VA = "0x1832047A0")]
	[AsyncStateMachine(typeof(IPEEEKPDAFK))]
	private Task BABMLJMPJCC(GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3204930", Offset = "0x3202F30", VA = "0x183204930")]
	private void NBEONAOJCJK([NotNull] CIFBNNGALCD HIFOLPKANOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3204FD0", Offset = "0x32035D0", VA = "0x183204FD0")]
	private bool NKJCILBHNIM(KECCLNDCEEL AJGHIJIKOBE, CIFBNNGALCD HIFOLPKANOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct BJLDIHMGPAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct INLAOHHKOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder<EMLPMBHPMDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public BJLDIHMGPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public PIFGAANHEEL.NEKFKEKLDFG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private GPNAMOIINIG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter<(global::IKEELLNFFOM<MAHIAFPEFOP, IHHGNGPIMCG>, global::IKEELLNFFOM<global::BNHPJFPNMAO<CIFBNNGALCD>, IHHGNGPIMCG>, global::IKEELLNFFOM<global::BNHPJFPNMAO<PBAIJGCAICP>, IHHGNGPIMCG>, global::IKEELLNFFOM<global::BNHPJFPNMAO<GKPJHGOMINL>, IHHGNGPIMCG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x3D16150", Offset = "0x3D14750", VA = "0x183D16150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x3D16A10", Offset = "0x3D15010", VA = "0x183D16A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct LHJHBOMGFNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder<global::IKEELLNFFOM<MAHIAFPEFOP, IHHGNGPIMCG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GPNAMOIINIG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public BJLDIHMGPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public PIFGAANHEEL.NEKFKEKLDFG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private GPNAMOIINIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<global::IKEELLNFFOM<MAHIAFPEFOP, IHHGNGPIMCG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A4F0", Offset = "0x3D18AF0", VA = "0x183D1A4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A9E0", Offset = "0x3D18FE0", VA = "0x183D1A9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private global::IIAAFKEDLDP<LLGMLEHJMCJ, PBAIJGCAICP> MPLAFJFJPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private global::IIAAFKEDLDP<LLGMLEHJMCJ, CIFBNNGALCD> MLMAHLBCOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private global::IIAAFKEDLDP<long, GKPJHGOMINL> DCMEFNIHHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private EFFCJBEKFIH NGCFOMJPPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private ELFALKJEDMF GHNJJOLFHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private KFMOMBKGPMO FPDMMMILDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private ANINOEMMMNA KMIEJIAMDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private long HBFDFDGJDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private GPNAMOIINIG IDKFKDEHFHM;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x31FEE60", Offset = "0x31FD460", VA = "0x1831FEE60")]
	public static Task<EMLPMBHPMDM> BNBGMJOFDBD(PEHFLLKFGNK GHBIGIEEHOO, ELFALKJEDMF GHNJJOLFHLE, in AJHGDDIACKC JIHCLPECHIB, PIFGAANHEEL.NEKFKEKLDFG JELIMPCBNBL, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x31FECF0", Offset = "0x31FD2F0", VA = "0x1831FECF0")]
	[AsyncStateMachine(typeof(INLAOHHKOHM))]
	private Task<EMLPMBHPMDM> BABMLJMPJCC(PIFGAANHEEL.NEKFKEKLDFG JELIMPCBNBL, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x31FF330", Offset = "0x31FD930", VA = "0x1831FF330")]
	private LLGMLEHJMCJ OOFEPMABPOC(ACFDLHGLMKA CCCHGKBILHH)
	{
		return default(LLGMLEHJMCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x31FF180", Offset = "0x31FD780", VA = "0x1831FF180")]
	[AsyncStateMachine(typeof(LHJHBOMGFNF))]
	private Task<global::IKEELLNFFOM<MAHIAFPEFOP, IHHGNGPIMCG>> KODMAEKNIDF(string LKJJAKMJOKN, long HBFDFDGJDBK, PIFGAANHEEL.NEKFKEKLDFG JELIMPCBNBL, GPNAMOIINIG ADFPLALBEOD, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal struct LHNEAGHBPIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct DPILLCKMAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<AJHGDDIACKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public LHNEAGHBPIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private GPNAMOIINIG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<AJHGDDIACKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x404B0F0", Offset = "0x40496F0", VA = "0x18404B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x404B5A0", Offset = "0x4049BA0", VA = "0x18404B5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct EMDLIMIHDHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<AJHGDDIACKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public LHNEAGHBPIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter<AJHGDDIACKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x404BAF0", Offset = "0x404A0F0", VA = "0x18404BAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x404BCE0", Offset = "0x404A2E0", VA = "0x18404BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class KLBDKHOOMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KLBDKHOOMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x1C8D050", Offset = "0x1C8B650", VA = "0x181C8D050")]
		internal bool <FetchRoomDetails>b__0(ANINOEMMMNA sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct JIGLMAJDOIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder<AJHGDDIACKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public EEOMMJMOFEO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private KLBDKHOOMCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter<KFMOMBKGPMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x4053260", Offset = "0x4051860", VA = "0x184053260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x40537A0", Offset = "0x4051DA0", VA = "0x1840537A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private PIJBHNICAJC EKNHNIJMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private GPNAMOIINIG IDKFKDEHFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private long FAFDJINDEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private long BJDHMPBAACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private string AJDNMAOBHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private LLGMLEHJMCJ COBNEJNNEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private LLGMLEHJMCJ JNNOIPHDKIA;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x32182B0", Offset = "0x32168B0", VA = "0x1832182B0")]
	public static Task<AJHGDDIACKC> BNBGMJOFDBD(PEHFLLKFGNK GHBIGIEEHOO, ELFALKJEDMF GHNJJOLFHLE, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3218150", Offset = "0x3216750", VA = "0x183218150")]
	[AsyncStateMachine(typeof(DPILLCKMAGG))]
	private Task<AJHGDDIACKC> BABMLJMPJCC(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x32189D0", Offset = "0x3216FD0", VA = "0x1832189D0")]
	[AsyncStateMachine(typeof(EMDLIMIHDHO))]
	private Task<AJHGDDIACKC> IKLFNAPDHHM(long FAFDJINDEIN, long BJDHMPBAACC, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, bool EODDKIIALLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3218850", Offset = "0x3216E50", VA = "0x183218850")]
	[AsyncStateMachine(typeof(JIGLMAJDOIM))]
	public static Task<AJHGDDIACKC> IKLFNAPDHHM(EEOMMJMOFEO NBJJAAKBODP, long FAFDJINDEIN, long BJDHMPBAACC, CancellationToken JLIEBAENBAG, GPNAMOIINIG AEKLGCBMNDP, bool EODDKIIALLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3218B60", Offset = "0x3217160", VA = "0x183218B60")]
	private void NMLKAANCLOF(KFMOMBKGPMO FPDMMMILDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3218540", Offset = "0x3216B40", VA = "0x183218540")]
	private bool EBLCCGHMJEE(AJHGDDIACKC JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x32186B0", Offset = "0x3216CB0", VA = "0x1832186B0")]
	private void IIOCIFDONPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct KDKPBGCICBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct OACIKGLBIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public KDKPBGCICBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x4059C20", Offset = "0x4058220", VA = "0x184059C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private const int CABBMGLJHOL = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private const float EGICMCFFFHJ = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private EEOMMJMOFEO NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EMLPMBHPMDM JIHCLPECHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private GPNAMOIINIG IDKFKDEHFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private float FKPGHOPEANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private float IIJHGMLFKDK;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x3216C60", Offset = "0x3215260", VA = "0x183216C60")]
	public static Task LJBGFKAFHPI(PEHFLLKFGNK GHBIGIEEHOO, EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x32168D0", Offset = "0x3214ED0", VA = "0x1832168D0")]
	[AsyncStateMachine(typeof(OACIKGLBIBO))]
	public Task BABMLJMPJCC(CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x3216A00", Offset = "0x3215000", VA = "0x183216A00")]
	private static void DOHDDBMLPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x3216E00", Offset = "0x3215400", VA = "0x183216E00")]
	private void MNEAGIPOKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x3216BA0", Offset = "0x32151A0", VA = "0x183216BA0")]
	private static float JPNBLDOPGON(EEOMMJMOFEO NBJJAAKBODP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x3216FD0", Offset = "0x32155D0", VA = "0x183216FD0")]
	private static float PLHDLPACKLN()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct KBBCIINCAHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct JNKAOJEDKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public IBAJEEKBPBO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private EDBOGFBFNEC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private PEHFLLKFGNK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private GCFFDDPMMNL.EKFLDOMHHLI <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x4054550", Offset = "0x4052B50", VA = "0x184054550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct MLAAGGPHIGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private EFCOJEFBPIL.HJJIMAIFKEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x4057FC0", Offset = "0x40565C0", VA = "0x184057FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x3214B40", Offset = "0x3213140", VA = "0x183214B40")]
	[AsyncStateMachine(typeof(JNKAOJEDKIH))]
	public static Task BABMLJMPJCC(IBAJEEKBPBO GPEMNCAIHFB, EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x3214CA0", Offset = "0x32132A0", VA = "0x183214CA0")]
	private static Task<GMKGAFOGKAM> NKMABHJNOBJ(IBAJEEKBPBO GPEMNCAIHFB, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x3214E40", Offset = "0x3213440", VA = "0x183214E40")]
	[AsyncStateMachine(typeof(MLAAGGPHIGI))]
	private static Task PKHBBJOMANE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct BCAJLPCFMIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct DCOHEMMEJIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public BCAJLPCFMIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x3D10F80", Offset = "0x3D0F580", VA = "0x183D10F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class GOJABKNMGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GOJABKNMGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3D14E30", Offset = "0x3D13430", VA = "0x183D14E30")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct GNGGJADLPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public BCAJLPCFMIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private PHLOFEOPBJB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x3D148E0", Offset = "0x3D12EE0", VA = "0x183D148E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private bool HAJDNFLHPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private GPNAMOIINIG IDKFKDEHFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CancellationToken JLIEBAENBAG;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x31FD480", Offset = "0x31FBA80", VA = "0x1831FD480")]
	public static Task DGALEELANFI(PEHFLLKFGNK GHBIGIEEHOO, bool HAJDNFLHPDF, GPNAMOIINIG IDKFKDEHFHM, CancellationToken FMLAIOLNLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x31FD370", Offset = "0x31FB970", VA = "0x1831FD370")]
	[AsyncStateMachine(typeof(DCOHEMMEJIE))]
	private Task BABMLJMPJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x31FD4F0", Offset = "0x31FBAF0", VA = "0x1831FD4F0")]
	[AsyncStateMachine(typeof(GNGGJADLPKL))]
	private Task GOMAIIPHMFP(bool LFOMIKJHJFO, string NILDNJGDILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
	private bool PGHKPPOKLPA(bool HAJDNFLHPDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct GCHGAOGDFOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct GLIPHIOONKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public GCHGAOGDFOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x404DEC0", Offset = "0x404C4C0", VA = "0x18404DEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x404E310", Offset = "0x404C910", VA = "0x18404E310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class EKJCEFMHLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EKJCEFMHLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x404BAA0", Offset = "0x404A0A0", VA = "0x18404BAA0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct PANFMHICCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public GCHGAOGDFOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private PHLOFEOPBJB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x405AAB0", Offset = "0x40590B0", VA = "0x18405AAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x405AFF0", Offset = "0x40595F0", VA = "0x18405AFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private LIHDCPPHNOK CNOJOJNCDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private GPNAMOIINIG IDKFKDEHFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private bool NPCAMCHDOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private EMLPMBHPMDM JIHCLPECHIB;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x320A620", Offset = "0x3208C20", VA = "0x18320A620")]
	public static Task<Scene> OGFBJOIHPJK(PEHFLLKFGNK GHBIGIEEHOO, LIHDCPPHNOK DMKPAOCODLP, GPNAMOIINIG IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x320A240", Offset = "0x3208840", VA = "0x18320A240")]
	public static Task<Scene> AONPPABOCHC(PEHFLLKFGNK GHBIGIEEHOO, EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x320A2E0", Offset = "0x32088E0", VA = "0x18320A2E0")]
	[AsyncStateMachine(typeof(GLIPHIOONKM))]
	private Task<Scene> BABMLJMPJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x320A480", Offset = "0x3208A80", VA = "0x18320A480")]
	private bool GKFMFBHOIJI(EMLPMBHPMDM JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x320A410", Offset = "0x3208A10", VA = "0x18320A410")]
	private void FAIOOKLPNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x320A4C0", Offset = "0x3208AC0", VA = "0x18320A4C0")]
	[AsyncStateMachine(typeof(PANFMHICCGC))]
	private Task<Scene> GOMAIIPHMFP(string NILDNJGDILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct DDOOEJNDDGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct OIMMPFGBPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public DDOOEJNDDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public DOIAGHFMBCN nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public EMLPMBHPMDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private GPNAMOIINIG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<DOIAGHFMBCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x3D20BB0", Offset = "0x3D1F1B0", VA = "0x183D20BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3D21260", Offset = "0x3D1F860", VA = "0x183D21260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct AAMNGGIHMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<DOIAGHFMBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public DDOOEJNDDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public DOIAGHFMBCN state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EB90", Offset = "0x3D0D190", VA = "0x183D0EB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EE10", Offset = "0x3D0D410", VA = "0x183D0EE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly IBAJEEKBPBO GPEMNCAIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private readonly PIJBHNICAJC EKNHNIJMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private readonly FCJJEHPENEJ ACOMPMEACNE;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private EDBOGFBFNEC EJCDLMHEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xC29F10", Offset = "0xC28510", VA = "0x180C29F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x32038F0", Offset = "0x3201EF0", VA = "0x1832038F0")]
	public DDOOEJNDDGD(IBAJEEKBPBO GPEMNCAIHFB, PIJBHNICAJC EKNHNIJMEKG, FCJJEHPENEJ ACOMPMEACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x32035B0", Offset = "0x3201BB0", VA = "0x1832035B0")]
	[AsyncStateMachine(typeof(OIMMPFGBPLJ))]
	public Task<DOIAGHFMBCN> CBLNIBPKGIO(DOIAGHFMBCN LMHECFIKGGL, EMLPMBHPMDM MMBHGDNIOAO, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG, bool CODDPMLIKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x3203780", Offset = "0x3201D80", VA = "0x183203780")]
	[AsyncStateMachine(typeof(AAMNGGIHMJK))]
	private Task<DOIAGHFMBCN> PBHIEGIEJMB(GPNAMOIINIG AEKLGCBMNDP, DOIAGHFMBCN BLJBLMCPLPH, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x3203750", Offset = "0x3201D50", VA = "0x183203750")]
	private bool MGBECKMODDL(DOIAGHFMBCN OAEAAKNOFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x3203590", Offset = "0x3201B90", VA = "0x183203590")]
	private void AECLFKCPDDB(string MLGGMMOFMCD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct ADHMAIGOLAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct KKKKNGAAGLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public EDBOGFBFNEC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private List<(PersistenceView, DACGKLHBLIE)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private (PersistenceView, DACGKLHBLIE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19990", Offset = "0x3D17F90", VA = "0x183D19990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x31F8D20", Offset = "0x31F7320", VA = "0x1831F8D20")]
	[AsyncStateMachine(typeof(KKKKNGAAGLM))]
	public static Task BABMLJMPJCC(EDBOGFBFNEC OECIEBPBJFM, EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct FBENLGDIBCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct JCCDGCBCEML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public EDBOGFBFNEC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public ILFLJKJJHHH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private KECCLNDCEEL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private List<(PersistenceView, DACGKLHBLIE)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DACGKLHBLIE <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x3D185C0", Offset = "0x3D16BC0", VA = "0x183D185C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x3206E60", Offset = "0x3205460", VA = "0x183206E60")]
	[AsyncStateMachine(typeof(JCCDGCBCEML))]
	public static Task BABMLJMPJCC(EDBOGFBFNEC OECIEBPBJFM, EMLPMBHPMDM JIHCLPECHIB, ILFLJKJJHHH NPKBDNGNGOJ, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct GCFFDDPMMNL
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public struct EKFLDOMHHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public List<GLABAKABANJ> FGMDGFNKOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public List<DACGKLHBLIE> POCENBIPLBD;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xAE7240", Offset = "0xAE5840", VA = "0x180AE7240")]
		public EKFLDOMHHLI(List<GLABAKABANJ> FGMDGFNKOPL, List<DACGKLHBLIE> POCENBIPLBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class KGDNBGDIEMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public IEnumerable<GLABAKABANJ> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KGDNBGDIEMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x4054BE0", Offset = "0x40531E0", VA = "0x184054BE0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private PEHFLLKFGNK GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private EMLPMBHPMDM JIHCLPECHIB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private EEOMMJMOFEO KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x3209CA0", Offset = "0x32082A0", VA = "0x183209CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x32099F0", Offset = "0x3207FF0", VA = "0x1832099F0")]
	public static EKFLDOMHHLI BABMLJMPJCC(PEHFLLKFGNK GHBIGIEEHOO, EMLPMBHPMDM JIHCLPECHIB)
	{
		return default(EKFLDOMHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x32096F0", Offset = "0x3207CF0", VA = "0x1832096F0")]
	private EKFLDOMHHLI BABMLJMPJCC()
	{
		return default(EKFLDOMHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x3209CF0", Offset = "0x32082F0", VA = "0x183209CF0")]
	private EKFLDOMHHLI OMHBHMFNMCG(CIFBNNGALCD HIFOLPKANOJ, KECCLNDCEEL LOKMNAHLNNL)
	{
		return default(EKFLDOMHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x3209A50", Offset = "0x3208050", VA = "0x183209A50")]
	private bool IBCIKLNJDPJ(IEnumerable<GLABAKABANJ> FGMDGFNKOPL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct HCALBLPMFNC
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class IKFDFHEFAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public GCFFDDPMMNL.EKFLDOMHHLI instantiations;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IKFDFHEFAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x4051160", Offset = "0x404F760", VA = "0x184051160")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class DLFEACAENNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public DLFEACAENNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x404A7A0", Offset = "0x4048DA0", VA = "0x18404A7A0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x320C560", Offset = "0x320AB60", VA = "0x18320C560")]
	public static void BABMLJMPJCC(EDBOGFBFNEC OECIEBPBJFM, EMLPMBHPMDM JIHCLPECHIB, GCFFDDPMMNL.EKFLDOMHHLI MLLHCOOBNJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class FCJJEHPENEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct OLDPBINICMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public DOIAGHFMBCN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public EMLPMBHPMDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x405A700", Offset = "0x4058D00", VA = "0x18405A700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class LFHNEPJNHPK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000150")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public LFHNEPJNHPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x4A56970", Offset = "0x4A54F70", VA = "0x184A56970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public GPNAMOIINIG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LFHNEPJNHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x4055E30", Offset = "0x4054430", VA = "0x184055E30")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct MAOIFBILGON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private LFHNEPJNHPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x4056A80", Offset = "0x4055080", VA = "0x184056A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct ECNNNPOJMDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private Dictionary<Guid, List<ECJAEBIEAEH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x404B620", Offset = "0x4049C20", VA = "0x18404B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct DCJHBPCOAEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GPNAMOIINIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private Dictionary<Guid, List<ECJAEBIEAEH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x3D10A80", Offset = "0x3D0F080", VA = "0x183D10A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class HJLDELHHNDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public ECJAEBIEAEH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public HJLDELHHNDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x4A542C0", Offset = "0x4A528C0", VA = "0x184A542C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public FPHDKOLEDOL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public List<ECJAEBIEAEH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HJLDELHHNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x4050550", Offset = "0x404EB50", VA = "0x184050550")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x4050730", Offset = "0x404ED30", VA = "0x184050730")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(ECJAEBIEAEH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x4050640", Offset = "0x404EC40", VA = "0x184050640")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct ALGLKIAJFCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public FPHDKOLEDOL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public List<ECJAEBIEAEH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private HJLDELHHNDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F250", Offset = "0x3D0D850", VA = "0x183D0F250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct OHCJKDOAOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public GPNAMOIINIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x4059FD0", Offset = "0x40585D0", VA = "0x184059FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class LNJDMBCJAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LNJDMBCJAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x40565D0", Offset = "0x4054BD0", VA = "0x1840565D0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct OHJGPFLOAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public EMLPMBHPMDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x405A250", Offset = "0x4058850", VA = "0x18405A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class JAFNIEOPKDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JAFNIEOPKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x4052F50", Offset = "0x4051550", VA = "0x184052F50")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LEKJGMJINPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public FCJJEHPENEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x40558D0", Offset = "0x4053ED0", VA = "0x1840558D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class KFPHKFIKCJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KFPHKFIKCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x4054B70", Offset = "0x4053170", VA = "0x184054B70")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly IBAJEEKBPBO GPEMNCAIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private BFKCGCEHIAN ACOMPMEACNE;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private EDBOGFBFNEC EJCDLMHEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8AB480", Offset = "0x8A9A80", VA = "0x1808AB480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public FCJJEHPENEJ(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x3207270", Offset = "0x3205870", VA = "0x183207270")]
	[AsyncStateMachine(typeof(OLDPBINICMM))]
	public Task BABMLJMPJCC(DOIAGHFMBCN MALLILCMKNC, EMLPMBHPMDM MMBHGDNIOAO, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x3206FB0", Offset = "0x32055B0", VA = "0x183206FB0")]
	[AsyncStateMachine(typeof(MAOIFBILGON))]
	private Task AKAMGGPMJKB(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x3207110", Offset = "0x3205710", VA = "0x183207110")]
	[AsyncStateMachine(typeof(ECNNNPOJMDJ))]
	private Task AMPHFGBFNGF(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x3207880", Offset = "0x3205E80", VA = "0x183207880")]
	[AsyncStateMachine(typeof(DCJHBPCOAEJ))]
	private Task LFCEELPIAIB(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x3207F60", Offset = "0x3206560", VA = "0x183207F60")]
	[AsyncStateMachine(typeof(ALGLKIAJFCJ))]
	private Task PDOHHNIEDCO(Guid ALNHHHBCBBI, List<ECJAEBIEAEH> HIPNBBPFLOE, FPHDKOLEDOL MDPIBPPHJGJ, EMLPMBHPMDM JIHCLPECHIB, CancellationToken HKLDIENGNNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x32075A0", Offset = "0x3205BA0", VA = "0x1832075A0")]
	[AsyncStateMachine(typeof(OHCJKDOAOOF))]
	private Task DFHKOLEFBCJ(EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x3207C50", Offset = "0x3206250", VA = "0x183207C50")]
	[AsyncStateMachine(typeof(OHJGPFLOAJA))]
	private Task OBDGGEINGJM(Guid MMIAOIEPJJD, EMLPMBHPMDM JIHCLPECHIB, GPNAMOIINIG IDKFKDEHFHM, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x3207B00", Offset = "0x3206100", VA = "0x183207B00")]
	[AsyncStateMachine(typeof(LEKJGMJINPB))]
	private Task NEMAFCPBHEL(Guid MMIAOIEPJJD, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x32076F0", Offset = "0x3205CF0", VA = "0x1832076F0")]
	private void JCMPFGCOKKP(Guid MMIAOIEPJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x32079E0", Offset = "0x3205FE0", VA = "0x1832079E0")]
	private void MDCANAANHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x3207D90", Offset = "0x3206390", VA = "0x183207D90")]
	public Guid OCJHCDNLEND(DOIAGHFMBCN ACKEPFLBACL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x32073D0", Offset = "0x32059D0", VA = "0x1832073D0")]
	[CompilerGenerated]
	private object DFEGKPCBALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
public readonly struct BGFIPODFDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	[CanBeNull]
	public readonly CIFBNNGALCD JOIEDLJPFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	[NotNull]
	public readonly PNLDGLNPKLK MPHKBNMIAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	[CanBeNull]
	public readonly string JGLGDAHDDFD;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyCollection<string> OIJBHOAJDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x31FEBB0", Offset = "0x31FD1B0", VA = "0x1831FEBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyDictionary<long, int> JNNPNKKENCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x31FEBD0", Offset = "0x31FD1D0", VA = "0x1831FEBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x31FEBF0", Offset = "0x31FD1F0", VA = "0x1831FEBF0")]
	public BGFIPODFDAA([CanBeNull] CIFBNNGALCD MJGIEGEMGND, [NotNull] PNLDGLNPKLK JFPFHKKLCID, [CanBeNull] string LKJJAKMJOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class HJLMGKGCMMH : JPPAACMPEPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct GEIOOIKACPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder<BGFIPODFDAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public HJLMGKGCMMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public JHCFIMFCHAI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x404D760", Offset = "0x404BD60", VA = "0x18404D760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x404DC30", Offset = "0x404C230", VA = "0x18404DC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class GFFPCBMKDJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public JHCFIMFCHAI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GFFPCBMKDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x404DC80", Offset = "0x404C280", VA = "0x18404DC80")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class GONEBCIOCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public GFFPCBMKDJI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GONEBCIOCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x404EC70", Offset = "0x404D270", VA = "0x18404EC70")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class JONGKNPCFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public GFFPCBMKDJI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JONGKNPCFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x4054AD0", Offset = "0x40530D0", VA = "0x184054AD0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct KLLINKCEAAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public JHCFIMFCHAI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public HJLMGKGCMMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private GONEBCIOCHH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private EFCOJEFBPIL.JNJGALBAHLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x4054EE0", Offset = "0x40534E0", VA = "0x184054EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly INGDNFMECCG DIAIBEICBEA;

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly TimeSpan OMDHMFFMFLP;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x320F9D0", Offset = "0x320DFD0", VA = "0x18320F9D0")]
	public HJLMGKGCMMH(IBAJEEKBPBO GPEMNCAIHFB, [Optional] INGDNFMECCG? DIAIBEICBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x320F0B0", Offset = "0x320D6B0", VA = "0x18320F0B0")]
	[AsyncStateMachine(typeof(GEIOOIKACPM))]
	public Task<BGFIPODFDAA> HGEKGOKJCDE(long BJDHMPBAACC, string LKJJAKMJOKN, JHCFIMFCHAI OCCAGACDAFL, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x320F800", Offset = "0x320DE00", VA = "0x18320F800")]
	[AsyncStateMachine(typeof(KLLINKCEAAE))]
	private Task OJCIDICONOB(JHCFIMFCHAI OCCAGACDAFL, IEnumerable<PersistenceView> BOFIIODFEHN, StringBuilder LJOGICGIAJK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x320F230", Offset = "0x320D830", VA = "0x18320F230")]
	private BGFIPODFDAA JJBCFIFPCCP(long BJDHMPBAACC, string LKJJAKMJOKN, JHCFIMFCHAI OCCAGACDAFL, IEnumerable<PersistenceView> BOFIIODFEHN, StringBuilder LJOGICGIAJK)
	{
		return default(BGFIPODFDAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x320E9E0", Offset = "0x320CFE0", VA = "0x18320E9E0")]
	private CIFBNNGALCD APEGCEGMGFO(long BJDHMPBAACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x320E7C0", Offset = "0x320CDC0", VA = "0x18320E7C0")]
	private void AMPBPOJMAOO(CIFBNNGALCD KICABIGFPNC, StringBuilder LJOGICGIAJK, IEnumerable<PersistenceView> BOFIIODFEHN, in KKBKOBCEICH ILAPGNJICNP, ref EFFCHKNPBAK GBHPAMBOKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x320EB50", Offset = "0x320D150", VA = "0x18320EB50")]
	private void DBCFENEFLPN(CIFBNNGALCD KICABIGFPNC, StringBuilder LJOGICGIAJK, PersistenceView EDNIAMBKPNL, ref EFFCHKNPBAK GBHPAMBOKGL, in KKBKOBCEICH ILAPGNJICNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class POOLDNGHOFB : JPPAACMPEPO
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class OAEKKACALJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public KIJPPJFGKMD.IPOCMMCCJIG roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public KIJPPJFGKMD.IPOCMMCCJIG subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OAEKKACALJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A52F00", Offset = "0x4A51500", VA = "0x184A52F00")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x4A52F90", Offset = "0x4A51590", VA = "0x184A52F90")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x4A52FE0", Offset = "0x4A515E0", VA = "0x184A52FE0")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x4A53050", Offset = "0x4A51650", VA = "0x184A53050")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct MLJKHLJADPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<(KIJPPJFGKMD.IPOCMMCCJIG roomDataUpload, KIJPPJFGKMD.IPOCMMCCJIG subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public BGFIPODFDAA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public POOLDNGHOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private OAEKKACALJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private TaskAwaiter<KIJPPJFGKMD.IPOCMMCCJIG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A515D0", Offset = "0x4A4FBD0", VA = "0x184A515D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A52020", Offset = "0x4A50620", VA = "0x184A52020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NFJMHDPECKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder<GKLDPEEJFFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public POOLDNGHOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public BGFIPODFDAA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public BFMPILHPOIM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter<(KIJPPJFGKMD.IPOCMMCCJIG roomDataUpload, KIJPPJFGKMD.IPOCMMCCJIG subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private TaskAwaiter<GKLDPEEJFFM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x4A52170", Offset = "0x4A50770", VA = "0x184A52170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x4A52570", Offset = "0x4A50B70", VA = "0x184A52570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct MGOFMFLDCFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<BBPHCEGMHJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public POOLDNGHOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public BGFIPODFDAA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter<(KIJPPJFGKMD.IPOCMMCCJIG roomDataUpload, KIJPPJFGKMD.IPOCMMCCJIG subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter<BBPHCEGMHJG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x4A50FF0", Offset = "0x4A4F5F0", VA = "0x184A50FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x4A51380", Offset = "0x4A4F980", VA = "0x184A51380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class GALGFOLGNDP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public GALGFOLGNDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			private GMKGAFOGKAM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			private TaskAwaiter<BBPHCEGMHJG> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<GKLDPEEJFFM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private TaskAwaiter<GMKGAFOGKAM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x4A56E50", Offset = "0x4A55450", VA = "0x184A56E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x4A57970", Offset = "0x4A55F70", VA = "0x184A57970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public POOLDNGHOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public BGFIPODFDAA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public BFMPILHPOIM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GALGFOLGNDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EEA0", Offset = "0x4A4D4A0", VA = "0x184A4EEA0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GMKGAFOGKAM> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct KELOJFOGHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AsyncTaskMethodBuilder<GMKGAFOGKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public POOLDNGHOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public BGFIPODFDAA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public BFMPILHPOIM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private TaskAwaiter<GMKGAFOGKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x4A50020", Offset = "0x4A4E620", VA = "0x184A50020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A502D0", Offset = "0x4A4E8D0", VA = "0x184A502D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private const float CFGPPOCFFIE = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private readonly FHHMNEGALCE KEODHPINPHO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private PEHFLLKFGNK EHKDPFOHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x31F7030", Offset = "0x31F5630", VA = "0x1831F7030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D24670", Offset = "0x3D22C70", VA = "0x183D24670")]
	public POOLDNGHOFB(IBAJEEKBPBO GPEMNCAIHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D24500", Offset = "0x3D22B00", VA = "0x183D24500")]
	[AsyncStateMachine(typeof(MLJKHLJADPL))]
	private Task<(KIJPPJFGKMD.IPOCMMCCJIG, KIJPPJFGKMD.IPOCMMCCJIG)> JFGGCNLCNGI(BGFIPODFDAA CKGACJHBBDE, long FAFDJINDEIN, long KJHHBFLPCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D24030", Offset = "0x3D22630", VA = "0x183D24030")]
	[AsyncStateMachine(typeof(NFJMHDPECKN))]
	public Task<GKLDPEEJFFM> FLDINPNCPKD(int NJHGAFMAJCP, [CanBeNull] BFMPILHPOIM NHIKBCCKBML, BGFIPODFDAA CKGACJHBBDE, long FAFDJINDEIN, long KJHHBFLPCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D24370", Offset = "0x3D22970", VA = "0x183D24370")]
	[AsyncStateMachine(typeof(MGOFMFLDCFB))]
	private Task<BBPHCEGMHJG> HCFMHOPCFDE(string ENKEIPCEPOH, int NJHGAFMAJCP, BGFIPODFDAA CKGACJHBBDE, long FAFDJINDEIN, long KJHHBFLPCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D241C0", Offset = "0x3D227C0", VA = "0x183D241C0")]
	[AsyncStateMachine(typeof(KELOJFOGHMA))]
	public Task<GMKGAFOGKAM> GIIJFOMNGOC(int NJHGAFMAJCP, [CanBeNull] BFMPILHPOIM NHIKBCCKBML, BGFIPODFDAA CKGACJHBBDE, long FAFDJINDEIN, long KJHHBFLPCIE, GPNAMOIINIG AEKLGCBMNDP, CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public abstract class CGFABOBOMME<T> where T : global::CGFABOBOMME<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	internal readonly PEHFLLKFGNK DJIGOHCOBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private int? NJFGADNDLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	protected readonly Guid DFKLDECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	protected readonly JOMJELHHOJP OOCIJPOCBJO;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T JLMCHDKDOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x364F220", Offset = "0x364D820", VA = "0x18364F220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x364F570", Offset = "0x364DB70", VA = "0x18364F570")]
	internal CGFABOBOMME(PEHFLLKFGNK IKMPGDCFAPN, JOMJELHHOJP OKGFNLPFOFG, [Optional] Guid? KAOFPCAFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x364F310", Offset = "0x364D910", VA = "0x18364F310")]
	private GMKGAFOGKAM HIIPHJFLPAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	protected virtual void GAGLBPHGMGL(GMKGAFOGKAM DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x364F280", Offset = "0x364D880", VA = "0x18364F280")]
	public T DPCMGBOKCBB(CHIAPKEENBB DNGIFCKAEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x364F4F0", Offset = "0x364DAF0", VA = "0x18364F4F0")]
	public T PGMNDIALKBH(int MJAGJOECPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x364F3F0", Offset = "0x364D9F0", VA = "0x18364F3F0", Slot = "5")]
	public virtual Task<HNKKGJKFCMD> NBENOMELJHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class NEPAAGJDNIP : global::CGFABOBOMME<NEPAAGJDNIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private ELFALKJEDMF GOMBJHKPMMM;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E820", Offset = "0x3D1CE20", VA = "0x183D1E820")]
	internal NEPAAGJDNIP(PEHFLLKFGNK IKMPGDCFAPN, JOMJELHHOJP OKGFNLPFOFG, [Optional] Guid? KAOFPCAFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xC4E120", Offset = "0xC4C720", VA = "0x180C4E120")]
	public NEPAAGJDNIP IBGLDAFGLDE(ELFALKJEDMF GOMBJHKPMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E760", Offset = "0x3D1CD60", VA = "0x183D1E760", Slot = "4")]
	protected override void GAGLBPHGMGL(GMKGAFOGKAM DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class IICKKMOGJNC : global::CGFABOBOMME<IICKKMOGJNC>
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	internal enum IFALCMAPFHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct NDECBACFEJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<HNKKGJKFCMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public IICKKMOGJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<HNKKGJKFCMD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x4058E50", Offset = "0x4057450", VA = "0x184058E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x4059150", Offset = "0x4057750", VA = "0x184059150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private IFALCMAPFHF LDMGGBPAOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private string GPGIEIFDMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private BFMPILHPOIM GOMBJHKPMMM;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x3213520", Offset = "0x3211B20", VA = "0x183213520")]
	internal IICKKMOGJNC(PEHFLLKFGNK IKMPGDCFAPN, JOMJELHHOJP OKGFNLPFOFG, [Optional] Guid? KAOFPCAFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x3213380", Offset = "0x3211980", VA = "0x183213380")]
	public IICKKMOGJNC HCGILLNKCIE(string JIPPCEBJCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x32133B0", Offset = "0x32119B0", VA = "0x1832133B0")]
	public IICKKMOGJNC IMPBAAPGJHB(bool HLOFGGLEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x32131E0", Offset = "0x32117E0", VA = "0x1832131E0")]
	public IICKKMOGJNC CEALKOMMABO(string GFBIJELPOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x32134F0", Offset = "0x3211AF0", VA = "0x1832134F0")]
	public IICKKMOGJNC PIGFDBLNJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x3213210", Offset = "0x3211810", VA = "0x183213210", Slot = "4")]
	protected override void GAGLBPHGMGL(GMKGAFOGKAM DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x32133D0", Offset = "0x32119D0", VA = "0x1832133D0", Slot = "5")]
	[AsyncStateMachine(typeof(NDECBACFEJK))]
	public override Task<HNKKGJKFCMD> NBENOMELJHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x32131A0", Offset = "0x32117A0", VA = "0x1832131A0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<HNKKGJKFCMD> AGCAMNIMDIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal static class JGCJDLOPBBL
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x3213DF0", Offset = "0x32123F0", VA = "0x183213DF0")]
	public static void GEMNCDJLJEK(this LLFBHKMOMLO OJIJOGNHBGI, IKMCGNPFENA GCLFJHJGEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x3213D10", Offset = "0x3212310", VA = "0x183213D10")]
	public static void AOOPDJAOJEK(this IKMCGNPFENA OECLDILMEEN, [Optional] string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public static class EKKEEOIKNBO
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x32068F0", Offset = "0x3204EF0", VA = "0x1832068F0")]
	public static LLGMLEHJMCJ LPPABMIAHFI(this ACFDLHGLMKA CCCHGKBILHH)
	{
		return default(LLGMLEHJMCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x3206830", Offset = "0x3204E30", VA = "0x183206830")]
	public static ACFDLHGLMKA LCGPAFGDLOB(this LLGMLEHJMCJ ADOMJBMOHEH)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public EKOKBLCONFM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public EKOKBLCONFM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private static EKOKBLCONFM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private Dictionary<EKOKBLCONFM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D25650", Offset = "0x3D23C50", VA = "0x183D25650")]
		public bool POOHHBMJCIC(EKOKBLCONFM JADFNIJJIDF, out ResultConfig PPPBIOFDOMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D24DB0", Offset = "0x3D233B0", VA = "0x183D24DB0")]
		public ResultConfig INMHLOFKNII(EKOKBLCONFM ECMALJHOMMC, [Optional] HashSet<EKOKBLCONFM> DHBGKHDIJFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D25450", Offset = "0x3D23A50", VA = "0x183D25450", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x3D24ED0", Offset = "0x3D234D0", VA = "0x183D24ED0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FADF0", Offset = "0x7F93F0", VA = "0x1807FADF0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class CENBJLJFCKJ
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x32001D0", Offset = "0x31FE7D0", VA = "0x1832001D0")]
	[PILNOHNDGDF(KBMKLHMPDPB.GameOnly)]
	private static void HJAIOHOJGPC(PEGEFOEHCCC CKAHEPACLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public interface HFFCNJPOHMD : IEquatable<HFFCNJPOHMD>
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime LEOGAFIOGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHBHGPJLDGF();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OJNMEMNKKMC(long FAFDJINDEIN, long BJDHMPBAACC, out BGFIPODFDAA CKGACJHBBDE);
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal class DMJGCJGPPLG : EODLIBFMCBK
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class IDNOEIONHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public DJMCEAKDOIN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IDNOEIONHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D15BA0", Offset = "0x3D141A0", VA = "0x183D15BA0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly KBLFNPLAPIM MDCHEABAHAM;

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private const int MLBPFJJIAKJ = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<HFFCNJPOHMD> GIEEADBOBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x32039D0", Offset = "0x3201FD0", VA = "0x1832039D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x3203A70", Offset = "0x3202070", VA = "0x183203A70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	[Preserve]
	public DMJGCJGPPLG([KICKHKJFGOO(null)] KBLFNPLAPIM MDCHEABAHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3203B10", Offset = "0x3202110", VA = "0x183203B10", Slot = "6")]
	public bool DAAMAIMPDJH(long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE, DJMCEAKDOIN LLJBGAHHCBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x32045A0", Offset = "0x3202BA0", VA = "0x1832045A0")]
	private void OJAPOADIGMF(HFFCNJPOHMD ALLHONMJPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x3204420", Offset = "0x3202A20", VA = "0x183204420", Slot = "7")]
	public bool MABPCAGPHKA(long FAFDJINDEIN, long BJDHMPBAACC, out HFFCNJPOHMD GBNPJHBLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x3203F80", Offset = "0x3202580", VA = "0x183203F80", Slot = "8")]
	public bool GOHIMGLLGAG(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, out HFFCNJPOHMD GBNPJHBLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x3204030", Offset = "0x3202630", VA = "0x183204030")]
	private void LIOOMCIFPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x3203E60", Offset = "0x3202460", VA = "0x183203E60", Slot = "9")]
	public void FNIDDPEAEAA(long FAFDJINDEIN, long BJDHMPBAACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal abstract class JGOEOHJPFHO : KBLFNPLAPIM
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	protected enum PGHEIHKDAFO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class NBKCODAAIDK : IEnumerable<HFFCNJPOHMD>, IEnumerable, IEnumerator<HFFCNJPOHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private HFFCNJPOHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public JGOEOHJPFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private DJMCEAKDOIN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public DJMCEAKDOIN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private HFFCNJPOHMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public NBKCODAAIDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x4058C00", Offset = "0x4057200", VA = "0x184058C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x4058E10", Offset = "0x4057410", VA = "0x184058E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x4058D60", Offset = "0x4057360", VA = "0x184058D60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HFFCNJPOHMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x4058D60", Offset = "0x4057360", VA = "0x184058D60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class BIOECDOCCMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public DJMCEAKDOIN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BIOECDOCCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x4047F20", Offset = "0x4046520", VA = "0x184047F20")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class BBBCJPIJCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public JGOEOHJPFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BBBCJPIJCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x4047780", Offset = "0x4045D80", VA = "0x184047780")]
		internal void <TryReadAutosaveFile>b__0(FCAFPKHGOHN.LBPHINLBAKP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	protected readonly string NJNGMFAKONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly object OMOKDDEEKPG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x32147C0", Offset = "0x3212DC0", VA = "0x1832147C0")]
	protected JGOEOHJPFHO([CanBeNull] string CJNOELJLPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x3214270", Offset = "0x3212870", VA = "0x183214270", Slot = "5")]
	public bool LEBFBIMBCBA(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, out HFFCNJPOHMD ALLHONMJPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3214740", Offset = "0x3212D40", VA = "0x183214740", Slot = "6")]
	[IteratorStateMachine(typeof(NBKCODAAIDK))]
	public IEnumerable<HFFCNJPOHMD> PCMMOGCAHJA(DJMCEAKDOIN LLJBGAHHCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LDAOEFDGNKC(Stream EBIDOFEJGIP, long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FEIKCAKDBJN(Stream EADKAGNPLKB, long FAFDJINDEIN, long BJDHMPBAACC, EIJCJMGMOJF ODNMPENJCKK, out BGFIPODFDAA CKGACJHBBDE);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3213F40", Offset = "0x3212540", VA = "0x183213F40", Slot = "7")]
	public HFFCNJPOHMD DGBEKPMAIDH(long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE, DJMCEAKDOIN LLJBGAHHCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo KNMGGPMKOPH(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PJHIMONGEEB(DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3214420", Offset = "0x3212A20", VA = "0x183214420")]
	protected void MJJGAPHFAMG(FCAFPKHGOHN.LBPHINLBAKP JKLGBLDBLAK, string MLGGMMOFMCD, FileInfo ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3214490", Offset = "0x3212A90", VA = "0x183214490")]
	internal bool ONBNMJABOFK(FileInfo HGBENBAEJHK, long FAFDJINDEIN, long BJDHMPBAACC, out BGFIPODFDAA CKGACJHBBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private void CCKOHJJIHDE(Exception OAIKBNOGBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class KKGBKPEIHID : JGOEOHJPFHO
{
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private const string ODAKELFCBGL = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private const string DLLMKIKMJBO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private const string GFGBNMFHOFN = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x9AA400", Offset = "0x9A8A00", VA = "0x1809AA400", Slot = "8")]
		get
		{
			return default(BHGMLFLKGOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x3217B90", Offset = "0x3216190", VA = "0x183217B90")]
	public KKGBKPEIHID([Optional] string CJNOELJLPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x3217040", Offset = "0x3215640", VA = "0x183217040")]
	private void EOEEOCHPAEP(DJMCEAKDOIN LLJBGAHHCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x3217820", Offset = "0x3215E20", VA = "0x183217820", Slot = "9")]
	internal override void LDAOEFDGNKC(Stream EBIDOFEJGIP, long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x32170C0", Offset = "0x32156C0", VA = "0x1832170C0", Slot = "10")]
	internal override bool FEIKCAKDBJN(Stream EADKAGNPLKB, long FAFDJINDEIN, long BJDHMPBAACC, EIJCJMGMOJF ODNMPENJCKK, out BGFIPODFDAA CKGACJHBBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x3217730", Offset = "0x3215D30", VA = "0x183217730", Slot = "11")]
	protected override FileInfo KNMGGPMKOPH(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x3217A80", Offset = "0x3216080", VA = "0x183217A80", Slot = "12")]
	protected override DirectoryInfo PJHIMONGEEB(DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal sealed class HGDIPBPBHIM : JGOEOHJPFHO
{
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private static readonly byte[] AIGAKEKDKHM;

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private const string DLLMKIKMJBO = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private const string GFGBNMFHOFN = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private const string KKCCGLANDEF = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly byte[] PAMBBLPOBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly byte[] LPGMBFAFBDD;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBA0", Offset = "0x9AA1A0", VA = "0x1809ABBA0", Slot = "8")]
		get
		{
			return default(BHGMLFLKGOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x320E2C0", Offset = "0x320C8C0", VA = "0x18320E2C0")]
	public HGDIPBPBHIM([Optional] string CJNOELJLPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x320DE80", Offset = "0x320C480", VA = "0x18320DE80", Slot = "9")]
	internal override void LDAOEFDGNKC(Stream EBIDOFEJGIP, long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x320D3C0", Offset = "0x320B9C0", VA = "0x18320D3C0", Slot = "10")]
	internal override bool FEIKCAKDBJN(Stream EADKAGNPLKB, long FAFDJINDEIN, long BJDHMPBAACC, EIJCJMGMOJF ODNMPENJCKK, out BGFIPODFDAA CKGACJHBBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x320DD70", Offset = "0x320C370", VA = "0x18320DD70")]
	private void KPHGGEODBKC(byte[] PPJLGCLGPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x320DC40", Offset = "0x320C240", VA = "0x18320DC40", Slot = "11")]
	protected override FileInfo KNMGGPMKOPH(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x320E120", Offset = "0x320C720", VA = "0x18320E120", Slot = "12")]
	protected override DirectoryInfo PJHIMONGEEB(DJMCEAKDOIN LLJBGAHHCBP, PGHEIHKDAFO MMDBFJGPEFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public enum BHGMLFLKGOA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal class OELNEDAJDMF : KBLFNPLAPIM
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class CHJAGGEANND : IEnumerable<HFFCNJPOHMD>, IEnumerable, IEnumerator<HFFCNJPOHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private HFFCNJPOHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public OELNEDAJDMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private DJMCEAKDOIN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public DJMCEAKDOIN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private BHGMLFLKGOA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerator<HFFCNJPOHMD> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private HFFCNJPOHMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public CHJAGGEANND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B760", Offset = "0x4A49D60", VA = "0x184A4B760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B390", Offset = "0x4A49990", VA = "0x184A4B390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B7F0", Offset = "0x4A49DF0", VA = "0x184A4B7F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B720", Offset = "0x4A49D20", VA = "0x184A4B720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B670", Offset = "0x4A49C70", VA = "0x184A4B670", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HFFCNJPOHMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B670", Offset = "0x4A49C70", VA = "0x184A4B670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly BHGMLFLKGOA[] GKOLEIAFLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly Dictionary<BHGMLFLKGOA, KBLFNPLAPIM> OJBEBIJHHBB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x3D20330", Offset = "0x3D1E930", VA = "0x183D20330", Slot = "4")]
		get
		{
			return default(BHGMLFLKGOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x3D20550", Offset = "0x3D1EB50", VA = "0x183D20550")]
	[Preserve]
	public OELNEDAJDMF(params KBLFNPLAPIM[] JFLOALNNCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3D20370", Offset = "0x3D1E970", VA = "0x183D20370", Slot = "5")]
	public bool LEBFBIMBCBA(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, out HFFCNJPOHMD ALLHONMJPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3D20100", Offset = "0x3D1E700", VA = "0x183D20100")]
	private void DLJDEOALMNC(int OPOOMPMNPAB, long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x3D204D0", Offset = "0x3D1EAD0", VA = "0x183D204D0", Slot = "6")]
	[IteratorStateMachine(typeof(CHJAGGEANND))]
	public IEnumerable<HFFCNJPOHMD> PCMMOGCAHJA(DJMCEAKDOIN LLJBGAHHCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FFA0", Offset = "0x3D1E5A0", VA = "0x183D1FFA0", Slot = "7")]
	public HFFCNJPOHMD DGBEKPMAIDH(long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE, DJMCEAKDOIN LLJBGAHHCBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal static class BLFKFOFGLOP
{
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	internal const int HCGPMNKHJFN = 32;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x31FF5D0", Offset = "0x31FDBD0", VA = "0x1831FF5D0")]
	internal static byte[] KOOHNLHDKAJ(byte[] PPJLGCLGPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x31FF370", Offset = "0x31FD970", VA = "0x1831FF370")]
	public static void ADCFEIJBLHC(Stream FJEDANIIFJL, byte[] PNIMNEOOKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x31FF3F0", Offset = "0x31FD9F0", VA = "0x1831FF3F0")]
	public static bool AMMGHKBOILJ(Stream FJEDANIIFJL, long LBPGGAPHEJG, EIJCJMGMOJF IKANEJJGMGL, out byte[] AJDHHKLKPBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal sealed class PMMKKDLCLND : HFFCNJPOHMD, IEquatable<HFFCNJPOHMD>, IEquatable<PMMKKDLCLND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private readonly JGOEOHJPFHO CBPKKLDMGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public readonly FileInfo DHCEBECKJDP;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1224CE0", Offset = "0x12232E0", VA = "0x181224CE0", Slot = "4")]
		get
		{
			return default(BHGMLFLKGOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime LEOGAFIOGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x3D239B0", Offset = "0x3D21FB0", VA = "0x183D239B0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3D23F30", Offset = "0x3D22530", VA = "0x183D23F30")]
	public PMMKKDLCLND(JGOEOHJPFHO LHGGMDPKEAE, FileInfo HGBENBAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3D23E80", Offset = "0x3D22480", VA = "0x183D23E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3D23A50", Offset = "0x3D22050", VA = "0x183D23A50", Slot = "6")]
	public void EHBHGPJLDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x3D23E40", Offset = "0x3D22440", VA = "0x183D23E40", Slot = "7")]
	public bool OJNMEMNKKMC(long FAFDJINDEIN, long BJDHMPBAACC, out BGFIPODFDAA CKGACJHBBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3D23BC0", Offset = "0x3D221C0", VA = "0x183D23BC0", Slot = "8")]
	public bool Equals(HFFCNJPOHMD OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x3D23B10", Offset = "0x3D22110", VA = "0x183D23B10", Slot = "9")]
	public bool Equals(PMMKKDLCLND OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3D23CA0", Offset = "0x3D222A0", VA = "0x183D23CA0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x3D23DA0", Offset = "0x3D223A0", VA = "0x183D23DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x23D2CF0", Offset = "0x23D12F0", VA = "0x1823D2CF0")]
	public static bool GBIPOJBPNDJ(PMMKKDLCLND FFMFLKJEKLP, PMMKKDLCLND PHDGNGLFBBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x23D2960", Offset = "0x23D0F60", VA = "0x1823D2960")]
	public static bool EOCJAGBGMLJ(PMMKKDLCLND FFMFLKJEKLP, PMMKKDLCLND PHDGNGLFBBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public delegate void EIJCJMGMOJF(FCAFPKHGOHN.LBPHINLBAKP HOGKFIGKOHG, string DIDMFBHHIEC);
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal interface KBLFNPLAPIM
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	BHGMLFLKGOA JDDGAFOKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEBFBIMBCBA(long FAFDJINDEIN, long BJDHMPBAACC, DJMCEAKDOIN LLJBGAHHCBP, out HFFCNJPOHMD ALLHONMJPOC);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HFFCNJPOHMD> PCMMOGCAHJA(DJMCEAKDOIN LLJBGAHHCBP);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HFFCNJPOHMD DGBEKPMAIDH(long FAFDJINDEIN, long BJDHMPBAACC, BGFIPODFDAA CKGACJHBBDE, DJMCEAKDOIN LLJBGAHHCBP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B530", Offset = "0x3D19B30", VA = "0x183D1B530")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B1E0", Offset = "0x3D197E0", VA = "0x183D1B1E0")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400068B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
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
