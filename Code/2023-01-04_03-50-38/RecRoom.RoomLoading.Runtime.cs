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
public class DNAJNBONPCA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x269BB50", Offset = "0x269AF50", VA = "0x18269BB50")]
	public DNAJNBONPCA(string KAKCNEMJMJL, Exception GKFIKAGHEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class LPKCJGJJDGF : EDEMHKDKOHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HKNHDLAKPFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DBGHAPPHDML>> <>t__builder;

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
		private TaskAwaiter<global::EGEIDAHANOB<DBGHAPPHDML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x323C670", Offset = "0x323BA70", VA = "0x18323C670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x323C850", Offset = "0x323BC50", VA = "0x18323C850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct MIGLFEMCAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DIEFIANLGNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<DIEFIANLGNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3242FE0", Offset = "0x32423E0", VA = "0x183242FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x32431A0", Offset = "0x32425A0", VA = "0x1832431A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	[Preserve]
	public LPKCJGJJDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26B4C10", Offset = "0x26B4010", VA = "0x1826B4C10", Slot = "4")]
	[AsyncStateMachine(typeof(HKNHDLAKPFN))]
	public Task<IReadOnlyList<DBGHAPPHDML>> FNCBAIHJGIG(long DDEPFHBCOHC, long BGHKIEHCOCI, [Optional] CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26B4D60", Offset = "0x26B4160", VA = "0x1826B4D60", Slot = "5")]
	[AsyncStateMachine(typeof(MIGLFEMCAHD))]
	public Task<IReadOnlyList<DIEFIANLGNP>> JPLDOHDLLHA(IReadOnlyList<int> KAJNDJJBIFI, [Optional] CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DEDJLCEBMGM : IEquatable<DEDJLCEBMGM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int AKKGDIFOGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DIEFIANLGNP JJBLCJAIMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime AJFHPFNNFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ELMLIEIFJKD? KAAOKFMEIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LBIJIIOMJMM? BLNBAMCNGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	BCHKNHLIBIP DKLHEJIOLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CJAGNKGLNKE> LGGDJOIJHLP();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BCHKNHLIBIP
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EDEMHKDKOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DBGHAPPHDML>> FNCBAIHJGIG(long DDEPFHBCOHC, long BGHKIEHCOCI, [Optional] CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DIEFIANLGNP>> JPLDOHDLLHA(IReadOnlyList<int> KAJNDJJBIFI, [Optional] CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NFKBICLFOJO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class GAKDNNEKPKM : DEDJLCEBMGM, IEquatable<DEDJLCEBMGM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct GMIJHCEPPBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GAKDNNEKPKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private KNOCCPHNCIA <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PCBJAABEHPG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<CJAGNKGLNKE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x46CFDA0", Offset = "0x46CF1A0", VA = "0x1846CFDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x46D0230", Offset = "0x46CF630", VA = "0x1846D0230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DBGHAPPHDML DEIKLBAIGMP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AKKGDIFOGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DIEFIANLGNP JJBLCJAIMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime KBNAFOHKHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x16B2130", Offset = "0x16B1530", VA = "0x1816B2130", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ELMLIEIFJKD? KAAOKFMEIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8E26A0", Offset = "0x8E1AA0", VA = "0x1808E26A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LBIJIIOMJMM? BLNBAMCNGEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8E2660", Offset = "0x8E1A60", VA = "0x1808E2660", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BCHKNHLIBIP DKLHEJIOLLF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69EAA0", Offset = "0x69DEA0", VA = "0x18069EAA0", Slot = "10")]
			get
			{
				return default(BCHKNHLIBIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3239710", Offset = "0x3238B10", VA = "0x183239710", Slot = "9")]
		[AsyncStateMachine(typeof(GMIJHCEPPBO))]
		public Task<CJAGNKGLNKE> LGGDJOIJHLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3239880", Offset = "0x3238C80", VA = "0x183239880")]
		public GAKDNNEKPKM(int JNBDCHFGOCI, DIEFIANLGNP GFMFCBHHFPP, DBGHAPPHDML DEIKLBAIGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x32395F0", Offset = "0x32389F0", VA = "0x1832395F0", Slot = "11")]
		public bool Equals(DEDJLCEBMGM EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3239550", Offset = "0x3238950", VA = "0x183239550", Slot = "0")]
		public override bool Equals(object JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3239840", Offset = "0x3238C40", VA = "0x183239840")]
		private bool LNNPOHFFAFO(GAKDNNEKPKM EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3239680", Offset = "0x3238A80", VA = "0x183239680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class GCODIDOLOFN : DEDJLCEBMGM, IEquatable<DEDJLCEBMGM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct DEKHLCPKCGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GCODIDOLOFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<CJAGNKGLNKE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x46CB5E0", Offset = "0x46CA9E0", VA = "0x1846CB5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x46CB820", Offset = "0x46CAC20", VA = "0x1846CB820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly LMBGJPBKLNM POCEPCACAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly ELMLIEIFJKD OFBAKNFDHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LBIJIIOMJMM MFPKDJJBJBL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int AKKGDIFOGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3239FE0", Offset = "0x32393E0", VA = "0x183239FE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DIEFIANLGNP JJBLCJAIMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x323A260", Offset = "0x3239660", VA = "0x18323A260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime KBNAFOHKHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x323A300", Offset = "0x3239700", VA = "0x18323A300", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ELMLIEIFJKD? KAAOKFMEIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3239F90", Offset = "0x3239390", VA = "0x183239F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LBIJIIOMJMM? BLNBAMCNGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x323A210", Offset = "0x3239610", VA = "0x18323A210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BCHKNHLIBIP DKLHEJIOLLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6932A0", Offset = "0x6926A0", VA = "0x1806932A0", Slot = "10")]
			get
			{
				return default(BCHKNHLIBIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71DD10", Offset = "0x71D110", VA = "0x18071DD10")]
		public GCODIDOLOFN(LMBGJPBKLNM MGLNAHCNMBL, ELMLIEIFJKD DHMDHBEHMKP, LBIJIIOMJMM CGIKKHDBDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x323A350", Offset = "0x3239750", VA = "0x18323A350", Slot = "9")]
		[AsyncStateMachine(typeof(DEKHLCPKCGJ))]
		public Task<CJAGNKGLNKE> LGGDJOIJHLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x323A0E0", Offset = "0x32394E0", VA = "0x18323A0E0", Slot = "11")]
		public bool Equals(DEDJLCEBMGM EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3239430", VA = "0x18323A030", Slot = "0")]
		public override bool Equals(object JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x323A470", Offset = "0x3239870", VA = "0x18323A470")]
		private bool LNNPOHFFAFO(GCODIDOLOFN EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x323A180", Offset = "0x3239580", VA = "0x18323A180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GGBCIDCMIMH : DEDJLCEBMGM, IEquatable<DEDJLCEBMGM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct BMCCDOPIMCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<CJAGNKGLNKE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x46CAAE0", Offset = "0x46C9EE0", VA = "0x1846CAAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x46CACC0", Offset = "0x46CA0C0", VA = "0x1846CACC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly DIEFIANLGNP EOOCLJBLEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ELMLIEIFJKD OFBAKNFDHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LBIJIIOMJMM MFPKDJJBJBL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int AKKGDIFOGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x323A520", Offset = "0x3239920", VA = "0x18323A520", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DIEFIANLGNP JJBLCJAIMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime KBNAFOHKHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ELMLIEIFJKD? KAAOKFMEIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x323A4D0", Offset = "0x32398D0", VA = "0x18323A4D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LBIJIIOMJMM? BLNBAMCNGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x323A8E0", Offset = "0x3239CE0", VA = "0x18323A8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BCHKNHLIBIP DKLHEJIOLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "10")]
			get
			{
				return default(BCHKNHLIBIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71DD10", Offset = "0x71D110", VA = "0x18071DD10")]
		public GGBCIDCMIMH(DIEFIANLGNP GFMFCBHHFPP, ELMLIEIFJKD DHMDHBEHMKP, LBIJIIOMJMM CGIKKHDBDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x323A930", Offset = "0x3239D30", VA = "0x18323A930", Slot = "9")]
		[AsyncStateMachine(typeof(BMCCDOPIMCP))]
		public Task<CJAGNKGLNKE> LGGDJOIJHLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x323A6F0", Offset = "0x3239AF0", VA = "0x18323A6F0", Slot = "11")]
		public bool Equals(DEDJLCEBMGM EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x323A5A0", Offset = "0x32399A0", VA = "0x18323A5A0", Slot = "0")]
		public override bool Equals(object JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x323A830", Offset = "0x3239C30", VA = "0x18323A830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x323AA20", Offset = "0x3239E20", VA = "0x18323AA20")]
		private bool LNNPOHFFAFO(GGBCIDCMIMH EPJIAIAEMFF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CCFFJOPOIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<DEDJLCEBMGM>> <>t__builder;

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
		public NFKBICLFOJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<DBGHAPPHDML> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<DBGHAPPHDML>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DIEFIANLGNP account, DBGHAPPHDML roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3235A60", Offset = "0x3234E60", VA = "0x183235A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x32364F0", Offset = "0x32358F0", VA = "0x1832364F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KLJIDNENIFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DIEFIANLGNP account, DBGHAPPHDML roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<DBGHAPPHDML> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NFKBICLFOJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<DIEFIANLGNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x32404E0", Offset = "0x323F8E0", VA = "0x1832404E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3240E60", Offset = "0x3240260", VA = "0x183240E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NOAFBENMHJD IHINAACEABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EDEMHKDKOHO FLCLLAAAPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly COLFLIDOIPP NPOBKCOMDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::ODGDCGAILJD<(long, long), IReadOnlyList<DBGHAPPHDML>> JLIABIODBOO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26B7460", Offset = "0x26B6860", VA = "0x1826B7460")]
	[Preserve]
	public NFKBICLFOJO([IMNCNOGBAJI(null)] EDEMHKDKOHO GEEOGDGNIFN, [IMNCNOGBAJI(null)] COLFLIDOIPP POFLOAMPNJH, [IMNCNOGBAJI(null)] NOAFBENMHJD PEOPJPFBIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26B7160", Offset = "0x26B6560", VA = "0x1826B7160")]
	[AsyncStateMachine(typeof(CCFFJOPOIIB))]
	public Task<IList<DEDJLCEBMGM>> EPADBHMEGDH(long DDEPFHBCOHC, long LBIOPPABCMJ, bool HIGEEPNIJOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26B72B0", Offset = "0x26B66B0", VA = "0x1826B72B0")]
	private bool GNEAFDGAGOD(DateTime? MFPIOGKCFJD, long DDEPFHBCOHC, long LBIOPPABCMJ, out LMBGJPBKLNM HHCPLMDOPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26B7020", Offset = "0x26B6420", VA = "0x1826B7020")]
	[AsyncStateMachine(typeof(KLJIDNENIFP))]
	private Task<IReadOnlyList<(int, DIEFIANLGNP, DBGHAPPHDML)>> DHMLOCADPIN(IReadOnlyList<DBGHAPPHDML> NPNAEFOFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface COLFLIDOIPP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LMBGJPBKLNM> AHFFALCGLPN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPJJINDLEOF(long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC, AEDHGGAECKF BFONPHLGOFF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPGBLMOIDCL(long DDEPFHBCOHC, long LBIOPPABCMJ, out LMBGJPBKLNM HHCPLMDOPHM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNLKJDGOGDP(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, out LMBGJPBKLNM HHCPLMDOPHM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POCBBBHKEMP(long DDEPFHBCOHC, long LBIOPPABCMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface HEECAHIIDDB : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BIGFBEMLHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task NPJKOPLBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCAELAPCBBO(Task MPDGFCFNFOK, string OOCIGPPHHOC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface LJNNJIFNHBJ : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJAGNKGLNKE> GAKNBGINLEI(LMBGJPBKLNM HHCPLMDOPHM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MNIPDLPKAJK(CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface EBCBFDJMCKE : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MBHCBBFEHOI JLAGAJPDAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKKBBDKDBAP();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOPHFFGBAJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface PIIBHELDMJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface ALHGIICHNJK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan MJFBGHLFEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan EMCPCKFIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan BIKLPAMLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JEKHFLHCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IKDKNCGBILB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CEGNOHLCCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OMDEHEBHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum NBEPCPKJODE
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IIPDMJLEAFA
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
public struct CKOHOJDPEFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly long MBADJDCHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly long BGHKIEHCOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly NBEPCPKJODE FPPBLNEEHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CanBeNull]
	public readonly Exception IKJNEKBFGPC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2698880", Offset = "0x2697C80", VA = "0x182698880")]
	public CKOHOJDPEFN(long MBADJDCHPMA, long BGHKIEHCOCI, NBEPCPKJODE FPPBLNEEHBP, [CanBeNull] Exception IKJNEKBFGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2698830", Offset = "0x2697C30", VA = "0x182698830")]
	public static CKOHOJDPEFN DKOALHGANJG(LBBLCNAMBKL KNLKAIOEGID, NBEPCPKJODE FPPBLNEEHBP, [Optional] Exception IKJNEKBFGPC)
	{
		return default(CKOHOJDPEFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void GHGJNPLHJDL(CKOHOJDPEFN EFBPCCGHHAO);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface DOILCJMNGKO : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KKJCHBMIONB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GHGJNPLHJDL DIEEDIOOKBJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GHGJNPLHJDL BGCLFNMGEGK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GHGJNPLHJDL GACKGHPNHFN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IIPDMJLEAFA, bool> PKLGKLMGFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKHGAODEBDA();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CJCMCFKPAEE(CKOHOJDPEFN EFBPCCGHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJGNMOFOOGC(CKOHOJDPEFN EFBPCCGHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FBABBLAGEEF(CKOHOJDPEFN EFBPCCGHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LKBKPAENEHH(IIPDMJLEAFA GKHLDKLBDNC, bool DILBCNADBAN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface HCMIBMOKODG : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OGPHHBJBPFI();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IELFINFLANH();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMIEDNHLJHM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task IPGFJMFBHGP(OHNBOJIMJND EFAPNGJIOOF, CancellationToken MJNGPHMPILM);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface CGIDICIEALN : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GCHJEJPKEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGACGDAIILD(IPGFJMFBHGP HAANDGCBPGA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface FNDBBNAOPBB : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus ICPBBFIJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ODKIDMLLLJP(LBBLCNAMBKL GDBABBEBBOF, HEGHJKALNFL LBKPJJFIBIF, CancellationToken DECHKOCCOAA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class IGDHCICBCCA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26ABB70", Offset = "0x26AAF70", VA = "0x1826ABB70")]
	public static bool FGDIOFKFDGB(this FNDBBNAOPBB DHNIACCKLKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CFOGACNBCBD : KNOCCPHNCIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken JODHAMMLAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	MMBGCEPKKOC JHKANIDIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BGDABKNLGMA MCIFHFALKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GJJDEJDBGAI FIMEOGBDMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KKCNBOMMFAG BHKMFKFDGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OCPDGHLKECJ IHDEHCBCPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KEBJMCDEHGP KFPDJKFHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LFHKFJAEBGI FIOOCAOEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HEECAHIIDDB NEPOJJBOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LJNNJIFNHBJ FMNIOPGCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DOILCJMNGKO LDLDHJGFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HCMIBMOKODG NAHMBGOJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FNDBBNAOPBB NFGMDFJNIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CGIDICIEALN OLPGMPAJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CKMNBBAMJEN CLBKGHENCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FLGAOFMICBL NFBDELIFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	OCMDPFKCLAF FPIEBEGNJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OFPKGDGJKFD CADOCKLIDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OILFFNFFKHK MFENPDBIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JEIJJCBFPCC OHNNOKONJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BPICBLADIFC LGNMHNGBFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PAMAFDMCKNL HPCOKNJCOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MLGKEKEFCFC DBDEJNKELKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NHLFFMBNCEF LHAIDFCCDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LINOPFBBAGA PEEFIMBMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EBCBFDJMCKE LOIFGLNLKME
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ALHGIICHNJK OHACAAJHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OIBBAGLKJLK DJCOIDJAIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	COLFLIDOIPP GGAFJJHPEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GBKPAEOLFNC(HEGHJKALNFL ADFHIKOEANN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface CKMNBBAMJEN : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIGBACNOMMA AKBMAMDKLNI(Guid MOLEKIELIBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKDAOIMBAHJ(Guid MOLEKIELIBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDGIADCCEDO(Guid MOLEKIELIBJ, Task KHFGHIMEHMB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPMDAMPPFCM(Guid MOLEKIELIBJ, CJAGNKGLNKE FHJDABIJIML);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AMIEDNHLJHM(Guid MOLEKIELIBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(CJAGNKGLNKE, Task)> NEFNNEEOCJC(Guid MOLEKIELIBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface FLGAOFMICBL : PIIBHELDMJJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface OCMDPFKCLAF : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCGBLHOBDCF(MFNPLLGOGAD KAKCNEMJMJL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJNJDMOBMPM(MFNPLLGOGAD KAKCNEMJMJL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OHOONLDMNHG> LOAOIEEEHGH(CancellationToken BODACEGGKKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate CJAGNKGLNKE GHCDNJGHINO(GLJCDOAILMB CJHAGBLILJN, OHOONLDMNHG FBBJHIOPJFI);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OFPKGDGJKFD : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIGBACNOMMA KOGJNMFBKIK(MFNPLLGOGAD AFDOCNIIOLI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKPOMGHPIFL(Guid MOLEKIELIBJ, Task KHFGHIMEHMB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OILFFNFFKHK : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJAGNKGLNKE> MFENPDBIBKM(MFNPLLGOGAD EHMKLLKELLI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JEIJJCBFPCC : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NGANIFEBMGB> MNOLMFHHCHN(IKIBJCADMMP LNACOMDLNOJ, LBBLCNAMBKL GDBABBEBBOF, CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PAMAFDMCKNL : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJAGNKGLNKE MFBBFHJDIGL(GLJCDOAILMB CJHAGBLILJN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHKBJPHDFHE(string GKBEAKNFHBF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface BPICBLADIFC : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MFNPLLGOGAD> KNGDNFPEBKI(MFNPLLGOGAD EMCPHLBMEHO, NFFKLIOJGMF DDIGKEOCPLO, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MFNPLLGOGAD> NEJPCJPPKDE(CancellationToken BJOMIPBBJKO, NFFKLIOJGMF DDIGKEOCPLO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPDJBKPIGJG FADGACEANPG(NMCMEOAHLPH CEJKJHKFODJ, IKIBJCADMMP LNACOMDLNOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NPDJBKPIGJG CCPFJFBAKJH(NMCMEOAHLPH CEJKJHKFODJ, IKIBJCADMMP LNACOMDLNOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MLGKEKEFCFC : PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJAGNKGLNKE CCPIABMGLMH(GLJCDOAILMB CJHAGBLILJN, OHOONLDMNHG FBBJHIOPJFI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJAGNKGLNKE HLHLKHCNLDM(GLJCDOAILMB PIPIGAHIOGG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CJAGNKGLNKE EEDDIANHLPO(GLJCDOAILMB PIPIGAHIOGG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NHLFFMBNCEF
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGPEPKKPBEO(DAGFLHPIIDO EIBKDKICMBE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPCOEFPFFBK(DAGFLHPIIDO EIBKDKICMBE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCEHJPPBAKI(DAGFLHPIIDO EIBKDKICMBE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IILIMIHJAMO(DAGFLHPIIDO EIBKDKICMBE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DAGFLHPIIDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly LBBLCNAMBKL LCPGAPDBFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, string> GNEGEKGHMBN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::DGKJHGKIMMO<string> BEEOPPCLEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public DAGFLHPIIDO(LBBLCNAMBKL PINGFGAGGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2699200", Offset = "0x2698600", VA = "0x182699200")]
	public DAGFLHPIIDO PPNEOICFFMO(string FOJIGKKHICE, string IGDJJEECDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2699160", Offset = "0x2698560", VA = "0x182699160")]
	public bool BLIHINMGOGE(out IEnumerable<KeyValuePair<string, string>> CMGLDOLIOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26991E0", Offset = "0x26985E0", VA = "0x1826991E0")]
	public DAGFLHPIIDO NPCHFGJAHEO(global::DGKJHGKIMMO<string> ANOJNPAHJKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OIBBAGLKJLK
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KAGIDGJDKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string IBINLCJFFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMCMNOJMBHB();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	APKNGAEPGMP GBJEEBJAELN(long LAPDEGDDDKC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::IFHFCDGGKJJ<NHJHNDPNKHC, ONLLFCEBJLC> NOFIFHLHFOD(long LAPDEGDDDKC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::IFHFCDGGKJJ<NHJHNDPNKHC, BLKLDFBMGPO> EENKMAAJOMA(long LAPDEGDDDKC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::IFHFCDGGKJJ<long, GANFMPDCCEC> BHDCEGHNIGM();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> KBFLFAAKMEI(byte[] GMKNCGJLIDK, byte[] LHJAGPNOAJM, CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KNOCCPHNCIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FGDIOFKFDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool GEIELBLCLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task LLFADCCOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HEGHJKALNFL CNEPNFGCALG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action KKJCHBMIONB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GHGJNPLHJDL DIEEDIOOKBJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GHGJNPLHJDL BGCLFNMGEGK;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GHGJNPLHJDL GACKGHPNHFN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IIPDMJLEAFA, bool> PKLGKLMGFMJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IELFINFLANH();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HLLHHPPDABG ABEEDJDBPGD();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AEGIABKBBOD GIGGCLNBFNM();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<CJAGNKGLNKE> GAKNBGINLEI(LMBGJPBKLNM MGLNAHCNMBL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task MNIPDLPKAJK(CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KKCNBOMMFAG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BBGGFLPLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string KKLBMAPDMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMJNNEPOLJP(Scene OEFIKLDOOIB);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JOKBPHMGFNI(PKDOPDLBJEI KPPHICBEPJB, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CMFEFJHNOJD();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CANONBEOPPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int JNGHHPOPLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DMMANBAIHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LEABELDLDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool AJBGPPCPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GJAELJJFNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool GPDKMANDHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	GLJCDOAILMB DHBHJHKBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EEBAHNKJJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBGCEPKKOC EPLMJABEPFF(MMBGCEPKKOC MKGOJGCIFGJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEJJNONBFFO(MMBGCEPKKOC CKGKDHACBKE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EBDBAIMNNCK(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MKMOCHMAHCP(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OJJEAFPPJFE(OGFFMBDIIFG AAMNHHPLJGD, [Optional] CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IAIHAIKOJHJ(float AEAEDGLFDAP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FPLCPLFOLCA(string AGEOBIJKNAA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<JOPIPFFKHBD> EPAEDAIPPDP();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable GEIACGIDJLO(object GKMHGIGLKCO, JOPIPFFKHBD JCMHKDFCHKO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ONLLFCEBJLC HPALHBMJHGI();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OABNJPPJLBB(int HCMNBAODNBE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JLCDPMAOMOD();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IFJGOEIFJBE();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool HCFICECJFFC();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LBKOPEKOHOH(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task FPGJOGGFAEF(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<HKEHDAKLJOE> EHMCJKLBIFI(DateTime IGAFEJLFKIO, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> PKEFAALDIPN(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FANKCBHPJGL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LBBAFPIBHHO IDOLJLGCNMJ(HIJAJEKEJIL LPOOJCLNGFL, BLKLDFBMGPO HBAOAKAIFAG, IEnumerable<PersistenceView> JJBKPOJOCCN, ref OAPBKONKIMK NACIEOCNAFE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IPFHNCJGNDH(NBMCGLEDJNH FAPFPPANPDB, in LBBAFPIBHHO IJBJEBDOLMK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OBIOJHBNBLA(BLKLDFBMGPO JBECKINBFJM, bool PHLOBJIDPJA);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PBHADMCPIJF();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GMNBGFAEOGK(long DDEPFHBCOHC, long BGHKIEHCOCI, PCBJAABEHPG CCOKLHEHHJD, KEGHMBLLMCM ALMGFMEBNFC);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PPAJLNPCHJM(long DDEPFHBCOHC, long BGHKIEHCOCI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PGBFDOCGKOC(PersistenceView KIJDNKIKDEA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool CONMGKBHEFG(PersistenceView ANICJOOMAKF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool NOCPDMIDPNO(NBMCGLEDJNH FAPFPPANPDB, CHICPPMIFLO FALBEGMMFHC, out ANABMJHNMOB POFIPBBFMGL);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DHBPLBMNBAK();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DOPCDADOADH();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable DOHMJDALLOG();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EPDGJEBKMDF(BLKLDFBMGPO JBECKINBFJM, CHICPPMIFLO FALBEGMMFHC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> KAEICAHADAP(BGDABKNLGMA CHLPJFPJJFO, CancellationToken BJOMIPBBJKO, IKIBJCADMMP LNACOMDLNOJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PNDLINHIHHF(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<CONFMKJIMDP> KJJOLKGPBMC(long DDEPFHBCOHC, long BGHKIEHCOCI, string OJHPMMBEEBE, IJECPJOJAHC.DDEDHFMIFJK EFAPNGJIOOF, IJECPJOJAHC.DDEDHFMIFJK LHJAGPNOAJM, IReadOnlyDictionary<long, int> GFKKHBAGCAA, int JHKENLBIBLN, string FILMPDJDFNH, bool GPLIMBGHDPP, int FNJAEMJHNGL);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ABAALCOFOBC> OJBFPOIFHGN(string IEAFHNALNCG, long DDEPFHBCOHC, long BGHKIEHCOCI, string OJHPMMBEEBE, IJECPJOJAHC.DDEDHFMIFJK EFAPNGJIOOF, IJECPJOJAHC.DDEDHFMIFJK LHJAGPNOAJM, int KECIOLCNGHC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PCBJAABEHPG> ENBKMJKANFB(long DDEPFHBCOHC, bool JFEBGOHJFDK, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool BPJDEMAJHBK();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool KGKODAPNNML();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GMAHJCHKGPF(IEnumerable<ANABMJHNMOB> LJNDBGLFDJM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void APKPEGJGNAO(List<GameObject> BFHNEJPDIEG);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float MHBJPNLNDEI();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool ALGLNBJEFEL(string JAOGIFGAJOA, out Scene MJJNOEJBKMP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> MCFHPCLDFPC(string JAOGIFGAJOA, LoadSceneMode INPBOMALAOG, bool FPOOHKFBODH, IKIBJCADMMP ANOJNPAHJKB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void HKOAOFIOMBL();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool DLKEGBLNCHP(ByteString BIPDDAIIHHG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MDLAIAGEELJ(LBBLCNAMBKL NJCMHKBLDNC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task KECNCFOBEEJ(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task EOFAKDKNFGN(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CGEFMPLKENL();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable NKPOEAKOPBB();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	FJGLKMANPAI ADLECPPKBJG();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FJGLKMANPAI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OOEKMLMAJJD(CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LJBKFBAEMJG(CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LBBAFPIBHHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HashSet<int> GPJKCKJKLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IDisposable COAGKCKAADF;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x26B1960", Offset = "0x26B0D60", VA = "0x1826B1960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HKEHDAKLJOE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LPKCDHNKKJE
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	LBBLCNAMBKL ALLGLOPOCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	PCBJAABEHPG FIJJAAHOJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FHLHIJKLEKO KBFABJJODCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OOBPFBIBFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CFBNLBAFAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int JNGHHPOPLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action EDIOMELFFNG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> GCLLGAKBJBM;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFDONABFKHM();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.KOMCHOKLCMN> BDFDKJIJLCH();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DJHJOAENBJA();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(LBBLCNAMBKL, HEGHJKALNFL) KGDJHGGHPGK();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HDKAGFAIENG FMFJIMIFDHC();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KAFCKGEFLDM(long LAPDEGDDDKC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LINOPFBBAGA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDAJFILCHKI(out IEnumerable<int> LLLHABKGCFE);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNNEBCCCDPH(JGNPMEGNACG MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHOFLCDDPPI(JGNPMEGNACG MJNGPHMPILM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HHEICLBHKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JIDMCDDJOOD(CJAGNKGLNKE MAIMHEEFNAP);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface NODJJJKLAHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PONMLAKFOCM(BMPAKMCHFPJ.EFLMPBENEMB OAAMBMNEJIM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOPBKLFOKNO(BMPAKMCHFPJ.EFLMPBENEMB OAAMBMNEJIM);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OCPDGHLKECJ : NODJJJKLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJAGNKGLNKE FKGCPEIHBGF(GLJCDOAILMB PIPIGAHIOGG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KEBJMCDEHGP : NODJJJKLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJAGNKGLNKE MFBBFHJDIGL(GLJCDOAILMB BKCMLHPPECC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface APKNGAEPGMP
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BFOGDGGAJLJ<PKDOPDLBJEI, DJBJKBPDGID>> AFHNJOGNINA(string OJHPMMBEEBE, long LAPDEGDDDKC, HEOMPLODKGB.PFGCJHJCHBH FECBNLJGOFC, CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IFHFCDGGKJJ<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BFOGDGGAJLJ<byte[], DJBJKBPDGID>> LIGBKLNLFCP(TGetDataArg NJOHOALIBEB, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BFOGDGGAJLJ<global::NCLCEHNCJOC<TData>, DJBJKBPDGID> FIHIECBPCKF(byte[] PNMIIEJFOON);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class MBMLIHJPPHI : CFOGACNBCBD, KNOCCPHNCIA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GLODKKNEIPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MBMLIHJPPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public LMBGJPBKLNM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x323ABC0", Offset = "0x3239FC0", VA = "0x18323ABC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x323AE60", Offset = "0x323A260", VA = "0x18323AE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct LDECHPJDGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MBMLIHJPPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x32412F0", Offset = "0x32406F0", VA = "0x1832412F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ABJEELGAJEG : IEnumerable<PIIBHELDMJJ>, IEnumerable, IEnumerator<PIIBHELDMJJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PIIBHELDMJJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MBMLIHJPPHI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private PIIBHELDMJJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public ABJEELGAJEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3232180", Offset = "0x3231580", VA = "0x183232180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x32325C0", Offset = "0x32319C0", VA = "0x1832325C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3232520", Offset = "0x3231920", VA = "0x183232520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PIIBHELDMJJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3232520", Offset = "0x3231920", VA = "0x183232520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CancellationTokenSource IHDBFIKAKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MMBGCEPKKOC CKGKDHACBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private OPLAPIGKHFI PMELELBCFNJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public BGDABKNLGMA MCIFHFALKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6780D0", Offset = "0x6774D0", VA = "0x1806780D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x770310", Offset = "0x76F710", VA = "0x180770310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GJJDEJDBGAI FIMEOGBDMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x68E760", Offset = "0x68DB60", VA = "0x18068E760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x702000", Offset = "0x701400", VA = "0x180702000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6780B0", Offset = "0x6774B0", VA = "0x1806780B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x770300", Offset = "0x76F700", VA = "0x180770300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KKCNBOMMFAG BHKMFKFDGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x719AB0", Offset = "0x718EB0", VA = "0x180719AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OCPDGHLKECJ IHDEHCBCPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x68E780", Offset = "0x68DB80", VA = "0x18068E780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7702F0", Offset = "0x76F6F0", VA = "0x1807702F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public KEBJMCDEHGP KFPDJKFHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x68E700", Offset = "0x68DB00", VA = "0x18068E700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A0860", Offset = "0x69FC60", VA = "0x1806A0860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LFHKFJAEBGI FIOOCAOEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x68E710", Offset = "0x68DB10", VA = "0x18068E710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDB0", Offset = "0x6AF1B0", VA = "0x1806AFDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HEECAHIIDDB NEPOJJBOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6B46D0", Offset = "0x6B3AD0", VA = "0x1806B46D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD90", Offset = "0x6AF190", VA = "0x1806AFD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LJNNJIFNHBJ FMNIOPGCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x67ED80", Offset = "0x67E180", VA = "0x18067ED80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x915880", Offset = "0x914C80", VA = "0x180915880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DOILCJMNGKO LDLDHJGFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x67EE20", Offset = "0x67E220", VA = "0x18067EE20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7F79F0", Offset = "0x7F6DF0", VA = "0x1807F79F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HCMIBMOKODG NAHMBGOJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6B46A0", Offset = "0x6B3AA0", VA = "0x1806B46A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x914EA0", Offset = "0x9142A0", VA = "0x180914EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FNDBBNAOPBB NFGMDFJNIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68E720", Offset = "0x68DB20", VA = "0x18068E720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDA0", Offset = "0x6AF1A0", VA = "0x1806AFDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CGIDICIEALN OLPGMPAJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x68E730", Offset = "0x68DB30", VA = "0x18068E730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6FC540", Offset = "0x6FB940", VA = "0x1806FC540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CKMNBBAMJEN CLBKGHENCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x68E750", Offset = "0x68DB50", VA = "0x18068E750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4E0", Offset = "0x7AA8E0", VA = "0x1807AB4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public FLGAOFMICBL NFBDELIFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x68E740", Offset = "0x68DB40", VA = "0x18068E740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDC0", Offset = "0x6AF1C0", VA = "0x1806AFDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OCMDPFKCLAF FPIEBEGNJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C00", Offset = "0x7A8000", VA = "0x1807A8C00", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7A92F0", Offset = "0x7A86F0", VA = "0x1807A92F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OFPKGDGJKFD CADOCKLIDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7307A0", Offset = "0x72FBA0", VA = "0x1807307A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C10", Offset = "0x7A8010", VA = "0x1807A8C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public OILFFNFFKHK MFENPDBIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AB220", Offset = "0x7AA620", VA = "0x1807AB220", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7AB310", Offset = "0x7AA710", VA = "0x1807AB310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public JEIJJCBFPCC OHNNOKONJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DC0", Offset = "0x7F41C0", VA = "0x1807F4DC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EA0", Offset = "0x7F42A0", VA = "0x1807F4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public BPICBLADIFC LGNMHNGBFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7A98A0", Offset = "0x7A8CA0", VA = "0x1807A98A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B10", Offset = "0x7F4F10", VA = "0x1807F5B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PAMAFDMCKNL HPCOKNJCOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7A95A0", Offset = "0x7A89A0", VA = "0x1807A95A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7A98D0", Offset = "0x7A8CD0", VA = "0x1807A98D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MLGKEKEFCFC DBDEJNKELKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9580", Offset = "0x7A8980", VA = "0x1807A9580", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7A98B0", Offset = "0x7A8CB0", VA = "0x1807A98B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NHLFFMBNCEF LHAIDFCCDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9590", Offset = "0x7A8990", VA = "0x1807A9590", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7A98C0", Offset = "0x7A8CC0", VA = "0x1807A98C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LINOPFBBAGA PEEFIMBMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B00", Offset = "0x7F4F00", VA = "0x1807F5B00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x10163F0", Offset = "0x10157F0", VA = "0x1810163F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EBCBFDJMCKE LOIFGLNLKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7A9880", Offset = "0x7A8C80", VA = "0x1807A9880", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A20", Offset = "0x7A8E20", VA = "0x1807A9A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public ALHGIICHNJK OHACAAJHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7A9890", Offset = "0x7A8C90", VA = "0x1807A9890", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A30", Offset = "0x7A8E30", VA = "0x1807A9A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OIBBAGLKJLK DJCOIDJAIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAD67D0", Offset = "0xAD5BD0", VA = "0x180AD67D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xAD5E60", Offset = "0xAD5260", VA = "0x180AD5E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public COLFLIDOIPP GGAFJJHPEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAD4930", Offset = "0xAD3D30", VA = "0x180AD4930", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public HEGHJKALNFL CNEPNFGCALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x101EED0", Offset = "0x101E2D0", VA = "0x18101EED0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x13BC740", Offset = "0x13BBB40", VA = "0x1813BC740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool EJOFKKDLAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x26B5900", Offset = "0x26B4D00", VA = "0x1826B5900", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool JLJCOMFCNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x26B57C0", Offset = "0x26B4BC0", VA = "0x1826B57C0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task IHFJNJLMAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x26B5000", Offset = "0x26B4400", VA = "0x1826B5000", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken BAOIEMNHAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x26B5050", Offset = "0x26B4450", VA = "0x1826B5050", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private MMBGCEPKKOC DAHODHIJKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action LMGNJBDBKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x26B5840", Offset = "0x26B4C40", VA = "0x1826B5840", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x26B5650", Offset = "0x26B4A50", VA = "0x1826B5650", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event GHGJNPLHJDL FFLMOHADBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D40", Offset = "0x26B5140", VA = "0x1826B5D40", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x26B50D0", Offset = "0x26B44D0", VA = "0x1826B50D0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event GHGJNPLHJDL HKCCNLPFHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x26B58A0", Offset = "0x26B4CA0", VA = "0x1826B58A0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x26B56B0", Offset = "0x26B4AB0", VA = "0x1826B56B0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event GHGJNPLHJDL LFFMMNJIGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x26B5190", Offset = "0x26B4590", VA = "0x1826B5190", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x26B5070", Offset = "0x26B4470", VA = "0x1826B5070", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<IIPDMJLEAFA, bool> CIOIBBHEPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x26B5380", Offset = "0x26B4780", VA = "0x1826B5380", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x26B5710", Offset = "0x26B4B10", VA = "0x1826B5710", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x13BC740", Offset = "0x13BBB40", VA = "0x1813BC740", Slot = "34")]
	public void GBKPAEOLFNC(HEGHJKALNFL ADFHIKOEANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26B5E10", Offset = "0x26B5210", VA = "0x1826B5E10")]
	[Preserve]
	internal MBMLIHJPPHI([IMNCNOGBAJI(null)] MMBGCEPKKOC CKGKDHACBKE, [IMNCNOGBAJI(null)] BGDABKNLGMA CHLPJFPJJFO, [IMNCNOGBAJI(null)] GJJDEJDBGAI PKNECOIMOEA, [IMNCNOGBAJI(null)] CANONBEOPPD GEEOPHADFKF, [IMNCNOGBAJI(null)] KKCNBOMMFAG IEEAPMBGDLK, [IMNCNOGBAJI(null)] OCPDGHLKECJ PBDLPGEAAFM, [IMNCNOGBAJI(null)] KEBJMCDEHGP PNMKAGOAOAP, [IMNCNOGBAJI(null)] LFHKFJAEBGI ELEIJOGPKLI, [IMNCNOGBAJI(null)] HEECAHIIDDB GKNNNJIIFKK, [IMNCNOGBAJI(null)] LJNNJIFNHBJ GCPGFPJICFJ, [IMNCNOGBAJI(null)] DOILCJMNGKO BMEDMCDHJAD, [IMNCNOGBAJI(null)] HCMIBMOKODG HOOHKIDPJIC, [IMNCNOGBAJI(null)] FNDBBNAOPBB DHNIACCKLKK, [IMNCNOGBAJI(null)] CGIDICIEALN KJFALAAMIPK, [IMNCNOGBAJI(null)] CKMNBBAMJEN NCAIMMECKBK, [IMNCNOGBAJI(null)] FLGAOFMICBL GLIBPLEFDNJ, [IMNCNOGBAJI(null)] OCMDPFKCLAF NAKNPMGKGNM, [IMNCNOGBAJI(null)] OFPKGDGJKFD CJFPHNDAGHC, [IMNCNOGBAJI(null)] OILFFNFFKHK NKBPLJNHAJK, [IMNCNOGBAJI(null)] JEIJJCBFPCC GDAPNDBNHIO, [IMNCNOGBAJI(null)] PAMAFDMCKNL FOMJHADIFBK, [IMNCNOGBAJI(null)] BPICBLADIFC LBLDNOJIDIP, [IMNCNOGBAJI(null)] MLGKEKEFCFC KLFACLBACCG, [IMNCNOGBAJI(null)] NHLFFMBNCEF KECKMDPKMCJ, [IMNCNOGBAJI(null)] LINOPFBBAGA MNABDOBMPFF, [IMNCNOGBAJI(null)] ALHGIICHNJK FBPEKKHBHEP, [IMNCNOGBAJI(null)] OIBBAGLKJLK ADNLKFHBHAO, [IMNCNOGBAJI(null)] COLFLIDOIPP APELCLDEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x26B5AA0", Offset = "0x26B4EA0", VA = "0x1826B5AA0")]
	private void LJAJKOINHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x26B51F0", Offset = "0x26B45F0", VA = "0x1826B51F0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x26B5770", Offset = "0x26B4B70", VA = "0x1826B5770", Slot = "48")]
	private void HLELOFLGEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x26B5500", Offset = "0x26B4900", VA = "0x1826B5500", Slot = "49")]
	private HLLHHPPDABG FDGBKGJPGPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x26B5B90", Offset = "0x26B4F90", VA = "0x1826B5B90", Slot = "50")]
	private AEGIABKBBOD NDOCAAOEEPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x26B5960", Offset = "0x26B4D60", VA = "0x1826B5960", Slot = "51")]
	[AsyncStateMachine(typeof(GLODKKNEIPA))]
	private Task<CJAGNKGLNKE> KLNBDGEDJFK(LMBGJPBKLNM HHCPLMDOPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x26B53E0", Offset = "0x26B47E0", VA = "0x1826B53E0", Slot = "52")]
	[AsyncStateMachine(typeof(LDECHPJDGDD))]
	private Task EPCJNDOFJCA(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x26B5DA0", Offset = "0x26B51A0", VA = "0x1826B5DA0")]
	[IteratorStateMachine(typeof(ABJEELGAJEG))]
	private IEnumerable<PIIBHELDMJJ> OEJLFAICGOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x26B5130", Offset = "0x26B4530", VA = "0x1826B5130")]
	[CompilerGenerated]
	private void DLLHIEKLLOH(PIIBHELDMJJ HEKOHKDELMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class MEDLGLFKKPN : ALHBGAJNLDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EHNGDNMMEKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MEDLGLFKKPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3238940", Offset = "0x3237D40", VA = "0x183238940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3238CC0", Offset = "0x32380C0", VA = "0x183238CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6786E0", Offset = "0x677AE0", VA = "0x1806786E0")]
	public MEDLGLFKKPN(CFOGACNBCBD IPNLLMLMMNI, CANONBEOPPD GEEOPHADFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x26B62D0", Offset = "0x26B56D0", VA = "0x1826B62D0", Slot = "4")]
	[AsyncStateMachine(typeof(EHNGDNMMEKM))]
	public Task<bool> LGBDBCAICBC(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26B61F0", Offset = "0x26B55F0", VA = "0x1826B61F0")]
	[CompilerGenerated]
	private object JJOBHJOPNMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class IMPABNOAFND : ALHBGAJNLDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JIIOAOIKHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IMPABNOAFND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x323E530", Offset = "0x323D930", VA = "0x18323E530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x323EB60", Offset = "0x323DF60", VA = "0x18323EB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const float GGFDDFADGDF = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x26ABE20", Offset = "0x26AB220", VA = "0x1826ABE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6786E0", Offset = "0x677AE0", VA = "0x1806786E0")]
	public IMPABNOAFND(CFOGACNBCBD IPNLLMLMMNI, CANONBEOPPD GEEOPHADFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x26ABCE0", Offset = "0x26AB0E0", VA = "0x1826ABCE0", Slot = "4")]
	[AsyncStateMachine(typeof(JIIOAOIKHDD))]
	public Task<bool> LGBDBCAICBC(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x26ABC00", Offset = "0x26AB000", VA = "0x1826ABC00")]
	[CompilerGenerated]
	private object GBKIPHHGGNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class KJBBIIAHPCN : ALHBGAJNLDI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JNECLLLGDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KJBBIIAHPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Matchmaking.KOMCHOKLCMN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LBBLCNAMBKL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JNECLLLGDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x323EFA0", Offset = "0x323E3A0", VA = "0x18323EFA0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x323F0F0", Offset = "0x323E4F0", VA = "0x18323F0F0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x323F160", Offset = "0x323E560", VA = "0x18323F160")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BEEJMIKFNEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KJBBIIAHPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JNECLLLGDFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Matchmaking.KOMCHOKLCMN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3234070", Offset = "0x3233470", VA = "0x183234070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3234930", Offset = "0x3233D30", VA = "0x183234930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private const float GGFDDFADGDF = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x26B1450", Offset = "0x26B0850", VA = "0x1826B1450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6786E0", Offset = "0x677AE0", VA = "0x1806786E0")]
	public KJBBIIAHPCN(CFOGACNBCBD IPNLLMLMMNI, CANONBEOPPD GEEOPHADFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x26B1310", Offset = "0x26B0710", VA = "0x1826B1310", Slot = "4")]
	[AsyncStateMachine(typeof(BEEJMIKFNEJ))]
	public Task<bool> LGBDBCAICBC(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface ALHBGAJNLDI
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LGBDBCAICBC(CancellationToken BJOMIPBBJKO);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct GJFBPCPMDMP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class MLHMNHIGKII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CFOGACNBCBD manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MLHMNHIGKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x302CA80", Offset = "0x302BE80", VA = "0x18302CA80")]
		internal Task <CreateTask>b__0(OHNBOJIMJND data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LGKLJHAFHBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public GJFBPCPMDMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private LMBGJPBKLNM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<HKEHDAKLJOE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x302B1F0", Offset = "0x302A5F0", VA = "0x18302B1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x302B770", Offset = "0x302AB70", VA = "0x18302B770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DDLMCAKMHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GJFBPCPMDMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3022A30", Offset = "0x3021E30", VA = "0x183022A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly CancellationToken BJOMIPBBJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly CFOGACNBCBD LHHJJDCDFNG;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private BGDABKNLGMA MCIFHFALKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x26A66E0", Offset = "0x26A5AE0", VA = "0x1826A66E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x26A6BA0", Offset = "0x26A5FA0", VA = "0x1826A6BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x26A6A10", Offset = "0x26A5E10", VA = "0x1826A6A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private LJNNJIFNHBJ FMNIOPGCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x26A6A90", Offset = "0x26A5E90", VA = "0x1826A6A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x26A6BF0", Offset = "0x26A5FF0", VA = "0x1826A6BF0")]
	public GJFBPCPMDMP(CancellationToken BJOMIPBBJKO, CFOGACNBCBD LHHJJDCDFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x26A6AE0", Offset = "0x26A5EE0", VA = "0x1826A6AE0")]
	public static IPGFJMFBHGP PDPGEGLLIKF(CFOGACNBCBD LHHJJDCDFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x26A65B0", Offset = "0x26A59B0", VA = "0x1826A65B0")]
	[AsyncStateMachine(typeof(LGKLJHAFHBI))]
	public Task<bool> CECDLANABFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x26A6730", Offset = "0x26A5B30", VA = "0x1826A6730")]
	private bool GFONGCLGIAK(out LMBGJPBKLNM HHCPLMDOPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x26A64B0", Offset = "0x26A58B0", VA = "0x1826A64B0")]
	[AsyncStateMachine(typeof(DDLMCAKMHFP))]
	private Task BANMIAEMCMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x26A68D0", Offset = "0x26A5CD0", VA = "0x1826A68D0")]
	private Task<HKEHDAKLJOE> GHONKAHPKKK(LMBGJPBKLNM JKHEBDFMLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct LIGBACNOMMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CKMNBBAMJEN NCAIMMECKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Guid MOLEKIELIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(CJAGNKGLNKE, Task)> CHDFPJKEAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x26B4240", Offset = "0x26B3640", VA = "0x1826B4240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D57CA0", Offset = "0x1D570A0", VA = "0x181D57CA0")]
	public LIGBACNOMMA(CKMNBBAMJEN NCAIMMECKBK, Guid MOLEKIELIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26B4310", Offset = "0x26B3710", VA = "0x1826B4310")]
	public TaskAwaiter<(CJAGNKGLNKE, Task)> KKLFLJCMIFJ()
	{
		return default(TaskAwaiter<(CJAGNKGLNKE, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26B4170", Offset = "0x26B3570", VA = "0x1826B4170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct HJMLJNDDLNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TaskCompletionSource<(CJAGNKGLNKE, Task)> EHDOEDNINAF;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(CJAGNKGLNKE, Task)> CHDFPJKEAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x26A7660", Offset = "0x26A6A60", VA = "0x1826A7660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x26A7730", Offset = "0x26A6B30", VA = "0x1826A7730")]
	public HJMLJNDDLNB(TimeSpan BMIAOLHKMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x26A7530", Offset = "0x26A6930", VA = "0x1826A7530")]
	public void CBPMAKBCHOD(Task KHFGHIMEHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x26A75D0", Offset = "0x26A69D0", VA = "0x1826A75D0")]
	public void ICBDDMFIGNP(CJAGNKGLNKE MAIMHEEFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x26A74E0", Offset = "0x26A68E0", VA = "0x1826A74E0")]
	public void BBIHFPKHFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x26A76A0", Offset = "0x26A6AA0", VA = "0x1826A76A0")]
	internal void KJNAALKAGFJ(string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class DJJFGEDGIFI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EDJPGLODOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EDJPGLODOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x115F080", Offset = "0x115E480", VA = "0x18115F080")]
		internal bool <Create>b__0(FHLHIJKLEKO subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x269A2F0", Offset = "0x26996F0", VA = "0x18269A2F0")]
	public static NGANIFEBMGB FNICMNFMKAL(long MBADJDCHPMA, long BGHKIEHCOCI, NHJHNDPNKHC GMKNCGJLIDK, string OJHPMMBEEBE, NHJHNDPNKHC LHJAGPNOAJM, string IEAFHNALNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x269A430", Offset = "0x2699830", VA = "0x18269A430")]
	public static NGANIFEBMGB FNICMNFMKAL(PCBJAABEHPG CKINMMHODBE, DBGHAPPHDML HCPFINODJKO, [Optional] string IEAFHNALNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x269A0D0", Offset = "0x26994D0", VA = "0x18269A0D0")]
	public static NGANIFEBMGB FNICMNFMKAL(PCBJAABEHPG CKINMMHODBE, long BGHKIEHCOCI, [Optional] string IEAFHNALNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x269A5A0", Offset = "0x26999A0", VA = "0x18269A5A0")]
	public static NGANIFEBMGB MGMNIJBBBBD(this NGANIFEBMGB NEIPJLDAIJA, PCBJAABEHPG MJGCCOBHMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2699F10", Offset = "0x2699310", VA = "0x182699F10")]
	public static NGANIFEBMGB BCNBLIAFIFO(this NGANIFEBMGB NEIPJLDAIJA, DBGHAPPHDML LOGODPMFMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2699FF0", Offset = "0x26993F0", VA = "0x182699FF0")]
	public static NGANIFEBMGB BCNBLIAFIFO(this NGANIFEBMGB NEIPJLDAIJA, FHLHIJKLEKO CHIMNGEFCIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Preserve]
internal class MLOMEKBNKMG : HEECAHIIDDB, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IIHODKKCIPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public MLOMEKBNKMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x323DB90", Offset = "0x323CF90", VA = "0x18323DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly JGNPMEGNACG HNEBDHBIHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string KJAGJADMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Task PGNIJDPIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BIGFBEMLHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x26B6E80", Offset = "0x26B6280", VA = "0x1826B6E80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task NPJKOPLBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x26B6EB0", Offset = "0x26B62B0", VA = "0x1826B6EB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0", Slot = "7")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x26B6BD0", Offset = "0x26B5FD0", VA = "0x1826B6BD0", Slot = "6")]
	public void MCAELAPCBBO(Task MPDGFCFNFOK, string OOCIGPPHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x26B6D50", Offset = "0x26B6150", VA = "0x1826B6D50")]
	[AsyncStateMachine(typeof(IIHODKKCIPA))]
	private Task OBPFDLGNIJA(Task FNIONFDAIAL, string OOCIGPPHHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x26B6F10", Offset = "0x26B6310", VA = "0x1826B6F10")]
	public MLOMEKBNKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class DABGNMAFIMA : EBCBFDJMCKE, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool KNJKHPPFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private MBHCBBFEHOI BLINCJOEKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private ALHGIICHNJK FBPEKKHBHEP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MBHCBBFEHOI JLAGAJPDAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x26988E0", Offset = "0x2697CE0", VA = "0x1826988E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2698B10", Offset = "0x2697F10", VA = "0x182698B10", Slot = "7")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2698950", Offset = "0x2697D50", VA = "0x182698950", Slot = "5")]
	public void IKKBBDKDBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x26988A0", Offset = "0x2697CA0", VA = "0x1826988A0", Slot = "6")]
	public void BOPHFFGBAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2698C20", Offset = "0x2698020", VA = "0x182698C20")]
	private Task OIEFAOBCLAP(NNHIIKOGOIH FAHGJOEFBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x26988A0", Offset = "0x2697CA0", VA = "0x1826988A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DABGNMAFIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class DAEINAOOGFG : ALHGIICHNJK
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class OPPBIPAFLAE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly CFLPNBFBGMN NFONAKLDNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly string FOJIGKKHICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly T HNGNIFMJFIP;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T KGOGAJOHGBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x67C250", Offset = "0x67B650", VA = "0x18067C250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x67C270", Offset = "0x67B670", VA = "0x18067C270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F160", Offset = "0x3C6E560", VA = "0x183C6F160")]
		public OPPBIPAFLAE(CFLPNBFBGMN NFONAKLDNPH, string FOJIGKKHICE, T HNGNIFMJFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EDB0", Offset = "0x3C6E1B0", VA = "0x183C6EDB0")]
		private void LFDJEJJIEFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly OPPBIPAFLAE<TimeSpan> GGGHOLDCGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly OPPBIPAFLAE<TimeSpan> NOHKHIPEMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly OPPBIPAFLAE<TimeSpan> CJHCIPDGIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly OPPBIPAFLAE<TimeSpan> LCHKNLFNKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OPPBIPAFLAE<bool> DOIKOBGGGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly OPPBIPAFLAE<bool> FCBFDMKAFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly OPPBIPAFLAE<bool> MHACEIOMNIM;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan MJFBGHLFEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2698DA0", Offset = "0x26981A0", VA = "0x182698DA0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan EMCPCKFIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2698CA0", Offset = "0x26980A0", VA = "0x182698CA0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan BIKLPAMLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2698CE0", Offset = "0x26980E0", VA = "0x182698CE0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan JEKHFLHCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2698D60", Offset = "0x2698160", VA = "0x182698D60", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool IKDKNCGBILB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2698DE0", Offset = "0x26981E0", VA = "0x182698DE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool CEGNOHLCCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2698E20", Offset = "0x2698220", VA = "0x182698E20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool OMDEHEBHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2698D20", Offset = "0x2698120", VA = "0x182698D20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2698E60", Offset = "0x2698260", VA = "0x182698E60")]
	[Preserve]
	public DAEINAOOGFG([IMNCNOGBAJI(null)] CFLPNBFBGMN NFONAKLDNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class FICMDBEDMPL : DOILCJMNGKO, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class MLLMKLOHNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CKOHOJDPEFN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MLLMKLOHNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x302CAC0", Offset = "0x302BEC0", VA = "0x18302CAC0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action KKJCHBMIONB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x269D570", Offset = "0x269C970", VA = "0x18269D570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x269D380", Offset = "0x269C780", VA = "0x18269D380", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event GHGJNPLHJDL DIEEDIOOKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x269CD80", Offset = "0x269C180", VA = "0x18269CD80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x269CCE0", Offset = "0x269C0E0", VA = "0x18269CCE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GHGJNPLHJDL BGCLFNMGEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x269D060", Offset = "0x269C460", VA = "0x18269D060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x269D420", Offset = "0x269C820", VA = "0x18269D420", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GHGJNPLHJDL GACKGHPNHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x269CFC0", Offset = "0x269C3C0", VA = "0x18269CFC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x269CF20", Offset = "0x269C320", VA = "0x18269CF20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<IIPDMJLEAFA, bool> PKLGKLMGFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x269D610", Offset = "0x269CA10", VA = "0x18269D610", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x269CE20", Offset = "0x269C220", VA = "0x18269CE20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "19")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x269D6B0", Offset = "0x269CAB0", VA = "0x18269D6B0", Slot = "14")]
	public void PKHGAODEBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x269CEC0", Offset = "0x269C2C0", VA = "0x18269CEC0", Slot = "15")]
	public void CJCMCFKPAEE(CKOHOJDPEFN EFBPCCGHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x269CEF0", Offset = "0x269C2F0", VA = "0x18269CEF0", Slot = "16")]
	public void CJGNMOFOOGC(CKOHOJDPEFN EFBPCCGHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x269D100", Offset = "0x269C500", VA = "0x18269D100", Slot = "17")]
	public void FBABBLAGEEF(CKOHOJDPEFN EFBPCCGHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x269D4C0", Offset = "0x269C8C0", VA = "0x18269D4C0", Slot = "18")]
	public void LKBKPAENEHH(IIPDMJLEAFA GKHLDKLBDNC, bool DILBCNADBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x269D130", Offset = "0x269C530", VA = "0x18269D130")]
	private void FGMLNBEAMPP(GHGJNPLHJDL JCMHKDFCHKO, CKOHOJDPEFN EFBPCCGHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FICMDBEDMPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class OKJLJLKIJBC : HCMIBMOKODG, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct BCFGGHALEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OKJLJLKIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x46C98E0", Offset = "0x46C8CE0", VA = "0x1846C98E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct EPMGHGHNPBM : IAsyncStateMachine
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
		public OKJLJLKIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x46CCB90", Offset = "0x46CBF90", VA = "0x1846CCB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FCMKIEDCKIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FCMKIEDCKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x46CCF40", Offset = "0x46CC340", VA = "0x1846CCF40")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct BOFPFBKBPDJ : IAsyncStateMachine
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
		public OKJLJLKIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private FCMKIEDCKIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x46CAD10", Offset = "0x46CA110", VA = "0x1846CAD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x46CB2A0", Offset = "0x46CA6A0", VA = "0x1846CB2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class FFNABIEOOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FFNABIEOOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x46CCFB0", Offset = "0x46CC3B0", VA = "0x1846CCFB0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private ALHBGAJNLDI[] NMKALNMAGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CancellationTokenSource KNPMPMKONCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int JFINANFOHCA;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3036B50", Offset = "0x3035F50", VA = "0x183036B50", Slot = "7")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3036190", Offset = "0x3035590", VA = "0x183036190", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3036020", Offset = "0x3035420", VA = "0x183036020", Slot = "6")]
	public void AMIEDNHLJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3036A00", Offset = "0x3035E00", VA = "0x183036A00", Slot = "5")]
	public void IELFINFLANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3036E80", Offset = "0x3036280", VA = "0x183036E80", Slot = "4")]
	[AsyncStateMachine(typeof(BCFGGHALEAJ))]
	public Task OGPHHBJBPFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x30363E0", Offset = "0x30357E0", VA = "0x1830363E0")]
	private void GJGFLEGGKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x30361A0", Offset = "0x30355A0", VA = "0x1830361A0")]
	[AsyncStateMachine(typeof(EPMGHGHNPBM))]
	private Task FILBAPGHDIA(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3036D30", Offset = "0x3036130", VA = "0x183036D30")]
	[AsyncStateMachine(typeof(BOFPFBKBPDJ))]
	private Task<bool> MLKMKGPMAMI(int HMJKJGLHFKE, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3036BD0", Offset = "0x3035FD0", VA = "0x183036BD0")]
	private void LLIMAECOGEP(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x30368C0", Offset = "0x3035CC0", VA = "0x1830368C0")]
	private void HAFKNMOEKHH(int HMJKJGLHFKE, bool DILBCNADBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3036710", Offset = "0x3035B10", VA = "0x183036710")]
	private void GMJLDIAIOGL(int HMJKJGLHFKE, Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x30362D0", Offset = "0x30356D0", VA = "0x1830362D0")]
	private void FNLHKBKDAMN(CancellationToken BJOMIPBBJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OKJLJLKIJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal class FJFFBFOBEGE : CGIDICIEALN, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct PFLPFIOIJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public FJFFBFOBEGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OHNBOJIMJND roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x30379B0", Offset = "0x3036DB0", VA = "0x1830379B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class HFKHABNMKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public FJFFBFOBEGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public OHNBOJIMJND roomData;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HFKHABNMKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3026FD0", Offset = "0x30263D0", VA = "0x183026FD0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct CGALPOFKOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public IPGFJMFBHGP taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3021C40", Offset = "0x3021040", VA = "0x183021C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct COLPIPDCHNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public FJFFBFOBEGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3021FA0", Offset = "0x30213A0", VA = "0x183021FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HashSet<IPGFJMFBHGP> FBIOAHPDMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GJJDEJDBGAI PKNECOIMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private JOPIPFFKHBD FGDIGACIACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private FNBLHALEOHE CPIPCEDCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IDisposable PHBIIOBNEBL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool GCHJEJPKEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x26A30B0", Offset = "0x26A24B0", VA = "0x1826A30B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task CHDFPJKEAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x26A2690", Offset = "0x26A1A90", VA = "0x1826A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x26A26A0", Offset = "0x26A1AA0", VA = "0x1826A26A0", Slot = "6")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x26A2530", Offset = "0x26A1930", VA = "0x1826A2530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x26A3050", Offset = "0x26A2450", VA = "0x1826A3050", Slot = "5")]
	public bool OGACGDAIILD(IPGFJMFBHGP HAANDGCBPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x26A2CE0", Offset = "0x26A20E0", VA = "0x1826A2CE0")]
	private void NBOAHPHCIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x26A2A60", Offset = "0x26A1E60", VA = "0x1826A2A60")]
	private void MGBOICAJHAJ(OHNBOJIMJND EFAPNGJIOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x26A2940", Offset = "0x26A1D40", VA = "0x1826A2940")]
	[AsyncStateMachine(typeof(PFLPFIOIJLK))]
	private Task MBCGOKFJMNG(OHNBOJIMJND EFAPNGJIOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x26A25B0", Offset = "0x26A19B0", VA = "0x1826A25B0")]
	private Func<CancellationToken, List<Task>> HGNAHBFHGJA(OHNBOJIMJND EFAPNGJIOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x26A1F00", Offset = "0x26A1300", VA = "0x1826A1F00")]
	private List<Task> AOAEAFABAPO(OHNBOJIMJND EFAPNGJIOOF, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x26A2F20", Offset = "0x26A2320", VA = "0x1826A2F20")]
	[AsyncStateMachine(typeof(CGALPOFKOHM))]
	private Task NGNPIKMBAJJ(IPGFJMFBHGP ODALGMINCAL, OHNBOJIMJND PNMIIEJFOON, CancellationToken MJNGPHMPILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x26A2430", Offset = "0x26A1830", VA = "0x1826A2430")]
	[AsyncStateMachine(typeof(COLPIPDCHNI))]
	private Task DFNOHAGPIOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x26A1DE0", Offset = "0x26A11E0", VA = "0x1826A1DE0")]
	private void AMIEDNHLJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x26A30E0", Offset = "0x26A24E0", VA = "0x1826A30E0")]
	public FJFFBFOBEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal class FIJKIFEDBOE : FNDBBNAOPBB, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct HDOOEIDHKNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public HEGHJKALNFL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x30265E0", Offset = "0x30259E0", VA = "0x1830265E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct MJAPAJNNBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HEGHJKALNFL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private global::DGKJHGKIMMO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NFFKLIOJGMF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DAGFLHPIIDO <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x302C0E0", Offset = "0x302B4E0", VA = "0x18302C0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HLNOPINHJHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task<NGANIFEBMGB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HLNOPINHJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		internal Task<NGANIFEBMGB> <ConnectToRoomAndRunLoadLogic>b__0(IKIBJCADMMP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct KGHPHHBPCCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public HEGHJKALNFL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public NFFKLIOJGMF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private HLNOPINHJHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private FMIJFIJBOLP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IKIBJCADMMP <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MKNHLIJNJKP <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<NGANIFEBMGB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x30297F0", Offset = "0x3028BF0", VA = "0x1830297F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct MBCFOJNFEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IKIBJCADMMP <disconnectTimerScope>5__3;

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
		private IKIBJCADMMP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x302B7C0", Offset = "0x302ABC0", VA = "0x18302B7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HFHHFACINFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private MMBGCEPKKOC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3026BB0", Offset = "0x3025FB0", VA = "0x183026BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct GKJPGDGPGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public NFFKLIOJGMF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IKIBJCADMMP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<FHDLGINJDME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3025A70", Offset = "0x3024E70", VA = "0x183025A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class DAKLFHNPNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public LBBLCNAMBKL targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DAKLFHNPNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3022930", Offset = "0x3021D30", VA = "0x183022930")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3022830", Offset = "0x3021C30", VA = "0x183022830")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct HGOOCCDLFOI : IAsyncStateMachine
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
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private DAKLFHNPNIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x3027000", Offset = "0x3026400", VA = "0x183027000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct BAIAMOGJDFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public NFFKLIOJGMF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public NGANIFEBMGB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public LBBLCNAMBKL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public FMIJFIJBOLP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private IKIBJCADMMP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3020260", Offset = "0x301F660", VA = "0x183020260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct BPLEAOKBPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IKIBJCADMMP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3021200", Offset = "0x3020600", VA = "0x183021200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct OFJMPHBAGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3035370", Offset = "0x3034770", VA = "0x183035370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PIDFBNMPAEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x30381C0", Offset = "0x30375C0", VA = "0x1830381C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DOLJCKEOFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3022E90", Offset = "0x3022290", VA = "0x183022E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct LBJFAPHAAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public FIJKIFEDBOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x302AF00", Offset = "0x302A300", VA = "0x18302AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IBGCOJEPCCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IBGCOJEPCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x30281A0", Offset = "0x30275A0", VA = "0x1830281A0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FJEGANJJFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FJEGANJJFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3024330", Offset = "0x3023730", VA = "0x183024330")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class HENPAFEGPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HENPAFEGPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3026B30", Offset = "0x3025F30", VA = "0x183026B30")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class IADKGCANHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IADKGCANHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x30280A0", Offset = "0x30274A0", VA = "0x1830280A0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly string FLAECEOOIGA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly string MFBLCKNAHCP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string OMBANCGKCGP;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly Guid OILDHIJACIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private LFHKFJAEBGI ELEIJOGPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GJJDEJDBGAI PKNECOIMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private HCMIBMOKODG HOOHKIDPJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private HEECAHIIDDB GKNNNJIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DOILCJMNGKO BMEDMCDHJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private ALHGIICHNJK FBPEKKHBHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IDisposable PHBIIOBNEBL;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus ICPBBFIJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA70A80", Offset = "0xA6FE80", VA = "0x180A70A80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA70A90", Offset = "0xA6FE90", VA = "0x180A70A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x26A05E0", Offset = "0x269F9E0", VA = "0x1826A05E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x26A01C0", Offset = "0x269F5C0", VA = "0x1826A01C0", Slot = "6")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x269E740", Offset = "0x269DB40", VA = "0x18269E740", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x26A10D0", Offset = "0x26A04D0", VA = "0x1826A10D0", Slot = "5")]
	[AsyncStateMachine(typeof(HDOOEIDHKNO))]
	public Task ODKIDMLLLJP(LBBLCNAMBKL GDBABBEBBOF, HEGHJKALNFL LBKPJJFIBIF, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x26A0060", Offset = "0x269F460", VA = "0x1826A0060")]
	[AsyncStateMachine(typeof(MJAPAJNNBJF))]
	private Task LCNOMLMMHNB(LBBLCNAMBKL GDBABBEBBOF, HEGHJKALNFL LBKPJJFIBIF, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x269FAF0", Offset = "0x269EEF0", VA = "0x18269FAF0")]
	private static void IOMDCOOIANG(LBBLCNAMBKL GDBABBEBBOF, Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x269E900", Offset = "0x269DD00", VA = "0x18269E900")]
	private static void EPFDIMMLJCP(DAGFLHPIIDO PKKGFHFHDGC, Exception DLEJGHMKMEP, [Optional] List<int> GDAIHGGHGIL, int JFINANFOHCA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x269FEE0", Offset = "0x269F2E0", VA = "0x18269FEE0")]
	[AsyncStateMachine(typeof(KGHPHHBPCCG))]
	private Task KMGDFJKPDCG(IKIBJCADMMP ANOJNPAHJKB, LBBLCNAMBKL GDBABBEBBOF, HEGHJKALNFL LBKPJJFIBIF, NFFKLIOJGMF LLFDEDIBMNC, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x269E5F0", Offset = "0x269D9F0", VA = "0x18269E5F0")]
	private void DDOKOMHJPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x26A1220", Offset = "0x26A0620", VA = "0x1826A1220")]
	[AsyncStateMachine(typeof(MBCFOJNFEAC))]
	private Task OEJFFBEMNNP(IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x26A0AD0", Offset = "0x269FED0", VA = "0x1826A0AD0")]
	private void NEJMHFBEFPA(LBBLCNAMBKL GDBABBEBBOF, CancellationToken DECHKOCCOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x269E010", Offset = "0x269D410", VA = "0x18269E010")]
	private void BMBBCMKBFKL(LBBLCNAMBKL GDBABBEBBOF, NFFKLIOJGMF LLFDEDIBMNC, OperationCanceledException PFOKLLFLIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x26A0630", Offset = "0x269FA30", VA = "0x1826A0630")]
	private void LOFDNLCPPFP(LBBLCNAMBKL GDBABBEBBOF, NFFKLIOJGMF LLFDEDIBMNC, Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x269E360", Offset = "0x269D760", VA = "0x18269E360")]
	private void DDLJLOPBPDJ(LBBLCNAMBKL GDBABBEBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x269FCB0", Offset = "0x269F0B0", VA = "0x18269FCB0")]
	private static CKOHOJDPEFN JEMHMHMLAHA(LBBLCNAMBKL GDBABBEBBOF)
	{
		return default(CKOHOJDPEFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x26A08F0", Offset = "0x269FCF0", VA = "0x1826A08F0")]
	[AsyncStateMachine(typeof(HFHHFACINFC))]
	private Task MFCKDKHACMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x269F690", Offset = "0x269EA90", VA = "0x18269F690")]
	private static FHDLGINJDME IHNNDOIGMIK(LBBLCNAMBKL GDBABBEBBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x269F740", Offset = "0x269EB40", VA = "0x18269F740")]
	[AsyncStateMachine(typeof(GKJPGDGPGIG))]
	private Task IKKAJLOOHAC(LBBLCNAMBKL GDBABBEBBOF, NFFKLIOJGMF LLFDEDIBMNC, IKIBJCADMMP ANOJNPAHJKB, CancellationToken DNLFAFDPOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x269DEB0", Offset = "0x269D2B0", VA = "0x18269DEB0")]
	[AsyncStateMachine(typeof(HGOOCCDLFOI))]
	private Task BJFGJLJOMPD(LBBLCNAMBKL GDBABBEBBOF, CancellationTokenSource JPGGPLHILGD, Task KIMFNLGBMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x269F140", Offset = "0x269E540", VA = "0x18269F140")]
	[AsyncStateMachine(typeof(BAIAMOGJDFD))]
	private Task FDOMMAAHGJM(NGANIFEBMGB JAEIJKMFOMM, FMIJFIJBOLP IIJHMGPFNOD, LBBLCNAMBKL CKDKBBFOIIJ, NFFKLIOJGMF MIDNKCIJDLL, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BCKANIIFGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x269DC70", Offset = "0x269D070", VA = "0x18269DC70")]
	private NFFKLIOJGMF AMANIDKOGKN(NFFKLIOJGMF MIDNKCIJDLL, ref CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x26A0F90", Offset = "0x26A0390", VA = "0x1826A0F90")]
	[AsyncStateMachine(typeof(BPLEAOKBPOK))]
	private Task NNMLDHOKEPC(IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x269F410", Offset = "0x269E810", VA = "0x18269F410")]
	[AsyncStateMachine(typeof(OFJMPHBAGHH))]
	private Task FOLMCDIPANO(IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x269F2D0", Offset = "0x269E6D0", VA = "0x18269F2D0")]
	[AsyncStateMachine(typeof(PIDFBNMPAEO))]
	private Task FOCBJLJDKFD(IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x269FD10", Offset = "0x269F110", VA = "0x18269FD10")]
	[AsyncStateMachine(typeof(DOLJCKEOFLM))]
	private Task JOFBBANHEHA(OHNBOJIMJND PNMIIEJFOON, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x26A1360", Offset = "0x26A0760", VA = "0x1826A1360")]
	[AsyncStateMachine(typeof(LBJFAPHAAJB))]
	private Task OJJEAFPPJFE(IKIBJCADMMP LNACOMDLNOJ, CancellationToken DNLFAFDPOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x269E790", Offset = "0x269DB90", VA = "0x18269E790")]
	private static void ECFCBINFKKN(LBBLCNAMBKL GDBABBEBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x269DAA0", Offset = "0x269CEA0", VA = "0x18269DAA0")]
	private void AKEFDEBMBLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x269FE50", Offset = "0x269F250", VA = "0x18269FE50")]
	private void KDEMKIDHDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x269F540", Offset = "0x269E940", VA = "0x18269F540")]
	private void GANECJKBNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x269E2D0", Offset = "0x269D6D0", VA = "0x18269E2D0")]
	private void DBFHIIFEJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x26A0E20", Offset = "0x26A0220", VA = "0x1826A0E20")]
	private static void NJPLJOKKJGM(LBBLCNAMBKL GDBABBEBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x269F5D0", Offset = "0x269E9D0", VA = "0x18269F5D0")]
	private static void GINLIMGKEEH(LBBLCNAMBKL GDBABBEBBOF, CancellationToken DNLFAFDPOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x269D920", Offset = "0x269CD20", VA = "0x18269D920")]
	private static void ADMEJDKAHCO(LBBLCNAMBKL GDBABBEBBOF, Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x269F8B0", Offset = "0x269ECB0", VA = "0x18269F8B0")]
	private void ILFGLPHGCFI(LBBLCNAMBKL GDBABBEBBOF, Task KIMFNLGBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x26A09F0", Offset = "0x269FDF0", VA = "0x1826A09F0")]
	private static void MFIHEHOKFNE(Func<string> ICBCECIENAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x26A1590", Offset = "0x26A0990", VA = "0x1826A1590")]
	public FIJKIFEDBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class AEFPDLKEAFO : CKMNBBAMJEN, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class MIICPMICFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MIICPMICFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x302C080", Offset = "0x302B480", VA = "0x18302C080")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class FEBCCKEKPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FEBCCKEKPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x30242D0", Offset = "0x30236D0", VA = "0x1830242D0")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class ECLOJFPMPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ECLOJFPMPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3023600", Offset = "0x3022A00", VA = "0x183023600")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class BDLKKNPIEMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BDLKKNPIEMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x30211A0", Offset = "0x30205A0", VA = "0x1830211A0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class ECPBMEJPIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ECPBMEJPIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3023660", Offset = "0x3022A60", VA = "0x183023660")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<Guid, HJMLJNDDLNB> NCAIMMECKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly TimeSpan KMKIMGLMCNO;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "10")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2695B10", Offset = "0x2694F10", VA = "0x182695B10", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2695360", Offset = "0x2694760", VA = "0x182695360", Slot = "4")]
	public LIGBACNOMMA AKBMAMDKLNI(Guid MOLEKIELIBJ)
	{
		return default(LIGBACNOMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2695B20", Offset = "0x2694F20", VA = "0x182695B20", Slot = "5")]
	public bool GKDAOIMBAHJ(Guid MOLEKIELIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x26955E0", Offset = "0x26949E0", VA = "0x1826955E0", Slot = "8")]
	public bool AMIEDNHLJHM(Guid MOLEKIELIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2695DD0", Offset = "0x26951D0", VA = "0x182695DD0", Slot = "6")]
	public bool IDGIADCCEDO(Guid MOLEKIELIBJ, Task KHFGHIMEHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2695850", Offset = "0x2694C50", VA = "0x182695850", Slot = "7")]
	public bool DPMDAMPPFCM(Guid MOLEKIELIBJ, CJAGNKGLNKE MAIMHEEFNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2696190", Offset = "0x2695590", VA = "0x182696190", Slot = "9")]
	public Task<(CJAGNKGLNKE, Task)> NEFNNEEOCJC(Guid MOLEKIELIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2696220", Offset = "0x2695620", VA = "0x182696220")]
	private void NLMPPLICOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x26964C0", Offset = "0x26958C0", VA = "0x1826964C0")]
	public AEFPDLKEAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal class LEPCEHCIGHC : FLGAOFMICBL, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class BPDBGHBJBPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private readonly LBBLCNAMBKL NJCMHKBLDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private readonly CancellationTokenSource KNPMPMKONCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly CancellationToken AOEFAAJEFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool DJJJGFFEGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool DAIKPAIAHEO;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3235500", Offset = "0x3234900", VA = "0x183235500")]
		public BPDBGHBJBPI(LBBLCNAMBKL NJCMHKBLDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3235380", Offset = "0x3234780", VA = "0x183235380")]
		public void AMIEDNHLJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x32354D0", Offset = "0x32348D0", VA = "0x1832354D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class JIMHGDGLBBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public NNHIIKOGOIH disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JIMHGDGLBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x323EBB0", Offset = "0x323DFB0", VA = "0x18323EBB0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct KLNNBLLGJAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public NNHIIKOGOIH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public LEPCEHCIGHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3240EB0", Offset = "0x32402B0", VA = "0x183240EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class MOGCEJKPGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MOGCEJKPGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x32431F0", Offset = "0x32425F0", VA = "0x1832431F0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct CLFGCMJMANB : IAsyncStateMachine
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
		public LEPCEHCIGHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3236AB0", Offset = "0x3235EB0", VA = "0x183236AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x681AD0", Offset = "0x680ED0", VA = "0x180681AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MDEMMMBPJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public LBBLCNAMBKL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MDEMMMBPJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3242C40", Offset = "0x3242040", VA = "0x183242C40")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3242CE0", Offset = "0x32420E0", VA = "0x183242CE0")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3242D20", Offset = "0x3242120", VA = "0x183242D20")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GIKFCNHJJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GIKFCNHJJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x323AB20", Offset = "0x3239F20", VA = "0x18323AB20")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LNCCLFLKKBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public LBBLCNAMBKL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public LEPCEHCIGHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public HEGHJKALNFL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private MDEMMMBPJIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x32419D0", Offset = "0x3240DD0", VA = "0x1832419D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private GJJDEJDBGAI PKNECOIMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private HCMIBMOKODG HOOHKIDPJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private ALHGIICHNJK FBPEKKHBHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private FNDBBNAOPBB DHNIACCKLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private long EJANHDCPBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private BPDBGHBJBPI KNDLNFOOCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool JOAAFICOCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Task FLHAFEPPPHI;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x26B2F20", Offset = "0x26B2320", VA = "0x1826B2F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DDPIMNJDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B40", Offset = "0x9F7F40", VA = "0x1809F8B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x26B28A0", Offset = "0x26B1CA0", VA = "0x1826B28A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x26B2CD0", Offset = "0x26B20D0", VA = "0x1826B2CD0", Slot = "4")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x26B21A0", Offset = "0x26B15A0", VA = "0x1826B21A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x26B2040", Offset = "0x26B1440", VA = "0x1826B2040")]
	[AsyncStateMachine(typeof(KLNNBLLGJAP))]
	private Task CEGKPMIMNHM(NNHIIKOGOIH KJJGNNJJMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x26B2320", Offset = "0x26B1720", VA = "0x1826B2320")]
	private void EDIOMELFFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x26B2980", Offset = "0x26B1D80", VA = "0x1826B2980")]
	private void JIFAJJBCMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x26B26A0", Offset = "0x26B1AA0", VA = "0x1826B26A0")]
	private void GHDLPDANGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x26B2530", Offset = "0x26B1930", VA = "0x1826B2530")]
	private bool GBKEFIIIJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x26B25B0", Offset = "0x26B19B0", VA = "0x1826B25B0")]
	[AsyncStateMachine(typeof(CLFGCMJMANB))]
	private void GCLLGAKBJBM(int DLDPNOCIKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x26B2F70", Offset = "0x26B2370", VA = "0x1826B2F70")]
	private void OGAMFLLPAKH(out IDisposable COLGOMLBGOE, out IDisposable LNFOCPGMKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x26B1EC0", Offset = "0x26B12C0", VA = "0x1826B1EC0")]
	private bool AHIGJJPGKPO(LBBLCNAMBKL NJCMHKBLDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x26B2160", Offset = "0x26B1560", VA = "0x1826B2160")]
	private void DLHBALIACFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x26B2B90", Offset = "0x26B1F90", VA = "0x1826B2B90")]
	[AsyncStateMachine(typeof(LNCCLFLKKBI))]
	private Task LCNOMLMMHNB(LBBLCNAMBKL NJCMHKBLDNC, HEGHJKALNFL LBKPJJFIBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x26B32B0", Offset = "0x26B26B0", VA = "0x1826B32B0")]
	public LEPCEHCIGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class KDMHKNKFOKO : OCMDPFKCLAF, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct OEOMBGKPKKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<OHOONLDMNHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public KDMHKNKFOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<OHOONLDMNHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3245650", Offset = "0x3244A50", VA = "0x183245650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x32458A0", Offset = "0x3244CA0", VA = "0x1832458A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class LGDKAMJEECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public MFNPLLGOGAD message;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LGDKAMJEECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3241530", Offset = "0x3240930", VA = "0x183241530")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class POOPHMKPOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public MFNPLLGOGAD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public POOPHMKPOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3247560", Offset = "0x3246960", VA = "0x183247560")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class LJPKNKJIJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LJPKNKJIJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3241970", Offset = "0x3240D70", VA = "0x183241970")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct GBHOOABJAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public KDMHKNKFOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<NMCMEOAHLPH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x32398E0", Offset = "0x3238CE0", VA = "0x1832398E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class EAMEPBMKIPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public MFNPLLGOGAD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EAMEPBMKIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3237990", Offset = "0x3236D90", VA = "0x183237990")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct KBOICNENEMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public MFNPLLGOGAD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public KDMHKNKFOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private NFFKLIOJGMF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x323F200", Offset = "0x323E600", VA = "0x18323F200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct IDAANDMIDDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<NMCMEOAHLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public KDMHKNKFOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private NFFKLIOJGMF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x323CFF0", Offset = "0x323C3F0", VA = "0x18323CFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x323D440", Offset = "0x323C840", VA = "0x18323D440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class ABCKIEPELDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public NMCMEOAHLPH operation;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ABCKIEPELDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3232100", Offset = "0x3231500", VA = "0x183232100")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct BDLMPIJNDMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public NMCMEOAHLPH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public KDMHKNKFOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private global::DGKJHGKIMMO<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3233B30", Offset = "0x3232F30", VA = "0x183233B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class PFAPDMJKNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PFAPDMJKNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3246520", Offset = "0x3245920", VA = "0x183246520")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class JHHEPMCMGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JHHEPMCMGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x323E4D0", Offset = "0x323D8D0", VA = "0x18323E4D0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private HEECAHIIDDB GKNNNJIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private OFPKGDGJKFD CJFPHNDAGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private BPICBLADIFC LBLDNOJIDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private TaskCompletionSource<OHOONLDMNHG> BJMKCONEDAM;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x26AF520", Offset = "0x26AE920", VA = "0x1826AF520", Slot = "7")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x26AF730", Offset = "0x26AEB30", VA = "0x1826AF730", Slot = "6")]
	[AsyncStateMachine(typeof(OEOMBGKPKKO))]
	public Task<OHOONLDMNHG> LOAOIEEEHGH(CancellationToken BODACEGGKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x26AFCB0", Offset = "0x26AF0B0", VA = "0x1826AFCB0", Slot = "4")]
	public void PCGBLHOBDCF(MFNPLLGOGAD KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC40", Offset = "0x26AE040", VA = "0x1826AEC40", Slot = "5")]
	public void IJNJDMOBMPM(MFNPLLGOGAD EHJAOOGNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x26AF600", Offset = "0x26AEA00", VA = "0x1826AF600")]
	[AsyncStateMachine(typeof(GBHOOABJAIL))]
	private Task LMEKNKALHON(MFNPLLGOGAD EMCPHLBMEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x26AF2C0", Offset = "0x26AE6C0", VA = "0x1826AF2C0")]
	[AsyncStateMachine(typeof(KBOICNENEMF))]
	private Task KPNDPPMMJGB(MFNPLLGOGAD BJPOPBHMGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x26AEA20", Offset = "0x26ADE20", VA = "0x1826AEA20")]
	[AsyncStateMachine(typeof(IDAANDMIDDL))]
	private Task<NMCMEOAHLPH> AGPAOCGLJPF(MFNPLLGOGAD EMCPHLBMEHO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x26AEBC0", Offset = "0x26ADFC0", VA = "0x1826AEBC0")]
	private NFFKLIOJGMF HPMKBDKAODM(MFNPLLGOGAD EHMKLLKELLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x26AF3F0", Offset = "0x26AE7F0", VA = "0x1826AF3F0")]
	[AsyncStateMachine(typeof(BDLMPIJNDMK))]
	private Task LIHEFDKNGOG(NMCMEOAHLPH OPDADEMFPEM, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x26AF040", Offset = "0x26AE440", VA = "0x1826AF040")]
	private NMCMEOAHLPH JMOGMNEGBMN(MFNPLLGOGAD EMCPHLBMEHO, NFFKLIOJGMF DDIGKEOCPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x25AEC20", Offset = "0x25AE020", VA = "0x1825AEC20")]
	private T MGBAAFPAJFC<T>(T IGDJJEECDAF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x26AF870", Offset = "0x26AEC70", VA = "0x1826AF870")]
	private NMCMEOAHLPH ODOCNEDILFA(MFNPLLGOGAD EMCPHLBMEHO, NFFKLIOJGMF DDIGKEOCPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public KDMHKNKFOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x26AEB70", Offset = "0x26ADF70", VA = "0x1826AEB70")]
	[CompilerGenerated]
	private void BBBJHHGOCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Preserve]
internal sealed class IFAKFOBHNMH : OFPKGDGJKFD, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class OGOJHGJEIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OGOJHGJEIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x32458F0", Offset = "0x3244CF0", VA = "0x1832458F0")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class GCEPILJAHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GCEPILJAHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x3239F20", Offset = "0x3239320", VA = "0x183239F20")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private MLGKEKEFCFC KLFACLBACCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OCMDPFKCLAF NAKNPMGKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private CKMNBBAMJEN NCAIMMECKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private LINOPFBBAGA MNABDOBMPFF;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x26AAB70", Offset = "0x26A9F70", VA = "0x1826AAB70", Slot = "6")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x26AA250", Offset = "0x26A9650", VA = "0x1826AA250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x26AA690", Offset = "0x26A9A90", VA = "0x1826AA690", Slot = "4")]
	public LIGBACNOMMA KOGJNMFBKIK(MFNPLLGOGAD AFDOCNIIOLI)
	{
		return default(LIGBACNOMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x26AACE0", Offset = "0x26AA0E0", VA = "0x1826AACE0", Slot = "5")]
	public void MKPOMGHPIFL(Guid MOLEKIELIBJ, Task KHFGHIMEHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x26AA2F0", Offset = "0x26A96F0", VA = "0x1826AA2F0")]
	private void EANHPJEEDID(byte FFINJKAOMCH, int OCBFIFAFHBM, object OKDONDENCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x26A95A0", Offset = "0x26A89A0", VA = "0x1826A95A0")]
	private void BNMGNNPJHBG(LDFMKAHHFPB DAFHLMNKNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x26A8FC0", Offset = "0x26A83C0", VA = "0x1826A8FC0")]
	private void ACBAOLBDPKP(LDFMKAHHFPB DAFHLMNKNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x26A9CA0", Offset = "0x26A90A0", VA = "0x1826A9CA0")]
	private void CCIJDOLLGMN(LDFMKAHHFPB DAFHLMNKNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x26AAF60", Offset = "0x26AA360", VA = "0x1826AAF60")]
	private CJAGNKGLNKE OJCCHHPHOJP(MFNPLLGOGAD EHMKLLKELLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x26AB200", Offset = "0x26AA600", VA = "0x1826AB200")]
	private void PIBAMGMJKEH(MFNPLLGOGAD BJPOPBHMGEH, CJAGNKGLNKE MAIMHEEFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x26A92A0", Offset = "0x26A86A0", VA = "0x1826A92A0")]
	private bool BAKFCCMHDEH(MFNPLLGOGAD BJPOPBHMGEH, CJAGNKGLNKE MAIMHEEFNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x26AA3C0", Offset = "0x26A97C0", VA = "0x1826AA3C0")]
	private bool KBMFLACNAJC(MFNPLLGOGAD IEGKKNDAJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x26A9F50", Offset = "0x26A9350", VA = "0x1826A9F50")]
	private bool DOLNOGACJOJ(byte FFINJKAOMCH, ExitGames.Client.Photon.Hashtable DAFHLMNKNIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public IFAKFOBHNMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class KDDPDICONCC : OILFFNFFKHK, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class IAHIJDMMFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public OHOONLDMNHG operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public KDDPDICONCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public MFNPLLGOGAD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IAHIJDMMFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x323CB50", Offset = "0x323BF50", VA = "0x18323CB50")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x323CBC0", Offset = "0x323BFC0", VA = "0x18323CBC0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KLEFADKAGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public KDDPDICONCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public MFNPLLGOGAD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x323FF30", Offset = "0x323F330", VA = "0x18323FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3240490", Offset = "0x323F890", VA = "0x183240490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class CCOONPNICHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public OHOONLDMNHG operationType;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CCOONPNICHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3236A40", Offset = "0x3235E40", VA = "0x183236A40")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class ALBNMIDGKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ALBNMIDGKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x32330D0", Offset = "0x32324D0", VA = "0x1832330D0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3233140", Offset = "0x3232540", VA = "0x183233140")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x32331B0", Offset = "0x32325B0", VA = "0x1832331B0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct HDOLNCNPOAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public KDDPDICONCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private ALBNMIDGKHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private LIGBACNOMMA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private CJAGNKGLNKE <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<(CJAGNKGLNKE validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x323B1E0", Offset = "0x323A5E0", VA = "0x18323B1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x323B8D0", Offset = "0x323ACD0", VA = "0x18323B8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MLGKEKEFCFC KLFACLBACCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private OFPKGDGJKFD CJFPHNDAGHC;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x26AE970", Offset = "0x26ADD70", VA = "0x1826AE970", Slot = "5")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x26AE490", Offset = "0x26AD890", VA = "0x1826AE490", Slot = "4")]
	[AsyncStateMachine(typeof(KLEFADKAGOK))]
	private Task<CJAGNKGLNKE> DCPENGOLJJI(MFNPLLGOGAD EHMKLLKELLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x26AE5D0", Offset = "0x26AD9D0", VA = "0x1826AE5D0")]
	private bool DKADLEEOMEK(OHOONLDMNHG GKHLDKLBDNC, out CJAGNKGLNKE MHKNFNJAIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x26AE830", Offset = "0x26ADC30", VA = "0x1826AE830")]
	[AsyncStateMachine(typeof(HDOLNCNPOAP))]
	private Task<CJAGNKGLNKE> IKNAAFDPLFH(MFNPLLGOGAD EMCPHLBMEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public KDDPDICONCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Preserve]
internal sealed class HOFBDCGEOMB : JEIJJCBFPCC, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct IGPFANEKODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<NGANIFEBMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public HOFBDCGEOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<PCBJAABEHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x323D960", Offset = "0x323CD60", VA = "0x18323D960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x323DB40", Offset = "0x323CF40", VA = "0x18323DB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class LAAJJFOCDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LAAJJFOCDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3241240", Offset = "0x3240640", VA = "0x183241240")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct GOGHAAJLHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<PCBJAABEHPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public HOFBDCGEOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public LBBLCNAMBKL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private LAAJJFOCDOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<FMPLMMKHKFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3026120", Offset = "0x3025520", VA = "0x183026120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x30264E0", Offset = "0x30258E0", VA = "0x1830264E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class NEDPIOMMDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NEDPIOMMDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x115F080", Offset = "0x115E480", VA = "0x18115F080")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(FHLHIJKLEKO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly (NHJHNDPNKHC superRoomData, string unityAssetId, NHJHNDPNKHC subRoomData) FDHLNDCIDFP;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x26A8AB0", Offset = "0x26A7EB0", VA = "0x1826A8AB0", Slot = "5")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x26A8B20", Offset = "0x26A7F20", VA = "0x1826A8B20", Slot = "4")]
	[AsyncStateMachine(typeof(IGPFANEKODN))]
	public Task<NGANIFEBMGB> MNOLMFHHCHN(IKIBJCADMMP LNACOMDLNOJ, LBBLCNAMBKL GDBABBEBBOF, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x26A8930", Offset = "0x26A7D30", VA = "0x1826A8930")]
	[AsyncStateMachine(typeof(GOGHAAJLHOD))]
	private Task<PCBJAABEHPG> FOAEPGIMEOJ(LBBLCNAMBKL GDBABBEBBOF, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x26A8CA0", Offset = "0x26A80A0", VA = "0x1826A8CA0")]
	private NGANIFEBMGB MPEJBLMHFFN(LBBLCNAMBKL GDBABBEBBOF, PCBJAABEHPG PGLIEDLJNLB, long LBIOPPABCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x26A8580", Offset = "0x26A7980", VA = "0x1826A8580")]
	private (NHJHNDPNKHC, string, NHJHNDPNKHC) ANJGNPBFOKL(LBBLCNAMBKL GDBABBEBBOF, PCBJAABEHPG PGLIEDLJNLB, long LBIOPPABCMJ)
	{
		return default((NHJHNDPNKHC, string, NHJHNDPNKHC));
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HOFBDCGEOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[Preserve]
internal sealed class DBBCABLLKHM : BPICBLADIFC, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class PILOIABPBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PILOIABPBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3038480", Offset = "0x3037880", VA = "0x183038480")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct FCFJPNHOPBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public DBBCABLLKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NFFKLIOJGMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3023E20", Offset = "0x3023220", VA = "0x183023E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x3024280", Offset = "0x3023680", VA = "0x183024280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct DAHHMCMLDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DBBCABLLKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NFFKLIOJGMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3022200", Offset = "0x3021600", VA = "0x183022200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x30227E0", Offset = "0x3021BE0", VA = "0x1830227E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class GLHBIGCFMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GLHBIGCFMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x30260C0", Offset = "0x30254C0", VA = "0x1830260C0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct IMCGAHFJENB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public MFNPLLGOGAD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public DBBCABLLKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public NFFKLIOJGMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private DPMOCIMNJAD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private LJOHAIHLJFB <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3028CA0", Offset = "0x30280A0", VA = "0x183028CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3029730", Offset = "0x3028B30", VA = "0x183029730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private EBCBFDJMCKE BDDONJGDBNJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private MBHCBBFEHOI JLAGAJPDAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2699400", Offset = "0x2698800", VA = "0x182699400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x26998B0", Offset = "0x2698CB0", VA = "0x1826998B0", Slot = "8")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2699740", Offset = "0x2698B40", VA = "0x182699740", Slot = "4")]
	[AsyncStateMachine(typeof(FCFJPNHOPBB))]
	public Task<MFNPLLGOGAD> KNGDNFPEBKI(MFNPLLGOGAD EMCPHLBMEHO, NFFKLIOJGMF DDIGKEOCPLO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2699940", Offset = "0x2698D40", VA = "0x182699940", Slot = "5")]
	[AsyncStateMachine(typeof(DAHHMCMLDDB))]
	public Task<MFNPLLGOGAD> NEJPCJPPKDE(CancellationToken BJOMIPBBJKO, NFFKLIOJGMF DDIGKEOCPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x26994C0", Offset = "0x26988C0", VA = "0x1826994C0", Slot = "6")]
	public NPDJBKPIGJG FADGACEANPG(NMCMEOAHLPH CEJKJHKFODJ, IKIBJCADMMP LNACOMDLNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26992D0", Offset = "0x26986D0", VA = "0x1826992D0", Slot = "7")]
	public NPDJBKPIGJG CCPFJFBAKJH(NMCMEOAHLPH CEJKJHKFODJ, IKIBJCADMMP LNACOMDLNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2699AA0", Offset = "0x2698EA0", VA = "0x182699AA0")]
	[AsyncStateMachine(typeof(IMCGAHFJENB))]
	private Task<MFNPLLGOGAD> PCDDPFNPLGH(MFNPLLGOGAD EMCPHLBMEHO, NFFKLIOJGMF DDIGKEOCPLO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x26994B0", Offset = "0x26988B0", VA = "0x1826994B0")]
	private static byte[] DJCPCFNIAHK(MFNPLLGOGAD KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26995F0", Offset = "0x26989F0", VA = "0x1826995F0")]
	private static string GHPDAINKBED(byte[] NJOHOALIBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DBBCABLLKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class DLJMGIACCIN : MLGKEKEFCFC, PIIBHELDMJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private OCPDGHLKECJ PBDLPGEAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private HEECAHIIDDB GKNNNJIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private PAMAFDMCKNL FOMJHADIFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private FNDBBNAOPBB DHNIACCKLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private CGIDICIEALN KJFALAAMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private ALHGIICHNJK FBPEKKHBHEP;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x269BB00", Offset = "0x269AF00", VA = "0x18269BB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static CJAGNKGLNKE MDGJJPDLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x269B310", Offset = "0x269A710", VA = "0x18269B310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x269B9A0", Offset = "0x269ADA0", VA = "0x18269B9A0", Slot = "7")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x269B320", Offset = "0x269A720", VA = "0x18269B320", Slot = "4")]
	public CJAGNKGLNKE CCPIABMGLMH(GLJCDOAILMB CJHAGBLILJN, OHOONLDMNHG FBBJHIOPJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x269B700", Offset = "0x269AB00", VA = "0x18269B700", Slot = "5")]
	public CJAGNKGLNKE HLHLKHCNLDM(GLJCDOAILMB PIPIGAHIOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x269B4C0", Offset = "0x269A8C0", VA = "0x18269B4C0", Slot = "6")]
	public CJAGNKGLNKE EEDDIANHLPO(GLJCDOAILMB PIPIGAHIOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x269B4B0", Offset = "0x269A8B0", VA = "0x18269B4B0")]
	private static CJAGNKGLNKE DKJEFONNOMK(FHIHJKLJCEC AAMNHHPLJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DLJMGIACCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class IJPAFIJDLNF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x26ABBC0", Offset = "0x26AAFC0", VA = "0x1826ABBC0")]
	public IJPAFIJDLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
	public IJPAFIJDLNF(string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[Preserve]
internal sealed class NPEMGOMCFGA : LJNNJIFNHBJ, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KDDMILHAKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public NPEMGOMCFGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public LMBGJPBKLNM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private global::DGKJHGKIMMO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private IKIBJCADMMP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private HDFMHKFCJJA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private IKIBJCADMMP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x46D2020", Offset = "0x46D1420", VA = "0x1846D2020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x46D26B0", Offset = "0x46D1AB0", VA = "0x1846D26B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct DGPPJGHBKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public NPEMGOMCFGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46CB9E0", Offset = "0x46CADE0", VA = "0x1846CB9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct EICOABHAANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public NPEMGOMCFGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46CC3A0", Offset = "0x46CB7A0", VA = "0x1846CC3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct GNBIPJNDEBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public NPEMGOMCFGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x46D0280", Offset = "0x46CF680", VA = "0x1846D0280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct BLIOPDJEIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public NPEMGOMCFGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46CA3B0", Offset = "0x46C97B0", VA = "0x1846CA3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct GPLMDOMPFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public NPEMGOMCFGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AEDHGGAECKF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private global::DGKJHGKIMMO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x46D03C0", Offset = "0x46CF7C0", VA = "0x1846D03C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static readonly TimeSpan JECDBLBMFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private BPICBLADIFC LBLDNOJIDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private HEECAHIIDDB GKNNNJIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private CGIDICIEALN KJFALAAMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private CancellationTokenSource BDPFPFHDKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Task PPLGEMCIPPP;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3031380", Offset = "0x3030780", VA = "0x183031380", Slot = "6")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x13727F0", Offset = "0x1371BF0", VA = "0x1813727F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3031240", Offset = "0x3030640", VA = "0x183031240", Slot = "4")]
	[AsyncStateMachine(typeof(KDDMILHAKBK))]
	public Task<CJAGNKGLNKE> GAKNBGINLEI(LMBGJPBKLNM HHCPLMDOPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3031770", Offset = "0x3030B70", VA = "0x183031770", Slot = "5")]
	[AsyncStateMachine(typeof(DGPPJGHBKEB))]
	public Task MNIPDLPKAJK([Optional] CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x13727F0", Offset = "0x1371BF0", VA = "0x1813727F0")]
	public void ABKLMELHFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3030B70", Offset = "0x302FF70", VA = "0x183030B70")]
	private HDFMHKFCJJA ADNGMDFLKJA(LMBGJPBKLNM HHCPLMDOPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3031530", Offset = "0x3030930", VA = "0x183031530")]
	[AsyncStateMachine(typeof(EICOABHAANC))]
	private Task LJDIJLFBNGP(OHNBOJIMJND FAHGJOEFBKN, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3031120", Offset = "0x3030520", VA = "0x183031120")]
	[AsyncStateMachine(typeof(GNBIPJNDEBN))]
	private Task FCBABAFNIMJ([Optional] CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3031890", Offset = "0x3030C90", VA = "0x183031890")]
	[AsyncStateMachine(typeof(BLIOPDJEIJK))]
	private Task OMOFFBIMEEK(TimeSpan BHHLOMELELO, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3030EB0", Offset = "0x30302B0", VA = "0x183030EB0")]
	private Task DOIGFKOAFBO(AEDHGGAECKF BFONPHLGOFF, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3030D80", Offset = "0x3030180", VA = "0x183030D80")]
	[AsyncStateMachine(typeof(GPLMDOMPFLB))]
	private Task BMBAMJKBBKN(AEDHGGAECKF BFONPHLGOFF, CancellationToken DECHKOCCOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3031660", Offset = "0x3030A60", VA = "0x183031660")]
	private bool MFBBFHJDIGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NPEMGOMCFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[Preserve]
internal class MIMJLCBJHEO : PAMAFDMCKNL, PIIBHELDMJJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct GMOEKADHIPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public MIMJLCBJHEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private global::DGKJHGKIMMO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x323AEB0", Offset = "0x323A2B0", VA = "0x18323AEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private KEBJMCDEHGP PNMKAGOAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private MLGKEKEFCFC KLFACLBACCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private BPICBLADIFC LBLDNOJIDIP;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x26B6950", Offset = "0x26B5D50", VA = "0x1826B6950", Slot = "6")]
	public void LJAJKOINHPD(CFOGACNBCBD IPNLLMLMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x26B67B0", Offset = "0x26B5BB0", VA = "0x1826B67B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x26B6690", Offset = "0x26B5A90", VA = "0x1826B6690", Slot = "5")]
	[AsyncStateMachine(typeof(GMOEKADHIPN))]
	public Task BHKBJPHDFHE(string GKBEAKNFHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x26B6B70", Offset = "0x26B5F70", VA = "0x1826B6B70", Slot = "4")]
	public CJAGNKGLNKE MFBBFHJDIGL(GLJCDOAILMB CJHAGBLILJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x26B6800", Offset = "0x26B5C00", VA = "0x1826B6800")]
	private BOHDCMFDFMA KMKFCKKIIGE(string GKBEAKNFHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MIMJLCBJHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class HLGHDLNGHFM
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x26A7EB0", Offset = "0x26A72B0", VA = "0x1826A7EB0")]
	public static void OEFOECDFCEH(MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x26A7DD0", Offset = "0x26A71D0", VA = "0x1826A7DD0")]
	internal static void JPOLPMNGCJL(MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x26A78A0", Offset = "0x26A6CA0", VA = "0x1826A78A0")]
	internal static void BCJPIBECLOA(MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x26A7980", Offset = "0x26A6D80", VA = "0x1826A7980")]
	internal static void GMHKJBFHNCF(MMBGCEPKKOC CKGKDHACBKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class GDHKBPKMHIP : global::NJCHCLFEFOB<MFNPLLGOGAD>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class BDAMMNLOJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public MFNPLLGOGAD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BDAMMNLOJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3020DF0", Offset = "0x30201F0", VA = "0x183020DF0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly GDHKBPKMHIP KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const string DPAIJKAJOIN = "pl";

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x26A4690", Offset = "0x26A3A90", VA = "0x1826A4690")]
	public ExitGames.Client.Photon.Hashtable FBLBIDAIACI(MFNPLLGOGAD KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x26A4550", Offset = "0x26A3950", VA = "0x1826A4550", Slot = "5")]
	protected override void FBINBPGPECG(MFNPLLGOGAD KAKCNEMJMJL, IDictionary<object, object> PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x26A4A60", Offset = "0x26A3E60", VA = "0x1826A4A60", Slot = "6")]
	public override MFNPLLGOGAD LOHKEOMODAB(IDictionary<object, object> PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x26A4C60", Offset = "0x26A4060", VA = "0x1826A4C60")]
	private static void MFIHEHOKFNE(string JAPLHPDFKME, MFNPLLGOGAD KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x26A4E60", Offset = "0x26A4260", VA = "0x1826A4E60")]
	public GDHKBPKMHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x26A4710", Offset = "0x26A3B10", VA = "0x1826A4710")]
	[CompilerGenerated]
	internal static string FJKKDPOCEAO(NGANIFEBMGB NEIPJLDAIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class OICDPFIFCBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static CJAGNKGLNKE MDGJJPDLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3035A00", Offset = "0x3034E00", VA = "0x183035A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3035F30", Offset = "0x3035330", VA = "0x183035F30")]
	public static bool ICKAGIJNHKI(this CJAGNKGLNKE MAIMHEEFNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3035CD0", Offset = "0x30350D0", VA = "0x183035CD0")]
	public static CJAGNKGLNKE DKJEFONNOMK(FHIHJKLJCEC LKPIEEBBCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3035F50", Offset = "0x3035350", VA = "0x183035F50")]
	public static CJAGNKGLNKE LFBDCDODCEM(params CJAGNKGLNKE[] HBBDIIKICMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3035D30", Offset = "0x3035130", VA = "0x183035D30")]
	public static CJAGNKGLNKE DNPEIFHKAOJ(IEnumerable<CJAGNKGLNKE> HBBDIIKICMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3035A60", Offset = "0x3034E60", VA = "0x183035A60")]
	public static string COMKMAHHCGA(this CJAGNKGLNKE MHKNFNJAIIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class BMPAKMCHFPJ : NODJJJKLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate CJAGNKGLNKE EFLMPBENEMB([NotNull] GLJCDOAILMB HLDMJLFBLHN);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class PEALELJHMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public GLJCDOAILMB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PEALELJHMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3037980", Offset = "0x3036D80", VA = "0x183037980")]
		internal CJAGNKGLNKE <Validate>b__0(EFLMPBENEMB v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	protected readonly HashSet<EFLMPBENEMB> OHEIACMCKAL;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2697D90", Offset = "0x2697190", VA = "0x182697D90", Slot = "4")]
	public void PONMLAKFOCM(EFLMPBENEMB OAAMBMNEJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2697D30", Offset = "0x2697130", VA = "0x182697D30", Slot = "5")]
	public void MOPBKLFOKNO(EFLMPBENEMB OAAMBMNEJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2697AC0", Offset = "0x2696EC0", VA = "0x182697AC0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2697B10", Offset = "0x2696F10", VA = "0x182697B10")]
	protected CJAGNKGLNKE FDHCEBHOMND(GLJCDOAILMB PIPIGAHIOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2697DF0", Offset = "0x26971F0", VA = "0x182697DF0")]
	protected BMPAKMCHFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class DEIOBJMOJBD : BMPAKMCHFPJ, OCPDGHLKECJ, NODJJJKLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class EAPDPCKAIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public CJAGNKGLNKE result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EAPDPCKAIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x30235A0", Offset = "0x30229A0", VA = "0x1830235A0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2699DA0", Offset = "0x26991A0", VA = "0x182699DA0")]
	[Preserve]
	public DEIOBJMOJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2699C20", Offset = "0x2699020", VA = "0x182699C20", Slot = "8")]
	public CJAGNKGLNKE FKGCPEIHBGF(GLJCDOAILMB PIPIGAHIOGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class LPJJAGMFKHJ : BMPAKMCHFPJ, KEBJMCDEHGP, NODJJJKLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class MPFEBJCBKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public CJAGNKGLNKE result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MPFEBJCBKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x3243260", Offset = "0x3242660", VA = "0x183243260")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2699DA0", Offset = "0x26991A0", VA = "0x182699DA0")]
	[Preserve]
	public LPJJAGMFKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x26B4A90", Offset = "0x26B3E90", VA = "0x1826B4A90", Slot = "8")]
	public CJAGNKGLNKE MFBBFHJDIGL(GLJCDOAILMB BKCMLHPPECC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum OGFFMBDIIFG
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
internal static class BCBOCHJOOOE
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class GPHNFEEFOOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public global::DGKJHGKIMMO<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GPHNFEEFOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3026530", Offset = "0x3025930", VA = "0x183026530")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public const string PBOFBAHBIMN = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public const string COPEJEHLBGG = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2696EA0", Offset = "0x26962A0", VA = "0x182696EA0")]
	public static global::DGKJHGKIMMO<string> LMCBBEIJELG([Optional] string CKGHLMHPIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2696A80", Offset = "0x2695E80", VA = "0x182696A80")]
	private static void DLIIDDAKONG(string FOJIGKKHICE, FGGJIAIMKFN ANOJNPAHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2696B80", Offset = "0x2695F80", VA = "0x182696B80")]
	private static void EKEKLMMMDMO(string FOJIGKKHICE, FGGJIAIMKFN ANOJNPAHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2696C80", Offset = "0x2696080", VA = "0x182696C80")]
	public static void FAIIMMELDDF(global::DGKJHGKIMMO<string> ANOJNPAHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2696DE0", Offset = "0x26961E0", VA = "0x182696DE0")]
	public static string KIMIHAPBDNK(MFNPLLGOGAD EHMKLLKELLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class HDOCDEJJAPK
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x26A74C0", Offset = "0x26A68C0", VA = "0x1826A74C0")]
	public static void FPKKJPOAHOB(this BGDABKNLGMA CHLPJFPJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x26A74D0", Offset = "0x26A68D0", VA = "0x1826A74D0")]
	public static void PAHLKGAJAHE(this BGDABKNLGMA CHLPJFPJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x26A73B0", Offset = "0x26A67B0", VA = "0x1826A73B0")]
	private static void CIAHBBCDKDF(this BGDABKNLGMA CHLPJFPJJFO, bool LMDBGHIOFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class ECEPGNMFKOL : NOGOJPOECKO, EFOGLGILCDH, LBEAFNPGOGA, DADBLFIAPGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly EFOGLGILCDH HPEPIELPOOE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GLJCDOAILMB DHBHJHKBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x269BC90", Offset = "0x269B090", VA = "0x18269BC90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int IFEGNHIPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x269C0B0", Offset = "0x269B4B0", VA = "0x18269C0B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int FGIFIGAGBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x269C100", Offset = "0x269B500", VA = "0x18269C100", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool KHAJGPCOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int LDNHNHAPKED
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x69EAA0", Offset = "0x69DEA0", VA = "0x18069EAA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event IHCNJAPNMEC.KLOIPNDLAFF EFKDIBMFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NNACAJLDGDP NHLMFEMPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x269BBF0", Offset = "0x269AFF0", VA = "0x18269BBF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x269BF60", Offset = "0x269B360", VA = "0x18269BF60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> BONKCLKOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<GLJCDOAILMB> IHLGNCPPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action GDHEBENCBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x269C150", Offset = "0x269B550", VA = "0x18269C150", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x269BCE0", Offset = "0x269B0E0", VA = "0x18269BCE0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x82D810", Offset = "0x82CC10", VA = "0x18082D810")]
	public ECEPGNMFKOL(EFOGLGILCDH HPEPIELPOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x269C000", Offset = "0x269B400", VA = "0x18269C000", Slot = "8")]
	public bool GCAGCCOOEFN(byte FFINJKAOMCH, ExitGames.Client.Photon.Hashtable HOPCKHHIANO, DDAFFKGIMND HEGDEADNBAD, SendOptions FCIJIDGGCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x269BEC0", Offset = "0x269B2C0", VA = "0x18269BEC0", Slot = "29")]
	public GLJCDOAILMB FAPKPBFELCD(int FBJKGMNDNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x269BDE0", Offset = "0x269B1E0", VA = "0x18269BDE0", Slot = "16")]
	public GLJCDOAILMB FAIJJBOFBPH(int OMANDIPLMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "19")]
	public void DHGDFCPOAJI(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "20")]
	public void KBEJHINBCFN(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "21")]
	public void LPONKBPDLOP(object MJNGPHMPILM, bool MIGIMAIIMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x269BD80", Offset = "0x269B180", VA = "0x18269BD80", Slot = "22")]
	public IDisposable EDLMJGEHGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "23")]
	private bool MCPIJBJBBCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "24")]
	public void CIAELNEKMMO(StringBuilder KCCCHKCLDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x269BBD0", Offset = "0x269AFD0", VA = "0x18269BBD0", Slot = "25")]
	public bool CKINFEDLADH(bool EEJHGLPEPMF, out string CIMKHIELLCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public void GNBPPNPIHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1150870", Offset = "0x114FC70", VA = "0x181150870", Slot = "28")]
	public void DAGACPMCKOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct LDFMKAHHFPB
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const string PIJNPAOPEDG = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public const string DGHOPPCDDGG = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly IDictionary<object, object> DAFHLMNKNIF;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x92FFA0", Offset = "0x92F3A0", VA = "0x18092FFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	public LDFMKAHHFPB(IDictionary<object, object> DAFHLMNKNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x26B1BC0", Offset = "0x26B0FC0", VA = "0x1826B1BC0")]
	public bool GGOCACGFJOP(out MFNPLLGOGAD KAKCNEMJMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x26B1DE0", Offset = "0x26B11E0", VA = "0x1826B1DE0")]
	public Guid MJHABMPNGFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x26B1C80", Offset = "0x26B1080", VA = "0x1826B1C80")]
	public CJAGNKGLNKE GOODPHHLOIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x26B1AD0", Offset = "0x26B0ED0", VA = "0x1826B1AD0")]
	public static ExitGames.Client.Photon.Hashtable FNICMNFMKAL(MFNPLLGOGAD KAKCNEMJMJL, CJAGNKGLNKE MAIMHEEFNAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class JKNLHABPHAJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x26ADD70", Offset = "0x26AD170", VA = "0x1826ADD70")]
	public static string EENOENPLCPN(this LBBLCNAMBKL PINGFGAGGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x26ADCF0", Offset = "0x26AD0F0", VA = "0x1826ADCF0")]
	public static bool ABFDPHODEOA(this LBBLCNAMBKL PINGFGAGGMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct FNBLHALEOHE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct DJOBFNFFCNO : IAsyncStateMachine
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
		public FNBLHALEOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3022CF0", Offset = "0x30220F0", VA = "0x183022CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CancellationTokenSource KNPMPMKONCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private Task MPDGFCFNFOK;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x26A4330", Offset = "0x26A3730", VA = "0x1826A4330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task CHDFPJKEAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x26A43B0", Offset = "0x26A37B0", VA = "0x1826A43B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x26A4430", Offset = "0x26A3830", VA = "0x1826A4430")]
	public FNBLHALEOHE(CancellationToken BJOMIPBBJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x26A4200", Offset = "0x26A3600", VA = "0x1826A4200")]
	[AsyncStateMachine(typeof(DJOBFNFFCNO))]
	public Task BLBEIEJMGMH(Func<CancellationToken, List<Task>> FJOGAAHIPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x26A4360", Offset = "0x26A3760", VA = "0x1826A4360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct OOPNAKGODNG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct JKBPKEFPFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<global::BFOGDGGAJLJ<global::NCLCEHNCJOC<TData>, DJBJKBPDGID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public global::OOPNAKGODNG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private IKIBJCADMMP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<global::BFOGDGGAJLJ<byte[], DJBJKBPDGID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x20B0840", Offset = "0x20AFC40", VA = "0x1820B0840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1BB1540", Offset = "0x1BB0940", VA = "0x181BB1540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private readonly global::IFHFCDGGKJJ<TGetDataArg, TData> PLDEBFMNDPG;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	internal OOPNAKGODNG(global::IFHFCDGGKJJ<TGetDataArg, TData> MHCCDFMDJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D960", Offset = "0x3C6CD60", VA = "0x183C6D960")]
	[AsyncStateMachine(typeof(global::OOPNAKGODNG<, >.JKBPKEFPFOG))]
	public Task<global::BFOGDGGAJLJ<global::NCLCEHNCJOC<TData>, DJBJKBPDGID>> MBLIIIIEOOA(TGetDataArg NJOHOALIBEB, string LIOEEMEFHAI, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class IEKKNKLBINH
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7ED00", Offset = "0x1F7E100", VA = "0x181F7ED00")]
	public static global::OOPNAKGODNG<TGetDataArg, TData> IKMCJIAOBME<TGetDataArg, TData>(global::IFHFCDGGKJJ<TGetDataArg, TData> MHCCDFMDJCL)
	{
		return default(global::OOPNAKGODNG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class LFHKFJAEBGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly ECOKMALNNKE KMNENOFMCPI;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private const string EJKDHADCOCA = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private const string HEKLDANDJDB = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string BDHJFJJAJGK = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string HCGJANMIGPI = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string HAAKGPAHHAK = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private string CHKEABIAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private long? AKGELMPFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private long? BKKOCLPLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private MABCHFGOLAP OEDKMNCMLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? JIFMCPMOFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private bool FMCNJKMIPCE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string KNFLKEDMMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long ODNJKOOEEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x26B3330", Offset = "0x26B2730", VA = "0x1826B3330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long FMENHJLBILK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x26B3830", Offset = "0x26B2C30", VA = "0x1826B3830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MABCHFGOLAP HBOCNAMKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C5720", Offset = "0x6C4B20", VA = "0x1806C5720")]
		get
		{
			return default(MABCHFGOLAP);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x26B38F0", Offset = "0x26B2CF0", VA = "0x1826B38F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long BJIAGADHMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x26B3890", Offset = "0x26B2C90", VA = "0x1826B3890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x26B3E80", Offset = "0x26B3280", VA = "0x1826B3E80")]
	[Preserve]
	public LFHKFJAEBGI([IMNCNOGBAJI(null)] ECOKMALNNKE KMNENOFMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x26B3CD0", Offset = "0x26B30D0", VA = "0x1826B3CD0")]
	private void OGLKIICCMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x26B3480", Offset = "0x26B2880", VA = "0x1826B3480")]
	public void DNOMBFCKNII(long DDEPFHBCOHC, long LBIOPPABCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x26B3390", Offset = "0x26B2790", VA = "0x1826B3390")]
	public void DAAHCEIGOOA(string HOIKGKOACAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x26B39E0", Offset = "0x26B2DE0", VA = "0x1826B39E0")]
	public void JDIMCFBICNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class NPDJBKPIGJG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct DMLIAGLNAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public MFNPLLGOGAD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public NPDJBKPIGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<NOOKBPKBJPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x46CC040", Offset = "0x46CB440", VA = "0x1846CC040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x46CC350", Offset = "0x46CB750", VA = "0x1846CC350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KDPIFMOGDMM<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class KABFBENIJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public MFNPLLGOGAD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KABFBENIJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x46D1F10", Offset = "0x46D1310", VA = "0x1846D1F10")]
		internal MFNPLLGOGAD <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct KEJFHGDMIPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<NOOKBPKBJPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public MFNPLLGOGAD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public NPDJBKPIGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private DPMOCIMNJAD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<NOOKBPKBJPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x46D2700", Offset = "0x46D1B00", VA = "0x1846D2700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x46D2ED0", Offset = "0x46D22D0", VA = "0x1846D2ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct JBLNJHNDFEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public NPDJBKPIGJG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46D1690", Offset = "0x46D0A90", VA = "0x1846D1690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class DGMLPEBMOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DGMLPEBMOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x46CB870", Offset = "0x46CAC70", VA = "0x1846CB870")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class BAGMHMEJNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BAGMHMEJNJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x46C9880", Offset = "0x46C8C80", VA = "0x1846C9880")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CBCMDKNACIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CBCMDKNACIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x46CB570", Offset = "0x46CA970", VA = "0x1846CB570")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class LECHKKIIMGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LECHKKIIMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x46D3C70", Offset = "0x46D3070", VA = "0x1846D3C70")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class BPBHGLNKNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public NPDJBKPIGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BPBHGLNKNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x46CB2F0", Offset = "0x46CA6F0", VA = "0x1846CB2F0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class IIPNOPLDMPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public NPDJBKPIGJG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IIPNOPLDMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x46D0C80", Offset = "0x46D0080", VA = "0x1846D0C80")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly Guid IGDGEAKLNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly NMCMEOAHLPH MLGDDCAPKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly MBHCBBFEHOI AFABPADDFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly LBEAFNPGOGA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly DADBLFIAPGN PDNJKEGOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool IOGJOOFMKMI;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3030950", Offset = "0x302FD50", VA = "0x183030950")]
	public NPDJBKPIGJG(NMCMEOAHLPH OPDADEMFPEM, MBHCBBFEHOI AFABPADDFPC, LBEAFNPGOGA CHLPJFPJJFO, DADBLFIAPGN PDNJKEGOLLE, IKIBJCADMMP LNACOMDLNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x302F460", Offset = "0x302E860", VA = "0x18302F460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x302F460", Offset = "0x302E860", VA = "0x18302F460")]
	public void ELFIGJEKGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x302F9D0", Offset = "0x302EDD0", VA = "0x18302F9D0")]
	public void JKCDEKKBCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3030700", Offset = "0x302FB00", VA = "0x183030700")]
	public void PIGEGBOFPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3030550", Offset = "0x302F950", VA = "0x183030550")]
	[AsyncStateMachine(typeof(DMLIAGLNAFP))]
	internal Task<MFNPLLGOGAD> PHCCAHPMJOK(IKIBJCADMMP LNACOMDLNOJ, MFNPLLGOGAD EHMKLLKELLI, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x26994B0", Offset = "0x26988B0", VA = "0x1826994B0")]
	private static byte[] AFCLFCPAOBK<T>(T KAKCNEMJMJL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x30E54B0", Offset = "0x30E48B0", VA = "0x1830E54B0")]
	private static T JLONIIBPNFI<T>(MessageParser<T> DNNGAIOJBMA, byte[] KAKCNEMJMJL, T GONKEOOFGON) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x30303F0", Offset = "0x302F7F0", VA = "0x1830303F0")]
	[AsyncStateMachine(typeof(KEJFHGDMIPJ))]
	private Task<NOOKBPKBJPD> ODMGAGGEKKH(MFNPLLGOGAD EHMKLLKELLI, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x30E51D0", Offset = "0x30E45D0", VA = "0x1830E51D0")]
	[AsyncStateMachine(typeof(GBJCAECHOEL))]
	internal Task<T> JEHEHMKOCIF<T>(CancellationToken DECHKOCCOAA, Func<CancellationToken, Task<T>> CNEBJLFLBAL, int DDCGPAJDMLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x302F880", Offset = "0x302EC80", VA = "0x18302F880")]
	[AsyncStateMachine(typeof(JBLNJHNDFEF))]
	internal Task JEHEHMKOCIF(CancellationToken DECHKOCCOAA, Func<CancellationToken, Task> CNEBJLFLBAL, int DDCGPAJDMLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3030850", Offset = "0x302FC50", VA = "0x183030850")]
	public MFNPLLGOGAD PIGKMIJNHOD(DPMOCIMNJAD KEDDOJGHNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x302F260", Offset = "0x302E660", VA = "0x18302F260")]
	public LLFKODGPJMJ COJJMFMDHKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x302F810", Offset = "0x302EC10", VA = "0x18302F810")]
	public NPLMCAJFHGI IGCADJGCFEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x30302E0", Offset = "0x302F6E0", VA = "0x1830302E0")]
	public NOPHMKEBNNO MPNPCDPLJDC([Optional] IECEHJHNOCE? AGHIOHHDKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x30306D0", Offset = "0x302FAD0", VA = "0x1830306D0")]
	public void PHGBJPHOGDK(Func<Guid, bool> HOJCMPMFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x302FCB0", Offset = "0x302F0B0", VA = "0x18302FCB0")]
	public void KGOAOMOOMHF(Func<Guid, bool> HBPLCGMDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x302F2D0", Offset = "0x302E6D0", VA = "0x18302F2D0")]
	public void DBILLNEAJFN(Func<Guid, bool> HOJCMPMFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x302F600", Offset = "0x302EA00", VA = "0x18302F600")]
	public Guid IAAGNLNGPAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x302FB20", Offset = "0x302EF20", VA = "0x18302FB20")]
	public void JLHJMDHPNMC(Guid FDOLBFAMFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3030190", Offset = "0x302F590", VA = "0x183030190")]
	public void MJAIMCAMDCD(MFNPLLGOGAD PKNHKAAPJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3030010", Offset = "0x302F410", VA = "0x183030010")]
	public void MFIHEHOKFNE(string MJAEGKLPJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x302FE90", Offset = "0x302F290", VA = "0x18302FE90")]
	public void MFIHEHOKFNE(Func<string> JOCAEADGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x30E5660", Offset = "0x30E4A60", VA = "0x1830E5660")]
	private T MGBAAFPAJFC<T>(T IGDJJEECDAF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x302F210", Offset = "0x302E610", VA = "0x18302F210")]
	public void CHMIKHNKNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x30E4EC0", Offset = "0x30E42C0", VA = "0x1830E4EC0")]
	[CompilerGenerated]
	internal static string BNLKBGADECF<T>(byte[] EEMDNKKFCBK, int JDEHNIBPJKF, ref KDPIFMOGDMM<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class FJDBCPDCENI : NMCMEOAHLPH
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class JIHJKAJOMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JIHJKAJOMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3029780", Offset = "0x3028B80", VA = "0x183029780")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct GCIDOFBBBKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public FJDBCPDCENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private NPLMCAJFHGI <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3024760", Offset = "0x3023B60", VA = "0x183024760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class ILIOIDEAMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public HDKAGFAIENG presence;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ILIOIDEAMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3028B60", Offset = "0x3027F60", VA = "0x183028B60")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly NGANIFEBMGB JAEIJKMFOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly LBBLCNAMBKL BHKDKHCKFFG;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private const bool MLEAMDECAIC = false;

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x26A1B20", Offset = "0x26A0F20", VA = "0x1826A1B20")]
	public FJDBCPDCENI(NGANIFEBMGB JAEIJKMFOMM, LBBLCNAMBKL BHKDKHCKFFG, Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x26A15A0", Offset = "0x26A09A0", VA = "0x1826A15A0", Slot = "8")]
	[AsyncStateMachine(typeof(GCIDOFBBBKG))]
	protected override Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x26A16F0", Offset = "0x26A0AF0", VA = "0x1826A16F0")]
	private HDKAGFAIENG FMFJIMIFDHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class HDFMHKFCJJA : NMCMEOAHLPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct GHLBIFLGIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public HDFMHKFCJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<CONFMKJIMDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x30251B0", Offset = "0x30245B0", VA = "0x1830251B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly int GGHGBIBGLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly LMBGJPBKLNM MGLNAHCNMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public readonly long GGNCNAGHBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public readonly long AFKIIBGDIKG;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CONFMKJIMDP GOCEIMNOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x67ED80", Offset = "0x67E180", VA = "0x18067ED80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x915880", Offset = "0x914C80", VA = "0x180915880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x26A7280", Offset = "0x26A6680", VA = "0x1826A7280")]
	public HDFMHKFCJJA(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM, int GGHGBIBGLGK, LMBGJPBKLNM MGLNAHCNMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x26A7140", Offset = "0x26A6540", VA = "0x1826A7140", Slot = "8")]
	[AsyncStateMachine(typeof(GHLBIFLGIJG))]
	protected override Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class HLPFDOALFKA : NMCMEOAHLPH
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class OIIBNOMHAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public HLPFDOALFKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public FJGLKMANPAI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OIIBNOMHAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x3035F60", Offset = "0x3035360", VA = "0x183035F60")]
		internal Task <RunAsync>b__0(IKIBJCADMMP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x3035FA0", Offset = "0x30353A0", VA = "0x183035FA0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct OBLGKOIFPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public HLPFDOALFKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private OIIBNOMHAOH <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3033520", Offset = "0x3032920", VA = "0x183033520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct BBIKPDABICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public FJGLKMANPAI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public HLPFDOALFKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x3020930", Offset = "0x301FD30", VA = "0x183020930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x26A8530", Offset = "0x26A7930", VA = "0x1826A8530")]
	public HLPFDOALFKA(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM, string DMBPCNEAHJF, IIPDMJLEAFA GKHLDKLBDNC, bool HFODJCMDCMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x26A83E0", Offset = "0x26A77E0", VA = "0x1826A83E0", Slot = "8")]
	[AsyncStateMachine(typeof(OBLGKOIFPLL))]
	protected override Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task FBCJLGAGADP(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x26A8280", Offset = "0x26A7680", VA = "0x1826A8280")]
	[AsyncStateMachine(typeof(BBIKPDABICK))]
	private Task BOIFPIIAJJB(IDisposable OGAABOAJECF, FJGLKMANPAI PMAFEIPPMCP, IKIBJCADMMP ANOJNPAHJKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class KNNCCLDNFED : NMCMEOAHLPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct FBDGDOEIMDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public KNNCCLDNFED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public NPDJBKPIGJG operationContext;

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
		private TaskAwaiter<KEGHMBLLMCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3239010", Offset = "0x3238410", VA = "0x183239010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly AEDHGGAECKF BFONPHLGOFF;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x26B16C0", Offset = "0x26B0AC0", VA = "0x1826B16C0")]
	public KNNCCLDNFED(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM, AEDHGGAECKF BFONPHLGOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x26B15E0", Offset = "0x26B09E0", VA = "0x1826B15E0", Slot = "7")]
	protected override string PMHJJIPJPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x26B14A0", Offset = "0x26B08A0", VA = "0x1826B14A0", Slot = "8")]
	[AsyncStateMachine(typeof(FBDGDOEIMDM))]
	protected override Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal abstract class NMCMEOAHLPH : PPBHKKGGKNA
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task GCOELCDDOPD(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class HOGEJJOMHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public IKIBJCADMMP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public NMCMEOAHLPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HOGEJJOMHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x46D09C0", Offset = "0x46CFDC0", VA = "0x1846D09C0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class ILMHLAHJGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public HOGEJJOMHHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ILMHLAHJGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x46D0F20", Offset = "0x46D0320", VA = "0x1846D0F20")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x46D0FE0", Offset = "0x46D03E0", VA = "0x1846D0FE0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct EEONCCCLFOJ : IAsyncStateMachine
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
		public NMCMEOAHLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<NMCMEOAHLPH, IKIBJCADMMP, NPDJBKPIGJG> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private HOGEJJOMHHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private NPDJBKPIGJG <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x32379F0", Offset = "0x3236DF0", VA = "0x1832379F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct IBCBJLLNDFO : IAsyncStateMachine
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
		public NMCMEOAHLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x46D09F0", Offset = "0x46CFDF0", VA = "0x1846D09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public readonly Guid MAIJDDOJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public readonly ByteString GICMGPJICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly NFFKLIOJGMF FEOOPIECBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	protected readonly string EMKABELJHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly bool HFODJCMDCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly Queue<GCOELCDDOPD> PCMKNPGPHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly MKNHLIJNJKP LPJHDNDJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly IIPDMJLEAFA GKHLDKLBDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private bool ONJGMJMHDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public MABCHFGOLAP PIAKOOLGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public MABCHFGOLAP CAINBPBHNEG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CFOGACNBCBD BLCLMCFGGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x302DED0", Offset = "0x302D2D0", VA = "0x18302DED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KKCNBOMMFAG BHKMFKFDGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x302DB50", Offset = "0x302CF50", VA = "0x18302DB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x302DAB0", Offset = "0x302CEB0", VA = "0x18302DAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float GMEKFOLMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x302DB30", Offset = "0x302CF30", VA = "0x18302DB30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event LGDLELCMDMM JBMMGCLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x302DA70", Offset = "0x302CE70", VA = "0x18302DA70", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x302DA90", Offset = "0x302CE90", VA = "0x18302DA90", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x302DF60", Offset = "0x302D360", VA = "0x18302DF60")]
	protected NMCMEOAHLPH(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM, string DMBPCNEAHJF, IIPDMJLEAFA GKHLDKLBDNC, bool HFODJCMDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x302DF20", Offset = "0x302D320", VA = "0x18302DF20", Slot = "7")]
	protected virtual string PMHJJIPJPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x302DBA0", Offset = "0x302CFA0", VA = "0x18302DBA0")]
	public void OOAFONBIFGC(GCOELCDDOPD ODALGMINCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x302D780", Offset = "0x302CB80", VA = "0x18302D780")]
	protected void EMBJNPHMDFM(float ENPADDIHOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x302D630", Offset = "0x302CA30", VA = "0x18302D630")]
	[AsyncStateMachine(typeof(EEONCCCLFOJ))]
	public Task CECDLANABFD(CancellationToken BJOMIPBBJKO, IKIBJCADMMP LNACOMDLNOJ, [Optional] Func<NMCMEOAHLPH, IKIBJCADMMP, NPDJBKPIGJG> PAFACHLIMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x302D7A0", Offset = "0x302CBA0", VA = "0x18302D7A0")]
	private void FIHCMODDIPC(bool DILBCNADBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x302DC00", Offset = "0x302D000", VA = "0x18302DC00")]
	private void PEFGFHBKJBC(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x302D930", Offset = "0x302CD30", VA = "0x18302D930")]
	[AsyncStateMachine(typeof(IBCBJLLNDFO))]
	private Task GKMFPEDFEFL(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x302DE50", Offset = "0x302D250", VA = "0x18302DE50")]
	public MFNPLLGOGAD PIGKMIJNHOD(DPMOCIMNJAD KEDDOJGHNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x302D550", Offset = "0x302C950", VA = "0x18302D550")]
	[CompilerGenerated]
	private Task BHLBOEBGANF(CancellationToken BJKDLBIJMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal sealed class KPJAMLIEAHI : HLPFDOALFKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct NPAAAFKOCLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public KPJAMLIEAHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private CKOHOJDPEFN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private NPLMCAJFHGI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3244C30", Offset = "0x3244030", VA = "0x183244C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly NGANIFEBMGB OOLBLIDPJIB;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x26B18B0", Offset = "0x26B0CB0", VA = "0x1826B18B0")]
	public KPJAMLIEAHI(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NGANIFEBMGB OOLBLIDPJIB, NFFKLIOJGMF PHKCFMENLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x26B1760", Offset = "0x26B0B60", VA = "0x1826B1760", Slot = "9")]
	[AsyncStateMachine(typeof(NPAAAFKOCLN))]
	protected override Task FBCJLGAGADP(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BOHDCMFDFMA : NMCMEOAHLPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct ODOOECECFDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public BOHDCMFDFMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter<KEGHMBLLMCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3034DB0", Offset = "0x30341B0", VA = "0x183034DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly string KCBCONDOCPA;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2698630", Offset = "0x2697A30", VA = "0x182698630")]
	public BOHDCMFDFMA(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, NFFKLIOJGMF PHKCFMENLCM, string KCBCONDOCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2698500", Offset = "0x2697900", VA = "0x182698500", Slot = "8")]
	[AsyncStateMachine(typeof(ODOOECECFDE))]
	protected override Task ECIJNOIHKIG(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class JMODAGFGNII : HLPFDOALFKA
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class EHFDLEGFMGN
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
			public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public EHFDLEGFMGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private TaskAwaiter<KEGHMBLLMCM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter<MFNPLLGOGAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x46D7FB0", Offset = "0x46D73B0", VA = "0x1846D7FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x46D8300", Offset = "0x46D7700", VA = "0x1846D8300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public JMODAGFGNII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public NOPHMKEBNNO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public LLFKODGPJMJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EHFDLEGFMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x32387F0", Offset = "0x3237BF0", VA = "0x1832387F0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MFNPLLGOGAD> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct PHCDNOEEALN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public JMODAGFGNII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EHFDLEGFMGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private CKOHOJDPEFN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private NPLMCAJFHGI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x32465F0", Offset = "0x32459F0", VA = "0x1832465F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly int KECIOLCNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[CanBeNull]
	private readonly JNDNCHHADEN DLOFILGCNNC;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x26AE3E0", Offset = "0x26AD7E0", VA = "0x1826AE3E0")]
	public JMODAGFGNII(Guid MOLEKIELIBJ, CFOGACNBCBD IPNLLMLMMNI, int KECIOLCNGHC, JNDNCHHADEN DLOFILGCNNC, NFFKLIOJGMF PHKCFMENLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x26ADFC0", Offset = "0x26AD3C0", VA = "0x1826ADFC0", Slot = "9")]
	[AsyncStateMachine(typeof(PHCDNOEEALN))]
	protected override Task FBCJLGAGADP(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x26AE2C0", Offset = "0x26AD6C0", VA = "0x1826AE2C0")]
	private void MHAMCEFFCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26AE120", Offset = "0x26AD520", VA = "0x1826AE120")]
	private void KCBKNPNMNIP(IKIBJCADMMP LNACOMDLNOJ, CKOHOJDPEFN EFBPCCGHHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal abstract class LBLFAMFCEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly NMCMEOAHLPH MLGDDCAPKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public readonly NPDJBKPIGJG JKGJOMPPKFJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x26B1A50", Offset = "0x26B0E50", VA = "0x1826B1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x26B19B0", Offset = "0x26B0DB0", VA = "0x1826B19B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x26B1A70", Offset = "0x26B0E70", VA = "0x1826B1A70")]
	protected LBLFAMFCEMA(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x26B1A30", Offset = "0x26B0E30", VA = "0x1826B1A30")]
	protected void MFIHEHOKFNE(string MJAEGKLPJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x26B1A10", Offset = "0x26B0E10", VA = "0x1826B1A10")]
	public void MFIHEHOKFNE(Func<string> JOCAEADGDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct POKCBINAHLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public Dictionary<Guid, List<NKOHEODHLDH>> GHLPNLHCECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public Dictionary<Guid, List<NKOHEODHLDH>> KAOALMLFKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<NKOHEODHLDH>> JJDEDHNEBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public List<Guid> BOCMNIFGIGE;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x30384E0", Offset = "0x30378E0", VA = "0x1830384E0")]
	public static POKCBINAHLP JLHLNIPLDNM(CANONBEOPPD GEEOPHADFKF, MABCHFGOLAP LPNAIGMHGJO, OHNBOJIMJND BLOAKGIDFJE)
	{
		return default(POKCBINAHLP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct BIDIAGNCGNL
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
	public static BIDIAGNCGNL FNICMNFMKAL()
	{
		return default(BIDIAGNCGNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GPABOPFAOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KKBBNNHDBPJ(OHNBOJIMJND PNMIIEJFOON, object FAPFPPANPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LEJMOMLBAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct FMPLMMKHKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly PCBJAABEHPG CCOKLHEHHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly FHLHIJKLEKO CJMJDLOLFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly KFIFOICIHDO EBOIMGDKAHA;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x26A41B0", Offset = "0x26A35B0", VA = "0x1826A41B0")]
	public FMPLMMKHKFC(PCBJAABEHPG CCOKLHEHHJD, FHLHIJKLEKO CJMJDLOLFMM, KFIFOICIHDO EBOIMGDKAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct GLKANLOGMCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private readonly NPDJBKPIGJG NGBLBNOIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private readonly Guid FDOLBFAMFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private bool DILBCNADBAN;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x26A6DB0", Offset = "0x26A61B0", VA = "0x1826A6DB0")]
	public static GLKANLOGMCE IAAGNLNGPAM(NPDJBKPIGJG NGBLBNOIPKA)
	{
		return default(GLKANLOGMCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x172C080", Offset = "0x172B480", VA = "0x18172C080")]
	public void PKADMBMDHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D50", Offset = "0x26A6150", VA = "0x1826A6D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EC0", Offset = "0x26A62C0", VA = "0x1826A6EC0")]
	private GLKANLOGMCE(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D50", Offset = "0x26A6150", VA = "0x1826A6D50")]
	private void JLHJMDHPNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x26A6E10", Offset = "0x26A6210", VA = "0x1826A6E10")]
	private Func<Guid, bool> KBHCDFGMNPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class NPLMCAJFHGI : LBLFAMFCEMA, PPBHKKGGKNA
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public delegate Task<MABCHFGOLAP> JJKLJCMLJMO(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL LGPAPPIGGOC, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct PCCEAOFJEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public NGANIFEBMGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private GLKANLOGMCE <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x46D50F0", Offset = "0x46D44F0", VA = "0x1846D50F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct FGBIPAMHDMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public NGANIFEBMGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private IKIBJCADMMP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x46CD020", Offset = "0x46CC420", VA = "0x1846CD020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x46CD340", Offset = "0x46CC740", VA = "0x1846CD340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct KHJFHGMBDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public NGANIFEBMGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private IKIBJCADMMP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x46D2F20", Offset = "0x46D2320", VA = "0x1846D2F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class FLJJEDFAOCF
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
			public AsyncTaskMethodBuilder<FMPLMMKHKFC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public FLJJEDFAOCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private FMPLMMKHKFC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<MABCHFGOLAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<FMPLMMKHKFC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x46D6D00", Offset = "0x46D6100", VA = "0x1846D6D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x46D7310", Offset = "0x46D6710", VA = "0x1846D7310", Slot = "5")]
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
			public AsyncTaskMethodBuilder<OHNBOJIMJND> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public FLJJEDFAOCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private OHNBOJIMJND <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<MABCHFGOLAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private TaskAwaiter<OHNBOJIMJND> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x46D7360", Offset = "0x46D6760", VA = "0x1846D7360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x46D7890", Offset = "0x46D6C90", VA = "0x1846D7890", Slot = "5")]
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
			public FLJJEDFAOCF <>4__this;

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
			private TaskAwaiter<MABCHFGOLAP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private AOCNEFENODL <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x46D58D0", Offset = "0x46D4CD0", VA = "0x1846D58D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public NGANIFEBMGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public MKNHLIJNJKP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public MKNHLIJNJKP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public FMPLMMKHKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public MKNHLIJNJKP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public OHNBOJIMJND phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public HEOMPLODKGB.PFGCJHJCHBH <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FLJJEDFAOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x46CD4C0", Offset = "0x46CC8C0", VA = "0x1846CD4C0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FMPLMMKHKFC> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x46CD600", Offset = "0x46CCA00", VA = "0x1846CD600")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OHNBOJIMJND> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x46CD740", Offset = "0x46CCB40", VA = "0x1846CD740")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x46CD390", Offset = "0x46CC790", VA = "0x1846CD390")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct GHIPBCIPEAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public NGANIFEBMGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private FLJJEDFAOCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<FMPLMMKHKFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter<OHNBOJIMJND> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x46CF190", Offset = "0x46CE590", VA = "0x1846CF190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BCPFPLFCLKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x46C9D40", Offset = "0x46C9140", VA = "0x1846C9D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct APDMLIPCDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IKIBJCADMMP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x46C92D0", Offset = "0x46C86D0", VA = "0x1846C92D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct KLPEHAJHDFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private IKIBJCADMMP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x46D3180", Offset = "0x46D2580", VA = "0x1846D3180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x46D3C20", Offset = "0x46D3020", VA = "0x1846D3C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct GFPLHFOJGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private IKIBJCADMMP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x46CE590", Offset = "0x46CD990", VA = "0x1846CE590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x46CF140", Offset = "0x46CE540", VA = "0x1846CF140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct OJBAIGLHOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public MABCHFGOLAP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public OHNBOJIMJND deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x46D4EA0", Offset = "0x46D42A0", VA = "0x1846D4EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x46D50A0", Offset = "0x46D44A0", VA = "0x1846D50A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class PMAAEBPFMII
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
			public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public PMAAEBPFMII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<MABCHFGOLAP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x46D78E0", Offset = "0x46D6CE0", VA = "0x1846D78E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x46D7E20", Offset = "0x46D7220", VA = "0x1846D7E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public JJKLJCMLJMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public MABCHFGOLAP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PMAAEBPFMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x46D5650", Offset = "0x46D4A50", VA = "0x1846D5650")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MABCHFGOLAP> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct GAGLIDLPDGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public JJKLJCMLJMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x46CD780", Offset = "0x46CCB80", VA = "0x1846CD780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x46CDC20", Offset = "0x46CD020", VA = "0x1846CDC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GECBNLMEMKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public MKNHLIJNJKP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private MABCHFGOLAP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private IEnumerator<MABCHFGOLAP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x46CE150", Offset = "0x46CD550", VA = "0x1846CE150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct PEKGEFDJAJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x46D5480", Offset = "0x46D4880", VA = "0x1846D5480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct BGJDHHFCPOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CFOGACNBCBD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x46CA260", Offset = "0x46C9660", VA = "0x1846CA260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct JODOBCLPOEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public NPLMCAJFHGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x46D1DC0", Offset = "0x46D11C0", VA = "0x1846D1DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class LPKEDDNOHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public PCBJAABEHPG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LPKEDDNOHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x46D3E50", Offset = "0x46D3250", VA = "0x1846D3E50")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly JGNPMEGNACG EKIDDPCANHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly JGNPMEGNACG DLGBFOEDNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly LFHKFJAEBGI ELEIJOGPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly KFANHBEOLML FOILFDKNEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly ELKCMMIBBII PMBHMBCEOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly FMIJFIJBOLP FBOJMJKODPA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float GMEKFOLMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x30330D0", Offset = "0x30324D0", VA = "0x1830330D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private CFOGACNBCBD BLCLMCFGGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x26B46A0", Offset = "0x26B3AA0", VA = "0x1826B46A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LGDLELCMDMM JBMMGCLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3032440", Offset = "0x3031840", VA = "0x183032440", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x3032460", Offset = "0x3031860", VA = "0x183032460", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x30332C0", Offset = "0x30326C0", VA = "0x1830332C0")]
	public NPLMCAJFHGI(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x30322E0", Offset = "0x30316E0", VA = "0x1830322E0")]
	[AsyncStateMachine(typeof(PCCEAOFJEEF))]
	public Task JJFBLNOKMKF(NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, bool KGCDPFFAKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x30325E0", Offset = "0x30319E0", VA = "0x1830325E0")]
	[AsyncStateMachine(typeof(FGBIPAMHDMG))]
	private Task<MFNPLLGOGAD> KDOKPDCAABI(NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x30330F0", Offset = "0x30324F0", VA = "0x1830330F0")]
	[AsyncStateMachine(typeof(KHJFHGMBDBJ))]
	private Task OGFCGMEHLOP(NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, bool KGCDPFFAKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x3032480", Offset = "0x3031880", VA = "0x183032480")]
	[AsyncStateMachine(typeof(GHIPBCIPEAP))]
	private Task KCPPHMEDNGO(NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP LNACOMDLNOJ, CancellationToken JDNNKIKHOHD, bool KGCDPFFAKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x3032760", Offset = "0x3031B60", VA = "0x183032760")]
	[AsyncStateMachine(typeof(BCPFPLFCLKC))]
	private Task KECNCFOBEEJ(IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x3032180", Offset = "0x3031580", VA = "0x183032180")]
	[AsyncStateMachine(typeof(APDMLIPCDPD))]
	private Task IOKOKOGBCHD(OHNBOJIMJND PNMIIEJFOON, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3031CA0", Offset = "0x30310A0", VA = "0x183031CA0")]
	[AsyncStateMachine(typeof(KLPEHAJHDFL))]
	private Task<MABCHFGOLAP> CNPPABIACPG(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3032CE0", Offset = "0x30320E0", VA = "0x183032CE0")]
	[AsyncStateMachine(typeof(GFPLHFOJGPK))]
	private Task<MABCHFGOLAP> NBKHDGGALBI(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x3031A30", Offset = "0x3030E30", VA = "0x183031A30")]
	[AsyncStateMachine(typeof(OJBAIGLHOJK))]
	private Task<MABCHFGOLAP> AKHLOBFIGKP(MABCHFGOLAP LPNAIGMHGJO, OHNBOJIMJND BLOAKGIDFJE, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, bool PKMFFGGHDBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3032FE0", Offset = "0x30323E0", VA = "0x183032FE0")]
	private bool NOPCKIEIPKC(OHNBOJIMJND PANLBBKLKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3031F70", Offset = "0x3031370", VA = "0x183031F70")]
	[AsyncStateMachine(typeof(GAGLIDLPDGG))]
	protected Task<MABCHFGOLAP> GNFEKANCGIK(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, JJKLJCMLJMO CELIAHNENED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3032890", Offset = "0x3031C90", VA = "0x183032890")]
	[AsyncStateMachine(typeof(GECBNLMEMKD))]
	private Task KFNPPLBNEON(OHNBOJIMJND PNMIIEJFOON, MKNHLIJNJKP IIJHMGPFNOD, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3031BF0", Offset = "0x3030FF0", VA = "0x183031BF0")]
	private void BGHIIIDLLFA(MABCHFGOLAP NBBOGIJMFOO, MKNHLIJNJKP IIJHMGPFNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x3031C40", Offset = "0x3031040", VA = "0x183031C40")]
	private void CEDMMFFFABP(MABCHFGOLAP OLNCGODMNJJ, out MABCHFGOLAP KCEINEGIEFN, out MABCHFGOLAP OMBHPIEHHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x3032120", Offset = "0x3031520", VA = "0x183032120")]
	private Task<FMPLMMKHKFC> HHGFIEKDKGO(NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x3033270", Offset = "0x3032670", VA = "0x183033270")]
	private Task<OHNBOJIMJND> PALEEACMGAH(NGANIFEBMGB EMCPHLBMEHO, FMPLMMKHKFC PNMIIEJFOON, HEOMPLODKGB.PFGCJHJCHBH FECBNLJGOFC, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x3031E20", Offset = "0x3031220", VA = "0x183031E20")]
	[AsyncStateMachine(typeof(PEKGEFDJAJO))]
	private Task FODHANFIMLB(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x3032B50", Offset = "0x3031F50", VA = "0x183032B50")]
	[AsyncStateMachine(typeof(BGJDHHFCPOG))]
	private Task MAEHNDPJCEC(OHNBOJIMJND PNMIIEJFOON, CFOGACNBCBD IPNLLMLMMNI, IKIBJCADMMP LNACOMDLNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x3032EC0", Offset = "0x30322C0", VA = "0x183032EC0")]
	[AsyncStateMachine(typeof(JODOBCLPOEM))]
	private Task NMCCMHIKBMO(OHNBOJIMJND PNMIIEJFOON, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x3031BC0", Offset = "0x3030FC0", VA = "0x183031BC0")]
	private Task BANCMJJNPBP(OHNBOJIMJND PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x3031C80", Offset = "0x3031080", VA = "0x183031C80")]
	private Task CFLMOBCBNPO(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x3033250", Offset = "0x3032650", VA = "0x183033250")]
	private Task OKIFNIKLGJP(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x3032E80", Offset = "0x3032280", VA = "0x183032E80")]
	private Task NDLBJBECMGE(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x3032CD0", Offset = "0x30320D0", VA = "0x183032CD0")]
	private static Task MINEDILLOGF(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3032160", Offset = "0x3031560", VA = "0x183032160")]
	private Task IGJBOHDMACD(OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x3032EA0", Offset = "0x30322A0", VA = "0x183032EA0")]
	private Task NKPAPELKFBC(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x3032CA0", Offset = "0x30320A0", VA = "0x183032CA0")]
	private void MBDAOBBIMFB(NGANIFEBMGB EMCPHLBMEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x30329F0", Offset = "0x3031DF0", VA = "0x1830329F0")]
	private static void LFAGCCDLEAF(PCBJAABEHPG CCOKLHEHHJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct PHNAMLEJJEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private MABCHFGOLAP NBBOGIJMFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private OHNBOJIMJND PNMIIEJFOON;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3038170", Offset = "0x3037570", VA = "0x183038170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x30380F0", Offset = "0x30374F0", VA = "0x1830380F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3038040", Offset = "0x3037440", VA = "0x183038040")]
	public static Task CECDLANABFD(CFOGACNBCBD IPNLLMLMMNI, MABCHFGOLAP NBBOGIJMFOO, OHNBOJIMJND PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x3037DF0", Offset = "0x30371F0", VA = "0x183037DF0")]
	private void CECDLANABFD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct GLAONKKGIDO
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x26A6C30", Offset = "0x26A6030", VA = "0x1826A6C30")]
	public static Task CECDLANABFD(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JAAMEEMEGDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct OAKCPPBLPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private IKIBJCADMMP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x32451F0", Offset = "0x32445F0", VA = "0x1832451F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26ACEC0", Offset = "0x26AC2C0", VA = "0x1826ACEC0")]
	[AsyncStateMachine(typeof(OAKCPPBLPLN))]
	public static Task CECDLANABFD(NPDJBKPIGJG NGBLBNOIPKA, OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct JDHGMNEBAJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct HEHIIGEIJJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private MABCHFGOLAP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private CFOGACNBCBD <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private CANONBEOPPD <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private List<(PersistenceView, NBMCGLEDJNH)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private NBMCGLEDJNH <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x323B920", Offset = "0x323AD20", VA = "0x18323B920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26AD500", Offset = "0x26AC900", VA = "0x1826AD500")]
	[AsyncStateMachine(typeof(HEHIIGEIJJJ))]
	public static Task CECDLANABFD(NPDJBKPIGJG NGBLBNOIPKA, OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x26AD290", Offset = "0x26AC690", VA = "0x1826AD290")]
	private static void BPJOCJAHLFA(PersistenceView ANICJOOMAKF, NBMCGLEDJNH FAPFPPANPDB, OHNBOJIMJND PNMIIEJFOON, MABCHFGOLAP LPNAIGMHGJO, bool PHLOBJIDPJA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct JAKOPJLIFPD
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x26AD010", Offset = "0x26AC410", VA = "0x1826AD010")]
	public static Task CECDLANABFD(CFOGACNBCBD IPNLLMLMMNI, OHNBOJIMJND PNMIIEJFOON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct ODJGKDHHGON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct LJBAJOIBPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public CFOGACNBCBD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x46D3CE0", Offset = "0x46D30E0", VA = "0x1846D3CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct OGDAPKOFNFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public ODJGKDHHGON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x46D4600", Offset = "0x46D3A00", VA = "0x1846D4600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class EINPBOPIOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CHICPPMIFLO version;

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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EINPBOPIOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x46CC950", Offset = "0x46CBD50", VA = "0x1846CC950")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x46CCA30", Offset = "0x46CBE30", VA = "0x1846CCA30")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private OHNBOJIMJND PNMIIEJFOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private NPDJBKPIGJG NGBLBNOIPKA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString FGFDAGJNBEH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x3034CE0", Offset = "0x30340E0", VA = "0x183034CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private LPKCDHNKKJE MHCPIANHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3034C30", Offset = "0x3034030", VA = "0x183034C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3034430", Offset = "0x3033830", VA = "0x183034430")]
	[AsyncStateMachine(typeof(LJBAJOIBPPP))]
	public static Task CECDLANABFD(CFOGACNBCBD IPNLLMLMMNI, MABCHFGOLAP NBBOGIJMFOO, OHNBOJIMJND PNMIIEJFOON, NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x30342F0", Offset = "0x30336F0", VA = "0x1830342F0")]
	[AsyncStateMachine(typeof(OGDAPKOFNFI))]
	private Task CECDLANABFD(IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3034590", Offset = "0x3033990", VA = "0x183034590")]
	private void IEBALLFFBLB([NotNull] BLKLDFBMGPO JBECKINBFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3034CB0", Offset = "0x30340B0", VA = "0x183034CB0")]
	private bool OKMPGMKKMFF(CHICPPMIFLO FMCKDMNHLLD, BLKLDFBMGPO JBECKINBFJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct JFLCDDJLEBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct ANMNGPKBNML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder<OHNBOJIMJND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public JFLCDDJLEBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public HEOMPLODKGB.PFGCJHJCHBH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private IKIBJCADMMP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter<(global::BFOGDGGAJLJ<PKDOPDLBJEI, DJBJKBPDGID>, global::BFOGDGGAJLJ<global::NCLCEHNCJOC<BLKLDFBMGPO>, DJBJKBPDGID>, global::BFOGDGGAJLJ<global::NCLCEHNCJOC<ONLLFCEBJLC>, DJBJKBPDGID>, global::BFOGDGGAJLJ<global::NCLCEHNCJOC<GANFMPDCCEC>, DJBJKBPDGID>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x3233220", Offset = "0x3232620", VA = "0x183233220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x3233AE0", Offset = "0x3232EE0", VA = "0x183233AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct BEPPPNEMEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder<global::BFOGDGGAJLJ<PKDOPDLBJEI, DJBJKBPDGID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public IKIBJCADMMP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public JFLCDDJLEBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public HEOMPLODKGB.PFGCJHJCHBH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private IKIBJCADMMP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<global::BFOGDGGAJLJ<PKDOPDLBJEI, DJBJKBPDGID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3234980", Offset = "0x3233D80", VA = "0x183234980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3234E70", Offset = "0x3234270", VA = "0x183234E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private global::OOPNAKGODNG<NHJHNDPNKHC, ONLLFCEBJLC> CKINMMHODBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private global::OOPNAKGODNG<NHJHNDPNKHC, BLKLDFBMGPO> CJMJDLOLFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private global::OOPNAKGODNG<long, GANFMPDCCEC> IBOAJNPKINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private APKNGAEPGMP FMKDGDLAFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private NGANIFEBMGB EMCPHLBMEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private PCBJAABEHPG CCOKLHEHHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private FHLHIJKLEKO IJDEOPFBEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private long LAPDEGDDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private IKIBJCADMMP ANOJNPAHJKB;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x26AD670", Offset = "0x26ACA70", VA = "0x1826AD670")]
	public static Task<OHNBOJIMJND> AGCFLIABLKJ(CFOGACNBCBD IPNLLMLMMNI, NGANIFEBMGB EMCPHLBMEHO, in FMPLMMKHKFC PNMIIEJFOON, HEOMPLODKGB.PFGCJHJCHBH FECBNLJGOFC, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x26AD990", Offset = "0x26ACD90", VA = "0x1826AD990")]
	[AsyncStateMachine(typeof(ANMNGPKBNML))]
	private Task<OHNBOJIMJND> CECDLANABFD(HEOMPLODKGB.PFGCJHJCHBH FECBNLJGOFC, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x26ADB00", Offset = "0x26ACF00", VA = "0x1826ADB00")]
	private NHJHNDPNKHC DKOALHGANJG(GFBPABDGPKK LIBCCFIBPDP)
	{
		return default(NHJHNDPNKHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x26ADB40", Offset = "0x26ACF40", VA = "0x1826ADB40")]
	[AsyncStateMachine(typeof(BEPPPNEMEHM))]
	private Task<global::BFOGDGGAJLJ<PKDOPDLBJEI, DJBJKBPDGID>> FBNJNCMBDDD(string OJHPMMBEEBE, long LAPDEGDDDKC, HEOMPLODKGB.PFGCJHJCHBH FECBNLJGOFC, IKIBJCADMMP FHLNHLLLBKM, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal struct IONLIDEJIBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct CCKJDKONELL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<FMPLMMKHKFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public IONLIDEJIBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IKIBJCADMMP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<FMPLMMKHKFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3236540", Offset = "0x3235940", VA = "0x183236540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x32369F0", Offset = "0x3235DF0", VA = "0x1832369F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct HPFCIIPJPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<FMPLMMKHKFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public IONLIDEJIBG <>4__this;

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
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter<FMPLMMKHKFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x323C910", Offset = "0x323BD10", VA = "0x18323C910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x323CB00", Offset = "0x323BF00", VA = "0x18323CB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class IBNOABFEOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IBNOABFEOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x115F080", Offset = "0x115E480", VA = "0x18115F080")]
		internal bool <FetchRoomDetails>b__0(FHLHIJKLEKO sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct AJEMJMAMKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder<FMPLMMKHKFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public CANONBEOPPD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private IBNOABFEOAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter<PCBJAABEHPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x3232B40", Offset = "0x3231F40", VA = "0x183232B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x3233080", Offset = "0x3232480", VA = "0x183233080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private LFHKFJAEBGI ELEIJOGPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private IKIBJCADMMP ANOJNPAHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private long DDEPFHBCOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private long LBIOPPABCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private string CCNFKACPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private NHJHNDPNKHC HCCAEGAOELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private NHJHNDPNKHC JHOEAKJFNOE;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26ABE70", Offset = "0x26AB270", VA = "0x1826ABE70")]
	public static Task<FMPLMMKHKFC> AGCFLIABLKJ(CFOGACNBCBD IPNLLMLMMNI, NGANIFEBMGB EMCPHLBMEHO, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26AC2A0", Offset = "0x26AB6A0", VA = "0x1826AC2A0")]
	[AsyncStateMachine(typeof(CCKJDKONELL))]
	private Task<FMPLMMKHKFC> CECDLANABFD(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26AC800", Offset = "0x26ABC00", VA = "0x1826AC800")]
	[AsyncStateMachine(typeof(HPFCIIPJPBG))]
	private Task<FMPLMMKHKFC> HHGFIEKDKGO(long DDEPFHBCOHC, long LBIOPPABCMJ, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, bool NDADLKOGFID = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26AC680", Offset = "0x26ABA80", VA = "0x1826AC680")]
	[AsyncStateMachine(typeof(AJEMJMAMKCA))]
	public static Task<FMPLMMKHKFC> HHGFIEKDKGO(CANONBEOPPD GEEOPHADFKF, long DDEPFHBCOHC, long LBIOPPABCMJ, CancellationToken BJOMIPBBJKO, IKIBJCADMMP LNACOMDLNOJ, bool NDADLKOGFID = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26AC400", Offset = "0x26AB800", VA = "0x1826AC400")]
	private void DDDHHLEBDKA(PCBJAABEHPG CCOKLHEHHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x26AC510", Offset = "0x26AB910", VA = "0x1826AC510")]
	private bool EDAGOIMLNCE(FMPLMMKHKFC PNMIIEJFOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26AC100", Offset = "0x26AB500", VA = "0x1826AC100")]
	private void AIMFFOJNEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct IGCBEMAJLEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct IFNNOAGDOKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public IGCBEMAJLEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x323D490", Offset = "0x323C890", VA = "0x18323D490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private const int MKBOKBDEHKG = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private const float DLKFHMKDMFH = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private CANONBEOPPD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private OHNBOJIMJND PNMIIEJFOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private IKIBJCADMMP ANOJNPAHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private float BOMOABEMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private float JIPOOCMFNLN;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x26AB720", Offset = "0x26AAB20", VA = "0x1826AB720")]
	public static Task DHCMHOBFBHE(CFOGACNBCBD IPNLLMLMMNI, OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x26AB450", Offset = "0x26AA850", VA = "0x1826AB450")]
	[AsyncStateMachine(typeof(IFNNOAGDOKI))]
	public Task CECDLANABFD(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x26AB580", Offset = "0x26AA980", VA = "0x1826AB580")]
	private static void CKMFBMHFFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x26AB8C0", Offset = "0x26AACC0", VA = "0x1826AB8C0")]
	private void DOPLLOMBCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x26ABAB0", Offset = "0x26AAEB0", VA = "0x1826ABAB0")]
	private static float HJBHELADOFM(CANONBEOPPD GEEOPHADFKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x26ABA90", Offset = "0x26AAE90", VA = "0x1826ABA90")]
	private static float EFBCNNEHEAG()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct MIEJFEPJLKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct PEJALGOFENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public NPDJBKPIGJG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private NMCMEOAHLPH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private CFOGACNBCBD <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private BGFOBNOIFNP.GHAMIAIOAEP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3245FA0", Offset = "0x32453A0", VA = "0x183245FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct JBFIBBOIEJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private MEODHCGMDDL.JOCALGIMGJP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x323E220", Offset = "0x323D620", VA = "0x18323E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x26B6460", Offset = "0x26B5860", VA = "0x1826B6460")]
	[AsyncStateMachine(typeof(PEJALGOFENE))]
	public static Task CECDLANABFD(NPDJBKPIGJG NGBLBNOIPKA, OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x26B63F0", Offset = "0x26B57F0", VA = "0x1826B63F0")]
	private static Task<MFNPLLGOGAD> ABFHMHPFOMI(NPDJBKPIGJG NGBLBNOIPKA, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x26B65C0", Offset = "0x26B59C0", VA = "0x1826B65C0")]
	[AsyncStateMachine(typeof(JBFIBBOIEJO))]
	private static Task NEEDNGJHIEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct LIAHDCGAKFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct AGBPBPJGDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public LIAHDCGAKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x3232600", Offset = "0x3231A00", VA = "0x183232600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class OINAGJPKFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OINAGJPKFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3245960", Offset = "0x3244D60", VA = "0x183245960")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct PKEJDEHOEGP : IAsyncStateMachine
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
		public LIAHDCGAKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private NHNCGDEOBBP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x3247010", Offset = "0x3246410", VA = "0x183247010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private bool AHOPKMIIGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private IKIBJCADMMP ANOJNPAHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CancellationToken BJOMIPBBJKO;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x26B3FD0", Offset = "0x26B33D0", VA = "0x1826B3FD0")]
	public static Task NBAMMKAINDI(CFOGACNBCBD IPNLLMLMMNI, bool AHOPKMIIGEL, IKIBJCADMMP ANOJNPAHJKB, CancellationToken DNLFAFDPOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x26B3EC0", Offset = "0x26B32C0", VA = "0x1826B3EC0")]
	[AsyncStateMachine(typeof(AGBPBPJGDBE))]
	private Task CECDLANABFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x26B4040", Offset = "0x26B3440", VA = "0x1826B4040")]
	[AsyncStateMachine(typeof(PKEJDEHOEGP))]
	private Task OPLILBCNOGO(bool FPOOHKFBODH, string JAOGIFGAJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
	private bool NIFLIHHHOKB(bool AHOPKMIIGEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct GHCCPPDLEID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct IDFIHGMFBOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public GHCCPPDLEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3028630", Offset = "0x3027A30", VA = "0x183028630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x3028A80", Offset = "0x3027E80", VA = "0x183028A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class HPIHNECAHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HPIHNECAHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x3028050", Offset = "0x3027450", VA = "0x183028050")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct HNOGJBKDLNA : IAsyncStateMachine
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
		public GHCCPPDLEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private NHNCGDEOBBP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x3027AC0", Offset = "0x3026EC0", VA = "0x183027AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3028000", Offset = "0x3027400", VA = "0x183028000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private KFIFOICIHDO BPHDIKKPGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private IKIBJCADMMP ANOJNPAHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private bool HECCMBEPPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private OHNBOJIMJND PNMIIEJFOON;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x26A58E0", Offset = "0x26A4CE0", VA = "0x1826A58E0")]
	public static Task<Scene> EOHDEKJLCOG(CFOGACNBCBD IPNLLMLMMNI, KFIFOICIHDO MADBJGDBPEC, IKIBJCADMMP ANOJNPAHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x26A5A10", Offset = "0x26A4E10", VA = "0x1826A5A10")]
	public static Task<Scene> LPALBOKMAIO(CFOGACNBCBD IPNLLMLMMNI, OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x26A57B0", Offset = "0x26A4BB0", VA = "0x1826A57B0")]
	[AsyncStateMachine(typeof(IDFIHGMFBOA))]
	private Task<Scene> CECDLANABFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x26A59D0", Offset = "0x26A4DD0", VA = "0x1826A59D0")]
	private bool JKCJEAMEMOA(OHNBOJIMJND PNMIIEJFOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x26A5960", Offset = "0x26A4D60", VA = "0x1826A5960")]
	private void HKOAOFIOMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5AB0", Offset = "0x26A4EB0", VA = "0x1826A5AB0")]
	[AsyncStateMachine(typeof(HNOGJBKDLNA))]
	private Task<Scene> OPLILBCNOGO(string JAOGIFGAJOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct ELKCMMIBBII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct CEDPHCDEEAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public ELKCMMIBBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public MABCHFGOLAP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public OHNBOJIMJND deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private IKIBJCADMMP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<MABCHFGOLAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x30215D0", Offset = "0x30209D0", VA = "0x1830215D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3021BF0", Offset = "0x3020FF0", VA = "0x183021BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct GDBDGHGANFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<MABCHFGOLAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public ELKCMMIBBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public MABCHFGOLAP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x3024D70", Offset = "0x3024170", VA = "0x183024D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3025160", Offset = "0x3024560", VA = "0x183025160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly NPDJBKPIGJG NGBLBNOIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private readonly LFHKFJAEBGI ELEIJOGPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private readonly KFANHBEOLML FOILFDKNEGO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private NMCMEOAHLPH MLGDDCAPKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x97B530", Offset = "0x97A930", VA = "0x18097B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x269C550", Offset = "0x269B950", VA = "0x18269C550")]
	public ELKCMMIBBII(NPDJBKPIGJG NGBLBNOIPKA, LFHKFJAEBGI ELEIJOGPKLI, KFANHBEOLML FOILFDKNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x269C390", Offset = "0x269B790", VA = "0x18269C390")]
	[AsyncStateMachine(typeof(CEDPHCDEEAL))]
	public Task<MABCHFGOLAP> IFEMPOLABOO(MABCHFGOLAP JEFCKEDLNLB, OHNBOJIMJND BLOAKGIDFJE, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO, bool PKMFFGGHDBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x269C1F0", Offset = "0x269B5F0", VA = "0x18269C1F0")]
	[AsyncStateMachine(typeof(GDBDGHGANFG))]
	private Task<MABCHFGOLAP> CNOHGMAMOHN(IKIBJCADMMP LNACOMDLNOJ, MABCHFGOLAP OHACFAMPHAM, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x269C360", Offset = "0x269B760", VA = "0x18269C360")]
	private bool EMILMGNJGKH(MABCHFGOLAP HJLNLCMHLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x269C530", Offset = "0x269B930", VA = "0x18269C530")]
	private void MFIHEHOKFNE(string ICBCECIENAJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct MBBEMBCNEMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct HJDOOAJNCMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public NMCMEOAHLPH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private List<(PersistenceView, NBMCGLEDJNH)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private (PersistenceView, NBMCGLEDJNH) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x323C110", Offset = "0x323B510", VA = "0x18323C110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x26B4EA0", Offset = "0x26B42A0", VA = "0x1826B4EA0")]
	[AsyncStateMachine(typeof(HJDOOAJNCMO))]
	public static Task CECDLANABFD(NMCMEOAHLPH OPDADEMFPEM, OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct CEDDBDPFJKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct AHCEOOCNGJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public NMCMEOAHLPH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AOCNEFENODL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private CHICPPMIFLO <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private List<(PersistenceView, NBMCGLEDJNH)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private NBMCGLEDJNH <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x301FB90", Offset = "0x301EF90", VA = "0x18301FB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x26986E0", Offset = "0x2697AE0", VA = "0x1826986E0")]
	[AsyncStateMachine(typeof(AHCEOOCNGJH))]
	public static Task CECDLANABFD(NMCMEOAHLPH OPDADEMFPEM, OHNBOJIMJND PNMIIEJFOON, AOCNEFENODL BOFDBCNKAGK, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct BGFOBNOIFNP
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public struct GHAMIAIOAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public List<ANABMJHNMOB> LBGBHJGDFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public List<NBMCGLEDJNH> MMFBFNMGNFC;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x728A10", Offset = "0x727E10", VA = "0x180728A10")]
		public GHAMIAIOAEP(List<ANABMJHNMOB> LBGBHJGDFFE, List<NBMCGLEDJNH> MMFBFNMGNFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class GAMAMLLGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public IEnumerable<ANABMJHNMOB> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GAMAMLLGAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x30246E0", Offset = "0x3023AE0", VA = "0x1830246E0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private CFOGACNBCBD IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private OHNBOJIMJND PNMIIEJFOON;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private CANONBEOPPD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2697A70", Offset = "0x2696E70", VA = "0x182697A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2697270", Offset = "0x2696670", VA = "0x182697270")]
	public static GHAMIAIOAEP CECDLANABFD(CFOGACNBCBD IPNLLMLMMNI, OHNBOJIMJND PNMIIEJFOON)
	{
		return default(GHAMIAIOAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2696F70", Offset = "0x2696370", VA = "0x182696F70")]
	private GHAMIAIOAEP CECDLANABFD()
	{
		return default(GHAMIAIOAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2697520", Offset = "0x2696920", VA = "0x182697520")]
	private GHAMIAIOAEP KEFEKBDNOHE(BLKLDFBMGPO JBECKINBFJM, CHICPPMIFLO FALBEGMMFHC)
	{
		return default(GHAMIAIOAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x26972D0", Offset = "0x26966D0", VA = "0x1826972D0")]
	private bool EAPGKGEAPIP(IEnumerable<ANABMJHNMOB> LBGBHJGDFFE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct BNBJKACOHGG
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class PAGLILLHANN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public BGFOBNOIFNP.GHAMIAIOAEP instantiations;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PAGLILLHANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x30378D0", Offset = "0x3036CD0", VA = "0x1830378D0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class DEKNFIAIOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DEKNFIAIOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x3022C60", Offset = "0x3022060", VA = "0x183022C60")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2697E70", Offset = "0x2697270", VA = "0x182697E70")]
	public static void CECDLANABFD(NMCMEOAHLPH OPDADEMFPEM, OHNBOJIMJND PNMIIEJFOON, BGFOBNOIFNP.GHAMIAIOAEP JHLADJLIEID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class KFANHBEOLML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct JLBFHCAPHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public MABCHFGOLAP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public OHNBOJIMJND deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x323EC60", Offset = "0x323E060", VA = "0x18323EC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class IGMCMBBCMKO
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
			public IGMCMBBCMKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x46D7E70", Offset = "0x46D7270", VA = "0x1846D7E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IKIBJCADMMP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IGMCMBBCMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x323D840", Offset = "0x323CC40", VA = "0x18323D840")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct KCLEOEFMMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IGMCMBBCMKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x323FB10", Offset = "0x323EF10", VA = "0x18323FB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct PDDGFMMHPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private Dictionary<Guid, List<NKOHEODHLDH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x3245B20", Offset = "0x3244F20", VA = "0x183245B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct MDECGDHFOMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public IKIBJCADMMP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private IKIBJCADMMP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private Dictionary<Guid, List<NKOHEODHLDH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x3242740", Offset = "0x3241B40", VA = "0x183242740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class EKLNFKINKPG
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
			public NKOHEODHLDH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public EKLNFKINKPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x46D5790", Offset = "0x46D4B90", VA = "0x1846D5790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public ABOPFBCGKOF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public List<NKOHEODHLDH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EKLNFKINKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3238D10", Offset = "0x3238110", VA = "0x183238D10")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3238EF0", Offset = "0x32382F0", VA = "0x183238EF0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(NKOHEODHLDH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3238E00", Offset = "0x3238200", VA = "0x183238E00")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct NOKPDEIPPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public ABOPFBCGKOF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public List<NKOHEODHLDH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private EKLNFKINKPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x32446B0", Offset = "0x3243AB0", VA = "0x1832446B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct MEFPPOKBHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public IKIBJCADMMP timer;

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
		[Cpp2IlInjected.Address(RVA = "0x3242D60", Offset = "0x3242160", VA = "0x183242D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class PFNLDEJLKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PFNLDEJLKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x3246580", Offset = "0x3245980", VA = "0x183246580")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct BFOPNLOJGIH : IAsyncStateMachine
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
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public OHNBOJIMJND data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x3234F30", Offset = "0x3234330", VA = "0x183234F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class BFLIHOOJEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BFLIHOOJEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x3234EC0", Offset = "0x32342C0", VA = "0x183234EC0")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct NHHJFOPNAAJ : IAsyncStateMachine
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
		public KFANHBEOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x32432C0", Offset = "0x32426C0", VA = "0x1832432C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class HLBCHLEONBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HLBCHLEONBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x323C8A0", Offset = "0x323BCA0", VA = "0x18323C8A0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly NPDJBKPIGJG NGBLBNOIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private POKCBINAHLP FOILFDKNEGO;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private NMCMEOAHLPH MLGDDCAPKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA60", Offset = "0x7CCE60", VA = "0x1807CDA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public KFANHBEOLML(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x26B0550", Offset = "0x26AF950", VA = "0x1826B0550")]
	[AsyncStateMachine(typeof(JLBFHCAPHBG))]
	public Task CECDLANABFD(MABCHFGOLAP LPNAIGMHGJO, OHNBOJIMJND BLOAKGIDFJE, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x26B1060", Offset = "0x26B0460", VA = "0x1826B1060")]
	[AsyncStateMachine(typeof(KCLEOEFMMKB))]
	private Task MBAKIBLEICA(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x26B0220", Offset = "0x26AF620", VA = "0x1826B0220")]
	[AsyncStateMachine(typeof(PDDGFMMHPHE))]
	private Task AHNJLGIFNJE(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x26B0800", Offset = "0x26AFC00", VA = "0x1826B0800")]
	[AsyncStateMachine(typeof(MDECGDHFOMH))]
	private Task HFDLOCGMFJL(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x26B0AA0", Offset = "0x26AFEA0", VA = "0x1826B0AA0")]
	[AsyncStateMachine(typeof(NOKPDEIPPKD))]
	private Task HNBKLGMFEIM(Guid OODMKOOFNNH, List<NKOHEODHLDH> DDEJMLLFJDD, ABOPFBCGKOF JOPOMGGKFKF, OHNBOJIMJND PNMIIEJFOON, CancellationToken MJNGPHMPILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x26B11C0", Offset = "0x26B05C0", VA = "0x1826B11C0")]
	[AsyncStateMachine(typeof(MEFPPOKBHIF))]
	private Task OIPHLBFKFOE(OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x26B0960", Offset = "0x26AFD60", VA = "0x1826B0960")]
	[AsyncStateMachine(typeof(BFOPNLOJGIH))]
	private Task HIGALNBJFAJ(Guid AHAIHBMOEBB, OHNBOJIMJND PNMIIEJFOON, IKIBJCADMMP ANOJNPAHJKB, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x26B06B0", Offset = "0x26AFAB0", VA = "0x1826B06B0")]
	[AsyncStateMachine(typeof(NHHJFOPNAAJ))]
	private Task FJMHEDLOCEI(Guid AHAIHBMOEBB, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x26B0BE0", Offset = "0x26AFFE0", VA = "0x1826B0BE0")]
	private void IJNBFJAJFII(Guid AHAIHBMOEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x26B0F40", Offset = "0x26B0340", VA = "0x1826B0F40")]
	private void JEHEAJNLEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x26B0380", Offset = "0x26AF780", VA = "0x1826B0380")]
	public Guid AJMKKGCCOPI(MABCHFGOLAP NBBOGIJMFOO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x26B0D70", Offset = "0x26B0170", VA = "0x1826B0D70")]
	[CompilerGenerated]
	private object IMCMGEBONHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
public readonly struct KEGHMBLLMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	[CanBeNull]
	public readonly BLKLDFBMGPO CBJKBFFHEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	[NotNull]
	public readonly CNAEEODIDMM ILDAEKGCGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	[CanBeNull]
	public readonly string GLLNOCIAFDG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyCollection<string> MEBHKDPHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x26B0100", Offset = "0x26AF500", VA = "0x1826B0100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyDictionary<long, int> PPKJLNEFOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x26B00E0", Offset = "0x26AF4E0", VA = "0x1826B00E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x26B0120", Offset = "0x26AF520", VA = "0x1826B0120")]
	public KEGHMBLLMCM([CanBeNull] BLKLDFBMGPO EFAPNGJIOOF, [NotNull] CNAEEODIDMM KEELLAPMENM, [CanBeNull] string OJHPMMBEEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class NOPHMKEBNNO : LBLFAMFCEMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct MDPCANKKLBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder<KEGHMBLLMCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public NOPHMKEBNNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public HIJAJEKEJIL serializeType;

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
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x46D40E0", Offset = "0x46D34E0", VA = "0x1846D40E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x46D45B0", Offset = "0x46D39B0", VA = "0x1846D45B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class HMBKBEABCMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public HIJAJEKEJIL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HMBKBEABCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x46D0780", Offset = "0x46CFB80", VA = "0x1846D0780")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class EONNLOEMJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public HMBKBEABCMN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EONNLOEMJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x46CCB20", Offset = "0x46CBF20", VA = "0x1846CCB20")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class ENDEFMHCGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public HMBKBEABCMN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ENDEFMHCGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x46CCAE0", Offset = "0x46CBEE0", VA = "0x1846CCAE0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct ILPIJKFEDGD : IAsyncStateMachine
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
		public HIJAJEKEJIL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public NOPHMKEBNNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private EONNLOEMJGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private MEODHCGMDDL.LBPIDDBMDIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x46D10A0", Offset = "0x46D04A0", VA = "0x1846D10A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly IECEHJHNOCE AGHIOHHDKJB;

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly TimeSpan JLMOFJKLCGD;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x302F140", Offset = "0x302E540", VA = "0x18302F140")]
	public NOPHMKEBNNO(NPDJBKPIGJG NGBLBNOIPKA, [Optional] IECEHJHNOCE? AGHIOHHDKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x302E0A0", Offset = "0x302D4A0", VA = "0x18302E0A0")]
	[AsyncStateMachine(typeof(MDPCANKKLBC))]
	public Task<KEGHMBLLMCM> FBLBIDAIACI(long LBIOPPABCMJ, string OJHPMMBEEBE, HIJAJEKEJIL LPOOJCLNGFL, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x302E220", Offset = "0x302D620", VA = "0x18302E220")]
	[AsyncStateMachine(typeof(ILPIJKFEDGD))]
	private Task GHBHPABKPDM(HIJAJEKEJIL LPOOJCLNGFL, IEnumerable<PersistenceView> JJBKPOJOCCN, StringBuilder CDDOHOOPKMO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x302E890", Offset = "0x302DC90", VA = "0x18302E890")]
	private KEGHMBLLMCM IOMMDAFOKCA(long LBIOPPABCMJ, string OJHPMMBEEBE, HIJAJEKEJIL LPOOJCLNGFL, IEnumerable<PersistenceView> JJBKPOJOCCN, StringBuilder CDDOHOOPKMO)
	{
		return default(KEGHMBLLMCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x302ED40", Offset = "0x302E140", VA = "0x18302ED40")]
	private BLKLDFBMGPO KBMAOJFLOPC(long LBIOPPABCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x302EEB0", Offset = "0x302E2B0", VA = "0x18302EEB0")]
	private void KDOBIPGECNA(BLKLDFBMGPO HBAOAKAIFAG, StringBuilder CDDOHOOPKMO, IEnumerable<PersistenceView> JJBKPOJOCCN, in LBBAFPIBHHO IJBJEBDOLMK, ref OAPBKONKIMK NACIEOCNAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x302E380", Offset = "0x302D780", VA = "0x18302E380")]
	private void IHECLMJOMFB(BLKLDFBMGPO HBAOAKAIFAG, StringBuilder CDDOHOOPKMO, PersistenceView ANICJOOMAKF, ref OAPBKONKIMK NACIEOCNAFE, in LBBAFPIBHHO IJBJEBDOLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class LLFKODGPJMJ : LBLFAMFCEMA
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class NIGHBNBJOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public IJECPJOJAHC.DDEDHFMIFJK roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public IJECPJOJAHC.DDEDHFMIFJK subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NIGHBNBJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x3244320", Offset = "0x3243720", VA = "0x183244320")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x32443B0", Offset = "0x32437B0", VA = "0x1832443B0")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x3244400", Offset = "0x3243800", VA = "0x183244400")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x3244470", Offset = "0x3243870", VA = "0x183244470")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct NIDPHPHAGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<(IJECPJOJAHC.DDEDHFMIFJK roomDataUpload, IJECPJOJAHC.DDEDHFMIFJK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public KEGHMBLLMCM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public LLFKODGPJMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private NIGHBNBJOBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private TaskAwaiter<IJECPJOJAHC.DDEDHFMIFJK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3243820", Offset = "0x3242C20", VA = "0x183243820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x32442D0", Offset = "0x32436D0", VA = "0x1832442D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct DAPBHHENGGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder<CONFMKJIMDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public LLFKODGPJMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public KEGHMBLLMCM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public JNDNCHHADEN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter<(IJECPJOJAHC.DDEDHFMIFJK roomDataUpload, IJECPJOJAHC.DDEDHFMIFJK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private TaskAwaiter<CONFMKJIMDP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x3237540", Offset = "0x3236940", VA = "0x183237540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3237940", Offset = "0x3236D40", VA = "0x183237940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LIJDMKFJECK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<ABAALCOFOBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public LLFKODGPJMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public KEGHMBLLMCM roomSerializedData;

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
		private TaskAwaiter<(IJECPJOJAHC.DDEDHFMIFJK roomDataUpload, IJECPJOJAHC.DDEDHFMIFJK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter<ABAALCOFOBC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x3241590", Offset = "0x3240990", VA = "0x183241590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x3241920", Offset = "0x3240D20", VA = "0x183241920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class PCFPHDENBAO
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
			public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public PCFPHDENBAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			private MFNPLLGOGAD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			private TaskAwaiter<ABAALCOFOBC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<CONFMKJIMDP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private TaskAwaiter<MFNPLLGOGAD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x46D8350", Offset = "0x46D7750", VA = "0x1846D8350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x46D8F30", Offset = "0x46D8330", VA = "0x1846D8F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public LLFKODGPJMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public KEGHMBLLMCM roomSerializedData;

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
		public JNDNCHHADEN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PCFPHDENBAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x32459E0", Offset = "0x3244DE0", VA = "0x1832459E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MFNPLLGOGAD> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct IAMMGPLCABA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AsyncTaskMethodBuilder<MFNPLLGOGAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public LLFKODGPJMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public KEGHMBLLMCM roomSerializedData;

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
		public JNDNCHHADEN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private TaskAwaiter<MFNPLLGOGAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x323CCF0", Offset = "0x323C0F0", VA = "0x18323CCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x323CFA0", Offset = "0x323C3A0", VA = "0x18323CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private const float GPFLLMFEJEI = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private readonly JEIJJCBFPCC GDAPNDBNHIO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CFOGACNBCBD BLCLMCFGGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x26B46A0", Offset = "0x26B3AA0", VA = "0x1826B46A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x26B49D0", Offset = "0x26B3DD0", VA = "0x1826B49D0")]
	public LLFKODGPJMJ(NPDJBKPIGJG NGBLBNOIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x26B46D0", Offset = "0x26B3AD0", VA = "0x1826B46D0")]
	[AsyncStateMachine(typeof(NIDPHPHAGEH))]
	private Task<(IJECPJOJAHC.DDEDHFMIFJK, IJECPJOJAHC.DDEDHFMIFJK)> HEDEEJLHCOH(KEGHMBLLMCM ALMGFMEBNFC, long DDEPFHBCOHC, long BGHKIEHCOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x26B4510", Offset = "0x26B3910", VA = "0x1826B4510")]
	[AsyncStateMachine(typeof(DAPBHHENGGB))]
	public Task<CONFMKJIMDP> CFFKCADJMLF(int KECIOLCNGHC, [CanBeNull] JNDNCHHADEN DLOFILGCNNC, KEGHMBLLMCM ALMGFMEBNFC, long DDEPFHBCOHC, long BGHKIEHCOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x26B4840", Offset = "0x26B3C40", VA = "0x1826B4840")]
	[AsyncStateMachine(typeof(LIJDMKFJECK))]
	private Task<ABAALCOFOBC> LIGMPAMABAJ(string IEAFHNALNCG, int KECIOLCNGHC, KEGHMBLLMCM ALMGFMEBNFC, long DDEPFHBCOHC, long BGHKIEHCOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x26B4360", Offset = "0x26B3760", VA = "0x1826B4360")]
	[AsyncStateMachine(typeof(IAMMGPLCABA))]
	public Task<MFNPLLGOGAD> CBENOHJMFJP(int KECIOLCNGHC, [CanBeNull] JNDNCHHADEN DLOFILGCNNC, KEGHMBLLMCM ALMGFMEBNFC, long DDEPFHBCOHC, long BGHKIEHCOCI, IKIBJCADMMP LNACOMDLNOJ, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public abstract class ODDKLECMIJF<T> where T : global::ODDKLECMIJF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	internal readonly CFOGACNBCBD OBNEFONBJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private int? AILDMMPCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	protected readonly Guid MAIJDDOJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	protected readonly OHOONLDMNHG JBPDNAABLMI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T FBCJJAJAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A4CDC0", Offset = "0x3A4C1C0", VA = "0x183A4CDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CE20", Offset = "0x3A4C220", VA = "0x183A4CE20")]
	internal ODDKLECMIJF(CFOGACNBCBD APIEEOGJDJL, OHOONLDMNHG FBBJHIOPJFI, [Optional] Guid? MOLEKIELIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CC60", Offset = "0x3A4C060", VA = "0x183A4CC60")]
	private MFNPLLGOGAD HIEJJPPEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	protected virtual void FBMNJCGEBHN(MFNPLLGOGAD KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CAD0", Offset = "0x3A4BED0", VA = "0x183A4CAD0")]
	public T CDKBKIKMNKM(GLJCDOAILMB BKCMLHPPECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CD40", Offset = "0x3A4C140", VA = "0x183A4CD40")]
	public T JFAEIMDKMPA(int KNHPGEMGFHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CB60", Offset = "0x3A4BF60", VA = "0x183A4CB60", Slot = "5")]
	public virtual Task<CJAGNKGLNKE> GPKDAKFKCKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class HLLHHPPDABG : global::ODDKLECMIJF<HLLHHPPDABG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private NGANIFEBMGB NEIPJLDAIJA;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x26A8150", Offset = "0x26A7550", VA = "0x1826A8150")]
	internal HLLHHPPDABG(CFOGACNBCBD APIEEOGJDJL, OHOONLDMNHG FBBJHIOPJFI, [Optional] Guid? MOLEKIELIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x26A8130", Offset = "0x26A7530", VA = "0x1826A8130")]
	public HLLHHPPDABG PGJPCPBGNBN(NGANIFEBMGB NEIPJLDAIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x26A8070", Offset = "0x26A7470", VA = "0x1826A8070", Slot = "4")]
	protected override void FBMNJCGEBHN(MFNPLLGOGAD KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class AEGIABKBBOD : global::ODDKLECMIJF<AEGIABKBBOD>
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	internal enum HIELGDBGMIC
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
	private struct EKNPFHPABHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<CJAGNKGLNKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AEGIABKBBOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<CJAGNKGLNKE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3023A90", Offset = "0x3022E90", VA = "0x183023A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x3023DD0", Offset = "0x30231D0", VA = "0x183023DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private HIELGDBGMIC PGNKHAGCEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private string AGDKPICDJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private JNDNCHHADEN NEIPJLDAIJA;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x2696900", Offset = "0x2695D00", VA = "0x182696900")]
	internal AEGIABKBBOD(CFOGACNBCBD APIEEOGJDJL, OHOONLDMNHG FBBJHIOPJFI, [Optional] Guid? MOLEKIELIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2696580", Offset = "0x2695980", VA = "0x182696580")]
	public AEGIABKBBOD ABKGFFPBICA(string FILMPDJDFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2696760", Offset = "0x2695B60", VA = "0x182696760")]
	public AEGIABKBBOD FKDKGHMBHLM(bool GPLIMBGHDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2696780", Offset = "0x2695B80", VA = "0x182696780")]
	public AEGIABKBBOD FLAFILPLDBH(string GKBEAKNFHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x26968D0", Offset = "0x2695CD0", VA = "0x1826968D0")]
	public AEGIABKBBOD OHNHNBMDFDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x26965F0", Offset = "0x26959F0", VA = "0x1826965F0", Slot = "4")]
	protected override void FBMNJCGEBHN(MFNPLLGOGAD KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x26967B0", Offset = "0x2695BB0", VA = "0x1826967B0", Slot = "5")]
	[AsyncStateMachine(typeof(EKNPFHPABHO))]
	public override Task<CJAGNKGLNKE> GPKDAKFKCKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x26965B0", Offset = "0x26959B0", VA = "0x1826965B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<CJAGNKGLNKE> DKIOHCIAJBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal static class GNIHPHEKHHC
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A6FF0", Offset = "0x26A63F0", VA = "0x1826A6FF0")]
	public static void OFIJPIFHOEH(this HDKAGFAIENG FCJDCHEIIBM, LBBLCNAMBKL BHKDKHCKFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F10", Offset = "0x26A6310", VA = "0x1826A6F10")]
	public static void ECFCBINFKKN(this LBBLCNAMBKL PINGFGAGGMP, [Optional] string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public static class DJCONJJDKDF
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2699E70", Offset = "0x2699270", VA = "0x182699E70")]
	public static NHJHNDPNKHC KNHHJLEJBJG(this GFBPABDGPKK LIBCCFIBPDP)
	{
		return default(NHJHNDPNKHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2699DB0", Offset = "0x26991B0", VA = "0x182699DB0")]
	public static GFBPABDGPKK DAJCJMCMFBO(this NHJHNDPNKHC BELODHAHDCG)
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
			public FHIHJKLJCEC ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public FHIHJKLJCEC HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private static FHIHJKLJCEC[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private Dictionary<FHIHJKLJCEC, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3039050", Offset = "0x3038450", VA = "0x183039050")]
		public bool BJJLBKMHDJH(FHIHJKLJCEC LKPIEEBBCJG, out ResultConfig FBPEKKHBHEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x30390C0", Offset = "0x30384C0", VA = "0x1830390C0")]
		public ResultConfig KPPLNFPPGFH(FHIHJKLJCEC AAMNHHPLJGD, [Optional] HashSet<FHIHJKLJCEC> NHOLCBIACDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3039760", Offset = "0x3038B60", VA = "0x183039760", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x30391E0", Offset = "0x30385E0", VA = "0x1830391E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0990", VA = "0x180EE1590")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class EMLPAEIODMB
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x269C5B0", Offset = "0x269B9B0", VA = "0x18269C5B0")]
	[PCIIMDKJBPO(GGLAACLIDJL.GameOnly)]
	private static void DLEDFLHHMLJ(MMBGCEPKKOC PBLOBOBPNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public interface LMBGJPBKLNM : IEquatable<LMBGJPBKLNM>
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime ENKNKALAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIKPIDELDAD();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NCHPPAJPDBN(long DDEPFHBCOHC, long LBIOPPABCMJ, out KEGHMBLLMCM ALMGFMEBNFC);
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal class DLJBKHGKFAK : COLFLIDOIPP
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class NDPCBPLFIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AEDHGGAECKF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NDPCBPLFIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x302CBC0", Offset = "0x302BFC0", VA = "0x18302CBC0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly NCFOLLEHLMD KPANOPEFKAK;

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private const int PLMLABEODHE = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<LMBGJPBKLNM> AHFFALCGLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x269ABD0", Offset = "0x2699FD0", VA = "0x18269ABD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x269AB30", Offset = "0x2699F30", VA = "0x18269AB30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	[Preserve]
	public DLJBKHGKFAK([IMNCNOGBAJI(null)] NCFOLLEHLMD KPANOPEFKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x269AC70", Offset = "0x269A070", VA = "0x18269AC70", Slot = "6")]
	public bool LPJJINDLEOF(long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC, AEDHGGAECKF BFONPHLGOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x269A6A0", Offset = "0x2699AA0", VA = "0x18269A6A0")]
	private void BAAKKFLLEFM(LMBGJPBKLNM MGLNAHCNMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x269B190", Offset = "0x269A590", VA = "0x18269B190", Slot = "7")]
	public bool PPGBLMOIDCL(long DDEPFHBCOHC, long LBIOPPABCMJ, out LMBGJPBKLNM HHCPLMDOPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x269AFC0", Offset = "0x269A3C0", VA = "0x18269AFC0", Slot = "8")]
	public bool MNLKJDGOGDP(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, out LMBGJPBKLNM HHCPLMDOPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x269A740", Offset = "0x2699B40", VA = "0x18269A740")]
	private void EDOGPAHAGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x269B070", Offset = "0x269A470", VA = "0x18269B070", Slot = "9")]
	public void POCBBBHKEMP(long DDEPFHBCOHC, long LBIOPPABCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal abstract class GFCMJLIOGLI : NCFOLLEHLMD
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	protected enum OCCJFAPLCHK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class FKGDNNODBFD : IEnumerable<LMBGJPBKLNM>, IEnumerable, IEnumerator<LMBGJPBKLNM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private LMBGJPBKLNM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public GFCMJLIOGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private AEDHGGAECKF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public AEDHGGAECKF <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private LMBGJPBKLNM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public FKGDNNODBFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x30243D0", Offset = "0x30237D0", VA = "0x1830243D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x30246A0", Offset = "0x3023AA0", VA = "0x1830246A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x30245F0", Offset = "0x30239F0", VA = "0x1830245F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMBGJPBKLNM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x30245F0", Offset = "0x30239F0", VA = "0x1830245F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class IKEHLAEDDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AEDHGGAECKF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IKEHLAEDDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x3028AD0", Offset = "0x3027ED0", VA = "0x183028AD0")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class GPODNLKFKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public GFCMJLIOGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GPODNLKFKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x30265B0", Offset = "0x30259B0", VA = "0x1830265B0")]
		internal void <TryReadAutosaveFile>b__0(POOEDLPNPHK.PJCFPDLAAAH ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	protected readonly string BMAJLEEDMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly object EBLBFNHIANJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x26A5720", Offset = "0x26A4B20", VA = "0x1826A5720")]
	protected GFCMJLIOGLI([CanBeNull] string IDMLKAJNNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x26A5570", Offset = "0x26A4970", VA = "0x1826A5570", Slot = "5")]
	public bool MPKNHOHLIJA(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, out LMBGJPBKLNM MGLNAHCNMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x26A4F10", Offset = "0x26A4310", VA = "0x1826A4F10", Slot = "6")]
	[IteratorStateMachine(typeof(FKGDNNODBFD))]
	public IEnumerable<LMBGJPBKLNM> FEENMAEBJMA(AEDHGGAECKF BFONPHLGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void KCGAEENDEOF(Stream NEACOIPFDMB, long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FNBOBBDHJDI(Stream OBOEPJBKHFD, long DDEPFHBCOHC, long LBIOPPABCMJ, NAIGGJANGPC EMDLLNJBOLF, out KEGHMBLLMCM ALMGFMEBNFC);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x26A4F90", Offset = "0x26A4390", VA = "0x1826A4F90", Slot = "7")]
	public LMBGJPBKLNM FMOLHMHAAAD(long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC, AEDHGGAECKF BFONPHLGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo JCDGMPFNNNH(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo AGECIEJGNGL(AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x26A4EA0", Offset = "0x26A42A0", VA = "0x1826A4EA0")]
	protected void CBEJIJIMDBK(POOEDLPNPHK.PJCFPDLAAAH OGHGGMJOOFK, string ICBCECIENAJ, FileInfo DNJACPJDGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x26A52C0", Offset = "0x26A46C0", VA = "0x1826A52C0")]
	internal bool JFFHAOKGJCM(FileInfo ILMEFLLEJKO, long DDEPFHBCOHC, long LBIOPPABCMJ, out KEGHMBLLMCM ALMGFMEBNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private void KLBINFDBBEC(Exception GHBHEEBHPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class ONAFGHPMEFP : GFCMJLIOGLI
{
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private const string HJOKEHGGMOL = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private const string LLGKPMAOPLN = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private const string ACJGAMMGGCC = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x1034DB0", Offset = "0x10341B0", VA = "0x181034DB0", Slot = "8")]
		get
		{
			return default(EGKMOCBNHJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x3037890", Offset = "0x3036C90", VA = "0x183037890")]
	public ONAFGHPMEFP([Optional] string IDMLKAJNNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x3037810", Offset = "0x3036C10", VA = "0x183037810")]
	private void KOMNBOLENDG(AEDHGGAECKF BFONPHLGOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x3037600", Offset = "0x3036A00", VA = "0x183037600", Slot = "9")]
	internal override void KCGAEENDEOF(Stream NEACOIPFDMB, long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x30370A0", Offset = "0x30364A0", VA = "0x1830370A0", Slot = "10")]
	internal override bool FNBOBBDHJDI(Stream OBOEPJBKHFD, long DDEPFHBCOHC, long LBIOPPABCMJ, NAIGGJANGPC EMDLLNJBOLF, out KEGHMBLLMCM ALMGFMEBNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x3037510", Offset = "0x3036910", VA = "0x183037510", Slot = "11")]
	protected override FileInfo JCDGMPFNNNH(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x3036F90", Offset = "0x3036390", VA = "0x183036F90", Slot = "12")]
	protected override DirectoryInfo AGECIEJGNGL(AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal sealed class FLCBFFAGAEM : GFCMJLIOGLI
{
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private static readonly byte[] FOJIGKKHICE;

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private const string LLGKPMAOPLN = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private const string ACJGAMMGGCC = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private const string CEFCHPPGHDN = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly byte[] BHCIOOANFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly byte[] MKABHOPJHNP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x732020", Offset = "0x731420", VA = "0x180732020", Slot = "8")]
		get
		{
			return default(EGKMOCBNHJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x26A4060", Offset = "0x26A3460", VA = "0x1826A4060")]
	public FLCBFFAGAEM([Optional] string IDMLKAJNNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x26A3C30", Offset = "0x26A3030", VA = "0x1826A3C30", Slot = "9")]
	internal override void KCGAEENDEOF(Stream NEACOIPFDMB, long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x26A3280", Offset = "0x26A2680", VA = "0x1826A3280", Slot = "10")]
	internal override bool FNBOBBDHJDI(Stream OBOEPJBKHFD, long DDEPFHBCOHC, long LBIOPPABCMJ, NAIGGJANGPC EMDLLNJBOLF, out KEGHMBLLMCM ALMGFMEBNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x26A3ED0", Offset = "0x26A32D0", VA = "0x1826A3ED0")]
	private void PEDDLCNNNBI(byte[] EEMDNKKFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x26A3B00", Offset = "0x26A2F00", VA = "0x1826A3B00", Slot = "11")]
	protected override FileInfo JCDGMPFNNNH(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x26A3160", Offset = "0x26A2560", VA = "0x1826A3160", Slot = "12")]
	protected override DirectoryInfo AGECIEJGNGL(AEDHGGAECKF BFONPHLGOFF, OCCJFAPLCHK BBJEOKFMKJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public enum EGKMOCBNHJN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal class NLKCMICPHGA : NCFOLLEHLMD
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class CBJPAMHOEMN : IEnumerable<LMBGJPBKLNM>, IEnumerable, IEnumerator<LMBGJPBKLNM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private LMBGJPBKLNM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public NLKCMICPHGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private AEDHGGAECKF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public AEDHGGAECKF <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private EGKMOCBNHJN[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerator<LMBGJPBKLNM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private LMBGJPBKLNM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public CBJPAMHOEMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3235980", Offset = "0x3234D80", VA = "0x183235980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x32355B0", Offset = "0x32349B0", VA = "0x1832355B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x3235A10", Offset = "0x3234E10", VA = "0x183235A10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x3235940", Offset = "0x3234D40", VA = "0x183235940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x3235890", Offset = "0x3234C90", VA = "0x183235890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMBGJPBKLNM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x3235890", Offset = "0x3234C90", VA = "0x183235890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly EGKMOCBNHJN[] AJOLDGGMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly Dictionary<EGKMOCBNHJN, NCFOLLEHLMD> AHNIFDBICKH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x302CC30", Offset = "0x302C030", VA = "0x18302CC30", Slot = "4")]
		get
		{
			return default(EGKMOCBNHJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x302D1E0", Offset = "0x302C5E0", VA = "0x18302D1E0")]
	[Preserve]
	public NLKCMICPHGA(params NCFOLLEHLMD[] KDKDHCFFCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x302CE50", Offset = "0x302C250", VA = "0x18302CE50", Slot = "5")]
	public bool MPKNHOHLIJA(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, out LMBGJPBKLNM MGLNAHCNMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x302CFB0", Offset = "0x302C3B0", VA = "0x18302CFB0")]
	private void POHAIMEGPHD(int IPFAKLGFGLH, long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x302CC70", Offset = "0x302C070", VA = "0x18302CC70", Slot = "6")]
	[IteratorStateMachine(typeof(CBJPAMHOEMN))]
	public IEnumerable<LMBGJPBKLNM> FEENMAEBJMA(AEDHGGAECKF BFONPHLGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x302CCF0", Offset = "0x302C0F0", VA = "0x18302CCF0", Slot = "7")]
	public LMBGJPBKLNM FMOLHMHAAAD(long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC, AEDHGGAECKF BFONPHLGOFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal static class FEGAFFKBKHA
{
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	internal const int MAJKDMDPIAD = 32;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x269CC40", Offset = "0x269C040", VA = "0x18269CC40")]
	internal static byte[] PPHLDGLNBMK(byte[] EEMDNKKFCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x269CBC0", Offset = "0x269BFC0", VA = "0x18269CBC0")]
	public static void JMNEFKAEIMN(Stream DJGPEPEBOGE, byte[] OEPEMPAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x269C9E0", Offset = "0x269BDE0", VA = "0x18269C9E0")]
	public static bool BMKAJGNFJAB(Stream DJGPEPEBOGE, long FFIIFMNGPME, NAIGGJANGPC LBCLOJAFMCG, out byte[] ENOFBJHMAMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal sealed class OCAKFEPOHKP : LMBGJPBKLNM, IEquatable<LMBGJPBKLNM>, IEquatable<OCAKFEPOHKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private readonly GFCMJLIOGLI AGGBIDLHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public readonly FileInfo MLMIFBGDAKN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA08640", VA = "0x180A09240", Slot = "4")]
		get
		{
			return default(EGKMOCBNHJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime ENKNKALAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x3033C70", Offset = "0x3033070", VA = "0x183033C70", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x30341F0", Offset = "0x30335F0", VA = "0x1830341F0")]
	public OCAKFEPOHKP(GFCMJLIOGLI HOBAENJMFOE, FileInfo ILMEFLLEJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3034140", Offset = "0x3033540", VA = "0x183034140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3034040", Offset = "0x3033440", VA = "0x183034040", Slot = "6")]
	public void KIKPIDELDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x3034100", Offset = "0x3033500", VA = "0x183034100", Slot = "7")]
	public bool NCHPPAJPDBN(long DDEPFHBCOHC, long LBIOPPABCMJ, out KEGHMBLLMCM ALMGFMEBNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3033DC0", Offset = "0x30331C0", VA = "0x183033DC0", Slot = "8")]
	public bool Equals(LMBGJPBKLNM EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x3033D10", Offset = "0x3033110", VA = "0x183033D10", Slot = "9")]
	public bool Equals(OCAKFEPOHKP EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3033EA0", Offset = "0x30332A0", VA = "0x183033EA0", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x3033FA0", Offset = "0x30333A0", VA = "0x183033FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x1FE40F0", Offset = "0x1FE34F0", VA = "0x181FE40F0")]
	public static bool LPAHFDMKICD(OCAKFEPOHKP HOHNFHDFLIK, OCAKFEPOHKP IBLJPHDNENC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3BC0", Offset = "0x1FE2FC0", VA = "0x181FE3BC0")]
	public static bool AFMDFHOMNJI(OCAKFEPOHKP HOHNFHDFLIK, OCAKFEPOHKP IBLJPHDNENC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public delegate void NAIGGJANGPC(POOEDLPNPHK.PJCFPDLAAAH NJBMDLEPAFI, string KAKCNEMJMJL);
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal interface NCFOLLEHLMD
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	EGKMOCBNHJN JMIPNNHCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPKNHOHLIJA(long DDEPFHBCOHC, long LBIOPPABCMJ, AEDHGGAECKF BFONPHLGOFF, out LMBGJPBKLNM MGLNAHCNMBL);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LMBGJPBKLNM> FEENMAEBJMA(AEDHGGAECKF BFONPHLGOFF);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMBGJPBKLNM FMOLHMHAAAD(long DDEPFHBCOHC, long LBIOPPABCMJ, KEGHMBLLMCM ALMGFMEBNFC, AEDHGGAECKF BFONPHLGOFF);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x26B7580", Offset = "0x26B6980", VA = "0x1826B7580")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x26B7690", Offset = "0x26B6A90", VA = "0x1826B7690")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
