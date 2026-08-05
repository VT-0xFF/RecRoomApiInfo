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
public class LLBLEIMEKMN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2BA94A0", Offset = "0x2BA82A0", VA = "0x182BA94A0")]
	public LLBLEIMEKMN(string HDKJDEIGPPL, Exception AMBDHCPDPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class FFBAMHEHDLF : KEOHPKPMANC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct JGBELHDHIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GMIHJEAEDBM>> <>t__builder;

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
		private TaskAwaiter<global::OFNNIEMLIIH<GMIHJEAEDBM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35EB4F0", Offset = "0x35EA2F0", VA = "0x1835EB4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35EB6D0", Offset = "0x35EA4D0", VA = "0x1835EB6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct DMMKLHMELOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NBNLPEKLFLE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<NBNLPEKLFLE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x35E5180", Offset = "0x35E3F80", VA = "0x1835E5180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35E5340", Offset = "0x35E4140", VA = "0x1835E5340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	[Preserve]
	public FFBAMHEHDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BB60", Offset = "0x2B9A960", VA = "0x182B9BB60", Slot = "4")]
	[AsyncStateMachine(typeof(JGBELHDHIFI))]
	public Task<IReadOnlyList<GMIHJEAEDBM>> DBFEMDCBPPG(long HMOGFNMOLJM, long NMFONIKGFJA, [Optional] CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BCB0", Offset = "0x2B9AAB0", VA = "0x182B9BCB0", Slot = "5")]
	[AsyncStateMachine(typeof(DMMKLHMELOO))]
	public Task<IReadOnlyList<NBNLPEKLFLE>> MNMCNEFBCJB(IReadOnlyList<int> MOHDMOKBJPG, [Optional] CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JFJMPPONANH : IEquatable<JFJMPPONANH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int ICIPEHAAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NBNLPEKLFLE NABOGCAAGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KAOEHNLBOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AAFDDHKKBIO? MKLIHIBALMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BENEFAKGBPE? FLOPAHLNPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	LOILHFMDJDM FBBAGMLENGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EDADMNIFEBK> INKOHOGOFEN();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LOILHFMDJDM
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KEOHPKPMANC
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GMIHJEAEDBM>> DBFEMDCBPPG(long HMOGFNMOLJM, long NMFONIKGFJA, [Optional] CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<NBNLPEKLFLE>> MNMCNEFBCJB(IReadOnlyList<int> MOHDMOKBJPG, [Optional] CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PHKIJNAMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class HFNOLJKJLDE : JFJMPPONANH, IEquatable<JFJMPPONANH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct ANKEFOPBLDH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HFNOLJKJLDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private GEACCIIFOMJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<EKLMJEDNPMN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<EDADMNIFEBK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x40E4960", Offset = "0x40E3760", VA = "0x1840E4960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x40E4DF0", Offset = "0x40E3BF0", VA = "0x1840E4DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly GMIHJEAEDBM ADNDNMHJKMP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ICIPEHAAJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NBNLPEKLFLE NABOGCAAGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AAAFOCMEGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15E5570", Offset = "0x15E4370", VA = "0x1815E5570", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AAFDDHKKBIO? MKLIHIBALMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB83E10", Offset = "0xB82C10", VA = "0x180B83E10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BENEFAKGBPE? FLOPAHLNPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB83DD0", Offset = "0xB82BD0", VA = "0x180B83DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LOILHFMDJDM FBBAGMLENGG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x74DCF0", Offset = "0x74CAF0", VA = "0x18074DCF0", Slot = "10")]
			get
			{
				return default(LOILHFMDJDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x40E89E0", Offset = "0x40E77E0", VA = "0x1840E89E0", Slot = "9")]
		[AsyncStateMachine(typeof(ANKEFOPBLDH))]
		public Task<EDADMNIFEBK> INKOHOGOFEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x40E8B10", Offset = "0x40E7910", VA = "0x1840E8B10")]
		public HFNOLJKJLDE(int GKJLNDDFADH, NBNLPEKLFLE FLPKEILGOBG, GMIHJEAEDBM ADNDNMHJKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40E88C0", Offset = "0x40E76C0", VA = "0x1840E88C0", Slot = "11")]
		public bool Equals(JFJMPPONANH MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40E8820", Offset = "0x40E7620", VA = "0x1840E8820", Slot = "0")]
		public override bool Equals(object KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x40E87E0", Offset = "0x40E75E0", VA = "0x1840E87E0")]
		private bool ACHAPOANOJG(HFNOLJKJLDE MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x40E8950", Offset = "0x40E7750", VA = "0x1840E8950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class NFPEPNKIAHP : JFJMPPONANH, IEquatable<JFJMPPONANH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct HILGLINAFBF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NFPEPNKIAHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<EDADMNIFEBK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x40E8B70", Offset = "0x40E7970", VA = "0x1840E8B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x40E8DB0", Offset = "0x40E7BB0", VA = "0x1840E8DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly GPNEMJHGMNP NEPIEOPKDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly AAFDDHKKBIO CAJPHPOBAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BENEFAKGBPE NBGOHLKEHEN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ICIPEHAAJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40ED570", Offset = "0x40EC370", VA = "0x1840ED570", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NBNLPEKLFLE NABOGCAAGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x40ED5C0", Offset = "0x40EC3C0", VA = "0x1840ED5C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AAAFOCMEGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x40ED840", Offset = "0x40EC640", VA = "0x1840ED840", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AAFDDHKKBIO? MKLIHIBALMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x40ED9B0", Offset = "0x40EC7B0", VA = "0x1840ED9B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BENEFAKGBPE? FLOPAHLNPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x40ED520", Offset = "0x40EC320", VA = "0x1840ED520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LOILHFMDJDM FBBAGMLENGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7425C0", Offset = "0x7413C0", VA = "0x1807425C0", Slot = "10")]
			get
			{
				return default(LOILHFMDJDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C53D0", Offset = "0x8C41D0", VA = "0x1808C53D0")]
		public NFPEPNKIAHP(GPNEMJHGMNP KBKLCBOFMEN, AAFDDHKKBIO HOBBHGJCLMM, BENEFAKGBPE ADIHHLNPKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x40ED890", Offset = "0x40EC690", VA = "0x1840ED890", Slot = "9")]
		[AsyncStateMachine(typeof(HILGLINAFBF))]
		public Task<EDADMNIFEBK> INKOHOGOFEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40ED710", Offset = "0x40EC510", VA = "0x1840ED710", Slot = "11")]
		public bool Equals(JFJMPPONANH MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40ED660", Offset = "0x40EC460", VA = "0x1840ED660", Slot = "0")]
		public override bool Equals(object KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40ED4C0", Offset = "0x40EC2C0", VA = "0x1840ED4C0")]
		private bool ACHAPOANOJG(NFPEPNKIAHP MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40ED7B0", Offset = "0x40EC5B0", VA = "0x1840ED7B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class LDIPADJLKLJ : JFJMPPONANH, IEquatable<JFJMPPONANH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct KAJCAJLKENK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<EDADMNIFEBK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x40EA230", Offset = "0x40E9030", VA = "0x1840EA230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x40EA410", Offset = "0x40E9210", VA = "0x1840EA410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly NBNLPEKLFLE HIABPKCOCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly AAFDDHKKBIO CAJPHPOBAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BENEFAKGBPE NBGOHLKEHEN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int ICIPEHAAJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x40EB770", Offset = "0x40EA570", VA = "0x1840EB770", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public NBNLPEKLFLE NABOGCAAGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AAAFOCMEGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public AAFDDHKKBIO? MKLIHIBALMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x40EBC20", Offset = "0x40EAA20", VA = "0x1840EBC20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BENEFAKGBPE? FLOPAHLNPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x40EB720", Offset = "0x40EA520", VA = "0x1840EB720", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LOILHFMDJDM FBBAGMLENGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "10")]
			get
			{
				return default(LOILHFMDJDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C53D0", Offset = "0x8C41D0", VA = "0x1808C53D0")]
		public LDIPADJLKLJ(NBNLPEKLFLE FLPKEILGOBG, AAFDDHKKBIO HOBBHGJCLMM, BENEFAKGBPE ADIHHLNPKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x40EBB30", Offset = "0x40EA930", VA = "0x1840EBB30", Slot = "9")]
		[AsyncStateMachine(typeof(KAJCAJLKENK))]
		public Task<EDADMNIFEBK> INKOHOGOFEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x40EB7F0", Offset = "0x40EA5F0", VA = "0x1840EB7F0", Slot = "11")]
		public bool Equals(JFJMPPONANH MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x40EB930", Offset = "0x40EA730", VA = "0x1840EB930", Slot = "0")]
		public override bool Equals(object KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x40EBA80", Offset = "0x40EA880", VA = "0x1840EBA80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40EB620", Offset = "0x40EA420", VA = "0x1840EB620")]
		private bool ACHAPOANOJG(LDIPADJLKLJ MCLIMJFDMCF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PACFBKCNPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<JFJMPPONANH>> <>t__builder;

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
		public PHKIJNAMOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<GMIHJEAEDBM> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<GMIHJEAEDBM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, NBNLPEKLFLE account, GMIHJEAEDBM roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40EDBA0", Offset = "0x40EC9A0", VA = "0x1840EDBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x40EE630", Offset = "0x40ED430", VA = "0x1840EE630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AJMJMIOFNLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, NBNLPEKLFLE account, GMIHJEAEDBM roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<GMIHJEAEDBM> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PHKIJNAMOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<NBNLPEKLFLE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x40E3770", Offset = "0x40E2570", VA = "0x1840E3770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x40E40F0", Offset = "0x40E2EF0", VA = "0x1840E40F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CGLFCKPIMDP LAEDFFGDIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KEOHPKPMANC FHPDFNNGOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FCEIAEBAOBA NPPOHPAOKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::HNFMCDMACCI<(long, long), IReadOnlyList<GMIHJEAEDBM>> FBJGHGFGCFL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x34384F0", Offset = "0x34372F0", VA = "0x1834384F0")]
	[Preserve]
	public PHKIJNAMOFJ([MAEEAOEDELI(null)] KEOHPKPMANC BIGGGPCPBCF, [MAEEAOEDELI(null)] FCEIAEBAOBA CDCCIJDEFGI, [MAEEAOEDELI(null)] CGLFCKPIMDP FOFGMIHNEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3438260", Offset = "0x3437060", VA = "0x183438260")]
	[AsyncStateMachine(typeof(PACFBKCNPFF))]
	public Task<IList<JFJMPPONANH>> KOJPGBAMJIE(long HMOGFNMOLJM, long KMHHOKHNCJA, bool AMOJOPIHCBD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34380B0", Offset = "0x3436EB0", VA = "0x1834380B0")]
	private bool EDGFNJLJNBH(DateTime? PFIOLPDCDDE, long HMOGFNMOLJM, long KMHHOKHNCJA, out GPNEMJHGMNP MKGFLPPMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34383B0", Offset = "0x34371B0", VA = "0x1834383B0")]
	[AsyncStateMachine(typeof(AJMJMIOFNLD))]
	private Task<IReadOnlyList<(int, NBNLPEKLFLE, GMIHJEAEDBM)>> LNONENEOPAB(IReadOnlyList<GMIHJEAEDBM> LAGIBNJDAAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FCEIAEBAOBA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GPNEMJHGMNP> JKNDCAHMDKL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCAHCMDGMDI(long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN, NAEECGFNFPJ JDHHIBOGJMN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LIDNDMHIFOA(long HMOGFNMOLJM, long KMHHOKHNCJA, out GPNEMJHGMNP MKGFLPPMKLO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DLMJPEAGLAB(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, out GPNEMJHGMNP MKGFLPPMKLO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKNCJMEPHJO(long HMOGFNMOLJM, long KMHHOKHNCJA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface DCCPDALJBAL : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BLEPNBPEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task KLLKDKCGKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPCCOGMIDAO(Task BCLOPCAMFLH, string CNPIGPDOMBD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface MFOKDGLCBJK : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EDADMNIFEBK> GEGFJFGPFMM(GPNEMJHGMNP MKGFLPPMKLO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NGGJGJGNMGK(CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface EBKAECJIOND : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CMPGKADDOBE KDKDECOHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNILANEOOJF();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPJLDBKFAAC();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface FLHIBGCAMJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface JPIFLEHBIAL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan FPNMCNFOMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JPDBJCBDAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GFKNLJONAML
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan IGNOJFLPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GKIADNJPEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NLGIBJGIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EBPHHAKMDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OEMMDHAJDIN
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CBLJMJHIGLN
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
public struct GBLFGEDHNKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly long GKAMKMBOFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly long NMFONIKGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly OEMMDHAJDIN BIEGICDMJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CanBeNull]
	public readonly Exception CCNCKENFPAE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D650", Offset = "0x2B9C450", VA = "0x182B9D650")]
	public GBLFGEDHNKK(long GKAMKMBOFDN, long NMFONIKGFJA, OEMMDHAJDIN BIEGICDMJCM, [CanBeNull] Exception CCNCKENFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D600", Offset = "0x2B9C400", VA = "0x182B9D600")]
	public static GBLFGEDHNKK LEEEFIBDGIA(JHCBDEANCOK LPGMONBIEDG, OEMMDHAJDIN BIEGICDMJCM, [Optional] Exception CCNCKENFPAE)
	{
		return default(GBLFGEDHNKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void KAPGPONHLBL(GBLFGEDHNKK IELAMMJPGFE);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface HEJGMLKIOPN : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPCCMFHOKGG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KAPGPONHLBL OGICKBCLMKL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KAPGPONHLBL IAAPGPFHLFI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KAPGPONHLBL CGOEFJEPMMA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CBLJMJHIGLN, bool> AMCAOFMJBFN;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GAGGODCNOLH();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GKADGHHFPEF(GBLFGEDHNKK IELAMMJPGFE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MOFIEFFAPOH(GBLFGEDHNKK IELAMMJPGFE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MPLGIDBMCFK(GBLFGEDHNKK IELAMMJPGFE);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PPKFKEEHGDI(CBLJMJHIGLN CPBINDABFHD, bool NKODDMBDLFC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface GCCJIMCEGGI : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GMGGHKHPBML();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGMCIPLFBFK();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIAEBEDAGAM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task OHPFCEKIMGL(FAFEPBBAFLL CGNEHNOPJMM, CancellationToken JJFHDFJGCDG);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface AOCHCJABCKH : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool KNBLIBKHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJGCNKLMHCL(OHPFCEKIMGL EFNMFBPHPAE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface MLPODPEFDLP : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus NLNLOHLCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CCKGNIADLEM(JHCBDEANCOK IOGMCGLFEHG, GFNMDKDIBLM GNGFNEHDMOA, CancellationToken LAKDHEPMDKO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class GGPHDIDPCGO
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B9ECE0", Offset = "0x2B9DAE0", VA = "0x182B9ECE0")]
	public static bool ABCNANHIGIM(this MLPODPEFDLP NCMIIFAGALO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface IAJPIHCHKKO : GEACCIIFOMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken FGLCHIKBMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HGCFMABKDDJ FEFJCNCBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PKJMFNAKBLI NHHOPOBPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BBEJDMLGHJF EIKFCDNKMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CDFFKAEIMLF LCKJJBALDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DFIABPFMAFI KKCPELJIIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EPICHIOPPLH JHDBDDCJOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CIBCBPALFJL MLCKJIIODNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DCCPDALJBAL ABMBFOKBJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MFOKDGLCBJK GEIBMPCBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HEJGMLKIOPN MHHJFFJLHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GCCJIMCEGGI LMOBEGHONAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MLPODPEFDLP MLPKNMDDJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AOCHCJABCKH EEJJGHPKNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OENDDEHNIIK IJKFKNGINHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KIMPLKCKBGH KKEHNHIHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ADMLJCBFOLB HGNNDAIDBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DHMADMBPCHB NMKJADGKEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KBANOPGIDKE ADNAELMFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IPLOKIPJJIH AJAFBJICOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JMIKBAENDAP ICMNGMGKNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LDKOGKFELIG NPGDEFMNNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IJKLBNCDOCH BGIFNOJABOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KBOECFLDMHD GHKEIAMKHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NLPBBIJHMGG HGLDMBBMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EBKAECJIOND LKBNDKMJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	JPIFLEHBIAL JNEBJPNPAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OOPMGELKGFC JFHACIPKJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FCEIAEBAOBA JNCFKCPHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OHJOBKOCENM(GFNMDKDIBLM HDOLDAOEBJF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface OENDDEHNIIK : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKALOINEDDO ELGBPIMHCCH(Guid FCEHMDFKHII);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOHHNJJEEIG(Guid FCEHMDFKHII);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMLKCGPPBBO(Guid FCEHMDFKHII, Task AACHDJBFHLE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHMDELCBIKA(Guid FCEHMDFKHII, EDADMNIFEBK OKOGFHFEHPH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CIAEBEDAGAM(Guid FCEHMDFKHII);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(EDADMNIFEBK, Task)> ELFEECBCIEM(Guid FCEHMDFKHII);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface KIMPLKCKBGH : FLHIBGCAMJL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface ADMLJCBFOLB : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMIPFJIHCOO(FJGCNLIMCNH HDKJDEIGPPL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEGBLPKIIAP(FJGCNLIMCNH HDKJDEIGPPL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BMCDEJCGGOJ> OCNBDHENNHD(CancellationToken EAEDBLMDKPK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate EDADMNIFEBK FCKJNGCNFCN(HHODDDLIHOO DLODLNNFJAK, BMCDEJCGGOJ FKHJNKOHGHH);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DHMADMBPCHB : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKALOINEDDO LAJPCBLALIJ(FJGCNLIMCNH KKHHMNPIDHC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGMLOMPOLBF(Guid FCEHMDFKHII, Task AACHDJBFHLE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KBANOPGIDKE : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EDADMNIFEBK> ADNAELMFJMP(FJGCNLIMCNH IDOPEBAPBGI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface IPLOKIPJJIH : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENNEEGPPNHD> KFEHEAKNDHN(CEJMOEANPLC PDHDLCNGDKN, JHCBDEANCOK IOGMCGLFEHG, CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LDKOGKFELIG : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDADMNIFEBK GPFLACOIDDO(HHODDDLIHOO DLODLNNFJAK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OHIDPGGMLNC(string GEMBNOGNCGO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JMIKBAENDAP : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJGCNLIMCNH> IHKILDNPJGJ(FJGCNLIMCNH BOBJBDACGIL, JLMDOPEJOBO JJJBMPKIJJD, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FJGCNLIMCNH> LNPECPHAEIP(CancellationToken ADCKNELPFOJ, JLMDOPEJOBO JJJBMPKIJJD);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OGKMJPOHBDC JJCPKDHDDGE(FBNACAEIJNK KDBBBFCLHNO, CEJMOEANPLC PDHDLCNGDKN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGKMJPOHBDC POEMGCEBOPG(FBNACAEIJNK KDBBBFCLHNO, CEJMOEANPLC PDHDLCNGDKN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface IJKLBNCDOCH : FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDADMNIFEBK EBALGJPPDHO(HHODDDLIHOO DLODLNNFJAK, BMCDEJCGGOJ FKHJNKOHGHH);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDADMNIFEBK EIFFKOIAPPL(HHODDDLIHOO MAHCEDMJMAH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDADMNIFEBK CGBMAHOCNMG(HHODDDLIHOO MAHCEDMJMAH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KBOECFLDMHD
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDMOBPMHJNK(DBGLIFFEAPK BFGNHCKFCKC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIONLJNNFHH(DBGLIFFEAPK BFGNHCKFCKC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CELHEADHGDC(DBGLIFFEAPK BFGNHCKFCKC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKGOECIMDIO(DBGLIFFEAPK BFGNHCKFCKC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DBGLIFFEAPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JHCBDEANCOK JOCKOOPDMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, string> CGHICCNGICM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::EEKDJEFEHJA<string> HBFCGMJPDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public DBGLIFFEAPK(JHCBDEANCOK KIBPNBFNHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B95210", Offset = "0x2B94010", VA = "0x182B95210")]
	public DBGLIFFEAPK JPEICEDFFOK(string BIMCDHOFDCP, string GKFICKKHACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B95190", Offset = "0x2B93F90", VA = "0x182B95190")]
	public bool JOEEACPBLNF(out IEnumerable<KeyValuePair<string, string>> NEOMJMNAGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2941C60", Offset = "0x2940A60", VA = "0x182941C60")]
	public DBGLIFFEAPK NGEAHOGNKLF(global::EEKDJEFEHJA<string> BIEDEPNABLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OOPMGELKGFC
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool NNLPIDPNANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string ABFGPKCEBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGECGCKEJNB();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGMMKFHKFLE BAPLFNEPFJO(long OMGLNIDEKLD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::LOPHDIBPEHK<MOAJEGAOKON, IDBFKGMDDDL> HHFEFAOFOAF(long OMGLNIDEKLD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::LOPHDIBPEHK<MOAJEGAOKON, IFHIAHJKMIE> OAFHOMILJLF(long OMGLNIDEKLD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::LOPHDIBPEHK<long, JNMMIDGNACF> DKDCDJGMLHA();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> BCILAKHDKGD(byte[] EECPCDMLMCO, byte[] BNFGILNHPPN, CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GEACCIIFOMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool ABCNANHIGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CPMJKPDOFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task JEJKHPLBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	GFNMDKDIBLM IMLDLKCBJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HPCCMFHOKGG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KAPGPONHLBL OGICKBCLMKL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KAPGPONHLBL IAAPGPFHLFI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KAPGPONHLBL CGOEFJEPMMA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CBLJMJHIGLN, bool> AMCAOFMJBFN;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BGMCIPLFBFK();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HKLCPKCDEDD MNLKAFLEABA();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DGPBCCKFCJO GBMOFEAEBJK();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<EDADMNIFEBK> GEGFJFGPFMM(GPNEMJHGMNP KBKLCBOFMEN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NGGJGJGNMGK(CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CDFFKAEIMLF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CFPPEKPEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string KPFIOCHGCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBBDACDABNO(Scene LOCKNDMLIOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DAHFFMJEHNK(MDIDCCCLLID FHKMAPPCGHL, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ONFFAEGBLNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PHALPGAPCKG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int GEHDIBOGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OCACCFNKKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool NMFLCHCGFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JIKENOMKMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CHMFJIOLLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool IFDOHPFAEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	HHODDDLIHOO LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IGNLHLDOEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HGCFMABKDDJ EEBJMMODAGG(HGCFMABKDDJ PPLKNGGGHBP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMIFFPBCOCB(HGCFMABKDDJ FLBJMLJLEGK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task FEDLPDMGMAE(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NKGCAHCODFG(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task JFFODFOHEKK(CIDAOGNGFEK LFBMHKKDNLG, [Optional] CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOPJCBNKJPE(float CKFOGIIACBB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HJOFNIGJIDI(string KEGMOHIBNHJ);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<HDIPLEEAOIL> MDIMFEONNHH();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable IMFIBFFAKHM(object EDPENIGJGLF, HDIPLEEAOIL EMIHNIFPKNM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IDBFKGMDDDL HNIJEBFIOLK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGMIKFOCHLP(int NEDCMBLJDOL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PLGOEJGBDHN();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IHENOGBBIHM();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool PNFEMECJCGJ();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OIKFHJIEGGA(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task HNOALFOPEFI(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<FKMKEDBGHNF> PADBIPLFCGJ(DateTime EFJJDMMCFPD, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> DHHKFFOCBLO(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GDODJBDCGFD();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KAKBDOCOCJJ OBIIAPNACEP(CDDICEMKPIL CFLMMFKOKIC, IFHIAHJKMIE ANIJBIHPCED, IEnumerable<PersistenceView> HJKCJHCGMHJ, ref FNKKAEHEGEC KAIOJDJBLIK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GBDEFGEMCIN(IOMALNHJNIN JNKHFBAHKDD, in KAKBDOCOCJJ FILNOJDGMDM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BKCIAEEIDFL(IFHIAHJKMIE BEACAGMICDF, bool DOPDECLOKOG);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PCCKEKGLENG();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NGMHPGFFIAA(long HMOGFNMOLJM, long NMFONIKGFJA, EKLMJEDNPMN OPOLHNGKHJE, ABKPGODLHEA MFDLBBEKGKN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GCCKOOKOGEB(long HMOGFNMOLJM, long NMFONIKGFJA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CPFIJPBGFDJ(PersistenceView EFANNCGDCDF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool JIHFPBKHKAC(PersistenceView BDEPBKMNBCE);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool BODPLBLLJNM(IOMALNHJNIN JNKHFBAHKDD, MIDGADGEHKB KHFKLFKJGLM, out CJDNBLOMJIN GIBMADLLGGG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HNDNMHMJPBB();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BLPBJDJIOBE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable DGHKDOGGGNE();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BDCDDFKMPEM(IFHIAHJKMIE BEACAGMICDF, MIDGADGEHKB KHFKLFKJGLM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> AEOGKKPHALF(PKJMFNAKBLI IJNIKOCLGEN, CancellationToken ADCKNELPFOJ, CEJMOEANPLC PDHDLCNGDKN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KMINIOIINBB(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<CFAAADDMGBE> IAPBDKCGBKE(long HMOGFNMOLJM, long NMFONIKGFJA, string DDFMKNKNADC, NFHPICNOJGF.IMJFLDFJCCH CGNEHNOPJMM, NFHPICNOJGF.IMJFLDFJCCH BNFGILNHPPN, IReadOnlyDictionary<long, int> HOAFFEGLKBG, int HACJGKLHBLA, string LIMGJHIDALE, bool EPBFAMNKKPN, int HLJCHABLDDA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<COJLFEIGGFL> OIBPLINIOPA(string JBJGKNEAFLJ, long HMOGFNMOLJM, long NMFONIKGFJA, string DDFMKNKNADC, NFHPICNOJGF.IMJFLDFJCCH CGNEHNOPJMM, NFHPICNOJGF.IMJFLDFJCCH BNFGILNHPPN, int BIOCBIPJPBJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EKLMJEDNPMN> KHJJMDHPGON(long HMOGFNMOLJM, bool DMPGHNLJBEA, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JDGAOALIMNE();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool MPNPCGGBAFE();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OOFHELPOEED(IEnumerable<CJDNBLOMJIN> EABINNOMLEL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void IBOPKJEMKJD(List<GameObject> OBBNHEEFOLO);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float ANFPEHJDJLM();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool LMAPBBBJBDM(string BIHFIHKHIBA, out Scene IEGFBJCKFAP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> FOJPEBJCGFH(string BIHFIHKHIBA, LoadSceneMode GCIMJCAMGNJ, bool IMDFFNIBLHP, CEJMOEANPLC BIEDEPNABLP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void MIJJBCEBCEA();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool IKAKGIHIHCJ(ByteString MEFFDBODCGD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void OCCLEOGAOFA(JHCBDEANCOK FAJDGHOJCAH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task NDOHKJPCFOF(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task HIEBAGGEICI(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void MNOOEHBFECO();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable HBJINFJBKOP();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	MLAEPGHCMNJ NFKGOCAIOGA();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MLAEPGHCMNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DNODLMPAEDK(CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IKNMFFAPBCJ(CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KAKBDOCOCJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HashSet<int> BGADGJBDAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IDisposable HCKFHKHNLMH;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6410", Offset = "0x2BA5210", VA = "0x182BA6410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum FKMKEDBGHNF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MMDMAENKKFC
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	JHCBDEANCOK NJIDAPBEKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	EKLMJEDNPMN BGGCCDBAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	BJMHDOIMFLB AFOJNIEOLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MHNNLEOBHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool EMFJDDGKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int GEHDIBOGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action GANEALHNEGP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> AOAKPDJIBLK;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BAFBBIAEENO();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.DACHHNHKJLG> EMFPHOHOPJJ();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BJKNCNHNOPA();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(JHCBDEANCOK, GFNMDKDIBLM) EGGEPBMIIAL();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KBPEMCHIDOA MAANNILAIJC();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBLHHOJOMAC(long OMGLNIDEKLD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NLPBBIJHMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DECCEMNCKPP(out IEnumerable<int> HPNGNLGILNC);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOMKIMHLOHC(GHFMFMDNJJE JJFHDFJGCDG);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBEOAFOIMKH(GHFMFMDNJJE JJFHDFJGCDG);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface GGLGJDOPBLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CMOHLBMAMBD(EDADMNIFEBK IOAMCBDOOBL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IJNAJOEFAJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPAOILJFNCE(OMLDHPMMBFH.CHGHHNOCONJ MNEIMAKMEEI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIIJDAIMEMC(OMLDHPMMBFH.CHGHHNOCONJ MNEIMAKMEEI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DFIABPFMAFI : IJNAJOEFAJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDADMNIFEBK BPNGKKIGPCJ(HHODDDLIHOO MAHCEDMJMAH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EPICHIOPPLH : IJNAJOEFAJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDADMNIFEBK GPFLACOIDDO(HHODDDLIHOO GAHFLBDIKFI);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PGMMKFHKFLE
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EMFHPGMFAOO<MDIDCCCLLID, BMIGOOHOEBL>> DOFFDEOONDC(string DDFMKNKNADC, long OMGLNIDEKLD, KFNPLEMFNFN.HNBAAKEGDFN ADDFOGMJOEM, CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LOPHDIBPEHK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EMFHPGMFAOO<byte[], BMIGOOHOEBL>> HHCFHLCKAFG(TGetDataArg KJLFMKEMDIK, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EMFHPGMFAOO<global::NGNOGAAMAIJ<TData>, BMIGOOHOEBL> KKPBHKNIEKH(byte[] JLFCOOGLPMP);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class ANMOGBOBAML : IAJPIHCHKKO, GEACCIIFOMJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MNKPMGFCONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public ANMOGBOBAML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GPNEMJHGMNP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<EDADMNIFEBK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x342C6F0", Offset = "0x342B4F0", VA = "0x18342C6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x342C990", Offset = "0x342B790", VA = "0x18342C990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KLGEHGALDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ANMOGBOBAML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3429E60", Offset = "0x3428C60", VA = "0x183429E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MCIHDLGJFFA : IEnumerable<FLHIBGCAMJL>, IEnumerable, IEnumerator<FLHIBGCAMJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FLHIBGCAMJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ANMOGBOBAML <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private FLHIBGCAMJL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public MCIHDLGJFFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x342B110", Offset = "0x3429F10", VA = "0x18342B110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x342B550", Offset = "0x342A350", VA = "0x18342B550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x342B4B0", Offset = "0x342A2B0", VA = "0x18342B4B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLHIBGCAMJL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x342B4B0", Offset = "0x342A2B0", VA = "0x18342B4B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CancellationTokenSource MKMLIOKMAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HGCFMABKDDJ FLBJMLJLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private AMPLHMMGJOJ MEJDJBGAMDO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public PKJMFNAKBLI NHHOPOBPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x656280", Offset = "0x655080", VA = "0x180656280", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6577D0", Offset = "0x6565D0", VA = "0x1806577D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public BBEJDMLGHJF EIKFCDNKMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x73A460", Offset = "0x739260", VA = "0x18073A460", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7F0", Offset = "0x7EA5F0", VA = "0x1807EB7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE90", Offset = "0x6ECC90", VA = "0x1806EDE90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7AC630", Offset = "0x7AB430", VA = "0x1807AC630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CDFFKAEIMLF LCKJJBALDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6EBEE0", Offset = "0x6EACE0", VA = "0x1806EBEE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x674B80", Offset = "0x673980", VA = "0x180674B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DFIABPFMAFI KKCPELJIIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6EBEF0", Offset = "0x6EACF0", VA = "0x1806EBEF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7AC620", Offset = "0x7AB420", VA = "0x1807AC620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public EPICHIOPPLH JHDBDDCJOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x65F410", Offset = "0x65E210", VA = "0x18065F410", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x74FAB0", Offset = "0x74E8B0", VA = "0x18074FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CIBCBPALFJL MLCKJIIODNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x694570", Offset = "0x693370", VA = "0x180694570", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x75F000", Offset = "0x75DE00", VA = "0x18075F000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public DCCPDALJBAL ABMBFOKBJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7133D0", Offset = "0x7121D0", VA = "0x1807133D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75EFE0", Offset = "0x75DDE0", VA = "0x18075EFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MFOKDGLCBJK GEIBMPCBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6C6550", Offset = "0x6C5350", VA = "0x1806C6550", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x775D80", Offset = "0x774B80", VA = "0x180775D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public HEJGMLKIOPN MHHJFFJLHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF0", Offset = "0x6F38F0", VA = "0x1806F4AF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77CD10", Offset = "0x77BB10", VA = "0x18077CD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GCCJIMCEGGI LMOBEGHONAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x665A80", Offset = "0x664880", VA = "0x180665A80", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x665B40", Offset = "0x664940", VA = "0x180665B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MLPODPEFDLP MLPKNMDDJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF00", Offset = "0x6EAD00", VA = "0x1806EBF00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x75EFF0", Offset = "0x75DDF0", VA = "0x18075EFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AOCHCJABCKH EEJJGHPKNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x65AC30", Offset = "0x659A30", VA = "0x18065AC30", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x65AE90", Offset = "0x659C90", VA = "0x18065AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public OENDDEHNIIK IJKFKNGINHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x65ACF0", Offset = "0x659AF0", VA = "0x18065ACF0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x65AEA0", Offset = "0x659CA0", VA = "0x18065AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KIMPLKCKBGH KKEHNHIHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x65ABB0", Offset = "0x6599B0", VA = "0x18065ABB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x65AE80", Offset = "0x659C80", VA = "0x18065AE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public ADMLJCBFOLB HGNNDAIDBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x670C70", Offset = "0x66FA70", VA = "0x180670C70", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x670CC0", Offset = "0x66FAC0", VA = "0x180670CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DHMADMBPCHB NMKJADGKEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x90D2C0", Offset = "0x90C0C0", VA = "0x18090D2C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9807A0", Offset = "0x97F5A0", VA = "0x1809807A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KBANOPGIDKE ADNAELMFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x672DC0", Offset = "0x671BC0", VA = "0x180672DC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x673290", Offset = "0x672090", VA = "0x180673290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IPLOKIPJJIH AJAFBJICOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x673010", Offset = "0x671E10", VA = "0x180673010", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6733F0", Offset = "0x6721F0", VA = "0x1806733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public JMIKBAENDAP ICMNGMGKNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6928F0", Offset = "0x6916F0", VA = "0x1806928F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6942A0", Offset = "0x6930A0", VA = "0x1806942A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LDKOGKFELIG NPGDEFMNNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6720D0", Offset = "0x670ED0", VA = "0x1806720D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDC0", Offset = "0x8AABC0", VA = "0x1808ABDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IJKLBNCDOCH BGIFNOJABOA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x672DA0", Offset = "0x671BA0", VA = "0x180672DA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x695DE0", Offset = "0x694BE0", VA = "0x180695DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KBOECFLDMHD GHKEIAMKHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x672DB0", Offset = "0x671BB0", VA = "0x180672DB0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x673280", Offset = "0x672080", VA = "0x180673280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NLPBBIJHMGG HGLDMBBMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x695DD0", Offset = "0x694BD0", VA = "0x180695DD0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x695DF0", Offset = "0x694BF0", VA = "0x180695DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EBKAECJIOND LKBNDKMJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x691F00", Offset = "0x690D00", VA = "0x180691F00", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6733D0", Offset = "0x6721D0", VA = "0x1806733D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JPIFLEHBIAL JNEBJPNPAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x699AC0", Offset = "0x6988C0", VA = "0x180699AC0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x699AE0", Offset = "0x6988E0", VA = "0x180699AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OOPMGELKGFC JFHACIPKJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x699AD0", Offset = "0x6988D0", VA = "0x180699AD0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x699AF0", Offset = "0x6988F0", VA = "0x180699AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public FCEIAEBAOBA JNCFKCPHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69E9B0", Offset = "0x69D7B0", VA = "0x18069E9B0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GFNMDKDIBLM IMLDLKCBJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8A14A0", Offset = "0x8A02A0", VA = "0x1808A14A0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDA0", Offset = "0x8AABA0", VA = "0x1808ABDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool KHAKPKEMCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC10", Offset = "0x2B8DA10", VA = "0x182B8EC10", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool IHEEAKGNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF10", Offset = "0x2B8DD10", VA = "0x182B8EF10", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task NNGDIIGLMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E660", Offset = "0x2B8D460", VA = "0x182B8E660", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken PJNKEFEOFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB40", Offset = "0x2B8D940", VA = "0x182B8EB40", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private HGCFMABKDDJ JKMGBCAAMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action GJKHEIOLHED
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECD0", Offset = "0x2B8DAD0", VA = "0x182B8ECD0", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E410", Offset = "0x2B8D210", VA = "0x182B8E410", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event KAPGPONHLBL NHHPNDLNMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E120", Offset = "0x2B8CF20", VA = "0x182B8E120", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB60", Offset = "0x2B8D960", VA = "0x182B8EB60", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event KAPGPONHLBL MJDMDIKLMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E600", Offset = "0x2B8D400", VA = "0x182B8E600", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E810", Offset = "0x2B8D610", VA = "0x182B8E810", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event KAPGPONHLBL LNKBGPLNMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF90", Offset = "0x2B8DD90", VA = "0x182B8EF90", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC70", Offset = "0x2B8DA70", VA = "0x182B8EC70", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<CBLJMJHIGLN, bool> BLJGNHMFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEB0", Offset = "0x2B8DCB0", VA = "0x182B8EEB0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE50", Offset = "0x2B8DC50", VA = "0x182B8EE50", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDA0", Offset = "0x8AABA0", VA = "0x1808ABDA0", Slot = "34")]
	public void OHJOBKOCENM(GFNMDKDIBLM HDOLDAOEBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EFF0", Offset = "0x2B8DDF0", VA = "0x182B8EFF0")]
	[Preserve]
	internal ANMOGBOBAML([MAEEAOEDELI(null)] HGCFMABKDDJ FLBJMLJLEGK, [MAEEAOEDELI(null)] PKJMFNAKBLI IJNIKOCLGEN, [MAEEAOEDELI(null)] BBEJDMLGHJF JFHNHBLBPEL, [MAEEAOEDELI(null)] PHALPGAPCKG KNPPOFLONHP, [MAEEAOEDELI(null)] CDFFKAEIMLF GMCLFDNGMDO, [MAEEAOEDELI(null)] DFIABPFMAFI LHGBFEDOMED, [MAEEAOEDELI(null)] EPICHIOPPLH GFKDEPHPIIE, [MAEEAOEDELI(null)] CIBCBPALFJL BJNNBLLPNOF, [MAEEAOEDELI(null)] DCCPDALJBAL BEFJCBGACCP, [MAEEAOEDELI(null)] MFOKDGLCBJK BBBBDJNJHNE, [MAEEAOEDELI(null)] HEJGMLKIOPN NEDADCIFNEM, [MAEEAOEDELI(null)] GCCJIMCEGGI EPEDHGFADLG, [MAEEAOEDELI(null)] MLPODPEFDLP NCMIIFAGALO, [MAEEAOEDELI(null)] AOCHCJABCKH NBLFFKFIJFM, [MAEEAOEDELI(null)] OENDDEHNIIK DKBOCLCPGFP, [MAEEAOEDELI(null)] KIMPLKCKBGH MKLPJPPHKLM, [MAEEAOEDELI(null)] ADMLJCBFOLB AFLJOBIKGCN, [MAEEAOEDELI(null)] DHMADMBPCHB CPANCLJBHKH, [MAEEAOEDELI(null)] KBANOPGIDKE IEJNEGOGCEP, [MAEEAOEDELI(null)] IPLOKIPJJIH DMNAIEPOHCP, [MAEEAOEDELI(null)] LDKOGKFELIG MJNKGJLJINJ, [MAEEAOEDELI(null)] JMIKBAENDAP FCGCIOOKLEJ, [MAEEAOEDELI(null)] IJKLBNCDOCH NJHEKOHHLCP, [MAEEAOEDELI(null)] KBOECFLDMHD CCCIGHNAGBD, [MAEEAOEDELI(null)] NLPBBIJHMGG HKJIPEEPLEG, [MAEEAOEDELI(null)] JPIFLEHBIAL GOLOEFFHKCK, [MAEEAOEDELI(null)] OOPMGELKGFC JCKOJJHENMD, [MAEEAOEDELI(null)] FCEIAEBAOBA HCCCAMEEFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E720", Offset = "0x2B8D520", VA = "0x182B8E720")]
	private void FNJOFAEFPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E470", Offset = "0x2B8D270", VA = "0x182B8E470", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EBC0", Offset = "0x2B8D9C0", VA = "0x182B8EBC0", Slot = "48")]
	private void IENGDJMHKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E2C0", Offset = "0x2B8D0C0", VA = "0x182B8E2C0", Slot = "49")]
	private HKLCPKCDEDD DBAJEPCJHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E870", Offset = "0x2B8D670", VA = "0x182B8E870", Slot = "50")]
	private DGPBCCKFCJO HCPOGMHCHCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E180", Offset = "0x2B8CF80", VA = "0x182B8E180", Slot = "51")]
	[AsyncStateMachine(typeof(MNKPMGFCONL))]
	private Task<EDADMNIFEBK> BLFIEBOCCNL(GPNEMJHGMNP MKGFLPPMKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ED30", Offset = "0x2B8DB30", VA = "0x182B8ED30", Slot = "52")]
	[AsyncStateMachine(typeof(KLGEHGALDDE))]
	private Task LNPLBGGGOLE(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EAD0", Offset = "0x2B8D8D0", VA = "0x182B8EAD0")]
	[IteratorStateMachine(typeof(MCIHDLGJFFA))]
	private IEnumerable<FLHIBGCAMJL> HHKEGOACKBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EA20", Offset = "0x2B8D820", VA = "0x182B8EA20")]
	[CompilerGenerated]
	private void HHDCCIOIPCC(FLHIBGCAMJL NMNKGKHKMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class OMJCNKFOAII : EOLLIBHPNAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct DNPPADEEPAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OMJCNKFOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x40E5990", Offset = "0x40E4790", VA = "0x1840E5990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x40E5D10", Offset = "0x40E4B10", VA = "0x1840E5D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4A0", Offset = "0x6ED2A0", VA = "0x1806EE4A0")]
	public OMJCNKFOAII(IAJPIHCHKKO NHBDFDDDAKD, PHALPGAPCKG KNPPOFLONHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3436B50", Offset = "0x3435950", VA = "0x183436B50", Slot = "4")]
	[AsyncStateMachine(typeof(DNPPADEEPAL))]
	public Task<bool> JDLHLMNOIAD(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3436C70", Offset = "0x3435A70", VA = "0x183436C70")]
	[CompilerGenerated]
	private object KNBPKMAFIFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class CPMGPNHBPEB : EOLLIBHPNAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CFDNNKOFGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CPMGPNHBPEB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3423F90", Offset = "0x3422D90", VA = "0x183423F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x34245C0", Offset = "0x34233C0", VA = "0x1834245C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const float GJKLLKKLPMD = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B95140", Offset = "0x2B93F40", VA = "0x182B95140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4A0", Offset = "0x6ED2A0", VA = "0x1806EE4A0")]
	public CPMGPNHBPEB(IAJPIHCHKKO NHBDFDDDAKD, PHALPGAPCKG KNPPOFLONHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B94EC0", Offset = "0x2B93CC0", VA = "0x182B94EC0", Slot = "4")]
	[AsyncStateMachine(typeof(CFDNNKOFGFB))]
	public Task<bool> JDLHLMNOIAD(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B95000", Offset = "0x2B93E00", VA = "0x182B95000")]
	[CompilerGenerated]
	private object KMLIAHPJIMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class BKMMJKABKKM : EOLLIBHPNAO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NCIEBBDLIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public BKMMJKABKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Matchmaking.DACHHNHKJLG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public JHCBDEANCOK newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NCIEBBDLIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x342CDE0", Offset = "0x342BBE0", VA = "0x18342CDE0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x342CEC0", Offset = "0x342BCC0", VA = "0x18342CEC0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x342CF30", Offset = "0x342BD30", VA = "0x18342CF30")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PMBFBEDJAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BKMMJKABKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private NCIEBBDLIHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Matchmaking.DACHHNHKJLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3438610", Offset = "0x3437410", VA = "0x183438610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3438ED0", Offset = "0x3437CD0", VA = "0x183438ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private const float GJKLLKKLPMD = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B917E0", Offset = "0x2B905E0", VA = "0x182B917E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4A0", Offset = "0x6ED2A0", VA = "0x1806EE4A0")]
	public BKMMJKABKKM(IAJPIHCHKKO NHBDFDDDAKD, PHALPGAPCKG KNPPOFLONHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B916A0", Offset = "0x2B904A0", VA = "0x182B916A0", Slot = "4")]
	[AsyncStateMachine(typeof(PMBFBEDJAMJ))]
	public Task<bool> JDLHLMNOIAD(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface EOLLIBHPNAO
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JDLHLMNOIAD(CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct IEIMNKHDODD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JGIFALIFBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public IAJPIHCHKKO manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JGIFALIFBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x35EB760", Offset = "0x35EA560", VA = "0x1835EB760")]
		internal Task <CreateTask>b__0(FAFEPBBAFLL data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct BHPMLJHOIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IEIMNKHDODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private GPNEMJHGMNP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<FKMKEDBGHNF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<EDADMNIFEBK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x35E2E50", Offset = "0x35E1C50", VA = "0x1835E2E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x35E33D0", Offset = "0x35E21D0", VA = "0x1835E33D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct OCAMFGMEFDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEIMNKHDODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x35F0FA0", Offset = "0x35EFDA0", VA = "0x1835F0FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly CancellationToken ADCKNELPFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly IAJPIHCHKKO JFENCDCNGLN;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private PKJMFNAKBLI NHHOPOBPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4930", Offset = "0x2BA3730", VA = "0x182BA4930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4AB0", Offset = "0x2BA38B0", VA = "0x182BA4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4A30", Offset = "0x2BA3830", VA = "0x182BA4A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private MFOKDGLCBJK GEIBMPCBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA48E0", Offset = "0x2BA36E0", VA = "0x182BA48E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4E50", Offset = "0x2BA3C50", VA = "0x182BA4E50")]
	public IEIMNKHDODD(CancellationToken ADCKNELPFOJ, IAJPIHCHKKO JFENCDCNGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4980", Offset = "0x2BA3780", VA = "0x182BA4980")]
	public static OHPFCEKIMGL KDONCABIBDP(IAJPIHCHKKO JFENCDCNGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BA46B0", Offset = "0x2BA34B0", VA = "0x182BA46B0")]
	[AsyncStateMachine(typeof(BHPMLJHOIOD))]
	public Task<bool> BLFPKNOMADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4B00", Offset = "0x2BA3900", VA = "0x182BA4B00")]
	private bool NBHECCOGAIH(out GPNEMJHGMNP MKGFLPPMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BA47E0", Offset = "0x2BA35E0", VA = "0x182BA47E0")]
	[AsyncStateMachine(typeof(OCAMFGMEFDI))]
	private Task DHCJGAOFDCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4CA0", Offset = "0x2BA3AA0", VA = "0x182BA4CA0")]
	private Task<FKMKEDBGHNF> OLFPJDBIDLA(GPNEMJHGMNP HHHDINKPPPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct FKALOINEDDO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly OENDDEHNIIK DKBOCLCPGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Guid FCEHMDFKHII;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(EDADMNIFEBK, Task)> JPLKLKPGNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D410", Offset = "0x2B9C210", VA = "0x182B9D410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x25210C0", Offset = "0x251FEC0", VA = "0x1825210C0")]
	public FKALOINEDDO(OENDDEHNIIK DKBOCLCPGFP, Guid FCEHMDFKHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D4E0", Offset = "0x2B9C2E0", VA = "0x182B9D4E0")]
	public TaskAwaiter<(EDADMNIFEBK, Task)> DBIJCJMCFAF()
	{
		return default(TaskAwaiter<(EDADMNIFEBK, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D530", Offset = "0x2B9C330", VA = "0x182B9D530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct FJNMCJKCLFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TaskCompletionSource<(EDADMNIFEBK, Task)> GOIMDMGNGKP;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(EDADMNIFEBK, Task)> JPLKLKPGNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D0A0", Offset = "0x2B9BEA0", VA = "0x182B9D0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D2A0", Offset = "0x2B9C0A0", VA = "0x182B9D2A0")]
	public FJNMCJKCLFJ(TimeSpan JIIJLIALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D0E0", Offset = "0x2B9BEE0", VA = "0x182B9D0E0")]
	public void CCPHKPLDNAA(Task AACHDJBFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D1C0", Offset = "0x2B9BFC0", VA = "0x182B9D1C0")]
	public void GKCBGNMINPE(EDADMNIFEBK IOAMCBDOOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D250", Offset = "0x2B9C050", VA = "0x182B9D250")]
	public void PGLAJAKAHFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D010", Offset = "0x2B9BE10", VA = "0x182B9D010")]
	internal void ACDFNCFJGHD(string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MBBJIMGHPPA
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HLPAKBPJHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HLPAKBPJHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x146E8E0", Offset = "0x146D6E0", VA = "0x18146E8E0")]
		internal bool <Create>b__0(BJMHDOIMFLB subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB1A0", Offset = "0x2BA9FA0", VA = "0x182BAB1A0")]
	public static ENNEEGPPNHD GLBIKEOEKPG(long GKAMKMBOFDN, long NMFONIKGFJA, MOAJEGAOKON EECPCDMLMCO, string DDFMKNKNADC, MOAJEGAOKON BNFGILNHPPN, string JBJGKNEAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAE10", Offset = "0x2BA9C10", VA = "0x182BAAE10")]
	public static ENNEEGPPNHD GLBIKEOEKPG(EKLMJEDNPMN KNGJOFJOOLM, GMIHJEAEDBM HHOHJCFFLNI, [Optional] string JBJGKNEAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAF80", Offset = "0x2BA9D80", VA = "0x182BAAF80")]
	public static ENNEEGPPNHD GLBIKEOEKPG(EKLMJEDNPMN KNGJOFJOOLM, long NMFONIKGFJA, [Optional] string JBJGKNEAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB2E0", Offset = "0x2BAA0E0", VA = "0x182BAB2E0")]
	public static ENNEEGPPNHD JJMMCIPJGJK(this ENNEEGPPNHD OICHLBNIOCE, EKLMJEDNPMN AJELKHEAJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAC50", Offset = "0x2BA9A50", VA = "0x182BAAC50")]
	public static ENNEEGPPNHD BAGAMLEMEOP(this ENNEEGPPNHD OICHLBNIOCE, GMIHJEAEDBM MBEJJOACPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAD30", Offset = "0x2BA9B30", VA = "0x182BAAD30")]
	public static ENNEEGPPNHD BAGAMLEMEOP(this ENNEEGPPNHD OICHLBNIOCE, BJMHDOIMFLB ECKOEICPOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Preserve]
internal class JDPHEKLFJIG : DCCPDALJBAL, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IGJHLILCNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public JDPHEKLFJIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x35EAA10", Offset = "0x35E9810", VA = "0x1835EAA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GHFMFMDNJJE AKLLIODEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string LABNCJKMCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Task JCPOCHBCFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BLEPNBPEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA53D0", Offset = "0x2BA41D0", VA = "0x182BA53D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task KLLKDKCGKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5370", Offset = "0x2BA4170", VA = "0x182BA5370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260", Slot = "7")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BA51F0", Offset = "0x2BA3FF0", VA = "0x182BA51F0", Slot = "6")]
	public void EPCCOGMIDAO(Task BCLOPCAMFLH, string CNPIGPDOMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BA50C0", Offset = "0x2BA3EC0", VA = "0x182BA50C0")]
	[AsyncStateMachine(typeof(IGJHLILCNDO))]
	private Task ECGNMMECBEM(Task IAKJPAEGDEG, string CNPIGPDOMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5400", Offset = "0x2BA4200", VA = "0x182BA5400")]
	public JDPHEKLFJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class BMNOCKBMHOB : EBKAECJIOND, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool LHNNMBCENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private CMPGKADDOBE KNCLNAHHGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JPIFLEHBIAL GOLOEFFHKCK;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CMPGKADDOBE KDKDECOHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BC0", Offset = "0x2B909C0", VA = "0x182B91BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B91870", Offset = "0x2B90670", VA = "0x182B91870", Slot = "7")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B91A00", Offset = "0x2B90800", VA = "0x182B91A00", Slot = "5")]
	public void NNILANEOOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B91830", Offset = "0x2B90630", VA = "0x182B91830", Slot = "6")]
	public void JPJLDBKFAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B91980", Offset = "0x2B90780", VA = "0x182B91980")]
	private Task LLDIPJGACBO(EIKHPNBLFLL KBICBGPAOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B91830", Offset = "0x2B90630", VA = "0x182B91830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public BMNOCKBMHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class HAICOIJBHCD : JPIFLEHBIAL
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class EKGKCPENKJJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly LOKJEBLNJMA LFEILJMMIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly string BIMCDHOFDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly T BJJKLHEAKLF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6CC600", Offset = "0x6CB400", VA = "0x1806CC600")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x6CC620", Offset = "0x6CB420", VA = "0x1806CC620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x33205E0", Offset = "0x331F3E0", VA = "0x1833205E0")]
		public EKGKCPENKJJ(LOKJEBLNJMA LFEILJMMIDE, string BIMCDHOFDCP, T BJJKLHEAKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3320100", Offset = "0x331EF00", VA = "0x183320100")]
		private void PLAPALPAFOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly EKGKCPENKJJ<TimeSpan> GFFEJBBFDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly EKGKCPENKJJ<TimeSpan> PBNILIBPCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly EKGKCPENKJJ<TimeSpan> EKPAAOMBEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly EKGKCPENKJJ<TimeSpan> KGDHJFHMNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly EKGKCPENKJJ<bool> GJCGDKOHFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly EKGKCPENKJJ<bool> FMKEPMOHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly EKGKCPENKJJ<bool> BOKKPMGCOKI;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan FPNMCNFOMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB80", Offset = "0x2B9E980", VA = "0x182B9FB80", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan JPDBJCBDAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB00", Offset = "0x2B9E900", VA = "0x182B9FB00", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan GFKNLJONAML
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB40", Offset = "0x2B9E940", VA = "0x182B9FB40", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan IGNOJFLPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC80", Offset = "0x2B9EA80", VA = "0x182B9FC80", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool GKIADNJPEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC40", Offset = "0x2B9EA40", VA = "0x182B9FC40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool NLGIBJGIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FBC0", Offset = "0x2B9E9C0", VA = "0x182B9FBC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool EBPHHAKMDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC00", Offset = "0x2B9EA00", VA = "0x182B9FC00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FCC0", Offset = "0x2B9EAC0", VA = "0x182B9FCC0")]
	[Preserve]
	public HAICOIJBHCD([MAEEAOEDELI(null)] LOKJEBLNJMA LFEILJMMIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class HAEPOCKIMBM : HEJGMLKIOPN, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PDLOKGAMGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GBLFGEDHNKK roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public PDLOKGAMGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x35F1720", Offset = "0x35F0520", VA = "0x1835F1720")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action HPCCMFHOKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F760", Offset = "0x2B9E560", VA = "0x182B9F760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EEC0", Offset = "0x2B9DCC0", VA = "0x182B9EEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event KAPGPONHLBL OGICKBCLMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5C0", Offset = "0x2B9E3C0", VA = "0x182B9F5C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F480", Offset = "0x2B9E280", VA = "0x182B9F480", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KAPGPONHLBL IAAPGPFHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F140", Offset = "0x2B9DF40", VA = "0x182B9F140", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F000", Offset = "0x2B9DE00", VA = "0x182B9F000", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KAPGPONHLBL CGOEFJEPMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F520", Offset = "0x2B9E320", VA = "0x182B9F520", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F0A0", Offset = "0x2B9DEA0", VA = "0x182B9F0A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<CBLJMJHIGLN, bool> AMCAOFMJBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F660", Offset = "0x2B9E460", VA = "0x182B9F660", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EF60", Offset = "0x2B9DD60", VA = "0x182B9EF60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "19")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F1E0", Offset = "0x2B9DFE0", VA = "0x182B9F1E0", Slot = "14")]
	public void GAGGODCNOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F450", Offset = "0x2B9E250", VA = "0x182B9F450", Slot = "15")]
	public void GKADGHHFPEF(GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F700", Offset = "0x2B9E500", VA = "0x182B9F700", Slot = "16")]
	public void MOFIEFFAPOH(GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F730", Offset = "0x2B9E530", VA = "0x182B9F730", Slot = "17")]
	public void MPLGIDBMCFK(GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FA50", Offset = "0x2B9E850", VA = "0x182B9FA50", Slot = "18")]
	public void PPKFKEEHGDI(CBLJMJHIGLN CPBINDABFHD, bool NKODDMBDLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F800", Offset = "0x2B9E600", VA = "0x182B9F800")]
	private void PHAMCHAEBGF(KAPGPONHLBL EMIHNIFPKNM, GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public HAEPOCKIMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class JIOJGKKHEDN : GCCJIMCEGGI, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct HGLHMPFHJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JIOJGKKHEDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x35E9410", Offset = "0x35E8210", VA = "0x1835E9410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct BMLEGLFLEMC : IAsyncStateMachine
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
		public JIOJGKKHEDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x35E3480", Offset = "0x35E2280", VA = "0x1835E3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MBIGCMMIEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MBIGCMMIEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x35EE210", Offset = "0x35ED010", VA = "0x1835EE210")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct GIIICIMHMMG : IAsyncStateMachine
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
		public JIOJGKKHEDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MBIGCMMIEDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x35E85B0", Offset = "0x35E73B0", VA = "0x1835E85B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x35E8B40", Offset = "0x35E7940", VA = "0x1835E8B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LJCHFPHOHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LJCHFPHOHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x35EE000", Offset = "0x35ECE00", VA = "0x1835EE000")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private EOLLIBHPNAO[] AOFHHPOHMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CancellationTokenSource DLBKDDIPECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int JLDKANOKHJA;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5A30", Offset = "0x2BA4830", VA = "0x182BA5A30", Slot = "7")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2BA58F0", Offset = "0x2BA46F0", VA = "0x182BA58F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5780", Offset = "0x2BA4580", VA = "0x182BA5780", Slot = "6")]
	public void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5480", Offset = "0x2BA4280", VA = "0x182BA5480", Slot = "5")]
	public void BGMCIPLFBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5C00", Offset = "0x2BA4A00", VA = "0x182BA5C00", Slot = "4")]
	[AsyncStateMachine(typeof(HGLHMPFHJPL))]
	public Task GMGGHKHPBML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5F60", Offset = "0x2BA4D60", VA = "0x182BA5F60")]
	private void LGOJNLPCJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5900", Offset = "0x2BA4700", VA = "0x182BA5900")]
	[AsyncStateMachine(typeof(BMLEGLFLEMC))]
	private Task FJCMIEACKIM(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5AB0", Offset = "0x2BA48B0", VA = "0x182BA5AB0")]
	[AsyncStateMachine(typeof(GIIICIMHMMG))]
	private Task<bool> GDDIHAKEHOK(int BNNEENLPEFO, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA62B0", Offset = "0x2BA50B0", VA = "0x182BA62B0")]
	private void MJMGHEEMJDC(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5D10", Offset = "0x2BA4B10", VA = "0x182BA5D10")]
	private void HCCPEHEOMFF(int BNNEENLPEFO, bool NKODDMBDLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA55D0", Offset = "0x2BA43D0", VA = "0x182BA55D0")]
	private void CCLGMIICJNJ(int BNNEENLPEFO, Exception FFCMPANFFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5E50", Offset = "0x2BA4C50", VA = "0x182BA5E50")]
	private void IAHNLKMHKLC(CancellationToken ADCKNELPFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public JIOJGKKHEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal class BGPEDILMGKH : AOCHCJABCKH, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct KOHMFMCNOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public BGPEDILMGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public FAFEPBBAFLL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x342A030", Offset = "0x3428E30", VA = "0x18342A030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class EHLMLIINIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BGPEDILMGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public FAFEPBBAFLL roomData;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EHLMLIINIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x34255B0", Offset = "0x34243B0", VA = "0x1834255B0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct AOHOHLMFHMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public OHPFCEKIMGL taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3423390", Offset = "0x3422190", VA = "0x183423390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct BFKJFDFLEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public BGPEDILMGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3423D30", Offset = "0x3422B30", VA = "0x183423D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HashSet<OHPFCEKIMGL> LHGOFFDEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private BBEJDMLGHJF JFHNHBLBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private HDIPLEEAOIL PEPBNKOKFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private KPKKOHNGCPF GFELOHLNINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IDisposable FCMKIHNFFAF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KNBLIBKHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2B90A60", Offset = "0x2B8F860", VA = "0x182B90A60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task JPLKLKPGNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2B903F0", Offset = "0x2B8F1F0", VA = "0x182B903F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2B90A90", Offset = "0x2B8F890", VA = "0x182B90A90", Slot = "6")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2B90520", Offset = "0x2B8F320", VA = "0x182B90520", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2B914C0", Offset = "0x2B902C0", VA = "0x182B914C0", Slot = "5")]
	public bool NJGCNKLMHCL(OHPFCEKIMGL EFNMFBPHPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2B90820", Offset = "0x2B8F620", VA = "0x182B90820")]
	private void ECIPHDFLBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2B905A0", Offset = "0x2B8F3A0", VA = "0x182B905A0")]
	private void EAIAMICDOBH(FAFEPBBAFLL CGNEHNOPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2B90E70", Offset = "0x2B8FC70", VA = "0x182B90E70")]
	[AsyncStateMachine(typeof(KOHMFMCNOPC))]
	private Task IPEADJICBBO(FAFEPBBAFLL CGNEHNOPJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2B90D90", Offset = "0x2B8FB90", VA = "0x182B90D90")]
	private Func<CancellationToken, List<Task>> GEMHOJGFHGO(FAFEPBBAFLL CGNEHNOPJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2B90F90", Offset = "0x2B8FD90", VA = "0x182B90F90")]
	private List<Task> KLMLNGNLAPE(FAFEPBBAFLL CGNEHNOPJMM, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2B902C0", Offset = "0x2B8F0C0", VA = "0x182B902C0")]
	[AsyncStateMachine(typeof(AOHOHLMFHMH))]
	private Task AICMHDBKPNA(OHPFCEKIMGL ANJDFHINBEF, FAFEPBBAFLL JLFCOOGLPMP, CancellationToken JJFHDFJGCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2B91520", Offset = "0x2B90320", VA = "0x182B91520")]
	[AsyncStateMachine(typeof(BFKJFDFLEAH))]
	private Task PIJHPPHLLBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2B90400", Offset = "0x2B8F200", VA = "0x182B90400")]
	private void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2B91620", Offset = "0x2B90420", VA = "0x182B91620")]
	public BGPEDILMGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal class OHPNKAKFPLO : MLPODPEFDLP, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GNLHBLGMDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public GFNMDKDIBLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x40E8290", Offset = "0x40E7090", VA = "0x1840E8290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct MHNNFMOJFKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GFNMDKDIBLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private global::EEKDJEFEHJA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private JLMDOPEJOBO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DBGLIFFEAPK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x40EBD00", Offset = "0x40EAB00", VA = "0x1840EBD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class GPGNEILHJCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task<ENNEEGPPNHD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GPGNEILHJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		internal Task<ENNEEGPPNHD> <ConnectToRoomAndRunLoadLogic>b__0(CEJMOEANPLC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct POBOKPOHJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GFNMDKDIBLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JLMDOPEJOBO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private GPGNEILHJCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private GHGOLJAPJCC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CEJMOEANPLC <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private KLJLIGBHMNL <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<ENNEEGPPNHD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x40EF520", Offset = "0x40EE320", VA = "0x1840EF520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct PNDLOKPCNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private CEJMOEANPLC <disconnectTimerScope>5__3;

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
		private CEJMOEANPLC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x40EEC60", Offset = "0x40EDA60", VA = "0x1840EEC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct EKHFPKGOLJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private HGCFMABKDDJ <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x40E63F0", Offset = "0x40E51F0", VA = "0x1840E63F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IHEGKLHNHAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public JLMDOPEJOBO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private CEJMOEANPLC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<KKNMEHNNIFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x40E9190", Offset = "0x40E7F90", VA = "0x1840E9190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class IKDIHOJBBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public JHCBDEANCOK targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public IKDIHOJBBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x40E98E0", Offset = "0x40E86E0", VA = "0x1840E98E0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x40E97E0", Offset = "0x40E85E0", VA = "0x1840E97E0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct MLBKKMKPAJO : IAsyncStateMachine
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
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private IKDIHOJBBFO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x40EC6A0", Offset = "0x40EB4A0", VA = "0x1840EC6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct PKPHJMGEFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JLMDOPEJOBO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ENNEEGPPNHD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public JHCBDEANCOK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GHGOLJAPJCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private CEJMOEANPLC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x40EE680", Offset = "0x40ED480", VA = "0x1840EE680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct DGHALMENNFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private CEJMOEANPLC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x40E55C0", Offset = "0x40E43C0", VA = "0x1840E55C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct POFCAENGHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x40F0C20", Offset = "0x40EFA20", VA = "0x1840F0C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct CJJOILFIHPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x40E51A0", Offset = "0x40E3FA0", VA = "0x1840E51A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct KGHFMHHFLNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<EDADMNIFEBK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x40EA5D0", Offset = "0x40E93D0", VA = "0x1840EA5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct GKKLAFCJKCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public OHPNKAKFPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x40E77B0", Offset = "0x40E65B0", VA = "0x1840E77B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LBIMDINADOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LBIMDINADOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x40EB190", Offset = "0x40E9F90", VA = "0x1840EB190")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class OKDCAEGMEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OKDCAEGMEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x40EDB00", Offset = "0x40EC900", VA = "0x1840EDB00")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class INBLIIGJJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public INBLIIGJJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x40E9BA0", Offset = "0x40E89A0", VA = "0x1840E9BA0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class OGHJMMKDMKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OGHJMMKDMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x40EDA00", Offset = "0x40EC800", VA = "0x1840EDA00")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly string IKIJLBBLCIK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly string JKHEFELAPED;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string MLCADHLFEAB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly Guid AFAJIIOEHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private CIBCBPALFJL BJNNBLLPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BBEJDMLGHJF JFHNHBLBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GCCJIMCEGGI EPEDHGFADLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private DCCPDALJBAL BEFJCBGACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HEJGMLKIOPN NEDADCIFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private JPIFLEHBIAL GOLOEFFHKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IDisposable FCMKIHNFFAF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus NLNLOHLCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD50", Offset = "0x9A9B50", VA = "0x1809AAD50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xDDDB90", Offset = "0xDDC990", VA = "0x180DDDB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3435AB0", Offset = "0x34348B0", VA = "0x183435AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3434880", Offset = "0x3433680", VA = "0x183434880", Slot = "6")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3434550", Offset = "0x3433350", VA = "0x183434550", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x34332A0", Offset = "0x34320A0", VA = "0x1834332A0", Slot = "5")]
	[AsyncStateMachine(typeof(GNLHBLGMDPE))]
	public Task CCKGNIADLEM(JHCBDEANCOK IOGMCGLFEHG, GFNMDKDIBLM GNGFNEHDMOA, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x34350B0", Offset = "0x3433EB0", VA = "0x1834350B0")]
	[AsyncStateMachine(typeof(MHNNFMOJFKK))]
	private Task IFCPCMIDLBL(JHCBDEANCOK IOGMCGLFEHG, GFNMDKDIBLM GNGFNEHDMOA, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3436210", Offset = "0x3435010", VA = "0x183436210")]
	private static void OPNCCKNKDHH(JHCBDEANCOK IOGMCGLFEHG, Exception FFCMPANFFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x34339C0", Offset = "0x34327C0", VA = "0x1834339C0")]
	private static void DGANJODLBJN(DBGLIFFEAPK PELGKKBPDHF, Exception FFCMPANFFDB, [Optional] List<int> HKKCEKNGFJI, int JLDKANOKHJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3435350", Offset = "0x3434150", VA = "0x183435350")]
	[AsyncStateMachine(typeof(POBOKPOHJFL))]
	private Task JEKEABDNJGJ(CEJMOEANPLC BIEDEPNABLP, JHCBDEANCOK IOGMCGLFEHG, GFNMDKDIBLM GNGFNEHDMOA, JLMDOPEJOBO DKBONLFAKJJ, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x34345A0", Offset = "0x34333A0", VA = "0x1834345A0")]
	private void EBOJKKDEACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3435210", Offset = "0x3434010", VA = "0x183435210")]
	[AsyncStateMachine(typeof(PNDLOKPCNHG))]
	private Task IKKEMKBMIFK(CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3434200", Offset = "0x3433000", VA = "0x183434200")]
	private void DOAOKDOJMAL(JHCBDEANCOK IOGMCGLFEHG, CancellationToken LAKDHEPMDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3435CD0", Offset = "0x3434AD0", VA = "0x183435CD0")]
	private void NIHPIFHFMLB(JHCBDEANCOK IOGMCGLFEHG, JLMDOPEJOBO DKBONLFAKJJ, OperationCanceledException PDIKGIDCPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3434CA0", Offset = "0x3433AA0", VA = "0x183434CA0")]
	private void HFPKOGBAGKC(JHCBDEANCOK IOGMCGLFEHG, JLMDOPEJOBO DKBONLFAKJJ, Exception FFCMPANFFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3435F80", Offset = "0x3434D80", VA = "0x183435F80")]
	private void NIJBMIPOOMO(JHCBDEANCOK IOGMCGLFEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3435860", Offset = "0x3434660", VA = "0x183435860")]
	private static GBLFGEDHNKK LBGOONLPFLJ(JHCBDEANCOK IOGMCGLFEHG)
	{
		return default(GBLFGEDHNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x34346F0", Offset = "0x34334F0", VA = "0x1834346F0")]
	[AsyncStateMachine(typeof(EKHFPKGOLJJ))]
	private Task FBJNBNOIECG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3436500", Offset = "0x3435300", VA = "0x183436500")]
	private static KKNMEHNNIFI PMMGGDFLNIA(JHCBDEANCOK IOGMCGLFEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3432D80", Offset = "0x3431B80", VA = "0x183432D80")]
	[AsyncStateMachine(typeof(IHEGKLHNHAL))]
	private Task AFEIHBDCEHF(JHCBDEANCOK IOGMCGLFEHG, JLMDOPEJOBO DKBONLFAKJJ, CEJMOEANPLC BIEDEPNABLP, CancellationToken FPPFEPPLODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3434F50", Offset = "0x3433D50", VA = "0x183434F50")]
	[AsyncStateMachine(typeof(MLBKKMKPAJO))]
	private Task IBAMMGIMCMN(JHCBDEANCOK IOGMCGLFEHG, CancellationTokenSource LPHNDPIJCME, Task FCOIBKADIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3435610", Offset = "0x3434410", VA = "0x183435610")]
	[AsyncStateMachine(typeof(PKPHJMGEFME))]
	private Task KINLHEKJMME(ENNEEGPPNHD HFMEENNPMOB, GHGOLJAPJCC AJEIKLJNAHK, JHCBDEANCOK PBODNIPIIHO, JLMDOPEJOBO JMPBPOCKKHJ, CEJMOEANPLC BIEDEPNABLP, CancellationToken DJPEEGCCKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3433780", Offset = "0x3432580", VA = "0x183433780")]
	private JLMDOPEJOBO DFEEOBJKDAF(JLMDOPEJOBO JMPBPOCKKHJ, ref CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3433640", Offset = "0x3432440", VA = "0x183433640")]
	[AsyncStateMachine(typeof(DGHALMENNFJ))]
	private Task DEPBICFMEIJ(CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x34363D0", Offset = "0x34351D0", VA = "0x1834363D0")]
	[AsyncStateMachine(typeof(POFCAENGHNG))]
	private Task PCEJABIBCMF(CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3434B60", Offset = "0x3433960", VA = "0x183434B60")]
	[AsyncStateMachine(typeof(CJJOILFIHPJ))]
	private Task HDBKCIOFMMO(CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3435B90", Offset = "0x3434990", VA = "0x183435B90")]
	[AsyncStateMachine(typeof(KGHFMHHFLNG))]
	private Task NFNCBBNAHOH(FAFEPBBAFLL JLFCOOGLPMP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x34354D0", Offset = "0x34342D0", VA = "0x1834354D0")]
	[AsyncStateMachine(typeof(GKKLAFCJKCM))]
	private Task JFFODFOHEKK(CEJMOEANPLC PDHDLCNGDKN, CancellationToken FPPFEPPLODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x34334D0", Offset = "0x34322D0", VA = "0x1834334D0")]
	private static void DCCOBGDOIOB(JHCBDEANCOK IOGMCGLFEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3432B60", Offset = "0x3431960", VA = "0x183432B60")]
	private void AAKIDKJHJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3435A20", Offset = "0x3434820", VA = "0x183435A20")]
	private void LLPAAIBNIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x34347F0", Offset = "0x34335F0", VA = "0x1834347F0")]
	private void FKMLKLGBHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3435B00", Offset = "0x3434900", VA = "0x183435B00")]
	private void NDNLMPJAKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3432EF0", Offset = "0x3431CF0", VA = "0x183432EF0")]
	private static void AMCAAGOOCCG(JHCBDEANCOK IOGMCGLFEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x34357A0", Offset = "0x34345A0", VA = "0x1834357A0")]
	private static void KNKGJNHEJNH(JHCBDEANCOK IOGMCGLFEHG, CancellationToken FPPFEPPLODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x34358A0", Offset = "0x34346A0", VA = "0x1834358A0")]
	private static void LCDCGAPENGO(JHCBDEANCOK IOGMCGLFEHG, Exception FFCMPANFFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3433060", Offset = "0x3431E60", VA = "0x183433060")]
	private void BNIBBPMKHHD(JHCBDEANCOK IOGMCGLFEHG, Task FCOIBKADIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x34333F0", Offset = "0x34321F0", VA = "0x1834333F0")]
	private static void CGAIAMLGLCP(Func<string> LGEKLMLBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x34366A0", Offset = "0x34354A0", VA = "0x1834366A0")]
	public OHPNKAKFPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class COPENMDIFFC : OENDDEHNIIK, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class NDOMDIGPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NDOMDIGPMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x342CFD0", Offset = "0x342BDD0", VA = "0x18342CFD0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class MEPIAHBHCHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MEPIAHBHCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x342B590", Offset = "0x342A390", VA = "0x18342B590")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class EBIJOBFEELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EBIJOBFEELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3425550", Offset = "0x3424350", VA = "0x183425550")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class ODIFKCPOEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ODIFKCPOEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3430D60", Offset = "0x342FB60", VA = "0x183430D60")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class FLOJILPMNCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FLOJILPMNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3427260", Offset = "0x3426060", VA = "0x183427260")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<Guid, FJNMCJKCLFJ> DKBOCLCPGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly TimeSpan LOIFBJILDOO;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "10")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2B94460", Offset = "0x2B93260", VA = "0x182B94460", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2B94500", Offset = "0x2B93300", VA = "0x182B94500", Slot = "4")]
	public FKALOINEDDO ELGBPIMHCCH(Guid FCEHMDFKHII)
	{
		return default(FKALOINEDDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2B941B0", Offset = "0x2B92FB0", VA = "0x182B941B0", Slot = "5")]
	public bool DOHHNJJEEIG(Guid FCEHMDFKHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2B93F40", Offset = "0x2B92D40", VA = "0x182B93F40", Slot = "8")]
	public bool CIAEBEDAGAM(Guid FCEHMDFKHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2B94780", Offset = "0x2B93580", VA = "0x182B94780", Slot = "6")]
	public bool EMLKCGPPBBO(Guid FCEHMDFKHII, Task AACHDJBFHLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2B94B40", Offset = "0x2B93940", VA = "0x182B94B40", Slot = "7")]
	public bool MHMDELCBIKA(Guid FCEHMDFKHII, EDADMNIFEBK IOAMCBDOOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2B94470", Offset = "0x2B93270", VA = "0x182B94470", Slot = "9")]
	public Task<(EDADMNIFEBK, Task)> ELFEECBCIEM(Guid FCEHMDFKHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2B93CA0", Offset = "0x2B92AA0", VA = "0x182B93CA0")]
	private void CDGHJECEOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2B94E00", Offset = "0x2B93C00", VA = "0x182B94E00")]
	public COPENMDIFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal class ELNJHNLDPJP : KIMPLKCKBGH, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class MGFBGIMBLMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private readonly JHCBDEANCOK FAJDGHOJCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private readonly CancellationTokenSource DLBKDDIPECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly CancellationToken NCIELFIMNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool LALHPNGKFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool LFPHADEPEGI;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x342B770", Offset = "0x342A570", VA = "0x18342B770")]
		public MGFBGIMBLMB(JHCBDEANCOK FAJDGHOJCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x342B5F0", Offset = "0x342A3F0", VA = "0x18342B5F0")]
		public void CIAEBEDAGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x342B740", Offset = "0x342A540", VA = "0x18342B740", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BAPOCJNDFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public EIKHPNBLFLL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BAPOCJNDFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x34236F0", Offset = "0x34224F0", VA = "0x1834236F0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct AFMBOAODFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public EIKHPNBLFLL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public ELNJHNLDPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x34221A0", Offset = "0x3420FA0", VA = "0x1834221A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class GKAFAKEPAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GKAFAKEPAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3427950", Offset = "0x3426750", VA = "0x183427950")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FIGACHLKALE : IAsyncStateMachine
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
		public ELNJHNLDPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3426770", Offset = "0x3425570", VA = "0x183426770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7750", Offset = "0x6F6550", VA = "0x1806F7750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BFFEKIJDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public JHCBDEANCOK newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BFFEKIJDGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3423C10", Offset = "0x3422A10", VA = "0x183423C10")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3423CB0", Offset = "0x3422AB0", VA = "0x183423CB0")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3423CF0", Offset = "0x3422AF0", VA = "0x183423CF0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class AAEJMLOPGAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public AAEJMLOPGAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3422100", Offset = "0x3420F00", VA = "0x183422100")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct NFLKNGAJPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public JHCBDEANCOK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public ELNJHNLDPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public GFNMDKDIBLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private BFFEKIJDGHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x342ED30", Offset = "0x342DB30", VA = "0x18342ED30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private BBEJDMLGHJF JFHNHBLBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private GCCJIMCEGGI EPEDHGFADLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private JPIFLEHBIAL GOLOEFFHKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private MLPODPEFDLP NCMIIFAGALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private long CGMDIPHHDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private MGFBGIMBLMB DLAHEOEKNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool IKNMEABCGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Task MCDACCMDGNK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A450", Offset = "0x2B99250", VA = "0x182B9A450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GMNDHPBHOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x72D150", Offset = "0x72BF50", VA = "0x18072D150")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4A0", Offset = "0x2B992A0", VA = "0x182B9A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B99990", Offset = "0x2B98790", VA = "0x182B99990", Slot = "4")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B99480", Offset = "0x2B98280", VA = "0x182B99480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B99E30", Offset = "0x2B98C30", VA = "0x182B99E30")]
	[AsyncStateMachine(typeof(AFMBOAODFEN))]
	private Task GOGDHMADNAD(EIKHPNBLFLL FBPLAABBKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B99BE0", Offset = "0x2B989E0", VA = "0x182B99BE0")]
	private void GANEALHNEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B99600", Offset = "0x2B98400", VA = "0x182B99600")]
	private void EOKEKKKGFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B99280", Offset = "0x2B98080", VA = "0x182B99280")]
	private void CGDMOJODJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A090", Offset = "0x2B98E90", VA = "0x182B9A090")]
	private bool IPBINNFBJOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B99190", Offset = "0x2B97F90", VA = "0x182B99190")]
	[AsyncStateMachine(typeof(FIGACHLKALE))]
	private void AOAKPDJIBLK(int DEPHGHGHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A110", Offset = "0x2B98F10", VA = "0x182B9A110")]
	private void KNFNIANPGDM(out IDisposable BEGHPCPLPIO, out IDisposable MNJOIAONABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B99810", Offset = "0x2B98610", VA = "0x182B99810")]
	private bool FBGCENCHLGA(JHCBDEANCOK FAJDGHOJCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2B99DF0", Offset = "0x2B98BF0", VA = "0x182B99DF0")]
	private void GOFALOAIBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B99F50", Offset = "0x2B98D50", VA = "0x182B99F50")]
	[AsyncStateMachine(typeof(NFLKNGAJPNA))]
	private Task IFCPCMIDLBL(JHCBDEANCOK FAJDGHOJCAH, GFNMDKDIBLM GNGFNEHDMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A580", Offset = "0x2B99380", VA = "0x182B9A580")]
	public ELNJHNLDPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class LMCCKPJPOHN : ADMLJCBFOLB, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct EILIHEJKHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<BMCDEJCGGOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public LMCCKPJPOHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<BMCDEJCGGOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x35E6290", Offset = "0x35E5090", VA = "0x1835E6290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x35E64E0", Offset = "0x35E52E0", VA = "0x1835E64E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class ABDBIHLAHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public FJGCNLIMCNH message;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ABDBIHLAHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x35DE960", Offset = "0x35DD760", VA = "0x1835DE960")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class PDFOJKFMGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public FJGCNLIMCNH messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public PDFOJKFMGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x35F16C0", Offset = "0x35F04C0", VA = "0x1835F16C0")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BKHMGDMIKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BKHMGDMIKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x35E3420", Offset = "0x35E2220", VA = "0x1835E3420")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct MMMGMBPFLPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public LMCCKPJPOHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<FBNACAEIJNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x35EE880", Offset = "0x35ED680", VA = "0x1835EE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class FHGEFNBAJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public FJGCNLIMCNH operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FHGEFNBAJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x35E6DD0", Offset = "0x35E5BD0", VA = "0x1835E6DD0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct APHBBJBJDFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FJGCNLIMCNH operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public LMCCKPJPOHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private JLMDOPEJOBO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x35E1510", Offset = "0x35E0310", VA = "0x1835E1510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct GJCGNPIFJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<FBNACAEIJNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public LMCCKPJPOHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private JLMDOPEJOBO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x35E8B90", Offset = "0x35E7990", VA = "0x1835E8B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x35E8FE0", Offset = "0x35E7DE0", VA = "0x1835E8FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class PIHGNNAEFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public FBNACAEIJNK operation;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public PIHGNNAEFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x35F3110", Offset = "0x35F1F10", VA = "0x1835F3110")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct AHBAHNKILGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public FBNACAEIJNK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public LMCCKPJPOHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private global::EEKDJEFEHJA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x35DF050", Offset = "0x35DDE50", VA = "0x1835DF050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class GHCIKEJHCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GHCIKEJHCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x35E8550", Offset = "0x35E7350", VA = "0x1835E8550")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MDICOPGLHKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MDICOPGLHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x35EE280", Offset = "0x35ED080", VA = "0x1835EE280")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private DCCPDALJBAL BEFJCBGACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private DHMADMBPCHB CPANCLJBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private JMIKBAENDAP FCGCIOOKLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private TaskCompletionSource<BMCDEJCGGOJ> MALAJPNFJPP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA160", Offset = "0x2BA8F60", VA = "0x182BAA160", Slot = "7")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA760", Offset = "0x2BA9560", VA = "0x182BAA760", Slot = "6")]
	[AsyncStateMachine(typeof(EILIHEJKHAG))]
	public Task<BMCDEJCGGOJ> OCNBDHENNHD(CancellationToken EAEDBLMDKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9D30", Offset = "0x2BA8B30", VA = "0x182BA9D30", Slot = "4")]
	public void EMIPFJIHCOO(FJGCNLIMCNH HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9930", Offset = "0x2BA8730", VA = "0x182BA9930", Slot = "5")]
	public void DEGBLPKIIAP(FJGCNLIMCNH FIPCKDPOKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA8A0", Offset = "0x2BA96A0", VA = "0x182BAA8A0")]
	[AsyncStateMachine(typeof(MMMGMBPFLPM))]
	private Task OGGEPGBNNMF(FJGCNLIMCNH BOBJBDACGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAB20", Offset = "0x2BA9920", VA = "0x182BAAB20")]
	[AsyncStateMachine(typeof(APHBBJBJDFK))]
	private Task PECIOFLJIND(FJGCNLIMCNH LAANLFPLIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA9D0", Offset = "0x2BA97D0", VA = "0x182BAA9D0")]
	[AsyncStateMachine(typeof(GJCGNPIFJEO))]
	private Task<FBNACAEIJNK> OPAKDGLAGKB(FJGCNLIMCNH BOBJBDACGIL, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA4C0", Offset = "0x2BA92C0", VA = "0x182BAA4C0")]
	private JLMDOPEJOBO KHIOHCKEKMI(FJGCNLIMCNH IDOPEBAPBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA630", Offset = "0x2BA9430", VA = "0x182BAA630")]
	[AsyncStateMachine(typeof(AHBAHNKILGH))]
	private Task OBPLDOHEAIO(FBNACAEIJNK PDKFIDGDGCK, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA240", Offset = "0x2BA9040", VA = "0x182BAA240")]
	private FBNACAEIJNK JPEFENADDIM(FJGCNLIMCNH BOBJBDACGIL, JLMDOPEJOBO JJJBMPKIJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDCF0", Offset = "0x2DDCAF0", VA = "0x182DDDCF0")]
	private T PMIOGGOCPMD<T>(T GKFICKKHACC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9520", Offset = "0x2BA8320", VA = "0x182BA9520")]
	private FBNACAEIJNK CEMLAJFKAEG(FJGCNLIMCNH BOBJBDACGIL, JLMDOPEJOBO JJJBMPKIJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public LMCCKPJPOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA5E0", Offset = "0x2BA93E0", VA = "0x182BAA5E0")]
	[CompilerGenerated]
	private void NMHPGNFECOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Preserve]
internal sealed class MOPHBGBJAEI : DHMADMBPCHB, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class ODNIEKNHPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ODNIEKNHPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x35F11D0", Offset = "0x35EFFD0", VA = "0x1835F11D0")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class ILEBPCDHEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ILEBPCDHEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x35EB0A0", Offset = "0x35E9EA0", VA = "0x1835EB0A0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private IJKLBNCDOCH NJHEKOHHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ADMLJCBFOLB AFLJOBIKGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private OENDDEHNIIK DKBOCLCPGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private NLPBBIJHMGG HKJIPEEPLEG;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC8C0", Offset = "0x2BAB6C0", VA = "0x182BAC8C0", Slot = "6")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC450", Offset = "0x2BAB250", VA = "0x182BAC450", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BADF30", Offset = "0x2BACD30", VA = "0x182BADF30", Slot = "4")]
	public FKALOINEDDO LAJPCBLALIJ(FJGCNLIMCNH KKHHMNPIDHC)
	{
		return default(FKALOINEDDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD5B0", Offset = "0x2BAC3B0", VA = "0x182BAD5B0", Slot = "5")]
	public void KGMLOMPOLBF(Guid FCEHMDFKHII, Task AACHDJBFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC4F0", Offset = "0x2BAB2F0", VA = "0x182BAC4F0")]
	private void ELLPBAFEFMM(byte CKEICLLNJFC, int CEHFGPABGFL, object MFPJPJDDOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD830", Offset = "0x2BAC630", VA = "0x182BAD830")]
	private void KOHAKJOEJEO(DPADCGOOFED HPOOCPGAFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE410", Offset = "0x2BAD210", VA = "0x182BAE410")]
	private void LBBLOJMAKLP(DPADCGOOFED HPOOCPGAFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BACD00", Offset = "0x2BABB00", VA = "0x182BACD00")]
	private void HKGKEMDDCHL(DPADCGOOFED HPOOCPGAFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC5C0", Offset = "0x2BAB3C0", VA = "0x182BAC5C0")]
	private EDADMNIFEBK FBIKHAOOIFG(FJGCNLIMCNH IDOPEBAPBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE6F0", Offset = "0x2BAD4F0", VA = "0x182BAE6F0")]
	private void PEGLKJDKEAD(FJGCNLIMCNH LAANLFPLIIE, EDADMNIFEBK IOAMCBDOOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BACFB0", Offset = "0x2BABDB0", VA = "0x182BACFB0")]
	private bool HPNBAIGBHKK(FJGCNLIMCNH LAANLFPLIIE, EDADMNIFEBK IOAMCBDOOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BACA30", Offset = "0x2BAB830", VA = "0x182BACA30")]
	private bool GGKBKBCNNLP(FJGCNLIMCNH MCOBMLMFHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD2B0", Offset = "0x2BAC0B0", VA = "0x182BAD2B0")]
	private bool IFPKNBJFLFG(byte CKEICLLNJFC, ExitGames.Client.Photon.Hashtable HPOOCPGAFFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public MOPHBGBJAEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class BOABJLBPFMD : KBANOPGIDKE, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class GOCLHABBLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public BMCDEJCGGOJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public BOABJLBPFMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public FJGCNLIMCNH roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GOCLHABBLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x34279C0", Offset = "0x34267C0", VA = "0x1834279C0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x3427A30", Offset = "0x3426830", VA = "0x183427A30")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct CPEHOLCJLOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public BOABJLBPFMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public FJGCNLIMCNH roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<EDADMNIFEBK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x34248C0", Offset = "0x34236C0", VA = "0x1834248C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3424E20", Offset = "0x3423C20", VA = "0x183424E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GDBHKIFCGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public BMCDEJCGGOJ operationType;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GDBHKIFCGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3427590", Offset = "0x3426390", VA = "0x183427590")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class JHKKMABHDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JHKKMABHDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3429780", Offset = "0x3428580", VA = "0x183429780")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x34297F0", Offset = "0x34285F0", VA = "0x1834297F0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3429860", Offset = "0x3428660", VA = "0x183429860")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct ICMKGAEGGID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public BOABJLBPFMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private JHKKMABHDCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private FKALOINEDDO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private EDADMNIFEBK <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<(EDADMNIFEBK validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x34285E0", Offset = "0x34273E0", VA = "0x1834285E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3428CD0", Offset = "0x3427AD0", VA = "0x183428CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private IJKLBNCDOCH NJHEKOHHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private DHMADMBPCHB CPANCLJBHKH;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2B91C30", Offset = "0x2B90A30", VA = "0x182B91C30", Slot = "5")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2B91F40", Offset = "0x2B90D40", VA = "0x182B91F40", Slot = "4")]
	[AsyncStateMachine(typeof(CPEHOLCJLOP))]
	private Task<EDADMNIFEBK> KJFGLGBPOIE(FJGCNLIMCNH IDOPEBAPBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2B91CE0", Offset = "0x2B90AE0", VA = "0x182B91CE0")]
	private bool JPDNKDNFGLM(BMCDEJCGGOJ CPBINDABFHD, out EDADMNIFEBK BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2B92080", Offset = "0x2B90E80", VA = "0x182B92080")]
	[AsyncStateMachine(typeof(ICMKGAEGGID))]
	private Task<EDADMNIFEBK> OBBDHLDEJCO(FJGCNLIMCNH BOBJBDACGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public BOABJLBPFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Preserve]
internal sealed class ICGPOPNNKAN : IPLOKIPJJIH, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct NAJANLOCKME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<ENNEEGPPNHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public ICGPOPNNKAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<EKLMJEDNPMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x35EF5B0", Offset = "0x35EE3B0", VA = "0x1835EF5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x35EF790", Offset = "0x35EE590", VA = "0x1835EF790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class FBIFMCNFNJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FBIFMCNFNJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x35E6D20", Offset = "0x35E5B20", VA = "0x1835E6D20")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct AICFIEFLLAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<EKLMJEDNPMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public ICGPOPNNKAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public JHCBDEANCOK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private FBIFMCNFNJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<ILNPNFMALGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x35DF590", Offset = "0x35DE390", VA = "0x1835DF590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x35DF950", Offset = "0x35DE750", VA = "0x1835DF950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class BNEGMIJHLHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BNEGMIJHLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x146E8E0", Offset = "0x146D6E0", VA = "0x18146E8E0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(BJMHDOIMFLB sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly (MOAJEGAOKON superRoomData, string unityAssetId, MOAJEGAOKON subRoomData) DMEMFIEJNHG;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1EF0", Offset = "0x2BA0CF0", VA = "0x182BA1EF0", Slot = "5")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1F60", Offset = "0x2BA0D60", VA = "0x182BA1F60", Slot = "4")]
	[AsyncStateMachine(typeof(NAJANLOCKME))]
	public Task<ENNEEGPPNHD> KFEHEAKNDHN(CEJMOEANPLC PDHDLCNGDKN, JHCBDEANCOK IOGMCGLFEHG, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2BA20E0", Offset = "0x2BA0EE0", VA = "0x182BA20E0")]
	[AsyncStateMachine(typeof(AICFIEFLLAM))]
	private Task<EKLMJEDNPMN> KFOOHGJKIIJ(JHCBDEANCOK IOGMCGLFEHG, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1CC0", Offset = "0x2BA0AC0", VA = "0x182BA1CC0")]
	private ENNEEGPPNHD EEHFICFDCAC(JHCBDEANCOK IOGMCGLFEHG, EKLMJEDNPMN GABMOPNNFMM, long KMHHOKHNCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2260", Offset = "0x2BA1060", VA = "0x182BA2260")]
	private (MOAJEGAOKON, string, MOAJEGAOKON) NMBKHLNLBGA(JHCBDEANCOK IOGMCGLFEHG, EKLMJEDNPMN GABMOPNNFMM, long KMHHOKHNCJA)
	{
		return default((MOAJEGAOKON, string, MOAJEGAOKON));
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public ICGPOPNNKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[Preserve]
internal sealed class NJIKDMGPPGF : JMIKBAENDAP, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class IDHFEJGEHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public IDHFEJGEHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x40E9130", Offset = "0x40E7F30", VA = "0x1840E9130")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct LBFPBOEANCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NJIKDMGPPGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public JLMDOPEJOBO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x40EACE0", Offset = "0x40E9AE0", VA = "0x1840EACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x40EB140", Offset = "0x40E9F40", VA = "0x1840EB140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct DOOPLMPDFIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NJIKDMGPPGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JLMDOPEJOBO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x40E5D60", Offset = "0x40E4B60", VA = "0x1840E5D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x40E6340", Offset = "0x40E5140", VA = "0x1840E6340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class GANLAKCEOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GANLAKCEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x40E7750", Offset = "0x40E6550", VA = "0x1840E7750")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AMNJPDFCAEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public FJGCNLIMCNH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NJIKDMGPPGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public JLMDOPEJOBO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private NAGOEMOCHDF <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private BMDFDHDDIKA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x35DFF30", Offset = "0x35DED30", VA = "0x1835DFF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x35E09C0", Offset = "0x35DF7C0", VA = "0x1835E09C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private EBKAECJIOND FCNFAKEGDIG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private CMPGKADDOBE KDKDECOHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3430360", Offset = "0x342F160", VA = "0x183430360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x342FAA0", Offset = "0x342E8A0", VA = "0x18342FAA0", Slot = "8")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x342FB30", Offset = "0x342E930", VA = "0x18342FB30", Slot = "4")]
	[AsyncStateMachine(typeof(LBFPBOEANCN))]
	public Task<FJGCNLIMCNH> IHKILDNPJGJ(FJGCNLIMCNH BOBJBDACGIL, JLMDOPEJOBO JJJBMPKIJJD, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x34300B0", Offset = "0x342EEB0", VA = "0x1834300B0", Slot = "5")]
	[AsyncStateMachine(typeof(DOOPLMPDFIP))]
	public Task<FJGCNLIMCNH> LNPECPHAEIP(CancellationToken ADCKNELPFOJ, JLMDOPEJOBO JJJBMPKIJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x342FCA0", Offset = "0x342EAA0", VA = "0x18342FCA0", Slot = "6")]
	public OGKMJPOHBDC JJCPKDHDDGE(FBNACAEIJNK KDBBBFCLHNO, CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3430410", Offset = "0x342F210", VA = "0x183430410", Slot = "7")]
	public OGKMJPOHBDC POEMGCEBOPG(FBNACAEIJNK KDBBBFCLHNO, CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x342FF30", Offset = "0x342ED30", VA = "0x18342FF30")]
	[AsyncStateMachine(typeof(AMNJPDFCAEO))]
	private Task<FJGCNLIMCNH> KBPMJKKGAPP(FJGCNLIMCNH BOBJBDACGIL, JLMDOPEJOBO JJJBMPKIJJD, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3252580", Offset = "0x3251380", VA = "0x183252580")]
	private static byte[] EELGIIGOFOD(FJGCNLIMCNH HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3430210", Offset = "0x342F010", VA = "0x183430210")]
	private static string NHIOMGGHHLL(byte[] KJLFMKEMDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public NJIKDMGPPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class EGKBFIPEMFN : IJKLBNCDOCH, FLHIBGCAMJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private DFIABPFMAFI LHGBFEDOMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private DCCPDALJBAL BEFJCBGACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private LDKOGKFELIG MJNKGJLJINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private MLPODPEFDLP NCMIIFAGALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private AOCHCJABCKH NBLFFKFIJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private JPIFLEHBIAL GOLOEFFHKCK;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B60", Offset = "0x2B97960", VA = "0x182B98B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static EDADMNIFEBK INLBLAFDBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B00", Offset = "0x2B97900", VA = "0x182B98B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2B98940", Offset = "0x2B97740", VA = "0x182B98940", Slot = "7")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2B984D0", Offset = "0x2B972D0", VA = "0x182B984D0", Slot = "4")]
	public EDADMNIFEBK EBALGJPPDHO(HHODDDLIHOO DLODLNNFJAK, BMCDEJCGGOJ FKHJNKOHGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2B98660", Offset = "0x2B97460", VA = "0x182B98660", Slot = "5")]
	public EDADMNIFEBK EIFFKOIAPPL(HHODDDLIHOO MAHCEDMJMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2B98260", Offset = "0x2B97060", VA = "0x182B98260", Slot = "6")]
	public EDADMNIFEBK CGBMAHOCNMG(HHODDDLIHOO MAHCEDMJMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2B98AA0", Offset = "0x2B978A0", VA = "0x182B98AA0")]
	private static EDADMNIFEBK HEDHDNLCAHM(LIALGDLIBHJ LFBMHKKDNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public EGKBFIPEMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class KPGNMANBGHA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9110", Offset = "0x2BA7F10", VA = "0x182BA9110")]
	public KPGNMANBGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xA53BB0", Offset = "0xA529B0", VA = "0x180A53BB0")]
	public KPGNMANBGHA(string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[Preserve]
internal sealed class DHKIOMIPPAE : MFOKDGLCBJK, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct AABKHJEBNON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public DHKIOMIPPAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GPNEMJHGMNP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private global::EEKDJEFEHJA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private CEJMOEANPLC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private COEKMOJHEKC <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private CEJMOEANPLC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<EDADMNIFEBK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x3421950", Offset = "0x3420750", VA = "0x183421950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x34220B0", Offset = "0x3420EB0", VA = "0x1834220B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct MKFMCFOAHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public DHKIOMIPPAE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x342C090", Offset = "0x342AE90", VA = "0x18342C090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct DPMKGOHJGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public DHKIOMIPPAE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3425000", Offset = "0x3423E00", VA = "0x183425000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct GOLMECMEDCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public DHKIOMIPPAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x3427BE0", Offset = "0x34269E0", VA = "0x183427BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct NELBBGGEDNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public DHKIOMIPPAE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x342DEE0", Offset = "0x342CCE0", VA = "0x18342DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct BBOKNBFOEKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public DHKIOMIPPAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public NAEECGFNFPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private global::EEKDJEFEHJA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x34237A0", Offset = "0x34225A0", VA = "0x1834237A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static readonly TimeSpan OMKCPDGHKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private JMIKBAENDAP FCGCIOOKLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private DCCPDALJBAL BEFJCBGACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private AOCHCJABCKH NBLFFKFIJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private CancellationTokenSource HJCOFNPMPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Task NCGLAMPPMKB;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2B95AA0", Offset = "0x2B948A0", VA = "0x182B95AA0", Slot = "6")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x184D8B0", Offset = "0x184C6B0", VA = "0x18184D8B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2B95CE0", Offset = "0x2B94AE0", VA = "0x182B95CE0", Slot = "4")]
	[AsyncStateMachine(typeof(AABKHJEBNON))]
	public Task<EDADMNIFEBK> GEGFJFGPFMM(GPNEMJHGMNP MKGFLPPMKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2B96650", Offset = "0x2B95450", VA = "0x182B96650", Slot = "5")]
	[AsyncStateMachine(typeof(MKFMCFOAHLN))]
	public Task NGGJGJGNMGK([Optional] CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x184D8B0", Offset = "0x184C6B0", VA = "0x18184D8B0")]
	public void PIOLLHADNEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2B957E0", Offset = "0x2B945E0", VA = "0x182B957E0")]
	private COEKMOJHEKC CAMOHGHEKNA(GPNEMJHGMNP MKGFLPPMKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2B95F30", Offset = "0x2B94D30", VA = "0x182B95F30")]
	[AsyncStateMachine(typeof(DPMKGOHJGFC))]
	private Task INLNKAIEPKP(FAFEPBBAFLL KBICBGPAOHG, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2B96060", Offset = "0x2B94E60", VA = "0x182B96060")]
	[AsyncStateMachine(typeof(GOLMECMEDCE))]
	private Task JPCCCMIABLC([Optional] CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2B96520", Offset = "0x2B95320", VA = "0x182B96520")]
	[AsyncStateMachine(typeof(NELBBGGEDNP))]
	private Task NGFKBHOMEHB(TimeSpan CFJOBMBABIN, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2B962B0", Offset = "0x2B950B0", VA = "0x182B962B0")]
	private Task NABFIMIKFML(NAEECGFNFPJ JDHHIBOGJMN, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2B96180", Offset = "0x2B94F80", VA = "0x182B96180")]
	[AsyncStateMachine(typeof(BBOKNBFOEKL))]
	private Task KNLEGHEDBHH(NAEECGFNFPJ JDHHIBOGJMN, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2B95E20", Offset = "0x2B94C20", VA = "0x182B95E20")]
	private bool GPFLACOIDDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public DHKIOMIPPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[Preserve]
internal class NPGOCAIOKAM : LDKOGKFELIG, FLHIBGCAMJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct ICGLHGPBNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public NPGOCAIOKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private global::EEKDJEFEHJA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x40E8E00", Offset = "0x40E7C00", VA = "0x1840E8E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private EPICHIOPPLH GFKDEPHPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private IJKLBNCDOCH NJHEKOHHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private JMIKBAENDAP FCGCIOOKLEJ;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x34306E0", Offset = "0x342F4E0", VA = "0x1834306E0", Slot = "6")]
	public void FNJOFAEFPIL(IAJPIHCHKKO NHBDFDDDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3430690", Offset = "0x342F490", VA = "0x183430690", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3430AD0", Offset = "0x342F8D0", VA = "0x183430AD0", Slot = "5")]
	[AsyncStateMachine(typeof(ICGLHGPBNFC))]
	public Task OHIDPGGMLNC(string GEMBNOGNCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3430900", Offset = "0x342F700", VA = "0x183430900", Slot = "4")]
	public EDADMNIFEBK GPFLACOIDDO(HHODDDLIHOO DLODLNNFJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x34309C0", Offset = "0x342F7C0", VA = "0x1834309C0")]
	private IFMHFGEOMHF LCAKEPMFIGN(string GEMBNOGNCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public NPGOCAIOKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class KMLJNFIBBAA
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8E70", Offset = "0x2BA7C70", VA = "0x182BA8E70")]
	public static void KAJHKKCEFOD(HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8940", Offset = "0x2BA7740", VA = "0x182BA8940")]
	internal static void GKMNHBNHPGA(HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9030", Offset = "0x2BA7E30", VA = "0x182BA9030")]
	internal static void MOEAPOMCNJJ(HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8A20", Offset = "0x2BA7820", VA = "0x182BA8A20")]
	internal static void IGHPFJIGBDN(HGCFMABKDDJ FLBJMLJLEGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class HIMHFLIAFIN : global::CBGNNHAEMGG<FJGCNLIMCNH>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class EIPOOEOHLLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public FJGCNLIMCNH message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EIPOOEOHLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x35E6970", Offset = "0x35E5770", VA = "0x1835E6970")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly HIMHFLIAFIN EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const string GLIBKLCPLNM = "pl";

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0E10", Offset = "0x2B9FC10", VA = "0x182BA0E10")]
	public ExitGames.Client.Photon.Hashtable CLPGJOCDFOA(FJGCNLIMCNH HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0E90", Offset = "0x2B9FC90", VA = "0x182BA0E90", Slot = "5")]
	protected override void KEFNKJKCNMG(FJGCNLIMCNH HDKJDEIGPPL, IDictionary<object, object> JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0FD0", Offset = "0x2B9FDD0", VA = "0x182BA0FD0", Slot = "6")]
	public override FJGCNLIMCNH MNOLKCHHLIP(IDictionary<object, object> JLFCOOGLPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0C90", Offset = "0x2B9FA90", VA = "0x182BA0C90")]
	private static void CGAIAMLGLCP(string LNPKKMJLCID, FJGCNLIMCNH HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2BA15F0", Offset = "0x2BA03F0", VA = "0x182BA15F0")]
	public HIMHFLIAFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1220", Offset = "0x2BA0020", VA = "0x182BA1220")]
	[CompilerGenerated]
	internal static string OOMFODMAKDL(ENNEEGPPNHD OICHLBNIOCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class HBAKOKMCMIG
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static EDADMNIFEBK INLBLAFDBII
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B00", Offset = "0x2B97900", VA = "0x182B98B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0440", Offset = "0x2B9F240", VA = "0x182BA0440")]
	public static bool EMJMHFHDCFL(this EDADMNIFEBK IOAMCBDOOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2B98AA0", Offset = "0x2B978A0", VA = "0x182B98AA0")]
	public static EDADMNIFEBK HEDHDNLCAHM(LIALGDLIBHJ GDMANHPKELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0430", Offset = "0x2B9F230", VA = "0x182BA0430")]
	public static EDADMNIFEBK DHNNECAIIIC(params EDADMNIFEBK[] MCCHLHFEOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0230", Offset = "0x2B9F030", VA = "0x182BA0230")]
	public static EDADMNIFEBK BMFGFKEMJDJ(IEnumerable<EDADMNIFEBK> MCCHLHFEOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FFC0", Offset = "0x2B9EDC0", VA = "0x182B9FFC0")]
	public static string BIECMOCDHCL(this EDADMNIFEBK BMBFIGGJLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class OMLDHPMMBFH : IJNAJOEFAJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate EDADMNIFEBK CHGHHNOCONJ([NotNull] HHODDDLIHOO GNBHGCMNEON);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class JKLHBBKMLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public HHODDDLIHOO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JKLHBBKMLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x40E9C50", Offset = "0x40E8A50", VA = "0x1840E9C50")]
		internal EDADMNIFEBK <Validate>b__0(CHGHHNOCONJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	protected readonly HashSet<CHGHHNOCONJ> HIIMGBHKCNA;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3436DB0", Offset = "0x3435BB0", VA = "0x183436DB0", Slot = "4")]
	public void BPAOILJFNCE(CHGHHNOCONJ MNEIMAKMEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3436D50", Offset = "0x3435B50", VA = "0x183436D50", Slot = "5")]
	public void AIIJDAIMEMC(CHGHHNOCONJ MNEIMAKMEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3437030", Offset = "0x3435E30", VA = "0x183437030", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3436E10", Offset = "0x3435C10", VA = "0x183436E10")]
	protected EDADMNIFEBK CKHMELEEAGD(HHODDDLIHOO MAHCEDMJMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3437080", Offset = "0x3435E80", VA = "0x183437080")]
	protected OMLDHPMMBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class GNEMBILAGGE : OMLDHPMMBFH, DFIABPFMAFI, IJNAJOEFAJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class LIDHPCDCGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public EDADMNIFEBK result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LIDHPCDCGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x35EDB40", Offset = "0x35EC940", VA = "0x1835EDB40")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EEB0", Offset = "0x2B9DCB0", VA = "0x182B9EEB0")]
	[Preserve]
	public GNEMBILAGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B9ED30", Offset = "0x2B9DB30", VA = "0x182B9ED30", Slot = "8")]
	public EDADMNIFEBK BPNGKKIGPCJ(HHODDDLIHOO MAHCEDMJMAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class HPGKEOANJDE : OMLDHPMMBFH, EPICHIOPPLH, IJNAJOEFAJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EEPBLDCDPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public EDADMNIFEBK result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EEPBLDCDPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x35E6230", Offset = "0x35E5030", VA = "0x1835E6230")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EEB0", Offset = "0x2B9DCB0", VA = "0x182B9EEB0")]
	[Preserve]
	public HPGKEOANJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1B40", Offset = "0x2BA0940", VA = "0x182BA1B40", Slot = "8")]
	public EDADMNIFEBK GPFLACOIDDO(HHODDDLIHOO GAHFLBDIKFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum CIDAOGNGFEK
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
internal static class DMFFKKGFGFJ
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class ELMADJBNCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public global::EEKDJEFEHJA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ELMADJBNCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3425B20", Offset = "0x3424920", VA = "0x183425B20")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public const string GKMDBOEMAIO = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public const string LLHLHKBMBED = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B96A40", Offset = "0x2B95840", VA = "0x182B96A40")]
	public static global::EEKDJEFEHJA<string> EHGGEAJMJGG([Optional] string AHHMFMOCNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B96C70", Offset = "0x2B95A70", VA = "0x182B96C70")]
	private static void NDEBCFAJKDO(string BIMCDHOFDCP, AFKKOELPLLE BIEDEPNABLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B96940", Offset = "0x2B95740", VA = "0x182B96940")]
	private static void BBKLHNLCOCL(string BIMCDHOFDCP, AFKKOELPLLE BIEDEPNABLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B96B10", Offset = "0x2B95910", VA = "0x182B96B10")]
	public static void HECDIDILCOD(global::EEKDJEFEHJA<string> BIEDEPNABLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B96D70", Offset = "0x2B95B70", VA = "0x182B96D70")]
	public static string OBOPNKMPJAM(FJGCNLIMCNH IDOPEBAPBGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class ECEKGGBIEHH
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B97E00", Offset = "0x2B96C00", VA = "0x182B97E00")]
	public static void IBCIIDKAJPH(this PKJMFNAKBLI IJNIKOCLGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B97CE0", Offset = "0x2B96AE0", VA = "0x182B97CE0")]
	public static void DHHHBOAGFJO(this PKJMFNAKBLI IJNIKOCLGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B97CF0", Offset = "0x2B96AF0", VA = "0x182B97CF0")]
	private static void ECAHNEOGLMM(this PKJMFNAKBLI IJNIKOCLGEN, bool MMONKEKNCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class CLNKCCNBFNM : BNJFENEMBMH, CIDKPIOBPBN, CPDOJLCJIOI, BKFFFBMIAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly CIDKPIOBPBN ADPAHFHHPLJ;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public HHODDDLIHOO LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B93840", Offset = "0x2B92640", VA = "0x182B93840", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int HEENLDKOBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B93410", Offset = "0x2B92210", VA = "0x182B93410", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int OCADPEKLKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B937F0", Offset = "0x2B925F0", VA = "0x182B937F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool LNHCHPFPGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int DCCBIAOLAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF0", Offset = "0x74CAF0", VA = "0x18074DCF0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JGHGIOFDGEK.MDDIPHIJLBL MOBJBLDENPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MLJKODGNBLE BNDBFNHDNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B93730", Offset = "0x2B92530", VA = "0x182B93730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B935F0", Offset = "0x2B923F0", VA = "0x182B935F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> ABBMGOBIOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<HHODDDLIHOO> GHBHGLJMHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action HOEAFAAFHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B938F0", Offset = "0x2B926F0", VA = "0x182B938F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B93990", Offset = "0x2B92790", VA = "0x182B93990", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x72A130", Offset = "0x728F30", VA = "0x18072A130")]
	public CLNKCCNBFNM(CIDKPIOBPBN ADPAHFHHPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B93540", Offset = "0x2B92340", VA = "0x182B93540", Slot = "8")]
	public bool DIPCLEPGGPG(byte CKEICLLNJFC, ExitGames.Client.Photon.Hashtable MOJOMMOLBPJ, GCHBHNIMADI ADFEEJBGKKC, SendOptions NDLNPBNIHKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B93690", Offset = "0x2B92490", VA = "0x182B93690", Slot = "29")]
	public HHODDDLIHOO EHHHEFFDIMG(int HBEHGKFGNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B93460", Offset = "0x2B92260", VA = "0x182B93460", Slot = "16")]
	public HHODDDLIHOO COAFHJOKEDE(int DKMNGHALNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "19")]
	public void PLDDFMLGFOC(object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "20")]
	public void MJGHPEEGHBI(object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "21")]
	public void HIKOHEHLBNE(object JJFHDFJGCDG, bool PDAPDNOJLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B93890", Offset = "0x2B92690", VA = "0x182B93890", Slot = "22")]
	public IDisposable ILKIHKOLMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "23")]
	private bool JDHIOJEFLOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "24")]
	public void PHPEKLIAKMK(StringBuilder CLCNHBPOBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B937D0", Offset = "0x2B925D0", VA = "0x182B937D0", Slot = "25")]
	public bool FFPHOGDAIAK(bool FALJJBNFGPA, out string OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public void IDOENLFENPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1B9CDD0", Offset = "0x1B9BBD0", VA = "0x181B9CDD0", Slot = "28")]
	public void PPGAANPGILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct DPADCGOOFED
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const string PCOMLFFHLOD = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public const string MLIJOPCDKLD = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly IDictionary<object, object> HPOOCPGAFFO;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x895100", Offset = "0x893F00", VA = "0x180895100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6507B0", Offset = "0x64F5B0", VA = "0x1806507B0")]
	public DPADCGOOFED(IDictionary<object, object> HPOOCPGAFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B97160", Offset = "0x2B95F60", VA = "0x182B97160")]
	public bool KEJLDLKBMBA(out FJGCNLIMCNH HDKJDEIGPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B96E30", Offset = "0x2B95C30", VA = "0x182B96E30")]
	public Guid ADJECMGHPGM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B97000", Offset = "0x2B95E00", VA = "0x182B97000")]
	public EDADMNIFEBK ILLMBHPJENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B96F10", Offset = "0x2B95D10", VA = "0x182B96F10")]
	public static ExitGames.Client.Photon.Hashtable GLBIKEOEKPG(FJGCNLIMCNH HDKJDEIGPPL, EDADMNIFEBK IOAMCBDOOBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GCDPLALGFIL
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D6F0", Offset = "0x2B9C4F0", VA = "0x182B9D6F0")]
	public static string NALANFECPKB(this JHCBDEANCOK KIBPNBFNHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D670", Offset = "0x2B9C470", VA = "0x182B9D670")]
	public static bool FDOOPNGDGAF(this JHCBDEANCOK KIBPNBFNHLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct KPKKOHNGCPF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct LKJMMBFMOHP : IAsyncStateMachine
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
		public KPKKOHNGCPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x35EE070", Offset = "0x35ECE70", VA = "0x1835EE070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CancellationTokenSource DLBKDDIPECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private Task BCLOPCAMFLH;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9350", Offset = "0x2BA8150", VA = "0x182BA9350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task JPLKLKPGNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9150", Offset = "0x2BA7F50", VA = "0x182BA9150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9380", Offset = "0x2BA8180", VA = "0x182BA9380")]
	public KPKKOHNGCPF(CancellationToken ADCKNELPFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7FD0", VA = "0x182BA91D0")]
	[AsyncStateMachine(typeof(LKJMMBFMOHP))]
	public Task BPCLMIGGBIO(Func<CancellationToken, List<Task>> PBEHNFHHOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA8100", VA = "0x182BA9300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct BKMDBBMLEPK<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct IEKDDFAFLHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<global::EMFHPGMFAOO<global::NGNOGAAMAIJ<TData>, BMIGOOHOEBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public global::BKMDBBMLEPK<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private CEJMOEANPLC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<global::EMFHPGMFAOO<byte[], BMIGOOHOEBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F35990", Offset = "0x1F34790", VA = "0x181F35990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F360F0", Offset = "0x1F34EF0", VA = "0x181F360F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private readonly global::LOPHDIBPEHK<TGetDataArg, TData> DPDFKNGGDCM;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6507B0", Offset = "0x64F5B0", VA = "0x1806507B0")]
	internal BKMDBBMLEPK(global::LOPHDIBPEHK<TGetDataArg, TData> HKPDNJBMEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A870", Offset = "0x2D19670", VA = "0x182D1A870")]
	[AsyncStateMachine(typeof(global::BKMDBBMLEPK<, >.IEKDDFAFLHN))]
	public Task<global::EMFHPGMFAOO<global::NGNOGAAMAIJ<TData>, BMIGOOHOEBL>> LOEPHLANJEA(TGetDataArg KJLFMKEMDIK, string IPOMOCENKLE, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class LAKPBNCGFGM
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x270C170", Offset = "0x270AF70", VA = "0x18270C170")]
	public static global::BKMDBBMLEPK<TGetDataArg, TData> KCNAIILPDFM<TGetDataArg, TData>(global::LOPHDIBPEHK<TGetDataArg, TData> HKPDNJBMEMK)
	{
		return default(global::BKMDBBMLEPK<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class CIBCBPALFJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly NABPMBKNMNN ALGPBBAKHCO;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private const string BBNBMKMDEMJ = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private const string NJAEMIKECHD = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string APJNPKPMONC = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string ADIPAOIGDNB = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string OKCBMEHBPMN = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private string FDIKKLIDJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private long? KGLMBKNCJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private long? GNKGCBMAEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private AMHDNJGMOGN LLBAGMEGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? INLLAEMNODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private bool LDFLIGDJDEE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string MHLFEGMHMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long MNHCGLANJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B93280", Offset = "0x2B92080", VA = "0x182B93280")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long NKKNFEMNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B92880", Offset = "0x2B91680", VA = "0x182B92880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AMHDNJGMOGN BDKAPHGLAND
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6631E0", Offset = "0x661FE0", VA = "0x1806631E0")]
		get
		{
			return default(AMHDNJGMOGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B932E0", Offset = "0x2B920E0", VA = "0x182B932E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long MCHBFLCKBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B93220", Offset = "0x2B92020", VA = "0x182B93220")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B933D0", Offset = "0x2B921D0", VA = "0x182B933D0")]
	[Preserve]
	public CIBCBPALFJL([MAEEAOEDELI(null)] NABPMBKNMNN ALGPBBAKHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B92CC0", Offset = "0x2B91AC0", VA = "0x182B92CC0")]
	private void GCEOEIHJNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B92E70", Offset = "0x2B91C70", VA = "0x182B92E70")]
	public void GIFGGBOILMH(long HMOGFNMOLJM, long KMHHOKHNCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B92BD0", Offset = "0x2B919D0", VA = "0x182B92BD0")]
	public void GAMMGJGFPJH(string MMOCLOLOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B928E0", Offset = "0x2B916E0", VA = "0x182B928E0")]
	public void FKAECECDKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class OGKMJPOHBDC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct NFEFGKLMLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public FJGCNLIMCNH roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public OGKMJPOHBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<OCFHDOCKNJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x40ED160", Offset = "0x40EBF60", VA = "0x1840ED160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x40ED470", Offset = "0x40EC270", VA = "0x1840ED470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EEFBKNMAABN<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class BCPCGFGBNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public FJGCNLIMCNH roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BCPCGFGBNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x40E4E40", Offset = "0x40E3C40", VA = "0x1840E4E40")]
		internal FJGCNLIMCNH <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct ALDHEENOLMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<OCFHDOCKNJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public FJGCNLIMCNH roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public OGKMJPOHBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private NAGOEMOCHDF <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<OCFHDOCKNJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x40E4140", Offset = "0x40E2F40", VA = "0x1840E4140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x40E4910", Offset = "0x40E3710", VA = "0x1840E4910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct DBLIIKHNIKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public OGKMJPOHBDC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40E5460", Offset = "0x40E4260", VA = "0x1840E5460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class KCNAMLIFEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public KCNAMLIFEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x40EA460", Offset = "0x40E9260", VA = "0x1840EA460")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class EGBONBMDEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EGBONBMDEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x40E6390", Offset = "0x40E5190", VA = "0x1840E6390")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class JLBCENCFDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JLBCENCFDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x40E9C80", Offset = "0x40E8A80", VA = "0x1840E9C80")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class ILHCDJMLNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ILHCDJMLNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x40E99E0", Offset = "0x40E87E0", VA = "0x1840E99E0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class FGNAFBCLNAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public OGKMJPOHBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FGNAFBCLNAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x40E6810", Offset = "0x40E5610", VA = "0x1840E6810")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class FIMFLDEHCBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public OGKMJPOHBDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FIMFLDEHCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x40E6A90", Offset = "0x40E5890", VA = "0x1840E6A90")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly Guid OPIBLPLJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly FBNACAEIJNK BFNEPCEELIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly CMPGKADDOBE FIAGILNCDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly CPDOJLCJIOI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly BKFFFBMIAIG GNMBNBALJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool MNEBNAJFDIM;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3432490", Offset = "0x3431290", VA = "0x183432490")]
	public OGKMJPOHBDC(FBNACAEIJNK PDKFIDGDGCK, CMPGKADDOBE FIAGILNCDCH, CPDOJLCJIOI IJNIKOCLGEN, BKFFFBMIAIG GNMBNBALJBL, CEJMOEANPLC PDHDLCNGDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x34312F0", Offset = "0x34300F0", VA = "0x1834312F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x34312F0", Offset = "0x34300F0", VA = "0x1834312F0")]
	public void ICECJBKABMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3431EA0", Offset = "0x3430CA0", VA = "0x183431EA0")]
	public void NMECLLBMGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x34319F0", Offset = "0x34307F0", VA = "0x1834319F0")]
	public void JKAGAPAPICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3431500", Offset = "0x3430300", VA = "0x183431500")]
	[AsyncStateMachine(typeof(NFEFGKLMLGK))]
	internal Task<FJGCNLIMCNH> HDFFCCAPDBO(CEJMOEANPLC PDHDLCNGDKN, FJGCNLIMCNH IDOPEBAPBGI, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3252580", Offset = "0x3251380", VA = "0x183252580")]
	private static byte[] IFCBCEPDJHD<T>(T HDKJDEIGPPL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3252870", Offset = "0x3251670", VA = "0x183252870")]
	private static T NMDKBGIGIFA<T>(MessageParser<T> OMFKPLLLDME, byte[] HDKJDEIGPPL, T JJPEDAIHJMM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3431FF0", Offset = "0x3430DF0", VA = "0x183431FF0")]
	[AsyncStateMachine(typeof(ALDHEENOLMP))]
	private Task<OCFHDOCKNJL> OEBGNPFBLDE(FJGCNLIMCNH IDOPEBAPBGI, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x3252590", Offset = "0x3251390", VA = "0x183252590")]
	[AsyncStateMachine(typeof(FJBBLOIFBHJ))]
	internal Task<T> MDHFGPILAKH<T>(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task<T>> PCKLOEHLHEN, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3431D50", Offset = "0x3430B50", VA = "0x183431D50")]
	[AsyncStateMachine(typeof(DBLIIKHNIKG))]
	internal Task MDHFGPILAKH(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task> PCKLOEHLHEN, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3432390", Offset = "0x3431190", VA = "0x183432390")]
	public FJGCNLIMCNH PMALMLCAELM(NAGOEMOCHDF LGDEOFMNENO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3431490", Offset = "0x3430290", VA = "0x183431490")]
	public MKGGJMJOFJM GIOOPKCCJFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x3431CE0", Offset = "0x3430AE0", VA = "0x183431CE0")]
	public IDGGIHMDFCC KMJDGLNOLIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x3431250", Offset = "0x3430050", VA = "0x183431250")]
	public GDOJNIPBOOE DCBJEJIFHCG([Optional] LPMCFBMFCPH? PJIGCIFNKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3432150", Offset = "0x3430F50", VA = "0x183432150")]
	public void OGGOGMAAMDG(Func<Guid, bool> DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3431680", Offset = "0x3430480", VA = "0x183431680")]
	public void IAKJPKIKGDM(Func<Guid, bool> LECIDFBHMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3430DC0", Offset = "0x342FBC0", VA = "0x183430DC0")]
	public void CAGDMIPPHJH(Func<Guid, bool> DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3432180", Offset = "0x3430F80", VA = "0x183432180")]
	public Guid OLOEHMPCONA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3431860", Offset = "0x3430660", VA = "0x183431860")]
	public void IEMMBDODMAC(Guid GFFJOACFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3431B40", Offset = "0x3430940", VA = "0x183431B40")]
	public void KFKABCBIEMH(FJGCNLIMCNH GCBJCBEKPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3430F50", Offset = "0x342FD50", VA = "0x183430F50")]
	public void CGAIAMLGLCP(string KIMLLHDLEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x34310D0", Offset = "0x342FED0", VA = "0x1834310D0")]
	public void CGAIAMLGLCP(Func<string> CLGLILAFKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3252A20", Offset = "0x3251820", VA = "0x183252A20")]
	private T PMIOGGOCPMD<T>(T GKFICKKHACC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3431C90", Offset = "0x3430A90", VA = "0x183431C90")]
	public void KKDJLJMBNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3252270", Offset = "0x3251070", VA = "0x183252270")]
	[CompilerGenerated]
	internal static string GPMDJNJNBIF<T>(byte[] EHAMCGPFFID, int LKELAAFKLBP, ref EEFBKNMAABN<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class CHFJEEPDEAL : FBNACAEIJNK
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class IBHKCGFEMIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public IBHKCGFEMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3428570", Offset = "0x3427370", VA = "0x183428570")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct POOHCDPDFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public CHFJEEPDEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private IDGGIHMDFCC <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3439F80", Offset = "0x3438D80", VA = "0x183439F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class MGMPOKFCDIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public KBPEMCHIDOA presence;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MGMPOKFCDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x342B820", Offset = "0x342A620", VA = "0x18342B820")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly ENNEEGPPNHD HFMEENNPMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly JHCBDEANCOK JAJLANOKGCB;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private const bool HKFACLEJOEK = false;

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2B92670", Offset = "0x2B91470", VA = "0x182B92670")]
	public CHFJEEPDEAL(ENNEEGPPNHD HFMEENNPMOB, JHCBDEANCOK JAJLANOKGCB, Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2B92520", Offset = "0x2B91320", VA = "0x182B92520", Slot = "8")]
	[AsyncStateMachine(typeof(POOHCDPDFJI))]
	protected override Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2B922E0", Offset = "0x2B910E0", VA = "0x182B922E0")]
	private KBPEMCHIDOA MAANNILAIJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class COEKMOJHEKC : FBNACAEIJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct HLCANEOOEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public COEKMOJHEKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<CFAAADDMGBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x3427D20", Offset = "0x3426B20", VA = "0x183427D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly int IIAKFDHOGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly GPNEMJHGMNP KBKLCBOFMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public readonly long LBGOKPFMLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public readonly long MCMNGKINLIK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CFAAADDMGBE JOECKBKNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6550", Offset = "0x6C5350", VA = "0x1806C6550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x775D80", Offset = "0x774B80", VA = "0x180775D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2B93B70", Offset = "0x2B92970", VA = "0x182B93B70")]
	public COEKMOJHEKC(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB, int IIAKFDHOGOL, GPNEMJHGMNP KBKLCBOFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2B93A30", Offset = "0x2B92830", VA = "0x182B93A30", Slot = "8")]
	[AsyncStateMachine(typeof(HLCANEOOEPP))]
	protected override Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class AGHLMPGBGNB : FBNACAEIJNK
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class MIMGCOCAINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public AGHLMPGBGNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public MLAEPGHCMNJ playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MIMGCOCAINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x342BFD0", Offset = "0x342ADD0", VA = "0x18342BFD0")]
		internal Task <RunAsync>b__0(CEJMOEANPLC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x342C010", Offset = "0x342AE10", VA = "0x18342C010")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct FHADDCDKJID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AGHLMPGBGNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private MIMGCOCAINK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3426060", Offset = "0x3424E60", VA = "0x183426060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct FAALHEBECDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public MLAEPGHCMNJ playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AGHLMPGBGNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x3425BA0", Offset = "0x34249A0", VA = "0x183425BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DE20", Offset = "0x2B8CC20", VA = "0x182B8DE20")]
	public AGHLMPGBGNB(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB, string BGOPIPCLOOH, CBLJMJHIGLN CPBINDABFHD, bool IGHPCEFPOKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DCD0", Offset = "0x2B8CAD0", VA = "0x182B8DCD0", Slot = "8")]
	[AsyncStateMachine(typeof(FHADDCDKJID))]
	protected override Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task NCEEOGGJKLJ(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DB70", Offset = "0x2B8C970", VA = "0x182B8DB70")]
	[AsyncStateMachine(typeof(FAALHEBECDP))]
	private Task BENAAMAIKEN(IDisposable CFLMJNDLBCM, MLAEPGHCMNJ JOPKPGGNGEL, CEJMOEANPLC BIEDEPNABLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class PFBHCLMBFLC : FBNACAEIJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct JPPFNJNAHPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public PFBHCLMBFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OGKMJPOHBDC operationContext;

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
		private TaskAwaiter<ABKPGODLHEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x40E9CF0", Offset = "0x40E8AF0", VA = "0x1840E9CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly NAEECGFNFPJ JDHHIBOGJMN;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x3437700", Offset = "0x3436500", VA = "0x183437700")]
	public PFBHCLMBFLC(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB, NAEECGFNFPJ JDHHIBOGJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x34374E0", Offset = "0x34362E0", VA = "0x1834374E0", Slot = "7")]
	protected override string KCPBLKPBLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x34375C0", Offset = "0x34363C0", VA = "0x1834375C0", Slot = "8")]
	[AsyncStateMachine(typeof(JPPFNJNAHPG))]
	protected override Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal abstract class FBNACAEIJNK : NLEJNCDHDND
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task EDAICKNPONO(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class LGOMIEHHBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CEJMOEANPLC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public FBNACAEIJNK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LGOMIEHHBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x35EDB10", Offset = "0x35EC910", VA = "0x1835EDB10")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class ACIPAEBCKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public LGOMIEHHBDD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ACIPAEBCKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x35DE9C0", Offset = "0x35DD7C0", VA = "0x1835DE9C0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x35DEA80", Offset = "0x35DD880", VA = "0x1835DEA80")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct JOMDODINNGB : IAsyncStateMachine
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
		public FBNACAEIJNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<FBNACAEIJNK, CEJMOEANPLC, OGKMJPOHBDC> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private LGOMIEHHBDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private OGKMJPOHBDC <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x35EBA30", Offset = "0x35EA830", VA = "0x1835EBA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct JIEHHEHMNFN : IAsyncStateMachine
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
		public FBNACAEIJNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x35EB7A0", Offset = "0x35EA5A0", VA = "0x1835EB7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public readonly Guid PNLGMJCAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public readonly ByteString GOMDJKHBOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly JLMDOPEJOBO MBIGBIBNKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	protected readonly string HLLGNPCGGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly bool IGHPCEFPOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly Queue<EDAICKNPONO> LNFLGJECDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly KLJLIGBHMNL DELGNFHCDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly CBLJMJHIGLN CPBINDABFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private bool NLCKIBOLBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public AMHDNJGMOGN NPCNCFMMCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public AMHDNJGMOGN LPBOEEPELNN;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IAJPIHCHKKO GOMKGLONFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B060", Offset = "0x2B99E60", VA = "0x182B9B060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public CDFFKAEIMLF LCKJJBALDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF90", Offset = "0x2B99D90", VA = "0x182B9AF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AFE0", Offset = "0x2B99DE0", VA = "0x182B9AFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B490", Offset = "0x2B9A290", VA = "0x182B9B490", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AC80", Offset = "0x2B99A80", VA = "0x182B9AC80", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B530", Offset = "0x2B9A330", VA = "0x182B9B530", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B550", Offset = "0x2B9A350", VA = "0x182B9B550")]
	protected FBNACAEIJNK(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB, string BGOPIPCLOOH, CBLJMJHIGLN CPBINDABFHD, bool IGHPCEFPOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AF50", Offset = "0x2B99D50", VA = "0x182B9AF50", Slot = "7")]
	protected virtual string KCPBLKPBLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B0B0", Offset = "0x2B99EB0", VA = "0x182B9B0B0")]
	public void MKOKPKNCPKP(EDAICKNPONO ANJDFHINBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2B9ADF0", Offset = "0x2B99BF0", VA = "0x182B9ADF0")]
	protected void BNKOFJMKLGI(float KNNJFFBFLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9ACA0", Offset = "0x2B99AA0", VA = "0x182B9ACA0")]
	[AsyncStateMachine(typeof(JOMDODINNGB))]
	public Task BLFPKNOMADF(CancellationToken ADCKNELPFOJ, CEJMOEANPLC PDHDLCNGDKN, [Optional] Func<FBNACAEIJNK, CEJMOEANPLC, OGKMJPOHBDC> BKHDPNHLHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B300", Offset = "0x2B9A100", VA = "0x182B9B300")]
	private void PIHLDFBOIBK(bool NKODDMBDLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B1F0", Offset = "0x2B99FF0", VA = "0x182B9B1F0")]
	private void MOLEFPAPCKH(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AE10", Offset = "0x2B99C10", VA = "0x182B9AE10")]
	[AsyncStateMachine(typeof(JIEHHEHMNFN))]
	private Task IINLCNMAEED(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B4B0", Offset = "0x2B9A2B0", VA = "0x182B9B4B0")]
	public FJGCNLIMCNH PMALMLCAELM(NAGOEMOCHDF LGDEOFMNENO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B110", Offset = "0x2B99F10", VA = "0x182B9B110")]
	[CompilerGenerated]
	private Task MMILCMBPOGD(CancellationToken NDJEJACDKEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal sealed class ABMBMELAIEH : AGHLMPGBGNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct AGOFPLGEGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public ABMBMELAIEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private GBLFGEDHNKK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private IDGGIHMDFCC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3422DD0", Offset = "0x3421BD0", VA = "0x183422DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly ENNEEGPPNHD MIBMFMAIKOC;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DAC0", Offset = "0x2B8C8C0", VA = "0x182B8DAC0")]
	public ABMBMELAIEH(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, ENNEEGPPNHD MIBMFMAIKOC, JLMDOPEJOBO IIGPHBAJOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D970", Offset = "0x2B8C770", VA = "0x182B8D970", Slot = "9")]
	[AsyncStateMachine(typeof(AGOFPLGEGBH))]
	protected override Task NCEEOGGJKLJ(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class IFMHFGEOMHF : FBNACAEIJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct KNJELJCKNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public IFMHFGEOMHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter<ABKPGODLHEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x35ED2D0", Offset = "0x35EC0D0", VA = "0x1835ED2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly string JANFCJIJBFA;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4FC0", Offset = "0x2BA3DC0", VA = "0x182BA4FC0")]
	public IFMHFGEOMHF(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, JLMDOPEJOBO IIGPHBAJOHB, string JANFCJIJBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4E90", Offset = "0x2BA3C90", VA = "0x182BA4E90", Slot = "8")]
	[AsyncStateMachine(typeof(KNJELJCKNBO))]
	protected override Task PKOAIEKLHFD(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class OLOFPBGCJMA : AGHLMPGBGNB
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ILOJBIBAFLK
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
			public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public ILOJBIBAFLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private TaskAwaiter<ABKPGODLHEA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter<FJGCNLIMCNH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x40F3AA0", Offset = "0x40F28A0", VA = "0x1840F3AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x40F3DF0", Offset = "0x40F2BF0", VA = "0x1840F3DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public OLOFPBGCJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public GDOJNIPBOOE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public MKGGJMJOFJM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ILOJBIBAFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x40E9A50", Offset = "0x40E8850", VA = "0x1840E9A50")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FJGCNLIMCNH> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct FOPMJPGJOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public OLOFPBGCJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private ILOJBIBAFLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private GBLFGEDHNKK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private IDGGIHMDFCC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x40E6D30", Offset = "0x40E5B30", VA = "0x1840E6D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly int BIOCBIPJPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[CanBeNull]
	private readonly PJOBDCFHOJN CMFBBNFPOCA;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x3436AA0", Offset = "0x34358A0", VA = "0x183436AA0")]
	public OLOFPBGCJMA(Guid FCEHMDFKHII, IAJPIHCHKKO NHBDFDDDAKD, int BIOCBIPJPBJ, PJOBDCFHOJN CMFBBNFPOCA, JLMDOPEJOBO IIGPHBAJOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x3436940", Offset = "0x3435740", VA = "0x183436940", Slot = "9")]
	[AsyncStateMachine(typeof(FOPMJPGJOOG))]
	protected override Task NCEEOGGJKLJ(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3436850", Offset = "0x3435650", VA = "0x183436850")]
	private void MOEDMMLHFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x34366B0", Offset = "0x34354B0", VA = "0x1834366B0")]
	private void INHEJCDIOLC(CEJMOEANPLC PDHDLCNGDKN, GBLFGEDHNKK IELAMMJPGFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal abstract class NACEKBLACKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly FBNACAEIJNK BFNEPCEELIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public readonly OGKMJPOHBDC KPLJANPGAPM;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x342CD60", Offset = "0x342BB60", VA = "0x18342CD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x342CD00", Offset = "0x342BB00", VA = "0x18342CD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x342CD80", Offset = "0x342BB80", VA = "0x18342CD80")]
	protected NACEKBLACKE(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x342CB70", Offset = "0x342B970", VA = "0x18342CB70")]
	protected void CGAIAMLGLCP(string KIMLLHDLEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x342C9E0", Offset = "0x342B7E0", VA = "0x18342C9E0")]
	public void CGAIAMLGLCP(Func<string> CLGLILAFKPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct KHEKEDOMIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public Dictionary<Guid, List<GADJMBFAGEF>> ACJCFPFGOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public Dictionary<Guid, List<GADJMBFAGEF>> DKJOBIEIPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<GADJMBFAGEF>> GAPCPABFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public List<Guid> HKCFAOLJKJP;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6EE0", Offset = "0x2BA5CE0", VA = "0x182BA6EE0")]
	public static KHEKEDOMIMA HMFHOBMDMGG(PHALPGAPCKG KNPPOFLONHP, AMHDNJGMOGN OKFLGLEGDLB, FAFEPBBAFLL OGCBKDBCIIM)
	{
		return default(KHEKEDOMIMA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct NMBJJOPFHDK
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0")]
	public static NMBJJOPFHDK GLBIKEOEKPG()
	{
		return default(NMBJJOPFHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void MNAKPJKBBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IAKIIPEJPFD(FAFEPBBAFLL JLFCOOGLPMP, object JNKHFBAHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DDCGBDMILJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct ILNPNFMALGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly EKLMJEDNPMN OPOLHNGKHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly BJMHDOIMFLB EABEMMHBDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly JJNENKGJHBC NIBJLJHBBKF;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5070", Offset = "0x2BA3E70", VA = "0x182BA5070")]
	public ILNPNFMALGH(EKLMJEDNPMN OPOLHNGKHJE, BJMHDOIMFLB EABEMMHBDCJ, JJNENKGJHBC NIBJLJHBBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct MFJJCHMBBNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private readonly OGKMJPOHBDC HDMGBOHIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private readonly Guid GFFJOACFPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private bool NKODDMBDLFC;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB5A0", Offset = "0x2BAA3A0", VA = "0x182BAB5A0")]
	public static MFJJCHMBBNM OLOEHMPCONA(OGKMJPOHBDC HDMGBOHIHAK)
	{
		return default(MFJJCHMBBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xB53BF0", Offset = "0xB529F0", VA = "0x180B53BF0")]
	public void APNEIHGBFJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB540", Offset = "0x2BAA340", VA = "0x182BAB540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB6B0", Offset = "0x2BAA4B0", VA = "0x182BAB6B0")]
	private MFJJCHMBBNM(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB540", Offset = "0x2BAA340", VA = "0x182BAB540")]
	private void IEMMBDODMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB600", Offset = "0x2BAA400", VA = "0x182BAB600")]
	private Func<Guid, bool> PGMAOJIFAPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class IDGGIHMDFCC : NACEKBLACKE, NLEJNCDHDND
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public delegate Task<AMHDNJGMOGN> HJJFFFIMFEA(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB AHCGKBKDJJH, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct NDNFHHOLGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public ENNEEGPPNHD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private MFJJCHMBBNM <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x35EF7E0", Offset = "0x35EE5E0", VA = "0x1835EF7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct JCOHEOAMPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public ENNEEGPPNHD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private CEJMOEANPLC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x35EB110", Offset = "0x35E9F10", VA = "0x1835EB110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x35EB430", Offset = "0x35EA230", VA = "0x1835EB430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct GCEKCHGKCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public ENNEEGPPNHD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private CEJMOEANPLC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x35E7E00", Offset = "0x35E6C00", VA = "0x1835E7E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class MOFHIDGNHEO
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
			public AsyncTaskMethodBuilder<ILNPNFMALGH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public MOFHIDGNHEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private ILNPNFMALGH <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<AMHDNJGMOGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<ILNPNFMALGH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x40F27F0", Offset = "0x40F15F0", VA = "0x1840F27F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x40F2E00", Offset = "0x40F1C00", VA = "0x1840F2E00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FAFEPBBAFLL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public MOFHIDGNHEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private FAFEPBBAFLL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<AMHDNJGMOGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private TaskAwaiter<FAFEPBBAFLL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x40F2E50", Offset = "0x40F1C50", VA = "0x1840F2E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x40F3380", Offset = "0x40F2180", VA = "0x1840F3380", Slot = "5")]
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
			public MOFHIDGNHEO <>4__this;

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
			private TaskAwaiter<AMHDNJGMOGN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private DJNHMPIAHIB <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x40F13F0", Offset = "0x40F01F0", VA = "0x1840F13F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public ENNEEGPPNHD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public KLJLIGBHMNL preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public KLJLIGBHMNL downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public ILNPNFMALGH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public KLJLIGBHMNL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public FAFEPBBAFLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public KFNPLEMFNFN.HNBAAKEGDFN <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MOFHIDGNHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x35EEFF0", Offset = "0x35EDDF0", VA = "0x1835EEFF0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<ILNPNFMALGH> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x35EF130", Offset = "0x35EDF30", VA = "0x1835EF130")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<FAFEPBBAFLL> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x35EF270", Offset = "0x35EE070", VA = "0x1835EF270")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x35EEEC0", Offset = "0x35EDCC0", VA = "0x1835EEEC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct BAMEOCDGOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public ENNEEGPPNHD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private MOFHIDGNHEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<ILNPNFMALGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter<FAFEPBBAFLL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x35E1E20", Offset = "0x35E0C20", VA = "0x1835E1E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct CLFKFJPHDNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x35E4370", Offset = "0x35E3170", VA = "0x1835E4370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct FHJPMBCHCIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private CEJMOEANPLC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x35E6E30", Offset = "0x35E5C30", VA = "0x1835E6E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct CHABJLHBNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private CEJMOEANPLC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x35E3830", Offset = "0x35E2630", VA = "0x1835E3830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x35E42D0", Offset = "0x35E30D0", VA = "0x1835E42D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct PGDAMPKKKHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private CEJMOEANPLC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x35F2510", Offset = "0x35F1310", VA = "0x1835F2510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x35F30C0", Offset = "0x35F1EC0", VA = "0x1835F30C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct HANIPMBILAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AMHDNJGMOGN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public FAFEPBBAFLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x35E90A0", Offset = "0x35E7EA0", VA = "0x1835E90A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x35E92A0", Offset = "0x35E80A0", VA = "0x1835E92A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class DJMMFJGNGOL
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
			public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public DJMMFJGNGOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<AMHDNJGMOGN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x40F33D0", Offset = "0x40F21D0", VA = "0x1840F33D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x40F3910", Offset = "0x40F2710", VA = "0x1840F3910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public HJJFFFIMFEA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AMHDNJGMOGN originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public DJMMFJGNGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x35E4EF0", Offset = "0x35E3CF0", VA = "0x1835E4EF0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<AMHDNJGMOGN> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct GCGFHFHGMBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public HJJFFFIMFEA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x35E8060", Offset = "0x35E6E60", VA = "0x1835E8060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x35E8500", Offset = "0x35E7300", VA = "0x1835E8500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct EIMJDFEBGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public KLJLIGBHMNL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private AMHDNJGMOGN <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private IEnumerator<AMHDNJGMOGN> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x35E6530", Offset = "0x35E5330", VA = "0x1835E6530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct HKHEKEOKDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x35EA7B0", Offset = "0x35E95B0", VA = "0x1835EA7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct MFHABONDEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public IAJPIHCHKKO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x35EE2E0", Offset = "0x35ED0E0", VA = "0x1835EE2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct DMJOOAHPEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public IDGGIHMDFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x35E5030", Offset = "0x35E3E30", VA = "0x1835E5030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class AGONBMCPMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public EKLMJEDNPMN roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public AGONBMCPMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x35DEDC0", Offset = "0x35DDBC0", VA = "0x1835DEDC0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly GHFMFMDNJJE HKGBPCDEKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly GHFMFMDNJJE EMNJBCEKMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly CIBCBPALFJL BJNNBLLPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly MPLBNHAJFEL HFHJMHDCJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly EEBIFGEDJJL OBIPACNIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly GHGOLJAPJCC OKPAJNNDNBA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA42B0", Offset = "0x2BA30B0", VA = "0x182BA42B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private IAJPIHCHKKO GOMKGLONFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA28A0", Offset = "0x2BA16A0", VA = "0x182BA28A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2A30", Offset = "0x2BA1830", VA = "0x182BA2A30", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4470", Offset = "0x2BA3270", VA = "0x182BA4470", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4490", Offset = "0x2BA3290", VA = "0x182BA4490")]
	public IDGGIHMDFCC(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA38F0", Offset = "0x2BA26F0", VA = "0x182BA38F0")]
	[AsyncStateMachine(typeof(NDNFHHOLGMG))]
	public Task LINNGIBHAKP(ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, bool OJPFHPKCHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3130", Offset = "0x2BA1F30", VA = "0x182BA3130")]
	[AsyncStateMachine(typeof(JCOHEOAMPOE))]
	private Task<FJGCNLIMCNH> FJNDLDJEKGC(ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2BA32B0", Offset = "0x2BA20B0", VA = "0x182BA32B0")]
	[AsyncStateMachine(typeof(GCEKCHGKCIL))]
	private Task HCDLIBBIEHC(ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, bool OJPFHPKCHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2BA28D0", Offset = "0x2BA16D0", VA = "0x182BA28D0")]
	[AsyncStateMachine(typeof(BAMEOCDGOCB))]
	private Task ALDOFLCIPKJ(ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC PDHDLCNGDKN, CancellationToken LAIAHIMPMBO, bool OJPFHPKCHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3B70", Offset = "0x2BA2970", VA = "0x182BA3B70")]
	[AsyncStateMachine(typeof(CLFKFJPHDNO))]
	private Task NDOHKJPCFOF(CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3CA0", Offset = "0x2BA2AA0", VA = "0x182BA3CA0")]
	[AsyncStateMachine(typeof(FHJPMBCHCIH))]
	private Task NHEIKGLJNBD(FAFEPBBAFLL JLFCOOGLPMP, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3770", Offset = "0x2BA2570", VA = "0x182BA3770")]
	[AsyncStateMachine(typeof(CHABJLHBNLK))]
	private Task<AMHDNJGMOGN> LANADNMPKDB(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2BA42D0", Offset = "0x2BA30D0", VA = "0x182BA42D0")]
	[AsyncStateMachine(typeof(PGDAMPKKKHF))]
	private Task<AMHDNJGMOGN> PMFELDGKKEL(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2BA0", Offset = "0x2BA19A0", VA = "0x182BA2BA0")]
	[AsyncStateMachine(typeof(HANIPMBILAM))]
	private Task<AMHDNJGMOGN> BDPPGLKCGEG(AMHDNJGMOGN OKFLGLEGDLB, FAFEPBBAFLL OGCBKDBCIIM, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, bool LNHECENLCFG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3040", Offset = "0x2BA1E40", VA = "0x182BA3040")]
	private bool EFMKKLNENOH(FAFEPBBAFLL NJJMNHOHGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4100", Offset = "0x2BA2F00", VA = "0x182BA4100")]
	[AsyncStateMachine(typeof(GCGFHFHGMBO))]
	protected Task<AMHDNJGMOGN> PCEACNMFIMN(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, HJJFFFIMFEA NLGHPMICCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2700", Offset = "0x2BA1500", VA = "0x182BA2700")]
	[AsyncStateMachine(typeof(EIMJDFEBGEM))]
	private Task ACOAABLMADP(FAFEPBBAFLL JLFCOOGLPMP, KLJLIGBHMNL AJEIKLJNAHK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3F50", Offset = "0x2BA2D50", VA = "0x182BA3F50")]
	private void OJILKFJNIPF(AMHDNJGMOGN FEOGDHPPOIP, KLJLIGBHMNL AJEIKLJNAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2860", Offset = "0x2BA1660", VA = "0x182BA2860")]
	private void AHKHBLIJLGK(AMHDNJGMOGN HEEDLFDDLOL, out AMHDNJGMOGN FIDADCLNMGJ, out AMHDNJGMOGN LEDJOMIJBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3410", Offset = "0x2BA2210", VA = "0x182BA3410")]
	private Task<ILNPNFMALGH> IHEOODDAAJD(ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA35D0", Offset = "0x2BA23D0", VA = "0x182BA35D0")]
	private Task<FAFEPBBAFLL> KOPGBNAALGE(ENNEEGPPNHD BOBJBDACGIL, ILNPNFMALGH JLFCOOGLPMP, KFNPLEMFNFN.HNBAAKEGDFN ADDFOGMJOEM, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2A50", Offset = "0x2BA1850", VA = "0x182BA2A50")]
	[AsyncStateMachine(typeof(HKHEKEOKDMM))]
	private Task AMJKJEEBDHM(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2EF0", Offset = "0x2BA1CF0", VA = "0x182BA2EF0")]
	[AsyncStateMachine(typeof(MFHABONDEIA))]
	private Task CNBEIIKHMKN(FAFEPBBAFLL JLFCOOGLPMP, IAJPIHCHKKO NHBDFDDDAKD, CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3A50", Offset = "0x2BA2850", VA = "0x182BA3A50")]
	[AsyncStateMachine(typeof(DMJOOAHPEKJ))]
	private Task NCENDFKPMFC(FAFEPBBAFLL JLFCOOGLPMP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D60", Offset = "0x2BA1B60", VA = "0x182BA2D60")]
	private Task BLKNPBFPJBJ(FAFEPBBAFLL JLFCOOGLPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3FA0", Offset = "0x2BA2DA0", VA = "0x182BA3FA0")]
	private Task PACMKDNJKAC(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3E00", Offset = "0x2BA2C00", VA = "0x182BA3E00")]
	private Task OIPCHMKPPFC(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3450", Offset = "0x2BA2250", VA = "0x182BA3450")]
	private Task JBCCDKAGOLH(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B921C0", Offset = "0x2B90FC0", VA = "0x182B921C0")]
	private static Task MHOFJFODOCH(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3470", Offset = "0x2BA2270", VA = "0x182BA3470")]
	private Task KAFPEFDMJLM(FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3620", Offset = "0x2BA2420", VA = "0x182BA3620")]
	private Task KPDNKLNOAIP(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D30", Offset = "0x2BA1B30", VA = "0x182BA2D30")]
	private void BECNDKDABNP(ENNEEGPPNHD BOBJBDACGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D90", Offset = "0x2BA1B90", VA = "0x182BA2D90")]
	private static void CJJDEAKFEGD(EKLMJEDNPMN OPOLHNGKHJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct BFIGIDOGCIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private AMHDNJGMOGN FEOGDHPPOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private FAFEPBBAFLL JLFCOOGLPMP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F750", Offset = "0x2B8E550", VA = "0x182B8F750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F6D0", Offset = "0x2B8E4D0", VA = "0x182B8F6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F3D0", Offset = "0x2B8E1D0", VA = "0x182B8F3D0")]
	public static Task BLFPKNOMADF(IAJPIHCHKKO NHBDFDDDAKD, AMHDNJGMOGN FEOGDHPPOIP, FAFEPBBAFLL JLFCOOGLPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F480", Offset = "0x2B8E280", VA = "0x182B8F480")]
	private void BLFPKNOMADF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct CGNPJEIAOCA
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B921C0", Offset = "0x2B90FC0", VA = "0x182B921C0")]
	public static Task BLFPKNOMADF(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct HDEPLFMCMFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct LJAMHNFEJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private CEJMOEANPLC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x35EDBA0", Offset = "0x35EC9A0", VA = "0x1835EDBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0460", Offset = "0x2B9F260", VA = "0x182BA0460")]
	[AsyncStateMachine(typeof(LJAMHNFEJAB))]
	public static Task BLFPKNOMADF(OGKMJPOHBDC HDMGBOHIHAK, FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct PAJNPAAEJKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct GMLONOHONCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private AMHDNJGMOGN <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private IAJPIHCHKKO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private PHALPGAPCKG <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private List<(PersistenceView, IOMALNHJNIN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private IOMALNHJNIN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x40E7AA0", Offset = "0x40E68A0", VA = "0x1840E7AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3437100", Offset = "0x3435F00", VA = "0x183437100")]
	[AsyncStateMachine(typeof(GMLONOHONCN))]
	public static Task BLFPKNOMADF(OGKMJPOHBDC HDMGBOHIHAK, FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3437270", Offset = "0x3436070", VA = "0x183437270")]
	private static void KCKMBEFJKPH(PersistenceView BDEPBKMNBCE, IOMALNHJNIN JNKHFBAHKDD, FAFEPBBAFLL JLFCOOGLPMP, AMHDNJGMOGN OKFLGLEGDLB, bool DOPDECLOKOG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct HHNEAELPLFP
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0A10", Offset = "0x2B9F810", VA = "0x182BA0A10")]
	public static Task BLFPKNOMADF(IAJPIHCHKKO NHBDFDDDAKD, FAFEPBBAFLL JLFCOOGLPMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct DPIFFLJOAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct OBPHPJFGANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public IAJPIHCHKKO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x3430BF0", Offset = "0x342F9F0", VA = "0x183430BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct AGKCNANGLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public DPIFFLJOAIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x3422530", Offset = "0x3421330", VA = "0x183422530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class DDOGKLGJJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public MIDGADGEHKB version;

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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public DDOGKLGJJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3424E70", Offset = "0x3423C70", VA = "0x183424E70")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3424F50", Offset = "0x3423D50", VA = "0x183424F50")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private FAFEPBBAFLL JLFCOOGLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private OGKMJPOHBDC HDMGBOHIHAK;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString IPLPEBKGNDB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B97570", Offset = "0x2B96370", VA = "0x182B97570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private MMDMAENKKFC KCGHDNBPODK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B974F0", Offset = "0x2B962F0", VA = "0x182B974F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B97360", Offset = "0x2B96160", VA = "0x182B97360")]
	[AsyncStateMachine(typeof(OBPHPJFGANB))]
	public static Task BLFPKNOMADF(IAJPIHCHKKO NHBDFDDDAKD, AMHDNJGMOGN FEOGDHPPOIP, FAFEPBBAFLL JLFCOOGLPMP, OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B97220", Offset = "0x2B96020", VA = "0x182B97220")]
	[AsyncStateMachine(typeof(AGKCNANGLNI))]
	private Task BLFPKNOMADF(CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B975C0", Offset = "0x2B963C0", VA = "0x182B975C0")]
	private void POHEHHBJGDI([NotNull] IFHIAHJKMIE BEACAGMICDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2B974C0", Offset = "0x2B962C0", VA = "0x182B974C0")]
	private bool ENPFNNJDKBF(MIDGADGEHKB OPAPEIICLLC, IFHIAHJKMIE BEACAGMICDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct MHCMLKFIIEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct PEOLFMPLBHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder<FAFEPBBAFLL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public MHCMLKFIIEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public KFNPLEMFNFN.HNBAAKEGDFN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private CEJMOEANPLC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter<(global::EMFHPGMFAOO<MDIDCCCLLID, BMIGOOHOEBL>, global::EMFHPGMFAOO<global::NGNOGAAMAIJ<IFHIAHJKMIE>, BMIGOOHOEBL>, global::EMFHPGMFAOO<global::NGNOGAAMAIJ<IDBFKGMDDDL>, BMIGOOHOEBL>, global::EMFHPGMFAOO<global::NGNOGAAMAIJ<JNMMIDGNACF>, BMIGOOHOEBL>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x35F1820", Offset = "0x35F0620", VA = "0x1835F1820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x35F20E0", Offset = "0x35F0EE0", VA = "0x1835F20E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NILLFDNOHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder<global::EMFHPGMFAOO<MDIDCCCLLID, BMIGOOHOEBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CEJMOEANPLC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public MHCMLKFIIEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public KFNPLEMFNFN.HNBAAKEGDFN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private CEJMOEANPLC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<global::EMFHPGMFAOO<MDIDCCCLLID, BMIGOOHOEBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x35EFBE0", Offset = "0x35EE9E0", VA = "0x1835EFBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x35F00D0", Offset = "0x35EEED0", VA = "0x1835F00D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private global::BKMDBBMLEPK<MOAJEGAOKON, IDBFKGMDDDL> KNGJOFJOOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private global::BKMDBBMLEPK<MOAJEGAOKON, IFHIAHJKMIE> EABEMMHBDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private global::BKMDBBMLEPK<long, JNMMIDGNACF> HPLGPFLBAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private PGMMKFHKFLE AIKKKDGMGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private ENNEEGPPNHD BOBJBDACGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private EKLMJEDNPMN OPOLHNGKHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private BJMHDOIMFLB AHCFENEADAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private long OMGLNIDEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private CEJMOEANPLC BIEDEPNABLP;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB700", Offset = "0x2BAA500", VA = "0x182BAB700")]
	public static Task<FAFEPBBAFLL> BFGJJINPKEO(IAJPIHCHKKO NHBDFDDDAKD, ENNEEGPPNHD BOBJBDACGIL, in ILNPNFMALGH JLFCOOGLPMP, KFNPLEMFNFN.HNBAAKEGDFN ADDFOGMJOEM, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2BABA20", Offset = "0x2BAA820", VA = "0x182BABA20")]
	[AsyncStateMachine(typeof(PEOLFMPLBHN))]
	private Task<FAFEPBBAFLL> BLFPKNOMADF(KFNPLEMFNFN.HNBAAKEGDFN ADDFOGMJOEM, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2BABD40", Offset = "0x2BAAB40", VA = "0x182BABD40")]
	private MOAJEGAOKON LEEEFIBDGIA(OGIBDGOJJJH PKLDEJDLNDH)
	{
		return default(MOAJEGAOKON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2BABB90", Offset = "0x2BAA990", VA = "0x182BABB90")]
	[AsyncStateMachine(typeof(NILLFDNOHHD))]
	private Task<global::EMFHPGMFAOO<MDIDCCCLLID, BMIGOOHOEBL>> BPEJEIOMCCA(string DDFMKNKNADC, long OMGLNIDEKLD, KFNPLEMFNFN.HNBAAKEGDFN ADDFOGMJOEM, CEJMOEANPLC LNMBJGPKIGO, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal struct BFMODHKLCCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct JAACPBMOKMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<ILNPNFMALGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public BFMODHKLCCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private CEJMOEANPLC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<ILNPNFMALGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3428D20", Offset = "0x3427B20", VA = "0x183428D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x34291D0", Offset = "0x3427FD0", VA = "0x1834291D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct PNGCADHCKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<ILNPNFMALGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public BFMODHKLCCJ <>4__this;

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
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter<ILNPNFMALGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3439D40", Offset = "0x3438B40", VA = "0x183439D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3439F30", Offset = "0x3438D30", VA = "0x183439F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class HOAIIHOCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HOAIIHOCJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x146E8E0", Offset = "0x146D6E0", VA = "0x18146E8E0")]
		internal bool <FetchRoomDetails>b__0(BJMHDOIMFLB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct KFJBIFGCCHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder<ILNPNFMALGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public PHALPGAPCKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private HOAIIHOCJGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter<EKLMJEDNPMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x34298D0", Offset = "0x34286D0", VA = "0x1834298D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x3429E10", Offset = "0x3428C10", VA = "0x183429E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private CIBCBPALFJL BJNNBLLPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private CEJMOEANPLC BIEDEPNABLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private long HMOGFNMOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private long KMHHOKHNCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private string JGHIFJNBNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private MOAJEGAOKON FKPCDIBGHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private MOAJEGAOKON NMMOICMGDNG;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F7A0", Offset = "0x2B8E5A0", VA = "0x182B8F7A0")]
	public static Task<ILNPNFMALGH> BFGJJINPKEO(IAJPIHCHKKO NHBDFDDDAKD, ENNEEGPPNHD BOBJBDACGIL, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FA30", Offset = "0x2B8E830", VA = "0x182B8FA30")]
	[AsyncStateMachine(typeof(JAACPBMOKMK))]
	private Task<ILNPNFMALGH> BLFPKNOMADF(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FD10", Offset = "0x2B8EB10", VA = "0x182B8FD10")]
	[AsyncStateMachine(typeof(PNGCADHCKOB))]
	private Task<ILNPNFMALGH> IHEOODDAAJD(long HMOGFNMOLJM, long KMHHOKHNCJA, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, bool IAEPMKLPONN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FB90", Offset = "0x2B8E990", VA = "0x182B8FB90")]
	[AsyncStateMachine(typeof(KFJBIFGCCHF))]
	public static Task<ILNPNFMALGH> IHEOODDAAJD(PHALPGAPCKG KNPPOFLONHP, long HMOGFNMOLJM, long KMHHOKHNCJA, CancellationToken ADCKNELPFOJ, CEJMOEANPLC PDHDLCNGDKN, bool IAEPMKLPONN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FEA0", Offset = "0x2B8ECA0", VA = "0x182B8FEA0")]
	private void JPKLGIGBEHP(EKLMJEDNPMN OPOLHNGKHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FFB0", Offset = "0x2B8EDB0", VA = "0x182B8FFB0")]
	private bool MIDOLDAPGDM(ILNPNFMALGH JLFCOOGLPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2B90120", Offset = "0x2B8EF20", VA = "0x182B90120")]
	private void NLDKPLEAOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct NEOMADEJADE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct NKPGCDIFHOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public NEOMADEJADE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x35F06A0", Offset = "0x35EF4A0", VA = "0x1835F06A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private const int HFCELALIDCJ = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private const float FONFJNFCJOO = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private PHALPGAPCKG KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private FAFEPBBAFLL JLFCOOGLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private CEJMOEANPLC BIEDEPNABLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private float HKANIIFIMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private float CNNICKPOOLG;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x342E800", Offset = "0x342D600", VA = "0x18342E800")]
	public static Task COEABMPIPOL(IAJPIHCHKKO NHBDFDDDAKD, FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x342E610", Offset = "0x342D410", VA = "0x18342E610")]
	[AsyncStateMachine(typeof(NKPGCDIFHOP))]
	public Task BLFPKNOMADF(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x342EB90", Offset = "0x342D990", VA = "0x18342EB90")]
	private static void KGGMBNPKHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x342E9C0", Offset = "0x342D7C0", VA = "0x18342E9C0")]
	private void GHJCDGIECHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x342E740", Offset = "0x342D540", VA = "0x18342E740")]
	private static float CHFGNHICJLG(PHALPGAPCKG KNPPOFLONHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x342E9A0", Offset = "0x342D7A0", VA = "0x18342E9A0")]
	private static float EKCNMJEALAL()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct ELACIBIDAIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct MBOLLHHBEMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public OGKMJPOHBDC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private FBNACAEIJNK <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private IAJPIHCHKKO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private KKDLOOADLNE.DCAKMHOBBDG <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x342AA20", Offset = "0x3429820", VA = "0x18342AA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct COHCBPECCBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ONJFAPKGJCJ.ANECHFAEDLF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3424610", Offset = "0x3423410", VA = "0x183424610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2B98EF0", Offset = "0x2B97CF0", VA = "0x182B98EF0")]
	[AsyncStateMachine(typeof(MBOLLHHBEMP))]
	public static Task BLFPKNOMADF(OGKMJPOHBDC HDMGBOHIHAK, FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2B99050", Offset = "0x2B97E50", VA = "0x182B99050")]
	private static Task<FJGCNLIMCNH> EBLMFCKEBLJ(OGKMJPOHBDC HDMGBOHIHAK, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2B990C0", Offset = "0x2B97EC0", VA = "0x182B990C0")]
	[AsyncStateMachine(typeof(COHCBPECCBA))]
	private static Task MLOGLEHCKKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct AINMNEILDPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct ELFODABLKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public AINMNEILDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x34255E0", Offset = "0x34243E0", VA = "0x1834255E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class BELPANABNCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BELPANABNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3423B90", Offset = "0x3422990", VA = "0x183423B90")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct LIFOOHFJLDN : IAsyncStateMachine
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
		public AINMNEILDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private MHNGKFLBHPH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x342A4D0", Offset = "0x34292D0", VA = "0x18342A4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private bool EFBPGMFMIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private CEJMOEANPLC BIEDEPNABLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CancellationToken ADCKNELPFOJ;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DE70", Offset = "0x2B8CC70", VA = "0x182B8DE70")]
	public static Task BGIJGPPFOEK(IAJPIHCHKKO NHBDFDDDAKD, bool EFBPGMFMIIC, CEJMOEANPLC BIEDEPNABLP, CancellationToken FPPFEPPLODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DEE0", Offset = "0x2B8CCE0", VA = "0x182B8DEE0")]
	[AsyncStateMachine(typeof(ELFODABLKBG))]
	private Task BLFPKNOMADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DFF0", Offset = "0x2B8CDF0", VA = "0x182B8DFF0")]
	[AsyncStateMachine(typeof(LIFOOHFJLDN))]
	private Task HBCDAJHMEEC(bool IMDFFNIBLHP, string BIHFIHKHIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0")]
	private bool PKDHIDMBHMI(bool EFBPGMFMIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct HEAFFIPKKEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct NNKHOMBKMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public HEAFFIPKKEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A50", Offset = "0x35EF850", VA = "0x1835F0A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x35F0EA0", Offset = "0x35EFCA0", VA = "0x1835F0EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class CKPKDCAONOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public CKPKDCAONOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x35E4320", Offset = "0x35E3120", VA = "0x1835E4320")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct AMIPHGLIGBE : IAsyncStateMachine
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
		public HEAFFIPKKEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private MHNGKFLBHPH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x35DF9A0", Offset = "0x35DE7A0", VA = "0x1835DF9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x35DFEE0", Offset = "0x35DECE0", VA = "0x1835DFEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private JJNENKGJHBC FHEDJPCKNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private CEJMOEANPLC BIEDEPNABLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private bool FMCNODFCDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private FAFEPBBAFLL JLFCOOGLPMP;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2BA08E0", Offset = "0x2B9F6E0", VA = "0x182BA08E0")]
	public static Task<Scene> JELFAEDBHLJ(IAJPIHCHKKO NHBDFDDDAKD, JJNENKGJHBC OAMOLCPBEAL, CEJMOEANPLC BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2BA06E0", Offset = "0x2B9F4E0", VA = "0x182BA06E0")]
	public static Task<Scene> GKDJNBOCNMP(IAJPIHCHKKO NHBDFDDDAKD, FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2BA05B0", Offset = "0x2B9F3B0", VA = "0x182BA05B0")]
	[AsyncStateMachine(typeof(NNKHOMBKMDE))]
	private Task<Scene> BLFPKNOMADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA09D0", Offset = "0x2B9F7D0", VA = "0x182BA09D0")]
	private bool PBBEOPDLACO(FAFEPBBAFLL JLFCOOGLPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0960", Offset = "0x2B9F760", VA = "0x182BA0960")]
	private void MIJJBCEBCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0780", Offset = "0x2B9F580", VA = "0x182BA0780")]
	[AsyncStateMachine(typeof(AMIPHGLIGBE))]
	private Task<Scene> HBCDAJHMEEC(string BIHFIHKHIBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EEBIFGEDJJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct MHFFKGPAAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public EEBIFGEDJJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AMHDNJGMOGN nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public FAFEPBBAFLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private CEJMOEANPLC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<AMHDNJGMOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x342B960", Offset = "0x342A760", VA = "0x18342B960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x342BF80", Offset = "0x342AD80", VA = "0x18342BF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct FOMDKIAJIKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<AMHDNJGMOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public EEBIFGEDJJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AMHDNJGMOGN state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x34272C0", Offset = "0x34260C0", VA = "0x1834272C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3427540", Offset = "0x3426340", VA = "0x183427540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly OGKMJPOHBDC HDMGBOHIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private readonly CIBCBPALFJL BJNNBLLPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private readonly MPLBNHAJFEL HFHJMHDCJLN;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private FBNACAEIJNK BFNEPCEELIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x9052C0", Offset = "0x9040C0", VA = "0x1809052C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2B98200", Offset = "0x2B97000", VA = "0x182B98200")]
	public EEBIFGEDJJL(OGKMJPOHBDC HDMGBOHIHAK, CIBCBPALFJL BJNNBLLPNOF, MPLBNHAJFEL HFHJMHDCJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2B98030", Offset = "0x2B96E30", VA = "0x182B98030")]
	[AsyncStateMachine(typeof(MHFFKGPAAFI))]
	public Task<AMHDNJGMOGN> IALNBABKANO(AMHDNJGMOGN DJECALLDDIF, FAFEPBBAFLL OGCBKDBCIIM, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ, bool LNHECENLCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2B97EC0", Offset = "0x2B96CC0", VA = "0x182B97EC0")]
	[AsyncStateMachine(typeof(FOMDKIAJIKJ))]
	private Task<AMHDNJGMOGN> EFECKFJHPKM(CEJMOEANPLC PDHDLCNGDKN, AMHDNJGMOGN OPCGPJFHEJB, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2B981D0", Offset = "0x2B96FD0", VA = "0x182B981D0")]
	private bool KFHIKICEFHC(AMHDNJGMOGN JJDABIOGNHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2B97EA0", Offset = "0x2B96CA0", VA = "0x182B97EA0")]
	private void CGAIAMLGLCP(string LGEKLMLBGCB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct DJLHHOKKAPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct JDNPEFPEGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public FBNACAEIJNK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private List<(PersistenceView, IOMALNHJNIN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private (PersistenceView, IOMALNHJNIN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3429220", Offset = "0x3428020", VA = "0x183429220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2B967E0", Offset = "0x2B955E0", VA = "0x182B967E0")]
	[AsyncStateMachine(typeof(JDNPEFPEGJG))]
	public static Task BLFPKNOMADF(FBNACAEIJNK PDKFIDGDGCK, FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct GDOFNEMDPFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct HIBIDNBJJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public FBNACAEIJNK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public DJNHMPIAHIB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private MIDGADGEHKB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private List<(PersistenceView, IOMALNHJNIN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private IOMALNHJNIN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x35E9810", Offset = "0x35E8610", VA = "0x1835E9810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D940", Offset = "0x2B9C740", VA = "0x182B9D940")]
	[AsyncStateMachine(typeof(HIBIDNBJJNN))]
	public static Task BLFPKNOMADF(FBNACAEIJNK PDKFIDGDGCK, FAFEPBBAFLL JLFCOOGLPMP, DJNHMPIAHIB JLKJOHDOLND, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct KKDLOOADLNE
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public struct DCAKMHOBBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public List<CJDNBLOMJIN> LAOEOAMGOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public List<IOMALNHJNIN> BDEDKPDKHFB;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x84CA20", Offset = "0x84B820", VA = "0x18084CA20")]
		public DCAKMHOBBDG(List<CJDNBLOMJIN> LAOEOAMGOMN, List<IOMALNHJNIN> BDEDKPDKHFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class NJHKGBHJGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public IEnumerable<CJDNBLOMJIN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NJHKGBHJGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x35F0120", Offset = "0x35EEF20", VA = "0x1835F0120")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private IAJPIHCHKKO NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private FAFEPBBAFLL JLFCOOGLPMP;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private PHALPGAPCKG JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FD0", Offset = "0x2BA6DD0", VA = "0x182BA7FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7A20", Offset = "0x2BA6820", VA = "0x182BA7A20")]
	public static DCAKMHOBBDG BLFPKNOMADF(IAJPIHCHKKO NHBDFDDDAKD, FAFEPBBAFLL JLFCOOGLPMP)
	{
		return default(DCAKMHOBBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7720", Offset = "0x2BA6520", VA = "0x182BA7720")]
	private DCAKMHOBBDG BLFPKNOMADF()
	{
		return default(DCAKMHOBBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7A80", Offset = "0x2BA6880", VA = "0x182BA7A80")]
	private DCAKMHOBBDG CKBLJOJBNII(IFHIAHJKMIE BEACAGMICDF, MIDGADGEHKB KHFKLFKJGLM)
	{
		return default(DCAKMHOBBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2BA74D0", Offset = "0x2BA62D0", VA = "0x182BA74D0")]
	private bool BDGPCLMJPHE(IEnumerable<CJDNBLOMJIN> LAOEOAMGOMN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct FHGPAFLAILG
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class OBEKCJMDEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public KKDLOOADLNE.DCAKMHOBBDG instantiations;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OBEKCJMDEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x35F0EF0", Offset = "0x35EFCF0", VA = "0x1835F0EF0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class ICBKEBPBCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ICBKEBPBCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x35EA980", Offset = "0x35E9780", VA = "0x1835EA980")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C980", Offset = "0x2B9B780", VA = "0x182B9C980")]
	public static void BLFPKNOMADF(FBNACAEIJNK PDKFIDGDGCK, FAFEPBBAFLL JLFCOOGLPMP, KKDLOOADLNE.DCAKMHOBBDG ACMDELBPIAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class MPLBNHAJFEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct DOBFFJDKDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AMHDNJGMOGN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public FAFEPBBAFLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x35E5400", Offset = "0x35E4200", VA = "0x1835E5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class HBMLPFOJNHK
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
			public HBMLPFOJNHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x40F3960", Offset = "0x40F2760", VA = "0x1840F3960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CEJMOEANPLC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HBMLPFOJNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x35E92F0", Offset = "0x35E80F0", VA = "0x1835E92F0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct BCEPGLJFPDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private HBMLPFOJNHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x35E2A30", Offset = "0x35E1830", VA = "0x1835E2A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct OJEHODFHCOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private Dictionary<Guid, List<GADJMBFAGEF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x35F1240", Offset = "0x35F0040", VA = "0x1835F1240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct NKFOBGPIPDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CEJMOEANPLC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private CEJMOEANPLC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private Dictionary<Guid, List<GADJMBFAGEF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x35F01A0", Offset = "0x35EEFA0", VA = "0x1835F01A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class HKFJCHMPPHA
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
			public GADJMBFAGEF handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public HKFJCHMPPHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x40F12B0", Offset = "0x40F00B0", VA = "0x1840F12B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public FJLKHEFCOOO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public List<GADJMBFAGEF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HKFJCHMPPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x35EA4B0", Offset = "0x35E92B0", VA = "0x1835EA4B0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x35EA690", Offset = "0x35E9490", VA = "0x1835EA690")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(GADJMBFAGEF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x35EA5A0", Offset = "0x35E93A0", VA = "0x1835EA5A0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct KHLLDNCDOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public FJLKHEFCOOO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public List<GADJMBFAGEF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private HKFJCHMPPHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x35ECD50", Offset = "0x35EBB50", VA = "0x1835ECD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct AEMHLCCBADJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CEJMOEANPLC timer;

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
		[Cpp2IlInjected.Address(RVA = "0x35DEB40", Offset = "0x35DD940", VA = "0x1835DEB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class JDCHMGHDABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JDCHMGHDABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x35EB480", Offset = "0x35EA280", VA = "0x1835EB480")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct MGEGIJOEOFC : IAsyncStateMachine
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
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public FAFEPBBAFLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x35EE430", Offset = "0x35ED230", VA = "0x1835EE430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class DNPCIGPJDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public DNPCIGPJDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x35E5390", Offset = "0x35E4190", VA = "0x1835E5390")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DOLMDPFOCBH : IAsyncStateMachine
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
		public MPLBNHAJFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x35E5740", Offset = "0x35E4540", VA = "0x1835E5740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class CNIKLOMDPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public CNIKLOMDPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x35E4890", Offset = "0x35E3690", VA = "0x1835E4890")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly OGKMJPOHBDC HDMGBOHIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private KHEKEDOMIMA HFHJMHDCJLN;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private FBNACAEIJNK BFNEPCEELIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x72A700", Offset = "0x729500", VA = "0x18072A700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public MPLBNHAJFEL(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEC50", Offset = "0x2BADA50", VA = "0x182BAEC50")]
	[AsyncStateMachine(typeof(DOBFFJDKDMJ))]
	public Task BLFPKNOMADF(AMHDNJGMOGN OKFLGLEGDLB, FAFEPBBAFLL OGCBKDBCIIM, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF0D0", Offset = "0x2BADED0", VA = "0x182BAF0D0")]
	[AsyncStateMachine(typeof(BCEPGLJFPDJ))]
	private Task FBBNJAHFIHE(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF600", Offset = "0x2BAE400", VA = "0x182BAF600")]
	[AsyncStateMachine(typeof(OJEHODFHCOA))]
	private Task LIJCBKIKJID(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF230", Offset = "0x2BAE030", VA = "0x182BAF230")]
	[AsyncStateMachine(typeof(NKFOBGPIPDJ))]
	private Task GGOMHOBBMII(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEB10", Offset = "0x2BAD910", VA = "0x182BAEB10")]
	[AsyncStateMachine(typeof(KHLLDNCDOED))]
	private Task APEKNEICOFG(Guid PBCCCHIAAHH, List<GADJMBFAGEF> EFPMIAJIDIJ, FJLKHEFCOOO OGMMBDAEMPH, FAFEPBBAFLL JLFCOOGLPMP, CancellationToken JJFHDFJGCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF390", Offset = "0x2BAE190", VA = "0x182BAF390")]
	[AsyncStateMachine(typeof(AEMHLCCBADJ))]
	private Task HKEPIFJCEFB(FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF8F0", Offset = "0x2BAE6F0", VA = "0x182BAF8F0")]
	[AsyncStateMachine(typeof(MGEGIJOEOFC))]
	private Task NICBPLKGKJO(Guid HKMPJCJGPHF, FAFEPBBAFLL JLFCOOGLPMP, CEJMOEANPLC BIEDEPNABLP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEDB0", Offset = "0x2BADBB0", VA = "0x182BAEDB0")]
	[AsyncStateMachine(typeof(DOLMDPFOCBH))]
	private Task DHJMDNGFJAM(Guid HKMPJCJGPHF, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF760", Offset = "0x2BAE560", VA = "0x182BAF760")]
	private void MABCHGBFLLC(Guid HKMPJCJGPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF4E0", Offset = "0x2BAE2E0", VA = "0x182BAF4E0")]
	private void IKHECGGKMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE940", Offset = "0x2BAD740", VA = "0x182BAE940")]
	public Guid ACDEBJENPPM(AMHDNJGMOGN FEOGDHPPOIP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEF00", Offset = "0x2BADD00", VA = "0x182BAEF00")]
	[CompilerGenerated]
	private object FAKKKMBNGOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
public readonly struct ABKPGODLHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	[CanBeNull]
	public readonly IFHIAHJKMIE DHJMJKIIOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	[NotNull]
	public readonly FICOJGDGHKG GEOAOOMEPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	[CanBeNull]
	public readonly string FEAICBGMCEK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyCollection<string> CIGOBIPKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D830", Offset = "0x2B8C630", VA = "0x182B8D830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyDictionary<long, int> GMOCIFLCEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D850", Offset = "0x2B8C650", VA = "0x182B8D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D870", Offset = "0x2B8C670", VA = "0x182B8D870")]
	public ABKPGODLHEA([CanBeNull] IFHIAHJKMIE CGNEHNOPJMM, [NotNull] FICOJGDGHKG CABMBKHMALO, [CanBeNull] string DDFMKNKNADC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class GDOJNIPBOOE : NACEKBLACKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct KCMHBGDFBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder<ABKPGODLHEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public GDOJNIPBOOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CDDICEMKPIL serializeType;

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
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x35EC830", Offset = "0x35EB630", VA = "0x1835EC830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x35ECD00", Offset = "0x35EBB00", VA = "0x1835ECD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class FJLOCIIGPIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CDDICEMKPIL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FJLOCIIGPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x35E73E0", Offset = "0x35E61E0", VA = "0x1835E73E0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class GJLBBKNGIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public FJLOCIIGPIL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GJLBBKNGIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x35E9030", Offset = "0x35E7E30", VA = "0x1835E9030")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class JGGCFMNALDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public FJLOCIIGPIL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JGGCFMNALDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x35EB720", Offset = "0x35EA520", VA = "0x1835EB720")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct DAAEECCJHKA : IAsyncStateMachine
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
		public CDDICEMKPIL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public GDOJNIPBOOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private GJLBBKNGIIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private ONJFAPKGJCJ.LOCKACBIMNC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x35E4900", Offset = "0x35E3700", VA = "0x1835E4900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly LPMCFBMFCPH PJIGCIFNKDE;

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly TimeSpan MACMDOPNEIG;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EC10", Offset = "0x2B9DA10", VA = "0x182B9EC10")]
	public GDOJNIPBOOE(OGKMJPOHBDC HDMGBOHIHAK, [Optional] LPMCFBMFCPH? PJIGCIFNKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DCB0", Offset = "0x2B9CAB0", VA = "0x182B9DCB0")]
	[AsyncStateMachine(typeof(KCMHBGDFBJD))]
	public Task<ABKPGODLHEA> CLPGJOCDFOA(long KMHHOKHNCJA, string DDFMKNKNADC, CDDICEMKPIL CFLMMFKOKIC, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DFA0", Offset = "0x2B9CDA0", VA = "0x182B9DFA0")]
	[AsyncStateMachine(typeof(DAAEECCJHKA))]
	private Task KBDEAEFLEFA(CDDICEMKPIL CFLMMFKOKIC, IEnumerable<PersistenceView> HJKCJHCGMHJ, StringBuilder MPJOEMJMEBK, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E610", Offset = "0x2B9D410", VA = "0x182B9E610")]
	private ABKPGODLHEA OFJJCLKKIBK(long KMHHOKHNCJA, string DDFMKNKNADC, CDDICEMKPIL CFLMMFKOKIC, IEnumerable<PersistenceView> HJKCJHCGMHJ, StringBuilder MPJOEMJMEBK)
	{
		return default(ABKPGODLHEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DE30", Offset = "0x2B9CC30", VA = "0x182B9DE30")]
	private IFHIAHJKMIE IMJPAGKOLOK(long KMHHOKHNCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DA90", Offset = "0x2B9C890", VA = "0x182B9DA90")]
	private void CCKDOJLCLCP(IFHIAHJKMIE ANIJBIHPCED, StringBuilder MPJOEMJMEBK, IEnumerable<PersistenceView> HJKCJHCGMHJ, in KAKBDOCOCJJ FILNOJDGMDM, ref FNKKAEHEGEC KAIOJDJBLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E100", Offset = "0x2B9CF00", VA = "0x182B9E100")]
	private void KNJACNJENOG(IFHIAHJKMIE ANIJBIHPCED, StringBuilder MPJOEMJMEBK, PersistenceView BDEPBKMNBCE, ref FNKKAEHEGEC KAIOJDJBLIK, in KAKBDOCOCJJ FILNOJDGMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class MKGGJMJOFJM : NACEKBLACKE
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class GBMKCLHBOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public NFHPICNOJGF.IMJFLDFJCCH roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public NFHPICNOJGF.IMJFLDFJCCH subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GBMKCLHBOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x35E7A70", Offset = "0x35E6870", VA = "0x1835E7A70")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x35E7B00", Offset = "0x35E6900", VA = "0x1835E7B00")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x35E7B50", Offset = "0x35E6950", VA = "0x1835E7B50")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x35E7BC0", Offset = "0x35E69C0", VA = "0x1835E7BC0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct APEHOCEDNIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<(NFHPICNOJGF.IMJFLDFJCCH roomDataUpload, NFHPICNOJGF.IMJFLDFJCCH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public ABKPGODLHEA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public MKGGJMJOFJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private GBMKCLHBOKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private TaskAwaiter<NFHPICNOJGF.IMJFLDFJCCH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x35E0A10", Offset = "0x35DF810", VA = "0x1835E0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x35E14C0", Offset = "0x35E02C0", VA = "0x1835E14C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct FMBFIGMPBJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder<CFAAADDMGBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public MKGGJMJOFJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public ABKPGODLHEA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public PJOBDCFHOJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter<(NFHPICNOJGF.IMJFLDFJCCH roomDataUpload, NFHPICNOJGF.IMJFLDFJCCH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private TaskAwaiter<CFAAADDMGBE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x35E7620", Offset = "0x35E6420", VA = "0x1835E7620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x35E7A20", Offset = "0x35E6820", VA = "0x1835E7A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct PFHFJPMIFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<COJLFEIGGFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public MKGGJMJOFJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public ABKPGODLHEA roomSerializedData;

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
		private TaskAwaiter<(NFHPICNOJGF.IMJFLDFJCCH roomDataUpload, NFHPICNOJGF.IMJFLDFJCCH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter<COJLFEIGGFL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x35F2130", Offset = "0x35F0F30", VA = "0x1835F2130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x35F24C0", Offset = "0x35F12C0", VA = "0x1835F24C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class ECGIKAIJFOL
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
			public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public ECGIKAIJFOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			private FJGCNLIMCNH <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			private TaskAwaiter<COJLFEIGGFL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<CFAAADDMGBE> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private TaskAwaiter<FJGCNLIMCNH> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x40F3E40", Offset = "0x40F2C40", VA = "0x1840F3E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x40F49C0", Offset = "0x40F37C0", VA = "0x1840F49C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public MKGGJMJOFJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public ABKPGODLHEA roomSerializedData;

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
		public PJOBDCFHOJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ECGIKAIJFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x35E5CA0", Offset = "0x35E4AA0", VA = "0x1835E5CA0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FJGCNLIMCNH> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct MPFGEEEIAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AsyncTaskMethodBuilder<FJGCNLIMCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public MKGGJMJOFJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public ABKPGODLHEA roomSerializedData;

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
		public PJOBDCFHOJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private TaskAwaiter<FJGCNLIMCNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x35EF2B0", Offset = "0x35EE0B0", VA = "0x1835EF2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x35EF560", Offset = "0x35EE360", VA = "0x1835EF560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private const float FGENIEPDCAL = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private readonly IPLOKIPJJIH DMNAIEPOHCP;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private IAJPIHCHKKO GOMKGLONFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA28A0", Offset = "0x2BA16A0", VA = "0x182BA28A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC3C0", Offset = "0x2BAB1C0", VA = "0x182BAC3C0")]
	public MKGGJMJOFJM(OGKMJPOHBDC HDMGBOHIHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC0C0", Offset = "0x2BAAEC0", VA = "0x182BAC0C0")]
	[AsyncStateMachine(typeof(APEHOCEDNIJ))]
	private Task<(NFHPICNOJGF.IMJFLDFJCCH, NFHPICNOJGF.IMJFLDFJCCH)> INKCEOBLEGA(ABKPGODLHEA MFDLBBEKGKN, long HMOGFNMOLJM, long NMFONIKGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BABF30", Offset = "0x2BAAD30", VA = "0x182BABF30")]
	[AsyncStateMachine(typeof(FMBFIGMPBJK))]
	public Task<CFAAADDMGBE> HBLNPAPPPDK(int BIOCBIPJPBJ, [CanBeNull] PJOBDCFHOJN CMFBBNFPOCA, ABKPGODLHEA MFDLBBEKGKN, long HMOGFNMOLJM, long NMFONIKGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC230", Offset = "0x2BAB030", VA = "0x182BAC230")]
	[AsyncStateMachine(typeof(PFHFJPMIFJI))]
	private Task<COJLFEIGGFL> NJMFMGKDFEB(string JBJGKNEAFLJ, int BIOCBIPJPBJ, ABKPGODLHEA MFDLBBEKGKN, long HMOGFNMOLJM, long NMFONIKGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BABD80", Offset = "0x2BAAB80", VA = "0x182BABD80")]
	[AsyncStateMachine(typeof(MPFGEEEIAEM))]
	public Task<FJGCNLIMCNH> AHCCIICIIIB(int BIOCBIPJPBJ, [CanBeNull] PJOBDCFHOJN CMFBBNFPOCA, ABKPGODLHEA MFDLBBEKGKN, long HMOGFNMOLJM, long NMFONIKGFJA, CEJMOEANPLC PDHDLCNGDKN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public abstract class PONGCPEACDE<T> where T : global::PONGCPEACDE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	internal readonly IAJPIHCHKKO EFMMIJAGFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private int? BCBDGIEMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	protected readonly Guid PNLGMJCAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	protected readonly BMCDEJCGGOJ GKLDCJNMDEA;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T JLDENFELCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x30B5F20", Offset = "0x30B4D20", VA = "0x1830B5F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x30B5F80", Offset = "0x30B4D80", VA = "0x1830B5F80")]
	internal PONGCPEACDE(IAJPIHCHKKO EDOPBIFHHNM, BMCDEJCGGOJ FKHJNKOHGHH, [Optional] Guid? FCEHMDFKHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x30B5C30", Offset = "0x30B4A30", VA = "0x1830B5C30")]
	private FJGCNLIMCNH DJJFMIIANKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	protected virtual void AOIPHIPPOMK(FJGCNLIMCNH HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x30B5D10", Offset = "0x30B4B10", VA = "0x1830B5D10")]
	public T DPMMPACLLME(HHODDDLIHOO GAHFLBDIKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x30B5EA0", Offset = "0x30B4CA0", VA = "0x1830B5EA0")]
	public T MBMFBOLCPCC(int DIDBMPBKPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x30B5DA0", Offset = "0x30B4BA0", VA = "0x1830B5DA0", Slot = "5")]
	public virtual Task<EDADMNIFEBK> HCGCNBEHEAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class HKLCPKCDEDD : global::PONGCPEACDE<HKLCPKCDEDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private ENNEEGPPNHD OICHLBNIOCE;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1710", Offset = "0x2BA0510", VA = "0x182BA1710")]
	internal HKLCPKCDEDD(IAJPIHCHKKO EDOPBIFHHNM, BMCDEJCGGOJ FKHJNKOHGHH, [Optional] Guid? FCEHMDFKHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BA16F0", Offset = "0x2BA04F0", VA = "0x182BA16F0")]
	public HKLCPKCDEDD DHOBPFCNIHM(ENNEEGPPNHD OICHLBNIOCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1630", Offset = "0x2BA0430", VA = "0x182BA1630", Slot = "4")]
	protected override void AOIPHIPPOMK(FJGCNLIMCNH HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class DGPBCCKFCJO : global::PONGCPEACDE<DGPBCCKFCJO>
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	internal enum OHNKCIDHOOD
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
	private struct GFJDABIIOJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<EDADMNIFEBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public DGPBCCKFCJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<EDADMNIFEBK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3427600", Offset = "0x3426400", VA = "0x183427600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x3427900", Offset = "0x3426700", VA = "0x183427900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private OHNKCIDHOOD FDJOFGEJCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private string LHLHDGEHBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private PJOBDCFHOJN OICHLBNIOCE;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B95660", Offset = "0x2B94460", VA = "0x182B95660")]
	internal DGPBCCKFCJO(IAJPIHCHKKO EDOPBIFHHNM, BMCDEJCGGOJ FKHJNKOHGHH, [Optional] Guid? FCEHMDFKHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B955C0", Offset = "0x2B943C0", VA = "0x182B955C0")]
	public DGPBCCKFCJO IEAMJMPFBOA(string LIMGJHIDALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B95480", Offset = "0x2B94280", VA = "0x182B95480")]
	public DGPBCCKFCJO DEEFEHGIPKF(bool EPBFAMNKKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B95450", Offset = "0x2B94250", VA = "0x182B95450")]
	public DGPBCCKFCJO COHKDGLKLDI(string GEMBNOGNCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B955F0", Offset = "0x2B943F0", VA = "0x182B955F0")]
	public DGPBCCKFCJO NDNEAHPIKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B952E0", Offset = "0x2B940E0", VA = "0x182B952E0", Slot = "4")]
	protected override void AOIPHIPPOMK(FJGCNLIMCNH HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B954A0", Offset = "0x2B942A0", VA = "0x182B954A0", Slot = "5")]
	[AsyncStateMachine(typeof(GFJDABIIOJO))]
	public override Task<EDADMNIFEBK> HCGCNBEHEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B95620", Offset = "0x2B94420", VA = "0x182B95620")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EDADMNIFEBK> OHHONMEADOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal static class NEHGEFMBLDM
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x342D0B0", Offset = "0x342BEB0", VA = "0x18342D0B0")]
	public static void HIFCICJAPAP(this KBPEMCHIDOA JAKDHLBNPPE, JHCBDEANCOK JAJLANOKGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x342D030", Offset = "0x342BE30", VA = "0x18342D030")]
	public static void DCCOBGDOIOB(this JHCBDEANCOK KIBPNBFNHLL, [Optional] string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public static class MEKMNHPFAIC
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB3E0", Offset = "0x2BAA1E0", VA = "0x182BAB3E0")]
	public static MOAJEGAOKON CPAAGMKGIGH(this OGIBDGOJJJH PKLDEJDLNDH)
	{
		return default(MOAJEGAOKON);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB480", Offset = "0x2BAA280", VA = "0x182BAB480")]
	public static OGIBDGOJJJH JOKJLGHFMLD(this MOAJEGAOKON PHDPPPEFJNB)
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
			public LIALGDLIBHJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public LIALGDLIBHJ HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private static LIALGDLIBHJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private Dictionary<LIALGDLIBHJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x343A6F0", Offset = "0x34394F0", VA = "0x18343A6F0")]
		public bool DAIKKKFCGCN(LIALGDLIBHJ GDMANHPKELG, out ResultConfig GOLOEFFHKCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x343A5D0", Offset = "0x34393D0", VA = "0x18343A5D0")]
		public ResultConfig BBJDBLNJOKP(LIALGDLIBHJ LFBMHKKDNLG, [Optional] HashSet<LIALGDLIBHJ> EHPJICGPBGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x343ACE0", Offset = "0x3439AE0", VA = "0x18343ACE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x343A760", Offset = "0x3439560", VA = "0x18343A760", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AD0", Offset = "0x6D58D0", VA = "0x1806D6AD0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class EIJBGJICEHH
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B98BB0", Offset = "0x2B979B0", VA = "0x182B98BB0")]
	[IIBELCEICEH(INPGEEFAPCN.GameOnly)]
	private static void FNPDOJFFBPD(HGCFMABKDDJ JBCEHIOIAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public interface GPNEMJHGMNP : IEquatable<GPNEMJHGMNP>
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime JJKDJPPPGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGFJGLPPKCH();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHAAAEFJFKP(long HMOGFNMOLJM, long KMHHOKHNCJA, out ABKPGODLHEA MFDLBBEKGKN);
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal class NEJLIMMHLND : FCEIAEBAOBA
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class NGHKHPGLCAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public NAEECGFNFPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NGHKHPGLCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x35EFB70", Offset = "0x35EE970", VA = "0x1835EFB70")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly OHFFKGHCLCP AGDINDKLOAD;

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private const int OBNDEOIHEJA = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<GPNEMJHGMNP> JKNDCAHMDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x342D200", Offset = "0x342C000", VA = "0x18342D200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x342DC20", Offset = "0x342CA20", VA = "0x18342DC20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	[Preserve]
	public NEJLIMMHLND([MAEEAOEDELI(null)] OHFFKGHCLCP AGDINDKLOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x342D470", Offset = "0x342C270", VA = "0x18342D470", Slot = "6")]
	public bool GCAHCMDGMDI(long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN, NAEECGFNFPJ JDHHIBOGJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x342DCC0", Offset = "0x342CAC0", VA = "0x18342DCC0")]
	private void JPNBEIJIHHK(GPNEMJHGMNP KBKLCBOFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x342DD60", Offset = "0x342CB60", VA = "0x18342DD60", Slot = "7")]
	public bool LIDNDMHIFOA(long HMOGFNMOLJM, long KMHHOKHNCJA, out GPNEMJHGMNP MKGFLPPMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x342D2A0", Offset = "0x342C0A0", VA = "0x18342D2A0", Slot = "8")]
	public bool DLMJPEAGLAB(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, out GPNEMJHGMNP MKGFLPPMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x342D7C0", Offset = "0x342C5C0", VA = "0x18342D7C0")]
	private void HHACLKLEJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x342D350", Offset = "0x342C150", VA = "0x18342D350", Slot = "9")]
	public void EKNCJMEPHJO(long HMOGFNMOLJM, long KMHHOKHNCJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal abstract class PFIGDMBPMML : OHFFKGHCLCP
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	protected enum CMCBLKEAHGJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class BHHEGMBHCIM : IEnumerable<GPNEMJHGMNP>, IEnumerable, IEnumerator<GPNEMJHGMNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private GPNEMJHGMNP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public PFIGDMBPMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private NAEECGFNFPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public NAEECGFNFPJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private GPNEMJHGMNP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public BHHEGMBHCIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x40E4F50", Offset = "0x40E3D50", VA = "0x1840E4F50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x40E5160", Offset = "0x40E3F60", VA = "0x1840E5160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x40E50B0", Offset = "0x40E3EB0", VA = "0x1840E50B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GPNEMJHGMNP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x40E50B0", Offset = "0x40E3EB0", VA = "0x1840E50B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class LEIFGNANGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public NAEECGFNFPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LEIFGNANGKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x40EBC70", Offset = "0x40EAA70", VA = "0x1840EBC70")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class JIFHLGAHKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public PFIGDMBPMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JIFHLGAHKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x40E9C20", Offset = "0x40E8A20", VA = "0x1840E9C20")]
		internal void <TryReadAutosaveFile>b__0(EIACGGLDOFH.BPPAIIIKEAI ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	protected readonly string EINENODLKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly object JMAOBPBLOIP;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x3438020", Offset = "0x3436E20", VA = "0x183438020")]
	protected PFIGDMBPMML([CanBeNull] string PHGMJDDDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x3437890", Offset = "0x3436690", VA = "0x183437890", Slot = "5")]
	public bool KNDDAHJHFDD(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, out GPNEMJHGMNP KBKLCBOFMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x34377A0", Offset = "0x34365A0", VA = "0x1834377A0", Slot = "6")]
	[IteratorStateMachine(typeof(BHHEGMBHCIM))]
	public IEnumerable<GPNEMJHGMNP> DMEHDOGAMCH(NAEECGFNFPJ JDHHIBOGJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void APPNCAOPDFP(Stream IFFLOIDPBHG, long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool ANNHLMNGOOD(Stream EEJDBGMFIHD, long HMOGFNMOLJM, long KMHHOKHNCJA, EDDHNGDLEID ECFHLPDJDFI, out ABKPGODLHEA MFDLBBEKGKN);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3437A40", Offset = "0x3436840", VA = "0x183437A40", Slot = "7")]
	public GPNEMJHGMNP LENNLHADFPO(long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN, NAEECGFNFPJ JDHHIBOGJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NEMLNHLFKFL(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo MCDMDAAHFFH(NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3437820", Offset = "0x3436620", VA = "0x183437820")]
	protected void JKDNCOGBABA(EIACGGLDOFH.BPPAIIIKEAI EAABGENAEDJ, string LGEKLMLBGCB, FileInfo CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3437D70", Offset = "0x3436B70", VA = "0x183437D70")]
	internal bool PAOANALNCCA(FileInfo ODCJGOGOCKA, long HMOGFNMOLJM, long KMHHOKHNCJA, out ABKPGODLHEA MFDLBBEKGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private void ENEGNKAFIAK(Exception CCFMIAPLDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class FHDKLGNAGCI : PFIGDMBPMML
{
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private const string NLMEDNLPMFL = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private const string CENHKEDLBOA = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private const string PEADDEOAHNJ = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x1885630", Offset = "0x1884430", VA = "0x181885630", Slot = "8")]
		get
		{
			return default(CCFABBKNJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C940", Offset = "0x2B9B740", VA = "0x182B9C940")]
	public FHDKLGNAGCI([Optional] string PHGMJDDDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C6C0", Offset = "0x2B9B4C0", VA = "0x182B9C6C0")]
	private void BLOANICMODF(NAEECGFNFPJ JDHHIBOGJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C460", Offset = "0x2B9B260", VA = "0x182B9C460", Slot = "9")]
	internal override void APPNCAOPDFP(Stream IFFLOIDPBHG, long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BDF0", Offset = "0x2B9ABF0", VA = "0x182B9BDF0", Slot = "10")]
	internal override bool ANNHLMNGOOD(Stream EEJDBGMFIHD, long HMOGFNMOLJM, long KMHHOKHNCJA, EDDHNGDLEID ECFHLPDJDFI, out ABKPGODLHEA MFDLBBEKGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C850", Offset = "0x2B9B650", VA = "0x182B9C850", Slot = "11")]
	protected override FileInfo NEMLNHLFKFL(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C740", Offset = "0x2B9B540", VA = "0x182B9C740", Slot = "12")]
	protected override DirectoryInfo MCDMDAAHFFH(NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal sealed class PMMCNEOKOLH : PFIGDMBPMML
{
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private static readonly byte[] BIMCDHOFDCP;

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private const string CENHKEDLBOA = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private const string PEADDEOAHNJ = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private const string FPBBCGDKGEK = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly byte[] CEIOELPJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly byte[] KMLGKDDHIBG;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x90F070", Offset = "0x90DE70", VA = "0x18090F070", Slot = "8")]
		get
		{
			return default(CCFABBKNJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x3439BF0", Offset = "0x34389F0", VA = "0x183439BF0")]
	public PMMCNEOKOLH([Optional] string PHGMJDDDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x34395B0", Offset = "0x34383B0", VA = "0x1834395B0", Slot = "9")]
	internal override void APPNCAOPDFP(Stream IFFLOIDPBHG, long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x3438F20", Offset = "0x3437D20", VA = "0x183438F20", Slot = "10")]
	internal override bool ANNHLMNGOOD(Stream EEJDBGMFIHD, long HMOGFNMOLJM, long KMHHOKHNCJA, EDDHNGDLEID ECFHLPDJDFI, out ABKPGODLHEA MFDLBBEKGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x3439810", Offset = "0x3438610", VA = "0x183439810")]
	private void DDBIAIKICAI(byte[] EHAMCGPFFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x3439A40", Offset = "0x3438840", VA = "0x183439A40", Slot = "11")]
	protected override FileInfo NEMLNHLFKFL(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x3439920", Offset = "0x3438720", VA = "0x183439920", Slot = "12")]
	protected override DirectoryInfo MCDMDAAHFFH(NAEECGFNFPJ JDHHIBOGJMN, CMCBLKEAHGJ NPBOBALBNEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public enum CCFABBKNJLD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal class KLNFPCAPDEP : OHFFKGHCLCP
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class LGFKLPLCEOE : IEnumerable<GPNEMJHGMNP>, IEnumerable, IEnumerator<GPNEMJHGMNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private GPNEMJHGMNP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public KLNFPCAPDEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private NAEECGFNFPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public NAEECGFNFPJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private CCFABBKNJLD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerator<GPNEMJHGMNP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private GPNEMJHGMNP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public LGFKLPLCEOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x35EDA30", Offset = "0x35EC830", VA = "0x1835EDA30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x35ED660", Offset = "0x35EC460", VA = "0x1835ED660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x35EDAC0", Offset = "0x35EC8C0", VA = "0x1835EDAC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x35ED9F0", Offset = "0x35EC7F0", VA = "0x1835ED9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x35ED940", Offset = "0x35EC740", VA = "0x1835ED940", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GPNEMJHGMNP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x35ED940", Offset = "0x35EC740", VA = "0x1835ED940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly CCFABBKNJLD[] GMGGMHIFNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly Dictionary<CCFABBKNJLD, OHFFKGHCLCP> OMHDCBDPPOJ;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2BA80A0", Offset = "0x2BA6EA0", VA = "0x182BA80A0", Slot = "4")]
		get
		{
			return default(CCFABBKNJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2BA85D0", Offset = "0x2BA73D0", VA = "0x182BA85D0")]
	[Preserve]
	public KLNFPCAPDEP(params OHFFKGHCLCP[] MEHEIFJBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2BA80E0", Offset = "0x2BA6EE0", VA = "0x182BA80E0", Slot = "5")]
	public bool KNDDAHJHFDD(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, out GPNEMJHGMNP KBKLCBOFMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2BA83A0", Offset = "0x2BA71A0", VA = "0x182BA83A0")]
	private void MLIBNEAJHJH(int MLICBMGIBHK, long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8020", Offset = "0x2BA6E20", VA = "0x182BA8020", Slot = "6")]
	[IteratorStateMachine(typeof(LGFKLPLCEOE))]
	public IEnumerable<GPNEMJHGMNP> DMEHDOGAMCH(NAEECGFNFPJ JDHHIBOGJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8240", Offset = "0x2BA7040", VA = "0x182BA8240", Slot = "7")]
	public GPNEMJHGMNP LENNLHADFPO(long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN, NAEECGFNFPJ JDHHIBOGJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal static class HPGHNMCAHAC
{
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	internal const int IKMILANJKIF = 32;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2BA18C0", Offset = "0x2BA06C0", VA = "0x182BA18C0")]
	internal static byte[] EKMLLGGGLBN(byte[] EHAMCGPFFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1840", Offset = "0x2BA0640", VA = "0x182BA1840")]
	public static void CBOFJIOCDPP(Stream HPPBGHGOBLD, byte[] EPOGKPEBGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1960", Offset = "0x2BA0760", VA = "0x182BA1960")]
	public static bool JHDAIFFJOPM(Stream HPPBGHGOBLD, long JGGNOLMPMJC, EDDHNGDLEID CLKNDHPLOOO, out byte[] EJNIKNMAOBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal sealed class EMDDJGBGEAG : GPNEMJHGMNP, IEquatable<GPNEMJHGMNP>, IEquatable<EMDDJGBGEAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private readonly PFIGDMBPMML LPIMKHBPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public readonly FileInfo GPKJBCCBEFF;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xD3C970", Offset = "0xD3B770", VA = "0x180D3C970", Slot = "4")]
		get
		{
			return default(CCFABBKNJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime JJKDJPPPGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AA30", Offset = "0x2B99830", VA = "0x182B9AA30", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AB80", Offset = "0x2B99980", VA = "0x182B9AB80")]
	public EMDDJGBGEAG(PFIGDMBPMML HNMBIAJILMA, FileInfo ODCJGOGOCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AAD0", Offset = "0x2B998D0", VA = "0x182B9AAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A640", Offset = "0x2B99440", VA = "0x182B9A640", Slot = "6")]
	public void EGFJGLPPKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A600", Offset = "0x2B99400", VA = "0x182B9A600", Slot = "7")]
	public bool AHAAAEFJFKP(long HMOGFNMOLJM, long KMHHOKHNCJA, out ABKPGODLHEA MFDLBBEKGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A8B0", Offset = "0x2B996B0", VA = "0x182B9A8B0", Slot = "8")]
	public bool Equals(GPNEMJHGMNP MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A700", Offset = "0x2B99500", VA = "0x182B9A700", Slot = "9")]
	public bool Equals(EMDDJGBGEAG MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A7B0", Offset = "0x2B995B0", VA = "0x182B9A7B0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A990", Offset = "0x2B99790", VA = "0x182B9A990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2225050", Offset = "0x2223E50", VA = "0x182225050")]
	public static bool IKJLJMIELNH(EMDDJGBGEAG JDNBANCIMCP, EMDDJGBGEAG KMGMIHIGANB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2225060", Offset = "0x2223E60", VA = "0x182225060")]
	public static bool NKIHKFGIBBG(EMDDJGBGEAG JDNBANCIMCP, EMDDJGBGEAG KMGMIHIGANB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public delegate void EDDHNGDLEID(EIACGGLDOFH.BPPAIIIKEAI IHHPJFMMMFE, string HDKJDEIGPPL);
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal interface OHFFKGHCLCP
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	CCFABBKNJLD DHFOEOEDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNDDAHJHFDD(long HMOGFNMOLJM, long KMHHOKHNCJA, NAEECGFNFPJ JDHHIBOGJMN, out GPNEMJHGMNP KBKLCBOFMEN);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GPNEMJHGMNP> DMEHDOGAMCH(NAEECGFNFPJ JDHHIBOGJMN);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPNEMJHGMNP LENNLHADFPO(long HMOGFNMOLJM, long KMHHOKHNCJA, ABKPGODLHEA MFDLBBEKGKN, NAEECGFNFPJ JDHHIBOGJMN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA68B0", Offset = "0x2BA56B0", VA = "0x182BA68B0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA69C0", Offset = "0x2BA57C0", VA = "0x182BA69C0")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
